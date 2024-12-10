﻿namespace Assignments_6._1._3
{
    internal class Program
    {
        public static void MoveZeroes(int[] nums)
    {
        int nonZeroIndex = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                int temp = nums[nonZeroIndex];
                nums[nonZeroIndex] = nums[i];
                nums[i] = temp;

                nonZeroIndex++;
            }
        }
    }

    
        static void Main(string[] args)
        {
            int[] nums1 = { 0, 1, 0, 3, 12 };
            MoveZeroes(nums1);
            Console.WriteLine(string.Join(", ", nums1));  

            int[] nums2 = { 0 };
            MoveZeroes(nums2);
            Console.WriteLine(string.Join(", ", nums2)); 
        }
    }
}

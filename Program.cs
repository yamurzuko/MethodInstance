using System;

namespace MethodInstance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /////// Recursive Function //////
            // 3^4 = 3*3*3*3
            
            /*
            int result = 1;

            for (int i = 1; i < 5; i++)
            {
                result *= 3;
            }
            Console.WriteLine(result);

            Process value = new Process();
            int result1 = value.Expo(2,4);
            Console.WriteLine(result1);
            */
            
            // Extension Methods

            string str = "Ugur Can Yagmur";
            Console.WriteLine(str);

            bool result = str.CheckSpaces();
            Console.WriteLine(result);
            Console.WriteLine(str.RemoveSpaces());
            Console.WriteLine(str.ToUpperMethod());
            Console.WriteLine(str.ToLowerMethod());

            int[] array1 = {12,2,4,1,23,14,7,5,10};
            array1.SortArray();
            foreach(var item in array1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
    }
 /*
    public class Process
    {
        public int Expo(int number, int expo)
        {
            if(expo < 2)
            {
                return number;
            }
            else
            {
                return number * Expo(number, expo-1);
            }
        }
    }
 */
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveSpaces(this string param)
        {
            string[] array = param.Split(" ");
            return string.Join("",array);
        }
        public static string ToUpperMethod(this string param)
        {
            return param.ToUpper();
        }
        public static string ToLowerMethod(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

    }
    
}
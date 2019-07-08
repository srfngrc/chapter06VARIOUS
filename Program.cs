using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Ex01_02_etc
{
    //Ch06Ex01
    //class Program
    //{
    //    static void Write()
    //    {
    //        Console.WriteLine("Text output from function.");
    //    }
    //    static void Main(string[] args)
    //    {
    //        Write();
    //        Console.ReadKey();
    //    }
    //}

    //Ch06Ex02
    class Program
    {
        
        static int MaxValue(int[] intArray)
        {
            int maxVal = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > maxVal)
                    maxVal = intArray[i];
            }
            return maxVal;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            int Srfn = myArray.Max();
            int maxVal = MaxValue(myArray);
            Console.WriteLine("The maximum value in myArray is {0} and the other {1}", maxVal, Srfn);
            Console.ReadKey();
        }
    }
}

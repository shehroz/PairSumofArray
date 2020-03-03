using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4 };
            
            int[] result = SumofDualOptimize(arr, 3);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadKey();

        }

        public static int[] SumofDual(int[] arr, int sum)
        {
            int pair = 2;
            int[] res = new int[pair];
            int index = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int cal = arr[i] + arr[j];
                    if (cal == sum)
                    {
                        res[index++] = arr[i];
                        res[index++] = arr[j];
                        return res;
                    }

                }
            }
            return res;
        }

        public static int[] SumofDualOptimize(int[] arr, int sum)
        {
            int[] result = new int[2];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int comp = sum - arr[i];
                if (dict.ContainsKey(arr[i]))
                {
                    result[0] = arr[i];
                    result[1] = comp;
                    return result;
                }
                else
                {
                    if(!dict.ContainsKey(comp))
                        dict.Add(comp, arr[i]);
                }
            }
            return result;
        }

    }
}

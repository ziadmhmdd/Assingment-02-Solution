using System.Globalization;

namespace Demo
{
    // 1. Class     ->Functions
    // 2. Struct    ->Functions
    // 3.Interfaces ->Functions
    // 4. Enum


    class NewData
    {
        public int Sum;
        public int Mul;
    }

    internal class Program
    {

        //static void PrintShape()
        //{
        //    // Body
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine("^-^");
        //    }

        //}

        //static void PrintShape(int Count)
        //{
        //    // Body
        //    for (int i = 1; i <= Count; i++)
        //    {
        //        Console.WriteLine("^-^");
        //    }

        //}

        //static void PrintShape(string Pattern = "%_%", int Count = 4)
        //{
        //    // Body
        //    for (int i = 1; i <= Count; i++)
        //    {
        //        Console.WriteLine(Pattern);
        //    }

        //}

       static int SumNumbers(int Number01, int Number02)
        { 
            return Number01 + Number02;
        }


        #region // Static Void SWAp(int X, int Y)

        //static void SWAP(int X, int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;       
        //}


        static void SWAP(ref int X, ref int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }



        #endregion

        // Entry Point 

        //static int SumArray(int[] Arr)
        //{
        //    int Sum = 0;

        //    Arr[0] = 100;

        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }

        //    return Sum;
        //}


        //static int SumArray(ref int[] Arr)
        //{
        //    int Sum = 0;

        //    Arr[0] = 100;

        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }

        //    return Sum;
        //}

        //static int SumArray( int[] Arr)
        //{
        //    int Sum = 0;

        //    Arr = new int[] { 4, 5 ,6 };

        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }

        //    return Sum;
        //}

        //static int SumArray(ref int[] Arr)
        //{
        //    int Sum = 0;

        //    Arr = new int[] { 4, 5, 6 };

        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }

        //    return Sum;
        //}

        //static int[] SumMul(int X, int Y)
        //{
        //    int[] Result = { X + Y, X * Y };
        //    return Result;
        //}


        //static NewData[] SumMul(int X, int Y)
        //{
        //    NewData data = new NewData();
        //    data.Sum = X + Y;
        //    data.Mul = X * Y;

        //    return data;
        //}

        //static NewData[] SumMul(int X, int Y, out int Sum, out int Mul)
        //{
        //    Sum = X + Y;
        //    Mul = X * Y;
        //}

        static int SumArray(params int[] Arr)
        {
            int Sum = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }


        static void Main(string[] args)
        {
            #region One D Array

            int[] Numbers;
            // Declare For Reference (Pointer) From Type 'Array Of Integers'
            // Numbers : Can Refer To Object From Type 'Array Of Integers'
            // Numbers : Refer To Null

            // 8 Bytes Will Be Allocated At Stack For The Reference 'Numbers'
            // 0 Bytes Will Be Allocated At Heap


            // Numbers = new int[size];
            Numbers = new int[5];
            // new
            // 1. Allocate The Number Of Required For The Object At Heap (4 Bytes * 5)
            // 2. Initialized The Allocated Bytes With The Default Value Of The DataType
            // 3. Call User-Defined Constructor If Exists 
            // 4. Assign The Object To The Reference 'Numbers'

            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);

            //Numbers[0] = 12;
            //Numbers[1] = 6;
            //Numbers[2] = 7;
            //Numbers[3] = 11;
            //Numbers[4] = 19;
            ////Numbers[5] = 20; // Out Of Range

            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);
            //Console.WriteLine(Numbers[2]);
            //Console.WriteLine(Numbers[3]);
            //Console.WriteLine(Numbers[4]);

            //int[] Numbers01 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int[] Numbers02 = new int[4] { 1, 2, 3, 4 };
            //int[] Numbers03 = new int[6] { 1, 2, 3, 4, 0, 0 };
            //int[] Numbers04 = new int[6];

            //Console.Write("Enter Numbers[0] ");
            //Numbers[0] = int.Parse(Console.ReadLine());

            //Console.Write("Enter Numbers[1] ");
            //Numbers[1] = int.Parse(Console.ReadLine());

            //Console.Write("Enter Numbers[2] ");
            //Numbers[2] = int.Parse(Console.ReadLine());

            //Console.Write("Enter Numbers[3] ");
            //Numbers[3] = int.Parse(Console.ReadLine());

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.Write($"Enter Numbers[{i}]: ");
            //    Numbers[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("================");
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.Write($"{Numbers[1]} ");
            //}

            // One D Array

            Console.WriteLine(Numbers.Length); // Size
            Console.WriteLine(Numbers.Rank); // Dimension

            #endregion

            #region Two D Array
            // Two D Array

            int[,] Marks = new int[3, 3];

            //Marks[0, 0] = 99;
            //Marks[0, 1] = 99;
            //Marks[0, 2] = 99;

            //Marks[1, 0] = 80;
            //Marks[1, 1] = 98;
            //Marks[1, 2] = 97;

            //Marks[2, 0] = 88;
            //Marks[2, 1] = 78;
            //Marks[2, 2] = 47;

            //Console.WriteLine(Marks[0,0]);
            //Console.WriteLine(Marks[0,1]);
            //Console.WriteLine(Marks[0,2]);

            //Console.WriteLine(Marks[1, 0]);
            //Console.WriteLine(Marks[1, 1]);
            //Console.WriteLine(Marks[1, 2]);

            //Console.WriteLine(Marks[2, 0]);
            //Console.WriteLine(Marks[2, 1]);
            //Console.WriteLine(Marks[2, 2]);

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Enter Marks[{i},{j}] : ");
            //        Marks[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine();

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Enter Marks[{i},{j}] : ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Two D Array-Juddge

            ////int[][] Markss = new int[3][];
            ////Markss[0] = new int[] { 1, 2, 3 };
            ////Markss[1] = new int[] { 1, 2 };
            ////Markss[2] = new int[] { 1, 2, 3, 4 };


            //int[][] Markss = new int[3][];
            //Markss[0] = new int[2];
            //Markss[1] = new int[5];
            //Markss[2] = new int[1];

            //for (int i = 0; i < 3; i++) ;
            //{
            //    for (int j = 0; j < 3; j++) ;
            //    {
            //        Console.Write($"Markss[{i}][{j}] : ");
            //        Markss[i][j] = int.Parse(Console.ReadLine());

            //    }

            //}
            //for (int i = 0; i < 3; i++) ;
            //{
            //    for (int j = 0; j < 3; j++) ;
            //    {
            //        Console.WriteLine($"{Markss[i][j]}");

            //    }

            //}

            #endregion

            #region Function Prototype

            // Function : block Of Code That Have Name If U Need To Execute This Code 
            // U Need To Call The Function By The Name 
            // Dry 

            // Function ProtoType
            // 1. Signature
            // 1.1. Name
            // 1.2. Return Type
            // 1.3. Parameters (inputs)


            // 2. Body (Code)


            // Calling For The Functions
            //PrintShape(5,"%_%"); // Passing By Order 
            //PrintShape (Pattern: "%_%", Count: 3); // Passing By Name 
            //PrintShape(Pattern: "%_%", Count: 3); // Passing By Name 
            //PrintShape("*-*");
            //PrintShape();


            // Methods 
            // 1. Class Memeber Method (Static Method)
            // 2. Object Memeber Method (Non Static Method)

            //int Sum = SumNumbers(2, 3);
            // Console.WriteLine(Sum);

            //Console.WriteLine(SumNumbers(2, 3));
            // SumNumbers(10, 20);
            #endregion

            #region Passing Parameter Value Type

            // Passing BY Value
            // Passing By Reference 



            // Passing Parameter Value Type
            // 1. Passing By Value

            //int A = 4, B = 5;
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            //Console.WriteLine("----After Swap----");

            ////SWAP(4, 5); // Passing By Value 
            //SWAP(A, B); // Passing By Value 

            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");




            // 2. Passing By Ref

            //int A = 4, B = 5;
            //Console.WriteLine($"A : {A}"); // 4
            //Console.WriteLine($"B : {B}"); // 5

            //Console.WriteLine("----After Swap----");

            ////SWAP(A, B); // Passing By ref 
            //SWAP(ref A, ref B); // Passing ref 

            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");
            #endregion

            #region Passing Parameter Reference Type
            // Passing Parameters Reference Type

            // 1. Passing By Value

            //int[] Number = { 1, 2, 3 };

            //int Result = SumArray(Number); // Passing By Value

            //Console.WriteLine(Result);
            //Console.WriteLine(Number[0]);




            // 2. Passing By Reference

            //int[] Number = { 1, 2, 3 };

            //int Result = SumArray( ref Numbers); // Passing By Ref
            //// The Address Of The Numbers

            //Console.WriteLine(Result);
            //Console.WriteLine(Numbers[0]); 
            #endregion

            #region Passing Parameter Reference Type
            // Passing Parameters Reference Type 

            //int[] Number = { 1, 2, 3 };

            //Console.WriteLine(SumArray(Number)); // Passing By Value
            //Console.WriteLine(Number[0]);

            //int[] Number = { 1, 2, 3 };

            //Console.WriteLine(SumArray(ref Number)); // Passing By Value
            //// Copy Of Number
            //Console.WriteLine(Number[0]); 
            #endregion

            #region Passing By_Out
            //int A = 3, B = 4;

            //int[] Result = SumMul(A, B);


            //Console.WriteLine(Result[0]);
            //Console.WriteLine(Result[1]);

            //int A = 3, B = 4;

            //NewData Result = SumMul(A, B);


            //Console.WriteLine(Result.Mul);
            //Console.WriteLine(Result.Sum);


            // Output Parameters 

            // Passing By Out

            //int A = 4, B = 5, Sum, Mul;

            //SumMul(A, B, out Sum, out Mul);

            //Console.WriteLine(Sum);
            //Console.WriteLine(Mul);

            //int A = 4, B = 5;

            //SumMul(A, B, out int Sum, out int Mul);

            //Console.WriteLine(Sum);
            //Console.WriteLine(Mul);

            //int A = 4, B = 5;

            //SumMul(A, B, out int Sum, out _);

            //Console.WriteLine(Sum);
            ////Console.WriteLine(Mul); 
            #endregion

            #region Params
            // Params


            int[] Number = { 1, 3, 4, 5, 6, 7, };

            Console.WriteLine(SumArray(1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 12)); 
            #endregion



        }
    }   }




            

            


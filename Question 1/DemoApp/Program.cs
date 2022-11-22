
int num = 0;
int s = int.Parse(args[0]);

var comp = new Computation(s);



Console.WriteLine($"The sum of Odd are : {comp.GetSumOf(num, s, comp.isOdd)}");

Console.WriteLine($"The sum of Even are : {comp.GetSumOf(num, s, comp.isEven)}");

Console.WriteLine($"The sum of Prime are : {comp.GetSumOf(num, s, comp.isPrime)}");

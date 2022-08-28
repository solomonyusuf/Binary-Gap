

int val = 9;
solution(val);

int solution(int N)
{
    var value = 0;
    var result = new List<int>();
    var num = Convert.ToString(N, 2);

    foreach (var n in num)
    {
        if (n.Equals("0"))
        {
            var a = value++;
            value = 0;
        }
        else
        {
            result.Add(value);
        }
    }

    return result.Max();
}
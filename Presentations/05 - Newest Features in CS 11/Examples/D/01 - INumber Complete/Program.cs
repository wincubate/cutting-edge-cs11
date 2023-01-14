var sequence = new[] { 42, 87, 112, 176 };
Console.WriteLine( AddSequence(sequence));

static int AddSequence( IEnumerable<int> sequence )
{
    int total = 0;
	foreach (var i in sequence)
	{
		total += i;
	}

	return total;
}
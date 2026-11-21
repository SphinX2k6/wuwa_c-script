using System;
using System.Runtime.CompilerServices;

// Token: 0x02002ABF RID: 10943
public class ScoreNode<[Nullable(1)] T> where T : class, new()
{
	// Token: 0x0400F00F RID: 61455
	[Nullable(2)]
	public T Item;

	// Token: 0x0400F010 RID: 61456
	public double Score;
}

using System;
using System.Runtime.CompilerServices;

// Token: 0x0200354A RID: 13642
public class ScoreNode<[Nullable(1)] T> where T : class, new()
{
	// Token: 0x0400EB52 RID: 60242
	[Nullable(2)]
	public T Item;

	// Token: 0x0400EB53 RID: 60243
	public double Score;
}

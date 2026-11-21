using System;
using System.Runtime.CompilerServices;

// Token: 0x02000051 RID: 81
[NullableContext(1)]
[Nullable(0)]
internal class LruNode<[Nullable(2)] TK, TV> where TV : class
{
	// Token: 0x0600024E RID: 590 RVA: 0x0000CC3A File Offset: 0x0000AE3A
	public LruNode(TK key, TV value)
	{
		this.Key = key;
		this.Value = value;
	}

	// Token: 0x040001C7 RID: 455
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public LruNode<TK, TV> Prev;

	// Token: 0x040001C8 RID: 456
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public LruNode<TK, TV> Next;

	// Token: 0x040001C9 RID: 457
	public int Count;

	// Token: 0x040001CA RID: 458
	public readonly TK Key;

	// Token: 0x040001CB RID: 459
	public readonly TV Value;
}

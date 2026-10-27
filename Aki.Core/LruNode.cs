using System;
using System.Runtime.CompilerServices;

// Token: 0x02000051 RID: 81
[NullableContext(1)]
[Nullable(0)]
internal class LruNode<[Nullable(2)] TK, TV> where TV : class
{
	// Token: 0x0600024D RID: 589 RVA: 0x0000CF56 File Offset: 0x0000B156
	public LruNode(TK key, TV value)
	{
		this.Key = key;
		this.Value = value;
	}

	// Token: 0x040001C5 RID: 453
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public LruNode<TK, TV> Prev;

	// Token: 0x040001C6 RID: 454
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public LruNode<TK, TV> Next;

	// Token: 0x040001C7 RID: 455
	public int Count;

	// Token: 0x040001C8 RID: 456
	public readonly TK Key;

	// Token: 0x040001C9 RID: 457
	public readonly TV Value;
}

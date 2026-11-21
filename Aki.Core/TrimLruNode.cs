using System;
using System.Runtime.CompilerServices;

// Token: 0x02000063 RID: 99
[NullableContext(1)]
[Nullable(0)]
public class TrimLruNode<[Nullable(2)] TK, TV> where TV : class
{
	// Token: 0x06000316 RID: 790 RVA: 0x00010A98 File Offset: 0x0000EC98
	public TrimLruNode(TK key, TV value, int size)
	{
		this.Key = key;
		this.Value = value;
		this.Size = size;
	}

	// Token: 0x04000218 RID: 536
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public TrimLruNode<TK, TV> Prev;

	// Token: 0x04000219 RID: 537
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public TrimLruNode<TK, TV> Next;

	// Token: 0x0400021A RID: 538
	public int Count;

	// Token: 0x0400021B RID: 539
	public readonly TK Key;

	// Token: 0x0400021C RID: 540
	public readonly TV Value;

	// Token: 0x0400021D RID: 541
	public readonly int Size;
}

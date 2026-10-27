using System;
using System.Runtime.CompilerServices;

// Token: 0x02000061 RID: 97
[NullableContext(1)]
[Nullable(0)]
public class TrimLruNode<[Nullable(2)] TK, TV> where TV : class
{
	// Token: 0x060002DB RID: 731 RVA: 0x0000FCB0 File Offset: 0x0000DEB0
	public TrimLruNode(TK key, TV value, int size)
	{
		this.Key = key;
		this.Value = value;
		this.Size = size;
	}

	// Token: 0x04000202 RID: 514
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public TrimLruNode<TK, TV> Prev;

	// Token: 0x04000203 RID: 515
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public TrimLruNode<TK, TV> Next;

	// Token: 0x04000204 RID: 516
	public int Count;

	// Token: 0x04000205 RID: 517
	public readonly TK Key;

	// Token: 0x04000206 RID: 518
	public readonly TV Value;

	// Token: 0x04000207 RID: 519
	public readonly int Size;
}

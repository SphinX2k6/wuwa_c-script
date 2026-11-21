using System;
using System.Runtime.CompilerServices;

// Token: 0x0200005E RID: 94
[NullableContext(2)]
[Nullable(0)]
internal class RbNode<T>
{
	// Token: 0x060002EB RID: 747 RVA: 0x0000F868 File Offset: 0x0000DA68
	[NullableContext(1)]
	public void BreakChildLink(RbNode<T> node)
	{
		if (this.Left == node)
		{
			this.Left = null;
			return;
		}
		if (this.Right == node)
		{
			this.Right = null;
			return;
		}
		Log.Instance.Error(ELogModule.Core, ELogAuthor.LCZ, "待移除的节点并非其子节点", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x060002EC RID: 748 RVA: 0x0000F8B1 File Offset: 0x0000DAB1
	public void Clear()
	{
		this.Parent = null;
		this.Left = null;
		this.Right = null;
		this.Item = default(T);
		this.IsRed = false;
	}

	// Token: 0x04000209 RID: 521
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public RbNode<T> Parent;

	// Token: 0x0400020A RID: 522
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public RbNode<T> Left;

	// Token: 0x0400020B RID: 523
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public RbNode<T> Right;

	// Token: 0x0400020C RID: 524
	public T Item;

	// Token: 0x0400020D RID: 525
	public bool IsRed;
}

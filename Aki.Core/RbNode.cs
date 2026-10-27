using System;
using System.Runtime.CompilerServices;

// Token: 0x0200005C RID: 92
[NullableContext(2)]
[Nullable(0)]
internal class RbNode<T>
{
	// Token: 0x060002B0 RID: 688 RVA: 0x0000EA80 File Offset: 0x0000CC80
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

	// Token: 0x060002B1 RID: 689 RVA: 0x0000EAC9 File Offset: 0x0000CCC9
	public void Clear()
	{
		this.Parent = null;
		this.Left = null;
		this.Right = null;
		this.Item = default(T);
		this.IsRed = false;
	}

	// Token: 0x040001F3 RID: 499
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public RbNode<T> Parent;

	// Token: 0x040001F4 RID: 500
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public RbNode<T> Left;

	// Token: 0x040001F5 RID: 501
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public RbNode<T> Right;

	// Token: 0x040001F6 RID: 502
	public T Item;

	// Token: 0x040001F7 RID: 503
	public bool IsRed;
}

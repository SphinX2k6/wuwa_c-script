using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000060 RID: 96
[NullableContext(1)]
[Nullable(0)]
public class Tree<[Nullable(2)] T>
{
	// Token: 0x060002D2 RID: 722 RVA: 0x0000FAB4 File Offset: 0x0000DCB4
	public Tree(T element, [Nullable(new byte[]
	{
		2,
		1
	})] Tree<T> parent = null)
	{
		this.Element = element;
		this.Parent = parent;
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000FACA File Offset: 0x0000DCCA
	public Dictionary<T, Tree<T>> ChildMap
	{
		get
		{
			if (this.ChildMapInternal == null)
			{
				this.ChildMapInternal = new Dictionary<T, Tree<T>>();
			}
			return this.ChildMapInternal;
		}
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x0000FAE8 File Offset: 0x0000DCE8
	public void AddChild(Tree<T> child)
	{
		T element = child.Element;
		if (this.ChildMap.ContainsKey(element))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RedDot;
			ELogAuthor author = ELogAuthor.TL;
			string message = "重复添加子节点！";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("element", element);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		child.Parent = this;
		this.ChildMap[element] = child;
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x0000FB4C File Offset: 0x0000DD4C
	public void AddChildElement(T element)
	{
		if (this.ChildMap.ContainsKey(element))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RedDot;
			ELogAuthor author = ELogAuthor.TL;
			string message = "重复添加子节点！";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("element", element);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		Tree<T> tree = new Tree<T>(element, this);
		tree.Parent = this;
		this.ChildMap[element] = tree;
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x0000FBB0 File Offset: 0x0000DDB0
	public void AddParent(Tree<T> parent)
	{
		if (this.Parent != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RedDot;
			ELogAuthor author = ELogAuthor.TL;
			string message = "该节点已存在父节点！";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("element", this.Element);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.Parent = parent;
		parent.ChildMap[this.Element] = this;
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x0000FC10 File Offset: 0x0000DE10
	public void AddParentElement(T element)
	{
		if (this.Parent != null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RedDot;
			ELogAuthor author = ELogAuthor.TL;
			string message = "该节点已存在父节点！";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("element", this.Element);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.Parent = new Tree<T>(element, null);
		this.Parent.ChildMap[this.Element] = this;
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x0000FC7B File Offset: 0x0000DE7B
	public Tree<T> GetRoot()
	{
		if (this.Parent == null)
		{
			return this;
		}
		return this.Parent.GetRoot();
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x0000FC92 File Offset: 0x0000DE92
	public bool IsRoot()
	{
		return this.Parent == null;
	}

	// Token: 0x060002DA RID: 730 RVA: 0x0000FC9D File Offset: 0x0000DE9D
	public bool IsLeaf()
	{
		return this.ChildMap.Count <= 0;
	}

	// Token: 0x040001FF RID: 511
	public T Element;

	// Token: 0x04000200 RID: 512
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Tree<T> Parent;

	// Token: 0x04000201 RID: 513
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<T, Tree<T>> ChildMapInternal;
}

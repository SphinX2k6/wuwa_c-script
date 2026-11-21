using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000062 RID: 98
[NullableContext(1)]
[Nullable(0)]
public class Tree<[Nullable(2)] T>
{
	// Token: 0x0600030D RID: 781 RVA: 0x0001089C File Offset: 0x0000EA9C
	public Tree(T element, [Nullable(new byte[]
	{
		2,
		1
	})] Tree<T> parent = null)
	{
		this.Element = element;
		this.Parent = parent;
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x0600030E RID: 782 RVA: 0x000108B2 File Offset: 0x0000EAB2
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

	// Token: 0x0600030F RID: 783 RVA: 0x000108D0 File Offset: 0x0000EAD0
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

	// Token: 0x06000310 RID: 784 RVA: 0x00010934 File Offset: 0x0000EB34
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

	// Token: 0x06000311 RID: 785 RVA: 0x00010998 File Offset: 0x0000EB98
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

	// Token: 0x06000312 RID: 786 RVA: 0x000109F8 File Offset: 0x0000EBF8
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

	// Token: 0x06000313 RID: 787 RVA: 0x00010A63 File Offset: 0x0000EC63
	public Tree<T> GetRoot()
	{
		if (this.Parent == null)
		{
			return this;
		}
		return this.Parent.GetRoot();
	}

	// Token: 0x06000314 RID: 788 RVA: 0x00010A7A File Offset: 0x0000EC7A
	public bool IsRoot()
	{
		return this.Parent == null;
	}

	// Token: 0x06000315 RID: 789 RVA: 0x00010A85 File Offset: 0x0000EC85
	public bool IsLeaf()
	{
		return this.ChildMap.Count <= 0;
	}

	// Token: 0x04000215 RID: 533
	public T Element;

	// Token: 0x04000216 RID: 534
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Tree<T> Parent;

	// Token: 0x04000217 RID: 535
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	private Dictionary<T, Tree<T>> ChildMapInternal;
}

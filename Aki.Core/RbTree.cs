using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

// Token: 0x0200005F RID: 95
[NullableContext(1)]
[Nullable(0)]
public class RbTree<[Nullable(2)] T>
{
	// Token: 0x060002EE RID: 750 RVA: 0x0000F8E3 File Offset: 0x0000DAE3
	public RbTree(Comparison<T> compare)
	{
		this.Compare = compare;
	}

	// Token: 0x060002EF RID: 751 RVA: 0x0000F908 File Offset: 0x0000DB08
	public void Clear()
	{
		foreach (KeyValuePair<T, RbNode<T>> keyValuePair in this.ItemNodeMap)
		{
			RbNode<T> value = keyValuePair.Value;
			value.Clear();
			this.NodePool.Add(value);
		}
		this.ItemNodeMap.Clear();
		this.Count = 0;
		this.Root = null;
		this.ExtremelyLeftInternal = null;
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x060002F0 RID: 752 RVA: 0x0000F990 File Offset: 0x0000DB90
	public bool IsEmpty
	{
		get
		{
			return this.Root == null;
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x060002F1 RID: 753 RVA: 0x0000F99B File Offset: 0x0000DB9B
	public int Size
	{
		get
		{
			return this.Count;
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x060002F2 RID: 754 RVA: 0x0000F9A4 File Offset: 0x0000DBA4
	[Nullable(2)]
	public T ExtremelyLeft
	{
		[NullableContext(2)]
		get
		{
			if (this.ExtremelyLeftInternal == null)
			{
				return default(T);
			}
			return this.ExtremelyLeftInternal.Item;
		}
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x0000F9CE File Offset: 0x0000DBCE
	public void RemoveExtremelyLeft()
	{
		this.RemoveInternal(this.ExtremelyLeftInternal);
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x0000F9DC File Offset: 0x0000DBDC
	public void Insert(T item)
	{
		if (this.ItemNodeMap.ContainsKey(item))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Core;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "Item已经在RbTree里面了";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Item", item);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		RbNode<T> rbNode = null;
		if (this.NodePool.Count > 0)
		{
			rbNode = this.NodePool[this.NodePool.Count - 1];
			this.NodePool.RemoveAt(this.NodePool.Count - 1);
		}
		if (rbNode == null)
		{
			rbNode = new RbNode<T>();
		}
		rbNode.Item = item;
		rbNode.IsRed = true;
		this.InsertInternal(rbNode);
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x0000FA84 File Offset: 0x0000DC84
	public void Remove(T item)
	{
		RbNode<T> deleteNode;
		if (!this.ItemNodeMap.TryGetValue(item, out deleteNode))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Core;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "Item不在RbTree里面";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Item", item);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.RemoveInternal(deleteNode);
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x0000FAD4 File Offset: 0x0000DCD4
	private void InsertInternal(RbNode<T> newNode)
	{
		this.Count++;
		this.ItemNodeMap[newNode.Item] = newNode;
		if (this.Root == null)
		{
			this.Root = newNode;
			this.Root.IsRed = false;
			this.ExtremelyLeftInternal = newNode;
			return;
		}
		RbNode<T> rbNode = this.Root;
		for (;;)
		{
			if (this.Compare(newNode.Item, rbNode.Item) < 0)
			{
				if (rbNode.Left == null)
				{
					break;
				}
				rbNode = rbNode.Left;
			}
			else
			{
				if (rbNode.Right == null)
				{
					goto Block_4;
				}
				rbNode = rbNode.Right;
			}
		}
		rbNode.Left = newNode;
		newNode.Parent = rbNode;
		goto IL_A6;
		Block_4:
		rbNode.Right = newNode;
		newNode.Parent = rbNode;
		IL_A6:
		this.FixUp(newNode);
		this.FindRootAndExtremelyLeft();
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x0000FB94 File Offset: 0x0000DD94
	private void RemoveInternal(RbNode<T> deleteNode)
	{
		this.Count--;
		this.ItemNodeMap.Remove(deleteNode.Item);
		RbNode<T> rbNode = deleteNode;
		while (rbNode.Left != null || rbNode.Right != null)
		{
			int num = 0;
			RbNode<T> rbNode2 = rbNode.Left;
			if (rbNode2 != null)
			{
				num = 1;
				while (rbNode2.Right != null)
				{
					num++;
					rbNode2 = rbNode2.Right;
				}
			}
			int num2 = 0;
			RbNode<T> rbNode3 = rbNode.Right;
			if (rbNode3 != null)
			{
				num2 = 1;
				while (rbNode3.Left != null)
				{
					num2++;
					rbNode3 = rbNode3.Left;
				}
			}
			if (num >= num2)
			{
				rbNode.Item = rbNode2.Item;
				this.ItemNodeMap[rbNode.Item] = rbNode;
				rbNode = rbNode2;
			}
			else
			{
				rbNode.Item = rbNode3.Item;
				this.ItemNodeMap[rbNode.Item] = rbNode;
				rbNode = rbNode3;
			}
		}
		RbNode<T> parent = rbNode.Parent;
		if (parent == null)
		{
			this.Root = null;
			this.ExtremelyLeftInternal = null;
			rbNode.Clear();
			this.NodePool.Add(rbNode);
			return;
		}
		if (this.ExtremelyLeftInternal == rbNode)
		{
			this.ExtremelyLeftInternal = parent;
		}
		if (rbNode.IsRed)
		{
			parent.BreakChildLink(rbNode);
			rbNode.Clear();
			this.NodePool.Add(rbNode);
			return;
		}
		bool isLeftInput = parent.Left == rbNode;
		parent.BreakChildLink(rbNode);
		rbNode.Clear();
		this.NodePool.Add(rbNode);
		this.AfterRemove(parent, isLeftInput);
		this.FindRootAndExtremelyLeft();
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x0000FD0C File Offset: 0x0000DF0C
	private void FixUp(RbNode<T> node)
	{
		this.Root.IsRed = false;
		RbNode<T> rbNode = node;
		while (rbNode.IsRed && rbNode.Parent != null)
		{
			RbNode<T> parent = rbNode.Parent;
			if (!parent.IsRed)
			{
				RbNode<T> left = parent.Left;
				if (left == null || !left.IsRed)
				{
					break;
				}
				RbNode<T> right = parent.Right;
				if (right == null || !right.IsRed)
				{
					break;
				}
				parent.Left.IsRed = false;
				parent.Right.IsRed = false;
				parent.IsRed = true;
				rbNode = parent;
			}
			else
			{
				RbNode<T> parent2 = parent.Parent;
				RbNode<T> left2 = parent2.Left;
				if (left2 != null && left2.IsRed)
				{
					RbNode<T> right2 = parent2.Right;
					if (right2 != null && right2.IsRed)
					{
						parent2.Left.IsRed = false;
						parent2.Right.IsRed = false;
						parent2.IsRed = true;
						rbNode = parent2;
						continue;
					}
				}
				if (rbNode == parent.Left)
				{
					if (parent2.Left == parent)
					{
						rbNode.IsRed = false;
						this.RotateL(parent2);
						rbNode = parent;
					}
					else
					{
						parent.IsRed = false;
						this.RotateL(parent);
						this.RotateR(parent2);
					}
				}
				else if (parent2.Left == parent)
				{
					parent.IsRed = false;
					this.RotateR(parent);
					this.RotateL(parent2);
				}
				else
				{
					rbNode.IsRed = false;
					this.RotateR(parent2);
					rbNode = parent;
				}
			}
		}
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x0000FE60 File Offset: 0x0000E060
	private void AfterRemove(RbNode<T> node, bool isLeftInput)
	{
		bool flag = isLeftInput;
		RbNode<T> rbNode = node;
		while (rbNode != null)
		{
			if (rbNode.IsRed)
			{
				if (flag)
				{
					rbNode.IsRed = false;
					rbNode.Right.IsRed = true;
					RbNode<T> left = rbNode.Right.Left;
					if (left != null && left.IsRed)
					{
						this.FixUp(rbNode.Right.Left);
						return;
					}
					RbNode<T> right = rbNode.Right.Right;
					if (right != null && right.IsRed)
					{
						this.FixUp(rbNode.Right.Right);
						return;
					}
					break;
				}
				else
				{
					rbNode.IsRed = false;
					rbNode.Left.IsRed = true;
					RbNode<T> left2 = rbNode.Left.Left;
					if (left2 != null && left2.IsRed)
					{
						this.FixUp(rbNode.Left.Left);
						return;
					}
					RbNode<T> right2 = rbNode.Left.Right;
					if (right2 != null && right2.IsRed)
					{
						this.FixUp(rbNode.Left.Right);
						return;
					}
					break;
				}
			}
			else
			{
				if (flag)
				{
					if (rbNode.Right.IsRed)
					{
						rbNode.Right.IsRed = false;
						RbNode<T> left3 = rbNode.Right.Left;
						left3.IsRed = true;
						this.RotateR(rbNode);
						RbNode<T> left4 = left3.Left;
						if (left4 != null && left4.IsRed)
						{
							this.FixUp(left3.Left);
							return;
						}
						RbNode<T> right3 = left3.Right;
						if (right3 != null && right3.IsRed)
						{
							this.FixUp(left3.Right);
							return;
						}
						break;
					}
					else
					{
						RbNode<T> right4 = rbNode.Right.Right;
						if (right4 != null && right4.IsRed)
						{
							rbNode.Right.Right.IsRed = false;
							this.RotateR(rbNode);
							return;
						}
						RbNode<T> left5 = rbNode.Right.Left;
						if (left5 != null && left5.IsRed)
						{
							rbNode.Right.Left.IsRed = false;
							this.RotateL(rbNode.Right);
							this.RotateR(rbNode);
							return;
						}
						rbNode.Right.IsRed = true;
					}
				}
				else if (rbNode.Left.IsRed)
				{
					rbNode.Left.IsRed = false;
					RbNode<T> right5 = rbNode.Left.Right;
					right5.IsRed = true;
					this.RotateL(rbNode);
					RbNode<T> right6 = right5.Right;
					if (right6 != null && right6.IsRed)
					{
						this.FixUp(right5.Right);
						return;
					}
					RbNode<T> left6 = right5.Left;
					if (left6 != null && left6.IsRed)
					{
						this.FixUp(right5.Left);
						return;
					}
					break;
				}
				else
				{
					RbNode<T> left7 = rbNode.Left.Left;
					if (left7 != null && left7.IsRed)
					{
						rbNode.Left.Left.IsRed = false;
						this.RotateL(rbNode);
						return;
					}
					RbNode<T> right7 = rbNode.Left.Right;
					if (right7 != null && right7.IsRed)
					{
						rbNode.Left.Right.IsRed = false;
						this.RotateR(rbNode.Left);
						this.RotateL(rbNode);
						return;
					}
					rbNode.Left.IsRed = true;
				}
				if (rbNode.Parent == null)
				{
					break;
				}
				flag = (rbNode.Parent.Left == rbNode);
				rbNode = rbNode.Parent;
			}
		}
	}

	// Token: 0x060002FA RID: 762 RVA: 0x00010174 File Offset: 0x0000E374
	private void FindRootAndExtremelyLeft()
	{
		while (this.Root.Parent != null)
		{
			this.Root = this.Root.Parent;
		}
		this.Root.IsRed = false;
		for (;;)
		{
			RbNode<T> parent = this.ExtremelyLeftInternal.Parent;
			if (((parent != null) ? parent.Right : null) != this.ExtremelyLeftInternal)
			{
				break;
			}
			this.ExtremelyLeftInternal = this.ExtremelyLeftInternal.Parent;
		}
		while (this.ExtremelyLeftInternal.Left != null)
		{
			this.ExtremelyLeftInternal = this.ExtremelyLeftInternal.Left;
		}
	}

	// Token: 0x060002FB RID: 763 RVA: 0x00010200 File Offset: 0x0000E400
	private void RotateL(RbNode<T> node)
	{
		RbNode<T> parent = node.Parent;
		RbNode<T> left = node.Left;
		RbNode<T> right = left.Right;
		left.Parent = parent;
		left.Right = node;
		node.Parent = left;
		node.Left = right;
		if (right != null)
		{
			right.Parent = node;
		}
		if (parent == null)
		{
			return;
		}
		if (parent.Left == node)
		{
			parent.Left = left;
			return;
		}
		parent.Right = left;
	}

	// Token: 0x060002FC RID: 764 RVA: 0x00010264 File Offset: 0x0000E464
	private void RotateR(RbNode<T> node)
	{
		RbNode<T> parent = node.Parent;
		RbNode<T> right = node.Right;
		RbNode<T> left = right.Left;
		right.Parent = parent;
		right.Left = node;
		node.Parent = right;
		node.Right = left;
		if (left != null)
		{
			left.Parent = node;
		}
		if (parent == null)
		{
			return;
		}
		if (parent.Left == node)
		{
			parent.Left = right;
			return;
		}
		parent.Right = right;
	}

	// Token: 0x060002FD RID: 765 RVA: 0x000102C8 File Offset: 0x0000E4C8
	public void ForEach(Func<T, bool> callback)
	{
		if (this.Root == null)
		{
			return;
		}
		RbNode<T> rbNode = this.ExtremelyLeftInternal;
		while (rbNode != null)
		{
			if (!callback(rbNode.Item))
			{
				return;
			}
			if (rbNode.Right != null)
			{
				rbNode = rbNode.Right;
				while (rbNode.Left != null)
				{
					rbNode = rbNode.Left;
				}
			}
			else
			{
				if (rbNode.Parent == null)
				{
					return;
				}
				while (rbNode.Parent != null)
				{
					if (rbNode == rbNode.Parent.Left)
					{
						rbNode = rbNode.Parent;
						break;
					}
					rbNode = rbNode.Parent;
					if (this.Root == rbNode)
					{
						return;
					}
				}
			}
		}
	}

	// Token: 0x060002FE RID: 766 RVA: 0x00010354 File Offset: 0x0000E554
	public void ForEachReverse(Func<T, bool> callback)
	{
		if (this.Root == null)
		{
			return;
		}
		RbNode<T> rbNode = this.Root;
		while (rbNode.Right != null)
		{
			rbNode = rbNode.Right;
		}
		while (rbNode != null)
		{
			if (!callback(rbNode.Item))
			{
				return;
			}
			if (rbNode.Left != null)
			{
				rbNode = rbNode.Left;
				while (rbNode.Right != null)
				{
					rbNode = rbNode.Right;
				}
			}
			else
			{
				if (rbNode.Parent == null)
				{
					return;
				}
				while (rbNode.Parent != null)
				{
					if (rbNode == rbNode.Parent.Right)
					{
						rbNode = rbNode.Parent;
						break;
					}
					rbNode = rbNode.Parent;
					if (this.Root == rbNode)
					{
						return;
					}
				}
			}
		}
	}

	// Token: 0x060002FF RID: 767 RVA: 0x000103F4 File Offset: 0x0000E5F4
	public void ForEachFrom(T from, Func<T, bool> callback)
	{
		if (this.Root == null)
		{
			return;
		}
		RbNode<T> rbNode;
		if (!this.ItemNodeMap.TryGetValue(from, out rbNode))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Core;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "From不在RbTree里面";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("From", from);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		while (rbNode != null)
		{
			if (!callback(rbNode.Item))
			{
				return;
			}
			if (rbNode.Right != null)
			{
				rbNode = rbNode.Right;
				while (rbNode.Left != null)
				{
					rbNode = rbNode.Left;
				}
			}
			else
			{
				if (rbNode.Parent == null)
				{
					return;
				}
				while (rbNode.Parent != null)
				{
					if (rbNode == rbNode.Parent.Left)
					{
						rbNode = rbNode.Parent;
						break;
					}
					rbNode = rbNode.Parent;
					if (this.Root == rbNode)
					{
						return;
					}
				}
			}
		}
	}

	// Token: 0x06000300 RID: 768 RVA: 0x000104B8 File Offset: 0x0000E6B8
	public bool CheckRbTree()
	{
		if (this.Root == null)
		{
			return true;
		}
		if (this.Root.Parent != null || this.Root.IsRed)
		{
			return false;
		}
		RbNode<T> rbNode = this.Root;
		while (rbNode.Left != null)
		{
			rbNode = rbNode.Left;
		}
		if (rbNode != this.ExtremelyLeftInternal)
		{
			Log.Instance.Error(ELogModule.Core, ELogAuthor.LCZ, "Extremely Left Error.", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		Queue<RbNode<T>> queue = new Queue<RbNode<T>>(4);
		queue.Push(this.Root);
		Queue<int> queue2 = new Queue<int>(4);
		queue2.Push(1);
		int num = -1;
		while (!queue.Empty)
		{
			RbNode<T> rbNode2 = queue.Pop();
			int num2 = queue2.Pop();
			if (rbNode2.Left == null || rbNode2.Right == null)
			{
				if (num < 0)
				{
					num = num2;
				}
				else if (num != num2)
				{
					return false;
				}
			}
			if (rbNode2.Left != null)
			{
				if (rbNode2.Left.IsRed && rbNode2.IsRed)
				{
					return false;
				}
				queue.Push(rbNode2.Left);
				queue2.Push(rbNode2.Left.IsRed ? num2 : (num2 + 1));
			}
			if (rbNode2.Right != null)
			{
				if (rbNode2.Right.IsRed && rbNode2.IsRed)
				{
					return false;
				}
				queue.Push(rbNode2.Right);
				queue2.Push(rbNode2.Right.IsRed ? num2 : (num2 + 1));
			}
		}
		return true;
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00010628 File Offset: 0x0000E828
	public void PrintRbTree()
	{
		if (this.Root == null)
		{
			return;
		}
		Queue<RbNode<T>> queue = new Queue<RbNode<T>>(4);
		queue.Push(this.Root);
		int i = 1;
		Queue<RbNode<T>> queue2 = new Queue<RbNode<T>>(4);
		while (i > 0)
		{
			i = 0;
			string str = "";
			while (!queue.Empty)
			{
				RbNode<T> rbNode = queue.Pop();
				if (rbNode != null)
				{
					if (rbNode.IsRed)
					{
						str = str + "\t\t(" + Json.Encode(rbNode.Item, null) + ")";
					}
					else
					{
						str = str + "\t\t" + Json.Encode(rbNode.Item, null);
					}
					queue2.Push(rbNode.Left);
					queue2.Push(rbNode.Right);
					if (rbNode.Left != null)
					{
						i++;
					}
					if (rbNode.Right != null)
					{
						i++;
					}
				}
				else
				{
					str += "\t\tNA";
					queue2.Push(null);
					queue2.Push(null);
				}
			}
			Queue<RbNode<T>> queue3 = queue;
			queue = queue2;
			queue2 = queue3;
		}
	}

	// Token: 0x0400020E RID: 526
	private readonly List<RbNode<T>> NodePool = new List<RbNode<T>>();

	// Token: 0x0400020F RID: 527
	private readonly Dictionary<T, RbNode<T>> ItemNodeMap = new Dictionary<T, RbNode<T>>();

	// Token: 0x04000210 RID: 528
	private int Count;

	// Token: 0x04000211 RID: 529
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private RbNode<T> Root;

	// Token: 0x04000212 RID: 530
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private RbNode<T> ExtremelyLeftInternal;

	// Token: 0x04000213 RID: 531
	private readonly Comparison<T> Compare;
}

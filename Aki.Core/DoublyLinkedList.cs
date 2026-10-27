using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200004A RID: 74
[NullableContext(1)]
[Nullable(0)]
public class DoublyLinkedList<[Nullable(2)] T>
{
	// Token: 0x06000208 RID: 520 RVA: 0x0000C4CC File Offset: 0x0000A6CC
	public static DoublyLinkedList<T> From(T[] array)
	{
		int num = array.Length;
		T element = default(T);
		List<T> list = new List<T>();
		if (num > 0)
		{
			element = array[0];
			for (int i = 1; i < num; i++)
			{
				list.Add(array[i]);
			}
		}
		DoublyLinkedList<T> doublyLinkedList = new DoublyLinkedList<T>(element);
		doublyLinkedList.Length = num;
		DoublyLinkedNode<T> doublyLinkedNode = doublyLinkedList.Head;
		foreach (T element2 in list)
		{
			if (doublyLinkedNode != null)
			{
				doublyLinkedNode.Next = new DoublyLinkedNode<T>(element2);
				doublyLinkedNode.Next.Pre = doublyLinkedNode;
				doublyLinkedNode = doublyLinkedNode.Next;
			}
			else
			{
				doublyLinkedNode = null;
			}
		}
		return doublyLinkedList;
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x06000209 RID: 521 RVA: 0x0000C598 File Offset: 0x0000A798
	public int CountWithHead
	{
		get
		{
			return this.Length - 1;
		}
	}

	// Token: 0x0600020A RID: 522 RVA: 0x0000C5A4 File Offset: 0x0000A7A4
	[NullableContext(2)]
	public DoublyLinkedList(T element = default(T))
	{
		this.Head = new DoublyLinkedNode<T>(element);
		this.Head.Next = this.Head;
		this.Head.Pre = this.Head;
		this.Tail = this.Head;
		this.Length = 1;
	}

	// Token: 0x0600020B RID: 523 RVA: 0x0000C5F8 File Offset: 0x0000A7F8
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public DoublyLinkedNode<T> Find(Func<DoublyLinkedNode<T>, bool> cb)
	{
		DoublyLinkedNode<T> doublyLinkedNode = this.Head;
		if (doublyLinkedNode == null)
		{
			return null;
		}
		int num = 0;
		while (num < this.Length && !cb(doublyLinkedNode))
		{
			doublyLinkedNode = doublyLinkedNode.Next;
			num++;
		}
		if (num == this.Length)
		{
			return null;
		}
		return doublyLinkedNode;
	}

	// Token: 0x0600020C RID: 524 RVA: 0x0000C640 File Offset: 0x0000A840
	public DoublyLinkedNode<T> Insert(T newElement, DoublyLinkedNode<T> node)
	{
		DoublyLinkedNode<T> doublyLinkedNode = new DoublyLinkedNode<T>(newElement);
		DoublyLinkedNode<T> doublyLinkedNode2 = this.Find((DoublyLinkedNode<T> n) => n == node);
		if (doublyLinkedNode2 != null)
		{
			DoublyLinkedNode<T> next = doublyLinkedNode2.Next;
			doublyLinkedNode2.Next = doublyLinkedNode;
			doublyLinkedNode.Pre = doublyLinkedNode2;
			doublyLinkedNode.Next = next;
			if (next != null)
			{
				next.Pre = doublyLinkedNode;
			}
			this.Length++;
		}
		if (doublyLinkedNode.Next == null)
		{
			this.Tail = doublyLinkedNode;
		}
		return doublyLinkedNode;
	}

	// Token: 0x0600020D RID: 525 RVA: 0x0000C6BC File Offset: 0x0000A8BC
	public void Remove(DoublyLinkedNode<T> node)
	{
		DoublyLinkedNode<T> doublyLinkedNode = this.Find((DoublyLinkedNode<T> n) => n == node);
		if (doublyLinkedNode == null)
		{
			return;
		}
		if (this.Head == doublyLinkedNode)
		{
			this.Head = doublyLinkedNode.Next;
		}
		if (doublyLinkedNode == this.Tail)
		{
			this.Tail = ((doublyLinkedNode != null) ? doublyLinkedNode.Pre : null);
		}
		if (doublyLinkedNode.Pre != null)
		{
			doublyLinkedNode.Pre.Next = doublyLinkedNode.Next;
		}
		if (doublyLinkedNode.Next != null)
		{
			doublyLinkedNode.Next.Pre = doublyLinkedNode.Pre;
		}
		this.Length--;
	}

	// Token: 0x0600020E RID: 526 RVA: 0x0000C760 File Offset: 0x0000A960
	public void RemoveThis(DoublyLinkedNode<T> node)
	{
		if (this.Head == node)
		{
			return;
		}
		if (node == this.Tail)
		{
			this.Tail = node.Pre;
		}
		if (node.Pre != null)
		{
			node.Pre.Next = node.Next;
		}
		if (node.Next != null)
		{
			node.Next.Pre = node.Pre;
		}
		this.Length--;
	}

	// Token: 0x0600020F RID: 527 RVA: 0x0000C7CC File Offset: 0x0000A9CC
	public DoublyLinkedNode<T> AddTail(T newElement)
	{
		DoublyLinkedNode<T> doublyLinkedNode = new DoublyLinkedNode<T>(newElement);
		DoublyLinkedNode<T> head = this.Head;
		DoublyLinkedNode<T> doublyLinkedNode2 = (head != null) ? head.Pre : null;
		DoublyLinkedNode<T> doublyLinkedNode3 = (doublyLinkedNode2 != null) ? doublyLinkedNode2.Next : null;
		if (doublyLinkedNode2 != null)
		{
			doublyLinkedNode2.Next = doublyLinkedNode;
		}
		doublyLinkedNode.Pre = doublyLinkedNode2;
		doublyLinkedNode.Next = doublyLinkedNode3;
		if (doublyLinkedNode3 != null)
		{
			doublyLinkedNode3.Pre = doublyLinkedNode;
		}
		this.Length++;
		this.Tail = doublyLinkedNode;
		return doublyLinkedNode;
	}

	// Token: 0x06000210 RID: 528 RVA: 0x0000C838 File Offset: 0x0000AA38
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public DoublyLinkedNode<T> GetHeadNode()
	{
		return this.Head;
	}

	// Token: 0x06000211 RID: 529 RVA: 0x0000C840 File Offset: 0x0000AA40
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public DoublyLinkedNode<T> GetTailNode()
	{
		return this.Tail;
	}

	// Token: 0x06000212 RID: 530 RVA: 0x0000C848 File Offset: 0x0000AA48
	public void RemoveAllNodeWithoutHead()
	{
		if (this.Head != null)
		{
			this.Head.Next = this.Head;
			this.Head.Pre = this.Head;
			this.Tail = this.Head;
			this.Length = 1;
		}
	}

	// Token: 0x040001B9 RID: 441
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private DoublyLinkedNode<T> Head;

	// Token: 0x040001BA RID: 442
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private DoublyLinkedNode<T> Tail;

	// Token: 0x040001BB RID: 443
	private int Length;
}

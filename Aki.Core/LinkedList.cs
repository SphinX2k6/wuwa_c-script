using System;
using System.Runtime.CompilerServices;

// Token: 0x02000050 RID: 80
[NullableContext(1)]
[Nullable(0)]
public class LinkedList<[Nullable(2)] T>
{
	// Token: 0x17000049 RID: 73
	// (get) Token: 0x06000245 RID: 581 RVA: 0x0000CD62 File Offset: 0x0000AF62
	public int Count
	{
		get
		{
			return this.Length - 1;
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x06000246 RID: 582 RVA: 0x0000CD6C File Offset: 0x0000AF6C
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public LinkedNode<T> TailNode
	{
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		get
		{
			return this.Tail;
		}
	}

	// Token: 0x06000247 RID: 583 RVA: 0x0000CD74 File Offset: 0x0000AF74
	public LinkedList(T element)
	{
		this.Head = new LinkedNode<T>(element);
		this.Tail = this.Head;
		this.Length = 1;
	}

	// Token: 0x06000248 RID: 584 RVA: 0x0000CD9C File Offset: 0x0000AF9C
	public LinkedNode<T> AddTail(T newElement)
	{
		LinkedNode<T> linkedNode = new LinkedNode<T>(newElement);
		this.Tail.Next = linkedNode;
		this.Tail = linkedNode;
		this.Length++;
		return linkedNode;
	}

	// Token: 0x06000249 RID: 585 RVA: 0x0000CDD4 File Offset: 0x0000AFD4
	public void RemoveNodesBeforeThis(LinkedNode<T> removeNode, bool includeThis)
	{
		if (removeNode == this.Head)
		{
			return;
		}
		if (this.Tail == removeNode)
		{
			if (includeThis)
			{
				this.Head.Next = null;
				this.Tail = this.Head;
				this.Length = 1;
				return;
			}
			LinkedNode<T> next = this.Head.Next;
			int num = 0;
			while (next != null && next != removeNode)
			{
				num++;
				next = next.Next;
			}
			this.Head.Next = removeNode;
			this.Length -= num;
			return;
		}
		else
		{
			LinkedNode<T> next2 = this.Head.Next;
			int num2 = 1;
			while (next2 != removeNode && next2 != null)
			{
				next2 = next2.Next;
				num2++;
			}
			if (next2 == null)
			{
				return;
			}
			if (includeThis)
			{
				this.Head.Next = removeNode.Next;
				this.Length -= num2;
				return;
			}
			this.Head.Next = removeNode;
			this.Length -= num2 - 1;
			return;
		}
	}

	// Token: 0x0600024A RID: 586 RVA: 0x0000CEBC File Offset: 0x0000B0BC
	public void RemoveNode(LinkedNode<T> removeNode)
	{
		if (removeNode == this.Head)
		{
			return;
		}
		LinkedNode<T> linkedNode = this.Head;
		while (linkedNode.Next != removeNode && linkedNode != this.Tail)
		{
			linkedNode = linkedNode.Next;
		}
		if (linkedNode.Next == removeNode)
		{
			linkedNode.Next = removeNode.Next;
			if (removeNode == this.Tail)
			{
				this.Tail = linkedNode;
			}
			this.Length--;
		}
	}

	// Token: 0x0600024B RID: 587 RVA: 0x0000CF28 File Offset: 0x0000B128
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public LinkedNode<T> GetHeadNextNode()
	{
		return this.Head.Next;
	}

	// Token: 0x0600024C RID: 588 RVA: 0x0000CF35 File Offset: 0x0000B135
	public void RemoveAllNodeWithoutHead()
	{
		this.Head.Next = null;
		this.Tail = this.Head;
		this.Length = 1;
	}

	// Token: 0x040001C2 RID: 450
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private readonly LinkedNode<T> Head;

	// Token: 0x040001C3 RID: 451
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LinkedNode<T> Tail;

	// Token: 0x040001C4 RID: 452
	private int Length;
}

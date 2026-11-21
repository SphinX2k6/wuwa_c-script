using System;
using System.Runtime.CompilerServices;

// Token: 0x02000049 RID: 73
[NullableContext(2)]
[Nullable(0)]
public class DoublyLinkedNode<T>
{
	// Token: 0x06000208 RID: 520 RVA: 0x0000C1A1 File Offset: 0x0000A3A1
	public DoublyLinkedNode(T element)
	{
		this.Element = element;
	}

	// Token: 0x040001B8 RID: 440
	public T Element;

	// Token: 0x040001B9 RID: 441
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public DoublyLinkedNode<T> Pre;

	// Token: 0x040001BA RID: 442
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public DoublyLinkedNode<T> Next;
}

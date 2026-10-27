using System;
using System.Runtime.CompilerServices;

// Token: 0x02000049 RID: 73
[NullableContext(2)]
[Nullable(0)]
public class DoublyLinkedNode<T>
{
	// Token: 0x06000207 RID: 519 RVA: 0x0000C4BD File Offset: 0x0000A6BD
	public DoublyLinkedNode(T element)
	{
		this.Element = element;
	}

	// Token: 0x040001B6 RID: 438
	public T Element;

	// Token: 0x040001B7 RID: 439
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public DoublyLinkedNode<T> Pre;

	// Token: 0x040001B8 RID: 440
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public DoublyLinkedNode<T> Next;
}

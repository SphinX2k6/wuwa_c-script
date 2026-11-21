using System;
using System.Runtime.CompilerServices;

// Token: 0x0200004F RID: 79
[NullableContext(2)]
[Nullable(0)]
public class LinkedNode<T>
{
	// Token: 0x06000245 RID: 581 RVA: 0x0000CA37 File Offset: 0x0000AC37
	[NullableContext(1)]
	public LinkedNode(T element)
	{
		this.Element = element;
	}

	// Token: 0x040001C2 RID: 450
	public T Element;

	// Token: 0x040001C3 RID: 451
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public LinkedNode<T> Next;
}

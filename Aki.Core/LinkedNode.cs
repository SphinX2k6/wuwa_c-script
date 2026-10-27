using System;
using System.Runtime.CompilerServices;

// Token: 0x0200004F RID: 79
[NullableContext(2)]
[Nullable(0)]
public class LinkedNode<T>
{
	// Token: 0x06000244 RID: 580 RVA: 0x0000CD53 File Offset: 0x0000AF53
	[NullableContext(1)]
	public LinkedNode(T element)
	{
		this.Element = element;
	}

	// Token: 0x040001C0 RID: 448
	public T Element;

	// Token: 0x040001C1 RID: 449
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public LinkedNode<T> Next;
}

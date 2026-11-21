using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000010 RID: 16
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class LogList<[Nullable(2)] T> : List<T>
{
	// Token: 0x06000107 RID: 263 RVA: 0x00007DC0 File Offset: 0x00005FC0
	public LogList()
	{
	}

	// Token: 0x06000108 RID: 264 RVA: 0x00007DC8 File Offset: 0x00005FC8
	public LogList(int capacity) : base(capacity)
	{
	}

	// Token: 0x06000109 RID: 265 RVA: 0x00007DD1 File Offset: 0x00005FD1
	public LogList(IEnumerable<T> collection) : base(collection)
	{
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200000F RID: 15
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class LogList<[Nullable(2)] T> : List<T>
{
	// Token: 0x0600009A RID: 154 RVA: 0x000046A4 File Offset: 0x000028A4
	public LogList()
	{
	}

	// Token: 0x0600009B RID: 155 RVA: 0x000046AC File Offset: 0x000028AC
	public LogList(int capacity) : base(capacity)
	{
	}

	// Token: 0x0600009C RID: 156 RVA: 0x000046B5 File Offset: 0x000028B5
	public LogList(IEnumerable<T> collection) : base(collection)
	{
	}
}

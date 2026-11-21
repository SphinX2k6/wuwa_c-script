using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000060 RID: 96
public static class SetUtility
{
	// Token: 0x06000302 RID: 770 RVA: 0x00010730 File Offset: 0x0000E930
	[NullableContext(1)]
	public static void AddToSet<[Nullable(2)] T>(HashSet<T> destination, HashSet<T> source)
	{
		foreach (T item in source)
		{
			destination.Add(item);
		}
	}
}

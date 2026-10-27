using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200005E RID: 94
public static class SetUtility
{
	// Token: 0x060002C7 RID: 711 RVA: 0x0000F948 File Offset: 0x0000DB48
	[NullableContext(1)]
	public static void AddToSet<[Nullable(2)] T>(HashSet<T> destination, HashSet<T> source)
	{
		foreach (T item in source)
		{
			destination.Add(item);
		}
	}
}

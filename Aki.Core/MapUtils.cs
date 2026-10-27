using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000F3 RID: 243
public static class MapUtils
{
	// Token: 0x06000772 RID: 1906 RVA: 0x00028834 File Offset: 0x00026A34
	[NullableContext(1)]
	[Obsolete]
	public static void ForEach<[Nullable(2)] TKey, [Nullable(2)] TValue>(TMap<TKey, TValue> map, Action<TKey, TValue> lambda)
	{
		foreach (KeyValuePair<TKey, TValue> keyValuePair in map)
		{
			lambda(keyValuePair.Key, keyValuePair.Value);
		}
	}
}

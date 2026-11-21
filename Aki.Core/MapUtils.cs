using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000F3 RID: 243
public static class MapUtils
{
	// Token: 0x060007AC RID: 1964 RVA: 0x00028B68 File Offset: 0x00026D68
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

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Extension
{
	// Token: 0x02000019 RID: 25
	public static class DictionaryExtension
	{
		// Token: 0x0600011A RID: 282 RVA: 0x0000E390 File Offset: 0x0000C590
		public static V? GetValueOrNull<[Nullable(2)] K, V>([Nullable(new byte[]
		{
			1,
			1,
			0
		})] this IReadOnlyDictionary<K, V> dict, [Nullable(1)] K key) where V : struct
		{
			V value;
			if (dict.TryGetValue(key, out value))
			{
				return new V?(value);
			}
			return null;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000E3B8 File Offset: 0x0000C5B8
		[NullableContext(2)]
		public static void AddRange<K, V>([Nullable(1)] this IDictionary<K, V> dict, [Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] IEnumerable<KeyValuePair<K, V>> items)
		{
			foreach (KeyValuePair<K, V> keyValuePair in items)
			{
				dict[keyValuePair.Key] = keyValuePair.Value;
			}
		}
	}
}

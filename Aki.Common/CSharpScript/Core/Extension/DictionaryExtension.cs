using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Core.Extension
{
	// Token: 0x02000018 RID: 24
	public static class DictionaryExtension
	{
		// Token: 0x060000AD RID: 173 RVA: 0x0000ABE8 File Offset: 0x00008DE8
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

		// Token: 0x060000AE RID: 174 RVA: 0x0000AC10 File Offset: 0x00008E10
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

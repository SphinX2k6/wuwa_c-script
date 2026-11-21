using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009D3 RID: 2515
	[NullableContext(1)]
	public interface IReadOnlyDictionary<[Nullable(2)] TKey, [Nullable(2)] TValue> : IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<!0, !1>>, IEnumerable
	{
		// Token: 0x0600933B RID: 37691
		bool ContainsKey(TKey key);

		// Token: 0x0600933C RID: 37692
		bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value);

		// Token: 0x17001413 RID: 5139
		TValue this[TKey key]
		{
			get;
		}

		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x0600933E RID: 37694
		IEnumerable<TKey> Keys { get; }

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x0600933F RID: 37695
		IEnumerable<TValue> Values { get; }
	}
}

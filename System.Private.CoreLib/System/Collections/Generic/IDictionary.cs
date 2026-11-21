using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009C8 RID: 2504
	[NullableContext(1)]
	public interface IDictionary<[Nullable(2)] TKey, [Nullable(2)] TValue> : ICollection<KeyValuePair<!0, !1>>, IEnumerable<KeyValuePair<!0, !1>>, IEnumerable
	{
		// Token: 0x1700140A RID: 5130
		TValue this[TKey key]
		{
			get;
			set;
		}

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x06009323 RID: 37667
		ICollection<TKey> Keys { get; }

		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x06009324 RID: 37668
		ICollection<TValue> Values { get; }

		// Token: 0x06009325 RID: 37669
		bool ContainsKey(TKey key);

		// Token: 0x06009326 RID: 37670
		void Add(TKey key, TValue value);

		// Token: 0x06009327 RID: 37671
		bool Remove(TKey key);

		// Token: 0x06009328 RID: 37672
		bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value);
	}
}

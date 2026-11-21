using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Collections.Concurrent
{
	// Token: 0x02000992 RID: 2450
	[NullableContext(1)]
	public interface IProducerConsumerCollection<[Nullable(2)] T> : IEnumerable<!0>, IEnumerable, ICollection
	{
		// Token: 0x0600917C RID: 37244
		void CopyTo(T[] array, int index);

		// Token: 0x0600917D RID: 37245
		bool TryAdd(T item);

		// Token: 0x0600917E RID: 37246
		bool TryTake([MaybeNullWhen(false)] out T item);

		// Token: 0x0600917F RID: 37247
		T[] ToArray();
	}
}

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace System.Collections.Concurrent
{
	// Token: 0x02000994 RID: 2452
	internal interface IProducerConsumerQueue<T> : IEnumerable<!0>, IEnumerable
	{
		// Token: 0x06009182 RID: 37250
		void Enqueue(T item);

		// Token: 0x06009183 RID: 37251
		bool TryDequeue([MaybeNullWhen(false)] out T result);

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x06009184 RID: 37252
		bool IsEmpty { get; }

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x06009185 RID: 37253
		int Count { get; }

		// Token: 0x06009186 RID: 37254
		int GetCountSafe(object syncObj);
	}
}

using System;
using System.Diagnostics;

namespace System.Collections.Concurrent
{
	// Token: 0x02000993 RID: 2451
	internal sealed class IProducerConsumerCollectionDebugView<T>
	{
		// Token: 0x06009180 RID: 37248 RVA: 0x00167E14 File Offset: 0x00166014
		public IProducerConsumerCollectionDebugView(IProducerConsumerCollection<T> collection)
		{
			ArgumentNullException.ThrowIfNull(collection, "collection");
			this._collection = collection;
		}

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x06009181 RID: 37249 RVA: 0x00167E2E File Offset: 0x0016602E
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] Items
		{
			get
			{
				return this._collection.ToArray();
			}
		}

		// Token: 0x04002244 RID: 8772
		private readonly IProducerConsumerCollection<T> _collection;
	}
}

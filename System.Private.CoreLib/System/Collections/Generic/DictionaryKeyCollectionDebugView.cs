using System;
using System.Diagnostics;

namespace System.Collections.Generic
{
	// Token: 0x020009CA RID: 2506
	internal sealed class DictionaryKeyCollectionDebugView<TKey, TValue>
	{
		// Token: 0x0600932B RID: 37675 RVA: 0x0016F466 File Offset: 0x0016D666
		public DictionaryKeyCollectionDebugView(ICollection<TKey> collection)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection");
			}
			this._collection = collection;
		}

		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x0600932C RID: 37676 RVA: 0x0016F484 File Offset: 0x0016D684
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public TKey[] Items
		{
			get
			{
				TKey[] array = new TKey[this._collection.Count];
				this._collection.CopyTo(array, 0);
				return array;
			}
		}

		// Token: 0x04002294 RID: 8852
		private readonly ICollection<TKey> _collection;
	}
}

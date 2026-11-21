using System;
using System.Diagnostics;

namespace System.Collections.Generic
{
	// Token: 0x020009CB RID: 2507
	internal sealed class DictionaryValueCollectionDebugView<TKey, TValue>
	{
		// Token: 0x0600932D RID: 37677 RVA: 0x0016F4B0 File Offset: 0x0016D6B0
		public DictionaryValueCollectionDebugView(ICollection<TValue> collection)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection");
			}
			this._collection = collection;
		}

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x0600932E RID: 37678 RVA: 0x0016F4D0 File Offset: 0x0016D6D0
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public TValue[] Items
		{
			get
			{
				TValue[] array = new TValue[this._collection.Count];
				this._collection.CopyTo(array, 0);
				return array;
			}
		}

		// Token: 0x04002295 RID: 8853
		private readonly ICollection<TValue> _collection;
	}
}

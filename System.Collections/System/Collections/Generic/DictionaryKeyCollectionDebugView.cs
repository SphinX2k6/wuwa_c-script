using System;
using System.Diagnostics;

namespace System.Collections.Generic
{
	// Token: 0x02000010 RID: 16
	internal sealed class DictionaryKeyCollectionDebugView<TKey, TValue>
	{
		// Token: 0x06000089 RID: 137 RVA: 0x00003FFE File Offset: 0x000021FE
		public DictionaryKeyCollectionDebugView(ICollection<TKey> collection)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection");
			}
			this._collection = collection;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000401C File Offset: 0x0000221C
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

		// Token: 0x04000012 RID: 18
		private readonly ICollection<TKey> _collection;
	}
}

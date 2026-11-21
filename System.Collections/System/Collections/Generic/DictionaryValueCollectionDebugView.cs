using System;
using System.Diagnostics;

namespace System.Collections.Generic
{
	// Token: 0x02000011 RID: 17
	internal sealed class DictionaryValueCollectionDebugView<TKey, TValue>
	{
		// Token: 0x0600008B RID: 139 RVA: 0x00004048 File Offset: 0x00002248
		public DictionaryValueCollectionDebugView(ICollection<TValue> collection)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection");
			}
			this._collection = collection;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00004068 File Offset: 0x00002268
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

		// Token: 0x04000013 RID: 19
		private readonly ICollection<TValue> _collection;
	}
}

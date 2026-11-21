using System;
using System.Diagnostics;

namespace System.Collections.Generic
{
	// Token: 0x020009C6 RID: 2502
	internal sealed class ICollectionDebugView<T>
	{
		// Token: 0x0600931E RID: 37662 RVA: 0x0016F3A7 File Offset: 0x0016D5A7
		public ICollectionDebugView(ICollection<T> collection)
		{
			ArgumentNullException.ThrowIfNull(collection, "collection");
			this._collection = collection;
		}

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x0600931F RID: 37663 RVA: 0x0016F3C4 File Offset: 0x0016D5C4
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] Items
		{
			get
			{
				T[] array = new T[this._collection.Count];
				this._collection.CopyTo(array, 0);
				return array;
			}
		}

		// Token: 0x04002292 RID: 8850
		private readonly ICollection<T> _collection;
	}
}

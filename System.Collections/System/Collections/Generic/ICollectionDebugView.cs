using System;
using System.Diagnostics;

namespace System.Collections.Generic
{
	// Token: 0x0200000E RID: 14
	internal sealed class ICollectionDebugView<T>
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00003F40 File Offset: 0x00002140
		public ICollectionDebugView(ICollection<T> collection)
		{
			ArgumentNullException.ThrowIfNull(collection, "collection");
			this._collection = collection;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00003F5C File Offset: 0x0000215C
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

		// Token: 0x04000010 RID: 16
		private readonly ICollection<T> _collection;
	}
}

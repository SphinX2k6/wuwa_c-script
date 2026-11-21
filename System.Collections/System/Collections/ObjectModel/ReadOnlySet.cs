using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Collections.ObjectModel
{
	// Token: 0x0200000C RID: 12
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerDisplay("Count = {Count}")]
	public class ReadOnlySet<[Nullable(2)] T> : IReadOnlySet<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, ISet<T>, ICollection<T>, ICollection
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00003DF0 File Offset: 0x00001FF0
		public ReadOnlySet(ISet<T> set)
		{
			ArgumentNullException.ThrowIfNull(set, "set");
			this._set = set;
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00003E0A File Offset: 0x0000200A
		public static ReadOnlySet<T> Empty { get; } = new ReadOnlySet<T>(new HashSet<T>());

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00003E11 File Offset: 0x00002011
		protected ISet<T> Set
		{
			get
			{
				return this._set;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00003E19 File Offset: 0x00002019
		public int Count
		{
			get
			{
				return this._set.Count;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003E26 File Offset: 0x00002026
		public IEnumerator<T> GetEnumerator()
		{
			if (this._set.Count != 0)
			{
				return this._set.GetEnumerator();
			}
			return Array.Empty<T>().GetEnumerator();
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003E4B File Offset: 0x0000204B
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003E53 File Offset: 0x00002053
		public bool Contains(T item)
		{
			return this._set.Contains(item);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003E61 File Offset: 0x00002061
		public bool IsProperSubsetOf(IEnumerable<T> other)
		{
			return this._set.IsProperSubsetOf(other);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003E6F File Offset: 0x0000206F
		public bool IsProperSupersetOf(IEnumerable<T> other)
		{
			return this._set.IsProperSupersetOf(other);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003E7D File Offset: 0x0000207D
		public bool IsSubsetOf(IEnumerable<T> other)
		{
			return this._set.IsSubsetOf(other);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003E8B File Offset: 0x0000208B
		public bool IsSupersetOf(IEnumerable<T> other)
		{
			return this._set.IsSupersetOf(other);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003E99 File Offset: 0x00002099
		public bool Overlaps(IEnumerable<T> other)
		{
			return this._set.Overlaps(other);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003EA7 File Offset: 0x000020A7
		public bool SetEquals(IEnumerable<T> other)
		{
			return this._set.SetEquals(other);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003EB5 File Offset: 0x000020B5
		void ICollection<!0>.CopyTo(T[] array, int arrayIndex)
		{
			this._set.CopyTo(array, arrayIndex);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003EC4 File Offset: 0x000020C4
		void ICollection.CopyTo(Array array, int index)
		{
			CollectionHelpers.CopyTo<T>(this._set, array, index);
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00003ED3 File Offset: 0x000020D3
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00003925 File Offset: 0x00001B25
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00003ED8 File Offset: 0x000020D8
		object ICollection.SyncRoot
		{
			get
			{
				ICollection collection = this._set as ICollection;
				if (collection == null)
				{
					return this;
				}
				return collection.SyncRoot;
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003EFC File Offset: 0x000020FC
		bool ISet<!0>.Add(T item)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003EFC File Offset: 0x000020FC
		void ISet<!0>.ExceptWith(IEnumerable<T> other)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003EFC File Offset: 0x000020FC
		void ISet<!0>.IntersectWith(IEnumerable<T> other)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003EFC File Offset: 0x000020FC
		void ISet<!0>.SymmetricExceptWith(IEnumerable<T> other)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003EFC File Offset: 0x000020FC
		void ISet<!0>.UnionWith(IEnumerable<T> other)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003EFC File Offset: 0x000020FC
		void ICollection<!0>.Add(T item)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003EFC File Offset: 0x000020FC
		void ICollection<!0>.Clear()
		{
			throw new NotSupportedException();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003EFC File Offset: 0x000020FC
		bool ICollection<!0>.Remove(T item)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0400000C RID: 12
		private readonly ISet<T> _set;
	}
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Collections
{
	// Token: 0x02000980 RID: 2432
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerDisplay("Count = {count}")]
	[DebuggerTypeProxy(typeof(ListDictionaryInternal.ListDictionaryInternalDebugView))]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class ListDictionaryInternal : IDictionary, ICollection, IEnumerable
	{
		// Token: 0x1700137B RID: 4987
		[Nullable(2)]
		public object this[object key]
		{
			[return: Nullable(2)]
			get
			{
				ArgumentNullException.ThrowIfNull(key, "key");
				for (ListDictionaryInternal.DictionaryNode next = this.head; next != null; next = next.next)
				{
					if (next.key.Equals(key))
					{
						return next.value;
					}
				}
				return null;
			}
			[param: Nullable(2)]
			set
			{
				ArgumentNullException.ThrowIfNull(key, "key");
				this.version++;
				ListDictionaryInternal.DictionaryNode dictionaryNode = null;
				ListDictionaryInternal.DictionaryNode next = this.head;
				while (next != null && !next.key.Equals(key))
				{
					dictionaryNode = next;
					next = next.next;
				}
				if (next != null)
				{
					next.value = value;
					return;
				}
				ListDictionaryInternal.DictionaryNode dictionaryNode2 = new ListDictionaryInternal.DictionaryNode();
				dictionaryNode2.key = key;
				dictionaryNode2.value = value;
				if (dictionaryNode != null)
				{
					dictionaryNode.next = dictionaryNode2;
				}
				else
				{
					this.head = dictionaryNode2;
				}
				this.count++;
			}
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x060090A4 RID: 37028 RVA: 0x00165B5F File Offset: 0x00163D5F
		public int Count
		{
			get
			{
				return this.count;
			}
		}

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x060090A5 RID: 37029 RVA: 0x00165B67 File Offset: 0x00163D67
		public ICollection Keys
		{
			get
			{
				return new ListDictionaryInternal.NodeKeyValueCollection(this, true);
			}
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x060090A6 RID: 37030 RVA: 0x00007B65 File Offset: 0x00005D65
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x060090A7 RID: 37031 RVA: 0x00007B65 File Offset: 0x00005D65
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x060090A8 RID: 37032 RVA: 0x00007B65 File Offset: 0x00005D65
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x060090A9 RID: 37033 RVA: 0x00007B62 File Offset: 0x00005D62
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x060090AA RID: 37034 RVA: 0x00165B70 File Offset: 0x00163D70
		public ICollection Values
		{
			get
			{
				return new ListDictionaryInternal.NodeKeyValueCollection(this, false);
			}
		}

		// Token: 0x060090AB RID: 37035 RVA: 0x00165B7C File Offset: 0x00163D7C
		public void Add(object key, [Nullable(2)] object value)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			this.version++;
			ListDictionaryInternal.DictionaryNode dictionaryNode = null;
			for (ListDictionaryInternal.DictionaryNode next = this.head; next != null; next = next.next)
			{
				if (next.key.Equals(key))
				{
					throw new ArgumentException(SR.Format(SR.Argument_AddingDuplicate__, next.key, key));
				}
				dictionaryNode = next;
			}
			ListDictionaryInternal.DictionaryNode dictionaryNode2 = new ListDictionaryInternal.DictionaryNode();
			dictionaryNode2.key = key;
			dictionaryNode2.value = value;
			if (dictionaryNode != null)
			{
				dictionaryNode.next = dictionaryNode2;
			}
			else
			{
				this.head = dictionaryNode2;
			}
			this.count++;
		}

		// Token: 0x060090AC RID: 37036 RVA: 0x00165C13 File Offset: 0x00163E13
		public void Clear()
		{
			this.count = 0;
			this.head = null;
			this.version++;
		}

		// Token: 0x060090AD RID: 37037 RVA: 0x00165C34 File Offset: 0x00163E34
		public bool Contains(object key)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			for (ListDictionaryInternal.DictionaryNode next = this.head; next != null; next = next.next)
			{
				if (next.key.Equals(key))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060090AE RID: 37038 RVA: 0x00165C70 File Offset: 0x00163E70
		public void CopyTo(Array array, int index)
		{
			ArgumentNullException.ThrowIfNull(array, "array");
			if (array.Rank != 1)
			{
				throw new ArgumentException(SR.Arg_RankMultiDimNotSupported);
			}
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			if (array.Length - index < this.Count)
			{
				throw new ArgumentException(SR.ArgumentOutOfRange_IndexMustBeLessOrEqual, "index");
			}
			for (ListDictionaryInternal.DictionaryNode next = this.head; next != null; next = next.next)
			{
				array.SetValue(new DictionaryEntry(next.key, next.value), index);
				index++;
			}
		}

		// Token: 0x060090AF RID: 37039 RVA: 0x00165CFC File Offset: 0x00163EFC
		public IDictionaryEnumerator GetEnumerator()
		{
			return new ListDictionaryInternal.NodeEnumerator(this);
		}

		// Token: 0x060090B0 RID: 37040 RVA: 0x00165CFC File Offset: 0x00163EFC
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new ListDictionaryInternal.NodeEnumerator(this);
		}

		// Token: 0x060090B1 RID: 37041 RVA: 0x00165D04 File Offset: 0x00163F04
		public void Remove(object key)
		{
			ArgumentNullException.ThrowIfNull(key, "key");
			this.version++;
			ListDictionaryInternal.DictionaryNode dictionaryNode = null;
			ListDictionaryInternal.DictionaryNode next = this.head;
			while (next != null && !next.key.Equals(key))
			{
				dictionaryNode = next;
				next = next.next;
			}
			if (next == null)
			{
				return;
			}
			if (next == this.head)
			{
				this.head = next.next;
			}
			else
			{
				dictionaryNode.next = next.next;
			}
			this.count--;
		}

		// Token: 0x04002210 RID: 8720
		private ListDictionaryInternal.DictionaryNode head;

		// Token: 0x04002211 RID: 8721
		private int version;

		// Token: 0x04002212 RID: 8722
		private int count;

		// Token: 0x02000981 RID: 2433
		private sealed class NodeEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x060090B2 RID: 37042 RVA: 0x00165D84 File Offset: 0x00163F84
			public NodeEnumerator(ListDictionaryInternal list)
			{
				this.list = list;
				this.version = list.version;
				this.start = true;
				this.current = null;
			}

			// Token: 0x17001383 RID: 4995
			// (get) Token: 0x060090B3 RID: 37043 RVA: 0x00165DAD File Offset: 0x00163FAD
			public object Current
			{
				get
				{
					return this.Entry;
				}
			}

			// Token: 0x17001384 RID: 4996
			// (get) Token: 0x060090B4 RID: 37044 RVA: 0x00165DBA File Offset: 0x00163FBA
			public DictionaryEntry Entry
			{
				get
				{
					if (this.current == null)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
					}
					return new DictionaryEntry(this.current.key, this.current.value);
				}
			}

			// Token: 0x17001385 RID: 4997
			// (get) Token: 0x060090B5 RID: 37045 RVA: 0x00165DEA File Offset: 0x00163FEA
			public object Key
			{
				get
				{
					if (this.current == null)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
					}
					return this.current.key;
				}
			}

			// Token: 0x17001386 RID: 4998
			// (get) Token: 0x060090B6 RID: 37046 RVA: 0x00165E0A File Offset: 0x0016400A
			public object Value
			{
				get
				{
					if (this.current == null)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
					}
					return this.current.value;
				}
			}

			// Token: 0x060090B7 RID: 37047 RVA: 0x00165E2C File Offset: 0x0016402C
			public bool MoveNext()
			{
				if (this.version != this.list.version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
				if (this.start)
				{
					this.current = this.list.head;
					this.start = false;
				}
				else if (this.current != null)
				{
					this.current = this.current.next;
				}
				return this.current != null;
			}

			// Token: 0x060090B8 RID: 37048 RVA: 0x00165E9B File Offset: 0x0016409B
			public void Reset()
			{
				if (this.version != this.list.version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
				this.start = true;
				this.current = null;
			}

			// Token: 0x04002213 RID: 8723
			private readonly ListDictionaryInternal list;

			// Token: 0x04002214 RID: 8724
			private ListDictionaryInternal.DictionaryNode current;

			// Token: 0x04002215 RID: 8725
			private readonly int version;

			// Token: 0x04002216 RID: 8726
			private bool start;
		}

		// Token: 0x02000982 RID: 2434
		private sealed class NodeKeyValueCollection : ICollection, IEnumerable
		{
			// Token: 0x060090B9 RID: 37049 RVA: 0x00165EC9 File Offset: 0x001640C9
			public NodeKeyValueCollection(ListDictionaryInternal list, bool isKeys)
			{
				this.list = list;
				this.isKeys = isKeys;
			}

			// Token: 0x060090BA RID: 37050 RVA: 0x00165EE0 File Offset: 0x001640E0
			void ICollection.CopyTo(Array array, int index)
			{
				ArgumentNullException.ThrowIfNull(array, "array");
				if (array.Rank != 1)
				{
					throw new ArgumentException(SR.Arg_RankMultiDimNotSupported);
				}
				ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
				if (array.Length - index < this.list.Count)
				{
					throw new ArgumentException(SR.ArgumentOutOfRange_IndexMustBeLessOrEqual, "index");
				}
				for (ListDictionaryInternal.DictionaryNode dictionaryNode = this.list.head; dictionaryNode != null; dictionaryNode = dictionaryNode.next)
				{
					array.SetValue(this.isKeys ? dictionaryNode.key : dictionaryNode.value, index);
					index++;
				}
			}

			// Token: 0x17001387 RID: 4999
			// (get) Token: 0x060090BB RID: 37051 RVA: 0x00165F78 File Offset: 0x00164178
			int ICollection.Count
			{
				get
				{
					int num = 0;
					for (ListDictionaryInternal.DictionaryNode dictionaryNode = this.list.head; dictionaryNode != null; dictionaryNode = dictionaryNode.next)
					{
						num++;
					}
					return num;
				}
			}

			// Token: 0x17001388 RID: 5000
			// (get) Token: 0x060090BC RID: 37052 RVA: 0x00007B65 File Offset: 0x00005D65
			bool ICollection.IsSynchronized
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17001389 RID: 5001
			// (get) Token: 0x060090BD RID: 37053 RVA: 0x00165FA4 File Offset: 0x001641A4
			object ICollection.SyncRoot
			{
				get
				{
					return this.list.SyncRoot;
				}
			}

			// Token: 0x060090BE RID: 37054 RVA: 0x00165FB1 File Offset: 0x001641B1
			IEnumerator IEnumerable.GetEnumerator()
			{
				return new ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator(this.list, this.isKeys);
			}

			// Token: 0x04002217 RID: 8727
			private readonly ListDictionaryInternal list;

			// Token: 0x04002218 RID: 8728
			private readonly bool isKeys;

			// Token: 0x02000983 RID: 2435
			private sealed class NodeKeyValueEnumerator : IEnumerator
			{
				// Token: 0x060090BF RID: 37055 RVA: 0x00165FC4 File Offset: 0x001641C4
				public NodeKeyValueEnumerator(ListDictionaryInternal list, bool isKeys)
				{
					this.list = list;
					this.isKeys = isKeys;
					this.version = list.version;
					this.start = true;
					this.current = null;
				}

				// Token: 0x1700138A RID: 5002
				// (get) Token: 0x060090C0 RID: 37056 RVA: 0x00165FF4 File Offset: 0x001641F4
				public object Current
				{
					get
					{
						if (this.current == null)
						{
							throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
						}
						if (!this.isKeys)
						{
							return this.current.value;
						}
						return this.current.key;
					}
				}

				// Token: 0x060090C1 RID: 37057 RVA: 0x00166028 File Offset: 0x00164228
				public bool MoveNext()
				{
					if (this.version != this.list.version)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
					}
					if (this.start)
					{
						this.current = this.list.head;
						this.start = false;
					}
					else if (this.current != null)
					{
						this.current = this.current.next;
					}
					return this.current != null;
				}

				// Token: 0x060090C2 RID: 37058 RVA: 0x00166097 File Offset: 0x00164297
				public void Reset()
				{
					if (this.version != this.list.version)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
					}
					this.start = true;
					this.current = null;
				}

				// Token: 0x04002219 RID: 8729
				private readonly ListDictionaryInternal list;

				// Token: 0x0400221A RID: 8730
				private ListDictionaryInternal.DictionaryNode current;

				// Token: 0x0400221B RID: 8731
				private readonly int version;

				// Token: 0x0400221C RID: 8732
				private readonly bool isKeys;

				// Token: 0x0400221D RID: 8733
				private bool start;
			}
		}

		// Token: 0x02000984 RID: 2436
		[Serializable]
		private sealed class DictionaryNode
		{
			// Token: 0x0400221E RID: 8734
			public object key;

			// Token: 0x0400221F RID: 8735
			public object value;

			// Token: 0x04002220 RID: 8736
			public ListDictionaryInternal.DictionaryNode next;
		}

		// Token: 0x02000985 RID: 2437
		private sealed class ListDictionaryInternalDebugView
		{
			// Token: 0x060090C4 RID: 37060 RVA: 0x001660C5 File Offset: 0x001642C5
			public ListDictionaryInternalDebugView(ListDictionaryInternal list)
			{
				ArgumentNullException.ThrowIfNull(list, "list");
				this._list = list;
			}

			// Token: 0x1700138B RID: 5003
			// (get) Token: 0x060090C5 RID: 37061 RVA: 0x001660E0 File Offset: 0x001642E0
			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			public DebugViewDictionaryItem<object, object>[] Items
			{
				get
				{
					DebugViewDictionaryItem<object, object>[] array = new DebugViewDictionaryItem<object, object>[this._list.count];
					int num = 0;
					for (ListDictionaryInternal.DictionaryNode dictionaryNode = this._list.head; dictionaryNode != null; dictionaryNode = dictionaryNode.next)
					{
						array[num++] = new DebugViewDictionaryItem<object, object>(dictionaryNode.key, dictionaryNode.value);
					}
					return array;
				}
			}

			// Token: 0x04002221 RID: 8737
			private readonly ListDictionaryInternal _list;
		}
	}
}

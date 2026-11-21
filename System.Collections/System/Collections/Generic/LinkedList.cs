using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	// Token: 0x02000012 RID: 18
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class LinkedList<[Nullable(2)] T> : ICollection<!0>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
	{
		// Token: 0x0600008D RID: 141 RVA: 0x00003B5E File Offset: 0x00001D5E
		public LinkedList()
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00004094 File Offset: 0x00002294
		public LinkedList(IEnumerable<T> collection)
		{
			ArgumentNullException.ThrowIfNull(collection, "collection");
			foreach (T value in collection)
			{
				this.AddLast(value);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000040F0 File Offset: 0x000022F0
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected LinkedList(SerializationInfo info, StreamingContext context)
		{
			this._siInfo = info;
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000040FF File Offset: 0x000022FF
		public int Count
		{
			get
			{
				return this.count;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00004107 File Offset: 0x00002307
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public LinkedListNode<T> First
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return this.head;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000410F File Offset: 0x0000230F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public LinkedListNode<T> Last
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				LinkedListNode<T> linkedListNode = this.head;
				if (linkedListNode == null)
				{
					return null;
				}
				return linkedListNode.prev;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00003925 File Offset: 0x00001B25
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00004122 File Offset: 0x00002322
		void ICollection<!0>.Add(T value)
		{
			this.AddLast(value);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000412C File Offset: 0x0000232C
		public LinkedListNode<T> AddAfter(LinkedListNode<T> node, T value)
		{
			this.ValidateNode(node);
			LinkedListNode<T> linkedListNode = new LinkedListNode<T>(node.list, value);
			this.InternalInsertNodeBefore(node.next, linkedListNode);
			return linkedListNode;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000415B File Offset: 0x0000235B
		public void AddAfter(LinkedListNode<T> node, LinkedListNode<T> newNode)
		{
			this.ValidateNode(node);
			LinkedList<T>.ValidateNewNode(newNode);
			this.InternalInsertNodeBefore(node.next, newNode);
			newNode.list = this;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00004180 File Offset: 0x00002380
		public LinkedListNode<T> AddBefore(LinkedListNode<T> node, T value)
		{
			this.ValidateNode(node);
			LinkedListNode<T> linkedListNode = new LinkedListNode<T>(node.list, value);
			this.InternalInsertNodeBefore(node, linkedListNode);
			if (node == this.head)
			{
				this.head = linkedListNode;
			}
			return linkedListNode;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000041BA File Offset: 0x000023BA
		public void AddBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
		{
			this.ValidateNode(node);
			LinkedList<T>.ValidateNewNode(newNode);
			this.InternalInsertNodeBefore(node, newNode);
			newNode.list = this;
			if (node == this.head)
			{
				this.head = newNode;
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000041E8 File Offset: 0x000023E8
		public LinkedListNode<T> AddFirst(T value)
		{
			LinkedListNode<T> linkedListNode = new LinkedListNode<T>(this, value);
			if (this.head == null)
			{
				this.InternalInsertNodeToEmptyList(linkedListNode);
			}
			else
			{
				this.InternalInsertNodeBefore(this.head, linkedListNode);
				this.head = linkedListNode;
			}
			return linkedListNode;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00004223 File Offset: 0x00002423
		public void AddFirst(LinkedListNode<T> node)
		{
			LinkedList<T>.ValidateNewNode(node);
			if (this.head == null)
			{
				this.InternalInsertNodeToEmptyList(node);
			}
			else
			{
				this.InternalInsertNodeBefore(this.head, node);
				this.head = node;
			}
			node.list = this;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00004258 File Offset: 0x00002458
		public LinkedListNode<T> AddLast(T value)
		{
			LinkedListNode<T> linkedListNode = new LinkedListNode<T>(this, value);
			if (this.head == null)
			{
				this.InternalInsertNodeToEmptyList(linkedListNode);
			}
			else
			{
				this.InternalInsertNodeBefore(this.head, linkedListNode);
			}
			return linkedListNode;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000428C File Offset: 0x0000248C
		public void AddLast(LinkedListNode<T> node)
		{
			LinkedList<T>.ValidateNewNode(node);
			if (this.head == null)
			{
				this.InternalInsertNodeToEmptyList(node);
			}
			else
			{
				this.InternalInsertNodeBefore(this.head, node);
			}
			node.list = this;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000042BC File Offset: 0x000024BC
		public void Clear()
		{
			LinkedListNode<T> next = this.head;
			while (next != null)
			{
				LinkedListNode<T> linkedListNode = next;
				next = next.Next;
				linkedListNode.Invalidate();
			}
			this.head = null;
			this.count = 0;
			this.version++;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00004300 File Offset: 0x00002500
		public bool Contains(T value)
		{
			return this.Find(value) != null;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000430C File Offset: 0x0000250C
		public void CopyTo(T[] array, int index)
		{
			ArgumentNullException.ThrowIfNull(array, "array");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			if (index > array.Length)
			{
				throw new ArgumentOutOfRangeException("index", index, SR.ArgumentOutOfRange_BiggerThanCollection);
			}
			if (array.Length - index < this.Count)
			{
				throw new ArgumentException(SR.Arg_InsufficientSpace);
			}
			LinkedListNode<T> next = this.head;
			if (next != null)
			{
				do
				{
					array[index++] = next.item;
					next = next.next;
				}
				while (next != this.head);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00004390 File Offset: 0x00002590
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public LinkedListNode<T> Find(T value)
		{
			LinkedListNode<T> next = this.head;
			EqualityComparer<T> @default = EqualityComparer<T>.Default;
			if (next != null)
			{
				if (value != null)
				{
					while (!@default.Equals(next.item, value))
					{
						next = next.next;
						if (next == this.head)
						{
							goto IL_5A;
						}
					}
					return next;
				}
				while (next.item != null)
				{
					next = next.next;
					if (next == this.head)
					{
						goto IL_5A;
					}
				}
				return next;
			}
			IL_5A:
			return null;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000043F8 File Offset: 0x000025F8
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public LinkedListNode<T> FindLast(T value)
		{
			if (this.head == null)
			{
				return null;
			}
			LinkedListNode<T> prev = this.head.prev;
			LinkedListNode<T> linkedListNode = prev;
			EqualityComparer<T> @default = EqualityComparer<T>.Default;
			if (linkedListNode != null)
			{
				if (value != null)
				{
					while (!@default.Equals(linkedListNode.item, value))
					{
						linkedListNode = linkedListNode.prev;
						if (linkedListNode == prev)
						{
							goto IL_61;
						}
					}
					return linkedListNode;
				}
				while (linkedListNode.item != null)
				{
					linkedListNode = linkedListNode.prev;
					if (linkedListNode == prev)
					{
						goto IL_61;
					}
				}
				return linkedListNode;
			}
			IL_61:
			return null;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00004467 File Offset: 0x00002667
		[NullableContext(0)]
		public LinkedList<T>.Enumerator GetEnumerator()
		{
			return new LinkedList<T>.Enumerator(this);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00004470 File Offset: 0x00002670
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			if (this.Count != 0)
			{
				return this.GetEnumerator();
			}
			return EnumerableHelpers.GetEmptyEnumerator<T>();
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004498 File Offset: 0x00002698
		public bool Remove(T value)
		{
			LinkedListNode<T> linkedListNode = this.Find(value);
			if (linkedListNode != null)
			{
				this.InternalRemoveNode(linkedListNode);
				return true;
			}
			return false;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000044BA File Offset: 0x000026BA
		public void Remove(LinkedListNode<T> node)
		{
			this.ValidateNode(node);
			this.InternalRemoveNode(node);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000044CA File Offset: 0x000026CA
		public void RemoveFirst()
		{
			if (this.head == null)
			{
				throw new InvalidOperationException(SR.LinkedListEmpty);
			}
			this.InternalRemoveNode(this.head);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000044EB File Offset: 0x000026EB
		public void RemoveLast()
		{
			if (this.head == null)
			{
				throw new InvalidOperationException(SR.LinkedListEmpty);
			}
			this.InternalRemoveNode(this.head.prev);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00004514 File Offset: 0x00002714
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			ArgumentNullException.ThrowIfNull(info, "info");
			info.AddValue("Version", this.version);
			info.AddValue("Count", this.count);
			if (this.count != 0)
			{
				T[] array = new T[this.count];
				this.CopyTo(array, 0);
				info.AddValue("Data", array, typeof(T[]));
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004580 File Offset: 0x00002780
		[NullableContext(2)]
		public virtual void OnDeserialization(object sender)
		{
			if (this._siInfo == null)
			{
				return;
			}
			int @int = this._siInfo.GetInt32("Version");
			if (this._siInfo.GetInt32("Count") != 0)
			{
				T[] array = (T[])this._siInfo.GetValue("Data", typeof(T[]));
				if (array == null)
				{
					throw new SerializationException(SR.Serialization_MissingValues);
				}
				for (int i = 0; i < array.Length; i++)
				{
					this.AddLast(array[i]);
				}
			}
			else
			{
				this.head = null;
			}
			this.version = @int;
			this._siInfo = null;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000461C File Offset: 0x0000281C
		private void InternalInsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
		{
			newNode.next = node;
			newNode.prev = node.prev;
			node.prev.next = newNode;
			node.prev = newNode;
			this.version++;
			this.count++;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000466B File Offset: 0x0000286B
		private void InternalInsertNodeToEmptyList(LinkedListNode<T> newNode)
		{
			newNode.next = newNode;
			newNode.prev = newNode;
			this.head = newNode;
			this.version++;
			this.count++;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000046A0 File Offset: 0x000028A0
		internal void InternalRemoveNode(LinkedListNode<T> node)
		{
			if (node.next == node)
			{
				this.head = null;
			}
			else
			{
				node.next.prev = node.prev;
				node.prev.next = node.next;
				if (this.head == node)
				{
					this.head = node.next;
				}
			}
			node.Invalidate();
			this.count--;
			this.version++;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00004718 File Offset: 0x00002918
		internal static void ValidateNewNode(LinkedListNode<T> node)
		{
			ArgumentNullException.ThrowIfNull(node, "node");
			if (node.list != null)
			{
				throw new InvalidOperationException(SR.LinkedListNodeIsAttached);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00004738 File Offset: 0x00002938
		internal void ValidateNode(LinkedListNode<T> node)
		{
			ArgumentNullException.ThrowIfNull(node, "node");
			if (node.list != this)
			{
				throw new InvalidOperationException(SR.ExternalLinkedListNode);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00003925 File Offset: 0x00001B25
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00003922 File Offset: 0x00001B22
		object ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000475C File Offset: 0x0000295C
		void ICollection.CopyTo(Array array, int index)
		{
			ArgumentNullException.ThrowIfNull(array, "array");
			if (array.Rank != 1)
			{
				throw new ArgumentException(SR.Arg_RankMultiDimNotSupported, "array");
			}
			if (array.GetLowerBound(0) != 0)
			{
				throw new ArgumentException(SR.Arg_NonZeroLowerBound, "array");
			}
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			if (array.Length - index < this.Count)
			{
				throw new ArgumentException(SR.Arg_InsufficientSpace);
			}
			T[] array2 = array as T[];
			if (array2 != null)
			{
				this.CopyTo(array2, index);
				return;
			}
			object[] array3 = array as object[];
			if (array3 == null)
			{
				throw new ArgumentException(SR.Argument_IncompatibleArrayType, "array");
			}
			LinkedListNode<T> next = this.head;
			try
			{
				if (next != null)
				{
					do
					{
						array3[index++] = next.item;
						next = next.next;
					}
					while (next != this.head);
				}
			}
			catch (ArrayTypeMismatchException)
			{
				throw new ArgumentException(SR.Argument_IncompatibleArrayType, "array");
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000484C File Offset: 0x00002A4C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<!0>)this).GetEnumerator();
		}

		// Token: 0x04000014 RID: 20
		internal LinkedListNode<T> head;

		// Token: 0x04000015 RID: 21
		internal int count;

		// Token: 0x04000016 RID: 22
		internal int version;

		// Token: 0x04000017 RID: 23
		private SerializationInfo _siInfo;

		// Token: 0x02000013 RID: 19
		[NullableContext(0)]
		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable, ISerializable, IDeserializationCallback
		{
			// Token: 0x060000B3 RID: 179 RVA: 0x00004854 File Offset: 0x00002A54
			internal Enumerator(LinkedList<T> list)
			{
				this._list = list;
				this._version = list.version;
				this._node = list.head;
				this._current = default(T);
				this._index = 0;
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x060000B4 RID: 180 RVA: 0x00004888 File Offset: 0x00002A88
			[Nullable(1)]
			public T Current
			{
				[NullableContext(1)]
				get
				{
					return this._current;
				}
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x060000B5 RID: 181 RVA: 0x00004890 File Offset: 0x00002A90
			[Nullable(2)]
			object IEnumerator.Current
			{
				get
				{
					if (this._index == 0 || this._index == this._list.Count + 1)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
					}
					return this.Current;
				}
			}

			// Token: 0x060000B6 RID: 182 RVA: 0x000048C8 File Offset: 0x00002AC8
			public bool MoveNext()
			{
				if (this._version != this._list.version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
				if (this._node == null)
				{
					this._index = this._list.Count + 1;
					return false;
				}
				this._index++;
				this._current = this._node.item;
				this._node = this._node.next;
				if (this._node == this._list.head)
				{
					this._node = null;
				}
				return true;
			}

			// Token: 0x060000B7 RID: 183 RVA: 0x0000495C File Offset: 0x00002B5C
			void IEnumerator.Reset()
			{
				if (this._version != this._list.version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
				this._current = default(T);
				this._node = this._list.head;
				this._index = 0;
			}

			// Token: 0x060000B8 RID: 184 RVA: 0x000049AB File Offset: 0x00002BAB
			public void Dispose()
			{
			}

			// Token: 0x060000B9 RID: 185 RVA: 0x000049AD File Offset: 0x00002BAD
			void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060000BA RID: 186 RVA: 0x000049AD File Offset: 0x00002BAD
			void IDeserializationCallback.OnDeserialization(object sender)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x04000018 RID: 24
			private readonly LinkedList<T> _list;

			// Token: 0x04000019 RID: 25
			private LinkedListNode<T> _node;

			// Token: 0x0400001A RID: 26
			private readonly int _version;

			// Token: 0x0400001B RID: 27
			private T _current;

			// Token: 0x0400001C RID: 28
			private int _index;
		}
	}
}

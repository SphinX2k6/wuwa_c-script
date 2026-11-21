using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Collections.ObjectModel
{
	// Token: 0x02000986 RID: 2438
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class Collection<[Nullable(2)] T> : IList<!0>, ICollection<!0>, IEnumerable<!0>, IEnumerable, IList, ICollection, IReadOnlyList<!0>, IReadOnlyCollection<T>
	{
		// Token: 0x060090C6 RID: 37062 RVA: 0x00166135 File Offset: 0x00164335
		public Collection()
		{
			this.items = new List<T>();
		}

		// Token: 0x060090C7 RID: 37063 RVA: 0x00166148 File Offset: 0x00164348
		public Collection(IList<T> list)
		{
			if (list == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.list);
			}
			this.items = list;
		}

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x060090C8 RID: 37064 RVA: 0x00166161 File Offset: 0x00164361
		public int Count
		{
			get
			{
				return this.items.Count;
			}
		}

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x060090C9 RID: 37065 RVA: 0x0016616E File Offset: 0x0016436E
		protected IList<T> Items
		{
			get
			{
				return this.items;
			}
		}

		// Token: 0x1700138E RID: 5006
		public T this[int index]
		{
			get
			{
				return this.items[index];
			}
			set
			{
				if (this.items.IsReadOnly)
				{
					ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
				}
				if (index >= this.items.Count)
				{
					ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
				}
				this.SetItem(index, value);
			}
		}

		// Token: 0x060090CC RID: 37068 RVA: 0x001661B4 File Offset: 0x001643B4
		public void Add(T item)
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			int count = this.items.Count;
			this.InsertItem(count, item);
		}

		// Token: 0x060090CD RID: 37069 RVA: 0x001661E8 File Offset: 0x001643E8
		public void Clear()
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			this.ClearItems();
		}

		// Token: 0x060090CE RID: 37070 RVA: 0x00166203 File Offset: 0x00164403
		public void CopyTo(T[] array, int index)
		{
			this.items.CopyTo(array, index);
		}

		// Token: 0x060090CF RID: 37071 RVA: 0x00166212 File Offset: 0x00164412
		public bool Contains(T item)
		{
			return this.items.Contains(item);
		}

		// Token: 0x060090D0 RID: 37072 RVA: 0x00166220 File Offset: 0x00164420
		public IEnumerator<T> GetEnumerator()
		{
			return this.items.GetEnumerator();
		}

		// Token: 0x060090D1 RID: 37073 RVA: 0x0016622D File Offset: 0x0016442D
		public int IndexOf(T item)
		{
			return this.items.IndexOf(item);
		}

		// Token: 0x060090D2 RID: 37074 RVA: 0x0016623B File Offset: 0x0016443B
		public void Insert(int index, T item)
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			if (index > this.items.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
			}
			this.InsertItem(index, item);
		}

		// Token: 0x060090D3 RID: 37075 RVA: 0x0016626C File Offset: 0x0016446C
		public bool Remove(T item)
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			int num = this.items.IndexOf(item);
			if (num < 0)
			{
				return false;
			}
			this.RemoveItem(num);
			return true;
		}

		// Token: 0x060090D4 RID: 37076 RVA: 0x001662A7 File Offset: 0x001644A7
		public void RemoveAt(int index)
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			if (index >= this.items.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessException();
			}
			this.RemoveItem(index);
		}

		// Token: 0x060090D5 RID: 37077 RVA: 0x001662D6 File Offset: 0x001644D6
		protected virtual void ClearItems()
		{
			this.items.Clear();
		}

		// Token: 0x060090D6 RID: 37078 RVA: 0x001662E3 File Offset: 0x001644E3
		protected virtual void InsertItem(int index, T item)
		{
			this.items.Insert(index, item);
		}

		// Token: 0x060090D7 RID: 37079 RVA: 0x001662F2 File Offset: 0x001644F2
		protected virtual void RemoveItem(int index)
		{
			this.items.RemoveAt(index);
		}

		// Token: 0x060090D8 RID: 37080 RVA: 0x00166300 File Offset: 0x00164500
		protected virtual void SetItem(int index, T item)
		{
			this.items[index] = item;
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x060090D9 RID: 37081 RVA: 0x0016630F File Offset: 0x0016450F
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return this.items.IsReadOnly;
			}
		}

		// Token: 0x060090DA RID: 37082 RVA: 0x0016631C File Offset: 0x0016451C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.items.GetEnumerator();
		}

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x060090DB RID: 37083 RVA: 0x00007B65 File Offset: 0x00005D65
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x060090DC RID: 37084 RVA: 0x0016632C File Offset: 0x0016452C
		object ICollection.SyncRoot
		{
			get
			{
				ICollection collection = this.items as ICollection;
				if (collection == null)
				{
					return this;
				}
				return collection.SyncRoot;
			}
		}

		// Token: 0x060090DD RID: 37085 RVA: 0x00166350 File Offset: 0x00164550
		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
			}
			if (array.Rank != 1)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_RankMultiDimNotSupported);
			}
			if (array.GetLowerBound(0) != 0)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_NonZeroLowerBound);
			}
			if (index < 0)
			{
				ThrowHelper.ThrowIndexArgumentOutOfRange_NeedNonNegNumException();
			}
			if (array.Length - index < this.Count)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ArrayPlusOffTooSmall);
			}
			T[] array2 = array as T[];
			if (array2 != null)
			{
				this.items.CopyTo(array2, index);
				return;
			}
			Type elementType = array.GetType().GetElementType();
			Type typeFromHandle = typeof(T);
			if (!elementType.IsAssignableFrom(typeFromHandle) && !typeFromHandle.IsAssignableFrom(elementType))
			{
				ThrowHelper.ThrowArgumentException_Argument_IncompatibleArrayType();
			}
			object[] array3 = array as object[];
			if (array3 == null)
			{
				ThrowHelper.ThrowArgumentException_Argument_IncompatibleArrayType();
			}
			int count = this.items.Count;
			try
			{
				for (int i = 0; i < count; i++)
				{
					array3[index++] = this.items[i];
				}
			}
			catch (ArrayTypeMismatchException)
			{
				ThrowHelper.ThrowArgumentException_Argument_IncompatibleArrayType();
			}
		}

		// Token: 0x17001392 RID: 5010
		[Nullable(2)]
		object IList.this[int index]
		{
			get
			{
				return this.items[index];
			}
			set
			{
				ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(value, ExceptionArgument.value);
				T value2 = default(T);
				try
				{
					value2 = (T)((object)value);
				}
				catch (InvalidCastException)
				{
					ThrowHelper.ThrowWrongValueTypeArgumentException<object>(value, typeof(T));
				}
				this[index] = value2;
			}
		}

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x060090E0 RID: 37088 RVA: 0x0016630F File Offset: 0x0016450F
		bool IList.IsReadOnly
		{
			get
			{
				return this.items.IsReadOnly;
			}
		}

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x060090E1 RID: 37089 RVA: 0x001664B0 File Offset: 0x001646B0
		bool IList.IsFixedSize
		{
			get
			{
				IList list = this.items as IList;
				if (list != null)
				{
					return list.IsFixedSize;
				}
				return this.items.IsReadOnly;
			}
		}

		// Token: 0x060090E2 RID: 37090 RVA: 0x001664E0 File Offset: 0x001646E0
		int IList.Add(object value)
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(value, ExceptionArgument.value);
			T item = default(T);
			try
			{
				item = (T)((object)value);
			}
			catch (InvalidCastException)
			{
				ThrowHelper.ThrowWrongValueTypeArgumentException<object>(value, typeof(T));
			}
			this.Add(item);
			return this.Count - 1;
		}

		// Token: 0x060090E3 RID: 37091 RVA: 0x0016654C File Offset: 0x0016474C
		bool IList.Contains(object value)
		{
			return Collection<T>.IsCompatibleObject(value) && this.Contains((T)((object)value));
		}

		// Token: 0x060090E4 RID: 37092 RVA: 0x00166564 File Offset: 0x00164764
		int IList.IndexOf(object value)
		{
			if (Collection<T>.IsCompatibleObject(value))
			{
				return this.IndexOf((T)((object)value));
			}
			return -1;
		}

		// Token: 0x060090E5 RID: 37093 RVA: 0x0016657C File Offset: 0x0016477C
		void IList.Insert(int index, object value)
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(value, ExceptionArgument.value);
			T item = default(T);
			try
			{
				item = (T)((object)value);
			}
			catch (InvalidCastException)
			{
				ThrowHelper.ThrowWrongValueTypeArgumentException<object>(value, typeof(T));
			}
			this.Insert(index, item);
		}

		// Token: 0x060090E6 RID: 37094 RVA: 0x001665E0 File Offset: 0x001647E0
		void IList.Remove(object value)
		{
			if (this.items.IsReadOnly)
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
			if (Collection<T>.IsCompatibleObject(value))
			{
				this.Remove((T)((object)value));
			}
		}

		// Token: 0x060090E7 RID: 37095 RVA: 0x0016660C File Offset: 0x0016480C
		private static bool IsCompatibleObject(object value)
		{
			return value is T || (value == null && default(T) == null);
		}

		// Token: 0x04002222 RID: 8738
		private readonly IList<T> items;
	}
}

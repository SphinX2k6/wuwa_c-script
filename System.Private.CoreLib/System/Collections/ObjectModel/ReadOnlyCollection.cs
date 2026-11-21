using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Collections.ObjectModel
{
	// Token: 0x02000988 RID: 2440
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class ReadOnlyCollection<[Nullable(2)] T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<!0>, IReadOnlyCollection<T>
	{
		// Token: 0x060090EA RID: 37098 RVA: 0x00166778 File Offset: 0x00164978
		public ReadOnlyCollection(IList<T> list)
		{
			if (list == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.list);
			}
			this.list = list;
		}

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x060090EB RID: 37099 RVA: 0x00166791 File Offset: 0x00164991
		public static ReadOnlyCollection<T> Empty { get; } = new ReadOnlyCollection<T>(Array.Empty<T>());

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x060090EC RID: 37100 RVA: 0x00166798 File Offset: 0x00164998
		public int Count
		{
			get
			{
				return this.list.Count;
			}
		}

		// Token: 0x17001397 RID: 5015
		public T this[int index]
		{
			get
			{
				return this.list[index];
			}
		}

		// Token: 0x060090EE RID: 37102 RVA: 0x001667B3 File Offset: 0x001649B3
		public bool Contains(T value)
		{
			return this.list.Contains(value);
		}

		// Token: 0x060090EF RID: 37103 RVA: 0x001667C1 File Offset: 0x001649C1
		public void CopyTo(T[] array, int index)
		{
			this.list.CopyTo(array, index);
		}

		// Token: 0x060090F0 RID: 37104 RVA: 0x001667D0 File Offset: 0x001649D0
		public IEnumerator<T> GetEnumerator()
		{
			if (this.list.Count != 0)
			{
				return this.list.GetEnumerator();
			}
			return SZGenericArrayEnumerator<T>.Empty;
		}

		// Token: 0x060090F1 RID: 37105 RVA: 0x001667FD File Offset: 0x001649FD
		public int IndexOf(T value)
		{
			return this.list.IndexOf(value);
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x060090F2 RID: 37106 RVA: 0x0016680B File Offset: 0x00164A0B
		protected IList<T> Items
		{
			get
			{
				return this.list;
			}
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x060090F3 RID: 37107 RVA: 0x000070DD File Offset: 0x000052DD
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700139A RID: 5018
		T IList<!0>.this[int index]
		{
			get
			{
				return this.list[index];
			}
			set
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
		}

		// Token: 0x060090F6 RID: 37110 RVA: 0x00007109 File Offset: 0x00005309
		void ICollection<!0>.Add(T value)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}

		// Token: 0x060090F7 RID: 37111 RVA: 0x00007109 File Offset: 0x00005309
		void ICollection<!0>.Clear()
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}

		// Token: 0x060090F8 RID: 37112 RVA: 0x00007109 File Offset: 0x00005309
		void IList<!0>.Insert(int index, T value)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}

		// Token: 0x060090F9 RID: 37113 RVA: 0x00166813 File Offset: 0x00164A13
		bool ICollection<!0>.Remove(T value)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			return false;
		}

		// Token: 0x060090FA RID: 37114 RVA: 0x00007109 File Offset: 0x00005309
		void IList<!0>.RemoveAt(int index)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}

		// Token: 0x060090FB RID: 37115 RVA: 0x0016681C File Offset: 0x00164A1C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.list.GetEnumerator();
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x060090FC RID: 37116 RVA: 0x00007B65 File Offset: 0x00005D65
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x060090FD RID: 37117 RVA: 0x0016682C File Offset: 0x00164A2C
		object ICollection.SyncRoot
		{
			get
			{
				ICollection collection = this.list as ICollection;
				if (collection == null)
				{
					return this;
				}
				return collection.SyncRoot;
			}
		}

		// Token: 0x060090FE RID: 37118 RVA: 0x00166850 File Offset: 0x00164A50
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
				this.list.CopyTo(array2, index);
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
			int count = this.list.Count;
			try
			{
				for (int i = 0; i < count; i++)
				{
					array3[index++] = this.list[i];
				}
			}
			catch (ArrayTypeMismatchException)
			{
				ThrowHelper.ThrowArgumentException_Argument_IncompatibleArrayType();
			}
		}

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x060090FF RID: 37119 RVA: 0x000070DD File Offset: 0x000052DD
		bool IList.IsFixedSize
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x06009100 RID: 37120 RVA: 0x000070DD File Offset: 0x000052DD
		bool IList.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700139F RID: 5023
		[Nullable(2)]
		object IList.this[int index]
		{
			get
			{
				return this.list[index];
			}
			set
			{
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			}
		}

		// Token: 0x06009103 RID: 37123 RVA: 0x0016695F File Offset: 0x00164B5F
		int IList.Add(object value)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
			return -1;
		}

		// Token: 0x06009104 RID: 37124 RVA: 0x00007109 File Offset: 0x00005309
		void IList.Clear()
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}

		// Token: 0x06009105 RID: 37125 RVA: 0x00166968 File Offset: 0x00164B68
		private static bool IsCompatibleObject(object value)
		{
			return value is T || (value == null && default(T) == null);
		}

		// Token: 0x06009106 RID: 37126 RVA: 0x00166995 File Offset: 0x00164B95
		bool IList.Contains(object value)
		{
			return ReadOnlyCollection<T>.IsCompatibleObject(value) && this.Contains((T)((object)value));
		}

		// Token: 0x06009107 RID: 37127 RVA: 0x001669AD File Offset: 0x00164BAD
		int IList.IndexOf(object value)
		{
			if (ReadOnlyCollection<T>.IsCompatibleObject(value))
			{
				return this.IndexOf((T)((object)value));
			}
			return -1;
		}

		// Token: 0x06009108 RID: 37128 RVA: 0x00007109 File Offset: 0x00005309
		void IList.Insert(int index, object value)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}

		// Token: 0x06009109 RID: 37129 RVA: 0x00007109 File Offset: 0x00005309
		void IList.Remove(object value)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}

		// Token: 0x0600910A RID: 37130 RVA: 0x00007109 File Offset: 0x00005309
		void IList.RemoveAt(int index)
		{
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.NotSupported_ReadOnlyCollection);
		}

		// Token: 0x04002223 RID: 8739
		private readonly IList<T> list;
	}
}

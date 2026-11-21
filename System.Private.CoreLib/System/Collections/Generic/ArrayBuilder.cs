using System;
using System.Reflection;

namespace System.Collections.Generic
{
	// Token: 0x020009A6 RID: 2470
	[DefaultMember("Item")]
	internal struct ArrayBuilder<T>
	{
		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x060091F9 RID: 37369 RVA: 0x0016AB58 File Offset: 0x00168D58
		public int Capacity
		{
			get
			{
				T[] array = this._array;
				if (array == null)
				{
					return 0;
				}
				return array.Length;
			}
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x060091FA RID: 37370 RVA: 0x0016AB68 File Offset: 0x00168D68
		public int Count
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x060091FB RID: 37371 RVA: 0x0016AB70 File Offset: 0x00168D70
		public void Add(T item)
		{
			if (this._count == this.Capacity)
			{
				this.EnsureCapacity(this._count + 1);
			}
			this.UncheckedAdd(item);
		}

		// Token: 0x060091FC RID: 37372 RVA: 0x0016AB98 File Offset: 0x00168D98
		public T[] ToArray()
		{
			if (this._count == 0)
			{
				return Array.Empty<T>();
			}
			T[] array = this._array;
			if (this._count < array.Length)
			{
				array = new T[this._count];
				Array.Copy(this._array, array, this._count);
			}
			return array;
		}

		// Token: 0x060091FD RID: 37373 RVA: 0x0016ABE4 File Offset: 0x00168DE4
		public void UncheckedAdd(T item)
		{
			T[] array = this._array;
			int count = this._count;
			this._count = count + 1;
			array[count] = item;
		}

		// Token: 0x060091FE RID: 37374 RVA: 0x0016AC10 File Offset: 0x00168E10
		private void EnsureCapacity(int minimum)
		{
			int capacity = this.Capacity;
			int num = (capacity == 0) ? 4 : (2 * capacity);
			if (num > 2147483591)
			{
				num = Math.Max(capacity + 1, 2147483591);
			}
			num = Math.Max(num, minimum);
			T[] array = new T[num];
			if (this._count > 0)
			{
				Array.Copy(this._array, array, this._count);
			}
			this._array = array;
		}

		// Token: 0x0400225D RID: 8797
		private T[] _array;

		// Token: 0x0400225E RID: 8798
		private int _count;
	}
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace System
{
	// Token: 0x020000D2 RID: 210
	internal sealed class SZGenericArrayEnumerator<T> : SZGenericArrayEnumeratorBase, IEnumerator<T>, IDisposable, IEnumerator
	{
		// Token: 0x06000A0A RID: 2570 RVA: 0x0001EAAE File Offset: 0x0001CCAE
		internal SZGenericArrayEnumerator(T[] array, int endIndex) : base(endIndex)
		{
			this._array = array;
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x0001EABE File Offset: 0x0001CCBE
		public T Current
		{
			get
			{
				if (this._index >= this._endIndex)
				{
					ThrowHelper.ThrowInvalidOperationException_EnumCurrent(this._index);
				}
				return this._array[this._index];
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x0001EAEA File Offset: 0x0001CCEA
		object IEnumerator.Current
		{
			get
			{
				return this.Current;
			}
		}

		// Token: 0x040002DD RID: 733
		private readonly T[] _array;

		// Token: 0x040002DE RID: 734
		internal static readonly SZGenericArrayEnumerator<T> Empty = new SZGenericArrayEnumerator<T>(null, 0);
	}
}

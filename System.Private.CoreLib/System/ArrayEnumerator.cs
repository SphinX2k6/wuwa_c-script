using System;
using System.Collections;

namespace System
{
	// Token: 0x020000D0 RID: 208
	internal sealed class ArrayEnumerator : IEnumerator, ICloneable
	{
		// Token: 0x06000A01 RID: 2561 RVA: 0x0001E9C5 File Offset: 0x0001CBC5
		internal ArrayEnumerator(Array array)
		{
			this._array = array;
			this._index = (IntPtr)(-1);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00007BA1 File Offset: 0x00005DA1
		public object Clone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0001E9DC File Offset: 0x0001CBDC
		public bool MoveNext()
		{
			IntPtr intPtr = this._index + (IntPtr)1;
			UIntPtr nativeLength = this._array.NativeLength;
			if (intPtr >= (IntPtr)nativeLength)
			{
				this._index = (IntPtr)nativeLength;
				return false;
			}
			this._index = intPtr;
			return true;
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x0001EA14 File Offset: 0x0001CC14
		public object Current
		{
			get
			{
				IntPtr index = this._index;
				Array array = this._array;
				if (index >= (IntPtr)array.NativeLength)
				{
					if (index < (IntPtr)0)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumNotStarted();
					}
					else
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumEnded();
					}
				}
				return array.InternalGetValue(index);
			}
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x0001EA50 File Offset: 0x0001CC50
		public void Reset()
		{
			this._index = (IntPtr)(-1);
		}

		// Token: 0x040002D9 RID: 729
		private readonly Array _array;

		// Token: 0x040002DA RID: 730
		private IntPtr _index;
	}
}

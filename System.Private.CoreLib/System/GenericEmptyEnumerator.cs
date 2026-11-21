using System;
using System.Collections;
using System.Collections.Generic;

namespace System
{
	// Token: 0x020000D4 RID: 212
	internal sealed class GenericEmptyEnumerator<T> : GenericEmptyEnumeratorBase, IEnumerator<T>, IDisposable, IEnumerator
	{
		// Token: 0x06000A13 RID: 2579 RVA: 0x0001EB0E File Offset: 0x0001CD0E
		private GenericEmptyEnumerator()
		{
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x0001EB18 File Offset: 0x0001CD18
		public new T Current
		{
			get
			{
				ThrowHelper.ThrowInvalidOperationException_EnumCurrent(-1);
				return default(T);
			}
		}

		// Token: 0x040002DF RID: 735
		public static readonly GenericEmptyEnumerator<T> Instance = new GenericEmptyEnumerator<T>();
	}
}

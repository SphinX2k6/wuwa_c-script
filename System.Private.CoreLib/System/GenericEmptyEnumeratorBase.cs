using System;
using System.Collections;

namespace System
{
	// Token: 0x020000D3 RID: 211
	internal abstract class GenericEmptyEnumeratorBase : IDisposable, IEnumerator
	{
		// Token: 0x06000A0E RID: 2574 RVA: 0x00007B65 File Offset: 0x00005D65
		public bool MoveNext()
		{
			return false;
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0001EB05 File Offset: 0x0001CD05
		public object Current
		{
			get
			{
				ThrowHelper.ThrowInvalidOperationException_EnumCurrent(-1);
				return null;
			}
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public void Reset()
		{
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public void Dispose()
		{
		}
	}
}

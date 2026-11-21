using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006E8 RID: 1768
	[CompilerFeatureRequired("RefStructs")]
	internal ref struct ObjectHandleOnStack
	{
		// Token: 0x06007513 RID: 29971 RVA: 0x0011665E File Offset: 0x0011485E
		private unsafe ObjectHandleOnStack(void* pObject)
		{
			this._ptr = pObject;
		}

		// Token: 0x06007514 RID: 29972 RVA: 0x00116667 File Offset: 0x00114867
		internal static ObjectHandleOnStack Create<T>(ref T o) where T : class
		{
			return new ObjectHandleOnStack(Unsafe.AsPointer<T>(ref o));
		}

		// Token: 0x04001512 RID: 5394
		private unsafe void* _ptr;
	}
}

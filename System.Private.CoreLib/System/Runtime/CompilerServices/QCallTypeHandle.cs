using System;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006EA RID: 1770
	[CompilerFeatureRequired("RefStructs")]
	internal ref struct QCallTypeHandle
	{
		// Token: 0x06007516 RID: 29974 RVA: 0x0011669A File Offset: 0x0011489A
		internal QCallTypeHandle(ref RuntimeType type)
		{
			this._ptr = Unsafe.AsPointer<RuntimeType>(ref type);
			RuntimeType runtimeType = type;
			this._handle = ((runtimeType != null) ? runtimeType.GetUnderlyingNativeHandle() : IntPtr.Zero);
		}

		// Token: 0x06007517 RID: 29975 RVA: 0x001166C0 File Offset: 0x001148C0
		internal QCallTypeHandle(ref RuntimeTypeHandle rth)
		{
			this._ptr = Unsafe.AsPointer<RuntimeTypeHandle>(ref rth);
			this._handle = rth.Value;
		}

		// Token: 0x04001515 RID: 5397
		private unsafe void* _ptr;

		// Token: 0x04001516 RID: 5398
		private IntPtr _handle;
	}
}

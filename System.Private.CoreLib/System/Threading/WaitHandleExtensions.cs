using System;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	// Token: 0x0200045E RID: 1118
	[NullableContext(1)]
	[Nullable(0)]
	public static class WaitHandleExtensions
	{
		// Token: 0x06004321 RID: 17185 RVA: 0x000DFC86 File Offset: 0x000DDE86
		public static SafeWaitHandle GetSafeWaitHandle(this WaitHandle waitHandle)
		{
			ArgumentNullException.ThrowIfNull(waitHandle, "waitHandle");
			return waitHandle.SafeWaitHandle;
		}

		// Token: 0x06004322 RID: 17186 RVA: 0x000DFC99 File Offset: 0x000DDE99
		public static void SetSafeWaitHandle(this WaitHandle waitHandle, [Nullable(2)] SafeWaitHandle value)
		{
			ArgumentNullException.ThrowIfNull(waitHandle, "waitHandle");
			waitHandle.SafeWaitHandle = value;
		}
	}
}

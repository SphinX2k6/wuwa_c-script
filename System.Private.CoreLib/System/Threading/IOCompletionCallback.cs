using System;

namespace System.Threading
{
	// Token: 0x020003EB RID: 1003
	// (Invoke) Token: 0x0600402F RID: 16431
	[CLSCompliant(false)]
	public unsafe delegate void IOCompletionCallback(uint errorCode, uint numBytes, NativeOverlapped* pOVERLAP);
}

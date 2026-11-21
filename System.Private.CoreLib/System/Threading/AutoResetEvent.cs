using System;

namespace System.Threading
{
	// Token: 0x020003D3 RID: 979
	public sealed class AutoResetEvent : EventWaitHandle
	{
		// Token: 0x06003F92 RID: 16274 RVA: 0x000D4AD0 File Offset: 0x000D2CD0
		public AutoResetEvent(bool initialState) : base(initialState, EventResetMode.AutoReset)
		{
		}
	}
}

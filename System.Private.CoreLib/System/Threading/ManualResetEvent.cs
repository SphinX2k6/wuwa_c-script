using System;

namespace System.Threading
{
	// Token: 0x020003FA RID: 1018
	public sealed class ManualResetEvent : EventWaitHandle
	{
		// Token: 0x060040A3 RID: 16547 RVA: 0x000D789C File Offset: 0x000D5A9C
		public ManualResetEvent(bool initialState) : base(initialState, EventResetMode.ManualReset)
		{
		}
	}
}

using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014ED RID: 5357
	public class ChangeTimer_SetValue
	{
		// Token: 0x040046A9 RID: 18089
		public ETimerType TimerType;

		// Token: 0x040046AA RID: 18090
		[Nullable(1)]
		public IChangeTimerType ChangeType;
	}
}

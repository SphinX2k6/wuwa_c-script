using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008C5 RID: 2245
	public class TimeScheduleComponent_SetValue
	{
		// Token: 0x0400212A RID: 8490
		public bool? Disabled;

		// Token: 0x0400212B RID: 8491
		public bool? EdIsLocked;

		// Token: 0x0400212C RID: 8492
		[Nullable(1)]
		public List<ITimeScheduleConfig> TimeScheduleConfigs;
	}
}

using System;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011E4 RID: 4580
	public class IQuestScheduleTimeLeft_SetValue
	{
		// Token: 0x04003D7D RID: 15741
		public EQuestScheduleType Type;

		// Token: 0x04003D7E RID: 15742
		public ETimerType TimerType;

		// Token: 0x04003D7F RID: 15743
		public int TimeLeft;

		// Token: 0x04003D80 RID: 15744
		public ETimeLeftIconType IconType;

		// Token: 0x04003D81 RID: 15745
		public bool? ShowTime;
	}
}

using System;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010B6 RID: 4278
	public class IQuestScheduleTimeLeft_SetValue
	{
		// Token: 0x04003A30 RID: 14896
		public EQuestScheduleType Type;

		// Token: 0x04003A31 RID: 14897
		public ETimerType TimerType;

		// Token: 0x04003A32 RID: 14898
		public int TimeLeft;

		// Token: 0x04003A33 RID: 14899
		public ETimeLeftIconType IconType;

		// Token: 0x04003A34 RID: 14900
		public bool? ShowTime;
	}
}

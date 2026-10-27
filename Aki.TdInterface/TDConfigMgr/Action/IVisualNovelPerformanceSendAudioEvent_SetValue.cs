using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002094 RID: 8340
	public class IVisualNovelPerformanceSendAudioEvent_SetValue
	{
		// Token: 0x04006E17 RID: 28183
		public EVisualNovelPerformanceType Type;

		// Token: 0x04006E18 RID: 28184
		public float? StartTime;

		// Token: 0x04006E19 RID: 28185
		[Nullable(1)]
		public string AudioEvent;

		// Token: 0x04006E1A RID: 28186
		public float? EndFadeOutTime;

		// Token: 0x04006E1B RID: 28187
		public bool? IsNotCountTimeAndNotInterrupted;
	}
}

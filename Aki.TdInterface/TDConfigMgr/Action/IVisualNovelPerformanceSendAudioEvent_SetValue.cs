using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022DF RID: 8927
	public class IVisualNovelPerformanceSendAudioEvent_SetValue
	{
		// Token: 0x04007423 RID: 29731
		public EVisualNovelPerformanceType Type;

		// Token: 0x04007424 RID: 29732
		public float? StartTime;

		// Token: 0x04007425 RID: 29733
		public string AudioEvent;

		// Token: 0x04007426 RID: 29734
		public float? EndFadeOutTime;

		// Token: 0x04007427 RID: 29735
		public bool? IsNotCountTimeAndNotInterrupted;

		// Token: 0x04007428 RID: 29736
		public bool? SkipOnUltraFastForward;
	}
}

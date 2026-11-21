using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F2E RID: 7982
	public class IPlayRegisteredMontageRender_SetValue
	{
		// Token: 0x040065EC RID: 26092
		public int EntityId;

		// Token: 0x040065ED RID: 26093
		public bool? IsOverlayMontage;

		// Token: 0x040065EE RID: 26094
		public IMontageId MontageId;

		// Token: 0x040065EF RID: 26095
		public int? FaceExpressionId;

		// Token: 0x040065F0 RID: 26096
		public float? LoopDuration;

		// Token: 0x040065F1 RID: 26097
		public int? RepeatTimes;

		// Token: 0x040065F2 RID: 26098
		public bool? KeepMontageWhenEnd;

		// Token: 0x040065F3 RID: 26099
		public bool? KeepMontageAfterFlow;
	}
}

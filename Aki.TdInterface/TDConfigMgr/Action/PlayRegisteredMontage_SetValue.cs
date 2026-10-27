using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200211E RID: 8478
	public class PlayRegisteredMontage_SetValue
	{
		// Token: 0x04006FB6 RID: 28598
		public int EntityId;

		// Token: 0x04006FB7 RID: 28599
		public int MontageId;

		// Token: 0x04006FB8 RID: 28600
		public bool? IsOverlayMontage;

		// Token: 0x04006FB9 RID: 28601
		public bool? IsAbpMontage;

		// Token: 0x04006FBA RID: 28602
		public int? FaceExpressionId;

		// Token: 0x04006FBB RID: 28603
		public float? LoopDuration;

		// Token: 0x04006FBC RID: 28604
		public int? RepeatTimes;

		// Token: 0x04006FBD RID: 28605
		public bool? KeepMontageWhenEnd;

		// Token: 0x04006FBE RID: 28606
		public bool? KeepMontageAfterFlow;
	}
}

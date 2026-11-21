using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200237F RID: 9087
	public class PlayRegisteredMontage_SetValue
	{
		// Token: 0x040075EB RID: 30187
		public int EntityId;

		// Token: 0x040075EC RID: 30188
		public int MontageId;

		// Token: 0x040075ED RID: 30189
		public bool? IsOverlayMontage;

		// Token: 0x040075EE RID: 30190
		public bool? IsAbpMontage;

		// Token: 0x040075EF RID: 30191
		public int? FaceExpressionId;

		// Token: 0x040075F0 RID: 30192
		public float? LoopDuration;

		// Token: 0x040075F1 RID: 30193
		public int? RepeatTimes;

		// Token: 0x040075F2 RID: 30194
		public bool? KeepMontageWhenEnd;

		// Token: 0x040075F3 RID: 30195
		public bool? KeepMontageAfterFlow;
	}
}

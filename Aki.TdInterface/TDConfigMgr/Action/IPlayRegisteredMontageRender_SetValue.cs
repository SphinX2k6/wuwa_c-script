using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D1D RID: 7453
	public class IPlayRegisteredMontageRender_SetValue
	{
		// Token: 0x04006070 RID: 24688
		public int EntityId;

		// Token: 0x04006071 RID: 24689
		public bool? IsOverlayMontage;

		// Token: 0x04006072 RID: 24690
		[Nullable(1)]
		public IMontageId MontageId;

		// Token: 0x04006073 RID: 24691
		public int? FaceExpressionId;

		// Token: 0x04006074 RID: 24692
		public float? LoopDuration;

		// Token: 0x04006075 RID: 24693
		public int? RepeatTimes;

		// Token: 0x04006076 RID: 24694
		public bool? KeepMontageWhenEnd;

		// Token: 0x04006077 RID: 24695
		public bool? KeepMontageAfterFlow;
	}
}

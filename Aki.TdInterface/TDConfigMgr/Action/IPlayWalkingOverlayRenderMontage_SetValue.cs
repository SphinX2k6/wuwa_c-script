using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D25 RID: 7461
	public class IPlayWalkingOverlayRenderMontage_SetValue
	{
		// Token: 0x0400608B RID: 24715
		public int EntityId;

		// Token: 0x0400608C RID: 24716
		[Nullable(1)]
		public IMontageId OverlapMontageId;

		// Token: 0x0400608D RID: 24717
		public float? LoopDuration;

		// Token: 0x0400608E RID: 24718
		public int? RepeatTimes;
	}
}

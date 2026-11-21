using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x020051CF RID: 20943
	[NullableContext(1)]
	public interface IRhythmShipSettlementViewData
	{
		// Token: 0x170065B4 RID: 26036
		// (get) Token: 0x06034315 RID: 213781
		// (set) Token: 0x06034316 RID: 213782
		int SubLevelId { get; set; }

		// Token: 0x170065B5 RID: 26037
		// (get) Token: 0x06034317 RID: 213783
		// (set) Token: 0x06034318 RID: 213784
		RhythmSettleReasonPb Reason { get; set; }

		// Token: 0x170065B6 RID: 26038
		// (get) Token: 0x06034319 RID: 213785
		// (set) Token: 0x0603431A RID: 213786
		RhythmResultPayload Payload { get; set; }

		// Token: 0x170065B7 RID: 26039
		// (get) Token: 0x0603431B RID: 213787
		// (set) Token: 0x0603431C RID: 213788
		Dictionary<ERhythmShipSettlementType, int> SettlementItemMap { get; set; }
	}
}

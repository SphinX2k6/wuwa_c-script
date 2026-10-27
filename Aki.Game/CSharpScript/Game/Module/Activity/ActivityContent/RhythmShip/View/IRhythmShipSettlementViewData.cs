using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006251 RID: 25169
	[NullableContext(1)]
	public interface IRhythmShipSettlementViewData
	{
		// Token: 0x17009252 RID: 37458
		// (get) Token: 0x0603F654 RID: 259668
		// (set) Token: 0x0603F655 RID: 259669
		int SubLevelId { get; set; }

		// Token: 0x17009253 RID: 37459
		// (get) Token: 0x0603F656 RID: 259670
		// (set) Token: 0x0603F657 RID: 259671
		RhythmSettleReasonPb Reason { get; set; }

		// Token: 0x17009254 RID: 37460
		// (get) Token: 0x0603F658 RID: 259672
		// (set) Token: 0x0603F659 RID: 259673
		RhythmResultPayload Payload { get; set; }

		// Token: 0x17009255 RID: 37461
		// (get) Token: 0x0603F65A RID: 259674
		// (set) Token: 0x0603F65B RID: 259675
		Dictionary<ERhythmShipSettlementType, int> SettlementItemMap { get; set; }
	}
}

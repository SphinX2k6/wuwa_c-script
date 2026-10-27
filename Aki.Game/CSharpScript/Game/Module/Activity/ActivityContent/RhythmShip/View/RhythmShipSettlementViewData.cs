using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006252 RID: 25170
	[NullableContext(1)]
	[Nullable(0)]
	public class RhythmShipSettlementViewData : IRhythmShipSettlementViewData
	{
		// Token: 0x17009256 RID: 37462
		// (get) Token: 0x0603F65C RID: 259676 RVA: 0x00F53702 File Offset: 0x00F51902
		// (set) Token: 0x0603F65D RID: 259677 RVA: 0x00F5370A File Offset: 0x00F5190A
		public int SubLevelId { get; set; }

		// Token: 0x17009257 RID: 37463
		// (get) Token: 0x0603F65E RID: 259678 RVA: 0x00F53713 File Offset: 0x00F51913
		// (set) Token: 0x0603F65F RID: 259679 RVA: 0x00F5371B File Offset: 0x00F5191B
		public RhythmSettleReasonPb Reason { get; set; }

		// Token: 0x17009258 RID: 37464
		// (get) Token: 0x0603F660 RID: 259680 RVA: 0x00F53724 File Offset: 0x00F51924
		// (set) Token: 0x0603F661 RID: 259681 RVA: 0x00F5372C File Offset: 0x00F5192C
		public RhythmResultPayload Payload { get; set; }

		// Token: 0x17009259 RID: 37465
		// (get) Token: 0x0603F662 RID: 259682 RVA: 0x00F53735 File Offset: 0x00F51935
		// (set) Token: 0x0603F663 RID: 259683 RVA: 0x00F5373D File Offset: 0x00F5193D
		public Dictionary<ERhythmShipSettlementType, int> SettlementItemMap { get; set; }
	}
}

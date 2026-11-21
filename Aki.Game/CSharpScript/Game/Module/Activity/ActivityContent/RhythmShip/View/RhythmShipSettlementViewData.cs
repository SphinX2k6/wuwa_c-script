using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x020051D0 RID: 20944
	[NullableContext(1)]
	[Nullable(0)]
	public class RhythmShipSettlementViewData : IRhythmShipSettlementViewData
	{
		// Token: 0x170065B8 RID: 26040
		// (get) Token: 0x0603431D RID: 213789 RVA: 0x00E9A65E File Offset: 0x00E9885E
		// (set) Token: 0x0603431E RID: 213790 RVA: 0x00E9A666 File Offset: 0x00E98866
		public int SubLevelId { get; set; }

		// Token: 0x170065B9 RID: 26041
		// (get) Token: 0x0603431F RID: 213791 RVA: 0x00E9A66F File Offset: 0x00E9886F
		// (set) Token: 0x06034320 RID: 213792 RVA: 0x00E9A677 File Offset: 0x00E98877
		public RhythmSettleReasonPb Reason { get; set; }

		// Token: 0x170065BA RID: 26042
		// (get) Token: 0x06034321 RID: 213793 RVA: 0x00E9A680 File Offset: 0x00E98880
		// (set) Token: 0x06034322 RID: 213794 RVA: 0x00E9A688 File Offset: 0x00E98888
		public RhythmResultPayload Payload { get; set; }

		// Token: 0x170065BB RID: 26043
		// (get) Token: 0x06034323 RID: 213795 RVA: 0x00E9A691 File Offset: 0x00E98891
		// (set) Token: 0x06034324 RID: 213796 RVA: 0x00E9A699 File Offset: 0x00E98899
		public Dictionary<ERhythmShipSettlementType, int> SettlementItemMap { get; set; }
	}
}

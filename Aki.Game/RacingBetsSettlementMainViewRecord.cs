using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001BED RID: 7149
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsSettlementMainViewRecord : IRacingBetsSettlementMainViewRecord
{
	// Token: 0x17001B1A RID: 6938
	// (get) Token: 0x06011C84 RID: 72836 RVA: 0x0053A993 File Offset: 0x00538B93
	// (set) Token: 0x06011C85 RID: 72837 RVA: 0x0053A99B File Offset: 0x00538B9B
	public int SeasonId { get; set; }

	// Token: 0x17001B1B RID: 6939
	// (get) Token: 0x06011C86 RID: 72838 RVA: 0x0053A9A4 File Offset: 0x00538BA4
	// (set) Token: 0x06011C87 RID: 72839 RVA: 0x0053A9AC File Offset: 0x00538BAC
	public List<int> ViewedLegMatchIds { get; set; }
}

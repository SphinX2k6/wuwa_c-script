using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002702 RID: 9986
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsSettlementMainViewRecord : IRacingBetsSettlementMainViewRecord
{
	// Token: 0x17001AE2 RID: 6882
	// (get) Token: 0x060147A2 RID: 83874 RVA: 0x0052BC77 File Offset: 0x00529E77
	// (set) Token: 0x060147A3 RID: 83875 RVA: 0x0052BC7F File Offset: 0x00529E7F
	public int SeasonId { get; set; }

	// Token: 0x17001AE3 RID: 6883
	// (get) Token: 0x060147A4 RID: 83876 RVA: 0x0052BC88 File Offset: 0x00529E88
	// (set) Token: 0x060147A5 RID: 83877 RVA: 0x0052BC90 File Offset: 0x00529E90
	public List<int> ViewedLegMatchIds { get; set; }
}

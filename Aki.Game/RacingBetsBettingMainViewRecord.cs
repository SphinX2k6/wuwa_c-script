using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002704 RID: 9988
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsBettingMainViewRecord : IRacingBetsBettingMainViewRecord
{
	// Token: 0x17001AE6 RID: 6886
	// (get) Token: 0x060147AB RID: 83883 RVA: 0x0052BCA1 File Offset: 0x00529EA1
	// (set) Token: 0x060147AC RID: 83884 RVA: 0x0052BCA9 File Offset: 0x00529EA9
	public int SeasonId { get; set; }

	// Token: 0x17001AE7 RID: 6887
	// (get) Token: 0x060147AD RID: 83885 RVA: 0x0052BCB2 File Offset: 0x00529EB2
	// (set) Token: 0x060147AE RID: 83886 RVA: 0x0052BCBA File Offset: 0x00529EBA
	public List<int> EnteredLegMatchIds { get; set; }
}

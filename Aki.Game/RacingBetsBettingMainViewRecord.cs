using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001BEF RID: 7151
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsBettingMainViewRecord : IRacingBetsBettingMainViewRecord
{
	// Token: 0x17001B1E RID: 6942
	// (get) Token: 0x06011C8D RID: 72845 RVA: 0x0053A9BD File Offset: 0x00538BBD
	// (set) Token: 0x06011C8E RID: 72846 RVA: 0x0053A9C5 File Offset: 0x00538BC5
	public int SeasonId { get; set; }

	// Token: 0x17001B1F RID: 6943
	// (get) Token: 0x06011C8F RID: 72847 RVA: 0x0053A9CE File Offset: 0x00538BCE
	// (set) Token: 0x06011C90 RID: 72848 RVA: 0x0053A9D6 File Offset: 0x00538BD6
	public List<int> EnteredLegMatchIds { get; set; }
}

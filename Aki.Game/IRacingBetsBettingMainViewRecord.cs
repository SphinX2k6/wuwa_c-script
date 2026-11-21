using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001BEE RID: 7150
[NullableContext(1)]
public interface IRacingBetsBettingMainViewRecord
{
	// Token: 0x17001B1C RID: 6940
	// (get) Token: 0x06011C89 RID: 72841
	// (set) Token: 0x06011C8A RID: 72842
	int SeasonId { get; set; }

	// Token: 0x17001B1D RID: 6941
	// (get) Token: 0x06011C8B RID: 72843
	// (set) Token: 0x06011C8C RID: 72844
	List<int> EnteredLegMatchIds { get; set; }
}

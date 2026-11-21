using System;
using System.Runtime.CompilerServices;

// Token: 0x02001F41 RID: 8001
[NullableContext(2)]
[Nullable(0)]
public class ShipTowerReviewViewParams
{
	// Token: 0x17001DFA RID: 7674
	// (get) Token: 0x06013CA5 RID: 81061 RVA: 0x005C6170 File Offset: 0x005C4370
	// (set) Token: 0x06013CA6 RID: 81062 RVA: 0x005C6178 File Offset: 0x005C4378
	public int SeasonId { get; set; }

	// Token: 0x17001DFB RID: 7675
	// (get) Token: 0x06013CA7 RID: 81063 RVA: 0x005C6181 File Offset: 0x005C4381
	// (set) Token: 0x06013CA8 RID: 81064 RVA: 0x005C6189 File Offset: 0x005C4389
	public CustomPromise<bool> Promise { get; set; }
}

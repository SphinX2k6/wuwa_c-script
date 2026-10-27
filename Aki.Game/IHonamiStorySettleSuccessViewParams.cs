using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001F18 RID: 7960
[NullableContext(1)]
public interface IHonamiStorySettleSuccessViewParams
{
	// Token: 0x17001331 RID: 4913
	// (get) Token: 0x0600F53B RID: 62779
	List<IHonamiStorySettleItemParams> DisplayItems { get; }

	// Token: 0x17001332 RID: 4914
	// (get) Token: 0x0600F53C RID: 62780
	int TotalReward { get; }

	// Token: 0x17001333 RID: 4915
	// (get) Token: 0x0600F53D RID: 62781
	bool IsNewRecord { get; }
}

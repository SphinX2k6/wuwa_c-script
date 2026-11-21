using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020013DA RID: 5082
[NullableContext(1)]
public interface IHonamiStorySettleSuccessViewParams
{
	// Token: 0x1700135B RID: 4955
	// (get) Token: 0x0600C95A RID: 51546
	List<IHonamiStorySettleItemParams> DisplayItems { get; }

	// Token: 0x1700135C RID: 4956
	// (get) Token: 0x0600C95B RID: 51547
	int TotalReward { get; }

	// Token: 0x1700135D RID: 4957
	// (get) Token: 0x0600C95C RID: 51548
	bool IsNewRecord { get; }
}

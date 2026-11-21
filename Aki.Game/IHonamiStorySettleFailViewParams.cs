using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020013D4 RID: 5076
[NullableContext(1)]
public interface IHonamiStorySettleFailViewParams
{
	// Token: 0x1700134F RID: 4943
	// (get) Token: 0x0600C939 RID: 51513
	List<IHonamiStorySettleItemParams> DisplayItems { get; }

	// Token: 0x17001350 RID: 4944
	// (get) Token: 0x0600C93A RID: 51514
	int TotalReward { get; }

	// Token: 0x17001351 RID: 4945
	// (get) Token: 0x0600C93B RID: 51515
	bool IsNewRecord { get; }

	// Token: 0x17001352 RID: 4946
	// (get) Token: 0x0600C93C RID: 51516
	int FailAddProportion { get; }
}

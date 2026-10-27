using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001F12 RID: 7954
[NullableContext(1)]
public interface IHonamiStorySettleFailViewParams
{
	// Token: 0x17001325 RID: 4901
	// (get) Token: 0x0600F51A RID: 62746
	List<IHonamiStorySettleItemParams> DisplayItems { get; }

	// Token: 0x17001326 RID: 4902
	// (get) Token: 0x0600F51B RID: 62747
	int TotalReward { get; }

	// Token: 0x17001327 RID: 4903
	// (get) Token: 0x0600F51C RID: 62748
	bool IsNewRecord { get; }

	// Token: 0x17001328 RID: 4904
	// (get) Token: 0x0600F51D RID: 62749
	int FailAddProportion { get; }
}

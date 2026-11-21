using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000F7E RID: 3966
[NullableContext(1)]
public interface IMapAreaRewardParam
{
	// Token: 0x170010EE RID: 4334
	// (get) Token: 0x06009F0B RID: 40715
	int InitValue { get; }

	// Token: 0x170010EF RID: 4335
	// (get) Token: 0x06009F0C RID: 40716
	int MaxValue { get; }

	// Token: 0x170010F0 RID: 4336
	// (get) Token: 0x06009F0D RID: 40717
	List<DailyActivityDefine.IActivityGoalData> RewardDataList { get; }

	// Token: 0x170010F1 RID: 4337
	// (get) Token: 0x06009F0E RID: 40718
	Action GetRewardCallback { get; }
}

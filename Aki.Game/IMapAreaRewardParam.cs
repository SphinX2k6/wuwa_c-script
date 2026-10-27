using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001ABF RID: 6847
[NullableContext(1)]
public interface IMapAreaRewardParam
{
	// Token: 0x170010C9 RID: 4297
	// (get) Token: 0x0600CAFA RID: 51962
	int InitValue { get; }

	// Token: 0x170010CA RID: 4298
	// (get) Token: 0x0600CAFB RID: 51963
	int MaxValue { get; }

	// Token: 0x170010CB RID: 4299
	// (get) Token: 0x0600CAFC RID: 51964
	List<DailyActivityDefine.IActivityGoalData> RewardDataList { get; }

	// Token: 0x170010CC RID: 4300
	// (get) Token: 0x0600CAFD RID: 51965
	Action GetRewardCallback { get; }
}

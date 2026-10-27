using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001AC0 RID: 6848
[NullableContext(1)]
[Nullable(0)]
public class MapAreaRewardParam : IMapAreaRewardParam
{
	// Token: 0x170010CD RID: 4301
	// (get) Token: 0x0600CAFE RID: 51966 RVA: 0x002E4578 File Offset: 0x002E2778
	// (set) Token: 0x0600CAFF RID: 51967 RVA: 0x002E4580 File Offset: 0x002E2780
	public int InitValue { get; set; }

	// Token: 0x170010CE RID: 4302
	// (get) Token: 0x0600CB00 RID: 51968 RVA: 0x002E4589 File Offset: 0x002E2789
	// (set) Token: 0x0600CB01 RID: 51969 RVA: 0x002E4591 File Offset: 0x002E2791
	public int MaxValue { get; set; }

	// Token: 0x170010CF RID: 4303
	// (get) Token: 0x0600CB02 RID: 51970 RVA: 0x002E459A File Offset: 0x002E279A
	// (set) Token: 0x0600CB03 RID: 51971 RVA: 0x002E45A2 File Offset: 0x002E27A2
	public List<DailyActivityDefine.IActivityGoalData> RewardDataList { get; set; }

	// Token: 0x170010D0 RID: 4304
	// (get) Token: 0x0600CB04 RID: 51972 RVA: 0x002E45AB File Offset: 0x002E27AB
	// (set) Token: 0x0600CB05 RID: 51973 RVA: 0x002E45B3 File Offset: 0x002E27B3
	public Action GetRewardCallback { get; set; }
}

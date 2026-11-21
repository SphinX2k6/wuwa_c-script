using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000F7F RID: 3967
[NullableContext(1)]
[Nullable(0)]
public class MapAreaRewardParam : IMapAreaRewardParam
{
	// Token: 0x170010F2 RID: 4338
	// (get) Token: 0x06009F0F RID: 40719 RVA: 0x002EF6FC File Offset: 0x002ED8FC
	// (set) Token: 0x06009F10 RID: 40720 RVA: 0x002EF704 File Offset: 0x002ED904
	public int InitValue { get; set; }

	// Token: 0x170010F3 RID: 4339
	// (get) Token: 0x06009F11 RID: 40721 RVA: 0x002EF70D File Offset: 0x002ED90D
	// (set) Token: 0x06009F12 RID: 40722 RVA: 0x002EF715 File Offset: 0x002ED915
	public int MaxValue { get; set; }

	// Token: 0x170010F4 RID: 4340
	// (get) Token: 0x06009F13 RID: 40723 RVA: 0x002EF71E File Offset: 0x002ED91E
	// (set) Token: 0x06009F14 RID: 40724 RVA: 0x002EF726 File Offset: 0x002ED926
	public List<DailyActivityDefine.IActivityGoalData> RewardDataList { get; set; }

	// Token: 0x170010F5 RID: 4341
	// (get) Token: 0x06009F15 RID: 40725 RVA: 0x002EF72F File Offset: 0x002ED92F
	// (set) Token: 0x06009F16 RID: 40726 RVA: 0x002EF737 File Offset: 0x002ED937
	public Action GetRewardCallback { get; set; }
}

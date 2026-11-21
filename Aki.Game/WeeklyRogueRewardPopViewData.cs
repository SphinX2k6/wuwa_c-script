using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020022BE RID: 8894
[NullableContext(1)]
[Nullable(0)]
public class WeeklyRogueRewardPopViewData : IWeeklyRogueRewardPopViewData
{
	// Token: 0x17002157 RID: 8535
	// (get) Token: 0x06015F97 RID: 90007 RVA: 0x0065E84F File Offset: 0x0065CA4F
	// (set) Token: 0x06015F98 RID: 90008 RVA: 0x0065E857 File Offset: 0x0065CA57
	public int SinglePowerCost { get; set; }

	// Token: 0x17002158 RID: 8536
	// (get) Token: 0x06015F99 RID: 90009 RVA: 0x0065E860 File Offset: 0x0065CA60
	// (set) Token: 0x06015F9A RID: 90010 RVA: 0x0065E868 File Offset: 0x0065CA68
	public Action<int, int> RewardCallBack { get; set; }

	// Token: 0x17002159 RID: 8537
	// (get) Token: 0x06015F9B RID: 90011 RVA: 0x0065E871 File Offset: 0x0065CA71
	// (set) Token: 0x06015F9C RID: 90012 RVA: 0x0065E879 File Offset: 0x0065CA79
	[Nullable(2)]
	public Action CloseCallBack { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x1700215A RID: 8538
	// (get) Token: 0x06015F9D RID: 90013 RVA: 0x0065E882 File Offset: 0x0065CA82
	// (set) Token: 0x06015F9E RID: 90014 RVA: 0x0065E88A File Offset: 0x0065CA8A
	public List<int> AvailableSilentArea { get; set; }

	// Token: 0x1700215B RID: 8539
	// (get) Token: 0x06015F9F RID: 90015 RVA: 0x0065E893 File Offset: 0x0065CA93
	// (set) Token: 0x06015FA0 RID: 90016 RVA: 0x0065E89B File Offset: 0x0065CA9B
	public int FreeCount { get; set; }

	// Token: 0x1700215C RID: 8540
	// (get) Token: 0x06015FA1 RID: 90017 RVA: 0x0065E8A4 File Offset: 0x0065CAA4
	// (set) Token: 0x06015FA2 RID: 90018 RVA: 0x0065E8AC File Offset: 0x0065CAAC
	public int FreeMax { get; set; }
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001535 RID: 5429
[NullableContext(1)]
[Nullable(0)]
public class NightmareKillInfo
{
	// Token: 0x0600D959 RID: 55641 RVA: 0x004075B9 File Offset: 0x004057B9
	public NightmareKillInfo()
	{
	}

	// Token: 0x0600D95A RID: 55642 RVA: 0x004075CC File Offset: 0x004057CC
	public NightmareKillInfo(bool enable, int currentKillCount, int currentIntervalIndex, List<int> intervalKillNumber)
	{
		this.Enable = enable;
		this.CurrentKillCount = currentKillCount;
		this.CurrentIntervalIndex = currentIntervalIndex;
		this.IntervalKillNumber = intervalKillNumber;
	}

	// Token: 0x04007973 RID: 31091
	public bool Enable;

	// Token: 0x04007974 RID: 31092
	public int CurrentKillCount;

	// Token: 0x04007975 RID: 31093
	public int CurrentIntervalIndex;

	// Token: 0x04007976 RID: 31094
	public List<int> IntervalKillNumber = new List<int>();
}

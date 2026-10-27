using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002062 RID: 8290
[NullableContext(1)]
[Nullable(0)]
public class NightmareKillInfo
{
	// Token: 0x060104F1 RID: 66801 RVA: 0x003FB029 File Offset: 0x003F9229
	public NightmareKillInfo()
	{
	}

	// Token: 0x060104F2 RID: 66802 RVA: 0x003FB03C File Offset: 0x003F923C
	public NightmareKillInfo(bool enable, int currentKillCount, int currentIntervalIndex, List<int> intervalKillNumber)
	{
		this.Enable = enable;
		this.CurrentKillCount = currentKillCount;
		this.CurrentIntervalIndex = currentIntervalIndex;
		this.IntervalKillNumber = intervalKillNumber;
	}

	// Token: 0x0400788A RID: 30858
	public bool Enable;

	// Token: 0x0400788B RID: 30859
	public int CurrentKillCount;

	// Token: 0x0400788C RID: 30860
	public int CurrentIntervalIndex;

	// Token: 0x0400788D RID: 30861
	public List<int> IntervalKillNumber = new List<int>();
}

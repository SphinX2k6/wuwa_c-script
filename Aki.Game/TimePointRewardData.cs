using System;

// Token: 0x020009D7 RID: 2519
public class TimePointRewardData
{
	// Token: 0x17000D63 RID: 3427
	// (get) Token: 0x06006E13 RID: 28179 RVA: 0x0021F877 File Offset: 0x0021DA77
	public ETimePointRewardState RewardState
	{
		get
		{
			if (this.HasClaimed)
			{
				return ETimePointRewardState.UnlockAndClaimed;
			}
			if (this.HasUnlock)
			{
				return ETimePointRewardState.UnlockAndUnClaimed;
			}
			return ETimePointRewardState.Lock;
		}
	}

	// Token: 0x04004484 RID: 17540
	public int Id;

	// Token: 0x04004485 RID: 17541
	public long RewardTime;

	// Token: 0x04004486 RID: 17542
	public bool HasClaimed;

	// Token: 0x04004487 RID: 17543
	public bool HasUnlock;

	// Token: 0x04004488 RID: 17544
	public int CurrentCheckInCount;

	// Token: 0x04004489 RID: 17545
	public int ConditionCount;
}

using System;

// Token: 0x0200151F RID: 5407
public class TimePointRewardData
{
	// Token: 0x17000D42 RID: 3394
	// (get) Token: 0x06009A35 RID: 39477 RVA: 0x00215ADB File Offset: 0x00213CDB
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

	// Token: 0x040043DE RID: 17374
	public int Id;

	// Token: 0x040043DF RID: 17375
	public long RewardTime;

	// Token: 0x040043E0 RID: 17376
	public bool HasClaimed;

	// Token: 0x040043E1 RID: 17377
	public bool HasUnlock;

	// Token: 0x040043E2 RID: 17378
	public int CurrentCheckInCount;

	// Token: 0x040043E3 RID: 17379
	public int ConditionCount;
}

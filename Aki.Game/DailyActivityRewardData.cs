using System;

// Token: 0x020019F5 RID: 6645
public class DailyActivityRewardData
{
	// Token: 0x0600C27E RID: 49790 RVA: 0x002BE4C6 File Offset: 0x002BC6C6
	public DailyActivityRewardData(int rewardId, double progress, int maxIndex)
	{
		this.RewardId = rewardId;
		this.Progress = progress;
		this.MaxIndex = maxIndex;
	}

	// Token: 0x04005984 RID: 22916
	public int MaxIndex;

	// Token: 0x04005985 RID: 22917
	public double Progress;

	// Token: 0x04005986 RID: 22918
	public int RewardId;
}

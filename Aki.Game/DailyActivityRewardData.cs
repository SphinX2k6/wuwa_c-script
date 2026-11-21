using System;

// Token: 0x02000EB4 RID: 3764
public class DailyActivityRewardData
{
	// Token: 0x0600968B RID: 38539 RVA: 0x002C949E File Offset: 0x002C769E
	public DailyActivityRewardData(int rewardId, double progress, int maxIndex)
	{
		this.RewardId = rewardId;
		this.Progress = progress;
		this.MaxIndex = maxIndex;
	}

	// Token: 0x04005A53 RID: 23123
	public int MaxIndex;

	// Token: 0x04005A54 RID: 23124
	public double Progress;

	// Token: 0x04005A55 RID: 23125
	public int RewardId;
}

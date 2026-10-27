using System;

// Token: 0x0200120F RID: 4623
public class DailyAdventureRewardData
{
	// Token: 0x06007BD1 RID: 31697 RVA: 0x001A1F5C File Offset: 0x001A015C
	public void RefreshState(bool hasTaken, int? currentPoint = null)
	{
		if (hasTaken)
		{
			this.RewardState = ERewardState.FinishedAndClaimed;
			return;
		}
		if (currentPoint != null)
		{
			int? num = currentPoint;
			int point = this.Point;
			this.RewardState = ((num.GetValueOrDefault() >= point & num != null) ? ERewardState.FinishedAndUnClaimed : ERewardState.Progress);
		}
	}

	// Token: 0x040038B4 RID: 14516
	public int RewardId;

	// Token: 0x040038B5 RID: 14517
	public int Point;

	// Token: 0x040038B6 RID: 14518
	public ERewardState RewardState = ERewardState.Progress;
}

using System;

// Token: 0x020006C3 RID: 1731
public class DailyAdventureRewardData
{
	// Token: 0x06004F67 RID: 20327 RVA: 0x001AABD4 File Offset: 0x001A8DD4
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

	// Token: 0x0400394D RID: 14669
	public int RewardId;

	// Token: 0x0400394E RID: 14670
	public int Point;

	// Token: 0x0400394F RID: 14671
	public ERewardState RewardState = ERewardState.Progress;
}

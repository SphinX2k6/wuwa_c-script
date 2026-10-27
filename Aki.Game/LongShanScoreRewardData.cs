using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Reward;

// Token: 0x020012A3 RID: 4771
[NullableContext(1)]
[Nullable(0)]
public class LongShanScoreRewardData
{
	// Token: 0x060082E2 RID: 33506 RVA: 0x001BCF90 File Offset: 0x001BB190
	public List<TItem> GetPreviewReward()
	{
		if (this.Rewards.Count == 0)
		{
			List<TItem> result = new List<TItem>();
			if (this.DropId == 0)
			{
				return result;
			}
			List<TItem> dropPackagePreviewItemList = RewardConfig.Instance.GetDropPackagePreviewItemList(this.DropId);
			this.Rewards = dropPackagePreviewItemList;
		}
		return this.Rewards;
	}

	// Token: 0x060082E3 RID: 33507 RVA: 0x001BCFD8 File Offset: 0x001BB1D8
	public EActivityTaskState GetState()
	{
		if (this.Achieved)
		{
			return EActivityTaskState.FinishedAndClaimed;
		}
		if (this.GetCurrentScore == null)
		{
			return EActivityTaskState.Active;
		}
		if (this.GetCurrentScore() >= this.Goal)
		{
			return EActivityTaskState.FinishedAndUnclaimed;
		}
		return EActivityTaskState.Active;
	}

	// Token: 0x04003B00 RID: 15104
	public int Id;

	// Token: 0x04003B01 RID: 15105
	public int Goal;

	// Token: 0x04003B02 RID: 15106
	public bool Achieved;

	// Token: 0x04003B03 RID: 15107
	public int DropId;

	// Token: 0x04003B04 RID: 15108
	private List<TItem> Rewards = new List<TItem>();

	// Token: 0x04003B05 RID: 15109
	[Nullable(2)]
	public Func<int> GetCurrentScore;
}

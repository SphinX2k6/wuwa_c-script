using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Reward;

// Token: 0x02001336 RID: 4918
[NullableContext(1)]
[Nullable(0)]
public class HandbookRewardData
{
	// Token: 0x060088F0 RID: 35056 RVA: 0x001D41FC File Offset: 0x001D23FC
	public List<TItem> GetPreviewReward()
	{
		if (this.Rewards.Count != 0)
		{
			return this.Rewards;
		}
		if (this.DropId == 0)
		{
			return new List<TItem>();
		}
		List<TItem> dropPackagePreviewItemList = RewardConfig.Instance.GetDropPackagePreviewItemList(this.DropId);
		if (dropPackagePreviewItemList != null)
		{
			this.Rewards = dropPackagePreviewItemList;
		}
		return this.Rewards;
	}

	// Token: 0x060088F1 RID: 35057 RVA: 0x001D424C File Offset: 0x001D244C
	public EHandbookRewardState GetState(int currentGoal)
	{
		if (this.Achieved)
		{
			return EHandbookRewardState.FinishedAndClaimed;
		}
		if (currentGoal >= this.Goal)
		{
			return EHandbookRewardState.FinishedAndUnclaimed;
		}
		return EHandbookRewardState.Active;
	}

	// Token: 0x04003D07 RID: 15623
	public int Id;

	// Token: 0x04003D08 RID: 15624
	public int Goal;

	// Token: 0x04003D09 RID: 15625
	public bool Achieved;

	// Token: 0x04003D0A RID: 15626
	public int DropId;

	// Token: 0x04003D0B RID: 15627
	private List<TItem> Rewards = new List<TItem>();
}

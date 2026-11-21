using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Reward;

// Token: 0x020007EA RID: 2026
[NullableContext(1)]
[Nullable(0)]
public class HandbookRewardData
{
	// Token: 0x06005C8B RID: 23691 RVA: 0x001DD068 File Offset: 0x001DB268
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

	// Token: 0x06005C8C RID: 23692 RVA: 0x001DD0B8 File Offset: 0x001DB2B8
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

	// Token: 0x04003D9F RID: 15775
	public int Id;

	// Token: 0x04003DA0 RID: 15776
	public int Goal;

	// Token: 0x04003DA1 RID: 15777
	public bool Achieved;

	// Token: 0x04003DA2 RID: 15778
	public int DropId;

	// Token: 0x04003DA3 RID: 15779
	private List<TItem> Rewards = new List<TItem>();
}

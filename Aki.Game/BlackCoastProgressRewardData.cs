using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Reward;

// Token: 0x0200065F RID: 1631
[NullableContext(1)]
[Nullable(0)]
public class BlackCoastProgressRewardData
{
	// Token: 0x06004B7B RID: 19323 RVA: 0x00199F7C File Offset: 0x0019817C
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

	// Token: 0x06004B7C RID: 19324 RVA: 0x00199FC4 File Offset: 0x001981C4
	public EActivityTaskState GetState()
	{
		if (this.Achieved)
		{
			return EActivityTaskState.FinishedAndClaimed;
		}
		if (this.GetCurrentGoal == null)
		{
			return EActivityTaskState.Active;
		}
		if (this.GetCurrentGoal() >= this.Goal)
		{
			return EActivityTaskState.FinishedAndUnclaimed;
		}
		return EActivityTaskState.Active;
	}

	// Token: 0x040037C2 RID: 14274
	public int Id;

	// Token: 0x040037C3 RID: 14275
	public int Goal;

	// Token: 0x040037C4 RID: 14276
	public bool Achieved;

	// Token: 0x040037C5 RID: 14277
	public int DropId;

	// Token: 0x040037C6 RID: 14278
	private List<TItem> Rewards = new List<TItem>();

	// Token: 0x040037C7 RID: 14279
	[Nullable(2)]
	public Func<int> GetCurrentGoal;
}

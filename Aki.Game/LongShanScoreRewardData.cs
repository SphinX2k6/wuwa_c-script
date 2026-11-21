using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Reward;

// Token: 0x02000757 RID: 1879
[NullableContext(1)]
[Nullable(0)]
public class LongShanScoreRewardData
{
	// Token: 0x06005679 RID: 22137 RVA: 0x001C5D20 File Offset: 0x001C3F20
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

	// Token: 0x0600567A RID: 22138 RVA: 0x001C5D68 File Offset: 0x001C3F68
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

	// Token: 0x04003B98 RID: 15256
	public int Id;

	// Token: 0x04003B99 RID: 15257
	public int Goal;

	// Token: 0x04003B9A RID: 15258
	public bool Achieved;

	// Token: 0x04003B9B RID: 15259
	public int DropId;

	// Token: 0x04003B9C RID: 15260
	private List<TItem> Rewards = new List<TItem>();

	// Token: 0x04003B9D RID: 15261
	[Nullable(2)]
	public Func<int> GetCurrentScore;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Reward;

// Token: 0x020011AB RID: 4523
[NullableContext(1)]
[Nullable(0)]
public class BlackCoastProgressRewardData
{
	// Token: 0x060077E4 RID: 30692 RVA: 0x00191390 File Offset: 0x0018F590
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

	// Token: 0x060077E5 RID: 30693 RVA: 0x001913D8 File Offset: 0x0018F5D8
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

	// Token: 0x04003729 RID: 14121
	public int Id;

	// Token: 0x0400372A RID: 14122
	public int Goal;

	// Token: 0x0400372B RID: 14123
	public bool Achieved;

	// Token: 0x0400372C RID: 14124
	public int DropId;

	// Token: 0x0400372D RID: 14125
	private List<TItem> Rewards = new List<TItem>();

	// Token: 0x0400372E RID: 14126
	[Nullable(2)]
	public Func<int> GetCurrentGoal;
}

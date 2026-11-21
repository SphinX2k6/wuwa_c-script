using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000EB2 RID: 3762
[NullableContext(1)]
[Nullable(0)]
public class WeeklyActivityRewardAdapter : DailyActivityDefine.IActivityRewardPanelDataAdapter
{
	// Token: 0x1700106A RID: 4202
	// (get) Token: 0x06009679 RID: 38521 RVA: 0x002C91BC File Offset: 0x002C73BC
	public double CurrentValue
	{
		get
		{
			return (double)WeeklyChallengeModel.Instance.WeeklyCurrentScore;
		}
	}

	// Token: 0x1700106B RID: 4203
	// (get) Token: 0x0600967A RID: 38522 RVA: 0x002C91C9 File Offset: 0x002C73C9
	public double MaxValue
	{
		get
		{
			return (double)WeeklyChallengeModel.Instance.WeeklyMaxScore;
		}
	}

	// Token: 0x1700106C RID: 4204
	// (get) Token: 0x0600967B RID: 38523 RVA: 0x002C91D6 File Offset: 0x002C73D6
	public IReadOnlyDictionary<int, DailyActivityDefine.IActivityGoalData> GoalMap
	{
		get
		{
			return WeeklyChallengeModel.Instance.WeeklyGoalMap;
		}
	}

	// Token: 0x0600967C RID: 38524 RVA: 0x002C91E2 File Offset: 0x002C73E2
	public List<int> GetCanRewardIdList()
	{
		return WeeklyChallengeModel.Instance.GetCanRewardIdList();
	}

	// Token: 0x0600967D RID: 38525 RVA: 0x002C91EE File Offset: 0x002C73EE
	public void RequestReward(List<int> idList, Action onClose)
	{
		WeeklyChallengeController.Instance.RequestWeeklyFrameworkScoreReward(idList);
		onClose();
	}

	// Token: 0x0600967E RID: 38526 RVA: 0x002C9201 File Offset: 0x002C7401
	public List<TItem> GetRewardById(int id)
	{
		return WeeklyChallengeModel.Instance.GetRewardById(id);
	}
}

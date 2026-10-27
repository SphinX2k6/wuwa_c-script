using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020019F3 RID: 6643
[NullableContext(1)]
[Nullable(0)]
public class WeeklyActivityRewardAdapter : DailyActivityDefine.IActivityRewardPanelDataAdapter
{
	// Token: 0x17001045 RID: 4165
	// (get) Token: 0x0600C26C RID: 49772 RVA: 0x002BE1E4 File Offset: 0x002BC3E4
	public double CurrentValue
	{
		get
		{
			return (double)WeeklyChallengeModel.Instance.WeeklyCurrentScore;
		}
	}

	// Token: 0x17001046 RID: 4166
	// (get) Token: 0x0600C26D RID: 49773 RVA: 0x002BE1F1 File Offset: 0x002BC3F1
	public double MaxValue
	{
		get
		{
			return (double)WeeklyChallengeModel.Instance.WeeklyMaxScore;
		}
	}

	// Token: 0x17001047 RID: 4167
	// (get) Token: 0x0600C26E RID: 49774 RVA: 0x002BE1FE File Offset: 0x002BC3FE
	public IReadOnlyDictionary<int, DailyActivityDefine.IActivityGoalData> GoalMap
	{
		get
		{
			return WeeklyChallengeModel.Instance.WeeklyGoalMap;
		}
	}

	// Token: 0x0600C26F RID: 49775 RVA: 0x002BE20A File Offset: 0x002BC40A
	public List<int> GetCanRewardIdList()
	{
		return WeeklyChallengeModel.Instance.GetCanRewardIdList();
	}

	// Token: 0x0600C270 RID: 49776 RVA: 0x002BE216 File Offset: 0x002BC416
	public void RequestReward(List<int> idList, Action onClose)
	{
		WeeklyChallengeController.Instance.RequestWeeklyFrameworkScoreReward(idList);
		onClose();
	}

	// Token: 0x0600C271 RID: 49777 RVA: 0x002BE229 File Offset: 0x002BC429
	public List<TItem> GetRewardById(int id)
	{
		return WeeklyChallengeModel.Instance.GetRewardById(id);
	}
}

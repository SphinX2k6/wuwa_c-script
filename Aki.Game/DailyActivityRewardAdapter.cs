using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020019F2 RID: 6642
[NullableContext(1)]
[Nullable(0)]
public class DailyActivityRewardAdapter : DailyActivityDefine.IActivityRewardPanelDataAdapter
{
	// Token: 0x17001042 RID: 4162
	// (get) Token: 0x0600C265 RID: 49765 RVA: 0x002BE18F File Offset: 0x002BC38F
	public double CurrentValue
	{
		get
		{
			return (double)DailyActivityModel.Instance.ActivityValue;
		}
	}

	// Token: 0x17001043 RID: 4163
	// (get) Token: 0x0600C266 RID: 49766 RVA: 0x002BE19C File Offset: 0x002BC39C
	public double MaxValue
	{
		get
		{
			return (double)DailyActivityModel.Instance.ActivityMaxValue;
		}
	}

	// Token: 0x17001044 RID: 4164
	// (get) Token: 0x0600C267 RID: 49767 RVA: 0x002BE1A9 File Offset: 0x002BC3A9
	public IReadOnlyDictionary<int, DailyActivityDefine.IActivityGoalData> GoalMap
	{
		get
		{
			return DailyActivityModel.Instance.DailyActivityGoalMap;
		}
	}

	// Token: 0x0600C268 RID: 49768 RVA: 0x002BE1B5 File Offset: 0x002BC3B5
	public List<int> GetCanRewardIdList()
	{
		return DailyActivityModel.Instance.GetCanRewardIdList();
	}

	// Token: 0x0600C269 RID: 49769 RVA: 0x002BE1C1 File Offset: 0x002BC3C1
	public void RequestReward(List<int> idList, Action onClose)
	{
		DailyActivityController.Instance.RequestDailyActivityReward(idList, onClose);
	}

	// Token: 0x0600C26A RID: 49770 RVA: 0x002BE1CF File Offset: 0x002BC3CF
	public List<TItem> GetRewardById(int id)
	{
		return DailyActivityModel.Instance.GetActivityRewardById(id);
	}
}

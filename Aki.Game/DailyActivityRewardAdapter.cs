using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000EB1 RID: 3761
[NullableContext(1)]
[Nullable(0)]
public class DailyActivityRewardAdapter : DailyActivityDefine.IActivityRewardPanelDataAdapter
{
	// Token: 0x17001067 RID: 4199
	// (get) Token: 0x06009672 RID: 38514 RVA: 0x002C9167 File Offset: 0x002C7367
	public double CurrentValue
	{
		get
		{
			return (double)DailyActivityModel.Instance.ActivityValue;
		}
	}

	// Token: 0x17001068 RID: 4200
	// (get) Token: 0x06009673 RID: 38515 RVA: 0x002C9174 File Offset: 0x002C7374
	public double MaxValue
	{
		get
		{
			return (double)DailyActivityModel.Instance.ActivityMaxValue;
		}
	}

	// Token: 0x17001069 RID: 4201
	// (get) Token: 0x06009674 RID: 38516 RVA: 0x002C9181 File Offset: 0x002C7381
	public IReadOnlyDictionary<int, DailyActivityDefine.IActivityGoalData> GoalMap
	{
		get
		{
			return DailyActivityModel.Instance.DailyActivityGoalMap;
		}
	}

	// Token: 0x06009675 RID: 38517 RVA: 0x002C918D File Offset: 0x002C738D
	public List<int> GetCanRewardIdList()
	{
		return DailyActivityModel.Instance.GetCanRewardIdList();
	}

	// Token: 0x06009676 RID: 38518 RVA: 0x002C9199 File Offset: 0x002C7399
	public void RequestReward(List<int> idList, Action onClose)
	{
		DailyActivityController.Instance.RequestDailyActivityReward(idList, onClose);
	}

	// Token: 0x06009677 RID: 38519 RVA: 0x002C91A7 File Offset: 0x002C73A7
	public List<TItem> GetRewardById(int id)
	{
		return DailyActivityModel.Instance.GetActivityRewardById(id);
	}
}

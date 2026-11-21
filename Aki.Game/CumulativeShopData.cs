using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Google.Protobuf.Collections;

// Token: 0x020006B5 RID: 1717
[NullableContext(1)]
[Nullable(0)]
public class CumulativeShopData : ActivityBaseData
{
	// Token: 0x17000AAC RID: 2732
	// (get) Token: 0x06004EF8 RID: 20216 RVA: 0x001A8EAC File Offset: 0x001A70AC
	public Dictionary<int, ConsumptiveTaskInfo> TaskDataMap { get; } = new Dictionary<int, ConsumptiveTaskInfo>();

	// Token: 0x17000AAD RID: 2733
	// (get) Token: 0x06004EF9 RID: 20217 RVA: 0x001A8EB4 File Offset: 0x001A70B4
	public Dictionary<int, List<int>> TaskTabMap { get; } = new Dictionary<int, List<int>>();

	// Token: 0x06004EFA RID: 20218 RVA: 0x001A8EBC File Offset: 0x001A70BC
	protected override void PhraseEx(ActivityData data)
	{
		this.TaskDataMap.Clear();
		this.TaskTabMap.Clear();
		ConsumptiveActivityInfo consumptiveActivityInfo = data.ConsumptiveActivityInfo;
		if (this.CheckIfInOpenTime() && consumptiveActivityInfo != null)
		{
			this.TotalScore = consumptiveActivityInfo.TotalScore;
		}
		else
		{
			this.TotalScore = 0;
			CumulativeShopController.Instance.ConsumptiveActivityScoreRequest();
		}
		RepeatedField<ConsumptiveTaskInfo> repeatedField = (consumptiveActivityInfo != null) ? consumptiveActivityInfo.Tasks : null;
		if (repeatedField != null)
		{
			foreach (ConsumptiveTaskInfo consumptiveTaskInfo in repeatedField)
			{
				this.TaskDataMap[consumptiveTaskInfo.Id] = consumptiveTaskInfo;
				int taskTab = CumulativeShopConfig.Instance.GetCumulativeShopTaskConfig(consumptiveTaskInfo.Id).Value.TaskTab;
				List<int> list;
				if (!this.TaskTabMap.TryGetValue(taskTab, out list) || list == null)
				{
					list = new List<int>();
				}
				list.Add(consumptiveTaskInfo.Id);
				this.TaskTabMap[taskTab] = list;
			}
		}
		this.CurrencyId = 0;
		this.ShopId = 0;
		ConsumptiveActivity? config = ConfigConsumptiveActivityById.GetConfig(data.Id, true);
		if (config == null)
		{
			return;
		}
		this.ShopId = config.Value.ShopId;
		this.CurrencyId = config.Value.ScoreItemId;
	}

	// Token: 0x06004EFB RID: 20219 RVA: 0x001A9020 File Offset: 0x001A7220
	public bool GetAnyTaskRedDot()
	{
		foreach (KeyValuePair<int, ConsumptiveTaskInfo> keyValuePair in this.TaskDataMap)
		{
			if (keyValuePair.Value.Reward.WaitReward > 0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06004EFC RID: 20220 RVA: 0x001A9088 File Offset: 0x001A7288
	public bool GetTaskTabRedDot(int tabIndex)
	{
		List<int> list;
		if (!this.TaskTabMap.TryGetValue(tabIndex, out list) || list == null)
		{
			return false;
		}
		foreach (int key in list)
		{
			ConsumptiveTaskInfo consumptiveTaskInfo;
			if (this.TaskDataMap.TryGetValue(key, out consumptiveTaskInfo) && consumptiveTaskInfo.Reward.WaitReward > 0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06004EFD RID: 20221 RVA: 0x001A910C File Offset: 0x001A730C
	public override bool GetExDataRedPointShowState()
	{
		return this.GetAnyTaskRedDot();
	}

	// Token: 0x06004EFE RID: 20222 RVA: 0x001A9114 File Offset: 0x001A7314
	public List<int> GetTabTaskList(int tabIndex)
	{
		List<int> list;
		if (!this.TaskTabMap.TryGetValue(tabIndex, out list) || list == null)
		{
			return new List<int>();
		}
		List<int> list2 = new List<int>(list);
		list2.Sort(delegate(int a, int b)
		{
			ConsumptiveTaskReward reward = this.TaskDataMap[a].Reward;
			ConsumptiveTaskReward reward2 = this.TaskDataMap[b].Reward;
			if (reward.WaitReward != reward2.WaitReward)
			{
				int num = (reward.WaitReward > 0) ? -1 : 1;
				int num2 = (reward2.WaitReward > 0) ? -1 : 1;
				return num - num2;
			}
			if (reward.MaxReward == 0 && reward2.MaxReward == 0)
			{
				return a - b;
			}
			int num3 = (reward.MaxReward == 0) ? -1 : ((reward.Rewarded < reward.MaxReward) ? -1 : 1);
			int num4 = (reward2.MaxReward == 0) ? -1 : ((reward2.Rewarded < reward2.MaxReward) ? -1 : 1);
			return num3 - num4;
		});
		return list2;
	}

	// Token: 0x04003902 RID: 14594
	public int ShopId;

	// Token: 0x04003903 RID: 14595
	public int CurrencyId;

	// Token: 0x04003904 RID: 14596
	public int TotalScore;

	// Token: 0x04003905 RID: 14597
	public bool ScoreRequesting;
}

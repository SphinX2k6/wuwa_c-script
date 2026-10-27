using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Google.Protobuf.Collections;

// Token: 0x02001201 RID: 4609
[NullableContext(1)]
[Nullable(0)]
public class CumulativeShopData : ActivityBaseData
{
	// Token: 0x17000A8C RID: 2700
	// (get) Token: 0x06007B62 RID: 31586 RVA: 0x001A01F4 File Offset: 0x0019E3F4
	public Dictionary<int, ConsumptiveTaskInfo> TaskDataMap { get; } = new Dictionary<int, ConsumptiveTaskInfo>();

	// Token: 0x17000A8D RID: 2701
	// (get) Token: 0x06007B63 RID: 31587 RVA: 0x001A01FC File Offset: 0x0019E3FC
	public Dictionary<int, List<int>> TaskTabMap { get; } = new Dictionary<int, List<int>>();

	// Token: 0x06007B64 RID: 31588 RVA: 0x001A0204 File Offset: 0x0019E404
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

	// Token: 0x06007B65 RID: 31589 RVA: 0x001A0368 File Offset: 0x0019E568
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

	// Token: 0x06007B66 RID: 31590 RVA: 0x001A03D0 File Offset: 0x0019E5D0
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

	// Token: 0x06007B67 RID: 31591 RVA: 0x001A0454 File Offset: 0x0019E654
	public override bool GetExDataRedPointShowState()
	{
		return this.GetAnyTaskRedDot();
	}

	// Token: 0x06007B68 RID: 31592 RVA: 0x001A045C File Offset: 0x0019E65C
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

	// Token: 0x04003869 RID: 14441
	public int ShopId;

	// Token: 0x0400386A RID: 14442
	public int CurrencyId;

	// Token: 0x0400386B RID: 14443
	public int TotalScore;

	// Token: 0x0400386C RID: 14444
	public bool ScoreRequesting;
}

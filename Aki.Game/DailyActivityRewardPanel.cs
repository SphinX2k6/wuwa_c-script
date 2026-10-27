using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019FB RID: 6651
[NullableContext(1)]
[Nullable(0)]
public class DailyActivityRewardPanel : UiPanelBase
{
	// Token: 0x0600C292 RID: 49810 RVA: 0x002BEBE0 File Offset: 0x002BCDE0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600C293 RID: 49811 RVA: 0x002BEC19 File Offset: 0x002BCE19
	protected override void OnStart()
	{
		this.RewardLayout = new GenericLayout<DailyActivityRewardItem, DailyActivityRewardData>(base.GetHorizontalLayout(0), new Func<DailyActivityRewardItem>(this.OnCreateRewardItem), null, false, true);
	}

	// Token: 0x0600C294 RID: 49812 RVA: 0x002BEC3C File Offset: 0x002BCE3C
	protected override void OnBeforeDestroy()
	{
		this.RefreshIdContainer = null;
	}

	// Token: 0x0600C295 RID: 49813 RVA: 0x002BEC48 File Offset: 0x002BCE48
	public void Init()
	{
		DailyActivityDefine.IActivityRewardPanelDataAdapter activityRewardPanelDataAdapter = this.DataAdapter ?? new DailyActivityRewardAdapter();
		IReadOnlyDictionary<int, DailyActivityDefine.IActivityGoalData> goalMap = activityRewardPanelDataAdapter.GoalMap;
		this.CurrentValue = activityRewardPanelDataAdapter.CurrentValue;
		this.MaxValue = activityRewardPanelDataAdapter.MaxValue;
		double num = (this.MaxValue > 0.0) ? (this.CurrentValue / this.MaxValue) : 0.0;
		int count = goalMap.Count;
		List<DailyActivityRewardData> list = new List<DailyActivityRewardData>();
		foreach (DailyActivityDefine.IActivityGoalData activityGoalData in goalMap.Values)
		{
			list.Add(new DailyActivityRewardData(activityGoalData.Id, num, count));
		}
		this.TotalRewardCount = list.Count;
		if (this.TotalRewardCount <= 0)
		{
			return;
		}
		this.RewardDataList = list;
		this.RewardLayout.RefreshByData(list, null, false);
		this.SetProgressBarPercent(num);
	}

	// Token: 0x0600C296 RID: 49814 RVA: 0x002BED40 File Offset: 0x002BCF40
	[NullableContext(2)]
	public UUIItem GetRewardItemByIndex(int index)
	{
		return this.RewardLayout.GetItemByIndex(index);
	}

	// Token: 0x0600C297 RID: 49815 RVA: 0x002BED50 File Offset: 0x002BCF50
	private void RefreshAllRewardItem()
	{
		foreach (DailyActivityRewardItem dailyActivityRewardItem in this.RewardLayout.GetLayoutItemList())
		{
			dailyActivityRewardItem.RefreshSelf();
		}
	}

	// Token: 0x0600C298 RID: 49816 RVA: 0x002BEDA8 File Offset: 0x002BCFA8
	private void RefreshRewardItem(int goalId)
	{
		int num = -1;
		for (int i = 0; i < this.RewardDataList.Count; i++)
		{
			if (this.RewardDataList[i].RewardId == goalId)
			{
				num = i;
				break;
			}
		}
		if (num < 0)
		{
			return;
		}
		this.RewardLayout.GetLayoutItemList()[num].RefreshSelf();
	}

	// Token: 0x0600C299 RID: 49817 RVA: 0x002BEE00 File Offset: 0x002BD000
	private void RefreshRewardItemDynamic(double value)
	{
		if (this.RefreshIdContainer.Count != 0)
		{
			ValueTuple<int, int> valueTuple = this.RefreshIdContainer[0];
			if ((double)valueTuple.Item1 <= value)
			{
				this.RefreshRewardItem(valueTuple.Item2);
				this.RefreshIdContainer.RemoveAt(0);
			}
		}
	}

	// Token: 0x0600C29A RID: 49818 RVA: 0x002BEE4C File Offset: 0x002BD04C
	private UniTask PlayItemRewardAnimAsync(int goalId)
	{
		DailyActivityRewardPanel.<PlayItemRewardAnimAsync>d__20 <PlayItemRewardAnimAsync>d__;
		<PlayItemRewardAnimAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayItemRewardAnimAsync>d__.<>4__this = this;
		<PlayItemRewardAnimAsync>d__.goalId = goalId;
		<PlayItemRewardAnimAsync>d__.<>1__state = -1;
		<PlayItemRewardAnimAsync>d__.<>t__builder.Start<DailyActivityRewardPanel.<PlayItemRewardAnimAsync>d__20>(ref <PlayItemRewardAnimAsync>d__);
		return <PlayItemRewardAnimAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C29B RID: 49819 RVA: 0x002BEE98 File Offset: 0x002BD098
	private UniTask GroupPlayItemRewardAnimAsync(List<int> goalIds)
	{
		DailyActivityRewardPanel.<GroupPlayItemRewardAnimAsync>d__21 <GroupPlayItemRewardAnimAsync>d__;
		<GroupPlayItemRewardAnimAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<GroupPlayItemRewardAnimAsync>d__.<>4__this = this;
		<GroupPlayItemRewardAnimAsync>d__.goalIds = goalIds;
		<GroupPlayItemRewardAnimAsync>d__.<>1__state = -1;
		<GroupPlayItemRewardAnimAsync>d__.<>t__builder.Start<DailyActivityRewardPanel.<GroupPlayItemRewardAnimAsync>d__21>(ref <GroupPlayItemRewardAnimAsync>d__);
		return <GroupPlayItemRewardAnimAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C29C RID: 49820 RVA: 0x002BEEE4 File Offset: 0x002BD0E4
	private void GroupPlayItemRewardAnim(List<int> goalIds)
	{
		DailyActivityRewardPanel.<>c__DisplayClass22_0 CS$<>8__locals1 = new DailyActivityRewardPanel.<>c__DisplayClass22_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.goalIds = goalIds;
		UiAsyncTask task = new UiAsyncTask("Reward", delegate()
		{
			DailyActivityRewardPanel.<>c__DisplayClass22_0.<<GroupPlayItemRewardAnim>b__0>d <<GroupPlayItemRewardAnim>b__0>d;
			<<GroupPlayItemRewardAnim>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<GroupPlayItemRewardAnim>b__0>d.<>4__this = CS$<>8__locals1;
			<<GroupPlayItemRewardAnim>b__0>d.<>1__state = -1;
			<<GroupPlayItemRewardAnim>b__0>d.<>t__builder.Start<DailyActivityRewardPanel.<>c__DisplayClass22_0.<<GroupPlayItemRewardAnim>b__0>d>(ref <<GroupPlayItemRewardAnim>b__0>d);
			return <<GroupPlayItemRewardAnim>b__0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x0600C29D RID: 49821 RVA: 0x002BEF28 File Offset: 0x002BD128
	public void OnTickRefresh(float deltaTime)
	{
		if (!this.IsShowAnimate)
		{
			return;
		}
		this.AnimateRunTime += (double)deltaTime * TimeUtil.Instance.Millisecond;
		double alpha = (this.AnimateRunTime / 0.5 > 1.0) ? 1.0 : (this.AnimateRunTime / 0.5);
		this.CurrentValue = MathUtils.Instance.Lerp(this.CurrentSaveValue, (double)this.GoalValue, alpha);
		double progressBarPercent = (this.MaxValue > 0.0) ? (this.CurrentValue / this.MaxValue) : 0.0;
		this.RefreshRewardItemDynamic(this.CurrentValue);
		this.SetProgressBarPercent(progressBarPercent);
		if (this.CurrentValue == (double)this.GoalValue)
		{
			this.EndProgressAnimate();
		}
	}

	// Token: 0x0600C29E RID: 49822 RVA: 0x002BF000 File Offset: 0x002BD200
	private void SetProgressBarPercent(double percent)
	{
		foreach (DailyActivityRewardItem dailyActivityRewardItem in this.RewardLayout.GetLayoutItemList())
		{
			dailyActivityRewardItem.RefreshProgress(percent);
		}
	}

	// Token: 0x0600C29F RID: 49823 RVA: 0x002BF058 File Offset: 0x002BD258
	private void StartProgressAnimate(float goalValue)
	{
		this.GoalValue = goalValue;
		this.CurrentSaveValue = this.CurrentValue;
		this.AnimateRunTime = 0.0;
		this.IsShowAnimate = true;
	}

	// Token: 0x0600C2A0 RID: 49824 RVA: 0x002BF084 File Offset: 0x002BD284
	private void EndProgressAnimate()
	{
		this.IsShowAnimate = false;
		this.CurrentValue = (double)this.GoalValue;
		double progressBarPercent = (this.MaxValue > 0.0) ? MathUtils.Instance.Clamp((double)this.GoalValue / this.MaxValue, 0.0, 1.0) : 0.0;
		this.RefreshAllRewardItem();
		this.SetProgressBarPercent(progressBarPercent);
	}

	// Token: 0x0600C2A1 RID: 49825 RVA: 0x002BF0FC File Offset: 0x002BD2FC
	public void RefreshProgressBarDynamic(float value)
	{
		if ((double)value <= this.CurrentValue)
		{
			return;
		}
		if (this.IsShowAnimate)
		{
			this.EndProgressAnimate();
		}
		IEnumerable<KeyValuePair<int, DailyActivityDefine.IActivityGoalData>> goalMap = (this.DataAdapter ?? new DailyActivityRewardAdapter()).GoalMap;
		this.RefreshIdContainer = new List<ValueTuple<int, int>>();
		foreach (KeyValuePair<int, DailyActivityDefine.IActivityGoalData> keyValuePair in goalMap)
		{
			int key = keyValuePair.Key;
			DailyActivityDefine.IActivityGoalData value2 = keyValuePair.Value;
			if (this.CurrentValue < (double)value2.Goal && (float)value2.Goal <= value)
			{
				this.RefreshIdContainer.Add(new ValueTuple<int, int>(value2.Goal, key));
			}
		}
		this.StartProgressAnimate(value);
	}

	// Token: 0x0600C2A2 RID: 49826 RVA: 0x002BF1BC File Offset: 0x002BD3BC
	private void OnRewardTake(IReadOnlyList<int> ids)
	{
		foreach (int goalId in ids)
		{
			this.RefreshRewardItem(goalId);
		}
	}

	// Token: 0x0600C2A3 RID: 49827 RVA: 0x002BF204 File Offset: 0x002BD404
	private void RequestGetAllAvailableReward()
	{
		DailyActivityDefine.IActivityRewardPanelDataAdapter activityRewardPanelDataAdapter = this.DataAdapter ?? new DailyActivityRewardAdapter();
		List<int> idList = activityRewardPanelDataAdapter.GetCanRewardIdList();
		Action onClose = delegate()
		{
			this.GroupPlayItemRewardAnim(idList);
		};
		activityRewardPanelDataAdapter.RequestReward(idList, onClose);
	}

	// Token: 0x0600C2A4 RID: 49828 RVA: 0x002BF254 File Offset: 0x002BD454
	private DailyActivityRewardItem OnCreateRewardItem()
	{
		return new DailyActivityRewardItem
		{
			RewardRequestDelegate = new Action(this.RequestGetAllAvailableReward),
			DataAdapter = this.DataAdapter
		};
	}

	// Token: 0x040059A5 RID: 22949
	private const float PROGRESS_ANIMATE_TIME = 0.5f;

	// Token: 0x040059A6 RID: 22950
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<DailyActivityRewardItem, DailyActivityRewardData> RewardLayout;

	// Token: 0x040059A7 RID: 22951
	private double CurrentValue;

	// Token: 0x040059A8 RID: 22952
	private double MaxValue;

	// Token: 0x040059A9 RID: 22953
	private float GoalValue;

	// Token: 0x040059AA RID: 22954
	private double CurrentSaveValue;

	// Token: 0x040059AB RID: 22955
	private bool IsShowAnimate;

	// Token: 0x040059AC RID: 22956
	private double AnimateRunTime;

	// Token: 0x040059AD RID: 22957
	[Nullable(new byte[]
	{
		2,
		0
	})]
	private List<ValueTuple<int, int>> RefreshIdContainer = new List<ValueTuple<int, int>>();

	// Token: 0x040059AE RID: 22958
	private List<DailyActivityRewardData> RewardDataList = new List<DailyActivityRewardData>();

	// Token: 0x040059AF RID: 22959
	private int TotalRewardCount;

	// Token: 0x040059B0 RID: 22960
	[Nullable(2)]
	public DailyActivityDefine.IActivityRewardPanelDataAdapter DataAdapter;
}

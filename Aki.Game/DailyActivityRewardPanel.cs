using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000EBA RID: 3770
[NullableContext(1)]
[Nullable(0)]
public class DailyActivityRewardPanel : UiPanelBase
{
	// Token: 0x0600969F RID: 38559 RVA: 0x002C9BB8 File Offset: 0x002C7DB8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x060096A0 RID: 38560 RVA: 0x002C9BF1 File Offset: 0x002C7DF1
	protected override void OnStart()
	{
		this.RewardLayout = new GenericLayout<DailyActivityRewardItem, DailyActivityRewardData>(base.GetHorizontalLayout(0), new Func<DailyActivityRewardItem>(this.OnCreateRewardItem), null, false, true);
	}

	// Token: 0x060096A1 RID: 38561 RVA: 0x002C9C14 File Offset: 0x002C7E14
	protected override void OnBeforeDestroy()
	{
		this.RefreshIdContainer = null;
	}

	// Token: 0x060096A2 RID: 38562 RVA: 0x002C9C20 File Offset: 0x002C7E20
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

	// Token: 0x060096A3 RID: 38563 RVA: 0x002C9D18 File Offset: 0x002C7F18
	[NullableContext(2)]
	public UUIItem GetRewardItemByIndex(int index)
	{
		return this.RewardLayout.GetItemByIndex(index);
	}

	// Token: 0x060096A4 RID: 38564 RVA: 0x002C9D28 File Offset: 0x002C7F28
	private void RefreshAllRewardItem()
	{
		foreach (DailyActivityRewardItem dailyActivityRewardItem in this.RewardLayout.GetLayoutItemList())
		{
			dailyActivityRewardItem.RefreshSelf();
		}
	}

	// Token: 0x060096A5 RID: 38565 RVA: 0x002C9D80 File Offset: 0x002C7F80
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

	// Token: 0x060096A6 RID: 38566 RVA: 0x002C9DD8 File Offset: 0x002C7FD8
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

	// Token: 0x060096A7 RID: 38567 RVA: 0x002C9E24 File Offset: 0x002C8024
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

	// Token: 0x060096A8 RID: 38568 RVA: 0x002C9E70 File Offset: 0x002C8070
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

	// Token: 0x060096A9 RID: 38569 RVA: 0x002C9EBC File Offset: 0x002C80BC
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

	// Token: 0x060096AA RID: 38570 RVA: 0x002C9F00 File Offset: 0x002C8100
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

	// Token: 0x060096AB RID: 38571 RVA: 0x002C9FD8 File Offset: 0x002C81D8
	private void SetProgressBarPercent(double percent)
	{
		foreach (DailyActivityRewardItem dailyActivityRewardItem in this.RewardLayout.GetLayoutItemList())
		{
			dailyActivityRewardItem.RefreshProgress(percent);
		}
	}

	// Token: 0x060096AC RID: 38572 RVA: 0x002CA030 File Offset: 0x002C8230
	private void StartProgressAnimate(float goalValue)
	{
		this.GoalValue = goalValue;
		this.CurrentSaveValue = this.CurrentValue;
		this.AnimateRunTime = 0.0;
		this.IsShowAnimate = true;
	}

	// Token: 0x060096AD RID: 38573 RVA: 0x002CA05C File Offset: 0x002C825C
	private void EndProgressAnimate()
	{
		this.IsShowAnimate = false;
		this.CurrentValue = (double)this.GoalValue;
		double progressBarPercent = (this.MaxValue > 0.0) ? MathUtils.Instance.Clamp((double)this.GoalValue / this.MaxValue, 0.0, 1.0) : 0.0;
		this.RefreshAllRewardItem();
		this.SetProgressBarPercent(progressBarPercent);
	}

	// Token: 0x060096AE RID: 38574 RVA: 0x002CA0D4 File Offset: 0x002C82D4
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

	// Token: 0x060096AF RID: 38575 RVA: 0x002CA194 File Offset: 0x002C8394
	private void OnRewardTake(IReadOnlyList<int> ids)
	{
		foreach (int goalId in ids)
		{
			this.RefreshRewardItem(goalId);
		}
	}

	// Token: 0x060096B0 RID: 38576 RVA: 0x002CA1DC File Offset: 0x002C83DC
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

	// Token: 0x060096B1 RID: 38577 RVA: 0x002CA22C File Offset: 0x002C842C
	private DailyActivityRewardItem OnCreateRewardItem()
	{
		return new DailyActivityRewardItem
		{
			RewardRequestDelegate = new Action(this.RequestGetAllAvailableReward),
			DataAdapter = this.DataAdapter
		};
	}

	// Token: 0x04005A74 RID: 23156
	private const float PROGRESS_ANIMATE_TIME = 0.5f;

	// Token: 0x04005A75 RID: 23157
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<DailyActivityRewardItem, DailyActivityRewardData> RewardLayout;

	// Token: 0x04005A76 RID: 23158
	private double CurrentValue;

	// Token: 0x04005A77 RID: 23159
	private double MaxValue;

	// Token: 0x04005A78 RID: 23160
	private float GoalValue;

	// Token: 0x04005A79 RID: 23161
	private double CurrentSaveValue;

	// Token: 0x04005A7A RID: 23162
	private bool IsShowAnimate;

	// Token: 0x04005A7B RID: 23163
	private double AnimateRunTime;

	// Token: 0x04005A7C RID: 23164
	[Nullable(new byte[]
	{
		2,
		0
	})]
	private List<ValueTuple<int, int>> RefreshIdContainer = new List<ValueTuple<int, int>>();

	// Token: 0x04005A7D RID: 23165
	private List<DailyActivityRewardData> RewardDataList = new List<DailyActivityRewardData>();

	// Token: 0x04005A7E RID: 23166
	private int TotalRewardCount;

	// Token: 0x04005A7F RID: 23167
	[Nullable(2)]
	public DailyActivityDefine.IActivityRewardPanelDataAdapter DataAdapter;
}

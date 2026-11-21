using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F80 RID: 3968
[NullableContext(1)]
[Nullable(0)]
public class MapAreaRewardPanel : UiPanelBase
{
	// Token: 0x06009F18 RID: 40728 RVA: 0x002EF748 File Offset: 0x002ED948
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009F19 RID: 40729 RVA: 0x002EF858 File Offset: 0x002EDA58
	protected override void OnStart()
	{
		this.RewardLayout = new GenericLayout<MapAreaRewardItem, DailyActivityDefine.IActivityGoalData>(base.GetHorizontalLayout(3), new Func<MapAreaRewardItem>(this.OnCreateRewardItem), null, false, true);
		UUIItem item = base.GetItem(0);
		this.MaxProgressWidth = item.GetWidth();
		this.ProgressBarItem = base.GetItem(0);
	}

	// Token: 0x06009F1A RID: 40730 RVA: 0x002EF8A7 File Offset: 0x002EDAA7
	protected override void OnBeforeDestroy()
	{
		this.ProgressBarItem = null;
		this.RefreshIdContainer = null;
		this.RewardPopup = null;
	}

	// Token: 0x06009F1B RID: 40731 RVA: 0x002EF8BE File Offset: 0x002EDABE
	public void Init(IMapAreaRewardParam param)
	{
		this.ChangeParamData(param);
	}

	// Token: 0x06009F1C RID: 40732 RVA: 0x002EF8C7 File Offset: 0x002EDAC7
	public void InitCommonRewardPopup(UUIItem rootItem)
	{
		this.RewardPopup = new CommonRewardPopup(rootItem);
	}

	// Token: 0x06009F1D RID: 40733 RVA: 0x002EF8D8 File Offset: 0x002EDAD8
	public void ChangeParamData(IMapAreaRewardParam param)
	{
		this.ParamData = param;
		this.CurrentValue = param.InitValue;
		this.CurrentFinishedRewardCount = 0;
		this.IdToIndexMap.Clear();
		for (int i = 0; i < param.RewardDataList.Count; i++)
		{
			DailyActivityDefine.IActivityGoalData activityGoalData = param.RewardDataList[i];
			if (activityGoalData.State != EDailyActiveState.Unfinished)
			{
				this.CurrentFinishedRewardCount++;
			}
			this.IdToIndexMap[activityGoalData.Id] = i;
		}
		this.RewardLayout.RefreshByData(param.RewardDataList, null, false);
		base.GetSprite(2).SetUIActive(false);
		base.GetSprite(6).SetUIActive(false);
		if (param.RewardDataList.Count != 0)
		{
			this.RewardWidth = 120f;
			this.LineWidth = (this.MaxProgressWidth - this.RewardWidth * (float)(param.RewardDataList.Count - 1)) / (float)param.RewardDataList.Count;
			this.SetProgressBarPercent((float)this.CurrentValue / (float)param.MaxValue);
			return;
		}
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetUIActive(false);
	}

	// Token: 0x06009F1E RID: 40734 RVA: 0x002EF9F4 File Offset: 0x002EDBF4
	public void OnTickRefresh(float deltaTime)
	{
		if (!this.IsShowAnimate)
		{
			return;
		}
		this.AnimateRunTime += (double)deltaTime * TimeUtil.Instance.Millisecond;
		double alpha = MathUtils.Instance.Clamp(this.AnimateRunTime / 0.5, 0.0, 1.0);
		this.CurrentValue = (int)MathUtils.Instance.Lerp((double)this.CurrentSaveValue, (double)this.GoalValue, alpha);
		float progressBarPercent = MathUtils.Instance.Clamp((float)this.CurrentValue / (float)this.ParamData.MaxValue, 0f, 1f);
		this.RefreshRewardItemDynamic(this.CurrentValue);
		this.SetProgressBarPercent(progressBarPercent);
		if (this.CurrentValue == this.GoalValue)
		{
			this.EndProgressAnimate();
		}
	}

	// Token: 0x06009F1F RID: 40735 RVA: 0x002EFAC4 File Offset: 0x002EDCC4
	public void RefreshProgressBarDynamic(int value)
	{
		if (value <= this.CurrentValue)
		{
			return;
		}
		if (this.IsShowAnimate)
		{
			this.EndProgressAnimate();
		}
		this.RefreshIdContainer = new List<ValueTuple<int, int>>();
		foreach (DailyActivityDefine.IActivityGoalData activityGoalData in this.ParamData.RewardDataList)
		{
			if (this.CurrentValue < activityGoalData.Goal && activityGoalData.Goal <= value)
			{
				this.RefreshIdContainer.Add(new ValueTuple<int, int>(activityGoalData.Goal, activityGoalData.Id));
			}
		}
		this.StartProgressAnimate(value);
	}

	// Token: 0x06009F20 RID: 40736 RVA: 0x002EFB74 File Offset: 0x002EDD74
	public void UpdateRewardIds(IReadOnlyList<int> ids)
	{
		foreach (int goalId in ids)
		{
			this.RefreshRewardItem(goalId);
		}
	}

	// Token: 0x06009F21 RID: 40737 RVA: 0x002EFBBC File Offset: 0x002EDDBC
	protected override void OnBeforeHide()
	{
		CommonRewardPopup rewardPopup = this.RewardPopup;
		if (rewardPopup == null)
		{
			return;
		}
		rewardPopup.SetActive(false);
	}

	// Token: 0x06009F22 RID: 40738 RVA: 0x002EFBD0 File Offset: 0x002EDDD0
	private void RefreshAllRewardItem()
	{
		int num = 0;
		foreach (MapAreaRewardItem mapAreaRewardItem in this.RewardLayout.GetLayoutItemList())
		{
			mapAreaRewardItem.RefreshSelf();
			if (mapAreaRewardItem.DailyActiveState.GetValueOrDefault() != EDailyActiveState.Unfinished)
			{
				num++;
			}
		}
		this.CurrentFinishedRewardCount = num;
	}

	// Token: 0x06009F23 RID: 40739 RVA: 0x002EFC44 File Offset: 0x002EDE44
	private void RefreshRewardItem(int goalId)
	{
		int index;
		if (this.IdToIndexMap.TryGetValue(goalId, out index))
		{
			MapAreaRewardItem layoutItemByIndex = this.RewardLayout.GetLayoutItemByIndex(index);
			if (layoutItemByIndex == null)
			{
				return;
			}
			layoutItemByIndex.RefreshSelf();
		}
	}

	// Token: 0x06009F24 RID: 40740 RVA: 0x002EFC78 File Offset: 0x002EDE78
	private void RefreshRewardItemDynamic(int value)
	{
		if (this.RefreshIdContainer.Count == 0)
		{
			return;
		}
		ValueTuple<int, int> valueTuple = this.RefreshIdContainer[0];
		if (valueTuple.Item1 <= value)
		{
			this.RefreshRewardItem(valueTuple.Item2);
			this.RefreshIdContainer.RemoveAt(0);
			this.CurrentFinishedRewardCount++;
		}
	}

	// Token: 0x06009F25 RID: 40741 RVA: 0x002EFCD0 File Offset: 0x002EDED0
	private void SetProgressBarPercent(float percent)
	{
		int count = this.ParamData.RewardDataList.Count;
		float num = (float)Math.Min(this.CurrentFinishedRewardCount, count - 1) * this.RewardWidth;
		float num2 = this.LineWidth * (float)count * Math.Min(percent, 1f);
		float stretchRight = this.MaxProgressWidth - num - num2;
		this.ProgressBarItem.SetStretchRight(stretchRight);
	}

	// Token: 0x06009F26 RID: 40742 RVA: 0x002EFD32 File Offset: 0x002EDF32
	private void StartProgressAnimate(int goalValue)
	{
		this.GoalValue = goalValue;
		this.CurrentSaveValue = this.CurrentValue;
		this.AnimateRunTime = 0.0;
		this.IsShowAnimate = true;
	}

	// Token: 0x06009F27 RID: 40743 RVA: 0x002EFD60 File Offset: 0x002EDF60
	private void EndProgressAnimate()
	{
		this.IsShowAnimate = false;
		this.CurrentValue = this.GoalValue;
		float progressBarPercent = MathUtils.Instance.Clamp((float)this.GoalValue / (float)this.ParamData.MaxValue, 0f, 1f);
		this.RefreshAllRewardItem();
		this.SetProgressBarPercent(progressBarPercent);
	}

	// Token: 0x06009F28 RID: 40744 RVA: 0x002EFDB8 File Offset: 0x002EDFB8
	private MapAreaRewardItem OnCreateRewardItem()
	{
		UUISprite sprite = base.GetSprite(2);
		UUIItem item = base.GetItem(1);
		UUIItem item2 = base.GetItem(5);
		UUISprite sprite2 = base.GetSprite(6);
		LguiUtil.Instance.CopyItem(sprite2, item2);
		LguiUtil.Instance.CopyItem(sprite, item);
		return new MapAreaRewardItem(this.ParamData.GetRewardCallback, new Action<RewardPopupData>(this.OpenRewardCallback));
	}

	// Token: 0x06009F29 RID: 40745 RVA: 0x002EFE1B File Offset: 0x002EE01B
	private void OpenRewardCallback(RewardPopupData data)
	{
		CommonRewardPopup rewardPopup = this.RewardPopup;
		if (rewardPopup == null)
		{
			return;
		}
		rewardPopup.Refresh(data);
	}

	// Token: 0x04005E3E RID: 24126
	private const float PROGRESS_ANIMATE_TIME = 0.5f;

	// Token: 0x04005E3F RID: 24127
	private const int REWARD_WIDTH = 120;

	// Token: 0x04005E40 RID: 24128
	private IMapAreaRewardParam ParamData;

	// Token: 0x04005E41 RID: 24129
	private GenericLayout<MapAreaRewardItem, DailyActivityDefine.IActivityGoalData> RewardLayout;

	// Token: 0x04005E42 RID: 24130
	[Nullable(2)]
	private UUIItem ProgressBarItem;

	// Token: 0x04005E43 RID: 24131
	private int CurrentValue;

	// Token: 0x04005E44 RID: 24132
	private int GoalValue;

	// Token: 0x04005E45 RID: 24133
	private int CurrentSaveValue;

	// Token: 0x04005E46 RID: 24134
	private bool IsShowAnimate;

	// Token: 0x04005E47 RID: 24135
	private double AnimateRunTime;

	// Token: 0x04005E48 RID: 24136
	[Nullable(new byte[]
	{
		2,
		0
	})]
	private List<ValueTuple<int, int>> RefreshIdContainer = new List<ValueTuple<int, int>>();

	// Token: 0x04005E49 RID: 24137
	private readonly Dictionary<int, int> IdToIndexMap = new Dictionary<int, int>();

	// Token: 0x04005E4A RID: 24138
	private int CurrentFinishedRewardCount;

	// Token: 0x04005E4B RID: 24139
	private float MaxProgressWidth;

	// Token: 0x04005E4C RID: 24140
	private float RewardWidth;

	// Token: 0x04005E4D RID: 24141
	private float LineWidth;

	// Token: 0x04005E4E RID: 24142
	[Nullable(2)]
	private CommonRewardPopup RewardPopup;

	// Token: 0x020071A6 RID: 29094
	[NullableContext(0)]
	private enum EActivityPanelItem
	{
		// Token: 0x0402504D RID: 151629
		ProgressPanel,
		// Token: 0x0402504E RID: 151630
		BarPanel,
		// Token: 0x0402504F RID: 151631
		BarSprite,
		// Token: 0x04025050 RID: 151632
		RewardPanel,
		// Token: 0x04025051 RID: 151633
		RewardItem,
		// Token: 0x04025052 RID: 151634
		PanelBackground,
		// Token: 0x04025053 RID: 151635
		BackgroundSprite
	}
}

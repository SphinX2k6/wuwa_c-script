using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001AC1 RID: 6849
[NullableContext(1)]
[Nullable(0)]
public class MapAreaRewardPanel : UiPanelBase
{
	// Token: 0x0600CB07 RID: 51975 RVA: 0x002E45C4 File Offset: 0x002E27C4
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

	// Token: 0x0600CB08 RID: 51976 RVA: 0x002E46D4 File Offset: 0x002E28D4
	protected override void OnStart()
	{
		this.RewardLayout = new GenericLayout<MapAreaRewardItem, DailyActivityDefine.IActivityGoalData>(base.GetHorizontalLayout(3), new Func<MapAreaRewardItem>(this.OnCreateRewardItem), null, false, true);
		UUIItem item = base.GetItem(0);
		this.MaxProgressWidth = item.GetWidth();
		this.ProgressBarItem = base.GetItem(0);
	}

	// Token: 0x0600CB09 RID: 51977 RVA: 0x002E4723 File Offset: 0x002E2923
	protected override void OnBeforeDestroy()
	{
		this.ProgressBarItem = null;
		this.RefreshIdContainer = null;
		this.RewardPopup = null;
	}

	// Token: 0x0600CB0A RID: 51978 RVA: 0x002E473A File Offset: 0x002E293A
	public void Init(IMapAreaRewardParam param)
	{
		this.ChangeParamData(param);
	}

	// Token: 0x0600CB0B RID: 51979 RVA: 0x002E4743 File Offset: 0x002E2943
	public void InitCommonRewardPopup(UUIItem rootItem)
	{
		this.RewardPopup = new CommonRewardPopup(rootItem);
	}

	// Token: 0x0600CB0C RID: 51980 RVA: 0x002E4754 File Offset: 0x002E2954
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

	// Token: 0x0600CB0D RID: 51981 RVA: 0x002E4870 File Offset: 0x002E2A70
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

	// Token: 0x0600CB0E RID: 51982 RVA: 0x002E4940 File Offset: 0x002E2B40
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

	// Token: 0x0600CB0F RID: 51983 RVA: 0x002E49F0 File Offset: 0x002E2BF0
	public void UpdateRewardIds(IReadOnlyList<int> ids)
	{
		foreach (int goalId in ids)
		{
			this.RefreshRewardItem(goalId);
		}
	}

	// Token: 0x0600CB10 RID: 51984 RVA: 0x002E4A38 File Offset: 0x002E2C38
	protected override void OnBeforeHide()
	{
		CommonRewardPopup rewardPopup = this.RewardPopup;
		if (rewardPopup == null)
		{
			return;
		}
		rewardPopup.SetActive(false);
	}

	// Token: 0x0600CB11 RID: 51985 RVA: 0x002E4A4C File Offset: 0x002E2C4C
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

	// Token: 0x0600CB12 RID: 51986 RVA: 0x002E4AC0 File Offset: 0x002E2CC0
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

	// Token: 0x0600CB13 RID: 51987 RVA: 0x002E4AF4 File Offset: 0x002E2CF4
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

	// Token: 0x0600CB14 RID: 51988 RVA: 0x002E4B4C File Offset: 0x002E2D4C
	private void SetProgressBarPercent(float percent)
	{
		int count = this.ParamData.RewardDataList.Count;
		float num = (float)Math.Min(this.CurrentFinishedRewardCount, count - 1) * this.RewardWidth;
		float num2 = this.LineWidth * (float)count * Math.Min(percent, 1f);
		float stretchRight = this.MaxProgressWidth - num - num2;
		this.ProgressBarItem.SetStretchRight(stretchRight);
	}

	// Token: 0x0600CB15 RID: 51989 RVA: 0x002E4BAE File Offset: 0x002E2DAE
	private void StartProgressAnimate(int goalValue)
	{
		this.GoalValue = goalValue;
		this.CurrentSaveValue = this.CurrentValue;
		this.AnimateRunTime = 0.0;
		this.IsShowAnimate = true;
	}

	// Token: 0x0600CB16 RID: 51990 RVA: 0x002E4BDC File Offset: 0x002E2DDC
	private void EndProgressAnimate()
	{
		this.IsShowAnimate = false;
		this.CurrentValue = this.GoalValue;
		float progressBarPercent = MathUtils.Instance.Clamp((float)this.GoalValue / (float)this.ParamData.MaxValue, 0f, 1f);
		this.RefreshAllRewardItem();
		this.SetProgressBarPercent(progressBarPercent);
	}

	// Token: 0x0600CB17 RID: 51991 RVA: 0x002E4C34 File Offset: 0x002E2E34
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

	// Token: 0x0600CB18 RID: 51992 RVA: 0x002E4C97 File Offset: 0x002E2E97
	private void OpenRewardCallback(RewardPopupData data)
	{
		CommonRewardPopup rewardPopup = this.RewardPopup;
		if (rewardPopup == null)
		{
			return;
		}
		rewardPopup.Refresh(data);
	}

	// Token: 0x04005D6F RID: 23919
	private const float PROGRESS_ANIMATE_TIME = 0.5f;

	// Token: 0x04005D70 RID: 23920
	private const int REWARD_WIDTH = 120;

	// Token: 0x04005D71 RID: 23921
	private IMapAreaRewardParam ParamData;

	// Token: 0x04005D72 RID: 23922
	private GenericLayout<MapAreaRewardItem, DailyActivityDefine.IActivityGoalData> RewardLayout;

	// Token: 0x04005D73 RID: 23923
	[Nullable(2)]
	private UUIItem ProgressBarItem;

	// Token: 0x04005D74 RID: 23924
	private int CurrentValue;

	// Token: 0x04005D75 RID: 23925
	private int GoalValue;

	// Token: 0x04005D76 RID: 23926
	private int CurrentSaveValue;

	// Token: 0x04005D77 RID: 23927
	private bool IsShowAnimate;

	// Token: 0x04005D78 RID: 23928
	private double AnimateRunTime;

	// Token: 0x04005D79 RID: 23929
	[Nullable(new byte[]
	{
		2,
		0
	})]
	private List<ValueTuple<int, int>> RefreshIdContainer = new List<ValueTuple<int, int>>();

	// Token: 0x04005D7A RID: 23930
	private readonly Dictionary<int, int> IdToIndexMap = new Dictionary<int, int>();

	// Token: 0x04005D7B RID: 23931
	private int CurrentFinishedRewardCount;

	// Token: 0x04005D7C RID: 23932
	private float MaxProgressWidth;

	// Token: 0x04005D7D RID: 23933
	private float RewardWidth;

	// Token: 0x04005D7E RID: 23934
	private float LineWidth;

	// Token: 0x04005D7F RID: 23935
	[Nullable(2)]
	private CommonRewardPopup RewardPopup;

	// Token: 0x02008017 RID: 32791
	[NullableContext(0)]
	private enum EActivityPanelItem
	{
		// Token: 0x04029D14 RID: 171284
		ProgressPanel,
		// Token: 0x04029D15 RID: 171285
		BarPanel,
		// Token: 0x04029D16 RID: 171286
		BarSprite,
		// Token: 0x04029D17 RID: 171287
		RewardPanel,
		// Token: 0x04029D18 RID: 171288
		RewardItem,
		// Token: 0x04029D19 RID: 171289
		PanelBackground,
		// Token: 0x04029D1A RID: 171290
		BackgroundSprite
	}
}

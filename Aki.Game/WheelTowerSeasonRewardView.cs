using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower.View.Season;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001646 RID: 5702
[NullableContext(2)]
[Nullable(0)]
public class WheelTowerSeasonRewardView : UiTickViewBase
{
	// Token: 0x0600A01F RID: 40991 RVA: 0x00233AAC File Offset: 0x00231CAC
	[NullableContext(1)]
	public WheelTowerSeasonRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600A020 RID: 40992 RVA: 0x00233AB8 File Offset: 0x00231CB8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIMultiTemplateScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A021 RID: 40993 RVA: 0x00233C94 File Offset: 0x00231E94
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerSeasonRewardView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerSeasonRewardView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A022 RID: 40994 RVA: 0x00233CD8 File Offset: 0x00231ED8
	protected override void OnTick(float delta)
	{
		if (this.TaskGridCount <= 0 || this.TaskLoopScroll == null)
		{
			return;
		}
		for (int i = 0; i < this.TaskGridCount; i++)
		{
			ISyncGridProxy proxyByGridIndex = this.TaskLoopScroll.GetProxyByGridIndex(i);
			WheelTowerSeasonTaskItem wheelTowerSeasonTaskItem = proxyByGridIndex as WheelTowerSeasonTaskItem;
			if (wheelTowerSeasonTaskItem == null)
			{
				WheelTowerSeasonTaskCategoryItem wheelTowerSeasonTaskCategoryItem = proxyByGridIndex as WheelTowerSeasonTaskCategoryItem;
				if (wheelTowerSeasonTaskCategoryItem != null)
				{
					wheelTowerSeasonTaskCategoryItem.OnTick();
				}
			}
			else
			{
				wheelTowerSeasonTaskItem.OnTick();
			}
		}
	}

	// Token: 0x0600A023 RID: 40995 RVA: 0x00233D3C File Offset: 0x00231F3C
	[NullableContext(1)]
	private List<IWheelTowerSeasonScoreData> GetSeasonScoreDataList()
	{
		int seasonScoreItemId = WheelTowerConfig.Instance.GetSeasonScoreItemId(this.SeasonId);
		int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(seasonScoreItemId, 0);
		IReadOnlyList<NewTowerSeasonSAward> readOnlyList = WheelTowerConfig.Instance.GetSeasonScoreRewardConfigList(this.SeasonId) ?? Array.Empty<NewTowerSeasonSAward>();
		List<IWheelTowerSeasonScoreData> list = new List<IWheelTowerSeasonScoreData>();
		int totalScore = (readOnlyList.Count > 0) ? readOnlyList[readOnlyList.Count - 1].Score : 0;
		int prevScore = 0;
		foreach (NewTowerSeasonSAward newTowerSeasonSAward in readOnlyList)
		{
			list.Add(new WheelTowerSeasonScoreData
			{
				Score = newTowerSeasonSAward.Score,
				PrevScore = prevScore,
				TotalScore = totalScore,
				CurScore = itemCountByConfigId,
				IsReceived = this.ActivityData.IsSeasonScoreRewardReceived(newTowerSeasonSAward.Id),
				DropId = newTowerSeasonSAward.DropId,
				MotorPreviewId = newTowerSeasonSAward.MotorPreviewId,
				WeaponPreviewId = newTowerSeasonSAward.WeaponPreviewId,
				PreviewIcon = newTowerSeasonSAward.PreviewIcon
			});
			prevScore = newTowerSeasonSAward.Score;
		}
		return list;
	}

	// Token: 0x0600A024 RID: 40996 RVA: 0x00233E74 File Offset: 0x00232074
	private void RefreshInfo()
	{
		this.RefreshTitle();
		this.RefreshDesc();
		this.RefreshRewardInfo();
		this.RefreshTaskScroll();
		this.RefreshProgressItem();
		this.RefreshMedalEntry();
	}

	// Token: 0x0600A025 RID: 40997 RVA: 0x00233E9C File Offset: 0x0023209C
	private void RefreshTitle()
	{
		NewTowerSeason? seasonConfig = WheelTowerConfig.Instance.GetSeasonConfig(this.SeasonId);
		if (seasonConfig == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), seasonConfig.Value.Name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "WheelTower_SeasonReward_EndVersion", new <>z__ReadOnlySingleElementList<object>(seasonConfig.Value.EndVersionId));
		base.SetTextureByPath(seasonConfig.Value.SmallIcon, base.GetTexture(6), null, null);
		base.SetTextureByPath(seasonConfig.Value.VersionIconMain, base.GetTexture(7), null, null);
	}

	// Token: 0x0600A026 RID: 40998 RVA: 0x00233F5F File Offset: 0x0023215F
	private void RefreshDesc()
	{
		UUIItem item = base.GetItem(11);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x0600A027 RID: 40999 RVA: 0x00233F74 File Offset: 0x00232174
	private void RefreshRewardInfo()
	{
		WheelTowerSeasonRewardInfoPanel rewardInfoPanel = this.RewardInfoPanel;
		if (rewardInfoPanel == null)
		{
			return;
		}
		rewardInfoPanel.RefreshDataList(this.GetSeasonScoreDataList());
	}

	// Token: 0x0600A028 RID: 41000 RVA: 0x00233F8C File Offset: 0x0023218C
	private void RefreshTaskScroll()
	{
		WheelTowerData activityData = this.ActivityData;
		List<ActivityTaskData> list = (from task in ((activityData != null) ? activityData.GetSeasonTaskList() : null) ?? new List<ActivityTaskData>()
		orderby task.Status
		select task).ThenBy(delegate(ActivityTaskData task)
		{
			NewTowerSeasonAward? seasonTaskRewardConfig2 = WheelTowerConfig.Instance.GetSeasonTaskRewardConfig(task.Id);
			if (seasonTaskRewardConfig2 == null)
			{
				return task.Id;
			}
			return seasonTaskRewardConfig2.Value.Index;
		}).ToList<ActivityTaskData>();
		List<ActivityTaskData> list2 = new List<ActivityTaskData>();
		List<ActivityTaskData> list3 = new List<ActivityTaskData>();
		foreach (ActivityTaskData activityTaskData in list)
		{
			NewTowerSeasonAward? seasonTaskRewardConfig = WheelTowerConfig.Instance.GetSeasonTaskRewardConfig(activityTaskData.Id);
			if (seasonTaskRewardConfig != null)
			{
				if (seasonTaskRewardConfig.Value.CycleId > 0)
				{
					list2.Add(activityTaskData);
				}
				else
				{
					list3.Add(activityTaskData);
				}
			}
		}
		List<IMultiTemplateGridData> list4 = new List<IMultiTemplateGridData>();
		if (list2.Count > 0)
		{
			list4.Add(new <WheelTowerSeasonRewardView>FBBF3D6A812E94D5AA5DF10EDABE679BF50A994B28144B2AF50A6ACDB52EB89EF__CategoryGridData(ETaskCategory.Cycle));
			foreach (ActivityTaskData data in list2)
			{
				list4.Add(new <WheelTowerSeasonRewardView>FBBF3D6A812E94D5AA5DF10EDABE679BF50A994B28144B2AF50A6ACDB52EB89EF__TaskGridData(data, new Action(this.OnClickGetTaskReward)));
			}
		}
		if (list3.Count > 0)
		{
			list4.Add(new <WheelTowerSeasonRewardView>FBBF3D6A812E94D5AA5DF10EDABE679BF50A994B28144B2AF50A6ACDB52EB89EF__CategoryGridData(ETaskCategory.Challenge));
			foreach (ActivityTaskData data2 in list3)
			{
				list4.Add(new <WheelTowerSeasonRewardView>FBBF3D6A812E94D5AA5DF10EDABE679BF50A994B28144B2AF50A6ACDB52EB89EF__TaskGridData(data2, new Action(this.OnClickGetTaskReward)));
			}
		}
		MultiTemplateScrollView taskLoopScroll = this.TaskLoopScroll;
		if (taskLoopScroll != null)
		{
			taskLoopScroll.RefreshByData(new MultiTemplateScrollViewRefreshContext(list4));
		}
		this.TaskGridCount = list4.Count;
	}

	// Token: 0x0600A029 RID: 41001 RVA: 0x0023417C File Offset: 0x0023237C
	private void RefreshProgressItem()
	{
		int seasonScoreItemId = WheelTowerConfig.Instance.GetSeasonScoreItemId(this.SeasonId);
		int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(seasonScoreItemId, 0);
		WheelTowerSeasonScoreProgressItem scoreProgressItem = this.ScoreProgressItem;
		if (scoreProgressItem == null)
		{
			return;
		}
		scoreProgressItem.Refresh(itemCountByConfigId, this.GetSeasonScoreDataList());
	}

	// Token: 0x0600A02A RID: 41002 RVA: 0x002341BE File Offset: 0x002323BE
	private void RefreshMedalEntry()
	{
		WheelTowerSeasonMedalEntryItem medalEntryItem = this.MedalEntryItem;
		if (medalEntryItem == null)
		{
			return;
		}
		medalEntryItem.Refresh(this.SeasonId);
	}

	// Token: 0x0600A02B RID: 41003 RVA: 0x002341D8 File Offset: 0x002323D8
	private void PlaySwitchTween()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence != null)
		{
			uiViewSequence.StopSequenceByKey("Switch", false, false);
		}
		UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
		if (uiViewSequence2 == null)
		{
			return;
		}
		uiViewSequence2.PlaySequence("Switch", false, null);
	}

	// Token: 0x0600A02C RID: 41004 RVA: 0x0023421C File Offset: 0x0023241C
	private void OnClickGetTaskReward()
	{
		WheelTowerController.Instance.RequestSeasonTaskReceive().ContinueWith(delegate()
		{
			this.RefreshTaskScroll();
			this.RefreshProgressItem();
		});
	}

	// Token: 0x0600A02D RID: 41005 RVA: 0x0023423A File Offset: 0x0023243A
	private void OnClickGetProgressReward()
	{
		WheelTowerController.Instance.RequestSeasonScoreReceive().ContinueWith(delegate()
		{
			this.RefreshRewardInfo();
			this.RefreshProgressItem();
		});
	}

	// Token: 0x0600A02E RID: 41006 RVA: 0x00234258 File Offset: 0x00232458
	private void OnClickClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x040048F1 RID: 18673
	private WheelTowerData ActivityData;

	// Token: 0x040048F2 RID: 18674
	private PopupCaptionItem CaptionItem;

	// Token: 0x040048F3 RID: 18675
	private WheelTowerSeasonRewardInfoPanel RewardInfoPanel;

	// Token: 0x040048F4 RID: 18676
	private MultiTemplateScrollView TaskLoopScroll;

	// Token: 0x040048F5 RID: 18677
	private WheelTowerSeasonScoreProgressItem ScoreProgressItem;

	// Token: 0x040048F6 RID: 18678
	private WheelTowerSeasonMedalEntryItem MedalEntryItem;

	// Token: 0x040048F7 RID: 18679
	private int SeasonId;

	// Token: 0x040048F8 RID: 18680
	private int TaskGridCount;
}

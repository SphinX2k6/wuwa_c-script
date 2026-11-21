using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200062F RID: 1583
public class BabelTowerNormalQuestItem : GridProxyAbstract<int>
{
	// Token: 0x060049E3 RID: 18915 RVA: 0x00191BF0 File Offset: 0x0018FDF0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickGetRewardBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060049E4 RID: 18916 RVA: 0x00191D3B File Offset: 0x0018FF3B
	protected override void OnStart()
	{
		this.RewardScrollerView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(1), new Func<CommonItemSmallItemGrid>(this.InitRewardItem), null, false, null);
	}

	// Token: 0x060049E5 RID: 18917 RVA: 0x00191D60 File Offset: 0x0018FF60
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		BabelTowerTask babelTowerNormalQuest = BabelTowerConfig.Instance.GetBabelTowerNormalQuest(data);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), babelTowerNormalQuest.Title, Array.Empty<object>());
		List<TItem> data2 = (babelTowerNormalQuest.DropId > 0) ? CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(babelTowerNormalQuest.DropId) : new List<TItem>();
		GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardScrollerView = this.RewardScrollerView;
		if (rewardScrollerView != null)
		{
			rewardScrollerView.RefreshByData(data2, null, false);
		}
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		ActivityTask activityTask;
		babelTowerData.NormalQuest.TryGetValue(data, out activityTask);
		ActivityTaskState activityTaskState = (activityTask != null) ? activityTask.Status : ActivityTaskState.ActivityTaskRunning;
		base.GetButton(3).RootUIComp.Get().SetUIActive(activityTaskState == ActivityTaskState.ActivityTaskFinish);
		base.GetItem(6).SetUIActive(activityTaskState == ActivityTaskState.ActivityTaskTaken);
		bool flag = activityTaskState == ActivityTaskState.ActivityTaskRunning;
		base.GetText(5).SetUIActive(flag);
		base.GetItem(4).SetUIActive(activityTaskState == ActivityTaskState.ActivityTaskTaken);
		if (!flag)
		{
			return;
		}
		BabelActivityLevelInfo babelActivityLevelInfo;
		babelTowerData.NormalLevelDataMap.TryGetValue(babelTowerNormalQuest.LevelId, out babelActivityLevelInfo);
		if (babelActivityLevelInfo == null)
		{
			babelTowerData.HardLevelDataMap.TryGetValue(babelTowerNormalQuest.LevelId, out babelActivityLevelInfo);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "BabelTowerTaskDoing", Array.Empty<object>());
		if (babelActivityLevelInfo != null)
		{
			long num = MathUtils.Instance.LongToNumber(babelActivityLevelInfo.UnlockTime);
			if (TimeUtil.Instance.GetServerTimeStamp() < (double)num)
			{
				CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat((double)((long)(((double)num - TimeUtil.Instance.GetServerTimeStamp()) * TimeUtil.Instance.Millisecond)));
				base.GetText(5).SetText(remainTimeDataFormat.CountDownText ?? "", true);
			}
		}
	}

	// Token: 0x060049E6 RID: 18918 RVA: 0x00191F04 File Offset: 0x00190104
	private void OnClickGetRewardBtn()
	{
		List<int> finishedTaskIds = BabelTowerController.Instance.GetBabelTowerData().GetFinishedTaskIds();
		if (finishedTaskIds.Count > 0)
		{
			BabelTowerController.Instance.BabelTowerMultiTaskRewardRequest(finishedTaskIds);
		}
	}

	// Token: 0x060049E7 RID: 18919 RVA: 0x00191F35 File Offset: 0x00190135
	[NullableContext(1)]
	private CommonItemSmallItemGrid InitRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x040036D7 RID: 14039
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollerView;

	// Token: 0x020068DB RID: 26843
	private class EComponentDefine
	{
		// Token: 0x040228F4 RID: 141556
		public const int TitleText = 0;

		// Token: 0x040228F5 RID: 141557
		public const int RewardScrollerView = 1;

		// Token: 0x040228F6 RID: 141558
		public const int RewardItem = 2;

		// Token: 0x040228F7 RID: 141559
		public const int GetRewardBtn = 3;

		// Token: 0x040228F8 RID: 141560
		public const int MaskItem = 4;

		// Token: 0x040228F9 RID: 141561
		public const int DoingText = 5;

		// Token: 0x040228FA RID: 141562
		public const int FishingItem = 6;
	}
}

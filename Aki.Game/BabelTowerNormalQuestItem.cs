using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200117B RID: 4475
public class BabelTowerNormalQuestItem : GridProxyAbstract<int>
{
	// Token: 0x0600764C RID: 30284 RVA: 0x00189040 File Offset: 0x00187240
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

	// Token: 0x0600764D RID: 30285 RVA: 0x0018918B File Offset: 0x0018738B
	protected override void OnStart()
	{
		this.RewardScrollerView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(1), new Func<CommonItemSmallItemGrid>(this.InitRewardItem), null, false, null);
	}

	// Token: 0x0600764E RID: 30286 RVA: 0x001891B0 File Offset: 0x001873B0
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

	// Token: 0x0600764F RID: 30287 RVA: 0x00189354 File Offset: 0x00187554
	private void OnClickGetRewardBtn()
	{
		List<int> finishedTaskIds = BabelTowerController.Instance.GetBabelTowerData().GetFinishedTaskIds();
		if (finishedTaskIds.Count > 0)
		{
			BabelTowerController.Instance.BabelTowerMultiTaskRewardRequest(finishedTaskIds);
		}
	}

	// Token: 0x06007650 RID: 30288 RVA: 0x00189385 File Offset: 0x00187585
	[NullableContext(1)]
	private CommonItemSmallItemGrid InitRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0400363E RID: 13886
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScrollerView;

	// Token: 0x0200774E RID: 30542
	private class EComponentDefine
	{
		// Token: 0x040275BB RID: 161211
		public const int TitleText = 0;

		// Token: 0x040275BC RID: 161212
		public const int RewardScrollerView = 1;

		// Token: 0x040275BD RID: 161213
		public const int RewardItem = 2;

		// Token: 0x040275BE RID: 161214
		public const int GetRewardBtn = 3;

		// Token: 0x040275BF RID: 161215
		public const int MaskItem = 4;

		// Token: 0x040275C0 RID: 161216
		public const int DoingText = 5;

		// Token: 0x040275C1 RID: 161217
		public const int FishingItem = 6;
	}
}

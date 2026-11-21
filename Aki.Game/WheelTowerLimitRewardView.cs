using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000ACF RID: 2767
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerLimitRewardView : UiTickViewBase
{
	// Token: 0x060072F6 RID: 29430 RVA: 0x0023720A File Offset: 0x0023540A
	public WheelTowerLimitRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060072F7 RID: 29431 RVA: 0x00237214 File Offset: 0x00235414
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060072F8 RID: 29432 RVA: 0x00237324 File Offset: 0x00235524
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerLimitRewardView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerLimitRewardView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060072F9 RID: 29433 RVA: 0x00237368 File Offset: 0x00235568
	protected override void OnStart()
	{
		WheelTowerLimitRewardTabItem normalTabItem = this.NormalTabItem;
		if (normalTabItem != null)
		{
			normalTabItem.Refresh(WheelTowerLimitRewardView.WheelTowerDiffList[0]);
		}
		WheelTowerLimitRewardTabItem endlessTabItem = this.EndlessTabItem;
		if (endlessTabItem != null)
		{
			endlessTabItem.Refresh(WheelTowerLimitRewardView.WheelTowerDiffList[1]);
		}
		WheelTowerLimitRewardTabItem normalTabItem2 = this.NormalTabItem;
		if (normalTabItem2 != null)
		{
			normalTabItem2.SetToggleStateForce(true, true);
		}
		PopupCaptionItem caption = this.Caption;
		if (caption == null)
		{
			return;
		}
		caption.SetCloseCallBack(delegate
		{
			base.CloseMe(null);
		});
	}

	// Token: 0x060072FA RID: 29434 RVA: 0x002373DC File Offset: 0x002355DC
	protected override void OnTick(float delta)
	{
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(WheelTowerModel.Instance.ActivityData, ConfigMultiTextLang.GetLocalTextNew("WheelTower_LimitReward_RemainTime", null));
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		UUIText text = base.GetText(6);
		if (text != null)
		{
			text.SetUIActive(item);
		}
		if (item && text != null)
		{
			text.SetText(item2, true);
		}
	}

	// Token: 0x060072FB RID: 29435 RVA: 0x00237438 File Offset: 0x00235638
	private void RefreshRewardScroll()
	{
		WheelTowerData data = WheelTowerModel.Instance.ActivityData;
		NewTowerClimbingLevelRecord levelRecord = data.GetLevelRecord(this.IsEndless);
		IReadOnlyList<NewTowerScoreReward> rewardConfigListByLevelId = WheelTowerConfig.Instance.GetRewardConfigListByLevelId(levelRecord.LevelId);
		if (rewardConfigListByLevelId == null)
		{
			return;
		}
		List<NewTowerScoreReward> list = new List<NewTowerScoreReward>(rewardConfigListByLevelId);
		list.Sort(delegate(NewTowerScoreReward a, NewTowerScoreReward b)
		{
			int num = base.<RefreshRewardScroll>g__GetPriority|0(a.Id);
			int num2 = base.<RefreshRewardScroll>g__GetPriority|0(b.Id);
			if (num == num2)
			{
				return a.Index - b.Index;
			}
			return num - num2;
		});
		List<int> list2 = new List<int>();
		foreach (NewTowerScoreReward newTowerScoreReward in list)
		{
			list2.Add(newTowerScoreReward.Id);
		}
		GenericScrollViewNew<WheelTowerLimitRewardItem, int> rewardScroll = this.RewardScroll;
		if (rewardScroll == null)
		{
			return;
		}
		rewardScroll.RefreshByData(list2, null, true);
	}

	// Token: 0x060072FC RID: 29436 RVA: 0x002374FC File Offset: 0x002356FC
	private void ToggleCallBack(int diff, UUIExtendToggle toggle)
	{
		if (this.CurrentTabToggle != null)
		{
			this.CurrentTabToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentTabToggle = toggle;
		this.CurrentTabToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		this.IsEndless = (diff == 1);
		this.RefreshRewardScroll();
	}

	// Token: 0x060072FD RID: 29437 RVA: 0x0023753B File Offset: 0x0023573B
	private WheelTowerLimitRewardItem CreateRewardItem()
	{
		WheelTowerLimitRewardItem wheelTowerLimitRewardItem = new WheelTowerLimitRewardItem();
		wheelTowerLimitRewardItem.SetOnClickReceiveCallback(new Action(this.ReceiveCallback));
		return wheelTowerLimitRewardItem;
	}

	// Token: 0x060072FE RID: 29438 RVA: 0x00237554 File Offset: 0x00235754
	private void ReceiveCallback()
	{
		WheelTowerController.Instance.RequestTaskReceive(this.IsEndless).ContinueWith(delegate()
		{
			WheelTowerLimitRewardTabItem normalTabItem = this.NormalTabItem;
			if (normalTabItem != null)
			{
				normalTabItem.Refresh(WheelTowerLimitRewardView.WheelTowerDiffList[0]);
			}
			WheelTowerLimitRewardTabItem endlessTabItem = this.EndlessTabItem;
			if (endlessTabItem != null)
			{
				endlessTabItem.Refresh(WheelTowerLimitRewardView.WheelTowerDiffList[1]);
			}
			this.RefreshRewardScroll();
		});
	}

	// Token: 0x060072FF RID: 29439 RVA: 0x00237578 File Offset: 0x00235778
	// Note: this type is marked as 'beforefieldinit'.
	unsafe static WheelTowerLimitRewardView()
	{
		int num = 2;
		List<int> list = new List<int>(num);
		CollectionsMarshal.SetCount<int>(list, num);
		Span<int> span = CollectionsMarshal.AsSpan<int>(list);
		int num2 = 0;
		*span[num2] = 0;
		num2++;
		*span[num2] = 1;
		WheelTowerLimitRewardView.WheelTowerDiffList = list;
	}

	// Token: 0x04004831 RID: 18481
	[StaticVariableRuleIgnore]
	private static readonly List<int> WheelTowerDiffList;

	// Token: 0x04004832 RID: 18482
	[Nullable(2)]
	private PopupCaptionItem Caption;

	// Token: 0x04004833 RID: 18483
	[Nullable(2)]
	private WheelTowerLimitRewardTabItem NormalTabItem;

	// Token: 0x04004834 RID: 18484
	[Nullable(2)]
	private WheelTowerLimitRewardTabItem EndlessTabItem;

	// Token: 0x04004835 RID: 18485
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<WheelTowerLimitRewardItem, int> RewardScroll;

	// Token: 0x04004836 RID: 18486
	[Nullable(2)]
	private UUIExtendToggle CurrentTabToggle;

	// Token: 0x04004837 RID: 18487
	private bool IsEndless;
}

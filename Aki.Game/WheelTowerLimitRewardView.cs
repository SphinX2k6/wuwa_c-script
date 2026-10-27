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

// Token: 0x02001617 RID: 5655
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerLimitRewardView : UiTickViewBase
{
	// Token: 0x06009F18 RID: 40728 RVA: 0x0022D3DA File Offset: 0x0022B5DA
	public WheelTowerLimitRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009F19 RID: 40729 RVA: 0x0022D3E4 File Offset: 0x0022B5E4
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

	// Token: 0x06009F1A RID: 40730 RVA: 0x0022D4F4 File Offset: 0x0022B6F4
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerLimitRewardView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerLimitRewardView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009F1B RID: 40731 RVA: 0x0022D538 File Offset: 0x0022B738
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

	// Token: 0x06009F1C RID: 40732 RVA: 0x0022D5AC File Offset: 0x0022B7AC
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

	// Token: 0x06009F1D RID: 40733 RVA: 0x0022D608 File Offset: 0x0022B808
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

	// Token: 0x06009F1E RID: 40734 RVA: 0x0022D6CC File Offset: 0x0022B8CC
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

	// Token: 0x06009F1F RID: 40735 RVA: 0x0022D70B File Offset: 0x0022B90B
	private WheelTowerLimitRewardItem CreateRewardItem()
	{
		WheelTowerLimitRewardItem wheelTowerLimitRewardItem = new WheelTowerLimitRewardItem();
		wheelTowerLimitRewardItem.SetOnClickReceiveCallback(new Action(this.ReceiveCallback));
		return wheelTowerLimitRewardItem;
	}

	// Token: 0x06009F20 RID: 40736 RVA: 0x0022D724 File Offset: 0x0022B924
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

	// Token: 0x06009F21 RID: 40737 RVA: 0x0022D748 File Offset: 0x0022B948
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

	// Token: 0x0400478B RID: 18315
	[StaticVariableRuleIgnore]
	private static readonly List<int> WheelTowerDiffList;

	// Token: 0x0400478C RID: 18316
	[Nullable(2)]
	private PopupCaptionItem Caption;

	// Token: 0x0400478D RID: 18317
	[Nullable(2)]
	private WheelTowerLimitRewardTabItem NormalTabItem;

	// Token: 0x0400478E RID: 18318
	[Nullable(2)]
	private WheelTowerLimitRewardTabItem EndlessTabItem;

	// Token: 0x0400478F RID: 18319
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<WheelTowerLimitRewardItem, int> RewardScroll;

	// Token: 0x04004790 RID: 18320
	[Nullable(2)]
	private UUIExtendToggle CurrentTabToggle;

	// Token: 0x04004791 RID: 18321
	private bool IsEndless;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000AEF RID: 2799
[NullableContext(1)]
[Nullable(0)]
public class ActivityWheelTowerRewardView : UiViewBase
{
	// Token: 0x060073B6 RID: 29622 RVA: 0x0023C137 File Offset: 0x0023A337
	public ActivityWheelTowerRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060073B7 RID: 29623 RVA: 0x0023C140 File Offset: 0x0023A340
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
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
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060073B8 RID: 29624 RVA: 0x0023C20C File Offset: 0x0023A40C
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityWheelTowerRewardView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityWheelTowerRewardView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060073B9 RID: 29625 RVA: 0x0023C250 File Offset: 0x0023A450
	protected override void OnStart()
	{
		GenericScrollViewNew<ActivityWheelTowerRewardView.RewardTabItem, int> tabScroll = this.TabScroll;
		if (tabScroll != null)
		{
			tabScroll.RefreshByData(ActivityWheelTowerRewardView.WheelTowerDiffList, delegate
			{
				ActivityWheelTowerRewardView.RewardTabItem scrollItemByIndex = this.TabScroll.GetScrollItemByIndex(0);
				if (scrollItemByIndex == null)
				{
					return;
				}
				scrollItemByIndex.SetToggleStateForce(true, true);
			}, true);
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

	// Token: 0x060073BA RID: 29626 RVA: 0x0023C29C File Offset: 0x0023A49C
	private void RefreshRewardScroll()
	{
		ActivityWheelTowerRewardView.<>c__DisplayClass9_0 CS$<>8__locals1 = new ActivityWheelTowerRewardView.<>c__DisplayClass9_0();
		CS$<>8__locals1.data = WheelTowerModel.Instance.ActivityData;
		NewTowerClimbingLevelRecord levelRecord = CS$<>8__locals1.data.GetLevelRecord(this.IsEndless);
		IReadOnlyList<NewTowerScoreReward> rewardConfigListByLevelId = WheelTowerConfig.Instance.GetRewardConfigListByLevelId(levelRecord.LevelId);
		if (rewardConfigListByLevelId == null)
		{
			GenericScrollViewNew<ActivityWheelTowerRewardView.RewardItem, int> rewardScroll = this.RewardScroll;
			if (rewardScroll == null)
			{
				return;
			}
			rewardScroll.RefreshByData(Array.Empty<int>(), null, false);
			return;
		}
		else
		{
			List<int> data = NoLinq.OrderByThenByToList<int, int, int>(NoLinq.SelectToList<NewTowerScoreReward, int>(rewardConfigListByLevelId, (NewTowerScoreReward config) => config.Id), new Func<int, int>(CS$<>8__locals1.<RefreshRewardScroll>g__GetPriority|0), (int id) => id);
			GenericScrollViewNew<ActivityWheelTowerRewardView.RewardItem, int> rewardScroll2 = this.RewardScroll;
			if (rewardScroll2 == null)
			{
				return;
			}
			rewardScroll2.RefreshByData(data, null, true);
			return;
		}
	}

	// Token: 0x060073BB RID: 29627 RVA: 0x0023C366 File Offset: 0x0023A566
	private ActivityWheelTowerRewardView.RewardTabItem CreateTabItem()
	{
		ActivityWheelTowerRewardView.RewardTabItem rewardTabItem = new ActivityWheelTowerRewardView.RewardTabItem();
		rewardTabItem.SetToggleClickCallback(new Action<int>(this.ToggleCallBack));
		return rewardTabItem;
	}

	// Token: 0x060073BC RID: 29628 RVA: 0x0023C37F File Offset: 0x0023A57F
	private void ToggleCallBack(int diff)
	{
		GenericScrollViewNew<ActivityWheelTowerRewardView.RewardTabItem, int> tabScroll = this.TabScroll;
		if (tabScroll != null)
		{
			tabScroll.SelectGridProxy(diff, false);
		}
		this.IsEndless = (diff == 1);
		this.RefreshRewardScroll();
	}

	// Token: 0x060073BD RID: 29629 RVA: 0x0023C3A4 File Offset: 0x0023A5A4
	private ActivityWheelTowerRewardView.RewardItem CreateRewardItem()
	{
		ActivityWheelTowerRewardView.RewardItem rewardItem = new ActivityWheelTowerRewardView.RewardItem();
		rewardItem.SetOnClickReceiveCallback(new Action(this.ReceiveCallback));
		return rewardItem;
	}

	// Token: 0x060073BE RID: 29630 RVA: 0x0023C3BD File Offset: 0x0023A5BD
	private void ReceiveCallback()
	{
		WheelTowerController.Instance.RequestTaskReceive(this.IsEndless).ContinueWith(delegate()
		{
			GenericScrollViewNew<ActivityWheelTowerRewardView.RewardTabItem, int> tabScroll = this.TabScroll;
			if (tabScroll != null)
			{
				GenericLayout<ActivityWheelTowerRewardView.RewardTabItem, int> genericLayout = tabScroll.GetGenericLayout();
				if (genericLayout != null)
				{
					genericLayout.RefreshWithoutDataSync();
				}
			}
			this.RefreshRewardScroll();
		});
	}

	// Token: 0x060073BF RID: 29631 RVA: 0x0023C3E4 File Offset: 0x0023A5E4
	// Note: this type is marked as 'beforefieldinit'.
	unsafe static ActivityWheelTowerRewardView()
	{
		int num = 2;
		List<int> list = new List<int>(num);
		CollectionsMarshal.SetCount<int>(list, num);
		Span<int> span = CollectionsMarshal.AsSpan<int>(list);
		int num2 = 0;
		*span[num2] = 0;
		num2++;
		*span[num2] = 1;
		ActivityWheelTowerRewardView.WheelTowerDiffList = list;
	}

	// Token: 0x04004944 RID: 18756
	[StaticVariableRuleIgnore]
	private static readonly List<int> WheelTowerDiffList;

	// Token: 0x04004945 RID: 18757
	[Nullable(2)]
	private PopupCaptionItem Caption;

	// Token: 0x04004946 RID: 18758
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<ActivityWheelTowerRewardView.RewardTabItem, int> TabScroll;

	// Token: 0x04004947 RID: 18759
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<ActivityWheelTowerRewardView.RewardItem, int> RewardScroll;

	// Token: 0x04004948 RID: 18760
	private bool IsEndless;

	// Token: 0x02006D87 RID: 28039
	[NullableContext(0)]
	private class RewardTabItem : GridProxyAbstract<int>
	{
		// Token: 0x0603FC37 RID: 261175 RVA: 0x012A9F00 File Offset: 0x012A8100
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FC38 RID: 261176 RVA: 0x012A9FE8 File Offset: 0x012A81E8
		protected override void OnStart()
		{
			UUIExtendToggle toggle = base.GetExtendToggle(0);
			toggle.CanExecuteChange.Bind(() => toggle.ToggleState != EToggleState.ETT_Checked);
			WheelTowerModel.Instance.ActivityData.RecordReadReward();
		}

		// Token: 0x0603FC39 RID: 261177 RVA: 0x012AA034 File Offset: 0x012A8234
		public override void Refresh(int diff, bool isSelected, int gridIndex)
		{
			this.Diff = diff;
			bool flag = diff == 1;
			string key = flag ? "WheelBattleMode_Endless" : "WheelBattleMode_Normal";
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.ShowTextNew(key);
			}
			WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
			EFilterMode filterMode = flag ? EFilterMode.Endless : EFilterMode.Normal;
			int totalRewardProgress = activityData.GetTotalRewardProgress(filterMode);
			int currentRewardProgress = activityData.GetCurrentRewardProgress(filterMode);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "WheelBattleMode_Progress", new <>z__ReadOnlyArray<object>(new object[]
			{
				currentRewardProgress,
				totalRewardProgress
			}));
			bool uiactive = activityData.HasAnyRewardCanReceive(filterMode);
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x0603FC3A RID: 261178 RVA: 0x012AA0E6 File Offset: 0x012A82E6
		[NullableContext(1)]
		public void SetToggleClickCallback(Action<int> callback)
		{
			this.ToggleClickCallback = callback;
		}

		// Token: 0x0603FC3B RID: 261179 RVA: 0x012AA0EF File Offset: 0x012A82EF
		public void SetToggleStateForce(bool isSelected, bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x0603FC3C RID: 261180 RVA: 0x012AA10C File Offset: 0x012A830C
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleStateForce(false, false);
		}

		// Token: 0x0603FC3D RID: 261181 RVA: 0x012AA116 File Offset: 0x012A8316
		private void OnClickToggle(EToggleState state)
		{
			Action<int> toggleClickCallback = this.ToggleClickCallback;
			if (toggleClickCallback == null)
			{
				return;
			}
			toggleClickCallback(this.Diff);
		}

		// Token: 0x04023EC1 RID: 147137
		private int Diff = -1;

		// Token: 0x04023EC2 RID: 147138
		[Nullable(2)]
		private Action<int> ToggleClickCallback;
	}

	// Token: 0x02006D88 RID: 28040
	[NullableContext(0)]
	private class RewardItem : GridProxyAbstract<int>
	{
		// Token: 0x0603FC3F RID: 261183 RVA: 0x012AA140 File Offset: 0x012A8340
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickReceive));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FC40 RID: 261184 RVA: 0x012AA28B File Offset: 0x012A848B
		protected override void OnStart()
		{
			this.RewardLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(2), () => new CommonItemSmallItemGrid(), null, false, true);
		}

		// Token: 0x0603FC41 RID: 261185 RVA: 0x012AA2C4 File Offset: 0x012A84C4
		public override void Refresh(int rewardId, bool isSelected, int gridIndex)
		{
			NewTowerScoreReward? rewardConfigById = WheelTowerConfig.Instance.GetRewardConfigById(rewardId);
			if (rewardConfigById == null)
			{
				return;
			}
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.ShowTextNew(rewardConfigById.Value.Desc);
			}
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(rewardConfigById.Value.DropId);
			GenericLayout<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
			if (rewardLayout != null)
			{
				rewardLayout.RefreshByData(dropPackagePreviewItemList, null, false);
			}
			WheelTowerData activityData = WheelTowerModel.Instance.ActivityData;
			bool flag = activityData.IsRewardCanReceive(rewardId);
			bool flag2 = activityData.IsRewardCompleted(rewardId);
			UUIButtonComponent button = base.GetButton(4);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(flag);
			}
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(flag2);
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!flag && !flag2);
		}

		// Token: 0x0603FC42 RID: 261186 RVA: 0x012AA3A0 File Offset: 0x012A85A0
		[NullableContext(1)]
		public void SetOnClickReceiveCallback(Action callback)
		{
			this.OnClickReceiveCallback = callback;
		}

		// Token: 0x0603FC43 RID: 261187 RVA: 0x012AA3A9 File Offset: 0x012A85A9
		private void OnClickReceive()
		{
			Action onClickReceiveCallback = this.OnClickReceiveCallback;
			if (onClickReceiveCallback == null)
			{
				return;
			}
			onClickReceiveCallback();
		}

		// Token: 0x04023EC3 RID: 147139
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x04023EC4 RID: 147140
		[Nullable(2)]
		private Action OnClickReceiveCallback;
	}
}

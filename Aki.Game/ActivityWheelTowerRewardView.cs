using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02001637 RID: 5687
[NullableContext(1)]
[Nullable(0)]
public class ActivityWheelTowerRewardView : UiViewBase
{
	// Token: 0x06009FD8 RID: 40920 RVA: 0x002322EB File Offset: 0x002304EB
	public ActivityWheelTowerRewardView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009FD9 RID: 40921 RVA: 0x002322F4 File Offset: 0x002304F4
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

	// Token: 0x06009FDA RID: 40922 RVA: 0x002323C0 File Offset: 0x002305C0
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityWheelTowerRewardView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityWheelTowerRewardView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009FDB RID: 40923 RVA: 0x00232404 File Offset: 0x00230604
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

	// Token: 0x06009FDC RID: 40924 RVA: 0x00232450 File Offset: 0x00230650
	private void RefreshRewardScroll()
	{
		WheelTowerData data = WheelTowerModel.Instance.ActivityData;
		NewTowerClimbingLevelRecord levelRecord = data.GetLevelRecord(this.IsEndless);
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
			List<int> data2 = (from config in rewardConfigListByLevelId
			orderby base.<RefreshRewardScroll>g__GetPriority|0(config.Id), config.Id
			select config.Id).ToList<int>();
			GenericScrollViewNew<ActivityWheelTowerRewardView.RewardItem, int> rewardScroll2 = this.RewardScroll;
			if (rewardScroll2 == null)
			{
				return;
			}
			rewardScroll2.RefreshByData(data2, null, true);
			return;
		}
	}

	// Token: 0x06009FDD RID: 40925 RVA: 0x00232524 File Offset: 0x00230724
	private ActivityWheelTowerRewardView.RewardTabItem CreateTabItem()
	{
		ActivityWheelTowerRewardView.RewardTabItem rewardTabItem = new ActivityWheelTowerRewardView.RewardTabItem();
		rewardTabItem.SetToggleClickCallback(new Action<int>(this.ToggleCallBack));
		return rewardTabItem;
	}

	// Token: 0x06009FDE RID: 40926 RVA: 0x0023253D File Offset: 0x0023073D
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

	// Token: 0x06009FDF RID: 40927 RVA: 0x00232562 File Offset: 0x00230762
	private ActivityWheelTowerRewardView.RewardItem CreateRewardItem()
	{
		ActivityWheelTowerRewardView.RewardItem rewardItem = new ActivityWheelTowerRewardView.RewardItem();
		rewardItem.SetOnClickReceiveCallback(new Action(this.ReceiveCallback));
		return rewardItem;
	}

	// Token: 0x06009FE0 RID: 40928 RVA: 0x0023257B File Offset: 0x0023077B
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

	// Token: 0x06009FE1 RID: 40929 RVA: 0x002325A0 File Offset: 0x002307A0
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

	// Token: 0x0400489E RID: 18590
	[StaticVariableRuleIgnore]
	private static readonly List<int> WheelTowerDiffList;

	// Token: 0x0400489F RID: 18591
	[Nullable(2)]
	private PopupCaptionItem Caption;

	// Token: 0x040048A0 RID: 18592
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<ActivityWheelTowerRewardView.RewardTabItem, int> TabScroll;

	// Token: 0x040048A1 RID: 18593
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<ActivityWheelTowerRewardView.RewardItem, int> RewardScroll;

	// Token: 0x040048A2 RID: 18594
	private bool IsEndless;

	// Token: 0x02007BFF RID: 31743
	[NullableContext(0)]
	private class RewardTabItem : GridProxyAbstract<int>
	{
		// Token: 0x0604981B RID: 301083 RVA: 0x01306C58 File Offset: 0x01304E58
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

		// Token: 0x0604981C RID: 301084 RVA: 0x01306D40 File Offset: 0x01304F40
		protected override void OnStart()
		{
			UUIExtendToggle toggle = base.GetExtendToggle(0);
			toggle.CanExecuteChange.Bind(() => toggle.ToggleState != EToggleState.ETT_Checked);
			WheelTowerModel.Instance.ActivityData.RecordReadReward();
		}

		// Token: 0x0604981D RID: 301085 RVA: 0x01306D8C File Offset: 0x01304F8C
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

		// Token: 0x0604981E RID: 301086 RVA: 0x01306E3E File Offset: 0x0130503E
		[NullableContext(1)]
		public void SetToggleClickCallback(Action<int> callback)
		{
			this.ToggleClickCallback = callback;
		}

		// Token: 0x0604981F RID: 301087 RVA: 0x01306E47 File Offset: 0x01305047
		public void SetToggleStateForce(bool isSelected, bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x06049820 RID: 301088 RVA: 0x01306E64 File Offset: 0x01305064
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleStateForce(false, false);
		}

		// Token: 0x06049821 RID: 301089 RVA: 0x01306E6E File Offset: 0x0130506E
		private void OnClickToggle(EToggleState state)
		{
			Action<int> toggleClickCallback = this.ToggleClickCallback;
			if (toggleClickCallback == null)
			{
				return;
			}
			toggleClickCallback(this.Diff);
		}

		// Token: 0x04028B8E RID: 166798
		private int Diff = -1;

		// Token: 0x04028B8F RID: 166799
		[Nullable(2)]
		private Action<int> ToggleClickCallback;
	}

	// Token: 0x02007C00 RID: 31744
	[NullableContext(0)]
	private class RewardItem : GridProxyAbstract<int>
	{
		// Token: 0x06049823 RID: 301091 RVA: 0x01306E98 File Offset: 0x01305098
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

		// Token: 0x06049824 RID: 301092 RVA: 0x01306FE3 File Offset: 0x013051E3
		protected override void OnStart()
		{
			this.RewardLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(2), () => new CommonItemSmallItemGrid(), null, false, true);
		}

		// Token: 0x06049825 RID: 301093 RVA: 0x0130701C File Offset: 0x0130521C
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

		// Token: 0x06049826 RID: 301094 RVA: 0x013070F8 File Offset: 0x013052F8
		[NullableContext(1)]
		public void SetOnClickReceiveCallback(Action callback)
		{
			this.OnClickReceiveCallback = callback;
		}

		// Token: 0x06049827 RID: 301095 RVA: 0x01307101 File Offset: 0x01305301
		private void OnClickReceive()
		{
			Action onClickReceiveCallback = this.OnClickReceiveCallback;
			if (onClickReceiveCallback == null)
			{
				return;
			}
			onClickReceiveCallback();
		}

		// Token: 0x04028B90 RID: 166800
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x04028B91 RID: 166801
		[Nullable(2)]
		private Action OnClickReceiveCallback;
	}
}

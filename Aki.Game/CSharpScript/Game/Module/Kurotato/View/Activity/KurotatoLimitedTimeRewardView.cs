using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Module.UiNavigation.UIComponent;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Activity
{
	// Token: 0x0200475F RID: 18271
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoLimitedTimeRewardView : UiTickViewBase
	{
		// Token: 0x0602DDC0 RID: 187840 RVA: 0x00CD5FCD File Offset: 0x00CD41CD
		public KurotatoLimitedTimeRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602DDC1 RID: 187841 RVA: 0x00CD5FF4 File Offset: 0x00CD41F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickDetail));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602DDC2 RID: 187842 RVA: 0x00CD61A4 File Offset: 0x00CD43A4
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnRefreshKurotatoLimitRewardData, new Action(this.RefreshView));
		}

		// Token: 0x0602DDC3 RID: 187843 RVA: 0x00CD61C2 File Offset: 0x00CD43C2
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnRefreshKurotatoLimitRewardData, new Action(this.RefreshView));
		}

		// Token: 0x0602DDC4 RID: 187844 RVA: 0x00CD61E0 File Offset: 0x00CD43E0
		protected override void OnStart()
		{
			this.InitQuestScroll();
			this.InitTabLayout();
			KurotatoLimitedTimeRewardBottomItem bottomItem = this.BottomItem;
			if (bottomItem != null)
			{
				bottomItem.Refresh();
			}
			this.TimeTextItem = base.GetText(7);
			this.FormatTimeText = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
			BackgroundCard? config = ConfigBackgroundCardById.GetConfig(KurotatoModel.Instance.GetActivityConfig().Value.PersonalCardId, true);
			if (config == null)
			{
				return;
			}
			UUIText text = base.GetText(8);
			if (text != null)
			{
				text.ShowTextNew(config.Value.Title);
			}
			UUIText text2 = base.GetText(9);
			if (text2 == null)
			{
				return;
			}
			text2.ShowTextNew(config.Value.AttributesDescription);
		}

		// Token: 0x0602DDC5 RID: 187845 RVA: 0x00CD6298 File Offset: 0x00CD4498
		private void InitTabLayout()
		{
			this.TabLayout = new GenericLayout<TabItem, KurotatoRewardTab>(base.GetHorizontalLayout(3), new Func<TabItem>(this.CreateTabItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
			IReadOnlyList<KurotatoRewardTab> allRewardTabConfig = KurotatoConfig.Instance.GetAllRewardTabConfig();
			this.TabLayout.RefreshByData(allRewardTabConfig, delegate
			{
				GenericLayout<TabItem, KurotatoRewardTab> tabLayout = this.TabLayout;
				if (tabLayout == null)
				{
					return;
				}
				TabItem layoutItemByIndex = tabLayout.GetLayoutItemByIndex(0);
				if (layoutItemByIndex == null)
				{
					return;
				}
				layoutItemByIndex.SetToggleSelect(true, true);
			}, false);
		}

		// Token: 0x0602DDC6 RID: 187846 RVA: 0x00CD62FA File Offset: 0x00CD44FA
		private TabItem CreateTabItem()
		{
			TabItem tabItem = new TabItem();
			tabItem.SetTabClickCallback(new Action<int>(this.OnClickTab));
			return tabItem;
		}

		// Token: 0x0602DDC7 RID: 187847 RVA: 0x00CD6313 File Offset: 0x00CD4513
		private void OnClickTab(int tabIndex)
		{
			this.SelectedTabIndex = tabIndex;
			GenericLayout<TabItem, KurotatoRewardTab> tabLayout = this.TabLayout;
			if (tabLayout != null)
			{
				tabLayout.SelectGridProxy(tabIndex, false);
			}
			this.RefreshQuestScroll();
			GenericScrollViewNew<KurotatoRewardItem, KurotatoRewardItemData> questScroll = this.QuestScroll;
			if (questScroll == null)
			{
				return;
			}
			questScroll.ScrollToTopByIndex(0);
		}

		// Token: 0x0602DDC8 RID: 187848 RVA: 0x00CD6346 File Offset: 0x00CD4546
		private void InitQuestScroll()
		{
			this.QuestScroll = new GenericScrollViewNew<KurotatoRewardItem, KurotatoRewardItemData>(base.GetScrollViewWithScrollbar(1), new Func<KurotatoRewardItem>(this.CreateQuestItem), null, false, null);
		}

		// Token: 0x0602DDC9 RID: 187849 RVA: 0x00CD636C File Offset: 0x00CD456C
		private void RefreshQuestScroll()
		{
			List<KurotatoLimitedTimeRewardItemData> limitedTimeTaskListByTabId = KurotatoActivityController.Instance.GetActivityData().GetLimitedTimeTaskListByTabId(this.SelectedTabIndex);
			limitedTimeTaskListByTabId.Sort((KurotatoLimitedTimeRewardItemData a, KurotatoLimitedTimeRewardItemData b) => Array.IndexOf<EKurotatoRewardStatus>(this.StatusOrder, a.Status) - Array.IndexOf<EKurotatoRewardStatus>(this.StatusOrder, b.Status));
			GenericScrollViewNew<KurotatoRewardItem, KurotatoRewardItemData> questScroll = this.QuestScroll;
			if (questScroll == null)
			{
				return;
			}
			questScroll.RefreshByData(limitedTimeTaskListByTabId, null, true);
		}

		// Token: 0x0602DDCA RID: 187850 RVA: 0x00CD63B4 File Offset: 0x00CD45B4
		private KurotatoRewardItem CreateQuestItem()
		{
			KurotatoRewardItem kurotatoRewardItem = new KurotatoRewardItem();
			kurotatoRewardItem.SetReceiveClickCallback(new Action(this.OnClickTaskReceive));
			return kurotatoRewardItem;
		}

		// Token: 0x0602DDCB RID: 187851 RVA: 0x00CD63D0 File Offset: 0x00CD45D0
		protected override void OnTick(float delta)
		{
			KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
			if (activityData == null)
			{
				base.CloseMe(null);
				return;
			}
			if (!activityData.CheckIfInLimitTime())
			{
				base.CloseMe(null);
				return;
			}
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(activityData.EndRewardTime, this.FormatTimeText);
			UUIText timeTextItem = this.TimeTextItem;
			if (timeTextItem == null)
			{
				return;
			}
			timeTextItem.SetText(remainTimeText, true);
		}

		// Token: 0x0602DDCC RID: 187852 RVA: 0x00CD642C File Offset: 0x00CD462C
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoLimitedTimeRewardView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoLimitedTimeRewardView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DDCD RID: 187853 RVA: 0x00CD646F File Offset: 0x00CD466F
		protected override void OnBeforeShow()
		{
			HotKeyComponentUtil.SetupComponents<RewardTakeComponent>(this.RootItem, EHotKeyCacheKey.RewardTakeDataCallback, delegate(RewardTakeComponent component)
			{
				component.SetDataCallback(() => KurotatoActivityController.Instance.GetActivityData().GetLastNotTakenScoreRewardIndex());
			});
			this.RefreshView();
		}

		// Token: 0x0602DDCE RID: 187854 RVA: 0x00CD64A2 File Offset: 0x00CD46A2
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602DDCF RID: 187855 RVA: 0x00CD64AB File Offset: 0x00CD46AB
		private void RefreshView()
		{
			KurotatoLimitedTimeRewardBottomItem bottomItem = this.BottomItem;
			if (bottomItem != null)
			{
				bottomItem.Refresh();
			}
			this.RefreshQuestScroll();
		}

		// Token: 0x0602DDD0 RID: 187856 RVA: 0x00CD64C4 File Offset: 0x00CD46C4
		private void OnClickDetail()
		{
			KurotatoActivityConfig? activityConfig = KurotatoModel.Instance.GetActivityConfig();
			if (activityConfig == null)
			{
				return;
			}
			int personalCardId = activityConfig.Value.PersonalCardId;
			if (personalCardId <= 0)
			{
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(personalCardId, true, null, false);
		}

		// Token: 0x0602DDD1 RID: 187857 RVA: 0x00CD650C File Offset: 0x00CD470C
		private void OnClickTaskReceive()
		{
			List<int> limitedTimeTaskCanClaimableIdListByTabId = KurotatoActivityController.Instance.GetActivityData().GetLimitedTimeTaskCanClaimableIdListByTabId(this.SelectedTabIndex);
			if (limitedTimeTaskCanClaimableIdListByTabId.Count <= 0)
			{
				return;
			}
			KurotatoActivityController.Instance.RequestLimitTimeReward(limitedTimeTaskCanClaimableIdListByTabId, new Action(this.RefreshView));
		}

		// Token: 0x04018800 RID: 100352
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04018801 RID: 100353
		[Nullable(2)]
		private KurotatoLimitedTimeRewardBottomItem BottomItem;

		// Token: 0x04018802 RID: 100354
		[Nullable(2)]
		private UUIText TimeTextItem;

		// Token: 0x04018803 RID: 100355
		[Nullable(2)]
		private string FormatTimeText;

		// Token: 0x04018804 RID: 100356
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<KurotatoRewardItem, KurotatoRewardItemData> QuestScroll;

		// Token: 0x04018805 RID: 100357
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<TabItem, KurotatoRewardTab> TabLayout;

		// Token: 0x04018806 RID: 100358
		private int SelectedTabIndex = -1;

		// Token: 0x04018807 RID: 100359
		private readonly EKurotatoRewardStatus[] StatusOrder = new EKurotatoRewardStatus[]
		{
			EKurotatoRewardStatus.CanReceive,
			EKurotatoRewardStatus.Doing,
			EKurotatoRewardStatus.Taken
		};

		// Token: 0x0200A3C2 RID: 41922
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04032C26 RID: 207910
			Caption,
			// Token: 0x04032C27 RID: 207911
			QuestScroll,
			// Token: 0x04032C28 RID: 207912
			QuestItem,
			// Token: 0x04032C29 RID: 207913
			TabLayout,
			// Token: 0x04032C2A RID: 207914
			TabItem,
			// Token: 0x04032C2B RID: 207915
			PanelBottom,
			// Token: 0x04032C2C RID: 207916
			DetailButton,
			// Token: 0x04032C2D RID: 207917
			TextDelayTime,
			// Token: 0x04032C2E RID: 207918
			DetailName,
			// Token: 0x04032C2F RID: 207919
			DetailDesc
		}
	}
}

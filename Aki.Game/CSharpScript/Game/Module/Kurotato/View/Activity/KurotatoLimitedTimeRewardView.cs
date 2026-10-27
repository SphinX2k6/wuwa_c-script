using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005788 RID: 22408
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoLimitedTimeRewardView : UiTickViewBase
	{
		// Token: 0x06038EB0 RID: 233136 RVA: 0x00D87274 File Offset: 0x00D85474
		public KurotatoLimitedTimeRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038EB1 RID: 233137 RVA: 0x00D87298 File Offset: 0x00D85498
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

		// Token: 0x06038EB2 RID: 233138 RVA: 0x00D87448 File Offset: 0x00D85648
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnRefreshKurotatoLimitRewardData, new Action(this.RefreshView));
		}

		// Token: 0x06038EB3 RID: 233139 RVA: 0x00D87466 File Offset: 0x00D85666
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnRefreshKurotatoLimitRewardData, new Action(this.RefreshView));
		}

		// Token: 0x06038EB4 RID: 233140 RVA: 0x00D87484 File Offset: 0x00D85684
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

		// Token: 0x06038EB5 RID: 233141 RVA: 0x00D8753C File Offset: 0x00D8573C
		private void InitTabLayout()
		{
			this.TabLayout = new GenericLayout<TabItem, KurotatoRewardTab>(base.GetHorizontalLayout(3), new Func<TabItem>(this.CreateTabItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
			List<KurotatoRewardTab> data = KurotatoConfig.Instance.GetAllRewardTabConfig().ToList<KurotatoRewardTab>();
			this.TabLayout.RefreshByData(data, delegate
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

		// Token: 0x06038EB6 RID: 233142 RVA: 0x00D875A3 File Offset: 0x00D857A3
		private TabItem CreateTabItem()
		{
			TabItem tabItem = new TabItem();
			tabItem.SetTabClickCallback(new Action<int>(this.OnClickTab));
			return tabItem;
		}

		// Token: 0x06038EB7 RID: 233143 RVA: 0x00D875BC File Offset: 0x00D857BC
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

		// Token: 0x06038EB8 RID: 233144 RVA: 0x00D875EF File Offset: 0x00D857EF
		private void InitQuestScroll()
		{
			this.QuestScroll = new GenericScrollViewNew<KurotatoRewardItem, KurotatoRewardItemData>(base.GetScrollViewWithScrollbar(1), new Func<KurotatoRewardItem>(this.CreateQuestItem), null, false, null);
		}

		// Token: 0x06038EB9 RID: 233145 RVA: 0x00D87614 File Offset: 0x00D85814
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

		// Token: 0x06038EBA RID: 233146 RVA: 0x00D8765C File Offset: 0x00D8585C
		private KurotatoRewardItem CreateQuestItem()
		{
			KurotatoRewardItem kurotatoRewardItem = new KurotatoRewardItem();
			kurotatoRewardItem.SetReceiveClickCallback(new Action(this.OnClickTaskReceive));
			return kurotatoRewardItem;
		}

		// Token: 0x06038EBB RID: 233147 RVA: 0x00D87678 File Offset: 0x00D85878
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

		// Token: 0x06038EBC RID: 233148 RVA: 0x00D876D4 File Offset: 0x00D858D4
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoLimitedTimeRewardView.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoLimitedTimeRewardView.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038EBD RID: 233149 RVA: 0x00D87717 File Offset: 0x00D85917
		protected override void OnBeforeShow()
		{
			HotKeyComponentUtil.SetupComponents<RewardTakeComponent>(this.RootItem, EHotKeyCacheKey.RewardTakeDataCallback, () => KurotatoActivityController.Instance.GetActivityData().GetLastNotTakenScoreRewardIndex());
			this.RefreshView();
		}

		// Token: 0x06038EBE RID: 233150 RVA: 0x00D8774A File Offset: 0x00D8594A
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06038EBF RID: 233151 RVA: 0x00D87753 File Offset: 0x00D85953
		private void RefreshView()
		{
			KurotatoLimitedTimeRewardBottomItem bottomItem = this.BottomItem;
			if (bottomItem != null)
			{
				bottomItem.Refresh();
			}
			this.RefreshQuestScroll();
		}

		// Token: 0x06038EC0 RID: 233152 RVA: 0x00D8776C File Offset: 0x00D8596C
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
			ItemController.Instance.OpenItemTipsByItemId(personalCardId, true, null);
		}

		// Token: 0x06038EC1 RID: 233153 RVA: 0x00D877B0 File Offset: 0x00D859B0
		private void OnClickTaskReceive()
		{
			List<int> limitedTimeTaskCanClaimableIdListByTabId = KurotatoActivityController.Instance.GetActivityData().GetLimitedTimeTaskCanClaimableIdListByTabId(this.SelectedTabIndex);
			if (limitedTimeTaskCanClaimableIdListByTabId.Count <= 0)
			{
				return;
			}
			KurotatoActivityController.Instance.RequestLimitTimeReward(limitedTimeTaskCanClaimableIdListByTabId, new Action(this.RefreshView));
		}

		// Token: 0x0401DD6A RID: 122218
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401DD6B RID: 122219
		[Nullable(2)]
		private KurotatoLimitedTimeRewardBottomItem BottomItem;

		// Token: 0x0401DD6C RID: 122220
		[Nullable(2)]
		private UUIText TimeTextItem;

		// Token: 0x0401DD6D RID: 122221
		[Nullable(2)]
		private string FormatTimeText;

		// Token: 0x0401DD6E RID: 122222
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<KurotatoRewardItem, KurotatoRewardItemData> QuestScroll;

		// Token: 0x0401DD6F RID: 122223
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<TabItem, KurotatoRewardTab> TabLayout;

		// Token: 0x0401DD70 RID: 122224
		private int SelectedTabIndex = -1;

		// Token: 0x0401DD71 RID: 122225
		private readonly EKurotatoRewardStatus[] StatusOrder = new EKurotatoRewardStatus[]
		{
			EKurotatoRewardStatus.CanReceive,
			EKurotatoRewardStatus.Doing,
			EKurotatoRewardStatus.Taken
		};

		// Token: 0x0200B9AC RID: 47532
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04038236 RID: 229942
			Caption,
			// Token: 0x04038237 RID: 229943
			QuestScroll,
			// Token: 0x04038238 RID: 229944
			QuestItem,
			// Token: 0x04038239 RID: 229945
			TabLayout,
			// Token: 0x0403823A RID: 229946
			TabItem,
			// Token: 0x0403823B RID: 229947
			PanelBottom,
			// Token: 0x0403823C RID: 229948
			DetailButton,
			// Token: 0x0403823D RID: 229949
			TextDelayTime,
			// Token: 0x0403823E RID: 229950
			DetailName,
			// Token: 0x0403823F RID: 229951
			DetailDesc
		}
	}
}

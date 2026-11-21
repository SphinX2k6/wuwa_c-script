using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x0200580D RID: 22541
	[NullableContext(1)]
	[Nullable(0)]
	public class CyberPunkTaskView : UiViewBase
	{
		// Token: 0x060379D9 RID: 227801 RVA: 0x00F8BA4D File Offset: 0x00F89C4D
		public CyberPunkTaskView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060379DA RID: 227802 RVA: 0x00F8BA64 File Offset: 0x00F89C64
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickLook));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060379DB RID: 227803 RVA: 0x00F8BBD0 File Offset: 0x00F89DD0
		protected override UniTask OnBeforeStartAsync()
		{
			CyberPunkTaskView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CyberPunkTaskView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060379DC RID: 227804 RVA: 0x00F8BC14 File Offset: 0x00F89E14
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnCyberPunkTaskRefresh, new Action(this.OnCyberPunkTaskRefresh));
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
			ActivityController.Instance.RegisterRefreshTimerDelegate(new Action<float>(this.OnTimerRefresh));
		}

		// Token: 0x060379DD RID: 227805 RVA: 0x00F8BC70 File Offset: 0x00F89E70
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnCyberPunkTaskRefresh, new Action(this.OnCyberPunkTaskRefresh));
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
			ActivityController.Instance.UnregisterRefreshTimerDelegate(new Action<float>(this.OnTimerRefresh));
		}

		// Token: 0x060379DE RID: 227806 RVA: 0x00F8BCCB File Offset: 0x00F89ECB
		private void OnTimerRefresh(float delta)
		{
			this.RefreshTimerText();
		}

		// Token: 0x060379DF RID: 227807 RVA: 0x00F8BCD3 File Offset: 0x00F89ED3
		protected override void OnBeforeShow()
		{
			if (this.TabDataList.Count > 0)
			{
				this.RefreshView();
			}
		}

		// Token: 0x060379E0 RID: 227808 RVA: 0x00F8BCEC File Offset: 0x00F89EEC
		private void OnCyberPunkTaskRefresh()
		{
			if (this.TabDataList.Count == 0)
			{
				this.InitTabData();
				if (this.TabDataList.Count == 0)
				{
					return;
				}
				this.RefreshView();
			}
			else
			{
				this.RefreshTaskList(this.TabDataList[this.SelectedTabIndex], false);
			}
			this.RefreshSliderItem();
		}

		// Token: 0x060379E1 RID: 227809 RVA: 0x00F8BD40 File Offset: 0x00F89F40
		private void OnRefreshRedDot(int activityId)
		{
			CyberPunkData currentActivityData = CyberPunkController.Instance.GetCurrentActivityData();
			if (currentActivityData != null && currentActivityData.Id == activityId)
			{
				this.RefreshSliderItem();
			}
		}

		// Token: 0x060379E2 RID: 227810 RVA: 0x00F8BD6C File Offset: 0x00F89F6C
		private void OnClickTabItem(int tabId, CyberPunkTaskTabItem tabItem)
		{
			CyberPunkTaskTabItem selectTabItem = this.SelectTabItem;
			if (selectTabItem != null)
			{
				selectTabItem.SetSelected(false, false);
			}
			this.SelectTabItem = tabItem;
			this.SelectTabItem.SetSelected(true, false);
			CyberPunkTaskTabData cyberPunkTaskTabData = this.TabDataList.Find((CyberPunkTaskTabData t) => t.TabId == tabId);
			if (cyberPunkTaskTabData == null)
			{
				return;
			}
			int num = this.TabDataList.IndexOf(cyberPunkTaskTabData);
			if (this.SelectedTabIndex == num)
			{
				return;
			}
			this.SelectedTabIndex = num;
			this.RefreshTaskList(cyberPunkTaskTabData, true);
		}

		// Token: 0x060379E3 RID: 227811 RVA: 0x00F8BDEF File Offset: 0x00F89FEF
		private void OnClaimSliderReward(int scoreId)
		{
			CyberPunkController.Instance.RequestScoreReward(scoreId, null);
		}

		// Token: 0x060379E4 RID: 227812 RVA: 0x00F8BDFD File Offset: 0x00F89FFD
		private void OnClickBack()
		{
			UiManager.Instance.CloseView(EUiViewName.CyberPunkTaskView, null);
		}

		// Token: 0x060379E5 RID: 227813 RVA: 0x00F8BE10 File Offset: 0x00F8A010
		private void OnClickLook()
		{
			if (this.SliderItem == null)
			{
				return;
			}
			int currentItemId = this.SliderItem.GetCurrentItemId();
			if (currentItemId > 0)
			{
				ItemController.Instance.OpenItemTipsByItemId(currentItemId, true, null, false);
			}
		}

		// Token: 0x060379E6 RID: 227814 RVA: 0x00F8BE44 File Offset: 0x00F8A044
		private UniTask InitTopItem()
		{
			CyberPunkTaskView.<InitTopItem>d__22 <InitTopItem>d__;
			<InitTopItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTopItem>d__.<>4__this = this;
			<InitTopItem>d__.<>1__state = -1;
			<InitTopItem>d__.<>t__builder.Start<CyberPunkTaskView.<InitTopItem>d__22>(ref <InitTopItem>d__);
			return <InitTopItem>d__.<>t__builder.Task;
		}

		// Token: 0x060379E7 RID: 227815 RVA: 0x00F8BE88 File Offset: 0x00F8A088
		private void InitTabLayout()
		{
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(1);
			this.TabLayout = new GenericLayout<CyberPunkTaskTabItem, CyberPunkTaskTabData>(verticalLayout, new Func<CyberPunkTaskTabItem>(this.OnCreateTabItem), null, false, true);
		}

		// Token: 0x060379E8 RID: 227816 RVA: 0x00F8BEB8 File Offset: 0x00F8A0B8
		private void InitTaskScroll()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
			this.TaskScroll = new GenericScrollViewNew<CyberPunkTaskScrollItem, CyberPunkTaskData>(scrollViewWithScrollbar, new Func<CyberPunkTaskScrollItem>(this.OnCreateTaskItem), null, false, null);
			AUIBaseActor content = scrollViewWithScrollbar.GetContent();
			this.TaskScrollAnimController = (((content != null) ? content.GetComponentByClass(UUIInturnAnimController.StaticClass()) : null) as UUIInturnAnimController);
		}

		// Token: 0x060379E9 RID: 227817 RVA: 0x00F8BF10 File Offset: 0x00F8A110
		private UniTask InitSliderItem()
		{
			CyberPunkTaskView.<InitSliderItem>d__25 <InitSliderItem>d__;
			<InitSliderItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSliderItem>d__.<>4__this = this;
			<InitSliderItem>d__.<>1__state = -1;
			<InitSliderItem>d__.<>t__builder.Start<CyberPunkTaskView.<InitSliderItem>d__25>(ref <InitSliderItem>d__);
			return <InitSliderItem>d__.<>t__builder.Task;
		}

		// Token: 0x060379EA RID: 227818 RVA: 0x00F8BF53 File Offset: 0x00F8A153
		private CyberPunkTaskTabItem OnCreateTabItem()
		{
			return new CyberPunkTaskTabItem
			{
				OnTabClickCallback = new Action<int, CyberPunkTaskTabItem>(this.OnClickTabItem)
			};
		}

		// Token: 0x060379EB RID: 227819 RVA: 0x00F8BF6C File Offset: 0x00F8A16C
		private CyberPunkTaskScrollItem OnCreateTaskItem()
		{
			return new CyberPunkTaskScrollItem();
		}

		// Token: 0x060379EC RID: 227820 RVA: 0x00F8BF74 File Offset: 0x00F8A174
		private void InitTabData()
		{
			CyberPunkData currentActivityData = CyberPunkController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			this.TabDataList = currentActivityData.GetCyberPunkTaskTabDataList();
		}

		// Token: 0x060379ED RID: 227821 RVA: 0x00F8BF9C File Offset: 0x00F8A19C
		private void RefreshView()
		{
			if (this.TabDataList.Count == 0)
			{
				return;
			}
			GenericLayout<CyberPunkTaskTabItem, CyberPunkTaskTabData> tabLayout = this.TabLayout;
			if (tabLayout != null)
			{
				tabLayout.RefreshByData(this.TabDataList, delegate
				{
					this.InitializeSelectedTab();
				}, false);
			}
			this.RefreshTimerText();
		}

		// Token: 0x060379EE RID: 227822 RVA: 0x00F8BFD8 File Offset: 0x00F8A1D8
		private void InitializeSelectedTab()
		{
			if (this.TabDataList.Count == 0)
			{
				return;
			}
			int num = this.SelectedTabIndex;
			if (num < 0 || num >= this.TabDataList.Count)
			{
				num = 0;
			}
			CyberPunkTaskTabData tabData = this.TabDataList[num];
			GenericLayout<CyberPunkTaskTabItem, CyberPunkTaskTabData> tabLayout = this.TabLayout;
			CyberPunkTaskTabItem cyberPunkTaskTabItem = (tabLayout != null) ? tabLayout.GetLayoutItemByIndex(num) : null;
			if (cyberPunkTaskTabItem == null)
			{
				return;
			}
			for (int i = 0; i < this.TabDataList.Count; i++)
			{
				CyberPunkTaskTabData cyberPunkTaskTabData = this.TabDataList[i];
				GenericLayout<CyberPunkTaskTabItem, CyberPunkTaskTabData> tabLayout2 = this.TabLayout;
				CyberPunkTaskTabItem cyberPunkTaskTabItem2 = (tabLayout2 != null) ? tabLayout2.GetLayoutItemByIndex(i) : null;
				if (cyberPunkTaskTabItem2 != null)
				{
					cyberPunkTaskTabItem2.SetTabIconByTabId(cyberPunkTaskTabData.TabId);
				}
				if (cyberPunkTaskTabItem2 != null)
				{
					cyberPunkTaskTabItem2.SetSelected(i == num, false);
				}
			}
			this.SelectTabItem = cyberPunkTaskTabItem;
			this.SelectTabItem.SetSelected(true, false);
			this.SelectedTabIndex = num;
			this.RefreshTaskList(tabData, false);
		}

		// Token: 0x060379EF RID: 227823 RVA: 0x00F8C0B0 File Offset: 0x00F8A2B0
		private void RefreshTaskList(CyberPunkTaskTabData tabData, bool resetScroll = false)
		{
			CyberPunkData currentActivityData = CyberPunkController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				GenericScrollViewNew<CyberPunkTaskScrollItem, CyberPunkTaskData> taskScroll = this.TaskScroll;
				if (taskScroll == null)
				{
					return;
				}
				taskScroll.RefreshByData(new List<CyberPunkTaskData>(), null, false);
				return;
			}
			else
			{
				List<CyberPunkTaskData> cyberPunkTaskListByTabId = currentActivityData.GetCyberPunkTaskListByTabId(tabData.TabId);
				GenericScrollViewNew<CyberPunkTaskScrollItem, CyberPunkTaskData> taskScroll2 = this.TaskScroll;
				if (taskScroll2 == null)
				{
					return;
				}
				taskScroll2.RefreshByData(cyberPunkTaskListByTabId, delegate
				{
					if (resetScroll)
					{
						this.ResetTaskScrollState();
					}
					this.PlayTaskScrollInturnAnimation();
				}, false);
				return;
			}
		}

		// Token: 0x060379F0 RID: 227824 RVA: 0x00F8C124 File Offset: 0x00F8A324
		private void ResetTaskScrollState()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
			if (scrollViewWithScrollbar != null)
			{
				scrollViewWithScrollbar.SetScrollProgress(0f);
			}
			if (this.TaskScroll != null)
			{
				foreach (CyberPunkTaskScrollItem cyberPunkTaskScrollItem in this.TaskScroll.GetScrollItemList())
				{
					cyberPunkTaskScrollItem.ResetScroll();
				}
			}
		}

		// Token: 0x060379F1 RID: 227825 RVA: 0x00F8C198 File Offset: 0x00F8A398
		private void PlayTaskScrollInturnAnimation()
		{
			UUIInturnAnimController taskScrollAnimController = this.TaskScrollAnimController;
			if (taskScrollAnimController == null)
			{
				return;
			}
			taskScrollAnimController.Play("", -1, false);
		}

		// Token: 0x060379F2 RID: 227826 RVA: 0x00F8C1B4 File Offset: 0x00F8A3B4
		private void RefreshSliderItem()
		{
			if (this.SliderItem == null)
			{
				return;
			}
			CyberPunkData currentActivityData = CyberPunkController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			CyberPunkTaskSliderData cyberPunkTaskSliderData = currentActivityData.GetCyberPunkTaskSliderData();
			CyberPunkTaskData cyberPunkTaskData = new CyberPunkTaskData();
			cyberPunkTaskData.Id = cyberPunkTaskSliderData.Id;
			cyberPunkTaskData.Target = cyberPunkTaskSliderData.Target;
			cyberPunkTaskData.Current = cyberPunkTaskSliderData.Current;
			cyberPunkTaskData.Status = cyberPunkTaskSliderData.Status;
			this.SliderItem.Refresh(cyberPunkTaskData, false, 0);
		}

		// Token: 0x060379F3 RID: 227827 RVA: 0x00F8C224 File Offset: 0x00F8A424
		private void RefreshTimerText()
		{
			CyberPunkData currentActivityData = CyberPunkController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				UUIText text = base.GetText(4);
				if (text == null)
				{
					return;
				}
				text.SetText("", true);
				return;
			}
			else
			{
				ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(currentActivityData, null);
				bool item = timeVisibleAndRemainTime.Item1;
				string item2 = timeVisibleAndRemainTime.Item2;
				if (item)
				{
					UUIText text2 = base.GetText(4);
					if (text2 == null)
					{
						return;
					}
					text2.SetText(item2, true);
					return;
				}
				else
				{
					UUIText text3 = base.GetText(4);
					if (text3 == null)
					{
						return;
					}
					text3.SetText("", true);
					return;
				}
			}
		}

		// Token: 0x060379F4 RID: 227828 RVA: 0x00F8C2A0 File Offset: 0x00F8A4A0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			if (!(configParams[0] == "BackToBattleViewBtn"))
			{
				return null;
			}
			UActorComponent componentInChildren = ULGUIBPLibrary.GetComponentInChildren(base.GetRootActor(), TsUiHomeHelper.StaticClass(), false);
			AActor aactor = (componentInChildren != null) ? componentInChildren.GetOwner() : null;
			if (aactor == null)
			{
				return null;
			}
			UUIButtonComponent uuibuttonComponent = ULGUIBPLibrary.GetComponentInChildren(aactor, UUIButtonComponent.StaticClass(), false) as UUIButtonComponent;
			UUIItem uuiitem = (uuibuttonComponent != null) ? uuibuttonComponent.GetRootComponent() : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x0401D554 RID: 120148
		[Nullable(2)]
		private CyberPunkTaskTopItem TopItem;

		// Token: 0x0401D555 RID: 120149
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<CyberPunkTaskTabItem, CyberPunkTaskTabData> TabLayout;

		// Token: 0x0401D556 RID: 120150
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<CyberPunkTaskScrollItem, CyberPunkTaskData> TaskScroll;

		// Token: 0x0401D557 RID: 120151
		[Nullable(2)]
		private UUIInturnAnimController TaskScrollAnimController;

		// Token: 0x0401D558 RID: 120152
		[Nullable(2)]
		private CyberPunkTaskSliderItem SliderItem;

		// Token: 0x0401D559 RID: 120153
		private int SelectedTabIndex;

		// Token: 0x0401D55A RID: 120154
		[Nullable(2)]
		private CyberPunkTaskTabItem SelectTabItem;

		// Token: 0x0401D55B RID: 120155
		private List<CyberPunkTaskTabData> TabDataList = new List<CyberPunkTaskTabData>();

		// Token: 0x0200B456 RID: 46166
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04037C72 RID: 228466
			public const int UiItemCaption = 0;

			// Token: 0x04037C73 RID: 228467
			public const int TabLayout = 1;

			// Token: 0x04037C74 RID: 228468
			public const int TogTab = 2;

			// Token: 0x04037C75 RID: 228469
			public const int BtnLook = 3;

			// Token: 0x04037C76 RID: 228470
			public const int TxtRemainTime = 4;

			// Token: 0x04037C77 RID: 228471
			public const int ScrollLayout = 5;

			// Token: 0x04037C78 RID: 228472
			public const int ScrollItem = 6;

			// Token: 0x04037C79 RID: 228473
			public const int DownRewardLayout = 7;
		}
	}
}

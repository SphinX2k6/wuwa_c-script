using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x020068BD RID: 26813
	[NullableContext(1)]
	[Nullable(0)]
	public class CyberPunkTaskView : UiViewBase
	{
		// Token: 0x06042E81 RID: 274049 RVA: 0x0104A425 File Offset: 0x01048625
		public CyberPunkTaskView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06042E82 RID: 274050 RVA: 0x0104A43C File Offset: 0x0104863C
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

		// Token: 0x06042E83 RID: 274051 RVA: 0x0104A5A8 File Offset: 0x010487A8
		protected override UniTask OnBeforeStartAsync()
		{
			CyberPunkTaskView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CyberPunkTaskView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042E84 RID: 274052 RVA: 0x0104A5EC File Offset: 0x010487EC
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnCyberPunkTaskRefresh, new Action(this.OnCyberPunkTaskRefresh));
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
			ActivityController.Instance.RegisterRefreshTimerDelegate(new Action<float>(this.OnTimerRefresh));
		}

		// Token: 0x06042E85 RID: 274053 RVA: 0x0104A648 File Offset: 0x01048848
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnCyberPunkTaskRefresh, new Action(this.OnCyberPunkTaskRefresh));
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
			ActivityController.Instance.UnregisterRefreshTimerDelegate(new Action<float>(this.OnTimerRefresh));
		}

		// Token: 0x06042E86 RID: 274054 RVA: 0x0104A6A3 File Offset: 0x010488A3
		private void OnTimerRefresh(float delta)
		{
			this.RefreshTimerText();
		}

		// Token: 0x06042E87 RID: 274055 RVA: 0x0104A6AB File Offset: 0x010488AB
		protected override void OnBeforeShow()
		{
			if (this.TabDataList.Count > 0)
			{
				this.RefreshView();
			}
		}

		// Token: 0x06042E88 RID: 274056 RVA: 0x0104A6C4 File Offset: 0x010488C4
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

		// Token: 0x06042E89 RID: 274057 RVA: 0x0104A718 File Offset: 0x01048918
		private void OnRefreshRedDot(int activityId)
		{
			CyberPunkData currentActivityData = CyberPunkController.Instance.GetCurrentActivityData();
			if (currentActivityData != null && currentActivityData.Id == activityId)
			{
				this.RefreshSliderItem();
			}
		}

		// Token: 0x06042E8A RID: 274058 RVA: 0x0104A744 File Offset: 0x01048944
		private void OnClickTabItem(int tabId, CyberPunkTaskTabItem tabItem)
		{
			CyberPunkTaskTabItem selectTabItem = this.SelectTabItem;
			if (selectTabItem != null)
			{
				selectTabItem.SetSelected(false, false);
			}
			this.SelectTabItem = tabItem;
			this.SelectTabItem.SetSelected(true, false);
			CyberPunkTaskTabData cyberPunkTaskTabData = this.TabDataList.FirstOrDefault((CyberPunkTaskTabData t) => t.TabId == tabId);
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

		// Token: 0x06042E8B RID: 274059 RVA: 0x0104A7C7 File Offset: 0x010489C7
		private void OnClaimSliderReward(int scoreId)
		{
			CyberPunkController.Instance.RequestScoreReward(scoreId, null);
		}

		// Token: 0x06042E8C RID: 274060 RVA: 0x0104A7D5 File Offset: 0x010489D5
		private void OnClickBack()
		{
			UiManager.Instance.CloseView(EUiViewName.CyberPunkTaskView, null);
		}

		// Token: 0x06042E8D RID: 274061 RVA: 0x0104A7E8 File Offset: 0x010489E8
		private void OnClickLook()
		{
			if (this.SliderItem == null)
			{
				return;
			}
			int currentItemId = this.SliderItem.GetCurrentItemId();
			if (currentItemId > 0)
			{
				ItemController.Instance.OpenItemTipsByItemId(currentItemId, true, null);
			}
		}

		// Token: 0x06042E8E RID: 274062 RVA: 0x0104A81C File Offset: 0x01048A1C
		private UniTask InitTopItem()
		{
			CyberPunkTaskView.<InitTopItem>d__22 <InitTopItem>d__;
			<InitTopItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTopItem>d__.<>4__this = this;
			<InitTopItem>d__.<>1__state = -1;
			<InitTopItem>d__.<>t__builder.Start<CyberPunkTaskView.<InitTopItem>d__22>(ref <InitTopItem>d__);
			return <InitTopItem>d__.<>t__builder.Task;
		}

		// Token: 0x06042E8F RID: 274063 RVA: 0x0104A860 File Offset: 0x01048A60
		private void InitTabLayout()
		{
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(1);
			this.TabLayout = new GenericLayout<CyberPunkTaskTabItem, CyberPunkTaskTabData>(verticalLayout, new Func<CyberPunkTaskTabItem>(this.OnCreateTabItem), null, false, true);
		}

		// Token: 0x06042E90 RID: 274064 RVA: 0x0104A890 File Offset: 0x01048A90
		private void InitTaskScroll()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
			this.TaskScroll = new GenericScrollViewNew<CyberPunkTaskScrollItem, CyberPunkTaskData>(scrollViewWithScrollbar, new Func<CyberPunkTaskScrollItem>(this.OnCreateTaskItem), null, false, null);
			AUIBaseActor content = scrollViewWithScrollbar.GetContent();
			this.TaskScrollAnimController = (((content != null) ? content.GetComponentByClass(UUIInturnAnimController.StaticClass()) : null) as UUIInturnAnimController);
		}

		// Token: 0x06042E91 RID: 274065 RVA: 0x0104A8E8 File Offset: 0x01048AE8
		private UniTask InitSliderItem()
		{
			CyberPunkTaskView.<InitSliderItem>d__25 <InitSliderItem>d__;
			<InitSliderItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSliderItem>d__.<>4__this = this;
			<InitSliderItem>d__.<>1__state = -1;
			<InitSliderItem>d__.<>t__builder.Start<CyberPunkTaskView.<InitSliderItem>d__25>(ref <InitSliderItem>d__);
			return <InitSliderItem>d__.<>t__builder.Task;
		}

		// Token: 0x06042E92 RID: 274066 RVA: 0x0104A92B File Offset: 0x01048B2B
		private CyberPunkTaskTabItem OnCreateTabItem()
		{
			return new CyberPunkTaskTabItem
			{
				OnTabClickCallback = new Action<int, CyberPunkTaskTabItem>(this.OnClickTabItem)
			};
		}

		// Token: 0x06042E93 RID: 274067 RVA: 0x0104A944 File Offset: 0x01048B44
		private CyberPunkTaskScrollItem OnCreateTaskItem()
		{
			return new CyberPunkTaskScrollItem();
		}

		// Token: 0x06042E94 RID: 274068 RVA: 0x0104A94C File Offset: 0x01048B4C
		private void InitTabData()
		{
			CyberPunkData currentActivityData = CyberPunkController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			this.TabDataList = currentActivityData.GetCyberPunkTaskTabDataList();
		}

		// Token: 0x06042E95 RID: 274069 RVA: 0x0104A974 File Offset: 0x01048B74
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

		// Token: 0x06042E96 RID: 274070 RVA: 0x0104A9B0 File Offset: 0x01048BB0
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

		// Token: 0x06042E97 RID: 274071 RVA: 0x0104AA88 File Offset: 0x01048C88
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

		// Token: 0x06042E98 RID: 274072 RVA: 0x0104AAFC File Offset: 0x01048CFC
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

		// Token: 0x06042E99 RID: 274073 RVA: 0x0104AB70 File Offset: 0x01048D70
		private void PlayTaskScrollInturnAnimation()
		{
			UUIInturnAnimController taskScrollAnimController = this.TaskScrollAnimController;
			if (taskScrollAnimController == null)
			{
				return;
			}
			taskScrollAnimController.Play("", -1, false);
		}

		// Token: 0x06042E9A RID: 274074 RVA: 0x0104AB8C File Offset: 0x01048D8C
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

		// Token: 0x06042E9B RID: 274075 RVA: 0x0104ABFC File Offset: 0x01048DFC
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

		// Token: 0x06042E9C RID: 274076 RVA: 0x0104AC78 File Offset: 0x01048E78
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

		// Token: 0x04022CF8 RID: 142584
		[Nullable(2)]
		private CyberPunkTaskTopItem TopItem;

		// Token: 0x04022CF9 RID: 142585
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<CyberPunkTaskTabItem, CyberPunkTaskTabData> TabLayout;

		// Token: 0x04022CFA RID: 142586
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<CyberPunkTaskScrollItem, CyberPunkTaskData> TaskScroll;

		// Token: 0x04022CFB RID: 142587
		[Nullable(2)]
		private UUIInturnAnimController TaskScrollAnimController;

		// Token: 0x04022CFC RID: 142588
		[Nullable(2)]
		private CyberPunkTaskSliderItem SliderItem;

		// Token: 0x04022CFD RID: 142589
		private int SelectedTabIndex;

		// Token: 0x04022CFE RID: 142590
		[Nullable(2)]
		private CyberPunkTaskTabItem SelectTabItem;

		// Token: 0x04022CFF RID: 142591
		private List<CyberPunkTaskTabData> TabDataList = new List<CyberPunkTaskTabData>();

		// Token: 0x0200CA8E RID: 51854
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0403D398 RID: 250776
			public const int UiItemCaption = 0;

			// Token: 0x0403D399 RID: 250777
			public const int TabLayout = 1;

			// Token: 0x0403D39A RID: 250778
			public const int TogTab = 2;

			// Token: 0x0403D39B RID: 250779
			public const int BtnLook = 3;

			// Token: 0x0403D39C RID: 250780
			public const int TxtRemainTime = 4;

			// Token: 0x0403D39D RID: 250781
			public const int ScrollLayout = 5;

			// Token: 0x0403D39E RID: 250782
			public const int ScrollItem = 6;

			// Token: 0x0403D39F RID: 250783
			public const int DownRewardLayout = 7;
		}
	}
}

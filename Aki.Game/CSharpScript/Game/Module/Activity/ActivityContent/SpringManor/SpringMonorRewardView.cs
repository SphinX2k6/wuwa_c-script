using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006070 RID: 24688
	[NullableContext(2)]
	[Nullable(0)]
	public class SpringMonorRewardView : UiTickViewBase
	{
		// Token: 0x0603E6EF RID: 255727 RVA: 0x00F1559F File Offset: 0x00F1379F
		[NullableContext(1)]
		public SpringMonorRewardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E6F0 RID: 255728 RVA: 0x00F155B0 File Offset: 0x00F137B0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickPreview));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603E6F1 RID: 255729 RVA: 0x00F1571C File Offset: 0x00F1391C
		protected override UniTask OnBeforeStartAsync()
		{
			SpringMonorRewardView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpringMonorRewardView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E6F2 RID: 255730 RVA: 0x00F15760 File Offset: 0x00F13960
		protected override void OnStart()
		{
			this.InitCaption();
			this.InitQuestScroll();
			this.InitTabLayout();
			SpringManorRewardBottomItem bottomItem = this.BottomItem;
			if (bottomItem != null)
			{
				bottomItem.Refresh();
			}
			this.TimeTextItem = base.GetText(7);
			this.FormatTimeText = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
		}

		// Token: 0x0603E6F3 RID: 255731 RVA: 0x00F157B0 File Offset: 0x00F139B0
		protected override void OnBeforeHide()
		{
			GameSettingsDeviceRender instance = GameSettingsDeviceRender.Instance;
			UiViewInfo viewInfo = this.ViewInfo;
			EUiViewName? euiViewName = (viewInfo != null) ? new EUiViewName?(viewInfo.Name) : null;
			instance.CancelPerformanceLimit((euiViewName != null) ? euiViewName.GetValueOrDefault() : null);
		}

		// Token: 0x0603E6F4 RID: 255732 RVA: 0x00F15800 File Offset: 0x00F13A00
		protected override void OnTick(float delta)
		{
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(SpringManorModel.Instance.ActivityData.EndShowTime, this.FormatTimeText);
			UUIText timeTextItem = this.TimeTextItem;
			if (timeTextItem == null)
			{
				return;
			}
			timeTextItem.SetText(remainTimeText, true);
		}

		// Token: 0x0603E6F5 RID: 255733 RVA: 0x00F1583F File Offset: 0x00F13A3F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SpringManorTaskUpdateNotify, new Action(this.RefreshView));
		}

		// Token: 0x0603E6F6 RID: 255734 RVA: 0x00F1585D File Offset: 0x00F13A5D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SpringManorTaskUpdateNotify, new Action(this.RefreshView));
		}

		// Token: 0x0603E6F7 RID: 255735 RVA: 0x00F1587B File Offset: 0x00F13A7B
		private void RefreshView()
		{
			GenericLayout<TabItem, int> tabLayout = this.TabLayout;
			if (tabLayout != null)
			{
				tabLayout.RefreshWithoutDataSync();
			}
			this.RefreshQuestScroll(true);
			SpringManorRewardBottomItem bottomItem = this.BottomItem;
			if (bottomItem == null)
			{
				return;
			}
			bottomItem.Refresh();
		}

		// Token: 0x0603E6F8 RID: 255736 RVA: 0x00F158A8 File Offset: 0x00F13AA8
		private void InitCaption()
		{
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickClose));
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem == null)
			{
				return;
			}
			captionItem.SetHelpCallBack(delegate
			{
				HelpController.Instance.OpenHelpById(502);
			});
		}

		// Token: 0x0603E6F9 RID: 255737 RVA: 0x00F158FC File Offset: 0x00F13AFC
		private void InitTabLayout()
		{
			this.TabLayout = new GenericLayout<TabItem, int>(base.GetLayoutBase(3), new Func<TabItem>(this.CreateTabItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
			List<int> rewardTaskTabList = SpringManorModel.Instance.GetRewardTaskTabList();
			this.TabLayout.RefreshByData(rewardTaskTabList, delegate
			{
				GenericLayout<TabItem, int> tabLayout = this.TabLayout;
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

		// Token: 0x0603E6FA RID: 255738 RVA: 0x00F1595E File Offset: 0x00F13B5E
		[NullableContext(1)]
		private TabItem CreateTabItem()
		{
			TabItem tabItem = new TabItem();
			tabItem.SetTabClickCallback(new Action<int>(this.OnClickTab));
			return tabItem;
		}

		// Token: 0x0603E6FB RID: 255739 RVA: 0x00F15977 File Offset: 0x00F13B77
		private void OnClickTab(int tabIndex)
		{
			this.SelectedTabIndex = tabIndex;
			GenericLayout<TabItem, int> tabLayout = this.TabLayout;
			if (tabLayout != null)
			{
				tabLayout.SelectGridProxy(tabIndex, false);
			}
			this.RefreshQuestScroll(false);
		}

		// Token: 0x0603E6FC RID: 255740 RVA: 0x00F1599A File Offset: 0x00F13B9A
		private void InitQuestScroll()
		{
			this.QuestScroll = new GenericScrollViewNew<SpringManorRewardQuestItem, int>(base.GetScrollViewWithScrollbar(1), new Func<SpringManorRewardQuestItem>(this.CreateQuestItem), null, false, null);
		}

		// Token: 0x0603E6FD RID: 255741 RVA: 0x00F159C0 File Offset: 0x00F13BC0
		private void RefreshQuestScroll(bool keepPosition = true)
		{
			List<int> rewardTaskListByTabId = SpringManorModel.Instance.ActivityData.GetRewardTaskListByTabId(this.SelectedTabIndex);
			rewardTaskListByTabId.Sort(delegate(int idA, int idB)
			{
				ActivitySpringManorTaskData rewardTaskData = SpringManorModel.Instance.ActivityData.GetRewardTaskData(idA);
				ActivitySpringManorTaskData rewardTaskData2 = SpringManorModel.Instance.ActivityData.GetRewardTaskData(idB);
				EActivityTaskState status = rewardTaskData.Status;
				EActivityTaskState status2 = rewardTaskData2.Status;
				if (status != status2)
				{
					return status - status2;
				}
				return rewardTaskData.Sort - rewardTaskData.Sort;
			});
			Action callBack = null;
			if (!keepPosition)
			{
				callBack = delegate()
				{
					GenericScrollViewNew<SpringManorRewardQuestItem, int> questScroll2 = this.QuestScroll;
					if (questScroll2 == null)
					{
						return;
					}
					questScroll2.ScrollToTop(0);
				};
			}
			GenericScrollViewNew<SpringManorRewardQuestItem, int> questScroll = this.QuestScroll;
			if (questScroll == null)
			{
				return;
			}
			questScroll.RefreshByData(rewardTaskListByTabId, callBack, true);
		}

		// Token: 0x0603E6FE RID: 255742 RVA: 0x00F15A2D File Offset: 0x00F13C2D
		[NullableContext(1)]
		private SpringManorRewardQuestItem CreateQuestItem()
		{
			SpringManorRewardQuestItem springManorRewardQuestItem = new SpringManorRewardQuestItem();
			springManorRewardQuestItem.SetReceiveClickCallback(new Action(this.OnClickTaskReceive));
			springManorRewardQuestItem.OnSkipClick = new Action<ESpringRewardTaskSkipType>(this.OnClickTaskSkip);
			return springManorRewardQuestItem;
		}

		// Token: 0x0603E6FF RID: 255743 RVA: 0x00F15A58 File Offset: 0x00F13C58
		private void OnClickTaskSkip(ESpringRewardTaskSkipType skipType)
		{
			if (skipType == ESpringRewardTaskSkipType.WorldPosition)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x0603E700 RID: 255744 RVA: 0x00F15A65 File Offset: 0x00F13C65
		private void OnClickTaskReceive()
		{
			SpringManorController.Instance.RequestTaskRewardReceive(this.SelectedTabIndex, new Action(this.RefreshView));
		}

		// Token: 0x0603E701 RID: 255745 RVA: 0x00F15A83 File Offset: 0x00F13C83
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603E702 RID: 255746 RVA: 0x00F15A8C File Offset: 0x00F13C8C
		private void OnClickPreview()
		{
			SpringManorModel instance = SpringManorModel.Instance;
			int? num = (instance != null) ? new int?(instance.GetActivityConfig().VisionSkinItemId) : null;
			CalabashController.Instance.JumpToCalabashCollectTabViewOnlyShow(num.Value, true);
		}

		// Token: 0x04020A42 RID: 133698
		private PopupCaptionItem CaptionItem;

		// Token: 0x04020A43 RID: 133699
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<TabItem, int> TabLayout;

		// Token: 0x04020A44 RID: 133700
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<SpringManorRewardQuestItem, int> QuestScroll;

		// Token: 0x04020A45 RID: 133701
		private int SelectedTabIndex = -1;

		// Token: 0x04020A46 RID: 133702
		private SpringManorRewardBottomItem BottomItem;

		// Token: 0x04020A47 RID: 133703
		private UUIText TimeTextItem;

		// Token: 0x04020A48 RID: 133704
		private string FormatTimeText;
	}
}

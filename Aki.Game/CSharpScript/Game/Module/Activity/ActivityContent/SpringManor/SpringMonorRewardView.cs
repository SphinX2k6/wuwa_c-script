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
	// Token: 0x02004FEE RID: 20462
	[NullableContext(2)]
	[Nullable(0)]
	public class SpringMonorRewardView : UiTickViewBase
	{
		// Token: 0x060333B3 RID: 209843 RVA: 0x00E5C363 File Offset: 0x00E5A563
		[NullableContext(1)]
		public SpringMonorRewardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060333B4 RID: 209844 RVA: 0x00E5C374 File Offset: 0x00E5A574
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

		// Token: 0x060333B5 RID: 209845 RVA: 0x00E5C4E0 File Offset: 0x00E5A6E0
		protected override UniTask OnBeforeStartAsync()
		{
			SpringMonorRewardView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpringMonorRewardView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060333B6 RID: 209846 RVA: 0x00E5C524 File Offset: 0x00E5A724
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

		// Token: 0x060333B7 RID: 209847 RVA: 0x00E5C574 File Offset: 0x00E5A774
		protected override void OnBeforeHide()
		{
			GameSettingsDeviceRender instance = GameSettingsDeviceRender.Instance;
			UiViewInfo viewInfo = this.ViewInfo;
			EUiViewName? euiViewName = (viewInfo != null) ? new EUiViewName?(viewInfo.Name) : null;
			instance.CancelPerformanceLimit((euiViewName != null) ? euiViewName.GetValueOrDefault() : null);
		}

		// Token: 0x060333B8 RID: 209848 RVA: 0x00E5C5C4 File Offset: 0x00E5A7C4
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

		// Token: 0x060333B9 RID: 209849 RVA: 0x00E5C603 File Offset: 0x00E5A803
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SpringManorTaskUpdateNotify, new Action(this.RefreshView));
		}

		// Token: 0x060333BA RID: 209850 RVA: 0x00E5C621 File Offset: 0x00E5A821
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SpringManorTaskUpdateNotify, new Action(this.RefreshView));
		}

		// Token: 0x060333BB RID: 209851 RVA: 0x00E5C63F File Offset: 0x00E5A83F
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

		// Token: 0x060333BC RID: 209852 RVA: 0x00E5C66C File Offset: 0x00E5A86C
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

		// Token: 0x060333BD RID: 209853 RVA: 0x00E5C6C0 File Offset: 0x00E5A8C0
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

		// Token: 0x060333BE RID: 209854 RVA: 0x00E5C722 File Offset: 0x00E5A922
		[NullableContext(1)]
		private TabItem CreateTabItem()
		{
			TabItem tabItem = new TabItem();
			tabItem.SetTabClickCallback(new Action<int>(this.OnClickTab));
			return tabItem;
		}

		// Token: 0x060333BF RID: 209855 RVA: 0x00E5C73B File Offset: 0x00E5A93B
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

		// Token: 0x060333C0 RID: 209856 RVA: 0x00E5C75E File Offset: 0x00E5A95E
		private void InitQuestScroll()
		{
			this.QuestScroll = new GenericScrollViewNew<SpringManorRewardQuestItem, int>(base.GetScrollViewWithScrollbar(1), new Func<SpringManorRewardQuestItem>(this.CreateQuestItem), null, false, null);
		}

		// Token: 0x060333C1 RID: 209857 RVA: 0x00E5C784 File Offset: 0x00E5A984
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

		// Token: 0x060333C2 RID: 209858 RVA: 0x00E5C7F1 File Offset: 0x00E5A9F1
		[NullableContext(1)]
		private SpringManorRewardQuestItem CreateQuestItem()
		{
			SpringManorRewardQuestItem springManorRewardQuestItem = new SpringManorRewardQuestItem();
			springManorRewardQuestItem.SetReceiveClickCallback(new Action(this.OnClickTaskReceive));
			springManorRewardQuestItem.OnSkipClick = new Action<ESpringRewardTaskSkipType>(this.OnClickTaskSkip);
			return springManorRewardQuestItem;
		}

		// Token: 0x060333C3 RID: 209859 RVA: 0x00E5C81C File Offset: 0x00E5AA1C
		private void OnClickTaskSkip(ESpringRewardTaskSkipType skipType)
		{
			if (skipType == ESpringRewardTaskSkipType.WorldPosition)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x060333C4 RID: 209860 RVA: 0x00E5C829 File Offset: 0x00E5AA29
		private void OnClickTaskReceive()
		{
			SpringManorController.Instance.RequestTaskRewardReceive(this.SelectedTabIndex, new Action(this.RefreshView));
		}

		// Token: 0x060333C5 RID: 209861 RVA: 0x00E5C847 File Offset: 0x00E5AA47
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x060333C6 RID: 209862 RVA: 0x00E5C850 File Offset: 0x00E5AA50
		private void OnClickPreview()
		{
			SpringManorModel instance = SpringManorModel.Instance;
			int? num = (instance != null) ? new int?(instance.GetActivityConfig().VisionSkinItemId) : null;
			CalabashController.Instance.JumpToCalabashCollectTabViewOnlyShow(num.Value, true);
		}

		// Token: 0x0401B36F RID: 111471
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B370 RID: 111472
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<TabItem, int> TabLayout;

		// Token: 0x0401B371 RID: 111473
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<SpringManorRewardQuestItem, int> QuestScroll;

		// Token: 0x0401B372 RID: 111474
		private int SelectedTabIndex = -1;

		// Token: 0x0401B373 RID: 111475
		private SpringManorRewardBottomItem BottomItem;

		// Token: 0x0401B374 RID: 111476
		private UUIText TimeTextItem;

		// Token: 0x0401B375 RID: 111477
		private string FormatTimeText;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Module.UiNavigation.UIComponent;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Views.Rewards
{
	// Token: 0x02005797 RID: 22423
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlRewardsView : UiTickViewBase
	{
		// Token: 0x17006A96 RID: 27286
		// (get) Token: 0x0603756E RID: 226670 RVA: 0x00F74E7F File Offset: 0x00F7307F
		private ActivityDangoBrawlData ActivityData
		{
			get
			{
				return ActivityDangoBrawlController.Instance.MyActivityData;
			}
		}

		// Token: 0x17006A97 RID: 27287
		// (get) Token: 0x0603756F RID: 226671 RVA: 0x00F74E8B File Offset: 0x00F7308B
		private DangoBrawlOutGameData OutGameData
		{
			get
			{
				return this.ActivityData.GetOutGameData();
			}
		}

		// Token: 0x06037570 RID: 226672 RVA: 0x00F74E98 File Offset: 0x00F73098
		public DangoBrawlRewardsView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06037571 RID: 226673 RVA: 0x00F74EC8 File Offset: 0x00F730C8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickDetail));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06037572 RID: 226674 RVA: 0x00F750BC File Offset: 0x00F732BC
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x06037573 RID: 226675 RVA: 0x00F750BE File Offset: 0x00F732BE
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x06037574 RID: 226676 RVA: 0x00F750C0 File Offset: 0x00F732C0
		protected override void OnStart()
		{
			this.InitQuestScroll();
			this.InitTabLayout();
			this.InitProgressReward();
		}

		// Token: 0x06037575 RID: 226677 RVA: 0x00F750D4 File Offset: 0x00F732D4
		private void InitTabLayout()
		{
			this.TabLayout = new GenericLayout<DangoBrawlRewardTabItem, DangoBrawlRewardTabData>(base.GetHorizontalLayout(2), new Func<DangoBrawlRewardTabItem>(this.CreateTabItem), base.GetItem(3).GetOwner() as AUIBaseActor, false, true);
			this.TabList = this.CreateTabDataList();
			this.TabLayout.RefreshByData(this.TabList, delegate
			{
				GenericLayout<DangoBrawlRewardTabItem, DangoBrawlRewardTabData> tabLayout = this.TabLayout;
				if (tabLayout == null)
				{
					return;
				}
				DangoBrawlRewardTabItem layoutItemByIndex = tabLayout.GetLayoutItemByIndex(0);
				if (layoutItemByIndex == null)
				{
					return;
				}
				layoutItemByIndex.SetToggleSelect(true, true);
			}, false);
		}

		// Token: 0x06037576 RID: 226678 RVA: 0x00F7513C File Offset: 0x00F7333C
		private List<DangoBrawlRewardTabData> CreateTabDataList()
		{
			List<DangoBrawlRewardTabData> list = new List<DangoBrawlRewardTabData>();
			foreach (DangoBrawlRewardTab dangoBrawlRewardTab in DangoBrawlConfig.Instance.GetRewardTabConfigList())
			{
				list.Add(new DangoBrawlRewardTabData(dangoBrawlRewardTab.Id, dangoBrawlRewardTab.Name ?? "")
				{
					CanReceive = this.OutGameData.IsTaskHasRedDot(new int?(dangoBrawlRewardTab.Id))
				});
			}
			return list;
		}

		// Token: 0x06037577 RID: 226679 RVA: 0x00F751CC File Offset: 0x00F733CC
		private DangoBrawlRewardTabItem CreateTabItem()
		{
			DangoBrawlRewardTabItem dangoBrawlRewardTabItem = new DangoBrawlRewardTabItem();
			dangoBrawlRewardTabItem.SetTabClickCallback(new Action<int>(this.OnClickTab));
			return dangoBrawlRewardTabItem;
		}

		// Token: 0x06037578 RID: 226680 RVA: 0x00F751E5 File Offset: 0x00F733E5
		private void OnClickTab(int tabIndex)
		{
			this.SelectedTabIndex = this.TabList[tabIndex].Id;
			GenericLayout<DangoBrawlRewardTabItem, DangoBrawlRewardTabData> tabLayout = this.TabLayout;
			if (tabLayout != null)
			{
				tabLayout.SelectGridProxy(tabIndex, false);
			}
			this.RefreshQuestScroll(true);
		}

		// Token: 0x06037579 RID: 226681 RVA: 0x00F75218 File Offset: 0x00F73418
		private void InitQuestScroll()
		{
			this.QuestScroll = new GenericScrollViewNew<DangoBrawlRewardItem, DangoBrawlTaskData>(base.GetScrollViewWithScrollbar(4), new Func<DangoBrawlRewardItem>(this.CreateQuestItem), null, false, null);
		}

		// Token: 0x0603757A RID: 226682 RVA: 0x00F7523C File Offset: 0x00F7343C
		private void RefreshQuestScroll(bool scrollToTop = false)
		{
			List<DangoBrawlTaskData> taskDataList = this.OutGameData.GetTaskDataList(new int?(this.SelectedTabIndex));
			taskDataList.Sort((DangoBrawlTaskData a, DangoBrawlTaskData b) => Array.IndexOf<EActivityTaskState>(this.StatusOrder, a.Status) - Array.IndexOf<EActivityTaskState>(this.StatusOrder, b.Status));
			Action callBack = null;
			if (scrollToTop)
			{
				callBack = delegate()
				{
					GenericScrollViewNew<DangoBrawlRewardItem, DangoBrawlTaskData> questScroll2 = this.QuestScroll;
					if (questScroll2 == null)
					{
						return;
					}
					questScroll2.ScrollToTop(0);
				};
			}
			GenericScrollViewNew<DangoBrawlRewardItem, DangoBrawlTaskData> questScroll = this.QuestScroll;
			if (questScroll == null)
			{
				return;
			}
			questScroll.RefreshByData(taskDataList, callBack, true);
		}

		// Token: 0x0603757B RID: 226683 RVA: 0x00F75297 File Offset: 0x00F73497
		private DangoBrawlRewardItem CreateQuestItem()
		{
			DangoBrawlRewardItem dangoBrawlRewardItem = new DangoBrawlRewardItem();
			dangoBrawlRewardItem.SetReceiveClickCallback(new Action(this.OnClickTaskReceive));
			return dangoBrawlRewardItem;
		}

		// Token: 0x0603757C RID: 226684 RVA: 0x00F752B0 File Offset: 0x00F734B0
		private void InitProgressReward()
		{
			this.GiftLayout = new GenericLayout<DangoBrawlGiftItem, int>(base.GetHorizontalLayout(8), new Func<DangoBrawlGiftItem>(this.CreateGiftItem), null, false, true);
			this.ProgressBarWidth = base.GetSprite(7).GetWidth();
		}

		// Token: 0x0603757D RID: 226685 RVA: 0x00F752E5 File Offset: 0x00F734E5
		private DangoBrawlGiftItem CreateGiftItem()
		{
			return new DangoBrawlGiftItem
			{
				ReceiveCallback = new Action(this.OnProgressRewardReceiveCallback)
			};
		}

		// Token: 0x0603757E RID: 226686 RVA: 0x00F752FE File Offset: 0x00F734FE
		private void OnProgressRewardReceiveCallback()
		{
			this.RefreshView();
		}

		// Token: 0x0603757F RID: 226687 RVA: 0x00F75308 File Offset: 0x00F73508
		private void RefreshProgressReward()
		{
			int currentMilestone = this.OutGameData.GetCurrentMilestone();
			IEnumerable<DangoBrawlScoreReward> allDangoBrawlScoreAwardConfig = DangoBrawlConfig.Instance.GetAllDangoBrawlScoreAwardConfig();
			List<int> list = new List<int>();
			foreach (DangoBrawlScoreReward dangoBrawlScoreReward in allDangoBrawlScoreAwardConfig)
			{
				list.Add(dangoBrawlScoreReward.Id);
			}
			this.RefreshProgressItem(currentMilestone, list);
		}

		// Token: 0x06037580 RID: 226688 RVA: 0x00F7537C File Offset: 0x00F7357C
		private void RefreshProgressItem(int currentProgress, IReadOnlyList<int> rewardIdList)
		{
			UUIText text = base.GetText(6);
			if (text != null)
			{
				text.SetText(currentProgress.ToString(), true);
			}
			float num = 0f;
			float num2 = 0f;
			int count = rewardIdList.Count;
			if (count <= 0)
			{
				GenericLayout<DangoBrawlGiftItem, int> giftLayout = this.GiftLayout;
				if (giftLayout == null)
				{
					return;
				}
				giftLayout.RefreshByData(Array.Empty<int>(), null, false);
				return;
			}
			else
			{
				int num3 = 0;
				for (int i = 0; i < count; i++)
				{
					int id = rewardIdList[i];
					DangoBrawlScoreReward value = DangoBrawlConfig.Instance.GetScoreRewardConfigById(id).Value;
					if (currentProgress >= value.Score)
					{
						num += 1f / (float)count;
					}
					else if (currentProgress > num3)
					{
						int score = value.Score;
						float num4 = this.ProgressBarWidth / (float)count - 130f;
						float num5 = (float)(currentProgress - num3) / (float)(score - num3);
						num2 = (num4 * num5 + 65f) / this.ProgressBarWidth;
						break;
					}
					num3 = value.Score;
				}
				float num6 = num + num2;
				base.GetSprite(7).SetFillAmount(num6);
				UUISprite sprite = base.GetSprite(10);
				UUIItem uuiitem = sprite;
				bool bUseChangeColor = num6 > 0f;
				FColor? fcolor = new FColor?(sprite.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
				GenericLayout<DangoBrawlGiftItem, int> giftLayout2 = this.GiftLayout;
				if (giftLayout2 == null)
				{
					return;
				}
				giftLayout2.RefreshByData(rewardIdList, null, false);
				return;
			}
		}

		// Token: 0x06037581 RID: 226689 RVA: 0x00F754B8 File Offset: 0x00F736B8
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlRewardsView.<OnBeforeStartAsync>d__31 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlRewardsView.<OnBeforeStartAsync>d__31>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037582 RID: 226690 RVA: 0x00F754FB File Offset: 0x00F736FB
		protected override void OnBeforeShow()
		{
			HotKeyComponentUtil.SetupComponents<RewardTakeComponent>(this.RootItem, EHotKeyCacheKey.RewardTakeDataCallback, delegate(RewardTakeComponent component)
			{
				component.SetDataCallback(() => this.OutGameData.GetLastNotTakenScoreRewardIndex());
			});
			this.RefreshView();
			this.RefreshRemainTime();
		}

		// Token: 0x06037583 RID: 226691 RVA: 0x00F75521 File Offset: 0x00F73721
		protected override void OnTick(float delta)
		{
			this.RefreshRemainTime();
		}

		// Token: 0x06037584 RID: 226692 RVA: 0x00F75529 File Offset: 0x00F73729
		private void RefreshView()
		{
			this.RefreshQuestScroll(false);
			this.RefreshProgressReward();
			this.RefreshTabRedDot();
		}

		// Token: 0x06037585 RID: 226693 RVA: 0x00F75540 File Offset: 0x00F73740
		private void SyncTabCanReceive()
		{
			foreach (DangoBrawlRewardTabData dangoBrawlRewardTabData in this.TabList)
			{
				dangoBrawlRewardTabData.CanReceive = this.OutGameData.IsTaskHasRedDot(new int?(dangoBrawlRewardTabData.Id));
			}
		}

		// Token: 0x06037586 RID: 226694 RVA: 0x00F755A8 File Offset: 0x00F737A8
		private void RefreshTabRedDot()
		{
			if (this.TabLayout == null)
			{
				return;
			}
			this.SyncTabCanReceive();
			List<DangoBrawlRewardTabItem> layoutItemList = this.TabLayout.GetLayoutItemList();
			int num = 0;
			while (num < layoutItemList.Count && num < this.TabList.Count)
			{
				DangoBrawlRewardTabItem dangoBrawlRewardTabItem = layoutItemList[num];
				DangoBrawlRewardTabData dangoBrawlRewardTabData = this.TabList[num];
				dangoBrawlRewardTabItem.SetRedDotVisible(dangoBrawlRewardTabData.CanReceive);
				num++;
			}
		}

		// Token: 0x06037587 RID: 226695 RVA: 0x00F75610 File Offset: 0x00F73810
		private void RefreshRemainTime()
		{
			string text = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null) ?? "";
			string newText = ActivityModel.Instance.GetRemainTimeText(this.ActivityData.EndOpenTime, text) ?? "";
			UUIText text2 = base.GetText(11);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(newText, true);
		}

		// Token: 0x06037588 RID: 226696 RVA: 0x00F75666 File Offset: 0x00F73866
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06037589 RID: 226697 RVA: 0x00F75670 File Offset: 0x00F73870
		private void OnClickDetail()
		{
			DangoBrawlActivity? activityConfigById = DangoBrawlConfig.Instance.GetActivityConfigById(this.ActivityData.Id);
			if (activityConfigById == null)
			{
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(activityConfigById.Value.LimitScoreRewardId, true, null, false);
		}

		// Token: 0x0603758A RID: 226698 RVA: 0x00F756BC File Offset: 0x00F738BC
		private void OnClickTaskReceive()
		{
			List<int> taskCanClaimableIdListByTabId = this.ActivityData.GetTaskCanClaimableIdListByTabId(this.SelectedTabIndex);
			if (taskCanClaimableIdListByTabId.Count <= 0)
			{
				return;
			}
			ActivityDangoBrawlController.Instance.RequestTaskReward(taskCanClaimableIdListByTabId, new Action(this.RefreshView));
		}

		// Token: 0x0401D39D RID: 119709
		private const int REWARD_ITEM_WIDTH = 130;

		// Token: 0x0401D39E RID: 119710
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401D39F RID: 119711
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<DangoBrawlRewardItem, DangoBrawlTaskData> QuestScroll;

		// Token: 0x0401D3A0 RID: 119712
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlRewardTabItem, DangoBrawlRewardTabData> TabLayout;

		// Token: 0x0401D3A1 RID: 119713
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<DangoBrawlGiftItem, int> GiftLayout;

		// Token: 0x0401D3A2 RID: 119714
		private List<DangoBrawlRewardTabData> TabList = new List<DangoBrawlRewardTabData>();

		// Token: 0x0401D3A3 RID: 119715
		private float ProgressBarWidth;

		// Token: 0x0401D3A4 RID: 119716
		private int SelectedTabIndex = -1;

		// Token: 0x0401D3A5 RID: 119717
		private readonly EActivityTaskState[] StatusOrder = new EActivityTaskState[]
		{
			EActivityTaskState.FinishedAndUnclaimed,
			EActivityTaskState.Active,
			EActivityTaskState.FinishedAndClaimed
		};

		// Token: 0x0200B3D8 RID: 46040
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x040379D8 RID: 227800
			Caption,
			// Token: 0x040379D9 RID: 227801
			DetailButton,
			// Token: 0x040379DA RID: 227802
			TabLayout,
			// Token: 0x040379DB RID: 227803
			TabItem,
			// Token: 0x040379DC RID: 227804
			QuestScroll,
			// Token: 0x040379DD RID: 227805
			QuestItem,
			// Token: 0x040379DE RID: 227806
			TextTotalScore,
			// Token: 0x040379DF RID: 227807
			Bar,
			// Token: 0x040379E0 RID: 227808
			PnlHLayout,
			// Token: 0x040379E1 RID: 227809
			PnlGift,
			// Token: 0x040379E2 RID: 227810
			SprDot,
			// Token: 0x040379E3 RID: 227811
			TxtLimitTime
		}
	}
}

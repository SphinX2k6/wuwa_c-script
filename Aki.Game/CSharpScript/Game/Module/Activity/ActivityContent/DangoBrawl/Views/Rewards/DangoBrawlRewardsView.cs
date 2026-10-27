using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02006847 RID: 26695
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlRewardsView : UiTickViewBase
	{
		// Token: 0x17009755 RID: 38741
		// (get) Token: 0x06042A1A RID: 272922 RVA: 0x01033973 File Offset: 0x01031B73
		private ActivityDangoBrawlData ActivityData
		{
			get
			{
				return ActivityDangoBrawlController.Instance.MyActivityData;
			}
		}

		// Token: 0x17009756 RID: 38742
		// (get) Token: 0x06042A1B RID: 272923 RVA: 0x0103397F File Offset: 0x01031B7F
		private DangoBrawlOutGameData OutGameData
		{
			get
			{
				return this.ActivityData.GetOutGameData();
			}
		}

		// Token: 0x06042A1C RID: 272924 RVA: 0x0103398C File Offset: 0x01031B8C
		public DangoBrawlRewardsView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06042A1D RID: 272925 RVA: 0x010339BC File Offset: 0x01031BBC
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

		// Token: 0x06042A1E RID: 272926 RVA: 0x01033BB0 File Offset: 0x01031DB0
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x06042A1F RID: 272927 RVA: 0x01033BB2 File Offset: 0x01031DB2
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x06042A20 RID: 272928 RVA: 0x01033BB4 File Offset: 0x01031DB4
		protected override void OnStart()
		{
			this.InitQuestScroll();
			this.InitTabLayout();
			this.InitProgressReward();
		}

		// Token: 0x06042A21 RID: 272929 RVA: 0x01033BC8 File Offset: 0x01031DC8
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

		// Token: 0x06042A22 RID: 272930 RVA: 0x01033C30 File Offset: 0x01031E30
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

		// Token: 0x06042A23 RID: 272931 RVA: 0x01033CC0 File Offset: 0x01031EC0
		private DangoBrawlRewardTabItem CreateTabItem()
		{
			DangoBrawlRewardTabItem dangoBrawlRewardTabItem = new DangoBrawlRewardTabItem();
			dangoBrawlRewardTabItem.SetTabClickCallback(new Action<int>(this.OnClickTab));
			return dangoBrawlRewardTabItem;
		}

		// Token: 0x06042A24 RID: 272932 RVA: 0x01033CD9 File Offset: 0x01031ED9
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

		// Token: 0x06042A25 RID: 272933 RVA: 0x01033D0C File Offset: 0x01031F0C
		private void InitQuestScroll()
		{
			this.QuestScroll = new GenericScrollViewNew<DangoBrawlRewardItem, DangoBrawlTaskData>(base.GetScrollViewWithScrollbar(4), new Func<DangoBrawlRewardItem>(this.CreateQuestItem), null, false, null);
		}

		// Token: 0x06042A26 RID: 272934 RVA: 0x01033D30 File Offset: 0x01031F30
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

		// Token: 0x06042A27 RID: 272935 RVA: 0x01033D8B File Offset: 0x01031F8B
		private DangoBrawlRewardItem CreateQuestItem()
		{
			DangoBrawlRewardItem dangoBrawlRewardItem = new DangoBrawlRewardItem();
			dangoBrawlRewardItem.SetReceiveClickCallback(new Action(this.OnClickTaskReceive));
			return dangoBrawlRewardItem;
		}

		// Token: 0x06042A28 RID: 272936 RVA: 0x01033DA4 File Offset: 0x01031FA4
		private void InitProgressReward()
		{
			this.GiftLayout = new GenericLayout<DangoBrawlGiftItem, int>(base.GetHorizontalLayout(8), new Func<DangoBrawlGiftItem>(this.CreateGiftItem), null, false, true);
			this.ProgressBarWidth = base.GetSprite(7).GetWidth();
		}

		// Token: 0x06042A29 RID: 272937 RVA: 0x01033DD9 File Offset: 0x01031FD9
		private DangoBrawlGiftItem CreateGiftItem()
		{
			return new DangoBrawlGiftItem
			{
				ReceiveCallback = new Action(this.OnProgressRewardReceiveCallback)
			};
		}

		// Token: 0x06042A2A RID: 272938 RVA: 0x01033DF2 File Offset: 0x01031FF2
		private void OnProgressRewardReceiveCallback()
		{
			this.RefreshView();
		}

		// Token: 0x06042A2B RID: 272939 RVA: 0x01033DFC File Offset: 0x01031FFC
		private void RefreshProgressReward()
		{
			int currentMilestone = this.OutGameData.GetCurrentMilestone();
			IReadOnlyList<DangoBrawlScoreReward> allDangoBrawlScoreAwardConfig = DangoBrawlConfig.Instance.GetAllDangoBrawlScoreAwardConfig();
			this.RefreshProgressItem(currentMilestone, (from config in allDangoBrawlScoreAwardConfig
			select config.Id).ToList<int>());
		}

		// Token: 0x06042A2C RID: 272940 RVA: 0x01033E54 File Offset: 0x01032054
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
				giftLayout2.RefreshByData(rewardIdList.ToList<int>(), null, false);
				return;
			}
		}

		// Token: 0x06042A2D RID: 272941 RVA: 0x01033F94 File Offset: 0x01032194
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlRewardsView.<OnBeforeStartAsync>d__31 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlRewardsView.<OnBeforeStartAsync>d__31>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042A2E RID: 272942 RVA: 0x01033FD7 File Offset: 0x010321D7
		protected override void OnBeforeShow()
		{
			HotKeyComponentUtil.SetupComponents<RewardTakeComponent>(this.RootItem, EHotKeyCacheKey.RewardTakeDataCallback, () => this.OutGameData.GetLastNotTakenScoreRewardIndex());
			this.RefreshView();
			this.RefreshRemainTime();
		}

		// Token: 0x06042A2F RID: 272943 RVA: 0x01033FFD File Offset: 0x010321FD
		protected override void OnTick(float delta)
		{
			this.RefreshRemainTime();
		}

		// Token: 0x06042A30 RID: 272944 RVA: 0x01034005 File Offset: 0x01032205
		private void RefreshView()
		{
			this.RefreshQuestScroll(false);
			this.RefreshProgressReward();
			this.RefreshTabRedDot();
		}

		// Token: 0x06042A31 RID: 272945 RVA: 0x0103401C File Offset: 0x0103221C
		private void SyncTabCanReceive()
		{
			foreach (DangoBrawlRewardTabData dangoBrawlRewardTabData in this.TabList)
			{
				dangoBrawlRewardTabData.CanReceive = this.OutGameData.IsTaskHasRedDot(new int?(dangoBrawlRewardTabData.Id));
			}
		}

		// Token: 0x06042A32 RID: 272946 RVA: 0x01034084 File Offset: 0x01032284
		private void RefreshTabRedDot()
		{
			if (this.TabLayout == null)
			{
				return;
			}
			this.SyncTabCanReceive();
			foreach (ValueTuple<DangoBrawlRewardTabItem, DangoBrawlRewardTabData> valueTuple in this.TabLayout.GetLayoutItemList().Zip(this.TabList))
			{
				DangoBrawlRewardTabItem item = valueTuple.Item1;
				DangoBrawlRewardTabData item2 = valueTuple.Item2;
				item.SetRedDotVisible(item2.CanReceive);
			}
		}

		// Token: 0x06042A33 RID: 272947 RVA: 0x01034104 File Offset: 0x01032304
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

		// Token: 0x06042A34 RID: 272948 RVA: 0x0103415A File Offset: 0x0103235A
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06042A35 RID: 272949 RVA: 0x01034164 File Offset: 0x01032364
		private void OnClickDetail()
		{
			DangoBrawlActivity? activityConfigById = DangoBrawlConfig.Instance.GetActivityConfigById(this.ActivityData.Id);
			if (activityConfigById == null)
			{
				return;
			}
			ItemController.Instance.OpenItemTipsByItemId(activityConfigById.Value.LimitScoreRewardId, true, null);
		}

		// Token: 0x06042A36 RID: 272950 RVA: 0x010341AC File Offset: 0x010323AC
		private void OnClickTaskReceive()
		{
			List<int> taskCanClaimableIdListByTabId = this.ActivityData.GetTaskCanClaimableIdListByTabId(this.SelectedTabIndex);
			if (taskCanClaimableIdListByTabId.Count <= 0)
			{
				return;
			}
			ActivityDangoBrawlController.Instance.RequestTaskReward(taskCanClaimableIdListByTabId, new Action(this.RefreshView));
		}

		// Token: 0x04022B40 RID: 142144
		private const int REWARD_ITEM_WIDTH = 130;

		// Token: 0x04022B41 RID: 142145
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04022B42 RID: 142146
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<DangoBrawlRewardItem, DangoBrawlTaskData> QuestScroll;

		// Token: 0x04022B43 RID: 142147
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlRewardTabItem, DangoBrawlRewardTabData> TabLayout;

		// Token: 0x04022B44 RID: 142148
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<DangoBrawlGiftItem, int> GiftLayout;

		// Token: 0x04022B45 RID: 142149
		private List<DangoBrawlRewardTabData> TabList = new List<DangoBrawlRewardTabData>();

		// Token: 0x04022B46 RID: 142150
		private float ProgressBarWidth;

		// Token: 0x04022B47 RID: 142151
		private int SelectedTabIndex = -1;

		// Token: 0x04022B48 RID: 142152
		private readonly EActivityTaskState[] StatusOrder = new EActivityTaskState[]
		{
			EActivityTaskState.FinishedAndUnclaimed,
			EActivityTaskState.Active,
			EActivityTaskState.FinishedAndClaimed
		};

		// Token: 0x0200CA0C RID: 51724
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403D0EF RID: 250095
			Caption,
			// Token: 0x0403D0F0 RID: 250096
			DetailButton,
			// Token: 0x0403D0F1 RID: 250097
			TabLayout,
			// Token: 0x0403D0F2 RID: 250098
			TabItem,
			// Token: 0x0403D0F3 RID: 250099
			QuestScroll,
			// Token: 0x0403D0F4 RID: 250100
			QuestItem,
			// Token: 0x0403D0F5 RID: 250101
			TextTotalScore,
			// Token: 0x0403D0F6 RID: 250102
			Bar,
			// Token: 0x0403D0F7 RID: 250103
			PnlHLayout,
			// Token: 0x0403D0F8 RID: 250104
			PnlGift,
			// Token: 0x0403D0F9 RID: 250105
			SprDot,
			// Token: 0x0403D0FA RID: 250106
			TxtLimitTime
		}
	}
}

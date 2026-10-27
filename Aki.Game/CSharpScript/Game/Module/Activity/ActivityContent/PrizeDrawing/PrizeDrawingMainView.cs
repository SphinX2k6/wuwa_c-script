using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing.Components;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing
{
	// Token: 0x0200629E RID: 25246
	[NullableContext(1)]
	[Nullable(0)]
	public class PrizeDrawingMainView : UiTickViewBase
	{
		// Token: 0x1700926D RID: 37485
		// (get) Token: 0x0603F827 RID: 260135 RVA: 0x00F5AF62 File Offset: 0x00F59162
		private ActivityPrizeDrawingData Data
		{
			get
			{
				return ActivityPrizeDrawingController.Instance.ActivityData;
			}
		}

		// Token: 0x0603F828 RID: 260136 RVA: 0x00F5AF6E File Offset: 0x00F5916E
		public PrizeDrawingMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603F829 RID: 260137 RVA: 0x00F5AF90 File Offset: 0x00F59190
		protected unsafe override void OnRegisterComponent()
		{
			int num = 20;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603F82A RID: 260138 RVA: 0x00F5B258 File Offset: 0x00F59458
		protected override UniTask OnBeforeStartAsync()
		{
			PrizeDrawingMainView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PrizeDrawingMainView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F82B RID: 260139 RVA: 0x00F5B29B File Offset: 0x00F5949B
		protected override void OnStart()
		{
			this.RefreshCaption();
			this.RefreshRewardList(true);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceCloseEvent), false);
		}

		// Token: 0x0603F82C RID: 260140 RVA: 0x00F5B2D3 File Offset: 0x00F594D3
		private void RefreshView()
		{
			this.RefreshRewardList(false);
			this.RefreshProgress();
			this.RefreshTime();
			this.RefreshButton();
			this.RefreshQuest();
		}

		// Token: 0x0603F82D RID: 260141 RVA: 0x00F5B2F4 File Offset: 0x00F594F4
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			this.RefreshView();
		}

		// Token: 0x0603F82E RID: 260142 RVA: 0x00F5B302 File Offset: 0x00F59502
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x0603F82F RID: 260143 RVA: 0x00F5B314 File Offset: 0x00F59514
		protected override void OnTick(float delta)
		{
			this.RefreshTime();
		}

		// Token: 0x0603F830 RID: 260144 RVA: 0x00F5B31C File Offset: 0x00F5951C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Add(EEventName.OnPrizeDrawingRewardStatusChanged, new Action(this.OnRewardStatusChanged));
			EventSystem.Instance.Add(EEventName.OnPrizeDrawingQuestUpdated, new Action(this.OnPrizeDrawingQuestUpdated));
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnOpenAnimationEvent));
		}

		// Token: 0x0603F831 RID: 260145 RVA: 0x00F5B398 File Offset: 0x00F59598
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Remove(EEventName.OnPrizeDrawingRewardStatusChanged, new Action(this.OnRewardStatusChanged));
			EventSystem.Instance.Remove(EEventName.OnPrizeDrawingQuestUpdated, new Action(this.OnPrizeDrawingQuestUpdated));
			EventSystem.Instance.Remove<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnOpenAnimationEvent));
		}

		// Token: 0x0603F832 RID: 260146 RVA: 0x00F5B412 File Offset: 0x00F59612
		private void OnOpenAnimationEvent(string param)
		{
			if (param == "Guide")
			{
				this.RefreshButtonAnimation();
			}
		}

		// Token: 0x0603F833 RID: 260147 RVA: 0x00F5B427 File Offset: 0x00F59627
		private void OnSequenceCloseEvent(string seqName)
		{
			if (seqName == "TransIn")
			{
				this.RefreshButtonAnimation();
			}
		}

		// Token: 0x0603F834 RID: 260148 RVA: 0x00F5B43C File Offset: 0x00F5963C
		private void RefreshButtonAnimation()
		{
			if (this.Data.ShouldShowButtonRedDot())
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer == null)
				{
					return;
				}
				levelSequencePlayer.PlayOrReplaySequenceByName("GuideLoop", false, null);
				return;
			}
			else
			{
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 == null)
				{
					return;
				}
				levelSequencePlayer2.PlaySequencePurely("GuideDefault", false, false, null, null, false);
				return;
			}
		}

		// Token: 0x0603F835 RID: 260149 RVA: 0x00F5B498 File Offset: 0x00F59698
		private void OnRewardStatusChanged()
		{
			this.IsRewardStatusChanged = true;
			this.RefreshButton();
			this.RefreshProgress();
		}

		// Token: 0x0603F836 RID: 260150 RVA: 0x00F5B4B0 File Offset: 0x00F596B0
		private void OnCloseView(EUiViewName viewName, int viewId)
		{
			if (viewName == EUiViewName.PrizeDrawingTearView)
			{
				if (this.IsRewardStatusChanged)
				{
					this.RefreshRewardList(false);
					this.IsRewardStatusChanged = false;
				}
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer == null)
				{
					return;
				}
				levelSequencePlayer.PlaySequencePurely("TransIn", true, false, null, null, false);
			}
		}

		// Token: 0x0603F837 RID: 260151 RVA: 0x00F5B502 File Offset: 0x00F59702
		private void OnPrizeDrawingQuestUpdated()
		{
			this.RefreshView();
		}

		// Token: 0x0603F838 RID: 260152 RVA: 0x00F5B50C File Offset: 0x00F5970C
		private UniTask CreateRewardList()
		{
			PrizeDrawingMainView.<CreateRewardList>d__27 <CreateRewardList>d__;
			<CreateRewardList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRewardList>d__.<>4__this = this;
			<CreateRewardList>d__.<>1__state = -1;
			<CreateRewardList>d__.<>t__builder.Start<PrizeDrawingMainView.<CreateRewardList>d__27>(ref <CreateRewardList>d__);
			return <CreateRewardList>d__.<>t__builder.Task;
		}

		// Token: 0x0603F839 RID: 260153 RVA: 0x00F5B550 File Offset: 0x00F59750
		private UniTask CreateFinalRewardItem(PrizeDrawingMainView.EComp itemIndex, int itemId, int count)
		{
			PrizeDrawingMainView.<CreateFinalRewardItem>d__28 <CreateFinalRewardItem>d__;
			<CreateFinalRewardItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateFinalRewardItem>d__.<>4__this = this;
			<CreateFinalRewardItem>d__.itemIndex = itemIndex;
			<CreateFinalRewardItem>d__.itemId = itemId;
			<CreateFinalRewardItem>d__.count = count;
			<CreateFinalRewardItem>d__.<>1__state = -1;
			<CreateFinalRewardItem>d__.<>t__builder.Start<PrizeDrawingMainView.<CreateFinalRewardItem>d__28>(ref <CreateFinalRewardItem>d__);
			return <CreateFinalRewardItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603F83A RID: 260154 RVA: 0x00F5B5AC File Offset: 0x00F597AC
		private UniTask CreateRewardItem(PrizeDrawingMainView.EComp itemIndex, int itemId, int count, int maxAmount)
		{
			PrizeDrawingMainView.<CreateRewardItem>d__29 <CreateRewardItem>d__;
			<CreateRewardItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRewardItem>d__.<>4__this = this;
			<CreateRewardItem>d__.itemIndex = itemIndex;
			<CreateRewardItem>d__.itemId = itemId;
			<CreateRewardItem>d__.count = count;
			<CreateRewardItem>d__.maxAmount = maxAmount;
			<CreateRewardItem>d__.<>1__state = -1;
			<CreateRewardItem>d__.<>t__builder.Start<PrizeDrawingMainView.<CreateRewardItem>d__29>(ref <CreateRewardItem>d__);
			return <CreateRewardItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603F83B RID: 260155 RVA: 0x00F5B610 File Offset: 0x00F59810
		private void RefreshRewardList(bool animBanned = false)
		{
			IReadOnlyList<KujiAwardsGroup> allAwardGroup = this.Data.GetAllAwardGroup();
			for (int i = 0; i < this.FinalRewardItemList.Count; i++)
			{
				this.FinalRewardItemList[i].Refresh(this.Data.IsGotAward(allAwardGroup[i].Id), animBanned);
			}
			for (int j = 0; j < this.RewardItemList.Count; j++)
			{
				this.RewardItemList[j].Refresh(this.Data.GetAwardCurrentAmount(allAwardGroup[j + this.FinalRewardItemList.Count].Id), animBanned);
			}
		}

		// Token: 0x0603F83C RID: 260156 RVA: 0x00F5B6BC File Offset: 0x00F598BC
		private void RefreshCaption()
		{
			this.CaptionItem.SetTitleLocalText(this.Data.GetTitleTextId());
			this.CaptionItem.SetCloseCallBack(new Action(this.OnCloseCallback));
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem == null)
			{
				return;
			}
			captionItem.SetCurrencyItemList(new int[]
			{
				this.Data.GetCostCoinId()
			});
		}

		// Token: 0x0603F83D RID: 260157 RVA: 0x00F5B71C File Offset: 0x00F5991C
		private void RefreshProgress()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "Ichiban_Kuji_Progress_Reward", new <>z__ReadOnlyArray<object>(new object[]
			{
				this.Data.GetCurrentProgress(),
				this.Data.GetTotalProgress()
			}));
		}

		// Token: 0x0603F83E RID: 260158 RVA: 0x00F5B774 File Offset: 0x00F59974
		private void RefreshTime()
		{
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(this.Data, null);
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			this.TimeTxtItem = base.GetText(12);
			this.TimeTxtItem.SetUIActive(item);
			this.TimeTxtItem.SetText(item2, true);
		}

		// Token: 0x0603F83F RID: 260159 RVA: 0x00F5B7C8 File Offset: 0x00F599C8
		private void RefreshButton()
		{
			UUIItem item = base.GetItem(17);
			ActivityPrizeDrawingData data = this.Data;
			if (data != null && data.IsAllFinished())
			{
				ActivityButtonItem activityButton = this.ActivityButton;
				if (activityButton != null)
				{
					activityButton.SetUiActive(false);
				}
				if (item != null)
				{
					item.SetUIActive(true);
					return;
				}
			}
			else
			{
				ActivityButtonItem activityButton2 = this.ActivityButton;
				if (activityButton2 != null)
				{
					activityButton2.SetUiActive(true);
				}
				if (item != null)
				{
					item.SetUIActive(false);
				}
				ActivityButtonItem activityButton3 = this.ActivityButton;
				if (activityButton3 != null)
				{
					activityButton3.SetShowText("Ichiban_Kuji_Start");
				}
				ActivityButtonItem activityButton4 = this.ActivityButton;
				if (activityButton4 != null)
				{
					activityButton4.SetFunction(new Action(this.OnClickRoll));
				}
				ActivityButtonItem activityButton5 = this.ActivityButton;
				if (activityButton5 == null)
				{
					return;
				}
				activityButton5.SetRedDotVisible(this.Data.ShouldShowButtonRedDot());
			}
		}

		// Token: 0x0603F840 RID: 260160 RVA: 0x00F5B87C File Offset: 0x00F59A7C
		private void RefreshQuest()
		{
			if (!this.Data.IsQuestAllCompleted())
			{
				PrizeDrawingQuestItem questItem = this.QuestItem;
				if (questItem != null)
				{
					questItem.RefreshFinishState(false);
				}
				int? currentQuestId = this.Data.GetCurrentQuestId();
				if (currentQuestId != null)
				{
					int? num = currentQuestId;
					int num2 = 0;
					if (!(num.GetValueOrDefault() == num2 & num != null))
					{
						PrizeDrawingQuestItem questItem2 = this.QuestItem;
						if (questItem2 == null)
						{
							return;
						}
						questItem2.RefreshByQuestId(currentQuestId.Value, this.Data.GetQuestProgress(), this.Data.GetQuestTotalProgress());
						return;
					}
				}
				return;
			}
			PrizeDrawingQuestItem questItem3 = this.QuestItem;
			if (questItem3 == null)
			{
				return;
			}
			questItem3.RefreshFinishState(true);
		}

		// Token: 0x0603F841 RID: 260161 RVA: 0x00F5B918 File Offset: 0x00F59B18
		private void OnClickRoll()
		{
			if (!ActivityPrizeDrawingController.Instance.ActivityData.HaveEnoughCoinToRoll())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Ichiban_Kuji_NotEnoughTips", Array.Empty<object>());
				return;
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely("TransOut", true, false, null, null, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.StopSequenceByKey("GuideLoop", false, false);
			}
			LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
			if (levelSequencePlayer3 != null)
			{
				levelSequencePlayer3.PlaySequencePurely("GuideDefault", false, false, null, null, false);
			}
			UiManager.Instance.OpenView(EUiViewName.PrizeDrawingTearView, null, null);
		}

		// Token: 0x0603F842 RID: 260162 RVA: 0x00F5B9BA File Offset: 0x00F59BBA
		private void OnCloseCallback()
		{
			base.CloseMe(null);
		}

		// Token: 0x0402133A RID: 135994
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0402133B RID: 135995
		[Nullable(2)]
		private ActivityButtonItem ActivityButton;

		// Token: 0x0402133C RID: 135996
		[Nullable(2)]
		private PrizeDrawingQuestItem QuestItem;

		// Token: 0x0402133D RID: 135997
		[Nullable(2)]
		private UUIText TimeTxtItem;

		// Token: 0x0402133E RID: 135998
		private readonly List<PrizeDrawingFinalRewardItem> FinalRewardItemList = new List<PrizeDrawingFinalRewardItem>();

		// Token: 0x0402133F RID: 135999
		private readonly List<PrizeDrawingRewardItem> RewardItemList = new List<PrizeDrawingRewardItem>();

		// Token: 0x04021340 RID: 136000
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04021341 RID: 136001
		private bool IsRewardStatusChanged;

		// Token: 0x0200C472 RID: 50290
		[NullableContext(0)]
		private enum EComp
		{
			// Token: 0x0403B43D RID: 242749
			Caption,
			// Token: 0x0403B43E RID: 242750
			PrizeS1,
			// Token: 0x0403B43F RID: 242751
			PrizeS2,
			// Token: 0x0403B440 RID: 242752
			PrizeS3,
			// Token: 0x0403B441 RID: 242753
			PrizeS4,
			// Token: 0x0403B442 RID: 242754
			PrizeA,
			// Token: 0x0403B443 RID: 242755
			PrizeB,
			// Token: 0x0403B444 RID: 242756
			PrizeC,
			// Token: 0x0403B445 RID: 242757
			PrizeD,
			// Token: 0x0403B446 RID: 242758
			PrizeE,
			// Token: 0x0403B447 RID: 242759
			PrizeF,
			// Token: 0x0403B448 RID: 242760
			TxtProgress,
			// Token: 0x0403B449 RID: 242761
			TxtDelTime,
			// Token: 0x0403B44A RID: 242762
			TxtQuestName,
			// Token: 0x0403B44B RID: 242763
			TxtQuestProgress,
			// Token: 0x0403B44C RID: 242764
			QuestRewardItem,
			// Token: 0x0403B44D RID: 242765
			SkipQuestBtn,
			// Token: 0x0403B44E RID: 242766
			TipsFinish,
			// Token: 0x0403B44F RID: 242767
			FunctionBtn,
			// Token: 0x0403B450 RID: 242768
			QuestItem
		}
	}
}

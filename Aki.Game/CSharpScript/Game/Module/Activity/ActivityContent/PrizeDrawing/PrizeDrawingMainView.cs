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
	// Token: 0x0200521C RID: 21020
	[NullableContext(1)]
	[Nullable(0)]
	public class PrizeDrawingMainView : UiTickViewBase
	{
		// Token: 0x170065CF RID: 26063
		// (get) Token: 0x060344E8 RID: 214248 RVA: 0x00EA1EBE File Offset: 0x00EA00BE
		private ActivityPrizeDrawingData Data
		{
			get
			{
				return ActivityPrizeDrawingController.Instance.ActivityData;
			}
		}

		// Token: 0x060344E9 RID: 214249 RVA: 0x00EA1ECA File Offset: 0x00EA00CA
		public PrizeDrawingMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060344EA RID: 214250 RVA: 0x00EA1EEC File Offset: 0x00EA00EC
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

		// Token: 0x060344EB RID: 214251 RVA: 0x00EA21B4 File Offset: 0x00EA03B4
		protected override UniTask OnBeforeStartAsync()
		{
			PrizeDrawingMainView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PrizeDrawingMainView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060344EC RID: 214252 RVA: 0x00EA21F7 File Offset: 0x00EA03F7
		protected override void OnStart()
		{
			this.RefreshCaption();
			this.RefreshRewardList(true);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceCloseEvent), false);
		}

		// Token: 0x060344ED RID: 214253 RVA: 0x00EA222F File Offset: 0x00EA042F
		private void RefreshView()
		{
			this.RefreshRewardList(false);
			this.RefreshProgress();
			this.RefreshTime();
			this.RefreshButton();
			this.RefreshQuest();
		}

		// Token: 0x060344EE RID: 214254 RVA: 0x00EA2250 File Offset: 0x00EA0450
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			this.RefreshView();
		}

		// Token: 0x060344EF RID: 214255 RVA: 0x00EA225E File Offset: 0x00EA045E
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x060344F0 RID: 214256 RVA: 0x00EA2270 File Offset: 0x00EA0470
		protected override void OnTick(float delta)
		{
			this.RefreshTime();
		}

		// Token: 0x060344F1 RID: 214257 RVA: 0x00EA2278 File Offset: 0x00EA0478
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Add(EEventName.OnPrizeDrawingRewardStatusChanged, new Action(this.OnRewardStatusChanged));
			EventSystem.Instance.Add(EEventName.OnPrizeDrawingQuestUpdated, new Action(this.OnPrizeDrawingQuestUpdated));
			EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnOpenAnimationEvent));
		}

		// Token: 0x060344F2 RID: 214258 RVA: 0x00EA22F4 File Offset: 0x00EA04F4
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Remove(EEventName.OnPrizeDrawingRewardStatusChanged, new Action(this.OnRewardStatusChanged));
			EventSystem.Instance.Remove(EEventName.OnPrizeDrawingQuestUpdated, new Action(this.OnPrizeDrawingQuestUpdated));
			EventSystem.Instance.Remove<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnOpenAnimationEvent));
		}

		// Token: 0x060344F3 RID: 214259 RVA: 0x00EA236E File Offset: 0x00EA056E
		private void OnOpenAnimationEvent(string param)
		{
			if (param == "Guide")
			{
				this.RefreshButtonAnimation();
			}
		}

		// Token: 0x060344F4 RID: 214260 RVA: 0x00EA2383 File Offset: 0x00EA0583
		private void OnSequenceCloseEvent(string seqName)
		{
			if (seqName == "TransIn")
			{
				this.RefreshButtonAnimation();
			}
		}

		// Token: 0x060344F5 RID: 214261 RVA: 0x00EA2398 File Offset: 0x00EA0598
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

		// Token: 0x060344F6 RID: 214262 RVA: 0x00EA23F4 File Offset: 0x00EA05F4
		private void OnRewardStatusChanged()
		{
			this.IsRewardStatusChanged = true;
			this.RefreshButton();
			this.RefreshProgress();
		}

		// Token: 0x060344F7 RID: 214263 RVA: 0x00EA240C File Offset: 0x00EA060C
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

		// Token: 0x060344F8 RID: 214264 RVA: 0x00EA245E File Offset: 0x00EA065E
		private void OnPrizeDrawingQuestUpdated()
		{
			this.RefreshView();
		}

		// Token: 0x060344F9 RID: 214265 RVA: 0x00EA2468 File Offset: 0x00EA0668
		private UniTask CreateRewardList()
		{
			PrizeDrawingMainView.<CreateRewardList>d__27 <CreateRewardList>d__;
			<CreateRewardList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRewardList>d__.<>4__this = this;
			<CreateRewardList>d__.<>1__state = -1;
			<CreateRewardList>d__.<>t__builder.Start<PrizeDrawingMainView.<CreateRewardList>d__27>(ref <CreateRewardList>d__);
			return <CreateRewardList>d__.<>t__builder.Task;
		}

		// Token: 0x060344FA RID: 214266 RVA: 0x00EA24AC File Offset: 0x00EA06AC
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

		// Token: 0x060344FB RID: 214267 RVA: 0x00EA2508 File Offset: 0x00EA0708
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

		// Token: 0x060344FC RID: 214268 RVA: 0x00EA256C File Offset: 0x00EA076C
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

		// Token: 0x060344FD RID: 214269 RVA: 0x00EA2618 File Offset: 0x00EA0818
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

		// Token: 0x060344FE RID: 214270 RVA: 0x00EA2678 File Offset: 0x00EA0878
		private void RefreshProgress()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "Ichiban_Kuji_Progress_Reward", new <>z__ReadOnlyArray<object>(new object[]
			{
				this.Data.GetCurrentProgress(),
				this.Data.GetTotalProgress()
			}));
		}

		// Token: 0x060344FF RID: 214271 RVA: 0x00EA26D0 File Offset: 0x00EA08D0
		private void RefreshTime()
		{
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(this.Data, null);
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			this.TimeTxtItem = base.GetText(12);
			this.TimeTxtItem.SetUIActive(item);
			this.TimeTxtItem.SetText(item2, true);
		}

		// Token: 0x06034500 RID: 214272 RVA: 0x00EA2724 File Offset: 0x00EA0924
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

		// Token: 0x06034501 RID: 214273 RVA: 0x00EA27D8 File Offset: 0x00EA09D8
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

		// Token: 0x06034502 RID: 214274 RVA: 0x00EA2874 File Offset: 0x00EA0A74
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

		// Token: 0x06034503 RID: 214275 RVA: 0x00EA2916 File Offset: 0x00EA0B16
		private void OnCloseCallback()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401BC69 RID: 113769
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401BC6A RID: 113770
		[Nullable(2)]
		private ActivityButtonItem ActivityButton;

		// Token: 0x0401BC6B RID: 113771
		[Nullable(2)]
		private PrizeDrawingQuestItem QuestItem;

		// Token: 0x0401BC6C RID: 113772
		[Nullable(2)]
		private UUIText TimeTxtItem;

		// Token: 0x0401BC6D RID: 113773
		private readonly List<PrizeDrawingFinalRewardItem> FinalRewardItemList = new List<PrizeDrawingFinalRewardItem>();

		// Token: 0x0401BC6E RID: 113774
		private readonly List<PrizeDrawingRewardItem> RewardItemList = new List<PrizeDrawingRewardItem>();

		// Token: 0x0401BC6F RID: 113775
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401BC70 RID: 113776
		private bool IsRewardStatusChanged;

		// Token: 0x0200AE59 RID: 44633
		[NullableContext(0)]
		private enum EComp
		{
			// Token: 0x04035D9F RID: 220575
			Caption,
			// Token: 0x04035DA0 RID: 220576
			PrizeS1,
			// Token: 0x04035DA1 RID: 220577
			PrizeS2,
			// Token: 0x04035DA2 RID: 220578
			PrizeS3,
			// Token: 0x04035DA3 RID: 220579
			PrizeS4,
			// Token: 0x04035DA4 RID: 220580
			PrizeA,
			// Token: 0x04035DA5 RID: 220581
			PrizeB,
			// Token: 0x04035DA6 RID: 220582
			PrizeC,
			// Token: 0x04035DA7 RID: 220583
			PrizeD,
			// Token: 0x04035DA8 RID: 220584
			PrizeE,
			// Token: 0x04035DA9 RID: 220585
			PrizeF,
			// Token: 0x04035DAA RID: 220586
			TxtProgress,
			// Token: 0x04035DAB RID: 220587
			TxtDelTime,
			// Token: 0x04035DAC RID: 220588
			TxtQuestName,
			// Token: 0x04035DAD RID: 220589
			TxtQuestProgress,
			// Token: 0x04035DAE RID: 220590
			QuestRewardItem,
			// Token: 0x04035DAF RID: 220591
			SkipQuestBtn,
			// Token: 0x04035DB0 RID: 220592
			TipsFinish,
			// Token: 0x04035DB1 RID: 220593
			FunctionBtn,
			// Token: 0x04035DB2 RID: 220594
			QuestItem
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005936 RID: 22838
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolPrizeDrawingView : UiViewBase
	{
		// Token: 0x17006BD5 RID: 27605
		// (get) Token: 0x06038462 RID: 230498 RVA: 0x00FBBF89 File Offset: 0x00FBA189
		private static SolarSchoolPrizeDrawingCenter Center
		{
			get
			{
				return SolarSchoolPrizeDrawingCenter.Instance;
			}
		}

		// Token: 0x17006BD6 RID: 27606
		// (get) Token: 0x06038463 RID: 230499 RVA: 0x00FBBF90 File Offset: 0x00FBA190
		private int ActivityId
		{
			get
			{
				return SolarSchoolPrizeDrawingView.Center.CurrentActivityId;
			}
		}

		// Token: 0x06038464 RID: 230500 RVA: 0x00FBBF9C File Offset: 0x00FBA19C
		public SolarSchoolPrizeDrawingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06038465 RID: 230501 RVA: 0x00FBBFBC File Offset: 0x00FBA1BC
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

		// Token: 0x06038466 RID: 230502 RVA: 0x00FBC284 File Offset: 0x00FBA484
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolPrizeDrawingView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolPrizeDrawingView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038467 RID: 230503 RVA: 0x00FBC2C8 File Offset: 0x00FBA4C8
		protected override void OnStart()
		{
			this.Handler = (this.OpenParam as ISolarSchoolPrizeDrawingViewHandler);
			this.RefreshCaption();
			this.RefreshRewardList(true);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			ISolarSchoolPrizeDrawingViewHandler handler = this.Handler;
			if (handler != null)
			{
				handler.OnViewReady(this);
			}
			this.RefreshView();
		}

		// Token: 0x06038468 RID: 230504 RVA: 0x00FBC31C File Offset: 0x00FBA51C
		protected override void OnBeforeShow()
		{
			this.RefreshView();
		}

		// Token: 0x06038469 RID: 230505 RVA: 0x00FBC324 File Offset: 0x00FBA524
		protected override UniTask OnPlayingCloseSequenceAsync()
		{
			SolarSchoolPrizeDrawCaptionItem captionItem = this.CaptionItem;
			if (captionItem != null)
			{
				captionItem.PlayClose(false);
			}
			return UniTask.CompletedTask;
		}

		// Token: 0x0603846A RID: 230506 RVA: 0x00FBC33D File Offset: 0x00FBA53D
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			ISolarSchoolPrizeDrawingViewHandler handler = this.Handler;
			this.Handler = null;
			if (handler == null)
			{
				return;
			}
			handler.OnViewClosed();
		}

		// Token: 0x0603846B RID: 230507 RVA: 0x00FBC368 File Offset: 0x00FBA568
		protected override UniTask OnDestroyAsyncImplementImplement()
		{
			SolarSchoolPrizeDrawingView.<OnDestroyAsyncImplementImplement>d__19 <OnDestroyAsyncImplementImplement>d__;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnDestroyAsyncImplementImplement>d__.<>4__this = this;
			<OnDestroyAsyncImplementImplement>d__.<>1__state = -1;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder.Start<SolarSchoolPrizeDrawingView.<OnDestroyAsyncImplementImplement>d__19>(ref <OnDestroyAsyncImplementImplement>d__);
			return <OnDestroyAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603846C RID: 230508 RVA: 0x00FBC3AB File Offset: 0x00FBA5AB
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Add(EEventName.OnPrizeDrawingRewardStatusChanged, new Action(this.OnRewardStatusChanged));
		}

		// Token: 0x0603846D RID: 230509 RVA: 0x00FBC3E2 File Offset: 0x00FBA5E2
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Remove(EEventName.OnPrizeDrawingRewardStatusChanged, new Action(this.OnRewardStatusChanged));
		}

		// Token: 0x0603846E RID: 230510 RVA: 0x00FBC419 File Offset: 0x00FBA619
		private void RefreshView()
		{
			this.RefreshRewardList(false);
			this.RefreshProgress();
			this.RefreshButton();
		}

		// Token: 0x0603846F RID: 230511 RVA: 0x00FBC42E File Offset: 0x00FBA62E
		private void OnRewardStatusChanged()
		{
			this.IsRewardStatusChanged = true;
			this.RefreshRewardList(false);
			this.RefreshButton();
			this.RefreshProgress();
		}

		// Token: 0x06038470 RID: 230512 RVA: 0x00FBC44C File Offset: 0x00FBA64C
		private void OnCloseView(EUiViewName viewName, int viewId)
		{
			if (viewName == EUiViewName.SolarSchoolPrizeDrawingTearView)
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

		// Token: 0x06038471 RID: 230513 RVA: 0x00FBC4A0 File Offset: 0x00FBA6A0
		private UniTask CreateRewardList()
		{
			SolarSchoolPrizeDrawingView.<CreateRewardList>d__25 <CreateRewardList>d__;
			<CreateRewardList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRewardList>d__.<>4__this = this;
			<CreateRewardList>d__.<>1__state = -1;
			<CreateRewardList>d__.<>t__builder.Start<SolarSchoolPrizeDrawingView.<CreateRewardList>d__25>(ref <CreateRewardList>d__);
			return <CreateRewardList>d__.<>t__builder.Task;
		}

		// Token: 0x06038472 RID: 230514 RVA: 0x00FBC4E4 File Offset: 0x00FBA6E4
		private UniTask CreateFinalRewardItem(SolarSchoolPrizeDrawingView.EComp itemIndex, int itemId, int count)
		{
			SolarSchoolPrizeDrawingView.<CreateFinalRewardItem>d__26 <CreateFinalRewardItem>d__;
			<CreateFinalRewardItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateFinalRewardItem>d__.<>4__this = this;
			<CreateFinalRewardItem>d__.itemIndex = itemIndex;
			<CreateFinalRewardItem>d__.itemId = itemId;
			<CreateFinalRewardItem>d__.count = count;
			<CreateFinalRewardItem>d__.<>1__state = -1;
			<CreateFinalRewardItem>d__.<>t__builder.Start<SolarSchoolPrizeDrawingView.<CreateFinalRewardItem>d__26>(ref <CreateFinalRewardItem>d__);
			return <CreateFinalRewardItem>d__.<>t__builder.Task;
		}

		// Token: 0x06038473 RID: 230515 RVA: 0x00FBC540 File Offset: 0x00FBA740
		private UniTask CreateRewardItem(SolarSchoolPrizeDrawingView.EComp itemIndex, int itemId, int count, int maxAmount)
		{
			SolarSchoolPrizeDrawingView.<CreateRewardItem>d__27 <CreateRewardItem>d__;
			<CreateRewardItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRewardItem>d__.<>4__this = this;
			<CreateRewardItem>d__.itemIndex = itemIndex;
			<CreateRewardItem>d__.itemId = itemId;
			<CreateRewardItem>d__.count = count;
			<CreateRewardItem>d__.maxAmount = maxAmount;
			<CreateRewardItem>d__.<>1__state = -1;
			<CreateRewardItem>d__.<>t__builder.Start<SolarSchoolPrizeDrawingView.<CreateRewardItem>d__27>(ref <CreateRewardItem>d__);
			return <CreateRewardItem>d__.<>t__builder.Task;
		}

		// Token: 0x06038474 RID: 230516 RVA: 0x00FBC5A4 File Offset: 0x00FBA7A4
		private void RefreshRewardList(bool animBanned = false)
		{
			IReadOnlyList<PrizeAwardsGroup> allAwardGroup = SolarSchoolPrizeDrawingView.Center.GetAllAwardGroup(this.ActivityId);
			int num = 0;
			while (num < this.FinalRewardItemList.Count && num < allAwardGroup.Count)
			{
				this.FinalRewardItemList[num].Refresh(SolarSchoolPrizeDrawingView.Center.IsGroupDrawnOut(allAwardGroup[num].Id), animBanned);
				num++;
			}
			int num2 = 0;
			while (num2 < this.RewardItemList.Count && num2 + this.FinalRewardItemList.Count < allAwardGroup.Count)
			{
				this.RewardItemList[num2].Refresh(SolarSchoolPrizeDrawingView.Center.GetDrawnCount(allAwardGroup[num2 + this.FinalRewardItemList.Count].Id), animBanned);
				num2++;
			}
		}

		// Token: 0x06038475 RID: 230517 RVA: 0x00FBC66E File Offset: 0x00FBA86E
		private void RefreshCaption()
		{
			this.CaptionItem.SetCloseCallBack(new Action(this.OnCloseCallback));
			this.CaptionItem.SetHelpGroupId(745);
		}

		// Token: 0x06038476 RID: 230518 RVA: 0x00FBC698 File Offset: 0x00FBA898
		private void RefreshProgress()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "Ichiban_Kuji_Progress_Reward", new <>z__ReadOnlyArray<object>(new object[]
			{
				SolarSchoolPrizeDrawingView.Center.GetCurrentProgress(this.ActivityId),
				SolarSchoolPrizeDrawingView.Center.GetTotalProgress(this.ActivityId)
			}));
		}

		// Token: 0x06038477 RID: 230519 RVA: 0x00FBC6F8 File Offset: 0x00FBA8F8
		private void RefreshButton()
		{
			UUIItem item = base.GetItem(17);
			if (SolarSchoolPrizeDrawingView.Center.IsAllFinished(this.ActivityId))
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
				activityButton5.SetRedDotVisible(SolarSchoolPrizeDrawingView.Center.HaveEnoughCoinToRoll());
			}
		}

		// Token: 0x06038478 RID: 230520 RVA: 0x00FBC7A8 File Offset: 0x00FBA9A8
		private void OnClickRoll()
		{
			switch (SolarSchoolPrizeDrawingView.Center.ResolveDrawCost())
			{
			case ESolarSchoolDrawCostCheck.UseA:
				this.OpenTearView(SolarSchoolPrizeDrawingView.Center.GetCostA());
				return;
			case ESolarSchoolDrawCostCheck.NeedConfirmB:
			{
				SolarSchoolCostCurrency costB = SolarSchoolPrizeDrawingView.Center.GetCostB();
				SolarSchoolUtils.ShowCostConfirmPopup(SolarSchoolPrizeDrawingView.Center.GetCostConfirmId(), costB.Num, delegate
				{
					if (!SolarSchoolPrizeDrawingView.Center.HasEnough(SolarSchoolPrizeDrawingView.Center.GetCostB()))
					{
						return;
					}
					this.OpenTearView(SolarSchoolPrizeDrawingView.Center.GetCostB());
				});
				return;
			}
			case ESolarSchoolDrawCostCheck.NotEnough:
				SolarSchoolUtils.ShowNotEnoughPopup(SolarSchoolPrizeDrawingView.Center.GetNotEnoughConfirmId());
				return;
			default:
				return;
			}
		}

		// Token: 0x06038479 RID: 230521 RVA: 0x00FBC820 File Offset: 0x00FBAA20
		private void OpenTearView(SolarSchoolCostCurrency firstCost)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely("TransOut", true, false, null, null, false);
			}
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolPrizeDrawingTearView, new SolarSchoolPrizeDrawingTearParam(firstCost), null);
		}

		// Token: 0x0603847A RID: 230522 RVA: 0x00FBC866 File Offset: 0x00FBAA66
		private void OnCloseCallback()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401DA31 RID: 121393
		[Nullable(2)]
		private SolarSchoolPrizeDrawCaptionItem CaptionItem;

		// Token: 0x0401DA32 RID: 121394
		[Nullable(2)]
		private ActivityButtonItem ActivityButton;

		// Token: 0x0401DA33 RID: 121395
		private readonly List<SolarSchoolPrizeDrawingFinalRewardItem> FinalRewardItemList = new List<SolarSchoolPrizeDrawingFinalRewardItem>();

		// Token: 0x0401DA34 RID: 121396
		private readonly List<SolarSchoolPrizeDrawingRewardItem> RewardItemList = new List<SolarSchoolPrizeDrawingRewardItem>();

		// Token: 0x0401DA35 RID: 121397
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401DA36 RID: 121398
		[Nullable(2)]
		private ISolarSchoolPrizeDrawingViewHandler Handler;

		// Token: 0x0401DA37 RID: 121399
		private bool IsRewardStatusChanged;

		// Token: 0x0200B4F0 RID: 46320
		[NullableContext(0)]
		private enum EComp
		{
			// Token: 0x04037F1A RID: 229146
			Caption,
			// Token: 0x04037F1B RID: 229147
			PrizeS1,
			// Token: 0x04037F1C RID: 229148
			PrizeS2,
			// Token: 0x04037F1D RID: 229149
			PrizeS3,
			// Token: 0x04037F1E RID: 229150
			PrizeS4,
			// Token: 0x04037F1F RID: 229151
			PrizeA,
			// Token: 0x04037F20 RID: 229152
			PrizeB,
			// Token: 0x04037F21 RID: 229153
			PrizeC,
			// Token: 0x04037F22 RID: 229154
			PrizeD,
			// Token: 0x04037F23 RID: 229155
			PrizeE,
			// Token: 0x04037F24 RID: 229156
			PrizeF,
			// Token: 0x04037F25 RID: 229157
			TxtProgress,
			// Token: 0x04037F26 RID: 229158
			TxtDelTime,
			// Token: 0x04037F27 RID: 229159
			TxtQuestName,
			// Token: 0x04037F28 RID: 229160
			TxtQuestProgress,
			// Token: 0x04037F29 RID: 229161
			QuestRewardItem,
			// Token: 0x04037F2A RID: 229162
			SkipQuestBtn,
			// Token: 0x04037F2B RID: 229163
			TipsFinish,
			// Token: 0x04037F2C RID: 229164
			FunctionBtn,
			// Token: 0x04037F2D RID: 229165
			QuestItem
		}
	}
}

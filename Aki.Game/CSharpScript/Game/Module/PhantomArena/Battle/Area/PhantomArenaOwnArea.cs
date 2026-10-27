using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Battle.Area.Functional;
using CSharpScript.Game.Module.PhantomArena.Battle.Area.Hand;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Field;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Panel;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Area
{
	// Token: 0x020052C8 RID: 21192
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaOwnArea
	{
		// Token: 0x06036343 RID: 222019 RVA: 0x00CD2B5C File Offset: 0x00CD0D5C
		private UniTask InitHandArea(UUIItem handAreaItem)
		{
			PhantomArenaOwnArea.<InitHandArea>d__11 <InitHandArea>d__;
			<InitHandArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitHandArea>d__.<>4__this = this;
			<InitHandArea>d__.handAreaItem = handAreaItem;
			<InitHandArea>d__.<>1__state = -1;
			<InitHandArea>d__.<>t__builder.Start<PhantomArenaOwnArea.<InitHandArea>d__11>(ref <InitHandArea>d__);
			return <InitHandArea>d__.<>t__builder.Task;
		}

		// Token: 0x06036344 RID: 222020 RVA: 0x00CD2BA8 File Offset: 0x00CD0DA8
		private UniTask InitFunctionalArea(UUIItem functionalAreaItem)
		{
			PhantomArenaOwnArea.<InitFunctionalArea>d__12 <InitFunctionalArea>d__;
			<InitFunctionalArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitFunctionalArea>d__.<>4__this = this;
			<InitFunctionalArea>d__.functionalAreaItem = functionalAreaItem;
			<InitFunctionalArea>d__.<>1__state = -1;
			<InitFunctionalArea>d__.<>t__builder.Start<PhantomArenaOwnArea.<InitFunctionalArea>d__12>(ref <InitFunctionalArea>d__);
			return <InitFunctionalArea>d__.<>t__builder.Task;
		}

		// Token: 0x06036345 RID: 222021 RVA: 0x00CD2BF4 File Offset: 0x00CD0DF4
		private UniTask InitRoleItem(UUIItem roleItem)
		{
			PhantomArenaOwnArea.<InitRoleItem>d__13 <InitRoleItem>d__;
			<InitRoleItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRoleItem>d__.<>4__this = this;
			<InitRoleItem>d__.roleItem = roleItem;
			<InitRoleItem>d__.<>1__state = -1;
			<InitRoleItem>d__.<>t__builder.Start<PhantomArenaOwnArea.<InitRoleItem>d__13>(ref <InitRoleItem>d__);
			return <InitRoleItem>d__.<>t__builder.Task;
		}

		// Token: 0x06036346 RID: 222022 RVA: 0x00CD2C40 File Offset: 0x00CD0E40
		private UniTask InitDrawCardCurveX()
		{
			PhantomArenaOwnArea.<InitDrawCardCurveX>d__14 <InitDrawCardCurveX>d__;
			<InitDrawCardCurveX>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDrawCardCurveX>d__.<>4__this = this;
			<InitDrawCardCurveX>d__.<>1__state = -1;
			<InitDrawCardCurveX>d__.<>t__builder.Start<PhantomArenaOwnArea.<InitDrawCardCurveX>d__14>(ref <InitDrawCardCurveX>d__);
			return <InitDrawCardCurveX>d__.<>t__builder.Task;
		}

		// Token: 0x06036347 RID: 222023 RVA: 0x00CD2C84 File Offset: 0x00CD0E84
		private UniTask InitDrawCardCurveY()
		{
			PhantomArenaOwnArea.<InitDrawCardCurveY>d__15 <InitDrawCardCurveY>d__;
			<InitDrawCardCurveY>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDrawCardCurveY>d__.<>4__this = this;
			<InitDrawCardCurveY>d__.<>1__state = -1;
			<InitDrawCardCurveY>d__.<>t__builder.Start<PhantomArenaOwnArea.<InitDrawCardCurveY>d__15>(ref <InitDrawCardCurveY>d__);
			return <InitDrawCardCurveY>d__.<>t__builder.Task;
		}

		// Token: 0x06036348 RID: 222024 RVA: 0x00CD2CC8 File Offset: 0x00CD0EC8
		private UniTask InitDiscardCardCurveX()
		{
			PhantomArenaOwnArea.<InitDiscardCardCurveX>d__16 <InitDiscardCardCurveX>d__;
			<InitDiscardCardCurveX>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDiscardCardCurveX>d__.<>4__this = this;
			<InitDiscardCardCurveX>d__.<>1__state = -1;
			<InitDiscardCardCurveX>d__.<>t__builder.Start<PhantomArenaOwnArea.<InitDiscardCardCurveX>d__16>(ref <InitDiscardCardCurveX>d__);
			return <InitDiscardCardCurveX>d__.<>t__builder.Task;
		}

		// Token: 0x06036349 RID: 222025 RVA: 0x00CD2D0C File Offset: 0x00CD0F0C
		private UniTask InitDiscardCardCurveY()
		{
			PhantomArenaOwnArea.<InitDiscardCardCurveY>d__17 <InitDiscardCardCurveY>d__;
			<InitDiscardCardCurveY>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDiscardCardCurveY>d__.<>4__this = this;
			<InitDiscardCardCurveY>d__.<>1__state = -1;
			<InitDiscardCardCurveY>d__.<>t__builder.Start<PhantomArenaOwnArea.<InitDiscardCardCurveY>d__17>(ref <InitDiscardCardCurveY>d__);
			return <InitDiscardCardCurveY>d__.<>t__builder.Task;
		}

		// Token: 0x0603634A RID: 222026 RVA: 0x00CD2D50 File Offset: 0x00CD0F50
		private UniTask InitMoveLocationCurve()
		{
			PhantomArenaOwnArea.<InitMoveLocationCurve>d__18 <InitMoveLocationCurve>d__;
			<InitMoveLocationCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMoveLocationCurve>d__.<>4__this = this;
			<InitMoveLocationCurve>d__.<>1__state = -1;
			<InitMoveLocationCurve>d__.<>t__builder.Start<PhantomArenaOwnArea.<InitMoveLocationCurve>d__18>(ref <InitMoveLocationCurve>d__);
			return <InitMoveLocationCurve>d__.<>t__builder.Task;
		}

		// Token: 0x0603634B RID: 222027 RVA: 0x00CD2D94 File Offset: 0x00CD0F94
		private UniTask InitRecycleCurve()
		{
			PhantomArenaOwnArea.<InitRecycleCurve>d__19 <InitRecycleCurve>d__;
			<InitRecycleCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRecycleCurve>d__.<>4__this = this;
			<InitRecycleCurve>d__.<>1__state = -1;
			<InitRecycleCurve>d__.<>t__builder.Start<PhantomArenaOwnArea.<InitRecycleCurve>d__19>(ref <InitRecycleCurve>d__);
			return <InitRecycleCurve>d__.<>t__builder.Task;
		}

		// Token: 0x0603634C RID: 222028 RVA: 0x00CD2DD8 File Offset: 0x00CD0FD8
		private UniTask InitCardCurve()
		{
			PhantomArenaOwnArea.<InitCardCurve>d__20 <InitCardCurve>d__;
			<InitCardCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCardCurve>d__.<>4__this = this;
			<InitCardCurve>d__.<>1__state = -1;
			<InitCardCurve>d__.<>t__builder.Start<PhantomArenaOwnArea.<InitCardCurve>d__20>(ref <InitCardCurve>d__);
			return <InitCardCurve>d__.<>t__builder.Task;
		}

		// Token: 0x0603634D RID: 222029 RVA: 0x00CD2E1B File Offset: 0x00CD101B
		private void RefreshTipsActiveByHandDrag(PhantomArenaCard card)
		{
			if (this.HandArea.CheckCardOutHandArea(card))
			{
				this.ViewProxy.HideCardTips();
				this.ViewProxy.CancelSelectedCard();
			}
		}

		// Token: 0x0603634E RID: 222030 RVA: 0x00CD2E41 File Offset: 0x00CD1041
		private void RefreshTipsActiveByFunctionalDrag(PhantomArenaAreaProxyBase cardProxy)
		{
			if (cardProxy.Distance > 100.0)
			{
				this.ViewProxy.HideCardTips();
				this.ViewProxy.CancelSelectedCard();
			}
		}

		// Token: 0x0603634F RID: 222031 RVA: 0x00CD2E6C File Offset: 0x00CD106C
		public UniTask InitArea(UUIItem handAreaItem, UUIItem functionalAreaItem, UUIItem roleItem, UUIItem filedAreaItem)
		{
			PhantomArenaOwnArea.<InitArea>d__23 <InitArea>d__;
			<InitArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitArea>d__.<>4__this = this;
			<InitArea>d__.handAreaItem = handAreaItem;
			<InitArea>d__.functionalAreaItem = functionalAreaItem;
			<InitArea>d__.roleItem = roleItem;
			<InitArea>d__.filedAreaItem = filedAreaItem;
			<InitArea>d__.<>1__state = -1;
			<InitArea>d__.<>t__builder.Start<PhantomArenaOwnArea.<InitArea>d__23>(ref <InitArea>d__);
			return <InitArea>d__.<>t__builder.Task;
		}

		// Token: 0x06036350 RID: 222032 RVA: 0x00CD2ED0 File Offset: 0x00CD10D0
		public void RegisterViewProxy(PhantomArenaBattleProxy proxy)
		{
			this.ViewProxy = proxy;
		}

		// Token: 0x06036351 RID: 222033 RVA: 0x00CD2ED9 File Offset: 0x00CD10D9
		public void RefreshAll(bool isFromWorldDone)
		{
			this.RolePanel.RefreshAll(isFromWorldDone);
			this.FunctionalArea.RefreshAllBattleCard();
			this.RefreshFiledArea().Forget();
		}

		// Token: 0x06036352 RID: 222034 RVA: 0x00CD2EFD File Offset: 0x00CD10FD
		public bool IsCanDragCard(int id)
		{
			return !PhantomArenaBattleModel.Instance.InWaitCallCardIdList(id) && !this.ViewProxy.InCantDragState();
		}

		// Token: 0x06036353 RID: 222035 RVA: 0x00CD2F20 File Offset: 0x00CD1120
		public void CardClick(int id)
		{
			if (this.HandArea.IsLayoutHoist)
			{
				PhantomCardData handCardDataByCardId = PhantomArenaBattleModel.Instance.OwnData.GetHandCardDataByCardId(id);
				this.ViewProxy.ShowCardTips(handCardDataByCardId, true);
				this.ViewProxy.SetSelectedCardId(id, EPhantomArenaCardClickFromType.OwnHand);
				return;
			}
			this.HandArea.HoistLayout();
		}

		// Token: 0x06036354 RID: 222036 RVA: 0x00CD2F71 File Offset: 0x00CD1171
		public void HideCardList()
		{
			this.ViewProxy.HideCardTips();
			this.ViewProxy.CancelSelectedCard();
			if (this.HandArea.IsLayoutHoist)
			{
				this.HandArea.LowerLayout();
			}
		}

		// Token: 0x06036355 RID: 222037 RVA: 0x00CD2FA1 File Offset: 0x00CD11A1
		private void HandleLayoutHoistByBeginDrag()
		{
			this.LastLayoutHoistState = this.HandArea.IsLayoutHoist;
			if (this.LastLayoutHoistState)
			{
				this.HandArea.LowerLayout();
			}
		}

		// Token: 0x06036356 RID: 222038 RVA: 0x00CD2FC7 File Offset: 0x00CD11C7
		private void HandleLayoutHoistByFinishDrag()
		{
			if (this.LastLayoutHoistState)
			{
				this.HandArea.HoistLayout();
			}
		}

		// Token: 0x06036357 RID: 222039 RVA: 0x00CD2FDC File Offset: 0x00CD11DC
		private void HandleLayoutHoistByFailDrag()
		{
			if (this.LastLayoutHoistState)
			{
				this.HandArea.HoistLayout();
			}
		}

		// Token: 0x06036358 RID: 222040 RVA: 0x00CD2FF1 File Offset: 0x00CD11F1
		private void CommonBeginDragLogic(PhantomArenaCard card)
		{
			this.ViewProxy.CardRecycle.RefreshCardRecycleArea(card);
			this.ViewProxy.CardRecycle.SetEffectActive(ERecycleSequenceType.Active);
			this.ViewProxy.BanButtonClickModule.BanButtonList("Drag");
		}

		// Token: 0x06036359 RID: 222041 RVA: 0x00CD302C File Offset: 0x00CD122C
		public void CardBeginDragByHand(PhantomArenaCard card)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "从手上拖动卡牌";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", card.Data.CardId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			card.SetUiParent(this.ViewProxy.GetDragRootItem(), false);
			this.FunctionalArea.RefreshStateByDragCard(card);
			this.CommonBeginDragLogic(card);
			this.HandleLayoutHoistByBeginDrag();
		}

		// Token: 0x0603635A RID: 222042 RVA: 0x00CD30A0 File Offset: 0x00CD12A0
		public unsafe void CardBeginDragByFunctional(PhantomArenaCard card)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "从场上拖动卡牌";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", card.Data.CardId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Index", card.Data.Index);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			card.SetUiParent(this.ViewProxy.GetDragRootItem(), false);
			this.FunctionalArea.RefreshStateByDragCard(card);
			this.CommonBeginDragLogic(card);
		}

		// Token: 0x0603635B RID: 222043 RVA: 0x00CD3148 File Offset: 0x00CD1348
		public UniTask HandCardBeginDragByGamepad(PhantomArenaCard card, int slotIndex, bool needDragUpTween)
		{
			PhantomArenaOwnArea.<HandCardBeginDragByGamepad>d__35 <HandCardBeginDragByGamepad>d__;
			<HandCardBeginDragByGamepad>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandCardBeginDragByGamepad>d__.<>4__this = this;
			<HandCardBeginDragByGamepad>d__.card = card;
			<HandCardBeginDragByGamepad>d__.slotIndex = slotIndex;
			<HandCardBeginDragByGamepad>d__.needDragUpTween = needDragUpTween;
			<HandCardBeginDragByGamepad>d__.<>1__state = -1;
			<HandCardBeginDragByGamepad>d__.<>t__builder.Start<PhantomArenaOwnArea.<HandCardBeginDragByGamepad>d__35>(ref <HandCardBeginDragByGamepad>d__);
			return <HandCardBeginDragByGamepad>d__.<>t__builder.Task;
		}

		// Token: 0x0603635C RID: 222044 RVA: 0x00CD31A4 File Offset: 0x00CD13A4
		public UniTask BattleCardBeginDragByGamepad(PhantomArenaCard card, int slotIndex, bool needDragUpTween)
		{
			PhantomArenaOwnArea.<BattleCardBeginDragByGamepad>d__36 <BattleCardBeginDragByGamepad>d__;
			<BattleCardBeginDragByGamepad>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<BattleCardBeginDragByGamepad>d__.<>4__this = this;
			<BattleCardBeginDragByGamepad>d__.card = card;
			<BattleCardBeginDragByGamepad>d__.slotIndex = slotIndex;
			<BattleCardBeginDragByGamepad>d__.needDragUpTween = needDragUpTween;
			<BattleCardBeginDragByGamepad>d__.<>1__state = -1;
			<BattleCardBeginDragByGamepad>d__.<>t__builder.Start<PhantomArenaOwnArea.<BattleCardBeginDragByGamepad>d__36>(ref <BattleCardBeginDragByGamepad>d__);
			return <BattleCardBeginDragByGamepad>d__.<>t__builder.Task;
		}

		// Token: 0x0603635D RID: 222045 RVA: 0x00CD31FF File Offset: 0x00CD13FF
		public void CardDraggingByHand(PhantomArenaCard card)
		{
			this.FunctionalArea.RefreshStateByDragCard(card);
			this.ViewProxy.CardRecycle.RefreshCardRecycleArea(card);
			this.RefreshTipsActiveByHandDrag(card);
		}

		// Token: 0x0603635E RID: 222046 RVA: 0x00CD3225 File Offset: 0x00CD1425
		public void CardDraggingByFunctional(PhantomArenaAreaProxyBase cardProxy)
		{
			this.FunctionalArea.RefreshStateByDragCard(cardProxy.Card);
			this.ViewProxy.CardRecycle.RefreshCardRecycleArea(cardProxy.Card);
			this.RefreshTipsActiveByFunctionalDrag(cardProxy);
		}

		// Token: 0x0603635F RID: 222047 RVA: 0x00CD3258 File Offset: 0x00CD1458
		[NullableContext(0)]
		public UniTask<bool> CardEndDragByHand([Nullable(1)] PhantomArenaCard card)
		{
			PhantomArenaOwnArea.<CardEndDragByHand>d__39 <CardEndDragByHand>d__;
			<CardEndDragByHand>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CardEndDragByHand>d__.<>4__this = this;
			<CardEndDragByHand>d__.card = card;
			<CardEndDragByHand>d__.<>1__state = -1;
			<CardEndDragByHand>d__.<>t__builder.Start<PhantomArenaOwnArea.<CardEndDragByHand>d__39>(ref <CardEndDragByHand>d__);
			return <CardEndDragByHand>d__.<>t__builder.Task;
		}

		// Token: 0x06036360 RID: 222048 RVA: 0x00CD32A4 File Offset: 0x00CD14A4
		[NullableContext(0)]
		public UniTask<bool> CardEndDragByFunctional([Nullable(1)] PhantomArenaCard card, int index)
		{
			PhantomArenaOwnArea.<CardEndDragByFunctional>d__40 <CardEndDragByFunctional>d__;
			<CardEndDragByFunctional>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CardEndDragByFunctional>d__.<>4__this = this;
			<CardEndDragByFunctional>d__.card = card;
			<CardEndDragByFunctional>d__.index = index;
			<CardEndDragByFunctional>d__.<>1__state = -1;
			<CardEndDragByFunctional>d__.<>t__builder.Start<PhantomArenaOwnArea.<CardEndDragByFunctional>d__40>(ref <CardEndDragByFunctional>d__);
			return <CardEndDragByFunctional>d__.<>t__builder.Task;
		}

		// Token: 0x06036361 RID: 222049 RVA: 0x00CD32F8 File Offset: 0x00CD14F8
		public UniTask MoveHandCardToRecycle(PhantomArenaCard card, int slotIndex)
		{
			PhantomArenaOwnArea.<MoveHandCardToRecycle>d__41 <MoveHandCardToRecycle>d__;
			<MoveHandCardToRecycle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<MoveHandCardToRecycle>d__.<>4__this = this;
			<MoveHandCardToRecycle>d__.card = card;
			<MoveHandCardToRecycle>d__.slotIndex = slotIndex;
			<MoveHandCardToRecycle>d__.<>1__state = -1;
			<MoveHandCardToRecycle>d__.<>t__builder.Start<PhantomArenaOwnArea.<MoveHandCardToRecycle>d__41>(ref <MoveHandCardToRecycle>d__);
			return <MoveHandCardToRecycle>d__.<>t__builder.Task;
		}

		// Token: 0x06036362 RID: 222050 RVA: 0x00CD334C File Offset: 0x00CD154C
		public UniTask MoveFunctionalCardToRecycle(PhantomArenaCard card, int index, int slotIndex)
		{
			PhantomArenaOwnArea.<MoveFunctionalCardToRecycle>d__42 <MoveFunctionalCardToRecycle>d__;
			<MoveFunctionalCardToRecycle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<MoveFunctionalCardToRecycle>d__.<>4__this = this;
			<MoveFunctionalCardToRecycle>d__.card = card;
			<MoveFunctionalCardToRecycle>d__.index = index;
			<MoveFunctionalCardToRecycle>d__.slotIndex = slotIndex;
			<MoveFunctionalCardToRecycle>d__.<>1__state = -1;
			<MoveFunctionalCardToRecycle>d__.<>t__builder.Start<PhantomArenaOwnArea.<MoveFunctionalCardToRecycle>d__42>(ref <MoveFunctionalCardToRecycle>d__);
			return <MoveFunctionalCardToRecycle>d__.<>t__builder.Task;
		}

		// Token: 0x06036363 RID: 222051 RVA: 0x00CD33A8 File Offset: 0x00CD15A8
		private void CommonGamepadResetSelectCardLogic(PhantomArenaCard card, int slotIndex)
		{
			PhantomArenaAreaProxyBase cardProxyByIndex = this.FunctionalArea.GetCardProxyByIndex(slotIndex);
			if (cardProxyByIndex != null)
			{
				cardProxyByIndex.SetHoverStateActive(false);
			}
			this.FunctionalArea.SetAllCardProxyUseActiveState(false, card);
			this.ViewProxy.CardRecycle.SetEffectActive(ERecycleSequenceType.DisActive);
			this.ViewProxy.BanButtonClickModule.ResumeButtonList("Drag");
		}

		// Token: 0x06036364 RID: 222052 RVA: 0x00CD3400 File Offset: 0x00CD1600
		public UniTask ResetSelectCardToHand(PhantomArenaCard card, int slotIndex)
		{
			PhantomArenaOwnArea.<ResetSelectCardToHand>d__44 <ResetSelectCardToHand>d__;
			<ResetSelectCardToHand>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResetSelectCardToHand>d__.<>4__this = this;
			<ResetSelectCardToHand>d__.card = card;
			<ResetSelectCardToHand>d__.slotIndex = slotIndex;
			<ResetSelectCardToHand>d__.<>1__state = -1;
			<ResetSelectCardToHand>d__.<>t__builder.Start<PhantomArenaOwnArea.<ResetSelectCardToHand>d__44>(ref <ResetSelectCardToHand>d__);
			return <ResetSelectCardToHand>d__.<>t__builder.Task;
		}

		// Token: 0x06036365 RID: 222053 RVA: 0x00CD3454 File Offset: 0x00CD1654
		public UniTask ResetSelectCardToFunctional(PhantomArenaCard card, int slotIndex)
		{
			PhantomArenaOwnArea.<ResetSelectCardToFunctional>d__45 <ResetSelectCardToFunctional>d__;
			<ResetSelectCardToFunctional>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResetSelectCardToFunctional>d__.<>4__this = this;
			<ResetSelectCardToFunctional>d__.card = card;
			<ResetSelectCardToFunctional>d__.slotIndex = slotIndex;
			<ResetSelectCardToFunctional>d__.<>1__state = -1;
			<ResetSelectCardToFunctional>d__.<>t__builder.Start<PhantomArenaOwnArea.<ResetSelectCardToFunctional>d__45>(ref <ResetSelectCardToFunctional>d__);
			return <ResetSelectCardToFunctional>d__.<>t__builder.Task;
		}

		// Token: 0x06036366 RID: 222054 RVA: 0x00CD34A7 File Offset: 0x00CD16A7
		public void ResetFunctionalToHand(PhantomArenaCard card, int index)
		{
			this.FunctionalArea.RemoveCard(index);
			this.HandArea.FunctionalToHand(card).Forget();
		}

		// Token: 0x06036367 RID: 222055 RVA: 0x00CD34C8 File Offset: 0x00CD16C8
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<PhantomArenaCard> CreatePhantomArenaCard(PhantomCardData cardData, UUIItem rootItem)
		{
			PhantomArenaOwnArea.<CreatePhantomArenaCard>d__47 <CreatePhantomArenaCard>d__;
			<CreatePhantomArenaCard>d__.<>t__builder = AsyncUniTaskMethodBuilder<PhantomArenaCard>.Create();
			<CreatePhantomArenaCard>d__.<>4__this = this;
			<CreatePhantomArenaCard>d__.cardData = cardData;
			<CreatePhantomArenaCard>d__.rootItem = rootItem;
			<CreatePhantomArenaCard>d__.<>1__state = -1;
			<CreatePhantomArenaCard>d__.<>t__builder.Start<PhantomArenaOwnArea.<CreatePhantomArenaCard>d__47>(ref <CreatePhantomArenaCard>d__);
			return <CreatePhantomArenaCard>d__.<>t__builder.Task;
		}

		// Token: 0x06036368 RID: 222056 RVA: 0x00CD351C File Offset: 0x00CD171C
		private UniTask CallLibraryCardToFight(PhantomCardData cardData, UUIItem fromItem, PhantomArenaAreaProxyBase proxy)
		{
			PhantomArenaOwnArea.<CallLibraryCardToFight>d__48 <CallLibraryCardToFight>d__;
			<CallLibraryCardToFight>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CallLibraryCardToFight>d__.<>4__this = this;
			<CallLibraryCardToFight>d__.cardData = cardData;
			<CallLibraryCardToFight>d__.fromItem = fromItem;
			<CallLibraryCardToFight>d__.proxy = proxy;
			<CallLibraryCardToFight>d__.<>1__state = -1;
			<CallLibraryCardToFight>d__.<>t__builder.Start<PhantomArenaOwnArea.<CallLibraryCardToFight>d__48>(ref <CallLibraryCardToFight>d__);
			return <CallLibraryCardToFight>d__.<>t__builder.Task;
		}

		// Token: 0x06036369 RID: 222057 RVA: 0x00CD3578 File Offset: 0x00CD1778
		private UniTask CallHandCardToFight(PhantomCardData cardData, PhantomArenaAreaProxyBase proxy)
		{
			PhantomArenaOwnArea.<CallHandCardToFight>d__49 <CallHandCardToFight>d__;
			<CallHandCardToFight>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CallHandCardToFight>d__.<>4__this = this;
			<CallHandCardToFight>d__.cardData = cardData;
			<CallHandCardToFight>d__.proxy = proxy;
			<CallHandCardToFight>d__.<>1__state = -1;
			<CallHandCardToFight>d__.<>t__builder.Start<PhantomArenaOwnArea.<CallHandCardToFight>d__49>(ref <CallHandCardToFight>d__);
			return <CallHandCardToFight>d__.<>t__builder.Task;
		}

		// Token: 0x0603636A RID: 222058 RVA: 0x00CD35CC File Offset: 0x00CD17CC
		public UniTask CallHandCardListToFight(PhantomBattleFighterInfo[] cardInfoList)
		{
			PhantomArenaOwnArea.<CallHandCardListToFight>d__50 <CallHandCardListToFight>d__;
			<CallHandCardListToFight>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CallHandCardListToFight>d__.<>4__this = this;
			<CallHandCardListToFight>d__.cardInfoList = cardInfoList;
			<CallHandCardListToFight>d__.<>1__state = -1;
			<CallHandCardListToFight>d__.<>t__builder.Start<PhantomArenaOwnArea.<CallHandCardListToFight>d__50>(ref <CallHandCardListToFight>d__);
			return <CallHandCardListToFight>d__.<>t__builder.Task;
		}

		// Token: 0x0603636B RID: 222059 RVA: 0x00CD3618 File Offset: 0x00CD1818
		public UniTask CallLibraryCardListToFight(PhantomBattleFighterInfo[] cardInfoList)
		{
			PhantomArenaOwnArea.<CallLibraryCardListToFight>d__51 <CallLibraryCardListToFight>d__;
			<CallLibraryCardListToFight>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CallLibraryCardListToFight>d__.<>4__this = this;
			<CallLibraryCardListToFight>d__.cardInfoList = cardInfoList;
			<CallLibraryCardListToFight>d__.<>1__state = -1;
			<CallLibraryCardListToFight>d__.<>t__builder.Start<PhantomArenaOwnArea.<CallLibraryCardListToFight>d__51>(ref <CallLibraryCardListToFight>d__);
			return <CallLibraryCardListToFight>d__.<>t__builder.Task;
		}

		// Token: 0x0603636C RID: 222060 RVA: 0x00CD3664 File Offset: 0x00CD1864
		private UniTask InitFiledArea(UUIItem filedAreaItem)
		{
			PhantomArenaOwnArea.<InitFiledArea>d__54 <InitFiledArea>d__;
			<InitFiledArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitFiledArea>d__.<>4__this = this;
			<InitFiledArea>d__.filedAreaItem = filedAreaItem;
			<InitFiledArea>d__.<>1__state = -1;
			<InitFiledArea>d__.<>t__builder.Start<PhantomArenaOwnArea.<InitFiledArea>d__54>(ref <InitFiledArea>d__);
			return <InitFiledArea>d__.<>t__builder.Task;
		}

		// Token: 0x0603636D RID: 222061 RVA: 0x00CD36B0 File Offset: 0x00CD18B0
		private UniTask ShowFieldEffect()
		{
			PhantomArenaOwnArea.<ShowFieldEffect>d__55 <ShowFieldEffect>d__;
			<ShowFieldEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowFieldEffect>d__.<>4__this = this;
			<ShowFieldEffect>d__.<>1__state = -1;
			<ShowFieldEffect>d__.<>t__builder.Start<PhantomArenaOwnArea.<ShowFieldEffect>d__55>(ref <ShowFieldEffect>d__);
			return <ShowFieldEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0603636E RID: 222062 RVA: 0x00CD36F4 File Offset: 0x00CD18F4
		public UniTask RefreshFiledArea()
		{
			PhantomArenaOwnArea.<RefreshFiledArea>d__56 <RefreshFiledArea>d__;
			<RefreshFiledArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshFiledArea>d__.<>4__this = this;
			<RefreshFiledArea>d__.<>1__state = -1;
			<RefreshFiledArea>d__.<>t__builder.Start<PhantomArenaOwnArea.<RefreshFiledArea>d__56>(ref <RefreshFiledArea>d__);
			return <RefreshFiledArea>d__.<>t__builder.Task;
		}

		// Token: 0x0603636F RID: 222063 RVA: 0x00CD3738 File Offset: 0x00CD1938
		public UniTask ShowField()
		{
			PhantomArenaOwnArea.<ShowField>d__57 <ShowField>d__;
			<ShowField>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowField>d__.<>4__this = this;
			<ShowField>d__.<>1__state = -1;
			<ShowField>d__.<>t__builder.Start<PhantomArenaOwnArea.<ShowField>d__57>(ref <ShowField>d__);
			return <ShowField>d__.<>t__builder.Task;
		}

		// Token: 0x06036370 RID: 222064 RVA: 0x00CD377C File Offset: 0x00CD197C
		public UniTask ShowFiledArea()
		{
			PhantomArenaOwnArea.<ShowFiledArea>d__58 <ShowFiledArea>d__;
			<ShowFiledArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowFiledArea>d__.<>4__this = this;
			<ShowFiledArea>d__.<>1__state = -1;
			<ShowFiledArea>d__.<>t__builder.Start<PhantomArenaOwnArea.<ShowFiledArea>d__58>(ref <ShowFiledArea>d__);
			return <ShowFiledArea>d__.<>t__builder.Task;
		}

		// Token: 0x06036371 RID: 222065 RVA: 0x00CD37C0 File Offset: 0x00CD19C0
		public UniTask UnlockFiledArea()
		{
			PhantomArenaOwnArea.<UnlockFiledArea>d__59 <UnlockFiledArea>d__;
			<UnlockFiledArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UnlockFiledArea>d__.<>4__this = this;
			<UnlockFiledArea>d__.<>1__state = -1;
			<UnlockFiledArea>d__.<>t__builder.Start<PhantomArenaOwnArea.<UnlockFiledArea>d__59>(ref <UnlockFiledArea>d__);
			return <UnlockFiledArea>d__.<>t__builder.Task;
		}

		// Token: 0x06036372 RID: 222066 RVA: 0x00CD3803 File Offset: 0x00CD1A03
		public void SwitchFieldState(bool isGamepad)
		{
			PhantomArenaFieldArea filedArea = this.FiledArea;
			if (filedArea != null)
			{
				filedArea.SwitchFieldState(!isGamepad);
			}
			this.RolePanel.SwitchFieldState(isGamepad);
		}

		// Token: 0x0401CAAF RID: 117423
		public PhantomArenaBattleProxy ViewProxy;

		// Token: 0x0401CAB0 RID: 117424
		public PhantomArenaHandArea HandArea;

		// Token: 0x0401CAB1 RID: 117425
		public PhantomArenaFunctionalArea FunctionalArea;

		// Token: 0x0401CAB2 RID: 117426
		public PhantomArenaOwnRolePanel RolePanel;

		// Token: 0x0401CAB3 RID: 117427
		public UCurveFloat DrawCardCurveX;

		// Token: 0x0401CAB4 RID: 117428
		public UCurveFloat DrawCardCurveY;

		// Token: 0x0401CAB5 RID: 117429
		public UCurveFloat DiscardCardCurveX;

		// Token: 0x0401CAB6 RID: 117430
		public UCurveFloat DiscardCardCurveY;

		// Token: 0x0401CAB7 RID: 117431
		public UCurveFloat MoveLocationCurve;

		// Token: 0x0401CAB8 RID: 117432
		public UCurveFloat RecycleCurve;

		// Token: 0x0401CAB9 RID: 117433
		private bool LastLayoutHoistState;

		// Token: 0x0401CABA RID: 117434
		public PhantomArenaFieldArea FiledArea;

		// Token: 0x0401CABB RID: 117435
		public PhantomArenaFieldEffectItem FieldEffect;
	}
}

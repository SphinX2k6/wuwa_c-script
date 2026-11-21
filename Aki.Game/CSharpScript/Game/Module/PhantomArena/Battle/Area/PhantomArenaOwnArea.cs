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
	// Token: 0x02004298 RID: 17048
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaOwnArea
	{
		// Token: 0x0602B23E RID: 176702 RVA: 0x00C20284 File Offset: 0x00C1E484
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

		// Token: 0x0602B23F RID: 176703 RVA: 0x00C202D0 File Offset: 0x00C1E4D0
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

		// Token: 0x0602B240 RID: 176704 RVA: 0x00C2031C File Offset: 0x00C1E51C
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

		// Token: 0x0602B241 RID: 176705 RVA: 0x00C20368 File Offset: 0x00C1E568
		private UniTask InitDrawCardCurveX()
		{
			PhantomArenaOwnArea.<InitDrawCardCurveX>d__14 <InitDrawCardCurveX>d__;
			<InitDrawCardCurveX>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDrawCardCurveX>d__.<>4__this = this;
			<InitDrawCardCurveX>d__.<>1__state = -1;
			<InitDrawCardCurveX>d__.<>t__builder.Start<PhantomArenaOwnArea.<InitDrawCardCurveX>d__14>(ref <InitDrawCardCurveX>d__);
			return <InitDrawCardCurveX>d__.<>t__builder.Task;
		}

		// Token: 0x0602B242 RID: 176706 RVA: 0x00C203AC File Offset: 0x00C1E5AC
		private UniTask InitDrawCardCurveY()
		{
			PhantomArenaOwnArea.<InitDrawCardCurveY>d__15 <InitDrawCardCurveY>d__;
			<InitDrawCardCurveY>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDrawCardCurveY>d__.<>4__this = this;
			<InitDrawCardCurveY>d__.<>1__state = -1;
			<InitDrawCardCurveY>d__.<>t__builder.Start<PhantomArenaOwnArea.<InitDrawCardCurveY>d__15>(ref <InitDrawCardCurveY>d__);
			return <InitDrawCardCurveY>d__.<>t__builder.Task;
		}

		// Token: 0x0602B243 RID: 176707 RVA: 0x00C203F0 File Offset: 0x00C1E5F0
		private UniTask InitDiscardCardCurveX()
		{
			PhantomArenaOwnArea.<InitDiscardCardCurveX>d__16 <InitDiscardCardCurveX>d__;
			<InitDiscardCardCurveX>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDiscardCardCurveX>d__.<>4__this = this;
			<InitDiscardCardCurveX>d__.<>1__state = -1;
			<InitDiscardCardCurveX>d__.<>t__builder.Start<PhantomArenaOwnArea.<InitDiscardCardCurveX>d__16>(ref <InitDiscardCardCurveX>d__);
			return <InitDiscardCardCurveX>d__.<>t__builder.Task;
		}

		// Token: 0x0602B244 RID: 176708 RVA: 0x00C20434 File Offset: 0x00C1E634
		private UniTask InitDiscardCardCurveY()
		{
			PhantomArenaOwnArea.<InitDiscardCardCurveY>d__17 <InitDiscardCardCurveY>d__;
			<InitDiscardCardCurveY>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDiscardCardCurveY>d__.<>4__this = this;
			<InitDiscardCardCurveY>d__.<>1__state = -1;
			<InitDiscardCardCurveY>d__.<>t__builder.Start<PhantomArenaOwnArea.<InitDiscardCardCurveY>d__17>(ref <InitDiscardCardCurveY>d__);
			return <InitDiscardCardCurveY>d__.<>t__builder.Task;
		}

		// Token: 0x0602B245 RID: 176709 RVA: 0x00C20478 File Offset: 0x00C1E678
		private UniTask InitMoveLocationCurve()
		{
			PhantomArenaOwnArea.<InitMoveLocationCurve>d__18 <InitMoveLocationCurve>d__;
			<InitMoveLocationCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMoveLocationCurve>d__.<>4__this = this;
			<InitMoveLocationCurve>d__.<>1__state = -1;
			<InitMoveLocationCurve>d__.<>t__builder.Start<PhantomArenaOwnArea.<InitMoveLocationCurve>d__18>(ref <InitMoveLocationCurve>d__);
			return <InitMoveLocationCurve>d__.<>t__builder.Task;
		}

		// Token: 0x0602B246 RID: 176710 RVA: 0x00C204BC File Offset: 0x00C1E6BC
		private UniTask InitRecycleCurve()
		{
			PhantomArenaOwnArea.<InitRecycleCurve>d__19 <InitRecycleCurve>d__;
			<InitRecycleCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRecycleCurve>d__.<>4__this = this;
			<InitRecycleCurve>d__.<>1__state = -1;
			<InitRecycleCurve>d__.<>t__builder.Start<PhantomArenaOwnArea.<InitRecycleCurve>d__19>(ref <InitRecycleCurve>d__);
			return <InitRecycleCurve>d__.<>t__builder.Task;
		}

		// Token: 0x0602B247 RID: 176711 RVA: 0x00C20500 File Offset: 0x00C1E700
		private UniTask InitCardCurve()
		{
			PhantomArenaOwnArea.<InitCardCurve>d__20 <InitCardCurve>d__;
			<InitCardCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCardCurve>d__.<>4__this = this;
			<InitCardCurve>d__.<>1__state = -1;
			<InitCardCurve>d__.<>t__builder.Start<PhantomArenaOwnArea.<InitCardCurve>d__20>(ref <InitCardCurve>d__);
			return <InitCardCurve>d__.<>t__builder.Task;
		}

		// Token: 0x0602B248 RID: 176712 RVA: 0x00C20543 File Offset: 0x00C1E743
		private void RefreshTipsActiveByHandDrag(PhantomArenaCard card)
		{
			if (this.HandArea.CheckCardOutHandArea(card))
			{
				this.ViewProxy.HideCardTips();
				this.ViewProxy.CancelSelectedCard();
			}
		}

		// Token: 0x0602B249 RID: 176713 RVA: 0x00C20569 File Offset: 0x00C1E769
		private void RefreshTipsActiveByFunctionalDrag(PhantomArenaAreaProxyBase cardProxy)
		{
			if (cardProxy.Distance > 100.0)
			{
				this.ViewProxy.HideCardTips();
				this.ViewProxy.CancelSelectedCard();
			}
		}

		// Token: 0x0602B24A RID: 176714 RVA: 0x00C20594 File Offset: 0x00C1E794
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

		// Token: 0x0602B24B RID: 176715 RVA: 0x00C205F8 File Offset: 0x00C1E7F8
		public void RegisterViewProxy(PhantomArenaBattleProxy proxy)
		{
			this.ViewProxy = proxy;
		}

		// Token: 0x0602B24C RID: 176716 RVA: 0x00C20601 File Offset: 0x00C1E801
		public void RefreshAll(bool isFromWorldDone)
		{
			this.RolePanel.RefreshAll(isFromWorldDone);
			this.FunctionalArea.RefreshAllBattleCard();
			this.RefreshFiledArea().Forget();
		}

		// Token: 0x0602B24D RID: 176717 RVA: 0x00C20625 File Offset: 0x00C1E825
		public bool IsCanDragCard(int id)
		{
			return !PhantomArenaBattleModel.Instance.InWaitCallCardIdList(id) && !this.ViewProxy.InCantDragState();
		}

		// Token: 0x0602B24E RID: 176718 RVA: 0x00C20648 File Offset: 0x00C1E848
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

		// Token: 0x0602B24F RID: 176719 RVA: 0x00C20699 File Offset: 0x00C1E899
		public void HideCardList()
		{
			this.ViewProxy.HideCardTips();
			this.ViewProxy.CancelSelectedCard();
			if (this.HandArea.IsLayoutHoist)
			{
				this.HandArea.LowerLayout();
			}
		}

		// Token: 0x0602B250 RID: 176720 RVA: 0x00C206C9 File Offset: 0x00C1E8C9
		private void HandleLayoutHoistByBeginDrag()
		{
			this.LastLayoutHoistState = this.HandArea.IsLayoutHoist;
			if (this.LastLayoutHoistState)
			{
				this.HandArea.LowerLayout();
			}
		}

		// Token: 0x0602B251 RID: 176721 RVA: 0x00C206EF File Offset: 0x00C1E8EF
		private void HandleLayoutHoistByFinishDrag()
		{
			if (this.LastLayoutHoistState)
			{
				this.HandArea.HoistLayout();
			}
		}

		// Token: 0x0602B252 RID: 176722 RVA: 0x00C20704 File Offset: 0x00C1E904
		private void HandleLayoutHoistByFailDrag()
		{
			if (this.LastLayoutHoistState)
			{
				this.HandArea.HoistLayout();
			}
		}

		// Token: 0x0602B253 RID: 176723 RVA: 0x00C20719 File Offset: 0x00C1E919
		private void CommonBeginDragLogic(PhantomArenaCard card)
		{
			this.ViewProxy.CardRecycle.RefreshCardRecycleArea(card);
			this.ViewProxy.CardRecycle.SetEffectActive(ERecycleSequenceType.Active);
			this.ViewProxy.BanButtonClickModule.BanButtonList("Drag");
		}

		// Token: 0x0602B254 RID: 176724 RVA: 0x00C20754 File Offset: 0x00C1E954
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

		// Token: 0x0602B255 RID: 176725 RVA: 0x00C207C8 File Offset: 0x00C1E9C8
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

		// Token: 0x0602B256 RID: 176726 RVA: 0x00C20870 File Offset: 0x00C1EA70
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

		// Token: 0x0602B257 RID: 176727 RVA: 0x00C208CC File Offset: 0x00C1EACC
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

		// Token: 0x0602B258 RID: 176728 RVA: 0x00C20927 File Offset: 0x00C1EB27
		public void CardDraggingByHand(PhantomArenaCard card)
		{
			this.FunctionalArea.RefreshStateByDragCard(card);
			this.ViewProxy.CardRecycle.RefreshCardRecycleArea(card);
			this.RefreshTipsActiveByHandDrag(card);
		}

		// Token: 0x0602B259 RID: 176729 RVA: 0x00C2094D File Offset: 0x00C1EB4D
		public void CardDraggingByFunctional(PhantomArenaAreaProxyBase cardProxy)
		{
			this.FunctionalArea.RefreshStateByDragCard(cardProxy.Card);
			this.ViewProxy.CardRecycle.RefreshCardRecycleArea(cardProxy.Card);
			this.RefreshTipsActiveByFunctionalDrag(cardProxy);
		}

		// Token: 0x0602B25A RID: 176730 RVA: 0x00C20980 File Offset: 0x00C1EB80
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

		// Token: 0x0602B25B RID: 176731 RVA: 0x00C209CC File Offset: 0x00C1EBCC
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

		// Token: 0x0602B25C RID: 176732 RVA: 0x00C20A20 File Offset: 0x00C1EC20
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

		// Token: 0x0602B25D RID: 176733 RVA: 0x00C20A74 File Offset: 0x00C1EC74
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

		// Token: 0x0602B25E RID: 176734 RVA: 0x00C20AD0 File Offset: 0x00C1ECD0
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

		// Token: 0x0602B25F RID: 176735 RVA: 0x00C20B28 File Offset: 0x00C1ED28
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

		// Token: 0x0602B260 RID: 176736 RVA: 0x00C20B7C File Offset: 0x00C1ED7C
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

		// Token: 0x0602B261 RID: 176737 RVA: 0x00C20BCF File Offset: 0x00C1EDCF
		public void ResetFunctionalToHand(PhantomArenaCard card, int index)
		{
			this.FunctionalArea.RemoveCard(index);
			this.HandArea.FunctionalToHand(card).Forget();
		}

		// Token: 0x0602B262 RID: 176738 RVA: 0x00C20BF0 File Offset: 0x00C1EDF0
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

		// Token: 0x0602B263 RID: 176739 RVA: 0x00C20C44 File Offset: 0x00C1EE44
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

		// Token: 0x0602B264 RID: 176740 RVA: 0x00C20CA0 File Offset: 0x00C1EEA0
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

		// Token: 0x0602B265 RID: 176741 RVA: 0x00C20CF4 File Offset: 0x00C1EEF4
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

		// Token: 0x0602B266 RID: 176742 RVA: 0x00C20D40 File Offset: 0x00C1EF40
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

		// Token: 0x0602B267 RID: 176743 RVA: 0x00C20D8C File Offset: 0x00C1EF8C
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

		// Token: 0x0602B268 RID: 176744 RVA: 0x00C20DD8 File Offset: 0x00C1EFD8
		private UniTask ShowFieldEffect()
		{
			PhantomArenaOwnArea.<ShowFieldEffect>d__55 <ShowFieldEffect>d__;
			<ShowFieldEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowFieldEffect>d__.<>4__this = this;
			<ShowFieldEffect>d__.<>1__state = -1;
			<ShowFieldEffect>d__.<>t__builder.Start<PhantomArenaOwnArea.<ShowFieldEffect>d__55>(ref <ShowFieldEffect>d__);
			return <ShowFieldEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602B269 RID: 176745 RVA: 0x00C20E1C File Offset: 0x00C1F01C
		public UniTask RefreshFiledArea()
		{
			PhantomArenaOwnArea.<RefreshFiledArea>d__56 <RefreshFiledArea>d__;
			<RefreshFiledArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshFiledArea>d__.<>4__this = this;
			<RefreshFiledArea>d__.<>1__state = -1;
			<RefreshFiledArea>d__.<>t__builder.Start<PhantomArenaOwnArea.<RefreshFiledArea>d__56>(ref <RefreshFiledArea>d__);
			return <RefreshFiledArea>d__.<>t__builder.Task;
		}

		// Token: 0x0602B26A RID: 176746 RVA: 0x00C20E60 File Offset: 0x00C1F060
		public UniTask ShowField()
		{
			PhantomArenaOwnArea.<ShowField>d__57 <ShowField>d__;
			<ShowField>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowField>d__.<>4__this = this;
			<ShowField>d__.<>1__state = -1;
			<ShowField>d__.<>t__builder.Start<PhantomArenaOwnArea.<ShowField>d__57>(ref <ShowField>d__);
			return <ShowField>d__.<>t__builder.Task;
		}

		// Token: 0x0602B26B RID: 176747 RVA: 0x00C20EA4 File Offset: 0x00C1F0A4
		public UniTask ShowFiledArea()
		{
			PhantomArenaOwnArea.<ShowFiledArea>d__58 <ShowFiledArea>d__;
			<ShowFiledArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowFiledArea>d__.<>4__this = this;
			<ShowFiledArea>d__.<>1__state = -1;
			<ShowFiledArea>d__.<>t__builder.Start<PhantomArenaOwnArea.<ShowFiledArea>d__58>(ref <ShowFiledArea>d__);
			return <ShowFiledArea>d__.<>t__builder.Task;
		}

		// Token: 0x0602B26C RID: 176748 RVA: 0x00C20EE8 File Offset: 0x00C1F0E8
		public UniTask UnlockFiledArea()
		{
			PhantomArenaOwnArea.<UnlockFiledArea>d__59 <UnlockFiledArea>d__;
			<UnlockFiledArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UnlockFiledArea>d__.<>4__this = this;
			<UnlockFiledArea>d__.<>1__state = -1;
			<UnlockFiledArea>d__.<>t__builder.Start<PhantomArenaOwnArea.<UnlockFiledArea>d__59>(ref <UnlockFiledArea>d__);
			return <UnlockFiledArea>d__.<>t__builder.Task;
		}

		// Token: 0x0602B26D RID: 176749 RVA: 0x00C20F2B File Offset: 0x00C1F12B
		public void SwitchFieldState(bool isGamepad)
		{
			PhantomArenaFieldArea filedArea = this.FiledArea;
			if (filedArea != null)
			{
				filedArea.SwitchFieldState(!isGamepad);
			}
			this.RolePanel.SwitchFieldState(isGamepad);
		}

		// Token: 0x040174E4 RID: 95460
		public PhantomArenaBattleProxy ViewProxy;

		// Token: 0x040174E5 RID: 95461
		public PhantomArenaHandArea HandArea;

		// Token: 0x040174E6 RID: 95462
		public PhantomArenaFunctionalArea FunctionalArea;

		// Token: 0x040174E7 RID: 95463
		public PhantomArenaOwnRolePanel RolePanel;

		// Token: 0x040174E8 RID: 95464
		public UCurveFloat DrawCardCurveX;

		// Token: 0x040174E9 RID: 95465
		public UCurveFloat DrawCardCurveY;

		// Token: 0x040174EA RID: 95466
		public UCurveFloat DiscardCardCurveX;

		// Token: 0x040174EB RID: 95467
		public UCurveFloat DiscardCardCurveY;

		// Token: 0x040174EC RID: 95468
		public UCurveFloat MoveLocationCurve;

		// Token: 0x040174ED RID: 95469
		public UCurveFloat RecycleCurve;

		// Token: 0x040174EE RID: 95470
		private bool LastLayoutHoistState;

		// Token: 0x040174EF RID: 95471
		public PhantomArenaFieldArea FiledArea;

		// Token: 0x040174F0 RID: 95472
		public PhantomArenaFieldEffectItem FieldEffect;
	}
}

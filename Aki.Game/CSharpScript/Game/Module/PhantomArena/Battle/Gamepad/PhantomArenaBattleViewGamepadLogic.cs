using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Area.Functional;
using CSharpScript.Game.Module.PhantomArena.Battle.Area.Hand;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using CSharpScript.Game.Module.PhantomArena.Battle.Opponent;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Gamepad
{
	// Token: 0x02004286 RID: 17030
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleViewGamepadLogic
	{
		// Token: 0x170056AF RID: 22191
		// (get) Token: 0x0602B184 RID: 176516 RVA: 0x00C1D982 File Offset: 0x00C1BB82
		public bool IsInHandCardSelectState
		{
			get
			{
				return this.SelectedCard != null && this.SelectedCard.Data.Index == -1;
			}
		}

		// Token: 0x170056B0 RID: 22192
		// (get) Token: 0x0602B185 RID: 176517 RVA: 0x00C1D9A1 File Offset: 0x00C1BBA1
		public bool IsInBattleCardSelectState
		{
			get
			{
				return this.SelectedCard != null && this.SelectedCard.Data.Index != -1;
			}
		}

		// Token: 0x170056B1 RID: 22193
		// (get) Token: 0x0602B186 RID: 176518 RVA: 0x00C1D9C3 File Offset: 0x00C1BBC3
		public bool IsInCardSelectState
		{
			get
			{
				return this.IsInHandCardSelectState || this.IsInBattleCardSelectState;
			}
		}

		// Token: 0x0602B187 RID: 176519 RVA: 0x00C1D9D5 File Offset: 0x00C1BBD5
		public PhantomArenaBattleViewGamepadLogic(PhantomArenaBattleProxy proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x0602B188 RID: 176520 RVA: 0x00C1D9F2 File Offset: 0x00C1BBF2
		private void ClearSelectedCard()
		{
			this.SelectedCard = null;
			this.SlotIndex = -1;
			this.HandIndex = -1;
			this.Proxy.OwnArea.FunctionalArea.ResetLastProxyIndexByGamepad();
		}

		// Token: 0x0602B189 RID: 176521 RVA: 0x00C1DA20 File Offset: 0x00C1BC20
		private UniTask SetSelectedCardByHand(PhantomArenaCard card, int index)
		{
			PhantomArenaBattleViewGamepadLogic.<SetSelectedCardByHand>d__14 <SetSelectedCardByHand>d__;
			<SetSelectedCardByHand>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetSelectedCardByHand>d__.<>4__this = this;
			<SetSelectedCardByHand>d__.card = card;
			<SetSelectedCardByHand>d__.index = index;
			<SetSelectedCardByHand>d__.<>1__state = -1;
			<SetSelectedCardByHand>d__.<>t__builder.Start<PhantomArenaBattleViewGamepadLogic.<SetSelectedCardByHand>d__14>(ref <SetSelectedCardByHand>d__);
			return <SetSelectedCardByHand>d__.<>t__builder.Task;
		}

		// Token: 0x0602B18A RID: 176522 RVA: 0x00C1DA74 File Offset: 0x00C1BC74
		private UniTask SetSelectedCardByFunctional(PhantomArenaCard card, int index)
		{
			PhantomArenaBattleViewGamepadLogic.<SetSelectedCardByFunctional>d__15 <SetSelectedCardByFunctional>d__;
			<SetSelectedCardByFunctional>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetSelectedCardByFunctional>d__.<>4__this = this;
			<SetSelectedCardByFunctional>d__.card = card;
			<SetSelectedCardByFunctional>d__.index = index;
			<SetSelectedCardByFunctional>d__.<>1__state = -1;
			<SetSelectedCardByFunctional>d__.<>t__builder.Start<PhantomArenaBattleViewGamepadLogic.<SetSelectedCardByFunctional>d__15>(ref <SetSelectedCardByFunctional>d__);
			return <SetSelectedCardByFunctional>d__.<>t__builder.Task;
		}

		// Token: 0x0602B18B RID: 176523 RVA: 0x00C1DAC8 File Offset: 0x00C1BCC8
		private UniTask ExecuteHandCardToRecycle(PhantomArenaCard card)
		{
			PhantomArenaBattleViewGamepadLogic.<ExecuteHandCardToRecycle>d__16 <ExecuteHandCardToRecycle>d__;
			<ExecuteHandCardToRecycle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteHandCardToRecycle>d__.<>4__this = this;
			<ExecuteHandCardToRecycle>d__.card = card;
			<ExecuteHandCardToRecycle>d__.<>1__state = -1;
			<ExecuteHandCardToRecycle>d__.<>t__builder.Start<PhantomArenaBattleViewGamepadLogic.<ExecuteHandCardToRecycle>d__16>(ref <ExecuteHandCardToRecycle>d__);
			return <ExecuteHandCardToRecycle>d__.<>t__builder.Task;
		}

		// Token: 0x0602B18C RID: 176524 RVA: 0x00C1DB14 File Offset: 0x00C1BD14
		private UniTask ExecuteFunctionalCardToRecycle(PhantomArenaCard card)
		{
			PhantomArenaBattleViewGamepadLogic.<ExecuteFunctionalCardToRecycle>d__17 <ExecuteFunctionalCardToRecycle>d__;
			<ExecuteFunctionalCardToRecycle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteFunctionalCardToRecycle>d__.<>4__this = this;
			<ExecuteFunctionalCardToRecycle>d__.card = card;
			<ExecuteFunctionalCardToRecycle>d__.<>1__state = -1;
			<ExecuteFunctionalCardToRecycle>d__.<>t__builder.Start<PhantomArenaBattleViewGamepadLogic.<ExecuteFunctionalCardToRecycle>d__17>(ref <ExecuteFunctionalCardToRecycle>d__);
			return <ExecuteFunctionalCardToRecycle>d__.<>t__builder.Task;
		}

		// Token: 0x0602B18D RID: 176525 RVA: 0x00C1DB5F File Offset: 0x00C1BD5F
		private void SetOwnBattleShowTipsCard(PhantomArenaCard card)
		{
			if (card == null)
			{
				this.CancelOwnBattleShowTipsCard();
				return;
			}
			this.OwnBattleShowTipsCard = card;
			card.SetSelectedStateByGamepad(true);
		}

		// Token: 0x0602B18E RID: 176526 RVA: 0x00C1DB79 File Offset: 0x00C1BD79
		private void CancelOwnBattleShowTipsCard()
		{
			if (this.OwnBattleShowTipsCard != null)
			{
				this.OwnBattleShowTipsCard.SetSelectedStateByGamepad(false);
				this.OwnBattleShowTipsCard = null;
			}
		}

		// Token: 0x0602B18F RID: 176527 RVA: 0x00C1DB98 File Offset: 0x00C1BD98
		public void CancelSelectedCard()
		{
			if (this.SelectedCard == null)
			{
				return;
			}
			if (this.SelectedCard.Data.Index == -1)
			{
				this.Proxy.OwnArea.ResetSelectCardToHand(this.SelectedCard, this.SlotIndex).Forget();
			}
			else
			{
				this.Proxy.OwnArea.ResetSelectCardToFunctional(this.SelectedCard, this.SlotIndex).Forget();
			}
			this.ClearSelectedCard();
		}

		// Token: 0x0602B190 RID: 176528 RVA: 0x00C1DC0B File Offset: 0x00C1BE0B
		public void ResetGamepadOperation()
		{
			this.CancelSelectedCard();
			this.CancelOwnBattleShowTipsCard();
		}

		// Token: 0x0602B191 RID: 176529 RVA: 0x00C1DC19 File Offset: 0x00C1BE19
		public void SwitchCardLayoutHoist()
		{
			this.Proxy.OwnArea.HandArea.SwitchLayoutHoist();
		}

		// Token: 0x0602B192 RID: 176530 RVA: 0x00C1DC30 File Offset: 0x00C1BE30
		public void TriggerRecycleCard()
		{
			if (this.SelectedCard == null)
			{
				return;
			}
			if (this.SelectedCard.Data.Index == -1)
			{
				this.ExecuteHandCardToRecycle(this.SelectedCard).Forget();
				this.ClearSelectedCard();
				return;
			}
			this.ExecuteFunctionalCardToRecycle(this.SelectedCard).Forget();
			this.ClearSelectedCard();
		}

		// Token: 0x0602B193 RID: 176531 RVA: 0x00C1DC88 File Offset: 0x00C1BE88
		[NullableContext(0)]
		public UniTask<bool> SelectHandCard(int index)
		{
			PhantomArenaBattleViewGamepadLogic.<SelectHandCard>d__24 <SelectHandCard>d__;
			<SelectHandCard>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<SelectHandCard>d__.<>4__this = this;
			<SelectHandCard>d__.index = index;
			<SelectHandCard>d__.<>1__state = -1;
			<SelectHandCard>d__.<>t__builder.Start<PhantomArenaBattleViewGamepadLogic.<SelectHandCard>d__24>(ref <SelectHandCard>d__);
			return <SelectHandCard>d__.<>t__builder.Task;
		}

		// Token: 0x0602B194 RID: 176532 RVA: 0x00C1DCD4 File Offset: 0x00C1BED4
		[NullableContext(0)]
		public UniTask<bool> SelectBattleCard(int index)
		{
			PhantomArenaBattleViewGamepadLogic.<SelectBattleCard>d__25 <SelectBattleCard>d__;
			<SelectBattleCard>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<SelectBattleCard>d__.<>4__this = this;
			<SelectBattleCard>d__.index = index;
			<SelectBattleCard>d__.<>1__state = -1;
			<SelectBattleCard>d__.<>t__builder.Start<PhantomArenaBattleViewGamepadLogic.<SelectBattleCard>d__25>(ref <SelectBattleCard>d__);
			return <SelectBattleCard>d__.<>t__builder.Task;
		}

		// Token: 0x0602B195 RID: 176533 RVA: 0x00C1DD20 File Offset: 0x00C1BF20
		public UniTask MoveHandCardToFunctional(int index)
		{
			PhantomArenaBattleViewGamepadLogic.<MoveHandCardToFunctional>d__26 <MoveHandCardToFunctional>d__;
			<MoveHandCardToFunctional>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<MoveHandCardToFunctional>d__.<>4__this = this;
			<MoveHandCardToFunctional>d__.index = index;
			<MoveHandCardToFunctional>d__.<>1__state = -1;
			<MoveHandCardToFunctional>d__.<>t__builder.Start<PhantomArenaBattleViewGamepadLogic.<MoveHandCardToFunctional>d__26>(ref <MoveHandCardToFunctional>d__);
			return <MoveHandCardToFunctional>d__.<>t__builder.Task;
		}

		// Token: 0x0602B196 RID: 176534 RVA: 0x00C1DD6C File Offset: 0x00C1BF6C
		public UniTask MoveBattleCardToFunctional(int index)
		{
			PhantomArenaBattleViewGamepadLogic.<MoveBattleCardToFunctional>d__27 <MoveBattleCardToFunctional>d__;
			<MoveBattleCardToFunctional>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<MoveBattleCardToFunctional>d__.<>4__this = this;
			<MoveBattleCardToFunctional>d__.index = index;
			<MoveBattleCardToFunctional>d__.<>1__state = -1;
			<MoveBattleCardToFunctional>d__.<>t__builder.Start<PhantomArenaBattleViewGamepadLogic.<MoveBattleCardToFunctional>d__27>(ref <MoveBattleCardToFunctional>d__);
			return <MoveBattleCardToFunctional>d__.<>t__builder.Task;
		}

		// Token: 0x0602B197 RID: 176535 RVA: 0x00C1DDB8 File Offset: 0x00C1BFB8
		[NullableContext(0)]
		public UniTask<bool> PutDownCardToFunctional()
		{
			PhantomArenaBattleViewGamepadLogic.<PutDownCardToFunctional>d__28 <PutDownCardToFunctional>d__;
			<PutDownCardToFunctional>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PutDownCardToFunctional>d__.<>4__this = this;
			<PutDownCardToFunctional>d__.<>1__state = -1;
			<PutDownCardToFunctional>d__.<>t__builder.Start<PhantomArenaBattleViewGamepadLogic.<PutDownCardToFunctional>d__28>(ref <PutDownCardToFunctional>d__);
			return <PutDownCardToFunctional>d__.<>t__builder.Task;
		}

		// Token: 0x0602B198 RID: 176536 RVA: 0x00C1DDFC File Offset: 0x00C1BFFC
		public void SwitchHandCardTips(int index)
		{
			PhantomArenaHandCardProxy cardProxyByIndex = this.Proxy.OwnArea.HandArea.GetCardProxyByIndex(index);
			if (cardProxyByIndex == null)
			{
				return;
			}
			this.Proxy.SwitchCardTips(cardProxyByIndex.GetCard().Data);
		}

		// Token: 0x0602B199 RID: 176537 RVA: 0x00C1DE3C File Offset: 0x00C1C03C
		public void SwitchOwnBattleCardTips(int index)
		{
			PhantomArenaAreaProxyBase cardProxyByIndex = this.Proxy.OwnArea.FunctionalArea.GetCardProxyByIndex(index);
			if (cardProxyByIndex == null || cardProxyByIndex.Card == null)
			{
				return;
			}
			this.SetOwnBattleShowTipsCard(this.Proxy.SwitchCardTips(cardProxyByIndex.Card.Data) ? cardProxyByIndex.Card : null);
		}

		// Token: 0x0602B19A RID: 176538 RVA: 0x00C1DE98 File Offset: 0x00C1C098
		public void SwitchOpponentBattleCardTips(int index)
		{
			OpponentFunctionAreaProxy cardProxyByIndex = this.Proxy.OpponentArea.FunctionalArea.GetCardProxyByIndex(index);
			if (cardProxyByIndex == null || cardProxyByIndex.Card == null)
			{
				return;
			}
			this.Proxy.SwitchCardTips(cardProxyByIndex.Card.Data);
		}

		// Token: 0x0602B19B RID: 176539 RVA: 0x00C1DEDF File Offset: 0x00C1C0DF
		public void HideCardTips()
		{
			this.Proxy.HideCardTips();
			this.CancelOwnBattleShowTipsCard();
		}

		// Token: 0x0602B19C RID: 176540 RVA: 0x00C1DEF4 File Offset: 0x00C1C0F4
		public bool IsInSkillInteractByOpponentIndex(int index)
		{
			OpponentFunctionAreaProxy cardProxyByIndex = this.Proxy.OpponentArea.FunctionalArea.GetCardProxyByIndex(index);
			return cardProxyByIndex != null && cardProxyByIndex.Card != null && cardProxyByIndex.IsInSkillInteract;
		}

		// Token: 0x0602B19D RID: 176541 RVA: 0x00C1DF2C File Offset: 0x00C1C12C
		public bool IsInSkillInteractByOwnIndex(int index)
		{
			PhantomArenaAreaProxyBase cardProxyByIndex = this.Proxy.OwnArea.FunctionalArea.GetCardProxyByIndex(index);
			return cardProxyByIndex != null && (cardProxyByIndex as PhantomArenaAreaMonsterProxy).IsInSkillInteract;
		}

		// Token: 0x040174AF RID: 95407
		public PhantomArenaCard SelectedCard;

		// Token: 0x040174B0 RID: 95408
		public int SlotIndex = -1;

		// Token: 0x040174B1 RID: 95409
		public int HandIndex = -1;

		// Token: 0x040174B2 RID: 95410
		private bool InPutDownTween;

		// Token: 0x040174B3 RID: 95411
		public PhantomArenaCard OwnBattleShowTipsCard;

		// Token: 0x040174B4 RID: 95412
		protected PhantomArenaBattleProxy Proxy;
	}
}

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
	// Token: 0x020052B6 RID: 21174
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleViewGamepadLogic
	{
		// Token: 0x170082EF RID: 33519
		// (get) Token: 0x06036289 RID: 221833 RVA: 0x00CD025A File Offset: 0x00CCE45A
		public bool IsInHandCardSelectState
		{
			get
			{
				return this.SelectedCard != null && this.SelectedCard.Data.Index == -1;
			}
		}

		// Token: 0x170082F0 RID: 33520
		// (get) Token: 0x0603628A RID: 221834 RVA: 0x00CD0279 File Offset: 0x00CCE479
		public bool IsInBattleCardSelectState
		{
			get
			{
				return this.SelectedCard != null && this.SelectedCard.Data.Index != -1;
			}
		}

		// Token: 0x170082F1 RID: 33521
		// (get) Token: 0x0603628B RID: 221835 RVA: 0x00CD029B File Offset: 0x00CCE49B
		public bool IsInCardSelectState
		{
			get
			{
				return this.IsInHandCardSelectState || this.IsInBattleCardSelectState;
			}
		}

		// Token: 0x0603628C RID: 221836 RVA: 0x00CD02AD File Offset: 0x00CCE4AD
		public PhantomArenaBattleViewGamepadLogic(PhantomArenaBattleProxy proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x0603628D RID: 221837 RVA: 0x00CD02CA File Offset: 0x00CCE4CA
		private void ClearSelectedCard()
		{
			this.SelectedCard = null;
			this.SlotIndex = -1;
			this.HandIndex = -1;
			this.Proxy.OwnArea.FunctionalArea.ResetLastProxyIndexByGamepad();
		}

		// Token: 0x0603628E RID: 221838 RVA: 0x00CD02F8 File Offset: 0x00CCE4F8
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

		// Token: 0x0603628F RID: 221839 RVA: 0x00CD034C File Offset: 0x00CCE54C
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

		// Token: 0x06036290 RID: 221840 RVA: 0x00CD03A0 File Offset: 0x00CCE5A0
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

		// Token: 0x06036291 RID: 221841 RVA: 0x00CD03EC File Offset: 0x00CCE5EC
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

		// Token: 0x06036292 RID: 221842 RVA: 0x00CD0437 File Offset: 0x00CCE637
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

		// Token: 0x06036293 RID: 221843 RVA: 0x00CD0451 File Offset: 0x00CCE651
		private void CancelOwnBattleShowTipsCard()
		{
			if (this.OwnBattleShowTipsCard != null)
			{
				this.OwnBattleShowTipsCard.SetSelectedStateByGamepad(false);
				this.OwnBattleShowTipsCard = null;
			}
		}

		// Token: 0x06036294 RID: 221844 RVA: 0x00CD0470 File Offset: 0x00CCE670
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

		// Token: 0x06036295 RID: 221845 RVA: 0x00CD04E3 File Offset: 0x00CCE6E3
		public void ResetGamepadOperation()
		{
			this.CancelSelectedCard();
			this.CancelOwnBattleShowTipsCard();
		}

		// Token: 0x06036296 RID: 221846 RVA: 0x00CD04F1 File Offset: 0x00CCE6F1
		public void SwitchCardLayoutHoist()
		{
			this.Proxy.OwnArea.HandArea.SwitchLayoutHoist();
		}

		// Token: 0x06036297 RID: 221847 RVA: 0x00CD0508 File Offset: 0x00CCE708
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

		// Token: 0x06036298 RID: 221848 RVA: 0x00CD0560 File Offset: 0x00CCE760
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

		// Token: 0x06036299 RID: 221849 RVA: 0x00CD05AC File Offset: 0x00CCE7AC
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

		// Token: 0x0603629A RID: 221850 RVA: 0x00CD05F8 File Offset: 0x00CCE7F8
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

		// Token: 0x0603629B RID: 221851 RVA: 0x00CD0644 File Offset: 0x00CCE844
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

		// Token: 0x0603629C RID: 221852 RVA: 0x00CD0690 File Offset: 0x00CCE890
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

		// Token: 0x0603629D RID: 221853 RVA: 0x00CD06D4 File Offset: 0x00CCE8D4
		public void SwitchHandCardTips(int index)
		{
			PhantomArenaHandCardProxy cardProxyByIndex = this.Proxy.OwnArea.HandArea.GetCardProxyByIndex(index);
			if (cardProxyByIndex == null)
			{
				return;
			}
			this.Proxy.SwitchCardTips(cardProxyByIndex.GetCard().Data);
		}

		// Token: 0x0603629E RID: 221854 RVA: 0x00CD0714 File Offset: 0x00CCE914
		public void SwitchOwnBattleCardTips(int index)
		{
			PhantomArenaAreaProxyBase cardProxyByIndex = this.Proxy.OwnArea.FunctionalArea.GetCardProxyByIndex(index);
			if (cardProxyByIndex == null || cardProxyByIndex.Card == null)
			{
				return;
			}
			this.SetOwnBattleShowTipsCard(this.Proxy.SwitchCardTips(cardProxyByIndex.Card.Data) ? cardProxyByIndex.Card : null);
		}

		// Token: 0x0603629F RID: 221855 RVA: 0x00CD0770 File Offset: 0x00CCE970
		public void SwitchOpponentBattleCardTips(int index)
		{
			OpponentFunctionAreaProxy cardProxyByIndex = this.Proxy.OpponentArea.FunctionalArea.GetCardProxyByIndex(index);
			if (cardProxyByIndex == null || cardProxyByIndex.Card == null)
			{
				return;
			}
			this.Proxy.SwitchCardTips(cardProxyByIndex.Card.Data);
		}

		// Token: 0x060362A0 RID: 221856 RVA: 0x00CD07B7 File Offset: 0x00CCE9B7
		public void HideCardTips()
		{
			this.Proxy.HideCardTips();
			this.CancelOwnBattleShowTipsCard();
		}

		// Token: 0x060362A1 RID: 221857 RVA: 0x00CD07CC File Offset: 0x00CCE9CC
		public bool IsInSkillInteractByOpponentIndex(int index)
		{
			OpponentFunctionAreaProxy cardProxyByIndex = this.Proxy.OpponentArea.FunctionalArea.GetCardProxyByIndex(index);
			return cardProxyByIndex != null && cardProxyByIndex.Card != null && cardProxyByIndex.IsInSkillInteract;
		}

		// Token: 0x060362A2 RID: 221858 RVA: 0x00CD0804 File Offset: 0x00CCEA04
		public bool IsInSkillInteractByOwnIndex(int index)
		{
			PhantomArenaAreaProxyBase cardProxyByIndex = this.Proxy.OwnArea.FunctionalArea.GetCardProxyByIndex(index);
			return cardProxyByIndex != null && (cardProxyByIndex as PhantomArenaAreaMonsterProxy).IsInSkillInteract;
		}

		// Token: 0x0401CA7A RID: 117370
		public PhantomArenaCard SelectedCard;

		// Token: 0x0401CA7B RID: 117371
		public int SlotIndex = -1;

		// Token: 0x0401CA7C RID: 117372
		public int HandIndex = -1;

		// Token: 0x0401CA7D RID: 117373
		private bool InPutDownTween;

		// Token: 0x0401CA7E RID: 117374
		public PhantomArenaCard OwnBattleShowTipsCard;

		// Token: 0x0401CA7F RID: 117375
		protected PhantomArenaBattleProxy Proxy;
	}
}

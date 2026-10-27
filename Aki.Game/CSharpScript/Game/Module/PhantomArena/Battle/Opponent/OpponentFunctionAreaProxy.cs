using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Area.Functional;
using CSharpScript.Game.Module.PhantomArena.Battle.Canvas;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Opponent
{
	// Token: 0x02005290 RID: 21136
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class OpponentFunctionAreaProxy : IPhantomCardProxy, IPhantomCardProxyBase, IAreaCanvas
	{
		// Token: 0x17008283 RID: 33411
		// (get) Token: 0x060360AB RID: 221355 RVA: 0x00CCA287 File Offset: 0x00CC8487
		// (set) Token: 0x060360AC RID: 221356 RVA: 0x00CCA28F File Offset: 0x00CC848F
		public PhantomArenaAreaItemBase AreaItem { get; set; }

		// Token: 0x17008284 RID: 33412
		// (get) Token: 0x060360AD RID: 221357
		public abstract bool IsMonster { get; }

		// Token: 0x17008285 RID: 33413
		// (get) Token: 0x060360AE RID: 221358
		public abstract bool IsNeedPreload { get; }

		// Token: 0x060360AF RID: 221359 RVA: 0x00CCA298 File Offset: 0x00CC8498
		public OpponentFunctionAreaProxy(int index, OpponentFunctionArea area)
		{
			this.Index = index;
			this.ParentArea = area;
		}

		// Token: 0x060360B0 RID: 221360 RVA: 0x00CCA2B5 File Offset: 0x00CC84B5
		public void SetAreaItem(PhantomArenaAreaItemBase areaItem)
		{
			this.AreaItem = areaItem;
		}

		// Token: 0x060360B1 RID: 221361 RVA: 0x00CCA2C0 File Offset: 0x00CC84C0
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected UniTask<PhantomArenaCard> AddCardById(int cardId)
		{
			OpponentFunctionAreaProxy.<AddCardById>d__16 <AddCardById>d__;
			<AddCardById>d__.<>t__builder = AsyncUniTaskMethodBuilder<PhantomArenaCard>.Create();
			<AddCardById>d__.<>4__this = this;
			<AddCardById>d__.cardId = cardId;
			<AddCardById>d__.<>1__state = -1;
			<AddCardById>d__.<>t__builder.Start<OpponentFunctionAreaProxy.<AddCardById>d__16>(ref <AddCardById>d__);
			return <AddCardById>d__.<>t__builder.Task;
		}

		// Token: 0x060360B2 RID: 221362 RVA: 0x00CCA30C File Offset: 0x00CC850C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected UniTask<PhantomArenaCard> AddFightCardById(int cardId)
		{
			OpponentFunctionAreaProxy.<AddFightCardById>d__17 <AddFightCardById>d__;
			<AddFightCardById>d__.<>t__builder = AsyncUniTaskMethodBuilder<PhantomArenaCard>.Create();
			<AddFightCardById>d__.<>4__this = this;
			<AddFightCardById>d__.cardId = cardId;
			<AddFightCardById>d__.<>1__state = -1;
			<AddFightCardById>d__.<>t__builder.Start<OpponentFunctionAreaProxy.<AddFightCardById>d__17>(ref <AddFightCardById>d__);
			return <AddFightCardById>d__.<>t__builder.Task;
		}

		// Token: 0x060360B3 RID: 221363 RVA: 0x00CCA358 File Offset: 0x00CC8558
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected UniTask<PhantomArenaCard> AddCardByCardData(PhantomCardData cardData)
		{
			OpponentFunctionAreaProxy.<AddCardByCardData>d__18 <AddCardByCardData>d__;
			<AddCardByCardData>d__.<>t__builder = AsyncUniTaskMethodBuilder<PhantomArenaCard>.Create();
			<AddCardByCardData>d__.<>4__this = this;
			<AddCardByCardData>d__.cardData = cardData;
			<AddCardByCardData>d__.<>1__state = -1;
			<AddCardByCardData>d__.<>t__builder.Start<OpponentFunctionAreaProxy.<AddCardByCardData>d__18>(ref <AddCardByCardData>d__);
			return <AddCardByCardData>d__.<>t__builder.Task;
		}

		// Token: 0x060360B4 RID: 221364 RVA: 0x00CCA3A4 File Offset: 0x00CC85A4
		public UniTask SetCard(int cardId, UUIItem fromItem)
		{
			OpponentFunctionAreaProxy.<SetCard>d__19 <SetCard>d__;
			<SetCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetCard>d__.<>4__this = this;
			<SetCard>d__.cardId = cardId;
			<SetCard>d__.fromItem = fromItem;
			<SetCard>d__.<>1__state = -1;
			<SetCard>d__.<>t__builder.Start<OpponentFunctionAreaProxy.<SetCard>d__19>(ref <SetCard>d__);
			return <SetCard>d__.<>t__builder.Task;
		}

		// Token: 0x060360B5 RID: 221365 RVA: 0x00CCA3F8 File Offset: 0x00CC85F8
		public UniTask ChangeCard(PhantomArenaCard card)
		{
			OpponentFunctionAreaProxy.<ChangeCard>d__20 <ChangeCard>d__;
			<ChangeCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ChangeCard>d__.<>4__this = this;
			<ChangeCard>d__.card = card;
			<ChangeCard>d__.<>1__state = -1;
			<ChangeCard>d__.<>t__builder.Start<OpponentFunctionAreaProxy.<ChangeCard>d__20>(ref <ChangeCard>d__);
			return <ChangeCard>d__.<>t__builder.Task;
		}

		// Token: 0x060360B6 RID: 221366 RVA: 0x00CCA444 File Offset: 0x00CC8644
		public UniTask DestroyCard()
		{
			OpponentFunctionAreaProxy.<DestroyCard>d__21 <DestroyCard>d__;
			<DestroyCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DestroyCard>d__.<>4__this = this;
			<DestroyCard>d__.<>1__state = -1;
			<DestroyCard>d__.<>t__builder.Start<OpponentFunctionAreaProxy.<DestroyCard>d__21>(ref <DestroyCard>d__);
			return <DestroyCard>d__.<>t__builder.Task;
		}

		// Token: 0x060360B7 RID: 221367 RVA: 0x00CCA488 File Offset: 0x00CC8688
		public UniTask DissolveCard()
		{
			OpponentFunctionAreaProxy.<DissolveCard>d__22 <DissolveCard>d__;
			<DissolveCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DissolveCard>d__.<>4__this = this;
			<DissolveCard>d__.<>1__state = -1;
			<DissolveCard>d__.<>t__builder.Start<OpponentFunctionAreaProxy.<DissolveCard>d__22>(ref <DissolveCard>d__);
			return <DissolveCard>d__.<>t__builder.Task;
		}

		// Token: 0x060360B8 RID: 221368 RVA: 0x00CCA4CB File Offset: 0x00CC86CB
		public void SetCardSelectedState(bool value)
		{
			if (this.Card != null)
			{
				this.Card.SetSelectedState(value);
			}
		}

		// Token: 0x060360B9 RID: 221369 RVA: 0x00CCA4E4 File Offset: 0x00CC86E4
		public UniTask PlaySetBattleTween(UUIItem fromItem)
		{
			OpponentFunctionAreaProxy.<PlaySetBattleTween>d__24 <PlaySetBattleTween>d__;
			<PlaySetBattleTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySetBattleTween>d__.<>4__this = this;
			<PlaySetBattleTween>d__.fromItem = fromItem;
			<PlaySetBattleTween>d__.<>1__state = -1;
			<PlaySetBattleTween>d__.<>t__builder.Start<OpponentFunctionAreaProxy.<PlaySetBattleTween>d__24>(ref <PlaySetBattleTween>d__);
			return <PlaySetBattleTween>d__.<>t__builder.Task;
		}

		// Token: 0x060360BA RID: 221370 RVA: 0x00CCA530 File Offset: 0x00CC8730
		public UniTask PlayChangeCardTween(UUIItem fromItem)
		{
			OpponentFunctionAreaProxy.<PlayChangeCardTween>d__25 <PlayChangeCardTween>d__;
			<PlayChangeCardTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayChangeCardTween>d__.<>4__this = this;
			<PlayChangeCardTween>d__.fromItem = fromItem;
			<PlayChangeCardTween>d__.<>1__state = -1;
			<PlayChangeCardTween>d__.<>t__builder.Start<OpponentFunctionAreaProxy.<PlayChangeCardTween>d__25>(ref <PlayChangeCardTween>d__);
			return <PlayChangeCardTween>d__.<>t__builder.Task;
		}

		// Token: 0x060360BB RID: 221371 RVA: 0x00CCA57C File Offset: 0x00CC877C
		public UniTask PlayBackToRecycleTween()
		{
			OpponentFunctionAreaProxy.<PlayBackToRecycleTween>d__26 <PlayBackToRecycleTween>d__;
			<PlayBackToRecycleTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayBackToRecycleTween>d__.<>4__this = this;
			<PlayBackToRecycleTween>d__.<>1__state = -1;
			<PlayBackToRecycleTween>d__.<>t__builder.Start<OpponentFunctionAreaProxy.<PlayBackToRecycleTween>d__26>(ref <PlayBackToRecycleTween>d__);
			return <PlayBackToRecycleTween>d__.<>t__builder.Task;
		}

		// Token: 0x060360BC RID: 221372
		protected abstract UUIItem GetCardAttachItem();

		// Token: 0x060360BD RID: 221373 RVA: 0x00CCA5C0 File Offset: 0x00CC87C0
		public void PointerClickCard(int id, EToggleState state)
		{
			if (this.UiInteract == null)
			{
				if (this.Card != null)
				{
					this.ParentArea.ParentArea.ViewProxy.ShowCardTips(this.Card.Data, true);
					this.ParentArea.ParentArea.ViewProxy.SetSelectedCardId(id, EPhantomArenaCardClickFromType.OpponentFunctional);
				}
				return;
			}
			bool flag = !this.IsInSkillPoint;
			if (!this.UiInteract.ReceiveClickData(ESkillInteractMainUiInteractType.MonsterBattleCard, new object[]
			{
				id,
				this.Index,
				flag
			}))
			{
				PhantomArenaCard card = this.Card;
				if (card == null)
				{
					return;
				}
				card.SetToggleState(EToggleState.ETT_UnChecked, false);
				return;
			}
			else if (flag)
			{
				this.IsInSkillPoint = true;
				PhantomArenaCard card2 = this.Card;
				if (card2 == null)
				{
					return;
				}
				card2.PlaySequence("Point", false);
				return;
			}
			else
			{
				this.IsInSkillPoint = false;
				PhantomArenaCard card3 = this.Card;
				if (card3 == null)
				{
					return;
				}
				card3.PlaySequence("PointClose", false);
				return;
			}
		}

		// Token: 0x060360BE RID: 221374 RVA: 0x00CCA6A8 File Offset: 0x00CC88A8
		public void PointerEnterCard(int id)
		{
		}

		// Token: 0x060360BF RID: 221375 RVA: 0x00CCA6AA File Offset: 0x00CC88AA
		public void PointerDownCard(int id, ULGUIPointerEventData eventData)
		{
		}

		// Token: 0x060360C0 RID: 221376 RVA: 0x00CCA6AC File Offset: 0x00CC88AC
		public bool CheckCanvasSortOrder(List<EPhantomArenaInteractTag> tagList, ISkillTriggerInfo skillTriggerInfo)
		{
			return this.Card != null && skillTriggerInfo.SelectFightIdList.Contains(this.Card.Data.FightId) && tagList.Contains(EPhantomArenaInteractTag.OpponentAreaMonster) && this.IsMonster;
		}

		// Token: 0x060360C1 RID: 221377 RVA: 0x00CCA6EB File Offset: 0x00CC88EB
		public void HandleSortOrder()
		{
			if (this.Card != null)
			{
				this.Card.OverrideCanvasSortOrder(true);
				this.Card.PlayStateSequence("PointStart");
				this.IsInSkillInteract = true;
			}
		}

		// Token: 0x060360C2 RID: 221378 RVA: 0x00CCA718 File Offset: 0x00CC8918
		public void CancelSortOrder()
		{
			if (this.Card != null)
			{
				this.Card.OverrideCanvasSortOrder(false);
				this.Card.PlayStateSequence("PointClose");
				if (this.Card.GetToggleState() == EToggleState.ETT_Checked)
				{
					this.Card.SetToggleState(EToggleState.ETT_UnChecked, false);
				}
				if (this.IsInSkillPoint)
				{
					this.Card.PlaySequence("PointClose", false);
				}
				this.IsInSkillPoint = false;
				this.IsInSkillInteract = false;
			}
		}

		// Token: 0x060360C3 RID: 221379 RVA: 0x00CCA78B File Offset: 0x00CC898B
		[NullableContext(2)]
		public void ReceiveUiInteract(ISkillInteractMainUiInteract uiInteract)
		{
			this.UiInteract = uiInteract;
		}

		// Token: 0x0401C9E0 RID: 117216
		protected OpponentFunctionArea ParentArea;

		// Token: 0x0401C9E2 RID: 117218
		public PhantomArenaCard Card;

		// Token: 0x0401C9E3 RID: 117219
		public int Index = -1;

		// Token: 0x0401C9E4 RID: 117220
		[Nullable(2)]
		private ISkillInteractMainUiInteract UiInteract;

		// Token: 0x0401C9E5 RID: 117221
		private bool IsInSkillPoint;

		// Token: 0x0401C9E6 RID: 117222
		public bool IsInSkillInteract;
	}
}

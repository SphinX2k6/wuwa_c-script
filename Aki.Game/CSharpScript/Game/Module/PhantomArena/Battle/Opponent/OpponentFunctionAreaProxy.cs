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
	// Token: 0x02004260 RID: 16992
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class OpponentFunctionAreaProxy : IPhantomCardProxy, IPhantomCardProxyBase, IAreaCanvas
	{
		// Token: 0x17005643 RID: 22083
		// (get) Token: 0x0602AFA6 RID: 176038 RVA: 0x00C1798B File Offset: 0x00C15B8B
		// (set) Token: 0x0602AFA7 RID: 176039 RVA: 0x00C17993 File Offset: 0x00C15B93
		public PhantomArenaAreaItemBase AreaItem { get; set; }

		// Token: 0x17005644 RID: 22084
		// (get) Token: 0x0602AFA8 RID: 176040
		public abstract bool IsMonster { get; }

		// Token: 0x17005645 RID: 22085
		// (get) Token: 0x0602AFA9 RID: 176041
		public abstract bool IsNeedPreload { get; }

		// Token: 0x0602AFAA RID: 176042 RVA: 0x00C1799C File Offset: 0x00C15B9C
		public OpponentFunctionAreaProxy(int index, OpponentFunctionArea area)
		{
			this.Index = index;
			this.ParentArea = area;
		}

		// Token: 0x0602AFAB RID: 176043 RVA: 0x00C179B9 File Offset: 0x00C15BB9
		public void SetAreaItem(PhantomArenaAreaItemBase areaItem)
		{
			this.AreaItem = areaItem;
		}

		// Token: 0x0602AFAC RID: 176044 RVA: 0x00C179C4 File Offset: 0x00C15BC4
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

		// Token: 0x0602AFAD RID: 176045 RVA: 0x00C17A10 File Offset: 0x00C15C10
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

		// Token: 0x0602AFAE RID: 176046 RVA: 0x00C17A5C File Offset: 0x00C15C5C
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

		// Token: 0x0602AFAF RID: 176047 RVA: 0x00C17AA8 File Offset: 0x00C15CA8
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

		// Token: 0x0602AFB0 RID: 176048 RVA: 0x00C17AFC File Offset: 0x00C15CFC
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

		// Token: 0x0602AFB1 RID: 176049 RVA: 0x00C17B48 File Offset: 0x00C15D48
		public UniTask DestroyCard()
		{
			OpponentFunctionAreaProxy.<DestroyCard>d__21 <DestroyCard>d__;
			<DestroyCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DestroyCard>d__.<>4__this = this;
			<DestroyCard>d__.<>1__state = -1;
			<DestroyCard>d__.<>t__builder.Start<OpponentFunctionAreaProxy.<DestroyCard>d__21>(ref <DestroyCard>d__);
			return <DestroyCard>d__.<>t__builder.Task;
		}

		// Token: 0x0602AFB2 RID: 176050 RVA: 0x00C17B8C File Offset: 0x00C15D8C
		public UniTask DissolveCard()
		{
			OpponentFunctionAreaProxy.<DissolveCard>d__22 <DissolveCard>d__;
			<DissolveCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DissolveCard>d__.<>4__this = this;
			<DissolveCard>d__.<>1__state = -1;
			<DissolveCard>d__.<>t__builder.Start<OpponentFunctionAreaProxy.<DissolveCard>d__22>(ref <DissolveCard>d__);
			return <DissolveCard>d__.<>t__builder.Task;
		}

		// Token: 0x0602AFB3 RID: 176051 RVA: 0x00C17BCF File Offset: 0x00C15DCF
		public void SetCardSelectedState(bool value)
		{
			if (this.Card != null)
			{
				this.Card.SetSelectedState(value);
			}
		}

		// Token: 0x0602AFB4 RID: 176052 RVA: 0x00C17BE8 File Offset: 0x00C15DE8
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

		// Token: 0x0602AFB5 RID: 176053 RVA: 0x00C17C34 File Offset: 0x00C15E34
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

		// Token: 0x0602AFB6 RID: 176054 RVA: 0x00C17C80 File Offset: 0x00C15E80
		public UniTask PlayBackToRecycleTween()
		{
			OpponentFunctionAreaProxy.<PlayBackToRecycleTween>d__26 <PlayBackToRecycleTween>d__;
			<PlayBackToRecycleTween>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayBackToRecycleTween>d__.<>4__this = this;
			<PlayBackToRecycleTween>d__.<>1__state = -1;
			<PlayBackToRecycleTween>d__.<>t__builder.Start<OpponentFunctionAreaProxy.<PlayBackToRecycleTween>d__26>(ref <PlayBackToRecycleTween>d__);
			return <PlayBackToRecycleTween>d__.<>t__builder.Task;
		}

		// Token: 0x0602AFB7 RID: 176055
		protected abstract UUIItem GetCardAttachItem();

		// Token: 0x0602AFB8 RID: 176056 RVA: 0x00C17CC4 File Offset: 0x00C15EC4
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

		// Token: 0x0602AFB9 RID: 176057 RVA: 0x00C17DAC File Offset: 0x00C15FAC
		public void PointerEnterCard(int id)
		{
		}

		// Token: 0x0602AFBA RID: 176058 RVA: 0x00C17DAE File Offset: 0x00C15FAE
		public void PointerDownCard(int id, ULGUIPointerEventData eventData)
		{
		}

		// Token: 0x0602AFBB RID: 176059 RVA: 0x00C17DB0 File Offset: 0x00C15FB0
		public bool CheckCanvasSortOrder(List<EPhantomArenaInteractTag> tagList, ISkillTriggerInfo skillTriggerInfo)
		{
			return this.Card != null && skillTriggerInfo.SelectFightIdList.Contains(this.Card.Data.FightId) && tagList.Contains(EPhantomArenaInteractTag.OpponentAreaMonster) && this.IsMonster;
		}

		// Token: 0x0602AFBC RID: 176060 RVA: 0x00C17DEF File Offset: 0x00C15FEF
		public void HandleSortOrder()
		{
			if (this.Card != null)
			{
				this.Card.OverrideCanvasSortOrder(true);
				this.Card.PlayStateSequence("PointStart");
				this.IsInSkillInteract = true;
			}
		}

		// Token: 0x0602AFBD RID: 176061 RVA: 0x00C17E1C File Offset: 0x00C1601C
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

		// Token: 0x0602AFBE RID: 176062 RVA: 0x00C17E8F File Offset: 0x00C1608F
		[NullableContext(2)]
		public void ReceiveUiInteract(ISkillInteractMainUiInteract uiInteract)
		{
			this.UiInteract = uiInteract;
		}

		// Token: 0x04017415 RID: 95253
		protected OpponentFunctionArea ParentArea;

		// Token: 0x04017417 RID: 95255
		public PhantomArenaCard Card;

		// Token: 0x04017418 RID: 95256
		public int Index = -1;

		// Token: 0x04017419 RID: 95257
		[Nullable(2)]
		private ISkillInteractMainUiInteract UiInteract;

		// Token: 0x0401741A RID: 95258
		private bool IsInSkillPoint;

		// Token: 0x0401741B RID: 95259
		public bool IsInSkillInteract;
	}
}

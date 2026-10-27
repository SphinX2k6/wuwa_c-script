using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.Canvas;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using CSharpScript.Game.Module.PhantomArena.Battle.Card.Logic;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Area.Functional
{
	// Token: 0x020052D1 RID: 21201
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaAreaMonsterProxy : PhantomArenaAreaProxyBase, IPhantomCardProxy, IPhantomCardProxyBase, IPhantomCardDragProxy, IAreaCanvas, ISkillInteractMainInterface
	{
		// Token: 0x170082F4 RID: 33524
		// (get) Token: 0x060363F6 RID: 222198 RVA: 0x00CD56E3 File Offset: 0x00CD38E3
		// (set) Token: 0x060363F7 RID: 222199 RVA: 0x00CD56F0 File Offset: 0x00CD38F0
		public new PhantomArenaAreaMonsterItem AreaItem
		{
			get
			{
				return base.AreaItem as PhantomArenaAreaMonsterItem;
			}
			set
			{
				base.AreaItem = value;
			}
		}

		// Token: 0x170082F5 RID: 33525
		// (get) Token: 0x060363F8 RID: 222200 RVA: 0x00CD56F9 File Offset: 0x00CD38F9
		public override EPhantomArenaCardAreaType AreaType
		{
			get
			{
				return EPhantomArenaCardAreaType.Monster;
			}
		}

		// Token: 0x060363F9 RID: 222201 RVA: 0x00CD56FC File Offset: 0x00CD38FC
		public PhantomArenaAreaMonsterProxy(int index, PhantomArenaFunctionalArea area) : base(index, area)
		{
		}

		// Token: 0x060363FA RID: 222202 RVA: 0x00CD5708 File Offset: 0x00CD3908
		protected bool CheckEvolveGuideCondition(int cardId, int battleIndex)
		{
			if (battleIndex == -1)
			{
				int handIndexByCardId = PhantomArenaBattleModel.Instance.OwnData.GetHandIndexByCardId(cardId);
				return this.ParentArea.ParentArea.ViewProxy.GuideManager.CheckCanExecuteAndShowFailTips(EBvbPlayerOperationType.BvbEvolution, new object[]
				{
					handIndexByCardId,
					this.Index
				});
			}
			return true;
		}

		// Token: 0x060363FB RID: 222203 RVA: 0x00CD5764 File Offset: 0x00CD3964
		protected bool CheckSettingGuideCondition(int cardId, int battleIndex)
		{
			if (battleIndex == -1)
			{
				int handIndexByCardId = PhantomArenaBattleModel.Instance.OwnData.GetHandIndexByCardId(cardId);
				return this.ParentArea.ParentArea.ViewProxy.GuideManager.CheckCanExecuteAndShowFailTips(EBvbPlayerOperationType.BvbDeploy, new object[]
				{
					handIndexByCardId,
					this.Index
				});
			}
			return true;
		}

		// Token: 0x060363FC RID: 222204 RVA: 0x00CD57C0 File Offset: 0x00CD39C0
		public override bool CheckGuideCondition(PhantomArenaCard card)
		{
			if (this.Card != null && card != null && this.Card != card)
			{
				return this.CheckEvolveGuideCondition(card.Data.CardId, card.Data.Index);
			}
			return this.CheckSettingGuideCondition(card.Data.CardId, card.Data.Index);
		}

		// Token: 0x060363FD RID: 222205 RVA: 0x00CD581C File Offset: 0x00CD3A1C
		public override bool CheckSettingCardCondition(PhantomArenaCard card)
		{
			bool flag;
			EPhantomCardSettingFailReason ephantomCardSettingFailReason;
			card.CardLogic.CheckMonsterSettingCondition(this.Card).Deconstruct(out flag, out ephantomCardSettingFailReason);
			bool result = flag;
			EPhantomCardSettingFailReason settingFailReason = ephantomCardSettingFailReason;
			this.SettingFailReason = settingFailReason;
			return result;
		}

		// Token: 0x060363FE RID: 222206 RVA: 0x00CD5850 File Offset: 0x00CD3A50
		[NullableContext(0)]
		protected UniTask<bool> OnHandleAreaByEvolve([Nullable(1)] PhantomArenaCard card)
		{
			PhantomArenaAreaMonsterProxy.<OnHandleAreaByEvolve>d__14 <OnHandleAreaByEvolve>d__;
			<OnHandleAreaByEvolve>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnHandleAreaByEvolve>d__.<>4__this = this;
			<OnHandleAreaByEvolve>d__.card = card;
			<OnHandleAreaByEvolve>d__.<>1__state = -1;
			<OnHandleAreaByEvolve>d__.<>t__builder.Start<PhantomArenaAreaMonsterProxy.<OnHandleAreaByEvolve>d__14>(ref <OnHandleAreaByEvolve>d__);
			return <OnHandleAreaByEvolve>d__.<>t__builder.Task;
		}

		// Token: 0x060363FF RID: 222207 RVA: 0x00CD589C File Offset: 0x00CD3A9C
		[NullableContext(0)]
		protected UniTask<bool> OnHandleAreaBySetCard([Nullable(1)] PhantomArenaCard card)
		{
			PhantomArenaAreaMonsterProxy.<OnHandleAreaBySetCard>d__15 <OnHandleAreaBySetCard>d__;
			<OnHandleAreaBySetCard>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnHandleAreaBySetCard>d__.<>4__this = this;
			<OnHandleAreaBySetCard>d__.card = card;
			<OnHandleAreaBySetCard>d__.<>1__state = -1;
			<OnHandleAreaBySetCard>d__.<>t__builder.Start<PhantomArenaAreaMonsterProxy.<OnHandleAreaBySetCard>d__15>(ref <OnHandleAreaBySetCard>d__);
			return <OnHandleAreaBySetCard>d__.<>t__builder.Task;
		}

		// Token: 0x06036400 RID: 222208 RVA: 0x00CD58E8 File Offset: 0x00CD3AE8
		[NullableContext(0)]
		protected override UniTask<bool> OnHandleCardSetting([Nullable(1)] PhantomArenaCard card)
		{
			PhantomArenaAreaMonsterProxy.<OnHandleCardSetting>d__16 <OnHandleCardSetting>d__;
			<OnHandleCardSetting>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnHandleCardSetting>d__.<>4__this = this;
			<OnHandleCardSetting>d__.card = card;
			<OnHandleCardSetting>d__.<>1__state = -1;
			<OnHandleCardSetting>d__.<>t__builder.Start<PhantomArenaAreaMonsterProxy.<OnHandleCardSetting>d__16>(ref <OnHandleCardSetting>d__);
			return <OnHandleCardSetting>d__.<>t__builder.Task;
		}

		// Token: 0x06036401 RID: 222209 RVA: 0x00CD5933 File Offset: 0x00CD3B33
		protected override UUIItem GetCardRootItem()
		{
			return this.AreaItem.GetCardRootItem();
		}

		// Token: 0x06036402 RID: 222210 RVA: 0x00CD5940 File Offset: 0x00CD3B40
		public override UniTask SetCard(PhantomArenaCard card)
		{
			PhantomArenaAreaMonsterProxy.<SetCard>d__18 <SetCard>d__;
			<SetCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetCard>d__.<>4__this = this;
			<SetCard>d__.card = card;
			<SetCard>d__.<>1__state = -1;
			<SetCard>d__.<>t__builder.Start<PhantomArenaAreaMonsterProxy.<SetCard>d__18>(ref <SetCard>d__);
			return <SetCard>d__.<>t__builder.Task;
		}

		// Token: 0x06036403 RID: 222211 RVA: 0x00CD598C File Offset: 0x00CD3B8C
		public UniTask CopyCard(PhantomCardData cardData)
		{
			PhantomArenaAreaMonsterProxy.<CopyCard>d__19 <CopyCard>d__;
			<CopyCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CopyCard>d__.<>4__this = this;
			<CopyCard>d__.cardData = cardData;
			<CopyCard>d__.<>1__state = -1;
			<CopyCard>d__.<>t__builder.Start<PhantomArenaAreaMonsterProxy.<CopyCard>d__19>(ref <CopyCard>d__);
			return <CopyCard>d__.<>t__builder.Task;
		}

		// Token: 0x06036404 RID: 222212 RVA: 0x00CD59D8 File Offset: 0x00CD3BD8
		public void PointerClickCard(int id, EToggleState state)
		{
			if (this.UiInteract == null)
			{
				if (this.Card != null)
				{
					this.ParentArea.ParentArea.ViewProxy.ShowCardTips(this.Card.Data, true);
					this.ParentArea.ParentArea.ViewProxy.SetSelectedCardId(id, EPhantomArenaCardClickFromType.OwnFunctional);
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

		// Token: 0x06036405 RID: 222213 RVA: 0x00CD5AC0 File Offset: 0x00CD3CC0
		public void PointerEnterCard(int id)
		{
		}

		// Token: 0x06036406 RID: 222214 RVA: 0x00CD5AC2 File Offset: 0x00CD3CC2
		public void PointerDownCard(int id, ULGUIPointerEventData eventData)
		{
			this.IsCanDrag = this.IsCanDragCard(id);
			if (!this.IsCanDrag)
			{
				return;
			}
			PhantomArenaCard card = this.Card;
			if (card == null)
			{
				return;
			}
			card.RecordLastDragPos(eventData.pointerPosition);
		}

		// Token: 0x06036407 RID: 222215 RVA: 0x00CD5AF0 File Offset: 0x00CD3CF0
		private bool IsCanDragCard(int id)
		{
			return !this.IsInCardTween && !PhantomArenaBattleModel.Instance.InWaitReconstructCardIdList(id) && this.ParentArea.ParentArea.IsCanDragCard(id);
		}

		// Token: 0x06036408 RID: 222216 RVA: 0x00CD5B1C File Offset: 0x00CD3D1C
		public void PointerBeginDrag(int id, ULGUIPointerEventData eventData)
		{
			if (this.Card == null)
			{
				return;
			}
			if (!this.IsCanDrag)
			{
				return;
			}
			global::Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "开始拖动手牌", default(ReadOnlySpan<ValueTuple<string, object>>));
			PhantomArenaCard card = this.Card;
			if (card != null)
			{
				card.PlayStateSequence("SeleStart");
			}
			this.ParentArea.ParentArea.CardBeginDragByFunctional(this.Card);
			this.Card.PlaySequence("DragUpTabletoHand", false);
		}

		// Token: 0x06036409 RID: 222217 RVA: 0x00CD5B98 File Offset: 0x00CD3D98
		public void PointerDragCard(int id, ULGUIPointerEventData eventData)
		{
			if (this.Card == null)
			{
				return;
			}
			if (!this.IsCanDrag)
			{
				return;
			}
			FVector pointerPosition = eventData.pointerPosition;
			this.Card.MoveCard(pointerPosition);
			this.ParentArea.ParentArea.CardDraggingByFunctional(this);
		}

		// Token: 0x0603640A RID: 222218 RVA: 0x00CD5BDB File Offset: 0x00CD3DDB
		public void PointerEndDrag(int id, ULGUIPointerEventData eventData)
		{
			if (this.Card == null)
			{
				return;
			}
			if (!this.IsCanDrag)
			{
				return;
			}
			this.ParentArea.ParentArea.CardEndDragByFunctional(this.Card, this.Index).Forget<bool>();
		}

		// Token: 0x0603640B RID: 222219 RVA: 0x00CD5C10 File Offset: 0x00CD3E10
		public bool CheckCanvasSortOrder(List<EPhantomArenaInteractTag> tagList, ISkillTriggerInfo skillTriggerInfo)
		{
			return this.Card != null && skillTriggerInfo.SelectFightIdList.Contains(this.Card.Data.FightId) && tagList.Contains(EPhantomArenaInteractTag.OwnMonster);
		}

		// Token: 0x0603640C RID: 222220 RVA: 0x00CD5C47 File Offset: 0x00CD3E47
		public void HandleSortOrder()
		{
			if (this.Card != null)
			{
				this.Card.OverrideCanvasSortOrder(true);
				this.Card.PlayStateSequence("PointStart");
				this.IsInSkillInteract = true;
			}
		}

		// Token: 0x0603640D RID: 222221 RVA: 0x00CD5C74 File Offset: 0x00CD3E74
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

		// Token: 0x0603640E RID: 222222 RVA: 0x00CD5CE7 File Offset: 0x00CD3EE7
		[NullableContext(2)]
		public void ReceiveUiInteract(ISkillInteractMainUiInteract uiInteract)
		{
			this.UiInteract = uiInteract;
		}

		// Token: 0x0603640F RID: 222223 RVA: 0x00CD5CF0 File Offset: 0x00CD3EF0
		public UniTask StartSkillInteract()
		{
			PhantomArenaAreaMonsterProxy.<StartSkillInteract>d__31 <StartSkillInteract>d__;
			<StartSkillInteract>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartSkillInteract>d__.<>4__this = this;
			<StartSkillInteract>d__.<>1__state = -1;
			<StartSkillInteract>d__.<>t__builder.Start<PhantomArenaAreaMonsterProxy.<StartSkillInteract>d__31>(ref <StartSkillInteract>d__);
			return <StartSkillInteract>d__.<>t__builder.Task;
		}

		// Token: 0x06036410 RID: 222224 RVA: 0x00CD5D33 File Offset: 0x00CD3F33
		public void CancelSkillInteract()
		{
			this.AreaItem.SetIncreaseActive(false).Forget();
		}

		// Token: 0x06036411 RID: 222225 RVA: 0x00CD5D46 File Offset: 0x00CD3F46
		public void FinishSkillInteract()
		{
			this.AreaItem.SetIncreaseActive(false).Forget();
			PhantomArenaCard card = this.Card;
			if (card == null)
			{
				return;
			}
			PhantomArenaCardLogic cardLogic = card.CardLogic;
			if (cardLogic == null)
			{
				return;
			}
			cardLogic.TryFinishCurrentGuide();
		}

		// Token: 0x06036412 RID: 222226 RVA: 0x00CD5D73 File Offset: 0x00CD3F73
		public ISkillTriggerInfo GetData()
		{
			return PhantomArenaBattleModel.Instance.BuffEffectData.CardSkillTriggerInfo;
		}

		// Token: 0x0401CADF RID: 117471
		[Nullable(2)]
		private ISkillInteractMainUiInteract UiInteract;

		// Token: 0x0401CAE0 RID: 117472
		private bool IsCanDrag;

		// Token: 0x0401CAE1 RID: 117473
		private bool IsInSkillPoint;

		// Token: 0x0401CAE2 RID: 117474
		public bool IsInSkillInteract;
	}
}

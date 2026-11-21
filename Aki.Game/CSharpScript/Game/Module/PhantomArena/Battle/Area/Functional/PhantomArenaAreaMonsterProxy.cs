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
	// Token: 0x020042A1 RID: 17057
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaAreaMonsterProxy : PhantomArenaAreaProxyBase, IPhantomCardProxy, IPhantomCardProxyBase, IPhantomCardDragProxy, IAreaCanvas, ISkillInteractMainInterface
	{
		// Token: 0x170056B4 RID: 22196
		// (get) Token: 0x0602B2F1 RID: 176881 RVA: 0x00C22E0B File Offset: 0x00C2100B
		// (set) Token: 0x0602B2F2 RID: 176882 RVA: 0x00C22E18 File Offset: 0x00C21018
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

		// Token: 0x170056B5 RID: 22197
		// (get) Token: 0x0602B2F3 RID: 176883 RVA: 0x00C22E21 File Offset: 0x00C21021
		public override EPhantomArenaCardAreaType AreaType
		{
			get
			{
				return EPhantomArenaCardAreaType.Monster;
			}
		}

		// Token: 0x0602B2F4 RID: 176884 RVA: 0x00C22E24 File Offset: 0x00C21024
		public PhantomArenaAreaMonsterProxy(int index, PhantomArenaFunctionalArea area) : base(index, area)
		{
		}

		// Token: 0x0602B2F5 RID: 176885 RVA: 0x00C22E30 File Offset: 0x00C21030
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

		// Token: 0x0602B2F6 RID: 176886 RVA: 0x00C22E8C File Offset: 0x00C2108C
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

		// Token: 0x0602B2F7 RID: 176887 RVA: 0x00C22EE8 File Offset: 0x00C210E8
		public override bool CheckGuideCondition(PhantomArenaCard card)
		{
			if (this.Card != null && card != null && this.Card != card)
			{
				return this.CheckEvolveGuideCondition(card.Data.CardId, card.Data.Index);
			}
			return this.CheckSettingGuideCondition(card.Data.CardId, card.Data.Index);
		}

		// Token: 0x0602B2F8 RID: 176888 RVA: 0x00C22F44 File Offset: 0x00C21144
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

		// Token: 0x0602B2F9 RID: 176889 RVA: 0x00C22F78 File Offset: 0x00C21178
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

		// Token: 0x0602B2FA RID: 176890 RVA: 0x00C22FC4 File Offset: 0x00C211C4
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

		// Token: 0x0602B2FB RID: 176891 RVA: 0x00C23010 File Offset: 0x00C21210
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

		// Token: 0x0602B2FC RID: 176892 RVA: 0x00C2305B File Offset: 0x00C2125B
		protected override UUIItem GetCardRootItem()
		{
			return this.AreaItem.GetCardRootItem();
		}

		// Token: 0x0602B2FD RID: 176893 RVA: 0x00C23068 File Offset: 0x00C21268
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

		// Token: 0x0602B2FE RID: 176894 RVA: 0x00C230B4 File Offset: 0x00C212B4
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

		// Token: 0x0602B2FF RID: 176895 RVA: 0x00C23100 File Offset: 0x00C21300
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

		// Token: 0x0602B300 RID: 176896 RVA: 0x00C231E8 File Offset: 0x00C213E8
		public void PointerEnterCard(int id)
		{
		}

		// Token: 0x0602B301 RID: 176897 RVA: 0x00C231EA File Offset: 0x00C213EA
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

		// Token: 0x0602B302 RID: 176898 RVA: 0x00C23218 File Offset: 0x00C21418
		private bool IsCanDragCard(int id)
		{
			return !this.IsInCardTween && !PhantomArenaBattleModel.Instance.InWaitReconstructCardIdList(id) && this.ParentArea.ParentArea.IsCanDragCard(id);
		}

		// Token: 0x0602B303 RID: 176899 RVA: 0x00C23244 File Offset: 0x00C21444
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

		// Token: 0x0602B304 RID: 176900 RVA: 0x00C232C0 File Offset: 0x00C214C0
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

		// Token: 0x0602B305 RID: 176901 RVA: 0x00C23303 File Offset: 0x00C21503
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

		// Token: 0x0602B306 RID: 176902 RVA: 0x00C23338 File Offset: 0x00C21538
		public bool CheckCanvasSortOrder(List<EPhantomArenaInteractTag> tagList, ISkillTriggerInfo skillTriggerInfo)
		{
			return this.Card != null && skillTriggerInfo.SelectFightIdList.Contains(this.Card.Data.FightId) && tagList.Contains(EPhantomArenaInteractTag.OwnMonster);
		}

		// Token: 0x0602B307 RID: 176903 RVA: 0x00C2336F File Offset: 0x00C2156F
		public void HandleSortOrder()
		{
			if (this.Card != null)
			{
				this.Card.OverrideCanvasSortOrder(true);
				this.Card.PlayStateSequence("PointStart");
				this.IsInSkillInteract = true;
			}
		}

		// Token: 0x0602B308 RID: 176904 RVA: 0x00C2339C File Offset: 0x00C2159C
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

		// Token: 0x0602B309 RID: 176905 RVA: 0x00C2340F File Offset: 0x00C2160F
		[NullableContext(2)]
		public void ReceiveUiInteract(ISkillInteractMainUiInteract uiInteract)
		{
			this.UiInteract = uiInteract;
		}

		// Token: 0x0602B30A RID: 176906 RVA: 0x00C23418 File Offset: 0x00C21618
		public UniTask StartSkillInteract()
		{
			PhantomArenaAreaMonsterProxy.<StartSkillInteract>d__31 <StartSkillInteract>d__;
			<StartSkillInteract>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartSkillInteract>d__.<>4__this = this;
			<StartSkillInteract>d__.<>1__state = -1;
			<StartSkillInteract>d__.<>t__builder.Start<PhantomArenaAreaMonsterProxy.<StartSkillInteract>d__31>(ref <StartSkillInteract>d__);
			return <StartSkillInteract>d__.<>t__builder.Task;
		}

		// Token: 0x0602B30B RID: 176907 RVA: 0x00C2345B File Offset: 0x00C2165B
		public void CancelSkillInteract()
		{
			this.AreaItem.SetIncreaseActive(false).Forget();
		}

		// Token: 0x0602B30C RID: 176908 RVA: 0x00C2346E File Offset: 0x00C2166E
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

		// Token: 0x0602B30D RID: 176909 RVA: 0x00C2349B File Offset: 0x00C2169B
		public ISkillTriggerInfo GetData()
		{
			return PhantomArenaBattleModel.Instance.BuffEffectData.CardSkillTriggerInfo;
		}

		// Token: 0x04017514 RID: 95508
		[Nullable(2)]
		private ISkillInteractMainUiInteract UiInteract;

		// Token: 0x04017515 RID: 95509
		private bool IsCanDrag;

		// Token: 0x04017516 RID: 95510
		private bool IsInSkillPoint;

		// Token: 0x04017517 RID: 95511
		public bool IsInSkillInteract;
	}
}

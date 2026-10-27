using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.Area.Hand;
using CSharpScript.Game.Module.PhantomArena.Battle.Canvas;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Area.Functional
{
	// Token: 0x020052CE RID: 21198
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaAreaFunctionalProxy : PhantomArenaAreaProxyBase, IAreaCanvas, ISkillInteractMainInterface
	{
		// Token: 0x170082F2 RID: 33522
		// (get) Token: 0x060363D1 RID: 222161 RVA: 0x00CD5088 File Offset: 0x00CD3288
		// (set) Token: 0x060363D2 RID: 222162 RVA: 0x00CD5095 File Offset: 0x00CD3295
		public new PhantomArenaAreaFunctionalItem AreaItem
		{
			get
			{
				return base.AreaItem as PhantomArenaAreaFunctionalItem;
			}
			set
			{
				base.AreaItem = value;
			}
		}

		// Token: 0x170082F3 RID: 33523
		// (get) Token: 0x060363D3 RID: 222163 RVA: 0x00CD509E File Offset: 0x00CD329E
		public override EPhantomArenaCardAreaType AreaType
		{
			get
			{
				return EPhantomArenaCardAreaType.Functional;
			}
		}

		// Token: 0x060363D4 RID: 222164 RVA: 0x00CD50A1 File Offset: 0x00CD32A1
		public PhantomArenaAreaFunctionalProxy(int index, PhantomArenaFunctionalArea area) : base(index, area)
		{
		}

		// Token: 0x060363D5 RID: 222165 RVA: 0x00CD50AB File Offset: 0x00CD32AB
		private void MagicUseCard()
		{
			if (this.Card != null)
			{
				this.Card.MagicUse().Forget();
				this.Card = null;
			}
		}

		// Token: 0x060363D6 RID: 222166 RVA: 0x00CD50CC File Offset: 0x00CD32CC
		[NullableContext(0)]
		protected UniTask<bool> OnHandleAreaBySetCard()
		{
			PhantomArenaAreaFunctionalProxy.<OnHandleAreaBySetCard>d__8 <OnHandleAreaBySetCard>d__;
			<OnHandleAreaBySetCard>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnHandleAreaBySetCard>d__.<>4__this = this;
			<OnHandleAreaBySetCard>d__.<>1__state = -1;
			<OnHandleAreaBySetCard>d__.<>t__builder.Start<PhantomArenaAreaFunctionalProxy.<OnHandleAreaBySetCard>d__8>(ref <OnHandleAreaBySetCard>d__);
			return <OnHandleAreaBySetCard>d__.<>t__builder.Task;
		}

		// Token: 0x060363D7 RID: 222167 RVA: 0x00CD5110 File Offset: 0x00CD3310
		protected void ResetCardProxy()
		{
			if (this.Card != null)
			{
				if (this.Card.Data.Index == -1)
				{
					PhantomArenaHandCardProxy cardProxy = this.ParentArea.ParentArea.HandArea.GetCardProxy(this.Card.Data.CardId);
					this.Card.SetCardProxy(cardProxy);
					this.SetCard(null).Forget();
					return;
				}
				PhantomArenaAreaProxyBase cardProxyByIndex = this.ParentArea.ParentArea.FunctionalArea.GetCardProxyByIndex(this.Card.Data.Index);
				this.Card.SetCardProxy(cardProxyByIndex.GetCardProxy());
				this.SetCard(null).Forget();
			}
		}

		// Token: 0x060363D8 RID: 222168 RVA: 0x00CD51C0 File Offset: 0x00CD33C0
		[NullableContext(0)]
		protected override UniTask<bool> OnHandleCardSetting([Nullable(1)] PhantomArenaCard card)
		{
			PhantomArenaAreaFunctionalProxy.<OnHandleCardSetting>d__10 <OnHandleCardSetting>d__;
			<OnHandleCardSetting>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnHandleCardSetting>d__.<>4__this = this;
			<OnHandleCardSetting>d__.card = card;
			<OnHandleCardSetting>d__.<>1__state = -1;
			<OnHandleCardSetting>d__.<>t__builder.Start<PhantomArenaAreaFunctionalProxy.<OnHandleCardSetting>d__10>(ref <OnHandleCardSetting>d__);
			return <OnHandleCardSetting>d__.<>t__builder.Task;
		}

		// Token: 0x060363D9 RID: 222169 RVA: 0x00CD520C File Offset: 0x00CD340C
		public override bool CheckGuideCondition(PhantomArenaCard card)
		{
			if (card.Data.Index == -1)
			{
				int handIndexByCardId = PhantomArenaBattleModel.Instance.OwnData.GetHandIndexByCardId(card.Data.CardId);
				return this.ParentArea.ParentArea.ViewProxy.GuideManager.CheckCanExecuteAndShowFailTips(EBvbPlayerOperationType.BvbChangeHandCard, new object[]
				{
					handIndexByCardId
				});
			}
			return this.ParentArea.ParentArea.ViewProxy.GuideManager.CheckCanExecuteAndShowFailTips(EBvbPlayerOperationType.BvbChangeBoardCard, new object[]
			{
				card.Data.Index
			});
		}

		// Token: 0x060363DA RID: 222170 RVA: 0x00CD52A4 File Offset: 0x00CD34A4
		public override bool CheckSettingCardCondition(PhantomArenaCard card)
		{
			bool flag;
			EPhantomCardSettingFailReason ephantomCardSettingFailReason;
			card.CardLogic.CheckFunctionalSettingCondition(this.Card).Deconstruct(out flag, out ephantomCardSettingFailReason);
			bool result = flag;
			EPhantomCardSettingFailReason settingFailReason = ephantomCardSettingFailReason;
			this.SettingFailReason = settingFailReason;
			return result;
		}

		// Token: 0x060363DB RID: 222171 RVA: 0x00CD52D5 File Offset: 0x00CD34D5
		protected override UUIItem GetCardRootItem()
		{
			return this.AreaItem.GetCardRootItem();
		}

		// Token: 0x060363DC RID: 222172 RVA: 0x00CD52E2 File Offset: 0x00CD34E2
		public bool CheckCanvasSortOrder(List<EPhantomArenaInteractTag> tagList, ISkillTriggerInfo skillTriggerInfo)
		{
			return this.Card != null;
		}

		// Token: 0x060363DD RID: 222173 RVA: 0x00CD52F0 File Offset: 0x00CD34F0
		public void HandleSortOrder()
		{
			if (this.Card != null)
			{
				this.Card.OverrideCanvasSortOrder(true);
				ULGUICanvas renderCanvas = this.AreaItem.GetCardRootItem().GetRenderCanvas();
				if (renderCanvas != null)
				{
					renderCanvas.SetSortOrderNew(2, true);
				}
				this.Card.PlayStateSequence("PointStart");
				this.InSkillInteract = true;
			}
		}

		// Token: 0x060363DE RID: 222174 RVA: 0x00CD5344 File Offset: 0x00CD3544
		public void CancelSortOrder()
		{
			if (this.Card != null)
			{
				this.Card.OverrideCanvasSortOrder(false);
				ULGUICanvas renderCanvas = this.AreaItem.GetCardRootItem().GetRenderCanvas();
				if (renderCanvas != null)
				{
					renderCanvas.SetSortOrderNew(0, true);
				}
				this.Card.PlayStateSequence("PointClose");
				this.InSkillInteract = false;
			}
		}

		// Token: 0x060363DF RID: 222175 RVA: 0x00CD5398 File Offset: 0x00CD3598
		public UniTask StartSkillInteract()
		{
			PhantomArenaAreaFunctionalProxy.<StartSkillInteract>d__17 <StartSkillInteract>d__;
			<StartSkillInteract>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartSkillInteract>d__.<>4__this = this;
			<StartSkillInteract>d__.<>1__state = -1;
			<StartSkillInteract>d__.<>t__builder.Start<PhantomArenaAreaFunctionalProxy.<StartSkillInteract>d__17>(ref <StartSkillInteract>d__);
			return <StartSkillInteract>d__.<>t__builder.Task;
		}

		// Token: 0x060363E0 RID: 222176 RVA: 0x00CD53DC File Offset: 0x00CD35DC
		public void CancelSkillInteract()
		{
			this.AreaItem.SetIncreaseActive(false).Forget();
			if (this.Card != null)
			{
				if (this.Card.Data.Index != -1)
				{
					this.ParentArea.ParentArea.FunctionalArea.ResetFunctionalToMonster(this.Card, this.Card.Data.Index, this.Index).Forget();
					return;
				}
				this.ParentArea.ParentArea.ResetFunctionalToHand(this.Card, this.Index);
			}
		}

		// Token: 0x060363E1 RID: 222177 RVA: 0x00CD5468 File Offset: 0x00CD3668
		public ISkillTriggerInfo GetData()
		{
			return PhantomArenaBattleModel.Instance.BuffEffectData.CardSkillTriggerInfo;
		}

		// Token: 0x060363E2 RID: 222178 RVA: 0x00CD5479 File Offset: 0x00CD3679
		public void FinishSkillInteract()
		{
			this.AreaItem.SetIncreaseActive(false).Forget();
			base.DestroyCard();
			this.ParentArea.FinishBuffEffect(this.Index);
		}

		// Token: 0x060363E3 RID: 222179 RVA: 0x00CD54A3 File Offset: 0x00CD36A3
		[NullableContext(2)]
		public void ReceiveUiInteract(ISkillInteractMainUiInteract uiInteract)
		{
		}

		// Token: 0x0401CAD8 RID: 117464
		public bool InSkillInteract;
	}
}

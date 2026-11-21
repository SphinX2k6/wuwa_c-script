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
	// Token: 0x0200429E RID: 17054
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaAreaFunctionalProxy : PhantomArenaAreaProxyBase, IAreaCanvas, ISkillInteractMainInterface
	{
		// Token: 0x170056B2 RID: 22194
		// (get) Token: 0x0602B2CC RID: 176844 RVA: 0x00C227B0 File Offset: 0x00C209B0
		// (set) Token: 0x0602B2CD RID: 176845 RVA: 0x00C227BD File Offset: 0x00C209BD
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

		// Token: 0x170056B3 RID: 22195
		// (get) Token: 0x0602B2CE RID: 176846 RVA: 0x00C227C6 File Offset: 0x00C209C6
		public override EPhantomArenaCardAreaType AreaType
		{
			get
			{
				return EPhantomArenaCardAreaType.Functional;
			}
		}

		// Token: 0x0602B2CF RID: 176847 RVA: 0x00C227C9 File Offset: 0x00C209C9
		public PhantomArenaAreaFunctionalProxy(int index, PhantomArenaFunctionalArea area) : base(index, area)
		{
		}

		// Token: 0x0602B2D0 RID: 176848 RVA: 0x00C227D3 File Offset: 0x00C209D3
		private void MagicUseCard()
		{
			if (this.Card != null)
			{
				this.Card.MagicUse().Forget();
				this.Card = null;
			}
		}

		// Token: 0x0602B2D1 RID: 176849 RVA: 0x00C227F4 File Offset: 0x00C209F4
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

		// Token: 0x0602B2D2 RID: 176850 RVA: 0x00C22838 File Offset: 0x00C20A38
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

		// Token: 0x0602B2D3 RID: 176851 RVA: 0x00C228E8 File Offset: 0x00C20AE8
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

		// Token: 0x0602B2D4 RID: 176852 RVA: 0x00C22934 File Offset: 0x00C20B34
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

		// Token: 0x0602B2D5 RID: 176853 RVA: 0x00C229CC File Offset: 0x00C20BCC
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

		// Token: 0x0602B2D6 RID: 176854 RVA: 0x00C229FD File Offset: 0x00C20BFD
		protected override UUIItem GetCardRootItem()
		{
			return this.AreaItem.GetCardRootItem();
		}

		// Token: 0x0602B2D7 RID: 176855 RVA: 0x00C22A0A File Offset: 0x00C20C0A
		public bool CheckCanvasSortOrder(List<EPhantomArenaInteractTag> tagList, ISkillTriggerInfo skillTriggerInfo)
		{
			return this.Card != null;
		}

		// Token: 0x0602B2D8 RID: 176856 RVA: 0x00C22A18 File Offset: 0x00C20C18
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

		// Token: 0x0602B2D9 RID: 176857 RVA: 0x00C22A6C File Offset: 0x00C20C6C
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

		// Token: 0x0602B2DA RID: 176858 RVA: 0x00C22AC0 File Offset: 0x00C20CC0
		public UniTask StartSkillInteract()
		{
			PhantomArenaAreaFunctionalProxy.<StartSkillInteract>d__17 <StartSkillInteract>d__;
			<StartSkillInteract>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartSkillInteract>d__.<>4__this = this;
			<StartSkillInteract>d__.<>1__state = -1;
			<StartSkillInteract>d__.<>t__builder.Start<PhantomArenaAreaFunctionalProxy.<StartSkillInteract>d__17>(ref <StartSkillInteract>d__);
			return <StartSkillInteract>d__.<>t__builder.Task;
		}

		// Token: 0x0602B2DB RID: 176859 RVA: 0x00C22B04 File Offset: 0x00C20D04
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

		// Token: 0x0602B2DC RID: 176860 RVA: 0x00C22B90 File Offset: 0x00C20D90
		public ISkillTriggerInfo GetData()
		{
			return PhantomArenaBattleModel.Instance.BuffEffectData.CardSkillTriggerInfo;
		}

		// Token: 0x0602B2DD RID: 176861 RVA: 0x00C22BA1 File Offset: 0x00C20DA1
		public void FinishSkillInteract()
		{
			this.AreaItem.SetIncreaseActive(false).Forget();
			base.DestroyCard();
			this.ParentArea.FinishBuffEffect(this.Index);
		}

		// Token: 0x0602B2DE RID: 176862 RVA: 0x00C22BCB File Offset: 0x00C20DCB
		[NullableContext(2)]
		public void ReceiveUiInteract(ISkillInteractMainUiInteract uiInteract)
		{
		}

		// Token: 0x0401750D RID: 95501
		public bool InSkillInteract;
	}
}

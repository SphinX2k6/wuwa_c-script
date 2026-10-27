using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena.Battle.Area;
using CSharpScript.Game.Module.PhantomArena.Battle.Area.Functional;
using CSharpScript.Game.Module.PhantomArena.Battle.Area.Hand;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.Opponent;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Choose;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Discard;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Panel;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View
{
	// Token: 0x0200524D RID: 21069
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleView : UiViewBase
	{
		// Token: 0x06035D49 RID: 220489 RVA: 0x00CBC6AF File Offset: 0x00CBA8AF
		public PhantomArenaBattleView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06035D4A RID: 220490 RVA: 0x00CBC6C0 File Offset: 0x00CBA8C0
		protected override void OnRegisterComponent()
		{
			this.Proxy = new PhantomArenaBattleProxy();
			this.Proxy.RegisterView(this);
			this.OpenParam = this.Proxy;
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIText)),
				new ValueTuple<int, Type>(13, typeof(UUIText)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUIItem)),
				new ValueTuple<int, Type>(16, typeof(UUIText)),
				new ValueTuple<int, Type>(17, typeof(UUIItem)),
				new ValueTuple<int, Type>(18, typeof(UUIItem)),
				new ValueTuple<int, Type>(19, typeof(UUIText)),
				new ValueTuple<int, Type>(20, typeof(UUIItem)),
				new ValueTuple<int, Type>(21, typeof(UUIItem)),
				new ValueTuple<int, Type>(22, typeof(UUIItem)),
				new ValueTuple<int, Type>(23, typeof(UUIItem)),
				new ValueTuple<int, Type>(24, typeof(UUISprite)),
				new ValueTuple<int, Type>(25, typeof(UUISprite)),
				new ValueTuple<int, Type>(26, typeof(UUIItem)),
				new ValueTuple<int, Type>(27, typeof(UUITexture)),
				new ValueTuple<int, Type>(28, typeof(UUIItem)),
				new ValueTuple<int, Type>(29, typeof(UUINiagara)),
				new ValueTuple<int, Type>(30, typeof(UUINiagara)),
				new ValueTuple<int, Type>(31, typeof(UUINiagara)),
				new ValueTuple<int, Type>(32, typeof(UUINiagara)),
				new ValueTuple<int, Type>(33, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(5, new Action(this.Proxy.HideLayoutClick)),
				new ValueTuple<int, Delegate>(7, new Action(this.Proxy.TimeEndClick))
			};
		}

		// Token: 0x06035D4B RID: 220491 RVA: 0x00CBCA48 File Offset: 0x00CBAC48
		private UniTask InitLibrarySprite()
		{
			PhantomArenaBattleView.<InitLibrarySprite>d__7 <InitLibrarySprite>d__;
			<InitLibrarySprite>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLibrarySprite>d__.<>4__this = this;
			<InitLibrarySprite>d__.<>1__state = -1;
			<InitLibrarySprite>d__.<>t__builder.Start<PhantomArenaBattleView.<InitLibrarySprite>d__7>(ref <InitLibrarySprite>d__);
			return <InitLibrarySprite>d__.<>t__builder.Task;
		}

		// Token: 0x06035D4C RID: 220492 RVA: 0x00CBCA8C File Offset: 0x00CBAC8C
		private UniTask InitDesktopBg()
		{
			PhantomArenaBattleView.<InitDesktopBg>d__8 <InitDesktopBg>d__;
			<InitDesktopBg>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDesktopBg>d__.<>4__this = this;
			<InitDesktopBg>d__.<>1__state = -1;
			<InitDesktopBg>d__.<>t__builder.Start<PhantomArenaBattleView.<InitDesktopBg>d__8>(ref <InitDesktopBg>d__);
			return <InitDesktopBg>d__.<>t__builder.Task;
		}

		// Token: 0x06035D4D RID: 220493 RVA: 0x00CBCAD0 File Offset: 0x00CBACD0
		private void InitCaption()
		{
			this.Proxy.CaptionItem = new PopupCaptionItem(base.GetItem(15));
			this.Proxy.CaptionItem.SetCloseCallBack(new Action(this.Proxy.CloseClick));
			this.Proxy.CaptionItem.SetHelpCallBack(new Action(this.Proxy.HelpClick));
		}

		// Token: 0x06035D4E RID: 220494 RVA: 0x00CBCB38 File Offset: 0x00CBAD38
		private UniTask InitOwnArea()
		{
			PhantomArenaBattleView.<InitOwnArea>d__10 <InitOwnArea>d__;
			<InitOwnArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitOwnArea>d__.<>4__this = this;
			<InitOwnArea>d__.<>1__state = -1;
			<InitOwnArea>d__.<>t__builder.Start<PhantomArenaBattleView.<InitOwnArea>d__10>(ref <InitOwnArea>d__);
			return <InitOwnArea>d__.<>t__builder.Task;
		}

		// Token: 0x06035D4F RID: 220495 RVA: 0x00CBCB7C File Offset: 0x00CBAD7C
		private UniTask InitOpponentArea()
		{
			PhantomArenaBattleView.<InitOpponentArea>d__11 <InitOpponentArea>d__;
			<InitOpponentArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitOpponentArea>d__.<>4__this = this;
			<InitOpponentArea>d__.<>1__state = -1;
			<InitOpponentArea>d__.<>t__builder.Start<PhantomArenaBattleView.<InitOpponentArea>d__11>(ref <InitOpponentArea>d__);
			return <InitOpponentArea>d__.<>t__builder.Task;
		}

		// Token: 0x06035D50 RID: 220496 RVA: 0x00CBCBC0 File Offset: 0x00CBADC0
		private UniTask InitCardLibrary()
		{
			PhantomArenaBattleView.<InitCardLibrary>d__12 <InitCardLibrary>d__;
			<InitCardLibrary>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCardLibrary>d__.<>4__this = this;
			<InitCardLibrary>d__.<>1__state = -1;
			<InitCardLibrary>d__.<>t__builder.Start<PhantomArenaBattleView.<InitCardLibrary>d__12>(ref <InitCardLibrary>d__);
			return <InitCardLibrary>d__.<>t__builder.Task;
		}

		// Token: 0x06035D51 RID: 220497 RVA: 0x00CBCC04 File Offset: 0x00CBAE04
		private UniTask InitTipsItem()
		{
			PhantomArenaBattleView.<InitTipsItem>d__13 <InitTipsItem>d__;
			<InitTipsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTipsItem>d__.<>4__this = this;
			<InitTipsItem>d__.<>1__state = -1;
			<InitTipsItem>d__.<>t__builder.Start<PhantomArenaBattleView.<InitTipsItem>d__13>(ref <InitTipsItem>d__);
			return <InitTipsItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035D52 RID: 220498 RVA: 0x00CBCC48 File Offset: 0x00CBAE48
		private UniTask InitDetailsTips()
		{
			PhantomArenaBattleView.<InitDetailsTips>d__14 <InitDetailsTips>d__;
			<InitDetailsTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDetailsTips>d__.<>4__this = this;
			<InitDetailsTips>d__.<>1__state = -1;
			<InitDetailsTips>d__.<>t__builder.Start<PhantomArenaBattleView.<InitDetailsTips>d__14>(ref <InitDetailsTips>d__);
			return <InitDetailsTips>d__.<>t__builder.Task;
		}

		// Token: 0x06035D53 RID: 220499 RVA: 0x00CBCC8C File Offset: 0x00CBAE8C
		private UniTask InitSkillTips()
		{
			PhantomArenaBattleView.<InitSkillTips>d__15 <InitSkillTips>d__;
			<InitSkillTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSkillTips>d__.<>4__this = this;
			<InitSkillTips>d__.<>1__state = -1;
			<InitSkillTips>d__.<>t__builder.Start<PhantomArenaBattleView.<InitSkillTips>d__15>(ref <InitSkillTips>d__);
			return <InitSkillTips>d__.<>t__builder.Task;
		}

		// Token: 0x06035D54 RID: 220500 RVA: 0x00CBCCD0 File Offset: 0x00CBAED0
		private UniTask InitDiscardPanel()
		{
			PhantomArenaBattleView.<InitDiscardPanel>d__16 <InitDiscardPanel>d__;
			<InitDiscardPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDiscardPanel>d__.<>4__this = this;
			<InitDiscardPanel>d__.<>1__state = -1;
			<InitDiscardPanel>d__.<>t__builder.Start<PhantomArenaBattleView.<InitDiscardPanel>d__16>(ref <InitDiscardPanel>d__);
			return <InitDiscardPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06035D55 RID: 220501 RVA: 0x00CBCD14 File Offset: 0x00CBAF14
		private UniTask InitChooseCardPanel()
		{
			PhantomArenaBattleView.<InitChooseCardPanel>d__17 <InitChooseCardPanel>d__;
			<InitChooseCardPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitChooseCardPanel>d__.<>4__this = this;
			<InitChooseCardPanel>d__.<>1__state = -1;
			<InitChooseCardPanel>d__.<>t__builder.Start<PhantomArenaBattleView.<InitChooseCardPanel>d__17>(ref <InitChooseCardPanel>d__);
			return <InitChooseCardPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06035D56 RID: 220502 RVA: 0x00CBCD58 File Offset: 0x00CBAF58
		private UniTask InitSkillTriggerMask()
		{
			PhantomArenaBattleView.<InitSkillTriggerMask>d__18 <InitSkillTriggerMask>d__;
			<InitSkillTriggerMask>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSkillTriggerMask>d__.<>4__this = this;
			<InitSkillTriggerMask>d__.<>1__state = -1;
			<InitSkillTriggerMask>d__.<>t__builder.Start<PhantomArenaBattleView.<InitSkillTriggerMask>d__18>(ref <InitSkillTriggerMask>d__);
			return <InitSkillTriggerMask>d__.<>t__builder.Task;
		}

		// Token: 0x06035D57 RID: 220503 RVA: 0x00CBCD9C File Offset: 0x00CBAF9C
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaBattleView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaBattleView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035D58 RID: 220504 RVA: 0x00CBCDE0 File Offset: 0x00CBAFE0
		protected override void OnStart()
		{
			this.DissolveTween = new LguiFloatTween();
			this.DissolveTween.SetCurrentEase(LTweenEase.InOutSine);
			this.DissolveTween.BindUpdateTween(new Action<float>(this.OnDissolveTweenUpdate));
			this.SetNiagaraNpcActive(false);
			this.SetNiagaraPlayerActive(false);
			this.SetNiagaraNpcStartActive(false);
			this.Proxy.BanButtonClickModule.RegisterButton(base.GetButton(7));
			this.Proxy.BanButtonClickModule.RegisterButton(this.Proxy.CaptionItem.GetCloseBtn());
			this.Proxy.BanButtonClickModule.RegisterButton(this.Proxy.CaptionItem.GetHelpBtn());
		}

		// Token: 0x06035D59 RID: 220505 RVA: 0x00CBCE88 File Offset: 0x00CBB088
		protected override void OnBeforeShow()
		{
			if (this.FirstShowDirty)
			{
				this.FirstShowDirty = false;
				return;
			}
			this.Proxy.Show(false);
		}

		// Token: 0x06035D5A RID: 220506 RVA: 0x00CBCEA8 File Offset: 0x00CBB0A8
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OwnBattleStatusChange, new Action<IReadOnlyList<PhantomBattleRoleStatus>>(this.Proxy.OnOwnBattleStatusChange));
			EventSystem.Instance.Add(EEventName.OpponentBattleStatusChange, new Action<IReadOnlyList<PhantomBattleRoleStatus>>(this.Proxy.OnOpponentBattleStatusChange));
			EventSystem.Instance.Add(EEventName.OwnCardLibraryChange, new Action(this.Proxy.OnOwnCardLibraryChange));
			EventSystem.Instance.Add(EEventName.OpponentHandCardChange, new Action(this.Proxy.OnOpponentHandCardChange));
			EventSystem.Instance.Add(EEventName.OpponentCardLibraryChange, new Action(this.Proxy.OnOpponentCardLibraryChange));
			EventSystem.Instance.Add(EEventName.OwnHandCardAdd, new Action<IReadOnlyList<int>>(this.Proxy.OnOwnHandCardAdd));
			EventSystem.Instance.Add(EEventName.PhantomArenaTriggerSkillEffect, new Action(this.Proxy.OnTriggerSkillEffect));
			EventSystem.Instance.Add(EEventName.NotifyCardTaskData, new Action<bool>(this.Proxy.OnNotifyCardTaskData));
			EventSystem.Instance.Add(EEventName.OwnHandCardRemove, new Action<IReadOnlyList<int>>(this.Proxy.OnOwnHandCardRemove));
			EventSystem.Instance.Add(EEventName.PhantomArenaCardAttrRefresh, new Action<int>(this.Proxy.OnCardAttrRefresh));
			EventSystem.Instance.Add(EEventName.PhantomArenaCardFactorsRefresh, new Action<int>(this.Proxy.OnCardFactorsRefresh));
			EventSystem.Instance.Add(EEventName.NotifyBattleCardChange, new Action<bool, int, int>(this.Proxy.OnNotifyBattleCardChange));
			EventSystem.Instance.Add(EEventName.OwnBattleAttrChange, new Action<IReadOnlyList<PhantomBattleCardAttr>>(this.Proxy.OnOwnBattleAttrChange));
			EventSystem.Instance.Add(EEventName.OpponentBattleAttrChange, new Action<IReadOnlyList<PhantomBattleCardAttr>>(this.Proxy.OnOpponentBattleAttrChange));
			EventSystem.Instance.Add(EEventName.RefreshRound, new Action(this.Proxy.OnRefreshRound));
			EventSystem.Instance.Add(EEventName.RefreshBattleCardNum, new Action(this.Proxy.OnRefreshBattleCardNum));
			EventSystem.Instance.Add(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.Proxy.OnInputControllerMainTypeChange));
			EventSystem.Instance.Add(EEventName.RefreshHandCardState, new Action(this.Proxy.OnRefreshHandCardState));
			EventSystem.Instance.Add(EEventName.PhantomBattleBoardSettleNotify, new Action(this.Proxy.OnPhantomBattleBoardSettleNotify));
			EventSystem.Instance.Add(EEventName.OpponentSealFieldChange, new Action<int>(this.Proxy.OnOpponentSealFieldChange));
			EventSystem.Instance.Add(EEventName.OwnSealRecycleChange, new Action<int>(this.Proxy.OnOwnSealRecycleChange));
		}

		// Token: 0x06035D5B RID: 220507 RVA: 0x00CBD16C File Offset: 0x00CBB36C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OwnBattleStatusChange, new Action<IReadOnlyList<PhantomBattleRoleStatus>>(this.Proxy.OnOwnBattleStatusChange));
			EventSystem.Instance.Remove(EEventName.OpponentBattleStatusChange, new Action<IReadOnlyList<PhantomBattleRoleStatus>>(this.Proxy.OnOpponentBattleStatusChange));
			EventSystem.Instance.Remove(EEventName.OwnCardLibraryChange, new Action(this.Proxy.OnOwnCardLibraryChange));
			EventSystem.Instance.Remove(EEventName.OpponentHandCardChange, new Action(this.Proxy.OnOpponentHandCardChange));
			EventSystem.Instance.Remove(EEventName.OpponentCardLibraryChange, new Action(this.Proxy.OnOpponentCardLibraryChange));
			EventSystem.Instance.Remove(EEventName.OwnHandCardAdd, new Action<IReadOnlyList<int>>(this.Proxy.OnOwnHandCardAdd));
			EventSystem.Instance.Remove(EEventName.PhantomArenaTriggerSkillEffect, new Action(this.Proxy.OnTriggerSkillEffect));
			EventSystem.Instance.Remove(EEventName.NotifyCardTaskData, new Action<bool>(this.Proxy.OnNotifyCardTaskData));
			EventSystem.Instance.Remove(EEventName.OwnHandCardRemove, new Action<IReadOnlyList<int>>(this.Proxy.OnOwnHandCardRemove));
			EventSystem.Instance.Remove(EEventName.PhantomArenaCardAttrRefresh, new Action<int>(this.Proxy.OnCardAttrRefresh));
			EventSystem.Instance.Remove(EEventName.PhantomArenaCardFactorsRefresh, new Action<int>(this.Proxy.OnCardFactorsRefresh));
			EventSystem.Instance.Remove(EEventName.NotifyBattleCardChange, new Action<bool, int, int>(this.Proxy.OnNotifyBattleCardChange));
			EventSystem.Instance.Remove(EEventName.OwnBattleAttrChange, new Action<IReadOnlyList<PhantomBattleCardAttr>>(this.Proxy.OnOwnBattleAttrChange));
			EventSystem.Instance.Remove(EEventName.OpponentBattleAttrChange, new Action<IReadOnlyList<PhantomBattleCardAttr>>(this.Proxy.OnOpponentBattleAttrChange));
			EventSystem.Instance.Remove(EEventName.RefreshRound, new Action(this.Proxy.OnRefreshRound));
			EventSystem.Instance.Remove(EEventName.RefreshBattleCardNum, new Action(this.Proxy.OnRefreshBattleCardNum));
			EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.Proxy.OnInputControllerMainTypeChange));
			EventSystem.Instance.Remove(EEventName.RefreshHandCardState, new Action(this.Proxy.OnRefreshHandCardState));
			EventSystem.Instance.Remove(EEventName.PhantomBattleBoardSettleNotify, new Action(this.Proxy.OnPhantomBattleBoardSettleNotify));
			EventSystem.Instance.Remove(EEventName.OpponentSealFieldChange, new Action<int>(this.Proxy.OnOpponentSealFieldChange));
			EventSystem.Instance.Remove(EEventName.OwnSealRecycleChange, new Action<int>(this.Proxy.OnOwnSealRecycleChange));
		}

		// Token: 0x06035D5C RID: 220508 RVA: 0x00CBD42E File Offset: 0x00CBB62E
		protected override void OnBeforeDestroy()
		{
			this.Proxy.Destroy();
			this.DissolveTween.Destroy();
		}

		// Token: 0x06035D5D RID: 220509 RVA: 0x00CBD446 File Offset: 0x00CBB646
		public UUIItem GetDragRootItem()
		{
			return base.GetItem(4);
		}

		// Token: 0x06035D5E RID: 220510 RVA: 0x00CBD44F File Offset: 0x00CBB64F
		public UUIItem GetOwnCardLibraryItem()
		{
			return base.GetItem(17);
		}

		// Token: 0x06035D5F RID: 220511 RVA: 0x00CBD459 File Offset: 0x00CBB659
		public UUIItem GetOpponentCardLibraryItem()
		{
			return base.GetItem(18);
		}

		// Token: 0x06035D60 RID: 220512 RVA: 0x00CBD463 File Offset: 0x00CBB663
		public UUIItem GetSkillTriggerAttachItem()
		{
			return base.GetItem(6);
		}

		// Token: 0x06035D61 RID: 220513 RVA: 0x00CBD46C File Offset: 0x00CBB66C
		public void SetCaptionItemActive(bool bActive)
		{
			base.GetItem(15).SetUIActive(bActive);
		}

		// Token: 0x06035D62 RID: 220514 RVA: 0x00CBD47C File Offset: 0x00CBB67C
		public void SetRoundEffectActive(bool bActive)
		{
			base.GetItem(20).SetUIActive(bActive);
		}

		// Token: 0x06035D63 RID: 220515 RVA: 0x00CBD48C File Offset: 0x00CBB68C
		public void RefreshOwnCardLibraryNum()
		{
			int cardLibraryNum = PhantomArenaBattleModel.Instance.OwnData.CardLibraryNum;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(12), "PhantomBattle_1022", new <>z__ReadOnlySingleElementList<object>(cardLibraryNum));
		}

		// Token: 0x06035D64 RID: 220516 RVA: 0x00CBD4CC File Offset: 0x00CBB6CC
		public void RefreshOpponentCardLibraryNum()
		{
			int cardLibraryNum = PhantomArenaBattleModel.Instance.OpponentData.CardLibraryNum;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(13), "PhantomBattle_1022", new <>z__ReadOnlySingleElementList<object>(cardLibraryNum));
		}

		// Token: 0x06035D65 RID: 220517 RVA: 0x00CBD50C File Offset: 0x00CBB70C
		public void SetTimeEndBtnInteractive(bool bInteractive)
		{
			UUIButtonComponent button = base.GetButton(7);
			if (bInteractive)
			{
				this.Proxy.BanButtonClickModule.ResumeButton(button, "TimeEndBtn.SetTimeEndBtnInteractive");
				return;
			}
			this.Proxy.BanButtonClickModule.BanButton(button, "TimeEndBtn.SetTimeEndBtnInteractive");
		}

		// Token: 0x06035D66 RID: 220518 RVA: 0x00CBD554 File Offset: 0x00CBB754
		public void RefreshRoundNum()
		{
			int challengeId = PhantomArenaBattleModel.Instance.ChallengeId;
			PhantomBattleChallenge phantomBattleChallengeConfig = PhantomArenaConfig.Instance.GetPhantomBattleChallengeConfig(challengeId);
			int round = PhantomArenaBattleModel.Instance.Round;
			int maxRoundNum = phantomBattleChallengeConfig.MaxRoundNum;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(16), "PhantomBattle_1082", new <>z__ReadOnlyArray<object>(new object[]
			{
				round,
				maxRoundNum
			}));
		}

		// Token: 0x06035D67 RID: 220519 RVA: 0x00CBD5C0 File Offset: 0x00CBB7C0
		public void RefreshLimitText()
		{
			int monsterCardLength = PhantomArenaBattleModel.Instance.OwnData.MonsterCardLength;
			base.GetText(19).SetText(monsterCardLength.ToString() + "/" + 4.ToString(), true);
		}

		// Token: 0x06035D68 RID: 220520 RVA: 0x00CBD608 File Offset: 0x00CBB808
		public UniTask PlayShowFieldEffect()
		{
			PhantomArenaBattleView.<PlayShowFieldEffect>d__36 <PlayShowFieldEffect>d__;
			<PlayShowFieldEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayShowFieldEffect>d__.<>4__this = this;
			<PlayShowFieldEffect>d__.<>1__state = -1;
			<PlayShowFieldEffect>d__.<>t__builder.Start<PhantomArenaBattleView.<PlayShowFieldEffect>d__36>(ref <PlayShowFieldEffect>d__);
			return <PlayShowFieldEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06035D69 RID: 220521 RVA: 0x00CBD64B File Offset: 0x00CBB84B
		public void LockNpcField()
		{
			this.DissolveTween.PlayTween(0.55f, 0f, 0.5f, null);
		}

		// Token: 0x06035D6A RID: 220522 RVA: 0x00CBD668 File Offset: 0x00CBB868
		public void UnlockNpcField()
		{
			this.RefreshNiagaraNpc();
			this.SetNiagaraNpcActive(true);
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.PlaySequencePurely("FieldReleaseNpc", false, false);
			}
			this.DissolveTween.PlayTween(0f, 0.55f, 0.5f, null);
		}

		// Token: 0x06035D6B RID: 220523 RVA: 0x00CBD6B5 File Offset: 0x00CBB8B5
		private void SetNiagaraNpcActive(bool value)
		{
			base.GetUiNiagara(30).SetUIActive(value);
		}

		// Token: 0x06035D6C RID: 220524 RVA: 0x00CBD6C5 File Offset: 0x00CBB8C5
		private void SetNiagaraNpcStartActive(bool value)
		{
			base.GetUiNiagara(31).SetUIActive(value);
		}

		// Token: 0x06035D6D RID: 220525 RVA: 0x00CBD6D5 File Offset: 0x00CBB8D5
		private void SetNiagaraPlayerActive(bool value)
		{
			base.GetUiNiagara(29).SetUIActive(value);
		}

		// Token: 0x06035D6E RID: 220526 RVA: 0x00CBD6E8 File Offset: 0x00CBB8E8
		private void RefreshNiagaraNpc()
		{
			PhantomArenaFieldData fieldData = PhantomArenaBattleModel.Instance.OpponentData.FieldData;
			if (fieldData == null)
			{
				return;
			}
			UUINiagara uiNiagara = base.GetUiNiagara(30);
			if (!StringUtils.IsBlank(fieldData.BaseColor))
			{
				FColor fcolor = FColor.FromHex(fieldData.BaseColor);
				FLinearColor value = new FLinearColor(ref fcolor);
				uiNiagara.SetNiagaraVarLinearColor("Base_Color", value);
			}
			if (!StringUtils.IsBlank(fieldData.BackGroundColor))
			{
				FColor fcolor = FColor.FromHex(fieldData.BackGroundColor);
				FLinearColor value2 = new FLinearColor(ref fcolor);
				uiNiagara.SetNiagaraVarLinearColor("Background_Color", value2);
			}
		}

		// Token: 0x06035D6F RID: 220527 RVA: 0x00CBD770 File Offset: 0x00CBB970
		private UniTask RefreshPlayerTexture()
		{
			PhantomArenaBattleView.<RefreshPlayerTexture>d__43 <RefreshPlayerTexture>d__;
			<RefreshPlayerTexture>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshPlayerTexture>d__.<>4__this = this;
			<RefreshPlayerTexture>d__.<>1__state = -1;
			<RefreshPlayerTexture>d__.<>t__builder.Start<PhantomArenaBattleView.<RefreshPlayerTexture>d__43>(ref <RefreshPlayerTexture>d__);
			return <RefreshPlayerTexture>d__.<>t__builder.Task;
		}

		// Token: 0x06035D70 RID: 220528 RVA: 0x00CBD7B4 File Offset: 0x00CBB9B4
		private UniTask RefreshNiagaraPlayer()
		{
			PhantomArenaBattleView.<RefreshNiagaraPlayer>d__44 <RefreshNiagaraPlayer>d__;
			<RefreshNiagaraPlayer>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshNiagaraPlayer>d__.<>4__this = this;
			<RefreshNiagaraPlayer>d__.<>1__state = -1;
			<RefreshNiagaraPlayer>d__.<>t__builder.Start<PhantomArenaBattleView.<RefreshNiagaraPlayer>d__44>(ref <RefreshNiagaraPlayer>d__);
			return <RefreshNiagaraPlayer>d__.<>t__builder.Task;
		}

		// Token: 0x06035D71 RID: 220529 RVA: 0x00CBD7F8 File Offset: 0x00CBB9F8
		protected override UUIItem OnGetBlurRootItem()
		{
			if (this.Proxy.IsMainInVisible)
			{
				return this.RootItem;
			}
			if (this.Proxy.InPanelInteractType == EPhantomArenaBattlePanelInteractType.ChooseCardPanel)
			{
				return this.Proxy.ChooseCardPanel.GetRootItem();
			}
			if (this.Proxy.InPanelInteractType == EPhantomArenaBattlePanelInteractType.DiscardCardPanel)
			{
				return this.Proxy.DiscardPanel.GetRootItem();
			}
			return this.RootItem;
		}

		// Token: 0x06035D72 RID: 220530 RVA: 0x00CBD85D File Offset: 0x00CBBA5D
		private void SetNiagaraNpcDissolve(float value)
		{
			base.GetUiNiagara(30).SetNiagaraVarFloat("Dissolve", value);
		}

		// Token: 0x06035D73 RID: 220531 RVA: 0x00CBD872 File Offset: 0x00CBBA72
		private void OnDissolveTweenUpdate(float value)
		{
			this.SetNiagaraNpcDissolve(value);
		}

		// Token: 0x06035D74 RID: 220532 RVA: 0x00CBD87C File Offset: 0x00CBBA7C
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			string a = configParams[0];
			if (a == "CardEffect" || a == "CardAttr" || a == "DetailCard" || a == "CardFullInfo")
			{
				PhantomArenaBattleTips tipsItem = this.Proxy.TipsItem;
				if (tipsItem == null)
				{
					return null;
				}
				return tipsItem.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
			else if (a == "BattleCard" || a == "BattleCardById" || a == "BattleCardSkillById")
			{
				if (configParams[1] == "Own")
				{
					PhantomArenaFunctionalArea functionalArea = this.Proxy.OwnArea.FunctionalArea;
					if (functionalArea == null)
					{
						return null;
					}
					return functionalArea.GetGuideUiItemAndUiItemForShowEx(configParams);
				}
				else
				{
					OpponentFunctionArea functionalArea2 = this.Proxy.OpponentArea.FunctionalArea;
					if (functionalArea2 == null)
					{
						return null;
					}
					return functionalArea2.GetGuideUiItemAndUiItemForShowEx(configParams);
				}
			}
			else if (a == "HandCard")
			{
				PhantomArenaOwnArea ownArea = this.Proxy.OwnArea;
				if (ownArea == null)
				{
					return null;
				}
				PhantomArenaHandArea handArea = ownArea.HandArea;
				if (handArea == null)
				{
					return null;
				}
				return handArea.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
			else
			{
				if (a == "HandArea")
				{
					PhantomArenaOwnArea ownArea2 = this.Proxy.OwnArea;
					UUIItem[] array;
					if (ownArea2 == null)
					{
						array = null;
					}
					else
					{
						PhantomArenaHandArea handArea2 = ownArea2.HandArea;
						array = ((handArea2 != null) ? handArea2.GetGuideUiItemAndUiItemForShowEx(configParams) : null);
					}
					UUIItem[] array2 = array;
					if (array2 != null && array2.Length > 1)
					{
						array2[1] = base.GetGuideUiItem("8");
					}
					return array2;
				}
				if (a == "Task")
				{
					PhantomArenaOwnArea ownArea3 = this.Proxy.OwnArea;
					if (ownArea3 == null)
					{
						return null;
					}
					PhantomArenaOwnRolePanel rolePanel = ownArea3.RolePanel;
					if (rolePanel == null)
					{
						return null;
					}
					return rolePanel.GetGuideUiItemAndUiItemForShowEx(configParams);
				}
				else if (a == "BattleCardDiscardById")
				{
					PhantomArenaDiscardCardPanel discardPanel = this.Proxy.DiscardPanel;
					if (discardPanel == null)
					{
						return null;
					}
					return discardPanel.GetGuideUiItemAndUiItemForShowEx(configParams);
				}
				else
				{
					if (!(a == "BattleCardChooseById"))
					{
						return null;
					}
					PhantomArenaChooseCardPanel chooseCardPanel = this.Proxy.ChooseCardPanel;
					if (chooseCardPanel == null)
					{
						return null;
					}
					return chooseCardPanel.GetGuideUiItemAndUiItemForShowEx(configParams);
				}
			}
		}

		// Token: 0x0401C89C RID: 116892
		private PhantomArenaBattleProxy Proxy;

		// Token: 0x0401C89D RID: 116893
		protected AActor DesktopBg;

		// Token: 0x0401C89E RID: 116894
		protected bool FirstShowDirty = true;

		// Token: 0x0401C89F RID: 116895
		protected LguiFloatTween DissolveTween;

		// Token: 0x0200B3EE RID: 46062
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403684D RID: 223309
			public const int OwnHandItem = 0;

			// Token: 0x0403684E RID: 223310
			public const int OwnFunctionalItem = 1;

			// Token: 0x0403684F RID: 223311
			public const int OpponentHandItem = 2;

			// Token: 0x04036850 RID: 223312
			public const int OpponentFunctionalItem = 3;

			// Token: 0x04036851 RID: 223313
			public const int DragRootItem = 4;

			// Token: 0x04036852 RID: 223314
			public const int HideLayoutBtn = 5;

			// Token: 0x04036853 RID: 223315
			public const int SkillTriggerAttachItem = 6;

			// Token: 0x04036854 RID: 223316
			public const int TimeEndBtn = 7;

			// Token: 0x04036855 RID: 223317
			public const int CardLibrary = 8;

			// Token: 0x04036856 RID: 223318
			public const int AttachItem = 9;

			// Token: 0x04036857 RID: 223319
			public const int OwnRoleItem = 10;

			// Token: 0x04036858 RID: 223320
			public const int OpponentRoleItem = 11;

			// Token: 0x04036859 RID: 223321
			public const int OwnCardLibraryNum = 12;

			// Token: 0x0403685A RID: 223322
			public const int OpponentCardLibraryNum = 13;

			// Token: 0x0403685B RID: 223323
			public const int TipsItem = 14;

			// Token: 0x0403685C RID: 223324
			public const int CaptionItem = 15;

			// Token: 0x0403685D RID: 223325
			public const int RoundNum = 16;

			// Token: 0x0403685E RID: 223326
			public const int OwnCardLibraryItem = 17;

			// Token: 0x0403685F RID: 223327
			public const int OpponentCardLibraryItem = 18;

			// Token: 0x04036860 RID: 223328
			public const int LimitText = 19;

			// Token: 0x04036861 RID: 223329
			public const int RoundEffect = 20;

			// Token: 0x04036862 RID: 223330
			public const int HeadItem = 21;

			// Token: 0x04036863 RID: 223331
			public const int OwnFiledItem = 22;

			// Token: 0x04036864 RID: 223332
			public const int OpponentFiledItem = 23;

			// Token: 0x04036865 RID: 223333
			public const int OpponentLibrarySprite = 24;

			// Token: 0x04036866 RID: 223334
			public const int OwnLibrarySprite = 25;

			// Token: 0x04036867 RID: 223335
			public const int DesktopBg = 26;

			// Token: 0x04036868 RID: 223336
			public const int FieldBg = 27;

			// Token: 0x04036869 RID: 223337
			public const int FieldAttachItem = 28;

			// Token: 0x0403686A RID: 223338
			public const int NiagaraPlayer = 29;

			// Token: 0x0403686B RID: 223339
			public const int NiagaraNpc = 30;

			// Token: 0x0403686C RID: 223340
			public const int NiagaraNpcStart = 31;

			// Token: 0x0403686D RID: 223341
			public const int NiagaraPlayerElement = 32;

			// Token: 0x0403686E RID: 223342
			public const int AttachDetailsTipsItem = 33;
		}
	}
}

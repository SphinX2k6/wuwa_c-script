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
	// Token: 0x0200421D RID: 16925
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleView : UiViewBase
	{
		// Token: 0x0602AC44 RID: 175172 RVA: 0x00C09D3F File Offset: 0x00C07F3F
		public PhantomArenaBattleView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602AC45 RID: 175173 RVA: 0x00C09D50 File Offset: 0x00C07F50
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

		// Token: 0x0602AC46 RID: 175174 RVA: 0x00C0A0D8 File Offset: 0x00C082D8
		private UniTask InitLibrarySprite()
		{
			PhantomArenaBattleView.<InitLibrarySprite>d__7 <InitLibrarySprite>d__;
			<InitLibrarySprite>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLibrarySprite>d__.<>4__this = this;
			<InitLibrarySprite>d__.<>1__state = -1;
			<InitLibrarySprite>d__.<>t__builder.Start<PhantomArenaBattleView.<InitLibrarySprite>d__7>(ref <InitLibrarySprite>d__);
			return <InitLibrarySprite>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC47 RID: 175175 RVA: 0x00C0A11C File Offset: 0x00C0831C
		private UniTask InitDesktopBg()
		{
			PhantomArenaBattleView.<InitDesktopBg>d__8 <InitDesktopBg>d__;
			<InitDesktopBg>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDesktopBg>d__.<>4__this = this;
			<InitDesktopBg>d__.<>1__state = -1;
			<InitDesktopBg>d__.<>t__builder.Start<PhantomArenaBattleView.<InitDesktopBg>d__8>(ref <InitDesktopBg>d__);
			return <InitDesktopBg>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC48 RID: 175176 RVA: 0x00C0A160 File Offset: 0x00C08360
		private void InitCaption()
		{
			this.Proxy.CaptionItem = new PopupCaptionItem(base.GetItem(15));
			this.Proxy.CaptionItem.SetCloseCallBack(new Action(this.Proxy.CloseClick));
			this.Proxy.CaptionItem.SetHelpCallBack(new Action(this.Proxy.HelpClick));
		}

		// Token: 0x0602AC49 RID: 175177 RVA: 0x00C0A1C8 File Offset: 0x00C083C8
		private UniTask InitOwnArea()
		{
			PhantomArenaBattleView.<InitOwnArea>d__10 <InitOwnArea>d__;
			<InitOwnArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitOwnArea>d__.<>4__this = this;
			<InitOwnArea>d__.<>1__state = -1;
			<InitOwnArea>d__.<>t__builder.Start<PhantomArenaBattleView.<InitOwnArea>d__10>(ref <InitOwnArea>d__);
			return <InitOwnArea>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC4A RID: 175178 RVA: 0x00C0A20C File Offset: 0x00C0840C
		private UniTask InitOpponentArea()
		{
			PhantomArenaBattleView.<InitOpponentArea>d__11 <InitOpponentArea>d__;
			<InitOpponentArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitOpponentArea>d__.<>4__this = this;
			<InitOpponentArea>d__.<>1__state = -1;
			<InitOpponentArea>d__.<>t__builder.Start<PhantomArenaBattleView.<InitOpponentArea>d__11>(ref <InitOpponentArea>d__);
			return <InitOpponentArea>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC4B RID: 175179 RVA: 0x00C0A250 File Offset: 0x00C08450
		private UniTask InitCardLibrary()
		{
			PhantomArenaBattleView.<InitCardLibrary>d__12 <InitCardLibrary>d__;
			<InitCardLibrary>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCardLibrary>d__.<>4__this = this;
			<InitCardLibrary>d__.<>1__state = -1;
			<InitCardLibrary>d__.<>t__builder.Start<PhantomArenaBattleView.<InitCardLibrary>d__12>(ref <InitCardLibrary>d__);
			return <InitCardLibrary>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC4C RID: 175180 RVA: 0x00C0A294 File Offset: 0x00C08494
		private UniTask InitTipsItem()
		{
			PhantomArenaBattleView.<InitTipsItem>d__13 <InitTipsItem>d__;
			<InitTipsItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTipsItem>d__.<>4__this = this;
			<InitTipsItem>d__.<>1__state = -1;
			<InitTipsItem>d__.<>t__builder.Start<PhantomArenaBattleView.<InitTipsItem>d__13>(ref <InitTipsItem>d__);
			return <InitTipsItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC4D RID: 175181 RVA: 0x00C0A2D8 File Offset: 0x00C084D8
		private UniTask InitDetailsTips()
		{
			PhantomArenaBattleView.<InitDetailsTips>d__14 <InitDetailsTips>d__;
			<InitDetailsTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDetailsTips>d__.<>4__this = this;
			<InitDetailsTips>d__.<>1__state = -1;
			<InitDetailsTips>d__.<>t__builder.Start<PhantomArenaBattleView.<InitDetailsTips>d__14>(ref <InitDetailsTips>d__);
			return <InitDetailsTips>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC4E RID: 175182 RVA: 0x00C0A31C File Offset: 0x00C0851C
		private UniTask InitSkillTips()
		{
			PhantomArenaBattleView.<InitSkillTips>d__15 <InitSkillTips>d__;
			<InitSkillTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSkillTips>d__.<>4__this = this;
			<InitSkillTips>d__.<>1__state = -1;
			<InitSkillTips>d__.<>t__builder.Start<PhantomArenaBattleView.<InitSkillTips>d__15>(ref <InitSkillTips>d__);
			return <InitSkillTips>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC4F RID: 175183 RVA: 0x00C0A360 File Offset: 0x00C08560
		private UniTask InitDiscardPanel()
		{
			PhantomArenaBattleView.<InitDiscardPanel>d__16 <InitDiscardPanel>d__;
			<InitDiscardPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDiscardPanel>d__.<>4__this = this;
			<InitDiscardPanel>d__.<>1__state = -1;
			<InitDiscardPanel>d__.<>t__builder.Start<PhantomArenaBattleView.<InitDiscardPanel>d__16>(ref <InitDiscardPanel>d__);
			return <InitDiscardPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC50 RID: 175184 RVA: 0x00C0A3A4 File Offset: 0x00C085A4
		private UniTask InitChooseCardPanel()
		{
			PhantomArenaBattleView.<InitChooseCardPanel>d__17 <InitChooseCardPanel>d__;
			<InitChooseCardPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitChooseCardPanel>d__.<>4__this = this;
			<InitChooseCardPanel>d__.<>1__state = -1;
			<InitChooseCardPanel>d__.<>t__builder.Start<PhantomArenaBattleView.<InitChooseCardPanel>d__17>(ref <InitChooseCardPanel>d__);
			return <InitChooseCardPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC51 RID: 175185 RVA: 0x00C0A3E8 File Offset: 0x00C085E8
		private UniTask InitSkillTriggerMask()
		{
			PhantomArenaBattleView.<InitSkillTriggerMask>d__18 <InitSkillTriggerMask>d__;
			<InitSkillTriggerMask>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSkillTriggerMask>d__.<>4__this = this;
			<InitSkillTriggerMask>d__.<>1__state = -1;
			<InitSkillTriggerMask>d__.<>t__builder.Start<PhantomArenaBattleView.<InitSkillTriggerMask>d__18>(ref <InitSkillTriggerMask>d__);
			return <InitSkillTriggerMask>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC52 RID: 175186 RVA: 0x00C0A42C File Offset: 0x00C0862C
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaBattleView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaBattleView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC53 RID: 175187 RVA: 0x00C0A470 File Offset: 0x00C08670
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

		// Token: 0x0602AC54 RID: 175188 RVA: 0x00C0A518 File Offset: 0x00C08718
		protected override void OnBeforeShow()
		{
			if (this.FirstShowDirty)
			{
				this.FirstShowDirty = false;
				return;
			}
			this.Proxy.Show(false);
		}

		// Token: 0x0602AC55 RID: 175189 RVA: 0x00C0A538 File Offset: 0x00C08738
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

		// Token: 0x0602AC56 RID: 175190 RVA: 0x00C0A7FC File Offset: 0x00C089FC
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

		// Token: 0x0602AC57 RID: 175191 RVA: 0x00C0AABE File Offset: 0x00C08CBE
		protected override void OnBeforeDestroy()
		{
			this.Proxy.Destroy();
			this.DissolveTween.Destroy();
		}

		// Token: 0x0602AC58 RID: 175192 RVA: 0x00C0AAD6 File Offset: 0x00C08CD6
		public UUIItem GetDragRootItem()
		{
			return base.GetItem(4);
		}

		// Token: 0x0602AC59 RID: 175193 RVA: 0x00C0AADF File Offset: 0x00C08CDF
		public UUIItem GetOwnCardLibraryItem()
		{
			return base.GetItem(17);
		}

		// Token: 0x0602AC5A RID: 175194 RVA: 0x00C0AAE9 File Offset: 0x00C08CE9
		public UUIItem GetOpponentCardLibraryItem()
		{
			return base.GetItem(18);
		}

		// Token: 0x0602AC5B RID: 175195 RVA: 0x00C0AAF3 File Offset: 0x00C08CF3
		public UUIItem GetSkillTriggerAttachItem()
		{
			return base.GetItem(6);
		}

		// Token: 0x0602AC5C RID: 175196 RVA: 0x00C0AAFC File Offset: 0x00C08CFC
		public void SetCaptionItemActive(bool bActive)
		{
			base.GetItem(15).SetUIActive(bActive);
		}

		// Token: 0x0602AC5D RID: 175197 RVA: 0x00C0AB0C File Offset: 0x00C08D0C
		public void SetRoundEffectActive(bool bActive)
		{
			base.GetItem(20).SetUIActive(bActive);
		}

		// Token: 0x0602AC5E RID: 175198 RVA: 0x00C0AB1C File Offset: 0x00C08D1C
		public void RefreshOwnCardLibraryNum()
		{
			int cardLibraryNum = PhantomArenaBattleModel.Instance.OwnData.CardLibraryNum;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(12), "PhantomBattle_1022", new <>z__ReadOnlySingleElementList<object>(cardLibraryNum));
		}

		// Token: 0x0602AC5F RID: 175199 RVA: 0x00C0AB5C File Offset: 0x00C08D5C
		public void RefreshOpponentCardLibraryNum()
		{
			int cardLibraryNum = PhantomArenaBattleModel.Instance.OpponentData.CardLibraryNum;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(13), "PhantomBattle_1022", new <>z__ReadOnlySingleElementList<object>(cardLibraryNum));
		}

		// Token: 0x0602AC60 RID: 175200 RVA: 0x00C0AB9C File Offset: 0x00C08D9C
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

		// Token: 0x0602AC61 RID: 175201 RVA: 0x00C0ABE4 File Offset: 0x00C08DE4
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

		// Token: 0x0602AC62 RID: 175202 RVA: 0x00C0AC50 File Offset: 0x00C08E50
		public void RefreshLimitText()
		{
			int monsterCardLength = PhantomArenaBattleModel.Instance.OwnData.MonsterCardLength;
			base.GetText(19).SetText(monsterCardLength.ToString() + "/" + 4.ToString(), true);
		}

		// Token: 0x0602AC63 RID: 175203 RVA: 0x00C0AC98 File Offset: 0x00C08E98
		public UniTask PlayShowFieldEffect()
		{
			PhantomArenaBattleView.<PlayShowFieldEffect>d__36 <PlayShowFieldEffect>d__;
			<PlayShowFieldEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayShowFieldEffect>d__.<>4__this = this;
			<PlayShowFieldEffect>d__.<>1__state = -1;
			<PlayShowFieldEffect>d__.<>t__builder.Start<PhantomArenaBattleView.<PlayShowFieldEffect>d__36>(ref <PlayShowFieldEffect>d__);
			return <PlayShowFieldEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC64 RID: 175204 RVA: 0x00C0ACDB File Offset: 0x00C08EDB
		public void LockNpcField()
		{
			this.DissolveTween.PlayTween(0.55f, 0f, 0.5f, null);
		}

		// Token: 0x0602AC65 RID: 175205 RVA: 0x00C0ACF8 File Offset: 0x00C08EF8
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

		// Token: 0x0602AC66 RID: 175206 RVA: 0x00C0AD45 File Offset: 0x00C08F45
		private void SetNiagaraNpcActive(bool value)
		{
			base.GetUiNiagara(30).SetUIActive(value);
		}

		// Token: 0x0602AC67 RID: 175207 RVA: 0x00C0AD55 File Offset: 0x00C08F55
		private void SetNiagaraNpcStartActive(bool value)
		{
			base.GetUiNiagara(31).SetUIActive(value);
		}

		// Token: 0x0602AC68 RID: 175208 RVA: 0x00C0AD65 File Offset: 0x00C08F65
		private void SetNiagaraPlayerActive(bool value)
		{
			base.GetUiNiagara(29).SetUIActive(value);
		}

		// Token: 0x0602AC69 RID: 175209 RVA: 0x00C0AD78 File Offset: 0x00C08F78
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

		// Token: 0x0602AC6A RID: 175210 RVA: 0x00C0AE00 File Offset: 0x00C09000
		private UniTask RefreshPlayerTexture()
		{
			PhantomArenaBattleView.<RefreshPlayerTexture>d__43 <RefreshPlayerTexture>d__;
			<RefreshPlayerTexture>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshPlayerTexture>d__.<>4__this = this;
			<RefreshPlayerTexture>d__.<>1__state = -1;
			<RefreshPlayerTexture>d__.<>t__builder.Start<PhantomArenaBattleView.<RefreshPlayerTexture>d__43>(ref <RefreshPlayerTexture>d__);
			return <RefreshPlayerTexture>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC6B RID: 175211 RVA: 0x00C0AE44 File Offset: 0x00C09044
		private UniTask RefreshNiagaraPlayer()
		{
			PhantomArenaBattleView.<RefreshNiagaraPlayer>d__44 <RefreshNiagaraPlayer>d__;
			<RefreshNiagaraPlayer>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshNiagaraPlayer>d__.<>4__this = this;
			<RefreshNiagaraPlayer>d__.<>1__state = -1;
			<RefreshNiagaraPlayer>d__.<>t__builder.Start<PhantomArenaBattleView.<RefreshNiagaraPlayer>d__44>(ref <RefreshNiagaraPlayer>d__);
			return <RefreshNiagaraPlayer>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC6C RID: 175212 RVA: 0x00C0AE88 File Offset: 0x00C09088
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

		// Token: 0x0602AC6D RID: 175213 RVA: 0x00C0AEED File Offset: 0x00C090ED
		private void SetNiagaraNpcDissolve(float value)
		{
			base.GetUiNiagara(30).SetNiagaraVarFloat("Dissolve", value);
		}

		// Token: 0x0602AC6E RID: 175214 RVA: 0x00C0AF02 File Offset: 0x00C09102
		private void OnDissolveTweenUpdate(float value)
		{
			this.SetNiagaraNpcDissolve(value);
		}

		// Token: 0x0602AC6F RID: 175215 RVA: 0x00C0AF0C File Offset: 0x00C0910C
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

		// Token: 0x040172D1 RID: 94929
		private PhantomArenaBattleProxy Proxy;

		// Token: 0x040172D2 RID: 94930
		protected AActor DesktopBg;

		// Token: 0x040172D3 RID: 94931
		protected bool FirstShowDirty = true;

		// Token: 0x040172D4 RID: 94932
		protected LguiFloatTween DissolveTween;

		// Token: 0x02009E26 RID: 40486
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040312A0 RID: 201376
			public const int OwnHandItem = 0;

			// Token: 0x040312A1 RID: 201377
			public const int OwnFunctionalItem = 1;

			// Token: 0x040312A2 RID: 201378
			public const int OpponentHandItem = 2;

			// Token: 0x040312A3 RID: 201379
			public const int OpponentFunctionalItem = 3;

			// Token: 0x040312A4 RID: 201380
			public const int DragRootItem = 4;

			// Token: 0x040312A5 RID: 201381
			public const int HideLayoutBtn = 5;

			// Token: 0x040312A6 RID: 201382
			public const int SkillTriggerAttachItem = 6;

			// Token: 0x040312A7 RID: 201383
			public const int TimeEndBtn = 7;

			// Token: 0x040312A8 RID: 201384
			public const int CardLibrary = 8;

			// Token: 0x040312A9 RID: 201385
			public const int AttachItem = 9;

			// Token: 0x040312AA RID: 201386
			public const int OwnRoleItem = 10;

			// Token: 0x040312AB RID: 201387
			public const int OpponentRoleItem = 11;

			// Token: 0x040312AC RID: 201388
			public const int OwnCardLibraryNum = 12;

			// Token: 0x040312AD RID: 201389
			public const int OpponentCardLibraryNum = 13;

			// Token: 0x040312AE RID: 201390
			public const int TipsItem = 14;

			// Token: 0x040312AF RID: 201391
			public const int CaptionItem = 15;

			// Token: 0x040312B0 RID: 201392
			public const int RoundNum = 16;

			// Token: 0x040312B1 RID: 201393
			public const int OwnCardLibraryItem = 17;

			// Token: 0x040312B2 RID: 201394
			public const int OpponentCardLibraryItem = 18;

			// Token: 0x040312B3 RID: 201395
			public const int LimitText = 19;

			// Token: 0x040312B4 RID: 201396
			public const int RoundEffect = 20;

			// Token: 0x040312B5 RID: 201397
			public const int HeadItem = 21;

			// Token: 0x040312B6 RID: 201398
			public const int OwnFiledItem = 22;

			// Token: 0x040312B7 RID: 201399
			public const int OpponentFiledItem = 23;

			// Token: 0x040312B8 RID: 201400
			public const int OpponentLibrarySprite = 24;

			// Token: 0x040312B9 RID: 201401
			public const int OwnLibrarySprite = 25;

			// Token: 0x040312BA RID: 201402
			public const int DesktopBg = 26;

			// Token: 0x040312BB RID: 201403
			public const int FieldBg = 27;

			// Token: 0x040312BC RID: 201404
			public const int FieldAttachItem = 28;

			// Token: 0x040312BD RID: 201405
			public const int NiagaraPlayer = 29;

			// Token: 0x040312BE RID: 201406
			public const int NiagaraNpc = 30;

			// Token: 0x040312BF RID: 201407
			public const int NiagaraNpcStart = 31;

			// Token: 0x040312C0 RID: 201408
			public const int NiagaraPlayerElement = 32;

			// Token: 0x040312C1 RID: 201409
			public const int AttachDetailsTipsItem = 33;
		}
	}
}

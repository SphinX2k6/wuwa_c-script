using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D0C RID: 19724
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleTimeDilationButton : FormationExtraButton
	{
		// Token: 0x060316F9 RID: 202489 RVA: 0x00DD228C File Offset: 0x00DD048C
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(0, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUISprite)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(4, typeof(UUIText)));
			if (!Info.Instance.IsInTouch())
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(5, typeof(UUIItem)));
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(6, typeof(UUIItem)));
			}
		}

		// Token: 0x060316FA RID: 202490 RVA: 0x00DD2368 File Offset: 0x00DD0568
		protected override UniTask OnBeforeStartAsync()
		{
			BattleTimeDilationButton.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleTimeDilationButton.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060316FB RID: 202491 RVA: 0x00DD23AB File Offset: 0x00DD05AB
		protected override void OnBeforeCreateImplement()
		{
			this.UiLevelSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiLevelSequence);
		}

		// Token: 0x060316FC RID: 202492 RVA: 0x00DD23C8 File Offset: 0x00DD05C8
		protected override void OnStart()
		{
			base.OnStart();
			if (!Info.Instance.IsInTouch())
			{
				CombineKeyItem keyItemPc = this.KeyItemPc;
				if (keyItemPc != null)
				{
					keyItemPc.RefreshAction("Link大招");
				}
				CombineKeyItem keyItemGp = this.KeyItemGp;
				if (keyItemGp != null)
				{
					keyItemGp.RefreshAction("Link大招");
				}
				this.RefreshKeyItemVisible();
			}
			this.PanelCdRoot = base.GetItem(2);
			this.BarCdSprite = base.GetSprite(3);
			this.BarCdText = base.GetText(4);
			this.ToggleHourGlass = base.GetExtendToggle(1);
			UUIExtendToggle toggleHourGlass = this.ToggleHourGlass;
			if (toggleHourGlass != null)
			{
				toggleHourGlass.OnPointDownCallBack.Bind(new Action<EToggleState>(this.OnClicked));
			}
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(MathUtils.Instance.DefaultTransformDouble);
			this.PostEffectHandle = instance.SpawnEffect(world, ftransformDouble, "/Game/Aki/Effect/EffectGroup/Common/DA_Fx_Group_Post_ForTimeStop_White.DA_Fx_Group_Post_ForTimeStop_White", "BattleTimeDilationButton_effect", null, EEffectType.Scene, null, new Action<ELoadEffectResult, int>(this.OnEffectLoaded), null, true, false);
			InputDistributeController.Instance.BindAction("Link大招", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputActive));
		}

		// Token: 0x060316FD RID: 202493 RVA: 0x00DD24D0 File Offset: 0x00DD06D0
		protected override void OnShowBattleChildView()
		{
			base.OnShowBattleChildView();
			EventSystem.Instance.Add(EEventName.BattleUiTimeDilationStateChanged, new Action(this.OnStateChanged));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			this.OnStateChanged();
		}

		// Token: 0x060316FE RID: 202494 RVA: 0x00DD2554 File Offset: 0x00DD0754
		protected override void OnHideBattleChildView()
		{
			base.OnHideBattleChildView();
			EventSystem.Instance.Remove(EEventName.BattleUiTimeDilationStateChanged, new Action(this.OnStateChanged));
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			this.EnableCoolDown = false;
		}

		// Token: 0x060316FF RID: 202495 RVA: 0x00DD25D8 File Offset: 0x00DD07D8
		public override void Tick(float delta)
		{
			if (!this.EnableCoolDown)
			{
				return;
			}
			if (this.TotalCoolDownTime <= 0f)
			{
				return;
			}
			double num = (double)this.TotalCoolDownTime - Time.Instance.WorldTime * TimeUtil.Instance.Millisecond + (double)this.CoolDownStartTime;
			double num2 = num / (double)this.TotalCoolDownTime;
			UUISprite barCdSprite = this.BarCdSprite;
			if (barCdSprite != null)
			{
				barCdSprite.SetFillAmount((float)num2);
			}
			UUIText barCdText = this.BarCdText;
			if (barCdText == null)
			{
				return;
			}
			barCdText.SetText(num.ToString("F1"), true);
		}

		// Token: 0x06031700 RID: 202496 RVA: 0x00DD265C File Offset: 0x00DD085C
		[NullableContext(1)]
		private void OnInputActive(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (!base.GetActive())
			{
				return;
			}
			if (actionType != InputDistributeDefine.EActionType.Press)
			{
				return;
			}
			this.TriggerAction();
		}

		// Token: 0x06031701 RID: 202497 RVA: 0x00DD2671 File Offset: 0x00DD0871
		private void OnClicked(EToggleState _)
		{
			this.TriggerAction();
		}

		// Token: 0x06031702 RID: 202498 RVA: 0x00DD2679 File Offset: 0x00DD0879
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.RefreshKeyItemVisible();
		}

		// Token: 0x06031703 RID: 202499 RVA: 0x00DD2684 File Offset: 0x00DD0884
		private void TriggerAction()
		{
			Log.Instance.Info(ELogModule.Battle, ELogAuthor.LJM, "[BattleTimeDilationButton]", default(ReadOnlySpan<ValueTuple<string, object>>));
			switch (BattleUiModel.Instance.CurrentTimeDilationSkillState)
			{
			case ETimeDilationSkillState.Ready:
				BattleUiModel.Instance.SetTimeDilationState(ETimeDilationSkillState.InUse);
				return;
			case ETimeDilationSkillState.InUse:
				BattleUiModel.Instance.SetTimeDilationState(ETimeDilationSkillState.CD);
				return;
			case ETimeDilationSkillState.CD:
				ScrollingTipsController.Instance.ShowTipsByTextId("PhotoFightTimeSlowNotReady", Array.Empty<object>());
				return;
			default:
				return;
			}
		}

		// Token: 0x06031704 RID: 202500 RVA: 0x00DD26F8 File Offset: 0x00DD08F8
		private void ClearAction()
		{
			Log.Instance.Info(ELogModule.Battle, ELogAuthor.LJM, "[BattleTimeDilationButton]ClearAction", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (this.PostEffectHandle != 0)
			{
				EffectSystem.Instance.StopEffectById(this.PostEffectHandle, "[BattleTimeDilationButton]ClearAction", true, null);
				this.PostEffectHandle = 0;
			}
			if (this.ScreenEffectHandle != 0)
			{
				ScreenEffectModel.Instance.EndScreenEffect(this.ScreenEffectHandle);
				this.ScreenEffectHandle = 0;
			}
			if (BattleUiModel.Instance.CurrentTimeDilationSkillState == ETimeDilationSkillState.InUse)
			{
				BattleUiModel.Instance.SetTimeDilationState(ETimeDilationSkillState.CD);
			}
		}

		// Token: 0x06031705 RID: 202501 RVA: 0x00DD2788 File Offset: 0x00DD0988
		private void OnStateChanged()
		{
			switch (BattleUiModel.Instance.CurrentTimeDilationSkillState)
			{
			case ETimeDilationSkillState.Ready:
			{
				this.EnableCoolDown = false;
				UUIItem panelCdRoot = this.PanelCdRoot;
				if (panelCdRoot != null)
				{
					panelCdRoot.SetUIActive(false);
				}
				this.PlayShowAnim();
				break;
			}
			case ETimeDilationSkillState.InUse:
			{
				this.EnableCoolDown = false;
				UUIItem panelCdRoot2 = this.PanelCdRoot;
				if (panelCdRoot2 != null)
				{
					panelCdRoot2.SetUIActive(false);
				}
				this.PlayLoopAnim();
				this.FightPhotoLogReport();
				break;
			}
			case ETimeDilationSkillState.CD:
			{
				this.EnableCoolDown = true;
				UUIItem panelCdRoot3 = this.PanelCdRoot;
				if (panelCdRoot3 != null)
				{
					panelCdRoot3.SetUIActive(true);
				}
				this.CoolDownStartTime = BattleUiModel.Instance.TimeDilationCoolDownStartTime;
				this.TotalCoolDownTime = BattleUiModel.Instance.TimeDilationSkillCdTime;
				this.PlayCloseAnim();
				break;
			}
			}
			this.UpdateAllEffectState();
		}

		// Token: 0x06031706 RID: 202502 RVA: 0x00DD2844 File Offset: 0x00DD0A44
		private void FightPhotoLogReport()
		{
			FightPhotoTimeDilationLogEvent fightPhotoTimeDilationLogEvent = new FightPhotoTimeDilationLogEvent();
			FightPhotoLevelData currentLevelData = FightPhotoController.Instance.GetActivityData().GetCurrentLevelData(true);
			fightPhotoTimeDilationLogEvent.inst_id = currentLevelData.InstanceId;
			fightPhotoTimeDilationLogEvent.inst_diff = ((currentLevelData.IsDifficulty > false) ? 1 : 0);
			fightPhotoTimeDilationLogEvent.trace_id = CreatureModel.Instance.GetSceneTraceId().ToString();
			LogReportController.Instance.LogReport(fightPhotoTimeDilationLogEvent);
		}

		// Token: 0x06031707 RID: 202503 RVA: 0x00DD28AC File Offset: 0x00DD0AAC
		public void PlayShowAnim()
		{
			if (this.UiLevelSequence.HasSequenceNameInPlaying("Start"))
			{
				return;
			}
			if (this.UiLevelSequence.IsInSequence())
			{
				this.UiLevelSequence.StopPrevSequence(false, true);
			}
			this.UiLevelSequence.PlaySequence("Start", false, null);
		}

		// Token: 0x06031708 RID: 202504 RVA: 0x00DD2900 File Offset: 0x00DD0B00
		public void PlayLoopAnim()
		{
			if (this.UiLevelSequence.HasSequenceNameInPlaying("Loop"))
			{
				return;
			}
			if (this.UiLevelSequence.IsInSequence())
			{
				this.UiLevelSequence.StopPrevSequence(false, true);
			}
			this.UiLevelSequence.PlaySequence("Loop", false, null);
		}

		// Token: 0x06031709 RID: 202505 RVA: 0x00DD2954 File Offset: 0x00DD0B54
		public void PlayCloseAnim()
		{
			if (this.UiLevelSequence.HasSequenceNameInPlaying("Close"))
			{
				return;
			}
			if (this.UiLevelSequence.IsInSequence())
			{
				this.UiLevelSequence.StopPrevSequence(false, true);
			}
			this.UiLevelSequence.PlaySequence("Close", false, null);
		}

		// Token: 0x0603170A RID: 202506 RVA: 0x00DD29A8 File Offset: 0x00DD0BA8
		private void RefreshKeyItemVisible()
		{
			CombineKeyItem keyItemPc = this.KeyItemPc;
			if (keyItemPc != null)
			{
				keyItemPc.SetUiActive(Info.Instance.IsInKeyBoard());
			}
			CombineKeyItem keyItemGp = this.KeyItemGp;
			if (keyItemGp == null)
			{
				return;
			}
			keyItemGp.SetUiActive(Info.Instance.IsInGamepad());
		}

		// Token: 0x0603170B RID: 202507 RVA: 0x00DD29DF File Offset: 0x00DD0BDF
		protected override void OnBeforeDestroy()
		{
			this.ClearAction();
			InputDistributeController.Instance.UnBindAction("Link大招", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputActive));
		}

		// Token: 0x0603170C RID: 202508 RVA: 0x00DD2A02 File Offset: 0x00DD0C02
		private void OnEffectLoaded(ELoadEffectResult result, int handle)
		{
			if (result != ELoadEffectResult.Success)
			{
				return;
			}
			this.UpdateEffectState(handle);
		}

		// Token: 0x0603170D RID: 202509 RVA: 0x00DD2A10 File Offset: 0x00DD0C10
		private void OnOpenView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.FightPhotographView)
			{
				return;
			}
			this.IsPhotographViewOpen = true;
			this.OnStateChanged();
		}

		// Token: 0x0603170E RID: 202510 RVA: 0x00DD2A2D File Offset: 0x00DD0C2D
		private void OnCloseView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.FightPhotographView)
			{
				return;
			}
			this.IsPhotographViewOpen = false;
			this.OnStateChanged();
		}

		// Token: 0x0603170F RID: 202511 RVA: 0x00DD2A4A File Offset: 0x00DD0C4A
		private void UpdateAllEffectState()
		{
			this.UpdateEffectState(this.PostEffectHandle);
			this.UpdateScreenEffect();
		}

		// Token: 0x06031710 RID: 202512 RVA: 0x00DD2A60 File Offset: 0x00DD0C60
		private void UpdateEffectState(int handle)
		{
			if (!EffectSystem.Instance.IsValid(handle))
			{
				return;
			}
			if (this.IsPhotographViewOpen)
			{
				EffectSystem.Instance.SetEffectHidden(handle, true, null, false);
				return;
			}
			switch (BattleUiModel.Instance.CurrentTimeDilationSkillState)
			{
			case ETimeDilationSkillState.Ready:
			case ETimeDilationSkillState.CD:
				EffectSystem.Instance.SetEffectHidden(handle, true, null, false);
				return;
			case ETimeDilationSkillState.InUse:
			{
				EffectSystem instance = EffectSystem.Instance;
				string reason = "[BattleTimeDilationButton.ReplayEffect]";
				FTransformDouble? ftransformDouble = null;
				instance.ReplayEffect(handle, reason, ftransformDouble);
				EffectSystem.Instance.SetEffectHidden(handle, false, null, false);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06031711 RID: 202513 RVA: 0x00DD2AE8 File Offset: 0x00DD0CE8
		private void UpdateScreenEffect()
		{
			if (this.ScreenEffectHandle != 0)
			{
				ScreenEffectModel.Instance.EndScreenEffect(this.ScreenEffectHandle);
			}
			if (this.IsPhotographViewOpen)
			{
				return;
			}
			if (BattleUiModel.Instance.CurrentTimeDilationSkillState == ETimeDilationSkillState.InUse)
			{
				this.ScreenEffectHandle = ScreenEffectModel.Instance.PlayScreenEffect("/Game/Aki/Effect/DataAsset/ScreenDA/SD_Fight/Bigworld/DA_Fx_Screen_ForTimeStop_White.DA_Fx_Screen_ForTimeStop_White", null, null);
			}
		}

		// Token: 0x0401A2E6 RID: 107238
		[Nullable(1)]
		private const string POST_EFFECT_PATH = "/Game/Aki/Effect/EffectGroup/Common/DA_Fx_Group_Post_ForTimeStop_White.DA_Fx_Group_Post_ForTimeStop_White";

		// Token: 0x0401A2E7 RID: 107239
		[Nullable(1)]
		private const string SCREEN_EFFECT_PATH = "/Game/Aki/Effect/DataAsset/ScreenDA/SD_Fight/Bigworld/DA_Fx_Screen_ForTimeStop_White.DA_Fx_Screen_ForTimeStop_White";

		// Token: 0x0401A2E8 RID: 107240
		private CombineKeyItem KeyItemPc;

		// Token: 0x0401A2E9 RID: 107241
		private CombineKeyItem KeyItemGp;

		// Token: 0x0401A2EA RID: 107242
		private UUIItem PanelCdRoot;

		// Token: 0x0401A2EB RID: 107243
		private UUISprite BarCdSprite;

		// Token: 0x0401A2EC RID: 107244
		private UUIText BarCdText;

		// Token: 0x0401A2ED RID: 107245
		private UUIExtendToggle ToggleHourGlass;

		// Token: 0x0401A2EE RID: 107246
		public UiBehaviorLevelSequence UiLevelSequence;

		// Token: 0x0401A2EF RID: 107247
		private int PostEffectHandle;

		// Token: 0x0401A2F0 RID: 107248
		private int ScreenEffectHandle;

		// Token: 0x0401A2F1 RID: 107249
		private float TotalCoolDownTime;

		// Token: 0x0401A2F2 RID: 107250
		private float CoolDownStartTime;

		// Token: 0x0401A2F3 RID: 107251
		private bool EnableCoolDown;

		// Token: 0x0401A2F4 RID: 107252
		private bool IsPhotographViewOpen;

		// Token: 0x0200A9BD RID: 43453
		[NullableContext(0)]
		private enum EDesktopChildType
		{
			// Token: 0x04034730 RID: 214832
			KeyItemPc = 5,
			// Token: 0x04034731 RID: 214833
			KeyItemGp
		}

		// Token: 0x0200A9BE RID: 43454
		[NullableContext(0)]
		private enum EBattleTimeDilationComponent
		{
			// Token: 0x04034733 RID: 214835
			RootItem,
			// Token: 0x04034734 RID: 214836
			ToggleHourGlass,
			// Token: 0x04034735 RID: 214837
			PanelCDRoot,
			// Token: 0x04034736 RID: 214838
			BarCDSprite,
			// Token: 0x04034737 RID: 214839
			BarCDText
		}
	}
}

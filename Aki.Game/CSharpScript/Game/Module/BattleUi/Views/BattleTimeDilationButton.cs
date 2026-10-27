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
	// Token: 0x02005D2A RID: 23850
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleTimeDilationButton : FormationExtraButton
	{
		// Token: 0x0603C7A0 RID: 247712 RVA: 0x00E81AEC File Offset: 0x00E7FCEC
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

		// Token: 0x0603C7A1 RID: 247713 RVA: 0x00E81BC8 File Offset: 0x00E7FDC8
		protected override UniTask OnBeforeStartAsync()
		{
			BattleTimeDilationButton.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleTimeDilationButton.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C7A2 RID: 247714 RVA: 0x00E81C0B File Offset: 0x00E7FE0B
		protected override void OnBeforeCreateImplement()
		{
			this.UiLevelSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiLevelSequence);
		}

		// Token: 0x0603C7A3 RID: 247715 RVA: 0x00E81C28 File Offset: 0x00E7FE28
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

		// Token: 0x0603C7A4 RID: 247716 RVA: 0x00E81D30 File Offset: 0x00E7FF30
		protected override void OnShowBattleChildView()
		{
			base.OnShowBattleChildView();
			EventSystem.Instance.Add(EEventName.BattleUiTimeDilationStateChanged, new Action(this.OnStateChanged));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			this.OnStateChanged();
		}

		// Token: 0x0603C7A5 RID: 247717 RVA: 0x00E81DB4 File Offset: 0x00E7FFB4
		protected override void OnHideBattleChildView()
		{
			base.OnHideBattleChildView();
			EventSystem.Instance.Remove(EEventName.BattleUiTimeDilationStateChanged, new Action(this.OnStateChanged));
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
			EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			this.EnableCoolDown = false;
		}

		// Token: 0x0603C7A6 RID: 247718 RVA: 0x00E81E38 File Offset: 0x00E80038
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

		// Token: 0x0603C7A7 RID: 247719 RVA: 0x00E81EBC File Offset: 0x00E800BC
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

		// Token: 0x0603C7A8 RID: 247720 RVA: 0x00E81ED1 File Offset: 0x00E800D1
		private void OnClicked(EToggleState _)
		{
			this.TriggerAction();
		}

		// Token: 0x0603C7A9 RID: 247721 RVA: 0x00E81ED9 File Offset: 0x00E800D9
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.RefreshKeyItemVisible();
		}

		// Token: 0x0603C7AA RID: 247722 RVA: 0x00E81EE4 File Offset: 0x00E800E4
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

		// Token: 0x0603C7AB RID: 247723 RVA: 0x00E81F58 File Offset: 0x00E80158
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

		// Token: 0x0603C7AC RID: 247724 RVA: 0x00E81FE8 File Offset: 0x00E801E8
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

		// Token: 0x0603C7AD RID: 247725 RVA: 0x00E820A4 File Offset: 0x00E802A4
		private void FightPhotoLogReport()
		{
			FightPhotoTimeDilationLogEvent fightPhotoTimeDilationLogEvent = new FightPhotoTimeDilationLogEvent();
			FightPhotoLevelData currentLevelData = FightPhotoController.Instance.GetActivityData().GetCurrentLevelData(true);
			fightPhotoTimeDilationLogEvent.inst_id = currentLevelData.InstanceId;
			fightPhotoTimeDilationLogEvent.inst_diff = ((currentLevelData.IsDifficulty > false) ? 1 : 0);
			fightPhotoTimeDilationLogEvent.trace_id = CreatureModel.Instance.GetSceneTraceId().ToString();
			LogReportController.Instance.LogReport(fightPhotoTimeDilationLogEvent);
		}

		// Token: 0x0603C7AE RID: 247726 RVA: 0x00E8210C File Offset: 0x00E8030C
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

		// Token: 0x0603C7AF RID: 247727 RVA: 0x00E82160 File Offset: 0x00E80360
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

		// Token: 0x0603C7B0 RID: 247728 RVA: 0x00E821B4 File Offset: 0x00E803B4
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

		// Token: 0x0603C7B1 RID: 247729 RVA: 0x00E82208 File Offset: 0x00E80408
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

		// Token: 0x0603C7B2 RID: 247730 RVA: 0x00E8223F File Offset: 0x00E8043F
		protected override void OnBeforeDestroy()
		{
			this.ClearAction();
			InputDistributeController.Instance.UnBindAction("Link大招", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputActive));
		}

		// Token: 0x0603C7B3 RID: 247731 RVA: 0x00E82262 File Offset: 0x00E80462
		private void OnEffectLoaded(ELoadEffectResult result, int handle)
		{
			if (result != ELoadEffectResult.Success)
			{
				return;
			}
			this.UpdateEffectState(handle);
		}

		// Token: 0x0603C7B4 RID: 247732 RVA: 0x00E82270 File Offset: 0x00E80470
		private void OnOpenView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.FightPhotographView)
			{
				return;
			}
			this.IsPhotographViewOpen = true;
			this.OnStateChanged();
		}

		// Token: 0x0603C7B5 RID: 247733 RVA: 0x00E8228D File Offset: 0x00E8048D
		private void OnCloseView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.FightPhotographView)
			{
				return;
			}
			this.IsPhotographViewOpen = false;
			this.OnStateChanged();
		}

		// Token: 0x0603C7B6 RID: 247734 RVA: 0x00E822AA File Offset: 0x00E804AA
		private void UpdateAllEffectState()
		{
			this.UpdateEffectState(this.PostEffectHandle);
			this.UpdateScreenEffect();
		}

		// Token: 0x0603C7B7 RID: 247735 RVA: 0x00E822C0 File Offset: 0x00E804C0
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

		// Token: 0x0603C7B8 RID: 247736 RVA: 0x00E82348 File Offset: 0x00E80548
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

		// Token: 0x0401F82D RID: 129069
		[Nullable(1)]
		private const string POST_EFFECT_PATH = "/Game/Aki/Effect/EffectGroup/Common/DA_Fx_Group_Post_ForTimeStop_White.DA_Fx_Group_Post_ForTimeStop_White";

		// Token: 0x0401F82E RID: 129070
		[Nullable(1)]
		private const string SCREEN_EFFECT_PATH = "/Game/Aki/Effect/DataAsset/ScreenDA/SD_Fight/Bigworld/DA_Fx_Screen_ForTimeStop_White.DA_Fx_Screen_ForTimeStop_White";

		// Token: 0x0401F82F RID: 129071
		private CombineKeyItem KeyItemPc;

		// Token: 0x0401F830 RID: 129072
		private CombineKeyItem KeyItemGp;

		// Token: 0x0401F831 RID: 129073
		private UUIItem PanelCdRoot;

		// Token: 0x0401F832 RID: 129074
		private UUISprite BarCdSprite;

		// Token: 0x0401F833 RID: 129075
		private UUIText BarCdText;

		// Token: 0x0401F834 RID: 129076
		private UUIExtendToggle ToggleHourGlass;

		// Token: 0x0401F835 RID: 129077
		public UiBehaviorLevelSequence UiLevelSequence;

		// Token: 0x0401F836 RID: 129078
		private int PostEffectHandle;

		// Token: 0x0401F837 RID: 129079
		private int ScreenEffectHandle;

		// Token: 0x0401F838 RID: 129080
		private float TotalCoolDownTime;

		// Token: 0x0401F839 RID: 129081
		private float CoolDownStartTime;

		// Token: 0x0401F83A RID: 129082
		private bool EnableCoolDown;

		// Token: 0x0401F83B RID: 129083
		private bool IsPhotographViewOpen;

		// Token: 0x0200BFB7 RID: 49079
		[NullableContext(0)]
		private enum EDesktopChildType
		{
			// Token: 0x04039D6E RID: 236910
			KeyItemPc = 5,
			// Token: 0x04039D6F RID: 236911
			KeyItemGp
		}

		// Token: 0x0200BFB8 RID: 49080
		[NullableContext(0)]
		private enum EBattleTimeDilationComponent
		{
			// Token: 0x04039D71 RID: 236913
			RootItem,
			// Token: 0x04039D72 RID: 236914
			ToggleHourGlass,
			// Token: 0x04039D73 RID: 236915
			PanelCDRoot,
			// Token: 0x04039D74 RID: 236916
			BarCDSprite,
			// Token: 0x04039D75 RID: 236917
			BarCDText
		}
	}
}

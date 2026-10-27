using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.FlowActions;

namespace CSharpScript.Game.Module.Plot.Flow
{
	// Token: 0x02005090 RID: 20624
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowActionCenter : ControllerAssistantBase
	{
		// Token: 0x06034D67 RID: 216423 RVA: 0x00C7F003 File Offset: 0x00C7D203
		protected override void OnInit()
		{
			this.InitActions();
		}

		// Token: 0x06034D68 RID: 216424 RVA: 0x00C7F00B File Offset: 0x00C7D20B
		protected override void OnDestroy()
		{
			this.FlowActionMap.Clear();
		}

		// Token: 0x06034D69 RID: 216425 RVA: 0x00C7F018 File Offset: 0x00C7D218
		private void InitActions()
		{
			this.InitAction(EAction.ShowTalk, () => new FlowActionShowTalk(), false);
			this.InitAction(EAction.ChangeState, () => new FlowActionChangeState(), false);
			this.InitAction(EAction.FinishState, () => new FlowActionFinishState(), false);
			this.InitAction(EAction.JumpTalk, () => new FlowActionJumpTalk(), false);
			this.InitAction(EAction.FinishTalk, () => new FlowActionFinishTalk(), false);
			this.InitAction(EAction.PlaySequenceData, () => new FlowActionPlaySequenceData(), false);
			this.InitAction(EAction.SetPlotMode, () => new FlowActionSetPlotMode(), false);
			this.InitAction(EAction.ShowCenterText, () => new FlowActionShowCenterText(), false);
			this.InitAction(EAction.SetHeadIconVisible, () => new FlowActionSetHeadIconVisible(), false);
			this.InitAction(EAction.Wait, () => new FlowActionWait(), false);
			this.InitAction(EAction.PlayMovie, () => new FlowActionPlayMovie(), false);
			this.InitAction(EAction.ChangeInteractOptionText, () => new FlowActionChangeInteractOptionText(), true);
			this.InitAction(EAction.FadeInScreen, () => new FlowActionFadeInScreen(), false);
			this.InitAction(EAction.FadeOutScreen, () => new FlowActionFadeOutScreen(), false);
			this.InitAction(EAction.BeginFlowTemplate, () => new FlowActionBeginFlowTemplate(), false);
			this.InitAction(EAction.SetFlowTemplate, () => new FlowActionSetFlowTemplate(), false);
			this.InitAction(EAction.CloseFlowTemplate, () => new FlowActionCloseFlowTemplate(), false);
			this.InitAction(EAction.SetPlayerPos, () => new FlowActionSetPlayerPos(), false);
			this.InitAction(EAction.AwakeEntity, () => new FlowActionAwakeEntity(), false);
			this.InitAction(EAction.DestroyEntity, () => new FlowActionDestroyEntity(), false);
			this.InitAction(EAction.PlayerLookAt, () => new FlowActionLevelSyncAction(), true);
			this.InitAction(EAction.PostAkEvent, () => new FlowActionLevelSyncAction(), true);
			this.InitAction(EAction.CameraLookAt, () => new FlowActionCameraLookAt(), false);
			this.InitAction(EAction.PlayBubble, () => new FlowActionLevelSyncAction(), true);
			this.InitAction(EAction.AddPlayBubble, () => new FlowActionAddPlayBubble(), true);
			this.InitAction(EAction.SetCameraAnim, () => new FlowActionSetCameraAnim(), true);
			this.InitAction(EAction.TakePlotPhoto, () => new FlowActionTakePlotPhoto(), false);
			this.InitAction(EAction.SetTime, () => new FlowActionSetTime(), true);
			this.InitAction(EAction.HideByRangeInFlow, () => new FlowActionHideByRangeInFlow(), true);
			this.InitAction(EAction.ShowAllHidedGroupInFlow, () => new FlowActionShowAllHidedGroupInFlow(), true);
			this.InitAction(EAction.ChangeActorTalker, () => new FlowActionChangeActorTalker(), true);
			this.InitAction(EAction.SetWeather, () => new FlowActionServerAction(), false);
			this.InitAction(EAction.SetTimeLockState, () => new FlowActionLockTodTime(), true);
			this.InitAction(EAction.SetWeatherLockState, () => new FlowActionServerAction(), false);
			this.InitAction(EAction.PromptQuestChapterUI, () => new FlowActionOpenQuestChapterView(), false);
			this.InitAction(EAction.OpenSystemBoard, () => new FlowActionOpenSystemBoard(), false);
			this.InitAction(EAction.PhoneSystemInteract, () => new FlowActionPhoneSystemInteract(), false);
			this.InitAction(EAction.ChangeEntityState, () => new FlowActionChangeEntityState(), false);
			this.InitAction(EAction.UnlockEntity, () => new FlowActionUnlockEntity(), true);
			this.InitAction(EAction.AdjustPlayerCamera, () => new FlowActionLevelSyncAction(), true);
			this.InitAction(EAction.RestorePlayerCameraAdjustment, () => new FlowActionLevelSyncAction(), true);
			this.InitAction(EAction.ChangeEntityPrefabPerformance, () => new FlowActionChangeEntityPerformanceState(), true);
			this.InitAction(EAction.ChangeSelfEntityState, () => new FlowActionChangeEntitySelfState(), true);
			this.InitAction(EAction.SetEntityVisible, () => new FlowActionSetEntityVisible(), false);
			this.InitAction(EAction.ChangePhantomFormation, () => new FlowActionChangeFormation(), false);
			this.InitAction(EAction.RestorePhantomFormation, () => new FlowActionChangeFormation(), false);
			this.InitAction(EAction.AddTrialCharacter, () => new FlowActionChangeFormation(), false);
			this.InitAction(EAction.RemoveTrialCharacter, () => new FlowActionChangeFormation(), false);
			this.InitAction(EAction.SwitchSubLevels, () => new FlowActionSwitchSubLevels(), false);
			this.InitAction(EAction.LeisureInteract, () => new FlowActionLeisureInteract(), false);
			this.InitAction(EAction.SetSpineAnimation, () => new FlowActionPlaySpine(), true);
			this.InitAction(EAction.SetAudioState, () => new FlowActionSetAudioState(), true);
			this.InitAction(EAction.StopUiScreenEffect, () => new FlowActionStopUiScreenEffect(), true);
			this.InitAction(EAction.OpenSimpleGameplay, () => new FlowActionOpenSimpleGameplay(), false);
			this.InitAction(EAction.FlowDefineNpcGroupPerform, () => new FlowActionSetNpcGroupPerform(), false);
			this.InitAction(EAction.TrapDefenseChangeMiniMap, () => new FlowActionChangeTrapDefenseMiniMap(), true);
			this.InitAction(EAction.ClientPreEnableSubLevels, () => new FlowActionPreEnableSubLevel(), false);
			this.InitAction(EAction.NpcLeisureInteract, () => new FlowActionNpcLeisureInteract(), true);
			this.InitAction(EAction.TriggerGamepadShake, () => new FlowActionLevelSyncAction(), true);
			this.InitAction(EAction.GiantToggleModel, () => new FlowActionGiantToggleModel(), false);
			this.InitAction(EAction.GiantTriggerResponse, () => new FlowActionGiantTriggerResponse(), false);
			this.InitAction(EAction.AvgPlayRoleAction, () => new FlowActionAvgPlayRoleAction(), true);
			this.InitAction(EAction.AvgMoveRole, () => new FlowActionAvgMoveRole(), false);
			this.InitAction(EAction.AvgFocusRole, () => new FlowActionAvgFocusRole(), true);
			this.InitAction(EAction.AvgShakeUi, () => new FlowActionAvgShakeUi(), true);
		}

		// Token: 0x06034D6A RID: 216426 RVA: 0x00C7FAC0 File Offset: 0x00C7DCC0
		private void InitAction(EAction type, Func<FlowActionBase> actionFactory, bool isAutoFinished = false)
		{
			if (this.FlowActionMap.ContainsKey(type))
			{
				return;
			}
			FlowAction flowAction = new FlowAction();
			flowAction.Init(type, actionFactory, isAutoFinished);
			this.FlowActionMap.Add(type, flowAction);
		}

		// Token: 0x06034D6B RID: 216427 RVA: 0x00C7FAF8 File Offset: 0x00C7DCF8
		[NullableContext(2)]
		public FlowAction GetFlowAction(EAction type)
		{
			return this.FlowActionMap.GetValueOrDefault(type);
		}

		// Token: 0x0401C269 RID: 115305
		private readonly Dictionary<EAction, FlowAction> FlowActionMap = new Dictionary<EAction, FlowAction>();
	}
}

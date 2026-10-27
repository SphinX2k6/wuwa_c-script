using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002285 RID: 8837
	public static class EActionExtensions
	{
		// Token: 0x0600C1D5 RID: 49621 RVA: 0x001BCC08 File Offset: 0x001BAE08
		public static string ToEnumString(this EAction value)
		{
			string result;
			switch (value)
			{
			case EAction.Undefined:
				result = "Undefined";
				break;
			case EAction.Activate:
				result = "Activate";
				break;
			case EAction.AccpetCurrentQuest:
				result = "AccpetCurrentQuest";
				break;
			case EAction.AddFlowInteractOption:
				result = "AddFlowInteractOption";
				break;
			case EAction.SetTime:
				result = "SetTime";
				break;
			case EAction.AwakeEntity:
				result = "AwakeEntity";
				break;
			case EAction.CalculateVar:
				result = "CalculateVar";
				break;
			case EAction.RandomVar:
				result = "RandomVar";
				break;
			case EAction.CallByCondition:
				result = "CallByCondition";
				break;
			case EAction.CallFunction:
				result = "CallFunction";
				break;
			case EAction.CameraLookAt:
				result = "CameraLookAt";
				break;
			case EAction.StopCameraLookAt:
				result = "StopCameraLookAt";
				break;
			case EAction.EnableHostility:
				result = "EnableHostility";
				break;
			case EAction.ChangeActorState:
				result = "ChangeActorState";
				break;
			case EAction.ChangeBehaviorState:
				result = "ChangeBehaviorState";
				break;
			case EAction.ChangeEntityState:
				result = "ChangeEntityState";
				break;
			case EAction.ChangeNpcPerformState:
				result = "ChangeNpcPerformState";
				break;
			case EAction.ChangeInteractOptionText:
				result = "ChangeInteractOptionText";
				break;
			case EAction.ChangeOtherState:
				result = "ChangeOtherState";
				break;
			case EAction.ChangeRandomState:
				result = "ChangeRandomState";
				break;
			case EAction.ChangeState:
				result = "ChangeState";
				break;
			case EAction.Collect:
				result = "Collect";
				break;
			case EAction.CompleteChildQuest:
				result = "CompleteChildQuest";
				break;
			case EAction.Destroy:
				result = "Destroy";
				break;
			case EAction.DestroyAllChild:
				result = "DestroyAllChild";
				break;
			case EAction.DestroyEntity:
				result = "DestroyEntity";
				break;
			case EAction.DestroySelf:
				result = "DestroySelf";
				break;
			case EAction.DoCalculate:
				result = "DoCalculate";
				break;
			case EAction.EnableFunction:
				result = "EnableFunction";
				break;
			case EAction.EnableClientFunction:
				result = "EnableClientFunction";
				break;
			case EAction.FaceToPos:
				result = "FaceToPos";
				break;
			case EAction.FinishDoInteract:
				result = "FinishDoInteract";
				break;
			case EAction.FinishState:
				result = "FinishState";
				break;
			case EAction.FinishTalk:
				result = "FinishTalk";
				break;
			case EAction.GetItem:
				result = "GetItem";
				break;
			case EAction.DestroyQuestItem:
				result = "DestroyQuestItem";
				break;
			case EAction.GuideTrigger:
				result = "GuideTrigger";
				break;
			case EAction.CompleteGuide:
				result = "CompleteGuide";
				break;
			case EAction.Invoke:
				result = "Invoke";
				break;
			case EAction.JumpTalk:
				result = "JumpTalk";
				break;
			case EAction.Log:
				result = "Log";
				break;
			case EAction.MoveToPos:
				result = "MoveToPos";
				break;
			case EAction.MoveWithSpline:
				result = "MoveWithSpline";
				break;
			case EAction.NewMoveWithSpline:
				result = "NewMoveWithSpline";
				break;
			case EAction.StopNewMoveWithSpline:
				result = "StopNewMoveWithSpline";
				break;
			case EAction.CharacterMoveToPoint:
				result = "CharacterMoveToPoint";
				break;
			case EAction.PlayerMoveToPoint:
				result = "PlayerMoveToPoint";
				break;
			case EAction.NpcMoveToPoint:
				result = "NpcMoveToPoint";
				break;
			case EAction.OpenSystemBoard:
				result = "OpenSystemBoard";
				break;
			case EAction.OpenSystemFunction:
				result = "OpenSystemFunction";
				break;
			case EAction.PlayCustomSequence:
				result = "PlayCustomSequence";
				break;
			case EAction.PlayerLookAt:
				result = "PlayerLookAt";
				break;
			case EAction.EntityLookAt:
				result = "EntityLookAt";
				break;
			case EAction.EntityTurnTo:
				result = "EntityTurnTo";
				break;
			case EAction.CharacterLookAt:
				result = "CharacterLookAt";
				break;
			case EAction.PlayFlow:
				result = "PlayFlow";
				break;
			case EAction.PlayMovie:
				result = "PlayMovie";
				break;
			case EAction.PlayEffect:
				result = "PlayEffect";
				break;
			case EAction.PlayEffect2:
				result = "PlayEffect2";
				break;
			case EAction.RemoveEffect:
				result = "RemoveEffect";
				break;
			case EAction.PlayMontage:
				result = "PlayMontage";
				break;
			case EAction.PlayRegisteredMontage:
				result = "PlayRegisteredMontage";
				break;
			case EAction.PlaySequenceData:
				result = "PlaySequenceData";
				break;
			case EAction.PlayerInput:
				result = "PlayerInput";
				break;
			case EAction.Prompt:
				result = "Prompt";
				break;
			case EAction.AddPlayBubble:
				result = "AddPlayBubble";
				break;
			case EAction.PlayBubble:
				result = "PlayBubble";
				break;
			case EAction.ClearPlayBubble:
				result = "ClearPlayBubble";
				break;
			case EAction.EnableAI:
				result = "EnableAI";
				break;
			case EAction.RemoveFlowInteractOption:
				result = "RemoveFlowInteractOption";
				break;
			case EAction.SendNpcMail:
				result = "SendNpcMail";
				break;
			case EAction.SetBehaviorIsPaused:
				result = "SetBehaviorIsPaused";
				break;
			case EAction.SetCameraMode:
				result = "SetCameraMode";
				break;
			case EAction.SetEntityVisible:
				result = "SetEntityVisible";
				break;
			case EAction.SetEntityClientVisible:
				result = "SetEntityClientVisible";
				break;
			case EAction.SetEntityClientVisibleSave:
				result = "SetEntityClientVisibleSave";
				break;
			case EAction.SetHeadIconVisible:
				result = "SetHeadIconVisible";
				break;
			case EAction.SetMoveSpeed:
				result = "SetMoveSpeed";
				break;
			case EAction.SetNumberVar:
				result = "SetNumberVar";
				break;
			case EAction.SetPlotMode:
				result = "SetPlotMode";
				break;
			case EAction.SetPos:
				result = "SetPos";
				break;
			case EAction.SetVar:
				result = "SetVar";
				break;
			case EAction.SetActorVar:
				result = "SetActorVar";
				break;
			case EAction.ShowCenterText:
				result = "ShowCenterText";
				break;
			case EAction.ShowMessage:
				result = "ShowMessage";
				break;
			case EAction.ShowTalk:
				result = "ShowTalk";
				break;
			case EAction.SimpleMove:
				result = "SimpleMove";
				break;
			case EAction.SpawnChild:
				result = "SpawnChild";
				break;
			case EAction.SpawnEntity:
				result = "SpawnEntity";
				break;
			case EAction.SyncVarToActorState:
				result = "SyncVarToActorState";
				break;
			case EAction.Wait:
				result = "Wait";
				break;
			case EAction.AddBuffToEntity:
				result = "AddBuffToEntity";
				break;
			case EAction.AddBuffToPlayer:
				result = "AddBuffToPlayer";
				break;
			case EAction.AddBuffToFollowShooter:
				result = "AddBuffToFollowShooter";
				break;
			case EAction.LockEntity:
				result = "LockEntity";
				break;
			case EAction.UnlockEntity:
				result = "UnlockEntity";
				break;
			case EAction.SetForceLock:
				result = "SetForceLock";
				break;
			case EAction.SetAreaState:
				result = "SetAreaState";
				break;
			case EAction.SetWuYinQuState:
				result = "SetWuYinQuState";
				break;
			case EAction.RemoveBuffFromEntity:
				result = "RemoveBuffFromEntity";
				break;
			case EAction.RemoveBuffFromPlayer:
				result = "RemoveBuffFromPlayer";
				break;
			case EAction.SetPlayerMoveControl:
				result = "SetPlayerMoveControl";
				break;
			case EAction.UnlockTeleportTrigger:
				result = "UnlockTeleportTrigger";
				break;
			case EAction.ChangeTeamPosition:
				result = "ChangeTeamPosition";
				break;
			case EAction.ClientChangeTeamPosition:
				result = "ClientChangeTeamPosition";
				break;
			case EAction.ClaimLevelPlayReward:
				result = "ClaimLevelPlayReward";
				break;
			case EAction.ClaimDynamicEntityReward:
				result = "ClaimDynamicEntityReward";
				break;
			case EAction.SetReviveRegion:
				result = "SetReviveRegion";
				break;
			case EAction.PromptQuestChapterUI:
				result = "PromptQuestChapterUI";
				break;
			case EAction.FireBullet:
				result = "FireBullet";
				break;
			case EAction.FireBulletEffect:
				result = "FireBulletEffect";
				break;
			case EAction.SetPlayerPos:
				result = "SetPlayerPos";
				break;
			case EAction.ClientSetPlayerPos:
				result = "ClientSetPlayerPos";
				break;
			case EAction.ClientPreEnableSubLevels:
				result = "ClientPreEnableSubLevels";
				break;
			case EAction.ChangeSelfEntityState:
				result = "ChangeSelfEntityState";
				break;
			case EAction.InterludeActions:
				result = "InterludeActions";
				break;
			case EAction.AddBuffToTriggeredEntity:
				result = "AddBuffToTriggeredEntity";
				break;
			case EAction.RemoveBuffToTriggeredEntity:
				result = "RemoveBuffToTriggeredEntity";
				break;
			case EAction.DetectTrigger:
				result = "DetectTrigger";
				break;
			case EAction.ItemFoundationMatch:
				result = "ItemFoundationMatch";
				break;
			case EAction.SetBattleState:
				result = "SetBattleState";
				break;
			case EAction.WaitBattleCondition:
				result = "WaitBattleCondition";
				break;
			case EAction.UnlockSystemItem:
				result = "UnlockSystemItem";
				break;
			case EAction.ClientUnlockAchievementSystemItem:
				result = "ClientUnlockAchievementSystemItem";
				break;
			case EAction.RunActions:
				result = "RunActions";
				break;
			case EAction.CommonTip:
				result = "CommonTip";
				break;
			case EAction.EndCommonTip:
				result = "EndCommonTip";
				break;
			case EAction.CommonTip2:
				result = "CommonTip2";
				break;
			case EAction.EnableNearbyTracking:
				result = "EnableNearbyTracking";
				break;
			case EAction.EnableLevelPlay:
				result = "EnableLevelPlay";
				break;
			case EAction.UnLimitPlayerOperation:
				result = "UnLimitPlayerOperation";
				break;
			case EAction.LimitPlayerOperation:
				result = "LimitPlayerOperation";
				break;
			case EAction.SetPlayerOperationRestriction:
				result = "SetPlayerOperationRestriction";
				break;
			case EAction.ClientSetPlayerOperationRestriction:
				result = "ClientSetPlayerOperationRestriction";
				break;
			case EAction.LeisureInteract:
				result = "LeisureInteract";
				break;
			case EAction.NpcLeisureInteract:
				result = "NpcLeisureInteract";
				break;
			case EAction.ChangePhantom:
				result = "ChangePhantom";
				break;
			case EAction.RestorePhantom:
				result = "RestorePhantom";
				break;
			case EAction.TakePlotPhoto:
				result = "TakePlotPhoto";
				break;
			case EAction.OpenQte:
				result = "OpenQte";
				break;
			case EAction.Preload:
				result = "Preload";
				break;
			case EAction.RemovePreloadResource:
				result = "RemovePreloadResource";
				break;
			case EAction.ExecAlertSystemAction:
				result = "ExecAlertSystemAction";
				break;
			case EAction.RecordDungeonEvent:
				result = "RecordDungeonEvent";
				break;
			case EAction.ResetLevelPlay:
				result = "ResetLevelPlay";
				break;
			case EAction.SetAreaTimeState:
				result = "SetAreaTimeState";
				break;
			case EAction.GetRewardByInteract:
				result = "GetRewardByInteract";
				break;
			case EAction.WaitUntilLevelSequenceReachMark:
				result = "WaitUntilLevelSequenceReachMark";
				break;
			case EAction.EnableKey4Func:
				result = "EnableKey4Func";
				break;
			case EAction.OpenQuickHackSystem:
				result = "OpenQuickHackSystem";
				break;
			case EAction.GuestOperateUiAnimation:
				result = "GuestOperateUiAnimation";
				break;
			case EAction.VehicleEnter:
				result = "VehicleEnter";
				break;
			case EAction.VehicleEnterNpc:
				result = "VehicleEnterNpc";
				break;
			case EAction.VehicleExitPlayer:
				result = "VehicleExitPlayer";
				break;
			case EAction.VehicleExitNpc:
				result = "VehicleExitNpc";
				break;
			case EAction.VehicleTeleport:
				result = "VehicleTeleport";
				break;
			case EAction.ClientVehicleTeleport:
				result = "ClientVehicleTeleport";
				break;
			case EAction.VehiclePlayPassengerVoice:
				result = "VehiclePlayPassengerVoice";
				break;
			case EAction.VehicleWaterfallClimbing:
				result = "VehicleWaterfallClimbing";
				break;
			case EAction.TeleportToAndEnterVehicle:
				result = "TeleportToAndEnterVehicle";
				break;
			case EAction.VehicleMoveWithPathLine:
				result = "VehicleMoveWithPathLine";
				break;
			case EAction.VehicleSprint:
				result = "VehicleSprint";
				break;
			case EAction.VehicleSetSpeedImmediately:
				result = "VehicleSetSpeedImmediately";
				break;
			case EAction.TeleportDungeon:
				result = "TeleportDungeon";
				break;
			case EAction.SettlementDungeon:
				result = "SettlementDungeon";
				break;
			case EAction.ClaimDungeonReward:
				result = "ClaimDungeonReward";
				break;
			case EAction.ExitDungeon:
				result = "ExitDungeon";
				break;
			case EAction.UnlockDungeonEntry:
				result = "UnlockDungeonEntry";
				break;
			case EAction.FinishDungeon:
				result = "FinishDungeon";
				break;
			case EAction.StopUiScreenEffect:
				result = "StopUiScreenEffect";
				break;
			case EAction.StartFlowTemplate:
				result = "StartFlowTemplate";
				break;
			case EAction.BeginFlowTemplate:
				result = "BeginFlowTemplate";
				break;
			case EAction.ChangeFlowTemplate:
				result = "ChangeFlowTemplate";
				break;
			case EAction.SetFlowTemplate:
				result = "SetFlowTemplate";
				break;
			case EAction.EndFlowTemplate:
				result = "EndFlowTemplate";
				break;
			case EAction.CloseFlowTemplate:
				result = "CloseFlowTemplate";
				break;
			case EAction.SendAiEvent:
				result = "SendAiEvent";
				break;
			case EAction.FadeInScreen:
				result = "FadeInScreen";
				break;
			case EAction.FadeOutScreen:
				result = "FadeOutScreen";
				break;
			case EAction.ChangeFightTeam:
				result = "ChangeFightTeam";
				break;
			case EAction.ManualOccupations:
				result = "ManualOccupations";
				break;
			case EAction.AddTrialCharacter:
				result = "AddTrialCharacter";
				break;
			case EAction.UpdateTrialCharacter:
				result = "UpdateTrialCharacter";
				break;
			case EAction.RestoreTrialCharacter:
				result = "RestoreTrialCharacter";
				break;
			case EAction.RemoveTrialCharacter:
				result = "RemoveTrialCharacter";
				break;
			case EAction.AddGuestCharacter:
				result = "AddGuestCharacter";
				break;
			case EAction.RemoveGuestCharacter:
				result = "RemoveGuestCharacter";
				break;
			case EAction.AddTrialFollowShooter:
				result = "AddTrialFollowShooter";
				break;
			case EAction.RemoveTrialFollowShooter:
				result = "RemoveTrialFollowShooter";
				break;
			case EAction.EnableFollowShooterAbility:
				result = "EnableFollowShooterAbility";
				break;
			case EAction.ClientFollowShooterLeisureInteract:
				result = "ClientFollowShooterLeisureInteract";
				break;
			case EAction.DestroyQuest:
				result = "DestroyQuest";
				break;
			case EAction.SetCameraAnim:
				result = "SetCameraAnim";
				break;
			case EAction.RotatorEntity:
				result = "RotatorEntity";
				break;
			case EAction.TraceSpline:
				result = "TraceSpline";
				break;
			case EAction.ToggleScanSplineEffect:
				result = "ToggleScanSplineEffect";
				break;
			case EAction.ChangeTimer:
				result = "ChangeTimer";
				break;
			case EAction.ToggleTimerPauseState:
				result = "ToggleTimerPauseState";
				break;
			case EAction.EnableSystem:
				result = "EnableSystem";
				break;
			case EAction.PostAkEvent:
				result = "PostAkEvent";
				break;
			case EAction.MoveSceneItem:
				result = "MoveSceneItem";
				break;
			case EAction.StopSceneItemMove:
				result = "StopSceneItemMove";
				break;
			case EAction.ChangeLiftTarget:
				result = "ChangeLiftTarget";
				break;
			case EAction.HideByRangeInFlow:
				result = "HideByRangeInFlow";
				break;
			case EAction.ShowAllHidedGroupInFlow:
				result = "ShowAllHidedGroupInFlow";
				break;
			case EAction.OpenSimpleGameplay:
				result = "OpenSimpleGameplay";
				break;
			case EAction.CloseSimpleGameplay:
				result = "CloseSimpleGameplay";
				break;
			case EAction.ChangeActorTalker:
				result = "ChangeActorTalker";
				break;
			case EAction.SwitchSubLevels:
				result = "SwitchSubLevels";
				break;
			case EAction.SwitchDataLayers:
				result = "SwitchDataLayers";
				break;
			case EAction.ActivateResetPoint:
				result = "ActivateResetPoint";
				break;
			case EAction.TeleportToLatestResetPoint:
				result = "TeleportToLatestResetPoint";
				break;
			case EAction.SetWeather:
				result = "SetWeather";
				break;
			case EAction.SetTimeLockState:
				result = "SetTimeLockState";
				break;
			case EAction.SetWeatherLockState:
				result = "SetWeatherLockState";
				break;
			case EAction.AdjustPlayerCamera:
				result = "AdjustPlayerCamera";
				break;
			case EAction.AdjustPlayerCameraGravity:
				result = "AdjustPlayerCameraGravity";
				break;
			case EAction.RestorePlayerCameraAdjustment:
				result = "RestorePlayerCameraAdjustment";
				break;
			case EAction.EnterMovieCamera:
				result = "EnterMovieCamera";
				break;
			case EAction.ExitMovieCamera:
				result = "ExitMovieCamera";
				break;
			case EAction.ResetPlayerCameraFocus:
				result = "ResetPlayerCameraFocus";
				break;
			case EAction.UsePhantomSkill:
				result = "UsePhantomSkill";
				break;
			case EAction.ChangePhantomFormation:
				result = "ChangePhantomFormation";
				break;
			case EAction.RestorePhantomFormation:
				result = "RestorePhantomFormation";
				break;
			case EAction.EnterOrbitalCamera:
				result = "EnterOrbitalCamera";
				break;
			case EAction.ExitOrbitalCamera:
				result = "ExitOrbitalCamera";
				break;
			case EAction.EnableSplineMoveModel:
				result = "EnableSplineMoveModel";
				break;
			case EAction.SetSportsState:
				result = "SetSportsState";
				break;
			case EAction.PlayLevelSequence:
				result = "PlayLevelSequence";
				break;
			case EAction.EnableTakePhotoClip:
				result = "EnableTakePhotoClip";
				break;
			case EAction.SetExploreState:
				result = "SetExploreState";
				break;
			case EAction.EnableAoiNotify:
				result = "EnableAoiNotify";
				break;
			case EAction.ChangeEntityPrefabPerformance:
				result = "ChangeEntityPrefabPerformance";
				break;
			case EAction.ModifySceneItemAttributeTag:
				result = "ModifySceneItemAttributeTag";
				break;
			case EAction.ClientModifyTargetTag:
				result = "ClientModifyTargetTag";
				break;
			case EAction.ToggleMapMarkState:
				result = "ToggleMapMarkState";
				break;
			case EAction.FocusOnMapMark:
				result = "FocusOnMapMark";
				break;
			case EAction.ToggleHighlightExploreUi:
				result = "ToggleHighlightExploreUi";
				break;
			case EAction.EnableTemporaryTeleport:
				result = "EnableTemporaryTeleport";
				break;
			case EAction.SetTeleControl:
				result = "SetTeleControl";
				break;
			case EAction.ActiveAntiGravitySafePoint:
				result = "ActiveAntiGravitySafePoint";
				break;
			case EAction.TriggerSpecificScanEffect:
				result = "TriggerSpecificScanEffect";
				break;
			case EAction.SendClientEvent:
				result = "SendClientEvent";
				break;
			case EAction.ClearFishingCabinInSaleItems:
				result = "ClearFishingCabinInSaleItems";
				break;
			case EAction.AcceptFishingEntrust:
				result = "AcceptFishingEntrust";
				break;
			case EAction.DestroyFishingBoat:
				result = "DestroyFishingBoat";
				break;
			case EAction.SlideRailStart:
				result = "SlideRailStart";
				break;
			case EAction.SlideRailEnd:
				result = "SlideRailEnd";
				break;
			case EAction.SlidePerformStart:
				result = "SlidePerformStart";
				break;
			case EAction.BvbSendSystemEvent:
				result = "BvbSendSystemEvent";
				break;
			case EAction.BvbSendAiEvent:
				result = "BvbSendAiEvent";
				break;
			case EAction.BvbPlayDialog:
				result = "BvbPlayDialog";
				break;
			case EAction.BvbPlayerOperationConstraint:
				result = "BvbPlayerOperationConstraint";
				break;
			case EAction.BvbSkipChallenge:
				result = "BvbSkipChallenge";
				break;
			case EAction.SetSpineAnimation:
				result = "SetSpineAnimation";
				break;
			case EAction.ChangeEntityCamp:
				result = "ChangeEntityCamp";
				break;
			case EAction.TrapDefenseChangeMiniMap:
				result = "TrapDefenseChangeMiniMap";
				break;
			case EAction.TrapDefensePlayerOperationConstraint:
				result = "TrapDefensePlayerOperationConstraint";
				break;
			case EAction.RogueGotoNextFloor:
				result = "RogueGotoNextFloor";
				break;
			case EAction.RogueSelectRoom:
				result = "RogueSelectRoom";
				break;
			case EAction.RogueActivatePortal:
				result = "RogueActivatePortal";
				break;
			case EAction.RogueReceiveReward:
				result = "RogueReceiveReward";
				break;
			case EAction.ExecRiskHarvestEffect:
				result = "ExecRiskHarvestEffect";
				break;
			case EAction.MowingTowerGotoNextFloor:
				result = "MowingTowerGotoNextFloor";
				break;
			case EAction.SlashAndTowerGotoNextFloor:
				result = "SlashAndTowerGotoNextFloor";
				break;
			case EAction.RoleTowerGotoNextFloor:
				result = "RoleTowerGotoNextFloor";
				break;
			case EAction.DangoAbyssActivatePortal:
				result = "DangoAbyssActivatePortal";
				break;
			case EAction.DangoAbyssGotoNextFloor:
				result = "DangoAbyssGotoNextFloor";
				break;
			case EAction.DangoAbyssCreateRewardTreasureBox:
				result = "DangoAbyssCreateRewardTreasureBox";
				break;
			case EAction.DangoAbyssReceiveReward:
				result = "DangoAbyssReceiveReward";
				break;
			case EAction.RoverRogueRoomFinish:
				result = "RoverRogueRoomFinish";
				break;
			case EAction.RoverRogueActivate:
				result = "RoverRogueActivate";
				break;
			case EAction.RoverRogueCreateRoomReward:
				result = "RoverRogueCreateRoomReward";
				break;
			case EAction.EnableActor:
				result = "EnableActor";
				break;
			case EAction.ModifyActorMaterial:
				result = "ModifyActorMaterial";
				break;
			case EAction.SpecialOpModifyActorMaterialParamBySplineProgress:
				result = "SpecialOpModifyActorMaterialParamBySplineProgress";
				break;
			case EAction.ModifyActorMedia:
				result = "ModifyActorMedia";
				break;
			case EAction.ToggleAirWall:
				result = "ToggleAirWall";
				break;
			case EAction.SetDataLayerTransitions:
				result = "SetDataLayerTransitions";
				break;
			case EAction.TriggerCameraShake:
				result = "TriggerCameraShake";
				break;
			case EAction.TriggerGamepadShake:
				result = "TriggerGamepadShake";
				break;
			case EAction.CreatePrefab:
				result = "CreatePrefab";
				break;
			case EAction.DestroyPrefab:
				result = "DestroyPrefab";
				break;
			case EAction.ExecBattleAction:
				result = "ExecBattleAction";
				break;
			case EAction.ExecClientBattleAction:
				result = "ExecClientBattleAction";
				break;
			case EAction.RecoverDurability:
				result = "RecoverDurability";
				break;
			case EAction.SetRegionConfig:
				result = "SetRegionConfig";
				break;
			case EAction.SetJigsawItem:
				result = "SetJigsawItem";
				break;
			case EAction.SetJigsawFoundation:
				result = "SetJigsawFoundation";
				break;
			case EAction.ResetEntity:
				result = "ResetEntity";
				break;
			case EAction.PlayDynamicSettlement:
				result = "PlayDynamicSettlement";
				break;
			case EAction.SetInteractionLockState:
				result = "SetInteractionLockState";
				break;
			case EAction.FinishCondition:
				result = "FinishCondition";
				break;
			case EAction.ClearEntityVisibleTag:
				result = "ClearEntityVisibleTag";
				break;
			case EAction.SetEntityPos:
				result = "SetEntityPos";
				break;
			case EAction.ResetEntityPos:
				result = "ResetEntityPos";
				break;
			case EAction.ServerSetPlayerPos:
				result = "ServerSetPlayerPos";
				break;
			case EAction.FixTeleControllerPos:
				result = "FixTeleControllerPos";
				break;
			case EAction.CustomJson:
				result = "CustomJson";
				break;
			case EAction.FixFoundationRelation:
				result = "FixFoundationRelation";
				break;
			case EAction.FixShowTargetRange:
				result = "FixShowTargetRange";
				break;
			case EAction.TraceCurrentQuest:
				result = "TraceCurrentQuest";
				break;
			case EAction.ForceOccupations:
				result = "ForceOccupations";
				break;
			case EAction.ServerForceEnableLevelPlay:
				result = "ServerForceEnableLevelPlay";
				break;
			case EAction.TeleportDungeonPos:
				result = "TeleportDungeonPos";
				break;
			case EAction.SetTimeScale:
				result = "SetTimeScale";
				break;
			case EAction.FixGetItem:
				result = "FixGetItem";
				break;
			case EAction.SetAudioState:
				result = "SetAudioState";
				break;
			case EAction.PerformerAiSplineMove:
				result = "PerformerAiSplineMove";
				break;
			case EAction.PerformerAiMoveTo:
				result = "PerformerAiMoveTo";
				break;
			case EAction.EnterPatrolState:
				result = "EnterPatrolState";
				break;
			case EAction.PerformAiHideSelf:
				result = "PerformAiHideSelf";
				break;
			case EAction.ExecResurrection:
				result = "ExecResurrection";
				break;
			case EAction.HideSpecificEntities:
				result = "HideSpecificEntities";
				break;
			case EAction.ShowSpecificEntities:
				result = "ShowSpecificEntities";
				break;
			case EAction.HideTargetRange:
				result = "HideTargetRange";
				break;
			case EAction.ShowTargetRange:
				result = "ShowTargetRange";
				break;
			case EAction.HideGroup:
				result = "HideGroup";
				break;
			case EAction.ShowHidedGroup:
				result = "ShowHidedGroup";
				break;
			case EAction.ReignsSetPropertyVisible:
				result = "ReignsSetPropertyVisible";
				break;
			case EAction.ReignsChangeBackground:
				result = "ReignsChangeBackground";
				break;
			case EAction.ReignsChangePlayerName:
				result = "ReignsChangePlayerName";
				break;
			case EAction.ReignsCallCard:
				result = "ReignsCallCard";
				break;
			case EAction.ReignsTriggerGuide:
				result = "ReignsTriggerGuide";
				break;
			case EAction.ReignsAddBuff:
				result = "ReignsAddBuff";
				break;
			case EAction.ReignsCheckSettle:
				result = "ReignsCheckSettle";
				break;
			case EAction.HonamiStoryInteractPickUp:
				result = "HonamiStoryInteractPickUp";
				break;
			case EAction.HonamiStoryReceiveCorruptedChestReward:
				result = "HonamiStoryReceiveCorruptedChestReward";
				break;
			case EAction.HonamiStoryActivateSafeEvacuation:
				result = "HonamiStoryActivateSafeEvacuation";
				break;
			case EAction.HonamiStoryGetItem:
				result = "HonamiStoryGetItem";
				break;
			case EAction.HonamiStorySetFormation:
				result = "HonamiStorySetFormation";
				break;
			case EAction.InfrActivityUpgradeInfrastructure:
				result = "InfrActivityUpgradeInfrastructure";
				break;
			case EAction.SetNpcGroupPerform:
				result = "SetNpcGroupPerform";
				break;
			case EAction.RemoveNpcGroupPerform:
				result = "RemoveNpcGroupPerform";
				break;
			case EAction.EnableEntityLookAt:
				result = "EnableEntityLookAt";
				break;
			case EAction.DisableEntityLookAt:
				result = "DisableEntityLookAt";
				break;
			case EAction.OverrideAiBehaviorTree:
				result = "OverrideAiBehaviorTree";
				break;
			case EAction.RestoreAiBehaviorTree:
				result = "RestoreAiBehaviorTree";
				break;
			case EAction.FlowDefineNpcGroupPerform:
				result = "FlowDefineNpcGroupPerform";
				break;
			case EAction.SeqEventAddTagToSelf:
				result = "SeqEventAddTagToSelf";
				break;
			case EAction.SeqEventFireBullet:
				result = "SeqEventFireBullet";
				break;
			case EAction.SetMotorSpeed:
				result = "SetMotorSpeed";
				break;
			case EAction.StartMotorCruise:
				result = "StartMotorCruise";
				break;
			case EAction.StopMotorCruise:
				result = "StopMotorCruise";
				break;
			case EAction.DriveMotorInSpecConfig:
				result = "DriveMotorInSpecConfig";
				break;
			case EAction.MotorSoarInWindField:
				result = "MotorSoarInWindField";
				break;
			case EAction.CollectSunSpirit:
				result = "CollectSunSpirit";
				break;
			case EAction.PerformSunSpiritGearRoundTrip:
				result = "PerformSunSpiritGearRoundTrip";
				break;
			case EAction.TriggerDeadeyeMode:
				result = "TriggerDeadeyeMode";
				break;
			case EAction.OpenSystemBoardWithReturn:
				result = "OpenSystemBoardWithReturn";
				break;
			case EAction.ResumeSystemRewardPopup:
				result = "ResumeSystemRewardPopup";
				break;
			case EAction.SummonEntity:
				result = "SummonEntity";
				break;
			case EAction.DestroySummonedEntities:
				result = "DestroySummonedEntities";
				break;
			case EAction.SetupMoraleSystem:
				result = "SetupMoraleSystem";
				break;
			case EAction.GiantToggleModel:
				result = "GiantToggleModel";
				break;
			case EAction.GiantTriggerResponse:
				result = "GiantTriggerResponse";
				break;
			case EAction.ActivateGiantTotalProgressNode:
				result = "ActivateGiantTotalProgressNode";
				break;
			case EAction.RunActorCustomEvent:
				result = "RunActorCustomEvent";
				break;
			case EAction.RequestSystemFunction:
				result = "RequestSystemFunction";
				break;
			case EAction.PlayWalkingOverlayMontage:
				result = "PlayWalkingOverlayMontage";
				break;
			case EAction.ChangeNpcAbpState:
				result = "ChangeNpcAbpState";
				break;
			case EAction.CloseWalkingOverlayMontage:
				result = "CloseWalkingOverlayMontage";
				break;
			case EAction.SetSkillButtonEffect:
				result = "SetSkillButtonEffect";
				break;
			case EAction.ScanEnrichmentArea:
				result = "ScanEnrichmentArea";
				break;
			case EAction.TriggerSystemRandomPlot:
				result = "TriggerSystemRandomPlot";
				break;
			case EAction.SetAudioEnable:
				result = "SetAudioEnable";
				break;
			case EAction.PhoneSystemInteract:
				result = "PhoneSystemInteract";
				break;
			case EAction.RollBlockGetReward:
				result = "RollBlockGetReward";
				break;
			case EAction.EnterMovieMode:
				result = "EnterMovieMode";
				break;
			case EAction.ExitMovieMode:
				result = "ExitMovieMode";
				break;
			case EAction.StartRoadNetworkNavigation:
				result = "StartRoadNetworkNavigation";
				break;
			case EAction.SetWayOccupancyState:
				result = "SetWayOccupancyState";
				break;
			case EAction.SendSceneActorsEvent:
				result = "SendSceneActorsEvent";
				break;
			case EAction.ExecBpActorFunc:
				result = "ExecBpActorFunc";
				break;
			case EAction.ResetPlayerPosWithPresentation:
				result = "ResetPlayerPosWithPresentation";
				break;
			case EAction.PlayerLookTowards:
				result = "PlayerLookTowards";
				break;
			case EAction.DrinksRollRoleRequirement:
				result = "DrinksRollRoleRequirement";
				break;
			case EAction.SetBlendAnim:
				result = "SetBlendAnim";
				break;
			case EAction.ReportTrackingEvent:
				result = "ReportTrackingEvent";
				break;
			case EAction.TetrisThrowBlock:
				result = "TetrisThrowBlock";
				break;
			case EAction.TetrisGameComplete:
				result = "TetrisGameComplete";
				break;
			case EAction.TetrisTriggerDelayFall:
				result = "TetrisTriggerDelayFall";
				break;
			case EAction.BossPilingRandomBuff:
				result = "BossPilingRandomBuff";
				break;
			case EAction.BossPilingEnterNextInst:
				result = "BossPilingEnterNextInst";
				break;
			case EAction.DollGrabItemDelivery:
				result = "DollGrabItemDelivery";
				break;
			case EAction.AvgPlayRoleAction:
				result = "AvgPlayRoleAction";
				break;
			case EAction.AvgMoveRole:
				result = "AvgMoveRole";
				break;
			case EAction.AvgFocusRole:
				result = "AvgFocusRole";
				break;
			case EAction.AvgShakeUi:
				result = "AvgShakeUi";
				break;
			case EAction.DestroyDynamicEntities:
				result = "DestroyDynamicEntities";
				break;
			case EAction.SheriffUnlockClue:
				result = "SheriffUnlockClue";
				break;
			case EAction.SheriffUnlockProgress:
				result = "SheriffUnlockProgress";
				break;
			case EAction.SheriffChangeCriminalState:
				result = "SheriffChangeCriminalState";
				break;
			case EAction.SheriffChangeCriminalIdentity:
				result = "SheriffChangeCriminalIdentity";
				break;
			case EAction.SheriffUnlockEnding:
				result = "SheriffUnlockEnding";
				break;
			case EAction.SetSubScreenMode:
				result = "SetSubScreenMode";
				break;
			case EAction.ClientSetSeasonState:
				result = "ClientSetSeasonState";
				break;
			case EAction.ToggleDragActorPlay:
				result = "ToggleDragActorPlay";
				break;
			case EAction.SetTargetElementalAbility:
				result = "SetTargetElementalAbility";
				break;
			case EAction.ToggleEntityElementalAbility:
				result = "ToggleEntityElementalAbility";
				break;
			case EAction.CaptureElementalBox:
				result = "CaptureElementalBox";
				break;
			case EAction.ChangeElementalBoxState:
				result = "ChangeElementalBoxState";
				break;
			case EAction.SetElementalBoxToTarget:
				result = "SetElementalBoxToTarget";
				break;
			case EAction.OverrideAbpAnimScheme:
				result = "OverrideAbpAnimScheme";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C1D6 RID: 49622 RVA: 0x001BE3B0 File Offset: 0x001BC5B0
		public static EAction FromString(string name)
		{
			EAction result;
			if (!EActionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAction 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C1D7 RID: 49623 RVA: 0x001BE3DC File Offset: 0x001BC5DC
		public static bool TryFromString(string name, out EAction value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAction.Undefined;
				return false;
			}
			uint num = <PrivateImplementationDetails>.ComputeStringHash(name);
			if (num <= 2134091447U)
			{
				if (num <= 926594151U)
				{
					if (num <= 457807016U)
					{
						if (num <= 249084523U)
						{
							if (num <= 136874514U)
							{
								if (num <= 56887563U)
								{
									if (num <= 41132262U)
									{
										if (num != 22706352U)
										{
											if (num != 23025330U)
											{
												if (num == 41132262U)
												{
													if (name == "ChangeEntityPrefabPerformance")
													{
														value = EAction.ChangeEntityPrefabPerformance;
														return true;
													}
												}
											}
											else if (name == "DangoAbyssGotoNextFloor")
											{
												value = EAction.DangoAbyssGotoNextFloor;
												return true;
											}
										}
										else if (name == "ChangeFightTeam")
										{
											value = EAction.ChangeFightTeam;
											return true;
										}
									}
									else if (num != 45121926U)
									{
										if (num != 45938099U)
										{
											if (num == 56887563U)
											{
												if (name == "ClientModifyTargetTag")
												{
													value = EAction.ClientModifyTargetTag;
													return true;
												}
											}
										}
										else if (name == "ToggleAirWall")
										{
											value = EAction.ToggleAirWall;
											return true;
										}
									}
									else if (name == "PromptQuestChapterUI")
									{
										value = EAction.PromptQuestChapterUI;
										return true;
									}
								}
								else if (num <= 78952540U)
								{
									if (num != 57702761U)
									{
										if (num != 69267889U)
										{
											if (num == 78952540U)
											{
												if (name == "TeleportDungeon")
												{
													value = EAction.TeleportDungeon;
													return true;
												}
											}
										}
										else if (name == "TriggerDeadeyeMode")
										{
											value = EAction.TriggerDeadeyeMode;
											return true;
										}
									}
									else if (name == "SetCameraAnim")
									{
										value = EAction.SetCameraAnim;
										return true;
									}
								}
								else if (num != 79142899U)
								{
									if (num != 106482998U)
									{
										if (num == 136874514U)
										{
											if (name == "RoverRogueActivate")
											{
												value = EAction.RoverRogueActivate;
												return true;
											}
										}
									}
									else if (name == "VehicleSetSpeedImmediately")
									{
										value = EAction.VehicleSetSpeedImmediately;
										return true;
									}
								}
								else if (name == "SendAiEvent")
								{
									value = EAction.SendAiEvent;
									return true;
								}
							}
							else if (num <= 198508992U)
							{
								if (num <= 158977448U)
								{
									if (num != 150091782U)
									{
										if (num != 156119723U)
										{
											if (num == 158977448U)
											{
												if (name == "RestorePlayerCameraAdjustment")
												{
													value = EAction.RestorePlayerCameraAdjustment;
													return true;
												}
											}
										}
										else if (name == "ResetEntityPos")
										{
											value = EAction.ResetEntityPos;
											return true;
										}
									}
									else if (name == "SetTimeLockState")
									{
										value = EAction.SetTimeLockState;
										return true;
									}
								}
								else if (num != 169702171U)
								{
									if (num != 190835426U)
									{
										if (num == 198508992U)
										{
											if (name == "Wait")
											{
												value = EAction.Wait;
												return true;
											}
										}
									}
									else if (name == "SetBattleState")
									{
										value = EAction.SetBattleState;
										return true;
									}
								}
								else if (name == "EnableSplineMoveModel")
								{
									value = EAction.EnableSplineMoveModel;
									return true;
								}
							}
							else if (num <= 229332899U)
							{
								if (num != 212064749U)
								{
									if (num != 218930631U)
									{
										if (num == 229332899U)
										{
											if (name == "VehicleSprint")
											{
												value = EAction.VehicleSprint;
												return true;
											}
										}
									}
									else if (name == "SetWeatherLockState")
									{
										value = EAction.SetWeatherLockState;
										return true;
									}
								}
								else if (name == "SetSkillButtonEffect")
								{
									value = EAction.SetSkillButtonEffect;
									return true;
								}
							}
							else if (num <= 238518974U)
							{
								if (num != 237916026U)
								{
									if (num == 238518974U)
									{
										if (name == "RestoreTrialCharacter")
										{
											value = EAction.RestoreTrialCharacter;
											return true;
										}
									}
								}
								else if (name == "RemoveTrialCharacter")
								{
									value = EAction.RemoveTrialCharacter;
									return true;
								}
							}
							else if (num != 240678689U)
							{
								if (num == 249084523U)
								{
									if (name == "ClearEntityVisibleTag")
									{
										value = EAction.ClearEntityVisibleTag;
										return true;
									}
								}
							}
							else if (name == "TetrisThrowBlock")
							{
								value = EAction.TetrisThrowBlock;
								return true;
							}
						}
						else if (num <= 356172353U)
						{
							if (num <= 315424526U)
							{
								if (num <= 270277162U)
								{
									if (num != 261008808U)
									{
										if (num != 265317419U)
										{
											if (num == 270277162U)
											{
												if (name == "PerformAiHideSelf")
												{
													value = EAction.PerformAiHideSelf;
													return true;
												}
											}
										}
										else if (name == "ChangeActorTalker")
										{
											value = EAction.ChangeActorTalker;
											return true;
										}
									}
									else if (name == "ClientChangeTeamPosition")
									{
										value = EAction.ClientChangeTeamPosition;
										return true;
									}
								}
								else if (num != 274257416U)
								{
									if (num != 278614064U)
									{
										if (num == 315424526U)
										{
											if (name == "ResumeSystemRewardPopup")
											{
												value = EAction.ResumeSystemRewardPopup;
												return true;
											}
										}
									}
									else if (name == "RunActorCustomEvent")
									{
										value = EAction.RunActorCustomEvent;
										return true;
									}
								}
								else if (name == "SendClientEvent")
								{
									value = EAction.SendClientEvent;
									return true;
								}
							}
							else if (num <= 331528337U)
							{
								if (num != 316026938U)
								{
									if (num != 326161380U)
									{
										if (num == 331528337U)
										{
											if (name == "FadeOutScreen")
											{
												value = EAction.FadeOutScreen;
												return true;
											}
										}
									}
									else if (name == "SetTeleControl")
									{
										value = EAction.SetTeleControl;
										return true;
									}
								}
								else if (name == "ActivateGiantTotalProgressNode")
								{
									value = EAction.ActivateGiantTotalProgressNode;
									return true;
								}
							}
							else if (num != 333012204U)
							{
								if (num != 345639526U)
								{
									if (num == 356172353U)
									{
										if (name == "RunActions")
										{
											value = EAction.RunActions;
											return true;
										}
									}
								}
								else if (name == "HonamiStoryInteractPickUp")
								{
									value = EAction.HonamiStoryInteractPickUp;
									return true;
								}
							}
							else if (name == "RemoveEffect")
							{
								value = EAction.RemoveEffect;
								return true;
							}
						}
						else if (num <= 409824003U)
						{
							if (num <= 375091148U)
							{
								if (num != 363387785U)
								{
									if (num != 363425241U)
									{
										if (num == 375091148U)
										{
											if (name == "ToggleHighlightExploreUi")
											{
												value = EAction.ToggleHighlightExploreUi;
												return true;
											}
										}
									}
									else if (name == "StopMotorCruise")
									{
										value = EAction.StopMotorCruise;
										return true;
									}
								}
								else if (name == "NewMoveWithSpline")
								{
									value = EAction.NewMoveWithSpline;
									return true;
								}
							}
							else if (num != 375883995U)
							{
								if (num != 383202675U)
								{
									if (num == 409824003U)
									{
										if (name == "SetJigsawItem")
										{
											value = EAction.SetJigsawItem;
											return true;
										}
									}
								}
								else if (name == "ChangeFlowTemplate")
								{
									value = EAction.ChangeFlowTemplate;
									return true;
								}
							}
							else if (name == "FixGetItem")
							{
								value = EAction.FixGetItem;
								return true;
							}
						}
						else if (num <= 427538078U)
						{
							if (num != 413087700U)
							{
								if (num != 413582567U)
								{
									if (num == 427538078U)
									{
										if (name == "SetEntityVisible")
										{
											value = EAction.SetEntityVisible;
											return true;
										}
									}
								}
								else if (name == "PlayWalkingOverlayMontage")
								{
									value = EAction.PlayWalkingOverlayMontage;
									return true;
								}
							}
							else if (name == "EnterPatrolState")
							{
								value = EAction.EnterPatrolState;
								return true;
							}
						}
						else if (num <= 453451113U)
						{
							if (num != 451126951U)
							{
								if (num == 453451113U)
								{
									if (name == "StartFlowTemplate")
									{
										value = EAction.StartFlowTemplate;
										return true;
									}
								}
							}
							else if (name == "ReignsAddBuff")
							{
								value = EAction.ReignsAddBuff;
								return true;
							}
						}
						else if (num != 455347589U)
						{
							if (num == 457807016U)
							{
								if (name == "EntityTurnTo")
								{
									value = EAction.EntityTurnTo;
									return true;
								}
							}
						}
						else if (name == "ClientVehicleTeleport")
						{
							value = EAction.ClientVehicleTeleport;
							return true;
						}
					}
					else if (num <= 626645766U)
					{
						if (num <= 552822251U)
						{
							if (num <= 496820238U)
							{
								if (num <= 468072804U)
								{
									if (num != 458574783U)
									{
										if (num != 461073112U)
										{
											if (num == 468072804U)
											{
												if (name == "PlayerInput")
												{
													value = EAction.PlayerInput;
													return true;
												}
											}
										}
										else if (name == "DoCalculate")
										{
											value = EAction.DoCalculate;
											return true;
										}
									}
									else if (name == "ReignsChangeBackground")
									{
										value = EAction.ReignsChangeBackground;
										return true;
									}
								}
								else if (num != 477067025U)
								{
									if (num != 488178786U)
									{
										if (num == 496820238U)
										{
											if (name == "RogueActivatePortal")
											{
												value = EAction.RogueActivatePortal;
												return true;
											}
										}
									}
									else if (name == "NpcMoveToPoint")
									{
										value = EAction.NpcMoveToPoint;
										return true;
									}
								}
								else if (name == "ExitOrbitalCamera")
								{
									value = EAction.ExitOrbitalCamera;
									return true;
								}
							}
							else if (num <= 528040495U)
							{
								if (num != 496837051U)
								{
									if (num != 521295586U)
									{
										if (num == 528040495U)
										{
											if (name == "EnableSystem")
											{
												value = EAction.EnableSystem;
												return true;
											}
										}
									}
									else if (name == "CharacterMoveToPoint")
									{
										value = EAction.CharacterMoveToPoint;
										return true;
									}
								}
								else if (name == "PerformerAiSplineMove")
								{
									value = EAction.PerformerAiSplineMove;
									return true;
								}
							}
							else if (num != 540111968U)
							{
								if (num != 546368171U)
								{
									if (num == 552822251U)
									{
										if (name == "SetInteractionLockState")
										{
											value = EAction.SetInteractionLockState;
											return true;
										}
									}
								}
								else if (name == "SwitchDataLayers")
								{
									value = EAction.SwitchDataLayers;
									return true;
								}
							}
							else if (name == "SetPlayerMoveControl")
							{
								value = EAction.SetPlayerMoveControl;
								return true;
							}
						}
						else if (num <= 581010442U)
						{
							if (num <= 563668963U)
							{
								if (num != 557107383U)
								{
									if (num != 562138037U)
									{
										if (num == 563668963U)
										{
											if (name == "ChangeEntityCamp")
											{
												value = EAction.ChangeEntityCamp;
												return true;
											}
										}
									}
									else if (name == "ExecBpActorFunc")
									{
										value = EAction.ExecBpActorFunc;
										return true;
									}
								}
								else if (name == "EnableActor")
								{
									value = EAction.EnableActor;
									return true;
								}
							}
							else if (num != 572681128U)
							{
								if (num != 579006769U)
								{
									if (num == 581010442U)
									{
										if (name == "RollBlockGetReward")
										{
											value = EAction.RollBlockGetReward;
											return true;
										}
									}
								}
								else if (name == "SetElementalBoxToTarget")
								{
									value = EAction.SetElementalBoxToTarget;
									return true;
								}
							}
							else if (name == "CameraLookAt")
							{
								value = EAction.CameraLookAt;
								return true;
							}
						}
						else if (num <= 593774867U)
						{
							if (num != 581883625U)
							{
								if (num != 592965117U)
								{
									if (num == 593774867U)
									{
										if (name == "AddBuffToFollowShooter")
										{
											value = EAction.AddBuffToFollowShooter;
											return true;
										}
									}
								}
								else if (name == "RestorePhantomFormation")
								{
									value = EAction.RestorePhantomFormation;
									return true;
								}
							}
							else if (name == "FocusOnMapMark")
							{
								value = EAction.FocusOnMapMark;
								return true;
							}
						}
						else if (num <= 616548336U)
						{
							if (num != 614558183U)
							{
								if (num == 616548336U)
								{
									if (name == "SetTimeScale")
									{
										value = EAction.SetTimeScale;
										return true;
									}
								}
							}
							else if (name == "SetCameraMode")
							{
								value = EAction.SetCameraMode;
								return true;
							}
						}
						else if (num != 625823495U)
						{
							if (num == 626645766U)
							{
								if (name == "BvbSendSystemEvent")
								{
									value = EAction.BvbSendSystemEvent;
									return true;
								}
							}
						}
						else if (name == "ChangeTeamPosition")
						{
							value = EAction.ChangeTeamPosition;
							return true;
						}
					}
					else if (num <= 778990795U)
					{
						if (num <= 665155329U)
						{
							if (num <= 638325852U)
							{
								if (num != 630176407U)
								{
									if (num != 636718758U)
									{
										if (num == 638325852U)
										{
											if (name == "OverrideAbpAnimScheme")
											{
												value = EAction.OverrideAbpAnimScheme;
												return true;
											}
										}
									}
									else if (name == "Preload")
									{
										value = EAction.Preload;
										return true;
									}
								}
								else if (name == "TraceSpline")
								{
									value = EAction.TraceSpline;
									return true;
								}
							}
							else if (num != 641162771U)
							{
								if (num != 657612618U)
								{
									if (num == 665155329U)
									{
										if (name == "DangoAbyssCreateRewardTreasureBox")
										{
											value = EAction.DangoAbyssCreateRewardTreasureBox;
											return true;
										}
									}
								}
								else if (name == "ChangePhantom")
								{
									value = EAction.ChangePhantom;
									return true;
								}
							}
							else if (name == "SheriffChangeCriminalIdentity")
							{
								value = EAction.SheriffChangeCriminalIdentity;
								return true;
							}
						}
						else if (num <= 719391451U)
						{
							if (num != 670376986U)
							{
								if (num != 694523368U)
								{
									if (num == 719391451U)
									{
										if (name == "PerformerAiMoveTo")
										{
											value = EAction.PerformerAiMoveTo;
											return true;
										}
									}
								}
								else if (name == "StopCameraLookAt")
								{
									value = EAction.StopCameraLookAt;
									return true;
								}
							}
							else if (name == "SetTime")
							{
								value = EAction.SetTime;
								return true;
							}
						}
						else if (num <= 748767383U)
						{
							if (num != 720460859U)
							{
								if (num == 748767383U)
								{
									if (name == "TraceCurrentQuest")
									{
										value = EAction.TraceCurrentQuest;
										return true;
									}
								}
							}
							else if (name == "PlayDynamicSettlement")
							{
								value = EAction.PlayDynamicSettlement;
								return true;
							}
						}
						else if (num != 750678627U)
						{
							if (num == 778990795U)
							{
								if (name == "HonamiStoryReceiveCorruptedChestReward")
								{
									value = EAction.HonamiStoryReceiveCorruptedChestReward;
									return true;
								}
							}
						}
						else if (name == "BvbPlayDialog")
						{
							value = EAction.BvbPlayDialog;
							return true;
						}
					}
					else if (num <= 811162234U)
					{
						if (num <= 806176668U)
						{
							if (num != 787509863U)
							{
								if (num != 803938123U)
								{
									if (num == 806176668U)
									{
										if (name == "ScanEnrichmentArea")
										{
											value = EAction.ScanEnrichmentArea;
											return true;
										}
									}
								}
								else if (name == "ServerSetPlayerPos")
								{
									value = EAction.ServerSetPlayerPos;
									return true;
								}
							}
							else if (name == "ChangeEntityState")
							{
								value = EAction.ChangeEntityState;
								return true;
							}
						}
						else if (num != 806202532U)
						{
							if (num != 808015252U)
							{
								if (num == 811162234U)
								{
									if (name == "CompleteChildQuest")
									{
										value = EAction.CompleteChildQuest;
										return true;
									}
								}
							}
							else if (name == "HideGroup")
							{
								value = EAction.HideGroup;
								return true;
							}
						}
						else if (name == "SlashAndTowerGotoNextFloor")
						{
							value = EAction.SlashAndTowerGotoNextFloor;
							return true;
						}
					}
					else if (num <= 905557690U)
					{
						if (num != 817361934U)
						{
							if (num != 896044502U)
							{
								if (num == 905557690U)
								{
									if (name == "LeisureInteract")
									{
										value = EAction.LeisureInteract;
										return true;
									}
								}
							}
							else if (name == "SimpleMove")
							{
								value = EAction.SimpleMove;
								return true;
							}
						}
						else if (name == "HideSpecificEntities")
						{
							value = EAction.HideSpecificEntities;
							return true;
						}
					}
					else if (num <= 912806078U)
					{
						if (num != 911382396U)
						{
							if (num == 912806078U)
							{
								if (name == "DestroyQuestItem")
								{
									value = EAction.DestroyQuestItem;
									return true;
								}
							}
						}
						else if (name == "PlayEffect2")
						{
							value = EAction.PlayEffect2;
							return true;
						}
					}
					else if (num != 923782487U)
					{
						if (num == 926594151U)
						{
							if (name == "ReignsTriggerGuide")
							{
								value = EAction.ReignsTriggerGuide;
								return true;
							}
						}
					}
					else if (name == "FinishCondition")
					{
						value = EAction.FinishCondition;
						return true;
					}
				}
				else if (num <= 1558151163U)
				{
					if (num <= 1245317943U)
					{
						if (num <= 1060750734U)
						{
							if (num <= 995435581U)
							{
								if (num <= 966114452U)
								{
									if (num != 937653570U)
									{
										if (num != 950193672U)
										{
											if (num == 966114452U)
											{
												if (name == "EntityLookAt")
												{
													value = EAction.EntityLookAt;
													return true;
												}
											}
										}
										else if (name == "ActiveAntiGravitySafePoint")
										{
											value = EAction.ActiveAntiGravitySafePoint;
											return true;
										}
									}
									else if (name == "PlaySequenceData")
									{
										value = EAction.PlaySequenceData;
										return true;
									}
								}
								else if (num != 971936426U)
								{
									if (num != 975055186U)
									{
										if (num == 995435581U)
										{
											if (name == "DestroyQuest")
											{
												value = EAction.DestroyQuest;
												return true;
											}
										}
									}
									else if (name == "ClaimLevelPlayReward")
									{
										value = EAction.ClaimLevelPlayReward;
										return true;
									}
								}
								else if (name == "RecordDungeonEvent")
								{
									value = EAction.RecordDungeonEvent;
									return true;
								}
							}
							else if (num <= 1018175070U)
							{
								if (num != 995934562U)
								{
									if (num != 999227792U)
									{
										if (num == 1018175070U)
										{
											if (name == "SheriffChangeCriminalState")
											{
												value = EAction.SheriffChangeCriminalState;
												return true;
											}
										}
									}
									else if (name == "Activate")
									{
										value = EAction.Activate;
										return true;
									}
								}
								else if (name == "EnableFunction")
								{
									value = EAction.EnableFunction;
									return true;
								}
							}
							else if (num != 1044914394U)
							{
								if (num != 1056744540U)
								{
									if (num == 1060750734U)
									{
										if (name == "RoleTowerGotoNextFloor")
										{
											value = EAction.RoleTowerGotoNextFloor;
											return true;
										}
									}
								}
								else if (name == "ExecBattleAction")
								{
									value = EAction.ExecBattleAction;
									return true;
								}
							}
							else if (name == "RemoveGuestCharacter")
							{
								value = EAction.RemoveGuestCharacter;
								return true;
							}
						}
						else if (num <= 1137524418U)
						{
							if (num <= 1084554529U)
							{
								if (num != 1065887448U)
								{
									if (num != 1071948578U)
									{
										if (num == 1084554529U)
										{
											if (name == "RemoveBuffFromPlayer")
											{
												value = EAction.RemoveBuffFromPlayer;
												return true;
											}
										}
									}
									else if (name == "DisableEntityLookAt")
									{
										value = EAction.DisableEntityLookAt;
										return true;
									}
								}
								else if (name == "SetWuYinQuState")
								{
									value = EAction.SetWuYinQuState;
									return true;
								}
							}
							else if (num != 1127961565U)
							{
								if (num != 1135890389U)
								{
									if (num == 1137524418U)
									{
										if (name == "ClearPlayBubble")
										{
											value = EAction.ClearPlayBubble;
											return true;
										}
									}
								}
								else if (name == "RogueReceiveReward")
								{
									value = EAction.RogueReceiveReward;
									return true;
								}
							}
							else if (name == "RestoreAiBehaviorTree")
							{
								value = EAction.RestoreAiBehaviorTree;
								return true;
							}
						}
						else if (num <= 1171735492U)
						{
							if (num != 1149397343U)
							{
								if (num != 1157991935U)
								{
									if (num == 1171735492U)
									{
										if (name == "SetDataLayerTransitions")
										{
											value = EAction.SetDataLayerTransitions;
											return true;
										}
									}
								}
								else if (name == "SetEntityClientVisible")
								{
									value = EAction.SetEntityClientVisible;
									return true;
								}
							}
							else if (name == "RoverRogueCreateRoomReward")
							{
								value = EAction.RoverRogueCreateRoomReward;
								return true;
							}
						}
						else if (num <= 1194153127U)
						{
							if (num != 1190281430U)
							{
								if (num == 1194153127U)
								{
									if (name == "TeleportToLatestResetPoint")
									{
										value = EAction.TeleportToLatestResetPoint;
										return true;
									}
								}
							}
							else if (name == "SetHeadIconVisible")
							{
								value = EAction.SetHeadIconVisible;
								return true;
							}
						}
						else if (num != 1227316783U)
						{
							if (num == 1245317943U)
							{
								if (name == "AddTrialCharacter")
								{
									value = EAction.AddTrialCharacter;
									return true;
								}
							}
						}
						else if (name == "SetNumberVar")
						{
							value = EAction.SetNumberVar;
							return true;
						}
					}
					else if (num <= 1362942746U)
					{
						if (num <= 1310578199U)
						{
							if (num <= 1265563172U)
							{
								if (num != 1249931647U)
								{
									if (num != 1255013970U)
									{
										if (num == 1265563172U)
										{
											if (name == "FadeInScreen")
											{
												value = EAction.FadeInScreen;
												return true;
											}
										}
									}
									else if (name == "ShowTargetRange")
									{
										value = EAction.ShowTargetRange;
										return true;
									}
								}
								else if (name == "ChangeRandomState")
								{
									value = EAction.ChangeRandomState;
									return true;
								}
							}
							else if (num != 1294946218U)
							{
								if (num != 1299621093U)
								{
									if (num == 1310578199U)
									{
										if (name == "FinishState")
										{
											value = EAction.FinishState;
											return true;
										}
									}
								}
								else if (name == "Destroy")
								{
									value = EAction.Destroy;
									return true;
								}
							}
							else if (name == "SlideRailStart")
							{
								value = EAction.SlideRailStart;
								return true;
							}
						}
						else if (num <= 1321155294U)
						{
							if (num != 1318392726U)
							{
								if (num != 1319033021U)
								{
									if (num == 1321155294U)
									{
										if (name == "ClientFollowShooterLeisureInteract")
										{
											value = EAction.ClientFollowShooterLeisureInteract;
											return true;
										}
									}
								}
								else if (name == "FixFoundationRelation")
								{
									value = EAction.FixFoundationRelation;
									return true;
								}
							}
							else if (name == "SeqEventAddTagToSelf")
							{
								value = EAction.SeqEventAddTagToSelf;
								return true;
							}
						}
						else if (num != 1330736562U)
						{
							if (num != 1354359410U)
							{
								if (num == 1362942746U)
								{
									if (name == "TetrisTriggerDelayFall")
									{
										value = EAction.TetrisTriggerDelayFall;
										return true;
									}
								}
							}
							else if (name == "PlayerMoveToPoint")
							{
								value = EAction.PlayerMoveToPoint;
								return true;
							}
						}
						else if (name == "ChangeNpcAbpState")
						{
							value = EAction.ChangeNpcAbpState;
							return true;
						}
					}
					else if (num <= 1458566294U)
					{
						if (num <= 1384486459U)
						{
							if (num != 1376721271U)
							{
								if (num != 1377183171U)
								{
									if (num == 1384486459U)
									{
										if (name == "ShowAllHidedGroupInFlow")
										{
											value = EAction.ShowAllHidedGroupInFlow;
											return true;
										}
									}
								}
								else if (name == "SetExploreState")
								{
									value = EAction.SetExploreState;
									return true;
								}
							}
							else if (name == "DestroySelf")
							{
								value = EAction.DestroySelf;
								return true;
							}
						}
						else if (num != 1410883977U)
						{
							if (num != 1423243649U)
							{
								if (num == 1458566294U)
								{
									if (name == "MotorSoarInWindField")
									{
										value = EAction.MotorSoarInWindField;
										return true;
									}
								}
							}
							else if (name == "AvgFocusRole")
							{
								value = EAction.AvgFocusRole;
								return true;
							}
						}
						else if (name == "RotatorEntity")
						{
							value = EAction.RotatorEntity;
							return true;
						}
					}
					else if (num <= 1487204504U)
					{
						if (num != 1486090641U)
						{
							if (num != 1486267177U)
							{
								if (num == 1487204504U)
								{
									if (name == "SetAudioEnable")
									{
										value = EAction.SetAudioEnable;
										return true;
									}
								}
							}
							else if (name == "FlowDefineNpcGroupPerform")
							{
								value = EAction.FlowDefineNpcGroupPerform;
								return true;
							}
						}
						else if (name == "DangoAbyssActivatePortal")
						{
							value = EAction.DangoAbyssActivatePortal;
							return true;
						}
					}
					else if (num <= 1527033163U)
					{
						if (num != 1498111488U)
						{
							if (num == 1527033163U)
							{
								if (name == "SheriffUnlockProgress")
								{
									value = EAction.SheriffUnlockProgress;
									return true;
								}
							}
						}
						else if (name == "DangoAbyssReceiveReward")
						{
							value = EAction.DangoAbyssReceiveReward;
							return true;
						}
					}
					else if (num != 1531121395U)
					{
						if (num == 1558151163U)
						{
							if (name == "TrapDefensePlayerOperationConstraint")
							{
								value = EAction.TrapDefensePlayerOperationConstraint;
								return true;
							}
						}
					}
					else if (name == "EnableHostility")
					{
						value = EAction.EnableHostility;
						return true;
					}
				}
				else if (num <= 1790748551U)
				{
					if (num <= 1674924584U)
					{
						if (num <= 1612682396U)
						{
							if (num <= 1578757803U)
							{
								if (num != 1566200485U)
								{
									if (num != 1578730927U)
									{
										if (num == 1578757803U)
										{
											if (name == "DestroyFishingBoat")
											{
												value = EAction.DestroyFishingBoat;
												return true;
											}
										}
									}
									else if (name == "ClientSetPlayerPos")
									{
										value = EAction.ClientSetPlayerPos;
										return true;
									}
								}
								else if (name == "PerformSunSpiritGearRoundTrip")
								{
									value = EAction.PerformSunSpiritGearRoundTrip;
									return true;
								}
							}
							else if (num != 1586638671U)
							{
								if (num != 1611758780U)
								{
									if (num == 1612682396U)
									{
										if (name == "SetSpineAnimation")
										{
											value = EAction.SetSpineAnimation;
											return true;
										}
									}
								}
								else if (name == "RecoverDurability")
								{
									value = EAction.RecoverDurability;
									return true;
								}
							}
							else if (name == "RogueGotoNextFloor")
							{
								value = EAction.RogueGotoNextFloor;
								return true;
							}
						}
						else if (num <= 1634348624U)
						{
							if (num != 1622590617U)
							{
								if (num != 1627185505U)
								{
									if (num == 1634348624U)
									{
										if (name == "EnterMovieMode")
										{
											value = EAction.EnterMovieMode;
											return true;
										}
									}
								}
								else if (name == "AddBuffToPlayer")
								{
									value = EAction.AddBuffToPlayer;
									return true;
								}
							}
							else if (name == "ChangeInteractOptionText")
							{
								value = EAction.ChangeInteractOptionText;
								return true;
							}
						}
						else if (num != 1638996739U)
						{
							if (num != 1654342680U)
							{
								if (num == 1674924584U)
								{
									if (name == "VehicleTeleport")
									{
										value = EAction.VehicleTeleport;
										return true;
									}
								}
							}
							else if (name == "ResetLevelPlay")
							{
								value = EAction.ResetLevelPlay;
								return true;
							}
						}
						else if (name == "SpawnEntity")
						{
							value = EAction.SpawnEntity;
							return true;
						}
					}
					else if (num <= 1751214299U)
					{
						if (num <= 1709720177U)
						{
							if (num != 1694670892U)
							{
								if (num != 1708422118U)
								{
									if (num == 1709720177U)
									{
										if (name == "SendSceneActorsEvent")
										{
											value = EAction.SendSceneActorsEvent;
											return true;
										}
									}
								}
								else if (name == "RestorePhantom")
								{
									value = EAction.RestorePhantom;
									return true;
								}
							}
							else if (name == "BeginFlowTemplate")
							{
								value = EAction.BeginFlowTemplate;
								return true;
							}
						}
						else if (num != 1715832146U)
						{
							if (num != 1731746019U)
							{
								if (num == 1751214299U)
								{
									if (name == "ExecClientBattleAction")
									{
										value = EAction.ExecClientBattleAction;
										return true;
									}
								}
							}
							else if (name == "Undefined")
							{
								value = EAction.Undefined;
								return true;
							}
						}
						else if (name == "CompleteGuide")
						{
							value = EAction.CompleteGuide;
							return true;
						}
					}
					else if (num <= 1770589238U)
					{
						if (num != 1757804247U)
						{
							if (num != 1770271980U)
							{
								if (num == 1770589238U)
								{
									if (name == "EnableLevelPlay")
									{
										value = EAction.EnableLevelPlay;
										return true;
									}
								}
							}
							else if (name == "VehicleWaterfallClimbing")
							{
								value = EAction.VehicleWaterfallClimbing;
								return true;
							}
						}
						else if (name == "AddTrialFollowShooter")
						{
							value = EAction.AddTrialFollowShooter;
							return true;
						}
					}
					else if (num <= 1784876271U)
					{
						if (num != 1780123448U)
						{
							if (num == 1784876271U)
							{
								if (name == "WaitBattleCondition")
								{
									value = EAction.WaitBattleCondition;
									return true;
								}
							}
						}
						else if (name == "EndFlowTemplate")
						{
							value = EAction.EndFlowTemplate;
							return true;
						}
					}
					else if (num != 1789777407U)
					{
						if (num == 1790748551U)
						{
							if (name == "ActivateResetPoint")
							{
								value = EAction.ActivateResetPoint;
								return true;
							}
						}
					}
					else if (name == "SlideRailEnd")
					{
						value = EAction.SlideRailEnd;
						return true;
					}
				}
				else if (num <= 1982999440U)
				{
					if (num <= 1880295570U)
					{
						if (num <= 1814328475U)
						{
							if (num != 1797781587U)
							{
								if (num != 1808748440U)
								{
									if (num == 1814328475U)
									{
										if (name == "RequestSystemFunction")
										{
											value = EAction.RequestSystemFunction;
											return true;
										}
									}
								}
								else if (name == "SettlementDungeon")
								{
									value = EAction.SettlementDungeon;
									return true;
								}
							}
							else if (name == "AddGuestCharacter")
							{
								value = EAction.AddGuestCharacter;
								return true;
							}
						}
						else if (num != 1841093436U)
						{
							if (num != 1850727938U)
							{
								if (num == 1880295570U)
								{
									if (name == "DestroyAllChild")
									{
										value = EAction.DestroyAllChild;
										return true;
									}
								}
							}
							else if (name == "RemoveFlowInteractOption")
							{
								value = EAction.RemoveFlowInteractOption;
								return true;
							}
						}
						else if (name == "EndCommonTip")
						{
							value = EAction.EndCommonTip;
							return true;
						}
					}
					else if (num <= 1954944637U)
					{
						if (num != 1890840053U)
						{
							if (num != 1949067738U)
							{
								if (num == 1954944637U)
								{
									if (name == "AvgShakeUi")
									{
										value = EAction.AvgShakeUi;
										return true;
									}
								}
							}
							else if (name == "UsePhantomSkill")
							{
								value = EAction.UsePhantomSkill;
								return true;
							}
						}
						else if (name == "GuideTrigger")
						{
							value = EAction.GuideTrigger;
							return true;
						}
					}
					else if (num <= 1962318722U)
					{
						if (num != 1959754401U)
						{
							if (num == 1962318722U)
							{
								if (name == "TriggerSystemRandomPlot")
								{
									value = EAction.TriggerSystemRandomPlot;
									return true;
								}
							}
						}
						else if (name == "ResetPlayerPosWithPresentation")
						{
							value = EAction.ResetPlayerPosWithPresentation;
							return true;
						}
					}
					else if (num != 1978792736U)
					{
						if (num == 1982999440U)
						{
							if (name == "GetItem")
							{
								value = EAction.GetItem;
								return true;
							}
						}
					}
					else if (name == "SetWayOccupancyState")
					{
						value = EAction.SetWayOccupancyState;
						return true;
					}
				}
				else if (num <= 2035606522U)
				{
					if (num <= 2018018397U)
					{
						if (num != 2007859523U)
						{
							if (num != 2015593190U)
							{
								if (num == 2018018397U)
								{
									if (name == "DollGrabItemDelivery")
									{
										value = EAction.DollGrabItemDelivery;
										return true;
									}
								}
							}
							else if (name == "SetEntityPos")
							{
								value = EAction.SetEntityPos;
								return true;
							}
						}
						else if (name == "TriggerSpecificScanEffect")
						{
							value = EAction.TriggerSpecificScanEffect;
							return true;
						}
					}
					else if (num != 2029983312U)
					{
						if (num != 2030919416U)
						{
							if (num == 2035606522U)
							{
								if (name == "ClientSetPlayerOperationRestriction")
								{
									value = EAction.ClientSetPlayerOperationRestriction;
									return true;
								}
							}
						}
						else if (name == "OpenQuickHackSystem")
						{
							value = EAction.OpenQuickHackSystem;
							return true;
						}
					}
					else if (name == "InterludeActions")
					{
						value = EAction.InterludeActions;
						return true;
					}
				}
				else if (num <= 2071689728U)
				{
					if (num != 2050816061U)
					{
						if (num != 2066132067U)
						{
							if (num == 2071689728U)
							{
								if (name == "FinishDungeon")
								{
									value = EAction.FinishDungeon;
									return true;
								}
							}
						}
						else if (name == "SheriffUnlockEnding")
						{
							value = EAction.SheriffUnlockEnding;
							return true;
						}
					}
					else if (name == "CloseFlowTemplate")
					{
						value = EAction.CloseFlowTemplate;
						return true;
					}
				}
				else if (num <= 2108270406U)
				{
					if (num != 2094544238U)
					{
						if (num == 2108270406U)
						{
							if (name == "CharacterLookAt")
							{
								value = EAction.CharacterLookAt;
								return true;
							}
						}
					}
					else if (name == "HideByRangeInFlow")
					{
						value = EAction.HideByRangeInFlow;
						return true;
					}
				}
				else if (num != 2114198897U)
				{
					if (num == 2134091447U)
					{
						if (name == "HonamiStoryGetItem")
						{
							value = EAction.HonamiStoryGetItem;
							return true;
						}
					}
				}
				else if (name == "NpcLeisureInteract")
				{
					value = EAction.NpcLeisureInteract;
					return true;
				}
			}
			else if (num <= 3327054839U)
			{
				if (num <= 2715646961U)
				{
					if (num <= 2330377671U)
					{
						if (num <= 2224418774U)
						{
							if (num <= 2174274579U)
							{
								if (num <= 2152026077U)
								{
									if (num != 2135923639U)
									{
										if (num != 2143987045U)
										{
											if (num == 2152026077U)
											{
												if (name == "SlidePerformStart")
												{
													value = EAction.SlidePerformStart;
													return true;
												}
											}
										}
										else if (name == "EnableTakePhotoClip")
										{
											value = EAction.EnableTakePhotoClip;
											return true;
										}
									}
									else if (name == "JumpTalk")
									{
										value = EAction.JumpTalk;
										return true;
									}
								}
								else if (num != 2153363071U)
								{
									if (num != 2155720729U)
									{
										if (num == 2174274579U)
										{
											if (name == "SetAreaState")
											{
												value = EAction.SetAreaState;
												return true;
											}
										}
									}
									else if (name == "SetActorVar")
									{
										value = EAction.SetActorVar;
										return true;
									}
								}
								else if (name == "PlayFlow")
								{
									value = EAction.PlayFlow;
									return true;
								}
							}
							else if (num <= 2198839411U)
							{
								if (num != 2187993097U)
								{
									if (num != 2197676485U)
									{
										if (num == 2198839411U)
										{
											if (name == "SetMotorSpeed")
											{
												value = EAction.SetMotorSpeed;
												return true;
											}
										}
									}
									else if (name == "ExecRiskHarvestEffect")
									{
										value = EAction.ExecRiskHarvestEffect;
										return true;
									}
								}
								else if (name == "SummonEntity")
								{
									value = EAction.SummonEntity;
									return true;
								}
							}
							else if (num != 2212120706U)
							{
								if (num != 2212951527U)
								{
									if (num == 2224418774U)
									{
										if (name == "RemovePreloadResource")
										{
											value = EAction.RemovePreloadResource;
											return true;
										}
									}
								}
								else if (name == "AddFlowInteractOption")
								{
									value = EAction.AddFlowInteractOption;
									return true;
								}
							}
							else if (name == "AccpetCurrentQuest")
							{
								value = EAction.AccpetCurrentQuest;
								return true;
							}
						}
						else if (num <= 2267712036U)
						{
							if (num <= 2248410712U)
							{
								if (num != 2232943762U)
								{
									if (num != 2246169256U)
									{
										if (num == 2248410712U)
										{
											if (name == "CustomJson")
											{
												value = EAction.CustomJson;
												return true;
											}
										}
									}
									else if (name == "AdjustPlayerCamera")
									{
										value = EAction.AdjustPlayerCamera;
										return true;
									}
								}
								else if (name == "AvgMoveRole")
								{
									value = EAction.AvgMoveRole;
									return true;
								}
							}
							else if (num != 2258951819U)
							{
								if (num != 2260470078U)
								{
									if (num == 2267712036U)
									{
										if (name == "SyncVarToActorState")
										{
											value = EAction.SyncVarToActorState;
											return true;
										}
									}
								}
								else if (name == "ChangeOtherState")
								{
									value = EAction.ChangeOtherState;
									return true;
								}
							}
							else if (name == "ShowHidedGroup")
							{
								value = EAction.ShowHidedGroup;
								return true;
							}
						}
						else if (num <= 2320243247U)
						{
							if (num != 2316127520U)
							{
								if (num != 2318633348U)
								{
									if (num == 2320243247U)
									{
										if (name == "ClientUnlockAchievementSystemItem")
										{
											value = EAction.ClientUnlockAchievementSystemItem;
											return true;
										}
									}
								}
								else if (name == "FireBulletEffect")
								{
									value = EAction.FireBulletEffect;
									return true;
								}
							}
							else if (name == "ToggleScanSplineEffect")
							{
								value = EAction.ToggleScanSplineEffect;
								return true;
							}
						}
						else if (num <= 2326540071U)
						{
							if (num != 2323761386U)
							{
								if (num == 2326540071U)
								{
									if (name == "GetRewardByInteract")
									{
										value = EAction.GetRewardByInteract;
										return true;
									}
								}
							}
							else if (name == "VehicleEnterNpc")
							{
								value = EAction.VehicleEnterNpc;
								return true;
							}
						}
						else if (num != 2328992418U)
						{
							if (num == 2330377671U)
							{
								if (name == "AwakeEntity")
								{
									value = EAction.AwakeEntity;
									return true;
								}
							}
						}
						else if (name == "ReportTrackingEvent")
						{
							value = EAction.ReportTrackingEvent;
							return true;
						}
					}
					else if (num <= 2445092153U)
					{
						if (num <= 2381593610U)
						{
							if (num <= 2373038302U)
							{
								if (num != 2349217778U)
								{
									if (num != 2352449708U)
									{
										if (num == 2373038302U)
										{
											if (name == "ChangeState")
											{
												value = EAction.ChangeState;
												return true;
											}
										}
									}
									else if (name == "RemoveNpcGroupPerform")
									{
										value = EAction.RemoveNpcGroupPerform;
										return true;
									}
								}
								else if (name == "ServerForceEnableLevelPlay")
								{
									value = EAction.ServerForceEnableLevelPlay;
									return true;
								}
							}
							else if (num != 2373372887U)
							{
								if (num != 2374337302U)
								{
									if (num == 2381593610U)
									{
										if (name == "SetEntityClientVisibleSave")
										{
											value = EAction.SetEntityClientVisibleSave;
											return true;
										}
									}
								}
								else if (name == "SetReviveRegion")
								{
									value = EAction.SetReviveRegion;
									return true;
								}
							}
							else if (name == "BvbSendAiEvent")
							{
								value = EAction.BvbSendAiEvent;
								return true;
							}
						}
						else if (num <= 2400896417U)
						{
							if (num != 2382187439U)
							{
								if (num != 2387942897U)
								{
									if (num == 2400896417U)
									{
										if (name == "StopSceneItemMove")
										{
											value = EAction.StopSceneItemMove;
											return true;
										}
									}
								}
								else if (name == "EnableClientFunction")
								{
									value = EAction.EnableClientFunction;
									return true;
								}
							}
							else if (name == "WaitUntilLevelSequenceReachMark")
							{
								value = EAction.WaitUntilLevelSequenceReachMark;
								return true;
							}
						}
						else if (num != 2438087062U)
						{
							if (num != 2444391545U)
							{
								if (num == 2445092153U)
								{
									if (name == "TrapDefenseChangeMiniMap")
									{
										value = EAction.TrapDefenseChangeMiniMap;
										return true;
									}
								}
							}
							else if (name == "RemoveBuffToTriggeredEntity")
							{
								value = EAction.RemoveBuffToTriggeredEntity;
								return true;
							}
						}
						else if (name == "UnlockTeleportTrigger")
						{
							value = EAction.UnlockTeleportTrigger;
							return true;
						}
					}
					else if (num <= 2568443947U)
					{
						if (num <= 2470629275U)
						{
							if (num != 2449275519U)
							{
								if (num != 2457348077U)
								{
									if (num == 2470629275U)
									{
										if (name == "EnableEntityLookAt")
										{
											value = EAction.EnableEntityLookAt;
											return true;
										}
									}
								}
								else if (name == "SetJigsawFoundation")
								{
									value = EAction.SetJigsawFoundation;
									return true;
								}
							}
							else if (name == "TakePlotPhoto")
							{
								value = EAction.TakePlotPhoto;
								return true;
							}
						}
						else if (num != 2520896635U)
						{
							if (num != 2536991015U)
							{
								if (num == 2568443947U)
								{
									if (name == "ExecResurrection")
									{
										value = EAction.ExecResurrection;
										return true;
									}
								}
							}
							else if (name == "CloseWalkingOverlayMontage")
							{
								value = EAction.CloseWalkingOverlayMontage;
								return true;
							}
						}
						else if (name == "VehicleEnter")
						{
							value = EAction.VehicleEnter;
							return true;
						}
					}
					else if (num <= 2667639771U)
					{
						if (num != 2577916440U)
						{
							if (num != 2592962310U)
							{
								if (num == 2667639771U)
								{
									if (name == "CaptureElementalBox")
									{
										value = EAction.CaptureElementalBox;
										return true;
									}
								}
							}
							else if (name == "TeleportDungeonPos")
							{
								value = EAction.TeleportDungeonPos;
								return true;
							}
						}
						else if (name == "DrinksRollRoleRequirement")
						{
							value = EAction.DrinksRollRoleRequirement;
							return true;
						}
					}
					else if (num <= 2707415479U)
					{
						if (num != 2690828473U)
						{
							if (num == 2707415479U)
							{
								if (name == "AddBuffToEntity")
								{
									value = EAction.AddBuffToEntity;
									return true;
								}
							}
						}
						else if (name == "ToggleMapMarkState")
						{
							value = EAction.ToggleMapMarkState;
							return true;
						}
					}
					else if (num != 2715189307U)
					{
						if (num == 2715646961U)
						{
							if (name == "Log")
							{
								value = EAction.Log;
								return true;
							}
						}
					}
					else if (name == "VehicleMoveWithPathLine")
					{
						value = EAction.VehicleMoveWithPathLine;
						return true;
					}
				}
				else if (num <= 3009412261U)
				{
					if (num <= 2852212440U)
					{
						if (num <= 2815753282U)
						{
							if (num <= 2746321178U)
							{
								if (num != 2732640163U)
								{
									if (num != 2737113081U)
									{
										if (num == 2746321178U)
										{
											if (name == "DriveMotorInSpecConfig")
											{
												value = EAction.DriveMotorInSpecConfig;
												return true;
											}
										}
									}
									else if (name == "PlayerLookTowards")
									{
										value = EAction.PlayerLookTowards;
										return true;
									}
								}
								else if (name == "GiantToggleModel")
								{
									value = EAction.GiantToggleModel;
									return true;
								}
							}
							else if (num != 2768556192U)
							{
								if (num != 2778094472U)
								{
									if (num == 2815753282U)
									{
										if (name == "ReignsSetPropertyVisible")
										{
											value = EAction.ReignsSetPropertyVisible;
											return true;
										}
									}
								}
								else if (name == "SetPlayerPos")
								{
									value = EAction.SetPlayerPos;
									return true;
								}
							}
							else if (name == "ExitMovieCamera")
							{
								value = EAction.ExitMovieCamera;
								return true;
							}
						}
						else if (num <= 2830865376U)
						{
							if (num != 2822551120U)
							{
								if (num != 2823922039U)
								{
									if (num == 2830865376U)
									{
										if (name == "DestroySummonedEntities")
										{
											value = EAction.DestroySummonedEntities;
											return true;
										}
									}
								}
								else if (name == "ShowSpecificEntities")
								{
									value = EAction.ShowSpecificEntities;
									return true;
								}
							}
							else if (name == "PhoneSystemInteract")
							{
								value = EAction.PhoneSystemInteract;
								return true;
							}
						}
						else if (num != 2841354295U)
						{
							if (num != 2844058088U)
							{
								if (num == 2852212440U)
								{
									if (name == "PlayRegisteredMontage")
									{
										value = EAction.PlayRegisteredMontage;
										return true;
									}
								}
							}
							else if (name == "SeqEventFireBullet")
							{
								value = EAction.SeqEventFireBullet;
								return true;
							}
						}
						else if (name == "GuestOperateUiAnimation")
						{
							value = EAction.GuestOperateUiAnimation;
							return true;
						}
					}
					else if (num <= 2934721385U)
					{
						if (num <= 2880149982U)
						{
							if (num != 2861543789U)
							{
								if (num != 2869198533U)
								{
									if (num == 2880149982U)
									{
										if (name == "SwitchSubLevels")
										{
											value = EAction.SwitchSubLevels;
											return true;
										}
									}
								}
								else if (name == "SetWeather")
								{
									value = EAction.SetWeather;
									return true;
								}
							}
							else if (name == "FinishDoInteract")
							{
								value = EAction.FinishDoInteract;
								return true;
							}
						}
						else if (num != 2900982667U)
						{
							if (num != 2904291958U)
							{
								if (num == 2934721385U)
								{
									if (name == "EnterOrbitalCamera")
									{
										value = EAction.EnterOrbitalCamera;
										return true;
									}
								}
							}
							else if (name == "ChangeNpcPerformState")
							{
								value = EAction.ChangeNpcPerformState;
								return true;
							}
						}
						else if (name == "SetPlayerOperationRestriction")
						{
							value = EAction.SetPlayerOperationRestriction;
							return true;
						}
					}
					else if (num <= 2981265070U)
					{
						if (num != 2959652001U)
						{
							if (num != 2967668457U)
							{
								if (num == 2981265070U)
								{
									if (name == "VehicleExitNpc")
									{
										value = EAction.VehicleExitNpc;
										return true;
									}
								}
							}
							else if (name == "CommonTip2")
							{
								value = EAction.CommonTip2;
								return true;
							}
						}
						else if (name == "BossPilingRandomBuff")
						{
							value = EAction.BossPilingRandomBuff;
							return true;
						}
					}
					else if (num <= 2982955510U)
					{
						if (num != 2981943712U)
						{
							if (num == 2982955510U)
							{
								if (name == "AdjustPlayerCameraGravity")
								{
									value = EAction.AdjustPlayerCameraGravity;
									return true;
								}
							}
						}
						else if (name == "SetAudioState")
						{
							value = EAction.SetAudioState;
							return true;
						}
					}
					else if (num != 2988799482U)
					{
						if (num == 3009412261U)
						{
							if (name == "ManualOccupations")
							{
								value = EAction.ManualOccupations;
								return true;
							}
						}
					}
					else if (name == "RogueSelectRoom")
					{
						value = EAction.RogueSelectRoom;
						return true;
					}
				}
				else if (num <= 3204616500U)
				{
					if (num <= 3082839618U)
					{
						if (num <= 3031392035U)
						{
							if (num != 3019068301U)
							{
								if (num != 3030685129U)
								{
									if (num == 3031392035U)
									{
										if (name == "ToggleEntityElementalAbility")
										{
											value = EAction.ToggleEntityElementalAbility;
											return true;
										}
									}
								}
								else if (name == "StopNewMoveWithSpline")
								{
									value = EAction.StopNewMoveWithSpline;
									return true;
								}
							}
							else if (name == "SendNpcMail")
							{
								value = EAction.SendNpcMail;
								return true;
							}
						}
						else if (num != 3048196267U)
						{
							if (num != 3069360931U)
							{
								if (num == 3082839618U)
								{
									if (name == "StopUiScreenEffect")
									{
										value = EAction.StopUiScreenEffect;
										return true;
									}
								}
							}
							else if (name == "HonamiStorySetFormation")
							{
								value = EAction.HonamiStorySetFormation;
								return true;
							}
						}
						else if (name == "SetBlendAnim")
						{
							value = EAction.SetBlendAnim;
							return true;
						}
					}
					else if (num <= 3169022647U)
					{
						if (num != 3126661164U)
						{
							if (num != 3129613678U)
							{
								if (num == 3169022647U)
								{
									if (name == "ChangeActorState")
									{
										value = EAction.ChangeActorState;
										return true;
									}
								}
							}
							else if (name == "RemoveTrialFollowShooter")
							{
								value = EAction.RemoveTrialFollowShooter;
								return true;
							}
						}
						else if (name == "ModifyActorMedia")
						{
							value = EAction.ModifyActorMedia;
							return true;
						}
					}
					else if (num <= 3179814327U)
					{
						if (num != 3169957883U)
						{
							if (num == 3179814327U)
							{
								if (name == "AvgPlayRoleAction")
								{
									value = EAction.AvgPlayRoleAction;
									return true;
								}
							}
						}
						else if (name == "ResetEntity")
						{
							value = EAction.ResetEntity;
							return true;
						}
					}
					else if (num != 3192190318U)
					{
						if (num == 3204616500U)
						{
							if (name == "SetSubScreenMode")
							{
								value = EAction.SetSubScreenMode;
								return true;
							}
						}
					}
					else if (name == "TeleportToAndEnterVehicle")
					{
						value = EAction.TeleportToAndEnterVehicle;
						return true;
					}
				}
				else if (num <= 3278064627U)
				{
					if (num <= 3246695545U)
					{
						if (num != 3205021753U)
						{
							if (num != 3212573930U)
							{
								if (num == 3246695545U)
								{
									if (name == "ReignsChangePlayerName")
									{
										value = EAction.ReignsChangePlayerName;
										return true;
									}
								}
							}
							else if (name == "ChangeTimer")
							{
								value = EAction.ChangeTimer;
								return true;
							}
						}
						else if (name == "GiantTriggerResponse")
						{
							value = EAction.GiantTriggerResponse;
							return true;
						}
					}
					else if (num != 3249911065U)
					{
						if (num != 3256547682U)
						{
							if (num == 3278064627U)
							{
								if (name == "SpecialOpModifyActorMaterialParamBySplineProgress")
								{
									value = EAction.SpecialOpModifyActorMaterialParamBySplineProgress;
									return true;
								}
							}
						}
						else if (name == "ResetPlayerCameraFocus")
						{
							value = EAction.ResetPlayerCameraFocus;
							return true;
						}
					}
					else if (name == "SetRegionConfig")
					{
						value = EAction.SetRegionConfig;
						return true;
					}
				}
				else if (num <= 3289892727U)
				{
					if (num != 3284905592U)
					{
						if (num != 3286563727U)
						{
							if (num == 3289892727U)
							{
								if (name == "RemoveBuffFromEntity")
								{
									value = EAction.RemoveBuffFromEntity;
									return true;
								}
							}
						}
						else if (name == "RandomVar")
						{
							value = EAction.RandomVar;
							return true;
						}
					}
					else if (name == "AddPlayBubble")
					{
						value = EAction.AddPlayBubble;
						return true;
					}
				}
				else if (num <= 3301731264U)
				{
					if (num != 3292704244U)
					{
						if (num == 3301731264U)
						{
							if (name == "ChangeBehaviorState")
							{
								value = EAction.ChangeBehaviorState;
								return true;
							}
						}
					}
					else if (name == "CalculateVar")
					{
						value = EAction.CalculateVar;
						return true;
					}
				}
				else if (num != 3318518093U)
				{
					if (num == 3327054839U)
					{
						if (name == "BvbSkipChallenge")
						{
							value = EAction.BvbSkipChallenge;
							return true;
						}
					}
				}
				else if (name == "UnLimitPlayerOperation")
				{
					value = EAction.UnLimitPlayerOperation;
					return true;
				}
			}
			else if (num <= 3831918259U)
			{
				if (num <= 3593847481U)
				{
					if (num <= 3467388784U)
					{
						if (num <= 3394738369U)
						{
							if (num <= 3362604838U)
							{
								if (num != 3331441882U)
								{
									if (num != 3347600789U)
									{
										if (num == 3362604838U)
										{
											if (name == "OpenSystemBoardWithReturn")
											{
												value = EAction.OpenSystemBoardWithReturn;
												return true;
											}
										}
									}
									else if (name == "MowingTowerGotoNextFloor")
									{
										value = EAction.MowingTowerGotoNextFloor;
										return true;
									}
								}
								else if (name == "DestroyEntity")
								{
									value = EAction.DestroyEntity;
									return true;
								}
							}
							else if (num != 3367456968U)
							{
								if (num != 3390755569U)
								{
									if (num == 3394738369U)
									{
										if (name == "LockEntity")
										{
											value = EAction.LockEntity;
											return true;
										}
									}
								}
								else if (name == "ExecAlertSystemAction")
								{
									value = EAction.ExecAlertSystemAction;
									return true;
								}
							}
							else if (name == "OpenSystemBoard")
							{
								value = EAction.OpenSystemBoard;
								return true;
							}
						}
						else if (num <= 3432617768U)
						{
							if (num != 3407511829U)
							{
								if (num != 3417157860U)
								{
									if (num == 3432617768U)
									{
										if (name == "SetVar")
										{
											value = EAction.SetVar;
											return true;
										}
									}
								}
								else if (name == "EnableAoiNotify")
								{
									value = EAction.EnableAoiNotify;
									return true;
								}
							}
							else if (name == "MoveWithSpline")
							{
								value = EAction.MoveWithSpline;
								return true;
							}
						}
						else if (num != 3438999407U)
						{
							if (num != 3446830477U)
							{
								if (num == 3467388784U)
								{
									if (name == "OpenSystemFunction")
									{
										value = EAction.OpenSystemFunction;
										return true;
									}
								}
							}
							else if (name == "ExitDungeon")
							{
								value = EAction.ExitDungeon;
								return true;
							}
						}
						else if (name == "SetTargetElementalAbility")
						{
							value = EAction.SetTargetElementalAbility;
							return true;
						}
					}
					else if (num <= 3533879663U)
					{
						if (num <= 3488734135U)
						{
							if (num != 3485200219U)
							{
								if (num != 3486427174U)
								{
									if (num == 3488734135U)
									{
										if (name == "UpdateTrialCharacter")
										{
											value = EAction.UpdateTrialCharacter;
											return true;
										}
									}
								}
								else if (name == "PlayEffect")
								{
									value = EAction.PlayEffect;
									return true;
								}
							}
							else if (name == "Prompt")
							{
								value = EAction.Prompt;
								return true;
							}
						}
						else if (num != 3495172681U)
						{
							if (num != 3512932389U)
							{
								if (num == 3533879663U)
								{
									if (name == "StartMotorCruise")
									{
										value = EAction.StartMotorCruise;
										return true;
									}
								}
							}
							else if (name == "EnableFollowShooterAbility")
							{
								value = EAction.EnableFollowShooterAbility;
								return true;
							}
						}
						else if (name == "OverrideAiBehaviorTree")
						{
							value = EAction.OverrideAiBehaviorTree;
							return true;
						}
					}
					else if (num <= 3566577693U)
					{
						if (num != 3538192079U)
						{
							if (num != 3541406324U)
							{
								if (num == 3566577693U)
								{
									if (name == "ChangeLiftTarget")
									{
										value = EAction.ChangeLiftTarget;
										return true;
									}
								}
							}
							else if (name == "ItemFoundationMatch")
							{
								value = EAction.ItemFoundationMatch;
								return true;
							}
						}
						else if (name == "SetPlotMode")
						{
							value = EAction.SetPlotMode;
							return true;
						}
					}
					else if (num <= 3586111684U)
					{
						if (num != 3572941018U)
						{
							if (num == 3586111684U)
							{
								if (name == "ClientSetSeasonState")
								{
									value = EAction.ClientSetSeasonState;
									return true;
								}
							}
						}
						else if (name == "ToggleDragActorPlay")
						{
							value = EAction.ToggleDragActorPlay;
							return true;
						}
					}
					else if (num != 3590975241U)
					{
						if (num == 3593847481U)
						{
							if (name == "SheriffUnlockClue")
							{
								value = EAction.SheriffUnlockClue;
								return true;
							}
						}
					}
					else if (name == "ChangePhantomFormation")
					{
						value = EAction.ChangePhantomFormation;
						return true;
					}
				}
				else if (num <= 3728081691U)
				{
					if (num <= 3662091041U)
					{
						if (num <= 3650441453U)
						{
							if (num != 3618734640U)
							{
								if (num != 3619002385U)
								{
									if (num == 3650441453U)
									{
										if (name == "SetSportsState")
										{
											value = EAction.SetSportsState;
											return true;
										}
									}
								}
								else if (name == "CloseSimpleGameplay")
								{
									value = EAction.CloseSimpleGameplay;
									return true;
								}
							}
							else if (name == "TriggerGamepadShake")
							{
								value = EAction.TriggerGamepadShake;
								return true;
							}
						}
						else if (num != 3652011744U)
						{
							if (num != 3660425845U)
							{
								if (num == 3662091041U)
								{
									if (name == "CommonTip")
									{
										value = EAction.CommonTip;
										return true;
									}
								}
							}
							else if (name == "FireBullet")
							{
								value = EAction.FireBullet;
								return true;
							}
						}
						else if (name == "ChangeElementalBoxState")
						{
							value = EAction.ChangeElementalBoxState;
							return true;
						}
					}
					else if (num <= 3686042588U)
					{
						if (num != 3662402425U)
						{
							if (num != 3674890103U)
							{
								if (num == 3686042588U)
								{
									if (name == "EnableAI")
									{
										value = EAction.EnableAI;
										return true;
									}
								}
							}
							else if (name == "HonamiStoryActivateSafeEvacuation")
							{
								value = EAction.HonamiStoryActivateSafeEvacuation;
								return true;
							}
						}
						else if (name == "ToggleTimerPauseState")
						{
							value = EAction.ToggleTimerPauseState;
							return true;
						}
					}
					else if (num != 3694430216U)
					{
						if (num != 3703133089U)
						{
							if (num == 3728081691U)
							{
								if (name == "ShowMessage")
								{
									value = EAction.ShowMessage;
									return true;
								}
							}
						}
						else if (name == "SetupMoraleSystem")
						{
							value = EAction.SetupMoraleSystem;
							return true;
						}
					}
					else if (name == "CollectSunSpirit")
					{
						value = EAction.CollectSunSpirit;
						return true;
					}
				}
				else if (num <= 3779015715U)
				{
					if (num <= 3752365065U)
					{
						if (num != 3732766550U)
						{
							if (num != 3748891560U)
							{
								if (num == 3752365065U)
								{
									if (name == "SetForceLock")
									{
										value = EAction.SetForceLock;
										return true;
									}
								}
							}
							else if (name == "SetAreaTimeState")
							{
								value = EAction.SetAreaTimeState;
								return true;
							}
						}
						else if (name == "ModifySceneItemAttributeTag")
						{
							value = EAction.ModifySceneItemAttributeTag;
							return true;
						}
					}
					else if (num != 3754794957U)
					{
						if (num != 3759637929U)
						{
							if (num == 3779015715U)
							{
								if (name == "OpenQte")
								{
									value = EAction.OpenQte;
									return true;
								}
							}
						}
						else if (name == "FixShowTargetRange")
						{
							value = EAction.FixShowTargetRange;
							return true;
						}
					}
					else if (name == "SetMoveSpeed")
					{
						value = EAction.SetMoveSpeed;
						return true;
					}
				}
				else if (num <= 3791982811U)
				{
					if (num != 3782254967U)
					{
						if (num != 3788867238U)
						{
							if (num == 3791982811U)
							{
								if (name == "SetBehaviorIsPaused")
								{
									value = EAction.SetBehaviorIsPaused;
									return true;
								}
							}
						}
						else if (name == "ReignsCheckSettle")
						{
							value = EAction.ReignsCheckSettle;
							return true;
						}
					}
					else if (name == "ClearFishingCabinInSaleItems")
					{
						value = EAction.ClearFishingCabinInSaleItems;
						return true;
					}
				}
				else if (num <= 3808295116U)
				{
					if (num != 3802766850U)
					{
						if (num == 3808295116U)
						{
							if (name == "PlayMontage")
							{
								value = EAction.PlayMontage;
								return true;
							}
						}
					}
					else if (name == "PlayLevelSequence")
					{
						value = EAction.PlayLevelSequence;
						return true;
					}
				}
				else if (num != 3820720027U)
				{
					if (num == 3831918259U)
					{
						if (name == "SetPos")
						{
							value = EAction.SetPos;
							return true;
						}
					}
				}
				else if (name == "CreatePrefab")
				{
					value = EAction.CreatePrefab;
					return true;
				}
			}
			else if (num <= 4085100186U)
			{
				if (num <= 3944804961U)
				{
					if (num <= 3879457942U)
					{
						if (num <= 3852819814U)
						{
							if (num != 3833707037U)
							{
								if (num != 3845969073U)
								{
									if (num == 3852819814U)
									{
										if (name == "EnableTemporaryTeleport")
										{
											value = EAction.EnableTemporaryTeleport;
											return true;
										}
									}
								}
								else if (name == "TetrisGameComplete")
								{
									value = EAction.TetrisGameComplete;
									return true;
								}
							}
							else if (name == "CallByCondition")
							{
								value = EAction.CallByCondition;
								return true;
							}
						}
						else if (num != 3865623548U)
						{
							if (num != 3873269114U)
							{
								if (num == 3879457942U)
								{
									if (name == "AddBuffToTriggeredEntity")
									{
										value = EAction.AddBuffToTriggeredEntity;
										return true;
									}
								}
							}
							else if (name == "ShowTalk")
							{
								value = EAction.ShowTalk;
								return true;
							}
						}
						else if (name == "FinishTalk")
						{
							value = EAction.FinishTalk;
							return true;
						}
					}
					else if (num <= 3923670299U)
					{
						if (num != 3896336121U)
						{
							if (num != 3919109462U)
							{
								if (num == 3923670299U)
								{
									if (name == "UnlockDungeonEntry")
									{
										value = EAction.UnlockDungeonEntry;
										return true;
									}
								}
							}
							else if (name == "PlayerLookAt")
							{
								value = EAction.PlayerLookAt;
								return true;
							}
						}
						else if (name == "FaceToPos")
						{
							value = EAction.FaceToPos;
							return true;
						}
					}
					else if (num != 3929830330U)
					{
						if (num != 3935555117U)
						{
							if (num == 3944804961U)
							{
								if (name == "MoveToPos")
								{
									value = EAction.MoveToPos;
									return true;
								}
							}
						}
						else if (name == "ChangeSelfEntityState")
						{
							value = EAction.ChangeSelfEntityState;
							return true;
						}
					}
					else if (name == "InfrActivityUpgradeInfrastructure")
					{
						value = EAction.InfrActivityUpgradeInfrastructure;
						return true;
					}
				}
				else if (num <= 4014012451U)
				{
					if (num <= 3991142744U)
					{
						if (num != 3952335754U)
						{
							if (num != 3975459613U)
							{
								if (num == 3991142744U)
								{
									if (name == "ClaimDynamicEntityReward")
									{
										value = EAction.ClaimDynamicEntityReward;
										return true;
									}
								}
							}
							else if (name == "SetFlowTemplate")
							{
								value = EAction.SetFlowTemplate;
								return true;
							}
						}
						else if (name == "FixTeleControllerPos")
						{
							value = EAction.FixTeleControllerPos;
							return true;
						}
					}
					else if (num != 3994703269U)
					{
						if (num != 3999318993U)
						{
							if (num == 4014012451U)
							{
								if (name == "UnlockSystemItem")
								{
									value = EAction.UnlockSystemItem;
									return true;
								}
							}
						}
						else if (name == "Collect")
						{
							value = EAction.Collect;
							return true;
						}
					}
					else if (name == "HideTargetRange")
					{
						value = EAction.HideTargetRange;
						return true;
					}
				}
				else if (num <= 4048686732U)
				{
					if (num != 4033815033U)
					{
						if (num != 4043288161U)
						{
							if (num == 4048686732U)
							{
								if (name == "EnableNearbyTracking")
								{
									value = EAction.EnableNearbyTracking;
									return true;
								}
							}
						}
						else if (name == "DestroyDynamicEntities")
						{
							value = EAction.DestroyDynamicEntities;
							return true;
						}
					}
					else if (name == "EnableKey4Func")
					{
						value = EAction.EnableKey4Func;
						return true;
					}
				}
				else if (num <= 4062373496U)
				{
					if (num != 4053018617U)
					{
						if (num == 4062373496U)
						{
							if (name == "EnterMovieCamera")
							{
								value = EAction.EnterMovieCamera;
								return true;
							}
						}
					}
					else if (name == "PlayMovie")
					{
						value = EAction.PlayMovie;
						return true;
					}
				}
				else if (num != 4069348538U)
				{
					if (num == 4085100186U)
					{
						if (name == "TriggerCameraShake")
						{
							value = EAction.TriggerCameraShake;
							return true;
						}
					}
				}
				else if (name == "LimitPlayerOperation")
				{
					value = EAction.LimitPlayerOperation;
					return true;
				}
			}
			else if (num <= 4208641742U)
			{
				if (num <= 4147837934U)
				{
					if (num <= 4115363916U)
					{
						if (num != 4088107391U)
						{
							if (num != 4102215337U)
							{
								if (num == 4115363916U)
								{
									if (name == "AcceptFishingEntrust")
									{
										value = EAction.AcceptFishingEntrust;
										return true;
									}
								}
							}
							else if (name == "PostAkEvent")
							{
								value = EAction.PostAkEvent;
								return true;
							}
						}
						else if (name == "VehiclePlayPassengerVoice")
						{
							value = EAction.VehiclePlayPassengerVoice;
							return true;
						}
					}
					else if (num != 4119110275U)
					{
						if (num != 4138262474U)
						{
							if (num == 4147837934U)
							{
								if (name == "SpawnChild")
								{
									value = EAction.SpawnChild;
									return true;
								}
							}
						}
						else if (name == "UnlockEntity")
						{
							value = EAction.UnlockEntity;
							return true;
						}
					}
					else if (name == "DestroyPrefab")
					{
						value = EAction.DestroyPrefab;
						return true;
					}
				}
				else if (num <= 4190790351U)
				{
					if (num != 4157997569U)
					{
						if (num != 4183518713U)
						{
							if (num == 4190790351U)
							{
								if (name == "OpenSimpleGameplay")
								{
									value = EAction.OpenSimpleGameplay;
									return true;
								}
							}
						}
						else if (name == "ClientPreEnableSubLevels")
						{
							value = EAction.ClientPreEnableSubLevels;
							return true;
						}
					}
					else if (name == "ModifyActorMaterial")
					{
						value = EAction.ModifyActorMaterial;
						return true;
					}
				}
				else if (num <= 4202393914U)
				{
					if (num != 4193798219U)
					{
						if (num == 4202393914U)
						{
							if (name == "BossPilingEnterNextInst")
							{
								value = EAction.BossPilingEnterNextInst;
								return true;
							}
						}
					}
					else if (name == "StartRoadNetworkNavigation")
					{
						value = EAction.StartRoadNetworkNavigation;
						return true;
					}
				}
				else if (num != 4202742786U)
				{
					if (num == 4208641742U)
					{
						if (name == "ShowCenterText")
						{
							value = EAction.ShowCenterText;
							return true;
						}
					}
				}
				else if (name == "SetNpcGroupPerform")
				{
					value = EAction.SetNpcGroupPerform;
					return true;
				}
			}
			else if (num <= 4263359784U)
			{
				if (num <= 4245701740U)
				{
					if (num != 4213006399U)
					{
						if (num != 4219829037U)
						{
							if (num == 4245701740U)
							{
								if (name == "ClaimDungeonReward")
								{
									value = EAction.ClaimDungeonReward;
									return true;
								}
							}
						}
						else if (name == "Invoke")
						{
							value = EAction.Invoke;
							return true;
						}
					}
					else if (name == "RoverRogueRoomFinish")
					{
						value = EAction.RoverRogueRoomFinish;
						return true;
					}
				}
				else if (num != 4252355697U)
				{
					if (num != 4260903634U)
					{
						if (num == 4263359784U)
						{
							if (name == "ExitMovieMode")
							{
								value = EAction.ExitMovieMode;
								return true;
							}
						}
					}
					else if (name == "DetectTrigger")
					{
						value = EAction.DetectTrigger;
						return true;
					}
				}
				else if (name == "ReignsCallCard")
				{
					value = EAction.ReignsCallCard;
					return true;
				}
			}
			else if (num <= 4274779473U)
			{
				if (num != 4266083725U)
				{
					if (num != 4274775290U)
					{
						if (num == 4274779473U)
						{
							if (name == "PlayBubble")
							{
								value = EAction.PlayBubble;
								return true;
							}
						}
					}
					else if (name == "BvbPlayerOperationConstraint")
					{
						value = EAction.BvbPlayerOperationConstraint;
						return true;
					}
				}
				else if (name == "PlayCustomSequence")
				{
					value = EAction.PlayCustomSequence;
					return true;
				}
			}
			else if (num <= 4280968301U)
			{
				if (num != 4275157832U)
				{
					if (num == 4280968301U)
					{
						if (name == "CallFunction")
						{
							value = EAction.CallFunction;
							return true;
						}
					}
				}
				else if (name == "ForceOccupations")
				{
					value = EAction.ForceOccupations;
					return true;
				}
			}
			else if (num != 4283085870U)
			{
				if (num == 4287466595U)
				{
					if (name == "MoveSceneItem")
					{
						value = EAction.MoveSceneItem;
						return true;
					}
				}
			}
			else if (name == "VehicleExitPlayer")
			{
				value = EAction.VehicleExitPlayer;
				return true;
			}
			value = EAction.Undefined;
			return false;
		}

		// Token: 0x0600C1D8 RID: 49624 RVA: 0x001C2B08 File Offset: 0x001C0D08
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Undefined",
				"Activate",
				"AccpetCurrentQuest",
				"AddFlowInteractOption",
				"SetTime",
				"AwakeEntity",
				"CalculateVar",
				"RandomVar",
				"CallByCondition",
				"CallFunction",
				"CameraLookAt",
				"StopCameraLookAt",
				"EnableHostility",
				"ChangeActorState",
				"ChangeBehaviorState",
				"ChangeEntityState",
				"ChangeNpcPerformState",
				"ChangeInteractOptionText",
				"ChangeOtherState",
				"ChangeRandomState",
				"ChangeState",
				"Collect",
				"CompleteChildQuest",
				"Destroy",
				"DestroyAllChild",
				"DestroyEntity",
				"DestroySelf",
				"DoCalculate",
				"EnableFunction",
				"EnableClientFunction",
				"FaceToPos",
				"FinishDoInteract",
				"FinishState",
				"FinishTalk",
				"GetItem",
				"DestroyQuestItem",
				"GuideTrigger",
				"CompleteGuide",
				"Invoke",
				"JumpTalk",
				"Log",
				"MoveToPos",
				"MoveWithSpline",
				"NewMoveWithSpline",
				"StopNewMoveWithSpline",
				"CharacterMoveToPoint",
				"PlayerMoveToPoint",
				"NpcMoveToPoint",
				"OpenSystemBoard",
				"OpenSystemFunction",
				"PlayCustomSequence",
				"PlayerLookAt",
				"EntityLookAt",
				"EntityTurnTo",
				"CharacterLookAt",
				"PlayFlow",
				"PlayMovie",
				"PlayEffect",
				"PlayEffect2",
				"RemoveEffect",
				"PlayMontage",
				"PlayRegisteredMontage",
				"PlaySequenceData",
				"PlayerInput",
				"Prompt",
				"AddPlayBubble",
				"PlayBubble",
				"ClearPlayBubble",
				"EnableAI",
				"RemoveFlowInteractOption",
				"SendNpcMail",
				"SetBehaviorIsPaused",
				"SetCameraMode",
				"SetEntityVisible",
				"SetEntityClientVisible",
				"SetEntityClientVisibleSave",
				"SetHeadIconVisible",
				"SetMoveSpeed",
				"SetNumberVar",
				"SetPlotMode",
				"SetPos",
				"SetVar",
				"SetActorVar",
				"ShowCenterText",
				"ShowMessage",
				"ShowTalk",
				"SimpleMove",
				"SpawnChild",
				"SpawnEntity",
				"SyncVarToActorState",
				"Wait",
				"AddBuffToEntity",
				"AddBuffToPlayer",
				"AddBuffToFollowShooter",
				"LockEntity",
				"UnlockEntity",
				"SetForceLock",
				"SetAreaState",
				"SetWuYinQuState",
				"RemoveBuffFromEntity",
				"RemoveBuffFromPlayer",
				"SetPlayerMoveControl",
				"UnlockTeleportTrigger",
				"ChangeTeamPosition",
				"ClientChangeTeamPosition",
				"ClaimLevelPlayReward",
				"ClaimDynamicEntityReward",
				"SetReviveRegion",
				"PromptQuestChapterUI",
				"FireBullet",
				"FireBulletEffect",
				"SetPlayerPos",
				"ClientSetPlayerPos",
				"ClientPreEnableSubLevels",
				"ChangeSelfEntityState",
				"InterludeActions",
				"AddBuffToTriggeredEntity",
				"RemoveBuffToTriggeredEntity",
				"DetectTrigger",
				"ItemFoundationMatch",
				"SetBattleState",
				"WaitBattleCondition",
				"UnlockSystemItem",
				"ClientUnlockAchievementSystemItem",
				"RunActions",
				"CommonTip",
				"EndCommonTip",
				"CommonTip2",
				"EnableNearbyTracking",
				"EnableLevelPlay",
				"UnLimitPlayerOperation",
				"LimitPlayerOperation",
				"SetPlayerOperationRestriction",
				"ClientSetPlayerOperationRestriction",
				"LeisureInteract",
				"NpcLeisureInteract",
				"ChangePhantom",
				"RestorePhantom",
				"TakePlotPhoto",
				"OpenQte",
				"Preload",
				"RemovePreloadResource",
				"ExecAlertSystemAction",
				"RecordDungeonEvent",
				"ResetLevelPlay",
				"SetAreaTimeState",
				"GetRewardByInteract",
				"WaitUntilLevelSequenceReachMark",
				"EnableKey4Func",
				"OpenQuickHackSystem",
				"GuestOperateUiAnimation",
				"VehicleEnter",
				"VehicleEnterNpc",
				"VehicleExitPlayer",
				"VehicleExitNpc",
				"VehicleTeleport",
				"ClientVehicleTeleport",
				"VehiclePlayPassengerVoice",
				"VehicleWaterfallClimbing",
				"TeleportToAndEnterVehicle",
				"VehicleMoveWithPathLine",
				"VehicleSprint",
				"VehicleSetSpeedImmediately",
				"TeleportDungeon",
				"SettlementDungeon",
				"ClaimDungeonReward",
				"ExitDungeon",
				"UnlockDungeonEntry",
				"FinishDungeon",
				"StopUiScreenEffect",
				"StartFlowTemplate",
				"BeginFlowTemplate",
				"ChangeFlowTemplate",
				"SetFlowTemplate",
				"EndFlowTemplate",
				"CloseFlowTemplate",
				"SendAiEvent",
				"FadeInScreen",
				"FadeOutScreen",
				"ChangeFightTeam",
				"ManualOccupations",
				"AddTrialCharacter",
				"UpdateTrialCharacter",
				"RestoreTrialCharacter",
				"RemoveTrialCharacter",
				"AddGuestCharacter",
				"RemoveGuestCharacter",
				"AddTrialFollowShooter",
				"RemoveTrialFollowShooter",
				"EnableFollowShooterAbility",
				"ClientFollowShooterLeisureInteract",
				"DestroyQuest",
				"SetCameraAnim",
				"RotatorEntity",
				"TraceSpline",
				"ToggleScanSplineEffect",
				"ChangeTimer",
				"ToggleTimerPauseState",
				"EnableSystem",
				"PostAkEvent",
				"MoveSceneItem",
				"StopSceneItemMove",
				"ChangeLiftTarget",
				"HideByRangeInFlow",
				"ShowAllHidedGroupInFlow",
				"OpenSimpleGameplay",
				"CloseSimpleGameplay",
				"ChangeActorTalker",
				"SwitchSubLevels",
				"SwitchDataLayers",
				"ActivateResetPoint",
				"TeleportToLatestResetPoint",
				"SetWeather",
				"SetTimeLockState",
				"SetWeatherLockState",
				"AdjustPlayerCamera",
				"AdjustPlayerCameraGravity",
				"RestorePlayerCameraAdjustment",
				"EnterMovieCamera",
				"ExitMovieCamera",
				"ResetPlayerCameraFocus",
				"UsePhantomSkill",
				"ChangePhantomFormation",
				"RestorePhantomFormation",
				"EnterOrbitalCamera",
				"ExitOrbitalCamera",
				"EnableSplineMoveModel",
				"SetSportsState",
				"PlayLevelSequence",
				"EnableTakePhotoClip",
				"SetExploreState",
				"EnableAoiNotify",
				"ChangeEntityPrefabPerformance",
				"ModifySceneItemAttributeTag",
				"ClientModifyTargetTag",
				"ToggleMapMarkState",
				"FocusOnMapMark",
				"ToggleHighlightExploreUi",
				"EnableTemporaryTeleport",
				"SetTeleControl",
				"ActiveAntiGravitySafePoint",
				"TriggerSpecificScanEffect",
				"SendClientEvent",
				"ClearFishingCabinInSaleItems",
				"AcceptFishingEntrust",
				"DestroyFishingBoat",
				"SlideRailStart",
				"SlideRailEnd",
				"SlidePerformStart",
				"BvbSendSystemEvent",
				"BvbSendAiEvent",
				"BvbPlayDialog",
				"BvbPlayerOperationConstraint",
				"BvbSkipChallenge",
				"SetSpineAnimation",
				"ChangeEntityCamp",
				"TrapDefenseChangeMiniMap",
				"TrapDefensePlayerOperationConstraint",
				"RogueGotoNextFloor",
				"RogueSelectRoom",
				"RogueActivatePortal",
				"RogueReceiveReward",
				"ExecRiskHarvestEffect",
				"MowingTowerGotoNextFloor",
				"SlashAndTowerGotoNextFloor",
				"RoleTowerGotoNextFloor",
				"DangoAbyssActivatePortal",
				"DangoAbyssGotoNextFloor",
				"DangoAbyssCreateRewardTreasureBox",
				"DangoAbyssReceiveReward",
				"RoverRogueRoomFinish",
				"RoverRogueActivate",
				"RoverRogueCreateRoomReward",
				"EnableActor",
				"ModifyActorMaterial",
				"SpecialOpModifyActorMaterialParamBySplineProgress",
				"ModifyActorMedia",
				"ToggleAirWall",
				"SetDataLayerTransitions",
				"TriggerCameraShake",
				"TriggerGamepadShake",
				"CreatePrefab",
				"DestroyPrefab",
				"ExecBattleAction",
				"ExecClientBattleAction",
				"RecoverDurability",
				"SetRegionConfig",
				"SetJigsawItem",
				"SetJigsawFoundation",
				"ResetEntity",
				"PlayDynamicSettlement",
				"SetInteractionLockState",
				"FinishCondition",
				"ClearEntityVisibleTag",
				"SetEntityPos",
				"ResetEntityPos",
				"ServerSetPlayerPos",
				"FixTeleControllerPos",
				"CustomJson",
				"FixFoundationRelation",
				"FixShowTargetRange",
				"TraceCurrentQuest",
				"ForceOccupations",
				"ServerForceEnableLevelPlay",
				"TeleportDungeonPos",
				"SetTimeScale",
				"FixGetItem",
				"SetAudioState",
				"PerformerAiSplineMove",
				"PerformerAiMoveTo",
				"EnterPatrolState",
				"PerformAiHideSelf",
				"ExecResurrection",
				"HideSpecificEntities",
				"ShowSpecificEntities",
				"HideTargetRange",
				"ShowTargetRange",
				"HideGroup",
				"ShowHidedGroup",
				"ReignsSetPropertyVisible",
				"ReignsChangeBackground",
				"ReignsChangePlayerName",
				"ReignsCallCard",
				"ReignsTriggerGuide",
				"ReignsAddBuff",
				"ReignsCheckSettle",
				"HonamiStoryInteractPickUp",
				"HonamiStoryReceiveCorruptedChestReward",
				"HonamiStoryActivateSafeEvacuation",
				"HonamiStoryGetItem",
				"HonamiStorySetFormation",
				"InfrActivityUpgradeInfrastructure",
				"SetNpcGroupPerform",
				"RemoveNpcGroupPerform",
				"EnableEntityLookAt",
				"DisableEntityLookAt",
				"OverrideAiBehaviorTree",
				"RestoreAiBehaviorTree",
				"FlowDefineNpcGroupPerform",
				"SeqEventAddTagToSelf",
				"SeqEventFireBullet",
				"SetMotorSpeed",
				"StartMotorCruise",
				"StopMotorCruise",
				"DriveMotorInSpecConfig",
				"MotorSoarInWindField",
				"CollectSunSpirit",
				"PerformSunSpiritGearRoundTrip",
				"TriggerDeadeyeMode",
				"OpenSystemBoardWithReturn",
				"ResumeSystemRewardPopup",
				"SummonEntity",
				"DestroySummonedEntities",
				"SetupMoraleSystem",
				"GiantToggleModel",
				"GiantTriggerResponse",
				"ActivateGiantTotalProgressNode",
				"RunActorCustomEvent",
				"RequestSystemFunction",
				"PlayWalkingOverlayMontage",
				"ChangeNpcAbpState",
				"CloseWalkingOverlayMontage",
				"SetSkillButtonEffect",
				"ScanEnrichmentArea",
				"TriggerSystemRandomPlot",
				"SetAudioEnable",
				"PhoneSystemInteract",
				"RollBlockGetReward",
				"EnterMovieMode",
				"ExitMovieMode",
				"StartRoadNetworkNavigation",
				"SetWayOccupancyState",
				"SendSceneActorsEvent",
				"ExecBpActorFunc",
				"ResetPlayerPosWithPresentation",
				"PlayerLookTowards",
				"DrinksRollRoleRequirement",
				"SetBlendAnim",
				"ReportTrackingEvent",
				"TetrisThrowBlock",
				"TetrisGameComplete",
				"TetrisTriggerDelayFall",
				"BossPilingRandomBuff",
				"BossPilingEnterNextInst",
				"DollGrabItemDelivery",
				"AvgPlayRoleAction",
				"AvgMoveRole",
				"AvgFocusRole",
				"AvgShakeUi",
				"DestroyDynamicEntities",
				"SheriffUnlockClue",
				"SheriffUnlockProgress",
				"SheriffChangeCriminalState",
				"SheriffChangeCriminalIdentity",
				"SheriffUnlockEnding",
				"SetSubScreenMode",
				"ClientSetSeasonState",
				"ToggleDragActorPlay",
				"SetTargetElementalAbility",
				"ToggleEntityElementalAbility",
				"CaptureElementalBox",
				"ChangeElementalBoxState",
				"SetElementalBoxToTarget",
				"OverrideAbpAnimScheme"
			};
		}

		// Token: 0x0600C1D9 RID: 49625 RVA: 0x001C3C86 File Offset: 0x001C1E86
		public static EAction[] GetValues()
		{
			return new EAction[]
			{
				EAction.Undefined,
				EAction.Activate,
				EAction.AccpetCurrentQuest,
				EAction.AddFlowInteractOption,
				EAction.SetTime,
				EAction.AwakeEntity,
				EAction.CalculateVar,
				EAction.RandomVar,
				EAction.CallByCondition,
				EAction.CallFunction,
				EAction.CameraLookAt,
				EAction.StopCameraLookAt,
				EAction.EnableHostility,
				EAction.ChangeActorState,
				EAction.ChangeBehaviorState,
				EAction.ChangeEntityState,
				EAction.ChangeNpcPerformState,
				EAction.ChangeInteractOptionText,
				EAction.ChangeOtherState,
				EAction.ChangeRandomState,
				EAction.ChangeState,
				EAction.Collect,
				EAction.CompleteChildQuest,
				EAction.Destroy,
				EAction.DestroyAllChild,
				EAction.DestroyEntity,
				EAction.DestroySelf,
				EAction.DoCalculate,
				EAction.EnableFunction,
				EAction.EnableClientFunction,
				EAction.FaceToPos,
				EAction.FinishDoInteract,
				EAction.FinishState,
				EAction.FinishTalk,
				EAction.GetItem,
				EAction.DestroyQuestItem,
				EAction.GuideTrigger,
				EAction.CompleteGuide,
				EAction.Invoke,
				EAction.JumpTalk,
				EAction.Log,
				EAction.MoveToPos,
				EAction.MoveWithSpline,
				EAction.NewMoveWithSpline,
				EAction.StopNewMoveWithSpline,
				EAction.CharacterMoveToPoint,
				EAction.PlayerMoveToPoint,
				EAction.NpcMoveToPoint,
				EAction.OpenSystemBoard,
				EAction.OpenSystemFunction,
				EAction.PlayCustomSequence,
				EAction.PlayerLookAt,
				EAction.EntityLookAt,
				EAction.EntityTurnTo,
				EAction.CharacterLookAt,
				EAction.PlayFlow,
				EAction.PlayMovie,
				EAction.PlayEffect,
				EAction.PlayEffect2,
				EAction.RemoveEffect,
				EAction.PlayMontage,
				EAction.PlayRegisteredMontage,
				EAction.PlaySequenceData,
				EAction.PlayerInput,
				EAction.Prompt,
				EAction.AddPlayBubble,
				EAction.PlayBubble,
				EAction.ClearPlayBubble,
				EAction.EnableAI,
				EAction.RemoveFlowInteractOption,
				EAction.SendNpcMail,
				EAction.SetBehaviorIsPaused,
				EAction.SetCameraMode,
				EAction.SetEntityVisible,
				EAction.SetEntityClientVisible,
				EAction.SetEntityClientVisibleSave,
				EAction.SetHeadIconVisible,
				EAction.SetMoveSpeed,
				EAction.SetNumberVar,
				EAction.SetPlotMode,
				EAction.SetPos,
				EAction.SetVar,
				EAction.SetActorVar,
				EAction.ShowCenterText,
				EAction.ShowMessage,
				EAction.ShowTalk,
				EAction.SimpleMove,
				EAction.SpawnChild,
				EAction.SpawnEntity,
				EAction.SyncVarToActorState,
				EAction.Wait,
				EAction.AddBuffToEntity,
				EAction.AddBuffToPlayer,
				EAction.AddBuffToFollowShooter,
				EAction.LockEntity,
				EAction.UnlockEntity,
				EAction.SetForceLock,
				EAction.SetAreaState,
				EAction.SetWuYinQuState,
				EAction.RemoveBuffFromEntity,
				EAction.RemoveBuffFromPlayer,
				EAction.SetPlayerMoveControl,
				EAction.UnlockTeleportTrigger,
				EAction.ChangeTeamPosition,
				EAction.ClientChangeTeamPosition,
				EAction.ClaimLevelPlayReward,
				EAction.ClaimDynamicEntityReward,
				EAction.SetReviveRegion,
				EAction.PromptQuestChapterUI,
				EAction.FireBullet,
				EAction.FireBulletEffect,
				EAction.SetPlayerPos,
				EAction.ClientSetPlayerPos,
				EAction.ClientPreEnableSubLevels,
				EAction.ChangeSelfEntityState,
				EAction.InterludeActions,
				EAction.AddBuffToTriggeredEntity,
				EAction.RemoveBuffToTriggeredEntity,
				EAction.DetectTrigger,
				EAction.ItemFoundationMatch,
				EAction.SetBattleState,
				EAction.WaitBattleCondition,
				EAction.UnlockSystemItem,
				EAction.ClientUnlockAchievementSystemItem,
				EAction.RunActions,
				EAction.CommonTip,
				EAction.EndCommonTip,
				EAction.CommonTip2,
				EAction.EnableNearbyTracking,
				EAction.EnableLevelPlay,
				EAction.UnLimitPlayerOperation,
				EAction.LimitPlayerOperation,
				EAction.SetPlayerOperationRestriction,
				EAction.ClientSetPlayerOperationRestriction,
				EAction.LeisureInteract,
				EAction.NpcLeisureInteract,
				EAction.ChangePhantom,
				EAction.RestorePhantom,
				EAction.TakePlotPhoto,
				EAction.OpenQte,
				EAction.Preload,
				EAction.RemovePreloadResource,
				EAction.ExecAlertSystemAction,
				EAction.RecordDungeonEvent,
				EAction.ResetLevelPlay,
				EAction.SetAreaTimeState,
				EAction.GetRewardByInteract,
				EAction.WaitUntilLevelSequenceReachMark,
				EAction.EnableKey4Func,
				EAction.OpenQuickHackSystem,
				EAction.GuestOperateUiAnimation,
				EAction.VehicleEnter,
				EAction.VehicleEnterNpc,
				EAction.VehicleExitPlayer,
				EAction.VehicleExitNpc,
				EAction.VehicleTeleport,
				EAction.ClientVehicleTeleport,
				EAction.VehiclePlayPassengerVoice,
				EAction.VehicleWaterfallClimbing,
				EAction.TeleportToAndEnterVehicle,
				EAction.VehicleMoveWithPathLine,
				EAction.VehicleSprint,
				EAction.VehicleSetSpeedImmediately,
				EAction.TeleportDungeon,
				EAction.SettlementDungeon,
				EAction.ClaimDungeonReward,
				EAction.ExitDungeon,
				EAction.UnlockDungeonEntry,
				EAction.FinishDungeon,
				EAction.StopUiScreenEffect,
				EAction.StartFlowTemplate,
				EAction.BeginFlowTemplate,
				EAction.ChangeFlowTemplate,
				EAction.SetFlowTemplate,
				EAction.EndFlowTemplate,
				EAction.CloseFlowTemplate,
				EAction.SendAiEvent,
				EAction.FadeInScreen,
				EAction.FadeOutScreen,
				EAction.ChangeFightTeam,
				EAction.ManualOccupations,
				EAction.AddTrialCharacter,
				EAction.UpdateTrialCharacter,
				EAction.RestoreTrialCharacter,
				EAction.RemoveTrialCharacter,
				EAction.AddGuestCharacter,
				EAction.RemoveGuestCharacter,
				EAction.AddTrialFollowShooter,
				EAction.RemoveTrialFollowShooter,
				EAction.EnableFollowShooterAbility,
				EAction.ClientFollowShooterLeisureInteract,
				EAction.DestroyQuest,
				EAction.SetCameraAnim,
				EAction.RotatorEntity,
				EAction.TraceSpline,
				EAction.ToggleScanSplineEffect,
				EAction.ChangeTimer,
				EAction.ToggleTimerPauseState,
				EAction.EnableSystem,
				EAction.PostAkEvent,
				EAction.MoveSceneItem,
				EAction.StopSceneItemMove,
				EAction.ChangeLiftTarget,
				EAction.HideByRangeInFlow,
				EAction.ShowAllHidedGroupInFlow,
				EAction.OpenSimpleGameplay,
				EAction.CloseSimpleGameplay,
				EAction.ChangeActorTalker,
				EAction.SwitchSubLevels,
				EAction.SwitchDataLayers,
				EAction.ActivateResetPoint,
				EAction.TeleportToLatestResetPoint,
				EAction.SetWeather,
				EAction.SetTimeLockState,
				EAction.SetWeatherLockState,
				EAction.AdjustPlayerCamera,
				EAction.AdjustPlayerCameraGravity,
				EAction.RestorePlayerCameraAdjustment,
				EAction.EnterMovieCamera,
				EAction.ExitMovieCamera,
				EAction.ResetPlayerCameraFocus,
				EAction.UsePhantomSkill,
				EAction.ChangePhantomFormation,
				EAction.RestorePhantomFormation,
				EAction.EnterOrbitalCamera,
				EAction.ExitOrbitalCamera,
				EAction.EnableSplineMoveModel,
				EAction.SetSportsState,
				EAction.PlayLevelSequence,
				EAction.EnableTakePhotoClip,
				EAction.SetExploreState,
				EAction.EnableAoiNotify,
				EAction.ChangeEntityPrefabPerformance,
				EAction.ModifySceneItemAttributeTag,
				EAction.ClientModifyTargetTag,
				EAction.ToggleMapMarkState,
				EAction.FocusOnMapMark,
				EAction.ToggleHighlightExploreUi,
				EAction.EnableTemporaryTeleport,
				EAction.SetTeleControl,
				EAction.ActiveAntiGravitySafePoint,
				EAction.TriggerSpecificScanEffect,
				EAction.SendClientEvent,
				EAction.ClearFishingCabinInSaleItems,
				EAction.AcceptFishingEntrust,
				EAction.DestroyFishingBoat,
				EAction.SlideRailStart,
				EAction.SlideRailEnd,
				EAction.SlidePerformStart,
				EAction.BvbSendSystemEvent,
				EAction.BvbSendAiEvent,
				EAction.BvbPlayDialog,
				EAction.BvbPlayerOperationConstraint,
				EAction.BvbSkipChallenge,
				EAction.SetSpineAnimation,
				EAction.ChangeEntityCamp,
				EAction.TrapDefenseChangeMiniMap,
				EAction.TrapDefensePlayerOperationConstraint,
				EAction.RogueGotoNextFloor,
				EAction.RogueSelectRoom,
				EAction.RogueActivatePortal,
				EAction.RogueReceiveReward,
				EAction.ExecRiskHarvestEffect,
				EAction.MowingTowerGotoNextFloor,
				EAction.SlashAndTowerGotoNextFloor,
				EAction.RoleTowerGotoNextFloor,
				EAction.DangoAbyssActivatePortal,
				EAction.DangoAbyssGotoNextFloor,
				EAction.DangoAbyssCreateRewardTreasureBox,
				EAction.DangoAbyssReceiveReward,
				EAction.RoverRogueRoomFinish,
				EAction.RoverRogueActivate,
				EAction.RoverRogueCreateRoomReward,
				EAction.EnableActor,
				EAction.ModifyActorMaterial,
				EAction.SpecialOpModifyActorMaterialParamBySplineProgress,
				EAction.ModifyActorMedia,
				EAction.ToggleAirWall,
				EAction.SetDataLayerTransitions,
				EAction.TriggerCameraShake,
				EAction.TriggerGamepadShake,
				EAction.CreatePrefab,
				EAction.DestroyPrefab,
				EAction.ExecBattleAction,
				EAction.ExecClientBattleAction,
				EAction.RecoverDurability,
				EAction.SetRegionConfig,
				EAction.SetJigsawItem,
				EAction.SetJigsawFoundation,
				EAction.ResetEntity,
				EAction.PlayDynamicSettlement,
				EAction.SetInteractionLockState,
				EAction.FinishCondition,
				EAction.ClearEntityVisibleTag,
				EAction.SetEntityPos,
				EAction.ResetEntityPos,
				EAction.ServerSetPlayerPos,
				EAction.FixTeleControllerPos,
				EAction.CustomJson,
				EAction.FixFoundationRelation,
				EAction.FixShowTargetRange,
				EAction.TraceCurrentQuest,
				EAction.ForceOccupations,
				EAction.ServerForceEnableLevelPlay,
				EAction.TeleportDungeonPos,
				EAction.SetTimeScale,
				EAction.FixGetItem,
				EAction.SetAudioState,
				EAction.PerformerAiSplineMove,
				EAction.PerformerAiMoveTo,
				EAction.EnterPatrolState,
				EAction.PerformAiHideSelf,
				EAction.ExecResurrection,
				EAction.HideSpecificEntities,
				EAction.ShowSpecificEntities,
				EAction.HideTargetRange,
				EAction.ShowTargetRange,
				EAction.HideGroup,
				EAction.ShowHidedGroup,
				EAction.ReignsSetPropertyVisible,
				EAction.ReignsChangeBackground,
				EAction.ReignsChangePlayerName,
				EAction.ReignsCallCard,
				EAction.ReignsTriggerGuide,
				EAction.ReignsAddBuff,
				EAction.ReignsCheckSettle,
				EAction.HonamiStoryInteractPickUp,
				EAction.HonamiStoryReceiveCorruptedChestReward,
				EAction.HonamiStoryActivateSafeEvacuation,
				EAction.HonamiStoryGetItem,
				EAction.HonamiStorySetFormation,
				EAction.InfrActivityUpgradeInfrastructure,
				EAction.SetNpcGroupPerform,
				EAction.RemoveNpcGroupPerform,
				EAction.EnableEntityLookAt,
				EAction.DisableEntityLookAt,
				EAction.OverrideAiBehaviorTree,
				EAction.RestoreAiBehaviorTree,
				EAction.FlowDefineNpcGroupPerform,
				EAction.SeqEventAddTagToSelf,
				EAction.SeqEventFireBullet,
				EAction.SetMotorSpeed,
				EAction.StartMotorCruise,
				EAction.StopMotorCruise,
				EAction.DriveMotorInSpecConfig,
				EAction.MotorSoarInWindField,
				EAction.CollectSunSpirit,
				EAction.PerformSunSpiritGearRoundTrip,
				EAction.TriggerDeadeyeMode,
				EAction.OpenSystemBoardWithReturn,
				EAction.ResumeSystemRewardPopup,
				EAction.SummonEntity,
				EAction.DestroySummonedEntities,
				EAction.SetupMoraleSystem,
				EAction.GiantToggleModel,
				EAction.GiantTriggerResponse,
				EAction.ActivateGiantTotalProgressNode,
				EAction.RunActorCustomEvent,
				EAction.RequestSystemFunction,
				EAction.PlayWalkingOverlayMontage,
				EAction.ChangeNpcAbpState,
				EAction.CloseWalkingOverlayMontage,
				EAction.SetSkillButtonEffect,
				EAction.ScanEnrichmentArea,
				EAction.TriggerSystemRandomPlot,
				EAction.SetAudioEnable,
				EAction.PhoneSystemInteract,
				EAction.RollBlockGetReward,
				EAction.EnterMovieMode,
				EAction.ExitMovieMode,
				EAction.StartRoadNetworkNavigation,
				EAction.SetWayOccupancyState,
				EAction.SendSceneActorsEvent,
				EAction.ExecBpActorFunc,
				EAction.ResetPlayerPosWithPresentation,
				EAction.PlayerLookTowards,
				EAction.DrinksRollRoleRequirement,
				EAction.SetBlendAnim,
				EAction.ReportTrackingEvent,
				EAction.TetrisThrowBlock,
				EAction.TetrisGameComplete,
				EAction.TetrisTriggerDelayFall,
				EAction.BossPilingRandomBuff,
				EAction.BossPilingEnterNextInst,
				EAction.DollGrabItemDelivery,
				EAction.AvgPlayRoleAction,
				EAction.AvgMoveRole,
				EAction.AvgFocusRole,
				EAction.AvgShakeUi,
				EAction.DestroyDynamicEntities,
				EAction.SheriffUnlockClue,
				EAction.SheriffUnlockProgress,
				EAction.SheriffChangeCriminalState,
				EAction.SheriffChangeCriminalIdentity,
				EAction.SheriffUnlockEnding,
				EAction.SetSubScreenMode,
				EAction.ClientSetSeasonState,
				EAction.ToggleDragActorPlay,
				EAction.SetTargetElementalAbility,
				EAction.ToggleEntityElementalAbility,
				EAction.CaptureElementalBox,
				EAction.ChangeElementalBoxState,
				EAction.SetElementalBoxToTarget,
				EAction.OverrideAbpAnimScheme
			};
		}

		// Token: 0x0600C1DA RID: 49626 RVA: 0x001C3CA0 File Offset: 0x001C1EA0
		public static string[] GetNames()
		{
			return new string[]
			{
				"Undefined",
				"Activate",
				"AccpetCurrentQuest",
				"AddFlowInteractOption",
				"SetTime",
				"AwakeEntity",
				"CalculateVar",
				"RandomVar",
				"CallByCondition",
				"CallFunction",
				"CameraLookAt",
				"StopCameraLookAt",
				"EnableHostility",
				"ChangeActorState",
				"ChangeBehaviorState",
				"ChangeEntityState",
				"ChangeNpcPerformState",
				"ChangeInteractOptionText",
				"ChangeOtherState",
				"ChangeRandomState",
				"ChangeState",
				"Collect",
				"CompleteChildQuest",
				"Destroy",
				"DestroyAllChild",
				"DestroyEntity",
				"DestroySelf",
				"DoCalculate",
				"EnableFunction",
				"EnableClientFunction",
				"FaceToPos",
				"FinishDoInteract",
				"FinishState",
				"FinishTalk",
				"GetItem",
				"DestroyQuestItem",
				"GuideTrigger",
				"CompleteGuide",
				"Invoke",
				"JumpTalk",
				"Log",
				"MoveToPos",
				"MoveWithSpline",
				"NewMoveWithSpline",
				"StopNewMoveWithSpline",
				"CharacterMoveToPoint",
				"PlayerMoveToPoint",
				"NpcMoveToPoint",
				"OpenSystemBoard",
				"OpenSystemFunction",
				"PlayCustomSequence",
				"PlayerLookAt",
				"EntityLookAt",
				"EntityTurnTo",
				"CharacterLookAt",
				"PlayFlow",
				"PlayMovie",
				"PlayEffect",
				"PlayEffect2",
				"RemoveEffect",
				"PlayMontage",
				"PlayRegisteredMontage",
				"PlaySequenceData",
				"PlayerInput",
				"Prompt",
				"AddPlayBubble",
				"PlayBubble",
				"ClearPlayBubble",
				"EnableAI",
				"RemoveFlowInteractOption",
				"SendNpcMail",
				"SetBehaviorIsPaused",
				"SetCameraMode",
				"SetEntityVisible",
				"SetEntityClientVisible",
				"SetEntityClientVisibleSave",
				"SetHeadIconVisible",
				"SetMoveSpeed",
				"SetNumberVar",
				"SetPlotMode",
				"SetPos",
				"SetVar",
				"SetActorVar",
				"ShowCenterText",
				"ShowMessage",
				"ShowTalk",
				"SimpleMove",
				"SpawnChild",
				"SpawnEntity",
				"SyncVarToActorState",
				"Wait",
				"AddBuffToEntity",
				"AddBuffToPlayer",
				"AddBuffToFollowShooter",
				"LockEntity",
				"UnlockEntity",
				"SetForceLock",
				"SetAreaState",
				"SetWuYinQuState",
				"RemoveBuffFromEntity",
				"RemoveBuffFromPlayer",
				"SetPlayerMoveControl",
				"UnlockTeleportTrigger",
				"ChangeTeamPosition",
				"ClientChangeTeamPosition",
				"ClaimLevelPlayReward",
				"ClaimDynamicEntityReward",
				"SetReviveRegion",
				"PromptQuestChapterUI",
				"FireBullet",
				"FireBulletEffect",
				"SetPlayerPos",
				"ClientSetPlayerPos",
				"ClientPreEnableSubLevels",
				"ChangeSelfEntityState",
				"InterludeActions",
				"AddBuffToTriggeredEntity",
				"RemoveBuffToTriggeredEntity",
				"DetectTrigger",
				"ItemFoundationMatch",
				"SetBattleState",
				"WaitBattleCondition",
				"UnlockSystemItem",
				"ClientUnlockAchievementSystemItem",
				"RunActions",
				"CommonTip",
				"EndCommonTip",
				"CommonTip2",
				"EnableNearbyTracking",
				"EnableLevelPlay",
				"UnLimitPlayerOperation",
				"LimitPlayerOperation",
				"SetPlayerOperationRestriction",
				"ClientSetPlayerOperationRestriction",
				"LeisureInteract",
				"NpcLeisureInteract",
				"ChangePhantom",
				"RestorePhantom",
				"TakePlotPhoto",
				"OpenQte",
				"Preload",
				"RemovePreloadResource",
				"ExecAlertSystemAction",
				"RecordDungeonEvent",
				"ResetLevelPlay",
				"SetAreaTimeState",
				"GetRewardByInteract",
				"WaitUntilLevelSequenceReachMark",
				"EnableKey4Func",
				"OpenQuickHackSystem",
				"GuestOperateUiAnimation",
				"VehicleEnter",
				"VehicleEnterNpc",
				"VehicleExitPlayer",
				"VehicleExitNpc",
				"VehicleTeleport",
				"ClientVehicleTeleport",
				"VehiclePlayPassengerVoice",
				"VehicleWaterfallClimbing",
				"TeleportToAndEnterVehicle",
				"VehicleMoveWithPathLine",
				"VehicleSprint",
				"VehicleSetSpeedImmediately",
				"TeleportDungeon",
				"SettlementDungeon",
				"ClaimDungeonReward",
				"ExitDungeon",
				"UnlockDungeonEntry",
				"FinishDungeon",
				"StopUiScreenEffect",
				"StartFlowTemplate",
				"BeginFlowTemplate",
				"ChangeFlowTemplate",
				"SetFlowTemplate",
				"EndFlowTemplate",
				"CloseFlowTemplate",
				"SendAiEvent",
				"FadeInScreen",
				"FadeOutScreen",
				"ChangeFightTeam",
				"ManualOccupations",
				"AddTrialCharacter",
				"UpdateTrialCharacter",
				"RestoreTrialCharacter",
				"RemoveTrialCharacter",
				"AddGuestCharacter",
				"RemoveGuestCharacter",
				"AddTrialFollowShooter",
				"RemoveTrialFollowShooter",
				"EnableFollowShooterAbility",
				"ClientFollowShooterLeisureInteract",
				"DestroyQuest",
				"SetCameraAnim",
				"RotatorEntity",
				"TraceSpline",
				"ToggleScanSplineEffect",
				"ChangeTimer",
				"ToggleTimerPauseState",
				"EnableSystem",
				"PostAkEvent",
				"MoveSceneItem",
				"StopSceneItemMove",
				"ChangeLiftTarget",
				"HideByRangeInFlow",
				"ShowAllHidedGroupInFlow",
				"OpenSimpleGameplay",
				"CloseSimpleGameplay",
				"ChangeActorTalker",
				"SwitchSubLevels",
				"SwitchDataLayers",
				"ActivateResetPoint",
				"TeleportToLatestResetPoint",
				"SetWeather",
				"SetTimeLockState",
				"SetWeatherLockState",
				"AdjustPlayerCamera",
				"AdjustPlayerCameraGravity",
				"RestorePlayerCameraAdjustment",
				"EnterMovieCamera",
				"ExitMovieCamera",
				"ResetPlayerCameraFocus",
				"UsePhantomSkill",
				"ChangePhantomFormation",
				"RestorePhantomFormation",
				"EnterOrbitalCamera",
				"ExitOrbitalCamera",
				"EnableSplineMoveModel",
				"SetSportsState",
				"PlayLevelSequence",
				"EnableTakePhotoClip",
				"SetExploreState",
				"EnableAoiNotify",
				"ChangeEntityPrefabPerformance",
				"ModifySceneItemAttributeTag",
				"ClientModifyTargetTag",
				"ToggleMapMarkState",
				"FocusOnMapMark",
				"ToggleHighlightExploreUi",
				"EnableTemporaryTeleport",
				"SetTeleControl",
				"ActiveAntiGravitySafePoint",
				"TriggerSpecificScanEffect",
				"SendClientEvent",
				"ClearFishingCabinInSaleItems",
				"AcceptFishingEntrust",
				"DestroyFishingBoat",
				"SlideRailStart",
				"SlideRailEnd",
				"SlidePerformStart",
				"BvbSendSystemEvent",
				"BvbSendAiEvent",
				"BvbPlayDialog",
				"BvbPlayerOperationConstraint",
				"BvbSkipChallenge",
				"SetSpineAnimation",
				"ChangeEntityCamp",
				"TrapDefenseChangeMiniMap",
				"TrapDefensePlayerOperationConstraint",
				"RogueGotoNextFloor",
				"RogueSelectRoom",
				"RogueActivatePortal",
				"RogueReceiveReward",
				"ExecRiskHarvestEffect",
				"MowingTowerGotoNextFloor",
				"SlashAndTowerGotoNextFloor",
				"RoleTowerGotoNextFloor",
				"DangoAbyssActivatePortal",
				"DangoAbyssGotoNextFloor",
				"DangoAbyssCreateRewardTreasureBox",
				"DangoAbyssReceiveReward",
				"RoverRogueRoomFinish",
				"RoverRogueActivate",
				"RoverRogueCreateRoomReward",
				"EnableActor",
				"ModifyActorMaterial",
				"SpecialOpModifyActorMaterialParamBySplineProgress",
				"ModifyActorMedia",
				"ToggleAirWall",
				"SetDataLayerTransitions",
				"TriggerCameraShake",
				"TriggerGamepadShake",
				"CreatePrefab",
				"DestroyPrefab",
				"ExecBattleAction",
				"ExecClientBattleAction",
				"RecoverDurability",
				"SetRegionConfig",
				"SetJigsawItem",
				"SetJigsawFoundation",
				"ResetEntity",
				"PlayDynamicSettlement",
				"SetInteractionLockState",
				"FinishCondition",
				"ClearEntityVisibleTag",
				"SetEntityPos",
				"ResetEntityPos",
				"ServerSetPlayerPos",
				"FixTeleControllerPos",
				"CustomJson",
				"FixFoundationRelation",
				"FixShowTargetRange",
				"TraceCurrentQuest",
				"ForceOccupations",
				"ServerForceEnableLevelPlay",
				"TeleportDungeonPos",
				"SetTimeScale",
				"FixGetItem",
				"SetAudioState",
				"PerformerAiSplineMove",
				"PerformerAiMoveTo",
				"EnterPatrolState",
				"PerformAiHideSelf",
				"ExecResurrection",
				"HideSpecificEntities",
				"ShowSpecificEntities",
				"HideTargetRange",
				"ShowTargetRange",
				"HideGroup",
				"ShowHidedGroup",
				"ReignsSetPropertyVisible",
				"ReignsChangeBackground",
				"ReignsChangePlayerName",
				"ReignsCallCard",
				"ReignsTriggerGuide",
				"ReignsAddBuff",
				"ReignsCheckSettle",
				"HonamiStoryInteractPickUp",
				"HonamiStoryReceiveCorruptedChestReward",
				"HonamiStoryActivateSafeEvacuation",
				"HonamiStoryGetItem",
				"HonamiStorySetFormation",
				"InfrActivityUpgradeInfrastructure",
				"SetNpcGroupPerform",
				"RemoveNpcGroupPerform",
				"EnableEntityLookAt",
				"DisableEntityLookAt",
				"OverrideAiBehaviorTree",
				"RestoreAiBehaviorTree",
				"FlowDefineNpcGroupPerform",
				"SeqEventAddTagToSelf",
				"SeqEventFireBullet",
				"SetMotorSpeed",
				"StartMotorCruise",
				"StopMotorCruise",
				"DriveMotorInSpecConfig",
				"MotorSoarInWindField",
				"CollectSunSpirit",
				"PerformSunSpiritGearRoundTrip",
				"TriggerDeadeyeMode",
				"OpenSystemBoardWithReturn",
				"ResumeSystemRewardPopup",
				"SummonEntity",
				"DestroySummonedEntities",
				"SetupMoraleSystem",
				"GiantToggleModel",
				"GiantTriggerResponse",
				"ActivateGiantTotalProgressNode",
				"RunActorCustomEvent",
				"RequestSystemFunction",
				"PlayWalkingOverlayMontage",
				"ChangeNpcAbpState",
				"CloseWalkingOverlayMontage",
				"SetSkillButtonEffect",
				"ScanEnrichmentArea",
				"TriggerSystemRandomPlot",
				"SetAudioEnable",
				"PhoneSystemInteract",
				"RollBlockGetReward",
				"EnterMovieMode",
				"ExitMovieMode",
				"StartRoadNetworkNavigation",
				"SetWayOccupancyState",
				"SendSceneActorsEvent",
				"ExecBpActorFunc",
				"ResetPlayerPosWithPresentation",
				"PlayerLookTowards",
				"DrinksRollRoleRequirement",
				"SetBlendAnim",
				"ReportTrackingEvent",
				"TetrisThrowBlock",
				"TetrisGameComplete",
				"TetrisTriggerDelayFall",
				"BossPilingRandomBuff",
				"BossPilingEnterNextInst",
				"DollGrabItemDelivery",
				"AvgPlayRoleAction",
				"AvgMoveRole",
				"AvgFocusRole",
				"AvgShakeUi",
				"DestroyDynamicEntities",
				"SheriffUnlockClue",
				"SheriffUnlockProgress",
				"SheriffChangeCriminalState",
				"SheriffChangeCriminalIdentity",
				"SheriffUnlockEnding",
				"SetSubScreenMode",
				"ClientSetSeasonState",
				"ToggleDragActorPlay",
				"SetTargetElementalAbility",
				"ToggleEntityElementalAbility",
				"CaptureElementalBox",
				"ChangeElementalBoxState",
				"SetElementalBoxToTarget",
				"OverrideAbpAnimScheme"
			};
		}
	}
}

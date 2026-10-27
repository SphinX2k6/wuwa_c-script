using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200151E RID: 5406
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ActionParamsConverter : JsonConverter<ActionParams>
	{
		// Token: 0x06007AC8 RID: 31432 RVA: 0x00124EE0 File Offset: 0x001230E0
		[return: Nullable(2)]
		public override ActionParams Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			reader.Skip();
			return null;
		}

		// Token: 0x06007AC9 RID: 31433 RVA: 0x00124EEC File Offset: 0x001230EC
		public override void Write(Utf8JsonWriter writer, ActionParams value, JsonSerializerOptions options)
		{
			IPlayCommonEffect playCommonEffect = value as IPlayCommonEffect;
			if (playCommonEffect != null)
			{
				JsonSerializer.Serialize<IPlayCommonEffect>(writer, playCommonEffect, options);
				return;
			}
			IPlayScreenEffect playScreenEffect = value as IPlayScreenEffect;
			if (playScreenEffect != null)
			{
				JsonSerializer.Serialize<IPlayScreenEffect>(writer, playScreenEffect, options);
				return;
			}
			ISwitchEffectState switchEffectState = value as ISwitchEffectState;
			if (switchEffectState != null)
			{
				JsonSerializer.Serialize<ISwitchEffectState>(writer, switchEffectState, options);
				return;
			}
			IPlayDissolveEffect playDissolveEffect = value as IPlayDissolveEffect;
			if (playDissolveEffect != null)
			{
				JsonSerializer.Serialize<IPlayDissolveEffect>(writer, playDissolveEffect, options);
				return;
			}
			IPlayMpcEffect playMpcEffect = value as IPlayMpcEffect;
			if (playMpcEffect != null)
			{
				JsonSerializer.Serialize<IPlayMpcEffect>(writer, playMpcEffect, options);
				return;
			}
			CompleteGuide completeGuide = value as CompleteGuide;
			if (completeGuide != null)
			{
				JsonSerializer.Serialize<CompleteGuide>(writer, completeGuide, options);
				return;
			}
			IChangeEntityStateDirectly changeEntityStateDirectly = value as IChangeEntityStateDirectly;
			if (changeEntityStateDirectly != null)
			{
				JsonSerializer.Serialize<IChangeEntityStateDirectly>(writer, changeEntityStateDirectly, options);
				return;
			}
			IChangeEntityStateBatchDirectly changeEntityStateBatchDirectly = value as IChangeEntityStateBatchDirectly;
			if (changeEntityStateBatchDirectly != null)
			{
				JsonSerializer.Serialize<IChangeEntityStateBatchDirectly>(writer, changeEntityStateBatchDirectly, options);
				return;
			}
			IChangeEntityStateLoop changeEntityStateLoop = value as IChangeEntityStateLoop;
			if (changeEntityStateLoop != null)
			{
				JsonSerializer.Serialize<IChangeEntityStateLoop>(writer, changeEntityStateLoop, options);
				return;
			}
			IOpenTraceSpline openTraceSpline = value as IOpenTraceSpline;
			if (openTraceSpline != null)
			{
				JsonSerializer.Serialize<IOpenTraceSpline>(writer, openTraceSpline, options);
				return;
			}
			ICloseTraceSpline closeTraceSpline = value as ICloseTraceSpline;
			if (closeTraceSpline != null)
			{
				JsonSerializer.Serialize<ICloseTraceSpline>(writer, closeTraceSpline, options);
				return;
			}
			ISwitchSubLevelsDirectly switchSubLevelsDirectly = value as ISwitchSubLevelsDirectly;
			if (switchSubLevelsDirectly != null)
			{
				JsonSerializer.Serialize<ISwitchSubLevelsDirectly>(writer, switchSubLevelsDirectly, options);
				return;
			}
			IPreloadSubLevels preloadSubLevels = value as IPreloadSubLevels;
			if (preloadSubLevels != null)
			{
				JsonSerializer.Serialize<IPreloadSubLevels>(writer, preloadSubLevels, options);
				return;
			}
			ISwitchPermission switchPermission = value as ISwitchPermission;
			if (switchPermission != null)
			{
				JsonSerializer.Serialize<ISwitchPermission>(writer, switchPermission, options);
				return;
			}
			IEnableAllPlayerOperation enableAllPlayerOperation = value as IEnableAllPlayerOperation;
			if (enableAllPlayerOperation != null)
			{
				JsonSerializer.Serialize<IEnableAllPlayerOperation>(writer, enableAllPlayerOperation, options);
				return;
			}
			IDisableAllPlayerOperation disableAllPlayerOperation = value as IDisableAllPlayerOperation;
			if (disableAllPlayerOperation != null)
			{
				JsonSerializer.Serialize<IDisableAllPlayerOperation>(writer, disableAllPlayerOperation, options);
				return;
			}
			IDisableModulePlayerOperation disableModulePlayerOperation = value as IDisableModulePlayerOperation;
			if (disableModulePlayerOperation != null)
			{
				JsonSerializer.Serialize<IDisableModulePlayerOperation>(writer, disableModulePlayerOperation, options);
				return;
			}
			IClientEnableAllPlayerOperation clientEnableAllPlayerOperation = value as IClientEnableAllPlayerOperation;
			if (clientEnableAllPlayerOperation != null)
			{
				JsonSerializer.Serialize<IClientEnableAllPlayerOperation>(writer, clientEnableAllPlayerOperation, options);
				return;
			}
			IClientDisableAllPlayerOperation clientDisableAllPlayerOperation = value as IClientDisableAllPlayerOperation;
			if (clientDisableAllPlayerOperation != null)
			{
				JsonSerializer.Serialize<IClientDisableAllPlayerOperation>(writer, clientDisableAllPlayerOperation, options);
				return;
			}
			IClientDisableModulePlayerOperation clientDisableModulePlayerOperation = value as IClientDisableModulePlayerOperation;
			if (clientDisableModulePlayerOperation != null)
			{
				JsonSerializer.Serialize<IClientDisableModulePlayerOperation>(writer, clientDisableModulePlayerOperation, options);
				return;
			}
			ITeleportDungeonFunction teleportDungeonFunction = value as ITeleportDungeonFunction;
			if (teleportDungeonFunction != null)
			{
				JsonSerializer.Serialize<ITeleportDungeonFunction>(writer, teleportDungeonFunction, options);
				return;
			}
			IMotorRadioUiFunction motorRadioUiFunction = value as IMotorRadioUiFunction;
			if (motorRadioUiFunction != null)
			{
				JsonSerializer.Serialize<IMotorRadioUiFunction>(writer, motorRadioUiFunction, options);
				return;
			}
			IInteractiveItemsFunction interactiveItemsFunction = value as IInteractiveItemsFunction;
			if (interactiveItemsFunction != null)
			{
				JsonSerializer.Serialize<IInteractiveItemsFunction>(writer, interactiveItemsFunction, options);
				return;
			}
			IHealthBarDisplayClientFunction healthBarDisplayClientFunction = value as IHealthBarDisplayClientFunction;
			if (healthBarDisplayClientFunction != null)
			{
				JsonSerializer.Serialize<IHealthBarDisplayClientFunction>(writer, healthBarDisplayClientFunction, options);
				return;
			}
			IChangeTargetEntityPrefabPerformance changeTargetEntityPrefabPerformance = value as IChangeTargetEntityPrefabPerformance;
			if (changeTargetEntityPrefabPerformance != null)
			{
				JsonSerializer.Serialize<IChangeTargetEntityPrefabPerformance>(writer, changeTargetEntityPrefabPerformance, options);
				return;
			}
			IChangeSelfEntityPrefabPerformance changeSelfEntityPrefabPerformance = value as IChangeSelfEntityPrefabPerformance;
			if (changeSelfEntityPrefabPerformance != null)
			{
				JsonSerializer.Serialize<IChangeSelfEntityPrefabPerformance>(writer, changeSelfEntityPrefabPerformance, options);
				return;
			}
			IModifySelfSceneItemAttributeTag modifySelfSceneItemAttributeTag = value as IModifySelfSceneItemAttributeTag;
			if (modifySelfSceneItemAttributeTag != null)
			{
				JsonSerializer.Serialize<IModifySelfSceneItemAttributeTag>(writer, modifySelfSceneItemAttributeTag, options);
				return;
			}
			IModifyTargetSceneItemAttributeTag modifyTargetSceneItemAttributeTag = value as IModifyTargetSceneItemAttributeTag;
			if (modifyTargetSceneItemAttributeTag != null)
			{
				JsonSerializer.Serialize<IModifyTargetSceneItemAttributeTag>(writer, modifyTargetSceneItemAttributeTag, options);
				return;
			}
			IShowMapMark showMapMark = value as IShowMapMark;
			if (showMapMark != null)
			{
				JsonSerializer.Serialize<IShowMapMark>(writer, showMapMark, options);
				return;
			}
			IHideMapMark hideMapMark = value as IHideMapMark;
			if (hideMapMark != null)
			{
				JsonSerializer.Serialize<IHideMapMark>(writer, hideMapMark, options);
				return;
			}
			IDisableMapMark disableMapMark = value as IDisableMapMark;
			if (disableMapMark != null)
			{
				JsonSerializer.Serialize<IDisableMapMark>(writer, disableMapMark, options);
				return;
			}
			ISetRegionMpc setRegionMpc = value as ISetRegionMpc;
			if (setRegionMpc != null)
			{
				JsonSerializer.Serialize<ISetRegionMpc>(writer, setRegionMpc, options);
				return;
			}
			IShowHighlightExploreSkillIcon showHighlightExploreSkillIcon = value as IShowHighlightExploreSkillIcon;
			if (showHighlightExploreSkillIcon != null)
			{
				JsonSerializer.Serialize<IShowHighlightExploreSkillIcon>(writer, showHighlightExploreSkillIcon, options);
				return;
			}
			IHideHighlightExploreSkillIcon hideHighlightExploreSkillIcon = value as IHideHighlightExploreSkillIcon;
			if (hideHighlightExploreSkillIcon != null)
			{
				JsonSerializer.Serialize<IHideHighlightExploreSkillIcon>(writer, hideHighlightExploreSkillIcon, options);
				return;
			}
			IToggleAndHighlightItem toggleAndHighlightItem = value as IToggleAndHighlightItem;
			if (toggleAndHighlightItem != null)
			{
				JsonSerializer.Serialize<IToggleAndHighlightItem>(writer, toggleAndHighlightItem, options);
				return;
			}
			Invoke invoke = value as Invoke;
			if (invoke != null)
			{
				JsonSerializer.Serialize<Invoke>(writer, invoke, options);
				return;
			}
			Interact interact = value as Interact;
			if (interact != null)
			{
				JsonSerializer.Serialize<Interact>(writer, interact, options);
				return;
			}
			FinishCondition finishCondition = value as FinishCondition;
			if (finishCondition != null)
			{
				JsonSerializer.Serialize<FinishCondition>(writer, finishCondition, options);
				return;
			}
			GetRewardByInteract getRewardByInteract = value as GetRewardByInteract;
			if (getRewardByInteract != null)
			{
				JsonSerializer.Serialize<GetRewardByInteract>(writer, getRewardByInteract, options);
				return;
			}
			WaitUntilLevelSequenceReachMark waitUntilLevelSequenceReachMark = value as WaitUntilLevelSequenceReachMark;
			if (waitUntilLevelSequenceReachMark != null)
			{
				JsonSerializer.Serialize<WaitUntilLevelSequenceReachMark>(writer, waitUntilLevelSequenceReachMark, options);
				return;
			}
			ClearEntityVisibleTag clearEntityVisibleTag = value as ClearEntityVisibleTag;
			if (clearEntityVisibleTag != null)
			{
				JsonSerializer.Serialize<ClearEntityVisibleTag>(writer, clearEntityVisibleTag, options);
				return;
			}
			SetEntityPos setEntityPos = value as SetEntityPos;
			if (setEntityPos != null)
			{
				JsonSerializer.Serialize<SetEntityPos>(writer, setEntityPos, options);
				return;
			}
			ResetEntityPos resetEntityPos = value as ResetEntityPos;
			if (resetEntityPos != null)
			{
				JsonSerializer.Serialize<ResetEntityPos>(writer, resetEntityPos, options);
				return;
			}
			ServerSetPlayerPos serverSetPlayerPos = value as ServerSetPlayerPos;
			if (serverSetPlayerPos != null)
			{
				JsonSerializer.Serialize<ServerSetPlayerPos>(writer, serverSetPlayerPos, options);
				return;
			}
			FixTeleControllerPos fixTeleControllerPos = value as FixTeleControllerPos;
			if (fixTeleControllerPos != null)
			{
				JsonSerializer.Serialize<FixTeleControllerPos>(writer, fixTeleControllerPos, options);
				return;
			}
			IFixTeleControllerResetPos fixTeleControllerResetPos = value as IFixTeleControllerResetPos;
			if (fixTeleControllerResetPos != null)
			{
				JsonSerializer.Serialize<IFixTeleControllerResetPos>(writer, fixTeleControllerResetPos, options);
				return;
			}
			FixFoundationRelation fixFoundationRelation = value as FixFoundationRelation;
			if (fixFoundationRelation != null)
			{
				JsonSerializer.Serialize<FixFoundationRelation>(writer, fixFoundationRelation, options);
				return;
			}
			TraceCurrentQuest traceCurrentQuest = value as TraceCurrentQuest;
			if (traceCurrentQuest != null)
			{
				JsonSerializer.Serialize<TraceCurrentQuest>(writer, traceCurrentQuest, options);
				return;
			}
			FixShowTargetRange fixShowTargetRange = value as FixShowTargetRange;
			if (fixShowTargetRange != null)
			{
				JsonSerializer.Serialize<FixShowTargetRange>(writer, fixShowTargetRange, options);
				return;
			}
			FixGetItem fixGetItem = value as FixGetItem;
			if (fixGetItem != null)
			{
				JsonSerializer.Serialize<FixGetItem>(writer, fixGetItem, options);
				return;
			}
			Log log = value as Log;
			if (log != null)
			{
				JsonSerializer.Serialize<Log>(writer, log, options);
				return;
			}
			ShowMessage showMessage = value as ShowMessage;
			if (showMessage != null)
			{
				JsonSerializer.Serialize<ShowMessage>(writer, showMessage, options);
				return;
			}
			Prompt prompt = value as Prompt;
			if (prompt != null)
			{
				JsonSerializer.Serialize<Prompt>(writer, prompt, options);
				return;
			}
			SendNpcMail sendNpcMail = value as SendNpcMail;
			if (sendNpcMail != null)
			{
				JsonSerializer.Serialize<SendNpcMail>(writer, sendNpcMail, options);
				return;
			}
			AdjustTodTime adjustTodTime = value as AdjustTodTime;
			if (adjustTodTime != null)
			{
				JsonSerializer.Serialize<AdjustTodTime>(writer, adjustTodTime, options);
				return;
			}
			SetAreaTimeState setAreaTimeState = value as SetAreaTimeState;
			if (setAreaTimeState != null)
			{
				JsonSerializer.Serialize<SetAreaTimeState>(writer, setAreaTimeState, options);
				return;
			}
			SetTimeScale setTimeScale = value as SetTimeScale;
			if (setTimeScale != null)
			{
				JsonSerializer.Serialize<SetTimeScale>(writer, setTimeScale, options);
				return;
			}
			JumpTalk jumpTalk = value as JumpTalk;
			if (jumpTalk != null)
			{
				JsonSerializer.Serialize<JumpTalk>(writer, jumpTalk, options);
				return;
			}
			SetHeadIconVisible setHeadIconVisible = value as SetHeadIconVisible;
			if (setHeadIconVisible != null)
			{
				JsonSerializer.Serialize<SetHeadIconVisible>(writer, setHeadIconVisible, options);
				return;
			}
			PlayMontage playMontage = value as PlayMontage;
			if (playMontage != null)
			{
				JsonSerializer.Serialize<PlayMontage>(writer, playMontage, options);
				return;
			}
			AvgPlayRoleAction avgPlayRoleAction = value as AvgPlayRoleAction;
			if (avgPlayRoleAction != null)
			{
				JsonSerializer.Serialize<AvgPlayRoleAction>(writer, avgPlayRoleAction, options);
				return;
			}
			AvgMoveRole avgMoveRole = value as AvgMoveRole;
			if (avgMoveRole != null)
			{
				JsonSerializer.Serialize<AvgMoveRole>(writer, avgMoveRole, options);
				return;
			}
			AvgFocusRole avgFocusRole = value as AvgFocusRole;
			if (avgFocusRole != null)
			{
				JsonSerializer.Serialize<AvgFocusRole>(writer, avgFocusRole, options);
				return;
			}
			AvgShakeUi avgShakeUi = value as AvgShakeUi;
			if (avgShakeUi != null)
			{
				JsonSerializer.Serialize<AvgShakeUi>(writer, avgShakeUi, options);
				return;
			}
			DestroyDynamicEntities destroyDynamicEntities = value as DestroyDynamicEntities;
			if (destroyDynamicEntities != null)
			{
				JsonSerializer.Serialize<DestroyDynamicEntities>(writer, destroyDynamicEntities, options);
				return;
			}
			IActorLookAt actorLookAt = value as IActorLookAt;
			if (actorLookAt != null)
			{
				JsonSerializer.Serialize<IActorLookAt>(writer, actorLookAt, options);
				return;
			}
			IActorTurnTo actorTurnTo = value as IActorTurnTo;
			if (actorTurnTo != null)
			{
				JsonSerializer.Serialize<IActorTurnTo>(writer, actorTurnTo, options);
				return;
			}
			ShowTalk showTalk = value as ShowTalk;
			if (showTalk != null)
			{
				JsonSerializer.Serialize<ShowTalk>(writer, showTalk, options);
				return;
			}
			FinishTalk finishTalk = value as FinishTalk;
			if (finishTalk != null)
			{
				JsonSerializer.Serialize<FinishTalk>(writer, finishTalk, options);
				return;
			}
			ShowCenterText showCenterText = value as ShowCenterText;
			if (showCenterText != null)
			{
				JsonSerializer.Serialize<ShowCenterText>(writer, showCenterText, options);
				return;
			}
			FinishState finishState = value as FinishState;
			if (finishState != null)
			{
				JsonSerializer.Serialize<FinishState>(writer, finishState, options);
				return;
			}
			ChangeState changeState = value as ChangeState;
			if (changeState != null)
			{
				JsonSerializer.Serialize<ChangeState>(writer, changeState, options);
				return;
			}
			ChangeBehaviorState changeBehaviorState = value as ChangeBehaviorState;
			if (changeBehaviorState != null)
			{
				JsonSerializer.Serialize<ChangeBehaviorState>(writer, changeBehaviorState, options);
				return;
			}
			SetBehaviorIsPaused setBehaviorIsPaused = value as SetBehaviorIsPaused;
			if (setBehaviorIsPaused != null)
			{
				JsonSerializer.Serialize<SetBehaviorIsPaused>(writer, setBehaviorIsPaused, options);
				return;
			}
			ChangeRandomState changeRandomState = value as ChangeRandomState;
			if (changeRandomState != null)
			{
				JsonSerializer.Serialize<ChangeRandomState>(writer, changeRandomState, options);
				return;
			}
			ChangeActorState changeActorState = value as ChangeActorState;
			if (changeActorState != null)
			{
				JsonSerializer.Serialize<ChangeActorState>(writer, changeActorState, options);
				return;
			}
			ChangeOtherState changeOtherState = value as ChangeOtherState;
			if (changeOtherState != null)
			{
				JsonSerializer.Serialize<ChangeOtherState>(writer, changeOtherState, options);
				return;
			}
			SetCameraMode setCameraMode = value as SetCameraMode;
			if (setCameraMode != null)
			{
				JsonSerializer.Serialize<SetCameraMode>(writer, setCameraMode, options);
				return;
			}
			SetPlotMode setPlotMode = value as SetPlotMode;
			if (setPlotMode != null)
			{
				JsonSerializer.Serialize<SetPlotMode>(writer, setPlotMode, options);
				return;
			}
			PlaySequenceData playSequenceData = value as PlaySequenceData;
			if (playSequenceData != null)
			{
				JsonSerializer.Serialize<PlaySequenceData>(writer, playSequenceData, options);
				return;
			}
			PlayCustomSequence playCustomSequence = value as PlayCustomSequence;
			if (playCustomSequence != null)
			{
				JsonSerializer.Serialize<PlayCustomSequence>(writer, playCustomSequence, options);
				return;
			}
			PlayMovie playMovie = value as PlayMovie;
			if (playMovie != null)
			{
				JsonSerializer.Serialize<PlayMovie>(writer, playMovie, options);
				return;
			}
			PlayEffect playEffect = value as PlayEffect;
			if (playEffect != null)
			{
				JsonSerializer.Serialize<PlayEffect>(writer, playEffect, options);
				return;
			}
			PlayEffect2 playEffect2 = value as PlayEffect2;
			if (playEffect2 != null)
			{
				JsonSerializer.Serialize<PlayEffect2>(writer, playEffect2, options);
				return;
			}
			RemoveEffect removeEffect = value as RemoveEffect;
			if (removeEffect != null)
			{
				JsonSerializer.Serialize<RemoveEffect>(writer, removeEffect, options);
				return;
			}
			Wait wait = value as Wait;
			if (wait != null)
			{
				JsonSerializer.Serialize<Wait>(writer, wait, options);
				return;
			}
			MoveToPosA moveToPosA = value as MoveToPosA;
			if (moveToPosA != null)
			{
				JsonSerializer.Serialize<MoveToPosA>(writer, moveToPosA, options);
				return;
			}
			SetMoveSpeed setMoveSpeed = value as SetMoveSpeed;
			if (setMoveSpeed != null)
			{
				JsonSerializer.Serialize<SetMoveSpeed>(writer, setMoveSpeed, options);
				return;
			}
			SetPosA setPosA = value as SetPosA;
			if (setPosA != null)
			{
				JsonSerializer.Serialize<SetPosA>(writer, setPosA, options);
				return;
			}
			FaceToPos faceToPos = value as FaceToPos;
			if (faceToPos != null)
			{
				JsonSerializer.Serialize<FaceToPos>(writer, faceToPos, options);
				return;
			}
			SpawnChild spawnChild = value as SpawnChild;
			if (spawnChild != null)
			{
				JsonSerializer.Serialize<SpawnChild>(writer, spawnChild, options);
				return;
			}
			SimpleMove simpleMove = value as SimpleMove;
			if (simpleMove != null)
			{
				JsonSerializer.Serialize<SimpleMove>(writer, simpleMove, options);
				return;
			}
			SetNumberVar setNumberVar = value as SetNumberVar;
			if (setNumberVar != null)
			{
				JsonSerializer.Serialize<SetNumberVar>(writer, setNumberVar, options);
				return;
			}
			SyncVarToActorState syncVarToActorState = value as SyncVarToActorState;
			if (syncVarToActorState != null)
			{
				JsonSerializer.Serialize<SyncVarToActorState>(writer, syncVarToActorState, options);
				return;
			}
			DoCalculate doCalculate = value as DoCalculate;
			if (doCalculate != null)
			{
				JsonSerializer.Serialize<DoCalculate>(writer, doCalculate, options);
				return;
			}
			CallByCondition callByCondition = value as CallByCondition;
			if (callByCondition != null)
			{
				JsonSerializer.Serialize<CallByCondition>(writer, callByCondition, options);
				return;
			}
			CallFunction callFunction = value as CallFunction;
			if (callFunction != null)
			{
				JsonSerializer.Serialize<CallFunction>(writer, callFunction, options);
				return;
			}
			AddFlowInteractOption addFlowInteractOption = value as AddFlowInteractOption;
			if (addFlowInteractOption != null)
			{
				JsonSerializer.Serialize<AddFlowInteractOption>(writer, addFlowInteractOption, options);
				return;
			}
			RemoveFlowInteractOption removeFlowInteractOption = value as RemoveFlowInteractOption;
			if (removeFlowInteractOption != null)
			{
				JsonSerializer.Serialize<RemoveFlowInteractOption>(writer, removeFlowInteractOption, options);
				return;
			}
			ChangeInteractOptionText changeInteractOptionText = value as ChangeInteractOptionText;
			if (changeInteractOptionText != null)
			{
				JsonSerializer.Serialize<ChangeInteractOptionText>(writer, changeInteractOptionText, options);
				return;
			}
			SpawnEntity spawnEntity = value as SpawnEntity;
			if (spawnEntity != null)
			{
				JsonSerializer.Serialize<SpawnEntity>(writer, spawnEntity, options);
				return;
			}
			DestroyAllChild destroyAllChild = value as DestroyAllChild;
			if (destroyAllChild != null)
			{
				JsonSerializer.Serialize<DestroyAllChild>(writer, destroyAllChild, options);
				return;
			}
			DestroyEntity destroyEntity = value as DestroyEntity;
			if (destroyEntity != null)
			{
				JsonSerializer.Serialize<DestroyEntity>(writer, destroyEntity, options);
				return;
			}
			PlayFlow playFlow = value as PlayFlow;
			if (playFlow != null)
			{
				JsonSerializer.Serialize<PlayFlow>(writer, playFlow, options);
				return;
			}
			IBubbleData bubbleData = value as IBubbleData;
			if (bubbleData != null)
			{
				JsonSerializer.Serialize<IBubbleData>(writer, bubbleData, options);
				return;
			}
			PlayerLookAt playerLookAt = value as PlayerLookAt;
			if (playerLookAt != null)
			{
				JsonSerializer.Serialize<PlayerLookAt>(writer, playerLookAt, options);
				return;
			}
			EntityLookAt entityLookAt = value as EntityLookAt;
			if (entityLookAt != null)
			{
				JsonSerializer.Serialize<EntityLookAt>(writer, entityLookAt, options);
				return;
			}
			CharacterLookAt characterLookAt = value as CharacterLookAt;
			if (characterLookAt != null)
			{
				JsonSerializer.Serialize<CharacterLookAt>(writer, characterLookAt, options);
				return;
			}
			PlayerLookTowards playerLookTowards = value as PlayerLookTowards;
			if (playerLookTowards != null)
			{
				JsonSerializer.Serialize<PlayerLookTowards>(writer, playerLookTowards, options);
				return;
			}
			EntityTurnTo entityTurnTo = value as EntityTurnTo;
			if (entityTurnTo != null)
			{
				JsonSerializer.Serialize<EntityTurnTo>(writer, entityTurnTo, options);
				return;
			}
			CameraLookAt cameraLookAt = value as CameraLookAt;
			if (cameraLookAt != null)
			{
				JsonSerializer.Serialize<CameraLookAt>(writer, cameraLookAt, options);
				return;
			}
			StopCameraLookAt stopCameraLookAt = value as StopCameraLookAt;
			if (stopCameraLookAt != null)
			{
				JsonSerializer.Serialize<StopCameraLookAt>(writer, stopCameraLookAt, options);
				return;
			}
			SetVar setVar = value as SetVar;
			if (setVar != null)
			{
				JsonSerializer.Serialize<SetVar>(writer, setVar, options);
				return;
			}
			SetActorVar setActorVar = value as SetActorVar;
			if (setActorVar != null)
			{
				JsonSerializer.Serialize<SetActorVar>(writer, setActorVar, options);
				return;
			}
			CalculateVar calculateVar = value as CalculateVar;
			if (calculateVar != null)
			{
				JsonSerializer.Serialize<CalculateVar>(writer, calculateVar, options);
				return;
			}
			RandomVar randomVar = value as RandomVar;
			if (randomVar != null)
			{
				JsonSerializer.Serialize<RandomVar>(writer, randomVar, options);
				return;
			}
			GuideTrigger guideTrigger = value as GuideTrigger;
			if (guideTrigger != null)
			{
				JsonSerializer.Serialize<GuideTrigger>(writer, guideTrigger, options);
				return;
			}
			GetItem getItem = value as GetItem;
			if (getItem != null)
			{
				JsonSerializer.Serialize<GetItem>(writer, getItem, options);
				return;
			}
			DestroyQuestItem destroyQuestItem = value as DestroyQuestItem;
			if (destroyQuestItem != null)
			{
				JsonSerializer.Serialize<DestroyQuestItem>(writer, destroyQuestItem, options);
				return;
			}
			AwakeEntity awakeEntity = value as AwakeEntity;
			if (awakeEntity != null)
			{
				JsonSerializer.Serialize<AwakeEntity>(writer, awakeEntity, options);
				return;
			}
			SetEntityVisible setEntityVisible = value as SetEntityVisible;
			if (setEntityVisible != null)
			{
				JsonSerializer.Serialize<SetEntityVisible>(writer, setEntityVisible, options);
				return;
			}
			SetEntityClientVisible setEntityClientVisible = value as SetEntityClientVisible;
			if (setEntityClientVisible != null)
			{
				JsonSerializer.Serialize<SetEntityClientVisible>(writer, setEntityClientVisible, options);
				return;
			}
			SetEntityClientVisibleSave setEntityClientVisibleSave = value as SetEntityClientVisibleSave;
			if (setEntityClientVisibleSave != null)
			{
				JsonSerializer.Serialize<SetEntityClientVisibleSave>(writer, setEntityClientVisibleSave, options);
				return;
			}
			LockEntity lockEntity = value as LockEntity;
			if (lockEntity != null)
			{
				JsonSerializer.Serialize<LockEntity>(writer, lockEntity, options);
				return;
			}
			UnlockEntity unlockEntity = value as UnlockEntity;
			if (unlockEntity != null)
			{
				JsonSerializer.Serialize<UnlockEntity>(writer, unlockEntity, options);
				return;
			}
			CompleteChildQuest completeChildQuest = value as CompleteChildQuest;
			if (completeChildQuest != null)
			{
				JsonSerializer.Serialize<CompleteChildQuest>(writer, completeChildQuest, options);
				return;
			}
			AcceptCurrentQuest acceptCurrentQuest = value as AcceptCurrentQuest;
			if (acceptCurrentQuest != null)
			{
				JsonSerializer.Serialize<AcceptCurrentQuest>(writer, acceptCurrentQuest, options);
				return;
			}
			FinishDoInteract finishDoInteract = value as FinishDoInteract;
			if (finishDoInteract != null)
			{
				JsonSerializer.Serialize<FinishDoInteract>(writer, finishDoInteract, options);
				return;
			}
			AddBuffToEntity addBuffToEntity = value as AddBuffToEntity;
			if (addBuffToEntity != null)
			{
				JsonSerializer.Serialize<AddBuffToEntity>(writer, addBuffToEntity, options);
				return;
			}
			AddBuffToPlayer addBuffToPlayer = value as AddBuffToPlayer;
			if (addBuffToPlayer != null)
			{
				JsonSerializer.Serialize<AddBuffToPlayer>(writer, addBuffToPlayer, options);
				return;
			}
			AddBuffToFollowShooter addBuffToFollowShooter = value as AddBuffToFollowShooter;
			if (addBuffToFollowShooter != null)
			{
				JsonSerializer.Serialize<AddBuffToFollowShooter>(writer, addBuffToFollowShooter, options);
				return;
			}
			OpenSystemBoard openSystemBoard = value as OpenSystemBoard;
			if (openSystemBoard != null)
			{
				JsonSerializer.Serialize<OpenSystemBoard>(writer, openSystemBoard, options);
				return;
			}
			OpenSystemFunction openSystemFunction = value as OpenSystemFunction;
			if (openSystemFunction != null)
			{
				JsonSerializer.Serialize<OpenSystemFunction>(writer, openSystemFunction, options);
				return;
			}
			ChangeEntityState changeEntityState = value as ChangeEntityState;
			if (changeEntityState != null)
			{
				JsonSerializer.Serialize<ChangeEntityState>(writer, changeEntityState, options);
				return;
			}
			ChangeNpcPerformState changeNpcPerformState = value as ChangeNpcPerformState;
			if (changeNpcPerformState != null)
			{
				JsonSerializer.Serialize<ChangeNpcPerformState>(writer, changeNpcPerformState, options);
				return;
			}
			SetForceLock setForceLock = value as SetForceLock;
			if (setForceLock != null)
			{
				JsonSerializer.Serialize<SetForceLock>(writer, setForceLock, options);
				return;
			}
			SetAreaState setAreaState = value as SetAreaState;
			if (setAreaState != null)
			{
				JsonSerializer.Serialize<SetAreaState>(writer, setAreaState, options);
				return;
			}
			SetWuYinQuState setWuYinQuState = value as SetWuYinQuState;
			if (setWuYinQuState != null)
			{
				JsonSerializer.Serialize<SetWuYinQuState>(writer, setWuYinQuState, options);
				return;
			}
			RemoveBuffFromEntity removeBuffFromEntity = value as RemoveBuffFromEntity;
			if (removeBuffFromEntity != null)
			{
				JsonSerializer.Serialize<RemoveBuffFromEntity>(writer, removeBuffFromEntity, options);
				return;
			}
			RemoveBuffFromPlayer removeBuffFromPlayer = value as RemoveBuffFromPlayer;
			if (removeBuffFromPlayer != null)
			{
				JsonSerializer.Serialize<RemoveBuffFromPlayer>(writer, removeBuffFromPlayer, options);
				return;
			}
			Collect collect = value as Collect;
			if (collect != null)
			{
				JsonSerializer.Serialize<Collect>(writer, collect, options);
				return;
			}
			Destroy destroy = value as Destroy;
			if (destroy != null)
			{
				JsonSerializer.Serialize<Destroy>(writer, destroy, options);
				return;
			}
			DestroySelf destroySelf = value as DestroySelf;
			if (destroySelf != null)
			{
				JsonSerializer.Serialize<DestroySelf>(writer, destroySelf, options);
				return;
			}
			SetPlayerMoveControl setPlayerMoveControl = value as SetPlayerMoveControl;
			if (setPlayerMoveControl != null)
			{
				JsonSerializer.Serialize<SetPlayerMoveControl>(writer, setPlayerMoveControl, options);
				return;
			}
			UnlockTeleportTrigger unlockTeleportTrigger = value as UnlockTeleportTrigger;
			if (unlockTeleportTrigger != null)
			{
				JsonSerializer.Serialize<UnlockTeleportTrigger>(writer, unlockTeleportTrigger, options);
				return;
			}
			ChangeTeamPosition changeTeamPosition = value as ChangeTeamPosition;
			if (changeTeamPosition != null)
			{
				JsonSerializer.Serialize<ChangeTeamPosition>(writer, changeTeamPosition, options);
				return;
			}
			ClientChangeTeamPosition clientChangeTeamPosition = value as ClientChangeTeamPosition;
			if (clientChangeTeamPosition != null)
			{
				JsonSerializer.Serialize<ClientChangeTeamPosition>(writer, clientChangeTeamPosition, options);
				return;
			}
			ClaimLevelPlayReward claimLevelPlayReward = value as ClaimLevelPlayReward;
			if (claimLevelPlayReward != null)
			{
				JsonSerializer.Serialize<ClaimLevelPlayReward>(writer, claimLevelPlayReward, options);
				return;
			}
			ClaimDynamicEntityReward claimDynamicEntityReward = value as ClaimDynamicEntityReward;
			if (claimDynamicEntityReward != null)
			{
				JsonSerializer.Serialize<ClaimDynamicEntityReward>(writer, claimDynamicEntityReward, options);
				return;
			}
			ClearFishingCabinInSaleItems clearFishingCabinInSaleItems = value as ClearFishingCabinInSaleItems;
			if (clearFishingCabinInSaleItems != null)
			{
				JsonSerializer.Serialize<ClearFishingCabinInSaleItems>(writer, clearFishingCabinInSaleItems, options);
				return;
			}
			AcceptFishingEntrust acceptFishingEntrust = value as AcceptFishingEntrust;
			if (acceptFishingEntrust != null)
			{
				JsonSerializer.Serialize<AcceptFishingEntrust>(writer, acceptFishingEntrust, options);
				return;
			}
			DestroyFishingBoat destroyFishingBoat = value as DestroyFishingBoat;
			if (destroyFishingBoat != null)
			{
				JsonSerializer.Serialize<DestroyFishingBoat>(writer, destroyFishingBoat, options);
				return;
			}
			TeleportDungeon teleportDungeon = value as TeleportDungeon;
			if (teleportDungeon != null)
			{
				JsonSerializer.Serialize<TeleportDungeon>(writer, teleportDungeon, options);
				return;
			}
			StopUiScreenEffect stopUiScreenEffect = value as StopUiScreenEffect;
			if (stopUiScreenEffect != null)
			{
				JsonSerializer.Serialize<StopUiScreenEffect>(writer, stopUiScreenEffect, options);
				return;
			}
			ClaimDungeonReward claimDungeonReward = value as ClaimDungeonReward;
			if (claimDungeonReward != null)
			{
				JsonSerializer.Serialize<ClaimDungeonReward>(writer, claimDungeonReward, options);
				return;
			}
			SettlementDungeon settlementDungeon = value as SettlementDungeon;
			if (settlementDungeon != null)
			{
				JsonSerializer.Serialize<SettlementDungeon>(writer, settlementDungeon, options);
				return;
			}
			ExitDungeon exitDungeon = value as ExitDungeon;
			if (exitDungeon != null)
			{
				JsonSerializer.Serialize<ExitDungeon>(writer, exitDungeon, options);
				return;
			}
			UnlockDungeonEntry unlockDungeonEntry = value as UnlockDungeonEntry;
			if (unlockDungeonEntry != null)
			{
				JsonSerializer.Serialize<UnlockDungeonEntry>(writer, unlockDungeonEntry, options);
				return;
			}
			FinishDungeon finishDungeon = value as FinishDungeon;
			if (finishDungeon != null)
			{
				JsonSerializer.Serialize<FinishDungeon>(writer, finishDungeon, options);
				return;
			}
			SetReviveRegion setReviveRegion = value as SetReviveRegion;
			if (setReviveRegion != null)
			{
				JsonSerializer.Serialize<SetReviveRegion>(writer, setReviveRegion, options);
				return;
			}
			PromptQuestChapterUI promptQuestChapterUI = value as PromptQuestChapterUI;
			if (promptQuestChapterUI != null)
			{
				JsonSerializer.Serialize<PromptQuestChapterUI>(writer, promptQuestChapterUI, options);
				return;
			}
			FireBullet fireBullet = value as FireBullet;
			if (fireBullet != null)
			{
				JsonSerializer.Serialize<FireBullet>(writer, fireBullet, options);
				return;
			}
			FireBulletEffect fireBulletEffect = value as FireBulletEffect;
			if (fireBulletEffect != null)
			{
				JsonSerializer.Serialize<FireBulletEffect>(writer, fireBulletEffect, options);
				return;
			}
			SetPlayerPos setPlayerPos = value as SetPlayerPos;
			if (setPlayerPos != null)
			{
				JsonSerializer.Serialize<SetPlayerPos>(writer, setPlayerPos, options);
				return;
			}
			ClientSetPlayerPos clientSetPlayerPos = value as ClientSetPlayerPos;
			if (clientSetPlayerPos != null)
			{
				JsonSerializer.Serialize<ClientSetPlayerPos>(writer, clientSetPlayerPos, options);
				return;
			}
			ClientPreEnableSubLevels clientPreEnableSubLevels = value as ClientPreEnableSubLevels;
			if (clientPreEnableSubLevels != null)
			{
				JsonSerializer.Serialize<ClientPreEnableSubLevels>(writer, clientPreEnableSubLevels, options);
				return;
			}
			RogueGotoNextFloor rogueGotoNextFloor = value as RogueGotoNextFloor;
			if (rogueGotoNextFloor != null)
			{
				JsonSerializer.Serialize<RogueGotoNextFloor>(writer, rogueGotoNextFloor, options);
				return;
			}
			RogueSelectRoom rogueSelectRoom = value as RogueSelectRoom;
			if (rogueSelectRoom != null)
			{
				JsonSerializer.Serialize<RogueSelectRoom>(writer, rogueSelectRoom, options);
				return;
			}
			RogueActivatePortal rogueActivatePortal = value as RogueActivatePortal;
			if (rogueActivatePortal != null)
			{
				JsonSerializer.Serialize<RogueActivatePortal>(writer, rogueActivatePortal, options);
				return;
			}
			RogueReceiveReward rogueReceiveReward = value as RogueReceiveReward;
			if (rogueReceiveReward != null)
			{
				JsonSerializer.Serialize<RogueReceiveReward>(writer, rogueReceiveReward, options);
				return;
			}
			ChangeSelfEntityState changeSelfEntityState = value as ChangeSelfEntityState;
			if (changeSelfEntityState != null)
			{
				JsonSerializer.Serialize<ChangeSelfEntityState>(writer, changeSelfEntityState, options);
				return;
			}
			InterludeActions interludeActions = value as InterludeActions;
			if (interludeActions != null)
			{
				JsonSerializer.Serialize<InterludeActions>(writer, interludeActions, options);
				return;
			}
			AddBuffToTriggeredEntity addBuffToTriggeredEntity = value as AddBuffToTriggeredEntity;
			if (addBuffToTriggeredEntity != null)
			{
				JsonSerializer.Serialize<AddBuffToTriggeredEntity>(writer, addBuffToTriggeredEntity, options);
				return;
			}
			RemoveBuffToTriggeredEntity removeBuffToTriggeredEntity = value as RemoveBuffToTriggeredEntity;
			if (removeBuffToTriggeredEntity != null)
			{
				JsonSerializer.Serialize<RemoveBuffToTriggeredEntity>(writer, removeBuffToTriggeredEntity, options);
				return;
			}
			DetectTrigger detectTrigger = value as DetectTrigger;
			if (detectTrigger != null)
			{
				JsonSerializer.Serialize<DetectTrigger>(writer, detectTrigger, options);
				return;
			}
			ItemFoundationMatch itemFoundationMatch = value as ItemFoundationMatch;
			if (itemFoundationMatch != null)
			{
				JsonSerializer.Serialize<ItemFoundationMatch>(writer, itemFoundationMatch, options);
				return;
			}
			SetBattleState setBattleState = value as SetBattleState;
			if (setBattleState != null)
			{
				JsonSerializer.Serialize<SetBattleState>(writer, setBattleState, options);
				return;
			}
			ExecBattleAction execBattleAction = value as ExecBattleAction;
			if (execBattleAction != null)
			{
				JsonSerializer.Serialize<ExecBattleAction>(writer, execBattleAction, options);
				return;
			}
			IExecClientMonsterNpcInteract execClientMonsterNpcInteract = value as IExecClientMonsterNpcInteract;
			if (execClientMonsterNpcInteract != null)
			{
				JsonSerializer.Serialize<IExecClientMonsterNpcInteract>(writer, execClientMonsterNpcInteract, options);
				return;
			}
			ExecClientBattleAction execClientBattleAction = value as ExecClientBattleAction;
			if (execClientBattleAction != null)
			{
				JsonSerializer.Serialize<ExecClientBattleAction>(writer, execClientBattleAction, options);
				return;
			}
			WaitBattleCondition waitBattleCondition = value as WaitBattleCondition;
			if (waitBattleCondition != null)
			{
				JsonSerializer.Serialize<WaitBattleCondition>(writer, waitBattleCondition, options);
				return;
			}
			EnableHostility enableHostility = value as EnableHostility;
			if (enableHostility != null)
			{
				JsonSerializer.Serialize<EnableHostility>(writer, enableHostility, options);
				return;
			}
			UnlockSystemItem unlockSystemItem = value as UnlockSystemItem;
			if (unlockSystemItem != null)
			{
				JsonSerializer.Serialize<UnlockSystemItem>(writer, unlockSystemItem, options);
				return;
			}
			ClientUnlockAchievementSystemItem clientUnlockAchievementSystemItem = value as ClientUnlockAchievementSystemItem;
			if (clientUnlockAchievementSystemItem != null)
			{
				JsonSerializer.Serialize<ClientUnlockAchievementSystemItem>(writer, clientUnlockAchievementSystemItem, options);
				return;
			}
			AddPlayBubble addPlayBubble = value as AddPlayBubble;
			if (addPlayBubble != null)
			{
				JsonSerializer.Serialize<AddPlayBubble>(writer, addPlayBubble, options);
				return;
			}
			PlayBubble playBubble = value as PlayBubble;
			if (playBubble != null)
			{
				JsonSerializer.Serialize<PlayBubble>(writer, playBubble, options);
				return;
			}
			ClearPlayBubble clearPlayBubble = value as ClearPlayBubble;
			if (clearPlayBubble != null)
			{
				JsonSerializer.Serialize<ClearPlayBubble>(writer, clearPlayBubble, options);
				return;
			}
			MoveWithSpline moveWithSpline = value as MoveWithSpline;
			if (moveWithSpline != null)
			{
				JsonSerializer.Serialize<MoveWithSpline>(writer, moveWithSpline, options);
				return;
			}
			NewMoveWithSpline newMoveWithSpline = value as NewMoveWithSpline;
			if (newMoveWithSpline != null)
			{
				JsonSerializer.Serialize<NewMoveWithSpline>(writer, newMoveWithSpline, options);
				return;
			}
			StopNewMoveWithSpline stopNewMoveWithSpline = value as StopNewMoveWithSpline;
			if (stopNewMoveWithSpline != null)
			{
				JsonSerializer.Serialize<StopNewMoveWithSpline>(writer, stopNewMoveWithSpline, options);
				return;
			}
			CharacterMoveToPoint characterMoveToPoint = value as CharacterMoveToPoint;
			if (characterMoveToPoint != null)
			{
				JsonSerializer.Serialize<CharacterMoveToPoint>(writer, characterMoveToPoint, options);
				return;
			}
			PlayerMoveToPoint playerMoveToPoint = value as PlayerMoveToPoint;
			if (playerMoveToPoint != null)
			{
				JsonSerializer.Serialize<PlayerMoveToPoint>(writer, playerMoveToPoint, options);
				return;
			}
			NpcMoveToPoint npcMoveToPoint = value as NpcMoveToPoint;
			if (npcMoveToPoint != null)
			{
				JsonSerializer.Serialize<NpcMoveToPoint>(writer, npcMoveToPoint, options);
				return;
			}
			ToggleScanSplineEffect toggleScanSplineEffect = value as ToggleScanSplineEffect;
			if (toggleScanSplineEffect != null)
			{
				JsonSerializer.Serialize<ToggleScanSplineEffect>(writer, toggleScanSplineEffect, options);
				return;
			}
			TraceSpline traceSpline = value as TraceSpline;
			if (traceSpline != null)
			{
				JsonSerializer.Serialize<TraceSpline>(writer, traceSpline, options);
				return;
			}
			EnableAI enableAI = value as EnableAI;
			if (enableAI != null)
			{
				JsonSerializer.Serialize<EnableAI>(writer, enableAI, options);
				return;
			}
			RunActions runActions = value as RunActions;
			if (runActions != null)
			{
				JsonSerializer.Serialize<RunActions>(writer, runActions, options);
				return;
			}
			CommonTip commonTip = value as CommonTip;
			if (commonTip != null)
			{
				JsonSerializer.Serialize<CommonTip>(writer, commonTip, options);
				return;
			}
			CommonTip2 commonTip2 = value as CommonTip2;
			if (commonTip2 != null)
			{
				JsonSerializer.Serialize<CommonTip2>(writer, commonTip2, options);
				return;
			}
			EndCommonTip endCommonTip = value as EndCommonTip;
			if (endCommonTip != null)
			{
				JsonSerializer.Serialize<EndCommonTip>(writer, endCommonTip, options);
				return;
			}
			EnableNearbyTracking enableNearbyTracking = value as EnableNearbyTracking;
			if (enableNearbyTracking != null)
			{
				JsonSerializer.Serialize<EnableNearbyTracking>(writer, enableNearbyTracking, options);
				return;
			}
			SendAiEvent sendAiEvent = value as SendAiEvent;
			if (sendAiEvent != null)
			{
				JsonSerializer.Serialize<SendAiEvent>(writer, sendAiEvent, options);
				return;
			}
			EnableLevelPlay enableLevelPlay = value as EnableLevelPlay;
			if (enableLevelPlay != null)
			{
				JsonSerializer.Serialize<EnableLevelPlay>(writer, enableLevelPlay, options);
				return;
			}
			ServerForceEnableLevelPlay serverForceEnableLevelPlay = value as ServerForceEnableLevelPlay;
			if (serverForceEnableLevelPlay != null)
			{
				JsonSerializer.Serialize<ServerForceEnableLevelPlay>(writer, serverForceEnableLevelPlay, options);
				return;
			}
			TeleportDungeonPos teleportDungeonPos = value as TeleportDungeonPos;
			if (teleportDungeonPos != null)
			{
				JsonSerializer.Serialize<TeleportDungeonPos>(writer, teleportDungeonPos, options);
				return;
			}
			FadeInScreen fadeInScreen = value as FadeInScreen;
			if (fadeInScreen != null)
			{
				JsonSerializer.Serialize<FadeInScreen>(writer, fadeInScreen, options);
				return;
			}
			FadeOutScreen fadeOutScreen = value as FadeOutScreen;
			if (fadeOutScreen != null)
			{
				JsonSerializer.Serialize<FadeOutScreen>(writer, fadeOutScreen, options);
				return;
			}
			StartFlowTemplate startFlowTemplate = value as StartFlowTemplate;
			if (startFlowTemplate != null)
			{
				JsonSerializer.Serialize<StartFlowTemplate>(writer, startFlowTemplate, options);
				return;
			}
			EndFlowTemplate endFlowTemplate = value as EndFlowTemplate;
			if (endFlowTemplate != null)
			{
				JsonSerializer.Serialize<EndFlowTemplate>(writer, endFlowTemplate, options);
				return;
			}
			CloseFlowTemplate closeFlowTemplate = value as CloseFlowTemplate;
			if (closeFlowTemplate != null)
			{
				JsonSerializer.Serialize<CloseFlowTemplate>(writer, closeFlowTemplate, options);
				return;
			}
			ChangeFlowTemplate changeFlowTemplate = value as ChangeFlowTemplate;
			if (changeFlowTemplate != null)
			{
				JsonSerializer.Serialize<ChangeFlowTemplate>(writer, changeFlowTemplate, options);
				return;
			}
			BeginFlowTemplate beginFlowTemplate = value as BeginFlowTemplate;
			if (beginFlowTemplate != null)
			{
				JsonSerializer.Serialize<BeginFlowTemplate>(writer, beginFlowTemplate, options);
				return;
			}
			SetFlowTemplate setFlowTemplate = value as SetFlowTemplate;
			if (setFlowTemplate != null)
			{
				JsonSerializer.Serialize<SetFlowTemplate>(writer, setFlowTemplate, options);
				return;
			}
			HideTargetRange hideTargetRange = value as HideTargetRange;
			if (hideTargetRange != null)
			{
				JsonSerializer.Serialize<HideTargetRange>(writer, hideTargetRange, options);
				return;
			}
			ShowTargetRange showTargetRange = value as ShowTargetRange;
			if (showTargetRange != null)
			{
				JsonSerializer.Serialize<ShowTargetRange>(writer, showTargetRange, options);
				return;
			}
			HideSpecificEntities hideSpecificEntities = value as HideSpecificEntities;
			if (hideSpecificEntities != null)
			{
				JsonSerializer.Serialize<HideSpecificEntities>(writer, hideSpecificEntities, options);
				return;
			}
			ShowSpecificEntities showSpecificEntities = value as ShowSpecificEntities;
			if (showSpecificEntities != null)
			{
				JsonSerializer.Serialize<ShowSpecificEntities>(writer, showSpecificEntities, options);
				return;
			}
			HideGroup hideGroup = value as HideGroup;
			if (hideGroup != null)
			{
				JsonSerializer.Serialize<HideGroup>(writer, hideGroup, options);
				return;
			}
			ShowHidedGroup showHidedGroup = value as ShowHidedGroup;
			if (showHidedGroup != null)
			{
				JsonSerializer.Serialize<ShowHidedGroup>(writer, showHidedGroup, options);
				return;
			}
			SetSubScreenMode setSubScreenMode = value as SetSubScreenMode;
			if (setSubScreenMode != null)
			{
				JsonSerializer.Serialize<SetSubScreenMode>(writer, setSubScreenMode, options);
				return;
			}
			ToggleDragActorPlay toggleDragActorPlay = value as ToggleDragActorPlay;
			if (toggleDragActorPlay != null)
			{
				JsonSerializer.Serialize<ToggleDragActorPlay>(writer, toggleDragActorPlay, options);
				return;
			}
			ManualOccupations manualOccupations = value as ManualOccupations;
			if (manualOccupations != null)
			{
				JsonSerializer.Serialize<ManualOccupations>(writer, manualOccupations, options);
				return;
			}
			ForceOccupations forceOccupations = value as ForceOccupations;
			if (forceOccupations != null)
			{
				JsonSerializer.Serialize<ForceOccupations>(writer, forceOccupations, options);
				return;
			}
			ChangeFightTeam changeFightTeam = value as ChangeFightTeam;
			if (changeFightTeam != null)
			{
				JsonSerializer.Serialize<ChangeFightTeam>(writer, changeFightTeam, options);
				return;
			}
			IActiveRange activeRange = value as IActiveRange;
			if (activeRange != null)
			{
				JsonSerializer.Serialize<IActiveRange>(writer, activeRange, options);
				return;
			}
			AddTrialCharacter addTrialCharacter = value as AddTrialCharacter;
			if (addTrialCharacter != null)
			{
				JsonSerializer.Serialize<AddTrialCharacter>(writer, addTrialCharacter, options);
				return;
			}
			UpdateTrialCharacter updateTrialCharacter = value as UpdateTrialCharacter;
			if (updateTrialCharacter != null)
			{
				JsonSerializer.Serialize<UpdateTrialCharacter>(writer, updateTrialCharacter, options);
				return;
			}
			RestoreTrialCharacter restoreTrialCharacter = value as RestoreTrialCharacter;
			if (restoreTrialCharacter != null)
			{
				JsonSerializer.Serialize<RestoreTrialCharacter>(writer, restoreTrialCharacter, options);
				return;
			}
			RemoveTrialCharacter removeTrialCharacter = value as RemoveTrialCharacter;
			if (removeTrialCharacter != null)
			{
				JsonSerializer.Serialize<RemoveTrialCharacter>(writer, removeTrialCharacter, options);
				return;
			}
			AddGuestCharacter addGuestCharacter = value as AddGuestCharacter;
			if (addGuestCharacter != null)
			{
				JsonSerializer.Serialize<AddGuestCharacter>(writer, addGuestCharacter, options);
				return;
			}
			RemoveGuestCharacter removeGuestCharacter = value as RemoveGuestCharacter;
			if (removeGuestCharacter != null)
			{
				JsonSerializer.Serialize<RemoveGuestCharacter>(writer, removeGuestCharacter, options);
				return;
			}
			DestroyQuest destroyQuest = value as DestroyQuest;
			if (destroyQuest != null)
			{
				JsonSerializer.Serialize<DestroyQuest>(writer, destroyQuest, options);
				return;
			}
			SetCameraAnim setCameraAnim = value as SetCameraAnim;
			if (setCameraAnim != null)
			{
				JsonSerializer.Serialize<SetCameraAnim>(writer, setCameraAnim, options);
				return;
			}
			ChangeTimer changeTimer = value as ChangeTimer;
			if (changeTimer != null)
			{
				JsonSerializer.Serialize<ChangeTimer>(writer, changeTimer, options);
				return;
			}
			ToggleTimerPauseState toggleTimerPauseState = value as ToggleTimerPauseState;
			if (toggleTimerPauseState != null)
			{
				JsonSerializer.Serialize<ToggleTimerPauseState>(writer, toggleTimerPauseState, options);
				return;
			}
			RotatorEntity rotatorEntity = value as RotatorEntity;
			if (rotatorEntity != null)
			{
				JsonSerializer.Serialize<RotatorEntity>(writer, rotatorEntity, options);
				return;
			}
			UnLimitPlayerOperation unLimitPlayerOperation = value as UnLimitPlayerOperation;
			if (unLimitPlayerOperation != null)
			{
				JsonSerializer.Serialize<UnLimitPlayerOperation>(writer, unLimitPlayerOperation, options);
				return;
			}
			LimitPlayerOperation limitPlayerOperation = value as LimitPlayerOperation;
			if (limitPlayerOperation != null)
			{
				JsonSerializer.Serialize<LimitPlayerOperation>(writer, limitPlayerOperation, options);
				return;
			}
			EnableSystem enableSystem = value as EnableSystem;
			if (enableSystem != null)
			{
				JsonSerializer.Serialize<EnableSystem>(writer, enableSystem, options);
				return;
			}
			LeisureInteract leisureInteract = value as LeisureInteract;
			if (leisureInteract != null)
			{
				JsonSerializer.Serialize<LeisureInteract>(writer, leisureInteract, options);
				return;
			}
			NpcLeisureInteract npcLeisureInteract = value as NpcLeisureInteract;
			if (npcLeisureInteract != null)
			{
				JsonSerializer.Serialize<NpcLeisureInteract>(writer, npcLeisureInteract, options);
				return;
			}
			PostAkEvent postAkEvent = value as PostAkEvent;
			if (postAkEvent != null)
			{
				JsonSerializer.Serialize<PostAkEvent>(writer, postAkEvent, options);
				return;
			}
			MoveSceneItem moveSceneItem = value as MoveSceneItem;
			if (moveSceneItem != null)
			{
				JsonSerializer.Serialize<MoveSceneItem>(writer, moveSceneItem, options);
				return;
			}
			StopSceneItemMove stopSceneItemMove = value as StopSceneItemMove;
			if (stopSceneItemMove != null)
			{
				JsonSerializer.Serialize<StopSceneItemMove>(writer, stopSceneItemMove, options);
				return;
			}
			ChangeLiftTarget changeLiftTarget = value as ChangeLiftTarget;
			if (changeLiftTarget != null)
			{
				JsonSerializer.Serialize<ChangeLiftTarget>(writer, changeLiftTarget, options);
				return;
			}
			HideByRangeInFlow hideByRangeInFlow = value as HideByRangeInFlow;
			if (hideByRangeInFlow != null)
			{
				JsonSerializer.Serialize<HideByRangeInFlow>(writer, hideByRangeInFlow, options);
				return;
			}
			ShowAllHidedGroupInFlow showAllHidedGroupInFlow = value as ShowAllHidedGroupInFlow;
			if (showAllHidedGroupInFlow != null)
			{
				JsonSerializer.Serialize<ShowAllHidedGroupInFlow>(writer, showAllHidedGroupInFlow, options);
				return;
			}
			OpenSimpleGameplay openSimpleGameplay = value as OpenSimpleGameplay;
			if (openSimpleGameplay != null)
			{
				JsonSerializer.Serialize<OpenSimpleGameplay>(writer, openSimpleGameplay, options);
				return;
			}
			CloseSimpleGameplay closeSimpleGameplay = value as CloseSimpleGameplay;
			if (closeSimpleGameplay != null)
			{
				JsonSerializer.Serialize<CloseSimpleGameplay>(writer, closeSimpleGameplay, options);
				return;
			}
			ChangePhantom changePhantom = value as ChangePhantom;
			if (changePhantom != null)
			{
				JsonSerializer.Serialize<ChangePhantom>(writer, changePhantom, options);
				return;
			}
			RestorePhantom restorePhantom = value as RestorePhantom;
			if (restorePhantom != null)
			{
				JsonSerializer.Serialize<RestorePhantom>(writer, restorePhantom, options);
				return;
			}
			TakePlotPhoto takePlotPhoto = value as TakePlotPhoto;
			if (takePlotPhoto != null)
			{
				JsonSerializer.Serialize<TakePlotPhoto>(writer, takePlotPhoto, options);
				return;
			}
			ChangeActorTalker changeActorTalker = value as ChangeActorTalker;
			if (changeActorTalker != null)
			{
				JsonSerializer.Serialize<ChangeActorTalker>(writer, changeActorTalker, options);
				return;
			}
			SwitchSubLevels switchSubLevels = value as SwitchSubLevels;
			if (switchSubLevels != null)
			{
				JsonSerializer.Serialize<SwitchSubLevels>(writer, switchSubLevels, options);
				return;
			}
			SwitchDataLayers switchDataLayers = value as SwitchDataLayers;
			if (switchDataLayers != null)
			{
				JsonSerializer.Serialize<SwitchDataLayers>(writer, switchDataLayers, options);
				return;
			}
			ActivateResetPoint activateResetPoint = value as ActivateResetPoint;
			if (activateResetPoint != null)
			{
				JsonSerializer.Serialize<ActivateResetPoint>(writer, activateResetPoint, options);
				return;
			}
			TeleportToLatestResetPoint teleportToLatestResetPoint = value as TeleportToLatestResetPoint;
			if (teleportToLatestResetPoint != null)
			{
				JsonSerializer.Serialize<TeleportToLatestResetPoint>(writer, teleportToLatestResetPoint, options);
				return;
			}
			SetWeather setWeather = value as SetWeather;
			if (setWeather != null)
			{
				JsonSerializer.Serialize<SetWeather>(writer, setWeather, options);
				return;
			}
			SetTimeLockState setTimeLockState = value as SetTimeLockState;
			if (setTimeLockState != null)
			{
				JsonSerializer.Serialize<SetTimeLockState>(writer, setTimeLockState, options);
				return;
			}
			SetWeatherLockState setWeatherLockState = value as SetWeatherLockState;
			if (setWeatherLockState != null)
			{
				JsonSerializer.Serialize<SetWeatherLockState>(writer, setWeatherLockState, options);
				return;
			}
			ClientSetSeasonState clientSetSeasonState = value as ClientSetSeasonState;
			if (clientSetSeasonState != null)
			{
				JsonSerializer.Serialize<ClientSetSeasonState>(writer, clientSetSeasonState, options);
				return;
			}
			IAxisLockScreenConfig axisLockScreenConfig = value as IAxisLockScreenConfig;
			if (axisLockScreenConfig != null)
			{
				JsonSerializer.Serialize<IAxisLockScreenConfig>(writer, axisLockScreenConfig, options);
				return;
			}
			AdjustPlayerCamera adjustPlayerCamera = value as AdjustPlayerCamera;
			if (adjustPlayerCamera != null)
			{
				JsonSerializer.Serialize<AdjustPlayerCamera>(writer, adjustPlayerCamera, options);
				return;
			}
			RestorePlayerCameraAdjustment restorePlayerCameraAdjustment = value as RestorePlayerCameraAdjustment;
			if (restorePlayerCameraAdjustment != null)
			{
				JsonSerializer.Serialize<RestorePlayerCameraAdjustment>(writer, restorePlayerCameraAdjustment, options);
				return;
			}
			AdjustPlayerCameraGravity adjustPlayerCameraGravity = value as AdjustPlayerCameraGravity;
			if (adjustPlayerCameraGravity != null)
			{
				JsonSerializer.Serialize<AdjustPlayerCameraGravity>(writer, adjustPlayerCameraGravity, options);
				return;
			}
			EnterMovieCamera enterMovieCamera = value as EnterMovieCamera;
			if (enterMovieCamera != null)
			{
				JsonSerializer.Serialize<EnterMovieCamera>(writer, enterMovieCamera, options);
				return;
			}
			ExitMovieCamera exitMovieCamera = value as ExitMovieCamera;
			if (exitMovieCamera != null)
			{
				JsonSerializer.Serialize<ExitMovieCamera>(writer, exitMovieCamera, options);
				return;
			}
			ResetPlayerCameraFocus resetPlayerCameraFocus = value as ResetPlayerCameraFocus;
			if (resetPlayerCameraFocus != null)
			{
				JsonSerializer.Serialize<ResetPlayerCameraFocus>(writer, resetPlayerCameraFocus, options);
				return;
			}
			UsePhantomSkill usePhantomSkill = value as UsePhantomSkill;
			if (usePhantomSkill != null)
			{
				JsonSerializer.Serialize<UsePhantomSkill>(writer, usePhantomSkill, options);
				return;
			}
			ChangePhantomFormation changePhantomFormation = value as ChangePhantomFormation;
			if (changePhantomFormation != null)
			{
				JsonSerializer.Serialize<ChangePhantomFormation>(writer, changePhantomFormation, options);
				return;
			}
			RestorePhantomFormation restorePhantomFormation = value as RestorePhantomFormation;
			if (restorePhantomFormation != null)
			{
				JsonSerializer.Serialize<RestorePhantomFormation>(writer, restorePhantomFormation, options);
				return;
			}
			EnterOrbitalCamera enterOrbitalCamera = value as EnterOrbitalCamera;
			if (enterOrbitalCamera != null)
			{
				JsonSerializer.Serialize<EnterOrbitalCamera>(writer, enterOrbitalCamera, options);
				return;
			}
			ExitOrbitalCamera exitOrbitalCamera = value as ExitOrbitalCamera;
			if (exitOrbitalCamera != null)
			{
				JsonSerializer.Serialize<ExitOrbitalCamera>(writer, exitOrbitalCamera, options);
				return;
			}
			EnableSplineMoveModel enableSplineMoveModel = value as EnableSplineMoveModel;
			if (enableSplineMoveModel != null)
			{
				JsonSerializer.Serialize<EnableSplineMoveModel>(writer, enableSplineMoveModel, options);
				return;
			}
			EnableActor enableActor = value as EnableActor;
			if (enableActor != null)
			{
				JsonSerializer.Serialize<EnableActor>(writer, enableActor, options);
				return;
			}
			SetSportsState setSportsState = value as SetSportsState;
			if (setSportsState != null)
			{
				JsonSerializer.Serialize<SetSportsState>(writer, setSportsState, options);
				return;
			}
			SetExploreState setExploreState = value as SetExploreState;
			if (setExploreState != null)
			{
				JsonSerializer.Serialize<SetExploreState>(writer, setExploreState, options);
				return;
			}
			ModifyActorMaterial modifyActorMaterial = value as ModifyActorMaterial;
			if (modifyActorMaterial != null)
			{
				JsonSerializer.Serialize<ModifyActorMaterial>(writer, modifyActorMaterial, options);
				return;
			}
			ModifyActorMaterialParamBySplineProgress modifyActorMaterialParamBySplineProgress = value as ModifyActorMaterialParamBySplineProgress;
			if (modifyActorMaterialParamBySplineProgress != null)
			{
				JsonSerializer.Serialize<ModifyActorMaterialParamBySplineProgress>(writer, modifyActorMaterialParamBySplineProgress, options);
				return;
			}
			ModifyActorMedia modifyActorMedia = value as ModifyActorMedia;
			if (modifyActorMedia != null)
			{
				JsonSerializer.Serialize<ModifyActorMedia>(writer, modifyActorMedia, options);
				return;
			}
			PlayLevelSequence playLevelSequence = value as PlayLevelSequence;
			if (playLevelSequence != null)
			{
				JsonSerializer.Serialize<PlayLevelSequence>(writer, playLevelSequence, options);
				return;
			}
			EnableTakePhotoClip enableTakePhotoClip = value as EnableTakePhotoClip;
			if (enableTakePhotoClip != null)
			{
				JsonSerializer.Serialize<EnableTakePhotoClip>(writer, enableTakePhotoClip, options);
				return;
			}
			ToggleAirWall toggleAirWall = value as ToggleAirWall;
			if (toggleAirWall != null)
			{
				JsonSerializer.Serialize<ToggleAirWall>(writer, toggleAirWall, options);
				return;
			}
			TriggerCameraShake triggerCameraShake = value as TriggerCameraShake;
			if (triggerCameraShake != null)
			{
				JsonSerializer.Serialize<TriggerCameraShake>(writer, triggerCameraShake, options);
				return;
			}
			TriggerGamepadShake triggerGamepadShake = value as TriggerGamepadShake;
			if (triggerGamepadShake != null)
			{
				JsonSerializer.Serialize<TriggerGamepadShake>(writer, triggerGamepadShake, options);
				return;
			}
			PlayRegisteredMontage playRegisteredMontage = value as PlayRegisteredMontage;
			if (playRegisteredMontage != null)
			{
				JsonSerializer.Serialize<PlayRegisteredMontage>(writer, playRegisteredMontage, options);
				return;
			}
			CreatePrefab createPrefab = value as CreatePrefab;
			if (createPrefab != null)
			{
				JsonSerializer.Serialize<CreatePrefab>(writer, createPrefab, options);
				return;
			}
			DestroyPrefab destroyPrefab = value as DestroyPrefab;
			if (destroyPrefab != null)
			{
				JsonSerializer.Serialize<DestroyPrefab>(writer, destroyPrefab, options);
				return;
			}
			SetDataLayerTransitions setDataLayerTransitions = value as SetDataLayerTransitions;
			if (setDataLayerTransitions != null)
			{
				JsonSerializer.Serialize<SetDataLayerTransitions>(writer, setDataLayerTransitions, options);
				return;
			}
			EnableAoiNotify enableAoiNotify = value as EnableAoiNotify;
			if (enableAoiNotify != null)
			{
				JsonSerializer.Serialize<EnableAoiNotify>(writer, enableAoiNotify, options);
				return;
			}
			RecoverDurability recoverDurability = value as RecoverDurability;
			if (recoverDurability != null)
			{
				JsonSerializer.Serialize<RecoverDurability>(writer, recoverDurability, options);
				return;
			}
			SetPlayerOperationRestriction setPlayerOperationRestriction = value as SetPlayerOperationRestriction;
			if (setPlayerOperationRestriction != null)
			{
				JsonSerializer.Serialize<SetPlayerOperationRestriction>(writer, setPlayerOperationRestriction, options);
				return;
			}
			ClientSetPlayerOperationRestriction clientSetPlayerOperationRestriction = value as ClientSetPlayerOperationRestriction;
			if (clientSetPlayerOperationRestriction != null)
			{
				JsonSerializer.Serialize<ClientSetPlayerOperationRestriction>(writer, clientSetPlayerOperationRestriction, options);
				return;
			}
			EnableFunction enableFunction = value as EnableFunction;
			if (enableFunction != null)
			{
				JsonSerializer.Serialize<EnableFunction>(writer, enableFunction, options);
				return;
			}
			EnableClientFunction enableClientFunction = value as EnableClientFunction;
			if (enableClientFunction != null)
			{
				JsonSerializer.Serialize<EnableClientFunction>(writer, enableClientFunction, options);
				return;
			}
			ChangeEntityPrefabPerformance changeEntityPrefabPerformance = value as ChangeEntityPrefabPerformance;
			if (changeEntityPrefabPerformance != null)
			{
				JsonSerializer.Serialize<ChangeEntityPrefabPerformance>(writer, changeEntityPrefabPerformance, options);
				return;
			}
			ModifySceneItemAttributeTag modifySceneItemAttributeTag = value as ModifySceneItemAttributeTag;
			if (modifySceneItemAttributeTag != null)
			{
				JsonSerializer.Serialize<ModifySceneItemAttributeTag>(writer, modifySceneItemAttributeTag, options);
				return;
			}
			ClientModifyTargetTag clientModifyTargetTag = value as ClientModifyTargetTag;
			if (clientModifyTargetTag != null)
			{
				JsonSerializer.Serialize<ClientModifyTargetTag>(writer, clientModifyTargetTag, options);
				return;
			}
			ToggleMapMarkState toggleMapMarkState = value as ToggleMapMarkState;
			if (toggleMapMarkState != null)
			{
				JsonSerializer.Serialize<ToggleMapMarkState>(writer, toggleMapMarkState, options);
				return;
			}
			FocusOnMapMarkAction focusOnMapMarkAction = value as FocusOnMapMarkAction;
			if (focusOnMapMarkAction != null)
			{
				JsonSerializer.Serialize<FocusOnMapMarkAction>(writer, focusOnMapMarkAction, options);
				return;
			}
			EnableTemporaryTeleport enableTemporaryTeleport = value as EnableTemporaryTeleport;
			if (enableTemporaryTeleport != null)
			{
				JsonSerializer.Serialize<EnableTemporaryTeleport>(writer, enableTemporaryTeleport, options);
				return;
			}
			SetRegionConfig setRegionConfig = value as SetRegionConfig;
			if (setRegionConfig != null)
			{
				JsonSerializer.Serialize<SetRegionConfig>(writer, setRegionConfig, options);
				return;
			}
			SetJigsawItem setJigsawItem = value as SetJigsawItem;
			if (setJigsawItem != null)
			{
				JsonSerializer.Serialize<SetJigsawItem>(writer, setJigsawItem, options);
				return;
			}
			SetJigsawFoundation setJigsawFoundation = value as SetJigsawFoundation;
			if (setJigsawFoundation != null)
			{
				JsonSerializer.Serialize<SetJigsawFoundation>(writer, setJigsawFoundation, options);
				return;
			}
			ToggleHighlightExploreUi toggleHighlightExploreUi = value as ToggleHighlightExploreUi;
			if (toggleHighlightExploreUi != null)
			{
				JsonSerializer.Serialize<ToggleHighlightExploreUi>(writer, toggleHighlightExploreUi, options);
				return;
			}
			ResetEntity resetEntity = value as ResetEntity;
			if (resetEntity != null)
			{
				JsonSerializer.Serialize<ResetEntity>(writer, resetEntity, options);
				return;
			}
			ResetLevelPlay resetLevelPlay = value as ResetLevelPlay;
			if (resetLevelPlay != null)
			{
				JsonSerializer.Serialize<ResetLevelPlay>(writer, resetLevelPlay, options);
				return;
			}
			PlayDynamicSettlement playDynamicSettlement = value as PlayDynamicSettlement;
			if (playDynamicSettlement != null)
			{
				JsonSerializer.Serialize<PlayDynamicSettlement>(writer, playDynamicSettlement, options);
				return;
			}
			SetInteractionLockState setInteractionLockState = value as SetInteractionLockState;
			if (setInteractionLockState != null)
			{
				JsonSerializer.Serialize<SetInteractionLockState>(writer, setInteractionLockState, options);
				return;
			}
			SetAudioState setAudioState = value as SetAudioState;
			if (setAudioState != null)
			{
				JsonSerializer.Serialize<SetAudioState>(writer, setAudioState, options);
				return;
			}
			PerformerAiSplineMove performerAiSplineMove = value as PerformerAiSplineMove;
			if (performerAiSplineMove != null)
			{
				JsonSerializer.Serialize<PerformerAiSplineMove>(writer, performerAiSplineMove, options);
				return;
			}
			PerformerAiMoveTo performerAiMoveTo = value as PerformerAiMoveTo;
			if (performerAiMoveTo != null)
			{
				JsonSerializer.Serialize<PerformerAiMoveTo>(writer, performerAiMoveTo, options);
				return;
			}
			AddTrialFollowShooter addTrialFollowShooter = value as AddTrialFollowShooter;
			if (addTrialFollowShooter != null)
			{
				JsonSerializer.Serialize<AddTrialFollowShooter>(writer, addTrialFollowShooter, options);
				return;
			}
			RemoveTrialFollowShooter removeTrialFollowShooter = value as RemoveTrialFollowShooter;
			if (removeTrialFollowShooter != null)
			{
				JsonSerializer.Serialize<RemoveTrialFollowShooter>(writer, removeTrialFollowShooter, options);
				return;
			}
			EnableFollowShooterAbility enableFollowShooterAbility = value as EnableFollowShooterAbility;
			if (enableFollowShooterAbility != null)
			{
				JsonSerializer.Serialize<EnableFollowShooterAbility>(writer, enableFollowShooterAbility, options);
				return;
			}
			ClientFollowShooterLeisureInteract clientFollowShooterLeisureInteract = value as ClientFollowShooterLeisureInteract;
			if (clientFollowShooterLeisureInteract != null)
			{
				JsonSerializer.Serialize<ClientFollowShooterLeisureInteract>(writer, clientFollowShooterLeisureInteract, options);
				return;
			}
			CustomJson customJson = value as CustomJson;
			if (customJson != null)
			{
				JsonSerializer.Serialize<CustomJson>(writer, customJson, options);
				return;
			}
			ExecResurrection execResurrection = value as ExecResurrection;
			if (execResurrection != null)
			{
				JsonSerializer.Serialize<ExecResurrection>(writer, execResurrection, options);
				return;
			}
			OpenSystemBoardWithReturn openSystemBoardWithReturn = value as OpenSystemBoardWithReturn;
			if (openSystemBoardWithReturn != null)
			{
				JsonSerializer.Serialize<OpenSystemBoardWithReturn>(writer, openSystemBoardWithReturn, options);
				return;
			}
			ResumeSystemRewardPopup resumeSystemRewardPopup = value as ResumeSystemRewardPopup;
			if (resumeSystemRewardPopup != null)
			{
				JsonSerializer.Serialize<ResumeSystemRewardPopup>(writer, resumeSystemRewardPopup, options);
				return;
			}
			ExecRiskHarvestEffect execRiskHarvestEffect = value as ExecRiskHarvestEffect;
			if (execRiskHarvestEffect != null)
			{
				JsonSerializer.Serialize<ExecRiskHarvestEffect>(writer, execRiskHarvestEffect, options);
				return;
			}
			SetTeleControl setTeleControl = value as SetTeleControl;
			if (setTeleControl != null)
			{
				JsonSerializer.Serialize<SetTeleControl>(writer, setTeleControl, options);
				return;
			}
			MowingTowerGotoNextFloor mowingTowerGotoNextFloor = value as MowingTowerGotoNextFloor;
			if (mowingTowerGotoNextFloor != null)
			{
				JsonSerializer.Serialize<MowingTowerGotoNextFloor>(writer, mowingTowerGotoNextFloor, options);
				return;
			}
			SlashAndTowerGotoNextFloor slashAndTowerGotoNextFloor = value as SlashAndTowerGotoNextFloor;
			if (slashAndTowerGotoNextFloor != null)
			{
				JsonSerializer.Serialize<SlashAndTowerGotoNextFloor>(writer, slashAndTowerGotoNextFloor, options);
				return;
			}
			RoleTowerGotoNextFloor roleTowerGotoNextFloor = value as RoleTowerGotoNextFloor;
			if (roleTowerGotoNextFloor != null)
			{
				JsonSerializer.Serialize<RoleTowerGotoNextFloor>(writer, roleTowerGotoNextFloor, options);
				return;
			}
			VehicleEnter vehicleEnter = value as VehicleEnter;
			if (vehicleEnter != null)
			{
				JsonSerializer.Serialize<VehicleEnter>(writer, vehicleEnter, options);
				return;
			}
			EnterNpcVehicle enterNpcVehicle = value as EnterNpcVehicle;
			if (enterNpcVehicle != null)
			{
				JsonSerializer.Serialize<EnterNpcVehicle>(writer, enterNpcVehicle, options);
				return;
			}
			VehicleExitPlayer vehicleExitPlayer = value as VehicleExitPlayer;
			if (vehicleExitPlayer != null)
			{
				JsonSerializer.Serialize<VehicleExitPlayer>(writer, vehicleExitPlayer, options);
				return;
			}
			VehicleExitNpc vehicleExitNpc = value as VehicleExitNpc;
			if (vehicleExitNpc != null)
			{
				JsonSerializer.Serialize<VehicleExitNpc>(writer, vehicleExitNpc, options);
				return;
			}
			TeleportVehicle teleportVehicle = value as TeleportVehicle;
			if (teleportVehicle != null)
			{
				JsonSerializer.Serialize<TeleportVehicle>(writer, teleportVehicle, options);
				return;
			}
			ClientTeleportVehicle clientTeleportVehicle = value as ClientTeleportVehicle;
			if (clientTeleportVehicle != null)
			{
				JsonSerializer.Serialize<ClientTeleportVehicle>(writer, clientTeleportVehicle, options);
				return;
			}
			VehiclePlayPassengerVoice vehiclePlayPassengerVoice = value as VehiclePlayPassengerVoice;
			if (vehiclePlayPassengerVoice != null)
			{
				JsonSerializer.Serialize<VehiclePlayPassengerVoice>(writer, vehiclePlayPassengerVoice, options);
				return;
			}
			VehicleWaterfallClimbing vehicleWaterfallClimbing = value as VehicleWaterfallClimbing;
			if (vehicleWaterfallClimbing != null)
			{
				JsonSerializer.Serialize<VehicleWaterfallClimbing>(writer, vehicleWaterfallClimbing, options);
				return;
			}
			TeleportToAndEnterVehicle teleportToAndEnterVehicle = value as TeleportToAndEnterVehicle;
			if (teleportToAndEnterVehicle != null)
			{
				JsonSerializer.Serialize<TeleportToAndEnterVehicle>(writer, teleportToAndEnterVehicle, options);
				return;
			}
			VehicleMoveWithPathLine vehicleMoveWithPathLine = value as VehicleMoveWithPathLine;
			if (vehicleMoveWithPathLine != null)
			{
				JsonSerializer.Serialize<VehicleMoveWithPathLine>(writer, vehicleMoveWithPathLine, options);
				return;
			}
			VehicleSprint vehicleSprint = value as VehicleSprint;
			if (vehicleSprint != null)
			{
				JsonSerializer.Serialize<VehicleSprint>(writer, vehicleSprint, options);
				return;
			}
			OpenQteAction openQteAction = value as OpenQteAction;
			if (openQteAction != null)
			{
				JsonSerializer.Serialize<OpenQteAction>(writer, openQteAction, options);
				return;
			}
			PlayerInput playerInput = value as PlayerInput;
			if (playerInput != null)
			{
				JsonSerializer.Serialize<PlayerInput>(writer, playerInput, options);
				return;
			}
			PreloadAction preloadAction = value as PreloadAction;
			if (preloadAction != null)
			{
				JsonSerializer.Serialize<PreloadAction>(writer, preloadAction, options);
				return;
			}
			RemovePreloadResourceAction removePreloadResourceAction = value as RemovePreloadResourceAction;
			if (removePreloadResourceAction != null)
			{
				JsonSerializer.Serialize<RemovePreloadResourceAction>(writer, removePreloadResourceAction, options);
				return;
			}
			ExecAlertSystemAction execAlertSystemAction = value as ExecAlertSystemAction;
			if (execAlertSystemAction != null)
			{
				JsonSerializer.Serialize<ExecAlertSystemAction>(writer, execAlertSystemAction, options);
				return;
			}
			SetSpineAnimation setSpineAnimation = value as SetSpineAnimation;
			if (setSpineAnimation != null)
			{
				JsonSerializer.Serialize<SetSpineAnimation>(writer, setSpineAnimation, options);
				return;
			}
			ChangeEntityCamp changeEntityCamp = value as ChangeEntityCamp;
			if (changeEntityCamp != null)
			{
				JsonSerializer.Serialize<ChangeEntityCamp>(writer, changeEntityCamp, options);
				return;
			}
			RecordDungeonEvent recordDungeonEvent = value as RecordDungeonEvent;
			if (recordDungeonEvent != null)
			{
				JsonSerializer.Serialize<RecordDungeonEvent>(writer, recordDungeonEvent, options);
				return;
			}
			DangoAbyssGotoNextFloor dangoAbyssGotoNextFloor = value as DangoAbyssGotoNextFloor;
			if (dangoAbyssGotoNextFloor != null)
			{
				JsonSerializer.Serialize<DangoAbyssGotoNextFloor>(writer, dangoAbyssGotoNextFloor, options);
				return;
			}
			DangoAbyssCreateRewardTreasureBox dangoAbyssCreateRewardTreasureBox = value as DangoAbyssCreateRewardTreasureBox;
			if (dangoAbyssCreateRewardTreasureBox != null)
			{
				JsonSerializer.Serialize<DangoAbyssCreateRewardTreasureBox>(writer, dangoAbyssCreateRewardTreasureBox, options);
				return;
			}
			DangoAbyssActivatePortal dangoAbyssActivatePortal = value as DangoAbyssActivatePortal;
			if (dangoAbyssActivatePortal != null)
			{
				JsonSerializer.Serialize<DangoAbyssActivatePortal>(writer, dangoAbyssActivatePortal, options);
				return;
			}
			DangoAbyssReceiveReward dangoAbyssReceiveReward = value as DangoAbyssReceiveReward;
			if (dangoAbyssReceiveReward != null)
			{
				JsonSerializer.Serialize<DangoAbyssReceiveReward>(writer, dangoAbyssReceiveReward, options);
				return;
			}
			RoverRogueActivate roverRogueActivate = value as RoverRogueActivate;
			if (roverRogueActivate != null)
			{
				JsonSerializer.Serialize<RoverRogueActivate>(writer, roverRogueActivate, options);
				return;
			}
			RoverRogueRoomFinish roverRogueRoomFinish = value as RoverRogueRoomFinish;
			if (roverRogueRoomFinish != null)
			{
				JsonSerializer.Serialize<RoverRogueRoomFinish>(writer, roverRogueRoomFinish, options);
				return;
			}
			RoverRogueCreateRoomReward roverRogueCreateRoomReward = value as RoverRogueCreateRoomReward;
			if (roverRogueCreateRoomReward != null)
			{
				JsonSerializer.Serialize<RoverRogueCreateRoomReward>(writer, roverRogueCreateRoomReward, options);
				return;
			}
			GuestOperateUiAnimation guestOperateUiAnimation = value as GuestOperateUiAnimation;
			if (guestOperateUiAnimation != null)
			{
				JsonSerializer.Serialize<GuestOperateUiAnimation>(writer, guestOperateUiAnimation, options);
				return;
			}
			SlideRailStart slideRailStart = value as SlideRailStart;
			if (slideRailStart != null)
			{
				JsonSerializer.Serialize<SlideRailStart>(writer, slideRailStart, options);
				return;
			}
			SlideRailEnd slideRailEnd = value as SlideRailEnd;
			if (slideRailEnd != null)
			{
				JsonSerializer.Serialize<SlideRailEnd>(writer, slideRailEnd, options);
				return;
			}
			SlidePerformStart slidePerformStart = value as SlidePerformStart;
			if (slidePerformStart != null)
			{
				JsonSerializer.Serialize<SlidePerformStart>(writer, slidePerformStart, options);
				return;
			}
			BvbSendSystemEvent bvbSendSystemEvent = value as BvbSendSystemEvent;
			if (bvbSendSystemEvent != null)
			{
				JsonSerializer.Serialize<BvbSendSystemEvent>(writer, bvbSendSystemEvent, options);
				return;
			}
			BvbSendAiEvent bvbSendAiEvent = value as BvbSendAiEvent;
			if (bvbSendAiEvent != null)
			{
				JsonSerializer.Serialize<BvbSendAiEvent>(writer, bvbSendAiEvent, options);
				return;
			}
			BvbPlayDialog bvbPlayDialog = value as BvbPlayDialog;
			if (bvbPlayDialog != null)
			{
				JsonSerializer.Serialize<BvbPlayDialog>(writer, bvbPlayDialog, options);
				return;
			}
			BvbPlayerOperationConstraint bvbPlayerOperationConstraint = value as BvbPlayerOperationConstraint;
			if (bvbPlayerOperationConstraint != null)
			{
				JsonSerializer.Serialize<BvbPlayerOperationConstraint>(writer, bvbPlayerOperationConstraint, options);
				return;
			}
			BvbSkipChallenge bvbSkipChallenge = value as BvbSkipChallenge;
			if (bvbSkipChallenge != null)
			{
				JsonSerializer.Serialize<BvbSkipChallenge>(writer, bvbSkipChallenge, options);
				return;
			}
			ActiveAntiGravitySafePoint activeAntiGravitySafePoint = value as ActiveAntiGravitySafePoint;
			if (activeAntiGravitySafePoint != null)
			{
				JsonSerializer.Serialize<ActiveAntiGravitySafePoint>(writer, activeAntiGravitySafePoint, options);
				return;
			}
			SummonEntity summonEntity = value as SummonEntity;
			if (summonEntity != null)
			{
				JsonSerializer.Serialize<SummonEntity>(writer, summonEntity, options);
				return;
			}
			DestroySummonedEntities destroySummonedEntities = value as DestroySummonedEntities;
			if (destroySummonedEntities != null)
			{
				JsonSerializer.Serialize<DestroySummonedEntities>(writer, destroySummonedEntities, options);
				return;
			}
			SetupMoraleSystem setupMoraleSystem = value as SetupMoraleSystem;
			if (setupMoraleSystem != null)
			{
				JsonSerializer.Serialize<SetupMoraleSystem>(writer, setupMoraleSystem, options);
				return;
			}
			GiantToggleModel giantToggleModel = value as GiantToggleModel;
			if (giantToggleModel != null)
			{
				JsonSerializer.Serialize<GiantToggleModel>(writer, giantToggleModel, options);
				return;
			}
			GiantTriggerResponse giantTriggerResponse = value as GiantTriggerResponse;
			if (giantTriggerResponse != null)
			{
				JsonSerializer.Serialize<GiantTriggerResponse>(writer, giantTriggerResponse, options);
				return;
			}
			ActivateGiantTotalProgressNode activateGiantTotalProgressNode = value as ActivateGiantTotalProgressNode;
			if (activateGiantTotalProgressNode != null)
			{
				JsonSerializer.Serialize<ActivateGiantTotalProgressNode>(writer, activateGiantTotalProgressNode, options);
				return;
			}
			RunActorCustomEvent runActorCustomEvent = value as RunActorCustomEvent;
			if (runActorCustomEvent != null)
			{
				JsonSerializer.Serialize<RunActorCustomEvent>(writer, runActorCustomEvent, options);
				return;
			}
			TriggerSpecificScanEffect triggerSpecificScanEffect = value as TriggerSpecificScanEffect;
			if (triggerSpecificScanEffect != null)
			{
				JsonSerializer.Serialize<TriggerSpecificScanEffect>(writer, triggerSpecificScanEffect, options);
				return;
			}
			SendClientEvent sendClientEvent = value as SendClientEvent;
			if (sendClientEvent != null)
			{
				JsonSerializer.Serialize<SendClientEvent>(writer, sendClientEvent, options);
				return;
			}
			ScanEnrichmentArea scanEnrichmentArea = value as ScanEnrichmentArea;
			if (scanEnrichmentArea != null)
			{
				JsonSerializer.Serialize<ScanEnrichmentArea>(writer, scanEnrichmentArea, options);
				return;
			}
			RequestSystemFunction requestSystemFunction = value as RequestSystemFunction;
			if (requestSystemFunction != null)
			{
				JsonSerializer.Serialize<RequestSystemFunction>(writer, requestSystemFunction, options);
				return;
			}
			ReignsSetPropertyVisible reignsSetPropertyVisible = value as ReignsSetPropertyVisible;
			if (reignsSetPropertyVisible != null)
			{
				JsonSerializer.Serialize<ReignsSetPropertyVisible>(writer, reignsSetPropertyVisible, options);
				return;
			}
			ReignsChangeBackground reignsChangeBackground = value as ReignsChangeBackground;
			if (reignsChangeBackground != null)
			{
				JsonSerializer.Serialize<ReignsChangeBackground>(writer, reignsChangeBackground, options);
				return;
			}
			IReignsSetUiEffect reignsSetUiEffect = value as IReignsSetUiEffect;
			if (reignsSetUiEffect != null)
			{
				JsonSerializer.Serialize<IReignsSetUiEffect>(writer, reignsSetUiEffect, options);
				return;
			}
			ReignsChangePlayerName reignsChangePlayerName = value as ReignsChangePlayerName;
			if (reignsChangePlayerName != null)
			{
				JsonSerializer.Serialize<ReignsChangePlayerName>(writer, reignsChangePlayerName, options);
				return;
			}
			ReignsCallCard reignsCallCard = value as ReignsCallCard;
			if (reignsCallCard != null)
			{
				JsonSerializer.Serialize<ReignsCallCard>(writer, reignsCallCard, options);
				return;
			}
			ReignsTriggerGuide reignsTriggerGuide = value as ReignsTriggerGuide;
			if (reignsTriggerGuide != null)
			{
				JsonSerializer.Serialize<ReignsTriggerGuide>(writer, reignsTriggerGuide, options);
				return;
			}
			ReignsAddBuff reignsAddBuff = value as ReignsAddBuff;
			if (reignsAddBuff != null)
			{
				JsonSerializer.Serialize<ReignsAddBuff>(writer, reignsAddBuff, options);
				return;
			}
			ReignsCheckSettle reignsCheckSettle = value as ReignsCheckSettle;
			if (reignsCheckSettle != null)
			{
				JsonSerializer.Serialize<ReignsCheckSettle>(writer, reignsCheckSettle, options);
				return;
			}
			SetNpcGroupPerform setNpcGroupPerform = value as SetNpcGroupPerform;
			if (setNpcGroupPerform != null)
			{
				JsonSerializer.Serialize<SetNpcGroupPerform>(writer, setNpcGroupPerform, options);
				return;
			}
			RemoveNpcGroupPerform removeNpcGroupPerform = value as RemoveNpcGroupPerform;
			if (removeNpcGroupPerform != null)
			{
				JsonSerializer.Serialize<RemoveNpcGroupPerform>(writer, removeNpcGroupPerform, options);
				return;
			}
			EnableEntityLookAt enableEntityLookAt = value as EnableEntityLookAt;
			if (enableEntityLookAt != null)
			{
				JsonSerializer.Serialize<EnableEntityLookAt>(writer, enableEntityLookAt, options);
				return;
			}
			DisableEntityLookAt disableEntityLookAt = value as DisableEntityLookAt;
			if (disableEntityLookAt != null)
			{
				JsonSerializer.Serialize<DisableEntityLookAt>(writer, disableEntityLookAt, options);
				return;
			}
			OverrideAiBehaviorTree overrideAiBehaviorTree = value as OverrideAiBehaviorTree;
			if (overrideAiBehaviorTree != null)
			{
				JsonSerializer.Serialize<OverrideAiBehaviorTree>(writer, overrideAiBehaviorTree, options);
				return;
			}
			RestoreAiBehaviorTree restoreAiBehaviorTree = value as RestoreAiBehaviorTree;
			if (restoreAiBehaviorTree != null)
			{
				JsonSerializer.Serialize<RestoreAiBehaviorTree>(writer, restoreAiBehaviorTree, options);
				return;
			}
			FlowDefineNpcGroupPerform flowDefineNpcGroupPerform = value as FlowDefineNpcGroupPerform;
			if (flowDefineNpcGroupPerform != null)
			{
				JsonSerializer.Serialize<FlowDefineNpcGroupPerform>(writer, flowDefineNpcGroupPerform, options);
				return;
			}
			SeqEventAddTagToSelf seqEventAddTagToSelf = value as SeqEventAddTagToSelf;
			if (seqEventAddTagToSelf != null)
			{
				JsonSerializer.Serialize<SeqEventAddTagToSelf>(writer, seqEventAddTagToSelf, options);
				return;
			}
			SeqEventFireBullet seqEventFireBullet = value as SeqEventFireBullet;
			if (seqEventFireBullet != null)
			{
				JsonSerializer.Serialize<SeqEventFireBullet>(writer, seqEventFireBullet, options);
				return;
			}
			TrapDefenseChangeMiniMap trapDefenseChangeMiniMap = value as TrapDefenseChangeMiniMap;
			if (trapDefenseChangeMiniMap != null)
			{
				JsonSerializer.Serialize<TrapDefenseChangeMiniMap>(writer, trapDefenseChangeMiniMap, options);
				return;
			}
			TrapDefensePlayerOperationConstraint trapDefensePlayerOperationConstraint = value as TrapDefensePlayerOperationConstraint;
			if (trapDefensePlayerOperationConstraint != null)
			{
				JsonSerializer.Serialize<TrapDefensePlayerOperationConstraint>(writer, trapDefensePlayerOperationConstraint, options);
				return;
			}
			HonamiStoryInteractPickUp honamiStoryInteractPickUp = value as HonamiStoryInteractPickUp;
			if (honamiStoryInteractPickUp != null)
			{
				JsonSerializer.Serialize<HonamiStoryInteractPickUp>(writer, honamiStoryInteractPickUp, options);
				return;
			}
			HonamiStoryReceiveCorruptedChestReward honamiStoryReceiveCorruptedChestReward = value as HonamiStoryReceiveCorruptedChestReward;
			if (honamiStoryReceiveCorruptedChestReward != null)
			{
				JsonSerializer.Serialize<HonamiStoryReceiveCorruptedChestReward>(writer, honamiStoryReceiveCorruptedChestReward, options);
				return;
			}
			HonamiStoryActivateSafeEvacuation honamiStoryActivateSafeEvacuation = value as HonamiStoryActivateSafeEvacuation;
			if (honamiStoryActivateSafeEvacuation != null)
			{
				JsonSerializer.Serialize<HonamiStoryActivateSafeEvacuation>(writer, honamiStoryActivateSafeEvacuation, options);
				return;
			}
			HonamiStorySetFormation honamiStorySetFormation = value as HonamiStorySetFormation;
			if (honamiStorySetFormation != null)
			{
				JsonSerializer.Serialize<HonamiStorySetFormation>(writer, honamiStorySetFormation, options);
				return;
			}
			HonamiStoryGetItem honamiStoryGetItem = value as HonamiStoryGetItem;
			if (honamiStoryGetItem != null)
			{
				JsonSerializer.Serialize<HonamiStoryGetItem>(writer, honamiStoryGetItem, options);
				return;
			}
			InfrActivityUpgradeInfrastructure infrActivityUpgradeInfrastructure = value as InfrActivityUpgradeInfrastructure;
			if (infrActivityUpgradeInfrastructure != null)
			{
				JsonSerializer.Serialize<InfrActivityUpgradeInfrastructure>(writer, infrActivityUpgradeInfrastructure, options);
				return;
			}
			PlayWalkingOverlayMontage playWalkingOverlayMontage = value as PlayWalkingOverlayMontage;
			if (playWalkingOverlayMontage != null)
			{
				JsonSerializer.Serialize<PlayWalkingOverlayMontage>(writer, playWalkingOverlayMontage, options);
				return;
			}
			EnableKey4Func enableKey4Func = value as EnableKey4Func;
			if (enableKey4Func != null)
			{
				JsonSerializer.Serialize<EnableKey4Func>(writer, enableKey4Func, options);
				return;
			}
			ChangeNpcAbpState changeNpcAbpState = value as ChangeNpcAbpState;
			if (changeNpcAbpState != null)
			{
				JsonSerializer.Serialize<ChangeNpcAbpState>(writer, changeNpcAbpState, options);
				return;
			}
			OverrideAbpAnimScheme overrideAbpAnimScheme = value as OverrideAbpAnimScheme;
			if (overrideAbpAnimScheme != null)
			{
				JsonSerializer.Serialize<OverrideAbpAnimScheme>(writer, overrideAbpAnimScheme, options);
				return;
			}
			CloseWalkingOverlayMontage closeWalkingOverlayMontage = value as CloseWalkingOverlayMontage;
			if (closeWalkingOverlayMontage != null)
			{
				JsonSerializer.Serialize<CloseWalkingOverlayMontage>(writer, closeWalkingOverlayMontage, options);
				return;
			}
			SetMotorSpeed setMotorSpeed = value as SetMotorSpeed;
			if (setMotorSpeed != null)
			{
				JsonSerializer.Serialize<SetMotorSpeed>(writer, setMotorSpeed, options);
				return;
			}
			VehicleSetSpeedImmediately vehicleSetSpeedImmediately = value as VehicleSetSpeedImmediately;
			if (vehicleSetSpeedImmediately != null)
			{
				JsonSerializer.Serialize<VehicleSetSpeedImmediately>(writer, vehicleSetSpeedImmediately, options);
				return;
			}
			StartMotorCruise startMotorCruise = value as StartMotorCruise;
			if (startMotorCruise != null)
			{
				JsonSerializer.Serialize<StartMotorCruise>(writer, startMotorCruise, options);
				return;
			}
			StopMotorCruise stopMotorCruise = value as StopMotorCruise;
			if (stopMotorCruise != null)
			{
				JsonSerializer.Serialize<StopMotorCruise>(writer, stopMotorCruise, options);
				return;
			}
			DriveMotorInSpecConfig driveMotorInSpecConfig = value as DriveMotorInSpecConfig;
			if (driveMotorInSpecConfig != null)
			{
				JsonSerializer.Serialize<DriveMotorInSpecConfig>(writer, driveMotorInSpecConfig, options);
				return;
			}
			MotorSoarInWindField motorSoarInWindField = value as MotorSoarInWindField;
			if (motorSoarInWindField != null)
			{
				JsonSerializer.Serialize<MotorSoarInWindField>(writer, motorSoarInWindField, options);
				return;
			}
			SetSkillBtnEffect setSkillBtnEffect = value as SetSkillBtnEffect;
			if (setSkillBtnEffect != null)
			{
				JsonSerializer.Serialize<SetSkillBtnEffect>(writer, setSkillBtnEffect, options);
				return;
			}
			CollectSunSpirit collectSunSpirit = value as CollectSunSpirit;
			if (collectSunSpirit != null)
			{
				JsonSerializer.Serialize<CollectSunSpirit>(writer, collectSunSpirit, options);
				return;
			}
			PerformSunSpiritGearRoundTrip performSunSpiritGearRoundTrip = value as PerformSunSpiritGearRoundTrip;
			if (performSunSpiritGearRoundTrip != null)
			{
				JsonSerializer.Serialize<PerformSunSpiritGearRoundTrip>(writer, performSunSpiritGearRoundTrip, options);
				return;
			}
			TriggerDeadeyeMode triggerDeadeyeMode = value as TriggerDeadeyeMode;
			if (triggerDeadeyeMode != null)
			{
				JsonSerializer.Serialize<TriggerDeadeyeMode>(writer, triggerDeadeyeMode, options);
				return;
			}
			TriggerSystemRandomPlot triggerSystemRandomPlot = value as TriggerSystemRandomPlot;
			if (triggerSystemRandomPlot != null)
			{
				JsonSerializer.Serialize<TriggerSystemRandomPlot>(writer, triggerSystemRandomPlot, options);
				return;
			}
			SetAudioEnable setAudioEnable = value as SetAudioEnable;
			if (setAudioEnable != null)
			{
				JsonSerializer.Serialize<SetAudioEnable>(writer, setAudioEnable, options);
				return;
			}
			PhoneSystemInteract phoneSystemInteract = value as PhoneSystemInteract;
			if (phoneSystemInteract != null)
			{
				JsonSerializer.Serialize<PhoneSystemInteract>(writer, phoneSystemInteract, options);
				return;
			}
			RollBlockGetReward rollBlockGetReward = value as RollBlockGetReward;
			if (rollBlockGetReward != null)
			{
				JsonSerializer.Serialize<RollBlockGetReward>(writer, rollBlockGetReward, options);
				return;
			}
			EnterMovieMode enterMovieMode = value as EnterMovieMode;
			if (enterMovieMode != null)
			{
				JsonSerializer.Serialize<EnterMovieMode>(writer, enterMovieMode, options);
				return;
			}
			ExitMovieMode exitMovieMode = value as ExitMovieMode;
			if (exitMovieMode != null)
			{
				JsonSerializer.Serialize<ExitMovieMode>(writer, exitMovieMode, options);
				return;
			}
			StartRoadNetworkNavigation startRoadNetworkNavigation = value as StartRoadNetworkNavigation;
			if (startRoadNetworkNavigation != null)
			{
				JsonSerializer.Serialize<StartRoadNetworkNavigation>(writer, startRoadNetworkNavigation, options);
				return;
			}
			SetWayOccupancyState setWayOccupancyState = value as SetWayOccupancyState;
			if (setWayOccupancyState != null)
			{
				JsonSerializer.Serialize<SetWayOccupancyState>(writer, setWayOccupancyState, options);
				return;
			}
			EnterPatrolState enterPatrolState = value as EnterPatrolState;
			if (enterPatrolState != null)
			{
				JsonSerializer.Serialize<EnterPatrolState>(writer, enterPatrolState, options);
				return;
			}
			PerformAiHideSelf performAiHideSelf = value as PerformAiHideSelf;
			if (performAiHideSelf != null)
			{
				JsonSerializer.Serialize<PerformAiHideSelf>(writer, performAiHideSelf, options);
				return;
			}
			SendSceneActorEvent sendSceneActorEvent = value as SendSceneActorEvent;
			if (sendSceneActorEvent != null)
			{
				JsonSerializer.Serialize<SendSceneActorEvent>(writer, sendSceneActorEvent, options);
				return;
			}
			ExecBpActorFunc execBpActorFunc = value as ExecBpActorFunc;
			if (execBpActorFunc != null)
			{
				JsonSerializer.Serialize<ExecBpActorFunc>(writer, execBpActorFunc, options);
				return;
			}
			ResetPlayerPosWithPresentation resetPlayerPosWithPresentation = value as ResetPlayerPosWithPresentation;
			if (resetPlayerPosWithPresentation != null)
			{
				JsonSerializer.Serialize<ResetPlayerPosWithPresentation>(writer, resetPlayerPosWithPresentation, options);
				return;
			}
			DrinksRollRoleRequirement drinksRollRoleRequirement = value as DrinksRollRoleRequirement;
			if (drinksRollRoleRequirement != null)
			{
				JsonSerializer.Serialize<DrinksRollRoleRequirement>(writer, drinksRollRoleRequirement, options);
				return;
			}
			SetBlendAnim setBlendAnim = value as SetBlendAnim;
			if (setBlendAnim != null)
			{
				JsonSerializer.Serialize<SetBlendAnim>(writer, setBlendAnim, options);
				return;
			}
			ReportTrackingEvent reportTrackingEvent = value as ReportTrackingEvent;
			if (reportTrackingEvent != null)
			{
				JsonSerializer.Serialize<ReportTrackingEvent>(writer, reportTrackingEvent, options);
				return;
			}
			TetrisThrowBlock tetrisThrowBlock = value as TetrisThrowBlock;
			if (tetrisThrowBlock != null)
			{
				JsonSerializer.Serialize<TetrisThrowBlock>(writer, tetrisThrowBlock, options);
				return;
			}
			TetrisGameComplete tetrisGameComplete = value as TetrisGameComplete;
			if (tetrisGameComplete != null)
			{
				JsonSerializer.Serialize<TetrisGameComplete>(writer, tetrisGameComplete, options);
				return;
			}
			TetrisTriggerDelayFall tetrisTriggerDelayFall = value as TetrisTriggerDelayFall;
			if (tetrisTriggerDelayFall != null)
			{
				JsonSerializer.Serialize<TetrisTriggerDelayFall>(writer, tetrisTriggerDelayFall, options);
				return;
			}
			BossPilingRandomBuff bossPilingRandomBuff = value as BossPilingRandomBuff;
			if (bossPilingRandomBuff != null)
			{
				JsonSerializer.Serialize<BossPilingRandomBuff>(writer, bossPilingRandomBuff, options);
				return;
			}
			BossPilingEnterNextInst bossPilingEnterNextInst = value as BossPilingEnterNextInst;
			if (bossPilingEnterNextInst != null)
			{
				JsonSerializer.Serialize<BossPilingEnterNextInst>(writer, bossPilingEnterNextInst, options);
				return;
			}
			OpenQuickHackSystem openQuickHackSystem = value as OpenQuickHackSystem;
			if (openQuickHackSystem != null)
			{
				JsonSerializer.Serialize<OpenQuickHackSystem>(writer, openQuickHackSystem, options);
				return;
			}
			DollGrabItemDelivery dollGrabItemDelivery = value as DollGrabItemDelivery;
			if (dollGrabItemDelivery != null)
			{
				JsonSerializer.Serialize<DollGrabItemDelivery>(writer, dollGrabItemDelivery, options);
				return;
			}
			SheriffUnlockClue sheriffUnlockClue = value as SheriffUnlockClue;
			if (sheriffUnlockClue != null)
			{
				JsonSerializer.Serialize<SheriffUnlockClue>(writer, sheriffUnlockClue, options);
				return;
			}
			SheriffUnlockProgress sheriffUnlockProgress = value as SheriffUnlockProgress;
			if (sheriffUnlockProgress != null)
			{
				JsonSerializer.Serialize<SheriffUnlockProgress>(writer, sheriffUnlockProgress, options);
				return;
			}
			SheriffChangeCriminalState sheriffChangeCriminalState = value as SheriffChangeCriminalState;
			if (sheriffChangeCriminalState != null)
			{
				JsonSerializer.Serialize<SheriffChangeCriminalState>(writer, sheriffChangeCriminalState, options);
				return;
			}
			SheriffChangeCriminalIdentity sheriffChangeCriminalIdentity = value as SheriffChangeCriminalIdentity;
			if (sheriffChangeCriminalIdentity != null)
			{
				JsonSerializer.Serialize<SheriffChangeCriminalIdentity>(writer, sheriffChangeCriminalIdentity, options);
				return;
			}
			SheriffUnlockEnding sheriffUnlockEnding = value as SheriffUnlockEnding;
			if (sheriffUnlockEnding != null)
			{
				JsonSerializer.Serialize<SheriffUnlockEnding>(writer, sheriffUnlockEnding, options);
				return;
			}
			SetTargetElementalAbility setTargetElementalAbility = value as SetTargetElementalAbility;
			if (setTargetElementalAbility != null)
			{
				JsonSerializer.Serialize<SetTargetElementalAbility>(writer, setTargetElementalAbility, options);
				return;
			}
			ToggleEntityElementalAbility toggleEntityElementalAbility = value as ToggleEntityElementalAbility;
			if (toggleEntityElementalAbility != null)
			{
				JsonSerializer.Serialize<ToggleEntityElementalAbility>(writer, toggleEntityElementalAbility, options);
				return;
			}
			CaptureElementalBox captureElementalBox = value as CaptureElementalBox;
			if (captureElementalBox != null)
			{
				JsonSerializer.Serialize<CaptureElementalBox>(writer, captureElementalBox, options);
				return;
			}
			ChangeElementalBoxState changeElementalBoxState = value as ChangeElementalBoxState;
			if (changeElementalBoxState != null)
			{
				JsonSerializer.Serialize<ChangeElementalBoxState>(writer, changeElementalBoxState, options);
				return;
			}
			SetElementalBoxToTarget setElementalBoxToTarget = value as SetElementalBoxToTarget;
			if (setElementalBoxToTarget == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
				defaultInterpolatedStringHandler.AppendLiteral("还未支持的变量类型:");
				defaultInterpolatedStringHandler.AppendFormatted<Type>(value.GetType());
				throw new JsonException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			JsonSerializer.Serialize<SetElementalBoxToTarget>(writer, setElementalBoxToTarget, options);
		}
	}
}

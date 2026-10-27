using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02005F03 RID: 24323
	public enum EAction : ushort
	{
		// Token: 0x0400FA09 RID: 64009
		Undefined,
		// Token: 0x0400FA0A RID: 64010
		Activate,
		// Token: 0x0400FA0B RID: 64011
		AccpetCurrentQuest,
		// Token: 0x0400FA0C RID: 64012
		AddFlowInteractOption,
		// Token: 0x0400FA0D RID: 64013
		SetTime,
		// Token: 0x0400FA0E RID: 64014
		AwakeEntity,
		// Token: 0x0400FA0F RID: 64015
		CalculateVar,
		// Token: 0x0400FA10 RID: 64016
		RandomVar,
		// Token: 0x0400FA11 RID: 64017
		CallByCondition,
		// Token: 0x0400FA12 RID: 64018
		CallFunction,
		// Token: 0x0400FA13 RID: 64019
		CameraLookAt,
		// Token: 0x0400FA14 RID: 64020
		StopCameraLookAt,
		// Token: 0x0400FA15 RID: 64021
		EnableHostility,
		// Token: 0x0400FA16 RID: 64022
		ChangeActorState,
		// Token: 0x0400FA17 RID: 64023
		ChangeBehaviorState,
		// Token: 0x0400FA18 RID: 64024
		ChangeEntityState,
		// Token: 0x0400FA19 RID: 64025
		ChangeNpcPerformState,
		// Token: 0x0400FA1A RID: 64026
		ChangeInteractOptionText,
		// Token: 0x0400FA1B RID: 64027
		ChangeOtherState,
		// Token: 0x0400FA1C RID: 64028
		ChangeRandomState,
		// Token: 0x0400FA1D RID: 64029
		ChangeState,
		// Token: 0x0400FA1E RID: 64030
		Collect,
		// Token: 0x0400FA1F RID: 64031
		CompleteChildQuest,
		// Token: 0x0400FA20 RID: 64032
		Destroy,
		// Token: 0x0400FA21 RID: 64033
		DestroyAllChild,
		// Token: 0x0400FA22 RID: 64034
		DestroyEntity,
		// Token: 0x0400FA23 RID: 64035
		DestroySelf,
		// Token: 0x0400FA24 RID: 64036
		DoCalculate,
		// Token: 0x0400FA25 RID: 64037
		EnableFunction,
		// Token: 0x0400FA26 RID: 64038
		EnableClientFunction,
		// Token: 0x0400FA27 RID: 64039
		FaceToPos,
		// Token: 0x0400FA28 RID: 64040
		FinishDoInteract,
		// Token: 0x0400FA29 RID: 64041
		FinishState,
		// Token: 0x0400FA2A RID: 64042
		FinishTalk,
		// Token: 0x0400FA2B RID: 64043
		GetItem,
		// Token: 0x0400FA2C RID: 64044
		DestroyQuestItem,
		// Token: 0x0400FA2D RID: 64045
		GuideTrigger,
		// Token: 0x0400FA2E RID: 64046
		CompleteGuide,
		// Token: 0x0400FA2F RID: 64047
		Invoke,
		// Token: 0x0400FA30 RID: 64048
		JumpTalk,
		// Token: 0x0400FA31 RID: 64049
		Log,
		// Token: 0x0400FA32 RID: 64050
		MoveToPos,
		// Token: 0x0400FA33 RID: 64051
		MoveWithSpline,
		// Token: 0x0400FA34 RID: 64052
		NewMoveWithSpline,
		// Token: 0x0400FA35 RID: 64053
		StopNewMoveWithSpline,
		// Token: 0x0400FA36 RID: 64054
		CharacterMoveToPoint,
		// Token: 0x0400FA37 RID: 64055
		PlayerMoveToPoint,
		// Token: 0x0400FA38 RID: 64056
		NpcMoveToPoint,
		// Token: 0x0400FA39 RID: 64057
		OpenSystemBoard,
		// Token: 0x0400FA3A RID: 64058
		OpenSystemFunction,
		// Token: 0x0400FA3B RID: 64059
		PlayCustomSequence,
		// Token: 0x0400FA3C RID: 64060
		PlayerLookAt,
		// Token: 0x0400FA3D RID: 64061
		EntityLookAt,
		// Token: 0x0400FA3E RID: 64062
		EntityTurnTo,
		// Token: 0x0400FA3F RID: 64063
		CharacterLookAt,
		// Token: 0x0400FA40 RID: 64064
		PlayFlow,
		// Token: 0x0400FA41 RID: 64065
		PlayMovie,
		// Token: 0x0400FA42 RID: 64066
		PlayEffect,
		// Token: 0x0400FA43 RID: 64067
		PlayEffect2,
		// Token: 0x0400FA44 RID: 64068
		RemoveEffect,
		// Token: 0x0400FA45 RID: 64069
		PlayMontage,
		// Token: 0x0400FA46 RID: 64070
		PlayRegisteredMontage,
		// Token: 0x0400FA47 RID: 64071
		PlaySequenceData,
		// Token: 0x0400FA48 RID: 64072
		PlayerInput,
		// Token: 0x0400FA49 RID: 64073
		Prompt,
		// Token: 0x0400FA4A RID: 64074
		AddPlayBubble,
		// Token: 0x0400FA4B RID: 64075
		PlayBubble,
		// Token: 0x0400FA4C RID: 64076
		ClearPlayBubble,
		// Token: 0x0400FA4D RID: 64077
		EnableAI,
		// Token: 0x0400FA4E RID: 64078
		RemoveFlowInteractOption,
		// Token: 0x0400FA4F RID: 64079
		SendNpcMail,
		// Token: 0x0400FA50 RID: 64080
		SetBehaviorIsPaused,
		// Token: 0x0400FA51 RID: 64081
		SetCameraMode,
		// Token: 0x0400FA52 RID: 64082
		SetEntityVisible,
		// Token: 0x0400FA53 RID: 64083
		SetEntityClientVisible,
		// Token: 0x0400FA54 RID: 64084
		SetEntityClientVisibleSave,
		// Token: 0x0400FA55 RID: 64085
		SetHeadIconVisible,
		// Token: 0x0400FA56 RID: 64086
		SetMoveSpeed,
		// Token: 0x0400FA57 RID: 64087
		SetNumberVar,
		// Token: 0x0400FA58 RID: 64088
		SetPlotMode,
		// Token: 0x0400FA59 RID: 64089
		SetPos,
		// Token: 0x0400FA5A RID: 64090
		SetVar,
		// Token: 0x0400FA5B RID: 64091
		SetActorVar,
		// Token: 0x0400FA5C RID: 64092
		ShowCenterText,
		// Token: 0x0400FA5D RID: 64093
		ShowMessage,
		// Token: 0x0400FA5E RID: 64094
		ShowTalk,
		// Token: 0x0400FA5F RID: 64095
		SimpleMove,
		// Token: 0x0400FA60 RID: 64096
		SpawnChild,
		// Token: 0x0400FA61 RID: 64097
		SpawnEntity,
		// Token: 0x0400FA62 RID: 64098
		SyncVarToActorState,
		// Token: 0x0400FA63 RID: 64099
		Wait,
		// Token: 0x0400FA64 RID: 64100
		AddBuffToEntity,
		// Token: 0x0400FA65 RID: 64101
		AddBuffToPlayer,
		// Token: 0x0400FA66 RID: 64102
		AddBuffToFollowShooter,
		// Token: 0x0400FA67 RID: 64103
		LockEntity,
		// Token: 0x0400FA68 RID: 64104
		UnlockEntity,
		// Token: 0x0400FA69 RID: 64105
		SetForceLock,
		// Token: 0x0400FA6A RID: 64106
		SetAreaState,
		// Token: 0x0400FA6B RID: 64107
		SetWuYinQuState,
		// Token: 0x0400FA6C RID: 64108
		RemoveBuffFromEntity,
		// Token: 0x0400FA6D RID: 64109
		RemoveBuffFromPlayer,
		// Token: 0x0400FA6E RID: 64110
		SetPlayerMoveControl,
		// Token: 0x0400FA6F RID: 64111
		UnlockTeleportTrigger,
		// Token: 0x0400FA70 RID: 64112
		ChangeTeamPosition,
		// Token: 0x0400FA71 RID: 64113
		ClientChangeTeamPosition,
		// Token: 0x0400FA72 RID: 64114
		ClaimLevelPlayReward,
		// Token: 0x0400FA73 RID: 64115
		ClaimDynamicEntityReward,
		// Token: 0x0400FA74 RID: 64116
		SetReviveRegion,
		// Token: 0x0400FA75 RID: 64117
		PromptQuestChapterUI,
		// Token: 0x0400FA76 RID: 64118
		FireBullet,
		// Token: 0x0400FA77 RID: 64119
		FireBulletEffect,
		// Token: 0x0400FA78 RID: 64120
		SetPlayerPos,
		// Token: 0x0400FA79 RID: 64121
		ClientSetPlayerPos,
		// Token: 0x0400FA7A RID: 64122
		ClientPreEnableSubLevels,
		// Token: 0x0400FA7B RID: 64123
		ChangeSelfEntityState,
		// Token: 0x0400FA7C RID: 64124
		InterludeActions,
		// Token: 0x0400FA7D RID: 64125
		AddBuffToTriggeredEntity,
		// Token: 0x0400FA7E RID: 64126
		RemoveBuffToTriggeredEntity,
		// Token: 0x0400FA7F RID: 64127
		DetectTrigger,
		// Token: 0x0400FA80 RID: 64128
		ItemFoundationMatch,
		// Token: 0x0400FA81 RID: 64129
		SetBattleState,
		// Token: 0x0400FA82 RID: 64130
		WaitBattleCondition,
		// Token: 0x0400FA83 RID: 64131
		UnlockSystemItem,
		// Token: 0x0400FA84 RID: 64132
		ClientUnlockAchievementSystemItem,
		// Token: 0x0400FA85 RID: 64133
		RunActions,
		// Token: 0x0400FA86 RID: 64134
		CommonTip,
		// Token: 0x0400FA87 RID: 64135
		EndCommonTip,
		// Token: 0x0400FA88 RID: 64136
		CommonTip2,
		// Token: 0x0400FA89 RID: 64137
		EnableNearbyTracking,
		// Token: 0x0400FA8A RID: 64138
		EnableLevelPlay,
		// Token: 0x0400FA8B RID: 64139
		UnLimitPlayerOperation,
		// Token: 0x0400FA8C RID: 64140
		LimitPlayerOperation,
		// Token: 0x0400FA8D RID: 64141
		SetPlayerOperationRestriction,
		// Token: 0x0400FA8E RID: 64142
		ClientSetPlayerOperationRestriction,
		// Token: 0x0400FA8F RID: 64143
		LeisureInteract,
		// Token: 0x0400FA90 RID: 64144
		NpcLeisureInteract,
		// Token: 0x0400FA91 RID: 64145
		ChangePhantom,
		// Token: 0x0400FA92 RID: 64146
		RestorePhantom,
		// Token: 0x0400FA93 RID: 64147
		TakePlotPhoto,
		// Token: 0x0400FA94 RID: 64148
		OpenQte,
		// Token: 0x0400FA95 RID: 64149
		Preload,
		// Token: 0x0400FA96 RID: 64150
		RemovePreloadResource,
		// Token: 0x0400FA97 RID: 64151
		ExecAlertSystemAction,
		// Token: 0x0400FA98 RID: 64152
		RecordDungeonEvent,
		// Token: 0x0400FA99 RID: 64153
		ResetLevelPlay,
		// Token: 0x0400FA9A RID: 64154
		SetAreaTimeState,
		// Token: 0x0400FA9B RID: 64155
		GetRewardByInteract,
		// Token: 0x0400FA9C RID: 64156
		WaitUntilLevelSequenceReachMark,
		// Token: 0x0400FA9D RID: 64157
		EnableKey4Func,
		// Token: 0x0400FA9E RID: 64158
		OpenQuickHackSystem,
		// Token: 0x0400FA9F RID: 64159
		GuestOperateUiAnimation,
		// Token: 0x0400FAA0 RID: 64160
		VehicleEnter,
		// Token: 0x0400FAA1 RID: 64161
		VehicleEnterNpc,
		// Token: 0x0400FAA2 RID: 64162
		VehicleExitPlayer,
		// Token: 0x0400FAA3 RID: 64163
		VehicleExitNpc,
		// Token: 0x0400FAA4 RID: 64164
		VehicleTeleport,
		// Token: 0x0400FAA5 RID: 64165
		ClientVehicleTeleport,
		// Token: 0x0400FAA6 RID: 64166
		VehiclePlayPassengerVoice,
		// Token: 0x0400FAA7 RID: 64167
		VehicleWaterfallClimbing,
		// Token: 0x0400FAA8 RID: 64168
		TeleportToAndEnterVehicle,
		// Token: 0x0400FAA9 RID: 64169
		VehicleMoveWithPathLine,
		// Token: 0x0400FAAA RID: 64170
		VehicleSprint,
		// Token: 0x0400FAAB RID: 64171
		VehicleSetSpeedImmediately,
		// Token: 0x0400FAAC RID: 64172
		TeleportDungeon,
		// Token: 0x0400FAAD RID: 64173
		SettlementDungeon,
		// Token: 0x0400FAAE RID: 64174
		ClaimDungeonReward,
		// Token: 0x0400FAAF RID: 64175
		ExitDungeon,
		// Token: 0x0400FAB0 RID: 64176
		UnlockDungeonEntry,
		// Token: 0x0400FAB1 RID: 64177
		FinishDungeon,
		// Token: 0x0400FAB2 RID: 64178
		StopUiScreenEffect,
		// Token: 0x0400FAB3 RID: 64179
		StartFlowTemplate,
		// Token: 0x0400FAB4 RID: 64180
		BeginFlowTemplate,
		// Token: 0x0400FAB5 RID: 64181
		ChangeFlowTemplate,
		// Token: 0x0400FAB6 RID: 64182
		SetFlowTemplate,
		// Token: 0x0400FAB7 RID: 64183
		EndFlowTemplate,
		// Token: 0x0400FAB8 RID: 64184
		CloseFlowTemplate,
		// Token: 0x0400FAB9 RID: 64185
		SendAiEvent,
		// Token: 0x0400FABA RID: 64186
		FadeInScreen,
		// Token: 0x0400FABB RID: 64187
		FadeOutScreen,
		// Token: 0x0400FABC RID: 64188
		ChangeFightTeam,
		// Token: 0x0400FABD RID: 64189
		ManualOccupations,
		// Token: 0x0400FABE RID: 64190
		AddTrialCharacter,
		// Token: 0x0400FABF RID: 64191
		UpdateTrialCharacter,
		// Token: 0x0400FAC0 RID: 64192
		RestoreTrialCharacter,
		// Token: 0x0400FAC1 RID: 64193
		RemoveTrialCharacter,
		// Token: 0x0400FAC2 RID: 64194
		AddGuestCharacter,
		// Token: 0x0400FAC3 RID: 64195
		RemoveGuestCharacter,
		// Token: 0x0400FAC4 RID: 64196
		AddTrialFollowShooter,
		// Token: 0x0400FAC5 RID: 64197
		RemoveTrialFollowShooter,
		// Token: 0x0400FAC6 RID: 64198
		EnableFollowShooterAbility,
		// Token: 0x0400FAC7 RID: 64199
		ClientFollowShooterLeisureInteract,
		// Token: 0x0400FAC8 RID: 64200
		DestroyQuest,
		// Token: 0x0400FAC9 RID: 64201
		SetCameraAnim,
		// Token: 0x0400FACA RID: 64202
		RotatorEntity,
		// Token: 0x0400FACB RID: 64203
		TraceSpline,
		// Token: 0x0400FACC RID: 64204
		ToggleScanSplineEffect,
		// Token: 0x0400FACD RID: 64205
		ChangeTimer,
		// Token: 0x0400FACE RID: 64206
		ToggleTimerPauseState,
		// Token: 0x0400FACF RID: 64207
		EnableSystem,
		// Token: 0x0400FAD0 RID: 64208
		PostAkEvent,
		// Token: 0x0400FAD1 RID: 64209
		MoveSceneItem,
		// Token: 0x0400FAD2 RID: 64210
		StopSceneItemMove,
		// Token: 0x0400FAD3 RID: 64211
		ChangeLiftTarget,
		// Token: 0x0400FAD4 RID: 64212
		HideByRangeInFlow,
		// Token: 0x0400FAD5 RID: 64213
		ShowAllHidedGroupInFlow,
		// Token: 0x0400FAD6 RID: 64214
		OpenSimpleGameplay,
		// Token: 0x0400FAD7 RID: 64215
		CloseSimpleGameplay,
		// Token: 0x0400FAD8 RID: 64216
		ChangeActorTalker,
		// Token: 0x0400FAD9 RID: 64217
		SwitchSubLevels,
		// Token: 0x0400FADA RID: 64218
		SwitchDataLayers,
		// Token: 0x0400FADB RID: 64219
		ActivateResetPoint,
		// Token: 0x0400FADC RID: 64220
		TeleportToLatestResetPoint,
		// Token: 0x0400FADD RID: 64221
		SetWeather,
		// Token: 0x0400FADE RID: 64222
		SetTimeLockState,
		// Token: 0x0400FADF RID: 64223
		SetWeatherLockState,
		// Token: 0x0400FAE0 RID: 64224
		AdjustPlayerCamera,
		// Token: 0x0400FAE1 RID: 64225
		AdjustPlayerCameraGravity,
		// Token: 0x0400FAE2 RID: 64226
		RestorePlayerCameraAdjustment,
		// Token: 0x0400FAE3 RID: 64227
		EnterMovieCamera,
		// Token: 0x0400FAE4 RID: 64228
		ExitMovieCamera,
		// Token: 0x0400FAE5 RID: 64229
		ResetPlayerCameraFocus,
		// Token: 0x0400FAE6 RID: 64230
		UsePhantomSkill,
		// Token: 0x0400FAE7 RID: 64231
		ChangePhantomFormation,
		// Token: 0x0400FAE8 RID: 64232
		RestorePhantomFormation,
		// Token: 0x0400FAE9 RID: 64233
		EnterOrbitalCamera,
		// Token: 0x0400FAEA RID: 64234
		ExitOrbitalCamera,
		// Token: 0x0400FAEB RID: 64235
		EnableSplineMoveModel,
		// Token: 0x0400FAEC RID: 64236
		SetSportsState,
		// Token: 0x0400FAED RID: 64237
		PlayLevelSequence,
		// Token: 0x0400FAEE RID: 64238
		EnableTakePhotoClip,
		// Token: 0x0400FAEF RID: 64239
		SetExploreState,
		// Token: 0x0400FAF0 RID: 64240
		EnableAoiNotify,
		// Token: 0x0400FAF1 RID: 64241
		ChangeEntityPrefabPerformance,
		// Token: 0x0400FAF2 RID: 64242
		ModifySceneItemAttributeTag,
		// Token: 0x0400FAF3 RID: 64243
		ClientModifyTargetTag,
		// Token: 0x0400FAF4 RID: 64244
		ToggleMapMarkState,
		// Token: 0x0400FAF5 RID: 64245
		FocusOnMapMark,
		// Token: 0x0400FAF6 RID: 64246
		ToggleHighlightExploreUi,
		// Token: 0x0400FAF7 RID: 64247
		EnableTemporaryTeleport,
		// Token: 0x0400FAF8 RID: 64248
		SetTeleControl,
		// Token: 0x0400FAF9 RID: 64249
		ActiveAntiGravitySafePoint,
		// Token: 0x0400FAFA RID: 64250
		TriggerSpecificScanEffect,
		// Token: 0x0400FAFB RID: 64251
		SendClientEvent,
		// Token: 0x0400FAFC RID: 64252
		ClearFishingCabinInSaleItems,
		// Token: 0x0400FAFD RID: 64253
		AcceptFishingEntrust,
		// Token: 0x0400FAFE RID: 64254
		DestroyFishingBoat,
		// Token: 0x0400FAFF RID: 64255
		SlideRailStart,
		// Token: 0x0400FB00 RID: 64256
		SlideRailEnd,
		// Token: 0x0400FB01 RID: 64257
		SlidePerformStart,
		// Token: 0x0400FB02 RID: 64258
		BvbSendSystemEvent,
		// Token: 0x0400FB03 RID: 64259
		BvbSendAiEvent,
		// Token: 0x0400FB04 RID: 64260
		BvbPlayDialog,
		// Token: 0x0400FB05 RID: 64261
		BvbPlayerOperationConstraint,
		// Token: 0x0400FB06 RID: 64262
		BvbSkipChallenge,
		// Token: 0x0400FB07 RID: 64263
		SetSpineAnimation,
		// Token: 0x0400FB08 RID: 64264
		ChangeEntityCamp,
		// Token: 0x0400FB09 RID: 64265
		TrapDefenseChangeMiniMap,
		// Token: 0x0400FB0A RID: 64266
		TrapDefensePlayerOperationConstraint,
		// Token: 0x0400FB0B RID: 64267
		RogueGotoNextFloor,
		// Token: 0x0400FB0C RID: 64268
		RogueSelectRoom,
		// Token: 0x0400FB0D RID: 64269
		RogueActivatePortal,
		// Token: 0x0400FB0E RID: 64270
		RogueReceiveReward,
		// Token: 0x0400FB0F RID: 64271
		ExecRiskHarvestEffect,
		// Token: 0x0400FB10 RID: 64272
		MowingTowerGotoNextFloor,
		// Token: 0x0400FB11 RID: 64273
		SlashAndTowerGotoNextFloor,
		// Token: 0x0400FB12 RID: 64274
		RoleTowerGotoNextFloor,
		// Token: 0x0400FB13 RID: 64275
		DangoAbyssActivatePortal,
		// Token: 0x0400FB14 RID: 64276
		DangoAbyssGotoNextFloor,
		// Token: 0x0400FB15 RID: 64277
		DangoAbyssCreateRewardTreasureBox,
		// Token: 0x0400FB16 RID: 64278
		DangoAbyssReceiveReward,
		// Token: 0x0400FB17 RID: 64279
		RoverRogueRoomFinish,
		// Token: 0x0400FB18 RID: 64280
		RoverRogueActivate,
		// Token: 0x0400FB19 RID: 64281
		RoverRogueCreateRoomReward,
		// Token: 0x0400FB1A RID: 64282
		EnableActor,
		// Token: 0x0400FB1B RID: 64283
		ModifyActorMaterial,
		// Token: 0x0400FB1C RID: 64284
		SpecialOpModifyActorMaterialParamBySplineProgress,
		// Token: 0x0400FB1D RID: 64285
		ModifyActorMedia,
		// Token: 0x0400FB1E RID: 64286
		ToggleAirWall,
		// Token: 0x0400FB1F RID: 64287
		SetDataLayerTransitions,
		// Token: 0x0400FB20 RID: 64288
		TriggerCameraShake,
		// Token: 0x0400FB21 RID: 64289
		TriggerGamepadShake,
		// Token: 0x0400FB22 RID: 64290
		CreatePrefab,
		// Token: 0x0400FB23 RID: 64291
		DestroyPrefab,
		// Token: 0x0400FB24 RID: 64292
		ExecBattleAction,
		// Token: 0x0400FB25 RID: 64293
		ExecClientBattleAction,
		// Token: 0x0400FB26 RID: 64294
		RecoverDurability,
		// Token: 0x0400FB27 RID: 64295
		SetRegionConfig,
		// Token: 0x0400FB28 RID: 64296
		SetJigsawItem,
		// Token: 0x0400FB29 RID: 64297
		SetJigsawFoundation,
		// Token: 0x0400FB2A RID: 64298
		ResetEntity,
		// Token: 0x0400FB2B RID: 64299
		PlayDynamicSettlement,
		// Token: 0x0400FB2C RID: 64300
		SetInteractionLockState,
		// Token: 0x0400FB2D RID: 64301
		FinishCondition,
		// Token: 0x0400FB2E RID: 64302
		ClearEntityVisibleTag,
		// Token: 0x0400FB2F RID: 64303
		SetEntityPos,
		// Token: 0x0400FB30 RID: 64304
		ResetEntityPos,
		// Token: 0x0400FB31 RID: 64305
		ServerSetPlayerPos,
		// Token: 0x0400FB32 RID: 64306
		FixTeleControllerPos,
		// Token: 0x0400FB33 RID: 64307
		CustomJson,
		// Token: 0x0400FB34 RID: 64308
		FixFoundationRelation,
		// Token: 0x0400FB35 RID: 64309
		FixShowTargetRange,
		// Token: 0x0400FB36 RID: 64310
		TraceCurrentQuest,
		// Token: 0x0400FB37 RID: 64311
		ForceOccupations,
		// Token: 0x0400FB38 RID: 64312
		ServerForceEnableLevelPlay,
		// Token: 0x0400FB39 RID: 64313
		TeleportDungeonPos,
		// Token: 0x0400FB3A RID: 64314
		SetTimeScale,
		// Token: 0x0400FB3B RID: 64315
		FixGetItem,
		// Token: 0x0400FB3C RID: 64316
		SetAudioState,
		// Token: 0x0400FB3D RID: 64317
		PerformerAiSplineMove,
		// Token: 0x0400FB3E RID: 64318
		PerformerAiMoveTo,
		// Token: 0x0400FB3F RID: 64319
		EnterPatrolState,
		// Token: 0x0400FB40 RID: 64320
		PerformAiHideSelf,
		// Token: 0x0400FB41 RID: 64321
		ExecResurrection,
		// Token: 0x0400FB42 RID: 64322
		HideSpecificEntities,
		// Token: 0x0400FB43 RID: 64323
		ShowSpecificEntities,
		// Token: 0x0400FB44 RID: 64324
		HideTargetRange,
		// Token: 0x0400FB45 RID: 64325
		ShowTargetRange,
		// Token: 0x0400FB46 RID: 64326
		HideGroup,
		// Token: 0x0400FB47 RID: 64327
		ShowHidedGroup,
		// Token: 0x0400FB48 RID: 64328
		ReignsSetPropertyVisible,
		// Token: 0x0400FB49 RID: 64329
		ReignsChangeBackground,
		// Token: 0x0400FB4A RID: 64330
		ReignsChangePlayerName,
		// Token: 0x0400FB4B RID: 64331
		ReignsCallCard,
		// Token: 0x0400FB4C RID: 64332
		ReignsTriggerGuide,
		// Token: 0x0400FB4D RID: 64333
		ReignsAddBuff,
		// Token: 0x0400FB4E RID: 64334
		ReignsCheckSettle,
		// Token: 0x0400FB4F RID: 64335
		HonamiStoryInteractPickUp,
		// Token: 0x0400FB50 RID: 64336
		HonamiStoryReceiveCorruptedChestReward,
		// Token: 0x0400FB51 RID: 64337
		HonamiStoryActivateSafeEvacuation,
		// Token: 0x0400FB52 RID: 64338
		HonamiStoryGetItem,
		// Token: 0x0400FB53 RID: 64339
		HonamiStorySetFormation,
		// Token: 0x0400FB54 RID: 64340
		InfrActivityUpgradeInfrastructure,
		// Token: 0x0400FB55 RID: 64341
		SetNpcGroupPerform,
		// Token: 0x0400FB56 RID: 64342
		RemoveNpcGroupPerform,
		// Token: 0x0400FB57 RID: 64343
		EnableEntityLookAt,
		// Token: 0x0400FB58 RID: 64344
		DisableEntityLookAt,
		// Token: 0x0400FB59 RID: 64345
		OverrideAiBehaviorTree,
		// Token: 0x0400FB5A RID: 64346
		RestoreAiBehaviorTree,
		// Token: 0x0400FB5B RID: 64347
		FlowDefineNpcGroupPerform,
		// Token: 0x0400FB5C RID: 64348
		SeqEventAddTagToSelf,
		// Token: 0x0400FB5D RID: 64349
		SeqEventFireBullet,
		// Token: 0x0400FB5E RID: 64350
		SetMotorSpeed,
		// Token: 0x0400FB5F RID: 64351
		StartMotorCruise,
		// Token: 0x0400FB60 RID: 64352
		StopMotorCruise,
		// Token: 0x0400FB61 RID: 64353
		DriveMotorInSpecConfig,
		// Token: 0x0400FB62 RID: 64354
		MotorSoarInWindField,
		// Token: 0x0400FB63 RID: 64355
		CollectSunSpirit,
		// Token: 0x0400FB64 RID: 64356
		PerformSunSpiritGearRoundTrip,
		// Token: 0x0400FB65 RID: 64357
		TriggerDeadeyeMode,
		// Token: 0x0400FB66 RID: 64358
		OpenSystemBoardWithReturn,
		// Token: 0x0400FB67 RID: 64359
		ResumeSystemRewardPopup,
		// Token: 0x0400FB68 RID: 64360
		SummonEntity,
		// Token: 0x0400FB69 RID: 64361
		DestroySummonedEntities,
		// Token: 0x0400FB6A RID: 64362
		SetupMoraleSystem,
		// Token: 0x0400FB6B RID: 64363
		GiantToggleModel,
		// Token: 0x0400FB6C RID: 64364
		GiantTriggerResponse,
		// Token: 0x0400FB6D RID: 64365
		ActivateGiantTotalProgressNode,
		// Token: 0x0400FB6E RID: 64366
		RunActorCustomEvent,
		// Token: 0x0400FB6F RID: 64367
		RequestSystemFunction,
		// Token: 0x0400FB70 RID: 64368
		PlayWalkingOverlayMontage,
		// Token: 0x0400FB71 RID: 64369
		ChangeNpcAbpState,
		// Token: 0x0400FB72 RID: 64370
		CloseWalkingOverlayMontage,
		// Token: 0x0400FB73 RID: 64371
		SetSkillButtonEffect,
		// Token: 0x0400FB74 RID: 64372
		ScanEnrichmentArea,
		// Token: 0x0400FB75 RID: 64373
		TriggerSystemRandomPlot,
		// Token: 0x0400FB76 RID: 64374
		SetAudioEnable,
		// Token: 0x0400FB77 RID: 64375
		PhoneSystemInteract,
		// Token: 0x0400FB78 RID: 64376
		RollBlockGetReward,
		// Token: 0x0400FB79 RID: 64377
		EnterMovieMode,
		// Token: 0x0400FB7A RID: 64378
		ExitMovieMode,
		// Token: 0x0400FB7B RID: 64379
		StartRoadNetworkNavigation,
		// Token: 0x0400FB7C RID: 64380
		SetWayOccupancyState,
		// Token: 0x0400FB7D RID: 64381
		SendSceneActorsEvent,
		// Token: 0x0400FB7E RID: 64382
		ExecBpActorFunc,
		// Token: 0x0400FB7F RID: 64383
		ResetPlayerPosWithPresentation,
		// Token: 0x0400FB80 RID: 64384
		PlayerLookTowards,
		// Token: 0x0400FB81 RID: 64385
		DrinksRollRoleRequirement,
		// Token: 0x0400FB82 RID: 64386
		SetBlendAnim,
		// Token: 0x0400FB83 RID: 64387
		ReportTrackingEvent,
		// Token: 0x0400FB84 RID: 64388
		TetrisThrowBlock,
		// Token: 0x0400FB85 RID: 64389
		TetrisGameComplete,
		// Token: 0x0400FB86 RID: 64390
		TetrisTriggerDelayFall,
		// Token: 0x0400FB87 RID: 64391
		BossPilingRandomBuff,
		// Token: 0x0400FB88 RID: 64392
		BossPilingEnterNextInst,
		// Token: 0x0400FB89 RID: 64393
		DollGrabItemDelivery,
		// Token: 0x0400FB8A RID: 64394
		AvgPlayRoleAction,
		// Token: 0x0400FB8B RID: 64395
		AvgMoveRole,
		// Token: 0x0400FB8C RID: 64396
		AvgFocusRole,
		// Token: 0x0400FB8D RID: 64397
		AvgShakeUi,
		// Token: 0x0400FB8E RID: 64398
		DestroyDynamicEntities,
		// Token: 0x0400FB8F RID: 64399
		SheriffUnlockClue,
		// Token: 0x0400FB90 RID: 64400
		SheriffUnlockProgress,
		// Token: 0x0400FB91 RID: 64401
		SheriffChangeCriminalState,
		// Token: 0x0400FB92 RID: 64402
		SheriffChangeCriminalIdentity,
		// Token: 0x0400FB93 RID: 64403
		SheriffUnlockEnding,
		// Token: 0x0400FB94 RID: 64404
		SetSubScreenMode,
		// Token: 0x0400FB95 RID: 64405
		ClientSetSeasonState,
		// Token: 0x0400FB96 RID: 64406
		ToggleDragActorPlay,
		// Token: 0x0400FB97 RID: 64407
		SetTargetElementalAbility,
		// Token: 0x0400FB98 RID: 64408
		ToggleEntityElementalAbility,
		// Token: 0x0400FB99 RID: 64409
		CaptureElementalBox,
		// Token: 0x0400FB9A RID: 64410
		ChangeElementalBoxState,
		// Token: 0x0400FB9B RID: 64411
		SetElementalBoxToTarget,
		// Token: 0x0400FB9C RID: 64412
		OverrideAbpAnimScheme
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066EE RID: 26350
	public enum IActionParams_Union_1 : byte
	{
		// Token: 0x0401115B RID: 69979
		NONE,
		// Token: 0x0401115C RID: 69980
		IEnterOrbitalCamera,
		// Token: 0x0401115D RID: 69981
		IExitOrbitalCamera,
		// Token: 0x0401115E RID: 69982
		IEnableSplineMoveModel,
		// Token: 0x0401115F RID: 69983
		IEnableActor,
		// Token: 0x04011160 RID: 69984
		ISetSportsState,
		// Token: 0x04011161 RID: 69985
		ISetExploreState,
		// Token: 0x04011162 RID: 69986
		IModifyActorMaterial,
		// Token: 0x04011163 RID: 69987
		IModifyActorMaterialParamBySplineProgress,
		// Token: 0x04011164 RID: 69988
		IModifyActorMedia,
		// Token: 0x04011165 RID: 69989
		IPlayLevelSequence,
		// Token: 0x04011166 RID: 69990
		IEnableTakePhotoClip,
		// Token: 0x04011167 RID: 69991
		IToggleAirWall,
		// Token: 0x04011168 RID: 69992
		ITriggerCameraShake,
		// Token: 0x04011169 RID: 69993
		ITriggerGamepadShake,
		// Token: 0x0401116A RID: 69994
		IPlayRegisteredMontage,
		// Token: 0x0401116B RID: 69995
		ICreatePrefab,
		// Token: 0x0401116C RID: 69996
		IDestroyPrefab,
		// Token: 0x0401116D RID: 69997
		ISetDataLayerTransitions,
		// Token: 0x0401116E RID: 69998
		IEnableAoiNotify,
		// Token: 0x0401116F RID: 69999
		IRecoverDurability,
		// Token: 0x04011170 RID: 70000
		ISetPlayerOperationRestriction,
		// Token: 0x04011171 RID: 70001
		IEnableAllPlayerOperation,
		// Token: 0x04011172 RID: 70002
		IDisableAllPlayerOperation,
		// Token: 0x04011173 RID: 70003
		IDisableModulePlayerOperation,
		// Token: 0x04011174 RID: 70004
		IClientSetPlayerOperationRestriction,
		// Token: 0x04011175 RID: 70005
		IClientEnableAllPlayerOperation,
		// Token: 0x04011176 RID: 70006
		IClientDisableAllPlayerOperation,
		// Token: 0x04011177 RID: 70007
		IClientDisableModulePlayerOperation,
		// Token: 0x04011178 RID: 70008
		IEnableFunction,
		// Token: 0x04011179 RID: 70009
		ITeleportDungeonFunction,
		// Token: 0x0401117A RID: 70010
		IMotorRadioUiFunction,
		// Token: 0x0401117B RID: 70011
		IInteractiveItemsFunction,
		// Token: 0x0401117C RID: 70012
		IEnableClientFunction,
		// Token: 0x0401117D RID: 70013
		IHealthBarDisplayClientFunction,
		// Token: 0x0401117E RID: 70014
		IChangeEntityPrefabPerformance,
		// Token: 0x0401117F RID: 70015
		IChangeTargetEntityPrefabPerformance,
		// Token: 0x04011180 RID: 70016
		IChangeSelfEntityPrefabPerformance,
		// Token: 0x04011181 RID: 70017
		IModifySceneItemAttributeTag,
		// Token: 0x04011182 RID: 70018
		IModifySelfSceneItemAttributeTag,
		// Token: 0x04011183 RID: 70019
		IModifyTargetSceneItemAttributeTag,
		// Token: 0x04011184 RID: 70020
		IClientModifyTargetTag,
		// Token: 0x04011185 RID: 70021
		IToggleMapMarkState,
		// Token: 0x04011186 RID: 70022
		IShowMapMark,
		// Token: 0x04011187 RID: 70023
		IHideMapMark,
		// Token: 0x04011188 RID: 70024
		IDisableMapMark,
		// Token: 0x04011189 RID: 70025
		IFocusOnMapMarkAction,
		// Token: 0x0401118A RID: 70026
		IEnableTemporaryTeleport,
		// Token: 0x0401118B RID: 70027
		ISetRegionConfig,
		// Token: 0x0401118C RID: 70028
		ISetRegionMpc,
		// Token: 0x0401118D RID: 70029
		ISetJigsawItem,
		// Token: 0x0401118E RID: 70030
		ISetJigsawFoundation,
		// Token: 0x0401118F RID: 70031
		IToggleHighlightExploreUi,
		// Token: 0x04011190 RID: 70032
		IShowHighlightExploreSkillIcon,
		// Token: 0x04011191 RID: 70033
		IHideHighlightExploreSkillIcon,
		// Token: 0x04011192 RID: 70034
		IToggleAndHighlightItem,
		// Token: 0x04011193 RID: 70035
		IResetEntity,
		// Token: 0x04011194 RID: 70036
		IResetLevelPlay,
		// Token: 0x04011195 RID: 70037
		IPlayDynamicSettlement,
		// Token: 0x04011196 RID: 70038
		ISetInteractionLockState,
		// Token: 0x04011197 RID: 70039
		ISetAudioState,
		// Token: 0x04011198 RID: 70040
		ISendBattleTag,
		// Token: 0x04011199 RID: 70041
		IPerformerAiSplineMove,
		// Token: 0x0401119A RID: 70042
		IPerformerAiMoveTo,
		// Token: 0x0401119B RID: 70043
		IAddTrialFollowShooter,
		// Token: 0x0401119C RID: 70044
		IRemoveTrialFollowShooter,
		// Token: 0x0401119D RID: 70045
		IEnableFollowShooterAbility,
		// Token: 0x0401119E RID: 70046
		IFollowShooterLeisureInteract,
		// Token: 0x0401119F RID: 70047
		IClientFollowShooterLeisureInteract,
		// Token: 0x040111A0 RID: 70048
		ICustomJson,
		// Token: 0x040111A1 RID: 70049
		IExecResurrection,
		// Token: 0x040111A2 RID: 70050
		IOpenSystemBoardWithReturn,
		// Token: 0x040111A3 RID: 70051
		IResumeSystemRewardPopup,
		// Token: 0x040111A4 RID: 70052
		IExecRiskHarvestEffect,
		// Token: 0x040111A5 RID: 70053
		ISetTeleControl,
		// Token: 0x040111A6 RID: 70054
		IMowingTowerGotoNextFloor,
		// Token: 0x040111A7 RID: 70055
		ISlashAndTowerGotoNextFloor,
		// Token: 0x040111A8 RID: 70056
		IRoleTowerGotoNextFloor,
		// Token: 0x040111A9 RID: 70057
		IVehicleEnter,
		// Token: 0x040111AA RID: 70058
		IEnterNpcVehicle,
		// Token: 0x040111AB RID: 70059
		IVehicleExitPlayer,
		// Token: 0x040111AC RID: 70060
		IVehicleExitNpc,
		// Token: 0x040111AD RID: 70061
		ITeleportVehicle,
		// Token: 0x040111AE RID: 70062
		IClientTeleportVehicle,
		// Token: 0x040111AF RID: 70063
		IVehiclePlayPassengerVoice,
		// Token: 0x040111B0 RID: 70064
		IVehicleWaterfallClimbing,
		// Token: 0x040111B1 RID: 70065
		ITeleportToAndEnterVehicle,
		// Token: 0x040111B2 RID: 70066
		IVehicleMoveWithPathLine,
		// Token: 0x040111B3 RID: 70067
		IVehicleSprint,
		// Token: 0x040111B4 RID: 70068
		IOpenQteAction,
		// Token: 0x040111B5 RID: 70069
		IPlayerInput,
		// Token: 0x040111B6 RID: 70070
		IPreloadAction,
		// Token: 0x040111B7 RID: 70071
		IRemovePreloadResourceAction,
		// Token: 0x040111B8 RID: 70072
		IExecAlertSystemAction,
		// Token: 0x040111B9 RID: 70073
		ISetSpineAnimation,
		// Token: 0x040111BA RID: 70074
		IChangeEntityCamp,
		// Token: 0x040111BB RID: 70075
		IRecordDungeonEvent,
		// Token: 0x040111BC RID: 70076
		IDangoAbyssGotoNextFloor,
		// Token: 0x040111BD RID: 70077
		IDangoAbyssCreateRewardTreasureBox,
		// Token: 0x040111BE RID: 70078
		IDangoAbyssActivatePortal,
		// Token: 0x040111BF RID: 70079
		IDangoAbyssReceiveReward,
		// Token: 0x040111C0 RID: 70080
		IRoverRogueActivate,
		// Token: 0x040111C1 RID: 70081
		IRoverRogueRoomFinish,
		// Token: 0x040111C2 RID: 70082
		IRoverRogueCreateRoomReward,
		// Token: 0x040111C3 RID: 70083
		IGuestOperateUiAnimation,
		// Token: 0x040111C4 RID: 70084
		ISlideRailStart,
		// Token: 0x040111C5 RID: 70085
		ISlideRailEnd,
		// Token: 0x040111C6 RID: 70086
		ISlidePerformStart,
		// Token: 0x040111C7 RID: 70087
		IBvbSendSystemEvent,
		// Token: 0x040111C8 RID: 70088
		IBvbSendAiEvent,
		// Token: 0x040111C9 RID: 70089
		IBvbPlayDialog,
		// Token: 0x040111CA RID: 70090
		IBvbPlayerOperationConstraint,
		// Token: 0x040111CB RID: 70091
		IBvbSkipChallenge,
		// Token: 0x040111CC RID: 70092
		IActiveAntiGravitySafePoint,
		// Token: 0x040111CD RID: 70093
		ISummonEntity,
		// Token: 0x040111CE RID: 70094
		IDestroySummonedEntities,
		// Token: 0x040111CF RID: 70095
		ISetupMoraleSystem,
		// Token: 0x040111D0 RID: 70096
		IGiantToggleModel,
		// Token: 0x040111D1 RID: 70097
		IGiantTriggerResponse,
		// Token: 0x040111D2 RID: 70098
		IActivateGiantTotalProgressNode,
		// Token: 0x040111D3 RID: 70099
		IRunActorCustomEvent,
		// Token: 0x040111D4 RID: 70100
		ITriggerSpecificScanEffect,
		// Token: 0x040111D5 RID: 70101
		ISendClientEvent,
		// Token: 0x040111D6 RID: 70102
		IScanEnrichmentArea,
		// Token: 0x040111D7 RID: 70103
		IRequestSystemFunction,
		// Token: 0x040111D8 RID: 70104
		IReignsSetPropertyVisible,
		// Token: 0x040111D9 RID: 70105
		IReignsChangeBackground,
		// Token: 0x040111DA RID: 70106
		IReignsSetUiEffect,
		// Token: 0x040111DB RID: 70107
		IReignsChangePlayerName,
		// Token: 0x040111DC RID: 70108
		IReignsCallCard,
		// Token: 0x040111DD RID: 70109
		IReignsTriggerGuide,
		// Token: 0x040111DE RID: 70110
		IReignsAddBuff,
		// Token: 0x040111DF RID: 70111
		IReignsCheckSettle,
		// Token: 0x040111E0 RID: 70112
		ISetNpcGroupPerform,
		// Token: 0x040111E1 RID: 70113
		IRemoveNpcGroupPerform,
		// Token: 0x040111E2 RID: 70114
		IEnableEntityLookAt,
		// Token: 0x040111E3 RID: 70115
		IDisableEntityLookAt,
		// Token: 0x040111E4 RID: 70116
		IOverrideAiBehaviorTree,
		// Token: 0x040111E5 RID: 70117
		IRestoreAiBehaviorTree,
		// Token: 0x040111E6 RID: 70118
		IFlowDefineNpcGroupPerform,
		// Token: 0x040111E7 RID: 70119
		ISeqEventAddTagToSelf,
		// Token: 0x040111E8 RID: 70120
		ISeqEventFireBullet,
		// Token: 0x040111E9 RID: 70121
		ITrapDefenseChangeMiniMap,
		// Token: 0x040111EA RID: 70122
		ITrapDefensePlayerOperationConstraint,
		// Token: 0x040111EB RID: 70123
		IHonamiStoryInteractPickUp,
		// Token: 0x040111EC RID: 70124
		IHonamiStoryReceiveCorruptedChestReward,
		// Token: 0x040111ED RID: 70125
		IHonamiStoryActivateSafeEvacuation,
		// Token: 0x040111EE RID: 70126
		IHonamiStorySetFormation,
		// Token: 0x040111EF RID: 70127
		IHonamiStoryGetItem,
		// Token: 0x040111F0 RID: 70128
		IInfrActivityUpgradeInfrastructure,
		// Token: 0x040111F1 RID: 70129
		IPlayWalkingOverlayMontage,
		// Token: 0x040111F2 RID: 70130
		IEnableKey4Func,
		// Token: 0x040111F3 RID: 70131
		IChangeNpcAbpState,
		// Token: 0x040111F4 RID: 70132
		IOverrideAbpAnimScheme,
		// Token: 0x040111F5 RID: 70133
		ICloseWalkingOverlayMontage,
		// Token: 0x040111F6 RID: 70134
		ISetMotorSpeed,
		// Token: 0x040111F7 RID: 70135
		IVehicleSetSpeedImmediately,
		// Token: 0x040111F8 RID: 70136
		IStartMotorCruise,
		// Token: 0x040111F9 RID: 70137
		IStopMotorCruise,
		// Token: 0x040111FA RID: 70138
		IDriveMotorInSpecConfig,
		// Token: 0x040111FB RID: 70139
		IMotorSoarInWindField,
		// Token: 0x040111FC RID: 70140
		ISetSkillBtnEffect,
		// Token: 0x040111FD RID: 70141
		ICollectSunSpirit,
		// Token: 0x040111FE RID: 70142
		IPerformSunSpiritGearRoundTrip,
		// Token: 0x040111FF RID: 70143
		ITriggerDeadeyeMode,
		// Token: 0x04011200 RID: 70144
		ITriggerSystemRandomPlot,
		// Token: 0x04011201 RID: 70145
		ISetAudioEnable,
		// Token: 0x04011202 RID: 70146
		IPhoneSystemInteract,
		// Token: 0x04011203 RID: 70147
		IRollBlockGetReward,
		// Token: 0x04011204 RID: 70148
		IEnterMovieMode,
		// Token: 0x04011205 RID: 70149
		IExitMovieMode,
		// Token: 0x04011206 RID: 70150
		IStartRoadNetworkNavigation,
		// Token: 0x04011207 RID: 70151
		ISetWayOccupancyState,
		// Token: 0x04011208 RID: 70152
		IEnterPatrolState,
		// Token: 0x04011209 RID: 70153
		IPerformAiHideSelf,
		// Token: 0x0401120A RID: 70154
		ISendSceneActorEvent,
		// Token: 0x0401120B RID: 70155
		IExecBpActorFunc,
		// Token: 0x0401120C RID: 70156
		IResetPlayerPosWithPresentation,
		// Token: 0x0401120D RID: 70157
		IDrinksRollRoleRequirement,
		// Token: 0x0401120E RID: 70158
		ISetBlendAnim,
		// Token: 0x0401120F RID: 70159
		IReportTrackingEvent,
		// Token: 0x04011210 RID: 70160
		ITetrisThrowBlock,
		// Token: 0x04011211 RID: 70161
		ITetrisGameComplete,
		// Token: 0x04011212 RID: 70162
		ITetrisTriggerDelayFall,
		// Token: 0x04011213 RID: 70163
		IBossPilingRandomBuff,
		// Token: 0x04011214 RID: 70164
		IBossPilingEnterNextInst,
		// Token: 0x04011215 RID: 70165
		IOpenQuickHackSystem,
		// Token: 0x04011216 RID: 70166
		IDollGrabItemDelivery,
		// Token: 0x04011217 RID: 70167
		ISheriffUnlockClue,
		// Token: 0x04011218 RID: 70168
		ISheriffUnlockProgress,
		// Token: 0x04011219 RID: 70169
		ISheriffChangeCriminalState,
		// Token: 0x0401121A RID: 70170
		ISheriffChangeCriminalIdentity,
		// Token: 0x0401121B RID: 70171
		ISheriffUnlockEnding,
		// Token: 0x0401121C RID: 70172
		ISetTargetElementalAbility,
		// Token: 0x0401121D RID: 70173
		IToggleEntityElementalAbility,
		// Token: 0x0401121E RID: 70174
		ICaptureElementalBox,
		// Token: 0x0401121F RID: 70175
		IChangeElementalBoxState,
		// Token: 0x04011220 RID: 70176
		ISetElementalBoxToTarget,
		// Token: 0x04011221 RID: 70177
		ISeasonWeatherSetRotationLock,
		// Token: 0x04011222 RID: 70178
		ISeasonWeatherChangeTo,
		// Token: 0x04011223 RID: 70179
		ISeasonWeatherUnlockSpecial,
		// Token: 0x04011224 RID: 70180
		IHandBookModifySystemProgress,
		// Token: 0x04011225 RID: 70181
		IClientExecEntityPrefabAction,
		// Token: 0x04011226 RID: 70182
		ILiveSetUi,
		// Token: 0x04011227 RID: 70183
		ILiveSetDanmaku,
		// Token: 0x04011228 RID: 70184
		ILiveSetParam,
		// Token: 0x04011229 RID: 70185
		ILiveSetSc
	}
}

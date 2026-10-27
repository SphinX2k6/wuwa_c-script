using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006089 RID: 24713
	public enum IActionParams_Union_0 : byte
	{
		// Token: 0x04010263 RID: 66147
		NONE,
		// Token: 0x04010264 RID: 66148
		IActionParams,
		// Token: 0x04010265 RID: 66149
		IInvoke,
		// Token: 0x04010266 RID: 66150
		IInteract,
		// Token: 0x04010267 RID: 66151
		IFinishCondition,
		// Token: 0x04010268 RID: 66152
		IGetRewardByInteract,
		// Token: 0x04010269 RID: 66153
		IWaitUntilLevelSequenceReachMark,
		// Token: 0x0401026A RID: 66154
		IClearEntityVisibleTag,
		// Token: 0x0401026B RID: 66155
		ISetEntityPos,
		// Token: 0x0401026C RID: 66156
		IResetEntityPos,
		// Token: 0x0401026D RID: 66157
		IServerSetPlayerPos,
		// Token: 0x0401026E RID: 66158
		IFixTeleControllerPos,
		// Token: 0x0401026F RID: 66159
		IFixTeleControllerResetPos,
		// Token: 0x04010270 RID: 66160
		IFixFoundationRelation,
		// Token: 0x04010271 RID: 66161
		ITraceCurrentQuest,
		// Token: 0x04010272 RID: 66162
		IFixShowTargetRange,
		// Token: 0x04010273 RID: 66163
		IFixGetItem,
		// Token: 0x04010274 RID: 66164
		ILog,
		// Token: 0x04010275 RID: 66165
		IShowMessage,
		// Token: 0x04010276 RID: 66166
		IPrompt,
		// Token: 0x04010277 RID: 66167
		ISendNpcMail,
		// Token: 0x04010278 RID: 66168
		IAdjustTodTime,
		// Token: 0x04010279 RID: 66169
		ISetAreaTimeState,
		// Token: 0x0401027A RID: 66170
		ISetTimeScale,
		// Token: 0x0401027B RID: 66171
		IJumpTalk,
		// Token: 0x0401027C RID: 66172
		ISetHeadIconVisible,
		// Token: 0x0401027D RID: 66173
		IPlayMontage,
		// Token: 0x0401027E RID: 66174
		IAvgPlayRoleAction,
		// Token: 0x0401027F RID: 66175
		IAvgMoveRole,
		// Token: 0x04010280 RID: 66176
		IAvgFocusRole,
		// Token: 0x04010281 RID: 66177
		IAvgShakeUi,
		// Token: 0x04010282 RID: 66178
		IDestroyDynamicEntities,
		// Token: 0x04010283 RID: 66179
		IActorLookAt,
		// Token: 0x04010284 RID: 66180
		IActorTurnTo,
		// Token: 0x04010285 RID: 66181
		IShowTalk,
		// Token: 0x04010286 RID: 66182
		IFinishTalk,
		// Token: 0x04010287 RID: 66183
		IShowCenterText,
		// Token: 0x04010288 RID: 66184
		IFinishState,
		// Token: 0x04010289 RID: 66185
		IChangeState,
		// Token: 0x0401028A RID: 66186
		IChangeBehaviorState,
		// Token: 0x0401028B RID: 66187
		ISetBehaviorIsPaused,
		// Token: 0x0401028C RID: 66188
		IChangeRandomState,
		// Token: 0x0401028D RID: 66189
		IChangeActorState,
		// Token: 0x0401028E RID: 66190
		IChangeOtherState,
		// Token: 0x0401028F RID: 66191
		ISetCameraMode,
		// Token: 0x04010290 RID: 66192
		ISetPlotMode,
		// Token: 0x04010291 RID: 66193
		IPlaySequenceData,
		// Token: 0x04010292 RID: 66194
		IPlayCustomSequence,
		// Token: 0x04010293 RID: 66195
		IPlayMovie,
		// Token: 0x04010294 RID: 66196
		IPlayEffect,
		// Token: 0x04010295 RID: 66197
		IPlayEffect2,
		// Token: 0x04010296 RID: 66198
		IPlayCommonEffect,
		// Token: 0x04010297 RID: 66199
		IPlayScreenEffect,
		// Token: 0x04010298 RID: 66200
		ISwitchEffectState,
		// Token: 0x04010299 RID: 66201
		IPlayDissolveEffect,
		// Token: 0x0401029A RID: 66202
		IPlayMpcEffect,
		// Token: 0x0401029B RID: 66203
		IRemoveEffect,
		// Token: 0x0401029C RID: 66204
		IWait,
		// Token: 0x0401029D RID: 66205
		IMoveToPosA,
		// Token: 0x0401029E RID: 66206
		ISetMoveSpeed,
		// Token: 0x0401029F RID: 66207
		ISetPosA,
		// Token: 0x040102A0 RID: 66208
		IFaceToPos,
		// Token: 0x040102A1 RID: 66209
		ISpawnChild,
		// Token: 0x040102A2 RID: 66210
		ISimpleMove,
		// Token: 0x040102A3 RID: 66211
		ISetNumberVar,
		// Token: 0x040102A4 RID: 66212
		ISyncVarToActorState,
		// Token: 0x040102A5 RID: 66213
		IDoCalculate,
		// Token: 0x040102A6 RID: 66214
		ICallByCondition,
		// Token: 0x040102A7 RID: 66215
		ICallFunction,
		// Token: 0x040102A8 RID: 66216
		IAddFlowInteractOption,
		// Token: 0x040102A9 RID: 66217
		IRemoveFlowInteractOption,
		// Token: 0x040102AA RID: 66218
		IChangeInteractOptionText,
		// Token: 0x040102AB RID: 66219
		ISpawnEntity,
		// Token: 0x040102AC RID: 66220
		IDestroyAllChild,
		// Token: 0x040102AD RID: 66221
		IDestroyEntity,
		// Token: 0x040102AE RID: 66222
		IPlayFlow,
		// Token: 0x040102AF RID: 66223
		IBubbleData,
		// Token: 0x040102B0 RID: 66224
		IPlayerLookAt,
		// Token: 0x040102B1 RID: 66225
		IEntityLookAt,
		// Token: 0x040102B2 RID: 66226
		ICharacterLookAt,
		// Token: 0x040102B3 RID: 66227
		IPlayerLookTowards,
		// Token: 0x040102B4 RID: 66228
		IEntityTurnTo,
		// Token: 0x040102B5 RID: 66229
		ICameraLookAt,
		// Token: 0x040102B6 RID: 66230
		IStopCameraLookAt,
		// Token: 0x040102B7 RID: 66231
		ISetVar,
		// Token: 0x040102B8 RID: 66232
		ISetActorVar,
		// Token: 0x040102B9 RID: 66233
		ICalculateVar,
		// Token: 0x040102BA RID: 66234
		IRandomVar,
		// Token: 0x040102BB RID: 66235
		IGuideTrigger,
		// Token: 0x040102BC RID: 66236
		ICompleteGuide,
		// Token: 0x040102BD RID: 66237
		IGetItem,
		// Token: 0x040102BE RID: 66238
		IDestroyQuestItem,
		// Token: 0x040102BF RID: 66239
		IAwakeEntity,
		// Token: 0x040102C0 RID: 66240
		ISetEntityVisible,
		// Token: 0x040102C1 RID: 66241
		ISetEntityClientVisible,
		// Token: 0x040102C2 RID: 66242
		ISetEntityClientVisibleSave,
		// Token: 0x040102C3 RID: 66243
		ILockEntity,
		// Token: 0x040102C4 RID: 66244
		IUnlockEntity,
		// Token: 0x040102C5 RID: 66245
		ICompleteChildQuest,
		// Token: 0x040102C6 RID: 66246
		IAcceptCurrentQuest,
		// Token: 0x040102C7 RID: 66247
		IFinishDoInteract,
		// Token: 0x040102C8 RID: 66248
		IAddBuffToEntity,
		// Token: 0x040102C9 RID: 66249
		IAddBuffToPlayer,
		// Token: 0x040102CA RID: 66250
		IAddBuffToFollowShooter,
		// Token: 0x040102CB RID: 66251
		IOpenSystemBoard,
		// Token: 0x040102CC RID: 66252
		IOpenSystemFunction,
		// Token: 0x040102CD RID: 66253
		IChangeEntityState,
		// Token: 0x040102CE RID: 66254
		IChangeEntityStateDirectly,
		// Token: 0x040102CF RID: 66255
		IChangeEntityStateBatchDirectly,
		// Token: 0x040102D0 RID: 66256
		IChangeEntityStateLoop,
		// Token: 0x040102D1 RID: 66257
		IChangeNpcPerformState,
		// Token: 0x040102D2 RID: 66258
		ISetForceLock,
		// Token: 0x040102D3 RID: 66259
		ISetAreaState,
		// Token: 0x040102D4 RID: 66260
		ISetWuYinQuState,
		// Token: 0x040102D5 RID: 66261
		IRemoveBuffFromEntity,
		// Token: 0x040102D6 RID: 66262
		IRemoveBuffFromPlayer,
		// Token: 0x040102D7 RID: 66263
		ICollect,
		// Token: 0x040102D8 RID: 66264
		IDestroy,
		// Token: 0x040102D9 RID: 66265
		IDestroySelf,
		// Token: 0x040102DA RID: 66266
		ISetPlayerMoveControl,
		// Token: 0x040102DB RID: 66267
		IUnlockTeleportTrigger,
		// Token: 0x040102DC RID: 66268
		IChangeTeamPosition,
		// Token: 0x040102DD RID: 66269
		IClientChangeTeamPosition,
		// Token: 0x040102DE RID: 66270
		IClaimLevelPlayReward,
		// Token: 0x040102DF RID: 66271
		IClaimDynamicEntityReward,
		// Token: 0x040102E0 RID: 66272
		IClearFishingCabinInSaleItems,
		// Token: 0x040102E1 RID: 66273
		IAcceptFishingEntrust,
		// Token: 0x040102E2 RID: 66274
		IDestroyFishingBoat,
		// Token: 0x040102E3 RID: 66275
		ITeleportDungeon,
		// Token: 0x040102E4 RID: 66276
		IStopUiScreenEffect,
		// Token: 0x040102E5 RID: 66277
		IClaimDungeonReward,
		// Token: 0x040102E6 RID: 66278
		ISettlementDungeon,
		// Token: 0x040102E7 RID: 66279
		IExitDungeon,
		// Token: 0x040102E8 RID: 66280
		IUnlockDungeonEntry,
		// Token: 0x040102E9 RID: 66281
		IFinishDungeon,
		// Token: 0x040102EA RID: 66282
		ISetReviveRegion,
		// Token: 0x040102EB RID: 66283
		IPromptQuestChapterUI,
		// Token: 0x040102EC RID: 66284
		IFireBullet,
		// Token: 0x040102ED RID: 66285
		IFireBulletEffect,
		// Token: 0x040102EE RID: 66286
		ISetPlayerPos,
		// Token: 0x040102EF RID: 66287
		IClientSetPlayerPos,
		// Token: 0x040102F0 RID: 66288
		IClientPreEnableSubLevels,
		// Token: 0x040102F1 RID: 66289
		IRogueGotoNextFloor,
		// Token: 0x040102F2 RID: 66290
		IRogueSelectRoom,
		// Token: 0x040102F3 RID: 66291
		IRogueActivatePortal,
		// Token: 0x040102F4 RID: 66292
		IRogueReceiveReward,
		// Token: 0x040102F5 RID: 66293
		IChangeSelfEntityState,
		// Token: 0x040102F6 RID: 66294
		IInterludeActions,
		// Token: 0x040102F7 RID: 66295
		IAddBuffToTriggeredEntity,
		// Token: 0x040102F8 RID: 66296
		IRemoveBuffToTriggeredEntity,
		// Token: 0x040102F9 RID: 66297
		IDetectTrigger,
		// Token: 0x040102FA RID: 66298
		IItemFoundationMatch,
		// Token: 0x040102FB RID: 66299
		ISetBattleState,
		// Token: 0x040102FC RID: 66300
		IExecBattleAction,
		// Token: 0x040102FD RID: 66301
		IExecClientMonsterNpcInteract,
		// Token: 0x040102FE RID: 66302
		IExecClientBattleAction,
		// Token: 0x040102FF RID: 66303
		IWaitBattleCondition,
		// Token: 0x04010300 RID: 66304
		IEnableHostility,
		// Token: 0x04010301 RID: 66305
		IUnlockSystemItem,
		// Token: 0x04010302 RID: 66306
		IClientUnlockAchievementSystemItem,
		// Token: 0x04010303 RID: 66307
		IAddPlayBubble,
		// Token: 0x04010304 RID: 66308
		IPlayBubble,
		// Token: 0x04010305 RID: 66309
		IClearPlayBubble,
		// Token: 0x04010306 RID: 66310
		IMoveWithSpline,
		// Token: 0x04010307 RID: 66311
		INewMoveWithSpline,
		// Token: 0x04010308 RID: 66312
		IStopNewMoveWithSpline,
		// Token: 0x04010309 RID: 66313
		ICharacterMoveToPoint,
		// Token: 0x0401030A RID: 66314
		IPlayerMoveToPoint,
		// Token: 0x0401030B RID: 66315
		INpcMoveToPoint,
		// Token: 0x0401030C RID: 66316
		IToggleScanSplineEffect,
		// Token: 0x0401030D RID: 66317
		IOpenTraceSpline,
		// Token: 0x0401030E RID: 66318
		ICloseTraceSpline,
		// Token: 0x0401030F RID: 66319
		ITraceSpline,
		// Token: 0x04010310 RID: 66320
		IEnableAI,
		// Token: 0x04010311 RID: 66321
		IRunActions,
		// Token: 0x04010312 RID: 66322
		ICommonTip,
		// Token: 0x04010313 RID: 66323
		ICommonTip2,
		// Token: 0x04010314 RID: 66324
		IEndCommonTip,
		// Token: 0x04010315 RID: 66325
		IEnableNearbyTracking,
		// Token: 0x04010316 RID: 66326
		ISendAiEvent,
		// Token: 0x04010317 RID: 66327
		IEnableLevelPlay,
		// Token: 0x04010318 RID: 66328
		IServerForceEnableLevelPlay,
		// Token: 0x04010319 RID: 66329
		ITeleportDungeonPos,
		// Token: 0x0401031A RID: 66330
		IFadeInScreen,
		// Token: 0x0401031B RID: 66331
		IFadeOutScreen,
		// Token: 0x0401031C RID: 66332
		IStartFlowTemplate,
		// Token: 0x0401031D RID: 66333
		IEndFlowTemplate,
		// Token: 0x0401031E RID: 66334
		ICloseFlowTemplate,
		// Token: 0x0401031F RID: 66335
		IChangeFlowTemplate,
		// Token: 0x04010320 RID: 66336
		IBeginFlowTemplate,
		// Token: 0x04010321 RID: 66337
		ISetFlowTemplate,
		// Token: 0x04010322 RID: 66338
		IHideTargetRange,
		// Token: 0x04010323 RID: 66339
		IShowTargetRange,
		// Token: 0x04010324 RID: 66340
		IHideSpecificEntities,
		// Token: 0x04010325 RID: 66341
		IShowSpecificEntities,
		// Token: 0x04010326 RID: 66342
		IHideGroup,
		// Token: 0x04010327 RID: 66343
		IShowHidedGroup,
		// Token: 0x04010328 RID: 66344
		ISetSubScreenMode,
		// Token: 0x04010329 RID: 66345
		IToggleDragActorPlay,
		// Token: 0x0401032A RID: 66346
		IManualOccupations,
		// Token: 0x0401032B RID: 66347
		IForceOccupations,
		// Token: 0x0401032C RID: 66348
		IChangeFightTeam,
		// Token: 0x0401032D RID: 66349
		IActiveRange,
		// Token: 0x0401032E RID: 66350
		IAddTrialCharacter,
		// Token: 0x0401032F RID: 66351
		IUpdateTrialCharacter,
		// Token: 0x04010330 RID: 66352
		IRestoreTrialCharacter,
		// Token: 0x04010331 RID: 66353
		IRemoveTrialCharacter,
		// Token: 0x04010332 RID: 66354
		IAddGuestCharacter,
		// Token: 0x04010333 RID: 66355
		IRemoveGuestCharacter,
		// Token: 0x04010334 RID: 66356
		IDestroyQuest,
		// Token: 0x04010335 RID: 66357
		ISetCameraAnim,
		// Token: 0x04010336 RID: 66358
		IChangeTimer,
		// Token: 0x04010337 RID: 66359
		IToggleTimerPauseState,
		// Token: 0x04010338 RID: 66360
		IRotatorEntity,
		// Token: 0x04010339 RID: 66361
		IUnLimitPlayerOperation,
		// Token: 0x0401033A RID: 66362
		ILimitPlayerOperation,
		// Token: 0x0401033B RID: 66363
		IEnableSystem,
		// Token: 0x0401033C RID: 66364
		ILeisureInteract,
		// Token: 0x0401033D RID: 66365
		INpcLeisureInteract,
		// Token: 0x0401033E RID: 66366
		IPostAkEvent,
		// Token: 0x0401033F RID: 66367
		IMoveSceneItem,
		// Token: 0x04010340 RID: 66368
		IStopSceneItemMove,
		// Token: 0x04010341 RID: 66369
		IChangeLiftTarget,
		// Token: 0x04010342 RID: 66370
		IHideByRangeInFlow,
		// Token: 0x04010343 RID: 66371
		IShowAllHidedGroupInFlow,
		// Token: 0x04010344 RID: 66372
		IOpenSimpleGameplay,
		// Token: 0x04010345 RID: 66373
		ICloseSimpleGameplay,
		// Token: 0x04010346 RID: 66374
		IChangePhantom,
		// Token: 0x04010347 RID: 66375
		IRestorePhantom,
		// Token: 0x04010348 RID: 66376
		ITakePlotPhoto,
		// Token: 0x04010349 RID: 66377
		IChangeActorTalker,
		// Token: 0x0401034A RID: 66378
		ISwitchSubLevels,
		// Token: 0x0401034B RID: 66379
		ISwitchSubLevelsDirectly,
		// Token: 0x0401034C RID: 66380
		IPreloadSubLevels,
		// Token: 0x0401034D RID: 66381
		ISwitchPermission,
		// Token: 0x0401034E RID: 66382
		ISwitchDataLayers,
		// Token: 0x0401034F RID: 66383
		IActivateResetPoint,
		// Token: 0x04010350 RID: 66384
		ITeleportToLatestResetPoint,
		// Token: 0x04010351 RID: 66385
		ISetWeather,
		// Token: 0x04010352 RID: 66386
		ISetTimeLockState,
		// Token: 0x04010353 RID: 66387
		ISetWeatherLockState,
		// Token: 0x04010354 RID: 66388
		IClientSetSeasonState,
		// Token: 0x04010355 RID: 66389
		IAxisLockScreenConfig,
		// Token: 0x04010356 RID: 66390
		IAdjustPlayerCamera,
		// Token: 0x04010357 RID: 66391
		IRestorePlayerCameraAdjustment,
		// Token: 0x04010358 RID: 66392
		IAdjustPlayerCameraGravity,
		// Token: 0x04010359 RID: 66393
		IEnterMovieCamera,
		// Token: 0x0401035A RID: 66394
		IExitMovieCamera,
		// Token: 0x0401035B RID: 66395
		IResetPlayerCameraFocus,
		// Token: 0x0401035C RID: 66396
		IUsePhantomSkill,
		// Token: 0x0401035D RID: 66397
		IChangePhantomFormation,
		// Token: 0x0401035E RID: 66398
		IRestorePhantomFormation,
		// Token: 0x0401035F RID: 66399
		IEnterOrbitalCamera,
		// Token: 0x04010360 RID: 66400
		IExitOrbitalCamera,
		// Token: 0x04010361 RID: 66401
		IEnableSplineMoveModel,
		// Token: 0x04010362 RID: 66402
		IEnableActor
	}
}

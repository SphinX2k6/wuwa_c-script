using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015D0 RID: 5584
	public enum GameCtxType
	{
		// Token: 0x0400BD05 RID: 48389
		[OriginalName("BehaviorTree")]
		BehaviorTree,
		// Token: 0x0400BD06 RID: 48390
		[OriginalName("Entity")]
		Entity,
		// Token: 0x0400BD07 RID: 48391
		[OriginalName("NormalInteract")]
		NormalInteract,
		// Token: 0x0400BD08 RID: 48392
		[OriginalName("DynamicInteract")]
		DynamicInteract,
		// Token: 0x0400BD09 RID: 48393
		[OriginalName("RandomInteract")]
		RandomInteract,
		// Token: 0x0400BD0A RID: 48394
		[OriginalName("EntityStateChangeAction")]
		EntityStateChangeAction,
		// Token: 0x0400BD0B RID: 48395
		[OriginalName("EntityGroupAction")]
		EntityGroupAction,
		// Token: 0x0400BD0C RID: 48396
		[OriginalName("EntityTrigger")]
		EntityTrigger,
		// Token: 0x0400BD0D RID: 48397
		[OriginalName("EntityLeaveTrigger")]
		EntityLeaveTrigger,
		// Token: 0x0400BD0E RID: 48398
		[OriginalName("EntityDestructible")]
		EntityDestructible,
		// Token: 0x0400BD0F RID: 48399
		[OriginalName("EntityTimelineTrack")]
		EntityTimelineTrack,
		// Token: 0x0400BD10 RID: 48400
		[OriginalName("LevelPlayOpenAction")]
		LevelPlayOpenAction,
		// Token: 0x0400BD11 RID: 48401
		[OriginalName("LevelPlayRewardAction")]
		LevelPlayRewardAction,
		// Token: 0x0400BD12 RID: 48402
		[OriginalName("QuestActiveAction")]
		QuestActiveAction,
		// Token: 0x0400BD13 RID: 48403
		[OriginalName("QuestAcceptAction")]
		QuestAcceptAction,
		// Token: 0x0400BD14 RID: 48404
		[OriginalName("QuestFinishAction")]
		QuestFinishAction,
		// Token: 0x0400BD15 RID: 48405
		[OriginalName("ChildQuestNodeEnterAction")]
		ChildQuestNodeEnterAction,
		// Token: 0x0400BD16 RID: 48406
		[OriginalName("ChildQuestNodeFinishAction")]
		ChildQuestNodeFinishAction,
		// Token: 0x0400BD17 RID: 48407
		[OriginalName("SuccessNodeAction")]
		SuccessNodeAction,
		// Token: 0x0400BD18 RID: 48408
		[OriginalName("FailedNodeAction")]
		FailedNodeAction,
		// Token: 0x0400BD19 RID: 48409
		[OriginalName("CompositionEnterAction")]
		CompositionEnterAction,
		// Token: 0x0400BD1A RID: 48410
		[OriginalName("EntityConditionListeningAction")]
		EntityConditionListeningAction,
		// Token: 0x0400BD1B RID: 48411
		[OriginalName("PlayFlowChildQuestNode")]
		PlayFlowChildQuestNode,
		// Token: 0x0400BD1C RID: 48412
		[OriginalName("HandInItemChildQuestNode")]
		HandInItemChildQuestNode,
		// Token: 0x0400BD1D RID: 48413
		[OriginalName("DoInteractChildQuestNode")]
		DoInteractChildQuestNode,
		// Token: 0x0400BD1E RID: 48414
		[OriginalName("ActionGroupNodeAction")]
		ActionGroupNodeAction,
		// Token: 0x0400BD1F RID: 48415
		[OriginalName("ExploreSkillPullGiantAction")]
		ExploreSkillPullGiantAction,
		// Token: 0x0400BD20 RID: 48416
		[OriginalName("LevelPlay")]
		LevelPlay,
		// Token: 0x0400BD21 RID: 48417
		[OriginalName("GmLevelAction")]
		GmLevelAction,
		// Token: 0x0400BD22 RID: 48418
		[OriginalName("GmPlayFlow")]
		GmPlayFlow,
		// Token: 0x0400BD23 RID: 48419
		[OriginalName("SceneItemLifeCycleComponentCreate")]
		SceneItemLifeCycleComponentCreate,
		// Token: 0x0400BD24 RID: 48420
		[OriginalName("SceneItemLifeCycleComponentDetroy")]
		SceneItemLifeCycleComponentDetroy,
		// Token: 0x0400BD25 RID: 48421
		[OriginalName("GameCtxGm")]
		GameCtxGm,
		// Token: 0x0400BD26 RID: 48422
		[OriginalName("FlowActionCtx")]
		FlowActionCtx,
		// Token: 0x0400BD27 RID: 48423
		[OriginalName("DailyQuestTerminateAction")]
		DailyQuestTerminateAction,
		// Token: 0x0400BD28 RID: 48424
		[OriginalName("ChildQuestNodeFixAction")]
		ChildQuestNodeFixAction,
		// Token: 0x0400BD29 RID: 48425
		[OriginalName("ConditionNodeFixAction")]
		ConditionNodeFixAction,
		// Token: 0x0400BD2A RID: 48426
		[OriginalName("EntityFixAction")]
		EntityFixAction,
		// Token: 0x0400BD2B RID: 48427
		[OriginalName("ConditionNode")]
		ConditionNode,
		// Token: 0x0400BD2C RID: 48428
		[OriginalName("EntityBeamReceiveAction")]
		EntityBeamReceiveAction,
		// Token: 0x0400BD2D RID: 48429
		[OriginalName("EntityGroupFailureAction")]
		EntityGroupFailureAction,
		// Token: 0x0400BD2E RID: 48430
		[OriginalName("ChildQuestNodeCondition")]
		ChildQuestNodeCondition,
		// Token: 0x0400BD2F RID: 48431
		[OriginalName("EntityStateChangeConditionAction")]
		EntityStateChangeConditionAction,
		// Token: 0x0400BD30 RID: 48432
		[OriginalName("RequestPlayerGameCurrStateBt")]
		RequestPlayerGameCurrStateBt,
		// Token: 0x0400BD31 RID: 48433
		[OriginalName("RequestEntityCurrState")]
		RequestEntityCurrState,
		// Token: 0x0400BD32 RID: 48434
		[OriginalName("TriggerConditionListeningAction")]
		TriggerConditionListeningAction,
		// Token: 0x0400BD33 RID: 48435
		[OriginalName("FlowStartTeleport")]
		FlowStartTeleport,
		// Token: 0x0400BD34 RID: 48436
		[OriginalName("EntityVisibleCondition")]
		EntityVisibleCondition,
		// Token: 0x0400BD35 RID: 48437
		[OriginalName("FailedNodeTeleport")]
		FailedNodeTeleport,
		// Token: 0x0400BD36 RID: 48438
		[OriginalName("LeaveInstEscActionCtx")]
		LeaveInstEscActionCtx,
		// Token: 0x0400BD37 RID: 48439
		[OriginalName("TrampleActiveActionCtx")]
		TrampleActiveActionCtx,
		// Token: 0x0400BD38 RID: 48440
		[OriginalName("TrampleDeActiveActionCtx")]
		TrampleDeActiveActionCtx,
		// Token: 0x0400BD39 RID: 48441
		[OriginalName("DefaultGameCtx")]
		DefaultGameCtx,
		// Token: 0x0400BD3A RID: 48442
		[OriginalName("LevelPlayExploratoryCtx")]
		LevelPlayExploratoryCtx,
		// Token: 0x0400BD3B RID: 48443
		[OriginalName("RenjuCompleteActionCtx")]
		RenjuCompleteActionCtx,
		// Token: 0x0400BD3C RID: 48444
		[OriginalName("JigsawFoundationMatchedActionCtx")]
		JigsawFoundationMatchedActionCtx,
		// Token: 0x0400BD3D RID: 48445
		[OriginalName("CompositionFixAction")]
		CompositionFixAction,
		// Token: 0x0400BD3E RID: 48446
		[OriginalName("JigsawFoundationUnMatchedActionCtx")]
		JigsawFoundationUnMatchedActionCtx,
		// Token: 0x0400BD3F RID: 48447
		[OriginalName("HookLockPointActionCtx")]
		HookLockPointActionCtx,
		// Token: 0x0400BD40 RID: 48448
		[OriginalName("ClientTriggerActionCtx")]
		ClientTriggerActionCtx,
		// Token: 0x0400BD41 RID: 48449
		[OriginalName("ExploreSkillCustomAction")]
		ExploreSkillCustomAction,
		// Token: 0x0400BD42 RID: 48450
		[OriginalName("LevelSequenceFrameEventAction")]
		LevelSequenceFrameEventAction,
		// Token: 0x0400BD43 RID: 48451
		[OriginalName("JigsawFoundationMatchedConditionActionCtx")]
		JigsawFoundationMatchedConditionActionCtx,
		// Token: 0x0400BD44 RID: 48452
		[OriginalName("CameraAlertComponentCreate")]
		CameraAlertComponentCreate,
		// Token: 0x0400BD45 RID: 48453
		[OriginalName("RenjuExitMatchedAction")]
		RenjuExitMatchedAction,
		// Token: 0x0400BD46 RID: 48454
		[OriginalName("RenjuExitUnMatchedAction")]
		RenjuExitUnMatchedAction,
		// Token: 0x0400BD47 RID: 48455
		[OriginalName("LevelPlayDestroyAction")]
		LevelPlayDestroyAction,
		// Token: 0x0400BD48 RID: 48456
		[OriginalName("EffectAreaConditionListeningAction")]
		EffectAreaConditionListeningAction,
		// Token: 0x0400BD49 RID: 48457
		[OriginalName("OccupationInfoAction")]
		OccupationInfoAction,
		// Token: 0x0400BD4A RID: 48458
		[OriginalName("EntityHeadInfoCondition")]
		EntityHeadInfoCondition,
		// Token: 0x0400BD4B RID: 48459
		[OriginalName("TemplateSpawnerConditionListen")]
		TemplateSpawnerConditionListen,
		// Token: 0x0400BD4C RID: 48460
		[OriginalName("TemplateSpawnerAction")]
		TemplateSpawnerAction,
		// Token: 0x0400BD4D RID: 48461
		[OriginalName("BatchRefresherConditionListen")]
		BatchRefresherConditionListen,
		// Token: 0x0400BD4E RID: 48462
		[OriginalName("QuestDestroyAction")]
		QuestDestroyAction,
		// Token: 0x0400BD4F RID: 48463
		[OriginalName("RequestGameCurrState")]
		RequestGameCurrState,
		// Token: 0x0400BD50 RID: 48464
		[OriginalName("TemplateSpawnerStateConditionListen")]
		TemplateSpawnerStateConditionListen,
		// Token: 0x0400BD51 RID: 48465
		[OriginalName("CompositionConditionEnterAction")]
		CompositionConditionEnterAction,
		// Token: 0x0400BD52 RID: 48466
		[OriginalName("TrapDefenseSystem")]
		TrapDefenseSystem,
		// Token: 0x0400BD53 RID: 48467
		[OriginalName("SceneItemSequenceFrameEventActionCtx")]
		SceneItemSequenceFrameEventActionCtx,
		// Token: 0x0400BD54 RID: 48468
		[OriginalName("TargetGearHitPart")]
		TargetGearHitPart,
		// Token: 0x0400BD55 RID: 48469
		[OriginalName("GlobalFixCtx")]
		GlobalFixCtx,
		// Token: 0x0400BD56 RID: 48470
		[OriginalName("ChildQuestNodeStuckCheckAction")]
		ChildQuestNodeStuckCheckAction,
		// Token: 0x0400BD57 RID: 48471
		[OriginalName("GameCurrFetchVar")]
		GameCurrFetchVar,
		// Token: 0x0400BD58 RID: 48472
		[OriginalName("EntityAfterConditionActionCtx")]
		EntityAfterConditionActionCtx,
		// Token: 0x0400BD59 RID: 48473
		[OriginalName("ChildQuestNodePreCondition")]
		ChildQuestNodePreCondition,
		// Token: 0x0400BD5A RID: 48474
		[OriginalName("BtNodePreCondition")]
		BtNodePreCondition,
		// Token: 0x0400BD5B RID: 48475
		[OriginalName("DynamicSpawnMonsterRefresherConditionListen")]
		DynamicSpawnMonsterRefresherConditionListen,
		// Token: 0x0400BD5C RID: 48476
		[OriginalName("BeamCastHitPlayerActionCtx")]
		BeamCastHitPlayerActionCtx,
		// Token: 0x0400BD5D RID: 48477
		[OriginalName("MotorSliderCtx")]
		MotorSliderCtx,
		// Token: 0x0400BD5E RID: 48478
		[OriginalName("RollBlockGamePlayActionCtx")]
		RollBlockGamePlayActionCtx,
		// Token: 0x0400BD5F RID: 48479
		[OriginalName("MotorParkourSystem")]
		MotorParkourSystem,
		// Token: 0x0400BD60 RID: 48480
		[OriginalName("TransferCtx")]
		TransferCtx,
		// Token: 0x0400BD61 RID: 48481
		[OriginalName("SystemModuleDataSyncComponent")]
		SystemModuleDataSyncComponent,
		// Token: 0x0400BD62 RID: 48482
		[OriginalName("DynamicEntityRewardCtx")]
		DynamicEntityRewardCtx,
		// Token: 0x0400BD63 RID: 48483
		[OriginalName("ExploreSkillAction")]
		ExploreSkillAction,
		// Token: 0x0400BD64 RID: 48484
		[OriginalName("MotorFightActivity")]
		MotorFightActivity,
		// Token: 0x0400BD65 RID: 48485
		[OriginalName("PasserByNpcSpawnerConditionListenCtx")]
		PasserByNpcSpawnerConditionListenCtx,
		// Token: 0x0400BD66 RID: 48486
		[OriginalName("EffectAreaListeningAction")]
		EffectAreaListeningAction,
		// Token: 0x0400BD67 RID: 48487
		[OriginalName("SurvivorsSystem")]
		SurvivorsSystem,
		// Token: 0x0400BD68 RID: 48488
		[OriginalName("TimeScheduleConditionCtx")]
		TimeScheduleConditionCtx,
		// Token: 0x0400BD69 RID: 48489
		[OriginalName("EntityBeamReceiveConditionCtx")]
		EntityBeamReceiveConditionCtx,
		// Token: 0x0400BD6A RID: 48490
		[OriginalName("FlowerPollutionActionCtx")]
		FlowerPollutionActionCtx,
		// Token: 0x0400BD6B RID: 48491
		[OriginalName("KurotatoSystem")]
		KurotatoSystem,
		// Token: 0x0400BD6C RID: 48492
		[OriginalName("EntityQuickHackSkill")]
		EntityQuickHackSkill,
		// Token: 0x0400BD6D RID: 48493
		[OriginalName("RecallQuestActiveAction")]
		RecallQuestActiveAction,
		// Token: 0x0400BD6E RID: 48494
		[OriginalName("RecallQuestAcceptAction")]
		RecallQuestAcceptAction,
		// Token: 0x0400BD6F RID: 48495
		[OriginalName("RecallQuestFinishAction")]
		RecallQuestFinishAction,
		// Token: 0x0400BD70 RID: 48496
		[OriginalName("RecallQuestDestroyAction")]
		RecallQuestDestroyAction,
		// Token: 0x0400BD71 RID: 48497
		[OriginalName("EdDebugEnterAction")]
		EdDebugEnterAction = 3401,
		// Token: 0x0400BD72 RID: 48498
		[OriginalName("SetClientGlobalVarAction")]
		SetClientGlobalVarAction,
		// Token: 0x0400BD73 RID: 48499
		[OriginalName("CasketTrigger")]
		CasketTrigger = 3501,
		// Token: 0x0400BD74 RID: 48500
		[OriginalName("FoundationCoreOperate")]
		FoundationCoreOperate,
		// Token: 0x0400BD75 RID: 48501
		[OriginalName("TargetGearActionByHitType")]
		TargetGearActionByHitType = 3701,
		// Token: 0x0400BD76 RID: 48502
		[OriginalName("LoopTeleportVolume")]
		LoopTeleportVolume,
		// Token: 0x0400BD77 RID: 48503
		[OriginalName("LongPressInteract")]
		LongPressInteract
	}
}

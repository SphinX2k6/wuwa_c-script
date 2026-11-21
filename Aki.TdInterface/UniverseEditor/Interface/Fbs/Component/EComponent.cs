using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005283 RID: 21123
	public enum EComponent : byte
	{
		// Token: 0x0400E39D RID: 58269
		AirWallSpawnerComponent,
		// Token: 0x0400E39E RID: 58270
		ActorStateComponent,
		// Token: 0x0400E39F RID: 58271
		BehaviorFlowComponent,
		// Token: 0x0400E3A0 RID: 58272
		CalculateComponent,
		// Token: 0x0400E3A1 RID: 58273
		EntitySpawnerComponent,
		// Token: 0x0400E3A2 RID: 58274
		EventComponent,
		// Token: 0x0400E3A3 RID: 58275
		FlowComponent,
		// Token: 0x0400E3A4 RID: 58276
		GrabComponent,
		// Token: 0x0400E3A5 RID: 58277
		InteractiveComponent,
		// Token: 0x0400E3A6 RID: 58278
		LampComponent,
		// Token: 0x0400E3A7 RID: 58279
		MoveComponent,
		// Token: 0x0400E3A8 RID: 58280
		NpcComponent,
		// Token: 0x0400E3A9 RID: 58281
		RefreshEntityComponent,
		// Token: 0x0400E3AA RID: 58282
		RefreshSingleComponent,
		// Token: 0x0400E3AB RID: 58283
		RotatorComponent,
		// Token: 0x0400E3AC RID: 58284
		RotatorComponent2,
		// Token: 0x0400E3AD RID: 58285
		RoleMotionInteractComponent,
		// Token: 0x0400E3AE RID: 58286
		SimpleComponent,
		// Token: 0x0400E3AF RID: 58287
		SphereComponent,
		// Token: 0x0400E3B0 RID: 58288
		SphereFactoryComponent,
		// Token: 0x0400E3B1 RID: 58289
		SpringBoardComponent,
		// Token: 0x0400E3B2 RID: 58290
		SpringComponent,
		// Token: 0x0400E3B3 RID: 58291
		StateComponent,
		// Token: 0x0400E3B4 RID: 58292
		SwitcherComponent,
		// Token: 0x0400E3B5 RID: 58293
		SpawnMonsterComponent,
		// Token: 0x0400E3B6 RID: 58294
		TalkComponent,
		// Token: 0x0400E3B7 RID: 58295
		TrampleUe5Component,
		// Token: 0x0400E3B8 RID: 58296
		TriggerComponent,
		// Token: 0x0400E3B9 RID: 58297
		ClientTriggerComponent,
		// Token: 0x0400E3BA RID: 58298
		TriggerUe5Component,
		// Token: 0x0400E3BB RID: 58299
		UndergroundComponent,
		// Token: 0x0400E3BC RID: 58300
		InteractComponent,
		// Token: 0x0400E3BD RID: 58301
		VarComponent,
		// Token: 0x0400E3BE RID: 58302
		AiComponent,
		// Token: 0x0400E3BF RID: 58303
		LevelAiComponent,
		// Token: 0x0400E3C0 RID: 58304
		AttributeComponent,
		// Token: 0x0400E3C1 RID: 58305
		BaseInfoComponent,
		// Token: 0x0400E3C2 RID: 58306
		RewardComponent,
		// Token: 0x0400E3C3 RID: 58307
		RefreshComponent,
		// Token: 0x0400E3C4 RID: 58308
		RefreshGroupComponent,
		// Token: 0x0400E3C5 RID: 58309
		TreasureBoxComponent,
		// Token: 0x0400E3C6 RID: 58310
		EntityStateComponent,
		// Token: 0x0400E3C7 RID: 58311
		SceneItemAttributeComponent,
		// Token: 0x0400E3C8 RID: 58312
		HookLockPoint,
		// Token: 0x0400E3C9 RID: 58313
		HookFetchComponent,
		// Token: 0x0400E3CA RID: 58314
		TargetGearComponent,
		// Token: 0x0400E3CB RID: 58315
		TargetGearGroupComponent,
		// Token: 0x0400E3CC RID: 58316
		ItemFoundation,
		// Token: 0x0400E3CD RID: 58317
		ItemFoundation2,
		// Token: 0x0400E3CE RID: 58318
		PullingObjectFoundation,
		// Token: 0x0400E3CF RID: 58319
		JigsawItem,
		// Token: 0x0400E3D0 RID: 58320
		JigsawFoundation,
		// Token: 0x0400E3D1 RID: 58321
		CollectComponent,
		// Token: 0x0400E3D2 RID: 58322
		TeleControl2,
		// Token: 0x0400E3D3 RID: 58323
		DestructibleItem,
		// Token: 0x0400E3D4 RID: 58324
		LevelPlayComponent,
		// Token: 0x0400E3D5 RID: 58325
		VisionComponent,
		// Token: 0x0400E3D6 RID: 58326
		VisionCaptureComponent,
		// Token: 0x0400E3D7 RID: 58327
		EntityGroupComponent,
		// Token: 0x0400E3D8 RID: 58328
		ResetEntitiesPosComponent,
		// Token: 0x0400E3D9 RID: 58329
		ResetSelfPosComponent,
		// Token: 0x0400E3DA RID: 58330
		AdsorbComponent,
		// Token: 0x0400E3DB RID: 58331
		TeleportComponent,
		// Token: 0x0400E3DC RID: 58332
		TrampleComponent,
		// Token: 0x0400E3DD RID: 58333
		NpcPerformComponent,
		// Token: 0x0400E3DE RID: 58334
		InteractGearComponent,
		// Token: 0x0400E3DF RID: 58335
		LiftComponent,
		// Token: 0x0400E3E0 RID: 58336
		FollowTrackComponent,
		// Token: 0x0400E3E1 RID: 58337
		SceneItemLifeCycleComponent,
		// Token: 0x0400E3E2 RID: 58338
		BubbleComponent,
		// Token: 0x0400E3E3 RID: 58339
		FightInteractComponent,
		// Token: 0x0400E3E4 RID: 58340
		NearbyTrackingComponent,
		// Token: 0x0400E3E5 RID: 58341
		EntityPackageComponent,
		// Token: 0x0400E3E6 RID: 58342
		SkyboxComponent,
		// Token: 0x0400E3E7 RID: 58343
		StateHintComponent,
		// Token: 0x0400E3E8 RID: 58344
		EntityVisibleComponent,
		// Token: 0x0400E3E9 RID: 58345
		CombinedVisibleGroupComponent,
		// Token: 0x0400E3EA RID: 58346
		WeaponComponent,
		// Token: 0x0400E3EB RID: 58347
		DungeonEntryComponent,
		// Token: 0x0400E3EC RID: 58348
		ResurrectionComponent,
		// Token: 0x0400E3ED RID: 58349
		BuffProducerComponent,
		// Token: 0x0400E3EE RID: 58350
		BuffConsumerComponent,
		// Token: 0x0400E3EF RID: 58351
		GuideLineCreatorComponent,
		// Token: 0x0400E3F0 RID: 58352
		InteractAudioComponent,
		// Token: 0x0400E3F1 RID: 58353
		DropComponent,
		// Token: 0x0400E3F2 RID: 58354
		AdviseItemComponent,
		// Token: 0x0400E3F3 RID: 58355
		VisionItemComponent,
		// Token: 0x0400E3F4 RID: 58356
		MonsterComponent,
		// Token: 0x0400E3F5 RID: 58357
		CombatComponent,
		// Token: 0x0400E3F6 RID: 58358
		EntityListComponent,
		// Token: 0x0400E3F7 RID: 58359
		AnimalComponent,
		// Token: 0x0400E3F8 RID: 58360
		EntityAudioComponent,
		// Token: 0x0400E3F9 RID: 58361
		EntityStateAudioComponent,
		// Token: 0x0400E3FA RID: 58362
		EntityCustomAudioComponent,
		// Token: 0x0400E3FB RID: 58363
		SceneItemMovementComponent,
		// Token: 0x0400E3FC RID: 58364
		RangeComponent,
		// Token: 0x0400E3FD RID: 58365
		ExtraRangeComponent,
		// Token: 0x0400E3FE RID: 58366
		TimelineTrackControlComponent,
		// Token: 0x0400E3FF RID: 58367
		SplineComponent,
		// Token: 0x0400E400 RID: 58368
		SceneActorRefComponent,
		// Token: 0x0400E401 RID: 58369
		EditCustomAoiComponent,
		// Token: 0x0400E402 RID: 58370
		SceneBulletComponent,
		// Token: 0x0400E403 RID: 58371
		TurntableControlComponent,
		// Token: 0x0400E404 RID: 58372
		ConditionListenerComponent,
		// Token: 0x0400E405 RID: 58373
		AttachTargetComponent,
		// Token: 0x0400E406 RID: 58374
		ReboundComponent,
		// Token: 0x0400E407 RID: 58375
		LevitateMagnetComponent,
		// Token: 0x0400E408 RID: 58376
		PhotoTargetComponent,
		// Token: 0x0400E409 RID: 58377
		AiAlertNotifyComponent,
		// Token: 0x0400E40A RID: 58378
		MonsterGachaItemComponent,
		// Token: 0x0400E40B RID: 58379
		MonsterGachaBaseComponent,
		// Token: 0x0400E40C RID: 58380
		ProgressBarControlComponent,
		// Token: 0x0400E40D RID: 58381
		ConveyorBeltComponent,
		// Token: 0x0400E40E RID: 58382
		DynamicTeleportComponent,
		// Token: 0x0400E40F RID: 58383
		ExploreSkillInteractComponent,
		// Token: 0x0400E410 RID: 58384
		ExploreSkillInteractGroupComponent,
		// Token: 0x0400E411 RID: 58385
		FanComponent,
		// Token: 0x0400E412 RID: 58386
		PasserbyNpcSpawnComponent,
		// Token: 0x0400E413 RID: 58387
		ModelComponent,
		// Token: 0x0400E414 RID: 58388
		EntityBundleComponent,
		// Token: 0x0400E415 RID: 58389
		BeamCastComponent,
		// Token: 0x0400E416 RID: 58390
		BeamReceiveComponent,
		// Token: 0x0400E417 RID: 58391
		TimeStopComponent,
		// Token: 0x0400E418 RID: 58392
		PortalComponent,
		// Token: 0x0400E419 RID: 58393
		NoRenderPortalComponent,
		// Token: 0x0400E41A RID: 58394
		EffectAreaComponent,
		// Token: 0x0400E41B RID: 58395
		PhysicsConstraintComponent,
		// Token: 0x0400E41C RID: 58396
		FollowDecorationComponent,
		// Token: 0x0400E41D RID: 58397
		FollowShooterComponent,
		// Token: 0x0400E41E RID: 58398
		ConnectorComponent,
		// Token: 0x0400E41F RID: 58399
		CharacterConnectorComponent,
		// Token: 0x0400E420 RID: 58400
		HitComponent,
		// Token: 0x0400E421 RID: 58401
		DynamicPortalCreatorComponent,
		// Token: 0x0400E422 RID: 58402
		AiGearStrategyComponent,
		// Token: 0x0400E423 RID: 58403
		PickInteractComponent,
		// Token: 0x0400E424 RID: 58404
		LocationSafetyComponent,
		// Token: 0x0400E425 RID: 58405
		BatchBulletCasterComponent,
		// Token: 0x0400E426 RID: 58406
		VehicleComponent,
		// Token: 0x0400E427 RID: 58407
		EnrichmentAreaComponent,
		// Token: 0x0400E428 RID: 58408
		ChessmanComponent,
		// Token: 0x0400E429 RID: 58409
		MonitorComponent,
		// Token: 0x0400E42A RID: 58410
		GroupAiComponent,
		// Token: 0x0400E42B RID: 58411
		InhalationAbilityComponent,
		// Token: 0x0400E42C RID: 58412
		InhaledItemComponent,
		// Token: 0x0400E42D RID: 58413
		AirPassageComponent,
		// Token: 0x0400E42E RID: 58414
		RenderSpecifiedRangeComponent,
		// Token: 0x0400E42F RID: 58415
		LevelPrefabPerformComponent,
		// Token: 0x0400E430 RID: 58416
		SceneItemAiComponent,
		// Token: 0x0400E431 RID: 58417
		GravityFlipComponent,
		// Token: 0x0400E432 RID: 58418
		LevelSequenceFrameEventComponent,
		// Token: 0x0400E433 RID: 58419
		LevelQteComponent,
		// Token: 0x0400E434 RID: 58420
		WalkingPatternComponent,
		// Token: 0x0400E435 RID: 58421
		LifePointCenterComponent,
		// Token: 0x0400E436 RID: 58422
		HackManagementComponent,
		// Token: 0x0400E437 RID: 58423
		ClientConditionListenerComponent,
		// Token: 0x0400E438 RID: 58424
		TemplateEntitySpawnerComponent,
		// Token: 0x0400E439 RID: 58425
		WindSourceComponent,
		// Token: 0x0400E43A RID: 58426
		SlideRailComponent,
		// Token: 0x0400E43B RID: 58427
		CurveControlComponent,
		// Token: 0x0400E43C RID: 58428
		EntityBatchRefreshComponent,
		// Token: 0x0400E43D RID: 58429
		SimpleCombatComponent,
		// Token: 0x0400E43E RID: 58430
		GridObjectComponent,
		// Token: 0x0400E43F RID: 58431
		GodKingFrequencyControllerComponent,
		// Token: 0x0400E440 RID: 58432
		PerformanceOptimizationComponent,
		// Token: 0x0400E441 RID: 58433
		SceneItemEventListenerComponent,
		// Token: 0x0400E442 RID: 58434
		DynamicSpawnMonsterPointComponent,
		// Token: 0x0400E443 RID: 58435
		DynamicSpawnMonsterComponent,
		// Token: 0x0400E444 RID: 58436
		RollBlockComponent,
		// Token: 0x0400E445 RID: 58437
		RollBlockFloorComponent,
		// Token: 0x0400E446 RID: 58438
		RollBlockItemComponent,
		// Token: 0x0400E447 RID: 58439
		SunSpiritCollectComponent,
		// Token: 0x0400E448 RID: 58440
		SunSpiritLauncherComponent,
		// Token: 0x0400E449 RID: 58441
		SunSpiritGearComponent,
		// Token: 0x0400E44A RID: 58442
		MotorSlideComponent,
		// Token: 0x0400E44B RID: 58443
		ProceduralVisualComponent,
		// Token: 0x0400E44C RID: 58444
		RoadNetworkNavigationComponent,
		// Token: 0x0400E44D RID: 58445
		DynamicEntityRewardComponent,
		// Token: 0x0400E44E RID: 58446
		FurnitureSlotComponent,
		// Token: 0x0400E44F RID: 58447
		VisionDisplayComponent,
		// Token: 0x0400E450 RID: 58448
		SystemModuleDataSyncComponent,
		// Token: 0x0400E451 RID: 58449
		ExhibitComponent,
		// Token: 0x0400E452 RID: 58450
		SlidePerformComponent,
		// Token: 0x0400E453 RID: 58451
		TimeScheduleComponent,
		// Token: 0x0400E454 RID: 58452
		ProjectorComponent,
		// Token: 0x0400E455 RID: 58453
		ProceduralMaterialComponent,
		// Token: 0x0400E456 RID: 58454
		GameplayDataPersistenceComponent,
		// Token: 0x0400E457 RID: 58455
		FlowerPollutionComponent,
		// Token: 0x0400E458 RID: 58456
		QuickHackComponent,
		// Token: 0x0400E459 RID: 58457
		DollGrabMachineComponent,
		// Token: 0x0400E45A RID: 58458
		DollGrabShowcaseComponent,
		// Token: 0x0400E45B RID: 58459
		WuWaGoComponent,
		// Token: 0x0400E45C RID: 58460
		DragActorPlayComponent,
		// Token: 0x0400E45D RID: 58461
		PathDrivenActorSpawnerComponent,
		// Token: 0x0400E45E RID: 58462
		ElementalHolderComponent,
		// Token: 0x0400E45F RID: 58463
		ElementalEffectComponent,
		// Token: 0x0400E460 RID: 58464
		IndependentSystemRewardComponent,
		// Token: 0x0400E461 RID: 58465
		Graph3dComponent,
		// Token: 0x0400E462 RID: 58466
		Graph3dEffectComponent,
		// Token: 0x0400E463 RID: 58467
		ElementalBoxFoundationComponent,
		// Token: 0x0400E464 RID: 58468
		ElementalWellComponent,
		// Token: 0x0400E465 RID: 58469
		StreamingSourceTriggerPointComponent,
		// Token: 0x0400E466 RID: 58470
		NoiseRemovalComponent,
		// Token: 0x0400E467 RID: 58471
		SceneTextComponent,
		// Token: 0x0400E468 RID: 58472
		NavMeshComponent,
		// Token: 0x0400E469 RID: 58473
		DynamicLevelPlayComponent,
		// Token: 0x0400E46A RID: 58474
		FrequencyPaintComponent,
		// Token: 0x0400E46B RID: 58475
		TurntableConnectorComponent
	}
}

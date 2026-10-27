using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004D82 RID: 19842
	public enum EComponent : byte
	{
		// Token: 0x0400D85B RID: 55387
		AirWallSpawnerComponent,
		// Token: 0x0400D85C RID: 55388
		ActorStateComponent,
		// Token: 0x0400D85D RID: 55389
		BehaviorFlowComponent,
		// Token: 0x0400D85E RID: 55390
		CalculateComponent,
		// Token: 0x0400D85F RID: 55391
		EntitySpawnerComponent,
		// Token: 0x0400D860 RID: 55392
		EventComponent,
		// Token: 0x0400D861 RID: 55393
		FlowComponent,
		// Token: 0x0400D862 RID: 55394
		GrabComponent,
		// Token: 0x0400D863 RID: 55395
		InteractiveComponent,
		// Token: 0x0400D864 RID: 55396
		LampComponent,
		// Token: 0x0400D865 RID: 55397
		MoveComponent,
		// Token: 0x0400D866 RID: 55398
		NpcComponent,
		// Token: 0x0400D867 RID: 55399
		RefreshEntityComponent,
		// Token: 0x0400D868 RID: 55400
		RefreshSingleComponent,
		// Token: 0x0400D869 RID: 55401
		RotatorComponent,
		// Token: 0x0400D86A RID: 55402
		RotatorComponent2,
		// Token: 0x0400D86B RID: 55403
		RoleMotionInteractComponent,
		// Token: 0x0400D86C RID: 55404
		SimpleComponent,
		// Token: 0x0400D86D RID: 55405
		SphereComponent,
		// Token: 0x0400D86E RID: 55406
		SphereFactoryComponent,
		// Token: 0x0400D86F RID: 55407
		SpringBoardComponent,
		// Token: 0x0400D870 RID: 55408
		SpringComponent,
		// Token: 0x0400D871 RID: 55409
		StateComponent,
		// Token: 0x0400D872 RID: 55410
		SwitcherComponent,
		// Token: 0x0400D873 RID: 55411
		SpawnMonsterComponent,
		// Token: 0x0400D874 RID: 55412
		TalkComponent,
		// Token: 0x0400D875 RID: 55413
		TrampleUe5Component,
		// Token: 0x0400D876 RID: 55414
		TriggerComponent,
		// Token: 0x0400D877 RID: 55415
		ClientTriggerComponent,
		// Token: 0x0400D878 RID: 55416
		TriggerUe5Component,
		// Token: 0x0400D879 RID: 55417
		UndergroundComponent,
		// Token: 0x0400D87A RID: 55418
		InteractComponent,
		// Token: 0x0400D87B RID: 55419
		VarComponent,
		// Token: 0x0400D87C RID: 55420
		AiComponent,
		// Token: 0x0400D87D RID: 55421
		LevelAiComponent,
		// Token: 0x0400D87E RID: 55422
		AttributeComponent,
		// Token: 0x0400D87F RID: 55423
		BaseInfoComponent,
		// Token: 0x0400D880 RID: 55424
		RewardComponent,
		// Token: 0x0400D881 RID: 55425
		RefreshComponent,
		// Token: 0x0400D882 RID: 55426
		RefreshGroupComponent,
		// Token: 0x0400D883 RID: 55427
		TreasureBoxComponent,
		// Token: 0x0400D884 RID: 55428
		EntityStateComponent,
		// Token: 0x0400D885 RID: 55429
		SceneItemAttributeComponent,
		// Token: 0x0400D886 RID: 55430
		HookLockPoint,
		// Token: 0x0400D887 RID: 55431
		HookFetchComponent,
		// Token: 0x0400D888 RID: 55432
		TargetGearComponent,
		// Token: 0x0400D889 RID: 55433
		TargetGearGroupComponent,
		// Token: 0x0400D88A RID: 55434
		ItemFoundation,
		// Token: 0x0400D88B RID: 55435
		ItemFoundation2,
		// Token: 0x0400D88C RID: 55436
		PullingObjectFoundation,
		// Token: 0x0400D88D RID: 55437
		JigsawItem,
		// Token: 0x0400D88E RID: 55438
		JigsawFoundation,
		// Token: 0x0400D88F RID: 55439
		CollectComponent,
		// Token: 0x0400D890 RID: 55440
		TeleControl2,
		// Token: 0x0400D891 RID: 55441
		DestructibleItem,
		// Token: 0x0400D892 RID: 55442
		LevelPlayComponent,
		// Token: 0x0400D893 RID: 55443
		VisionComponent,
		// Token: 0x0400D894 RID: 55444
		VisionCaptureComponent,
		// Token: 0x0400D895 RID: 55445
		EntityGroupComponent,
		// Token: 0x0400D896 RID: 55446
		ResetEntitiesPosComponent,
		// Token: 0x0400D897 RID: 55447
		ResetSelfPosComponent,
		// Token: 0x0400D898 RID: 55448
		AdsorbComponent,
		// Token: 0x0400D899 RID: 55449
		TeleportComponent,
		// Token: 0x0400D89A RID: 55450
		TrampleComponent,
		// Token: 0x0400D89B RID: 55451
		NpcPerformComponent,
		// Token: 0x0400D89C RID: 55452
		InteractGearComponent,
		// Token: 0x0400D89D RID: 55453
		LiftComponent,
		// Token: 0x0400D89E RID: 55454
		FollowTrackComponent,
		// Token: 0x0400D89F RID: 55455
		SceneItemLifeCycleComponent,
		// Token: 0x0400D8A0 RID: 55456
		BubbleComponent,
		// Token: 0x0400D8A1 RID: 55457
		FightInteractComponent,
		// Token: 0x0400D8A2 RID: 55458
		NearbyTrackingComponent,
		// Token: 0x0400D8A3 RID: 55459
		EntityPackageComponent,
		// Token: 0x0400D8A4 RID: 55460
		SkyboxComponent,
		// Token: 0x0400D8A5 RID: 55461
		StateHintComponent,
		// Token: 0x0400D8A6 RID: 55462
		EntityVisibleComponent,
		// Token: 0x0400D8A7 RID: 55463
		CombinedVisibleGroupComponent,
		// Token: 0x0400D8A8 RID: 55464
		WeaponComponent,
		// Token: 0x0400D8A9 RID: 55465
		DungeonEntryComponent,
		// Token: 0x0400D8AA RID: 55466
		ResurrectionComponent,
		// Token: 0x0400D8AB RID: 55467
		BuffProducerComponent,
		// Token: 0x0400D8AC RID: 55468
		BuffConsumerComponent,
		// Token: 0x0400D8AD RID: 55469
		GuideLineCreatorComponent,
		// Token: 0x0400D8AE RID: 55470
		InteractAudioComponent,
		// Token: 0x0400D8AF RID: 55471
		DropComponent,
		// Token: 0x0400D8B0 RID: 55472
		AdviseItemComponent,
		// Token: 0x0400D8B1 RID: 55473
		VisionItemComponent,
		// Token: 0x0400D8B2 RID: 55474
		MonsterComponent,
		// Token: 0x0400D8B3 RID: 55475
		CombatComponent,
		// Token: 0x0400D8B4 RID: 55476
		EntityListComponent,
		// Token: 0x0400D8B5 RID: 55477
		AnimalComponent,
		// Token: 0x0400D8B6 RID: 55478
		EntityAudioComponent,
		// Token: 0x0400D8B7 RID: 55479
		EntityStateAudioComponent,
		// Token: 0x0400D8B8 RID: 55480
		EntityCustomAudioComponent,
		// Token: 0x0400D8B9 RID: 55481
		SceneItemMovementComponent,
		// Token: 0x0400D8BA RID: 55482
		RangeComponent,
		// Token: 0x0400D8BB RID: 55483
		ExtraRangeComponent,
		// Token: 0x0400D8BC RID: 55484
		TimelineTrackControlComponent,
		// Token: 0x0400D8BD RID: 55485
		SplineComponent,
		// Token: 0x0400D8BE RID: 55486
		SceneActorRefComponent,
		// Token: 0x0400D8BF RID: 55487
		EditCustomAoiComponent,
		// Token: 0x0400D8C0 RID: 55488
		SceneBulletComponent,
		// Token: 0x0400D8C1 RID: 55489
		TurntableControlComponent,
		// Token: 0x0400D8C2 RID: 55490
		ConditionListenerComponent,
		// Token: 0x0400D8C3 RID: 55491
		AttachTargetComponent,
		// Token: 0x0400D8C4 RID: 55492
		ReboundComponent,
		// Token: 0x0400D8C5 RID: 55493
		LevitateMagnetComponent,
		// Token: 0x0400D8C6 RID: 55494
		PhotoTargetComponent,
		// Token: 0x0400D8C7 RID: 55495
		AiAlertNotifyComponent,
		// Token: 0x0400D8C8 RID: 55496
		MonsterGachaItemComponent,
		// Token: 0x0400D8C9 RID: 55497
		MonsterGachaBaseComponent,
		// Token: 0x0400D8CA RID: 55498
		ProgressBarControlComponent,
		// Token: 0x0400D8CB RID: 55499
		ConveyorBeltComponent,
		// Token: 0x0400D8CC RID: 55500
		DynamicTeleportComponent,
		// Token: 0x0400D8CD RID: 55501
		ExploreSkillInteractComponent,
		// Token: 0x0400D8CE RID: 55502
		ExploreSkillInteractGroupComponent,
		// Token: 0x0400D8CF RID: 55503
		FanComponent,
		// Token: 0x0400D8D0 RID: 55504
		PasserbyNpcSpawnComponent,
		// Token: 0x0400D8D1 RID: 55505
		ModelComponent,
		// Token: 0x0400D8D2 RID: 55506
		EntityBundleComponent,
		// Token: 0x0400D8D3 RID: 55507
		BeamCastComponent,
		// Token: 0x0400D8D4 RID: 55508
		BeamReceiveComponent,
		// Token: 0x0400D8D5 RID: 55509
		TimeStopComponent,
		// Token: 0x0400D8D6 RID: 55510
		PortalComponent,
		// Token: 0x0400D8D7 RID: 55511
		NoRenderPortalComponent,
		// Token: 0x0400D8D8 RID: 55512
		EffectAreaComponent,
		// Token: 0x0400D8D9 RID: 55513
		PhysicsConstraintComponent,
		// Token: 0x0400D8DA RID: 55514
		FollowDecorationComponent,
		// Token: 0x0400D8DB RID: 55515
		FollowShooterComponent,
		// Token: 0x0400D8DC RID: 55516
		ConnectorComponent,
		// Token: 0x0400D8DD RID: 55517
		CharacterConnectorComponent,
		// Token: 0x0400D8DE RID: 55518
		HitComponent,
		// Token: 0x0400D8DF RID: 55519
		DynamicPortalCreatorComponent,
		// Token: 0x0400D8E0 RID: 55520
		AiGearStrategyComponent,
		// Token: 0x0400D8E1 RID: 55521
		PickInteractComponent,
		// Token: 0x0400D8E2 RID: 55522
		LocationSafetyComponent,
		// Token: 0x0400D8E3 RID: 55523
		BatchBulletCasterComponent,
		// Token: 0x0400D8E4 RID: 55524
		VehicleComponent,
		// Token: 0x0400D8E5 RID: 55525
		EnrichmentAreaComponent,
		// Token: 0x0400D8E6 RID: 55526
		ChessmanComponent,
		// Token: 0x0400D8E7 RID: 55527
		MonitorComponent,
		// Token: 0x0400D8E8 RID: 55528
		GroupAiComponent,
		// Token: 0x0400D8E9 RID: 55529
		InhalationAbilityComponent,
		// Token: 0x0400D8EA RID: 55530
		InhaledItemComponent,
		// Token: 0x0400D8EB RID: 55531
		AirPassageComponent,
		// Token: 0x0400D8EC RID: 55532
		RenderSpecifiedRangeComponent,
		// Token: 0x0400D8ED RID: 55533
		LevelPrefabPerformComponent,
		// Token: 0x0400D8EE RID: 55534
		SceneItemAiComponent,
		// Token: 0x0400D8EF RID: 55535
		GravityFlipComponent,
		// Token: 0x0400D8F0 RID: 55536
		LevelSequenceFrameEventComponent,
		// Token: 0x0400D8F1 RID: 55537
		LevelQteComponent,
		// Token: 0x0400D8F2 RID: 55538
		WalkingPatternComponent,
		// Token: 0x0400D8F3 RID: 55539
		LifePointCenterComponent,
		// Token: 0x0400D8F4 RID: 55540
		HackManagementComponent,
		// Token: 0x0400D8F5 RID: 55541
		ClientConditionListenerComponent,
		// Token: 0x0400D8F6 RID: 55542
		TemplateEntitySpawnerComponent,
		// Token: 0x0400D8F7 RID: 55543
		WindSourceComponent,
		// Token: 0x0400D8F8 RID: 55544
		SlideRailComponent,
		// Token: 0x0400D8F9 RID: 55545
		CurveControlComponent,
		// Token: 0x0400D8FA RID: 55546
		EntityBatchRefreshComponent,
		// Token: 0x0400D8FB RID: 55547
		SimpleCombatComponent,
		// Token: 0x0400D8FC RID: 55548
		GridObjectComponent,
		// Token: 0x0400D8FD RID: 55549
		GodKingFrequencyControllerComponent,
		// Token: 0x0400D8FE RID: 55550
		PerformanceOptimizationComponent,
		// Token: 0x0400D8FF RID: 55551
		SceneItemEventListenerComponent,
		// Token: 0x0400D900 RID: 55552
		DynamicSpawnMonsterPointComponent,
		// Token: 0x0400D901 RID: 55553
		DynamicSpawnMonsterComponent,
		// Token: 0x0400D902 RID: 55554
		RollBlockComponent,
		// Token: 0x0400D903 RID: 55555
		RollBlockFloorComponent,
		// Token: 0x0400D904 RID: 55556
		RollBlockItemComponent,
		// Token: 0x0400D905 RID: 55557
		SunSpiritCollectComponent,
		// Token: 0x0400D906 RID: 55558
		SunSpiritLauncherComponent,
		// Token: 0x0400D907 RID: 55559
		SunSpiritGearComponent,
		// Token: 0x0400D908 RID: 55560
		MotorSlideComponent,
		// Token: 0x0400D909 RID: 55561
		ProceduralVisualComponent,
		// Token: 0x0400D90A RID: 55562
		RoadNetworkNavigationComponent,
		// Token: 0x0400D90B RID: 55563
		DynamicEntityRewardComponent,
		// Token: 0x0400D90C RID: 55564
		FurnitureSlotComponent,
		// Token: 0x0400D90D RID: 55565
		VisionDisplayComponent,
		// Token: 0x0400D90E RID: 55566
		SystemModuleDataSyncComponent,
		// Token: 0x0400D90F RID: 55567
		ExhibitComponent,
		// Token: 0x0400D910 RID: 55568
		SlidePerformComponent,
		// Token: 0x0400D911 RID: 55569
		TimeScheduleComponent,
		// Token: 0x0400D912 RID: 55570
		ProjectorComponent,
		// Token: 0x0400D913 RID: 55571
		ProceduralMaterialComponent,
		// Token: 0x0400D914 RID: 55572
		GameplayDataPersistenceComponent,
		// Token: 0x0400D915 RID: 55573
		FlowerPollutionComponent,
		// Token: 0x0400D916 RID: 55574
		QuickHackComponent,
		// Token: 0x0400D917 RID: 55575
		DollGrabMachineComponent,
		// Token: 0x0400D918 RID: 55576
		DollGrabShowcaseComponent,
		// Token: 0x0400D919 RID: 55577
		WuWaGoComponent,
		// Token: 0x0400D91A RID: 55578
		DragActorPlayComponent,
		// Token: 0x0400D91B RID: 55579
		PathDrivenActorSpawnerComponent,
		// Token: 0x0400D91C RID: 55580
		ElementalHolderComponent,
		// Token: 0x0400D91D RID: 55581
		ElementalEffectComponent,
		// Token: 0x0400D91E RID: 55582
		IndependentSystemRewardComponent,
		// Token: 0x0400D91F RID: 55583
		Graph3dComponent,
		// Token: 0x0400D920 RID: 55584
		Graph3dEffectComponent,
		// Token: 0x0400D921 RID: 55585
		ElementalBoxFoundationComponent,
		// Token: 0x0400D922 RID: 55586
		ElementalWellComponent,
		// Token: 0x0400D923 RID: 55587
		StreamingSourceTriggerPointComponent,
		// Token: 0x0400D924 RID: 55588
		NoiseRemovalComponent,
		// Token: 0x0400D925 RID: 55589
		SceneTextComponent,
		// Token: 0x0400D926 RID: 55590
		NavMeshComponent,
		// Token: 0x0400D927 RID: 55591
		DynamicLevelPlayComponent
	}
}

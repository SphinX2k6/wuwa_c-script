using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200008B RID: 139
	[EnumExtensions]
	public enum EConfigComponent
	{
		// Token: 0x040002C7 RID: 711
		AirWallSpawnerComponent,
		// Token: 0x040002C8 RID: 712
		ActorStateComponent,
		// Token: 0x040002C9 RID: 713
		BehaviorFlowComponent,
		// Token: 0x040002CA RID: 714
		CalculateComponent,
		// Token: 0x040002CB RID: 715
		EntitySpawnerComponent,
		// Token: 0x040002CC RID: 716
		EventComponent,
		// Token: 0x040002CD RID: 717
		FlowComponent,
		// Token: 0x040002CE RID: 718
		GrabComponent,
		// Token: 0x040002CF RID: 719
		InteractiveComponent,
		// Token: 0x040002D0 RID: 720
		LampComponent,
		// Token: 0x040002D1 RID: 721
		MoveComponent,
		// Token: 0x040002D2 RID: 722
		NpcComponent,
		// Token: 0x040002D3 RID: 723
		RefreshEntityComponent,
		// Token: 0x040002D4 RID: 724
		RefreshSingleComponent,
		// Token: 0x040002D5 RID: 725
		RotatorComponent,
		// Token: 0x040002D6 RID: 726
		RotatorComponent2,
		// Token: 0x040002D7 RID: 727
		RoleMotionInteractComponent,
		// Token: 0x040002D8 RID: 728
		SimpleComponent,
		// Token: 0x040002D9 RID: 729
		SphereComponent,
		// Token: 0x040002DA RID: 730
		SphereFactoryComponent,
		// Token: 0x040002DB RID: 731
		SpringBoardComponent,
		// Token: 0x040002DC RID: 732
		SpringComponent,
		// Token: 0x040002DD RID: 733
		StateComponent,
		// Token: 0x040002DE RID: 734
		SwitcherComponent,
		// Token: 0x040002DF RID: 735
		SpawnMonsterComponent,
		// Token: 0x040002E0 RID: 736
		TalkComponent,
		// Token: 0x040002E1 RID: 737
		TrampleUe5Component,
		// Token: 0x040002E2 RID: 738
		TriggerComponent,
		// Token: 0x040002E3 RID: 739
		ClientTriggerComponent,
		// Token: 0x040002E4 RID: 740
		TriggerUe5Component,
		// Token: 0x040002E5 RID: 741
		UndergroundComponent,
		// Token: 0x040002E6 RID: 742
		InteractComponent,
		// Token: 0x040002E7 RID: 743
		VarComponent,
		// Token: 0x040002E8 RID: 744
		AiComponent,
		// Token: 0x040002E9 RID: 745
		LevelAiComponent,
		// Token: 0x040002EA RID: 746
		AttributeComponent,
		// Token: 0x040002EB RID: 747
		BaseInfoComponent,
		// Token: 0x040002EC RID: 748
		RewardComponent,
		// Token: 0x040002ED RID: 749
		RefreshComponent,
		// Token: 0x040002EE RID: 750
		RefreshGroupComponent,
		// Token: 0x040002EF RID: 751
		TreasureBoxComponent,
		// Token: 0x040002F0 RID: 752
		EntityStateComponent,
		// Token: 0x040002F1 RID: 753
		SceneItemAttributeComponent,
		// Token: 0x040002F2 RID: 754
		HookLockPoint,
		// Token: 0x040002F3 RID: 755
		HookFetchComponent,
		// Token: 0x040002F4 RID: 756
		TargetGearComponent,
		// Token: 0x040002F5 RID: 757
		TargetGearGroupComponent,
		// Token: 0x040002F6 RID: 758
		ItemFoundation,
		// Token: 0x040002F7 RID: 759
		ItemFoundation2,
		// Token: 0x040002F8 RID: 760
		PullingObjectFoundation,
		// Token: 0x040002F9 RID: 761
		JigsawItem,
		// Token: 0x040002FA RID: 762
		JigsawFoundation,
		// Token: 0x040002FB RID: 763
		CollectComponent,
		// Token: 0x040002FC RID: 764
		TeleControl2,
		// Token: 0x040002FD RID: 765
		DestructibleItem,
		// Token: 0x040002FE RID: 766
		LevelPlayComponent,
		// Token: 0x040002FF RID: 767
		VisionComponent,
		// Token: 0x04000300 RID: 768
		VisionCaptureComponent,
		// Token: 0x04000301 RID: 769
		EntityGroupComponent,
		// Token: 0x04000302 RID: 770
		ResetEntitiesPosComponent,
		// Token: 0x04000303 RID: 771
		ResetSelfPosComponent,
		// Token: 0x04000304 RID: 772
		AdsorbComponent,
		// Token: 0x04000305 RID: 773
		TeleportComponent,
		// Token: 0x04000306 RID: 774
		TrampleComponent,
		// Token: 0x04000307 RID: 775
		NpcPerformComponent,
		// Token: 0x04000308 RID: 776
		InteractGearComponent,
		// Token: 0x04000309 RID: 777
		LiftComponent,
		// Token: 0x0400030A RID: 778
		FollowTrackComponent,
		// Token: 0x0400030B RID: 779
		SceneItemLifeCycleComponent,
		// Token: 0x0400030C RID: 780
		BubbleComponent,
		// Token: 0x0400030D RID: 781
		FightInteractComponent,
		// Token: 0x0400030E RID: 782
		NearbyTrackingComponent,
		// Token: 0x0400030F RID: 783
		EntityPackageComponent,
		// Token: 0x04000310 RID: 784
		SkyboxComponent,
		// Token: 0x04000311 RID: 785
		StateHintComponent,
		// Token: 0x04000312 RID: 786
		EntityVisibleComponent,
		// Token: 0x04000313 RID: 787
		CombinedVisibleGroupComponent,
		// Token: 0x04000314 RID: 788
		WeaponComponent,
		// Token: 0x04000315 RID: 789
		DungeonEntryComponent,
		// Token: 0x04000316 RID: 790
		ResurrectionComponent,
		// Token: 0x04000317 RID: 791
		BuffProducerComponent,
		// Token: 0x04000318 RID: 792
		BuffConsumerComponent,
		// Token: 0x04000319 RID: 793
		GuideLineCreatorComponent,
		// Token: 0x0400031A RID: 794
		InteractAudioComponent,
		// Token: 0x0400031B RID: 795
		DropComponent,
		// Token: 0x0400031C RID: 796
		AdviseItemComponent,
		// Token: 0x0400031D RID: 797
		VisionItemComponent,
		// Token: 0x0400031E RID: 798
		MonsterComponent,
		// Token: 0x0400031F RID: 799
		CombatComponent,
		// Token: 0x04000320 RID: 800
		EntityListComponent,
		// Token: 0x04000321 RID: 801
		AnimalComponent,
		// Token: 0x04000322 RID: 802
		EntityAudioComponent,
		// Token: 0x04000323 RID: 803
		EntityStateAudioComponent,
		// Token: 0x04000324 RID: 804
		EntityCustomAudioComponent,
		// Token: 0x04000325 RID: 805
		SceneItemMovementComponent,
		// Token: 0x04000326 RID: 806
		RangeComponent,
		// Token: 0x04000327 RID: 807
		ExtraRangeComponent,
		// Token: 0x04000328 RID: 808
		TimelineTrackControlComponent,
		// Token: 0x04000329 RID: 809
		SplineComponent,
		// Token: 0x0400032A RID: 810
		SceneActorRefComponent,
		// Token: 0x0400032B RID: 811
		EditCustomAoiComponent,
		// Token: 0x0400032C RID: 812
		SceneBulletComponent,
		// Token: 0x0400032D RID: 813
		TurntableControlComponent,
		// Token: 0x0400032E RID: 814
		ConditionListenerComponent,
		// Token: 0x0400032F RID: 815
		AttachTargetComponent,
		// Token: 0x04000330 RID: 816
		ReboundComponent,
		// Token: 0x04000331 RID: 817
		LevitateMagnetComponent,
		// Token: 0x04000332 RID: 818
		PhotoTargetComponent,
		// Token: 0x04000333 RID: 819
		AiAlertNotifyComponent,
		// Token: 0x04000334 RID: 820
		MonsterGachaItemComponent,
		// Token: 0x04000335 RID: 821
		MonsterGachaBaseComponent,
		// Token: 0x04000336 RID: 822
		ProgressBarControlComponent,
		// Token: 0x04000337 RID: 823
		ConveyorBeltComponent,
		// Token: 0x04000338 RID: 824
		DynamicTeleportComponent,
		// Token: 0x04000339 RID: 825
		ExploreSkillInteractComponent,
		// Token: 0x0400033A RID: 826
		ExploreSkillInteractGroupComponent,
		// Token: 0x0400033B RID: 827
		FanComponent,
		// Token: 0x0400033C RID: 828
		PasserbyNpcSpawnComponent,
		// Token: 0x0400033D RID: 829
		ModelComponent,
		// Token: 0x0400033E RID: 830
		EntityBundleComponent,
		// Token: 0x0400033F RID: 831
		BeamCastComponent,
		// Token: 0x04000340 RID: 832
		BeamReceiveComponent,
		// Token: 0x04000341 RID: 833
		TimeStopComponent,
		// Token: 0x04000342 RID: 834
		PortalComponent,
		// Token: 0x04000343 RID: 835
		NoRenderPortalComponent,
		// Token: 0x04000344 RID: 836
		EffectAreaComponent,
		// Token: 0x04000345 RID: 837
		PhysicsConstraintComponent,
		// Token: 0x04000346 RID: 838
		FollowDecorationComponent,
		// Token: 0x04000347 RID: 839
		FollowShooterComponent,
		// Token: 0x04000348 RID: 840
		ConnectorComponent,
		// Token: 0x04000349 RID: 841
		CharacterConnectorComponent,
		// Token: 0x0400034A RID: 842
		HitComponent,
		// Token: 0x0400034B RID: 843
		DynamicPortalCreatorComponent,
		// Token: 0x0400034C RID: 844
		AiGearStrategyComponent,
		// Token: 0x0400034D RID: 845
		PickInteractComponent,
		// Token: 0x0400034E RID: 846
		LocationSafetyComponent,
		// Token: 0x0400034F RID: 847
		BatchBulletCasterComponent,
		// Token: 0x04000350 RID: 848
		VehicleComponent,
		// Token: 0x04000351 RID: 849
		EnrichmentAreaComponent,
		// Token: 0x04000352 RID: 850
		ChessmanComponent,
		// Token: 0x04000353 RID: 851
		MonitorComponent,
		// Token: 0x04000354 RID: 852
		GroupAiComponent,
		// Token: 0x04000355 RID: 853
		InhalationAbilityComponent,
		// Token: 0x04000356 RID: 854
		InhaledItemComponent,
		// Token: 0x04000357 RID: 855
		AirPassageComponent,
		// Token: 0x04000358 RID: 856
		RenderSpecifiedRangeComponent,
		// Token: 0x04000359 RID: 857
		LevelPrefabPerformComponent,
		// Token: 0x0400035A RID: 858
		SceneItemAiComponent,
		// Token: 0x0400035B RID: 859
		GravityFlipComponent,
		// Token: 0x0400035C RID: 860
		LevelSequenceFrameEventComponent,
		// Token: 0x0400035D RID: 861
		LevelQteComponent,
		// Token: 0x0400035E RID: 862
		WalkingPatternComponent,
		// Token: 0x0400035F RID: 863
		LifePointCenterComponent,
		// Token: 0x04000360 RID: 864
		HackManagementComponent,
		// Token: 0x04000361 RID: 865
		ClientConditionListenerComponent,
		// Token: 0x04000362 RID: 866
		TemplateEntitySpawnerComponent,
		// Token: 0x04000363 RID: 867
		WindSourceComponent,
		// Token: 0x04000364 RID: 868
		SlideRailComponent,
		// Token: 0x04000365 RID: 869
		CurveControlComponent,
		// Token: 0x04000366 RID: 870
		EntityBatchRefreshComponent,
		// Token: 0x04000367 RID: 871
		SimpleCombatComponent,
		// Token: 0x04000368 RID: 872
		GridObjectComponent,
		// Token: 0x04000369 RID: 873
		GodKingFrequencyControllerComponent,
		// Token: 0x0400036A RID: 874
		PerformanceOptimizationComponent,
		// Token: 0x0400036B RID: 875
		SceneItemEventListenerComponent,
		// Token: 0x0400036C RID: 876
		DynamicSpawnMonsterPointComponent,
		// Token: 0x0400036D RID: 877
		DynamicSpawnMonsterComponent,
		// Token: 0x0400036E RID: 878
		RollBlockComponent,
		// Token: 0x0400036F RID: 879
		RollBlockFloorComponent,
		// Token: 0x04000370 RID: 880
		RollBlockItemComponent,
		// Token: 0x04000371 RID: 881
		SunSpiritCollectComponent,
		// Token: 0x04000372 RID: 882
		SunSpiritLauncherComponent,
		// Token: 0x04000373 RID: 883
		SunSpiritGearComponent,
		// Token: 0x04000374 RID: 884
		MotorSlideComponent,
		// Token: 0x04000375 RID: 885
		ProceduralVisualComponent,
		// Token: 0x04000376 RID: 886
		RoadNetworkNavigationComponent,
		// Token: 0x04000377 RID: 887
		DynamicEntityRewardComponent,
		// Token: 0x04000378 RID: 888
		FurnitureSlotComponent,
		// Token: 0x04000379 RID: 889
		VisionDisplayComponent,
		// Token: 0x0400037A RID: 890
		SystemModuleDataSyncComponent,
		// Token: 0x0400037B RID: 891
		ExhibitComponent,
		// Token: 0x0400037C RID: 892
		SlidePerformComponent,
		// Token: 0x0400037D RID: 893
		TimeScheduleComponent,
		// Token: 0x0400037E RID: 894
		ProjectorComponent,
		// Token: 0x0400037F RID: 895
		ProceduralMaterialComponent,
		// Token: 0x04000380 RID: 896
		GameplayDataPersistenceComponent,
		// Token: 0x04000381 RID: 897
		FlowerPollutionComponent,
		// Token: 0x04000382 RID: 898
		QuickHackComponent,
		// Token: 0x04000383 RID: 899
		DollGrabMachineComponent,
		// Token: 0x04000384 RID: 900
		DollGrabShowcaseComponent,
		// Token: 0x04000385 RID: 901
		WuWaGoComponent,
		// Token: 0x04000386 RID: 902
		DragActorPlayComponent,
		// Token: 0x04000387 RID: 903
		PathDrivenActorSpawnerComponent,
		// Token: 0x04000388 RID: 904
		ElementalHolderComponent,
		// Token: 0x04000389 RID: 905
		ElementalEffectComponent,
		// Token: 0x0400038A RID: 906
		IndependentSystemRewardComponent,
		// Token: 0x0400038B RID: 907
		Graph3dComponent,
		// Token: 0x0400038C RID: 908
		Graph3dEffectComponent,
		// Token: 0x0400038D RID: 909
		ElementalBoxFoundationComponent,
		// Token: 0x0400038E RID: 910
		ElementalWellComponent,
		// Token: 0x0400038F RID: 911
		StreamingSourceTriggerPointComponent,
		// Token: 0x04000390 RID: 912
		NoiseRemovalComponent,
		// Token: 0x04000391 RID: 913
		SceneTextComponent,
		// Token: 0x04000392 RID: 914
		NavMeshComponent,
		// Token: 0x04000393 RID: 915
		DynamicLevelPlayComponent,
		// Token: 0x04000394 RID: 916
		FrequencyPaintComponent,
		// Token: 0x04000395 RID: 917
		TurntableConnectorComponent
	}
}

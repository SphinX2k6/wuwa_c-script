using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000086 RID: 134
	[EnumExtensions]
	public enum EConfigComponent
	{
		// Token: 0x040002B0 RID: 688
		AirWallSpawnerComponent,
		// Token: 0x040002B1 RID: 689
		ActorStateComponent,
		// Token: 0x040002B2 RID: 690
		BehaviorFlowComponent,
		// Token: 0x040002B3 RID: 691
		CalculateComponent,
		// Token: 0x040002B4 RID: 692
		EntitySpawnerComponent,
		// Token: 0x040002B5 RID: 693
		EventComponent,
		// Token: 0x040002B6 RID: 694
		FlowComponent,
		// Token: 0x040002B7 RID: 695
		GrabComponent,
		// Token: 0x040002B8 RID: 696
		InteractiveComponent,
		// Token: 0x040002B9 RID: 697
		LampComponent,
		// Token: 0x040002BA RID: 698
		MoveComponent,
		// Token: 0x040002BB RID: 699
		NpcComponent,
		// Token: 0x040002BC RID: 700
		RefreshEntityComponent,
		// Token: 0x040002BD RID: 701
		RefreshSingleComponent,
		// Token: 0x040002BE RID: 702
		RotatorComponent,
		// Token: 0x040002BF RID: 703
		RotatorComponent2,
		// Token: 0x040002C0 RID: 704
		RoleMotionInteractComponent,
		// Token: 0x040002C1 RID: 705
		SimpleComponent,
		// Token: 0x040002C2 RID: 706
		SphereComponent,
		// Token: 0x040002C3 RID: 707
		SphereFactoryComponent,
		// Token: 0x040002C4 RID: 708
		SpringBoardComponent,
		// Token: 0x040002C5 RID: 709
		SpringComponent,
		// Token: 0x040002C6 RID: 710
		StateComponent,
		// Token: 0x040002C7 RID: 711
		SwitcherComponent,
		// Token: 0x040002C8 RID: 712
		SpawnMonsterComponent,
		// Token: 0x040002C9 RID: 713
		TalkComponent,
		// Token: 0x040002CA RID: 714
		TrampleUe5Component,
		// Token: 0x040002CB RID: 715
		TriggerComponent,
		// Token: 0x040002CC RID: 716
		ClientTriggerComponent,
		// Token: 0x040002CD RID: 717
		TriggerUe5Component,
		// Token: 0x040002CE RID: 718
		UndergroundComponent,
		// Token: 0x040002CF RID: 719
		InteractComponent,
		// Token: 0x040002D0 RID: 720
		VarComponent,
		// Token: 0x040002D1 RID: 721
		AiComponent,
		// Token: 0x040002D2 RID: 722
		LevelAiComponent,
		// Token: 0x040002D3 RID: 723
		AttributeComponent,
		// Token: 0x040002D4 RID: 724
		BaseInfoComponent,
		// Token: 0x040002D5 RID: 725
		RewardComponent,
		// Token: 0x040002D6 RID: 726
		RefreshComponent,
		// Token: 0x040002D7 RID: 727
		RefreshGroupComponent,
		// Token: 0x040002D8 RID: 728
		TreasureBoxComponent,
		// Token: 0x040002D9 RID: 729
		EntityStateComponent,
		// Token: 0x040002DA RID: 730
		SceneItemAttributeComponent,
		// Token: 0x040002DB RID: 731
		HookLockPoint,
		// Token: 0x040002DC RID: 732
		HookFetchComponent,
		// Token: 0x040002DD RID: 733
		TargetGearComponent,
		// Token: 0x040002DE RID: 734
		TargetGearGroupComponent,
		// Token: 0x040002DF RID: 735
		ItemFoundation,
		// Token: 0x040002E0 RID: 736
		ItemFoundation2,
		// Token: 0x040002E1 RID: 737
		PullingObjectFoundation,
		// Token: 0x040002E2 RID: 738
		JigsawItem,
		// Token: 0x040002E3 RID: 739
		JigsawFoundation,
		// Token: 0x040002E4 RID: 740
		CollectComponent,
		// Token: 0x040002E5 RID: 741
		TeleControl2,
		// Token: 0x040002E6 RID: 742
		DestructibleItem,
		// Token: 0x040002E7 RID: 743
		LevelPlayComponent,
		// Token: 0x040002E8 RID: 744
		VisionComponent,
		// Token: 0x040002E9 RID: 745
		VisionCaptureComponent,
		// Token: 0x040002EA RID: 746
		EntityGroupComponent,
		// Token: 0x040002EB RID: 747
		ResetEntitiesPosComponent,
		// Token: 0x040002EC RID: 748
		ResetSelfPosComponent,
		// Token: 0x040002ED RID: 749
		AdsorbComponent,
		// Token: 0x040002EE RID: 750
		TeleportComponent,
		// Token: 0x040002EF RID: 751
		TrampleComponent,
		// Token: 0x040002F0 RID: 752
		NpcPerformComponent,
		// Token: 0x040002F1 RID: 753
		InteractGearComponent,
		// Token: 0x040002F2 RID: 754
		LiftComponent,
		// Token: 0x040002F3 RID: 755
		FollowTrackComponent,
		// Token: 0x040002F4 RID: 756
		SceneItemLifeCycleComponent,
		// Token: 0x040002F5 RID: 757
		BubbleComponent,
		// Token: 0x040002F6 RID: 758
		FightInteractComponent,
		// Token: 0x040002F7 RID: 759
		NearbyTrackingComponent,
		// Token: 0x040002F8 RID: 760
		EntityPackageComponent,
		// Token: 0x040002F9 RID: 761
		SkyboxComponent,
		// Token: 0x040002FA RID: 762
		StateHintComponent,
		// Token: 0x040002FB RID: 763
		EntityVisibleComponent,
		// Token: 0x040002FC RID: 764
		CombinedVisibleGroupComponent,
		// Token: 0x040002FD RID: 765
		WeaponComponent,
		// Token: 0x040002FE RID: 766
		DungeonEntryComponent,
		// Token: 0x040002FF RID: 767
		ResurrectionComponent,
		// Token: 0x04000300 RID: 768
		BuffProducerComponent,
		// Token: 0x04000301 RID: 769
		BuffConsumerComponent,
		// Token: 0x04000302 RID: 770
		GuideLineCreatorComponent,
		// Token: 0x04000303 RID: 771
		InteractAudioComponent,
		// Token: 0x04000304 RID: 772
		DropComponent,
		// Token: 0x04000305 RID: 773
		AdviseItemComponent,
		// Token: 0x04000306 RID: 774
		VisionItemComponent,
		// Token: 0x04000307 RID: 775
		MonsterComponent,
		// Token: 0x04000308 RID: 776
		CombatComponent,
		// Token: 0x04000309 RID: 777
		EntityListComponent,
		// Token: 0x0400030A RID: 778
		AnimalComponent,
		// Token: 0x0400030B RID: 779
		EntityAudioComponent,
		// Token: 0x0400030C RID: 780
		EntityStateAudioComponent,
		// Token: 0x0400030D RID: 781
		EntityCustomAudioComponent,
		// Token: 0x0400030E RID: 782
		SceneItemMovementComponent,
		// Token: 0x0400030F RID: 783
		RangeComponent,
		// Token: 0x04000310 RID: 784
		ExtraRangeComponent,
		// Token: 0x04000311 RID: 785
		TimelineTrackControlComponent,
		// Token: 0x04000312 RID: 786
		SplineComponent,
		// Token: 0x04000313 RID: 787
		SceneActorRefComponent,
		// Token: 0x04000314 RID: 788
		EditCustomAoiComponent,
		// Token: 0x04000315 RID: 789
		SceneBulletComponent,
		// Token: 0x04000316 RID: 790
		TurntableControlComponent,
		// Token: 0x04000317 RID: 791
		ConditionListenerComponent,
		// Token: 0x04000318 RID: 792
		AttachTargetComponent,
		// Token: 0x04000319 RID: 793
		ReboundComponent,
		// Token: 0x0400031A RID: 794
		LevitateMagnetComponent,
		// Token: 0x0400031B RID: 795
		PhotoTargetComponent,
		// Token: 0x0400031C RID: 796
		AiAlertNotifyComponent,
		// Token: 0x0400031D RID: 797
		MonsterGachaItemComponent,
		// Token: 0x0400031E RID: 798
		MonsterGachaBaseComponent,
		// Token: 0x0400031F RID: 799
		ProgressBarControlComponent,
		// Token: 0x04000320 RID: 800
		ConveyorBeltComponent,
		// Token: 0x04000321 RID: 801
		DynamicTeleportComponent,
		// Token: 0x04000322 RID: 802
		ExploreSkillInteractComponent,
		// Token: 0x04000323 RID: 803
		ExploreSkillInteractGroupComponent,
		// Token: 0x04000324 RID: 804
		FanComponent,
		// Token: 0x04000325 RID: 805
		PasserbyNpcSpawnComponent,
		// Token: 0x04000326 RID: 806
		ModelComponent,
		// Token: 0x04000327 RID: 807
		EntityBundleComponent,
		// Token: 0x04000328 RID: 808
		BeamCastComponent,
		// Token: 0x04000329 RID: 809
		BeamReceiveComponent,
		// Token: 0x0400032A RID: 810
		TimeStopComponent,
		// Token: 0x0400032B RID: 811
		PortalComponent,
		// Token: 0x0400032C RID: 812
		NoRenderPortalComponent,
		// Token: 0x0400032D RID: 813
		EffectAreaComponent,
		// Token: 0x0400032E RID: 814
		PhysicsConstraintComponent,
		// Token: 0x0400032F RID: 815
		FollowDecorationComponent,
		// Token: 0x04000330 RID: 816
		FollowShooterComponent,
		// Token: 0x04000331 RID: 817
		ConnectorComponent,
		// Token: 0x04000332 RID: 818
		CharacterConnectorComponent,
		// Token: 0x04000333 RID: 819
		HitComponent,
		// Token: 0x04000334 RID: 820
		DynamicPortalCreatorComponent,
		// Token: 0x04000335 RID: 821
		AiGearStrategyComponent,
		// Token: 0x04000336 RID: 822
		PickInteractComponent,
		// Token: 0x04000337 RID: 823
		LocationSafetyComponent,
		// Token: 0x04000338 RID: 824
		BatchBulletCasterComponent,
		// Token: 0x04000339 RID: 825
		VehicleComponent,
		// Token: 0x0400033A RID: 826
		EnrichmentAreaComponent,
		// Token: 0x0400033B RID: 827
		ChessmanComponent,
		// Token: 0x0400033C RID: 828
		MonitorComponent,
		// Token: 0x0400033D RID: 829
		GroupAiComponent,
		// Token: 0x0400033E RID: 830
		InhalationAbilityComponent,
		// Token: 0x0400033F RID: 831
		InhaledItemComponent,
		// Token: 0x04000340 RID: 832
		AirPassageComponent,
		// Token: 0x04000341 RID: 833
		RenderSpecifiedRangeComponent,
		// Token: 0x04000342 RID: 834
		LevelPrefabPerformComponent,
		// Token: 0x04000343 RID: 835
		SceneItemAiComponent,
		// Token: 0x04000344 RID: 836
		GravityFlipComponent,
		// Token: 0x04000345 RID: 837
		LevelSequenceFrameEventComponent,
		// Token: 0x04000346 RID: 838
		LevelQteComponent,
		// Token: 0x04000347 RID: 839
		WalkingPatternComponent,
		// Token: 0x04000348 RID: 840
		LifePointCenterComponent,
		// Token: 0x04000349 RID: 841
		HackManagementComponent,
		// Token: 0x0400034A RID: 842
		ClientConditionListenerComponent,
		// Token: 0x0400034B RID: 843
		TemplateEntitySpawnerComponent,
		// Token: 0x0400034C RID: 844
		WindSourceComponent,
		// Token: 0x0400034D RID: 845
		SlideRailComponent,
		// Token: 0x0400034E RID: 846
		CurveControlComponent,
		// Token: 0x0400034F RID: 847
		EntityBatchRefreshComponent,
		// Token: 0x04000350 RID: 848
		SimpleCombatComponent,
		// Token: 0x04000351 RID: 849
		GridObjectComponent,
		// Token: 0x04000352 RID: 850
		GodKingFrequencyControllerComponent,
		// Token: 0x04000353 RID: 851
		PerformanceOptimizationComponent,
		// Token: 0x04000354 RID: 852
		SceneItemEventListenerComponent,
		// Token: 0x04000355 RID: 853
		DynamicSpawnMonsterPointComponent,
		// Token: 0x04000356 RID: 854
		DynamicSpawnMonsterComponent,
		// Token: 0x04000357 RID: 855
		RollBlockComponent,
		// Token: 0x04000358 RID: 856
		RollBlockFloorComponent,
		// Token: 0x04000359 RID: 857
		RollBlockItemComponent,
		// Token: 0x0400035A RID: 858
		SunSpiritCollectComponent,
		// Token: 0x0400035B RID: 859
		SunSpiritLauncherComponent,
		// Token: 0x0400035C RID: 860
		SunSpiritGearComponent,
		// Token: 0x0400035D RID: 861
		MotorSlideComponent,
		// Token: 0x0400035E RID: 862
		ProceduralVisualComponent,
		// Token: 0x0400035F RID: 863
		RoadNetworkNavigationComponent,
		// Token: 0x04000360 RID: 864
		DynamicEntityRewardComponent,
		// Token: 0x04000361 RID: 865
		FurnitureSlotComponent,
		// Token: 0x04000362 RID: 866
		VisionDisplayComponent,
		// Token: 0x04000363 RID: 867
		SystemModuleDataSyncComponent,
		// Token: 0x04000364 RID: 868
		ExhibitComponent,
		// Token: 0x04000365 RID: 869
		SlidePerformComponent,
		// Token: 0x04000366 RID: 870
		TimeScheduleComponent,
		// Token: 0x04000367 RID: 871
		ProjectorComponent,
		// Token: 0x04000368 RID: 872
		ProceduralMaterialComponent,
		// Token: 0x04000369 RID: 873
		GameplayDataPersistenceComponent,
		// Token: 0x0400036A RID: 874
		FlowerPollutionComponent,
		// Token: 0x0400036B RID: 875
		QuickHackComponent,
		// Token: 0x0400036C RID: 876
		DollGrabMachineComponent,
		// Token: 0x0400036D RID: 877
		DollGrabShowcaseComponent,
		// Token: 0x0400036E RID: 878
		WuWaGoComponent,
		// Token: 0x0400036F RID: 879
		DragActorPlayComponent,
		// Token: 0x04000370 RID: 880
		PathDrivenActorSpawnerComponent,
		// Token: 0x04000371 RID: 881
		ElementalHolderComponent,
		// Token: 0x04000372 RID: 882
		ElementalEffectComponent,
		// Token: 0x04000373 RID: 883
		IndependentSystemRewardComponent,
		// Token: 0x04000374 RID: 884
		Graph3dComponent,
		// Token: 0x04000375 RID: 885
		Graph3dEffectComponent,
		// Token: 0x04000376 RID: 886
		ElementalBoxFoundationComponent,
		// Token: 0x04000377 RID: 887
		ElementalWellComponent,
		// Token: 0x04000378 RID: 888
		StreamingSourceTriggerPointComponent,
		// Token: 0x04000379 RID: 889
		NoiseRemovalComponent,
		// Token: 0x0400037A RID: 890
		SceneTextComponent,
		// Token: 0x0400037B RID: 891
		NavMeshComponent,
		// Token: 0x0400037C RID: 892
		DynamicLevelPlayComponent
	}
}

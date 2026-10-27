using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004771 RID: 18289
	public enum EEntity : ushort
	{
		// Token: 0x0400CA7A RID: 51834
		CharacterEntity,
		// Token: 0x0400CA7B RID: 51835
		Npc,
		// Token: 0x0400CA7C RID: 51836
		Npc2,
		// Token: 0x0400CA7D RID: 51837
		Trample,
		// Token: 0x0400CA7E RID: 51838
		Trample2,
		// Token: 0x0400CA7F RID: 51839
		Trample3,
		// Token: 0x0400CA80 RID: 51840
		TrampleWithSceneItemAttribute,
		// Token: 0x0400CA81 RID: 51841
		EntityPackage,
		// Token: 0x0400CA82 RID: 51842
		EntityList,
		// Token: 0x0400CA83 RID: 51843
		Player,
		// Token: 0x0400CA84 RID: 51844
		AiNpc,
		// Token: 0x0400CA85 RID: 51845
		Entity,
		// Token: 0x0400CA86 RID: 51846
		Lamp,
		// Token: 0x0400CA87 RID: 51847
		RefreshSingle,
		// Token: 0x0400CA88 RID: 51848
		RefreshEntity,
		// Token: 0x0400CA89 RID: 51849
		Rotator,
		// Token: 0x0400CA8A RID: 51850
		SphereActor,
		// Token: 0x0400CA8B RID: 51851
		SphereFactory,
		// Token: 0x0400CA8C RID: 51852
		Spring,
		// Token: 0x0400CA8D RID: 51853
		SpringBoard,
		// Token: 0x0400CA8E RID: 51854
		StateEntity,
		// Token: 0x0400CA8F RID: 51855
		Switcher,
		// Token: 0x0400CA90 RID: 51856
		TriggerUe5,
		// Token: 0x0400CA91 RID: 51857
		Underground,
		// Token: 0x0400CA92 RID: 51858
		UndergroundComponent,
		// Token: 0x0400CA93 RID: 51859
		RefreshComponent,
		// Token: 0x0400CA94 RID: 51860
		Item,
		// Token: 0x0400CA95 RID: 51861
		Gear,
		// Token: 0x0400CA96 RID: 51862
		FollowTrack,
		// Token: 0x0400CA97 RID: 51863
		FollowTrackFoundation,
		// Token: 0x0400CA98 RID: 51864
		Animal,
		// Token: 0x0400CA99 RID: 51865
		Animal2,
		// Token: 0x0400CA9A RID: 51866
		CombatAnimal,
		// Token: 0x0400CA9B RID: 51867
		CombatAnimal2,
		// Token: 0x0400CA9C RID: 51868
		CombatAnimal3,
		// Token: 0x0400CA9D RID: 51869
		CollectAnimal,
		// Token: 0x0400CA9E RID: 51870
		Monster,
		// Token: 0x0400CA9F RID: 51871
		NpcMonster,
		// Token: 0x0400CAA0 RID: 51872
		MonsterWithInhalation,
		// Token: 0x0400CAA1 RID: 51873
		GroupAi,
		// Token: 0x0400CAA2 RID: 51874
		FollowShooter,
		// Token: 0x0400CAA3 RID: 51875
		FollowShooter2,
		// Token: 0x0400CAA4 RID: 51876
		HackingTypeFollowShooter,
		// Token: 0x0400CAA5 RID: 51877
		SimpleInteract,
		// Token: 0x0400CAA6 RID: 51878
		Collect,
		// Token: 0x0400CAA7 RID: 51879
		Collect2,
		// Token: 0x0400CAA8 RID: 51880
		Collect3,
		// Token: 0x0400CAA9 RID: 51881
		CollectWithListener,
		// Token: 0x0400CAAA RID: 51882
		CollectWithHook,
		// Token: 0x0400CAAB RID: 51883
		TreasureBox,
		// Token: 0x0400CAAC RID: 51884
		VisionTreasureBox,
		// Token: 0x0400CAAD RID: 51885
		HookTreasureBox,
		// Token: 0x0400CAAE RID: 51886
		Trigger,
		// Token: 0x0400CAAF RID: 51887
		ClientTrigger,
		// Token: 0x0400CAB0 RID: 51888
		VisibleTrigger,
		// Token: 0x0400CAB1 RID: 51889
		LevelQteTrigger,
		// Token: 0x0400CAB2 RID: 51890
		LevelSeqTrigger,
		// Token: 0x0400CAB3 RID: 51891
		HookLockPoint,
		// Token: 0x0400CAB4 RID: 51892
		RoleMotionInteractPoint,
		// Token: 0x0400CAB5 RID: 51893
		KiteHook,
		// Token: 0x0400CAB6 RID: 51894
		SuiGuangHook,
		// Token: 0x0400CAB7 RID: 51895
		HookWithRange,
		// Token: 0x0400CAB8 RID: 51896
		TimeScaledHook,
		// Token: 0x0400CAB9 RID: 51897
		CableWayHook,
		// Token: 0x0400CABA RID: 51898
		HookPullSoundBox,
		// Token: 0x0400CABB RID: 51899
		HookPullSoundBoxWithSplineMove,
		// Token: 0x0400CABC RID: 51900
		ItemFoundation,
		// Token: 0x0400CABD RID: 51901
		StatueFoundation,
		// Token: 0x0400CABE RID: 51902
		AdsorptionFoundation,
		// Token: 0x0400CABF RID: 51903
		InteractFoundation,
		// Token: 0x0400CAC0 RID: 51904
		InteractFoundationWithSceneItemAttribute,
		// Token: 0x0400CAC1 RID: 51905
		MatchGear,
		// Token: 0x0400CAC2 RID: 51906
		MatchGroup,
		// Token: 0x0400CAC3 RID: 51907
		InteractGearGroup,
		// Token: 0x0400CAC4 RID: 51908
		RefreshGroup,
		// Token: 0x0400CAC5 RID: 51909
		EntityBatchRefresh,
		// Token: 0x0400CAC6 RID: 51910
		TeleControl,
		// Token: 0x0400CAC7 RID: 51911
		TeleControl2,
		// Token: 0x0400CAC8 RID: 51912
		TeleControl3,
		// Token: 0x0400CAC9 RID: 51913
		TeleControl4,
		// Token: 0x0400CACA RID: 51914
		TeleControlGroup,
		// Token: 0x0400CACB RID: 51915
		TargetGear,
		// Token: 0x0400CACC RID: 51916
		TargetGear2,
		// Token: 0x0400CACD RID: 51917
		TargetGearPro,
		// Token: 0x0400CACE RID: 51918
		RangeTriggerTargetGear,
		// Token: 0x0400CACF RID: 51919
		TargetGearWithVariable,
		// Token: 0x0400CAD0 RID: 51920
		TargetGearWithLevelPrefabPerform,
		// Token: 0x0400CAD1 RID: 51921
		TargetGearWithConditionListener,
		// Token: 0x0400CAD2 RID: 51922
		TargetGearGroup,
		// Token: 0x0400CAD3 RID: 51923
		TargetGearGroup2,
		// Token: 0x0400CAD4 RID: 51924
		Destructible,
		// Token: 0x0400CAD5 RID: 51925
		DestructibleWithSceneItemAttribute,
		// Token: 0x0400CAD6 RID: 51926
		DestructibleControl,
		// Token: 0x0400CAD7 RID: 51927
		DestructibleTrigger,
		// Token: 0x0400CAD8 RID: 51928
		DestructibleSceneBullet,
		// Token: 0x0400CAD9 RID: 51929
		DestructibleExploreInteractor,
		// Token: 0x0400CADA RID: 51930
		TargetGearExploreInteractor,
		// Token: 0x0400CADB RID: 51931
		CurveControlDestructible,
		// Token: 0x0400CADC RID: 51932
		LevelPlay,
		// Token: 0x0400CADD RID: 51933
		LevelPlay2,
		// Token: 0x0400CADE RID: 51934
		LevelPlayReward,
		// Token: 0x0400CADF RID: 51935
		Teleporter,
		// Token: 0x0400CAE0 RID: 51936
		TriggerTeleporter,
		// Token: 0x0400CAE1 RID: 51937
		DungeonTeleporter,
		// Token: 0x0400CAE2 RID: 51938
		InteractGear,
		// Token: 0x0400CAE3 RID: 51939
		InteractGear2,
		// Token: 0x0400CAE4 RID: 51940
		InteractGearCanHit,
		// Token: 0x0400CAE5 RID: 51941
		InteractGearTrigger,
		// Token: 0x0400CAE6 RID: 51942
		GameplayInteractGear,
		// Token: 0x0400CAE7 RID: 51943
		SpawnMonster,
		// Token: 0x0400CAE8 RID: 51944
		BondageTrap,
		// Token: 0x0400CAE9 RID: 51945
		RollingFireball,
		// Token: 0x0400CAEA RID: 51946
		Lift,
		// Token: 0x0400CAEB RID: 51947
		Lift2,
		// Token: 0x0400CAEC RID: 51948
		SequenceLift,
		// Token: 0x0400CAED RID: 51949
		BurstCrystalFoundation,
		// Token: 0x0400CAEE RID: 51950
		BurstCrystalFoundation2,
		// Token: 0x0400CAEF RID: 51951
		GuardTarget,
		// Token: 0x0400CAF0 RID: 51952
		ChallengeInteract,
		// Token: 0x0400CAF1 RID: 51953
		SkyboxTrigger,
		// Token: 0x0400CAF2 RID: 51954
		SceneItemStateHint,
		// Token: 0x0400CAF3 RID: 51955
		SceneAura,
		// Token: 0x0400CAF4 RID: 51956
		StateSceneItem,
		// Token: 0x0400CAF5 RID: 51957
		BubbleSceneItem,
		// Token: 0x0400CAF6 RID: 51958
		Weapon,
		// Token: 0x0400CAF7 RID: 51959
		CookTool,
		// Token: 0x0400CAF8 RID: 51960
		DungeonEntry,
		// Token: 0x0400CAF9 RID: 51961
		DungeonEntryWithTrigger,
		// Token: 0x0400CAFA RID: 51962
		Resurrection,
		// Token: 0x0400CAFB RID: 51963
		BuffProducer,
		// Token: 0x0400CAFC RID: 51964
		BuffConsumer,
		// Token: 0x0400CAFD RID: 51965
		StateTrigger,
		// Token: 0x0400CAFE RID: 51966
		GuideLineCreator,
		// Token: 0x0400CAFF RID: 51967
		Vision,
		// Token: 0x0400CB00 RID: 51968
		Drop,
		// Token: 0x0400CB01 RID: 51969
		DropItem,
		// Token: 0x0400CB02 RID: 51970
		VisionItem,
		// Token: 0x0400CB03 RID: 51971
		AdviseItem,
		// Token: 0x0400CB04 RID: 51972
		SoundBox,
		// Token: 0x0400CB05 RID: 51973
		HookSoundBox,
		// Token: 0x0400CB06 RID: 51974
		AnnunciatorCenter,
		// Token: 0x0400CB07 RID: 51975
		AnnunciatorWire,
		// Token: 0x0400CB08 RID: 51976
		LifePointCenter,
		// Token: 0x0400CB09 RID: 51977
		DaemonHack,
		// Token: 0x0400CB0A RID: 51978
		Chair,
		// Token: 0x0400CB0B RID: 51979
		Chair2,
		// Token: 0x0400CB0C RID: 51980
		FollowDecorationChair,
		// Token: 0x0400CB0D RID: 51981
		Audio,
		// Token: 0x0400CB0E RID: 51982
		AudioBox,
		// Token: 0x0400CB0F RID: 51983
		Gramophone,
		// Token: 0x0400CB10 RID: 51984
		Disc,
		// Token: 0x0400CB11 RID: 51985
		AreaOccupation,
		// Token: 0x0400CB12 RID: 51986
		Position,
		// Token: 0x0400CB13 RID: 51987
		Range,
		// Token: 0x0400CB14 RID: 51988
		TimelineTrackController,
		// Token: 0x0400CB15 RID: 51989
		Spline,
		// Token: 0x0400CB16 RID: 51990
		MoveableTrigger,
		// Token: 0x0400CB17 RID: 51991
		CustomAoiEditor,
		// Token: 0x0400CB18 RID: 51992
		CombinedVisibleGroup,
		// Token: 0x0400CB19 RID: 51993
		SceneBullet,
		// Token: 0x0400CB1A RID: 51994
		SceneBulletWithMovement,
		// Token: 0x0400CB1B RID: 51995
		SceneBulletCanHit,
		// Token: 0x0400CB1C RID: 51996
		SceneBulletTrigger,
		// Token: 0x0400CB1D RID: 51997
		DestructibleListenerSceneBullet,
		// Token: 0x0400CB1E RID: 51998
		TurntableController,
		// Token: 0x0400CB1F RID: 51999
		InteractiveConditionListener,
		// Token: 0x0400CB20 RID: 52000
		TriggerConditionListener,
		// Token: 0x0400CB21 RID: 52001
		HitConditionListener,
		// Token: 0x0400CB22 RID: 52002
		ReboundPlateGear,
		// Token: 0x0400CB23 RID: 52003
		JigsawItem,
		// Token: 0x0400CB24 RID: 52004
		JigsawFoundation,
		// Token: 0x0400CB25 RID: 52005
		LevitateMagnet,
		// Token: 0x0400CB26 RID: 52006
		SoundTransmitter,
		// Token: 0x0400CB27 RID: 52007
		PhotoTarget,
		// Token: 0x0400CB28 RID: 52008
		AiAlertNotifier,
		// Token: 0x0400CB29 RID: 52009
		MonsterGachaItem,
		// Token: 0x0400CB2A RID: 52010
		MonsterGachaBase,
		// Token: 0x0400CB2B RID: 52011
		SimpleNpc,
		// Token: 0x0400CB2C RID: 52012
		ProgressBarController,
		// Token: 0x0400CB2D RID: 52013
		ProgressBarControllerWithAttribute,
		// Token: 0x0400CB2E RID: 52014
		ConveyorBelt,
		// Token: 0x0400CB2F RID: 52015
		TemporaryTeleporter,
		// Token: 0x0400CB30 RID: 52016
		ExploreSkillInteractor,
		// Token: 0x0400CB31 RID: 52017
		ExploreSkillGroupInteractor,
		// Token: 0x0400CB32 RID: 52018
		PullingObject,
		// Token: 0x0400CB33 RID: 52019
		WaterSpout,
		// Token: 0x0400CB34 RID: 52020
		PasserbyNpc,
		// Token: 0x0400CB35 RID: 52021
		ElementalNpc,
		// Token: 0x0400CB36 RID: 52022
		SpawnPasserbyNpc,
		// Token: 0x0400CB37 RID: 52023
		LightDeliver,
		// Token: 0x0400CB38 RID: 52024
		BeamCaster,
		// Token: 0x0400CB39 RID: 52025
		BeamReceiver,
		// Token: 0x0400CB3A RID: 52026
		BeamDeliver,
		// Token: 0x0400CB3B RID: 52027
		BeamCrystal,
		// Token: 0x0400CB3C RID: 52028
		BeamCastBullet,
		// Token: 0x0400CB3D RID: 52029
		Mirror,
		// Token: 0x0400CB3E RID: 52030
		TimeStop,
		// Token: 0x0400CB3F RID: 52031
		Portal,
		// Token: 0x0400CB40 RID: 52032
		NoRenderPortal,
		// Token: 0x0400CB41 RID: 52033
		MoveNoRenderPortal,
		// Token: 0x0400CB42 RID: 52034
		NoRenderPortalWithInteract,
		// Token: 0x0400CB43 RID: 52035
		DynamicPortalCreater,
		// Token: 0x0400CB44 RID: 52036
		EffectArea,
		// Token: 0x0400CB45 RID: 52037
		EffectTrampleArea,
		// Token: 0x0400CB46 RID: 52038
		ActorRefVolumeTrigger,
		// Token: 0x0400CB47 RID: 52039
		PhysicsSwing,
		// Token: 0x0400CB48 RID: 52040
		VarManager,
		// Token: 0x0400CB49 RID: 52041
		ControlConnector,
		// Token: 0x0400CB4A RID: 52042
		RangeTriggerRotator,
		// Token: 0x0400CB4B RID: 52043
		EntityBundle,
		// Token: 0x0400CB4C RID: 52044
		Chessboard,
		// Token: 0x0400CB4D RID: 52045
		Chessman,
		// Token: 0x0400CB4E RID: 52046
		AiMovementGear,
		// Token: 0x0400CB4F RID: 52047
		AiGearController,
		// Token: 0x0400CB50 RID: 52048
		DestructibleAiMovementGear,
		// Token: 0x0400CB51 RID: 52049
		LocationSafety,
		// Token: 0x0400CB52 RID: 52050
		BatchBulletCaster,
		// Token: 0x0400CB53 RID: 52051
		Vehicle,
		// Token: 0x0400CB54 RID: 52052
		Vehicle2,
		// Token: 0x0400CB55 RID: 52053
		VehicleNpc,
		// Token: 0x0400CB56 RID: 52054
		VehicleSceneItem,
		// Token: 0x0400CB57 RID: 52055
		FishingBoat,
		// Token: 0x0400CB58 RID: 52056
		BattleVehicle,
		// Token: 0x0400CB59 RID: 52057
		EnrichmentArea,
		// Token: 0x0400CB5A RID: 52058
		AirPassage,
		// Token: 0x0400CB5B RID: 52059
		TimedStrikeDevice,
		// Token: 0x0400CB5C RID: 52060
		Monitor,
		// Token: 0x0400CB5D RID: 52061
		WaterCollection,
		// Token: 0x0400CB5E RID: 52062
		InhaledItem,
		// Token: 0x0400CB5F RID: 52063
		VacuumCleaner,
		// Token: 0x0400CB60 RID: 52064
		AiSceneItem,
		// Token: 0x0400CB61 RID: 52065
		GravityFlip,
		// Token: 0x0400CB62 RID: 52066
		CollectAnimalPart,
		// Token: 0x0400CB63 RID: 52067
		RenderSpecifiedRange,
		// Token: 0x0400CB64 RID: 52068
		RenderSpecifiedRange2,
		// Token: 0x0400CB65 RID: 52069
		WalkingPatternController,
		// Token: 0x0400CB66 RID: 52070
		SummonGongduolaPoint,
		// Token: 0x0400CB67 RID: 52071
		SummonGondolaSpline,
		// Token: 0x0400CB68 RID: 52072
		HorseBettingTuanzi,
		// Token: 0x0400CB69 RID: 52073
		WindSource,
		// Token: 0x0400CB6A RID: 52074
		TemplateEntitySpawner,
		// Token: 0x0400CB6B RID: 52075
		RewardNpc,
		// Token: 0x0400CB6C RID: 52076
		SlideRail,
		// Token: 0x0400CB6D RID: 52077
		SlidePerformRail,
		// Token: 0x0400CB6E RID: 52078
		TuanziNpc,
		// Token: 0x0400CB6F RID: 52079
		SplineRange,
		// Token: 0x0400CB70 RID: 52080
		Slots,
		// Token: 0x0400CB71 RID: 52081
		TuningStand,
		// Token: 0x0400CB72 RID: 52082
		MusicStand,
		// Token: 0x0400CB73 RID: 52083
		TowerDefenseTrap,
		// Token: 0x0400CB74 RID: 52084
		TowerDefenseMonster,
		// Token: 0x0400CB75 RID: 52085
		TowerDefenseFollowShooter,
		// Token: 0x0400CB76 RID: 52086
		RenderSpecifiedFollowShooter,
		// Token: 0x0400CB77 RID: 52087
		GodKingFrequencyController,
		// Token: 0x0400CB78 RID: 52088
		PerformanceOptimizer,
		// Token: 0x0400CB79 RID: 52089
		DynamicSpawnMonsterPoint,
		// Token: 0x0400CB7A RID: 52090
		DynamicSpawnMonster,
		// Token: 0x0400CB7B RID: 52091
		TraceTrackingFootPrint,
		// Token: 0x0400CB7C RID: 52092
		MusicListener,
		// Token: 0x0400CB7D RID: 52093
		MusicTriggerListener,
		// Token: 0x0400CB7E RID: 52094
		ClientTriggerGear,
		// Token: 0x0400CB7F RID: 52095
		RollBlock,
		// Token: 0x0400CB80 RID: 52096
		RollBlockFloor,
		// Token: 0x0400CB81 RID: 52097
		RollBlockItem,
		// Token: 0x0400CB82 RID: 52098
		SunSpiritCollectUnit,
		// Token: 0x0400CB83 RID: 52099
		SunSpiritGearLauncher,
		// Token: 0x0400CB84 RID: 52100
		SunSpiritGear,
		// Token: 0x0400CB85 RID: 52101
		SunSpiritPlatform,
		// Token: 0x0400CB86 RID: 52102
		SunSpiritCombiner,
		// Token: 0x0400CB87 RID: 52103
		DeadeyeHookTrigger,
		// Token: 0x0400CB88 RID: 52104
		MotorSlide,
		// Token: 0x0400CB89 RID: 52105
		HonamiStoryCorruptedArea,
		// Token: 0x0400CB8A RID: 52106
		SplineFX,
		// Token: 0x0400CB8B RID: 52107
		TrafficSceneItem,
		// Token: 0x0400CB8C RID: 52108
		QuantumPolluted,
		// Token: 0x0400CB8D RID: 52109
		FurnitureSlot,
		// Token: 0x0400CB8E RID: 52110
		Furniture,
		// Token: 0x0400CB8F RID: 52111
		VisionDisplayItem,
		// Token: 0x0400CB90 RID: 52112
		AirWallEffectTrigger,
		// Token: 0x0400CB91 RID: 52113
		HitTargetMonster,
		// Token: 0x0400CB92 RID: 52114
		SystemModuleVarSynchronizer,
		// Token: 0x0400CB93 RID: 52115
		Paver,
		// Token: 0x0400CB94 RID: 52116
		DestructibleWithHook,
		// Token: 0x0400CB95 RID: 52117
		PilotThrowTitan,
		// Token: 0x0400CB96 RID: 52118
		ExhibitBase,
		// Token: 0x0400CB97 RID: 52119
		TimeScheduleManagerEntity,
		// Token: 0x0400CB98 RID: 52120
		Projector,
		// Token: 0x0400CB99 RID: 52121
		OrientationUnlockStatue,
		// Token: 0x0400CB9A RID: 52122
		FlowerPollutionManager,
		// Token: 0x0400CB9B RID: 52123
		QuickHack,
		// Token: 0x0400CB9C RID: 52124
		DollGrabMachine,
		// Token: 0x0400CB9D RID: 52125
		DollGrabShowcase,
		// Token: 0x0400CB9E RID: 52126
		WuWaGoEntity,
		// Token: 0x0400CB9F RID: 52127
		DragActorPlayEntity,
		// Token: 0x0400CBA0 RID: 52128
		PathDrivenActorSpawner,
		// Token: 0x0400CBA1 RID: 52129
		SwordRiderRail,
		// Token: 0x0400CBA2 RID: 52130
		SequenceDrivenHook,
		// Token: 0x0400CBA3 RID: 52131
		LivingCharMeteor,
		// Token: 0x0400CBA4 RID: 52132
		ElementalHolder,
		// Token: 0x0400CBA5 RID: 52133
		ElementalResponse,
		// Token: 0x0400CBA6 RID: 52134
		ElementalResponseComposite,
		// Token: 0x0400CBA7 RID: 52135
		ElementalResponseActorEntity,
		// Token: 0x0400CBA8 RID: 52136
		FireBoxLamp,
		// Token: 0x0400CBA9 RID: 52137
		FireBoxSearchlight,
		// Token: 0x0400CBAA RID: 52138
		WoodenBoxJadeTree,
		// Token: 0x0400CBAB RID: 52139
		WoodenBoxVase,
		// Token: 0x0400CBAC RID: 52140
		WoodenBoxRegenerativeJade,
		// Token: 0x0400CBAD RID: 52141
		ElementalResponseHook,
		// Token: 0x0400CBAE RID: 52142
		Graph3d,
		// Token: 0x0400CBAF RID: 52143
		ElementalBoxFoundation,
		// Token: 0x0400CBB0 RID: 52144
		ElementalWell,
		// Token: 0x0400CBB1 RID: 52145
		AttributeConditionListenerTrigger,
		// Token: 0x0400CBB2 RID: 52146
		FoxPushBox,
		// Token: 0x0400CBB3 RID: 52147
		NoiseRemoval,
		// Token: 0x0400CBB4 RID: 52148
		SceneText,
		// Token: 0x0400CBB5 RID: 52149
		SceneBuilding
	}
}

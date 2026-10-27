using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FDC RID: 20444
	public enum IComponentBase_Union : byte
	{
		// Token: 0x0400DECC RID: 57036
		NONE,
		// Token: 0x0400DECD RID: 57037
		IComponentBase,
		// Token: 0x0400DECE RID: 57038
		IUnUseComponent,
		// Token: 0x0400DECF RID: 57039
		IInteractiveComponent,
		// Token: 0x0400DED0 RID: 57040
		ISwitcherComponent,
		// Token: 0x0400DED1 RID: 57041
		IRotatorComponent,
		// Token: 0x0400DED2 RID: 57042
		IBehaviorFlowComponent,
		// Token: 0x0400DED3 RID: 57043
		IFlowComponent,
		// Token: 0x0400DED4 RID: 57044
		ITriggerUe5Component,
		// Token: 0x0400DED5 RID: 57045
		IMoveComponent,
		// Token: 0x0400DED6 RID: 57046
		IActorStateComponent,
		// Token: 0x0400DED7 RID: 57047
		ICalculateComponent,
		// Token: 0x0400DED8 RID: 57048
		IRefreshGroup,
		// Token: 0x0400DED9 RID: 57049
		IRefreshSingleComponent,
		// Token: 0x0400DEDA RID: 57050
		IRotatorComponent2,
		// Token: 0x0400DEDB RID: 57051
		ISphereFactoryComponent,
		// Token: 0x0400DEDC RID: 57052
		ISpringComponent,
		// Token: 0x0400DEDD RID: 57053
		ITrampleUe5Component,
		// Token: 0x0400DEDE RID: 57054
		IUndergroundComponent,
		// Token: 0x0400DEDF RID: 57055
		IGrabComponent,
		// Token: 0x0400DEE0 RID: 57056
		IInteractComponent,
		// Token: 0x0400DEE1 RID: 57057
		IVarComponent,
		// Token: 0x0400DEE2 RID: 57058
		IPatrol,
		// Token: 0x0400DEE3 RID: 57059
		IAiComponent,
		// Token: 0x0400DEE4 RID: 57060
		IAttributeComponent,
		// Token: 0x0400DEE5 RID: 57061
		IEditCustomAoiComponent,
		// Token: 0x0400DEE6 RID: 57062
		IBaseInfoComponent,
		// Token: 0x0400DEE7 RID: 57063
		IRewardComponent,
		// Token: 0x0400DEE8 RID: 57064
		IDynamicEntityRewardComponent,
		// Token: 0x0400DEE9 RID: 57065
		IIndependentSystemRewardComponent,
		// Token: 0x0400DEEA RID: 57066
		IRefreshComponent,
		// Token: 0x0400DEEB RID: 57067
		IRefreshGroupComponent,
		// Token: 0x0400DEEC RID: 57068
		IEntityBatchRefreshComponent,
		// Token: 0x0400DEED RID: 57069
		ITreasureBoxComponent,
		// Token: 0x0400DEEE RID: 57070
		ITriggerComponent,
		// Token: 0x0400DEEF RID: 57071
		IEntityStateComponent,
		// Token: 0x0400DEF0 RID: 57072
		ISceneItemAttributeComponent,
		// Token: 0x0400DEF1 RID: 57073
		IEntityAudioComponent,
		// Token: 0x0400DEF2 RID: 57074
		IEntityStateAudioComponent,
		// Token: 0x0400DEF3 RID: 57075
		IEntityCustomAudioComponent,
		// Token: 0x0400DEF4 RID: 57076
		ITrampleComponent,
		// Token: 0x0400DEF5 RID: 57077
		IEntityGroupComponent,
		// Token: 0x0400DEF6 RID: 57078
		IHookLockPoint,
		// Token: 0x0400DEF7 RID: 57079
		IRoleMotionInteractComponent,
		// Token: 0x0400DEF8 RID: 57080
		IHookFetchComponent,
		// Token: 0x0400DEF9 RID: 57081
		IItemFoundation,
		// Token: 0x0400DEFA RID: 57082
		IResetEntitiesPosComponent,
		// Token: 0x0400DEFB RID: 57083
		IResetSelfPosComponent,
		// Token: 0x0400DEFC RID: 57084
		ICollectComponent,
		// Token: 0x0400DEFD RID: 57085
		ITeleControl2,
		// Token: 0x0400DEFE RID: 57086
		IItemFoundation2,
		// Token: 0x0400DEFF RID: 57087
		IPullingFoundation,
		// Token: 0x0400DF00 RID: 57088
		ILevelPlayComponent,
		// Token: 0x0400DF01 RID: 57089
		IDynamicLevelPlayComponent,
		// Token: 0x0400DF02 RID: 57090
		IVisionComponent,
		// Token: 0x0400DF03 RID: 57091
		IVisionCaptureComponent,
		// Token: 0x0400DF04 RID: 57092
		IAdsorbComponent,
		// Token: 0x0400DF05 RID: 57093
		ITeleportComponent,
		// Token: 0x0400DF06 RID: 57094
		ISpawnMonsterComponent,
		// Token: 0x0400DF07 RID: 57095
		IHitComponentBase,
		// Token: 0x0400DF08 RID: 57096
		IDestructibleItem,
		// Token: 0x0400DF09 RID: 57097
		ITargetGearComponent,
		// Token: 0x0400DF0A RID: 57098
		IProgressBarControlComponent,
		// Token: 0x0400DF0B RID: 57099
		IHitComponent,
		// Token: 0x0400DF0C RID: 57100
		ITargetGearGroupComponent,
		// Token: 0x0400DF0D RID: 57101
		INpcPerformComponent,
		// Token: 0x0400DF0E RID: 57102
		IInteractGearComponent,
		// Token: 0x0400DF0F RID: 57103
		ILiftComponent,
		// Token: 0x0400DF10 RID: 57104
		IConveyorBeltComponent,
		// Token: 0x0400DF11 RID: 57105
		IFollowTrackComponent,
		// Token: 0x0400DF12 RID: 57106
		ISceneItemLifeCycleComponent,
		// Token: 0x0400DF13 RID: 57107
		IFightInteractComponent,
		// Token: 0x0400DF14 RID: 57108
		IBubbleComponent,
		// Token: 0x0400DF15 RID: 57109
		INearbyTrackingComponent,
		// Token: 0x0400DF16 RID: 57110
		IEntityPackageComponent,
		// Token: 0x0400DF17 RID: 57111
		ISkyboxComponent,
		// Token: 0x0400DF18 RID: 57112
		IStateHintComponent,
		// Token: 0x0400DF19 RID: 57113
		IEntityVisibleComponent,
		// Token: 0x0400DF1A RID: 57114
		ICombinedVisibleGroupComponent,
		// Token: 0x0400DF1B RID: 57115
		IWeaponComponent,
		// Token: 0x0400DF1C RID: 57116
		IDungeonEntryComponent,
		// Token: 0x0400DF1D RID: 57117
		IResurrectionComponent,
		// Token: 0x0400DF1E RID: 57118
		IBuffProducerComponent,
		// Token: 0x0400DF1F RID: 57119
		IBuffConsumerComponent,
		// Token: 0x0400DF20 RID: 57120
		IGuideLineCreatorComponent,
		// Token: 0x0400DF21 RID: 57121
		IInteractAudioComponent,
		// Token: 0x0400DF22 RID: 57122
		IDropComponent,
		// Token: 0x0400DF23 RID: 57123
		IVisionItemComponent,
		// Token: 0x0400DF24 RID: 57124
		IAdviseItemComponent,
		// Token: 0x0400DF25 RID: 57125
		IMonsterComponent,
		// Token: 0x0400DF26 RID: 57126
		ICombatComponent,
		// Token: 0x0400DF27 RID: 57127
		IEntityListComponent,
		// Token: 0x0400DF28 RID: 57128
		IAnimalComponent,
		// Token: 0x0400DF29 RID: 57129
		ISceneItemMovementComponent,
		// Token: 0x0400DF2A RID: 57130
		IRangeComponent,
		// Token: 0x0400DF2B RID: 57131
		IExtraRangeComponent,
		// Token: 0x0400DF2C RID: 57132
		ITimelineTrackControlComponent,
		// Token: 0x0400DF2D RID: 57133
		ISplineComponent,
		// Token: 0x0400DF2E RID: 57134
		IAirWallSpawnerComponent,
		// Token: 0x0400DF2F RID: 57135
		ISceneActorRefComponent,
		// Token: 0x0400DF30 RID: 57136
		ISceneBulletComponent,
		// Token: 0x0400DF31 RID: 57137
		ITurntableControlComponent,
		// Token: 0x0400DF32 RID: 57138
		IConditionListenerComponent,
		// Token: 0x0400DF33 RID: 57139
		IAttachTargetComponent,
		// Token: 0x0400DF34 RID: 57140
		IReboundComponent,
		// Token: 0x0400DF35 RID: 57141
		IJigsawItem,
		// Token: 0x0400DF36 RID: 57142
		IJigsawFoundation,
		// Token: 0x0400DF37 RID: 57143
		ILevelAIComponent,
		// Token: 0x0400DF38 RID: 57144
		ILevitateMagnetComponent,
		// Token: 0x0400DF39 RID: 57145
		IPhotoTargetComponent,
		// Token: 0x0400DF3A RID: 57146
		IAiAlertNotifyComponent,
		// Token: 0x0400DF3B RID: 57147
		IMonsterGachaItemComponent,
		// Token: 0x0400DF3C RID: 57148
		IMonsterGachaBaseComponent,
		// Token: 0x0400DF3D RID: 57149
		IDynamicTeleportComponent,
		// Token: 0x0400DF3E RID: 57150
		IExploreSkillInteractComponent,
		// Token: 0x0400DF3F RID: 57151
		IExploreSkillInteractGroupComponent,
		// Token: 0x0400DF40 RID: 57152
		IFanComponent,
		// Token: 0x0400DF41 RID: 57153
		IPasserbyNpcSpawnComponent,
		// Token: 0x0400DF42 RID: 57154
		IModelComponent,
		// Token: 0x0400DF43 RID: 57155
		IEntityBundleComponent,
		// Token: 0x0400DF44 RID: 57156
		IBeamCastComponent,
		// Token: 0x0400DF45 RID: 57157
		IBeamReceiveComponent,
		// Token: 0x0400DF46 RID: 57158
		ITimeStopComponent,
		// Token: 0x0400DF47 RID: 57159
		IPortalComponent,
		// Token: 0x0400DF48 RID: 57160
		IDynamicPortalCreatorComponent,
		// Token: 0x0400DF49 RID: 57161
		INoRenderPortalComponent,
		// Token: 0x0400DF4A RID: 57162
		IEffectAreaComponent,
		// Token: 0x0400DF4B RID: 57163
		IPhysicsConstraintComponent,
		// Token: 0x0400DF4C RID: 57164
		IFollowDecorationComponent,
		// Token: 0x0400DF4D RID: 57165
		IFollowShooterComponent,
		// Token: 0x0400DF4E RID: 57166
		IConnectorComponent,
		// Token: 0x0400DF4F RID: 57167
		ISceneTextComponent,
		// Token: 0x0400DF50 RID: 57168
		INavMeshComponent,
		// Token: 0x0400DF51 RID: 57169
		ICharacterConnectorComponent,
		// Token: 0x0400DF52 RID: 57170
		IAiGearStrategyComponent,
		// Token: 0x0400DF53 RID: 57171
		IPickInteractComponent,
		// Token: 0x0400DF54 RID: 57172
		IChessmanComponent,
		// Token: 0x0400DF55 RID: 57173
		IClientTriggerComponent,
		// Token: 0x0400DF56 RID: 57174
		ILocationSafetyComponent,
		// Token: 0x0400DF57 RID: 57175
		IBatchBulletCasterComponent,
		// Token: 0x0400DF58 RID: 57176
		IVehicleComponent,
		// Token: 0x0400DF59 RID: 57177
		IEnrichmentAreaComponent,
		// Token: 0x0400DF5A RID: 57178
		IMonitorComponent,
		// Token: 0x0400DF5B RID: 57179
		IGroupAiComponent,
		// Token: 0x0400DF5C RID: 57180
		IInhalationAbilityComponent,
		// Token: 0x0400DF5D RID: 57181
		IInhaledItemComponent,
		// Token: 0x0400DF5E RID: 57182
		IAirPassageComponent,
		// Token: 0x0400DF5F RID: 57183
		IRenderSpecifiedRangeComponent,
		// Token: 0x0400DF60 RID: 57184
		ILevelPrefabPerformComponent,
		// Token: 0x0400DF61 RID: 57185
		ISceneItemAiComponent,
		// Token: 0x0400DF62 RID: 57186
		IGravityFlipComponent,
		// Token: 0x0400DF63 RID: 57187
		ILevelSequenceFrameEventComponent,
		// Token: 0x0400DF64 RID: 57188
		ILevelQteComponent,
		// Token: 0x0400DF65 RID: 57189
		IWalkingPatternComponent,
		// Token: 0x0400DF66 RID: 57190
		ILifePointCenterComponent,
		// Token: 0x0400DF67 RID: 57191
		IHackManagementComponent,
		// Token: 0x0400DF68 RID: 57192
		IClientConditionListenerComponent,
		// Token: 0x0400DF69 RID: 57193
		ITemplateEntitySpawnerComponent,
		// Token: 0x0400DF6A RID: 57194
		IWindSourceComponent,
		// Token: 0x0400DF6B RID: 57195
		ISlideRailComponent,
		// Token: 0x0400DF6C RID: 57196
		ISlidePerformComponent,
		// Token: 0x0400DF6D RID: 57197
		IRollBlockComponent,
		// Token: 0x0400DF6E RID: 57198
		IRollBlockFloorComponent,
		// Token: 0x0400DF6F RID: 57199
		IRollBlockItemComponent,
		// Token: 0x0400DF70 RID: 57200
		ICurveControlComponent,
		// Token: 0x0400DF71 RID: 57201
		ISimpleCombatComponent,
		// Token: 0x0400DF72 RID: 57202
		IGridObjectComponent,
		// Token: 0x0400DF73 RID: 57203
		IGodKingFrequencyControllerComponent,
		// Token: 0x0400DF74 RID: 57204
		IPerformanceOptimizationComponent,
		// Token: 0x0400DF75 RID: 57205
		ISceneItemEventListenerComponent,
		// Token: 0x0400DF76 RID: 57206
		IDynamicSpawnMonsterPointComponent,
		// Token: 0x0400DF77 RID: 57207
		IDynamicSpawnMonsterComponent,
		// Token: 0x0400DF78 RID: 57208
		ISunSpiritCollectComponent,
		// Token: 0x0400DF79 RID: 57209
		ISunSpiritLauncherComponent,
		// Token: 0x0400DF7A RID: 57210
		ISunSpiritGearComponent,
		// Token: 0x0400DF7B RID: 57211
		IMotorSlideComponent,
		// Token: 0x0400DF7C RID: 57212
		IProceduralVisualComponent,
		// Token: 0x0400DF7D RID: 57213
		IRoadNetworkNavigationComponent,
		// Token: 0x0400DF7E RID: 57214
		IFurnitureSlotComponent,
		// Token: 0x0400DF7F RID: 57215
		IVisionDisplayComponent,
		// Token: 0x0400DF80 RID: 57216
		ISystemModuleDataSyncComponent,
		// Token: 0x0400DF81 RID: 57217
		IExhibitComponent,
		// Token: 0x0400DF82 RID: 57218
		ITimeScheduleComponent,
		// Token: 0x0400DF83 RID: 57219
		IProjectorComponent,
		// Token: 0x0400DF84 RID: 57220
		IProceduralMaterialComponent,
		// Token: 0x0400DF85 RID: 57221
		IGameplayDataPersistenceComponent,
		// Token: 0x0400DF86 RID: 57222
		IFlowerPollutionComponent,
		// Token: 0x0400DF87 RID: 57223
		IQuickHackComponent,
		// Token: 0x0400DF88 RID: 57224
		IDollGrabMachineComponent,
		// Token: 0x0400DF89 RID: 57225
		IDollGrabShowcaseComponent,
		// Token: 0x0400DF8A RID: 57226
		IWuWaGoComponent,
		// Token: 0x0400DF8B RID: 57227
		IDragActorPlayComponent,
		// Token: 0x0400DF8C RID: 57228
		IPathDrivenActorSpawnerComponent,
		// Token: 0x0400DF8D RID: 57229
		IElementalHolderComponent,
		// Token: 0x0400DF8E RID: 57230
		IElementalEffectComponent,
		// Token: 0x0400DF8F RID: 57231
		IElementalBoxFoundationComponent,
		// Token: 0x0400DF90 RID: 57232
		IElementalWellComponent,
		// Token: 0x0400DF91 RID: 57233
		IStreamingSourceTriggerPointComponent,
		// Token: 0x0400DF92 RID: 57234
		IGraph3dComponent,
		// Token: 0x0400DF93 RID: 57235
		IGraph3dEffectComponent,
		// Token: 0x0400DF94 RID: 57236
		INoiseRemovalComponent
	}
}

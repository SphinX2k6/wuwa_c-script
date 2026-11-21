using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200553B RID: 21819
	public enum IComponentBase_Union : byte
	{
		// Token: 0x0400EAC0 RID: 60096
		NONE,
		// Token: 0x0400EAC1 RID: 60097
		IComponentBase,
		// Token: 0x0400EAC2 RID: 60098
		IUnUseComponent,
		// Token: 0x0400EAC3 RID: 60099
		IInteractiveComponent,
		// Token: 0x0400EAC4 RID: 60100
		ISwitcherComponent,
		// Token: 0x0400EAC5 RID: 60101
		IRotatorComponent,
		// Token: 0x0400EAC6 RID: 60102
		IBehaviorFlowComponent,
		// Token: 0x0400EAC7 RID: 60103
		IFlowComponent,
		// Token: 0x0400EAC8 RID: 60104
		ITriggerUe5Component,
		// Token: 0x0400EAC9 RID: 60105
		IMoveComponent,
		// Token: 0x0400EACA RID: 60106
		IActorStateComponent,
		// Token: 0x0400EACB RID: 60107
		ICalculateComponent,
		// Token: 0x0400EACC RID: 60108
		IRefreshGroup,
		// Token: 0x0400EACD RID: 60109
		IRefreshSingleComponent,
		// Token: 0x0400EACE RID: 60110
		IRotatorComponent2,
		// Token: 0x0400EACF RID: 60111
		ISphereFactoryComponent,
		// Token: 0x0400EAD0 RID: 60112
		ISpringComponent,
		// Token: 0x0400EAD1 RID: 60113
		ITrampleUe5Component,
		// Token: 0x0400EAD2 RID: 60114
		IUndergroundComponent,
		// Token: 0x0400EAD3 RID: 60115
		IGrabComponent,
		// Token: 0x0400EAD4 RID: 60116
		IInteractComponent,
		// Token: 0x0400EAD5 RID: 60117
		IVarComponent,
		// Token: 0x0400EAD6 RID: 60118
		IPatrol,
		// Token: 0x0400EAD7 RID: 60119
		IAiComponent,
		// Token: 0x0400EAD8 RID: 60120
		IAttributeComponent,
		// Token: 0x0400EAD9 RID: 60121
		IEditCustomAoiComponent,
		// Token: 0x0400EADA RID: 60122
		IBaseInfoComponent,
		// Token: 0x0400EADB RID: 60123
		IRewardComponent,
		// Token: 0x0400EADC RID: 60124
		IDynamicEntityRewardComponent,
		// Token: 0x0400EADD RID: 60125
		IIndependentSystemRewardComponent,
		// Token: 0x0400EADE RID: 60126
		IRefreshComponent,
		// Token: 0x0400EADF RID: 60127
		IRefreshGroupComponent,
		// Token: 0x0400EAE0 RID: 60128
		IEntityBatchRefreshComponent,
		// Token: 0x0400EAE1 RID: 60129
		ITreasureBoxComponent,
		// Token: 0x0400EAE2 RID: 60130
		ITriggerComponent,
		// Token: 0x0400EAE3 RID: 60131
		IEntityStateComponent,
		// Token: 0x0400EAE4 RID: 60132
		ISceneItemAttributeComponent,
		// Token: 0x0400EAE5 RID: 60133
		IEntityAudioComponent,
		// Token: 0x0400EAE6 RID: 60134
		IEntityStateAudioComponent,
		// Token: 0x0400EAE7 RID: 60135
		IEntityCustomAudioComponent,
		// Token: 0x0400EAE8 RID: 60136
		ITrampleComponent,
		// Token: 0x0400EAE9 RID: 60137
		IEntityGroupComponent,
		// Token: 0x0400EAEA RID: 60138
		IHookLockPoint,
		// Token: 0x0400EAEB RID: 60139
		IRoleMotionInteractComponent,
		// Token: 0x0400EAEC RID: 60140
		IHookFetchComponent,
		// Token: 0x0400EAED RID: 60141
		IItemFoundation,
		// Token: 0x0400EAEE RID: 60142
		IResetEntitiesPosComponent,
		// Token: 0x0400EAEF RID: 60143
		IResetSelfPosComponent,
		// Token: 0x0400EAF0 RID: 60144
		ICollectComponent,
		// Token: 0x0400EAF1 RID: 60145
		ITeleControl2,
		// Token: 0x0400EAF2 RID: 60146
		IItemFoundation2,
		// Token: 0x0400EAF3 RID: 60147
		IPullingFoundation,
		// Token: 0x0400EAF4 RID: 60148
		ILevelPlayComponent,
		// Token: 0x0400EAF5 RID: 60149
		IDynamicLevelPlayComponent,
		// Token: 0x0400EAF6 RID: 60150
		IVisionComponent,
		// Token: 0x0400EAF7 RID: 60151
		IVisionCaptureComponent,
		// Token: 0x0400EAF8 RID: 60152
		IAdsorbComponent,
		// Token: 0x0400EAF9 RID: 60153
		ITeleportComponent,
		// Token: 0x0400EAFA RID: 60154
		ISpawnMonsterComponent,
		// Token: 0x0400EAFB RID: 60155
		IHitComponentBase,
		// Token: 0x0400EAFC RID: 60156
		IDestructibleItem,
		// Token: 0x0400EAFD RID: 60157
		ITargetGearComponent,
		// Token: 0x0400EAFE RID: 60158
		IProgressBarControlComponent,
		// Token: 0x0400EAFF RID: 60159
		IHitComponent,
		// Token: 0x0400EB00 RID: 60160
		ITargetGearGroupComponent,
		// Token: 0x0400EB01 RID: 60161
		INpcPerformComponent,
		// Token: 0x0400EB02 RID: 60162
		IInteractGearComponent,
		// Token: 0x0400EB03 RID: 60163
		ILiftComponent,
		// Token: 0x0400EB04 RID: 60164
		IConveyorBeltComponent,
		// Token: 0x0400EB05 RID: 60165
		IFollowTrackComponent,
		// Token: 0x0400EB06 RID: 60166
		ISceneItemLifeCycleComponent,
		// Token: 0x0400EB07 RID: 60167
		IFightInteractComponent,
		// Token: 0x0400EB08 RID: 60168
		IBubbleComponent,
		// Token: 0x0400EB09 RID: 60169
		INearbyTrackingComponent,
		// Token: 0x0400EB0A RID: 60170
		IEntityPackageComponent,
		// Token: 0x0400EB0B RID: 60171
		ISkyboxComponent,
		// Token: 0x0400EB0C RID: 60172
		IStateHintComponent,
		// Token: 0x0400EB0D RID: 60173
		IEntityVisibleComponent,
		// Token: 0x0400EB0E RID: 60174
		ICombinedVisibleGroupComponent,
		// Token: 0x0400EB0F RID: 60175
		IWeaponComponent,
		// Token: 0x0400EB10 RID: 60176
		IDungeonEntryComponent,
		// Token: 0x0400EB11 RID: 60177
		IResurrectionComponent,
		// Token: 0x0400EB12 RID: 60178
		IBuffProducerComponent,
		// Token: 0x0400EB13 RID: 60179
		IBuffConsumerComponent,
		// Token: 0x0400EB14 RID: 60180
		IGuideLineCreatorComponent,
		// Token: 0x0400EB15 RID: 60181
		IInteractAudioComponent,
		// Token: 0x0400EB16 RID: 60182
		IDropComponent,
		// Token: 0x0400EB17 RID: 60183
		IVisionItemComponent,
		// Token: 0x0400EB18 RID: 60184
		IAdviseItemComponent,
		// Token: 0x0400EB19 RID: 60185
		IMonsterComponent,
		// Token: 0x0400EB1A RID: 60186
		ICombatComponent,
		// Token: 0x0400EB1B RID: 60187
		IEntityListComponent,
		// Token: 0x0400EB1C RID: 60188
		IAnimalComponent,
		// Token: 0x0400EB1D RID: 60189
		ISceneItemMovementComponent,
		// Token: 0x0400EB1E RID: 60190
		IRangeComponent,
		// Token: 0x0400EB1F RID: 60191
		IExtraRangeComponent,
		// Token: 0x0400EB20 RID: 60192
		ITimelineTrackControlComponent,
		// Token: 0x0400EB21 RID: 60193
		ISplineComponent,
		// Token: 0x0400EB22 RID: 60194
		IAirWallSpawnerComponent,
		// Token: 0x0400EB23 RID: 60195
		ISceneActorRefComponent,
		// Token: 0x0400EB24 RID: 60196
		ISceneBulletComponent,
		// Token: 0x0400EB25 RID: 60197
		ITurntableControlComponent,
		// Token: 0x0400EB26 RID: 60198
		IConditionListenerComponent,
		// Token: 0x0400EB27 RID: 60199
		IAttachTargetComponent,
		// Token: 0x0400EB28 RID: 60200
		IReboundComponent,
		// Token: 0x0400EB29 RID: 60201
		IJigsawItem,
		// Token: 0x0400EB2A RID: 60202
		IJigsawFoundation,
		// Token: 0x0400EB2B RID: 60203
		ILevelAIComponent,
		// Token: 0x0400EB2C RID: 60204
		ILevitateMagnetComponent,
		// Token: 0x0400EB2D RID: 60205
		IPhotoTargetComponent,
		// Token: 0x0400EB2E RID: 60206
		IAiAlertNotifyComponent,
		// Token: 0x0400EB2F RID: 60207
		IMonsterGachaItemComponent,
		// Token: 0x0400EB30 RID: 60208
		IMonsterGachaBaseComponent,
		// Token: 0x0400EB31 RID: 60209
		IDynamicTeleportComponent,
		// Token: 0x0400EB32 RID: 60210
		IExploreSkillInteractComponent,
		// Token: 0x0400EB33 RID: 60211
		IExploreSkillInteractGroupComponent,
		// Token: 0x0400EB34 RID: 60212
		IFanComponent,
		// Token: 0x0400EB35 RID: 60213
		IPasserbyNpcSpawnComponent,
		// Token: 0x0400EB36 RID: 60214
		IModelComponent,
		// Token: 0x0400EB37 RID: 60215
		IEntityBundleComponent,
		// Token: 0x0400EB38 RID: 60216
		IBeamCastComponent,
		// Token: 0x0400EB39 RID: 60217
		IBeamReceiveComponent,
		// Token: 0x0400EB3A RID: 60218
		ITimeStopComponent,
		// Token: 0x0400EB3B RID: 60219
		IPortalComponent,
		// Token: 0x0400EB3C RID: 60220
		IDynamicPortalCreatorComponent,
		// Token: 0x0400EB3D RID: 60221
		INoRenderPortalComponent,
		// Token: 0x0400EB3E RID: 60222
		IEffectAreaComponent,
		// Token: 0x0400EB3F RID: 60223
		IPhysicsConstraintComponent,
		// Token: 0x0400EB40 RID: 60224
		IFollowDecorationComponent,
		// Token: 0x0400EB41 RID: 60225
		IFollowShooterComponent,
		// Token: 0x0400EB42 RID: 60226
		IConnectorComponent,
		// Token: 0x0400EB43 RID: 60227
		ISceneTextComponent,
		// Token: 0x0400EB44 RID: 60228
		INavMeshComponent,
		// Token: 0x0400EB45 RID: 60229
		ICharacterConnectorComponent,
		// Token: 0x0400EB46 RID: 60230
		IAiGearStrategyComponent,
		// Token: 0x0400EB47 RID: 60231
		IPickInteractComponent,
		// Token: 0x0400EB48 RID: 60232
		IChessmanComponent,
		// Token: 0x0400EB49 RID: 60233
		IClientTriggerComponent,
		// Token: 0x0400EB4A RID: 60234
		ILocationSafetyComponent,
		// Token: 0x0400EB4B RID: 60235
		IBatchBulletCasterComponent,
		// Token: 0x0400EB4C RID: 60236
		IVehicleComponent,
		// Token: 0x0400EB4D RID: 60237
		IEnrichmentAreaComponent,
		// Token: 0x0400EB4E RID: 60238
		IMonitorComponent,
		// Token: 0x0400EB4F RID: 60239
		IGroupAiComponent,
		// Token: 0x0400EB50 RID: 60240
		IInhalationAbilityComponent,
		// Token: 0x0400EB51 RID: 60241
		IInhaledItemComponent,
		// Token: 0x0400EB52 RID: 60242
		IAirPassageComponent,
		// Token: 0x0400EB53 RID: 60243
		IRenderSpecifiedRangeComponent,
		// Token: 0x0400EB54 RID: 60244
		ILevelPrefabPerformComponent,
		// Token: 0x0400EB55 RID: 60245
		ISceneItemAiComponent,
		// Token: 0x0400EB56 RID: 60246
		IGravityFlipComponent,
		// Token: 0x0400EB57 RID: 60247
		ILevelSequenceFrameEventComponent,
		// Token: 0x0400EB58 RID: 60248
		ILevelQteComponent,
		// Token: 0x0400EB59 RID: 60249
		IWalkingPatternComponent,
		// Token: 0x0400EB5A RID: 60250
		ILifePointCenterComponent,
		// Token: 0x0400EB5B RID: 60251
		IHackManagementComponent,
		// Token: 0x0400EB5C RID: 60252
		IClientConditionListenerComponent,
		// Token: 0x0400EB5D RID: 60253
		ITemplateEntitySpawnerComponent,
		// Token: 0x0400EB5E RID: 60254
		IWindSourceComponent,
		// Token: 0x0400EB5F RID: 60255
		ISlideRailComponent,
		// Token: 0x0400EB60 RID: 60256
		ISlidePerformComponent,
		// Token: 0x0400EB61 RID: 60257
		IRollBlockComponent,
		// Token: 0x0400EB62 RID: 60258
		IRollBlockFloorComponent,
		// Token: 0x0400EB63 RID: 60259
		IRollBlockItemComponent,
		// Token: 0x0400EB64 RID: 60260
		ICurveControlComponent,
		// Token: 0x0400EB65 RID: 60261
		ISimpleCombatComponent,
		// Token: 0x0400EB66 RID: 60262
		IGridObjectComponent,
		// Token: 0x0400EB67 RID: 60263
		IGodKingFrequencyControllerComponent,
		// Token: 0x0400EB68 RID: 60264
		IPerformanceOptimizationComponent,
		// Token: 0x0400EB69 RID: 60265
		ISceneItemEventListenerComponent,
		// Token: 0x0400EB6A RID: 60266
		IDynamicSpawnMonsterPointComponent,
		// Token: 0x0400EB6B RID: 60267
		IDynamicSpawnMonsterComponent,
		// Token: 0x0400EB6C RID: 60268
		ISunSpiritCollectComponent,
		// Token: 0x0400EB6D RID: 60269
		ISunSpiritLauncherComponent,
		// Token: 0x0400EB6E RID: 60270
		ISunSpiritGearComponent,
		// Token: 0x0400EB6F RID: 60271
		IMotorSlideComponent,
		// Token: 0x0400EB70 RID: 60272
		IProceduralVisualComponent,
		// Token: 0x0400EB71 RID: 60273
		IRoadNetworkNavigationComponent,
		// Token: 0x0400EB72 RID: 60274
		IFurnitureSlotComponent,
		// Token: 0x0400EB73 RID: 60275
		IVisionDisplayComponent,
		// Token: 0x0400EB74 RID: 60276
		ISystemModuleDataSyncComponent,
		// Token: 0x0400EB75 RID: 60277
		IExhibitComponent,
		// Token: 0x0400EB76 RID: 60278
		ITimeScheduleComponent,
		// Token: 0x0400EB77 RID: 60279
		IProjectorComponent,
		// Token: 0x0400EB78 RID: 60280
		IProceduralMaterialComponent,
		// Token: 0x0400EB79 RID: 60281
		IGameplayDataPersistenceComponent,
		// Token: 0x0400EB7A RID: 60282
		IFlowerPollutionComponent,
		// Token: 0x0400EB7B RID: 60283
		IQuickHackComponent,
		// Token: 0x0400EB7C RID: 60284
		IDollGrabMachineComponent,
		// Token: 0x0400EB7D RID: 60285
		IDollGrabShowcaseComponent,
		// Token: 0x0400EB7E RID: 60286
		IWuWaGoComponent,
		// Token: 0x0400EB7F RID: 60287
		IDragActorPlayComponent,
		// Token: 0x0400EB80 RID: 60288
		IPathDrivenActorSpawnerComponent,
		// Token: 0x0400EB81 RID: 60289
		IElementalHolderComponent,
		// Token: 0x0400EB82 RID: 60290
		IElementalEffectComponent,
		// Token: 0x0400EB83 RID: 60291
		IElementalBoxFoundationComponent,
		// Token: 0x0400EB84 RID: 60292
		IElementalWellComponent,
		// Token: 0x0400EB85 RID: 60293
		IStreamingSourceTriggerPointComponent,
		// Token: 0x0400EB86 RID: 60294
		IGraph3dComponent,
		// Token: 0x0400EB87 RID: 60295
		IGraph3dEffectComponent,
		// Token: 0x0400EB88 RID: 60296
		INoiseRemovalComponent,
		// Token: 0x0400EB89 RID: 60297
		IFrequencyPaintComponent,
		// Token: 0x0400EB8A RID: 60298
		ITurntableConnectorComponent
	}
}

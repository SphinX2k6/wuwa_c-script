using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FDE RID: 20446
	public static class IComponentBase_UnionVerify
	{
		// Token: 0x06020AB0 RID: 133808 RVA: 0x0048A08C File Offset: 0x0048828C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IComponentBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IUnUseComponentVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IInteractiveComponentVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISwitcherComponentVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IRotatorComponentVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IBehaviorFlowComponentVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IFlowComponentVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ITriggerUe5ComponentVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IMoveComponentVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IActorStateComponentVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = ICalculateComponentVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IRefreshGroupVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IRefreshSingleComponentVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = IRotatorComponent2Verify.Verify(verifier, tablePos);
				break;
			case 15:
				result = ISphereFactoryComponentVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = ISpringComponentVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = ITrampleUe5ComponentVerify.Verify(verifier, tablePos);
				break;
			case 18:
				result = IUndergroundComponentVerify.Verify(verifier, tablePos);
				break;
			case 19:
				result = IGrabComponentVerify.Verify(verifier, tablePos);
				break;
			case 20:
				result = IInteractComponentVerify.Verify(verifier, tablePos);
				break;
			case 21:
				result = IVarComponentVerify.Verify(verifier, tablePos);
				break;
			case 22:
				result = IPatrolVerify.Verify(verifier, tablePos);
				break;
			case 23:
				result = IAiComponentVerify.Verify(verifier, tablePos);
				break;
			case 24:
				result = IAttributeComponentVerify.Verify(verifier, tablePos);
				break;
			case 25:
				result = IEditCustomAoiComponentVerify.Verify(verifier, tablePos);
				break;
			case 26:
				result = IBaseInfoComponentVerify.Verify(verifier, tablePos);
				break;
			case 27:
				result = IRewardComponentVerify.Verify(verifier, tablePos);
				break;
			case 28:
				result = IDynamicEntityRewardComponentVerify.Verify(verifier, tablePos);
				break;
			case 29:
				result = IIndependentSystemRewardComponentVerify.Verify(verifier, tablePos);
				break;
			case 30:
				result = IRefreshComponentVerify.Verify(verifier, tablePos);
				break;
			case 31:
				result = IRefreshGroupComponentVerify.Verify(verifier, tablePos);
				break;
			case 32:
				result = IEntityBatchRefreshComponentVerify.Verify(verifier, tablePos);
				break;
			case 33:
				result = ITreasureBoxComponentVerify.Verify(verifier, tablePos);
				break;
			case 34:
				result = ITriggerComponentVerify.Verify(verifier, tablePos);
				break;
			case 35:
				result = IEntityStateComponentVerify.Verify(verifier, tablePos);
				break;
			case 36:
				result = ISceneItemAttributeComponentVerify.Verify(verifier, tablePos);
				break;
			case 37:
				result = IEntityAudioComponentVerify.Verify(verifier, tablePos);
				break;
			case 38:
				result = IEntityStateAudioComponentVerify.Verify(verifier, tablePos);
				break;
			case 39:
				result = IEntityCustomAudioComponentVerify.Verify(verifier, tablePos);
				break;
			case 40:
				result = ITrampleComponentVerify.Verify(verifier, tablePos);
				break;
			case 41:
				result = IEntityGroupComponentVerify.Verify(verifier, tablePos);
				break;
			case 42:
				result = IHookLockPointVerify.Verify(verifier, tablePos);
				break;
			case 43:
				result = IRoleMotionInteractComponentVerify.Verify(verifier, tablePos);
				break;
			case 44:
				result = IHookFetchComponentVerify.Verify(verifier, tablePos);
				break;
			case 45:
				result = IItemFoundationVerify.Verify(verifier, tablePos);
				break;
			case 46:
				result = IResetEntitiesPosComponentVerify.Verify(verifier, tablePos);
				break;
			case 47:
				result = IResetSelfPosComponentVerify.Verify(verifier, tablePos);
				break;
			case 48:
				result = ICollectComponentVerify.Verify(verifier, tablePos);
				break;
			case 49:
				result = ITeleControl2Verify.Verify(verifier, tablePos);
				break;
			case 50:
				result = IItemFoundation2Verify.Verify(verifier, tablePos);
				break;
			case 51:
				result = IPullingFoundationVerify.Verify(verifier, tablePos);
				break;
			case 52:
				result = ILevelPlayComponentVerify.Verify(verifier, tablePos);
				break;
			case 53:
				result = IDynamicLevelPlayComponentVerify.Verify(verifier, tablePos);
				break;
			case 54:
				result = IVisionComponentVerify.Verify(verifier, tablePos);
				break;
			case 55:
				result = IVisionCaptureComponentVerify.Verify(verifier, tablePos);
				break;
			case 56:
				result = IAdsorbComponentVerify.Verify(verifier, tablePos);
				break;
			case 57:
				result = ITeleportComponentVerify.Verify(verifier, tablePos);
				break;
			case 58:
				result = ISpawnMonsterComponentVerify.Verify(verifier, tablePos);
				break;
			case 59:
				result = IHitComponentBaseVerify.Verify(verifier, tablePos);
				break;
			case 60:
				result = IDestructibleItemVerify.Verify(verifier, tablePos);
				break;
			case 61:
				result = ITargetGearComponentVerify.Verify(verifier, tablePos);
				break;
			case 62:
				result = IProgressBarControlComponentVerify.Verify(verifier, tablePos);
				break;
			case 63:
				result = IHitComponentVerify.Verify(verifier, tablePos);
				break;
			case 64:
				result = ITargetGearGroupComponentVerify.Verify(verifier, tablePos);
				break;
			case 65:
				result = INpcPerformComponentVerify.Verify(verifier, tablePos);
				break;
			case 66:
				result = IInteractGearComponentVerify.Verify(verifier, tablePos);
				break;
			case 67:
				result = ILiftComponentVerify.Verify(verifier, tablePos);
				break;
			case 68:
				result = IConveyorBeltComponentVerify.Verify(verifier, tablePos);
				break;
			case 69:
				result = IFollowTrackComponentVerify.Verify(verifier, tablePos);
				break;
			case 70:
				result = ISceneItemLifeCycleComponentVerify.Verify(verifier, tablePos);
				break;
			case 71:
				result = IFightInteractComponentVerify.Verify(verifier, tablePos);
				break;
			case 72:
				result = IBubbleComponentVerify.Verify(verifier, tablePos);
				break;
			case 73:
				result = INearbyTrackingComponentVerify.Verify(verifier, tablePos);
				break;
			case 74:
				result = IEntityPackageComponentVerify.Verify(verifier, tablePos);
				break;
			case 75:
				result = ISkyboxComponentVerify.Verify(verifier, tablePos);
				break;
			case 76:
				result = IStateHintComponentVerify.Verify(verifier, tablePos);
				break;
			case 77:
				result = IEntityVisibleComponentVerify.Verify(verifier, tablePos);
				break;
			case 78:
				result = ICombinedVisibleGroupComponentVerify.Verify(verifier, tablePos);
				break;
			case 79:
				result = IWeaponComponentVerify.Verify(verifier, tablePos);
				break;
			case 80:
				result = IDungeonEntryComponentVerify.Verify(verifier, tablePos);
				break;
			case 81:
				result = IResurrectionComponentVerify.Verify(verifier, tablePos);
				break;
			case 82:
				result = IBuffProducerComponentVerify.Verify(verifier, tablePos);
				break;
			case 83:
				result = IBuffConsumerComponentVerify.Verify(verifier, tablePos);
				break;
			case 84:
				result = IGuideLineCreatorComponentVerify.Verify(verifier, tablePos);
				break;
			case 85:
				result = IInteractAudioComponentVerify.Verify(verifier, tablePos);
				break;
			case 86:
				result = IDropComponentVerify.Verify(verifier, tablePos);
				break;
			case 87:
				result = IVisionItemComponentVerify.Verify(verifier, tablePos);
				break;
			case 88:
				result = IAdviseItemComponentVerify.Verify(verifier, tablePos);
				break;
			case 89:
				result = IMonsterComponentVerify.Verify(verifier, tablePos);
				break;
			case 90:
				result = ICombatComponentVerify.Verify(verifier, tablePos);
				break;
			case 91:
				result = IEntityListComponentVerify.Verify(verifier, tablePos);
				break;
			case 92:
				result = IAnimalComponentVerify.Verify(verifier, tablePos);
				break;
			case 93:
				result = ISceneItemMovementComponentVerify.Verify(verifier, tablePos);
				break;
			case 94:
				result = IRangeComponentVerify.Verify(verifier, tablePos);
				break;
			case 95:
				result = IExtraRangeComponentVerify.Verify(verifier, tablePos);
				break;
			case 96:
				result = ITimelineTrackControlComponentVerify.Verify(verifier, tablePos);
				break;
			case 97:
				result = ISplineComponentVerify.Verify(verifier, tablePos);
				break;
			case 98:
				result = IAirWallSpawnerComponentVerify.Verify(verifier, tablePos);
				break;
			case 99:
				result = ISceneActorRefComponentVerify.Verify(verifier, tablePos);
				break;
			case 100:
				result = ISceneBulletComponentVerify.Verify(verifier, tablePos);
				break;
			case 101:
				result = ITurntableControlComponentVerify.Verify(verifier, tablePos);
				break;
			case 102:
				result = IConditionListenerComponentVerify.Verify(verifier, tablePos);
				break;
			case 103:
				result = IAttachTargetComponentVerify.Verify(verifier, tablePos);
				break;
			case 104:
				result = IReboundComponentVerify.Verify(verifier, tablePos);
				break;
			case 105:
				result = IJigsawItemVerify.Verify(verifier, tablePos);
				break;
			case 106:
				result = IJigsawFoundationVerify.Verify(verifier, tablePos);
				break;
			case 107:
				result = ILevelAIComponentVerify.Verify(verifier, tablePos);
				break;
			case 108:
				result = ILevitateMagnetComponentVerify.Verify(verifier, tablePos);
				break;
			case 109:
				result = IPhotoTargetComponentVerify.Verify(verifier, tablePos);
				break;
			case 110:
				result = IAiAlertNotifyComponentVerify.Verify(verifier, tablePos);
				break;
			case 111:
				result = IMonsterGachaItemComponentVerify.Verify(verifier, tablePos);
				break;
			case 112:
				result = IMonsterGachaBaseComponentVerify.Verify(verifier, tablePos);
				break;
			case 113:
				result = IDynamicTeleportComponentVerify.Verify(verifier, tablePos);
				break;
			case 114:
				result = IExploreSkillInteractComponentVerify.Verify(verifier, tablePos);
				break;
			case 115:
				result = IExploreSkillInteractGroupComponentVerify.Verify(verifier, tablePos);
				break;
			case 116:
				result = IFanComponentVerify.Verify(verifier, tablePos);
				break;
			case 117:
				result = IPasserbyNpcSpawnComponentVerify.Verify(verifier, tablePos);
				break;
			case 118:
				result = IModelComponentVerify.Verify(verifier, tablePos);
				break;
			case 119:
				result = IEntityBundleComponentVerify.Verify(verifier, tablePos);
				break;
			case 120:
				result = IBeamCastComponentVerify.Verify(verifier, tablePos);
				break;
			case 121:
				result = IBeamReceiveComponentVerify.Verify(verifier, tablePos);
				break;
			case 122:
				result = ITimeStopComponentVerify.Verify(verifier, tablePos);
				break;
			case 123:
				result = IPortalComponentVerify.Verify(verifier, tablePos);
				break;
			case 124:
				result = IDynamicPortalCreatorComponentVerify.Verify(verifier, tablePos);
				break;
			case 125:
				result = INoRenderPortalComponentVerify.Verify(verifier, tablePos);
				break;
			case 126:
				result = IEffectAreaComponentVerify.Verify(verifier, tablePos);
				break;
			case 127:
				result = IPhysicsConstraintComponentVerify.Verify(verifier, tablePos);
				break;
			case 128:
				result = IFollowDecorationComponentVerify.Verify(verifier, tablePos);
				break;
			case 129:
				result = IFollowShooterComponentVerify.Verify(verifier, tablePos);
				break;
			case 130:
				result = IConnectorComponentVerify.Verify(verifier, tablePos);
				break;
			case 131:
				result = ISceneTextComponentVerify.Verify(verifier, tablePos);
				break;
			case 132:
				result = INavMeshComponentVerify.Verify(verifier, tablePos);
				break;
			case 133:
				result = ICharacterConnectorComponentVerify.Verify(verifier, tablePos);
				break;
			case 134:
				result = IAiGearStrategyComponentVerify.Verify(verifier, tablePos);
				break;
			case 135:
				result = IPickInteractComponentVerify.Verify(verifier, tablePos);
				break;
			case 136:
				result = IChessmanComponentVerify.Verify(verifier, tablePos);
				break;
			case 137:
				result = IClientTriggerComponentVerify.Verify(verifier, tablePos);
				break;
			case 138:
				result = ILocationSafetyComponentVerify.Verify(verifier, tablePos);
				break;
			case 139:
				result = IBatchBulletCasterComponentVerify.Verify(verifier, tablePos);
				break;
			case 140:
				result = IVehicleComponentVerify.Verify(verifier, tablePos);
				break;
			case 141:
				result = IEnrichmentAreaComponentVerify.Verify(verifier, tablePos);
				break;
			case 142:
				result = IMonitorComponentVerify.Verify(verifier, tablePos);
				break;
			case 143:
				result = IGroupAiComponentVerify.Verify(verifier, tablePos);
				break;
			case 144:
				result = IInhalationAbilityComponentVerify.Verify(verifier, tablePos);
				break;
			case 145:
				result = IInhaledItemComponentVerify.Verify(verifier, tablePos);
				break;
			case 146:
				result = IAirPassageComponentVerify.Verify(verifier, tablePos);
				break;
			case 147:
				result = IRenderSpecifiedRangeComponentVerify.Verify(verifier, tablePos);
				break;
			case 148:
				result = ILevelPrefabPerformComponentVerify.Verify(verifier, tablePos);
				break;
			case 149:
				result = ISceneItemAiComponentVerify.Verify(verifier, tablePos);
				break;
			case 150:
				result = IGravityFlipComponentVerify.Verify(verifier, tablePos);
				break;
			case 151:
				result = ILevelSequenceFrameEventComponentVerify.Verify(verifier, tablePos);
				break;
			case 152:
				result = ILevelQteComponentVerify.Verify(verifier, tablePos);
				break;
			case 153:
				result = IWalkingPatternComponentVerify.Verify(verifier, tablePos);
				break;
			case 154:
				result = ILifePointCenterComponentVerify.Verify(verifier, tablePos);
				break;
			case 155:
				result = IHackManagementComponentVerify.Verify(verifier, tablePos);
				break;
			case 156:
				result = IClientConditionListenerComponentVerify.Verify(verifier, tablePos);
				break;
			case 157:
				result = ITemplateEntitySpawnerComponentVerify.Verify(verifier, tablePos);
				break;
			case 158:
				result = IWindSourceComponentVerify.Verify(verifier, tablePos);
				break;
			case 159:
				result = ISlideRailComponentVerify.Verify(verifier, tablePos);
				break;
			case 160:
				result = ISlidePerformComponentVerify.Verify(verifier, tablePos);
				break;
			case 161:
				result = IRollBlockComponentVerify.Verify(verifier, tablePos);
				break;
			case 162:
				result = IRollBlockFloorComponentVerify.Verify(verifier, tablePos);
				break;
			case 163:
				result = IRollBlockItemComponentVerify.Verify(verifier, tablePos);
				break;
			case 164:
				result = ICurveControlComponentVerify.Verify(verifier, tablePos);
				break;
			case 165:
				result = ISimpleCombatComponentVerify.Verify(verifier, tablePos);
				break;
			case 166:
				result = IGridObjectComponentVerify.Verify(verifier, tablePos);
				break;
			case 167:
				result = IGodKingFrequencyControllerComponentVerify.Verify(verifier, tablePos);
				break;
			case 168:
				result = IPerformanceOptimizationComponentVerify.Verify(verifier, tablePos);
				break;
			case 169:
				result = ISceneItemEventListenerComponentVerify.Verify(verifier, tablePos);
				break;
			case 170:
				result = IDynamicSpawnMonsterPointComponentVerify.Verify(verifier, tablePos);
				break;
			case 171:
				result = IDynamicSpawnMonsterComponentVerify.Verify(verifier, tablePos);
				break;
			case 172:
				result = ISunSpiritCollectComponentVerify.Verify(verifier, tablePos);
				break;
			case 173:
				result = ISunSpiritLauncherComponentVerify.Verify(verifier, tablePos);
				break;
			case 174:
				result = ISunSpiritGearComponentVerify.Verify(verifier, tablePos);
				break;
			case 175:
				result = IMotorSlideComponentVerify.Verify(verifier, tablePos);
				break;
			case 176:
				result = IProceduralVisualComponentVerify.Verify(verifier, tablePos);
				break;
			case 177:
				result = IRoadNetworkNavigationComponentVerify.Verify(verifier, tablePos);
				break;
			case 178:
				result = IFurnitureSlotComponentVerify.Verify(verifier, tablePos);
				break;
			case 179:
				result = IVisionDisplayComponentVerify.Verify(verifier, tablePos);
				break;
			case 180:
				result = ISystemModuleDataSyncComponentVerify.Verify(verifier, tablePos);
				break;
			case 181:
				result = IExhibitComponentVerify.Verify(verifier, tablePos);
				break;
			case 182:
				result = ITimeScheduleComponentVerify.Verify(verifier, tablePos);
				break;
			case 183:
				result = IProjectorComponentVerify.Verify(verifier, tablePos);
				break;
			case 184:
				result = IProceduralMaterialComponentVerify.Verify(verifier, tablePos);
				break;
			case 185:
				result = IGameplayDataPersistenceComponentVerify.Verify(verifier, tablePos);
				break;
			case 186:
				result = IFlowerPollutionComponentVerify.Verify(verifier, tablePos);
				break;
			case 187:
				result = IQuickHackComponentVerify.Verify(verifier, tablePos);
				break;
			case 188:
				result = IDollGrabMachineComponentVerify.Verify(verifier, tablePos);
				break;
			case 189:
				result = IDollGrabShowcaseComponentVerify.Verify(verifier, tablePos);
				break;
			case 190:
				result = IWuWaGoComponentVerify.Verify(verifier, tablePos);
				break;
			case 191:
				result = IDragActorPlayComponentVerify.Verify(verifier, tablePos);
				break;
			case 192:
				result = IPathDrivenActorSpawnerComponentVerify.Verify(verifier, tablePos);
				break;
			case 193:
				result = IElementalHolderComponentVerify.Verify(verifier, tablePos);
				break;
			case 194:
				result = IElementalEffectComponentVerify.Verify(verifier, tablePos);
				break;
			case 195:
				result = IElementalBoxFoundationComponentVerify.Verify(verifier, tablePos);
				break;
			case 196:
				result = IElementalWellComponentVerify.Verify(verifier, tablePos);
				break;
			case 197:
				result = IStreamingSourceTriggerPointComponentVerify.Verify(verifier, tablePos);
				break;
			case 198:
				result = IGraph3dComponentVerify.Verify(verifier, tablePos);
				break;
			case 199:
				result = IGraph3dEffectComponentVerify.Verify(verifier, tablePos);
				break;
			case 200:
				result = INoiseRemovalComponentVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}

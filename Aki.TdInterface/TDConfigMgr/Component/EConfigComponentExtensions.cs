using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200090E RID: 2318
	public static class EConfigComponentExtensions
	{
		// Token: 0x06003470 RID: 13424 RVA: 0x00085CF0 File Offset: 0x00083EF0
		public static string ToEnumString(this EConfigComponent value)
		{
			string result;
			switch (value)
			{
			case EConfigComponent.AirWallSpawnerComponent:
				result = "AirWallSpawnerComponent";
				break;
			case EConfigComponent.ActorStateComponent:
				result = "ActorStateComponent";
				break;
			case EConfigComponent.BehaviorFlowComponent:
				result = "BehaviorFlowComponent";
				break;
			case EConfigComponent.CalculateComponent:
				result = "CalculateComponent";
				break;
			case EConfigComponent.EntitySpawnerComponent:
				result = "EntitySpawnerComponent";
				break;
			case EConfigComponent.EventComponent:
				result = "EventComponent";
				break;
			case EConfigComponent.FlowComponent:
				result = "FlowComponent";
				break;
			case EConfigComponent.GrabComponent:
				result = "GrabComponent";
				break;
			case EConfigComponent.InteractiveComponent:
				result = "InteractiveComponent";
				break;
			case EConfigComponent.LampComponent:
				result = "LampComponent";
				break;
			case EConfigComponent.MoveComponent:
				result = "MoveComponent";
				break;
			case EConfigComponent.NpcComponent:
				result = "NpcComponent";
				break;
			case EConfigComponent.RefreshEntityComponent:
				result = "RefreshEntityComponent";
				break;
			case EConfigComponent.RefreshSingleComponent:
				result = "RefreshSingleComponent";
				break;
			case EConfigComponent.RotatorComponent:
				result = "RotatorComponent";
				break;
			case EConfigComponent.RotatorComponent2:
				result = "RotatorComponent2";
				break;
			case EConfigComponent.RoleMotionInteractComponent:
				result = "RoleMotionInteractComponent";
				break;
			case EConfigComponent.SimpleComponent:
				result = "SimpleComponent";
				break;
			case EConfigComponent.SphereComponent:
				result = "SphereComponent";
				break;
			case EConfigComponent.SphereFactoryComponent:
				result = "SphereFactoryComponent";
				break;
			case EConfigComponent.SpringBoardComponent:
				result = "SpringBoardComponent";
				break;
			case EConfigComponent.SpringComponent:
				result = "SpringComponent";
				break;
			case EConfigComponent.StateComponent:
				result = "StateComponent";
				break;
			case EConfigComponent.SwitcherComponent:
				result = "SwitcherComponent";
				break;
			case EConfigComponent.SpawnMonsterComponent:
				result = "SpawnMonsterComponent";
				break;
			case EConfigComponent.TalkComponent:
				result = "TalkComponent";
				break;
			case EConfigComponent.TrampleUe5Component:
				result = "TrampleUe5Component";
				break;
			case EConfigComponent.TriggerComponent:
				result = "TriggerComponent";
				break;
			case EConfigComponent.ClientTriggerComponent:
				result = "ClientTriggerComponent";
				break;
			case EConfigComponent.TriggerUe5Component:
				result = "TriggerUe5Component";
				break;
			case EConfigComponent.UndergroundComponent:
				result = "UndergroundComponent";
				break;
			case EConfigComponent.InteractComponent:
				result = "InteractComponent";
				break;
			case EConfigComponent.VarComponent:
				result = "VarComponent";
				break;
			case EConfigComponent.AiComponent:
				result = "AiComponent";
				break;
			case EConfigComponent.LevelAiComponent:
				result = "LevelAiComponent";
				break;
			case EConfigComponent.AttributeComponent:
				result = "AttributeComponent";
				break;
			case EConfigComponent.BaseInfoComponent:
				result = "BaseInfoComponent";
				break;
			case EConfigComponent.RewardComponent:
				result = "RewardComponent";
				break;
			case EConfigComponent.RefreshComponent:
				result = "RefreshComponent";
				break;
			case EConfigComponent.RefreshGroupComponent:
				result = "RefreshGroupComponent";
				break;
			case EConfigComponent.TreasureBoxComponent:
				result = "TreasureBoxComponent";
				break;
			case EConfigComponent.EntityStateComponent:
				result = "EntityStateComponent";
				break;
			case EConfigComponent.SceneItemAttributeComponent:
				result = "SceneItemAttributeComponent";
				break;
			case EConfigComponent.HookLockPoint:
				result = "HookLockPoint";
				break;
			case EConfigComponent.HookFetchComponent:
				result = "HookFetchComponent";
				break;
			case EConfigComponent.TargetGearComponent:
				result = "TargetGearComponent";
				break;
			case EConfigComponent.TargetGearGroupComponent:
				result = "TargetGearGroupComponent";
				break;
			case EConfigComponent.ItemFoundation:
				result = "ItemFoundation";
				break;
			case EConfigComponent.ItemFoundation2:
				result = "ItemFoundation2";
				break;
			case EConfigComponent.PullingObjectFoundation:
				result = "PullingObjectFoundation";
				break;
			case EConfigComponent.JigsawItem:
				result = "JigsawItem";
				break;
			case EConfigComponent.JigsawFoundation:
				result = "JigsawFoundation";
				break;
			case EConfigComponent.CollectComponent:
				result = "CollectComponent";
				break;
			case EConfigComponent.TeleControl2:
				result = "TeleControl2";
				break;
			case EConfigComponent.DestructibleItem:
				result = "DestructibleItem";
				break;
			case EConfigComponent.LevelPlayComponent:
				result = "LevelPlayComponent";
				break;
			case EConfigComponent.VisionComponent:
				result = "VisionComponent";
				break;
			case EConfigComponent.VisionCaptureComponent:
				result = "VisionCaptureComponent";
				break;
			case EConfigComponent.EntityGroupComponent:
				result = "EntityGroupComponent";
				break;
			case EConfigComponent.ResetEntitiesPosComponent:
				result = "ResetEntitiesPosComponent";
				break;
			case EConfigComponent.ResetSelfPosComponent:
				result = "ResetSelfPosComponent";
				break;
			case EConfigComponent.AdsorbComponent:
				result = "AdsorbComponent";
				break;
			case EConfigComponent.TeleportComponent:
				result = "TeleportComponent";
				break;
			case EConfigComponent.TrampleComponent:
				result = "TrampleComponent";
				break;
			case EConfigComponent.NpcPerformComponent:
				result = "NpcPerformComponent";
				break;
			case EConfigComponent.InteractGearComponent:
				result = "InteractGearComponent";
				break;
			case EConfigComponent.LiftComponent:
				result = "LiftComponent";
				break;
			case EConfigComponent.FollowTrackComponent:
				result = "FollowTrackComponent";
				break;
			case EConfigComponent.SceneItemLifeCycleComponent:
				result = "SceneItemLifeCycleComponent";
				break;
			case EConfigComponent.BubbleComponent:
				result = "BubbleComponent";
				break;
			case EConfigComponent.FightInteractComponent:
				result = "FightInteractComponent";
				break;
			case EConfigComponent.NearbyTrackingComponent:
				result = "NearbyTrackingComponent";
				break;
			case EConfigComponent.EntityPackageComponent:
				result = "EntityPackageComponent";
				break;
			case EConfigComponent.SkyboxComponent:
				result = "SkyboxComponent";
				break;
			case EConfigComponent.StateHintComponent:
				result = "StateHintComponent";
				break;
			case EConfigComponent.EntityVisibleComponent:
				result = "EntityVisibleComponent";
				break;
			case EConfigComponent.CombinedVisibleGroupComponent:
				result = "CombinedVisibleGroupComponent";
				break;
			case EConfigComponent.WeaponComponent:
				result = "WeaponComponent";
				break;
			case EConfigComponent.DungeonEntryComponent:
				result = "DungeonEntryComponent";
				break;
			case EConfigComponent.ResurrectionComponent:
				result = "ResurrectionComponent";
				break;
			case EConfigComponent.BuffProducerComponent:
				result = "BuffProducerComponent";
				break;
			case EConfigComponent.BuffConsumerComponent:
				result = "BuffConsumerComponent";
				break;
			case EConfigComponent.GuideLineCreatorComponent:
				result = "GuideLineCreatorComponent";
				break;
			case EConfigComponent.InteractAudioComponent:
				result = "InteractAudioComponent";
				break;
			case EConfigComponent.DropComponent:
				result = "DropComponent";
				break;
			case EConfigComponent.AdviseItemComponent:
				result = "AdviseItemComponent";
				break;
			case EConfigComponent.VisionItemComponent:
				result = "VisionItemComponent";
				break;
			case EConfigComponent.MonsterComponent:
				result = "MonsterComponent";
				break;
			case EConfigComponent.CombatComponent:
				result = "CombatComponent";
				break;
			case EConfigComponent.EntityListComponent:
				result = "EntityListComponent";
				break;
			case EConfigComponent.AnimalComponent:
				result = "AnimalComponent";
				break;
			case EConfigComponent.EntityAudioComponent:
				result = "EntityAudioComponent";
				break;
			case EConfigComponent.EntityStateAudioComponent:
				result = "EntityStateAudioComponent";
				break;
			case EConfigComponent.EntityCustomAudioComponent:
				result = "EntityCustomAudioComponent";
				break;
			case EConfigComponent.SceneItemMovementComponent:
				result = "SceneItemMovementComponent";
				break;
			case EConfigComponent.RangeComponent:
				result = "RangeComponent";
				break;
			case EConfigComponent.ExtraRangeComponent:
				result = "ExtraRangeComponent";
				break;
			case EConfigComponent.TimelineTrackControlComponent:
				result = "TimelineTrackControlComponent";
				break;
			case EConfigComponent.SplineComponent:
				result = "SplineComponent";
				break;
			case EConfigComponent.SceneActorRefComponent:
				result = "SceneActorRefComponent";
				break;
			case EConfigComponent.EditCustomAoiComponent:
				result = "EditCustomAoiComponent";
				break;
			case EConfigComponent.SceneBulletComponent:
				result = "SceneBulletComponent";
				break;
			case EConfigComponent.TurntableControlComponent:
				result = "TurntableControlComponent";
				break;
			case EConfigComponent.ConditionListenerComponent:
				result = "ConditionListenerComponent";
				break;
			case EConfigComponent.AttachTargetComponent:
				result = "AttachTargetComponent";
				break;
			case EConfigComponent.ReboundComponent:
				result = "ReboundComponent";
				break;
			case EConfigComponent.LevitateMagnetComponent:
				result = "LevitateMagnetComponent";
				break;
			case EConfigComponent.PhotoTargetComponent:
				result = "PhotoTargetComponent";
				break;
			case EConfigComponent.AiAlertNotifyComponent:
				result = "AiAlertNotifyComponent";
				break;
			case EConfigComponent.MonsterGachaItemComponent:
				result = "MonsterGachaItemComponent";
				break;
			case EConfigComponent.MonsterGachaBaseComponent:
				result = "MonsterGachaBaseComponent";
				break;
			case EConfigComponent.ProgressBarControlComponent:
				result = "ProgressBarControlComponent";
				break;
			case EConfigComponent.ConveyorBeltComponent:
				result = "ConveyorBeltComponent";
				break;
			case EConfigComponent.DynamicTeleportComponent:
				result = "DynamicTeleportComponent";
				break;
			case EConfigComponent.ExploreSkillInteractComponent:
				result = "ExploreSkillInteractComponent";
				break;
			case EConfigComponent.ExploreSkillInteractGroupComponent:
				result = "ExploreSkillInteractGroupComponent";
				break;
			case EConfigComponent.FanComponent:
				result = "FanComponent";
				break;
			case EConfigComponent.PasserbyNpcSpawnComponent:
				result = "PasserbyNpcSpawnComponent";
				break;
			case EConfigComponent.ModelComponent:
				result = "ModelComponent";
				break;
			case EConfigComponent.EntityBundleComponent:
				result = "EntityBundleComponent";
				break;
			case EConfigComponent.BeamCastComponent:
				result = "BeamCastComponent";
				break;
			case EConfigComponent.BeamReceiveComponent:
				result = "BeamReceiveComponent";
				break;
			case EConfigComponent.TimeStopComponent:
				result = "TimeStopComponent";
				break;
			case EConfigComponent.PortalComponent:
				result = "PortalComponent";
				break;
			case EConfigComponent.NoRenderPortalComponent:
				result = "NoRenderPortalComponent";
				break;
			case EConfigComponent.EffectAreaComponent:
				result = "EffectAreaComponent";
				break;
			case EConfigComponent.PhysicsConstraintComponent:
				result = "PhysicsConstraintComponent";
				break;
			case EConfigComponent.FollowDecorationComponent:
				result = "FollowDecorationComponent";
				break;
			case EConfigComponent.FollowShooterComponent:
				result = "FollowShooterComponent";
				break;
			case EConfigComponent.ConnectorComponent:
				result = "ConnectorComponent";
				break;
			case EConfigComponent.CharacterConnectorComponent:
				result = "CharacterConnectorComponent";
				break;
			case EConfigComponent.HitComponent:
				result = "HitComponent";
				break;
			case EConfigComponent.DynamicPortalCreatorComponent:
				result = "DynamicPortalCreatorComponent";
				break;
			case EConfigComponent.AiGearStrategyComponent:
				result = "AiGearStrategyComponent";
				break;
			case EConfigComponent.PickInteractComponent:
				result = "PickInteractComponent";
				break;
			case EConfigComponent.LocationSafetyComponent:
				result = "LocationSafetyComponent";
				break;
			case EConfigComponent.BatchBulletCasterComponent:
				result = "BatchBulletCasterComponent";
				break;
			case EConfigComponent.VehicleComponent:
				result = "VehicleComponent";
				break;
			case EConfigComponent.EnrichmentAreaComponent:
				result = "EnrichmentAreaComponent";
				break;
			case EConfigComponent.ChessmanComponent:
				result = "ChessmanComponent";
				break;
			case EConfigComponent.MonitorComponent:
				result = "MonitorComponent";
				break;
			case EConfigComponent.GroupAiComponent:
				result = "GroupAiComponent";
				break;
			case EConfigComponent.InhalationAbilityComponent:
				result = "InhalationAbilityComponent";
				break;
			case EConfigComponent.InhaledItemComponent:
				result = "InhaledItemComponent";
				break;
			case EConfigComponent.AirPassageComponent:
				result = "AirPassageComponent";
				break;
			case EConfigComponent.RenderSpecifiedRangeComponent:
				result = "RenderSpecifiedRangeComponent";
				break;
			case EConfigComponent.LevelPrefabPerformComponent:
				result = "LevelPrefabPerformComponent";
				break;
			case EConfigComponent.SceneItemAiComponent:
				result = "SceneItemAiComponent";
				break;
			case EConfigComponent.GravityFlipComponent:
				result = "GravityFlipComponent";
				break;
			case EConfigComponent.LevelSequenceFrameEventComponent:
				result = "LevelSequenceFrameEventComponent";
				break;
			case EConfigComponent.LevelQteComponent:
				result = "LevelQteComponent";
				break;
			case EConfigComponent.WalkingPatternComponent:
				result = "WalkingPatternComponent";
				break;
			case EConfigComponent.LifePointCenterComponent:
				result = "LifePointCenterComponent";
				break;
			case EConfigComponent.HackManagementComponent:
				result = "HackManagementComponent";
				break;
			case EConfigComponent.ClientConditionListenerComponent:
				result = "ClientConditionListenerComponent";
				break;
			case EConfigComponent.TemplateEntitySpawnerComponent:
				result = "TemplateEntitySpawnerComponent";
				break;
			case EConfigComponent.WindSourceComponent:
				result = "WindSourceComponent";
				break;
			case EConfigComponent.SlideRailComponent:
				result = "SlideRailComponent";
				break;
			case EConfigComponent.CurveControlComponent:
				result = "CurveControlComponent";
				break;
			case EConfigComponent.EntityBatchRefreshComponent:
				result = "EntityBatchRefreshComponent";
				break;
			case EConfigComponent.SimpleCombatComponent:
				result = "SimpleCombatComponent";
				break;
			case EConfigComponent.GridObjectComponent:
				result = "GridObjectComponent";
				break;
			case EConfigComponent.GodKingFrequencyControllerComponent:
				result = "GodKingFrequencyControllerComponent";
				break;
			case EConfigComponent.PerformanceOptimizationComponent:
				result = "PerformanceOptimizationComponent";
				break;
			case EConfigComponent.SceneItemEventListenerComponent:
				result = "SceneItemEventListenerComponent";
				break;
			case EConfigComponent.DynamicSpawnMonsterPointComponent:
				result = "DynamicSpawnMonsterPointComponent";
				break;
			case EConfigComponent.DynamicSpawnMonsterComponent:
				result = "DynamicSpawnMonsterComponent";
				break;
			case EConfigComponent.RollBlockComponent:
				result = "RollBlockComponent";
				break;
			case EConfigComponent.RollBlockFloorComponent:
				result = "RollBlockFloorComponent";
				break;
			case EConfigComponent.RollBlockItemComponent:
				result = "RollBlockItemComponent";
				break;
			case EConfigComponent.SunSpiritCollectComponent:
				result = "SunSpiritCollectComponent";
				break;
			case EConfigComponent.SunSpiritLauncherComponent:
				result = "SunSpiritLauncherComponent";
				break;
			case EConfigComponent.SunSpiritGearComponent:
				result = "SunSpiritGearComponent";
				break;
			case EConfigComponent.MotorSlideComponent:
				result = "MotorSlideComponent";
				break;
			case EConfigComponent.ProceduralVisualComponent:
				result = "ProceduralVisualComponent";
				break;
			case EConfigComponent.RoadNetworkNavigationComponent:
				result = "RoadNetworkNavigationComponent";
				break;
			case EConfigComponent.DynamicEntityRewardComponent:
				result = "DynamicEntityRewardComponent";
				break;
			case EConfigComponent.FurnitureSlotComponent:
				result = "FurnitureSlotComponent";
				break;
			case EConfigComponent.VisionDisplayComponent:
				result = "VisionDisplayComponent";
				break;
			case EConfigComponent.SystemModuleDataSyncComponent:
				result = "SystemModuleDataSyncComponent";
				break;
			case EConfigComponent.ExhibitComponent:
				result = "ExhibitComponent";
				break;
			case EConfigComponent.SlidePerformComponent:
				result = "SlidePerformComponent";
				break;
			case EConfigComponent.TimeScheduleComponent:
				result = "TimeScheduleComponent";
				break;
			case EConfigComponent.ProjectorComponent:
				result = "ProjectorComponent";
				break;
			case EConfigComponent.ProceduralMaterialComponent:
				result = "ProceduralMaterialComponent";
				break;
			case EConfigComponent.GameplayDataPersistenceComponent:
				result = "GameplayDataPersistenceComponent";
				break;
			case EConfigComponent.FlowerPollutionComponent:
				result = "FlowerPollutionComponent";
				break;
			case EConfigComponent.QuickHackComponent:
				result = "QuickHackComponent";
				break;
			case EConfigComponent.DollGrabMachineComponent:
				result = "DollGrabMachineComponent";
				break;
			case EConfigComponent.DollGrabShowcaseComponent:
				result = "DollGrabShowcaseComponent";
				break;
			case EConfigComponent.WuWaGoComponent:
				result = "WuWaGoComponent";
				break;
			case EConfigComponent.DragActorPlayComponent:
				result = "DragActorPlayComponent";
				break;
			case EConfigComponent.PathDrivenActorSpawnerComponent:
				result = "PathDrivenActorSpawnerComponent";
				break;
			case EConfigComponent.ElementalHolderComponent:
				result = "ElementalHolderComponent";
				break;
			case EConfigComponent.ElementalEffectComponent:
				result = "ElementalEffectComponent";
				break;
			case EConfigComponent.IndependentSystemRewardComponent:
				result = "IndependentSystemRewardComponent";
				break;
			case EConfigComponent.Graph3dComponent:
				result = "Graph3dComponent";
				break;
			case EConfigComponent.Graph3dEffectComponent:
				result = "Graph3dEffectComponent";
				break;
			case EConfigComponent.ElementalBoxFoundationComponent:
				result = "ElementalBoxFoundationComponent";
				break;
			case EConfigComponent.ElementalWellComponent:
				result = "ElementalWellComponent";
				break;
			case EConfigComponent.StreamingSourceTriggerPointComponent:
				result = "StreamingSourceTriggerPointComponent";
				break;
			case EConfigComponent.NoiseRemovalComponent:
				result = "NoiseRemovalComponent";
				break;
			case EConfigComponent.SceneTextComponent:
				result = "SceneTextComponent";
				break;
			case EConfigComponent.NavMeshComponent:
				result = "NavMeshComponent";
				break;
			case EConfigComponent.DynamicLevelPlayComponent:
				result = "DynamicLevelPlayComponent";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x000868F0 File Offset: 0x00084AF0
		public static EConfigComponent FromString(string name)
		{
			EConfigComponent result;
			if (!EConfigComponentExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EConfigComponent 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x0008691C File Offset: 0x00084B1C
		public static bool TryFromString(string name, out EConfigComponent value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EConfigComponent.AirWallSpawnerComponent;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 10:
					if (name == "JigsawItem")
					{
						value = EConfigComponent.JigsawItem;
						return true;
					}
					break;
				case 11:
					if (name == "AiComponent")
					{
						value = EConfigComponent.AiComponent;
						return true;
					}
					break;
				case 12:
				{
					char c = name[0];
					if (c <= 'H')
					{
						if (c != 'F')
						{
							if (c == 'H')
							{
								if (name == "HitComponent")
								{
									value = EConfigComponent.HitComponent;
									return true;
								}
							}
						}
						else if (name == "FanComponent")
						{
							value = EConfigComponent.FanComponent;
							return true;
						}
					}
					else if (c != 'N')
					{
						if (c != 'T')
						{
							if (c == 'V')
							{
								if (name == "VarComponent")
								{
									value = EConfigComponent.VarComponent;
									return true;
								}
							}
						}
						else if (name == "TeleControl2")
						{
							value = EConfigComponent.TeleControl2;
							return true;
						}
					}
					else if (name == "NpcComponent")
					{
						value = EConfigComponent.NpcComponent;
						return true;
					}
					break;
				}
				case 13:
				{
					char c = name[0];
					switch (c)
					{
					case 'D':
						if (name == "DropComponent")
						{
							value = EConfigComponent.DropComponent;
							return true;
						}
						break;
					case 'E':
					case 'I':
					case 'J':
					case 'K':
						break;
					case 'F':
						if (name == "FlowComponent")
						{
							value = EConfigComponent.FlowComponent;
							return true;
						}
						break;
					case 'G':
						if (name == "GrabComponent")
						{
							value = EConfigComponent.GrabComponent;
							return true;
						}
						break;
					case 'H':
						if (name == "HookLockPoint")
						{
							value = EConfigComponent.HookLockPoint;
							return true;
						}
						break;
					case 'L':
						if (name == "LampComponent")
						{
							value = EConfigComponent.LampComponent;
							return true;
						}
						if (name == "LiftComponent")
						{
							value = EConfigComponent.LiftComponent;
							return true;
						}
						break;
					case 'M':
						if (name == "MoveComponent")
						{
							value = EConfigComponent.MoveComponent;
							return true;
						}
						break;
					default:
						if (c == 'T')
						{
							if (name == "TalkComponent")
							{
								value = EConfigComponent.TalkComponent;
								return true;
							}
						}
						break;
					}
					break;
				}
				case 14:
				{
					char c = name[0];
					if (c <= 'I')
					{
						if (c != 'E')
						{
							if (c == 'I')
							{
								if (name == "ItemFoundation")
								{
									value = EConfigComponent.ItemFoundation;
									return true;
								}
							}
						}
						else if (name == "EventComponent")
						{
							value = EConfigComponent.EventComponent;
							return true;
						}
					}
					else if (c != 'M')
					{
						if (c != 'R')
						{
							if (c == 'S')
							{
								if (name == "StateComponent")
								{
									value = EConfigComponent.StateComponent;
									return true;
								}
							}
						}
						else if (name == "RangeComponent")
						{
							value = EConfigComponent.RangeComponent;
							return true;
						}
					}
					else if (name == "ModelComponent")
					{
						value = EConfigComponent.ModelComponent;
						return true;
					}
					break;
				}
				case 15:
				{
					char c = name[2];
					if (c <= 'r')
					{
						if (c != 'W')
						{
							switch (c)
							{
							case 'a':
								if (name == "WeaponComponent")
								{
									value = EConfigComponent.WeaponComponent;
									return true;
								}
								break;
							case 'b':
								if (name == "BubbleComponent")
								{
									value = EConfigComponent.BubbleComponent;
									return true;
								}
								break;
							case 'c':
							case 'd':
							case 'f':
							case 'g':
							case 'j':
							case 'k':
								break;
							case 'e':
								if (name == "ItemFoundation2")
								{
									value = EConfigComponent.ItemFoundation2;
									return true;
								}
								break;
							case 'h':
								if (name == "SphereComponent")
								{
									value = EConfigComponent.SphereComponent;
									return true;
								}
								break;
							case 'i':
								if (name == "AnimalComponent")
								{
									value = EConfigComponent.AnimalComponent;
									return true;
								}
								break;
							case 'l':
								if (name == "SplineComponent")
								{
									value = EConfigComponent.SplineComponent;
									return true;
								}
								break;
							case 'm':
								if (name == "SimpleComponent")
								{
									value = EConfigComponent.SimpleComponent;
									return true;
								}
								if (name == "CombatComponent")
								{
									value = EConfigComponent.CombatComponent;
									return true;
								}
								break;
							default:
								if (c == 'r')
								{
									if (name == "SpringComponent")
									{
										value = EConfigComponent.SpringComponent;
										return true;
									}
									if (name == "PortalComponent")
									{
										value = EConfigComponent.PortalComponent;
										return true;
									}
								}
								break;
							}
						}
						else if (name == "WuWaGoComponent")
						{
							value = EConfigComponent.WuWaGoComponent;
							return true;
						}
					}
					else if (c != 's')
					{
						if (c != 'w')
						{
							if (c == 'y')
							{
								if (name == "SkyboxComponent")
								{
									value = EConfigComponent.SkyboxComponent;
									return true;
								}
							}
						}
						else if (name == "RewardComponent")
						{
							value = EConfigComponent.RewardComponent;
							return true;
						}
					}
					else
					{
						if (name == "VisionComponent")
						{
							value = EConfigComponent.VisionComponent;
							return true;
						}
						if (name == "AdsorbComponent")
						{
							value = EConfigComponent.AdsorbComponent;
							return true;
						}
					}
					break;
				}
				case 16:
				{
					char c = name[3];
					if (c != 'M')
					{
						switch (c)
						{
						case 'a':
							if (name == "RotatorComponent")
							{
								value = EConfigComponent.RotatorComponent;
								return true;
							}
							break;
						case 'e':
							if (name == "LevelAiComponent")
							{
								value = EConfigComponent.LevelAiComponent;
								return true;
							}
							break;
						case 'g':
							if (name == "TriggerComponent")
							{
								value = EConfigComponent.TriggerComponent;
								return true;
							}
							break;
						case 'i':
							if (name == "VehicleComponent")
							{
								value = EConfigComponent.VehicleComponent;
								return true;
							}
							if (name == "MonitorComponent")
							{
								value = EConfigComponent.MonitorComponent;
								return true;
							}
							if (name == "ExhibitComponent")
							{
								value = EConfigComponent.ExhibitComponent;
								return true;
							}
							break;
						case 'l':
							if (name == "CollectComponent")
							{
								value = EConfigComponent.CollectComponent;
								return true;
							}
							break;
						case 'm':
							if (name == "TrampleComponent")
							{
								value = EConfigComponent.TrampleComponent;
								return true;
							}
							break;
						case 'o':
							if (name == "ReboundComponent")
							{
								value = EConfigComponent.ReboundComponent;
								return true;
							}
							break;
						case 'p':
							if (name == "Graph3dComponent")
							{
								value = EConfigComponent.Graph3dComponent;
								return true;
							}
							break;
						case 'r':
							if (name == "RefreshComponent")
							{
								value = EConfigComponent.RefreshComponent;
								return true;
							}
							break;
						case 's':
							if (name == "JigsawFoundation")
							{
								value = EConfigComponent.JigsawFoundation;
								return true;
							}
							if (name == "MonsterComponent")
							{
								value = EConfigComponent.MonsterComponent;
								return true;
							}
							break;
						case 't':
							if (name == "DestructibleItem")
							{
								value = EConfigComponent.DestructibleItem;
								return true;
							}
							break;
						case 'u':
							if (name == "GroupAiComponent")
							{
								value = EConfigComponent.GroupAiComponent;
								return true;
							}
							break;
						}
					}
					else if (name == "NavMeshComponent")
					{
						value = EConfigComponent.NavMeshComponent;
						return true;
					}
					break;
				}
				case 17:
				{
					char c = name[4];
					if (c <= 'I')
					{
						if (c != 'C')
						{
							if (c == 'I')
							{
								if (name == "BaseInfoComponent")
								{
									value = EConfigComponent.BaseInfoComponent;
									return true;
								}
							}
						}
						else if (name == "BeamCastComponent")
						{
							value = EConfigComponent.BeamCastComponent;
							return true;
						}
					}
					else if (c != 'S')
					{
						if (c != 'c')
						{
							switch (c)
							{
							case 'l':
								if (name == "LevelQteComponent")
								{
									value = EConfigComponent.LevelQteComponent;
									return true;
								}
								break;
							case 'p':
								if (name == "TeleportComponent")
								{
									value = EConfigComponent.TeleportComponent;
									return true;
								}
								break;
							case 'r':
								if (name == "InteractComponent")
								{
									value = EConfigComponent.InteractComponent;
									return true;
								}
								break;
							case 's':
								if (name == "ChessmanComponent")
								{
									value = EConfigComponent.ChessmanComponent;
									return true;
								}
								break;
							case 't':
								if (name == "RotatorComponent2")
								{
									value = EConfigComponent.RotatorComponent2;
									return true;
								}
								break;
							}
						}
						else if (name == "SwitcherComponent")
						{
							value = EConfigComponent.SwitcherComponent;
							return true;
						}
					}
					else if (name == "TimeStopComponent")
					{
						value = EConfigComponent.TimeStopComponent;
						return true;
					}
					break;
				}
				case 18:
				{
					char c = name[3];
					switch (c)
					{
					case 'c':
						if (name == "CalculateComponent")
						{
							value = EConfigComponent.CalculateComponent;
							return true;
						}
						if (name == "QuickHackComponent")
						{
							value = EConfigComponent.QuickHackComponent;
							return true;
						}
						break;
					case 'd':
						if (name == "SlideRailComponent")
						{
							value = EConfigComponent.SlideRailComponent;
							return true;
						}
						break;
					case 'e':
						if (name == "LevelPlayComponent")
						{
							value = EConfigComponent.LevelPlayComponent;
							return true;
						}
						break;
					case 'f':
					case 'g':
					case 'h':
					case 'i':
					case 'm':
						break;
					case 'j':
						if (name == "ProjectorComponent")
						{
							value = EConfigComponent.ProjectorComponent;
							return true;
						}
						break;
					case 'k':
						if (name == "HookFetchComponent")
						{
							value = EConfigComponent.HookFetchComponent;
							return true;
						}
						break;
					case 'l':
						if (name == "RollBlockComponent")
						{
							value = EConfigComponent.RollBlockComponent;
							return true;
						}
						break;
					case 'n':
						if (name == "ConnectorComponent")
						{
							value = EConfigComponent.ConnectorComponent;
							return true;
						}
						if (name == "SceneTextComponent")
						{
							value = EConfigComponent.SceneTextComponent;
							return true;
						}
						break;
					default:
						if (c != 'r')
						{
							if (c == 't')
							{
								if (name == "StateHintComponent")
								{
									value = EConfigComponent.StateHintComponent;
									return true;
								}
							}
						}
						else if (name == "AttributeComponent")
						{
							value = EConfigComponent.AttributeComponent;
							return true;
						}
						break;
					}
					break;
				}
				case 19:
				{
					char c = name[6];
					if (c <= 'a')
					{
						if (c <= 'G')
						{
							if (c != 'A')
							{
								if (c == 'G')
								{
									if (name == "TargetGearComponent")
									{
										value = EConfigComponent.TargetGearComponent;
										return true;
									}
								}
							}
							else if (name == "EffectAreaComponent")
							{
								value = EConfigComponent.EffectAreaComponent;
								return true;
							}
						}
						else if (c != 'I')
						{
							if (c != 'L')
							{
								if (c == 'a')
								{
									if (name == "ExtraRangeComponent")
									{
										value = EConfigComponent.ExtraRangeComponent;
										return true;
									}
								}
							}
							else if (name == "EntityListComponent")
							{
								value = EConfigComponent.EntityListComponent;
								return true;
							}
						}
						else
						{
							if (name == "AdviseItemComponent")
							{
								value = EConfigComponent.AdviseItemComponent;
								return true;
							}
							if (name == "VisionItemComponent")
							{
								value = EConfigComponent.VisionItemComponent;
								return true;
							}
						}
					}
					else if (c <= 'f')
					{
						if (c != 'e')
						{
							if (c == 'f')
							{
								if (name == "NpcPerformComponent")
								{
									value = EConfigComponent.NpcPerformComponent;
									return true;
								}
							}
						}
						else if (name == "TrampleUe5Component")
						{
							value = EConfigComponent.TrampleUe5Component;
							return true;
						}
					}
					else if (c != 'j')
					{
						if (c != 'l')
						{
							switch (c)
							{
							case 'r':
								if (name == "TriggerUe5Component")
								{
									value = EConfigComponent.TriggerUe5Component;
									return true;
								}
								break;
							case 's':
								if (name == "AirPassageComponent")
								{
									value = EConfigComponent.AirPassageComponent;
									return true;
								}
								break;
							case 't':
								if (name == "ActorStateComponent")
								{
									value = EConfigComponent.ActorStateComponent;
									return true;
								}
								break;
							case 'u':
								if (name == "WindSourceComponent")
								{
									value = EConfigComponent.WindSourceComponent;
									return true;
								}
								break;
							}
						}
						else if (name == "MotorSlideComponent")
						{
							value = EConfigComponent.MotorSlideComponent;
							return true;
						}
					}
					else if (name == "GridObjectComponent")
					{
						value = EConfigComponent.GridObjectComponent;
						return true;
					}
					break;
				}
				case 20:
				{
					char c = name[6];
					if (c <= 'S')
					{
						if (c <= 'B')
						{
							if (c != 'A')
							{
								if (c == 'B')
								{
									if (name == "SpringBoardComponent")
									{
										value = EConfigComponent.SpringBoardComponent;
										return true;
									}
								}
							}
							else if (name == "EntityAudioComponent")
							{
								value = EConfigComponent.EntityAudioComponent;
								return true;
							}
						}
						else if (c != 'G')
						{
							if (c == 'S')
							{
								if (name == "EntityStateComponent")
								{
									value = EConfigComponent.EntityStateComponent;
									return true;
								}
							}
						}
						else if (name == "EntityGroupComponent")
						{
							value = EConfigComponent.EntityGroupComponent;
							return true;
						}
					}
					else if (c <= 'd')
					{
						if (c != 'T')
						{
							switch (c)
							{
							case 'a':
								if (name == "PhotoTargetComponent")
								{
									value = EConfigComponent.PhotoTargetComponent;
									return true;
								}
								break;
							case 'c':
								if (name == "InteractiveComponent")
								{
									value = EConfigComponent.InteractiveComponent;
									return true;
								}
								if (name == "BeamReceiveComponent")
								{
									value = EConfigComponent.BeamReceiveComponent;
									return true;
								}
								break;
							case 'd':
								if (name == "InhaledItemComponent")
								{
									value = EConfigComponent.InhaledItemComponent;
									return true;
								}
								break;
							}
						}
						else if (name == "FollowTrackComponent")
						{
							value = EConfigComponent.FollowTrackComponent;
							return true;
						}
					}
					else
					{
						switch (c)
						{
						case 'r':
							if (name == "UndergroundComponent")
							{
								value = EConfigComponent.UndergroundComponent;
								return true;
							}
							if (name == "TreasureBoxComponent")
							{
								value = EConfigComponent.TreasureBoxComponent;
								return true;
							}
							break;
						case 's':
							break;
						case 't':
							if (name == "SceneItemAiComponent")
							{
								value = EConfigComponent.SceneItemAiComponent;
								return true;
							}
							break;
						case 'u':
							if (name == "SceneBulletComponent")
							{
								value = EConfigComponent.SceneBulletComponent;
								return true;
							}
							break;
						default:
							if (c == 'y')
							{
								if (name == "GravityFlipComponent")
								{
									value = EConfigComponent.GravityFlipComponent;
									return true;
								}
							}
							break;
						}
					}
					break;
				}
				case 21:
				{
					char c = name[5];
					if (c <= 'S')
					{
						if (c != 'C')
						{
							switch (c)
							{
							case 'M':
								if (name == "SpawnMonsterComponent")
								{
									value = EConfigComponent.SpawnMonsterComponent;
									return true;
								}
								break;
							case 'P':
								if (name == "SlidePerformComponent")
								{
									value = EConfigComponent.SlidePerformComponent;
									return true;
								}
								break;
							case 'R':
								if (name == "NoiseRemovalComponent")
								{
									value = EConfigComponent.NoiseRemovalComponent;
									return true;
								}
								break;
							case 'S':
								if (name == "ResetSelfPosComponent")
								{
									value = EConfigComponent.ResetSelfPosComponent;
									return true;
								}
								break;
							}
						}
						else if (name == "CurveControlComponent")
						{
							value = EConfigComponent.CurveControlComponent;
							return true;
						}
					}
					else
					{
						switch (c)
						{
						case 'a':
							if (name == "InteractGearComponent")
							{
								value = EConfigComponent.InteractGearComponent;
								return true;
							}
							break;
						case 'b':
						case 'd':
						case 'f':
						case 'g':
							break;
						case 'c':
							if (name == "TimeScheduleComponent")
							{
								value = EConfigComponent.TimeScheduleComponent;
								return true;
							}
							break;
						case 'e':
							if (name == "SimpleCombatComponent")
							{
								value = EConfigComponent.SimpleCombatComponent;
								return true;
							}
							break;
						case 'h':
							if (name == "AttachTargetComponent")
							{
								value = EConfigComponent.AttachTargetComponent;
								return true;
							}
							break;
						case 'i':
							if (name == "BehaviorFlowComponent")
							{
								value = EConfigComponent.BehaviorFlowComponent;
								return true;
							}
							break;
						default:
							switch (c)
							{
							case 'n':
								if (name == "PickInteractComponent")
								{
									value = EConfigComponent.PickInteractComponent;
									return true;
								}
								break;
							case 'o':
								if (name == "DungeonEntryComponent")
								{
									value = EConfigComponent.DungeonEntryComponent;
									return true;
								}
								if (name == "BuffConsumerComponent")
								{
									value = EConfigComponent.BuffConsumerComponent;
									return true;
								}
								break;
							case 'p':
							case 'q':
								break;
							case 'r':
								if (name == "ResurrectionComponent")
								{
									value = EConfigComponent.ResurrectionComponent;
									return true;
								}
								if (name == "BuffProducerComponent")
								{
									value = EConfigComponent.BuffProducerComponent;
									return true;
								}
								break;
							case 's':
								if (name == "RefreshGroupComponent")
								{
									value = EConfigComponent.RefreshGroupComponent;
									return true;
								}
								break;
							default:
								if (c == 'y')
								{
									if (name == "ConveyorBeltComponent")
									{
										value = EConfigComponent.ConveyorBeltComponent;
										return true;
									}
									if (name == "EntityBundleComponent")
									{
										value = EConfigComponent.EntityBundleComponent;
										return true;
									}
								}
								break;
							}
							break;
						}
					}
					break;
				}
				case 22:
				{
					char c = name[9];
					if (c <= 'P')
					{
						if (c != 'G')
						{
							if (c != 'I')
							{
								if (c == 'P')
								{
									if (name == "DragActorPlayComponent")
									{
										value = EConfigComponent.DragActorPlayComponent;
										return true;
									}
								}
							}
							else if (name == "RollBlockItemComponent")
							{
								value = EConfigComponent.RollBlockItemComponent;
								return true;
							}
						}
						else if (name == "SunSpiritGearComponent")
						{
							value = EConfigComponent.SunSpiritGearComponent;
							return true;
						}
					}
					else if (c != 'S')
					{
						if (c != 'W')
						{
							switch (c)
							{
							case 'f':
								if (name == "Graph3dEffectComponent")
								{
									value = EConfigComponent.Graph3dEffectComponent;
									return true;
								}
								break;
							case 'g':
								if (name == "ClientTriggerComponent")
								{
									value = EConfigComponent.ClientTriggerComponent;
									return true;
								}
								break;
							case 'i':
								if (name == "EntityVisibleComponent")
								{
									value = EConfigComponent.EntityVisibleComponent;
									return true;
								}
								break;
							case 'k':
								if (name == "EntityPackageComponent")
								{
									value = EConfigComponent.EntityPackageComponent;
									return true;
								}
								break;
							case 'm':
								if (name == "EditCustomAoiComponent")
								{
									value = EConfigComponent.EditCustomAoiComponent;
									return true;
								}
								break;
							case 'n':
								if (name == "RefreshSingleComponent")
								{
									value = EConfigComponent.RefreshSingleComponent;
									return true;
								}
								break;
							case 'o':
								if (name == "FollowShooterComponent")
								{
									value = EConfigComponent.FollowShooterComponent;
									return true;
								}
								break;
							case 'p':
								if (name == "VisionDisplayComponent")
								{
									value = EConfigComponent.VisionDisplayComponent;
									return true;
								}
								break;
							case 'r':
								if (name == "FightInteractComponent")
								{
									value = EConfigComponent.FightInteractComponent;
									return true;
								}
								if (name == "SceneActorRefComponent")
								{
									value = EConfigComponent.SceneActorRefComponent;
									return true;
								}
								break;
							case 't':
								if (name == "RefreshEntityComponent")
								{
									value = EConfigComponent.RefreshEntityComponent;
									return true;
								}
								if (name == "SphereFactoryComponent")
								{
									value = EConfigComponent.SphereFactoryComponent;
									return true;
								}
								if (name == "VisionCaptureComponent")
								{
									value = EConfigComponent.VisionCaptureComponent;
									return true;
								}
								if (name == "AiAlertNotifyComponent")
								{
									value = EConfigComponent.AiAlertNotifyComponent;
									return true;
								}
								break;
							case 'u':
								if (name == "InteractAudioComponent")
								{
									value = EConfigComponent.InteractAudioComponent;
									return true;
								}
								break;
							case 'w':
								if (name == "EntitySpawnerComponent")
								{
									value = EConfigComponent.EntitySpawnerComponent;
									return true;
								}
								break;
							}
						}
						else if (name == "ElementalWellComponent")
						{
							value = EConfigComponent.ElementalWellComponent;
							return true;
						}
					}
					else if (name == "FurnitureSlotComponent")
					{
						value = EConfigComponent.FurnitureSlotComponent;
						return true;
					}
					break;
				}
				case 23:
				{
					char c = name[8];
					if (c <= 'a')
					{
						if (c <= 'P')
						{
							if (c != 'M')
							{
								if (c == 'P')
								{
									if (name == "NoRenderPortalComponent")
									{
										value = EConfigComponent.NoRenderPortalComponent;
										return true;
									}
								}
							}
							else if (name == "LevitateMagnetComponent")
							{
								value = EConfigComponent.LevitateMagnetComponent;
								return true;
							}
						}
						else if (c != 'S')
						{
							if (c == 'a')
							{
								if (name == "NearbyTrackingComponent")
								{
									value = EConfigComponent.NearbyTrackingComponent;
									return true;
								}
								if (name == "WalkingPatternComponent")
								{
									value = EConfigComponent.WalkingPatternComponent;
									return true;
								}
							}
						}
						else if (name == "LocationSafetyComponent")
						{
							value = EConfigComponent.LocationSafetyComponent;
							return true;
						}
					}
					else if (c <= 'g')
					{
						if (c != 'b')
						{
							if (c == 'g')
							{
								if (name == "HackManagementComponent")
								{
									value = EConfigComponent.HackManagementComponent;
									return true;
								}
							}
						}
						else if (name == "PullingObjectFoundation")
						{
							value = EConfigComponent.PullingObjectFoundation;
							return true;
						}
					}
					else if (c != 'k')
					{
						switch (c)
						{
						case 'n':
							if (name == "EnrichmentAreaComponent")
							{
								value = EConfigComponent.EnrichmentAreaComponent;
								return true;
							}
							break;
						case 'p':
							if (name == "AirWallSpawnerComponent")
							{
								value = EConfigComponent.AirWallSpawnerComponent;
								return true;
							}
							break;
						case 'r':
							if (name == "AiGearStrategyComponent")
							{
								value = EConfigComponent.AiGearStrategyComponent;
								return true;
							}
							break;
						}
					}
					else if (name == "RollBlockFloorComponent")
					{
						value = EConfigComponent.RollBlockFloorComponent;
						return true;
					}
					break;
				}
				case 24:
				{
					char c = name[11];
					if (c != 'f')
					{
						if (c != 'h')
						{
							switch (c)
							{
							case 'l':
								if (name == "ElementalHolderComponent")
								{
									value = EConfigComponent.ElementalHolderComponent;
									return true;
								}
								break;
							case 'n':
								if (name == "LifePointCenterComponent")
								{
									value = EConfigComponent.LifePointCenterComponent;
									return true;
								}
								break;
							case 'p':
								if (name == "DynamicTeleportComponent")
								{
									value = EConfigComponent.DynamicTeleportComponent;
									return true;
								}
								break;
							case 'r':
								if (name == "TargetGearGroupComponent")
								{
									value = EConfigComponent.TargetGearGroupComponent;
									return true;
								}
								break;
							case 't':
								if (name == "FlowerPollutionComponent")
								{
									value = EConfigComponent.FlowerPollutionComponent;
									return true;
								}
								break;
							}
						}
						else if (name == "DollGrabMachineComponent")
						{
							value = EConfigComponent.DollGrabMachineComponent;
							return true;
						}
					}
					else if (name == "ElementalEffectComponent")
					{
						value = EConfigComponent.ElementalEffectComponent;
						return true;
					}
					break;
				}
				case 25:
				{
					char c = name[7];
					if (c <= 'i')
					{
						if (c <= 'L')
						{
							if (c != 'G')
							{
								if (c == 'L')
								{
									if (name == "DynamicLevelPlayComponent")
									{
										value = EConfigComponent.DynamicLevelPlayComponent;
										return true;
									}
								}
							}
							else
							{
								if (name == "MonsterGachaItemComponent")
								{
									value = EConfigComponent.MonsterGachaItemComponent;
									return true;
								}
								if (name == "MonsterGachaBaseComponent")
								{
									value = EConfigComponent.MonsterGachaBaseComponent;
									return true;
								}
							}
						}
						else if (c != 'b')
						{
							if (c != 'e')
							{
								if (c == 'i')
								{
									if (name == "SunSpiritCollectComponent")
									{
										value = EConfigComponent.SunSpiritCollectComponent;
										return true;
									}
								}
							}
							else if (name == "FollowDecorationComponent")
							{
								value = EConfigComponent.FollowDecorationComponent;
								return true;
							}
						}
						else if (name == "DollGrabShowcaseComponent")
						{
							value = EConfigComponent.DollGrabShowcaseComponent;
							return true;
						}
					}
					else if (c <= 'n')
					{
						if (c != 'l')
						{
							if (c == 'n')
							{
								if (name == "GuideLineCreatorComponent")
								{
									value = EConfigComponent.GuideLineCreatorComponent;
									return true;
								}
							}
						}
						else if (name == "TurntableControlComponent")
						{
							value = EConfigComponent.TurntableControlComponent;
							return true;
						}
					}
					else if (c != 'r')
					{
						if (c != 't')
						{
							if (c == 'y')
							{
								if (name == "PasserbyNpcSpawnComponent")
								{
									value = EConfigComponent.PasserbyNpcSpawnComponent;
									return true;
								}
							}
						}
						else
						{
							if (name == "ResetEntitiesPosComponent")
							{
								value = EConfigComponent.ResetEntitiesPosComponent;
								return true;
							}
							if (name == "EntityStateAudioComponent")
							{
								value = EConfigComponent.EntityStateAudioComponent;
								return true;
							}
						}
					}
					else if (name == "ProceduralVisualComponent")
					{
						value = EConfigComponent.ProceduralVisualComponent;
						return true;
					}
					break;
				}
				case 26:
				{
					char c = name[3];
					if (c <= 'd')
					{
						if (c != 'S')
						{
							switch (c)
							{
							case 'a':
								if (name == "InhalationAbilityComponent")
								{
									value = EConfigComponent.InhalationAbilityComponent;
									return true;
								}
								break;
							case 'c':
								if (name == "BatchBulletCasterComponent")
								{
									value = EConfigComponent.BatchBulletCasterComponent;
									return true;
								}
								break;
							case 'd':
								if (name == "ConditionListenerComponent")
								{
									value = EConfigComponent.ConditionListenerComponent;
									return true;
								}
								break;
							}
						}
						else if (name == "SunSpiritLauncherComponent")
						{
							value = EConfigComponent.SunSpiritLauncherComponent;
							return true;
						}
					}
					else if (c != 'i')
					{
						if (c != 'n')
						{
							if (c == 's')
							{
								if (name == "PhysicsConstraintComponent")
								{
									value = EConfigComponent.PhysicsConstraintComponent;
									return true;
								}
							}
						}
						else if (name == "SceneItemMovementComponent")
						{
							value = EConfigComponent.SceneItemMovementComponent;
							return true;
						}
					}
					else if (name == "EntityCustomAudioComponent")
					{
						value = EConfigComponent.EntityCustomAudioComponent;
						return true;
					}
					break;
				}
				case 27:
				{
					char c = name[10];
					if (c <= 'h')
					{
						if (c <= 'M')
						{
							if (c != 'I')
							{
								if (c == 'M')
								{
									if (name == "ProceduralMaterialComponent")
									{
										value = EConfigComponent.ProceduralMaterialComponent;
										return true;
									}
								}
							}
							else if (name == "RoleMotionInteractComponent")
							{
								value = EConfigComponent.RoleMotionInteractComponent;
								return true;
							}
						}
						else if (c != 'b')
						{
							if (c == 'h')
							{
								if (name == "EntityBatchRefreshComponent")
								{
									value = EConfigComponent.EntityBatchRefreshComponent;
									return true;
								}
							}
						}
						else if (name == "LevelPrefabPerformComponent")
						{
							value = EConfigComponent.LevelPrefabPerformComponent;
							return true;
						}
					}
					else if (c <= 'o')
					{
						if (c != 'i')
						{
							if (c == 'o')
							{
								if (name == "CharacterConnectorComponent")
								{
									value = EConfigComponent.CharacterConnectorComponent;
									return true;
								}
							}
						}
						else if (name == "SceneItemLifeCycleComponent")
						{
							value = EConfigComponent.SceneItemLifeCycleComponent;
							return true;
						}
					}
					else if (c != 'r')
					{
						if (c == 't')
						{
							if (name == "SceneItemAttributeComponent")
							{
								value = EConfigComponent.SceneItemAttributeComponent;
								return true;
							}
						}
					}
					else if (name == "ProgressBarControlComponent")
					{
						value = EConfigComponent.ProgressBarControlComponent;
						return true;
					}
					break;
				}
				case 28:
				{
					char c = name[7];
					if (c != 'E')
					{
						if (c == 'S')
						{
							if (name == "DynamicSpawnMonsterComponent")
							{
								value = EConfigComponent.DynamicSpawnMonsterComponent;
								return true;
							}
						}
					}
					else if (name == "DynamicEntityRewardComponent")
					{
						value = EConfigComponent.DynamicEntityRewardComponent;
						return true;
					}
					break;
				}
				case 29:
				{
					char c = name[0];
					switch (c)
					{
					case 'C':
						if (name == "CombinedVisibleGroupComponent")
						{
							value = EConfigComponent.CombinedVisibleGroupComponent;
							return true;
						}
						break;
					case 'D':
						if (name == "DynamicPortalCreatorComponent")
						{
							value = EConfigComponent.DynamicPortalCreatorComponent;
							return true;
						}
						break;
					case 'E':
						if (name == "ExploreSkillInteractComponent")
						{
							value = EConfigComponent.ExploreSkillInteractComponent;
							return true;
						}
						break;
					default:
						switch (c)
						{
						case 'R':
							if (name == "RenderSpecifiedRangeComponent")
							{
								value = EConfigComponent.RenderSpecifiedRangeComponent;
								return true;
							}
							break;
						case 'S':
							if (name == "SystemModuleDataSyncComponent")
							{
								value = EConfigComponent.SystemModuleDataSyncComponent;
								return true;
							}
							break;
						case 'T':
							if (name == "TimelineTrackControlComponent")
							{
								value = EConfigComponent.TimelineTrackControlComponent;
								return true;
							}
							break;
						}
						break;
					}
					break;
				}
				case 30:
				{
					char c = name[0];
					if (c != 'R')
					{
						if (c == 'T')
						{
							if (name == "TemplateEntitySpawnerComponent")
							{
								value = EConfigComponent.TemplateEntitySpawnerComponent;
								return true;
							}
						}
					}
					else if (name == "RoadNetworkNavigationComponent")
					{
						value = EConfigComponent.RoadNetworkNavigationComponent;
						return true;
					}
					break;
				}
				case 31:
				{
					char c = name[0];
					if (c != 'E')
					{
						if (c != 'P')
						{
							if (c == 'S')
							{
								if (name == "SceneItemEventListenerComponent")
								{
									value = EConfigComponent.SceneItemEventListenerComponent;
									return true;
								}
							}
						}
						else if (name == "PathDrivenActorSpawnerComponent")
						{
							value = EConfigComponent.PathDrivenActorSpawnerComponent;
							return true;
						}
					}
					else if (name == "ElementalBoxFoundationComponent")
					{
						value = EConfigComponent.ElementalBoxFoundationComponent;
						return true;
					}
					break;
				}
				case 32:
				{
					char c = name[0];
					if (c <= 'G')
					{
						if (c != 'C')
						{
							if (c == 'G')
							{
								if (name == "GameplayDataPersistenceComponent")
								{
									value = EConfigComponent.GameplayDataPersistenceComponent;
									return true;
								}
							}
						}
						else if (name == "ClientConditionListenerComponent")
						{
							value = EConfigComponent.ClientConditionListenerComponent;
							return true;
						}
					}
					else if (c != 'I')
					{
						if (c != 'L')
						{
							if (c == 'P')
							{
								if (name == "PerformanceOptimizationComponent")
								{
									value = EConfigComponent.PerformanceOptimizationComponent;
									return true;
								}
							}
						}
						else if (name == "LevelSequenceFrameEventComponent")
						{
							value = EConfigComponent.LevelSequenceFrameEventComponent;
							return true;
						}
					}
					else if (name == "IndependentSystemRewardComponent")
					{
						value = EConfigComponent.IndependentSystemRewardComponent;
						return true;
					}
					break;
				}
				case 33:
					if (name == "DynamicSpawnMonsterPointComponent")
					{
						value = EConfigComponent.DynamicSpawnMonsterPointComponent;
						return true;
					}
					break;
				case 34:
					if (name == "ExploreSkillInteractGroupComponent")
					{
						value = EConfigComponent.ExploreSkillInteractGroupComponent;
						return true;
					}
					break;
				case 35:
					if (name == "GodKingFrequencyControllerComponent")
					{
						value = EConfigComponent.GodKingFrequencyControllerComponent;
						return true;
					}
					break;
				case 36:
					if (name == "StreamingSourceTriggerPointComponent")
					{
						value = EConfigComponent.StreamingSourceTriggerPointComponent;
						return true;
					}
					break;
				}
			}
			value = EConfigComponent.AirWallSpawnerComponent;
			return false;
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x00088758 File Offset: 0x00086958
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AirWallSpawnerComponent",
				"ActorStateComponent",
				"BehaviorFlowComponent",
				"CalculateComponent",
				"EntitySpawnerComponent",
				"EventComponent",
				"FlowComponent",
				"GrabComponent",
				"InteractiveComponent",
				"LampComponent",
				"MoveComponent",
				"NpcComponent",
				"RefreshEntityComponent",
				"RefreshSingleComponent",
				"RotatorComponent",
				"RotatorComponent2",
				"RoleMotionInteractComponent",
				"SimpleComponent",
				"SphereComponent",
				"SphereFactoryComponent",
				"SpringBoardComponent",
				"SpringComponent",
				"StateComponent",
				"SwitcherComponent",
				"SpawnMonsterComponent",
				"TalkComponent",
				"TrampleUe5Component",
				"TriggerComponent",
				"ClientTriggerComponent",
				"TriggerUe5Component",
				"UndergroundComponent",
				"InteractComponent",
				"VarComponent",
				"AiComponent",
				"LevelAiComponent",
				"AttributeComponent",
				"BaseInfoComponent",
				"RewardComponent",
				"RefreshComponent",
				"RefreshGroupComponent",
				"TreasureBoxComponent",
				"EntityStateComponent",
				"SceneItemAttributeComponent",
				"HookLockPoint",
				"HookFetchComponent",
				"TargetGearComponent",
				"TargetGearGroupComponent",
				"ItemFoundation",
				"ItemFoundation2",
				"PullingObjectFoundation",
				"JigsawItem",
				"JigsawFoundation",
				"CollectComponent",
				"TeleControl2",
				"DestructibleItem",
				"LevelPlayComponent",
				"VisionComponent",
				"VisionCaptureComponent",
				"EntityGroupComponent",
				"ResetEntitiesPosComponent",
				"ResetSelfPosComponent",
				"AdsorbComponent",
				"TeleportComponent",
				"TrampleComponent",
				"NpcPerformComponent",
				"InteractGearComponent",
				"LiftComponent",
				"FollowTrackComponent",
				"SceneItemLifeCycleComponent",
				"BubbleComponent",
				"FightInteractComponent",
				"NearbyTrackingComponent",
				"EntityPackageComponent",
				"SkyboxComponent",
				"StateHintComponent",
				"EntityVisibleComponent",
				"CombinedVisibleGroupComponent",
				"WeaponComponent",
				"DungeonEntryComponent",
				"ResurrectionComponent",
				"BuffProducerComponent",
				"BuffConsumerComponent",
				"GuideLineCreatorComponent",
				"InteractAudioComponent",
				"DropComponent",
				"AdviseItemComponent",
				"VisionItemComponent",
				"MonsterComponent",
				"CombatComponent",
				"EntityListComponent",
				"AnimalComponent",
				"EntityAudioComponent",
				"EntityStateAudioComponent",
				"EntityCustomAudioComponent",
				"SceneItemMovementComponent",
				"RangeComponent",
				"ExtraRangeComponent",
				"TimelineTrackControlComponent",
				"SplineComponent",
				"SceneActorRefComponent",
				"EditCustomAoiComponent",
				"SceneBulletComponent",
				"TurntableControlComponent",
				"ConditionListenerComponent",
				"AttachTargetComponent",
				"ReboundComponent",
				"LevitateMagnetComponent",
				"PhotoTargetComponent",
				"AiAlertNotifyComponent",
				"MonsterGachaItemComponent",
				"MonsterGachaBaseComponent",
				"ProgressBarControlComponent",
				"ConveyorBeltComponent",
				"DynamicTeleportComponent",
				"ExploreSkillInteractComponent",
				"ExploreSkillInteractGroupComponent",
				"FanComponent",
				"PasserbyNpcSpawnComponent",
				"ModelComponent",
				"EntityBundleComponent",
				"BeamCastComponent",
				"BeamReceiveComponent",
				"TimeStopComponent",
				"PortalComponent",
				"NoRenderPortalComponent",
				"EffectAreaComponent",
				"PhysicsConstraintComponent",
				"FollowDecorationComponent",
				"FollowShooterComponent",
				"ConnectorComponent",
				"CharacterConnectorComponent",
				"HitComponent",
				"DynamicPortalCreatorComponent",
				"AiGearStrategyComponent",
				"PickInteractComponent",
				"LocationSafetyComponent",
				"BatchBulletCasterComponent",
				"VehicleComponent",
				"EnrichmentAreaComponent",
				"ChessmanComponent",
				"MonitorComponent",
				"GroupAiComponent",
				"InhalationAbilityComponent",
				"InhaledItemComponent",
				"AirPassageComponent",
				"RenderSpecifiedRangeComponent",
				"LevelPrefabPerformComponent",
				"SceneItemAiComponent",
				"GravityFlipComponent",
				"LevelSequenceFrameEventComponent",
				"LevelQteComponent",
				"WalkingPatternComponent",
				"LifePointCenterComponent",
				"HackManagementComponent",
				"ClientConditionListenerComponent",
				"TemplateEntitySpawnerComponent",
				"WindSourceComponent",
				"SlideRailComponent",
				"CurveControlComponent",
				"EntityBatchRefreshComponent",
				"SimpleCombatComponent",
				"GridObjectComponent",
				"GodKingFrequencyControllerComponent",
				"PerformanceOptimizationComponent",
				"SceneItemEventListenerComponent",
				"DynamicSpawnMonsterPointComponent",
				"DynamicSpawnMonsterComponent",
				"RollBlockComponent",
				"RollBlockFloorComponent",
				"RollBlockItemComponent",
				"SunSpiritCollectComponent",
				"SunSpiritLauncherComponent",
				"SunSpiritGearComponent",
				"MotorSlideComponent",
				"ProceduralVisualComponent",
				"RoadNetworkNavigationComponent",
				"DynamicEntityRewardComponent",
				"FurnitureSlotComponent",
				"VisionDisplayComponent",
				"SystemModuleDataSyncComponent",
				"ExhibitComponent",
				"SlidePerformComponent",
				"TimeScheduleComponent",
				"ProjectorComponent",
				"ProceduralMaterialComponent",
				"GameplayDataPersistenceComponent",
				"FlowerPollutionComponent",
				"QuickHackComponent",
				"DollGrabMachineComponent",
				"DollGrabShowcaseComponent",
				"WuWaGoComponent",
				"DragActorPlayComponent",
				"PathDrivenActorSpawnerComponent",
				"ElementalHolderComponent",
				"ElementalEffectComponent",
				"IndependentSystemRewardComponent",
				"Graph3dComponent",
				"Graph3dEffectComponent",
				"ElementalBoxFoundationComponent",
				"ElementalWellComponent",
				"StreamingSourceTriggerPointComponent",
				"NoiseRemovalComponent",
				"SceneTextComponent",
				"NavMeshComponent",
				"DynamicLevelPlayComponent"
			};
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x00088F82 File Offset: 0x00087182
		public static EConfigComponent[] GetValues()
		{
			return new EConfigComponent[]
			{
				EConfigComponent.AirWallSpawnerComponent,
				EConfigComponent.ActorStateComponent,
				EConfigComponent.BehaviorFlowComponent,
				EConfigComponent.CalculateComponent,
				EConfigComponent.EntitySpawnerComponent,
				EConfigComponent.EventComponent,
				EConfigComponent.FlowComponent,
				EConfigComponent.GrabComponent,
				EConfigComponent.InteractiveComponent,
				EConfigComponent.LampComponent,
				EConfigComponent.MoveComponent,
				EConfigComponent.NpcComponent,
				EConfigComponent.RefreshEntityComponent,
				EConfigComponent.RefreshSingleComponent,
				EConfigComponent.RotatorComponent,
				EConfigComponent.RotatorComponent2,
				EConfigComponent.RoleMotionInteractComponent,
				EConfigComponent.SimpleComponent,
				EConfigComponent.SphereComponent,
				EConfigComponent.SphereFactoryComponent,
				EConfigComponent.SpringBoardComponent,
				EConfigComponent.SpringComponent,
				EConfigComponent.StateComponent,
				EConfigComponent.SwitcherComponent,
				EConfigComponent.SpawnMonsterComponent,
				EConfigComponent.TalkComponent,
				EConfigComponent.TrampleUe5Component,
				EConfigComponent.TriggerComponent,
				EConfigComponent.ClientTriggerComponent,
				EConfigComponent.TriggerUe5Component,
				EConfigComponent.UndergroundComponent,
				EConfigComponent.InteractComponent,
				EConfigComponent.VarComponent,
				EConfigComponent.AiComponent,
				EConfigComponent.LevelAiComponent,
				EConfigComponent.AttributeComponent,
				EConfigComponent.BaseInfoComponent,
				EConfigComponent.RewardComponent,
				EConfigComponent.RefreshComponent,
				EConfigComponent.RefreshGroupComponent,
				EConfigComponent.TreasureBoxComponent,
				EConfigComponent.EntityStateComponent,
				EConfigComponent.SceneItemAttributeComponent,
				EConfigComponent.HookLockPoint,
				EConfigComponent.HookFetchComponent,
				EConfigComponent.TargetGearComponent,
				EConfigComponent.TargetGearGroupComponent,
				EConfigComponent.ItemFoundation,
				EConfigComponent.ItemFoundation2,
				EConfigComponent.PullingObjectFoundation,
				EConfigComponent.JigsawItem,
				EConfigComponent.JigsawFoundation,
				EConfigComponent.CollectComponent,
				EConfigComponent.TeleControl2,
				EConfigComponent.DestructibleItem,
				EConfigComponent.LevelPlayComponent,
				EConfigComponent.VisionComponent,
				EConfigComponent.VisionCaptureComponent,
				EConfigComponent.EntityGroupComponent,
				EConfigComponent.ResetEntitiesPosComponent,
				EConfigComponent.ResetSelfPosComponent,
				EConfigComponent.AdsorbComponent,
				EConfigComponent.TeleportComponent,
				EConfigComponent.TrampleComponent,
				EConfigComponent.NpcPerformComponent,
				EConfigComponent.InteractGearComponent,
				EConfigComponent.LiftComponent,
				EConfigComponent.FollowTrackComponent,
				EConfigComponent.SceneItemLifeCycleComponent,
				EConfigComponent.BubbleComponent,
				EConfigComponent.FightInteractComponent,
				EConfigComponent.NearbyTrackingComponent,
				EConfigComponent.EntityPackageComponent,
				EConfigComponent.SkyboxComponent,
				EConfigComponent.StateHintComponent,
				EConfigComponent.EntityVisibleComponent,
				EConfigComponent.CombinedVisibleGroupComponent,
				EConfigComponent.WeaponComponent,
				EConfigComponent.DungeonEntryComponent,
				EConfigComponent.ResurrectionComponent,
				EConfigComponent.BuffProducerComponent,
				EConfigComponent.BuffConsumerComponent,
				EConfigComponent.GuideLineCreatorComponent,
				EConfigComponent.InteractAudioComponent,
				EConfigComponent.DropComponent,
				EConfigComponent.AdviseItemComponent,
				EConfigComponent.VisionItemComponent,
				EConfigComponent.MonsterComponent,
				EConfigComponent.CombatComponent,
				EConfigComponent.EntityListComponent,
				EConfigComponent.AnimalComponent,
				EConfigComponent.EntityAudioComponent,
				EConfigComponent.EntityStateAudioComponent,
				EConfigComponent.EntityCustomAudioComponent,
				EConfigComponent.SceneItemMovementComponent,
				EConfigComponent.RangeComponent,
				EConfigComponent.ExtraRangeComponent,
				EConfigComponent.TimelineTrackControlComponent,
				EConfigComponent.SplineComponent,
				EConfigComponent.SceneActorRefComponent,
				EConfigComponent.EditCustomAoiComponent,
				EConfigComponent.SceneBulletComponent,
				EConfigComponent.TurntableControlComponent,
				EConfigComponent.ConditionListenerComponent,
				EConfigComponent.AttachTargetComponent,
				EConfigComponent.ReboundComponent,
				EConfigComponent.LevitateMagnetComponent,
				EConfigComponent.PhotoTargetComponent,
				EConfigComponent.AiAlertNotifyComponent,
				EConfigComponent.MonsterGachaItemComponent,
				EConfigComponent.MonsterGachaBaseComponent,
				EConfigComponent.ProgressBarControlComponent,
				EConfigComponent.ConveyorBeltComponent,
				EConfigComponent.DynamicTeleportComponent,
				EConfigComponent.ExploreSkillInteractComponent,
				EConfigComponent.ExploreSkillInteractGroupComponent,
				EConfigComponent.FanComponent,
				EConfigComponent.PasserbyNpcSpawnComponent,
				EConfigComponent.ModelComponent,
				EConfigComponent.EntityBundleComponent,
				EConfigComponent.BeamCastComponent,
				EConfigComponent.BeamReceiveComponent,
				EConfigComponent.TimeStopComponent,
				EConfigComponent.PortalComponent,
				EConfigComponent.NoRenderPortalComponent,
				EConfigComponent.EffectAreaComponent,
				EConfigComponent.PhysicsConstraintComponent,
				EConfigComponent.FollowDecorationComponent,
				EConfigComponent.FollowShooterComponent,
				EConfigComponent.ConnectorComponent,
				EConfigComponent.CharacterConnectorComponent,
				EConfigComponent.HitComponent,
				EConfigComponent.DynamicPortalCreatorComponent,
				EConfigComponent.AiGearStrategyComponent,
				EConfigComponent.PickInteractComponent,
				EConfigComponent.LocationSafetyComponent,
				EConfigComponent.BatchBulletCasterComponent,
				EConfigComponent.VehicleComponent,
				EConfigComponent.EnrichmentAreaComponent,
				EConfigComponent.ChessmanComponent,
				EConfigComponent.MonitorComponent,
				EConfigComponent.GroupAiComponent,
				EConfigComponent.InhalationAbilityComponent,
				EConfigComponent.InhaledItemComponent,
				EConfigComponent.AirPassageComponent,
				EConfigComponent.RenderSpecifiedRangeComponent,
				EConfigComponent.LevelPrefabPerformComponent,
				EConfigComponent.SceneItemAiComponent,
				EConfigComponent.GravityFlipComponent,
				EConfigComponent.LevelSequenceFrameEventComponent,
				EConfigComponent.LevelQteComponent,
				EConfigComponent.WalkingPatternComponent,
				EConfigComponent.LifePointCenterComponent,
				EConfigComponent.HackManagementComponent,
				EConfigComponent.ClientConditionListenerComponent,
				EConfigComponent.TemplateEntitySpawnerComponent,
				EConfigComponent.WindSourceComponent,
				EConfigComponent.SlideRailComponent,
				EConfigComponent.CurveControlComponent,
				EConfigComponent.EntityBatchRefreshComponent,
				EConfigComponent.SimpleCombatComponent,
				EConfigComponent.GridObjectComponent,
				EConfigComponent.GodKingFrequencyControllerComponent,
				EConfigComponent.PerformanceOptimizationComponent,
				EConfigComponent.SceneItemEventListenerComponent,
				EConfigComponent.DynamicSpawnMonsterPointComponent,
				EConfigComponent.DynamicSpawnMonsterComponent,
				EConfigComponent.RollBlockComponent,
				EConfigComponent.RollBlockFloorComponent,
				EConfigComponent.RollBlockItemComponent,
				EConfigComponent.SunSpiritCollectComponent,
				EConfigComponent.SunSpiritLauncherComponent,
				EConfigComponent.SunSpiritGearComponent,
				EConfigComponent.MotorSlideComponent,
				EConfigComponent.ProceduralVisualComponent,
				EConfigComponent.RoadNetworkNavigationComponent,
				EConfigComponent.DynamicEntityRewardComponent,
				EConfigComponent.FurnitureSlotComponent,
				EConfigComponent.VisionDisplayComponent,
				EConfigComponent.SystemModuleDataSyncComponent,
				EConfigComponent.ExhibitComponent,
				EConfigComponent.SlidePerformComponent,
				EConfigComponent.TimeScheduleComponent,
				EConfigComponent.ProjectorComponent,
				EConfigComponent.ProceduralMaterialComponent,
				EConfigComponent.GameplayDataPersistenceComponent,
				EConfigComponent.FlowerPollutionComponent,
				EConfigComponent.QuickHackComponent,
				EConfigComponent.DollGrabMachineComponent,
				EConfigComponent.DollGrabShowcaseComponent,
				EConfigComponent.WuWaGoComponent,
				EConfigComponent.DragActorPlayComponent,
				EConfigComponent.PathDrivenActorSpawnerComponent,
				EConfigComponent.ElementalHolderComponent,
				EConfigComponent.ElementalEffectComponent,
				EConfigComponent.IndependentSystemRewardComponent,
				EConfigComponent.Graph3dComponent,
				EConfigComponent.Graph3dEffectComponent,
				EConfigComponent.ElementalBoxFoundationComponent,
				EConfigComponent.ElementalWellComponent,
				EConfigComponent.StreamingSourceTriggerPointComponent,
				EConfigComponent.NoiseRemovalComponent,
				EConfigComponent.SceneTextComponent,
				EConfigComponent.NavMeshComponent,
				EConfigComponent.DynamicLevelPlayComponent
			};
		}

		// Token: 0x06003475 RID: 13429 RVA: 0x00088F9C File Offset: 0x0008719C
		public static string[] GetNames()
		{
			return new string[]
			{
				"AirWallSpawnerComponent",
				"ActorStateComponent",
				"BehaviorFlowComponent",
				"CalculateComponent",
				"EntitySpawnerComponent",
				"EventComponent",
				"FlowComponent",
				"GrabComponent",
				"InteractiveComponent",
				"LampComponent",
				"MoveComponent",
				"NpcComponent",
				"RefreshEntityComponent",
				"RefreshSingleComponent",
				"RotatorComponent",
				"RotatorComponent2",
				"RoleMotionInteractComponent",
				"SimpleComponent",
				"SphereComponent",
				"SphereFactoryComponent",
				"SpringBoardComponent",
				"SpringComponent",
				"StateComponent",
				"SwitcherComponent",
				"SpawnMonsterComponent",
				"TalkComponent",
				"TrampleUe5Component",
				"TriggerComponent",
				"ClientTriggerComponent",
				"TriggerUe5Component",
				"UndergroundComponent",
				"InteractComponent",
				"VarComponent",
				"AiComponent",
				"LevelAiComponent",
				"AttributeComponent",
				"BaseInfoComponent",
				"RewardComponent",
				"RefreshComponent",
				"RefreshGroupComponent",
				"TreasureBoxComponent",
				"EntityStateComponent",
				"SceneItemAttributeComponent",
				"HookLockPoint",
				"HookFetchComponent",
				"TargetGearComponent",
				"TargetGearGroupComponent",
				"ItemFoundation",
				"ItemFoundation2",
				"PullingObjectFoundation",
				"JigsawItem",
				"JigsawFoundation",
				"CollectComponent",
				"TeleControl2",
				"DestructibleItem",
				"LevelPlayComponent",
				"VisionComponent",
				"VisionCaptureComponent",
				"EntityGroupComponent",
				"ResetEntitiesPosComponent",
				"ResetSelfPosComponent",
				"AdsorbComponent",
				"TeleportComponent",
				"TrampleComponent",
				"NpcPerformComponent",
				"InteractGearComponent",
				"LiftComponent",
				"FollowTrackComponent",
				"SceneItemLifeCycleComponent",
				"BubbleComponent",
				"FightInteractComponent",
				"NearbyTrackingComponent",
				"EntityPackageComponent",
				"SkyboxComponent",
				"StateHintComponent",
				"EntityVisibleComponent",
				"CombinedVisibleGroupComponent",
				"WeaponComponent",
				"DungeonEntryComponent",
				"ResurrectionComponent",
				"BuffProducerComponent",
				"BuffConsumerComponent",
				"GuideLineCreatorComponent",
				"InteractAudioComponent",
				"DropComponent",
				"AdviseItemComponent",
				"VisionItemComponent",
				"MonsterComponent",
				"CombatComponent",
				"EntityListComponent",
				"AnimalComponent",
				"EntityAudioComponent",
				"EntityStateAudioComponent",
				"EntityCustomAudioComponent",
				"SceneItemMovementComponent",
				"RangeComponent",
				"ExtraRangeComponent",
				"TimelineTrackControlComponent",
				"SplineComponent",
				"SceneActorRefComponent",
				"EditCustomAoiComponent",
				"SceneBulletComponent",
				"TurntableControlComponent",
				"ConditionListenerComponent",
				"AttachTargetComponent",
				"ReboundComponent",
				"LevitateMagnetComponent",
				"PhotoTargetComponent",
				"AiAlertNotifyComponent",
				"MonsterGachaItemComponent",
				"MonsterGachaBaseComponent",
				"ProgressBarControlComponent",
				"ConveyorBeltComponent",
				"DynamicTeleportComponent",
				"ExploreSkillInteractComponent",
				"ExploreSkillInteractGroupComponent",
				"FanComponent",
				"PasserbyNpcSpawnComponent",
				"ModelComponent",
				"EntityBundleComponent",
				"BeamCastComponent",
				"BeamReceiveComponent",
				"TimeStopComponent",
				"PortalComponent",
				"NoRenderPortalComponent",
				"EffectAreaComponent",
				"PhysicsConstraintComponent",
				"FollowDecorationComponent",
				"FollowShooterComponent",
				"ConnectorComponent",
				"CharacterConnectorComponent",
				"HitComponent",
				"DynamicPortalCreatorComponent",
				"AiGearStrategyComponent",
				"PickInteractComponent",
				"LocationSafetyComponent",
				"BatchBulletCasterComponent",
				"VehicleComponent",
				"EnrichmentAreaComponent",
				"ChessmanComponent",
				"MonitorComponent",
				"GroupAiComponent",
				"InhalationAbilityComponent",
				"InhaledItemComponent",
				"AirPassageComponent",
				"RenderSpecifiedRangeComponent",
				"LevelPrefabPerformComponent",
				"SceneItemAiComponent",
				"GravityFlipComponent",
				"LevelSequenceFrameEventComponent",
				"LevelQteComponent",
				"WalkingPatternComponent",
				"LifePointCenterComponent",
				"HackManagementComponent",
				"ClientConditionListenerComponent",
				"TemplateEntitySpawnerComponent",
				"WindSourceComponent",
				"SlideRailComponent",
				"CurveControlComponent",
				"EntityBatchRefreshComponent",
				"SimpleCombatComponent",
				"GridObjectComponent",
				"GodKingFrequencyControllerComponent",
				"PerformanceOptimizationComponent",
				"SceneItemEventListenerComponent",
				"DynamicSpawnMonsterPointComponent",
				"DynamicSpawnMonsterComponent",
				"RollBlockComponent",
				"RollBlockFloorComponent",
				"RollBlockItemComponent",
				"SunSpiritCollectComponent",
				"SunSpiritLauncherComponent",
				"SunSpiritGearComponent",
				"MotorSlideComponent",
				"ProceduralVisualComponent",
				"RoadNetworkNavigationComponent",
				"DynamicEntityRewardComponent",
				"FurnitureSlotComponent",
				"VisionDisplayComponent",
				"SystemModuleDataSyncComponent",
				"ExhibitComponent",
				"SlidePerformComponent",
				"TimeScheduleComponent",
				"ProjectorComponent",
				"ProceduralMaterialComponent",
				"GameplayDataPersistenceComponent",
				"FlowerPollutionComponent",
				"QuickHackComponent",
				"DollGrabMachineComponent",
				"DollGrabShowcaseComponent",
				"WuWaGoComponent",
				"DragActorPlayComponent",
				"PathDrivenActorSpawnerComponent",
				"ElementalHolderComponent",
				"ElementalEffectComponent",
				"IndependentSystemRewardComponent",
				"Graph3dComponent",
				"Graph3dEffectComponent",
				"ElementalBoxFoundationComponent",
				"ElementalWellComponent",
				"StreamingSourceTriggerPointComponent",
				"NoiseRemovalComponent",
				"SceneTextComponent",
				"NavMeshComponent",
				"DynamicLevelPlayComponent"
			};
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark.Component;
using CSharpScript.Game.Module.Map.Marks;
using CSharpScript.Game.Module.WorldMap.ViewComponent;

namespace CSharpScript.Game.Module.Map.Mark
{
	// Token: 0x020054C2 RID: 21698
	[NullableContext(1)]
	[Nullable(0)]
	public static class MarkFactory
	{
		// Token: 0x06037671 RID: 226929 RVA: 0x00D27CD3 File Offset: 0x00D25ED3
		public static MarkItemEntity CreateAndAssembleMark(ICreateMarkParam param)
		{
			MarkItemEntity markItemEntity = MarkFactory.CreateDefaultEntity(param);
			MarkFactory.AssembleMarkComponents(markItemEntity, param);
			return markItemEntity;
		}

		// Token: 0x06037672 RID: 226930 RVA: 0x00D27CE4 File Offset: 0x00D25EE4
		private static void AssembleMarkComponents(MarkItemEntity markItemEntity, ICreateMarkParam param)
		{
			EMapComponent[] array;
			if (MarkFactory.MarkAssembleRegisterMap.TryGetValue(param.MarkType, out array))
			{
				foreach (EMapComponent emapComponent in array)
				{
					switch (emapComponent)
					{
					case EMapComponent.WorldMapSecondaryUi:
						markItemEntity.AddComponent<WorldMapSecondaryUiComponent>(emapComponent);
						break;
					case EMapComponent.WorldMapInteract:
						markItemEntity.AddComponent<WorldMapInteractComponent>(emapComponent);
						break;
					case EMapComponent.WorldMapMove:
						markItemEntity.AddComponent<WorldMapMoveComponent>(emapComponent);
						break;
					case EMapComponent.WorldMapScale:
						markItemEntity.AddComponent<WorldMapScaleComponent>(emapComponent);
						break;
					case EMapComponent.WorldMapPlayer:
						markItemEntity.AddComponent<WorldMapPlayerComponent>(emapComponent);
						break;
					case EMapComponent.WorldMapMultiFloor:
						markItemEntity.AddComponent<WorldMapMultiFloorComponent>(emapComponent);
						break;
					case EMapComponent.WorldMapQuickNavigate:
						markItemEntity.AddComponent<WorldMapQuickNavigateComponent>(emapComponent);
						break;
					case EMapComponent.WorldMapStreaming:
						markItemEntity.AddComponent<WorldMapStreamingComponent>(emapComponent);
						break;
					case EMapComponent.WorldMapAlterMap:
						markItemEntity.AddComponent<WorldMapAlterMapComponent>(emapComponent);
						break;
					case EMapComponent.MarkGamePlay:
						markItemEntity.AddComponent<MarkGamePlayComponent>(emapComponent);
						break;
					case EMapComponent.MarkResource:
						markItemEntity.AddComponent<MarkResourceComponent>(emapComponent);
						break;
					case EMapComponent.MarkViewLifeCircle:
						markItemEntity.AddComponent<MarkViewLifeCircleComponent>(emapComponent);
						break;
					case EMapComponent.MarkGamePlayState:
						markItemEntity.AddComponent<MarkGamePlayStateComponent>(emapComponent);
						break;
					case EMapComponent.MarkCommonGamePlayState:
						markItemEntity.AddComponent<MarkCommonGamePlayStateComponent>(emapComponent);
						break;
					case EMapComponent.MarkConfig:
						markItemEntity.AddComponent<MarkConfigComponent>(emapComponent);
						break;
					case EMapComponent.MarkFishingPoint:
						markItemEntity.AddComponent<MarkFishingPointComponent>(emapComponent);
						break;
					case EMapComponent.MarkMultiFloor:
						markItemEntity.AddComponent<MarkMultiFloorComponent>(emapComponent);
						break;
					case EMapComponent.MarkEntity:
						markItemEntity.AddComponent<MarkEntityComponent>(emapComponent);
						break;
					case EMapComponent.WorldMapExtraUiPanel:
						markItemEntity.AddComponent<WorldMapExtraUiPanelComponent>(emapComponent);
						break;
					default:
						throw new ArgumentOutOfRangeException("assembleComponent", emapComponent, "未知的EMapComponent类型");
					}
				}
			}
		}

		// Token: 0x06037673 RID: 226931 RVA: 0x00D27E67 File Offset: 0x00D26067
		public static MarkItemEntity CreateAndAssembleConfigMark(ICreateMarkParam param)
		{
			MarkItemEntity markItemEntity = MarkFactory.CreateConfigMark(param);
			MarkFactory.AssembleMarkComponents(markItemEntity, param);
			return markItemEntity;
		}

		// Token: 0x06037674 RID: 226932 RVA: 0x00D27E76 File Offset: 0x00D26076
		public static MarkItemEntity CreateAndAssembleServerMark(ICreateMarkParam param)
		{
			MarkItemEntity markItemEntity = MarkFactory.CreateServerMark(param);
			MarkFactory.AssembleMarkComponents(markItemEntity, param);
			return markItemEntity;
		}

		// Token: 0x06037675 RID: 226933 RVA: 0x00D27E85 File Offset: 0x00D26085
		public static MarkItemEntity CreateAndAssembleDynamicConfigMark(ICreateMarkParam param)
		{
			MarkItemEntity markItemEntity = MarkFactory.CreateDynamicConfigMark(param);
			MarkFactory.AssembleMarkComponents(markItemEntity, param);
			return markItemEntity;
		}

		// Token: 0x06037676 RID: 226934 RVA: 0x00D27E94 File Offset: 0x00D26094
		private static MarkItemEntity CreateDefaultEntity(ICreateMarkParam param)
		{
			return new MarkItemEntity
			{
				GamePlay = 
				{
					MarkId = param.MarkId,
					MarkType = param.MarkType,
					Gravity = param.Gravity,
					MapId = param.MapId
				}
			};
		}

		// Token: 0x06037677 RID: 226935 RVA: 0x00D27EEA File Offset: 0x00D260EA
		private static MarkItemEntity CreateConfigMark(ICreateMarkParam param)
		{
			MarkItemEntity markItemEntity = MarkFactory.CreateDefaultEntity(param);
			markItemEntity.AddComponent<MarkConfigComponent>(EMapComponent.MarkConfig).Config = param.Config;
			markItemEntity.AddComponent<MarkEntityComponent>(EMapComponent.MarkEntity).EntityId = new int?(param.EntityId);
			return markItemEntity;
		}

		// Token: 0x06037678 RID: 226936 RVA: 0x00D27F22 File Offset: 0x00D26122
		private static MarkItemEntity CreateServerMark(ICreateMarkParam param)
		{
			MarkItemEntity markItemEntity = MarkFactory.CreateDefaultEntity(param);
			markItemEntity.AddComponent<MarkEntityComponent>(EMapComponent.MarkEntity).EntityId = new int?(param.EntityId);
			return markItemEntity;
		}

		// Token: 0x06037679 RID: 226937 RVA: 0x00D27F42 File Offset: 0x00D26142
		private static MarkItemEntity CreateDynamicConfigMark(ICreateMarkParam param)
		{
			MarkItemEntity markItemEntity = MarkFactory.CreateDefaultEntity(param);
			markItemEntity.AddComponent<MarkConfigComponent>(EMapComponent.MarkConfig).Config = param.DynamicConfig;
			return markItemEntity;
		}

		// Token: 0x0603767A RID: 226938 RVA: 0x00D27F64 File Offset: 0x00D26164
		// Note: this type is marked as 'beforefieldinit'.
		static MarkFactory()
		{
			Dictionary<EMarkType, EMapComponent[]> dictionary = new Dictionary<EMarkType, EMapComponent[]>();
			dictionary[EMarkType.CommonGamePlay] = new EMapComponent[]
			{
				EMapComponent.MarkCommonGamePlayState
			};
			dictionary[EMarkType.LevelPlayReport] = new EMapComponent[]
			{
				EMapComponent.MarkCommonGamePlayState
			};
			dictionary[EMarkType.SceneGameplay] = new EMapComponent[]
			{
				EMapComponent.MarkGamePlayState
			};
			dictionary[EMarkType.FishingPoint] = new EMapComponent[]
			{
				EMapComponent.MarkFishingPoint,
				EMapComponent.MarkConfig
			};
			dictionary[EMarkType.FishingShip] = new EMapComponent[]
			{
				EMapComponent.MarkConfig
			};
			dictionary[EMarkType.Entity] = new EMapComponent[]
			{
				EMapComponent.MarkCommonGamePlayState
			};
			dictionary[EMarkType.SightSpot] = new EMapComponent[]
			{
				EMapComponent.MarkConfig
			};
			dictionary[EMarkType.FlyingHunter] = new EMapComponent[]
			{
				EMapComponent.MarkConfig
			};
			dictionary[EMarkType.Frostbite] = new EMapComponent[]
			{
				EMapComponent.MarkConfig
			};
			dictionary[EMarkType.GreatSwordChallenge] = new EMapComponent[]
			{
				EMapComponent.MarkCommonGamePlayState
			};
			MarkFactory.MarkAssembleRegisterMap = dictionary;
		}

		// Token: 0x0401D344 RID: 119620
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<EMarkType, EMapComponent[]> MarkAssembleRegisterMap;
	}
}

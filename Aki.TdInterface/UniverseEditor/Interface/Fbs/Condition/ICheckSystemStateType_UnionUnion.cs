using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B48 RID: 19272
	public class ICheckSystemStateType_UnionUnion
	{
		// Token: 0x17008BCE RID: 35790
		// (get) Token: 0x0601E55D RID: 124253 RVA: 0x0044016D File Offset: 0x0043E36D
		// (set) Token: 0x0601E55E RID: 124254 RVA: 0x00440175 File Offset: 0x0043E375
		public ICheckSystemStateType_Union Type { get; set; }

		// Token: 0x17008BCF RID: 35791
		// (get) Token: 0x0601E55F RID: 124255 RVA: 0x0044017E File Offset: 0x0043E37E
		// (set) Token: 0x0601E560 RID: 124256 RVA: 0x00440186 File Offset: 0x0043E386
		public object Value { get; set; }

		// Token: 0x0601E561 RID: 124257 RVA: 0x0044018F File Offset: 0x0043E38F
		public ICheckSystemStateType_UnionUnion()
		{
			this.Type = ICheckSystemStateType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601E562 RID: 124258 RVA: 0x004401A5 File Offset: 0x0043E3A5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601E563 RID: 124259 RVA: 0x004401B7 File Offset: 0x0043E3B7
		public ICheckSystemStateTypeT AsICheckSystemStateType()
		{
			return this.As<ICheckSystemStateTypeT>();
		}

		// Token: 0x0601E564 RID: 124260 RVA: 0x004401BF File Offset: 0x0043E3BF
		public static ICheckSystemStateType_UnionUnion FromICheckSystemStateType(ICheckSystemStateTypeT _ichecksystemstatetype)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckSystemStateType,
				Value = _ichecksystemstatetype
			};
		}

		// Token: 0x0601E565 RID: 124261 RVA: 0x004401D4 File Offset: 0x0043E3D4
		public ICheckMoonBuildingStateT AsICheckMoonBuildingState()
		{
			return this.As<ICheckMoonBuildingStateT>();
		}

		// Token: 0x0601E566 RID: 124262 RVA: 0x004401DC File Offset: 0x0043E3DC
		public static ICheckSystemStateType_UnionUnion FromICheckMoonBuildingState(ICheckMoonBuildingStateT _icheckmoonbuildingstate)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckMoonBuildingState,
				Value = _icheckmoonbuildingstate
			};
		}

		// Token: 0x0601E567 RID: 124263 RVA: 0x004401F1 File Offset: 0x0043E3F1
		public ICheckCollectionShopStateT AsICheckCollectionShopState()
		{
			return this.As<ICheckCollectionShopStateT>();
		}

		// Token: 0x0601E568 RID: 124264 RVA: 0x004401F9 File Offset: 0x0043E3F9
		public static ICheckSystemStateType_UnionUnion FromICheckCollectionShopState(ICheckCollectionShopStateT _icheckcollectionshopstate)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckCollectionShopState,
				Value = _icheckcollectionshopstate
			};
		}

		// Token: 0x0601E569 RID: 124265 RVA: 0x0044020E File Offset: 0x0043E40E
		public ICheckTrackMoonPopularityT AsICheckTrackMoonPopularity()
		{
			return this.As<ICheckTrackMoonPopularityT>();
		}

		// Token: 0x0601E56A RID: 124266 RVA: 0x00440216 File Offset: 0x0043E416
		public static ICheckSystemStateType_UnionUnion FromICheckTrackMoonPopularity(ICheckTrackMoonPopularityT _ichecktrackmoonpopularity)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckTrackMoonPopularity,
				Value = _ichecktrackmoonpopularity
			};
		}

		// Token: 0x0601E56B RID: 124267 RVA: 0x0044022B File Offset: 0x0043E42B
		public ICheckInfrastructureStageT AsICheckInfrastructureStage()
		{
			return this.As<ICheckInfrastructureStageT>();
		}

		// Token: 0x0601E56C RID: 124268 RVA: 0x00440233 File Offset: 0x0043E433
		public static ICheckSystemStateType_UnionUnion FromICheckInfrastructureStage(ICheckInfrastructureStageT _icheckinfrastructurestage)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckInfrastructureStage,
				Value = _icheckinfrastructurestage
			};
		}

		// Token: 0x0601E56D RID: 124269 RVA: 0x00440248 File Offset: 0x0043E448
		public ICheckRoadBuildStateT AsICheckRoadBuildState()
		{
			return this.As<ICheckRoadBuildStateT>();
		}

		// Token: 0x0601E56E RID: 124270 RVA: 0x00440250 File Offset: 0x0043E450
		public static ICheckSystemStateType_UnionUnion FromICheckRoadBuildState(ICheckRoadBuildStateT _icheckroadbuildstate)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckRoadBuildState,
				Value = _icheckroadbuildstate
			};
		}

		// Token: 0x0601E56F RID: 124271 RVA: 0x00440265 File Offset: 0x0043E465
		public ICheckInfrActivityExpT AsICheckInfrActivityExp()
		{
			return this.As<ICheckInfrActivityExpT>();
		}

		// Token: 0x0601E570 RID: 124272 RVA: 0x0044026D File Offset: 0x0043E46D
		public static ICheckSystemStateType_UnionUnion FromICheckInfrActivityExp(ICheckInfrActivityExpT _icheckinfractivityexp)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckInfrActivityExp,
				Value = _icheckinfractivityexp
			};
		}

		// Token: 0x0601E571 RID: 124273 RVA: 0x00440282 File Offset: 0x0043E482
		public ICheckVillageInfrLevelT AsICheckVillageInfrLevel()
		{
			return this.As<ICheckVillageInfrLevelT>();
		}

		// Token: 0x0601E572 RID: 124274 RVA: 0x0044028A File Offset: 0x0043E48A
		public static ICheckSystemStateType_UnionUnion FromICheckVillageInfrLevel(ICheckVillageInfrLevelT _icheckvillageinfrlevel)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckVillageInfrLevel,
				Value = _icheckvillageinfrlevel
			};
		}

		// Token: 0x0601E573 RID: 124275 RVA: 0x0044029F File Offset: 0x0043E49F
		public ICheckEncircleLevelCompleteT AsICheckEncircleLevelComplete()
		{
			return this.As<ICheckEncircleLevelCompleteT>();
		}

		// Token: 0x0601E574 RID: 124276 RVA: 0x004402A7 File Offset: 0x0043E4A7
		public static ICheckSystemStateType_UnionUnion FromICheckEncircleLevelComplete(ICheckEncircleLevelCompleteT _icheckencirclelevelcomplete)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckEncircleLevelComplete,
				Value = _icheckencirclelevelcomplete
			};
		}

		// Token: 0x0601E575 RID: 124277 RVA: 0x004402BD File Offset: 0x0043E4BD
		public ICheckSpringFestivalAtmosphereLevelT AsICheckSpringFestivalAtmosphereLevel()
		{
			return this.As<ICheckSpringFestivalAtmosphereLevelT>();
		}

		// Token: 0x0601E576 RID: 124278 RVA: 0x004402C5 File Offset: 0x0043E4C5
		public static ICheckSystemStateType_UnionUnion FromICheckSpringFestivalAtmosphereLevel(ICheckSpringFestivalAtmosphereLevelT _icheckspringfestivalatmospherelevel)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckSpringFestivalAtmosphereLevel,
				Value = _icheckspringfestivalatmospherelevel
			};
		}

		// Token: 0x0601E577 RID: 124279 RVA: 0x004402DB File Offset: 0x0043E4DB
		public ICheckSpringFestivalGuessJokerFirstCompleteT AsICheckSpringFestivalGuessJokerFirstComplete()
		{
			return this.As<ICheckSpringFestivalGuessJokerFirstCompleteT>();
		}

		// Token: 0x0601E578 RID: 124280 RVA: 0x004402E3 File Offset: 0x0043E4E3
		public static ICheckSystemStateType_UnionUnion FromICheckSpringFestivalGuessJokerFirstComplete(ICheckSpringFestivalGuessJokerFirstCompleteT _icheckspringfestivalguessjokerfirstcomplete)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckSpringFestivalGuessJokerFirstComplete,
				Value = _icheckspringfestivalguessjokerfirstcomplete
			};
		}

		// Token: 0x0601E579 RID: 124281 RVA: 0x004402F9 File Offset: 0x0043E4F9
		public ICheckCoopRoleCoopLevelT AsICheckCoopRoleCoopLevel()
		{
			return this.As<ICheckCoopRoleCoopLevelT>();
		}

		// Token: 0x0601E57A RID: 124282 RVA: 0x00440301 File Offset: 0x0043E501
		public static ICheckSystemStateType_UnionUnion FromICheckCoopRoleCoopLevel(ICheckCoopRoleCoopLevelT _icheckcooprolecooplevel)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckCoopRoleCoopLevel,
				Value = _icheckcooprolecooplevel
			};
		}

		// Token: 0x0601E57B RID: 124283 RVA: 0x00440317 File Offset: 0x0043E517
		public ICheckSunSpiritDeliveryLevelT AsICheckSunSpiritDeliveryLevel()
		{
			return this.As<ICheckSunSpiritDeliveryLevelT>();
		}

		// Token: 0x0601E57C RID: 124284 RVA: 0x0044031F File Offset: 0x0043E51F
		public static ICheckSystemStateType_UnionUnion FromICheckSunSpiritDeliveryLevel(ICheckSunSpiritDeliveryLevelT _ichecksunspiritdeliverylevel)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckSunSpiritDeliveryLevel,
				Value = _ichecksunspiritdeliverylevel
			};
		}

		// Token: 0x0601E57D RID: 124285 RVA: 0x00440335 File Offset: 0x0043E535
		public ICheckRhythmSpaceshipReachLevelRankT AsICheckRhythmSpaceshipReachLevelRank()
		{
			return this.As<ICheckRhythmSpaceshipReachLevelRankT>();
		}

		// Token: 0x0601E57E RID: 124286 RVA: 0x0044033D File Offset: 0x0043E53D
		public static ICheckSystemStateType_UnionUnion FromICheckRhythmSpaceshipReachLevelRank(ICheckRhythmSpaceshipReachLevelRankT _icheckrhythmspaceshipreachlevelrank)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckRhythmSpaceshipReachLevelRank,
				Value = _icheckrhythmspaceshipreachlevelrank
			};
		}

		// Token: 0x0601E57F RID: 124287 RVA: 0x00440353 File Offset: 0x0043E553
		public ICheckDropCatchGameplayCompleteLevelT AsICheckDropCatchGameplayCompleteLevel()
		{
			return this.As<ICheckDropCatchGameplayCompleteLevelT>();
		}

		// Token: 0x0601E580 RID: 124288 RVA: 0x0044035B File Offset: 0x0043E55B
		public static ICheckSystemStateType_UnionUnion FromICheckDropCatchGameplayCompleteLevel(ICheckDropCatchGameplayCompleteLevelT _icheckdropcatchgameplaycompletelevel)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckDropCatchGameplayCompleteLevel,
				Value = _icheckdropcatchgameplaycompletelevel
			};
		}

		// Token: 0x0601E581 RID: 124289 RVA: 0x00440371 File Offset: 0x0043E571
		public ICheckDangoBrawlChallengeCompleteT AsICheckDangoBrawlChallengeComplete()
		{
			return this.As<ICheckDangoBrawlChallengeCompleteT>();
		}

		// Token: 0x0601E582 RID: 124290 RVA: 0x00440379 File Offset: 0x0043E579
		public static ICheckSystemStateType_UnionUnion FromICheckDangoBrawlChallengeComplete(ICheckDangoBrawlChallengeCompleteT _icheckdangobrawlchallengecomplete)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckDangoBrawlChallengeComplete,
				Value = _icheckdangobrawlchallengecomplete
			};
		}

		// Token: 0x0601E583 RID: 124291 RVA: 0x0044038F File Offset: 0x0043E58F
		public ICheckRogueStateT AsICheckRogueState()
		{
			return this.As<ICheckRogueStateT>();
		}

		// Token: 0x0601E584 RID: 124292 RVA: 0x00440397 File Offset: 0x0043E597
		public static ICheckSystemStateType_UnionUnion FromICheckRogueState(ICheckRogueStateT _icheckroguestate)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckRogueState,
				Value = _icheckroguestate
			};
		}

		// Token: 0x0601E585 RID: 124293 RVA: 0x004403AD File Offset: 0x0043E5AD
		public ICheckVillageInfrTreeBuildStateT AsICheckVillageInfrTreeBuildState()
		{
			return this.As<ICheckVillageInfrTreeBuildStateT>();
		}

		// Token: 0x0601E586 RID: 124294 RVA: 0x004403B5 File Offset: 0x0043E5B5
		public static ICheckSystemStateType_UnionUnion FromICheckVillageInfrTreeBuildState(ICheckVillageInfrTreeBuildStateT _icheckvillageinfrtreebuildstate)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckVillageInfrTreeBuildState,
				Value = _icheckvillageinfrtreebuildstate
			};
		}

		// Token: 0x0601E587 RID: 124295 RVA: 0x004403CC File Offset: 0x0043E5CC
		public static int Pack(FlatBufferBuilder builder, ICheckSystemStateType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICheckSystemStateType_Union.ICheckSystemStateType:
				return ICheckSystemStateType.Pack(builder, _o.AsICheckSystemStateType()).Value;
			case ICheckSystemStateType_Union.ICheckMoonBuildingState:
				return ICheckMoonBuildingState.Pack(builder, _o.AsICheckMoonBuildingState()).Value;
			case ICheckSystemStateType_Union.ICheckCollectionShopState:
				return ICheckCollectionShopState.Pack(builder, _o.AsICheckCollectionShopState()).Value;
			case ICheckSystemStateType_Union.ICheckTrackMoonPopularity:
				return ICheckTrackMoonPopularity.Pack(builder, _o.AsICheckTrackMoonPopularity()).Value;
			case ICheckSystemStateType_Union.ICheckInfrastructureStage:
				return ICheckInfrastructureStage.Pack(builder, _o.AsICheckInfrastructureStage()).Value;
			case ICheckSystemStateType_Union.ICheckRoadBuildState:
				return ICheckRoadBuildState.Pack(builder, _o.AsICheckRoadBuildState()).Value;
			case ICheckSystemStateType_Union.ICheckInfrActivityExp:
				return ICheckInfrActivityExp.Pack(builder, _o.AsICheckInfrActivityExp()).Value;
			case ICheckSystemStateType_Union.ICheckVillageInfrLevel:
				return ICheckVillageInfrLevel.Pack(builder, _o.AsICheckVillageInfrLevel()).Value;
			case ICheckSystemStateType_Union.ICheckEncircleLevelComplete:
				return ICheckEncircleLevelComplete.Pack(builder, _o.AsICheckEncircleLevelComplete()).Value;
			case ICheckSystemStateType_Union.ICheckSpringFestivalAtmosphereLevel:
				return ICheckSpringFestivalAtmosphereLevel.Pack(builder, _o.AsICheckSpringFestivalAtmosphereLevel()).Value;
			case ICheckSystemStateType_Union.ICheckSpringFestivalGuessJokerFirstComplete:
				return ICheckSpringFestivalGuessJokerFirstComplete.Pack(builder, _o.AsICheckSpringFestivalGuessJokerFirstComplete()).Value;
			case ICheckSystemStateType_Union.ICheckCoopRoleCoopLevel:
				return ICheckCoopRoleCoopLevel.Pack(builder, _o.AsICheckCoopRoleCoopLevel()).Value;
			case ICheckSystemStateType_Union.ICheckSunSpiritDeliveryLevel:
				return ICheckSunSpiritDeliveryLevel.Pack(builder, _o.AsICheckSunSpiritDeliveryLevel()).Value;
			case ICheckSystemStateType_Union.ICheckRhythmSpaceshipReachLevelRank:
				return ICheckRhythmSpaceshipReachLevelRank.Pack(builder, _o.AsICheckRhythmSpaceshipReachLevelRank()).Value;
			case ICheckSystemStateType_Union.ICheckDropCatchGameplayCompleteLevel:
				return ICheckDropCatchGameplayCompleteLevel.Pack(builder, _o.AsICheckDropCatchGameplayCompleteLevel()).Value;
			case ICheckSystemStateType_Union.ICheckDangoBrawlChallengeComplete:
				return ICheckDangoBrawlChallengeComplete.Pack(builder, _o.AsICheckDangoBrawlChallengeComplete()).Value;
			case ICheckSystemStateType_Union.ICheckRogueState:
				return ICheckRogueState.Pack(builder, _o.AsICheckRogueState()).Value;
			case ICheckSystemStateType_Union.ICheckVillageInfrTreeBuildState:
				return ICheckVillageInfrTreeBuildState.Pack(builder, _o.AsICheckVillageInfrTreeBuildState()).Value;
			default:
				return 0;
			}
		}
	}
}

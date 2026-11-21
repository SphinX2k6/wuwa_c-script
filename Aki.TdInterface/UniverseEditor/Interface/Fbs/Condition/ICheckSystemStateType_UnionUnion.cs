using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200502F RID: 20527
	public class ICheckSystemStateType_UnionUnion
	{
		// Token: 0x170092DE RID: 37598
		// (get) Token: 0x060200E9 RID: 131305 RVA: 0x00472971 File Offset: 0x00470B71
		// (set) Token: 0x060200EA RID: 131306 RVA: 0x00472979 File Offset: 0x00470B79
		public ICheckSystemStateType_Union Type { get; set; }

		// Token: 0x170092DF RID: 37599
		// (get) Token: 0x060200EB RID: 131307 RVA: 0x00472982 File Offset: 0x00470B82
		// (set) Token: 0x060200EC RID: 131308 RVA: 0x0047298A File Offset: 0x00470B8A
		public object Value { get; set; }

		// Token: 0x060200ED RID: 131309 RVA: 0x00472993 File Offset: 0x00470B93
		public ICheckSystemStateType_UnionUnion()
		{
			this.Type = ICheckSystemStateType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060200EE RID: 131310 RVA: 0x004729A9 File Offset: 0x00470BA9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060200EF RID: 131311 RVA: 0x004729BB File Offset: 0x00470BBB
		public ICheckSystemStateTypeT AsICheckSystemStateType()
		{
			return this.As<ICheckSystemStateTypeT>();
		}

		// Token: 0x060200F0 RID: 131312 RVA: 0x004729C3 File Offset: 0x00470BC3
		public static ICheckSystemStateType_UnionUnion FromICheckSystemStateType(ICheckSystemStateTypeT _ichecksystemstatetype)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckSystemStateType,
				Value = _ichecksystemstatetype
			};
		}

		// Token: 0x060200F1 RID: 131313 RVA: 0x004729D8 File Offset: 0x00470BD8
		public ICheckMoonBuildingStateT AsICheckMoonBuildingState()
		{
			return this.As<ICheckMoonBuildingStateT>();
		}

		// Token: 0x060200F2 RID: 131314 RVA: 0x004729E0 File Offset: 0x00470BE0
		public static ICheckSystemStateType_UnionUnion FromICheckMoonBuildingState(ICheckMoonBuildingStateT _icheckmoonbuildingstate)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckMoonBuildingState,
				Value = _icheckmoonbuildingstate
			};
		}

		// Token: 0x060200F3 RID: 131315 RVA: 0x004729F5 File Offset: 0x00470BF5
		public ICheckCollectionShopStateT AsICheckCollectionShopState()
		{
			return this.As<ICheckCollectionShopStateT>();
		}

		// Token: 0x060200F4 RID: 131316 RVA: 0x004729FD File Offset: 0x00470BFD
		public static ICheckSystemStateType_UnionUnion FromICheckCollectionShopState(ICheckCollectionShopStateT _icheckcollectionshopstate)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckCollectionShopState,
				Value = _icheckcollectionshopstate
			};
		}

		// Token: 0x060200F5 RID: 131317 RVA: 0x00472A12 File Offset: 0x00470C12
		public ICheckTrackMoonPopularityT AsICheckTrackMoonPopularity()
		{
			return this.As<ICheckTrackMoonPopularityT>();
		}

		// Token: 0x060200F6 RID: 131318 RVA: 0x00472A1A File Offset: 0x00470C1A
		public static ICheckSystemStateType_UnionUnion FromICheckTrackMoonPopularity(ICheckTrackMoonPopularityT _ichecktrackmoonpopularity)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckTrackMoonPopularity,
				Value = _ichecktrackmoonpopularity
			};
		}

		// Token: 0x060200F7 RID: 131319 RVA: 0x00472A2F File Offset: 0x00470C2F
		public ICheckInfrastructureStageT AsICheckInfrastructureStage()
		{
			return this.As<ICheckInfrastructureStageT>();
		}

		// Token: 0x060200F8 RID: 131320 RVA: 0x00472A37 File Offset: 0x00470C37
		public static ICheckSystemStateType_UnionUnion FromICheckInfrastructureStage(ICheckInfrastructureStageT _icheckinfrastructurestage)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckInfrastructureStage,
				Value = _icheckinfrastructurestage
			};
		}

		// Token: 0x060200F9 RID: 131321 RVA: 0x00472A4C File Offset: 0x00470C4C
		public ICheckRoadBuildStateT AsICheckRoadBuildState()
		{
			return this.As<ICheckRoadBuildStateT>();
		}

		// Token: 0x060200FA RID: 131322 RVA: 0x00472A54 File Offset: 0x00470C54
		public static ICheckSystemStateType_UnionUnion FromICheckRoadBuildState(ICheckRoadBuildStateT _icheckroadbuildstate)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckRoadBuildState,
				Value = _icheckroadbuildstate
			};
		}

		// Token: 0x060200FB RID: 131323 RVA: 0x00472A69 File Offset: 0x00470C69
		public ICheckInfrActivityExpT AsICheckInfrActivityExp()
		{
			return this.As<ICheckInfrActivityExpT>();
		}

		// Token: 0x060200FC RID: 131324 RVA: 0x00472A71 File Offset: 0x00470C71
		public static ICheckSystemStateType_UnionUnion FromICheckInfrActivityExp(ICheckInfrActivityExpT _icheckinfractivityexp)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckInfrActivityExp,
				Value = _icheckinfractivityexp
			};
		}

		// Token: 0x060200FD RID: 131325 RVA: 0x00472A86 File Offset: 0x00470C86
		public ICheckVillageInfrLevelT AsICheckVillageInfrLevel()
		{
			return this.As<ICheckVillageInfrLevelT>();
		}

		// Token: 0x060200FE RID: 131326 RVA: 0x00472A8E File Offset: 0x00470C8E
		public static ICheckSystemStateType_UnionUnion FromICheckVillageInfrLevel(ICheckVillageInfrLevelT _icheckvillageinfrlevel)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckVillageInfrLevel,
				Value = _icheckvillageinfrlevel
			};
		}

		// Token: 0x060200FF RID: 131327 RVA: 0x00472AA3 File Offset: 0x00470CA3
		public ICheckEncircleLevelCompleteT AsICheckEncircleLevelComplete()
		{
			return this.As<ICheckEncircleLevelCompleteT>();
		}

		// Token: 0x06020100 RID: 131328 RVA: 0x00472AAB File Offset: 0x00470CAB
		public static ICheckSystemStateType_UnionUnion FromICheckEncircleLevelComplete(ICheckEncircleLevelCompleteT _icheckencirclelevelcomplete)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckEncircleLevelComplete,
				Value = _icheckencirclelevelcomplete
			};
		}

		// Token: 0x06020101 RID: 131329 RVA: 0x00472AC1 File Offset: 0x00470CC1
		public ICheckSpringFestivalAtmosphereLevelT AsICheckSpringFestivalAtmosphereLevel()
		{
			return this.As<ICheckSpringFestivalAtmosphereLevelT>();
		}

		// Token: 0x06020102 RID: 131330 RVA: 0x00472AC9 File Offset: 0x00470CC9
		public static ICheckSystemStateType_UnionUnion FromICheckSpringFestivalAtmosphereLevel(ICheckSpringFestivalAtmosphereLevelT _icheckspringfestivalatmospherelevel)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckSpringFestivalAtmosphereLevel,
				Value = _icheckspringfestivalatmospherelevel
			};
		}

		// Token: 0x06020103 RID: 131331 RVA: 0x00472ADF File Offset: 0x00470CDF
		public ICheckSpringFestivalGuessJokerFirstCompleteT AsICheckSpringFestivalGuessJokerFirstComplete()
		{
			return this.As<ICheckSpringFestivalGuessJokerFirstCompleteT>();
		}

		// Token: 0x06020104 RID: 131332 RVA: 0x00472AE7 File Offset: 0x00470CE7
		public static ICheckSystemStateType_UnionUnion FromICheckSpringFestivalGuessJokerFirstComplete(ICheckSpringFestivalGuessJokerFirstCompleteT _icheckspringfestivalguessjokerfirstcomplete)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckSpringFestivalGuessJokerFirstComplete,
				Value = _icheckspringfestivalguessjokerfirstcomplete
			};
		}

		// Token: 0x06020105 RID: 131333 RVA: 0x00472AFD File Offset: 0x00470CFD
		public ICheckCoopRoleCoopLevelT AsICheckCoopRoleCoopLevel()
		{
			return this.As<ICheckCoopRoleCoopLevelT>();
		}

		// Token: 0x06020106 RID: 131334 RVA: 0x00472B05 File Offset: 0x00470D05
		public static ICheckSystemStateType_UnionUnion FromICheckCoopRoleCoopLevel(ICheckCoopRoleCoopLevelT _icheckcooprolecooplevel)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckCoopRoleCoopLevel,
				Value = _icheckcooprolecooplevel
			};
		}

		// Token: 0x06020107 RID: 131335 RVA: 0x00472B1B File Offset: 0x00470D1B
		public ICheckSunSpiritDeliveryLevelT AsICheckSunSpiritDeliveryLevel()
		{
			return this.As<ICheckSunSpiritDeliveryLevelT>();
		}

		// Token: 0x06020108 RID: 131336 RVA: 0x00472B23 File Offset: 0x00470D23
		public static ICheckSystemStateType_UnionUnion FromICheckSunSpiritDeliveryLevel(ICheckSunSpiritDeliveryLevelT _ichecksunspiritdeliverylevel)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckSunSpiritDeliveryLevel,
				Value = _ichecksunspiritdeliverylevel
			};
		}

		// Token: 0x06020109 RID: 131337 RVA: 0x00472B39 File Offset: 0x00470D39
		public ICheckRhythmSpaceshipReachLevelRankT AsICheckRhythmSpaceshipReachLevelRank()
		{
			return this.As<ICheckRhythmSpaceshipReachLevelRankT>();
		}

		// Token: 0x0602010A RID: 131338 RVA: 0x00472B41 File Offset: 0x00470D41
		public static ICheckSystemStateType_UnionUnion FromICheckRhythmSpaceshipReachLevelRank(ICheckRhythmSpaceshipReachLevelRankT _icheckrhythmspaceshipreachlevelrank)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckRhythmSpaceshipReachLevelRank,
				Value = _icheckrhythmspaceshipreachlevelrank
			};
		}

		// Token: 0x0602010B RID: 131339 RVA: 0x00472B57 File Offset: 0x00470D57
		public ICheckDropCatchGameplayCompleteLevelT AsICheckDropCatchGameplayCompleteLevel()
		{
			return this.As<ICheckDropCatchGameplayCompleteLevelT>();
		}

		// Token: 0x0602010C RID: 131340 RVA: 0x00472B5F File Offset: 0x00470D5F
		public static ICheckSystemStateType_UnionUnion FromICheckDropCatchGameplayCompleteLevel(ICheckDropCatchGameplayCompleteLevelT _icheckdropcatchgameplaycompletelevel)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckDropCatchGameplayCompleteLevel,
				Value = _icheckdropcatchgameplaycompletelevel
			};
		}

		// Token: 0x0602010D RID: 131341 RVA: 0x00472B75 File Offset: 0x00470D75
		public ICheckDangoBrawlChallengeCompleteT AsICheckDangoBrawlChallengeComplete()
		{
			return this.As<ICheckDangoBrawlChallengeCompleteT>();
		}

		// Token: 0x0602010E RID: 131342 RVA: 0x00472B7D File Offset: 0x00470D7D
		public static ICheckSystemStateType_UnionUnion FromICheckDangoBrawlChallengeComplete(ICheckDangoBrawlChallengeCompleteT _icheckdangobrawlchallengecomplete)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckDangoBrawlChallengeComplete,
				Value = _icheckdangobrawlchallengecomplete
			};
		}

		// Token: 0x0602010F RID: 131343 RVA: 0x00472B93 File Offset: 0x00470D93
		public ICheckHandBookPageCompleteT AsICheckHandBookPageComplete()
		{
			return this.As<ICheckHandBookPageCompleteT>();
		}

		// Token: 0x06020110 RID: 131344 RVA: 0x00472B9B File Offset: 0x00470D9B
		public static ICheckSystemStateType_UnionUnion FromICheckHandBookPageComplete(ICheckHandBookPageCompleteT _icheckhandbookpagecomplete)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckHandBookPageComplete,
				Value = _icheckhandbookpagecomplete
			};
		}

		// Token: 0x06020111 RID: 131345 RVA: 0x00472BB1 File Offset: 0x00470DB1
		public ICheckRogueStateT AsICheckRogueState()
		{
			return this.As<ICheckRogueStateT>();
		}

		// Token: 0x06020112 RID: 131346 RVA: 0x00472BB9 File Offset: 0x00470DB9
		public static ICheckSystemStateType_UnionUnion FromICheckRogueState(ICheckRogueStateT _icheckroguestate)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckRogueState,
				Value = _icheckroguestate
			};
		}

		// Token: 0x06020113 RID: 131347 RVA: 0x00472BCF File Offset: 0x00470DCF
		public ICheckVillageInfrTreeBuildStateT AsICheckVillageInfrTreeBuildState()
		{
			return this.As<ICheckVillageInfrTreeBuildStateT>();
		}

		// Token: 0x06020114 RID: 131348 RVA: 0x00472BD7 File Offset: 0x00470DD7
		public static ICheckSystemStateType_UnionUnion FromICheckVillageInfrTreeBuildState(ICheckVillageInfrTreeBuildStateT _icheckvillageinfrtreebuildstate)
		{
			return new ICheckSystemStateType_UnionUnion
			{
				Type = ICheckSystemStateType_Union.ICheckVillageInfrTreeBuildState,
				Value = _icheckvillageinfrtreebuildstate
			};
		}

		// Token: 0x06020115 RID: 131349 RVA: 0x00472BF0 File Offset: 0x00470DF0
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
			case ICheckSystemStateType_Union.ICheckHandBookPageComplete:
				return ICheckHandBookPageComplete.Pack(builder, _o.AsICheckHandBookPageComplete()).Value;
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

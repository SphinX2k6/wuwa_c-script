using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005236 RID: 21046
	public class TCheckSystemStateUnion
	{
		// Token: 0x1700967A RID: 38522
		// (get) Token: 0x06021249 RID: 135753 RVA: 0x00493812 File Offset: 0x00491A12
		// (set) Token: 0x0602124A RID: 135754 RVA: 0x0049381A File Offset: 0x00491A1A
		public TCheckSystemState Type { get; set; }

		// Token: 0x1700967B RID: 38523
		// (get) Token: 0x0602124B RID: 135755 RVA: 0x00493823 File Offset: 0x00491A23
		// (set) Token: 0x0602124C RID: 135756 RVA: 0x0049382B File Offset: 0x00491A2B
		public object Value { get; set; }

		// Token: 0x0602124D RID: 135757 RVA: 0x00493834 File Offset: 0x00491A34
		public TCheckSystemStateUnion()
		{
			this.Type = TCheckSystemState.NONE;
			this.Value = null;
		}

		// Token: 0x0602124E RID: 135758 RVA: 0x0049384A File Offset: 0x00491A4A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602124F RID: 135759 RVA: 0x0049385C File Offset: 0x00491A5C
		public ICheckCollectionShopStateT AsICheckCollectionShopState()
		{
			return this.As<ICheckCollectionShopStateT>();
		}

		// Token: 0x06021250 RID: 135760 RVA: 0x00493864 File Offset: 0x00491A64
		public static TCheckSystemStateUnion FromICheckCollectionShopState(ICheckCollectionShopStateT _icheckcollectionshopstate)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckCollectionShopState,
				Value = _icheckcollectionshopstate
			};
		}

		// Token: 0x06021251 RID: 135761 RVA: 0x00493879 File Offset: 0x00491A79
		public ICheckCoopRoleCoopLevelT AsICheckCoopRoleCoopLevel()
		{
			return this.As<ICheckCoopRoleCoopLevelT>();
		}

		// Token: 0x06021252 RID: 135762 RVA: 0x00493881 File Offset: 0x00491A81
		public static TCheckSystemStateUnion FromICheckCoopRoleCoopLevel(ICheckCoopRoleCoopLevelT _icheckcooprolecooplevel)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckCoopRoleCoopLevel,
				Value = _icheckcooprolecooplevel
			};
		}

		// Token: 0x06021253 RID: 135763 RVA: 0x00493896 File Offset: 0x00491A96
		public ICheckDangoBrawlChallengeCompleteT AsICheckDangoBrawlChallengeComplete()
		{
			return this.As<ICheckDangoBrawlChallengeCompleteT>();
		}

		// Token: 0x06021254 RID: 135764 RVA: 0x0049389E File Offset: 0x00491A9E
		public static TCheckSystemStateUnion FromICheckDangoBrawlChallengeComplete(ICheckDangoBrawlChallengeCompleteT _icheckdangobrawlchallengecomplete)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckDangoBrawlChallengeComplete,
				Value = _icheckdangobrawlchallengecomplete
			};
		}

		// Token: 0x06021255 RID: 135765 RVA: 0x004938B3 File Offset: 0x00491AB3
		public ICheckDropCatchGameplayCompleteLevelT AsICheckDropCatchGameplayCompleteLevel()
		{
			return this.As<ICheckDropCatchGameplayCompleteLevelT>();
		}

		// Token: 0x06021256 RID: 135766 RVA: 0x004938BB File Offset: 0x00491ABB
		public static TCheckSystemStateUnion FromICheckDropCatchGameplayCompleteLevel(ICheckDropCatchGameplayCompleteLevelT _icheckdropcatchgameplaycompletelevel)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckDropCatchGameplayCompleteLevel,
				Value = _icheckdropcatchgameplaycompletelevel
			};
		}

		// Token: 0x06021257 RID: 135767 RVA: 0x004938D0 File Offset: 0x00491AD0
		public ICheckEncircleLevelCompleteT AsICheckEncircleLevelComplete()
		{
			return this.As<ICheckEncircleLevelCompleteT>();
		}

		// Token: 0x06021258 RID: 135768 RVA: 0x004938D8 File Offset: 0x00491AD8
		public static TCheckSystemStateUnion FromICheckEncircleLevelComplete(ICheckEncircleLevelCompleteT _icheckencirclelevelcomplete)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckEncircleLevelComplete,
				Value = _icheckencirclelevelcomplete
			};
		}

		// Token: 0x06021259 RID: 135769 RVA: 0x004938ED File Offset: 0x00491AED
		public ICheckHandBookPageCompleteT AsICheckHandBookPageComplete()
		{
			return this.As<ICheckHandBookPageCompleteT>();
		}

		// Token: 0x0602125A RID: 135770 RVA: 0x004938F5 File Offset: 0x00491AF5
		public static TCheckSystemStateUnion FromICheckHandBookPageComplete(ICheckHandBookPageCompleteT _icheckhandbookpagecomplete)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckHandBookPageComplete,
				Value = _icheckhandbookpagecomplete
			};
		}

		// Token: 0x0602125B RID: 135771 RVA: 0x0049390A File Offset: 0x00491B0A
		public ICheckInfrActivityExpT AsICheckInfrActivityExp()
		{
			return this.As<ICheckInfrActivityExpT>();
		}

		// Token: 0x0602125C RID: 135772 RVA: 0x00493912 File Offset: 0x00491B12
		public static TCheckSystemStateUnion FromICheckInfrActivityExp(ICheckInfrActivityExpT _icheckinfractivityexp)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckInfrActivityExp,
				Value = _icheckinfractivityexp
			};
		}

		// Token: 0x0602125D RID: 135773 RVA: 0x00493927 File Offset: 0x00491B27
		public ICheckInfrastructureStageT AsICheckInfrastructureStage()
		{
			return this.As<ICheckInfrastructureStageT>();
		}

		// Token: 0x0602125E RID: 135774 RVA: 0x0049392F File Offset: 0x00491B2F
		public static TCheckSystemStateUnion FromICheckInfrastructureStage(ICheckInfrastructureStageT _icheckinfrastructurestage)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckInfrastructureStage,
				Value = _icheckinfrastructurestage
			};
		}

		// Token: 0x0602125F RID: 135775 RVA: 0x00493944 File Offset: 0x00491B44
		public ICheckMoonBuildingStateT AsICheckMoonBuildingState()
		{
			return this.As<ICheckMoonBuildingStateT>();
		}

		// Token: 0x06021260 RID: 135776 RVA: 0x0049394C File Offset: 0x00491B4C
		public static TCheckSystemStateUnion FromICheckMoonBuildingState(ICheckMoonBuildingStateT _icheckmoonbuildingstate)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckMoonBuildingState,
				Value = _icheckmoonbuildingstate
			};
		}

		// Token: 0x06021261 RID: 135777 RVA: 0x00493962 File Offset: 0x00491B62
		public ICheckRhythmSpaceshipReachLevelRankT AsICheckRhythmSpaceshipReachLevelRank()
		{
			return this.As<ICheckRhythmSpaceshipReachLevelRankT>();
		}

		// Token: 0x06021262 RID: 135778 RVA: 0x0049396A File Offset: 0x00491B6A
		public static TCheckSystemStateUnion FromICheckRhythmSpaceshipReachLevelRank(ICheckRhythmSpaceshipReachLevelRankT _icheckrhythmspaceshipreachlevelrank)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckRhythmSpaceshipReachLevelRank,
				Value = _icheckrhythmspaceshipreachlevelrank
			};
		}

		// Token: 0x06021263 RID: 135779 RVA: 0x00493980 File Offset: 0x00491B80
		public ICheckRoadBuildStateT AsICheckRoadBuildState()
		{
			return this.As<ICheckRoadBuildStateT>();
		}

		// Token: 0x06021264 RID: 135780 RVA: 0x00493988 File Offset: 0x00491B88
		public static TCheckSystemStateUnion FromICheckRoadBuildState(ICheckRoadBuildStateT _icheckroadbuildstate)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckRoadBuildState,
				Value = _icheckroadbuildstate
			};
		}

		// Token: 0x06021265 RID: 135781 RVA: 0x0049399E File Offset: 0x00491B9E
		public ICheckRogueStateT AsICheckRogueState()
		{
			return this.As<ICheckRogueStateT>();
		}

		// Token: 0x06021266 RID: 135782 RVA: 0x004939A6 File Offset: 0x00491BA6
		public static TCheckSystemStateUnion FromICheckRogueState(ICheckRogueStateT _icheckroguestate)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckRogueState,
				Value = _icheckroguestate
			};
		}

		// Token: 0x06021267 RID: 135783 RVA: 0x004939BC File Offset: 0x00491BBC
		public ICheckSpringFestivalAtmosphereLevelT AsICheckSpringFestivalAtmosphereLevel()
		{
			return this.As<ICheckSpringFestivalAtmosphereLevelT>();
		}

		// Token: 0x06021268 RID: 135784 RVA: 0x004939C4 File Offset: 0x00491BC4
		public static TCheckSystemStateUnion FromICheckSpringFestivalAtmosphereLevel(ICheckSpringFestivalAtmosphereLevelT _icheckspringfestivalatmospherelevel)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckSpringFestivalAtmosphereLevel,
				Value = _icheckspringfestivalatmospherelevel
			};
		}

		// Token: 0x06021269 RID: 135785 RVA: 0x004939DA File Offset: 0x00491BDA
		public ICheckSpringFestivalGuessJokerFirstCompleteT AsICheckSpringFestivalGuessJokerFirstComplete()
		{
			return this.As<ICheckSpringFestivalGuessJokerFirstCompleteT>();
		}

		// Token: 0x0602126A RID: 135786 RVA: 0x004939E2 File Offset: 0x00491BE2
		public static TCheckSystemStateUnion FromICheckSpringFestivalGuessJokerFirstComplete(ICheckSpringFestivalGuessJokerFirstCompleteT _icheckspringfestivalguessjokerfirstcomplete)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckSpringFestivalGuessJokerFirstComplete,
				Value = _icheckspringfestivalguessjokerfirstcomplete
			};
		}

		// Token: 0x0602126B RID: 135787 RVA: 0x004939F8 File Offset: 0x00491BF8
		public ICheckSunSpiritDeliveryLevelT AsICheckSunSpiritDeliveryLevel()
		{
			return this.As<ICheckSunSpiritDeliveryLevelT>();
		}

		// Token: 0x0602126C RID: 135788 RVA: 0x00493A00 File Offset: 0x00491C00
		public static TCheckSystemStateUnion FromICheckSunSpiritDeliveryLevel(ICheckSunSpiritDeliveryLevelT _ichecksunspiritdeliverylevel)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckSunSpiritDeliveryLevel,
				Value = _ichecksunspiritdeliverylevel
			};
		}

		// Token: 0x0602126D RID: 135789 RVA: 0x00493A16 File Offset: 0x00491C16
		public ICheckTrackMoonPopularityT AsICheckTrackMoonPopularity()
		{
			return this.As<ICheckTrackMoonPopularityT>();
		}

		// Token: 0x0602126E RID: 135790 RVA: 0x00493A1E File Offset: 0x00491C1E
		public static TCheckSystemStateUnion FromICheckTrackMoonPopularity(ICheckTrackMoonPopularityT _ichecktrackmoonpopularity)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckTrackMoonPopularity,
				Value = _ichecktrackmoonpopularity
			};
		}

		// Token: 0x0602126F RID: 135791 RVA: 0x00493A34 File Offset: 0x00491C34
		public ICheckVillageInfrLevelT AsICheckVillageInfrLevel()
		{
			return this.As<ICheckVillageInfrLevelT>();
		}

		// Token: 0x06021270 RID: 135792 RVA: 0x00493A3C File Offset: 0x00491C3C
		public static TCheckSystemStateUnion FromICheckVillageInfrLevel(ICheckVillageInfrLevelT _icheckvillageinfrlevel)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckVillageInfrLevel,
				Value = _icheckvillageinfrlevel
			};
		}

		// Token: 0x06021271 RID: 135793 RVA: 0x00493A52 File Offset: 0x00491C52
		public ICheckVillageInfrTreeBuildStateT AsICheckVillageInfrTreeBuildState()
		{
			return this.As<ICheckVillageInfrTreeBuildStateT>();
		}

		// Token: 0x06021272 RID: 135794 RVA: 0x00493A5A File Offset: 0x00491C5A
		public static TCheckSystemStateUnion FromICheckVillageInfrTreeBuildState(ICheckVillageInfrTreeBuildStateT _icheckvillageinfrtreebuildstate)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckVillageInfrTreeBuildState,
				Value = _icheckvillageinfrtreebuildstate
			};
		}

		// Token: 0x06021273 RID: 135795 RVA: 0x00493A70 File Offset: 0x00491C70
		public static int Pack(FlatBufferBuilder builder, TCheckSystemStateUnion _o)
		{
			switch (_o.Type)
			{
			case TCheckSystemState.ICheckCollectionShopState:
				return ICheckCollectionShopState.Pack(builder, _o.AsICheckCollectionShopState()).Value;
			case TCheckSystemState.ICheckCoopRoleCoopLevel:
				return ICheckCoopRoleCoopLevel.Pack(builder, _o.AsICheckCoopRoleCoopLevel()).Value;
			case TCheckSystemState.ICheckDangoBrawlChallengeComplete:
				return ICheckDangoBrawlChallengeComplete.Pack(builder, _o.AsICheckDangoBrawlChallengeComplete()).Value;
			case TCheckSystemState.ICheckDropCatchGameplayCompleteLevel:
				return ICheckDropCatchGameplayCompleteLevel.Pack(builder, _o.AsICheckDropCatchGameplayCompleteLevel()).Value;
			case TCheckSystemState.ICheckEncircleLevelComplete:
				return ICheckEncircleLevelComplete.Pack(builder, _o.AsICheckEncircleLevelComplete()).Value;
			case TCheckSystemState.ICheckHandBookPageComplete:
				return ICheckHandBookPageComplete.Pack(builder, _o.AsICheckHandBookPageComplete()).Value;
			case TCheckSystemState.ICheckInfrActivityExp:
				return ICheckInfrActivityExp.Pack(builder, _o.AsICheckInfrActivityExp()).Value;
			case TCheckSystemState.ICheckInfrastructureStage:
				return ICheckInfrastructureStage.Pack(builder, _o.AsICheckInfrastructureStage()).Value;
			case TCheckSystemState.ICheckMoonBuildingState:
				return ICheckMoonBuildingState.Pack(builder, _o.AsICheckMoonBuildingState()).Value;
			case TCheckSystemState.ICheckRhythmSpaceshipReachLevelRank:
				return ICheckRhythmSpaceshipReachLevelRank.Pack(builder, _o.AsICheckRhythmSpaceshipReachLevelRank()).Value;
			case TCheckSystemState.ICheckRoadBuildState:
				return ICheckRoadBuildState.Pack(builder, _o.AsICheckRoadBuildState()).Value;
			case TCheckSystemState.ICheckRogueState:
				return ICheckRogueState.Pack(builder, _o.AsICheckRogueState()).Value;
			case TCheckSystemState.ICheckSpringFestivalAtmosphereLevel:
				return ICheckSpringFestivalAtmosphereLevel.Pack(builder, _o.AsICheckSpringFestivalAtmosphereLevel()).Value;
			case TCheckSystemState.ICheckSpringFestivalGuessJokerFirstComplete:
				return ICheckSpringFestivalGuessJokerFirstComplete.Pack(builder, _o.AsICheckSpringFestivalGuessJokerFirstComplete()).Value;
			case TCheckSystemState.ICheckSunSpiritDeliveryLevel:
				return ICheckSunSpiritDeliveryLevel.Pack(builder, _o.AsICheckSunSpiritDeliveryLevel()).Value;
			case TCheckSystemState.ICheckTrackMoonPopularity:
				return ICheckTrackMoonPopularity.Pack(builder, _o.AsICheckTrackMoonPopularity()).Value;
			case TCheckSystemState.ICheckVillageInfrLevel:
				return ICheckVillageInfrLevel.Pack(builder, _o.AsICheckVillageInfrLevel()).Value;
			case TCheckSystemState.ICheckVillageInfrTreeBuildState:
				return ICheckVillageInfrTreeBuildState.Pack(builder, _o.AsICheckVillageInfrTreeBuildState()).Value;
			default:
				return 0;
			}
		}
	}
}

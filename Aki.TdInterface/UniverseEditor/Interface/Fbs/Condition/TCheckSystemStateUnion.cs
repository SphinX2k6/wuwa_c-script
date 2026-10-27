using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D3A RID: 19770
	public class TCheckSystemStateUnion
	{
		// Token: 0x17008F41 RID: 36673
		// (get) Token: 0x0601F602 RID: 128514 RVA: 0x0045F882 File Offset: 0x0045DA82
		// (set) Token: 0x0601F603 RID: 128515 RVA: 0x0045F88A File Offset: 0x0045DA8A
		public TCheckSystemState Type { get; set; }

		// Token: 0x17008F42 RID: 36674
		// (get) Token: 0x0601F604 RID: 128516 RVA: 0x0045F893 File Offset: 0x0045DA93
		// (set) Token: 0x0601F605 RID: 128517 RVA: 0x0045F89B File Offset: 0x0045DA9B
		public object Value { get; set; }

		// Token: 0x0601F606 RID: 128518 RVA: 0x0045F8A4 File Offset: 0x0045DAA4
		public TCheckSystemStateUnion()
		{
			this.Type = TCheckSystemState.NONE;
			this.Value = null;
		}

		// Token: 0x0601F607 RID: 128519 RVA: 0x0045F8BA File Offset: 0x0045DABA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F608 RID: 128520 RVA: 0x0045F8CC File Offset: 0x0045DACC
		public ICheckCollectionShopStateT AsICheckCollectionShopState()
		{
			return this.As<ICheckCollectionShopStateT>();
		}

		// Token: 0x0601F609 RID: 128521 RVA: 0x0045F8D4 File Offset: 0x0045DAD4
		public static TCheckSystemStateUnion FromICheckCollectionShopState(ICheckCollectionShopStateT _icheckcollectionshopstate)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckCollectionShopState,
				Value = _icheckcollectionshopstate
			};
		}

		// Token: 0x0601F60A RID: 128522 RVA: 0x0045F8E9 File Offset: 0x0045DAE9
		public ICheckCoopRoleCoopLevelT AsICheckCoopRoleCoopLevel()
		{
			return this.As<ICheckCoopRoleCoopLevelT>();
		}

		// Token: 0x0601F60B RID: 128523 RVA: 0x0045F8F1 File Offset: 0x0045DAF1
		public static TCheckSystemStateUnion FromICheckCoopRoleCoopLevel(ICheckCoopRoleCoopLevelT _icheckcooprolecooplevel)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckCoopRoleCoopLevel,
				Value = _icheckcooprolecooplevel
			};
		}

		// Token: 0x0601F60C RID: 128524 RVA: 0x0045F906 File Offset: 0x0045DB06
		public ICheckDangoBrawlChallengeCompleteT AsICheckDangoBrawlChallengeComplete()
		{
			return this.As<ICheckDangoBrawlChallengeCompleteT>();
		}

		// Token: 0x0601F60D RID: 128525 RVA: 0x0045F90E File Offset: 0x0045DB0E
		public static TCheckSystemStateUnion FromICheckDangoBrawlChallengeComplete(ICheckDangoBrawlChallengeCompleteT _icheckdangobrawlchallengecomplete)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckDangoBrawlChallengeComplete,
				Value = _icheckdangobrawlchallengecomplete
			};
		}

		// Token: 0x0601F60E RID: 128526 RVA: 0x0045F923 File Offset: 0x0045DB23
		public ICheckDropCatchGameplayCompleteLevelT AsICheckDropCatchGameplayCompleteLevel()
		{
			return this.As<ICheckDropCatchGameplayCompleteLevelT>();
		}

		// Token: 0x0601F60F RID: 128527 RVA: 0x0045F92B File Offset: 0x0045DB2B
		public static TCheckSystemStateUnion FromICheckDropCatchGameplayCompleteLevel(ICheckDropCatchGameplayCompleteLevelT _icheckdropcatchgameplaycompletelevel)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckDropCatchGameplayCompleteLevel,
				Value = _icheckdropcatchgameplaycompletelevel
			};
		}

		// Token: 0x0601F610 RID: 128528 RVA: 0x0045F940 File Offset: 0x0045DB40
		public ICheckEncircleLevelCompleteT AsICheckEncircleLevelComplete()
		{
			return this.As<ICheckEncircleLevelCompleteT>();
		}

		// Token: 0x0601F611 RID: 128529 RVA: 0x0045F948 File Offset: 0x0045DB48
		public static TCheckSystemStateUnion FromICheckEncircleLevelComplete(ICheckEncircleLevelCompleteT _icheckencirclelevelcomplete)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckEncircleLevelComplete,
				Value = _icheckencirclelevelcomplete
			};
		}

		// Token: 0x0601F612 RID: 128530 RVA: 0x0045F95D File Offset: 0x0045DB5D
		public ICheckInfrActivityExpT AsICheckInfrActivityExp()
		{
			return this.As<ICheckInfrActivityExpT>();
		}

		// Token: 0x0601F613 RID: 128531 RVA: 0x0045F965 File Offset: 0x0045DB65
		public static TCheckSystemStateUnion FromICheckInfrActivityExp(ICheckInfrActivityExpT _icheckinfractivityexp)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckInfrActivityExp,
				Value = _icheckinfractivityexp
			};
		}

		// Token: 0x0601F614 RID: 128532 RVA: 0x0045F97A File Offset: 0x0045DB7A
		public ICheckInfrastructureStageT AsICheckInfrastructureStage()
		{
			return this.As<ICheckInfrastructureStageT>();
		}

		// Token: 0x0601F615 RID: 128533 RVA: 0x0045F982 File Offset: 0x0045DB82
		public static TCheckSystemStateUnion FromICheckInfrastructureStage(ICheckInfrastructureStageT _icheckinfrastructurestage)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckInfrastructureStage,
				Value = _icheckinfrastructurestage
			};
		}

		// Token: 0x0601F616 RID: 128534 RVA: 0x0045F997 File Offset: 0x0045DB97
		public ICheckMoonBuildingStateT AsICheckMoonBuildingState()
		{
			return this.As<ICheckMoonBuildingStateT>();
		}

		// Token: 0x0601F617 RID: 128535 RVA: 0x0045F99F File Offset: 0x0045DB9F
		public static TCheckSystemStateUnion FromICheckMoonBuildingState(ICheckMoonBuildingStateT _icheckmoonbuildingstate)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckMoonBuildingState,
				Value = _icheckmoonbuildingstate
			};
		}

		// Token: 0x0601F618 RID: 128536 RVA: 0x0045F9B4 File Offset: 0x0045DBB4
		public ICheckRhythmSpaceshipReachLevelRankT AsICheckRhythmSpaceshipReachLevelRank()
		{
			return this.As<ICheckRhythmSpaceshipReachLevelRankT>();
		}

		// Token: 0x0601F619 RID: 128537 RVA: 0x0045F9BC File Offset: 0x0045DBBC
		public static TCheckSystemStateUnion FromICheckRhythmSpaceshipReachLevelRank(ICheckRhythmSpaceshipReachLevelRankT _icheckrhythmspaceshipreachlevelrank)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckRhythmSpaceshipReachLevelRank,
				Value = _icheckrhythmspaceshipreachlevelrank
			};
		}

		// Token: 0x0601F61A RID: 128538 RVA: 0x0045F9D2 File Offset: 0x0045DBD2
		public ICheckRoadBuildStateT AsICheckRoadBuildState()
		{
			return this.As<ICheckRoadBuildStateT>();
		}

		// Token: 0x0601F61B RID: 128539 RVA: 0x0045F9DA File Offset: 0x0045DBDA
		public static TCheckSystemStateUnion FromICheckRoadBuildState(ICheckRoadBuildStateT _icheckroadbuildstate)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckRoadBuildState,
				Value = _icheckroadbuildstate
			};
		}

		// Token: 0x0601F61C RID: 128540 RVA: 0x0045F9F0 File Offset: 0x0045DBF0
		public ICheckRogueStateT AsICheckRogueState()
		{
			return this.As<ICheckRogueStateT>();
		}

		// Token: 0x0601F61D RID: 128541 RVA: 0x0045F9F8 File Offset: 0x0045DBF8
		public static TCheckSystemStateUnion FromICheckRogueState(ICheckRogueStateT _icheckroguestate)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckRogueState,
				Value = _icheckroguestate
			};
		}

		// Token: 0x0601F61E RID: 128542 RVA: 0x0045FA0E File Offset: 0x0045DC0E
		public ICheckSpringFestivalAtmosphereLevelT AsICheckSpringFestivalAtmosphereLevel()
		{
			return this.As<ICheckSpringFestivalAtmosphereLevelT>();
		}

		// Token: 0x0601F61F RID: 128543 RVA: 0x0045FA16 File Offset: 0x0045DC16
		public static TCheckSystemStateUnion FromICheckSpringFestivalAtmosphereLevel(ICheckSpringFestivalAtmosphereLevelT _icheckspringfestivalatmospherelevel)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckSpringFestivalAtmosphereLevel,
				Value = _icheckspringfestivalatmospherelevel
			};
		}

		// Token: 0x0601F620 RID: 128544 RVA: 0x0045FA2C File Offset: 0x0045DC2C
		public ICheckSpringFestivalGuessJokerFirstCompleteT AsICheckSpringFestivalGuessJokerFirstComplete()
		{
			return this.As<ICheckSpringFestivalGuessJokerFirstCompleteT>();
		}

		// Token: 0x0601F621 RID: 128545 RVA: 0x0045FA34 File Offset: 0x0045DC34
		public static TCheckSystemStateUnion FromICheckSpringFestivalGuessJokerFirstComplete(ICheckSpringFestivalGuessJokerFirstCompleteT _icheckspringfestivalguessjokerfirstcomplete)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckSpringFestivalGuessJokerFirstComplete,
				Value = _icheckspringfestivalguessjokerfirstcomplete
			};
		}

		// Token: 0x0601F622 RID: 128546 RVA: 0x0045FA4A File Offset: 0x0045DC4A
		public ICheckSunSpiritDeliveryLevelT AsICheckSunSpiritDeliveryLevel()
		{
			return this.As<ICheckSunSpiritDeliveryLevelT>();
		}

		// Token: 0x0601F623 RID: 128547 RVA: 0x0045FA52 File Offset: 0x0045DC52
		public static TCheckSystemStateUnion FromICheckSunSpiritDeliveryLevel(ICheckSunSpiritDeliveryLevelT _ichecksunspiritdeliverylevel)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckSunSpiritDeliveryLevel,
				Value = _ichecksunspiritdeliverylevel
			};
		}

		// Token: 0x0601F624 RID: 128548 RVA: 0x0045FA68 File Offset: 0x0045DC68
		public ICheckTrackMoonPopularityT AsICheckTrackMoonPopularity()
		{
			return this.As<ICheckTrackMoonPopularityT>();
		}

		// Token: 0x0601F625 RID: 128549 RVA: 0x0045FA70 File Offset: 0x0045DC70
		public static TCheckSystemStateUnion FromICheckTrackMoonPopularity(ICheckTrackMoonPopularityT _ichecktrackmoonpopularity)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckTrackMoonPopularity,
				Value = _ichecktrackmoonpopularity
			};
		}

		// Token: 0x0601F626 RID: 128550 RVA: 0x0045FA86 File Offset: 0x0045DC86
		public ICheckVillageInfrLevelT AsICheckVillageInfrLevel()
		{
			return this.As<ICheckVillageInfrLevelT>();
		}

		// Token: 0x0601F627 RID: 128551 RVA: 0x0045FA8E File Offset: 0x0045DC8E
		public static TCheckSystemStateUnion FromICheckVillageInfrLevel(ICheckVillageInfrLevelT _icheckvillageinfrlevel)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckVillageInfrLevel,
				Value = _icheckvillageinfrlevel
			};
		}

		// Token: 0x0601F628 RID: 128552 RVA: 0x0045FAA4 File Offset: 0x0045DCA4
		public ICheckVillageInfrTreeBuildStateT AsICheckVillageInfrTreeBuildState()
		{
			return this.As<ICheckVillageInfrTreeBuildStateT>();
		}

		// Token: 0x0601F629 RID: 128553 RVA: 0x0045FAAC File Offset: 0x0045DCAC
		public static TCheckSystemStateUnion FromICheckVillageInfrTreeBuildState(ICheckVillageInfrTreeBuildStateT _icheckvillageinfrtreebuildstate)
		{
			return new TCheckSystemStateUnion
			{
				Type = TCheckSystemState.ICheckVillageInfrTreeBuildState,
				Value = _icheckvillageinfrtreebuildstate
			};
		}

		// Token: 0x0601F62A RID: 128554 RVA: 0x0045FAC4 File Offset: 0x0045DCC4
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

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200471D RID: 18205
	public class TChildQuestConditionUnion
	{
		// Token: 0x17007F66 RID: 32614
		// (get) Token: 0x0601AC81 RID: 109697 RVA: 0x003CDAA2 File Offset: 0x003CBCA2
		// (set) Token: 0x0601AC82 RID: 109698 RVA: 0x003CDAAA File Offset: 0x003CBCAA
		public TChildQuestCondition Type { get; set; }

		// Token: 0x17007F67 RID: 32615
		// (get) Token: 0x0601AC83 RID: 109699 RVA: 0x003CDAB3 File Offset: 0x003CBCB3
		// (set) Token: 0x0601AC84 RID: 109700 RVA: 0x003CDABB File Offset: 0x003CBCBB
		public object Value { get; set; }

		// Token: 0x0601AC85 RID: 109701 RVA: 0x003CDAC4 File Offset: 0x003CBCC4
		public TChildQuestConditionUnion()
		{
			this.Type = TChildQuestCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0601AC86 RID: 109702 RVA: 0x003CDADA File Offset: 0x003CBCDA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AC87 RID: 109703 RVA: 0x003CDAEC File Offset: 0x003CBCEC
		public IAtomicProcessT AsIAtomicProcess()
		{
			return this.As<IAtomicProcessT>();
		}

		// Token: 0x0601AC88 RID: 109704 RVA: 0x003CDAF4 File Offset: 0x003CBCF4
		public static TChildQuestConditionUnion FromIAtomicProcess(IAtomicProcessT _iatomicprocess)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IAtomicProcess,
				Value = _iatomicprocess
			};
		}

		// Token: 0x0601AC89 RID: 109705 RVA: 0x003CDB09 File Offset: 0x003CBD09
		public IAwakeAndLoadEntityConditionT AsIAwakeAndLoadEntityCondition()
		{
			return this.As<IAwakeAndLoadEntityConditionT>();
		}

		// Token: 0x0601AC8A RID: 109706 RVA: 0x003CDB11 File Offset: 0x003CBD11
		public static TChildQuestConditionUnion FromIAwakeAndLoadEntityCondition(IAwakeAndLoadEntityConditionT _iawakeandloadentitycondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IAwakeAndLoadEntityCondition,
				Value = _iawakeandloadentitycondition
			};
		}

		// Token: 0x0601AC8B RID: 109707 RVA: 0x003CDB26 File Offset: 0x003CBD26
		public ICheckActivityStateConditionT AsICheckActivityStateCondition()
		{
			return this.As<ICheckActivityStateConditionT>();
		}

		// Token: 0x0601AC8C RID: 109708 RVA: 0x003CDB2E File Offset: 0x003CBD2E
		public static TChildQuestConditionUnion FromICheckActivityStateCondition(ICheckActivityStateConditionT _icheckactivitystatecondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICheckActivityStateCondition,
				Value = _icheckactivitystatecondition
			};
		}

		// Token: 0x0601AC8D RID: 109709 RVA: 0x003CDB43 File Offset: 0x003CBD43
		public ICheckClientConditionGroupQuestConditionT AsICheckClientConditionGroupQuestCondition()
		{
			return this.As<ICheckClientConditionGroupQuestConditionT>();
		}

		// Token: 0x0601AC8E RID: 109710 RVA: 0x003CDB4B File Offset: 0x003CBD4B
		public static TChildQuestConditionUnion FromICheckClientConditionGroupQuestCondition(ICheckClientConditionGroupQuestConditionT _icheckclientconditiongroupquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICheckClientConditionGroupQuestCondition,
				Value = _icheckclientconditiongroupquestcondition
			};
		}

		// Token: 0x0601AC8F RID: 109711 RVA: 0x003CDB60 File Offset: 0x003CBD60
		public ICheckConditionGroupQuestConditionT AsICheckConditionGroupQuestCondition()
		{
			return this.As<ICheckConditionGroupQuestConditionT>();
		}

		// Token: 0x0601AC90 RID: 109712 RVA: 0x003CDB68 File Offset: 0x003CBD68
		public static TChildQuestConditionUnion FromICheckConditionGroupQuestCondition(ICheckConditionGroupQuestConditionT _icheckconditiongroupquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICheckConditionGroupQuestCondition,
				Value = _icheckconditiongroupquestcondition
			};
		}

		// Token: 0x0601AC91 RID: 109713 RVA: 0x003CDB7D File Offset: 0x003CBD7D
		public ICheckEntityStateQuestConditionT AsICheckEntityStateQuestCondition()
		{
			return this.As<ICheckEntityStateQuestConditionT>();
		}

		// Token: 0x0601AC92 RID: 109714 RVA: 0x003CDB85 File Offset: 0x003CBD85
		public static TChildQuestConditionUnion FromICheckEntityStateQuestCondition(ICheckEntityStateQuestConditionT _icheckentitystatequestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICheckEntityStateQuestCondition,
				Value = _icheckentitystatequestcondition
			};
		}

		// Token: 0x0601AC93 RID: 109715 RVA: 0x003CDB9A File Offset: 0x003CBD9A
		public ICheckLevelPlayQuestConditionT AsICheckLevelPlayQuestCondition()
		{
			return this.As<ICheckLevelPlayQuestConditionT>();
		}

		// Token: 0x0601AC94 RID: 109716 RVA: 0x003CDBA2 File Offset: 0x003CBDA2
		public static TChildQuestConditionUnion FromICheckLevelPlayQuestCondition(ICheckLevelPlayQuestConditionT _ichecklevelplayquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICheckLevelPlayQuestCondition,
				Value = _ichecklevelplayquestcondition
			};
		}

		// Token: 0x0601AC95 RID: 109717 RVA: 0x003CDBB7 File Offset: 0x003CBDB7
		public ICheckPlayerInputConditionT AsICheckPlayerInputCondition()
		{
			return this.As<ICheckPlayerInputConditionT>();
		}

		// Token: 0x0601AC96 RID: 109718 RVA: 0x003CDBBF File Offset: 0x003CBDBF
		public static TChildQuestConditionUnion FromICheckPlayerInputCondition(ICheckPlayerInputConditionT _icheckplayerinputcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICheckPlayerInputCondition,
				Value = _icheckplayerinputcondition
			};
		}

		// Token: 0x0601AC97 RID: 109719 RVA: 0x003CDBD4 File Offset: 0x003CBDD4
		public ICheckSpringFestivalGameplayCompletedT AsICheckSpringFestivalGameplayCompleted()
		{
			return this.As<ICheckSpringFestivalGameplayCompletedT>();
		}

		// Token: 0x0601AC98 RID: 109720 RVA: 0x003CDBDC File Offset: 0x003CBDDC
		public static TChildQuestConditionUnion FromICheckSpringFestivalGameplayCompleted(ICheckSpringFestivalGameplayCompletedT _icheckspringfestivalgameplaycompleted)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICheckSpringFestivalGameplayCompleted,
				Value = _icheckspringfestivalgameplaycompleted
			};
		}

		// Token: 0x0601AC99 RID: 109721 RVA: 0x003CDBF2 File Offset: 0x003CBDF2
		public ICheckTargetBattleAttributeConditionT AsICheckTargetBattleAttributeCondition()
		{
			return this.As<ICheckTargetBattleAttributeConditionT>();
		}

		// Token: 0x0601AC9A RID: 109722 RVA: 0x003CDBFA File Offset: 0x003CBDFA
		public static TChildQuestConditionUnion FromICheckTargetBattleAttributeCondition(ICheckTargetBattleAttributeConditionT _ichecktargetbattleattributecondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICheckTargetBattleAttributeCondition,
				Value = _ichecktargetbattleattributecondition
			};
		}

		// Token: 0x0601AC9B RID: 109723 RVA: 0x003CDC10 File Offset: 0x003CBE10
		public ICheckTrapDefenseEventConditionT AsICheckTrapDefenseEventCondition()
		{
			return this.As<ICheckTrapDefenseEventConditionT>();
		}

		// Token: 0x0601AC9C RID: 109724 RVA: 0x003CDC18 File Offset: 0x003CBE18
		public static TChildQuestConditionUnion FromICheckTrapDefenseEventCondition(ICheckTrapDefenseEventConditionT _ichecktrapdefenseeventcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICheckTrapDefenseEventCondition,
				Value = _ichecktrapdefenseeventcondition
			};
		}

		// Token: 0x0601AC9D RID: 109725 RVA: 0x003CDC2E File Offset: 0x003CBE2E
		public ICheckUiGameQuestConditionT AsICheckUiGameQuestCondition()
		{
			return this.As<ICheckUiGameQuestConditionT>();
		}

		// Token: 0x0601AC9E RID: 109726 RVA: 0x003CDC36 File Offset: 0x003CBE36
		public static TChildQuestConditionUnion FromICheckUiGameQuestCondition(ICheckUiGameQuestConditionT _icheckuigamequestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICheckUiGameQuestCondition,
				Value = _icheckuigamequestcondition
			};
		}

		// Token: 0x0601AC9F RID: 109727 RVA: 0x003CDC4C File Offset: 0x003CBE4C
		public ICompareActorVarT AsICompareActorVar()
		{
			return this.As<ICompareActorVarT>();
		}

		// Token: 0x0601ACA0 RID: 109728 RVA: 0x003CDC54 File Offset: 0x003CBE54
		public static TChildQuestConditionUnion FromICompareActorVar(ICompareActorVarT _icompareactorvar)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICompareActorVar,
				Value = _icompareactorvar
			};
		}

		// Token: 0x0601ACA1 RID: 109729 RVA: 0x003CDC6A File Offset: 0x003CBE6A
		public ICompareVarConditionInChildQuestT AsICompareVarConditionInChildQuest()
		{
			return this.As<ICompareVarConditionInChildQuestT>();
		}

		// Token: 0x0601ACA2 RID: 109730 RVA: 0x003CDC72 File Offset: 0x003CBE72
		public static TChildQuestConditionUnion FromICompareVarConditionInChildQuest(ICompareVarConditionInChildQuestT _icomparevarconditioninchildquest)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICompareVarConditionInChildQuest,
				Value = _icomparevarconditioninchildquest
			};
		}

		// Token: 0x0601ACA3 RID: 109731 RVA: 0x003CDC88 File Offset: 0x003CBE88
		public ICrossSceneSyncKillMonsterT AsICrossSceneSyncKillMonster()
		{
			return this.As<ICrossSceneSyncKillMonsterT>();
		}

		// Token: 0x0601ACA4 RID: 109732 RVA: 0x003CDC90 File Offset: 0x003CBE90
		public static TChildQuestConditionUnion FromICrossSceneSyncKillMonster(ICrossSceneSyncKillMonsterT _icrossscenesynckillmonster)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICrossSceneSyncKillMonster,
				Value = _icrossscenesynckillmonster
			};
		}

		// Token: 0x0601ACA5 RID: 109733 RVA: 0x003CDCA6 File Offset: 0x003CBEA6
		public IDetectCombatState2ConditionT AsIDetectCombatState2Condition()
		{
			return this.As<IDetectCombatState2ConditionT>();
		}

		// Token: 0x0601ACA6 RID: 109734 RVA: 0x003CDCAE File Offset: 0x003CBEAE
		public static TChildQuestConditionUnion FromIDetectCombatState2Condition(IDetectCombatState2ConditionT _idetectcombatstate2condition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IDetectCombatState2Condition,
				Value = _idetectcombatstate2condition
			};
		}

		// Token: 0x0601ACA7 RID: 109735 RVA: 0x003CDCC4 File Offset: 0x003CBEC4
		public IDetectCombatStateConditionT AsIDetectCombatStateCondition()
		{
			return this.As<IDetectCombatStateConditionT>();
		}

		// Token: 0x0601ACA8 RID: 109736 RVA: 0x003CDCCC File Offset: 0x003CBECC
		public static TChildQuestConditionUnion FromIDetectCombatStateCondition(IDetectCombatStateConditionT _idetectcombatstatecondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IDetectCombatStateCondition,
				Value = _idetectcombatstatecondition
			};
		}

		// Token: 0x0601ACA9 RID: 109737 RVA: 0x003CDCE2 File Offset: 0x003CBEE2
		public IDoInteractQuestConditionT AsIDoInteractQuestCondition()
		{
			return this.As<IDoInteractQuestConditionT>();
		}

		// Token: 0x0601ACAA RID: 109738 RVA: 0x003CDCEA File Offset: 0x003CBEEA
		public static TChildQuestConditionUnion FromIDoInteractQuestCondition(IDoInteractQuestConditionT _idointeractquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IDoInteractQuestCondition,
				Value = _idointeractquestcondition
			};
		}

		// Token: 0x0601ACAB RID: 109739 RVA: 0x003CDD00 File Offset: 0x003CBF00
		public IEnterDungeonConditionT AsIEnterDungeonCondition()
		{
			return this.As<IEnterDungeonConditionT>();
		}

		// Token: 0x0601ACAC RID: 109740 RVA: 0x003CDD08 File Offset: 0x003CBF08
		public static TChildQuestConditionUnion FromIEnterDungeonCondition(IEnterDungeonConditionT _ienterdungeoncondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IEnterDungeonCondition,
				Value = _ienterdungeoncondition
			};
		}

		// Token: 0x0601ACAD RID: 109741 RVA: 0x003CDD1E File Offset: 0x003CBF1E
		public IFinishArcadeGameplayT AsIFinishArcadeGameplay()
		{
			return this.As<IFinishArcadeGameplayT>();
		}

		// Token: 0x0601ACAE RID: 109742 RVA: 0x003CDD26 File Offset: 0x003CBF26
		public static TChildQuestConditionUnion FromIFinishArcadeGameplay(IFinishArcadeGameplayT _ifinisharcadegameplay)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishArcadeGameplay,
				Value = _ifinisharcadegameplay
			};
		}

		// Token: 0x0601ACAF RID: 109743 RVA: 0x003CDD3C File Offset: 0x003CBF3C
		public IFinishBvbChallengeT AsIFinishBvbChallenge()
		{
			return this.As<IFinishBvbChallengeT>();
		}

		// Token: 0x0601ACB0 RID: 109744 RVA: 0x003CDD44 File Offset: 0x003CBF44
		public static TChildQuestConditionUnion FromIFinishBvbChallenge(IFinishBvbChallengeT _ifinishbvbchallenge)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishBvbChallenge,
				Value = _ifinishbvbchallenge
			};
		}

		// Token: 0x0601ACB1 RID: 109745 RVA: 0x003CDD5A File Offset: 0x003CBF5A
		public IFinishDungeonQuestConditionT AsIFinishDungeonQuestCondition()
		{
			return this.As<IFinishDungeonQuestConditionT>();
		}

		// Token: 0x0601ACB2 RID: 109746 RVA: 0x003CDD62 File Offset: 0x003CBF62
		public static TChildQuestConditionUnion FromIFinishDungeonQuestCondition(IFinishDungeonQuestConditionT _ifinishdungeonquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishDungeonQuestCondition,
				Value = _ifinishdungeonquestcondition
			};
		}

		// Token: 0x0601ACB3 RID: 109747 RVA: 0x003CDD78 File Offset: 0x003CBF78
		public IFinishFlipperConditionT AsIFinishFlipperCondition()
		{
			return this.As<IFinishFlipperConditionT>();
		}

		// Token: 0x0601ACB4 RID: 109748 RVA: 0x003CDD80 File Offset: 0x003CBF80
		public static TChildQuestConditionUnion FromIFinishFlipperCondition(IFinishFlipperConditionT _ifinishflippercondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishFlipperCondition,
				Value = _ifinishflippercondition
			};
		}

		// Token: 0x0601ACB5 RID: 109749 RVA: 0x003CDD96 File Offset: 0x003CBF96
		public IFinishJellyfishReturnConditionT AsIFinishJellyfishReturnCondition()
		{
			return this.As<IFinishJellyfishReturnConditionT>();
		}

		// Token: 0x0601ACB6 RID: 109750 RVA: 0x003CDD9E File Offset: 0x003CBF9E
		public static TChildQuestConditionUnion FromIFinishJellyfishReturnCondition(IFinishJellyfishReturnConditionT _ifinishjellyfishreturncondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishJellyfishReturnCondition,
				Value = _ifinishjellyfishreturncondition
			};
		}

		// Token: 0x0601ACB7 RID: 109751 RVA: 0x003CDDB4 File Offset: 0x003CBFB4
		public IFinishKuroSimpleCombatKillMonsterT AsIFinishKuroSimpleCombatKillMonster()
		{
			return this.As<IFinishKuroSimpleCombatKillMonsterT>();
		}

		// Token: 0x0601ACB8 RID: 109752 RVA: 0x003CDDBC File Offset: 0x003CBFBC
		public static TChildQuestConditionUnion FromIFinishKuroSimpleCombatKillMonster(IFinishKuroSimpleCombatKillMonsterT _ifinishkurosimplecombatkillmonster)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishKuroSimpleCombatKillMonster,
				Value = _ifinishkurosimplecombatkillmonster
			};
		}

		// Token: 0x0601ACB9 RID: 109753 RVA: 0x003CDDD2 File Offset: 0x003CBFD2
		public IFinishKurotatoConditionT AsIFinishKurotatoCondition()
		{
			return this.As<IFinishKurotatoConditionT>();
		}

		// Token: 0x0601ACBA RID: 109754 RVA: 0x003CDDDA File Offset: 0x003CBFDA
		public static TChildQuestConditionUnion FromIFinishKurotatoCondition(IFinishKurotatoConditionT _ifinishkurotatocondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishKurotatoCondition,
				Value = _ifinishkurotatocondition
			};
		}

		// Token: 0x0601ACBB RID: 109755 RVA: 0x003CDDF0 File Offset: 0x003CBFF0
		public IFinishRhythmSpaceshipConditionT AsIFinishRhythmSpaceshipCondition()
		{
			return this.As<IFinishRhythmSpaceshipConditionT>();
		}

		// Token: 0x0601ACBC RID: 109756 RVA: 0x003CDDF8 File Offset: 0x003CBFF8
		public static TChildQuestConditionUnion FromIFinishRhythmSpaceshipCondition(IFinishRhythmSpaceshipConditionT _ifinishrhythmspaceshipcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishRhythmSpaceshipCondition,
				Value = _ifinishrhythmspaceshipcondition
			};
		}

		// Token: 0x0601ACBD RID: 109757 RVA: 0x003CDE0E File Offset: 0x003CC00E
		public IFinishRoleTowerConditionT AsIFinishRoleTowerCondition()
		{
			return this.As<IFinishRoleTowerConditionT>();
		}

		// Token: 0x0601ACBE RID: 109758 RVA: 0x003CDE16 File Offset: 0x003CC016
		public static TChildQuestConditionUnion FromIFinishRoleTowerCondition(IFinishRoleTowerConditionT _ifinishroletowercondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishRoleTowerCondition,
				Value = _ifinishroletowercondition
			};
		}

		// Token: 0x0601ACBF RID: 109759 RVA: 0x003CDE2C File Offset: 0x003CC02C
		public IFinishRollBlockT AsIFinishRollBlock()
		{
			return this.As<IFinishRollBlockT>();
		}

		// Token: 0x0601ACC0 RID: 109760 RVA: 0x003CDE34 File Offset: 0x003CC034
		public static TChildQuestConditionUnion FromIFinishRollBlock(IFinishRollBlockT _ifinishrollblock)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishRollBlock,
				Value = _ifinishrollblock
			};
		}

		// Token: 0x0601ACC1 RID: 109761 RVA: 0x003CDE4A File Offset: 0x003CC04A
		public IFinishSurvivorsRougeConditionT AsIFinishSurvivorsRougeCondition()
		{
			return this.As<IFinishSurvivorsRougeConditionT>();
		}

		// Token: 0x0601ACC2 RID: 109762 RVA: 0x003CDE52 File Offset: 0x003CC052
		public static TChildQuestConditionUnion FromIFinishSurvivorsRougeCondition(IFinishSurvivorsRougeConditionT _ifinishsurvivorsrougecondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishSurvivorsRougeCondition,
				Value = _ifinishsurvivorsrougecondition
			};
		}

		// Token: 0x0601ACC3 RID: 109763 RVA: 0x003CDE68 File Offset: 0x003CC068
		public IFinishTetrisT AsIFinishTetris()
		{
			return this.As<IFinishTetrisT>();
		}

		// Token: 0x0601ACC4 RID: 109764 RVA: 0x003CDE70 File Offset: 0x003CC070
		public static TChildQuestConditionUnion FromIFinishTetris(IFinishTetrisT _ifinishtetris)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishTetris,
				Value = _ifinishtetris
			};
		}

		// Token: 0x0601ACC5 RID: 109765 RVA: 0x003CDE86 File Offset: 0x003CC086
		public IFinishTrapDefenseConditionT AsIFinishTrapDefenseCondition()
		{
			return this.As<IFinishTrapDefenseConditionT>();
		}

		// Token: 0x0601ACC6 RID: 109766 RVA: 0x003CDE8E File Offset: 0x003CC08E
		public static TChildQuestConditionUnion FromIFinishTrapDefenseCondition(IFinishTrapDefenseConditionT _ifinishtrapdefensecondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishTrapDefenseCondition,
				Value = _ifinishtrapdefensecondition
			};
		}

		// Token: 0x0601ACC7 RID: 109767 RVA: 0x003CDEA4 File Offset: 0x003CC0A4
		public IGetItemQuestConditionT AsIGetItemQuestCondition()
		{
			return this.As<IGetItemQuestConditionT>();
		}

		// Token: 0x0601ACC8 RID: 109768 RVA: 0x003CDEAC File Offset: 0x003CC0AC
		public static TChildQuestConditionUnion FromIGetItemQuestCondition(IGetItemQuestConditionT _igetitemquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IGetItemQuestCondition,
				Value = _igetitemquestcondition
			};
		}

		// Token: 0x0601ACC9 RID: 109769 RVA: 0x003CDEC2 File Offset: 0x003CC0C2
		public IGetSkillQuestConditionT AsIGetSkillQuestCondition()
		{
			return this.As<IGetSkillQuestConditionT>();
		}

		// Token: 0x0601ACCA RID: 109770 RVA: 0x003CDECA File Offset: 0x003CC0CA
		public static TChildQuestConditionUnion FromIGetSkillQuestCondition(IGetSkillQuestConditionT _igetskillquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IGetSkillQuestCondition,
				Value = _igetskillquestcondition
			};
		}

		// Token: 0x0601ACCB RID: 109771 RVA: 0x003CDEE0 File Offset: 0x003CC0E0
		public IGuideConditionT AsIGuideCondition()
		{
			return this.As<IGuideConditionT>();
		}

		// Token: 0x0601ACCC RID: 109772 RVA: 0x003CDEE8 File Offset: 0x003CC0E8
		public static TChildQuestConditionUnion FromIGuideCondition(IGuideConditionT _iguidecondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IGuideCondition,
				Value = _iguidecondition
			};
		}

		// Token: 0x0601ACCD RID: 109773 RVA: 0x003CDEFE File Offset: 0x003CC0FE
		public IHandInItemsConditionT AsIHandInItemsCondition()
		{
			return this.As<IHandInItemsConditionT>();
		}

		// Token: 0x0601ACCE RID: 109774 RVA: 0x003CDF06 File Offset: 0x003CC106
		public static TChildQuestConditionUnion FromIHandInItemsCondition(IHandInItemsConditionT _ihandinitemscondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IHandInItemsCondition,
				Value = _ihandinitemscondition
			};
		}

		// Token: 0x0601ACCF RID: 109775 RVA: 0x003CDF1C File Offset: 0x003CC11C
		public IInformationViewCheckConditionT AsIInformationViewCheckCondition()
		{
			return this.As<IInformationViewCheckConditionT>();
		}

		// Token: 0x0601ACD0 RID: 109776 RVA: 0x003CDF24 File Offset: 0x003CC124
		public static TChildQuestConditionUnion FromIInformationViewCheckCondition(IInformationViewCheckConditionT _iinformationviewcheckcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IInformationViewCheckCondition,
				Value = _iinformationviewcheckcondition
			};
		}

		// Token: 0x0601ACD1 RID: 109777 RVA: 0x003CDF3A File Offset: 0x003CC13A
		public IKillChildQuestConditionT AsIKillChildQuestCondition()
		{
			return this.As<IKillChildQuestConditionT>();
		}

		// Token: 0x0601ACD2 RID: 109778 RVA: 0x003CDF42 File Offset: 0x003CC142
		public static TChildQuestConditionUnion FromIKillChildQuestCondition(IKillChildQuestConditionT _ikillchildquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IKillChildQuestCondition,
				Value = _ikillchildquestcondition
			};
		}

		// Token: 0x0601ACD3 RID: 109779 RVA: 0x003CDF58 File Offset: 0x003CC158
		public ILeaveDungeonConditionT AsILeaveDungeonCondition()
		{
			return this.As<ILeaveDungeonConditionT>();
		}

		// Token: 0x0601ACD4 RID: 109780 RVA: 0x003CDF60 File Offset: 0x003CC160
		public static TChildQuestConditionUnion FromILeaveDungeonCondition(ILeaveDungeonConditionT _ileavedungeoncondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ILeaveDungeonCondition,
				Value = _ileavedungeoncondition
			};
		}

		// Token: 0x0601ACD5 RID: 109781 RVA: 0x003CDF76 File Offset: 0x003CC176
		public IListenToEventT AsIListenToEvent()
		{
			return this.As<IListenToEventT>();
		}

		// Token: 0x0601ACD6 RID: 109782 RVA: 0x003CDF7E File Offset: 0x003CC17E
		public static TChildQuestConditionUnion FromIListenToEvent(IListenToEventT _ilistentoevent)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IListenToEvent,
				Value = _ilistentoevent
			};
		}

		// Token: 0x0601ACD7 RID: 109783 RVA: 0x003CDF94 File Offset: 0x003CC194
		public IMonsterCreatorQuestConditionT AsIMonsterCreatorQuestCondition()
		{
			return this.As<IMonsterCreatorQuestConditionT>();
		}

		// Token: 0x0601ACD8 RID: 109784 RVA: 0x003CDF9C File Offset: 0x003CC19C
		public static TChildQuestConditionUnion FromIMonsterCreatorQuestCondition(IMonsterCreatorQuestConditionT _imonstercreatorquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IMonsterCreatorQuestCondition,
				Value = _imonstercreatorquestcondition
			};
		}

		// Token: 0x0601ACD9 RID: 109785 RVA: 0x003CDFB2 File Offset: 0x003CC1B2
		public INewHandInItemsConditionT AsINewHandInItemsCondition()
		{
			return this.As<INewHandInItemsConditionT>();
		}

		// Token: 0x0601ACDA RID: 109786 RVA: 0x003CDFBA File Offset: 0x003CC1BA
		public static TChildQuestConditionUnion FromINewHandInItemsCondition(INewHandInItemsConditionT _inewhandinitemscondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.INewHandInItemsCondition,
				Value = _inewhandinitemscondition
			};
		}

		// Token: 0x0601ACDB RID: 109787 RVA: 0x003CDFD0 File Offset: 0x003CC1D0
		public IParallaxAlignQuestConditionT AsIParallaxAlignQuestCondition()
		{
			return this.As<IParallaxAlignQuestConditionT>();
		}

		// Token: 0x0601ACDC RID: 109788 RVA: 0x003CDFD8 File Offset: 0x003CC1D8
		public static TChildQuestConditionUnion FromIParallaxAlignQuestCondition(IParallaxAlignQuestConditionT _iparallaxalignquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IParallaxAlignQuestCondition,
				Value = _iparallaxalignquestcondition
			};
		}

		// Token: 0x0601ACDD RID: 109789 RVA: 0x003CDFEE File Offset: 0x003CC1EE
		public IParkourQuestConditionT AsIParkourQuestCondition()
		{
			return this.As<IParkourQuestConditionT>();
		}

		// Token: 0x0601ACDE RID: 109790 RVA: 0x003CDFF6 File Offset: 0x003CC1F6
		public static TChildQuestConditionUnion FromIParkourQuestCondition(IParkourQuestConditionT _iparkourquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IParkourQuestCondition,
				Value = _iparkourquestcondition
			};
		}

		// Token: 0x0601ACDF RID: 109791 RVA: 0x003CE00C File Offset: 0x003CC20C
		public IPlaybackShowTimelineQuestConditionT AsIPlaybackShowTimelineQuestCondition()
		{
			return this.As<IPlaybackShowTimelineQuestConditionT>();
		}

		// Token: 0x0601ACE0 RID: 109792 RVA: 0x003CE014 File Offset: 0x003CC214
		public static TChildQuestConditionUnion FromIPlaybackShowTimelineQuestCondition(IPlaybackShowTimelineQuestConditionT _iplaybackshowtimelinequestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IPlaybackShowTimelineQuestCondition,
				Value = _iplaybackshowtimelinequestcondition
			};
		}

		// Token: 0x0601ACE1 RID: 109793 RVA: 0x003CE02A File Offset: 0x003CC22A
		public IPlayFlowQuestConditionT AsIPlayFlowQuestCondition()
		{
			return this.As<IPlayFlowQuestConditionT>();
		}

		// Token: 0x0601ACE2 RID: 109794 RVA: 0x003CE032 File Offset: 0x003CC232
		public static TChildQuestConditionUnion FromIPlayFlowQuestCondition(IPlayFlowQuestConditionT _iplayflowquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IPlayFlowQuestCondition,
				Value = _iplayflowquestcondition
			};
		}

		// Token: 0x0601ACE3 RID: 109795 RVA: 0x003CE048 File Offset: 0x003CC248
		public IProgramSpecialProcessT AsIProgramSpecialProcess()
		{
			return this.As<IProgramSpecialProcessT>();
		}

		// Token: 0x0601ACE4 RID: 109796 RVA: 0x003CE050 File Offset: 0x003CC250
		public static TChildQuestConditionUnion FromIProgramSpecialProcess(IProgramSpecialProcessT _iprogramspecialprocess)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IProgramSpecialProcess,
				Value = _iprogramspecialprocess
			};
		}

		// Token: 0x0601ACE5 RID: 109797 RVA: 0x003CE066 File Offset: 0x003CC266
		public IReachAreaQuestConditionT AsIReachAreaQuestCondition()
		{
			return this.As<IReachAreaQuestConditionT>();
		}

		// Token: 0x0601ACE6 RID: 109798 RVA: 0x003CE06E File Offset: 0x003CC26E
		public static TChildQuestConditionUnion FromIReachAreaQuestCondition(IReachAreaQuestConditionT _ireachareaquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IReachAreaQuestCondition,
				Value = _ireachareaquestcondition
			};
		}

		// Token: 0x0601ACE7 RID: 109799 RVA: 0x003CE084 File Offset: 0x003CC284
		public IReadMailConditionT AsIReadMailCondition()
		{
			return this.As<IReadMailConditionT>();
		}

		// Token: 0x0601ACE8 RID: 109800 RVA: 0x003CE08C File Offset: 0x003CC28C
		public static TChildQuestConditionUnion FromIReadMailCondition(IReadMailConditionT _ireadmailcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IReadMailCondition,
				Value = _ireadmailcondition
			};
		}

		// Token: 0x0601ACE9 RID: 109801 RVA: 0x003CE0A2 File Offset: 0x003CC2A2
		public IReadPhoneMessageQuestConditionT AsIReadPhoneMessageQuestCondition()
		{
			return this.As<IReadPhoneMessageQuestConditionT>();
		}

		// Token: 0x0601ACEA RID: 109802 RVA: 0x003CE0AA File Offset: 0x003CC2AA
		public static TChildQuestConditionUnion FromIReadPhoneMessageQuestCondition(IReadPhoneMessageQuestConditionT _ireadphonemessagequestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IReadPhoneMessageQuestCondition,
				Value = _ireadphonemessagequestcondition
			};
		}

		// Token: 0x0601ACEB RID: 109803 RVA: 0x003CE0C0 File Offset: 0x003CC2C0
		public IReceiveTelecomChildQuestConditionT AsIReceiveTelecomChildQuestCondition()
		{
			return this.As<IReceiveTelecomChildQuestConditionT>();
		}

		// Token: 0x0601ACEC RID: 109804 RVA: 0x003CE0C8 File Offset: 0x003CC2C8
		public static TChildQuestConditionUnion FromIReceiveTelecomChildQuestCondition(IReceiveTelecomChildQuestConditionT _ireceivetelecomchildquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IReceiveTelecomChildQuestCondition,
				Value = _ireceivetelecomchildquestcondition
			};
		}

		// Token: 0x0601ACED RID: 109805 RVA: 0x003CE0DE File Offset: 0x003CC2DE
		public IScheduleTimeConditionT AsIScheduleTimeCondition()
		{
			return this.As<IScheduleTimeConditionT>();
		}

		// Token: 0x0601ACEE RID: 109806 RVA: 0x003CE0E6 File Offset: 0x003CC2E6
		public static TChildQuestConditionUnion FromIScheduleTimeCondition(IScheduleTimeConditionT _ischeduletimecondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IScheduleTimeCondition,
				Value = _ischeduletimecondition
			};
		}

		// Token: 0x0601ACEF RID: 109807 RVA: 0x003CE0FC File Offset: 0x003CC2FC
		public IShowUiConditionT AsIShowUiCondition()
		{
			return this.As<IShowUiConditionT>();
		}

		// Token: 0x0601ACF0 RID: 109808 RVA: 0x003CE104 File Offset: 0x003CC304
		public static TChildQuestConditionUnion FromIShowUiCondition(IShowUiConditionT _ishowuicondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IShowUiCondition,
				Value = _ishowuicondition
			};
		}

		// Token: 0x0601ACF1 RID: 109809 RVA: 0x003CE11A File Offset: 0x003CC31A
		public ITakePhoto2ConditionT AsITakePhoto2Condition()
		{
			return this.As<ITakePhoto2ConditionT>();
		}

		// Token: 0x0601ACF2 RID: 109810 RVA: 0x003CE122 File Offset: 0x003CC322
		public static TChildQuestConditionUnion FromITakePhoto2Condition(ITakePhoto2ConditionT _itakephoto2condition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ITakePhoto2Condition,
				Value = _itakephoto2condition
			};
		}

		// Token: 0x0601ACF3 RID: 109811 RVA: 0x003CE138 File Offset: 0x003CC338
		public ITakePhotoConditionT AsITakePhotoCondition()
		{
			return this.As<ITakePhotoConditionT>();
		}

		// Token: 0x0601ACF4 RID: 109812 RVA: 0x003CE140 File Offset: 0x003CC340
		public static TChildQuestConditionUnion FromITakePhotoCondition(ITakePhotoConditionT _itakephotocondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ITakePhotoCondition,
				Value = _itakephotocondition
			};
		}

		// Token: 0x0601ACF5 RID: 109813 RVA: 0x003CE156 File Offset: 0x003CC356
		public ITimerQuestConditionT AsITimerQuestCondition()
		{
			return this.As<ITimerQuestConditionT>();
		}

		// Token: 0x0601ACF6 RID: 109814 RVA: 0x003CE15E File Offset: 0x003CC35E
		public static TChildQuestConditionUnion FromITimerQuestCondition(ITimerQuestConditionT _itimerquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ITimerQuestCondition,
				Value = _itimerquestcondition
			};
		}

		// Token: 0x0601ACF7 RID: 109815 RVA: 0x003CE174 File Offset: 0x003CC374
		public ITimeScaledPhotographT AsITimeScaledPhotograph()
		{
			return this.As<ITimeScaledPhotographT>();
		}

		// Token: 0x0601ACF8 RID: 109816 RVA: 0x003CE17C File Offset: 0x003CC37C
		public static TChildQuestConditionUnion FromITimeScaledPhotograph(ITimeScaledPhotographT _itimescaledphotograph)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ITimeScaledPhotograph,
				Value = _itimescaledphotograph
			};
		}

		// Token: 0x0601ACF9 RID: 109817 RVA: 0x003CE192 File Offset: 0x003CC392
		public IUseItemConditionT AsIUseItemCondition()
		{
			return this.As<IUseItemConditionT>();
		}

		// Token: 0x0601ACFA RID: 109818 RVA: 0x003CE19A File Offset: 0x003CC39A
		public static TChildQuestConditionUnion FromIUseItemCondition(IUseItemConditionT _iuseitemcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IUseItemCondition,
				Value = _iuseitemcondition
			};
		}

		// Token: 0x0601ACFB RID: 109819 RVA: 0x003CE1B0 File Offset: 0x003CC3B0
		public IUseSkillQuestConditionT AsIUseSkillQuestCondition()
		{
			return this.As<IUseSkillQuestConditionT>();
		}

		// Token: 0x0601ACFC RID: 109820 RVA: 0x003CE1B8 File Offset: 0x003CC3B8
		public static TChildQuestConditionUnion FromIUseSkillQuestCondition(IUseSkillQuestConditionT _iuseskillquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IUseSkillQuestCondition,
				Value = _iuseskillquestcondition
			};
		}

		// Token: 0x0601ACFD RID: 109821 RVA: 0x003CE1CE File Offset: 0x003CC3CE
		public IUseWeatherSwitchConditionT AsIUseWeatherSwitchCondition()
		{
			return this.As<IUseWeatherSwitchConditionT>();
		}

		// Token: 0x0601ACFE RID: 109822 RVA: 0x003CE1D6 File Offset: 0x003CC3D6
		public static TChildQuestConditionUnion FromIUseWeatherSwitchCondition(IUseWeatherSwitchConditionT _iuseweatherswitchcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IUseWeatherSwitchCondition,
				Value = _iuseweatherswitchcondition
			};
		}

		// Token: 0x0601ACFF RID: 109823 RVA: 0x003CE1EC File Offset: 0x003CC3EC
		public IVisionSystemQuestConditionT AsIVisionSystemQuestCondition()
		{
			return this.As<IVisionSystemQuestConditionT>();
		}

		// Token: 0x0601AD00 RID: 109824 RVA: 0x003CE1F4 File Offset: 0x003CC3F4
		public static TChildQuestConditionUnion FromIVisionSystemQuestCondition(IVisionSystemQuestConditionT _ivisionsystemquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IVisionSystemQuestCondition,
				Value = _ivisionsystemquestcondition
			};
		}

		// Token: 0x0601AD01 RID: 109825 RVA: 0x003CE20A File Offset: 0x003CC40A
		public IWaitBattleConditionT AsIWaitBattleCondition()
		{
			return this.As<IWaitBattleConditionT>();
		}

		// Token: 0x0601AD02 RID: 109826 RVA: 0x003CE212 File Offset: 0x003CC412
		public static TChildQuestConditionUnion FromIWaitBattleCondition(IWaitBattleConditionT _iwaitbattlecondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IWaitBattleCondition,
				Value = _iwaitbattlecondition
			};
		}

		// Token: 0x0601AD03 RID: 109827 RVA: 0x003CE228 File Offset: 0x003CC428
		public IWaitTimeConditionT AsIWaitTimeCondition()
		{
			return this.As<IWaitTimeConditionT>();
		}

		// Token: 0x0601AD04 RID: 109828 RVA: 0x003CE230 File Offset: 0x003CC430
		public static TChildQuestConditionUnion FromIWaitTimeCondition(IWaitTimeConditionT _iwaittimecondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IWaitTimeCondition,
				Value = _iwaittimecondition
			};
		}

		// Token: 0x0601AD05 RID: 109829 RVA: 0x003CE246 File Offset: 0x003CC446
		public IWaitUntilLevelSequenceReachMarkT AsIWaitUntilLevelSequenceReachMark()
		{
			return this.As<IWaitUntilLevelSequenceReachMarkT>();
		}

		// Token: 0x0601AD06 RID: 109830 RVA: 0x003CE24E File Offset: 0x003CC44E
		public static TChildQuestConditionUnion FromIWaitUntilLevelSequenceReachMark(IWaitUntilLevelSequenceReachMarkT _iwaituntillevelsequencereachmark)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IWaitUntilLevelSequenceReachMark,
				Value = _iwaituntillevelsequencereachmark
			};
		}

		// Token: 0x0601AD07 RID: 109831 RVA: 0x003CE264 File Offset: 0x003CC464
		public IWalkingPatternConditionT AsIWalkingPatternCondition()
		{
			return this.As<IWalkingPatternConditionT>();
		}

		// Token: 0x0601AD08 RID: 109832 RVA: 0x003CE26C File Offset: 0x003CC46C
		public static TChildQuestConditionUnion FromIWalkingPatternCondition(IWalkingPatternConditionT _iwalkingpatterncondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IWalkingPatternCondition,
				Value = _iwalkingpatterncondition
			};
		}

		// Token: 0x0601AD09 RID: 109833 RVA: 0x003CE284 File Offset: 0x003CC484
		public static int Pack(FlatBufferBuilder builder, TChildQuestConditionUnion _o)
		{
			switch (_o.Type)
			{
			case TChildQuestCondition.IAtomicProcess:
				return IAtomicProcess.Pack(builder, _o.AsIAtomicProcess()).Value;
			case TChildQuestCondition.IAwakeAndLoadEntityCondition:
				return IAwakeAndLoadEntityCondition.Pack(builder, _o.AsIAwakeAndLoadEntityCondition()).Value;
			case TChildQuestCondition.ICheckActivityStateCondition:
				return ICheckActivityStateCondition.Pack(builder, _o.AsICheckActivityStateCondition()).Value;
			case TChildQuestCondition.ICheckClientConditionGroupQuestCondition:
				return ICheckClientConditionGroupQuestCondition.Pack(builder, _o.AsICheckClientConditionGroupQuestCondition()).Value;
			case TChildQuestCondition.ICheckConditionGroupQuestCondition:
				return ICheckConditionGroupQuestCondition.Pack(builder, _o.AsICheckConditionGroupQuestCondition()).Value;
			case TChildQuestCondition.ICheckEntityStateQuestCondition:
				return ICheckEntityStateQuestCondition.Pack(builder, _o.AsICheckEntityStateQuestCondition()).Value;
			case TChildQuestCondition.ICheckLevelPlayQuestCondition:
				return ICheckLevelPlayQuestCondition.Pack(builder, _o.AsICheckLevelPlayQuestCondition()).Value;
			case TChildQuestCondition.ICheckPlayerInputCondition:
				return ICheckPlayerInputCondition.Pack(builder, _o.AsICheckPlayerInputCondition()).Value;
			case TChildQuestCondition.ICheckSpringFestivalGameplayCompleted:
				return ICheckSpringFestivalGameplayCompleted.Pack(builder, _o.AsICheckSpringFestivalGameplayCompleted()).Value;
			case TChildQuestCondition.ICheckTargetBattleAttributeCondition:
				return ICheckTargetBattleAttributeCondition.Pack(builder, _o.AsICheckTargetBattleAttributeCondition()).Value;
			case TChildQuestCondition.ICheckTrapDefenseEventCondition:
				return ICheckTrapDefenseEventCondition.Pack(builder, _o.AsICheckTrapDefenseEventCondition()).Value;
			case TChildQuestCondition.ICheckUiGameQuestCondition:
				return ICheckUiGameQuestCondition.Pack(builder, _o.AsICheckUiGameQuestCondition()).Value;
			case TChildQuestCondition.ICompareActorVar:
				return ICompareActorVar.Pack(builder, _o.AsICompareActorVar()).Value;
			case TChildQuestCondition.ICompareVarConditionInChildQuest:
				return ICompareVarConditionInChildQuest.Pack(builder, _o.AsICompareVarConditionInChildQuest()).Value;
			case TChildQuestCondition.ICrossSceneSyncKillMonster:
				return ICrossSceneSyncKillMonster.Pack(builder, _o.AsICrossSceneSyncKillMonster()).Value;
			case TChildQuestCondition.IDetectCombatState2Condition:
				return IDetectCombatState2Condition.Pack(builder, _o.AsIDetectCombatState2Condition()).Value;
			case TChildQuestCondition.IDetectCombatStateCondition:
				return IDetectCombatStateCondition.Pack(builder, _o.AsIDetectCombatStateCondition()).Value;
			case TChildQuestCondition.IDoInteractQuestCondition:
				return IDoInteractQuestCondition.Pack(builder, _o.AsIDoInteractQuestCondition()).Value;
			case TChildQuestCondition.IEnterDungeonCondition:
				return IEnterDungeonCondition.Pack(builder, _o.AsIEnterDungeonCondition()).Value;
			case TChildQuestCondition.IFinishArcadeGameplay:
				return IFinishArcadeGameplay.Pack(builder, _o.AsIFinishArcadeGameplay()).Value;
			case TChildQuestCondition.IFinishBvbChallenge:
				return IFinishBvbChallenge.Pack(builder, _o.AsIFinishBvbChallenge()).Value;
			case TChildQuestCondition.IFinishDungeonQuestCondition:
				return IFinishDungeonQuestCondition.Pack(builder, _o.AsIFinishDungeonQuestCondition()).Value;
			case TChildQuestCondition.IFinishFlipperCondition:
				return IFinishFlipperCondition.Pack(builder, _o.AsIFinishFlipperCondition()).Value;
			case TChildQuestCondition.IFinishJellyfishReturnCondition:
				return IFinishJellyfishReturnCondition.Pack(builder, _o.AsIFinishJellyfishReturnCondition()).Value;
			case TChildQuestCondition.IFinishKuroSimpleCombatKillMonster:
				return IFinishKuroSimpleCombatKillMonster.Pack(builder, _o.AsIFinishKuroSimpleCombatKillMonster()).Value;
			case TChildQuestCondition.IFinishKurotatoCondition:
				return IFinishKurotatoCondition.Pack(builder, _o.AsIFinishKurotatoCondition()).Value;
			case TChildQuestCondition.IFinishRhythmSpaceshipCondition:
				return IFinishRhythmSpaceshipCondition.Pack(builder, _o.AsIFinishRhythmSpaceshipCondition()).Value;
			case TChildQuestCondition.IFinishRoleTowerCondition:
				return IFinishRoleTowerCondition.Pack(builder, _o.AsIFinishRoleTowerCondition()).Value;
			case TChildQuestCondition.IFinishRollBlock:
				return IFinishRollBlock.Pack(builder, _o.AsIFinishRollBlock()).Value;
			case TChildQuestCondition.IFinishSurvivorsRougeCondition:
				return IFinishSurvivorsRougeCondition.Pack(builder, _o.AsIFinishSurvivorsRougeCondition()).Value;
			case TChildQuestCondition.IFinishTetris:
				return IFinishTetris.Pack(builder, _o.AsIFinishTetris()).Value;
			case TChildQuestCondition.IFinishTrapDefenseCondition:
				return IFinishTrapDefenseCondition.Pack(builder, _o.AsIFinishTrapDefenseCondition()).Value;
			case TChildQuestCondition.IGetItemQuestCondition:
				return IGetItemQuestCondition.Pack(builder, _o.AsIGetItemQuestCondition()).Value;
			case TChildQuestCondition.IGetSkillQuestCondition:
				return IGetSkillQuestCondition.Pack(builder, _o.AsIGetSkillQuestCondition()).Value;
			case TChildQuestCondition.IGuideCondition:
				return IGuideCondition.Pack(builder, _o.AsIGuideCondition()).Value;
			case TChildQuestCondition.IHandInItemsCondition:
				return IHandInItemsCondition.Pack(builder, _o.AsIHandInItemsCondition()).Value;
			case TChildQuestCondition.IInformationViewCheckCondition:
				return IInformationViewCheckCondition.Pack(builder, _o.AsIInformationViewCheckCondition()).Value;
			case TChildQuestCondition.IKillChildQuestCondition:
				return IKillChildQuestCondition.Pack(builder, _o.AsIKillChildQuestCondition()).Value;
			case TChildQuestCondition.ILeaveDungeonCondition:
				return ILeaveDungeonCondition.Pack(builder, _o.AsILeaveDungeonCondition()).Value;
			case TChildQuestCondition.IListenToEvent:
				return IListenToEvent.Pack(builder, _o.AsIListenToEvent()).Value;
			case TChildQuestCondition.IMonsterCreatorQuestCondition:
				return IMonsterCreatorQuestCondition.Pack(builder, _o.AsIMonsterCreatorQuestCondition()).Value;
			case TChildQuestCondition.INewHandInItemsCondition:
				return INewHandInItemsCondition.Pack(builder, _o.AsINewHandInItemsCondition()).Value;
			case TChildQuestCondition.IParallaxAlignQuestCondition:
				return IParallaxAlignQuestCondition.Pack(builder, _o.AsIParallaxAlignQuestCondition()).Value;
			case TChildQuestCondition.IParkourQuestCondition:
				return IParkourQuestCondition.Pack(builder, _o.AsIParkourQuestCondition()).Value;
			case TChildQuestCondition.IPlaybackShowTimelineQuestCondition:
				return IPlaybackShowTimelineQuestCondition.Pack(builder, _o.AsIPlaybackShowTimelineQuestCondition()).Value;
			case TChildQuestCondition.IPlayFlowQuestCondition:
				return IPlayFlowQuestCondition.Pack(builder, _o.AsIPlayFlowQuestCondition()).Value;
			case TChildQuestCondition.IProgramSpecialProcess:
				return IProgramSpecialProcess.Pack(builder, _o.AsIProgramSpecialProcess()).Value;
			case TChildQuestCondition.IReachAreaQuestCondition:
				return IReachAreaQuestCondition.Pack(builder, _o.AsIReachAreaQuestCondition()).Value;
			case TChildQuestCondition.IReadMailCondition:
				return IReadMailCondition.Pack(builder, _o.AsIReadMailCondition()).Value;
			case TChildQuestCondition.IReadPhoneMessageQuestCondition:
				return IReadPhoneMessageQuestCondition.Pack(builder, _o.AsIReadPhoneMessageQuestCondition()).Value;
			case TChildQuestCondition.IReceiveTelecomChildQuestCondition:
				return IReceiveTelecomChildQuestCondition.Pack(builder, _o.AsIReceiveTelecomChildQuestCondition()).Value;
			case TChildQuestCondition.IScheduleTimeCondition:
				return IScheduleTimeCondition.Pack(builder, _o.AsIScheduleTimeCondition()).Value;
			case TChildQuestCondition.IShowUiCondition:
				return IShowUiCondition.Pack(builder, _o.AsIShowUiCondition()).Value;
			case TChildQuestCondition.ITakePhoto2Condition:
				return ITakePhoto2Condition.Pack(builder, _o.AsITakePhoto2Condition()).Value;
			case TChildQuestCondition.ITakePhotoCondition:
				return ITakePhotoCondition.Pack(builder, _o.AsITakePhotoCondition()).Value;
			case TChildQuestCondition.ITimerQuestCondition:
				return ITimerQuestCondition.Pack(builder, _o.AsITimerQuestCondition()).Value;
			case TChildQuestCondition.ITimeScaledPhotograph:
				return ITimeScaledPhotograph.Pack(builder, _o.AsITimeScaledPhotograph()).Value;
			case TChildQuestCondition.IUseItemCondition:
				return IUseItemCondition.Pack(builder, _o.AsIUseItemCondition()).Value;
			case TChildQuestCondition.IUseSkillQuestCondition:
				return IUseSkillQuestCondition.Pack(builder, _o.AsIUseSkillQuestCondition()).Value;
			case TChildQuestCondition.IUseWeatherSwitchCondition:
				return IUseWeatherSwitchCondition.Pack(builder, _o.AsIUseWeatherSwitchCondition()).Value;
			case TChildQuestCondition.IVisionSystemQuestCondition:
				return IVisionSystemQuestCondition.Pack(builder, _o.AsIVisionSystemQuestCondition()).Value;
			case TChildQuestCondition.IWaitBattleCondition:
				return IWaitBattleCondition.Pack(builder, _o.AsIWaitBattleCondition()).Value;
			case TChildQuestCondition.IWaitTimeCondition:
				return IWaitTimeCondition.Pack(builder, _o.AsIWaitTimeCondition()).Value;
			case TChildQuestCondition.IWaitUntilLevelSequenceReachMark:
				return IWaitUntilLevelSequenceReachMark.Pack(builder, _o.AsIWaitUntilLevelSequenceReachMark()).Value;
			case TChildQuestCondition.IWalkingPatternCondition:
				return IWalkingPatternCondition.Pack(builder, _o.AsIWalkingPatternCondition()).Value;
			default:
				return 0;
			}
		}
	}
}

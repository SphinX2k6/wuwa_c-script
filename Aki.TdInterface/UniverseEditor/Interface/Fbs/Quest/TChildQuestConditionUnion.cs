using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042C1 RID: 17089
	public class TChildQuestConditionUnion
	{
		// Token: 0x17007935 RID: 31029
		// (get) Token: 0x06019515 RID: 103701 RVA: 0x003A23CA File Offset: 0x003A05CA
		// (set) Token: 0x06019516 RID: 103702 RVA: 0x003A23D2 File Offset: 0x003A05D2
		public TChildQuestCondition Type { get; set; }

		// Token: 0x17007936 RID: 31030
		// (get) Token: 0x06019517 RID: 103703 RVA: 0x003A23DB File Offset: 0x003A05DB
		// (set) Token: 0x06019518 RID: 103704 RVA: 0x003A23E3 File Offset: 0x003A05E3
		public object Value { get; set; }

		// Token: 0x06019519 RID: 103705 RVA: 0x003A23EC File Offset: 0x003A05EC
		public TChildQuestConditionUnion()
		{
			this.Type = TChildQuestCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0601951A RID: 103706 RVA: 0x003A2402 File Offset: 0x003A0602
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601951B RID: 103707 RVA: 0x003A2414 File Offset: 0x003A0614
		public IAtomicProcessT AsIAtomicProcess()
		{
			return this.As<IAtomicProcessT>();
		}

		// Token: 0x0601951C RID: 103708 RVA: 0x003A241C File Offset: 0x003A061C
		public static TChildQuestConditionUnion FromIAtomicProcess(IAtomicProcessT _iatomicprocess)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IAtomicProcess,
				Value = _iatomicprocess
			};
		}

		// Token: 0x0601951D RID: 103709 RVA: 0x003A2431 File Offset: 0x003A0631
		public IAwakeAndLoadEntityConditionT AsIAwakeAndLoadEntityCondition()
		{
			return this.As<IAwakeAndLoadEntityConditionT>();
		}

		// Token: 0x0601951E RID: 103710 RVA: 0x003A2439 File Offset: 0x003A0639
		public static TChildQuestConditionUnion FromIAwakeAndLoadEntityCondition(IAwakeAndLoadEntityConditionT _iawakeandloadentitycondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IAwakeAndLoadEntityCondition,
				Value = _iawakeandloadentitycondition
			};
		}

		// Token: 0x0601951F RID: 103711 RVA: 0x003A244E File Offset: 0x003A064E
		public ICheckActivityStateConditionT AsICheckActivityStateCondition()
		{
			return this.As<ICheckActivityStateConditionT>();
		}

		// Token: 0x06019520 RID: 103712 RVA: 0x003A2456 File Offset: 0x003A0656
		public static TChildQuestConditionUnion FromICheckActivityStateCondition(ICheckActivityStateConditionT _icheckactivitystatecondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICheckActivityStateCondition,
				Value = _icheckactivitystatecondition
			};
		}

		// Token: 0x06019521 RID: 103713 RVA: 0x003A246B File Offset: 0x003A066B
		public ICheckClientConditionGroupQuestConditionT AsICheckClientConditionGroupQuestCondition()
		{
			return this.As<ICheckClientConditionGroupQuestConditionT>();
		}

		// Token: 0x06019522 RID: 103714 RVA: 0x003A2473 File Offset: 0x003A0673
		public static TChildQuestConditionUnion FromICheckClientConditionGroupQuestCondition(ICheckClientConditionGroupQuestConditionT _icheckclientconditiongroupquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICheckClientConditionGroupQuestCondition,
				Value = _icheckclientconditiongroupquestcondition
			};
		}

		// Token: 0x06019523 RID: 103715 RVA: 0x003A2488 File Offset: 0x003A0688
		public ICheckConditionGroupQuestConditionT AsICheckConditionGroupQuestCondition()
		{
			return this.As<ICheckConditionGroupQuestConditionT>();
		}

		// Token: 0x06019524 RID: 103716 RVA: 0x003A2490 File Offset: 0x003A0690
		public static TChildQuestConditionUnion FromICheckConditionGroupQuestCondition(ICheckConditionGroupQuestConditionT _icheckconditiongroupquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICheckConditionGroupQuestCondition,
				Value = _icheckconditiongroupquestcondition
			};
		}

		// Token: 0x06019525 RID: 103717 RVA: 0x003A24A5 File Offset: 0x003A06A5
		public ICheckEntityStateQuestConditionT AsICheckEntityStateQuestCondition()
		{
			return this.As<ICheckEntityStateQuestConditionT>();
		}

		// Token: 0x06019526 RID: 103718 RVA: 0x003A24AD File Offset: 0x003A06AD
		public static TChildQuestConditionUnion FromICheckEntityStateQuestCondition(ICheckEntityStateQuestConditionT _icheckentitystatequestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICheckEntityStateQuestCondition,
				Value = _icheckentitystatequestcondition
			};
		}

		// Token: 0x06019527 RID: 103719 RVA: 0x003A24C2 File Offset: 0x003A06C2
		public ICheckLevelPlayQuestConditionT AsICheckLevelPlayQuestCondition()
		{
			return this.As<ICheckLevelPlayQuestConditionT>();
		}

		// Token: 0x06019528 RID: 103720 RVA: 0x003A24CA File Offset: 0x003A06CA
		public static TChildQuestConditionUnion FromICheckLevelPlayQuestCondition(ICheckLevelPlayQuestConditionT _ichecklevelplayquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICheckLevelPlayQuestCondition,
				Value = _ichecklevelplayquestcondition
			};
		}

		// Token: 0x06019529 RID: 103721 RVA: 0x003A24DF File Offset: 0x003A06DF
		public ICheckPlayerInputConditionT AsICheckPlayerInputCondition()
		{
			return this.As<ICheckPlayerInputConditionT>();
		}

		// Token: 0x0601952A RID: 103722 RVA: 0x003A24E7 File Offset: 0x003A06E7
		public static TChildQuestConditionUnion FromICheckPlayerInputCondition(ICheckPlayerInputConditionT _icheckplayerinputcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICheckPlayerInputCondition,
				Value = _icheckplayerinputcondition
			};
		}

		// Token: 0x0601952B RID: 103723 RVA: 0x003A24FC File Offset: 0x003A06FC
		public ICheckSpringFestivalGameplayCompletedT AsICheckSpringFestivalGameplayCompleted()
		{
			return this.As<ICheckSpringFestivalGameplayCompletedT>();
		}

		// Token: 0x0601952C RID: 103724 RVA: 0x003A2504 File Offset: 0x003A0704
		public static TChildQuestConditionUnion FromICheckSpringFestivalGameplayCompleted(ICheckSpringFestivalGameplayCompletedT _icheckspringfestivalgameplaycompleted)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICheckSpringFestivalGameplayCompleted,
				Value = _icheckspringfestivalgameplaycompleted
			};
		}

		// Token: 0x0601952D RID: 103725 RVA: 0x003A251A File Offset: 0x003A071A
		public ICheckTargetBattleAttributeConditionT AsICheckTargetBattleAttributeCondition()
		{
			return this.As<ICheckTargetBattleAttributeConditionT>();
		}

		// Token: 0x0601952E RID: 103726 RVA: 0x003A2522 File Offset: 0x003A0722
		public static TChildQuestConditionUnion FromICheckTargetBattleAttributeCondition(ICheckTargetBattleAttributeConditionT _ichecktargetbattleattributecondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICheckTargetBattleAttributeCondition,
				Value = _ichecktargetbattleattributecondition
			};
		}

		// Token: 0x0601952F RID: 103727 RVA: 0x003A2538 File Offset: 0x003A0738
		public ICheckTrapDefenseEventConditionT AsICheckTrapDefenseEventCondition()
		{
			return this.As<ICheckTrapDefenseEventConditionT>();
		}

		// Token: 0x06019530 RID: 103728 RVA: 0x003A2540 File Offset: 0x003A0740
		public static TChildQuestConditionUnion FromICheckTrapDefenseEventCondition(ICheckTrapDefenseEventConditionT _ichecktrapdefenseeventcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICheckTrapDefenseEventCondition,
				Value = _ichecktrapdefenseeventcondition
			};
		}

		// Token: 0x06019531 RID: 103729 RVA: 0x003A2556 File Offset: 0x003A0756
		public ICheckUiGameQuestConditionT AsICheckUiGameQuestCondition()
		{
			return this.As<ICheckUiGameQuestConditionT>();
		}

		// Token: 0x06019532 RID: 103730 RVA: 0x003A255E File Offset: 0x003A075E
		public static TChildQuestConditionUnion FromICheckUiGameQuestCondition(ICheckUiGameQuestConditionT _icheckuigamequestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICheckUiGameQuestCondition,
				Value = _icheckuigamequestcondition
			};
		}

		// Token: 0x06019533 RID: 103731 RVA: 0x003A2574 File Offset: 0x003A0774
		public ICompareActorVarT AsICompareActorVar()
		{
			return this.As<ICompareActorVarT>();
		}

		// Token: 0x06019534 RID: 103732 RVA: 0x003A257C File Offset: 0x003A077C
		public static TChildQuestConditionUnion FromICompareActorVar(ICompareActorVarT _icompareactorvar)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICompareActorVar,
				Value = _icompareactorvar
			};
		}

		// Token: 0x06019535 RID: 103733 RVA: 0x003A2592 File Offset: 0x003A0792
		public ICompareVarConditionInChildQuestT AsICompareVarConditionInChildQuest()
		{
			return this.As<ICompareVarConditionInChildQuestT>();
		}

		// Token: 0x06019536 RID: 103734 RVA: 0x003A259A File Offset: 0x003A079A
		public static TChildQuestConditionUnion FromICompareVarConditionInChildQuest(ICompareVarConditionInChildQuestT _icomparevarconditioninchildquest)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICompareVarConditionInChildQuest,
				Value = _icomparevarconditioninchildquest
			};
		}

		// Token: 0x06019537 RID: 103735 RVA: 0x003A25B0 File Offset: 0x003A07B0
		public ICrossSceneSyncKillMonsterT AsICrossSceneSyncKillMonster()
		{
			return this.As<ICrossSceneSyncKillMonsterT>();
		}

		// Token: 0x06019538 RID: 103736 RVA: 0x003A25B8 File Offset: 0x003A07B8
		public static TChildQuestConditionUnion FromICrossSceneSyncKillMonster(ICrossSceneSyncKillMonsterT _icrossscenesynckillmonster)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ICrossSceneSyncKillMonster,
				Value = _icrossscenesynckillmonster
			};
		}

		// Token: 0x06019539 RID: 103737 RVA: 0x003A25CE File Offset: 0x003A07CE
		public IDetectCombatState2ConditionT AsIDetectCombatState2Condition()
		{
			return this.As<IDetectCombatState2ConditionT>();
		}

		// Token: 0x0601953A RID: 103738 RVA: 0x003A25D6 File Offset: 0x003A07D6
		public static TChildQuestConditionUnion FromIDetectCombatState2Condition(IDetectCombatState2ConditionT _idetectcombatstate2condition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IDetectCombatState2Condition,
				Value = _idetectcombatstate2condition
			};
		}

		// Token: 0x0601953B RID: 103739 RVA: 0x003A25EC File Offset: 0x003A07EC
		public IDetectCombatStateConditionT AsIDetectCombatStateCondition()
		{
			return this.As<IDetectCombatStateConditionT>();
		}

		// Token: 0x0601953C RID: 103740 RVA: 0x003A25F4 File Offset: 0x003A07F4
		public static TChildQuestConditionUnion FromIDetectCombatStateCondition(IDetectCombatStateConditionT _idetectcombatstatecondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IDetectCombatStateCondition,
				Value = _idetectcombatstatecondition
			};
		}

		// Token: 0x0601953D RID: 103741 RVA: 0x003A260A File Offset: 0x003A080A
		public IDoInteractQuestConditionT AsIDoInteractQuestCondition()
		{
			return this.As<IDoInteractQuestConditionT>();
		}

		// Token: 0x0601953E RID: 103742 RVA: 0x003A2612 File Offset: 0x003A0812
		public static TChildQuestConditionUnion FromIDoInteractQuestCondition(IDoInteractQuestConditionT _idointeractquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IDoInteractQuestCondition,
				Value = _idointeractquestcondition
			};
		}

		// Token: 0x0601953F RID: 103743 RVA: 0x003A2628 File Offset: 0x003A0828
		public IEnterDungeonConditionT AsIEnterDungeonCondition()
		{
			return this.As<IEnterDungeonConditionT>();
		}

		// Token: 0x06019540 RID: 103744 RVA: 0x003A2630 File Offset: 0x003A0830
		public static TChildQuestConditionUnion FromIEnterDungeonCondition(IEnterDungeonConditionT _ienterdungeoncondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IEnterDungeonCondition,
				Value = _ienterdungeoncondition
			};
		}

		// Token: 0x06019541 RID: 103745 RVA: 0x003A2646 File Offset: 0x003A0846
		public IFinishArcadeGameplayT AsIFinishArcadeGameplay()
		{
			return this.As<IFinishArcadeGameplayT>();
		}

		// Token: 0x06019542 RID: 103746 RVA: 0x003A264E File Offset: 0x003A084E
		public static TChildQuestConditionUnion FromIFinishArcadeGameplay(IFinishArcadeGameplayT _ifinisharcadegameplay)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishArcadeGameplay,
				Value = _ifinisharcadegameplay
			};
		}

		// Token: 0x06019543 RID: 103747 RVA: 0x003A2664 File Offset: 0x003A0864
		public IFinishBvbChallengeT AsIFinishBvbChallenge()
		{
			return this.As<IFinishBvbChallengeT>();
		}

		// Token: 0x06019544 RID: 103748 RVA: 0x003A266C File Offset: 0x003A086C
		public static TChildQuestConditionUnion FromIFinishBvbChallenge(IFinishBvbChallengeT _ifinishbvbchallenge)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishBvbChallenge,
				Value = _ifinishbvbchallenge
			};
		}

		// Token: 0x06019545 RID: 103749 RVA: 0x003A2682 File Offset: 0x003A0882
		public IFinishDungeonQuestConditionT AsIFinishDungeonQuestCondition()
		{
			return this.As<IFinishDungeonQuestConditionT>();
		}

		// Token: 0x06019546 RID: 103750 RVA: 0x003A268A File Offset: 0x003A088A
		public static TChildQuestConditionUnion FromIFinishDungeonQuestCondition(IFinishDungeonQuestConditionT _ifinishdungeonquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishDungeonQuestCondition,
				Value = _ifinishdungeonquestcondition
			};
		}

		// Token: 0x06019547 RID: 103751 RVA: 0x003A26A0 File Offset: 0x003A08A0
		public IFinishFlipperConditionT AsIFinishFlipperCondition()
		{
			return this.As<IFinishFlipperConditionT>();
		}

		// Token: 0x06019548 RID: 103752 RVA: 0x003A26A8 File Offset: 0x003A08A8
		public static TChildQuestConditionUnion FromIFinishFlipperCondition(IFinishFlipperConditionT _ifinishflippercondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishFlipperCondition,
				Value = _ifinishflippercondition
			};
		}

		// Token: 0x06019549 RID: 103753 RVA: 0x003A26BE File Offset: 0x003A08BE
		public IFinishJellyfishReturnConditionT AsIFinishJellyfishReturnCondition()
		{
			return this.As<IFinishJellyfishReturnConditionT>();
		}

		// Token: 0x0601954A RID: 103754 RVA: 0x003A26C6 File Offset: 0x003A08C6
		public static TChildQuestConditionUnion FromIFinishJellyfishReturnCondition(IFinishJellyfishReturnConditionT _ifinishjellyfishreturncondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishJellyfishReturnCondition,
				Value = _ifinishjellyfishreturncondition
			};
		}

		// Token: 0x0601954B RID: 103755 RVA: 0x003A26DC File Offset: 0x003A08DC
		public IFinishKuroSimpleCombatKillMonsterT AsIFinishKuroSimpleCombatKillMonster()
		{
			return this.As<IFinishKuroSimpleCombatKillMonsterT>();
		}

		// Token: 0x0601954C RID: 103756 RVA: 0x003A26E4 File Offset: 0x003A08E4
		public static TChildQuestConditionUnion FromIFinishKuroSimpleCombatKillMonster(IFinishKuroSimpleCombatKillMonsterT _ifinishkurosimplecombatkillmonster)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishKuroSimpleCombatKillMonster,
				Value = _ifinishkurosimplecombatkillmonster
			};
		}

		// Token: 0x0601954D RID: 103757 RVA: 0x003A26FA File Offset: 0x003A08FA
		public IFinishKurotatoConditionT AsIFinishKurotatoCondition()
		{
			return this.As<IFinishKurotatoConditionT>();
		}

		// Token: 0x0601954E RID: 103758 RVA: 0x003A2702 File Offset: 0x003A0902
		public static TChildQuestConditionUnion FromIFinishKurotatoCondition(IFinishKurotatoConditionT _ifinishkurotatocondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishKurotatoCondition,
				Value = _ifinishkurotatocondition
			};
		}

		// Token: 0x0601954F RID: 103759 RVA: 0x003A2718 File Offset: 0x003A0918
		public IFinishRhythmSpaceshipConditionT AsIFinishRhythmSpaceshipCondition()
		{
			return this.As<IFinishRhythmSpaceshipConditionT>();
		}

		// Token: 0x06019550 RID: 103760 RVA: 0x003A2720 File Offset: 0x003A0920
		public static TChildQuestConditionUnion FromIFinishRhythmSpaceshipCondition(IFinishRhythmSpaceshipConditionT _ifinishrhythmspaceshipcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishRhythmSpaceshipCondition,
				Value = _ifinishrhythmspaceshipcondition
			};
		}

		// Token: 0x06019551 RID: 103761 RVA: 0x003A2736 File Offset: 0x003A0936
		public IFinishRoleTowerConditionT AsIFinishRoleTowerCondition()
		{
			return this.As<IFinishRoleTowerConditionT>();
		}

		// Token: 0x06019552 RID: 103762 RVA: 0x003A273E File Offset: 0x003A093E
		public static TChildQuestConditionUnion FromIFinishRoleTowerCondition(IFinishRoleTowerConditionT _ifinishroletowercondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishRoleTowerCondition,
				Value = _ifinishroletowercondition
			};
		}

		// Token: 0x06019553 RID: 103763 RVA: 0x003A2754 File Offset: 0x003A0954
		public IFinishRollBlockT AsIFinishRollBlock()
		{
			return this.As<IFinishRollBlockT>();
		}

		// Token: 0x06019554 RID: 103764 RVA: 0x003A275C File Offset: 0x003A095C
		public static TChildQuestConditionUnion FromIFinishRollBlock(IFinishRollBlockT _ifinishrollblock)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishRollBlock,
				Value = _ifinishrollblock
			};
		}

		// Token: 0x06019555 RID: 103765 RVA: 0x003A2772 File Offset: 0x003A0972
		public IFinishSurvivorsRougeConditionT AsIFinishSurvivorsRougeCondition()
		{
			return this.As<IFinishSurvivorsRougeConditionT>();
		}

		// Token: 0x06019556 RID: 103766 RVA: 0x003A277A File Offset: 0x003A097A
		public static TChildQuestConditionUnion FromIFinishSurvivorsRougeCondition(IFinishSurvivorsRougeConditionT _ifinishsurvivorsrougecondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishSurvivorsRougeCondition,
				Value = _ifinishsurvivorsrougecondition
			};
		}

		// Token: 0x06019557 RID: 103767 RVA: 0x003A2790 File Offset: 0x003A0990
		public IFinishTetrisT AsIFinishTetris()
		{
			return this.As<IFinishTetrisT>();
		}

		// Token: 0x06019558 RID: 103768 RVA: 0x003A2798 File Offset: 0x003A0998
		public static TChildQuestConditionUnion FromIFinishTetris(IFinishTetrisT _ifinishtetris)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishTetris,
				Value = _ifinishtetris
			};
		}

		// Token: 0x06019559 RID: 103769 RVA: 0x003A27AE File Offset: 0x003A09AE
		public IFinishTrapDefenseConditionT AsIFinishTrapDefenseCondition()
		{
			return this.As<IFinishTrapDefenseConditionT>();
		}

		// Token: 0x0601955A RID: 103770 RVA: 0x003A27B6 File Offset: 0x003A09B6
		public static TChildQuestConditionUnion FromIFinishTrapDefenseCondition(IFinishTrapDefenseConditionT _ifinishtrapdefensecondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IFinishTrapDefenseCondition,
				Value = _ifinishtrapdefensecondition
			};
		}

		// Token: 0x0601955B RID: 103771 RVA: 0x003A27CC File Offset: 0x003A09CC
		public IGetItemQuestConditionT AsIGetItemQuestCondition()
		{
			return this.As<IGetItemQuestConditionT>();
		}

		// Token: 0x0601955C RID: 103772 RVA: 0x003A27D4 File Offset: 0x003A09D4
		public static TChildQuestConditionUnion FromIGetItemQuestCondition(IGetItemQuestConditionT _igetitemquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IGetItemQuestCondition,
				Value = _igetitemquestcondition
			};
		}

		// Token: 0x0601955D RID: 103773 RVA: 0x003A27EA File Offset: 0x003A09EA
		public IGetSkillQuestConditionT AsIGetSkillQuestCondition()
		{
			return this.As<IGetSkillQuestConditionT>();
		}

		// Token: 0x0601955E RID: 103774 RVA: 0x003A27F2 File Offset: 0x003A09F2
		public static TChildQuestConditionUnion FromIGetSkillQuestCondition(IGetSkillQuestConditionT _igetskillquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IGetSkillQuestCondition,
				Value = _igetskillquestcondition
			};
		}

		// Token: 0x0601955F RID: 103775 RVA: 0x003A2808 File Offset: 0x003A0A08
		public IGuideConditionT AsIGuideCondition()
		{
			return this.As<IGuideConditionT>();
		}

		// Token: 0x06019560 RID: 103776 RVA: 0x003A2810 File Offset: 0x003A0A10
		public static TChildQuestConditionUnion FromIGuideCondition(IGuideConditionT _iguidecondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IGuideCondition,
				Value = _iguidecondition
			};
		}

		// Token: 0x06019561 RID: 103777 RVA: 0x003A2826 File Offset: 0x003A0A26
		public IHandInItemsConditionT AsIHandInItemsCondition()
		{
			return this.As<IHandInItemsConditionT>();
		}

		// Token: 0x06019562 RID: 103778 RVA: 0x003A282E File Offset: 0x003A0A2E
		public static TChildQuestConditionUnion FromIHandInItemsCondition(IHandInItemsConditionT _ihandinitemscondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IHandInItemsCondition,
				Value = _ihandinitemscondition
			};
		}

		// Token: 0x06019563 RID: 103779 RVA: 0x003A2844 File Offset: 0x003A0A44
		public IInformationViewCheckConditionT AsIInformationViewCheckCondition()
		{
			return this.As<IInformationViewCheckConditionT>();
		}

		// Token: 0x06019564 RID: 103780 RVA: 0x003A284C File Offset: 0x003A0A4C
		public static TChildQuestConditionUnion FromIInformationViewCheckCondition(IInformationViewCheckConditionT _iinformationviewcheckcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IInformationViewCheckCondition,
				Value = _iinformationviewcheckcondition
			};
		}

		// Token: 0x06019565 RID: 103781 RVA: 0x003A2862 File Offset: 0x003A0A62
		public IKillChildQuestConditionT AsIKillChildQuestCondition()
		{
			return this.As<IKillChildQuestConditionT>();
		}

		// Token: 0x06019566 RID: 103782 RVA: 0x003A286A File Offset: 0x003A0A6A
		public static TChildQuestConditionUnion FromIKillChildQuestCondition(IKillChildQuestConditionT _ikillchildquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IKillChildQuestCondition,
				Value = _ikillchildquestcondition
			};
		}

		// Token: 0x06019567 RID: 103783 RVA: 0x003A2880 File Offset: 0x003A0A80
		public ILeaveDungeonConditionT AsILeaveDungeonCondition()
		{
			return this.As<ILeaveDungeonConditionT>();
		}

		// Token: 0x06019568 RID: 103784 RVA: 0x003A2888 File Offset: 0x003A0A88
		public static TChildQuestConditionUnion FromILeaveDungeonCondition(ILeaveDungeonConditionT _ileavedungeoncondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ILeaveDungeonCondition,
				Value = _ileavedungeoncondition
			};
		}

		// Token: 0x06019569 RID: 103785 RVA: 0x003A289E File Offset: 0x003A0A9E
		public IListenToEventT AsIListenToEvent()
		{
			return this.As<IListenToEventT>();
		}

		// Token: 0x0601956A RID: 103786 RVA: 0x003A28A6 File Offset: 0x003A0AA6
		public static TChildQuestConditionUnion FromIListenToEvent(IListenToEventT _ilistentoevent)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IListenToEvent,
				Value = _ilistentoevent
			};
		}

		// Token: 0x0601956B RID: 103787 RVA: 0x003A28BC File Offset: 0x003A0ABC
		public IMonsterCreatorQuestConditionT AsIMonsterCreatorQuestCondition()
		{
			return this.As<IMonsterCreatorQuestConditionT>();
		}

		// Token: 0x0601956C RID: 103788 RVA: 0x003A28C4 File Offset: 0x003A0AC4
		public static TChildQuestConditionUnion FromIMonsterCreatorQuestCondition(IMonsterCreatorQuestConditionT _imonstercreatorquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IMonsterCreatorQuestCondition,
				Value = _imonstercreatorquestcondition
			};
		}

		// Token: 0x0601956D RID: 103789 RVA: 0x003A28DA File Offset: 0x003A0ADA
		public INewHandInItemsConditionT AsINewHandInItemsCondition()
		{
			return this.As<INewHandInItemsConditionT>();
		}

		// Token: 0x0601956E RID: 103790 RVA: 0x003A28E2 File Offset: 0x003A0AE2
		public static TChildQuestConditionUnion FromINewHandInItemsCondition(INewHandInItemsConditionT _inewhandinitemscondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.INewHandInItemsCondition,
				Value = _inewhandinitemscondition
			};
		}

		// Token: 0x0601956F RID: 103791 RVA: 0x003A28F8 File Offset: 0x003A0AF8
		public IParallaxAlignQuestConditionT AsIParallaxAlignQuestCondition()
		{
			return this.As<IParallaxAlignQuestConditionT>();
		}

		// Token: 0x06019570 RID: 103792 RVA: 0x003A2900 File Offset: 0x003A0B00
		public static TChildQuestConditionUnion FromIParallaxAlignQuestCondition(IParallaxAlignQuestConditionT _iparallaxalignquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IParallaxAlignQuestCondition,
				Value = _iparallaxalignquestcondition
			};
		}

		// Token: 0x06019571 RID: 103793 RVA: 0x003A2916 File Offset: 0x003A0B16
		public IParkourQuestConditionT AsIParkourQuestCondition()
		{
			return this.As<IParkourQuestConditionT>();
		}

		// Token: 0x06019572 RID: 103794 RVA: 0x003A291E File Offset: 0x003A0B1E
		public static TChildQuestConditionUnion FromIParkourQuestCondition(IParkourQuestConditionT _iparkourquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IParkourQuestCondition,
				Value = _iparkourquestcondition
			};
		}

		// Token: 0x06019573 RID: 103795 RVA: 0x003A2934 File Offset: 0x003A0B34
		public IPlaybackShowTimelineQuestConditionT AsIPlaybackShowTimelineQuestCondition()
		{
			return this.As<IPlaybackShowTimelineQuestConditionT>();
		}

		// Token: 0x06019574 RID: 103796 RVA: 0x003A293C File Offset: 0x003A0B3C
		public static TChildQuestConditionUnion FromIPlaybackShowTimelineQuestCondition(IPlaybackShowTimelineQuestConditionT _iplaybackshowtimelinequestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IPlaybackShowTimelineQuestCondition,
				Value = _iplaybackshowtimelinequestcondition
			};
		}

		// Token: 0x06019575 RID: 103797 RVA: 0x003A2952 File Offset: 0x003A0B52
		public IPlayFlowQuestConditionT AsIPlayFlowQuestCondition()
		{
			return this.As<IPlayFlowQuestConditionT>();
		}

		// Token: 0x06019576 RID: 103798 RVA: 0x003A295A File Offset: 0x003A0B5A
		public static TChildQuestConditionUnion FromIPlayFlowQuestCondition(IPlayFlowQuestConditionT _iplayflowquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IPlayFlowQuestCondition,
				Value = _iplayflowquestcondition
			};
		}

		// Token: 0x06019577 RID: 103799 RVA: 0x003A2970 File Offset: 0x003A0B70
		public IProgramSpecialProcessT AsIProgramSpecialProcess()
		{
			return this.As<IProgramSpecialProcessT>();
		}

		// Token: 0x06019578 RID: 103800 RVA: 0x003A2978 File Offset: 0x003A0B78
		public static TChildQuestConditionUnion FromIProgramSpecialProcess(IProgramSpecialProcessT _iprogramspecialprocess)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IProgramSpecialProcess,
				Value = _iprogramspecialprocess
			};
		}

		// Token: 0x06019579 RID: 103801 RVA: 0x003A298E File Offset: 0x003A0B8E
		public IReachAreaQuestConditionT AsIReachAreaQuestCondition()
		{
			return this.As<IReachAreaQuestConditionT>();
		}

		// Token: 0x0601957A RID: 103802 RVA: 0x003A2996 File Offset: 0x003A0B96
		public static TChildQuestConditionUnion FromIReachAreaQuestCondition(IReachAreaQuestConditionT _ireachareaquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IReachAreaQuestCondition,
				Value = _ireachareaquestcondition
			};
		}

		// Token: 0x0601957B RID: 103803 RVA: 0x003A29AC File Offset: 0x003A0BAC
		public IReadMailConditionT AsIReadMailCondition()
		{
			return this.As<IReadMailConditionT>();
		}

		// Token: 0x0601957C RID: 103804 RVA: 0x003A29B4 File Offset: 0x003A0BB4
		public static TChildQuestConditionUnion FromIReadMailCondition(IReadMailConditionT _ireadmailcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IReadMailCondition,
				Value = _ireadmailcondition
			};
		}

		// Token: 0x0601957D RID: 103805 RVA: 0x003A29CA File Offset: 0x003A0BCA
		public IReadPhoneMessageQuestConditionT AsIReadPhoneMessageQuestCondition()
		{
			return this.As<IReadPhoneMessageQuestConditionT>();
		}

		// Token: 0x0601957E RID: 103806 RVA: 0x003A29D2 File Offset: 0x003A0BD2
		public static TChildQuestConditionUnion FromIReadPhoneMessageQuestCondition(IReadPhoneMessageQuestConditionT _ireadphonemessagequestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IReadPhoneMessageQuestCondition,
				Value = _ireadphonemessagequestcondition
			};
		}

		// Token: 0x0601957F RID: 103807 RVA: 0x003A29E8 File Offset: 0x003A0BE8
		public IReceiveTelecomChildQuestConditionT AsIReceiveTelecomChildQuestCondition()
		{
			return this.As<IReceiveTelecomChildQuestConditionT>();
		}

		// Token: 0x06019580 RID: 103808 RVA: 0x003A29F0 File Offset: 0x003A0BF0
		public static TChildQuestConditionUnion FromIReceiveTelecomChildQuestCondition(IReceiveTelecomChildQuestConditionT _ireceivetelecomchildquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IReceiveTelecomChildQuestCondition,
				Value = _ireceivetelecomchildquestcondition
			};
		}

		// Token: 0x06019581 RID: 103809 RVA: 0x003A2A06 File Offset: 0x003A0C06
		public IScheduleTimeConditionT AsIScheduleTimeCondition()
		{
			return this.As<IScheduleTimeConditionT>();
		}

		// Token: 0x06019582 RID: 103810 RVA: 0x003A2A0E File Offset: 0x003A0C0E
		public static TChildQuestConditionUnion FromIScheduleTimeCondition(IScheduleTimeConditionT _ischeduletimecondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IScheduleTimeCondition,
				Value = _ischeduletimecondition
			};
		}

		// Token: 0x06019583 RID: 103811 RVA: 0x003A2A24 File Offset: 0x003A0C24
		public IShowUiConditionT AsIShowUiCondition()
		{
			return this.As<IShowUiConditionT>();
		}

		// Token: 0x06019584 RID: 103812 RVA: 0x003A2A2C File Offset: 0x003A0C2C
		public static TChildQuestConditionUnion FromIShowUiCondition(IShowUiConditionT _ishowuicondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IShowUiCondition,
				Value = _ishowuicondition
			};
		}

		// Token: 0x06019585 RID: 103813 RVA: 0x003A2A42 File Offset: 0x003A0C42
		public ITakePhoto2ConditionT AsITakePhoto2Condition()
		{
			return this.As<ITakePhoto2ConditionT>();
		}

		// Token: 0x06019586 RID: 103814 RVA: 0x003A2A4A File Offset: 0x003A0C4A
		public static TChildQuestConditionUnion FromITakePhoto2Condition(ITakePhoto2ConditionT _itakephoto2condition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ITakePhoto2Condition,
				Value = _itakephoto2condition
			};
		}

		// Token: 0x06019587 RID: 103815 RVA: 0x003A2A60 File Offset: 0x003A0C60
		public ITakePhotoConditionT AsITakePhotoCondition()
		{
			return this.As<ITakePhotoConditionT>();
		}

		// Token: 0x06019588 RID: 103816 RVA: 0x003A2A68 File Offset: 0x003A0C68
		public static TChildQuestConditionUnion FromITakePhotoCondition(ITakePhotoConditionT _itakephotocondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ITakePhotoCondition,
				Value = _itakephotocondition
			};
		}

		// Token: 0x06019589 RID: 103817 RVA: 0x003A2A7E File Offset: 0x003A0C7E
		public ITimerQuestConditionT AsITimerQuestCondition()
		{
			return this.As<ITimerQuestConditionT>();
		}

		// Token: 0x0601958A RID: 103818 RVA: 0x003A2A86 File Offset: 0x003A0C86
		public static TChildQuestConditionUnion FromITimerQuestCondition(ITimerQuestConditionT _itimerquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ITimerQuestCondition,
				Value = _itimerquestcondition
			};
		}

		// Token: 0x0601958B RID: 103819 RVA: 0x003A2A9C File Offset: 0x003A0C9C
		public ITimeScaledPhotographT AsITimeScaledPhotograph()
		{
			return this.As<ITimeScaledPhotographT>();
		}

		// Token: 0x0601958C RID: 103820 RVA: 0x003A2AA4 File Offset: 0x003A0CA4
		public static TChildQuestConditionUnion FromITimeScaledPhotograph(ITimeScaledPhotographT _itimescaledphotograph)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.ITimeScaledPhotograph,
				Value = _itimescaledphotograph
			};
		}

		// Token: 0x0601958D RID: 103821 RVA: 0x003A2ABA File Offset: 0x003A0CBA
		public IUseItemConditionT AsIUseItemCondition()
		{
			return this.As<IUseItemConditionT>();
		}

		// Token: 0x0601958E RID: 103822 RVA: 0x003A2AC2 File Offset: 0x003A0CC2
		public static TChildQuestConditionUnion FromIUseItemCondition(IUseItemConditionT _iuseitemcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IUseItemCondition,
				Value = _iuseitemcondition
			};
		}

		// Token: 0x0601958F RID: 103823 RVA: 0x003A2AD8 File Offset: 0x003A0CD8
		public IUseSkillQuestConditionT AsIUseSkillQuestCondition()
		{
			return this.As<IUseSkillQuestConditionT>();
		}

		// Token: 0x06019590 RID: 103824 RVA: 0x003A2AE0 File Offset: 0x003A0CE0
		public static TChildQuestConditionUnion FromIUseSkillQuestCondition(IUseSkillQuestConditionT _iuseskillquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IUseSkillQuestCondition,
				Value = _iuseskillquestcondition
			};
		}

		// Token: 0x06019591 RID: 103825 RVA: 0x003A2AF6 File Offset: 0x003A0CF6
		public IUseWeatherSwitchConditionT AsIUseWeatherSwitchCondition()
		{
			return this.As<IUseWeatherSwitchConditionT>();
		}

		// Token: 0x06019592 RID: 103826 RVA: 0x003A2AFE File Offset: 0x003A0CFE
		public static TChildQuestConditionUnion FromIUseWeatherSwitchCondition(IUseWeatherSwitchConditionT _iuseweatherswitchcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IUseWeatherSwitchCondition,
				Value = _iuseweatherswitchcondition
			};
		}

		// Token: 0x06019593 RID: 103827 RVA: 0x003A2B14 File Offset: 0x003A0D14
		public IVisionSystemQuestConditionT AsIVisionSystemQuestCondition()
		{
			return this.As<IVisionSystemQuestConditionT>();
		}

		// Token: 0x06019594 RID: 103828 RVA: 0x003A2B1C File Offset: 0x003A0D1C
		public static TChildQuestConditionUnion FromIVisionSystemQuestCondition(IVisionSystemQuestConditionT _ivisionsystemquestcondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IVisionSystemQuestCondition,
				Value = _ivisionsystemquestcondition
			};
		}

		// Token: 0x06019595 RID: 103829 RVA: 0x003A2B32 File Offset: 0x003A0D32
		public IWaitBattleConditionT AsIWaitBattleCondition()
		{
			return this.As<IWaitBattleConditionT>();
		}

		// Token: 0x06019596 RID: 103830 RVA: 0x003A2B3A File Offset: 0x003A0D3A
		public static TChildQuestConditionUnion FromIWaitBattleCondition(IWaitBattleConditionT _iwaitbattlecondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IWaitBattleCondition,
				Value = _iwaitbattlecondition
			};
		}

		// Token: 0x06019597 RID: 103831 RVA: 0x003A2B50 File Offset: 0x003A0D50
		public IWaitTimeConditionT AsIWaitTimeCondition()
		{
			return this.As<IWaitTimeConditionT>();
		}

		// Token: 0x06019598 RID: 103832 RVA: 0x003A2B58 File Offset: 0x003A0D58
		public static TChildQuestConditionUnion FromIWaitTimeCondition(IWaitTimeConditionT _iwaittimecondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IWaitTimeCondition,
				Value = _iwaittimecondition
			};
		}

		// Token: 0x06019599 RID: 103833 RVA: 0x003A2B6E File Offset: 0x003A0D6E
		public IWaitUntilLevelSequenceReachMarkT AsIWaitUntilLevelSequenceReachMark()
		{
			return this.As<IWaitUntilLevelSequenceReachMarkT>();
		}

		// Token: 0x0601959A RID: 103834 RVA: 0x003A2B76 File Offset: 0x003A0D76
		public static TChildQuestConditionUnion FromIWaitUntilLevelSequenceReachMark(IWaitUntilLevelSequenceReachMarkT _iwaituntillevelsequencereachmark)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IWaitUntilLevelSequenceReachMark,
				Value = _iwaituntillevelsequencereachmark
			};
		}

		// Token: 0x0601959B RID: 103835 RVA: 0x003A2B8C File Offset: 0x003A0D8C
		public IWalkingPatternConditionT AsIWalkingPatternCondition()
		{
			return this.As<IWalkingPatternConditionT>();
		}

		// Token: 0x0601959C RID: 103836 RVA: 0x003A2B94 File Offset: 0x003A0D94
		public static TChildQuestConditionUnion FromIWalkingPatternCondition(IWalkingPatternConditionT _iwalkingpatterncondition)
		{
			return new TChildQuestConditionUnion
			{
				Type = TChildQuestCondition.IWalkingPatternCondition,
				Value = _iwalkingpatterncondition
			};
		}

		// Token: 0x0601959D RID: 103837 RVA: 0x003A2BAC File Offset: 0x003A0DAC
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

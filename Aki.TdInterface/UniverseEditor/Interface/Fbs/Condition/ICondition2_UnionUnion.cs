using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BDE RID: 19422
	public class ICondition2_UnionUnion
	{
		// Token: 0x17008D18 RID: 36120
		// (get) Token: 0x0601EAAD RID: 125613 RVA: 0x00449E1C File Offset: 0x0044801C
		// (set) Token: 0x0601EAAE RID: 125614 RVA: 0x00449E24 File Offset: 0x00448024
		public ICondition2_Union Type { get; set; }

		// Token: 0x17008D19 RID: 36121
		// (get) Token: 0x0601EAAF RID: 125615 RVA: 0x00449E2D File Offset: 0x0044802D
		// (set) Token: 0x0601EAB0 RID: 125616 RVA: 0x00449E35 File Offset: 0x00448035
		public object Value { get; set; }

		// Token: 0x0601EAB1 RID: 125617 RVA: 0x00449E3E File Offset: 0x0044803E
		public ICondition2_UnionUnion()
		{
			this.Type = ICondition2_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601EAB2 RID: 125618 RVA: 0x00449E54 File Offset: 0x00448054
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601EAB3 RID: 125619 RVA: 0x00449E66 File Offset: 0x00448066
		public ICondition2T AsICondition2()
		{
			return this.As<ICondition2T>();
		}

		// Token: 0x0601EAB4 RID: 125620 RVA: 0x00449E6E File Offset: 0x0044806E
		public static ICondition2_UnionUnion FromICondition2(ICondition2T _icondition2)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICondition2,
				Value = _icondition2
			};
		}

		// Token: 0x0601EAB5 RID: 125621 RVA: 0x00449E83 File Offset: 0x00448083
		public ICompareVarConditionT AsICompareVarCondition()
		{
			return this.As<ICompareVarConditionT>();
		}

		// Token: 0x0601EAB6 RID: 125622 RVA: 0x00449E8B File Offset: 0x0044808B
		public static ICondition2_UnionUnion FromICompareVarCondition(ICompareVarConditionT _icomparevarcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareVarCondition,
				Value = _icomparevarcondition
			};
		}

		// Token: 0x0601EAB7 RID: 125623 RVA: 0x00449EA0 File Offset: 0x004480A0
		public IQuestStateEqualConditionT AsIQuestStateEqualCondition()
		{
			return this.As<IQuestStateEqualConditionT>();
		}

		// Token: 0x0601EAB8 RID: 125624 RVA: 0x00449EA8 File Offset: 0x004480A8
		public static ICondition2_UnionUnion FromIQuestStateEqualCondition(IQuestStateEqualConditionT _iqueststateequalcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.IQuestStateEqualCondition,
				Value = _iqueststateequalcondition
			};
		}

		// Token: 0x0601EAB9 RID: 125625 RVA: 0x00449EBD File Offset: 0x004480BD
		public ICompareExploreLevelConditionT AsICompareExploreLevelCondition()
		{
			return this.As<ICompareExploreLevelConditionT>();
		}

		// Token: 0x0601EABA RID: 125626 RVA: 0x00449EC5 File Offset: 0x004480C5
		public static ICondition2_UnionUnion FromICompareExploreLevelCondition(ICompareExploreLevelConditionT _icompareexplorelevelcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareExploreLevelCondition,
				Value = _icompareexplorelevelcondition
			};
		}

		// Token: 0x0601EABB RID: 125627 RVA: 0x00449EDA File Offset: 0x004480DA
		public ICompareCalabashLevelConditionT AsICompareCalabashLevelCondition()
		{
			return this.As<ICompareCalabashLevelConditionT>();
		}

		// Token: 0x0601EABC RID: 125628 RVA: 0x00449EE2 File Offset: 0x004480E2
		public static ICondition2_UnionUnion FromICompareCalabashLevelCondition(ICompareCalabashLevelConditionT _icomparecalabashlevelcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareCalabashLevelCondition,
				Value = _icomparecalabashlevelcondition
			};
		}

		// Token: 0x0601EABD RID: 125629 RVA: 0x00449EF7 File Offset: 0x004480F7
		public ICompareLiftConditionT AsICompareLiftCondition()
		{
			return this.As<ICompareLiftConditionT>();
		}

		// Token: 0x0601EABE RID: 125630 RVA: 0x00449EFF File Offset: 0x004480FF
		public static ICondition2_UnionUnion FromICompareLiftCondition(ICompareLiftConditionT _icompareliftcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareLiftCondition,
				Value = _icompareliftcondition
			};
		}

		// Token: 0x0601EABF RID: 125631 RVA: 0x00449F14 File Offset: 0x00448114
		public ICompareEntityStateConditionT AsICompareEntityStateCondition()
		{
			return this.As<ICompareEntityStateConditionT>();
		}

		// Token: 0x0601EAC0 RID: 125632 RVA: 0x00449F1C File Offset: 0x0044811C
		public static ICondition2_UnionUnion FromICompareEntityStateCondition(ICompareEntityStateConditionT _icompareentitystatecondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareEntityStateCondition,
				Value = _icompareentitystatecondition
			};
		}

		// Token: 0x0601EAC1 RID: 125633 RVA: 0x00449F31 File Offset: 0x00448131
		public ICompareNpcPerformStateConditionT AsICompareNpcPerformStateCondition()
		{
			return this.As<ICompareNpcPerformStateConditionT>();
		}

		// Token: 0x0601EAC2 RID: 125634 RVA: 0x00449F39 File Offset: 0x00448139
		public static ICondition2_UnionUnion FromICompareNpcPerformStateCondition(ICompareNpcPerformStateConditionT _icomparenpcperformstatecondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareNpcPerformStateCondition,
				Value = _icomparenpcperformstatecondition
			};
		}

		// Token: 0x0601EAC3 RID: 125635 RVA: 0x00449F4E File Offset: 0x0044814E
		public ICheckTreasureBeenClaimedConditionT AsICheckTreasureBeenClaimedCondition()
		{
			return this.As<ICheckTreasureBeenClaimedConditionT>();
		}

		// Token: 0x0601EAC4 RID: 125636 RVA: 0x00449F56 File Offset: 0x00448156
		public static ICondition2_UnionUnion FromICheckTreasureBeenClaimedCondition(ICheckTreasureBeenClaimedConditionT _ichecktreasurebeenclaimedcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckTreasureBeenClaimedCondition,
				Value = _ichecktreasurebeenclaimedcondition
			};
		}

		// Token: 0x0601EAC5 RID: 125637 RVA: 0x00449F6C File Offset: 0x0044816C
		public ICompareEntityGroupStateConditionT AsICompareEntityGroupStateCondition()
		{
			return this.As<ICompareEntityGroupStateConditionT>();
		}

		// Token: 0x0601EAC6 RID: 125638 RVA: 0x00449F74 File Offset: 0x00448174
		public static ICondition2_UnionUnion FromICompareEntityGroupStateCondition(ICompareEntityGroupStateConditionT _icompareentitygroupstatecondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareEntityGroupStateCondition,
				Value = _icompareentitygroupstatecondition
			};
		}

		// Token: 0x0601EAC7 RID: 125639 RVA: 0x00449F8A File Offset: 0x0044818A
		public ICompareEntitySelfStateConditionT AsICompareEntitySelfStateCondition()
		{
			return this.As<ICompareEntitySelfStateConditionT>();
		}

		// Token: 0x0601EAC8 RID: 125640 RVA: 0x00449F92 File Offset: 0x00448192
		public static ICondition2_UnionUnion FromICompareEntitySelfStateCondition(ICompareEntitySelfStateConditionT _icompareentityselfstatecondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareEntitySelfStateCondition,
				Value = _icompareentityselfstatecondition
			};
		}

		// Token: 0x0601EAC9 RID: 125641 RVA: 0x00449FA8 File Offset: 0x004481A8
		public ICompareLevelPlayRewardStateConditionT AsICompareLevelPlayRewardStateCondition()
		{
			return this.As<ICompareLevelPlayRewardStateConditionT>();
		}

		// Token: 0x0601EACA RID: 125642 RVA: 0x00449FB0 File Offset: 0x004481B0
		public static ICondition2_UnionUnion FromICompareLevelPlayRewardStateCondition(ICompareLevelPlayRewardStateConditionT _icomparelevelplayrewardstatecondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareLevelPlayRewardStateCondition,
				Value = _icomparelevelplayrewardstatecondition
			};
		}

		// Token: 0x0601EACB RID: 125643 RVA: 0x00449FC6 File Offset: 0x004481C6
		public IHourToHourConditionT AsIHourToHourCondition()
		{
			return this.As<IHourToHourConditionT>();
		}

		// Token: 0x0601EACC RID: 125644 RVA: 0x00449FCE File Offset: 0x004481CE
		public static ICondition2_UnionUnion FromIHourToHourCondition(IHourToHourConditionT _ihourtohourcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.IHourToHourCondition,
				Value = _ihourtohourcondition
			};
		}

		// Token: 0x0601EACD RID: 125645 RVA: 0x00449FE4 File Offset: 0x004481E4
		public IRangeSphereT AsIRangeSphere()
		{
			return this.As<IRangeSphereT>();
		}

		// Token: 0x0601EACE RID: 125646 RVA: 0x00449FEC File Offset: 0x004481EC
		public static ICondition2_UnionUnion FromIRangeSphere(IRangeSphereT _irangesphere)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.IRangeSphere,
				Value = _irangesphere
			};
		}

		// Token: 0x0601EACF RID: 125647 RVA: 0x0044A002 File Offset: 0x00448202
		public ICheckItemsT AsICheckItems()
		{
			return this.As<ICheckItemsT>();
		}

		// Token: 0x0601EAD0 RID: 125648 RVA: 0x0044A00A File Offset: 0x0044820A
		public static ICondition2_UnionUnion FromICheckItems(ICheckItemsT _icheckitems)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckItems,
				Value = _icheckitems
			};
		}

		// Token: 0x0601EAD1 RID: 125649 RVA: 0x0044A020 File Offset: 0x00448220
		public IHasBuffT AsIHasBuff()
		{
			return this.As<IHasBuffT>();
		}

		// Token: 0x0601EAD2 RID: 125650 RVA: 0x0044A028 File Offset: 0x00448228
		public static ICondition2_UnionUnion FromIHasBuff(IHasBuffT _ihasbuff)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.IHasBuff,
				Value = _ihasbuff
			};
		}

		// Token: 0x0601EAD3 RID: 125651 RVA: 0x0044A03E File Offset: 0x0044823E
		public ICheckSystemFunctionT AsICheckSystemFunction()
		{
			return this.As<ICheckSystemFunctionT>();
		}

		// Token: 0x0601EAD4 RID: 125652 RVA: 0x0044A046 File Offset: 0x00448246
		public static ICondition2_UnionUnion FromICheckSystemFunction(ICheckSystemFunctionT _ichecksystemfunction)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckSystemFunction,
				Value = _ichecksystemfunction
			};
		}

		// Token: 0x0601EAD5 RID: 125653 RVA: 0x0044A05C File Offset: 0x0044825C
		public ICheckAiStateT AsICheckAiState()
		{
			return this.As<ICheckAiStateT>();
		}

		// Token: 0x0601EAD6 RID: 125654 RVA: 0x0044A064 File Offset: 0x00448264
		public static ICondition2_UnionUnion FromICheckAiState(ICheckAiStateT _icheckaistate)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckAiState,
				Value = _icheckaistate
			};
		}

		// Token: 0x0601EAD7 RID: 125655 RVA: 0x0044A07A File Offset: 0x0044827A
		public ICompareDungeonIdT AsICompareDungeonId()
		{
			return this.As<ICompareDungeonIdT>();
		}

		// Token: 0x0601EAD8 RID: 125656 RVA: 0x0044A082 File Offset: 0x00448282
		public static ICondition2_UnionUnion FromICompareDungeonId(ICompareDungeonIdT _icomparedungeonid)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareDungeonId,
				Value = _icomparedungeonid
			};
		}

		// Token: 0x0601EAD9 RID: 125657 RVA: 0x0044A098 File Offset: 0x00448298
		public ICompareTimePeriodT AsICompareTimePeriod()
		{
			return this.As<ICompareTimePeriodT>();
		}

		// Token: 0x0601EADA RID: 125658 RVA: 0x0044A0A0 File Offset: 0x004482A0
		public static ICondition2_UnionUnion FromICompareTimePeriod(ICompareTimePeriodT _icomparetimeperiod)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareTimePeriod,
				Value = _icomparetimeperiod
			};
		}

		// Token: 0x0601EADB RID: 125659 RVA: 0x0044A0B6 File Offset: 0x004482B6
		public ICompareWeatherT AsICompareWeather()
		{
			return this.As<ICompareWeatherT>();
		}

		// Token: 0x0601EADC RID: 125660 RVA: 0x0044A0BE File Offset: 0x004482BE
		public static ICondition2_UnionUnion FromICompareWeather(ICompareWeatherT _icompareweather)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareWeather,
				Value = _icompareweather
			};
		}

		// Token: 0x0601EADD RID: 125661 RVA: 0x0044A0D4 File Offset: 0x004482D4
		public ICheckLevelPlayStateT AsICheckLevelPlayState()
		{
			return this.As<ICheckLevelPlayStateT>();
		}

		// Token: 0x0601EADE RID: 125662 RVA: 0x0044A0DC File Offset: 0x004482DC
		public static ICondition2_UnionUnion FromICheckLevelPlayState(ICheckLevelPlayStateT _ichecklevelplaystate)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckLevelPlayState,
				Value = _ichecklevelplaystate
			};
		}

		// Token: 0x0601EADF RID: 125663 RVA: 0x0044A0F2 File Offset: 0x004482F2
		public ICheckLevelPlayCompleteNumberT AsICheckLevelPlayCompleteNumber()
		{
			return this.As<ICheckLevelPlayCompleteNumberT>();
		}

		// Token: 0x0601EAE0 RID: 125664 RVA: 0x0044A0FA File Offset: 0x004482FA
		public static ICondition2_UnionUnion FromICheckLevelPlayCompleteNumber(ICheckLevelPlayCompleteNumberT _ichecklevelplaycompletenumber)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckLevelPlayCompleteNumber,
				Value = _ichecklevelplaycompletenumber
			};
		}

		// Token: 0x0601EAE1 RID: 125665 RVA: 0x0044A110 File Offset: 0x00448310
		public ICheckLevelPlayChildQuestFinishedT AsICheckLevelPlayChildQuestFinished()
		{
			return this.As<ICheckLevelPlayChildQuestFinishedT>();
		}

		// Token: 0x0601EAE2 RID: 125666 RVA: 0x0044A118 File Offset: 0x00448318
		public static ICondition2_UnionUnion FromICheckLevelPlayChildQuestFinished(ICheckLevelPlayChildQuestFinishedT _ichecklevelplaychildquestfinished)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckLevelPlayChildQuestFinished,
				Value = _ichecklevelplaychildquestfinished
			};
		}

		// Token: 0x0601EAE3 RID: 125667 RVA: 0x0044A12E File Offset: 0x0044832E
		public ICheckCurrentRoleT AsICheckCurrentRole()
		{
			return this.As<ICheckCurrentRoleT>();
		}

		// Token: 0x0601EAE4 RID: 125668 RVA: 0x0044A136 File Offset: 0x00448336
		public static ICondition2_UnionUnion FromICheckCurrentRole(ICheckCurrentRoleT _icheckcurrentrole)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckCurrentRole,
				Value = _icheckcurrentrole
			};
		}

		// Token: 0x0601EAE5 RID: 125669 RVA: 0x0044A14C File Offset: 0x0044834C
		public ICheckPlayerGenderT AsICheckPlayerGender()
		{
			return this.As<ICheckPlayerGenderT>();
		}

		// Token: 0x0601EAE6 RID: 125670 RVA: 0x0044A154 File Offset: 0x00448354
		public static ICondition2_UnionUnion FromICheckPlayerGender(ICheckPlayerGenderT _icheckplayergender)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerGender,
				Value = _icheckplayergender
			};
		}

		// Token: 0x0601EAE7 RID: 125671 RVA: 0x0044A16A File Offset: 0x0044836A
		public ICheckInCombatT AsICheckInCombat()
		{
			return this.As<ICheckInCombatT>();
		}

		// Token: 0x0601EAE8 RID: 125672 RVA: 0x0044A172 File Offset: 0x00448372
		public static ICondition2_UnionUnion FromICheckInCombat(ICheckInCombatT _icheckincombat)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckInCombat,
				Value = _icheckincombat
			};
		}

		// Token: 0x0601EAE9 RID: 125673 RVA: 0x0044A188 File Offset: 0x00448388
		public ICheckHasFollowShooterT AsICheckHasFollowShooter()
		{
			return this.As<ICheckHasFollowShooterT>();
		}

		// Token: 0x0601EAEA RID: 125674 RVA: 0x0044A190 File Offset: 0x00448390
		public static ICondition2_UnionUnion FromICheckHasFollowShooter(ICheckHasFollowShooterT _icheckhasfollowshooter)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHasFollowShooter,
				Value = _icheckhasfollowshooter
			};
		}

		// Token: 0x0601EAEB RID: 125675 RVA: 0x0044A1A6 File Offset: 0x004483A6
		public ICheckFollowShooterActiveT AsICheckFollowShooterActive()
		{
			return this.As<ICheckFollowShooterActiveT>();
		}

		// Token: 0x0601EAEC RID: 125676 RVA: 0x0044A1AE File Offset: 0x004483AE
		public static ICondition2_UnionUnion FromICheckFollowShooterActive(ICheckFollowShooterActiveT _icheckfollowshooteractive)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckFollowShooterActive,
				Value = _icheckfollowshooteractive
			};
		}

		// Token: 0x0601EAED RID: 125677 RVA: 0x0044A1C4 File Offset: 0x004483C4
		public ICheckChildQuestFinishedT AsICheckChildQuestFinished()
		{
			return this.As<ICheckChildQuestFinishedT>();
		}

		// Token: 0x0601EAEE RID: 125678 RVA: 0x0044A1CC File Offset: 0x004483CC
		public static ICondition2_UnionUnion FromICheckChildQuestFinished(ICheckChildQuestFinishedT _icheckchildquestfinished)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckChildQuestFinished,
				Value = _icheckchildquestfinished
			};
		}

		// Token: 0x0601EAEF RID: 125679 RVA: 0x0044A1E2 File Offset: 0x004483E2
		public ICheckSyncLevelPlayCompleteNumberT AsICheckSyncLevelPlayCompleteNumber()
		{
			return this.As<ICheckSyncLevelPlayCompleteNumberT>();
		}

		// Token: 0x0601EAF0 RID: 125680 RVA: 0x0044A1EA File Offset: 0x004483EA
		public static ICondition2_UnionUnion FromICheckSyncLevelPlayCompleteNumber(ICheckSyncLevelPlayCompleteNumberT _ichecksynclevelplaycompletenumber)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckSyncLevelPlayCompleteNumber,
				Value = _ichecksynclevelplaycompletenumber
			};
		}

		// Token: 0x0601EAF1 RID: 125681 RVA: 0x0044A200 File Offset: 0x00448400
		public ICheckCrossSceneSyncKillMonsterFinishedT AsICheckCrossSceneSyncKillMonsterFinished()
		{
			return this.As<ICheckCrossSceneSyncKillMonsterFinishedT>();
		}

		// Token: 0x0601EAF2 RID: 125682 RVA: 0x0044A208 File Offset: 0x00448408
		public static ICondition2_UnionUnion FromICheckCrossSceneSyncKillMonsterFinished(ICheckCrossSceneSyncKillMonsterFinishedT _icheckcrossscenesynckillmonsterfinished)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckCrossSceneSyncKillMonsterFinished,
				Value = _icheckcrossscenesynckillmonsterfinished
			};
		}

		// Token: 0x0601EAF3 RID: 125683 RVA: 0x0044A21E File Offset: 0x0044841E
		public ICheckNodeStatusT AsICheckNodeStatus()
		{
			return this.As<ICheckNodeStatusT>();
		}

		// Token: 0x0601EAF4 RID: 125684 RVA: 0x0044A226 File Offset: 0x00448426
		public static ICondition2_UnionUnion FromICheckNodeStatus(ICheckNodeStatusT _ichecknodestatus)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckNodeStatus,
				Value = _ichecknodestatus
			};
		}

		// Token: 0x0601EAF5 RID: 125685 RVA: 0x0044A23C File Offset: 0x0044843C
		public ICheckChildQuestStatusT AsICheckChildQuestStatus()
		{
			return this.As<ICheckChildQuestStatusT>();
		}

		// Token: 0x0601EAF6 RID: 125686 RVA: 0x0044A244 File Offset: 0x00448444
		public static ICondition2_UnionUnion FromICheckChildQuestStatus(ICheckChildQuestStatusT _icheckchildqueststatus)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckChildQuestStatus,
				Value = _icheckchildqueststatus
			};
		}

		// Token: 0x0601EAF7 RID: 125687 RVA: 0x0044A25A File Offset: 0x0044845A
		public ICheckEntitiesExistT AsICheckEntitiesExist()
		{
			return this.As<ICheckEntitiesExistT>();
		}

		// Token: 0x0601EAF8 RID: 125688 RVA: 0x0044A262 File Offset: 0x00448462
		public static ICondition2_UnionUnion FromICheckEntitiesExist(ICheckEntitiesExistT _icheckentitiesexist)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntitiesExist,
				Value = _icheckentitiesexist
			};
		}

		// Token: 0x0601EAF9 RID: 125689 RVA: 0x0044A278 File Offset: 0x00448478
		public ICheckPlayerPositionT AsICheckPlayerPosition()
		{
			return this.As<ICheckPlayerPositionT>();
		}

		// Token: 0x0601EAFA RID: 125690 RVA: 0x0044A280 File Offset: 0x00448480
		public static ICondition2_UnionUnion FromICheckPlayerPosition(ICheckPlayerPositionT _icheckplayerposition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerPosition,
				Value = _icheckplayerposition
			};
		}

		// Token: 0x0601EAFB RID: 125691 RVA: 0x0044A296 File Offset: 0x00448496
		public ICheckEntityPositionT AsICheckEntityPosition()
		{
			return this.As<ICheckEntityPositionT>();
		}

		// Token: 0x0601EAFC RID: 125692 RVA: 0x0044A29E File Offset: 0x0044849E
		public static ICondition2_UnionUnion FromICheckEntityPosition(ICheckEntityPositionT _icheckentityposition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntityPosition,
				Value = _icheckentityposition
			};
		}

		// Token: 0x0601EAFD RID: 125693 RVA: 0x0044A2B4 File Offset: 0x004484B4
		public ICheckDungeonFinishT AsICheckDungeonFinish()
		{
			return this.As<ICheckDungeonFinishT>();
		}

		// Token: 0x0601EAFE RID: 125694 RVA: 0x0044A2BC File Offset: 0x004484BC
		public static ICondition2_UnionUnion FromICheckDungeonFinish(ICheckDungeonFinishT _icheckdungeonfinish)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckDungeonFinish,
				Value = _icheckdungeonfinish
			};
		}

		// Token: 0x0601EAFF RID: 125695 RVA: 0x0044A2D2 File Offset: 0x004484D2
		public ICheckEntityIsVisibilityT AsICheckEntityIsVisibility()
		{
			return this.As<ICheckEntityIsVisibilityT>();
		}

		// Token: 0x0601EB00 RID: 125696 RVA: 0x0044A2DA File Offset: 0x004484DA
		public static ICondition2_UnionUnion FromICheckEntityIsVisibility(ICheckEntityIsVisibilityT _icheckentityisvisibility)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntityIsVisibility,
				Value = _icheckentityisvisibility
			};
		}

		// Token: 0x0601EB01 RID: 125697 RVA: 0x0044A2F0 File Offset: 0x004484F0
		public IComparePlayerMotionStateT AsIComparePlayerMotionState()
		{
			return this.As<IComparePlayerMotionStateT>();
		}

		// Token: 0x0601EB02 RID: 125698 RVA: 0x0044A2F8 File Offset: 0x004484F8
		public static ICondition2_UnionUnion FromIComparePlayerMotionState(IComparePlayerMotionStateT _icompareplayermotionstate)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.IComparePlayerMotionState,
				Value = _icompareplayermotionstate
			};
		}

		// Token: 0x0601EB03 RID: 125699 RVA: 0x0044A30E File Offset: 0x0044850E
		public IComparePlayerMotionState2T AsIComparePlayerMotionState2()
		{
			return this.As<IComparePlayerMotionState2T>();
		}

		// Token: 0x0601EB04 RID: 125700 RVA: 0x0044A316 File Offset: 0x00448516
		public static ICondition2_UnionUnion FromIComparePlayerMotionState2(IComparePlayerMotionState2T _icompareplayermotionstate2)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.IComparePlayerMotionState2,
				Value = _icompareplayermotionstate2
			};
		}

		// Token: 0x0601EB05 RID: 125701 RVA: 0x0044A32C File Offset: 0x0044852C
		public ICheckDataLayerConditionT AsICheckDataLayerCondition()
		{
			return this.As<ICheckDataLayerConditionT>();
		}

		// Token: 0x0601EB06 RID: 125702 RVA: 0x0044A334 File Offset: 0x00448534
		public static ICondition2_UnionUnion FromICheckDataLayerCondition(ICheckDataLayerConditionT _icheckdatalayercondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckDataLayerCondition,
				Value = _icheckdatalayercondition
			};
		}

		// Token: 0x0601EB07 RID: 125703 RVA: 0x0044A34A File Offset: 0x0044854A
		public ICheckHookLockPointConditionT AsICheckHookLockPointCondition()
		{
			return this.As<ICheckHookLockPointConditionT>();
		}

		// Token: 0x0601EB08 RID: 125704 RVA: 0x0044A352 File Offset: 0x00448552
		public static ICondition2_UnionUnion FromICheckHookLockPointCondition(ICheckHookLockPointConditionT _icheckhooklockpointcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHookLockPointCondition,
				Value = _icheckhooklockpointcondition
			};
		}

		// Token: 0x0601EB09 RID: 125705 RVA: 0x0044A368 File Offset: 0x00448568
		public ICheckPlayerSkillReadyConditionT AsICheckPlayerSkillReadyCondition()
		{
			return this.As<ICheckPlayerSkillReadyConditionT>();
		}

		// Token: 0x0601EB0A RID: 125706 RVA: 0x0044A370 File Offset: 0x00448570
		public static ICondition2_UnionUnion FromICheckPlayerSkillReadyCondition(ICheckPlayerSkillReadyConditionT _icheckplayerskillreadycondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerSkillReadyCondition,
				Value = _icheckplayerskillreadycondition
			};
		}

		// Token: 0x0601EB0B RID: 125707 RVA: 0x0044A386 File Offset: 0x00448586
		public ICheckPlayerUseSkillConditionT AsICheckPlayerUseSkillCondition()
		{
			return this.As<ICheckPlayerUseSkillConditionT>();
		}

		// Token: 0x0601EB0C RID: 125708 RVA: 0x0044A38E File Offset: 0x0044858E
		public static ICondition2_UnionUnion FromICheckPlayerUseSkillCondition(ICheckPlayerUseSkillConditionT _icheckplayeruseskillcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerUseSkillCondition,
				Value = _icheckplayeruseskillcondition
			};
		}

		// Token: 0x0601EB0D RID: 125709 RVA: 0x0044A3A4 File Offset: 0x004485A4
		public ICheckPlayerStateRestrictionConditionT AsICheckPlayerStateRestrictionCondition()
		{
			return this.As<ICheckPlayerStateRestrictionConditionT>();
		}

		// Token: 0x0601EB0E RID: 125710 RVA: 0x0044A3AC File Offset: 0x004485AC
		public static ICondition2_UnionUnion FromICheckPlayerStateRestrictionCondition(ICheckPlayerStateRestrictionConditionT _icheckplayerstaterestrictioncondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerStateRestrictionCondition,
				Value = _icheckplayerstaterestrictioncondition
			};
		}

		// Token: 0x0601EB0F RID: 125711 RVA: 0x0044A3C2 File Offset: 0x004485C2
		public ICheckLordGymFinishConditionT AsICheckLordGymFinishCondition()
		{
			return this.As<ICheckLordGymFinishConditionT>();
		}

		// Token: 0x0601EB10 RID: 125712 RVA: 0x0044A3CA File Offset: 0x004485CA
		public static ICondition2_UnionUnion FromICheckLordGymFinishCondition(ICheckLordGymFinishConditionT _ichecklordgymfinishcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckLordGymFinishCondition,
				Value = _ichecklordgymfinishcondition
			};
		}

		// Token: 0x0601EB11 RID: 125713 RVA: 0x0044A3E0 File Offset: 0x004485E0
		public ICheckCalabashDevelopRewardConditionT AsICheckCalabashDevelopRewardCondition()
		{
			return this.As<ICheckCalabashDevelopRewardConditionT>();
		}

		// Token: 0x0601EB12 RID: 125714 RVA: 0x0044A3E8 File Offset: 0x004485E8
		public static ICondition2_UnionUnion FromICheckCalabashDevelopRewardCondition(ICheckCalabashDevelopRewardConditionT _icheckcalabashdeveloprewardcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckCalabashDevelopRewardCondition,
				Value = _icheckcalabashdeveloprewardcondition
			};
		}

		// Token: 0x0601EB13 RID: 125715 RVA: 0x0044A3FE File Offset: 0x004485FE
		public ICompareFishingPrestigeLevelConditionT AsICompareFishingPrestigeLevelCondition()
		{
			return this.As<ICompareFishingPrestigeLevelConditionT>();
		}

		// Token: 0x0601EB14 RID: 125716 RVA: 0x0044A406 File Offset: 0x00448606
		public static ICondition2_UnionUnion FromICompareFishingPrestigeLevelCondition(ICompareFishingPrestigeLevelConditionT _icomparefishingprestigelevelcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareFishingPrestigeLevelCondition,
				Value = _icomparefishingprestigelevelcondition
			};
		}

		// Token: 0x0601EB15 RID: 125717 RVA: 0x0044A41C File Offset: 0x0044861C
		public ICheckCertainFishingItemCountT AsICheckCertainFishingItemCount()
		{
			return this.As<ICheckCertainFishingItemCountT>();
		}

		// Token: 0x0601EB16 RID: 125718 RVA: 0x0044A424 File Offset: 0x00448624
		public static ICondition2_UnionUnion FromICheckCertainFishingItemCount(ICheckCertainFishingItemCountT _icheckcertainfishingitemcount)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckCertainFishingItemCount,
				Value = _icheckcertainfishingitemcount
			};
		}

		// Token: 0x0601EB17 RID: 125719 RVA: 0x0044A43A File Offset: 0x0044863A
		public ICompleteCertainFishingEntrustT AsICompleteCertainFishingEntrust()
		{
			return this.As<ICompleteCertainFishingEntrustT>();
		}

		// Token: 0x0601EB18 RID: 125720 RVA: 0x0044A442 File Offset: 0x00448642
		public static ICondition2_UnionUnion FromICompleteCertainFishingEntrust(ICompleteCertainFishingEntrustT _icompletecertainfishingentrust)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompleteCertainFishingEntrust,
				Value = _icompletecertainfishingentrust
			};
		}

		// Token: 0x0601EB19 RID: 125721 RVA: 0x0044A458 File Offset: 0x00448658
		public ICompareFishingBoatStateT AsICompareFishingBoatState()
		{
			return this.As<ICompareFishingBoatStateT>();
		}

		// Token: 0x0601EB1A RID: 125722 RVA: 0x0044A460 File Offset: 0x00448660
		public static ICondition2_UnionUnion FromICompareFishingBoatState(ICompareFishingBoatStateT _icomparefishingboatstate)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareFishingBoatState,
				Value = _icomparefishingboatstate
			};
		}

		// Token: 0x0601EB1B RID: 125723 RVA: 0x0044A476 File Offset: 0x00448676
		public ICheckJigsawInfoConditionT AsICheckJigsawInfoCondition()
		{
			return this.As<ICheckJigsawInfoConditionT>();
		}

		// Token: 0x0601EB1C RID: 125724 RVA: 0x0044A47E File Offset: 0x0044867E
		public static ICondition2_UnionUnion FromICheckJigsawInfoCondition(ICheckJigsawInfoConditionT _icheckjigsawinfocondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckJigsawInfoCondition,
				Value = _icheckjigsawinfocondition
			};
		}

		// Token: 0x0601EB1D RID: 125725 RVA: 0x0044A494 File Offset: 0x00448694
		public ICheckGameplayTagConditionT AsICheckGameplayTagCondition()
		{
			return this.As<ICheckGameplayTagConditionT>();
		}

		// Token: 0x0601EB1E RID: 125726 RVA: 0x0044A49C File Offset: 0x0044869C
		public static ICondition2_UnionUnion FromICheckGameplayTagCondition(ICheckGameplayTagConditionT _icheckgameplaytagcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckGameplayTagCondition,
				Value = _icheckgameplaytagcondition
			};
		}

		// Token: 0x0601EB1F RID: 125727 RVA: 0x0044A4B2 File Offset: 0x004486B2
		public ICheckFormationRoleInfoConditionT AsICheckFormationRoleInfoCondition()
		{
			return this.As<ICheckFormationRoleInfoConditionT>();
		}

		// Token: 0x0601EB20 RID: 125728 RVA: 0x0044A4BA File Offset: 0x004486BA
		public static ICondition2_UnionUnion FromICheckFormationRoleInfoCondition(ICheckFormationRoleInfoConditionT _icheckformationroleinfocondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckFormationRoleInfoCondition,
				Value = _icheckformationroleinfocondition
			};
		}

		// Token: 0x0601EB21 RID: 125729 RVA: 0x0044A4D0 File Offset: 0x004486D0
		public ICheckTargetAttributeConditionT AsICheckTargetAttributeCondition()
		{
			return this.As<ICheckTargetAttributeConditionT>();
		}

		// Token: 0x0601EB22 RID: 125730 RVA: 0x0044A4D8 File Offset: 0x004486D8
		public static ICondition2_UnionUnion FromICheckTargetAttributeCondition(ICheckTargetAttributeConditionT _ichecktargetattributecondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckTargetAttributeCondition,
				Value = _ichecktargetattributecondition
			};
		}

		// Token: 0x0601EB23 RID: 125731 RVA: 0x0044A4EE File Offset: 0x004486EE
		public ICheckRogueAbilitySelectConditionT AsICheckRogueAbilitySelectCondition()
		{
			return this.As<ICheckRogueAbilitySelectConditionT>();
		}

		// Token: 0x0601EB24 RID: 125732 RVA: 0x0044A4F6 File Offset: 0x004486F6
		public static ICondition2_UnionUnion FromICheckRogueAbilitySelectCondition(ICheckRogueAbilitySelectConditionT _icheckrogueabilityselectcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckRogueAbilitySelectCondition,
				Value = _icheckrogueabilityselectcondition
			};
		}

		// Token: 0x0601EB25 RID: 125733 RVA: 0x0044A50C File Offset: 0x0044870C
		public ICheckDirectionConditionT AsICheckDirectionCondition()
		{
			return this.As<ICheckDirectionConditionT>();
		}

		// Token: 0x0601EB26 RID: 125734 RVA: 0x0044A514 File Offset: 0x00448714
		public static ICondition2_UnionUnion FromICheckDirectionCondition(ICheckDirectionConditionT _icheckdirectioncondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckDirectionCondition,
				Value = _icheckdirectioncondition
			};
		}

		// Token: 0x0601EB27 RID: 125735 RVA: 0x0044A52A File Offset: 0x0044872A
		public ICheckSceneItemDirectionConditionT AsICheckSceneItemDirectionCondition()
		{
			return this.As<ICheckSceneItemDirectionConditionT>();
		}

		// Token: 0x0601EB28 RID: 125736 RVA: 0x0044A532 File Offset: 0x00448732
		public static ICondition2_UnionUnion FromICheckSceneItemDirectionCondition(ICheckSceneItemDirectionConditionT _ichecksceneitemdirectioncondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckSceneItemDirectionCondition,
				Value = _ichecksceneitemdirectioncondition
			};
		}

		// Token: 0x0601EB29 RID: 125737 RVA: 0x0044A548 File Offset: 0x00448748
		public ICheckPlayerFaceToConditionT AsICheckPlayerFaceToCondition()
		{
			return this.As<ICheckPlayerFaceToConditionT>();
		}

		// Token: 0x0601EB2A RID: 125738 RVA: 0x0044A550 File Offset: 0x00448750
		public static ICondition2_UnionUnion FromICheckPlayerFaceToCondition(ICheckPlayerFaceToConditionT _icheckplayerfacetocondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerFaceToCondition,
				Value = _icheckplayerfacetocondition
			};
		}

		// Token: 0x0601EB2B RID: 125739 RVA: 0x0044A566 File Offset: 0x00448766
		public ICheckPlayerCanJoinActivityConditionT AsICheckPlayerCanJoinActivityCondition()
		{
			return this.As<ICheckPlayerCanJoinActivityConditionT>();
		}

		// Token: 0x0601EB2C RID: 125740 RVA: 0x0044A56E File Offset: 0x0044876E
		public static ICondition2_UnionUnion FromICheckPlayerCanJoinActivityCondition(ICheckPlayerCanJoinActivityConditionT _icheckplayercanjoinactivitycondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerCanJoinActivityCondition,
				Value = _icheckplayercanjoinactivitycondition
			};
		}

		// Token: 0x0601EB2D RID: 125741 RVA: 0x0044A584 File Offset: 0x00448784
		public ICheckSystemStateConditionT AsICheckSystemStateCondition()
		{
			return this.As<ICheckSystemStateConditionT>();
		}

		// Token: 0x0601EB2E RID: 125742 RVA: 0x0044A58C File Offset: 0x0044878C
		public static ICondition2_UnionUnion FromICheckSystemStateCondition(ICheckSystemStateConditionT _ichecksystemstatecondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckSystemStateCondition,
				Value = _ichecksystemstatecondition
			};
		}

		// Token: 0x0601EB2F RID: 125743 RVA: 0x0044A5A2 File Offset: 0x004487A2
		public ICheckInRangeConditionT AsICheckInRangeCondition()
		{
			return this.As<ICheckInRangeConditionT>();
		}

		// Token: 0x0601EB30 RID: 125744 RVA: 0x0044A5AA File Offset: 0x004487AA
		public static ICondition2_UnionUnion FromICheckInRangeCondition(ICheckInRangeConditionT _icheckinrangecondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckInRangeCondition,
				Value = _icheckinrangecondition
			};
		}

		// Token: 0x0601EB31 RID: 125745 RVA: 0x0044A5C0 File Offset: 0x004487C0
		public ICheckInRangeProperlyConditionT AsICheckInRangeProperlyCondition()
		{
			return this.As<ICheckInRangeProperlyConditionT>();
		}

		// Token: 0x0601EB32 RID: 125746 RVA: 0x0044A5C8 File Offset: 0x004487C8
		public static ICondition2_UnionUnion FromICheckInRangeProperlyCondition(ICheckInRangeProperlyConditionT _icheckinrangeproperlycondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckInRangeProperlyCondition,
				Value = _icheckinrangeproperlycondition
			};
		}

		// Token: 0x0601EB33 RID: 125747 RVA: 0x0044A5DE File Offset: 0x004487DE
		public ICheckEntityLockedConditionT AsICheckEntityLockedCondition()
		{
			return this.As<ICheckEntityLockedConditionT>();
		}

		// Token: 0x0601EB34 RID: 125748 RVA: 0x0044A5E6 File Offset: 0x004487E6
		public static ICondition2_UnionUnion FromICheckEntityLockedCondition(ICheckEntityLockedConditionT _icheckentitylockedcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntityLockedCondition,
				Value = _icheckentitylockedcondition
			};
		}

		// Token: 0x0601EB35 RID: 125749 RVA: 0x0044A5FC File Offset: 0x004487FC
		public ICompareTeammateDieConditionT AsICompareTeammateDieCondition()
		{
			return this.As<ICompareTeammateDieConditionT>();
		}

		// Token: 0x0601EB36 RID: 125750 RVA: 0x0044A604 File Offset: 0x00448804
		public static ICondition2_UnionUnion FromICompareTeammateDieCondition(ICompareTeammateDieConditionT _icompareteammatediecondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareTeammateDieCondition,
				Value = _icompareteammatediecondition
			};
		}

		// Token: 0x0601EB37 RID: 125751 RVA: 0x0044A61A File Offset: 0x0044881A
		public IListenEntitySelfEventConditionT AsIListenEntitySelfEventCondition()
		{
			return this.As<IListenEntitySelfEventConditionT>();
		}

		// Token: 0x0601EB38 RID: 125752 RVA: 0x0044A622 File Offset: 0x00448822
		public static ICondition2_UnionUnion FromIListenEntitySelfEventCondition(IListenEntitySelfEventConditionT _ilistenentityselfeventcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.IListenEntitySelfEventCondition,
				Value = _ilistenentityselfeventcondition
			};
		}

		// Token: 0x0601EB39 RID: 125753 RVA: 0x0044A638 File Offset: 0x00448838
		public ICheckEntityDistanceConditionT AsICheckEntityDistanceCondition()
		{
			return this.As<ICheckEntityDistanceConditionT>();
		}

		// Token: 0x0601EB3A RID: 125754 RVA: 0x0044A640 File Offset: 0x00448840
		public static ICondition2_UnionUnion FromICheckEntityDistanceCondition(ICheckEntityDistanceConditionT _icheckentitydistancecondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntityDistanceCondition,
				Value = _icheckentitydistancecondition
			};
		}

		// Token: 0x0601EB3B RID: 125755 RVA: 0x0044A656 File Offset: 0x00448856
		public ICheckEntityHasSceneItemAttributeTagT AsICheckEntityHasSceneItemAttributeTag()
		{
			return this.As<ICheckEntityHasSceneItemAttributeTagT>();
		}

		// Token: 0x0601EB3C RID: 125756 RVA: 0x0044A65E File Offset: 0x0044885E
		public static ICondition2_UnionUnion FromICheckEntityHasSceneItemAttributeTag(ICheckEntityHasSceneItemAttributeTagT _icheckentityhassceneitemattributetag)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntityHasSceneItemAttributeTag,
				Value = _icheckentityhassceneitemattributetag
			};
		}

		// Token: 0x0601EB3D RID: 125757 RVA: 0x0044A674 File Offset: 0x00448874
		public IListenEntityThroughPortalT AsIListenEntityThroughPortal()
		{
			return this.As<IListenEntityThroughPortalT>();
		}

		// Token: 0x0601EB3E RID: 125758 RVA: 0x0044A67C File Offset: 0x0044887C
		public static ICondition2_UnionUnion FromIListenEntityThroughPortal(IListenEntityThroughPortalT _ilistenentitythroughportal)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.IListenEntityThroughPortal,
				Value = _ilistenentitythroughportal
			};
		}

		// Token: 0x0601EB3F RID: 125759 RVA: 0x0044A692 File Offset: 0x00448892
		public ICheckTeleControlStateT AsICheckTeleControlState()
		{
			return this.As<ICheckTeleControlStateT>();
		}

		// Token: 0x0601EB40 RID: 125760 RVA: 0x0044A69A File Offset: 0x0044889A
		public static ICondition2_UnionUnion FromICheckTeleControlState(ICheckTeleControlStateT _ichecktelecontrolstate)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckTeleControlState,
				Value = _ichecktelecontrolstate
			};
		}

		// Token: 0x0601EB41 RID: 125761 RVA: 0x0044A6B0 File Offset: 0x004488B0
		public ICustomJsonConditionT AsICustomJsonCondition()
		{
			return this.As<ICustomJsonConditionT>();
		}

		// Token: 0x0601EB42 RID: 125762 RVA: 0x0044A6B8 File Offset: 0x004488B8
		public static ICondition2_UnionUnion FromICustomJsonCondition(ICustomJsonConditionT _icustomjsoncondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICustomJsonCondition,
				Value = _icustomjsoncondition
			};
		}

		// Token: 0x0601EB43 RID: 125763 RVA: 0x0044A6CE File Offset: 0x004488CE
		public ICheckChessWinnerT AsICheckChessWinner()
		{
			return this.As<ICheckChessWinnerT>();
		}

		// Token: 0x0601EB44 RID: 125764 RVA: 0x0044A6D6 File Offset: 0x004488D6
		public static ICondition2_UnionUnion FromICheckChessWinner(ICheckChessWinnerT _icheckchesswinner)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckChessWinner,
				Value = _icheckchesswinner
			};
		}

		// Token: 0x0601EB45 RID: 125765 RVA: 0x0044A6EC File Offset: 0x004488EC
		public ICheckVehicleConditionT AsICheckVehicleCondition()
		{
			return this.As<ICheckVehicleConditionT>();
		}

		// Token: 0x0601EB46 RID: 125766 RVA: 0x0044A6F4 File Offset: 0x004488F4
		public static ICondition2_UnionUnion FromICheckVehicleCondition(ICheckVehicleConditionT _icheckvehiclecondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckVehicleCondition,
				Value = _icheckvehiclecondition
			};
		}

		// Token: 0x0601EB47 RID: 125767 RVA: 0x0044A70A File Offset: 0x0044890A
		public ICompareAlertValueT AsICompareAlertValue()
		{
			return this.As<ICompareAlertValueT>();
		}

		// Token: 0x0601EB48 RID: 125768 RVA: 0x0044A712 File Offset: 0x00448912
		public static ICondition2_UnionUnion FromICompareAlertValue(ICompareAlertValueT _icomparealertvalue)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareAlertValue,
				Value = _icomparealertvalue
			};
		}

		// Token: 0x0601EB49 RID: 125769 RVA: 0x0044A728 File Offset: 0x00448928
		public ICheckEntityGravityDirectionT AsICheckEntityGravityDirection()
		{
			return this.As<ICheckEntityGravityDirectionT>();
		}

		// Token: 0x0601EB4A RID: 125770 RVA: 0x0044A730 File Offset: 0x00448930
		public static ICondition2_UnionUnion FromICheckEntityGravityDirection(ICheckEntityGravityDirectionT _icheckentitygravitydirection)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntityGravityDirection,
				Value = _icheckentitygravitydirection
			};
		}

		// Token: 0x0601EB4B RID: 125771 RVA: 0x0044A746 File Offset: 0x00448946
		public ICheckCollectAnimalPartsT AsICheckCollectAnimalParts()
		{
			return this.As<ICheckCollectAnimalPartsT>();
		}

		// Token: 0x0601EB4C RID: 125772 RVA: 0x0044A74E File Offset: 0x0044894E
		public static ICondition2_UnionUnion FromICheckCollectAnimalParts(ICheckCollectAnimalPartsT _icheckcollectanimalparts)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckCollectAnimalParts,
				Value = _icheckcollectanimalparts
			};
		}

		// Token: 0x0601EB4D RID: 125773 RVA: 0x0044A764 File Offset: 0x00448964
		public ICheckFinishLoadingT AsICheckFinishLoading()
		{
			return this.As<ICheckFinishLoadingT>();
		}

		// Token: 0x0601EB4E RID: 125774 RVA: 0x0044A76C File Offset: 0x0044896C
		public static ICondition2_UnionUnion FromICheckFinishLoading(ICheckFinishLoadingT _icheckfinishloading)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckFinishLoading,
				Value = _icheckfinishloading
			};
		}

		// Token: 0x0601EB4F RID: 125775 RVA: 0x0044A782 File Offset: 0x00448982
		public ICheckFishingPointHasFishT AsICheckFishingPointHasFish()
		{
			return this.As<ICheckFishingPointHasFishT>();
		}

		// Token: 0x0601EB50 RID: 125776 RVA: 0x0044A78A File Offset: 0x0044898A
		public static ICondition2_UnionUnion FromICheckFishingPointHasFish(ICheckFishingPointHasFishT _icheckfishingpointhasfish)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckFishingPointHasFish,
				Value = _icheckfishingpointhasfish
			};
		}

		// Token: 0x0601EB51 RID: 125777 RVA: 0x0044A7A0 File Offset: 0x004489A0
		public ICheckFishingCageFillingRatioT AsICheckFishingCageFillingRatio()
		{
			return this.As<ICheckFishingCageFillingRatioT>();
		}

		// Token: 0x0601EB52 RID: 125778 RVA: 0x0044A7A8 File Offset: 0x004489A8
		public static ICondition2_UnionUnion FromICheckFishingCageFillingRatio(ICheckFishingCageFillingRatioT _icheckfishingcagefillingratio)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckFishingCageFillingRatio,
				Value = _icheckfishingcagefillingratio
			};
		}

		// Token: 0x0601EB53 RID: 125779 RVA: 0x0044A7BE File Offset: 0x004489BE
		public ICompareFishingTechLevelT AsICompareFishingTechLevel()
		{
			return this.As<ICompareFishingTechLevelT>();
		}

		// Token: 0x0601EB54 RID: 125780 RVA: 0x0044A7C6 File Offset: 0x004489C6
		public static ICondition2_UnionUnion FromICompareFishingTechLevel(ICompareFishingTechLevelT _icomparefishingtechlevel)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareFishingTechLevel,
				Value = _icomparefishingtechlevel
			};
		}

		// Token: 0x0601EB55 RID: 125781 RVA: 0x0044A7DC File Offset: 0x004489DC
		public ICheckGuestCharacterT AsICheckGuestCharacter()
		{
			return this.As<ICheckGuestCharacterT>();
		}

		// Token: 0x0601EB56 RID: 125782 RVA: 0x0044A7E4 File Offset: 0x004489E4
		public static ICondition2_UnionUnion FromICheckGuestCharacter(ICheckGuestCharacterT _icheckguestcharacter)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckGuestCharacter,
				Value = _icheckguestcharacter
			};
		}

		// Token: 0x0601EB57 RID: 125783 RVA: 0x0044A7FA File Offset: 0x004489FA
		public ICheckSubLevelStateT AsICheckSubLevelState()
		{
			return this.As<ICheckSubLevelStateT>();
		}

		// Token: 0x0601EB58 RID: 125784 RVA: 0x0044A802 File Offset: 0x00448A02
		public static ICondition2_UnionUnion FromICheckSubLevelState(ICheckSubLevelStateT _ichecksublevelstate)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckSubLevelState,
				Value = _ichecksublevelstate
			};
		}

		// Token: 0x0601EB59 RID: 125785 RVA: 0x0044A818 File Offset: 0x00448A18
		public IComparePlayerNumInDungeonT AsIComparePlayerNumInDungeon()
		{
			return this.As<IComparePlayerNumInDungeonT>();
		}

		// Token: 0x0601EB5A RID: 125786 RVA: 0x0044A820 File Offset: 0x00448A20
		public static ICondition2_UnionUnion FromIComparePlayerNumInDungeon(IComparePlayerNumInDungeonT _icompareplayernumindungeon)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.IComparePlayerNumInDungeon,
				Value = _icompareplayernumindungeon
			};
		}

		// Token: 0x0601EB5B RID: 125787 RVA: 0x0044A836 File Offset: 0x00448A36
		public ICheckAlertAreaEnabledT AsICheckAlertAreaEnabled()
		{
			return this.As<ICheckAlertAreaEnabledT>();
		}

		// Token: 0x0601EB5C RID: 125788 RVA: 0x0044A83E File Offset: 0x00448A3E
		public static ICondition2_UnionUnion FromICheckAlertAreaEnabled(ICheckAlertAreaEnabledT _icheckalertareaenabled)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckAlertAreaEnabled,
				Value = _icheckalertareaenabled
			};
		}

		// Token: 0x0601EB5D RID: 125789 RVA: 0x0044A854 File Offset: 0x00448A54
		public ICheckClientEventT AsICheckClientEvent()
		{
			return this.As<ICheckClientEventT>();
		}

		// Token: 0x0601EB5E RID: 125790 RVA: 0x0044A85C File Offset: 0x00448A5C
		public static ICondition2_UnionUnion FromICheckClientEvent(ICheckClientEventT _icheckclientevent)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckClientEvent,
				Value = _icheckclientevent
			};
		}

		// Token: 0x0601EB5F RID: 125791 RVA: 0x0044A872 File Offset: 0x00448A72
		public ICheckIsGramophonePlayingMusicT AsICheckIsGramophonePlayingMusic()
		{
			return this.As<ICheckIsGramophonePlayingMusicT>();
		}

		// Token: 0x0601EB60 RID: 125792 RVA: 0x0044A87A File Offset: 0x00448A7A
		public static ICondition2_UnionUnion FromICheckIsGramophonePlayingMusic(ICheckIsGramophonePlayingMusicT _icheckisgramophoneplayingmusic)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsGramophonePlayingMusic,
				Value = _icheckisgramophoneplayingmusic
			};
		}

		// Token: 0x0601EB61 RID: 125793 RVA: 0x0044A890 File Offset: 0x00448A90
		public ICheckEntityRewardT AsICheckEntityReward()
		{
			return this.As<ICheckEntityRewardT>();
		}

		// Token: 0x0601EB62 RID: 125794 RVA: 0x0044A898 File Offset: 0x00448A98
		public static ICondition2_UnionUnion FromICheckEntityReward(ICheckEntityRewardT _icheckentityreward)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntityReward,
				Value = _icheckentityreward
			};
		}

		// Token: 0x0601EB63 RID: 125795 RVA: 0x0044A8AE File Offset: 0x00448AAE
		public ICheckDungeonHasSaveConfigT AsICheckDungeonHasSaveConfig()
		{
			return this.As<ICheckDungeonHasSaveConfigT>();
		}

		// Token: 0x0601EB64 RID: 125796 RVA: 0x0044A8B6 File Offset: 0x00448AB6
		public static ICondition2_UnionUnion FromICheckDungeonHasSaveConfig(ICheckDungeonHasSaveConfigT _icheckdungeonhassaveconfig)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckDungeonHasSaveConfig,
				Value = _icheckdungeonhassaveconfig
			};
		}

		// Token: 0x0601EB65 RID: 125797 RVA: 0x0044A8CC File Offset: 0x00448ACC
		public ICheckSystemEventBvbT AsICheckSystemEventBvb()
		{
			return this.As<ICheckSystemEventBvbT>();
		}

		// Token: 0x0601EB66 RID: 125798 RVA: 0x0044A8D4 File Offset: 0x00448AD4
		public static ICondition2_UnionUnion FromICheckSystemEventBvb(ICheckSystemEventBvbT _ichecksystemeventbvb)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckSystemEventBvb,
				Value = _ichecksystemeventbvb
			};
		}

		// Token: 0x0601EB67 RID: 125799 RVA: 0x0044A8EA File Offset: 0x00448AEA
		public ICheckDangoCultivationProgressT AsICheckDangoCultivationProgress()
		{
			return this.As<ICheckDangoCultivationProgressT>();
		}

		// Token: 0x0601EB68 RID: 125800 RVA: 0x0044A8F2 File Offset: 0x00448AF2
		public static ICondition2_UnionUnion FromICheckDangoCultivationProgress(ICheckDangoCultivationProgressT _icheckdangocultivationprogress)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckDangoCultivationProgress,
				Value = _icheckdangocultivationprogress
			};
		}

		// Token: 0x0601EB69 RID: 125801 RVA: 0x0044A908 File Offset: 0x00448B08
		public ICheckPlayerMoraleLevelRangeT AsICheckPlayerMoraleLevelRange()
		{
			return this.As<ICheckPlayerMoraleLevelRangeT>();
		}

		// Token: 0x0601EB6A RID: 125802 RVA: 0x0044A910 File Offset: 0x00448B10
		public static ICondition2_UnionUnion FromICheckPlayerMoraleLevelRange(ICheckPlayerMoraleLevelRangeT _icheckplayermoralelevelrange)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerMoraleLevelRange,
				Value = _icheckplayermoralelevelrange
			};
		}

		// Token: 0x0601EB6B RID: 125803 RVA: 0x0044A926 File Offset: 0x00448B26
		public ICheckIsGlobalTimeScaleEnabledT AsICheckIsGlobalTimeScaleEnabled()
		{
			return this.As<ICheckIsGlobalTimeScaleEnabledT>();
		}

		// Token: 0x0601EB6C RID: 125804 RVA: 0x0044A92E File Offset: 0x00448B2E
		public static ICondition2_UnionUnion FromICheckIsGlobalTimeScaleEnabled(ICheckIsGlobalTimeScaleEnabledT _icheckisglobaltimescaleenabled)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsGlobalTimeScaleEnabled,
				Value = _icheckisglobaltimescaleenabled
			};
		}

		// Token: 0x0601EB6D RID: 125805 RVA: 0x0044A944 File Offset: 0x00448B44
		public ISaveConfigEnterMethodT AsISaveConfigEnterMethod()
		{
			return this.As<ISaveConfigEnterMethodT>();
		}

		// Token: 0x0601EB6E RID: 125806 RVA: 0x0044A94C File Offset: 0x00448B4C
		public static ICondition2_UnionUnion FromISaveConfigEnterMethod(ISaveConfigEnterMethodT _isaveconfigentermethod)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ISaveConfigEnterMethod,
				Value = _isaveconfigentermethod
			};
		}

		// Token: 0x0601EB6F RID: 125807 RVA: 0x0044A962 File Offset: 0x00448B62
		public ICheckIsEntityTimeScaleEnabledT AsICheckIsEntityTimeScaleEnabled()
		{
			return this.As<ICheckIsEntityTimeScaleEnabledT>();
		}

		// Token: 0x0601EB70 RID: 125808 RVA: 0x0044A96A File Offset: 0x00448B6A
		public static ICondition2_UnionUnion FromICheckIsEntityTimeScaleEnabled(ICheckIsEntityTimeScaleEnabledT _icheckisentitytimescaleenabled)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsEntityTimeScaleEnabled,
				Value = _icheckisentitytimescaleenabled
			};
		}

		// Token: 0x0601EB71 RID: 125809 RVA: 0x0044A980 File Offset: 0x00448B80
		public ICheckIsCharacterHoldingHandsT AsICheckIsCharacterHoldingHands()
		{
			return this.As<ICheckIsCharacterHoldingHandsT>();
		}

		// Token: 0x0601EB72 RID: 125810 RVA: 0x0044A988 File Offset: 0x00448B88
		public static ICondition2_UnionUnion FromICheckIsCharacterHoldingHands(ICheckIsCharacterHoldingHandsT _icheckischaracterholdinghands)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsCharacterHoldingHands,
				Value = _icheckischaracterholdinghands
			};
		}

		// Token: 0x0601EB73 RID: 125811 RVA: 0x0044A99E File Offset: 0x00448B9E
		public ICheckIsTrackingCurrentQuestT AsICheckIsTrackingCurrentQuest()
		{
			return this.As<ICheckIsTrackingCurrentQuestT>();
		}

		// Token: 0x0601EB74 RID: 125812 RVA: 0x0044A9A6 File Offset: 0x00448BA6
		public static ICondition2_UnionUnion FromICheckIsTrackingCurrentQuest(ICheckIsTrackingCurrentQuestT _icheckistrackingcurrentquest)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsTrackingCurrentQuest,
				Value = _icheckistrackingcurrentquest
			};
		}

		// Token: 0x0601EB75 RID: 125813 RVA: 0x0044A9BC File Offset: 0x00448BBC
		public ICheckIsTrackingQuestT AsICheckIsTrackingQuest()
		{
			return this.As<ICheckIsTrackingQuestT>();
		}

		// Token: 0x0601EB76 RID: 125814 RVA: 0x0044A9C4 File Offset: 0x00448BC4
		public static ICondition2_UnionUnion FromICheckIsTrackingQuest(ICheckIsTrackingQuestT _icheckistrackingquest)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsTrackingQuest,
				Value = _icheckistrackingquest
			};
		}

		// Token: 0x0601EB77 RID: 125815 RVA: 0x0044A9DA File Offset: 0x00448BDA
		public ICheckMusicEventT AsICheckMusicEvent()
		{
			return this.As<ICheckMusicEventT>();
		}

		// Token: 0x0601EB78 RID: 125816 RVA: 0x0044A9E2 File Offset: 0x00448BE2
		public static ICondition2_UnionUnion FromICheckMusicEvent(ICheckMusicEventT _icheckmusicevent)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckMusicEvent,
				Value = _icheckmusicevent
			};
		}

		// Token: 0x0601EB79 RID: 125817 RVA: 0x0044A9F8 File Offset: 0x00448BF8
		public ICompareGameDifficultyT AsICompareGameDifficulty()
		{
			return this.As<ICompareGameDifficultyT>();
		}

		// Token: 0x0601EB7A RID: 125818 RVA: 0x0044AA00 File Offset: 0x00448C00
		public static ICondition2_UnionUnion FromICompareGameDifficulty(ICompareGameDifficultyT _icomparegamedifficulty)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareGameDifficulty,
				Value = _icomparegamedifficulty
			};
		}

		// Token: 0x0601EB7B RID: 125819 RVA: 0x0044AA16 File Offset: 0x00448C16
		public ICheckPhotographCameraParamT AsICheckPhotographCameraParam()
		{
			return this.As<ICheckPhotographCameraParamT>();
		}

		// Token: 0x0601EB7C RID: 125820 RVA: 0x0044AA1E File Offset: 0x00448C1E
		public static ICondition2_UnionUnion FromICheckPhotographCameraParam(ICheckPhotographCameraParamT _icheckphotographcameraparam)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPhotographCameraParam,
				Value = _icheckphotographcameraparam
			};
		}

		// Token: 0x0601EB7D RID: 125821 RVA: 0x0044AA34 File Offset: 0x00448C34
		public ICheckEntityHasBuffT AsICheckEntityHasBuff()
		{
			return this.As<ICheckEntityHasBuffT>();
		}

		// Token: 0x0601EB7E RID: 125822 RVA: 0x0044AA3C File Offset: 0x00448C3C
		public static ICondition2_UnionUnion FromICheckEntityHasBuff(ICheckEntityHasBuffT _icheckentityhasbuff)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntityHasBuff,
				Value = _icheckentityhasbuff
			};
		}

		// Token: 0x0601EB7F RID: 125823 RVA: 0x0044AA52 File Offset: 0x00448C52
		public ICheckEntityBuffStackT AsICheckEntityBuffStack()
		{
			return this.As<ICheckEntityBuffStackT>();
		}

		// Token: 0x0601EB80 RID: 125824 RVA: 0x0044AA5A File Offset: 0x00448C5A
		public static ICondition2_UnionUnion FromICheckEntityBuffStack(ICheckEntityBuffStackT _icheckentitybuffstack)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntityBuffStack,
				Value = _icheckentitybuffstack
			};
		}

		// Token: 0x0601EB81 RID: 125825 RVA: 0x0044AA70 File Offset: 0x00448C70
		public ICheckAvailableSunSpiritCountT AsICheckAvailableSunSpiritCount()
		{
			return this.As<ICheckAvailableSunSpiritCountT>();
		}

		// Token: 0x0601EB82 RID: 125826 RVA: 0x0044AA78 File Offset: 0x00448C78
		public static ICondition2_UnionUnion FromICheckAvailableSunSpiritCount(ICheckAvailableSunSpiritCountT _icheckavailablesunspiritcount)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckAvailableSunSpiritCount,
				Value = _icheckavailablesunspiritcount
			};
		}

		// Token: 0x0601EB83 RID: 125827 RVA: 0x0044AA8E File Offset: 0x00448C8E
		public ICheckPlayerEnterClientTriggerDirT AsICheckPlayerEnterClientTriggerDir()
		{
			return this.As<ICheckPlayerEnterClientTriggerDirT>();
		}

		// Token: 0x0601EB84 RID: 125828 RVA: 0x0044AA96 File Offset: 0x00448C96
		public static ICondition2_UnionUnion FromICheckPlayerEnterClientTriggerDir(ICheckPlayerEnterClientTriggerDirT _icheckplayerenterclienttriggerdir)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerEnterClientTriggerDir,
				Value = _icheckplayerenterclienttriggerdir
			};
		}

		// Token: 0x0601EB85 RID: 125829 RVA: 0x0044AAAC File Offset: 0x00448CAC
		public ICheckPlayerRelativeDistanceT AsICheckPlayerRelativeDistance()
		{
			return this.As<ICheckPlayerRelativeDistanceT>();
		}

		// Token: 0x0601EB86 RID: 125830 RVA: 0x0044AAB4 File Offset: 0x00448CB4
		public static ICondition2_UnionUnion FromICheckPlayerRelativeDistance(ICheckPlayerRelativeDistanceT _icheckplayerrelativedistance)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerRelativeDistance,
				Value = _icheckplayerrelativedistance
			};
		}

		// Token: 0x0601EB87 RID: 125831 RVA: 0x0044AACA File Offset: 0x00448CCA
		public ICheckPlayerRelativeAngleT AsICheckPlayerRelativeAngle()
		{
			return this.As<ICheckPlayerRelativeAngleT>();
		}

		// Token: 0x0601EB88 RID: 125832 RVA: 0x0044AAD2 File Offset: 0x00448CD2
		public static ICondition2_UnionUnion FromICheckPlayerRelativeAngle(ICheckPlayerRelativeAngleT _icheckplayerrelativeangle)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerRelativeAngle,
				Value = _icheckplayerrelativeangle
			};
		}

		// Token: 0x0601EB89 RID: 125833 RVA: 0x0044AAE8 File Offset: 0x00448CE8
		public ICheckHonamiStoryGetItemT AsICheckHonamiStoryGetItem()
		{
			return this.As<ICheckHonamiStoryGetItemT>();
		}

		// Token: 0x0601EB8A RID: 125834 RVA: 0x0044AAF0 File Offset: 0x00448CF0
		public static ICondition2_UnionUnion FromICheckHonamiStoryGetItem(ICheckHonamiStoryGetItemT _icheckhonamistorygetitem)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHonamiStoryGetItem,
				Value = _icheckhonamistorygetitem
			};
		}

		// Token: 0x0601EB8B RID: 125835 RVA: 0x0044AB06 File Offset: 0x00448D06
		public ICheckHonamiStoryEquipItemT AsICheckHonamiStoryEquipItem()
		{
			return this.As<ICheckHonamiStoryEquipItemT>();
		}

		// Token: 0x0601EB8C RID: 125836 RVA: 0x0044AB0E File Offset: 0x00448D0E
		public static ICondition2_UnionUnion FromICheckHonamiStoryEquipItem(ICheckHonamiStoryEquipItemT _icheckhonamistoryequipitem)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHonamiStoryEquipItem,
				Value = _icheckhonamistoryequipitem
			};
		}

		// Token: 0x0601EB8D RID: 125837 RVA: 0x0044AB24 File Offset: 0x00448D24
		public ICheckHonamiStoryActivateTalentT AsICheckHonamiStoryActivateTalent()
		{
			return this.As<ICheckHonamiStoryActivateTalentT>();
		}

		// Token: 0x0601EB8E RID: 125838 RVA: 0x0044AB2C File Offset: 0x00448D2C
		public static ICondition2_UnionUnion FromICheckHonamiStoryActivateTalent(ICheckHonamiStoryActivateTalentT _icheckhonamistoryactivatetalent)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHonamiStoryActivateTalent,
				Value = _icheckhonamistoryactivatetalent
			};
		}

		// Token: 0x0601EB8F RID: 125839 RVA: 0x0044AB42 File Offset: 0x00448D42
		public ICheckHonamiStoryUnlockSlotT AsICheckHonamiStoryUnlockSlot()
		{
			return this.As<ICheckHonamiStoryUnlockSlotT>();
		}

		// Token: 0x0601EB90 RID: 125840 RVA: 0x0044AB4A File Offset: 0x00448D4A
		public static ICondition2_UnionUnion FromICheckHonamiStoryUnlockSlot(ICheckHonamiStoryUnlockSlotT _icheckhonamistoryunlockslot)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHonamiStoryUnlockSlot,
				Value = _icheckhonamistoryunlockslot
			};
		}

		// Token: 0x0601EB91 RID: 125841 RVA: 0x0044AB60 File Offset: 0x00448D60
		public ICheckHonamiStoryLifeSupportLevelT AsICheckHonamiStoryLifeSupportLevel()
		{
			return this.As<ICheckHonamiStoryLifeSupportLevelT>();
		}

		// Token: 0x0601EB92 RID: 125842 RVA: 0x0044AB68 File Offset: 0x00448D68
		public static ICondition2_UnionUnion FromICheckHonamiStoryLifeSupportLevel(ICheckHonamiStoryLifeSupportLevelT _icheckhonamistorylifesupportlevel)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHonamiStoryLifeSupportLevel,
				Value = _icheckhonamistorylifesupportlevel
			};
		}

		// Token: 0x0601EB93 RID: 125843 RVA: 0x0044AB7E File Offset: 0x00448D7E
		public ICheckHonamiStoryTowerCompleteT AsICheckHonamiStoryTowerComplete()
		{
			return this.As<ICheckHonamiStoryTowerCompleteT>();
		}

		// Token: 0x0601EB94 RID: 125844 RVA: 0x0044AB86 File Offset: 0x00448D86
		public static ICondition2_UnionUnion FromICheckHonamiStoryTowerComplete(ICheckHonamiStoryTowerCompleteT _icheckhonamistorytowercomplete)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHonamiStoryTowerComplete,
				Value = _icheckhonamistorytowercomplete
			};
		}

		// Token: 0x0601EB95 RID: 125845 RVA: 0x0044AB9C File Offset: 0x00448D9C
		public ICheckHonamiStoryPlayerCorruptedLevelT AsICheckHonamiStoryPlayerCorruptedLevel()
		{
			return this.As<ICheckHonamiStoryPlayerCorruptedLevelT>();
		}

		// Token: 0x0601EB96 RID: 125846 RVA: 0x0044ABA4 File Offset: 0x00448DA4
		public static ICondition2_UnionUnion FromICheckHonamiStoryPlayerCorruptedLevel(ICheckHonamiStoryPlayerCorruptedLevelT _icheckhonamistoryplayercorruptedlevel)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHonamiStoryPlayerCorruptedLevel,
				Value = _icheckhonamistoryplayercorruptedlevel
			};
		}

		// Token: 0x0601EB97 RID: 125847 RVA: 0x0044ABBA File Offset: 0x00448DBA
		public ICheckHonamiStoryUnlockMascotT AsICheckHonamiStoryUnlockMascot()
		{
			return this.As<ICheckHonamiStoryUnlockMascotT>();
		}

		// Token: 0x0601EB98 RID: 125848 RVA: 0x0044ABC2 File Offset: 0x00448DC2
		public static ICondition2_UnionUnion FromICheckHonamiStoryUnlockMascot(ICheckHonamiStoryUnlockMascotT _icheckhonamistoryunlockmascot)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHonamiStoryUnlockMascot,
				Value = _icheckhonamistoryunlockmascot
			};
		}

		// Token: 0x0601EB99 RID: 125849 RVA: 0x0044ABD8 File Offset: 0x00448DD8
		public ICheckHonamiStoryChestOpenTimeT AsICheckHonamiStoryChestOpenTime()
		{
			return this.As<ICheckHonamiStoryChestOpenTimeT>();
		}

		// Token: 0x0601EB9A RID: 125850 RVA: 0x0044ABE0 File Offset: 0x00448DE0
		public static ICondition2_UnionUnion FromICheckHonamiStoryChestOpenTime(ICheckHonamiStoryChestOpenTimeT _icheckhonamistorychestopentime)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHonamiStoryChestOpenTime,
				Value = _icheckhonamistorychestopentime
			};
		}

		// Token: 0x0601EB9B RID: 125851 RVA: 0x0044ABF6 File Offset: 0x00448DF6
		public ICheckHonamiStorySuccessfulEvacuationT AsICheckHonamiStorySuccessfulEvacuation()
		{
			return this.As<ICheckHonamiStorySuccessfulEvacuationT>();
		}

		// Token: 0x0601EB9C RID: 125852 RVA: 0x0044ABFE File Offset: 0x00448DFE
		public static ICondition2_UnionUnion FromICheckHonamiStorySuccessfulEvacuation(ICheckHonamiStorySuccessfulEvacuationT _icheckhonamistorysuccessfulevacuation)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHonamiStorySuccessfulEvacuation,
				Value = _icheckhonamistorysuccessfulevacuation
			};
		}

		// Token: 0x0601EB9D RID: 125853 RVA: 0x0044AC14 File Offset: 0x00448E14
		public ICheckBvbChallengeStateT AsICheckBvbChallengeState()
		{
			return this.As<ICheckBvbChallengeStateT>();
		}

		// Token: 0x0601EB9E RID: 125854 RVA: 0x0044AC1C File Offset: 0x00448E1C
		public static ICondition2_UnionUnion FromICheckBvbChallengeState(ICheckBvbChallengeStateT _icheckbvbchallengestate)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckBvbChallengeState,
				Value = _icheckbvbchallengestate
			};
		}

		// Token: 0x0601EB9F RID: 125855 RVA: 0x0044AC32 File Offset: 0x00448E32
		public ICheckBvbActivityRankT AsICheckBvbActivityRank()
		{
			return this.As<ICheckBvbActivityRankT>();
		}

		// Token: 0x0601EBA0 RID: 125856 RVA: 0x0044AC3A File Offset: 0x00448E3A
		public static ICondition2_UnionUnion FromICheckBvbActivityRank(ICheckBvbActivityRankT _icheckbvbactivityrank)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckBvbActivityRank,
				Value = _icheckbvbactivityrank
			};
		}

		// Token: 0x0601EBA1 RID: 125857 RVA: 0x0044AC50 File Offset: 0x00448E50
		public ICheckCollectedSunSpiritCountT AsICheckCollectedSunSpiritCount()
		{
			return this.As<ICheckCollectedSunSpiritCountT>();
		}

		// Token: 0x0601EBA2 RID: 125858 RVA: 0x0044AC58 File Offset: 0x00448E58
		public static ICondition2_UnionUnion FromICheckCollectedSunSpiritCount(ICheckCollectedSunSpiritCountT _icheckcollectedsunspiritcount)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckCollectedSunSpiritCount,
				Value = _icheckcollectedsunspiritcount
			};
		}

		// Token: 0x0601EBA3 RID: 125859 RVA: 0x0044AC6E File Offset: 0x00448E6E
		public ICheckTargetSunSpiritCollectedT AsICheckTargetSunSpiritCollected()
		{
			return this.As<ICheckTargetSunSpiritCollectedT>();
		}

		// Token: 0x0601EBA4 RID: 125860 RVA: 0x0044AC76 File Offset: 0x00448E76
		public static ICondition2_UnionUnion FromICheckTargetSunSpiritCollected(ICheckTargetSunSpiritCollectedT _ichecktargetsunspiritcollected)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckTargetSunSpiritCollected,
				Value = _ichecktargetsunspiritcollected
			};
		}

		// Token: 0x0601EBA5 RID: 125861 RVA: 0x0044AC8C File Offset: 0x00448E8C
		public ICheckPlayerIsInDeadEyeProcessT AsICheckPlayerIsInDeadEyeProcess()
		{
			return this.As<ICheckPlayerIsInDeadEyeProcessT>();
		}

		// Token: 0x0601EBA6 RID: 125862 RVA: 0x0044AC94 File Offset: 0x00448E94
		public static ICondition2_UnionUnion FromICheckPlayerIsInDeadEyeProcess(ICheckPlayerIsInDeadEyeProcessT _icheckplayerisindeadeyeprocess)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerIsInDeadEyeProcess,
				Value = _icheckplayerisindeadeyeprocess
			};
		}

		// Token: 0x0601EBA7 RID: 125863 RVA: 0x0044ACAA File Offset: 0x00448EAA
		public ICheckEntitySelfDirectionT AsICheckEntitySelfDirection()
		{
			return this.As<ICheckEntitySelfDirectionT>();
		}

		// Token: 0x0601EBA8 RID: 125864 RVA: 0x0044ACB2 File Offset: 0x00448EB2
		public static ICondition2_UnionUnion FromICheckEntitySelfDirection(ICheckEntitySelfDirectionT _icheckentityselfdirection)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntitySelfDirection,
				Value = _icheckentityselfdirection
			};
		}

		// Token: 0x0601EBA9 RID: 125865 RVA: 0x0044ACC8 File Offset: 0x00448EC8
		public ICheckDollGrabItemComboAchievedInOnceDeliveryT AsICheckDollGrabItemComboAchievedInOnceDelivery()
		{
			return this.As<ICheckDollGrabItemComboAchievedInOnceDeliveryT>();
		}

		// Token: 0x0601EBAA RID: 125866 RVA: 0x0044ACD0 File Offset: 0x00448ED0
		public static ICondition2_UnionUnion FromICheckDollGrabItemComboAchievedInOnceDelivery(ICheckDollGrabItemComboAchievedInOnceDeliveryT _icheckdollgrabitemcomboachievedinoncedelivery)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckDollGrabItemComboAchievedInOnceDelivery,
				Value = _icheckdollgrabitemcomboachievedinoncedelivery
			};
		}

		// Token: 0x0601EBAB RID: 125867 RVA: 0x0044ACE6 File Offset: 0x00448EE6
		public ICheckDollGrabShowcaseItemComboAchievedT AsICheckDollGrabShowcaseItemComboAchieved()
		{
			return this.As<ICheckDollGrabShowcaseItemComboAchievedT>();
		}

		// Token: 0x0601EBAC RID: 125868 RVA: 0x0044ACEE File Offset: 0x00448EEE
		public static ICondition2_UnionUnion FromICheckDollGrabShowcaseItemComboAchieved(ICheckDollGrabShowcaseItemComboAchievedT _icheckdollgrabshowcaseitemcomboachieved)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckDollGrabShowcaseItemComboAchieved,
				Value = _icheckdollgrabshowcaseitemcomboachieved
			};
		}

		// Token: 0x0601EBAD RID: 125869 RVA: 0x0044AD04 File Offset: 0x00448F04
		public ICheckRoverRogueAbilitySelectConditionT AsICheckRoverRogueAbilitySelectCondition()
		{
			return this.As<ICheckRoverRogueAbilitySelectConditionT>();
		}

		// Token: 0x0601EBAE RID: 125870 RVA: 0x0044AD0C File Offset: 0x00448F0C
		public static ICondition2_UnionUnion FromICheckRoverRogueAbilitySelectCondition(ICheckRoverRogueAbilitySelectConditionT _icheckroverrogueabilityselectcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckRoverRogueAbilitySelectCondition,
				Value = _icheckroverrogueabilityselectcondition
			};
		}

		// Token: 0x0601EBAF RID: 125871 RVA: 0x0044AD22 File Offset: 0x00448F22
		public ICheckDollGrabMachineFinishedT AsICheckDollGrabMachineFinished()
		{
			return this.As<ICheckDollGrabMachineFinishedT>();
		}

		// Token: 0x0601EBB0 RID: 125872 RVA: 0x0044AD2A File Offset: 0x00448F2A
		public static ICondition2_UnionUnion FromICheckDollGrabMachineFinished(ICheckDollGrabMachineFinishedT _icheckdollgrabmachinefinished)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckDollGrabMachineFinished,
				Value = _icheckdollgrabmachinefinished
			};
		}

		// Token: 0x0601EBB1 RID: 125873 RVA: 0x0044AD40 File Offset: 0x00448F40
		public ICheckTrafficBlockedT AsICheckTrafficBlocked()
		{
			return this.As<ICheckTrafficBlockedT>();
		}

		// Token: 0x0601EBB2 RID: 125874 RVA: 0x0044AD48 File Offset: 0x00448F48
		public static ICondition2_UnionUnion FromICheckTrafficBlocked(ICheckTrafficBlockedT _ichecktrafficblocked)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckTrafficBlocked,
				Value = _ichecktrafficblocked
			};
		}

		// Token: 0x0601EBB3 RID: 125875 RVA: 0x0044AD61 File Offset: 0x00448F61
		public ICheckDrinksPreferenceLevelT AsICheckDrinksPreferenceLevel()
		{
			return this.As<ICheckDrinksPreferenceLevelT>();
		}

		// Token: 0x0601EBB4 RID: 125876 RVA: 0x0044AD69 File Offset: 0x00448F69
		public static ICondition2_UnionUnion FromICheckDrinksPreferenceLevel(ICheckDrinksPreferenceLevelT _icheckdrinkspreferencelevel)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckDrinksPreferenceLevel,
				Value = _icheckdrinkspreferencelevel
			};
		}

		// Token: 0x0601EBB5 RID: 125877 RVA: 0x0044AD82 File Offset: 0x00448F82
		public ICheckPlayerIsInMotorcycleCruiseT AsICheckPlayerIsInMotorcycleCruise()
		{
			return this.As<ICheckPlayerIsInMotorcycleCruiseT>();
		}

		// Token: 0x0601EBB6 RID: 125878 RVA: 0x0044AD8A File Offset: 0x00448F8A
		public static ICondition2_UnionUnion FromICheckPlayerIsInMotorcycleCruise(ICheckPlayerIsInMotorcycleCruiseT _icheckplayerisinmotorcyclecruise)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerIsInMotorcycleCruise,
				Value = _icheckplayerisinmotorcyclecruise
			};
		}

		// Token: 0x0601EBB7 RID: 125879 RVA: 0x0044ADA3 File Offset: 0x00448FA3
		public ICheckTetrisEndlessScoreT AsICheckTetrisEndlessScore()
		{
			return this.As<ICheckTetrisEndlessScoreT>();
		}

		// Token: 0x0601EBB8 RID: 125880 RVA: 0x0044ADAB File Offset: 0x00448FAB
		public static ICondition2_UnionUnion FromICheckTetrisEndlessScore(ICheckTetrisEndlessScoreT _ichecktetrisendlessscore)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckTetrisEndlessScore,
				Value = _ichecktetrisendlessscore
			};
		}

		// Token: 0x0601EBB9 RID: 125881 RVA: 0x0044ADC4 File Offset: 0x00448FC4
		public ICheckAtlasUnlockedT AsICheckAtlasUnlocked()
		{
			return this.As<ICheckAtlasUnlockedT>();
		}

		// Token: 0x0601EBBA RID: 125882 RVA: 0x0044ADCC File Offset: 0x00448FCC
		public static ICondition2_UnionUnion FromICheckAtlasUnlocked(ICheckAtlasUnlockedT _icheckatlasunlocked)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckAtlasUnlocked,
				Value = _icheckatlasunlocked
			};
		}

		// Token: 0x0601EBBB RID: 125883 RVA: 0x0044ADE5 File Offset: 0x00448FE5
		public ICheckSheriffUnlockEndingT AsICheckSheriffUnlockEnding()
		{
			return this.As<ICheckSheriffUnlockEndingT>();
		}

		// Token: 0x0601EBBC RID: 125884 RVA: 0x0044ADED File Offset: 0x00448FED
		public static ICondition2_UnionUnion FromICheckSheriffUnlockEnding(ICheckSheriffUnlockEndingT _ichecksheriffunlockending)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckSheriffUnlockEnding,
				Value = _ichecksheriffunlockending
			};
		}

		// Token: 0x0601EBBD RID: 125885 RVA: 0x0044AE06 File Offset: 0x00449006
		public ICheckIsInDragActorPlayT AsICheckIsInDragActorPlay()
		{
			return this.As<ICheckIsInDragActorPlayT>();
		}

		// Token: 0x0601EBBE RID: 125886 RVA: 0x0044AE0E File Offset: 0x0044900E
		public static ICondition2_UnionUnion FromICheckIsInDragActorPlay(ICheckIsInDragActorPlayT _icheckisindragactorplay)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsInDragActorPlay,
				Value = _icheckisindragactorplay
			};
		}

		// Token: 0x0601EBBF RID: 125887 RVA: 0x0044AE27 File Offset: 0x00449027
		public ICheckIsInDollGrabGamePlayT AsICheckIsInDollGrabGamePlay()
		{
			return this.As<ICheckIsInDollGrabGamePlayT>();
		}

		// Token: 0x0601EBC0 RID: 125888 RVA: 0x0044AE2F File Offset: 0x0044902F
		public static ICondition2_UnionUnion FromICheckIsInDollGrabGamePlay(ICheckIsInDollGrabGamePlayT _icheckisindollgrabgameplay)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsInDollGrabGamePlay,
				Value = _icheckisindollgrabgameplay
			};
		}

		// Token: 0x0601EBC1 RID: 125889 RVA: 0x0044AE48 File Offset: 0x00449048
		public ICheckEntityPrefabPerformanceTypeT AsICheckEntityPrefabPerformanceType()
		{
			return this.As<ICheckEntityPrefabPerformanceTypeT>();
		}

		// Token: 0x0601EBC2 RID: 125890 RVA: 0x0044AE50 File Offset: 0x00449050
		public static ICondition2_UnionUnion FromICheckEntityPrefabPerformanceType(ICheckEntityPrefabPerformanceTypeT _icheckentityprefabperformancetype)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntityPrefabPerformanceType,
				Value = _icheckentityprefabperformancetype
			};
		}

		// Token: 0x0601EBC3 RID: 125891 RVA: 0x0044AE69 File Offset: 0x00449069
		public ICheckIsSupportedWalkingT AsICheckIsSupportedWalking()
		{
			return this.As<ICheckIsSupportedWalkingT>();
		}

		// Token: 0x0601EBC4 RID: 125892 RVA: 0x0044AE71 File Offset: 0x00449071
		public static ICondition2_UnionUnion FromICheckIsSupportedWalking(ICheckIsSupportedWalkingT _icheckissupportedwalking)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsSupportedWalking,
				Value = _icheckissupportedwalking
			};
		}

		// Token: 0x0601EBC5 RID: 125893 RVA: 0x0044AE8A File Offset: 0x0044908A
		public ICheckGiantStableValueT AsICheckGiantStableValue()
		{
			return this.As<ICheckGiantStableValueT>();
		}

		// Token: 0x0601EBC6 RID: 125894 RVA: 0x0044AE92 File Offset: 0x00449092
		public static ICondition2_UnionUnion FromICheckGiantStableValue(ICheckGiantStableValueT _icheckgiantstablevalue)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckGiantStableValue,
				Value = _icheckgiantstablevalue
			};
		}

		// Token: 0x0601EBC7 RID: 125895 RVA: 0x0044AEAB File Offset: 0x004490AB
		public ICheckGiantTotalProgressCanActivateNodeT AsICheckGiantTotalProgressCanActivateNode()
		{
			return this.As<ICheckGiantTotalProgressCanActivateNodeT>();
		}

		// Token: 0x0601EBC8 RID: 125896 RVA: 0x0044AEB3 File Offset: 0x004490B3
		public static ICondition2_UnionUnion FromICheckGiantTotalProgressCanActivateNode(ICheckGiantTotalProgressCanActivateNodeT _icheckgianttotalprogresscanactivatenode)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckGiantTotalProgressCanActivateNode,
				Value = _icheckgianttotalprogresscanactivatenode
			};
		}

		// Token: 0x0601EBC9 RID: 125897 RVA: 0x0044AECC File Offset: 0x004490CC
		public ICheckGiantTotalProgressInteractActivatedNodeT AsICheckGiantTotalProgressInteractActivatedNode()
		{
			return this.As<ICheckGiantTotalProgressInteractActivatedNodeT>();
		}

		// Token: 0x0601EBCA RID: 125898 RVA: 0x0044AED4 File Offset: 0x004490D4
		public static ICondition2_UnionUnion FromICheckGiantTotalProgressInteractActivatedNode(ICheckGiantTotalProgressInteractActivatedNodeT _icheckgianttotalprogressinteractactivatednode)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckGiantTotalProgressInteractActivatedNode,
				Value = _icheckgianttotalprogressinteractactivatednode
			};
		}

		// Token: 0x0601EBCB RID: 125899 RVA: 0x0044AEED File Offset: 0x004490ED
		public ICheckGiantRegionCultivationTriggeredUpgradeLevelT AsICheckGiantRegionCultivationTriggeredUpgradeLevel()
		{
			return this.As<ICheckGiantRegionCultivationTriggeredUpgradeLevelT>();
		}

		// Token: 0x0601EBCC RID: 125900 RVA: 0x0044AEF5 File Offset: 0x004490F5
		public static ICondition2_UnionUnion FromICheckGiantRegionCultivationTriggeredUpgradeLevel(ICheckGiantRegionCultivationTriggeredUpgradeLevelT _icheckgiantregioncultivationtriggeredupgradelevel)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckGiantRegionCultivationTriggeredUpgradeLevel,
				Value = _icheckgiantregioncultivationtriggeredupgradelevel
			};
		}

		// Token: 0x0601EBCD RID: 125901 RVA: 0x0044AF0E File Offset: 0x0044910E
		public ICheckElementalBoxStateT AsICheckElementalBoxState()
		{
			return this.As<ICheckElementalBoxStateT>();
		}

		// Token: 0x0601EBCE RID: 125902 RVA: 0x0044AF16 File Offset: 0x00449116
		public static ICondition2_UnionUnion FromICheckElementalBoxState(ICheckElementalBoxStateT _icheckelementalboxstate)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckElementalBoxState,
				Value = _icheckelementalboxstate
			};
		}

		// Token: 0x0601EBCF RID: 125903 RVA: 0x0044AF2F File Offset: 0x0044912F
		public ICheckIsTargetHoldElementalBoxT AsICheckIsTargetHoldElementalBox()
		{
			return this.As<ICheckIsTargetHoldElementalBoxT>();
		}

		// Token: 0x0601EBD0 RID: 125904 RVA: 0x0044AF37 File Offset: 0x00449137
		public static ICondition2_UnionUnion FromICheckIsTargetHoldElementalBox(ICheckIsTargetHoldElementalBoxT _icheckistargetholdelementalbox)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsTargetHoldElementalBox,
				Value = _icheckistargetholdelementalbox
			};
		}

		// Token: 0x0601EBD1 RID: 125905 RVA: 0x0044AF50 File Offset: 0x00449150
		public ICheckElementalEffectActiveT AsICheckElementalEffectActive()
		{
			return this.As<ICheckElementalEffectActiveT>();
		}

		// Token: 0x0601EBD2 RID: 125906 RVA: 0x0044AF58 File Offset: 0x00449158
		public static ICondition2_UnionUnion FromICheckElementalEffectActive(ICheckElementalEffectActiveT _icheckelementaleffectactive)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckElementalEffectActive,
				Value = _icheckelementaleffectactive
			};
		}

		// Token: 0x0601EBD3 RID: 125907 RVA: 0x0044AF71 File Offset: 0x00449171
		public ICheckElementalWaterBoxStagnationSeqT AsICheckElementalWaterBoxStagnationSeq()
		{
			return this.As<ICheckElementalWaterBoxStagnationSeqT>();
		}

		// Token: 0x0601EBD4 RID: 125908 RVA: 0x0044AF79 File Offset: 0x00449179
		public static ICondition2_UnionUnion FromICheckElementalWaterBoxStagnationSeq(ICheckElementalWaterBoxStagnationSeqT _icheckelementalwaterboxstagnationseq)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckElementalWaterBoxStagnationSeq,
				Value = _icheckelementalwaterboxstagnationseq
			};
		}

		// Token: 0x0601EBD5 RID: 125909 RVA: 0x0044AF94 File Offset: 0x00449194
		public static int Pack(FlatBufferBuilder builder, ICondition2_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICondition2_Union.ICondition2:
				return ICondition2.Pack(builder, _o.AsICondition2()).Value;
			case ICondition2_Union.ICompareVarCondition:
				return ICompareVarCondition.Pack(builder, _o.AsICompareVarCondition()).Value;
			case ICondition2_Union.IQuestStateEqualCondition:
				return IQuestStateEqualCondition.Pack(builder, _o.AsIQuestStateEqualCondition()).Value;
			case ICondition2_Union.ICompareExploreLevelCondition:
				return ICompareExploreLevelCondition.Pack(builder, _o.AsICompareExploreLevelCondition()).Value;
			case ICondition2_Union.ICompareCalabashLevelCondition:
				return ICompareCalabashLevelCondition.Pack(builder, _o.AsICompareCalabashLevelCondition()).Value;
			case ICondition2_Union.ICompareLiftCondition:
				return ICompareLiftCondition.Pack(builder, _o.AsICompareLiftCondition()).Value;
			case ICondition2_Union.ICompareEntityStateCondition:
				return ICompareEntityStateCondition.Pack(builder, _o.AsICompareEntityStateCondition()).Value;
			case ICondition2_Union.ICompareNpcPerformStateCondition:
				return ICompareNpcPerformStateCondition.Pack(builder, _o.AsICompareNpcPerformStateCondition()).Value;
			case ICondition2_Union.ICheckTreasureBeenClaimedCondition:
				return ICheckTreasureBeenClaimedCondition.Pack(builder, _o.AsICheckTreasureBeenClaimedCondition()).Value;
			case ICondition2_Union.ICompareEntityGroupStateCondition:
				return ICompareEntityGroupStateCondition.Pack(builder, _o.AsICompareEntityGroupStateCondition()).Value;
			case ICondition2_Union.ICompareEntitySelfStateCondition:
				return ICompareEntitySelfStateCondition.Pack(builder, _o.AsICompareEntitySelfStateCondition()).Value;
			case ICondition2_Union.ICompareLevelPlayRewardStateCondition:
				return ICompareLevelPlayRewardStateCondition.Pack(builder, _o.AsICompareLevelPlayRewardStateCondition()).Value;
			case ICondition2_Union.IHourToHourCondition:
				return IHourToHourCondition.Pack(builder, _o.AsIHourToHourCondition()).Value;
			case ICondition2_Union.IRangeSphere:
				return IRangeSphere.Pack(builder, _o.AsIRangeSphere()).Value;
			case ICondition2_Union.ICheckItems:
				return ICheckItems.Pack(builder, _o.AsICheckItems()).Value;
			case ICondition2_Union.IHasBuff:
				return IHasBuff.Pack(builder, _o.AsIHasBuff()).Value;
			case ICondition2_Union.ICheckSystemFunction:
				return ICheckSystemFunction.Pack(builder, _o.AsICheckSystemFunction()).Value;
			case ICondition2_Union.ICheckAiState:
				return ICheckAiState.Pack(builder, _o.AsICheckAiState()).Value;
			case ICondition2_Union.ICompareDungeonId:
				return ICompareDungeonId.Pack(builder, _o.AsICompareDungeonId()).Value;
			case ICondition2_Union.ICompareTimePeriod:
				return ICompareTimePeriod.Pack(builder, _o.AsICompareTimePeriod()).Value;
			case ICondition2_Union.ICompareWeather:
				return ICompareWeather.Pack(builder, _o.AsICompareWeather()).Value;
			case ICondition2_Union.ICheckLevelPlayState:
				return ICheckLevelPlayState.Pack(builder, _o.AsICheckLevelPlayState()).Value;
			case ICondition2_Union.ICheckLevelPlayCompleteNumber:
				return ICheckLevelPlayCompleteNumber.Pack(builder, _o.AsICheckLevelPlayCompleteNumber()).Value;
			case ICondition2_Union.ICheckLevelPlayChildQuestFinished:
				return ICheckLevelPlayChildQuestFinished.Pack(builder, _o.AsICheckLevelPlayChildQuestFinished()).Value;
			case ICondition2_Union.ICheckCurrentRole:
				return ICheckCurrentRole.Pack(builder, _o.AsICheckCurrentRole()).Value;
			case ICondition2_Union.ICheckPlayerGender:
				return ICheckPlayerGender.Pack(builder, _o.AsICheckPlayerGender()).Value;
			case ICondition2_Union.ICheckInCombat:
				return ICheckInCombat.Pack(builder, _o.AsICheckInCombat()).Value;
			case ICondition2_Union.ICheckHasFollowShooter:
				return ICheckHasFollowShooter.Pack(builder, _o.AsICheckHasFollowShooter()).Value;
			case ICondition2_Union.ICheckFollowShooterActive:
				return ICheckFollowShooterActive.Pack(builder, _o.AsICheckFollowShooterActive()).Value;
			case ICondition2_Union.ICheckChildQuestFinished:
				return ICheckChildQuestFinished.Pack(builder, _o.AsICheckChildQuestFinished()).Value;
			case ICondition2_Union.ICheckSyncLevelPlayCompleteNumber:
				return ICheckSyncLevelPlayCompleteNumber.Pack(builder, _o.AsICheckSyncLevelPlayCompleteNumber()).Value;
			case ICondition2_Union.ICheckCrossSceneSyncKillMonsterFinished:
				return ICheckCrossSceneSyncKillMonsterFinished.Pack(builder, _o.AsICheckCrossSceneSyncKillMonsterFinished()).Value;
			case ICondition2_Union.ICheckNodeStatus:
				return ICheckNodeStatus.Pack(builder, _o.AsICheckNodeStatus()).Value;
			case ICondition2_Union.ICheckChildQuestStatus:
				return ICheckChildQuestStatus.Pack(builder, _o.AsICheckChildQuestStatus()).Value;
			case ICondition2_Union.ICheckEntitiesExist:
				return ICheckEntitiesExist.Pack(builder, _o.AsICheckEntitiesExist()).Value;
			case ICondition2_Union.ICheckPlayerPosition:
				return ICheckPlayerPosition.Pack(builder, _o.AsICheckPlayerPosition()).Value;
			case ICondition2_Union.ICheckEntityPosition:
				return ICheckEntityPosition.Pack(builder, _o.AsICheckEntityPosition()).Value;
			case ICondition2_Union.ICheckDungeonFinish:
				return ICheckDungeonFinish.Pack(builder, _o.AsICheckDungeonFinish()).Value;
			case ICondition2_Union.ICheckEntityIsVisibility:
				return ICheckEntityIsVisibility.Pack(builder, _o.AsICheckEntityIsVisibility()).Value;
			case ICondition2_Union.IComparePlayerMotionState:
				return IComparePlayerMotionState.Pack(builder, _o.AsIComparePlayerMotionState()).Value;
			case ICondition2_Union.IComparePlayerMotionState2:
				return IComparePlayerMotionState2.Pack(builder, _o.AsIComparePlayerMotionState2()).Value;
			case ICondition2_Union.ICheckDataLayerCondition:
				return ICheckDataLayerCondition.Pack(builder, _o.AsICheckDataLayerCondition()).Value;
			case ICondition2_Union.ICheckHookLockPointCondition:
				return ICheckHookLockPointCondition.Pack(builder, _o.AsICheckHookLockPointCondition()).Value;
			case ICondition2_Union.ICheckPlayerSkillReadyCondition:
				return ICheckPlayerSkillReadyCondition.Pack(builder, _o.AsICheckPlayerSkillReadyCondition()).Value;
			case ICondition2_Union.ICheckPlayerUseSkillCondition:
				return ICheckPlayerUseSkillCondition.Pack(builder, _o.AsICheckPlayerUseSkillCondition()).Value;
			case ICondition2_Union.ICheckPlayerStateRestrictionCondition:
				return ICheckPlayerStateRestrictionCondition.Pack(builder, _o.AsICheckPlayerStateRestrictionCondition()).Value;
			case ICondition2_Union.ICheckLordGymFinishCondition:
				return ICheckLordGymFinishCondition.Pack(builder, _o.AsICheckLordGymFinishCondition()).Value;
			case ICondition2_Union.ICheckCalabashDevelopRewardCondition:
				return ICheckCalabashDevelopRewardCondition.Pack(builder, _o.AsICheckCalabashDevelopRewardCondition()).Value;
			case ICondition2_Union.ICompareFishingPrestigeLevelCondition:
				return ICompareFishingPrestigeLevelCondition.Pack(builder, _o.AsICompareFishingPrestigeLevelCondition()).Value;
			case ICondition2_Union.ICheckCertainFishingItemCount:
				return ICheckCertainFishingItemCount.Pack(builder, _o.AsICheckCertainFishingItemCount()).Value;
			case ICondition2_Union.ICompleteCertainFishingEntrust:
				return ICompleteCertainFishingEntrust.Pack(builder, _o.AsICompleteCertainFishingEntrust()).Value;
			case ICondition2_Union.ICompareFishingBoatState:
				return ICompareFishingBoatState.Pack(builder, _o.AsICompareFishingBoatState()).Value;
			case ICondition2_Union.ICheckJigsawInfoCondition:
				return ICheckJigsawInfoCondition.Pack(builder, _o.AsICheckJigsawInfoCondition()).Value;
			case ICondition2_Union.ICheckGameplayTagCondition:
				return ICheckGameplayTagCondition.Pack(builder, _o.AsICheckGameplayTagCondition()).Value;
			case ICondition2_Union.ICheckFormationRoleInfoCondition:
				return ICheckFormationRoleInfoCondition.Pack(builder, _o.AsICheckFormationRoleInfoCondition()).Value;
			case ICondition2_Union.ICheckTargetAttributeCondition:
				return ICheckTargetAttributeCondition.Pack(builder, _o.AsICheckTargetAttributeCondition()).Value;
			case ICondition2_Union.ICheckRogueAbilitySelectCondition:
				return ICheckRogueAbilitySelectCondition.Pack(builder, _o.AsICheckRogueAbilitySelectCondition()).Value;
			case ICondition2_Union.ICheckDirectionCondition:
				return ICheckDirectionCondition.Pack(builder, _o.AsICheckDirectionCondition()).Value;
			case ICondition2_Union.ICheckSceneItemDirectionCondition:
				return ICheckSceneItemDirectionCondition.Pack(builder, _o.AsICheckSceneItemDirectionCondition()).Value;
			case ICondition2_Union.ICheckPlayerFaceToCondition:
				return ICheckPlayerFaceToCondition.Pack(builder, _o.AsICheckPlayerFaceToCondition()).Value;
			case ICondition2_Union.ICheckPlayerCanJoinActivityCondition:
				return ICheckPlayerCanJoinActivityCondition.Pack(builder, _o.AsICheckPlayerCanJoinActivityCondition()).Value;
			case ICondition2_Union.ICheckSystemStateCondition:
				return ICheckSystemStateCondition.Pack(builder, _o.AsICheckSystemStateCondition()).Value;
			case ICondition2_Union.ICheckInRangeCondition:
				return ICheckInRangeCondition.Pack(builder, _o.AsICheckInRangeCondition()).Value;
			case ICondition2_Union.ICheckInRangeProperlyCondition:
				return ICheckInRangeProperlyCondition.Pack(builder, _o.AsICheckInRangeProperlyCondition()).Value;
			case ICondition2_Union.ICheckEntityLockedCondition:
				return ICheckEntityLockedCondition.Pack(builder, _o.AsICheckEntityLockedCondition()).Value;
			case ICondition2_Union.ICompareTeammateDieCondition:
				return ICompareTeammateDieCondition.Pack(builder, _o.AsICompareTeammateDieCondition()).Value;
			case ICondition2_Union.IListenEntitySelfEventCondition:
				return IListenEntitySelfEventCondition.Pack(builder, _o.AsIListenEntitySelfEventCondition()).Value;
			case ICondition2_Union.ICheckEntityDistanceCondition:
				return ICheckEntityDistanceCondition.Pack(builder, _o.AsICheckEntityDistanceCondition()).Value;
			case ICondition2_Union.ICheckEntityHasSceneItemAttributeTag:
				return ICheckEntityHasSceneItemAttributeTag.Pack(builder, _o.AsICheckEntityHasSceneItemAttributeTag()).Value;
			case ICondition2_Union.IListenEntityThroughPortal:
				return IListenEntityThroughPortal.Pack(builder, _o.AsIListenEntityThroughPortal()).Value;
			case ICondition2_Union.ICheckTeleControlState:
				return ICheckTeleControlState.Pack(builder, _o.AsICheckTeleControlState()).Value;
			case ICondition2_Union.ICustomJsonCondition:
				return ICustomJsonCondition.Pack(builder, _o.AsICustomJsonCondition()).Value;
			case ICondition2_Union.ICheckChessWinner:
				return ICheckChessWinner.Pack(builder, _o.AsICheckChessWinner()).Value;
			case ICondition2_Union.ICheckVehicleCondition:
				return ICheckVehicleCondition.Pack(builder, _o.AsICheckVehicleCondition()).Value;
			case ICondition2_Union.ICompareAlertValue:
				return ICompareAlertValue.Pack(builder, _o.AsICompareAlertValue()).Value;
			case ICondition2_Union.ICheckEntityGravityDirection:
				return ICheckEntityGravityDirection.Pack(builder, _o.AsICheckEntityGravityDirection()).Value;
			case ICondition2_Union.ICheckCollectAnimalParts:
				return ICheckCollectAnimalParts.Pack(builder, _o.AsICheckCollectAnimalParts()).Value;
			case ICondition2_Union.ICheckFinishLoading:
				return ICheckFinishLoading.Pack(builder, _o.AsICheckFinishLoading()).Value;
			case ICondition2_Union.ICheckFishingPointHasFish:
				return ICheckFishingPointHasFish.Pack(builder, _o.AsICheckFishingPointHasFish()).Value;
			case ICondition2_Union.ICheckFishingCageFillingRatio:
				return ICheckFishingCageFillingRatio.Pack(builder, _o.AsICheckFishingCageFillingRatio()).Value;
			case ICondition2_Union.ICompareFishingTechLevel:
				return ICompareFishingTechLevel.Pack(builder, _o.AsICompareFishingTechLevel()).Value;
			case ICondition2_Union.ICheckGuestCharacter:
				return ICheckGuestCharacter.Pack(builder, _o.AsICheckGuestCharacter()).Value;
			case ICondition2_Union.ICheckSubLevelState:
				return ICheckSubLevelState.Pack(builder, _o.AsICheckSubLevelState()).Value;
			case ICondition2_Union.IComparePlayerNumInDungeon:
				return IComparePlayerNumInDungeon.Pack(builder, _o.AsIComparePlayerNumInDungeon()).Value;
			case ICondition2_Union.ICheckAlertAreaEnabled:
				return ICheckAlertAreaEnabled.Pack(builder, _o.AsICheckAlertAreaEnabled()).Value;
			case ICondition2_Union.ICheckClientEvent:
				return ICheckClientEvent.Pack(builder, _o.AsICheckClientEvent()).Value;
			case ICondition2_Union.ICheckIsGramophonePlayingMusic:
				return ICheckIsGramophonePlayingMusic.Pack(builder, _o.AsICheckIsGramophonePlayingMusic()).Value;
			case ICondition2_Union.ICheckEntityReward:
				return ICheckEntityReward.Pack(builder, _o.AsICheckEntityReward()).Value;
			case ICondition2_Union.ICheckDungeonHasSaveConfig:
				return ICheckDungeonHasSaveConfig.Pack(builder, _o.AsICheckDungeonHasSaveConfig()).Value;
			case ICondition2_Union.ICheckSystemEventBvb:
				return ICheckSystemEventBvb.Pack(builder, _o.AsICheckSystemEventBvb()).Value;
			case ICondition2_Union.ICheckDangoCultivationProgress:
				return ICheckDangoCultivationProgress.Pack(builder, _o.AsICheckDangoCultivationProgress()).Value;
			case ICondition2_Union.ICheckPlayerMoraleLevelRange:
				return ICheckPlayerMoraleLevelRange.Pack(builder, _o.AsICheckPlayerMoraleLevelRange()).Value;
			case ICondition2_Union.ICheckIsGlobalTimeScaleEnabled:
				return ICheckIsGlobalTimeScaleEnabled.Pack(builder, _o.AsICheckIsGlobalTimeScaleEnabled()).Value;
			case ICondition2_Union.ISaveConfigEnterMethod:
				return ISaveConfigEnterMethod.Pack(builder, _o.AsISaveConfigEnterMethod()).Value;
			case ICondition2_Union.ICheckIsEntityTimeScaleEnabled:
				return ICheckIsEntityTimeScaleEnabled.Pack(builder, _o.AsICheckIsEntityTimeScaleEnabled()).Value;
			case ICondition2_Union.ICheckIsCharacterHoldingHands:
				return ICheckIsCharacterHoldingHands.Pack(builder, _o.AsICheckIsCharacterHoldingHands()).Value;
			case ICondition2_Union.ICheckIsTrackingCurrentQuest:
				return ICheckIsTrackingCurrentQuest.Pack(builder, _o.AsICheckIsTrackingCurrentQuest()).Value;
			case ICondition2_Union.ICheckIsTrackingQuest:
				return ICheckIsTrackingQuest.Pack(builder, _o.AsICheckIsTrackingQuest()).Value;
			case ICondition2_Union.ICheckMusicEvent:
				return ICheckMusicEvent.Pack(builder, _o.AsICheckMusicEvent()).Value;
			case ICondition2_Union.ICompareGameDifficulty:
				return ICompareGameDifficulty.Pack(builder, _o.AsICompareGameDifficulty()).Value;
			case ICondition2_Union.ICheckPhotographCameraParam:
				return ICheckPhotographCameraParam.Pack(builder, _o.AsICheckPhotographCameraParam()).Value;
			case ICondition2_Union.ICheckEntityHasBuff:
				return ICheckEntityHasBuff.Pack(builder, _o.AsICheckEntityHasBuff()).Value;
			case ICondition2_Union.ICheckEntityBuffStack:
				return ICheckEntityBuffStack.Pack(builder, _o.AsICheckEntityBuffStack()).Value;
			case ICondition2_Union.ICheckAvailableSunSpiritCount:
				return ICheckAvailableSunSpiritCount.Pack(builder, _o.AsICheckAvailableSunSpiritCount()).Value;
			case ICondition2_Union.ICheckPlayerEnterClientTriggerDir:
				return ICheckPlayerEnterClientTriggerDir.Pack(builder, _o.AsICheckPlayerEnterClientTriggerDir()).Value;
			case ICondition2_Union.ICheckPlayerRelativeDistance:
				return ICheckPlayerRelativeDistance.Pack(builder, _o.AsICheckPlayerRelativeDistance()).Value;
			case ICondition2_Union.ICheckPlayerRelativeAngle:
				return ICheckPlayerRelativeAngle.Pack(builder, _o.AsICheckPlayerRelativeAngle()).Value;
			case ICondition2_Union.ICheckHonamiStoryGetItem:
				return ICheckHonamiStoryGetItem.Pack(builder, _o.AsICheckHonamiStoryGetItem()).Value;
			case ICondition2_Union.ICheckHonamiStoryEquipItem:
				return ICheckHonamiStoryEquipItem.Pack(builder, _o.AsICheckHonamiStoryEquipItem()).Value;
			case ICondition2_Union.ICheckHonamiStoryActivateTalent:
				return ICheckHonamiStoryActivateTalent.Pack(builder, _o.AsICheckHonamiStoryActivateTalent()).Value;
			case ICondition2_Union.ICheckHonamiStoryUnlockSlot:
				return ICheckHonamiStoryUnlockSlot.Pack(builder, _o.AsICheckHonamiStoryUnlockSlot()).Value;
			case ICondition2_Union.ICheckHonamiStoryLifeSupportLevel:
				return ICheckHonamiStoryLifeSupportLevel.Pack(builder, _o.AsICheckHonamiStoryLifeSupportLevel()).Value;
			case ICondition2_Union.ICheckHonamiStoryTowerComplete:
				return ICheckHonamiStoryTowerComplete.Pack(builder, _o.AsICheckHonamiStoryTowerComplete()).Value;
			case ICondition2_Union.ICheckHonamiStoryPlayerCorruptedLevel:
				return ICheckHonamiStoryPlayerCorruptedLevel.Pack(builder, _o.AsICheckHonamiStoryPlayerCorruptedLevel()).Value;
			case ICondition2_Union.ICheckHonamiStoryUnlockMascot:
				return ICheckHonamiStoryUnlockMascot.Pack(builder, _o.AsICheckHonamiStoryUnlockMascot()).Value;
			case ICondition2_Union.ICheckHonamiStoryChestOpenTime:
				return ICheckHonamiStoryChestOpenTime.Pack(builder, _o.AsICheckHonamiStoryChestOpenTime()).Value;
			case ICondition2_Union.ICheckHonamiStorySuccessfulEvacuation:
				return ICheckHonamiStorySuccessfulEvacuation.Pack(builder, _o.AsICheckHonamiStorySuccessfulEvacuation()).Value;
			case ICondition2_Union.ICheckBvbChallengeState:
				return ICheckBvbChallengeState.Pack(builder, _o.AsICheckBvbChallengeState()).Value;
			case ICondition2_Union.ICheckBvbActivityRank:
				return ICheckBvbActivityRank.Pack(builder, _o.AsICheckBvbActivityRank()).Value;
			case ICondition2_Union.ICheckCollectedSunSpiritCount:
				return ICheckCollectedSunSpiritCount.Pack(builder, _o.AsICheckCollectedSunSpiritCount()).Value;
			case ICondition2_Union.ICheckTargetSunSpiritCollected:
				return ICheckTargetSunSpiritCollected.Pack(builder, _o.AsICheckTargetSunSpiritCollected()).Value;
			case ICondition2_Union.ICheckPlayerIsInDeadEyeProcess:
				return ICheckPlayerIsInDeadEyeProcess.Pack(builder, _o.AsICheckPlayerIsInDeadEyeProcess()).Value;
			case ICondition2_Union.ICheckEntitySelfDirection:
				return ICheckEntitySelfDirection.Pack(builder, _o.AsICheckEntitySelfDirection()).Value;
			case ICondition2_Union.ICheckDollGrabItemComboAchievedInOnceDelivery:
				return ICheckDollGrabItemComboAchievedInOnceDelivery.Pack(builder, _o.AsICheckDollGrabItemComboAchievedInOnceDelivery()).Value;
			case ICondition2_Union.ICheckDollGrabShowcaseItemComboAchieved:
				return ICheckDollGrabShowcaseItemComboAchieved.Pack(builder, _o.AsICheckDollGrabShowcaseItemComboAchieved()).Value;
			case ICondition2_Union.ICheckRoverRogueAbilitySelectCondition:
				return ICheckRoverRogueAbilitySelectCondition.Pack(builder, _o.AsICheckRoverRogueAbilitySelectCondition()).Value;
			case ICondition2_Union.ICheckDollGrabMachineFinished:
				return ICheckDollGrabMachineFinished.Pack(builder, _o.AsICheckDollGrabMachineFinished()).Value;
			case ICondition2_Union.ICheckTrafficBlocked:
				return ICheckTrafficBlocked.Pack(builder, _o.AsICheckTrafficBlocked()).Value;
			case ICondition2_Union.ICheckDrinksPreferenceLevel:
				return ICheckDrinksPreferenceLevel.Pack(builder, _o.AsICheckDrinksPreferenceLevel()).Value;
			case ICondition2_Union.ICheckPlayerIsInMotorcycleCruise:
				return ICheckPlayerIsInMotorcycleCruise.Pack(builder, _o.AsICheckPlayerIsInMotorcycleCruise()).Value;
			case ICondition2_Union.ICheckTetrisEndlessScore:
				return ICheckTetrisEndlessScore.Pack(builder, _o.AsICheckTetrisEndlessScore()).Value;
			case ICondition2_Union.ICheckAtlasUnlocked:
				return ICheckAtlasUnlocked.Pack(builder, _o.AsICheckAtlasUnlocked()).Value;
			case ICondition2_Union.ICheckSheriffUnlockEnding:
				return ICheckSheriffUnlockEnding.Pack(builder, _o.AsICheckSheriffUnlockEnding()).Value;
			case ICondition2_Union.ICheckIsInDragActorPlay:
				return ICheckIsInDragActorPlay.Pack(builder, _o.AsICheckIsInDragActorPlay()).Value;
			case ICondition2_Union.ICheckIsInDollGrabGamePlay:
				return ICheckIsInDollGrabGamePlay.Pack(builder, _o.AsICheckIsInDollGrabGamePlay()).Value;
			case ICondition2_Union.ICheckEntityPrefabPerformanceType:
				return ICheckEntityPrefabPerformanceType.Pack(builder, _o.AsICheckEntityPrefabPerformanceType()).Value;
			case ICondition2_Union.ICheckIsSupportedWalking:
				return ICheckIsSupportedWalking.Pack(builder, _o.AsICheckIsSupportedWalking()).Value;
			case ICondition2_Union.ICheckGiantStableValue:
				return ICheckGiantStableValue.Pack(builder, _o.AsICheckGiantStableValue()).Value;
			case ICondition2_Union.ICheckGiantTotalProgressCanActivateNode:
				return ICheckGiantTotalProgressCanActivateNode.Pack(builder, _o.AsICheckGiantTotalProgressCanActivateNode()).Value;
			case ICondition2_Union.ICheckGiantTotalProgressInteractActivatedNode:
				return ICheckGiantTotalProgressInteractActivatedNode.Pack(builder, _o.AsICheckGiantTotalProgressInteractActivatedNode()).Value;
			case ICondition2_Union.ICheckGiantRegionCultivationTriggeredUpgradeLevel:
				return ICheckGiantRegionCultivationTriggeredUpgradeLevel.Pack(builder, _o.AsICheckGiantRegionCultivationTriggeredUpgradeLevel()).Value;
			case ICondition2_Union.ICheckElementalBoxState:
				return ICheckElementalBoxState.Pack(builder, _o.AsICheckElementalBoxState()).Value;
			case ICondition2_Union.ICheckIsTargetHoldElementalBox:
				return ICheckIsTargetHoldElementalBox.Pack(builder, _o.AsICheckIsTargetHoldElementalBox()).Value;
			case ICondition2_Union.ICheckElementalEffectActive:
				return ICheckElementalEffectActive.Pack(builder, _o.AsICheckElementalEffectActive()).Value;
			case ICondition2_Union.ICheckElementalWaterBoxStagnationSeq:
				return ICheckElementalWaterBoxStagnationSeq.Pack(builder, _o.AsICheckElementalWaterBoxStagnationSeq()).Value;
			default:
				return 0;
			}
		}
	}
}

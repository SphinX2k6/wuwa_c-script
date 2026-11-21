using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050CB RID: 20683
	public class ICondition2_UnionUnion
	{
		// Token: 0x1700943C RID: 37948
		// (get) Token: 0x0602067B RID: 132731 RVA: 0x0047CD28 File Offset: 0x0047AF28
		// (set) Token: 0x0602067C RID: 132732 RVA: 0x0047CD30 File Offset: 0x0047AF30
		public ICondition2_Union Type { get; set; }

		// Token: 0x1700943D RID: 37949
		// (get) Token: 0x0602067D RID: 132733 RVA: 0x0047CD39 File Offset: 0x0047AF39
		// (set) Token: 0x0602067E RID: 132734 RVA: 0x0047CD41 File Offset: 0x0047AF41
		public object Value { get; set; }

		// Token: 0x0602067F RID: 132735 RVA: 0x0047CD4A File Offset: 0x0047AF4A
		public ICondition2_UnionUnion()
		{
			this.Type = ICondition2_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020680 RID: 132736 RVA: 0x0047CD60 File Offset: 0x0047AF60
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020681 RID: 132737 RVA: 0x0047CD72 File Offset: 0x0047AF72
		public ICondition2T AsICondition2()
		{
			return this.As<ICondition2T>();
		}

		// Token: 0x06020682 RID: 132738 RVA: 0x0047CD7A File Offset: 0x0047AF7A
		public static ICondition2_UnionUnion FromICondition2(ICondition2T _icondition2)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICondition2,
				Value = _icondition2
			};
		}

		// Token: 0x06020683 RID: 132739 RVA: 0x0047CD8F File Offset: 0x0047AF8F
		public ICompareVarConditionT AsICompareVarCondition()
		{
			return this.As<ICompareVarConditionT>();
		}

		// Token: 0x06020684 RID: 132740 RVA: 0x0047CD97 File Offset: 0x0047AF97
		public static ICondition2_UnionUnion FromICompareVarCondition(ICompareVarConditionT _icomparevarcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareVarCondition,
				Value = _icomparevarcondition
			};
		}

		// Token: 0x06020685 RID: 132741 RVA: 0x0047CDAC File Offset: 0x0047AFAC
		public IQuestStateEqualConditionT AsIQuestStateEqualCondition()
		{
			return this.As<IQuestStateEqualConditionT>();
		}

		// Token: 0x06020686 RID: 132742 RVA: 0x0047CDB4 File Offset: 0x0047AFB4
		public static ICondition2_UnionUnion FromIQuestStateEqualCondition(IQuestStateEqualConditionT _iqueststateequalcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.IQuestStateEqualCondition,
				Value = _iqueststateequalcondition
			};
		}

		// Token: 0x06020687 RID: 132743 RVA: 0x0047CDC9 File Offset: 0x0047AFC9
		public ICompareExploreLevelConditionT AsICompareExploreLevelCondition()
		{
			return this.As<ICompareExploreLevelConditionT>();
		}

		// Token: 0x06020688 RID: 132744 RVA: 0x0047CDD1 File Offset: 0x0047AFD1
		public static ICondition2_UnionUnion FromICompareExploreLevelCondition(ICompareExploreLevelConditionT _icompareexplorelevelcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareExploreLevelCondition,
				Value = _icompareexplorelevelcondition
			};
		}

		// Token: 0x06020689 RID: 132745 RVA: 0x0047CDE6 File Offset: 0x0047AFE6
		public ICompareCalabashLevelConditionT AsICompareCalabashLevelCondition()
		{
			return this.As<ICompareCalabashLevelConditionT>();
		}

		// Token: 0x0602068A RID: 132746 RVA: 0x0047CDEE File Offset: 0x0047AFEE
		public static ICondition2_UnionUnion FromICompareCalabashLevelCondition(ICompareCalabashLevelConditionT _icomparecalabashlevelcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareCalabashLevelCondition,
				Value = _icomparecalabashlevelcondition
			};
		}

		// Token: 0x0602068B RID: 132747 RVA: 0x0047CE03 File Offset: 0x0047B003
		public ICompareLiftConditionT AsICompareLiftCondition()
		{
			return this.As<ICompareLiftConditionT>();
		}

		// Token: 0x0602068C RID: 132748 RVA: 0x0047CE0B File Offset: 0x0047B00B
		public static ICondition2_UnionUnion FromICompareLiftCondition(ICompareLiftConditionT _icompareliftcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareLiftCondition,
				Value = _icompareliftcondition
			};
		}

		// Token: 0x0602068D RID: 132749 RVA: 0x0047CE20 File Offset: 0x0047B020
		public ICompareEntityStateConditionT AsICompareEntityStateCondition()
		{
			return this.As<ICompareEntityStateConditionT>();
		}

		// Token: 0x0602068E RID: 132750 RVA: 0x0047CE28 File Offset: 0x0047B028
		public static ICondition2_UnionUnion FromICompareEntityStateCondition(ICompareEntityStateConditionT _icompareentitystatecondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareEntityStateCondition,
				Value = _icompareentitystatecondition
			};
		}

		// Token: 0x0602068F RID: 132751 RVA: 0x0047CE3D File Offset: 0x0047B03D
		public ICompareNpcPerformStateConditionT AsICompareNpcPerformStateCondition()
		{
			return this.As<ICompareNpcPerformStateConditionT>();
		}

		// Token: 0x06020690 RID: 132752 RVA: 0x0047CE45 File Offset: 0x0047B045
		public static ICondition2_UnionUnion FromICompareNpcPerformStateCondition(ICompareNpcPerformStateConditionT _icomparenpcperformstatecondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareNpcPerformStateCondition,
				Value = _icomparenpcperformstatecondition
			};
		}

		// Token: 0x06020691 RID: 132753 RVA: 0x0047CE5A File Offset: 0x0047B05A
		public ICheckTreasureBeenClaimedConditionT AsICheckTreasureBeenClaimedCondition()
		{
			return this.As<ICheckTreasureBeenClaimedConditionT>();
		}

		// Token: 0x06020692 RID: 132754 RVA: 0x0047CE62 File Offset: 0x0047B062
		public static ICondition2_UnionUnion FromICheckTreasureBeenClaimedCondition(ICheckTreasureBeenClaimedConditionT _ichecktreasurebeenclaimedcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckTreasureBeenClaimedCondition,
				Value = _ichecktreasurebeenclaimedcondition
			};
		}

		// Token: 0x06020693 RID: 132755 RVA: 0x0047CE78 File Offset: 0x0047B078
		public ICompareEntityGroupStateConditionT AsICompareEntityGroupStateCondition()
		{
			return this.As<ICompareEntityGroupStateConditionT>();
		}

		// Token: 0x06020694 RID: 132756 RVA: 0x0047CE80 File Offset: 0x0047B080
		public static ICondition2_UnionUnion FromICompareEntityGroupStateCondition(ICompareEntityGroupStateConditionT _icompareentitygroupstatecondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareEntityGroupStateCondition,
				Value = _icompareentitygroupstatecondition
			};
		}

		// Token: 0x06020695 RID: 132757 RVA: 0x0047CE96 File Offset: 0x0047B096
		public ICompareEntitySelfStateConditionT AsICompareEntitySelfStateCondition()
		{
			return this.As<ICompareEntitySelfStateConditionT>();
		}

		// Token: 0x06020696 RID: 132758 RVA: 0x0047CE9E File Offset: 0x0047B09E
		public static ICondition2_UnionUnion FromICompareEntitySelfStateCondition(ICompareEntitySelfStateConditionT _icompareentityselfstatecondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareEntitySelfStateCondition,
				Value = _icompareentityselfstatecondition
			};
		}

		// Token: 0x06020697 RID: 132759 RVA: 0x0047CEB4 File Offset: 0x0047B0B4
		public ICompareLevelPlayRewardStateConditionT AsICompareLevelPlayRewardStateCondition()
		{
			return this.As<ICompareLevelPlayRewardStateConditionT>();
		}

		// Token: 0x06020698 RID: 132760 RVA: 0x0047CEBC File Offset: 0x0047B0BC
		public static ICondition2_UnionUnion FromICompareLevelPlayRewardStateCondition(ICompareLevelPlayRewardStateConditionT _icomparelevelplayrewardstatecondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareLevelPlayRewardStateCondition,
				Value = _icomparelevelplayrewardstatecondition
			};
		}

		// Token: 0x06020699 RID: 132761 RVA: 0x0047CED2 File Offset: 0x0047B0D2
		public IHourToHourConditionT AsIHourToHourCondition()
		{
			return this.As<IHourToHourConditionT>();
		}

		// Token: 0x0602069A RID: 132762 RVA: 0x0047CEDA File Offset: 0x0047B0DA
		public static ICondition2_UnionUnion FromIHourToHourCondition(IHourToHourConditionT _ihourtohourcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.IHourToHourCondition,
				Value = _ihourtohourcondition
			};
		}

		// Token: 0x0602069B RID: 132763 RVA: 0x0047CEF0 File Offset: 0x0047B0F0
		public IRangeSphereT AsIRangeSphere()
		{
			return this.As<IRangeSphereT>();
		}

		// Token: 0x0602069C RID: 132764 RVA: 0x0047CEF8 File Offset: 0x0047B0F8
		public static ICondition2_UnionUnion FromIRangeSphere(IRangeSphereT _irangesphere)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.IRangeSphere,
				Value = _irangesphere
			};
		}

		// Token: 0x0602069D RID: 132765 RVA: 0x0047CF0E File Offset: 0x0047B10E
		public ICheckItemsT AsICheckItems()
		{
			return this.As<ICheckItemsT>();
		}

		// Token: 0x0602069E RID: 132766 RVA: 0x0047CF16 File Offset: 0x0047B116
		public static ICondition2_UnionUnion FromICheckItems(ICheckItemsT _icheckitems)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckItems,
				Value = _icheckitems
			};
		}

		// Token: 0x0602069F RID: 132767 RVA: 0x0047CF2C File Offset: 0x0047B12C
		public IHasBuffT AsIHasBuff()
		{
			return this.As<IHasBuffT>();
		}

		// Token: 0x060206A0 RID: 132768 RVA: 0x0047CF34 File Offset: 0x0047B134
		public static ICondition2_UnionUnion FromIHasBuff(IHasBuffT _ihasbuff)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.IHasBuff,
				Value = _ihasbuff
			};
		}

		// Token: 0x060206A1 RID: 132769 RVA: 0x0047CF4A File Offset: 0x0047B14A
		public ICheckSystemFunctionT AsICheckSystemFunction()
		{
			return this.As<ICheckSystemFunctionT>();
		}

		// Token: 0x060206A2 RID: 132770 RVA: 0x0047CF52 File Offset: 0x0047B152
		public static ICondition2_UnionUnion FromICheckSystemFunction(ICheckSystemFunctionT _ichecksystemfunction)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckSystemFunction,
				Value = _ichecksystemfunction
			};
		}

		// Token: 0x060206A3 RID: 132771 RVA: 0x0047CF68 File Offset: 0x0047B168
		public ICheckAiStateT AsICheckAiState()
		{
			return this.As<ICheckAiStateT>();
		}

		// Token: 0x060206A4 RID: 132772 RVA: 0x0047CF70 File Offset: 0x0047B170
		public static ICondition2_UnionUnion FromICheckAiState(ICheckAiStateT _icheckaistate)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckAiState,
				Value = _icheckaistate
			};
		}

		// Token: 0x060206A5 RID: 132773 RVA: 0x0047CF86 File Offset: 0x0047B186
		public ICompareDungeonIdT AsICompareDungeonId()
		{
			return this.As<ICompareDungeonIdT>();
		}

		// Token: 0x060206A6 RID: 132774 RVA: 0x0047CF8E File Offset: 0x0047B18E
		public static ICondition2_UnionUnion FromICompareDungeonId(ICompareDungeonIdT _icomparedungeonid)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareDungeonId,
				Value = _icomparedungeonid
			};
		}

		// Token: 0x060206A7 RID: 132775 RVA: 0x0047CFA4 File Offset: 0x0047B1A4
		public ICompareTimePeriodT AsICompareTimePeriod()
		{
			return this.As<ICompareTimePeriodT>();
		}

		// Token: 0x060206A8 RID: 132776 RVA: 0x0047CFAC File Offset: 0x0047B1AC
		public static ICondition2_UnionUnion FromICompareTimePeriod(ICompareTimePeriodT _icomparetimeperiod)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareTimePeriod,
				Value = _icomparetimeperiod
			};
		}

		// Token: 0x060206A9 RID: 132777 RVA: 0x0047CFC2 File Offset: 0x0047B1C2
		public ICompareWeatherT AsICompareWeather()
		{
			return this.As<ICompareWeatherT>();
		}

		// Token: 0x060206AA RID: 132778 RVA: 0x0047CFCA File Offset: 0x0047B1CA
		public static ICondition2_UnionUnion FromICompareWeather(ICompareWeatherT _icompareweather)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareWeather,
				Value = _icompareweather
			};
		}

		// Token: 0x060206AB RID: 132779 RVA: 0x0047CFE0 File Offset: 0x0047B1E0
		public ICheckLevelPlayStateT AsICheckLevelPlayState()
		{
			return this.As<ICheckLevelPlayStateT>();
		}

		// Token: 0x060206AC RID: 132780 RVA: 0x0047CFE8 File Offset: 0x0047B1E8
		public static ICondition2_UnionUnion FromICheckLevelPlayState(ICheckLevelPlayStateT _ichecklevelplaystate)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckLevelPlayState,
				Value = _ichecklevelplaystate
			};
		}

		// Token: 0x060206AD RID: 132781 RVA: 0x0047CFFE File Offset: 0x0047B1FE
		public ICheckLevelPlayCompleteNumberT AsICheckLevelPlayCompleteNumber()
		{
			return this.As<ICheckLevelPlayCompleteNumberT>();
		}

		// Token: 0x060206AE RID: 132782 RVA: 0x0047D006 File Offset: 0x0047B206
		public static ICondition2_UnionUnion FromICheckLevelPlayCompleteNumber(ICheckLevelPlayCompleteNumberT _ichecklevelplaycompletenumber)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckLevelPlayCompleteNumber,
				Value = _ichecklevelplaycompletenumber
			};
		}

		// Token: 0x060206AF RID: 132783 RVA: 0x0047D01C File Offset: 0x0047B21C
		public ICheckLevelPlayChildQuestFinishedT AsICheckLevelPlayChildQuestFinished()
		{
			return this.As<ICheckLevelPlayChildQuestFinishedT>();
		}

		// Token: 0x060206B0 RID: 132784 RVA: 0x0047D024 File Offset: 0x0047B224
		public static ICondition2_UnionUnion FromICheckLevelPlayChildQuestFinished(ICheckLevelPlayChildQuestFinishedT _ichecklevelplaychildquestfinished)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckLevelPlayChildQuestFinished,
				Value = _ichecklevelplaychildquestfinished
			};
		}

		// Token: 0x060206B1 RID: 132785 RVA: 0x0047D03A File Offset: 0x0047B23A
		public ICheckCurrentRoleT AsICheckCurrentRole()
		{
			return this.As<ICheckCurrentRoleT>();
		}

		// Token: 0x060206B2 RID: 132786 RVA: 0x0047D042 File Offset: 0x0047B242
		public static ICondition2_UnionUnion FromICheckCurrentRole(ICheckCurrentRoleT _icheckcurrentrole)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckCurrentRole,
				Value = _icheckcurrentrole
			};
		}

		// Token: 0x060206B3 RID: 132787 RVA: 0x0047D058 File Offset: 0x0047B258
		public ICheckPlayerGenderT AsICheckPlayerGender()
		{
			return this.As<ICheckPlayerGenderT>();
		}

		// Token: 0x060206B4 RID: 132788 RVA: 0x0047D060 File Offset: 0x0047B260
		public static ICondition2_UnionUnion FromICheckPlayerGender(ICheckPlayerGenderT _icheckplayergender)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerGender,
				Value = _icheckplayergender
			};
		}

		// Token: 0x060206B5 RID: 132789 RVA: 0x0047D076 File Offset: 0x0047B276
		public ICheckInCombatT AsICheckInCombat()
		{
			return this.As<ICheckInCombatT>();
		}

		// Token: 0x060206B6 RID: 132790 RVA: 0x0047D07E File Offset: 0x0047B27E
		public static ICondition2_UnionUnion FromICheckInCombat(ICheckInCombatT _icheckincombat)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckInCombat,
				Value = _icheckincombat
			};
		}

		// Token: 0x060206B7 RID: 132791 RVA: 0x0047D094 File Offset: 0x0047B294
		public ICheckHasFollowShooterT AsICheckHasFollowShooter()
		{
			return this.As<ICheckHasFollowShooterT>();
		}

		// Token: 0x060206B8 RID: 132792 RVA: 0x0047D09C File Offset: 0x0047B29C
		public static ICondition2_UnionUnion FromICheckHasFollowShooter(ICheckHasFollowShooterT _icheckhasfollowshooter)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHasFollowShooter,
				Value = _icheckhasfollowshooter
			};
		}

		// Token: 0x060206B9 RID: 132793 RVA: 0x0047D0B2 File Offset: 0x0047B2B2
		public ICheckFollowShooterActiveT AsICheckFollowShooterActive()
		{
			return this.As<ICheckFollowShooterActiveT>();
		}

		// Token: 0x060206BA RID: 132794 RVA: 0x0047D0BA File Offset: 0x0047B2BA
		public static ICondition2_UnionUnion FromICheckFollowShooterActive(ICheckFollowShooterActiveT _icheckfollowshooteractive)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckFollowShooterActive,
				Value = _icheckfollowshooteractive
			};
		}

		// Token: 0x060206BB RID: 132795 RVA: 0x0047D0D0 File Offset: 0x0047B2D0
		public ICheckChildQuestFinishedT AsICheckChildQuestFinished()
		{
			return this.As<ICheckChildQuestFinishedT>();
		}

		// Token: 0x060206BC RID: 132796 RVA: 0x0047D0D8 File Offset: 0x0047B2D8
		public static ICondition2_UnionUnion FromICheckChildQuestFinished(ICheckChildQuestFinishedT _icheckchildquestfinished)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckChildQuestFinished,
				Value = _icheckchildquestfinished
			};
		}

		// Token: 0x060206BD RID: 132797 RVA: 0x0047D0EE File Offset: 0x0047B2EE
		public ICheckSyncLevelPlayCompleteNumberT AsICheckSyncLevelPlayCompleteNumber()
		{
			return this.As<ICheckSyncLevelPlayCompleteNumberT>();
		}

		// Token: 0x060206BE RID: 132798 RVA: 0x0047D0F6 File Offset: 0x0047B2F6
		public static ICondition2_UnionUnion FromICheckSyncLevelPlayCompleteNumber(ICheckSyncLevelPlayCompleteNumberT _ichecksynclevelplaycompletenumber)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckSyncLevelPlayCompleteNumber,
				Value = _ichecksynclevelplaycompletenumber
			};
		}

		// Token: 0x060206BF RID: 132799 RVA: 0x0047D10C File Offset: 0x0047B30C
		public ICheckCrossSceneSyncKillMonsterFinishedT AsICheckCrossSceneSyncKillMonsterFinished()
		{
			return this.As<ICheckCrossSceneSyncKillMonsterFinishedT>();
		}

		// Token: 0x060206C0 RID: 132800 RVA: 0x0047D114 File Offset: 0x0047B314
		public static ICondition2_UnionUnion FromICheckCrossSceneSyncKillMonsterFinished(ICheckCrossSceneSyncKillMonsterFinishedT _icheckcrossscenesynckillmonsterfinished)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckCrossSceneSyncKillMonsterFinished,
				Value = _icheckcrossscenesynckillmonsterfinished
			};
		}

		// Token: 0x060206C1 RID: 132801 RVA: 0x0047D12A File Offset: 0x0047B32A
		public ICheckNodeStatusT AsICheckNodeStatus()
		{
			return this.As<ICheckNodeStatusT>();
		}

		// Token: 0x060206C2 RID: 132802 RVA: 0x0047D132 File Offset: 0x0047B332
		public static ICondition2_UnionUnion FromICheckNodeStatus(ICheckNodeStatusT _ichecknodestatus)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckNodeStatus,
				Value = _ichecknodestatus
			};
		}

		// Token: 0x060206C3 RID: 132803 RVA: 0x0047D148 File Offset: 0x0047B348
		public ICheckChildQuestStatusT AsICheckChildQuestStatus()
		{
			return this.As<ICheckChildQuestStatusT>();
		}

		// Token: 0x060206C4 RID: 132804 RVA: 0x0047D150 File Offset: 0x0047B350
		public static ICondition2_UnionUnion FromICheckChildQuestStatus(ICheckChildQuestStatusT _icheckchildqueststatus)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckChildQuestStatus,
				Value = _icheckchildqueststatus
			};
		}

		// Token: 0x060206C5 RID: 132805 RVA: 0x0047D166 File Offset: 0x0047B366
		public ICheckEntitiesExistT AsICheckEntitiesExist()
		{
			return this.As<ICheckEntitiesExistT>();
		}

		// Token: 0x060206C6 RID: 132806 RVA: 0x0047D16E File Offset: 0x0047B36E
		public static ICondition2_UnionUnion FromICheckEntitiesExist(ICheckEntitiesExistT _icheckentitiesexist)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntitiesExist,
				Value = _icheckentitiesexist
			};
		}

		// Token: 0x060206C7 RID: 132807 RVA: 0x0047D184 File Offset: 0x0047B384
		public ICheckPlayerPositionT AsICheckPlayerPosition()
		{
			return this.As<ICheckPlayerPositionT>();
		}

		// Token: 0x060206C8 RID: 132808 RVA: 0x0047D18C File Offset: 0x0047B38C
		public static ICondition2_UnionUnion FromICheckPlayerPosition(ICheckPlayerPositionT _icheckplayerposition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerPosition,
				Value = _icheckplayerposition
			};
		}

		// Token: 0x060206C9 RID: 132809 RVA: 0x0047D1A2 File Offset: 0x0047B3A2
		public ICheckEntityPositionT AsICheckEntityPosition()
		{
			return this.As<ICheckEntityPositionT>();
		}

		// Token: 0x060206CA RID: 132810 RVA: 0x0047D1AA File Offset: 0x0047B3AA
		public static ICondition2_UnionUnion FromICheckEntityPosition(ICheckEntityPositionT _icheckentityposition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntityPosition,
				Value = _icheckentityposition
			};
		}

		// Token: 0x060206CB RID: 132811 RVA: 0x0047D1C0 File Offset: 0x0047B3C0
		public ICheckDungeonFinishT AsICheckDungeonFinish()
		{
			return this.As<ICheckDungeonFinishT>();
		}

		// Token: 0x060206CC RID: 132812 RVA: 0x0047D1C8 File Offset: 0x0047B3C8
		public static ICondition2_UnionUnion FromICheckDungeonFinish(ICheckDungeonFinishT _icheckdungeonfinish)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckDungeonFinish,
				Value = _icheckdungeonfinish
			};
		}

		// Token: 0x060206CD RID: 132813 RVA: 0x0047D1DE File Offset: 0x0047B3DE
		public ICheckEntityIsVisibilityT AsICheckEntityIsVisibility()
		{
			return this.As<ICheckEntityIsVisibilityT>();
		}

		// Token: 0x060206CE RID: 132814 RVA: 0x0047D1E6 File Offset: 0x0047B3E6
		public static ICondition2_UnionUnion FromICheckEntityIsVisibility(ICheckEntityIsVisibilityT _icheckentityisvisibility)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntityIsVisibility,
				Value = _icheckentityisvisibility
			};
		}

		// Token: 0x060206CF RID: 132815 RVA: 0x0047D1FC File Offset: 0x0047B3FC
		public IComparePlayerMotionStateT AsIComparePlayerMotionState()
		{
			return this.As<IComparePlayerMotionStateT>();
		}

		// Token: 0x060206D0 RID: 132816 RVA: 0x0047D204 File Offset: 0x0047B404
		public static ICondition2_UnionUnion FromIComparePlayerMotionState(IComparePlayerMotionStateT _icompareplayermotionstate)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.IComparePlayerMotionState,
				Value = _icompareplayermotionstate
			};
		}

		// Token: 0x060206D1 RID: 132817 RVA: 0x0047D21A File Offset: 0x0047B41A
		public IComparePlayerMotionState2T AsIComparePlayerMotionState2()
		{
			return this.As<IComparePlayerMotionState2T>();
		}

		// Token: 0x060206D2 RID: 132818 RVA: 0x0047D222 File Offset: 0x0047B422
		public static ICondition2_UnionUnion FromIComparePlayerMotionState2(IComparePlayerMotionState2T _icompareplayermotionstate2)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.IComparePlayerMotionState2,
				Value = _icompareplayermotionstate2
			};
		}

		// Token: 0x060206D3 RID: 132819 RVA: 0x0047D238 File Offset: 0x0047B438
		public ICheckDataLayerConditionT AsICheckDataLayerCondition()
		{
			return this.As<ICheckDataLayerConditionT>();
		}

		// Token: 0x060206D4 RID: 132820 RVA: 0x0047D240 File Offset: 0x0047B440
		public static ICondition2_UnionUnion FromICheckDataLayerCondition(ICheckDataLayerConditionT _icheckdatalayercondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckDataLayerCondition,
				Value = _icheckdatalayercondition
			};
		}

		// Token: 0x060206D5 RID: 132821 RVA: 0x0047D256 File Offset: 0x0047B456
		public ICheckHookLockPointConditionT AsICheckHookLockPointCondition()
		{
			return this.As<ICheckHookLockPointConditionT>();
		}

		// Token: 0x060206D6 RID: 132822 RVA: 0x0047D25E File Offset: 0x0047B45E
		public static ICondition2_UnionUnion FromICheckHookLockPointCondition(ICheckHookLockPointConditionT _icheckhooklockpointcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHookLockPointCondition,
				Value = _icheckhooklockpointcondition
			};
		}

		// Token: 0x060206D7 RID: 132823 RVA: 0x0047D274 File Offset: 0x0047B474
		public ICheckPlayerSkillReadyConditionT AsICheckPlayerSkillReadyCondition()
		{
			return this.As<ICheckPlayerSkillReadyConditionT>();
		}

		// Token: 0x060206D8 RID: 132824 RVA: 0x0047D27C File Offset: 0x0047B47C
		public static ICondition2_UnionUnion FromICheckPlayerSkillReadyCondition(ICheckPlayerSkillReadyConditionT _icheckplayerskillreadycondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerSkillReadyCondition,
				Value = _icheckplayerskillreadycondition
			};
		}

		// Token: 0x060206D9 RID: 132825 RVA: 0x0047D292 File Offset: 0x0047B492
		public ICheckPlayerUseSkillConditionT AsICheckPlayerUseSkillCondition()
		{
			return this.As<ICheckPlayerUseSkillConditionT>();
		}

		// Token: 0x060206DA RID: 132826 RVA: 0x0047D29A File Offset: 0x0047B49A
		public static ICondition2_UnionUnion FromICheckPlayerUseSkillCondition(ICheckPlayerUseSkillConditionT _icheckplayeruseskillcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerUseSkillCondition,
				Value = _icheckplayeruseskillcondition
			};
		}

		// Token: 0x060206DB RID: 132827 RVA: 0x0047D2B0 File Offset: 0x0047B4B0
		public ICheckPlayerStateRestrictionConditionT AsICheckPlayerStateRestrictionCondition()
		{
			return this.As<ICheckPlayerStateRestrictionConditionT>();
		}

		// Token: 0x060206DC RID: 132828 RVA: 0x0047D2B8 File Offset: 0x0047B4B8
		public static ICondition2_UnionUnion FromICheckPlayerStateRestrictionCondition(ICheckPlayerStateRestrictionConditionT _icheckplayerstaterestrictioncondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerStateRestrictionCondition,
				Value = _icheckplayerstaterestrictioncondition
			};
		}

		// Token: 0x060206DD RID: 132829 RVA: 0x0047D2CE File Offset: 0x0047B4CE
		public ICheckLordGymFinishConditionT AsICheckLordGymFinishCondition()
		{
			return this.As<ICheckLordGymFinishConditionT>();
		}

		// Token: 0x060206DE RID: 132830 RVA: 0x0047D2D6 File Offset: 0x0047B4D6
		public static ICondition2_UnionUnion FromICheckLordGymFinishCondition(ICheckLordGymFinishConditionT _ichecklordgymfinishcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckLordGymFinishCondition,
				Value = _ichecklordgymfinishcondition
			};
		}

		// Token: 0x060206DF RID: 132831 RVA: 0x0047D2EC File Offset: 0x0047B4EC
		public ICheckCalabashDevelopRewardConditionT AsICheckCalabashDevelopRewardCondition()
		{
			return this.As<ICheckCalabashDevelopRewardConditionT>();
		}

		// Token: 0x060206E0 RID: 132832 RVA: 0x0047D2F4 File Offset: 0x0047B4F4
		public static ICondition2_UnionUnion FromICheckCalabashDevelopRewardCondition(ICheckCalabashDevelopRewardConditionT _icheckcalabashdeveloprewardcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckCalabashDevelopRewardCondition,
				Value = _icheckcalabashdeveloprewardcondition
			};
		}

		// Token: 0x060206E1 RID: 132833 RVA: 0x0047D30A File Offset: 0x0047B50A
		public ICompareFishingPrestigeLevelConditionT AsICompareFishingPrestigeLevelCondition()
		{
			return this.As<ICompareFishingPrestigeLevelConditionT>();
		}

		// Token: 0x060206E2 RID: 132834 RVA: 0x0047D312 File Offset: 0x0047B512
		public static ICondition2_UnionUnion FromICompareFishingPrestigeLevelCondition(ICompareFishingPrestigeLevelConditionT _icomparefishingprestigelevelcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareFishingPrestigeLevelCondition,
				Value = _icomparefishingprestigelevelcondition
			};
		}

		// Token: 0x060206E3 RID: 132835 RVA: 0x0047D328 File Offset: 0x0047B528
		public ICheckCertainFishingItemCountT AsICheckCertainFishingItemCount()
		{
			return this.As<ICheckCertainFishingItemCountT>();
		}

		// Token: 0x060206E4 RID: 132836 RVA: 0x0047D330 File Offset: 0x0047B530
		public static ICondition2_UnionUnion FromICheckCertainFishingItemCount(ICheckCertainFishingItemCountT _icheckcertainfishingitemcount)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckCertainFishingItemCount,
				Value = _icheckcertainfishingitemcount
			};
		}

		// Token: 0x060206E5 RID: 132837 RVA: 0x0047D346 File Offset: 0x0047B546
		public ICompleteCertainFishingEntrustT AsICompleteCertainFishingEntrust()
		{
			return this.As<ICompleteCertainFishingEntrustT>();
		}

		// Token: 0x060206E6 RID: 132838 RVA: 0x0047D34E File Offset: 0x0047B54E
		public static ICondition2_UnionUnion FromICompleteCertainFishingEntrust(ICompleteCertainFishingEntrustT _icompletecertainfishingentrust)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompleteCertainFishingEntrust,
				Value = _icompletecertainfishingentrust
			};
		}

		// Token: 0x060206E7 RID: 132839 RVA: 0x0047D364 File Offset: 0x0047B564
		public ICompareFishingBoatStateT AsICompareFishingBoatState()
		{
			return this.As<ICompareFishingBoatStateT>();
		}

		// Token: 0x060206E8 RID: 132840 RVA: 0x0047D36C File Offset: 0x0047B56C
		public static ICondition2_UnionUnion FromICompareFishingBoatState(ICompareFishingBoatStateT _icomparefishingboatstate)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareFishingBoatState,
				Value = _icomparefishingboatstate
			};
		}

		// Token: 0x060206E9 RID: 132841 RVA: 0x0047D382 File Offset: 0x0047B582
		public ICheckJigsawInfoConditionT AsICheckJigsawInfoCondition()
		{
			return this.As<ICheckJigsawInfoConditionT>();
		}

		// Token: 0x060206EA RID: 132842 RVA: 0x0047D38A File Offset: 0x0047B58A
		public static ICondition2_UnionUnion FromICheckJigsawInfoCondition(ICheckJigsawInfoConditionT _icheckjigsawinfocondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckJigsawInfoCondition,
				Value = _icheckjigsawinfocondition
			};
		}

		// Token: 0x060206EB RID: 132843 RVA: 0x0047D3A0 File Offset: 0x0047B5A0
		public ICheckGameplayTagConditionT AsICheckGameplayTagCondition()
		{
			return this.As<ICheckGameplayTagConditionT>();
		}

		// Token: 0x060206EC RID: 132844 RVA: 0x0047D3A8 File Offset: 0x0047B5A8
		public static ICondition2_UnionUnion FromICheckGameplayTagCondition(ICheckGameplayTagConditionT _icheckgameplaytagcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckGameplayTagCondition,
				Value = _icheckgameplaytagcondition
			};
		}

		// Token: 0x060206ED RID: 132845 RVA: 0x0047D3BE File Offset: 0x0047B5BE
		public ICheckFormationRoleInfoConditionT AsICheckFormationRoleInfoCondition()
		{
			return this.As<ICheckFormationRoleInfoConditionT>();
		}

		// Token: 0x060206EE RID: 132846 RVA: 0x0047D3C6 File Offset: 0x0047B5C6
		public static ICondition2_UnionUnion FromICheckFormationRoleInfoCondition(ICheckFormationRoleInfoConditionT _icheckformationroleinfocondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckFormationRoleInfoCondition,
				Value = _icheckformationroleinfocondition
			};
		}

		// Token: 0x060206EF RID: 132847 RVA: 0x0047D3DC File Offset: 0x0047B5DC
		public ICheckTargetAttributeConditionT AsICheckTargetAttributeCondition()
		{
			return this.As<ICheckTargetAttributeConditionT>();
		}

		// Token: 0x060206F0 RID: 132848 RVA: 0x0047D3E4 File Offset: 0x0047B5E4
		public static ICondition2_UnionUnion FromICheckTargetAttributeCondition(ICheckTargetAttributeConditionT _ichecktargetattributecondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckTargetAttributeCondition,
				Value = _ichecktargetattributecondition
			};
		}

		// Token: 0x060206F1 RID: 132849 RVA: 0x0047D3FA File Offset: 0x0047B5FA
		public ICheckRogueAbilitySelectConditionT AsICheckRogueAbilitySelectCondition()
		{
			return this.As<ICheckRogueAbilitySelectConditionT>();
		}

		// Token: 0x060206F2 RID: 132850 RVA: 0x0047D402 File Offset: 0x0047B602
		public static ICondition2_UnionUnion FromICheckRogueAbilitySelectCondition(ICheckRogueAbilitySelectConditionT _icheckrogueabilityselectcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckRogueAbilitySelectCondition,
				Value = _icheckrogueabilityselectcondition
			};
		}

		// Token: 0x060206F3 RID: 132851 RVA: 0x0047D418 File Offset: 0x0047B618
		public ICheckDirectionConditionT AsICheckDirectionCondition()
		{
			return this.As<ICheckDirectionConditionT>();
		}

		// Token: 0x060206F4 RID: 132852 RVA: 0x0047D420 File Offset: 0x0047B620
		public static ICondition2_UnionUnion FromICheckDirectionCondition(ICheckDirectionConditionT _icheckdirectioncondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckDirectionCondition,
				Value = _icheckdirectioncondition
			};
		}

		// Token: 0x060206F5 RID: 132853 RVA: 0x0047D436 File Offset: 0x0047B636
		public ICheckSceneItemDirectionConditionT AsICheckSceneItemDirectionCondition()
		{
			return this.As<ICheckSceneItemDirectionConditionT>();
		}

		// Token: 0x060206F6 RID: 132854 RVA: 0x0047D43E File Offset: 0x0047B63E
		public static ICondition2_UnionUnion FromICheckSceneItemDirectionCondition(ICheckSceneItemDirectionConditionT _ichecksceneitemdirectioncondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckSceneItemDirectionCondition,
				Value = _ichecksceneitemdirectioncondition
			};
		}

		// Token: 0x060206F7 RID: 132855 RVA: 0x0047D454 File Offset: 0x0047B654
		public ICheckPlayerFaceToConditionT AsICheckPlayerFaceToCondition()
		{
			return this.As<ICheckPlayerFaceToConditionT>();
		}

		// Token: 0x060206F8 RID: 132856 RVA: 0x0047D45C File Offset: 0x0047B65C
		public static ICondition2_UnionUnion FromICheckPlayerFaceToCondition(ICheckPlayerFaceToConditionT _icheckplayerfacetocondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerFaceToCondition,
				Value = _icheckplayerfacetocondition
			};
		}

		// Token: 0x060206F9 RID: 132857 RVA: 0x0047D472 File Offset: 0x0047B672
		public ICheckPlayerCanJoinActivityConditionT AsICheckPlayerCanJoinActivityCondition()
		{
			return this.As<ICheckPlayerCanJoinActivityConditionT>();
		}

		// Token: 0x060206FA RID: 132858 RVA: 0x0047D47A File Offset: 0x0047B67A
		public static ICondition2_UnionUnion FromICheckPlayerCanJoinActivityCondition(ICheckPlayerCanJoinActivityConditionT _icheckplayercanjoinactivitycondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerCanJoinActivityCondition,
				Value = _icheckplayercanjoinactivitycondition
			};
		}

		// Token: 0x060206FB RID: 132859 RVA: 0x0047D490 File Offset: 0x0047B690
		public ICheckSystemStateConditionT AsICheckSystemStateCondition()
		{
			return this.As<ICheckSystemStateConditionT>();
		}

		// Token: 0x060206FC RID: 132860 RVA: 0x0047D498 File Offset: 0x0047B698
		public static ICondition2_UnionUnion FromICheckSystemStateCondition(ICheckSystemStateConditionT _ichecksystemstatecondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckSystemStateCondition,
				Value = _ichecksystemstatecondition
			};
		}

		// Token: 0x060206FD RID: 132861 RVA: 0x0047D4AE File Offset: 0x0047B6AE
		public ICheckInRangeConditionT AsICheckInRangeCondition()
		{
			return this.As<ICheckInRangeConditionT>();
		}

		// Token: 0x060206FE RID: 132862 RVA: 0x0047D4B6 File Offset: 0x0047B6B6
		public static ICondition2_UnionUnion FromICheckInRangeCondition(ICheckInRangeConditionT _icheckinrangecondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckInRangeCondition,
				Value = _icheckinrangecondition
			};
		}

		// Token: 0x060206FF RID: 132863 RVA: 0x0047D4CC File Offset: 0x0047B6CC
		public ICheckInRangeProperlyConditionT AsICheckInRangeProperlyCondition()
		{
			return this.As<ICheckInRangeProperlyConditionT>();
		}

		// Token: 0x06020700 RID: 132864 RVA: 0x0047D4D4 File Offset: 0x0047B6D4
		public static ICondition2_UnionUnion FromICheckInRangeProperlyCondition(ICheckInRangeProperlyConditionT _icheckinrangeproperlycondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckInRangeProperlyCondition,
				Value = _icheckinrangeproperlycondition
			};
		}

		// Token: 0x06020701 RID: 132865 RVA: 0x0047D4EA File Offset: 0x0047B6EA
		public ICheckEntityLockedConditionT AsICheckEntityLockedCondition()
		{
			return this.As<ICheckEntityLockedConditionT>();
		}

		// Token: 0x06020702 RID: 132866 RVA: 0x0047D4F2 File Offset: 0x0047B6F2
		public static ICondition2_UnionUnion FromICheckEntityLockedCondition(ICheckEntityLockedConditionT _icheckentitylockedcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntityLockedCondition,
				Value = _icheckentitylockedcondition
			};
		}

		// Token: 0x06020703 RID: 132867 RVA: 0x0047D508 File Offset: 0x0047B708
		public ICompareTeammateDieConditionT AsICompareTeammateDieCondition()
		{
			return this.As<ICompareTeammateDieConditionT>();
		}

		// Token: 0x06020704 RID: 132868 RVA: 0x0047D510 File Offset: 0x0047B710
		public static ICondition2_UnionUnion FromICompareTeammateDieCondition(ICompareTeammateDieConditionT _icompareteammatediecondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareTeammateDieCondition,
				Value = _icompareteammatediecondition
			};
		}

		// Token: 0x06020705 RID: 132869 RVA: 0x0047D526 File Offset: 0x0047B726
		public IListenEntitySelfEventConditionT AsIListenEntitySelfEventCondition()
		{
			return this.As<IListenEntitySelfEventConditionT>();
		}

		// Token: 0x06020706 RID: 132870 RVA: 0x0047D52E File Offset: 0x0047B72E
		public static ICondition2_UnionUnion FromIListenEntitySelfEventCondition(IListenEntitySelfEventConditionT _ilistenentityselfeventcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.IListenEntitySelfEventCondition,
				Value = _ilistenentityselfeventcondition
			};
		}

		// Token: 0x06020707 RID: 132871 RVA: 0x0047D544 File Offset: 0x0047B744
		public ICheckEntityDistanceConditionT AsICheckEntityDistanceCondition()
		{
			return this.As<ICheckEntityDistanceConditionT>();
		}

		// Token: 0x06020708 RID: 132872 RVA: 0x0047D54C File Offset: 0x0047B74C
		public static ICondition2_UnionUnion FromICheckEntityDistanceCondition(ICheckEntityDistanceConditionT _icheckentitydistancecondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntityDistanceCondition,
				Value = _icheckentitydistancecondition
			};
		}

		// Token: 0x06020709 RID: 132873 RVA: 0x0047D562 File Offset: 0x0047B762
		public ICheckEntityHasSceneItemAttributeTagT AsICheckEntityHasSceneItemAttributeTag()
		{
			return this.As<ICheckEntityHasSceneItemAttributeTagT>();
		}

		// Token: 0x0602070A RID: 132874 RVA: 0x0047D56A File Offset: 0x0047B76A
		public static ICondition2_UnionUnion FromICheckEntityHasSceneItemAttributeTag(ICheckEntityHasSceneItemAttributeTagT _icheckentityhassceneitemattributetag)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntityHasSceneItemAttributeTag,
				Value = _icheckentityhassceneitemattributetag
			};
		}

		// Token: 0x0602070B RID: 132875 RVA: 0x0047D580 File Offset: 0x0047B780
		public IListenEntityThroughPortalT AsIListenEntityThroughPortal()
		{
			return this.As<IListenEntityThroughPortalT>();
		}

		// Token: 0x0602070C RID: 132876 RVA: 0x0047D588 File Offset: 0x0047B788
		public static ICondition2_UnionUnion FromIListenEntityThroughPortal(IListenEntityThroughPortalT _ilistenentitythroughportal)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.IListenEntityThroughPortal,
				Value = _ilistenentitythroughportal
			};
		}

		// Token: 0x0602070D RID: 132877 RVA: 0x0047D59E File Offset: 0x0047B79E
		public ICheckTeleControlStateT AsICheckTeleControlState()
		{
			return this.As<ICheckTeleControlStateT>();
		}

		// Token: 0x0602070E RID: 132878 RVA: 0x0047D5A6 File Offset: 0x0047B7A6
		public static ICondition2_UnionUnion FromICheckTeleControlState(ICheckTeleControlStateT _ichecktelecontrolstate)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckTeleControlState,
				Value = _ichecktelecontrolstate
			};
		}

		// Token: 0x0602070F RID: 132879 RVA: 0x0047D5BC File Offset: 0x0047B7BC
		public ICustomJsonConditionT AsICustomJsonCondition()
		{
			return this.As<ICustomJsonConditionT>();
		}

		// Token: 0x06020710 RID: 132880 RVA: 0x0047D5C4 File Offset: 0x0047B7C4
		public static ICondition2_UnionUnion FromICustomJsonCondition(ICustomJsonConditionT _icustomjsoncondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICustomJsonCondition,
				Value = _icustomjsoncondition
			};
		}

		// Token: 0x06020711 RID: 132881 RVA: 0x0047D5DA File Offset: 0x0047B7DA
		public ICheckChessWinnerT AsICheckChessWinner()
		{
			return this.As<ICheckChessWinnerT>();
		}

		// Token: 0x06020712 RID: 132882 RVA: 0x0047D5E2 File Offset: 0x0047B7E2
		public static ICondition2_UnionUnion FromICheckChessWinner(ICheckChessWinnerT _icheckchesswinner)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckChessWinner,
				Value = _icheckchesswinner
			};
		}

		// Token: 0x06020713 RID: 132883 RVA: 0x0047D5F8 File Offset: 0x0047B7F8
		public ICheckVehicleConditionT AsICheckVehicleCondition()
		{
			return this.As<ICheckVehicleConditionT>();
		}

		// Token: 0x06020714 RID: 132884 RVA: 0x0047D600 File Offset: 0x0047B800
		public static ICondition2_UnionUnion FromICheckVehicleCondition(ICheckVehicleConditionT _icheckvehiclecondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckVehicleCondition,
				Value = _icheckvehiclecondition
			};
		}

		// Token: 0x06020715 RID: 132885 RVA: 0x0047D616 File Offset: 0x0047B816
		public ICheckMechStateT AsICheckMechState()
		{
			return this.As<ICheckMechStateT>();
		}

		// Token: 0x06020716 RID: 132886 RVA: 0x0047D61E File Offset: 0x0047B81E
		public static ICondition2_UnionUnion FromICheckMechState(ICheckMechStateT _icheckmechstate)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckMechState,
				Value = _icheckmechstate
			};
		}

		// Token: 0x06020717 RID: 132887 RVA: 0x0047D634 File Offset: 0x0047B834
		public ICheckExploreSkillStateT AsICheckExploreSkillState()
		{
			return this.As<ICheckExploreSkillStateT>();
		}

		// Token: 0x06020718 RID: 132888 RVA: 0x0047D63C File Offset: 0x0047B83C
		public static ICondition2_UnionUnion FromICheckExploreSkillState(ICheckExploreSkillStateT _icheckexploreskillstate)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckExploreSkillState,
				Value = _icheckexploreskillstate
			};
		}

		// Token: 0x06020719 RID: 132889 RVA: 0x0047D652 File Offset: 0x0047B852
		public ICompareAlertValueT AsICompareAlertValue()
		{
			return this.As<ICompareAlertValueT>();
		}

		// Token: 0x0602071A RID: 132890 RVA: 0x0047D65A File Offset: 0x0047B85A
		public static ICondition2_UnionUnion FromICompareAlertValue(ICompareAlertValueT _icomparealertvalue)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareAlertValue,
				Value = _icomparealertvalue
			};
		}

		// Token: 0x0602071B RID: 132891 RVA: 0x0047D670 File Offset: 0x0047B870
		public ICheckEntityGravityDirectionT AsICheckEntityGravityDirection()
		{
			return this.As<ICheckEntityGravityDirectionT>();
		}

		// Token: 0x0602071C RID: 132892 RVA: 0x0047D678 File Offset: 0x0047B878
		public static ICondition2_UnionUnion FromICheckEntityGravityDirection(ICheckEntityGravityDirectionT _icheckentitygravitydirection)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntityGravityDirection,
				Value = _icheckentitygravitydirection
			};
		}

		// Token: 0x0602071D RID: 132893 RVA: 0x0047D68E File Offset: 0x0047B88E
		public ICheckCollectAnimalPartsT AsICheckCollectAnimalParts()
		{
			return this.As<ICheckCollectAnimalPartsT>();
		}

		// Token: 0x0602071E RID: 132894 RVA: 0x0047D696 File Offset: 0x0047B896
		public static ICondition2_UnionUnion FromICheckCollectAnimalParts(ICheckCollectAnimalPartsT _icheckcollectanimalparts)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckCollectAnimalParts,
				Value = _icheckcollectanimalparts
			};
		}

		// Token: 0x0602071F RID: 132895 RVA: 0x0047D6AC File Offset: 0x0047B8AC
		public ICheckPreloadCompleteT AsICheckPreloadComplete()
		{
			return this.As<ICheckPreloadCompleteT>();
		}

		// Token: 0x06020720 RID: 132896 RVA: 0x0047D6B4 File Offset: 0x0047B8B4
		public static ICondition2_UnionUnion FromICheckPreloadComplete(ICheckPreloadCompleteT _icheckpreloadcomplete)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPreloadComplete,
				Value = _icheckpreloadcomplete
			};
		}

		// Token: 0x06020721 RID: 132897 RVA: 0x0047D6CA File Offset: 0x0047B8CA
		public ICheckFinishLoadingT AsICheckFinishLoading()
		{
			return this.As<ICheckFinishLoadingT>();
		}

		// Token: 0x06020722 RID: 132898 RVA: 0x0047D6D2 File Offset: 0x0047B8D2
		public static ICondition2_UnionUnion FromICheckFinishLoading(ICheckFinishLoadingT _icheckfinishloading)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckFinishLoading,
				Value = _icheckfinishloading
			};
		}

		// Token: 0x06020723 RID: 132899 RVA: 0x0047D6E8 File Offset: 0x0047B8E8
		public ICheckFishingPointHasFishT AsICheckFishingPointHasFish()
		{
			return this.As<ICheckFishingPointHasFishT>();
		}

		// Token: 0x06020724 RID: 132900 RVA: 0x0047D6F0 File Offset: 0x0047B8F0
		public static ICondition2_UnionUnion FromICheckFishingPointHasFish(ICheckFishingPointHasFishT _icheckfishingpointhasfish)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckFishingPointHasFish,
				Value = _icheckfishingpointhasfish
			};
		}

		// Token: 0x06020725 RID: 132901 RVA: 0x0047D706 File Offset: 0x0047B906
		public ICheckFishingCageFillingRatioT AsICheckFishingCageFillingRatio()
		{
			return this.As<ICheckFishingCageFillingRatioT>();
		}

		// Token: 0x06020726 RID: 132902 RVA: 0x0047D70E File Offset: 0x0047B90E
		public static ICondition2_UnionUnion FromICheckFishingCageFillingRatio(ICheckFishingCageFillingRatioT _icheckfishingcagefillingratio)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckFishingCageFillingRatio,
				Value = _icheckfishingcagefillingratio
			};
		}

		// Token: 0x06020727 RID: 132903 RVA: 0x0047D724 File Offset: 0x0047B924
		public ICompareFishingTechLevelT AsICompareFishingTechLevel()
		{
			return this.As<ICompareFishingTechLevelT>();
		}

		// Token: 0x06020728 RID: 132904 RVA: 0x0047D72C File Offset: 0x0047B92C
		public static ICondition2_UnionUnion FromICompareFishingTechLevel(ICompareFishingTechLevelT _icomparefishingtechlevel)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareFishingTechLevel,
				Value = _icomparefishingtechlevel
			};
		}

		// Token: 0x06020729 RID: 132905 RVA: 0x0047D742 File Offset: 0x0047B942
		public ICheckGuestCharacterT AsICheckGuestCharacter()
		{
			return this.As<ICheckGuestCharacterT>();
		}

		// Token: 0x0602072A RID: 132906 RVA: 0x0047D74A File Offset: 0x0047B94A
		public static ICondition2_UnionUnion FromICheckGuestCharacter(ICheckGuestCharacterT _icheckguestcharacter)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckGuestCharacter,
				Value = _icheckguestcharacter
			};
		}

		// Token: 0x0602072B RID: 132907 RVA: 0x0047D760 File Offset: 0x0047B960
		public ICheckSubLevelStateT AsICheckSubLevelState()
		{
			return this.As<ICheckSubLevelStateT>();
		}

		// Token: 0x0602072C RID: 132908 RVA: 0x0047D768 File Offset: 0x0047B968
		public static ICondition2_UnionUnion FromICheckSubLevelState(ICheckSubLevelStateT _ichecksublevelstate)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckSubLevelState,
				Value = _ichecksublevelstate
			};
		}

		// Token: 0x0602072D RID: 132909 RVA: 0x0047D77E File Offset: 0x0047B97E
		public IComparePlayerNumInDungeonT AsIComparePlayerNumInDungeon()
		{
			return this.As<IComparePlayerNumInDungeonT>();
		}

		// Token: 0x0602072E RID: 132910 RVA: 0x0047D786 File Offset: 0x0047B986
		public static ICondition2_UnionUnion FromIComparePlayerNumInDungeon(IComparePlayerNumInDungeonT _icompareplayernumindungeon)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.IComparePlayerNumInDungeon,
				Value = _icompareplayernumindungeon
			};
		}

		// Token: 0x0602072F RID: 132911 RVA: 0x0047D79C File Offset: 0x0047B99C
		public ICheckAlertAreaEnabledT AsICheckAlertAreaEnabled()
		{
			return this.As<ICheckAlertAreaEnabledT>();
		}

		// Token: 0x06020730 RID: 132912 RVA: 0x0047D7A4 File Offset: 0x0047B9A4
		public static ICondition2_UnionUnion FromICheckAlertAreaEnabled(ICheckAlertAreaEnabledT _icheckalertareaenabled)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckAlertAreaEnabled,
				Value = _icheckalertareaenabled
			};
		}

		// Token: 0x06020731 RID: 132913 RVA: 0x0047D7BA File Offset: 0x0047B9BA
		public ICheckClientEventT AsICheckClientEvent()
		{
			return this.As<ICheckClientEventT>();
		}

		// Token: 0x06020732 RID: 132914 RVA: 0x0047D7C2 File Offset: 0x0047B9C2
		public static ICondition2_UnionUnion FromICheckClientEvent(ICheckClientEventT _icheckclientevent)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckClientEvent,
				Value = _icheckclientevent
			};
		}

		// Token: 0x06020733 RID: 132915 RVA: 0x0047D7D8 File Offset: 0x0047B9D8
		public ICheckIsGramophonePlayingMusicT AsICheckIsGramophonePlayingMusic()
		{
			return this.As<ICheckIsGramophonePlayingMusicT>();
		}

		// Token: 0x06020734 RID: 132916 RVA: 0x0047D7E0 File Offset: 0x0047B9E0
		public static ICondition2_UnionUnion FromICheckIsGramophonePlayingMusic(ICheckIsGramophonePlayingMusicT _icheckisgramophoneplayingmusic)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsGramophonePlayingMusic,
				Value = _icheckisgramophoneplayingmusic
			};
		}

		// Token: 0x06020735 RID: 132917 RVA: 0x0047D7F6 File Offset: 0x0047B9F6
		public ICheckEntityRewardT AsICheckEntityReward()
		{
			return this.As<ICheckEntityRewardT>();
		}

		// Token: 0x06020736 RID: 132918 RVA: 0x0047D7FE File Offset: 0x0047B9FE
		public static ICondition2_UnionUnion FromICheckEntityReward(ICheckEntityRewardT _icheckentityreward)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntityReward,
				Value = _icheckentityreward
			};
		}

		// Token: 0x06020737 RID: 132919 RVA: 0x0047D814 File Offset: 0x0047BA14
		public ICheckDungeonHasSaveConfigT AsICheckDungeonHasSaveConfig()
		{
			return this.As<ICheckDungeonHasSaveConfigT>();
		}

		// Token: 0x06020738 RID: 132920 RVA: 0x0047D81C File Offset: 0x0047BA1C
		public static ICondition2_UnionUnion FromICheckDungeonHasSaveConfig(ICheckDungeonHasSaveConfigT _icheckdungeonhassaveconfig)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckDungeonHasSaveConfig,
				Value = _icheckdungeonhassaveconfig
			};
		}

		// Token: 0x06020739 RID: 132921 RVA: 0x0047D832 File Offset: 0x0047BA32
		public ICheckSystemEventBvbT AsICheckSystemEventBvb()
		{
			return this.As<ICheckSystemEventBvbT>();
		}

		// Token: 0x0602073A RID: 132922 RVA: 0x0047D83A File Offset: 0x0047BA3A
		public static ICondition2_UnionUnion FromICheckSystemEventBvb(ICheckSystemEventBvbT _ichecksystemeventbvb)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckSystemEventBvb,
				Value = _ichecksystemeventbvb
			};
		}

		// Token: 0x0602073B RID: 132923 RVA: 0x0047D850 File Offset: 0x0047BA50
		public ICheckDangoCultivationProgressT AsICheckDangoCultivationProgress()
		{
			return this.As<ICheckDangoCultivationProgressT>();
		}

		// Token: 0x0602073C RID: 132924 RVA: 0x0047D858 File Offset: 0x0047BA58
		public static ICondition2_UnionUnion FromICheckDangoCultivationProgress(ICheckDangoCultivationProgressT _icheckdangocultivationprogress)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckDangoCultivationProgress,
				Value = _icheckdangocultivationprogress
			};
		}

		// Token: 0x0602073D RID: 132925 RVA: 0x0047D86E File Offset: 0x0047BA6E
		public ICheckPlayerMoraleLevelRangeT AsICheckPlayerMoraleLevelRange()
		{
			return this.As<ICheckPlayerMoraleLevelRangeT>();
		}

		// Token: 0x0602073E RID: 132926 RVA: 0x0047D876 File Offset: 0x0047BA76
		public static ICondition2_UnionUnion FromICheckPlayerMoraleLevelRange(ICheckPlayerMoraleLevelRangeT _icheckplayermoralelevelrange)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerMoraleLevelRange,
				Value = _icheckplayermoralelevelrange
			};
		}

		// Token: 0x0602073F RID: 132927 RVA: 0x0047D88C File Offset: 0x0047BA8C
		public ICheckIsGlobalTimeScaleEnabledT AsICheckIsGlobalTimeScaleEnabled()
		{
			return this.As<ICheckIsGlobalTimeScaleEnabledT>();
		}

		// Token: 0x06020740 RID: 132928 RVA: 0x0047D894 File Offset: 0x0047BA94
		public static ICondition2_UnionUnion FromICheckIsGlobalTimeScaleEnabled(ICheckIsGlobalTimeScaleEnabledT _icheckisglobaltimescaleenabled)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsGlobalTimeScaleEnabled,
				Value = _icheckisglobaltimescaleenabled
			};
		}

		// Token: 0x06020741 RID: 132929 RVA: 0x0047D8AA File Offset: 0x0047BAAA
		public ISaveConfigEnterMethodT AsISaveConfigEnterMethod()
		{
			return this.As<ISaveConfigEnterMethodT>();
		}

		// Token: 0x06020742 RID: 132930 RVA: 0x0047D8B2 File Offset: 0x0047BAB2
		public static ICondition2_UnionUnion FromISaveConfigEnterMethod(ISaveConfigEnterMethodT _isaveconfigentermethod)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ISaveConfigEnterMethod,
				Value = _isaveconfigentermethod
			};
		}

		// Token: 0x06020743 RID: 132931 RVA: 0x0047D8C8 File Offset: 0x0047BAC8
		public ICheckIsEntityTimeScaleEnabledT AsICheckIsEntityTimeScaleEnabled()
		{
			return this.As<ICheckIsEntityTimeScaleEnabledT>();
		}

		// Token: 0x06020744 RID: 132932 RVA: 0x0047D8D0 File Offset: 0x0047BAD0
		public static ICondition2_UnionUnion FromICheckIsEntityTimeScaleEnabled(ICheckIsEntityTimeScaleEnabledT _icheckisentitytimescaleenabled)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsEntityTimeScaleEnabled,
				Value = _icheckisentitytimescaleenabled
			};
		}

		// Token: 0x06020745 RID: 132933 RVA: 0x0047D8E6 File Offset: 0x0047BAE6
		public ICheckIsCharacterHoldingHandsT AsICheckIsCharacterHoldingHands()
		{
			return this.As<ICheckIsCharacterHoldingHandsT>();
		}

		// Token: 0x06020746 RID: 132934 RVA: 0x0047D8EE File Offset: 0x0047BAEE
		public static ICondition2_UnionUnion FromICheckIsCharacterHoldingHands(ICheckIsCharacterHoldingHandsT _icheckischaracterholdinghands)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsCharacterHoldingHands,
				Value = _icheckischaracterholdinghands
			};
		}

		// Token: 0x06020747 RID: 132935 RVA: 0x0047D904 File Offset: 0x0047BB04
		public ICheckIsTrackingCurrentQuestT AsICheckIsTrackingCurrentQuest()
		{
			return this.As<ICheckIsTrackingCurrentQuestT>();
		}

		// Token: 0x06020748 RID: 132936 RVA: 0x0047D90C File Offset: 0x0047BB0C
		public static ICondition2_UnionUnion FromICheckIsTrackingCurrentQuest(ICheckIsTrackingCurrentQuestT _icheckistrackingcurrentquest)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsTrackingCurrentQuest,
				Value = _icheckistrackingcurrentquest
			};
		}

		// Token: 0x06020749 RID: 132937 RVA: 0x0047D922 File Offset: 0x0047BB22
		public ICheckIsTrackingQuestT AsICheckIsTrackingQuest()
		{
			return this.As<ICheckIsTrackingQuestT>();
		}

		// Token: 0x0602074A RID: 132938 RVA: 0x0047D92A File Offset: 0x0047BB2A
		public static ICondition2_UnionUnion FromICheckIsTrackingQuest(ICheckIsTrackingQuestT _icheckistrackingquest)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsTrackingQuest,
				Value = _icheckistrackingquest
			};
		}

		// Token: 0x0602074B RID: 132939 RVA: 0x0047D940 File Offset: 0x0047BB40
		public ICheckMusicEventT AsICheckMusicEvent()
		{
			return this.As<ICheckMusicEventT>();
		}

		// Token: 0x0602074C RID: 132940 RVA: 0x0047D948 File Offset: 0x0047BB48
		public static ICondition2_UnionUnion FromICheckMusicEvent(ICheckMusicEventT _icheckmusicevent)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckMusicEvent,
				Value = _icheckmusicevent
			};
		}

		// Token: 0x0602074D RID: 132941 RVA: 0x0047D95E File Offset: 0x0047BB5E
		public ICompareGameDifficultyT AsICompareGameDifficulty()
		{
			return this.As<ICompareGameDifficultyT>();
		}

		// Token: 0x0602074E RID: 132942 RVA: 0x0047D966 File Offset: 0x0047BB66
		public static ICondition2_UnionUnion FromICompareGameDifficulty(ICompareGameDifficultyT _icomparegamedifficulty)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareGameDifficulty,
				Value = _icomparegamedifficulty
			};
		}

		// Token: 0x0602074F RID: 132943 RVA: 0x0047D97C File Offset: 0x0047BB7C
		public ICheckPhotographCameraParamT AsICheckPhotographCameraParam()
		{
			return this.As<ICheckPhotographCameraParamT>();
		}

		// Token: 0x06020750 RID: 132944 RVA: 0x0047D984 File Offset: 0x0047BB84
		public static ICondition2_UnionUnion FromICheckPhotographCameraParam(ICheckPhotographCameraParamT _icheckphotographcameraparam)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPhotographCameraParam,
				Value = _icheckphotographcameraparam
			};
		}

		// Token: 0x06020751 RID: 132945 RVA: 0x0047D99A File Offset: 0x0047BB9A
		public ICheckEntityHasBuffT AsICheckEntityHasBuff()
		{
			return this.As<ICheckEntityHasBuffT>();
		}

		// Token: 0x06020752 RID: 132946 RVA: 0x0047D9A2 File Offset: 0x0047BBA2
		public static ICondition2_UnionUnion FromICheckEntityHasBuff(ICheckEntityHasBuffT _icheckentityhasbuff)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntityHasBuff,
				Value = _icheckentityhasbuff
			};
		}

		// Token: 0x06020753 RID: 132947 RVA: 0x0047D9B8 File Offset: 0x0047BBB8
		public ICheckEntityBuffStackT AsICheckEntityBuffStack()
		{
			return this.As<ICheckEntityBuffStackT>();
		}

		// Token: 0x06020754 RID: 132948 RVA: 0x0047D9C0 File Offset: 0x0047BBC0
		public static ICondition2_UnionUnion FromICheckEntityBuffStack(ICheckEntityBuffStackT _icheckentitybuffstack)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntityBuffStack,
				Value = _icheckentitybuffstack
			};
		}

		// Token: 0x06020755 RID: 132949 RVA: 0x0047D9D6 File Offset: 0x0047BBD6
		public ICheckAvailableSunSpiritCountT AsICheckAvailableSunSpiritCount()
		{
			return this.As<ICheckAvailableSunSpiritCountT>();
		}

		// Token: 0x06020756 RID: 132950 RVA: 0x0047D9DE File Offset: 0x0047BBDE
		public static ICondition2_UnionUnion FromICheckAvailableSunSpiritCount(ICheckAvailableSunSpiritCountT _icheckavailablesunspiritcount)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckAvailableSunSpiritCount,
				Value = _icheckavailablesunspiritcount
			};
		}

		// Token: 0x06020757 RID: 132951 RVA: 0x0047D9F4 File Offset: 0x0047BBF4
		public ICheckPlayerEnterClientTriggerDirT AsICheckPlayerEnterClientTriggerDir()
		{
			return this.As<ICheckPlayerEnterClientTriggerDirT>();
		}

		// Token: 0x06020758 RID: 132952 RVA: 0x0047D9FC File Offset: 0x0047BBFC
		public static ICondition2_UnionUnion FromICheckPlayerEnterClientTriggerDir(ICheckPlayerEnterClientTriggerDirT _icheckplayerenterclienttriggerdir)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerEnterClientTriggerDir,
				Value = _icheckplayerenterclienttriggerdir
			};
		}

		// Token: 0x06020759 RID: 132953 RVA: 0x0047DA12 File Offset: 0x0047BC12
		public ICheckPlayerRelativeDistanceT AsICheckPlayerRelativeDistance()
		{
			return this.As<ICheckPlayerRelativeDistanceT>();
		}

		// Token: 0x0602075A RID: 132954 RVA: 0x0047DA1A File Offset: 0x0047BC1A
		public static ICondition2_UnionUnion FromICheckPlayerRelativeDistance(ICheckPlayerRelativeDistanceT _icheckplayerrelativedistance)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerRelativeDistance,
				Value = _icheckplayerrelativedistance
			};
		}

		// Token: 0x0602075B RID: 132955 RVA: 0x0047DA30 File Offset: 0x0047BC30
		public ICheckPlayerRelativeAngleT AsICheckPlayerRelativeAngle()
		{
			return this.As<ICheckPlayerRelativeAngleT>();
		}

		// Token: 0x0602075C RID: 132956 RVA: 0x0047DA38 File Offset: 0x0047BC38
		public static ICondition2_UnionUnion FromICheckPlayerRelativeAngle(ICheckPlayerRelativeAngleT _icheckplayerrelativeangle)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerRelativeAngle,
				Value = _icheckplayerrelativeangle
			};
		}

		// Token: 0x0602075D RID: 132957 RVA: 0x0047DA4E File Offset: 0x0047BC4E
		public ICheckHonamiStoryGetItemT AsICheckHonamiStoryGetItem()
		{
			return this.As<ICheckHonamiStoryGetItemT>();
		}

		// Token: 0x0602075E RID: 132958 RVA: 0x0047DA56 File Offset: 0x0047BC56
		public static ICondition2_UnionUnion FromICheckHonamiStoryGetItem(ICheckHonamiStoryGetItemT _icheckhonamistorygetitem)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHonamiStoryGetItem,
				Value = _icheckhonamistorygetitem
			};
		}

		// Token: 0x0602075F RID: 132959 RVA: 0x0047DA6C File Offset: 0x0047BC6C
		public ICheckHonamiStoryEquipItemT AsICheckHonamiStoryEquipItem()
		{
			return this.As<ICheckHonamiStoryEquipItemT>();
		}

		// Token: 0x06020760 RID: 132960 RVA: 0x0047DA74 File Offset: 0x0047BC74
		public static ICondition2_UnionUnion FromICheckHonamiStoryEquipItem(ICheckHonamiStoryEquipItemT _icheckhonamistoryequipitem)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHonamiStoryEquipItem,
				Value = _icheckhonamistoryequipitem
			};
		}

		// Token: 0x06020761 RID: 132961 RVA: 0x0047DA8A File Offset: 0x0047BC8A
		public ICheckHonamiStoryActivateTalentT AsICheckHonamiStoryActivateTalent()
		{
			return this.As<ICheckHonamiStoryActivateTalentT>();
		}

		// Token: 0x06020762 RID: 132962 RVA: 0x0047DA92 File Offset: 0x0047BC92
		public static ICondition2_UnionUnion FromICheckHonamiStoryActivateTalent(ICheckHonamiStoryActivateTalentT _icheckhonamistoryactivatetalent)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHonamiStoryActivateTalent,
				Value = _icheckhonamistoryactivatetalent
			};
		}

		// Token: 0x06020763 RID: 132963 RVA: 0x0047DAA8 File Offset: 0x0047BCA8
		public ICheckHonamiStoryUnlockSlotT AsICheckHonamiStoryUnlockSlot()
		{
			return this.As<ICheckHonamiStoryUnlockSlotT>();
		}

		// Token: 0x06020764 RID: 132964 RVA: 0x0047DAB0 File Offset: 0x0047BCB0
		public static ICondition2_UnionUnion FromICheckHonamiStoryUnlockSlot(ICheckHonamiStoryUnlockSlotT _icheckhonamistoryunlockslot)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHonamiStoryUnlockSlot,
				Value = _icheckhonamistoryunlockslot
			};
		}

		// Token: 0x06020765 RID: 132965 RVA: 0x0047DAC6 File Offset: 0x0047BCC6
		public ICheckHonamiStoryLifeSupportLevelT AsICheckHonamiStoryLifeSupportLevel()
		{
			return this.As<ICheckHonamiStoryLifeSupportLevelT>();
		}

		// Token: 0x06020766 RID: 132966 RVA: 0x0047DACE File Offset: 0x0047BCCE
		public static ICondition2_UnionUnion FromICheckHonamiStoryLifeSupportLevel(ICheckHonamiStoryLifeSupportLevelT _icheckhonamistorylifesupportlevel)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHonamiStoryLifeSupportLevel,
				Value = _icheckhonamistorylifesupportlevel
			};
		}

		// Token: 0x06020767 RID: 132967 RVA: 0x0047DAE4 File Offset: 0x0047BCE4
		public ICheckHonamiStoryTowerCompleteT AsICheckHonamiStoryTowerComplete()
		{
			return this.As<ICheckHonamiStoryTowerCompleteT>();
		}

		// Token: 0x06020768 RID: 132968 RVA: 0x0047DAEC File Offset: 0x0047BCEC
		public static ICondition2_UnionUnion FromICheckHonamiStoryTowerComplete(ICheckHonamiStoryTowerCompleteT _icheckhonamistorytowercomplete)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHonamiStoryTowerComplete,
				Value = _icheckhonamistorytowercomplete
			};
		}

		// Token: 0x06020769 RID: 132969 RVA: 0x0047DB02 File Offset: 0x0047BD02
		public ICheckHonamiStoryPlayerCorruptedLevelT AsICheckHonamiStoryPlayerCorruptedLevel()
		{
			return this.As<ICheckHonamiStoryPlayerCorruptedLevelT>();
		}

		// Token: 0x0602076A RID: 132970 RVA: 0x0047DB0A File Offset: 0x0047BD0A
		public static ICondition2_UnionUnion FromICheckHonamiStoryPlayerCorruptedLevel(ICheckHonamiStoryPlayerCorruptedLevelT _icheckhonamistoryplayercorruptedlevel)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHonamiStoryPlayerCorruptedLevel,
				Value = _icheckhonamistoryplayercorruptedlevel
			};
		}

		// Token: 0x0602076B RID: 132971 RVA: 0x0047DB20 File Offset: 0x0047BD20
		public ICheckHonamiStoryUnlockMascotT AsICheckHonamiStoryUnlockMascot()
		{
			return this.As<ICheckHonamiStoryUnlockMascotT>();
		}

		// Token: 0x0602076C RID: 132972 RVA: 0x0047DB28 File Offset: 0x0047BD28
		public static ICondition2_UnionUnion FromICheckHonamiStoryUnlockMascot(ICheckHonamiStoryUnlockMascotT _icheckhonamistoryunlockmascot)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHonamiStoryUnlockMascot,
				Value = _icheckhonamistoryunlockmascot
			};
		}

		// Token: 0x0602076D RID: 132973 RVA: 0x0047DB3E File Offset: 0x0047BD3E
		public ICheckHonamiStoryChestOpenTimeT AsICheckHonamiStoryChestOpenTime()
		{
			return this.As<ICheckHonamiStoryChestOpenTimeT>();
		}

		// Token: 0x0602076E RID: 132974 RVA: 0x0047DB46 File Offset: 0x0047BD46
		public static ICondition2_UnionUnion FromICheckHonamiStoryChestOpenTime(ICheckHonamiStoryChestOpenTimeT _icheckhonamistorychestopentime)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHonamiStoryChestOpenTime,
				Value = _icheckhonamistorychestopentime
			};
		}

		// Token: 0x0602076F RID: 132975 RVA: 0x0047DB5C File Offset: 0x0047BD5C
		public ICheckHonamiStorySuccessfulEvacuationT AsICheckHonamiStorySuccessfulEvacuation()
		{
			return this.As<ICheckHonamiStorySuccessfulEvacuationT>();
		}

		// Token: 0x06020770 RID: 132976 RVA: 0x0047DB64 File Offset: 0x0047BD64
		public static ICondition2_UnionUnion FromICheckHonamiStorySuccessfulEvacuation(ICheckHonamiStorySuccessfulEvacuationT _icheckhonamistorysuccessfulevacuation)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckHonamiStorySuccessfulEvacuation,
				Value = _icheckhonamistorysuccessfulevacuation
			};
		}

		// Token: 0x06020771 RID: 132977 RVA: 0x0047DB7A File Offset: 0x0047BD7A
		public ICheckBvbChallengeStateT AsICheckBvbChallengeState()
		{
			return this.As<ICheckBvbChallengeStateT>();
		}

		// Token: 0x06020772 RID: 132978 RVA: 0x0047DB82 File Offset: 0x0047BD82
		public static ICondition2_UnionUnion FromICheckBvbChallengeState(ICheckBvbChallengeStateT _icheckbvbchallengestate)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckBvbChallengeState,
				Value = _icheckbvbchallengestate
			};
		}

		// Token: 0x06020773 RID: 132979 RVA: 0x0047DB98 File Offset: 0x0047BD98
		public ICheckBvbActivityRankT AsICheckBvbActivityRank()
		{
			return this.As<ICheckBvbActivityRankT>();
		}

		// Token: 0x06020774 RID: 132980 RVA: 0x0047DBA0 File Offset: 0x0047BDA0
		public static ICondition2_UnionUnion FromICheckBvbActivityRank(ICheckBvbActivityRankT _icheckbvbactivityrank)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckBvbActivityRank,
				Value = _icheckbvbactivityrank
			};
		}

		// Token: 0x06020775 RID: 132981 RVA: 0x0047DBB6 File Offset: 0x0047BDB6
		public ICheckDiceGameChallengeStateT AsICheckDiceGameChallengeState()
		{
			return this.As<ICheckDiceGameChallengeStateT>();
		}

		// Token: 0x06020776 RID: 132982 RVA: 0x0047DBBE File Offset: 0x0047BDBE
		public static ICondition2_UnionUnion FromICheckDiceGameChallengeState(ICheckDiceGameChallengeStateT _icheckdicegamechallengestate)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckDiceGameChallengeState,
				Value = _icheckdicegamechallengestate
			};
		}

		// Token: 0x06020777 RID: 132983 RVA: 0x0047DBD4 File Offset: 0x0047BDD4
		public ICompareDiceGameRankLevelT AsICompareDiceGameRankLevel()
		{
			return this.As<ICompareDiceGameRankLevelT>();
		}

		// Token: 0x06020778 RID: 132984 RVA: 0x0047DBDC File Offset: 0x0047BDDC
		public static ICondition2_UnionUnion FromICompareDiceGameRankLevel(ICompareDiceGameRankLevelT _icomparedicegameranklevel)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareDiceGameRankLevel,
				Value = _icomparedicegameranklevel
			};
		}

		// Token: 0x06020779 RID: 132985 RVA: 0x0047DBF2 File Offset: 0x0047BDF2
		public ICheckCollectedSunSpiritCountT AsICheckCollectedSunSpiritCount()
		{
			return this.As<ICheckCollectedSunSpiritCountT>();
		}

		// Token: 0x0602077A RID: 132986 RVA: 0x0047DBFA File Offset: 0x0047BDFA
		public static ICondition2_UnionUnion FromICheckCollectedSunSpiritCount(ICheckCollectedSunSpiritCountT _icheckcollectedsunspiritcount)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckCollectedSunSpiritCount,
				Value = _icheckcollectedsunspiritcount
			};
		}

		// Token: 0x0602077B RID: 132987 RVA: 0x0047DC10 File Offset: 0x0047BE10
		public ICheckTargetSunSpiritCollectedT AsICheckTargetSunSpiritCollected()
		{
			return this.As<ICheckTargetSunSpiritCollectedT>();
		}

		// Token: 0x0602077C RID: 132988 RVA: 0x0047DC18 File Offset: 0x0047BE18
		public static ICondition2_UnionUnion FromICheckTargetSunSpiritCollected(ICheckTargetSunSpiritCollectedT _ichecktargetsunspiritcollected)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckTargetSunSpiritCollected,
				Value = _ichecktargetsunspiritcollected
			};
		}

		// Token: 0x0602077D RID: 132989 RVA: 0x0047DC2E File Offset: 0x0047BE2E
		public ICheckPlayerIsInDeadEyeProcessT AsICheckPlayerIsInDeadEyeProcess()
		{
			return this.As<ICheckPlayerIsInDeadEyeProcessT>();
		}

		// Token: 0x0602077E RID: 132990 RVA: 0x0047DC36 File Offset: 0x0047BE36
		public static ICondition2_UnionUnion FromICheckPlayerIsInDeadEyeProcess(ICheckPlayerIsInDeadEyeProcessT _icheckplayerisindeadeyeprocess)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerIsInDeadEyeProcess,
				Value = _icheckplayerisindeadeyeprocess
			};
		}

		// Token: 0x0602077F RID: 132991 RVA: 0x0047DC4C File Offset: 0x0047BE4C
		public ICheckEntitySelfDirectionT AsICheckEntitySelfDirection()
		{
			return this.As<ICheckEntitySelfDirectionT>();
		}

		// Token: 0x06020780 RID: 132992 RVA: 0x0047DC54 File Offset: 0x0047BE54
		public static ICondition2_UnionUnion FromICheckEntitySelfDirection(ICheckEntitySelfDirectionT _icheckentityselfdirection)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntitySelfDirection,
				Value = _icheckentityselfdirection
			};
		}

		// Token: 0x06020781 RID: 132993 RVA: 0x0047DC6D File Offset: 0x0047BE6D
		public ICheckDollGrabItemComboAchievedInOnceDeliveryT AsICheckDollGrabItemComboAchievedInOnceDelivery()
		{
			return this.As<ICheckDollGrabItemComboAchievedInOnceDeliveryT>();
		}

		// Token: 0x06020782 RID: 132994 RVA: 0x0047DC75 File Offset: 0x0047BE75
		public static ICondition2_UnionUnion FromICheckDollGrabItemComboAchievedInOnceDelivery(ICheckDollGrabItemComboAchievedInOnceDeliveryT _icheckdollgrabitemcomboachievedinoncedelivery)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckDollGrabItemComboAchievedInOnceDelivery,
				Value = _icheckdollgrabitemcomboachievedinoncedelivery
			};
		}

		// Token: 0x06020783 RID: 132995 RVA: 0x0047DC8E File Offset: 0x0047BE8E
		public ICheckDollGrabShowcaseItemComboAchievedT AsICheckDollGrabShowcaseItemComboAchieved()
		{
			return this.As<ICheckDollGrabShowcaseItemComboAchievedT>();
		}

		// Token: 0x06020784 RID: 132996 RVA: 0x0047DC96 File Offset: 0x0047BE96
		public static ICondition2_UnionUnion FromICheckDollGrabShowcaseItemComboAchieved(ICheckDollGrabShowcaseItemComboAchievedT _icheckdollgrabshowcaseitemcomboachieved)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckDollGrabShowcaseItemComboAchieved,
				Value = _icheckdollgrabshowcaseitemcomboachieved
			};
		}

		// Token: 0x06020785 RID: 132997 RVA: 0x0047DCAF File Offset: 0x0047BEAF
		public ICheckRoverRogueAbilitySelectConditionT AsICheckRoverRogueAbilitySelectCondition()
		{
			return this.As<ICheckRoverRogueAbilitySelectConditionT>();
		}

		// Token: 0x06020786 RID: 132998 RVA: 0x0047DCB7 File Offset: 0x0047BEB7
		public static ICondition2_UnionUnion FromICheckRoverRogueAbilitySelectCondition(ICheckRoverRogueAbilitySelectConditionT _icheckroverrogueabilityselectcondition)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckRoverRogueAbilitySelectCondition,
				Value = _icheckroverrogueabilityselectcondition
			};
		}

		// Token: 0x06020787 RID: 132999 RVA: 0x0047DCD0 File Offset: 0x0047BED0
		public ICheckDollGrabMachineFinishedT AsICheckDollGrabMachineFinished()
		{
			return this.As<ICheckDollGrabMachineFinishedT>();
		}

		// Token: 0x06020788 RID: 133000 RVA: 0x0047DCD8 File Offset: 0x0047BED8
		public static ICondition2_UnionUnion FromICheckDollGrabMachineFinished(ICheckDollGrabMachineFinishedT _icheckdollgrabmachinefinished)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckDollGrabMachineFinished,
				Value = _icheckdollgrabmachinefinished
			};
		}

		// Token: 0x06020789 RID: 133001 RVA: 0x0047DCF1 File Offset: 0x0047BEF1
		public ICheckTrafficBlockedT AsICheckTrafficBlocked()
		{
			return this.As<ICheckTrafficBlockedT>();
		}

		// Token: 0x0602078A RID: 133002 RVA: 0x0047DCF9 File Offset: 0x0047BEF9
		public static ICondition2_UnionUnion FromICheckTrafficBlocked(ICheckTrafficBlockedT _ichecktrafficblocked)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckTrafficBlocked,
				Value = _ichecktrafficblocked
			};
		}

		// Token: 0x0602078B RID: 133003 RVA: 0x0047DD12 File Offset: 0x0047BF12
		public ICheckDrinksPreferenceLevelT AsICheckDrinksPreferenceLevel()
		{
			return this.As<ICheckDrinksPreferenceLevelT>();
		}

		// Token: 0x0602078C RID: 133004 RVA: 0x0047DD1A File Offset: 0x0047BF1A
		public static ICondition2_UnionUnion FromICheckDrinksPreferenceLevel(ICheckDrinksPreferenceLevelT _icheckdrinkspreferencelevel)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckDrinksPreferenceLevel,
				Value = _icheckdrinkspreferencelevel
			};
		}

		// Token: 0x0602078D RID: 133005 RVA: 0x0047DD33 File Offset: 0x0047BF33
		public ICheckPlayerIsInMotorcycleCruiseT AsICheckPlayerIsInMotorcycleCruise()
		{
			return this.As<ICheckPlayerIsInMotorcycleCruiseT>();
		}

		// Token: 0x0602078E RID: 133006 RVA: 0x0047DD3B File Offset: 0x0047BF3B
		public static ICondition2_UnionUnion FromICheckPlayerIsInMotorcycleCruise(ICheckPlayerIsInMotorcycleCruiseT _icheckplayerisinmotorcyclecruise)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerIsInMotorcycleCruise,
				Value = _icheckplayerisinmotorcyclecruise
			};
		}

		// Token: 0x0602078F RID: 133007 RVA: 0x0047DD54 File Offset: 0x0047BF54
		public ICheckPlayerIsControlledByAiT AsICheckPlayerIsControlledByAi()
		{
			return this.As<ICheckPlayerIsControlledByAiT>();
		}

		// Token: 0x06020790 RID: 133008 RVA: 0x0047DD5C File Offset: 0x0047BF5C
		public static ICondition2_UnionUnion FromICheckPlayerIsControlledByAi(ICheckPlayerIsControlledByAiT _icheckplayeriscontrolledbyai)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckPlayerIsControlledByAi,
				Value = _icheckplayeriscontrolledbyai
			};
		}

		// Token: 0x06020791 RID: 133009 RVA: 0x0047DD75 File Offset: 0x0047BF75
		public ICheckTetrisEndlessScoreT AsICheckTetrisEndlessScore()
		{
			return this.As<ICheckTetrisEndlessScoreT>();
		}

		// Token: 0x06020792 RID: 133010 RVA: 0x0047DD7D File Offset: 0x0047BF7D
		public static ICondition2_UnionUnion FromICheckTetrisEndlessScore(ICheckTetrisEndlessScoreT _ichecktetrisendlessscore)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckTetrisEndlessScore,
				Value = _ichecktetrisendlessscore
			};
		}

		// Token: 0x06020793 RID: 133011 RVA: 0x0047DD96 File Offset: 0x0047BF96
		public ICheckDartLevelCompleteT AsICheckDartLevelComplete()
		{
			return this.As<ICheckDartLevelCompleteT>();
		}

		// Token: 0x06020794 RID: 133012 RVA: 0x0047DD9E File Offset: 0x0047BF9E
		public static ICondition2_UnionUnion FromICheckDartLevelComplete(ICheckDartLevelCompleteT _icheckdartlevelcomplete)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckDartLevelComplete,
				Value = _icheckdartlevelcomplete
			};
		}

		// Token: 0x06020795 RID: 133013 RVA: 0x0047DDB7 File Offset: 0x0047BFB7
		public ICheckAtlasUnlockedT AsICheckAtlasUnlocked()
		{
			return this.As<ICheckAtlasUnlockedT>();
		}

		// Token: 0x06020796 RID: 133014 RVA: 0x0047DDBF File Offset: 0x0047BFBF
		public static ICondition2_UnionUnion FromICheckAtlasUnlocked(ICheckAtlasUnlockedT _icheckatlasunlocked)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckAtlasUnlocked,
				Value = _icheckatlasunlocked
			};
		}

		// Token: 0x06020797 RID: 133015 RVA: 0x0047DDD8 File Offset: 0x0047BFD8
		public ICheckSheriffUnlockEndingT AsICheckSheriffUnlockEnding()
		{
			return this.As<ICheckSheriffUnlockEndingT>();
		}

		// Token: 0x06020798 RID: 133016 RVA: 0x0047DDE0 File Offset: 0x0047BFE0
		public static ICondition2_UnionUnion FromICheckSheriffUnlockEnding(ICheckSheriffUnlockEndingT _ichecksheriffunlockending)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckSheriffUnlockEnding,
				Value = _ichecksheriffunlockending
			};
		}

		// Token: 0x06020799 RID: 133017 RVA: 0x0047DDF9 File Offset: 0x0047BFF9
		public ICheckIsInDragActorPlayT AsICheckIsInDragActorPlay()
		{
			return this.As<ICheckIsInDragActorPlayT>();
		}

		// Token: 0x0602079A RID: 133018 RVA: 0x0047DE01 File Offset: 0x0047C001
		public static ICondition2_UnionUnion FromICheckIsInDragActorPlay(ICheckIsInDragActorPlayT _icheckisindragactorplay)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsInDragActorPlay,
				Value = _icheckisindragactorplay
			};
		}

		// Token: 0x0602079B RID: 133019 RVA: 0x0047DE1A File Offset: 0x0047C01A
		public ICheckIsInDollGrabGamePlayT AsICheckIsInDollGrabGamePlay()
		{
			return this.As<ICheckIsInDollGrabGamePlayT>();
		}

		// Token: 0x0602079C RID: 133020 RVA: 0x0047DE22 File Offset: 0x0047C022
		public static ICondition2_UnionUnion FromICheckIsInDollGrabGamePlay(ICheckIsInDollGrabGamePlayT _icheckisindollgrabgameplay)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsInDollGrabGamePlay,
				Value = _icheckisindollgrabgameplay
			};
		}

		// Token: 0x0602079D RID: 133021 RVA: 0x0047DE3B File Offset: 0x0047C03B
		public ICheckIsInDartGameplayT AsICheckIsInDartGameplay()
		{
			return this.As<ICheckIsInDartGameplayT>();
		}

		// Token: 0x0602079E RID: 133022 RVA: 0x0047DE43 File Offset: 0x0047C043
		public static ICondition2_UnionUnion FromICheckIsInDartGameplay(ICheckIsInDartGameplayT _icheckisindartgameplay)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsInDartGameplay,
				Value = _icheckisindartgameplay
			};
		}

		// Token: 0x0602079F RID: 133023 RVA: 0x0047DE5C File Offset: 0x0047C05C
		public ICheckIsInRideFlyingCarGameplayT AsICheckIsInRideFlyingCarGameplay()
		{
			return this.As<ICheckIsInRideFlyingCarGameplayT>();
		}

		// Token: 0x060207A0 RID: 133024 RVA: 0x0047DE64 File Offset: 0x0047C064
		public static ICondition2_UnionUnion FromICheckIsInRideFlyingCarGameplay(ICheckIsInRideFlyingCarGameplayT _icheckisinrideflyingcargameplay)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsInRideFlyingCarGameplay,
				Value = _icheckisinrideflyingcargameplay
			};
		}

		// Token: 0x060207A1 RID: 133025 RVA: 0x0047DE7D File Offset: 0x0047C07D
		public ICheckEntityPrefabPerformanceTypeT AsICheckEntityPrefabPerformanceType()
		{
			return this.As<ICheckEntityPrefabPerformanceTypeT>();
		}

		// Token: 0x060207A2 RID: 133026 RVA: 0x0047DE85 File Offset: 0x0047C085
		public static ICondition2_UnionUnion FromICheckEntityPrefabPerformanceType(ICheckEntityPrefabPerformanceTypeT _icheckentityprefabperformancetype)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckEntityPrefabPerformanceType,
				Value = _icheckentityprefabperformancetype
			};
		}

		// Token: 0x060207A3 RID: 133027 RVA: 0x0047DE9E File Offset: 0x0047C09E
		public ICheckIsSupportedWalkingT AsICheckIsSupportedWalking()
		{
			return this.As<ICheckIsSupportedWalkingT>();
		}

		// Token: 0x060207A4 RID: 133028 RVA: 0x0047DEA6 File Offset: 0x0047C0A6
		public static ICondition2_UnionUnion FromICheckIsSupportedWalking(ICheckIsSupportedWalkingT _icheckissupportedwalking)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsSupportedWalking,
				Value = _icheckissupportedwalking
			};
		}

		// Token: 0x060207A5 RID: 133029 RVA: 0x0047DEBF File Offset: 0x0047C0BF
		public ICheckGiantStableValueT AsICheckGiantStableValue()
		{
			return this.As<ICheckGiantStableValueT>();
		}

		// Token: 0x060207A6 RID: 133030 RVA: 0x0047DEC7 File Offset: 0x0047C0C7
		public static ICondition2_UnionUnion FromICheckGiantStableValue(ICheckGiantStableValueT _icheckgiantstablevalue)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckGiantStableValue,
				Value = _icheckgiantstablevalue
			};
		}

		// Token: 0x060207A7 RID: 133031 RVA: 0x0047DEE0 File Offset: 0x0047C0E0
		public ICheckGiantTotalProgressCanActivateNodeT AsICheckGiantTotalProgressCanActivateNode()
		{
			return this.As<ICheckGiantTotalProgressCanActivateNodeT>();
		}

		// Token: 0x060207A8 RID: 133032 RVA: 0x0047DEE8 File Offset: 0x0047C0E8
		public static ICondition2_UnionUnion FromICheckGiantTotalProgressCanActivateNode(ICheckGiantTotalProgressCanActivateNodeT _icheckgianttotalprogresscanactivatenode)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckGiantTotalProgressCanActivateNode,
				Value = _icheckgianttotalprogresscanactivatenode
			};
		}

		// Token: 0x060207A9 RID: 133033 RVA: 0x0047DF01 File Offset: 0x0047C101
		public ICheckGiantTotalProgressInteractActivatedNodeT AsICheckGiantTotalProgressInteractActivatedNode()
		{
			return this.As<ICheckGiantTotalProgressInteractActivatedNodeT>();
		}

		// Token: 0x060207AA RID: 133034 RVA: 0x0047DF09 File Offset: 0x0047C109
		public static ICondition2_UnionUnion FromICheckGiantTotalProgressInteractActivatedNode(ICheckGiantTotalProgressInteractActivatedNodeT _icheckgianttotalprogressinteractactivatednode)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckGiantTotalProgressInteractActivatedNode,
				Value = _icheckgianttotalprogressinteractactivatednode
			};
		}

		// Token: 0x060207AB RID: 133035 RVA: 0x0047DF22 File Offset: 0x0047C122
		public ICheckGiantRegionCultivationTriggeredUpgradeLevelT AsICheckGiantRegionCultivationTriggeredUpgradeLevel()
		{
			return this.As<ICheckGiantRegionCultivationTriggeredUpgradeLevelT>();
		}

		// Token: 0x060207AC RID: 133036 RVA: 0x0047DF2A File Offset: 0x0047C12A
		public static ICondition2_UnionUnion FromICheckGiantRegionCultivationTriggeredUpgradeLevel(ICheckGiantRegionCultivationTriggeredUpgradeLevelT _icheckgiantregioncultivationtriggeredupgradelevel)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckGiantRegionCultivationTriggeredUpgradeLevel,
				Value = _icheckgiantregioncultivationtriggeredupgradelevel
			};
		}

		// Token: 0x060207AD RID: 133037 RVA: 0x0047DF43 File Offset: 0x0047C143
		public ICheckElementalBoxStateT AsICheckElementalBoxState()
		{
			return this.As<ICheckElementalBoxStateT>();
		}

		// Token: 0x060207AE RID: 133038 RVA: 0x0047DF4B File Offset: 0x0047C14B
		public static ICondition2_UnionUnion FromICheckElementalBoxState(ICheckElementalBoxStateT _icheckelementalboxstate)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckElementalBoxState,
				Value = _icheckelementalboxstate
			};
		}

		// Token: 0x060207AF RID: 133039 RVA: 0x0047DF64 File Offset: 0x0047C164
		public ICheckIsTargetHoldElementalBoxT AsICheckIsTargetHoldElementalBox()
		{
			return this.As<ICheckIsTargetHoldElementalBoxT>();
		}

		// Token: 0x060207B0 RID: 133040 RVA: 0x0047DF6C File Offset: 0x0047C16C
		public static ICondition2_UnionUnion FromICheckIsTargetHoldElementalBox(ICheckIsTargetHoldElementalBoxT _icheckistargetholdelementalbox)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsTargetHoldElementalBox,
				Value = _icheckistargetholdelementalbox
			};
		}

		// Token: 0x060207B1 RID: 133041 RVA: 0x0047DF85 File Offset: 0x0047C185
		public ICheckElementalEffectActiveT AsICheckElementalEffectActive()
		{
			return this.As<ICheckElementalEffectActiveT>();
		}

		// Token: 0x060207B2 RID: 133042 RVA: 0x0047DF8D File Offset: 0x0047C18D
		public static ICondition2_UnionUnion FromICheckElementalEffectActive(ICheckElementalEffectActiveT _icheckelementaleffectactive)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckElementalEffectActive,
				Value = _icheckelementaleffectactive
			};
		}

		// Token: 0x060207B3 RID: 133043 RVA: 0x0047DFA6 File Offset: 0x0047C1A6
		public ICheckElementalWaterBoxStagnationSeqT AsICheckElementalWaterBoxStagnationSeq()
		{
			return this.As<ICheckElementalWaterBoxStagnationSeqT>();
		}

		// Token: 0x060207B4 RID: 133044 RVA: 0x0047DFAE File Offset: 0x0047C1AE
		public static ICondition2_UnionUnion FromICheckElementalWaterBoxStagnationSeq(ICheckElementalWaterBoxStagnationSeqT _icheckelementalwaterboxstagnationseq)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckElementalWaterBoxStagnationSeq,
				Value = _icheckelementalwaterboxstagnationseq
			};
		}

		// Token: 0x060207B5 RID: 133045 RVA: 0x0047DFC7 File Offset: 0x0047C1C7
		public ICompareSeasonAndWeatherT AsICompareSeasonAndWeather()
		{
			return this.As<ICompareSeasonAndWeatherT>();
		}

		// Token: 0x060207B6 RID: 133046 RVA: 0x0047DFCF File Offset: 0x0047C1CF
		public static ICondition2_UnionUnion FromICompareSeasonAndWeather(ICompareSeasonAndWeatherT _icompareseasonandweather)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICompareSeasonAndWeather,
				Value = _icompareseasonandweather
			};
		}

		// Token: 0x060207B7 RID: 133047 RVA: 0x0047DFE8 File Offset: 0x0047C1E8
		public ICheckIsSpecialWeatherUnlockedT AsICheckIsSpecialWeatherUnlocked()
		{
			return this.As<ICheckIsSpecialWeatherUnlockedT>();
		}

		// Token: 0x060207B8 RID: 133048 RVA: 0x0047DFF0 File Offset: 0x0047C1F0
		public static ICondition2_UnionUnion FromICheckIsSpecialWeatherUnlocked(ICheckIsSpecialWeatherUnlockedT _icheckisspecialweatherunlocked)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckIsSpecialWeatherUnlocked,
				Value = _icheckisspecialweatherunlocked
			};
		}

		// Token: 0x060207B9 RID: 133049 RVA: 0x0047E009 File Offset: 0x0047C209
		public ICheckCollectiblesDetectionAllowedT AsICheckCollectiblesDetectionAllowed()
		{
			return this.As<ICheckCollectiblesDetectionAllowedT>();
		}

		// Token: 0x060207BA RID: 133050 RVA: 0x0047E011 File Offset: 0x0047C211
		public static ICondition2_UnionUnion FromICheckCollectiblesDetectionAllowed(ICheckCollectiblesDetectionAllowedT _icheckcollectiblesdetectionallowed)
		{
			return new ICondition2_UnionUnion
			{
				Type = ICondition2_Union.ICheckCollectiblesDetectionAllowed,
				Value = _icheckcollectiblesdetectionallowed
			};
		}

		// Token: 0x060207BB RID: 133051 RVA: 0x0047E02C File Offset: 0x0047C22C
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
			case ICondition2_Union.ICheckMechState:
				return ICheckMechState.Pack(builder, _o.AsICheckMechState()).Value;
			case ICondition2_Union.ICheckExploreSkillState:
				return ICheckExploreSkillState.Pack(builder, _o.AsICheckExploreSkillState()).Value;
			case ICondition2_Union.ICompareAlertValue:
				return ICompareAlertValue.Pack(builder, _o.AsICompareAlertValue()).Value;
			case ICondition2_Union.ICheckEntityGravityDirection:
				return ICheckEntityGravityDirection.Pack(builder, _o.AsICheckEntityGravityDirection()).Value;
			case ICondition2_Union.ICheckCollectAnimalParts:
				return ICheckCollectAnimalParts.Pack(builder, _o.AsICheckCollectAnimalParts()).Value;
			case ICondition2_Union.ICheckPreloadComplete:
				return ICheckPreloadComplete.Pack(builder, _o.AsICheckPreloadComplete()).Value;
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
			case ICondition2_Union.ICheckDiceGameChallengeState:
				return ICheckDiceGameChallengeState.Pack(builder, _o.AsICheckDiceGameChallengeState()).Value;
			case ICondition2_Union.ICompareDiceGameRankLevel:
				return ICompareDiceGameRankLevel.Pack(builder, _o.AsICompareDiceGameRankLevel()).Value;
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
			case ICondition2_Union.ICheckPlayerIsControlledByAi:
				return ICheckPlayerIsControlledByAi.Pack(builder, _o.AsICheckPlayerIsControlledByAi()).Value;
			case ICondition2_Union.ICheckTetrisEndlessScore:
				return ICheckTetrisEndlessScore.Pack(builder, _o.AsICheckTetrisEndlessScore()).Value;
			case ICondition2_Union.ICheckDartLevelComplete:
				return ICheckDartLevelComplete.Pack(builder, _o.AsICheckDartLevelComplete()).Value;
			case ICondition2_Union.ICheckAtlasUnlocked:
				return ICheckAtlasUnlocked.Pack(builder, _o.AsICheckAtlasUnlocked()).Value;
			case ICondition2_Union.ICheckSheriffUnlockEnding:
				return ICheckSheriffUnlockEnding.Pack(builder, _o.AsICheckSheriffUnlockEnding()).Value;
			case ICondition2_Union.ICheckIsInDragActorPlay:
				return ICheckIsInDragActorPlay.Pack(builder, _o.AsICheckIsInDragActorPlay()).Value;
			case ICondition2_Union.ICheckIsInDollGrabGamePlay:
				return ICheckIsInDollGrabGamePlay.Pack(builder, _o.AsICheckIsInDollGrabGamePlay()).Value;
			case ICondition2_Union.ICheckIsInDartGameplay:
				return ICheckIsInDartGameplay.Pack(builder, _o.AsICheckIsInDartGameplay()).Value;
			case ICondition2_Union.ICheckIsInRideFlyingCarGameplay:
				return ICheckIsInRideFlyingCarGameplay.Pack(builder, _o.AsICheckIsInRideFlyingCarGameplay()).Value;
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
			case ICondition2_Union.ICompareSeasonAndWeather:
				return ICompareSeasonAndWeather.Pack(builder, _o.AsICompareSeasonAndWeather()).Value;
			case ICondition2_Union.ICheckIsSpecialWeatherUnlocked:
				return ICheckIsSpecialWeatherUnlocked.Pack(builder, _o.AsICheckIsSpecialWeatherUnlocked()).Value;
			case ICondition2_Union.ICheckCollectiblesDetectionAllowed:
				return ICheckCollectiblesDetectionAllowed.Pack(builder, _o.AsICheckCollectiblesDetectionAllowed()).Value;
			default:
				return 0;
			}
		}
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004413 RID: 17427
	public class IQuestCondition_UnionUnion
	{
		// Token: 0x17007871 RID: 30833
		// (get) Token: 0x06018D9E RID: 101790 RVA: 0x0038B348 File Offset: 0x00389548
		// (set) Token: 0x06018D9F RID: 101791 RVA: 0x0038B350 File Offset: 0x00389550
		public IQuestCondition_Union Type { get; set; }

		// Token: 0x17007872 RID: 30834
		// (get) Token: 0x06018DA0 RID: 101792 RVA: 0x0038B359 File Offset: 0x00389559
		// (set) Token: 0x06018DA1 RID: 101793 RVA: 0x0038B361 File Offset: 0x00389561
		public object Value { get; set; }

		// Token: 0x06018DA2 RID: 101794 RVA: 0x0038B36A File Offset: 0x0038956A
		public IQuestCondition_UnionUnion()
		{
			this.Type = IQuestCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06018DA3 RID: 101795 RVA: 0x0038B380 File Offset: 0x00389580
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06018DA4 RID: 101796 RVA: 0x0038B392 File Offset: 0x00389592
		public IQuestConditionT AsIQuestCondition()
		{
			return this.As<IQuestConditionT>();
		}

		// Token: 0x06018DA5 RID: 101797 RVA: 0x0038B39A File Offset: 0x0038959A
		public static IQuestCondition_UnionUnion FromIQuestCondition(IQuestConditionT _iquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IQuestCondition,
				Value = _iquestcondition
			};
		}

		// Token: 0x06018DA6 RID: 101798 RVA: 0x0038B3AF File Offset: 0x003895AF
		public IInformationViewCheckConditionT AsIInformationViewCheckCondition()
		{
			return this.As<IInformationViewCheckConditionT>();
		}

		// Token: 0x06018DA7 RID: 101799 RVA: 0x0038B3B7 File Offset: 0x003895B7
		public static IQuestCondition_UnionUnion FromIInformationViewCheckCondition(IInformationViewCheckConditionT _iinformationviewcheckcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IInformationViewCheckCondition,
				Value = _iinformationviewcheckcondition
			};
		}

		// Token: 0x06018DA8 RID: 101800 RVA: 0x0038B3CC File Offset: 0x003895CC
		public IUseItemConditionT AsIUseItemCondition()
		{
			return this.As<IUseItemConditionT>();
		}

		// Token: 0x06018DA9 RID: 101801 RVA: 0x0038B3D4 File Offset: 0x003895D4
		public static IQuestCondition_UnionUnion FromIUseItemCondition(IUseItemConditionT _iuseitemcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IUseItemCondition,
				Value = _iuseitemcondition
			};
		}

		// Token: 0x06018DAA RID: 101802 RVA: 0x0038B3E9 File Offset: 0x003895E9
		public IGetItemQuestConditionT AsIGetItemQuestCondition()
		{
			return this.As<IGetItemQuestConditionT>();
		}

		// Token: 0x06018DAB RID: 101803 RVA: 0x0038B3F1 File Offset: 0x003895F1
		public static IQuestCondition_UnionUnion FromIGetItemQuestCondition(IGetItemQuestConditionT _igetitemquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IGetItemQuestCondition,
				Value = _igetitemquestcondition
			};
		}

		// Token: 0x06018DAC RID: 101804 RVA: 0x0038B406 File Offset: 0x00389606
		public ICheckEntityStateQuestConditionT AsICheckEntityStateQuestCondition()
		{
			return this.As<ICheckEntityStateQuestConditionT>();
		}

		// Token: 0x06018DAD RID: 101805 RVA: 0x0038B40E File Offset: 0x0038960E
		public static IQuestCondition_UnionUnion FromICheckEntityStateQuestCondition(ICheckEntityStateQuestConditionT _icheckentitystatequestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICheckEntityStateQuestCondition,
				Value = _icheckentitystatequestcondition
			};
		}

		// Token: 0x06018DAE RID: 101806 RVA: 0x0038B423 File Offset: 0x00389623
		public ICheckLevelPlayQuestConditionT AsICheckLevelPlayQuestCondition()
		{
			return this.As<ICheckLevelPlayQuestConditionT>();
		}

		// Token: 0x06018DAF RID: 101807 RVA: 0x0038B42B File Offset: 0x0038962B
		public static IQuestCondition_UnionUnion FromICheckLevelPlayQuestCondition(ICheckLevelPlayQuestConditionT _ichecklevelplayquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICheckLevelPlayQuestCondition,
				Value = _ichecklevelplayquestcondition
			};
		}

		// Token: 0x06018DB0 RID: 101808 RVA: 0x0038B440 File Offset: 0x00389640
		public ICheckUiGameQuestConditionT AsICheckUiGameQuestCondition()
		{
			return this.As<ICheckUiGameQuestConditionT>();
		}

		// Token: 0x06018DB1 RID: 101809 RVA: 0x0038B448 File Offset: 0x00389648
		public static IQuestCondition_UnionUnion FromICheckUiGameQuestCondition(ICheckUiGameQuestConditionT _icheckuigamequestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICheckUiGameQuestCondition,
				Value = _icheckuigamequestcondition
			};
		}

		// Token: 0x06018DB2 RID: 101810 RVA: 0x0038B45D File Offset: 0x0038965D
		public IReadPhoneMessageQuestConditionT AsIReadPhoneMessageQuestCondition()
		{
			return this.As<IReadPhoneMessageQuestConditionT>();
		}

		// Token: 0x06018DB3 RID: 101811 RVA: 0x0038B465 File Offset: 0x00389665
		public static IQuestCondition_UnionUnion FromIReadPhoneMessageQuestCondition(IReadPhoneMessageQuestConditionT _ireadphonemessagequestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IReadPhoneMessageQuestCondition,
				Value = _ireadphonemessagequestcondition
			};
		}

		// Token: 0x06018DB4 RID: 101812 RVA: 0x0038B47A File Offset: 0x0038967A
		public IUseSkillQuestConditionT AsIUseSkillQuestCondition()
		{
			return this.As<IUseSkillQuestConditionT>();
		}

		// Token: 0x06018DB5 RID: 101813 RVA: 0x0038B482 File Offset: 0x00389682
		public static IQuestCondition_UnionUnion FromIUseSkillQuestCondition(IUseSkillQuestConditionT _iuseskillquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IUseSkillQuestCondition,
				Value = _iuseskillquestcondition
			};
		}

		// Token: 0x06018DB6 RID: 101814 RVA: 0x0038B498 File Offset: 0x00389698
		public IGetSkillQuestConditionT AsIGetSkillQuestCondition()
		{
			return this.As<IGetSkillQuestConditionT>();
		}

		// Token: 0x06018DB7 RID: 101815 RVA: 0x0038B4A0 File Offset: 0x003896A0
		public static IQuestCondition_UnionUnion FromIGetSkillQuestCondition(IGetSkillQuestConditionT _igetskillquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IGetSkillQuestCondition,
				Value = _igetskillquestcondition
			};
		}

		// Token: 0x06018DB8 RID: 101816 RVA: 0x0038B4B6 File Offset: 0x003896B6
		public IPlayFlowQuestConditionT AsIPlayFlowQuestCondition()
		{
			return this.As<IPlayFlowQuestConditionT>();
		}

		// Token: 0x06018DB9 RID: 101817 RVA: 0x0038B4BE File Offset: 0x003896BE
		public static IQuestCondition_UnionUnion FromIPlayFlowQuestCondition(IPlayFlowQuestConditionT _iplayflowquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IPlayFlowQuestCondition,
				Value = _iplayflowquestcondition
			};
		}

		// Token: 0x06018DBA RID: 101818 RVA: 0x0038B4D4 File Offset: 0x003896D4
		public IDoInteractQuestConditionT AsIDoInteractQuestCondition()
		{
			return this.As<IDoInteractQuestConditionT>();
		}

		// Token: 0x06018DBB RID: 101819 RVA: 0x0038B4DC File Offset: 0x003896DC
		public static IQuestCondition_UnionUnion FromIDoInteractQuestCondition(IDoInteractQuestConditionT _idointeractquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IDoInteractQuestCondition,
				Value = _idointeractquestcondition
			};
		}

		// Token: 0x06018DBC RID: 101820 RVA: 0x0038B4F2 File Offset: 0x003896F2
		public IReachAreaQuestConditionT AsIReachAreaQuestCondition()
		{
			return this.As<IReachAreaQuestConditionT>();
		}

		// Token: 0x06018DBD RID: 101821 RVA: 0x0038B4FA File Offset: 0x003896FA
		public static IQuestCondition_UnionUnion FromIReachAreaQuestCondition(IReachAreaQuestConditionT _ireachareaquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IReachAreaQuestCondition,
				Value = _ireachareaquestcondition
			};
		}

		// Token: 0x06018DBE RID: 101822 RVA: 0x0038B510 File Offset: 0x00389710
		public IKillChildQuestConditionT AsIKillChildQuestCondition()
		{
			return this.As<IKillChildQuestConditionT>();
		}

		// Token: 0x06018DBF RID: 101823 RVA: 0x0038B518 File Offset: 0x00389718
		public static IQuestCondition_UnionUnion FromIKillChildQuestCondition(IKillChildQuestConditionT _ikillchildquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IKillChildQuestCondition,
				Value = _ikillchildquestcondition
			};
		}

		// Token: 0x06018DC0 RID: 101824 RVA: 0x0038B52E File Offset: 0x0038972E
		public IDetectCombatStateConditionT AsIDetectCombatStateCondition()
		{
			return this.As<IDetectCombatStateConditionT>();
		}

		// Token: 0x06018DC1 RID: 101825 RVA: 0x0038B536 File Offset: 0x00389736
		public static IQuestCondition_UnionUnion FromIDetectCombatStateCondition(IDetectCombatStateConditionT _idetectcombatstatecondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IDetectCombatStateCondition,
				Value = _idetectcombatstatecondition
			};
		}

		// Token: 0x06018DC2 RID: 101826 RVA: 0x0038B54C File Offset: 0x0038974C
		public IDetectCombatState2ConditionT AsIDetectCombatState2Condition()
		{
			return this.As<IDetectCombatState2ConditionT>();
		}

		// Token: 0x06018DC3 RID: 101827 RVA: 0x0038B554 File Offset: 0x00389754
		public static IQuestCondition_UnionUnion FromIDetectCombatState2Condition(IDetectCombatState2ConditionT _idetectcombatstate2condition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IDetectCombatState2Condition,
				Value = _idetectcombatstate2condition
			};
		}

		// Token: 0x06018DC4 RID: 101828 RVA: 0x0038B56A File Offset: 0x0038976A
		public IHandInItemsConditionT AsIHandInItemsCondition()
		{
			return this.As<IHandInItemsConditionT>();
		}

		// Token: 0x06018DC5 RID: 101829 RVA: 0x0038B572 File Offset: 0x00389772
		public static IQuestCondition_UnionUnion FromIHandInItemsCondition(IHandInItemsConditionT _ihandinitemscondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IHandInItemsCondition,
				Value = _ihandinitemscondition
			};
		}

		// Token: 0x06018DC6 RID: 101830 RVA: 0x0038B588 File Offset: 0x00389788
		public INewHandInItemsConditionT AsINewHandInItemsCondition()
		{
			return this.As<INewHandInItemsConditionT>();
		}

		// Token: 0x06018DC7 RID: 101831 RVA: 0x0038B590 File Offset: 0x00389790
		public static IQuestCondition_UnionUnion FromINewHandInItemsCondition(INewHandInItemsConditionT _inewhandinitemscondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.INewHandInItemsCondition,
				Value = _inewhandinitemscondition
			};
		}

		// Token: 0x06018DC8 RID: 101832 RVA: 0x0038B5A6 File Offset: 0x003897A6
		public IFinishDungeonQuestConditionT AsIFinishDungeonQuestCondition()
		{
			return this.As<IFinishDungeonQuestConditionT>();
		}

		// Token: 0x06018DC9 RID: 101833 RVA: 0x0038B5AE File Offset: 0x003897AE
		public static IQuestCondition_UnionUnion FromIFinishDungeonQuestCondition(IFinishDungeonQuestConditionT _ifinishdungeonquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishDungeonQuestCondition,
				Value = _ifinishdungeonquestcondition
			};
		}

		// Token: 0x06018DCA RID: 101834 RVA: 0x0038B5C4 File Offset: 0x003897C4
		public IWaitTimeConditionT AsIWaitTimeCondition()
		{
			return this.As<IWaitTimeConditionT>();
		}

		// Token: 0x06018DCB RID: 101835 RVA: 0x0038B5CC File Offset: 0x003897CC
		public static IQuestCondition_UnionUnion FromIWaitTimeCondition(IWaitTimeConditionT _iwaittimecondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IWaitTimeCondition,
				Value = _iwaittimecondition
			};
		}

		// Token: 0x06018DCC RID: 101836 RVA: 0x0038B5E2 File Offset: 0x003897E2
		public IScheduleTimeConditionT AsIScheduleTimeCondition()
		{
			return this.As<IScheduleTimeConditionT>();
		}

		// Token: 0x06018DCD RID: 101837 RVA: 0x0038B5EA File Offset: 0x003897EA
		public static IQuestCondition_UnionUnion FromIScheduleTimeCondition(IScheduleTimeConditionT _ischeduletimecondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IScheduleTimeCondition,
				Value = _ischeduletimecondition
			};
		}

		// Token: 0x06018DCE RID: 101838 RVA: 0x0038B600 File Offset: 0x00389800
		public IReadMailConditionT AsIReadMailCondition()
		{
			return this.As<IReadMailConditionT>();
		}

		// Token: 0x06018DCF RID: 101839 RVA: 0x0038B608 File Offset: 0x00389808
		public static IQuestCondition_UnionUnion FromIReadMailCondition(IReadMailConditionT _ireadmailcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IReadMailCondition,
				Value = _ireadmailcondition
			};
		}

		// Token: 0x06018DD0 RID: 101840 RVA: 0x0038B61E File Offset: 0x0038981E
		public IGuideConditionT AsIGuideCondition()
		{
			return this.As<IGuideConditionT>();
		}

		// Token: 0x06018DD1 RID: 101841 RVA: 0x0038B626 File Offset: 0x00389826
		public static IQuestCondition_UnionUnion FromIGuideCondition(IGuideConditionT _iguidecondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IGuideCondition,
				Value = _iguidecondition
			};
		}

		// Token: 0x06018DD2 RID: 101842 RVA: 0x0038B63C File Offset: 0x0038983C
		public IEnterDungeonConditionT AsIEnterDungeonCondition()
		{
			return this.As<IEnterDungeonConditionT>();
		}

		// Token: 0x06018DD3 RID: 101843 RVA: 0x0038B644 File Offset: 0x00389844
		public static IQuestCondition_UnionUnion FromIEnterDungeonCondition(IEnterDungeonConditionT _ienterdungeoncondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IEnterDungeonCondition,
				Value = _ienterdungeoncondition
			};
		}

		// Token: 0x06018DD4 RID: 101844 RVA: 0x0038B65A File Offset: 0x0038985A
		public ILeaveDungeonConditionT AsILeaveDungeonCondition()
		{
			return this.As<ILeaveDungeonConditionT>();
		}

		// Token: 0x06018DD5 RID: 101845 RVA: 0x0038B662 File Offset: 0x00389862
		public static IQuestCondition_UnionUnion FromILeaveDungeonCondition(ILeaveDungeonConditionT _ileavedungeoncondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ILeaveDungeonCondition,
				Value = _ileavedungeoncondition
			};
		}

		// Token: 0x06018DD6 RID: 101846 RVA: 0x0038B678 File Offset: 0x00389878
		public ICheckTargetBattleAttributeConditionT AsICheckTargetBattleAttributeCondition()
		{
			return this.As<ICheckTargetBattleAttributeConditionT>();
		}

		// Token: 0x06018DD7 RID: 101847 RVA: 0x0038B680 File Offset: 0x00389880
		public static IQuestCondition_UnionUnion FromICheckTargetBattleAttributeCondition(ICheckTargetBattleAttributeConditionT _ichecktargetbattleattributecondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICheckTargetBattleAttributeCondition,
				Value = _ichecktargetbattleattributecondition
			};
		}

		// Token: 0x06018DD8 RID: 101848 RVA: 0x0038B696 File Offset: 0x00389896
		public IWaitBattleConditionT AsIWaitBattleCondition()
		{
			return this.As<IWaitBattleConditionT>();
		}

		// Token: 0x06018DD9 RID: 101849 RVA: 0x0038B69E File Offset: 0x0038989E
		public static IQuestCondition_UnionUnion FromIWaitBattleCondition(IWaitBattleConditionT _iwaitbattlecondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IWaitBattleCondition,
				Value = _iwaitbattlecondition
			};
		}

		// Token: 0x06018DDA RID: 101850 RVA: 0x0038B6B4 File Offset: 0x003898B4
		public ICompareVarConditionInChildQuestT AsICompareVarConditionInChildQuest()
		{
			return this.As<ICompareVarConditionInChildQuestT>();
		}

		// Token: 0x06018DDB RID: 101851 RVA: 0x0038B6BC File Offset: 0x003898BC
		public static IQuestCondition_UnionUnion FromICompareVarConditionInChildQuest(ICompareVarConditionInChildQuestT _icomparevarconditioninchildquest)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICompareVarConditionInChildQuest,
				Value = _icomparevarconditioninchildquest
			};
		}

		// Token: 0x06018DDC RID: 101852 RVA: 0x0038B6D2 File Offset: 0x003898D2
		public ICompareActorVarT AsICompareActorVar()
		{
			return this.As<ICompareActorVarT>();
		}

		// Token: 0x06018DDD RID: 101853 RVA: 0x0038B6DA File Offset: 0x003898DA
		public static IQuestCondition_UnionUnion FromICompareActorVar(ICompareActorVarT _icompareactorvar)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICompareActorVar,
				Value = _icompareactorvar
			};
		}

		// Token: 0x06018DDE RID: 101854 RVA: 0x0038B6F0 File Offset: 0x003898F0
		public IReceiveTelecomChildQuestConditionT AsIReceiveTelecomChildQuestCondition()
		{
			return this.As<IReceiveTelecomChildQuestConditionT>();
		}

		// Token: 0x06018DDF RID: 101855 RVA: 0x0038B6F8 File Offset: 0x003898F8
		public static IQuestCondition_UnionUnion FromIReceiveTelecomChildQuestCondition(IReceiveTelecomChildQuestConditionT _ireceivetelecomchildquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IReceiveTelecomChildQuestCondition,
				Value = _ireceivetelecomchildquestcondition
			};
		}

		// Token: 0x06018DE0 RID: 101856 RVA: 0x0038B70E File Offset: 0x0038990E
		public IShowUiConditionT AsIShowUiCondition()
		{
			return this.As<IShowUiConditionT>();
		}

		// Token: 0x06018DE1 RID: 101857 RVA: 0x0038B716 File Offset: 0x00389916
		public static IQuestCondition_UnionUnion FromIShowUiCondition(IShowUiConditionT _ishowuicondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IShowUiCondition,
				Value = _ishowuicondition
			};
		}

		// Token: 0x06018DE2 RID: 101858 RVA: 0x0038B72C File Offset: 0x0038992C
		public ITakePhotoConditionT AsITakePhotoCondition()
		{
			return this.As<ITakePhotoConditionT>();
		}

		// Token: 0x06018DE3 RID: 101859 RVA: 0x0038B734 File Offset: 0x00389934
		public static IQuestCondition_UnionUnion FromITakePhotoCondition(ITakePhotoConditionT _itakephotocondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ITakePhotoCondition,
				Value = _itakephotocondition
			};
		}

		// Token: 0x06018DE4 RID: 101860 RVA: 0x0038B74A File Offset: 0x0038994A
		public ITakePhoto2ConditionT AsITakePhoto2Condition()
		{
			return this.As<ITakePhoto2ConditionT>();
		}

		// Token: 0x06018DE5 RID: 101861 RVA: 0x0038B752 File Offset: 0x00389952
		public static IQuestCondition_UnionUnion FromITakePhoto2Condition(ITakePhoto2ConditionT _itakephoto2condition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ITakePhoto2Condition,
				Value = _itakephoto2condition
			};
		}

		// Token: 0x06018DE6 RID: 101862 RVA: 0x0038B768 File Offset: 0x00389968
		public IVisionSystemQuestConditionT AsIVisionSystemQuestCondition()
		{
			return this.As<IVisionSystemQuestConditionT>();
		}

		// Token: 0x06018DE7 RID: 101863 RVA: 0x0038B770 File Offset: 0x00389970
		public static IQuestCondition_UnionUnion FromIVisionSystemQuestCondition(IVisionSystemQuestConditionT _ivisionsystemquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IVisionSystemQuestCondition,
				Value = _ivisionsystemquestcondition
			};
		}

		// Token: 0x06018DE8 RID: 101864 RVA: 0x0038B786 File Offset: 0x00389986
		public IParallaxAlignQuestConditionT AsIParallaxAlignQuestCondition()
		{
			return this.As<IParallaxAlignQuestConditionT>();
		}

		// Token: 0x06018DE9 RID: 101865 RVA: 0x0038B78E File Offset: 0x0038998E
		public static IQuestCondition_UnionUnion FromIParallaxAlignQuestCondition(IParallaxAlignQuestConditionT _iparallaxalignquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IParallaxAlignQuestCondition,
				Value = _iparallaxalignquestcondition
			};
		}

		// Token: 0x06018DEA RID: 101866 RVA: 0x0038B7A4 File Offset: 0x003899A4
		public ICheckConditionGroupQuestConditionT AsICheckConditionGroupQuestCondition()
		{
			return this.As<ICheckConditionGroupQuestConditionT>();
		}

		// Token: 0x06018DEB RID: 101867 RVA: 0x0038B7AC File Offset: 0x003899AC
		public static IQuestCondition_UnionUnion FromICheckConditionGroupQuestCondition(ICheckConditionGroupQuestConditionT _icheckconditiongroupquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICheckConditionGroupQuestCondition,
				Value = _icheckconditiongroupquestcondition
			};
		}

		// Token: 0x06018DEC RID: 101868 RVA: 0x0038B7C2 File Offset: 0x003899C2
		public ICheckClientConditionGroupQuestConditionT AsICheckClientConditionGroupQuestCondition()
		{
			return this.As<ICheckClientConditionGroupQuestConditionT>();
		}

		// Token: 0x06018DED RID: 101869 RVA: 0x0038B7CA File Offset: 0x003899CA
		public static IQuestCondition_UnionUnion FromICheckClientConditionGroupQuestCondition(ICheckClientConditionGroupQuestConditionT _icheckclientconditiongroupquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICheckClientConditionGroupQuestCondition,
				Value = _icheckclientconditiongroupquestcondition
			};
		}

		// Token: 0x06018DEE RID: 101870 RVA: 0x0038B7E0 File Offset: 0x003899E0
		public ICheckActivityStateConditionT AsICheckActivityStateCondition()
		{
			return this.As<ICheckActivityStateConditionT>();
		}

		// Token: 0x06018DEF RID: 101871 RVA: 0x0038B7E8 File Offset: 0x003899E8
		public static IQuestCondition_UnionUnion FromICheckActivityStateCondition(ICheckActivityStateConditionT _icheckactivitystatecondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICheckActivityStateCondition,
				Value = _icheckactivitystatecondition
			};
		}

		// Token: 0x06018DF0 RID: 101872 RVA: 0x0038B7FE File Offset: 0x003899FE
		public ICheckPlayerInputConditionT AsICheckPlayerInputCondition()
		{
			return this.As<ICheckPlayerInputConditionT>();
		}

		// Token: 0x06018DF1 RID: 101873 RVA: 0x0038B806 File Offset: 0x00389A06
		public static IQuestCondition_UnionUnion FromICheckPlayerInputCondition(ICheckPlayerInputConditionT _icheckplayerinputcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICheckPlayerInputCondition,
				Value = _icheckplayerinputcondition
			};
		}

		// Token: 0x06018DF2 RID: 101874 RVA: 0x0038B81C File Offset: 0x00389A1C
		public IAwakeAndLoadEntityConditionT AsIAwakeAndLoadEntityCondition()
		{
			return this.As<IAwakeAndLoadEntityConditionT>();
		}

		// Token: 0x06018DF3 RID: 101875 RVA: 0x0038B824 File Offset: 0x00389A24
		public static IQuestCondition_UnionUnion FromIAwakeAndLoadEntityCondition(IAwakeAndLoadEntityConditionT _iawakeandloadentitycondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IAwakeAndLoadEntityCondition,
				Value = _iawakeandloadentitycondition
			};
		}

		// Token: 0x06018DF4 RID: 101876 RVA: 0x0038B83A File Offset: 0x00389A3A
		public IWalkingPatternConditionT AsIWalkingPatternCondition()
		{
			return this.As<IWalkingPatternConditionT>();
		}

		// Token: 0x06018DF5 RID: 101877 RVA: 0x0038B842 File Offset: 0x00389A42
		public static IQuestCondition_UnionUnion FromIWalkingPatternCondition(IWalkingPatternConditionT _iwalkingpatterncondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IWalkingPatternCondition,
				Value = _iwalkingpatterncondition
			};
		}

		// Token: 0x06018DF6 RID: 101878 RVA: 0x0038B858 File Offset: 0x00389A58
		public IFinishBvbChallengeT AsIFinishBvbChallenge()
		{
			return this.As<IFinishBvbChallengeT>();
		}

		// Token: 0x06018DF7 RID: 101879 RVA: 0x0038B860 File Offset: 0x00389A60
		public static IQuestCondition_UnionUnion FromIFinishBvbChallenge(IFinishBvbChallengeT _ifinishbvbchallenge)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishBvbChallenge,
				Value = _ifinishbvbchallenge
			};
		}

		// Token: 0x06018DF8 RID: 101880 RVA: 0x0038B876 File Offset: 0x00389A76
		public IProgramSpecialProcessT AsIProgramSpecialProcess()
		{
			return this.As<IProgramSpecialProcessT>();
		}

		// Token: 0x06018DF9 RID: 101881 RVA: 0x0038B87E File Offset: 0x00389A7E
		public static IQuestCondition_UnionUnion FromIProgramSpecialProcess(IProgramSpecialProcessT _iprogramspecialprocess)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IProgramSpecialProcess,
				Value = _iprogramspecialprocess
			};
		}

		// Token: 0x06018DFA RID: 101882 RVA: 0x0038B894 File Offset: 0x00389A94
		public IPlaybackShowTimelineQuestConditionT AsIPlaybackShowTimelineQuestCondition()
		{
			return this.As<IPlaybackShowTimelineQuestConditionT>();
		}

		// Token: 0x06018DFB RID: 101883 RVA: 0x0038B89C File Offset: 0x00389A9C
		public static IQuestCondition_UnionUnion FromIPlaybackShowTimelineQuestCondition(IPlaybackShowTimelineQuestConditionT _iplaybackshowtimelinequestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IPlaybackShowTimelineQuestCondition,
				Value = _iplaybackshowtimelinequestcondition
			};
		}

		// Token: 0x06018DFC RID: 101884 RVA: 0x0038B8B2 File Offset: 0x00389AB2
		public IWaitUntilLevelSequenceReachMarkT AsIWaitUntilLevelSequenceReachMark()
		{
			return this.As<IWaitUntilLevelSequenceReachMarkT>();
		}

		// Token: 0x06018DFD RID: 101885 RVA: 0x0038B8BA File Offset: 0x00389ABA
		public static IQuestCondition_UnionUnion FromIWaitUntilLevelSequenceReachMark(IWaitUntilLevelSequenceReachMarkT _iwaituntillevelsequencereachmark)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IWaitUntilLevelSequenceReachMark,
				Value = _iwaituntillevelsequencereachmark
			};
		}

		// Token: 0x06018DFE RID: 101886 RVA: 0x0038B8D0 File Offset: 0x00389AD0
		public IFinishTrapDefenseConditionT AsIFinishTrapDefenseCondition()
		{
			return this.As<IFinishTrapDefenseConditionT>();
		}

		// Token: 0x06018DFF RID: 101887 RVA: 0x0038B8D8 File Offset: 0x00389AD8
		public static IQuestCondition_UnionUnion FromIFinishTrapDefenseCondition(IFinishTrapDefenseConditionT _ifinishtrapdefensecondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishTrapDefenseCondition,
				Value = _ifinishtrapdefensecondition
			};
		}

		// Token: 0x06018E00 RID: 101888 RVA: 0x0038B8EE File Offset: 0x00389AEE
		public ICheckTrapDefenseEventConditionT AsICheckTrapDefenseEventCondition()
		{
			return this.As<ICheckTrapDefenseEventConditionT>();
		}

		// Token: 0x06018E01 RID: 101889 RVA: 0x0038B8F6 File Offset: 0x00389AF6
		public static IQuestCondition_UnionUnion FromICheckTrapDefenseEventCondition(ICheckTrapDefenseEventConditionT _ichecktrapdefenseeventcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICheckTrapDefenseEventCondition,
				Value = _ichecktrapdefenseeventcondition
			};
		}

		// Token: 0x06018E02 RID: 101890 RVA: 0x0038B90C File Offset: 0x00389B0C
		public IFinishSurvivorsRougeConditionT AsIFinishSurvivorsRougeCondition()
		{
			return this.As<IFinishSurvivorsRougeConditionT>();
		}

		// Token: 0x06018E03 RID: 101891 RVA: 0x0038B914 File Offset: 0x00389B14
		public static IQuestCondition_UnionUnion FromIFinishSurvivorsRougeCondition(IFinishSurvivorsRougeConditionT _ifinishsurvivorsrougecondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishSurvivorsRougeCondition,
				Value = _ifinishsurvivorsrougecondition
			};
		}

		// Token: 0x06018E04 RID: 101892 RVA: 0x0038B92A File Offset: 0x00389B2A
		public IFinishKurotatoConditionT AsIFinishKurotatoCondition()
		{
			return this.As<IFinishKurotatoConditionT>();
		}

		// Token: 0x06018E05 RID: 101893 RVA: 0x0038B932 File Offset: 0x00389B32
		public static IQuestCondition_UnionUnion FromIFinishKurotatoCondition(IFinishKurotatoConditionT _ifinishkurotatocondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishKurotatoCondition,
				Value = _ifinishkurotatocondition
			};
		}

		// Token: 0x06018E06 RID: 101894 RVA: 0x0038B948 File Offset: 0x00389B48
		public IFinishRoleTowerConditionT AsIFinishRoleTowerCondition()
		{
			return this.As<IFinishRoleTowerConditionT>();
		}

		// Token: 0x06018E07 RID: 101895 RVA: 0x0038B950 File Offset: 0x00389B50
		public static IQuestCondition_UnionUnion FromIFinishRoleTowerCondition(IFinishRoleTowerConditionT _ifinishroletowercondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishRoleTowerCondition,
				Value = _ifinishroletowercondition
			};
		}

		// Token: 0x06018E08 RID: 101896 RVA: 0x0038B966 File Offset: 0x00389B66
		public IFinishRhythmSpaceshipConditionT AsIFinishRhythmSpaceshipCondition()
		{
			return this.As<IFinishRhythmSpaceshipConditionT>();
		}

		// Token: 0x06018E09 RID: 101897 RVA: 0x0038B96E File Offset: 0x00389B6E
		public static IQuestCondition_UnionUnion FromIFinishRhythmSpaceshipCondition(IFinishRhythmSpaceshipConditionT _ifinishrhythmspaceshipcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishRhythmSpaceshipCondition,
				Value = _ifinishrhythmspaceshipcondition
			};
		}

		// Token: 0x06018E0A RID: 101898 RVA: 0x0038B984 File Offset: 0x00389B84
		public IFinishFlipperConditionT AsIFinishFlipperCondition()
		{
			return this.As<IFinishFlipperConditionT>();
		}

		// Token: 0x06018E0B RID: 101899 RVA: 0x0038B98C File Offset: 0x00389B8C
		public static IQuestCondition_UnionUnion FromIFinishFlipperCondition(IFinishFlipperConditionT _ifinishflippercondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishFlipperCondition,
				Value = _ifinishflippercondition
			};
		}

		// Token: 0x06018E0C RID: 101900 RVA: 0x0038B9A2 File Offset: 0x00389BA2
		public ITimeScaledPhotographT AsITimeScaledPhotograph()
		{
			return this.As<ITimeScaledPhotographT>();
		}

		// Token: 0x06018E0D RID: 101901 RVA: 0x0038B9AA File Offset: 0x00389BAA
		public static IQuestCondition_UnionUnion FromITimeScaledPhotograph(ITimeScaledPhotographT _itimescaledphotograph)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ITimeScaledPhotograph,
				Value = _itimescaledphotograph
			};
		}

		// Token: 0x06018E0E RID: 101902 RVA: 0x0038B9C0 File Offset: 0x00389BC0
		public IFinishRollBlockT AsIFinishRollBlock()
		{
			return this.As<IFinishRollBlockT>();
		}

		// Token: 0x06018E0F RID: 101903 RVA: 0x0038B9C8 File Offset: 0x00389BC8
		public static IQuestCondition_UnionUnion FromIFinishRollBlock(IFinishRollBlockT _ifinishrollblock)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishRollBlock,
				Value = _ifinishrollblock
			};
		}

		// Token: 0x06018E10 RID: 101904 RVA: 0x0038B9DE File Offset: 0x00389BDE
		public IAtomicProcessT AsIAtomicProcess()
		{
			return this.As<IAtomicProcessT>();
		}

		// Token: 0x06018E11 RID: 101905 RVA: 0x0038B9E6 File Offset: 0x00389BE6
		public static IQuestCondition_UnionUnion FromIAtomicProcess(IAtomicProcessT _iatomicprocess)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IAtomicProcess,
				Value = _iatomicprocess
			};
		}

		// Token: 0x06018E12 RID: 101906 RVA: 0x0038B9FC File Offset: 0x00389BFC
		public IUseWeatherSwitchConditionT AsIUseWeatherSwitchCondition()
		{
			return this.As<IUseWeatherSwitchConditionT>();
		}

		// Token: 0x06018E13 RID: 101907 RVA: 0x0038BA04 File Offset: 0x00389C04
		public static IQuestCondition_UnionUnion FromIUseWeatherSwitchCondition(IUseWeatherSwitchConditionT _iuseweatherswitchcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IUseWeatherSwitchCondition,
				Value = _iuseweatherswitchcondition
			};
		}

		// Token: 0x06018E14 RID: 101908 RVA: 0x0038BA1A File Offset: 0x00389C1A
		public ICheckSpringFestivalGameplayCompletedT AsICheckSpringFestivalGameplayCompleted()
		{
			return this.As<ICheckSpringFestivalGameplayCompletedT>();
		}

		// Token: 0x06018E15 RID: 101909 RVA: 0x0038BA22 File Offset: 0x00389C22
		public static IQuestCondition_UnionUnion FromICheckSpringFestivalGameplayCompleted(ICheckSpringFestivalGameplayCompletedT _icheckspringfestivalgameplaycompleted)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICheckSpringFestivalGameplayCompleted,
				Value = _icheckspringfestivalgameplaycompleted
			};
		}

		// Token: 0x06018E16 RID: 101910 RVA: 0x0038BA38 File Offset: 0x00389C38
		public IListenToEventT AsIListenToEvent()
		{
			return this.As<IListenToEventT>();
		}

		// Token: 0x06018E17 RID: 101911 RVA: 0x0038BA40 File Offset: 0x00389C40
		public static IQuestCondition_UnionUnion FromIListenToEvent(IListenToEventT _ilistentoevent)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IListenToEvent,
				Value = _ilistentoevent
			};
		}

		// Token: 0x06018E18 RID: 101912 RVA: 0x0038BA56 File Offset: 0x00389C56
		public IParkourQuestConditionT AsIParkourQuestCondition()
		{
			return this.As<IParkourQuestConditionT>();
		}

		// Token: 0x06018E19 RID: 101913 RVA: 0x0038BA5E File Offset: 0x00389C5E
		public static IQuestCondition_UnionUnion FromIParkourQuestCondition(IParkourQuestConditionT _iparkourquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IParkourQuestCondition,
				Value = _iparkourquestcondition
			};
		}

		// Token: 0x06018E1A RID: 101914 RVA: 0x0038BA74 File Offset: 0x00389C74
		public ITimerQuestConditionT AsITimerQuestCondition()
		{
			return this.As<ITimerQuestConditionT>();
		}

		// Token: 0x06018E1B RID: 101915 RVA: 0x0038BA7C File Offset: 0x00389C7C
		public static IQuestCondition_UnionUnion FromITimerQuestCondition(ITimerQuestConditionT _itimerquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ITimerQuestCondition,
				Value = _itimerquestcondition
			};
		}

		// Token: 0x06018E1C RID: 101916 RVA: 0x0038BA92 File Offset: 0x00389C92
		public IMonsterCreatorQuestConditionT AsIMonsterCreatorQuestCondition()
		{
			return this.As<IMonsterCreatorQuestConditionT>();
		}

		// Token: 0x06018E1D RID: 101917 RVA: 0x0038BA9A File Offset: 0x00389C9A
		public static IQuestCondition_UnionUnion FromIMonsterCreatorQuestCondition(IMonsterCreatorQuestConditionT _imonstercreatorquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IMonsterCreatorQuestCondition,
				Value = _imonstercreatorquestcondition
			};
		}

		// Token: 0x06018E1E RID: 101918 RVA: 0x0038BAB0 File Offset: 0x00389CB0
		public IFinishTetrisT AsIFinishTetris()
		{
			return this.As<IFinishTetrisT>();
		}

		// Token: 0x06018E1F RID: 101919 RVA: 0x0038BAB8 File Offset: 0x00389CB8
		public static IQuestCondition_UnionUnion FromIFinishTetris(IFinishTetrisT _ifinishtetris)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishTetris,
				Value = _ifinishtetris
			};
		}

		// Token: 0x06018E20 RID: 101920 RVA: 0x0038BACE File Offset: 0x00389CCE
		public IFinishArcadeGameplayT AsIFinishArcadeGameplay()
		{
			return this.As<IFinishArcadeGameplayT>();
		}

		// Token: 0x06018E21 RID: 101921 RVA: 0x0038BAD6 File Offset: 0x00389CD6
		public static IQuestCondition_UnionUnion FromIFinishArcadeGameplay(IFinishArcadeGameplayT _ifinisharcadegameplay)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishArcadeGameplay,
				Value = _ifinisharcadegameplay
			};
		}

		// Token: 0x06018E22 RID: 101922 RVA: 0x0038BAEC File Offset: 0x00389CEC
		public IFinishKuroSimpleCombatKillMonsterT AsIFinishKuroSimpleCombatKillMonster()
		{
			return this.As<IFinishKuroSimpleCombatKillMonsterT>();
		}

		// Token: 0x06018E23 RID: 101923 RVA: 0x0038BAF4 File Offset: 0x00389CF4
		public static IQuestCondition_UnionUnion FromIFinishKuroSimpleCombatKillMonster(IFinishKuroSimpleCombatKillMonsterT _ifinishkurosimplecombatkillmonster)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishKuroSimpleCombatKillMonster,
				Value = _ifinishkurosimplecombatkillmonster
			};
		}

		// Token: 0x06018E24 RID: 101924 RVA: 0x0038BB0A File Offset: 0x00389D0A
		public ICrossSceneSyncKillMonsterT AsICrossSceneSyncKillMonster()
		{
			return this.As<ICrossSceneSyncKillMonsterT>();
		}

		// Token: 0x06018E25 RID: 101925 RVA: 0x0038BB12 File Offset: 0x00389D12
		public static IQuestCondition_UnionUnion FromICrossSceneSyncKillMonster(ICrossSceneSyncKillMonsterT _icrossscenesynckillmonster)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICrossSceneSyncKillMonster,
				Value = _icrossscenesynckillmonster
			};
		}

		// Token: 0x06018E26 RID: 101926 RVA: 0x0038BB28 File Offset: 0x00389D28
		public IFinishJellyfishReturnConditionT AsIFinishJellyfishReturnCondition()
		{
			return this.As<IFinishJellyfishReturnConditionT>();
		}

		// Token: 0x06018E27 RID: 101927 RVA: 0x0038BB30 File Offset: 0x00389D30
		public static IQuestCondition_UnionUnion FromIFinishJellyfishReturnCondition(IFinishJellyfishReturnConditionT _ifinishjellyfishreturncondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishJellyfishReturnCondition,
				Value = _ifinishjellyfishreturncondition
			};
		}

		// Token: 0x06018E28 RID: 101928 RVA: 0x0038BB48 File Offset: 0x00389D48
		public static int Pack(FlatBufferBuilder builder, IQuestCondition_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IQuestCondition_Union.IQuestCondition:
				return IQuestCondition.Pack(builder, _o.AsIQuestCondition()).Value;
			case IQuestCondition_Union.IInformationViewCheckCondition:
				return IInformationViewCheckCondition.Pack(builder, _o.AsIInformationViewCheckCondition()).Value;
			case IQuestCondition_Union.IUseItemCondition:
				return IUseItemCondition.Pack(builder, _o.AsIUseItemCondition()).Value;
			case IQuestCondition_Union.IGetItemQuestCondition:
				return IGetItemQuestCondition.Pack(builder, _o.AsIGetItemQuestCondition()).Value;
			case IQuestCondition_Union.ICheckEntityStateQuestCondition:
				return ICheckEntityStateQuestCondition.Pack(builder, _o.AsICheckEntityStateQuestCondition()).Value;
			case IQuestCondition_Union.ICheckLevelPlayQuestCondition:
				return ICheckLevelPlayQuestCondition.Pack(builder, _o.AsICheckLevelPlayQuestCondition()).Value;
			case IQuestCondition_Union.ICheckUiGameQuestCondition:
				return ICheckUiGameQuestCondition.Pack(builder, _o.AsICheckUiGameQuestCondition()).Value;
			case IQuestCondition_Union.IReadPhoneMessageQuestCondition:
				return IReadPhoneMessageQuestCondition.Pack(builder, _o.AsIReadPhoneMessageQuestCondition()).Value;
			case IQuestCondition_Union.IUseSkillQuestCondition:
				return IUseSkillQuestCondition.Pack(builder, _o.AsIUseSkillQuestCondition()).Value;
			case IQuestCondition_Union.IGetSkillQuestCondition:
				return IGetSkillQuestCondition.Pack(builder, _o.AsIGetSkillQuestCondition()).Value;
			case IQuestCondition_Union.IPlayFlowQuestCondition:
				return IPlayFlowQuestCondition.Pack(builder, _o.AsIPlayFlowQuestCondition()).Value;
			case IQuestCondition_Union.IDoInteractQuestCondition:
				return IDoInteractQuestCondition.Pack(builder, _o.AsIDoInteractQuestCondition()).Value;
			case IQuestCondition_Union.IReachAreaQuestCondition:
				return IReachAreaQuestCondition.Pack(builder, _o.AsIReachAreaQuestCondition()).Value;
			case IQuestCondition_Union.IKillChildQuestCondition:
				return IKillChildQuestCondition.Pack(builder, _o.AsIKillChildQuestCondition()).Value;
			case IQuestCondition_Union.IDetectCombatStateCondition:
				return IDetectCombatStateCondition.Pack(builder, _o.AsIDetectCombatStateCondition()).Value;
			case IQuestCondition_Union.IDetectCombatState2Condition:
				return IDetectCombatState2Condition.Pack(builder, _o.AsIDetectCombatState2Condition()).Value;
			case IQuestCondition_Union.IHandInItemsCondition:
				return IHandInItemsCondition.Pack(builder, _o.AsIHandInItemsCondition()).Value;
			case IQuestCondition_Union.INewHandInItemsCondition:
				return INewHandInItemsCondition.Pack(builder, _o.AsINewHandInItemsCondition()).Value;
			case IQuestCondition_Union.IFinishDungeonQuestCondition:
				return IFinishDungeonQuestCondition.Pack(builder, _o.AsIFinishDungeonQuestCondition()).Value;
			case IQuestCondition_Union.IWaitTimeCondition:
				return IWaitTimeCondition.Pack(builder, _o.AsIWaitTimeCondition()).Value;
			case IQuestCondition_Union.IScheduleTimeCondition:
				return IScheduleTimeCondition.Pack(builder, _o.AsIScheduleTimeCondition()).Value;
			case IQuestCondition_Union.IReadMailCondition:
				return IReadMailCondition.Pack(builder, _o.AsIReadMailCondition()).Value;
			case IQuestCondition_Union.IGuideCondition:
				return IGuideCondition.Pack(builder, _o.AsIGuideCondition()).Value;
			case IQuestCondition_Union.IEnterDungeonCondition:
				return IEnterDungeonCondition.Pack(builder, _o.AsIEnterDungeonCondition()).Value;
			case IQuestCondition_Union.ILeaveDungeonCondition:
				return ILeaveDungeonCondition.Pack(builder, _o.AsILeaveDungeonCondition()).Value;
			case IQuestCondition_Union.ICheckTargetBattleAttributeCondition:
				return ICheckTargetBattleAttributeCondition.Pack(builder, _o.AsICheckTargetBattleAttributeCondition()).Value;
			case IQuestCondition_Union.IWaitBattleCondition:
				return IWaitBattleCondition.Pack(builder, _o.AsIWaitBattleCondition()).Value;
			case IQuestCondition_Union.ICompareVarConditionInChildQuest:
				return ICompareVarConditionInChildQuest.Pack(builder, _o.AsICompareVarConditionInChildQuest()).Value;
			case IQuestCondition_Union.ICompareActorVar:
				return ICompareActorVar.Pack(builder, _o.AsICompareActorVar()).Value;
			case IQuestCondition_Union.IReceiveTelecomChildQuestCondition:
				return IReceiveTelecomChildQuestCondition.Pack(builder, _o.AsIReceiveTelecomChildQuestCondition()).Value;
			case IQuestCondition_Union.IShowUiCondition:
				return IShowUiCondition.Pack(builder, _o.AsIShowUiCondition()).Value;
			case IQuestCondition_Union.ITakePhotoCondition:
				return ITakePhotoCondition.Pack(builder, _o.AsITakePhotoCondition()).Value;
			case IQuestCondition_Union.ITakePhoto2Condition:
				return ITakePhoto2Condition.Pack(builder, _o.AsITakePhoto2Condition()).Value;
			case IQuestCondition_Union.IVisionSystemQuestCondition:
				return IVisionSystemQuestCondition.Pack(builder, _o.AsIVisionSystemQuestCondition()).Value;
			case IQuestCondition_Union.IParallaxAlignQuestCondition:
				return IParallaxAlignQuestCondition.Pack(builder, _o.AsIParallaxAlignQuestCondition()).Value;
			case IQuestCondition_Union.ICheckConditionGroupQuestCondition:
				return ICheckConditionGroupQuestCondition.Pack(builder, _o.AsICheckConditionGroupQuestCondition()).Value;
			case IQuestCondition_Union.ICheckClientConditionGroupQuestCondition:
				return ICheckClientConditionGroupQuestCondition.Pack(builder, _o.AsICheckClientConditionGroupQuestCondition()).Value;
			case IQuestCondition_Union.ICheckActivityStateCondition:
				return ICheckActivityStateCondition.Pack(builder, _o.AsICheckActivityStateCondition()).Value;
			case IQuestCondition_Union.ICheckPlayerInputCondition:
				return ICheckPlayerInputCondition.Pack(builder, _o.AsICheckPlayerInputCondition()).Value;
			case IQuestCondition_Union.IAwakeAndLoadEntityCondition:
				return IAwakeAndLoadEntityCondition.Pack(builder, _o.AsIAwakeAndLoadEntityCondition()).Value;
			case IQuestCondition_Union.IWalkingPatternCondition:
				return IWalkingPatternCondition.Pack(builder, _o.AsIWalkingPatternCondition()).Value;
			case IQuestCondition_Union.IFinishBvbChallenge:
				return IFinishBvbChallenge.Pack(builder, _o.AsIFinishBvbChallenge()).Value;
			case IQuestCondition_Union.IProgramSpecialProcess:
				return IProgramSpecialProcess.Pack(builder, _o.AsIProgramSpecialProcess()).Value;
			case IQuestCondition_Union.IPlaybackShowTimelineQuestCondition:
				return IPlaybackShowTimelineQuestCondition.Pack(builder, _o.AsIPlaybackShowTimelineQuestCondition()).Value;
			case IQuestCondition_Union.IWaitUntilLevelSequenceReachMark:
				return IWaitUntilLevelSequenceReachMark.Pack(builder, _o.AsIWaitUntilLevelSequenceReachMark()).Value;
			case IQuestCondition_Union.IFinishTrapDefenseCondition:
				return IFinishTrapDefenseCondition.Pack(builder, _o.AsIFinishTrapDefenseCondition()).Value;
			case IQuestCondition_Union.ICheckTrapDefenseEventCondition:
				return ICheckTrapDefenseEventCondition.Pack(builder, _o.AsICheckTrapDefenseEventCondition()).Value;
			case IQuestCondition_Union.IFinishSurvivorsRougeCondition:
				return IFinishSurvivorsRougeCondition.Pack(builder, _o.AsIFinishSurvivorsRougeCondition()).Value;
			case IQuestCondition_Union.IFinishKurotatoCondition:
				return IFinishKurotatoCondition.Pack(builder, _o.AsIFinishKurotatoCondition()).Value;
			case IQuestCondition_Union.IFinishRoleTowerCondition:
				return IFinishRoleTowerCondition.Pack(builder, _o.AsIFinishRoleTowerCondition()).Value;
			case IQuestCondition_Union.IFinishRhythmSpaceshipCondition:
				return IFinishRhythmSpaceshipCondition.Pack(builder, _o.AsIFinishRhythmSpaceshipCondition()).Value;
			case IQuestCondition_Union.IFinishFlipperCondition:
				return IFinishFlipperCondition.Pack(builder, _o.AsIFinishFlipperCondition()).Value;
			case IQuestCondition_Union.ITimeScaledPhotograph:
				return ITimeScaledPhotograph.Pack(builder, _o.AsITimeScaledPhotograph()).Value;
			case IQuestCondition_Union.IFinishRollBlock:
				return IFinishRollBlock.Pack(builder, _o.AsIFinishRollBlock()).Value;
			case IQuestCondition_Union.IAtomicProcess:
				return IAtomicProcess.Pack(builder, _o.AsIAtomicProcess()).Value;
			case IQuestCondition_Union.IUseWeatherSwitchCondition:
				return IUseWeatherSwitchCondition.Pack(builder, _o.AsIUseWeatherSwitchCondition()).Value;
			case IQuestCondition_Union.ICheckSpringFestivalGameplayCompleted:
				return ICheckSpringFestivalGameplayCompleted.Pack(builder, _o.AsICheckSpringFestivalGameplayCompleted()).Value;
			case IQuestCondition_Union.IListenToEvent:
				return IListenToEvent.Pack(builder, _o.AsIListenToEvent()).Value;
			case IQuestCondition_Union.IParkourQuestCondition:
				return IParkourQuestCondition.Pack(builder, _o.AsIParkourQuestCondition()).Value;
			case IQuestCondition_Union.ITimerQuestCondition:
				return ITimerQuestCondition.Pack(builder, _o.AsITimerQuestCondition()).Value;
			case IQuestCondition_Union.IMonsterCreatorQuestCondition:
				return IMonsterCreatorQuestCondition.Pack(builder, _o.AsIMonsterCreatorQuestCondition()).Value;
			case IQuestCondition_Union.IFinishTetris:
				return IFinishTetris.Pack(builder, _o.AsIFinishTetris()).Value;
			case IQuestCondition_Union.IFinishArcadeGameplay:
				return IFinishArcadeGameplay.Pack(builder, _o.AsIFinishArcadeGameplay()).Value;
			case IQuestCondition_Union.IFinishKuroSimpleCombatKillMonster:
				return IFinishKuroSimpleCombatKillMonster.Pack(builder, _o.AsIFinishKuroSimpleCombatKillMonster()).Value;
			case IQuestCondition_Union.ICrossSceneSyncKillMonster:
				return ICrossSceneSyncKillMonster.Pack(builder, _o.AsICrossSceneSyncKillMonster()).Value;
			case IQuestCondition_Union.IFinishJellyfishReturnCondition:
				return IFinishJellyfishReturnCondition.Pack(builder, _o.AsIFinishJellyfishReturnCondition()).Value;
			default:
				return 0;
			}
		}
	}
}

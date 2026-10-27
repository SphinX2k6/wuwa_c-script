using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FD2 RID: 16338
	public class IQuestCondition_UnionUnion
	{
		// Token: 0x17007271 RID: 29297
		// (get) Token: 0x0601770B RID: 96011 RVA: 0x00361620 File Offset: 0x0035F820
		// (set) Token: 0x0601770C RID: 96012 RVA: 0x00361628 File Offset: 0x0035F828
		public IQuestCondition_Union Type { get; set; }

		// Token: 0x17007272 RID: 29298
		// (get) Token: 0x0601770D RID: 96013 RVA: 0x00361631 File Offset: 0x0035F831
		// (set) Token: 0x0601770E RID: 96014 RVA: 0x00361639 File Offset: 0x0035F839
		public object Value { get; set; }

		// Token: 0x0601770F RID: 96015 RVA: 0x00361642 File Offset: 0x0035F842
		public IQuestCondition_UnionUnion()
		{
			this.Type = IQuestCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06017710 RID: 96016 RVA: 0x00361658 File Offset: 0x0035F858
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06017711 RID: 96017 RVA: 0x0036166A File Offset: 0x0035F86A
		public IQuestConditionT AsIQuestCondition()
		{
			return this.As<IQuestConditionT>();
		}

		// Token: 0x06017712 RID: 96018 RVA: 0x00361672 File Offset: 0x0035F872
		public static IQuestCondition_UnionUnion FromIQuestCondition(IQuestConditionT _iquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IQuestCondition,
				Value = _iquestcondition
			};
		}

		// Token: 0x06017713 RID: 96019 RVA: 0x00361687 File Offset: 0x0035F887
		public IInformationViewCheckConditionT AsIInformationViewCheckCondition()
		{
			return this.As<IInformationViewCheckConditionT>();
		}

		// Token: 0x06017714 RID: 96020 RVA: 0x0036168F File Offset: 0x0035F88F
		public static IQuestCondition_UnionUnion FromIInformationViewCheckCondition(IInformationViewCheckConditionT _iinformationviewcheckcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IInformationViewCheckCondition,
				Value = _iinformationviewcheckcondition
			};
		}

		// Token: 0x06017715 RID: 96021 RVA: 0x003616A4 File Offset: 0x0035F8A4
		public IUseItemConditionT AsIUseItemCondition()
		{
			return this.As<IUseItemConditionT>();
		}

		// Token: 0x06017716 RID: 96022 RVA: 0x003616AC File Offset: 0x0035F8AC
		public static IQuestCondition_UnionUnion FromIUseItemCondition(IUseItemConditionT _iuseitemcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IUseItemCondition,
				Value = _iuseitemcondition
			};
		}

		// Token: 0x06017717 RID: 96023 RVA: 0x003616C1 File Offset: 0x0035F8C1
		public IGetItemQuestConditionT AsIGetItemQuestCondition()
		{
			return this.As<IGetItemQuestConditionT>();
		}

		// Token: 0x06017718 RID: 96024 RVA: 0x003616C9 File Offset: 0x0035F8C9
		public static IQuestCondition_UnionUnion FromIGetItemQuestCondition(IGetItemQuestConditionT _igetitemquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IGetItemQuestCondition,
				Value = _igetitemquestcondition
			};
		}

		// Token: 0x06017719 RID: 96025 RVA: 0x003616DE File Offset: 0x0035F8DE
		public ICheckEntityStateQuestConditionT AsICheckEntityStateQuestCondition()
		{
			return this.As<ICheckEntityStateQuestConditionT>();
		}

		// Token: 0x0601771A RID: 96026 RVA: 0x003616E6 File Offset: 0x0035F8E6
		public static IQuestCondition_UnionUnion FromICheckEntityStateQuestCondition(ICheckEntityStateQuestConditionT _icheckentitystatequestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICheckEntityStateQuestCondition,
				Value = _icheckentitystatequestcondition
			};
		}

		// Token: 0x0601771B RID: 96027 RVA: 0x003616FB File Offset: 0x0035F8FB
		public ICheckLevelPlayQuestConditionT AsICheckLevelPlayQuestCondition()
		{
			return this.As<ICheckLevelPlayQuestConditionT>();
		}

		// Token: 0x0601771C RID: 96028 RVA: 0x00361703 File Offset: 0x0035F903
		public static IQuestCondition_UnionUnion FromICheckLevelPlayQuestCondition(ICheckLevelPlayQuestConditionT _ichecklevelplayquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICheckLevelPlayQuestCondition,
				Value = _ichecklevelplayquestcondition
			};
		}

		// Token: 0x0601771D RID: 96029 RVA: 0x00361718 File Offset: 0x0035F918
		public ICheckUiGameQuestConditionT AsICheckUiGameQuestCondition()
		{
			return this.As<ICheckUiGameQuestConditionT>();
		}

		// Token: 0x0601771E RID: 96030 RVA: 0x00361720 File Offset: 0x0035F920
		public static IQuestCondition_UnionUnion FromICheckUiGameQuestCondition(ICheckUiGameQuestConditionT _icheckuigamequestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICheckUiGameQuestCondition,
				Value = _icheckuigamequestcondition
			};
		}

		// Token: 0x0601771F RID: 96031 RVA: 0x00361735 File Offset: 0x0035F935
		public IReadPhoneMessageQuestConditionT AsIReadPhoneMessageQuestCondition()
		{
			return this.As<IReadPhoneMessageQuestConditionT>();
		}

		// Token: 0x06017720 RID: 96032 RVA: 0x0036173D File Offset: 0x0035F93D
		public static IQuestCondition_UnionUnion FromIReadPhoneMessageQuestCondition(IReadPhoneMessageQuestConditionT _ireadphonemessagequestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IReadPhoneMessageQuestCondition,
				Value = _ireadphonemessagequestcondition
			};
		}

		// Token: 0x06017721 RID: 96033 RVA: 0x00361752 File Offset: 0x0035F952
		public IUseSkillQuestConditionT AsIUseSkillQuestCondition()
		{
			return this.As<IUseSkillQuestConditionT>();
		}

		// Token: 0x06017722 RID: 96034 RVA: 0x0036175A File Offset: 0x0035F95A
		public static IQuestCondition_UnionUnion FromIUseSkillQuestCondition(IUseSkillQuestConditionT _iuseskillquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IUseSkillQuestCondition,
				Value = _iuseskillquestcondition
			};
		}

		// Token: 0x06017723 RID: 96035 RVA: 0x00361770 File Offset: 0x0035F970
		public IGetSkillQuestConditionT AsIGetSkillQuestCondition()
		{
			return this.As<IGetSkillQuestConditionT>();
		}

		// Token: 0x06017724 RID: 96036 RVA: 0x00361778 File Offset: 0x0035F978
		public static IQuestCondition_UnionUnion FromIGetSkillQuestCondition(IGetSkillQuestConditionT _igetskillquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IGetSkillQuestCondition,
				Value = _igetskillquestcondition
			};
		}

		// Token: 0x06017725 RID: 96037 RVA: 0x0036178E File Offset: 0x0035F98E
		public IPlayFlowQuestConditionT AsIPlayFlowQuestCondition()
		{
			return this.As<IPlayFlowQuestConditionT>();
		}

		// Token: 0x06017726 RID: 96038 RVA: 0x00361796 File Offset: 0x0035F996
		public static IQuestCondition_UnionUnion FromIPlayFlowQuestCondition(IPlayFlowQuestConditionT _iplayflowquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IPlayFlowQuestCondition,
				Value = _iplayflowquestcondition
			};
		}

		// Token: 0x06017727 RID: 96039 RVA: 0x003617AC File Offset: 0x0035F9AC
		public IDoInteractQuestConditionT AsIDoInteractQuestCondition()
		{
			return this.As<IDoInteractQuestConditionT>();
		}

		// Token: 0x06017728 RID: 96040 RVA: 0x003617B4 File Offset: 0x0035F9B4
		public static IQuestCondition_UnionUnion FromIDoInteractQuestCondition(IDoInteractQuestConditionT _idointeractquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IDoInteractQuestCondition,
				Value = _idointeractquestcondition
			};
		}

		// Token: 0x06017729 RID: 96041 RVA: 0x003617CA File Offset: 0x0035F9CA
		public IReachAreaQuestConditionT AsIReachAreaQuestCondition()
		{
			return this.As<IReachAreaQuestConditionT>();
		}

		// Token: 0x0601772A RID: 96042 RVA: 0x003617D2 File Offset: 0x0035F9D2
		public static IQuestCondition_UnionUnion FromIReachAreaQuestCondition(IReachAreaQuestConditionT _ireachareaquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IReachAreaQuestCondition,
				Value = _ireachareaquestcondition
			};
		}

		// Token: 0x0601772B RID: 96043 RVA: 0x003617E8 File Offset: 0x0035F9E8
		public IKillChildQuestConditionT AsIKillChildQuestCondition()
		{
			return this.As<IKillChildQuestConditionT>();
		}

		// Token: 0x0601772C RID: 96044 RVA: 0x003617F0 File Offset: 0x0035F9F0
		public static IQuestCondition_UnionUnion FromIKillChildQuestCondition(IKillChildQuestConditionT _ikillchildquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IKillChildQuestCondition,
				Value = _ikillchildquestcondition
			};
		}

		// Token: 0x0601772D RID: 96045 RVA: 0x00361806 File Offset: 0x0035FA06
		public IDetectCombatStateConditionT AsIDetectCombatStateCondition()
		{
			return this.As<IDetectCombatStateConditionT>();
		}

		// Token: 0x0601772E RID: 96046 RVA: 0x0036180E File Offset: 0x0035FA0E
		public static IQuestCondition_UnionUnion FromIDetectCombatStateCondition(IDetectCombatStateConditionT _idetectcombatstatecondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IDetectCombatStateCondition,
				Value = _idetectcombatstatecondition
			};
		}

		// Token: 0x0601772F RID: 96047 RVA: 0x00361824 File Offset: 0x0035FA24
		public IDetectCombatState2ConditionT AsIDetectCombatState2Condition()
		{
			return this.As<IDetectCombatState2ConditionT>();
		}

		// Token: 0x06017730 RID: 96048 RVA: 0x0036182C File Offset: 0x0035FA2C
		public static IQuestCondition_UnionUnion FromIDetectCombatState2Condition(IDetectCombatState2ConditionT _idetectcombatstate2condition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IDetectCombatState2Condition,
				Value = _idetectcombatstate2condition
			};
		}

		// Token: 0x06017731 RID: 96049 RVA: 0x00361842 File Offset: 0x0035FA42
		public IHandInItemsConditionT AsIHandInItemsCondition()
		{
			return this.As<IHandInItemsConditionT>();
		}

		// Token: 0x06017732 RID: 96050 RVA: 0x0036184A File Offset: 0x0035FA4A
		public static IQuestCondition_UnionUnion FromIHandInItemsCondition(IHandInItemsConditionT _ihandinitemscondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IHandInItemsCondition,
				Value = _ihandinitemscondition
			};
		}

		// Token: 0x06017733 RID: 96051 RVA: 0x00361860 File Offset: 0x0035FA60
		public INewHandInItemsConditionT AsINewHandInItemsCondition()
		{
			return this.As<INewHandInItemsConditionT>();
		}

		// Token: 0x06017734 RID: 96052 RVA: 0x00361868 File Offset: 0x0035FA68
		public static IQuestCondition_UnionUnion FromINewHandInItemsCondition(INewHandInItemsConditionT _inewhandinitemscondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.INewHandInItemsCondition,
				Value = _inewhandinitemscondition
			};
		}

		// Token: 0x06017735 RID: 96053 RVA: 0x0036187E File Offset: 0x0035FA7E
		public IFinishDungeonQuestConditionT AsIFinishDungeonQuestCondition()
		{
			return this.As<IFinishDungeonQuestConditionT>();
		}

		// Token: 0x06017736 RID: 96054 RVA: 0x00361886 File Offset: 0x0035FA86
		public static IQuestCondition_UnionUnion FromIFinishDungeonQuestCondition(IFinishDungeonQuestConditionT _ifinishdungeonquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishDungeonQuestCondition,
				Value = _ifinishdungeonquestcondition
			};
		}

		// Token: 0x06017737 RID: 96055 RVA: 0x0036189C File Offset: 0x0035FA9C
		public IWaitTimeConditionT AsIWaitTimeCondition()
		{
			return this.As<IWaitTimeConditionT>();
		}

		// Token: 0x06017738 RID: 96056 RVA: 0x003618A4 File Offset: 0x0035FAA4
		public static IQuestCondition_UnionUnion FromIWaitTimeCondition(IWaitTimeConditionT _iwaittimecondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IWaitTimeCondition,
				Value = _iwaittimecondition
			};
		}

		// Token: 0x06017739 RID: 96057 RVA: 0x003618BA File Offset: 0x0035FABA
		public IScheduleTimeConditionT AsIScheduleTimeCondition()
		{
			return this.As<IScheduleTimeConditionT>();
		}

		// Token: 0x0601773A RID: 96058 RVA: 0x003618C2 File Offset: 0x0035FAC2
		public static IQuestCondition_UnionUnion FromIScheduleTimeCondition(IScheduleTimeConditionT _ischeduletimecondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IScheduleTimeCondition,
				Value = _ischeduletimecondition
			};
		}

		// Token: 0x0601773B RID: 96059 RVA: 0x003618D8 File Offset: 0x0035FAD8
		public IReadMailConditionT AsIReadMailCondition()
		{
			return this.As<IReadMailConditionT>();
		}

		// Token: 0x0601773C RID: 96060 RVA: 0x003618E0 File Offset: 0x0035FAE0
		public static IQuestCondition_UnionUnion FromIReadMailCondition(IReadMailConditionT _ireadmailcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IReadMailCondition,
				Value = _ireadmailcondition
			};
		}

		// Token: 0x0601773D RID: 96061 RVA: 0x003618F6 File Offset: 0x0035FAF6
		public IGuideConditionT AsIGuideCondition()
		{
			return this.As<IGuideConditionT>();
		}

		// Token: 0x0601773E RID: 96062 RVA: 0x003618FE File Offset: 0x0035FAFE
		public static IQuestCondition_UnionUnion FromIGuideCondition(IGuideConditionT _iguidecondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IGuideCondition,
				Value = _iguidecondition
			};
		}

		// Token: 0x0601773F RID: 96063 RVA: 0x00361914 File Offset: 0x0035FB14
		public IEnterDungeonConditionT AsIEnterDungeonCondition()
		{
			return this.As<IEnterDungeonConditionT>();
		}

		// Token: 0x06017740 RID: 96064 RVA: 0x0036191C File Offset: 0x0035FB1C
		public static IQuestCondition_UnionUnion FromIEnterDungeonCondition(IEnterDungeonConditionT _ienterdungeoncondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IEnterDungeonCondition,
				Value = _ienterdungeoncondition
			};
		}

		// Token: 0x06017741 RID: 96065 RVA: 0x00361932 File Offset: 0x0035FB32
		public ILeaveDungeonConditionT AsILeaveDungeonCondition()
		{
			return this.As<ILeaveDungeonConditionT>();
		}

		// Token: 0x06017742 RID: 96066 RVA: 0x0036193A File Offset: 0x0035FB3A
		public static IQuestCondition_UnionUnion FromILeaveDungeonCondition(ILeaveDungeonConditionT _ileavedungeoncondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ILeaveDungeonCondition,
				Value = _ileavedungeoncondition
			};
		}

		// Token: 0x06017743 RID: 96067 RVA: 0x00361950 File Offset: 0x0035FB50
		public ICheckTargetBattleAttributeConditionT AsICheckTargetBattleAttributeCondition()
		{
			return this.As<ICheckTargetBattleAttributeConditionT>();
		}

		// Token: 0x06017744 RID: 96068 RVA: 0x00361958 File Offset: 0x0035FB58
		public static IQuestCondition_UnionUnion FromICheckTargetBattleAttributeCondition(ICheckTargetBattleAttributeConditionT _ichecktargetbattleattributecondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICheckTargetBattleAttributeCondition,
				Value = _ichecktargetbattleattributecondition
			};
		}

		// Token: 0x06017745 RID: 96069 RVA: 0x0036196E File Offset: 0x0035FB6E
		public IWaitBattleConditionT AsIWaitBattleCondition()
		{
			return this.As<IWaitBattleConditionT>();
		}

		// Token: 0x06017746 RID: 96070 RVA: 0x00361976 File Offset: 0x0035FB76
		public static IQuestCondition_UnionUnion FromIWaitBattleCondition(IWaitBattleConditionT _iwaitbattlecondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IWaitBattleCondition,
				Value = _iwaitbattlecondition
			};
		}

		// Token: 0x06017747 RID: 96071 RVA: 0x0036198C File Offset: 0x0035FB8C
		public ICompareVarConditionInChildQuestT AsICompareVarConditionInChildQuest()
		{
			return this.As<ICompareVarConditionInChildQuestT>();
		}

		// Token: 0x06017748 RID: 96072 RVA: 0x00361994 File Offset: 0x0035FB94
		public static IQuestCondition_UnionUnion FromICompareVarConditionInChildQuest(ICompareVarConditionInChildQuestT _icomparevarconditioninchildquest)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICompareVarConditionInChildQuest,
				Value = _icomparevarconditioninchildquest
			};
		}

		// Token: 0x06017749 RID: 96073 RVA: 0x003619AA File Offset: 0x0035FBAA
		public ICompareActorVarT AsICompareActorVar()
		{
			return this.As<ICompareActorVarT>();
		}

		// Token: 0x0601774A RID: 96074 RVA: 0x003619B2 File Offset: 0x0035FBB2
		public static IQuestCondition_UnionUnion FromICompareActorVar(ICompareActorVarT _icompareactorvar)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICompareActorVar,
				Value = _icompareactorvar
			};
		}

		// Token: 0x0601774B RID: 96075 RVA: 0x003619C8 File Offset: 0x0035FBC8
		public IReceiveTelecomChildQuestConditionT AsIReceiveTelecomChildQuestCondition()
		{
			return this.As<IReceiveTelecomChildQuestConditionT>();
		}

		// Token: 0x0601774C RID: 96076 RVA: 0x003619D0 File Offset: 0x0035FBD0
		public static IQuestCondition_UnionUnion FromIReceiveTelecomChildQuestCondition(IReceiveTelecomChildQuestConditionT _ireceivetelecomchildquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IReceiveTelecomChildQuestCondition,
				Value = _ireceivetelecomchildquestcondition
			};
		}

		// Token: 0x0601774D RID: 96077 RVA: 0x003619E6 File Offset: 0x0035FBE6
		public IShowUiConditionT AsIShowUiCondition()
		{
			return this.As<IShowUiConditionT>();
		}

		// Token: 0x0601774E RID: 96078 RVA: 0x003619EE File Offset: 0x0035FBEE
		public static IQuestCondition_UnionUnion FromIShowUiCondition(IShowUiConditionT _ishowuicondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IShowUiCondition,
				Value = _ishowuicondition
			};
		}

		// Token: 0x0601774F RID: 96079 RVA: 0x00361A04 File Offset: 0x0035FC04
		public ITakePhotoConditionT AsITakePhotoCondition()
		{
			return this.As<ITakePhotoConditionT>();
		}

		// Token: 0x06017750 RID: 96080 RVA: 0x00361A0C File Offset: 0x0035FC0C
		public static IQuestCondition_UnionUnion FromITakePhotoCondition(ITakePhotoConditionT _itakephotocondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ITakePhotoCondition,
				Value = _itakephotocondition
			};
		}

		// Token: 0x06017751 RID: 96081 RVA: 0x00361A22 File Offset: 0x0035FC22
		public ITakePhoto2ConditionT AsITakePhoto2Condition()
		{
			return this.As<ITakePhoto2ConditionT>();
		}

		// Token: 0x06017752 RID: 96082 RVA: 0x00361A2A File Offset: 0x0035FC2A
		public static IQuestCondition_UnionUnion FromITakePhoto2Condition(ITakePhoto2ConditionT _itakephoto2condition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ITakePhoto2Condition,
				Value = _itakephoto2condition
			};
		}

		// Token: 0x06017753 RID: 96083 RVA: 0x00361A40 File Offset: 0x0035FC40
		public IVisionSystemQuestConditionT AsIVisionSystemQuestCondition()
		{
			return this.As<IVisionSystemQuestConditionT>();
		}

		// Token: 0x06017754 RID: 96084 RVA: 0x00361A48 File Offset: 0x0035FC48
		public static IQuestCondition_UnionUnion FromIVisionSystemQuestCondition(IVisionSystemQuestConditionT _ivisionsystemquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IVisionSystemQuestCondition,
				Value = _ivisionsystemquestcondition
			};
		}

		// Token: 0x06017755 RID: 96085 RVA: 0x00361A5E File Offset: 0x0035FC5E
		public IParallaxAlignQuestConditionT AsIParallaxAlignQuestCondition()
		{
			return this.As<IParallaxAlignQuestConditionT>();
		}

		// Token: 0x06017756 RID: 96086 RVA: 0x00361A66 File Offset: 0x0035FC66
		public static IQuestCondition_UnionUnion FromIParallaxAlignQuestCondition(IParallaxAlignQuestConditionT _iparallaxalignquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IParallaxAlignQuestCondition,
				Value = _iparallaxalignquestcondition
			};
		}

		// Token: 0x06017757 RID: 96087 RVA: 0x00361A7C File Offset: 0x0035FC7C
		public ICheckConditionGroupQuestConditionT AsICheckConditionGroupQuestCondition()
		{
			return this.As<ICheckConditionGroupQuestConditionT>();
		}

		// Token: 0x06017758 RID: 96088 RVA: 0x00361A84 File Offset: 0x0035FC84
		public static IQuestCondition_UnionUnion FromICheckConditionGroupQuestCondition(ICheckConditionGroupQuestConditionT _icheckconditiongroupquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICheckConditionGroupQuestCondition,
				Value = _icheckconditiongroupquestcondition
			};
		}

		// Token: 0x06017759 RID: 96089 RVA: 0x00361A9A File Offset: 0x0035FC9A
		public ICheckClientConditionGroupQuestConditionT AsICheckClientConditionGroupQuestCondition()
		{
			return this.As<ICheckClientConditionGroupQuestConditionT>();
		}

		// Token: 0x0601775A RID: 96090 RVA: 0x00361AA2 File Offset: 0x0035FCA2
		public static IQuestCondition_UnionUnion FromICheckClientConditionGroupQuestCondition(ICheckClientConditionGroupQuestConditionT _icheckclientconditiongroupquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICheckClientConditionGroupQuestCondition,
				Value = _icheckclientconditiongroupquestcondition
			};
		}

		// Token: 0x0601775B RID: 96091 RVA: 0x00361AB8 File Offset: 0x0035FCB8
		public ICheckActivityStateConditionT AsICheckActivityStateCondition()
		{
			return this.As<ICheckActivityStateConditionT>();
		}

		// Token: 0x0601775C RID: 96092 RVA: 0x00361AC0 File Offset: 0x0035FCC0
		public static IQuestCondition_UnionUnion FromICheckActivityStateCondition(ICheckActivityStateConditionT _icheckactivitystatecondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICheckActivityStateCondition,
				Value = _icheckactivitystatecondition
			};
		}

		// Token: 0x0601775D RID: 96093 RVA: 0x00361AD6 File Offset: 0x0035FCD6
		public ICheckPlayerInputConditionT AsICheckPlayerInputCondition()
		{
			return this.As<ICheckPlayerInputConditionT>();
		}

		// Token: 0x0601775E RID: 96094 RVA: 0x00361ADE File Offset: 0x0035FCDE
		public static IQuestCondition_UnionUnion FromICheckPlayerInputCondition(ICheckPlayerInputConditionT _icheckplayerinputcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICheckPlayerInputCondition,
				Value = _icheckplayerinputcondition
			};
		}

		// Token: 0x0601775F RID: 96095 RVA: 0x00361AF4 File Offset: 0x0035FCF4
		public IAwakeAndLoadEntityConditionT AsIAwakeAndLoadEntityCondition()
		{
			return this.As<IAwakeAndLoadEntityConditionT>();
		}

		// Token: 0x06017760 RID: 96096 RVA: 0x00361AFC File Offset: 0x0035FCFC
		public static IQuestCondition_UnionUnion FromIAwakeAndLoadEntityCondition(IAwakeAndLoadEntityConditionT _iawakeandloadentitycondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IAwakeAndLoadEntityCondition,
				Value = _iawakeandloadentitycondition
			};
		}

		// Token: 0x06017761 RID: 96097 RVA: 0x00361B12 File Offset: 0x0035FD12
		public IWalkingPatternConditionT AsIWalkingPatternCondition()
		{
			return this.As<IWalkingPatternConditionT>();
		}

		// Token: 0x06017762 RID: 96098 RVA: 0x00361B1A File Offset: 0x0035FD1A
		public static IQuestCondition_UnionUnion FromIWalkingPatternCondition(IWalkingPatternConditionT _iwalkingpatterncondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IWalkingPatternCondition,
				Value = _iwalkingpatterncondition
			};
		}

		// Token: 0x06017763 RID: 96099 RVA: 0x00361B30 File Offset: 0x0035FD30
		public IFinishBvbChallengeT AsIFinishBvbChallenge()
		{
			return this.As<IFinishBvbChallengeT>();
		}

		// Token: 0x06017764 RID: 96100 RVA: 0x00361B38 File Offset: 0x0035FD38
		public static IQuestCondition_UnionUnion FromIFinishBvbChallenge(IFinishBvbChallengeT _ifinishbvbchallenge)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishBvbChallenge,
				Value = _ifinishbvbchallenge
			};
		}

		// Token: 0x06017765 RID: 96101 RVA: 0x00361B4E File Offset: 0x0035FD4E
		public IProgramSpecialProcessT AsIProgramSpecialProcess()
		{
			return this.As<IProgramSpecialProcessT>();
		}

		// Token: 0x06017766 RID: 96102 RVA: 0x00361B56 File Offset: 0x0035FD56
		public static IQuestCondition_UnionUnion FromIProgramSpecialProcess(IProgramSpecialProcessT _iprogramspecialprocess)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IProgramSpecialProcess,
				Value = _iprogramspecialprocess
			};
		}

		// Token: 0x06017767 RID: 96103 RVA: 0x00361B6C File Offset: 0x0035FD6C
		public IPlaybackShowTimelineQuestConditionT AsIPlaybackShowTimelineQuestCondition()
		{
			return this.As<IPlaybackShowTimelineQuestConditionT>();
		}

		// Token: 0x06017768 RID: 96104 RVA: 0x00361B74 File Offset: 0x0035FD74
		public static IQuestCondition_UnionUnion FromIPlaybackShowTimelineQuestCondition(IPlaybackShowTimelineQuestConditionT _iplaybackshowtimelinequestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IPlaybackShowTimelineQuestCondition,
				Value = _iplaybackshowtimelinequestcondition
			};
		}

		// Token: 0x06017769 RID: 96105 RVA: 0x00361B8A File Offset: 0x0035FD8A
		public IWaitUntilLevelSequenceReachMarkT AsIWaitUntilLevelSequenceReachMark()
		{
			return this.As<IWaitUntilLevelSequenceReachMarkT>();
		}

		// Token: 0x0601776A RID: 96106 RVA: 0x00361B92 File Offset: 0x0035FD92
		public static IQuestCondition_UnionUnion FromIWaitUntilLevelSequenceReachMark(IWaitUntilLevelSequenceReachMarkT _iwaituntillevelsequencereachmark)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IWaitUntilLevelSequenceReachMark,
				Value = _iwaituntillevelsequencereachmark
			};
		}

		// Token: 0x0601776B RID: 96107 RVA: 0x00361BA8 File Offset: 0x0035FDA8
		public IFinishTrapDefenseConditionT AsIFinishTrapDefenseCondition()
		{
			return this.As<IFinishTrapDefenseConditionT>();
		}

		// Token: 0x0601776C RID: 96108 RVA: 0x00361BB0 File Offset: 0x0035FDB0
		public static IQuestCondition_UnionUnion FromIFinishTrapDefenseCondition(IFinishTrapDefenseConditionT _ifinishtrapdefensecondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishTrapDefenseCondition,
				Value = _ifinishtrapdefensecondition
			};
		}

		// Token: 0x0601776D RID: 96109 RVA: 0x00361BC6 File Offset: 0x0035FDC6
		public ICheckTrapDefenseEventConditionT AsICheckTrapDefenseEventCondition()
		{
			return this.As<ICheckTrapDefenseEventConditionT>();
		}

		// Token: 0x0601776E RID: 96110 RVA: 0x00361BCE File Offset: 0x0035FDCE
		public static IQuestCondition_UnionUnion FromICheckTrapDefenseEventCondition(ICheckTrapDefenseEventConditionT _ichecktrapdefenseeventcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICheckTrapDefenseEventCondition,
				Value = _ichecktrapdefenseeventcondition
			};
		}

		// Token: 0x0601776F RID: 96111 RVA: 0x00361BE4 File Offset: 0x0035FDE4
		public IFinishSurvivorsRougeConditionT AsIFinishSurvivorsRougeCondition()
		{
			return this.As<IFinishSurvivorsRougeConditionT>();
		}

		// Token: 0x06017770 RID: 96112 RVA: 0x00361BEC File Offset: 0x0035FDEC
		public static IQuestCondition_UnionUnion FromIFinishSurvivorsRougeCondition(IFinishSurvivorsRougeConditionT _ifinishsurvivorsrougecondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishSurvivorsRougeCondition,
				Value = _ifinishsurvivorsrougecondition
			};
		}

		// Token: 0x06017771 RID: 96113 RVA: 0x00361C02 File Offset: 0x0035FE02
		public IFinishKurotatoConditionT AsIFinishKurotatoCondition()
		{
			return this.As<IFinishKurotatoConditionT>();
		}

		// Token: 0x06017772 RID: 96114 RVA: 0x00361C0A File Offset: 0x0035FE0A
		public static IQuestCondition_UnionUnion FromIFinishKurotatoCondition(IFinishKurotatoConditionT _ifinishkurotatocondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishKurotatoCondition,
				Value = _ifinishkurotatocondition
			};
		}

		// Token: 0x06017773 RID: 96115 RVA: 0x00361C20 File Offset: 0x0035FE20
		public IFinishRoleTowerConditionT AsIFinishRoleTowerCondition()
		{
			return this.As<IFinishRoleTowerConditionT>();
		}

		// Token: 0x06017774 RID: 96116 RVA: 0x00361C28 File Offset: 0x0035FE28
		public static IQuestCondition_UnionUnion FromIFinishRoleTowerCondition(IFinishRoleTowerConditionT _ifinishroletowercondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishRoleTowerCondition,
				Value = _ifinishroletowercondition
			};
		}

		// Token: 0x06017775 RID: 96117 RVA: 0x00361C3E File Offset: 0x0035FE3E
		public IFinishRhythmSpaceshipConditionT AsIFinishRhythmSpaceshipCondition()
		{
			return this.As<IFinishRhythmSpaceshipConditionT>();
		}

		// Token: 0x06017776 RID: 96118 RVA: 0x00361C46 File Offset: 0x0035FE46
		public static IQuestCondition_UnionUnion FromIFinishRhythmSpaceshipCondition(IFinishRhythmSpaceshipConditionT _ifinishrhythmspaceshipcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishRhythmSpaceshipCondition,
				Value = _ifinishrhythmspaceshipcondition
			};
		}

		// Token: 0x06017777 RID: 96119 RVA: 0x00361C5C File Offset: 0x0035FE5C
		public IFinishFlipperConditionT AsIFinishFlipperCondition()
		{
			return this.As<IFinishFlipperConditionT>();
		}

		// Token: 0x06017778 RID: 96120 RVA: 0x00361C64 File Offset: 0x0035FE64
		public static IQuestCondition_UnionUnion FromIFinishFlipperCondition(IFinishFlipperConditionT _ifinishflippercondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishFlipperCondition,
				Value = _ifinishflippercondition
			};
		}

		// Token: 0x06017779 RID: 96121 RVA: 0x00361C7A File Offset: 0x0035FE7A
		public ITimeScaledPhotographT AsITimeScaledPhotograph()
		{
			return this.As<ITimeScaledPhotographT>();
		}

		// Token: 0x0601777A RID: 96122 RVA: 0x00361C82 File Offset: 0x0035FE82
		public static IQuestCondition_UnionUnion FromITimeScaledPhotograph(ITimeScaledPhotographT _itimescaledphotograph)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ITimeScaledPhotograph,
				Value = _itimescaledphotograph
			};
		}

		// Token: 0x0601777B RID: 96123 RVA: 0x00361C98 File Offset: 0x0035FE98
		public IFinishRollBlockT AsIFinishRollBlock()
		{
			return this.As<IFinishRollBlockT>();
		}

		// Token: 0x0601777C RID: 96124 RVA: 0x00361CA0 File Offset: 0x0035FEA0
		public static IQuestCondition_UnionUnion FromIFinishRollBlock(IFinishRollBlockT _ifinishrollblock)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishRollBlock,
				Value = _ifinishrollblock
			};
		}

		// Token: 0x0601777D RID: 96125 RVA: 0x00361CB6 File Offset: 0x0035FEB6
		public IAtomicProcessT AsIAtomicProcess()
		{
			return this.As<IAtomicProcessT>();
		}

		// Token: 0x0601777E RID: 96126 RVA: 0x00361CBE File Offset: 0x0035FEBE
		public static IQuestCondition_UnionUnion FromIAtomicProcess(IAtomicProcessT _iatomicprocess)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IAtomicProcess,
				Value = _iatomicprocess
			};
		}

		// Token: 0x0601777F RID: 96127 RVA: 0x00361CD4 File Offset: 0x0035FED4
		public IUseWeatherSwitchConditionT AsIUseWeatherSwitchCondition()
		{
			return this.As<IUseWeatherSwitchConditionT>();
		}

		// Token: 0x06017780 RID: 96128 RVA: 0x00361CDC File Offset: 0x0035FEDC
		public static IQuestCondition_UnionUnion FromIUseWeatherSwitchCondition(IUseWeatherSwitchConditionT _iuseweatherswitchcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IUseWeatherSwitchCondition,
				Value = _iuseweatherswitchcondition
			};
		}

		// Token: 0x06017781 RID: 96129 RVA: 0x00361CF2 File Offset: 0x0035FEF2
		public ICheckSpringFestivalGameplayCompletedT AsICheckSpringFestivalGameplayCompleted()
		{
			return this.As<ICheckSpringFestivalGameplayCompletedT>();
		}

		// Token: 0x06017782 RID: 96130 RVA: 0x00361CFA File Offset: 0x0035FEFA
		public static IQuestCondition_UnionUnion FromICheckSpringFestivalGameplayCompleted(ICheckSpringFestivalGameplayCompletedT _icheckspringfestivalgameplaycompleted)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICheckSpringFestivalGameplayCompleted,
				Value = _icheckspringfestivalgameplaycompleted
			};
		}

		// Token: 0x06017783 RID: 96131 RVA: 0x00361D10 File Offset: 0x0035FF10
		public IListenToEventT AsIListenToEvent()
		{
			return this.As<IListenToEventT>();
		}

		// Token: 0x06017784 RID: 96132 RVA: 0x00361D18 File Offset: 0x0035FF18
		public static IQuestCondition_UnionUnion FromIListenToEvent(IListenToEventT _ilistentoevent)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IListenToEvent,
				Value = _ilistentoevent
			};
		}

		// Token: 0x06017785 RID: 96133 RVA: 0x00361D2E File Offset: 0x0035FF2E
		public IParkourQuestConditionT AsIParkourQuestCondition()
		{
			return this.As<IParkourQuestConditionT>();
		}

		// Token: 0x06017786 RID: 96134 RVA: 0x00361D36 File Offset: 0x0035FF36
		public static IQuestCondition_UnionUnion FromIParkourQuestCondition(IParkourQuestConditionT _iparkourquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IParkourQuestCondition,
				Value = _iparkourquestcondition
			};
		}

		// Token: 0x06017787 RID: 96135 RVA: 0x00361D4C File Offset: 0x0035FF4C
		public ITimerQuestConditionT AsITimerQuestCondition()
		{
			return this.As<ITimerQuestConditionT>();
		}

		// Token: 0x06017788 RID: 96136 RVA: 0x00361D54 File Offset: 0x0035FF54
		public static IQuestCondition_UnionUnion FromITimerQuestCondition(ITimerQuestConditionT _itimerquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ITimerQuestCondition,
				Value = _itimerquestcondition
			};
		}

		// Token: 0x06017789 RID: 96137 RVA: 0x00361D6A File Offset: 0x0035FF6A
		public IMonsterCreatorQuestConditionT AsIMonsterCreatorQuestCondition()
		{
			return this.As<IMonsterCreatorQuestConditionT>();
		}

		// Token: 0x0601778A RID: 96138 RVA: 0x00361D72 File Offset: 0x0035FF72
		public static IQuestCondition_UnionUnion FromIMonsterCreatorQuestCondition(IMonsterCreatorQuestConditionT _imonstercreatorquestcondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IMonsterCreatorQuestCondition,
				Value = _imonstercreatorquestcondition
			};
		}

		// Token: 0x0601778B RID: 96139 RVA: 0x00361D88 File Offset: 0x0035FF88
		public IFinishTetrisT AsIFinishTetris()
		{
			return this.As<IFinishTetrisT>();
		}

		// Token: 0x0601778C RID: 96140 RVA: 0x00361D90 File Offset: 0x0035FF90
		public static IQuestCondition_UnionUnion FromIFinishTetris(IFinishTetrisT _ifinishtetris)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishTetris,
				Value = _ifinishtetris
			};
		}

		// Token: 0x0601778D RID: 96141 RVA: 0x00361DA6 File Offset: 0x0035FFA6
		public IFinishArcadeGameplayT AsIFinishArcadeGameplay()
		{
			return this.As<IFinishArcadeGameplayT>();
		}

		// Token: 0x0601778E RID: 96142 RVA: 0x00361DAE File Offset: 0x0035FFAE
		public static IQuestCondition_UnionUnion FromIFinishArcadeGameplay(IFinishArcadeGameplayT _ifinisharcadegameplay)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishArcadeGameplay,
				Value = _ifinisharcadegameplay
			};
		}

		// Token: 0x0601778F RID: 96143 RVA: 0x00361DC4 File Offset: 0x0035FFC4
		public IFinishKuroSimpleCombatKillMonsterT AsIFinishKuroSimpleCombatKillMonster()
		{
			return this.As<IFinishKuroSimpleCombatKillMonsterT>();
		}

		// Token: 0x06017790 RID: 96144 RVA: 0x00361DCC File Offset: 0x0035FFCC
		public static IQuestCondition_UnionUnion FromIFinishKuroSimpleCombatKillMonster(IFinishKuroSimpleCombatKillMonsterT _ifinishkurosimplecombatkillmonster)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishKuroSimpleCombatKillMonster,
				Value = _ifinishkurosimplecombatkillmonster
			};
		}

		// Token: 0x06017791 RID: 96145 RVA: 0x00361DE2 File Offset: 0x0035FFE2
		public ICrossSceneSyncKillMonsterT AsICrossSceneSyncKillMonster()
		{
			return this.As<ICrossSceneSyncKillMonsterT>();
		}

		// Token: 0x06017792 RID: 96146 RVA: 0x00361DEA File Offset: 0x0035FFEA
		public static IQuestCondition_UnionUnion FromICrossSceneSyncKillMonster(ICrossSceneSyncKillMonsterT _icrossscenesynckillmonster)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.ICrossSceneSyncKillMonster,
				Value = _icrossscenesynckillmonster
			};
		}

		// Token: 0x06017793 RID: 96147 RVA: 0x00361E00 File Offset: 0x00360000
		public IFinishJellyfishReturnConditionT AsIFinishJellyfishReturnCondition()
		{
			return this.As<IFinishJellyfishReturnConditionT>();
		}

		// Token: 0x06017794 RID: 96148 RVA: 0x00361E08 File Offset: 0x00360008
		public static IQuestCondition_UnionUnion FromIFinishJellyfishReturnCondition(IFinishJellyfishReturnConditionT _ifinishjellyfishreturncondition)
		{
			return new IQuestCondition_UnionUnion
			{
				Type = IQuestCondition_Union.IFinishJellyfishReturnCondition,
				Value = _ifinishjellyfishreturncondition
			};
		}

		// Token: 0x06017795 RID: 96149 RVA: 0x00361E20 File Offset: 0x00360020
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

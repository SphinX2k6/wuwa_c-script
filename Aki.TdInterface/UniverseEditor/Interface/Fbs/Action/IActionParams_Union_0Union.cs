using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066EC RID: 26348
	public class IActionParams_Union_0Union
	{
		// Token: 0x1700BF94 RID: 49044
		// (get) Token: 0x0602C650 RID: 181840 RVA: 0x00613774 File Offset: 0x00611974
		// (set) Token: 0x0602C651 RID: 181841 RVA: 0x0061377C File Offset: 0x0061197C
		public IActionParams_Union_0 Type { get; set; }

		// Token: 0x1700BF95 RID: 49045
		// (get) Token: 0x0602C652 RID: 181842 RVA: 0x00613785 File Offset: 0x00611985
		// (set) Token: 0x0602C653 RID: 181843 RVA: 0x0061378D File Offset: 0x0061198D
		public object Value { get; set; }

		// Token: 0x0602C654 RID: 181844 RVA: 0x00613796 File Offset: 0x00611996
		public IActionParams_Union_0Union()
		{
			this.Type = IActionParams_Union_0.NONE;
			this.Value = null;
		}

		// Token: 0x0602C655 RID: 181845 RVA: 0x006137AC File Offset: 0x006119AC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602C656 RID: 181846 RVA: 0x006137BE File Offset: 0x006119BE
		public IActionParamsT AsIActionParams()
		{
			return this.As<IActionParamsT>();
		}

		// Token: 0x0602C657 RID: 181847 RVA: 0x006137C6 File Offset: 0x006119C6
		public static IActionParams_Union_0Union FromIActionParams(IActionParamsT _iactionparams)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IActionParams,
				Value = _iactionparams
			};
		}

		// Token: 0x0602C658 RID: 181848 RVA: 0x006137DB File Offset: 0x006119DB
		public IInvokeT AsIInvoke()
		{
			return this.As<IInvokeT>();
		}

		// Token: 0x0602C659 RID: 181849 RVA: 0x006137E3 File Offset: 0x006119E3
		public static IActionParams_Union_0Union FromIInvoke(IInvokeT _iinvoke)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IInvoke,
				Value = _iinvoke
			};
		}

		// Token: 0x0602C65A RID: 181850 RVA: 0x006137F8 File Offset: 0x006119F8
		public IInteractT AsIInteract()
		{
			return this.As<IInteractT>();
		}

		// Token: 0x0602C65B RID: 181851 RVA: 0x00613800 File Offset: 0x00611A00
		public static IActionParams_Union_0Union FromIInteract(IInteractT _iinteract)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IInteract,
				Value = _iinteract
			};
		}

		// Token: 0x0602C65C RID: 181852 RVA: 0x00613815 File Offset: 0x00611A15
		public IFinishConditionT AsIFinishCondition()
		{
			return this.As<IFinishConditionT>();
		}

		// Token: 0x0602C65D RID: 181853 RVA: 0x0061381D File Offset: 0x00611A1D
		public static IActionParams_Union_0Union FromIFinishCondition(IFinishConditionT _ifinishcondition)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFinishCondition,
				Value = _ifinishcondition
			};
		}

		// Token: 0x0602C65E RID: 181854 RVA: 0x00613832 File Offset: 0x00611A32
		public IGetRewardByInteractT AsIGetRewardByInteract()
		{
			return this.As<IGetRewardByInteractT>();
		}

		// Token: 0x0602C65F RID: 181855 RVA: 0x0061383A File Offset: 0x00611A3A
		public static IActionParams_Union_0Union FromIGetRewardByInteract(IGetRewardByInteractT _igetrewardbyinteract)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IGetRewardByInteract,
				Value = _igetrewardbyinteract
			};
		}

		// Token: 0x0602C660 RID: 181856 RVA: 0x0061384F File Offset: 0x00611A4F
		public IWaitUntilLevelSequenceReachMarkT AsIWaitUntilLevelSequenceReachMark()
		{
			return this.As<IWaitUntilLevelSequenceReachMarkT>();
		}

		// Token: 0x0602C661 RID: 181857 RVA: 0x00613857 File Offset: 0x00611A57
		public static IActionParams_Union_0Union FromIWaitUntilLevelSequenceReachMark(IWaitUntilLevelSequenceReachMarkT _iwaituntillevelsequencereachmark)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IWaitUntilLevelSequenceReachMark,
				Value = _iwaituntillevelsequencereachmark
			};
		}

		// Token: 0x0602C662 RID: 181858 RVA: 0x0061386C File Offset: 0x00611A6C
		public IClearEntityVisibleTagT AsIClearEntityVisibleTag()
		{
			return this.As<IClearEntityVisibleTagT>();
		}

		// Token: 0x0602C663 RID: 181859 RVA: 0x00613874 File Offset: 0x00611A74
		public static IActionParams_Union_0Union FromIClearEntityVisibleTag(IClearEntityVisibleTagT _iclearentityvisibletag)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IClearEntityVisibleTag,
				Value = _iclearentityvisibletag
			};
		}

		// Token: 0x0602C664 RID: 181860 RVA: 0x00613889 File Offset: 0x00611A89
		public ISetEntityPosT AsISetEntityPos()
		{
			return this.As<ISetEntityPosT>();
		}

		// Token: 0x0602C665 RID: 181861 RVA: 0x00613891 File Offset: 0x00611A91
		public static IActionParams_Union_0Union FromISetEntityPos(ISetEntityPosT _isetentitypos)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetEntityPos,
				Value = _isetentitypos
			};
		}

		// Token: 0x0602C666 RID: 181862 RVA: 0x006138A6 File Offset: 0x00611AA6
		public IResetEntityPosT AsIResetEntityPos()
		{
			return this.As<IResetEntityPosT>();
		}

		// Token: 0x0602C667 RID: 181863 RVA: 0x006138AE File Offset: 0x00611AAE
		public static IActionParams_Union_0Union FromIResetEntityPos(IResetEntityPosT _iresetentitypos)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IResetEntityPos,
				Value = _iresetentitypos
			};
		}

		// Token: 0x0602C668 RID: 181864 RVA: 0x006138C4 File Offset: 0x00611AC4
		public IServerSetPlayerPosT AsIServerSetPlayerPos()
		{
			return this.As<IServerSetPlayerPosT>();
		}

		// Token: 0x0602C669 RID: 181865 RVA: 0x006138CC File Offset: 0x00611ACC
		public static IActionParams_Union_0Union FromIServerSetPlayerPos(IServerSetPlayerPosT _iserversetplayerpos)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IServerSetPlayerPos,
				Value = _iserversetplayerpos
			};
		}

		// Token: 0x0602C66A RID: 181866 RVA: 0x006138E2 File Offset: 0x00611AE2
		public IFixTeleControllerPosT AsIFixTeleControllerPos()
		{
			return this.As<IFixTeleControllerPosT>();
		}

		// Token: 0x0602C66B RID: 181867 RVA: 0x006138EA File Offset: 0x00611AEA
		public static IActionParams_Union_0Union FromIFixTeleControllerPos(IFixTeleControllerPosT _ifixtelecontrollerpos)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFixTeleControllerPos,
				Value = _ifixtelecontrollerpos
			};
		}

		// Token: 0x0602C66C RID: 181868 RVA: 0x00613900 File Offset: 0x00611B00
		public IFixTeleControllerResetPosT AsIFixTeleControllerResetPos()
		{
			return this.As<IFixTeleControllerResetPosT>();
		}

		// Token: 0x0602C66D RID: 181869 RVA: 0x00613908 File Offset: 0x00611B08
		public static IActionParams_Union_0Union FromIFixTeleControllerResetPos(IFixTeleControllerResetPosT _ifixtelecontrollerresetpos)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFixTeleControllerResetPos,
				Value = _ifixtelecontrollerresetpos
			};
		}

		// Token: 0x0602C66E RID: 181870 RVA: 0x0061391E File Offset: 0x00611B1E
		public IFixFoundationRelationT AsIFixFoundationRelation()
		{
			return this.As<IFixFoundationRelationT>();
		}

		// Token: 0x0602C66F RID: 181871 RVA: 0x00613926 File Offset: 0x00611B26
		public static IActionParams_Union_0Union FromIFixFoundationRelation(IFixFoundationRelationT _ifixfoundationrelation)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFixFoundationRelation,
				Value = _ifixfoundationrelation
			};
		}

		// Token: 0x0602C670 RID: 181872 RVA: 0x0061393C File Offset: 0x00611B3C
		public ITraceCurrentQuestT AsITraceCurrentQuest()
		{
			return this.As<ITraceCurrentQuestT>();
		}

		// Token: 0x0602C671 RID: 181873 RVA: 0x00613944 File Offset: 0x00611B44
		public static IActionParams_Union_0Union FromITraceCurrentQuest(ITraceCurrentQuestT _itracecurrentquest)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ITraceCurrentQuest,
				Value = _itracecurrentquest
			};
		}

		// Token: 0x0602C672 RID: 181874 RVA: 0x0061395A File Offset: 0x00611B5A
		public IFixShowTargetRangeT AsIFixShowTargetRange()
		{
			return this.As<IFixShowTargetRangeT>();
		}

		// Token: 0x0602C673 RID: 181875 RVA: 0x00613962 File Offset: 0x00611B62
		public static IActionParams_Union_0Union FromIFixShowTargetRange(IFixShowTargetRangeT _ifixshowtargetrange)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFixShowTargetRange,
				Value = _ifixshowtargetrange
			};
		}

		// Token: 0x0602C674 RID: 181876 RVA: 0x00613978 File Offset: 0x00611B78
		public IFixGetItemT AsIFixGetItem()
		{
			return this.As<IFixGetItemT>();
		}

		// Token: 0x0602C675 RID: 181877 RVA: 0x00613980 File Offset: 0x00611B80
		public static IActionParams_Union_0Union FromIFixGetItem(IFixGetItemT _ifixgetitem)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFixGetItem,
				Value = _ifixgetitem
			};
		}

		// Token: 0x0602C676 RID: 181878 RVA: 0x00613996 File Offset: 0x00611B96
		public ILogT AsILog()
		{
			return this.As<ILogT>();
		}

		// Token: 0x0602C677 RID: 181879 RVA: 0x0061399E File Offset: 0x00611B9E
		public static IActionParams_Union_0Union FromILog(ILogT _ilog)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ILog,
				Value = _ilog
			};
		}

		// Token: 0x0602C678 RID: 181880 RVA: 0x006139B4 File Offset: 0x00611BB4
		public IShowMessageT AsIShowMessage()
		{
			return this.As<IShowMessageT>();
		}

		// Token: 0x0602C679 RID: 181881 RVA: 0x006139BC File Offset: 0x00611BBC
		public static IActionParams_Union_0Union FromIShowMessage(IShowMessageT _ishowmessage)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IShowMessage,
				Value = _ishowmessage
			};
		}

		// Token: 0x0602C67A RID: 181882 RVA: 0x006139D2 File Offset: 0x00611BD2
		public IPromptT AsIPrompt()
		{
			return this.As<IPromptT>();
		}

		// Token: 0x0602C67B RID: 181883 RVA: 0x006139DA File Offset: 0x00611BDA
		public static IActionParams_Union_0Union FromIPrompt(IPromptT _iprompt)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPrompt,
				Value = _iprompt
			};
		}

		// Token: 0x0602C67C RID: 181884 RVA: 0x006139F0 File Offset: 0x00611BF0
		public ISendNpcMailT AsISendNpcMail()
		{
			return this.As<ISendNpcMailT>();
		}

		// Token: 0x0602C67D RID: 181885 RVA: 0x006139F8 File Offset: 0x00611BF8
		public static IActionParams_Union_0Union FromISendNpcMail(ISendNpcMailT _isendnpcmail)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISendNpcMail,
				Value = _isendnpcmail
			};
		}

		// Token: 0x0602C67E RID: 181886 RVA: 0x00613A0E File Offset: 0x00611C0E
		public IAdjustTodTimeT AsIAdjustTodTime()
		{
			return this.As<IAdjustTodTimeT>();
		}

		// Token: 0x0602C67F RID: 181887 RVA: 0x00613A16 File Offset: 0x00611C16
		public static IActionParams_Union_0Union FromIAdjustTodTime(IAdjustTodTimeT _iadjusttodtime)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAdjustTodTime,
				Value = _iadjusttodtime
			};
		}

		// Token: 0x0602C680 RID: 181888 RVA: 0x00613A2C File Offset: 0x00611C2C
		public ISetAreaTimeStateT AsISetAreaTimeState()
		{
			return this.As<ISetAreaTimeStateT>();
		}

		// Token: 0x0602C681 RID: 181889 RVA: 0x00613A34 File Offset: 0x00611C34
		public static IActionParams_Union_0Union FromISetAreaTimeState(ISetAreaTimeStateT _isetareatimestate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetAreaTimeState,
				Value = _isetareatimestate
			};
		}

		// Token: 0x0602C682 RID: 181890 RVA: 0x00613A4A File Offset: 0x00611C4A
		public ISetTimeScaleT AsISetTimeScale()
		{
			return this.As<ISetTimeScaleT>();
		}

		// Token: 0x0602C683 RID: 181891 RVA: 0x00613A52 File Offset: 0x00611C52
		public static IActionParams_Union_0Union FromISetTimeScale(ISetTimeScaleT _isettimescale)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetTimeScale,
				Value = _isettimescale
			};
		}

		// Token: 0x0602C684 RID: 181892 RVA: 0x00613A68 File Offset: 0x00611C68
		public IJumpTalkT AsIJumpTalk()
		{
			return this.As<IJumpTalkT>();
		}

		// Token: 0x0602C685 RID: 181893 RVA: 0x00613A70 File Offset: 0x00611C70
		public static IActionParams_Union_0Union FromIJumpTalk(IJumpTalkT _ijumptalk)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IJumpTalk,
				Value = _ijumptalk
			};
		}

		// Token: 0x0602C686 RID: 181894 RVA: 0x00613A86 File Offset: 0x00611C86
		public ISetHeadIconVisibleT AsISetHeadIconVisible()
		{
			return this.As<ISetHeadIconVisibleT>();
		}

		// Token: 0x0602C687 RID: 181895 RVA: 0x00613A8E File Offset: 0x00611C8E
		public static IActionParams_Union_0Union FromISetHeadIconVisible(ISetHeadIconVisibleT _isetheadiconvisible)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetHeadIconVisible,
				Value = _isetheadiconvisible
			};
		}

		// Token: 0x0602C688 RID: 181896 RVA: 0x00613AA4 File Offset: 0x00611CA4
		public IPlayMontageT AsIPlayMontage()
		{
			return this.As<IPlayMontageT>();
		}

		// Token: 0x0602C689 RID: 181897 RVA: 0x00613AAC File Offset: 0x00611CAC
		public static IActionParams_Union_0Union FromIPlayMontage(IPlayMontageT _iplaymontage)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayMontage,
				Value = _iplaymontage
			};
		}

		// Token: 0x0602C68A RID: 181898 RVA: 0x00613AC2 File Offset: 0x00611CC2
		public IAvgPlayRoleActionT AsIAvgPlayRoleAction()
		{
			return this.As<IAvgPlayRoleActionT>();
		}

		// Token: 0x0602C68B RID: 181899 RVA: 0x00613ACA File Offset: 0x00611CCA
		public static IActionParams_Union_0Union FromIAvgPlayRoleAction(IAvgPlayRoleActionT _iavgplayroleaction)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAvgPlayRoleAction,
				Value = _iavgplayroleaction
			};
		}

		// Token: 0x0602C68C RID: 181900 RVA: 0x00613AE0 File Offset: 0x00611CE0
		public IAvgMoveRoleT AsIAvgMoveRole()
		{
			return this.As<IAvgMoveRoleT>();
		}

		// Token: 0x0602C68D RID: 181901 RVA: 0x00613AE8 File Offset: 0x00611CE8
		public static IActionParams_Union_0Union FromIAvgMoveRole(IAvgMoveRoleT _iavgmoverole)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAvgMoveRole,
				Value = _iavgmoverole
			};
		}

		// Token: 0x0602C68E RID: 181902 RVA: 0x00613AFE File Offset: 0x00611CFE
		public IAvgFocusRoleT AsIAvgFocusRole()
		{
			return this.As<IAvgFocusRoleT>();
		}

		// Token: 0x0602C68F RID: 181903 RVA: 0x00613B06 File Offset: 0x00611D06
		public static IActionParams_Union_0Union FromIAvgFocusRole(IAvgFocusRoleT _iavgfocusrole)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAvgFocusRole,
				Value = _iavgfocusrole
			};
		}

		// Token: 0x0602C690 RID: 181904 RVA: 0x00613B1C File Offset: 0x00611D1C
		public IAvgShakeUiT AsIAvgShakeUi()
		{
			return this.As<IAvgShakeUiT>();
		}

		// Token: 0x0602C691 RID: 181905 RVA: 0x00613B24 File Offset: 0x00611D24
		public static IActionParams_Union_0Union FromIAvgShakeUi(IAvgShakeUiT _iavgshakeui)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAvgShakeUi,
				Value = _iavgshakeui
			};
		}

		// Token: 0x0602C692 RID: 181906 RVA: 0x00613B3A File Offset: 0x00611D3A
		public IDestroyDynamicEntitiesT AsIDestroyDynamicEntities()
		{
			return this.As<IDestroyDynamicEntitiesT>();
		}

		// Token: 0x0602C693 RID: 181907 RVA: 0x00613B42 File Offset: 0x00611D42
		public static IActionParams_Union_0Union FromIDestroyDynamicEntities(IDestroyDynamicEntitiesT _idestroydynamicentities)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IDestroyDynamicEntities,
				Value = _idestroydynamicentities
			};
		}

		// Token: 0x0602C694 RID: 181908 RVA: 0x00613B58 File Offset: 0x00611D58
		public IActorLookAtT AsIActorLookAt()
		{
			return this.As<IActorLookAtT>();
		}

		// Token: 0x0602C695 RID: 181909 RVA: 0x00613B60 File Offset: 0x00611D60
		public static IActionParams_Union_0Union FromIActorLookAt(IActorLookAtT _iactorlookat)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IActorLookAt,
				Value = _iactorlookat
			};
		}

		// Token: 0x0602C696 RID: 181910 RVA: 0x00613B76 File Offset: 0x00611D76
		public IActorTurnToT AsIActorTurnTo()
		{
			return this.As<IActorTurnToT>();
		}

		// Token: 0x0602C697 RID: 181911 RVA: 0x00613B7E File Offset: 0x00611D7E
		public static IActionParams_Union_0Union FromIActorTurnTo(IActorTurnToT _iactorturnto)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IActorTurnTo,
				Value = _iactorturnto
			};
		}

		// Token: 0x0602C698 RID: 181912 RVA: 0x00613B94 File Offset: 0x00611D94
		public IShowTalkT AsIShowTalk()
		{
			return this.As<IShowTalkT>();
		}

		// Token: 0x0602C699 RID: 181913 RVA: 0x00613B9C File Offset: 0x00611D9C
		public static IActionParams_Union_0Union FromIShowTalk(IShowTalkT _ishowtalk)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IShowTalk,
				Value = _ishowtalk
			};
		}

		// Token: 0x0602C69A RID: 181914 RVA: 0x00613BB2 File Offset: 0x00611DB2
		public IFinishTalkT AsIFinishTalk()
		{
			return this.As<IFinishTalkT>();
		}

		// Token: 0x0602C69B RID: 181915 RVA: 0x00613BBA File Offset: 0x00611DBA
		public static IActionParams_Union_0Union FromIFinishTalk(IFinishTalkT _ifinishtalk)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFinishTalk,
				Value = _ifinishtalk
			};
		}

		// Token: 0x0602C69C RID: 181916 RVA: 0x00613BD0 File Offset: 0x00611DD0
		public IShowCenterTextT AsIShowCenterText()
		{
			return this.As<IShowCenterTextT>();
		}

		// Token: 0x0602C69D RID: 181917 RVA: 0x00613BD8 File Offset: 0x00611DD8
		public static IActionParams_Union_0Union FromIShowCenterText(IShowCenterTextT _ishowcentertext)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IShowCenterText,
				Value = _ishowcentertext
			};
		}

		// Token: 0x0602C69E RID: 181918 RVA: 0x00613BEE File Offset: 0x00611DEE
		public IFinishStateT AsIFinishState()
		{
			return this.As<IFinishStateT>();
		}

		// Token: 0x0602C69F RID: 181919 RVA: 0x00613BF6 File Offset: 0x00611DF6
		public static IActionParams_Union_0Union FromIFinishState(IFinishStateT _ifinishstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFinishState,
				Value = _ifinishstate
			};
		}

		// Token: 0x0602C6A0 RID: 181920 RVA: 0x00613C0C File Offset: 0x00611E0C
		public IChangeStateT AsIChangeState()
		{
			return this.As<IChangeStateT>();
		}

		// Token: 0x0602C6A1 RID: 181921 RVA: 0x00613C14 File Offset: 0x00611E14
		public static IActionParams_Union_0Union FromIChangeState(IChangeStateT _ichangestate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeState,
				Value = _ichangestate
			};
		}

		// Token: 0x0602C6A2 RID: 181922 RVA: 0x00613C2A File Offset: 0x00611E2A
		public IChangeBehaviorStateT AsIChangeBehaviorState()
		{
			return this.As<IChangeBehaviorStateT>();
		}

		// Token: 0x0602C6A3 RID: 181923 RVA: 0x00613C32 File Offset: 0x00611E32
		public static IActionParams_Union_0Union FromIChangeBehaviorState(IChangeBehaviorStateT _ichangebehaviorstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeBehaviorState,
				Value = _ichangebehaviorstate
			};
		}

		// Token: 0x0602C6A4 RID: 181924 RVA: 0x00613C48 File Offset: 0x00611E48
		public ISetBehaviorIsPausedT AsISetBehaviorIsPaused()
		{
			return this.As<ISetBehaviorIsPausedT>();
		}

		// Token: 0x0602C6A5 RID: 181925 RVA: 0x00613C50 File Offset: 0x00611E50
		public static IActionParams_Union_0Union FromISetBehaviorIsPaused(ISetBehaviorIsPausedT _isetbehaviorispaused)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetBehaviorIsPaused,
				Value = _isetbehaviorispaused
			};
		}

		// Token: 0x0602C6A6 RID: 181926 RVA: 0x00613C66 File Offset: 0x00611E66
		public IChangeRandomStateT AsIChangeRandomState()
		{
			return this.As<IChangeRandomStateT>();
		}

		// Token: 0x0602C6A7 RID: 181927 RVA: 0x00613C6E File Offset: 0x00611E6E
		public static IActionParams_Union_0Union FromIChangeRandomState(IChangeRandomStateT _ichangerandomstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeRandomState,
				Value = _ichangerandomstate
			};
		}

		// Token: 0x0602C6A8 RID: 181928 RVA: 0x00613C84 File Offset: 0x00611E84
		public IChangeActorStateT AsIChangeActorState()
		{
			return this.As<IChangeActorStateT>();
		}

		// Token: 0x0602C6A9 RID: 181929 RVA: 0x00613C8C File Offset: 0x00611E8C
		public static IActionParams_Union_0Union FromIChangeActorState(IChangeActorStateT _ichangeactorstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeActorState,
				Value = _ichangeactorstate
			};
		}

		// Token: 0x0602C6AA RID: 181930 RVA: 0x00613CA2 File Offset: 0x00611EA2
		public IChangeOtherStateT AsIChangeOtherState()
		{
			return this.As<IChangeOtherStateT>();
		}

		// Token: 0x0602C6AB RID: 181931 RVA: 0x00613CAA File Offset: 0x00611EAA
		public static IActionParams_Union_0Union FromIChangeOtherState(IChangeOtherStateT _ichangeotherstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeOtherState,
				Value = _ichangeotherstate
			};
		}

		// Token: 0x0602C6AC RID: 181932 RVA: 0x00613CC0 File Offset: 0x00611EC0
		public ISetCameraModeT AsISetCameraMode()
		{
			return this.As<ISetCameraModeT>();
		}

		// Token: 0x0602C6AD RID: 181933 RVA: 0x00613CC8 File Offset: 0x00611EC8
		public static IActionParams_Union_0Union FromISetCameraMode(ISetCameraModeT _isetcameramode)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetCameraMode,
				Value = _isetcameramode
			};
		}

		// Token: 0x0602C6AE RID: 181934 RVA: 0x00613CDE File Offset: 0x00611EDE
		public IModifySceneUiSubtitleT AsIModifySceneUiSubtitle()
		{
			return this.As<IModifySceneUiSubtitleT>();
		}

		// Token: 0x0602C6AF RID: 181935 RVA: 0x00613CE6 File Offset: 0x00611EE6
		public static IActionParams_Union_0Union FromIModifySceneUiSubtitle(IModifySceneUiSubtitleT _imodifysceneuisubtitle)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IModifySceneUiSubtitle,
				Value = _imodifysceneuisubtitle
			};
		}

		// Token: 0x0602C6B0 RID: 181936 RVA: 0x00613CFC File Offset: 0x00611EFC
		public ISetPlotModeT AsISetPlotMode()
		{
			return this.As<ISetPlotModeT>();
		}

		// Token: 0x0602C6B1 RID: 181937 RVA: 0x00613D04 File Offset: 0x00611F04
		public static IActionParams_Union_0Union FromISetPlotMode(ISetPlotModeT _isetplotmode)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetPlotMode,
				Value = _isetplotmode
			};
		}

		// Token: 0x0602C6B2 RID: 181938 RVA: 0x00613D1A File Offset: 0x00611F1A
		public IPlaySequenceDataT AsIPlaySequenceData()
		{
			return this.As<IPlaySequenceDataT>();
		}

		// Token: 0x0602C6B3 RID: 181939 RVA: 0x00613D22 File Offset: 0x00611F22
		public static IActionParams_Union_0Union FromIPlaySequenceData(IPlaySequenceDataT _iplaysequencedata)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlaySequenceData,
				Value = _iplaysequencedata
			};
		}

		// Token: 0x0602C6B4 RID: 181940 RVA: 0x00613D38 File Offset: 0x00611F38
		public IPlayCustomSequenceT AsIPlayCustomSequence()
		{
			return this.As<IPlayCustomSequenceT>();
		}

		// Token: 0x0602C6B5 RID: 181941 RVA: 0x00613D40 File Offset: 0x00611F40
		public static IActionParams_Union_0Union FromIPlayCustomSequence(IPlayCustomSequenceT _iplaycustomsequence)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayCustomSequence,
				Value = _iplaycustomsequence
			};
		}

		// Token: 0x0602C6B6 RID: 181942 RVA: 0x00613D56 File Offset: 0x00611F56
		public IPlayMovieT AsIPlayMovie()
		{
			return this.As<IPlayMovieT>();
		}

		// Token: 0x0602C6B7 RID: 181943 RVA: 0x00613D5E File Offset: 0x00611F5E
		public static IActionParams_Union_0Union FromIPlayMovie(IPlayMovieT _iplaymovie)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayMovie,
				Value = _iplaymovie
			};
		}

		// Token: 0x0602C6B8 RID: 181944 RVA: 0x00613D74 File Offset: 0x00611F74
		public IPlayEffectT AsIPlayEffect()
		{
			return this.As<IPlayEffectT>();
		}

		// Token: 0x0602C6B9 RID: 181945 RVA: 0x00613D7C File Offset: 0x00611F7C
		public static IActionParams_Union_0Union FromIPlayEffect(IPlayEffectT _iplayeffect)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayEffect,
				Value = _iplayeffect
			};
		}

		// Token: 0x0602C6BA RID: 181946 RVA: 0x00613D92 File Offset: 0x00611F92
		public IPlayEffect2T AsIPlayEffect2()
		{
			return this.As<IPlayEffect2T>();
		}

		// Token: 0x0602C6BB RID: 181947 RVA: 0x00613D9A File Offset: 0x00611F9A
		public static IActionParams_Union_0Union FromIPlayEffect2(IPlayEffect2T _iplayeffect2)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayEffect2,
				Value = _iplayeffect2
			};
		}

		// Token: 0x0602C6BC RID: 181948 RVA: 0x00613DB0 File Offset: 0x00611FB0
		public IPlayCommonEffectT AsIPlayCommonEffect()
		{
			return this.As<IPlayCommonEffectT>();
		}

		// Token: 0x0602C6BD RID: 181949 RVA: 0x00613DB8 File Offset: 0x00611FB8
		public static IActionParams_Union_0Union FromIPlayCommonEffect(IPlayCommonEffectT _iplaycommoneffect)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayCommonEffect,
				Value = _iplaycommoneffect
			};
		}

		// Token: 0x0602C6BE RID: 181950 RVA: 0x00613DCE File Offset: 0x00611FCE
		public IPlayScreenEffectT AsIPlayScreenEffect()
		{
			return this.As<IPlayScreenEffectT>();
		}

		// Token: 0x0602C6BF RID: 181951 RVA: 0x00613DD6 File Offset: 0x00611FD6
		public static IActionParams_Union_0Union FromIPlayScreenEffect(IPlayScreenEffectT _iplayscreeneffect)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayScreenEffect,
				Value = _iplayscreeneffect
			};
		}

		// Token: 0x0602C6C0 RID: 181952 RVA: 0x00613DEC File Offset: 0x00611FEC
		public ISwitchEffectStateT AsISwitchEffectState()
		{
			return this.As<ISwitchEffectStateT>();
		}

		// Token: 0x0602C6C1 RID: 181953 RVA: 0x00613DF4 File Offset: 0x00611FF4
		public static IActionParams_Union_0Union FromISwitchEffectState(ISwitchEffectStateT _iswitcheffectstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISwitchEffectState,
				Value = _iswitcheffectstate
			};
		}

		// Token: 0x0602C6C2 RID: 181954 RVA: 0x00613E0A File Offset: 0x0061200A
		public IPlayDissolveEffectT AsIPlayDissolveEffect()
		{
			return this.As<IPlayDissolveEffectT>();
		}

		// Token: 0x0602C6C3 RID: 181955 RVA: 0x00613E12 File Offset: 0x00612012
		public static IActionParams_Union_0Union FromIPlayDissolveEffect(IPlayDissolveEffectT _iplaydissolveeffect)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayDissolveEffect,
				Value = _iplaydissolveeffect
			};
		}

		// Token: 0x0602C6C4 RID: 181956 RVA: 0x00613E28 File Offset: 0x00612028
		public IPlayMpcEffectT AsIPlayMpcEffect()
		{
			return this.As<IPlayMpcEffectT>();
		}

		// Token: 0x0602C6C5 RID: 181957 RVA: 0x00613E30 File Offset: 0x00612030
		public static IActionParams_Union_0Union FromIPlayMpcEffect(IPlayMpcEffectT _iplaympceffect)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayMpcEffect,
				Value = _iplaympceffect
			};
		}

		// Token: 0x0602C6C6 RID: 181958 RVA: 0x00613E46 File Offset: 0x00612046
		public IRemoveEffectT AsIRemoveEffect()
		{
			return this.As<IRemoveEffectT>();
		}

		// Token: 0x0602C6C7 RID: 181959 RVA: 0x00613E4E File Offset: 0x0061204E
		public static IActionParams_Union_0Union FromIRemoveEffect(IRemoveEffectT _iremoveeffect)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRemoveEffect,
				Value = _iremoveeffect
			};
		}

		// Token: 0x0602C6C8 RID: 181960 RVA: 0x00613E64 File Offset: 0x00612064
		public IWaitT AsIWait()
		{
			return this.As<IWaitT>();
		}

		// Token: 0x0602C6C9 RID: 181961 RVA: 0x00613E6C File Offset: 0x0061206C
		public static IActionParams_Union_0Union FromIWait(IWaitT _iwait)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IWait,
				Value = _iwait
			};
		}

		// Token: 0x0602C6CA RID: 181962 RVA: 0x00613E82 File Offset: 0x00612082
		public IMoveToPosAT AsIMoveToPosA()
		{
			return this.As<IMoveToPosAT>();
		}

		// Token: 0x0602C6CB RID: 181963 RVA: 0x00613E8A File Offset: 0x0061208A
		public static IActionParams_Union_0Union FromIMoveToPosA(IMoveToPosAT _imovetoposa)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IMoveToPosA,
				Value = _imovetoposa
			};
		}

		// Token: 0x0602C6CC RID: 181964 RVA: 0x00613EA0 File Offset: 0x006120A0
		public ISetMoveSpeedT AsISetMoveSpeed()
		{
			return this.As<ISetMoveSpeedT>();
		}

		// Token: 0x0602C6CD RID: 181965 RVA: 0x00613EA8 File Offset: 0x006120A8
		public static IActionParams_Union_0Union FromISetMoveSpeed(ISetMoveSpeedT _isetmovespeed)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetMoveSpeed,
				Value = _isetmovespeed
			};
		}

		// Token: 0x0602C6CE RID: 181966 RVA: 0x00613EBE File Offset: 0x006120BE
		public ISetPosAT AsISetPosA()
		{
			return this.As<ISetPosAT>();
		}

		// Token: 0x0602C6CF RID: 181967 RVA: 0x00613EC6 File Offset: 0x006120C6
		public static IActionParams_Union_0Union FromISetPosA(ISetPosAT _isetposa)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetPosA,
				Value = _isetposa
			};
		}

		// Token: 0x0602C6D0 RID: 181968 RVA: 0x00613EDC File Offset: 0x006120DC
		public IFaceToPosT AsIFaceToPos()
		{
			return this.As<IFaceToPosT>();
		}

		// Token: 0x0602C6D1 RID: 181969 RVA: 0x00613EE4 File Offset: 0x006120E4
		public static IActionParams_Union_0Union FromIFaceToPos(IFaceToPosT _ifacetopos)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFaceToPos,
				Value = _ifacetopos
			};
		}

		// Token: 0x0602C6D2 RID: 181970 RVA: 0x00613EFA File Offset: 0x006120FA
		public ISpawnChildT AsISpawnChild()
		{
			return this.As<ISpawnChildT>();
		}

		// Token: 0x0602C6D3 RID: 181971 RVA: 0x00613F02 File Offset: 0x00612102
		public static IActionParams_Union_0Union FromISpawnChild(ISpawnChildT _ispawnchild)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISpawnChild,
				Value = _ispawnchild
			};
		}

		// Token: 0x0602C6D4 RID: 181972 RVA: 0x00613F18 File Offset: 0x00612118
		public ISimpleMoveT AsISimpleMove()
		{
			return this.As<ISimpleMoveT>();
		}

		// Token: 0x0602C6D5 RID: 181973 RVA: 0x00613F20 File Offset: 0x00612120
		public static IActionParams_Union_0Union FromISimpleMove(ISimpleMoveT _isimplemove)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISimpleMove,
				Value = _isimplemove
			};
		}

		// Token: 0x0602C6D6 RID: 181974 RVA: 0x00613F36 File Offset: 0x00612136
		public ISetNumberVarT AsISetNumberVar()
		{
			return this.As<ISetNumberVarT>();
		}

		// Token: 0x0602C6D7 RID: 181975 RVA: 0x00613F3E File Offset: 0x0061213E
		public static IActionParams_Union_0Union FromISetNumberVar(ISetNumberVarT _isetnumbervar)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetNumberVar,
				Value = _isetnumbervar
			};
		}

		// Token: 0x0602C6D8 RID: 181976 RVA: 0x00613F54 File Offset: 0x00612154
		public ISyncVarToActorStateT AsISyncVarToActorState()
		{
			return this.As<ISyncVarToActorStateT>();
		}

		// Token: 0x0602C6D9 RID: 181977 RVA: 0x00613F5C File Offset: 0x0061215C
		public static IActionParams_Union_0Union FromISyncVarToActorState(ISyncVarToActorStateT _isyncvartoactorstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISyncVarToActorState,
				Value = _isyncvartoactorstate
			};
		}

		// Token: 0x0602C6DA RID: 181978 RVA: 0x00613F72 File Offset: 0x00612172
		public IDoCalculateT AsIDoCalculate()
		{
			return this.As<IDoCalculateT>();
		}

		// Token: 0x0602C6DB RID: 181979 RVA: 0x00613F7A File Offset: 0x0061217A
		public static IActionParams_Union_0Union FromIDoCalculate(IDoCalculateT _idocalculate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IDoCalculate,
				Value = _idocalculate
			};
		}

		// Token: 0x0602C6DC RID: 181980 RVA: 0x00613F90 File Offset: 0x00612190
		public ICallByConditionT AsICallByCondition()
		{
			return this.As<ICallByConditionT>();
		}

		// Token: 0x0602C6DD RID: 181981 RVA: 0x00613F98 File Offset: 0x00612198
		public static IActionParams_Union_0Union FromICallByCondition(ICallByConditionT _icallbycondition)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICallByCondition,
				Value = _icallbycondition
			};
		}

		// Token: 0x0602C6DE RID: 181982 RVA: 0x00613FAE File Offset: 0x006121AE
		public ICallFunctionT AsICallFunction()
		{
			return this.As<ICallFunctionT>();
		}

		// Token: 0x0602C6DF RID: 181983 RVA: 0x00613FB6 File Offset: 0x006121B6
		public static IActionParams_Union_0Union FromICallFunction(ICallFunctionT _icallfunction)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICallFunction,
				Value = _icallfunction
			};
		}

		// Token: 0x0602C6E0 RID: 181984 RVA: 0x00613FCC File Offset: 0x006121CC
		public IAddFlowInteractOptionT AsIAddFlowInteractOption()
		{
			return this.As<IAddFlowInteractOptionT>();
		}

		// Token: 0x0602C6E1 RID: 181985 RVA: 0x00613FD4 File Offset: 0x006121D4
		public static IActionParams_Union_0Union FromIAddFlowInteractOption(IAddFlowInteractOptionT _iaddflowinteractoption)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAddFlowInteractOption,
				Value = _iaddflowinteractoption
			};
		}

		// Token: 0x0602C6E2 RID: 181986 RVA: 0x00613FEA File Offset: 0x006121EA
		public IRemoveFlowInteractOptionT AsIRemoveFlowInteractOption()
		{
			return this.As<IRemoveFlowInteractOptionT>();
		}

		// Token: 0x0602C6E3 RID: 181987 RVA: 0x00613FF2 File Offset: 0x006121F2
		public static IActionParams_Union_0Union FromIRemoveFlowInteractOption(IRemoveFlowInteractOptionT _iremoveflowinteractoption)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRemoveFlowInteractOption,
				Value = _iremoveflowinteractoption
			};
		}

		// Token: 0x0602C6E4 RID: 181988 RVA: 0x00614008 File Offset: 0x00612208
		public IChangeInteractOptionTextT AsIChangeInteractOptionText()
		{
			return this.As<IChangeInteractOptionTextT>();
		}

		// Token: 0x0602C6E5 RID: 181989 RVA: 0x00614010 File Offset: 0x00612210
		public static IActionParams_Union_0Union FromIChangeInteractOptionText(IChangeInteractOptionTextT _ichangeinteractoptiontext)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeInteractOptionText,
				Value = _ichangeinteractoptiontext
			};
		}

		// Token: 0x0602C6E6 RID: 181990 RVA: 0x00614026 File Offset: 0x00612226
		public ISpawnEntityT AsISpawnEntity()
		{
			return this.As<ISpawnEntityT>();
		}

		// Token: 0x0602C6E7 RID: 181991 RVA: 0x0061402E File Offset: 0x0061222E
		public static IActionParams_Union_0Union FromISpawnEntity(ISpawnEntityT _ispawnentity)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISpawnEntity,
				Value = _ispawnentity
			};
		}

		// Token: 0x0602C6E8 RID: 181992 RVA: 0x00614044 File Offset: 0x00612244
		public IDestroyAllChildT AsIDestroyAllChild()
		{
			return this.As<IDestroyAllChildT>();
		}

		// Token: 0x0602C6E9 RID: 181993 RVA: 0x0061404C File Offset: 0x0061224C
		public static IActionParams_Union_0Union FromIDestroyAllChild(IDestroyAllChildT _idestroyallchild)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IDestroyAllChild,
				Value = _idestroyallchild
			};
		}

		// Token: 0x0602C6EA RID: 181994 RVA: 0x00614062 File Offset: 0x00612262
		public IDestroyEntityT AsIDestroyEntity()
		{
			return this.As<IDestroyEntityT>();
		}

		// Token: 0x0602C6EB RID: 181995 RVA: 0x0061406A File Offset: 0x0061226A
		public static IActionParams_Union_0Union FromIDestroyEntity(IDestroyEntityT _idestroyentity)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IDestroyEntity,
				Value = _idestroyentity
			};
		}

		// Token: 0x0602C6EC RID: 181996 RVA: 0x00614080 File Offset: 0x00612280
		public IPlayFlowT AsIPlayFlow()
		{
			return this.As<IPlayFlowT>();
		}

		// Token: 0x0602C6ED RID: 181997 RVA: 0x00614088 File Offset: 0x00612288
		public static IActionParams_Union_0Union FromIPlayFlow(IPlayFlowT _iplayflow)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayFlow,
				Value = _iplayflow
			};
		}

		// Token: 0x0602C6EE RID: 181998 RVA: 0x0061409E File Offset: 0x0061229E
		public IBubbleDataT AsIBubbleData()
		{
			return this.As<IBubbleDataT>();
		}

		// Token: 0x0602C6EF RID: 181999 RVA: 0x006140A6 File Offset: 0x006122A6
		public static IActionParams_Union_0Union FromIBubbleData(IBubbleDataT _ibubbledata)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IBubbleData,
				Value = _ibubbledata
			};
		}

		// Token: 0x0602C6F0 RID: 182000 RVA: 0x006140BC File Offset: 0x006122BC
		public IPlayerLookAtT AsIPlayerLookAt()
		{
			return this.As<IPlayerLookAtT>();
		}

		// Token: 0x0602C6F1 RID: 182001 RVA: 0x006140C4 File Offset: 0x006122C4
		public static IActionParams_Union_0Union FromIPlayerLookAt(IPlayerLookAtT _iplayerlookat)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayerLookAt,
				Value = _iplayerlookat
			};
		}

		// Token: 0x0602C6F2 RID: 182002 RVA: 0x006140DA File Offset: 0x006122DA
		public IEntityLookAtT AsIEntityLookAt()
		{
			return this.As<IEntityLookAtT>();
		}

		// Token: 0x0602C6F3 RID: 182003 RVA: 0x006140E2 File Offset: 0x006122E2
		public static IActionParams_Union_0Union FromIEntityLookAt(IEntityLookAtT _ientitylookat)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEntityLookAt,
				Value = _ientitylookat
			};
		}

		// Token: 0x0602C6F4 RID: 182004 RVA: 0x006140F8 File Offset: 0x006122F8
		public ICharacterLookAtT AsICharacterLookAt()
		{
			return this.As<ICharacterLookAtT>();
		}

		// Token: 0x0602C6F5 RID: 182005 RVA: 0x00614100 File Offset: 0x00612300
		public static IActionParams_Union_0Union FromICharacterLookAt(ICharacterLookAtT _icharacterlookat)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICharacterLookAt,
				Value = _icharacterlookat
			};
		}

		// Token: 0x0602C6F6 RID: 182006 RVA: 0x00614116 File Offset: 0x00612316
		public IPlayerLookTowardsT AsIPlayerLookTowards()
		{
			return this.As<IPlayerLookTowardsT>();
		}

		// Token: 0x0602C6F7 RID: 182007 RVA: 0x0061411E File Offset: 0x0061231E
		public static IActionParams_Union_0Union FromIPlayerLookTowards(IPlayerLookTowardsT _iplayerlooktowards)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayerLookTowards,
				Value = _iplayerlooktowards
			};
		}

		// Token: 0x0602C6F8 RID: 182008 RVA: 0x00614134 File Offset: 0x00612334
		public IEntityTurnToT AsIEntityTurnTo()
		{
			return this.As<IEntityTurnToT>();
		}

		// Token: 0x0602C6F9 RID: 182009 RVA: 0x0061413C File Offset: 0x0061233C
		public static IActionParams_Union_0Union FromIEntityTurnTo(IEntityTurnToT _ientityturnto)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEntityTurnTo,
				Value = _ientityturnto
			};
		}

		// Token: 0x0602C6FA RID: 182010 RVA: 0x00614152 File Offset: 0x00612352
		public ICameraLookAtT AsICameraLookAt()
		{
			return this.As<ICameraLookAtT>();
		}

		// Token: 0x0602C6FB RID: 182011 RVA: 0x0061415A File Offset: 0x0061235A
		public static IActionParams_Union_0Union FromICameraLookAt(ICameraLookAtT _icameralookat)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICameraLookAt,
				Value = _icameralookat
			};
		}

		// Token: 0x0602C6FC RID: 182012 RVA: 0x00614170 File Offset: 0x00612370
		public IStopCameraLookAtT AsIStopCameraLookAt()
		{
			return this.As<IStopCameraLookAtT>();
		}

		// Token: 0x0602C6FD RID: 182013 RVA: 0x00614178 File Offset: 0x00612378
		public static IActionParams_Union_0Union FromIStopCameraLookAt(IStopCameraLookAtT _istopcameralookat)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IStopCameraLookAt,
				Value = _istopcameralookat
			};
		}

		// Token: 0x0602C6FE RID: 182014 RVA: 0x0061418E File Offset: 0x0061238E
		public ISetVarT AsISetVar()
		{
			return this.As<ISetVarT>();
		}

		// Token: 0x0602C6FF RID: 182015 RVA: 0x00614196 File Offset: 0x00612396
		public static IActionParams_Union_0Union FromISetVar(ISetVarT _isetvar)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetVar,
				Value = _isetvar
			};
		}

		// Token: 0x0602C700 RID: 182016 RVA: 0x006141AC File Offset: 0x006123AC
		public ISetActorVarT AsISetActorVar()
		{
			return this.As<ISetActorVarT>();
		}

		// Token: 0x0602C701 RID: 182017 RVA: 0x006141B4 File Offset: 0x006123B4
		public static IActionParams_Union_0Union FromISetActorVar(ISetActorVarT _isetactorvar)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetActorVar,
				Value = _isetactorvar
			};
		}

		// Token: 0x0602C702 RID: 182018 RVA: 0x006141CA File Offset: 0x006123CA
		public ICalculateVarT AsICalculateVar()
		{
			return this.As<ICalculateVarT>();
		}

		// Token: 0x0602C703 RID: 182019 RVA: 0x006141D2 File Offset: 0x006123D2
		public static IActionParams_Union_0Union FromICalculateVar(ICalculateVarT _icalculatevar)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICalculateVar,
				Value = _icalculatevar
			};
		}

		// Token: 0x0602C704 RID: 182020 RVA: 0x006141E8 File Offset: 0x006123E8
		public IRandomVarT AsIRandomVar()
		{
			return this.As<IRandomVarT>();
		}

		// Token: 0x0602C705 RID: 182021 RVA: 0x006141F0 File Offset: 0x006123F0
		public static IActionParams_Union_0Union FromIRandomVar(IRandomVarT _irandomvar)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRandomVar,
				Value = _irandomvar
			};
		}

		// Token: 0x0602C706 RID: 182022 RVA: 0x00614206 File Offset: 0x00612406
		public IGuideTriggerT AsIGuideTrigger()
		{
			return this.As<IGuideTriggerT>();
		}

		// Token: 0x0602C707 RID: 182023 RVA: 0x0061420E File Offset: 0x0061240E
		public static IActionParams_Union_0Union FromIGuideTrigger(IGuideTriggerT _iguidetrigger)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IGuideTrigger,
				Value = _iguidetrigger
			};
		}

		// Token: 0x0602C708 RID: 182024 RVA: 0x00614224 File Offset: 0x00612424
		public ICompleteGuideT AsICompleteGuide()
		{
			return this.As<ICompleteGuideT>();
		}

		// Token: 0x0602C709 RID: 182025 RVA: 0x0061422C File Offset: 0x0061242C
		public static IActionParams_Union_0Union FromICompleteGuide(ICompleteGuideT _icompleteguide)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICompleteGuide,
				Value = _icompleteguide
			};
		}

		// Token: 0x0602C70A RID: 182026 RVA: 0x00614242 File Offset: 0x00612442
		public IGetItemT AsIGetItem()
		{
			return this.As<IGetItemT>();
		}

		// Token: 0x0602C70B RID: 182027 RVA: 0x0061424A File Offset: 0x0061244A
		public static IActionParams_Union_0Union FromIGetItem(IGetItemT _igetitem)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IGetItem,
				Value = _igetitem
			};
		}

		// Token: 0x0602C70C RID: 182028 RVA: 0x00614260 File Offset: 0x00612460
		public IDestroyQuestItemT AsIDestroyQuestItem()
		{
			return this.As<IDestroyQuestItemT>();
		}

		// Token: 0x0602C70D RID: 182029 RVA: 0x00614268 File Offset: 0x00612468
		public static IActionParams_Union_0Union FromIDestroyQuestItem(IDestroyQuestItemT _idestroyquestitem)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IDestroyQuestItem,
				Value = _idestroyquestitem
			};
		}

		// Token: 0x0602C70E RID: 182030 RVA: 0x0061427E File Offset: 0x0061247E
		public IAwakeEntityT AsIAwakeEntity()
		{
			return this.As<IAwakeEntityT>();
		}

		// Token: 0x0602C70F RID: 182031 RVA: 0x00614286 File Offset: 0x00612486
		public static IActionParams_Union_0Union FromIAwakeEntity(IAwakeEntityT _iawakeentity)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAwakeEntity,
				Value = _iawakeentity
			};
		}

		// Token: 0x0602C710 RID: 182032 RVA: 0x0061429C File Offset: 0x0061249C
		public ISetEntityVisibleT AsISetEntityVisible()
		{
			return this.As<ISetEntityVisibleT>();
		}

		// Token: 0x0602C711 RID: 182033 RVA: 0x006142A4 File Offset: 0x006124A4
		public static IActionParams_Union_0Union FromISetEntityVisible(ISetEntityVisibleT _isetentityvisible)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetEntityVisible,
				Value = _isetentityvisible
			};
		}

		// Token: 0x0602C712 RID: 182034 RVA: 0x006142BA File Offset: 0x006124BA
		public ISetEntityClientVisibleT AsISetEntityClientVisible()
		{
			return this.As<ISetEntityClientVisibleT>();
		}

		// Token: 0x0602C713 RID: 182035 RVA: 0x006142C2 File Offset: 0x006124C2
		public static IActionParams_Union_0Union FromISetEntityClientVisible(ISetEntityClientVisibleT _isetentityclientvisible)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetEntityClientVisible,
				Value = _isetentityclientvisible
			};
		}

		// Token: 0x0602C714 RID: 182036 RVA: 0x006142D8 File Offset: 0x006124D8
		public ISetEntityClientVisibleSaveT AsISetEntityClientVisibleSave()
		{
			return this.As<ISetEntityClientVisibleSaveT>();
		}

		// Token: 0x0602C715 RID: 182037 RVA: 0x006142E0 File Offset: 0x006124E0
		public static IActionParams_Union_0Union FromISetEntityClientVisibleSave(ISetEntityClientVisibleSaveT _isetentityclientvisiblesave)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetEntityClientVisibleSave,
				Value = _isetentityclientvisiblesave
			};
		}

		// Token: 0x0602C716 RID: 182038 RVA: 0x006142F6 File Offset: 0x006124F6
		public ILockEntityT AsILockEntity()
		{
			return this.As<ILockEntityT>();
		}

		// Token: 0x0602C717 RID: 182039 RVA: 0x006142FE File Offset: 0x006124FE
		public static IActionParams_Union_0Union FromILockEntity(ILockEntityT _ilockentity)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ILockEntity,
				Value = _ilockentity
			};
		}

		// Token: 0x0602C718 RID: 182040 RVA: 0x00614314 File Offset: 0x00612514
		public IUnlockEntityT AsIUnlockEntity()
		{
			return this.As<IUnlockEntityT>();
		}

		// Token: 0x0602C719 RID: 182041 RVA: 0x0061431C File Offset: 0x0061251C
		public static IActionParams_Union_0Union FromIUnlockEntity(IUnlockEntityT _iunlockentity)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IUnlockEntity,
				Value = _iunlockentity
			};
		}

		// Token: 0x0602C71A RID: 182042 RVA: 0x00614332 File Offset: 0x00612532
		public ICompleteChildQuestT AsICompleteChildQuest()
		{
			return this.As<ICompleteChildQuestT>();
		}

		// Token: 0x0602C71B RID: 182043 RVA: 0x0061433A File Offset: 0x0061253A
		public static IActionParams_Union_0Union FromICompleteChildQuest(ICompleteChildQuestT _icompletechildquest)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICompleteChildQuest,
				Value = _icompletechildquest
			};
		}

		// Token: 0x0602C71C RID: 182044 RVA: 0x00614350 File Offset: 0x00612550
		public IAcceptCurrentQuestT AsIAcceptCurrentQuest()
		{
			return this.As<IAcceptCurrentQuestT>();
		}

		// Token: 0x0602C71D RID: 182045 RVA: 0x00614358 File Offset: 0x00612558
		public static IActionParams_Union_0Union FromIAcceptCurrentQuest(IAcceptCurrentQuestT _iacceptcurrentquest)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAcceptCurrentQuest,
				Value = _iacceptcurrentquest
			};
		}

		// Token: 0x0602C71E RID: 182046 RVA: 0x0061436E File Offset: 0x0061256E
		public IFinishDoInteractT AsIFinishDoInteract()
		{
			return this.As<IFinishDoInteractT>();
		}

		// Token: 0x0602C71F RID: 182047 RVA: 0x00614376 File Offset: 0x00612576
		public static IActionParams_Union_0Union FromIFinishDoInteract(IFinishDoInteractT _ifinishdointeract)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFinishDoInteract,
				Value = _ifinishdointeract
			};
		}

		// Token: 0x0602C720 RID: 182048 RVA: 0x0061438C File Offset: 0x0061258C
		public IModifyEntityDecorationT AsIModifyEntityDecoration()
		{
			return this.As<IModifyEntityDecorationT>();
		}

		// Token: 0x0602C721 RID: 182049 RVA: 0x00614394 File Offset: 0x00612594
		public static IActionParams_Union_0Union FromIModifyEntityDecoration(IModifyEntityDecorationT _imodifyentitydecoration)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IModifyEntityDecoration,
				Value = _imodifyentitydecoration
			};
		}

		// Token: 0x0602C722 RID: 182050 RVA: 0x006143AA File Offset: 0x006125AA
		public IAddBuffToEntityT AsIAddBuffToEntity()
		{
			return this.As<IAddBuffToEntityT>();
		}

		// Token: 0x0602C723 RID: 182051 RVA: 0x006143B2 File Offset: 0x006125B2
		public static IActionParams_Union_0Union FromIAddBuffToEntity(IAddBuffToEntityT _iaddbufftoentity)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAddBuffToEntity,
				Value = _iaddbufftoentity
			};
		}

		// Token: 0x0602C724 RID: 182052 RVA: 0x006143C8 File Offset: 0x006125C8
		public IAddBuffToPlayerT AsIAddBuffToPlayer()
		{
			return this.As<IAddBuffToPlayerT>();
		}

		// Token: 0x0602C725 RID: 182053 RVA: 0x006143D0 File Offset: 0x006125D0
		public static IActionParams_Union_0Union FromIAddBuffToPlayer(IAddBuffToPlayerT _iaddbufftoplayer)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAddBuffToPlayer,
				Value = _iaddbufftoplayer
			};
		}

		// Token: 0x0602C726 RID: 182054 RVA: 0x006143E6 File Offset: 0x006125E6
		public IAddBuffToFollowShooterT AsIAddBuffToFollowShooter()
		{
			return this.As<IAddBuffToFollowShooterT>();
		}

		// Token: 0x0602C727 RID: 182055 RVA: 0x006143EE File Offset: 0x006125EE
		public static IActionParams_Union_0Union FromIAddBuffToFollowShooter(IAddBuffToFollowShooterT _iaddbufftofollowshooter)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAddBuffToFollowShooter,
				Value = _iaddbufftofollowshooter
			};
		}

		// Token: 0x0602C728 RID: 182056 RVA: 0x00614404 File Offset: 0x00612604
		public IOpenSystemBoardT AsIOpenSystemBoard()
		{
			return this.As<IOpenSystemBoardT>();
		}

		// Token: 0x0602C729 RID: 182057 RVA: 0x0061440C File Offset: 0x0061260C
		public static IActionParams_Union_0Union FromIOpenSystemBoard(IOpenSystemBoardT _iopensystemboard)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IOpenSystemBoard,
				Value = _iopensystemboard
			};
		}

		// Token: 0x0602C72A RID: 182058 RVA: 0x00614422 File Offset: 0x00612622
		public IOpenSystemFunctionT AsIOpenSystemFunction()
		{
			return this.As<IOpenSystemFunctionT>();
		}

		// Token: 0x0602C72B RID: 182059 RVA: 0x0061442A File Offset: 0x0061262A
		public static IActionParams_Union_0Union FromIOpenSystemFunction(IOpenSystemFunctionT _iopensystemfunction)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IOpenSystemFunction,
				Value = _iopensystemfunction
			};
		}

		// Token: 0x0602C72C RID: 182060 RVA: 0x00614440 File Offset: 0x00612640
		public IChangeEntityStateT AsIChangeEntityState()
		{
			return this.As<IChangeEntityStateT>();
		}

		// Token: 0x0602C72D RID: 182061 RVA: 0x00614448 File Offset: 0x00612648
		public static IActionParams_Union_0Union FromIChangeEntityState(IChangeEntityStateT _ichangeentitystate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeEntityState,
				Value = _ichangeentitystate
			};
		}

		// Token: 0x0602C72E RID: 182062 RVA: 0x0061445E File Offset: 0x0061265E
		public IChangeEntityStateDirectlyT AsIChangeEntityStateDirectly()
		{
			return this.As<IChangeEntityStateDirectlyT>();
		}

		// Token: 0x0602C72F RID: 182063 RVA: 0x00614466 File Offset: 0x00612666
		public static IActionParams_Union_0Union FromIChangeEntityStateDirectly(IChangeEntityStateDirectlyT _ichangeentitystatedirectly)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeEntityStateDirectly,
				Value = _ichangeentitystatedirectly
			};
		}

		// Token: 0x0602C730 RID: 182064 RVA: 0x0061447C File Offset: 0x0061267C
		public IChangeEntityStateBatchDirectlyT AsIChangeEntityStateBatchDirectly()
		{
			return this.As<IChangeEntityStateBatchDirectlyT>();
		}

		// Token: 0x0602C731 RID: 182065 RVA: 0x00614484 File Offset: 0x00612684
		public static IActionParams_Union_0Union FromIChangeEntityStateBatchDirectly(IChangeEntityStateBatchDirectlyT _ichangeentitystatebatchdirectly)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeEntityStateBatchDirectly,
				Value = _ichangeentitystatebatchdirectly
			};
		}

		// Token: 0x0602C732 RID: 182066 RVA: 0x0061449A File Offset: 0x0061269A
		public IChangeEntityStateLoopT AsIChangeEntityStateLoop()
		{
			return this.As<IChangeEntityStateLoopT>();
		}

		// Token: 0x0602C733 RID: 182067 RVA: 0x006144A2 File Offset: 0x006126A2
		public static IActionParams_Union_0Union FromIChangeEntityStateLoop(IChangeEntityStateLoopT _ichangeentitystateloop)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeEntityStateLoop,
				Value = _ichangeentitystateloop
			};
		}

		// Token: 0x0602C734 RID: 182068 RVA: 0x006144B8 File Offset: 0x006126B8
		public IChangeNpcPerformStateT AsIChangeNpcPerformState()
		{
			return this.As<IChangeNpcPerformStateT>();
		}

		// Token: 0x0602C735 RID: 182069 RVA: 0x006144C0 File Offset: 0x006126C0
		public static IActionParams_Union_0Union FromIChangeNpcPerformState(IChangeNpcPerformStateT _ichangenpcperformstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeNpcPerformState,
				Value = _ichangenpcperformstate
			};
		}

		// Token: 0x0602C736 RID: 182070 RVA: 0x006144D6 File Offset: 0x006126D6
		public ISetForceLockT AsISetForceLock()
		{
			return this.As<ISetForceLockT>();
		}

		// Token: 0x0602C737 RID: 182071 RVA: 0x006144DE File Offset: 0x006126DE
		public static IActionParams_Union_0Union FromISetForceLock(ISetForceLockT _isetforcelock)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetForceLock,
				Value = _isetforcelock
			};
		}

		// Token: 0x0602C738 RID: 182072 RVA: 0x006144F4 File Offset: 0x006126F4
		public ISetAreaStateT AsISetAreaState()
		{
			return this.As<ISetAreaStateT>();
		}

		// Token: 0x0602C739 RID: 182073 RVA: 0x006144FC File Offset: 0x006126FC
		public static IActionParams_Union_0Union FromISetAreaState(ISetAreaStateT _isetareastate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetAreaState,
				Value = _isetareastate
			};
		}

		// Token: 0x0602C73A RID: 182074 RVA: 0x00614512 File Offset: 0x00612712
		public ISetWuYinQuStateT AsISetWuYinQuState()
		{
			return this.As<ISetWuYinQuStateT>();
		}

		// Token: 0x0602C73B RID: 182075 RVA: 0x0061451A File Offset: 0x0061271A
		public static IActionParams_Union_0Union FromISetWuYinQuState(ISetWuYinQuStateT _isetwuyinqustate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetWuYinQuState,
				Value = _isetwuyinqustate
			};
		}

		// Token: 0x0602C73C RID: 182076 RVA: 0x00614530 File Offset: 0x00612730
		public IRemoveBuffFromEntityT AsIRemoveBuffFromEntity()
		{
			return this.As<IRemoveBuffFromEntityT>();
		}

		// Token: 0x0602C73D RID: 182077 RVA: 0x00614538 File Offset: 0x00612738
		public static IActionParams_Union_0Union FromIRemoveBuffFromEntity(IRemoveBuffFromEntityT _iremovebufffromentity)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRemoveBuffFromEntity,
				Value = _iremovebufffromentity
			};
		}

		// Token: 0x0602C73E RID: 182078 RVA: 0x0061454E File Offset: 0x0061274E
		public IRemoveBuffFromPlayerT AsIRemoveBuffFromPlayer()
		{
			return this.As<IRemoveBuffFromPlayerT>();
		}

		// Token: 0x0602C73F RID: 182079 RVA: 0x00614556 File Offset: 0x00612756
		public static IActionParams_Union_0Union FromIRemoveBuffFromPlayer(IRemoveBuffFromPlayerT _iremovebufffromplayer)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRemoveBuffFromPlayer,
				Value = _iremovebufffromplayer
			};
		}

		// Token: 0x0602C740 RID: 182080 RVA: 0x0061456C File Offset: 0x0061276C
		public ICollectT AsICollect()
		{
			return this.As<ICollectT>();
		}

		// Token: 0x0602C741 RID: 182081 RVA: 0x00614574 File Offset: 0x00612774
		public static IActionParams_Union_0Union FromICollect(ICollectT _icollect)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICollect,
				Value = _icollect
			};
		}

		// Token: 0x0602C742 RID: 182082 RVA: 0x0061458A File Offset: 0x0061278A
		public IDestroyT AsIDestroy()
		{
			return this.As<IDestroyT>();
		}

		// Token: 0x0602C743 RID: 182083 RVA: 0x00614592 File Offset: 0x00612792
		public static IActionParams_Union_0Union FromIDestroy(IDestroyT _idestroy)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IDestroy,
				Value = _idestroy
			};
		}

		// Token: 0x0602C744 RID: 182084 RVA: 0x006145A8 File Offset: 0x006127A8
		public IDestroySelfT AsIDestroySelf()
		{
			return this.As<IDestroySelfT>();
		}

		// Token: 0x0602C745 RID: 182085 RVA: 0x006145B0 File Offset: 0x006127B0
		public static IActionParams_Union_0Union FromIDestroySelf(IDestroySelfT _idestroyself)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IDestroySelf,
				Value = _idestroyself
			};
		}

		// Token: 0x0602C746 RID: 182086 RVA: 0x006145C6 File Offset: 0x006127C6
		public ISetPlayerMoveControlT AsISetPlayerMoveControl()
		{
			return this.As<ISetPlayerMoveControlT>();
		}

		// Token: 0x0602C747 RID: 182087 RVA: 0x006145CE File Offset: 0x006127CE
		public static IActionParams_Union_0Union FromISetPlayerMoveControl(ISetPlayerMoveControlT _isetplayermovecontrol)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetPlayerMoveControl,
				Value = _isetplayermovecontrol
			};
		}

		// Token: 0x0602C748 RID: 182088 RVA: 0x006145E4 File Offset: 0x006127E4
		public IUnlockTeleportTriggerT AsIUnlockTeleportTrigger()
		{
			return this.As<IUnlockTeleportTriggerT>();
		}

		// Token: 0x0602C749 RID: 182089 RVA: 0x006145EC File Offset: 0x006127EC
		public static IActionParams_Union_0Union FromIUnlockTeleportTrigger(IUnlockTeleportTriggerT _iunlockteleporttrigger)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IUnlockTeleportTrigger,
				Value = _iunlockteleporttrigger
			};
		}

		// Token: 0x0602C74A RID: 182090 RVA: 0x00614602 File Offset: 0x00612802
		public IChangeTeamPositionT AsIChangeTeamPosition()
		{
			return this.As<IChangeTeamPositionT>();
		}

		// Token: 0x0602C74B RID: 182091 RVA: 0x0061460A File Offset: 0x0061280A
		public static IActionParams_Union_0Union FromIChangeTeamPosition(IChangeTeamPositionT _ichangeteamposition)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeTeamPosition,
				Value = _ichangeteamposition
			};
		}

		// Token: 0x0602C74C RID: 182092 RVA: 0x00614620 File Offset: 0x00612820
		public IClientChangeTeamPositionT AsIClientChangeTeamPosition()
		{
			return this.As<IClientChangeTeamPositionT>();
		}

		// Token: 0x0602C74D RID: 182093 RVA: 0x00614628 File Offset: 0x00612828
		public static IActionParams_Union_0Union FromIClientChangeTeamPosition(IClientChangeTeamPositionT _iclientchangeteamposition)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IClientChangeTeamPosition,
				Value = _iclientchangeteamposition
			};
		}

		// Token: 0x0602C74E RID: 182094 RVA: 0x0061463E File Offset: 0x0061283E
		public IClaimLevelPlayRewardT AsIClaimLevelPlayReward()
		{
			return this.As<IClaimLevelPlayRewardT>();
		}

		// Token: 0x0602C74F RID: 182095 RVA: 0x00614646 File Offset: 0x00612846
		public static IActionParams_Union_0Union FromIClaimLevelPlayReward(IClaimLevelPlayRewardT _iclaimlevelplayreward)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IClaimLevelPlayReward,
				Value = _iclaimlevelplayreward
			};
		}

		// Token: 0x0602C750 RID: 182096 RVA: 0x0061465C File Offset: 0x0061285C
		public IClaimDynamicEntityRewardT AsIClaimDynamicEntityReward()
		{
			return this.As<IClaimDynamicEntityRewardT>();
		}

		// Token: 0x0602C751 RID: 182097 RVA: 0x00614664 File Offset: 0x00612864
		public static IActionParams_Union_0Union FromIClaimDynamicEntityReward(IClaimDynamicEntityRewardT _iclaimdynamicentityreward)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IClaimDynamicEntityReward,
				Value = _iclaimdynamicentityreward
			};
		}

		// Token: 0x0602C752 RID: 182098 RVA: 0x0061467A File Offset: 0x0061287A
		public IClearFishingCabinInSaleItemsT AsIClearFishingCabinInSaleItems()
		{
			return this.As<IClearFishingCabinInSaleItemsT>();
		}

		// Token: 0x0602C753 RID: 182099 RVA: 0x00614682 File Offset: 0x00612882
		public static IActionParams_Union_0Union FromIClearFishingCabinInSaleItems(IClearFishingCabinInSaleItemsT _iclearfishingcabininsaleitems)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IClearFishingCabinInSaleItems,
				Value = _iclearfishingcabininsaleitems
			};
		}

		// Token: 0x0602C754 RID: 182100 RVA: 0x00614698 File Offset: 0x00612898
		public IAcceptFishingEntrustT AsIAcceptFishingEntrust()
		{
			return this.As<IAcceptFishingEntrustT>();
		}

		// Token: 0x0602C755 RID: 182101 RVA: 0x006146A0 File Offset: 0x006128A0
		public static IActionParams_Union_0Union FromIAcceptFishingEntrust(IAcceptFishingEntrustT _iacceptfishingentrust)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAcceptFishingEntrust,
				Value = _iacceptfishingentrust
			};
		}

		// Token: 0x0602C756 RID: 182102 RVA: 0x006146B9 File Offset: 0x006128B9
		public IDestroyFishingBoatT AsIDestroyFishingBoat()
		{
			return this.As<IDestroyFishingBoatT>();
		}

		// Token: 0x0602C757 RID: 182103 RVA: 0x006146C1 File Offset: 0x006128C1
		public static IActionParams_Union_0Union FromIDestroyFishingBoat(IDestroyFishingBoatT _idestroyfishingboat)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IDestroyFishingBoat,
				Value = _idestroyfishingboat
			};
		}

		// Token: 0x0602C758 RID: 182104 RVA: 0x006146DA File Offset: 0x006128DA
		public ITeleportDungeonT AsITeleportDungeon()
		{
			return this.As<ITeleportDungeonT>();
		}

		// Token: 0x0602C759 RID: 182105 RVA: 0x006146E2 File Offset: 0x006128E2
		public static IActionParams_Union_0Union FromITeleportDungeon(ITeleportDungeonT _iteleportdungeon)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ITeleportDungeon,
				Value = _iteleportdungeon
			};
		}

		// Token: 0x0602C75A RID: 182106 RVA: 0x006146FB File Offset: 0x006128FB
		public IStopUiScreenEffectT AsIStopUiScreenEffect()
		{
			return this.As<IStopUiScreenEffectT>();
		}

		// Token: 0x0602C75B RID: 182107 RVA: 0x00614703 File Offset: 0x00612903
		public static IActionParams_Union_0Union FromIStopUiScreenEffect(IStopUiScreenEffectT _istopuiscreeneffect)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IStopUiScreenEffect,
				Value = _istopuiscreeneffect
			};
		}

		// Token: 0x0602C75C RID: 182108 RVA: 0x0061471C File Offset: 0x0061291C
		public IClaimDungeonRewardT AsIClaimDungeonReward()
		{
			return this.As<IClaimDungeonRewardT>();
		}

		// Token: 0x0602C75D RID: 182109 RVA: 0x00614724 File Offset: 0x00612924
		public static IActionParams_Union_0Union FromIClaimDungeonReward(IClaimDungeonRewardT _iclaimdungeonreward)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IClaimDungeonReward,
				Value = _iclaimdungeonreward
			};
		}

		// Token: 0x0602C75E RID: 182110 RVA: 0x0061473D File Offset: 0x0061293D
		public ISettlementDungeonT AsISettlementDungeon()
		{
			return this.As<ISettlementDungeonT>();
		}

		// Token: 0x0602C75F RID: 182111 RVA: 0x00614745 File Offset: 0x00612945
		public static IActionParams_Union_0Union FromISettlementDungeon(ISettlementDungeonT _isettlementdungeon)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISettlementDungeon,
				Value = _isettlementdungeon
			};
		}

		// Token: 0x0602C760 RID: 182112 RVA: 0x0061475E File Offset: 0x0061295E
		public IExitDungeonT AsIExitDungeon()
		{
			return this.As<IExitDungeonT>();
		}

		// Token: 0x0602C761 RID: 182113 RVA: 0x00614766 File Offset: 0x00612966
		public static IActionParams_Union_0Union FromIExitDungeon(IExitDungeonT _iexitdungeon)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IExitDungeon,
				Value = _iexitdungeon
			};
		}

		// Token: 0x0602C762 RID: 182114 RVA: 0x0061477F File Offset: 0x0061297F
		public IUnlockDungeonEntryT AsIUnlockDungeonEntry()
		{
			return this.As<IUnlockDungeonEntryT>();
		}

		// Token: 0x0602C763 RID: 182115 RVA: 0x00614787 File Offset: 0x00612987
		public static IActionParams_Union_0Union FromIUnlockDungeonEntry(IUnlockDungeonEntryT _iunlockdungeonentry)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IUnlockDungeonEntry,
				Value = _iunlockdungeonentry
			};
		}

		// Token: 0x0602C764 RID: 182116 RVA: 0x006147A0 File Offset: 0x006129A0
		public IFinishDungeonT AsIFinishDungeon()
		{
			return this.As<IFinishDungeonT>();
		}

		// Token: 0x0602C765 RID: 182117 RVA: 0x006147A8 File Offset: 0x006129A8
		public static IActionParams_Union_0Union FromIFinishDungeon(IFinishDungeonT _ifinishdungeon)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFinishDungeon,
				Value = _ifinishdungeon
			};
		}

		// Token: 0x0602C766 RID: 182118 RVA: 0x006147C1 File Offset: 0x006129C1
		public ISetReviveRegionT AsISetReviveRegion()
		{
			return this.As<ISetReviveRegionT>();
		}

		// Token: 0x0602C767 RID: 182119 RVA: 0x006147C9 File Offset: 0x006129C9
		public static IActionParams_Union_0Union FromISetReviveRegion(ISetReviveRegionT _isetreviveregion)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetReviveRegion,
				Value = _isetreviveregion
			};
		}

		// Token: 0x0602C768 RID: 182120 RVA: 0x006147E2 File Offset: 0x006129E2
		public IPromptQuestChapterUIT AsIPromptQuestChapterUI()
		{
			return this.As<IPromptQuestChapterUIT>();
		}

		// Token: 0x0602C769 RID: 182121 RVA: 0x006147EA File Offset: 0x006129EA
		public static IActionParams_Union_0Union FromIPromptQuestChapterUI(IPromptQuestChapterUIT _ipromptquestchapterui)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPromptQuestChapterUI,
				Value = _ipromptquestchapterui
			};
		}

		// Token: 0x0602C76A RID: 182122 RVA: 0x00614803 File Offset: 0x00612A03
		public IFireBulletT AsIFireBullet()
		{
			return this.As<IFireBulletT>();
		}

		// Token: 0x0602C76B RID: 182123 RVA: 0x0061480B File Offset: 0x00612A0B
		public static IActionParams_Union_0Union FromIFireBullet(IFireBulletT _ifirebullet)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFireBullet,
				Value = _ifirebullet
			};
		}

		// Token: 0x0602C76C RID: 182124 RVA: 0x00614824 File Offset: 0x00612A24
		public IFireBulletEffectT AsIFireBulletEffect()
		{
			return this.As<IFireBulletEffectT>();
		}

		// Token: 0x0602C76D RID: 182125 RVA: 0x0061482C File Offset: 0x00612A2C
		public static IActionParams_Union_0Union FromIFireBulletEffect(IFireBulletEffectT _ifirebulleteffect)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFireBulletEffect,
				Value = _ifirebulleteffect
			};
		}

		// Token: 0x0602C76E RID: 182126 RVA: 0x00614845 File Offset: 0x00612A45
		public ISetAssistCharacterPosT AsISetAssistCharacterPos()
		{
			return this.As<ISetAssistCharacterPosT>();
		}

		// Token: 0x0602C76F RID: 182127 RVA: 0x0061484D File Offset: 0x00612A4D
		public static IActionParams_Union_0Union FromISetAssistCharacterPos(ISetAssistCharacterPosT _isetassistcharacterpos)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetAssistCharacterPos,
				Value = _isetassistcharacterpos
			};
		}

		// Token: 0x0602C770 RID: 182128 RVA: 0x00614866 File Offset: 0x00612A66
		public ISetPlayerPosT AsISetPlayerPos()
		{
			return this.As<ISetPlayerPosT>();
		}

		// Token: 0x0602C771 RID: 182129 RVA: 0x0061486E File Offset: 0x00612A6E
		public static IActionParams_Union_0Union FromISetPlayerPos(ISetPlayerPosT _isetplayerpos)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetPlayerPos,
				Value = _isetplayerpos
			};
		}

		// Token: 0x0602C772 RID: 182130 RVA: 0x00614887 File Offset: 0x00612A87
		public IClientSetPlayerPosT AsIClientSetPlayerPos()
		{
			return this.As<IClientSetPlayerPosT>();
		}

		// Token: 0x0602C773 RID: 182131 RVA: 0x0061488F File Offset: 0x00612A8F
		public static IActionParams_Union_0Union FromIClientSetPlayerPos(IClientSetPlayerPosT _iclientsetplayerpos)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IClientSetPlayerPos,
				Value = _iclientsetplayerpos
			};
		}

		// Token: 0x0602C774 RID: 182132 RVA: 0x006148A8 File Offset: 0x00612AA8
		public IClientPreEnableSubLevelsT AsIClientPreEnableSubLevels()
		{
			return this.As<IClientPreEnableSubLevelsT>();
		}

		// Token: 0x0602C775 RID: 182133 RVA: 0x006148B0 File Offset: 0x00612AB0
		public static IActionParams_Union_0Union FromIClientPreEnableSubLevels(IClientPreEnableSubLevelsT _iclientpreenablesublevels)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IClientPreEnableSubLevels,
				Value = _iclientpreenablesublevels
			};
		}

		// Token: 0x0602C776 RID: 182134 RVA: 0x006148C9 File Offset: 0x00612AC9
		public IRogueGotoNextFloorT AsIRogueGotoNextFloor()
		{
			return this.As<IRogueGotoNextFloorT>();
		}

		// Token: 0x0602C777 RID: 182135 RVA: 0x006148D1 File Offset: 0x00612AD1
		public static IActionParams_Union_0Union FromIRogueGotoNextFloor(IRogueGotoNextFloorT _iroguegotonextfloor)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRogueGotoNextFloor,
				Value = _iroguegotonextfloor
			};
		}

		// Token: 0x0602C778 RID: 182136 RVA: 0x006148EA File Offset: 0x00612AEA
		public IRogueSelectRoomT AsIRogueSelectRoom()
		{
			return this.As<IRogueSelectRoomT>();
		}

		// Token: 0x0602C779 RID: 182137 RVA: 0x006148F2 File Offset: 0x00612AF2
		public static IActionParams_Union_0Union FromIRogueSelectRoom(IRogueSelectRoomT _irogueselectroom)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRogueSelectRoom,
				Value = _irogueselectroom
			};
		}

		// Token: 0x0602C77A RID: 182138 RVA: 0x0061490B File Offset: 0x00612B0B
		public IRogueActivatePortalT AsIRogueActivatePortal()
		{
			return this.As<IRogueActivatePortalT>();
		}

		// Token: 0x0602C77B RID: 182139 RVA: 0x00614913 File Offset: 0x00612B13
		public static IActionParams_Union_0Union FromIRogueActivatePortal(IRogueActivatePortalT _irogueactivateportal)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRogueActivatePortal,
				Value = _irogueactivateportal
			};
		}

		// Token: 0x0602C77C RID: 182140 RVA: 0x0061492C File Offset: 0x00612B2C
		public IRogueReceiveRewardT AsIRogueReceiveReward()
		{
			return this.As<IRogueReceiveRewardT>();
		}

		// Token: 0x0602C77D RID: 182141 RVA: 0x00614934 File Offset: 0x00612B34
		public static IActionParams_Union_0Union FromIRogueReceiveReward(IRogueReceiveRewardT _iroguereceivereward)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRogueReceiveReward,
				Value = _iroguereceivereward
			};
		}

		// Token: 0x0602C77E RID: 182142 RVA: 0x0061494D File Offset: 0x00612B4D
		public IChangeSelfEntityStateT AsIChangeSelfEntityState()
		{
			return this.As<IChangeSelfEntityStateT>();
		}

		// Token: 0x0602C77F RID: 182143 RVA: 0x00614955 File Offset: 0x00612B55
		public static IActionParams_Union_0Union FromIChangeSelfEntityState(IChangeSelfEntityStateT _ichangeselfentitystate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeSelfEntityState,
				Value = _ichangeselfentitystate
			};
		}

		// Token: 0x0602C780 RID: 182144 RVA: 0x0061496E File Offset: 0x00612B6E
		public IInterludeActionsT AsIInterludeActions()
		{
			return this.As<IInterludeActionsT>();
		}

		// Token: 0x0602C781 RID: 182145 RVA: 0x00614976 File Offset: 0x00612B76
		public static IActionParams_Union_0Union FromIInterludeActions(IInterludeActionsT _iinterludeactions)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IInterludeActions,
				Value = _iinterludeactions
			};
		}

		// Token: 0x0602C782 RID: 182146 RVA: 0x0061498F File Offset: 0x00612B8F
		public IAddBuffToTriggeredEntityT AsIAddBuffToTriggeredEntity()
		{
			return this.As<IAddBuffToTriggeredEntityT>();
		}

		// Token: 0x0602C783 RID: 182147 RVA: 0x00614997 File Offset: 0x00612B97
		public static IActionParams_Union_0Union FromIAddBuffToTriggeredEntity(IAddBuffToTriggeredEntityT _iaddbufftotriggeredentity)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAddBuffToTriggeredEntity,
				Value = _iaddbufftotriggeredentity
			};
		}

		// Token: 0x0602C784 RID: 182148 RVA: 0x006149B0 File Offset: 0x00612BB0
		public IRemoveBuffToTriggeredEntityT AsIRemoveBuffToTriggeredEntity()
		{
			return this.As<IRemoveBuffToTriggeredEntityT>();
		}

		// Token: 0x0602C785 RID: 182149 RVA: 0x006149B8 File Offset: 0x00612BB8
		public static IActionParams_Union_0Union FromIRemoveBuffToTriggeredEntity(IRemoveBuffToTriggeredEntityT _iremovebufftotriggeredentity)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRemoveBuffToTriggeredEntity,
				Value = _iremovebufftotriggeredentity
			};
		}

		// Token: 0x0602C786 RID: 182150 RVA: 0x006149D1 File Offset: 0x00612BD1
		public IDetectTriggerT AsIDetectTrigger()
		{
			return this.As<IDetectTriggerT>();
		}

		// Token: 0x0602C787 RID: 182151 RVA: 0x006149D9 File Offset: 0x00612BD9
		public static IActionParams_Union_0Union FromIDetectTrigger(IDetectTriggerT _idetecttrigger)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IDetectTrigger,
				Value = _idetecttrigger
			};
		}

		// Token: 0x0602C788 RID: 182152 RVA: 0x006149F2 File Offset: 0x00612BF2
		public IItemFoundationMatchT AsIItemFoundationMatch()
		{
			return this.As<IItemFoundationMatchT>();
		}

		// Token: 0x0602C789 RID: 182153 RVA: 0x006149FA File Offset: 0x00612BFA
		public static IActionParams_Union_0Union FromIItemFoundationMatch(IItemFoundationMatchT _iitemfoundationmatch)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IItemFoundationMatch,
				Value = _iitemfoundationmatch
			};
		}

		// Token: 0x0602C78A RID: 182154 RVA: 0x00614A13 File Offset: 0x00612C13
		public ISetBattleStateT AsISetBattleState()
		{
			return this.As<ISetBattleStateT>();
		}

		// Token: 0x0602C78B RID: 182155 RVA: 0x00614A1B File Offset: 0x00612C1B
		public static IActionParams_Union_0Union FromISetBattleState(ISetBattleStateT _isetbattlestate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetBattleState,
				Value = _isetbattlestate
			};
		}

		// Token: 0x0602C78C RID: 182156 RVA: 0x00614A34 File Offset: 0x00612C34
		public IExecBattleActionT AsIExecBattleAction()
		{
			return this.As<IExecBattleActionT>();
		}

		// Token: 0x0602C78D RID: 182157 RVA: 0x00614A3C File Offset: 0x00612C3C
		public static IActionParams_Union_0Union FromIExecBattleAction(IExecBattleActionT _iexecbattleaction)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IExecBattleAction,
				Value = _iexecbattleaction
			};
		}

		// Token: 0x0602C78E RID: 182158 RVA: 0x00614A55 File Offset: 0x00612C55
		public IExecClientMonsterNpcInteractT AsIExecClientMonsterNpcInteract()
		{
			return this.As<IExecClientMonsterNpcInteractT>();
		}

		// Token: 0x0602C78F RID: 182159 RVA: 0x00614A5D File Offset: 0x00612C5D
		public static IActionParams_Union_0Union FromIExecClientMonsterNpcInteract(IExecClientMonsterNpcInteractT _iexecclientmonsternpcinteract)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IExecClientMonsterNpcInteract,
				Value = _iexecclientmonsternpcinteract
			};
		}

		// Token: 0x0602C790 RID: 182160 RVA: 0x00614A76 File Offset: 0x00612C76
		public IExecClientBattleActionT AsIExecClientBattleAction()
		{
			return this.As<IExecClientBattleActionT>();
		}

		// Token: 0x0602C791 RID: 182161 RVA: 0x00614A7E File Offset: 0x00612C7E
		public static IActionParams_Union_0Union FromIExecClientBattleAction(IExecClientBattleActionT _iexecclientbattleaction)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IExecClientBattleAction,
				Value = _iexecclientbattleaction
			};
		}

		// Token: 0x0602C792 RID: 182162 RVA: 0x00614A97 File Offset: 0x00612C97
		public IWaitBattleConditionT AsIWaitBattleCondition()
		{
			return this.As<IWaitBattleConditionT>();
		}

		// Token: 0x0602C793 RID: 182163 RVA: 0x00614A9F File Offset: 0x00612C9F
		public static IActionParams_Union_0Union FromIWaitBattleCondition(IWaitBattleConditionT _iwaitbattlecondition)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IWaitBattleCondition,
				Value = _iwaitbattlecondition
			};
		}

		// Token: 0x0602C794 RID: 182164 RVA: 0x00614AB8 File Offset: 0x00612CB8
		public IEnableHostilityT AsIEnableHostility()
		{
			return this.As<IEnableHostilityT>();
		}

		// Token: 0x0602C795 RID: 182165 RVA: 0x00614AC0 File Offset: 0x00612CC0
		public static IActionParams_Union_0Union FromIEnableHostility(IEnableHostilityT _ienablehostility)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEnableHostility,
				Value = _ienablehostility
			};
		}

		// Token: 0x0602C796 RID: 182166 RVA: 0x00614AD9 File Offset: 0x00612CD9
		public IUnlockSystemItemT AsIUnlockSystemItem()
		{
			return this.As<IUnlockSystemItemT>();
		}

		// Token: 0x0602C797 RID: 182167 RVA: 0x00614AE1 File Offset: 0x00612CE1
		public static IActionParams_Union_0Union FromIUnlockSystemItem(IUnlockSystemItemT _iunlocksystemitem)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IUnlockSystemItem,
				Value = _iunlocksystemitem
			};
		}

		// Token: 0x0602C798 RID: 182168 RVA: 0x00614AFA File Offset: 0x00612CFA
		public IClientUnlockAchievementSystemItemT AsIClientUnlockAchievementSystemItem()
		{
			return this.As<IClientUnlockAchievementSystemItemT>();
		}

		// Token: 0x0602C799 RID: 182169 RVA: 0x00614B02 File Offset: 0x00612D02
		public static IActionParams_Union_0Union FromIClientUnlockAchievementSystemItem(IClientUnlockAchievementSystemItemT _iclientunlockachievementsystemitem)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IClientUnlockAchievementSystemItem,
				Value = _iclientunlockachievementsystemitem
			};
		}

		// Token: 0x0602C79A RID: 182170 RVA: 0x00614B1B File Offset: 0x00612D1B
		public IAddPlayBubbleT AsIAddPlayBubble()
		{
			return this.As<IAddPlayBubbleT>();
		}

		// Token: 0x0602C79B RID: 182171 RVA: 0x00614B23 File Offset: 0x00612D23
		public static IActionParams_Union_0Union FromIAddPlayBubble(IAddPlayBubbleT _iaddplaybubble)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAddPlayBubble,
				Value = _iaddplaybubble
			};
		}

		// Token: 0x0602C79C RID: 182172 RVA: 0x00614B3C File Offset: 0x00612D3C
		public IPlayBubbleT AsIPlayBubble()
		{
			return this.As<IPlayBubbleT>();
		}

		// Token: 0x0602C79D RID: 182173 RVA: 0x00614B44 File Offset: 0x00612D44
		public static IActionParams_Union_0Union FromIPlayBubble(IPlayBubbleT _iplaybubble)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayBubble,
				Value = _iplaybubble
			};
		}

		// Token: 0x0602C79E RID: 182174 RVA: 0x00614B5D File Offset: 0x00612D5D
		public IClearPlayBubbleT AsIClearPlayBubble()
		{
			return this.As<IClearPlayBubbleT>();
		}

		// Token: 0x0602C79F RID: 182175 RVA: 0x00614B65 File Offset: 0x00612D65
		public static IActionParams_Union_0Union FromIClearPlayBubble(IClearPlayBubbleT _iclearplaybubble)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IClearPlayBubble,
				Value = _iclearplaybubble
			};
		}

		// Token: 0x0602C7A0 RID: 182176 RVA: 0x00614B7E File Offset: 0x00612D7E
		public IMoveWithSplineT AsIMoveWithSpline()
		{
			return this.As<IMoveWithSplineT>();
		}

		// Token: 0x0602C7A1 RID: 182177 RVA: 0x00614B86 File Offset: 0x00612D86
		public static IActionParams_Union_0Union FromIMoveWithSpline(IMoveWithSplineT _imovewithspline)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IMoveWithSpline,
				Value = _imovewithspline
			};
		}

		// Token: 0x0602C7A2 RID: 182178 RVA: 0x00614B9F File Offset: 0x00612D9F
		public INewMoveWithSplineT AsINewMoveWithSpline()
		{
			return this.As<INewMoveWithSplineT>();
		}

		// Token: 0x0602C7A3 RID: 182179 RVA: 0x00614BA7 File Offset: 0x00612DA7
		public static IActionParams_Union_0Union FromINewMoveWithSpline(INewMoveWithSplineT _inewmovewithspline)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.INewMoveWithSpline,
				Value = _inewmovewithspline
			};
		}

		// Token: 0x0602C7A4 RID: 182180 RVA: 0x00614BC0 File Offset: 0x00612DC0
		public IStopNewMoveWithSplineT AsIStopNewMoveWithSpline()
		{
			return this.As<IStopNewMoveWithSplineT>();
		}

		// Token: 0x0602C7A5 RID: 182181 RVA: 0x00614BC8 File Offset: 0x00612DC8
		public static IActionParams_Union_0Union FromIStopNewMoveWithSpline(IStopNewMoveWithSplineT _istopnewmovewithspline)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IStopNewMoveWithSpline,
				Value = _istopnewmovewithspline
			};
		}

		// Token: 0x0602C7A6 RID: 182182 RVA: 0x00614BE1 File Offset: 0x00612DE1
		public ICharacterMoveToPointT AsICharacterMoveToPoint()
		{
			return this.As<ICharacterMoveToPointT>();
		}

		// Token: 0x0602C7A7 RID: 182183 RVA: 0x00614BE9 File Offset: 0x00612DE9
		public static IActionParams_Union_0Union FromICharacterMoveToPoint(ICharacterMoveToPointT _icharactermovetopoint)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICharacterMoveToPoint,
				Value = _icharactermovetopoint
			};
		}

		// Token: 0x0602C7A8 RID: 182184 RVA: 0x00614C02 File Offset: 0x00612E02
		public IPlayerMoveToPointT AsIPlayerMoveToPoint()
		{
			return this.As<IPlayerMoveToPointT>();
		}

		// Token: 0x0602C7A9 RID: 182185 RVA: 0x00614C0A File Offset: 0x00612E0A
		public static IActionParams_Union_0Union FromIPlayerMoveToPoint(IPlayerMoveToPointT _iplayermovetopoint)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayerMoveToPoint,
				Value = _iplayermovetopoint
			};
		}

		// Token: 0x0602C7AA RID: 182186 RVA: 0x00614C23 File Offset: 0x00612E23
		public INpcMoveToPointT AsINpcMoveToPoint()
		{
			return this.As<INpcMoveToPointT>();
		}

		// Token: 0x0602C7AB RID: 182187 RVA: 0x00614C2B File Offset: 0x00612E2B
		public static IActionParams_Union_0Union FromINpcMoveToPoint(INpcMoveToPointT _inpcmovetopoint)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.INpcMoveToPoint,
				Value = _inpcmovetopoint
			};
		}

		// Token: 0x0602C7AC RID: 182188 RVA: 0x00614C44 File Offset: 0x00612E44
		public IToggleScanSplineEffectT AsIToggleScanSplineEffect()
		{
			return this.As<IToggleScanSplineEffectT>();
		}

		// Token: 0x0602C7AD RID: 182189 RVA: 0x00614C4C File Offset: 0x00612E4C
		public static IActionParams_Union_0Union FromIToggleScanSplineEffect(IToggleScanSplineEffectT _itogglescansplineeffect)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IToggleScanSplineEffect,
				Value = _itogglescansplineeffect
			};
		}

		// Token: 0x0602C7AE RID: 182190 RVA: 0x00614C65 File Offset: 0x00612E65
		public IOpenTraceSplineT AsIOpenTraceSpline()
		{
			return this.As<IOpenTraceSplineT>();
		}

		// Token: 0x0602C7AF RID: 182191 RVA: 0x00614C6D File Offset: 0x00612E6D
		public static IActionParams_Union_0Union FromIOpenTraceSpline(IOpenTraceSplineT _iopentracespline)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IOpenTraceSpline,
				Value = _iopentracespline
			};
		}

		// Token: 0x0602C7B0 RID: 182192 RVA: 0x00614C86 File Offset: 0x00612E86
		public ICloseTraceSplineT AsICloseTraceSpline()
		{
			return this.As<ICloseTraceSplineT>();
		}

		// Token: 0x0602C7B1 RID: 182193 RVA: 0x00614C8E File Offset: 0x00612E8E
		public static IActionParams_Union_0Union FromICloseTraceSpline(ICloseTraceSplineT _iclosetracespline)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICloseTraceSpline,
				Value = _iclosetracespline
			};
		}

		// Token: 0x0602C7B2 RID: 182194 RVA: 0x00614CA7 File Offset: 0x00612EA7
		public ITraceSplineT AsITraceSpline()
		{
			return this.As<ITraceSplineT>();
		}

		// Token: 0x0602C7B3 RID: 182195 RVA: 0x00614CAF File Offset: 0x00612EAF
		public static IActionParams_Union_0Union FromITraceSpline(ITraceSplineT _itracespline)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ITraceSpline,
				Value = _itracespline
			};
		}

		// Token: 0x0602C7B4 RID: 182196 RVA: 0x00614CC8 File Offset: 0x00612EC8
		public IEnableAIT AsIEnableAI()
		{
			return this.As<IEnableAIT>();
		}

		// Token: 0x0602C7B5 RID: 182197 RVA: 0x00614CD0 File Offset: 0x00612ED0
		public static IActionParams_Union_0Union FromIEnableAI(IEnableAIT _ienableai)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEnableAI,
				Value = _ienableai
			};
		}

		// Token: 0x0602C7B6 RID: 182198 RVA: 0x00614CE9 File Offset: 0x00612EE9
		public IRunActionsT AsIRunActions()
		{
			return this.As<IRunActionsT>();
		}

		// Token: 0x0602C7B7 RID: 182199 RVA: 0x00614CF1 File Offset: 0x00612EF1
		public static IActionParams_Union_0Union FromIRunActions(IRunActionsT _irunactions)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRunActions,
				Value = _irunactions
			};
		}

		// Token: 0x0602C7B8 RID: 182200 RVA: 0x00614D0A File Offset: 0x00612F0A
		public ICommonTipT AsICommonTip()
		{
			return this.As<ICommonTipT>();
		}

		// Token: 0x0602C7B9 RID: 182201 RVA: 0x00614D12 File Offset: 0x00612F12
		public static IActionParams_Union_0Union FromICommonTip(ICommonTipT _icommontip)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICommonTip,
				Value = _icommontip
			};
		}

		// Token: 0x0602C7BA RID: 182202 RVA: 0x00614D2B File Offset: 0x00612F2B
		public ICommonTip2T AsICommonTip2()
		{
			return this.As<ICommonTip2T>();
		}

		// Token: 0x0602C7BB RID: 182203 RVA: 0x00614D33 File Offset: 0x00612F33
		public static IActionParams_Union_0Union FromICommonTip2(ICommonTip2T _icommontip2)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICommonTip2,
				Value = _icommontip2
			};
		}

		// Token: 0x0602C7BC RID: 182204 RVA: 0x00614D4C File Offset: 0x00612F4C
		public IEndCommonTipT AsIEndCommonTip()
		{
			return this.As<IEndCommonTipT>();
		}

		// Token: 0x0602C7BD RID: 182205 RVA: 0x00614D54 File Offset: 0x00612F54
		public static IActionParams_Union_0Union FromIEndCommonTip(IEndCommonTipT _iendcommontip)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEndCommonTip,
				Value = _iendcommontip
			};
		}

		// Token: 0x0602C7BE RID: 182206 RVA: 0x00614D6D File Offset: 0x00612F6D
		public IEnableNearbyTrackingT AsIEnableNearbyTracking()
		{
			return this.As<IEnableNearbyTrackingT>();
		}

		// Token: 0x0602C7BF RID: 182207 RVA: 0x00614D75 File Offset: 0x00612F75
		public static IActionParams_Union_0Union FromIEnableNearbyTracking(IEnableNearbyTrackingT _ienablenearbytracking)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEnableNearbyTracking,
				Value = _ienablenearbytracking
			};
		}

		// Token: 0x0602C7C0 RID: 182208 RVA: 0x00614D8E File Offset: 0x00612F8E
		public ISendAiEventT AsISendAiEvent()
		{
			return this.As<ISendAiEventT>();
		}

		// Token: 0x0602C7C1 RID: 182209 RVA: 0x00614D96 File Offset: 0x00612F96
		public static IActionParams_Union_0Union FromISendAiEvent(ISendAiEventT _isendaievent)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISendAiEvent,
				Value = _isendaievent
			};
		}

		// Token: 0x0602C7C2 RID: 182210 RVA: 0x00614DAF File Offset: 0x00612FAF
		public IEnableLevelPlayT AsIEnableLevelPlay()
		{
			return this.As<IEnableLevelPlayT>();
		}

		// Token: 0x0602C7C3 RID: 182211 RVA: 0x00614DB7 File Offset: 0x00612FB7
		public static IActionParams_Union_0Union FromIEnableLevelPlay(IEnableLevelPlayT _ienablelevelplay)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEnableLevelPlay,
				Value = _ienablelevelplay
			};
		}

		// Token: 0x0602C7C4 RID: 182212 RVA: 0x00614DD0 File Offset: 0x00612FD0
		public IServerForceEnableLevelPlayT AsIServerForceEnableLevelPlay()
		{
			return this.As<IServerForceEnableLevelPlayT>();
		}

		// Token: 0x0602C7C5 RID: 182213 RVA: 0x00614DD8 File Offset: 0x00612FD8
		public static IActionParams_Union_0Union FromIServerForceEnableLevelPlay(IServerForceEnableLevelPlayT _iserverforceenablelevelplay)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IServerForceEnableLevelPlay,
				Value = _iserverforceenablelevelplay
			};
		}

		// Token: 0x0602C7C6 RID: 182214 RVA: 0x00614DF1 File Offset: 0x00612FF1
		public ITeleportDungeonPosT AsITeleportDungeonPos()
		{
			return this.As<ITeleportDungeonPosT>();
		}

		// Token: 0x0602C7C7 RID: 182215 RVA: 0x00614DF9 File Offset: 0x00612FF9
		public static IActionParams_Union_0Union FromITeleportDungeonPos(ITeleportDungeonPosT _iteleportdungeonpos)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ITeleportDungeonPos,
				Value = _iteleportdungeonpos
			};
		}

		// Token: 0x0602C7C8 RID: 182216 RVA: 0x00614E12 File Offset: 0x00613012
		public IFadeInScreenT AsIFadeInScreen()
		{
			return this.As<IFadeInScreenT>();
		}

		// Token: 0x0602C7C9 RID: 182217 RVA: 0x00614E1A File Offset: 0x0061301A
		public static IActionParams_Union_0Union FromIFadeInScreen(IFadeInScreenT _ifadeinscreen)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFadeInScreen,
				Value = _ifadeinscreen
			};
		}

		// Token: 0x0602C7CA RID: 182218 RVA: 0x00614E33 File Offset: 0x00613033
		public IFadeOutScreenT AsIFadeOutScreen()
		{
			return this.As<IFadeOutScreenT>();
		}

		// Token: 0x0602C7CB RID: 182219 RVA: 0x00614E3B File Offset: 0x0061303B
		public static IActionParams_Union_0Union FromIFadeOutScreen(IFadeOutScreenT _ifadeoutscreen)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFadeOutScreen,
				Value = _ifadeoutscreen
			};
		}

		// Token: 0x0602C7CC RID: 182220 RVA: 0x00614E54 File Offset: 0x00613054
		public IStartFlowTemplateT AsIStartFlowTemplate()
		{
			return this.As<IStartFlowTemplateT>();
		}

		// Token: 0x0602C7CD RID: 182221 RVA: 0x00614E5C File Offset: 0x0061305C
		public static IActionParams_Union_0Union FromIStartFlowTemplate(IStartFlowTemplateT _istartflowtemplate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IStartFlowTemplate,
				Value = _istartflowtemplate
			};
		}

		// Token: 0x0602C7CE RID: 182222 RVA: 0x00614E75 File Offset: 0x00613075
		public IEndFlowTemplateT AsIEndFlowTemplate()
		{
			return this.As<IEndFlowTemplateT>();
		}

		// Token: 0x0602C7CF RID: 182223 RVA: 0x00614E7D File Offset: 0x0061307D
		public static IActionParams_Union_0Union FromIEndFlowTemplate(IEndFlowTemplateT _iendflowtemplate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEndFlowTemplate,
				Value = _iendflowtemplate
			};
		}

		// Token: 0x0602C7D0 RID: 182224 RVA: 0x00614E96 File Offset: 0x00613096
		public ICloseFlowTemplateT AsICloseFlowTemplate()
		{
			return this.As<ICloseFlowTemplateT>();
		}

		// Token: 0x0602C7D1 RID: 182225 RVA: 0x00614E9E File Offset: 0x0061309E
		public static IActionParams_Union_0Union FromICloseFlowTemplate(ICloseFlowTemplateT _icloseflowtemplate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICloseFlowTemplate,
				Value = _icloseflowtemplate
			};
		}

		// Token: 0x0602C7D2 RID: 182226 RVA: 0x00614EB7 File Offset: 0x006130B7
		public IChangeFlowTemplateT AsIChangeFlowTemplate()
		{
			return this.As<IChangeFlowTemplateT>();
		}

		// Token: 0x0602C7D3 RID: 182227 RVA: 0x00614EBF File Offset: 0x006130BF
		public static IActionParams_Union_0Union FromIChangeFlowTemplate(IChangeFlowTemplateT _ichangeflowtemplate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeFlowTemplate,
				Value = _ichangeflowtemplate
			};
		}

		// Token: 0x0602C7D4 RID: 182228 RVA: 0x00614ED8 File Offset: 0x006130D8
		public IBeginFlowTemplateT AsIBeginFlowTemplate()
		{
			return this.As<IBeginFlowTemplateT>();
		}

		// Token: 0x0602C7D5 RID: 182229 RVA: 0x00614EE0 File Offset: 0x006130E0
		public static IActionParams_Union_0Union FromIBeginFlowTemplate(IBeginFlowTemplateT _ibeginflowtemplate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IBeginFlowTemplate,
				Value = _ibeginflowtemplate
			};
		}

		// Token: 0x0602C7D6 RID: 182230 RVA: 0x00614EF9 File Offset: 0x006130F9
		public ISetFlowTemplateT AsISetFlowTemplate()
		{
			return this.As<ISetFlowTemplateT>();
		}

		// Token: 0x0602C7D7 RID: 182231 RVA: 0x00614F01 File Offset: 0x00613101
		public static IActionParams_Union_0Union FromISetFlowTemplate(ISetFlowTemplateT _isetflowtemplate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetFlowTemplate,
				Value = _isetflowtemplate
			};
		}

		// Token: 0x0602C7D8 RID: 182232 RVA: 0x00614F1A File Offset: 0x0061311A
		public IHideTargetRangeT AsIHideTargetRange()
		{
			return this.As<IHideTargetRangeT>();
		}

		// Token: 0x0602C7D9 RID: 182233 RVA: 0x00614F22 File Offset: 0x00613122
		public static IActionParams_Union_0Union FromIHideTargetRange(IHideTargetRangeT _ihidetargetrange)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IHideTargetRange,
				Value = _ihidetargetrange
			};
		}

		// Token: 0x0602C7DA RID: 182234 RVA: 0x00614F3B File Offset: 0x0061313B
		public IShowTargetRangeT AsIShowTargetRange()
		{
			return this.As<IShowTargetRangeT>();
		}

		// Token: 0x0602C7DB RID: 182235 RVA: 0x00614F43 File Offset: 0x00613143
		public static IActionParams_Union_0Union FromIShowTargetRange(IShowTargetRangeT _ishowtargetrange)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IShowTargetRange,
				Value = _ishowtargetrange
			};
		}

		// Token: 0x0602C7DC RID: 182236 RVA: 0x00614F5C File Offset: 0x0061315C
		public IHideSpecificEntitiesT AsIHideSpecificEntities()
		{
			return this.As<IHideSpecificEntitiesT>();
		}

		// Token: 0x0602C7DD RID: 182237 RVA: 0x00614F64 File Offset: 0x00613164
		public static IActionParams_Union_0Union FromIHideSpecificEntities(IHideSpecificEntitiesT _ihidespecificentities)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IHideSpecificEntities,
				Value = _ihidespecificentities
			};
		}

		// Token: 0x0602C7DE RID: 182238 RVA: 0x00614F7D File Offset: 0x0061317D
		public IShowSpecificEntitiesT AsIShowSpecificEntities()
		{
			return this.As<IShowSpecificEntitiesT>();
		}

		// Token: 0x0602C7DF RID: 182239 RVA: 0x00614F85 File Offset: 0x00613185
		public static IActionParams_Union_0Union FromIShowSpecificEntities(IShowSpecificEntitiesT _ishowspecificentities)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IShowSpecificEntities,
				Value = _ishowspecificentities
			};
		}

		// Token: 0x0602C7E0 RID: 182240 RVA: 0x00614F9E File Offset: 0x0061319E
		public IHideGroupT AsIHideGroup()
		{
			return this.As<IHideGroupT>();
		}

		// Token: 0x0602C7E1 RID: 182241 RVA: 0x00614FA6 File Offset: 0x006131A6
		public static IActionParams_Union_0Union FromIHideGroup(IHideGroupT _ihidegroup)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IHideGroup,
				Value = _ihidegroup
			};
		}

		// Token: 0x0602C7E2 RID: 182242 RVA: 0x00614FBF File Offset: 0x006131BF
		public IShowHidedGroupT AsIShowHidedGroup()
		{
			return this.As<IShowHidedGroupT>();
		}

		// Token: 0x0602C7E3 RID: 182243 RVA: 0x00614FC7 File Offset: 0x006131C7
		public static IActionParams_Union_0Union FromIShowHidedGroup(IShowHidedGroupT _ishowhidedgroup)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IShowHidedGroup,
				Value = _ishowhidedgroup
			};
		}

		// Token: 0x0602C7E4 RID: 182244 RVA: 0x00614FE0 File Offset: 0x006131E0
		public ISetSubScreenModeT AsISetSubScreenMode()
		{
			return this.As<ISetSubScreenModeT>();
		}

		// Token: 0x0602C7E5 RID: 182245 RVA: 0x00614FE8 File Offset: 0x006131E8
		public static IActionParams_Union_0Union FromISetSubScreenMode(ISetSubScreenModeT _isetsubscreenmode)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetSubScreenMode,
				Value = _isetsubscreenmode
			};
		}

		// Token: 0x0602C7E6 RID: 182246 RVA: 0x00615001 File Offset: 0x00613201
		public IToggleDragActorPlayT AsIToggleDragActorPlay()
		{
			return this.As<IToggleDragActorPlayT>();
		}

		// Token: 0x0602C7E7 RID: 182247 RVA: 0x00615009 File Offset: 0x00613209
		public static IActionParams_Union_0Union FromIToggleDragActorPlay(IToggleDragActorPlayT _itoggledragactorplay)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IToggleDragActorPlay,
				Value = _itoggledragactorplay
			};
		}

		// Token: 0x0602C7E8 RID: 182248 RVA: 0x00615022 File Offset: 0x00613222
		public IDarkTideSetMapMarkStateT AsIDarkTideSetMapMarkState()
		{
			return this.As<IDarkTideSetMapMarkStateT>();
		}

		// Token: 0x0602C7E9 RID: 182249 RVA: 0x0061502A File Offset: 0x0061322A
		public static IActionParams_Union_0Union FromIDarkTideSetMapMarkState(IDarkTideSetMapMarkStateT _idarktidesetmapmarkstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IDarkTideSetMapMarkState,
				Value = _idarktidesetmapmarkstate
			};
		}

		// Token: 0x0602C7EA RID: 182250 RVA: 0x00615043 File Offset: 0x00613243
		public IManualOccupationsT AsIManualOccupations()
		{
			return this.As<IManualOccupationsT>();
		}

		// Token: 0x0602C7EB RID: 182251 RVA: 0x0061504B File Offset: 0x0061324B
		public static IActionParams_Union_0Union FromIManualOccupations(IManualOccupationsT _imanualoccupations)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IManualOccupations,
				Value = _imanualoccupations
			};
		}

		// Token: 0x0602C7EC RID: 182252 RVA: 0x00615064 File Offset: 0x00613264
		public IForceOccupationsT AsIForceOccupations()
		{
			return this.As<IForceOccupationsT>();
		}

		// Token: 0x0602C7ED RID: 182253 RVA: 0x0061506C File Offset: 0x0061326C
		public static IActionParams_Union_0Union FromIForceOccupations(IForceOccupationsT _iforceoccupations)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IForceOccupations,
				Value = _iforceoccupations
			};
		}

		// Token: 0x0602C7EE RID: 182254 RVA: 0x00615085 File Offset: 0x00613285
		public IChangeFightTeamT AsIChangeFightTeam()
		{
			return this.As<IChangeFightTeamT>();
		}

		// Token: 0x0602C7EF RID: 182255 RVA: 0x0061508D File Offset: 0x0061328D
		public static IActionParams_Union_0Union FromIChangeFightTeam(IChangeFightTeamT _ichangefightteam)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeFightTeam,
				Value = _ichangefightteam
			};
		}

		// Token: 0x0602C7F0 RID: 182256 RVA: 0x006150A6 File Offset: 0x006132A6
		public IActiveRangeT AsIActiveRange()
		{
			return this.As<IActiveRangeT>();
		}

		// Token: 0x0602C7F1 RID: 182257 RVA: 0x006150AE File Offset: 0x006132AE
		public static IActionParams_Union_0Union FromIActiveRange(IActiveRangeT _iactiverange)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IActiveRange,
				Value = _iactiverange
			};
		}

		// Token: 0x0602C7F2 RID: 182258 RVA: 0x006150C7 File Offset: 0x006132C7
		public IAddTrialCharacterT AsIAddTrialCharacter()
		{
			return this.As<IAddTrialCharacterT>();
		}

		// Token: 0x0602C7F3 RID: 182259 RVA: 0x006150CF File Offset: 0x006132CF
		public static IActionParams_Union_0Union FromIAddTrialCharacter(IAddTrialCharacterT _iaddtrialcharacter)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAddTrialCharacter,
				Value = _iaddtrialcharacter
			};
		}

		// Token: 0x0602C7F4 RID: 182260 RVA: 0x006150E8 File Offset: 0x006132E8
		public IUpdateTrialCharacterT AsIUpdateTrialCharacter()
		{
			return this.As<IUpdateTrialCharacterT>();
		}

		// Token: 0x0602C7F5 RID: 182261 RVA: 0x006150F0 File Offset: 0x006132F0
		public static IActionParams_Union_0Union FromIUpdateTrialCharacter(IUpdateTrialCharacterT _iupdatetrialcharacter)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IUpdateTrialCharacter,
				Value = _iupdatetrialcharacter
			};
		}

		// Token: 0x0602C7F6 RID: 182262 RVA: 0x00615109 File Offset: 0x00613309
		public IRestoreTrialCharacterT AsIRestoreTrialCharacter()
		{
			return this.As<IRestoreTrialCharacterT>();
		}

		// Token: 0x0602C7F7 RID: 182263 RVA: 0x00615111 File Offset: 0x00613311
		public static IActionParams_Union_0Union FromIRestoreTrialCharacter(IRestoreTrialCharacterT _irestoretrialcharacter)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRestoreTrialCharacter,
				Value = _irestoretrialcharacter
			};
		}

		// Token: 0x0602C7F8 RID: 182264 RVA: 0x0061512A File Offset: 0x0061332A
		public IRemoveTrialCharacterT AsIRemoveTrialCharacter()
		{
			return this.As<IRemoveTrialCharacterT>();
		}

		// Token: 0x0602C7F9 RID: 182265 RVA: 0x00615132 File Offset: 0x00613332
		public static IActionParams_Union_0Union FromIRemoveTrialCharacter(IRemoveTrialCharacterT _iremovetrialcharacter)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRemoveTrialCharacter,
				Value = _iremovetrialcharacter
			};
		}

		// Token: 0x0602C7FA RID: 182266 RVA: 0x0061514B File Offset: 0x0061334B
		public IAddGuestCharacterT AsIAddGuestCharacter()
		{
			return this.As<IAddGuestCharacterT>();
		}

		// Token: 0x0602C7FB RID: 182267 RVA: 0x00615153 File Offset: 0x00613353
		public static IActionParams_Union_0Union FromIAddGuestCharacter(IAddGuestCharacterT _iaddguestcharacter)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAddGuestCharacter,
				Value = _iaddguestcharacter
			};
		}

		// Token: 0x0602C7FC RID: 182268 RVA: 0x0061516C File Offset: 0x0061336C
		public IRemoveGuestCharacterT AsIRemoveGuestCharacter()
		{
			return this.As<IRemoveGuestCharacterT>();
		}

		// Token: 0x0602C7FD RID: 182269 RVA: 0x00615174 File Offset: 0x00613374
		public static IActionParams_Union_0Union FromIRemoveGuestCharacter(IRemoveGuestCharacterT _iremoveguestcharacter)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRemoveGuestCharacter,
				Value = _iremoveguestcharacter
			};
		}

		// Token: 0x0602C7FE RID: 182270 RVA: 0x0061518D File Offset: 0x0061338D
		public IDestroyQuestT AsIDestroyQuest()
		{
			return this.As<IDestroyQuestT>();
		}

		// Token: 0x0602C7FF RID: 182271 RVA: 0x00615195 File Offset: 0x00613395
		public static IActionParams_Union_0Union FromIDestroyQuest(IDestroyQuestT _idestroyquest)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IDestroyQuest,
				Value = _idestroyquest
			};
		}

		// Token: 0x0602C800 RID: 182272 RVA: 0x006151AE File Offset: 0x006133AE
		public ISetCameraAnimT AsISetCameraAnim()
		{
			return this.As<ISetCameraAnimT>();
		}

		// Token: 0x0602C801 RID: 182273 RVA: 0x006151B6 File Offset: 0x006133B6
		public static IActionParams_Union_0Union FromISetCameraAnim(ISetCameraAnimT _isetcameraanim)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetCameraAnim,
				Value = _isetcameraanim
			};
		}

		// Token: 0x0602C802 RID: 182274 RVA: 0x006151CF File Offset: 0x006133CF
		public IChangeTimerT AsIChangeTimer()
		{
			return this.As<IChangeTimerT>();
		}

		// Token: 0x0602C803 RID: 182275 RVA: 0x006151D7 File Offset: 0x006133D7
		public static IActionParams_Union_0Union FromIChangeTimer(IChangeTimerT _ichangetimer)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeTimer,
				Value = _ichangetimer
			};
		}

		// Token: 0x0602C804 RID: 182276 RVA: 0x006151F0 File Offset: 0x006133F0
		public IToggleTimerPauseStateT AsIToggleTimerPauseState()
		{
			return this.As<IToggleTimerPauseStateT>();
		}

		// Token: 0x0602C805 RID: 182277 RVA: 0x006151F8 File Offset: 0x006133F8
		public static IActionParams_Union_0Union FromIToggleTimerPauseState(IToggleTimerPauseStateT _itoggletimerpausestate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IToggleTimerPauseState,
				Value = _itoggletimerpausestate
			};
		}

		// Token: 0x0602C806 RID: 182278 RVA: 0x00615211 File Offset: 0x00613411
		public IRotatorEntityT AsIRotatorEntity()
		{
			return this.As<IRotatorEntityT>();
		}

		// Token: 0x0602C807 RID: 182279 RVA: 0x00615219 File Offset: 0x00613419
		public static IActionParams_Union_0Union FromIRotatorEntity(IRotatorEntityT _irotatorentity)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRotatorEntity,
				Value = _irotatorentity
			};
		}

		// Token: 0x0602C808 RID: 182280 RVA: 0x00615232 File Offset: 0x00613432
		public IUnLimitPlayerOperationT AsIUnLimitPlayerOperation()
		{
			return this.As<IUnLimitPlayerOperationT>();
		}

		// Token: 0x0602C809 RID: 182281 RVA: 0x0061523A File Offset: 0x0061343A
		public static IActionParams_Union_0Union FromIUnLimitPlayerOperation(IUnLimitPlayerOperationT _iunlimitplayeroperation)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IUnLimitPlayerOperation,
				Value = _iunlimitplayeroperation
			};
		}

		// Token: 0x0602C80A RID: 182282 RVA: 0x00615253 File Offset: 0x00613453
		public ILimitPlayerOperationT AsILimitPlayerOperation()
		{
			return this.As<ILimitPlayerOperationT>();
		}

		// Token: 0x0602C80B RID: 182283 RVA: 0x0061525B File Offset: 0x0061345B
		public static IActionParams_Union_0Union FromILimitPlayerOperation(ILimitPlayerOperationT _ilimitplayeroperation)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ILimitPlayerOperation,
				Value = _ilimitplayeroperation
			};
		}

		// Token: 0x0602C80C RID: 182284 RVA: 0x00615274 File Offset: 0x00613474
		public IEnableSystemT AsIEnableSystem()
		{
			return this.As<IEnableSystemT>();
		}

		// Token: 0x0602C80D RID: 182285 RVA: 0x0061527C File Offset: 0x0061347C
		public static IActionParams_Union_0Union FromIEnableSystem(IEnableSystemT _ienablesystem)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEnableSystem,
				Value = _ienablesystem
			};
		}

		// Token: 0x0602C80E RID: 182286 RVA: 0x00615295 File Offset: 0x00613495
		public ILeisureInteractT AsILeisureInteract()
		{
			return this.As<ILeisureInteractT>();
		}

		// Token: 0x0602C80F RID: 182287 RVA: 0x0061529D File Offset: 0x0061349D
		public static IActionParams_Union_0Union FromILeisureInteract(ILeisureInteractT _ileisureinteract)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ILeisureInteract,
				Value = _ileisureinteract
			};
		}

		// Token: 0x0602C810 RID: 182288 RVA: 0x006152B6 File Offset: 0x006134B6
		public INpcLeisureInteractT AsINpcLeisureInteract()
		{
			return this.As<INpcLeisureInteractT>();
		}

		// Token: 0x0602C811 RID: 182289 RVA: 0x006152BE File Offset: 0x006134BE
		public static IActionParams_Union_0Union FromINpcLeisureInteract(INpcLeisureInteractT _inpcleisureinteract)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.INpcLeisureInteract,
				Value = _inpcleisureinteract
			};
		}

		// Token: 0x0602C812 RID: 182290 RVA: 0x006152D7 File Offset: 0x006134D7
		public IPostAkEventT AsIPostAkEvent()
		{
			return this.As<IPostAkEventT>();
		}

		// Token: 0x0602C813 RID: 182291 RVA: 0x006152DF File Offset: 0x006134DF
		public static IActionParams_Union_0Union FromIPostAkEvent(IPostAkEventT _ipostakevent)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPostAkEvent,
				Value = _ipostakevent
			};
		}

		// Token: 0x0602C814 RID: 182292 RVA: 0x006152F8 File Offset: 0x006134F8
		public IMoveSceneItemT AsIMoveSceneItem()
		{
			return this.As<IMoveSceneItemT>();
		}

		// Token: 0x0602C815 RID: 182293 RVA: 0x00615300 File Offset: 0x00613500
		public static IActionParams_Union_0Union FromIMoveSceneItem(IMoveSceneItemT _imovesceneitem)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IMoveSceneItem,
				Value = _imovesceneitem
			};
		}

		// Token: 0x0602C816 RID: 182294 RVA: 0x00615319 File Offset: 0x00613519
		public IStopSceneItemMoveT AsIStopSceneItemMove()
		{
			return this.As<IStopSceneItemMoveT>();
		}

		// Token: 0x0602C817 RID: 182295 RVA: 0x00615321 File Offset: 0x00613521
		public static IActionParams_Union_0Union FromIStopSceneItemMove(IStopSceneItemMoveT _istopsceneitemmove)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IStopSceneItemMove,
				Value = _istopsceneitemmove
			};
		}

		// Token: 0x0602C818 RID: 182296 RVA: 0x0061533A File Offset: 0x0061353A
		public IChangeLiftTargetT AsIChangeLiftTarget()
		{
			return this.As<IChangeLiftTargetT>();
		}

		// Token: 0x0602C819 RID: 182297 RVA: 0x00615342 File Offset: 0x00613542
		public static IActionParams_Union_0Union FromIChangeLiftTarget(IChangeLiftTargetT _ichangelifttarget)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeLiftTarget,
				Value = _ichangelifttarget
			};
		}

		// Token: 0x0602C81A RID: 182298 RVA: 0x0061535B File Offset: 0x0061355B
		public IHideByRangeInFlowT AsIHideByRangeInFlow()
		{
			return this.As<IHideByRangeInFlowT>();
		}

		// Token: 0x0602C81B RID: 182299 RVA: 0x00615363 File Offset: 0x00613563
		public static IActionParams_Union_0Union FromIHideByRangeInFlow(IHideByRangeInFlowT _ihidebyrangeinflow)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IHideByRangeInFlow,
				Value = _ihidebyrangeinflow
			};
		}

		// Token: 0x0602C81C RID: 182300 RVA: 0x0061537C File Offset: 0x0061357C
		public IShowAllHidedGroupInFlowT AsIShowAllHidedGroupInFlow()
		{
			return this.As<IShowAllHidedGroupInFlowT>();
		}

		// Token: 0x0602C81D RID: 182301 RVA: 0x00615384 File Offset: 0x00613584
		public static IActionParams_Union_0Union FromIShowAllHidedGroupInFlow(IShowAllHidedGroupInFlowT _ishowallhidedgroupinflow)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IShowAllHidedGroupInFlow,
				Value = _ishowallhidedgroupinflow
			};
		}

		// Token: 0x0602C81E RID: 182302 RVA: 0x0061539D File Offset: 0x0061359D
		public IOpenSimpleGameplayT AsIOpenSimpleGameplay()
		{
			return this.As<IOpenSimpleGameplayT>();
		}

		// Token: 0x0602C81F RID: 182303 RVA: 0x006153A5 File Offset: 0x006135A5
		public static IActionParams_Union_0Union FromIOpenSimpleGameplay(IOpenSimpleGameplayT _iopensimplegameplay)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IOpenSimpleGameplay,
				Value = _iopensimplegameplay
			};
		}

		// Token: 0x0602C820 RID: 182304 RVA: 0x006153BE File Offset: 0x006135BE
		public IToggleRideFlyingCarUiGameplayT AsIToggleRideFlyingCarUiGameplay()
		{
			return this.As<IToggleRideFlyingCarUiGameplayT>();
		}

		// Token: 0x0602C821 RID: 182305 RVA: 0x006153C6 File Offset: 0x006135C6
		public static IActionParams_Union_0Union FromIToggleRideFlyingCarUiGameplay(IToggleRideFlyingCarUiGameplayT _itogglerideflyingcaruigameplay)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IToggleRideFlyingCarUiGameplay,
				Value = _itogglerideflyingcaruigameplay
			};
		}

		// Token: 0x0602C822 RID: 182306 RVA: 0x006153DF File Offset: 0x006135DF
		public IChangePhantomT AsIChangePhantom()
		{
			return this.As<IChangePhantomT>();
		}

		// Token: 0x0602C823 RID: 182307 RVA: 0x006153E7 File Offset: 0x006135E7
		public static IActionParams_Union_0Union FromIChangePhantom(IChangePhantomT _ichangephantom)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangePhantom,
				Value = _ichangephantom
			};
		}

		// Token: 0x0602C824 RID: 182308 RVA: 0x00615400 File Offset: 0x00613600
		public IRestorePhantomT AsIRestorePhantom()
		{
			return this.As<IRestorePhantomT>();
		}

		// Token: 0x0602C825 RID: 182309 RVA: 0x00615408 File Offset: 0x00613608
		public static IActionParams_Union_0Union FromIRestorePhantom(IRestorePhantomT _irestorephantom)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRestorePhantom,
				Value = _irestorephantom
			};
		}

		// Token: 0x0602C826 RID: 182310 RVA: 0x00615421 File Offset: 0x00613621
		public ITakePlotPhotoT AsITakePlotPhoto()
		{
			return this.As<ITakePlotPhotoT>();
		}

		// Token: 0x0602C827 RID: 182311 RVA: 0x00615429 File Offset: 0x00613629
		public static IActionParams_Union_0Union FromITakePlotPhoto(ITakePlotPhotoT _itakeplotphoto)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ITakePlotPhoto,
				Value = _itakeplotphoto
			};
		}

		// Token: 0x0602C828 RID: 182312 RVA: 0x00615442 File Offset: 0x00613642
		public IChangeActorTalkerT AsIChangeActorTalker()
		{
			return this.As<IChangeActorTalkerT>();
		}

		// Token: 0x0602C829 RID: 182313 RVA: 0x0061544A File Offset: 0x0061364A
		public static IActionParams_Union_0Union FromIChangeActorTalker(IChangeActorTalkerT _ichangeactortalker)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeActorTalker,
				Value = _ichangeactortalker
			};
		}

		// Token: 0x0602C82A RID: 182314 RVA: 0x00615463 File Offset: 0x00613663
		public ISwitchSubLevelsT AsISwitchSubLevels()
		{
			return this.As<ISwitchSubLevelsT>();
		}

		// Token: 0x0602C82B RID: 182315 RVA: 0x0061546B File Offset: 0x0061366B
		public static IActionParams_Union_0Union FromISwitchSubLevels(ISwitchSubLevelsT _iswitchsublevels)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISwitchSubLevels,
				Value = _iswitchsublevels
			};
		}

		// Token: 0x0602C82C RID: 182316 RVA: 0x00615484 File Offset: 0x00613684
		public ISwitchSubLevelsDirectlyT AsISwitchSubLevelsDirectly()
		{
			return this.As<ISwitchSubLevelsDirectlyT>();
		}

		// Token: 0x0602C82D RID: 182317 RVA: 0x0061548C File Offset: 0x0061368C
		public static IActionParams_Union_0Union FromISwitchSubLevelsDirectly(ISwitchSubLevelsDirectlyT _iswitchsublevelsdirectly)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISwitchSubLevelsDirectly,
				Value = _iswitchsublevelsdirectly
			};
		}

		// Token: 0x0602C82E RID: 182318 RVA: 0x006154A5 File Offset: 0x006136A5
		public IPreloadSubLevelsT AsIPreloadSubLevels()
		{
			return this.As<IPreloadSubLevelsT>();
		}

		// Token: 0x0602C82F RID: 182319 RVA: 0x006154AD File Offset: 0x006136AD
		public static IActionParams_Union_0Union FromIPreloadSubLevels(IPreloadSubLevelsT _ipreloadsublevels)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPreloadSubLevels,
				Value = _ipreloadsublevels
			};
		}

		// Token: 0x0602C830 RID: 182320 RVA: 0x006154C6 File Offset: 0x006136C6
		public ISwitchPermissionT AsISwitchPermission()
		{
			return this.As<ISwitchPermissionT>();
		}

		// Token: 0x0602C831 RID: 182321 RVA: 0x006154CE File Offset: 0x006136CE
		public static IActionParams_Union_0Union FromISwitchPermission(ISwitchPermissionT _iswitchpermission)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISwitchPermission,
				Value = _iswitchpermission
			};
		}

		// Token: 0x0602C832 RID: 182322 RVA: 0x006154E7 File Offset: 0x006136E7
		public ISwitchDataLayersT AsISwitchDataLayers()
		{
			return this.As<ISwitchDataLayersT>();
		}

		// Token: 0x0602C833 RID: 182323 RVA: 0x006154EF File Offset: 0x006136EF
		public static IActionParams_Union_0Union FromISwitchDataLayers(ISwitchDataLayersT _iswitchdatalayers)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISwitchDataLayers,
				Value = _iswitchdatalayers
			};
		}

		// Token: 0x0602C834 RID: 182324 RVA: 0x00615508 File Offset: 0x00613708
		public IActivateResetPointT AsIActivateResetPoint()
		{
			return this.As<IActivateResetPointT>();
		}

		// Token: 0x0602C835 RID: 182325 RVA: 0x00615510 File Offset: 0x00613710
		public static IActionParams_Union_0Union FromIActivateResetPoint(IActivateResetPointT _iactivateresetpoint)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IActivateResetPoint,
				Value = _iactivateresetpoint
			};
		}

		// Token: 0x0602C836 RID: 182326 RVA: 0x00615529 File Offset: 0x00613729
		public ITeleportToLatestResetPointT AsITeleportToLatestResetPoint()
		{
			return this.As<ITeleportToLatestResetPointT>();
		}

		// Token: 0x0602C837 RID: 182327 RVA: 0x00615531 File Offset: 0x00613731
		public static IActionParams_Union_0Union FromITeleportToLatestResetPoint(ITeleportToLatestResetPointT _iteleporttolatestresetpoint)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ITeleportToLatestResetPoint,
				Value = _iteleporttolatestresetpoint
			};
		}

		// Token: 0x0602C838 RID: 182328 RVA: 0x0061554A File Offset: 0x0061374A
		public ISetWeatherT AsISetWeather()
		{
			return this.As<ISetWeatherT>();
		}

		// Token: 0x0602C839 RID: 182329 RVA: 0x00615552 File Offset: 0x00613752
		public static IActionParams_Union_0Union FromISetWeather(ISetWeatherT _isetweather)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetWeather,
				Value = _isetweather
			};
		}

		// Token: 0x0602C83A RID: 182330 RVA: 0x0061556B File Offset: 0x0061376B
		public ISetTimeLockStateT AsISetTimeLockState()
		{
			return this.As<ISetTimeLockStateT>();
		}

		// Token: 0x0602C83B RID: 182331 RVA: 0x00615573 File Offset: 0x00613773
		public static IActionParams_Union_0Union FromISetTimeLockState(ISetTimeLockStateT _isettimelockstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetTimeLockState,
				Value = _isettimelockstate
			};
		}

		// Token: 0x0602C83C RID: 182332 RVA: 0x0061558C File Offset: 0x0061378C
		public ISetWeatherLockStateT AsISetWeatherLockState()
		{
			return this.As<ISetWeatherLockStateT>();
		}

		// Token: 0x0602C83D RID: 182333 RVA: 0x00615594 File Offset: 0x00613794
		public static IActionParams_Union_0Union FromISetWeatherLockState(ISetWeatherLockStateT _isetweatherlockstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetWeatherLockState,
				Value = _isetweatherlockstate
			};
		}

		// Token: 0x0602C83E RID: 182334 RVA: 0x006155AD File Offset: 0x006137AD
		public IClientSetSeasonStateT AsIClientSetSeasonState()
		{
			return this.As<IClientSetSeasonStateT>();
		}

		// Token: 0x0602C83F RID: 182335 RVA: 0x006155B5 File Offset: 0x006137B5
		public static IActionParams_Union_0Union FromIClientSetSeasonState(IClientSetSeasonStateT _iclientsetseasonstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IClientSetSeasonState,
				Value = _iclientsetseasonstate
			};
		}

		// Token: 0x0602C840 RID: 182336 RVA: 0x006155CE File Offset: 0x006137CE
		public IAxisLockScreenConfigT AsIAxisLockScreenConfig()
		{
			return this.As<IAxisLockScreenConfigT>();
		}

		// Token: 0x0602C841 RID: 182337 RVA: 0x006155D6 File Offset: 0x006137D6
		public static IActionParams_Union_0Union FromIAxisLockScreenConfig(IAxisLockScreenConfigT _iaxislockscreenconfig)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAxisLockScreenConfig,
				Value = _iaxislockscreenconfig
			};
		}

		// Token: 0x0602C842 RID: 182338 RVA: 0x006155EF File Offset: 0x006137EF
		public IAdjustPlayerCameraT AsIAdjustPlayerCamera()
		{
			return this.As<IAdjustPlayerCameraT>();
		}

		// Token: 0x0602C843 RID: 182339 RVA: 0x006155F7 File Offset: 0x006137F7
		public static IActionParams_Union_0Union FromIAdjustPlayerCamera(IAdjustPlayerCameraT _iadjustplayercamera)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAdjustPlayerCamera,
				Value = _iadjustplayercamera
			};
		}

		// Token: 0x0602C844 RID: 182340 RVA: 0x00615610 File Offset: 0x00613810
		public IRestorePlayerCameraAdjustmentT AsIRestorePlayerCameraAdjustment()
		{
			return this.As<IRestorePlayerCameraAdjustmentT>();
		}

		// Token: 0x0602C845 RID: 182341 RVA: 0x00615618 File Offset: 0x00613818
		public static IActionParams_Union_0Union FromIRestorePlayerCameraAdjustment(IRestorePlayerCameraAdjustmentT _irestoreplayercameraadjustment)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRestorePlayerCameraAdjustment,
				Value = _irestoreplayercameraadjustment
			};
		}

		// Token: 0x0602C846 RID: 182342 RVA: 0x00615631 File Offset: 0x00613831
		public IAdjustPlayerCameraGravityT AsIAdjustPlayerCameraGravity()
		{
			return this.As<IAdjustPlayerCameraGravityT>();
		}

		// Token: 0x0602C847 RID: 182343 RVA: 0x00615639 File Offset: 0x00613839
		public static IActionParams_Union_0Union FromIAdjustPlayerCameraGravity(IAdjustPlayerCameraGravityT _iadjustplayercameragravity)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAdjustPlayerCameraGravity,
				Value = _iadjustplayercameragravity
			};
		}

		// Token: 0x0602C848 RID: 182344 RVA: 0x00615652 File Offset: 0x00613852
		public IEnterMovieCameraT AsIEnterMovieCamera()
		{
			return this.As<IEnterMovieCameraT>();
		}

		// Token: 0x0602C849 RID: 182345 RVA: 0x0061565A File Offset: 0x0061385A
		public static IActionParams_Union_0Union FromIEnterMovieCamera(IEnterMovieCameraT _ientermoviecamera)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEnterMovieCamera,
				Value = _ientermoviecamera
			};
		}

		// Token: 0x0602C84A RID: 182346 RVA: 0x00615673 File Offset: 0x00613873
		public IExitMovieCameraT AsIExitMovieCamera()
		{
			return this.As<IExitMovieCameraT>();
		}

		// Token: 0x0602C84B RID: 182347 RVA: 0x0061567B File Offset: 0x0061387B
		public static IActionParams_Union_0Union FromIExitMovieCamera(IExitMovieCameraT _iexitmoviecamera)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IExitMovieCamera,
				Value = _iexitmoviecamera
			};
		}

		// Token: 0x0602C84C RID: 182348 RVA: 0x00615694 File Offset: 0x00613894
		public IResetPlayerCameraFocusT AsIResetPlayerCameraFocus()
		{
			return this.As<IResetPlayerCameraFocusT>();
		}

		// Token: 0x0602C84D RID: 182349 RVA: 0x0061569C File Offset: 0x0061389C
		public static IActionParams_Union_0Union FromIResetPlayerCameraFocus(IResetPlayerCameraFocusT _iresetplayercamerafocus)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IResetPlayerCameraFocus,
				Value = _iresetplayercamerafocus
			};
		}

		// Token: 0x0602C84E RID: 182350 RVA: 0x006156B5 File Offset: 0x006138B5
		public IUsePhantomSkillT AsIUsePhantomSkill()
		{
			return this.As<IUsePhantomSkillT>();
		}

		// Token: 0x0602C84F RID: 182351 RVA: 0x006156BD File Offset: 0x006138BD
		public static IActionParams_Union_0Union FromIUsePhantomSkill(IUsePhantomSkillT _iusephantomskill)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IUsePhantomSkill,
				Value = _iusephantomskill
			};
		}

		// Token: 0x0602C850 RID: 182352 RVA: 0x006156D6 File Offset: 0x006138D6
		public IChangePhantomFormationT AsIChangePhantomFormation()
		{
			return this.As<IChangePhantomFormationT>();
		}

		// Token: 0x0602C851 RID: 182353 RVA: 0x006156DE File Offset: 0x006138DE
		public static IActionParams_Union_0Union FromIChangePhantomFormation(IChangePhantomFormationT _ichangephantomformation)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangePhantomFormation,
				Value = _ichangephantomformation
			};
		}

		// Token: 0x0602C852 RID: 182354 RVA: 0x006156F7 File Offset: 0x006138F7
		public IRestorePhantomFormationT AsIRestorePhantomFormation()
		{
			return this.As<IRestorePhantomFormationT>();
		}

		// Token: 0x0602C853 RID: 182355 RVA: 0x006156FF File Offset: 0x006138FF
		public static IActionParams_Union_0Union FromIRestorePhantomFormation(IRestorePhantomFormationT _irestorephantomformation)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRestorePhantomFormation,
				Value = _irestorephantomformation
			};
		}

		// Token: 0x0602C854 RID: 182356 RVA: 0x00615718 File Offset: 0x00613918
		public static int Pack(FlatBufferBuilder builder, IActionParams_Union_0Union _o)
		{
			switch (_o.Type)
			{
			case IActionParams_Union_0.IActionParams:
				return IActionParams.Pack(builder, _o.AsIActionParams()).Value;
			case IActionParams_Union_0.IInvoke:
				return IInvoke.Pack(builder, _o.AsIInvoke()).Value;
			case IActionParams_Union_0.IInteract:
				return IInteract.Pack(builder, _o.AsIInteract()).Value;
			case IActionParams_Union_0.IFinishCondition:
				return IFinishCondition.Pack(builder, _o.AsIFinishCondition()).Value;
			case IActionParams_Union_0.IGetRewardByInteract:
				return IGetRewardByInteract.Pack(builder, _o.AsIGetRewardByInteract()).Value;
			case IActionParams_Union_0.IWaitUntilLevelSequenceReachMark:
				return IWaitUntilLevelSequenceReachMark.Pack(builder, _o.AsIWaitUntilLevelSequenceReachMark()).Value;
			case IActionParams_Union_0.IClearEntityVisibleTag:
				return IClearEntityVisibleTag.Pack(builder, _o.AsIClearEntityVisibleTag()).Value;
			case IActionParams_Union_0.ISetEntityPos:
				return ISetEntityPos.Pack(builder, _o.AsISetEntityPos()).Value;
			case IActionParams_Union_0.IResetEntityPos:
				return IResetEntityPos.Pack(builder, _o.AsIResetEntityPos()).Value;
			case IActionParams_Union_0.IServerSetPlayerPos:
				return IServerSetPlayerPos.Pack(builder, _o.AsIServerSetPlayerPos()).Value;
			case IActionParams_Union_0.IFixTeleControllerPos:
				return IFixTeleControllerPos.Pack(builder, _o.AsIFixTeleControllerPos()).Value;
			case IActionParams_Union_0.IFixTeleControllerResetPos:
				return IFixTeleControllerResetPos.Pack(builder, _o.AsIFixTeleControllerResetPos()).Value;
			case IActionParams_Union_0.IFixFoundationRelation:
				return IFixFoundationRelation.Pack(builder, _o.AsIFixFoundationRelation()).Value;
			case IActionParams_Union_0.ITraceCurrentQuest:
				return ITraceCurrentQuest.Pack(builder, _o.AsITraceCurrentQuest()).Value;
			case IActionParams_Union_0.IFixShowTargetRange:
				return IFixShowTargetRange.Pack(builder, _o.AsIFixShowTargetRange()).Value;
			case IActionParams_Union_0.IFixGetItem:
				return IFixGetItem.Pack(builder, _o.AsIFixGetItem()).Value;
			case IActionParams_Union_0.ILog:
				return ILog.Pack(builder, _o.AsILog()).Value;
			case IActionParams_Union_0.IShowMessage:
				return IShowMessage.Pack(builder, _o.AsIShowMessage()).Value;
			case IActionParams_Union_0.IPrompt:
				return IPrompt.Pack(builder, _o.AsIPrompt()).Value;
			case IActionParams_Union_0.ISendNpcMail:
				return ISendNpcMail.Pack(builder, _o.AsISendNpcMail()).Value;
			case IActionParams_Union_0.IAdjustTodTime:
				return IAdjustTodTime.Pack(builder, _o.AsIAdjustTodTime()).Value;
			case IActionParams_Union_0.ISetAreaTimeState:
				return ISetAreaTimeState.Pack(builder, _o.AsISetAreaTimeState()).Value;
			case IActionParams_Union_0.ISetTimeScale:
				return ISetTimeScale.Pack(builder, _o.AsISetTimeScale()).Value;
			case IActionParams_Union_0.IJumpTalk:
				return IJumpTalk.Pack(builder, _o.AsIJumpTalk()).Value;
			case IActionParams_Union_0.ISetHeadIconVisible:
				return ISetHeadIconVisible.Pack(builder, _o.AsISetHeadIconVisible()).Value;
			case IActionParams_Union_0.IPlayMontage:
				return IPlayMontage.Pack(builder, _o.AsIPlayMontage()).Value;
			case IActionParams_Union_0.IAvgPlayRoleAction:
				return IAvgPlayRoleAction.Pack(builder, _o.AsIAvgPlayRoleAction()).Value;
			case IActionParams_Union_0.IAvgMoveRole:
				return IAvgMoveRole.Pack(builder, _o.AsIAvgMoveRole()).Value;
			case IActionParams_Union_0.IAvgFocusRole:
				return IAvgFocusRole.Pack(builder, _o.AsIAvgFocusRole()).Value;
			case IActionParams_Union_0.IAvgShakeUi:
				return IAvgShakeUi.Pack(builder, _o.AsIAvgShakeUi()).Value;
			case IActionParams_Union_0.IDestroyDynamicEntities:
				return IDestroyDynamicEntities.Pack(builder, _o.AsIDestroyDynamicEntities()).Value;
			case IActionParams_Union_0.IActorLookAt:
				return IActorLookAt.Pack(builder, _o.AsIActorLookAt()).Value;
			case IActionParams_Union_0.IActorTurnTo:
				return IActorTurnTo.Pack(builder, _o.AsIActorTurnTo()).Value;
			case IActionParams_Union_0.IShowTalk:
				return IShowTalk.Pack(builder, _o.AsIShowTalk()).Value;
			case IActionParams_Union_0.IFinishTalk:
				return IFinishTalk.Pack(builder, _o.AsIFinishTalk()).Value;
			case IActionParams_Union_0.IShowCenterText:
				return IShowCenterText.Pack(builder, _o.AsIShowCenterText()).Value;
			case IActionParams_Union_0.IFinishState:
				return IFinishState.Pack(builder, _o.AsIFinishState()).Value;
			case IActionParams_Union_0.IChangeState:
				return IChangeState.Pack(builder, _o.AsIChangeState()).Value;
			case IActionParams_Union_0.IChangeBehaviorState:
				return IChangeBehaviorState.Pack(builder, _o.AsIChangeBehaviorState()).Value;
			case IActionParams_Union_0.ISetBehaviorIsPaused:
				return ISetBehaviorIsPaused.Pack(builder, _o.AsISetBehaviorIsPaused()).Value;
			case IActionParams_Union_0.IChangeRandomState:
				return IChangeRandomState.Pack(builder, _o.AsIChangeRandomState()).Value;
			case IActionParams_Union_0.IChangeActorState:
				return IChangeActorState.Pack(builder, _o.AsIChangeActorState()).Value;
			case IActionParams_Union_0.IChangeOtherState:
				return IChangeOtherState.Pack(builder, _o.AsIChangeOtherState()).Value;
			case IActionParams_Union_0.ISetCameraMode:
				return ISetCameraMode.Pack(builder, _o.AsISetCameraMode()).Value;
			case IActionParams_Union_0.IModifySceneUiSubtitle:
				return IModifySceneUiSubtitle.Pack(builder, _o.AsIModifySceneUiSubtitle()).Value;
			case IActionParams_Union_0.ISetPlotMode:
				return ISetPlotMode.Pack(builder, _o.AsISetPlotMode()).Value;
			case IActionParams_Union_0.IPlaySequenceData:
				return IPlaySequenceData.Pack(builder, _o.AsIPlaySequenceData()).Value;
			case IActionParams_Union_0.IPlayCustomSequence:
				return IPlayCustomSequence.Pack(builder, _o.AsIPlayCustomSequence()).Value;
			case IActionParams_Union_0.IPlayMovie:
				return IPlayMovie.Pack(builder, _o.AsIPlayMovie()).Value;
			case IActionParams_Union_0.IPlayEffect:
				return IPlayEffect.Pack(builder, _o.AsIPlayEffect()).Value;
			case IActionParams_Union_0.IPlayEffect2:
				return IPlayEffect2.Pack(builder, _o.AsIPlayEffect2()).Value;
			case IActionParams_Union_0.IPlayCommonEffect:
				return IPlayCommonEffect.Pack(builder, _o.AsIPlayCommonEffect()).Value;
			case IActionParams_Union_0.IPlayScreenEffect:
				return IPlayScreenEffect.Pack(builder, _o.AsIPlayScreenEffect()).Value;
			case IActionParams_Union_0.ISwitchEffectState:
				return ISwitchEffectState.Pack(builder, _o.AsISwitchEffectState()).Value;
			case IActionParams_Union_0.IPlayDissolveEffect:
				return IPlayDissolveEffect.Pack(builder, _o.AsIPlayDissolveEffect()).Value;
			case IActionParams_Union_0.IPlayMpcEffect:
				return IPlayMpcEffect.Pack(builder, _o.AsIPlayMpcEffect()).Value;
			case IActionParams_Union_0.IRemoveEffect:
				return IRemoveEffect.Pack(builder, _o.AsIRemoveEffect()).Value;
			case IActionParams_Union_0.IWait:
				return IWait.Pack(builder, _o.AsIWait()).Value;
			case IActionParams_Union_0.IMoveToPosA:
				return IMoveToPosA.Pack(builder, _o.AsIMoveToPosA()).Value;
			case IActionParams_Union_0.ISetMoveSpeed:
				return ISetMoveSpeed.Pack(builder, _o.AsISetMoveSpeed()).Value;
			case IActionParams_Union_0.ISetPosA:
				return ISetPosA.Pack(builder, _o.AsISetPosA()).Value;
			case IActionParams_Union_0.IFaceToPos:
				return IFaceToPos.Pack(builder, _o.AsIFaceToPos()).Value;
			case IActionParams_Union_0.ISpawnChild:
				return ISpawnChild.Pack(builder, _o.AsISpawnChild()).Value;
			case IActionParams_Union_0.ISimpleMove:
				return ISimpleMove.Pack(builder, _o.AsISimpleMove()).Value;
			case IActionParams_Union_0.ISetNumberVar:
				return ISetNumberVar.Pack(builder, _o.AsISetNumberVar()).Value;
			case IActionParams_Union_0.ISyncVarToActorState:
				return ISyncVarToActorState.Pack(builder, _o.AsISyncVarToActorState()).Value;
			case IActionParams_Union_0.IDoCalculate:
				return IDoCalculate.Pack(builder, _o.AsIDoCalculate()).Value;
			case IActionParams_Union_0.ICallByCondition:
				return ICallByCondition.Pack(builder, _o.AsICallByCondition()).Value;
			case IActionParams_Union_0.ICallFunction:
				return ICallFunction.Pack(builder, _o.AsICallFunction()).Value;
			case IActionParams_Union_0.IAddFlowInteractOption:
				return IAddFlowInteractOption.Pack(builder, _o.AsIAddFlowInteractOption()).Value;
			case IActionParams_Union_0.IRemoveFlowInteractOption:
				return IRemoveFlowInteractOption.Pack(builder, _o.AsIRemoveFlowInteractOption()).Value;
			case IActionParams_Union_0.IChangeInteractOptionText:
				return IChangeInteractOptionText.Pack(builder, _o.AsIChangeInteractOptionText()).Value;
			case IActionParams_Union_0.ISpawnEntity:
				return ISpawnEntity.Pack(builder, _o.AsISpawnEntity()).Value;
			case IActionParams_Union_0.IDestroyAllChild:
				return IDestroyAllChild.Pack(builder, _o.AsIDestroyAllChild()).Value;
			case IActionParams_Union_0.IDestroyEntity:
				return IDestroyEntity.Pack(builder, _o.AsIDestroyEntity()).Value;
			case IActionParams_Union_0.IPlayFlow:
				return IPlayFlow.Pack(builder, _o.AsIPlayFlow()).Value;
			case IActionParams_Union_0.IBubbleData:
				return IBubbleData.Pack(builder, _o.AsIBubbleData()).Value;
			case IActionParams_Union_0.IPlayerLookAt:
				return IPlayerLookAt.Pack(builder, _o.AsIPlayerLookAt()).Value;
			case IActionParams_Union_0.IEntityLookAt:
				return IEntityLookAt.Pack(builder, _o.AsIEntityLookAt()).Value;
			case IActionParams_Union_0.ICharacterLookAt:
				return ICharacterLookAt.Pack(builder, _o.AsICharacterLookAt()).Value;
			case IActionParams_Union_0.IPlayerLookTowards:
				return IPlayerLookTowards.Pack(builder, _o.AsIPlayerLookTowards()).Value;
			case IActionParams_Union_0.IEntityTurnTo:
				return IEntityTurnTo.Pack(builder, _o.AsIEntityTurnTo()).Value;
			case IActionParams_Union_0.ICameraLookAt:
				return ICameraLookAt.Pack(builder, _o.AsICameraLookAt()).Value;
			case IActionParams_Union_0.IStopCameraLookAt:
				return IStopCameraLookAt.Pack(builder, _o.AsIStopCameraLookAt()).Value;
			case IActionParams_Union_0.ISetVar:
				return ISetVar.Pack(builder, _o.AsISetVar()).Value;
			case IActionParams_Union_0.ISetActorVar:
				return ISetActorVar.Pack(builder, _o.AsISetActorVar()).Value;
			case IActionParams_Union_0.ICalculateVar:
				return ICalculateVar.Pack(builder, _o.AsICalculateVar()).Value;
			case IActionParams_Union_0.IRandomVar:
				return IRandomVar.Pack(builder, _o.AsIRandomVar()).Value;
			case IActionParams_Union_0.IGuideTrigger:
				return IGuideTrigger.Pack(builder, _o.AsIGuideTrigger()).Value;
			case IActionParams_Union_0.ICompleteGuide:
				return ICompleteGuide.Pack(builder, _o.AsICompleteGuide()).Value;
			case IActionParams_Union_0.IGetItem:
				return IGetItem.Pack(builder, _o.AsIGetItem()).Value;
			case IActionParams_Union_0.IDestroyQuestItem:
				return IDestroyQuestItem.Pack(builder, _o.AsIDestroyQuestItem()).Value;
			case IActionParams_Union_0.IAwakeEntity:
				return IAwakeEntity.Pack(builder, _o.AsIAwakeEntity()).Value;
			case IActionParams_Union_0.ISetEntityVisible:
				return ISetEntityVisible.Pack(builder, _o.AsISetEntityVisible()).Value;
			case IActionParams_Union_0.ISetEntityClientVisible:
				return ISetEntityClientVisible.Pack(builder, _o.AsISetEntityClientVisible()).Value;
			case IActionParams_Union_0.ISetEntityClientVisibleSave:
				return ISetEntityClientVisibleSave.Pack(builder, _o.AsISetEntityClientVisibleSave()).Value;
			case IActionParams_Union_0.ILockEntity:
				return ILockEntity.Pack(builder, _o.AsILockEntity()).Value;
			case IActionParams_Union_0.IUnlockEntity:
				return IUnlockEntity.Pack(builder, _o.AsIUnlockEntity()).Value;
			case IActionParams_Union_0.ICompleteChildQuest:
				return ICompleteChildQuest.Pack(builder, _o.AsICompleteChildQuest()).Value;
			case IActionParams_Union_0.IAcceptCurrentQuest:
				return IAcceptCurrentQuest.Pack(builder, _o.AsIAcceptCurrentQuest()).Value;
			case IActionParams_Union_0.IFinishDoInteract:
				return IFinishDoInteract.Pack(builder, _o.AsIFinishDoInteract()).Value;
			case IActionParams_Union_0.IModifyEntityDecoration:
				return IModifyEntityDecoration.Pack(builder, _o.AsIModifyEntityDecoration()).Value;
			case IActionParams_Union_0.IAddBuffToEntity:
				return IAddBuffToEntity.Pack(builder, _o.AsIAddBuffToEntity()).Value;
			case IActionParams_Union_0.IAddBuffToPlayer:
				return IAddBuffToPlayer.Pack(builder, _o.AsIAddBuffToPlayer()).Value;
			case IActionParams_Union_0.IAddBuffToFollowShooter:
				return IAddBuffToFollowShooter.Pack(builder, _o.AsIAddBuffToFollowShooter()).Value;
			case IActionParams_Union_0.IOpenSystemBoard:
				return IOpenSystemBoard.Pack(builder, _o.AsIOpenSystemBoard()).Value;
			case IActionParams_Union_0.IOpenSystemFunction:
				return IOpenSystemFunction.Pack(builder, _o.AsIOpenSystemFunction()).Value;
			case IActionParams_Union_0.IChangeEntityState:
				return IChangeEntityState.Pack(builder, _o.AsIChangeEntityState()).Value;
			case IActionParams_Union_0.IChangeEntityStateDirectly:
				return IChangeEntityStateDirectly.Pack(builder, _o.AsIChangeEntityStateDirectly()).Value;
			case IActionParams_Union_0.IChangeEntityStateBatchDirectly:
				return IChangeEntityStateBatchDirectly.Pack(builder, _o.AsIChangeEntityStateBatchDirectly()).Value;
			case IActionParams_Union_0.IChangeEntityStateLoop:
				return IChangeEntityStateLoop.Pack(builder, _o.AsIChangeEntityStateLoop()).Value;
			case IActionParams_Union_0.IChangeNpcPerformState:
				return IChangeNpcPerformState.Pack(builder, _o.AsIChangeNpcPerformState()).Value;
			case IActionParams_Union_0.ISetForceLock:
				return ISetForceLock.Pack(builder, _o.AsISetForceLock()).Value;
			case IActionParams_Union_0.ISetAreaState:
				return ISetAreaState.Pack(builder, _o.AsISetAreaState()).Value;
			case IActionParams_Union_0.ISetWuYinQuState:
				return ISetWuYinQuState.Pack(builder, _o.AsISetWuYinQuState()).Value;
			case IActionParams_Union_0.IRemoveBuffFromEntity:
				return IRemoveBuffFromEntity.Pack(builder, _o.AsIRemoveBuffFromEntity()).Value;
			case IActionParams_Union_0.IRemoveBuffFromPlayer:
				return IRemoveBuffFromPlayer.Pack(builder, _o.AsIRemoveBuffFromPlayer()).Value;
			case IActionParams_Union_0.ICollect:
				return ICollect.Pack(builder, _o.AsICollect()).Value;
			case IActionParams_Union_0.IDestroy:
				return IDestroy.Pack(builder, _o.AsIDestroy()).Value;
			case IActionParams_Union_0.IDestroySelf:
				return IDestroySelf.Pack(builder, _o.AsIDestroySelf()).Value;
			case IActionParams_Union_0.ISetPlayerMoveControl:
				return ISetPlayerMoveControl.Pack(builder, _o.AsISetPlayerMoveControl()).Value;
			case IActionParams_Union_0.IUnlockTeleportTrigger:
				return IUnlockTeleportTrigger.Pack(builder, _o.AsIUnlockTeleportTrigger()).Value;
			case IActionParams_Union_0.IChangeTeamPosition:
				return IChangeTeamPosition.Pack(builder, _o.AsIChangeTeamPosition()).Value;
			case IActionParams_Union_0.IClientChangeTeamPosition:
				return IClientChangeTeamPosition.Pack(builder, _o.AsIClientChangeTeamPosition()).Value;
			case IActionParams_Union_0.IClaimLevelPlayReward:
				return IClaimLevelPlayReward.Pack(builder, _o.AsIClaimLevelPlayReward()).Value;
			case IActionParams_Union_0.IClaimDynamicEntityReward:
				return IClaimDynamicEntityReward.Pack(builder, _o.AsIClaimDynamicEntityReward()).Value;
			case IActionParams_Union_0.IClearFishingCabinInSaleItems:
				return IClearFishingCabinInSaleItems.Pack(builder, _o.AsIClearFishingCabinInSaleItems()).Value;
			case IActionParams_Union_0.IAcceptFishingEntrust:
				return IAcceptFishingEntrust.Pack(builder, _o.AsIAcceptFishingEntrust()).Value;
			case IActionParams_Union_0.IDestroyFishingBoat:
				return IDestroyFishingBoat.Pack(builder, _o.AsIDestroyFishingBoat()).Value;
			case IActionParams_Union_0.ITeleportDungeon:
				return ITeleportDungeon.Pack(builder, _o.AsITeleportDungeon()).Value;
			case IActionParams_Union_0.IStopUiScreenEffect:
				return IStopUiScreenEffect.Pack(builder, _o.AsIStopUiScreenEffect()).Value;
			case IActionParams_Union_0.IClaimDungeonReward:
				return IClaimDungeonReward.Pack(builder, _o.AsIClaimDungeonReward()).Value;
			case IActionParams_Union_0.ISettlementDungeon:
				return ISettlementDungeon.Pack(builder, _o.AsISettlementDungeon()).Value;
			case IActionParams_Union_0.IExitDungeon:
				return IExitDungeon.Pack(builder, _o.AsIExitDungeon()).Value;
			case IActionParams_Union_0.IUnlockDungeonEntry:
				return IUnlockDungeonEntry.Pack(builder, _o.AsIUnlockDungeonEntry()).Value;
			case IActionParams_Union_0.IFinishDungeon:
				return IFinishDungeon.Pack(builder, _o.AsIFinishDungeon()).Value;
			case IActionParams_Union_0.ISetReviveRegion:
				return ISetReviveRegion.Pack(builder, _o.AsISetReviveRegion()).Value;
			case IActionParams_Union_0.IPromptQuestChapterUI:
				return IPromptQuestChapterUI.Pack(builder, _o.AsIPromptQuestChapterUI()).Value;
			case IActionParams_Union_0.IFireBullet:
				return IFireBullet.Pack(builder, _o.AsIFireBullet()).Value;
			case IActionParams_Union_0.IFireBulletEffect:
				return IFireBulletEffect.Pack(builder, _o.AsIFireBulletEffect()).Value;
			case IActionParams_Union_0.ISetAssistCharacterPos:
				return ISetAssistCharacterPos.Pack(builder, _o.AsISetAssistCharacterPos()).Value;
			case IActionParams_Union_0.ISetPlayerPos:
				return ISetPlayerPos.Pack(builder, _o.AsISetPlayerPos()).Value;
			case IActionParams_Union_0.IClientSetPlayerPos:
				return IClientSetPlayerPos.Pack(builder, _o.AsIClientSetPlayerPos()).Value;
			case IActionParams_Union_0.IClientPreEnableSubLevels:
				return IClientPreEnableSubLevels.Pack(builder, _o.AsIClientPreEnableSubLevels()).Value;
			case IActionParams_Union_0.IRogueGotoNextFloor:
				return IRogueGotoNextFloor.Pack(builder, _o.AsIRogueGotoNextFloor()).Value;
			case IActionParams_Union_0.IRogueSelectRoom:
				return IRogueSelectRoom.Pack(builder, _o.AsIRogueSelectRoom()).Value;
			case IActionParams_Union_0.IRogueActivatePortal:
				return IRogueActivatePortal.Pack(builder, _o.AsIRogueActivatePortal()).Value;
			case IActionParams_Union_0.IRogueReceiveReward:
				return IRogueReceiveReward.Pack(builder, _o.AsIRogueReceiveReward()).Value;
			case IActionParams_Union_0.IChangeSelfEntityState:
				return IChangeSelfEntityState.Pack(builder, _o.AsIChangeSelfEntityState()).Value;
			case IActionParams_Union_0.IInterludeActions:
				return IInterludeActions.Pack(builder, _o.AsIInterludeActions()).Value;
			case IActionParams_Union_0.IAddBuffToTriggeredEntity:
				return IAddBuffToTriggeredEntity.Pack(builder, _o.AsIAddBuffToTriggeredEntity()).Value;
			case IActionParams_Union_0.IRemoveBuffToTriggeredEntity:
				return IRemoveBuffToTriggeredEntity.Pack(builder, _o.AsIRemoveBuffToTriggeredEntity()).Value;
			case IActionParams_Union_0.IDetectTrigger:
				return IDetectTrigger.Pack(builder, _o.AsIDetectTrigger()).Value;
			case IActionParams_Union_0.IItemFoundationMatch:
				return IItemFoundationMatch.Pack(builder, _o.AsIItemFoundationMatch()).Value;
			case IActionParams_Union_0.ISetBattleState:
				return ISetBattleState.Pack(builder, _o.AsISetBattleState()).Value;
			case IActionParams_Union_0.IExecBattleAction:
				return IExecBattleAction.Pack(builder, _o.AsIExecBattleAction()).Value;
			case IActionParams_Union_0.IExecClientMonsterNpcInteract:
				return IExecClientMonsterNpcInteract.Pack(builder, _o.AsIExecClientMonsterNpcInteract()).Value;
			case IActionParams_Union_0.IExecClientBattleAction:
				return IExecClientBattleAction.Pack(builder, _o.AsIExecClientBattleAction()).Value;
			case IActionParams_Union_0.IWaitBattleCondition:
				return IWaitBattleCondition.Pack(builder, _o.AsIWaitBattleCondition()).Value;
			case IActionParams_Union_0.IEnableHostility:
				return IEnableHostility.Pack(builder, _o.AsIEnableHostility()).Value;
			case IActionParams_Union_0.IUnlockSystemItem:
				return IUnlockSystemItem.Pack(builder, _o.AsIUnlockSystemItem()).Value;
			case IActionParams_Union_0.IClientUnlockAchievementSystemItem:
				return IClientUnlockAchievementSystemItem.Pack(builder, _o.AsIClientUnlockAchievementSystemItem()).Value;
			case IActionParams_Union_0.IAddPlayBubble:
				return IAddPlayBubble.Pack(builder, _o.AsIAddPlayBubble()).Value;
			case IActionParams_Union_0.IPlayBubble:
				return IPlayBubble.Pack(builder, _o.AsIPlayBubble()).Value;
			case IActionParams_Union_0.IClearPlayBubble:
				return IClearPlayBubble.Pack(builder, _o.AsIClearPlayBubble()).Value;
			case IActionParams_Union_0.IMoveWithSpline:
				return IMoveWithSpline.Pack(builder, _o.AsIMoveWithSpline()).Value;
			case IActionParams_Union_0.INewMoveWithSpline:
				return INewMoveWithSpline.Pack(builder, _o.AsINewMoveWithSpline()).Value;
			case IActionParams_Union_0.IStopNewMoveWithSpline:
				return IStopNewMoveWithSpline.Pack(builder, _o.AsIStopNewMoveWithSpline()).Value;
			case IActionParams_Union_0.ICharacterMoveToPoint:
				return ICharacterMoveToPoint.Pack(builder, _o.AsICharacterMoveToPoint()).Value;
			case IActionParams_Union_0.IPlayerMoveToPoint:
				return IPlayerMoveToPoint.Pack(builder, _o.AsIPlayerMoveToPoint()).Value;
			case IActionParams_Union_0.INpcMoveToPoint:
				return INpcMoveToPoint.Pack(builder, _o.AsINpcMoveToPoint()).Value;
			case IActionParams_Union_0.IToggleScanSplineEffect:
				return IToggleScanSplineEffect.Pack(builder, _o.AsIToggleScanSplineEffect()).Value;
			case IActionParams_Union_0.IOpenTraceSpline:
				return IOpenTraceSpline.Pack(builder, _o.AsIOpenTraceSpline()).Value;
			case IActionParams_Union_0.ICloseTraceSpline:
				return ICloseTraceSpline.Pack(builder, _o.AsICloseTraceSpline()).Value;
			case IActionParams_Union_0.ITraceSpline:
				return ITraceSpline.Pack(builder, _o.AsITraceSpline()).Value;
			case IActionParams_Union_0.IEnableAI:
				return IEnableAI.Pack(builder, _o.AsIEnableAI()).Value;
			case IActionParams_Union_0.IRunActions:
				return IRunActions.Pack(builder, _o.AsIRunActions()).Value;
			case IActionParams_Union_0.ICommonTip:
				return ICommonTip.Pack(builder, _o.AsICommonTip()).Value;
			case IActionParams_Union_0.ICommonTip2:
				return ICommonTip2.Pack(builder, _o.AsICommonTip2()).Value;
			case IActionParams_Union_0.IEndCommonTip:
				return IEndCommonTip.Pack(builder, _o.AsIEndCommonTip()).Value;
			case IActionParams_Union_0.IEnableNearbyTracking:
				return IEnableNearbyTracking.Pack(builder, _o.AsIEnableNearbyTracking()).Value;
			case IActionParams_Union_0.ISendAiEvent:
				return ISendAiEvent.Pack(builder, _o.AsISendAiEvent()).Value;
			case IActionParams_Union_0.IEnableLevelPlay:
				return IEnableLevelPlay.Pack(builder, _o.AsIEnableLevelPlay()).Value;
			case IActionParams_Union_0.IServerForceEnableLevelPlay:
				return IServerForceEnableLevelPlay.Pack(builder, _o.AsIServerForceEnableLevelPlay()).Value;
			case IActionParams_Union_0.ITeleportDungeonPos:
				return ITeleportDungeonPos.Pack(builder, _o.AsITeleportDungeonPos()).Value;
			case IActionParams_Union_0.IFadeInScreen:
				return IFadeInScreen.Pack(builder, _o.AsIFadeInScreen()).Value;
			case IActionParams_Union_0.IFadeOutScreen:
				return IFadeOutScreen.Pack(builder, _o.AsIFadeOutScreen()).Value;
			case IActionParams_Union_0.IStartFlowTemplate:
				return IStartFlowTemplate.Pack(builder, _o.AsIStartFlowTemplate()).Value;
			case IActionParams_Union_0.IEndFlowTemplate:
				return IEndFlowTemplate.Pack(builder, _o.AsIEndFlowTemplate()).Value;
			case IActionParams_Union_0.ICloseFlowTemplate:
				return ICloseFlowTemplate.Pack(builder, _o.AsICloseFlowTemplate()).Value;
			case IActionParams_Union_0.IChangeFlowTemplate:
				return IChangeFlowTemplate.Pack(builder, _o.AsIChangeFlowTemplate()).Value;
			case IActionParams_Union_0.IBeginFlowTemplate:
				return IBeginFlowTemplate.Pack(builder, _o.AsIBeginFlowTemplate()).Value;
			case IActionParams_Union_0.ISetFlowTemplate:
				return ISetFlowTemplate.Pack(builder, _o.AsISetFlowTemplate()).Value;
			case IActionParams_Union_0.IHideTargetRange:
				return IHideTargetRange.Pack(builder, _o.AsIHideTargetRange()).Value;
			case IActionParams_Union_0.IShowTargetRange:
				return IShowTargetRange.Pack(builder, _o.AsIShowTargetRange()).Value;
			case IActionParams_Union_0.IHideSpecificEntities:
				return IHideSpecificEntities.Pack(builder, _o.AsIHideSpecificEntities()).Value;
			case IActionParams_Union_0.IShowSpecificEntities:
				return IShowSpecificEntities.Pack(builder, _o.AsIShowSpecificEntities()).Value;
			case IActionParams_Union_0.IHideGroup:
				return IHideGroup.Pack(builder, _o.AsIHideGroup()).Value;
			case IActionParams_Union_0.IShowHidedGroup:
				return IShowHidedGroup.Pack(builder, _o.AsIShowHidedGroup()).Value;
			case IActionParams_Union_0.ISetSubScreenMode:
				return ISetSubScreenMode.Pack(builder, _o.AsISetSubScreenMode()).Value;
			case IActionParams_Union_0.IToggleDragActorPlay:
				return IToggleDragActorPlay.Pack(builder, _o.AsIToggleDragActorPlay()).Value;
			case IActionParams_Union_0.IDarkTideSetMapMarkState:
				return IDarkTideSetMapMarkState.Pack(builder, _o.AsIDarkTideSetMapMarkState()).Value;
			case IActionParams_Union_0.IManualOccupations:
				return IManualOccupations.Pack(builder, _o.AsIManualOccupations()).Value;
			case IActionParams_Union_0.IForceOccupations:
				return IForceOccupations.Pack(builder, _o.AsIForceOccupations()).Value;
			case IActionParams_Union_0.IChangeFightTeam:
				return IChangeFightTeam.Pack(builder, _o.AsIChangeFightTeam()).Value;
			case IActionParams_Union_0.IActiveRange:
				return IActiveRange.Pack(builder, _o.AsIActiveRange()).Value;
			case IActionParams_Union_0.IAddTrialCharacter:
				return IAddTrialCharacter.Pack(builder, _o.AsIAddTrialCharacter()).Value;
			case IActionParams_Union_0.IUpdateTrialCharacter:
				return IUpdateTrialCharacter.Pack(builder, _o.AsIUpdateTrialCharacter()).Value;
			case IActionParams_Union_0.IRestoreTrialCharacter:
				return IRestoreTrialCharacter.Pack(builder, _o.AsIRestoreTrialCharacter()).Value;
			case IActionParams_Union_0.IRemoveTrialCharacter:
				return IRemoveTrialCharacter.Pack(builder, _o.AsIRemoveTrialCharacter()).Value;
			case IActionParams_Union_0.IAddGuestCharacter:
				return IAddGuestCharacter.Pack(builder, _o.AsIAddGuestCharacter()).Value;
			case IActionParams_Union_0.IRemoveGuestCharacter:
				return IRemoveGuestCharacter.Pack(builder, _o.AsIRemoveGuestCharacter()).Value;
			case IActionParams_Union_0.IDestroyQuest:
				return IDestroyQuest.Pack(builder, _o.AsIDestroyQuest()).Value;
			case IActionParams_Union_0.ISetCameraAnim:
				return ISetCameraAnim.Pack(builder, _o.AsISetCameraAnim()).Value;
			case IActionParams_Union_0.IChangeTimer:
				return IChangeTimer.Pack(builder, _o.AsIChangeTimer()).Value;
			case IActionParams_Union_0.IToggleTimerPauseState:
				return IToggleTimerPauseState.Pack(builder, _o.AsIToggleTimerPauseState()).Value;
			case IActionParams_Union_0.IRotatorEntity:
				return IRotatorEntity.Pack(builder, _o.AsIRotatorEntity()).Value;
			case IActionParams_Union_0.IUnLimitPlayerOperation:
				return IUnLimitPlayerOperation.Pack(builder, _o.AsIUnLimitPlayerOperation()).Value;
			case IActionParams_Union_0.ILimitPlayerOperation:
				return ILimitPlayerOperation.Pack(builder, _o.AsILimitPlayerOperation()).Value;
			case IActionParams_Union_0.IEnableSystem:
				return IEnableSystem.Pack(builder, _o.AsIEnableSystem()).Value;
			case IActionParams_Union_0.ILeisureInteract:
				return ILeisureInteract.Pack(builder, _o.AsILeisureInteract()).Value;
			case IActionParams_Union_0.INpcLeisureInteract:
				return INpcLeisureInteract.Pack(builder, _o.AsINpcLeisureInteract()).Value;
			case IActionParams_Union_0.IPostAkEvent:
				return IPostAkEvent.Pack(builder, _o.AsIPostAkEvent()).Value;
			case IActionParams_Union_0.IMoveSceneItem:
				return IMoveSceneItem.Pack(builder, _o.AsIMoveSceneItem()).Value;
			case IActionParams_Union_0.IStopSceneItemMove:
				return IStopSceneItemMove.Pack(builder, _o.AsIStopSceneItemMove()).Value;
			case IActionParams_Union_0.IChangeLiftTarget:
				return IChangeLiftTarget.Pack(builder, _o.AsIChangeLiftTarget()).Value;
			case IActionParams_Union_0.IHideByRangeInFlow:
				return IHideByRangeInFlow.Pack(builder, _o.AsIHideByRangeInFlow()).Value;
			case IActionParams_Union_0.IShowAllHidedGroupInFlow:
				return IShowAllHidedGroupInFlow.Pack(builder, _o.AsIShowAllHidedGroupInFlow()).Value;
			case IActionParams_Union_0.IOpenSimpleGameplay:
				return IOpenSimpleGameplay.Pack(builder, _o.AsIOpenSimpleGameplay()).Value;
			case IActionParams_Union_0.IToggleRideFlyingCarUiGameplay:
				return IToggleRideFlyingCarUiGameplay.Pack(builder, _o.AsIToggleRideFlyingCarUiGameplay()).Value;
			case IActionParams_Union_0.IChangePhantom:
				return IChangePhantom.Pack(builder, _o.AsIChangePhantom()).Value;
			case IActionParams_Union_0.IRestorePhantom:
				return IRestorePhantom.Pack(builder, _o.AsIRestorePhantom()).Value;
			case IActionParams_Union_0.ITakePlotPhoto:
				return ITakePlotPhoto.Pack(builder, _o.AsITakePlotPhoto()).Value;
			case IActionParams_Union_0.IChangeActorTalker:
				return IChangeActorTalker.Pack(builder, _o.AsIChangeActorTalker()).Value;
			case IActionParams_Union_0.ISwitchSubLevels:
				return ISwitchSubLevels.Pack(builder, _o.AsISwitchSubLevels()).Value;
			case IActionParams_Union_0.ISwitchSubLevelsDirectly:
				return ISwitchSubLevelsDirectly.Pack(builder, _o.AsISwitchSubLevelsDirectly()).Value;
			case IActionParams_Union_0.IPreloadSubLevels:
				return IPreloadSubLevels.Pack(builder, _o.AsIPreloadSubLevels()).Value;
			case IActionParams_Union_0.ISwitchPermission:
				return ISwitchPermission.Pack(builder, _o.AsISwitchPermission()).Value;
			case IActionParams_Union_0.ISwitchDataLayers:
				return ISwitchDataLayers.Pack(builder, _o.AsISwitchDataLayers()).Value;
			case IActionParams_Union_0.IActivateResetPoint:
				return IActivateResetPoint.Pack(builder, _o.AsIActivateResetPoint()).Value;
			case IActionParams_Union_0.ITeleportToLatestResetPoint:
				return ITeleportToLatestResetPoint.Pack(builder, _o.AsITeleportToLatestResetPoint()).Value;
			case IActionParams_Union_0.ISetWeather:
				return ISetWeather.Pack(builder, _o.AsISetWeather()).Value;
			case IActionParams_Union_0.ISetTimeLockState:
				return ISetTimeLockState.Pack(builder, _o.AsISetTimeLockState()).Value;
			case IActionParams_Union_0.ISetWeatherLockState:
				return ISetWeatherLockState.Pack(builder, _o.AsISetWeatherLockState()).Value;
			case IActionParams_Union_0.IClientSetSeasonState:
				return IClientSetSeasonState.Pack(builder, _o.AsIClientSetSeasonState()).Value;
			case IActionParams_Union_0.IAxisLockScreenConfig:
				return IAxisLockScreenConfig.Pack(builder, _o.AsIAxisLockScreenConfig()).Value;
			case IActionParams_Union_0.IAdjustPlayerCamera:
				return IAdjustPlayerCamera.Pack(builder, _o.AsIAdjustPlayerCamera()).Value;
			case IActionParams_Union_0.IRestorePlayerCameraAdjustment:
				return IRestorePlayerCameraAdjustment.Pack(builder, _o.AsIRestorePlayerCameraAdjustment()).Value;
			case IActionParams_Union_0.IAdjustPlayerCameraGravity:
				return IAdjustPlayerCameraGravity.Pack(builder, _o.AsIAdjustPlayerCameraGravity()).Value;
			case IActionParams_Union_0.IEnterMovieCamera:
				return IEnterMovieCamera.Pack(builder, _o.AsIEnterMovieCamera()).Value;
			case IActionParams_Union_0.IExitMovieCamera:
				return IExitMovieCamera.Pack(builder, _o.AsIExitMovieCamera()).Value;
			case IActionParams_Union_0.IResetPlayerCameraFocus:
				return IResetPlayerCameraFocus.Pack(builder, _o.AsIResetPlayerCameraFocus()).Value;
			case IActionParams_Union_0.IUsePhantomSkill:
				return IUsePhantomSkill.Pack(builder, _o.AsIUsePhantomSkill()).Value;
			case IActionParams_Union_0.IChangePhantomFormation:
				return IChangePhantomFormation.Pack(builder, _o.AsIChangePhantomFormation()).Value;
			case IActionParams_Union_0.IRestorePhantomFormation:
				return IRestorePhantomFormation.Pack(builder, _o.AsIRestorePhantomFormation()).Value;
			default:
				return 0;
			}
		}
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200608A RID: 24714
	public class IActionParams_Union_0Union
	{
		// Token: 0x1700B629 RID: 46633
		// (get) Token: 0x06029F8D RID: 171917 RVA: 0x005C9C00 File Offset: 0x005C7E00
		// (set) Token: 0x06029F8E RID: 171918 RVA: 0x005C9C08 File Offset: 0x005C7E08
		public IActionParams_Union_0 Type { get; set; }

		// Token: 0x1700B62A RID: 46634
		// (get) Token: 0x06029F8F RID: 171919 RVA: 0x005C9C11 File Offset: 0x005C7E11
		// (set) Token: 0x06029F90 RID: 171920 RVA: 0x005C9C19 File Offset: 0x005C7E19
		public object Value { get; set; }

		// Token: 0x06029F91 RID: 171921 RVA: 0x005C9C22 File Offset: 0x005C7E22
		public IActionParams_Union_0Union()
		{
			this.Type = IActionParams_Union_0.NONE;
			this.Value = null;
		}

		// Token: 0x06029F92 RID: 171922 RVA: 0x005C9C38 File Offset: 0x005C7E38
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029F93 RID: 171923 RVA: 0x005C9C4A File Offset: 0x005C7E4A
		public IActionParamsT AsIActionParams()
		{
			return this.As<IActionParamsT>();
		}

		// Token: 0x06029F94 RID: 171924 RVA: 0x005C9C52 File Offset: 0x005C7E52
		public static IActionParams_Union_0Union FromIActionParams(IActionParamsT _iactionparams)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IActionParams,
				Value = _iactionparams
			};
		}

		// Token: 0x06029F95 RID: 171925 RVA: 0x005C9C67 File Offset: 0x005C7E67
		public IInvokeT AsIInvoke()
		{
			return this.As<IInvokeT>();
		}

		// Token: 0x06029F96 RID: 171926 RVA: 0x005C9C6F File Offset: 0x005C7E6F
		public static IActionParams_Union_0Union FromIInvoke(IInvokeT _iinvoke)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IInvoke,
				Value = _iinvoke
			};
		}

		// Token: 0x06029F97 RID: 171927 RVA: 0x005C9C84 File Offset: 0x005C7E84
		public IInteractT AsIInteract()
		{
			return this.As<IInteractT>();
		}

		// Token: 0x06029F98 RID: 171928 RVA: 0x005C9C8C File Offset: 0x005C7E8C
		public static IActionParams_Union_0Union FromIInteract(IInteractT _iinteract)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IInteract,
				Value = _iinteract
			};
		}

		// Token: 0x06029F99 RID: 171929 RVA: 0x005C9CA1 File Offset: 0x005C7EA1
		public IFinishConditionT AsIFinishCondition()
		{
			return this.As<IFinishConditionT>();
		}

		// Token: 0x06029F9A RID: 171930 RVA: 0x005C9CA9 File Offset: 0x005C7EA9
		public static IActionParams_Union_0Union FromIFinishCondition(IFinishConditionT _ifinishcondition)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFinishCondition,
				Value = _ifinishcondition
			};
		}

		// Token: 0x06029F9B RID: 171931 RVA: 0x005C9CBE File Offset: 0x005C7EBE
		public IGetRewardByInteractT AsIGetRewardByInteract()
		{
			return this.As<IGetRewardByInteractT>();
		}

		// Token: 0x06029F9C RID: 171932 RVA: 0x005C9CC6 File Offset: 0x005C7EC6
		public static IActionParams_Union_0Union FromIGetRewardByInteract(IGetRewardByInteractT _igetrewardbyinteract)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IGetRewardByInteract,
				Value = _igetrewardbyinteract
			};
		}

		// Token: 0x06029F9D RID: 171933 RVA: 0x005C9CDB File Offset: 0x005C7EDB
		public IWaitUntilLevelSequenceReachMarkT AsIWaitUntilLevelSequenceReachMark()
		{
			return this.As<IWaitUntilLevelSequenceReachMarkT>();
		}

		// Token: 0x06029F9E RID: 171934 RVA: 0x005C9CE3 File Offset: 0x005C7EE3
		public static IActionParams_Union_0Union FromIWaitUntilLevelSequenceReachMark(IWaitUntilLevelSequenceReachMarkT _iwaituntillevelsequencereachmark)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IWaitUntilLevelSequenceReachMark,
				Value = _iwaituntillevelsequencereachmark
			};
		}

		// Token: 0x06029F9F RID: 171935 RVA: 0x005C9CF8 File Offset: 0x005C7EF8
		public IClearEntityVisibleTagT AsIClearEntityVisibleTag()
		{
			return this.As<IClearEntityVisibleTagT>();
		}

		// Token: 0x06029FA0 RID: 171936 RVA: 0x005C9D00 File Offset: 0x005C7F00
		public static IActionParams_Union_0Union FromIClearEntityVisibleTag(IClearEntityVisibleTagT _iclearentityvisibletag)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IClearEntityVisibleTag,
				Value = _iclearentityvisibletag
			};
		}

		// Token: 0x06029FA1 RID: 171937 RVA: 0x005C9D15 File Offset: 0x005C7F15
		public ISetEntityPosT AsISetEntityPos()
		{
			return this.As<ISetEntityPosT>();
		}

		// Token: 0x06029FA2 RID: 171938 RVA: 0x005C9D1D File Offset: 0x005C7F1D
		public static IActionParams_Union_0Union FromISetEntityPos(ISetEntityPosT _isetentitypos)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetEntityPos,
				Value = _isetentitypos
			};
		}

		// Token: 0x06029FA3 RID: 171939 RVA: 0x005C9D32 File Offset: 0x005C7F32
		public IResetEntityPosT AsIResetEntityPos()
		{
			return this.As<IResetEntityPosT>();
		}

		// Token: 0x06029FA4 RID: 171940 RVA: 0x005C9D3A File Offset: 0x005C7F3A
		public static IActionParams_Union_0Union FromIResetEntityPos(IResetEntityPosT _iresetentitypos)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IResetEntityPos,
				Value = _iresetentitypos
			};
		}

		// Token: 0x06029FA5 RID: 171941 RVA: 0x005C9D50 File Offset: 0x005C7F50
		public IServerSetPlayerPosT AsIServerSetPlayerPos()
		{
			return this.As<IServerSetPlayerPosT>();
		}

		// Token: 0x06029FA6 RID: 171942 RVA: 0x005C9D58 File Offset: 0x005C7F58
		public static IActionParams_Union_0Union FromIServerSetPlayerPos(IServerSetPlayerPosT _iserversetplayerpos)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IServerSetPlayerPos,
				Value = _iserversetplayerpos
			};
		}

		// Token: 0x06029FA7 RID: 171943 RVA: 0x005C9D6E File Offset: 0x005C7F6E
		public IFixTeleControllerPosT AsIFixTeleControllerPos()
		{
			return this.As<IFixTeleControllerPosT>();
		}

		// Token: 0x06029FA8 RID: 171944 RVA: 0x005C9D76 File Offset: 0x005C7F76
		public static IActionParams_Union_0Union FromIFixTeleControllerPos(IFixTeleControllerPosT _ifixtelecontrollerpos)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFixTeleControllerPos,
				Value = _ifixtelecontrollerpos
			};
		}

		// Token: 0x06029FA9 RID: 171945 RVA: 0x005C9D8C File Offset: 0x005C7F8C
		public IFixTeleControllerResetPosT AsIFixTeleControllerResetPos()
		{
			return this.As<IFixTeleControllerResetPosT>();
		}

		// Token: 0x06029FAA RID: 171946 RVA: 0x005C9D94 File Offset: 0x005C7F94
		public static IActionParams_Union_0Union FromIFixTeleControllerResetPos(IFixTeleControllerResetPosT _ifixtelecontrollerresetpos)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFixTeleControllerResetPos,
				Value = _ifixtelecontrollerresetpos
			};
		}

		// Token: 0x06029FAB RID: 171947 RVA: 0x005C9DAA File Offset: 0x005C7FAA
		public IFixFoundationRelationT AsIFixFoundationRelation()
		{
			return this.As<IFixFoundationRelationT>();
		}

		// Token: 0x06029FAC RID: 171948 RVA: 0x005C9DB2 File Offset: 0x005C7FB2
		public static IActionParams_Union_0Union FromIFixFoundationRelation(IFixFoundationRelationT _ifixfoundationrelation)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFixFoundationRelation,
				Value = _ifixfoundationrelation
			};
		}

		// Token: 0x06029FAD RID: 171949 RVA: 0x005C9DC8 File Offset: 0x005C7FC8
		public ITraceCurrentQuestT AsITraceCurrentQuest()
		{
			return this.As<ITraceCurrentQuestT>();
		}

		// Token: 0x06029FAE RID: 171950 RVA: 0x005C9DD0 File Offset: 0x005C7FD0
		public static IActionParams_Union_0Union FromITraceCurrentQuest(ITraceCurrentQuestT _itracecurrentquest)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ITraceCurrentQuest,
				Value = _itracecurrentquest
			};
		}

		// Token: 0x06029FAF RID: 171951 RVA: 0x005C9DE6 File Offset: 0x005C7FE6
		public IFixShowTargetRangeT AsIFixShowTargetRange()
		{
			return this.As<IFixShowTargetRangeT>();
		}

		// Token: 0x06029FB0 RID: 171952 RVA: 0x005C9DEE File Offset: 0x005C7FEE
		public static IActionParams_Union_0Union FromIFixShowTargetRange(IFixShowTargetRangeT _ifixshowtargetrange)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFixShowTargetRange,
				Value = _ifixshowtargetrange
			};
		}

		// Token: 0x06029FB1 RID: 171953 RVA: 0x005C9E04 File Offset: 0x005C8004
		public IFixGetItemT AsIFixGetItem()
		{
			return this.As<IFixGetItemT>();
		}

		// Token: 0x06029FB2 RID: 171954 RVA: 0x005C9E0C File Offset: 0x005C800C
		public static IActionParams_Union_0Union FromIFixGetItem(IFixGetItemT _ifixgetitem)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFixGetItem,
				Value = _ifixgetitem
			};
		}

		// Token: 0x06029FB3 RID: 171955 RVA: 0x005C9E22 File Offset: 0x005C8022
		public ILogT AsILog()
		{
			return this.As<ILogT>();
		}

		// Token: 0x06029FB4 RID: 171956 RVA: 0x005C9E2A File Offset: 0x005C802A
		public static IActionParams_Union_0Union FromILog(ILogT _ilog)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ILog,
				Value = _ilog
			};
		}

		// Token: 0x06029FB5 RID: 171957 RVA: 0x005C9E40 File Offset: 0x005C8040
		public IShowMessageT AsIShowMessage()
		{
			return this.As<IShowMessageT>();
		}

		// Token: 0x06029FB6 RID: 171958 RVA: 0x005C9E48 File Offset: 0x005C8048
		public static IActionParams_Union_0Union FromIShowMessage(IShowMessageT _ishowmessage)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IShowMessage,
				Value = _ishowmessage
			};
		}

		// Token: 0x06029FB7 RID: 171959 RVA: 0x005C9E5E File Offset: 0x005C805E
		public IPromptT AsIPrompt()
		{
			return this.As<IPromptT>();
		}

		// Token: 0x06029FB8 RID: 171960 RVA: 0x005C9E66 File Offset: 0x005C8066
		public static IActionParams_Union_0Union FromIPrompt(IPromptT _iprompt)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPrompt,
				Value = _iprompt
			};
		}

		// Token: 0x06029FB9 RID: 171961 RVA: 0x005C9E7C File Offset: 0x005C807C
		public ISendNpcMailT AsISendNpcMail()
		{
			return this.As<ISendNpcMailT>();
		}

		// Token: 0x06029FBA RID: 171962 RVA: 0x005C9E84 File Offset: 0x005C8084
		public static IActionParams_Union_0Union FromISendNpcMail(ISendNpcMailT _isendnpcmail)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISendNpcMail,
				Value = _isendnpcmail
			};
		}

		// Token: 0x06029FBB RID: 171963 RVA: 0x005C9E9A File Offset: 0x005C809A
		public IAdjustTodTimeT AsIAdjustTodTime()
		{
			return this.As<IAdjustTodTimeT>();
		}

		// Token: 0x06029FBC RID: 171964 RVA: 0x005C9EA2 File Offset: 0x005C80A2
		public static IActionParams_Union_0Union FromIAdjustTodTime(IAdjustTodTimeT _iadjusttodtime)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAdjustTodTime,
				Value = _iadjusttodtime
			};
		}

		// Token: 0x06029FBD RID: 171965 RVA: 0x005C9EB8 File Offset: 0x005C80B8
		public ISetAreaTimeStateT AsISetAreaTimeState()
		{
			return this.As<ISetAreaTimeStateT>();
		}

		// Token: 0x06029FBE RID: 171966 RVA: 0x005C9EC0 File Offset: 0x005C80C0
		public static IActionParams_Union_0Union FromISetAreaTimeState(ISetAreaTimeStateT _isetareatimestate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetAreaTimeState,
				Value = _isetareatimestate
			};
		}

		// Token: 0x06029FBF RID: 171967 RVA: 0x005C9ED6 File Offset: 0x005C80D6
		public ISetTimeScaleT AsISetTimeScale()
		{
			return this.As<ISetTimeScaleT>();
		}

		// Token: 0x06029FC0 RID: 171968 RVA: 0x005C9EDE File Offset: 0x005C80DE
		public static IActionParams_Union_0Union FromISetTimeScale(ISetTimeScaleT _isettimescale)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetTimeScale,
				Value = _isettimescale
			};
		}

		// Token: 0x06029FC1 RID: 171969 RVA: 0x005C9EF4 File Offset: 0x005C80F4
		public IJumpTalkT AsIJumpTalk()
		{
			return this.As<IJumpTalkT>();
		}

		// Token: 0x06029FC2 RID: 171970 RVA: 0x005C9EFC File Offset: 0x005C80FC
		public static IActionParams_Union_0Union FromIJumpTalk(IJumpTalkT _ijumptalk)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IJumpTalk,
				Value = _ijumptalk
			};
		}

		// Token: 0x06029FC3 RID: 171971 RVA: 0x005C9F12 File Offset: 0x005C8112
		public ISetHeadIconVisibleT AsISetHeadIconVisible()
		{
			return this.As<ISetHeadIconVisibleT>();
		}

		// Token: 0x06029FC4 RID: 171972 RVA: 0x005C9F1A File Offset: 0x005C811A
		public static IActionParams_Union_0Union FromISetHeadIconVisible(ISetHeadIconVisibleT _isetheadiconvisible)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetHeadIconVisible,
				Value = _isetheadiconvisible
			};
		}

		// Token: 0x06029FC5 RID: 171973 RVA: 0x005C9F30 File Offset: 0x005C8130
		public IPlayMontageT AsIPlayMontage()
		{
			return this.As<IPlayMontageT>();
		}

		// Token: 0x06029FC6 RID: 171974 RVA: 0x005C9F38 File Offset: 0x005C8138
		public static IActionParams_Union_0Union FromIPlayMontage(IPlayMontageT _iplaymontage)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayMontage,
				Value = _iplaymontage
			};
		}

		// Token: 0x06029FC7 RID: 171975 RVA: 0x005C9F4E File Offset: 0x005C814E
		public IAvgPlayRoleActionT AsIAvgPlayRoleAction()
		{
			return this.As<IAvgPlayRoleActionT>();
		}

		// Token: 0x06029FC8 RID: 171976 RVA: 0x005C9F56 File Offset: 0x005C8156
		public static IActionParams_Union_0Union FromIAvgPlayRoleAction(IAvgPlayRoleActionT _iavgplayroleaction)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAvgPlayRoleAction,
				Value = _iavgplayroleaction
			};
		}

		// Token: 0x06029FC9 RID: 171977 RVA: 0x005C9F6C File Offset: 0x005C816C
		public IAvgMoveRoleT AsIAvgMoveRole()
		{
			return this.As<IAvgMoveRoleT>();
		}

		// Token: 0x06029FCA RID: 171978 RVA: 0x005C9F74 File Offset: 0x005C8174
		public static IActionParams_Union_0Union FromIAvgMoveRole(IAvgMoveRoleT _iavgmoverole)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAvgMoveRole,
				Value = _iavgmoverole
			};
		}

		// Token: 0x06029FCB RID: 171979 RVA: 0x005C9F8A File Offset: 0x005C818A
		public IAvgFocusRoleT AsIAvgFocusRole()
		{
			return this.As<IAvgFocusRoleT>();
		}

		// Token: 0x06029FCC RID: 171980 RVA: 0x005C9F92 File Offset: 0x005C8192
		public static IActionParams_Union_0Union FromIAvgFocusRole(IAvgFocusRoleT _iavgfocusrole)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAvgFocusRole,
				Value = _iavgfocusrole
			};
		}

		// Token: 0x06029FCD RID: 171981 RVA: 0x005C9FA8 File Offset: 0x005C81A8
		public IAvgShakeUiT AsIAvgShakeUi()
		{
			return this.As<IAvgShakeUiT>();
		}

		// Token: 0x06029FCE RID: 171982 RVA: 0x005C9FB0 File Offset: 0x005C81B0
		public static IActionParams_Union_0Union FromIAvgShakeUi(IAvgShakeUiT _iavgshakeui)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAvgShakeUi,
				Value = _iavgshakeui
			};
		}

		// Token: 0x06029FCF RID: 171983 RVA: 0x005C9FC6 File Offset: 0x005C81C6
		public IDestroyDynamicEntitiesT AsIDestroyDynamicEntities()
		{
			return this.As<IDestroyDynamicEntitiesT>();
		}

		// Token: 0x06029FD0 RID: 171984 RVA: 0x005C9FCE File Offset: 0x005C81CE
		public static IActionParams_Union_0Union FromIDestroyDynamicEntities(IDestroyDynamicEntitiesT _idestroydynamicentities)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IDestroyDynamicEntities,
				Value = _idestroydynamicentities
			};
		}

		// Token: 0x06029FD1 RID: 171985 RVA: 0x005C9FE4 File Offset: 0x005C81E4
		public IActorLookAtT AsIActorLookAt()
		{
			return this.As<IActorLookAtT>();
		}

		// Token: 0x06029FD2 RID: 171986 RVA: 0x005C9FEC File Offset: 0x005C81EC
		public static IActionParams_Union_0Union FromIActorLookAt(IActorLookAtT _iactorlookat)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IActorLookAt,
				Value = _iactorlookat
			};
		}

		// Token: 0x06029FD3 RID: 171987 RVA: 0x005CA002 File Offset: 0x005C8202
		public IActorTurnToT AsIActorTurnTo()
		{
			return this.As<IActorTurnToT>();
		}

		// Token: 0x06029FD4 RID: 171988 RVA: 0x005CA00A File Offset: 0x005C820A
		public static IActionParams_Union_0Union FromIActorTurnTo(IActorTurnToT _iactorturnto)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IActorTurnTo,
				Value = _iactorturnto
			};
		}

		// Token: 0x06029FD5 RID: 171989 RVA: 0x005CA020 File Offset: 0x005C8220
		public IShowTalkT AsIShowTalk()
		{
			return this.As<IShowTalkT>();
		}

		// Token: 0x06029FD6 RID: 171990 RVA: 0x005CA028 File Offset: 0x005C8228
		public static IActionParams_Union_0Union FromIShowTalk(IShowTalkT _ishowtalk)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IShowTalk,
				Value = _ishowtalk
			};
		}

		// Token: 0x06029FD7 RID: 171991 RVA: 0x005CA03E File Offset: 0x005C823E
		public IFinishTalkT AsIFinishTalk()
		{
			return this.As<IFinishTalkT>();
		}

		// Token: 0x06029FD8 RID: 171992 RVA: 0x005CA046 File Offset: 0x005C8246
		public static IActionParams_Union_0Union FromIFinishTalk(IFinishTalkT _ifinishtalk)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFinishTalk,
				Value = _ifinishtalk
			};
		}

		// Token: 0x06029FD9 RID: 171993 RVA: 0x005CA05C File Offset: 0x005C825C
		public IShowCenterTextT AsIShowCenterText()
		{
			return this.As<IShowCenterTextT>();
		}

		// Token: 0x06029FDA RID: 171994 RVA: 0x005CA064 File Offset: 0x005C8264
		public static IActionParams_Union_0Union FromIShowCenterText(IShowCenterTextT _ishowcentertext)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IShowCenterText,
				Value = _ishowcentertext
			};
		}

		// Token: 0x06029FDB RID: 171995 RVA: 0x005CA07A File Offset: 0x005C827A
		public IFinishStateT AsIFinishState()
		{
			return this.As<IFinishStateT>();
		}

		// Token: 0x06029FDC RID: 171996 RVA: 0x005CA082 File Offset: 0x005C8282
		public static IActionParams_Union_0Union FromIFinishState(IFinishStateT _ifinishstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFinishState,
				Value = _ifinishstate
			};
		}

		// Token: 0x06029FDD RID: 171997 RVA: 0x005CA098 File Offset: 0x005C8298
		public IChangeStateT AsIChangeState()
		{
			return this.As<IChangeStateT>();
		}

		// Token: 0x06029FDE RID: 171998 RVA: 0x005CA0A0 File Offset: 0x005C82A0
		public static IActionParams_Union_0Union FromIChangeState(IChangeStateT _ichangestate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeState,
				Value = _ichangestate
			};
		}

		// Token: 0x06029FDF RID: 171999 RVA: 0x005CA0B6 File Offset: 0x005C82B6
		public IChangeBehaviorStateT AsIChangeBehaviorState()
		{
			return this.As<IChangeBehaviorStateT>();
		}

		// Token: 0x06029FE0 RID: 172000 RVA: 0x005CA0BE File Offset: 0x005C82BE
		public static IActionParams_Union_0Union FromIChangeBehaviorState(IChangeBehaviorStateT _ichangebehaviorstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeBehaviorState,
				Value = _ichangebehaviorstate
			};
		}

		// Token: 0x06029FE1 RID: 172001 RVA: 0x005CA0D4 File Offset: 0x005C82D4
		public ISetBehaviorIsPausedT AsISetBehaviorIsPaused()
		{
			return this.As<ISetBehaviorIsPausedT>();
		}

		// Token: 0x06029FE2 RID: 172002 RVA: 0x005CA0DC File Offset: 0x005C82DC
		public static IActionParams_Union_0Union FromISetBehaviorIsPaused(ISetBehaviorIsPausedT _isetbehaviorispaused)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetBehaviorIsPaused,
				Value = _isetbehaviorispaused
			};
		}

		// Token: 0x06029FE3 RID: 172003 RVA: 0x005CA0F2 File Offset: 0x005C82F2
		public IChangeRandomStateT AsIChangeRandomState()
		{
			return this.As<IChangeRandomStateT>();
		}

		// Token: 0x06029FE4 RID: 172004 RVA: 0x005CA0FA File Offset: 0x005C82FA
		public static IActionParams_Union_0Union FromIChangeRandomState(IChangeRandomStateT _ichangerandomstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeRandomState,
				Value = _ichangerandomstate
			};
		}

		// Token: 0x06029FE5 RID: 172005 RVA: 0x005CA110 File Offset: 0x005C8310
		public IChangeActorStateT AsIChangeActorState()
		{
			return this.As<IChangeActorStateT>();
		}

		// Token: 0x06029FE6 RID: 172006 RVA: 0x005CA118 File Offset: 0x005C8318
		public static IActionParams_Union_0Union FromIChangeActorState(IChangeActorStateT _ichangeactorstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeActorState,
				Value = _ichangeactorstate
			};
		}

		// Token: 0x06029FE7 RID: 172007 RVA: 0x005CA12E File Offset: 0x005C832E
		public IChangeOtherStateT AsIChangeOtherState()
		{
			return this.As<IChangeOtherStateT>();
		}

		// Token: 0x06029FE8 RID: 172008 RVA: 0x005CA136 File Offset: 0x005C8336
		public static IActionParams_Union_0Union FromIChangeOtherState(IChangeOtherStateT _ichangeotherstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeOtherState,
				Value = _ichangeotherstate
			};
		}

		// Token: 0x06029FE9 RID: 172009 RVA: 0x005CA14C File Offset: 0x005C834C
		public ISetCameraModeT AsISetCameraMode()
		{
			return this.As<ISetCameraModeT>();
		}

		// Token: 0x06029FEA RID: 172010 RVA: 0x005CA154 File Offset: 0x005C8354
		public static IActionParams_Union_0Union FromISetCameraMode(ISetCameraModeT _isetcameramode)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetCameraMode,
				Value = _isetcameramode
			};
		}

		// Token: 0x06029FEB RID: 172011 RVA: 0x005CA16A File Offset: 0x005C836A
		public ISetPlotModeT AsISetPlotMode()
		{
			return this.As<ISetPlotModeT>();
		}

		// Token: 0x06029FEC RID: 172012 RVA: 0x005CA172 File Offset: 0x005C8372
		public static IActionParams_Union_0Union FromISetPlotMode(ISetPlotModeT _isetplotmode)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetPlotMode,
				Value = _isetplotmode
			};
		}

		// Token: 0x06029FED RID: 172013 RVA: 0x005CA188 File Offset: 0x005C8388
		public IPlaySequenceDataT AsIPlaySequenceData()
		{
			return this.As<IPlaySequenceDataT>();
		}

		// Token: 0x06029FEE RID: 172014 RVA: 0x005CA190 File Offset: 0x005C8390
		public static IActionParams_Union_0Union FromIPlaySequenceData(IPlaySequenceDataT _iplaysequencedata)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlaySequenceData,
				Value = _iplaysequencedata
			};
		}

		// Token: 0x06029FEF RID: 172015 RVA: 0x005CA1A6 File Offset: 0x005C83A6
		public IPlayCustomSequenceT AsIPlayCustomSequence()
		{
			return this.As<IPlayCustomSequenceT>();
		}

		// Token: 0x06029FF0 RID: 172016 RVA: 0x005CA1AE File Offset: 0x005C83AE
		public static IActionParams_Union_0Union FromIPlayCustomSequence(IPlayCustomSequenceT _iplaycustomsequence)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayCustomSequence,
				Value = _iplaycustomsequence
			};
		}

		// Token: 0x06029FF1 RID: 172017 RVA: 0x005CA1C4 File Offset: 0x005C83C4
		public IPlayMovieT AsIPlayMovie()
		{
			return this.As<IPlayMovieT>();
		}

		// Token: 0x06029FF2 RID: 172018 RVA: 0x005CA1CC File Offset: 0x005C83CC
		public static IActionParams_Union_0Union FromIPlayMovie(IPlayMovieT _iplaymovie)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayMovie,
				Value = _iplaymovie
			};
		}

		// Token: 0x06029FF3 RID: 172019 RVA: 0x005CA1E2 File Offset: 0x005C83E2
		public IPlayEffectT AsIPlayEffect()
		{
			return this.As<IPlayEffectT>();
		}

		// Token: 0x06029FF4 RID: 172020 RVA: 0x005CA1EA File Offset: 0x005C83EA
		public static IActionParams_Union_0Union FromIPlayEffect(IPlayEffectT _iplayeffect)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayEffect,
				Value = _iplayeffect
			};
		}

		// Token: 0x06029FF5 RID: 172021 RVA: 0x005CA200 File Offset: 0x005C8400
		public IPlayEffect2T AsIPlayEffect2()
		{
			return this.As<IPlayEffect2T>();
		}

		// Token: 0x06029FF6 RID: 172022 RVA: 0x005CA208 File Offset: 0x005C8408
		public static IActionParams_Union_0Union FromIPlayEffect2(IPlayEffect2T _iplayeffect2)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayEffect2,
				Value = _iplayeffect2
			};
		}

		// Token: 0x06029FF7 RID: 172023 RVA: 0x005CA21E File Offset: 0x005C841E
		public IPlayCommonEffectT AsIPlayCommonEffect()
		{
			return this.As<IPlayCommonEffectT>();
		}

		// Token: 0x06029FF8 RID: 172024 RVA: 0x005CA226 File Offset: 0x005C8426
		public static IActionParams_Union_0Union FromIPlayCommonEffect(IPlayCommonEffectT _iplaycommoneffect)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayCommonEffect,
				Value = _iplaycommoneffect
			};
		}

		// Token: 0x06029FF9 RID: 172025 RVA: 0x005CA23C File Offset: 0x005C843C
		public IPlayScreenEffectT AsIPlayScreenEffect()
		{
			return this.As<IPlayScreenEffectT>();
		}

		// Token: 0x06029FFA RID: 172026 RVA: 0x005CA244 File Offset: 0x005C8444
		public static IActionParams_Union_0Union FromIPlayScreenEffect(IPlayScreenEffectT _iplayscreeneffect)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayScreenEffect,
				Value = _iplayscreeneffect
			};
		}

		// Token: 0x06029FFB RID: 172027 RVA: 0x005CA25A File Offset: 0x005C845A
		public ISwitchEffectStateT AsISwitchEffectState()
		{
			return this.As<ISwitchEffectStateT>();
		}

		// Token: 0x06029FFC RID: 172028 RVA: 0x005CA262 File Offset: 0x005C8462
		public static IActionParams_Union_0Union FromISwitchEffectState(ISwitchEffectStateT _iswitcheffectstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISwitchEffectState,
				Value = _iswitcheffectstate
			};
		}

		// Token: 0x06029FFD RID: 172029 RVA: 0x005CA278 File Offset: 0x005C8478
		public IPlayDissolveEffectT AsIPlayDissolveEffect()
		{
			return this.As<IPlayDissolveEffectT>();
		}

		// Token: 0x06029FFE RID: 172030 RVA: 0x005CA280 File Offset: 0x005C8480
		public static IActionParams_Union_0Union FromIPlayDissolveEffect(IPlayDissolveEffectT _iplaydissolveeffect)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayDissolveEffect,
				Value = _iplaydissolveeffect
			};
		}

		// Token: 0x06029FFF RID: 172031 RVA: 0x005CA296 File Offset: 0x005C8496
		public IPlayMpcEffectT AsIPlayMpcEffect()
		{
			return this.As<IPlayMpcEffectT>();
		}

		// Token: 0x0602A000 RID: 172032 RVA: 0x005CA29E File Offset: 0x005C849E
		public static IActionParams_Union_0Union FromIPlayMpcEffect(IPlayMpcEffectT _iplaympceffect)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayMpcEffect,
				Value = _iplaympceffect
			};
		}

		// Token: 0x0602A001 RID: 172033 RVA: 0x005CA2B4 File Offset: 0x005C84B4
		public IRemoveEffectT AsIRemoveEffect()
		{
			return this.As<IRemoveEffectT>();
		}

		// Token: 0x0602A002 RID: 172034 RVA: 0x005CA2BC File Offset: 0x005C84BC
		public static IActionParams_Union_0Union FromIRemoveEffect(IRemoveEffectT _iremoveeffect)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRemoveEffect,
				Value = _iremoveeffect
			};
		}

		// Token: 0x0602A003 RID: 172035 RVA: 0x005CA2D2 File Offset: 0x005C84D2
		public IWaitT AsIWait()
		{
			return this.As<IWaitT>();
		}

		// Token: 0x0602A004 RID: 172036 RVA: 0x005CA2DA File Offset: 0x005C84DA
		public static IActionParams_Union_0Union FromIWait(IWaitT _iwait)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IWait,
				Value = _iwait
			};
		}

		// Token: 0x0602A005 RID: 172037 RVA: 0x005CA2F0 File Offset: 0x005C84F0
		public IMoveToPosAT AsIMoveToPosA()
		{
			return this.As<IMoveToPosAT>();
		}

		// Token: 0x0602A006 RID: 172038 RVA: 0x005CA2F8 File Offset: 0x005C84F8
		public static IActionParams_Union_0Union FromIMoveToPosA(IMoveToPosAT _imovetoposa)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IMoveToPosA,
				Value = _imovetoposa
			};
		}

		// Token: 0x0602A007 RID: 172039 RVA: 0x005CA30E File Offset: 0x005C850E
		public ISetMoveSpeedT AsISetMoveSpeed()
		{
			return this.As<ISetMoveSpeedT>();
		}

		// Token: 0x0602A008 RID: 172040 RVA: 0x005CA316 File Offset: 0x005C8516
		public static IActionParams_Union_0Union FromISetMoveSpeed(ISetMoveSpeedT _isetmovespeed)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetMoveSpeed,
				Value = _isetmovespeed
			};
		}

		// Token: 0x0602A009 RID: 172041 RVA: 0x005CA32C File Offset: 0x005C852C
		public ISetPosAT AsISetPosA()
		{
			return this.As<ISetPosAT>();
		}

		// Token: 0x0602A00A RID: 172042 RVA: 0x005CA334 File Offset: 0x005C8534
		public static IActionParams_Union_0Union FromISetPosA(ISetPosAT _isetposa)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetPosA,
				Value = _isetposa
			};
		}

		// Token: 0x0602A00B RID: 172043 RVA: 0x005CA34A File Offset: 0x005C854A
		public IFaceToPosT AsIFaceToPos()
		{
			return this.As<IFaceToPosT>();
		}

		// Token: 0x0602A00C RID: 172044 RVA: 0x005CA352 File Offset: 0x005C8552
		public static IActionParams_Union_0Union FromIFaceToPos(IFaceToPosT _ifacetopos)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFaceToPos,
				Value = _ifacetopos
			};
		}

		// Token: 0x0602A00D RID: 172045 RVA: 0x005CA368 File Offset: 0x005C8568
		public ISpawnChildT AsISpawnChild()
		{
			return this.As<ISpawnChildT>();
		}

		// Token: 0x0602A00E RID: 172046 RVA: 0x005CA370 File Offset: 0x005C8570
		public static IActionParams_Union_0Union FromISpawnChild(ISpawnChildT _ispawnchild)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISpawnChild,
				Value = _ispawnchild
			};
		}

		// Token: 0x0602A00F RID: 172047 RVA: 0x005CA386 File Offset: 0x005C8586
		public ISimpleMoveT AsISimpleMove()
		{
			return this.As<ISimpleMoveT>();
		}

		// Token: 0x0602A010 RID: 172048 RVA: 0x005CA38E File Offset: 0x005C858E
		public static IActionParams_Union_0Union FromISimpleMove(ISimpleMoveT _isimplemove)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISimpleMove,
				Value = _isimplemove
			};
		}

		// Token: 0x0602A011 RID: 172049 RVA: 0x005CA3A4 File Offset: 0x005C85A4
		public ISetNumberVarT AsISetNumberVar()
		{
			return this.As<ISetNumberVarT>();
		}

		// Token: 0x0602A012 RID: 172050 RVA: 0x005CA3AC File Offset: 0x005C85AC
		public static IActionParams_Union_0Union FromISetNumberVar(ISetNumberVarT _isetnumbervar)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetNumberVar,
				Value = _isetnumbervar
			};
		}

		// Token: 0x0602A013 RID: 172051 RVA: 0x005CA3C2 File Offset: 0x005C85C2
		public ISyncVarToActorStateT AsISyncVarToActorState()
		{
			return this.As<ISyncVarToActorStateT>();
		}

		// Token: 0x0602A014 RID: 172052 RVA: 0x005CA3CA File Offset: 0x005C85CA
		public static IActionParams_Union_0Union FromISyncVarToActorState(ISyncVarToActorStateT _isyncvartoactorstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISyncVarToActorState,
				Value = _isyncvartoactorstate
			};
		}

		// Token: 0x0602A015 RID: 172053 RVA: 0x005CA3E0 File Offset: 0x005C85E0
		public IDoCalculateT AsIDoCalculate()
		{
			return this.As<IDoCalculateT>();
		}

		// Token: 0x0602A016 RID: 172054 RVA: 0x005CA3E8 File Offset: 0x005C85E8
		public static IActionParams_Union_0Union FromIDoCalculate(IDoCalculateT _idocalculate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IDoCalculate,
				Value = _idocalculate
			};
		}

		// Token: 0x0602A017 RID: 172055 RVA: 0x005CA3FE File Offset: 0x005C85FE
		public ICallByConditionT AsICallByCondition()
		{
			return this.As<ICallByConditionT>();
		}

		// Token: 0x0602A018 RID: 172056 RVA: 0x005CA406 File Offset: 0x005C8606
		public static IActionParams_Union_0Union FromICallByCondition(ICallByConditionT _icallbycondition)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICallByCondition,
				Value = _icallbycondition
			};
		}

		// Token: 0x0602A019 RID: 172057 RVA: 0x005CA41C File Offset: 0x005C861C
		public ICallFunctionT AsICallFunction()
		{
			return this.As<ICallFunctionT>();
		}

		// Token: 0x0602A01A RID: 172058 RVA: 0x005CA424 File Offset: 0x005C8624
		public static IActionParams_Union_0Union FromICallFunction(ICallFunctionT _icallfunction)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICallFunction,
				Value = _icallfunction
			};
		}

		// Token: 0x0602A01B RID: 172059 RVA: 0x005CA43A File Offset: 0x005C863A
		public IAddFlowInteractOptionT AsIAddFlowInteractOption()
		{
			return this.As<IAddFlowInteractOptionT>();
		}

		// Token: 0x0602A01C RID: 172060 RVA: 0x005CA442 File Offset: 0x005C8642
		public static IActionParams_Union_0Union FromIAddFlowInteractOption(IAddFlowInteractOptionT _iaddflowinteractoption)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAddFlowInteractOption,
				Value = _iaddflowinteractoption
			};
		}

		// Token: 0x0602A01D RID: 172061 RVA: 0x005CA458 File Offset: 0x005C8658
		public IRemoveFlowInteractOptionT AsIRemoveFlowInteractOption()
		{
			return this.As<IRemoveFlowInteractOptionT>();
		}

		// Token: 0x0602A01E RID: 172062 RVA: 0x005CA460 File Offset: 0x005C8660
		public static IActionParams_Union_0Union FromIRemoveFlowInteractOption(IRemoveFlowInteractOptionT _iremoveflowinteractoption)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRemoveFlowInteractOption,
				Value = _iremoveflowinteractoption
			};
		}

		// Token: 0x0602A01F RID: 172063 RVA: 0x005CA476 File Offset: 0x005C8676
		public IChangeInteractOptionTextT AsIChangeInteractOptionText()
		{
			return this.As<IChangeInteractOptionTextT>();
		}

		// Token: 0x0602A020 RID: 172064 RVA: 0x005CA47E File Offset: 0x005C867E
		public static IActionParams_Union_0Union FromIChangeInteractOptionText(IChangeInteractOptionTextT _ichangeinteractoptiontext)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeInteractOptionText,
				Value = _ichangeinteractoptiontext
			};
		}

		// Token: 0x0602A021 RID: 172065 RVA: 0x005CA494 File Offset: 0x005C8694
		public ISpawnEntityT AsISpawnEntity()
		{
			return this.As<ISpawnEntityT>();
		}

		// Token: 0x0602A022 RID: 172066 RVA: 0x005CA49C File Offset: 0x005C869C
		public static IActionParams_Union_0Union FromISpawnEntity(ISpawnEntityT _ispawnentity)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISpawnEntity,
				Value = _ispawnentity
			};
		}

		// Token: 0x0602A023 RID: 172067 RVA: 0x005CA4B2 File Offset: 0x005C86B2
		public IDestroyAllChildT AsIDestroyAllChild()
		{
			return this.As<IDestroyAllChildT>();
		}

		// Token: 0x0602A024 RID: 172068 RVA: 0x005CA4BA File Offset: 0x005C86BA
		public static IActionParams_Union_0Union FromIDestroyAllChild(IDestroyAllChildT _idestroyallchild)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IDestroyAllChild,
				Value = _idestroyallchild
			};
		}

		// Token: 0x0602A025 RID: 172069 RVA: 0x005CA4D0 File Offset: 0x005C86D0
		public IDestroyEntityT AsIDestroyEntity()
		{
			return this.As<IDestroyEntityT>();
		}

		// Token: 0x0602A026 RID: 172070 RVA: 0x005CA4D8 File Offset: 0x005C86D8
		public static IActionParams_Union_0Union FromIDestroyEntity(IDestroyEntityT _idestroyentity)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IDestroyEntity,
				Value = _idestroyentity
			};
		}

		// Token: 0x0602A027 RID: 172071 RVA: 0x005CA4EE File Offset: 0x005C86EE
		public IPlayFlowT AsIPlayFlow()
		{
			return this.As<IPlayFlowT>();
		}

		// Token: 0x0602A028 RID: 172072 RVA: 0x005CA4F6 File Offset: 0x005C86F6
		public static IActionParams_Union_0Union FromIPlayFlow(IPlayFlowT _iplayflow)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayFlow,
				Value = _iplayflow
			};
		}

		// Token: 0x0602A029 RID: 172073 RVA: 0x005CA50C File Offset: 0x005C870C
		public IBubbleDataT AsIBubbleData()
		{
			return this.As<IBubbleDataT>();
		}

		// Token: 0x0602A02A RID: 172074 RVA: 0x005CA514 File Offset: 0x005C8714
		public static IActionParams_Union_0Union FromIBubbleData(IBubbleDataT _ibubbledata)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IBubbleData,
				Value = _ibubbledata
			};
		}

		// Token: 0x0602A02B RID: 172075 RVA: 0x005CA52A File Offset: 0x005C872A
		public IPlayerLookAtT AsIPlayerLookAt()
		{
			return this.As<IPlayerLookAtT>();
		}

		// Token: 0x0602A02C RID: 172076 RVA: 0x005CA532 File Offset: 0x005C8732
		public static IActionParams_Union_0Union FromIPlayerLookAt(IPlayerLookAtT _iplayerlookat)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayerLookAt,
				Value = _iplayerlookat
			};
		}

		// Token: 0x0602A02D RID: 172077 RVA: 0x005CA548 File Offset: 0x005C8748
		public IEntityLookAtT AsIEntityLookAt()
		{
			return this.As<IEntityLookAtT>();
		}

		// Token: 0x0602A02E RID: 172078 RVA: 0x005CA550 File Offset: 0x005C8750
		public static IActionParams_Union_0Union FromIEntityLookAt(IEntityLookAtT _ientitylookat)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEntityLookAt,
				Value = _ientitylookat
			};
		}

		// Token: 0x0602A02F RID: 172079 RVA: 0x005CA566 File Offset: 0x005C8766
		public ICharacterLookAtT AsICharacterLookAt()
		{
			return this.As<ICharacterLookAtT>();
		}

		// Token: 0x0602A030 RID: 172080 RVA: 0x005CA56E File Offset: 0x005C876E
		public static IActionParams_Union_0Union FromICharacterLookAt(ICharacterLookAtT _icharacterlookat)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICharacterLookAt,
				Value = _icharacterlookat
			};
		}

		// Token: 0x0602A031 RID: 172081 RVA: 0x005CA584 File Offset: 0x005C8784
		public IPlayerLookTowardsT AsIPlayerLookTowards()
		{
			return this.As<IPlayerLookTowardsT>();
		}

		// Token: 0x0602A032 RID: 172082 RVA: 0x005CA58C File Offset: 0x005C878C
		public static IActionParams_Union_0Union FromIPlayerLookTowards(IPlayerLookTowardsT _iplayerlooktowards)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayerLookTowards,
				Value = _iplayerlooktowards
			};
		}

		// Token: 0x0602A033 RID: 172083 RVA: 0x005CA5A2 File Offset: 0x005C87A2
		public IEntityTurnToT AsIEntityTurnTo()
		{
			return this.As<IEntityTurnToT>();
		}

		// Token: 0x0602A034 RID: 172084 RVA: 0x005CA5AA File Offset: 0x005C87AA
		public static IActionParams_Union_0Union FromIEntityTurnTo(IEntityTurnToT _ientityturnto)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEntityTurnTo,
				Value = _ientityturnto
			};
		}

		// Token: 0x0602A035 RID: 172085 RVA: 0x005CA5C0 File Offset: 0x005C87C0
		public ICameraLookAtT AsICameraLookAt()
		{
			return this.As<ICameraLookAtT>();
		}

		// Token: 0x0602A036 RID: 172086 RVA: 0x005CA5C8 File Offset: 0x005C87C8
		public static IActionParams_Union_0Union FromICameraLookAt(ICameraLookAtT _icameralookat)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICameraLookAt,
				Value = _icameralookat
			};
		}

		// Token: 0x0602A037 RID: 172087 RVA: 0x005CA5DE File Offset: 0x005C87DE
		public IStopCameraLookAtT AsIStopCameraLookAt()
		{
			return this.As<IStopCameraLookAtT>();
		}

		// Token: 0x0602A038 RID: 172088 RVA: 0x005CA5E6 File Offset: 0x005C87E6
		public static IActionParams_Union_0Union FromIStopCameraLookAt(IStopCameraLookAtT _istopcameralookat)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IStopCameraLookAt,
				Value = _istopcameralookat
			};
		}

		// Token: 0x0602A039 RID: 172089 RVA: 0x005CA5FC File Offset: 0x005C87FC
		public ISetVarT AsISetVar()
		{
			return this.As<ISetVarT>();
		}

		// Token: 0x0602A03A RID: 172090 RVA: 0x005CA604 File Offset: 0x005C8804
		public static IActionParams_Union_0Union FromISetVar(ISetVarT _isetvar)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetVar,
				Value = _isetvar
			};
		}

		// Token: 0x0602A03B RID: 172091 RVA: 0x005CA61A File Offset: 0x005C881A
		public ISetActorVarT AsISetActorVar()
		{
			return this.As<ISetActorVarT>();
		}

		// Token: 0x0602A03C RID: 172092 RVA: 0x005CA622 File Offset: 0x005C8822
		public static IActionParams_Union_0Union FromISetActorVar(ISetActorVarT _isetactorvar)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetActorVar,
				Value = _isetactorvar
			};
		}

		// Token: 0x0602A03D RID: 172093 RVA: 0x005CA638 File Offset: 0x005C8838
		public ICalculateVarT AsICalculateVar()
		{
			return this.As<ICalculateVarT>();
		}

		// Token: 0x0602A03E RID: 172094 RVA: 0x005CA640 File Offset: 0x005C8840
		public static IActionParams_Union_0Union FromICalculateVar(ICalculateVarT _icalculatevar)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICalculateVar,
				Value = _icalculatevar
			};
		}

		// Token: 0x0602A03F RID: 172095 RVA: 0x005CA656 File Offset: 0x005C8856
		public IRandomVarT AsIRandomVar()
		{
			return this.As<IRandomVarT>();
		}

		// Token: 0x0602A040 RID: 172096 RVA: 0x005CA65E File Offset: 0x005C885E
		public static IActionParams_Union_0Union FromIRandomVar(IRandomVarT _irandomvar)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRandomVar,
				Value = _irandomvar
			};
		}

		// Token: 0x0602A041 RID: 172097 RVA: 0x005CA674 File Offset: 0x005C8874
		public IGuideTriggerT AsIGuideTrigger()
		{
			return this.As<IGuideTriggerT>();
		}

		// Token: 0x0602A042 RID: 172098 RVA: 0x005CA67C File Offset: 0x005C887C
		public static IActionParams_Union_0Union FromIGuideTrigger(IGuideTriggerT _iguidetrigger)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IGuideTrigger,
				Value = _iguidetrigger
			};
		}

		// Token: 0x0602A043 RID: 172099 RVA: 0x005CA692 File Offset: 0x005C8892
		public ICompleteGuideT AsICompleteGuide()
		{
			return this.As<ICompleteGuideT>();
		}

		// Token: 0x0602A044 RID: 172100 RVA: 0x005CA69A File Offset: 0x005C889A
		public static IActionParams_Union_0Union FromICompleteGuide(ICompleteGuideT _icompleteguide)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICompleteGuide,
				Value = _icompleteguide
			};
		}

		// Token: 0x0602A045 RID: 172101 RVA: 0x005CA6B0 File Offset: 0x005C88B0
		public IGetItemT AsIGetItem()
		{
			return this.As<IGetItemT>();
		}

		// Token: 0x0602A046 RID: 172102 RVA: 0x005CA6B8 File Offset: 0x005C88B8
		public static IActionParams_Union_0Union FromIGetItem(IGetItemT _igetitem)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IGetItem,
				Value = _igetitem
			};
		}

		// Token: 0x0602A047 RID: 172103 RVA: 0x005CA6CE File Offset: 0x005C88CE
		public IDestroyQuestItemT AsIDestroyQuestItem()
		{
			return this.As<IDestroyQuestItemT>();
		}

		// Token: 0x0602A048 RID: 172104 RVA: 0x005CA6D6 File Offset: 0x005C88D6
		public static IActionParams_Union_0Union FromIDestroyQuestItem(IDestroyQuestItemT _idestroyquestitem)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IDestroyQuestItem,
				Value = _idestroyquestitem
			};
		}

		// Token: 0x0602A049 RID: 172105 RVA: 0x005CA6EC File Offset: 0x005C88EC
		public IAwakeEntityT AsIAwakeEntity()
		{
			return this.As<IAwakeEntityT>();
		}

		// Token: 0x0602A04A RID: 172106 RVA: 0x005CA6F4 File Offset: 0x005C88F4
		public static IActionParams_Union_0Union FromIAwakeEntity(IAwakeEntityT _iawakeentity)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAwakeEntity,
				Value = _iawakeentity
			};
		}

		// Token: 0x0602A04B RID: 172107 RVA: 0x005CA70A File Offset: 0x005C890A
		public ISetEntityVisibleT AsISetEntityVisible()
		{
			return this.As<ISetEntityVisibleT>();
		}

		// Token: 0x0602A04C RID: 172108 RVA: 0x005CA712 File Offset: 0x005C8912
		public static IActionParams_Union_0Union FromISetEntityVisible(ISetEntityVisibleT _isetentityvisible)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetEntityVisible,
				Value = _isetentityvisible
			};
		}

		// Token: 0x0602A04D RID: 172109 RVA: 0x005CA728 File Offset: 0x005C8928
		public ISetEntityClientVisibleT AsISetEntityClientVisible()
		{
			return this.As<ISetEntityClientVisibleT>();
		}

		// Token: 0x0602A04E RID: 172110 RVA: 0x005CA730 File Offset: 0x005C8930
		public static IActionParams_Union_0Union FromISetEntityClientVisible(ISetEntityClientVisibleT _isetentityclientvisible)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetEntityClientVisible,
				Value = _isetentityclientvisible
			};
		}

		// Token: 0x0602A04F RID: 172111 RVA: 0x005CA746 File Offset: 0x005C8946
		public ISetEntityClientVisibleSaveT AsISetEntityClientVisibleSave()
		{
			return this.As<ISetEntityClientVisibleSaveT>();
		}

		// Token: 0x0602A050 RID: 172112 RVA: 0x005CA74E File Offset: 0x005C894E
		public static IActionParams_Union_0Union FromISetEntityClientVisibleSave(ISetEntityClientVisibleSaveT _isetentityclientvisiblesave)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetEntityClientVisibleSave,
				Value = _isetentityclientvisiblesave
			};
		}

		// Token: 0x0602A051 RID: 172113 RVA: 0x005CA764 File Offset: 0x005C8964
		public ILockEntityT AsILockEntity()
		{
			return this.As<ILockEntityT>();
		}

		// Token: 0x0602A052 RID: 172114 RVA: 0x005CA76C File Offset: 0x005C896C
		public static IActionParams_Union_0Union FromILockEntity(ILockEntityT _ilockentity)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ILockEntity,
				Value = _ilockentity
			};
		}

		// Token: 0x0602A053 RID: 172115 RVA: 0x005CA782 File Offset: 0x005C8982
		public IUnlockEntityT AsIUnlockEntity()
		{
			return this.As<IUnlockEntityT>();
		}

		// Token: 0x0602A054 RID: 172116 RVA: 0x005CA78A File Offset: 0x005C898A
		public static IActionParams_Union_0Union FromIUnlockEntity(IUnlockEntityT _iunlockentity)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IUnlockEntity,
				Value = _iunlockentity
			};
		}

		// Token: 0x0602A055 RID: 172117 RVA: 0x005CA7A0 File Offset: 0x005C89A0
		public ICompleteChildQuestT AsICompleteChildQuest()
		{
			return this.As<ICompleteChildQuestT>();
		}

		// Token: 0x0602A056 RID: 172118 RVA: 0x005CA7A8 File Offset: 0x005C89A8
		public static IActionParams_Union_0Union FromICompleteChildQuest(ICompleteChildQuestT _icompletechildquest)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICompleteChildQuest,
				Value = _icompletechildquest
			};
		}

		// Token: 0x0602A057 RID: 172119 RVA: 0x005CA7BE File Offset: 0x005C89BE
		public IAcceptCurrentQuestT AsIAcceptCurrentQuest()
		{
			return this.As<IAcceptCurrentQuestT>();
		}

		// Token: 0x0602A058 RID: 172120 RVA: 0x005CA7C6 File Offset: 0x005C89C6
		public static IActionParams_Union_0Union FromIAcceptCurrentQuest(IAcceptCurrentQuestT _iacceptcurrentquest)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAcceptCurrentQuest,
				Value = _iacceptcurrentquest
			};
		}

		// Token: 0x0602A059 RID: 172121 RVA: 0x005CA7DC File Offset: 0x005C89DC
		public IFinishDoInteractT AsIFinishDoInteract()
		{
			return this.As<IFinishDoInteractT>();
		}

		// Token: 0x0602A05A RID: 172122 RVA: 0x005CA7E4 File Offset: 0x005C89E4
		public static IActionParams_Union_0Union FromIFinishDoInteract(IFinishDoInteractT _ifinishdointeract)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFinishDoInteract,
				Value = _ifinishdointeract
			};
		}

		// Token: 0x0602A05B RID: 172123 RVA: 0x005CA7FA File Offset: 0x005C89FA
		public IAddBuffToEntityT AsIAddBuffToEntity()
		{
			return this.As<IAddBuffToEntityT>();
		}

		// Token: 0x0602A05C RID: 172124 RVA: 0x005CA802 File Offset: 0x005C8A02
		public static IActionParams_Union_0Union FromIAddBuffToEntity(IAddBuffToEntityT _iaddbufftoentity)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAddBuffToEntity,
				Value = _iaddbufftoentity
			};
		}

		// Token: 0x0602A05D RID: 172125 RVA: 0x005CA818 File Offset: 0x005C8A18
		public IAddBuffToPlayerT AsIAddBuffToPlayer()
		{
			return this.As<IAddBuffToPlayerT>();
		}

		// Token: 0x0602A05E RID: 172126 RVA: 0x005CA820 File Offset: 0x005C8A20
		public static IActionParams_Union_0Union FromIAddBuffToPlayer(IAddBuffToPlayerT _iaddbufftoplayer)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAddBuffToPlayer,
				Value = _iaddbufftoplayer
			};
		}

		// Token: 0x0602A05F RID: 172127 RVA: 0x005CA836 File Offset: 0x005C8A36
		public IAddBuffToFollowShooterT AsIAddBuffToFollowShooter()
		{
			return this.As<IAddBuffToFollowShooterT>();
		}

		// Token: 0x0602A060 RID: 172128 RVA: 0x005CA83E File Offset: 0x005C8A3E
		public static IActionParams_Union_0Union FromIAddBuffToFollowShooter(IAddBuffToFollowShooterT _iaddbufftofollowshooter)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAddBuffToFollowShooter,
				Value = _iaddbufftofollowshooter
			};
		}

		// Token: 0x0602A061 RID: 172129 RVA: 0x005CA854 File Offset: 0x005C8A54
		public IOpenSystemBoardT AsIOpenSystemBoard()
		{
			return this.As<IOpenSystemBoardT>();
		}

		// Token: 0x0602A062 RID: 172130 RVA: 0x005CA85C File Offset: 0x005C8A5C
		public static IActionParams_Union_0Union FromIOpenSystemBoard(IOpenSystemBoardT _iopensystemboard)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IOpenSystemBoard,
				Value = _iopensystemboard
			};
		}

		// Token: 0x0602A063 RID: 172131 RVA: 0x005CA872 File Offset: 0x005C8A72
		public IOpenSystemFunctionT AsIOpenSystemFunction()
		{
			return this.As<IOpenSystemFunctionT>();
		}

		// Token: 0x0602A064 RID: 172132 RVA: 0x005CA87A File Offset: 0x005C8A7A
		public static IActionParams_Union_0Union FromIOpenSystemFunction(IOpenSystemFunctionT _iopensystemfunction)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IOpenSystemFunction,
				Value = _iopensystemfunction
			};
		}

		// Token: 0x0602A065 RID: 172133 RVA: 0x005CA890 File Offset: 0x005C8A90
		public IChangeEntityStateT AsIChangeEntityState()
		{
			return this.As<IChangeEntityStateT>();
		}

		// Token: 0x0602A066 RID: 172134 RVA: 0x005CA898 File Offset: 0x005C8A98
		public static IActionParams_Union_0Union FromIChangeEntityState(IChangeEntityStateT _ichangeentitystate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeEntityState,
				Value = _ichangeentitystate
			};
		}

		// Token: 0x0602A067 RID: 172135 RVA: 0x005CA8AE File Offset: 0x005C8AAE
		public IChangeEntityStateDirectlyT AsIChangeEntityStateDirectly()
		{
			return this.As<IChangeEntityStateDirectlyT>();
		}

		// Token: 0x0602A068 RID: 172136 RVA: 0x005CA8B6 File Offset: 0x005C8AB6
		public static IActionParams_Union_0Union FromIChangeEntityStateDirectly(IChangeEntityStateDirectlyT _ichangeentitystatedirectly)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeEntityStateDirectly,
				Value = _ichangeentitystatedirectly
			};
		}

		// Token: 0x0602A069 RID: 172137 RVA: 0x005CA8CC File Offset: 0x005C8ACC
		public IChangeEntityStateBatchDirectlyT AsIChangeEntityStateBatchDirectly()
		{
			return this.As<IChangeEntityStateBatchDirectlyT>();
		}

		// Token: 0x0602A06A RID: 172138 RVA: 0x005CA8D4 File Offset: 0x005C8AD4
		public static IActionParams_Union_0Union FromIChangeEntityStateBatchDirectly(IChangeEntityStateBatchDirectlyT _ichangeentitystatebatchdirectly)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeEntityStateBatchDirectly,
				Value = _ichangeentitystatebatchdirectly
			};
		}

		// Token: 0x0602A06B RID: 172139 RVA: 0x005CA8EA File Offset: 0x005C8AEA
		public IChangeEntityStateLoopT AsIChangeEntityStateLoop()
		{
			return this.As<IChangeEntityStateLoopT>();
		}

		// Token: 0x0602A06C RID: 172140 RVA: 0x005CA8F2 File Offset: 0x005C8AF2
		public static IActionParams_Union_0Union FromIChangeEntityStateLoop(IChangeEntityStateLoopT _ichangeentitystateloop)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeEntityStateLoop,
				Value = _ichangeentitystateloop
			};
		}

		// Token: 0x0602A06D RID: 172141 RVA: 0x005CA908 File Offset: 0x005C8B08
		public IChangeNpcPerformStateT AsIChangeNpcPerformState()
		{
			return this.As<IChangeNpcPerformStateT>();
		}

		// Token: 0x0602A06E RID: 172142 RVA: 0x005CA910 File Offset: 0x005C8B10
		public static IActionParams_Union_0Union FromIChangeNpcPerformState(IChangeNpcPerformStateT _ichangenpcperformstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeNpcPerformState,
				Value = _ichangenpcperformstate
			};
		}

		// Token: 0x0602A06F RID: 172143 RVA: 0x005CA926 File Offset: 0x005C8B26
		public ISetForceLockT AsISetForceLock()
		{
			return this.As<ISetForceLockT>();
		}

		// Token: 0x0602A070 RID: 172144 RVA: 0x005CA92E File Offset: 0x005C8B2E
		public static IActionParams_Union_0Union FromISetForceLock(ISetForceLockT _isetforcelock)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetForceLock,
				Value = _isetforcelock
			};
		}

		// Token: 0x0602A071 RID: 172145 RVA: 0x005CA944 File Offset: 0x005C8B44
		public ISetAreaStateT AsISetAreaState()
		{
			return this.As<ISetAreaStateT>();
		}

		// Token: 0x0602A072 RID: 172146 RVA: 0x005CA94C File Offset: 0x005C8B4C
		public static IActionParams_Union_0Union FromISetAreaState(ISetAreaStateT _isetareastate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetAreaState,
				Value = _isetareastate
			};
		}

		// Token: 0x0602A073 RID: 172147 RVA: 0x005CA962 File Offset: 0x005C8B62
		public ISetWuYinQuStateT AsISetWuYinQuState()
		{
			return this.As<ISetWuYinQuStateT>();
		}

		// Token: 0x0602A074 RID: 172148 RVA: 0x005CA96A File Offset: 0x005C8B6A
		public static IActionParams_Union_0Union FromISetWuYinQuState(ISetWuYinQuStateT _isetwuyinqustate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetWuYinQuState,
				Value = _isetwuyinqustate
			};
		}

		// Token: 0x0602A075 RID: 172149 RVA: 0x005CA980 File Offset: 0x005C8B80
		public IRemoveBuffFromEntityT AsIRemoveBuffFromEntity()
		{
			return this.As<IRemoveBuffFromEntityT>();
		}

		// Token: 0x0602A076 RID: 172150 RVA: 0x005CA988 File Offset: 0x005C8B88
		public static IActionParams_Union_0Union FromIRemoveBuffFromEntity(IRemoveBuffFromEntityT _iremovebufffromentity)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRemoveBuffFromEntity,
				Value = _iremovebufffromentity
			};
		}

		// Token: 0x0602A077 RID: 172151 RVA: 0x005CA99E File Offset: 0x005C8B9E
		public IRemoveBuffFromPlayerT AsIRemoveBuffFromPlayer()
		{
			return this.As<IRemoveBuffFromPlayerT>();
		}

		// Token: 0x0602A078 RID: 172152 RVA: 0x005CA9A6 File Offset: 0x005C8BA6
		public static IActionParams_Union_0Union FromIRemoveBuffFromPlayer(IRemoveBuffFromPlayerT _iremovebufffromplayer)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRemoveBuffFromPlayer,
				Value = _iremovebufffromplayer
			};
		}

		// Token: 0x0602A079 RID: 172153 RVA: 0x005CA9BC File Offset: 0x005C8BBC
		public ICollectT AsICollect()
		{
			return this.As<ICollectT>();
		}

		// Token: 0x0602A07A RID: 172154 RVA: 0x005CA9C4 File Offset: 0x005C8BC4
		public static IActionParams_Union_0Union FromICollect(ICollectT _icollect)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICollect,
				Value = _icollect
			};
		}

		// Token: 0x0602A07B RID: 172155 RVA: 0x005CA9DA File Offset: 0x005C8BDA
		public IDestroyT AsIDestroy()
		{
			return this.As<IDestroyT>();
		}

		// Token: 0x0602A07C RID: 172156 RVA: 0x005CA9E2 File Offset: 0x005C8BE2
		public static IActionParams_Union_0Union FromIDestroy(IDestroyT _idestroy)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IDestroy,
				Value = _idestroy
			};
		}

		// Token: 0x0602A07D RID: 172157 RVA: 0x005CA9F8 File Offset: 0x005C8BF8
		public IDestroySelfT AsIDestroySelf()
		{
			return this.As<IDestroySelfT>();
		}

		// Token: 0x0602A07E RID: 172158 RVA: 0x005CAA00 File Offset: 0x005C8C00
		public static IActionParams_Union_0Union FromIDestroySelf(IDestroySelfT _idestroyself)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IDestroySelf,
				Value = _idestroyself
			};
		}

		// Token: 0x0602A07F RID: 172159 RVA: 0x005CAA16 File Offset: 0x005C8C16
		public ISetPlayerMoveControlT AsISetPlayerMoveControl()
		{
			return this.As<ISetPlayerMoveControlT>();
		}

		// Token: 0x0602A080 RID: 172160 RVA: 0x005CAA1E File Offset: 0x005C8C1E
		public static IActionParams_Union_0Union FromISetPlayerMoveControl(ISetPlayerMoveControlT _isetplayermovecontrol)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetPlayerMoveControl,
				Value = _isetplayermovecontrol
			};
		}

		// Token: 0x0602A081 RID: 172161 RVA: 0x005CAA34 File Offset: 0x005C8C34
		public IUnlockTeleportTriggerT AsIUnlockTeleportTrigger()
		{
			return this.As<IUnlockTeleportTriggerT>();
		}

		// Token: 0x0602A082 RID: 172162 RVA: 0x005CAA3C File Offset: 0x005C8C3C
		public static IActionParams_Union_0Union FromIUnlockTeleportTrigger(IUnlockTeleportTriggerT _iunlockteleporttrigger)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IUnlockTeleportTrigger,
				Value = _iunlockteleporttrigger
			};
		}

		// Token: 0x0602A083 RID: 172163 RVA: 0x005CAA52 File Offset: 0x005C8C52
		public IChangeTeamPositionT AsIChangeTeamPosition()
		{
			return this.As<IChangeTeamPositionT>();
		}

		// Token: 0x0602A084 RID: 172164 RVA: 0x005CAA5A File Offset: 0x005C8C5A
		public static IActionParams_Union_0Union FromIChangeTeamPosition(IChangeTeamPositionT _ichangeteamposition)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeTeamPosition,
				Value = _ichangeteamposition
			};
		}

		// Token: 0x0602A085 RID: 172165 RVA: 0x005CAA70 File Offset: 0x005C8C70
		public IClientChangeTeamPositionT AsIClientChangeTeamPosition()
		{
			return this.As<IClientChangeTeamPositionT>();
		}

		// Token: 0x0602A086 RID: 172166 RVA: 0x005CAA78 File Offset: 0x005C8C78
		public static IActionParams_Union_0Union FromIClientChangeTeamPosition(IClientChangeTeamPositionT _iclientchangeteamposition)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IClientChangeTeamPosition,
				Value = _iclientchangeteamposition
			};
		}

		// Token: 0x0602A087 RID: 172167 RVA: 0x005CAA8E File Offset: 0x005C8C8E
		public IClaimLevelPlayRewardT AsIClaimLevelPlayReward()
		{
			return this.As<IClaimLevelPlayRewardT>();
		}

		// Token: 0x0602A088 RID: 172168 RVA: 0x005CAA96 File Offset: 0x005C8C96
		public static IActionParams_Union_0Union FromIClaimLevelPlayReward(IClaimLevelPlayRewardT _iclaimlevelplayreward)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IClaimLevelPlayReward,
				Value = _iclaimlevelplayreward
			};
		}

		// Token: 0x0602A089 RID: 172169 RVA: 0x005CAAAC File Offset: 0x005C8CAC
		public IClaimDynamicEntityRewardT AsIClaimDynamicEntityReward()
		{
			return this.As<IClaimDynamicEntityRewardT>();
		}

		// Token: 0x0602A08A RID: 172170 RVA: 0x005CAAB4 File Offset: 0x005C8CB4
		public static IActionParams_Union_0Union FromIClaimDynamicEntityReward(IClaimDynamicEntityRewardT _iclaimdynamicentityreward)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IClaimDynamicEntityReward,
				Value = _iclaimdynamicentityreward
			};
		}

		// Token: 0x0602A08B RID: 172171 RVA: 0x005CAACA File Offset: 0x005C8CCA
		public IClearFishingCabinInSaleItemsT AsIClearFishingCabinInSaleItems()
		{
			return this.As<IClearFishingCabinInSaleItemsT>();
		}

		// Token: 0x0602A08C RID: 172172 RVA: 0x005CAAD2 File Offset: 0x005C8CD2
		public static IActionParams_Union_0Union FromIClearFishingCabinInSaleItems(IClearFishingCabinInSaleItemsT _iclearfishingcabininsaleitems)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IClearFishingCabinInSaleItems,
				Value = _iclearfishingcabininsaleitems
			};
		}

		// Token: 0x0602A08D RID: 172173 RVA: 0x005CAAE8 File Offset: 0x005C8CE8
		public IAcceptFishingEntrustT AsIAcceptFishingEntrust()
		{
			return this.As<IAcceptFishingEntrustT>();
		}

		// Token: 0x0602A08E RID: 172174 RVA: 0x005CAAF0 File Offset: 0x005C8CF0
		public static IActionParams_Union_0Union FromIAcceptFishingEntrust(IAcceptFishingEntrustT _iacceptfishingentrust)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAcceptFishingEntrust,
				Value = _iacceptfishingentrust
			};
		}

		// Token: 0x0602A08F RID: 172175 RVA: 0x005CAB06 File Offset: 0x005C8D06
		public IDestroyFishingBoatT AsIDestroyFishingBoat()
		{
			return this.As<IDestroyFishingBoatT>();
		}

		// Token: 0x0602A090 RID: 172176 RVA: 0x005CAB0E File Offset: 0x005C8D0E
		public static IActionParams_Union_0Union FromIDestroyFishingBoat(IDestroyFishingBoatT _idestroyfishingboat)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IDestroyFishingBoat,
				Value = _idestroyfishingboat
			};
		}

		// Token: 0x0602A091 RID: 172177 RVA: 0x005CAB24 File Offset: 0x005C8D24
		public ITeleportDungeonT AsITeleportDungeon()
		{
			return this.As<ITeleportDungeonT>();
		}

		// Token: 0x0602A092 RID: 172178 RVA: 0x005CAB2C File Offset: 0x005C8D2C
		public static IActionParams_Union_0Union FromITeleportDungeon(ITeleportDungeonT _iteleportdungeon)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ITeleportDungeon,
				Value = _iteleportdungeon
			};
		}

		// Token: 0x0602A093 RID: 172179 RVA: 0x005CAB45 File Offset: 0x005C8D45
		public IStopUiScreenEffectT AsIStopUiScreenEffect()
		{
			return this.As<IStopUiScreenEffectT>();
		}

		// Token: 0x0602A094 RID: 172180 RVA: 0x005CAB4D File Offset: 0x005C8D4D
		public static IActionParams_Union_0Union FromIStopUiScreenEffect(IStopUiScreenEffectT _istopuiscreeneffect)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IStopUiScreenEffect,
				Value = _istopuiscreeneffect
			};
		}

		// Token: 0x0602A095 RID: 172181 RVA: 0x005CAB66 File Offset: 0x005C8D66
		public IClaimDungeonRewardT AsIClaimDungeonReward()
		{
			return this.As<IClaimDungeonRewardT>();
		}

		// Token: 0x0602A096 RID: 172182 RVA: 0x005CAB6E File Offset: 0x005C8D6E
		public static IActionParams_Union_0Union FromIClaimDungeonReward(IClaimDungeonRewardT _iclaimdungeonreward)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IClaimDungeonReward,
				Value = _iclaimdungeonreward
			};
		}

		// Token: 0x0602A097 RID: 172183 RVA: 0x005CAB87 File Offset: 0x005C8D87
		public ISettlementDungeonT AsISettlementDungeon()
		{
			return this.As<ISettlementDungeonT>();
		}

		// Token: 0x0602A098 RID: 172184 RVA: 0x005CAB8F File Offset: 0x005C8D8F
		public static IActionParams_Union_0Union FromISettlementDungeon(ISettlementDungeonT _isettlementdungeon)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISettlementDungeon,
				Value = _isettlementdungeon
			};
		}

		// Token: 0x0602A099 RID: 172185 RVA: 0x005CABA8 File Offset: 0x005C8DA8
		public IExitDungeonT AsIExitDungeon()
		{
			return this.As<IExitDungeonT>();
		}

		// Token: 0x0602A09A RID: 172186 RVA: 0x005CABB0 File Offset: 0x005C8DB0
		public static IActionParams_Union_0Union FromIExitDungeon(IExitDungeonT _iexitdungeon)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IExitDungeon,
				Value = _iexitdungeon
			};
		}

		// Token: 0x0602A09B RID: 172187 RVA: 0x005CABC9 File Offset: 0x005C8DC9
		public IUnlockDungeonEntryT AsIUnlockDungeonEntry()
		{
			return this.As<IUnlockDungeonEntryT>();
		}

		// Token: 0x0602A09C RID: 172188 RVA: 0x005CABD1 File Offset: 0x005C8DD1
		public static IActionParams_Union_0Union FromIUnlockDungeonEntry(IUnlockDungeonEntryT _iunlockdungeonentry)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IUnlockDungeonEntry,
				Value = _iunlockdungeonentry
			};
		}

		// Token: 0x0602A09D RID: 172189 RVA: 0x005CABEA File Offset: 0x005C8DEA
		public IFinishDungeonT AsIFinishDungeon()
		{
			return this.As<IFinishDungeonT>();
		}

		// Token: 0x0602A09E RID: 172190 RVA: 0x005CABF2 File Offset: 0x005C8DF2
		public static IActionParams_Union_0Union FromIFinishDungeon(IFinishDungeonT _ifinishdungeon)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFinishDungeon,
				Value = _ifinishdungeon
			};
		}

		// Token: 0x0602A09F RID: 172191 RVA: 0x005CAC0B File Offset: 0x005C8E0B
		public ISetReviveRegionT AsISetReviveRegion()
		{
			return this.As<ISetReviveRegionT>();
		}

		// Token: 0x0602A0A0 RID: 172192 RVA: 0x005CAC13 File Offset: 0x005C8E13
		public static IActionParams_Union_0Union FromISetReviveRegion(ISetReviveRegionT _isetreviveregion)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetReviveRegion,
				Value = _isetreviveregion
			};
		}

		// Token: 0x0602A0A1 RID: 172193 RVA: 0x005CAC2C File Offset: 0x005C8E2C
		public IPromptQuestChapterUIT AsIPromptQuestChapterUI()
		{
			return this.As<IPromptQuestChapterUIT>();
		}

		// Token: 0x0602A0A2 RID: 172194 RVA: 0x005CAC34 File Offset: 0x005C8E34
		public static IActionParams_Union_0Union FromIPromptQuestChapterUI(IPromptQuestChapterUIT _ipromptquestchapterui)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPromptQuestChapterUI,
				Value = _ipromptquestchapterui
			};
		}

		// Token: 0x0602A0A3 RID: 172195 RVA: 0x005CAC4D File Offset: 0x005C8E4D
		public IFireBulletT AsIFireBullet()
		{
			return this.As<IFireBulletT>();
		}

		// Token: 0x0602A0A4 RID: 172196 RVA: 0x005CAC55 File Offset: 0x005C8E55
		public static IActionParams_Union_0Union FromIFireBullet(IFireBulletT _ifirebullet)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFireBullet,
				Value = _ifirebullet
			};
		}

		// Token: 0x0602A0A5 RID: 172197 RVA: 0x005CAC6E File Offset: 0x005C8E6E
		public IFireBulletEffectT AsIFireBulletEffect()
		{
			return this.As<IFireBulletEffectT>();
		}

		// Token: 0x0602A0A6 RID: 172198 RVA: 0x005CAC76 File Offset: 0x005C8E76
		public static IActionParams_Union_0Union FromIFireBulletEffect(IFireBulletEffectT _ifirebulleteffect)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFireBulletEffect,
				Value = _ifirebulleteffect
			};
		}

		// Token: 0x0602A0A7 RID: 172199 RVA: 0x005CAC8F File Offset: 0x005C8E8F
		public ISetPlayerPosT AsISetPlayerPos()
		{
			return this.As<ISetPlayerPosT>();
		}

		// Token: 0x0602A0A8 RID: 172200 RVA: 0x005CAC97 File Offset: 0x005C8E97
		public static IActionParams_Union_0Union FromISetPlayerPos(ISetPlayerPosT _isetplayerpos)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetPlayerPos,
				Value = _isetplayerpos
			};
		}

		// Token: 0x0602A0A9 RID: 172201 RVA: 0x005CACB0 File Offset: 0x005C8EB0
		public IClientSetPlayerPosT AsIClientSetPlayerPos()
		{
			return this.As<IClientSetPlayerPosT>();
		}

		// Token: 0x0602A0AA RID: 172202 RVA: 0x005CACB8 File Offset: 0x005C8EB8
		public static IActionParams_Union_0Union FromIClientSetPlayerPos(IClientSetPlayerPosT _iclientsetplayerpos)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IClientSetPlayerPos,
				Value = _iclientsetplayerpos
			};
		}

		// Token: 0x0602A0AB RID: 172203 RVA: 0x005CACD1 File Offset: 0x005C8ED1
		public IClientPreEnableSubLevelsT AsIClientPreEnableSubLevels()
		{
			return this.As<IClientPreEnableSubLevelsT>();
		}

		// Token: 0x0602A0AC RID: 172204 RVA: 0x005CACD9 File Offset: 0x005C8ED9
		public static IActionParams_Union_0Union FromIClientPreEnableSubLevels(IClientPreEnableSubLevelsT _iclientpreenablesublevels)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IClientPreEnableSubLevels,
				Value = _iclientpreenablesublevels
			};
		}

		// Token: 0x0602A0AD RID: 172205 RVA: 0x005CACF2 File Offset: 0x005C8EF2
		public IRogueGotoNextFloorT AsIRogueGotoNextFloor()
		{
			return this.As<IRogueGotoNextFloorT>();
		}

		// Token: 0x0602A0AE RID: 172206 RVA: 0x005CACFA File Offset: 0x005C8EFA
		public static IActionParams_Union_0Union FromIRogueGotoNextFloor(IRogueGotoNextFloorT _iroguegotonextfloor)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRogueGotoNextFloor,
				Value = _iroguegotonextfloor
			};
		}

		// Token: 0x0602A0AF RID: 172207 RVA: 0x005CAD13 File Offset: 0x005C8F13
		public IRogueSelectRoomT AsIRogueSelectRoom()
		{
			return this.As<IRogueSelectRoomT>();
		}

		// Token: 0x0602A0B0 RID: 172208 RVA: 0x005CAD1B File Offset: 0x005C8F1B
		public static IActionParams_Union_0Union FromIRogueSelectRoom(IRogueSelectRoomT _irogueselectroom)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRogueSelectRoom,
				Value = _irogueselectroom
			};
		}

		// Token: 0x0602A0B1 RID: 172209 RVA: 0x005CAD34 File Offset: 0x005C8F34
		public IRogueActivatePortalT AsIRogueActivatePortal()
		{
			return this.As<IRogueActivatePortalT>();
		}

		// Token: 0x0602A0B2 RID: 172210 RVA: 0x005CAD3C File Offset: 0x005C8F3C
		public static IActionParams_Union_0Union FromIRogueActivatePortal(IRogueActivatePortalT _irogueactivateportal)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRogueActivatePortal,
				Value = _irogueactivateportal
			};
		}

		// Token: 0x0602A0B3 RID: 172211 RVA: 0x005CAD55 File Offset: 0x005C8F55
		public IRogueReceiveRewardT AsIRogueReceiveReward()
		{
			return this.As<IRogueReceiveRewardT>();
		}

		// Token: 0x0602A0B4 RID: 172212 RVA: 0x005CAD5D File Offset: 0x005C8F5D
		public static IActionParams_Union_0Union FromIRogueReceiveReward(IRogueReceiveRewardT _iroguereceivereward)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRogueReceiveReward,
				Value = _iroguereceivereward
			};
		}

		// Token: 0x0602A0B5 RID: 172213 RVA: 0x005CAD76 File Offset: 0x005C8F76
		public IChangeSelfEntityStateT AsIChangeSelfEntityState()
		{
			return this.As<IChangeSelfEntityStateT>();
		}

		// Token: 0x0602A0B6 RID: 172214 RVA: 0x005CAD7E File Offset: 0x005C8F7E
		public static IActionParams_Union_0Union FromIChangeSelfEntityState(IChangeSelfEntityStateT _ichangeselfentitystate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeSelfEntityState,
				Value = _ichangeselfentitystate
			};
		}

		// Token: 0x0602A0B7 RID: 172215 RVA: 0x005CAD97 File Offset: 0x005C8F97
		public IInterludeActionsT AsIInterludeActions()
		{
			return this.As<IInterludeActionsT>();
		}

		// Token: 0x0602A0B8 RID: 172216 RVA: 0x005CAD9F File Offset: 0x005C8F9F
		public static IActionParams_Union_0Union FromIInterludeActions(IInterludeActionsT _iinterludeactions)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IInterludeActions,
				Value = _iinterludeactions
			};
		}

		// Token: 0x0602A0B9 RID: 172217 RVA: 0x005CADB8 File Offset: 0x005C8FB8
		public IAddBuffToTriggeredEntityT AsIAddBuffToTriggeredEntity()
		{
			return this.As<IAddBuffToTriggeredEntityT>();
		}

		// Token: 0x0602A0BA RID: 172218 RVA: 0x005CADC0 File Offset: 0x005C8FC0
		public static IActionParams_Union_0Union FromIAddBuffToTriggeredEntity(IAddBuffToTriggeredEntityT _iaddbufftotriggeredentity)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAddBuffToTriggeredEntity,
				Value = _iaddbufftotriggeredentity
			};
		}

		// Token: 0x0602A0BB RID: 172219 RVA: 0x005CADD9 File Offset: 0x005C8FD9
		public IRemoveBuffToTriggeredEntityT AsIRemoveBuffToTriggeredEntity()
		{
			return this.As<IRemoveBuffToTriggeredEntityT>();
		}

		// Token: 0x0602A0BC RID: 172220 RVA: 0x005CADE1 File Offset: 0x005C8FE1
		public static IActionParams_Union_0Union FromIRemoveBuffToTriggeredEntity(IRemoveBuffToTriggeredEntityT _iremovebufftotriggeredentity)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRemoveBuffToTriggeredEntity,
				Value = _iremovebufftotriggeredentity
			};
		}

		// Token: 0x0602A0BD RID: 172221 RVA: 0x005CADFA File Offset: 0x005C8FFA
		public IDetectTriggerT AsIDetectTrigger()
		{
			return this.As<IDetectTriggerT>();
		}

		// Token: 0x0602A0BE RID: 172222 RVA: 0x005CAE02 File Offset: 0x005C9002
		public static IActionParams_Union_0Union FromIDetectTrigger(IDetectTriggerT _idetecttrigger)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IDetectTrigger,
				Value = _idetecttrigger
			};
		}

		// Token: 0x0602A0BF RID: 172223 RVA: 0x005CAE1B File Offset: 0x005C901B
		public IItemFoundationMatchT AsIItemFoundationMatch()
		{
			return this.As<IItemFoundationMatchT>();
		}

		// Token: 0x0602A0C0 RID: 172224 RVA: 0x005CAE23 File Offset: 0x005C9023
		public static IActionParams_Union_0Union FromIItemFoundationMatch(IItemFoundationMatchT _iitemfoundationmatch)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IItemFoundationMatch,
				Value = _iitemfoundationmatch
			};
		}

		// Token: 0x0602A0C1 RID: 172225 RVA: 0x005CAE3C File Offset: 0x005C903C
		public ISetBattleStateT AsISetBattleState()
		{
			return this.As<ISetBattleStateT>();
		}

		// Token: 0x0602A0C2 RID: 172226 RVA: 0x005CAE44 File Offset: 0x005C9044
		public static IActionParams_Union_0Union FromISetBattleState(ISetBattleStateT _isetbattlestate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetBattleState,
				Value = _isetbattlestate
			};
		}

		// Token: 0x0602A0C3 RID: 172227 RVA: 0x005CAE5D File Offset: 0x005C905D
		public IExecBattleActionT AsIExecBattleAction()
		{
			return this.As<IExecBattleActionT>();
		}

		// Token: 0x0602A0C4 RID: 172228 RVA: 0x005CAE65 File Offset: 0x005C9065
		public static IActionParams_Union_0Union FromIExecBattleAction(IExecBattleActionT _iexecbattleaction)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IExecBattleAction,
				Value = _iexecbattleaction
			};
		}

		// Token: 0x0602A0C5 RID: 172229 RVA: 0x005CAE7E File Offset: 0x005C907E
		public IExecClientMonsterNpcInteractT AsIExecClientMonsterNpcInteract()
		{
			return this.As<IExecClientMonsterNpcInteractT>();
		}

		// Token: 0x0602A0C6 RID: 172230 RVA: 0x005CAE86 File Offset: 0x005C9086
		public static IActionParams_Union_0Union FromIExecClientMonsterNpcInteract(IExecClientMonsterNpcInteractT _iexecclientmonsternpcinteract)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IExecClientMonsterNpcInteract,
				Value = _iexecclientmonsternpcinteract
			};
		}

		// Token: 0x0602A0C7 RID: 172231 RVA: 0x005CAE9F File Offset: 0x005C909F
		public IExecClientBattleActionT AsIExecClientBattleAction()
		{
			return this.As<IExecClientBattleActionT>();
		}

		// Token: 0x0602A0C8 RID: 172232 RVA: 0x005CAEA7 File Offset: 0x005C90A7
		public static IActionParams_Union_0Union FromIExecClientBattleAction(IExecClientBattleActionT _iexecclientbattleaction)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IExecClientBattleAction,
				Value = _iexecclientbattleaction
			};
		}

		// Token: 0x0602A0C9 RID: 172233 RVA: 0x005CAEC0 File Offset: 0x005C90C0
		public IWaitBattleConditionT AsIWaitBattleCondition()
		{
			return this.As<IWaitBattleConditionT>();
		}

		// Token: 0x0602A0CA RID: 172234 RVA: 0x005CAEC8 File Offset: 0x005C90C8
		public static IActionParams_Union_0Union FromIWaitBattleCondition(IWaitBattleConditionT _iwaitbattlecondition)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IWaitBattleCondition,
				Value = _iwaitbattlecondition
			};
		}

		// Token: 0x0602A0CB RID: 172235 RVA: 0x005CAEE1 File Offset: 0x005C90E1
		public IEnableHostilityT AsIEnableHostility()
		{
			return this.As<IEnableHostilityT>();
		}

		// Token: 0x0602A0CC RID: 172236 RVA: 0x005CAEE9 File Offset: 0x005C90E9
		public static IActionParams_Union_0Union FromIEnableHostility(IEnableHostilityT _ienablehostility)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEnableHostility,
				Value = _ienablehostility
			};
		}

		// Token: 0x0602A0CD RID: 172237 RVA: 0x005CAF02 File Offset: 0x005C9102
		public IUnlockSystemItemT AsIUnlockSystemItem()
		{
			return this.As<IUnlockSystemItemT>();
		}

		// Token: 0x0602A0CE RID: 172238 RVA: 0x005CAF0A File Offset: 0x005C910A
		public static IActionParams_Union_0Union FromIUnlockSystemItem(IUnlockSystemItemT _iunlocksystemitem)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IUnlockSystemItem,
				Value = _iunlocksystemitem
			};
		}

		// Token: 0x0602A0CF RID: 172239 RVA: 0x005CAF23 File Offset: 0x005C9123
		public IClientUnlockAchievementSystemItemT AsIClientUnlockAchievementSystemItem()
		{
			return this.As<IClientUnlockAchievementSystemItemT>();
		}

		// Token: 0x0602A0D0 RID: 172240 RVA: 0x005CAF2B File Offset: 0x005C912B
		public static IActionParams_Union_0Union FromIClientUnlockAchievementSystemItem(IClientUnlockAchievementSystemItemT _iclientunlockachievementsystemitem)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IClientUnlockAchievementSystemItem,
				Value = _iclientunlockachievementsystemitem
			};
		}

		// Token: 0x0602A0D1 RID: 172241 RVA: 0x005CAF44 File Offset: 0x005C9144
		public IAddPlayBubbleT AsIAddPlayBubble()
		{
			return this.As<IAddPlayBubbleT>();
		}

		// Token: 0x0602A0D2 RID: 172242 RVA: 0x005CAF4C File Offset: 0x005C914C
		public static IActionParams_Union_0Union FromIAddPlayBubble(IAddPlayBubbleT _iaddplaybubble)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAddPlayBubble,
				Value = _iaddplaybubble
			};
		}

		// Token: 0x0602A0D3 RID: 172243 RVA: 0x005CAF65 File Offset: 0x005C9165
		public IPlayBubbleT AsIPlayBubble()
		{
			return this.As<IPlayBubbleT>();
		}

		// Token: 0x0602A0D4 RID: 172244 RVA: 0x005CAF6D File Offset: 0x005C916D
		public static IActionParams_Union_0Union FromIPlayBubble(IPlayBubbleT _iplaybubble)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayBubble,
				Value = _iplaybubble
			};
		}

		// Token: 0x0602A0D5 RID: 172245 RVA: 0x005CAF86 File Offset: 0x005C9186
		public IClearPlayBubbleT AsIClearPlayBubble()
		{
			return this.As<IClearPlayBubbleT>();
		}

		// Token: 0x0602A0D6 RID: 172246 RVA: 0x005CAF8E File Offset: 0x005C918E
		public static IActionParams_Union_0Union FromIClearPlayBubble(IClearPlayBubbleT _iclearplaybubble)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IClearPlayBubble,
				Value = _iclearplaybubble
			};
		}

		// Token: 0x0602A0D7 RID: 172247 RVA: 0x005CAFA7 File Offset: 0x005C91A7
		public IMoveWithSplineT AsIMoveWithSpline()
		{
			return this.As<IMoveWithSplineT>();
		}

		// Token: 0x0602A0D8 RID: 172248 RVA: 0x005CAFAF File Offset: 0x005C91AF
		public static IActionParams_Union_0Union FromIMoveWithSpline(IMoveWithSplineT _imovewithspline)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IMoveWithSpline,
				Value = _imovewithspline
			};
		}

		// Token: 0x0602A0D9 RID: 172249 RVA: 0x005CAFC8 File Offset: 0x005C91C8
		public INewMoveWithSplineT AsINewMoveWithSpline()
		{
			return this.As<INewMoveWithSplineT>();
		}

		// Token: 0x0602A0DA RID: 172250 RVA: 0x005CAFD0 File Offset: 0x005C91D0
		public static IActionParams_Union_0Union FromINewMoveWithSpline(INewMoveWithSplineT _inewmovewithspline)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.INewMoveWithSpline,
				Value = _inewmovewithspline
			};
		}

		// Token: 0x0602A0DB RID: 172251 RVA: 0x005CAFE9 File Offset: 0x005C91E9
		public IStopNewMoveWithSplineT AsIStopNewMoveWithSpline()
		{
			return this.As<IStopNewMoveWithSplineT>();
		}

		// Token: 0x0602A0DC RID: 172252 RVA: 0x005CAFF1 File Offset: 0x005C91F1
		public static IActionParams_Union_0Union FromIStopNewMoveWithSpline(IStopNewMoveWithSplineT _istopnewmovewithspline)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IStopNewMoveWithSpline,
				Value = _istopnewmovewithspline
			};
		}

		// Token: 0x0602A0DD RID: 172253 RVA: 0x005CB00A File Offset: 0x005C920A
		public ICharacterMoveToPointT AsICharacterMoveToPoint()
		{
			return this.As<ICharacterMoveToPointT>();
		}

		// Token: 0x0602A0DE RID: 172254 RVA: 0x005CB012 File Offset: 0x005C9212
		public static IActionParams_Union_0Union FromICharacterMoveToPoint(ICharacterMoveToPointT _icharactermovetopoint)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICharacterMoveToPoint,
				Value = _icharactermovetopoint
			};
		}

		// Token: 0x0602A0DF RID: 172255 RVA: 0x005CB02B File Offset: 0x005C922B
		public IPlayerMoveToPointT AsIPlayerMoveToPoint()
		{
			return this.As<IPlayerMoveToPointT>();
		}

		// Token: 0x0602A0E0 RID: 172256 RVA: 0x005CB033 File Offset: 0x005C9233
		public static IActionParams_Union_0Union FromIPlayerMoveToPoint(IPlayerMoveToPointT _iplayermovetopoint)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPlayerMoveToPoint,
				Value = _iplayermovetopoint
			};
		}

		// Token: 0x0602A0E1 RID: 172257 RVA: 0x005CB04C File Offset: 0x005C924C
		public INpcMoveToPointT AsINpcMoveToPoint()
		{
			return this.As<INpcMoveToPointT>();
		}

		// Token: 0x0602A0E2 RID: 172258 RVA: 0x005CB054 File Offset: 0x005C9254
		public static IActionParams_Union_0Union FromINpcMoveToPoint(INpcMoveToPointT _inpcmovetopoint)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.INpcMoveToPoint,
				Value = _inpcmovetopoint
			};
		}

		// Token: 0x0602A0E3 RID: 172259 RVA: 0x005CB06D File Offset: 0x005C926D
		public IToggleScanSplineEffectT AsIToggleScanSplineEffect()
		{
			return this.As<IToggleScanSplineEffectT>();
		}

		// Token: 0x0602A0E4 RID: 172260 RVA: 0x005CB075 File Offset: 0x005C9275
		public static IActionParams_Union_0Union FromIToggleScanSplineEffect(IToggleScanSplineEffectT _itogglescansplineeffect)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IToggleScanSplineEffect,
				Value = _itogglescansplineeffect
			};
		}

		// Token: 0x0602A0E5 RID: 172261 RVA: 0x005CB08E File Offset: 0x005C928E
		public IOpenTraceSplineT AsIOpenTraceSpline()
		{
			return this.As<IOpenTraceSplineT>();
		}

		// Token: 0x0602A0E6 RID: 172262 RVA: 0x005CB096 File Offset: 0x005C9296
		public static IActionParams_Union_0Union FromIOpenTraceSpline(IOpenTraceSplineT _iopentracespline)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IOpenTraceSpline,
				Value = _iopentracespline
			};
		}

		// Token: 0x0602A0E7 RID: 172263 RVA: 0x005CB0AF File Offset: 0x005C92AF
		public ICloseTraceSplineT AsICloseTraceSpline()
		{
			return this.As<ICloseTraceSplineT>();
		}

		// Token: 0x0602A0E8 RID: 172264 RVA: 0x005CB0B7 File Offset: 0x005C92B7
		public static IActionParams_Union_0Union FromICloseTraceSpline(ICloseTraceSplineT _iclosetracespline)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICloseTraceSpline,
				Value = _iclosetracespline
			};
		}

		// Token: 0x0602A0E9 RID: 172265 RVA: 0x005CB0D0 File Offset: 0x005C92D0
		public ITraceSplineT AsITraceSpline()
		{
			return this.As<ITraceSplineT>();
		}

		// Token: 0x0602A0EA RID: 172266 RVA: 0x005CB0D8 File Offset: 0x005C92D8
		public static IActionParams_Union_0Union FromITraceSpline(ITraceSplineT _itracespline)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ITraceSpline,
				Value = _itracespline
			};
		}

		// Token: 0x0602A0EB RID: 172267 RVA: 0x005CB0F1 File Offset: 0x005C92F1
		public IEnableAIT AsIEnableAI()
		{
			return this.As<IEnableAIT>();
		}

		// Token: 0x0602A0EC RID: 172268 RVA: 0x005CB0F9 File Offset: 0x005C92F9
		public static IActionParams_Union_0Union FromIEnableAI(IEnableAIT _ienableai)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEnableAI,
				Value = _ienableai
			};
		}

		// Token: 0x0602A0ED RID: 172269 RVA: 0x005CB112 File Offset: 0x005C9312
		public IRunActionsT AsIRunActions()
		{
			return this.As<IRunActionsT>();
		}

		// Token: 0x0602A0EE RID: 172270 RVA: 0x005CB11A File Offset: 0x005C931A
		public static IActionParams_Union_0Union FromIRunActions(IRunActionsT _irunactions)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRunActions,
				Value = _irunactions
			};
		}

		// Token: 0x0602A0EF RID: 172271 RVA: 0x005CB133 File Offset: 0x005C9333
		public ICommonTipT AsICommonTip()
		{
			return this.As<ICommonTipT>();
		}

		// Token: 0x0602A0F0 RID: 172272 RVA: 0x005CB13B File Offset: 0x005C933B
		public static IActionParams_Union_0Union FromICommonTip(ICommonTipT _icommontip)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICommonTip,
				Value = _icommontip
			};
		}

		// Token: 0x0602A0F1 RID: 172273 RVA: 0x005CB154 File Offset: 0x005C9354
		public ICommonTip2T AsICommonTip2()
		{
			return this.As<ICommonTip2T>();
		}

		// Token: 0x0602A0F2 RID: 172274 RVA: 0x005CB15C File Offset: 0x005C935C
		public static IActionParams_Union_0Union FromICommonTip2(ICommonTip2T _icommontip2)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICommonTip2,
				Value = _icommontip2
			};
		}

		// Token: 0x0602A0F3 RID: 172275 RVA: 0x005CB175 File Offset: 0x005C9375
		public IEndCommonTipT AsIEndCommonTip()
		{
			return this.As<IEndCommonTipT>();
		}

		// Token: 0x0602A0F4 RID: 172276 RVA: 0x005CB17D File Offset: 0x005C937D
		public static IActionParams_Union_0Union FromIEndCommonTip(IEndCommonTipT _iendcommontip)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEndCommonTip,
				Value = _iendcommontip
			};
		}

		// Token: 0x0602A0F5 RID: 172277 RVA: 0x005CB196 File Offset: 0x005C9396
		public IEnableNearbyTrackingT AsIEnableNearbyTracking()
		{
			return this.As<IEnableNearbyTrackingT>();
		}

		// Token: 0x0602A0F6 RID: 172278 RVA: 0x005CB19E File Offset: 0x005C939E
		public static IActionParams_Union_0Union FromIEnableNearbyTracking(IEnableNearbyTrackingT _ienablenearbytracking)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEnableNearbyTracking,
				Value = _ienablenearbytracking
			};
		}

		// Token: 0x0602A0F7 RID: 172279 RVA: 0x005CB1B7 File Offset: 0x005C93B7
		public ISendAiEventT AsISendAiEvent()
		{
			return this.As<ISendAiEventT>();
		}

		// Token: 0x0602A0F8 RID: 172280 RVA: 0x005CB1BF File Offset: 0x005C93BF
		public static IActionParams_Union_0Union FromISendAiEvent(ISendAiEventT _isendaievent)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISendAiEvent,
				Value = _isendaievent
			};
		}

		// Token: 0x0602A0F9 RID: 172281 RVA: 0x005CB1D8 File Offset: 0x005C93D8
		public IEnableLevelPlayT AsIEnableLevelPlay()
		{
			return this.As<IEnableLevelPlayT>();
		}

		// Token: 0x0602A0FA RID: 172282 RVA: 0x005CB1E0 File Offset: 0x005C93E0
		public static IActionParams_Union_0Union FromIEnableLevelPlay(IEnableLevelPlayT _ienablelevelplay)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEnableLevelPlay,
				Value = _ienablelevelplay
			};
		}

		// Token: 0x0602A0FB RID: 172283 RVA: 0x005CB1F9 File Offset: 0x005C93F9
		public IServerForceEnableLevelPlayT AsIServerForceEnableLevelPlay()
		{
			return this.As<IServerForceEnableLevelPlayT>();
		}

		// Token: 0x0602A0FC RID: 172284 RVA: 0x005CB201 File Offset: 0x005C9401
		public static IActionParams_Union_0Union FromIServerForceEnableLevelPlay(IServerForceEnableLevelPlayT _iserverforceenablelevelplay)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IServerForceEnableLevelPlay,
				Value = _iserverforceenablelevelplay
			};
		}

		// Token: 0x0602A0FD RID: 172285 RVA: 0x005CB21A File Offset: 0x005C941A
		public ITeleportDungeonPosT AsITeleportDungeonPos()
		{
			return this.As<ITeleportDungeonPosT>();
		}

		// Token: 0x0602A0FE RID: 172286 RVA: 0x005CB222 File Offset: 0x005C9422
		public static IActionParams_Union_0Union FromITeleportDungeonPos(ITeleportDungeonPosT _iteleportdungeonpos)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ITeleportDungeonPos,
				Value = _iteleportdungeonpos
			};
		}

		// Token: 0x0602A0FF RID: 172287 RVA: 0x005CB23B File Offset: 0x005C943B
		public IFadeInScreenT AsIFadeInScreen()
		{
			return this.As<IFadeInScreenT>();
		}

		// Token: 0x0602A100 RID: 172288 RVA: 0x005CB243 File Offset: 0x005C9443
		public static IActionParams_Union_0Union FromIFadeInScreen(IFadeInScreenT _ifadeinscreen)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFadeInScreen,
				Value = _ifadeinscreen
			};
		}

		// Token: 0x0602A101 RID: 172289 RVA: 0x005CB25C File Offset: 0x005C945C
		public IFadeOutScreenT AsIFadeOutScreen()
		{
			return this.As<IFadeOutScreenT>();
		}

		// Token: 0x0602A102 RID: 172290 RVA: 0x005CB264 File Offset: 0x005C9464
		public static IActionParams_Union_0Union FromIFadeOutScreen(IFadeOutScreenT _ifadeoutscreen)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IFadeOutScreen,
				Value = _ifadeoutscreen
			};
		}

		// Token: 0x0602A103 RID: 172291 RVA: 0x005CB27D File Offset: 0x005C947D
		public IStartFlowTemplateT AsIStartFlowTemplate()
		{
			return this.As<IStartFlowTemplateT>();
		}

		// Token: 0x0602A104 RID: 172292 RVA: 0x005CB285 File Offset: 0x005C9485
		public static IActionParams_Union_0Union FromIStartFlowTemplate(IStartFlowTemplateT _istartflowtemplate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IStartFlowTemplate,
				Value = _istartflowtemplate
			};
		}

		// Token: 0x0602A105 RID: 172293 RVA: 0x005CB29E File Offset: 0x005C949E
		public IEndFlowTemplateT AsIEndFlowTemplate()
		{
			return this.As<IEndFlowTemplateT>();
		}

		// Token: 0x0602A106 RID: 172294 RVA: 0x005CB2A6 File Offset: 0x005C94A6
		public static IActionParams_Union_0Union FromIEndFlowTemplate(IEndFlowTemplateT _iendflowtemplate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEndFlowTemplate,
				Value = _iendflowtemplate
			};
		}

		// Token: 0x0602A107 RID: 172295 RVA: 0x005CB2BF File Offset: 0x005C94BF
		public ICloseFlowTemplateT AsICloseFlowTemplate()
		{
			return this.As<ICloseFlowTemplateT>();
		}

		// Token: 0x0602A108 RID: 172296 RVA: 0x005CB2C7 File Offset: 0x005C94C7
		public static IActionParams_Union_0Union FromICloseFlowTemplate(ICloseFlowTemplateT _icloseflowtemplate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICloseFlowTemplate,
				Value = _icloseflowtemplate
			};
		}

		// Token: 0x0602A109 RID: 172297 RVA: 0x005CB2E0 File Offset: 0x005C94E0
		public IChangeFlowTemplateT AsIChangeFlowTemplate()
		{
			return this.As<IChangeFlowTemplateT>();
		}

		// Token: 0x0602A10A RID: 172298 RVA: 0x005CB2E8 File Offset: 0x005C94E8
		public static IActionParams_Union_0Union FromIChangeFlowTemplate(IChangeFlowTemplateT _ichangeflowtemplate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeFlowTemplate,
				Value = _ichangeflowtemplate
			};
		}

		// Token: 0x0602A10B RID: 172299 RVA: 0x005CB301 File Offset: 0x005C9501
		public IBeginFlowTemplateT AsIBeginFlowTemplate()
		{
			return this.As<IBeginFlowTemplateT>();
		}

		// Token: 0x0602A10C RID: 172300 RVA: 0x005CB309 File Offset: 0x005C9509
		public static IActionParams_Union_0Union FromIBeginFlowTemplate(IBeginFlowTemplateT _ibeginflowtemplate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IBeginFlowTemplate,
				Value = _ibeginflowtemplate
			};
		}

		// Token: 0x0602A10D RID: 172301 RVA: 0x005CB322 File Offset: 0x005C9522
		public ISetFlowTemplateT AsISetFlowTemplate()
		{
			return this.As<ISetFlowTemplateT>();
		}

		// Token: 0x0602A10E RID: 172302 RVA: 0x005CB32A File Offset: 0x005C952A
		public static IActionParams_Union_0Union FromISetFlowTemplate(ISetFlowTemplateT _isetflowtemplate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetFlowTemplate,
				Value = _isetflowtemplate
			};
		}

		// Token: 0x0602A10F RID: 172303 RVA: 0x005CB343 File Offset: 0x005C9543
		public IHideTargetRangeT AsIHideTargetRange()
		{
			return this.As<IHideTargetRangeT>();
		}

		// Token: 0x0602A110 RID: 172304 RVA: 0x005CB34B File Offset: 0x005C954B
		public static IActionParams_Union_0Union FromIHideTargetRange(IHideTargetRangeT _ihidetargetrange)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IHideTargetRange,
				Value = _ihidetargetrange
			};
		}

		// Token: 0x0602A111 RID: 172305 RVA: 0x005CB364 File Offset: 0x005C9564
		public IShowTargetRangeT AsIShowTargetRange()
		{
			return this.As<IShowTargetRangeT>();
		}

		// Token: 0x0602A112 RID: 172306 RVA: 0x005CB36C File Offset: 0x005C956C
		public static IActionParams_Union_0Union FromIShowTargetRange(IShowTargetRangeT _ishowtargetrange)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IShowTargetRange,
				Value = _ishowtargetrange
			};
		}

		// Token: 0x0602A113 RID: 172307 RVA: 0x005CB385 File Offset: 0x005C9585
		public IHideSpecificEntitiesT AsIHideSpecificEntities()
		{
			return this.As<IHideSpecificEntitiesT>();
		}

		// Token: 0x0602A114 RID: 172308 RVA: 0x005CB38D File Offset: 0x005C958D
		public static IActionParams_Union_0Union FromIHideSpecificEntities(IHideSpecificEntitiesT _ihidespecificentities)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IHideSpecificEntities,
				Value = _ihidespecificentities
			};
		}

		// Token: 0x0602A115 RID: 172309 RVA: 0x005CB3A6 File Offset: 0x005C95A6
		public IShowSpecificEntitiesT AsIShowSpecificEntities()
		{
			return this.As<IShowSpecificEntitiesT>();
		}

		// Token: 0x0602A116 RID: 172310 RVA: 0x005CB3AE File Offset: 0x005C95AE
		public static IActionParams_Union_0Union FromIShowSpecificEntities(IShowSpecificEntitiesT _ishowspecificentities)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IShowSpecificEntities,
				Value = _ishowspecificentities
			};
		}

		// Token: 0x0602A117 RID: 172311 RVA: 0x005CB3C7 File Offset: 0x005C95C7
		public IHideGroupT AsIHideGroup()
		{
			return this.As<IHideGroupT>();
		}

		// Token: 0x0602A118 RID: 172312 RVA: 0x005CB3CF File Offset: 0x005C95CF
		public static IActionParams_Union_0Union FromIHideGroup(IHideGroupT _ihidegroup)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IHideGroup,
				Value = _ihidegroup
			};
		}

		// Token: 0x0602A119 RID: 172313 RVA: 0x005CB3E8 File Offset: 0x005C95E8
		public IShowHidedGroupT AsIShowHidedGroup()
		{
			return this.As<IShowHidedGroupT>();
		}

		// Token: 0x0602A11A RID: 172314 RVA: 0x005CB3F0 File Offset: 0x005C95F0
		public static IActionParams_Union_0Union FromIShowHidedGroup(IShowHidedGroupT _ishowhidedgroup)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IShowHidedGroup,
				Value = _ishowhidedgroup
			};
		}

		// Token: 0x0602A11B RID: 172315 RVA: 0x005CB409 File Offset: 0x005C9609
		public ISetSubScreenModeT AsISetSubScreenMode()
		{
			return this.As<ISetSubScreenModeT>();
		}

		// Token: 0x0602A11C RID: 172316 RVA: 0x005CB411 File Offset: 0x005C9611
		public static IActionParams_Union_0Union FromISetSubScreenMode(ISetSubScreenModeT _isetsubscreenmode)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetSubScreenMode,
				Value = _isetsubscreenmode
			};
		}

		// Token: 0x0602A11D RID: 172317 RVA: 0x005CB42A File Offset: 0x005C962A
		public IToggleDragActorPlayT AsIToggleDragActorPlay()
		{
			return this.As<IToggleDragActorPlayT>();
		}

		// Token: 0x0602A11E RID: 172318 RVA: 0x005CB432 File Offset: 0x005C9632
		public static IActionParams_Union_0Union FromIToggleDragActorPlay(IToggleDragActorPlayT _itoggledragactorplay)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IToggleDragActorPlay,
				Value = _itoggledragactorplay
			};
		}

		// Token: 0x0602A11F RID: 172319 RVA: 0x005CB44B File Offset: 0x005C964B
		public IManualOccupationsT AsIManualOccupations()
		{
			return this.As<IManualOccupationsT>();
		}

		// Token: 0x0602A120 RID: 172320 RVA: 0x005CB453 File Offset: 0x005C9653
		public static IActionParams_Union_0Union FromIManualOccupations(IManualOccupationsT _imanualoccupations)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IManualOccupations,
				Value = _imanualoccupations
			};
		}

		// Token: 0x0602A121 RID: 172321 RVA: 0x005CB46C File Offset: 0x005C966C
		public IForceOccupationsT AsIForceOccupations()
		{
			return this.As<IForceOccupationsT>();
		}

		// Token: 0x0602A122 RID: 172322 RVA: 0x005CB474 File Offset: 0x005C9674
		public static IActionParams_Union_0Union FromIForceOccupations(IForceOccupationsT _iforceoccupations)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IForceOccupations,
				Value = _iforceoccupations
			};
		}

		// Token: 0x0602A123 RID: 172323 RVA: 0x005CB48D File Offset: 0x005C968D
		public IChangeFightTeamT AsIChangeFightTeam()
		{
			return this.As<IChangeFightTeamT>();
		}

		// Token: 0x0602A124 RID: 172324 RVA: 0x005CB495 File Offset: 0x005C9695
		public static IActionParams_Union_0Union FromIChangeFightTeam(IChangeFightTeamT _ichangefightteam)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeFightTeam,
				Value = _ichangefightteam
			};
		}

		// Token: 0x0602A125 RID: 172325 RVA: 0x005CB4AE File Offset: 0x005C96AE
		public IActiveRangeT AsIActiveRange()
		{
			return this.As<IActiveRangeT>();
		}

		// Token: 0x0602A126 RID: 172326 RVA: 0x005CB4B6 File Offset: 0x005C96B6
		public static IActionParams_Union_0Union FromIActiveRange(IActiveRangeT _iactiverange)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IActiveRange,
				Value = _iactiverange
			};
		}

		// Token: 0x0602A127 RID: 172327 RVA: 0x005CB4CF File Offset: 0x005C96CF
		public IAddTrialCharacterT AsIAddTrialCharacter()
		{
			return this.As<IAddTrialCharacterT>();
		}

		// Token: 0x0602A128 RID: 172328 RVA: 0x005CB4D7 File Offset: 0x005C96D7
		public static IActionParams_Union_0Union FromIAddTrialCharacter(IAddTrialCharacterT _iaddtrialcharacter)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAddTrialCharacter,
				Value = _iaddtrialcharacter
			};
		}

		// Token: 0x0602A129 RID: 172329 RVA: 0x005CB4F0 File Offset: 0x005C96F0
		public IUpdateTrialCharacterT AsIUpdateTrialCharacter()
		{
			return this.As<IUpdateTrialCharacterT>();
		}

		// Token: 0x0602A12A RID: 172330 RVA: 0x005CB4F8 File Offset: 0x005C96F8
		public static IActionParams_Union_0Union FromIUpdateTrialCharacter(IUpdateTrialCharacterT _iupdatetrialcharacter)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IUpdateTrialCharacter,
				Value = _iupdatetrialcharacter
			};
		}

		// Token: 0x0602A12B RID: 172331 RVA: 0x005CB511 File Offset: 0x005C9711
		public IRestoreTrialCharacterT AsIRestoreTrialCharacter()
		{
			return this.As<IRestoreTrialCharacterT>();
		}

		// Token: 0x0602A12C RID: 172332 RVA: 0x005CB519 File Offset: 0x005C9719
		public static IActionParams_Union_0Union FromIRestoreTrialCharacter(IRestoreTrialCharacterT _irestoretrialcharacter)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRestoreTrialCharacter,
				Value = _irestoretrialcharacter
			};
		}

		// Token: 0x0602A12D RID: 172333 RVA: 0x005CB532 File Offset: 0x005C9732
		public IRemoveTrialCharacterT AsIRemoveTrialCharacter()
		{
			return this.As<IRemoveTrialCharacterT>();
		}

		// Token: 0x0602A12E RID: 172334 RVA: 0x005CB53A File Offset: 0x005C973A
		public static IActionParams_Union_0Union FromIRemoveTrialCharacter(IRemoveTrialCharacterT _iremovetrialcharacter)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRemoveTrialCharacter,
				Value = _iremovetrialcharacter
			};
		}

		// Token: 0x0602A12F RID: 172335 RVA: 0x005CB553 File Offset: 0x005C9753
		public IAddGuestCharacterT AsIAddGuestCharacter()
		{
			return this.As<IAddGuestCharacterT>();
		}

		// Token: 0x0602A130 RID: 172336 RVA: 0x005CB55B File Offset: 0x005C975B
		public static IActionParams_Union_0Union FromIAddGuestCharacter(IAddGuestCharacterT _iaddguestcharacter)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAddGuestCharacter,
				Value = _iaddguestcharacter
			};
		}

		// Token: 0x0602A131 RID: 172337 RVA: 0x005CB574 File Offset: 0x005C9774
		public IRemoveGuestCharacterT AsIRemoveGuestCharacter()
		{
			return this.As<IRemoveGuestCharacterT>();
		}

		// Token: 0x0602A132 RID: 172338 RVA: 0x005CB57C File Offset: 0x005C977C
		public static IActionParams_Union_0Union FromIRemoveGuestCharacter(IRemoveGuestCharacterT _iremoveguestcharacter)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRemoveGuestCharacter,
				Value = _iremoveguestcharacter
			};
		}

		// Token: 0x0602A133 RID: 172339 RVA: 0x005CB595 File Offset: 0x005C9795
		public IDestroyQuestT AsIDestroyQuest()
		{
			return this.As<IDestroyQuestT>();
		}

		// Token: 0x0602A134 RID: 172340 RVA: 0x005CB59D File Offset: 0x005C979D
		public static IActionParams_Union_0Union FromIDestroyQuest(IDestroyQuestT _idestroyquest)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IDestroyQuest,
				Value = _idestroyquest
			};
		}

		// Token: 0x0602A135 RID: 172341 RVA: 0x005CB5B6 File Offset: 0x005C97B6
		public ISetCameraAnimT AsISetCameraAnim()
		{
			return this.As<ISetCameraAnimT>();
		}

		// Token: 0x0602A136 RID: 172342 RVA: 0x005CB5BE File Offset: 0x005C97BE
		public static IActionParams_Union_0Union FromISetCameraAnim(ISetCameraAnimT _isetcameraanim)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetCameraAnim,
				Value = _isetcameraanim
			};
		}

		// Token: 0x0602A137 RID: 172343 RVA: 0x005CB5D7 File Offset: 0x005C97D7
		public IChangeTimerT AsIChangeTimer()
		{
			return this.As<IChangeTimerT>();
		}

		// Token: 0x0602A138 RID: 172344 RVA: 0x005CB5DF File Offset: 0x005C97DF
		public static IActionParams_Union_0Union FromIChangeTimer(IChangeTimerT _ichangetimer)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeTimer,
				Value = _ichangetimer
			};
		}

		// Token: 0x0602A139 RID: 172345 RVA: 0x005CB5F8 File Offset: 0x005C97F8
		public IToggleTimerPauseStateT AsIToggleTimerPauseState()
		{
			return this.As<IToggleTimerPauseStateT>();
		}

		// Token: 0x0602A13A RID: 172346 RVA: 0x005CB600 File Offset: 0x005C9800
		public static IActionParams_Union_0Union FromIToggleTimerPauseState(IToggleTimerPauseStateT _itoggletimerpausestate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IToggleTimerPauseState,
				Value = _itoggletimerpausestate
			};
		}

		// Token: 0x0602A13B RID: 172347 RVA: 0x005CB619 File Offset: 0x005C9819
		public IRotatorEntityT AsIRotatorEntity()
		{
			return this.As<IRotatorEntityT>();
		}

		// Token: 0x0602A13C RID: 172348 RVA: 0x005CB621 File Offset: 0x005C9821
		public static IActionParams_Union_0Union FromIRotatorEntity(IRotatorEntityT _irotatorentity)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRotatorEntity,
				Value = _irotatorentity
			};
		}

		// Token: 0x0602A13D RID: 172349 RVA: 0x005CB63A File Offset: 0x005C983A
		public IUnLimitPlayerOperationT AsIUnLimitPlayerOperation()
		{
			return this.As<IUnLimitPlayerOperationT>();
		}

		// Token: 0x0602A13E RID: 172350 RVA: 0x005CB642 File Offset: 0x005C9842
		public static IActionParams_Union_0Union FromIUnLimitPlayerOperation(IUnLimitPlayerOperationT _iunlimitplayeroperation)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IUnLimitPlayerOperation,
				Value = _iunlimitplayeroperation
			};
		}

		// Token: 0x0602A13F RID: 172351 RVA: 0x005CB65B File Offset: 0x005C985B
		public ILimitPlayerOperationT AsILimitPlayerOperation()
		{
			return this.As<ILimitPlayerOperationT>();
		}

		// Token: 0x0602A140 RID: 172352 RVA: 0x005CB663 File Offset: 0x005C9863
		public static IActionParams_Union_0Union FromILimitPlayerOperation(ILimitPlayerOperationT _ilimitplayeroperation)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ILimitPlayerOperation,
				Value = _ilimitplayeroperation
			};
		}

		// Token: 0x0602A141 RID: 172353 RVA: 0x005CB67C File Offset: 0x005C987C
		public IEnableSystemT AsIEnableSystem()
		{
			return this.As<IEnableSystemT>();
		}

		// Token: 0x0602A142 RID: 172354 RVA: 0x005CB684 File Offset: 0x005C9884
		public static IActionParams_Union_0Union FromIEnableSystem(IEnableSystemT _ienablesystem)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEnableSystem,
				Value = _ienablesystem
			};
		}

		// Token: 0x0602A143 RID: 172355 RVA: 0x005CB69D File Offset: 0x005C989D
		public ILeisureInteractT AsILeisureInteract()
		{
			return this.As<ILeisureInteractT>();
		}

		// Token: 0x0602A144 RID: 172356 RVA: 0x005CB6A5 File Offset: 0x005C98A5
		public static IActionParams_Union_0Union FromILeisureInteract(ILeisureInteractT _ileisureinteract)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ILeisureInteract,
				Value = _ileisureinteract
			};
		}

		// Token: 0x0602A145 RID: 172357 RVA: 0x005CB6BE File Offset: 0x005C98BE
		public INpcLeisureInteractT AsINpcLeisureInteract()
		{
			return this.As<INpcLeisureInteractT>();
		}

		// Token: 0x0602A146 RID: 172358 RVA: 0x005CB6C6 File Offset: 0x005C98C6
		public static IActionParams_Union_0Union FromINpcLeisureInteract(INpcLeisureInteractT _inpcleisureinteract)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.INpcLeisureInteract,
				Value = _inpcleisureinteract
			};
		}

		// Token: 0x0602A147 RID: 172359 RVA: 0x005CB6DF File Offset: 0x005C98DF
		public IPostAkEventT AsIPostAkEvent()
		{
			return this.As<IPostAkEventT>();
		}

		// Token: 0x0602A148 RID: 172360 RVA: 0x005CB6E7 File Offset: 0x005C98E7
		public static IActionParams_Union_0Union FromIPostAkEvent(IPostAkEventT _ipostakevent)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPostAkEvent,
				Value = _ipostakevent
			};
		}

		// Token: 0x0602A149 RID: 172361 RVA: 0x005CB700 File Offset: 0x005C9900
		public IMoveSceneItemT AsIMoveSceneItem()
		{
			return this.As<IMoveSceneItemT>();
		}

		// Token: 0x0602A14A RID: 172362 RVA: 0x005CB708 File Offset: 0x005C9908
		public static IActionParams_Union_0Union FromIMoveSceneItem(IMoveSceneItemT _imovesceneitem)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IMoveSceneItem,
				Value = _imovesceneitem
			};
		}

		// Token: 0x0602A14B RID: 172363 RVA: 0x005CB721 File Offset: 0x005C9921
		public IStopSceneItemMoveT AsIStopSceneItemMove()
		{
			return this.As<IStopSceneItemMoveT>();
		}

		// Token: 0x0602A14C RID: 172364 RVA: 0x005CB729 File Offset: 0x005C9929
		public static IActionParams_Union_0Union FromIStopSceneItemMove(IStopSceneItemMoveT _istopsceneitemmove)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IStopSceneItemMove,
				Value = _istopsceneitemmove
			};
		}

		// Token: 0x0602A14D RID: 172365 RVA: 0x005CB742 File Offset: 0x005C9942
		public IChangeLiftTargetT AsIChangeLiftTarget()
		{
			return this.As<IChangeLiftTargetT>();
		}

		// Token: 0x0602A14E RID: 172366 RVA: 0x005CB74A File Offset: 0x005C994A
		public static IActionParams_Union_0Union FromIChangeLiftTarget(IChangeLiftTargetT _ichangelifttarget)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeLiftTarget,
				Value = _ichangelifttarget
			};
		}

		// Token: 0x0602A14F RID: 172367 RVA: 0x005CB763 File Offset: 0x005C9963
		public IHideByRangeInFlowT AsIHideByRangeInFlow()
		{
			return this.As<IHideByRangeInFlowT>();
		}

		// Token: 0x0602A150 RID: 172368 RVA: 0x005CB76B File Offset: 0x005C996B
		public static IActionParams_Union_0Union FromIHideByRangeInFlow(IHideByRangeInFlowT _ihidebyrangeinflow)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IHideByRangeInFlow,
				Value = _ihidebyrangeinflow
			};
		}

		// Token: 0x0602A151 RID: 172369 RVA: 0x005CB784 File Offset: 0x005C9984
		public IShowAllHidedGroupInFlowT AsIShowAllHidedGroupInFlow()
		{
			return this.As<IShowAllHidedGroupInFlowT>();
		}

		// Token: 0x0602A152 RID: 172370 RVA: 0x005CB78C File Offset: 0x005C998C
		public static IActionParams_Union_0Union FromIShowAllHidedGroupInFlow(IShowAllHidedGroupInFlowT _ishowallhidedgroupinflow)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IShowAllHidedGroupInFlow,
				Value = _ishowallhidedgroupinflow
			};
		}

		// Token: 0x0602A153 RID: 172371 RVA: 0x005CB7A5 File Offset: 0x005C99A5
		public IOpenSimpleGameplayT AsIOpenSimpleGameplay()
		{
			return this.As<IOpenSimpleGameplayT>();
		}

		// Token: 0x0602A154 RID: 172372 RVA: 0x005CB7AD File Offset: 0x005C99AD
		public static IActionParams_Union_0Union FromIOpenSimpleGameplay(IOpenSimpleGameplayT _iopensimplegameplay)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IOpenSimpleGameplay,
				Value = _iopensimplegameplay
			};
		}

		// Token: 0x0602A155 RID: 172373 RVA: 0x005CB7C6 File Offset: 0x005C99C6
		public ICloseSimpleGameplayT AsICloseSimpleGameplay()
		{
			return this.As<ICloseSimpleGameplayT>();
		}

		// Token: 0x0602A156 RID: 172374 RVA: 0x005CB7CE File Offset: 0x005C99CE
		public static IActionParams_Union_0Union FromICloseSimpleGameplay(ICloseSimpleGameplayT _iclosesimplegameplay)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ICloseSimpleGameplay,
				Value = _iclosesimplegameplay
			};
		}

		// Token: 0x0602A157 RID: 172375 RVA: 0x005CB7E7 File Offset: 0x005C99E7
		public IChangePhantomT AsIChangePhantom()
		{
			return this.As<IChangePhantomT>();
		}

		// Token: 0x0602A158 RID: 172376 RVA: 0x005CB7EF File Offset: 0x005C99EF
		public static IActionParams_Union_0Union FromIChangePhantom(IChangePhantomT _ichangephantom)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangePhantom,
				Value = _ichangephantom
			};
		}

		// Token: 0x0602A159 RID: 172377 RVA: 0x005CB808 File Offset: 0x005C9A08
		public IRestorePhantomT AsIRestorePhantom()
		{
			return this.As<IRestorePhantomT>();
		}

		// Token: 0x0602A15A RID: 172378 RVA: 0x005CB810 File Offset: 0x005C9A10
		public static IActionParams_Union_0Union FromIRestorePhantom(IRestorePhantomT _irestorephantom)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRestorePhantom,
				Value = _irestorephantom
			};
		}

		// Token: 0x0602A15B RID: 172379 RVA: 0x005CB829 File Offset: 0x005C9A29
		public ITakePlotPhotoT AsITakePlotPhoto()
		{
			return this.As<ITakePlotPhotoT>();
		}

		// Token: 0x0602A15C RID: 172380 RVA: 0x005CB831 File Offset: 0x005C9A31
		public static IActionParams_Union_0Union FromITakePlotPhoto(ITakePlotPhotoT _itakeplotphoto)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ITakePlotPhoto,
				Value = _itakeplotphoto
			};
		}

		// Token: 0x0602A15D RID: 172381 RVA: 0x005CB84A File Offset: 0x005C9A4A
		public IChangeActorTalkerT AsIChangeActorTalker()
		{
			return this.As<IChangeActorTalkerT>();
		}

		// Token: 0x0602A15E RID: 172382 RVA: 0x005CB852 File Offset: 0x005C9A52
		public static IActionParams_Union_0Union FromIChangeActorTalker(IChangeActorTalkerT _ichangeactortalker)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangeActorTalker,
				Value = _ichangeactortalker
			};
		}

		// Token: 0x0602A15F RID: 172383 RVA: 0x005CB86B File Offset: 0x005C9A6B
		public ISwitchSubLevelsT AsISwitchSubLevels()
		{
			return this.As<ISwitchSubLevelsT>();
		}

		// Token: 0x0602A160 RID: 172384 RVA: 0x005CB873 File Offset: 0x005C9A73
		public static IActionParams_Union_0Union FromISwitchSubLevels(ISwitchSubLevelsT _iswitchsublevels)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISwitchSubLevels,
				Value = _iswitchsublevels
			};
		}

		// Token: 0x0602A161 RID: 172385 RVA: 0x005CB88C File Offset: 0x005C9A8C
		public ISwitchSubLevelsDirectlyT AsISwitchSubLevelsDirectly()
		{
			return this.As<ISwitchSubLevelsDirectlyT>();
		}

		// Token: 0x0602A162 RID: 172386 RVA: 0x005CB894 File Offset: 0x005C9A94
		public static IActionParams_Union_0Union FromISwitchSubLevelsDirectly(ISwitchSubLevelsDirectlyT _iswitchsublevelsdirectly)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISwitchSubLevelsDirectly,
				Value = _iswitchsublevelsdirectly
			};
		}

		// Token: 0x0602A163 RID: 172387 RVA: 0x005CB8AD File Offset: 0x005C9AAD
		public IPreloadSubLevelsT AsIPreloadSubLevels()
		{
			return this.As<IPreloadSubLevelsT>();
		}

		// Token: 0x0602A164 RID: 172388 RVA: 0x005CB8B5 File Offset: 0x005C9AB5
		public static IActionParams_Union_0Union FromIPreloadSubLevels(IPreloadSubLevelsT _ipreloadsublevels)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IPreloadSubLevels,
				Value = _ipreloadsublevels
			};
		}

		// Token: 0x0602A165 RID: 172389 RVA: 0x005CB8CE File Offset: 0x005C9ACE
		public ISwitchPermissionT AsISwitchPermission()
		{
			return this.As<ISwitchPermissionT>();
		}

		// Token: 0x0602A166 RID: 172390 RVA: 0x005CB8D6 File Offset: 0x005C9AD6
		public static IActionParams_Union_0Union FromISwitchPermission(ISwitchPermissionT _iswitchpermission)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISwitchPermission,
				Value = _iswitchpermission
			};
		}

		// Token: 0x0602A167 RID: 172391 RVA: 0x005CB8EF File Offset: 0x005C9AEF
		public ISwitchDataLayersT AsISwitchDataLayers()
		{
			return this.As<ISwitchDataLayersT>();
		}

		// Token: 0x0602A168 RID: 172392 RVA: 0x005CB8F7 File Offset: 0x005C9AF7
		public static IActionParams_Union_0Union FromISwitchDataLayers(ISwitchDataLayersT _iswitchdatalayers)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISwitchDataLayers,
				Value = _iswitchdatalayers
			};
		}

		// Token: 0x0602A169 RID: 172393 RVA: 0x005CB910 File Offset: 0x005C9B10
		public IActivateResetPointT AsIActivateResetPoint()
		{
			return this.As<IActivateResetPointT>();
		}

		// Token: 0x0602A16A RID: 172394 RVA: 0x005CB918 File Offset: 0x005C9B18
		public static IActionParams_Union_0Union FromIActivateResetPoint(IActivateResetPointT _iactivateresetpoint)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IActivateResetPoint,
				Value = _iactivateresetpoint
			};
		}

		// Token: 0x0602A16B RID: 172395 RVA: 0x005CB931 File Offset: 0x005C9B31
		public ITeleportToLatestResetPointT AsITeleportToLatestResetPoint()
		{
			return this.As<ITeleportToLatestResetPointT>();
		}

		// Token: 0x0602A16C RID: 172396 RVA: 0x005CB939 File Offset: 0x005C9B39
		public static IActionParams_Union_0Union FromITeleportToLatestResetPoint(ITeleportToLatestResetPointT _iteleporttolatestresetpoint)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ITeleportToLatestResetPoint,
				Value = _iteleporttolatestresetpoint
			};
		}

		// Token: 0x0602A16D RID: 172397 RVA: 0x005CB952 File Offset: 0x005C9B52
		public ISetWeatherT AsISetWeather()
		{
			return this.As<ISetWeatherT>();
		}

		// Token: 0x0602A16E RID: 172398 RVA: 0x005CB95A File Offset: 0x005C9B5A
		public static IActionParams_Union_0Union FromISetWeather(ISetWeatherT _isetweather)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetWeather,
				Value = _isetweather
			};
		}

		// Token: 0x0602A16F RID: 172399 RVA: 0x005CB973 File Offset: 0x005C9B73
		public ISetTimeLockStateT AsISetTimeLockState()
		{
			return this.As<ISetTimeLockStateT>();
		}

		// Token: 0x0602A170 RID: 172400 RVA: 0x005CB97B File Offset: 0x005C9B7B
		public static IActionParams_Union_0Union FromISetTimeLockState(ISetTimeLockStateT _isettimelockstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetTimeLockState,
				Value = _isettimelockstate
			};
		}

		// Token: 0x0602A171 RID: 172401 RVA: 0x005CB994 File Offset: 0x005C9B94
		public ISetWeatherLockStateT AsISetWeatherLockState()
		{
			return this.As<ISetWeatherLockStateT>();
		}

		// Token: 0x0602A172 RID: 172402 RVA: 0x005CB99C File Offset: 0x005C9B9C
		public static IActionParams_Union_0Union FromISetWeatherLockState(ISetWeatherLockStateT _isetweatherlockstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.ISetWeatherLockState,
				Value = _isetweatherlockstate
			};
		}

		// Token: 0x0602A173 RID: 172403 RVA: 0x005CB9B5 File Offset: 0x005C9BB5
		public IClientSetSeasonStateT AsIClientSetSeasonState()
		{
			return this.As<IClientSetSeasonStateT>();
		}

		// Token: 0x0602A174 RID: 172404 RVA: 0x005CB9BD File Offset: 0x005C9BBD
		public static IActionParams_Union_0Union FromIClientSetSeasonState(IClientSetSeasonStateT _iclientsetseasonstate)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IClientSetSeasonState,
				Value = _iclientsetseasonstate
			};
		}

		// Token: 0x0602A175 RID: 172405 RVA: 0x005CB9D6 File Offset: 0x005C9BD6
		public IAxisLockScreenConfigT AsIAxisLockScreenConfig()
		{
			return this.As<IAxisLockScreenConfigT>();
		}

		// Token: 0x0602A176 RID: 172406 RVA: 0x005CB9DE File Offset: 0x005C9BDE
		public static IActionParams_Union_0Union FromIAxisLockScreenConfig(IAxisLockScreenConfigT _iaxislockscreenconfig)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAxisLockScreenConfig,
				Value = _iaxislockscreenconfig
			};
		}

		// Token: 0x0602A177 RID: 172407 RVA: 0x005CB9F7 File Offset: 0x005C9BF7
		public IAdjustPlayerCameraT AsIAdjustPlayerCamera()
		{
			return this.As<IAdjustPlayerCameraT>();
		}

		// Token: 0x0602A178 RID: 172408 RVA: 0x005CB9FF File Offset: 0x005C9BFF
		public static IActionParams_Union_0Union FromIAdjustPlayerCamera(IAdjustPlayerCameraT _iadjustplayercamera)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAdjustPlayerCamera,
				Value = _iadjustplayercamera
			};
		}

		// Token: 0x0602A179 RID: 172409 RVA: 0x005CBA18 File Offset: 0x005C9C18
		public IRestorePlayerCameraAdjustmentT AsIRestorePlayerCameraAdjustment()
		{
			return this.As<IRestorePlayerCameraAdjustmentT>();
		}

		// Token: 0x0602A17A RID: 172410 RVA: 0x005CBA20 File Offset: 0x005C9C20
		public static IActionParams_Union_0Union FromIRestorePlayerCameraAdjustment(IRestorePlayerCameraAdjustmentT _irestoreplayercameraadjustment)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRestorePlayerCameraAdjustment,
				Value = _irestoreplayercameraadjustment
			};
		}

		// Token: 0x0602A17B RID: 172411 RVA: 0x005CBA39 File Offset: 0x005C9C39
		public IAdjustPlayerCameraGravityT AsIAdjustPlayerCameraGravity()
		{
			return this.As<IAdjustPlayerCameraGravityT>();
		}

		// Token: 0x0602A17C RID: 172412 RVA: 0x005CBA41 File Offset: 0x005C9C41
		public static IActionParams_Union_0Union FromIAdjustPlayerCameraGravity(IAdjustPlayerCameraGravityT _iadjustplayercameragravity)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IAdjustPlayerCameraGravity,
				Value = _iadjustplayercameragravity
			};
		}

		// Token: 0x0602A17D RID: 172413 RVA: 0x005CBA5A File Offset: 0x005C9C5A
		public IEnterMovieCameraT AsIEnterMovieCamera()
		{
			return this.As<IEnterMovieCameraT>();
		}

		// Token: 0x0602A17E RID: 172414 RVA: 0x005CBA62 File Offset: 0x005C9C62
		public static IActionParams_Union_0Union FromIEnterMovieCamera(IEnterMovieCameraT _ientermoviecamera)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEnterMovieCamera,
				Value = _ientermoviecamera
			};
		}

		// Token: 0x0602A17F RID: 172415 RVA: 0x005CBA7B File Offset: 0x005C9C7B
		public IExitMovieCameraT AsIExitMovieCamera()
		{
			return this.As<IExitMovieCameraT>();
		}

		// Token: 0x0602A180 RID: 172416 RVA: 0x005CBA83 File Offset: 0x005C9C83
		public static IActionParams_Union_0Union FromIExitMovieCamera(IExitMovieCameraT _iexitmoviecamera)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IExitMovieCamera,
				Value = _iexitmoviecamera
			};
		}

		// Token: 0x0602A181 RID: 172417 RVA: 0x005CBA9C File Offset: 0x005C9C9C
		public IResetPlayerCameraFocusT AsIResetPlayerCameraFocus()
		{
			return this.As<IResetPlayerCameraFocusT>();
		}

		// Token: 0x0602A182 RID: 172418 RVA: 0x005CBAA4 File Offset: 0x005C9CA4
		public static IActionParams_Union_0Union FromIResetPlayerCameraFocus(IResetPlayerCameraFocusT _iresetplayercamerafocus)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IResetPlayerCameraFocus,
				Value = _iresetplayercamerafocus
			};
		}

		// Token: 0x0602A183 RID: 172419 RVA: 0x005CBABD File Offset: 0x005C9CBD
		public IUsePhantomSkillT AsIUsePhantomSkill()
		{
			return this.As<IUsePhantomSkillT>();
		}

		// Token: 0x0602A184 RID: 172420 RVA: 0x005CBAC5 File Offset: 0x005C9CC5
		public static IActionParams_Union_0Union FromIUsePhantomSkill(IUsePhantomSkillT _iusephantomskill)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IUsePhantomSkill,
				Value = _iusephantomskill
			};
		}

		// Token: 0x0602A185 RID: 172421 RVA: 0x005CBADE File Offset: 0x005C9CDE
		public IChangePhantomFormationT AsIChangePhantomFormation()
		{
			return this.As<IChangePhantomFormationT>();
		}

		// Token: 0x0602A186 RID: 172422 RVA: 0x005CBAE6 File Offset: 0x005C9CE6
		public static IActionParams_Union_0Union FromIChangePhantomFormation(IChangePhantomFormationT _ichangephantomformation)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IChangePhantomFormation,
				Value = _ichangephantomformation
			};
		}

		// Token: 0x0602A187 RID: 172423 RVA: 0x005CBAFF File Offset: 0x005C9CFF
		public IRestorePhantomFormationT AsIRestorePhantomFormation()
		{
			return this.As<IRestorePhantomFormationT>();
		}

		// Token: 0x0602A188 RID: 172424 RVA: 0x005CBB07 File Offset: 0x005C9D07
		public static IActionParams_Union_0Union FromIRestorePhantomFormation(IRestorePhantomFormationT _irestorephantomformation)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IRestorePhantomFormation,
				Value = _irestorephantomformation
			};
		}

		// Token: 0x0602A189 RID: 172425 RVA: 0x005CBB20 File Offset: 0x005C9D20
		public IEnterOrbitalCameraT AsIEnterOrbitalCamera()
		{
			return this.As<IEnterOrbitalCameraT>();
		}

		// Token: 0x0602A18A RID: 172426 RVA: 0x005CBB28 File Offset: 0x005C9D28
		public static IActionParams_Union_0Union FromIEnterOrbitalCamera(IEnterOrbitalCameraT _ienterorbitalcamera)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEnterOrbitalCamera,
				Value = _ienterorbitalcamera
			};
		}

		// Token: 0x0602A18B RID: 172427 RVA: 0x005CBB41 File Offset: 0x005C9D41
		public IExitOrbitalCameraT AsIExitOrbitalCamera()
		{
			return this.As<IExitOrbitalCameraT>();
		}

		// Token: 0x0602A18C RID: 172428 RVA: 0x005CBB49 File Offset: 0x005C9D49
		public static IActionParams_Union_0Union FromIExitOrbitalCamera(IExitOrbitalCameraT _iexitorbitalcamera)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IExitOrbitalCamera,
				Value = _iexitorbitalcamera
			};
		}

		// Token: 0x0602A18D RID: 172429 RVA: 0x005CBB62 File Offset: 0x005C9D62
		public IEnableSplineMoveModelT AsIEnableSplineMoveModel()
		{
			return this.As<IEnableSplineMoveModelT>();
		}

		// Token: 0x0602A18E RID: 172430 RVA: 0x005CBB6A File Offset: 0x005C9D6A
		public static IActionParams_Union_0Union FromIEnableSplineMoveModel(IEnableSplineMoveModelT _ienablesplinemovemodel)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEnableSplineMoveModel,
				Value = _ienablesplinemovemodel
			};
		}

		// Token: 0x0602A18F RID: 172431 RVA: 0x005CBB83 File Offset: 0x005C9D83
		public IEnableActorT AsIEnableActor()
		{
			return this.As<IEnableActorT>();
		}

		// Token: 0x0602A190 RID: 172432 RVA: 0x005CBB8B File Offset: 0x005C9D8B
		public static IActionParams_Union_0Union FromIEnableActor(IEnableActorT _ienableactor)
		{
			return new IActionParams_Union_0Union
			{
				Type = IActionParams_Union_0.IEnableActor,
				Value = _ienableactor
			};
		}

		// Token: 0x0602A191 RID: 172433 RVA: 0x005CBBA4 File Offset: 0x005C9DA4
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
			case IActionParams_Union_0.ICloseSimpleGameplay:
				return ICloseSimpleGameplay.Pack(builder, _o.AsICloseSimpleGameplay()).Value;
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
			case IActionParams_Union_0.IEnterOrbitalCamera:
				return IEnterOrbitalCamera.Pack(builder, _o.AsIEnterOrbitalCamera()).Value;
			case IActionParams_Union_0.IExitOrbitalCamera:
				return IExitOrbitalCamera.Pack(builder, _o.AsIExitOrbitalCamera()).Value;
			case IActionParams_Union_0.IEnableSplineMoveModel:
				return IEnableSplineMoveModel.Pack(builder, _o.AsIEnableSplineMoveModel()).Value;
			case IActionParams_Union_0.IEnableActor:
				return IEnableActor.Pack(builder, _o.AsIEnableActor()).Value;
			default:
				return 0;
			}
		}
	}
}

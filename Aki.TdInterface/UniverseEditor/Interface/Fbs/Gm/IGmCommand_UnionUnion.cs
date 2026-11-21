using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AC6 RID: 19142
	public class IGmCommand_UnionUnion
	{
		// Token: 0x17008616 RID: 34326
		// (get) Token: 0x0601CC96 RID: 117910 RVA: 0x0040E1D9 File Offset: 0x0040C3D9
		// (set) Token: 0x0601CC97 RID: 117911 RVA: 0x0040E1E1 File Offset: 0x0040C3E1
		public IGmCommand_Union Type { get; set; }

		// Token: 0x17008617 RID: 34327
		// (get) Token: 0x0601CC98 RID: 117912 RVA: 0x0040E1EA File Offset: 0x0040C3EA
		// (set) Token: 0x0601CC99 RID: 117913 RVA: 0x0040E1F2 File Offset: 0x0040C3F2
		public object Value { get; set; }

		// Token: 0x0601CC9A RID: 117914 RVA: 0x0040E1FB File Offset: 0x0040C3FB
		public IGmCommand_UnionUnion()
		{
			this.Type = IGmCommand_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601CC9B RID: 117915 RVA: 0x0040E211 File Offset: 0x0040C411
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601CC9C RID: 117916 RVA: 0x0040E223 File Offset: 0x0040C423
		public IGmCommandT AsIGmCommand()
		{
			return this.As<IGmCommandT>();
		}

		// Token: 0x0601CC9D RID: 117917 RVA: 0x0040E22B File Offset: 0x0040C42B
		public static IGmCommand_UnionUnion FromIGmCommand(IGmCommandT _igmcommand)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IGmCommand,
				Value = _igmcommand
			};
		}

		// Token: 0x0601CC9E RID: 117918 RVA: 0x0040E240 File Offset: 0x0040C440
		public ISkipToLevelPlayNodeT AsISkipToLevelPlayNode()
		{
			return this.As<ISkipToLevelPlayNodeT>();
		}

		// Token: 0x0601CC9F RID: 117919 RVA: 0x0040E248 File Offset: 0x0040C448
		public static IGmCommand_UnionUnion FromISkipToLevelPlayNode(ISkipToLevelPlayNodeT _iskiptolevelplaynode)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ISkipToLevelPlayNode,
				Value = _iskiptolevelplaynode
			};
		}

		// Token: 0x0601CCA0 RID: 117920 RVA: 0x0040E25D File Offset: 0x0040C45D
		public IFinishCurrentLevelPlayNodeT AsIFinishCurrentLevelPlayNode()
		{
			return this.As<IFinishCurrentLevelPlayNodeT>();
		}

		// Token: 0x0601CCA1 RID: 117921 RVA: 0x0040E265 File Offset: 0x0040C465
		public static IGmCommand_UnionUnion FromIFinishCurrentLevelPlayNode(IFinishCurrentLevelPlayNodeT _ifinishcurrentlevelplaynode)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IFinishCurrentLevelPlayNode,
				Value = _ifinishcurrentlevelplaynode
			};
		}

		// Token: 0x0601CCA2 RID: 117922 RVA: 0x0040E27A File Offset: 0x0040C47A
		public ITeleportToCurLevelPlayTrackPositionT AsITeleportToCurLevelPlayTrackPosition()
		{
			return this.As<ITeleportToCurLevelPlayTrackPositionT>();
		}

		// Token: 0x0601CCA3 RID: 117923 RVA: 0x0040E282 File Offset: 0x0040C482
		public static IGmCommand_UnionUnion FromITeleportToCurLevelPlayTrackPosition(ITeleportToCurLevelPlayTrackPositionT _iteleporttocurlevelplaytrackposition)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ITeleportToCurLevelPlayTrackPosition,
				Value = _iteleporttocurlevelplaytrackposition
			};
		}

		// Token: 0x0601CCA4 RID: 117924 RVA: 0x0040E297 File Offset: 0x0040C497
		public IGmSetLevelPlaySwitchForceT AsIGmSetLevelPlaySwitchForce()
		{
			return this.As<IGmSetLevelPlaySwitchForceT>();
		}

		// Token: 0x0601CCA5 RID: 117925 RVA: 0x0040E29F File Offset: 0x0040C49F
		public static IGmCommand_UnionUnion FromIGmSetLevelPlaySwitchForce(IGmSetLevelPlaySwitchForceT _igmsetlevelplayswitchforce)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IGmSetLevelPlaySwitchForce,
				Value = _igmsetlevelplayswitchforce
			};
		}

		// Token: 0x0601CCA6 RID: 117926 RVA: 0x0040E2B4 File Offset: 0x0040C4B4
		public IGmSetLevelPlayUpdateForceT AsIGmSetLevelPlayUpdateForce()
		{
			return this.As<IGmSetLevelPlayUpdateForceT>();
		}

		// Token: 0x0601CCA7 RID: 117927 RVA: 0x0040E2BC File Offset: 0x0040C4BC
		public static IGmCommand_UnionUnion FromIGmSetLevelPlayUpdateForce(IGmSetLevelPlayUpdateForceT _igmsetlevelplayupdateforce)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IGmSetLevelPlayUpdateForce,
				Value = _igmsetlevelplayupdateforce
			};
		}

		// Token: 0x0601CCA8 RID: 117928 RVA: 0x0040E2D1 File Offset: 0x0040C4D1
		public ITeleportToLevelPlayCenterT AsITeleportToLevelPlayCenter()
		{
			return this.As<ITeleportToLevelPlayCenterT>();
		}

		// Token: 0x0601CCA9 RID: 117929 RVA: 0x0040E2D9 File Offset: 0x0040C4D9
		public static IGmCommand_UnionUnion FromITeleportToLevelPlayCenter(ITeleportToLevelPlayCenterT _iteleporttolevelplaycenter)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ITeleportToLevelPlayCenter,
				Value = _iteleporttolevelplaycenter
			};
		}

		// Token: 0x0601CCAA RID: 117930 RVA: 0x0040E2EE File Offset: 0x0040C4EE
		public ISkipToQuestNodeT AsISkipToQuestNode()
		{
			return this.As<ISkipToQuestNodeT>();
		}

		// Token: 0x0601CCAB RID: 117931 RVA: 0x0040E2F6 File Offset: 0x0040C4F6
		public static IGmCommand_UnionUnion FromISkipToQuestNode(ISkipToQuestNodeT _iskiptoquestnode)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ISkipToQuestNode,
				Value = _iskiptoquestnode
			};
		}

		// Token: 0x0601CCAC RID: 117932 RVA: 0x0040E30B File Offset: 0x0040C50B
		public IFinishCurrentTrackQuestNodeT AsIFinishCurrentTrackQuestNode()
		{
			return this.As<IFinishCurrentTrackQuestNodeT>();
		}

		// Token: 0x0601CCAD RID: 117933 RVA: 0x0040E313 File Offset: 0x0040C513
		public static IGmCommand_UnionUnion FromIFinishCurrentTrackQuestNode(IFinishCurrentTrackQuestNodeT _ifinishcurrenttrackquestnode)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IFinishCurrentTrackQuestNode,
				Value = _ifinishcurrenttrackquestnode
			};
		}

		// Token: 0x0601CCAE RID: 117934 RVA: 0x0040E329 File Offset: 0x0040C529
		public ITeleportToCurQuestTrackPositionT AsITeleportToCurQuestTrackPosition()
		{
			return this.As<ITeleportToCurQuestTrackPositionT>();
		}

		// Token: 0x0601CCAF RID: 117935 RVA: 0x0040E331 File Offset: 0x0040C531
		public static IGmCommand_UnionUnion FromITeleportToCurQuestTrackPosition(ITeleportToCurQuestTrackPositionT _iteleporttocurquesttrackposition)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ITeleportToCurQuestTrackPosition,
				Value = _iteleporttocurquesttrackposition
			};
		}

		// Token: 0x0601CCB0 RID: 117936 RVA: 0x0040E347 File Offset: 0x0040C547
		public IAcceptQuestT AsIAcceptQuest()
		{
			return this.As<IAcceptQuestT>();
		}

		// Token: 0x0601CCB1 RID: 117937 RVA: 0x0040E34F File Offset: 0x0040C54F
		public static IGmCommand_UnionUnion FromIAcceptQuest(IAcceptQuestT _iacceptquest)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IAcceptQuest,
				Value = _iacceptquest
			};
		}

		// Token: 0x0601CCB2 RID: 117938 RVA: 0x0040E365 File Offset: 0x0040C565
		public IUnlockQuestT AsIUnlockQuest()
		{
			return this.As<IUnlockQuestT>();
		}

		// Token: 0x0601CCB3 RID: 117939 RVA: 0x0040E36D File Offset: 0x0040C56D
		public static IGmCommand_UnionUnion FromIUnlockQuest(IUnlockQuestT _iunlockquest)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IUnlockQuest,
				Value = _iunlockquest
			};
		}

		// Token: 0x0601CCB4 RID: 117940 RVA: 0x0040E383 File Offset: 0x0040C583
		public IPlayFlowForGmT AsIPlayFlowForGm()
		{
			return this.As<IPlayFlowForGmT>();
		}

		// Token: 0x0601CCB5 RID: 117941 RVA: 0x0040E38B File Offset: 0x0040C58B
		public static IGmCommand_UnionUnion FromIPlayFlowForGm(IPlayFlowForGmT _iplayflowforgm)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IPlayFlowForGm,
				Value = _iplayflowforgm
			};
		}

		// Token: 0x0601CCB6 RID: 117942 RVA: 0x0040E3A1 File Offset: 0x0040C5A1
		public ISkipToInstanceDungeonNodeT AsISkipToInstanceDungeonNode()
		{
			return this.As<ISkipToInstanceDungeonNodeT>();
		}

		// Token: 0x0601CCB7 RID: 117943 RVA: 0x0040E3A9 File Offset: 0x0040C5A9
		public static IGmCommand_UnionUnion FromISkipToInstanceDungeonNode(ISkipToInstanceDungeonNodeT _iskiptoinstancedungeonnode)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ISkipToInstanceDungeonNode,
				Value = _iskiptoinstancedungeonnode
			};
		}

		// Token: 0x0601CCB8 RID: 117944 RVA: 0x0040E3BF File Offset: 0x0040C5BF
		public IFinishCurTrackDungeonNodeT AsIFinishCurTrackDungeonNode()
		{
			return this.As<IFinishCurTrackDungeonNodeT>();
		}

		// Token: 0x0601CCB9 RID: 117945 RVA: 0x0040E3C7 File Offset: 0x0040C5C7
		public static IGmCommand_UnionUnion FromIFinishCurTrackDungeonNode(IFinishCurTrackDungeonNodeT _ifinishcurtrackdungeonnode)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IFinishCurTrackDungeonNode,
				Value = _ifinishcurtrackdungeonnode
			};
		}

		// Token: 0x0601CCBA RID: 117946 RVA: 0x0040E3DD File Offset: 0x0040C5DD
		public ITeleportToCurDungeonTrackPositionT AsITeleportToCurDungeonTrackPosition()
		{
			return this.As<ITeleportToCurDungeonTrackPositionT>();
		}

		// Token: 0x0601CCBB RID: 117947 RVA: 0x0040E3E5 File Offset: 0x0040C5E5
		public static IGmCommand_UnionUnion FromITeleportToCurDungeonTrackPosition(ITeleportToCurDungeonTrackPositionT _iteleporttocurdungeontrackposition)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ITeleportToCurDungeonTrackPosition,
				Value = _iteleporttocurdungeontrackposition
			};
		}

		// Token: 0x0601CCBC RID: 117948 RVA: 0x0040E3FB File Offset: 0x0040C5FB
		public IResetCurrentDungeonT AsIResetCurrentDungeon()
		{
			return this.As<IResetCurrentDungeonT>();
		}

		// Token: 0x0601CCBD RID: 117949 RVA: 0x0040E403 File Offset: 0x0040C603
		public static IGmCommand_UnionUnion FromIResetCurrentDungeon(IResetCurrentDungeonT _iresetcurrentdungeon)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IResetCurrentDungeon,
				Value = _iresetcurrentdungeon
			};
		}

		// Token: 0x0601CCBE RID: 117950 RVA: 0x0040E419 File Offset: 0x0040C619
		public IExitDungeonInGmT AsIExitDungeonInGm()
		{
			return this.As<IExitDungeonInGmT>();
		}

		// Token: 0x0601CCBF RID: 117951 RVA: 0x0040E421 File Offset: 0x0040C621
		public static IGmCommand_UnionUnion FromIExitDungeonInGm(IExitDungeonInGmT _iexitdungeoningm)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IExitDungeonInGm,
				Value = _iexitdungeoningm
			};
		}

		// Token: 0x0601CCC0 RID: 117952 RVA: 0x0040E437 File Offset: 0x0040C637
		public IGmRoguelikeStartInGmT AsIGmRoguelikeStartInGm()
		{
			return this.As<IGmRoguelikeStartInGmT>();
		}

		// Token: 0x0601CCC1 RID: 117953 RVA: 0x0040E43F File Offset: 0x0040C63F
		public static IGmCommand_UnionUnion FromIGmRoguelikeStartInGm(IGmRoguelikeStartInGmT _igmroguelikestartingm)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IGmRoguelikeStartInGm,
				Value = _igmroguelikestartingm
			};
		}

		// Token: 0x0601CCC2 RID: 117954 RVA: 0x0040E455 File Offset: 0x0040C655
		public IGmGotoRogueRoomInGmT AsIGmGotoRogueRoomInGm()
		{
			return this.As<IGmGotoRogueRoomInGmT>();
		}

		// Token: 0x0601CCC3 RID: 117955 RVA: 0x0040E45D File Offset: 0x0040C65D
		public static IGmCommand_UnionUnion FromIGmGotoRogueRoomInGm(IGmGotoRogueRoomInGmT _igmgotorogueroomingm)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IGmGotoRogueRoomInGm,
				Value = _igmgotorogueroomingm
			};
		}

		// Token: 0x0601CCC4 RID: 117956 RVA: 0x0040E473 File Offset: 0x0040C673
		public IUnlockEntityForGmT AsIUnlockEntityForGm()
		{
			return this.As<IUnlockEntityForGmT>();
		}

		// Token: 0x0601CCC5 RID: 117957 RVA: 0x0040E47B File Offset: 0x0040C67B
		public static IGmCommand_UnionUnion FromIUnlockEntityForGm(IUnlockEntityForGmT _iunlockentityforgm)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IUnlockEntityForGm,
				Value = _iunlockentityforgm
			};
		}

		// Token: 0x0601CCC6 RID: 117958 RVA: 0x0040E491 File Offset: 0x0040C691
		public ITeleportToEntityT AsITeleportToEntity()
		{
			return this.As<ITeleportToEntityT>();
		}

		// Token: 0x0601CCC7 RID: 117959 RVA: 0x0040E499 File Offset: 0x0040C699
		public static IGmCommand_UnionUnion FromITeleportToEntity(ITeleportToEntityT _iteleporttoentity)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ITeleportToEntity,
				Value = _iteleporttoentity
			};
		}

		// Token: 0x0601CCC8 RID: 117960 RVA: 0x0040E4AF File Offset: 0x0040C6AF
		public IGmTeleportToEntityT AsIGmTeleportToEntity()
		{
			return this.As<IGmTeleportToEntityT>();
		}

		// Token: 0x0601CCC9 RID: 117961 RVA: 0x0040E4B7 File Offset: 0x0040C6B7
		public static IGmCommand_UnionUnion FromIGmTeleportToEntity(IGmTeleportToEntityT _igmteleporttoentity)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IGmTeleportToEntity,
				Value = _igmteleporttoentity
			};
		}

		// Token: 0x0601CCCA RID: 117962 RVA: 0x0040E4CD File Offset: 0x0040C6CD
		public IOpenDungeonEntranceT AsIOpenDungeonEntrance()
		{
			return this.As<IOpenDungeonEntranceT>();
		}

		// Token: 0x0601CCCB RID: 117963 RVA: 0x0040E4D5 File Offset: 0x0040C6D5
		public static IGmCommand_UnionUnion FromIOpenDungeonEntrance(IOpenDungeonEntranceT _iopendungeonentrance)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IOpenDungeonEntrance,
				Value = _iopendungeonentrance
			};
		}

		// Token: 0x0601CCCC RID: 117964 RVA: 0x0040E4EB File Offset: 0x0040C6EB
		public IShowTipsViewT AsIShowTipsView()
		{
			return this.As<IShowTipsViewT>();
		}

		// Token: 0x0601CCCD RID: 117965 RVA: 0x0040E4F3 File Offset: 0x0040C6F3
		public static IGmCommand_UnionUnion FromIShowTipsView(IShowTipsViewT _ishowtipsview)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IShowTipsView,
				Value = _ishowtipsview
			};
		}

		// Token: 0x0601CCCE RID: 117966 RVA: 0x0040E509 File Offset: 0x0040C709
		public IShieldGuideT AsIShieldGuide()
		{
			return this.As<IShieldGuideT>();
		}

		// Token: 0x0601CCCF RID: 117967 RVA: 0x0040E511 File Offset: 0x0040C711
		public static IGmCommand_UnionUnion FromIShieldGuide(IShieldGuideT _ishieldguide)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IShieldGuide,
				Value = _ishieldguide
			};
		}

		// Token: 0x0601CCD0 RID: 117968 RVA: 0x0040E527 File Offset: 0x0040C727
		public IOpenFuncT AsIOpenFunc()
		{
			return this.As<IOpenFuncT>();
		}

		// Token: 0x0601CCD1 RID: 117969 RVA: 0x0040E52F File Offset: 0x0040C72F
		public static IGmCommand_UnionUnion FromIOpenFunc(IOpenFuncT _iopenfunc)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IOpenFunc,
				Value = _iopenfunc
			};
		}

		// Token: 0x0601CCD2 RID: 117970 RVA: 0x0040E545 File Offset: 0x0040C745
		public ISetTimeT AsISetTime()
		{
			return this.As<ISetTimeT>();
		}

		// Token: 0x0601CCD3 RID: 117971 RVA: 0x0040E54D File Offset: 0x0040C74D
		public static IGmCommand_UnionUnion FromISetTime(ISetTimeT _isettime)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ISetTime,
				Value = _isettime
			};
		}

		// Token: 0x0601CCD4 RID: 117972 RVA: 0x0040E563 File Offset: 0x0040C763
		public IUnlockAllExploreSkillT AsIUnlockAllExploreSkill()
		{
			return this.As<IUnlockAllExploreSkillT>();
		}

		// Token: 0x0601CCD5 RID: 117973 RVA: 0x0040E56B File Offset: 0x0040C76B
		public static IGmCommand_UnionUnion FromIUnlockAllExploreSkill(IUnlockAllExploreSkillT _iunlockallexploreskill)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IUnlockAllExploreSkill,
				Value = _iunlockallexploreskill
			};
		}

		// Token: 0x0601CCD6 RID: 117974 RVA: 0x0040E581 File Offset: 0x0040C781
		public IActivateTeleportT AsIActivateTeleport()
		{
			return this.As<IActivateTeleportT>();
		}

		// Token: 0x0601CCD7 RID: 117975 RVA: 0x0040E589 File Offset: 0x0040C789
		public static IGmCommand_UnionUnion FromIActivateTeleport(IActivateTeleportT _iactivateteleport)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IActivateTeleport,
				Value = _iactivateteleport
			};
		}

		// Token: 0x0601CCD8 RID: 117976 RVA: 0x0040E59F File Offset: 0x0040C79F
		public ISetUnopenedAreaPullbackT AsISetUnopenedAreaPullback()
		{
			return this.As<ISetUnopenedAreaPullbackT>();
		}

		// Token: 0x0601CCD9 RID: 117977 RVA: 0x0040E5A7 File Offset: 0x0040C7A7
		public static IGmCommand_UnionUnion FromISetUnopenedAreaPullback(ISetUnopenedAreaPullbackT _isetunopenedareapullback)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ISetUnopenedAreaPullback,
				Value = _isetunopenedareapullback
			};
		}

		// Token: 0x0601CCDA RID: 117978 RVA: 0x0040E5BD File Offset: 0x0040C7BD
		public ITeleportToPosT AsITeleportToPos()
		{
			return this.As<ITeleportToPosT>();
		}

		// Token: 0x0601CCDB RID: 117979 RVA: 0x0040E5C5 File Offset: 0x0040C7C5
		public static IGmCommand_UnionUnion FromITeleportToPos(ITeleportToPosT _iteleporttopos)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ITeleportToPos,
				Value = _iteleporttopos
			};
		}

		// Token: 0x0601CCDC RID: 117980 RVA: 0x0040E5DB File Offset: 0x0040C7DB
		public ITeleportToPosInWorldT AsITeleportToPosInWorld()
		{
			return this.As<ITeleportToPosInWorldT>();
		}

		// Token: 0x0601CCDD RID: 117981 RVA: 0x0040E5E3 File Offset: 0x0040C7E3
		public static IGmCommand_UnionUnion FromITeleportToPosInWorld(ITeleportToPosInWorldT _iteleporttoposinworld)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ITeleportToPosInWorld,
				Value = _iteleporttoposinworld
			};
		}

		// Token: 0x0601CCDE RID: 117982 RVA: 0x0040E5F9 File Offset: 0x0040C7F9
		public IUnfreezeInstanceLimitT AsIUnfreezeInstanceLimit()
		{
			return this.As<IUnfreezeInstanceLimitT>();
		}

		// Token: 0x0601CCDF RID: 117983 RVA: 0x0040E601 File Offset: 0x0040C801
		public static IGmCommand_UnionUnion FromIUnfreezeInstanceLimit(IUnfreezeInstanceLimitT _iunfreezeinstancelimit)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IUnfreezeInstanceLimit,
				Value = _iunfreezeinstancelimit
			};
		}

		// Token: 0x0601CCE0 RID: 117984 RVA: 0x0040E617 File Offset: 0x0040C817
		public IUpdateSceneRolesT AsIUpdateSceneRoles()
		{
			return this.As<IUpdateSceneRolesT>();
		}

		// Token: 0x0601CCE1 RID: 117985 RVA: 0x0040E61F File Offset: 0x0040C81F
		public static IGmCommand_UnionUnion FromIUpdateSceneRoles(IUpdateSceneRolesT _iupdatesceneroles)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IUpdateSceneRoles,
				Value = _iupdatesceneroles
			};
		}

		// Token: 0x0601CCE2 RID: 117986 RVA: 0x0040E635 File Offset: 0x0040C835
		public IAddAllRoleT AsIAddAllRole()
		{
			return this.As<IAddAllRoleT>();
		}

		// Token: 0x0601CCE3 RID: 117987 RVA: 0x0040E63D File Offset: 0x0040C83D
		public static IGmCommand_UnionUnion FromIAddAllRole(IAddAllRoleT _iaddallrole)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IAddAllRole,
				Value = _iaddallrole
			};
		}

		// Token: 0x0601CCE4 RID: 117988 RVA: 0x0040E653 File Offset: 0x0040C853
		public IAddNewRoleT AsIAddNewRole()
		{
			return this.As<IAddNewRoleT>();
		}

		// Token: 0x0601CCE5 RID: 117989 RVA: 0x0040E65B File Offset: 0x0040C85B
		public static IGmCommand_UnionUnion FromIAddNewRole(IAddNewRoleT _iaddnewrole)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IAddNewRole,
				Value = _iaddnewrole
			};
		}

		// Token: 0x0601CCE6 RID: 117990 RVA: 0x0040E671 File Offset: 0x0040C871
		public ISetAllRoleToGraduateT AsISetAllRoleToGraduate()
		{
			return this.As<ISetAllRoleToGraduateT>();
		}

		// Token: 0x0601CCE7 RID: 117991 RVA: 0x0040E679 File Offset: 0x0040C879
		public static IGmCommand_UnionUnion FromISetAllRoleToGraduate(ISetAllRoleToGraduateT _isetallroletograduate)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ISetAllRoleToGraduate,
				Value = _isetallroletograduate
			};
		}

		// Token: 0x0601CCE8 RID: 117992 RVA: 0x0040E68F File Offset: 0x0040C88F
		public IAddAllItemT AsIAddAllItem()
		{
			return this.As<IAddAllItemT>();
		}

		// Token: 0x0601CCE9 RID: 117993 RVA: 0x0040E697 File Offset: 0x0040C897
		public static IGmCommand_UnionUnion FromIAddAllItem(IAddAllItemT _iaddallitem)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IAddAllItem,
				Value = _iaddallitem
			};
		}

		// Token: 0x0601CCEA RID: 117994 RVA: 0x0040E6AD File Offset: 0x0040C8AD
		public IAddItemT AsIAddItem()
		{
			return this.As<IAddItemT>();
		}

		// Token: 0x0601CCEB RID: 117995 RVA: 0x0040E6B5 File Offset: 0x0040C8B5
		public static IGmCommand_UnionUnion FromIAddItem(IAddItemT _iadditem)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IAddItem,
				Value = _iadditem
			};
		}

		// Token: 0x0601CCEC RID: 117996 RVA: 0x0040E6CB File Offset: 0x0040C8CB
		public IAddAllPhantomT AsIAddAllPhantom()
		{
			return this.As<IAddAllPhantomT>();
		}

		// Token: 0x0601CCED RID: 117997 RVA: 0x0040E6D3 File Offset: 0x0040C8D3
		public static IGmCommand_UnionUnion FromIAddAllPhantom(IAddAllPhantomT _iaddallphantom)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IAddAllPhantom,
				Value = _iaddallphantom
			};
		}

		// Token: 0x0601CCEE RID: 117998 RVA: 0x0040E6E9 File Offset: 0x0040C8E9
		public IGetAllGraduatedPhantomT AsIGetAllGraduatedPhantom()
		{
			return this.As<IGetAllGraduatedPhantomT>();
		}

		// Token: 0x0601CCEF RID: 117999 RVA: 0x0040E6F1 File Offset: 0x0040C8F1
		public static IGmCommand_UnionUnion FromIGetAllGraduatedPhantom(IGetAllGraduatedPhantomT _igetallgraduatedphantom)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IGetAllGraduatedPhantom,
				Value = _igetallgraduatedphantom
			};
		}

		// Token: 0x0601CCF0 RID: 118000 RVA: 0x0040E707 File Offset: 0x0040C907
		public IGetAllGraduatedWeaponT AsIGetAllGraduatedWeapon()
		{
			return this.As<IGetAllGraduatedWeaponT>();
		}

		// Token: 0x0601CCF1 RID: 118001 RVA: 0x0040E70F File Offset: 0x0040C90F
		public static IGmCommand_UnionUnion FromIGetAllGraduatedWeapon(IGetAllGraduatedWeaponT _igetallgraduatedweapon)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IGetAllGraduatedWeapon,
				Value = _igetallgraduatedweapon
			};
		}

		// Token: 0x0601CCF2 RID: 118002 RVA: 0x0040E725 File Offset: 0x0040C925
		public ISetEquippedWeaponToGraduateT AsISetEquippedWeaponToGraduate()
		{
			return this.As<ISetEquippedWeaponToGraduateT>();
		}

		// Token: 0x0601CCF3 RID: 118003 RVA: 0x0040E72D File Offset: 0x0040C92D
		public static IGmCommand_UnionUnion FromISetEquippedWeaponToGraduate(ISetEquippedWeaponToGraduateT _isetequippedweapontograduate)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ISetEquippedWeaponToGraduate,
				Value = _isetequippedweapontograduate
			};
		}

		// Token: 0x0601CCF4 RID: 118004 RVA: 0x0040E743 File Offset: 0x0040C943
		public IEquipGraduatedWeaponToTeamT AsIEquipGraduatedWeaponToTeam()
		{
			return this.As<IEquipGraduatedWeaponToTeamT>();
		}

		// Token: 0x0601CCF5 RID: 118005 RVA: 0x0040E74B File Offset: 0x0040C94B
		public static IGmCommand_UnionUnion FromIEquipGraduatedWeaponToTeam(IEquipGraduatedWeaponToTeamT _iequipgraduatedweapontoteam)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IEquipGraduatedWeaponToTeam,
				Value = _iequipgraduatedweapontoteam
			};
		}

		// Token: 0x0601CCF6 RID: 118006 RVA: 0x0040E761 File Offset: 0x0040C961
		public IExecuteActionListT AsIExecuteActionList()
		{
			return this.As<IExecuteActionListT>();
		}

		// Token: 0x0601CCF7 RID: 118007 RVA: 0x0040E769 File Offset: 0x0040C969
		public static IGmCommand_UnionUnion FromIExecuteActionList(IExecuteActionListT _iexecuteactionlist)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IExecuteActionList,
				Value = _iexecuteactionlist
			};
		}

		// Token: 0x0601CCF8 RID: 118008 RVA: 0x0040E77F File Offset: 0x0040C97F
		public IOpenBackLoginViewT AsIOpenBackLoginView()
		{
			return this.As<IOpenBackLoginViewT>();
		}

		// Token: 0x0601CCF9 RID: 118009 RVA: 0x0040E787 File Offset: 0x0040C987
		public static IGmCommand_UnionUnion FromIOpenBackLoginView(IOpenBackLoginViewT _iopenbackloginview)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IOpenBackLoginView,
				Value = _iopenbackloginview
			};
		}

		// Token: 0x0601CCFA RID: 118010 RVA: 0x0040E79D File Offset: 0x0040C99D
		public ISavePlayerDataT AsISavePlayerData()
		{
			return this.As<ISavePlayerDataT>();
		}

		// Token: 0x0601CCFB RID: 118011 RVA: 0x0040E7A5 File Offset: 0x0040C9A5
		public static IGmCommand_UnionUnion FromISavePlayerData(ISavePlayerDataT _isaveplayerdata)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ISavePlayerData,
				Value = _isaveplayerdata
			};
		}

		// Token: 0x0601CCFC RID: 118012 RVA: 0x0040E7BB File Offset: 0x0040C9BB
		public IBrokenRockHotFixT AsIBrokenRockHotFix()
		{
			return this.As<IBrokenRockHotFixT>();
		}

		// Token: 0x0601CCFD RID: 118013 RVA: 0x0040E7C3 File Offset: 0x0040C9C3
		public static IGmCommand_UnionUnion FromIBrokenRockHotFix(IBrokenRockHotFixT _ibrokenrockhotfix)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IBrokenRockHotFix,
				Value = _ibrokenrockhotfix
			};
		}

		// Token: 0x0601CCFE RID: 118014 RVA: 0x0040E7D9 File Offset: 0x0040C9D9
		public ISetVarT AsISetVar()
		{
			return this.As<ISetVarT>();
		}

		// Token: 0x0601CCFF RID: 118015 RVA: 0x0040E7E1 File Offset: 0x0040C9E1
		public static IGmCommand_UnionUnion FromISetVar(ISetVarT _isetvar)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ISetVar,
				Value = _isetvar
			};
		}

		// Token: 0x0601CD00 RID: 118016 RVA: 0x0040E7F7 File Offset: 0x0040C9F7
		public IGoToNodeT AsIGoToNode()
		{
			return this.As<IGoToNodeT>();
		}

		// Token: 0x0601CD01 RID: 118017 RVA: 0x0040E7FF File Offset: 0x0040C9FF
		public static IGmCommand_UnionUnion FromIGoToNode(IGoToNodeT _igotonode)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IGoToNode,
				Value = _igotonode
			};
		}

		// Token: 0x0601CD02 RID: 118018 RVA: 0x0040E815 File Offset: 0x0040CA15
		public ICustomTextGmT AsICustomTextGm()
		{
			return this.As<ICustomTextGmT>();
		}

		// Token: 0x0601CD03 RID: 118019 RVA: 0x0040E81D File Offset: 0x0040CA1D
		public static IGmCommand_UnionUnion FromICustomTextGm(ICustomTextGmT _icustomtextgm)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ICustomTextGm,
				Value = _icustomtextgm
			};
		}

		// Token: 0x0601CD04 RID: 118020 RVA: 0x0040E833 File Offset: 0x0040CA33
		public IStartCombatOperationCaptureT AsIStartCombatOperationCapture()
		{
			return this.As<IStartCombatOperationCaptureT>();
		}

		// Token: 0x0601CD05 RID: 118021 RVA: 0x0040E83B File Offset: 0x0040CA3B
		public static IGmCommand_UnionUnion FromIStartCombatOperationCapture(IStartCombatOperationCaptureT _istartcombatoperationcapture)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IStartCombatOperationCapture,
				Value = _istartcombatoperationcapture
			};
		}

		// Token: 0x0601CD06 RID: 118022 RVA: 0x0040E851 File Offset: 0x0040CA51
		public IStopCombatOperationCaptureT AsIStopCombatOperationCapture()
		{
			return this.As<IStopCombatOperationCaptureT>();
		}

		// Token: 0x0601CD07 RID: 118023 RVA: 0x0040E859 File Offset: 0x0040CA59
		public static IGmCommand_UnionUnion FromIStopCombatOperationCapture(IStopCombatOperationCaptureT _istopcombatoperationcapture)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IStopCombatOperationCapture,
				Value = _istopcombatoperationcapture
			};
		}

		// Token: 0x0601CD08 RID: 118024 RVA: 0x0040E86F File Offset: 0x0040CA6F
		public IRecordCombatOperationCaptureCheckpointT AsIRecordCombatOperationCaptureCheckpoint()
		{
			return this.As<IRecordCombatOperationCaptureCheckpointT>();
		}

		// Token: 0x0601CD09 RID: 118025 RVA: 0x0040E877 File Offset: 0x0040CA77
		public static IGmCommand_UnionUnion FromIRecordCombatOperationCaptureCheckpoint(IRecordCombatOperationCaptureCheckpointT _irecordcombatoperationcapturecheckpoint)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IRecordCombatOperationCaptureCheckpoint,
				Value = _irecordcombatoperationcapturecheckpoint
			};
		}

		// Token: 0x0601CD0A RID: 118026 RVA: 0x0040E88D File Offset: 0x0040CA8D
		public IStartCombatOperationReplayT AsIStartCombatOperationReplay()
		{
			return this.As<IStartCombatOperationReplayT>();
		}

		// Token: 0x0601CD0B RID: 118027 RVA: 0x0040E895 File Offset: 0x0040CA95
		public static IGmCommand_UnionUnion FromIStartCombatOperationReplay(IStartCombatOperationReplayT _istartcombatoperationreplay)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IStartCombatOperationReplay,
				Value = _istartcombatoperationreplay
			};
		}

		// Token: 0x0601CD0C RID: 118028 RVA: 0x0040E8AB File Offset: 0x0040CAAB
		public IStopCombatOperationReplayT AsIStopCombatOperationReplay()
		{
			return this.As<IStopCombatOperationReplayT>();
		}

		// Token: 0x0601CD0D RID: 118029 RVA: 0x0040E8B3 File Offset: 0x0040CAB3
		public static IGmCommand_UnionUnion FromIStopCombatOperationReplay(IStopCombatOperationReplayT _istopcombatoperationreplay)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IStopCombatOperationReplay,
				Value = _istopcombatoperationreplay
			};
		}

		// Token: 0x0601CD0E RID: 118030 RVA: 0x0040E8CC File Offset: 0x0040CACC
		public static int Pack(FlatBufferBuilder builder, IGmCommand_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IGmCommand_Union.IGmCommand:
				return IGmCommand.Pack(builder, _o.AsIGmCommand()).Value;
			case IGmCommand_Union.ISkipToLevelPlayNode:
				return ISkipToLevelPlayNode.Pack(builder, _o.AsISkipToLevelPlayNode()).Value;
			case IGmCommand_Union.IFinishCurrentLevelPlayNode:
				return IFinishCurrentLevelPlayNode.Pack(builder, _o.AsIFinishCurrentLevelPlayNode()).Value;
			case IGmCommand_Union.ITeleportToCurLevelPlayTrackPosition:
				return ITeleportToCurLevelPlayTrackPosition.Pack(builder, _o.AsITeleportToCurLevelPlayTrackPosition()).Value;
			case IGmCommand_Union.IGmSetLevelPlaySwitchForce:
				return IGmSetLevelPlaySwitchForce.Pack(builder, _o.AsIGmSetLevelPlaySwitchForce()).Value;
			case IGmCommand_Union.IGmSetLevelPlayUpdateForce:
				return IGmSetLevelPlayUpdateForce.Pack(builder, _o.AsIGmSetLevelPlayUpdateForce()).Value;
			case IGmCommand_Union.ITeleportToLevelPlayCenter:
				return ITeleportToLevelPlayCenter.Pack(builder, _o.AsITeleportToLevelPlayCenter()).Value;
			case IGmCommand_Union.ISkipToQuestNode:
				return ISkipToQuestNode.Pack(builder, _o.AsISkipToQuestNode()).Value;
			case IGmCommand_Union.IFinishCurrentTrackQuestNode:
				return IFinishCurrentTrackQuestNode.Pack(builder, _o.AsIFinishCurrentTrackQuestNode()).Value;
			case IGmCommand_Union.ITeleportToCurQuestTrackPosition:
				return ITeleportToCurQuestTrackPosition.Pack(builder, _o.AsITeleportToCurQuestTrackPosition()).Value;
			case IGmCommand_Union.IAcceptQuest:
				return IAcceptQuest.Pack(builder, _o.AsIAcceptQuest()).Value;
			case IGmCommand_Union.IUnlockQuest:
				return IUnlockQuest.Pack(builder, _o.AsIUnlockQuest()).Value;
			case IGmCommand_Union.IPlayFlowForGm:
				return IPlayFlowForGm.Pack(builder, _o.AsIPlayFlowForGm()).Value;
			case IGmCommand_Union.ISkipToInstanceDungeonNode:
				return ISkipToInstanceDungeonNode.Pack(builder, _o.AsISkipToInstanceDungeonNode()).Value;
			case IGmCommand_Union.IFinishCurTrackDungeonNode:
				return IFinishCurTrackDungeonNode.Pack(builder, _o.AsIFinishCurTrackDungeonNode()).Value;
			case IGmCommand_Union.ITeleportToCurDungeonTrackPosition:
				return ITeleportToCurDungeonTrackPosition.Pack(builder, _o.AsITeleportToCurDungeonTrackPosition()).Value;
			case IGmCommand_Union.IResetCurrentDungeon:
				return IResetCurrentDungeon.Pack(builder, _o.AsIResetCurrentDungeon()).Value;
			case IGmCommand_Union.IExitDungeonInGm:
				return IExitDungeonInGm.Pack(builder, _o.AsIExitDungeonInGm()).Value;
			case IGmCommand_Union.IGmRoguelikeStartInGm:
				return IGmRoguelikeStartInGm.Pack(builder, _o.AsIGmRoguelikeStartInGm()).Value;
			case IGmCommand_Union.IGmGotoRogueRoomInGm:
				return IGmGotoRogueRoomInGm.Pack(builder, _o.AsIGmGotoRogueRoomInGm()).Value;
			case IGmCommand_Union.IUnlockEntityForGm:
				return IUnlockEntityForGm.Pack(builder, _o.AsIUnlockEntityForGm()).Value;
			case IGmCommand_Union.ITeleportToEntity:
				return ITeleportToEntity.Pack(builder, _o.AsITeleportToEntity()).Value;
			case IGmCommand_Union.IGmTeleportToEntity:
				return IGmTeleportToEntity.Pack(builder, _o.AsIGmTeleportToEntity()).Value;
			case IGmCommand_Union.IOpenDungeonEntrance:
				return IOpenDungeonEntrance.Pack(builder, _o.AsIOpenDungeonEntrance()).Value;
			case IGmCommand_Union.IShowTipsView:
				return IShowTipsView.Pack(builder, _o.AsIShowTipsView()).Value;
			case IGmCommand_Union.IShieldGuide:
				return IShieldGuide.Pack(builder, _o.AsIShieldGuide()).Value;
			case IGmCommand_Union.IOpenFunc:
				return IOpenFunc.Pack(builder, _o.AsIOpenFunc()).Value;
			case IGmCommand_Union.ISetTime:
				return ISetTime.Pack(builder, _o.AsISetTime()).Value;
			case IGmCommand_Union.IUnlockAllExploreSkill:
				return IUnlockAllExploreSkill.Pack(builder, _o.AsIUnlockAllExploreSkill()).Value;
			case IGmCommand_Union.IActivateTeleport:
				return IActivateTeleport.Pack(builder, _o.AsIActivateTeleport()).Value;
			case IGmCommand_Union.ISetUnopenedAreaPullback:
				return ISetUnopenedAreaPullback.Pack(builder, _o.AsISetUnopenedAreaPullback()).Value;
			case IGmCommand_Union.ITeleportToPos:
				return ITeleportToPos.Pack(builder, _o.AsITeleportToPos()).Value;
			case IGmCommand_Union.ITeleportToPosInWorld:
				return ITeleportToPosInWorld.Pack(builder, _o.AsITeleportToPosInWorld()).Value;
			case IGmCommand_Union.IUnfreezeInstanceLimit:
				return IUnfreezeInstanceLimit.Pack(builder, _o.AsIUnfreezeInstanceLimit()).Value;
			case IGmCommand_Union.IUpdateSceneRoles:
				return IUpdateSceneRoles.Pack(builder, _o.AsIUpdateSceneRoles()).Value;
			case IGmCommand_Union.IAddAllRole:
				return IAddAllRole.Pack(builder, _o.AsIAddAllRole()).Value;
			case IGmCommand_Union.IAddNewRole:
				return IAddNewRole.Pack(builder, _o.AsIAddNewRole()).Value;
			case IGmCommand_Union.ISetAllRoleToGraduate:
				return ISetAllRoleToGraduate.Pack(builder, _o.AsISetAllRoleToGraduate()).Value;
			case IGmCommand_Union.IAddAllItem:
				return IAddAllItem.Pack(builder, _o.AsIAddAllItem()).Value;
			case IGmCommand_Union.IAddItem:
				return IAddItem.Pack(builder, _o.AsIAddItem()).Value;
			case IGmCommand_Union.IAddAllPhantom:
				return IAddAllPhantom.Pack(builder, _o.AsIAddAllPhantom()).Value;
			case IGmCommand_Union.IGetAllGraduatedPhantom:
				return IGetAllGraduatedPhantom.Pack(builder, _o.AsIGetAllGraduatedPhantom()).Value;
			case IGmCommand_Union.IGetAllGraduatedWeapon:
				return IGetAllGraduatedWeapon.Pack(builder, _o.AsIGetAllGraduatedWeapon()).Value;
			case IGmCommand_Union.ISetEquippedWeaponToGraduate:
				return ISetEquippedWeaponToGraduate.Pack(builder, _o.AsISetEquippedWeaponToGraduate()).Value;
			case IGmCommand_Union.IEquipGraduatedWeaponToTeam:
				return IEquipGraduatedWeaponToTeam.Pack(builder, _o.AsIEquipGraduatedWeaponToTeam()).Value;
			case IGmCommand_Union.IExecuteActionList:
				return IExecuteActionList.Pack(builder, _o.AsIExecuteActionList()).Value;
			case IGmCommand_Union.IOpenBackLoginView:
				return IOpenBackLoginView.Pack(builder, _o.AsIOpenBackLoginView()).Value;
			case IGmCommand_Union.ISavePlayerData:
				return ISavePlayerData.Pack(builder, _o.AsISavePlayerData()).Value;
			case IGmCommand_Union.IBrokenRockHotFix:
				return IBrokenRockHotFix.Pack(builder, _o.AsIBrokenRockHotFix()).Value;
			case IGmCommand_Union.ISetVar:
				return ISetVar.Pack(builder, _o.AsISetVar()).Value;
			case IGmCommand_Union.IGoToNode:
				return IGoToNode.Pack(builder, _o.AsIGoToNode()).Value;
			case IGmCommand_Union.ICustomTextGm:
				return ICustomTextGm.Pack(builder, _o.AsICustomTextGm()).Value;
			case IGmCommand_Union.IStartCombatOperationCapture:
				return IStartCombatOperationCapture.Pack(builder, _o.AsIStartCombatOperationCapture()).Value;
			case IGmCommand_Union.IStopCombatOperationCapture:
				return IStopCombatOperationCapture.Pack(builder, _o.AsIStopCombatOperationCapture()).Value;
			case IGmCommand_Union.IRecordCombatOperationCaptureCheckpoint:
				return IRecordCombatOperationCaptureCheckpoint.Pack(builder, _o.AsIRecordCombatOperationCaptureCheckpoint()).Value;
			case IGmCommand_Union.IStartCombatOperationReplay:
				return IStartCombatOperationReplay.Pack(builder, _o.AsIStartCombatOperationReplay()).Value;
			case IGmCommand_Union.IStopCombatOperationReplay:
				return IStopCombatOperationReplay.Pack(builder, _o.AsIStopCombatOperationReplay()).Value;
			default:
				return 0;
			}
		}
	}
}

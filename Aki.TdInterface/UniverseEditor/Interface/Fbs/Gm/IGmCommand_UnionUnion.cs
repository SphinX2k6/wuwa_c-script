using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200465E RID: 18014
	public class IGmCommand_UnionUnion
	{
		// Token: 0x17007FD5 RID: 32725
		// (get) Token: 0x0601B4C1 RID: 111809 RVA: 0x003E1F3D File Offset: 0x003E013D
		// (set) Token: 0x0601B4C2 RID: 111810 RVA: 0x003E1F45 File Offset: 0x003E0145
		public IGmCommand_Union Type { get; set; }

		// Token: 0x17007FD6 RID: 32726
		// (get) Token: 0x0601B4C3 RID: 111811 RVA: 0x003E1F4E File Offset: 0x003E014E
		// (set) Token: 0x0601B4C4 RID: 111812 RVA: 0x003E1F56 File Offset: 0x003E0156
		public object Value { get; set; }

		// Token: 0x0601B4C5 RID: 111813 RVA: 0x003E1F5F File Offset: 0x003E015F
		public IGmCommand_UnionUnion()
		{
			this.Type = IGmCommand_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601B4C6 RID: 111814 RVA: 0x003E1F75 File Offset: 0x003E0175
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B4C7 RID: 111815 RVA: 0x003E1F87 File Offset: 0x003E0187
		public IGmCommandT AsIGmCommand()
		{
			return this.As<IGmCommandT>();
		}

		// Token: 0x0601B4C8 RID: 111816 RVA: 0x003E1F8F File Offset: 0x003E018F
		public static IGmCommand_UnionUnion FromIGmCommand(IGmCommandT _igmcommand)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IGmCommand,
				Value = _igmcommand
			};
		}

		// Token: 0x0601B4C9 RID: 111817 RVA: 0x003E1FA4 File Offset: 0x003E01A4
		public ISkipToLevelPlayNodeT AsISkipToLevelPlayNode()
		{
			return this.As<ISkipToLevelPlayNodeT>();
		}

		// Token: 0x0601B4CA RID: 111818 RVA: 0x003E1FAC File Offset: 0x003E01AC
		public static IGmCommand_UnionUnion FromISkipToLevelPlayNode(ISkipToLevelPlayNodeT _iskiptolevelplaynode)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ISkipToLevelPlayNode,
				Value = _iskiptolevelplaynode
			};
		}

		// Token: 0x0601B4CB RID: 111819 RVA: 0x003E1FC1 File Offset: 0x003E01C1
		public IFinishCurrentLevelPlayNodeT AsIFinishCurrentLevelPlayNode()
		{
			return this.As<IFinishCurrentLevelPlayNodeT>();
		}

		// Token: 0x0601B4CC RID: 111820 RVA: 0x003E1FC9 File Offset: 0x003E01C9
		public static IGmCommand_UnionUnion FromIFinishCurrentLevelPlayNode(IFinishCurrentLevelPlayNodeT _ifinishcurrentlevelplaynode)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IFinishCurrentLevelPlayNode,
				Value = _ifinishcurrentlevelplaynode
			};
		}

		// Token: 0x0601B4CD RID: 111821 RVA: 0x003E1FDE File Offset: 0x003E01DE
		public ITeleportToCurLevelPlayTrackPositionT AsITeleportToCurLevelPlayTrackPosition()
		{
			return this.As<ITeleportToCurLevelPlayTrackPositionT>();
		}

		// Token: 0x0601B4CE RID: 111822 RVA: 0x003E1FE6 File Offset: 0x003E01E6
		public static IGmCommand_UnionUnion FromITeleportToCurLevelPlayTrackPosition(ITeleportToCurLevelPlayTrackPositionT _iteleporttocurlevelplaytrackposition)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ITeleportToCurLevelPlayTrackPosition,
				Value = _iteleporttocurlevelplaytrackposition
			};
		}

		// Token: 0x0601B4CF RID: 111823 RVA: 0x003E1FFB File Offset: 0x003E01FB
		public IGmSetLevelPlaySwitchForceT AsIGmSetLevelPlaySwitchForce()
		{
			return this.As<IGmSetLevelPlaySwitchForceT>();
		}

		// Token: 0x0601B4D0 RID: 111824 RVA: 0x003E2003 File Offset: 0x003E0203
		public static IGmCommand_UnionUnion FromIGmSetLevelPlaySwitchForce(IGmSetLevelPlaySwitchForceT _igmsetlevelplayswitchforce)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IGmSetLevelPlaySwitchForce,
				Value = _igmsetlevelplayswitchforce
			};
		}

		// Token: 0x0601B4D1 RID: 111825 RVA: 0x003E2018 File Offset: 0x003E0218
		public IGmSetLevelPlayUpdateForceT AsIGmSetLevelPlayUpdateForce()
		{
			return this.As<IGmSetLevelPlayUpdateForceT>();
		}

		// Token: 0x0601B4D2 RID: 111826 RVA: 0x003E2020 File Offset: 0x003E0220
		public static IGmCommand_UnionUnion FromIGmSetLevelPlayUpdateForce(IGmSetLevelPlayUpdateForceT _igmsetlevelplayupdateforce)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IGmSetLevelPlayUpdateForce,
				Value = _igmsetlevelplayupdateforce
			};
		}

		// Token: 0x0601B4D3 RID: 111827 RVA: 0x003E2035 File Offset: 0x003E0235
		public ITeleportToLevelPlayCenterT AsITeleportToLevelPlayCenter()
		{
			return this.As<ITeleportToLevelPlayCenterT>();
		}

		// Token: 0x0601B4D4 RID: 111828 RVA: 0x003E203D File Offset: 0x003E023D
		public static IGmCommand_UnionUnion FromITeleportToLevelPlayCenter(ITeleportToLevelPlayCenterT _iteleporttolevelplaycenter)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ITeleportToLevelPlayCenter,
				Value = _iteleporttolevelplaycenter
			};
		}

		// Token: 0x0601B4D5 RID: 111829 RVA: 0x003E2052 File Offset: 0x003E0252
		public ISkipToQuestNodeT AsISkipToQuestNode()
		{
			return this.As<ISkipToQuestNodeT>();
		}

		// Token: 0x0601B4D6 RID: 111830 RVA: 0x003E205A File Offset: 0x003E025A
		public static IGmCommand_UnionUnion FromISkipToQuestNode(ISkipToQuestNodeT _iskiptoquestnode)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ISkipToQuestNode,
				Value = _iskiptoquestnode
			};
		}

		// Token: 0x0601B4D7 RID: 111831 RVA: 0x003E206F File Offset: 0x003E026F
		public IFinishCurrentTrackQuestNodeT AsIFinishCurrentTrackQuestNode()
		{
			return this.As<IFinishCurrentTrackQuestNodeT>();
		}

		// Token: 0x0601B4D8 RID: 111832 RVA: 0x003E2077 File Offset: 0x003E0277
		public static IGmCommand_UnionUnion FromIFinishCurrentTrackQuestNode(IFinishCurrentTrackQuestNodeT _ifinishcurrenttrackquestnode)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IFinishCurrentTrackQuestNode,
				Value = _ifinishcurrenttrackquestnode
			};
		}

		// Token: 0x0601B4D9 RID: 111833 RVA: 0x003E208D File Offset: 0x003E028D
		public ITeleportToCurQuestTrackPositionT AsITeleportToCurQuestTrackPosition()
		{
			return this.As<ITeleportToCurQuestTrackPositionT>();
		}

		// Token: 0x0601B4DA RID: 111834 RVA: 0x003E2095 File Offset: 0x003E0295
		public static IGmCommand_UnionUnion FromITeleportToCurQuestTrackPosition(ITeleportToCurQuestTrackPositionT _iteleporttocurquesttrackposition)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ITeleportToCurQuestTrackPosition,
				Value = _iteleporttocurquesttrackposition
			};
		}

		// Token: 0x0601B4DB RID: 111835 RVA: 0x003E20AB File Offset: 0x003E02AB
		public IAcceptQuestT AsIAcceptQuest()
		{
			return this.As<IAcceptQuestT>();
		}

		// Token: 0x0601B4DC RID: 111836 RVA: 0x003E20B3 File Offset: 0x003E02B3
		public static IGmCommand_UnionUnion FromIAcceptQuest(IAcceptQuestT _iacceptquest)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IAcceptQuest,
				Value = _iacceptquest
			};
		}

		// Token: 0x0601B4DD RID: 111837 RVA: 0x003E20C9 File Offset: 0x003E02C9
		public IUnlockQuestT AsIUnlockQuest()
		{
			return this.As<IUnlockQuestT>();
		}

		// Token: 0x0601B4DE RID: 111838 RVA: 0x003E20D1 File Offset: 0x003E02D1
		public static IGmCommand_UnionUnion FromIUnlockQuest(IUnlockQuestT _iunlockquest)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IUnlockQuest,
				Value = _iunlockquest
			};
		}

		// Token: 0x0601B4DF RID: 111839 RVA: 0x003E20E7 File Offset: 0x003E02E7
		public IPlayFlowForGmT AsIPlayFlowForGm()
		{
			return this.As<IPlayFlowForGmT>();
		}

		// Token: 0x0601B4E0 RID: 111840 RVA: 0x003E20EF File Offset: 0x003E02EF
		public static IGmCommand_UnionUnion FromIPlayFlowForGm(IPlayFlowForGmT _iplayflowforgm)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IPlayFlowForGm,
				Value = _iplayflowforgm
			};
		}

		// Token: 0x0601B4E1 RID: 111841 RVA: 0x003E2105 File Offset: 0x003E0305
		public ISkipToInstanceDungeonNodeT AsISkipToInstanceDungeonNode()
		{
			return this.As<ISkipToInstanceDungeonNodeT>();
		}

		// Token: 0x0601B4E2 RID: 111842 RVA: 0x003E210D File Offset: 0x003E030D
		public static IGmCommand_UnionUnion FromISkipToInstanceDungeonNode(ISkipToInstanceDungeonNodeT _iskiptoinstancedungeonnode)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ISkipToInstanceDungeonNode,
				Value = _iskiptoinstancedungeonnode
			};
		}

		// Token: 0x0601B4E3 RID: 111843 RVA: 0x003E2123 File Offset: 0x003E0323
		public IFinishCurTrackDungeonNodeT AsIFinishCurTrackDungeonNode()
		{
			return this.As<IFinishCurTrackDungeonNodeT>();
		}

		// Token: 0x0601B4E4 RID: 111844 RVA: 0x003E212B File Offset: 0x003E032B
		public static IGmCommand_UnionUnion FromIFinishCurTrackDungeonNode(IFinishCurTrackDungeonNodeT _ifinishcurtrackdungeonnode)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IFinishCurTrackDungeonNode,
				Value = _ifinishcurtrackdungeonnode
			};
		}

		// Token: 0x0601B4E5 RID: 111845 RVA: 0x003E2141 File Offset: 0x003E0341
		public ITeleportToCurDungeonTrackPositionT AsITeleportToCurDungeonTrackPosition()
		{
			return this.As<ITeleportToCurDungeonTrackPositionT>();
		}

		// Token: 0x0601B4E6 RID: 111846 RVA: 0x003E2149 File Offset: 0x003E0349
		public static IGmCommand_UnionUnion FromITeleportToCurDungeonTrackPosition(ITeleportToCurDungeonTrackPositionT _iteleporttocurdungeontrackposition)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ITeleportToCurDungeonTrackPosition,
				Value = _iteleporttocurdungeontrackposition
			};
		}

		// Token: 0x0601B4E7 RID: 111847 RVA: 0x003E215F File Offset: 0x003E035F
		public IResetCurrentDungeonT AsIResetCurrentDungeon()
		{
			return this.As<IResetCurrentDungeonT>();
		}

		// Token: 0x0601B4E8 RID: 111848 RVA: 0x003E2167 File Offset: 0x003E0367
		public static IGmCommand_UnionUnion FromIResetCurrentDungeon(IResetCurrentDungeonT _iresetcurrentdungeon)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IResetCurrentDungeon,
				Value = _iresetcurrentdungeon
			};
		}

		// Token: 0x0601B4E9 RID: 111849 RVA: 0x003E217D File Offset: 0x003E037D
		public IExitDungeonInGmT AsIExitDungeonInGm()
		{
			return this.As<IExitDungeonInGmT>();
		}

		// Token: 0x0601B4EA RID: 111850 RVA: 0x003E2185 File Offset: 0x003E0385
		public static IGmCommand_UnionUnion FromIExitDungeonInGm(IExitDungeonInGmT _iexitdungeoningm)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IExitDungeonInGm,
				Value = _iexitdungeoningm
			};
		}

		// Token: 0x0601B4EB RID: 111851 RVA: 0x003E219B File Offset: 0x003E039B
		public IGmRoguelikeStartInGmT AsIGmRoguelikeStartInGm()
		{
			return this.As<IGmRoguelikeStartInGmT>();
		}

		// Token: 0x0601B4EC RID: 111852 RVA: 0x003E21A3 File Offset: 0x003E03A3
		public static IGmCommand_UnionUnion FromIGmRoguelikeStartInGm(IGmRoguelikeStartInGmT _igmroguelikestartingm)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IGmRoguelikeStartInGm,
				Value = _igmroguelikestartingm
			};
		}

		// Token: 0x0601B4ED RID: 111853 RVA: 0x003E21B9 File Offset: 0x003E03B9
		public IGmGotoRogueRoomInGmT AsIGmGotoRogueRoomInGm()
		{
			return this.As<IGmGotoRogueRoomInGmT>();
		}

		// Token: 0x0601B4EE RID: 111854 RVA: 0x003E21C1 File Offset: 0x003E03C1
		public static IGmCommand_UnionUnion FromIGmGotoRogueRoomInGm(IGmGotoRogueRoomInGmT _igmgotorogueroomingm)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IGmGotoRogueRoomInGm,
				Value = _igmgotorogueroomingm
			};
		}

		// Token: 0x0601B4EF RID: 111855 RVA: 0x003E21D7 File Offset: 0x003E03D7
		public IUnlockEntityForGmT AsIUnlockEntityForGm()
		{
			return this.As<IUnlockEntityForGmT>();
		}

		// Token: 0x0601B4F0 RID: 111856 RVA: 0x003E21DF File Offset: 0x003E03DF
		public static IGmCommand_UnionUnion FromIUnlockEntityForGm(IUnlockEntityForGmT _iunlockentityforgm)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IUnlockEntityForGm,
				Value = _iunlockentityforgm
			};
		}

		// Token: 0x0601B4F1 RID: 111857 RVA: 0x003E21F5 File Offset: 0x003E03F5
		public ITeleportToEntityT AsITeleportToEntity()
		{
			return this.As<ITeleportToEntityT>();
		}

		// Token: 0x0601B4F2 RID: 111858 RVA: 0x003E21FD File Offset: 0x003E03FD
		public static IGmCommand_UnionUnion FromITeleportToEntity(ITeleportToEntityT _iteleporttoentity)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ITeleportToEntity,
				Value = _iteleporttoentity
			};
		}

		// Token: 0x0601B4F3 RID: 111859 RVA: 0x003E2213 File Offset: 0x003E0413
		public IGmTeleportToEntityT AsIGmTeleportToEntity()
		{
			return this.As<IGmTeleportToEntityT>();
		}

		// Token: 0x0601B4F4 RID: 111860 RVA: 0x003E221B File Offset: 0x003E041B
		public static IGmCommand_UnionUnion FromIGmTeleportToEntity(IGmTeleportToEntityT _igmteleporttoentity)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IGmTeleportToEntity,
				Value = _igmteleporttoentity
			};
		}

		// Token: 0x0601B4F5 RID: 111861 RVA: 0x003E2231 File Offset: 0x003E0431
		public IOpenDungeonEntranceT AsIOpenDungeonEntrance()
		{
			return this.As<IOpenDungeonEntranceT>();
		}

		// Token: 0x0601B4F6 RID: 111862 RVA: 0x003E2239 File Offset: 0x003E0439
		public static IGmCommand_UnionUnion FromIOpenDungeonEntrance(IOpenDungeonEntranceT _iopendungeonentrance)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IOpenDungeonEntrance,
				Value = _iopendungeonentrance
			};
		}

		// Token: 0x0601B4F7 RID: 111863 RVA: 0x003E224F File Offset: 0x003E044F
		public IShowTipsViewT AsIShowTipsView()
		{
			return this.As<IShowTipsViewT>();
		}

		// Token: 0x0601B4F8 RID: 111864 RVA: 0x003E2257 File Offset: 0x003E0457
		public static IGmCommand_UnionUnion FromIShowTipsView(IShowTipsViewT _ishowtipsview)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IShowTipsView,
				Value = _ishowtipsview
			};
		}

		// Token: 0x0601B4F9 RID: 111865 RVA: 0x003E226D File Offset: 0x003E046D
		public IShieldGuideT AsIShieldGuide()
		{
			return this.As<IShieldGuideT>();
		}

		// Token: 0x0601B4FA RID: 111866 RVA: 0x003E2275 File Offset: 0x003E0475
		public static IGmCommand_UnionUnion FromIShieldGuide(IShieldGuideT _ishieldguide)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IShieldGuide,
				Value = _ishieldguide
			};
		}

		// Token: 0x0601B4FB RID: 111867 RVA: 0x003E228B File Offset: 0x003E048B
		public IOpenFuncT AsIOpenFunc()
		{
			return this.As<IOpenFuncT>();
		}

		// Token: 0x0601B4FC RID: 111868 RVA: 0x003E2293 File Offset: 0x003E0493
		public static IGmCommand_UnionUnion FromIOpenFunc(IOpenFuncT _iopenfunc)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IOpenFunc,
				Value = _iopenfunc
			};
		}

		// Token: 0x0601B4FD RID: 111869 RVA: 0x003E22A9 File Offset: 0x003E04A9
		public ISetTimeT AsISetTime()
		{
			return this.As<ISetTimeT>();
		}

		// Token: 0x0601B4FE RID: 111870 RVA: 0x003E22B1 File Offset: 0x003E04B1
		public static IGmCommand_UnionUnion FromISetTime(ISetTimeT _isettime)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ISetTime,
				Value = _isettime
			};
		}

		// Token: 0x0601B4FF RID: 111871 RVA: 0x003E22C7 File Offset: 0x003E04C7
		public IUnlockAllExploreSkillT AsIUnlockAllExploreSkill()
		{
			return this.As<IUnlockAllExploreSkillT>();
		}

		// Token: 0x0601B500 RID: 111872 RVA: 0x003E22CF File Offset: 0x003E04CF
		public static IGmCommand_UnionUnion FromIUnlockAllExploreSkill(IUnlockAllExploreSkillT _iunlockallexploreskill)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IUnlockAllExploreSkill,
				Value = _iunlockallexploreskill
			};
		}

		// Token: 0x0601B501 RID: 111873 RVA: 0x003E22E5 File Offset: 0x003E04E5
		public IActivateTeleportT AsIActivateTeleport()
		{
			return this.As<IActivateTeleportT>();
		}

		// Token: 0x0601B502 RID: 111874 RVA: 0x003E22ED File Offset: 0x003E04ED
		public static IGmCommand_UnionUnion FromIActivateTeleport(IActivateTeleportT _iactivateteleport)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IActivateTeleport,
				Value = _iactivateteleport
			};
		}

		// Token: 0x0601B503 RID: 111875 RVA: 0x003E2303 File Offset: 0x003E0503
		public ISetUnopenedAreaPullbackT AsISetUnopenedAreaPullback()
		{
			return this.As<ISetUnopenedAreaPullbackT>();
		}

		// Token: 0x0601B504 RID: 111876 RVA: 0x003E230B File Offset: 0x003E050B
		public static IGmCommand_UnionUnion FromISetUnopenedAreaPullback(ISetUnopenedAreaPullbackT _isetunopenedareapullback)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ISetUnopenedAreaPullback,
				Value = _isetunopenedareapullback
			};
		}

		// Token: 0x0601B505 RID: 111877 RVA: 0x003E2321 File Offset: 0x003E0521
		public ITeleportToPosT AsITeleportToPos()
		{
			return this.As<ITeleportToPosT>();
		}

		// Token: 0x0601B506 RID: 111878 RVA: 0x003E2329 File Offset: 0x003E0529
		public static IGmCommand_UnionUnion FromITeleportToPos(ITeleportToPosT _iteleporttopos)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ITeleportToPos,
				Value = _iteleporttopos
			};
		}

		// Token: 0x0601B507 RID: 111879 RVA: 0x003E233F File Offset: 0x003E053F
		public ITeleportToPosInWorldT AsITeleportToPosInWorld()
		{
			return this.As<ITeleportToPosInWorldT>();
		}

		// Token: 0x0601B508 RID: 111880 RVA: 0x003E2347 File Offset: 0x003E0547
		public static IGmCommand_UnionUnion FromITeleportToPosInWorld(ITeleportToPosInWorldT _iteleporttoposinworld)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ITeleportToPosInWorld,
				Value = _iteleporttoposinworld
			};
		}

		// Token: 0x0601B509 RID: 111881 RVA: 0x003E235D File Offset: 0x003E055D
		public IUnfreezeInstanceLimitT AsIUnfreezeInstanceLimit()
		{
			return this.As<IUnfreezeInstanceLimitT>();
		}

		// Token: 0x0601B50A RID: 111882 RVA: 0x003E2365 File Offset: 0x003E0565
		public static IGmCommand_UnionUnion FromIUnfreezeInstanceLimit(IUnfreezeInstanceLimitT _iunfreezeinstancelimit)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IUnfreezeInstanceLimit,
				Value = _iunfreezeinstancelimit
			};
		}

		// Token: 0x0601B50B RID: 111883 RVA: 0x003E237B File Offset: 0x003E057B
		public IUpdateSceneRolesT AsIUpdateSceneRoles()
		{
			return this.As<IUpdateSceneRolesT>();
		}

		// Token: 0x0601B50C RID: 111884 RVA: 0x003E2383 File Offset: 0x003E0583
		public static IGmCommand_UnionUnion FromIUpdateSceneRoles(IUpdateSceneRolesT _iupdatesceneroles)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IUpdateSceneRoles,
				Value = _iupdatesceneroles
			};
		}

		// Token: 0x0601B50D RID: 111885 RVA: 0x003E2399 File Offset: 0x003E0599
		public IAddAllRoleT AsIAddAllRole()
		{
			return this.As<IAddAllRoleT>();
		}

		// Token: 0x0601B50E RID: 111886 RVA: 0x003E23A1 File Offset: 0x003E05A1
		public static IGmCommand_UnionUnion FromIAddAllRole(IAddAllRoleT _iaddallrole)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IAddAllRole,
				Value = _iaddallrole
			};
		}

		// Token: 0x0601B50F RID: 111887 RVA: 0x003E23B7 File Offset: 0x003E05B7
		public IAddNewRoleT AsIAddNewRole()
		{
			return this.As<IAddNewRoleT>();
		}

		// Token: 0x0601B510 RID: 111888 RVA: 0x003E23BF File Offset: 0x003E05BF
		public static IGmCommand_UnionUnion FromIAddNewRole(IAddNewRoleT _iaddnewrole)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IAddNewRole,
				Value = _iaddnewrole
			};
		}

		// Token: 0x0601B511 RID: 111889 RVA: 0x003E23D5 File Offset: 0x003E05D5
		public ISetAllRoleToGraduateT AsISetAllRoleToGraduate()
		{
			return this.As<ISetAllRoleToGraduateT>();
		}

		// Token: 0x0601B512 RID: 111890 RVA: 0x003E23DD File Offset: 0x003E05DD
		public static IGmCommand_UnionUnion FromISetAllRoleToGraduate(ISetAllRoleToGraduateT _isetallroletograduate)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ISetAllRoleToGraduate,
				Value = _isetallroletograduate
			};
		}

		// Token: 0x0601B513 RID: 111891 RVA: 0x003E23F3 File Offset: 0x003E05F3
		public IAddAllItemT AsIAddAllItem()
		{
			return this.As<IAddAllItemT>();
		}

		// Token: 0x0601B514 RID: 111892 RVA: 0x003E23FB File Offset: 0x003E05FB
		public static IGmCommand_UnionUnion FromIAddAllItem(IAddAllItemT _iaddallitem)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IAddAllItem,
				Value = _iaddallitem
			};
		}

		// Token: 0x0601B515 RID: 111893 RVA: 0x003E2411 File Offset: 0x003E0611
		public IAddItemT AsIAddItem()
		{
			return this.As<IAddItemT>();
		}

		// Token: 0x0601B516 RID: 111894 RVA: 0x003E2419 File Offset: 0x003E0619
		public static IGmCommand_UnionUnion FromIAddItem(IAddItemT _iadditem)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IAddItem,
				Value = _iadditem
			};
		}

		// Token: 0x0601B517 RID: 111895 RVA: 0x003E242F File Offset: 0x003E062F
		public IAddAllPhantomT AsIAddAllPhantom()
		{
			return this.As<IAddAllPhantomT>();
		}

		// Token: 0x0601B518 RID: 111896 RVA: 0x003E2437 File Offset: 0x003E0637
		public static IGmCommand_UnionUnion FromIAddAllPhantom(IAddAllPhantomT _iaddallphantom)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IAddAllPhantom,
				Value = _iaddallphantom
			};
		}

		// Token: 0x0601B519 RID: 111897 RVA: 0x003E244D File Offset: 0x003E064D
		public IGetAllGraduatedPhantomT AsIGetAllGraduatedPhantom()
		{
			return this.As<IGetAllGraduatedPhantomT>();
		}

		// Token: 0x0601B51A RID: 111898 RVA: 0x003E2455 File Offset: 0x003E0655
		public static IGmCommand_UnionUnion FromIGetAllGraduatedPhantom(IGetAllGraduatedPhantomT _igetallgraduatedphantom)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IGetAllGraduatedPhantom,
				Value = _igetallgraduatedphantom
			};
		}

		// Token: 0x0601B51B RID: 111899 RVA: 0x003E246B File Offset: 0x003E066B
		public IGetAllGraduatedWeaponT AsIGetAllGraduatedWeapon()
		{
			return this.As<IGetAllGraduatedWeaponT>();
		}

		// Token: 0x0601B51C RID: 111900 RVA: 0x003E2473 File Offset: 0x003E0673
		public static IGmCommand_UnionUnion FromIGetAllGraduatedWeapon(IGetAllGraduatedWeaponT _igetallgraduatedweapon)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IGetAllGraduatedWeapon,
				Value = _igetallgraduatedweapon
			};
		}

		// Token: 0x0601B51D RID: 111901 RVA: 0x003E2489 File Offset: 0x003E0689
		public ISetEquippedWeaponToGraduateT AsISetEquippedWeaponToGraduate()
		{
			return this.As<ISetEquippedWeaponToGraduateT>();
		}

		// Token: 0x0601B51E RID: 111902 RVA: 0x003E2491 File Offset: 0x003E0691
		public static IGmCommand_UnionUnion FromISetEquippedWeaponToGraduate(ISetEquippedWeaponToGraduateT _isetequippedweapontograduate)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ISetEquippedWeaponToGraduate,
				Value = _isetequippedweapontograduate
			};
		}

		// Token: 0x0601B51F RID: 111903 RVA: 0x003E24A7 File Offset: 0x003E06A7
		public IEquipGraduatedWeaponToTeamT AsIEquipGraduatedWeaponToTeam()
		{
			return this.As<IEquipGraduatedWeaponToTeamT>();
		}

		// Token: 0x0601B520 RID: 111904 RVA: 0x003E24AF File Offset: 0x003E06AF
		public static IGmCommand_UnionUnion FromIEquipGraduatedWeaponToTeam(IEquipGraduatedWeaponToTeamT _iequipgraduatedweapontoteam)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IEquipGraduatedWeaponToTeam,
				Value = _iequipgraduatedweapontoteam
			};
		}

		// Token: 0x0601B521 RID: 111905 RVA: 0x003E24C5 File Offset: 0x003E06C5
		public IExecuteActionListT AsIExecuteActionList()
		{
			return this.As<IExecuteActionListT>();
		}

		// Token: 0x0601B522 RID: 111906 RVA: 0x003E24CD File Offset: 0x003E06CD
		public static IGmCommand_UnionUnion FromIExecuteActionList(IExecuteActionListT _iexecuteactionlist)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IExecuteActionList,
				Value = _iexecuteactionlist
			};
		}

		// Token: 0x0601B523 RID: 111907 RVA: 0x003E24E3 File Offset: 0x003E06E3
		public IOpenBackLoginViewT AsIOpenBackLoginView()
		{
			return this.As<IOpenBackLoginViewT>();
		}

		// Token: 0x0601B524 RID: 111908 RVA: 0x003E24EB File Offset: 0x003E06EB
		public static IGmCommand_UnionUnion FromIOpenBackLoginView(IOpenBackLoginViewT _iopenbackloginview)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IOpenBackLoginView,
				Value = _iopenbackloginview
			};
		}

		// Token: 0x0601B525 RID: 111909 RVA: 0x003E2501 File Offset: 0x003E0701
		public ISavePlayerDataT AsISavePlayerData()
		{
			return this.As<ISavePlayerDataT>();
		}

		// Token: 0x0601B526 RID: 111910 RVA: 0x003E2509 File Offset: 0x003E0709
		public static IGmCommand_UnionUnion FromISavePlayerData(ISavePlayerDataT _isaveplayerdata)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ISavePlayerData,
				Value = _isaveplayerdata
			};
		}

		// Token: 0x0601B527 RID: 111911 RVA: 0x003E251F File Offset: 0x003E071F
		public IBrokenRockHotFixT AsIBrokenRockHotFix()
		{
			return this.As<IBrokenRockHotFixT>();
		}

		// Token: 0x0601B528 RID: 111912 RVA: 0x003E2527 File Offset: 0x003E0727
		public static IGmCommand_UnionUnion FromIBrokenRockHotFix(IBrokenRockHotFixT _ibrokenrockhotfix)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IBrokenRockHotFix,
				Value = _ibrokenrockhotfix
			};
		}

		// Token: 0x0601B529 RID: 111913 RVA: 0x003E253D File Offset: 0x003E073D
		public ISetVarT AsISetVar()
		{
			return this.As<ISetVarT>();
		}

		// Token: 0x0601B52A RID: 111914 RVA: 0x003E2545 File Offset: 0x003E0745
		public static IGmCommand_UnionUnion FromISetVar(ISetVarT _isetvar)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ISetVar,
				Value = _isetvar
			};
		}

		// Token: 0x0601B52B RID: 111915 RVA: 0x003E255B File Offset: 0x003E075B
		public IGoToNodeT AsIGoToNode()
		{
			return this.As<IGoToNodeT>();
		}

		// Token: 0x0601B52C RID: 111916 RVA: 0x003E2563 File Offset: 0x003E0763
		public static IGmCommand_UnionUnion FromIGoToNode(IGoToNodeT _igotonode)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IGoToNode,
				Value = _igotonode
			};
		}

		// Token: 0x0601B52D RID: 111917 RVA: 0x003E2579 File Offset: 0x003E0779
		public ICustomTextGmT AsICustomTextGm()
		{
			return this.As<ICustomTextGmT>();
		}

		// Token: 0x0601B52E RID: 111918 RVA: 0x003E2581 File Offset: 0x003E0781
		public static IGmCommand_UnionUnion FromICustomTextGm(ICustomTextGmT _icustomtextgm)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.ICustomTextGm,
				Value = _icustomtextgm
			};
		}

		// Token: 0x0601B52F RID: 111919 RVA: 0x003E2597 File Offset: 0x003E0797
		public IStartCombatOperationCaptureT AsIStartCombatOperationCapture()
		{
			return this.As<IStartCombatOperationCaptureT>();
		}

		// Token: 0x0601B530 RID: 111920 RVA: 0x003E259F File Offset: 0x003E079F
		public static IGmCommand_UnionUnion FromIStartCombatOperationCapture(IStartCombatOperationCaptureT _istartcombatoperationcapture)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IStartCombatOperationCapture,
				Value = _istartcombatoperationcapture
			};
		}

		// Token: 0x0601B531 RID: 111921 RVA: 0x003E25B5 File Offset: 0x003E07B5
		public IStopCombatOperationCaptureT AsIStopCombatOperationCapture()
		{
			return this.As<IStopCombatOperationCaptureT>();
		}

		// Token: 0x0601B532 RID: 111922 RVA: 0x003E25BD File Offset: 0x003E07BD
		public static IGmCommand_UnionUnion FromIStopCombatOperationCapture(IStopCombatOperationCaptureT _istopcombatoperationcapture)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IStopCombatOperationCapture,
				Value = _istopcombatoperationcapture
			};
		}

		// Token: 0x0601B533 RID: 111923 RVA: 0x003E25D3 File Offset: 0x003E07D3
		public IRecordCombatOperationCaptureCheckpointT AsIRecordCombatOperationCaptureCheckpoint()
		{
			return this.As<IRecordCombatOperationCaptureCheckpointT>();
		}

		// Token: 0x0601B534 RID: 111924 RVA: 0x003E25DB File Offset: 0x003E07DB
		public static IGmCommand_UnionUnion FromIRecordCombatOperationCaptureCheckpoint(IRecordCombatOperationCaptureCheckpointT _irecordcombatoperationcapturecheckpoint)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IRecordCombatOperationCaptureCheckpoint,
				Value = _irecordcombatoperationcapturecheckpoint
			};
		}

		// Token: 0x0601B535 RID: 111925 RVA: 0x003E25F1 File Offset: 0x003E07F1
		public IStartCombatOperationReplayT AsIStartCombatOperationReplay()
		{
			return this.As<IStartCombatOperationReplayT>();
		}

		// Token: 0x0601B536 RID: 111926 RVA: 0x003E25F9 File Offset: 0x003E07F9
		public static IGmCommand_UnionUnion FromIStartCombatOperationReplay(IStartCombatOperationReplayT _istartcombatoperationreplay)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IStartCombatOperationReplay,
				Value = _istartcombatoperationreplay
			};
		}

		// Token: 0x0601B537 RID: 111927 RVA: 0x003E260F File Offset: 0x003E080F
		public IStopCombatOperationReplayT AsIStopCombatOperationReplay()
		{
			return this.As<IStopCombatOperationReplayT>();
		}

		// Token: 0x0601B538 RID: 111928 RVA: 0x003E2617 File Offset: 0x003E0817
		public static IGmCommand_UnionUnion FromIStopCombatOperationReplay(IStopCombatOperationReplayT _istopcombatoperationreplay)
		{
			return new IGmCommand_UnionUnion
			{
				Type = IGmCommand_Union.IStopCombatOperationReplay,
				Value = _istopcombatoperationreplay
			};
		}

		// Token: 0x0601B539 RID: 111929 RVA: 0x003E2630 File Offset: 0x003E0830
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

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046D9 RID: 18137
	public class TGmCommandUnion
	{
		// Token: 0x170080D9 RID: 32985
		// (get) Token: 0x0601B939 RID: 112953 RVA: 0x003E9491 File Offset: 0x003E7691
		// (set) Token: 0x0601B93A RID: 112954 RVA: 0x003E9499 File Offset: 0x003E7699
		public TGmCommand Type { get; set; }

		// Token: 0x170080DA RID: 32986
		// (get) Token: 0x0601B93B RID: 112955 RVA: 0x003E94A2 File Offset: 0x003E76A2
		// (set) Token: 0x0601B93C RID: 112956 RVA: 0x003E94AA File Offset: 0x003E76AA
		public object Value { get; set; }

		// Token: 0x0601B93D RID: 112957 RVA: 0x003E94B3 File Offset: 0x003E76B3
		public TGmCommandUnion()
		{
			this.Type = TGmCommand.NONE;
			this.Value = null;
		}

		// Token: 0x0601B93E RID: 112958 RVA: 0x003E94C9 File Offset: 0x003E76C9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B93F RID: 112959 RVA: 0x003E94DB File Offset: 0x003E76DB
		public IAcceptQuestT AsIAcceptQuest()
		{
			return this.As<IAcceptQuestT>();
		}

		// Token: 0x0601B940 RID: 112960 RVA: 0x003E94E3 File Offset: 0x003E76E3
		public static TGmCommandUnion FromIAcceptQuest(IAcceptQuestT _iacceptquest)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IAcceptQuest,
				Value = _iacceptquest
			};
		}

		// Token: 0x0601B941 RID: 112961 RVA: 0x003E94F8 File Offset: 0x003E76F8
		public IActivateTeleportT AsIActivateTeleport()
		{
			return this.As<IActivateTeleportT>();
		}

		// Token: 0x0601B942 RID: 112962 RVA: 0x003E9500 File Offset: 0x003E7700
		public static TGmCommandUnion FromIActivateTeleport(IActivateTeleportT _iactivateteleport)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IActivateTeleport,
				Value = _iactivateteleport
			};
		}

		// Token: 0x0601B943 RID: 112963 RVA: 0x003E9515 File Offset: 0x003E7715
		public IAddAllItemT AsIAddAllItem()
		{
			return this.As<IAddAllItemT>();
		}

		// Token: 0x0601B944 RID: 112964 RVA: 0x003E951D File Offset: 0x003E771D
		public static TGmCommandUnion FromIAddAllItem(IAddAllItemT _iaddallitem)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IAddAllItem,
				Value = _iaddallitem
			};
		}

		// Token: 0x0601B945 RID: 112965 RVA: 0x003E9532 File Offset: 0x003E7732
		public IAddAllPhantomT AsIAddAllPhantom()
		{
			return this.As<IAddAllPhantomT>();
		}

		// Token: 0x0601B946 RID: 112966 RVA: 0x003E953A File Offset: 0x003E773A
		public static TGmCommandUnion FromIAddAllPhantom(IAddAllPhantomT _iaddallphantom)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IAddAllPhantom,
				Value = _iaddallphantom
			};
		}

		// Token: 0x0601B947 RID: 112967 RVA: 0x003E954F File Offset: 0x003E774F
		public IAddAllRoleT AsIAddAllRole()
		{
			return this.As<IAddAllRoleT>();
		}

		// Token: 0x0601B948 RID: 112968 RVA: 0x003E9557 File Offset: 0x003E7757
		public static TGmCommandUnion FromIAddAllRole(IAddAllRoleT _iaddallrole)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IAddAllRole,
				Value = _iaddallrole
			};
		}

		// Token: 0x0601B949 RID: 112969 RVA: 0x003E956C File Offset: 0x003E776C
		public IAddItemT AsIAddItem()
		{
			return this.As<IAddItemT>();
		}

		// Token: 0x0601B94A RID: 112970 RVA: 0x003E9574 File Offset: 0x003E7774
		public static TGmCommandUnion FromIAddItem(IAddItemT _iadditem)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IAddItem,
				Value = _iadditem
			};
		}

		// Token: 0x0601B94B RID: 112971 RVA: 0x003E9589 File Offset: 0x003E7789
		public IAddNewRoleT AsIAddNewRole()
		{
			return this.As<IAddNewRoleT>();
		}

		// Token: 0x0601B94C RID: 112972 RVA: 0x003E9591 File Offset: 0x003E7791
		public static TGmCommandUnion FromIAddNewRole(IAddNewRoleT _iaddnewrole)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IAddNewRole,
				Value = _iaddnewrole
			};
		}

		// Token: 0x0601B94D RID: 112973 RVA: 0x003E95A6 File Offset: 0x003E77A6
		public IBrokenRockHotFixT AsIBrokenRockHotFix()
		{
			return this.As<IBrokenRockHotFixT>();
		}

		// Token: 0x0601B94E RID: 112974 RVA: 0x003E95AE File Offset: 0x003E77AE
		public static TGmCommandUnion FromIBrokenRockHotFix(IBrokenRockHotFixT _ibrokenrockhotfix)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IBrokenRockHotFix,
				Value = _ibrokenrockhotfix
			};
		}

		// Token: 0x0601B94F RID: 112975 RVA: 0x003E95C3 File Offset: 0x003E77C3
		public ICustomTextGmT AsICustomTextGm()
		{
			return this.As<ICustomTextGmT>();
		}

		// Token: 0x0601B950 RID: 112976 RVA: 0x003E95CB File Offset: 0x003E77CB
		public static TGmCommandUnion FromICustomTextGm(ICustomTextGmT _icustomtextgm)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ICustomTextGm,
				Value = _icustomtextgm
			};
		}

		// Token: 0x0601B951 RID: 112977 RVA: 0x003E95E1 File Offset: 0x003E77E1
		public IEquipGraduatedWeaponToTeamT AsIEquipGraduatedWeaponToTeam()
		{
			return this.As<IEquipGraduatedWeaponToTeamT>();
		}

		// Token: 0x0601B952 RID: 112978 RVA: 0x003E95E9 File Offset: 0x003E77E9
		public static TGmCommandUnion FromIEquipGraduatedWeaponToTeam(IEquipGraduatedWeaponToTeamT _iequipgraduatedweapontoteam)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IEquipGraduatedWeaponToTeam,
				Value = _iequipgraduatedweapontoteam
			};
		}

		// Token: 0x0601B953 RID: 112979 RVA: 0x003E95FF File Offset: 0x003E77FF
		public IExecuteActionListT AsIExecuteActionList()
		{
			return this.As<IExecuteActionListT>();
		}

		// Token: 0x0601B954 RID: 112980 RVA: 0x003E9607 File Offset: 0x003E7807
		public static TGmCommandUnion FromIExecuteActionList(IExecuteActionListT _iexecuteactionlist)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IExecuteActionList,
				Value = _iexecuteactionlist
			};
		}

		// Token: 0x0601B955 RID: 112981 RVA: 0x003E961D File Offset: 0x003E781D
		public IExitDungeonInGmT AsIExitDungeonInGm()
		{
			return this.As<IExitDungeonInGmT>();
		}

		// Token: 0x0601B956 RID: 112982 RVA: 0x003E9625 File Offset: 0x003E7825
		public static TGmCommandUnion FromIExitDungeonInGm(IExitDungeonInGmT _iexitdungeoningm)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IExitDungeonInGm,
				Value = _iexitdungeoningm
			};
		}

		// Token: 0x0601B957 RID: 112983 RVA: 0x003E963B File Offset: 0x003E783B
		public IFinishCurrentLevelPlayNodeT AsIFinishCurrentLevelPlayNode()
		{
			return this.As<IFinishCurrentLevelPlayNodeT>();
		}

		// Token: 0x0601B958 RID: 112984 RVA: 0x003E9643 File Offset: 0x003E7843
		public static TGmCommandUnion FromIFinishCurrentLevelPlayNode(IFinishCurrentLevelPlayNodeT _ifinishcurrentlevelplaynode)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IFinishCurrentLevelPlayNode,
				Value = _ifinishcurrentlevelplaynode
			};
		}

		// Token: 0x0601B959 RID: 112985 RVA: 0x003E9659 File Offset: 0x003E7859
		public IFinishCurrentTrackQuestNodeT AsIFinishCurrentTrackQuestNode()
		{
			return this.As<IFinishCurrentTrackQuestNodeT>();
		}

		// Token: 0x0601B95A RID: 112986 RVA: 0x003E9661 File Offset: 0x003E7861
		public static TGmCommandUnion FromIFinishCurrentTrackQuestNode(IFinishCurrentTrackQuestNodeT _ifinishcurrenttrackquestnode)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IFinishCurrentTrackQuestNode,
				Value = _ifinishcurrenttrackquestnode
			};
		}

		// Token: 0x0601B95B RID: 112987 RVA: 0x003E9677 File Offset: 0x003E7877
		public IFinishCurTrackDungeonNodeT AsIFinishCurTrackDungeonNode()
		{
			return this.As<IFinishCurTrackDungeonNodeT>();
		}

		// Token: 0x0601B95C RID: 112988 RVA: 0x003E967F File Offset: 0x003E787F
		public static TGmCommandUnion FromIFinishCurTrackDungeonNode(IFinishCurTrackDungeonNodeT _ifinishcurtrackdungeonnode)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IFinishCurTrackDungeonNode,
				Value = _ifinishcurtrackdungeonnode
			};
		}

		// Token: 0x0601B95D RID: 112989 RVA: 0x003E9695 File Offset: 0x003E7895
		public IGetAllGraduatedPhantomT AsIGetAllGraduatedPhantom()
		{
			return this.As<IGetAllGraduatedPhantomT>();
		}

		// Token: 0x0601B95E RID: 112990 RVA: 0x003E969D File Offset: 0x003E789D
		public static TGmCommandUnion FromIGetAllGraduatedPhantom(IGetAllGraduatedPhantomT _igetallgraduatedphantom)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IGetAllGraduatedPhantom,
				Value = _igetallgraduatedphantom
			};
		}

		// Token: 0x0601B95F RID: 112991 RVA: 0x003E96B3 File Offset: 0x003E78B3
		public IGetAllGraduatedWeaponT AsIGetAllGraduatedWeapon()
		{
			return this.As<IGetAllGraduatedWeaponT>();
		}

		// Token: 0x0601B960 RID: 112992 RVA: 0x003E96BB File Offset: 0x003E78BB
		public static TGmCommandUnion FromIGetAllGraduatedWeapon(IGetAllGraduatedWeaponT _igetallgraduatedweapon)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IGetAllGraduatedWeapon,
				Value = _igetallgraduatedweapon
			};
		}

		// Token: 0x0601B961 RID: 112993 RVA: 0x003E96D1 File Offset: 0x003E78D1
		public IGmGotoRogueRoomInGmT AsIGmGotoRogueRoomInGm()
		{
			return this.As<IGmGotoRogueRoomInGmT>();
		}

		// Token: 0x0601B962 RID: 112994 RVA: 0x003E96D9 File Offset: 0x003E78D9
		public static TGmCommandUnion FromIGmGotoRogueRoomInGm(IGmGotoRogueRoomInGmT _igmgotorogueroomingm)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IGmGotoRogueRoomInGm,
				Value = _igmgotorogueroomingm
			};
		}

		// Token: 0x0601B963 RID: 112995 RVA: 0x003E96EF File Offset: 0x003E78EF
		public IGmRoguelikeStartInGmT AsIGmRoguelikeStartInGm()
		{
			return this.As<IGmRoguelikeStartInGmT>();
		}

		// Token: 0x0601B964 RID: 112996 RVA: 0x003E96F7 File Offset: 0x003E78F7
		public static TGmCommandUnion FromIGmRoguelikeStartInGm(IGmRoguelikeStartInGmT _igmroguelikestartingm)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IGmRoguelikeStartInGm,
				Value = _igmroguelikestartingm
			};
		}

		// Token: 0x0601B965 RID: 112997 RVA: 0x003E970D File Offset: 0x003E790D
		public IGmSetLevelPlaySwitchForceT AsIGmSetLevelPlaySwitchForce()
		{
			return this.As<IGmSetLevelPlaySwitchForceT>();
		}

		// Token: 0x0601B966 RID: 112998 RVA: 0x003E9715 File Offset: 0x003E7915
		public static TGmCommandUnion FromIGmSetLevelPlaySwitchForce(IGmSetLevelPlaySwitchForceT _igmsetlevelplayswitchforce)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IGmSetLevelPlaySwitchForce,
				Value = _igmsetlevelplayswitchforce
			};
		}

		// Token: 0x0601B967 RID: 112999 RVA: 0x003E972B File Offset: 0x003E792B
		public IGmSetLevelPlayUpdateForceT AsIGmSetLevelPlayUpdateForce()
		{
			return this.As<IGmSetLevelPlayUpdateForceT>();
		}

		// Token: 0x0601B968 RID: 113000 RVA: 0x003E9733 File Offset: 0x003E7933
		public static TGmCommandUnion FromIGmSetLevelPlayUpdateForce(IGmSetLevelPlayUpdateForceT _igmsetlevelplayupdateforce)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IGmSetLevelPlayUpdateForce,
				Value = _igmsetlevelplayupdateforce
			};
		}

		// Token: 0x0601B969 RID: 113001 RVA: 0x003E9749 File Offset: 0x003E7949
		public IGmTeleportToEntityT AsIGmTeleportToEntity()
		{
			return this.As<IGmTeleportToEntityT>();
		}

		// Token: 0x0601B96A RID: 113002 RVA: 0x003E9751 File Offset: 0x003E7951
		public static TGmCommandUnion FromIGmTeleportToEntity(IGmTeleportToEntityT _igmteleporttoentity)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IGmTeleportToEntity,
				Value = _igmteleporttoentity
			};
		}

		// Token: 0x0601B96B RID: 113003 RVA: 0x003E9767 File Offset: 0x003E7967
		public IGoToNodeT AsIGoToNode()
		{
			return this.As<IGoToNodeT>();
		}

		// Token: 0x0601B96C RID: 113004 RVA: 0x003E976F File Offset: 0x003E796F
		public static TGmCommandUnion FromIGoToNode(IGoToNodeT _igotonode)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IGoToNode,
				Value = _igotonode
			};
		}

		// Token: 0x0601B96D RID: 113005 RVA: 0x003E9785 File Offset: 0x003E7985
		public IOpenBackLoginViewT AsIOpenBackLoginView()
		{
			return this.As<IOpenBackLoginViewT>();
		}

		// Token: 0x0601B96E RID: 113006 RVA: 0x003E978D File Offset: 0x003E798D
		public static TGmCommandUnion FromIOpenBackLoginView(IOpenBackLoginViewT _iopenbackloginview)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IOpenBackLoginView,
				Value = _iopenbackloginview
			};
		}

		// Token: 0x0601B96F RID: 113007 RVA: 0x003E97A3 File Offset: 0x003E79A3
		public IOpenDungeonEntranceT AsIOpenDungeonEntrance()
		{
			return this.As<IOpenDungeonEntranceT>();
		}

		// Token: 0x0601B970 RID: 113008 RVA: 0x003E97AB File Offset: 0x003E79AB
		public static TGmCommandUnion FromIOpenDungeonEntrance(IOpenDungeonEntranceT _iopendungeonentrance)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IOpenDungeonEntrance,
				Value = _iopendungeonentrance
			};
		}

		// Token: 0x0601B971 RID: 113009 RVA: 0x003E97C1 File Offset: 0x003E79C1
		public IOpenFuncT AsIOpenFunc()
		{
			return this.As<IOpenFuncT>();
		}

		// Token: 0x0601B972 RID: 113010 RVA: 0x003E97C9 File Offset: 0x003E79C9
		public static TGmCommandUnion FromIOpenFunc(IOpenFuncT _iopenfunc)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IOpenFunc,
				Value = _iopenfunc
			};
		}

		// Token: 0x0601B973 RID: 113011 RVA: 0x003E97DF File Offset: 0x003E79DF
		public IPlayFlowForGmT AsIPlayFlowForGm()
		{
			return this.As<IPlayFlowForGmT>();
		}

		// Token: 0x0601B974 RID: 113012 RVA: 0x003E97E7 File Offset: 0x003E79E7
		public static TGmCommandUnion FromIPlayFlowForGm(IPlayFlowForGmT _iplayflowforgm)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IPlayFlowForGm,
				Value = _iplayflowforgm
			};
		}

		// Token: 0x0601B975 RID: 113013 RVA: 0x003E97FD File Offset: 0x003E79FD
		public IRecordCombatOperationCaptureCheckpointT AsIRecordCombatOperationCaptureCheckpoint()
		{
			return this.As<IRecordCombatOperationCaptureCheckpointT>();
		}

		// Token: 0x0601B976 RID: 113014 RVA: 0x003E9805 File Offset: 0x003E7A05
		public static TGmCommandUnion FromIRecordCombatOperationCaptureCheckpoint(IRecordCombatOperationCaptureCheckpointT _irecordcombatoperationcapturecheckpoint)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IRecordCombatOperationCaptureCheckpoint,
				Value = _irecordcombatoperationcapturecheckpoint
			};
		}

		// Token: 0x0601B977 RID: 113015 RVA: 0x003E981B File Offset: 0x003E7A1B
		public IResetCurrentDungeonT AsIResetCurrentDungeon()
		{
			return this.As<IResetCurrentDungeonT>();
		}

		// Token: 0x0601B978 RID: 113016 RVA: 0x003E9823 File Offset: 0x003E7A23
		public static TGmCommandUnion FromIResetCurrentDungeon(IResetCurrentDungeonT _iresetcurrentdungeon)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IResetCurrentDungeon,
				Value = _iresetcurrentdungeon
			};
		}

		// Token: 0x0601B979 RID: 113017 RVA: 0x003E9839 File Offset: 0x003E7A39
		public ISavePlayerDataT AsISavePlayerData()
		{
			return this.As<ISavePlayerDataT>();
		}

		// Token: 0x0601B97A RID: 113018 RVA: 0x003E9841 File Offset: 0x003E7A41
		public static TGmCommandUnion FromISavePlayerData(ISavePlayerDataT _isaveplayerdata)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ISavePlayerData,
				Value = _isaveplayerdata
			};
		}

		// Token: 0x0601B97B RID: 113019 RVA: 0x003E9857 File Offset: 0x003E7A57
		public ISetAllRoleToGraduateT AsISetAllRoleToGraduate()
		{
			return this.As<ISetAllRoleToGraduateT>();
		}

		// Token: 0x0601B97C RID: 113020 RVA: 0x003E985F File Offset: 0x003E7A5F
		public static TGmCommandUnion FromISetAllRoleToGraduate(ISetAllRoleToGraduateT _isetallroletograduate)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ISetAllRoleToGraduate,
				Value = _isetallroletograduate
			};
		}

		// Token: 0x0601B97D RID: 113021 RVA: 0x003E9875 File Offset: 0x003E7A75
		public ISetEquippedWeaponToGraduateT AsISetEquippedWeaponToGraduate()
		{
			return this.As<ISetEquippedWeaponToGraduateT>();
		}

		// Token: 0x0601B97E RID: 113022 RVA: 0x003E987D File Offset: 0x003E7A7D
		public static TGmCommandUnion FromISetEquippedWeaponToGraduate(ISetEquippedWeaponToGraduateT _isetequippedweapontograduate)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ISetEquippedWeaponToGraduate,
				Value = _isetequippedweapontograduate
			};
		}

		// Token: 0x0601B97F RID: 113023 RVA: 0x003E9893 File Offset: 0x003E7A93
		public ISetTimeT AsISetTime()
		{
			return this.As<ISetTimeT>();
		}

		// Token: 0x0601B980 RID: 113024 RVA: 0x003E989B File Offset: 0x003E7A9B
		public static TGmCommandUnion FromISetTime(ISetTimeT _isettime)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ISetTime,
				Value = _isettime
			};
		}

		// Token: 0x0601B981 RID: 113025 RVA: 0x003E98B1 File Offset: 0x003E7AB1
		public ISetUnopenedAreaPullbackT AsISetUnopenedAreaPullback()
		{
			return this.As<ISetUnopenedAreaPullbackT>();
		}

		// Token: 0x0601B982 RID: 113026 RVA: 0x003E98B9 File Offset: 0x003E7AB9
		public static TGmCommandUnion FromISetUnopenedAreaPullback(ISetUnopenedAreaPullbackT _isetunopenedareapullback)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ISetUnopenedAreaPullback,
				Value = _isetunopenedareapullback
			};
		}

		// Token: 0x0601B983 RID: 113027 RVA: 0x003E98CF File Offset: 0x003E7ACF
		public ISetVarT AsISetVar()
		{
			return this.As<ISetVarT>();
		}

		// Token: 0x0601B984 RID: 113028 RVA: 0x003E98D7 File Offset: 0x003E7AD7
		public static TGmCommandUnion FromISetVar(ISetVarT _isetvar)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ISetVar,
				Value = _isetvar
			};
		}

		// Token: 0x0601B985 RID: 113029 RVA: 0x003E98ED File Offset: 0x003E7AED
		public IShieldGuideT AsIShieldGuide()
		{
			return this.As<IShieldGuideT>();
		}

		// Token: 0x0601B986 RID: 113030 RVA: 0x003E98F5 File Offset: 0x003E7AF5
		public static TGmCommandUnion FromIShieldGuide(IShieldGuideT _ishieldguide)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IShieldGuide,
				Value = _ishieldguide
			};
		}

		// Token: 0x0601B987 RID: 113031 RVA: 0x003E990B File Offset: 0x003E7B0B
		public IShowTipsViewT AsIShowTipsView()
		{
			return this.As<IShowTipsViewT>();
		}

		// Token: 0x0601B988 RID: 113032 RVA: 0x003E9913 File Offset: 0x003E7B13
		public static TGmCommandUnion FromIShowTipsView(IShowTipsViewT _ishowtipsview)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IShowTipsView,
				Value = _ishowtipsview
			};
		}

		// Token: 0x0601B989 RID: 113033 RVA: 0x003E9929 File Offset: 0x003E7B29
		public ISkipToInstanceDungeonNodeT AsISkipToInstanceDungeonNode()
		{
			return this.As<ISkipToInstanceDungeonNodeT>();
		}

		// Token: 0x0601B98A RID: 113034 RVA: 0x003E9931 File Offset: 0x003E7B31
		public static TGmCommandUnion FromISkipToInstanceDungeonNode(ISkipToInstanceDungeonNodeT _iskiptoinstancedungeonnode)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ISkipToInstanceDungeonNode,
				Value = _iskiptoinstancedungeonnode
			};
		}

		// Token: 0x0601B98B RID: 113035 RVA: 0x003E9947 File Offset: 0x003E7B47
		public ISkipToLevelPlayNodeT AsISkipToLevelPlayNode()
		{
			return this.As<ISkipToLevelPlayNodeT>();
		}

		// Token: 0x0601B98C RID: 113036 RVA: 0x003E994F File Offset: 0x003E7B4F
		public static TGmCommandUnion FromISkipToLevelPlayNode(ISkipToLevelPlayNodeT _iskiptolevelplaynode)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ISkipToLevelPlayNode,
				Value = _iskiptolevelplaynode
			};
		}

		// Token: 0x0601B98D RID: 113037 RVA: 0x003E9965 File Offset: 0x003E7B65
		public ISkipToQuestNodeT AsISkipToQuestNode()
		{
			return this.As<ISkipToQuestNodeT>();
		}

		// Token: 0x0601B98E RID: 113038 RVA: 0x003E996D File Offset: 0x003E7B6D
		public static TGmCommandUnion FromISkipToQuestNode(ISkipToQuestNodeT _iskiptoquestnode)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ISkipToQuestNode,
				Value = _iskiptoquestnode
			};
		}

		// Token: 0x0601B98F RID: 113039 RVA: 0x003E9983 File Offset: 0x003E7B83
		public IStartCombatOperationCaptureT AsIStartCombatOperationCapture()
		{
			return this.As<IStartCombatOperationCaptureT>();
		}

		// Token: 0x0601B990 RID: 113040 RVA: 0x003E998B File Offset: 0x003E7B8B
		public static TGmCommandUnion FromIStartCombatOperationCapture(IStartCombatOperationCaptureT _istartcombatoperationcapture)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IStartCombatOperationCapture,
				Value = _istartcombatoperationcapture
			};
		}

		// Token: 0x0601B991 RID: 113041 RVA: 0x003E99A1 File Offset: 0x003E7BA1
		public IStartCombatOperationReplayT AsIStartCombatOperationReplay()
		{
			return this.As<IStartCombatOperationReplayT>();
		}

		// Token: 0x0601B992 RID: 113042 RVA: 0x003E99A9 File Offset: 0x003E7BA9
		public static TGmCommandUnion FromIStartCombatOperationReplay(IStartCombatOperationReplayT _istartcombatoperationreplay)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IStartCombatOperationReplay,
				Value = _istartcombatoperationreplay
			};
		}

		// Token: 0x0601B993 RID: 113043 RVA: 0x003E99BF File Offset: 0x003E7BBF
		public IStopCombatOperationCaptureT AsIStopCombatOperationCapture()
		{
			return this.As<IStopCombatOperationCaptureT>();
		}

		// Token: 0x0601B994 RID: 113044 RVA: 0x003E99C7 File Offset: 0x003E7BC7
		public static TGmCommandUnion FromIStopCombatOperationCapture(IStopCombatOperationCaptureT _istopcombatoperationcapture)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IStopCombatOperationCapture,
				Value = _istopcombatoperationcapture
			};
		}

		// Token: 0x0601B995 RID: 113045 RVA: 0x003E99DD File Offset: 0x003E7BDD
		public IStopCombatOperationReplayT AsIStopCombatOperationReplay()
		{
			return this.As<IStopCombatOperationReplayT>();
		}

		// Token: 0x0601B996 RID: 113046 RVA: 0x003E99E5 File Offset: 0x003E7BE5
		public static TGmCommandUnion FromIStopCombatOperationReplay(IStopCombatOperationReplayT _istopcombatoperationreplay)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IStopCombatOperationReplay,
				Value = _istopcombatoperationreplay
			};
		}

		// Token: 0x0601B997 RID: 113047 RVA: 0x003E99FB File Offset: 0x003E7BFB
		public ITeleportToCurDungeonTrackPositionT AsITeleportToCurDungeonTrackPosition()
		{
			return this.As<ITeleportToCurDungeonTrackPositionT>();
		}

		// Token: 0x0601B998 RID: 113048 RVA: 0x003E9A03 File Offset: 0x003E7C03
		public static TGmCommandUnion FromITeleportToCurDungeonTrackPosition(ITeleportToCurDungeonTrackPositionT _iteleporttocurdungeontrackposition)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ITeleportToCurDungeonTrackPosition,
				Value = _iteleporttocurdungeontrackposition
			};
		}

		// Token: 0x0601B999 RID: 113049 RVA: 0x003E9A19 File Offset: 0x003E7C19
		public ITeleportToCurLevelPlayTrackPositionT AsITeleportToCurLevelPlayTrackPosition()
		{
			return this.As<ITeleportToCurLevelPlayTrackPositionT>();
		}

		// Token: 0x0601B99A RID: 113050 RVA: 0x003E9A21 File Offset: 0x003E7C21
		public static TGmCommandUnion FromITeleportToCurLevelPlayTrackPosition(ITeleportToCurLevelPlayTrackPositionT _iteleporttocurlevelplaytrackposition)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ITeleportToCurLevelPlayTrackPosition,
				Value = _iteleporttocurlevelplaytrackposition
			};
		}

		// Token: 0x0601B99B RID: 113051 RVA: 0x003E9A37 File Offset: 0x003E7C37
		public ITeleportToCurQuestTrackPositionT AsITeleportToCurQuestTrackPosition()
		{
			return this.As<ITeleportToCurQuestTrackPositionT>();
		}

		// Token: 0x0601B99C RID: 113052 RVA: 0x003E9A3F File Offset: 0x003E7C3F
		public static TGmCommandUnion FromITeleportToCurQuestTrackPosition(ITeleportToCurQuestTrackPositionT _iteleporttocurquesttrackposition)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ITeleportToCurQuestTrackPosition,
				Value = _iteleporttocurquesttrackposition
			};
		}

		// Token: 0x0601B99D RID: 113053 RVA: 0x003E9A55 File Offset: 0x003E7C55
		public ITeleportToEntityT AsITeleportToEntity()
		{
			return this.As<ITeleportToEntityT>();
		}

		// Token: 0x0601B99E RID: 113054 RVA: 0x003E9A5D File Offset: 0x003E7C5D
		public static TGmCommandUnion FromITeleportToEntity(ITeleportToEntityT _iteleporttoentity)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ITeleportToEntity,
				Value = _iteleporttoentity
			};
		}

		// Token: 0x0601B99F RID: 113055 RVA: 0x003E9A73 File Offset: 0x003E7C73
		public ITeleportToLevelPlayCenterT AsITeleportToLevelPlayCenter()
		{
			return this.As<ITeleportToLevelPlayCenterT>();
		}

		// Token: 0x0601B9A0 RID: 113056 RVA: 0x003E9A7B File Offset: 0x003E7C7B
		public static TGmCommandUnion FromITeleportToLevelPlayCenter(ITeleportToLevelPlayCenterT _iteleporttolevelplaycenter)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ITeleportToLevelPlayCenter,
				Value = _iteleporttolevelplaycenter
			};
		}

		// Token: 0x0601B9A1 RID: 113057 RVA: 0x003E9A91 File Offset: 0x003E7C91
		public ITeleportToPosT AsITeleportToPos()
		{
			return this.As<ITeleportToPosT>();
		}

		// Token: 0x0601B9A2 RID: 113058 RVA: 0x003E9A99 File Offset: 0x003E7C99
		public static TGmCommandUnion FromITeleportToPos(ITeleportToPosT _iteleporttopos)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ITeleportToPos,
				Value = _iteleporttopos
			};
		}

		// Token: 0x0601B9A3 RID: 113059 RVA: 0x003E9AAF File Offset: 0x003E7CAF
		public ITeleportToPosInWorldT AsITeleportToPosInWorld()
		{
			return this.As<ITeleportToPosInWorldT>();
		}

		// Token: 0x0601B9A4 RID: 113060 RVA: 0x003E9AB7 File Offset: 0x003E7CB7
		public static TGmCommandUnion FromITeleportToPosInWorld(ITeleportToPosInWorldT _iteleporttoposinworld)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ITeleportToPosInWorld,
				Value = _iteleporttoposinworld
			};
		}

		// Token: 0x0601B9A5 RID: 113061 RVA: 0x003E9ACD File Offset: 0x003E7CCD
		public IUnfreezeInstanceLimitT AsIUnfreezeInstanceLimit()
		{
			return this.As<IUnfreezeInstanceLimitT>();
		}

		// Token: 0x0601B9A6 RID: 113062 RVA: 0x003E9AD5 File Offset: 0x003E7CD5
		public static TGmCommandUnion FromIUnfreezeInstanceLimit(IUnfreezeInstanceLimitT _iunfreezeinstancelimit)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IUnfreezeInstanceLimit,
				Value = _iunfreezeinstancelimit
			};
		}

		// Token: 0x0601B9A7 RID: 113063 RVA: 0x003E9AEB File Offset: 0x003E7CEB
		public IUnlockAllExploreSkillT AsIUnlockAllExploreSkill()
		{
			return this.As<IUnlockAllExploreSkillT>();
		}

		// Token: 0x0601B9A8 RID: 113064 RVA: 0x003E9AF3 File Offset: 0x003E7CF3
		public static TGmCommandUnion FromIUnlockAllExploreSkill(IUnlockAllExploreSkillT _iunlockallexploreskill)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IUnlockAllExploreSkill,
				Value = _iunlockallexploreskill
			};
		}

		// Token: 0x0601B9A9 RID: 113065 RVA: 0x003E9B09 File Offset: 0x003E7D09
		public IUnlockEntityForGmT AsIUnlockEntityForGm()
		{
			return this.As<IUnlockEntityForGmT>();
		}

		// Token: 0x0601B9AA RID: 113066 RVA: 0x003E9B11 File Offset: 0x003E7D11
		public static TGmCommandUnion FromIUnlockEntityForGm(IUnlockEntityForGmT _iunlockentityforgm)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IUnlockEntityForGm,
				Value = _iunlockentityforgm
			};
		}

		// Token: 0x0601B9AB RID: 113067 RVA: 0x003E9B27 File Offset: 0x003E7D27
		public IUnlockQuestT AsIUnlockQuest()
		{
			return this.As<IUnlockQuestT>();
		}

		// Token: 0x0601B9AC RID: 113068 RVA: 0x003E9B2F File Offset: 0x003E7D2F
		public static TGmCommandUnion FromIUnlockQuest(IUnlockQuestT _iunlockquest)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IUnlockQuest,
				Value = _iunlockquest
			};
		}

		// Token: 0x0601B9AD RID: 113069 RVA: 0x003E9B45 File Offset: 0x003E7D45
		public IUpdateSceneRolesT AsIUpdateSceneRoles()
		{
			return this.As<IUpdateSceneRolesT>();
		}

		// Token: 0x0601B9AE RID: 113070 RVA: 0x003E9B4D File Offset: 0x003E7D4D
		public static TGmCommandUnion FromIUpdateSceneRoles(IUpdateSceneRolesT _iupdatesceneroles)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IUpdateSceneRoles,
				Value = _iupdatesceneroles
			};
		}

		// Token: 0x0601B9AF RID: 113071 RVA: 0x003E9B64 File Offset: 0x003E7D64
		public static int Pack(FlatBufferBuilder builder, TGmCommandUnion _o)
		{
			switch (_o.Type)
			{
			case TGmCommand.IAcceptQuest:
				return IAcceptQuest.Pack(builder, _o.AsIAcceptQuest()).Value;
			case TGmCommand.IActivateTeleport:
				return IActivateTeleport.Pack(builder, _o.AsIActivateTeleport()).Value;
			case TGmCommand.IAddAllItem:
				return IAddAllItem.Pack(builder, _o.AsIAddAllItem()).Value;
			case TGmCommand.IAddAllPhantom:
				return IAddAllPhantom.Pack(builder, _o.AsIAddAllPhantom()).Value;
			case TGmCommand.IAddAllRole:
				return IAddAllRole.Pack(builder, _o.AsIAddAllRole()).Value;
			case TGmCommand.IAddItem:
				return IAddItem.Pack(builder, _o.AsIAddItem()).Value;
			case TGmCommand.IAddNewRole:
				return IAddNewRole.Pack(builder, _o.AsIAddNewRole()).Value;
			case TGmCommand.IBrokenRockHotFix:
				return IBrokenRockHotFix.Pack(builder, _o.AsIBrokenRockHotFix()).Value;
			case TGmCommand.ICustomTextGm:
				return ICustomTextGm.Pack(builder, _o.AsICustomTextGm()).Value;
			case TGmCommand.IEquipGraduatedWeaponToTeam:
				return IEquipGraduatedWeaponToTeam.Pack(builder, _o.AsIEquipGraduatedWeaponToTeam()).Value;
			case TGmCommand.IExecuteActionList:
				return IExecuteActionList.Pack(builder, _o.AsIExecuteActionList()).Value;
			case TGmCommand.IExitDungeonInGm:
				return IExitDungeonInGm.Pack(builder, _o.AsIExitDungeonInGm()).Value;
			case TGmCommand.IFinishCurrentLevelPlayNode:
				return IFinishCurrentLevelPlayNode.Pack(builder, _o.AsIFinishCurrentLevelPlayNode()).Value;
			case TGmCommand.IFinishCurrentTrackQuestNode:
				return IFinishCurrentTrackQuestNode.Pack(builder, _o.AsIFinishCurrentTrackQuestNode()).Value;
			case TGmCommand.IFinishCurTrackDungeonNode:
				return IFinishCurTrackDungeonNode.Pack(builder, _o.AsIFinishCurTrackDungeonNode()).Value;
			case TGmCommand.IGetAllGraduatedPhantom:
				return IGetAllGraduatedPhantom.Pack(builder, _o.AsIGetAllGraduatedPhantom()).Value;
			case TGmCommand.IGetAllGraduatedWeapon:
				return IGetAllGraduatedWeapon.Pack(builder, _o.AsIGetAllGraduatedWeapon()).Value;
			case TGmCommand.IGmGotoRogueRoomInGm:
				return IGmGotoRogueRoomInGm.Pack(builder, _o.AsIGmGotoRogueRoomInGm()).Value;
			case TGmCommand.IGmRoguelikeStartInGm:
				return IGmRoguelikeStartInGm.Pack(builder, _o.AsIGmRoguelikeStartInGm()).Value;
			case TGmCommand.IGmSetLevelPlaySwitchForce:
				return IGmSetLevelPlaySwitchForce.Pack(builder, _o.AsIGmSetLevelPlaySwitchForce()).Value;
			case TGmCommand.IGmSetLevelPlayUpdateForce:
				return IGmSetLevelPlayUpdateForce.Pack(builder, _o.AsIGmSetLevelPlayUpdateForce()).Value;
			case TGmCommand.IGmTeleportToEntity:
				return IGmTeleportToEntity.Pack(builder, _o.AsIGmTeleportToEntity()).Value;
			case TGmCommand.IGoToNode:
				return IGoToNode.Pack(builder, _o.AsIGoToNode()).Value;
			case TGmCommand.IOpenBackLoginView:
				return IOpenBackLoginView.Pack(builder, _o.AsIOpenBackLoginView()).Value;
			case TGmCommand.IOpenDungeonEntrance:
				return IOpenDungeonEntrance.Pack(builder, _o.AsIOpenDungeonEntrance()).Value;
			case TGmCommand.IOpenFunc:
				return IOpenFunc.Pack(builder, _o.AsIOpenFunc()).Value;
			case TGmCommand.IPlayFlowForGm:
				return IPlayFlowForGm.Pack(builder, _o.AsIPlayFlowForGm()).Value;
			case TGmCommand.IRecordCombatOperationCaptureCheckpoint:
				return IRecordCombatOperationCaptureCheckpoint.Pack(builder, _o.AsIRecordCombatOperationCaptureCheckpoint()).Value;
			case TGmCommand.IResetCurrentDungeon:
				return IResetCurrentDungeon.Pack(builder, _o.AsIResetCurrentDungeon()).Value;
			case TGmCommand.ISavePlayerData:
				return ISavePlayerData.Pack(builder, _o.AsISavePlayerData()).Value;
			case TGmCommand.ISetAllRoleToGraduate:
				return ISetAllRoleToGraduate.Pack(builder, _o.AsISetAllRoleToGraduate()).Value;
			case TGmCommand.ISetEquippedWeaponToGraduate:
				return ISetEquippedWeaponToGraduate.Pack(builder, _o.AsISetEquippedWeaponToGraduate()).Value;
			case TGmCommand.ISetTime:
				return ISetTime.Pack(builder, _o.AsISetTime()).Value;
			case TGmCommand.ISetUnopenedAreaPullback:
				return ISetUnopenedAreaPullback.Pack(builder, _o.AsISetUnopenedAreaPullback()).Value;
			case TGmCommand.ISetVar:
				return ISetVar.Pack(builder, _o.AsISetVar()).Value;
			case TGmCommand.IShieldGuide:
				return IShieldGuide.Pack(builder, _o.AsIShieldGuide()).Value;
			case TGmCommand.IShowTipsView:
				return IShowTipsView.Pack(builder, _o.AsIShowTipsView()).Value;
			case TGmCommand.ISkipToInstanceDungeonNode:
				return ISkipToInstanceDungeonNode.Pack(builder, _o.AsISkipToInstanceDungeonNode()).Value;
			case TGmCommand.ISkipToLevelPlayNode:
				return ISkipToLevelPlayNode.Pack(builder, _o.AsISkipToLevelPlayNode()).Value;
			case TGmCommand.ISkipToQuestNode:
				return ISkipToQuestNode.Pack(builder, _o.AsISkipToQuestNode()).Value;
			case TGmCommand.IStartCombatOperationCapture:
				return IStartCombatOperationCapture.Pack(builder, _o.AsIStartCombatOperationCapture()).Value;
			case TGmCommand.IStartCombatOperationReplay:
				return IStartCombatOperationReplay.Pack(builder, _o.AsIStartCombatOperationReplay()).Value;
			case TGmCommand.IStopCombatOperationCapture:
				return IStopCombatOperationCapture.Pack(builder, _o.AsIStopCombatOperationCapture()).Value;
			case TGmCommand.IStopCombatOperationReplay:
				return IStopCombatOperationReplay.Pack(builder, _o.AsIStopCombatOperationReplay()).Value;
			case TGmCommand.ITeleportToCurDungeonTrackPosition:
				return ITeleportToCurDungeonTrackPosition.Pack(builder, _o.AsITeleportToCurDungeonTrackPosition()).Value;
			case TGmCommand.ITeleportToCurLevelPlayTrackPosition:
				return ITeleportToCurLevelPlayTrackPosition.Pack(builder, _o.AsITeleportToCurLevelPlayTrackPosition()).Value;
			case TGmCommand.ITeleportToCurQuestTrackPosition:
				return ITeleportToCurQuestTrackPosition.Pack(builder, _o.AsITeleportToCurQuestTrackPosition()).Value;
			case TGmCommand.ITeleportToEntity:
				return ITeleportToEntity.Pack(builder, _o.AsITeleportToEntity()).Value;
			case TGmCommand.ITeleportToLevelPlayCenter:
				return ITeleportToLevelPlayCenter.Pack(builder, _o.AsITeleportToLevelPlayCenter()).Value;
			case TGmCommand.ITeleportToPos:
				return ITeleportToPos.Pack(builder, _o.AsITeleportToPos()).Value;
			case TGmCommand.ITeleportToPosInWorld:
				return ITeleportToPosInWorld.Pack(builder, _o.AsITeleportToPosInWorld()).Value;
			case TGmCommand.IUnfreezeInstanceLimit:
				return IUnfreezeInstanceLimit.Pack(builder, _o.AsIUnfreezeInstanceLimit()).Value;
			case TGmCommand.IUnlockAllExploreSkill:
				return IUnlockAllExploreSkill.Pack(builder, _o.AsIUnlockAllExploreSkill()).Value;
			case TGmCommand.IUnlockEntityForGm:
				return IUnlockEntityForGm.Pack(builder, _o.AsIUnlockEntityForGm()).Value;
			case TGmCommand.IUnlockQuest:
				return IUnlockQuest.Pack(builder, _o.AsIUnlockQuest()).Value;
			case TGmCommand.IUpdateSceneRoles:
				return IUpdateSceneRoles.Pack(builder, _o.AsIUpdateSceneRoles()).Value;
			default:
				return 0;
			}
		}
	}
}

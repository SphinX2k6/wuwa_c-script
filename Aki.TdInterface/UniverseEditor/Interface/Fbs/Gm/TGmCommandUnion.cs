using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B41 RID: 19265
	public class TGmCommandUnion
	{
		// Token: 0x1700871A RID: 34586
		// (get) Token: 0x0601D10E RID: 119054 RVA: 0x0041572D File Offset: 0x0041392D
		// (set) Token: 0x0601D10F RID: 119055 RVA: 0x00415735 File Offset: 0x00413935
		public TGmCommand Type { get; set; }

		// Token: 0x1700871B RID: 34587
		// (get) Token: 0x0601D110 RID: 119056 RVA: 0x0041573E File Offset: 0x0041393E
		// (set) Token: 0x0601D111 RID: 119057 RVA: 0x00415746 File Offset: 0x00413946
		public object Value { get; set; }

		// Token: 0x0601D112 RID: 119058 RVA: 0x0041574F File Offset: 0x0041394F
		public TGmCommandUnion()
		{
			this.Type = TGmCommand.NONE;
			this.Value = null;
		}

		// Token: 0x0601D113 RID: 119059 RVA: 0x00415765 File Offset: 0x00413965
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601D114 RID: 119060 RVA: 0x00415777 File Offset: 0x00413977
		public IAcceptQuestT AsIAcceptQuest()
		{
			return this.As<IAcceptQuestT>();
		}

		// Token: 0x0601D115 RID: 119061 RVA: 0x0041577F File Offset: 0x0041397F
		public static TGmCommandUnion FromIAcceptQuest(IAcceptQuestT _iacceptquest)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IAcceptQuest,
				Value = _iacceptquest
			};
		}

		// Token: 0x0601D116 RID: 119062 RVA: 0x00415794 File Offset: 0x00413994
		public IActivateTeleportT AsIActivateTeleport()
		{
			return this.As<IActivateTeleportT>();
		}

		// Token: 0x0601D117 RID: 119063 RVA: 0x0041579C File Offset: 0x0041399C
		public static TGmCommandUnion FromIActivateTeleport(IActivateTeleportT _iactivateteleport)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IActivateTeleport,
				Value = _iactivateteleport
			};
		}

		// Token: 0x0601D118 RID: 119064 RVA: 0x004157B1 File Offset: 0x004139B1
		public IAddAllItemT AsIAddAllItem()
		{
			return this.As<IAddAllItemT>();
		}

		// Token: 0x0601D119 RID: 119065 RVA: 0x004157B9 File Offset: 0x004139B9
		public static TGmCommandUnion FromIAddAllItem(IAddAllItemT _iaddallitem)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IAddAllItem,
				Value = _iaddallitem
			};
		}

		// Token: 0x0601D11A RID: 119066 RVA: 0x004157CE File Offset: 0x004139CE
		public IAddAllPhantomT AsIAddAllPhantom()
		{
			return this.As<IAddAllPhantomT>();
		}

		// Token: 0x0601D11B RID: 119067 RVA: 0x004157D6 File Offset: 0x004139D6
		public static TGmCommandUnion FromIAddAllPhantom(IAddAllPhantomT _iaddallphantom)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IAddAllPhantom,
				Value = _iaddallphantom
			};
		}

		// Token: 0x0601D11C RID: 119068 RVA: 0x004157EB File Offset: 0x004139EB
		public IAddAllRoleT AsIAddAllRole()
		{
			return this.As<IAddAllRoleT>();
		}

		// Token: 0x0601D11D RID: 119069 RVA: 0x004157F3 File Offset: 0x004139F3
		public static TGmCommandUnion FromIAddAllRole(IAddAllRoleT _iaddallrole)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IAddAllRole,
				Value = _iaddallrole
			};
		}

		// Token: 0x0601D11E RID: 119070 RVA: 0x00415808 File Offset: 0x00413A08
		public IAddItemT AsIAddItem()
		{
			return this.As<IAddItemT>();
		}

		// Token: 0x0601D11F RID: 119071 RVA: 0x00415810 File Offset: 0x00413A10
		public static TGmCommandUnion FromIAddItem(IAddItemT _iadditem)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IAddItem,
				Value = _iadditem
			};
		}

		// Token: 0x0601D120 RID: 119072 RVA: 0x00415825 File Offset: 0x00413A25
		public IAddNewRoleT AsIAddNewRole()
		{
			return this.As<IAddNewRoleT>();
		}

		// Token: 0x0601D121 RID: 119073 RVA: 0x0041582D File Offset: 0x00413A2D
		public static TGmCommandUnion FromIAddNewRole(IAddNewRoleT _iaddnewrole)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IAddNewRole,
				Value = _iaddnewrole
			};
		}

		// Token: 0x0601D122 RID: 119074 RVA: 0x00415842 File Offset: 0x00413A42
		public IBrokenRockHotFixT AsIBrokenRockHotFix()
		{
			return this.As<IBrokenRockHotFixT>();
		}

		// Token: 0x0601D123 RID: 119075 RVA: 0x0041584A File Offset: 0x00413A4A
		public static TGmCommandUnion FromIBrokenRockHotFix(IBrokenRockHotFixT _ibrokenrockhotfix)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IBrokenRockHotFix,
				Value = _ibrokenrockhotfix
			};
		}

		// Token: 0x0601D124 RID: 119076 RVA: 0x0041585F File Offset: 0x00413A5F
		public ICustomTextGmT AsICustomTextGm()
		{
			return this.As<ICustomTextGmT>();
		}

		// Token: 0x0601D125 RID: 119077 RVA: 0x00415867 File Offset: 0x00413A67
		public static TGmCommandUnion FromICustomTextGm(ICustomTextGmT _icustomtextgm)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ICustomTextGm,
				Value = _icustomtextgm
			};
		}

		// Token: 0x0601D126 RID: 119078 RVA: 0x0041587D File Offset: 0x00413A7D
		public IEquipGraduatedWeaponToTeamT AsIEquipGraduatedWeaponToTeam()
		{
			return this.As<IEquipGraduatedWeaponToTeamT>();
		}

		// Token: 0x0601D127 RID: 119079 RVA: 0x00415885 File Offset: 0x00413A85
		public static TGmCommandUnion FromIEquipGraduatedWeaponToTeam(IEquipGraduatedWeaponToTeamT _iequipgraduatedweapontoteam)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IEquipGraduatedWeaponToTeam,
				Value = _iequipgraduatedweapontoteam
			};
		}

		// Token: 0x0601D128 RID: 119080 RVA: 0x0041589B File Offset: 0x00413A9B
		public IExecuteActionListT AsIExecuteActionList()
		{
			return this.As<IExecuteActionListT>();
		}

		// Token: 0x0601D129 RID: 119081 RVA: 0x004158A3 File Offset: 0x00413AA3
		public static TGmCommandUnion FromIExecuteActionList(IExecuteActionListT _iexecuteactionlist)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IExecuteActionList,
				Value = _iexecuteactionlist
			};
		}

		// Token: 0x0601D12A RID: 119082 RVA: 0x004158B9 File Offset: 0x00413AB9
		public IExitDungeonInGmT AsIExitDungeonInGm()
		{
			return this.As<IExitDungeonInGmT>();
		}

		// Token: 0x0601D12B RID: 119083 RVA: 0x004158C1 File Offset: 0x00413AC1
		public static TGmCommandUnion FromIExitDungeonInGm(IExitDungeonInGmT _iexitdungeoningm)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IExitDungeonInGm,
				Value = _iexitdungeoningm
			};
		}

		// Token: 0x0601D12C RID: 119084 RVA: 0x004158D7 File Offset: 0x00413AD7
		public IFinishCurrentLevelPlayNodeT AsIFinishCurrentLevelPlayNode()
		{
			return this.As<IFinishCurrentLevelPlayNodeT>();
		}

		// Token: 0x0601D12D RID: 119085 RVA: 0x004158DF File Offset: 0x00413ADF
		public static TGmCommandUnion FromIFinishCurrentLevelPlayNode(IFinishCurrentLevelPlayNodeT _ifinishcurrentlevelplaynode)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IFinishCurrentLevelPlayNode,
				Value = _ifinishcurrentlevelplaynode
			};
		}

		// Token: 0x0601D12E RID: 119086 RVA: 0x004158F5 File Offset: 0x00413AF5
		public IFinishCurrentTrackQuestNodeT AsIFinishCurrentTrackQuestNode()
		{
			return this.As<IFinishCurrentTrackQuestNodeT>();
		}

		// Token: 0x0601D12F RID: 119087 RVA: 0x004158FD File Offset: 0x00413AFD
		public static TGmCommandUnion FromIFinishCurrentTrackQuestNode(IFinishCurrentTrackQuestNodeT _ifinishcurrenttrackquestnode)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IFinishCurrentTrackQuestNode,
				Value = _ifinishcurrenttrackquestnode
			};
		}

		// Token: 0x0601D130 RID: 119088 RVA: 0x00415913 File Offset: 0x00413B13
		public IFinishCurTrackDungeonNodeT AsIFinishCurTrackDungeonNode()
		{
			return this.As<IFinishCurTrackDungeonNodeT>();
		}

		// Token: 0x0601D131 RID: 119089 RVA: 0x0041591B File Offset: 0x00413B1B
		public static TGmCommandUnion FromIFinishCurTrackDungeonNode(IFinishCurTrackDungeonNodeT _ifinishcurtrackdungeonnode)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IFinishCurTrackDungeonNode,
				Value = _ifinishcurtrackdungeonnode
			};
		}

		// Token: 0x0601D132 RID: 119090 RVA: 0x00415931 File Offset: 0x00413B31
		public IGetAllGraduatedPhantomT AsIGetAllGraduatedPhantom()
		{
			return this.As<IGetAllGraduatedPhantomT>();
		}

		// Token: 0x0601D133 RID: 119091 RVA: 0x00415939 File Offset: 0x00413B39
		public static TGmCommandUnion FromIGetAllGraduatedPhantom(IGetAllGraduatedPhantomT _igetallgraduatedphantom)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IGetAllGraduatedPhantom,
				Value = _igetallgraduatedphantom
			};
		}

		// Token: 0x0601D134 RID: 119092 RVA: 0x0041594F File Offset: 0x00413B4F
		public IGetAllGraduatedWeaponT AsIGetAllGraduatedWeapon()
		{
			return this.As<IGetAllGraduatedWeaponT>();
		}

		// Token: 0x0601D135 RID: 119093 RVA: 0x00415957 File Offset: 0x00413B57
		public static TGmCommandUnion FromIGetAllGraduatedWeapon(IGetAllGraduatedWeaponT _igetallgraduatedweapon)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IGetAllGraduatedWeapon,
				Value = _igetallgraduatedweapon
			};
		}

		// Token: 0x0601D136 RID: 119094 RVA: 0x0041596D File Offset: 0x00413B6D
		public IGmGotoRogueRoomInGmT AsIGmGotoRogueRoomInGm()
		{
			return this.As<IGmGotoRogueRoomInGmT>();
		}

		// Token: 0x0601D137 RID: 119095 RVA: 0x00415975 File Offset: 0x00413B75
		public static TGmCommandUnion FromIGmGotoRogueRoomInGm(IGmGotoRogueRoomInGmT _igmgotorogueroomingm)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IGmGotoRogueRoomInGm,
				Value = _igmgotorogueroomingm
			};
		}

		// Token: 0x0601D138 RID: 119096 RVA: 0x0041598B File Offset: 0x00413B8B
		public IGmRoguelikeStartInGmT AsIGmRoguelikeStartInGm()
		{
			return this.As<IGmRoguelikeStartInGmT>();
		}

		// Token: 0x0601D139 RID: 119097 RVA: 0x00415993 File Offset: 0x00413B93
		public static TGmCommandUnion FromIGmRoguelikeStartInGm(IGmRoguelikeStartInGmT _igmroguelikestartingm)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IGmRoguelikeStartInGm,
				Value = _igmroguelikestartingm
			};
		}

		// Token: 0x0601D13A RID: 119098 RVA: 0x004159A9 File Offset: 0x00413BA9
		public IGmSetLevelPlaySwitchForceT AsIGmSetLevelPlaySwitchForce()
		{
			return this.As<IGmSetLevelPlaySwitchForceT>();
		}

		// Token: 0x0601D13B RID: 119099 RVA: 0x004159B1 File Offset: 0x00413BB1
		public static TGmCommandUnion FromIGmSetLevelPlaySwitchForce(IGmSetLevelPlaySwitchForceT _igmsetlevelplayswitchforce)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IGmSetLevelPlaySwitchForce,
				Value = _igmsetlevelplayswitchforce
			};
		}

		// Token: 0x0601D13C RID: 119100 RVA: 0x004159C7 File Offset: 0x00413BC7
		public IGmSetLevelPlayUpdateForceT AsIGmSetLevelPlayUpdateForce()
		{
			return this.As<IGmSetLevelPlayUpdateForceT>();
		}

		// Token: 0x0601D13D RID: 119101 RVA: 0x004159CF File Offset: 0x00413BCF
		public static TGmCommandUnion FromIGmSetLevelPlayUpdateForce(IGmSetLevelPlayUpdateForceT _igmsetlevelplayupdateforce)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IGmSetLevelPlayUpdateForce,
				Value = _igmsetlevelplayupdateforce
			};
		}

		// Token: 0x0601D13E RID: 119102 RVA: 0x004159E5 File Offset: 0x00413BE5
		public IGmTeleportToEntityT AsIGmTeleportToEntity()
		{
			return this.As<IGmTeleportToEntityT>();
		}

		// Token: 0x0601D13F RID: 119103 RVA: 0x004159ED File Offset: 0x00413BED
		public static TGmCommandUnion FromIGmTeleportToEntity(IGmTeleportToEntityT _igmteleporttoentity)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IGmTeleportToEntity,
				Value = _igmteleporttoentity
			};
		}

		// Token: 0x0601D140 RID: 119104 RVA: 0x00415A03 File Offset: 0x00413C03
		public IGoToNodeT AsIGoToNode()
		{
			return this.As<IGoToNodeT>();
		}

		// Token: 0x0601D141 RID: 119105 RVA: 0x00415A0B File Offset: 0x00413C0B
		public static TGmCommandUnion FromIGoToNode(IGoToNodeT _igotonode)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IGoToNode,
				Value = _igotonode
			};
		}

		// Token: 0x0601D142 RID: 119106 RVA: 0x00415A21 File Offset: 0x00413C21
		public IOpenBackLoginViewT AsIOpenBackLoginView()
		{
			return this.As<IOpenBackLoginViewT>();
		}

		// Token: 0x0601D143 RID: 119107 RVA: 0x00415A29 File Offset: 0x00413C29
		public static TGmCommandUnion FromIOpenBackLoginView(IOpenBackLoginViewT _iopenbackloginview)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IOpenBackLoginView,
				Value = _iopenbackloginview
			};
		}

		// Token: 0x0601D144 RID: 119108 RVA: 0x00415A3F File Offset: 0x00413C3F
		public IOpenDungeonEntranceT AsIOpenDungeonEntrance()
		{
			return this.As<IOpenDungeonEntranceT>();
		}

		// Token: 0x0601D145 RID: 119109 RVA: 0x00415A47 File Offset: 0x00413C47
		public static TGmCommandUnion FromIOpenDungeonEntrance(IOpenDungeonEntranceT _iopendungeonentrance)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IOpenDungeonEntrance,
				Value = _iopendungeonentrance
			};
		}

		// Token: 0x0601D146 RID: 119110 RVA: 0x00415A5D File Offset: 0x00413C5D
		public IOpenFuncT AsIOpenFunc()
		{
			return this.As<IOpenFuncT>();
		}

		// Token: 0x0601D147 RID: 119111 RVA: 0x00415A65 File Offset: 0x00413C65
		public static TGmCommandUnion FromIOpenFunc(IOpenFuncT _iopenfunc)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IOpenFunc,
				Value = _iopenfunc
			};
		}

		// Token: 0x0601D148 RID: 119112 RVA: 0x00415A7B File Offset: 0x00413C7B
		public IPlayFlowForGmT AsIPlayFlowForGm()
		{
			return this.As<IPlayFlowForGmT>();
		}

		// Token: 0x0601D149 RID: 119113 RVA: 0x00415A83 File Offset: 0x00413C83
		public static TGmCommandUnion FromIPlayFlowForGm(IPlayFlowForGmT _iplayflowforgm)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IPlayFlowForGm,
				Value = _iplayflowforgm
			};
		}

		// Token: 0x0601D14A RID: 119114 RVA: 0x00415A99 File Offset: 0x00413C99
		public IRecordCombatOperationCaptureCheckpointT AsIRecordCombatOperationCaptureCheckpoint()
		{
			return this.As<IRecordCombatOperationCaptureCheckpointT>();
		}

		// Token: 0x0601D14B RID: 119115 RVA: 0x00415AA1 File Offset: 0x00413CA1
		public static TGmCommandUnion FromIRecordCombatOperationCaptureCheckpoint(IRecordCombatOperationCaptureCheckpointT _irecordcombatoperationcapturecheckpoint)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IRecordCombatOperationCaptureCheckpoint,
				Value = _irecordcombatoperationcapturecheckpoint
			};
		}

		// Token: 0x0601D14C RID: 119116 RVA: 0x00415AB7 File Offset: 0x00413CB7
		public IResetCurrentDungeonT AsIResetCurrentDungeon()
		{
			return this.As<IResetCurrentDungeonT>();
		}

		// Token: 0x0601D14D RID: 119117 RVA: 0x00415ABF File Offset: 0x00413CBF
		public static TGmCommandUnion FromIResetCurrentDungeon(IResetCurrentDungeonT _iresetcurrentdungeon)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IResetCurrentDungeon,
				Value = _iresetcurrentdungeon
			};
		}

		// Token: 0x0601D14E RID: 119118 RVA: 0x00415AD5 File Offset: 0x00413CD5
		public ISavePlayerDataT AsISavePlayerData()
		{
			return this.As<ISavePlayerDataT>();
		}

		// Token: 0x0601D14F RID: 119119 RVA: 0x00415ADD File Offset: 0x00413CDD
		public static TGmCommandUnion FromISavePlayerData(ISavePlayerDataT _isaveplayerdata)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ISavePlayerData,
				Value = _isaveplayerdata
			};
		}

		// Token: 0x0601D150 RID: 119120 RVA: 0x00415AF3 File Offset: 0x00413CF3
		public ISetAllRoleToGraduateT AsISetAllRoleToGraduate()
		{
			return this.As<ISetAllRoleToGraduateT>();
		}

		// Token: 0x0601D151 RID: 119121 RVA: 0x00415AFB File Offset: 0x00413CFB
		public static TGmCommandUnion FromISetAllRoleToGraduate(ISetAllRoleToGraduateT _isetallroletograduate)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ISetAllRoleToGraduate,
				Value = _isetallroletograduate
			};
		}

		// Token: 0x0601D152 RID: 119122 RVA: 0x00415B11 File Offset: 0x00413D11
		public ISetEquippedWeaponToGraduateT AsISetEquippedWeaponToGraduate()
		{
			return this.As<ISetEquippedWeaponToGraduateT>();
		}

		// Token: 0x0601D153 RID: 119123 RVA: 0x00415B19 File Offset: 0x00413D19
		public static TGmCommandUnion FromISetEquippedWeaponToGraduate(ISetEquippedWeaponToGraduateT _isetequippedweapontograduate)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ISetEquippedWeaponToGraduate,
				Value = _isetequippedweapontograduate
			};
		}

		// Token: 0x0601D154 RID: 119124 RVA: 0x00415B2F File Offset: 0x00413D2F
		public ISetTimeT AsISetTime()
		{
			return this.As<ISetTimeT>();
		}

		// Token: 0x0601D155 RID: 119125 RVA: 0x00415B37 File Offset: 0x00413D37
		public static TGmCommandUnion FromISetTime(ISetTimeT _isettime)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ISetTime,
				Value = _isettime
			};
		}

		// Token: 0x0601D156 RID: 119126 RVA: 0x00415B4D File Offset: 0x00413D4D
		public ISetUnopenedAreaPullbackT AsISetUnopenedAreaPullback()
		{
			return this.As<ISetUnopenedAreaPullbackT>();
		}

		// Token: 0x0601D157 RID: 119127 RVA: 0x00415B55 File Offset: 0x00413D55
		public static TGmCommandUnion FromISetUnopenedAreaPullback(ISetUnopenedAreaPullbackT _isetunopenedareapullback)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ISetUnopenedAreaPullback,
				Value = _isetunopenedareapullback
			};
		}

		// Token: 0x0601D158 RID: 119128 RVA: 0x00415B6B File Offset: 0x00413D6B
		public ISetVarT AsISetVar()
		{
			return this.As<ISetVarT>();
		}

		// Token: 0x0601D159 RID: 119129 RVA: 0x00415B73 File Offset: 0x00413D73
		public static TGmCommandUnion FromISetVar(ISetVarT _isetvar)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ISetVar,
				Value = _isetvar
			};
		}

		// Token: 0x0601D15A RID: 119130 RVA: 0x00415B89 File Offset: 0x00413D89
		public IShieldGuideT AsIShieldGuide()
		{
			return this.As<IShieldGuideT>();
		}

		// Token: 0x0601D15B RID: 119131 RVA: 0x00415B91 File Offset: 0x00413D91
		public static TGmCommandUnion FromIShieldGuide(IShieldGuideT _ishieldguide)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IShieldGuide,
				Value = _ishieldguide
			};
		}

		// Token: 0x0601D15C RID: 119132 RVA: 0x00415BA7 File Offset: 0x00413DA7
		public IShowTipsViewT AsIShowTipsView()
		{
			return this.As<IShowTipsViewT>();
		}

		// Token: 0x0601D15D RID: 119133 RVA: 0x00415BAF File Offset: 0x00413DAF
		public static TGmCommandUnion FromIShowTipsView(IShowTipsViewT _ishowtipsview)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IShowTipsView,
				Value = _ishowtipsview
			};
		}

		// Token: 0x0601D15E RID: 119134 RVA: 0x00415BC5 File Offset: 0x00413DC5
		public ISkipToInstanceDungeonNodeT AsISkipToInstanceDungeonNode()
		{
			return this.As<ISkipToInstanceDungeonNodeT>();
		}

		// Token: 0x0601D15F RID: 119135 RVA: 0x00415BCD File Offset: 0x00413DCD
		public static TGmCommandUnion FromISkipToInstanceDungeonNode(ISkipToInstanceDungeonNodeT _iskiptoinstancedungeonnode)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ISkipToInstanceDungeonNode,
				Value = _iskiptoinstancedungeonnode
			};
		}

		// Token: 0x0601D160 RID: 119136 RVA: 0x00415BE3 File Offset: 0x00413DE3
		public ISkipToLevelPlayNodeT AsISkipToLevelPlayNode()
		{
			return this.As<ISkipToLevelPlayNodeT>();
		}

		// Token: 0x0601D161 RID: 119137 RVA: 0x00415BEB File Offset: 0x00413DEB
		public static TGmCommandUnion FromISkipToLevelPlayNode(ISkipToLevelPlayNodeT _iskiptolevelplaynode)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ISkipToLevelPlayNode,
				Value = _iskiptolevelplaynode
			};
		}

		// Token: 0x0601D162 RID: 119138 RVA: 0x00415C01 File Offset: 0x00413E01
		public ISkipToQuestNodeT AsISkipToQuestNode()
		{
			return this.As<ISkipToQuestNodeT>();
		}

		// Token: 0x0601D163 RID: 119139 RVA: 0x00415C09 File Offset: 0x00413E09
		public static TGmCommandUnion FromISkipToQuestNode(ISkipToQuestNodeT _iskiptoquestnode)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ISkipToQuestNode,
				Value = _iskiptoquestnode
			};
		}

		// Token: 0x0601D164 RID: 119140 RVA: 0x00415C1F File Offset: 0x00413E1F
		public IStartCombatOperationCaptureT AsIStartCombatOperationCapture()
		{
			return this.As<IStartCombatOperationCaptureT>();
		}

		// Token: 0x0601D165 RID: 119141 RVA: 0x00415C27 File Offset: 0x00413E27
		public static TGmCommandUnion FromIStartCombatOperationCapture(IStartCombatOperationCaptureT _istartcombatoperationcapture)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IStartCombatOperationCapture,
				Value = _istartcombatoperationcapture
			};
		}

		// Token: 0x0601D166 RID: 119142 RVA: 0x00415C3D File Offset: 0x00413E3D
		public IStartCombatOperationReplayT AsIStartCombatOperationReplay()
		{
			return this.As<IStartCombatOperationReplayT>();
		}

		// Token: 0x0601D167 RID: 119143 RVA: 0x00415C45 File Offset: 0x00413E45
		public static TGmCommandUnion FromIStartCombatOperationReplay(IStartCombatOperationReplayT _istartcombatoperationreplay)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IStartCombatOperationReplay,
				Value = _istartcombatoperationreplay
			};
		}

		// Token: 0x0601D168 RID: 119144 RVA: 0x00415C5B File Offset: 0x00413E5B
		public IStopCombatOperationCaptureT AsIStopCombatOperationCapture()
		{
			return this.As<IStopCombatOperationCaptureT>();
		}

		// Token: 0x0601D169 RID: 119145 RVA: 0x00415C63 File Offset: 0x00413E63
		public static TGmCommandUnion FromIStopCombatOperationCapture(IStopCombatOperationCaptureT _istopcombatoperationcapture)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IStopCombatOperationCapture,
				Value = _istopcombatoperationcapture
			};
		}

		// Token: 0x0601D16A RID: 119146 RVA: 0x00415C79 File Offset: 0x00413E79
		public IStopCombatOperationReplayT AsIStopCombatOperationReplay()
		{
			return this.As<IStopCombatOperationReplayT>();
		}

		// Token: 0x0601D16B RID: 119147 RVA: 0x00415C81 File Offset: 0x00413E81
		public static TGmCommandUnion FromIStopCombatOperationReplay(IStopCombatOperationReplayT _istopcombatoperationreplay)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IStopCombatOperationReplay,
				Value = _istopcombatoperationreplay
			};
		}

		// Token: 0x0601D16C RID: 119148 RVA: 0x00415C97 File Offset: 0x00413E97
		public ITeleportToCurDungeonTrackPositionT AsITeleportToCurDungeonTrackPosition()
		{
			return this.As<ITeleportToCurDungeonTrackPositionT>();
		}

		// Token: 0x0601D16D RID: 119149 RVA: 0x00415C9F File Offset: 0x00413E9F
		public static TGmCommandUnion FromITeleportToCurDungeonTrackPosition(ITeleportToCurDungeonTrackPositionT _iteleporttocurdungeontrackposition)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ITeleportToCurDungeonTrackPosition,
				Value = _iteleporttocurdungeontrackposition
			};
		}

		// Token: 0x0601D16E RID: 119150 RVA: 0x00415CB5 File Offset: 0x00413EB5
		public ITeleportToCurLevelPlayTrackPositionT AsITeleportToCurLevelPlayTrackPosition()
		{
			return this.As<ITeleportToCurLevelPlayTrackPositionT>();
		}

		// Token: 0x0601D16F RID: 119151 RVA: 0x00415CBD File Offset: 0x00413EBD
		public static TGmCommandUnion FromITeleportToCurLevelPlayTrackPosition(ITeleportToCurLevelPlayTrackPositionT _iteleporttocurlevelplaytrackposition)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ITeleportToCurLevelPlayTrackPosition,
				Value = _iteleporttocurlevelplaytrackposition
			};
		}

		// Token: 0x0601D170 RID: 119152 RVA: 0x00415CD3 File Offset: 0x00413ED3
		public ITeleportToCurQuestTrackPositionT AsITeleportToCurQuestTrackPosition()
		{
			return this.As<ITeleportToCurQuestTrackPositionT>();
		}

		// Token: 0x0601D171 RID: 119153 RVA: 0x00415CDB File Offset: 0x00413EDB
		public static TGmCommandUnion FromITeleportToCurQuestTrackPosition(ITeleportToCurQuestTrackPositionT _iteleporttocurquesttrackposition)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ITeleportToCurQuestTrackPosition,
				Value = _iteleporttocurquesttrackposition
			};
		}

		// Token: 0x0601D172 RID: 119154 RVA: 0x00415CF1 File Offset: 0x00413EF1
		public ITeleportToEntityT AsITeleportToEntity()
		{
			return this.As<ITeleportToEntityT>();
		}

		// Token: 0x0601D173 RID: 119155 RVA: 0x00415CF9 File Offset: 0x00413EF9
		public static TGmCommandUnion FromITeleportToEntity(ITeleportToEntityT _iteleporttoentity)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ITeleportToEntity,
				Value = _iteleporttoentity
			};
		}

		// Token: 0x0601D174 RID: 119156 RVA: 0x00415D0F File Offset: 0x00413F0F
		public ITeleportToLevelPlayCenterT AsITeleportToLevelPlayCenter()
		{
			return this.As<ITeleportToLevelPlayCenterT>();
		}

		// Token: 0x0601D175 RID: 119157 RVA: 0x00415D17 File Offset: 0x00413F17
		public static TGmCommandUnion FromITeleportToLevelPlayCenter(ITeleportToLevelPlayCenterT _iteleporttolevelplaycenter)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ITeleportToLevelPlayCenter,
				Value = _iteleporttolevelplaycenter
			};
		}

		// Token: 0x0601D176 RID: 119158 RVA: 0x00415D2D File Offset: 0x00413F2D
		public ITeleportToPosT AsITeleportToPos()
		{
			return this.As<ITeleportToPosT>();
		}

		// Token: 0x0601D177 RID: 119159 RVA: 0x00415D35 File Offset: 0x00413F35
		public static TGmCommandUnion FromITeleportToPos(ITeleportToPosT _iteleporttopos)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ITeleportToPos,
				Value = _iteleporttopos
			};
		}

		// Token: 0x0601D178 RID: 119160 RVA: 0x00415D4B File Offset: 0x00413F4B
		public ITeleportToPosInWorldT AsITeleportToPosInWorld()
		{
			return this.As<ITeleportToPosInWorldT>();
		}

		// Token: 0x0601D179 RID: 119161 RVA: 0x00415D53 File Offset: 0x00413F53
		public static TGmCommandUnion FromITeleportToPosInWorld(ITeleportToPosInWorldT _iteleporttoposinworld)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.ITeleportToPosInWorld,
				Value = _iteleporttoposinworld
			};
		}

		// Token: 0x0601D17A RID: 119162 RVA: 0x00415D69 File Offset: 0x00413F69
		public IUnfreezeInstanceLimitT AsIUnfreezeInstanceLimit()
		{
			return this.As<IUnfreezeInstanceLimitT>();
		}

		// Token: 0x0601D17B RID: 119163 RVA: 0x00415D71 File Offset: 0x00413F71
		public static TGmCommandUnion FromIUnfreezeInstanceLimit(IUnfreezeInstanceLimitT _iunfreezeinstancelimit)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IUnfreezeInstanceLimit,
				Value = _iunfreezeinstancelimit
			};
		}

		// Token: 0x0601D17C RID: 119164 RVA: 0x00415D87 File Offset: 0x00413F87
		public IUnlockAllExploreSkillT AsIUnlockAllExploreSkill()
		{
			return this.As<IUnlockAllExploreSkillT>();
		}

		// Token: 0x0601D17D RID: 119165 RVA: 0x00415D8F File Offset: 0x00413F8F
		public static TGmCommandUnion FromIUnlockAllExploreSkill(IUnlockAllExploreSkillT _iunlockallexploreskill)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IUnlockAllExploreSkill,
				Value = _iunlockallexploreskill
			};
		}

		// Token: 0x0601D17E RID: 119166 RVA: 0x00415DA5 File Offset: 0x00413FA5
		public IUnlockEntityForGmT AsIUnlockEntityForGm()
		{
			return this.As<IUnlockEntityForGmT>();
		}

		// Token: 0x0601D17F RID: 119167 RVA: 0x00415DAD File Offset: 0x00413FAD
		public static TGmCommandUnion FromIUnlockEntityForGm(IUnlockEntityForGmT _iunlockentityforgm)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IUnlockEntityForGm,
				Value = _iunlockentityforgm
			};
		}

		// Token: 0x0601D180 RID: 119168 RVA: 0x00415DC3 File Offset: 0x00413FC3
		public IUnlockQuestT AsIUnlockQuest()
		{
			return this.As<IUnlockQuestT>();
		}

		// Token: 0x0601D181 RID: 119169 RVA: 0x00415DCB File Offset: 0x00413FCB
		public static TGmCommandUnion FromIUnlockQuest(IUnlockQuestT _iunlockquest)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IUnlockQuest,
				Value = _iunlockquest
			};
		}

		// Token: 0x0601D182 RID: 119170 RVA: 0x00415DE1 File Offset: 0x00413FE1
		public IUpdateSceneRolesT AsIUpdateSceneRoles()
		{
			return this.As<IUpdateSceneRolesT>();
		}

		// Token: 0x0601D183 RID: 119171 RVA: 0x00415DE9 File Offset: 0x00413FE9
		public static TGmCommandUnion FromIUpdateSceneRoles(IUpdateSceneRolesT _iupdatesceneroles)
		{
			return new TGmCommandUnion
			{
				Type = TGmCommand.IUpdateSceneRoles,
				Value = _iupdatesceneroles
			};
		}

		// Token: 0x0601D184 RID: 119172 RVA: 0x00415E00 File Offset: 0x00414000
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

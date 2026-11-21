using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CE5 RID: 19685
	public struct ILaunchSettingShowInMainEditor : IFlatbufferObject
	{
		// Token: 0x17008CA6 RID: 36006
		// (get) Token: 0x0601E69F RID: 124575 RVA: 0x00442B44 File Offset: 0x00440D44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E6A0 RID: 124576 RVA: 0x00442B51 File Offset: 0x00440D51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E6A1 RID: 124577 RVA: 0x00442B58 File Offset: 0x00440D58
		public static ILaunchSettingShowInMainEditor GetRootAsILaunchSettingShowInMainEditor(ByteBuffer _bb)
		{
			return ILaunchSettingShowInMainEditor.GetRootAsILaunchSettingShowInMainEditor(_bb, default(ILaunchSettingShowInMainEditor));
		}

		// Token: 0x0601E6A2 RID: 124578 RVA: 0x00442B74 File Offset: 0x00440D74
		public static ILaunchSettingShowInMainEditor GetRootAsILaunchSettingShowInMainEditor(ByteBuffer _bb, ILaunchSettingShowInMainEditor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E6A3 RID: 124579 RVA: 0x00442B91 File Offset: 0x00440D91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E6A4 RID: 124580 RVA: 0x00442BA0 File Offset: 0x00440DA0
		public ILaunchSettingShowInMainEditor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008CA7 RID: 36007
		// (get) Token: 0x0601E6A5 RID: 124581 RVA: 0x00442BB0 File Offset: 0x00440DB0
		public bool DisableAutoStartServer
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CA8 RID: 36008
		// (get) Token: 0x0601E6A6 RID: 124582 RVA: 0x00442BF0 File Offset: 0x00440DF0
		public bool IsNetMode
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CA9 RID: 36009
		// (get) Token: 0x0601E6A7 RID: 124583 RVA: 0x00442C30 File Offset: 0x00440E30
		public bool UseTemp
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CAA RID: 36010
		// (get) Token: 0x0601E6A8 RID: 124584 RVA: 0x00442C70 File Offset: 0x00440E70
		public bool EnableDeltaReload
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CAB RID: 36011
		// (get) Token: 0x0601E6A9 RID: 124585 RVA: 0x00442CB0 File Offset: 0x00440EB0
		public bool ReloadEditorConfig
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CAC RID: 36012
		// (get) Token: 0x0601E6AA RID: 124586 RVA: 0x00442CF0 File Offset: 0x00440EF0
		public bool ReloadConfigTable
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CAD RID: 36013
		// (get) Token: 0x0601E6AB RID: 124587 RVA: 0x00442D30 File Offset: 0x00440F30
		public bool Account
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CAE RID: 36014
		// (get) Token: 0x0601E6AC RID: 124588 RVA: 0x00442D70 File Offset: 0x00440F70
		public bool IsBornAtCamera
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CAF RID: 36015
		// (get) Token: 0x0601E6AD RID: 124589 RVA: 0x00442DB0 File Offset: 0x00440FB0
		public bool IsOpenDebugService
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CB0 RID: 36016
		// (get) Token: 0x0601E6AE RID: 124590 RVA: 0x00442DF0 File Offset: 0x00440FF0
		public bool IsMale
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CB1 RID: 36017
		// (get) Token: 0x0601E6AF RID: 124591 RVA: 0x00442E30 File Offset: 0x00441030
		public bool WaitDebug
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CB2 RID: 36018
		// (get) Token: 0x0601E6B0 RID: 124592 RVA: 0x00442E70 File Offset: 0x00441070
		public bool EnableAllSystemWithoutPopWin
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CB3 RID: 36019
		// (get) Token: 0x0601E6B1 RID: 124593 RVA: 0x00442EB0 File Offset: 0x004410B0
		public bool IsUnlockExplore
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CB4 RID: 36020
		// (get) Token: 0x0601E6B2 RID: 124594 RVA: 0x00442EF0 File Offset: 0x004410F0
		public bool IsUnlockSpecial
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CB5 RID: 36021
		// (get) Token: 0x0601E6B3 RID: 124595 RVA: 0x00442F30 File Offset: 0x00441130
		public bool EnableAllTeleportPoints
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CB6 RID: 36022
		// (get) Token: 0x0601E6B4 RID: 124596 RVA: 0x00442F70 File Offset: 0x00441170
		public bool IsUnlockAllFog
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CB7 RID: 36023
		// (get) Token: 0x0601E6B5 RID: 124597 RVA: 0x00442FB0 File Offset: 0x004411B0
		public bool IsDisableTeleportDungeon
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CB8 RID: 36024
		// (get) Token: 0x0601E6B6 RID: 124598 RVA: 0x00442FF0 File Offset: 0x004411F0
		public bool IsSkipQuests
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CB9 RID: 36025
		// (get) Token: 0x0601E6B7 RID: 124599 RVA: 0x00443030 File Offset: 0x00441230
		public bool LevelSetting
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CBA RID: 36026
		// (get) Token: 0x0601E6B8 RID: 124600 RVA: 0x00443070 File Offset: 0x00441270
		public bool NewLevelSetting
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CBB RID: 36027
		// (get) Token: 0x0601E6B9 RID: 124601 RVA: 0x004430B0 File Offset: 0x004412B0
		public bool DataLayerSetting
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CBC RID: 36028
		// (get) Token: 0x0601E6BA RID: 124602 RVA: 0x004430F0 File Offset: 0x004412F0
		public bool DisableEntitySetting
		{
			get
			{
				int num = this.__p.__offset(46);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CBD RID: 36029
		// (get) Token: 0x0601E6BB RID: 124603 RVA: 0x00443130 File Offset: 0x00441330
		public bool GmPathOnLogin
		{
			get
			{
				int num = this.__p.__offset(48);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CBE RID: 36030
		// (get) Token: 0x0601E6BC RID: 124604 RVA: 0x00443170 File Offset: 0x00441370
		public bool IsUseMobileStreamingParamsInPie
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CBF RID: 36031
		// (get) Token: 0x0601E6BD RID: 124605 RVA: 0x004431B0 File Offset: 0x004413B0
		public bool IsUseHighAoi
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CC0 RID: 36032
		// (get) Token: 0x0601E6BE RID: 124606 RVA: 0x004431F0 File Offset: 0x004413F0
		public bool IsOpenUseWorldPartitionLoadedZone
		{
			get
			{
				int num = this.__p.__offset(54);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CC1 RID: 36033
		// (get) Token: 0x0601E6BF RID: 124607 RVA: 0x00443230 File Offset: 0x00441430
		public bool IsCloseSkinnedMeshAlwaysTick
		{
			get
			{
				int num = this.__p.__offset(56);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CC2 RID: 36034
		// (get) Token: 0x0601E6C0 RID: 124608 RVA: 0x00443270 File Offset: 0x00441470
		public bool IsOpenReloadSpeed
		{
			get
			{
				int num = this.__p.__offset(58);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CC3 RID: 36035
		// (get) Token: 0x0601E6C1 RID: 124609 RVA: 0x004432B0 File Offset: 0x004414B0
		public bool IsStayInSubWp
		{
			get
			{
				int num = this.__p.__offset(60);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CC4 RID: 36036
		// (get) Token: 0x0601E6C2 RID: 124610 RVA: 0x004432F0 File Offset: 0x004414F0
		public bool CustomPlayerName
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008CC5 RID: 36037
		// (get) Token: 0x0601E6C3 RID: 124611 RVA: 0x00443330 File Offset: 0x00441530
		public uint NullMask
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0U;
				}
				return this.__p.bb.GetUint(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E6C4 RID: 124612 RVA: 0x00443370 File Offset: 0x00441570
		public static Offset<ILaunchSettingShowInMainEditor> CreateILaunchSettingShowInMainEditor(FlatBufferBuilder builder, bool DisableAutoStartServer = false, bool IsNetMode = false, bool UseTemp = false, bool EnableDeltaReload = false, bool ReloadEditorConfig = false, bool ReloadConfigTable = false, bool Account = false, bool IsBornAtCamera = false, bool IsOpenDebugService = false, bool IsMale = false, bool WaitDebug = false, bool EnableAllSystemWithoutPopWin = false, bool IsUnlockExplore = false, bool IsUnlockSpecial = false, bool EnableAllTeleportPoints = false, bool IsUnlockAllFog = false, bool IsDisableTeleportDungeon = false, bool IsSkipQuests = false, bool LevelSetting = false, bool NewLevelSetting = false, bool DataLayerSetting = false, bool DisableEntitySetting = false, bool GmPathOnLogin = false, bool IsUseMobileStreamingParamsInPie = false, bool IsUseHighAoi = false, bool IsOpenUseWorldPartitionLoadedZone = false, bool IsCloseSkinnedMeshAlwaysTick = false, bool IsOpenReloadSpeed = false, bool IsStayInSubWp = false, bool CustomPlayerName = false, uint NullMask = 0U)
		{
			builder.StartTable(31);
			ILaunchSettingShowInMainEditor.AddNullMask(builder, NullMask);
			ILaunchSettingShowInMainEditor.AddCustomPlayerName(builder, CustomPlayerName);
			ILaunchSettingShowInMainEditor.AddIsStayInSubWp(builder, IsStayInSubWp);
			ILaunchSettingShowInMainEditor.AddIsOpenReloadSpeed(builder, IsOpenReloadSpeed);
			ILaunchSettingShowInMainEditor.AddIsCloseSkinnedMeshAlwaysTick(builder, IsCloseSkinnedMeshAlwaysTick);
			ILaunchSettingShowInMainEditor.AddIsOpenUseWorldPartitionLoadedZone(builder, IsOpenUseWorldPartitionLoadedZone);
			ILaunchSettingShowInMainEditor.AddIsUseHighAoi(builder, IsUseHighAoi);
			ILaunchSettingShowInMainEditor.AddIsUseMobileStreamingParamsInPie(builder, IsUseMobileStreamingParamsInPie);
			ILaunchSettingShowInMainEditor.AddGmPathOnLogin(builder, GmPathOnLogin);
			ILaunchSettingShowInMainEditor.AddDisableEntitySetting(builder, DisableEntitySetting);
			ILaunchSettingShowInMainEditor.AddDataLayerSetting(builder, DataLayerSetting);
			ILaunchSettingShowInMainEditor.AddNewLevelSetting(builder, NewLevelSetting);
			ILaunchSettingShowInMainEditor.AddLevelSetting(builder, LevelSetting);
			ILaunchSettingShowInMainEditor.AddIsSkipQuests(builder, IsSkipQuests);
			ILaunchSettingShowInMainEditor.AddIsDisableTeleportDungeon(builder, IsDisableTeleportDungeon);
			ILaunchSettingShowInMainEditor.AddIsUnlockAllFog(builder, IsUnlockAllFog);
			ILaunchSettingShowInMainEditor.AddEnableAllTeleportPoints(builder, EnableAllTeleportPoints);
			ILaunchSettingShowInMainEditor.AddIsUnlockSpecial(builder, IsUnlockSpecial);
			ILaunchSettingShowInMainEditor.AddIsUnlockExplore(builder, IsUnlockExplore);
			ILaunchSettingShowInMainEditor.AddEnableAllSystemWithoutPopWin(builder, EnableAllSystemWithoutPopWin);
			ILaunchSettingShowInMainEditor.AddWaitDebug(builder, WaitDebug);
			ILaunchSettingShowInMainEditor.AddIsMale(builder, IsMale);
			ILaunchSettingShowInMainEditor.AddIsOpenDebugService(builder, IsOpenDebugService);
			ILaunchSettingShowInMainEditor.AddIsBornAtCamera(builder, IsBornAtCamera);
			ILaunchSettingShowInMainEditor.AddAccount(builder, Account);
			ILaunchSettingShowInMainEditor.AddReloadConfigTable(builder, ReloadConfigTable);
			ILaunchSettingShowInMainEditor.AddReloadEditorConfig(builder, ReloadEditorConfig);
			ILaunchSettingShowInMainEditor.AddEnableDeltaReload(builder, EnableDeltaReload);
			ILaunchSettingShowInMainEditor.AddUseTemp(builder, UseTemp);
			ILaunchSettingShowInMainEditor.AddIsNetMode(builder, IsNetMode);
			ILaunchSettingShowInMainEditor.AddDisableAutoStartServer(builder, DisableAutoStartServer);
			return ILaunchSettingShowInMainEditor.EndILaunchSettingShowInMainEditor(builder);
		}

		// Token: 0x0601E6C5 RID: 124613 RVA: 0x00443480 File Offset: 0x00441680
		public static void StartILaunchSettingShowInMainEditor(FlatBufferBuilder builder)
		{
			builder.StartTable(31);
		}

		// Token: 0x0601E6C6 RID: 124614 RVA: 0x0044348A File Offset: 0x0044168A
		public static void AddDisableAutoStartServer(FlatBufferBuilder builder, bool disableAutoStartServer)
		{
			builder.AddBool(0, disableAutoStartServer, false);
		}

		// Token: 0x0601E6C7 RID: 124615 RVA: 0x00443495 File Offset: 0x00441695
		public static void AddIsNetMode(FlatBufferBuilder builder, bool isNetMode)
		{
			builder.AddBool(1, isNetMode, false);
		}

		// Token: 0x0601E6C8 RID: 124616 RVA: 0x004434A0 File Offset: 0x004416A0
		public static void AddUseTemp(FlatBufferBuilder builder, bool useTemp)
		{
			builder.AddBool(2, useTemp, false);
		}

		// Token: 0x0601E6C9 RID: 124617 RVA: 0x004434AB File Offset: 0x004416AB
		public static void AddEnableDeltaReload(FlatBufferBuilder builder, bool enableDeltaReload)
		{
			builder.AddBool(3, enableDeltaReload, false);
		}

		// Token: 0x0601E6CA RID: 124618 RVA: 0x004434B6 File Offset: 0x004416B6
		public static void AddReloadEditorConfig(FlatBufferBuilder builder, bool reloadEditorConfig)
		{
			builder.AddBool(4, reloadEditorConfig, false);
		}

		// Token: 0x0601E6CB RID: 124619 RVA: 0x004434C1 File Offset: 0x004416C1
		public static void AddReloadConfigTable(FlatBufferBuilder builder, bool reloadConfigTable)
		{
			builder.AddBool(5, reloadConfigTable, false);
		}

		// Token: 0x0601E6CC RID: 124620 RVA: 0x004434CC File Offset: 0x004416CC
		public static void AddAccount(FlatBufferBuilder builder, bool account)
		{
			builder.AddBool(6, account, false);
		}

		// Token: 0x0601E6CD RID: 124621 RVA: 0x004434D7 File Offset: 0x004416D7
		public static void AddIsBornAtCamera(FlatBufferBuilder builder, bool isBornAtCamera)
		{
			builder.AddBool(7, isBornAtCamera, false);
		}

		// Token: 0x0601E6CE RID: 124622 RVA: 0x004434E2 File Offset: 0x004416E2
		public static void AddIsOpenDebugService(FlatBufferBuilder builder, bool isOpenDebugService)
		{
			builder.AddBool(8, isOpenDebugService, false);
		}

		// Token: 0x0601E6CF RID: 124623 RVA: 0x004434ED File Offset: 0x004416ED
		public static void AddIsMale(FlatBufferBuilder builder, bool isMale)
		{
			builder.AddBool(9, isMale, false);
		}

		// Token: 0x0601E6D0 RID: 124624 RVA: 0x004434F9 File Offset: 0x004416F9
		public static void AddWaitDebug(FlatBufferBuilder builder, bool waitDebug)
		{
			builder.AddBool(10, waitDebug, false);
		}

		// Token: 0x0601E6D1 RID: 124625 RVA: 0x00443505 File Offset: 0x00441705
		public static void AddEnableAllSystemWithoutPopWin(FlatBufferBuilder builder, bool enableAllSystemWithoutPopWin)
		{
			builder.AddBool(11, enableAllSystemWithoutPopWin, false);
		}

		// Token: 0x0601E6D2 RID: 124626 RVA: 0x00443511 File Offset: 0x00441711
		public static void AddIsUnlockExplore(FlatBufferBuilder builder, bool isUnlockExplore)
		{
			builder.AddBool(12, isUnlockExplore, false);
		}

		// Token: 0x0601E6D3 RID: 124627 RVA: 0x0044351D File Offset: 0x0044171D
		public static void AddIsUnlockSpecial(FlatBufferBuilder builder, bool isUnlockSpecial)
		{
			builder.AddBool(13, isUnlockSpecial, false);
		}

		// Token: 0x0601E6D4 RID: 124628 RVA: 0x00443529 File Offset: 0x00441729
		public static void AddEnableAllTeleportPoints(FlatBufferBuilder builder, bool enableAllTeleportPoints)
		{
			builder.AddBool(14, enableAllTeleportPoints, false);
		}

		// Token: 0x0601E6D5 RID: 124629 RVA: 0x00443535 File Offset: 0x00441735
		public static void AddIsUnlockAllFog(FlatBufferBuilder builder, bool isUnlockAllFog)
		{
			builder.AddBool(15, isUnlockAllFog, false);
		}

		// Token: 0x0601E6D6 RID: 124630 RVA: 0x00443541 File Offset: 0x00441741
		public static void AddIsDisableTeleportDungeon(FlatBufferBuilder builder, bool isDisableTeleportDungeon)
		{
			builder.AddBool(16, isDisableTeleportDungeon, false);
		}

		// Token: 0x0601E6D7 RID: 124631 RVA: 0x0044354D File Offset: 0x0044174D
		public static void AddIsSkipQuests(FlatBufferBuilder builder, bool isSkipQuests)
		{
			builder.AddBool(17, isSkipQuests, false);
		}

		// Token: 0x0601E6D8 RID: 124632 RVA: 0x00443559 File Offset: 0x00441759
		public static void AddLevelSetting(FlatBufferBuilder builder, bool levelSetting)
		{
			builder.AddBool(18, levelSetting, false);
		}

		// Token: 0x0601E6D9 RID: 124633 RVA: 0x00443565 File Offset: 0x00441765
		public static void AddNewLevelSetting(FlatBufferBuilder builder, bool newLevelSetting)
		{
			builder.AddBool(19, newLevelSetting, false);
		}

		// Token: 0x0601E6DA RID: 124634 RVA: 0x00443571 File Offset: 0x00441771
		public static void AddDataLayerSetting(FlatBufferBuilder builder, bool dataLayerSetting)
		{
			builder.AddBool(20, dataLayerSetting, false);
		}

		// Token: 0x0601E6DB RID: 124635 RVA: 0x0044357D File Offset: 0x0044177D
		public static void AddDisableEntitySetting(FlatBufferBuilder builder, bool disableEntitySetting)
		{
			builder.AddBool(21, disableEntitySetting, false);
		}

		// Token: 0x0601E6DC RID: 124636 RVA: 0x00443589 File Offset: 0x00441789
		public static void AddGmPathOnLogin(FlatBufferBuilder builder, bool gmPathOnLogin)
		{
			builder.AddBool(22, gmPathOnLogin, false);
		}

		// Token: 0x0601E6DD RID: 124637 RVA: 0x00443595 File Offset: 0x00441795
		public static void AddIsUseMobileStreamingParamsInPie(FlatBufferBuilder builder, bool isUseMobileStreamingParamsInPie)
		{
			builder.AddBool(23, isUseMobileStreamingParamsInPie, false);
		}

		// Token: 0x0601E6DE RID: 124638 RVA: 0x004435A1 File Offset: 0x004417A1
		public static void AddIsUseHighAoi(FlatBufferBuilder builder, bool isUseHighAoi)
		{
			builder.AddBool(24, isUseHighAoi, false);
		}

		// Token: 0x0601E6DF RID: 124639 RVA: 0x004435AD File Offset: 0x004417AD
		public static void AddIsOpenUseWorldPartitionLoadedZone(FlatBufferBuilder builder, bool isOpenUseWorldPartitionLoadedZone)
		{
			builder.AddBool(25, isOpenUseWorldPartitionLoadedZone, false);
		}

		// Token: 0x0601E6E0 RID: 124640 RVA: 0x004435B9 File Offset: 0x004417B9
		public static void AddIsCloseSkinnedMeshAlwaysTick(FlatBufferBuilder builder, bool isCloseSkinnedMeshAlwaysTick)
		{
			builder.AddBool(26, isCloseSkinnedMeshAlwaysTick, false);
		}

		// Token: 0x0601E6E1 RID: 124641 RVA: 0x004435C5 File Offset: 0x004417C5
		public static void AddIsOpenReloadSpeed(FlatBufferBuilder builder, bool isOpenReloadSpeed)
		{
			builder.AddBool(27, isOpenReloadSpeed, false);
		}

		// Token: 0x0601E6E2 RID: 124642 RVA: 0x004435D1 File Offset: 0x004417D1
		public static void AddIsStayInSubWp(FlatBufferBuilder builder, bool isStayInSubWp)
		{
			builder.AddBool(28, isStayInSubWp, false);
		}

		// Token: 0x0601E6E3 RID: 124643 RVA: 0x004435DD File Offset: 0x004417DD
		public static void AddCustomPlayerName(FlatBufferBuilder builder, bool customPlayerName)
		{
			builder.AddBool(29, customPlayerName, false);
		}

		// Token: 0x0601E6E4 RID: 124644 RVA: 0x004435E9 File Offset: 0x004417E9
		public static void AddNullMask(FlatBufferBuilder builder, uint nullMask)
		{
			builder.AddUint(30, nullMask, 0U);
		}

		// Token: 0x0601E6E5 RID: 124645 RVA: 0x004435F5 File Offset: 0x004417F5
		public static Offset<ILaunchSettingShowInMainEditor> EndILaunchSettingShowInMainEditor(FlatBufferBuilder builder)
		{
			return new Offset<ILaunchSettingShowInMainEditor>(builder.EndTable());
		}

		// Token: 0x0601E6E6 RID: 124646 RVA: 0x00443604 File Offset: 0x00441804
		public ILaunchSettingShowInMainEditorT UnPack()
		{
			ILaunchSettingShowInMainEditorT launchSettingShowInMainEditorT = new ILaunchSettingShowInMainEditorT();
			this.UnPackTo(launchSettingShowInMainEditorT);
			return launchSettingShowInMainEditorT;
		}

		// Token: 0x0601E6E7 RID: 124647 RVA: 0x00443620 File Offset: 0x00441820
		public void UnPackTo(ILaunchSettingShowInMainEditorT _o)
		{
			_o.DisableAutoStartServer = this.DisableAutoStartServer;
			_o.IsNetMode = this.IsNetMode;
			_o.UseTemp = this.UseTemp;
			_o.EnableDeltaReload = this.EnableDeltaReload;
			_o.ReloadEditorConfig = this.ReloadEditorConfig;
			_o.ReloadConfigTable = this.ReloadConfigTable;
			_o.Account = this.Account;
			_o.IsBornAtCamera = this.IsBornAtCamera;
			_o.IsOpenDebugService = this.IsOpenDebugService;
			_o.IsMale = this.IsMale;
			_o.WaitDebug = this.WaitDebug;
			_o.EnableAllSystemWithoutPopWin = this.EnableAllSystemWithoutPopWin;
			_o.IsUnlockExplore = this.IsUnlockExplore;
			_o.IsUnlockSpecial = this.IsUnlockSpecial;
			_o.EnableAllTeleportPoints = this.EnableAllTeleportPoints;
			_o.IsUnlockAllFog = this.IsUnlockAllFog;
			_o.IsDisableTeleportDungeon = this.IsDisableTeleportDungeon;
			_o.IsSkipQuests = this.IsSkipQuests;
			_o.LevelSetting = this.LevelSetting;
			_o.NewLevelSetting = this.NewLevelSetting;
			_o.DataLayerSetting = this.DataLayerSetting;
			_o.DisableEntitySetting = this.DisableEntitySetting;
			_o.GmPathOnLogin = this.GmPathOnLogin;
			_o.IsUseMobileStreamingParamsInPie = this.IsUseMobileStreamingParamsInPie;
			_o.IsUseHighAoi = this.IsUseHighAoi;
			_o.IsOpenUseWorldPartitionLoadedZone = this.IsOpenUseWorldPartitionLoadedZone;
			_o.IsCloseSkinnedMeshAlwaysTick = this.IsCloseSkinnedMeshAlwaysTick;
			_o.IsOpenReloadSpeed = this.IsOpenReloadSpeed;
			_o.IsStayInSubWp = this.IsStayInSubWp;
			_o.CustomPlayerName = this.CustomPlayerName;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601E6E8 RID: 124648 RVA: 0x004437A4 File Offset: 0x004419A4
		public static Offset<ILaunchSettingShowInMainEditor> Pack(FlatBufferBuilder builder, ILaunchSettingShowInMainEditorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILaunchSettingShowInMainEditor>);
			}
			return ILaunchSettingShowInMainEditor.CreateILaunchSettingShowInMainEditor(builder, _o.DisableAutoStartServer, _o.IsNetMode, _o.UseTemp, _o.EnableDeltaReload, _o.ReloadEditorConfig, _o.ReloadConfigTable, _o.Account, _o.IsBornAtCamera, _o.IsOpenDebugService, _o.IsMale, _o.WaitDebug, _o.EnableAllSystemWithoutPopWin, _o.IsUnlockExplore, _o.IsUnlockSpecial, _o.EnableAllTeleportPoints, _o.IsUnlockAllFog, _o.IsDisableTeleportDungeon, _o.IsSkipQuests, _o.LevelSetting, _o.NewLevelSetting, _o.DataLayerSetting, _o.DisableEntitySetting, _o.GmPathOnLogin, _o.IsUseMobileStreamingParamsInPie, _o.IsUseHighAoi, _o.IsOpenUseWorldPartitionLoadedZone, _o.IsCloseSkinnedMeshAlwaysTick, _o.IsOpenReloadSpeed, _o.IsStayInSubWp, _o.CustomPlayerName, _o.NullMask);
		}

		// Token: 0x0400D881 RID: 55425
		private Table __p;
	}
}

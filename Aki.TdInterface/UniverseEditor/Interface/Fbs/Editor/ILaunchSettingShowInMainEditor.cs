using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004880 RID: 18560
	public struct ILaunchSettingShowInMainEditor : IFlatbufferObject
	{
		// Token: 0x1700865E RID: 34398
		// (get) Token: 0x0601CEB2 RID: 118450 RVA: 0x004163A8 File Offset: 0x004145A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CEB3 RID: 118451 RVA: 0x004163B5 File Offset: 0x004145B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CEB4 RID: 118452 RVA: 0x004163BC File Offset: 0x004145BC
		public static ILaunchSettingShowInMainEditor GetRootAsILaunchSettingShowInMainEditor(ByteBuffer _bb)
		{
			return ILaunchSettingShowInMainEditor.GetRootAsILaunchSettingShowInMainEditor(_bb, default(ILaunchSettingShowInMainEditor));
		}

		// Token: 0x0601CEB5 RID: 118453 RVA: 0x004163D8 File Offset: 0x004145D8
		public static ILaunchSettingShowInMainEditor GetRootAsILaunchSettingShowInMainEditor(ByteBuffer _bb, ILaunchSettingShowInMainEditor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CEB6 RID: 118454 RVA: 0x004163F5 File Offset: 0x004145F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CEB7 RID: 118455 RVA: 0x00416404 File Offset: 0x00414604
		public ILaunchSettingShowInMainEditor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700865F RID: 34399
		// (get) Token: 0x0601CEB8 RID: 118456 RVA: 0x00416414 File Offset: 0x00414614
		public bool DisableAutoStartServer
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008660 RID: 34400
		// (get) Token: 0x0601CEB9 RID: 118457 RVA: 0x00416454 File Offset: 0x00414654
		public bool IsNetMode
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008661 RID: 34401
		// (get) Token: 0x0601CEBA RID: 118458 RVA: 0x00416494 File Offset: 0x00414694
		public bool UseTemp
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008662 RID: 34402
		// (get) Token: 0x0601CEBB RID: 118459 RVA: 0x004164D4 File Offset: 0x004146D4
		public bool EnableDeltaReload
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008663 RID: 34403
		// (get) Token: 0x0601CEBC RID: 118460 RVA: 0x00416514 File Offset: 0x00414714
		public bool ReloadEditorConfig
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008664 RID: 34404
		// (get) Token: 0x0601CEBD RID: 118461 RVA: 0x00416554 File Offset: 0x00414754
		public bool ReloadConfigTable
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008665 RID: 34405
		// (get) Token: 0x0601CEBE RID: 118462 RVA: 0x00416594 File Offset: 0x00414794
		public bool Account
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008666 RID: 34406
		// (get) Token: 0x0601CEBF RID: 118463 RVA: 0x004165D4 File Offset: 0x004147D4
		public bool IsBornAtCamera
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008667 RID: 34407
		// (get) Token: 0x0601CEC0 RID: 118464 RVA: 0x00416614 File Offset: 0x00414814
		public bool IsOpenDebugService
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008668 RID: 34408
		// (get) Token: 0x0601CEC1 RID: 118465 RVA: 0x00416654 File Offset: 0x00414854
		public bool IsMale
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008669 RID: 34409
		// (get) Token: 0x0601CEC2 RID: 118466 RVA: 0x00416694 File Offset: 0x00414894
		public bool WaitDebug
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700866A RID: 34410
		// (get) Token: 0x0601CEC3 RID: 118467 RVA: 0x004166D4 File Offset: 0x004148D4
		public bool EnableAllSystemWithoutPopWin
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700866B RID: 34411
		// (get) Token: 0x0601CEC4 RID: 118468 RVA: 0x00416714 File Offset: 0x00414914
		public bool IsUnlockExplore
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700866C RID: 34412
		// (get) Token: 0x0601CEC5 RID: 118469 RVA: 0x00416754 File Offset: 0x00414954
		public bool IsUnlockSpecial
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700866D RID: 34413
		// (get) Token: 0x0601CEC6 RID: 118470 RVA: 0x00416794 File Offset: 0x00414994
		public bool EnableAllTeleportPoints
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700866E RID: 34414
		// (get) Token: 0x0601CEC7 RID: 118471 RVA: 0x004167D4 File Offset: 0x004149D4
		public bool IsUnlockAllFog
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700866F RID: 34415
		// (get) Token: 0x0601CEC8 RID: 118472 RVA: 0x00416814 File Offset: 0x00414A14
		public bool IsDisableTeleportDungeon
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008670 RID: 34416
		// (get) Token: 0x0601CEC9 RID: 118473 RVA: 0x00416854 File Offset: 0x00414A54
		public bool IsSkipQuests
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008671 RID: 34417
		// (get) Token: 0x0601CECA RID: 118474 RVA: 0x00416894 File Offset: 0x00414A94
		public bool LevelSetting
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008672 RID: 34418
		// (get) Token: 0x0601CECB RID: 118475 RVA: 0x004168D4 File Offset: 0x00414AD4
		public bool NewLevelSetting
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008673 RID: 34419
		// (get) Token: 0x0601CECC RID: 118476 RVA: 0x00416914 File Offset: 0x00414B14
		public bool DataLayerSetting
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008674 RID: 34420
		// (get) Token: 0x0601CECD RID: 118477 RVA: 0x00416954 File Offset: 0x00414B54
		public bool DisableEntitySetting
		{
			get
			{
				int num = this.__p.__offset(46);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008675 RID: 34421
		// (get) Token: 0x0601CECE RID: 118478 RVA: 0x00416994 File Offset: 0x00414B94
		public bool GmPathOnLogin
		{
			get
			{
				int num = this.__p.__offset(48);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008676 RID: 34422
		// (get) Token: 0x0601CECF RID: 118479 RVA: 0x004169D4 File Offset: 0x00414BD4
		public bool IsUseMobileStreamingParamsInPie
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008677 RID: 34423
		// (get) Token: 0x0601CED0 RID: 118480 RVA: 0x00416A14 File Offset: 0x00414C14
		public bool IsUseHighAoi
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008678 RID: 34424
		// (get) Token: 0x0601CED1 RID: 118481 RVA: 0x00416A54 File Offset: 0x00414C54
		public bool IsOpenUseWorldPartitionLoadedZone
		{
			get
			{
				int num = this.__p.__offset(54);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008679 RID: 34425
		// (get) Token: 0x0601CED2 RID: 118482 RVA: 0x00416A94 File Offset: 0x00414C94
		public bool IsCloseSkinnedMeshAlwaysTick
		{
			get
			{
				int num = this.__p.__offset(56);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700867A RID: 34426
		// (get) Token: 0x0601CED3 RID: 118483 RVA: 0x00416AD4 File Offset: 0x00414CD4
		public bool IsOpenReloadSpeed
		{
			get
			{
				int num = this.__p.__offset(58);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700867B RID: 34427
		// (get) Token: 0x0601CED4 RID: 118484 RVA: 0x00416B14 File Offset: 0x00414D14
		public bool IsStayInSubWp
		{
			get
			{
				int num = this.__p.__offset(60);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700867C RID: 34428
		// (get) Token: 0x0601CED5 RID: 118485 RVA: 0x00416B54 File Offset: 0x00414D54
		public bool CustomPlayerName
		{
			get
			{
				int num = this.__p.__offset(62);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700867D RID: 34429
		// (get) Token: 0x0601CED6 RID: 118486 RVA: 0x00416B94 File Offset: 0x00414D94
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

		// Token: 0x0601CED7 RID: 118487 RVA: 0x00416BD4 File Offset: 0x00414DD4
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

		// Token: 0x0601CED8 RID: 118488 RVA: 0x00416CE4 File Offset: 0x00414EE4
		public static void StartILaunchSettingShowInMainEditor(FlatBufferBuilder builder)
		{
			builder.StartTable(31);
		}

		// Token: 0x0601CED9 RID: 118489 RVA: 0x00416CEE File Offset: 0x00414EEE
		public static void AddDisableAutoStartServer(FlatBufferBuilder builder, bool disableAutoStartServer)
		{
			builder.AddBool(0, disableAutoStartServer, false);
		}

		// Token: 0x0601CEDA RID: 118490 RVA: 0x00416CF9 File Offset: 0x00414EF9
		public static void AddIsNetMode(FlatBufferBuilder builder, bool isNetMode)
		{
			builder.AddBool(1, isNetMode, false);
		}

		// Token: 0x0601CEDB RID: 118491 RVA: 0x00416D04 File Offset: 0x00414F04
		public static void AddUseTemp(FlatBufferBuilder builder, bool useTemp)
		{
			builder.AddBool(2, useTemp, false);
		}

		// Token: 0x0601CEDC RID: 118492 RVA: 0x00416D0F File Offset: 0x00414F0F
		public static void AddEnableDeltaReload(FlatBufferBuilder builder, bool enableDeltaReload)
		{
			builder.AddBool(3, enableDeltaReload, false);
		}

		// Token: 0x0601CEDD RID: 118493 RVA: 0x00416D1A File Offset: 0x00414F1A
		public static void AddReloadEditorConfig(FlatBufferBuilder builder, bool reloadEditorConfig)
		{
			builder.AddBool(4, reloadEditorConfig, false);
		}

		// Token: 0x0601CEDE RID: 118494 RVA: 0x00416D25 File Offset: 0x00414F25
		public static void AddReloadConfigTable(FlatBufferBuilder builder, bool reloadConfigTable)
		{
			builder.AddBool(5, reloadConfigTable, false);
		}

		// Token: 0x0601CEDF RID: 118495 RVA: 0x00416D30 File Offset: 0x00414F30
		public static void AddAccount(FlatBufferBuilder builder, bool account)
		{
			builder.AddBool(6, account, false);
		}

		// Token: 0x0601CEE0 RID: 118496 RVA: 0x00416D3B File Offset: 0x00414F3B
		public static void AddIsBornAtCamera(FlatBufferBuilder builder, bool isBornAtCamera)
		{
			builder.AddBool(7, isBornAtCamera, false);
		}

		// Token: 0x0601CEE1 RID: 118497 RVA: 0x00416D46 File Offset: 0x00414F46
		public static void AddIsOpenDebugService(FlatBufferBuilder builder, bool isOpenDebugService)
		{
			builder.AddBool(8, isOpenDebugService, false);
		}

		// Token: 0x0601CEE2 RID: 118498 RVA: 0x00416D51 File Offset: 0x00414F51
		public static void AddIsMale(FlatBufferBuilder builder, bool isMale)
		{
			builder.AddBool(9, isMale, false);
		}

		// Token: 0x0601CEE3 RID: 118499 RVA: 0x00416D5D File Offset: 0x00414F5D
		public static void AddWaitDebug(FlatBufferBuilder builder, bool waitDebug)
		{
			builder.AddBool(10, waitDebug, false);
		}

		// Token: 0x0601CEE4 RID: 118500 RVA: 0x00416D69 File Offset: 0x00414F69
		public static void AddEnableAllSystemWithoutPopWin(FlatBufferBuilder builder, bool enableAllSystemWithoutPopWin)
		{
			builder.AddBool(11, enableAllSystemWithoutPopWin, false);
		}

		// Token: 0x0601CEE5 RID: 118501 RVA: 0x00416D75 File Offset: 0x00414F75
		public static void AddIsUnlockExplore(FlatBufferBuilder builder, bool isUnlockExplore)
		{
			builder.AddBool(12, isUnlockExplore, false);
		}

		// Token: 0x0601CEE6 RID: 118502 RVA: 0x00416D81 File Offset: 0x00414F81
		public static void AddIsUnlockSpecial(FlatBufferBuilder builder, bool isUnlockSpecial)
		{
			builder.AddBool(13, isUnlockSpecial, false);
		}

		// Token: 0x0601CEE7 RID: 118503 RVA: 0x00416D8D File Offset: 0x00414F8D
		public static void AddEnableAllTeleportPoints(FlatBufferBuilder builder, bool enableAllTeleportPoints)
		{
			builder.AddBool(14, enableAllTeleportPoints, false);
		}

		// Token: 0x0601CEE8 RID: 118504 RVA: 0x00416D99 File Offset: 0x00414F99
		public static void AddIsUnlockAllFog(FlatBufferBuilder builder, bool isUnlockAllFog)
		{
			builder.AddBool(15, isUnlockAllFog, false);
		}

		// Token: 0x0601CEE9 RID: 118505 RVA: 0x00416DA5 File Offset: 0x00414FA5
		public static void AddIsDisableTeleportDungeon(FlatBufferBuilder builder, bool isDisableTeleportDungeon)
		{
			builder.AddBool(16, isDisableTeleportDungeon, false);
		}

		// Token: 0x0601CEEA RID: 118506 RVA: 0x00416DB1 File Offset: 0x00414FB1
		public static void AddIsSkipQuests(FlatBufferBuilder builder, bool isSkipQuests)
		{
			builder.AddBool(17, isSkipQuests, false);
		}

		// Token: 0x0601CEEB RID: 118507 RVA: 0x00416DBD File Offset: 0x00414FBD
		public static void AddLevelSetting(FlatBufferBuilder builder, bool levelSetting)
		{
			builder.AddBool(18, levelSetting, false);
		}

		// Token: 0x0601CEEC RID: 118508 RVA: 0x00416DC9 File Offset: 0x00414FC9
		public static void AddNewLevelSetting(FlatBufferBuilder builder, bool newLevelSetting)
		{
			builder.AddBool(19, newLevelSetting, false);
		}

		// Token: 0x0601CEED RID: 118509 RVA: 0x00416DD5 File Offset: 0x00414FD5
		public static void AddDataLayerSetting(FlatBufferBuilder builder, bool dataLayerSetting)
		{
			builder.AddBool(20, dataLayerSetting, false);
		}

		// Token: 0x0601CEEE RID: 118510 RVA: 0x00416DE1 File Offset: 0x00414FE1
		public static void AddDisableEntitySetting(FlatBufferBuilder builder, bool disableEntitySetting)
		{
			builder.AddBool(21, disableEntitySetting, false);
		}

		// Token: 0x0601CEEF RID: 118511 RVA: 0x00416DED File Offset: 0x00414FED
		public static void AddGmPathOnLogin(FlatBufferBuilder builder, bool gmPathOnLogin)
		{
			builder.AddBool(22, gmPathOnLogin, false);
		}

		// Token: 0x0601CEF0 RID: 118512 RVA: 0x00416DF9 File Offset: 0x00414FF9
		public static void AddIsUseMobileStreamingParamsInPie(FlatBufferBuilder builder, bool isUseMobileStreamingParamsInPie)
		{
			builder.AddBool(23, isUseMobileStreamingParamsInPie, false);
		}

		// Token: 0x0601CEF1 RID: 118513 RVA: 0x00416E05 File Offset: 0x00415005
		public static void AddIsUseHighAoi(FlatBufferBuilder builder, bool isUseHighAoi)
		{
			builder.AddBool(24, isUseHighAoi, false);
		}

		// Token: 0x0601CEF2 RID: 118514 RVA: 0x00416E11 File Offset: 0x00415011
		public static void AddIsOpenUseWorldPartitionLoadedZone(FlatBufferBuilder builder, bool isOpenUseWorldPartitionLoadedZone)
		{
			builder.AddBool(25, isOpenUseWorldPartitionLoadedZone, false);
		}

		// Token: 0x0601CEF3 RID: 118515 RVA: 0x00416E1D File Offset: 0x0041501D
		public static void AddIsCloseSkinnedMeshAlwaysTick(FlatBufferBuilder builder, bool isCloseSkinnedMeshAlwaysTick)
		{
			builder.AddBool(26, isCloseSkinnedMeshAlwaysTick, false);
		}

		// Token: 0x0601CEF4 RID: 118516 RVA: 0x00416E29 File Offset: 0x00415029
		public static void AddIsOpenReloadSpeed(FlatBufferBuilder builder, bool isOpenReloadSpeed)
		{
			builder.AddBool(27, isOpenReloadSpeed, false);
		}

		// Token: 0x0601CEF5 RID: 118517 RVA: 0x00416E35 File Offset: 0x00415035
		public static void AddIsStayInSubWp(FlatBufferBuilder builder, bool isStayInSubWp)
		{
			builder.AddBool(28, isStayInSubWp, false);
		}

		// Token: 0x0601CEF6 RID: 118518 RVA: 0x00416E41 File Offset: 0x00415041
		public static void AddCustomPlayerName(FlatBufferBuilder builder, bool customPlayerName)
		{
			builder.AddBool(29, customPlayerName, false);
		}

		// Token: 0x0601CEF7 RID: 118519 RVA: 0x00416E4D File Offset: 0x0041504D
		public static void AddNullMask(FlatBufferBuilder builder, uint nullMask)
		{
			builder.AddUint(30, nullMask, 0U);
		}

		// Token: 0x0601CEF8 RID: 118520 RVA: 0x00416E59 File Offset: 0x00415059
		public static Offset<ILaunchSettingShowInMainEditor> EndILaunchSettingShowInMainEditor(FlatBufferBuilder builder)
		{
			return new Offset<ILaunchSettingShowInMainEditor>(builder.EndTable());
		}

		// Token: 0x0601CEF9 RID: 118521 RVA: 0x00416E68 File Offset: 0x00415068
		public ILaunchSettingShowInMainEditorT UnPack()
		{
			ILaunchSettingShowInMainEditorT launchSettingShowInMainEditorT = new ILaunchSettingShowInMainEditorT();
			this.UnPackTo(launchSettingShowInMainEditorT);
			return launchSettingShowInMainEditorT;
		}

		// Token: 0x0601CEFA RID: 118522 RVA: 0x00416E84 File Offset: 0x00415084
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

		// Token: 0x0601CEFB RID: 118523 RVA: 0x00417008 File Offset: 0x00415208
		public static Offset<ILaunchSettingShowInMainEditor> Pack(FlatBufferBuilder builder, ILaunchSettingShowInMainEditorT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILaunchSettingShowInMainEditor>);
			}
			return ILaunchSettingShowInMainEditor.CreateILaunchSettingShowInMainEditor(builder, _o.DisableAutoStartServer, _o.IsNetMode, _o.UseTemp, _o.EnableDeltaReload, _o.ReloadEditorConfig, _o.ReloadConfigTable, _o.Account, _o.IsBornAtCamera, _o.IsOpenDebugService, _o.IsMale, _o.WaitDebug, _o.EnableAllSystemWithoutPopWin, _o.IsUnlockExplore, _o.IsUnlockSpecial, _o.EnableAllTeleportPoints, _o.IsUnlockAllFog, _o.IsDisableTeleportDungeon, _o.IsSkipQuests, _o.LevelSetting, _o.NewLevelSetting, _o.DataLayerSetting, _o.DisableEntitySetting, _o.GmPathOnLogin, _o.IsUseMobileStreamingParamsInPie, _o.IsUseHighAoi, _o.IsOpenUseWorldPartitionLoadedZone, _o.IsCloseSkinnedMeshAlwaysTick, _o.IsOpenReloadSpeed, _o.IsStayInSubWp, _o.CustomPlayerName, _o.NullMask);
		}

		// Token: 0x0400CE48 RID: 52808
		private Table __p;
	}
}

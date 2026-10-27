using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004868 RID: 18536
	public struct IEditorSaveConfig : IFlatbufferObject
	{
		// Token: 0x1700857F RID: 34175
		// (get) Token: 0x0601CC2C RID: 117804 RVA: 0x00410B0C File Offset: 0x0040ED0C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CC2D RID: 117805 RVA: 0x00410B19 File Offset: 0x0040ED19
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CC2E RID: 117806 RVA: 0x00410B20 File Offset: 0x0040ED20
		public static IEditorSaveConfig GetRootAsIEditorSaveConfig(ByteBuffer _bb)
		{
			return IEditorSaveConfig.GetRootAsIEditorSaveConfig(_bb, default(IEditorSaveConfig));
		}

		// Token: 0x0601CC2F RID: 117807 RVA: 0x00410B3C File Offset: 0x0040ED3C
		public static IEditorSaveConfig GetRootAsIEditorSaveConfig(ByteBuffer _bb, IEditorSaveConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CC30 RID: 117808 RVA: 0x00410B59 File Offset: 0x0040ED59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CC31 RID: 117809 RVA: 0x00410B68 File Offset: 0x0040ED68
		public IEditorSaveConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008580 RID: 34176
		// (get) Token: 0x0601CC32 RID: 117810 RVA: 0x00410B78 File Offset: 0x0040ED78
		public string Account
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CC33 RID: 117811 RVA: 0x00410BAF File Offset: 0x0040EDAF
		public Span<byte> GetAccountBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601CC34 RID: 117812 RVA: 0x00410BBE File Offset: 0x0040EDBE
		public byte[] GetAccountArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008581 RID: 34177
		// (get) Token: 0x0601CC35 RID: 117813 RVA: 0x00410BCC File Offset: 0x0040EDCC
		public EEditorLoginAccountType LoginAccountType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EEditorLoginAccountType.Custom;
				}
				return (EEditorLoginAccountType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008582 RID: 34178
		// (get) Token: 0x0601CC36 RID: 117814 RVA: 0x00410C08 File Offset: 0x0040EE08
		public string CustomAccount
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CC37 RID: 117815 RVA: 0x00410C3F File Offset: 0x0040EE3F
		public Span<byte> GetCustomAccountBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601CC38 RID: 117816 RVA: 0x00410C4E File Offset: 0x0040EE4E
		public byte[] GetCustomAccountArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008583 RID: 34179
		// (get) Token: 0x0601CC39 RID: 117817 RVA: 0x00410C5C File Offset: 0x0040EE5C
		public string ArchiveAccount
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CC3A RID: 117818 RVA: 0x00410C94 File Offset: 0x0040EE94
		public Span<byte> GetArchiveAccountBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601CC3B RID: 117819 RVA: 0x00410CA4 File Offset: 0x0040EEA4
		public byte[] GetArchiveAccountArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17008584 RID: 34180
		// (get) Token: 0x0601CC3C RID: 117820 RVA: 0x00410CB4 File Offset: 0x0040EEB4
		public bool IsNetMode
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008585 RID: 34181
		// (get) Token: 0x0601CC3D RID: 117821 RVA: 0x00410CF4 File Offset: 0x0040EEF4
		public bool IsMale
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008586 RID: 34182
		// (get) Token: 0x0601CC3E RID: 117822 RVA: 0x00410D34 File Offset: 0x0040EF34
		public bool UseTemp
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008587 RID: 34183
		// (get) Token: 0x0601CC3F RID: 117823 RVA: 0x00410D74 File Offset: 0x0040EF74
		public string ServerIp
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CC40 RID: 117824 RVA: 0x00410DAC File Offset: 0x0040EFAC
		public Span<byte> GetServerIpBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0601CC41 RID: 117825 RVA: 0x00410DBC File Offset: 0x0040EFBC
		public byte[] GetServerIpArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x17008588 RID: 34184
		// (get) Token: 0x0601CC42 RID: 117826 RVA: 0x00410DCC File Offset: 0x0040EFCC
		public bool IsRelaxMode
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008589 RID: 34185
		// (get) Token: 0x0601CC43 RID: 117827 RVA: 0x00410E0C File Offset: 0x0040F00C
		public int DungeonId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700858A RID: 34186
		// (get) Token: 0x0601CC44 RID: 117828 RVA: 0x00410E4C File Offset: 0x0040F04C
		public bool IsBornAtCamera
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700858B RID: 34187
		// (get) Token: 0x0601CC45 RID: 117829 RVA: 0x00410E8C File Offset: 0x0040F08C
		public bool IsOpenDebugService
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700858C RID: 34188
		// (get) Token: 0x0601CC46 RID: 117830 RVA: 0x00410ECC File Offset: 0x0040F0CC
		public bool DisableAutoStartServer
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700858D RID: 34189
		// (get) Token: 0x0601CC47 RID: 117831 RVA: 0x00410F0C File Offset: 0x0040F10C
		public bool ReloadEditorConfig
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700858E RID: 34190
		// (get) Token: 0x0601CC48 RID: 117832 RVA: 0x00410F4C File Offset: 0x0040F14C
		public bool ReloadConfigTable
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700858F RID: 34191
		// (get) Token: 0x0601CC49 RID: 117833 RVA: 0x00410F8C File Offset: 0x0040F18C
		public bool IsLoginByNewUserName
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008590 RID: 34192
		// (get) Token: 0x0601CC4A RID: 117834 RVA: 0x00410FCC File Offset: 0x0040F1CC
		public EAccountType AccountType
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return EAccountType.Custom;
				}
				return (EAccountType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008591 RID: 34193
		// (get) Token: 0x0601CC4B RID: 117835 RVA: 0x0041100C File Offset: 0x0040F20C
		public string GmPathOnLogin
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CC4C RID: 117836 RVA: 0x00411044 File Offset: 0x0040F244
		public Span<byte> GetGmPathOnLoginBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0601CC4D RID: 117837 RVA: 0x00411054 File Offset: 0x0040F254
		public byte[] GetGmPathOnLoginArray()
		{
			return this.__p.__vector_as_array<byte>(38);
		}

		// Token: 0x17008592 RID: 34194
		// (get) Token: 0x0601CC4E RID: 117838 RVA: 0x00411064 File Offset: 0x0040F264
		public int EditorPort
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008593 RID: 34195
		// (get) Token: 0x0601CC4F RID: 117839 RVA: 0x004110A4 File Offset: 0x0040F2A4
		public int GameClientGmPort
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008594 RID: 34196
		// (get) Token: 0x0601CC50 RID: 117840 RVA: 0x004110E4 File Offset: 0x0040F2E4
		public bool IsReLoadArchive
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008595 RID: 34197
		// (get) Token: 0x0601CC51 RID: 117841 RVA: 0x00411124 File Offset: 0x0040F324
		public int PackageVersion
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008596 RID: 34198
		// (get) Token: 0x0601CC52 RID: 117842 RVA: 0x00411164 File Offset: 0x0040F364
		public bool IsCustomAttachServerIp
		{
			get
			{
				int num = this.__p.__offset(48);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008597 RID: 34199
		// (get) Token: 0x0601CC53 RID: 117843 RVA: 0x004111A4 File Offset: 0x0040F3A4
		public string AttachServerIp
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CC54 RID: 117844 RVA: 0x004111DC File Offset: 0x0040F3DC
		public Span<byte> GetAttachServerIpBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0601CC55 RID: 117845 RVA: 0x004111EC File Offset: 0x0040F3EC
		public byte[] GetAttachServerIpArray()
		{
			return this.__p.__vector_as_array<byte>(50);
		}

		// Token: 0x17008598 RID: 34200
		// (get) Token: 0x0601CC56 RID: 117846 RVA: 0x004111FC File Offset: 0x0040F3FC
		public int AttachPlayerId
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008599 RID: 34201
		// (get) Token: 0x0601CC57 RID: 117847 RVA: 0x0041123C File Offset: 0x0040F43C
		public bool IsUseMobileStreamingParamsInPie
		{
			get
			{
				int num = this.__p.__offset(54);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700859A RID: 34202
		// (get) Token: 0x0601CC58 RID: 117848 RVA: 0x0041127C File Offset: 0x0040F47C
		public bool IsUseHighAoi
		{
			get
			{
				int num = this.__p.__offset(56);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700859B RID: 34203
		// (get) Token: 0x0601CC59 RID: 117849 RVA: 0x004112BC File Offset: 0x0040F4BC
		public bool IsStayInSubWp
		{
			get
			{
				int num = this.__p.__offset(58);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700859C RID: 34204
		// (get) Token: 0x0601CC5A RID: 117850 RVA: 0x004112FC File Offset: 0x0040F4FC
		public string CustomPlayerName
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CC5B RID: 117851 RVA: 0x00411334 File Offset: 0x0040F534
		public Span<byte> GetCustomPlayerNameBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x0601CC5C RID: 117852 RVA: 0x00411344 File Offset: 0x0040F544
		public byte[] GetCustomPlayerNameArray()
		{
			return this.__p.__vector_as_array<byte>(60);
		}

		// Token: 0x0601CC5D RID: 117853 RVA: 0x00411354 File Offset: 0x0040F554
		public static Offset<IEditorSaveConfig> CreateIEditorSaveConfig(FlatBufferBuilder builder, StringOffset AccountOffset = default(StringOffset), EEditorLoginAccountType LoginAccountType = EEditorLoginAccountType.Custom, StringOffset CustomAccountOffset = default(StringOffset), StringOffset ArchiveAccountOffset = default(StringOffset), bool IsNetMode = false, bool IsMale = false, bool UseTemp = false, StringOffset ServerIpOffset = default(StringOffset), bool IsRelaxMode = false, int DungeonId = 0, bool IsBornAtCamera = false, bool IsOpenDebugService = false, bool DisableAutoStartServer = false, bool ReloadEditorConfig = false, bool ReloadConfigTable = false, bool IsLoginByNewUserName = false, EAccountType AccountType = EAccountType.Custom, StringOffset GmPathOnLoginOffset = default(StringOffset), int EditorPort = 0, int GameClientGmPort = 0, bool IsReLoadArchive = false, int PackageVersion = 0, bool IsCustomAttachServerIp = false, StringOffset AttachServerIpOffset = default(StringOffset), int AttachPlayerId = 0, bool IsUseMobileStreamingParamsInPie = false, bool IsUseHighAoi = false, bool IsStayInSubWp = false, StringOffset CustomPlayerNameOffset = default(StringOffset))
		{
			builder.StartTable(29);
			IEditorSaveConfig.AddCustomPlayerName(builder, CustomPlayerNameOffset);
			IEditorSaveConfig.AddAttachPlayerId(builder, AttachPlayerId);
			IEditorSaveConfig.AddAttachServerIp(builder, AttachServerIpOffset);
			IEditorSaveConfig.AddPackageVersion(builder, PackageVersion);
			IEditorSaveConfig.AddGameClientGmPort(builder, GameClientGmPort);
			IEditorSaveConfig.AddEditorPort(builder, EditorPort);
			IEditorSaveConfig.AddGmPathOnLogin(builder, GmPathOnLoginOffset);
			IEditorSaveConfig.AddDungeonId(builder, DungeonId);
			IEditorSaveConfig.AddServerIp(builder, ServerIpOffset);
			IEditorSaveConfig.AddArchiveAccount(builder, ArchiveAccountOffset);
			IEditorSaveConfig.AddCustomAccount(builder, CustomAccountOffset);
			IEditorSaveConfig.AddAccount(builder, AccountOffset);
			IEditorSaveConfig.AddIsStayInSubWp(builder, IsStayInSubWp);
			IEditorSaveConfig.AddIsUseHighAoi(builder, IsUseHighAoi);
			IEditorSaveConfig.AddIsUseMobileStreamingParamsInPie(builder, IsUseMobileStreamingParamsInPie);
			IEditorSaveConfig.AddIsCustomAttachServerIp(builder, IsCustomAttachServerIp);
			IEditorSaveConfig.AddIsReLoadArchive(builder, IsReLoadArchive);
			IEditorSaveConfig.AddAccountType(builder, AccountType);
			IEditorSaveConfig.AddIsLoginByNewUserName(builder, IsLoginByNewUserName);
			IEditorSaveConfig.AddReloadConfigTable(builder, ReloadConfigTable);
			IEditorSaveConfig.AddReloadEditorConfig(builder, ReloadEditorConfig);
			IEditorSaveConfig.AddDisableAutoStartServer(builder, DisableAutoStartServer);
			IEditorSaveConfig.AddIsOpenDebugService(builder, IsOpenDebugService);
			IEditorSaveConfig.AddIsBornAtCamera(builder, IsBornAtCamera);
			IEditorSaveConfig.AddIsRelaxMode(builder, IsRelaxMode);
			IEditorSaveConfig.AddUseTemp(builder, UseTemp);
			IEditorSaveConfig.AddIsMale(builder, IsMale);
			IEditorSaveConfig.AddIsNetMode(builder, IsNetMode);
			IEditorSaveConfig.AddLoginAccountType(builder, LoginAccountType);
			return IEditorSaveConfig.EndIEditorSaveConfig(builder);
		}

		// Token: 0x0601CC5E RID: 117854 RVA: 0x00411454 File Offset: 0x0040F654
		public static void StartIEditorSaveConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(29);
		}

		// Token: 0x0601CC5F RID: 117855 RVA: 0x0041145E File Offset: 0x0040F65E
		public static void AddAccount(FlatBufferBuilder builder, StringOffset accountOffset)
		{
			builder.AddOffset(0, accountOffset.Value, 0);
		}

		// Token: 0x0601CC60 RID: 117856 RVA: 0x0041146E File Offset: 0x0040F66E
		public static void AddLoginAccountType(FlatBufferBuilder builder, EEditorLoginAccountType loginAccountType)
		{
			builder.AddByte(1, (byte)loginAccountType, 0);
		}

		// Token: 0x0601CC61 RID: 117857 RVA: 0x00411479 File Offset: 0x0040F679
		public static void AddCustomAccount(FlatBufferBuilder builder, StringOffset customAccountOffset)
		{
			builder.AddOffset(2, customAccountOffset.Value, 0);
		}

		// Token: 0x0601CC62 RID: 117858 RVA: 0x00411489 File Offset: 0x0040F689
		public static void AddArchiveAccount(FlatBufferBuilder builder, StringOffset archiveAccountOffset)
		{
			builder.AddOffset(3, archiveAccountOffset.Value, 0);
		}

		// Token: 0x0601CC63 RID: 117859 RVA: 0x00411499 File Offset: 0x0040F699
		public static void AddIsNetMode(FlatBufferBuilder builder, bool isNetMode)
		{
			builder.AddBool(4, isNetMode, false);
		}

		// Token: 0x0601CC64 RID: 117860 RVA: 0x004114A4 File Offset: 0x0040F6A4
		public static void AddIsMale(FlatBufferBuilder builder, bool isMale)
		{
			builder.AddBool(5, isMale, false);
		}

		// Token: 0x0601CC65 RID: 117861 RVA: 0x004114AF File Offset: 0x0040F6AF
		public static void AddUseTemp(FlatBufferBuilder builder, bool useTemp)
		{
			builder.AddBool(6, useTemp, false);
		}

		// Token: 0x0601CC66 RID: 117862 RVA: 0x004114BA File Offset: 0x0040F6BA
		public static void AddServerIp(FlatBufferBuilder builder, StringOffset serverIpOffset)
		{
			builder.AddOffset(7, serverIpOffset.Value, 0);
		}

		// Token: 0x0601CC67 RID: 117863 RVA: 0x004114CA File Offset: 0x0040F6CA
		public static void AddIsRelaxMode(FlatBufferBuilder builder, bool isRelaxMode)
		{
			builder.AddBool(8, isRelaxMode, false);
		}

		// Token: 0x0601CC68 RID: 117864 RVA: 0x004114D5 File Offset: 0x0040F6D5
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(9, dungeonId, 0);
		}

		// Token: 0x0601CC69 RID: 117865 RVA: 0x004114E1 File Offset: 0x0040F6E1
		public static void AddIsBornAtCamera(FlatBufferBuilder builder, bool isBornAtCamera)
		{
			builder.AddBool(10, isBornAtCamera, false);
		}

		// Token: 0x0601CC6A RID: 117866 RVA: 0x004114ED File Offset: 0x0040F6ED
		public static void AddIsOpenDebugService(FlatBufferBuilder builder, bool isOpenDebugService)
		{
			builder.AddBool(11, isOpenDebugService, false);
		}

		// Token: 0x0601CC6B RID: 117867 RVA: 0x004114F9 File Offset: 0x0040F6F9
		public static void AddDisableAutoStartServer(FlatBufferBuilder builder, bool disableAutoStartServer)
		{
			builder.AddBool(12, disableAutoStartServer, false);
		}

		// Token: 0x0601CC6C RID: 117868 RVA: 0x00411505 File Offset: 0x0040F705
		public static void AddReloadEditorConfig(FlatBufferBuilder builder, bool reloadEditorConfig)
		{
			builder.AddBool(13, reloadEditorConfig, false);
		}

		// Token: 0x0601CC6D RID: 117869 RVA: 0x00411511 File Offset: 0x0040F711
		public static void AddReloadConfigTable(FlatBufferBuilder builder, bool reloadConfigTable)
		{
			builder.AddBool(14, reloadConfigTable, false);
		}

		// Token: 0x0601CC6E RID: 117870 RVA: 0x0041151D File Offset: 0x0040F71D
		public static void AddIsLoginByNewUserName(FlatBufferBuilder builder, bool isLoginByNewUserName)
		{
			builder.AddBool(15, isLoginByNewUserName, false);
		}

		// Token: 0x0601CC6F RID: 117871 RVA: 0x00411529 File Offset: 0x0040F729
		public static void AddAccountType(FlatBufferBuilder builder, EAccountType accountType)
		{
			builder.AddByte(16, (byte)accountType, 0);
		}

		// Token: 0x0601CC70 RID: 117872 RVA: 0x00411535 File Offset: 0x0040F735
		public static void AddGmPathOnLogin(FlatBufferBuilder builder, StringOffset gmPathOnLoginOffset)
		{
			builder.AddOffset(17, gmPathOnLoginOffset.Value, 0);
		}

		// Token: 0x0601CC71 RID: 117873 RVA: 0x00411546 File Offset: 0x0040F746
		public static void AddEditorPort(FlatBufferBuilder builder, int editorPort)
		{
			builder.AddInt(18, editorPort, 0);
		}

		// Token: 0x0601CC72 RID: 117874 RVA: 0x00411552 File Offset: 0x0040F752
		public static void AddGameClientGmPort(FlatBufferBuilder builder, int gameClientGmPort)
		{
			builder.AddInt(19, gameClientGmPort, 0);
		}

		// Token: 0x0601CC73 RID: 117875 RVA: 0x0041155E File Offset: 0x0040F75E
		public static void AddIsReLoadArchive(FlatBufferBuilder builder, bool isReLoadArchive)
		{
			builder.AddBool(20, isReLoadArchive, false);
		}

		// Token: 0x0601CC74 RID: 117876 RVA: 0x0041156A File Offset: 0x0040F76A
		public static void AddPackageVersion(FlatBufferBuilder builder, int packageVersion)
		{
			builder.AddInt(21, packageVersion, 0);
		}

		// Token: 0x0601CC75 RID: 117877 RVA: 0x00411576 File Offset: 0x0040F776
		public static void AddIsCustomAttachServerIp(FlatBufferBuilder builder, bool isCustomAttachServerIp)
		{
			builder.AddBool(22, isCustomAttachServerIp, false);
		}

		// Token: 0x0601CC76 RID: 117878 RVA: 0x00411582 File Offset: 0x0040F782
		public static void AddAttachServerIp(FlatBufferBuilder builder, StringOffset attachServerIpOffset)
		{
			builder.AddOffset(23, attachServerIpOffset.Value, 0);
		}

		// Token: 0x0601CC77 RID: 117879 RVA: 0x00411593 File Offset: 0x0040F793
		public static void AddAttachPlayerId(FlatBufferBuilder builder, int attachPlayerId)
		{
			builder.AddInt(24, attachPlayerId, 0);
		}

		// Token: 0x0601CC78 RID: 117880 RVA: 0x0041159F File Offset: 0x0040F79F
		public static void AddIsUseMobileStreamingParamsInPie(FlatBufferBuilder builder, bool isUseMobileStreamingParamsInPie)
		{
			builder.AddBool(25, isUseMobileStreamingParamsInPie, false);
		}

		// Token: 0x0601CC79 RID: 117881 RVA: 0x004115AB File Offset: 0x0040F7AB
		public static void AddIsUseHighAoi(FlatBufferBuilder builder, bool isUseHighAoi)
		{
			builder.AddBool(26, isUseHighAoi, false);
		}

		// Token: 0x0601CC7A RID: 117882 RVA: 0x004115B7 File Offset: 0x0040F7B7
		public static void AddIsStayInSubWp(FlatBufferBuilder builder, bool isStayInSubWp)
		{
			builder.AddBool(27, isStayInSubWp, false);
		}

		// Token: 0x0601CC7B RID: 117883 RVA: 0x004115C3 File Offset: 0x0040F7C3
		public static void AddCustomPlayerName(FlatBufferBuilder builder, StringOffset customPlayerNameOffset)
		{
			builder.AddOffset(28, customPlayerNameOffset.Value, 0);
		}

		// Token: 0x0601CC7C RID: 117884 RVA: 0x004115D4 File Offset: 0x0040F7D4
		public static Offset<IEditorSaveConfig> EndIEditorSaveConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEditorSaveConfig>(builder.EndTable());
		}

		// Token: 0x0601CC7D RID: 117885 RVA: 0x004115E4 File Offset: 0x0040F7E4
		public IEditorSaveConfigT UnPack()
		{
			IEditorSaveConfigT editorSaveConfigT = new IEditorSaveConfigT();
			this.UnPackTo(editorSaveConfigT);
			return editorSaveConfigT;
		}

		// Token: 0x0601CC7E RID: 117886 RVA: 0x00411600 File Offset: 0x0040F800
		public void UnPackTo(IEditorSaveConfigT _o)
		{
			_o.Account = this.Account;
			_o.LoginAccountType = this.LoginAccountType;
			_o.CustomAccount = this.CustomAccount;
			_o.ArchiveAccount = this.ArchiveAccount;
			_o.IsNetMode = this.IsNetMode;
			_o.IsMale = this.IsMale;
			_o.UseTemp = this.UseTemp;
			_o.ServerIp = this.ServerIp;
			_o.IsRelaxMode = this.IsRelaxMode;
			_o.DungeonId = this.DungeonId;
			_o.IsBornAtCamera = this.IsBornAtCamera;
			_o.IsOpenDebugService = this.IsOpenDebugService;
			_o.DisableAutoStartServer = this.DisableAutoStartServer;
			_o.ReloadEditorConfig = this.ReloadEditorConfig;
			_o.ReloadConfigTable = this.ReloadConfigTable;
			_o.IsLoginByNewUserName = this.IsLoginByNewUserName;
			_o.AccountType = this.AccountType;
			_o.GmPathOnLogin = this.GmPathOnLogin;
			_o.EditorPort = this.EditorPort;
			_o.GameClientGmPort = this.GameClientGmPort;
			_o.IsReLoadArchive = this.IsReLoadArchive;
			_o.PackageVersion = this.PackageVersion;
			_o.IsCustomAttachServerIp = this.IsCustomAttachServerIp;
			_o.AttachServerIp = this.AttachServerIp;
			_o.AttachPlayerId = this.AttachPlayerId;
			_o.IsUseMobileStreamingParamsInPie = this.IsUseMobileStreamingParamsInPie;
			_o.IsUseHighAoi = this.IsUseHighAoi;
			_o.IsStayInSubWp = this.IsStayInSubWp;
			_o.CustomPlayerName = this.CustomPlayerName;
		}

		// Token: 0x0601CC7F RID: 117887 RVA: 0x0041176C File Offset: 0x0040F96C
		public static Offset<IEditorSaveConfig> Pack(FlatBufferBuilder builder, IEditorSaveConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEditorSaveConfig>);
			}
			StringOffset accountOffset = (_o.Account == null) ? default(StringOffset) : builder.CreateString(_o.Account);
			StringOffset customAccountOffset = (_o.CustomAccount == null) ? default(StringOffset) : builder.CreateString(_o.CustomAccount);
			StringOffset archiveAccountOffset = (_o.ArchiveAccount == null) ? default(StringOffset) : builder.CreateString(_o.ArchiveAccount);
			StringOffset serverIpOffset = (_o.ServerIp == null) ? default(StringOffset) : builder.CreateString(_o.ServerIp);
			StringOffset gmPathOnLoginOffset = (_o.GmPathOnLogin == null) ? default(StringOffset) : builder.CreateString(_o.GmPathOnLogin);
			StringOffset attachServerIpOffset = (_o.AttachServerIp == null) ? default(StringOffset) : builder.CreateString(_o.AttachServerIp);
			StringOffset customPlayerNameOffset = (_o.CustomPlayerName == null) ? default(StringOffset) : builder.CreateString(_o.CustomPlayerName);
			return IEditorSaveConfig.CreateIEditorSaveConfig(builder, accountOffset, _o.LoginAccountType, customAccountOffset, archiveAccountOffset, _o.IsNetMode, _o.IsMale, _o.UseTemp, serverIpOffset, _o.IsRelaxMode, _o.DungeonId, _o.IsBornAtCamera, _o.IsOpenDebugService, _o.DisableAutoStartServer, _o.ReloadEditorConfig, _o.ReloadConfigTable, _o.IsLoginByNewUserName, _o.AccountType, gmPathOnLoginOffset, _o.EditorPort, _o.GameClientGmPort, _o.IsReLoadArchive, _o.PackageVersion, _o.IsCustomAttachServerIp, attachServerIpOffset, _o.AttachPlayerId, _o.IsUseMobileStreamingParamsInPie, _o.IsUseHighAoi, _o.IsStayInSubWp, customPlayerNameOffset);
		}

		// Token: 0x0400CDD5 RID: 52693
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CCD RID: 19661
	public struct IEditorSaveConfig : IFlatbufferObject
	{
		// Token: 0x17008BC9 RID: 35785
		// (get) Token: 0x0601E41D RID: 123933 RVA: 0x0043D3B4 File Offset: 0x0043B5B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E41E RID: 123934 RVA: 0x0043D3C1 File Offset: 0x0043B5C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E41F RID: 123935 RVA: 0x0043D3C8 File Offset: 0x0043B5C8
		public static IEditorSaveConfig GetRootAsIEditorSaveConfig(ByteBuffer _bb)
		{
			return IEditorSaveConfig.GetRootAsIEditorSaveConfig(_bb, default(IEditorSaveConfig));
		}

		// Token: 0x0601E420 RID: 123936 RVA: 0x0043D3E4 File Offset: 0x0043B5E4
		public static IEditorSaveConfig GetRootAsIEditorSaveConfig(ByteBuffer _bb, IEditorSaveConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E421 RID: 123937 RVA: 0x0043D401 File Offset: 0x0043B601
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E422 RID: 123938 RVA: 0x0043D410 File Offset: 0x0043B610
		public IEditorSaveConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008BCA RID: 35786
		// (get) Token: 0x0601E423 RID: 123939 RVA: 0x0043D420 File Offset: 0x0043B620
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

		// Token: 0x0601E424 RID: 123940 RVA: 0x0043D457 File Offset: 0x0043B657
		public Span<byte> GetAccountBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601E425 RID: 123941 RVA: 0x0043D466 File Offset: 0x0043B666
		public byte[] GetAccountArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008BCB RID: 35787
		// (get) Token: 0x0601E426 RID: 123942 RVA: 0x0043D474 File Offset: 0x0043B674
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

		// Token: 0x17008BCC RID: 35788
		// (get) Token: 0x0601E427 RID: 123943 RVA: 0x0043D4B0 File Offset: 0x0043B6B0
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

		// Token: 0x0601E428 RID: 123944 RVA: 0x0043D4E7 File Offset: 0x0043B6E7
		public Span<byte> GetCustomAccountBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601E429 RID: 123945 RVA: 0x0043D4F6 File Offset: 0x0043B6F6
		public byte[] GetCustomAccountArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008BCD RID: 35789
		// (get) Token: 0x0601E42A RID: 123946 RVA: 0x0043D504 File Offset: 0x0043B704
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

		// Token: 0x0601E42B RID: 123947 RVA: 0x0043D53C File Offset: 0x0043B73C
		public Span<byte> GetArchiveAccountBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601E42C RID: 123948 RVA: 0x0043D54C File Offset: 0x0043B74C
		public byte[] GetArchiveAccountArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17008BCE RID: 35790
		// (get) Token: 0x0601E42D RID: 123949 RVA: 0x0043D55C File Offset: 0x0043B75C
		public bool IsNetMode
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008BCF RID: 35791
		// (get) Token: 0x0601E42E RID: 123950 RVA: 0x0043D59C File Offset: 0x0043B79C
		public bool IsMale
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008BD0 RID: 35792
		// (get) Token: 0x0601E42F RID: 123951 RVA: 0x0043D5DC File Offset: 0x0043B7DC
		public bool UseTemp
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008BD1 RID: 35793
		// (get) Token: 0x0601E430 RID: 123952 RVA: 0x0043D61C File Offset: 0x0043B81C
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

		// Token: 0x0601E431 RID: 123953 RVA: 0x0043D654 File Offset: 0x0043B854
		public Span<byte> GetServerIpBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0601E432 RID: 123954 RVA: 0x0043D664 File Offset: 0x0043B864
		public byte[] GetServerIpArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x17008BD2 RID: 35794
		// (get) Token: 0x0601E433 RID: 123955 RVA: 0x0043D674 File Offset: 0x0043B874
		public bool IsRelaxMode
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008BD3 RID: 35795
		// (get) Token: 0x0601E434 RID: 123956 RVA: 0x0043D6B4 File Offset: 0x0043B8B4
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

		// Token: 0x17008BD4 RID: 35796
		// (get) Token: 0x0601E435 RID: 123957 RVA: 0x0043D6F4 File Offset: 0x0043B8F4
		public bool IsBornAtCamera
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008BD5 RID: 35797
		// (get) Token: 0x0601E436 RID: 123958 RVA: 0x0043D734 File Offset: 0x0043B934
		public bool IsOpenDebugService
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008BD6 RID: 35798
		// (get) Token: 0x0601E437 RID: 123959 RVA: 0x0043D774 File Offset: 0x0043B974
		public bool DisableAutoStartServer
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008BD7 RID: 35799
		// (get) Token: 0x0601E438 RID: 123960 RVA: 0x0043D7B4 File Offset: 0x0043B9B4
		public bool ReloadEditorConfig
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008BD8 RID: 35800
		// (get) Token: 0x0601E439 RID: 123961 RVA: 0x0043D7F4 File Offset: 0x0043B9F4
		public bool ReloadConfigTable
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008BD9 RID: 35801
		// (get) Token: 0x0601E43A RID: 123962 RVA: 0x0043D834 File Offset: 0x0043BA34
		public bool IsLoginByNewUserName
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008BDA RID: 35802
		// (get) Token: 0x0601E43B RID: 123963 RVA: 0x0043D874 File Offset: 0x0043BA74
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

		// Token: 0x17008BDB RID: 35803
		// (get) Token: 0x0601E43C RID: 123964 RVA: 0x0043D8B4 File Offset: 0x0043BAB4
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

		// Token: 0x0601E43D RID: 123965 RVA: 0x0043D8EC File Offset: 0x0043BAEC
		public Span<byte> GetGmPathOnLoginBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0601E43E RID: 123966 RVA: 0x0043D8FC File Offset: 0x0043BAFC
		public byte[] GetGmPathOnLoginArray()
		{
			return this.__p.__vector_as_array<byte>(38);
		}

		// Token: 0x17008BDC RID: 35804
		// (get) Token: 0x0601E43F RID: 123967 RVA: 0x0043D90C File Offset: 0x0043BB0C
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

		// Token: 0x17008BDD RID: 35805
		// (get) Token: 0x0601E440 RID: 123968 RVA: 0x0043D94C File Offset: 0x0043BB4C
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

		// Token: 0x17008BDE RID: 35806
		// (get) Token: 0x0601E441 RID: 123969 RVA: 0x0043D98C File Offset: 0x0043BB8C
		public bool IsReLoadArchive
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008BDF RID: 35807
		// (get) Token: 0x0601E442 RID: 123970 RVA: 0x0043D9CC File Offset: 0x0043BBCC
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

		// Token: 0x17008BE0 RID: 35808
		// (get) Token: 0x0601E443 RID: 123971 RVA: 0x0043DA0C File Offset: 0x0043BC0C
		public bool IsCustomAttachServerIp
		{
			get
			{
				int num = this.__p.__offset(48);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008BE1 RID: 35809
		// (get) Token: 0x0601E444 RID: 123972 RVA: 0x0043DA4C File Offset: 0x0043BC4C
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

		// Token: 0x0601E445 RID: 123973 RVA: 0x0043DA84 File Offset: 0x0043BC84
		public Span<byte> GetAttachServerIpBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0601E446 RID: 123974 RVA: 0x0043DA94 File Offset: 0x0043BC94
		public byte[] GetAttachServerIpArray()
		{
			return this.__p.__vector_as_array<byte>(50);
		}

		// Token: 0x17008BE2 RID: 35810
		// (get) Token: 0x0601E447 RID: 123975 RVA: 0x0043DAA4 File Offset: 0x0043BCA4
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

		// Token: 0x17008BE3 RID: 35811
		// (get) Token: 0x0601E448 RID: 123976 RVA: 0x0043DAE4 File Offset: 0x0043BCE4
		public bool IsUseMobileStreamingParamsInPie
		{
			get
			{
				int num = this.__p.__offset(54);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008BE4 RID: 35812
		// (get) Token: 0x0601E449 RID: 123977 RVA: 0x0043DB24 File Offset: 0x0043BD24
		public bool IsUseHighAoi
		{
			get
			{
				int num = this.__p.__offset(56);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008BE5 RID: 35813
		// (get) Token: 0x0601E44A RID: 123978 RVA: 0x0043DB64 File Offset: 0x0043BD64
		public bool IsStayInSubWp
		{
			get
			{
				int num = this.__p.__offset(58);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008BE6 RID: 35814
		// (get) Token: 0x0601E44B RID: 123979 RVA: 0x0043DBA4 File Offset: 0x0043BDA4
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

		// Token: 0x0601E44C RID: 123980 RVA: 0x0043DBDC File Offset: 0x0043BDDC
		public Span<byte> GetCustomPlayerNameBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x0601E44D RID: 123981 RVA: 0x0043DBEC File Offset: 0x0043BDEC
		public byte[] GetCustomPlayerNameArray()
		{
			return this.__p.__vector_as_array<byte>(60);
		}

		// Token: 0x0601E44E RID: 123982 RVA: 0x0043DBFC File Offset: 0x0043BDFC
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

		// Token: 0x0601E44F RID: 123983 RVA: 0x0043DCFC File Offset: 0x0043BEFC
		public static void StartIEditorSaveConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(29);
		}

		// Token: 0x0601E450 RID: 123984 RVA: 0x0043DD06 File Offset: 0x0043BF06
		public static void AddAccount(FlatBufferBuilder builder, StringOffset accountOffset)
		{
			builder.AddOffset(0, accountOffset.Value, 0);
		}

		// Token: 0x0601E451 RID: 123985 RVA: 0x0043DD16 File Offset: 0x0043BF16
		public static void AddLoginAccountType(FlatBufferBuilder builder, EEditorLoginAccountType loginAccountType)
		{
			builder.AddByte(1, (byte)loginAccountType, 0);
		}

		// Token: 0x0601E452 RID: 123986 RVA: 0x0043DD21 File Offset: 0x0043BF21
		public static void AddCustomAccount(FlatBufferBuilder builder, StringOffset customAccountOffset)
		{
			builder.AddOffset(2, customAccountOffset.Value, 0);
		}

		// Token: 0x0601E453 RID: 123987 RVA: 0x0043DD31 File Offset: 0x0043BF31
		public static void AddArchiveAccount(FlatBufferBuilder builder, StringOffset archiveAccountOffset)
		{
			builder.AddOffset(3, archiveAccountOffset.Value, 0);
		}

		// Token: 0x0601E454 RID: 123988 RVA: 0x0043DD41 File Offset: 0x0043BF41
		public static void AddIsNetMode(FlatBufferBuilder builder, bool isNetMode)
		{
			builder.AddBool(4, isNetMode, false);
		}

		// Token: 0x0601E455 RID: 123989 RVA: 0x0043DD4C File Offset: 0x0043BF4C
		public static void AddIsMale(FlatBufferBuilder builder, bool isMale)
		{
			builder.AddBool(5, isMale, false);
		}

		// Token: 0x0601E456 RID: 123990 RVA: 0x0043DD57 File Offset: 0x0043BF57
		public static void AddUseTemp(FlatBufferBuilder builder, bool useTemp)
		{
			builder.AddBool(6, useTemp, false);
		}

		// Token: 0x0601E457 RID: 123991 RVA: 0x0043DD62 File Offset: 0x0043BF62
		public static void AddServerIp(FlatBufferBuilder builder, StringOffset serverIpOffset)
		{
			builder.AddOffset(7, serverIpOffset.Value, 0);
		}

		// Token: 0x0601E458 RID: 123992 RVA: 0x0043DD72 File Offset: 0x0043BF72
		public static void AddIsRelaxMode(FlatBufferBuilder builder, bool isRelaxMode)
		{
			builder.AddBool(8, isRelaxMode, false);
		}

		// Token: 0x0601E459 RID: 123993 RVA: 0x0043DD7D File Offset: 0x0043BF7D
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(9, dungeonId, 0);
		}

		// Token: 0x0601E45A RID: 123994 RVA: 0x0043DD89 File Offset: 0x0043BF89
		public static void AddIsBornAtCamera(FlatBufferBuilder builder, bool isBornAtCamera)
		{
			builder.AddBool(10, isBornAtCamera, false);
		}

		// Token: 0x0601E45B RID: 123995 RVA: 0x0043DD95 File Offset: 0x0043BF95
		public static void AddIsOpenDebugService(FlatBufferBuilder builder, bool isOpenDebugService)
		{
			builder.AddBool(11, isOpenDebugService, false);
		}

		// Token: 0x0601E45C RID: 123996 RVA: 0x0043DDA1 File Offset: 0x0043BFA1
		public static void AddDisableAutoStartServer(FlatBufferBuilder builder, bool disableAutoStartServer)
		{
			builder.AddBool(12, disableAutoStartServer, false);
		}

		// Token: 0x0601E45D RID: 123997 RVA: 0x0043DDAD File Offset: 0x0043BFAD
		public static void AddReloadEditorConfig(FlatBufferBuilder builder, bool reloadEditorConfig)
		{
			builder.AddBool(13, reloadEditorConfig, false);
		}

		// Token: 0x0601E45E RID: 123998 RVA: 0x0043DDB9 File Offset: 0x0043BFB9
		public static void AddReloadConfigTable(FlatBufferBuilder builder, bool reloadConfigTable)
		{
			builder.AddBool(14, reloadConfigTable, false);
		}

		// Token: 0x0601E45F RID: 123999 RVA: 0x0043DDC5 File Offset: 0x0043BFC5
		public static void AddIsLoginByNewUserName(FlatBufferBuilder builder, bool isLoginByNewUserName)
		{
			builder.AddBool(15, isLoginByNewUserName, false);
		}

		// Token: 0x0601E460 RID: 124000 RVA: 0x0043DDD1 File Offset: 0x0043BFD1
		public static void AddAccountType(FlatBufferBuilder builder, EAccountType accountType)
		{
			builder.AddByte(16, (byte)accountType, 0);
		}

		// Token: 0x0601E461 RID: 124001 RVA: 0x0043DDDD File Offset: 0x0043BFDD
		public static void AddGmPathOnLogin(FlatBufferBuilder builder, StringOffset gmPathOnLoginOffset)
		{
			builder.AddOffset(17, gmPathOnLoginOffset.Value, 0);
		}

		// Token: 0x0601E462 RID: 124002 RVA: 0x0043DDEE File Offset: 0x0043BFEE
		public static void AddEditorPort(FlatBufferBuilder builder, int editorPort)
		{
			builder.AddInt(18, editorPort, 0);
		}

		// Token: 0x0601E463 RID: 124003 RVA: 0x0043DDFA File Offset: 0x0043BFFA
		public static void AddGameClientGmPort(FlatBufferBuilder builder, int gameClientGmPort)
		{
			builder.AddInt(19, gameClientGmPort, 0);
		}

		// Token: 0x0601E464 RID: 124004 RVA: 0x0043DE06 File Offset: 0x0043C006
		public static void AddIsReLoadArchive(FlatBufferBuilder builder, bool isReLoadArchive)
		{
			builder.AddBool(20, isReLoadArchive, false);
		}

		// Token: 0x0601E465 RID: 124005 RVA: 0x0043DE12 File Offset: 0x0043C012
		public static void AddPackageVersion(FlatBufferBuilder builder, int packageVersion)
		{
			builder.AddInt(21, packageVersion, 0);
		}

		// Token: 0x0601E466 RID: 124006 RVA: 0x0043DE1E File Offset: 0x0043C01E
		public static void AddIsCustomAttachServerIp(FlatBufferBuilder builder, bool isCustomAttachServerIp)
		{
			builder.AddBool(22, isCustomAttachServerIp, false);
		}

		// Token: 0x0601E467 RID: 124007 RVA: 0x0043DE2A File Offset: 0x0043C02A
		public static void AddAttachServerIp(FlatBufferBuilder builder, StringOffset attachServerIpOffset)
		{
			builder.AddOffset(23, attachServerIpOffset.Value, 0);
		}

		// Token: 0x0601E468 RID: 124008 RVA: 0x0043DE3B File Offset: 0x0043C03B
		public static void AddAttachPlayerId(FlatBufferBuilder builder, int attachPlayerId)
		{
			builder.AddInt(24, attachPlayerId, 0);
		}

		// Token: 0x0601E469 RID: 124009 RVA: 0x0043DE47 File Offset: 0x0043C047
		public static void AddIsUseMobileStreamingParamsInPie(FlatBufferBuilder builder, bool isUseMobileStreamingParamsInPie)
		{
			builder.AddBool(25, isUseMobileStreamingParamsInPie, false);
		}

		// Token: 0x0601E46A RID: 124010 RVA: 0x0043DE53 File Offset: 0x0043C053
		public static void AddIsUseHighAoi(FlatBufferBuilder builder, bool isUseHighAoi)
		{
			builder.AddBool(26, isUseHighAoi, false);
		}

		// Token: 0x0601E46B RID: 124011 RVA: 0x0043DE5F File Offset: 0x0043C05F
		public static void AddIsStayInSubWp(FlatBufferBuilder builder, bool isStayInSubWp)
		{
			builder.AddBool(27, isStayInSubWp, false);
		}

		// Token: 0x0601E46C RID: 124012 RVA: 0x0043DE6B File Offset: 0x0043C06B
		public static void AddCustomPlayerName(FlatBufferBuilder builder, StringOffset customPlayerNameOffset)
		{
			builder.AddOffset(28, customPlayerNameOffset.Value, 0);
		}

		// Token: 0x0601E46D RID: 124013 RVA: 0x0043DE7C File Offset: 0x0043C07C
		public static Offset<IEditorSaveConfig> EndIEditorSaveConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEditorSaveConfig>(builder.EndTable());
		}

		// Token: 0x0601E46E RID: 124014 RVA: 0x0043DE8C File Offset: 0x0043C08C
		public IEditorSaveConfigT UnPack()
		{
			IEditorSaveConfigT editorSaveConfigT = new IEditorSaveConfigT();
			this.UnPackTo(editorSaveConfigT);
			return editorSaveConfigT;
		}

		// Token: 0x0601E46F RID: 124015 RVA: 0x0043DEA8 File Offset: 0x0043C0A8
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

		// Token: 0x0601E470 RID: 124016 RVA: 0x0043E014 File Offset: 0x0043C214
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

		// Token: 0x0400D80F RID: 55311
		private Table __p;
	}
}

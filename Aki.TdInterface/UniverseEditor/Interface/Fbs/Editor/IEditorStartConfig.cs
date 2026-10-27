using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200486E RID: 18542
	public struct IEditorStartConfig : IFlatbufferObject
	{
		// Token: 0x170085C5 RID: 34245
		// (get) Token: 0x0601CCE2 RID: 117986 RVA: 0x004121F4 File Offset: 0x004103F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CCE3 RID: 117987 RVA: 0x00412201 File Offset: 0x00410401
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CCE4 RID: 117988 RVA: 0x00412208 File Offset: 0x00410408
		public static IEditorStartConfig GetRootAsIEditorStartConfig(ByteBuffer _bb)
		{
			return IEditorStartConfig.GetRootAsIEditorStartConfig(_bb, default(IEditorStartConfig));
		}

		// Token: 0x0601CCE5 RID: 117989 RVA: 0x00412224 File Offset: 0x00410424
		public static IEditorStartConfig GetRootAsIEditorStartConfig(ByteBuffer _bb, IEditorStartConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CCE6 RID: 117990 RVA: 0x00412241 File Offset: 0x00410441
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CCE7 RID: 117991 RVA: 0x00412250 File Offset: 0x00410450
		public IEditorStartConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170085C6 RID: 34246
		// (get) Token: 0x0601CCE8 RID: 117992 RVA: 0x00412260 File Offset: 0x00410460
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

		// Token: 0x0601CCE9 RID: 117993 RVA: 0x00412297 File Offset: 0x00410497
		public Span<byte> GetAccountBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601CCEA RID: 117994 RVA: 0x004122A6 File Offset: 0x004104A6
		public byte[] GetAccountArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170085C7 RID: 34247
		// (get) Token: 0x0601CCEB RID: 117995 RVA: 0x004122B4 File Offset: 0x004104B4
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

		// Token: 0x170085C8 RID: 34248
		// (get) Token: 0x0601CCEC RID: 117996 RVA: 0x004122F0 File Offset: 0x004104F0
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

		// Token: 0x0601CCED RID: 117997 RVA: 0x00412327 File Offset: 0x00410527
		public Span<byte> GetCustomAccountBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601CCEE RID: 117998 RVA: 0x00412336 File Offset: 0x00410536
		public byte[] GetCustomAccountArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170085C9 RID: 34249
		// (get) Token: 0x0601CCEF RID: 117999 RVA: 0x00412344 File Offset: 0x00410544
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

		// Token: 0x0601CCF0 RID: 118000 RVA: 0x0041237C File Offset: 0x0041057C
		public Span<byte> GetArchiveAccountBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601CCF1 RID: 118001 RVA: 0x0041238C File Offset: 0x0041058C
		public byte[] GetArchiveAccountArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x170085CA RID: 34250
		// (get) Token: 0x0601CCF2 RID: 118002 RVA: 0x0041239C File Offset: 0x0041059C
		public bool IsNetMode
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085CB RID: 34251
		// (get) Token: 0x0601CCF3 RID: 118003 RVA: 0x004123DC File Offset: 0x004105DC
		public bool IsMale
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085CC RID: 34252
		// (get) Token: 0x0601CCF4 RID: 118004 RVA: 0x0041241C File Offset: 0x0041061C
		public bool UseTemp
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085CD RID: 34253
		// (get) Token: 0x0601CCF5 RID: 118005 RVA: 0x0041245C File Offset: 0x0041065C
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

		// Token: 0x0601CCF6 RID: 118006 RVA: 0x00412494 File Offset: 0x00410694
		public Span<byte> GetServerIpBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0601CCF7 RID: 118007 RVA: 0x004124A4 File Offset: 0x004106A4
		public byte[] GetServerIpArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x170085CE RID: 34254
		// (get) Token: 0x0601CCF8 RID: 118008 RVA: 0x004124B4 File Offset: 0x004106B4
		public bool IsRelaxMode
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085CF RID: 34255
		// (get) Token: 0x0601CCF9 RID: 118009 RVA: 0x004124F4 File Offset: 0x004106F4
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

		// Token: 0x170085D0 RID: 34256
		// (get) Token: 0x0601CCFA RID: 118010 RVA: 0x00412534 File Offset: 0x00410734
		public bool IsOpenDebugService
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085D1 RID: 34257
		// (get) Token: 0x0601CCFB RID: 118011 RVA: 0x00412574 File Offset: 0x00410774
		public bool DisableAutoStartServer
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085D2 RID: 34258
		// (get) Token: 0x0601CCFC RID: 118012 RVA: 0x004125B4 File Offset: 0x004107B4
		public bool ReloadEditorConfig
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085D3 RID: 34259
		// (get) Token: 0x0601CCFD RID: 118013 RVA: 0x004125F4 File Offset: 0x004107F4
		public bool ReloadConfigTable
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085D4 RID: 34260
		// (get) Token: 0x0601CCFE RID: 118014 RVA: 0x00412634 File Offset: 0x00410834
		public bool IsLoginByNewUserName
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085D5 RID: 34261
		// (get) Token: 0x0601CCFF RID: 118015 RVA: 0x00412674 File Offset: 0x00410874
		public EAccountType AccountType
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return EAccountType.Custom;
				}
				return (EAccountType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170085D6 RID: 34262
		// (get) Token: 0x0601CD00 RID: 118016 RVA: 0x004126B4 File Offset: 0x004108B4
		public string GmPathOnLogin
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CD01 RID: 118017 RVA: 0x004126EC File Offset: 0x004108EC
		public Span<byte> GetGmPathOnLoginBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0601CD02 RID: 118018 RVA: 0x004126FC File Offset: 0x004108FC
		public byte[] GetGmPathOnLoginArray()
		{
			return this.__p.__vector_as_array<byte>(36);
		}

		// Token: 0x170085D7 RID: 34263
		// (get) Token: 0x0601CD03 RID: 118019 RVA: 0x0041270C File Offset: 0x0041090C
		public int EditorPort
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170085D8 RID: 34264
		// (get) Token: 0x0601CD04 RID: 118020 RVA: 0x0041274C File Offset: 0x0041094C
		public int GameClientGmPort
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

		// Token: 0x170085D9 RID: 34265
		// (get) Token: 0x0601CD05 RID: 118021 RVA: 0x0041278C File Offset: 0x0041098C
		public bool IsReLoadArchive
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085DA RID: 34266
		// (get) Token: 0x0601CD06 RID: 118022 RVA: 0x004127CC File Offset: 0x004109CC
		public int PackageVersion
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170085DB RID: 34267
		// (get) Token: 0x0601CD07 RID: 118023 RVA: 0x0041280C File Offset: 0x00410A0C
		public bool IsCustomAttachServerIp
		{
			get
			{
				int num = this.__p.__offset(46);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085DC RID: 34268
		// (get) Token: 0x0601CD08 RID: 118024 RVA: 0x0041284C File Offset: 0x00410A4C
		public string AttachServerIp
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CD09 RID: 118025 RVA: 0x00412884 File Offset: 0x00410A84
		public Span<byte> GetAttachServerIpBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x0601CD0A RID: 118026 RVA: 0x00412894 File Offset: 0x00410A94
		public byte[] GetAttachServerIpArray()
		{
			return this.__p.__vector_as_array<byte>(48);
		}

		// Token: 0x170085DD RID: 34269
		// (get) Token: 0x0601CD0B RID: 118027 RVA: 0x004128A4 File Offset: 0x00410AA4
		public int AttachPlayerId
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170085DE RID: 34270
		// (get) Token: 0x0601CD0C RID: 118028 RVA: 0x004128E4 File Offset: 0x00410AE4
		public bool IsUseMobileStreamingParamsInPie
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085DF RID: 34271
		// (get) Token: 0x0601CD0D RID: 118029 RVA: 0x00412924 File Offset: 0x00410B24
		public bool IsUseHighAoi
		{
			get
			{
				int num = this.__p.__offset(54);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085E0 RID: 34272
		// (get) Token: 0x0601CD0E RID: 118030 RVA: 0x00412964 File Offset: 0x00410B64
		public bool IsStayInSubWp
		{
			get
			{
				int num = this.__p.__offset(56);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085E1 RID: 34273
		// (get) Token: 0x0601CD0F RID: 118031 RVA: 0x004129A4 File Offset: 0x00410BA4
		public string CustomPlayerName
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CD10 RID: 118032 RVA: 0x004129DC File Offset: 0x00410BDC
		public Span<byte> GetCustomPlayerNameBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x0601CD11 RID: 118033 RVA: 0x004129EC File Offset: 0x00410BEC
		public byte[] GetCustomPlayerNameArray()
		{
			return this.__p.__vector_as_array<byte>(58);
		}

		// Token: 0x0601CD12 RID: 118034 RVA: 0x004129FC File Offset: 0x00410BFC
		public string SubLevels(int j)
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170085E2 RID: 34274
		// (get) Token: 0x0601CD13 RID: 118035 RVA: 0x00412A38 File Offset: 0x00410C38
		public int SubLevelsLength
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601CD14 RID: 118036 RVA: 0x00412A64 File Offset: 0x00410C64
		public Record_Int_Strings? SubLevelsMap(int j)
		{
			int num = this.__p.__offset(62);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_Strings?(default(Record_Int_Strings).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170085E3 RID: 34275
		// (get) Token: 0x0601CD15 RID: 118037 RVA: 0x00412AC8 File Offset: 0x00410CC8
		public int SubLevelsMapLength
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601CD16 RID: 118038 RVA: 0x00412AF4 File Offset: 0x00410CF4
		public Record_Int_Ints? DataLayers(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_Ints?(default(Record_Int_Ints).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170085E4 RID: 34276
		// (get) Token: 0x0601CD17 RID: 118039 RVA: 0x00412B58 File Offset: 0x00410D58
		public int DataLayersLength
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601CD18 RID: 118040 RVA: 0x00412B84 File Offset: 0x00410D84
		public Record_Int_IDisableEntities? DisableEntities(int j)
		{
			int num = this.__p.__offset(66);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_IDisableEntities?(default(Record_Int_IDisableEntities).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170085E5 RID: 34277
		// (get) Token: 0x0601CD19 RID: 118041 RVA: 0x00412BE8 File Offset: 0x00410DE8
		public int DisableEntitiesLength
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601CD1A RID: 118042 RVA: 0x00412C14 File Offset: 0x00410E14
		public Record_Int_Int? DungeonIdMap(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_Int?(default(Record_Int_Int).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170085E6 RID: 34278
		// (get) Token: 0x0601CD1B RID: 118043 RVA: 0x00412C78 File Offset: 0x00410E78
		public int DungeonIdMapLength
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601CD1C RID: 118044 RVA: 0x00412CA4 File Offset: 0x00410EA4
		public int SkipQuests(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170085E7 RID: 34279
		// (get) Token: 0x0601CD1D RID: 118045 RVA: 0x00412CE4 File Offset: 0x00410EE4
		public int SkipQuestsLength
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601CD1E RID: 118046 RVA: 0x00412D10 File Offset: 0x00410F10
		public Span<int> GetSkipQuestsBytes()
		{
			return this.__p.__vector_as_span<int>(70, 4);
		}

		// Token: 0x0601CD1F RID: 118047 RVA: 0x00412D20 File Offset: 0x00410F20
		public int[] GetSkipQuestsArray()
		{
			return this.__p.__vector_as_array<int>(70);
		}

		// Token: 0x170085E8 RID: 34280
		// (get) Token: 0x0601CD20 RID: 118048 RVA: 0x00412D30 File Offset: 0x00410F30
		public bool IsBornAtCamera
		{
			get
			{
				int num = this.__p.__offset(72);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085E9 RID: 34281
		// (get) Token: 0x0601CD21 RID: 118049 RVA: 0x00412D70 File Offset: 0x00410F70
		public bool EnableDeltaReload
		{
			get
			{
				int num = this.__p.__offset(74);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085EA RID: 34282
		// (get) Token: 0x0601CD22 RID: 118050 RVA: 0x00412DB0 File Offset: 0x00410FB0
		public bool IsSkipQuests
		{
			get
			{
				int num = this.__p.__offset(76);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085EB RID: 34283
		// (get) Token: 0x0601CD23 RID: 118051 RVA: 0x00412DF0 File Offset: 0x00410FF0
		public bool IsUnlockExplore
		{
			get
			{
				int num = this.__p.__offset(78);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085EC RID: 34284
		// (get) Token: 0x0601CD24 RID: 118052 RVA: 0x00412E30 File Offset: 0x00411030
		public bool IsUnlockSpecial
		{
			get
			{
				int num = this.__p.__offset(80);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085ED RID: 34285
		// (get) Token: 0x0601CD25 RID: 118053 RVA: 0x00412E70 File Offset: 0x00411070
		public IPosA? Location
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170085EE RID: 34286
		// (get) Token: 0x0601CD26 RID: 118054 RVA: 0x00412ED0 File Offset: 0x004110D0
		public bool EnableAllSystemWithoutPopWin
		{
			get
			{
				int num = this.__p.__offset(84);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085EF RID: 34287
		// (get) Token: 0x0601CD27 RID: 118055 RVA: 0x00412F10 File Offset: 0x00411110
		public bool EnableAllTeleportPoints
		{
			get
			{
				int num = this.__p.__offset(86);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085F0 RID: 34288
		// (get) Token: 0x0601CD28 RID: 118056 RVA: 0x00412F50 File Offset: 0x00411150
		public bool IsUnlockAllFog
		{
			get
			{
				int num = this.__p.__offset(88);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085F1 RID: 34289
		// (get) Token: 0x0601CD29 RID: 118057 RVA: 0x00412F90 File Offset: 0x00411190
		public bool IsDisableTeleportDungeon
		{
			get
			{
				int num = this.__p.__offset(90);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601CD2A RID: 118058 RVA: 0x00412FD0 File Offset: 0x004111D0
		public static Offset<IEditorStartConfig> CreateIEditorStartConfig(FlatBufferBuilder builder, StringOffset AccountOffset = default(StringOffset), EEditorLoginAccountType LoginAccountType = EEditorLoginAccountType.Custom, StringOffset CustomAccountOffset = default(StringOffset), StringOffset ArchiveAccountOffset = default(StringOffset), bool IsNetMode = false, bool IsMale = false, bool UseTemp = false, StringOffset ServerIpOffset = default(StringOffset), bool IsRelaxMode = false, int DungeonId = 0, bool IsOpenDebugService = false, bool DisableAutoStartServer = false, bool ReloadEditorConfig = false, bool ReloadConfigTable = false, bool IsLoginByNewUserName = false, EAccountType AccountType = EAccountType.Custom, StringOffset GmPathOnLoginOffset = default(StringOffset), int EditorPort = 0, int GameClientGmPort = 0, bool IsReLoadArchive = false, int PackageVersion = 0, bool IsCustomAttachServerIp = false, StringOffset AttachServerIpOffset = default(StringOffset), int AttachPlayerId = 0, bool IsUseMobileStreamingParamsInPie = false, bool IsUseHighAoi = false, bool IsStayInSubWp = false, StringOffset CustomPlayerNameOffset = default(StringOffset), VectorOffset SubLevelsOffset = default(VectorOffset), VectorOffset SubLevelsMapOffset = default(VectorOffset), VectorOffset DataLayersOffset = default(VectorOffset), VectorOffset DisableEntitiesOffset = default(VectorOffset), VectorOffset DungeonIdMapOffset = default(VectorOffset), VectorOffset SkipQuestsOffset = default(VectorOffset), bool IsBornAtCamera = false, bool EnableDeltaReload = false, bool IsSkipQuests = false, bool IsUnlockExplore = false, bool IsUnlockSpecial = false, Offset<IPosA> LocationOffset = default(Offset<IPosA>), bool EnableAllSystemWithoutPopWin = false, bool EnableAllTeleportPoints = false, bool IsUnlockAllFog = false, bool IsDisableTeleportDungeon = false)
		{
			builder.StartTable(44);
			IEditorStartConfig.AddLocation(builder, LocationOffset);
			IEditorStartConfig.AddSkipQuests(builder, SkipQuestsOffset);
			IEditorStartConfig.AddDungeonIdMap(builder, DungeonIdMapOffset);
			IEditorStartConfig.AddDisableEntities(builder, DisableEntitiesOffset);
			IEditorStartConfig.AddDataLayers(builder, DataLayersOffset);
			IEditorStartConfig.AddSubLevelsMap(builder, SubLevelsMapOffset);
			IEditorStartConfig.AddSubLevels(builder, SubLevelsOffset);
			IEditorStartConfig.AddCustomPlayerName(builder, CustomPlayerNameOffset);
			IEditorStartConfig.AddAttachPlayerId(builder, AttachPlayerId);
			IEditorStartConfig.AddAttachServerIp(builder, AttachServerIpOffset);
			IEditorStartConfig.AddPackageVersion(builder, PackageVersion);
			IEditorStartConfig.AddGameClientGmPort(builder, GameClientGmPort);
			IEditorStartConfig.AddEditorPort(builder, EditorPort);
			IEditorStartConfig.AddGmPathOnLogin(builder, GmPathOnLoginOffset);
			IEditorStartConfig.AddDungeonId(builder, DungeonId);
			IEditorStartConfig.AddServerIp(builder, ServerIpOffset);
			IEditorStartConfig.AddArchiveAccount(builder, ArchiveAccountOffset);
			IEditorStartConfig.AddCustomAccount(builder, CustomAccountOffset);
			IEditorStartConfig.AddAccount(builder, AccountOffset);
			IEditorStartConfig.AddIsDisableTeleportDungeon(builder, IsDisableTeleportDungeon);
			IEditorStartConfig.AddIsUnlockAllFog(builder, IsUnlockAllFog);
			IEditorStartConfig.AddEnableAllTeleportPoints(builder, EnableAllTeleportPoints);
			IEditorStartConfig.AddEnableAllSystemWithoutPopWin(builder, EnableAllSystemWithoutPopWin);
			IEditorStartConfig.AddIsUnlockSpecial(builder, IsUnlockSpecial);
			IEditorStartConfig.AddIsUnlockExplore(builder, IsUnlockExplore);
			IEditorStartConfig.AddIsSkipQuests(builder, IsSkipQuests);
			IEditorStartConfig.AddEnableDeltaReload(builder, EnableDeltaReload);
			IEditorStartConfig.AddIsBornAtCamera(builder, IsBornAtCamera);
			IEditorStartConfig.AddIsStayInSubWp(builder, IsStayInSubWp);
			IEditorStartConfig.AddIsUseHighAoi(builder, IsUseHighAoi);
			IEditorStartConfig.AddIsUseMobileStreamingParamsInPie(builder, IsUseMobileStreamingParamsInPie);
			IEditorStartConfig.AddIsCustomAttachServerIp(builder, IsCustomAttachServerIp);
			IEditorStartConfig.AddIsReLoadArchive(builder, IsReLoadArchive);
			IEditorStartConfig.AddAccountType(builder, AccountType);
			IEditorStartConfig.AddIsLoginByNewUserName(builder, IsLoginByNewUserName);
			IEditorStartConfig.AddReloadConfigTable(builder, ReloadConfigTable);
			IEditorStartConfig.AddReloadEditorConfig(builder, ReloadEditorConfig);
			IEditorStartConfig.AddDisableAutoStartServer(builder, DisableAutoStartServer);
			IEditorStartConfig.AddIsOpenDebugService(builder, IsOpenDebugService);
			IEditorStartConfig.AddIsRelaxMode(builder, IsRelaxMode);
			IEditorStartConfig.AddUseTemp(builder, UseTemp);
			IEditorStartConfig.AddIsMale(builder, IsMale);
			IEditorStartConfig.AddIsNetMode(builder, IsNetMode);
			IEditorStartConfig.AddLoginAccountType(builder, LoginAccountType);
			return IEditorStartConfig.EndIEditorStartConfig(builder);
		}

		// Token: 0x0601CD2B RID: 118059 RVA: 0x00413148 File Offset: 0x00411348
		public static void StartIEditorStartConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(44);
		}

		// Token: 0x0601CD2C RID: 118060 RVA: 0x00413152 File Offset: 0x00411352
		public static void AddAccount(FlatBufferBuilder builder, StringOffset accountOffset)
		{
			builder.AddOffset(0, accountOffset.Value, 0);
		}

		// Token: 0x0601CD2D RID: 118061 RVA: 0x00413162 File Offset: 0x00411362
		public static void AddLoginAccountType(FlatBufferBuilder builder, EEditorLoginAccountType loginAccountType)
		{
			builder.AddByte(1, (byte)loginAccountType, 0);
		}

		// Token: 0x0601CD2E RID: 118062 RVA: 0x0041316D File Offset: 0x0041136D
		public static void AddCustomAccount(FlatBufferBuilder builder, StringOffset customAccountOffset)
		{
			builder.AddOffset(2, customAccountOffset.Value, 0);
		}

		// Token: 0x0601CD2F RID: 118063 RVA: 0x0041317D File Offset: 0x0041137D
		public static void AddArchiveAccount(FlatBufferBuilder builder, StringOffset archiveAccountOffset)
		{
			builder.AddOffset(3, archiveAccountOffset.Value, 0);
		}

		// Token: 0x0601CD30 RID: 118064 RVA: 0x0041318D File Offset: 0x0041138D
		public static void AddIsNetMode(FlatBufferBuilder builder, bool isNetMode)
		{
			builder.AddBool(4, isNetMode, false);
		}

		// Token: 0x0601CD31 RID: 118065 RVA: 0x00413198 File Offset: 0x00411398
		public static void AddIsMale(FlatBufferBuilder builder, bool isMale)
		{
			builder.AddBool(5, isMale, false);
		}

		// Token: 0x0601CD32 RID: 118066 RVA: 0x004131A3 File Offset: 0x004113A3
		public static void AddUseTemp(FlatBufferBuilder builder, bool useTemp)
		{
			builder.AddBool(6, useTemp, false);
		}

		// Token: 0x0601CD33 RID: 118067 RVA: 0x004131AE File Offset: 0x004113AE
		public static void AddServerIp(FlatBufferBuilder builder, StringOffset serverIpOffset)
		{
			builder.AddOffset(7, serverIpOffset.Value, 0);
		}

		// Token: 0x0601CD34 RID: 118068 RVA: 0x004131BE File Offset: 0x004113BE
		public static void AddIsRelaxMode(FlatBufferBuilder builder, bool isRelaxMode)
		{
			builder.AddBool(8, isRelaxMode, false);
		}

		// Token: 0x0601CD35 RID: 118069 RVA: 0x004131C9 File Offset: 0x004113C9
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(9, dungeonId, 0);
		}

		// Token: 0x0601CD36 RID: 118070 RVA: 0x004131D5 File Offset: 0x004113D5
		public static void AddIsOpenDebugService(FlatBufferBuilder builder, bool isOpenDebugService)
		{
			builder.AddBool(10, isOpenDebugService, false);
		}

		// Token: 0x0601CD37 RID: 118071 RVA: 0x004131E1 File Offset: 0x004113E1
		public static void AddDisableAutoStartServer(FlatBufferBuilder builder, bool disableAutoStartServer)
		{
			builder.AddBool(11, disableAutoStartServer, false);
		}

		// Token: 0x0601CD38 RID: 118072 RVA: 0x004131ED File Offset: 0x004113ED
		public static void AddReloadEditorConfig(FlatBufferBuilder builder, bool reloadEditorConfig)
		{
			builder.AddBool(12, reloadEditorConfig, false);
		}

		// Token: 0x0601CD39 RID: 118073 RVA: 0x004131F9 File Offset: 0x004113F9
		public static void AddReloadConfigTable(FlatBufferBuilder builder, bool reloadConfigTable)
		{
			builder.AddBool(13, reloadConfigTable, false);
		}

		// Token: 0x0601CD3A RID: 118074 RVA: 0x00413205 File Offset: 0x00411405
		public static void AddIsLoginByNewUserName(FlatBufferBuilder builder, bool isLoginByNewUserName)
		{
			builder.AddBool(14, isLoginByNewUserName, false);
		}

		// Token: 0x0601CD3B RID: 118075 RVA: 0x00413211 File Offset: 0x00411411
		public static void AddAccountType(FlatBufferBuilder builder, EAccountType accountType)
		{
			builder.AddByte(15, (byte)accountType, 0);
		}

		// Token: 0x0601CD3C RID: 118076 RVA: 0x0041321D File Offset: 0x0041141D
		public static void AddGmPathOnLogin(FlatBufferBuilder builder, StringOffset gmPathOnLoginOffset)
		{
			builder.AddOffset(16, gmPathOnLoginOffset.Value, 0);
		}

		// Token: 0x0601CD3D RID: 118077 RVA: 0x0041322E File Offset: 0x0041142E
		public static void AddEditorPort(FlatBufferBuilder builder, int editorPort)
		{
			builder.AddInt(17, editorPort, 0);
		}

		// Token: 0x0601CD3E RID: 118078 RVA: 0x0041323A File Offset: 0x0041143A
		public static void AddGameClientGmPort(FlatBufferBuilder builder, int gameClientGmPort)
		{
			builder.AddInt(18, gameClientGmPort, 0);
		}

		// Token: 0x0601CD3F RID: 118079 RVA: 0x00413246 File Offset: 0x00411446
		public static void AddIsReLoadArchive(FlatBufferBuilder builder, bool isReLoadArchive)
		{
			builder.AddBool(19, isReLoadArchive, false);
		}

		// Token: 0x0601CD40 RID: 118080 RVA: 0x00413252 File Offset: 0x00411452
		public static void AddPackageVersion(FlatBufferBuilder builder, int packageVersion)
		{
			builder.AddInt(20, packageVersion, 0);
		}

		// Token: 0x0601CD41 RID: 118081 RVA: 0x0041325E File Offset: 0x0041145E
		public static void AddIsCustomAttachServerIp(FlatBufferBuilder builder, bool isCustomAttachServerIp)
		{
			builder.AddBool(21, isCustomAttachServerIp, false);
		}

		// Token: 0x0601CD42 RID: 118082 RVA: 0x0041326A File Offset: 0x0041146A
		public static void AddAttachServerIp(FlatBufferBuilder builder, StringOffset attachServerIpOffset)
		{
			builder.AddOffset(22, attachServerIpOffset.Value, 0);
		}

		// Token: 0x0601CD43 RID: 118083 RVA: 0x0041327B File Offset: 0x0041147B
		public static void AddAttachPlayerId(FlatBufferBuilder builder, int attachPlayerId)
		{
			builder.AddInt(23, attachPlayerId, 0);
		}

		// Token: 0x0601CD44 RID: 118084 RVA: 0x00413287 File Offset: 0x00411487
		public static void AddIsUseMobileStreamingParamsInPie(FlatBufferBuilder builder, bool isUseMobileStreamingParamsInPie)
		{
			builder.AddBool(24, isUseMobileStreamingParamsInPie, false);
		}

		// Token: 0x0601CD45 RID: 118085 RVA: 0x00413293 File Offset: 0x00411493
		public static void AddIsUseHighAoi(FlatBufferBuilder builder, bool isUseHighAoi)
		{
			builder.AddBool(25, isUseHighAoi, false);
		}

		// Token: 0x0601CD46 RID: 118086 RVA: 0x0041329F File Offset: 0x0041149F
		public static void AddIsStayInSubWp(FlatBufferBuilder builder, bool isStayInSubWp)
		{
			builder.AddBool(26, isStayInSubWp, false);
		}

		// Token: 0x0601CD47 RID: 118087 RVA: 0x004132AB File Offset: 0x004114AB
		public static void AddCustomPlayerName(FlatBufferBuilder builder, StringOffset customPlayerNameOffset)
		{
			builder.AddOffset(27, customPlayerNameOffset.Value, 0);
		}

		// Token: 0x0601CD48 RID: 118088 RVA: 0x004132BC File Offset: 0x004114BC
		public static void AddSubLevels(FlatBufferBuilder builder, VectorOffset subLevelsOffset)
		{
			builder.AddOffset(28, subLevelsOffset.Value, 0);
		}

		// Token: 0x0601CD49 RID: 118089 RVA: 0x004132D0 File Offset: 0x004114D0
		public static VectorOffset CreateSubLevelsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CD4A RID: 118090 RVA: 0x00413310 File Offset: 0x00411510
		public static VectorOffset CreateSubLevelsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CD4B RID: 118091 RVA: 0x0041332A File Offset: 0x0041152A
		public static VectorOffset CreateSubLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CD4C RID: 118092 RVA: 0x00413348 File Offset: 0x00411548
		public static VectorOffset CreateSubLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CD4D RID: 118093 RVA: 0x00413361 File Offset: 0x00411561
		public static void StartSubLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601CD4E RID: 118094 RVA: 0x0041336C File Offset: 0x0041156C
		public static void AddSubLevelsMap(FlatBufferBuilder builder, VectorOffset subLevelsMapOffset)
		{
			builder.AddOffset(29, subLevelsMapOffset.Value, 0);
		}

		// Token: 0x0601CD4F RID: 118095 RVA: 0x00413380 File Offset: 0x00411580
		public static VectorOffset CreateSubLevelsMapVector(FlatBufferBuilder builder, Offset<Record_Int_Strings>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CD50 RID: 118096 RVA: 0x004133C0 File Offset: 0x004115C0
		public static VectorOffset CreateSubLevelsMapVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_Strings>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_Strings>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CD51 RID: 118097 RVA: 0x004133DA File Offset: 0x004115DA
		public static VectorOffset CreateSubLevelsMapVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_Strings>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_Strings>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CD52 RID: 118098 RVA: 0x004133F8 File Offset: 0x004115F8
		public static VectorOffset CreateSubLevelsMapVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_Strings>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CD53 RID: 118099 RVA: 0x00413411 File Offset: 0x00411611
		public static void StartSubLevelsMapVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601CD54 RID: 118100 RVA: 0x0041341C File Offset: 0x0041161C
		public static void AddDataLayers(FlatBufferBuilder builder, VectorOffset dataLayersOffset)
		{
			builder.AddOffset(30, dataLayersOffset.Value, 0);
		}

		// Token: 0x0601CD55 RID: 118101 RVA: 0x00413430 File Offset: 0x00411630
		public static VectorOffset CreateDataLayersVector(FlatBufferBuilder builder, Offset<Record_Int_Ints>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CD56 RID: 118102 RVA: 0x00413470 File Offset: 0x00411670
		public static VectorOffset CreateDataLayersVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_Ints>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_Ints>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CD57 RID: 118103 RVA: 0x0041348A File Offset: 0x0041168A
		public static VectorOffset CreateDataLayersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_Ints>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_Ints>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CD58 RID: 118104 RVA: 0x004134A8 File Offset: 0x004116A8
		public static VectorOffset CreateDataLayersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_Ints>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CD59 RID: 118105 RVA: 0x004134C1 File Offset: 0x004116C1
		public static void StartDataLayersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601CD5A RID: 118106 RVA: 0x004134CC File Offset: 0x004116CC
		public static void AddDisableEntities(FlatBufferBuilder builder, VectorOffset disableEntitiesOffset)
		{
			builder.AddOffset(31, disableEntitiesOffset.Value, 0);
		}

		// Token: 0x0601CD5B RID: 118107 RVA: 0x004134E0 File Offset: 0x004116E0
		public static VectorOffset CreateDisableEntitiesVector(FlatBufferBuilder builder, Offset<Record_Int_IDisableEntities>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CD5C RID: 118108 RVA: 0x00413520 File Offset: 0x00411720
		public static VectorOffset CreateDisableEntitiesVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_IDisableEntities>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_IDisableEntities>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CD5D RID: 118109 RVA: 0x0041353A File Offset: 0x0041173A
		public static VectorOffset CreateDisableEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_IDisableEntities>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_IDisableEntities>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CD5E RID: 118110 RVA: 0x00413558 File Offset: 0x00411758
		public static VectorOffset CreateDisableEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_IDisableEntities>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CD5F RID: 118111 RVA: 0x00413571 File Offset: 0x00411771
		public static void StartDisableEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601CD60 RID: 118112 RVA: 0x0041357C File Offset: 0x0041177C
		public static void AddDungeonIdMap(FlatBufferBuilder builder, VectorOffset dungeonIdMapOffset)
		{
			builder.AddOffset(32, dungeonIdMapOffset.Value, 0);
		}

		// Token: 0x0601CD61 RID: 118113 RVA: 0x00413590 File Offset: 0x00411790
		public static VectorOffset CreateDungeonIdMapVector(FlatBufferBuilder builder, Offset<Record_Int_Int>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CD62 RID: 118114 RVA: 0x004135D0 File Offset: 0x004117D0
		public static VectorOffset CreateDungeonIdMapVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_Int>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_Int>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CD63 RID: 118115 RVA: 0x004135EA File Offset: 0x004117EA
		public static VectorOffset CreateDungeonIdMapVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_Int>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_Int>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CD64 RID: 118116 RVA: 0x00413608 File Offset: 0x00411808
		public static VectorOffset CreateDungeonIdMapVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_Int>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CD65 RID: 118117 RVA: 0x00413621 File Offset: 0x00411821
		public static void StartDungeonIdMapVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601CD66 RID: 118118 RVA: 0x0041362C File Offset: 0x0041182C
		public static void AddSkipQuests(FlatBufferBuilder builder, VectorOffset skipQuestsOffset)
		{
			builder.AddOffset(33, skipQuestsOffset.Value, 0);
		}

		// Token: 0x0601CD67 RID: 118119 RVA: 0x00413640 File Offset: 0x00411840
		public static VectorOffset CreateSkipQuestsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CD68 RID: 118120 RVA: 0x00413677 File Offset: 0x00411877
		public static VectorOffset CreateSkipQuestsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CD69 RID: 118121 RVA: 0x00413691 File Offset: 0x00411891
		public static VectorOffset CreateSkipQuestsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CD6A RID: 118122 RVA: 0x004136AF File Offset: 0x004118AF
		public static VectorOffset CreateSkipQuestsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CD6B RID: 118123 RVA: 0x004136C8 File Offset: 0x004118C8
		public static void StartSkipQuestsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601CD6C RID: 118124 RVA: 0x004136D3 File Offset: 0x004118D3
		public static void AddIsBornAtCamera(FlatBufferBuilder builder, bool isBornAtCamera)
		{
			builder.AddBool(34, isBornAtCamera, false);
		}

		// Token: 0x0601CD6D RID: 118125 RVA: 0x004136DF File Offset: 0x004118DF
		public static void AddEnableDeltaReload(FlatBufferBuilder builder, bool enableDeltaReload)
		{
			builder.AddBool(35, enableDeltaReload, false);
		}

		// Token: 0x0601CD6E RID: 118126 RVA: 0x004136EB File Offset: 0x004118EB
		public static void AddIsSkipQuests(FlatBufferBuilder builder, bool isSkipQuests)
		{
			builder.AddBool(36, isSkipQuests, false);
		}

		// Token: 0x0601CD6F RID: 118127 RVA: 0x004136F7 File Offset: 0x004118F7
		public static void AddIsUnlockExplore(FlatBufferBuilder builder, bool isUnlockExplore)
		{
			builder.AddBool(37, isUnlockExplore, false);
		}

		// Token: 0x0601CD70 RID: 118128 RVA: 0x00413703 File Offset: 0x00411903
		public static void AddIsUnlockSpecial(FlatBufferBuilder builder, bool isUnlockSpecial)
		{
			builder.AddBool(38, isUnlockSpecial, false);
		}

		// Token: 0x0601CD71 RID: 118129 RVA: 0x0041370F File Offset: 0x0041190F
		public static void AddLocation(FlatBufferBuilder builder, Offset<IPosA> locationOffset)
		{
			builder.AddOffset(39, locationOffset.Value, 0);
		}

		// Token: 0x0601CD72 RID: 118130 RVA: 0x00413720 File Offset: 0x00411920
		public static void AddEnableAllSystemWithoutPopWin(FlatBufferBuilder builder, bool enableAllSystemWithoutPopWin)
		{
			builder.AddBool(40, enableAllSystemWithoutPopWin, false);
		}

		// Token: 0x0601CD73 RID: 118131 RVA: 0x0041372C File Offset: 0x0041192C
		public static void AddEnableAllTeleportPoints(FlatBufferBuilder builder, bool enableAllTeleportPoints)
		{
			builder.AddBool(41, enableAllTeleportPoints, false);
		}

		// Token: 0x0601CD74 RID: 118132 RVA: 0x00413738 File Offset: 0x00411938
		public static void AddIsUnlockAllFog(FlatBufferBuilder builder, bool isUnlockAllFog)
		{
			builder.AddBool(42, isUnlockAllFog, false);
		}

		// Token: 0x0601CD75 RID: 118133 RVA: 0x00413744 File Offset: 0x00411944
		public static void AddIsDisableTeleportDungeon(FlatBufferBuilder builder, bool isDisableTeleportDungeon)
		{
			builder.AddBool(43, isDisableTeleportDungeon, false);
		}

		// Token: 0x0601CD76 RID: 118134 RVA: 0x00413750 File Offset: 0x00411950
		public static Offset<IEditorStartConfig> EndIEditorStartConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEditorStartConfig>(builder.EndTable());
		}

		// Token: 0x0601CD77 RID: 118135 RVA: 0x00413760 File Offset: 0x00411960
		public IEditorStartConfigT UnPack()
		{
			IEditorStartConfigT editorStartConfigT = new IEditorStartConfigT();
			this.UnPackTo(editorStartConfigT);
			return editorStartConfigT;
		}

		// Token: 0x0601CD78 RID: 118136 RVA: 0x0041377C File Offset: 0x0041197C
		public void UnPackTo(IEditorStartConfigT _o)
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
			_o.SubLevels = new List<string>();
			for (int i = 0; i < this.SubLevelsLength; i++)
			{
				_o.SubLevels.Add(this.SubLevels(i));
			}
			_o.SubLevelsMap = new List<Record_Int_StringsT>();
			for (int j = 0; j < this.SubLevelsMapLength; j++)
			{
				_o.SubLevelsMap.Add((this.SubLevelsMap(j) != null) ? this.SubLevelsMap(j).Value.UnPack() : null);
			}
			_o.DataLayers = new List<Record_Int_IntsT>();
			for (int k = 0; k < this.DataLayersLength; k++)
			{
				_o.DataLayers.Add((this.DataLayers(k) != null) ? this.DataLayers(k).Value.UnPack() : null);
			}
			_o.DisableEntities = new List<Record_Int_IDisableEntitiesT>();
			for (int l = 0; l < this.DisableEntitiesLength; l++)
			{
				_o.DisableEntities.Add((this.DisableEntities(l) != null) ? this.DisableEntities(l).Value.UnPack() : null);
			}
			_o.DungeonIdMap = new List<Record_Int_IntT>();
			for (int m = 0; m < this.DungeonIdMapLength; m++)
			{
				_o.DungeonIdMap.Add((this.DungeonIdMap(m) != null) ? this.DungeonIdMap(m).Value.UnPack() : null);
			}
			_o.SkipQuests = new List<int>();
			for (int n = 0; n < this.SkipQuestsLength; n++)
			{
				_o.SkipQuests.Add(this.SkipQuests(n));
			}
			_o.IsBornAtCamera = this.IsBornAtCamera;
			_o.EnableDeltaReload = this.EnableDeltaReload;
			_o.IsSkipQuests = this.IsSkipQuests;
			_o.IsUnlockExplore = this.IsUnlockExplore;
			_o.IsUnlockSpecial = this.IsUnlockSpecial;
			_o.Location = ((this.Location != null) ? this.Location.Value.UnPack() : null);
			_o.EnableAllSystemWithoutPopWin = this.EnableAllSystemWithoutPopWin;
			_o.EnableAllTeleportPoints = this.EnableAllTeleportPoints;
			_o.IsUnlockAllFog = this.IsUnlockAllFog;
			_o.IsDisableTeleportDungeon = this.IsDisableTeleportDungeon;
		}

		// Token: 0x0601CD79 RID: 118137 RVA: 0x00413B3C File Offset: 0x00411D3C
		public static Offset<IEditorStartConfig> Pack(FlatBufferBuilder builder, IEditorStartConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEditorStartConfig>);
			}
			StringOffset accountOffset = (_o.Account == null) ? default(StringOffset) : builder.CreateString(_o.Account);
			StringOffset customAccountOffset = (_o.CustomAccount == null) ? default(StringOffset) : builder.CreateString(_o.CustomAccount);
			StringOffset archiveAccountOffset = (_o.ArchiveAccount == null) ? default(StringOffset) : builder.CreateString(_o.ArchiveAccount);
			StringOffset serverIpOffset = (_o.ServerIp == null) ? default(StringOffset) : builder.CreateString(_o.ServerIp);
			StringOffset gmPathOnLoginOffset = (_o.GmPathOnLogin == null) ? default(StringOffset) : builder.CreateString(_o.GmPathOnLogin);
			StringOffset attachServerIpOffset = (_o.AttachServerIp == null) ? default(StringOffset) : builder.CreateString(_o.AttachServerIp);
			StringOffset customPlayerNameOffset = (_o.CustomPlayerName == null) ? default(StringOffset) : builder.CreateString(_o.CustomPlayerName);
			VectorOffset subLevelsOffset = default(VectorOffset);
			if (_o.SubLevels != null)
			{
				StringOffset[] array = new StringOffset[_o.SubLevels.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.SubLevels[i]);
				}
				subLevelsOffset = IEditorStartConfig.CreateSubLevelsVector(builder, array);
			}
			VectorOffset subLevelsMapOffset = default(VectorOffset);
			if (_o.SubLevelsMap != null)
			{
				Offset<Record_Int_Strings>[] array2 = new Offset<Record_Int_Strings>[_o.SubLevelsMap.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = Record_Int_Strings.Pack(builder, _o.SubLevelsMap[j]);
				}
				subLevelsMapOffset = IEditorStartConfig.CreateSubLevelsMapVector(builder, array2);
			}
			VectorOffset dataLayersOffset = default(VectorOffset);
			if (_o.DataLayers != null)
			{
				Offset<Record_Int_Ints>[] array3 = new Offset<Record_Int_Ints>[_o.DataLayers.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = Record_Int_Ints.Pack(builder, _o.DataLayers[k]);
				}
				dataLayersOffset = IEditorStartConfig.CreateDataLayersVector(builder, array3);
			}
			VectorOffset disableEntitiesOffset = default(VectorOffset);
			if (_o.DisableEntities != null)
			{
				Offset<Record_Int_IDisableEntities>[] array4 = new Offset<Record_Int_IDisableEntities>[_o.DisableEntities.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = Record_Int_IDisableEntities.Pack(builder, _o.DisableEntities[l]);
				}
				disableEntitiesOffset = IEditorStartConfig.CreateDisableEntitiesVector(builder, array4);
			}
			VectorOffset dungeonIdMapOffset = default(VectorOffset);
			if (_o.DungeonIdMap != null)
			{
				Offset<Record_Int_Int>[] array5 = new Offset<Record_Int_Int>[_o.DungeonIdMap.Count];
				for (int m = 0; m < array5.Length; m++)
				{
					array5[m] = Record_Int_Int.Pack(builder, _o.DungeonIdMap[m]);
				}
				dungeonIdMapOffset = IEditorStartConfig.CreateDungeonIdMapVector(builder, array5);
			}
			VectorOffset skipQuestsOffset = default(VectorOffset);
			if (_o.SkipQuests != null)
			{
				int[] data = _o.SkipQuests.ToArray();
				skipQuestsOffset = IEditorStartConfig.CreateSkipQuestsVector(builder, data);
			}
			Offset<IPosA> locationOffset = (_o.Location == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.Location);
			return IEditorStartConfig.CreateIEditorStartConfig(builder, accountOffset, _o.LoginAccountType, customAccountOffset, archiveAccountOffset, _o.IsNetMode, _o.IsMale, _o.UseTemp, serverIpOffset, _o.IsRelaxMode, _o.DungeonId, _o.IsOpenDebugService, _o.DisableAutoStartServer, _o.ReloadEditorConfig, _o.ReloadConfigTable, _o.IsLoginByNewUserName, _o.AccountType, gmPathOnLoginOffset, _o.EditorPort, _o.GameClientGmPort, _o.IsReLoadArchive, _o.PackageVersion, _o.IsCustomAttachServerIp, attachServerIpOffset, _o.AttachPlayerId, _o.IsUseMobileStreamingParamsInPie, _o.IsUseHighAoi, _o.IsStayInSubWp, customPlayerNameOffset, subLevelsOffset, subLevelsMapOffset, dataLayersOffset, disableEntitiesOffset, dungeonIdMapOffset, skipQuestsOffset, _o.IsBornAtCamera, _o.EnableDeltaReload, _o.IsSkipQuests, _o.IsUnlockExplore, _o.IsUnlockSpecial, locationOffset, _o.EnableAllSystemWithoutPopWin, _o.EnableAllTeleportPoints, _o.IsUnlockAllFog, _o.IsDisableTeleportDungeon);
		}

		// Token: 0x0400CDF9 RID: 52729
		private Table __p;
	}
}

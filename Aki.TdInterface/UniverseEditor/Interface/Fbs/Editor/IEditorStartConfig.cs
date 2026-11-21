using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CD3 RID: 19667
	public struct IEditorStartConfig : IFlatbufferObject
	{
		// Token: 0x17008C0F RID: 35855
		// (get) Token: 0x0601E4D3 RID: 124115 RVA: 0x0043EA9C File Offset: 0x0043CC9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E4D4 RID: 124116 RVA: 0x0043EAA9 File Offset: 0x0043CCA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E4D5 RID: 124117 RVA: 0x0043EAB0 File Offset: 0x0043CCB0
		public static IEditorStartConfig GetRootAsIEditorStartConfig(ByteBuffer _bb)
		{
			return IEditorStartConfig.GetRootAsIEditorStartConfig(_bb, default(IEditorStartConfig));
		}

		// Token: 0x0601E4D6 RID: 124118 RVA: 0x0043EACC File Offset: 0x0043CCCC
		public static IEditorStartConfig GetRootAsIEditorStartConfig(ByteBuffer _bb, IEditorStartConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E4D7 RID: 124119 RVA: 0x0043EAE9 File Offset: 0x0043CCE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E4D8 RID: 124120 RVA: 0x0043EAF8 File Offset: 0x0043CCF8
		public IEditorStartConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C10 RID: 35856
		// (get) Token: 0x0601E4D9 RID: 124121 RVA: 0x0043EB08 File Offset: 0x0043CD08
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

		// Token: 0x0601E4DA RID: 124122 RVA: 0x0043EB3F File Offset: 0x0043CD3F
		public Span<byte> GetAccountBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601E4DB RID: 124123 RVA: 0x0043EB4E File Offset: 0x0043CD4E
		public byte[] GetAccountArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008C11 RID: 35857
		// (get) Token: 0x0601E4DC RID: 124124 RVA: 0x0043EB5C File Offset: 0x0043CD5C
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

		// Token: 0x17008C12 RID: 35858
		// (get) Token: 0x0601E4DD RID: 124125 RVA: 0x0043EB98 File Offset: 0x0043CD98
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

		// Token: 0x0601E4DE RID: 124126 RVA: 0x0043EBCF File Offset: 0x0043CDCF
		public Span<byte> GetCustomAccountBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601E4DF RID: 124127 RVA: 0x0043EBDE File Offset: 0x0043CDDE
		public byte[] GetCustomAccountArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008C13 RID: 35859
		// (get) Token: 0x0601E4E0 RID: 124128 RVA: 0x0043EBEC File Offset: 0x0043CDEC
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

		// Token: 0x0601E4E1 RID: 124129 RVA: 0x0043EC24 File Offset: 0x0043CE24
		public Span<byte> GetArchiveAccountBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601E4E2 RID: 124130 RVA: 0x0043EC34 File Offset: 0x0043CE34
		public byte[] GetArchiveAccountArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17008C14 RID: 35860
		// (get) Token: 0x0601E4E3 RID: 124131 RVA: 0x0043EC44 File Offset: 0x0043CE44
		public bool IsNetMode
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C15 RID: 35861
		// (get) Token: 0x0601E4E4 RID: 124132 RVA: 0x0043EC84 File Offset: 0x0043CE84
		public bool IsMale
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C16 RID: 35862
		// (get) Token: 0x0601E4E5 RID: 124133 RVA: 0x0043ECC4 File Offset: 0x0043CEC4
		public bool UseTemp
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C17 RID: 35863
		// (get) Token: 0x0601E4E6 RID: 124134 RVA: 0x0043ED04 File Offset: 0x0043CF04
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

		// Token: 0x0601E4E7 RID: 124135 RVA: 0x0043ED3C File Offset: 0x0043CF3C
		public Span<byte> GetServerIpBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0601E4E8 RID: 124136 RVA: 0x0043ED4C File Offset: 0x0043CF4C
		public byte[] GetServerIpArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x17008C18 RID: 35864
		// (get) Token: 0x0601E4E9 RID: 124137 RVA: 0x0043ED5C File Offset: 0x0043CF5C
		public bool IsRelaxMode
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C19 RID: 35865
		// (get) Token: 0x0601E4EA RID: 124138 RVA: 0x0043ED9C File Offset: 0x0043CF9C
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

		// Token: 0x17008C1A RID: 35866
		// (get) Token: 0x0601E4EB RID: 124139 RVA: 0x0043EDDC File Offset: 0x0043CFDC
		public bool IsOpenDebugService
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C1B RID: 35867
		// (get) Token: 0x0601E4EC RID: 124140 RVA: 0x0043EE1C File Offset: 0x0043D01C
		public bool DisableAutoStartServer
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C1C RID: 35868
		// (get) Token: 0x0601E4ED RID: 124141 RVA: 0x0043EE5C File Offset: 0x0043D05C
		public bool ReloadEditorConfig
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C1D RID: 35869
		// (get) Token: 0x0601E4EE RID: 124142 RVA: 0x0043EE9C File Offset: 0x0043D09C
		public bool ReloadConfigTable
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C1E RID: 35870
		// (get) Token: 0x0601E4EF RID: 124143 RVA: 0x0043EEDC File Offset: 0x0043D0DC
		public bool IsLoginByNewUserName
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C1F RID: 35871
		// (get) Token: 0x0601E4F0 RID: 124144 RVA: 0x0043EF1C File Offset: 0x0043D11C
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

		// Token: 0x17008C20 RID: 35872
		// (get) Token: 0x0601E4F1 RID: 124145 RVA: 0x0043EF5C File Offset: 0x0043D15C
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

		// Token: 0x0601E4F2 RID: 124146 RVA: 0x0043EF94 File Offset: 0x0043D194
		public Span<byte> GetGmPathOnLoginBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0601E4F3 RID: 124147 RVA: 0x0043EFA4 File Offset: 0x0043D1A4
		public byte[] GetGmPathOnLoginArray()
		{
			return this.__p.__vector_as_array<byte>(36);
		}

		// Token: 0x17008C21 RID: 35873
		// (get) Token: 0x0601E4F4 RID: 124148 RVA: 0x0043EFB4 File Offset: 0x0043D1B4
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

		// Token: 0x17008C22 RID: 35874
		// (get) Token: 0x0601E4F5 RID: 124149 RVA: 0x0043EFF4 File Offset: 0x0043D1F4
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

		// Token: 0x17008C23 RID: 35875
		// (get) Token: 0x0601E4F6 RID: 124150 RVA: 0x0043F034 File Offset: 0x0043D234
		public bool IsReLoadArchive
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C24 RID: 35876
		// (get) Token: 0x0601E4F7 RID: 124151 RVA: 0x0043F074 File Offset: 0x0043D274
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

		// Token: 0x17008C25 RID: 35877
		// (get) Token: 0x0601E4F8 RID: 124152 RVA: 0x0043F0B4 File Offset: 0x0043D2B4
		public bool IsCustomAttachServerIp
		{
			get
			{
				int num = this.__p.__offset(46);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C26 RID: 35878
		// (get) Token: 0x0601E4F9 RID: 124153 RVA: 0x0043F0F4 File Offset: 0x0043D2F4
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

		// Token: 0x0601E4FA RID: 124154 RVA: 0x0043F12C File Offset: 0x0043D32C
		public Span<byte> GetAttachServerIpBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x0601E4FB RID: 124155 RVA: 0x0043F13C File Offset: 0x0043D33C
		public byte[] GetAttachServerIpArray()
		{
			return this.__p.__vector_as_array<byte>(48);
		}

		// Token: 0x17008C27 RID: 35879
		// (get) Token: 0x0601E4FC RID: 124156 RVA: 0x0043F14C File Offset: 0x0043D34C
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

		// Token: 0x17008C28 RID: 35880
		// (get) Token: 0x0601E4FD RID: 124157 RVA: 0x0043F18C File Offset: 0x0043D38C
		public bool IsUseMobileStreamingParamsInPie
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C29 RID: 35881
		// (get) Token: 0x0601E4FE RID: 124158 RVA: 0x0043F1CC File Offset: 0x0043D3CC
		public bool IsUseHighAoi
		{
			get
			{
				int num = this.__p.__offset(54);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C2A RID: 35882
		// (get) Token: 0x0601E4FF RID: 124159 RVA: 0x0043F20C File Offset: 0x0043D40C
		public bool IsStayInSubWp
		{
			get
			{
				int num = this.__p.__offset(56);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C2B RID: 35883
		// (get) Token: 0x0601E500 RID: 124160 RVA: 0x0043F24C File Offset: 0x0043D44C
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

		// Token: 0x0601E501 RID: 124161 RVA: 0x0043F284 File Offset: 0x0043D484
		public Span<byte> GetCustomPlayerNameBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x0601E502 RID: 124162 RVA: 0x0043F294 File Offset: 0x0043D494
		public byte[] GetCustomPlayerNameArray()
		{
			return this.__p.__vector_as_array<byte>(58);
		}

		// Token: 0x0601E503 RID: 124163 RVA: 0x0043F2A4 File Offset: 0x0043D4A4
		public string SubLevels(int j)
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008C2C RID: 35884
		// (get) Token: 0x0601E504 RID: 124164 RVA: 0x0043F2E0 File Offset: 0x0043D4E0
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

		// Token: 0x0601E505 RID: 124165 RVA: 0x0043F30C File Offset: 0x0043D50C
		public Record_Int_Strings? SubLevelsMap(int j)
		{
			int num = this.__p.__offset(62);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_Strings?(default(Record_Int_Strings).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008C2D RID: 35885
		// (get) Token: 0x0601E506 RID: 124166 RVA: 0x0043F370 File Offset: 0x0043D570
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

		// Token: 0x0601E507 RID: 124167 RVA: 0x0043F39C File Offset: 0x0043D59C
		public Record_Int_Ints? DataLayers(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_Ints?(default(Record_Int_Ints).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008C2E RID: 35886
		// (get) Token: 0x0601E508 RID: 124168 RVA: 0x0043F400 File Offset: 0x0043D600
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

		// Token: 0x0601E509 RID: 124169 RVA: 0x0043F42C File Offset: 0x0043D62C
		public Record_Int_IDisableEntities? DisableEntities(int j)
		{
			int num = this.__p.__offset(66);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_IDisableEntities?(default(Record_Int_IDisableEntities).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008C2F RID: 35887
		// (get) Token: 0x0601E50A RID: 124170 RVA: 0x0043F490 File Offset: 0x0043D690
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

		// Token: 0x0601E50B RID: 124171 RVA: 0x0043F4BC File Offset: 0x0043D6BC
		public Record_Int_Int? DungeonIdMap(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_Int?(default(Record_Int_Int).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008C30 RID: 35888
		// (get) Token: 0x0601E50C RID: 124172 RVA: 0x0043F520 File Offset: 0x0043D720
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

		// Token: 0x0601E50D RID: 124173 RVA: 0x0043F54C File Offset: 0x0043D74C
		public int SkipQuests(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008C31 RID: 35889
		// (get) Token: 0x0601E50E RID: 124174 RVA: 0x0043F58C File Offset: 0x0043D78C
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

		// Token: 0x0601E50F RID: 124175 RVA: 0x0043F5B8 File Offset: 0x0043D7B8
		public Span<int> GetSkipQuestsBytes()
		{
			return this.__p.__vector_as_span<int>(70, 4);
		}

		// Token: 0x0601E510 RID: 124176 RVA: 0x0043F5C8 File Offset: 0x0043D7C8
		public int[] GetSkipQuestsArray()
		{
			return this.__p.__vector_as_array<int>(70);
		}

		// Token: 0x17008C32 RID: 35890
		// (get) Token: 0x0601E511 RID: 124177 RVA: 0x0043F5D8 File Offset: 0x0043D7D8
		public bool IsBornAtCamera
		{
			get
			{
				int num = this.__p.__offset(72);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C33 RID: 35891
		// (get) Token: 0x0601E512 RID: 124178 RVA: 0x0043F618 File Offset: 0x0043D818
		public bool EnableDeltaReload
		{
			get
			{
				int num = this.__p.__offset(74);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C34 RID: 35892
		// (get) Token: 0x0601E513 RID: 124179 RVA: 0x0043F658 File Offset: 0x0043D858
		public bool IsSkipQuests
		{
			get
			{
				int num = this.__p.__offset(76);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C35 RID: 35893
		// (get) Token: 0x0601E514 RID: 124180 RVA: 0x0043F698 File Offset: 0x0043D898
		public bool IsUnlockExplore
		{
			get
			{
				int num = this.__p.__offset(78);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C36 RID: 35894
		// (get) Token: 0x0601E515 RID: 124181 RVA: 0x0043F6D8 File Offset: 0x0043D8D8
		public bool IsUnlockSpecial
		{
			get
			{
				int num = this.__p.__offset(80);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C37 RID: 35895
		// (get) Token: 0x0601E516 RID: 124182 RVA: 0x0043F718 File Offset: 0x0043D918
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

		// Token: 0x17008C38 RID: 35896
		// (get) Token: 0x0601E517 RID: 124183 RVA: 0x0043F778 File Offset: 0x0043D978
		public bool EnableAllSystemWithoutPopWin
		{
			get
			{
				int num = this.__p.__offset(84);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C39 RID: 35897
		// (get) Token: 0x0601E518 RID: 124184 RVA: 0x0043F7B8 File Offset: 0x0043D9B8
		public bool EnableAllTeleportPoints
		{
			get
			{
				int num = this.__p.__offset(86);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C3A RID: 35898
		// (get) Token: 0x0601E519 RID: 124185 RVA: 0x0043F7F8 File Offset: 0x0043D9F8
		public bool IsUnlockAllFog
		{
			get
			{
				int num = this.__p.__offset(88);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C3B RID: 35899
		// (get) Token: 0x0601E51A RID: 124186 RVA: 0x0043F838 File Offset: 0x0043DA38
		public bool IsDisableTeleportDungeon
		{
			get
			{
				int num = this.__p.__offset(90);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601E51B RID: 124187 RVA: 0x0043F878 File Offset: 0x0043DA78
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

		// Token: 0x0601E51C RID: 124188 RVA: 0x0043F9F0 File Offset: 0x0043DBF0
		public static void StartIEditorStartConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(44);
		}

		// Token: 0x0601E51D RID: 124189 RVA: 0x0043F9FA File Offset: 0x0043DBFA
		public static void AddAccount(FlatBufferBuilder builder, StringOffset accountOffset)
		{
			builder.AddOffset(0, accountOffset.Value, 0);
		}

		// Token: 0x0601E51E RID: 124190 RVA: 0x0043FA0A File Offset: 0x0043DC0A
		public static void AddLoginAccountType(FlatBufferBuilder builder, EEditorLoginAccountType loginAccountType)
		{
			builder.AddByte(1, (byte)loginAccountType, 0);
		}

		// Token: 0x0601E51F RID: 124191 RVA: 0x0043FA15 File Offset: 0x0043DC15
		public static void AddCustomAccount(FlatBufferBuilder builder, StringOffset customAccountOffset)
		{
			builder.AddOffset(2, customAccountOffset.Value, 0);
		}

		// Token: 0x0601E520 RID: 124192 RVA: 0x0043FA25 File Offset: 0x0043DC25
		public static void AddArchiveAccount(FlatBufferBuilder builder, StringOffset archiveAccountOffset)
		{
			builder.AddOffset(3, archiveAccountOffset.Value, 0);
		}

		// Token: 0x0601E521 RID: 124193 RVA: 0x0043FA35 File Offset: 0x0043DC35
		public static void AddIsNetMode(FlatBufferBuilder builder, bool isNetMode)
		{
			builder.AddBool(4, isNetMode, false);
		}

		// Token: 0x0601E522 RID: 124194 RVA: 0x0043FA40 File Offset: 0x0043DC40
		public static void AddIsMale(FlatBufferBuilder builder, bool isMale)
		{
			builder.AddBool(5, isMale, false);
		}

		// Token: 0x0601E523 RID: 124195 RVA: 0x0043FA4B File Offset: 0x0043DC4B
		public static void AddUseTemp(FlatBufferBuilder builder, bool useTemp)
		{
			builder.AddBool(6, useTemp, false);
		}

		// Token: 0x0601E524 RID: 124196 RVA: 0x0043FA56 File Offset: 0x0043DC56
		public static void AddServerIp(FlatBufferBuilder builder, StringOffset serverIpOffset)
		{
			builder.AddOffset(7, serverIpOffset.Value, 0);
		}

		// Token: 0x0601E525 RID: 124197 RVA: 0x0043FA66 File Offset: 0x0043DC66
		public static void AddIsRelaxMode(FlatBufferBuilder builder, bool isRelaxMode)
		{
			builder.AddBool(8, isRelaxMode, false);
		}

		// Token: 0x0601E526 RID: 124198 RVA: 0x0043FA71 File Offset: 0x0043DC71
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(9, dungeonId, 0);
		}

		// Token: 0x0601E527 RID: 124199 RVA: 0x0043FA7D File Offset: 0x0043DC7D
		public static void AddIsOpenDebugService(FlatBufferBuilder builder, bool isOpenDebugService)
		{
			builder.AddBool(10, isOpenDebugService, false);
		}

		// Token: 0x0601E528 RID: 124200 RVA: 0x0043FA89 File Offset: 0x0043DC89
		public static void AddDisableAutoStartServer(FlatBufferBuilder builder, bool disableAutoStartServer)
		{
			builder.AddBool(11, disableAutoStartServer, false);
		}

		// Token: 0x0601E529 RID: 124201 RVA: 0x0043FA95 File Offset: 0x0043DC95
		public static void AddReloadEditorConfig(FlatBufferBuilder builder, bool reloadEditorConfig)
		{
			builder.AddBool(12, reloadEditorConfig, false);
		}

		// Token: 0x0601E52A RID: 124202 RVA: 0x0043FAA1 File Offset: 0x0043DCA1
		public static void AddReloadConfigTable(FlatBufferBuilder builder, bool reloadConfigTable)
		{
			builder.AddBool(13, reloadConfigTable, false);
		}

		// Token: 0x0601E52B RID: 124203 RVA: 0x0043FAAD File Offset: 0x0043DCAD
		public static void AddIsLoginByNewUserName(FlatBufferBuilder builder, bool isLoginByNewUserName)
		{
			builder.AddBool(14, isLoginByNewUserName, false);
		}

		// Token: 0x0601E52C RID: 124204 RVA: 0x0043FAB9 File Offset: 0x0043DCB9
		public static void AddAccountType(FlatBufferBuilder builder, EAccountType accountType)
		{
			builder.AddByte(15, (byte)accountType, 0);
		}

		// Token: 0x0601E52D RID: 124205 RVA: 0x0043FAC5 File Offset: 0x0043DCC5
		public static void AddGmPathOnLogin(FlatBufferBuilder builder, StringOffset gmPathOnLoginOffset)
		{
			builder.AddOffset(16, gmPathOnLoginOffset.Value, 0);
		}

		// Token: 0x0601E52E RID: 124206 RVA: 0x0043FAD6 File Offset: 0x0043DCD6
		public static void AddEditorPort(FlatBufferBuilder builder, int editorPort)
		{
			builder.AddInt(17, editorPort, 0);
		}

		// Token: 0x0601E52F RID: 124207 RVA: 0x0043FAE2 File Offset: 0x0043DCE2
		public static void AddGameClientGmPort(FlatBufferBuilder builder, int gameClientGmPort)
		{
			builder.AddInt(18, gameClientGmPort, 0);
		}

		// Token: 0x0601E530 RID: 124208 RVA: 0x0043FAEE File Offset: 0x0043DCEE
		public static void AddIsReLoadArchive(FlatBufferBuilder builder, bool isReLoadArchive)
		{
			builder.AddBool(19, isReLoadArchive, false);
		}

		// Token: 0x0601E531 RID: 124209 RVA: 0x0043FAFA File Offset: 0x0043DCFA
		public static void AddPackageVersion(FlatBufferBuilder builder, int packageVersion)
		{
			builder.AddInt(20, packageVersion, 0);
		}

		// Token: 0x0601E532 RID: 124210 RVA: 0x0043FB06 File Offset: 0x0043DD06
		public static void AddIsCustomAttachServerIp(FlatBufferBuilder builder, bool isCustomAttachServerIp)
		{
			builder.AddBool(21, isCustomAttachServerIp, false);
		}

		// Token: 0x0601E533 RID: 124211 RVA: 0x0043FB12 File Offset: 0x0043DD12
		public static void AddAttachServerIp(FlatBufferBuilder builder, StringOffset attachServerIpOffset)
		{
			builder.AddOffset(22, attachServerIpOffset.Value, 0);
		}

		// Token: 0x0601E534 RID: 124212 RVA: 0x0043FB23 File Offset: 0x0043DD23
		public static void AddAttachPlayerId(FlatBufferBuilder builder, int attachPlayerId)
		{
			builder.AddInt(23, attachPlayerId, 0);
		}

		// Token: 0x0601E535 RID: 124213 RVA: 0x0043FB2F File Offset: 0x0043DD2F
		public static void AddIsUseMobileStreamingParamsInPie(FlatBufferBuilder builder, bool isUseMobileStreamingParamsInPie)
		{
			builder.AddBool(24, isUseMobileStreamingParamsInPie, false);
		}

		// Token: 0x0601E536 RID: 124214 RVA: 0x0043FB3B File Offset: 0x0043DD3B
		public static void AddIsUseHighAoi(FlatBufferBuilder builder, bool isUseHighAoi)
		{
			builder.AddBool(25, isUseHighAoi, false);
		}

		// Token: 0x0601E537 RID: 124215 RVA: 0x0043FB47 File Offset: 0x0043DD47
		public static void AddIsStayInSubWp(FlatBufferBuilder builder, bool isStayInSubWp)
		{
			builder.AddBool(26, isStayInSubWp, false);
		}

		// Token: 0x0601E538 RID: 124216 RVA: 0x0043FB53 File Offset: 0x0043DD53
		public static void AddCustomPlayerName(FlatBufferBuilder builder, StringOffset customPlayerNameOffset)
		{
			builder.AddOffset(27, customPlayerNameOffset.Value, 0);
		}

		// Token: 0x0601E539 RID: 124217 RVA: 0x0043FB64 File Offset: 0x0043DD64
		public static void AddSubLevels(FlatBufferBuilder builder, VectorOffset subLevelsOffset)
		{
			builder.AddOffset(28, subLevelsOffset.Value, 0);
		}

		// Token: 0x0601E53A RID: 124218 RVA: 0x0043FB78 File Offset: 0x0043DD78
		public static VectorOffset CreateSubLevelsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E53B RID: 124219 RVA: 0x0043FBB8 File Offset: 0x0043DDB8
		public static VectorOffset CreateSubLevelsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E53C RID: 124220 RVA: 0x0043FBD2 File Offset: 0x0043DDD2
		public static VectorOffset CreateSubLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E53D RID: 124221 RVA: 0x0043FBF0 File Offset: 0x0043DDF0
		public static VectorOffset CreateSubLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E53E RID: 124222 RVA: 0x0043FC09 File Offset: 0x0043DE09
		public static void StartSubLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E53F RID: 124223 RVA: 0x0043FC14 File Offset: 0x0043DE14
		public static void AddSubLevelsMap(FlatBufferBuilder builder, VectorOffset subLevelsMapOffset)
		{
			builder.AddOffset(29, subLevelsMapOffset.Value, 0);
		}

		// Token: 0x0601E540 RID: 124224 RVA: 0x0043FC28 File Offset: 0x0043DE28
		public static VectorOffset CreateSubLevelsMapVector(FlatBufferBuilder builder, Offset<Record_Int_Strings>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E541 RID: 124225 RVA: 0x0043FC68 File Offset: 0x0043DE68
		public static VectorOffset CreateSubLevelsMapVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_Strings>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_Strings>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E542 RID: 124226 RVA: 0x0043FC82 File Offset: 0x0043DE82
		public static VectorOffset CreateSubLevelsMapVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_Strings>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_Strings>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E543 RID: 124227 RVA: 0x0043FCA0 File Offset: 0x0043DEA0
		public static VectorOffset CreateSubLevelsMapVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_Strings>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E544 RID: 124228 RVA: 0x0043FCB9 File Offset: 0x0043DEB9
		public static void StartSubLevelsMapVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E545 RID: 124229 RVA: 0x0043FCC4 File Offset: 0x0043DEC4
		public static void AddDataLayers(FlatBufferBuilder builder, VectorOffset dataLayersOffset)
		{
			builder.AddOffset(30, dataLayersOffset.Value, 0);
		}

		// Token: 0x0601E546 RID: 124230 RVA: 0x0043FCD8 File Offset: 0x0043DED8
		public static VectorOffset CreateDataLayersVector(FlatBufferBuilder builder, Offset<Record_Int_Ints>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E547 RID: 124231 RVA: 0x0043FD18 File Offset: 0x0043DF18
		public static VectorOffset CreateDataLayersVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_Ints>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_Ints>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E548 RID: 124232 RVA: 0x0043FD32 File Offset: 0x0043DF32
		public static VectorOffset CreateDataLayersVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_Ints>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_Ints>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E549 RID: 124233 RVA: 0x0043FD50 File Offset: 0x0043DF50
		public static VectorOffset CreateDataLayersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_Ints>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E54A RID: 124234 RVA: 0x0043FD69 File Offset: 0x0043DF69
		public static void StartDataLayersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E54B RID: 124235 RVA: 0x0043FD74 File Offset: 0x0043DF74
		public static void AddDisableEntities(FlatBufferBuilder builder, VectorOffset disableEntitiesOffset)
		{
			builder.AddOffset(31, disableEntitiesOffset.Value, 0);
		}

		// Token: 0x0601E54C RID: 124236 RVA: 0x0043FD88 File Offset: 0x0043DF88
		public static VectorOffset CreateDisableEntitiesVector(FlatBufferBuilder builder, Offset<Record_Int_IDisableEntities>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E54D RID: 124237 RVA: 0x0043FDC8 File Offset: 0x0043DFC8
		public static VectorOffset CreateDisableEntitiesVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_IDisableEntities>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_IDisableEntities>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E54E RID: 124238 RVA: 0x0043FDE2 File Offset: 0x0043DFE2
		public static VectorOffset CreateDisableEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_IDisableEntities>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_IDisableEntities>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E54F RID: 124239 RVA: 0x0043FE00 File Offset: 0x0043E000
		public static VectorOffset CreateDisableEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_IDisableEntities>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E550 RID: 124240 RVA: 0x0043FE19 File Offset: 0x0043E019
		public static void StartDisableEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E551 RID: 124241 RVA: 0x0043FE24 File Offset: 0x0043E024
		public static void AddDungeonIdMap(FlatBufferBuilder builder, VectorOffset dungeonIdMapOffset)
		{
			builder.AddOffset(32, dungeonIdMapOffset.Value, 0);
		}

		// Token: 0x0601E552 RID: 124242 RVA: 0x0043FE38 File Offset: 0x0043E038
		public static VectorOffset CreateDungeonIdMapVector(FlatBufferBuilder builder, Offset<Record_Int_Int>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E553 RID: 124243 RVA: 0x0043FE78 File Offset: 0x0043E078
		public static VectorOffset CreateDungeonIdMapVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_Int>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_Int>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E554 RID: 124244 RVA: 0x0043FE92 File Offset: 0x0043E092
		public static VectorOffset CreateDungeonIdMapVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_Int>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_Int>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E555 RID: 124245 RVA: 0x0043FEB0 File Offset: 0x0043E0B0
		public static VectorOffset CreateDungeonIdMapVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_Int>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E556 RID: 124246 RVA: 0x0043FEC9 File Offset: 0x0043E0C9
		public static void StartDungeonIdMapVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E557 RID: 124247 RVA: 0x0043FED4 File Offset: 0x0043E0D4
		public static void AddSkipQuests(FlatBufferBuilder builder, VectorOffset skipQuestsOffset)
		{
			builder.AddOffset(33, skipQuestsOffset.Value, 0);
		}

		// Token: 0x0601E558 RID: 124248 RVA: 0x0043FEE8 File Offset: 0x0043E0E8
		public static VectorOffset CreateSkipQuestsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E559 RID: 124249 RVA: 0x0043FF1F File Offset: 0x0043E11F
		public static VectorOffset CreateSkipQuestsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E55A RID: 124250 RVA: 0x0043FF39 File Offset: 0x0043E139
		public static VectorOffset CreateSkipQuestsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E55B RID: 124251 RVA: 0x0043FF57 File Offset: 0x0043E157
		public static VectorOffset CreateSkipQuestsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E55C RID: 124252 RVA: 0x0043FF70 File Offset: 0x0043E170
		public static void StartSkipQuestsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E55D RID: 124253 RVA: 0x0043FF7B File Offset: 0x0043E17B
		public static void AddIsBornAtCamera(FlatBufferBuilder builder, bool isBornAtCamera)
		{
			builder.AddBool(34, isBornAtCamera, false);
		}

		// Token: 0x0601E55E RID: 124254 RVA: 0x0043FF87 File Offset: 0x0043E187
		public static void AddEnableDeltaReload(FlatBufferBuilder builder, bool enableDeltaReload)
		{
			builder.AddBool(35, enableDeltaReload, false);
		}

		// Token: 0x0601E55F RID: 124255 RVA: 0x0043FF93 File Offset: 0x0043E193
		public static void AddIsSkipQuests(FlatBufferBuilder builder, bool isSkipQuests)
		{
			builder.AddBool(36, isSkipQuests, false);
		}

		// Token: 0x0601E560 RID: 124256 RVA: 0x0043FF9F File Offset: 0x0043E19F
		public static void AddIsUnlockExplore(FlatBufferBuilder builder, bool isUnlockExplore)
		{
			builder.AddBool(37, isUnlockExplore, false);
		}

		// Token: 0x0601E561 RID: 124257 RVA: 0x0043FFAB File Offset: 0x0043E1AB
		public static void AddIsUnlockSpecial(FlatBufferBuilder builder, bool isUnlockSpecial)
		{
			builder.AddBool(38, isUnlockSpecial, false);
		}

		// Token: 0x0601E562 RID: 124258 RVA: 0x0043FFB7 File Offset: 0x0043E1B7
		public static void AddLocation(FlatBufferBuilder builder, Offset<IPosA> locationOffset)
		{
			builder.AddOffset(39, locationOffset.Value, 0);
		}

		// Token: 0x0601E563 RID: 124259 RVA: 0x0043FFC8 File Offset: 0x0043E1C8
		public static void AddEnableAllSystemWithoutPopWin(FlatBufferBuilder builder, bool enableAllSystemWithoutPopWin)
		{
			builder.AddBool(40, enableAllSystemWithoutPopWin, false);
		}

		// Token: 0x0601E564 RID: 124260 RVA: 0x0043FFD4 File Offset: 0x0043E1D4
		public static void AddEnableAllTeleportPoints(FlatBufferBuilder builder, bool enableAllTeleportPoints)
		{
			builder.AddBool(41, enableAllTeleportPoints, false);
		}

		// Token: 0x0601E565 RID: 124261 RVA: 0x0043FFE0 File Offset: 0x0043E1E0
		public static void AddIsUnlockAllFog(FlatBufferBuilder builder, bool isUnlockAllFog)
		{
			builder.AddBool(42, isUnlockAllFog, false);
		}

		// Token: 0x0601E566 RID: 124262 RVA: 0x0043FFEC File Offset: 0x0043E1EC
		public static void AddIsDisableTeleportDungeon(FlatBufferBuilder builder, bool isDisableTeleportDungeon)
		{
			builder.AddBool(43, isDisableTeleportDungeon, false);
		}

		// Token: 0x0601E567 RID: 124263 RVA: 0x0043FFF8 File Offset: 0x0043E1F8
		public static Offset<IEditorStartConfig> EndIEditorStartConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEditorStartConfig>(builder.EndTable());
		}

		// Token: 0x0601E568 RID: 124264 RVA: 0x00440008 File Offset: 0x0043E208
		public IEditorStartConfigT UnPack()
		{
			IEditorStartConfigT editorStartConfigT = new IEditorStartConfigT();
			this.UnPackTo(editorStartConfigT);
			return editorStartConfigT;
		}

		// Token: 0x0601E569 RID: 124265 RVA: 0x00440024 File Offset: 0x0043E224
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

		// Token: 0x0601E56A RID: 124266 RVA: 0x004403E4 File Offset: 0x0043E5E4
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

		// Token: 0x0400D833 RID: 55347
		private Table __p;
	}
}

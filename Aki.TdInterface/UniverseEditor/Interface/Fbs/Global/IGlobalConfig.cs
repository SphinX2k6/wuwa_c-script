using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Global
{
	// Token: 0x020046DC RID: 18140
	public struct IGlobalConfig : IFlatbufferObject
	{
		// Token: 0x170080DB RID: 32987
		// (get) Token: 0x0601B9B1 RID: 113073 RVA: 0x003EA406 File Offset: 0x003E8606
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B9B2 RID: 113074 RVA: 0x003EA413 File Offset: 0x003E8613
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B9B3 RID: 113075 RVA: 0x003EA41C File Offset: 0x003E861C
		public static IGlobalConfig GetRootAsIGlobalConfig(ByteBuffer _bb)
		{
			return IGlobalConfig.GetRootAsIGlobalConfig(_bb, default(IGlobalConfig));
		}

		// Token: 0x0601B9B4 RID: 113076 RVA: 0x003EA438 File Offset: 0x003E8638
		public static IGlobalConfig GetRootAsIGlobalConfig(ByteBuffer _bb, IGlobalConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B9B5 RID: 113077 RVA: 0x003EA455 File Offset: 0x003E8655
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B9B6 RID: 113078 RVA: 0x003EA464 File Offset: 0x003E8664
		public IGlobalConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080DC RID: 32988
		// (get) Token: 0x0601B9B7 RID: 113079 RVA: 0x003EA474 File Offset: 0x003E8674
		public string ActionConfigPath
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

		// Token: 0x0601B9B8 RID: 113080 RVA: 0x003EA4AB File Offset: 0x003E86AB
		public Span<byte> GetActionConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601B9B9 RID: 113081 RVA: 0x003EA4BA File Offset: 0x003E86BA
		public byte[] GetActionConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170080DD RID: 32989
		// (get) Token: 0x0601B9BA RID: 113082 RVA: 0x003EA4C8 File Offset: 0x003E86C8
		public string ComponentConfigPath
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B9BB RID: 113083 RVA: 0x003EA4FF File Offset: 0x003E86FF
		public Span<byte> GetComponentConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601B9BC RID: 113084 RVA: 0x003EA50E File Offset: 0x003E870E
		public byte[] GetComponentConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170080DE RID: 32990
		// (get) Token: 0x0601B9BD RID: 113085 RVA: 0x003EA51C File Offset: 0x003E871C
		public string EntityConfigPath
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

		// Token: 0x0601B9BE RID: 113086 RVA: 0x003EA553 File Offset: 0x003E8753
		public Span<byte> GetEntityConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601B9BF RID: 113087 RVA: 0x003EA562 File Offset: 0x003E8762
		public byte[] GetEntityConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170080DF RID: 32991
		// (get) Token: 0x0601B9C0 RID: 113088 RVA: 0x003EA570 File Offset: 0x003E8770
		public string BlueprintConfigPath
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

		// Token: 0x0601B9C1 RID: 113089 RVA: 0x003EA5A8 File Offset: 0x003E87A8
		public Span<byte> GetBlueprintConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601B9C2 RID: 113090 RVA: 0x003EA5B8 File Offset: 0x003E87B8
		public byte[] GetBlueprintConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x170080E0 RID: 32992
		// (get) Token: 0x0601B9C3 RID: 113091 RVA: 0x003EA5C8 File Offset: 0x003E87C8
		public string LevelsConfigPath
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B9C4 RID: 113092 RVA: 0x003EA600 File Offset: 0x003E8800
		public Span<byte> GetLevelsConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601B9C5 RID: 113093 RVA: 0x003EA610 File Offset: 0x003E8810
		public byte[] GetLevelsConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x170080E1 RID: 32993
		// (get) Token: 0x0601B9C6 RID: 113094 RVA: 0x003EA620 File Offset: 0x003E8820
		public string SubWpMapConfigPath
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B9C7 RID: 113095 RVA: 0x003EA658 File Offset: 0x003E8858
		public Span<byte> GetSubWpMapConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601B9C8 RID: 113096 RVA: 0x003EA668 File Offset: 0x003E8868
		public byte[] GetSubWpMapConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x170080E2 RID: 32994
		// (get) Token: 0x0601B9C9 RID: 113097 RVA: 0x003EA678 File Offset: 0x003E8878
		public string LevelsDir
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B9CA RID: 113098 RVA: 0x003EA6B0 File Offset: 0x003E88B0
		public Span<byte> GetLevelsDirBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0601B9CB RID: 113099 RVA: 0x003EA6C0 File Offset: 0x003E88C0
		public byte[] GetLevelsDirArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x170080E3 RID: 32995
		// (get) Token: 0x0601B9CC RID: 113100 RVA: 0x003EA6D0 File Offset: 0x003E88D0
		public string LevelsDataDir
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

		// Token: 0x0601B9CD RID: 113101 RVA: 0x003EA708 File Offset: 0x003E8908
		public Span<byte> GetLevelsDataDirBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0601B9CE RID: 113102 RVA: 0x003EA718 File Offset: 0x003E8918
		public byte[] GetLevelsDataDirArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x170080E4 RID: 32996
		// (get) Token: 0x0601B9CF RID: 113103 RVA: 0x003EA728 File Offset: 0x003E8928
		public string TemplateDir
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B9D0 RID: 113104 RVA: 0x003EA760 File Offset: 0x003E8960
		public Span<byte> GetTemplateDirBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0601B9D1 RID: 113105 RVA: 0x003EA770 File Offset: 0x003E8970
		public byte[] GetTemplateDirArray()
		{
			return this.__p.__vector_as_array<byte>(20);
		}

		// Token: 0x170080E5 RID: 32997
		// (get) Token: 0x0601B9D2 RID: 113106 RVA: 0x003EA780 File Offset: 0x003E8980
		public string TemplateConfigPath
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B9D3 RID: 113107 RVA: 0x003EA7B8 File Offset: 0x003E89B8
		public Span<byte> GetTemplateConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0601B9D4 RID: 113108 RVA: 0x003EA7C8 File Offset: 0x003E89C8
		public byte[] GetTemplateConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x170080E6 RID: 32998
		// (get) Token: 0x0601B9D5 RID: 113109 RVA: 0x003EA7D8 File Offset: 0x003E89D8
		public string EntityDataConfigPath
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B9D6 RID: 113110 RVA: 0x003EA810 File Offset: 0x003E8A10
		public Span<byte> GetEntityDataConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0601B9D7 RID: 113111 RVA: 0x003EA820 File Offset: 0x003E8A20
		public byte[] GetEntityDataConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(24);
		}

		// Token: 0x170080E7 RID: 32999
		// (get) Token: 0x0601B9D8 RID: 113112 RVA: 0x003EA830 File Offset: 0x003E8A30
		public string TypeScriptRoot
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B9D9 RID: 113113 RVA: 0x003EA868 File Offset: 0x003E8A68
		public Span<byte> GetTypeScriptRootBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0601B9DA RID: 113114 RVA: 0x003EA878 File Offset: 0x003E8A78
		public byte[] GetTypeScriptRootArray()
		{
			return this.__p.__vector_as_array<byte>(26);
		}

		// Token: 0x170080E8 RID: 33000
		// (get) Token: 0x0601B9DB RID: 113115 RVA: 0x003EA888 File Offset: 0x003E8A88
		public string CsvFileDir
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B9DC RID: 113116 RVA: 0x003EA8C0 File Offset: 0x003E8AC0
		public Span<byte> GetCsvFileDirBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0601B9DD RID: 113117 RVA: 0x003EA8D0 File Offset: 0x003E8AD0
		public byte[] GetCsvFileDirArray()
		{
			return this.__p.__vector_as_array<byte>(28);
		}

		// Token: 0x170080E9 RID: 33001
		// (get) Token: 0x0601B9DE RID: 113118 RVA: 0x003EA8E0 File Offset: 0x003E8AE0
		public string FlowListDir
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B9DF RID: 113119 RVA: 0x003EA918 File Offset: 0x003E8B18
		public Span<byte> GetFlowListDirBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0601B9E0 RID: 113120 RVA: 0x003EA928 File Offset: 0x003E8B28
		public byte[] GetFlowListDirArray()
		{
			return this.__p.__vector_as_array<byte>(30);
		}

		// Token: 0x170080EA RID: 33002
		// (get) Token: 0x0601B9E1 RID: 113121 RVA: 0x003EA938 File Offset: 0x003E8B38
		public string QuestListDir
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B9E2 RID: 113122 RVA: 0x003EA970 File Offset: 0x003E8B70
		public Span<byte> GetQuestListDirBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0601B9E3 RID: 113123 RVA: 0x003EA980 File Offset: 0x003E8B80
		public byte[] GetQuestListDirArray()
		{
			return this.__p.__vector_as_array<byte>(32);
		}

		// Token: 0x170080EB RID: 33003
		// (get) Token: 0x0601B9E4 RID: 113124 RVA: 0x003EA990 File Offset: 0x003E8B90
		public string QuestListExportDir
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B9E5 RID: 113125 RVA: 0x003EA9C8 File Offset: 0x003E8BC8
		public Span<byte> GetQuestListExportDirBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0601B9E6 RID: 113126 RVA: 0x003EA9D8 File Offset: 0x003E8BD8
		public byte[] GetQuestListExportDirArray()
		{
			return this.__p.__vector_as_array<byte>(34);
		}

		// Token: 0x170080EC RID: 33004
		// (get) Token: 0x0601B9E7 RID: 113127 RVA: 0x003EA9E8 File Offset: 0x003E8BE8
		public string EntityStateConfigPath
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

		// Token: 0x0601B9E8 RID: 113128 RVA: 0x003EAA20 File Offset: 0x003E8C20
		public Span<byte> GetEntityStateConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0601B9E9 RID: 113129 RVA: 0x003EAA30 File Offset: 0x003E8C30
		public byte[] GetEntityStateConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(36);
		}

		// Token: 0x170080ED RID: 33005
		// (get) Token: 0x0601B9EA RID: 113130 RVA: 0x003EAA40 File Offset: 0x003E8C40
		public string EntityOwnerConfigPath
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

		// Token: 0x0601B9EB RID: 113131 RVA: 0x003EAA78 File Offset: 0x003E8C78
		public Span<byte> GetEntityOwnerConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0601B9EC RID: 113132 RVA: 0x003EAA88 File Offset: 0x003E8C88
		public byte[] GetEntityOwnerConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(38);
		}

		// Token: 0x170080EE RID: 33006
		// (get) Token: 0x0601B9ED RID: 113133 RVA: 0x003EAA98 File Offset: 0x003E8C98
		public string ChildEntityOwnerConfigPath
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B9EE RID: 113134 RVA: 0x003EAAD0 File Offset: 0x003E8CD0
		public Span<byte> GetChildEntityOwnerConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0601B9EF RID: 113135 RVA: 0x003EAAE0 File Offset: 0x003E8CE0
		public byte[] GetChildEntityOwnerConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(40);
		}

		// Token: 0x170080EF RID: 33007
		// (get) Token: 0x0601B9F0 RID: 113136 RVA: 0x003EAAF0 File Offset: 0x003E8CF0
		public string AlwaysLoadEntityConfigPath
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B9F1 RID: 113137 RVA: 0x003EAB28 File Offset: 0x003E8D28
		public Span<byte> GetAlwaysLoadEntityConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0601B9F2 RID: 113138 RVA: 0x003EAB38 File Offset: 0x003E8D38
		public byte[] GetAlwaysLoadEntityConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(42);
		}

		// Token: 0x170080F0 RID: 33008
		// (get) Token: 0x0601B9F3 RID: 113139 RVA: 0x003EAB48 File Offset: 0x003E8D48
		public string LevelPlayListDir
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B9F4 RID: 113140 RVA: 0x003EAB80 File Offset: 0x003E8D80
		public Span<byte> GetLevelPlayListDirBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0601B9F5 RID: 113141 RVA: 0x003EAB90 File Offset: 0x003E8D90
		public byte[] GetLevelPlayListDirArray()
		{
			return this.__p.__vector_as_array<byte>(44);
		}

		// Token: 0x170080F1 RID: 33009
		// (get) Token: 0x0601B9F6 RID: 113142 RVA: 0x003EABA0 File Offset: 0x003E8DA0
		public string LevelPlayListExportDir
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B9F7 RID: 113143 RVA: 0x003EABD8 File Offset: 0x003E8DD8
		public Span<byte> GetLevelPlayListExportDirBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0601B9F8 RID: 113144 RVA: 0x003EABE8 File Offset: 0x003E8DE8
		public byte[] GetLevelPlayListExportDirArray()
		{
			return this.__p.__vector_as_array<byte>(46);
		}

		// Token: 0x170080F2 RID: 33010
		// (get) Token: 0x0601B9F9 RID: 113145 RVA: 0x003EABF8 File Offset: 0x003E8DF8
		public string DynamicLevelPlayListExportDir
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

		// Token: 0x0601B9FA RID: 113146 RVA: 0x003EAC30 File Offset: 0x003E8E30
		public Span<byte> GetDynamicLevelPlayListExportDirBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x0601B9FB RID: 113147 RVA: 0x003EAC40 File Offset: 0x003E8E40
		public byte[] GetDynamicLevelPlayListExportDirArray()
		{
			return this.__p.__vector_as_array<byte>(48);
		}

		// Token: 0x170080F3 RID: 33011
		// (get) Token: 0x0601B9FC RID: 113148 RVA: 0x003EAC50 File Offset: 0x003E8E50
		public string TwoDimensionLevelListDir
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

		// Token: 0x0601B9FD RID: 113149 RVA: 0x003EAC88 File Offset: 0x003E8E88
		public Span<byte> GetTwoDimensionLevelListDirBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0601B9FE RID: 113150 RVA: 0x003EAC98 File Offset: 0x003E8E98
		public byte[] GetTwoDimensionLevelListDirArray()
		{
			return this.__p.__vector_as_array<byte>(50);
		}

		// Token: 0x170080F4 RID: 33012
		// (get) Token: 0x0601B9FF RID: 113151 RVA: 0x003EACA8 File Offset: 0x003E8EA8
		public string DangoBrawlObjectTemplateDir
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA00 RID: 113152 RVA: 0x003EACE0 File Offset: 0x003E8EE0
		public Span<byte> GetDangoBrawlObjectTemplateDirBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0601BA01 RID: 113153 RVA: 0x003EACF0 File Offset: 0x003E8EF0
		public byte[] GetDangoBrawlObjectTemplateDirArray()
		{
			return this.__p.__vector_as_array<byte>(52);
		}

		// Token: 0x170080F5 RID: 33013
		// (get) Token: 0x0601BA02 RID: 113154 RVA: 0x003EAD00 File Offset: 0x003E8F00
		public string MarbleLevelConfigPath
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA03 RID: 113155 RVA: 0x003EAD38 File Offset: 0x003E8F38
		public Span<byte> GetMarbleLevelConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x0601BA04 RID: 113156 RVA: 0x003EAD48 File Offset: 0x003E8F48
		public byte[] GetMarbleLevelConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(54);
		}

		// Token: 0x170080F6 RID: 33014
		// (get) Token: 0x0601BA05 RID: 113157 RVA: 0x003EAD58 File Offset: 0x003E8F58
		public string DangoBrawlLevelConfigPath
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA06 RID: 113158 RVA: 0x003EAD90 File Offset: 0x003E8F90
		public Span<byte> GetDangoBrawlLevelConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x0601BA07 RID: 113159 RVA: 0x003EADA0 File Offset: 0x003E8FA0
		public byte[] GetDangoBrawlLevelConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(56);
		}

		// Token: 0x170080F7 RID: 33015
		// (get) Token: 0x0601BA08 RID: 113160 RVA: 0x003EADB0 File Offset: 0x003E8FB0
		public string DangoBrawlObjectTemplateConfigPath
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

		// Token: 0x0601BA09 RID: 113161 RVA: 0x003EADE8 File Offset: 0x003E8FE8
		public Span<byte> GetDangoBrawlObjectTemplateConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x0601BA0A RID: 113162 RVA: 0x003EADF8 File Offset: 0x003E8FF8
		public byte[] GetDangoBrawlObjectTemplateConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(58);
		}

		// Token: 0x170080F8 RID: 33016
		// (get) Token: 0x0601BA0B RID: 113163 RVA: 0x003EAE08 File Offset: 0x003E9008
		public string FunctionalTestDir
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

		// Token: 0x0601BA0C RID: 113164 RVA: 0x003EAE40 File Offset: 0x003E9040
		public Span<byte> GetFunctionalTestDirBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x0601BA0D RID: 113165 RVA: 0x003EAE50 File Offset: 0x003E9050
		public byte[] GetFunctionalTestDirArray()
		{
			return this.__p.__vector_as_array<byte>(60);
		}

		// Token: 0x170080F9 RID: 33017
		// (get) Token: 0x0601BA0E RID: 113166 RVA: 0x003EAE60 File Offset: 0x003E9060
		public string FlowTemplateConfigPath
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA0F RID: 113167 RVA: 0x003EAE98 File Offset: 0x003E9098
		public Span<byte> GetFlowTemplateConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x0601BA10 RID: 113168 RVA: 0x003EAEA8 File Offset: 0x003E90A8
		public byte[] GetFlowTemplateConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(62);
		}

		// Token: 0x170080FA RID: 33018
		// (get) Token: 0x0601BA11 RID: 113169 RVA: 0x003EAEB8 File Offset: 0x003E90B8
		public string FlowTemplateCameraDir
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA12 RID: 113170 RVA: 0x003EAEF0 File Offset: 0x003E90F0
		public Span<byte> GetFlowTemplateCameraDirBytes()
		{
			return this.__p.__vector_as_span<byte>(64, 1);
		}

		// Token: 0x0601BA13 RID: 113171 RVA: 0x003EAF00 File Offset: 0x003E9100
		public byte[] GetFlowTemplateCameraDirArray()
		{
			return this.__p.__vector_as_array<byte>(64);
		}

		// Token: 0x170080FB RID: 33019
		// (get) Token: 0x0601BA14 RID: 113172 RVA: 0x003EAF10 File Offset: 0x003E9110
		public string FlowTemplateCameraConfigPath
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA15 RID: 113173 RVA: 0x003EAF48 File Offset: 0x003E9148
		public Span<byte> GetFlowTemplateCameraConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(66, 1);
		}

		// Token: 0x0601BA16 RID: 113174 RVA: 0x003EAF58 File Offset: 0x003E9158
		public byte[] GetFlowTemplateCameraConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(66);
		}

		// Token: 0x170080FC RID: 33020
		// (get) Token: 0x0601BA17 RID: 113175 RVA: 0x003EAF68 File Offset: 0x003E9168
		public string FlowTemplateCameraConfgSourcePath
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA18 RID: 113176 RVA: 0x003EAFA0 File Offset: 0x003E91A0
		public Span<byte> GetFlowTemplateCameraConfgSourcePathBytes()
		{
			return this.__p.__vector_as_span<byte>(68, 1);
		}

		// Token: 0x0601BA19 RID: 113177 RVA: 0x003EAFB0 File Offset: 0x003E91B0
		public byte[] GetFlowTemplateCameraConfgSourcePathArray()
		{
			return this.__p.__vector_as_array<byte>(68);
		}

		// Token: 0x170080FD RID: 33021
		// (get) Token: 0x0601BA1A RID: 113178 RVA: 0x003EAFC0 File Offset: 0x003E91C0
		public string GlobalVarConfigPath
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA1B RID: 113179 RVA: 0x003EAFF8 File Offset: 0x003E91F8
		public Span<byte> GetGlobalVarConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(70, 1);
		}

		// Token: 0x0601BA1C RID: 113180 RVA: 0x003EB008 File Offset: 0x003E9208
		public byte[] GetGlobalVarConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(70);
		}

		// Token: 0x170080FE RID: 33022
		// (get) Token: 0x0601BA1D RID: 113181 RVA: 0x003EB018 File Offset: 0x003E9218
		public string SystemVarConfigPath
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA1E RID: 113182 RVA: 0x003EB050 File Offset: 0x003E9250
		public Span<byte> GetSystemVarConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(72, 1);
		}

		// Token: 0x0601BA1F RID: 113183 RVA: 0x003EB060 File Offset: 0x003E9260
		public byte[] GetSystemVarConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(72);
		}

		// Token: 0x170080FF RID: 33023
		// (get) Token: 0x0601BA20 RID: 113184 RVA: 0x003EB070 File Offset: 0x003E9270
		public string VehicleRidingRolesConfigPath
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA21 RID: 113185 RVA: 0x003EB0A8 File Offset: 0x003E92A8
		public Span<byte> GetVehicleRidingRolesConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x0601BA22 RID: 113186 RVA: 0x003EB0B8 File Offset: 0x003E92B8
		public byte[] GetVehicleRidingRolesConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(74);
		}

		// Token: 0x17008100 RID: 33024
		// (get) Token: 0x0601BA23 RID: 113187 RVA: 0x003EB0C8 File Offset: 0x003E92C8
		public string OccupationConfigPath
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA24 RID: 113188 RVA: 0x003EB100 File Offset: 0x003E9300
		public Span<byte> GetOccupationConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(76, 1);
		}

		// Token: 0x0601BA25 RID: 113189 RVA: 0x003EB110 File Offset: 0x003E9310
		public byte[] GetOccupationConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(76);
		}

		// Token: 0x17008101 RID: 33025
		// (get) Token: 0x0601BA26 RID: 113190 RVA: 0x003EB120 File Offset: 0x003E9320
		public string OccupiedExportPath
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA27 RID: 113191 RVA: 0x003EB158 File Offset: 0x003E9358
		public Span<byte> GetOccupiedExportPathBytes()
		{
			return this.__p.__vector_as_span<byte>(78, 1);
		}

		// Token: 0x0601BA28 RID: 113192 RVA: 0x003EB168 File Offset: 0x003E9368
		public byte[] GetOccupiedExportPathArray()
		{
			return this.__p.__vector_as_array<byte>(78);
		}

		// Token: 0x17008102 RID: 33026
		// (get) Token: 0x0601BA29 RID: 113193 RVA: 0x003EB178 File Offset: 0x003E9378
		public string InteractOptionConfigPath
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA2A RID: 113194 RVA: 0x003EB1B0 File Offset: 0x003E93B0
		public Span<byte> GetInteractOptionConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(80, 1);
		}

		// Token: 0x0601BA2B RID: 113195 RVA: 0x003EB1C0 File Offset: 0x003E93C0
		public byte[] GetInteractOptionConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(80);
		}

		// Token: 0x17008103 RID: 33027
		// (get) Token: 0x0601BA2C RID: 113196 RVA: 0x003EB1D0 File Offset: 0x003E93D0
		public string AreaEntitiesPath
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA2D RID: 113197 RVA: 0x003EB208 File Offset: 0x003E9408
		public Span<byte> GetAreaEntitiesPathBytes()
		{
			return this.__p.__vector_as_span<byte>(82, 1);
		}

		// Token: 0x0601BA2E RID: 113198 RVA: 0x003EB218 File Offset: 0x003E9418
		public byte[] GetAreaEntitiesPathArray()
		{
			return this.__p.__vector_as_array<byte>(82);
		}

		// Token: 0x17008104 RID: 33028
		// (get) Token: 0x0601BA2F RID: 113199 RVA: 0x003EB228 File Offset: 0x003E9428
		public string BtConfigPath
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA30 RID: 113200 RVA: 0x003EB260 File Offset: 0x003E9460
		public Span<byte> GetBtConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(84, 1);
		}

		// Token: 0x0601BA31 RID: 113201 RVA: 0x003EB270 File Offset: 0x003E9470
		public byte[] GetBtConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(84);
		}

		// Token: 0x17008105 RID: 33029
		// (get) Token: 0x0601BA32 RID: 113202 RVA: 0x003EB280 File Offset: 0x003E9480
		public string MontageConfigPath
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA33 RID: 113203 RVA: 0x003EB2B8 File Offset: 0x003E94B8
		public Span<byte> GetMontageConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(86, 1);
		}

		// Token: 0x0601BA34 RID: 113204 RVA: 0x003EB2C8 File Offset: 0x003E94C8
		public byte[] GetMontageConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(86);
		}

		// Token: 0x17008106 RID: 33030
		// (get) Token: 0x0601BA35 RID: 113205 RVA: 0x003EB2D8 File Offset: 0x003E94D8
		public string AbpMontageConfigPath
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA36 RID: 113206 RVA: 0x003EB310 File Offset: 0x003E9510
		public Span<byte> GetAbpMontageConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(88, 1);
		}

		// Token: 0x0601BA37 RID: 113207 RVA: 0x003EB320 File Offset: 0x003E9520
		public byte[] GetAbpMontageConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(88);
		}

		// Token: 0x17008107 RID: 33031
		// (get) Token: 0x0601BA38 RID: 113208 RVA: 0x003EB330 File Offset: 0x003E9530
		public string AbpOverlayMontageConfigPath
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA39 RID: 113209 RVA: 0x003EB368 File Offset: 0x003E9568
		public Span<byte> GetAbpOverlayMontageConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(90, 1);
		}

		// Token: 0x0601BA3A RID: 113210 RVA: 0x003EB378 File Offset: 0x003E9578
		public byte[] GetAbpOverlayMontageConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(90);
		}

		// Token: 0x17008108 RID: 33032
		// (get) Token: 0x0601BA3B RID: 113211 RVA: 0x003EB388 File Offset: 0x003E9588
		public string AbpStateConfigPath
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA3C RID: 113212 RVA: 0x003EB3C0 File Offset: 0x003E95C0
		public Span<byte> GetAbpStateConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(92, 1);
		}

		// Token: 0x0601BA3D RID: 113213 RVA: 0x003EB3D0 File Offset: 0x003E95D0
		public byte[] GetAbpStateConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(92);
		}

		// Token: 0x17008109 RID: 33033
		// (get) Token: 0x0601BA3E RID: 113214 RVA: 0x003EB3E0 File Offset: 0x003E95E0
		public string FaceExpressionConfigPath
		{
			get
			{
				int num = this.__p.__offset(94);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA3F RID: 113215 RVA: 0x003EB418 File Offset: 0x003E9618
		public Span<byte> GetFaceExpressionConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(94, 1);
		}

		// Token: 0x0601BA40 RID: 113216 RVA: 0x003EB428 File Offset: 0x003E9628
		public byte[] GetFaceExpressionConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(94);
		}

		// Token: 0x1700810A RID: 33034
		// (get) Token: 0x0601BA41 RID: 113217 RVA: 0x003EB438 File Offset: 0x003E9638
		public string AoiGroupPath
		{
			get
			{
				int num = this.__p.__offset(96);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA42 RID: 113218 RVA: 0x003EB470 File Offset: 0x003E9670
		public Span<byte> GetAoiGroupPathBytes()
		{
			return this.__p.__vector_as_span<byte>(96, 1);
		}

		// Token: 0x0601BA43 RID: 113219 RVA: 0x003EB480 File Offset: 0x003E9680
		public byte[] GetAoiGroupPathArray()
		{
			return this.__p.__vector_as_array<byte>(96);
		}

		// Token: 0x1700810B RID: 33035
		// (get) Token: 0x0601BA44 RID: 113220 RVA: 0x003EB490 File Offset: 0x003E9690
		public string EntityPerformanceDataPath
		{
			get
			{
				int num = this.__p.__offset(98);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA45 RID: 113221 RVA: 0x003EB4C8 File Offset: 0x003E96C8
		public Span<byte> GetEntityPerformanceDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(98, 1);
		}

		// Token: 0x0601BA46 RID: 113222 RVA: 0x003EB4D8 File Offset: 0x003E96D8
		public byte[] GetEntityPerformanceDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(98);
		}

		// Token: 0x1700810C RID: 33036
		// (get) Token: 0x0601BA47 RID: 113223 RVA: 0x003EB4E8 File Offset: 0x003E96E8
		public string ActorRefConfigPath
		{
			get
			{
				int num = this.__p.__offset(100);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA48 RID: 113224 RVA: 0x003EB520 File Offset: 0x003E9720
		public Span<byte> GetActorRefConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(100, 1);
		}

		// Token: 0x0601BA49 RID: 113225 RVA: 0x003EB530 File Offset: 0x003E9730
		public byte[] GetActorRefConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(100);
		}

		// Token: 0x1700810D RID: 33037
		// (get) Token: 0x0601BA4A RID: 113226 RVA: 0x003EB540 File Offset: 0x003E9740
		public string AoiDefineDataPath
		{
			get
			{
				int num = this.__p.__offset(102);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA4B RID: 113227 RVA: 0x003EB578 File Offset: 0x003E9778
		public Span<byte> GetAoiDefineDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(102, 1);
		}

		// Token: 0x0601BA4C RID: 113228 RVA: 0x003EB588 File Offset: 0x003E9788
		public byte[] GetAoiDefineDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(102);
		}

		// Token: 0x1700810E RID: 33038
		// (get) Token: 0x0601BA4D RID: 113229 RVA: 0x003EB598 File Offset: 0x003E9798
		public string PrefabDir
		{
			get
			{
				int num = this.__p.__offset(104);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA4E RID: 113230 RVA: 0x003EB5D0 File Offset: 0x003E97D0
		public Span<byte> GetPrefabDirBytes()
		{
			return this.__p.__vector_as_span<byte>(104, 1);
		}

		// Token: 0x0601BA4F RID: 113231 RVA: 0x003EB5E0 File Offset: 0x003E97E0
		public byte[] GetPrefabDirArray()
		{
			return this.__p.__vector_as_array<byte>(104);
		}

		// Token: 0x1700810F RID: 33039
		// (get) Token: 0x0601BA50 RID: 113232 RVA: 0x003EB5F0 File Offset: 0x003E97F0
		public string BundleDir
		{
			get
			{
				int num = this.__p.__offset(106);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA51 RID: 113233 RVA: 0x003EB628 File Offset: 0x003E9828
		public Span<byte> GetBundleDirBytes()
		{
			return this.__p.__vector_as_span<byte>(106, 1);
		}

		// Token: 0x0601BA52 RID: 113234 RVA: 0x003EB638 File Offset: 0x003E9838
		public byte[] GetBundleDirArray()
		{
			return this.__p.__vector_as_array<byte>(106);
		}

		// Token: 0x17008110 RID: 33040
		// (get) Token: 0x0601BA53 RID: 113235 RVA: 0x003EB648 File Offset: 0x003E9848
		public string PrefabConfigPath
		{
			get
			{
				int num = this.__p.__offset(108);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA54 RID: 113236 RVA: 0x003EB680 File Offset: 0x003E9880
		public Span<byte> GetPrefabConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(108, 1);
		}

		// Token: 0x0601BA55 RID: 113237 RVA: 0x003EB690 File Offset: 0x003E9890
		public byte[] GetPrefabConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(108);
		}

		// Token: 0x17008111 RID: 33041
		// (get) Token: 0x0601BA56 RID: 113238 RVA: 0x003EB6A0 File Offset: 0x003E98A0
		public string EditorStartConfig
		{
			get
			{
				int num = this.__p.__offset(110);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA57 RID: 113239 RVA: 0x003EB6D8 File Offset: 0x003E98D8
		public Span<byte> GetEditorStartConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(110, 1);
		}

		// Token: 0x0601BA58 RID: 113240 RVA: 0x003EB6E8 File Offset: 0x003E98E8
		public byte[] GetEditorStartConfigArray()
		{
			return this.__p.__vector_as_array<byte>(110);
		}

		// Token: 0x17008112 RID: 33042
		// (get) Token: 0x0601BA59 RID: 113241 RVA: 0x003EB6F8 File Offset: 0x003E98F8
		public string BubbleConfigPath
		{
			get
			{
				int num = this.__p.__offset(112);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA5A RID: 113242 RVA: 0x003EB730 File Offset: 0x003E9930
		public Span<byte> GetBubbleConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(112, 1);
		}

		// Token: 0x0601BA5B RID: 113243 RVA: 0x003EB740 File Offset: 0x003E9940
		public byte[] GetBubbleConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(112);
		}

		// Token: 0x17008113 RID: 33043
		// (get) Token: 0x0601BA5C RID: 113244 RVA: 0x003EB750 File Offset: 0x003E9950
		public string LevelEntityVoxelPath
		{
			get
			{
				int num = this.__p.__offset(114);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA5D RID: 113245 RVA: 0x003EB788 File Offset: 0x003E9988
		public Span<byte> GetLevelEntityVoxelPathBytes()
		{
			return this.__p.__vector_as_span<byte>(114, 1);
		}

		// Token: 0x0601BA5E RID: 113246 RVA: 0x003EB798 File Offset: 0x003E9998
		public byte[] GetLevelEntityVoxelPathArray()
		{
			return this.__p.__vector_as_array<byte>(114);
		}

		// Token: 0x17008114 RID: 33044
		// (get) Token: 0x0601BA5F RID: 113247 RVA: 0x003EB7A8 File Offset: 0x003E99A8
		public string TidTextTempPath
		{
			get
			{
				int num = this.__p.__offset(116);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA60 RID: 113248 RVA: 0x003EB7E0 File Offset: 0x003E99E0
		public Span<byte> GetTidTextTempPathBytes()
		{
			return this.__p.__vector_as_span<byte>(116, 1);
		}

		// Token: 0x0601BA61 RID: 113249 RVA: 0x003EB7F0 File Offset: 0x003E99F0
		public byte[] GetTidTextTempPathArray()
		{
			return this.__p.__vector_as_array<byte>(116);
		}

		// Token: 0x17008115 RID: 33045
		// (get) Token: 0x0601BA62 RID: 113250 RVA: 0x003EB800 File Offset: 0x003E9A00
		public string AudioStatePath
		{
			get
			{
				int num = this.__p.__offset(118);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA63 RID: 113251 RVA: 0x003EB838 File Offset: 0x003E9A38
		public Span<byte> GetAudioStatePathBytes()
		{
			return this.__p.__vector_as_span<byte>(118, 1);
		}

		// Token: 0x0601BA64 RID: 113252 RVA: 0x003EB848 File Offset: 0x003E9A48
		public byte[] GetAudioStatePathArray()
		{
			return this.__p.__vector_as_array<byte>(118);
		}

		// Token: 0x17008116 RID: 33046
		// (get) Token: 0x0601BA65 RID: 113253 RVA: 0x003EB858 File Offset: 0x003E9A58
		public string PlotHandBookPath
		{
			get
			{
				int num = this.__p.__offset(120);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA66 RID: 113254 RVA: 0x003EB890 File Offset: 0x003E9A90
		public Span<byte> GetPlotHandBookPathBytes()
		{
			return this.__p.__vector_as_span<byte>(120, 1);
		}

		// Token: 0x0601BA67 RID: 113255 RVA: 0x003EB8A0 File Offset: 0x003E9AA0
		public byte[] GetPlotHandBookPathArray()
		{
			return this.__p.__vector_as_array<byte>(120);
		}

		// Token: 0x17008117 RID: 33047
		// (get) Token: 0x0601BA68 RID: 113256 RVA: 0x003EB8B0 File Offset: 0x003E9AB0
		public string PlotPositionPath
		{
			get
			{
				int num = this.__p.__offset(122);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA69 RID: 113257 RVA: 0x003EB8E8 File Offset: 0x003E9AE8
		public Span<byte> GetPlotPositionPathBytes()
		{
			return this.__p.__vector_as_span<byte>(122, 1);
		}

		// Token: 0x0601BA6A RID: 113258 RVA: 0x003EB8F8 File Offset: 0x003E9AF8
		public byte[] GetPlotPositionPathArray()
		{
			return this.__p.__vector_as_array<byte>(122);
		}

		// Token: 0x17008118 RID: 33048
		// (get) Token: 0x0601BA6B RID: 113259 RVA: 0x003EB908 File Offset: 0x003E9B08
		public string TextLibraryDir
		{
			get
			{
				int num = this.__p.__offset(124);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA6C RID: 113260 RVA: 0x003EB940 File Offset: 0x003E9B40
		public Span<byte> GetTextLibraryDirBytes()
		{
			return this.__p.__vector_as_span<byte>(124, 1);
		}

		// Token: 0x0601BA6D RID: 113261 RVA: 0x003EB950 File Offset: 0x003E9B50
		public byte[] GetTextLibraryDirArray()
		{
			return this.__p.__vector_as_array<byte>(124);
		}

		// Token: 0x17008119 RID: 33049
		// (get) Token: 0x0601BA6E RID: 113262 RVA: 0x003EB960 File Offset: 0x003E9B60
		public string EnrichmentArea
		{
			get
			{
				int num = this.__p.__offset(126);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA6F RID: 113263 RVA: 0x003EB998 File Offset: 0x003E9B98
		public Span<byte> GetEnrichmentAreaBytes()
		{
			return this.__p.__vector_as_span<byte>(126, 1);
		}

		// Token: 0x0601BA70 RID: 113264 RVA: 0x003EB9A8 File Offset: 0x003E9BA8
		public byte[] GetEnrichmentAreaArray()
		{
			return this.__p.__vector_as_array<byte>(126);
		}

		// Token: 0x1700811A RID: 33050
		// (get) Token: 0x0601BA71 RID: 113265 RVA: 0x003EB9B8 File Offset: 0x003E9BB8
		public string MarkedErrorCsvPath
		{
			get
			{
				int num = this.__p.__offset(128);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA72 RID: 113266 RVA: 0x003EB9F3 File Offset: 0x003E9BF3
		public Span<byte> GetMarkedErrorCsvPathBytes()
		{
			return this.__p.__vector_as_span<byte>(128, 1);
		}

		// Token: 0x0601BA73 RID: 113267 RVA: 0x003EBA06 File Offset: 0x003E9C06
		public byte[] GetMarkedErrorCsvPathArray()
		{
			return this.__p.__vector_as_array<byte>(128);
		}

		// Token: 0x1700811B RID: 33051
		// (get) Token: 0x0601BA74 RID: 113268 RVA: 0x003EBA18 File Offset: 0x003E9C18
		public string BrokenRockConfig
		{
			get
			{
				int num = this.__p.__offset(130);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA75 RID: 113269 RVA: 0x003EBA53 File Offset: 0x003E9C53
		public Span<byte> GetBrokenRockConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(130, 1);
		}

		// Token: 0x0601BA76 RID: 113270 RVA: 0x003EBA66 File Offset: 0x003E9C66
		public byte[] GetBrokenRockConfigArray()
		{
			return this.__p.__vector_as_array<byte>(130);
		}

		// Token: 0x1700811C RID: 33052
		// (get) Token: 0x0601BA77 RID: 113271 RVA: 0x003EBA78 File Offset: 0x003E9C78
		public string GridItemShapeConfigPath
		{
			get
			{
				int num = this.__p.__offset(132);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA78 RID: 113272 RVA: 0x003EBAB3 File Offset: 0x003E9CB3
		public Span<byte> GetGridItemShapeConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(132, 1);
		}

		// Token: 0x0601BA79 RID: 113273 RVA: 0x003EBAC6 File Offset: 0x003E9CC6
		public byte[] GetGridItemShapeConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(132);
		}

		// Token: 0x1700811D RID: 33053
		// (get) Token: 0x0601BA7A RID: 113274 RVA: 0x003EBAD8 File Offset: 0x003E9CD8
		public string FishingRouletteConfig
		{
			get
			{
				int num = this.__p.__offset(134);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA7B RID: 113275 RVA: 0x003EBB13 File Offset: 0x003E9D13
		public Span<byte> GetFishingRouletteConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(134, 1);
		}

		// Token: 0x0601BA7C RID: 113276 RVA: 0x003EBB26 File Offset: 0x003E9D26
		public byte[] GetFishingRouletteConfigArray()
		{
			return this.__p.__vector_as_array<byte>(134);
		}

		// Token: 0x1700811E RID: 33054
		// (get) Token: 0x0601BA7D RID: 113277 RVA: 0x003EBB38 File Offset: 0x003E9D38
		public string AreaQuestTracking
		{
			get
			{
				int num = this.__p.__offset(136);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA7E RID: 113278 RVA: 0x003EBB73 File Offset: 0x003E9D73
		public Span<byte> GetAreaQuestTrackingBytes()
		{
			return this.__p.__vector_as_span<byte>(136, 1);
		}

		// Token: 0x0601BA7F RID: 113279 RVA: 0x003EBB86 File Offset: 0x003E9D86
		public byte[] GetAreaQuestTrackingArray()
		{
			return this.__p.__vector_as_array<byte>(136);
		}

		// Token: 0x1700811F RID: 33055
		// (get) Token: 0x0601BA80 RID: 113280 RVA: 0x003EBB98 File Offset: 0x003E9D98
		public string OfflineComponentExportPath
		{
			get
			{
				int num = this.__p.__offset(138);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA81 RID: 113281 RVA: 0x003EBBD3 File Offset: 0x003E9DD3
		public Span<byte> GetOfflineComponentExportPathBytes()
		{
			return this.__p.__vector_as_span<byte>(138, 1);
		}

		// Token: 0x0601BA82 RID: 113282 RVA: 0x003EBBE6 File Offset: 0x003E9DE6
		public byte[] GetOfflineComponentExportPathArray()
		{
			return this.__p.__vector_as_array<byte>(138);
		}

		// Token: 0x17008120 RID: 33056
		// (get) Token: 0x0601BA83 RID: 113283 RVA: 0x003EBBF8 File Offset: 0x003E9DF8
		public string SummonGongduolaConfigExportPath
		{
			get
			{
				int num = this.__p.__offset(140);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA84 RID: 113284 RVA: 0x003EBC33 File Offset: 0x003E9E33
		public Span<byte> GetSummonGongduolaConfigExportPathBytes()
		{
			return this.__p.__vector_as_span<byte>(140, 1);
		}

		// Token: 0x0601BA85 RID: 113285 RVA: 0x003EBC46 File Offset: 0x003E9E46
		public byte[] GetSummonGongduolaConfigExportPathArray()
		{
			return this.__p.__vector_as_array<byte>(140);
		}

		// Token: 0x17008121 RID: 33057
		// (get) Token: 0x0601BA86 RID: 113286 RVA: 0x003EBC58 File Offset: 0x003E9E58
		public string HideGroupFixConfigPath
		{
			get
			{
				int num = this.__p.__offset(142);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA87 RID: 113287 RVA: 0x003EBC93 File Offset: 0x003E9E93
		public Span<byte> GetHideGroupFixConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(142, 1);
		}

		// Token: 0x0601BA88 RID: 113288 RVA: 0x003EBCA6 File Offset: 0x003E9EA6
		public byte[] GetHideGroupFixConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(142);
		}

		// Token: 0x17008122 RID: 33058
		// (get) Token: 0x0601BA89 RID: 113289 RVA: 0x003EBCB8 File Offset: 0x003E9EB8
		public string EntityFixProcessorPath
		{
			get
			{
				int num = this.__p.__offset(144);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA8A RID: 113290 RVA: 0x003EBCF3 File Offset: 0x003E9EF3
		public Span<byte> GetEntityFixProcessorPathBytes()
		{
			return this.__p.__vector_as_span<byte>(144, 1);
		}

		// Token: 0x0601BA8B RID: 113291 RVA: 0x003EBD06 File Offset: 0x003E9F06
		public byte[] GetEntityFixProcessorPathArray()
		{
			return this.__p.__vector_as_array<byte>(144);
		}

		// Token: 0x17008123 RID: 33059
		// (get) Token: 0x0601BA8C RID: 113292 RVA: 0x003EBD18 File Offset: 0x003E9F18
		public string GravityAbnormalEntityListPath
		{
			get
			{
				int num = this.__p.__offset(146);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA8D RID: 113293 RVA: 0x003EBD53 File Offset: 0x003E9F53
		public Span<byte> GetGravityAbnormalEntityListPathBytes()
		{
			return this.__p.__vector_as_span<byte>(146, 1);
		}

		// Token: 0x0601BA8E RID: 113294 RVA: 0x003EBD66 File Offset: 0x003E9F66
		public byte[] GetGravityAbnormalEntityListPathArray()
		{
			return this.__p.__vector_as_array<byte>(146);
		}

		// Token: 0x17008124 RID: 33060
		// (get) Token: 0x0601BA8F RID: 113295 RVA: 0x003EBD78 File Offset: 0x003E9F78
		public string ActorRefComponentsConfigPath
		{
			get
			{
				int num = this.__p.__offset(148);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA90 RID: 113296 RVA: 0x003EBDB3 File Offset: 0x003E9FB3
		public Span<byte> GetActorRefComponentsConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(148, 1);
		}

		// Token: 0x0601BA91 RID: 113297 RVA: 0x003EBDC6 File Offset: 0x003E9FC6
		public byte[] GetActorRefComponentsConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(148);
		}

		// Token: 0x17008125 RID: 33061
		// (get) Token: 0x0601BA92 RID: 113298 RVA: 0x003EBDD8 File Offset: 0x003E9FD8
		public string SeqRefComponentsConfigPath
		{
			get
			{
				int num = this.__p.__offset(150);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA93 RID: 113299 RVA: 0x003EBE13 File Offset: 0x003EA013
		public Span<byte> GetSeqRefComponentsConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(150, 1);
		}

		// Token: 0x0601BA94 RID: 113300 RVA: 0x003EBE26 File Offset: 0x003EA026
		public byte[] GetSeqRefComponentsConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(150);
		}

		// Token: 0x17008126 RID: 33062
		// (get) Token: 0x0601BA95 RID: 113301 RVA: 0x003EBE38 File Offset: 0x003EA038
		public string QuestRefMp4Path
		{
			get
			{
				int num = this.__p.__offset(152);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA96 RID: 113302 RVA: 0x003EBE73 File Offset: 0x003EA073
		public Span<byte> GetQuestRefMp4PathBytes()
		{
			return this.__p.__vector_as_span<byte>(152, 1);
		}

		// Token: 0x0601BA97 RID: 113303 RVA: 0x003EBE86 File Offset: 0x003EA086
		public byte[] GetQuestRefMp4PathArray()
		{
			return this.__p.__vector_as_array<byte>(152);
		}

		// Token: 0x17008127 RID: 33063
		// (get) Token: 0x0601BA98 RID: 113304 RVA: 0x003EBE98 File Offset: 0x003EA098
		public string BehaviorTreeFragmentDir
		{
			get
			{
				int num = this.__p.__offset(154);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA99 RID: 113305 RVA: 0x003EBED3 File Offset: 0x003EA0D3
		public Span<byte> GetBehaviorTreeFragmentDirBytes()
		{
			return this.__p.__vector_as_span<byte>(154, 1);
		}

		// Token: 0x0601BA9A RID: 113306 RVA: 0x003EBEE6 File Offset: 0x003EA0E6
		public byte[] GetBehaviorTreeFragmentDirArray()
		{
			return this.__p.__vector_as_array<byte>(154);
		}

		// Token: 0x17008128 RID: 33064
		// (get) Token: 0x0601BA9B RID: 113307 RVA: 0x003EBEF8 File Offset: 0x003EA0F8
		public string CommonBtDir
		{
			get
			{
				int num = this.__p.__offset(156);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA9C RID: 113308 RVA: 0x003EBF33 File Offset: 0x003EA133
		public Span<byte> GetCommonBtDirBytes()
		{
			return this.__p.__vector_as_span<byte>(156, 1);
		}

		// Token: 0x0601BA9D RID: 113309 RVA: 0x003EBF46 File Offset: 0x003EA146
		public byte[] GetCommonBtDirArray()
		{
			return this.__p.__vector_as_array<byte>(156);
		}

		// Token: 0x17008129 RID: 33065
		// (get) Token: 0x0601BA9E RID: 113310 RVA: 0x003EBF58 File Offset: 0x003EA158
		public string CommonBtExportDir
		{
			get
			{
				int num = this.__p.__offset(158);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA9F RID: 113311 RVA: 0x003EBF93 File Offset: 0x003EA193
		public Span<byte> GetCommonBtExportDirBytes()
		{
			return this.__p.__vector_as_span<byte>(158, 1);
		}

		// Token: 0x0601BAA0 RID: 113312 RVA: 0x003EBFA6 File Offset: 0x003EA1A6
		public byte[] GetCommonBtExportDirArray()
		{
			return this.__p.__vector_as_array<byte>(158);
		}

		// Token: 0x1700812A RID: 33066
		// (get) Token: 0x0601BAA1 RID: 113313 RVA: 0x003EBFB8 File Offset: 0x003EA1B8
		public string LevelBuildingGrids
		{
			get
			{
				int num = this.__p.__offset(160);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BAA2 RID: 113314 RVA: 0x003EBFF3 File Offset: 0x003EA1F3
		public Span<byte> GetLevelBuildingGridsBytes()
		{
			return this.__p.__vector_as_span<byte>(160, 1);
		}

		// Token: 0x0601BAA3 RID: 113315 RVA: 0x003EC006 File Offset: 0x003EA206
		public byte[] GetLevelBuildingGridsArray()
		{
			return this.__p.__vector_as_array<byte>(160);
		}

		// Token: 0x1700812B RID: 33067
		// (get) Token: 0x0601BAA4 RID: 113316 RVA: 0x003EC018 File Offset: 0x003EA218
		public string GlobalFixConfigPath
		{
			get
			{
				int num = this.__p.__offset(162);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BAA5 RID: 113317 RVA: 0x003EC053 File Offset: 0x003EA253
		public Span<byte> GetGlobalFixConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(162, 1);
		}

		// Token: 0x0601BAA6 RID: 113318 RVA: 0x003EC066 File Offset: 0x003EA266
		public byte[] GetGlobalFixConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(162);
		}

		// Token: 0x1700812C RID: 33068
		// (get) Token: 0x0601BAA7 RID: 113319 RVA: 0x003EC078 File Offset: 0x003EA278
		public string AreaFunctionConfigPath
		{
			get
			{
				int num = this.__p.__offset(164);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BAA8 RID: 113320 RVA: 0x003EC0B3 File Offset: 0x003EA2B3
		public Span<byte> GetAreaFunctionConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(164, 1);
		}

		// Token: 0x0601BAA9 RID: 113321 RVA: 0x003EC0C6 File Offset: 0x003EA2C6
		public byte[] GetAreaFunctionConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(164);
		}

		// Token: 0x1700812D RID: 33069
		// (get) Token: 0x0601BAAA RID: 113322 RVA: 0x003EC0D8 File Offset: 0x003EA2D8
		public string DynamicSpawnMonsterRandomPoolConfigPath
		{
			get
			{
				int num = this.__p.__offset(166);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BAAB RID: 113323 RVA: 0x003EC113 File Offset: 0x003EA313
		public Span<byte> GetDynamicSpawnMonsterRandomPoolConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(166, 1);
		}

		// Token: 0x0601BAAC RID: 113324 RVA: 0x003EC126 File Offset: 0x003EA326
		public byte[] GetDynamicSpawnMonsterRandomPoolConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(166);
		}

		// Token: 0x1700812E RID: 33070
		// (get) Token: 0x0601BAAD RID: 113325 RVA: 0x003EC138 File Offset: 0x003EA338
		public string EntityCustomPrimitiveData
		{
			get
			{
				int num = this.__p.__offset(168);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BAAE RID: 113326 RVA: 0x003EC173 File Offset: 0x003EA373
		public Span<byte> GetEntityCustomPrimitiveDataBytes()
		{
			return this.__p.__vector_as_span<byte>(168, 1);
		}

		// Token: 0x0601BAAF RID: 113327 RVA: 0x003EC186 File Offset: 0x003EA386
		public byte[] GetEntityCustomPrimitiveDataArray()
		{
			return this.__p.__vector_as_array<byte>(168);
		}

		// Token: 0x1700812F RID: 33071
		// (get) Token: 0x0601BAB0 RID: 113328 RVA: 0x003EC198 File Offset: 0x003EA398
		public string AnimalStandbyTagPath
		{
			get
			{
				int num = this.__p.__offset(170);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BAB1 RID: 113329 RVA: 0x003EC1D3 File Offset: 0x003EA3D3
		public Span<byte> GetAnimalStandbyTagPathBytes()
		{
			return this.__p.__vector_as_span<byte>(170, 1);
		}

		// Token: 0x0601BAB2 RID: 113330 RVA: 0x003EC1E6 File Offset: 0x003EA3E6
		public byte[] GetAnimalStandbyTagPathArray()
		{
			return this.__p.__vector_as_array<byte>(170);
		}

		// Token: 0x17008130 RID: 33072
		// (get) Token: 0x0601BAB3 RID: 113331 RVA: 0x003EC1F8 File Offset: 0x003EA3F8
		public string AnsPerformDataPath
		{
			get
			{
				int num = this.__p.__offset(172);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BAB4 RID: 113332 RVA: 0x003EC233 File Offset: 0x003EA433
		public Span<byte> GetAnsPerformDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(172, 1);
		}

		// Token: 0x0601BAB5 RID: 113333 RVA: 0x003EC246 File Offset: 0x003EA446
		public byte[] GetAnsPerformDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(172);
		}

		// Token: 0x17008131 RID: 33073
		// (get) Token: 0x0601BAB6 RID: 113334 RVA: 0x003EC258 File Offset: 0x003EA458
		public string RoadZonePath
		{
			get
			{
				int num = this.__p.__offset(174);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BAB7 RID: 113335 RVA: 0x003EC293 File Offset: 0x003EA493
		public Span<byte> GetRoadZonePathBytes()
		{
			return this.__p.__vector_as_span<byte>(174, 1);
		}

		// Token: 0x0601BAB8 RID: 113336 RVA: 0x003EC2A6 File Offset: 0x003EA4A6
		public byte[] GetRoadZonePathArray()
		{
			return this.__p.__vector_as_array<byte>(174);
		}

		// Token: 0x17008132 RID: 33074
		// (get) Token: 0x0601BAB9 RID: 113337 RVA: 0x003EC2B8 File Offset: 0x003EA4B8
		public string UltraLeaveRadiusLevelPlayPath
		{
			get
			{
				int num = this.__p.__offset(176);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BABA RID: 113338 RVA: 0x003EC2F3 File Offset: 0x003EA4F3
		public Span<byte> GetUltraLeaveRadiusLevelPlayPathBytes()
		{
			return this.__p.__vector_as_span<byte>(176, 1);
		}

		// Token: 0x0601BABB RID: 113339 RVA: 0x003EC306 File Offset: 0x003EA506
		public byte[] GetUltraLeaveRadiusLevelPlayPathArray()
		{
			return this.__p.__vector_as_array<byte>(176);
		}

		// Token: 0x17008133 RID: 33075
		// (get) Token: 0x0601BABC RID: 113340 RVA: 0x003EC318 File Offset: 0x003EA518
		public string AreaTeleportPath
		{
			get
			{
				int num = this.__p.__offset(178);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BABD RID: 113341 RVA: 0x003EC353 File Offset: 0x003EA553
		public Span<byte> GetAreaTeleportPathBytes()
		{
			return this.__p.__vector_as_span<byte>(178, 1);
		}

		// Token: 0x0601BABE RID: 113342 RVA: 0x003EC366 File Offset: 0x003EA566
		public byte[] GetAreaTeleportPathArray()
		{
			return this.__p.__vector_as_array<byte>(178);
		}

		// Token: 0x17008134 RID: 33076
		// (get) Token: 0x0601BABF RID: 113343 RVA: 0x003EC378 File Offset: 0x003EA578
		public string SeqAreaPath
		{
			get
			{
				int num = this.__p.__offset(180);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BAC0 RID: 113344 RVA: 0x003EC3B3 File Offset: 0x003EA5B3
		public Span<byte> GetSeqAreaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(180, 1);
		}

		// Token: 0x0601BAC1 RID: 113345 RVA: 0x003EC3C6 File Offset: 0x003EA5C6
		public byte[] GetSeqAreaPathArray()
		{
			return this.__p.__vector_as_array<byte>(180);
		}

		// Token: 0x17008135 RID: 33077
		// (get) Token: 0x0601BAC2 RID: 113346 RVA: 0x003EC3D8 File Offset: 0x003EA5D8
		public string DungeonAreaOwnerDataPath
		{
			get
			{
				int num = this.__p.__offset(182);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BAC3 RID: 113347 RVA: 0x003EC413 File Offset: 0x003EA613
		public Span<byte> GetDungeonAreaOwnerDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(182, 1);
		}

		// Token: 0x0601BAC4 RID: 113348 RVA: 0x003EC426 File Offset: 0x003EA626
		public byte[] GetDungeonAreaOwnerDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(182);
		}

		// Token: 0x17008136 RID: 33078
		// (get) Token: 0x0601BAC5 RID: 113349 RVA: 0x003EC438 File Offset: 0x003EA638
		public string DungeonAreaReachableDataPath
		{
			get
			{
				int num = this.__p.__offset(184);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BAC6 RID: 113350 RVA: 0x003EC473 File Offset: 0x003EA673
		public Span<byte> GetDungeonAreaReachableDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(184, 1);
		}

		// Token: 0x0601BAC7 RID: 113351 RVA: 0x003EC486 File Offset: 0x003EA686
		public byte[] GetDungeonAreaReachableDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(184);
		}

		// Token: 0x17008137 RID: 33079
		// (get) Token: 0x0601BAC8 RID: 113352 RVA: 0x003EC498 File Offset: 0x003EA698
		public string TimeSchedulePath
		{
			get
			{
				int num = this.__p.__offset(186);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BAC9 RID: 113353 RVA: 0x003EC4D3 File Offset: 0x003EA6D3
		public Span<byte> GetTimeSchedulePathBytes()
		{
			return this.__p.__vector_as_span<byte>(186, 1);
		}

		// Token: 0x0601BACA RID: 113354 RVA: 0x003EC4E6 File Offset: 0x003EA6E6
		public byte[] GetTimeSchedulePathArray()
		{
			return this.__p.__vector_as_array<byte>(186);
		}

		// Token: 0x17008138 RID: 33080
		// (get) Token: 0x0601BACB RID: 113355 RVA: 0x003EC4F8 File Offset: 0x003EA6F8
		public string AiBehaviorTreePath
		{
			get
			{
				int num = this.__p.__offset(188);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BACC RID: 113356 RVA: 0x003EC533 File Offset: 0x003EA733
		public Span<byte> GetAiBehaviorTreePathBytes()
		{
			return this.__p.__vector_as_span<byte>(188, 1);
		}

		// Token: 0x0601BACD RID: 113357 RVA: 0x003EC546 File Offset: 0x003EA746
		public byte[] GetAiBehaviorTreePathArray()
		{
			return this.__p.__vector_as_array<byte>(188);
		}

		// Token: 0x17008139 RID: 33081
		// (get) Token: 0x0601BACE RID: 113358 RVA: 0x003EC558 File Offset: 0x003EA758
		public string RecallDataConfigPath
		{
			get
			{
				int num = this.__p.__offset(190);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BACF RID: 113359 RVA: 0x003EC593 File Offset: 0x003EA793
		public Span<byte> GetRecallDataConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(190, 1);
		}

		// Token: 0x0601BAD0 RID: 113360 RVA: 0x003EC5A6 File Offset: 0x003EA7A6
		public byte[] GetRecallDataConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(190);
		}

		// Token: 0x1700813A RID: 33082
		// (get) Token: 0x0601BAD1 RID: 113361 RVA: 0x003EC5B8 File Offset: 0x003EA7B8
		public string CombatOperationCaptureDir
		{
			get
			{
				int num = this.__p.__offset(192);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BAD2 RID: 113362 RVA: 0x003EC5F3 File Offset: 0x003EA7F3
		public Span<byte> GetCombatOperationCaptureDirBytes()
		{
			return this.__p.__vector_as_span<byte>(192, 1);
		}

		// Token: 0x0601BAD3 RID: 113363 RVA: 0x003EC606 File Offset: 0x003EA806
		public byte[] GetCombatOperationCaptureDirArray()
		{
			return this.__p.__vector_as_array<byte>(192);
		}

		// Token: 0x1700813B RID: 33083
		// (get) Token: 0x0601BAD4 RID: 113364 RVA: 0x003EC618 File Offset: 0x003EA818
		public string RecallEntityConfigPath
		{
			get
			{
				int num = this.__p.__offset(194);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BAD5 RID: 113365 RVA: 0x003EC653 File Offset: 0x003EA853
		public Span<byte> GetRecallEntityConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(194, 1);
		}

		// Token: 0x0601BAD6 RID: 113366 RVA: 0x003EC666 File Offset: 0x003EA866
		public byte[] GetRecallEntityConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(194);
		}

		// Token: 0x0601BAD7 RID: 113367 RVA: 0x003EC678 File Offset: 0x003EA878
		public static Offset<IGlobalConfig> CreateIGlobalConfig(FlatBufferBuilder builder, StringOffset ActionConfigPathOffset = default(StringOffset), StringOffset ComponentConfigPathOffset = default(StringOffset), StringOffset EntityConfigPathOffset = default(StringOffset), StringOffset BlueprintConfigPathOffset = default(StringOffset), StringOffset LevelsConfigPathOffset = default(StringOffset), StringOffset SubWpMapConfigPathOffset = default(StringOffset), StringOffset LevelsDirOffset = default(StringOffset), StringOffset LevelsDataDirOffset = default(StringOffset), StringOffset TemplateDirOffset = default(StringOffset), StringOffset TemplateConfigPathOffset = default(StringOffset), StringOffset EntityDataConfigPathOffset = default(StringOffset), StringOffset TypeScriptRootOffset = default(StringOffset), StringOffset CsvFileDirOffset = default(StringOffset), StringOffset FlowListDirOffset = default(StringOffset), StringOffset QuestListDirOffset = default(StringOffset), StringOffset QuestListExportDirOffset = default(StringOffset), StringOffset EntityStateConfigPathOffset = default(StringOffset), StringOffset EntityOwnerConfigPathOffset = default(StringOffset), StringOffset ChildEntityOwnerConfigPathOffset = default(StringOffset), StringOffset AlwaysLoadEntityConfigPathOffset = default(StringOffset), StringOffset LevelPlayListDirOffset = default(StringOffset), StringOffset LevelPlayListExportDirOffset = default(StringOffset), StringOffset DynamicLevelPlayListExportDirOffset = default(StringOffset), StringOffset TwoDimensionLevelListDirOffset = default(StringOffset), StringOffset DangoBrawlObjectTemplateDirOffset = default(StringOffset), StringOffset MarbleLevelConfigPathOffset = default(StringOffset), StringOffset DangoBrawlLevelConfigPathOffset = default(StringOffset), StringOffset DangoBrawlObjectTemplateConfigPathOffset = default(StringOffset), StringOffset FunctionalTestDirOffset = default(StringOffset), StringOffset FlowTemplateConfigPathOffset = default(StringOffset), StringOffset FlowTemplateCameraDirOffset = default(StringOffset), StringOffset FlowTemplateCameraConfigPathOffset = default(StringOffset), StringOffset FlowTemplateCameraConfgSourcePathOffset = default(StringOffset), StringOffset GlobalVarConfigPathOffset = default(StringOffset), StringOffset SystemVarConfigPathOffset = default(StringOffset), StringOffset VehicleRidingRolesConfigPathOffset = default(StringOffset), StringOffset OccupationConfigPathOffset = default(StringOffset), StringOffset OccupiedExportPathOffset = default(StringOffset), StringOffset InteractOptionConfigPathOffset = default(StringOffset), StringOffset AreaEntitiesPathOffset = default(StringOffset), StringOffset BtConfigPathOffset = default(StringOffset), StringOffset MontageConfigPathOffset = default(StringOffset), StringOffset AbpMontageConfigPathOffset = default(StringOffset), StringOffset AbpOverlayMontageConfigPathOffset = default(StringOffset), StringOffset AbpStateConfigPathOffset = default(StringOffset), StringOffset FaceExpressionConfigPathOffset = default(StringOffset), StringOffset AoiGroupPathOffset = default(StringOffset), StringOffset EntityPerformanceDataPathOffset = default(StringOffset), StringOffset ActorRefConfigPathOffset = default(StringOffset), StringOffset AoiDefineDataPathOffset = default(StringOffset), StringOffset PrefabDirOffset = default(StringOffset), StringOffset BundleDirOffset = default(StringOffset), StringOffset PrefabConfigPathOffset = default(StringOffset), StringOffset EditorStartConfigOffset = default(StringOffset), StringOffset BubbleConfigPathOffset = default(StringOffset), StringOffset LevelEntityVoxelPathOffset = default(StringOffset), StringOffset TidTextTempPathOffset = default(StringOffset), StringOffset AudioStatePathOffset = default(StringOffset), StringOffset PlotHandBookPathOffset = default(StringOffset), StringOffset PlotPositionPathOffset = default(StringOffset), StringOffset TextLibraryDirOffset = default(StringOffset), StringOffset EnrichmentAreaOffset = default(StringOffset), StringOffset MarkedErrorCsvPathOffset = default(StringOffset), StringOffset BrokenRockConfigOffset = default(StringOffset), StringOffset GridItemShapeConfigPathOffset = default(StringOffset), StringOffset FishingRouletteConfigOffset = default(StringOffset), StringOffset AreaQuestTrackingOffset = default(StringOffset), StringOffset OfflineComponentExportPathOffset = default(StringOffset), StringOffset SummonGongduolaConfigExportPathOffset = default(StringOffset), StringOffset HideGroupFixConfigPathOffset = default(StringOffset), StringOffset EntityFixProcessorPathOffset = default(StringOffset), StringOffset GravityAbnormalEntityListPathOffset = default(StringOffset), StringOffset ActorRefComponentsConfigPathOffset = default(StringOffset), StringOffset SeqRefComponentsConfigPathOffset = default(StringOffset), StringOffset QuestRefMp4PathOffset = default(StringOffset), StringOffset BehaviorTreeFragmentDirOffset = default(StringOffset), StringOffset CommonBtDirOffset = default(StringOffset), StringOffset CommonBtExportDirOffset = default(StringOffset), StringOffset LevelBuildingGridsOffset = default(StringOffset), StringOffset GlobalFixConfigPathOffset = default(StringOffset), StringOffset AreaFunctionConfigPathOffset = default(StringOffset), StringOffset DynamicSpawnMonsterRandomPoolConfigPathOffset = default(StringOffset), StringOffset EntityCustomPrimitiveDataOffset = default(StringOffset), StringOffset AnimalStandbyTagPathOffset = default(StringOffset), StringOffset AnsPerformDataPathOffset = default(StringOffset), StringOffset RoadZonePathOffset = default(StringOffset), StringOffset UltraLeaveRadiusLevelPlayPathOffset = default(StringOffset), StringOffset AreaTeleportPathOffset = default(StringOffset), StringOffset SeqAreaPathOffset = default(StringOffset), StringOffset DungeonAreaOwnerDataPathOffset = default(StringOffset), StringOffset DungeonAreaReachableDataPathOffset = default(StringOffset), StringOffset TimeSchedulePathOffset = default(StringOffset), StringOffset AiBehaviorTreePathOffset = default(StringOffset), StringOffset RecallDataConfigPathOffset = default(StringOffset), StringOffset CombatOperationCaptureDirOffset = default(StringOffset), StringOffset RecallEntityConfigPathOffset = default(StringOffset))
		{
			builder.StartTable(96);
			IGlobalConfig.AddRecallEntityConfigPath(builder, RecallEntityConfigPathOffset);
			IGlobalConfig.AddCombatOperationCaptureDir(builder, CombatOperationCaptureDirOffset);
			IGlobalConfig.AddRecallDataConfigPath(builder, RecallDataConfigPathOffset);
			IGlobalConfig.AddAiBehaviorTreePath(builder, AiBehaviorTreePathOffset);
			IGlobalConfig.AddTimeSchedulePath(builder, TimeSchedulePathOffset);
			IGlobalConfig.AddDungeonAreaReachableDataPath(builder, DungeonAreaReachableDataPathOffset);
			IGlobalConfig.AddDungeonAreaOwnerDataPath(builder, DungeonAreaOwnerDataPathOffset);
			IGlobalConfig.AddSeqAreaPath(builder, SeqAreaPathOffset);
			IGlobalConfig.AddAreaTeleportPath(builder, AreaTeleportPathOffset);
			IGlobalConfig.AddUltraLeaveRadiusLevelPlayPath(builder, UltraLeaveRadiusLevelPlayPathOffset);
			IGlobalConfig.AddRoadZonePath(builder, RoadZonePathOffset);
			IGlobalConfig.AddAnsPerformDataPath(builder, AnsPerformDataPathOffset);
			IGlobalConfig.AddAnimalStandbyTagPath(builder, AnimalStandbyTagPathOffset);
			IGlobalConfig.AddEntityCustomPrimitiveData(builder, EntityCustomPrimitiveDataOffset);
			IGlobalConfig.AddDynamicSpawnMonsterRandomPoolConfigPath(builder, DynamicSpawnMonsterRandomPoolConfigPathOffset);
			IGlobalConfig.AddAreaFunctionConfigPath(builder, AreaFunctionConfigPathOffset);
			IGlobalConfig.AddGlobalFixConfigPath(builder, GlobalFixConfigPathOffset);
			IGlobalConfig.AddLevelBuildingGrids(builder, LevelBuildingGridsOffset);
			IGlobalConfig.AddCommonBtExportDir(builder, CommonBtExportDirOffset);
			IGlobalConfig.AddCommonBtDir(builder, CommonBtDirOffset);
			IGlobalConfig.AddBehaviorTreeFragmentDir(builder, BehaviorTreeFragmentDirOffset);
			IGlobalConfig.AddQuestRefMp4Path(builder, QuestRefMp4PathOffset);
			IGlobalConfig.AddSeqRefComponentsConfigPath(builder, SeqRefComponentsConfigPathOffset);
			IGlobalConfig.AddActorRefComponentsConfigPath(builder, ActorRefComponentsConfigPathOffset);
			IGlobalConfig.AddGravityAbnormalEntityListPath(builder, GravityAbnormalEntityListPathOffset);
			IGlobalConfig.AddEntityFixProcessorPath(builder, EntityFixProcessorPathOffset);
			IGlobalConfig.AddHideGroupFixConfigPath(builder, HideGroupFixConfigPathOffset);
			IGlobalConfig.AddSummonGongduolaConfigExportPath(builder, SummonGongduolaConfigExportPathOffset);
			IGlobalConfig.AddOfflineComponentExportPath(builder, OfflineComponentExportPathOffset);
			IGlobalConfig.AddAreaQuestTracking(builder, AreaQuestTrackingOffset);
			IGlobalConfig.AddFishingRouletteConfig(builder, FishingRouletteConfigOffset);
			IGlobalConfig.AddGridItemShapeConfigPath(builder, GridItemShapeConfigPathOffset);
			IGlobalConfig.AddBrokenRockConfig(builder, BrokenRockConfigOffset);
			IGlobalConfig.AddMarkedErrorCsvPath(builder, MarkedErrorCsvPathOffset);
			IGlobalConfig.AddEnrichmentArea(builder, EnrichmentAreaOffset);
			IGlobalConfig.AddTextLibraryDir(builder, TextLibraryDirOffset);
			IGlobalConfig.AddPlotPositionPath(builder, PlotPositionPathOffset);
			IGlobalConfig.AddPlotHandBookPath(builder, PlotHandBookPathOffset);
			IGlobalConfig.AddAudioStatePath(builder, AudioStatePathOffset);
			IGlobalConfig.AddTidTextTempPath(builder, TidTextTempPathOffset);
			IGlobalConfig.AddLevelEntityVoxelPath(builder, LevelEntityVoxelPathOffset);
			IGlobalConfig.AddBubbleConfigPath(builder, BubbleConfigPathOffset);
			IGlobalConfig.AddEditorStartConfig(builder, EditorStartConfigOffset);
			IGlobalConfig.AddPrefabConfigPath(builder, PrefabConfigPathOffset);
			IGlobalConfig.AddBundleDir(builder, BundleDirOffset);
			IGlobalConfig.AddPrefabDir(builder, PrefabDirOffset);
			IGlobalConfig.AddAoiDefineDataPath(builder, AoiDefineDataPathOffset);
			IGlobalConfig.AddActorRefConfigPath(builder, ActorRefConfigPathOffset);
			IGlobalConfig.AddEntityPerformanceDataPath(builder, EntityPerformanceDataPathOffset);
			IGlobalConfig.AddAoiGroupPath(builder, AoiGroupPathOffset);
			IGlobalConfig.AddFaceExpressionConfigPath(builder, FaceExpressionConfigPathOffset);
			IGlobalConfig.AddAbpStateConfigPath(builder, AbpStateConfigPathOffset);
			IGlobalConfig.AddAbpOverlayMontageConfigPath(builder, AbpOverlayMontageConfigPathOffset);
			IGlobalConfig.AddAbpMontageConfigPath(builder, AbpMontageConfigPathOffset);
			IGlobalConfig.AddMontageConfigPath(builder, MontageConfigPathOffset);
			IGlobalConfig.AddBtConfigPath(builder, BtConfigPathOffset);
			IGlobalConfig.AddAreaEntitiesPath(builder, AreaEntitiesPathOffset);
			IGlobalConfig.AddInteractOptionConfigPath(builder, InteractOptionConfigPathOffset);
			IGlobalConfig.AddOccupiedExportPath(builder, OccupiedExportPathOffset);
			IGlobalConfig.AddOccupationConfigPath(builder, OccupationConfigPathOffset);
			IGlobalConfig.AddVehicleRidingRolesConfigPath(builder, VehicleRidingRolesConfigPathOffset);
			IGlobalConfig.AddSystemVarConfigPath(builder, SystemVarConfigPathOffset);
			IGlobalConfig.AddGlobalVarConfigPath(builder, GlobalVarConfigPathOffset);
			IGlobalConfig.AddFlowTemplateCameraConfgSourcePath(builder, FlowTemplateCameraConfgSourcePathOffset);
			IGlobalConfig.AddFlowTemplateCameraConfigPath(builder, FlowTemplateCameraConfigPathOffset);
			IGlobalConfig.AddFlowTemplateCameraDir(builder, FlowTemplateCameraDirOffset);
			IGlobalConfig.AddFlowTemplateConfigPath(builder, FlowTemplateConfigPathOffset);
			IGlobalConfig.AddFunctionalTestDir(builder, FunctionalTestDirOffset);
			IGlobalConfig.AddDangoBrawlObjectTemplateConfigPath(builder, DangoBrawlObjectTemplateConfigPathOffset);
			IGlobalConfig.AddDangoBrawlLevelConfigPath(builder, DangoBrawlLevelConfigPathOffset);
			IGlobalConfig.AddMarbleLevelConfigPath(builder, MarbleLevelConfigPathOffset);
			IGlobalConfig.AddDangoBrawlObjectTemplateDir(builder, DangoBrawlObjectTemplateDirOffset);
			IGlobalConfig.AddTwoDimensionLevelListDir(builder, TwoDimensionLevelListDirOffset);
			IGlobalConfig.AddDynamicLevelPlayListExportDir(builder, DynamicLevelPlayListExportDirOffset);
			IGlobalConfig.AddLevelPlayListExportDir(builder, LevelPlayListExportDirOffset);
			IGlobalConfig.AddLevelPlayListDir(builder, LevelPlayListDirOffset);
			IGlobalConfig.AddAlwaysLoadEntityConfigPath(builder, AlwaysLoadEntityConfigPathOffset);
			IGlobalConfig.AddChildEntityOwnerConfigPath(builder, ChildEntityOwnerConfigPathOffset);
			IGlobalConfig.AddEntityOwnerConfigPath(builder, EntityOwnerConfigPathOffset);
			IGlobalConfig.AddEntityStateConfigPath(builder, EntityStateConfigPathOffset);
			IGlobalConfig.AddQuestListExportDir(builder, QuestListExportDirOffset);
			IGlobalConfig.AddQuestListDir(builder, QuestListDirOffset);
			IGlobalConfig.AddFlowListDir(builder, FlowListDirOffset);
			IGlobalConfig.AddCsvFileDir(builder, CsvFileDirOffset);
			IGlobalConfig.AddTypeScriptRoot(builder, TypeScriptRootOffset);
			IGlobalConfig.AddEntityDataConfigPath(builder, EntityDataConfigPathOffset);
			IGlobalConfig.AddTemplateConfigPath(builder, TemplateConfigPathOffset);
			IGlobalConfig.AddTemplateDir(builder, TemplateDirOffset);
			IGlobalConfig.AddLevelsDataDir(builder, LevelsDataDirOffset);
			IGlobalConfig.AddLevelsDir(builder, LevelsDirOffset);
			IGlobalConfig.AddSubWpMapConfigPath(builder, SubWpMapConfigPathOffset);
			IGlobalConfig.AddLevelsConfigPath(builder, LevelsConfigPathOffset);
			IGlobalConfig.AddBlueprintConfigPath(builder, BlueprintConfigPathOffset);
			IGlobalConfig.AddEntityConfigPath(builder, EntityConfigPathOffset);
			IGlobalConfig.AddComponentConfigPath(builder, ComponentConfigPathOffset);
			IGlobalConfig.AddActionConfigPath(builder, ActionConfigPathOffset);
			return IGlobalConfig.EndIGlobalConfig(builder);
		}

		// Token: 0x0601BAD8 RID: 113368 RVA: 0x003EC990 File Offset: 0x003EAB90
		public static void StartIGlobalConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(96);
		}

		// Token: 0x0601BAD9 RID: 113369 RVA: 0x003EC99A File Offset: 0x003EAB9A
		public static void AddActionConfigPath(FlatBufferBuilder builder, StringOffset actionConfigPathOffset)
		{
			builder.AddOffset(0, actionConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BADA RID: 113370 RVA: 0x003EC9AA File Offset: 0x003EABAA
		public static void AddComponentConfigPath(FlatBufferBuilder builder, StringOffset componentConfigPathOffset)
		{
			builder.AddOffset(1, componentConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BADB RID: 113371 RVA: 0x003EC9BA File Offset: 0x003EABBA
		public static void AddEntityConfigPath(FlatBufferBuilder builder, StringOffset entityConfigPathOffset)
		{
			builder.AddOffset(2, entityConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BADC RID: 113372 RVA: 0x003EC9CA File Offset: 0x003EABCA
		public static void AddBlueprintConfigPath(FlatBufferBuilder builder, StringOffset blueprintConfigPathOffset)
		{
			builder.AddOffset(3, blueprintConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BADD RID: 113373 RVA: 0x003EC9DA File Offset: 0x003EABDA
		public static void AddLevelsConfigPath(FlatBufferBuilder builder, StringOffset levelsConfigPathOffset)
		{
			builder.AddOffset(4, levelsConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BADE RID: 113374 RVA: 0x003EC9EA File Offset: 0x003EABEA
		public static void AddSubWpMapConfigPath(FlatBufferBuilder builder, StringOffset subWpMapConfigPathOffset)
		{
			builder.AddOffset(5, subWpMapConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BADF RID: 113375 RVA: 0x003EC9FA File Offset: 0x003EABFA
		public static void AddLevelsDir(FlatBufferBuilder builder, StringOffset levelsDirOffset)
		{
			builder.AddOffset(6, levelsDirOffset.Value, 0);
		}

		// Token: 0x0601BAE0 RID: 113376 RVA: 0x003ECA0A File Offset: 0x003EAC0A
		public static void AddLevelsDataDir(FlatBufferBuilder builder, StringOffset levelsDataDirOffset)
		{
			builder.AddOffset(7, levelsDataDirOffset.Value, 0);
		}

		// Token: 0x0601BAE1 RID: 113377 RVA: 0x003ECA1A File Offset: 0x003EAC1A
		public static void AddTemplateDir(FlatBufferBuilder builder, StringOffset templateDirOffset)
		{
			builder.AddOffset(8, templateDirOffset.Value, 0);
		}

		// Token: 0x0601BAE2 RID: 113378 RVA: 0x003ECA2A File Offset: 0x003EAC2A
		public static void AddTemplateConfigPath(FlatBufferBuilder builder, StringOffset templateConfigPathOffset)
		{
			builder.AddOffset(9, templateConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BAE3 RID: 113379 RVA: 0x003ECA3B File Offset: 0x003EAC3B
		public static void AddEntityDataConfigPath(FlatBufferBuilder builder, StringOffset entityDataConfigPathOffset)
		{
			builder.AddOffset(10, entityDataConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BAE4 RID: 113380 RVA: 0x003ECA4C File Offset: 0x003EAC4C
		public static void AddTypeScriptRoot(FlatBufferBuilder builder, StringOffset typeScriptRootOffset)
		{
			builder.AddOffset(11, typeScriptRootOffset.Value, 0);
		}

		// Token: 0x0601BAE5 RID: 113381 RVA: 0x003ECA5D File Offset: 0x003EAC5D
		public static void AddCsvFileDir(FlatBufferBuilder builder, StringOffset csvFileDirOffset)
		{
			builder.AddOffset(12, csvFileDirOffset.Value, 0);
		}

		// Token: 0x0601BAE6 RID: 113382 RVA: 0x003ECA6E File Offset: 0x003EAC6E
		public static void AddFlowListDir(FlatBufferBuilder builder, StringOffset flowListDirOffset)
		{
			builder.AddOffset(13, flowListDirOffset.Value, 0);
		}

		// Token: 0x0601BAE7 RID: 113383 RVA: 0x003ECA7F File Offset: 0x003EAC7F
		public static void AddQuestListDir(FlatBufferBuilder builder, StringOffset questListDirOffset)
		{
			builder.AddOffset(14, questListDirOffset.Value, 0);
		}

		// Token: 0x0601BAE8 RID: 113384 RVA: 0x003ECA90 File Offset: 0x003EAC90
		public static void AddQuestListExportDir(FlatBufferBuilder builder, StringOffset questListExportDirOffset)
		{
			builder.AddOffset(15, questListExportDirOffset.Value, 0);
		}

		// Token: 0x0601BAE9 RID: 113385 RVA: 0x003ECAA1 File Offset: 0x003EACA1
		public static void AddEntityStateConfigPath(FlatBufferBuilder builder, StringOffset entityStateConfigPathOffset)
		{
			builder.AddOffset(16, entityStateConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BAEA RID: 113386 RVA: 0x003ECAB2 File Offset: 0x003EACB2
		public static void AddEntityOwnerConfigPath(FlatBufferBuilder builder, StringOffset entityOwnerConfigPathOffset)
		{
			builder.AddOffset(17, entityOwnerConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BAEB RID: 113387 RVA: 0x003ECAC3 File Offset: 0x003EACC3
		public static void AddChildEntityOwnerConfigPath(FlatBufferBuilder builder, StringOffset childEntityOwnerConfigPathOffset)
		{
			builder.AddOffset(18, childEntityOwnerConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BAEC RID: 113388 RVA: 0x003ECAD4 File Offset: 0x003EACD4
		public static void AddAlwaysLoadEntityConfigPath(FlatBufferBuilder builder, StringOffset alwaysLoadEntityConfigPathOffset)
		{
			builder.AddOffset(19, alwaysLoadEntityConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BAED RID: 113389 RVA: 0x003ECAE5 File Offset: 0x003EACE5
		public static void AddLevelPlayListDir(FlatBufferBuilder builder, StringOffset levelPlayListDirOffset)
		{
			builder.AddOffset(20, levelPlayListDirOffset.Value, 0);
		}

		// Token: 0x0601BAEE RID: 113390 RVA: 0x003ECAF6 File Offset: 0x003EACF6
		public static void AddLevelPlayListExportDir(FlatBufferBuilder builder, StringOffset levelPlayListExportDirOffset)
		{
			builder.AddOffset(21, levelPlayListExportDirOffset.Value, 0);
		}

		// Token: 0x0601BAEF RID: 113391 RVA: 0x003ECB07 File Offset: 0x003EAD07
		public static void AddDynamicLevelPlayListExportDir(FlatBufferBuilder builder, StringOffset dynamicLevelPlayListExportDirOffset)
		{
			builder.AddOffset(22, dynamicLevelPlayListExportDirOffset.Value, 0);
		}

		// Token: 0x0601BAF0 RID: 113392 RVA: 0x003ECB18 File Offset: 0x003EAD18
		public static void AddTwoDimensionLevelListDir(FlatBufferBuilder builder, StringOffset twoDimensionLevelListDirOffset)
		{
			builder.AddOffset(23, twoDimensionLevelListDirOffset.Value, 0);
		}

		// Token: 0x0601BAF1 RID: 113393 RVA: 0x003ECB29 File Offset: 0x003EAD29
		public static void AddDangoBrawlObjectTemplateDir(FlatBufferBuilder builder, StringOffset dangoBrawlObjectTemplateDirOffset)
		{
			builder.AddOffset(24, dangoBrawlObjectTemplateDirOffset.Value, 0);
		}

		// Token: 0x0601BAF2 RID: 113394 RVA: 0x003ECB3A File Offset: 0x003EAD3A
		public static void AddMarbleLevelConfigPath(FlatBufferBuilder builder, StringOffset marbleLevelConfigPathOffset)
		{
			builder.AddOffset(25, marbleLevelConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BAF3 RID: 113395 RVA: 0x003ECB4B File Offset: 0x003EAD4B
		public static void AddDangoBrawlLevelConfigPath(FlatBufferBuilder builder, StringOffset dangoBrawlLevelConfigPathOffset)
		{
			builder.AddOffset(26, dangoBrawlLevelConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BAF4 RID: 113396 RVA: 0x003ECB5C File Offset: 0x003EAD5C
		public static void AddDangoBrawlObjectTemplateConfigPath(FlatBufferBuilder builder, StringOffset dangoBrawlObjectTemplateConfigPathOffset)
		{
			builder.AddOffset(27, dangoBrawlObjectTemplateConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BAF5 RID: 113397 RVA: 0x003ECB6D File Offset: 0x003EAD6D
		public static void AddFunctionalTestDir(FlatBufferBuilder builder, StringOffset functionalTestDirOffset)
		{
			builder.AddOffset(28, functionalTestDirOffset.Value, 0);
		}

		// Token: 0x0601BAF6 RID: 113398 RVA: 0x003ECB7E File Offset: 0x003EAD7E
		public static void AddFlowTemplateConfigPath(FlatBufferBuilder builder, StringOffset flowTemplateConfigPathOffset)
		{
			builder.AddOffset(29, flowTemplateConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BAF7 RID: 113399 RVA: 0x003ECB8F File Offset: 0x003EAD8F
		public static void AddFlowTemplateCameraDir(FlatBufferBuilder builder, StringOffset flowTemplateCameraDirOffset)
		{
			builder.AddOffset(30, flowTemplateCameraDirOffset.Value, 0);
		}

		// Token: 0x0601BAF8 RID: 113400 RVA: 0x003ECBA0 File Offset: 0x003EADA0
		public static void AddFlowTemplateCameraConfigPath(FlatBufferBuilder builder, StringOffset flowTemplateCameraConfigPathOffset)
		{
			builder.AddOffset(31, flowTemplateCameraConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BAF9 RID: 113401 RVA: 0x003ECBB1 File Offset: 0x003EADB1
		public static void AddFlowTemplateCameraConfgSourcePath(FlatBufferBuilder builder, StringOffset flowTemplateCameraConfgSourcePathOffset)
		{
			builder.AddOffset(32, flowTemplateCameraConfgSourcePathOffset.Value, 0);
		}

		// Token: 0x0601BAFA RID: 113402 RVA: 0x003ECBC2 File Offset: 0x003EADC2
		public static void AddGlobalVarConfigPath(FlatBufferBuilder builder, StringOffset globalVarConfigPathOffset)
		{
			builder.AddOffset(33, globalVarConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BAFB RID: 113403 RVA: 0x003ECBD3 File Offset: 0x003EADD3
		public static void AddSystemVarConfigPath(FlatBufferBuilder builder, StringOffset systemVarConfigPathOffset)
		{
			builder.AddOffset(34, systemVarConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BAFC RID: 113404 RVA: 0x003ECBE4 File Offset: 0x003EADE4
		public static void AddVehicleRidingRolesConfigPath(FlatBufferBuilder builder, StringOffset vehicleRidingRolesConfigPathOffset)
		{
			builder.AddOffset(35, vehicleRidingRolesConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BAFD RID: 113405 RVA: 0x003ECBF5 File Offset: 0x003EADF5
		public static void AddOccupationConfigPath(FlatBufferBuilder builder, StringOffset occupationConfigPathOffset)
		{
			builder.AddOffset(36, occupationConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BAFE RID: 113406 RVA: 0x003ECC06 File Offset: 0x003EAE06
		public static void AddOccupiedExportPath(FlatBufferBuilder builder, StringOffset occupiedExportPathOffset)
		{
			builder.AddOffset(37, occupiedExportPathOffset.Value, 0);
		}

		// Token: 0x0601BAFF RID: 113407 RVA: 0x003ECC17 File Offset: 0x003EAE17
		public static void AddInteractOptionConfigPath(FlatBufferBuilder builder, StringOffset interactOptionConfigPathOffset)
		{
			builder.AddOffset(38, interactOptionConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BB00 RID: 113408 RVA: 0x003ECC28 File Offset: 0x003EAE28
		public static void AddAreaEntitiesPath(FlatBufferBuilder builder, StringOffset areaEntitiesPathOffset)
		{
			builder.AddOffset(39, areaEntitiesPathOffset.Value, 0);
		}

		// Token: 0x0601BB01 RID: 113409 RVA: 0x003ECC39 File Offset: 0x003EAE39
		public static void AddBtConfigPath(FlatBufferBuilder builder, StringOffset btConfigPathOffset)
		{
			builder.AddOffset(40, btConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BB02 RID: 113410 RVA: 0x003ECC4A File Offset: 0x003EAE4A
		public static void AddMontageConfigPath(FlatBufferBuilder builder, StringOffset montageConfigPathOffset)
		{
			builder.AddOffset(41, montageConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BB03 RID: 113411 RVA: 0x003ECC5B File Offset: 0x003EAE5B
		public static void AddAbpMontageConfigPath(FlatBufferBuilder builder, StringOffset abpMontageConfigPathOffset)
		{
			builder.AddOffset(42, abpMontageConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BB04 RID: 113412 RVA: 0x003ECC6C File Offset: 0x003EAE6C
		public static void AddAbpOverlayMontageConfigPath(FlatBufferBuilder builder, StringOffset abpOverlayMontageConfigPathOffset)
		{
			builder.AddOffset(43, abpOverlayMontageConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BB05 RID: 113413 RVA: 0x003ECC7D File Offset: 0x003EAE7D
		public static void AddAbpStateConfigPath(FlatBufferBuilder builder, StringOffset abpStateConfigPathOffset)
		{
			builder.AddOffset(44, abpStateConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BB06 RID: 113414 RVA: 0x003ECC8E File Offset: 0x003EAE8E
		public static void AddFaceExpressionConfigPath(FlatBufferBuilder builder, StringOffset faceExpressionConfigPathOffset)
		{
			builder.AddOffset(45, faceExpressionConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BB07 RID: 113415 RVA: 0x003ECC9F File Offset: 0x003EAE9F
		public static void AddAoiGroupPath(FlatBufferBuilder builder, StringOffset aoiGroupPathOffset)
		{
			builder.AddOffset(46, aoiGroupPathOffset.Value, 0);
		}

		// Token: 0x0601BB08 RID: 113416 RVA: 0x003ECCB0 File Offset: 0x003EAEB0
		public static void AddEntityPerformanceDataPath(FlatBufferBuilder builder, StringOffset entityPerformanceDataPathOffset)
		{
			builder.AddOffset(47, entityPerformanceDataPathOffset.Value, 0);
		}

		// Token: 0x0601BB09 RID: 113417 RVA: 0x003ECCC1 File Offset: 0x003EAEC1
		public static void AddActorRefConfigPath(FlatBufferBuilder builder, StringOffset actorRefConfigPathOffset)
		{
			builder.AddOffset(48, actorRefConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BB0A RID: 113418 RVA: 0x003ECCD2 File Offset: 0x003EAED2
		public static void AddAoiDefineDataPath(FlatBufferBuilder builder, StringOffset aoiDefineDataPathOffset)
		{
			builder.AddOffset(49, aoiDefineDataPathOffset.Value, 0);
		}

		// Token: 0x0601BB0B RID: 113419 RVA: 0x003ECCE3 File Offset: 0x003EAEE3
		public static void AddPrefabDir(FlatBufferBuilder builder, StringOffset prefabDirOffset)
		{
			builder.AddOffset(50, prefabDirOffset.Value, 0);
		}

		// Token: 0x0601BB0C RID: 113420 RVA: 0x003ECCF4 File Offset: 0x003EAEF4
		public static void AddBundleDir(FlatBufferBuilder builder, StringOffset bundleDirOffset)
		{
			builder.AddOffset(51, bundleDirOffset.Value, 0);
		}

		// Token: 0x0601BB0D RID: 113421 RVA: 0x003ECD05 File Offset: 0x003EAF05
		public static void AddPrefabConfigPath(FlatBufferBuilder builder, StringOffset prefabConfigPathOffset)
		{
			builder.AddOffset(52, prefabConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BB0E RID: 113422 RVA: 0x003ECD16 File Offset: 0x003EAF16
		public static void AddEditorStartConfig(FlatBufferBuilder builder, StringOffset editorStartConfigOffset)
		{
			builder.AddOffset(53, editorStartConfigOffset.Value, 0);
		}

		// Token: 0x0601BB0F RID: 113423 RVA: 0x003ECD27 File Offset: 0x003EAF27
		public static void AddBubbleConfigPath(FlatBufferBuilder builder, StringOffset bubbleConfigPathOffset)
		{
			builder.AddOffset(54, bubbleConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BB10 RID: 113424 RVA: 0x003ECD38 File Offset: 0x003EAF38
		public static void AddLevelEntityVoxelPath(FlatBufferBuilder builder, StringOffset levelEntityVoxelPathOffset)
		{
			builder.AddOffset(55, levelEntityVoxelPathOffset.Value, 0);
		}

		// Token: 0x0601BB11 RID: 113425 RVA: 0x003ECD49 File Offset: 0x003EAF49
		public static void AddTidTextTempPath(FlatBufferBuilder builder, StringOffset tidTextTempPathOffset)
		{
			builder.AddOffset(56, tidTextTempPathOffset.Value, 0);
		}

		// Token: 0x0601BB12 RID: 113426 RVA: 0x003ECD5A File Offset: 0x003EAF5A
		public static void AddAudioStatePath(FlatBufferBuilder builder, StringOffset audioStatePathOffset)
		{
			builder.AddOffset(57, audioStatePathOffset.Value, 0);
		}

		// Token: 0x0601BB13 RID: 113427 RVA: 0x003ECD6B File Offset: 0x003EAF6B
		public static void AddPlotHandBookPath(FlatBufferBuilder builder, StringOffset plotHandBookPathOffset)
		{
			builder.AddOffset(58, plotHandBookPathOffset.Value, 0);
		}

		// Token: 0x0601BB14 RID: 113428 RVA: 0x003ECD7C File Offset: 0x003EAF7C
		public static void AddPlotPositionPath(FlatBufferBuilder builder, StringOffset plotPositionPathOffset)
		{
			builder.AddOffset(59, plotPositionPathOffset.Value, 0);
		}

		// Token: 0x0601BB15 RID: 113429 RVA: 0x003ECD8D File Offset: 0x003EAF8D
		public static void AddTextLibraryDir(FlatBufferBuilder builder, StringOffset textLibraryDirOffset)
		{
			builder.AddOffset(60, textLibraryDirOffset.Value, 0);
		}

		// Token: 0x0601BB16 RID: 113430 RVA: 0x003ECD9E File Offset: 0x003EAF9E
		public static void AddEnrichmentArea(FlatBufferBuilder builder, StringOffset enrichmentAreaOffset)
		{
			builder.AddOffset(61, enrichmentAreaOffset.Value, 0);
		}

		// Token: 0x0601BB17 RID: 113431 RVA: 0x003ECDAF File Offset: 0x003EAFAF
		public static void AddMarkedErrorCsvPath(FlatBufferBuilder builder, StringOffset markedErrorCsvPathOffset)
		{
			builder.AddOffset(62, markedErrorCsvPathOffset.Value, 0);
		}

		// Token: 0x0601BB18 RID: 113432 RVA: 0x003ECDC0 File Offset: 0x003EAFC0
		public static void AddBrokenRockConfig(FlatBufferBuilder builder, StringOffset brokenRockConfigOffset)
		{
			builder.AddOffset(63, brokenRockConfigOffset.Value, 0);
		}

		// Token: 0x0601BB19 RID: 113433 RVA: 0x003ECDD1 File Offset: 0x003EAFD1
		public static void AddGridItemShapeConfigPath(FlatBufferBuilder builder, StringOffset gridItemShapeConfigPathOffset)
		{
			builder.AddOffset(64, gridItemShapeConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BB1A RID: 113434 RVA: 0x003ECDE2 File Offset: 0x003EAFE2
		public static void AddFishingRouletteConfig(FlatBufferBuilder builder, StringOffset fishingRouletteConfigOffset)
		{
			builder.AddOffset(65, fishingRouletteConfigOffset.Value, 0);
		}

		// Token: 0x0601BB1B RID: 113435 RVA: 0x003ECDF3 File Offset: 0x003EAFF3
		public static void AddAreaQuestTracking(FlatBufferBuilder builder, StringOffset areaQuestTrackingOffset)
		{
			builder.AddOffset(66, areaQuestTrackingOffset.Value, 0);
		}

		// Token: 0x0601BB1C RID: 113436 RVA: 0x003ECE04 File Offset: 0x003EB004
		public static void AddOfflineComponentExportPath(FlatBufferBuilder builder, StringOffset offlineComponentExportPathOffset)
		{
			builder.AddOffset(67, offlineComponentExportPathOffset.Value, 0);
		}

		// Token: 0x0601BB1D RID: 113437 RVA: 0x003ECE15 File Offset: 0x003EB015
		public static void AddSummonGongduolaConfigExportPath(FlatBufferBuilder builder, StringOffset summonGongduolaConfigExportPathOffset)
		{
			builder.AddOffset(68, summonGongduolaConfigExportPathOffset.Value, 0);
		}

		// Token: 0x0601BB1E RID: 113438 RVA: 0x003ECE26 File Offset: 0x003EB026
		public static void AddHideGroupFixConfigPath(FlatBufferBuilder builder, StringOffset hideGroupFixConfigPathOffset)
		{
			builder.AddOffset(69, hideGroupFixConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BB1F RID: 113439 RVA: 0x003ECE37 File Offset: 0x003EB037
		public static void AddEntityFixProcessorPath(FlatBufferBuilder builder, StringOffset entityFixProcessorPathOffset)
		{
			builder.AddOffset(70, entityFixProcessorPathOffset.Value, 0);
		}

		// Token: 0x0601BB20 RID: 113440 RVA: 0x003ECE48 File Offset: 0x003EB048
		public static void AddGravityAbnormalEntityListPath(FlatBufferBuilder builder, StringOffset gravityAbnormalEntityListPathOffset)
		{
			builder.AddOffset(71, gravityAbnormalEntityListPathOffset.Value, 0);
		}

		// Token: 0x0601BB21 RID: 113441 RVA: 0x003ECE59 File Offset: 0x003EB059
		public static void AddActorRefComponentsConfigPath(FlatBufferBuilder builder, StringOffset actorRefComponentsConfigPathOffset)
		{
			builder.AddOffset(72, actorRefComponentsConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BB22 RID: 113442 RVA: 0x003ECE6A File Offset: 0x003EB06A
		public static void AddSeqRefComponentsConfigPath(FlatBufferBuilder builder, StringOffset seqRefComponentsConfigPathOffset)
		{
			builder.AddOffset(73, seqRefComponentsConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BB23 RID: 113443 RVA: 0x003ECE7B File Offset: 0x003EB07B
		public static void AddQuestRefMp4Path(FlatBufferBuilder builder, StringOffset questRefMp4PathOffset)
		{
			builder.AddOffset(74, questRefMp4PathOffset.Value, 0);
		}

		// Token: 0x0601BB24 RID: 113444 RVA: 0x003ECE8C File Offset: 0x003EB08C
		public static void AddBehaviorTreeFragmentDir(FlatBufferBuilder builder, StringOffset behaviorTreeFragmentDirOffset)
		{
			builder.AddOffset(75, behaviorTreeFragmentDirOffset.Value, 0);
		}

		// Token: 0x0601BB25 RID: 113445 RVA: 0x003ECE9D File Offset: 0x003EB09D
		public static void AddCommonBtDir(FlatBufferBuilder builder, StringOffset commonBtDirOffset)
		{
			builder.AddOffset(76, commonBtDirOffset.Value, 0);
		}

		// Token: 0x0601BB26 RID: 113446 RVA: 0x003ECEAE File Offset: 0x003EB0AE
		public static void AddCommonBtExportDir(FlatBufferBuilder builder, StringOffset commonBtExportDirOffset)
		{
			builder.AddOffset(77, commonBtExportDirOffset.Value, 0);
		}

		// Token: 0x0601BB27 RID: 113447 RVA: 0x003ECEBF File Offset: 0x003EB0BF
		public static void AddLevelBuildingGrids(FlatBufferBuilder builder, StringOffset levelBuildingGridsOffset)
		{
			builder.AddOffset(78, levelBuildingGridsOffset.Value, 0);
		}

		// Token: 0x0601BB28 RID: 113448 RVA: 0x003ECED0 File Offset: 0x003EB0D0
		public static void AddGlobalFixConfigPath(FlatBufferBuilder builder, StringOffset globalFixConfigPathOffset)
		{
			builder.AddOffset(79, globalFixConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BB29 RID: 113449 RVA: 0x003ECEE1 File Offset: 0x003EB0E1
		public static void AddAreaFunctionConfigPath(FlatBufferBuilder builder, StringOffset areaFunctionConfigPathOffset)
		{
			builder.AddOffset(80, areaFunctionConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BB2A RID: 113450 RVA: 0x003ECEF2 File Offset: 0x003EB0F2
		public static void AddDynamicSpawnMonsterRandomPoolConfigPath(FlatBufferBuilder builder, StringOffset dynamicSpawnMonsterRandomPoolConfigPathOffset)
		{
			builder.AddOffset(81, dynamicSpawnMonsterRandomPoolConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BB2B RID: 113451 RVA: 0x003ECF03 File Offset: 0x003EB103
		public static void AddEntityCustomPrimitiveData(FlatBufferBuilder builder, StringOffset entityCustomPrimitiveDataOffset)
		{
			builder.AddOffset(82, entityCustomPrimitiveDataOffset.Value, 0);
		}

		// Token: 0x0601BB2C RID: 113452 RVA: 0x003ECF14 File Offset: 0x003EB114
		public static void AddAnimalStandbyTagPath(FlatBufferBuilder builder, StringOffset animalStandbyTagPathOffset)
		{
			builder.AddOffset(83, animalStandbyTagPathOffset.Value, 0);
		}

		// Token: 0x0601BB2D RID: 113453 RVA: 0x003ECF25 File Offset: 0x003EB125
		public static void AddAnsPerformDataPath(FlatBufferBuilder builder, StringOffset ansPerformDataPathOffset)
		{
			builder.AddOffset(84, ansPerformDataPathOffset.Value, 0);
		}

		// Token: 0x0601BB2E RID: 113454 RVA: 0x003ECF36 File Offset: 0x003EB136
		public static void AddRoadZonePath(FlatBufferBuilder builder, StringOffset roadZonePathOffset)
		{
			builder.AddOffset(85, roadZonePathOffset.Value, 0);
		}

		// Token: 0x0601BB2F RID: 113455 RVA: 0x003ECF47 File Offset: 0x003EB147
		public static void AddUltraLeaveRadiusLevelPlayPath(FlatBufferBuilder builder, StringOffset ultraLeaveRadiusLevelPlayPathOffset)
		{
			builder.AddOffset(86, ultraLeaveRadiusLevelPlayPathOffset.Value, 0);
		}

		// Token: 0x0601BB30 RID: 113456 RVA: 0x003ECF58 File Offset: 0x003EB158
		public static void AddAreaTeleportPath(FlatBufferBuilder builder, StringOffset areaTeleportPathOffset)
		{
			builder.AddOffset(87, areaTeleportPathOffset.Value, 0);
		}

		// Token: 0x0601BB31 RID: 113457 RVA: 0x003ECF69 File Offset: 0x003EB169
		public static void AddSeqAreaPath(FlatBufferBuilder builder, StringOffset seqAreaPathOffset)
		{
			builder.AddOffset(88, seqAreaPathOffset.Value, 0);
		}

		// Token: 0x0601BB32 RID: 113458 RVA: 0x003ECF7A File Offset: 0x003EB17A
		public static void AddDungeonAreaOwnerDataPath(FlatBufferBuilder builder, StringOffset dungeonAreaOwnerDataPathOffset)
		{
			builder.AddOffset(89, dungeonAreaOwnerDataPathOffset.Value, 0);
		}

		// Token: 0x0601BB33 RID: 113459 RVA: 0x003ECF8B File Offset: 0x003EB18B
		public static void AddDungeonAreaReachableDataPath(FlatBufferBuilder builder, StringOffset dungeonAreaReachableDataPathOffset)
		{
			builder.AddOffset(90, dungeonAreaReachableDataPathOffset.Value, 0);
		}

		// Token: 0x0601BB34 RID: 113460 RVA: 0x003ECF9C File Offset: 0x003EB19C
		public static void AddTimeSchedulePath(FlatBufferBuilder builder, StringOffset timeSchedulePathOffset)
		{
			builder.AddOffset(91, timeSchedulePathOffset.Value, 0);
		}

		// Token: 0x0601BB35 RID: 113461 RVA: 0x003ECFAD File Offset: 0x003EB1AD
		public static void AddAiBehaviorTreePath(FlatBufferBuilder builder, StringOffset aiBehaviorTreePathOffset)
		{
			builder.AddOffset(92, aiBehaviorTreePathOffset.Value, 0);
		}

		// Token: 0x0601BB36 RID: 113462 RVA: 0x003ECFBE File Offset: 0x003EB1BE
		public static void AddRecallDataConfigPath(FlatBufferBuilder builder, StringOffset recallDataConfigPathOffset)
		{
			builder.AddOffset(93, recallDataConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BB37 RID: 113463 RVA: 0x003ECFCF File Offset: 0x003EB1CF
		public static void AddCombatOperationCaptureDir(FlatBufferBuilder builder, StringOffset combatOperationCaptureDirOffset)
		{
			builder.AddOffset(94, combatOperationCaptureDirOffset.Value, 0);
		}

		// Token: 0x0601BB38 RID: 113464 RVA: 0x003ECFE0 File Offset: 0x003EB1E0
		public static void AddRecallEntityConfigPath(FlatBufferBuilder builder, StringOffset recallEntityConfigPathOffset)
		{
			builder.AddOffset(95, recallEntityConfigPathOffset.Value, 0);
		}

		// Token: 0x0601BB39 RID: 113465 RVA: 0x003ECFF1 File Offset: 0x003EB1F1
		public static Offset<IGlobalConfig> EndIGlobalConfig(FlatBufferBuilder builder)
		{
			return new Offset<IGlobalConfig>(builder.EndTable());
		}

		// Token: 0x0601BB3A RID: 113466 RVA: 0x003ED000 File Offset: 0x003EB200
		public IGlobalConfigT UnPack()
		{
			IGlobalConfigT globalConfigT = new IGlobalConfigT();
			this.UnPackTo(globalConfigT);
			return globalConfigT;
		}

		// Token: 0x0601BB3B RID: 113467 RVA: 0x003ED01C File Offset: 0x003EB21C
		public void UnPackTo(IGlobalConfigT _o)
		{
			_o.ActionConfigPath = this.ActionConfigPath;
			_o.ComponentConfigPath = this.ComponentConfigPath;
			_o.EntityConfigPath = this.EntityConfigPath;
			_o.BlueprintConfigPath = this.BlueprintConfigPath;
			_o.LevelsConfigPath = this.LevelsConfigPath;
			_o.SubWpMapConfigPath = this.SubWpMapConfigPath;
			_o.LevelsDir = this.LevelsDir;
			_o.LevelsDataDir = this.LevelsDataDir;
			_o.TemplateDir = this.TemplateDir;
			_o.TemplateConfigPath = this.TemplateConfigPath;
			_o.EntityDataConfigPath = this.EntityDataConfigPath;
			_o.TypeScriptRoot = this.TypeScriptRoot;
			_o.CsvFileDir = this.CsvFileDir;
			_o.FlowListDir = this.FlowListDir;
			_o.QuestListDir = this.QuestListDir;
			_o.QuestListExportDir = this.QuestListExportDir;
			_o.EntityStateConfigPath = this.EntityStateConfigPath;
			_o.EntityOwnerConfigPath = this.EntityOwnerConfigPath;
			_o.ChildEntityOwnerConfigPath = this.ChildEntityOwnerConfigPath;
			_o.AlwaysLoadEntityConfigPath = this.AlwaysLoadEntityConfigPath;
			_o.LevelPlayListDir = this.LevelPlayListDir;
			_o.LevelPlayListExportDir = this.LevelPlayListExportDir;
			_o.DynamicLevelPlayListExportDir = this.DynamicLevelPlayListExportDir;
			_o.TwoDimensionLevelListDir = this.TwoDimensionLevelListDir;
			_o.DangoBrawlObjectTemplateDir = this.DangoBrawlObjectTemplateDir;
			_o.MarbleLevelConfigPath = this.MarbleLevelConfigPath;
			_o.DangoBrawlLevelConfigPath = this.DangoBrawlLevelConfigPath;
			_o.DangoBrawlObjectTemplateConfigPath = this.DangoBrawlObjectTemplateConfigPath;
			_o.FunctionalTestDir = this.FunctionalTestDir;
			_o.FlowTemplateConfigPath = this.FlowTemplateConfigPath;
			_o.FlowTemplateCameraDir = this.FlowTemplateCameraDir;
			_o.FlowTemplateCameraConfigPath = this.FlowTemplateCameraConfigPath;
			_o.FlowTemplateCameraConfgSourcePath = this.FlowTemplateCameraConfgSourcePath;
			_o.GlobalVarConfigPath = this.GlobalVarConfigPath;
			_o.SystemVarConfigPath = this.SystemVarConfigPath;
			_o.VehicleRidingRolesConfigPath = this.VehicleRidingRolesConfigPath;
			_o.OccupationConfigPath = this.OccupationConfigPath;
			_o.OccupiedExportPath = this.OccupiedExportPath;
			_o.InteractOptionConfigPath = this.InteractOptionConfigPath;
			_o.AreaEntitiesPath = this.AreaEntitiesPath;
			_o.BtConfigPath = this.BtConfigPath;
			_o.MontageConfigPath = this.MontageConfigPath;
			_o.AbpMontageConfigPath = this.AbpMontageConfigPath;
			_o.AbpOverlayMontageConfigPath = this.AbpOverlayMontageConfigPath;
			_o.AbpStateConfigPath = this.AbpStateConfigPath;
			_o.FaceExpressionConfigPath = this.FaceExpressionConfigPath;
			_o.AoiGroupPath = this.AoiGroupPath;
			_o.EntityPerformanceDataPath = this.EntityPerformanceDataPath;
			_o.ActorRefConfigPath = this.ActorRefConfigPath;
			_o.AoiDefineDataPath = this.AoiDefineDataPath;
			_o.PrefabDir = this.PrefabDir;
			_o.BundleDir = this.BundleDir;
			_o.PrefabConfigPath = this.PrefabConfigPath;
			_o.EditorStartConfig = this.EditorStartConfig;
			_o.BubbleConfigPath = this.BubbleConfigPath;
			_o.LevelEntityVoxelPath = this.LevelEntityVoxelPath;
			_o.TidTextTempPath = this.TidTextTempPath;
			_o.AudioStatePath = this.AudioStatePath;
			_o.PlotHandBookPath = this.PlotHandBookPath;
			_o.PlotPositionPath = this.PlotPositionPath;
			_o.TextLibraryDir = this.TextLibraryDir;
			_o.EnrichmentArea = this.EnrichmentArea;
			_o.MarkedErrorCsvPath = this.MarkedErrorCsvPath;
			_o.BrokenRockConfig = this.BrokenRockConfig;
			_o.GridItemShapeConfigPath = this.GridItemShapeConfigPath;
			_o.FishingRouletteConfig = this.FishingRouletteConfig;
			_o.AreaQuestTracking = this.AreaQuestTracking;
			_o.OfflineComponentExportPath = this.OfflineComponentExportPath;
			_o.SummonGongduolaConfigExportPath = this.SummonGongduolaConfigExportPath;
			_o.HideGroupFixConfigPath = this.HideGroupFixConfigPath;
			_o.EntityFixProcessorPath = this.EntityFixProcessorPath;
			_o.GravityAbnormalEntityListPath = this.GravityAbnormalEntityListPath;
			_o.ActorRefComponentsConfigPath = this.ActorRefComponentsConfigPath;
			_o.SeqRefComponentsConfigPath = this.SeqRefComponentsConfigPath;
			_o.QuestRefMp4Path = this.QuestRefMp4Path;
			_o.BehaviorTreeFragmentDir = this.BehaviorTreeFragmentDir;
			_o.CommonBtDir = this.CommonBtDir;
			_o.CommonBtExportDir = this.CommonBtExportDir;
			_o.LevelBuildingGrids = this.LevelBuildingGrids;
			_o.GlobalFixConfigPath = this.GlobalFixConfigPath;
			_o.AreaFunctionConfigPath = this.AreaFunctionConfigPath;
			_o.DynamicSpawnMonsterRandomPoolConfigPath = this.DynamicSpawnMonsterRandomPoolConfigPath;
			_o.EntityCustomPrimitiveData = this.EntityCustomPrimitiveData;
			_o.AnimalStandbyTagPath = this.AnimalStandbyTagPath;
			_o.AnsPerformDataPath = this.AnsPerformDataPath;
			_o.RoadZonePath = this.RoadZonePath;
			_o.UltraLeaveRadiusLevelPlayPath = this.UltraLeaveRadiusLevelPlayPath;
			_o.AreaTeleportPath = this.AreaTeleportPath;
			_o.SeqAreaPath = this.SeqAreaPath;
			_o.DungeonAreaOwnerDataPath = this.DungeonAreaOwnerDataPath;
			_o.DungeonAreaReachableDataPath = this.DungeonAreaReachableDataPath;
			_o.TimeSchedulePath = this.TimeSchedulePath;
			_o.AiBehaviorTreePath = this.AiBehaviorTreePath;
			_o.RecallDataConfigPath = this.RecallDataConfigPath;
			_o.CombatOperationCaptureDir = this.CombatOperationCaptureDir;
			_o.RecallEntityConfigPath = this.RecallEntityConfigPath;
		}

		// Token: 0x0601BB3C RID: 113468 RVA: 0x003ED4AC File Offset: 0x003EB6AC
		public static Offset<IGlobalConfig> Pack(FlatBufferBuilder builder, IGlobalConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGlobalConfig>);
			}
			StringOffset actionConfigPathOffset = (_o.ActionConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.ActionConfigPath);
			StringOffset componentConfigPathOffset = (_o.ComponentConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.ComponentConfigPath);
			StringOffset entityConfigPathOffset = (_o.EntityConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.EntityConfigPath);
			StringOffset blueprintConfigPathOffset = (_o.BlueprintConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.BlueprintConfigPath);
			StringOffset levelsConfigPathOffset = (_o.LevelsConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.LevelsConfigPath);
			StringOffset subWpMapConfigPathOffset = (_o.SubWpMapConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.SubWpMapConfigPath);
			StringOffset levelsDirOffset = (_o.LevelsDir == null) ? default(StringOffset) : builder.CreateString(_o.LevelsDir);
			StringOffset levelsDataDirOffset = (_o.LevelsDataDir == null) ? default(StringOffset) : builder.CreateString(_o.LevelsDataDir);
			StringOffset templateDirOffset = (_o.TemplateDir == null) ? default(StringOffset) : builder.CreateString(_o.TemplateDir);
			StringOffset templateConfigPathOffset = (_o.TemplateConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.TemplateConfigPath);
			StringOffset entityDataConfigPathOffset = (_o.EntityDataConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.EntityDataConfigPath);
			StringOffset typeScriptRootOffset = (_o.TypeScriptRoot == null) ? default(StringOffset) : builder.CreateString(_o.TypeScriptRoot);
			StringOffset csvFileDirOffset = (_o.CsvFileDir == null) ? default(StringOffset) : builder.CreateString(_o.CsvFileDir);
			StringOffset flowListDirOffset = (_o.FlowListDir == null) ? default(StringOffset) : builder.CreateString(_o.FlowListDir);
			StringOffset questListDirOffset = (_o.QuestListDir == null) ? default(StringOffset) : builder.CreateString(_o.QuestListDir);
			StringOffset questListExportDirOffset = (_o.QuestListExportDir == null) ? default(StringOffset) : builder.CreateString(_o.QuestListExportDir);
			StringOffset entityStateConfigPathOffset = (_o.EntityStateConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.EntityStateConfigPath);
			StringOffset entityOwnerConfigPathOffset = (_o.EntityOwnerConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.EntityOwnerConfigPath);
			StringOffset childEntityOwnerConfigPathOffset = (_o.ChildEntityOwnerConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.ChildEntityOwnerConfigPath);
			StringOffset alwaysLoadEntityConfigPathOffset = (_o.AlwaysLoadEntityConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.AlwaysLoadEntityConfigPath);
			StringOffset levelPlayListDirOffset = (_o.LevelPlayListDir == null) ? default(StringOffset) : builder.CreateString(_o.LevelPlayListDir);
			StringOffset levelPlayListExportDirOffset = (_o.LevelPlayListExportDir == null) ? default(StringOffset) : builder.CreateString(_o.LevelPlayListExportDir);
			StringOffset dynamicLevelPlayListExportDirOffset = (_o.DynamicLevelPlayListExportDir == null) ? default(StringOffset) : builder.CreateString(_o.DynamicLevelPlayListExportDir);
			StringOffset twoDimensionLevelListDirOffset = (_o.TwoDimensionLevelListDir == null) ? default(StringOffset) : builder.CreateString(_o.TwoDimensionLevelListDir);
			StringOffset dangoBrawlObjectTemplateDirOffset = (_o.DangoBrawlObjectTemplateDir == null) ? default(StringOffset) : builder.CreateString(_o.DangoBrawlObjectTemplateDir);
			StringOffset marbleLevelConfigPathOffset = (_o.MarbleLevelConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.MarbleLevelConfigPath);
			StringOffset dangoBrawlLevelConfigPathOffset = (_o.DangoBrawlLevelConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.DangoBrawlLevelConfigPath);
			StringOffset dangoBrawlObjectTemplateConfigPathOffset = (_o.DangoBrawlObjectTemplateConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.DangoBrawlObjectTemplateConfigPath);
			StringOffset functionalTestDirOffset = (_o.FunctionalTestDir == null) ? default(StringOffset) : builder.CreateString(_o.FunctionalTestDir);
			StringOffset flowTemplateConfigPathOffset = (_o.FlowTemplateConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.FlowTemplateConfigPath);
			StringOffset flowTemplateCameraDirOffset = (_o.FlowTemplateCameraDir == null) ? default(StringOffset) : builder.CreateString(_o.FlowTemplateCameraDir);
			StringOffset flowTemplateCameraConfigPathOffset = (_o.FlowTemplateCameraConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.FlowTemplateCameraConfigPath);
			StringOffset flowTemplateCameraConfgSourcePathOffset = (_o.FlowTemplateCameraConfgSourcePath == null) ? default(StringOffset) : builder.CreateString(_o.FlowTemplateCameraConfgSourcePath);
			StringOffset globalVarConfigPathOffset = (_o.GlobalVarConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.GlobalVarConfigPath);
			StringOffset systemVarConfigPathOffset = (_o.SystemVarConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.SystemVarConfigPath);
			StringOffset vehicleRidingRolesConfigPathOffset = (_o.VehicleRidingRolesConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.VehicleRidingRolesConfigPath);
			StringOffset occupationConfigPathOffset = (_o.OccupationConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.OccupationConfigPath);
			StringOffset occupiedExportPathOffset = (_o.OccupiedExportPath == null) ? default(StringOffset) : builder.CreateString(_o.OccupiedExportPath);
			StringOffset interactOptionConfigPathOffset = (_o.InteractOptionConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.InteractOptionConfigPath);
			StringOffset areaEntitiesPathOffset = (_o.AreaEntitiesPath == null) ? default(StringOffset) : builder.CreateString(_o.AreaEntitiesPath);
			StringOffset btConfigPathOffset = (_o.BtConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.BtConfigPath);
			StringOffset montageConfigPathOffset = (_o.MontageConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.MontageConfigPath);
			StringOffset abpMontageConfigPathOffset = (_o.AbpMontageConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.AbpMontageConfigPath);
			StringOffset abpOverlayMontageConfigPathOffset = (_o.AbpOverlayMontageConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.AbpOverlayMontageConfigPath);
			StringOffset abpStateConfigPathOffset = (_o.AbpStateConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.AbpStateConfigPath);
			StringOffset faceExpressionConfigPathOffset = (_o.FaceExpressionConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.FaceExpressionConfigPath);
			StringOffset aoiGroupPathOffset = (_o.AoiGroupPath == null) ? default(StringOffset) : builder.CreateString(_o.AoiGroupPath);
			StringOffset entityPerformanceDataPathOffset = (_o.EntityPerformanceDataPath == null) ? default(StringOffset) : builder.CreateString(_o.EntityPerformanceDataPath);
			StringOffset actorRefConfigPathOffset = (_o.ActorRefConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.ActorRefConfigPath);
			StringOffset aoiDefineDataPathOffset = (_o.AoiDefineDataPath == null) ? default(StringOffset) : builder.CreateString(_o.AoiDefineDataPath);
			StringOffset prefabDirOffset = (_o.PrefabDir == null) ? default(StringOffset) : builder.CreateString(_o.PrefabDir);
			StringOffset bundleDirOffset = (_o.BundleDir == null) ? default(StringOffset) : builder.CreateString(_o.BundleDir);
			StringOffset prefabConfigPathOffset = (_o.PrefabConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.PrefabConfigPath);
			StringOffset editorStartConfigOffset = (_o.EditorStartConfig == null) ? default(StringOffset) : builder.CreateString(_o.EditorStartConfig);
			StringOffset bubbleConfigPathOffset = (_o.BubbleConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.BubbleConfigPath);
			StringOffset levelEntityVoxelPathOffset = (_o.LevelEntityVoxelPath == null) ? default(StringOffset) : builder.CreateString(_o.LevelEntityVoxelPath);
			StringOffset tidTextTempPathOffset = (_o.TidTextTempPath == null) ? default(StringOffset) : builder.CreateString(_o.TidTextTempPath);
			StringOffset audioStatePathOffset = (_o.AudioStatePath == null) ? default(StringOffset) : builder.CreateString(_o.AudioStatePath);
			StringOffset plotHandBookPathOffset = (_o.PlotHandBookPath == null) ? default(StringOffset) : builder.CreateString(_o.PlotHandBookPath);
			StringOffset plotPositionPathOffset = (_o.PlotPositionPath == null) ? default(StringOffset) : builder.CreateString(_o.PlotPositionPath);
			StringOffset textLibraryDirOffset = (_o.TextLibraryDir == null) ? default(StringOffset) : builder.CreateString(_o.TextLibraryDir);
			StringOffset enrichmentAreaOffset = (_o.EnrichmentArea == null) ? default(StringOffset) : builder.CreateString(_o.EnrichmentArea);
			StringOffset markedErrorCsvPathOffset = (_o.MarkedErrorCsvPath == null) ? default(StringOffset) : builder.CreateString(_o.MarkedErrorCsvPath);
			StringOffset brokenRockConfigOffset = (_o.BrokenRockConfig == null) ? default(StringOffset) : builder.CreateString(_o.BrokenRockConfig);
			StringOffset gridItemShapeConfigPathOffset = (_o.GridItemShapeConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.GridItemShapeConfigPath);
			StringOffset fishingRouletteConfigOffset = (_o.FishingRouletteConfig == null) ? default(StringOffset) : builder.CreateString(_o.FishingRouletteConfig);
			StringOffset areaQuestTrackingOffset = (_o.AreaQuestTracking == null) ? default(StringOffset) : builder.CreateString(_o.AreaQuestTracking);
			StringOffset offlineComponentExportPathOffset = (_o.OfflineComponentExportPath == null) ? default(StringOffset) : builder.CreateString(_o.OfflineComponentExportPath);
			StringOffset summonGongduolaConfigExportPathOffset = (_o.SummonGongduolaConfigExportPath == null) ? default(StringOffset) : builder.CreateString(_o.SummonGongduolaConfigExportPath);
			StringOffset hideGroupFixConfigPathOffset = (_o.HideGroupFixConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.HideGroupFixConfigPath);
			StringOffset entityFixProcessorPathOffset = (_o.EntityFixProcessorPath == null) ? default(StringOffset) : builder.CreateString(_o.EntityFixProcessorPath);
			StringOffset gravityAbnormalEntityListPathOffset = (_o.GravityAbnormalEntityListPath == null) ? default(StringOffset) : builder.CreateString(_o.GravityAbnormalEntityListPath);
			StringOffset actorRefComponentsConfigPathOffset = (_o.ActorRefComponentsConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.ActorRefComponentsConfigPath);
			StringOffset seqRefComponentsConfigPathOffset = (_o.SeqRefComponentsConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.SeqRefComponentsConfigPath);
			StringOffset questRefMp4PathOffset = (_o.QuestRefMp4Path == null) ? default(StringOffset) : builder.CreateString(_o.QuestRefMp4Path);
			StringOffset behaviorTreeFragmentDirOffset = (_o.BehaviorTreeFragmentDir == null) ? default(StringOffset) : builder.CreateString(_o.BehaviorTreeFragmentDir);
			StringOffset commonBtDirOffset = (_o.CommonBtDir == null) ? default(StringOffset) : builder.CreateString(_o.CommonBtDir);
			StringOffset commonBtExportDirOffset = (_o.CommonBtExportDir == null) ? default(StringOffset) : builder.CreateString(_o.CommonBtExportDir);
			StringOffset levelBuildingGridsOffset = (_o.LevelBuildingGrids == null) ? default(StringOffset) : builder.CreateString(_o.LevelBuildingGrids);
			StringOffset globalFixConfigPathOffset = (_o.GlobalFixConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.GlobalFixConfigPath);
			StringOffset areaFunctionConfigPathOffset = (_o.AreaFunctionConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.AreaFunctionConfigPath);
			StringOffset dynamicSpawnMonsterRandomPoolConfigPathOffset = (_o.DynamicSpawnMonsterRandomPoolConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.DynamicSpawnMonsterRandomPoolConfigPath);
			StringOffset entityCustomPrimitiveDataOffset = (_o.EntityCustomPrimitiveData == null) ? default(StringOffset) : builder.CreateString(_o.EntityCustomPrimitiveData);
			StringOffset animalStandbyTagPathOffset = (_o.AnimalStandbyTagPath == null) ? default(StringOffset) : builder.CreateString(_o.AnimalStandbyTagPath);
			StringOffset ansPerformDataPathOffset = (_o.AnsPerformDataPath == null) ? default(StringOffset) : builder.CreateString(_o.AnsPerformDataPath);
			StringOffset roadZonePathOffset = (_o.RoadZonePath == null) ? default(StringOffset) : builder.CreateString(_o.RoadZonePath);
			StringOffset ultraLeaveRadiusLevelPlayPathOffset = (_o.UltraLeaveRadiusLevelPlayPath == null) ? default(StringOffset) : builder.CreateString(_o.UltraLeaveRadiusLevelPlayPath);
			StringOffset areaTeleportPathOffset = (_o.AreaTeleportPath == null) ? default(StringOffset) : builder.CreateString(_o.AreaTeleportPath);
			StringOffset seqAreaPathOffset = (_o.SeqAreaPath == null) ? default(StringOffset) : builder.CreateString(_o.SeqAreaPath);
			StringOffset dungeonAreaOwnerDataPathOffset = (_o.DungeonAreaOwnerDataPath == null) ? default(StringOffset) : builder.CreateString(_o.DungeonAreaOwnerDataPath);
			StringOffset dungeonAreaReachableDataPathOffset = (_o.DungeonAreaReachableDataPath == null) ? default(StringOffset) : builder.CreateString(_o.DungeonAreaReachableDataPath);
			StringOffset timeSchedulePathOffset = (_o.TimeSchedulePath == null) ? default(StringOffset) : builder.CreateString(_o.TimeSchedulePath);
			StringOffset aiBehaviorTreePathOffset = (_o.AiBehaviorTreePath == null) ? default(StringOffset) : builder.CreateString(_o.AiBehaviorTreePath);
			StringOffset recallDataConfigPathOffset = (_o.RecallDataConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.RecallDataConfigPath);
			StringOffset combatOperationCaptureDirOffset = (_o.CombatOperationCaptureDir == null) ? default(StringOffset) : builder.CreateString(_o.CombatOperationCaptureDir);
			StringOffset recallEntityConfigPathOffset = (_o.RecallEntityConfigPath == null) ? default(StringOffset) : builder.CreateString(_o.RecallEntityConfigPath);
			return IGlobalConfig.CreateIGlobalConfig(builder, actionConfigPathOffset, componentConfigPathOffset, entityConfigPathOffset, blueprintConfigPathOffset, levelsConfigPathOffset, subWpMapConfigPathOffset, levelsDirOffset, levelsDataDirOffset, templateDirOffset, templateConfigPathOffset, entityDataConfigPathOffset, typeScriptRootOffset, csvFileDirOffset, flowListDirOffset, questListDirOffset, questListExportDirOffset, entityStateConfigPathOffset, entityOwnerConfigPathOffset, childEntityOwnerConfigPathOffset, alwaysLoadEntityConfigPathOffset, levelPlayListDirOffset, levelPlayListExportDirOffset, dynamicLevelPlayListExportDirOffset, twoDimensionLevelListDirOffset, dangoBrawlObjectTemplateDirOffset, marbleLevelConfigPathOffset, dangoBrawlLevelConfigPathOffset, dangoBrawlObjectTemplateConfigPathOffset, functionalTestDirOffset, flowTemplateConfigPathOffset, flowTemplateCameraDirOffset, flowTemplateCameraConfigPathOffset, flowTemplateCameraConfgSourcePathOffset, globalVarConfigPathOffset, systemVarConfigPathOffset, vehicleRidingRolesConfigPathOffset, occupationConfigPathOffset, occupiedExportPathOffset, interactOptionConfigPathOffset, areaEntitiesPathOffset, btConfigPathOffset, montageConfigPathOffset, abpMontageConfigPathOffset, abpOverlayMontageConfigPathOffset, abpStateConfigPathOffset, faceExpressionConfigPathOffset, aoiGroupPathOffset, entityPerformanceDataPathOffset, actorRefConfigPathOffset, aoiDefineDataPathOffset, prefabDirOffset, bundleDirOffset, prefabConfigPathOffset, editorStartConfigOffset, bubbleConfigPathOffset, levelEntityVoxelPathOffset, tidTextTempPathOffset, audioStatePathOffset, plotHandBookPathOffset, plotPositionPathOffset, textLibraryDirOffset, enrichmentAreaOffset, markedErrorCsvPathOffset, brokenRockConfigOffset, gridItemShapeConfigPathOffset, fishingRouletteConfigOffset, areaQuestTrackingOffset, offlineComponentExportPathOffset, summonGongduolaConfigExportPathOffset, hideGroupFixConfigPathOffset, entityFixProcessorPathOffset, gravityAbnormalEntityListPathOffset, actorRefComponentsConfigPathOffset, seqRefComponentsConfigPathOffset, questRefMp4PathOffset, behaviorTreeFragmentDirOffset, commonBtDirOffset, commonBtExportDirOffset, levelBuildingGridsOffset, globalFixConfigPathOffset, areaFunctionConfigPathOffset, dynamicSpawnMonsterRandomPoolConfigPathOffset, entityCustomPrimitiveDataOffset, animalStandbyTagPathOffset, ansPerformDataPathOffset, roadZonePathOffset, ultraLeaveRadiusLevelPlayPathOffset, areaTeleportPathOffset, seqAreaPathOffset, dungeonAreaOwnerDataPathOffset, dungeonAreaReachableDataPathOffset, timeSchedulePathOffset, aiBehaviorTreePathOffset, recallDataConfigPathOffset, combatOperationCaptureDirOffset, recallEntityConfigPathOffset);
		}

		// Token: 0x0400C8E9 RID: 51433
		private Table __p;
	}
}

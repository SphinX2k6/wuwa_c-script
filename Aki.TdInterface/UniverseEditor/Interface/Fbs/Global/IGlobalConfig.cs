using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Global
{
	// Token: 0x02004B44 RID: 19268
	public struct IGlobalConfig : IFlatbufferObject
	{
		// Token: 0x1700871C RID: 34588
		// (get) Token: 0x0601D186 RID: 119174 RVA: 0x004166A2 File Offset: 0x004148A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D187 RID: 119175 RVA: 0x004166AF File Offset: 0x004148AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D188 RID: 119176 RVA: 0x004166B8 File Offset: 0x004148B8
		public static IGlobalConfig GetRootAsIGlobalConfig(ByteBuffer _bb)
		{
			return IGlobalConfig.GetRootAsIGlobalConfig(_bb, default(IGlobalConfig));
		}

		// Token: 0x0601D189 RID: 119177 RVA: 0x004166D4 File Offset: 0x004148D4
		public static IGlobalConfig GetRootAsIGlobalConfig(ByteBuffer _bb, IGlobalConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D18A RID: 119178 RVA: 0x004166F1 File Offset: 0x004148F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D18B RID: 119179 RVA: 0x00416700 File Offset: 0x00414900
		public IGlobalConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700871D RID: 34589
		// (get) Token: 0x0601D18C RID: 119180 RVA: 0x00416710 File Offset: 0x00414910
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

		// Token: 0x0601D18D RID: 119181 RVA: 0x00416747 File Offset: 0x00414947
		public Span<byte> GetActionConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601D18E RID: 119182 RVA: 0x00416756 File Offset: 0x00414956
		public byte[] GetActionConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700871E RID: 34590
		// (get) Token: 0x0601D18F RID: 119183 RVA: 0x00416764 File Offset: 0x00414964
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

		// Token: 0x0601D190 RID: 119184 RVA: 0x0041679B File Offset: 0x0041499B
		public Span<byte> GetComponentConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601D191 RID: 119185 RVA: 0x004167AA File Offset: 0x004149AA
		public byte[] GetComponentConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700871F RID: 34591
		// (get) Token: 0x0601D192 RID: 119186 RVA: 0x004167B8 File Offset: 0x004149B8
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

		// Token: 0x0601D193 RID: 119187 RVA: 0x004167EF File Offset: 0x004149EF
		public Span<byte> GetEntityConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601D194 RID: 119188 RVA: 0x004167FE File Offset: 0x004149FE
		public byte[] GetEntityConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008720 RID: 34592
		// (get) Token: 0x0601D195 RID: 119189 RVA: 0x0041680C File Offset: 0x00414A0C
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

		// Token: 0x0601D196 RID: 119190 RVA: 0x00416844 File Offset: 0x00414A44
		public Span<byte> GetBlueprintConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601D197 RID: 119191 RVA: 0x00416854 File Offset: 0x00414A54
		public byte[] GetBlueprintConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17008721 RID: 34593
		// (get) Token: 0x0601D198 RID: 119192 RVA: 0x00416864 File Offset: 0x00414A64
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

		// Token: 0x0601D199 RID: 119193 RVA: 0x0041689C File Offset: 0x00414A9C
		public Span<byte> GetLevelsConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601D19A RID: 119194 RVA: 0x004168AC File Offset: 0x00414AAC
		public byte[] GetLevelsConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17008722 RID: 34594
		// (get) Token: 0x0601D19B RID: 119195 RVA: 0x004168BC File Offset: 0x00414ABC
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

		// Token: 0x0601D19C RID: 119196 RVA: 0x004168F4 File Offset: 0x00414AF4
		public Span<byte> GetSubWpMapConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0601D19D RID: 119197 RVA: 0x00416904 File Offset: 0x00414B04
		public byte[] GetSubWpMapConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x17008723 RID: 34595
		// (get) Token: 0x0601D19E RID: 119198 RVA: 0x00416914 File Offset: 0x00414B14
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

		// Token: 0x0601D19F RID: 119199 RVA: 0x0041694C File Offset: 0x00414B4C
		public Span<byte> GetLevelsDirBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0601D1A0 RID: 119200 RVA: 0x0041695C File Offset: 0x00414B5C
		public byte[] GetLevelsDirArray()
		{
			return this.__p.__vector_as_array<byte>(16);
		}

		// Token: 0x17008724 RID: 34596
		// (get) Token: 0x0601D1A1 RID: 119201 RVA: 0x0041696C File Offset: 0x00414B6C
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

		// Token: 0x0601D1A2 RID: 119202 RVA: 0x004169A4 File Offset: 0x00414BA4
		public Span<byte> GetLevelsDataDirBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0601D1A3 RID: 119203 RVA: 0x004169B4 File Offset: 0x00414BB4
		public byte[] GetLevelsDataDirArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x17008725 RID: 34597
		// (get) Token: 0x0601D1A4 RID: 119204 RVA: 0x004169C4 File Offset: 0x00414BC4
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

		// Token: 0x0601D1A5 RID: 119205 RVA: 0x004169FC File Offset: 0x00414BFC
		public Span<byte> GetTemplateDirBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0601D1A6 RID: 119206 RVA: 0x00416A0C File Offset: 0x00414C0C
		public byte[] GetTemplateDirArray()
		{
			return this.__p.__vector_as_array<byte>(20);
		}

		// Token: 0x17008726 RID: 34598
		// (get) Token: 0x0601D1A7 RID: 119207 RVA: 0x00416A1C File Offset: 0x00414C1C
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

		// Token: 0x0601D1A8 RID: 119208 RVA: 0x00416A54 File Offset: 0x00414C54
		public Span<byte> GetTemplateConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0601D1A9 RID: 119209 RVA: 0x00416A64 File Offset: 0x00414C64
		public byte[] GetTemplateConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(22);
		}

		// Token: 0x17008727 RID: 34599
		// (get) Token: 0x0601D1AA RID: 119210 RVA: 0x00416A74 File Offset: 0x00414C74
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

		// Token: 0x0601D1AB RID: 119211 RVA: 0x00416AAC File Offset: 0x00414CAC
		public Span<byte> GetEntityDataConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0601D1AC RID: 119212 RVA: 0x00416ABC File Offset: 0x00414CBC
		public byte[] GetEntityDataConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(24);
		}

		// Token: 0x17008728 RID: 34600
		// (get) Token: 0x0601D1AD RID: 119213 RVA: 0x00416ACC File Offset: 0x00414CCC
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

		// Token: 0x0601D1AE RID: 119214 RVA: 0x00416B04 File Offset: 0x00414D04
		public Span<byte> GetTypeScriptRootBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0601D1AF RID: 119215 RVA: 0x00416B14 File Offset: 0x00414D14
		public byte[] GetTypeScriptRootArray()
		{
			return this.__p.__vector_as_array<byte>(26);
		}

		// Token: 0x17008729 RID: 34601
		// (get) Token: 0x0601D1B0 RID: 119216 RVA: 0x00416B24 File Offset: 0x00414D24
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

		// Token: 0x0601D1B1 RID: 119217 RVA: 0x00416B5C File Offset: 0x00414D5C
		public Span<byte> GetCsvFileDirBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0601D1B2 RID: 119218 RVA: 0x00416B6C File Offset: 0x00414D6C
		public byte[] GetCsvFileDirArray()
		{
			return this.__p.__vector_as_array<byte>(28);
		}

		// Token: 0x1700872A RID: 34602
		// (get) Token: 0x0601D1B3 RID: 119219 RVA: 0x00416B7C File Offset: 0x00414D7C
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

		// Token: 0x0601D1B4 RID: 119220 RVA: 0x00416BB4 File Offset: 0x00414DB4
		public Span<byte> GetFlowListDirBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0601D1B5 RID: 119221 RVA: 0x00416BC4 File Offset: 0x00414DC4
		public byte[] GetFlowListDirArray()
		{
			return this.__p.__vector_as_array<byte>(30);
		}

		// Token: 0x1700872B RID: 34603
		// (get) Token: 0x0601D1B6 RID: 119222 RVA: 0x00416BD4 File Offset: 0x00414DD4
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

		// Token: 0x0601D1B7 RID: 119223 RVA: 0x00416C0C File Offset: 0x00414E0C
		public Span<byte> GetQuestListDirBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0601D1B8 RID: 119224 RVA: 0x00416C1C File Offset: 0x00414E1C
		public byte[] GetQuestListDirArray()
		{
			return this.__p.__vector_as_array<byte>(32);
		}

		// Token: 0x1700872C RID: 34604
		// (get) Token: 0x0601D1B9 RID: 119225 RVA: 0x00416C2C File Offset: 0x00414E2C
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

		// Token: 0x0601D1BA RID: 119226 RVA: 0x00416C64 File Offset: 0x00414E64
		public Span<byte> GetQuestListExportDirBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0601D1BB RID: 119227 RVA: 0x00416C74 File Offset: 0x00414E74
		public byte[] GetQuestListExportDirArray()
		{
			return this.__p.__vector_as_array<byte>(34);
		}

		// Token: 0x1700872D RID: 34605
		// (get) Token: 0x0601D1BC RID: 119228 RVA: 0x00416C84 File Offset: 0x00414E84
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

		// Token: 0x0601D1BD RID: 119229 RVA: 0x00416CBC File Offset: 0x00414EBC
		public Span<byte> GetEntityStateConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0601D1BE RID: 119230 RVA: 0x00416CCC File Offset: 0x00414ECC
		public byte[] GetEntityStateConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(36);
		}

		// Token: 0x1700872E RID: 34606
		// (get) Token: 0x0601D1BF RID: 119231 RVA: 0x00416CDC File Offset: 0x00414EDC
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

		// Token: 0x0601D1C0 RID: 119232 RVA: 0x00416D14 File Offset: 0x00414F14
		public Span<byte> GetEntityOwnerConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0601D1C1 RID: 119233 RVA: 0x00416D24 File Offset: 0x00414F24
		public byte[] GetEntityOwnerConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(38);
		}

		// Token: 0x1700872F RID: 34607
		// (get) Token: 0x0601D1C2 RID: 119234 RVA: 0x00416D34 File Offset: 0x00414F34
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

		// Token: 0x0601D1C3 RID: 119235 RVA: 0x00416D6C File Offset: 0x00414F6C
		public Span<byte> GetChildEntityOwnerConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0601D1C4 RID: 119236 RVA: 0x00416D7C File Offset: 0x00414F7C
		public byte[] GetChildEntityOwnerConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(40);
		}

		// Token: 0x17008730 RID: 34608
		// (get) Token: 0x0601D1C5 RID: 119237 RVA: 0x00416D8C File Offset: 0x00414F8C
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

		// Token: 0x0601D1C6 RID: 119238 RVA: 0x00416DC4 File Offset: 0x00414FC4
		public Span<byte> GetAlwaysLoadEntityConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0601D1C7 RID: 119239 RVA: 0x00416DD4 File Offset: 0x00414FD4
		public byte[] GetAlwaysLoadEntityConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(42);
		}

		// Token: 0x17008731 RID: 34609
		// (get) Token: 0x0601D1C8 RID: 119240 RVA: 0x00416DE4 File Offset: 0x00414FE4
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

		// Token: 0x0601D1C9 RID: 119241 RVA: 0x00416E1C File Offset: 0x0041501C
		public Span<byte> GetLevelPlayListDirBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0601D1CA RID: 119242 RVA: 0x00416E2C File Offset: 0x0041502C
		public byte[] GetLevelPlayListDirArray()
		{
			return this.__p.__vector_as_array<byte>(44);
		}

		// Token: 0x17008732 RID: 34610
		// (get) Token: 0x0601D1CB RID: 119243 RVA: 0x00416E3C File Offset: 0x0041503C
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

		// Token: 0x0601D1CC RID: 119244 RVA: 0x00416E74 File Offset: 0x00415074
		public Span<byte> GetLevelPlayListExportDirBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0601D1CD RID: 119245 RVA: 0x00416E84 File Offset: 0x00415084
		public byte[] GetLevelPlayListExportDirArray()
		{
			return this.__p.__vector_as_array<byte>(46);
		}

		// Token: 0x17008733 RID: 34611
		// (get) Token: 0x0601D1CE RID: 119246 RVA: 0x00416E94 File Offset: 0x00415094
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

		// Token: 0x0601D1CF RID: 119247 RVA: 0x00416ECC File Offset: 0x004150CC
		public Span<byte> GetDynamicLevelPlayListExportDirBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x0601D1D0 RID: 119248 RVA: 0x00416EDC File Offset: 0x004150DC
		public byte[] GetDynamicLevelPlayListExportDirArray()
		{
			return this.__p.__vector_as_array<byte>(48);
		}

		// Token: 0x17008734 RID: 34612
		// (get) Token: 0x0601D1D1 RID: 119249 RVA: 0x00416EEC File Offset: 0x004150EC
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

		// Token: 0x0601D1D2 RID: 119250 RVA: 0x00416F24 File Offset: 0x00415124
		public Span<byte> GetTwoDimensionLevelListDirBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0601D1D3 RID: 119251 RVA: 0x00416F34 File Offset: 0x00415134
		public byte[] GetTwoDimensionLevelListDirArray()
		{
			return this.__p.__vector_as_array<byte>(50);
		}

		// Token: 0x17008735 RID: 34613
		// (get) Token: 0x0601D1D4 RID: 119252 RVA: 0x00416F44 File Offset: 0x00415144
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

		// Token: 0x0601D1D5 RID: 119253 RVA: 0x00416F7C File Offset: 0x0041517C
		public Span<byte> GetDangoBrawlObjectTemplateDirBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0601D1D6 RID: 119254 RVA: 0x00416F8C File Offset: 0x0041518C
		public byte[] GetDangoBrawlObjectTemplateDirArray()
		{
			return this.__p.__vector_as_array<byte>(52);
		}

		// Token: 0x17008736 RID: 34614
		// (get) Token: 0x0601D1D7 RID: 119255 RVA: 0x00416F9C File Offset: 0x0041519C
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

		// Token: 0x0601D1D8 RID: 119256 RVA: 0x00416FD4 File Offset: 0x004151D4
		public Span<byte> GetMarbleLevelConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x0601D1D9 RID: 119257 RVA: 0x00416FE4 File Offset: 0x004151E4
		public byte[] GetMarbleLevelConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(54);
		}

		// Token: 0x17008737 RID: 34615
		// (get) Token: 0x0601D1DA RID: 119258 RVA: 0x00416FF4 File Offset: 0x004151F4
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

		// Token: 0x0601D1DB RID: 119259 RVA: 0x0041702C File Offset: 0x0041522C
		public Span<byte> GetDangoBrawlLevelConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x0601D1DC RID: 119260 RVA: 0x0041703C File Offset: 0x0041523C
		public byte[] GetDangoBrawlLevelConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(56);
		}

		// Token: 0x17008738 RID: 34616
		// (get) Token: 0x0601D1DD RID: 119261 RVA: 0x0041704C File Offset: 0x0041524C
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

		// Token: 0x0601D1DE RID: 119262 RVA: 0x00417084 File Offset: 0x00415284
		public Span<byte> GetDangoBrawlObjectTemplateConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x0601D1DF RID: 119263 RVA: 0x00417094 File Offset: 0x00415294
		public byte[] GetDangoBrawlObjectTemplateConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(58);
		}

		// Token: 0x17008739 RID: 34617
		// (get) Token: 0x0601D1E0 RID: 119264 RVA: 0x004170A4 File Offset: 0x004152A4
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

		// Token: 0x0601D1E1 RID: 119265 RVA: 0x004170DC File Offset: 0x004152DC
		public Span<byte> GetFunctionalTestDirBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x0601D1E2 RID: 119266 RVA: 0x004170EC File Offset: 0x004152EC
		public byte[] GetFunctionalTestDirArray()
		{
			return this.__p.__vector_as_array<byte>(60);
		}

		// Token: 0x1700873A RID: 34618
		// (get) Token: 0x0601D1E3 RID: 119267 RVA: 0x004170FC File Offset: 0x004152FC
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

		// Token: 0x0601D1E4 RID: 119268 RVA: 0x00417134 File Offset: 0x00415334
		public Span<byte> GetFlowTemplateConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x0601D1E5 RID: 119269 RVA: 0x00417144 File Offset: 0x00415344
		public byte[] GetFlowTemplateConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(62);
		}

		// Token: 0x1700873B RID: 34619
		// (get) Token: 0x0601D1E6 RID: 119270 RVA: 0x00417154 File Offset: 0x00415354
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

		// Token: 0x0601D1E7 RID: 119271 RVA: 0x0041718C File Offset: 0x0041538C
		public Span<byte> GetFlowTemplateCameraDirBytes()
		{
			return this.__p.__vector_as_span<byte>(64, 1);
		}

		// Token: 0x0601D1E8 RID: 119272 RVA: 0x0041719C File Offset: 0x0041539C
		public byte[] GetFlowTemplateCameraDirArray()
		{
			return this.__p.__vector_as_array<byte>(64);
		}

		// Token: 0x1700873C RID: 34620
		// (get) Token: 0x0601D1E9 RID: 119273 RVA: 0x004171AC File Offset: 0x004153AC
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

		// Token: 0x0601D1EA RID: 119274 RVA: 0x004171E4 File Offset: 0x004153E4
		public Span<byte> GetFlowTemplateCameraConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(66, 1);
		}

		// Token: 0x0601D1EB RID: 119275 RVA: 0x004171F4 File Offset: 0x004153F4
		public byte[] GetFlowTemplateCameraConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(66);
		}

		// Token: 0x1700873D RID: 34621
		// (get) Token: 0x0601D1EC RID: 119276 RVA: 0x00417204 File Offset: 0x00415404
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

		// Token: 0x0601D1ED RID: 119277 RVA: 0x0041723C File Offset: 0x0041543C
		public Span<byte> GetFlowTemplateCameraConfgSourcePathBytes()
		{
			return this.__p.__vector_as_span<byte>(68, 1);
		}

		// Token: 0x0601D1EE RID: 119278 RVA: 0x0041724C File Offset: 0x0041544C
		public byte[] GetFlowTemplateCameraConfgSourcePathArray()
		{
			return this.__p.__vector_as_array<byte>(68);
		}

		// Token: 0x1700873E RID: 34622
		// (get) Token: 0x0601D1EF RID: 119279 RVA: 0x0041725C File Offset: 0x0041545C
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

		// Token: 0x0601D1F0 RID: 119280 RVA: 0x00417294 File Offset: 0x00415494
		public Span<byte> GetGlobalVarConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(70, 1);
		}

		// Token: 0x0601D1F1 RID: 119281 RVA: 0x004172A4 File Offset: 0x004154A4
		public byte[] GetGlobalVarConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(70);
		}

		// Token: 0x1700873F RID: 34623
		// (get) Token: 0x0601D1F2 RID: 119282 RVA: 0x004172B4 File Offset: 0x004154B4
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

		// Token: 0x0601D1F3 RID: 119283 RVA: 0x004172EC File Offset: 0x004154EC
		public Span<byte> GetSystemVarConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(72, 1);
		}

		// Token: 0x0601D1F4 RID: 119284 RVA: 0x004172FC File Offset: 0x004154FC
		public byte[] GetSystemVarConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(72);
		}

		// Token: 0x17008740 RID: 34624
		// (get) Token: 0x0601D1F5 RID: 119285 RVA: 0x0041730C File Offset: 0x0041550C
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

		// Token: 0x0601D1F6 RID: 119286 RVA: 0x00417344 File Offset: 0x00415544
		public Span<byte> GetVehicleRidingRolesConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x0601D1F7 RID: 119287 RVA: 0x00417354 File Offset: 0x00415554
		public byte[] GetVehicleRidingRolesConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(74);
		}

		// Token: 0x17008741 RID: 34625
		// (get) Token: 0x0601D1F8 RID: 119288 RVA: 0x00417364 File Offset: 0x00415564
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

		// Token: 0x0601D1F9 RID: 119289 RVA: 0x0041739C File Offset: 0x0041559C
		public Span<byte> GetOccupationConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(76, 1);
		}

		// Token: 0x0601D1FA RID: 119290 RVA: 0x004173AC File Offset: 0x004155AC
		public byte[] GetOccupationConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(76);
		}

		// Token: 0x17008742 RID: 34626
		// (get) Token: 0x0601D1FB RID: 119291 RVA: 0x004173BC File Offset: 0x004155BC
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

		// Token: 0x0601D1FC RID: 119292 RVA: 0x004173F4 File Offset: 0x004155F4
		public Span<byte> GetOccupiedExportPathBytes()
		{
			return this.__p.__vector_as_span<byte>(78, 1);
		}

		// Token: 0x0601D1FD RID: 119293 RVA: 0x00417404 File Offset: 0x00415604
		public byte[] GetOccupiedExportPathArray()
		{
			return this.__p.__vector_as_array<byte>(78);
		}

		// Token: 0x17008743 RID: 34627
		// (get) Token: 0x0601D1FE RID: 119294 RVA: 0x00417414 File Offset: 0x00415614
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

		// Token: 0x0601D1FF RID: 119295 RVA: 0x0041744C File Offset: 0x0041564C
		public Span<byte> GetInteractOptionConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(80, 1);
		}

		// Token: 0x0601D200 RID: 119296 RVA: 0x0041745C File Offset: 0x0041565C
		public byte[] GetInteractOptionConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(80);
		}

		// Token: 0x17008744 RID: 34628
		// (get) Token: 0x0601D201 RID: 119297 RVA: 0x0041746C File Offset: 0x0041566C
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

		// Token: 0x0601D202 RID: 119298 RVA: 0x004174A4 File Offset: 0x004156A4
		public Span<byte> GetAreaEntitiesPathBytes()
		{
			return this.__p.__vector_as_span<byte>(82, 1);
		}

		// Token: 0x0601D203 RID: 119299 RVA: 0x004174B4 File Offset: 0x004156B4
		public byte[] GetAreaEntitiesPathArray()
		{
			return this.__p.__vector_as_array<byte>(82);
		}

		// Token: 0x17008745 RID: 34629
		// (get) Token: 0x0601D204 RID: 119300 RVA: 0x004174C4 File Offset: 0x004156C4
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

		// Token: 0x0601D205 RID: 119301 RVA: 0x004174FC File Offset: 0x004156FC
		public Span<byte> GetBtConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(84, 1);
		}

		// Token: 0x0601D206 RID: 119302 RVA: 0x0041750C File Offset: 0x0041570C
		public byte[] GetBtConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(84);
		}

		// Token: 0x17008746 RID: 34630
		// (get) Token: 0x0601D207 RID: 119303 RVA: 0x0041751C File Offset: 0x0041571C
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

		// Token: 0x0601D208 RID: 119304 RVA: 0x00417554 File Offset: 0x00415754
		public Span<byte> GetMontageConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(86, 1);
		}

		// Token: 0x0601D209 RID: 119305 RVA: 0x00417564 File Offset: 0x00415764
		public byte[] GetMontageConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(86);
		}

		// Token: 0x17008747 RID: 34631
		// (get) Token: 0x0601D20A RID: 119306 RVA: 0x00417574 File Offset: 0x00415774
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

		// Token: 0x0601D20B RID: 119307 RVA: 0x004175AC File Offset: 0x004157AC
		public Span<byte> GetAbpMontageConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(88, 1);
		}

		// Token: 0x0601D20C RID: 119308 RVA: 0x004175BC File Offset: 0x004157BC
		public byte[] GetAbpMontageConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(88);
		}

		// Token: 0x17008748 RID: 34632
		// (get) Token: 0x0601D20D RID: 119309 RVA: 0x004175CC File Offset: 0x004157CC
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

		// Token: 0x0601D20E RID: 119310 RVA: 0x00417604 File Offset: 0x00415804
		public Span<byte> GetAbpOverlayMontageConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(90, 1);
		}

		// Token: 0x0601D20F RID: 119311 RVA: 0x00417614 File Offset: 0x00415814
		public byte[] GetAbpOverlayMontageConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(90);
		}

		// Token: 0x17008749 RID: 34633
		// (get) Token: 0x0601D210 RID: 119312 RVA: 0x00417624 File Offset: 0x00415824
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

		// Token: 0x0601D211 RID: 119313 RVA: 0x0041765C File Offset: 0x0041585C
		public Span<byte> GetAbpStateConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(92, 1);
		}

		// Token: 0x0601D212 RID: 119314 RVA: 0x0041766C File Offset: 0x0041586C
		public byte[] GetAbpStateConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(92);
		}

		// Token: 0x1700874A RID: 34634
		// (get) Token: 0x0601D213 RID: 119315 RVA: 0x0041767C File Offset: 0x0041587C
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

		// Token: 0x0601D214 RID: 119316 RVA: 0x004176B4 File Offset: 0x004158B4
		public Span<byte> GetFaceExpressionConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(94, 1);
		}

		// Token: 0x0601D215 RID: 119317 RVA: 0x004176C4 File Offset: 0x004158C4
		public byte[] GetFaceExpressionConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(94);
		}

		// Token: 0x1700874B RID: 34635
		// (get) Token: 0x0601D216 RID: 119318 RVA: 0x004176D4 File Offset: 0x004158D4
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

		// Token: 0x0601D217 RID: 119319 RVA: 0x0041770C File Offset: 0x0041590C
		public Span<byte> GetAoiGroupPathBytes()
		{
			return this.__p.__vector_as_span<byte>(96, 1);
		}

		// Token: 0x0601D218 RID: 119320 RVA: 0x0041771C File Offset: 0x0041591C
		public byte[] GetAoiGroupPathArray()
		{
			return this.__p.__vector_as_array<byte>(96);
		}

		// Token: 0x1700874C RID: 34636
		// (get) Token: 0x0601D219 RID: 119321 RVA: 0x0041772C File Offset: 0x0041592C
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

		// Token: 0x0601D21A RID: 119322 RVA: 0x00417764 File Offset: 0x00415964
		public Span<byte> GetEntityPerformanceDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(98, 1);
		}

		// Token: 0x0601D21B RID: 119323 RVA: 0x00417774 File Offset: 0x00415974
		public byte[] GetEntityPerformanceDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(98);
		}

		// Token: 0x1700874D RID: 34637
		// (get) Token: 0x0601D21C RID: 119324 RVA: 0x00417784 File Offset: 0x00415984
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

		// Token: 0x0601D21D RID: 119325 RVA: 0x004177BC File Offset: 0x004159BC
		public Span<byte> GetActorRefConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(100, 1);
		}

		// Token: 0x0601D21E RID: 119326 RVA: 0x004177CC File Offset: 0x004159CC
		public byte[] GetActorRefConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(100);
		}

		// Token: 0x1700874E RID: 34638
		// (get) Token: 0x0601D21F RID: 119327 RVA: 0x004177DC File Offset: 0x004159DC
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

		// Token: 0x0601D220 RID: 119328 RVA: 0x00417814 File Offset: 0x00415A14
		public Span<byte> GetAoiDefineDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(102, 1);
		}

		// Token: 0x0601D221 RID: 119329 RVA: 0x00417824 File Offset: 0x00415A24
		public byte[] GetAoiDefineDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(102);
		}

		// Token: 0x1700874F RID: 34639
		// (get) Token: 0x0601D222 RID: 119330 RVA: 0x00417834 File Offset: 0x00415A34
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

		// Token: 0x0601D223 RID: 119331 RVA: 0x0041786C File Offset: 0x00415A6C
		public Span<byte> GetPrefabDirBytes()
		{
			return this.__p.__vector_as_span<byte>(104, 1);
		}

		// Token: 0x0601D224 RID: 119332 RVA: 0x0041787C File Offset: 0x00415A7C
		public byte[] GetPrefabDirArray()
		{
			return this.__p.__vector_as_array<byte>(104);
		}

		// Token: 0x17008750 RID: 34640
		// (get) Token: 0x0601D225 RID: 119333 RVA: 0x0041788C File Offset: 0x00415A8C
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

		// Token: 0x0601D226 RID: 119334 RVA: 0x004178C4 File Offset: 0x00415AC4
		public Span<byte> GetBundleDirBytes()
		{
			return this.__p.__vector_as_span<byte>(106, 1);
		}

		// Token: 0x0601D227 RID: 119335 RVA: 0x004178D4 File Offset: 0x00415AD4
		public byte[] GetBundleDirArray()
		{
			return this.__p.__vector_as_array<byte>(106);
		}

		// Token: 0x17008751 RID: 34641
		// (get) Token: 0x0601D228 RID: 119336 RVA: 0x004178E4 File Offset: 0x00415AE4
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

		// Token: 0x0601D229 RID: 119337 RVA: 0x0041791C File Offset: 0x00415B1C
		public Span<byte> GetPrefabConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(108, 1);
		}

		// Token: 0x0601D22A RID: 119338 RVA: 0x0041792C File Offset: 0x00415B2C
		public byte[] GetPrefabConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(108);
		}

		// Token: 0x17008752 RID: 34642
		// (get) Token: 0x0601D22B RID: 119339 RVA: 0x0041793C File Offset: 0x00415B3C
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

		// Token: 0x0601D22C RID: 119340 RVA: 0x00417974 File Offset: 0x00415B74
		public Span<byte> GetEditorStartConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(110, 1);
		}

		// Token: 0x0601D22D RID: 119341 RVA: 0x00417984 File Offset: 0x00415B84
		public byte[] GetEditorStartConfigArray()
		{
			return this.__p.__vector_as_array<byte>(110);
		}

		// Token: 0x17008753 RID: 34643
		// (get) Token: 0x0601D22E RID: 119342 RVA: 0x00417994 File Offset: 0x00415B94
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

		// Token: 0x0601D22F RID: 119343 RVA: 0x004179CC File Offset: 0x00415BCC
		public Span<byte> GetBubbleConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(112, 1);
		}

		// Token: 0x0601D230 RID: 119344 RVA: 0x004179DC File Offset: 0x00415BDC
		public byte[] GetBubbleConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(112);
		}

		// Token: 0x17008754 RID: 34644
		// (get) Token: 0x0601D231 RID: 119345 RVA: 0x004179EC File Offset: 0x00415BEC
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

		// Token: 0x0601D232 RID: 119346 RVA: 0x00417A24 File Offset: 0x00415C24
		public Span<byte> GetLevelEntityVoxelPathBytes()
		{
			return this.__p.__vector_as_span<byte>(114, 1);
		}

		// Token: 0x0601D233 RID: 119347 RVA: 0x00417A34 File Offset: 0x00415C34
		public byte[] GetLevelEntityVoxelPathArray()
		{
			return this.__p.__vector_as_array<byte>(114);
		}

		// Token: 0x17008755 RID: 34645
		// (get) Token: 0x0601D234 RID: 119348 RVA: 0x00417A44 File Offset: 0x00415C44
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

		// Token: 0x0601D235 RID: 119349 RVA: 0x00417A7C File Offset: 0x00415C7C
		public Span<byte> GetTidTextTempPathBytes()
		{
			return this.__p.__vector_as_span<byte>(116, 1);
		}

		// Token: 0x0601D236 RID: 119350 RVA: 0x00417A8C File Offset: 0x00415C8C
		public byte[] GetTidTextTempPathArray()
		{
			return this.__p.__vector_as_array<byte>(116);
		}

		// Token: 0x17008756 RID: 34646
		// (get) Token: 0x0601D237 RID: 119351 RVA: 0x00417A9C File Offset: 0x00415C9C
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

		// Token: 0x0601D238 RID: 119352 RVA: 0x00417AD4 File Offset: 0x00415CD4
		public Span<byte> GetAudioStatePathBytes()
		{
			return this.__p.__vector_as_span<byte>(118, 1);
		}

		// Token: 0x0601D239 RID: 119353 RVA: 0x00417AE4 File Offset: 0x00415CE4
		public byte[] GetAudioStatePathArray()
		{
			return this.__p.__vector_as_array<byte>(118);
		}

		// Token: 0x17008757 RID: 34647
		// (get) Token: 0x0601D23A RID: 119354 RVA: 0x00417AF4 File Offset: 0x00415CF4
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

		// Token: 0x0601D23B RID: 119355 RVA: 0x00417B2C File Offset: 0x00415D2C
		public Span<byte> GetPlotHandBookPathBytes()
		{
			return this.__p.__vector_as_span<byte>(120, 1);
		}

		// Token: 0x0601D23C RID: 119356 RVA: 0x00417B3C File Offset: 0x00415D3C
		public byte[] GetPlotHandBookPathArray()
		{
			return this.__p.__vector_as_array<byte>(120);
		}

		// Token: 0x17008758 RID: 34648
		// (get) Token: 0x0601D23D RID: 119357 RVA: 0x00417B4C File Offset: 0x00415D4C
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

		// Token: 0x0601D23E RID: 119358 RVA: 0x00417B84 File Offset: 0x00415D84
		public Span<byte> GetPlotPositionPathBytes()
		{
			return this.__p.__vector_as_span<byte>(122, 1);
		}

		// Token: 0x0601D23F RID: 119359 RVA: 0x00417B94 File Offset: 0x00415D94
		public byte[] GetPlotPositionPathArray()
		{
			return this.__p.__vector_as_array<byte>(122);
		}

		// Token: 0x17008759 RID: 34649
		// (get) Token: 0x0601D240 RID: 119360 RVA: 0x00417BA4 File Offset: 0x00415DA4
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

		// Token: 0x0601D241 RID: 119361 RVA: 0x00417BDC File Offset: 0x00415DDC
		public Span<byte> GetTextLibraryDirBytes()
		{
			return this.__p.__vector_as_span<byte>(124, 1);
		}

		// Token: 0x0601D242 RID: 119362 RVA: 0x00417BEC File Offset: 0x00415DEC
		public byte[] GetTextLibraryDirArray()
		{
			return this.__p.__vector_as_array<byte>(124);
		}

		// Token: 0x1700875A RID: 34650
		// (get) Token: 0x0601D243 RID: 119363 RVA: 0x00417BFC File Offset: 0x00415DFC
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

		// Token: 0x0601D244 RID: 119364 RVA: 0x00417C34 File Offset: 0x00415E34
		public Span<byte> GetEnrichmentAreaBytes()
		{
			return this.__p.__vector_as_span<byte>(126, 1);
		}

		// Token: 0x0601D245 RID: 119365 RVA: 0x00417C44 File Offset: 0x00415E44
		public byte[] GetEnrichmentAreaArray()
		{
			return this.__p.__vector_as_array<byte>(126);
		}

		// Token: 0x1700875B RID: 34651
		// (get) Token: 0x0601D246 RID: 119366 RVA: 0x00417C54 File Offset: 0x00415E54
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

		// Token: 0x0601D247 RID: 119367 RVA: 0x00417C8F File Offset: 0x00415E8F
		public Span<byte> GetMarkedErrorCsvPathBytes()
		{
			return this.__p.__vector_as_span<byte>(128, 1);
		}

		// Token: 0x0601D248 RID: 119368 RVA: 0x00417CA2 File Offset: 0x00415EA2
		public byte[] GetMarkedErrorCsvPathArray()
		{
			return this.__p.__vector_as_array<byte>(128);
		}

		// Token: 0x1700875C RID: 34652
		// (get) Token: 0x0601D249 RID: 119369 RVA: 0x00417CB4 File Offset: 0x00415EB4
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

		// Token: 0x0601D24A RID: 119370 RVA: 0x00417CEF File Offset: 0x00415EEF
		public Span<byte> GetBrokenRockConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(130, 1);
		}

		// Token: 0x0601D24B RID: 119371 RVA: 0x00417D02 File Offset: 0x00415F02
		public byte[] GetBrokenRockConfigArray()
		{
			return this.__p.__vector_as_array<byte>(130);
		}

		// Token: 0x1700875D RID: 34653
		// (get) Token: 0x0601D24C RID: 119372 RVA: 0x00417D14 File Offset: 0x00415F14
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

		// Token: 0x0601D24D RID: 119373 RVA: 0x00417D4F File Offset: 0x00415F4F
		public Span<byte> GetGridItemShapeConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(132, 1);
		}

		// Token: 0x0601D24E RID: 119374 RVA: 0x00417D62 File Offset: 0x00415F62
		public byte[] GetGridItemShapeConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(132);
		}

		// Token: 0x1700875E RID: 34654
		// (get) Token: 0x0601D24F RID: 119375 RVA: 0x00417D74 File Offset: 0x00415F74
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

		// Token: 0x0601D250 RID: 119376 RVA: 0x00417DAF File Offset: 0x00415FAF
		public Span<byte> GetFishingRouletteConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(134, 1);
		}

		// Token: 0x0601D251 RID: 119377 RVA: 0x00417DC2 File Offset: 0x00415FC2
		public byte[] GetFishingRouletteConfigArray()
		{
			return this.__p.__vector_as_array<byte>(134);
		}

		// Token: 0x1700875F RID: 34655
		// (get) Token: 0x0601D252 RID: 119378 RVA: 0x00417DD4 File Offset: 0x00415FD4
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

		// Token: 0x0601D253 RID: 119379 RVA: 0x00417E0F File Offset: 0x0041600F
		public Span<byte> GetAreaQuestTrackingBytes()
		{
			return this.__p.__vector_as_span<byte>(136, 1);
		}

		// Token: 0x0601D254 RID: 119380 RVA: 0x00417E22 File Offset: 0x00416022
		public byte[] GetAreaQuestTrackingArray()
		{
			return this.__p.__vector_as_array<byte>(136);
		}

		// Token: 0x17008760 RID: 34656
		// (get) Token: 0x0601D255 RID: 119381 RVA: 0x00417E34 File Offset: 0x00416034
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

		// Token: 0x0601D256 RID: 119382 RVA: 0x00417E6F File Offset: 0x0041606F
		public Span<byte> GetOfflineComponentExportPathBytes()
		{
			return this.__p.__vector_as_span<byte>(138, 1);
		}

		// Token: 0x0601D257 RID: 119383 RVA: 0x00417E82 File Offset: 0x00416082
		public byte[] GetOfflineComponentExportPathArray()
		{
			return this.__p.__vector_as_array<byte>(138);
		}

		// Token: 0x17008761 RID: 34657
		// (get) Token: 0x0601D258 RID: 119384 RVA: 0x00417E94 File Offset: 0x00416094
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

		// Token: 0x0601D259 RID: 119385 RVA: 0x00417ECF File Offset: 0x004160CF
		public Span<byte> GetSummonGongduolaConfigExportPathBytes()
		{
			return this.__p.__vector_as_span<byte>(140, 1);
		}

		// Token: 0x0601D25A RID: 119386 RVA: 0x00417EE2 File Offset: 0x004160E2
		public byte[] GetSummonGongduolaConfigExportPathArray()
		{
			return this.__p.__vector_as_array<byte>(140);
		}

		// Token: 0x17008762 RID: 34658
		// (get) Token: 0x0601D25B RID: 119387 RVA: 0x00417EF4 File Offset: 0x004160F4
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

		// Token: 0x0601D25C RID: 119388 RVA: 0x00417F2F File Offset: 0x0041612F
		public Span<byte> GetHideGroupFixConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(142, 1);
		}

		// Token: 0x0601D25D RID: 119389 RVA: 0x00417F42 File Offset: 0x00416142
		public byte[] GetHideGroupFixConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(142);
		}

		// Token: 0x17008763 RID: 34659
		// (get) Token: 0x0601D25E RID: 119390 RVA: 0x00417F54 File Offset: 0x00416154
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

		// Token: 0x0601D25F RID: 119391 RVA: 0x00417F8F File Offset: 0x0041618F
		public Span<byte> GetEntityFixProcessorPathBytes()
		{
			return this.__p.__vector_as_span<byte>(144, 1);
		}

		// Token: 0x0601D260 RID: 119392 RVA: 0x00417FA2 File Offset: 0x004161A2
		public byte[] GetEntityFixProcessorPathArray()
		{
			return this.__p.__vector_as_array<byte>(144);
		}

		// Token: 0x17008764 RID: 34660
		// (get) Token: 0x0601D261 RID: 119393 RVA: 0x00417FB4 File Offset: 0x004161B4
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

		// Token: 0x0601D262 RID: 119394 RVA: 0x00417FEF File Offset: 0x004161EF
		public Span<byte> GetGravityAbnormalEntityListPathBytes()
		{
			return this.__p.__vector_as_span<byte>(146, 1);
		}

		// Token: 0x0601D263 RID: 119395 RVA: 0x00418002 File Offset: 0x00416202
		public byte[] GetGravityAbnormalEntityListPathArray()
		{
			return this.__p.__vector_as_array<byte>(146);
		}

		// Token: 0x17008765 RID: 34661
		// (get) Token: 0x0601D264 RID: 119396 RVA: 0x00418014 File Offset: 0x00416214
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

		// Token: 0x0601D265 RID: 119397 RVA: 0x0041804F File Offset: 0x0041624F
		public Span<byte> GetActorRefComponentsConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(148, 1);
		}

		// Token: 0x0601D266 RID: 119398 RVA: 0x00418062 File Offset: 0x00416262
		public byte[] GetActorRefComponentsConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(148);
		}

		// Token: 0x17008766 RID: 34662
		// (get) Token: 0x0601D267 RID: 119399 RVA: 0x00418074 File Offset: 0x00416274
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

		// Token: 0x0601D268 RID: 119400 RVA: 0x004180AF File Offset: 0x004162AF
		public Span<byte> GetSeqRefComponentsConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(150, 1);
		}

		// Token: 0x0601D269 RID: 119401 RVA: 0x004180C2 File Offset: 0x004162C2
		public byte[] GetSeqRefComponentsConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(150);
		}

		// Token: 0x17008767 RID: 34663
		// (get) Token: 0x0601D26A RID: 119402 RVA: 0x004180D4 File Offset: 0x004162D4
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

		// Token: 0x0601D26B RID: 119403 RVA: 0x0041810F File Offset: 0x0041630F
		public Span<byte> GetQuestRefMp4PathBytes()
		{
			return this.__p.__vector_as_span<byte>(152, 1);
		}

		// Token: 0x0601D26C RID: 119404 RVA: 0x00418122 File Offset: 0x00416322
		public byte[] GetQuestRefMp4PathArray()
		{
			return this.__p.__vector_as_array<byte>(152);
		}

		// Token: 0x17008768 RID: 34664
		// (get) Token: 0x0601D26D RID: 119405 RVA: 0x00418134 File Offset: 0x00416334
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

		// Token: 0x0601D26E RID: 119406 RVA: 0x0041816F File Offset: 0x0041636F
		public Span<byte> GetBehaviorTreeFragmentDirBytes()
		{
			return this.__p.__vector_as_span<byte>(154, 1);
		}

		// Token: 0x0601D26F RID: 119407 RVA: 0x00418182 File Offset: 0x00416382
		public byte[] GetBehaviorTreeFragmentDirArray()
		{
			return this.__p.__vector_as_array<byte>(154);
		}

		// Token: 0x17008769 RID: 34665
		// (get) Token: 0x0601D270 RID: 119408 RVA: 0x00418194 File Offset: 0x00416394
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

		// Token: 0x0601D271 RID: 119409 RVA: 0x004181CF File Offset: 0x004163CF
		public Span<byte> GetCommonBtDirBytes()
		{
			return this.__p.__vector_as_span<byte>(156, 1);
		}

		// Token: 0x0601D272 RID: 119410 RVA: 0x004181E2 File Offset: 0x004163E2
		public byte[] GetCommonBtDirArray()
		{
			return this.__p.__vector_as_array<byte>(156);
		}

		// Token: 0x1700876A RID: 34666
		// (get) Token: 0x0601D273 RID: 119411 RVA: 0x004181F4 File Offset: 0x004163F4
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

		// Token: 0x0601D274 RID: 119412 RVA: 0x0041822F File Offset: 0x0041642F
		public Span<byte> GetCommonBtExportDirBytes()
		{
			return this.__p.__vector_as_span<byte>(158, 1);
		}

		// Token: 0x0601D275 RID: 119413 RVA: 0x00418242 File Offset: 0x00416442
		public byte[] GetCommonBtExportDirArray()
		{
			return this.__p.__vector_as_array<byte>(158);
		}

		// Token: 0x1700876B RID: 34667
		// (get) Token: 0x0601D276 RID: 119414 RVA: 0x00418254 File Offset: 0x00416454
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

		// Token: 0x0601D277 RID: 119415 RVA: 0x0041828F File Offset: 0x0041648F
		public Span<byte> GetLevelBuildingGridsBytes()
		{
			return this.__p.__vector_as_span<byte>(160, 1);
		}

		// Token: 0x0601D278 RID: 119416 RVA: 0x004182A2 File Offset: 0x004164A2
		public byte[] GetLevelBuildingGridsArray()
		{
			return this.__p.__vector_as_array<byte>(160);
		}

		// Token: 0x1700876C RID: 34668
		// (get) Token: 0x0601D279 RID: 119417 RVA: 0x004182B4 File Offset: 0x004164B4
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

		// Token: 0x0601D27A RID: 119418 RVA: 0x004182EF File Offset: 0x004164EF
		public Span<byte> GetGlobalFixConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(162, 1);
		}

		// Token: 0x0601D27B RID: 119419 RVA: 0x00418302 File Offset: 0x00416502
		public byte[] GetGlobalFixConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(162);
		}

		// Token: 0x1700876D RID: 34669
		// (get) Token: 0x0601D27C RID: 119420 RVA: 0x00418314 File Offset: 0x00416514
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

		// Token: 0x0601D27D RID: 119421 RVA: 0x0041834F File Offset: 0x0041654F
		public Span<byte> GetAreaFunctionConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(164, 1);
		}

		// Token: 0x0601D27E RID: 119422 RVA: 0x00418362 File Offset: 0x00416562
		public byte[] GetAreaFunctionConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(164);
		}

		// Token: 0x1700876E RID: 34670
		// (get) Token: 0x0601D27F RID: 119423 RVA: 0x00418374 File Offset: 0x00416574
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

		// Token: 0x0601D280 RID: 119424 RVA: 0x004183AF File Offset: 0x004165AF
		public Span<byte> GetDynamicSpawnMonsterRandomPoolConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(166, 1);
		}

		// Token: 0x0601D281 RID: 119425 RVA: 0x004183C2 File Offset: 0x004165C2
		public byte[] GetDynamicSpawnMonsterRandomPoolConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(166);
		}

		// Token: 0x1700876F RID: 34671
		// (get) Token: 0x0601D282 RID: 119426 RVA: 0x004183D4 File Offset: 0x004165D4
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

		// Token: 0x0601D283 RID: 119427 RVA: 0x0041840F File Offset: 0x0041660F
		public Span<byte> GetEntityCustomPrimitiveDataBytes()
		{
			return this.__p.__vector_as_span<byte>(168, 1);
		}

		// Token: 0x0601D284 RID: 119428 RVA: 0x00418422 File Offset: 0x00416622
		public byte[] GetEntityCustomPrimitiveDataArray()
		{
			return this.__p.__vector_as_array<byte>(168);
		}

		// Token: 0x17008770 RID: 34672
		// (get) Token: 0x0601D285 RID: 119429 RVA: 0x00418434 File Offset: 0x00416634
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

		// Token: 0x0601D286 RID: 119430 RVA: 0x0041846F File Offset: 0x0041666F
		public Span<byte> GetAnimalStandbyTagPathBytes()
		{
			return this.__p.__vector_as_span<byte>(170, 1);
		}

		// Token: 0x0601D287 RID: 119431 RVA: 0x00418482 File Offset: 0x00416682
		public byte[] GetAnimalStandbyTagPathArray()
		{
			return this.__p.__vector_as_array<byte>(170);
		}

		// Token: 0x17008771 RID: 34673
		// (get) Token: 0x0601D288 RID: 119432 RVA: 0x00418494 File Offset: 0x00416694
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

		// Token: 0x0601D289 RID: 119433 RVA: 0x004184CF File Offset: 0x004166CF
		public Span<byte> GetAnsPerformDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(172, 1);
		}

		// Token: 0x0601D28A RID: 119434 RVA: 0x004184E2 File Offset: 0x004166E2
		public byte[] GetAnsPerformDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(172);
		}

		// Token: 0x17008772 RID: 34674
		// (get) Token: 0x0601D28B RID: 119435 RVA: 0x004184F4 File Offset: 0x004166F4
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

		// Token: 0x0601D28C RID: 119436 RVA: 0x0041852F File Offset: 0x0041672F
		public Span<byte> GetRoadZonePathBytes()
		{
			return this.__p.__vector_as_span<byte>(174, 1);
		}

		// Token: 0x0601D28D RID: 119437 RVA: 0x00418542 File Offset: 0x00416742
		public byte[] GetRoadZonePathArray()
		{
			return this.__p.__vector_as_array<byte>(174);
		}

		// Token: 0x17008773 RID: 34675
		// (get) Token: 0x0601D28E RID: 119438 RVA: 0x00418554 File Offset: 0x00416754
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

		// Token: 0x0601D28F RID: 119439 RVA: 0x0041858F File Offset: 0x0041678F
		public Span<byte> GetUltraLeaveRadiusLevelPlayPathBytes()
		{
			return this.__p.__vector_as_span<byte>(176, 1);
		}

		// Token: 0x0601D290 RID: 119440 RVA: 0x004185A2 File Offset: 0x004167A2
		public byte[] GetUltraLeaveRadiusLevelPlayPathArray()
		{
			return this.__p.__vector_as_array<byte>(176);
		}

		// Token: 0x17008774 RID: 34676
		// (get) Token: 0x0601D291 RID: 119441 RVA: 0x004185B4 File Offset: 0x004167B4
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

		// Token: 0x0601D292 RID: 119442 RVA: 0x004185EF File Offset: 0x004167EF
		public Span<byte> GetAreaTeleportPathBytes()
		{
			return this.__p.__vector_as_span<byte>(178, 1);
		}

		// Token: 0x0601D293 RID: 119443 RVA: 0x00418602 File Offset: 0x00416802
		public byte[] GetAreaTeleportPathArray()
		{
			return this.__p.__vector_as_array<byte>(178);
		}

		// Token: 0x17008775 RID: 34677
		// (get) Token: 0x0601D294 RID: 119444 RVA: 0x00418614 File Offset: 0x00416814
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

		// Token: 0x0601D295 RID: 119445 RVA: 0x0041864F File Offset: 0x0041684F
		public Span<byte> GetSeqAreaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(180, 1);
		}

		// Token: 0x0601D296 RID: 119446 RVA: 0x00418662 File Offset: 0x00416862
		public byte[] GetSeqAreaPathArray()
		{
			return this.__p.__vector_as_array<byte>(180);
		}

		// Token: 0x17008776 RID: 34678
		// (get) Token: 0x0601D297 RID: 119447 RVA: 0x00418674 File Offset: 0x00416874
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

		// Token: 0x0601D298 RID: 119448 RVA: 0x004186AF File Offset: 0x004168AF
		public Span<byte> GetDungeonAreaOwnerDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(182, 1);
		}

		// Token: 0x0601D299 RID: 119449 RVA: 0x004186C2 File Offset: 0x004168C2
		public byte[] GetDungeonAreaOwnerDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(182);
		}

		// Token: 0x17008777 RID: 34679
		// (get) Token: 0x0601D29A RID: 119450 RVA: 0x004186D4 File Offset: 0x004168D4
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

		// Token: 0x0601D29B RID: 119451 RVA: 0x0041870F File Offset: 0x0041690F
		public Span<byte> GetDungeonAreaReachableDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(184, 1);
		}

		// Token: 0x0601D29C RID: 119452 RVA: 0x00418722 File Offset: 0x00416922
		public byte[] GetDungeonAreaReachableDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(184);
		}

		// Token: 0x17008778 RID: 34680
		// (get) Token: 0x0601D29D RID: 119453 RVA: 0x00418734 File Offset: 0x00416934
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

		// Token: 0x0601D29E RID: 119454 RVA: 0x0041876F File Offset: 0x0041696F
		public Span<byte> GetTimeSchedulePathBytes()
		{
			return this.__p.__vector_as_span<byte>(186, 1);
		}

		// Token: 0x0601D29F RID: 119455 RVA: 0x00418782 File Offset: 0x00416982
		public byte[] GetTimeSchedulePathArray()
		{
			return this.__p.__vector_as_array<byte>(186);
		}

		// Token: 0x17008779 RID: 34681
		// (get) Token: 0x0601D2A0 RID: 119456 RVA: 0x00418794 File Offset: 0x00416994
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

		// Token: 0x0601D2A1 RID: 119457 RVA: 0x004187CF File Offset: 0x004169CF
		public Span<byte> GetAiBehaviorTreePathBytes()
		{
			return this.__p.__vector_as_span<byte>(188, 1);
		}

		// Token: 0x0601D2A2 RID: 119458 RVA: 0x004187E2 File Offset: 0x004169E2
		public byte[] GetAiBehaviorTreePathArray()
		{
			return this.__p.__vector_as_array<byte>(188);
		}

		// Token: 0x1700877A RID: 34682
		// (get) Token: 0x0601D2A3 RID: 119459 RVA: 0x004187F4 File Offset: 0x004169F4
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

		// Token: 0x0601D2A4 RID: 119460 RVA: 0x0041882F File Offset: 0x00416A2F
		public Span<byte> GetRecallDataConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(190, 1);
		}

		// Token: 0x0601D2A5 RID: 119461 RVA: 0x00418842 File Offset: 0x00416A42
		public byte[] GetRecallDataConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(190);
		}

		// Token: 0x1700877B RID: 34683
		// (get) Token: 0x0601D2A6 RID: 119462 RVA: 0x00418854 File Offset: 0x00416A54
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

		// Token: 0x0601D2A7 RID: 119463 RVA: 0x0041888F File Offset: 0x00416A8F
		public Span<byte> GetCombatOperationCaptureDirBytes()
		{
			return this.__p.__vector_as_span<byte>(192, 1);
		}

		// Token: 0x0601D2A8 RID: 119464 RVA: 0x004188A2 File Offset: 0x00416AA2
		public byte[] GetCombatOperationCaptureDirArray()
		{
			return this.__p.__vector_as_array<byte>(192);
		}

		// Token: 0x1700877C RID: 34684
		// (get) Token: 0x0601D2A9 RID: 119465 RVA: 0x004188B4 File Offset: 0x00416AB4
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

		// Token: 0x0601D2AA RID: 119466 RVA: 0x004188EF File Offset: 0x00416AEF
		public Span<byte> GetRecallEntityConfigPathBytes()
		{
			return this.__p.__vector_as_span<byte>(194, 1);
		}

		// Token: 0x0601D2AB RID: 119467 RVA: 0x00418902 File Offset: 0x00416B02
		public byte[] GetRecallEntityConfigPathArray()
		{
			return this.__p.__vector_as_array<byte>(194);
		}

		// Token: 0x0601D2AC RID: 119468 RVA: 0x00418914 File Offset: 0x00416B14
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

		// Token: 0x0601D2AD RID: 119469 RVA: 0x00418C2C File Offset: 0x00416E2C
		public static void StartIGlobalConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(96);
		}

		// Token: 0x0601D2AE RID: 119470 RVA: 0x00418C36 File Offset: 0x00416E36
		public static void AddActionConfigPath(FlatBufferBuilder builder, StringOffset actionConfigPathOffset)
		{
			builder.AddOffset(0, actionConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2AF RID: 119471 RVA: 0x00418C46 File Offset: 0x00416E46
		public static void AddComponentConfigPath(FlatBufferBuilder builder, StringOffset componentConfigPathOffset)
		{
			builder.AddOffset(1, componentConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2B0 RID: 119472 RVA: 0x00418C56 File Offset: 0x00416E56
		public static void AddEntityConfigPath(FlatBufferBuilder builder, StringOffset entityConfigPathOffset)
		{
			builder.AddOffset(2, entityConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2B1 RID: 119473 RVA: 0x00418C66 File Offset: 0x00416E66
		public static void AddBlueprintConfigPath(FlatBufferBuilder builder, StringOffset blueprintConfigPathOffset)
		{
			builder.AddOffset(3, blueprintConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2B2 RID: 119474 RVA: 0x00418C76 File Offset: 0x00416E76
		public static void AddLevelsConfigPath(FlatBufferBuilder builder, StringOffset levelsConfigPathOffset)
		{
			builder.AddOffset(4, levelsConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2B3 RID: 119475 RVA: 0x00418C86 File Offset: 0x00416E86
		public static void AddSubWpMapConfigPath(FlatBufferBuilder builder, StringOffset subWpMapConfigPathOffset)
		{
			builder.AddOffset(5, subWpMapConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2B4 RID: 119476 RVA: 0x00418C96 File Offset: 0x00416E96
		public static void AddLevelsDir(FlatBufferBuilder builder, StringOffset levelsDirOffset)
		{
			builder.AddOffset(6, levelsDirOffset.Value, 0);
		}

		// Token: 0x0601D2B5 RID: 119477 RVA: 0x00418CA6 File Offset: 0x00416EA6
		public static void AddLevelsDataDir(FlatBufferBuilder builder, StringOffset levelsDataDirOffset)
		{
			builder.AddOffset(7, levelsDataDirOffset.Value, 0);
		}

		// Token: 0x0601D2B6 RID: 119478 RVA: 0x00418CB6 File Offset: 0x00416EB6
		public static void AddTemplateDir(FlatBufferBuilder builder, StringOffset templateDirOffset)
		{
			builder.AddOffset(8, templateDirOffset.Value, 0);
		}

		// Token: 0x0601D2B7 RID: 119479 RVA: 0x00418CC6 File Offset: 0x00416EC6
		public static void AddTemplateConfigPath(FlatBufferBuilder builder, StringOffset templateConfigPathOffset)
		{
			builder.AddOffset(9, templateConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2B8 RID: 119480 RVA: 0x00418CD7 File Offset: 0x00416ED7
		public static void AddEntityDataConfigPath(FlatBufferBuilder builder, StringOffset entityDataConfigPathOffset)
		{
			builder.AddOffset(10, entityDataConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2B9 RID: 119481 RVA: 0x00418CE8 File Offset: 0x00416EE8
		public static void AddTypeScriptRoot(FlatBufferBuilder builder, StringOffset typeScriptRootOffset)
		{
			builder.AddOffset(11, typeScriptRootOffset.Value, 0);
		}

		// Token: 0x0601D2BA RID: 119482 RVA: 0x00418CF9 File Offset: 0x00416EF9
		public static void AddCsvFileDir(FlatBufferBuilder builder, StringOffset csvFileDirOffset)
		{
			builder.AddOffset(12, csvFileDirOffset.Value, 0);
		}

		// Token: 0x0601D2BB RID: 119483 RVA: 0x00418D0A File Offset: 0x00416F0A
		public static void AddFlowListDir(FlatBufferBuilder builder, StringOffset flowListDirOffset)
		{
			builder.AddOffset(13, flowListDirOffset.Value, 0);
		}

		// Token: 0x0601D2BC RID: 119484 RVA: 0x00418D1B File Offset: 0x00416F1B
		public static void AddQuestListDir(FlatBufferBuilder builder, StringOffset questListDirOffset)
		{
			builder.AddOffset(14, questListDirOffset.Value, 0);
		}

		// Token: 0x0601D2BD RID: 119485 RVA: 0x00418D2C File Offset: 0x00416F2C
		public static void AddQuestListExportDir(FlatBufferBuilder builder, StringOffset questListExportDirOffset)
		{
			builder.AddOffset(15, questListExportDirOffset.Value, 0);
		}

		// Token: 0x0601D2BE RID: 119486 RVA: 0x00418D3D File Offset: 0x00416F3D
		public static void AddEntityStateConfigPath(FlatBufferBuilder builder, StringOffset entityStateConfigPathOffset)
		{
			builder.AddOffset(16, entityStateConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2BF RID: 119487 RVA: 0x00418D4E File Offset: 0x00416F4E
		public static void AddEntityOwnerConfigPath(FlatBufferBuilder builder, StringOffset entityOwnerConfigPathOffset)
		{
			builder.AddOffset(17, entityOwnerConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2C0 RID: 119488 RVA: 0x00418D5F File Offset: 0x00416F5F
		public static void AddChildEntityOwnerConfigPath(FlatBufferBuilder builder, StringOffset childEntityOwnerConfigPathOffset)
		{
			builder.AddOffset(18, childEntityOwnerConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2C1 RID: 119489 RVA: 0x00418D70 File Offset: 0x00416F70
		public static void AddAlwaysLoadEntityConfigPath(FlatBufferBuilder builder, StringOffset alwaysLoadEntityConfigPathOffset)
		{
			builder.AddOffset(19, alwaysLoadEntityConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2C2 RID: 119490 RVA: 0x00418D81 File Offset: 0x00416F81
		public static void AddLevelPlayListDir(FlatBufferBuilder builder, StringOffset levelPlayListDirOffset)
		{
			builder.AddOffset(20, levelPlayListDirOffset.Value, 0);
		}

		// Token: 0x0601D2C3 RID: 119491 RVA: 0x00418D92 File Offset: 0x00416F92
		public static void AddLevelPlayListExportDir(FlatBufferBuilder builder, StringOffset levelPlayListExportDirOffset)
		{
			builder.AddOffset(21, levelPlayListExportDirOffset.Value, 0);
		}

		// Token: 0x0601D2C4 RID: 119492 RVA: 0x00418DA3 File Offset: 0x00416FA3
		public static void AddDynamicLevelPlayListExportDir(FlatBufferBuilder builder, StringOffset dynamicLevelPlayListExportDirOffset)
		{
			builder.AddOffset(22, dynamicLevelPlayListExportDirOffset.Value, 0);
		}

		// Token: 0x0601D2C5 RID: 119493 RVA: 0x00418DB4 File Offset: 0x00416FB4
		public static void AddTwoDimensionLevelListDir(FlatBufferBuilder builder, StringOffset twoDimensionLevelListDirOffset)
		{
			builder.AddOffset(23, twoDimensionLevelListDirOffset.Value, 0);
		}

		// Token: 0x0601D2C6 RID: 119494 RVA: 0x00418DC5 File Offset: 0x00416FC5
		public static void AddDangoBrawlObjectTemplateDir(FlatBufferBuilder builder, StringOffset dangoBrawlObjectTemplateDirOffset)
		{
			builder.AddOffset(24, dangoBrawlObjectTemplateDirOffset.Value, 0);
		}

		// Token: 0x0601D2C7 RID: 119495 RVA: 0x00418DD6 File Offset: 0x00416FD6
		public static void AddMarbleLevelConfigPath(FlatBufferBuilder builder, StringOffset marbleLevelConfigPathOffset)
		{
			builder.AddOffset(25, marbleLevelConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2C8 RID: 119496 RVA: 0x00418DE7 File Offset: 0x00416FE7
		public static void AddDangoBrawlLevelConfigPath(FlatBufferBuilder builder, StringOffset dangoBrawlLevelConfigPathOffset)
		{
			builder.AddOffset(26, dangoBrawlLevelConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2C9 RID: 119497 RVA: 0x00418DF8 File Offset: 0x00416FF8
		public static void AddDangoBrawlObjectTemplateConfigPath(FlatBufferBuilder builder, StringOffset dangoBrawlObjectTemplateConfigPathOffset)
		{
			builder.AddOffset(27, dangoBrawlObjectTemplateConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2CA RID: 119498 RVA: 0x00418E09 File Offset: 0x00417009
		public static void AddFunctionalTestDir(FlatBufferBuilder builder, StringOffset functionalTestDirOffset)
		{
			builder.AddOffset(28, functionalTestDirOffset.Value, 0);
		}

		// Token: 0x0601D2CB RID: 119499 RVA: 0x00418E1A File Offset: 0x0041701A
		public static void AddFlowTemplateConfigPath(FlatBufferBuilder builder, StringOffset flowTemplateConfigPathOffset)
		{
			builder.AddOffset(29, flowTemplateConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2CC RID: 119500 RVA: 0x00418E2B File Offset: 0x0041702B
		public static void AddFlowTemplateCameraDir(FlatBufferBuilder builder, StringOffset flowTemplateCameraDirOffset)
		{
			builder.AddOffset(30, flowTemplateCameraDirOffset.Value, 0);
		}

		// Token: 0x0601D2CD RID: 119501 RVA: 0x00418E3C File Offset: 0x0041703C
		public static void AddFlowTemplateCameraConfigPath(FlatBufferBuilder builder, StringOffset flowTemplateCameraConfigPathOffset)
		{
			builder.AddOffset(31, flowTemplateCameraConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2CE RID: 119502 RVA: 0x00418E4D File Offset: 0x0041704D
		public static void AddFlowTemplateCameraConfgSourcePath(FlatBufferBuilder builder, StringOffset flowTemplateCameraConfgSourcePathOffset)
		{
			builder.AddOffset(32, flowTemplateCameraConfgSourcePathOffset.Value, 0);
		}

		// Token: 0x0601D2CF RID: 119503 RVA: 0x00418E5E File Offset: 0x0041705E
		public static void AddGlobalVarConfigPath(FlatBufferBuilder builder, StringOffset globalVarConfigPathOffset)
		{
			builder.AddOffset(33, globalVarConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2D0 RID: 119504 RVA: 0x00418E6F File Offset: 0x0041706F
		public static void AddSystemVarConfigPath(FlatBufferBuilder builder, StringOffset systemVarConfigPathOffset)
		{
			builder.AddOffset(34, systemVarConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2D1 RID: 119505 RVA: 0x00418E80 File Offset: 0x00417080
		public static void AddVehicleRidingRolesConfigPath(FlatBufferBuilder builder, StringOffset vehicleRidingRolesConfigPathOffset)
		{
			builder.AddOffset(35, vehicleRidingRolesConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2D2 RID: 119506 RVA: 0x00418E91 File Offset: 0x00417091
		public static void AddOccupationConfigPath(FlatBufferBuilder builder, StringOffset occupationConfigPathOffset)
		{
			builder.AddOffset(36, occupationConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2D3 RID: 119507 RVA: 0x00418EA2 File Offset: 0x004170A2
		public static void AddOccupiedExportPath(FlatBufferBuilder builder, StringOffset occupiedExportPathOffset)
		{
			builder.AddOffset(37, occupiedExportPathOffset.Value, 0);
		}

		// Token: 0x0601D2D4 RID: 119508 RVA: 0x00418EB3 File Offset: 0x004170B3
		public static void AddInteractOptionConfigPath(FlatBufferBuilder builder, StringOffset interactOptionConfigPathOffset)
		{
			builder.AddOffset(38, interactOptionConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2D5 RID: 119509 RVA: 0x00418EC4 File Offset: 0x004170C4
		public static void AddAreaEntitiesPath(FlatBufferBuilder builder, StringOffset areaEntitiesPathOffset)
		{
			builder.AddOffset(39, areaEntitiesPathOffset.Value, 0);
		}

		// Token: 0x0601D2D6 RID: 119510 RVA: 0x00418ED5 File Offset: 0x004170D5
		public static void AddBtConfigPath(FlatBufferBuilder builder, StringOffset btConfigPathOffset)
		{
			builder.AddOffset(40, btConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2D7 RID: 119511 RVA: 0x00418EE6 File Offset: 0x004170E6
		public static void AddMontageConfigPath(FlatBufferBuilder builder, StringOffset montageConfigPathOffset)
		{
			builder.AddOffset(41, montageConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2D8 RID: 119512 RVA: 0x00418EF7 File Offset: 0x004170F7
		public static void AddAbpMontageConfigPath(FlatBufferBuilder builder, StringOffset abpMontageConfigPathOffset)
		{
			builder.AddOffset(42, abpMontageConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2D9 RID: 119513 RVA: 0x00418F08 File Offset: 0x00417108
		public static void AddAbpOverlayMontageConfigPath(FlatBufferBuilder builder, StringOffset abpOverlayMontageConfigPathOffset)
		{
			builder.AddOffset(43, abpOverlayMontageConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2DA RID: 119514 RVA: 0x00418F19 File Offset: 0x00417119
		public static void AddAbpStateConfigPath(FlatBufferBuilder builder, StringOffset abpStateConfigPathOffset)
		{
			builder.AddOffset(44, abpStateConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2DB RID: 119515 RVA: 0x00418F2A File Offset: 0x0041712A
		public static void AddFaceExpressionConfigPath(FlatBufferBuilder builder, StringOffset faceExpressionConfigPathOffset)
		{
			builder.AddOffset(45, faceExpressionConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2DC RID: 119516 RVA: 0x00418F3B File Offset: 0x0041713B
		public static void AddAoiGroupPath(FlatBufferBuilder builder, StringOffset aoiGroupPathOffset)
		{
			builder.AddOffset(46, aoiGroupPathOffset.Value, 0);
		}

		// Token: 0x0601D2DD RID: 119517 RVA: 0x00418F4C File Offset: 0x0041714C
		public static void AddEntityPerformanceDataPath(FlatBufferBuilder builder, StringOffset entityPerformanceDataPathOffset)
		{
			builder.AddOffset(47, entityPerformanceDataPathOffset.Value, 0);
		}

		// Token: 0x0601D2DE RID: 119518 RVA: 0x00418F5D File Offset: 0x0041715D
		public static void AddActorRefConfigPath(FlatBufferBuilder builder, StringOffset actorRefConfigPathOffset)
		{
			builder.AddOffset(48, actorRefConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2DF RID: 119519 RVA: 0x00418F6E File Offset: 0x0041716E
		public static void AddAoiDefineDataPath(FlatBufferBuilder builder, StringOffset aoiDefineDataPathOffset)
		{
			builder.AddOffset(49, aoiDefineDataPathOffset.Value, 0);
		}

		// Token: 0x0601D2E0 RID: 119520 RVA: 0x00418F7F File Offset: 0x0041717F
		public static void AddPrefabDir(FlatBufferBuilder builder, StringOffset prefabDirOffset)
		{
			builder.AddOffset(50, prefabDirOffset.Value, 0);
		}

		// Token: 0x0601D2E1 RID: 119521 RVA: 0x00418F90 File Offset: 0x00417190
		public static void AddBundleDir(FlatBufferBuilder builder, StringOffset bundleDirOffset)
		{
			builder.AddOffset(51, bundleDirOffset.Value, 0);
		}

		// Token: 0x0601D2E2 RID: 119522 RVA: 0x00418FA1 File Offset: 0x004171A1
		public static void AddPrefabConfigPath(FlatBufferBuilder builder, StringOffset prefabConfigPathOffset)
		{
			builder.AddOffset(52, prefabConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2E3 RID: 119523 RVA: 0x00418FB2 File Offset: 0x004171B2
		public static void AddEditorStartConfig(FlatBufferBuilder builder, StringOffset editorStartConfigOffset)
		{
			builder.AddOffset(53, editorStartConfigOffset.Value, 0);
		}

		// Token: 0x0601D2E4 RID: 119524 RVA: 0x00418FC3 File Offset: 0x004171C3
		public static void AddBubbleConfigPath(FlatBufferBuilder builder, StringOffset bubbleConfigPathOffset)
		{
			builder.AddOffset(54, bubbleConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2E5 RID: 119525 RVA: 0x00418FD4 File Offset: 0x004171D4
		public static void AddLevelEntityVoxelPath(FlatBufferBuilder builder, StringOffset levelEntityVoxelPathOffset)
		{
			builder.AddOffset(55, levelEntityVoxelPathOffset.Value, 0);
		}

		// Token: 0x0601D2E6 RID: 119526 RVA: 0x00418FE5 File Offset: 0x004171E5
		public static void AddTidTextTempPath(FlatBufferBuilder builder, StringOffset tidTextTempPathOffset)
		{
			builder.AddOffset(56, tidTextTempPathOffset.Value, 0);
		}

		// Token: 0x0601D2E7 RID: 119527 RVA: 0x00418FF6 File Offset: 0x004171F6
		public static void AddAudioStatePath(FlatBufferBuilder builder, StringOffset audioStatePathOffset)
		{
			builder.AddOffset(57, audioStatePathOffset.Value, 0);
		}

		// Token: 0x0601D2E8 RID: 119528 RVA: 0x00419007 File Offset: 0x00417207
		public static void AddPlotHandBookPath(FlatBufferBuilder builder, StringOffset plotHandBookPathOffset)
		{
			builder.AddOffset(58, plotHandBookPathOffset.Value, 0);
		}

		// Token: 0x0601D2E9 RID: 119529 RVA: 0x00419018 File Offset: 0x00417218
		public static void AddPlotPositionPath(FlatBufferBuilder builder, StringOffset plotPositionPathOffset)
		{
			builder.AddOffset(59, plotPositionPathOffset.Value, 0);
		}

		// Token: 0x0601D2EA RID: 119530 RVA: 0x00419029 File Offset: 0x00417229
		public static void AddTextLibraryDir(FlatBufferBuilder builder, StringOffset textLibraryDirOffset)
		{
			builder.AddOffset(60, textLibraryDirOffset.Value, 0);
		}

		// Token: 0x0601D2EB RID: 119531 RVA: 0x0041903A File Offset: 0x0041723A
		public static void AddEnrichmentArea(FlatBufferBuilder builder, StringOffset enrichmentAreaOffset)
		{
			builder.AddOffset(61, enrichmentAreaOffset.Value, 0);
		}

		// Token: 0x0601D2EC RID: 119532 RVA: 0x0041904B File Offset: 0x0041724B
		public static void AddMarkedErrorCsvPath(FlatBufferBuilder builder, StringOffset markedErrorCsvPathOffset)
		{
			builder.AddOffset(62, markedErrorCsvPathOffset.Value, 0);
		}

		// Token: 0x0601D2ED RID: 119533 RVA: 0x0041905C File Offset: 0x0041725C
		public static void AddBrokenRockConfig(FlatBufferBuilder builder, StringOffset brokenRockConfigOffset)
		{
			builder.AddOffset(63, brokenRockConfigOffset.Value, 0);
		}

		// Token: 0x0601D2EE RID: 119534 RVA: 0x0041906D File Offset: 0x0041726D
		public static void AddGridItemShapeConfigPath(FlatBufferBuilder builder, StringOffset gridItemShapeConfigPathOffset)
		{
			builder.AddOffset(64, gridItemShapeConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2EF RID: 119535 RVA: 0x0041907E File Offset: 0x0041727E
		public static void AddFishingRouletteConfig(FlatBufferBuilder builder, StringOffset fishingRouletteConfigOffset)
		{
			builder.AddOffset(65, fishingRouletteConfigOffset.Value, 0);
		}

		// Token: 0x0601D2F0 RID: 119536 RVA: 0x0041908F File Offset: 0x0041728F
		public static void AddAreaQuestTracking(FlatBufferBuilder builder, StringOffset areaQuestTrackingOffset)
		{
			builder.AddOffset(66, areaQuestTrackingOffset.Value, 0);
		}

		// Token: 0x0601D2F1 RID: 119537 RVA: 0x004190A0 File Offset: 0x004172A0
		public static void AddOfflineComponentExportPath(FlatBufferBuilder builder, StringOffset offlineComponentExportPathOffset)
		{
			builder.AddOffset(67, offlineComponentExportPathOffset.Value, 0);
		}

		// Token: 0x0601D2F2 RID: 119538 RVA: 0x004190B1 File Offset: 0x004172B1
		public static void AddSummonGongduolaConfigExportPath(FlatBufferBuilder builder, StringOffset summonGongduolaConfigExportPathOffset)
		{
			builder.AddOffset(68, summonGongduolaConfigExportPathOffset.Value, 0);
		}

		// Token: 0x0601D2F3 RID: 119539 RVA: 0x004190C2 File Offset: 0x004172C2
		public static void AddHideGroupFixConfigPath(FlatBufferBuilder builder, StringOffset hideGroupFixConfigPathOffset)
		{
			builder.AddOffset(69, hideGroupFixConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2F4 RID: 119540 RVA: 0x004190D3 File Offset: 0x004172D3
		public static void AddEntityFixProcessorPath(FlatBufferBuilder builder, StringOffset entityFixProcessorPathOffset)
		{
			builder.AddOffset(70, entityFixProcessorPathOffset.Value, 0);
		}

		// Token: 0x0601D2F5 RID: 119541 RVA: 0x004190E4 File Offset: 0x004172E4
		public static void AddGravityAbnormalEntityListPath(FlatBufferBuilder builder, StringOffset gravityAbnormalEntityListPathOffset)
		{
			builder.AddOffset(71, gravityAbnormalEntityListPathOffset.Value, 0);
		}

		// Token: 0x0601D2F6 RID: 119542 RVA: 0x004190F5 File Offset: 0x004172F5
		public static void AddActorRefComponentsConfigPath(FlatBufferBuilder builder, StringOffset actorRefComponentsConfigPathOffset)
		{
			builder.AddOffset(72, actorRefComponentsConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2F7 RID: 119543 RVA: 0x00419106 File Offset: 0x00417306
		public static void AddSeqRefComponentsConfigPath(FlatBufferBuilder builder, StringOffset seqRefComponentsConfigPathOffset)
		{
			builder.AddOffset(73, seqRefComponentsConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2F8 RID: 119544 RVA: 0x00419117 File Offset: 0x00417317
		public static void AddQuestRefMp4Path(FlatBufferBuilder builder, StringOffset questRefMp4PathOffset)
		{
			builder.AddOffset(74, questRefMp4PathOffset.Value, 0);
		}

		// Token: 0x0601D2F9 RID: 119545 RVA: 0x00419128 File Offset: 0x00417328
		public static void AddBehaviorTreeFragmentDir(FlatBufferBuilder builder, StringOffset behaviorTreeFragmentDirOffset)
		{
			builder.AddOffset(75, behaviorTreeFragmentDirOffset.Value, 0);
		}

		// Token: 0x0601D2FA RID: 119546 RVA: 0x00419139 File Offset: 0x00417339
		public static void AddCommonBtDir(FlatBufferBuilder builder, StringOffset commonBtDirOffset)
		{
			builder.AddOffset(76, commonBtDirOffset.Value, 0);
		}

		// Token: 0x0601D2FB RID: 119547 RVA: 0x0041914A File Offset: 0x0041734A
		public static void AddCommonBtExportDir(FlatBufferBuilder builder, StringOffset commonBtExportDirOffset)
		{
			builder.AddOffset(77, commonBtExportDirOffset.Value, 0);
		}

		// Token: 0x0601D2FC RID: 119548 RVA: 0x0041915B File Offset: 0x0041735B
		public static void AddLevelBuildingGrids(FlatBufferBuilder builder, StringOffset levelBuildingGridsOffset)
		{
			builder.AddOffset(78, levelBuildingGridsOffset.Value, 0);
		}

		// Token: 0x0601D2FD RID: 119549 RVA: 0x0041916C File Offset: 0x0041736C
		public static void AddGlobalFixConfigPath(FlatBufferBuilder builder, StringOffset globalFixConfigPathOffset)
		{
			builder.AddOffset(79, globalFixConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2FE RID: 119550 RVA: 0x0041917D File Offset: 0x0041737D
		public static void AddAreaFunctionConfigPath(FlatBufferBuilder builder, StringOffset areaFunctionConfigPathOffset)
		{
			builder.AddOffset(80, areaFunctionConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D2FF RID: 119551 RVA: 0x0041918E File Offset: 0x0041738E
		public static void AddDynamicSpawnMonsterRandomPoolConfigPath(FlatBufferBuilder builder, StringOffset dynamicSpawnMonsterRandomPoolConfigPathOffset)
		{
			builder.AddOffset(81, dynamicSpawnMonsterRandomPoolConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D300 RID: 119552 RVA: 0x0041919F File Offset: 0x0041739F
		public static void AddEntityCustomPrimitiveData(FlatBufferBuilder builder, StringOffset entityCustomPrimitiveDataOffset)
		{
			builder.AddOffset(82, entityCustomPrimitiveDataOffset.Value, 0);
		}

		// Token: 0x0601D301 RID: 119553 RVA: 0x004191B0 File Offset: 0x004173B0
		public static void AddAnimalStandbyTagPath(FlatBufferBuilder builder, StringOffset animalStandbyTagPathOffset)
		{
			builder.AddOffset(83, animalStandbyTagPathOffset.Value, 0);
		}

		// Token: 0x0601D302 RID: 119554 RVA: 0x004191C1 File Offset: 0x004173C1
		public static void AddAnsPerformDataPath(FlatBufferBuilder builder, StringOffset ansPerformDataPathOffset)
		{
			builder.AddOffset(84, ansPerformDataPathOffset.Value, 0);
		}

		// Token: 0x0601D303 RID: 119555 RVA: 0x004191D2 File Offset: 0x004173D2
		public static void AddRoadZonePath(FlatBufferBuilder builder, StringOffset roadZonePathOffset)
		{
			builder.AddOffset(85, roadZonePathOffset.Value, 0);
		}

		// Token: 0x0601D304 RID: 119556 RVA: 0x004191E3 File Offset: 0x004173E3
		public static void AddUltraLeaveRadiusLevelPlayPath(FlatBufferBuilder builder, StringOffset ultraLeaveRadiusLevelPlayPathOffset)
		{
			builder.AddOffset(86, ultraLeaveRadiusLevelPlayPathOffset.Value, 0);
		}

		// Token: 0x0601D305 RID: 119557 RVA: 0x004191F4 File Offset: 0x004173F4
		public static void AddAreaTeleportPath(FlatBufferBuilder builder, StringOffset areaTeleportPathOffset)
		{
			builder.AddOffset(87, areaTeleportPathOffset.Value, 0);
		}

		// Token: 0x0601D306 RID: 119558 RVA: 0x00419205 File Offset: 0x00417405
		public static void AddSeqAreaPath(FlatBufferBuilder builder, StringOffset seqAreaPathOffset)
		{
			builder.AddOffset(88, seqAreaPathOffset.Value, 0);
		}

		// Token: 0x0601D307 RID: 119559 RVA: 0x00419216 File Offset: 0x00417416
		public static void AddDungeonAreaOwnerDataPath(FlatBufferBuilder builder, StringOffset dungeonAreaOwnerDataPathOffset)
		{
			builder.AddOffset(89, dungeonAreaOwnerDataPathOffset.Value, 0);
		}

		// Token: 0x0601D308 RID: 119560 RVA: 0x00419227 File Offset: 0x00417427
		public static void AddDungeonAreaReachableDataPath(FlatBufferBuilder builder, StringOffset dungeonAreaReachableDataPathOffset)
		{
			builder.AddOffset(90, dungeonAreaReachableDataPathOffset.Value, 0);
		}

		// Token: 0x0601D309 RID: 119561 RVA: 0x00419238 File Offset: 0x00417438
		public static void AddTimeSchedulePath(FlatBufferBuilder builder, StringOffset timeSchedulePathOffset)
		{
			builder.AddOffset(91, timeSchedulePathOffset.Value, 0);
		}

		// Token: 0x0601D30A RID: 119562 RVA: 0x00419249 File Offset: 0x00417449
		public static void AddAiBehaviorTreePath(FlatBufferBuilder builder, StringOffset aiBehaviorTreePathOffset)
		{
			builder.AddOffset(92, aiBehaviorTreePathOffset.Value, 0);
		}

		// Token: 0x0601D30B RID: 119563 RVA: 0x0041925A File Offset: 0x0041745A
		public static void AddRecallDataConfigPath(FlatBufferBuilder builder, StringOffset recallDataConfigPathOffset)
		{
			builder.AddOffset(93, recallDataConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D30C RID: 119564 RVA: 0x0041926B File Offset: 0x0041746B
		public static void AddCombatOperationCaptureDir(FlatBufferBuilder builder, StringOffset combatOperationCaptureDirOffset)
		{
			builder.AddOffset(94, combatOperationCaptureDirOffset.Value, 0);
		}

		// Token: 0x0601D30D RID: 119565 RVA: 0x0041927C File Offset: 0x0041747C
		public static void AddRecallEntityConfigPath(FlatBufferBuilder builder, StringOffset recallEntityConfigPathOffset)
		{
			builder.AddOffset(95, recallEntityConfigPathOffset.Value, 0);
		}

		// Token: 0x0601D30E RID: 119566 RVA: 0x0041928D File Offset: 0x0041748D
		public static Offset<IGlobalConfig> EndIGlobalConfig(FlatBufferBuilder builder)
		{
			return new Offset<IGlobalConfig>(builder.EndTable());
		}

		// Token: 0x0601D30F RID: 119567 RVA: 0x0041929C File Offset: 0x0041749C
		public IGlobalConfigT UnPack()
		{
			IGlobalConfigT globalConfigT = new IGlobalConfigT();
			this.UnPackTo(globalConfigT);
			return globalConfigT;
		}

		// Token: 0x0601D310 RID: 119568 RVA: 0x004192B8 File Offset: 0x004174B8
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

		// Token: 0x0601D311 RID: 119569 RVA: 0x00419748 File Offset: 0x00417948
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

		// Token: 0x0400D318 RID: 54040
		private Table __p;
	}
}

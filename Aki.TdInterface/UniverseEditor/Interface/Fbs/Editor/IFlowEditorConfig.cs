using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200487A RID: 18554
	public struct IFlowEditorConfig : IFlatbufferObject
	{
		// Token: 0x17008644 RID: 34372
		// (get) Token: 0x0601CE5E RID: 118366 RVA: 0x00415A58 File Offset: 0x00413C58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CE5F RID: 118367 RVA: 0x00415A65 File Offset: 0x00413C65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CE60 RID: 118368 RVA: 0x00415A6C File Offset: 0x00413C6C
		public static IFlowEditorConfig GetRootAsIFlowEditorConfig(ByteBuffer _bb)
		{
			return IFlowEditorConfig.GetRootAsIFlowEditorConfig(_bb, default(IFlowEditorConfig));
		}

		// Token: 0x0601CE61 RID: 118369 RVA: 0x00415A88 File Offset: 0x00413C88
		public static IFlowEditorConfig GetRootAsIFlowEditorConfig(ByteBuffer _bb, IFlowEditorConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CE62 RID: 118370 RVA: 0x00415AA5 File Offset: 0x00413CA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CE63 RID: 118371 RVA: 0x00415AB4 File Offset: 0x00413CB4
		public IFlowEditorConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008645 RID: 34373
		// (get) Token: 0x0601CE64 RID: 118372 RVA: 0x00415AC4 File Offset: 0x00413CC4
		public string CsvExportPath
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

		// Token: 0x0601CE65 RID: 118373 RVA: 0x00415AFB File Offset: 0x00413CFB
		public Span<byte> GetCsvExportPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601CE66 RID: 118374 RVA: 0x00415B0A File Offset: 0x00413D0A
		public byte[] GetCsvExportPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008646 RID: 34374
		// (get) Token: 0x0601CE67 RID: 118375 RVA: 0x00415B18 File Offset: 0x00413D18
		public string CsvImportPath
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

		// Token: 0x0601CE68 RID: 118376 RVA: 0x00415B4F File Offset: 0x00413D4F
		public Span<byte> GetCsvImportPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601CE69 RID: 118377 RVA: 0x00415B5E File Offset: 0x00413D5E
		public byte[] GetCsvImportPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008647 RID: 34375
		// (get) Token: 0x0601CE6A RID: 118378 RVA: 0x00415B6C File Offset: 0x00413D6C
		public string PlotRootDir
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

		// Token: 0x0601CE6B RID: 118379 RVA: 0x00415BA3 File Offset: 0x00413DA3
		public Span<byte> GetPlotRootDirBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601CE6C RID: 118380 RVA: 0x00415BB2 File Offset: 0x00413DB2
		public byte[] GetPlotRootDirArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008648 RID: 34376
		// (get) Token: 0x0601CE6D RID: 118381 RVA: 0x00415BC0 File Offset: 0x00413DC0
		public bool IsVerbose
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008649 RID: 34377
		// (get) Token: 0x0601CE6E RID: 118382 RVA: 0x00415C00 File Offset: 0x00413E00
		public bool ShowActionFilter
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700864A RID: 34378
		// (get) Token: 0x0601CE6F RID: 118383 RVA: 0x00415C40 File Offset: 0x00413E40
		public bool ShowTextHiddenStatus
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700864B RID: 34379
		// (get) Token: 0x0601CE70 RID: 118384 RVA: 0x00415C80 File Offset: 0x00413E80
		public bool ShowLookAtDebugArrow
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700864C RID: 34380
		// (get) Token: 0x0601CE71 RID: 118385 RVA: 0x00415CC0 File Offset: 0x00413EC0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CE72 RID: 118386 RVA: 0x00415D00 File Offset: 0x00413F00
		public static Offset<IFlowEditorConfig> CreateIFlowEditorConfig(FlatBufferBuilder builder, StringOffset CsvExportPathOffset = default(StringOffset), StringOffset CsvImportPathOffset = default(StringOffset), StringOffset PlotRootDirOffset = default(StringOffset), bool IsVerbose = false, bool ShowActionFilter = false, bool ShowTextHiddenStatus = false, bool ShowLookAtDebugArrow = false, byte NullMask = 0)
		{
			builder.StartTable(8);
			IFlowEditorConfig.AddPlotRootDir(builder, PlotRootDirOffset);
			IFlowEditorConfig.AddCsvImportPath(builder, CsvImportPathOffset);
			IFlowEditorConfig.AddCsvExportPath(builder, CsvExportPathOffset);
			IFlowEditorConfig.AddNullMask(builder, NullMask);
			IFlowEditorConfig.AddShowLookAtDebugArrow(builder, ShowLookAtDebugArrow);
			IFlowEditorConfig.AddShowTextHiddenStatus(builder, ShowTextHiddenStatus);
			IFlowEditorConfig.AddShowActionFilter(builder, ShowActionFilter);
			IFlowEditorConfig.AddIsVerbose(builder, IsVerbose);
			return IFlowEditorConfig.EndIFlowEditorConfig(builder);
		}

		// Token: 0x0601CE73 RID: 118387 RVA: 0x00415D57 File Offset: 0x00413F57
		public static void StartIFlowEditorConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601CE74 RID: 118388 RVA: 0x00415D60 File Offset: 0x00413F60
		public static void AddCsvExportPath(FlatBufferBuilder builder, StringOffset csvExportPathOffset)
		{
			builder.AddOffset(0, csvExportPathOffset.Value, 0);
		}

		// Token: 0x0601CE75 RID: 118389 RVA: 0x00415D70 File Offset: 0x00413F70
		public static void AddCsvImportPath(FlatBufferBuilder builder, StringOffset csvImportPathOffset)
		{
			builder.AddOffset(1, csvImportPathOffset.Value, 0);
		}

		// Token: 0x0601CE76 RID: 118390 RVA: 0x00415D80 File Offset: 0x00413F80
		public static void AddPlotRootDir(FlatBufferBuilder builder, StringOffset plotRootDirOffset)
		{
			builder.AddOffset(2, plotRootDirOffset.Value, 0);
		}

		// Token: 0x0601CE77 RID: 118391 RVA: 0x00415D90 File Offset: 0x00413F90
		public static void AddIsVerbose(FlatBufferBuilder builder, bool isVerbose)
		{
			builder.AddBool(3, isVerbose, false);
		}

		// Token: 0x0601CE78 RID: 118392 RVA: 0x00415D9B File Offset: 0x00413F9B
		public static void AddShowActionFilter(FlatBufferBuilder builder, bool showActionFilter)
		{
			builder.AddBool(4, showActionFilter, false);
		}

		// Token: 0x0601CE79 RID: 118393 RVA: 0x00415DA6 File Offset: 0x00413FA6
		public static void AddShowTextHiddenStatus(FlatBufferBuilder builder, bool showTextHiddenStatus)
		{
			builder.AddBool(5, showTextHiddenStatus, false);
		}

		// Token: 0x0601CE7A RID: 118394 RVA: 0x00415DB1 File Offset: 0x00413FB1
		public static void AddShowLookAtDebugArrow(FlatBufferBuilder builder, bool showLookAtDebugArrow)
		{
			builder.AddBool(6, showLookAtDebugArrow, false);
		}

		// Token: 0x0601CE7B RID: 118395 RVA: 0x00415DBC File Offset: 0x00413FBC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0601CE7C RID: 118396 RVA: 0x00415DC7 File Offset: 0x00413FC7
		public static Offset<IFlowEditorConfig> EndIFlowEditorConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFlowEditorConfig>(builder.EndTable());
		}

		// Token: 0x0601CE7D RID: 118397 RVA: 0x00415DD4 File Offset: 0x00413FD4
		public IFlowEditorConfigT UnPack()
		{
			IFlowEditorConfigT flowEditorConfigT = new IFlowEditorConfigT();
			this.UnPackTo(flowEditorConfigT);
			return flowEditorConfigT;
		}

		// Token: 0x0601CE7E RID: 118398 RVA: 0x00415DF0 File Offset: 0x00413FF0
		public void UnPackTo(IFlowEditorConfigT _o)
		{
			_o.CsvExportPath = this.CsvExportPath;
			_o.CsvImportPath = this.CsvImportPath;
			_o.PlotRootDir = this.PlotRootDir;
			_o.IsVerbose = this.IsVerbose;
			_o.ShowActionFilter = this.ShowActionFilter;
			_o.ShowTextHiddenStatus = this.ShowTextHiddenStatus;
			_o.ShowLookAtDebugArrow = this.ShowLookAtDebugArrow;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601CE7F RID: 118399 RVA: 0x00415E60 File Offset: 0x00414060
		public static Offset<IFlowEditorConfig> Pack(FlatBufferBuilder builder, IFlowEditorConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowEditorConfig>);
			}
			StringOffset csvExportPathOffset = (_o.CsvExportPath == null) ? default(StringOffset) : builder.CreateString(_o.CsvExportPath);
			StringOffset csvImportPathOffset = (_o.CsvImportPath == null) ? default(StringOffset) : builder.CreateString(_o.CsvImportPath);
			StringOffset plotRootDirOffset = (_o.PlotRootDir == null) ? default(StringOffset) : builder.CreateString(_o.PlotRootDir);
			return IFlowEditorConfig.CreateIFlowEditorConfig(builder, csvExportPathOffset, csvImportPathOffset, plotRootDirOffset, _o.IsVerbose, _o.ShowActionFilter, _o.ShowTextHiddenStatus, _o.ShowLookAtDebugArrow, _o.NullMask);
		}

		// Token: 0x0400CE3A RID: 52794
		private Table __p;
	}
}

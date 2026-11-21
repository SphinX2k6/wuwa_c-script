using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CDF RID: 19679
	public struct IFlowEditorConfig : IFlatbufferObject
	{
		// Token: 0x17008C8C RID: 35980
		// (get) Token: 0x0601E64B RID: 124491 RVA: 0x004421F4 File Offset: 0x004403F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E64C RID: 124492 RVA: 0x00442201 File Offset: 0x00440401
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E64D RID: 124493 RVA: 0x00442208 File Offset: 0x00440408
		public static IFlowEditorConfig GetRootAsIFlowEditorConfig(ByteBuffer _bb)
		{
			return IFlowEditorConfig.GetRootAsIFlowEditorConfig(_bb, default(IFlowEditorConfig));
		}

		// Token: 0x0601E64E RID: 124494 RVA: 0x00442224 File Offset: 0x00440424
		public static IFlowEditorConfig GetRootAsIFlowEditorConfig(ByteBuffer _bb, IFlowEditorConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E64F RID: 124495 RVA: 0x00442241 File Offset: 0x00440441
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E650 RID: 124496 RVA: 0x00442250 File Offset: 0x00440450
		public IFlowEditorConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C8D RID: 35981
		// (get) Token: 0x0601E651 RID: 124497 RVA: 0x00442260 File Offset: 0x00440460
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

		// Token: 0x0601E652 RID: 124498 RVA: 0x00442297 File Offset: 0x00440497
		public Span<byte> GetCsvExportPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601E653 RID: 124499 RVA: 0x004422A6 File Offset: 0x004404A6
		public byte[] GetCsvExportPathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008C8E RID: 35982
		// (get) Token: 0x0601E654 RID: 124500 RVA: 0x004422B4 File Offset: 0x004404B4
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

		// Token: 0x0601E655 RID: 124501 RVA: 0x004422EB File Offset: 0x004404EB
		public Span<byte> GetCsvImportPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601E656 RID: 124502 RVA: 0x004422FA File Offset: 0x004404FA
		public byte[] GetCsvImportPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008C8F RID: 35983
		// (get) Token: 0x0601E657 RID: 124503 RVA: 0x00442308 File Offset: 0x00440508
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

		// Token: 0x0601E658 RID: 124504 RVA: 0x0044233F File Offset: 0x0044053F
		public Span<byte> GetPlotRootDirBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601E659 RID: 124505 RVA: 0x0044234E File Offset: 0x0044054E
		public byte[] GetPlotRootDirArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008C90 RID: 35984
		// (get) Token: 0x0601E65A RID: 124506 RVA: 0x0044235C File Offset: 0x0044055C
		public bool IsVerbose
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C91 RID: 35985
		// (get) Token: 0x0601E65B RID: 124507 RVA: 0x0044239C File Offset: 0x0044059C
		public bool ShowActionFilter
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C92 RID: 35986
		// (get) Token: 0x0601E65C RID: 124508 RVA: 0x004423DC File Offset: 0x004405DC
		public bool ShowTextHiddenStatus
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C93 RID: 35987
		// (get) Token: 0x0601E65D RID: 124509 RVA: 0x0044241C File Offset: 0x0044061C
		public bool ShowLookAtDebugArrow
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008C94 RID: 35988
		// (get) Token: 0x0601E65E RID: 124510 RVA: 0x0044245C File Offset: 0x0044065C
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

		// Token: 0x0601E65F RID: 124511 RVA: 0x0044249C File Offset: 0x0044069C
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

		// Token: 0x0601E660 RID: 124512 RVA: 0x004424F3 File Offset: 0x004406F3
		public static void StartIFlowEditorConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601E661 RID: 124513 RVA: 0x004424FC File Offset: 0x004406FC
		public static void AddCsvExportPath(FlatBufferBuilder builder, StringOffset csvExportPathOffset)
		{
			builder.AddOffset(0, csvExportPathOffset.Value, 0);
		}

		// Token: 0x0601E662 RID: 124514 RVA: 0x0044250C File Offset: 0x0044070C
		public static void AddCsvImportPath(FlatBufferBuilder builder, StringOffset csvImportPathOffset)
		{
			builder.AddOffset(1, csvImportPathOffset.Value, 0);
		}

		// Token: 0x0601E663 RID: 124515 RVA: 0x0044251C File Offset: 0x0044071C
		public static void AddPlotRootDir(FlatBufferBuilder builder, StringOffset plotRootDirOffset)
		{
			builder.AddOffset(2, plotRootDirOffset.Value, 0);
		}

		// Token: 0x0601E664 RID: 124516 RVA: 0x0044252C File Offset: 0x0044072C
		public static void AddIsVerbose(FlatBufferBuilder builder, bool isVerbose)
		{
			builder.AddBool(3, isVerbose, false);
		}

		// Token: 0x0601E665 RID: 124517 RVA: 0x00442537 File Offset: 0x00440737
		public static void AddShowActionFilter(FlatBufferBuilder builder, bool showActionFilter)
		{
			builder.AddBool(4, showActionFilter, false);
		}

		// Token: 0x0601E666 RID: 124518 RVA: 0x00442542 File Offset: 0x00440742
		public static void AddShowTextHiddenStatus(FlatBufferBuilder builder, bool showTextHiddenStatus)
		{
			builder.AddBool(5, showTextHiddenStatus, false);
		}

		// Token: 0x0601E667 RID: 124519 RVA: 0x0044254D File Offset: 0x0044074D
		public static void AddShowLookAtDebugArrow(FlatBufferBuilder builder, bool showLookAtDebugArrow)
		{
			builder.AddBool(6, showLookAtDebugArrow, false);
		}

		// Token: 0x0601E668 RID: 124520 RVA: 0x00442558 File Offset: 0x00440758
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0601E669 RID: 124521 RVA: 0x00442563 File Offset: 0x00440763
		public static Offset<IFlowEditorConfig> EndIFlowEditorConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFlowEditorConfig>(builder.EndTable());
		}

		// Token: 0x0601E66A RID: 124522 RVA: 0x00442570 File Offset: 0x00440770
		public IFlowEditorConfigT UnPack()
		{
			IFlowEditorConfigT flowEditorConfigT = new IFlowEditorConfigT();
			this.UnPackTo(flowEditorConfigT);
			return flowEditorConfigT;
		}

		// Token: 0x0601E66B RID: 124523 RVA: 0x0044258C File Offset: 0x0044078C
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

		// Token: 0x0601E66C RID: 124524 RVA: 0x004425FC File Offset: 0x004407FC
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

		// Token: 0x0400D873 RID: 55411
		private Table __p;
	}
}

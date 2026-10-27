using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200485F RID: 18527
	public struct IEditorIndentationDisplaySetting : IFlatbufferObject
	{
		// Token: 0x17008562 RID: 34146
		// (get) Token: 0x0601CBCE RID: 117710 RVA: 0x004100BB File Offset: 0x0040E2BB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CBCF RID: 117711 RVA: 0x004100C8 File Offset: 0x0040E2C8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CBD0 RID: 117712 RVA: 0x004100D0 File Offset: 0x0040E2D0
		public static IEditorIndentationDisplaySetting GetRootAsIEditorIndentationDisplaySetting(ByteBuffer _bb)
		{
			return IEditorIndentationDisplaySetting.GetRootAsIEditorIndentationDisplaySetting(_bb, default(IEditorIndentationDisplaySetting));
		}

		// Token: 0x0601CBD1 RID: 117713 RVA: 0x004100EC File Offset: 0x0040E2EC
		public static IEditorIndentationDisplaySetting GetRootAsIEditorIndentationDisplaySetting(ByteBuffer _bb, IEditorIndentationDisplaySetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CBD2 RID: 117714 RVA: 0x00410109 File Offset: 0x0040E309
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CBD3 RID: 117715 RVA: 0x00410118 File Offset: 0x0040E318
		public IEditorIndentationDisplaySetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008563 RID: 34147
		// (get) Token: 0x0601CBD4 RID: 117716 RVA: 0x00410128 File Offset: 0x0040E328
		public bool EnabledShowStructureIndentLine
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008564 RID: 34148
		// (get) Token: 0x0601CBD5 RID: 117717 RVA: 0x00410168 File Offset: 0x0040E368
		public bool EnabledShowStructureBlock
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008565 RID: 34149
		// (get) Token: 0x0601CBD6 RID: 117718 RVA: 0x004101A8 File Offset: 0x0040E3A8
		public bool EnabledShowArrayElementPrefixLine
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008566 RID: 34150
		// (get) Token: 0x0601CBD7 RID: 117719 RVA: 0x004101E8 File Offset: 0x0040E3E8
		public float BaseGray
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008567 RID: 34151
		// (get) Token: 0x0601CBD8 RID: 117720 RVA: 0x0041022C File Offset: 0x0040E42C
		public float MaxGray
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008568 RID: 34152
		// (get) Token: 0x0601CBD9 RID: 117721 RVA: 0x00410270 File Offset: 0x0040E470
		public int MaxDepth
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008569 RID: 34153
		// (get) Token: 0x0601CBDA RID: 117722 RVA: 0x004102B0 File Offset: 0x0040E4B0
		public float SameLevelChangeStrength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CBDB RID: 117723 RVA: 0x004102F4 File Offset: 0x0040E4F4
		public static Offset<IEditorIndentationDisplaySetting> CreateIEditorIndentationDisplaySetting(FlatBufferBuilder builder, bool EnabledShowStructureIndentLine = false, bool EnabledShowStructureBlock = false, bool EnabledShowArrayElementPrefixLine = false, float BaseGray = 0f, float MaxGray = 0f, int MaxDepth = 0, float SameLevelChangeStrength = 0f)
		{
			builder.StartTable(7);
			IEditorIndentationDisplaySetting.AddSameLevelChangeStrength(builder, SameLevelChangeStrength);
			IEditorIndentationDisplaySetting.AddMaxDepth(builder, MaxDepth);
			IEditorIndentationDisplaySetting.AddMaxGray(builder, MaxGray);
			IEditorIndentationDisplaySetting.AddBaseGray(builder, BaseGray);
			IEditorIndentationDisplaySetting.AddEnabledShowArrayElementPrefixLine(builder, EnabledShowArrayElementPrefixLine);
			IEditorIndentationDisplaySetting.AddEnabledShowStructureBlock(builder, EnabledShowStructureBlock);
			IEditorIndentationDisplaySetting.AddEnabledShowStructureIndentLine(builder, EnabledShowStructureIndentLine);
			return IEditorIndentationDisplaySetting.EndIEditorIndentationDisplaySetting(builder);
		}

		// Token: 0x0601CBDC RID: 117724 RVA: 0x00410343 File Offset: 0x0040E543
		public static void StartIEditorIndentationDisplaySetting(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601CBDD RID: 117725 RVA: 0x0041034C File Offset: 0x0040E54C
		public static void AddEnabledShowStructureIndentLine(FlatBufferBuilder builder, bool enabledShowStructureIndentLine)
		{
			builder.AddBool(0, enabledShowStructureIndentLine, false);
		}

		// Token: 0x0601CBDE RID: 117726 RVA: 0x00410357 File Offset: 0x0040E557
		public static void AddEnabledShowStructureBlock(FlatBufferBuilder builder, bool enabledShowStructureBlock)
		{
			builder.AddBool(1, enabledShowStructureBlock, false);
		}

		// Token: 0x0601CBDF RID: 117727 RVA: 0x00410362 File Offset: 0x0040E562
		public static void AddEnabledShowArrayElementPrefixLine(FlatBufferBuilder builder, bool enabledShowArrayElementPrefixLine)
		{
			builder.AddBool(2, enabledShowArrayElementPrefixLine, false);
		}

		// Token: 0x0601CBE0 RID: 117728 RVA: 0x0041036D File Offset: 0x0040E56D
		public static void AddBaseGray(FlatBufferBuilder builder, float baseGray)
		{
			builder.AddFloat(3, baseGray, 0.0);
		}

		// Token: 0x0601CBE1 RID: 117729 RVA: 0x00410380 File Offset: 0x0040E580
		public static void AddMaxGray(FlatBufferBuilder builder, float maxGray)
		{
			builder.AddFloat(4, maxGray, 0.0);
		}

		// Token: 0x0601CBE2 RID: 117730 RVA: 0x00410393 File Offset: 0x0040E593
		public static void AddMaxDepth(FlatBufferBuilder builder, int maxDepth)
		{
			builder.AddInt(5, maxDepth, 0);
		}

		// Token: 0x0601CBE3 RID: 117731 RVA: 0x0041039E File Offset: 0x0040E59E
		public static void AddSameLevelChangeStrength(FlatBufferBuilder builder, float sameLevelChangeStrength)
		{
			builder.AddFloat(6, sameLevelChangeStrength, 0.0);
		}

		// Token: 0x0601CBE4 RID: 117732 RVA: 0x004103B1 File Offset: 0x0040E5B1
		public static Offset<IEditorIndentationDisplaySetting> EndIEditorIndentationDisplaySetting(FlatBufferBuilder builder)
		{
			return new Offset<IEditorIndentationDisplaySetting>(builder.EndTable());
		}

		// Token: 0x0601CBE5 RID: 117733 RVA: 0x004103C0 File Offset: 0x0040E5C0
		public IEditorIndentationDisplaySettingT UnPack()
		{
			IEditorIndentationDisplaySettingT editorIndentationDisplaySettingT = new IEditorIndentationDisplaySettingT();
			this.UnPackTo(editorIndentationDisplaySettingT);
			return editorIndentationDisplaySettingT;
		}

		// Token: 0x0601CBE6 RID: 117734 RVA: 0x004103DC File Offset: 0x0040E5DC
		public void UnPackTo(IEditorIndentationDisplaySettingT _o)
		{
			_o.EnabledShowStructureIndentLine = this.EnabledShowStructureIndentLine;
			_o.EnabledShowStructureBlock = this.EnabledShowStructureBlock;
			_o.EnabledShowArrayElementPrefixLine = this.EnabledShowArrayElementPrefixLine;
			_o.BaseGray = this.BaseGray;
			_o.MaxGray = this.MaxGray;
			_o.MaxDepth = this.MaxDepth;
			_o.SameLevelChangeStrength = this.SameLevelChangeStrength;
		}

		// Token: 0x0601CBE7 RID: 117735 RVA: 0x00410440 File Offset: 0x0040E640
		public static Offset<IEditorIndentationDisplaySetting> Pack(FlatBufferBuilder builder, IEditorIndentationDisplaySettingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEditorIndentationDisplaySetting>);
			}
			return IEditorIndentationDisplaySetting.CreateIEditorIndentationDisplaySetting(builder, _o.EnabledShowStructureIndentLine, _o.EnabledShowStructureBlock, _o.EnabledShowArrayElementPrefixLine, _o.BaseGray, _o.MaxGray, _o.MaxDepth, _o.SameLevelChangeStrength);
		}

		// Token: 0x0400CDC5 RID: 52677
		private Table __p;
	}
}

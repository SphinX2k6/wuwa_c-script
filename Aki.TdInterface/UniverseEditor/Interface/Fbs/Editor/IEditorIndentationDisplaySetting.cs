using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CC7 RID: 19655
	public struct IEditorIndentationDisplaySetting : IFlatbufferObject
	{
		// Token: 0x17008BB1 RID: 35761
		// (get) Token: 0x0601E3D5 RID: 123861 RVA: 0x0043CB67 File Offset: 0x0043AD67
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E3D6 RID: 123862 RVA: 0x0043CB74 File Offset: 0x0043AD74
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E3D7 RID: 123863 RVA: 0x0043CB7C File Offset: 0x0043AD7C
		public static IEditorIndentationDisplaySetting GetRootAsIEditorIndentationDisplaySetting(ByteBuffer _bb)
		{
			return IEditorIndentationDisplaySetting.GetRootAsIEditorIndentationDisplaySetting(_bb, default(IEditorIndentationDisplaySetting));
		}

		// Token: 0x0601E3D8 RID: 123864 RVA: 0x0043CB98 File Offset: 0x0043AD98
		public static IEditorIndentationDisplaySetting GetRootAsIEditorIndentationDisplaySetting(ByteBuffer _bb, IEditorIndentationDisplaySetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E3D9 RID: 123865 RVA: 0x0043CBB5 File Offset: 0x0043ADB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E3DA RID: 123866 RVA: 0x0043CBC4 File Offset: 0x0043ADC4
		public IEditorIndentationDisplaySetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008BB2 RID: 35762
		// (get) Token: 0x0601E3DB RID: 123867 RVA: 0x0043CBD4 File Offset: 0x0043ADD4
		public bool EnabledShowStructureIndentLine
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008BB3 RID: 35763
		// (get) Token: 0x0601E3DC RID: 123868 RVA: 0x0043CC14 File Offset: 0x0043AE14
		public bool EnabledShowStructureBlock
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008BB4 RID: 35764
		// (get) Token: 0x0601E3DD RID: 123869 RVA: 0x0043CC54 File Offset: 0x0043AE54
		public bool EnabledShowArrayElementPrefixLine
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17008BB5 RID: 35765
		// (get) Token: 0x0601E3DE RID: 123870 RVA: 0x0043CC94 File Offset: 0x0043AE94
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

		// Token: 0x17008BB6 RID: 35766
		// (get) Token: 0x0601E3DF RID: 123871 RVA: 0x0043CCD8 File Offset: 0x0043AED8
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

		// Token: 0x17008BB7 RID: 35767
		// (get) Token: 0x0601E3E0 RID: 123872 RVA: 0x0043CD1C File Offset: 0x0043AF1C
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

		// Token: 0x17008BB8 RID: 35768
		// (get) Token: 0x0601E3E1 RID: 123873 RVA: 0x0043CD5C File Offset: 0x0043AF5C
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

		// Token: 0x0601E3E2 RID: 123874 RVA: 0x0043CDA0 File Offset: 0x0043AFA0
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

		// Token: 0x0601E3E3 RID: 123875 RVA: 0x0043CDEF File Offset: 0x0043AFEF
		public static void StartIEditorIndentationDisplaySetting(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0601E3E4 RID: 123876 RVA: 0x0043CDF8 File Offset: 0x0043AFF8
		public static void AddEnabledShowStructureIndentLine(FlatBufferBuilder builder, bool enabledShowStructureIndentLine)
		{
			builder.AddBool(0, enabledShowStructureIndentLine, false);
		}

		// Token: 0x0601E3E5 RID: 123877 RVA: 0x0043CE03 File Offset: 0x0043B003
		public static void AddEnabledShowStructureBlock(FlatBufferBuilder builder, bool enabledShowStructureBlock)
		{
			builder.AddBool(1, enabledShowStructureBlock, false);
		}

		// Token: 0x0601E3E6 RID: 123878 RVA: 0x0043CE0E File Offset: 0x0043B00E
		public static void AddEnabledShowArrayElementPrefixLine(FlatBufferBuilder builder, bool enabledShowArrayElementPrefixLine)
		{
			builder.AddBool(2, enabledShowArrayElementPrefixLine, false);
		}

		// Token: 0x0601E3E7 RID: 123879 RVA: 0x0043CE19 File Offset: 0x0043B019
		public static void AddBaseGray(FlatBufferBuilder builder, float baseGray)
		{
			builder.AddFloat(3, baseGray, 0.0);
		}

		// Token: 0x0601E3E8 RID: 123880 RVA: 0x0043CE2C File Offset: 0x0043B02C
		public static void AddMaxGray(FlatBufferBuilder builder, float maxGray)
		{
			builder.AddFloat(4, maxGray, 0.0);
		}

		// Token: 0x0601E3E9 RID: 123881 RVA: 0x0043CE3F File Offset: 0x0043B03F
		public static void AddMaxDepth(FlatBufferBuilder builder, int maxDepth)
		{
			builder.AddInt(5, maxDepth, 0);
		}

		// Token: 0x0601E3EA RID: 123882 RVA: 0x0043CE4A File Offset: 0x0043B04A
		public static void AddSameLevelChangeStrength(FlatBufferBuilder builder, float sameLevelChangeStrength)
		{
			builder.AddFloat(6, sameLevelChangeStrength, 0.0);
		}

		// Token: 0x0601E3EB RID: 123883 RVA: 0x0043CE5D File Offset: 0x0043B05D
		public static Offset<IEditorIndentationDisplaySetting> EndIEditorIndentationDisplaySetting(FlatBufferBuilder builder)
		{
			return new Offset<IEditorIndentationDisplaySetting>(builder.EndTable());
		}

		// Token: 0x0601E3EC RID: 123884 RVA: 0x0043CE6C File Offset: 0x0043B06C
		public IEditorIndentationDisplaySettingT UnPack()
		{
			IEditorIndentationDisplaySettingT editorIndentationDisplaySettingT = new IEditorIndentationDisplaySettingT();
			this.UnPackTo(editorIndentationDisplaySettingT);
			return editorIndentationDisplaySettingT;
		}

		// Token: 0x0601E3ED RID: 123885 RVA: 0x0043CE88 File Offset: 0x0043B088
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

		// Token: 0x0601E3EE RID: 123886 RVA: 0x0043CEEC File Offset: 0x0043B0EC
		public static Offset<IEditorIndentationDisplaySetting> Pack(FlatBufferBuilder builder, IEditorIndentationDisplaySettingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEditorIndentationDisplaySetting>);
			}
			return IEditorIndentationDisplaySetting.CreateIEditorIndentationDisplaySetting(builder, _o.EnabledShowStructureIndentLine, _o.EnabledShowStructureBlock, _o.EnabledShowArrayElementPrefixLine, _o.BaseGray, _o.MaxGray, _o.MaxDepth, _o.SameLevelChangeStrength);
		}

		// Token: 0x0400D802 RID: 55298
		private Table __p;
	}
}

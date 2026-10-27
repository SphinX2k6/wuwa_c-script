using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048C8 RID: 18632
	public struct IWorldEditorTemplateConfig : IFlatbufferObject
	{
		// Token: 0x17008740 RID: 34624
		// (get) Token: 0x0601D210 RID: 119312 RVA: 0x0041CE5D File Offset: 0x0041B05D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D211 RID: 119313 RVA: 0x0041CE6A File Offset: 0x0041B06A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D212 RID: 119314 RVA: 0x0041CE74 File Offset: 0x0041B074
		public static IWorldEditorTemplateConfig GetRootAsIWorldEditorTemplateConfig(ByteBuffer _bb)
		{
			return IWorldEditorTemplateConfig.GetRootAsIWorldEditorTemplateConfig(_bb, default(IWorldEditorTemplateConfig));
		}

		// Token: 0x0601D213 RID: 119315 RVA: 0x0041CE90 File Offset: 0x0041B090
		public static IWorldEditorTemplateConfig GetRootAsIWorldEditorTemplateConfig(ByteBuffer _bb, IWorldEditorTemplateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D214 RID: 119316 RVA: 0x0041CEAD File Offset: 0x0041B0AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D215 RID: 119317 RVA: 0x0041CEBC File Offset: 0x0041B0BC
		public IWorldEditorTemplateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008741 RID: 34625
		// (get) Token: 0x0601D216 RID: 119318 RVA: 0x0041CECC File Offset: 0x0041B0CC
		public string Icon
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

		// Token: 0x0601D217 RID: 119319 RVA: 0x0041CF03 File Offset: 0x0041B103
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601D218 RID: 119320 RVA: 0x0041CF12 File Offset: 0x0041B112
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008742 RID: 34626
		// (get) Token: 0x0601D219 RID: 119321 RVA: 0x0041CF20 File Offset: 0x0041B120
		public EZoomType ZoomType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EZoomType.Default;
				}
				return (EZoomType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008743 RID: 34627
		// (get) Token: 0x0601D21A RID: 119322 RVA: 0x0041CF5C File Offset: 0x0041B15C
		public string MainType
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

		// Token: 0x0601D21B RID: 119323 RVA: 0x0041CF93 File Offset: 0x0041B193
		public Span<byte> GetMainTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601D21C RID: 119324 RVA: 0x0041CFA2 File Offset: 0x0041B1A2
		public byte[] GetMainTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008744 RID: 34628
		// (get) Token: 0x0601D21D RID: 119325 RVA: 0x0041CFB0 File Offset: 0x0041B1B0
		public string SubType
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

		// Token: 0x0601D21E RID: 119326 RVA: 0x0041CFE8 File Offset: 0x0041B1E8
		public Span<byte> GetSubTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601D21F RID: 119327 RVA: 0x0041CFF8 File Offset: 0x0041B1F8
		public byte[] GetSubTypeArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17008745 RID: 34629
		// (get) Token: 0x0601D220 RID: 119328 RVA: 0x0041D008 File Offset: 0x0041B208
		public string Tags
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

		// Token: 0x0601D221 RID: 119329 RVA: 0x0041D040 File Offset: 0x0041B240
		public Span<byte> GetTagsBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601D222 RID: 119330 RVA: 0x0041D050 File Offset: 0x0041B250
		public byte[] GetTagsArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x0601D223 RID: 119331 RVA: 0x0041D05F File Offset: 0x0041B25F
		public static Offset<IWorldEditorTemplateConfig> CreateIWorldEditorTemplateConfig(FlatBufferBuilder builder, StringOffset IconOffset = default(StringOffset), EZoomType ZoomType = EZoomType.Default, StringOffset MainTypeOffset = default(StringOffset), StringOffset SubTypeOffset = default(StringOffset), StringOffset TagsOffset = default(StringOffset))
		{
			builder.StartTable(5);
			IWorldEditorTemplateConfig.AddTags(builder, TagsOffset);
			IWorldEditorTemplateConfig.AddSubType(builder, SubTypeOffset);
			IWorldEditorTemplateConfig.AddMainType(builder, MainTypeOffset);
			IWorldEditorTemplateConfig.AddIcon(builder, IconOffset);
			IWorldEditorTemplateConfig.AddZoomType(builder, ZoomType);
			return IWorldEditorTemplateConfig.EndIWorldEditorTemplateConfig(builder);
		}

		// Token: 0x0601D224 RID: 119332 RVA: 0x0041D093 File Offset: 0x0041B293
		public static void StartIWorldEditorTemplateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601D225 RID: 119333 RVA: 0x0041D09C File Offset: 0x0041B29C
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
			builder.AddOffset(0, iconOffset.Value, 0);
		}

		// Token: 0x0601D226 RID: 119334 RVA: 0x0041D0AC File Offset: 0x0041B2AC
		public static void AddZoomType(FlatBufferBuilder builder, EZoomType zoomType)
		{
			builder.AddByte(1, (byte)zoomType, 0);
		}

		// Token: 0x0601D227 RID: 119335 RVA: 0x0041D0B7 File Offset: 0x0041B2B7
		public static void AddMainType(FlatBufferBuilder builder, StringOffset mainTypeOffset)
		{
			builder.AddOffset(2, mainTypeOffset.Value, 0);
		}

		// Token: 0x0601D228 RID: 119336 RVA: 0x0041D0C7 File Offset: 0x0041B2C7
		public static void AddSubType(FlatBufferBuilder builder, StringOffset subTypeOffset)
		{
			builder.AddOffset(3, subTypeOffset.Value, 0);
		}

		// Token: 0x0601D229 RID: 119337 RVA: 0x0041D0D7 File Offset: 0x0041B2D7
		public static void AddTags(FlatBufferBuilder builder, StringOffset tagsOffset)
		{
			builder.AddOffset(4, tagsOffset.Value, 0);
		}

		// Token: 0x0601D22A RID: 119338 RVA: 0x0041D0E7 File Offset: 0x0041B2E7
		public static Offset<IWorldEditorTemplateConfig> EndIWorldEditorTemplateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWorldEditorTemplateConfig>(builder.EndTable());
		}

		// Token: 0x0601D22B RID: 119339 RVA: 0x0041D0F4 File Offset: 0x0041B2F4
		public IWorldEditorTemplateConfigT UnPack()
		{
			IWorldEditorTemplateConfigT worldEditorTemplateConfigT = new IWorldEditorTemplateConfigT();
			this.UnPackTo(worldEditorTemplateConfigT);
			return worldEditorTemplateConfigT;
		}

		// Token: 0x0601D22C RID: 119340 RVA: 0x0041D10F File Offset: 0x0041B30F
		public void UnPackTo(IWorldEditorTemplateConfigT _o)
		{
			_o.Icon = this.Icon;
			_o.ZoomType = this.ZoomType;
			_o.MainType = this.MainType;
			_o.SubType = this.SubType;
			_o.Tags = this.Tags;
		}

		// Token: 0x0601D22D RID: 119341 RVA: 0x0041D150 File Offset: 0x0041B350
		public static Offset<IWorldEditorTemplateConfig> Pack(FlatBufferBuilder builder, IWorldEditorTemplateConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWorldEditorTemplateConfig>);
			}
			StringOffset iconOffset = (_o.Icon == null) ? default(StringOffset) : builder.CreateString(_o.Icon);
			StringOffset mainTypeOffset = (_o.MainType == null) ? default(StringOffset) : builder.CreateString(_o.MainType);
			StringOffset subTypeOffset = (_o.SubType == null) ? default(StringOffset) : builder.CreateString(_o.SubType);
			StringOffset tagsOffset = (_o.Tags == null) ? default(StringOffset) : builder.CreateString(_o.Tags);
			return IWorldEditorTemplateConfig.CreateIWorldEditorTemplateConfig(builder, iconOffset, _o.ZoomType, mainTypeOffset, subTypeOffset, tagsOffset);
		}

		// Token: 0x0400CECF RID: 52943
		private Table __p;
	}
}

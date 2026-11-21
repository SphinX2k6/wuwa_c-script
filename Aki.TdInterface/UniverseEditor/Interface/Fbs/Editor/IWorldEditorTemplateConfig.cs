using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D2D RID: 19757
	public struct IWorldEditorTemplateConfig : IFlatbufferObject
	{
		// Token: 0x17008D88 RID: 36232
		// (get) Token: 0x0601E9FD RID: 125437 RVA: 0x004495F9 File Offset: 0x004477F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E9FE RID: 125438 RVA: 0x00449606 File Offset: 0x00447806
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E9FF RID: 125439 RVA: 0x00449610 File Offset: 0x00447810
		public static IWorldEditorTemplateConfig GetRootAsIWorldEditorTemplateConfig(ByteBuffer _bb)
		{
			return IWorldEditorTemplateConfig.GetRootAsIWorldEditorTemplateConfig(_bb, default(IWorldEditorTemplateConfig));
		}

		// Token: 0x0601EA00 RID: 125440 RVA: 0x0044962C File Offset: 0x0044782C
		public static IWorldEditorTemplateConfig GetRootAsIWorldEditorTemplateConfig(ByteBuffer _bb, IWorldEditorTemplateConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EA01 RID: 125441 RVA: 0x00449649 File Offset: 0x00447849
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EA02 RID: 125442 RVA: 0x00449658 File Offset: 0x00447858
		public IWorldEditorTemplateConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D89 RID: 36233
		// (get) Token: 0x0601EA03 RID: 125443 RVA: 0x00449668 File Offset: 0x00447868
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

		// Token: 0x0601EA04 RID: 125444 RVA: 0x0044969F File Offset: 0x0044789F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601EA05 RID: 125445 RVA: 0x004496AE File Offset: 0x004478AE
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008D8A RID: 36234
		// (get) Token: 0x0601EA06 RID: 125446 RVA: 0x004496BC File Offset: 0x004478BC
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

		// Token: 0x17008D8B RID: 36235
		// (get) Token: 0x0601EA07 RID: 125447 RVA: 0x004496F8 File Offset: 0x004478F8
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

		// Token: 0x0601EA08 RID: 125448 RVA: 0x0044972F File Offset: 0x0044792F
		public Span<byte> GetMainTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601EA09 RID: 125449 RVA: 0x0044973E File Offset: 0x0044793E
		public byte[] GetMainTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008D8C RID: 36236
		// (get) Token: 0x0601EA0A RID: 125450 RVA: 0x0044974C File Offset: 0x0044794C
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

		// Token: 0x0601EA0B RID: 125451 RVA: 0x00449784 File Offset: 0x00447984
		public Span<byte> GetSubTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601EA0C RID: 125452 RVA: 0x00449794 File Offset: 0x00447994
		public byte[] GetSubTypeArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x17008D8D RID: 36237
		// (get) Token: 0x0601EA0D RID: 125453 RVA: 0x004497A4 File Offset: 0x004479A4
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

		// Token: 0x0601EA0E RID: 125454 RVA: 0x004497DC File Offset: 0x004479DC
		public Span<byte> GetTagsBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0601EA0F RID: 125455 RVA: 0x004497EC File Offset: 0x004479EC
		public byte[] GetTagsArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x0601EA10 RID: 125456 RVA: 0x004497FB File Offset: 0x004479FB
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

		// Token: 0x0601EA11 RID: 125457 RVA: 0x0044982F File Offset: 0x00447A2F
		public static void StartIWorldEditorTemplateConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601EA12 RID: 125458 RVA: 0x00449838 File Offset: 0x00447A38
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
			builder.AddOffset(0, iconOffset.Value, 0);
		}

		// Token: 0x0601EA13 RID: 125459 RVA: 0x00449848 File Offset: 0x00447A48
		public static void AddZoomType(FlatBufferBuilder builder, EZoomType zoomType)
		{
			builder.AddByte(1, (byte)zoomType, 0);
		}

		// Token: 0x0601EA14 RID: 125460 RVA: 0x00449853 File Offset: 0x00447A53
		public static void AddMainType(FlatBufferBuilder builder, StringOffset mainTypeOffset)
		{
			builder.AddOffset(2, mainTypeOffset.Value, 0);
		}

		// Token: 0x0601EA15 RID: 125461 RVA: 0x00449863 File Offset: 0x00447A63
		public static void AddSubType(FlatBufferBuilder builder, StringOffset subTypeOffset)
		{
			builder.AddOffset(3, subTypeOffset.Value, 0);
		}

		// Token: 0x0601EA16 RID: 125462 RVA: 0x00449873 File Offset: 0x00447A73
		public static void AddTags(FlatBufferBuilder builder, StringOffset tagsOffset)
		{
			builder.AddOffset(4, tagsOffset.Value, 0);
		}

		// Token: 0x0601EA17 RID: 125463 RVA: 0x00449883 File Offset: 0x00447A83
		public static Offset<IWorldEditorTemplateConfig> EndIWorldEditorTemplateConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWorldEditorTemplateConfig>(builder.EndTable());
		}

		// Token: 0x0601EA18 RID: 125464 RVA: 0x00449890 File Offset: 0x00447A90
		public IWorldEditorTemplateConfigT UnPack()
		{
			IWorldEditorTemplateConfigT worldEditorTemplateConfigT = new IWorldEditorTemplateConfigT();
			this.UnPackTo(worldEditorTemplateConfigT);
			return worldEditorTemplateConfigT;
		}

		// Token: 0x0601EA19 RID: 125465 RVA: 0x004498AB File Offset: 0x00447AAB
		public void UnPackTo(IWorldEditorTemplateConfigT _o)
		{
			_o.Icon = this.Icon;
			_o.ZoomType = this.ZoomType;
			_o.MainType = this.MainType;
			_o.SubType = this.SubType;
			_o.Tags = this.Tags;
		}

		// Token: 0x0601EA1A RID: 125466 RVA: 0x004498EC File Offset: 0x00447AEC
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

		// Token: 0x0400D908 RID: 55560
		private Table __p;
	}
}

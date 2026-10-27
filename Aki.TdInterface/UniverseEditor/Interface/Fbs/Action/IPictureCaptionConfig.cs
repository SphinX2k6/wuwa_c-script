using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CC9 RID: 27849
	public struct IPictureCaptionConfig : IFlatbufferObject
	{
		// Token: 0x1700CF54 RID: 53076
		// (get) Token: 0x06031149 RID: 201033 RVA: 0x006A9138 File Offset: 0x006A7338
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603114A RID: 201034 RVA: 0x006A9145 File Offset: 0x006A7345
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603114B RID: 201035 RVA: 0x006A914C File Offset: 0x006A734C
		public static IPictureCaptionConfig GetRootAsIPictureCaptionConfig(ByteBuffer _bb)
		{
			return IPictureCaptionConfig.GetRootAsIPictureCaptionConfig(_bb, default(IPictureCaptionConfig));
		}

		// Token: 0x0603114C RID: 201036 RVA: 0x006A9168 File Offset: 0x006A7368
		public static IPictureCaptionConfig GetRootAsIPictureCaptionConfig(ByteBuffer _bb, IPictureCaptionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603114D RID: 201037 RVA: 0x006A9185 File Offset: 0x006A7385
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603114E RID: 201038 RVA: 0x006A9194 File Offset: 0x006A7394
		public IPictureCaptionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF55 RID: 53077
		// (get) Token: 0x0603114F RID: 201039 RVA: 0x006A91A4 File Offset: 0x006A73A4
		public string PictureCaption
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

		// Token: 0x06031150 RID: 201040 RVA: 0x006A91DB File Offset: 0x006A73DB
		public Span<byte> GetPictureCaptionBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06031151 RID: 201041 RVA: 0x006A91EA File Offset: 0x006A73EA
		public byte[] GetPictureCaptionArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700CF56 RID: 53078
		// (get) Token: 0x06031152 RID: 201042 RVA: 0x006A91F8 File Offset: 0x006A73F8
		public string UiPrefabId
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

		// Token: 0x06031153 RID: 201043 RVA: 0x006A922F File Offset: 0x006A742F
		public Span<byte> GetUiPrefabIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06031154 RID: 201044 RVA: 0x006A923E File Offset: 0x006A743E
		public byte[] GetUiPrefabIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700CF57 RID: 53079
		// (get) Token: 0x06031155 RID: 201045 RVA: 0x006A924C File Offset: 0x006A744C
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CF58 RID: 53080
		// (get) Token: 0x06031156 RID: 201046 RVA: 0x006A928C File Offset: 0x006A748C
		public IUiAnimConfig? UiAnimConfig
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IUiAnimConfig?(default(IUiAnimConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06031157 RID: 201047 RVA: 0x006A92EA File Offset: 0x006A74EA
		public static Offset<IPictureCaptionConfig> CreateIPictureCaptionConfig(FlatBufferBuilder builder, StringOffset PictureCaptionOffset = default(StringOffset), StringOffset UiPrefabIdOffset = default(StringOffset), float Duration = 0f, Offset<IUiAnimConfig> UiAnimConfigOffset = default(Offset<IUiAnimConfig>))
		{
			builder.StartTable(4);
			IPictureCaptionConfig.AddUiAnimConfig(builder, UiAnimConfigOffset);
			IPictureCaptionConfig.AddDuration(builder, Duration);
			IPictureCaptionConfig.AddUiPrefabId(builder, UiPrefabIdOffset);
			IPictureCaptionConfig.AddPictureCaption(builder, PictureCaptionOffset);
			return IPictureCaptionConfig.EndIPictureCaptionConfig(builder);
		}

		// Token: 0x06031158 RID: 201048 RVA: 0x006A9316 File Offset: 0x006A7516
		public static void StartIPictureCaptionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06031159 RID: 201049 RVA: 0x006A931F File Offset: 0x006A751F
		public static void AddPictureCaption(FlatBufferBuilder builder, StringOffset pictureCaptionOffset)
		{
			builder.AddOffset(0, pictureCaptionOffset.Value, 0);
		}

		// Token: 0x0603115A RID: 201050 RVA: 0x006A932F File Offset: 0x006A752F
		public static void AddUiPrefabId(FlatBufferBuilder builder, StringOffset uiPrefabIdOffset)
		{
			builder.AddOffset(1, uiPrefabIdOffset.Value, 0);
		}

		// Token: 0x0603115B RID: 201051 RVA: 0x006A933F File Offset: 0x006A753F
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(2, duration, 0.0);
		}

		// Token: 0x0603115C RID: 201052 RVA: 0x006A9352 File Offset: 0x006A7552
		public static void AddUiAnimConfig(FlatBufferBuilder builder, Offset<IUiAnimConfig> uiAnimConfigOffset)
		{
			builder.AddOffset(3, uiAnimConfigOffset.Value, 0);
		}

		// Token: 0x0603115D RID: 201053 RVA: 0x006A9362 File Offset: 0x006A7562
		public static Offset<IPictureCaptionConfig> EndIPictureCaptionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPictureCaptionConfig>(builder.EndTable());
		}

		// Token: 0x0603115E RID: 201054 RVA: 0x006A9370 File Offset: 0x006A7570
		public IPictureCaptionConfigT UnPack()
		{
			IPictureCaptionConfigT pictureCaptionConfigT = new IPictureCaptionConfigT();
			this.UnPackTo(pictureCaptionConfigT);
			return pictureCaptionConfigT;
		}

		// Token: 0x0603115F RID: 201055 RVA: 0x006A938C File Offset: 0x006A758C
		public void UnPackTo(IPictureCaptionConfigT _o)
		{
			_o.PictureCaption = this.PictureCaption;
			_o.UiPrefabId = this.UiPrefabId;
			_o.Duration = this.Duration;
			_o.UiAnimConfig = ((this.UiAnimConfig != null) ? this.UiAnimConfig.Value.UnPack() : null);
		}

		// Token: 0x06031160 RID: 201056 RVA: 0x006A93EC File Offset: 0x006A75EC
		public static Offset<IPictureCaptionConfig> Pack(FlatBufferBuilder builder, IPictureCaptionConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPictureCaptionConfig>);
			}
			StringOffset pictureCaptionOffset = (_o.PictureCaption == null) ? default(StringOffset) : builder.CreateString(_o.PictureCaption);
			StringOffset uiPrefabIdOffset = (_o.UiPrefabId == null) ? default(StringOffset) : builder.CreateString(_o.UiPrefabId);
			Offset<IUiAnimConfig> uiAnimConfigOffset = (_o.UiAnimConfig == null) ? default(Offset<IUiAnimConfig>) : IUiAnimConfig.Pack(builder, _o.UiAnimConfig);
			return IPictureCaptionConfig.CreateIPictureCaptionConfig(builder, pictureCaptionOffset, uiPrefabIdOffset, _o.Duration, uiAnimConfigOffset);
		}

		// Token: 0x0401162E RID: 71214
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200743F RID: 29759
	public struct IPictureCaptionConfig : IFlatbufferObject
	{
		// Token: 0x1700DA91 RID: 55953
		// (get) Token: 0x06034120 RID: 213280 RVA: 0x0070436C File Offset: 0x0070256C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034121 RID: 213281 RVA: 0x00704379 File Offset: 0x00702579
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034122 RID: 213282 RVA: 0x00704380 File Offset: 0x00702580
		public static IPictureCaptionConfig GetRootAsIPictureCaptionConfig(ByteBuffer _bb)
		{
			return IPictureCaptionConfig.GetRootAsIPictureCaptionConfig(_bb, default(IPictureCaptionConfig));
		}

		// Token: 0x06034123 RID: 213283 RVA: 0x0070439C File Offset: 0x0070259C
		public static IPictureCaptionConfig GetRootAsIPictureCaptionConfig(ByteBuffer _bb, IPictureCaptionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034124 RID: 213284 RVA: 0x007043B9 File Offset: 0x007025B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034125 RID: 213285 RVA: 0x007043C8 File Offset: 0x007025C8
		public IPictureCaptionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA92 RID: 55954
		// (get) Token: 0x06034126 RID: 213286 RVA: 0x007043D8 File Offset: 0x007025D8
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

		// Token: 0x06034127 RID: 213287 RVA: 0x0070440F File Offset: 0x0070260F
		public Span<byte> GetPictureCaptionBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06034128 RID: 213288 RVA: 0x0070441E File Offset: 0x0070261E
		public byte[] GetPictureCaptionArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700DA93 RID: 55955
		// (get) Token: 0x06034129 RID: 213289 RVA: 0x0070442C File Offset: 0x0070262C
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

		// Token: 0x0603412A RID: 213290 RVA: 0x00704463 File Offset: 0x00702663
		public Span<byte> GetUiPrefabIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603412B RID: 213291 RVA: 0x00704472 File Offset: 0x00702672
		public byte[] GetUiPrefabIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700DA94 RID: 55956
		// (get) Token: 0x0603412C RID: 213292 RVA: 0x00704480 File Offset: 0x00702680
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

		// Token: 0x1700DA95 RID: 55957
		// (get) Token: 0x0603412D RID: 213293 RVA: 0x007044C0 File Offset: 0x007026C0
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

		// Token: 0x0603412E RID: 213294 RVA: 0x0070451E File Offset: 0x0070271E
		public static Offset<IPictureCaptionConfig> CreateIPictureCaptionConfig(FlatBufferBuilder builder, StringOffset PictureCaptionOffset = default(StringOffset), StringOffset UiPrefabIdOffset = default(StringOffset), float Duration = 0f, Offset<IUiAnimConfig> UiAnimConfigOffset = default(Offset<IUiAnimConfig>))
		{
			builder.StartTable(4);
			IPictureCaptionConfig.AddUiAnimConfig(builder, UiAnimConfigOffset);
			IPictureCaptionConfig.AddDuration(builder, Duration);
			IPictureCaptionConfig.AddUiPrefabId(builder, UiPrefabIdOffset);
			IPictureCaptionConfig.AddPictureCaption(builder, PictureCaptionOffset);
			return IPictureCaptionConfig.EndIPictureCaptionConfig(builder);
		}

		// Token: 0x0603412F RID: 213295 RVA: 0x0070454A File Offset: 0x0070274A
		public static void StartIPictureCaptionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06034130 RID: 213296 RVA: 0x00704553 File Offset: 0x00702753
		public static void AddPictureCaption(FlatBufferBuilder builder, StringOffset pictureCaptionOffset)
		{
			builder.AddOffset(0, pictureCaptionOffset.Value, 0);
		}

		// Token: 0x06034131 RID: 213297 RVA: 0x00704563 File Offset: 0x00702763
		public static void AddUiPrefabId(FlatBufferBuilder builder, StringOffset uiPrefabIdOffset)
		{
			builder.AddOffset(1, uiPrefabIdOffset.Value, 0);
		}

		// Token: 0x06034132 RID: 213298 RVA: 0x00704573 File Offset: 0x00702773
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(2, duration, 0.0);
		}

		// Token: 0x06034133 RID: 213299 RVA: 0x00704586 File Offset: 0x00702786
		public static void AddUiAnimConfig(FlatBufferBuilder builder, Offset<IUiAnimConfig> uiAnimConfigOffset)
		{
			builder.AddOffset(3, uiAnimConfigOffset.Value, 0);
		}

		// Token: 0x06034134 RID: 213300 RVA: 0x00704596 File Offset: 0x00702796
		public static Offset<IPictureCaptionConfig> EndIPictureCaptionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPictureCaptionConfig>(builder.EndTable());
		}

		// Token: 0x06034135 RID: 213301 RVA: 0x007045A4 File Offset: 0x007027A4
		public IPictureCaptionConfigT UnPack()
		{
			IPictureCaptionConfigT pictureCaptionConfigT = new IPictureCaptionConfigT();
			this.UnPackTo(pictureCaptionConfigT);
			return pictureCaptionConfigT;
		}

		// Token: 0x06034136 RID: 213302 RVA: 0x007045C0 File Offset: 0x007027C0
		public void UnPackTo(IPictureCaptionConfigT _o)
		{
			_o.PictureCaption = this.PictureCaption;
			_o.UiPrefabId = this.UiPrefabId;
			_o.Duration = this.Duration;
			_o.UiAnimConfig = ((this.UiAnimConfig != null) ? this.UiAnimConfig.Value.UnPack() : null);
		}

		// Token: 0x06034137 RID: 213303 RVA: 0x00704620 File Offset: 0x00702820
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

		// Token: 0x0401259E RID: 75166
		private Table __p;
	}
}

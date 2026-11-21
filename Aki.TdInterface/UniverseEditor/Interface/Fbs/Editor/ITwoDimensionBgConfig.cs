using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D15 RID: 19733
	public struct ITwoDimensionBgConfig : IFlatbufferObject
	{
		// Token: 0x17008D31 RID: 36145
		// (get) Token: 0x0601E8AD RID: 125101 RVA: 0x00446900 File Offset: 0x00444B00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E8AE RID: 125102 RVA: 0x0044690D File Offset: 0x00444B0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E8AF RID: 125103 RVA: 0x00446914 File Offset: 0x00444B14
		public static ITwoDimensionBgConfig GetRootAsITwoDimensionBgConfig(ByteBuffer _bb)
		{
			return ITwoDimensionBgConfig.GetRootAsITwoDimensionBgConfig(_bb, default(ITwoDimensionBgConfig));
		}

		// Token: 0x0601E8B0 RID: 125104 RVA: 0x00446930 File Offset: 0x00444B30
		public static ITwoDimensionBgConfig GetRootAsITwoDimensionBgConfig(ByteBuffer _bb, ITwoDimensionBgConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E8B1 RID: 125105 RVA: 0x0044694D File Offset: 0x00444B4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E8B2 RID: 125106 RVA: 0x0044695C File Offset: 0x00444B5C
		public ITwoDimensionBgConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D32 RID: 36146
		// (get) Token: 0x0601E8B3 RID: 125107 RVA: 0x0044696C File Offset: 0x00444B6C
		public string BgUrl
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

		// Token: 0x0601E8B4 RID: 125108 RVA: 0x004469A3 File Offset: 0x00444BA3
		public Span<byte> GetBgUrlBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601E8B5 RID: 125109 RVA: 0x004469B2 File Offset: 0x00444BB2
		public byte[] GetBgUrlArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008D33 RID: 36147
		// (get) Token: 0x0601E8B6 RID: 125110 RVA: 0x004469C0 File Offset: 0x00444BC0
		public int Width
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008D34 RID: 36148
		// (get) Token: 0x0601E8B7 RID: 125111 RVA: 0x004469FC File Offset: 0x00444BFC
		public int Height
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008D35 RID: 36149
		// (get) Token: 0x0601E8B8 RID: 125112 RVA: 0x00446A38 File Offset: 0x00444C38
		public float Scale
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

		// Token: 0x0601E8B9 RID: 125113 RVA: 0x00446A79 File Offset: 0x00444C79
		public static Offset<ITwoDimensionBgConfig> CreateITwoDimensionBgConfig(FlatBufferBuilder builder, StringOffset BgUrlOffset = default(StringOffset), int Width = 0, int Height = 0, float Scale = 0f)
		{
			builder.StartTable(4);
			ITwoDimensionBgConfig.AddScale(builder, Scale);
			ITwoDimensionBgConfig.AddHeight(builder, Height);
			ITwoDimensionBgConfig.AddWidth(builder, Width);
			ITwoDimensionBgConfig.AddBgUrl(builder, BgUrlOffset);
			return ITwoDimensionBgConfig.EndITwoDimensionBgConfig(builder);
		}

		// Token: 0x0601E8BA RID: 125114 RVA: 0x00446AA5 File Offset: 0x00444CA5
		public static void StartITwoDimensionBgConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E8BB RID: 125115 RVA: 0x00446AAE File Offset: 0x00444CAE
		public static void AddBgUrl(FlatBufferBuilder builder, StringOffset bgUrlOffset)
		{
			builder.AddOffset(0, bgUrlOffset.Value, 0);
		}

		// Token: 0x0601E8BC RID: 125116 RVA: 0x00446ABE File Offset: 0x00444CBE
		public static void AddWidth(FlatBufferBuilder builder, int width)
		{
			builder.AddInt(1, width, 0);
		}

		// Token: 0x0601E8BD RID: 125117 RVA: 0x00446AC9 File Offset: 0x00444CC9
		public static void AddHeight(FlatBufferBuilder builder, int height)
		{
			builder.AddInt(2, height, 0);
		}

		// Token: 0x0601E8BE RID: 125118 RVA: 0x00446AD4 File Offset: 0x00444CD4
		public static void AddScale(FlatBufferBuilder builder, float scale)
		{
			builder.AddFloat(3, scale, 0.0);
		}

		// Token: 0x0601E8BF RID: 125119 RVA: 0x00446AE7 File Offset: 0x00444CE7
		public static Offset<ITwoDimensionBgConfig> EndITwoDimensionBgConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITwoDimensionBgConfig>(builder.EndTable());
		}

		// Token: 0x0601E8C0 RID: 125120 RVA: 0x00446AF4 File Offset: 0x00444CF4
		public ITwoDimensionBgConfigT UnPack()
		{
			ITwoDimensionBgConfigT twoDimensionBgConfigT = new ITwoDimensionBgConfigT();
			this.UnPackTo(twoDimensionBgConfigT);
			return twoDimensionBgConfigT;
		}

		// Token: 0x0601E8C1 RID: 125121 RVA: 0x00446B0F File Offset: 0x00444D0F
		public void UnPackTo(ITwoDimensionBgConfigT _o)
		{
			_o.BgUrl = this.BgUrl;
			_o.Width = this.Width;
			_o.Height = this.Height;
			_o.Scale = this.Scale;
		}

		// Token: 0x0601E8C2 RID: 125122 RVA: 0x00446B44 File Offset: 0x00444D44
		public static Offset<ITwoDimensionBgConfig> Pack(FlatBufferBuilder builder, ITwoDimensionBgConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITwoDimensionBgConfig>);
			}
			StringOffset bgUrlOffset = (_o.BgUrl == null) ? default(StringOffset) : builder.CreateString(_o.BgUrl);
			return ITwoDimensionBgConfig.CreateITwoDimensionBgConfig(builder, bgUrlOffset, _o.Width, _o.Height, _o.Scale);
		}

		// Token: 0x0400D8D9 RID: 55513
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048B0 RID: 18608
	public struct ITwoDimensionBgConfig : IFlatbufferObject
	{
		// Token: 0x170086E9 RID: 34537
		// (get) Token: 0x0601D0C0 RID: 118976 RVA: 0x0041A164 File Offset: 0x00418364
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D0C1 RID: 118977 RVA: 0x0041A171 File Offset: 0x00418371
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D0C2 RID: 118978 RVA: 0x0041A178 File Offset: 0x00418378
		public static ITwoDimensionBgConfig GetRootAsITwoDimensionBgConfig(ByteBuffer _bb)
		{
			return ITwoDimensionBgConfig.GetRootAsITwoDimensionBgConfig(_bb, default(ITwoDimensionBgConfig));
		}

		// Token: 0x0601D0C3 RID: 118979 RVA: 0x0041A194 File Offset: 0x00418394
		public static ITwoDimensionBgConfig GetRootAsITwoDimensionBgConfig(ByteBuffer _bb, ITwoDimensionBgConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D0C4 RID: 118980 RVA: 0x0041A1B1 File Offset: 0x004183B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D0C5 RID: 118981 RVA: 0x0041A1C0 File Offset: 0x004183C0
		public ITwoDimensionBgConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086EA RID: 34538
		// (get) Token: 0x0601D0C6 RID: 118982 RVA: 0x0041A1D0 File Offset: 0x004183D0
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

		// Token: 0x0601D0C7 RID: 118983 RVA: 0x0041A207 File Offset: 0x00418407
		public Span<byte> GetBgUrlBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601D0C8 RID: 118984 RVA: 0x0041A216 File Offset: 0x00418416
		public byte[] GetBgUrlArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170086EB RID: 34539
		// (get) Token: 0x0601D0C9 RID: 118985 RVA: 0x0041A224 File Offset: 0x00418424
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

		// Token: 0x170086EC RID: 34540
		// (get) Token: 0x0601D0CA RID: 118986 RVA: 0x0041A260 File Offset: 0x00418460
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

		// Token: 0x170086ED RID: 34541
		// (get) Token: 0x0601D0CB RID: 118987 RVA: 0x0041A29C File Offset: 0x0041849C
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

		// Token: 0x0601D0CC RID: 118988 RVA: 0x0041A2DD File Offset: 0x004184DD
		public static Offset<ITwoDimensionBgConfig> CreateITwoDimensionBgConfig(FlatBufferBuilder builder, StringOffset BgUrlOffset = default(StringOffset), int Width = 0, int Height = 0, float Scale = 0f)
		{
			builder.StartTable(4);
			ITwoDimensionBgConfig.AddScale(builder, Scale);
			ITwoDimensionBgConfig.AddHeight(builder, Height);
			ITwoDimensionBgConfig.AddWidth(builder, Width);
			ITwoDimensionBgConfig.AddBgUrl(builder, BgUrlOffset);
			return ITwoDimensionBgConfig.EndITwoDimensionBgConfig(builder);
		}

		// Token: 0x0601D0CD RID: 118989 RVA: 0x0041A309 File Offset: 0x00418509
		public static void StartITwoDimensionBgConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601D0CE RID: 118990 RVA: 0x0041A312 File Offset: 0x00418512
		public static void AddBgUrl(FlatBufferBuilder builder, StringOffset bgUrlOffset)
		{
			builder.AddOffset(0, bgUrlOffset.Value, 0);
		}

		// Token: 0x0601D0CF RID: 118991 RVA: 0x0041A322 File Offset: 0x00418522
		public static void AddWidth(FlatBufferBuilder builder, int width)
		{
			builder.AddInt(1, width, 0);
		}

		// Token: 0x0601D0D0 RID: 118992 RVA: 0x0041A32D File Offset: 0x0041852D
		public static void AddHeight(FlatBufferBuilder builder, int height)
		{
			builder.AddInt(2, height, 0);
		}

		// Token: 0x0601D0D1 RID: 118993 RVA: 0x0041A338 File Offset: 0x00418538
		public static void AddScale(FlatBufferBuilder builder, float scale)
		{
			builder.AddFloat(3, scale, 0.0);
		}

		// Token: 0x0601D0D2 RID: 118994 RVA: 0x0041A34B File Offset: 0x0041854B
		public static Offset<ITwoDimensionBgConfig> EndITwoDimensionBgConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITwoDimensionBgConfig>(builder.EndTable());
		}

		// Token: 0x0601D0D3 RID: 118995 RVA: 0x0041A358 File Offset: 0x00418558
		public ITwoDimensionBgConfigT UnPack()
		{
			ITwoDimensionBgConfigT twoDimensionBgConfigT = new ITwoDimensionBgConfigT();
			this.UnPackTo(twoDimensionBgConfigT);
			return twoDimensionBgConfigT;
		}

		// Token: 0x0601D0D4 RID: 118996 RVA: 0x0041A373 File Offset: 0x00418573
		public void UnPackTo(ITwoDimensionBgConfigT _o)
		{
			_o.BgUrl = this.BgUrl;
			_o.Width = this.Width;
			_o.Height = this.Height;
			_o.Scale = this.Scale;
		}

		// Token: 0x0601D0D5 RID: 118997 RVA: 0x0041A3A8 File Offset: 0x004185A8
		public static Offset<ITwoDimensionBgConfig> Pack(FlatBufferBuilder builder, ITwoDimensionBgConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITwoDimensionBgConfig>);
			}
			StringOffset bgUrlOffset = (_o.BgUrl == null) ? default(StringOffset) : builder.CreateString(_o.BgUrl);
			return ITwoDimensionBgConfig.CreateITwoDimensionBgConfig(builder, bgUrlOffset, _o.Width, _o.Height, _o.Scale);
		}

		// Token: 0x0400CEA0 RID: 52896
		private Table __p;
	}
}

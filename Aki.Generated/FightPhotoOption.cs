using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C6A RID: 3178
	public struct FightPhotoOption : IFlatbufferObject
	{
		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x06006DE7 RID: 28135 RVA: 0x0022DCAC File Offset: 0x0022BEAC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006DE8 RID: 28136 RVA: 0x0022DCB9 File Offset: 0x0022BEB9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006DE9 RID: 28137 RVA: 0x0022DCC0 File Offset: 0x0022BEC0
		public static FightPhotoOption GetRootAsFightPhotoOption(ByteBuffer _bb)
		{
			return FightPhotoOption.GetRootAsFightPhotoOption(_bb, default(FightPhotoOption));
		}

		// Token: 0x06006DEA RID: 28138 RVA: 0x0022DCDC File Offset: 0x0022BEDC
		public static FightPhotoOption GetRootAsFightPhotoOption(ByteBuffer _bb, FightPhotoOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006DEB RID: 28139 RVA: 0x0022DCF9 File Offset: 0x0022BEF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006DEC RID: 28140 RVA: 0x0022DD08 File Offset: 0x0022BF08
		public FightPhotoOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x06006DED RID: 28141 RVA: 0x0022DD18 File Offset: 0x0022BF18
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x06006DEE RID: 28142 RVA: 0x0022DD54 File Offset: 0x0022BF54
		public string Name
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

		// Token: 0x06006DEF RID: 28143 RVA: 0x0022DD8B File Offset: 0x0022BF8B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006DF0 RID: 28144 RVA: 0x0022DD9A File Offset: 0x0022BF9A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x06006DF1 RID: 28145 RVA: 0x0022DDB4 File Offset: 0x0022BFB4
		public string Picture
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

		// Token: 0x06006DF2 RID: 28146 RVA: 0x0022DDEB File Offset: 0x0022BFEB
		public Span<byte> GetPictureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006DF3 RID: 28147 RVA: 0x0022DDFA File Offset: 0x0022BFFA
		public byte[] GetPictureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x06006DF4 RID: 28148 RVA: 0x0022DE14 File Offset: 0x0022C014
		public int FilterIndex
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x06006DF5 RID: 28149 RVA: 0x0022DE54 File Offset: 0x0022C054
		public float FilterParamX
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0.5f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x06006DF6 RID: 28150 RVA: 0x0022DE98 File Offset: 0x0022C098
		public float FilterParamY
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0.5f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x06006DF7 RID: 28151 RVA: 0x0022DEDC File Offset: 0x0022C0DC
		public float FilterIntensity
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x06006DF8 RID: 28152 RVA: 0x0022DF20 File Offset: 0x0022C120
		public int DtTableId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004CB5 RID: 19637
		private Table __p;
	}
}

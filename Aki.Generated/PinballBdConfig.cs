using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F22 RID: 3874
	public struct PinballBdConfig : IFlatbufferObject
	{
		// Token: 0x170028F5 RID: 10485
		// (get) Token: 0x0600AE0E RID: 44558 RVA: 0x002BFD09 File Offset: 0x002BDF09
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AE0F RID: 44559 RVA: 0x002BFD16 File Offset: 0x002BDF16
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AE10 RID: 44560 RVA: 0x002BFD20 File Offset: 0x002BDF20
		public static PinballBdConfig GetRootAsPinballBdConfig(ByteBuffer _bb)
		{
			return PinballBdConfig.GetRootAsPinballBdConfig(_bb, default(PinballBdConfig));
		}

		// Token: 0x0600AE11 RID: 44561 RVA: 0x002BFD3C File Offset: 0x002BDF3C
		public static PinballBdConfig GetRootAsPinballBdConfig(ByteBuffer _bb, PinballBdConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AE12 RID: 44562 RVA: 0x002BFD59 File Offset: 0x002BDF59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AE13 RID: 44563 RVA: 0x002BFD68 File Offset: 0x002BDF68
		public PinballBdConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170028F6 RID: 10486
		// (get) Token: 0x0600AE14 RID: 44564 RVA: 0x002BFD78 File Offset: 0x002BDF78
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

		// Token: 0x170028F7 RID: 10487
		// (get) Token: 0x0600AE15 RID: 44565 RVA: 0x002BFDB4 File Offset: 0x002BDFB4
		public string BdName
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

		// Token: 0x0600AE16 RID: 44566 RVA: 0x002BFDEB File Offset: 0x002BDFEB
		public Span<byte> GetBdNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AE17 RID: 44567 RVA: 0x002BFDFA File Offset: 0x002BDFFA
		public byte[] GetBdNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170028F8 RID: 10488
		// (get) Token: 0x0600AE18 RID: 44568 RVA: 0x002BFE14 File Offset: 0x002BE014
		public string Icon
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

		// Token: 0x0600AE19 RID: 44569 RVA: 0x002BFE4B File Offset: 0x002BE04B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AE1A RID: 44570 RVA: 0x002BFE5A File Offset: 0x002BE05A
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170028F9 RID: 10489
		// (get) Token: 0x0600AE1B RID: 44571 RVA: 0x002BFE74 File Offset: 0x002BE074
		public string MiddleIcon
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

		// Token: 0x0600AE1C RID: 44572 RVA: 0x002BFEAC File Offset: 0x002BE0AC
		public Span<byte> GetMiddleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AE1D RID: 44573 RVA: 0x002BFEBC File Offset: 0x002BE0BC
		public byte[] GetMiddleIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170028FA RID: 10490
		// (get) Token: 0x0600AE1E RID: 44574 RVA: 0x002BFED4 File Offset: 0x002BE0D4
		public string BigIcon
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

		// Token: 0x0600AE1F RID: 44575 RVA: 0x002BFF0C File Offset: 0x002BE10C
		public Span<byte> GetBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600AE20 RID: 44576 RVA: 0x002BFF1C File Offset: 0x002BE11C
		public byte[] GetBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170028FB RID: 10491
		// (get) Token: 0x0600AE21 RID: 44577 RVA: 0x002BFF34 File Offset: 0x002BE134
		public string BgColor
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AE22 RID: 44578 RVA: 0x002BFF6C File Offset: 0x002BE16C
		public Span<byte> GetBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600AE23 RID: 44579 RVA: 0x002BFF7C File Offset: 0x002BE17C
		public byte[] GetBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004FEB RID: 20459
		private Table __p;
	}
}

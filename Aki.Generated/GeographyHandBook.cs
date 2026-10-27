using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CF5 RID: 3317
	public struct GeographyHandBook : IFlatbufferObject
	{
		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x060079FB RID: 31227 RVA: 0x0024A1B5 File Offset: 0x002483B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060079FC RID: 31228 RVA: 0x0024A1C2 File Offset: 0x002483C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060079FD RID: 31229 RVA: 0x0024A1CC File Offset: 0x002483CC
		public static GeographyHandBook GetRootAsGeographyHandBook(ByteBuffer _bb)
		{
			return GeographyHandBook.GetRootAsGeographyHandBook(_bb, default(GeographyHandBook));
		}

		// Token: 0x060079FE RID: 31230 RVA: 0x0024A1E8 File Offset: 0x002483E8
		public static GeographyHandBook GetRootAsGeographyHandBook(ByteBuffer _bb, GeographyHandBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060079FF RID: 31231 RVA: 0x0024A205 File Offset: 0x00248405
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007A00 RID: 31232 RVA: 0x0024A214 File Offset: 0x00248414
		public GeographyHandBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x06007A01 RID: 31233 RVA: 0x0024A224 File Offset: 0x00248424
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

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x06007A02 RID: 31234 RVA: 0x0024A260 File Offset: 0x00248460
		public int GeographyTabType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x06007A03 RID: 31235 RVA: 0x0024A29C File Offset: 0x0024849C
		public int Type
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

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x06007A04 RID: 31236 RVA: 0x0024A2D8 File Offset: 0x002484D8
		public string Name
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

		// Token: 0x06007A05 RID: 31237 RVA: 0x0024A310 File Offset: 0x00248510
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007A06 RID: 31238 RVA: 0x0024A320 File Offset: 0x00248520
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x06007A07 RID: 31239 RVA: 0x0024A338 File Offset: 0x00248538
		public string Texture
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

		// Token: 0x06007A08 RID: 31240 RVA: 0x0024A370 File Offset: 0x00248570
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007A09 RID: 31241 RVA: 0x0024A380 File Offset: 0x00248580
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x06007A0A RID: 31242 RVA: 0x0024A398 File Offset: 0x00248598
		public string TypeDescrtption
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

		// Token: 0x06007A0B RID: 31243 RVA: 0x0024A3D0 File Offset: 0x002485D0
		public Span<byte> GetTypeDescrtptionBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007A0C RID: 31244 RVA: 0x0024A3E0 File Offset: 0x002485E0
		public byte[] GetTypeDescrtptionArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x06007A0D RID: 31245 RVA: 0x0024A3F8 File Offset: 0x002485F8
		public string Descrtption
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007A0E RID: 31246 RVA: 0x0024A430 File Offset: 0x00248630
		public Span<byte> GetDescrtptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007A0F RID: 31247 RVA: 0x0024A440 File Offset: 0x00248640
		public byte[] GetDescrtptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D68 RID: 19816
		private Table __p;
	}
}

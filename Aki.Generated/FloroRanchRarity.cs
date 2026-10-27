using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CAD RID: 3245
	public struct FloroRanchRarity : IFlatbufferObject
	{
		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x06007395 RID: 29589 RVA: 0x0023B9A4 File Offset: 0x00239BA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007396 RID: 29590 RVA: 0x0023B9B1 File Offset: 0x00239BB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007397 RID: 29591 RVA: 0x0023B9B8 File Offset: 0x00239BB8
		public static FloroRanchRarity GetRootAsFloroRanchRarity(ByteBuffer _bb)
		{
			return FloroRanchRarity.GetRootAsFloroRanchRarity(_bb, default(FloroRanchRarity));
		}

		// Token: 0x06007398 RID: 29592 RVA: 0x0023B9D4 File Offset: 0x00239BD4
		public static FloroRanchRarity GetRootAsFloroRanchRarity(ByteBuffer _bb, FloroRanchRarity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007399 RID: 29593 RVA: 0x0023B9F1 File Offset: 0x00239BF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600739A RID: 29594 RVA: 0x0023BA00 File Offset: 0x00239C00
		public FloroRanchRarity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x0600739B RID: 29595 RVA: 0x0023BA10 File Offset: 0x00239C10
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

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x0600739C RID: 29596 RVA: 0x0023BA4C File Offset: 0x00239C4C
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

		// Token: 0x0600739D RID: 29597 RVA: 0x0023BA83 File Offset: 0x00239C83
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600739E RID: 29598 RVA: 0x0023BA92 File Offset: 0x00239C92
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x0600739F RID: 29599 RVA: 0x0023BAAC File Offset: 0x00239CAC
		public string Color
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

		// Token: 0x060073A0 RID: 29600 RVA: 0x0023BAE3 File Offset: 0x00239CE3
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060073A1 RID: 29601 RVA: 0x0023BAF2 File Offset: 0x00239CF2
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x060073A2 RID: 29602 RVA: 0x0023BB0C File Offset: 0x00239D0C
		public string DetailCardBigBg
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

		// Token: 0x060073A3 RID: 29603 RVA: 0x0023BB44 File Offset: 0x00239D44
		public Span<byte> GetDetailCardBigBgBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060073A4 RID: 29604 RVA: 0x0023BB54 File Offset: 0x00239D54
		public byte[] GetDetailCardBigBgArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x060073A5 RID: 29605 RVA: 0x0023BB6C File Offset: 0x00239D6C
		public string DetailCardSmallBg
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

		// Token: 0x060073A6 RID: 29606 RVA: 0x0023BBA4 File Offset: 0x00239DA4
		public Span<byte> GetDetailCardSmallBgBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060073A7 RID: 29607 RVA: 0x0023BBB4 File Offset: 0x00239DB4
		public byte[] GetDetailCardSmallBgArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x060073A8 RID: 29608 RVA: 0x0023BBCC File Offset: 0x00239DCC
		public string SmallCardBg
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

		// Token: 0x060073A9 RID: 29609 RVA: 0x0023BC04 File Offset: 0x00239E04
		public Span<byte> GetSmallCardBgBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060073AA RID: 29610 RVA: 0x0023BC14 File Offset: 0x00239E14
		public byte[] GetSmallCardBgArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x060073AB RID: 29611 RVA: 0x0023BC2C File Offset: 0x00239E2C
		public string ShopCardBg
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

		// Token: 0x060073AC RID: 29612 RVA: 0x0023BC64 File Offset: 0x00239E64
		public Span<byte> GetShopCardBgBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060073AD RID: 29613 RVA: 0x0023BC74 File Offset: 0x00239E74
		public byte[] GetShopCardBgArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x060073AE RID: 29614 RVA: 0x0023BC8C File Offset: 0x00239E8C
		public string SelectTexture
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060073AF RID: 29615 RVA: 0x0023BCC4 File Offset: 0x00239EC4
		public Span<byte> GetSelectTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060073B0 RID: 29616 RVA: 0x0023BCD4 File Offset: 0x00239ED4
		public byte[] GetSelectTextureArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D11 RID: 19729
		private Table __p;
	}
}

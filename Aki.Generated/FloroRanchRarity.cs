using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D91 RID: 3473
	public struct FloroRanchRarity : IFlatbufferObject
	{
		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x060079A0 RID: 31136 RVA: 0x0025A820 File Offset: 0x00258A20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060079A1 RID: 31137 RVA: 0x0025A82D File Offset: 0x00258A2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060079A2 RID: 31138 RVA: 0x0025A834 File Offset: 0x00258A34
		public static FloroRanchRarity GetRootAsFloroRanchRarity(ByteBuffer _bb)
		{
			return FloroRanchRarity.GetRootAsFloroRanchRarity(_bb, default(FloroRanchRarity));
		}

		// Token: 0x060079A3 RID: 31139 RVA: 0x0025A850 File Offset: 0x00258A50
		public static FloroRanchRarity GetRootAsFloroRanchRarity(ByteBuffer _bb, FloroRanchRarity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060079A4 RID: 31140 RVA: 0x0025A86D File Offset: 0x00258A6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060079A5 RID: 31141 RVA: 0x0025A87C File Offset: 0x00258A7C
		public FloroRanchRarity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x060079A6 RID: 31142 RVA: 0x0025A88C File Offset: 0x00258A8C
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

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x060079A7 RID: 31143 RVA: 0x0025A8C8 File Offset: 0x00258AC8
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

		// Token: 0x060079A8 RID: 31144 RVA: 0x0025A8FF File Offset: 0x00258AFF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060079A9 RID: 31145 RVA: 0x0025A90E File Offset: 0x00258B0E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x060079AA RID: 31146 RVA: 0x0025A928 File Offset: 0x00258B28
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

		// Token: 0x060079AB RID: 31147 RVA: 0x0025A95F File Offset: 0x00258B5F
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060079AC RID: 31148 RVA: 0x0025A96E File Offset: 0x00258B6E
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x060079AD RID: 31149 RVA: 0x0025A988 File Offset: 0x00258B88
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

		// Token: 0x060079AE RID: 31150 RVA: 0x0025A9C0 File Offset: 0x00258BC0
		public Span<byte> GetDetailCardBigBgBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060079AF RID: 31151 RVA: 0x0025A9D0 File Offset: 0x00258BD0
		public byte[] GetDetailCardBigBgArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x060079B0 RID: 31152 RVA: 0x0025A9E8 File Offset: 0x00258BE8
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

		// Token: 0x060079B1 RID: 31153 RVA: 0x0025AA20 File Offset: 0x00258C20
		public Span<byte> GetDetailCardSmallBgBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060079B2 RID: 31154 RVA: 0x0025AA30 File Offset: 0x00258C30
		public byte[] GetDetailCardSmallBgArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x060079B3 RID: 31155 RVA: 0x0025AA48 File Offset: 0x00258C48
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

		// Token: 0x060079B4 RID: 31156 RVA: 0x0025AA80 File Offset: 0x00258C80
		public Span<byte> GetSmallCardBgBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060079B5 RID: 31157 RVA: 0x0025AA90 File Offset: 0x00258C90
		public byte[] GetSmallCardBgArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x060079B6 RID: 31158 RVA: 0x0025AAA8 File Offset: 0x00258CA8
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

		// Token: 0x060079B7 RID: 31159 RVA: 0x0025AAE0 File Offset: 0x00258CE0
		public Span<byte> GetShopCardBgBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060079B8 RID: 31160 RVA: 0x0025AAF0 File Offset: 0x00258CF0
		public byte[] GetShopCardBgArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x060079B9 RID: 31161 RVA: 0x0025AB08 File Offset: 0x00258D08
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

		// Token: 0x060079BA RID: 31162 RVA: 0x0025AB40 File Offset: 0x00258D40
		public Span<byte> GetSelectTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060079BB RID: 31163 RVA: 0x0025AB50 File Offset: 0x00258D50
		public byte[] GetSelectTextureArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x040052F5 RID: 21237
		private Table __p;
	}
}

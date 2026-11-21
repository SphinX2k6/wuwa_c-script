using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F98 RID: 3992
	public struct PayShopRecommend : IFlatbufferObject
	{
		// Token: 0x17002525 RID: 9509
		// (get) Token: 0x0600A945 RID: 43333 RVA: 0x002C3EC0 File Offset: 0x002C20C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A946 RID: 43334 RVA: 0x002C3ECD File Offset: 0x002C20CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A947 RID: 43335 RVA: 0x002C3ED4 File Offset: 0x002C20D4
		public static PayShopRecommend GetRootAsPayShopRecommend(ByteBuffer _bb)
		{
			return PayShopRecommend.GetRootAsPayShopRecommend(_bb, default(PayShopRecommend));
		}

		// Token: 0x0600A948 RID: 43336 RVA: 0x002C3EF0 File Offset: 0x002C20F0
		public static PayShopRecommend GetRootAsPayShopRecommend(ByteBuffer _bb, PayShopRecommend obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A949 RID: 43337 RVA: 0x002C3F0D File Offset: 0x002C210D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A94A RID: 43338 RVA: 0x002C3F1C File Offset: 0x002C211C
		public PayShopRecommend __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002526 RID: 9510
		// (get) Token: 0x0600A94B RID: 43339 RVA: 0x002C3F2C File Offset: 0x002C212C
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

		// Token: 0x17002527 RID: 9511
		// (get) Token: 0x0600A94C RID: 43340 RVA: 0x002C3F68 File Offset: 0x002C2168
		public int RecommendType
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

		// Token: 0x17002528 RID: 9512
		// (get) Token: 0x0600A94D RID: 43341 RVA: 0x002C3FA4 File Offset: 0x002C21A4
		public int RecommendId
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

		// Token: 0x17002529 RID: 9513
		// (get) Token: 0x0600A94E RID: 43342 RVA: 0x002C3FE0 File Offset: 0x002C21E0
		public string RecommendTexture
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

		// Token: 0x0600A94F RID: 43343 RVA: 0x002C4018 File Offset: 0x002C2218
		public Span<byte> GetRecommendTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A950 RID: 43344 RVA: 0x002C4028 File Offset: 0x002C2228
		public byte[] GetRecommendTextureArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700252A RID: 9514
		// (get) Token: 0x0600A951 RID: 43345 RVA: 0x002C4040 File Offset: 0x002C2240
		public string TabName
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

		// Token: 0x0600A952 RID: 43346 RVA: 0x002C4078 File Offset: 0x002C2278
		public Span<byte> GetTabNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A953 RID: 43347 RVA: 0x002C4088 File Offset: 0x002C2288
		public byte[] GetTabNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700252B RID: 9515
		// (get) Token: 0x0600A954 RID: 43348 RVA: 0x002C40A0 File Offset: 0x002C22A0
		public string PrefabPath
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

		// Token: 0x0600A955 RID: 43349 RVA: 0x002C40D8 File Offset: 0x002C22D8
		public Span<byte> GetPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A956 RID: 43350 RVA: 0x002C40E8 File Offset: 0x002C22E8
		public byte[] GetPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700252C RID: 9516
		// (get) Token: 0x0600A957 RID: 43351 RVA: 0x002C4100 File Offset: 0x002C2300
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700252D RID: 9517
		// (get) Token: 0x0600A958 RID: 43352 RVA: 0x002C4140 File Offset: 0x002C2340
		public bool Show
		{
			get
			{
				int num = this.__p.__offset(18);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400554E RID: 21838
		private Table __p;
	}
}

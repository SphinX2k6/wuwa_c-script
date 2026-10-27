using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EB3 RID: 3763
	public struct PayShopRecommend : IFlatbufferObject
	{
		// Token: 0x170024C0 RID: 9408
		// (get) Token: 0x0600A325 RID: 41765 RVA: 0x002A6B64 File Offset: 0x002A4D64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A326 RID: 41766 RVA: 0x002A6B71 File Offset: 0x002A4D71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A327 RID: 41767 RVA: 0x002A6B78 File Offset: 0x002A4D78
		public static PayShopRecommend GetRootAsPayShopRecommend(ByteBuffer _bb)
		{
			return PayShopRecommend.GetRootAsPayShopRecommend(_bb, default(PayShopRecommend));
		}

		// Token: 0x0600A328 RID: 41768 RVA: 0x002A6B94 File Offset: 0x002A4D94
		public static PayShopRecommend GetRootAsPayShopRecommend(ByteBuffer _bb, PayShopRecommend obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A329 RID: 41769 RVA: 0x002A6BB1 File Offset: 0x002A4DB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A32A RID: 41770 RVA: 0x002A6BC0 File Offset: 0x002A4DC0
		public PayShopRecommend __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170024C1 RID: 9409
		// (get) Token: 0x0600A32B RID: 41771 RVA: 0x002A6BD0 File Offset: 0x002A4DD0
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

		// Token: 0x170024C2 RID: 9410
		// (get) Token: 0x0600A32C RID: 41772 RVA: 0x002A6C0C File Offset: 0x002A4E0C
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

		// Token: 0x170024C3 RID: 9411
		// (get) Token: 0x0600A32D RID: 41773 RVA: 0x002A6C48 File Offset: 0x002A4E48
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

		// Token: 0x170024C4 RID: 9412
		// (get) Token: 0x0600A32E RID: 41774 RVA: 0x002A6C84 File Offset: 0x002A4E84
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

		// Token: 0x0600A32F RID: 41775 RVA: 0x002A6CBC File Offset: 0x002A4EBC
		public Span<byte> GetRecommendTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A330 RID: 41776 RVA: 0x002A6CCC File Offset: 0x002A4ECC
		public byte[] GetRecommendTextureArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170024C5 RID: 9413
		// (get) Token: 0x0600A331 RID: 41777 RVA: 0x002A6CE4 File Offset: 0x002A4EE4
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

		// Token: 0x0600A332 RID: 41778 RVA: 0x002A6D1C File Offset: 0x002A4F1C
		public Span<byte> GetTabNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A333 RID: 41779 RVA: 0x002A6D2C File Offset: 0x002A4F2C
		public byte[] GetTabNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170024C6 RID: 9414
		// (get) Token: 0x0600A334 RID: 41780 RVA: 0x002A6D44 File Offset: 0x002A4F44
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

		// Token: 0x0600A335 RID: 41781 RVA: 0x002A6D7C File Offset: 0x002A4F7C
		public Span<byte> GetPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A336 RID: 41782 RVA: 0x002A6D8C File Offset: 0x002A4F8C
		public byte[] GetPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170024C7 RID: 9415
		// (get) Token: 0x0600A337 RID: 41783 RVA: 0x002A6DA4 File Offset: 0x002A4FA4
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

		// Token: 0x170024C8 RID: 9416
		// (get) Token: 0x0600A338 RID: 41784 RVA: 0x002A6DE4 File Offset: 0x002A4FE4
		public bool Show
		{
			get
			{
				int num = this.__p.__offset(18);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004F69 RID: 20329
		private Table __p;
	}
}

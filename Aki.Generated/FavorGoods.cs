using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D43 RID: 3395
	public struct FavorGoods : IFlatbufferObject
	{
		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x060072CE RID: 29390 RVA: 0x0024A849 File Offset: 0x00248A49
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060072CF RID: 29391 RVA: 0x0024A856 File Offset: 0x00248A56
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060072D0 RID: 29392 RVA: 0x0024A860 File Offset: 0x00248A60
		public static FavorGoods GetRootAsFavorGoods(ByteBuffer _bb)
		{
			return FavorGoods.GetRootAsFavorGoods(_bb, default(FavorGoods));
		}

		// Token: 0x060072D1 RID: 29393 RVA: 0x0024A87C File Offset: 0x00248A7C
		public static FavorGoods GetRootAsFavorGoods(ByteBuffer _bb, FavorGoods obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060072D2 RID: 29394 RVA: 0x0024A899 File Offset: 0x00248A99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060072D3 RID: 29395 RVA: 0x0024A8A8 File Offset: 0x00248AA8
		public FavorGoods __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x060072D4 RID: 29396 RVA: 0x0024A8B8 File Offset: 0x00248AB8
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

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x060072D5 RID: 29397 RVA: 0x0024A8F4 File Offset: 0x00248AF4
		public int RoleId
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

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x060072D6 RID: 29398 RVA: 0x0024A930 File Offset: 0x00248B30
		public int Sort
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

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x060072D7 RID: 29399 RVA: 0x0024A96C File Offset: 0x00248B6C
		public string Title
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

		// Token: 0x060072D8 RID: 29400 RVA: 0x0024A9A4 File Offset: 0x00248BA4
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060072D9 RID: 29401 RVA: 0x0024A9B4 File Offset: 0x00248BB4
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x060072DA RID: 29402 RVA: 0x0024A9CC File Offset: 0x00248BCC
		public string Content
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

		// Token: 0x060072DB RID: 29403 RVA: 0x0024AA04 File Offset: 0x00248C04
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060072DC RID: 29404 RVA: 0x0024AA14 File Offset: 0x00248C14
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x060072DD RID: 29405 RVA: 0x0024AA2C File Offset: 0x00248C2C
		public string Pic
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

		// Token: 0x060072DE RID: 29406 RVA: 0x0024AA64 File Offset: 0x00248C64
		public Span<byte> GetPicBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060072DF RID: 29407 RVA: 0x0024AA74 File Offset: 0x00248C74
		public byte[] GetPicArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x060072E0 RID: 29408 RVA: 0x0024AA8C File Offset: 0x00248C8C
		public int CondGroupId
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

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x060072E1 RID: 29409 RVA: 0x0024AACC File Offset: 0x00248CCC
		public int Type
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

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x060072E2 RID: 29410 RVA: 0x0024AB0C File Offset: 0x00248D0C
		public string MotionImg
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060072E3 RID: 29411 RVA: 0x0024AB44 File Offset: 0x00248D44
		public Span<byte> GetMotionImgBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060072E4 RID: 29412 RVA: 0x0024AB54 File Offset: 0x00248D54
		public byte[] GetMotionImgArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x060072E5 RID: 29413 RVA: 0x0024AB6C File Offset: 0x00248D6C
		public string AniBlueprint
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060072E6 RID: 29414 RVA: 0x0024ABA4 File Offset: 0x00248DA4
		public Span<byte> GetAniBlueprintBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060072E7 RID: 29415 RVA: 0x0024ABB4 File Offset: 0x00248DB4
		public byte[] GetAniBlueprintArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x060072E8 RID: 29416 RVA: 0x0024ABCC File Offset: 0x00248DCC
		public string AniMontage
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060072E9 RID: 29417 RVA: 0x0024AC04 File Offset: 0x00248E04
		public Span<byte> GetAniMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060072EA RID: 29418 RVA: 0x0024AC14 File Offset: 0x00248E14
		public byte[] GetAniMontageArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0400528E RID: 21134
		private Table __p;
	}
}

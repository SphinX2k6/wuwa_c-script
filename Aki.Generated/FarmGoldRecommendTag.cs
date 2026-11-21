using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D41 RID: 3393
	public struct FarmGoldRecommendTag : IFlatbufferObject
	{
		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x060072B7 RID: 29367 RVA: 0x0024A584 File Offset: 0x00248784
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060072B8 RID: 29368 RVA: 0x0024A591 File Offset: 0x00248791
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060072B9 RID: 29369 RVA: 0x0024A598 File Offset: 0x00248798
		public static FarmGoldRecommendTag GetRootAsFarmGoldRecommendTag(ByteBuffer _bb)
		{
			return FarmGoldRecommendTag.GetRootAsFarmGoldRecommendTag(_bb, default(FarmGoldRecommendTag));
		}

		// Token: 0x060072BA RID: 29370 RVA: 0x0024A5B4 File Offset: 0x002487B4
		public static FarmGoldRecommendTag GetRootAsFarmGoldRecommendTag(ByteBuffer _bb, FarmGoldRecommendTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060072BB RID: 29371 RVA: 0x0024A5D1 File Offset: 0x002487D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060072BC RID: 29372 RVA: 0x0024A5E0 File Offset: 0x002487E0
		public FarmGoldRecommendTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x060072BD RID: 29373 RVA: 0x0024A5F0 File Offset: 0x002487F0
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

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x060072BE RID: 29374 RVA: 0x0024A62C File Offset: 0x0024882C
		public string RecommendText
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

		// Token: 0x060072BF RID: 29375 RVA: 0x0024A663 File Offset: 0x00248863
		public Span<byte> GetRecommendTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060072C0 RID: 29376 RVA: 0x0024A672 File Offset: 0x00248872
		public byte[] GetRecommendTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x060072C1 RID: 29377 RVA: 0x0024A68C File Offset: 0x0024888C
		public string RecommendIcon
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

		// Token: 0x060072C2 RID: 29378 RVA: 0x0024A6C3 File Offset: 0x002488C3
		public Span<byte> GetRecommendIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060072C3 RID: 29379 RVA: 0x0024A6D2 File Offset: 0x002488D2
		public byte[] GetRecommendIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400528C RID: 21132
		private Table __p;
	}
}

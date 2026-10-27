using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C5D RID: 3165
	public struct FarmGoldRecommendTag : IFlatbufferObject
	{
		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x06006CAC RID: 27820 RVA: 0x0022B234 File Offset: 0x00229434
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006CAD RID: 27821 RVA: 0x0022B241 File Offset: 0x00229441
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006CAE RID: 27822 RVA: 0x0022B248 File Offset: 0x00229448
		public static FarmGoldRecommendTag GetRootAsFarmGoldRecommendTag(ByteBuffer _bb)
		{
			return FarmGoldRecommendTag.GetRootAsFarmGoldRecommendTag(_bb, default(FarmGoldRecommendTag));
		}

		// Token: 0x06006CAF RID: 27823 RVA: 0x0022B264 File Offset: 0x00229464
		public static FarmGoldRecommendTag GetRootAsFarmGoldRecommendTag(ByteBuffer _bb, FarmGoldRecommendTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006CB0 RID: 27824 RVA: 0x0022B281 File Offset: 0x00229481
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006CB1 RID: 27825 RVA: 0x0022B290 File Offset: 0x00229490
		public FarmGoldRecommendTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06006CB2 RID: 27826 RVA: 0x0022B2A0 File Offset: 0x002294A0
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

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06006CB3 RID: 27827 RVA: 0x0022B2DC File Offset: 0x002294DC
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

		// Token: 0x06006CB4 RID: 27828 RVA: 0x0022B313 File Offset: 0x00229513
		public Span<byte> GetRecommendTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006CB5 RID: 27829 RVA: 0x0022B322 File Offset: 0x00229522
		public byte[] GetRecommendTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x06006CB6 RID: 27830 RVA: 0x0022B33C File Offset: 0x0022953C
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

		// Token: 0x06006CB7 RID: 27831 RVA: 0x0022B373 File Offset: 0x00229573
		public Span<byte> GetRecommendIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006CB8 RID: 27832 RVA: 0x0022B382 File Offset: 0x00229582
		public byte[] GetRecommendIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CA8 RID: 19624
		private Table __p;
	}
}

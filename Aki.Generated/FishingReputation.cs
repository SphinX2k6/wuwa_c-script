using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D6E RID: 3438
	public struct FishingReputation : IFlatbufferObject
	{
		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x0600766A RID: 30314 RVA: 0x00252D1C File Offset: 0x00250F1C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600766B RID: 30315 RVA: 0x00252D29 File Offset: 0x00250F29
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600766C RID: 30316 RVA: 0x00252D30 File Offset: 0x00250F30
		public static FishingReputation GetRootAsFishingReputation(ByteBuffer _bb)
		{
			return FishingReputation.GetRootAsFishingReputation(_bb, default(FishingReputation));
		}

		// Token: 0x0600766D RID: 30317 RVA: 0x00252D4C File Offset: 0x00250F4C
		public static FishingReputation GetRootAsFishingReputation(ByteBuffer _bb, FishingReputation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600766E RID: 30318 RVA: 0x00252D69 File Offset: 0x00250F69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600766F RID: 30319 RVA: 0x00252D78 File Offset: 0x00250F78
		public FishingReputation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x06007670 RID: 30320 RVA: 0x00252D88 File Offset: 0x00250F88
		public int Level
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

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x06007671 RID: 30321 RVA: 0x00252DC4 File Offset: 0x00250FC4
		public int Exp
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

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x06007672 RID: 30322 RVA: 0x00252E00 File Offset: 0x00251000
		public string SailRating
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

		// Token: 0x06007673 RID: 30323 RVA: 0x00252E37 File Offset: 0x00251037
		public Span<byte> GetSailRatingBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007674 RID: 30324 RVA: 0x00252E46 File Offset: 0x00251046
		public byte[] GetSailRatingArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040052C3 RID: 21187
		private Table __p;
	}
}

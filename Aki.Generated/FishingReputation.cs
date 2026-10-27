using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C8A RID: 3210
	public struct FishingReputation : IFlatbufferObject
	{
		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x0600705F RID: 28767 RVA: 0x00233C28 File Offset: 0x00231E28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007060 RID: 28768 RVA: 0x00233C35 File Offset: 0x00231E35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007061 RID: 28769 RVA: 0x00233C3C File Offset: 0x00231E3C
		public static FishingReputation GetRootAsFishingReputation(ByteBuffer _bb)
		{
			return FishingReputation.GetRootAsFishingReputation(_bb, default(FishingReputation));
		}

		// Token: 0x06007062 RID: 28770 RVA: 0x00233C58 File Offset: 0x00231E58
		public static FishingReputation GetRootAsFishingReputation(ByteBuffer _bb, FishingReputation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007063 RID: 28771 RVA: 0x00233C75 File Offset: 0x00231E75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007064 RID: 28772 RVA: 0x00233C84 File Offset: 0x00231E84
		public FishingReputation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x06007065 RID: 28773 RVA: 0x00233C94 File Offset: 0x00231E94
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

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06007066 RID: 28774 RVA: 0x00233CD0 File Offset: 0x00231ED0
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

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x06007067 RID: 28775 RVA: 0x00233D0C File Offset: 0x00231F0C
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

		// Token: 0x06007068 RID: 28776 RVA: 0x00233D43 File Offset: 0x00231F43
		public Span<byte> GetSailRatingBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007069 RID: 28777 RVA: 0x00233D52 File Offset: 0x00231F52
		public byte[] GetSailRatingArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CDF RID: 19679
		private Table __p;
	}
}

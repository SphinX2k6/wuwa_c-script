using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C5E RID: 3166
	public struct FarmGoldScore : IFlatbufferObject
	{
		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x06006CB9 RID: 27833 RVA: 0x0022B399 File Offset: 0x00229599
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006CBA RID: 27834 RVA: 0x0022B3A6 File Offset: 0x002295A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006CBB RID: 27835 RVA: 0x0022B3B0 File Offset: 0x002295B0
		public static FarmGoldScore GetRootAsFarmGoldScore(ByteBuffer _bb)
		{
			return FarmGoldScore.GetRootAsFarmGoldScore(_bb, default(FarmGoldScore));
		}

		// Token: 0x06006CBC RID: 27836 RVA: 0x0022B3CC File Offset: 0x002295CC
		public static FarmGoldScore GetRootAsFarmGoldScore(ByteBuffer _bb, FarmGoldScore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006CBD RID: 27837 RVA: 0x0022B3E9 File Offset: 0x002295E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006CBE RID: 27838 RVA: 0x0022B3F8 File Offset: 0x002295F8
		public FarmGoldScore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x06006CBF RID: 27839 RVA: 0x0022B408 File Offset: 0x00229608
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

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x06006CC0 RID: 27840 RVA: 0x0022B444 File Offset: 0x00229644
		public int ActivityId
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

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06006CC1 RID: 27841 RVA: 0x0022B480 File Offset: 0x00229680
		public int Score
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

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x06006CC2 RID: 27842 RVA: 0x0022B4BC File Offset: 0x002296BC
		public int RewardId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004CA9 RID: 19625
		private Table __p;
	}
}

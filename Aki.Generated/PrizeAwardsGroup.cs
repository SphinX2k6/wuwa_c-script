using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001041 RID: 4161
	public struct PrizeAwardsGroup : IFlatbufferObject
	{
		// Token: 0x17002B75 RID: 11125
		// (get) Token: 0x0600B9B2 RID: 47538 RVA: 0x002E8539 File Offset: 0x002E6739
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B9B3 RID: 47539 RVA: 0x002E8546 File Offset: 0x002E6746
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B9B4 RID: 47540 RVA: 0x002E8550 File Offset: 0x002E6750
		public static PrizeAwardsGroup GetRootAsPrizeAwardsGroup(ByteBuffer _bb)
		{
			return PrizeAwardsGroup.GetRootAsPrizeAwardsGroup(_bb, default(PrizeAwardsGroup));
		}

		// Token: 0x0600B9B5 RID: 47541 RVA: 0x002E856C File Offset: 0x002E676C
		public static PrizeAwardsGroup GetRootAsPrizeAwardsGroup(ByteBuffer _bb, PrizeAwardsGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B9B6 RID: 47542 RVA: 0x002E8589 File Offset: 0x002E6789
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B9B7 RID: 47543 RVA: 0x002E8598 File Offset: 0x002E6798
		public PrizeAwardsGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B76 RID: 11126
		// (get) Token: 0x0600B9B8 RID: 47544 RVA: 0x002E85A8 File Offset: 0x002E67A8
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

		// Token: 0x17002B77 RID: 11127
		// (get) Token: 0x0600B9B9 RID: 47545 RVA: 0x002E85E4 File Offset: 0x002E67E4
		public int Amount
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

		// Token: 0x17002B78 RID: 11128
		// (get) Token: 0x0600B9BA RID: 47546 RVA: 0x002E8620 File Offset: 0x002E6820
		public int RewardId
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

		// Token: 0x17002B79 RID: 11129
		// (get) Token: 0x0600B9BB RID: 47547 RVA: 0x002E865C File Offset: 0x002E685C
		public int Weight
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

		// Token: 0x17002B7A RID: 11130
		// (get) Token: 0x0600B9BC RID: 47548 RVA: 0x002E869C File Offset: 0x002E689C
		public int Rank
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400560E RID: 22030
		private Table __p;
	}
}

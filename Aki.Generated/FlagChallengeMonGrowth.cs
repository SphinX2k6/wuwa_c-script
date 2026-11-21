using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D78 RID: 3448
	public struct FlagChallengeMonGrowth : IFlatbufferObject
	{
		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x06007755 RID: 30549 RVA: 0x00254D59 File Offset: 0x00252F59
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007756 RID: 30550 RVA: 0x00254D66 File Offset: 0x00252F66
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007757 RID: 30551 RVA: 0x00254D70 File Offset: 0x00252F70
		public static FlagChallengeMonGrowth GetRootAsFlagChallengeMonGrowth(ByteBuffer _bb)
		{
			return FlagChallengeMonGrowth.GetRootAsFlagChallengeMonGrowth(_bb, default(FlagChallengeMonGrowth));
		}

		// Token: 0x06007758 RID: 30552 RVA: 0x00254D8C File Offset: 0x00252F8C
		public static FlagChallengeMonGrowth GetRootAsFlagChallengeMonGrowth(ByteBuffer _bb, FlagChallengeMonGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007759 RID: 30553 RVA: 0x00254DA9 File Offset: 0x00252FA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600775A RID: 30554 RVA: 0x00254DB8 File Offset: 0x00252FB8
		public FlagChallengeMonGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x0600775B RID: 30555 RVA: 0x00254DC8 File Offset: 0x00252FC8
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

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x0600775C RID: 30556 RVA: 0x00254E04 File Offset: 0x00253004
		public int Level
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

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x0600775D RID: 30557 RVA: 0x00254E40 File Offset: 0x00253040
		public int ActivityId
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

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x0600775E RID: 30558 RVA: 0x00254E7C File Offset: 0x0025307C
		public int LifeMaxRatio
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

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x0600775F RID: 30559 RVA: 0x00254EBC File Offset: 0x002530BC
		public int AtkRatio
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

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x06007760 RID: 30560 RVA: 0x00254EFC File Offset: 0x002530FC
		public int DefRatio
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040052CF RID: 21199
		private Table __p;
	}
}

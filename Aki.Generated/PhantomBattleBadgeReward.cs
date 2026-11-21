using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FA3 RID: 4003
	public struct PhantomBattleBadgeReward : IFlatbufferObject
	{
		// Token: 0x170025A7 RID: 9639
		// (get) Token: 0x0600AAA0 RID: 43680 RVA: 0x002C7251 File Offset: 0x002C5451
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AAA1 RID: 43681 RVA: 0x002C725E File Offset: 0x002C545E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AAA2 RID: 43682 RVA: 0x002C7268 File Offset: 0x002C5468
		public static PhantomBattleBadgeReward GetRootAsPhantomBattleBadgeReward(ByteBuffer _bb)
		{
			return PhantomBattleBadgeReward.GetRootAsPhantomBattleBadgeReward(_bb, default(PhantomBattleBadgeReward));
		}

		// Token: 0x0600AAA3 RID: 43683 RVA: 0x002C7284 File Offset: 0x002C5484
		public static PhantomBattleBadgeReward GetRootAsPhantomBattleBadgeReward(ByteBuffer _bb, PhantomBattleBadgeReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AAA4 RID: 43684 RVA: 0x002C72A1 File Offset: 0x002C54A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AAA5 RID: 43685 RVA: 0x002C72B0 File Offset: 0x002C54B0
		public PhantomBattleBadgeReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170025A8 RID: 9640
		// (get) Token: 0x0600AAA6 RID: 43686 RVA: 0x002C72C0 File Offset: 0x002C54C0
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

		// Token: 0x170025A9 RID: 9641
		// (get) Token: 0x0600AAA7 RID: 43687 RVA: 0x002C72FC File Offset: 0x002C54FC
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

		// Token: 0x170025AA RID: 9642
		// (get) Token: 0x0600AAA8 RID: 43688 RVA: 0x002C7338 File Offset: 0x002C5538
		public int DropId
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

		// Token: 0x170025AB RID: 9643
		// (get) Token: 0x0600AAA9 RID: 43689 RVA: 0x002C7374 File Offset: 0x002C5574
		public int BitFlagId
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

		// Token: 0x0400555E RID: 21854
		private Table __p;
	}
}

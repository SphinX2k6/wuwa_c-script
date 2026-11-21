using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C27 RID: 3111
	public struct BossRushScore : IFlatbufferObject
	{
		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06005501 RID: 21761 RVA: 0x00207EE4 File Offset: 0x002060E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005502 RID: 21762 RVA: 0x00207EF1 File Offset: 0x002060F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005503 RID: 21763 RVA: 0x00207EF8 File Offset: 0x002060F8
		public static BossRushScore GetRootAsBossRushScore(ByteBuffer _bb)
		{
			return BossRushScore.GetRootAsBossRushScore(_bb, default(BossRushScore));
		}

		// Token: 0x06005504 RID: 21764 RVA: 0x00207F14 File Offset: 0x00206114
		public static BossRushScore GetRootAsBossRushScore(ByteBuffer _bb, BossRushScore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005505 RID: 21765 RVA: 0x00207F31 File Offset: 0x00206131
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005506 RID: 21766 RVA: 0x00207F40 File Offset: 0x00206140
		public BossRushScore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06005507 RID: 21767 RVA: 0x00207F50 File Offset: 0x00206150
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

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06005508 RID: 21768 RVA: 0x00207F8C File Offset: 0x0020618C
		public int Score
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

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06005509 RID: 21769 RVA: 0x00207FC8 File Offset: 0x002061C8
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

		// Token: 0x04005122 RID: 20770
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BD1 RID: 3025
	public struct DangoBrawlScoreReward : IFlatbufferObject
	{
		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06005FDB RID: 24539 RVA: 0x0020E464 File Offset: 0x0020C664
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005FDC RID: 24540 RVA: 0x0020E471 File Offset: 0x0020C671
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005FDD RID: 24541 RVA: 0x0020E478 File Offset: 0x0020C678
		public static DangoBrawlScoreReward GetRootAsDangoBrawlScoreReward(ByteBuffer _bb)
		{
			return DangoBrawlScoreReward.GetRootAsDangoBrawlScoreReward(_bb, default(DangoBrawlScoreReward));
		}

		// Token: 0x06005FDE RID: 24542 RVA: 0x0020E494 File Offset: 0x0020C694
		public static DangoBrawlScoreReward GetRootAsDangoBrawlScoreReward(ByteBuffer _bb, DangoBrawlScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005FDF RID: 24543 RVA: 0x0020E4B1 File Offset: 0x0020C6B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005FE0 RID: 24544 RVA: 0x0020E4C0 File Offset: 0x0020C6C0
		public DangoBrawlScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06005FE1 RID: 24545 RVA: 0x0020E4D0 File Offset: 0x0020C6D0
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

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06005FE2 RID: 24546 RVA: 0x0020E50C File Offset: 0x0020C70C
		public int Activity
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

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06005FE3 RID: 24547 RVA: 0x0020E548 File Offset: 0x0020C748
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

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06005FE4 RID: 24548 RVA: 0x0020E584 File Offset: 0x0020C784
		public int DropId
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

		// Token: 0x04004BFC RID: 19452
		private Table __p;
	}
}

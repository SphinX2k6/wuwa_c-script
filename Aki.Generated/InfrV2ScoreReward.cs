using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E52 RID: 3666
	public struct InfrV2ScoreReward : IFlatbufferObject
	{
		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x06008A3A RID: 35386 RVA: 0x0027EEFE File Offset: 0x0027D0FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008A3B RID: 35387 RVA: 0x0027EF0B File Offset: 0x0027D10B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008A3C RID: 35388 RVA: 0x0027EF14 File Offset: 0x0027D114
		public static InfrV2ScoreReward GetRootAsInfrV2ScoreReward(ByteBuffer _bb)
		{
			return InfrV2ScoreReward.GetRootAsInfrV2ScoreReward(_bb, default(InfrV2ScoreReward));
		}

		// Token: 0x06008A3D RID: 35389 RVA: 0x0027EF30 File Offset: 0x0027D130
		public static InfrV2ScoreReward GetRootAsInfrV2ScoreReward(ByteBuffer _bb, InfrV2ScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008A3E RID: 35390 RVA: 0x0027EF4D File Offset: 0x0027D14D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008A3F RID: 35391 RVA: 0x0027EF5C File Offset: 0x0027D15C
		public InfrV2ScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x06008A40 RID: 35392 RVA: 0x0027EF6C File Offset: 0x0027D16C
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

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x06008A41 RID: 35393 RVA: 0x0027EFA8 File Offset: 0x0027D1A8
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

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x06008A42 RID: 35394 RVA: 0x0027EFE4 File Offset: 0x0027D1E4
		public int Index
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

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x06008A43 RID: 35395 RVA: 0x0027F020 File Offset: 0x0027D220
		public int Score
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

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x06008A44 RID: 35396 RVA: 0x0027F060 File Offset: 0x0027D260
		public int DropId
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

		// Token: 0x040053D5 RID: 21461
		private Table __p;
	}
}

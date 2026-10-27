using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011A3 RID: 4515
	public struct WeeklyFrameAward : IFlatbufferObject
	{
		// Token: 0x17003E59 RID: 15961
		// (get) Token: 0x0600E901 RID: 59649 RVA: 0x0034521D File Offset: 0x0034341D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E902 RID: 59650 RVA: 0x0034522A File Offset: 0x0034342A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E903 RID: 59651 RVA: 0x00345234 File Offset: 0x00343434
		public static WeeklyFrameAward GetRootAsWeeklyFrameAward(ByteBuffer _bb)
		{
			return WeeklyFrameAward.GetRootAsWeeklyFrameAward(_bb, default(WeeklyFrameAward));
		}

		// Token: 0x0600E904 RID: 59652 RVA: 0x00345250 File Offset: 0x00343450
		public static WeeklyFrameAward GetRootAsWeeklyFrameAward(ByteBuffer _bb, WeeklyFrameAward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E905 RID: 59653 RVA: 0x0034526D File Offset: 0x0034346D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E906 RID: 59654 RVA: 0x0034527C File Offset: 0x0034347C
		public WeeklyFrameAward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E5A RID: 15962
		// (get) Token: 0x0600E907 RID: 59655 RVA: 0x0034528C File Offset: 0x0034348C
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

		// Token: 0x17003E5B RID: 15963
		// (get) Token: 0x0600E908 RID: 59656 RVA: 0x003452C8 File Offset: 0x003434C8
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

		// Token: 0x17003E5C RID: 15964
		// (get) Token: 0x0600E909 RID: 59657 RVA: 0x00345304 File Offset: 0x00343504
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

		// Token: 0x040052EF RID: 21231
		private Table __p;
	}
}

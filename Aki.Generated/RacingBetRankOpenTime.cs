using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200106D RID: 4205
	public struct RacingBetRankOpenTime : IFlatbufferObject
	{
		// Token: 0x17002D01 RID: 11521
		// (get) Token: 0x0600BE17 RID: 48663 RVA: 0x002F1525 File Offset: 0x002EF725
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BE18 RID: 48664 RVA: 0x002F1532 File Offset: 0x002EF732
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BE19 RID: 48665 RVA: 0x002F153C File Offset: 0x002EF73C
		public static RacingBetRankOpenTime GetRootAsRacingBetRankOpenTime(ByteBuffer _bb)
		{
			return RacingBetRankOpenTime.GetRootAsRacingBetRankOpenTime(_bb, default(RacingBetRankOpenTime));
		}

		// Token: 0x0600BE1A RID: 48666 RVA: 0x002F1558 File Offset: 0x002EF758
		public static RacingBetRankOpenTime GetRootAsRacingBetRankOpenTime(ByteBuffer _bb, RacingBetRankOpenTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BE1B RID: 48667 RVA: 0x002F1575 File Offset: 0x002EF775
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BE1C RID: 48668 RVA: 0x002F1584 File Offset: 0x002EF784
		public RacingBetRankOpenTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D02 RID: 11522
		// (get) Token: 0x0600BE1D RID: 48669 RVA: 0x002F1594 File Offset: 0x002EF794
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

		// Token: 0x0400563B RID: 22075
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F86 RID: 3974
	public struct RacingBetRankOpenTime : IFlatbufferObject
	{
		// Token: 0x17002C89 RID: 11401
		// (get) Token: 0x0600B7DA RID: 47066 RVA: 0x002D4B99 File Offset: 0x002D2D99
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B7DB RID: 47067 RVA: 0x002D4BA6 File Offset: 0x002D2DA6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B7DC RID: 47068 RVA: 0x002D4BB0 File Offset: 0x002D2DB0
		public static RacingBetRankOpenTime GetRootAsRacingBetRankOpenTime(ByteBuffer _bb)
		{
			return RacingBetRankOpenTime.GetRootAsRacingBetRankOpenTime(_bb, default(RacingBetRankOpenTime));
		}

		// Token: 0x0600B7DD RID: 47069 RVA: 0x002D4BCC File Offset: 0x002D2DCC
		public static RacingBetRankOpenTime GetRootAsRacingBetRankOpenTime(ByteBuffer _bb, RacingBetRankOpenTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B7DE RID: 47070 RVA: 0x002D4BE9 File Offset: 0x002D2DE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B7DF RID: 47071 RVA: 0x002D4BF8 File Offset: 0x002D2DF8
		public RacingBetRankOpenTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C8A RID: 11402
		// (get) Token: 0x0600B7E0 RID: 47072 RVA: 0x002D4C08 File Offset: 0x002D2E08
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

		// Token: 0x04005054 RID: 20564
		private Table __p;
	}
}

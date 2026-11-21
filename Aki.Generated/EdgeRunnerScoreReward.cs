using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CFF RID: 3327
	public struct EdgeRunnerScoreReward : IFlatbufferObject
	{
		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06006D4D RID: 27981 RVA: 0x0023EDE2 File Offset: 0x0023CFE2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006D4E RID: 27982 RVA: 0x0023EDEF File Offset: 0x0023CFEF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006D4F RID: 27983 RVA: 0x0023EDF8 File Offset: 0x0023CFF8
		public static EdgeRunnerScoreReward GetRootAsEdgeRunnerScoreReward(ByteBuffer _bb)
		{
			return EdgeRunnerScoreReward.GetRootAsEdgeRunnerScoreReward(_bb, default(EdgeRunnerScoreReward));
		}

		// Token: 0x06006D50 RID: 27984 RVA: 0x0023EE14 File Offset: 0x0023D014
		public static EdgeRunnerScoreReward GetRootAsEdgeRunnerScoreReward(ByteBuffer _bb, EdgeRunnerScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006D51 RID: 27985 RVA: 0x0023EE31 File Offset: 0x0023D031
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006D52 RID: 27986 RVA: 0x0023EE40 File Offset: 0x0023D040
		public EdgeRunnerScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06006D53 RID: 27987 RVA: 0x0023EE50 File Offset: 0x0023D050
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

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06006D54 RID: 27988 RVA: 0x0023EE8C File Offset: 0x0023D08C
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

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06006D55 RID: 27989 RVA: 0x0023EEC8 File Offset: 0x0023D0C8
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

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06006D56 RID: 27990 RVA: 0x0023EF04 File Offset: 0x0023D104
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

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06006D57 RID: 27991 RVA: 0x0023EF44 File Offset: 0x0023D144
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

		// Token: 0x0400523F RID: 21055
		private Table __p;
	}
}

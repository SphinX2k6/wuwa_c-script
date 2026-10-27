using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C1C RID: 3100
	public struct EdgeRunnerScoreReward : IFlatbufferObject
	{
		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x0600675A RID: 26458 RVA: 0x0021FA06 File Offset: 0x0021DC06
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600675B RID: 26459 RVA: 0x0021FA13 File Offset: 0x0021DC13
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600675C RID: 26460 RVA: 0x0021FA1C File Offset: 0x0021DC1C
		public static EdgeRunnerScoreReward GetRootAsEdgeRunnerScoreReward(ByteBuffer _bb)
		{
			return EdgeRunnerScoreReward.GetRootAsEdgeRunnerScoreReward(_bb, default(EdgeRunnerScoreReward));
		}

		// Token: 0x0600675D RID: 26461 RVA: 0x0021FA38 File Offset: 0x0021DC38
		public static EdgeRunnerScoreReward GetRootAsEdgeRunnerScoreReward(ByteBuffer _bb, EdgeRunnerScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600675E RID: 26462 RVA: 0x0021FA55 File Offset: 0x0021DC55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600675F RID: 26463 RVA: 0x0021FA64 File Offset: 0x0021DC64
		public EdgeRunnerScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x06006760 RID: 26464 RVA: 0x0021FA74 File Offset: 0x0021DC74
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

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x06006761 RID: 26465 RVA: 0x0021FAB0 File Offset: 0x0021DCB0
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

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06006762 RID: 26466 RVA: 0x0021FAEC File Offset: 0x0021DCEC
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

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06006763 RID: 26467 RVA: 0x0021FB28 File Offset: 0x0021DD28
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

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06006764 RID: 26468 RVA: 0x0021FB68 File Offset: 0x0021DD68
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

		// Token: 0x04004C5C RID: 19548
		private Table __p;
	}
}

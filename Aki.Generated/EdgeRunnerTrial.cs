using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C1E RID: 3102
	public struct EdgeRunnerTrial : IFlatbufferObject
	{
		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x0600676F RID: 26479 RVA: 0x0021FCAD File Offset: 0x0021DEAD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006770 RID: 26480 RVA: 0x0021FCBA File Offset: 0x0021DEBA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006771 RID: 26481 RVA: 0x0021FCC4 File Offset: 0x0021DEC4
		public static EdgeRunnerTrial GetRootAsEdgeRunnerTrial(ByteBuffer _bb)
		{
			return EdgeRunnerTrial.GetRootAsEdgeRunnerTrial(_bb, default(EdgeRunnerTrial));
		}

		// Token: 0x06006772 RID: 26482 RVA: 0x0021FCE0 File Offset: 0x0021DEE0
		public static EdgeRunnerTrial GetRootAsEdgeRunnerTrial(ByteBuffer _bb, EdgeRunnerTrial obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006773 RID: 26483 RVA: 0x0021FCFD File Offset: 0x0021DEFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006774 RID: 26484 RVA: 0x0021FD0C File Offset: 0x0021DF0C
		public EdgeRunnerTrial __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06006775 RID: 26485 RVA: 0x0021FD1C File Offset: 0x0021DF1C
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

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06006776 RID: 26486 RVA: 0x0021FD58 File Offset: 0x0021DF58
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

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06006777 RID: 26487 RVA: 0x0021FD94 File Offset: 0x0021DF94
		public int CyberPunkActivityId
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

		// Token: 0x04004C5E RID: 19550
		private Table __p;
	}
}

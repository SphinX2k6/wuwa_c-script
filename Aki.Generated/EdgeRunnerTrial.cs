using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D01 RID: 3329
	public struct EdgeRunnerTrial : IFlatbufferObject
	{
		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06006D62 RID: 28002 RVA: 0x0023F089 File Offset: 0x0023D289
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006D63 RID: 28003 RVA: 0x0023F096 File Offset: 0x0023D296
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006D64 RID: 28004 RVA: 0x0023F0A0 File Offset: 0x0023D2A0
		public static EdgeRunnerTrial GetRootAsEdgeRunnerTrial(ByteBuffer _bb)
		{
			return EdgeRunnerTrial.GetRootAsEdgeRunnerTrial(_bb, default(EdgeRunnerTrial));
		}

		// Token: 0x06006D65 RID: 28005 RVA: 0x0023F0BC File Offset: 0x0023D2BC
		public static EdgeRunnerTrial GetRootAsEdgeRunnerTrial(ByteBuffer _bb, EdgeRunnerTrial obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006D66 RID: 28006 RVA: 0x0023F0D9 File Offset: 0x0023D2D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006D67 RID: 28007 RVA: 0x0023F0E8 File Offset: 0x0023D2E8
		public EdgeRunnerTrial __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06006D68 RID: 28008 RVA: 0x0023F0F8 File Offset: 0x0023D2F8
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

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06006D69 RID: 28009 RVA: 0x0023F134 File Offset: 0x0023D334
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

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06006D6A RID: 28010 RVA: 0x0023F170 File Offset: 0x0023D370
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

		// Token: 0x04005241 RID: 21057
		private Table __p;
	}
}

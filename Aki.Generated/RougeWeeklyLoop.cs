using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001070 RID: 4208
	public struct RougeWeeklyLoop : IFlatbufferObject
	{
		// Token: 0x170033E4 RID: 13284
		// (get) Token: 0x0600CC9D RID: 52381 RVA: 0x0030346D File Offset: 0x0030166D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CC9E RID: 52382 RVA: 0x0030347A File Offset: 0x0030167A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CC9F RID: 52383 RVA: 0x00303484 File Offset: 0x00301684
		public static RougeWeeklyLoop GetRootAsRougeWeeklyLoop(ByteBuffer _bb)
		{
			return RougeWeeklyLoop.GetRootAsRougeWeeklyLoop(_bb, default(RougeWeeklyLoop));
		}

		// Token: 0x0600CCA0 RID: 52384 RVA: 0x003034A0 File Offset: 0x003016A0
		public static RougeWeeklyLoop GetRootAsRougeWeeklyLoop(ByteBuffer _bb, RougeWeeklyLoop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CCA1 RID: 52385 RVA: 0x003034BD File Offset: 0x003016BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CCA2 RID: 52386 RVA: 0x003034CC File Offset: 0x003016CC
		public RougeWeeklyLoop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170033E5 RID: 13285
		// (get) Token: 0x0600CCA3 RID: 52387 RVA: 0x003034DC File Offset: 0x003016DC
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

		// Token: 0x170033E6 RID: 13286
		// (get) Token: 0x0600CCA4 RID: 52388 RVA: 0x00303518 File Offset: 0x00301718
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

		// Token: 0x04005175 RID: 20853
		private Table __p;
	}
}

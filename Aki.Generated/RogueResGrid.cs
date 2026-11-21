using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010EE RID: 4334
	public struct RogueResGrid : IFlatbufferObject
	{
		// Token: 0x170030E5 RID: 12517
		// (get) Token: 0x0600C918 RID: 51480 RVA: 0x0030946D File Offset: 0x0030766D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C919 RID: 51481 RVA: 0x0030947A File Offset: 0x0030767A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C91A RID: 51482 RVA: 0x00309484 File Offset: 0x00307684
		public static RogueResGrid GetRootAsRogueResGrid(ByteBuffer _bb)
		{
			return RogueResGrid.GetRootAsRogueResGrid(_bb, default(RogueResGrid));
		}

		// Token: 0x0600C91B RID: 51483 RVA: 0x003094A0 File Offset: 0x003076A0
		public static RogueResGrid GetRootAsRogueResGrid(ByteBuffer _bb, RogueResGrid obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C91C RID: 51484 RVA: 0x003094BD File Offset: 0x003076BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C91D RID: 51485 RVA: 0x003094CC File Offset: 0x003076CC
		public RogueResGrid __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030E6 RID: 12518
		// (get) Token: 0x0600C91E RID: 51486 RVA: 0x003094DC File Offset: 0x003076DC
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

		// Token: 0x040056D6 RID: 22230
		private Table __p;
	}
}

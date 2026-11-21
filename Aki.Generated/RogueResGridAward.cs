using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010EF RID: 4335
	public struct RogueResGridAward : IFlatbufferObject
	{
		// Token: 0x170030E7 RID: 12519
		// (get) Token: 0x0600C91F RID: 51487 RVA: 0x00309518 File Offset: 0x00307718
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C920 RID: 51488 RVA: 0x00309525 File Offset: 0x00307725
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C921 RID: 51489 RVA: 0x0030952C File Offset: 0x0030772C
		public static RogueResGridAward GetRootAsRogueResGridAward(ByteBuffer _bb)
		{
			return RogueResGridAward.GetRootAsRogueResGridAward(_bb, default(RogueResGridAward));
		}

		// Token: 0x0600C922 RID: 51490 RVA: 0x00309548 File Offset: 0x00307748
		public static RogueResGridAward GetRootAsRogueResGridAward(ByteBuffer _bb, RogueResGridAward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C923 RID: 51491 RVA: 0x00309565 File Offset: 0x00307765
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C924 RID: 51492 RVA: 0x00309574 File Offset: 0x00307774
		public RogueResGridAward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030E8 RID: 12520
		// (get) Token: 0x0600C925 RID: 51493 RVA: 0x00309584 File Offset: 0x00307784
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

		// Token: 0x040056D7 RID: 22231
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001007 RID: 4103
	public struct RogueResGridAward : IFlatbufferObject
	{
		// Token: 0x1700306C RID: 12396
		// (get) Token: 0x0600C2D5 RID: 49877 RVA: 0x002ED400 File Offset: 0x002EB600
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C2D6 RID: 49878 RVA: 0x002ED40D File Offset: 0x002EB60D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C2D7 RID: 49879 RVA: 0x002ED414 File Offset: 0x002EB614
		public static RogueResGridAward GetRootAsRogueResGridAward(ByteBuffer _bb)
		{
			return RogueResGridAward.GetRootAsRogueResGridAward(_bb, default(RogueResGridAward));
		}

		// Token: 0x0600C2D8 RID: 49880 RVA: 0x002ED430 File Offset: 0x002EB630
		public static RogueResGridAward GetRootAsRogueResGridAward(ByteBuffer _bb, RogueResGridAward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C2D9 RID: 49881 RVA: 0x002ED44D File Offset: 0x002EB64D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C2DA RID: 49882 RVA: 0x002ED45C File Offset: 0x002EB65C
		public RogueResGridAward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700306D RID: 12397
		// (get) Token: 0x0600C2DB RID: 49883 RVA: 0x002ED46C File Offset: 0x002EB66C
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

		// Token: 0x040050EF RID: 20719
		private Table __p;
	}
}

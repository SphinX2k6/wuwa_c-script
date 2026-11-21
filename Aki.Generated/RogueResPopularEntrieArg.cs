using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010F6 RID: 4342
	public struct RogueResPopularEntrieArg : IFlatbufferObject
	{
		// Token: 0x17003121 RID: 12577
		// (get) Token: 0x0600C9D8 RID: 51672 RVA: 0x0030B068 File Offset: 0x00309268
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C9D9 RID: 51673 RVA: 0x0030B075 File Offset: 0x00309275
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C9DA RID: 51674 RVA: 0x0030B07C File Offset: 0x0030927C
		public static RogueResPopularEntrieArg GetRootAsRogueResPopularEntrieArg(ByteBuffer _bb)
		{
			return RogueResPopularEntrieArg.GetRootAsRogueResPopularEntrieArg(_bb, default(RogueResPopularEntrieArg));
		}

		// Token: 0x0600C9DB RID: 51675 RVA: 0x0030B098 File Offset: 0x00309298
		public static RogueResPopularEntrieArg GetRootAsRogueResPopularEntrieArg(ByteBuffer _bb, RogueResPopularEntrieArg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C9DC RID: 51676 RVA: 0x0030B0B5 File Offset: 0x003092B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C9DD RID: 51677 RVA: 0x0030B0C4 File Offset: 0x003092C4
		public RogueResPopularEntrieArg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003122 RID: 12578
		// (get) Token: 0x0600C9DE RID: 51678 RVA: 0x0030B0D4 File Offset: 0x003092D4
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

		// Token: 0x17003123 RID: 12579
		// (get) Token: 0x0600C9DF RID: 51679 RVA: 0x0030B110 File Offset: 0x00309310
		public int SeasonId
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

		// Token: 0x17003124 RID: 12580
		// (get) Token: 0x0600C9E0 RID: 51680 RVA: 0x0030B14C File Offset: 0x0030934C
		public int InstId
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

		// Token: 0x17003125 RID: 12581
		// (get) Token: 0x0600C9E1 RID: 51681 RVA: 0x0030B188 File Offset: 0x00309388
		public int Slot
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

		// Token: 0x040056E3 RID: 22243
		private Table __p;
	}
}

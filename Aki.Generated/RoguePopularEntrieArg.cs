using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010D2 RID: 4306
	public struct RoguePopularEntrieArg : IFlatbufferObject
	{
		// Token: 0x1700300B RID: 12299
		// (get) Token: 0x0600C679 RID: 50809 RVA: 0x00303B88 File Offset: 0x00301D88
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C67A RID: 50810 RVA: 0x00303B95 File Offset: 0x00301D95
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C67B RID: 50811 RVA: 0x00303B9C File Offset: 0x00301D9C
		public static RoguePopularEntrieArg GetRootAsRoguePopularEntrieArg(ByteBuffer _bb)
		{
			return RoguePopularEntrieArg.GetRootAsRoguePopularEntrieArg(_bb, default(RoguePopularEntrieArg));
		}

		// Token: 0x0600C67C RID: 50812 RVA: 0x00303BB8 File Offset: 0x00301DB8
		public static RoguePopularEntrieArg GetRootAsRoguePopularEntrieArg(ByteBuffer _bb, RoguePopularEntrieArg obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C67D RID: 50813 RVA: 0x00303BD5 File Offset: 0x00301DD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C67E RID: 50814 RVA: 0x00303BE4 File Offset: 0x00301DE4
		public RoguePopularEntrieArg __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700300C RID: 12300
		// (get) Token: 0x0600C67F RID: 50815 RVA: 0x00303BF4 File Offset: 0x00301DF4
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

		// Token: 0x1700300D RID: 12301
		// (get) Token: 0x0600C680 RID: 50816 RVA: 0x00303C30 File Offset: 0x00301E30
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

		// Token: 0x1700300E RID: 12302
		// (get) Token: 0x0600C681 RID: 50817 RVA: 0x00303C6C File Offset: 0x00301E6C
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

		// Token: 0x1700300F RID: 12303
		// (get) Token: 0x0600C682 RID: 50818 RVA: 0x00303CA8 File Offset: 0x00301EA8
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

		// Token: 0x040056B3 RID: 22195
		private Table __p;
	}
}

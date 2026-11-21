using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001111 RID: 4369
	public struct RogueWeeklyBF : IFlatbufferObject
	{
		// Token: 0x170031D2 RID: 12754
		// (get) Token: 0x0600CBE8 RID: 52200 RVA: 0x0030F6E2 File Offset: 0x0030D8E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CBE9 RID: 52201 RVA: 0x0030F6EF File Offset: 0x0030D8EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CBEA RID: 52202 RVA: 0x0030F6F8 File Offset: 0x0030D8F8
		public static RogueWeeklyBF GetRootAsRogueWeeklyBF(ByteBuffer _bb)
		{
			return RogueWeeklyBF.GetRootAsRogueWeeklyBF(_bb, default(RogueWeeklyBF));
		}

		// Token: 0x0600CBEB RID: 52203 RVA: 0x0030F714 File Offset: 0x0030D914
		public static RogueWeeklyBF GetRootAsRogueWeeklyBF(ByteBuffer _bb, RogueWeeklyBF obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CBEC RID: 52204 RVA: 0x0030F731 File Offset: 0x0030D931
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CBED RID: 52205 RVA: 0x0030F740 File Offset: 0x0030D940
		public RogueWeeklyBF __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031D3 RID: 12755
		// (get) Token: 0x0600CBEE RID: 52206 RVA: 0x0030F750 File Offset: 0x0030D950
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

		// Token: 0x170031D4 RID: 12756
		// (get) Token: 0x0600CBEF RID: 52207 RVA: 0x0030F78C File Offset: 0x0030D98C
		public int ExchangeRewardId
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

		// Token: 0x170031D5 RID: 12757
		// (get) Token: 0x0600CBF0 RID: 52208 RVA: 0x0030F7C8 File Offset: 0x0030D9C8
		public int SilentAreaDetectionId
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

		// Token: 0x170031D6 RID: 12758
		// (get) Token: 0x0600CBF1 RID: 52209 RVA: 0x0030F804 File Offset: 0x0030DA04
		public int ShowItemId
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

		// Token: 0x170031D7 RID: 12759
		// (get) Token: 0x0600CBF2 RID: 52210 RVA: 0x0030F844 File Offset: 0x0030DA44
		public int SortId
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

		// Token: 0x170031D8 RID: 12760
		// (get) Token: 0x0600CBF3 RID: 52211 RVA: 0x0030F884 File Offset: 0x0030DA84
		public int IconId1
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170031D9 RID: 12761
		// (get) Token: 0x0600CBF4 RID: 52212 RVA: 0x0030F8C4 File Offset: 0x0030DAC4
		public int IconId2
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005704 RID: 22276
		private Table __p;
	}
}

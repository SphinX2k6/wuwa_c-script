using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001029 RID: 4137
	public struct RogueWeeklyBF : IFlatbufferObject
	{
		// Token: 0x17003157 RID: 12631
		// (get) Token: 0x0600C59E RID: 50590 RVA: 0x002F3755 File Offset: 0x002F1955
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C59F RID: 50591 RVA: 0x002F3762 File Offset: 0x002F1962
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C5A0 RID: 50592 RVA: 0x002F376C File Offset: 0x002F196C
		public static RogueWeeklyBF GetRootAsRogueWeeklyBF(ByteBuffer _bb)
		{
			return RogueWeeklyBF.GetRootAsRogueWeeklyBF(_bb, default(RogueWeeklyBF));
		}

		// Token: 0x0600C5A1 RID: 50593 RVA: 0x002F3788 File Offset: 0x002F1988
		public static RogueWeeklyBF GetRootAsRogueWeeklyBF(ByteBuffer _bb, RogueWeeklyBF obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C5A2 RID: 50594 RVA: 0x002F37A5 File Offset: 0x002F19A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C5A3 RID: 50595 RVA: 0x002F37B4 File Offset: 0x002F19B4
		public RogueWeeklyBF __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003158 RID: 12632
		// (get) Token: 0x0600C5A4 RID: 50596 RVA: 0x002F37C4 File Offset: 0x002F19C4
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

		// Token: 0x17003159 RID: 12633
		// (get) Token: 0x0600C5A5 RID: 50597 RVA: 0x002F3800 File Offset: 0x002F1A00
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

		// Token: 0x1700315A RID: 12634
		// (get) Token: 0x0600C5A6 RID: 50598 RVA: 0x002F383C File Offset: 0x002F1A3C
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

		// Token: 0x1700315B RID: 12635
		// (get) Token: 0x0600C5A7 RID: 50599 RVA: 0x002F3878 File Offset: 0x002F1A78
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

		// Token: 0x1700315C RID: 12636
		// (get) Token: 0x0600C5A8 RID: 50600 RVA: 0x002F38B8 File Offset: 0x002F1AB8
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

		// Token: 0x1700315D RID: 12637
		// (get) Token: 0x0600C5A9 RID: 50601 RVA: 0x002F38F8 File Offset: 0x002F1AF8
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

		// Token: 0x1700315E RID: 12638
		// (get) Token: 0x0600C5AA RID: 50602 RVA: 0x002F3938 File Offset: 0x002F1B38
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

		// Token: 0x0400511C RID: 20764
		private Table __p;
	}
}

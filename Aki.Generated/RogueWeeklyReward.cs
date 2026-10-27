using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200102E RID: 4142
	public struct RogueWeeklyReward : IFlatbufferObject
	{
		// Token: 0x170031A2 RID: 12706
		// (get) Token: 0x0600C65D RID: 50781 RVA: 0x002F56FE File Offset: 0x002F38FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C65E RID: 50782 RVA: 0x002F570B File Offset: 0x002F390B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C65F RID: 50783 RVA: 0x002F5714 File Offset: 0x002F3914
		public static RogueWeeklyReward GetRootAsRogueWeeklyReward(ByteBuffer _bb)
		{
			return RogueWeeklyReward.GetRootAsRogueWeeklyReward(_bb, default(RogueWeeklyReward));
		}

		// Token: 0x0600C660 RID: 50784 RVA: 0x002F5730 File Offset: 0x002F3930
		public static RogueWeeklyReward GetRootAsRogueWeeklyReward(ByteBuffer _bb, RogueWeeklyReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C661 RID: 50785 RVA: 0x002F574D File Offset: 0x002F394D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C662 RID: 50786 RVA: 0x002F575C File Offset: 0x002F395C
		public RogueWeeklyReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031A3 RID: 12707
		// (get) Token: 0x0600C663 RID: 50787 RVA: 0x002F576C File Offset: 0x002F396C
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

		// Token: 0x170031A4 RID: 12708
		// (get) Token: 0x0600C664 RID: 50788 RVA: 0x002F57A8 File Offset: 0x002F39A8
		public int CycleId
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

		// Token: 0x170031A5 RID: 12709
		// (get) Token: 0x0600C665 RID: 50789 RVA: 0x002F57E4 File Offset: 0x002F39E4
		public string TargetName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C666 RID: 50790 RVA: 0x002F581B File Offset: 0x002F3A1B
		public Span<byte> GetTargetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C667 RID: 50791 RVA: 0x002F582A File Offset: 0x002F3A2A
		public byte[] GetTargetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170031A6 RID: 12710
		// (get) Token: 0x0600C668 RID: 50792 RVA: 0x002F5844 File Offset: 0x002F3A44
		public int TargetReward
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

		// Token: 0x170031A7 RID: 12711
		// (get) Token: 0x0600C669 RID: 50793 RVA: 0x002F5884 File Offset: 0x002F3A84
		public int Score
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

		// Token: 0x04005126 RID: 20774
		private Table __p;
	}
}

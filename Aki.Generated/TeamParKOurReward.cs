using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001119 RID: 4377
	public struct TeamParKOurReward : IFlatbufferObject
	{
		// Token: 0x170039D8 RID: 14808
		// (get) Token: 0x0600DD2F RID: 56623 RVA: 0x0032A39D File Offset: 0x0032859D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DD30 RID: 56624 RVA: 0x0032A3AA File Offset: 0x003285AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DD31 RID: 56625 RVA: 0x0032A3B4 File Offset: 0x003285B4
		public static TeamParKOurReward GetRootAsTeamParKOurReward(ByteBuffer _bb)
		{
			return TeamParKOurReward.GetRootAsTeamParKOurReward(_bb, default(TeamParKOurReward));
		}

		// Token: 0x0600DD32 RID: 56626 RVA: 0x0032A3D0 File Offset: 0x003285D0
		public static TeamParKOurReward GetRootAsTeamParKOurReward(ByteBuffer _bb, TeamParKOurReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DD33 RID: 56627 RVA: 0x0032A3ED File Offset: 0x003285ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DD34 RID: 56628 RVA: 0x0032A3FC File Offset: 0x003285FC
		public TeamParKOurReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170039D9 RID: 14809
		// (get) Token: 0x0600DD35 RID: 56629 RVA: 0x0032A40C File Offset: 0x0032860C
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

		// Token: 0x170039DA RID: 14810
		// (get) Token: 0x0600DD36 RID: 56630 RVA: 0x0032A448 File Offset: 0x00328648
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

		// Token: 0x170039DB RID: 14811
		// (get) Token: 0x0600DD37 RID: 56631 RVA: 0x0032A484 File Offset: 0x00328684
		public int Reward
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

		// Token: 0x170039DC RID: 14812
		// (get) Token: 0x0600DD38 RID: 56632 RVA: 0x0032A4C0 File Offset: 0x003286C0
		public int RewardThreshold
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

		// Token: 0x170039DD RID: 14813
		// (get) Token: 0x0600DD39 RID: 56633 RVA: 0x0032A500 File Offset: 0x00328700
		public string TaskTitle
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DD3A RID: 56634 RVA: 0x0032A538 File Offset: 0x00328738
		public Span<byte> GetTaskTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600DD3B RID: 56635 RVA: 0x0032A548 File Offset: 0x00328748
		public byte[] GetTaskTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005256 RID: 21078
		private Table __p;
	}
}

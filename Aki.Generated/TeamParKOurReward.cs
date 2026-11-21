using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200124F RID: 4687
	public struct TeamParKOurReward : IFlatbufferObject
	{
		// Token: 0x17003D2E RID: 15662
		// (get) Token: 0x0600EA7A RID: 60026 RVA: 0x003554D5 File Offset: 0x003536D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EA7B RID: 60027 RVA: 0x003554E2 File Offset: 0x003536E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EA7C RID: 60028 RVA: 0x003554EC File Offset: 0x003536EC
		public static TeamParKOurReward GetRootAsTeamParKOurReward(ByteBuffer _bb)
		{
			return TeamParKOurReward.GetRootAsTeamParKOurReward(_bb, default(TeamParKOurReward));
		}

		// Token: 0x0600EA7D RID: 60029 RVA: 0x00355508 File Offset: 0x00353708
		public static TeamParKOurReward GetRootAsTeamParKOurReward(ByteBuffer _bb, TeamParKOurReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EA7E RID: 60030 RVA: 0x00355525 File Offset: 0x00353725
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EA7F RID: 60031 RVA: 0x00355534 File Offset: 0x00353734
		public TeamParKOurReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D2F RID: 15663
		// (get) Token: 0x0600EA80 RID: 60032 RVA: 0x00355544 File Offset: 0x00353744
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

		// Token: 0x17003D30 RID: 15664
		// (get) Token: 0x0600EA81 RID: 60033 RVA: 0x00355580 File Offset: 0x00353780
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

		// Token: 0x17003D31 RID: 15665
		// (get) Token: 0x0600EA82 RID: 60034 RVA: 0x003555BC File Offset: 0x003537BC
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

		// Token: 0x17003D32 RID: 15666
		// (get) Token: 0x0600EA83 RID: 60035 RVA: 0x003555F8 File Offset: 0x003537F8
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

		// Token: 0x17003D33 RID: 15667
		// (get) Token: 0x0600EA84 RID: 60036 RVA: 0x00355638 File Offset: 0x00353838
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

		// Token: 0x0600EA85 RID: 60037 RVA: 0x00355670 File Offset: 0x00353870
		public Span<byte> GetTaskTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600EA86 RID: 60038 RVA: 0x00355680 File Offset: 0x00353880
		public byte[] GetTaskTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005899 RID: 22681
		private Table __p;
	}
}

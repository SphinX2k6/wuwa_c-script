using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FCF RID: 4047
	public struct RiskHarvestScoreReward : IFlatbufferObject
	{
		// Token: 0x17002EAA RID: 11946
		// (get) Token: 0x0600BD9B RID: 48539 RVA: 0x002E1B1E File Offset: 0x002DFD1E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BD9C RID: 48540 RVA: 0x002E1B2B File Offset: 0x002DFD2B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BD9D RID: 48541 RVA: 0x002E1B34 File Offset: 0x002DFD34
		public static RiskHarvestScoreReward GetRootAsRiskHarvestScoreReward(ByteBuffer _bb)
		{
			return RiskHarvestScoreReward.GetRootAsRiskHarvestScoreReward(_bb, default(RiskHarvestScoreReward));
		}

		// Token: 0x0600BD9E RID: 48542 RVA: 0x002E1B50 File Offset: 0x002DFD50
		public static RiskHarvestScoreReward GetRootAsRiskHarvestScoreReward(ByteBuffer _bb, RiskHarvestScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BD9F RID: 48543 RVA: 0x002E1B6D File Offset: 0x002DFD6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BDA0 RID: 48544 RVA: 0x002E1B7C File Offset: 0x002DFD7C
		public RiskHarvestScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002EAB RID: 11947
		// (get) Token: 0x0600BDA1 RID: 48545 RVA: 0x002E1B8C File Offset: 0x002DFD8C
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

		// Token: 0x17002EAC RID: 11948
		// (get) Token: 0x0600BDA2 RID: 48546 RVA: 0x002E1BC8 File Offset: 0x002DFDC8
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

		// Token: 0x17002EAD RID: 11949
		// (get) Token: 0x0600BDA3 RID: 48547 RVA: 0x002E1C04 File Offset: 0x002DFE04
		public int Score
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

		// Token: 0x17002EAE RID: 11950
		// (get) Token: 0x0600BDA4 RID: 48548 RVA: 0x002E1C40 File Offset: 0x002DFE40
		public int Reward
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

		// Token: 0x17002EAF RID: 11951
		// (get) Token: 0x0600BDA5 RID: 48549 RVA: 0x002E1C80 File Offset: 0x002DFE80
		public string Desc
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

		// Token: 0x0600BDA6 RID: 48550 RVA: 0x002E1CB8 File Offset: 0x002DFEB8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BDA7 RID: 48551 RVA: 0x002E1CC8 File Offset: 0x002DFEC8
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040050AA RID: 20650
		private Table __p;
	}
}

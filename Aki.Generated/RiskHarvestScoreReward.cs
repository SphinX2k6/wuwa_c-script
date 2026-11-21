using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010B7 RID: 4279
	public struct RiskHarvestScoreReward : IFlatbufferObject
	{
		// Token: 0x17002F25 RID: 12069
		// (get) Token: 0x0600C3E5 RID: 50149 RVA: 0x002FE0EA File Offset: 0x002FC2EA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C3E6 RID: 50150 RVA: 0x002FE0F7 File Offset: 0x002FC2F7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C3E7 RID: 50151 RVA: 0x002FE100 File Offset: 0x002FC300
		public static RiskHarvestScoreReward GetRootAsRiskHarvestScoreReward(ByteBuffer _bb)
		{
			return RiskHarvestScoreReward.GetRootAsRiskHarvestScoreReward(_bb, default(RiskHarvestScoreReward));
		}

		// Token: 0x0600C3E8 RID: 50152 RVA: 0x002FE11C File Offset: 0x002FC31C
		public static RiskHarvestScoreReward GetRootAsRiskHarvestScoreReward(ByteBuffer _bb, RiskHarvestScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C3E9 RID: 50153 RVA: 0x002FE139 File Offset: 0x002FC339
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C3EA RID: 50154 RVA: 0x002FE148 File Offset: 0x002FC348
		public RiskHarvestScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F26 RID: 12070
		// (get) Token: 0x0600C3EB RID: 50155 RVA: 0x002FE158 File Offset: 0x002FC358
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

		// Token: 0x17002F27 RID: 12071
		// (get) Token: 0x0600C3EC RID: 50156 RVA: 0x002FE194 File Offset: 0x002FC394
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

		// Token: 0x17002F28 RID: 12072
		// (get) Token: 0x0600C3ED RID: 50157 RVA: 0x002FE1D0 File Offset: 0x002FC3D0
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

		// Token: 0x17002F29 RID: 12073
		// (get) Token: 0x0600C3EE RID: 50158 RVA: 0x002FE20C File Offset: 0x002FC40C
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

		// Token: 0x17002F2A RID: 12074
		// (get) Token: 0x0600C3EF RID: 50159 RVA: 0x002FE24C File Offset: 0x002FC44C
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

		// Token: 0x0600C3F0 RID: 50160 RVA: 0x002FE284 File Offset: 0x002FC484
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C3F1 RID: 50161 RVA: 0x002FE294 File Offset: 0x002FC494
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005692 RID: 22162
		private Table __p;
	}
}

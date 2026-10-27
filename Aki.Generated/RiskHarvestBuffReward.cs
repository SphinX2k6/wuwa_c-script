using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FCC RID: 4044
	public struct RiskHarvestBuffReward : IFlatbufferObject
	{
		// Token: 0x17002E89 RID: 11913
		// (get) Token: 0x0600BD53 RID: 48467 RVA: 0x002E1077 File Offset: 0x002DF277
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BD54 RID: 48468 RVA: 0x002E1084 File Offset: 0x002DF284
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BD55 RID: 48469 RVA: 0x002E108C File Offset: 0x002DF28C
		public static RiskHarvestBuffReward GetRootAsRiskHarvestBuffReward(ByteBuffer _bb)
		{
			return RiskHarvestBuffReward.GetRootAsRiskHarvestBuffReward(_bb, default(RiskHarvestBuffReward));
		}

		// Token: 0x0600BD56 RID: 48470 RVA: 0x002E10A8 File Offset: 0x002DF2A8
		public static RiskHarvestBuffReward GetRootAsRiskHarvestBuffReward(ByteBuffer _bb, RiskHarvestBuffReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BD57 RID: 48471 RVA: 0x002E10C5 File Offset: 0x002DF2C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BD58 RID: 48472 RVA: 0x002E10D4 File Offset: 0x002DF2D4
		public RiskHarvestBuffReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E8A RID: 11914
		// (get) Token: 0x0600BD59 RID: 48473 RVA: 0x002E10E4 File Offset: 0x002DF2E4
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

		// Token: 0x17002E8B RID: 11915
		// (get) Token: 0x0600BD5A RID: 48474 RVA: 0x002E1120 File Offset: 0x002DF320
		public int BuffType
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

		// Token: 0x17002E8C RID: 11916
		// (get) Token: 0x0600BD5B RID: 48475 RVA: 0x002E115C File Offset: 0x002DF35C
		public int Count
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

		// Token: 0x17002E8D RID: 11917
		// (get) Token: 0x0600BD5C RID: 48476 RVA: 0x002E1198 File Offset: 0x002DF398
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

		// Token: 0x17002E8E RID: 11918
		// (get) Token: 0x0600BD5D RID: 48477 RVA: 0x002E11D8 File Offset: 0x002DF3D8
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

		// Token: 0x0600BD5E RID: 48478 RVA: 0x002E1210 File Offset: 0x002DF410
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BD5F RID: 48479 RVA: 0x002E1220 File Offset: 0x002DF420
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040050A7 RID: 20647
		private Table __p;
	}
}

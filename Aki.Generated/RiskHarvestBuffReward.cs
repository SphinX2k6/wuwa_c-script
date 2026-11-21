using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010B4 RID: 4276
	public struct RiskHarvestBuffReward : IFlatbufferObject
	{
		// Token: 0x17002F04 RID: 12036
		// (get) Token: 0x0600C39D RID: 50077 RVA: 0x002FD663 File Offset: 0x002FB863
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C39E RID: 50078 RVA: 0x002FD670 File Offset: 0x002FB870
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C39F RID: 50079 RVA: 0x002FD678 File Offset: 0x002FB878
		public static RiskHarvestBuffReward GetRootAsRiskHarvestBuffReward(ByteBuffer _bb)
		{
			return RiskHarvestBuffReward.GetRootAsRiskHarvestBuffReward(_bb, default(RiskHarvestBuffReward));
		}

		// Token: 0x0600C3A0 RID: 50080 RVA: 0x002FD694 File Offset: 0x002FB894
		public static RiskHarvestBuffReward GetRootAsRiskHarvestBuffReward(ByteBuffer _bb, RiskHarvestBuffReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C3A1 RID: 50081 RVA: 0x002FD6B1 File Offset: 0x002FB8B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C3A2 RID: 50082 RVA: 0x002FD6C0 File Offset: 0x002FB8C0
		public RiskHarvestBuffReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F05 RID: 12037
		// (get) Token: 0x0600C3A3 RID: 50083 RVA: 0x002FD6D0 File Offset: 0x002FB8D0
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

		// Token: 0x17002F06 RID: 12038
		// (get) Token: 0x0600C3A4 RID: 50084 RVA: 0x002FD70C File Offset: 0x002FB90C
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

		// Token: 0x17002F07 RID: 12039
		// (get) Token: 0x0600C3A5 RID: 50085 RVA: 0x002FD748 File Offset: 0x002FB948
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

		// Token: 0x17002F08 RID: 12040
		// (get) Token: 0x0600C3A6 RID: 50086 RVA: 0x002FD784 File Offset: 0x002FB984
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

		// Token: 0x17002F09 RID: 12041
		// (get) Token: 0x0600C3A7 RID: 50087 RVA: 0x002FD7C4 File Offset: 0x002FB9C4
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

		// Token: 0x0600C3A8 RID: 50088 RVA: 0x002FD7FC File Offset: 0x002FB9FC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C3A9 RID: 50089 RVA: 0x002FD80C File Offset: 0x002FBA0C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0400568F RID: 22159
		private Table __p;
	}
}

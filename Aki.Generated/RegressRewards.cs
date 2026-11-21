using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200109B RID: 4251
	public struct RegressRewards : IFlatbufferObject
	{
		// Token: 0x17002E45 RID: 11845
		// (get) Token: 0x0600C187 RID: 49543 RVA: 0x002F9039 File Offset: 0x002F7239
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C188 RID: 49544 RVA: 0x002F9046 File Offset: 0x002F7246
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C189 RID: 49545 RVA: 0x002F9050 File Offset: 0x002F7250
		public static RegressRewards GetRootAsRegressRewards(ByteBuffer _bb)
		{
			return RegressRewards.GetRootAsRegressRewards(_bb, default(RegressRewards));
		}

		// Token: 0x0600C18A RID: 49546 RVA: 0x002F906C File Offset: 0x002F726C
		public static RegressRewards GetRootAsRegressRewards(ByteBuffer _bb, RegressRewards obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C18B RID: 49547 RVA: 0x002F9089 File Offset: 0x002F7289
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C18C RID: 49548 RVA: 0x002F9098 File Offset: 0x002F7298
		public RegressRewards __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E46 RID: 11846
		// (get) Token: 0x0600C18D RID: 49549 RVA: 0x002F90A8 File Offset: 0x002F72A8
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

		// Token: 0x17002E47 RID: 11847
		// (get) Token: 0x0600C18E RID: 49550 RVA: 0x002F90E4 File Offset: 0x002F72E4
		public int RewardGroup
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

		// Token: 0x04005674 RID: 22132
		private Table __p;
	}
}

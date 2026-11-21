using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010A5 RID: 4261
	public struct RewardConfig : IFlatbufferObject
	{
		// Token: 0x17002E8B RID: 11915
		// (get) Token: 0x0600C254 RID: 49748 RVA: 0x002FAB19 File Offset: 0x002F8D19
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C255 RID: 49749 RVA: 0x002FAB26 File Offset: 0x002F8D26
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C256 RID: 49750 RVA: 0x002FAB30 File Offset: 0x002F8D30
		public static RewardConfig GetRootAsRewardConfig(ByteBuffer _bb)
		{
			return RewardConfig.GetRootAsRewardConfig(_bb, default(RewardConfig));
		}

		// Token: 0x0600C257 RID: 49751 RVA: 0x002FAB4C File Offset: 0x002F8D4C
		public static RewardConfig GetRootAsRewardConfig(ByteBuffer _bb, RewardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C258 RID: 49752 RVA: 0x002FAB69 File Offset: 0x002F8D69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C259 RID: 49753 RVA: 0x002FAB78 File Offset: 0x002F8D78
		public RewardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E8C RID: 11916
		// (get) Token: 0x0600C25A RID: 49754 RVA: 0x002FAB88 File Offset: 0x002F8D88
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

		// Token: 0x17002E8D RID: 11917
		// (get) Token: 0x0600C25B RID: 49755 RVA: 0x002FABC4 File Offset: 0x002F8DC4
		public int Reward
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

		// Token: 0x0400567F RID: 22143
		private Table __p;
	}
}

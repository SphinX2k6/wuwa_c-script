using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FBD RID: 4029
	public struct RewardConfig : IFlatbufferObject
	{
		// Token: 0x17002E10 RID: 11792
		// (get) Token: 0x0600BC0A RID: 48138 RVA: 0x002DE401 File Offset: 0x002DC601
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BC0B RID: 48139 RVA: 0x002DE40E File Offset: 0x002DC60E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BC0C RID: 48140 RVA: 0x002DE418 File Offset: 0x002DC618
		public static RewardConfig GetRootAsRewardConfig(ByteBuffer _bb)
		{
			return RewardConfig.GetRootAsRewardConfig(_bb, default(RewardConfig));
		}

		// Token: 0x0600BC0D RID: 48141 RVA: 0x002DE434 File Offset: 0x002DC634
		public static RewardConfig GetRootAsRewardConfig(ByteBuffer _bb, RewardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BC0E RID: 48142 RVA: 0x002DE451 File Offset: 0x002DC651
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BC0F RID: 48143 RVA: 0x002DE460 File Offset: 0x002DC660
		public RewardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E11 RID: 11793
		// (get) Token: 0x0600BC10 RID: 48144 RVA: 0x002DE470 File Offset: 0x002DC670
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

		// Token: 0x17002E12 RID: 11794
		// (get) Token: 0x0600BC11 RID: 48145 RVA: 0x002DE4AC File Offset: 0x002DC6AC
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

		// Token: 0x04005097 RID: 20631
		private Table __p;
	}
}

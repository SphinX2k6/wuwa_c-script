using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B17 RID: 2839
	public struct AvoidBlockReward : IFlatbufferObject
	{
		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06004A15 RID: 18965 RVA: 0x001DB1DC File Offset: 0x001D93DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004A16 RID: 18966 RVA: 0x001DB1E9 File Offset: 0x001D93E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004A17 RID: 18967 RVA: 0x001DB1F0 File Offset: 0x001D93F0
		public static AvoidBlockReward GetRootAsAvoidBlockReward(ByteBuffer _bb)
		{
			return AvoidBlockReward.GetRootAsAvoidBlockReward(_bb, default(AvoidBlockReward));
		}

		// Token: 0x06004A18 RID: 18968 RVA: 0x001DB20C File Offset: 0x001D940C
		public static AvoidBlockReward GetRootAsAvoidBlockReward(ByteBuffer _bb, AvoidBlockReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004A19 RID: 18969 RVA: 0x001DB229 File Offset: 0x001D9429
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004A1A RID: 18970 RVA: 0x001DB238 File Offset: 0x001D9438
		public AvoidBlockReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06004A1B RID: 18971 RVA: 0x001DB248 File Offset: 0x001D9448
		public int RewardId
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

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06004A1C RID: 18972 RVA: 0x001DB284 File Offset: 0x001D9484
		public int RewardGroupId
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

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06004A1D RID: 18973 RVA: 0x001DB2C0 File Offset: 0x001D94C0
		public int TargetScore
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

		// Token: 0x04004AFF RID: 19199
		private Table __p;
	}
}

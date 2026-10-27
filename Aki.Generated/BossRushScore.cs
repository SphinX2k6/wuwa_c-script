using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B47 RID: 2887
	public struct BossRushScore : IFlatbufferObject
	{
		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06004F3F RID: 20287 RVA: 0x001E7D64 File Offset: 0x001E5F64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004F40 RID: 20288 RVA: 0x001E7D71 File Offset: 0x001E5F71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004F41 RID: 20289 RVA: 0x001E7D78 File Offset: 0x001E5F78
		public static BossRushScore GetRootAsBossRushScore(ByteBuffer _bb)
		{
			return BossRushScore.GetRootAsBossRushScore(_bb, default(BossRushScore));
		}

		// Token: 0x06004F42 RID: 20290 RVA: 0x001E7D94 File Offset: 0x001E5F94
		public static BossRushScore GetRootAsBossRushScore(ByteBuffer _bb, BossRushScore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004F43 RID: 20291 RVA: 0x001E7DB1 File Offset: 0x001E5FB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004F44 RID: 20292 RVA: 0x001E7DC0 File Offset: 0x001E5FC0
		public BossRushScore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06004F45 RID: 20293 RVA: 0x001E7DD0 File Offset: 0x001E5FD0
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

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06004F46 RID: 20294 RVA: 0x001E7E0C File Offset: 0x001E600C
		public int Score
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

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06004F47 RID: 20295 RVA: 0x001E7E48 File Offset: 0x001E6048
		public int RewardId
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

		// Token: 0x04004B42 RID: 19266
		private Table __p;
	}
}

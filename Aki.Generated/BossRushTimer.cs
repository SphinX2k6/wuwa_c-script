using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B4A RID: 2890
	public struct BossRushTimer : IFlatbufferObject
	{
		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06004F63 RID: 20323 RVA: 0x001E81E8 File Offset: 0x001E63E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004F64 RID: 20324 RVA: 0x001E81F5 File Offset: 0x001E63F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004F65 RID: 20325 RVA: 0x001E81FC File Offset: 0x001E63FC
		public static BossRushTimer GetRootAsBossRushTimer(ByteBuffer _bb)
		{
			return BossRushTimer.GetRootAsBossRushTimer(_bb, default(BossRushTimer));
		}

		// Token: 0x06004F66 RID: 20326 RVA: 0x001E8218 File Offset: 0x001E6418
		public static BossRushTimer GetRootAsBossRushTimer(ByteBuffer _bb, BossRushTimer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004F67 RID: 20327 RVA: 0x001E8235 File Offset: 0x001E6435
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004F68 RID: 20328 RVA: 0x001E8244 File Offset: 0x001E6444
		public BossRushTimer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06004F69 RID: 20329 RVA: 0x001E8254 File Offset: 0x001E6454
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

		// Token: 0x04004B45 RID: 19269
		private Table __p;
	}
}

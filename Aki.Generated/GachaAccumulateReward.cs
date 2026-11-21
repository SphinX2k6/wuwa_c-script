using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DC2 RID: 3522
	public struct GachaAccumulateReward : IFlatbufferObject
	{
		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x06007E0C RID: 32268 RVA: 0x00264529 File Offset: 0x00262729
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007E0D RID: 32269 RVA: 0x00264536 File Offset: 0x00262736
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007E0E RID: 32270 RVA: 0x00264540 File Offset: 0x00262740
		public static GachaAccumulateReward GetRootAsGachaAccumulateReward(ByteBuffer _bb)
		{
			return GachaAccumulateReward.GetRootAsGachaAccumulateReward(_bb, default(GachaAccumulateReward));
		}

		// Token: 0x06007E0F RID: 32271 RVA: 0x0026455C File Offset: 0x0026275C
		public static GachaAccumulateReward GetRootAsGachaAccumulateReward(ByteBuffer _bb, GachaAccumulateReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007E10 RID: 32272 RVA: 0x00264579 File Offset: 0x00262779
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007E11 RID: 32273 RVA: 0x00264588 File Offset: 0x00262788
		public GachaAccumulateReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x06007E12 RID: 32274 RVA: 0x00264598 File Offset: 0x00262798
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

		// Token: 0x04005333 RID: 21299
		private Table __p;
	}
}

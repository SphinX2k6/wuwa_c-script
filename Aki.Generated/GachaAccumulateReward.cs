using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CDE RID: 3294
	public struct GachaAccumulateReward : IFlatbufferObject
	{
		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x06007801 RID: 30721 RVA: 0x002459AD File Offset: 0x00243BAD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007802 RID: 30722 RVA: 0x002459BA File Offset: 0x00243BBA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007803 RID: 30723 RVA: 0x002459C4 File Offset: 0x00243BC4
		public static GachaAccumulateReward GetRootAsGachaAccumulateReward(ByteBuffer _bb)
		{
			return GachaAccumulateReward.GetRootAsGachaAccumulateReward(_bb, default(GachaAccumulateReward));
		}

		// Token: 0x06007804 RID: 30724 RVA: 0x002459E0 File Offset: 0x00243BE0
		public static GachaAccumulateReward GetRootAsGachaAccumulateReward(ByteBuffer _bb, GachaAccumulateReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007805 RID: 30725 RVA: 0x002459FD File Offset: 0x00243BFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007806 RID: 30726 RVA: 0x00245A0C File Offset: 0x00243C0C
		public GachaAccumulateReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x06007807 RID: 30727 RVA: 0x00245A1C File Offset: 0x00243C1C
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

		// Token: 0x04004D4F RID: 19791
		private Table __p;
	}
}

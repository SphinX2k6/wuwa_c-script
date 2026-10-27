using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D13 RID: 3347
	public struct GuessJokerPlotConfig : IFlatbufferObject
	{
		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x06007C46 RID: 31814 RVA: 0x0024F34C File Offset: 0x0024D54C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007C47 RID: 31815 RVA: 0x0024F359 File Offset: 0x0024D559
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007C48 RID: 31816 RVA: 0x0024F360 File Offset: 0x0024D560
		public static GuessJokerPlotConfig GetRootAsGuessJokerPlotConfig(ByteBuffer _bb)
		{
			return GuessJokerPlotConfig.GetRootAsGuessJokerPlotConfig(_bb, default(GuessJokerPlotConfig));
		}

		// Token: 0x06007C49 RID: 31817 RVA: 0x0024F37C File Offset: 0x0024D57C
		public static GuessJokerPlotConfig GetRootAsGuessJokerPlotConfig(ByteBuffer _bb, GuessJokerPlotConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007C4A RID: 31818 RVA: 0x0024F399 File Offset: 0x0024D599
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007C4B RID: 31819 RVA: 0x0024F3A8 File Offset: 0x0024D5A8
		public GuessJokerPlotConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x06007C4C RID: 31820 RVA: 0x0024F3B8 File Offset: 0x0024D5B8
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

		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x06007C4D RID: 31821 RVA: 0x0024F3F4 File Offset: 0x0024D5F4
		public string FlowListName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007C4E RID: 31822 RVA: 0x0024F42B File Offset: 0x0024D62B
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007C4F RID: 31823 RVA: 0x0024F43A File Offset: 0x0024D63A
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x06007C50 RID: 31824 RVA: 0x0024F454 File Offset: 0x0024D654
		public int FlowId
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

		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x06007C51 RID: 31825 RVA: 0x0024F490 File Offset: 0x0024D690
		public int StateId
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

		// Token: 0x04004D8B RID: 19851
		private Table __p;
	}
}

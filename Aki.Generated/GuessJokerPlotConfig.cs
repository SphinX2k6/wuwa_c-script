using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DF8 RID: 3576
	public struct GuessJokerPlotConfig : IFlatbufferObject
	{
		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x0600825E RID: 33374 RVA: 0x0026DD6C File Offset: 0x0026BF6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600825F RID: 33375 RVA: 0x0026DD79 File Offset: 0x0026BF79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008260 RID: 33376 RVA: 0x0026DD80 File Offset: 0x0026BF80
		public static GuessJokerPlotConfig GetRootAsGuessJokerPlotConfig(ByteBuffer _bb)
		{
			return GuessJokerPlotConfig.GetRootAsGuessJokerPlotConfig(_bb, default(GuessJokerPlotConfig));
		}

		// Token: 0x06008261 RID: 33377 RVA: 0x0026DD9C File Offset: 0x0026BF9C
		public static GuessJokerPlotConfig GetRootAsGuessJokerPlotConfig(ByteBuffer _bb, GuessJokerPlotConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008262 RID: 33378 RVA: 0x0026DDB9 File Offset: 0x0026BFB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008263 RID: 33379 RVA: 0x0026DDC8 File Offset: 0x0026BFC8
		public GuessJokerPlotConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x06008264 RID: 33380 RVA: 0x0026DDD8 File Offset: 0x0026BFD8
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

		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x06008265 RID: 33381 RVA: 0x0026DE14 File Offset: 0x0026C014
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

		// Token: 0x06008266 RID: 33382 RVA: 0x0026DE4B File Offset: 0x0026C04B
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008267 RID: 33383 RVA: 0x0026DE5A File Offset: 0x0026C05A
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x06008268 RID: 33384 RVA: 0x0026DE74 File Offset: 0x0026C074
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

		// Token: 0x170016A2 RID: 5794
		// (get) Token: 0x06008269 RID: 33385 RVA: 0x0026DEB0 File Offset: 0x0026C0B0
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

		// Token: 0x04005370 RID: 21360
		private Table __p;
	}
}

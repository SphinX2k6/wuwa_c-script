using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DA9 RID: 3497
	public struct FlowText : IFlatbufferObject
	{
		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x06007B96 RID: 31638 RVA: 0x0025EFA4 File Offset: 0x0025D1A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007B97 RID: 31639 RVA: 0x0025EFB1 File Offset: 0x0025D1B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007B98 RID: 31640 RVA: 0x0025EFB8 File Offset: 0x0025D1B8
		public static FlowText GetRootAsFlowText(ByteBuffer _bb)
		{
			return FlowText.GetRootAsFlowText(_bb, default(FlowText));
		}

		// Token: 0x06007B99 RID: 31641 RVA: 0x0025EFD4 File Offset: 0x0025D1D4
		public static FlowText GetRootAsFlowText(ByteBuffer _bb, FlowText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007B9A RID: 31642 RVA: 0x0025EFF1 File Offset: 0x0025D1F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007B9B RID: 31643 RVA: 0x0025F000 File Offset: 0x0025D200
		public FlowText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x06007B9C RID: 31644 RVA: 0x0025F010 File Offset: 0x0025D210
		public long Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x06007B9D RID: 31645 RVA: 0x0025F050 File Offset: 0x0025D250
		public string FlowListId
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

		// Token: 0x06007B9E RID: 31646 RVA: 0x0025F087 File Offset: 0x0025D287
		public Span<byte> GetFlowListIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007B9F RID: 31647 RVA: 0x0025F096 File Offset: 0x0025D296
		public byte[] GetFlowListIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x06007BA0 RID: 31648 RVA: 0x0025F0B0 File Offset: 0x0025D2B0
		public string PlotLineId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007BA1 RID: 31649 RVA: 0x0025F0E7 File Offset: 0x0025D2E7
		public Span<byte> GetPlotLineIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007BA2 RID: 31650 RVA: 0x0025F0F6 File Offset: 0x0025D2F6
		public byte[] GetPlotLineIdArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x06007BA3 RID: 31651 RVA: 0x0025F110 File Offset: 0x0025D310
		public int Id
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

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x06007BA4 RID: 31652 RVA: 0x0025F150 File Offset: 0x0025D350
		public int Text
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x06007BA5 RID: 31653 RVA: 0x0025F190 File Offset: 0x0025D390
		public string Sound
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007BA6 RID: 31654 RVA: 0x0025F1C8 File Offset: 0x0025D3C8
		public Span<byte> GetSoundBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007BA7 RID: 31655 RVA: 0x0025F1D8 File Offset: 0x0025D3D8
		public byte[] GetSoundArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x06007BA8 RID: 31656 RVA: 0x0025F1F0 File Offset: 0x0025D3F0
		public string EsKey
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007BA9 RID: 31657 RVA: 0x0025F228 File Offset: 0x0025D428
		public Span<byte> GetEsKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007BAA RID: 31658 RVA: 0x0025F238 File Offset: 0x0025D438
		public byte[] GetEsKeyArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005319 RID: 21273
		private Table __p;
	}
}

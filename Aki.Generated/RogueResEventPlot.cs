using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010EB RID: 4331
	public struct RogueResEventPlot : IFlatbufferObject
	{
		// Token: 0x170030C7 RID: 12487
		// (get) Token: 0x0600C8AA RID: 51370 RVA: 0x00308708 File Offset: 0x00306908
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C8AB RID: 51371 RVA: 0x00308715 File Offset: 0x00306915
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C8AC RID: 51372 RVA: 0x0030871C File Offset: 0x0030691C
		public static RogueResEventPlot GetRootAsRogueResEventPlot(ByteBuffer _bb)
		{
			return RogueResEventPlot.GetRootAsRogueResEventPlot(_bb, default(RogueResEventPlot));
		}

		// Token: 0x0600C8AD RID: 51373 RVA: 0x00308738 File Offset: 0x00306938
		public static RogueResEventPlot GetRootAsRogueResEventPlot(ByteBuffer _bb, RogueResEventPlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C8AE RID: 51374 RVA: 0x00308755 File Offset: 0x00306955
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C8AF RID: 51375 RVA: 0x00308764 File Offset: 0x00306964
		public RogueResEventPlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030C8 RID: 12488
		// (get) Token: 0x0600C8B0 RID: 51376 RVA: 0x00308774 File Offset: 0x00306974
		public int PlotId
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

		// Token: 0x170030C9 RID: 12489
		// (get) Token: 0x0600C8B1 RID: 51377 RVA: 0x003087B0 File Offset: 0x003069B0
		public string Title
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

		// Token: 0x0600C8B2 RID: 51378 RVA: 0x003087E7 File Offset: 0x003069E7
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C8B3 RID: 51379 RVA: 0x003087F6 File Offset: 0x003069F6
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170030CA RID: 12490
		// (get) Token: 0x0600C8B4 RID: 51380 RVA: 0x00308810 File Offset: 0x00306A10
		public int BgResource
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

		// Token: 0x040056D3 RID: 22227
		private Table __p;
	}
}

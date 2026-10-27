using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001003 RID: 4099
	public struct RogueResEventPlot : IFlatbufferObject
	{
		// Token: 0x1700304C RID: 12364
		// (get) Token: 0x0600C260 RID: 49760 RVA: 0x002EC4DC File Offset: 0x002EA6DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C261 RID: 49761 RVA: 0x002EC4E9 File Offset: 0x002EA6E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C262 RID: 49762 RVA: 0x002EC4F0 File Offset: 0x002EA6F0
		public static RogueResEventPlot GetRootAsRogueResEventPlot(ByteBuffer _bb)
		{
			return RogueResEventPlot.GetRootAsRogueResEventPlot(_bb, default(RogueResEventPlot));
		}

		// Token: 0x0600C263 RID: 49763 RVA: 0x002EC50C File Offset: 0x002EA70C
		public static RogueResEventPlot GetRootAsRogueResEventPlot(ByteBuffer _bb, RogueResEventPlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C264 RID: 49764 RVA: 0x002EC529 File Offset: 0x002EA729
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C265 RID: 49765 RVA: 0x002EC538 File Offset: 0x002EA738
		public RogueResEventPlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700304D RID: 12365
		// (get) Token: 0x0600C266 RID: 49766 RVA: 0x002EC548 File Offset: 0x002EA748
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

		// Token: 0x1700304E RID: 12366
		// (get) Token: 0x0600C267 RID: 49767 RVA: 0x002EC584 File Offset: 0x002EA784
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

		// Token: 0x0600C268 RID: 49768 RVA: 0x002EC5BB File Offset: 0x002EA7BB
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C269 RID: 49769 RVA: 0x002EC5CA File Offset: 0x002EA7CA
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700304F RID: 12367
		// (get) Token: 0x0600C26A RID: 49770 RVA: 0x002EC5E4 File Offset: 0x002EA7E4
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

		// Token: 0x040050EB RID: 20715
		private Table __p;
	}
}

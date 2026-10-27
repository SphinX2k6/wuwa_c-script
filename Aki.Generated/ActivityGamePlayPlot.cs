using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AC3 RID: 2755
	public struct ActivityGamePlayPlot : IFlatbufferObject
	{
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06004340 RID: 17216 RVA: 0x001CBE09 File Offset: 0x001CA009
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x001CBE16 File Offset: 0x001CA016
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x001CBE20 File Offset: 0x001CA020
		public static ActivityGamePlayPlot GetRootAsActivityGamePlayPlot(ByteBuffer _bb)
		{
			return ActivityGamePlayPlot.GetRootAsActivityGamePlayPlot(_bb, default(ActivityGamePlayPlot));
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x001CBE3C File Offset: 0x001CA03C
		public static ActivityGamePlayPlot GetRootAsActivityGamePlayPlot(ByteBuffer _bb, ActivityGamePlayPlot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004344 RID: 17220 RVA: 0x001CBE59 File Offset: 0x001CA059
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x001CBE68 File Offset: 0x001CA068
		public ActivityGamePlayPlot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06004346 RID: 17222 RVA: 0x001CBE78 File Offset: 0x001CA078
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

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06004347 RID: 17223 RVA: 0x001CBEB4 File Offset: 0x001CA0B4
		public string Name
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

		// Token: 0x06004348 RID: 17224 RVA: 0x001CBEEB File Offset: 0x001CA0EB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004349 RID: 17225 RVA: 0x001CBEFA File Offset: 0x001CA0FA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600434A RID: 17226 RVA: 0x001CBF14 File Offset: 0x001CA114
		public string Icon
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

		// Token: 0x0600434B RID: 17227 RVA: 0x001CBF4B File Offset: 0x001CA14B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600434C RID: 17228 RVA: 0x001CBF5A File Offset: 0x001CA15A
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600434D RID: 17229 RVA: 0x001CBF74 File Offset: 0x001CA174
		public int HelpId
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

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600434E RID: 17230 RVA: 0x001CBFB4 File Offset: 0x001CA1B4
		public bool NeedClose
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004A9F RID: 19103
		private Table __p;
	}
}

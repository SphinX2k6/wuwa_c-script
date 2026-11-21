using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D9C RID: 3484
	public struct FloroRanchTaskTab : IFlatbufferObject
	{
		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x06007AAE RID: 31406 RVA: 0x0025D051 File Offset: 0x0025B251
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007AAF RID: 31407 RVA: 0x0025D05E File Offset: 0x0025B25E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007AB0 RID: 31408 RVA: 0x0025D068 File Offset: 0x0025B268
		public static FloroRanchTaskTab GetRootAsFloroRanchTaskTab(ByteBuffer _bb)
		{
			return FloroRanchTaskTab.GetRootAsFloroRanchTaskTab(_bb, default(FloroRanchTaskTab));
		}

		// Token: 0x06007AB1 RID: 31409 RVA: 0x0025D084 File Offset: 0x0025B284
		public static FloroRanchTaskTab GetRootAsFloroRanchTaskTab(ByteBuffer _bb, FloroRanchTaskTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007AB2 RID: 31410 RVA: 0x0025D0A1 File Offset: 0x0025B2A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007AB3 RID: 31411 RVA: 0x0025D0B0 File Offset: 0x0025B2B0
		public FloroRanchTaskTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x06007AB4 RID: 31412 RVA: 0x0025D0C0 File Offset: 0x0025B2C0
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

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x06007AB5 RID: 31413 RVA: 0x0025D0FC File Offset: 0x0025B2FC
		public string TabName
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

		// Token: 0x06007AB6 RID: 31414 RVA: 0x0025D133 File Offset: 0x0025B333
		public Span<byte> GetTabNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007AB7 RID: 31415 RVA: 0x0025D142 File Offset: 0x0025B342
		public byte[] GetTabNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x06007AB8 RID: 31416 RVA: 0x0025D15C File Offset: 0x0025B35C
		public int Sort
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

		// Token: 0x04005309 RID: 21257
		private Table __p;
	}
}

using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010E3 RID: 4323
	public struct RogueResEffect : IFlatbufferObject
	{
		// Token: 0x1700308B RID: 12427
		// (get) Token: 0x0600C807 RID: 51207 RVA: 0x003072C9 File Offset: 0x003054C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C808 RID: 51208 RVA: 0x003072D6 File Offset: 0x003054D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C809 RID: 51209 RVA: 0x003072E0 File Offset: 0x003054E0
		public static RogueResEffect GetRootAsRogueResEffect(ByteBuffer _bb)
		{
			return RogueResEffect.GetRootAsRogueResEffect(_bb, default(RogueResEffect));
		}

		// Token: 0x0600C80A RID: 51210 RVA: 0x003072FC File Offset: 0x003054FC
		public static RogueResEffect GetRootAsRogueResEffect(ByteBuffer _bb, RogueResEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C80B RID: 51211 RVA: 0x00307319 File Offset: 0x00305519
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C80C RID: 51212 RVA: 0x00307328 File Offset: 0x00305528
		public RogueResEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700308C RID: 12428
		// (get) Token: 0x0600C80D RID: 51213 RVA: 0x00307338 File Offset: 0x00305538
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

		// Token: 0x1700308D RID: 12429
		// (get) Token: 0x0600C80E RID: 51214 RVA: 0x00307374 File Offset: 0x00305574
		public int Tag
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700308E RID: 12430
		// (get) Token: 0x0600C80F RID: 51215 RVA: 0x003073B0 File Offset: 0x003055B0
		public int DescIntParam
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

		// Token: 0x1700308F RID: 12431
		// (get) Token: 0x0600C810 RID: 51216 RVA: 0x003073EC File Offset: 0x003055EC
		public string DescParam
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C811 RID: 51217 RVA: 0x00307424 File Offset: 0x00305624
		public Span<byte> GetDescParamBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C812 RID: 51218 RVA: 0x00307434 File Offset: 0x00305634
		public byte[] GetDescParamArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040056CB RID: 22219
		private Table __p;
	}
}

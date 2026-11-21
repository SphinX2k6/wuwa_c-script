using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010E1 RID: 4321
	public struct RogueResDeliveryRule : IFlatbufferObject
	{
		// Token: 0x1700307B RID: 12411
		// (get) Token: 0x0600C7D8 RID: 51160 RVA: 0x00306D12 File Offset: 0x00304F12
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C7D9 RID: 51161 RVA: 0x00306D1F File Offset: 0x00304F1F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C7DA RID: 51162 RVA: 0x00306D28 File Offset: 0x00304F28
		public static RogueResDeliveryRule GetRootAsRogueResDeliveryRule(ByteBuffer _bb)
		{
			return RogueResDeliveryRule.GetRootAsRogueResDeliveryRule(_bb, default(RogueResDeliveryRule));
		}

		// Token: 0x0600C7DB RID: 51163 RVA: 0x00306D44 File Offset: 0x00304F44
		public static RogueResDeliveryRule GetRootAsRogueResDeliveryRule(ByteBuffer _bb, RogueResDeliveryRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C7DC RID: 51164 RVA: 0x00306D61 File Offset: 0x00304F61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C7DD RID: 51165 RVA: 0x00306D70 File Offset: 0x00304F70
		public RogueResDeliveryRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700307C RID: 12412
		// (get) Token: 0x0600C7DE RID: 51166 RVA: 0x00306D80 File Offset: 0x00304F80
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

		// Token: 0x1700307D RID: 12413
		// (get) Token: 0x0600C7DF RID: 51167 RVA: 0x00306DBC File Offset: 0x00304FBC
		public int Type
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

		// Token: 0x0600C7E0 RID: 51168 RVA: 0x00306DF8 File Offset: 0x00304FF8
		public int Insts(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700307E RID: 12414
		// (get) Token: 0x0600C7E1 RID: 51169 RVA: 0x00306E38 File Offset: 0x00305038
		public int InstsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C7E2 RID: 51170 RVA: 0x00306E63 File Offset: 0x00305063
		public Span<int> GetInstsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C7E3 RID: 51171 RVA: 0x00306E72 File Offset: 0x00305072
		public int[] GetInstsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600C7E4 RID: 51172 RVA: 0x00306E89 File Offset: 0x00305089
		[NullableContext(1)]
		public int[] Insts()
		{
			return this.GetInstsArray();
		}

		// Token: 0x0600C7E5 RID: 51173 RVA: 0x00306E91 File Offset: 0x00305091
		[NullableContext(1)]
		public IEnumerable<int> InstsIter()
		{
			RogueResDeliveryRule.<InstsIter>d__18 <InstsIter>d__ = new RogueResDeliveryRule.<InstsIter>d__18(-2);
			<InstsIter>d__.<>3__<>4__this = this;
			return <InstsIter>d__;
		}

		// Token: 0x040056C9 RID: 22217
		private Table __p;
	}
}

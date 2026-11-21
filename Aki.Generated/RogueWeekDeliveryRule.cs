using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001110 RID: 4368
	public struct RogueWeekDeliveryRule : IFlatbufferObject
	{
		// Token: 0x170031CE RID: 12750
		// (get) Token: 0x0600CBDA RID: 52186 RVA: 0x0030F550 File Offset: 0x0030D750
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CBDB RID: 52187 RVA: 0x0030F55D File Offset: 0x0030D75D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CBDC RID: 52188 RVA: 0x0030F564 File Offset: 0x0030D764
		public static RogueWeekDeliveryRule GetRootAsRogueWeekDeliveryRule(ByteBuffer _bb)
		{
			return RogueWeekDeliveryRule.GetRootAsRogueWeekDeliveryRule(_bb, default(RogueWeekDeliveryRule));
		}

		// Token: 0x0600CBDD RID: 52189 RVA: 0x0030F580 File Offset: 0x0030D780
		public static RogueWeekDeliveryRule GetRootAsRogueWeekDeliveryRule(ByteBuffer _bb, RogueWeekDeliveryRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CBDE RID: 52190 RVA: 0x0030F59D File Offset: 0x0030D79D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CBDF RID: 52191 RVA: 0x0030F5AC File Offset: 0x0030D7AC
		public RogueWeekDeliveryRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031CF RID: 12751
		// (get) Token: 0x0600CBE0 RID: 52192 RVA: 0x0030F5BC File Offset: 0x0030D7BC
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

		// Token: 0x170031D0 RID: 12752
		// (get) Token: 0x0600CBE1 RID: 52193 RVA: 0x0030F5F8 File Offset: 0x0030D7F8
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

		// Token: 0x0600CBE2 RID: 52194 RVA: 0x0030F634 File Offset: 0x0030D834
		public int Insts(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170031D1 RID: 12753
		// (get) Token: 0x0600CBE3 RID: 52195 RVA: 0x0030F674 File Offset: 0x0030D874
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

		// Token: 0x0600CBE4 RID: 52196 RVA: 0x0030F69F File Offset: 0x0030D89F
		public Span<int> GetInstsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600CBE5 RID: 52197 RVA: 0x0030F6AE File Offset: 0x0030D8AE
		public int[] GetInstsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600CBE6 RID: 52198 RVA: 0x0030F6C5 File Offset: 0x0030D8C5
		[NullableContext(1)]
		public int[] Insts()
		{
			return this.GetInstsArray();
		}

		// Token: 0x0600CBE7 RID: 52199 RVA: 0x0030F6CD File Offset: 0x0030D8CD
		[NullableContext(1)]
		public IEnumerable<int> InstsIter()
		{
			RogueWeekDeliveryRule.<InstsIter>d__18 <InstsIter>d__ = new RogueWeekDeliveryRule.<InstsIter>d__18(-2);
			<InstsIter>d__.<>3__<>4__this = this;
			return <InstsIter>d__;
		}

		// Token: 0x04005703 RID: 22275
		private Table __p;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010C6 RID: 4294
	public struct RogueDeliveryRule : IFlatbufferObject
	{
		// Token: 0x17002F9B RID: 12187
		// (get) Token: 0x0600C51F RID: 50463 RVA: 0x00300BC6 File Offset: 0x002FEDC6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C520 RID: 50464 RVA: 0x00300BD3 File Offset: 0x002FEDD3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C521 RID: 50465 RVA: 0x00300BDC File Offset: 0x002FEDDC
		public static RogueDeliveryRule GetRootAsRogueDeliveryRule(ByteBuffer _bb)
		{
			return RogueDeliveryRule.GetRootAsRogueDeliveryRule(_bb, default(RogueDeliveryRule));
		}

		// Token: 0x0600C522 RID: 50466 RVA: 0x00300BF8 File Offset: 0x002FEDF8
		public static RogueDeliveryRule GetRootAsRogueDeliveryRule(ByteBuffer _bb, RogueDeliveryRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C523 RID: 50467 RVA: 0x00300C15 File Offset: 0x002FEE15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C524 RID: 50468 RVA: 0x00300C24 File Offset: 0x002FEE24
		public RogueDeliveryRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F9C RID: 12188
		// (get) Token: 0x0600C525 RID: 50469 RVA: 0x00300C34 File Offset: 0x002FEE34
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

		// Token: 0x17002F9D RID: 12189
		// (get) Token: 0x0600C526 RID: 50470 RVA: 0x00300C70 File Offset: 0x002FEE70
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

		// Token: 0x0600C527 RID: 50471 RVA: 0x00300CAC File Offset: 0x002FEEAC
		public int Insts(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F9E RID: 12190
		// (get) Token: 0x0600C528 RID: 50472 RVA: 0x00300CEC File Offset: 0x002FEEEC
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

		// Token: 0x0600C529 RID: 50473 RVA: 0x00300D17 File Offset: 0x002FEF17
		public Span<int> GetInstsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C52A RID: 50474 RVA: 0x00300D26 File Offset: 0x002FEF26
		public int[] GetInstsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600C52B RID: 50475 RVA: 0x00300D3D File Offset: 0x002FEF3D
		[NullableContext(1)]
		public int[] Insts()
		{
			return this.GetInstsArray();
		}

		// Token: 0x0600C52C RID: 50476 RVA: 0x00300D45 File Offset: 0x002FEF45
		[NullableContext(1)]
		public IEnumerable<int> InstsIter()
		{
			RogueDeliveryRule.<InstsIter>d__18 <InstsIter>d__ = new RogueDeliveryRule.<InstsIter>d__18(-2);
			<InstsIter>d__.<>3__<>4__this = this;
			return <InstsIter>d__;
		}

		// Token: 0x040056A3 RID: 22179
		private Table __p;
	}
}

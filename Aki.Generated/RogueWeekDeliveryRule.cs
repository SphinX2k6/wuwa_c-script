using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001028 RID: 4136
	public struct RogueWeekDeliveryRule : IFlatbufferObject
	{
		// Token: 0x17003153 RID: 12627
		// (get) Token: 0x0600C590 RID: 50576 RVA: 0x002F35A4 File Offset: 0x002F17A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C591 RID: 50577 RVA: 0x002F35B1 File Offset: 0x002F17B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C592 RID: 50578 RVA: 0x002F35B8 File Offset: 0x002F17B8
		public static RogueWeekDeliveryRule GetRootAsRogueWeekDeliveryRule(ByteBuffer _bb)
		{
			return RogueWeekDeliveryRule.GetRootAsRogueWeekDeliveryRule(_bb, default(RogueWeekDeliveryRule));
		}

		// Token: 0x0600C593 RID: 50579 RVA: 0x002F35D4 File Offset: 0x002F17D4
		public static RogueWeekDeliveryRule GetRootAsRogueWeekDeliveryRule(ByteBuffer _bb, RogueWeekDeliveryRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C594 RID: 50580 RVA: 0x002F35F1 File Offset: 0x002F17F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C595 RID: 50581 RVA: 0x002F3600 File Offset: 0x002F1800
		public RogueWeekDeliveryRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003154 RID: 12628
		// (get) Token: 0x0600C596 RID: 50582 RVA: 0x002F3610 File Offset: 0x002F1810
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

		// Token: 0x17003155 RID: 12629
		// (get) Token: 0x0600C597 RID: 50583 RVA: 0x002F364C File Offset: 0x002F184C
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

		// Token: 0x0600C598 RID: 50584 RVA: 0x002F3688 File Offset: 0x002F1888
		public int Insts(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003156 RID: 12630
		// (get) Token: 0x0600C599 RID: 50585 RVA: 0x002F36C8 File Offset: 0x002F18C8
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

		// Token: 0x0600C59A RID: 50586 RVA: 0x002F36F3 File Offset: 0x002F18F3
		public Span<int> GetInstsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C59B RID: 50587 RVA: 0x002F3702 File Offset: 0x002F1902
		public int[] GetInstsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600C59C RID: 50588 RVA: 0x002F371C File Offset: 0x002F191C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InstsIter()或GetInstsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Insts()
		{
			RogueWeekDeliveryRule rogueWeekDeliveryRule = this;
			return rogueWeekDeliveryRule.GetInstsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C59D RID: 50589 RVA: 0x002F3740 File Offset: 0x002F1940
		[NullableContext(1)]
		public readonly IEnumerable<int> InstsIter()
		{
			RogueWeekDeliveryRule.<InstsIter>d__18 <InstsIter>d__ = new RogueWeekDeliveryRule.<InstsIter>d__18(-2);
			<InstsIter>d__.<>3__<>4__this = this;
			return <InstsIter>d__;
		}

		// Token: 0x0400511B RID: 20763
		private Table __p;
	}
}

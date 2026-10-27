using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FF9 RID: 4089
	public struct RogueResDeliveryRule : IFlatbufferObject
	{
		// Token: 0x17003000 RID: 12288
		// (get) Token: 0x0600C18E RID: 49550 RVA: 0x002EAAA9 File Offset: 0x002E8CA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C18F RID: 49551 RVA: 0x002EAAB6 File Offset: 0x002E8CB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C190 RID: 49552 RVA: 0x002EAAC0 File Offset: 0x002E8CC0
		public static RogueResDeliveryRule GetRootAsRogueResDeliveryRule(ByteBuffer _bb)
		{
			return RogueResDeliveryRule.GetRootAsRogueResDeliveryRule(_bb, default(RogueResDeliveryRule));
		}

		// Token: 0x0600C191 RID: 49553 RVA: 0x002EAADC File Offset: 0x002E8CDC
		public static RogueResDeliveryRule GetRootAsRogueResDeliveryRule(ByteBuffer _bb, RogueResDeliveryRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C192 RID: 49554 RVA: 0x002EAAF9 File Offset: 0x002E8CF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C193 RID: 49555 RVA: 0x002EAB08 File Offset: 0x002E8D08
		public RogueResDeliveryRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003001 RID: 12289
		// (get) Token: 0x0600C194 RID: 49556 RVA: 0x002EAB18 File Offset: 0x002E8D18
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

		// Token: 0x17003002 RID: 12290
		// (get) Token: 0x0600C195 RID: 49557 RVA: 0x002EAB54 File Offset: 0x002E8D54
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

		// Token: 0x0600C196 RID: 49558 RVA: 0x002EAB90 File Offset: 0x002E8D90
		public int Insts(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003003 RID: 12291
		// (get) Token: 0x0600C197 RID: 49559 RVA: 0x002EABD0 File Offset: 0x002E8DD0
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

		// Token: 0x0600C198 RID: 49560 RVA: 0x002EABFB File Offset: 0x002E8DFB
		public Span<int> GetInstsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C199 RID: 49561 RVA: 0x002EAC0A File Offset: 0x002E8E0A
		public int[] GetInstsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600C19A RID: 49562 RVA: 0x002EAC24 File Offset: 0x002E8E24
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InstsIter()或GetInstsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Insts()
		{
			RogueResDeliveryRule rogueResDeliveryRule = this;
			return rogueResDeliveryRule.GetInstsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C19B RID: 49563 RVA: 0x002EAC48 File Offset: 0x002E8E48
		[NullableContext(1)]
		public readonly IEnumerable<int> InstsIter()
		{
			RogueResDeliveryRule.<InstsIter>d__18 <InstsIter>d__ = new RogueResDeliveryRule.<InstsIter>d__18(-2);
			<InstsIter>d__.<>3__<>4__this = this;
			return <InstsIter>d__;
		}

		// Token: 0x040050E1 RID: 20705
		private Table __p;
	}
}

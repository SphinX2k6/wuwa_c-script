using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FDE RID: 4062
	public struct RogueDeliveryRule : IFlatbufferObject
	{
		// Token: 0x17002F20 RID: 12064
		// (get) Token: 0x0600BED5 RID: 48853 RVA: 0x002E4691 File Offset: 0x002E2891
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BED6 RID: 48854 RVA: 0x002E469E File Offset: 0x002E289E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BED7 RID: 48855 RVA: 0x002E46A8 File Offset: 0x002E28A8
		public static RogueDeliveryRule GetRootAsRogueDeliveryRule(ByteBuffer _bb)
		{
			return RogueDeliveryRule.GetRootAsRogueDeliveryRule(_bb, default(RogueDeliveryRule));
		}

		// Token: 0x0600BED8 RID: 48856 RVA: 0x002E46C4 File Offset: 0x002E28C4
		public static RogueDeliveryRule GetRootAsRogueDeliveryRule(ByteBuffer _bb, RogueDeliveryRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BED9 RID: 48857 RVA: 0x002E46E1 File Offset: 0x002E28E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BEDA RID: 48858 RVA: 0x002E46F0 File Offset: 0x002E28F0
		public RogueDeliveryRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F21 RID: 12065
		// (get) Token: 0x0600BEDB RID: 48859 RVA: 0x002E4700 File Offset: 0x002E2900
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

		// Token: 0x17002F22 RID: 12066
		// (get) Token: 0x0600BEDC RID: 48860 RVA: 0x002E473C File Offset: 0x002E293C
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

		// Token: 0x0600BEDD RID: 48861 RVA: 0x002E4778 File Offset: 0x002E2978
		public int Insts(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F23 RID: 12067
		// (get) Token: 0x0600BEDE RID: 48862 RVA: 0x002E47B8 File Offset: 0x002E29B8
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

		// Token: 0x0600BEDF RID: 48863 RVA: 0x002E47E3 File Offset: 0x002E29E3
		public Span<int> GetInstsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600BEE0 RID: 48864 RVA: 0x002E47F2 File Offset: 0x002E29F2
		public int[] GetInstsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600BEE1 RID: 48865 RVA: 0x002E480C File Offset: 0x002E2A0C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InstsIter()或GetInstsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Insts()
		{
			RogueDeliveryRule rogueDeliveryRule = this;
			return rogueDeliveryRule.GetInstsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BEE2 RID: 48866 RVA: 0x002E4830 File Offset: 0x002E2A30
		[NullableContext(1)]
		public readonly IEnumerable<int> InstsIter()
		{
			RogueDeliveryRule.<InstsIter>d__18 <InstsIter>d__ = new RogueDeliveryRule.<InstsIter>d__18(-2);
			<InstsIter>d__.<>3__<>4__this = this;
			return <InstsIter>d__;
		}

		// Token: 0x040050BB RID: 20667
		private Table __p;
	}
}

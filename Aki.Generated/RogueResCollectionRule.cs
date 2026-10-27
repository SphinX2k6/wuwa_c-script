using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FF7 RID: 4087
	public struct RogueResCollectionRule : IFlatbufferObject
	{
		// Token: 0x17002FEB RID: 12267
		// (get) Token: 0x0600C151 RID: 49489 RVA: 0x002EA2C1 File Offset: 0x002E84C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C152 RID: 49490 RVA: 0x002EA2CE File Offset: 0x002E84CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C153 RID: 49491 RVA: 0x002EA2D8 File Offset: 0x002E84D8
		public static RogueResCollectionRule GetRootAsRogueResCollectionRule(ByteBuffer _bb)
		{
			return RogueResCollectionRule.GetRootAsRogueResCollectionRule(_bb, default(RogueResCollectionRule));
		}

		// Token: 0x0600C154 RID: 49492 RVA: 0x002EA2F4 File Offset: 0x002E84F4
		public static RogueResCollectionRule GetRootAsRogueResCollectionRule(ByteBuffer _bb, RogueResCollectionRule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C155 RID: 49493 RVA: 0x002EA311 File Offset: 0x002E8511
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C156 RID: 49494 RVA: 0x002EA320 File Offset: 0x002E8520
		public RogueResCollectionRule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002FEC RID: 12268
		// (get) Token: 0x0600C157 RID: 49495 RVA: 0x002EA330 File Offset: 0x002E8530
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

		// Token: 0x17002FED RID: 12269
		// (get) Token: 0x0600C158 RID: 49496 RVA: 0x002EA36C File Offset: 0x002E856C
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

		// Token: 0x0600C159 RID: 49497 RVA: 0x002EA3A8 File Offset: 0x002E85A8
		public int Seasons(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002FEE RID: 12270
		// (get) Token: 0x0600C15A RID: 49498 RVA: 0x002EA3E8 File Offset: 0x002E85E8
		public int SeasonsLength
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

		// Token: 0x0600C15B RID: 49499 RVA: 0x002EA413 File Offset: 0x002E8613
		public Span<int> GetSeasonsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C15C RID: 49500 RVA: 0x002EA422 File Offset: 0x002E8622
		public int[] GetSeasonsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600C15D RID: 49501 RVA: 0x002EA43C File Offset: 0x002E863C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SeasonsIter()或GetSeasonsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Seasons()
		{
			RogueResCollectionRule rogueResCollectionRule = this;
			return rogueResCollectionRule.GetSeasonsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C15E RID: 49502 RVA: 0x002EA460 File Offset: 0x002E8660
		[NullableContext(1)]
		public readonly IEnumerable<int> SeasonsIter()
		{
			RogueResCollectionRule.<SeasonsIter>d__18 <SeasonsIter>d__ = new RogueResCollectionRule.<SeasonsIter>d__18(-2);
			<SeasonsIter>d__.<>3__<>4__this = this;
			return <SeasonsIter>d__;
		}

		// Token: 0x040050DF RID: 20703
		private Table __p;
	}
}

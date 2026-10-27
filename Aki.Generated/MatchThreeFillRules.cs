using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DFD RID: 3581
	public struct MatchThreeFillRules : IFlatbufferObject
	{
		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x060092A0 RID: 37536 RVA: 0x0028202D File Offset: 0x0028022D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060092A1 RID: 37537 RVA: 0x0028203A File Offset: 0x0028023A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060092A2 RID: 37538 RVA: 0x00282044 File Offset: 0x00280244
		public static MatchThreeFillRules GetRootAsMatchThreeFillRules(ByteBuffer _bb)
		{
			return MatchThreeFillRules.GetRootAsMatchThreeFillRules(_bb, default(MatchThreeFillRules));
		}

		// Token: 0x060092A3 RID: 37539 RVA: 0x00282060 File Offset: 0x00280260
		public static MatchThreeFillRules GetRootAsMatchThreeFillRules(ByteBuffer _bb, MatchThreeFillRules obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060092A4 RID: 37540 RVA: 0x0028207D File Offset: 0x0028027D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060092A5 RID: 37541 RVA: 0x0028208C File Offset: 0x0028028C
		public MatchThreeFillRules __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x060092A6 RID: 37542 RVA: 0x0028209C File Offset: 0x0028029C
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

		// Token: 0x17001E8C RID: 7820
		// (get) Token: 0x060092A7 RID: 37543 RVA: 0x002820D8 File Offset: 0x002802D8
		public int Count
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

		// Token: 0x17001E8D RID: 7821
		// (get) Token: 0x060092A8 RID: 37544 RVA: 0x00282114 File Offset: 0x00280314
		public float EliminateProbability
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E8E RID: 7822
		// (get) Token: 0x060092A9 RID: 37545 RVA: 0x00282154 File Offset: 0x00280354
		public float RandomProbability
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060092AA RID: 37546 RVA: 0x00282198 File Offset: 0x00280398
		public int Pool(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E8F RID: 7823
		// (get) Token: 0x060092AB RID: 37547 RVA: 0x002821D8 File Offset: 0x002803D8
		public int PoolLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060092AC RID: 37548 RVA: 0x00282204 File Offset: 0x00280404
		public Span<int> GetPoolBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060092AD RID: 37549 RVA: 0x00282214 File Offset: 0x00280414
		public int[] GetPoolArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x060092AE RID: 37550 RVA: 0x0028222C File Offset: 0x0028042C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PoolIter()或GetPoolBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Pool()
		{
			MatchThreeFillRules matchThreeFillRules = this;
			return matchThreeFillRules.GetPoolArray() ?? Array.Empty<int>();
		}

		// Token: 0x060092AF RID: 37551 RVA: 0x00282250 File Offset: 0x00280450
		[NullableContext(1)]
		public readonly IEnumerable<int> PoolIter()
		{
			MatchThreeFillRules.<PoolIter>d__22 <PoolIter>d__ = new MatchThreeFillRules.<PoolIter>d__22(-2);
			<PoolIter>d__.<>3__<>4__this = this;
			return <PoolIter>d__;
		}

		// Token: 0x04004E9D RID: 20125
		private Table __p;
	}
}

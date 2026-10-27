using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C54 RID: 3156
	public struct ExploreScore : IFlatbufferObject
	{
		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x06006BDD RID: 27613 RVA: 0x00229380 File Offset: 0x00227580
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006BDE RID: 27614 RVA: 0x0022938D File Offset: 0x0022758D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006BDF RID: 27615 RVA: 0x00229394 File Offset: 0x00227594
		public static ExploreScore GetRootAsExploreScore(ByteBuffer _bb)
		{
			return ExploreScore.GetRootAsExploreScore(_bb, default(ExploreScore));
		}

		// Token: 0x06006BE0 RID: 27616 RVA: 0x002293B0 File Offset: 0x002275B0
		public static ExploreScore GetRootAsExploreScore(ByteBuffer _bb, ExploreScore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006BE1 RID: 27617 RVA: 0x002293CD File Offset: 0x002275CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006BE2 RID: 27618 RVA: 0x002293DC File Offset: 0x002275DC
		public ExploreScore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x06006BE3 RID: 27619 RVA: 0x002293EC File Offset: 0x002275EC
		public int Area
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

		// Token: 0x06006BE4 RID: 27620 RVA: 0x00229428 File Offset: 0x00227628
		public DicIntInt? Score(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x06006BE5 RID: 27621 RVA: 0x00229488 File Offset: 0x00227688
		public int ScoreLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006BE6 RID: 27622 RVA: 0x002294B4 File Offset: 0x002276B4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ScoreFrozenDict()缓存字典，遍历请使用ScoreIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Score()
		{
			return this.ScoreIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006BE7 RID: 27623 RVA: 0x0022950A File Offset: 0x0022770A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ScoreIter()
		{
			ExploreScore.<ScoreIter>d__14 <ScoreIter>d__ = new ExploreScore.<ScoreIter>d__14(-2);
			<ScoreIter>d__.<>3__<>4__this = this;
			return <ScoreIter>d__;
		}

		// Token: 0x06006BE8 RID: 27624 RVA: 0x00229520 File Offset: 0x00227720
		public int? GetScore(int key)
		{
			this.EnsureScoreCacheIfNeeded();
			int value;
			if (!this.ScoreCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06006BE9 RID: 27625 RVA: 0x00229554 File Offset: 0x00227754
		private void EnsureScoreCacheIfNeeded()
		{
			if (this.ScoreCache != null)
			{
				return;
			}
			this.ScoreCache = this.ScoreIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006BEA RID: 27626 RVA: 0x002295BA File Offset: 0x002277BA
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetScoreFrozenDict(int key)
		{
			this.EnsureScoreCacheIfNeeded();
			return this.ScoreCache;
		}

		// Token: 0x04004C9B RID: 19611
		private Table __p;

		// Token: 0x04004C9C RID: 19612
		[Nullable(2)]
		private FrozenDictionary<int, int> ScoreCache;
	}
}

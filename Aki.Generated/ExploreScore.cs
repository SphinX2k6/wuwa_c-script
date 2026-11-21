using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D37 RID: 3383
	public struct ExploreScore : IFlatbufferObject
	{
		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x060071DF RID: 29151 RVA: 0x0024860C File Offset: 0x0024680C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060071E0 RID: 29152 RVA: 0x00248619 File Offset: 0x00246819
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060071E1 RID: 29153 RVA: 0x00248620 File Offset: 0x00246820
		public static ExploreScore GetRootAsExploreScore(ByteBuffer _bb)
		{
			return ExploreScore.GetRootAsExploreScore(_bb, default(ExploreScore));
		}

		// Token: 0x060071E2 RID: 29154 RVA: 0x0024863C File Offset: 0x0024683C
		public static ExploreScore GetRootAsExploreScore(ByteBuffer _bb, ExploreScore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060071E3 RID: 29155 RVA: 0x00248659 File Offset: 0x00246859
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060071E4 RID: 29156 RVA: 0x00248668 File Offset: 0x00246868
		public ExploreScore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x060071E5 RID: 29157 RVA: 0x00248678 File Offset: 0x00246878
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

		// Token: 0x060071E6 RID: 29158 RVA: 0x002486B4 File Offset: 0x002468B4
		public DicIntInt? Score(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x060071E7 RID: 29159 RVA: 0x00248714 File Offset: 0x00246914
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

		// Token: 0x060071E8 RID: 29160 RVA: 0x00248740 File Offset: 0x00246940
		[NullableContext(1)]
		public Dictionary<int, int> Score()
		{
			return this.ScoreIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060071E9 RID: 29161 RVA: 0x00248796 File Offset: 0x00246996
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ScoreIter()
		{
			ExploreScore.<ScoreIter>d__14 <ScoreIter>d__ = new ExploreScore.<ScoreIter>d__14(-2);
			<ScoreIter>d__.<>3__<>4__this = this;
			return <ScoreIter>d__;
		}

		// Token: 0x060071EA RID: 29162 RVA: 0x002487AC File Offset: 0x002469AC
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

		// Token: 0x060071EB RID: 29163 RVA: 0x002487E0 File Offset: 0x002469E0
		private void EnsureScoreCacheIfNeeded()
		{
			if (this.ScoreCache != null)
			{
				return;
			}
			this.ScoreCache = this.ScoreIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060071EC RID: 29164 RVA: 0x00248846 File Offset: 0x00246A46
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetScoreFrozenDict()
		{
			this.EnsureScoreCacheIfNeeded();
			return this.ScoreCache;
		}

		// Token: 0x0400527E RID: 21118
		private Table __p;

		// Token: 0x0400527F RID: 21119
		[Nullable(2)]
		private FrozenDictionary<int, int> ScoreCache;
	}
}

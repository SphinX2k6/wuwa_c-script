using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010F1 RID: 4337
	[NullableContext(1)]
	[Nullable(0)]
	public struct RogueResGridExplore : IFlatbufferObject
	{
		// Token: 0x170030F5 RID: 12533
		// (get) Token: 0x0600C941 RID: 51521 RVA: 0x0030997D File Offset: 0x00307B7D
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C942 RID: 51522 RVA: 0x0030998A File Offset: 0x00307B8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C943 RID: 51523 RVA: 0x00309994 File Offset: 0x00307B94
		[NullableContext(0)]
		public static RogueResGridExplore GetRootAsRogueResGridExplore(ByteBuffer _bb)
		{
			return RogueResGridExplore.GetRootAsRogueResGridExplore(_bb, default(RogueResGridExplore));
		}

		// Token: 0x0600C944 RID: 51524 RVA: 0x003099B0 File Offset: 0x00307BB0
		[NullableContext(0)]
		public static RogueResGridExplore GetRootAsRogueResGridExplore(ByteBuffer _bb, RogueResGridExplore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C945 RID: 51525 RVA: 0x003099CD File Offset: 0x00307BCD
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C946 RID: 51526 RVA: 0x003099DC File Offset: 0x00307BDC
		[NullableContext(0)]
		public RogueResGridExplore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030F6 RID: 12534
		// (get) Token: 0x0600C947 RID: 51527 RVA: 0x003099EC File Offset: 0x00307BEC
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

		// Token: 0x170030F7 RID: 12535
		// (get) Token: 0x0600C948 RID: 51528 RVA: 0x00309A28 File Offset: 0x00307C28
		public int InstId
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

		// Token: 0x0600C949 RID: 51529 RVA: 0x00309A64 File Offset: 0x00307C64
		[NullableContext(0)]
		public string FinishCountType(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030F8 RID: 12536
		// (get) Token: 0x0600C94A RID: 51530 RVA: 0x00309AA0 File Offset: 0x00307CA0
		public int FinishCountTypeLength
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

		// Token: 0x0600C94B RID: 51531 RVA: 0x00309ACC File Offset: 0x00307CCC
		[NullableContext(0)]
		public string CountTypeA(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030F9 RID: 12537
		// (get) Token: 0x0600C94C RID: 51532 RVA: 0x00309B08 File Offset: 0x00307D08
		public int CountTypeALength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C94D RID: 51533 RVA: 0x00309B34 File Offset: 0x00307D34
		[NullableContext(0)]
		public string DescA(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030FA RID: 12538
		// (get) Token: 0x0600C94E RID: 51534 RVA: 0x00309B70 File Offset: 0x00307D70
		public int DescALength
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

		// Token: 0x0600C94F RID: 51535 RVA: 0x00309B9C File Offset: 0x00307D9C
		public int CountTypeB(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030FB RID: 12539
		// (get) Token: 0x0600C950 RID: 51536 RVA: 0x00309BDC File Offset: 0x00307DDC
		public int CountTypeBLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C951 RID: 51537 RVA: 0x00309C08 File Offset: 0x00307E08
		[NullableContext(0)]
		public Span<int> GetCountTypeBBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600C952 RID: 51538 RVA: 0x00309C18 File Offset: 0x00307E18
		[NullableContext(0)]
		public int[] GetCountTypeBArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600C953 RID: 51539 RVA: 0x00309C30 File Offset: 0x00307E30
		[NullableContext(0)]
		public string DescB(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030FC RID: 12540
		// (get) Token: 0x0600C954 RID: 51540 RVA: 0x00309C6C File Offset: 0x00307E6C
		public int DescBLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C955 RID: 51541 RVA: 0x00309C98 File Offset: 0x00307E98
		public DicIntInt? ScoreMap(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170030FD RID: 12541
		// (get) Token: 0x0600C956 RID: 51542 RVA: 0x00309CFC File Offset: 0x00307EFC
		public int ScoreMapLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C957 RID: 51543 RVA: 0x00309D28 File Offset: 0x00307F28
		public DicIntInt? RankMap(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170030FE RID: 12542
		// (get) Token: 0x0600C958 RID: 51544 RVA: 0x00309D8C File Offset: 0x00307F8C
		public int RankMapLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C959 RID: 51545 RVA: 0x00309DB8 File Offset: 0x00307FB8
		public DicIntInt? DropMap(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170030FF RID: 12543
		// (get) Token: 0x0600C95A RID: 51546 RVA: 0x00309E1C File Offset: 0x0030801C
		public int DropMapLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C95B RID: 51547 RVA: 0x00309E48 File Offset: 0x00308048
		public string[] CountTypeA()
		{
			return this.CountTypeAIter().ToArray<string>();
		}

		// Token: 0x0600C95C RID: 51548 RVA: 0x00309E55 File Offset: 0x00308055
		public IEnumerable<string> CountTypeAIter()
		{
			RogueResGridExplore.<CountTypeAIter>d__39 <CountTypeAIter>d__ = new RogueResGridExplore.<CountTypeAIter>d__39(-2);
			<CountTypeAIter>d__.<>3__<>4__this = this;
			return <CountTypeAIter>d__;
		}

		// Token: 0x0600C95D RID: 51549 RVA: 0x00309E6A File Offset: 0x0030806A
		public int[] CountTypeB()
		{
			return this.GetCountTypeBArray();
		}

		// Token: 0x0600C95E RID: 51550 RVA: 0x00309E72 File Offset: 0x00308072
		public IEnumerable<int> CountTypeBIter()
		{
			RogueResGridExplore.<CountTypeBIter>d__41 <CountTypeBIter>d__ = new RogueResGridExplore.<CountTypeBIter>d__41(-2);
			<CountTypeBIter>d__.<>3__<>4__this = this;
			return <CountTypeBIter>d__;
		}

		// Token: 0x0600C95F RID: 51551 RVA: 0x00309E87 File Offset: 0x00308087
		public string[] DescA()
		{
			return this.DescAIter().ToArray<string>();
		}

		// Token: 0x0600C960 RID: 51552 RVA: 0x00309E94 File Offset: 0x00308094
		public IEnumerable<string> DescAIter()
		{
			RogueResGridExplore.<DescAIter>d__43 <DescAIter>d__ = new RogueResGridExplore.<DescAIter>d__43(-2);
			<DescAIter>d__.<>3__<>4__this = this;
			return <DescAIter>d__;
		}

		// Token: 0x0600C961 RID: 51553 RVA: 0x00309EA9 File Offset: 0x003080A9
		public string[] DescB()
		{
			return this.DescBIter().ToArray<string>();
		}

		// Token: 0x0600C962 RID: 51554 RVA: 0x00309EB6 File Offset: 0x003080B6
		public IEnumerable<string> DescBIter()
		{
			RogueResGridExplore.<DescBIter>d__45 <DescBIter>d__ = new RogueResGridExplore.<DescBIter>d__45(-2);
			<DescBIter>d__.<>3__<>4__this = this;
			return <DescBIter>d__;
		}

		// Token: 0x0600C963 RID: 51555 RVA: 0x00309ECC File Offset: 0x003080CC
		public Dictionary<int, int> DropMap()
		{
			return this.DropMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C964 RID: 51556 RVA: 0x00309F22 File Offset: 0x00308122
		public IEnumerable<DicIntInt> DropMapIter()
		{
			RogueResGridExplore.<DropMapIter>d__47 <DropMapIter>d__ = new RogueResGridExplore.<DropMapIter>d__47(-2);
			<DropMapIter>d__.<>3__<>4__this = this;
			return <DropMapIter>d__;
		}

		// Token: 0x0600C965 RID: 51557 RVA: 0x00309F37 File Offset: 0x00308137
		public string[] FinishCountType()
		{
			return this.FinishCountTypeIter().ToArray<string>();
		}

		// Token: 0x0600C966 RID: 51558 RVA: 0x00309F44 File Offset: 0x00308144
		public IEnumerable<string> FinishCountTypeIter()
		{
			RogueResGridExplore.<FinishCountTypeIter>d__49 <FinishCountTypeIter>d__ = new RogueResGridExplore.<FinishCountTypeIter>d__49(-2);
			<FinishCountTypeIter>d__.<>3__<>4__this = this;
			return <FinishCountTypeIter>d__;
		}

		// Token: 0x0600C967 RID: 51559 RVA: 0x00309F5C File Offset: 0x0030815C
		public Dictionary<int, int> RankMap()
		{
			return this.RankMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C968 RID: 51560 RVA: 0x00309FB2 File Offset: 0x003081B2
		public IEnumerable<DicIntInt> RankMapIter()
		{
			RogueResGridExplore.<RankMapIter>d__51 <RankMapIter>d__ = new RogueResGridExplore.<RankMapIter>d__51(-2);
			<RankMapIter>d__.<>3__<>4__this = this;
			return <RankMapIter>d__;
		}

		// Token: 0x0600C969 RID: 51561 RVA: 0x00309FC8 File Offset: 0x003081C8
		public Dictionary<int, int> ScoreMap()
		{
			return this.ScoreMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C96A RID: 51562 RVA: 0x0030A01E File Offset: 0x0030821E
		public IEnumerable<DicIntInt> ScoreMapIter()
		{
			RogueResGridExplore.<ScoreMapIter>d__53 <ScoreMapIter>d__ = new RogueResGridExplore.<ScoreMapIter>d__53(-2);
			<ScoreMapIter>d__.<>3__<>4__this = this;
			return <ScoreMapIter>d__;
		}

		// Token: 0x0600C96B RID: 51563 RVA: 0x0030A034 File Offset: 0x00308234
		public int? GetDropMap(int key)
		{
			this.EnsureDropMapCacheIfNeeded();
			int value;
			if (!this.DropMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C96C RID: 51564 RVA: 0x0030A068 File Offset: 0x00308268
		public int? GetRankMap(int key)
		{
			this.EnsureRankMapCacheIfNeeded();
			int value;
			if (!this.RankMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C96D RID: 51565 RVA: 0x0030A09C File Offset: 0x0030829C
		public int? GetScoreMap(int key)
		{
			this.EnsureScoreMapCacheIfNeeded();
			int value;
			if (!this.ScoreMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C96E RID: 51566 RVA: 0x0030A0D0 File Offset: 0x003082D0
		private void EnsureDropMapCacheIfNeeded()
		{
			if (this.DropMapCache != null)
			{
				return;
			}
			this.DropMapCache = this.DropMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C96F RID: 51567 RVA: 0x0030A138 File Offset: 0x00308338
		private void EnsureRankMapCacheIfNeeded()
		{
			if (this.RankMapCache != null)
			{
				return;
			}
			this.RankMapCache = this.RankMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C970 RID: 51568 RVA: 0x0030A1A0 File Offset: 0x003083A0
		private void EnsureScoreMapCacheIfNeeded()
		{
			if (this.ScoreMapCache != null)
			{
				return;
			}
			this.ScoreMapCache = this.ScoreMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C971 RID: 51569 RVA: 0x0030A206 File Offset: 0x00308406
		public FrozenDictionary<int, int> GetDropMapFrozenDict()
		{
			this.EnsureDropMapCacheIfNeeded();
			return this.DropMapCache;
		}

		// Token: 0x0600C972 RID: 51570 RVA: 0x0030A214 File Offset: 0x00308414
		public FrozenDictionary<int, int> GetRankMapFrozenDict()
		{
			this.EnsureRankMapCacheIfNeeded();
			return this.RankMapCache;
		}

		// Token: 0x0600C973 RID: 51571 RVA: 0x0030A222 File Offset: 0x00308422
		public FrozenDictionary<int, int> GetScoreMapFrozenDict()
		{
			this.EnsureScoreMapCacheIfNeeded();
			return this.ScoreMapCache;
		}

		// Token: 0x040056D9 RID: 22233
		private Table __p;

		// Token: 0x040056DA RID: 22234
		[Nullable(2)]
		private FrozenDictionary<int, int> DropMapCache;

		// Token: 0x040056DB RID: 22235
		[Nullable(2)]
		private FrozenDictionary<int, int> RankMapCache;

		// Token: 0x040056DC RID: 22236
		[Nullable(2)]
		private FrozenDictionary<int, int> ScoreMapCache;
	}
}

using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001009 RID: 4105
	[NullableContext(1)]
	[Nullable(0)]
	public struct RogueResGridExplore : IFlatbufferObject
	{
		// Token: 0x1700307A RID: 12410
		// (get) Token: 0x0600C2F7 RID: 49911 RVA: 0x002ED865 File Offset: 0x002EBA65
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C2F8 RID: 49912 RVA: 0x002ED872 File Offset: 0x002EBA72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C2F9 RID: 49913 RVA: 0x002ED87C File Offset: 0x002EBA7C
		[NullableContext(0)]
		public static RogueResGridExplore GetRootAsRogueResGridExplore(ByteBuffer _bb)
		{
			return RogueResGridExplore.GetRootAsRogueResGridExplore(_bb, default(RogueResGridExplore));
		}

		// Token: 0x0600C2FA RID: 49914 RVA: 0x002ED898 File Offset: 0x002EBA98
		[NullableContext(0)]
		public static RogueResGridExplore GetRootAsRogueResGridExplore(ByteBuffer _bb, RogueResGridExplore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C2FB RID: 49915 RVA: 0x002ED8B5 File Offset: 0x002EBAB5
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C2FC RID: 49916 RVA: 0x002ED8C4 File Offset: 0x002EBAC4
		[NullableContext(0)]
		public RogueResGridExplore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700307B RID: 12411
		// (get) Token: 0x0600C2FD RID: 49917 RVA: 0x002ED8D4 File Offset: 0x002EBAD4
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

		// Token: 0x1700307C RID: 12412
		// (get) Token: 0x0600C2FE RID: 49918 RVA: 0x002ED910 File Offset: 0x002EBB10
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

		// Token: 0x0600C2FF RID: 49919 RVA: 0x002ED94C File Offset: 0x002EBB4C
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

		// Token: 0x1700307D RID: 12413
		// (get) Token: 0x0600C300 RID: 49920 RVA: 0x002ED988 File Offset: 0x002EBB88
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

		// Token: 0x0600C301 RID: 49921 RVA: 0x002ED9B4 File Offset: 0x002EBBB4
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

		// Token: 0x1700307E RID: 12414
		// (get) Token: 0x0600C302 RID: 49922 RVA: 0x002ED9F0 File Offset: 0x002EBBF0
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

		// Token: 0x0600C303 RID: 49923 RVA: 0x002EDA1C File Offset: 0x002EBC1C
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

		// Token: 0x1700307F RID: 12415
		// (get) Token: 0x0600C304 RID: 49924 RVA: 0x002EDA58 File Offset: 0x002EBC58
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

		// Token: 0x0600C305 RID: 49925 RVA: 0x002EDA84 File Offset: 0x002EBC84
		public int CountTypeB(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003080 RID: 12416
		// (get) Token: 0x0600C306 RID: 49926 RVA: 0x002EDAC4 File Offset: 0x002EBCC4
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

		// Token: 0x0600C307 RID: 49927 RVA: 0x002EDAF0 File Offset: 0x002EBCF0
		[NullableContext(0)]
		public Span<int> GetCountTypeBBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600C308 RID: 49928 RVA: 0x002EDB00 File Offset: 0x002EBD00
		[NullableContext(0)]
		public int[] GetCountTypeBArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600C309 RID: 49929 RVA: 0x002EDB18 File Offset: 0x002EBD18
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

		// Token: 0x17003081 RID: 12417
		// (get) Token: 0x0600C30A RID: 49930 RVA: 0x002EDB54 File Offset: 0x002EBD54
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

		// Token: 0x0600C30B RID: 49931 RVA: 0x002EDB80 File Offset: 0x002EBD80
		public DicIntInt? ScoreMap(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003082 RID: 12418
		// (get) Token: 0x0600C30C RID: 49932 RVA: 0x002EDBE4 File Offset: 0x002EBDE4
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

		// Token: 0x0600C30D RID: 49933 RVA: 0x002EDC10 File Offset: 0x002EBE10
		public DicIntInt? RankMap(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003083 RID: 12419
		// (get) Token: 0x0600C30E RID: 49934 RVA: 0x002EDC74 File Offset: 0x002EBE74
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

		// Token: 0x0600C30F RID: 49935 RVA: 0x002EDCA0 File Offset: 0x002EBEA0
		public DicIntInt? DropMap(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003084 RID: 12420
		// (get) Token: 0x0600C310 RID: 49936 RVA: 0x002EDD04 File Offset: 0x002EBF04
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

		// Token: 0x0600C311 RID: 49937 RVA: 0x002EDD30 File Offset: 0x002EBF30
		[Obsolete("本方法用于缓存,遍历请使用CountTypeAIter()或GetCountTypeABytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] CountTypeA()
		{
			return this.CountTypeAIter().ToArray<string>();
		}

		// Token: 0x0600C312 RID: 49938 RVA: 0x002EDD3D File Offset: 0x002EBF3D
		public readonly IEnumerable<string> CountTypeAIter()
		{
			RogueResGridExplore.<CountTypeAIter>d__39 <CountTypeAIter>d__ = new RogueResGridExplore.<CountTypeAIter>d__39(-2);
			<CountTypeAIter>d__.<>3__<>4__this = this;
			return <CountTypeAIter>d__;
		}

		// Token: 0x0600C313 RID: 49939 RVA: 0x002EDD54 File Offset: 0x002EBF54
		[Obsolete("本方法用于缓存,遍历请使用CountTypeBIter()或GetCountTypeBBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CountTypeB()
		{
			RogueResGridExplore rogueResGridExplore = this;
			return rogueResGridExplore.GetCountTypeBArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C314 RID: 49940 RVA: 0x002EDD78 File Offset: 0x002EBF78
		public readonly IEnumerable<int> CountTypeBIter()
		{
			RogueResGridExplore.<CountTypeBIter>d__41 <CountTypeBIter>d__ = new RogueResGridExplore.<CountTypeBIter>d__41(-2);
			<CountTypeBIter>d__.<>3__<>4__this = this;
			return <CountTypeBIter>d__;
		}

		// Token: 0x0600C315 RID: 49941 RVA: 0x002EDD8D File Offset: 0x002EBF8D
		[Obsolete("本方法用于缓存,遍历请使用DescAIter()或GetDescABytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescA()
		{
			return this.DescAIter().ToArray<string>();
		}

		// Token: 0x0600C316 RID: 49942 RVA: 0x002EDD9A File Offset: 0x002EBF9A
		public readonly IEnumerable<string> DescAIter()
		{
			RogueResGridExplore.<DescAIter>d__43 <DescAIter>d__ = new RogueResGridExplore.<DescAIter>d__43(-2);
			<DescAIter>d__.<>3__<>4__this = this;
			return <DescAIter>d__;
		}

		// Token: 0x0600C317 RID: 49943 RVA: 0x002EDDAF File Offset: 0x002EBFAF
		[Obsolete("本方法用于缓存,遍历请使用DescBIter()或GetDescBBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescB()
		{
			return this.DescBIter().ToArray<string>();
		}

		// Token: 0x0600C318 RID: 49944 RVA: 0x002EDDBC File Offset: 0x002EBFBC
		public readonly IEnumerable<string> DescBIter()
		{
			RogueResGridExplore.<DescBIter>d__45 <DescBIter>d__ = new RogueResGridExplore.<DescBIter>d__45(-2);
			<DescBIter>d__.<>3__<>4__this = this;
			return <DescBIter>d__;
		}

		// Token: 0x0600C319 RID: 49945 RVA: 0x002EDDD4 File Offset: 0x002EBFD4
		[Obsolete("已废弃，请使用DropMapFrozenDict()缓存字典，遍历请使用DropMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> DropMap()
		{
			return this.DropMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C31A RID: 49946 RVA: 0x002EDE2A File Offset: 0x002EC02A
		public readonly IEnumerable<DicIntInt> DropMapIter()
		{
			RogueResGridExplore.<DropMapIter>d__47 <DropMapIter>d__ = new RogueResGridExplore.<DropMapIter>d__47(-2);
			<DropMapIter>d__.<>3__<>4__this = this;
			return <DropMapIter>d__;
		}

		// Token: 0x0600C31B RID: 49947 RVA: 0x002EDE3F File Offset: 0x002EC03F
		[Obsolete("本方法用于缓存,遍历请使用FinishCountTypeIter()或GetFinishCountTypeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] FinishCountType()
		{
			return this.FinishCountTypeIter().ToArray<string>();
		}

		// Token: 0x0600C31C RID: 49948 RVA: 0x002EDE4C File Offset: 0x002EC04C
		public readonly IEnumerable<string> FinishCountTypeIter()
		{
			RogueResGridExplore.<FinishCountTypeIter>d__49 <FinishCountTypeIter>d__ = new RogueResGridExplore.<FinishCountTypeIter>d__49(-2);
			<FinishCountTypeIter>d__.<>3__<>4__this = this;
			return <FinishCountTypeIter>d__;
		}

		// Token: 0x0600C31D RID: 49949 RVA: 0x002EDE64 File Offset: 0x002EC064
		[Obsolete("已废弃，请使用RankMapFrozenDict()缓存字典，遍历请使用RankMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> RankMap()
		{
			return this.RankMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C31E RID: 49950 RVA: 0x002EDEBA File Offset: 0x002EC0BA
		public readonly IEnumerable<DicIntInt> RankMapIter()
		{
			RogueResGridExplore.<RankMapIter>d__51 <RankMapIter>d__ = new RogueResGridExplore.<RankMapIter>d__51(-2);
			<RankMapIter>d__.<>3__<>4__this = this;
			return <RankMapIter>d__;
		}

		// Token: 0x0600C31F RID: 49951 RVA: 0x002EDED0 File Offset: 0x002EC0D0
		[Obsolete("已废弃，请使用ScoreMapFrozenDict()缓存字典，遍历请使用ScoreMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ScoreMap()
		{
			return this.ScoreMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C320 RID: 49952 RVA: 0x002EDF26 File Offset: 0x002EC126
		public readonly IEnumerable<DicIntInt> ScoreMapIter()
		{
			RogueResGridExplore.<ScoreMapIter>d__53 <ScoreMapIter>d__ = new RogueResGridExplore.<ScoreMapIter>d__53(-2);
			<ScoreMapIter>d__.<>3__<>4__this = this;
			return <ScoreMapIter>d__;
		}

		// Token: 0x0600C321 RID: 49953 RVA: 0x002EDF3C File Offset: 0x002EC13C
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

		// Token: 0x0600C322 RID: 49954 RVA: 0x002EDF70 File Offset: 0x002EC170
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

		// Token: 0x0600C323 RID: 49955 RVA: 0x002EDFA4 File Offset: 0x002EC1A4
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

		// Token: 0x0600C324 RID: 49956 RVA: 0x002EDFD8 File Offset: 0x002EC1D8
		private void EnsureDropMapCacheIfNeeded()
		{
			if (this.DropMapCache != null)
			{
				return;
			}
			this.DropMapCache = this.DropMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C325 RID: 49957 RVA: 0x002EE040 File Offset: 0x002EC240
		private void EnsureRankMapCacheIfNeeded()
		{
			if (this.RankMapCache != null)
			{
				return;
			}
			this.RankMapCache = this.RankMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C326 RID: 49958 RVA: 0x002EE0A8 File Offset: 0x002EC2A8
		private void EnsureScoreMapCacheIfNeeded()
		{
			if (this.ScoreMapCache != null)
			{
				return;
			}
			this.ScoreMapCache = this.ScoreMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C327 RID: 49959 RVA: 0x002EE10E File Offset: 0x002EC30E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetDropMapFrozenDict(int key)
		{
			this.EnsureDropMapCacheIfNeeded();
			return this.DropMapCache;
		}

		// Token: 0x0600C328 RID: 49960 RVA: 0x002EE11C File Offset: 0x002EC31C
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRankMapFrozenDict(int key)
		{
			this.EnsureRankMapCacheIfNeeded();
			return this.RankMapCache;
		}

		// Token: 0x0600C329 RID: 49961 RVA: 0x002EE12A File Offset: 0x002EC32A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetScoreMapFrozenDict(int key)
		{
			this.EnsureScoreMapCacheIfNeeded();
			return this.ScoreMapCache;
		}

		// Token: 0x040050F1 RID: 20721
		private Table __p;

		// Token: 0x040050F2 RID: 20722
		[Nullable(2)]
		private FrozenDictionary<int, int> DropMapCache;

		// Token: 0x040050F3 RID: 20723
		[Nullable(2)]
		private FrozenDictionary<int, int> RankMapCache;

		// Token: 0x040050F4 RID: 20724
		[Nullable(2)]
		private FrozenDictionary<int, int> ScoreMapCache;
	}
}

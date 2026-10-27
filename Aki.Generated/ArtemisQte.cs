using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B0D RID: 2829
	public struct ArtemisQte : IFlatbufferObject
	{
		// Token: 0x1700037C RID: 892
		// (get) Token: 0x0600494D RID: 18765 RVA: 0x001D94F8 File Offset: 0x001D76F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600494E RID: 18766 RVA: 0x001D9505 File Offset: 0x001D7705
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600494F RID: 18767 RVA: 0x001D950C File Offset: 0x001D770C
		public static ArtemisQte GetRootAsArtemisQte(ByteBuffer _bb)
		{
			return ArtemisQte.GetRootAsArtemisQte(_bb, default(ArtemisQte));
		}

		// Token: 0x06004950 RID: 18768 RVA: 0x001D9528 File Offset: 0x001D7728
		public static ArtemisQte GetRootAsArtemisQte(ByteBuffer _bb, ArtemisQte obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004951 RID: 18769 RVA: 0x001D9545 File Offset: 0x001D7745
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004952 RID: 18770 RVA: 0x001D9554 File Offset: 0x001D7754
		public ArtemisQte __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06004953 RID: 18771 RVA: 0x001D9564 File Offset: 0x001D7764
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

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06004954 RID: 18772 RVA: 0x001D95A0 File Offset: 0x001D77A0
		public string Comment
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004955 RID: 18773 RVA: 0x001D95D7 File Offset: 0x001D77D7
		public Span<byte> GetCommentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004956 RID: 18774 RVA: 0x001D95E6 File Offset: 0x001D77E6
		public byte[] GetCommentArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06004957 RID: 18775 RVA: 0x001D9600 File Offset: 0x001D7800
		public int RandomArea(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06004958 RID: 18776 RVA: 0x001D9640 File Offset: 0x001D7840
		public int RandomAreaLength
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

		// Token: 0x06004959 RID: 18777 RVA: 0x001D966B File Offset: 0x001D786B
		public Span<int> GetRandomAreaBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600495A RID: 18778 RVA: 0x001D967A File Offset: 0x001D787A
		public int[] GetRandomAreaArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600495B RID: 18779 RVA: 0x001D9694 File Offset: 0x001D7894
		public IntArray? InvalidArea(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x0600495C RID: 18780 RVA: 0x001D96F8 File Offset: 0x001D78F8
		public int InvalidAreaLength
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

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x0600495D RID: 18781 RVA: 0x001D9724 File Offset: 0x001D7924
		public int MaxScore
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600495E RID: 18782 RVA: 0x001D9764 File Offset: 0x001D7964
		public int HitAreaScore
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 10;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x0600495F RID: 18783 RVA: 0x001D97A4 File Offset: 0x001D79A4
		public int PerfectSize
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004960 RID: 18784 RVA: 0x001D97E4 File Offset: 0x001D79E4
		public DicIntInt? PerfectAppearRate(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06004961 RID: 18785 RVA: 0x001D9848 File Offset: 0x001D7A48
		public int PerfectAppearRateLength
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

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06004962 RID: 18786 RVA: 0x001D9874 File Offset: 0x001D7A74
		public int PerfectScore
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004963 RID: 18787 RVA: 0x001D98B4 File Offset: 0x001D7AB4
		public DicIntInt? CursorSpeed(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06004964 RID: 18788 RVA: 0x001D9918 File Offset: 0x001D7B18
		public int CursorSpeedLength
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

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06004965 RID: 18789 RVA: 0x001D9944 File Offset: 0x001D7B44
		public int HitColdTime
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06004966 RID: 18790 RVA: 0x001D9984 File Offset: 0x001D7B84
		public int ScoreUp
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06004967 RID: 18791 RVA: 0x001D99C4 File Offset: 0x001D7BC4
		public int MultiBoxGroup
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004968 RID: 18792 RVA: 0x001D9A04 File Offset: 0x001D7C04
		public float HiddenInterval(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06004969 RID: 18793 RVA: 0x001D9A48 File Offset: 0x001D7C48
		public int HiddenIntervalLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600496A RID: 18794 RVA: 0x001D9A74 File Offset: 0x001D7C74
		public Span<float> GetHiddenIntervalBytes()
		{
			return this.__p.__vector_as_span<float>(30, 4);
		}

		// Token: 0x0600496B RID: 18795 RVA: 0x001D9A84 File Offset: 0x001D7C84
		public float[] GetHiddenIntervalArray()
		{
			return this.__p.__vector_as_array<float>(30) ?? Array.Empty<float>();
		}

		// Token: 0x0600496C RID: 18796 RVA: 0x001D9A9C File Offset: 0x001D7C9C
		public DicIntInt? RouletteRotateSpeed(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x0600496D RID: 18797 RVA: 0x001D9B00 File Offset: 0x001D7D00
		public int RouletteRotateSpeedLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x0600496E RID: 18798 RVA: 0x001D9B2C File Offset: 0x001D7D2C
		public int MistakeScore
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x0600496F RID: 18799 RVA: 0x001D9B6C File Offset: 0x001D7D6C
		public bool IsAnticlockwise
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06004970 RID: 18800 RVA: 0x001D9BAC File Offset: 0x001D7DAC
		public int RefreshType
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004971 RID: 18801 RVA: 0x001D9BEC File Offset: 0x001D7DEC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用CursorSpeedFrozenDict()缓存字典，遍历请使用CursorSpeedIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> CursorSpeed()
		{
			return this.CursorSpeedIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004972 RID: 18802 RVA: 0x001D9C42 File Offset: 0x001D7E42
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> CursorSpeedIter()
		{
			ArtemisQte.<CursorSpeedIter>d__57 <CursorSpeedIter>d__ = new ArtemisQte.<CursorSpeedIter>d__57(-2);
			<CursorSpeedIter>d__.<>3__<>4__this = this;
			return <CursorSpeedIter>d__;
		}

		// Token: 0x06004973 RID: 18803 RVA: 0x001D9C58 File Offset: 0x001D7E58
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用HiddenIntervalIter()或GetHiddenIntervalBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] HiddenInterval()
		{
			ArtemisQte artemisQte = this;
			return artemisQte.GetHiddenIntervalArray() ?? Array.Empty<float>();
		}

		// Token: 0x06004974 RID: 18804 RVA: 0x001D9C7C File Offset: 0x001D7E7C
		[NullableContext(1)]
		public readonly IEnumerable<float> HiddenIntervalIter()
		{
			ArtemisQte.<HiddenIntervalIter>d__59 <HiddenIntervalIter>d__ = new ArtemisQte.<HiddenIntervalIter>d__59(-2);
			<HiddenIntervalIter>d__.<>3__<>4__this = this;
			return <HiddenIntervalIter>d__;
		}

		// Token: 0x06004975 RID: 18805 RVA: 0x001D9C91 File Offset: 0x001D7E91
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InvalidAreaIter()或GetInvalidAreaBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] InvalidArea()
		{
			return this.InvalidAreaIter().ToArray<IntArray>();
		}

		// Token: 0x06004976 RID: 18806 RVA: 0x001D9C9E File Offset: 0x001D7E9E
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> InvalidAreaIter()
		{
			ArtemisQte.<InvalidAreaIter>d__61 <InvalidAreaIter>d__ = new ArtemisQte.<InvalidAreaIter>d__61(-2);
			<InvalidAreaIter>d__.<>3__<>4__this = this;
			return <InvalidAreaIter>d__;
		}

		// Token: 0x06004977 RID: 18807 RVA: 0x001D9CB4 File Offset: 0x001D7EB4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用PerfectAppearRateFrozenDict()缓存字典，遍历请使用PerfectAppearRateIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> PerfectAppearRate()
		{
			return this.PerfectAppearRateIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004978 RID: 18808 RVA: 0x001D9D0A File Offset: 0x001D7F0A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> PerfectAppearRateIter()
		{
			ArtemisQte.<PerfectAppearRateIter>d__63 <PerfectAppearRateIter>d__ = new ArtemisQte.<PerfectAppearRateIter>d__63(-2);
			<PerfectAppearRateIter>d__.<>3__<>4__this = this;
			return <PerfectAppearRateIter>d__;
		}

		// Token: 0x06004979 RID: 18809 RVA: 0x001D9D20 File Offset: 0x001D7F20
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RandomAreaIter()或GetRandomAreaBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RandomArea()
		{
			ArtemisQte artemisQte = this;
			return artemisQte.GetRandomAreaArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x001D9D44 File Offset: 0x001D7F44
		[NullableContext(1)]
		public readonly IEnumerable<int> RandomAreaIter()
		{
			ArtemisQte.<RandomAreaIter>d__65 <RandomAreaIter>d__ = new ArtemisQte.<RandomAreaIter>d__65(-2);
			<RandomAreaIter>d__.<>3__<>4__this = this;
			return <RandomAreaIter>d__;
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x001D9D5C File Offset: 0x001D7F5C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RouletteRotateSpeedFrozenDict()缓存字典，遍历请使用RouletteRotateSpeedIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> RouletteRotateSpeed()
		{
			return this.RouletteRotateSpeedIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600497C RID: 18812 RVA: 0x001D9DB2 File Offset: 0x001D7FB2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RouletteRotateSpeedIter()
		{
			ArtemisQte.<RouletteRotateSpeedIter>d__67 <RouletteRotateSpeedIter>d__ = new ArtemisQte.<RouletteRotateSpeedIter>d__67(-2);
			<RouletteRotateSpeedIter>d__.<>3__<>4__this = this;
			return <RouletteRotateSpeedIter>d__;
		}

		// Token: 0x0600497D RID: 18813 RVA: 0x001D9DC8 File Offset: 0x001D7FC8
		public int? GetCursorSpeed(int key)
		{
			this.EnsureCursorSpeedCacheIfNeeded();
			int value;
			if (!this.CursorSpeedCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600497E RID: 18814 RVA: 0x001D9DFC File Offset: 0x001D7FFC
		public int? GetPerfectAppearRate(int key)
		{
			this.EnsurePerfectAppearRateCacheIfNeeded();
			int value;
			if (!this.PerfectAppearRateCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600497F RID: 18815 RVA: 0x001D9E30 File Offset: 0x001D8030
		public int? GetRouletteRotateSpeed(int key)
		{
			this.EnsureRouletteRotateSpeedCacheIfNeeded();
			int value;
			if (!this.RouletteRotateSpeedCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06004980 RID: 18816 RVA: 0x001D9E64 File Offset: 0x001D8064
		private void EnsureCursorSpeedCacheIfNeeded()
		{
			if (this.CursorSpeedCache != null)
			{
				return;
			}
			this.CursorSpeedCache = this.CursorSpeedIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004981 RID: 18817 RVA: 0x001D9ECC File Offset: 0x001D80CC
		private void EnsurePerfectAppearRateCacheIfNeeded()
		{
			if (this.PerfectAppearRateCache != null)
			{
				return;
			}
			this.PerfectAppearRateCache = this.PerfectAppearRateIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004982 RID: 18818 RVA: 0x001D9F34 File Offset: 0x001D8134
		private void EnsureRouletteRotateSpeedCacheIfNeeded()
		{
			if (this.RouletteRotateSpeedCache != null)
			{
				return;
			}
			this.RouletteRotateSpeedCache = this.RouletteRotateSpeedIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004983 RID: 18819 RVA: 0x001D9F9A File Offset: 0x001D819A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetCursorSpeedFrozenDict(int key)
		{
			this.EnsureCursorSpeedCacheIfNeeded();
			return this.CursorSpeedCache;
		}

		// Token: 0x06004984 RID: 18820 RVA: 0x001D9FA8 File Offset: 0x001D81A8
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetPerfectAppearRateFrozenDict(int key)
		{
			this.EnsurePerfectAppearRateCacheIfNeeded();
			return this.PerfectAppearRateCache;
		}

		// Token: 0x06004985 RID: 18821 RVA: 0x001D9FB6 File Offset: 0x001D81B6
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRouletteRotateSpeedFrozenDict(int key)
		{
			this.EnsureRouletteRotateSpeedCacheIfNeeded();
			return this.RouletteRotateSpeedCache;
		}

		// Token: 0x04004AF2 RID: 19186
		private Table __p;

		// Token: 0x04004AF3 RID: 19187
		[Nullable(2)]
		private FrozenDictionary<int, int> CursorSpeedCache;

		// Token: 0x04004AF4 RID: 19188
		[Nullable(2)]
		private FrozenDictionary<int, int> PerfectAppearRateCache;

		// Token: 0x04004AF5 RID: 19189
		[Nullable(2)]
		private FrozenDictionary<int, int> RouletteRotateSpeedCache;
	}
}

using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BE7 RID: 3047
	public struct ArtemisQte : IFlatbufferObject
	{
		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06004E94 RID: 20116 RVA: 0x001F8CA4 File Offset: 0x001F6EA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004E95 RID: 20117 RVA: 0x001F8CB1 File Offset: 0x001F6EB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004E96 RID: 20118 RVA: 0x001F8CB8 File Offset: 0x001F6EB8
		public static ArtemisQte GetRootAsArtemisQte(ByteBuffer _bb)
		{
			return ArtemisQte.GetRootAsArtemisQte(_bb, default(ArtemisQte));
		}

		// Token: 0x06004E97 RID: 20119 RVA: 0x001F8CD4 File Offset: 0x001F6ED4
		public static ArtemisQte GetRootAsArtemisQte(ByteBuffer _bb, ArtemisQte obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004E98 RID: 20120 RVA: 0x001F8CF1 File Offset: 0x001F6EF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004E99 RID: 20121 RVA: 0x001F8D00 File Offset: 0x001F6F00
		public ArtemisQte __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06004E9A RID: 20122 RVA: 0x001F8D10 File Offset: 0x001F6F10
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

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06004E9B RID: 20123 RVA: 0x001F8D4C File Offset: 0x001F6F4C
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

		// Token: 0x06004E9C RID: 20124 RVA: 0x001F8D83 File Offset: 0x001F6F83
		public Span<byte> GetCommentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004E9D RID: 20125 RVA: 0x001F8D92 File Offset: 0x001F6F92
		public byte[] GetCommentArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06004E9E RID: 20126 RVA: 0x001F8DAC File Offset: 0x001F6FAC
		public int RandomArea(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06004E9F RID: 20127 RVA: 0x001F8DEC File Offset: 0x001F6FEC
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

		// Token: 0x06004EA0 RID: 20128 RVA: 0x001F8E17 File Offset: 0x001F7017
		public Span<int> GetRandomAreaBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06004EA1 RID: 20129 RVA: 0x001F8E26 File Offset: 0x001F7026
		public int[] GetRandomAreaArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06004EA2 RID: 20130 RVA: 0x001F8E40 File Offset: 0x001F7040
		public IntArray? InvalidArea(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06004EA3 RID: 20131 RVA: 0x001F8EA4 File Offset: 0x001F70A4
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

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06004EA4 RID: 20132 RVA: 0x001F8ED0 File Offset: 0x001F70D0
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

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06004EA5 RID: 20133 RVA: 0x001F8F10 File Offset: 0x001F7110
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

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06004EA6 RID: 20134 RVA: 0x001F8F50 File Offset: 0x001F7150
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

		// Token: 0x06004EA7 RID: 20135 RVA: 0x001F8F90 File Offset: 0x001F7190
		public DicIntInt? PerfectAppearRate(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06004EA8 RID: 20136 RVA: 0x001F8FF4 File Offset: 0x001F71F4
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

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06004EA9 RID: 20137 RVA: 0x001F9020 File Offset: 0x001F7220
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

		// Token: 0x06004EAA RID: 20138 RVA: 0x001F9060 File Offset: 0x001F7260
		public DicIntInt? CursorSpeed(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06004EAB RID: 20139 RVA: 0x001F90C4 File Offset: 0x001F72C4
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

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06004EAC RID: 20140 RVA: 0x001F90F0 File Offset: 0x001F72F0
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

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06004EAD RID: 20141 RVA: 0x001F9130 File Offset: 0x001F7330
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

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06004EAE RID: 20142 RVA: 0x001F9170 File Offset: 0x001F7370
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

		// Token: 0x06004EAF RID: 20143 RVA: 0x001F91B0 File Offset: 0x001F73B0
		public float HiddenInterval(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06004EB0 RID: 20144 RVA: 0x001F91F4 File Offset: 0x001F73F4
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

		// Token: 0x06004EB1 RID: 20145 RVA: 0x001F9220 File Offset: 0x001F7420
		public Span<float> GetHiddenIntervalBytes()
		{
			return this.__p.__vector_as_span<float>(30, 4);
		}

		// Token: 0x06004EB2 RID: 20146 RVA: 0x001F9230 File Offset: 0x001F7430
		public float[] GetHiddenIntervalArray()
		{
			return this.__p.__vector_as_array<float>(30) ?? Array.Empty<float>();
		}

		// Token: 0x06004EB3 RID: 20147 RVA: 0x001F9248 File Offset: 0x001F7448
		public DicIntInt? RouletteRotateSpeed(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06004EB4 RID: 20148 RVA: 0x001F92AC File Offset: 0x001F74AC
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

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06004EB5 RID: 20149 RVA: 0x001F92D8 File Offset: 0x001F74D8
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

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06004EB6 RID: 20150 RVA: 0x001F9318 File Offset: 0x001F7518
		public bool IsAnticlockwise
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06004EB7 RID: 20151 RVA: 0x001F9358 File Offset: 0x001F7558
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

		// Token: 0x06004EB8 RID: 20152 RVA: 0x001F9398 File Offset: 0x001F7598
		[NullableContext(1)]
		public Dictionary<int, int> CursorSpeed()
		{
			return this.CursorSpeedIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004EB9 RID: 20153 RVA: 0x001F93EE File Offset: 0x001F75EE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> CursorSpeedIter()
		{
			ArtemisQte.<CursorSpeedIter>d__57 <CursorSpeedIter>d__ = new ArtemisQte.<CursorSpeedIter>d__57(-2);
			<CursorSpeedIter>d__.<>3__<>4__this = this;
			return <CursorSpeedIter>d__;
		}

		// Token: 0x06004EBA RID: 20154 RVA: 0x001F9403 File Offset: 0x001F7603
		[NullableContext(1)]
		public float[] HiddenInterval()
		{
			return this.GetHiddenIntervalArray();
		}

		// Token: 0x06004EBB RID: 20155 RVA: 0x001F940B File Offset: 0x001F760B
		[NullableContext(1)]
		public IEnumerable<float> HiddenIntervalIter()
		{
			ArtemisQte.<HiddenIntervalIter>d__59 <HiddenIntervalIter>d__ = new ArtemisQte.<HiddenIntervalIter>d__59(-2);
			<HiddenIntervalIter>d__.<>3__<>4__this = this;
			return <HiddenIntervalIter>d__;
		}

		// Token: 0x06004EBC RID: 20156 RVA: 0x001F9420 File Offset: 0x001F7620
		[NullableContext(1)]
		public IntArray[] InvalidArea()
		{
			return this.InvalidAreaIter().ToArray<IntArray>();
		}

		// Token: 0x06004EBD RID: 20157 RVA: 0x001F942D File Offset: 0x001F762D
		[NullableContext(1)]
		public IEnumerable<IntArray> InvalidAreaIter()
		{
			ArtemisQte.<InvalidAreaIter>d__61 <InvalidAreaIter>d__ = new ArtemisQte.<InvalidAreaIter>d__61(-2);
			<InvalidAreaIter>d__.<>3__<>4__this = this;
			return <InvalidAreaIter>d__;
		}

		// Token: 0x06004EBE RID: 20158 RVA: 0x001F9444 File Offset: 0x001F7644
		[NullableContext(1)]
		public Dictionary<int, int> PerfectAppearRate()
		{
			return this.PerfectAppearRateIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004EBF RID: 20159 RVA: 0x001F949A File Offset: 0x001F769A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> PerfectAppearRateIter()
		{
			ArtemisQte.<PerfectAppearRateIter>d__63 <PerfectAppearRateIter>d__ = new ArtemisQte.<PerfectAppearRateIter>d__63(-2);
			<PerfectAppearRateIter>d__.<>3__<>4__this = this;
			return <PerfectAppearRateIter>d__;
		}

		// Token: 0x06004EC0 RID: 20160 RVA: 0x001F94AF File Offset: 0x001F76AF
		[NullableContext(1)]
		public int[] RandomArea()
		{
			return this.GetRandomAreaArray();
		}

		// Token: 0x06004EC1 RID: 20161 RVA: 0x001F94B7 File Offset: 0x001F76B7
		[NullableContext(1)]
		public IEnumerable<int> RandomAreaIter()
		{
			ArtemisQte.<RandomAreaIter>d__65 <RandomAreaIter>d__ = new ArtemisQte.<RandomAreaIter>d__65(-2);
			<RandomAreaIter>d__.<>3__<>4__this = this;
			return <RandomAreaIter>d__;
		}

		// Token: 0x06004EC2 RID: 20162 RVA: 0x001F94CC File Offset: 0x001F76CC
		[NullableContext(1)]
		public Dictionary<int, int> RouletteRotateSpeed()
		{
			return this.RouletteRotateSpeedIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004EC3 RID: 20163 RVA: 0x001F9522 File Offset: 0x001F7722
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RouletteRotateSpeedIter()
		{
			ArtemisQte.<RouletteRotateSpeedIter>d__67 <RouletteRotateSpeedIter>d__ = new ArtemisQte.<RouletteRotateSpeedIter>d__67(-2);
			<RouletteRotateSpeedIter>d__.<>3__<>4__this = this;
			return <RouletteRotateSpeedIter>d__;
		}

		// Token: 0x06004EC4 RID: 20164 RVA: 0x001F9538 File Offset: 0x001F7738
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

		// Token: 0x06004EC5 RID: 20165 RVA: 0x001F956C File Offset: 0x001F776C
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

		// Token: 0x06004EC6 RID: 20166 RVA: 0x001F95A0 File Offset: 0x001F77A0
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

		// Token: 0x06004EC7 RID: 20167 RVA: 0x001F95D4 File Offset: 0x001F77D4
		private void EnsureCursorSpeedCacheIfNeeded()
		{
			if (this.CursorSpeedCache != null)
			{
				return;
			}
			this.CursorSpeedCache = this.CursorSpeedIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004EC8 RID: 20168 RVA: 0x001F963C File Offset: 0x001F783C
		private void EnsurePerfectAppearRateCacheIfNeeded()
		{
			if (this.PerfectAppearRateCache != null)
			{
				return;
			}
			this.PerfectAppearRateCache = this.PerfectAppearRateIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004EC9 RID: 20169 RVA: 0x001F96A4 File Offset: 0x001F78A4
		private void EnsureRouletteRotateSpeedCacheIfNeeded()
		{
			if (this.RouletteRotateSpeedCache != null)
			{
				return;
			}
			this.RouletteRotateSpeedCache = this.RouletteRotateSpeedIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004ECA RID: 20170 RVA: 0x001F970A File Offset: 0x001F790A
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetCursorSpeedFrozenDict()
		{
			this.EnsureCursorSpeedCacheIfNeeded();
			return this.CursorSpeedCache;
		}

		// Token: 0x06004ECB RID: 20171 RVA: 0x001F9718 File Offset: 0x001F7918
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetPerfectAppearRateFrozenDict()
		{
			this.EnsurePerfectAppearRateCacheIfNeeded();
			return this.PerfectAppearRateCache;
		}

		// Token: 0x06004ECC RID: 20172 RVA: 0x001F9726 File Offset: 0x001F7926
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRouletteRotateSpeedFrozenDict()
		{
			this.EnsureRouletteRotateSpeedCacheIfNeeded();
			return this.RouletteRotateSpeedCache;
		}

		// Token: 0x040050CC RID: 20684
		private Table __p;

		// Token: 0x040050CD RID: 20685
		[Nullable(2)]
		private FrozenDictionary<int, int> CursorSpeedCache;

		// Token: 0x040050CE RID: 20686
		[Nullable(2)]
		private FrozenDictionary<int, int> PerfectAppearRateCache;

		// Token: 0x040050CF RID: 20687
		[Nullable(2)]
		private FrozenDictionary<int, int> RouletteRotateSpeedCache;
	}
}

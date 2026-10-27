using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C88 RID: 3208
	public struct FishingQteConfig : IFlatbufferObject
	{
		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x06007013 RID: 28691 RVA: 0x00232F31 File Offset: 0x00231131
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007014 RID: 28692 RVA: 0x00232F3E File Offset: 0x0023113E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007015 RID: 28693 RVA: 0x00232F48 File Offset: 0x00231148
		public static FishingQteConfig GetRootAsFishingQteConfig(ByteBuffer _bb)
		{
			return FishingQteConfig.GetRootAsFishingQteConfig(_bb, default(FishingQteConfig));
		}

		// Token: 0x06007016 RID: 28694 RVA: 0x00232F64 File Offset: 0x00231164
		public static FishingQteConfig GetRootAsFishingQteConfig(ByteBuffer _bb, FishingQteConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007017 RID: 28695 RVA: 0x00232F81 File Offset: 0x00231181
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007018 RID: 28696 RVA: 0x00232F90 File Offset: 0x00231190
		public FishingQteConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x06007019 RID: 28697 RVA: 0x00232FA0 File Offset: 0x002311A0
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

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x0600701A RID: 28698 RVA: 0x00232FDC File Offset: 0x002311DC
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

		// Token: 0x0600701B RID: 28699 RVA: 0x00233013 File Offset: 0x00231213
		public Span<byte> GetCommentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600701C RID: 28700 RVA: 0x00233022 File Offset: 0x00231222
		public byte[] GetCommentArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600701D RID: 28701 RVA: 0x0023303C File Offset: 0x0023123C
		public int RandomArea(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x0600701E RID: 28702 RVA: 0x0023307C File Offset: 0x0023127C
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

		// Token: 0x0600701F RID: 28703 RVA: 0x002330A7 File Offset: 0x002312A7
		public Span<int> GetRandomAreaBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06007020 RID: 28704 RVA: 0x002330B6 File Offset: 0x002312B6
		public int[] GetRandomAreaArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06007021 RID: 28705 RVA: 0x002330D0 File Offset: 0x002312D0
		public IntArray? InvalidArea(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x06007022 RID: 28706 RVA: 0x00233134 File Offset: 0x00231334
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

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x06007023 RID: 28707 RVA: 0x00233160 File Offset: 0x00231360
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

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x06007024 RID: 28708 RVA: 0x002331A0 File Offset: 0x002313A0
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

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x06007025 RID: 28709 RVA: 0x002331E0 File Offset: 0x002313E0
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

		// Token: 0x06007026 RID: 28710 RVA: 0x00233220 File Offset: 0x00231420
		public DicIntInt? PerfectAppearRate(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x06007027 RID: 28711 RVA: 0x00233284 File Offset: 0x00231484
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

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x06007028 RID: 28712 RVA: 0x002332B0 File Offset: 0x002314B0
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

		// Token: 0x06007029 RID: 28713 RVA: 0x002332F0 File Offset: 0x002314F0
		public DicIntInt? CursorSpeed(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x0600702A RID: 28714 RVA: 0x00233354 File Offset: 0x00231554
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

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x0600702B RID: 28715 RVA: 0x00233380 File Offset: 0x00231580
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

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x0600702C RID: 28716 RVA: 0x002333C0 File Offset: 0x002315C0
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

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x0600702D RID: 28717 RVA: 0x00233400 File Offset: 0x00231600
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

		// Token: 0x0600702E RID: 28718 RVA: 0x00233440 File Offset: 0x00231640
		public float HiddenInterval(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x0600702F RID: 28719 RVA: 0x00233484 File Offset: 0x00231684
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

		// Token: 0x06007030 RID: 28720 RVA: 0x002334B0 File Offset: 0x002316B0
		public Span<float> GetHiddenIntervalBytes()
		{
			return this.__p.__vector_as_span<float>(30, 4);
		}

		// Token: 0x06007031 RID: 28721 RVA: 0x002334C0 File Offset: 0x002316C0
		public float[] GetHiddenIntervalArray()
		{
			return this.__p.__vector_as_array<float>(30) ?? Array.Empty<float>();
		}

		// Token: 0x06007032 RID: 28722 RVA: 0x002334D8 File Offset: 0x002316D8
		public DicIntInt? RouletteRotateSpeed(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x06007033 RID: 28723 RVA: 0x0023353C File Offset: 0x0023173C
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

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x06007034 RID: 28724 RVA: 0x00233568 File Offset: 0x00231768
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

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x06007035 RID: 28725 RVA: 0x002335A8 File Offset: 0x002317A8
		public bool IsAnticlockwise
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x06007036 RID: 28726 RVA: 0x002335E8 File Offset: 0x002317E8
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

		// Token: 0x06007037 RID: 28727 RVA: 0x00233628 File Offset: 0x00231828
		[NullableContext(1)]
		[Obsolete("已废弃，请使用CursorSpeedFrozenDict()缓存字典，遍历请使用CursorSpeedIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> CursorSpeed()
		{
			return this.CursorSpeedIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06007038 RID: 28728 RVA: 0x0023367E File Offset: 0x0023187E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> CursorSpeedIter()
		{
			FishingQteConfig.<CursorSpeedIter>d__57 <CursorSpeedIter>d__ = new FishingQteConfig.<CursorSpeedIter>d__57(-2);
			<CursorSpeedIter>d__.<>3__<>4__this = this;
			return <CursorSpeedIter>d__;
		}

		// Token: 0x06007039 RID: 28729 RVA: 0x00233694 File Offset: 0x00231894
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用HiddenIntervalIter()或GetHiddenIntervalBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] HiddenInterval()
		{
			FishingQteConfig fishingQteConfig = this;
			return fishingQteConfig.GetHiddenIntervalArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600703A RID: 28730 RVA: 0x002336B8 File Offset: 0x002318B8
		[NullableContext(1)]
		public readonly IEnumerable<float> HiddenIntervalIter()
		{
			FishingQteConfig.<HiddenIntervalIter>d__59 <HiddenIntervalIter>d__ = new FishingQteConfig.<HiddenIntervalIter>d__59(-2);
			<HiddenIntervalIter>d__.<>3__<>4__this = this;
			return <HiddenIntervalIter>d__;
		}

		// Token: 0x0600703B RID: 28731 RVA: 0x002336CD File Offset: 0x002318CD
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InvalidAreaIter()或GetInvalidAreaBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] InvalidArea()
		{
			return this.InvalidAreaIter().ToArray<IntArray>();
		}

		// Token: 0x0600703C RID: 28732 RVA: 0x002336DA File Offset: 0x002318DA
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> InvalidAreaIter()
		{
			FishingQteConfig.<InvalidAreaIter>d__61 <InvalidAreaIter>d__ = new FishingQteConfig.<InvalidAreaIter>d__61(-2);
			<InvalidAreaIter>d__.<>3__<>4__this = this;
			return <InvalidAreaIter>d__;
		}

		// Token: 0x0600703D RID: 28733 RVA: 0x002336F0 File Offset: 0x002318F0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用PerfectAppearRateFrozenDict()缓存字典，遍历请使用PerfectAppearRateIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> PerfectAppearRate()
		{
			return this.PerfectAppearRateIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600703E RID: 28734 RVA: 0x00233746 File Offset: 0x00231946
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> PerfectAppearRateIter()
		{
			FishingQteConfig.<PerfectAppearRateIter>d__63 <PerfectAppearRateIter>d__ = new FishingQteConfig.<PerfectAppearRateIter>d__63(-2);
			<PerfectAppearRateIter>d__.<>3__<>4__this = this;
			return <PerfectAppearRateIter>d__;
		}

		// Token: 0x0600703F RID: 28735 RVA: 0x0023375C File Offset: 0x0023195C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RandomAreaIter()或GetRandomAreaBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RandomArea()
		{
			FishingQteConfig fishingQteConfig = this;
			return fishingQteConfig.GetRandomAreaArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007040 RID: 28736 RVA: 0x00233780 File Offset: 0x00231980
		[NullableContext(1)]
		public readonly IEnumerable<int> RandomAreaIter()
		{
			FishingQteConfig.<RandomAreaIter>d__65 <RandomAreaIter>d__ = new FishingQteConfig.<RandomAreaIter>d__65(-2);
			<RandomAreaIter>d__.<>3__<>4__this = this;
			return <RandomAreaIter>d__;
		}

		// Token: 0x06007041 RID: 28737 RVA: 0x00233798 File Offset: 0x00231998
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RouletteRotateSpeedFrozenDict()缓存字典，遍历请使用RouletteRotateSpeedIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> RouletteRotateSpeed()
		{
			return this.RouletteRotateSpeedIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06007042 RID: 28738 RVA: 0x002337EE File Offset: 0x002319EE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RouletteRotateSpeedIter()
		{
			FishingQteConfig.<RouletteRotateSpeedIter>d__67 <RouletteRotateSpeedIter>d__ = new FishingQteConfig.<RouletteRotateSpeedIter>d__67(-2);
			<RouletteRotateSpeedIter>d__.<>3__<>4__this = this;
			return <RouletteRotateSpeedIter>d__;
		}

		// Token: 0x06007043 RID: 28739 RVA: 0x00233804 File Offset: 0x00231A04
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

		// Token: 0x06007044 RID: 28740 RVA: 0x00233838 File Offset: 0x00231A38
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

		// Token: 0x06007045 RID: 28741 RVA: 0x0023386C File Offset: 0x00231A6C
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

		// Token: 0x06007046 RID: 28742 RVA: 0x002338A0 File Offset: 0x00231AA0
		private void EnsureCursorSpeedCacheIfNeeded()
		{
			if (this.CursorSpeedCache != null)
			{
				return;
			}
			this.CursorSpeedCache = this.CursorSpeedIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007047 RID: 28743 RVA: 0x00233908 File Offset: 0x00231B08
		private void EnsurePerfectAppearRateCacheIfNeeded()
		{
			if (this.PerfectAppearRateCache != null)
			{
				return;
			}
			this.PerfectAppearRateCache = this.PerfectAppearRateIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007048 RID: 28744 RVA: 0x00233970 File Offset: 0x00231B70
		private void EnsureRouletteRotateSpeedCacheIfNeeded()
		{
			if (this.RouletteRotateSpeedCache != null)
			{
				return;
			}
			this.RouletteRotateSpeedCache = this.RouletteRotateSpeedIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007049 RID: 28745 RVA: 0x002339D6 File Offset: 0x00231BD6
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetCursorSpeedFrozenDict(int key)
		{
			this.EnsureCursorSpeedCacheIfNeeded();
			return this.CursorSpeedCache;
		}

		// Token: 0x0600704A RID: 28746 RVA: 0x002339E4 File Offset: 0x00231BE4
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetPerfectAppearRateFrozenDict(int key)
		{
			this.EnsurePerfectAppearRateCacheIfNeeded();
			return this.PerfectAppearRateCache;
		}

		// Token: 0x0600704B RID: 28747 RVA: 0x002339F2 File Offset: 0x00231BF2
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRouletteRotateSpeedFrozenDict(int key)
		{
			this.EnsureRouletteRotateSpeedCacheIfNeeded();
			return this.RouletteRotateSpeedCache;
		}

		// Token: 0x04004CDA RID: 19674
		private Table __p;

		// Token: 0x04004CDB RID: 19675
		[Nullable(2)]
		private FrozenDictionary<int, int> CursorSpeedCache;

		// Token: 0x04004CDC RID: 19676
		[Nullable(2)]
		private FrozenDictionary<int, int> PerfectAppearRateCache;

		// Token: 0x04004CDD RID: 19677
		[Nullable(2)]
		private FrozenDictionary<int, int> RouletteRotateSpeedCache;
	}
}

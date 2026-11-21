using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D6C RID: 3436
	public struct FishingQteConfig : IFlatbufferObject
	{
		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x0600761E RID: 30238 RVA: 0x00252063 File Offset: 0x00250263
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600761F RID: 30239 RVA: 0x00252070 File Offset: 0x00250270
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007620 RID: 30240 RVA: 0x00252078 File Offset: 0x00250278
		public static FishingQteConfig GetRootAsFishingQteConfig(ByteBuffer _bb)
		{
			return FishingQteConfig.GetRootAsFishingQteConfig(_bb, default(FishingQteConfig));
		}

		// Token: 0x06007621 RID: 30241 RVA: 0x00252094 File Offset: 0x00250294
		public static FishingQteConfig GetRootAsFishingQteConfig(ByteBuffer _bb, FishingQteConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007622 RID: 30242 RVA: 0x002520B1 File Offset: 0x002502B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007623 RID: 30243 RVA: 0x002520C0 File Offset: 0x002502C0
		public FishingQteConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x06007624 RID: 30244 RVA: 0x002520D0 File Offset: 0x002502D0
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

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x06007625 RID: 30245 RVA: 0x0025210C File Offset: 0x0025030C
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

		// Token: 0x06007626 RID: 30246 RVA: 0x00252143 File Offset: 0x00250343
		public Span<byte> GetCommentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007627 RID: 30247 RVA: 0x00252152 File Offset: 0x00250352
		public byte[] GetCommentArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06007628 RID: 30248 RVA: 0x0025216C File Offset: 0x0025036C
		public int RandomArea(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x06007629 RID: 30249 RVA: 0x002521AC File Offset: 0x002503AC
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

		// Token: 0x0600762A RID: 30250 RVA: 0x002521D7 File Offset: 0x002503D7
		public Span<int> GetRandomAreaBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600762B RID: 30251 RVA: 0x002521E6 File Offset: 0x002503E6
		public int[] GetRandomAreaArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600762C RID: 30252 RVA: 0x00252200 File Offset: 0x00250400
		public IntArray? InvalidArea(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x0600762D RID: 30253 RVA: 0x00252264 File Offset: 0x00250464
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

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x0600762E RID: 30254 RVA: 0x00252290 File Offset: 0x00250490
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

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x0600762F RID: 30255 RVA: 0x002522D0 File Offset: 0x002504D0
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

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x06007630 RID: 30256 RVA: 0x00252310 File Offset: 0x00250510
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

		// Token: 0x06007631 RID: 30257 RVA: 0x00252350 File Offset: 0x00250550
		public DicIntInt? PerfectAppearRate(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x06007632 RID: 30258 RVA: 0x002523B4 File Offset: 0x002505B4
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

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x06007633 RID: 30259 RVA: 0x002523E0 File Offset: 0x002505E0
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

		// Token: 0x06007634 RID: 30260 RVA: 0x00252420 File Offset: 0x00250620
		public DicIntInt? CursorSpeed(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x06007635 RID: 30261 RVA: 0x00252484 File Offset: 0x00250684
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

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x06007636 RID: 30262 RVA: 0x002524B0 File Offset: 0x002506B0
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

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x06007637 RID: 30263 RVA: 0x002524F0 File Offset: 0x002506F0
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

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x06007638 RID: 30264 RVA: 0x00252530 File Offset: 0x00250730
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

		// Token: 0x06007639 RID: 30265 RVA: 0x00252570 File Offset: 0x00250770
		public float HiddenInterval(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x0600763A RID: 30266 RVA: 0x002525B4 File Offset: 0x002507B4
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

		// Token: 0x0600763B RID: 30267 RVA: 0x002525E0 File Offset: 0x002507E0
		public Span<float> GetHiddenIntervalBytes()
		{
			return this.__p.__vector_as_span<float>(30, 4);
		}

		// Token: 0x0600763C RID: 30268 RVA: 0x002525F0 File Offset: 0x002507F0
		public float[] GetHiddenIntervalArray()
		{
			return this.__p.__vector_as_array<float>(30) ?? Array.Empty<float>();
		}

		// Token: 0x0600763D RID: 30269 RVA: 0x00252608 File Offset: 0x00250808
		public DicIntInt? RouletteRotateSpeed(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x0600763E RID: 30270 RVA: 0x0025266C File Offset: 0x0025086C
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

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x0600763F RID: 30271 RVA: 0x00252698 File Offset: 0x00250898
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

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x06007640 RID: 30272 RVA: 0x002526D8 File Offset: 0x002508D8
		public bool IsAnticlockwise
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x06007641 RID: 30273 RVA: 0x00252718 File Offset: 0x00250918
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

		// Token: 0x06007642 RID: 30274 RVA: 0x00252758 File Offset: 0x00250958
		[NullableContext(1)]
		public Dictionary<int, int> CursorSpeed()
		{
			return this.CursorSpeedIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06007643 RID: 30275 RVA: 0x002527AE File Offset: 0x002509AE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> CursorSpeedIter()
		{
			FishingQteConfig.<CursorSpeedIter>d__57 <CursorSpeedIter>d__ = new FishingQteConfig.<CursorSpeedIter>d__57(-2);
			<CursorSpeedIter>d__.<>3__<>4__this = this;
			return <CursorSpeedIter>d__;
		}

		// Token: 0x06007644 RID: 30276 RVA: 0x002527C3 File Offset: 0x002509C3
		[NullableContext(1)]
		public float[] HiddenInterval()
		{
			return this.GetHiddenIntervalArray();
		}

		// Token: 0x06007645 RID: 30277 RVA: 0x002527CB File Offset: 0x002509CB
		[NullableContext(1)]
		public IEnumerable<float> HiddenIntervalIter()
		{
			FishingQteConfig.<HiddenIntervalIter>d__59 <HiddenIntervalIter>d__ = new FishingQteConfig.<HiddenIntervalIter>d__59(-2);
			<HiddenIntervalIter>d__.<>3__<>4__this = this;
			return <HiddenIntervalIter>d__;
		}

		// Token: 0x06007646 RID: 30278 RVA: 0x002527E0 File Offset: 0x002509E0
		[NullableContext(1)]
		public IntArray[] InvalidArea()
		{
			return this.InvalidAreaIter().ToArray<IntArray>();
		}

		// Token: 0x06007647 RID: 30279 RVA: 0x002527ED File Offset: 0x002509ED
		[NullableContext(1)]
		public IEnumerable<IntArray> InvalidAreaIter()
		{
			FishingQteConfig.<InvalidAreaIter>d__61 <InvalidAreaIter>d__ = new FishingQteConfig.<InvalidAreaIter>d__61(-2);
			<InvalidAreaIter>d__.<>3__<>4__this = this;
			return <InvalidAreaIter>d__;
		}

		// Token: 0x06007648 RID: 30280 RVA: 0x00252804 File Offset: 0x00250A04
		[NullableContext(1)]
		public Dictionary<int, int> PerfectAppearRate()
		{
			return this.PerfectAppearRateIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06007649 RID: 30281 RVA: 0x0025285A File Offset: 0x00250A5A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> PerfectAppearRateIter()
		{
			FishingQteConfig.<PerfectAppearRateIter>d__63 <PerfectAppearRateIter>d__ = new FishingQteConfig.<PerfectAppearRateIter>d__63(-2);
			<PerfectAppearRateIter>d__.<>3__<>4__this = this;
			return <PerfectAppearRateIter>d__;
		}

		// Token: 0x0600764A RID: 30282 RVA: 0x0025286F File Offset: 0x00250A6F
		[NullableContext(1)]
		public int[] RandomArea()
		{
			return this.GetRandomAreaArray();
		}

		// Token: 0x0600764B RID: 30283 RVA: 0x00252877 File Offset: 0x00250A77
		[NullableContext(1)]
		public IEnumerable<int> RandomAreaIter()
		{
			FishingQteConfig.<RandomAreaIter>d__65 <RandomAreaIter>d__ = new FishingQteConfig.<RandomAreaIter>d__65(-2);
			<RandomAreaIter>d__.<>3__<>4__this = this;
			return <RandomAreaIter>d__;
		}

		// Token: 0x0600764C RID: 30284 RVA: 0x0025288C File Offset: 0x00250A8C
		[NullableContext(1)]
		public Dictionary<int, int> RouletteRotateSpeed()
		{
			return this.RouletteRotateSpeedIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600764D RID: 30285 RVA: 0x002528E2 File Offset: 0x00250AE2
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RouletteRotateSpeedIter()
		{
			FishingQteConfig.<RouletteRotateSpeedIter>d__67 <RouletteRotateSpeedIter>d__ = new FishingQteConfig.<RouletteRotateSpeedIter>d__67(-2);
			<RouletteRotateSpeedIter>d__.<>3__<>4__this = this;
			return <RouletteRotateSpeedIter>d__;
		}

		// Token: 0x0600764E RID: 30286 RVA: 0x002528F8 File Offset: 0x00250AF8
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

		// Token: 0x0600764F RID: 30287 RVA: 0x0025292C File Offset: 0x00250B2C
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

		// Token: 0x06007650 RID: 30288 RVA: 0x00252960 File Offset: 0x00250B60
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

		// Token: 0x06007651 RID: 30289 RVA: 0x00252994 File Offset: 0x00250B94
		private void EnsureCursorSpeedCacheIfNeeded()
		{
			if (this.CursorSpeedCache != null)
			{
				return;
			}
			this.CursorSpeedCache = this.CursorSpeedIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007652 RID: 30290 RVA: 0x002529FC File Offset: 0x00250BFC
		private void EnsurePerfectAppearRateCacheIfNeeded()
		{
			if (this.PerfectAppearRateCache != null)
			{
				return;
			}
			this.PerfectAppearRateCache = this.PerfectAppearRateIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007653 RID: 30291 RVA: 0x00252A64 File Offset: 0x00250C64
		private void EnsureRouletteRotateSpeedCacheIfNeeded()
		{
			if (this.RouletteRotateSpeedCache != null)
			{
				return;
			}
			this.RouletteRotateSpeedCache = this.RouletteRotateSpeedIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007654 RID: 30292 RVA: 0x00252ACA File Offset: 0x00250CCA
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetCursorSpeedFrozenDict()
		{
			this.EnsureCursorSpeedCacheIfNeeded();
			return this.CursorSpeedCache;
		}

		// Token: 0x06007655 RID: 30293 RVA: 0x00252AD8 File Offset: 0x00250CD8
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetPerfectAppearRateFrozenDict()
		{
			this.EnsurePerfectAppearRateCacheIfNeeded();
			return this.PerfectAppearRateCache;
		}

		// Token: 0x06007656 RID: 30294 RVA: 0x00252AE6 File Offset: 0x00250CE6
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRouletteRotateSpeedFrozenDict()
		{
			this.EnsureRouletteRotateSpeedCacheIfNeeded();
			return this.RouletteRotateSpeedCache;
		}

		// Token: 0x040052BE RID: 21182
		private Table __p;

		// Token: 0x040052BF RID: 21183
		[Nullable(2)]
		private FrozenDictionary<int, int> CursorSpeedCache;

		// Token: 0x040052C0 RID: 21184
		[Nullable(2)]
		private FrozenDictionary<int, int> PerfectAppearRateCache;

		// Token: 0x040052C1 RID: 21185
		[Nullable(2)]
		private FrozenDictionary<int, int> RouletteRotateSpeedCache;
	}
}

using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FC6 RID: 4038
	public struct RhythmSubLevel : IFlatbufferObject
	{
		// Token: 0x17002E5D RID: 11869
		// (get) Token: 0x0600BCD9 RID: 48345 RVA: 0x002DFF11 File Offset: 0x002DE111
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BCDA RID: 48346 RVA: 0x002DFF1E File Offset: 0x002DE11E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BCDB RID: 48347 RVA: 0x002DFF28 File Offset: 0x002DE128
		public static RhythmSubLevel GetRootAsRhythmSubLevel(ByteBuffer _bb)
		{
			return RhythmSubLevel.GetRootAsRhythmSubLevel(_bb, default(RhythmSubLevel));
		}

		// Token: 0x0600BCDC RID: 48348 RVA: 0x002DFF44 File Offset: 0x002DE144
		public static RhythmSubLevel GetRootAsRhythmSubLevel(ByteBuffer _bb, RhythmSubLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BCDD RID: 48349 RVA: 0x002DFF61 File Offset: 0x002DE161
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BCDE RID: 48350 RVA: 0x002DFF70 File Offset: 0x002DE170
		public RhythmSubLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E5E RID: 11870
		// (get) Token: 0x0600BCDF RID: 48351 RVA: 0x002DFF80 File Offset: 0x002DE180
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

		// Token: 0x17002E5F RID: 11871
		// (get) Token: 0x0600BCE0 RID: 48352 RVA: 0x002DFFBC File Offset: 0x002DE1BC
		public int LevelId
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

		// Token: 0x17002E60 RID: 11872
		// (get) Token: 0x0600BCE1 RID: 48353 RVA: 0x002DFFF8 File Offset: 0x002DE1F8
		public int InstId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BCE2 RID: 48354 RVA: 0x002E0034 File Offset: 0x002DE234
		public DicIntInt? PreLevel(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002E61 RID: 11873
		// (get) Token: 0x0600BCE3 RID: 48355 RVA: 0x002E0098 File Offset: 0x002DE298
		public int PreLevelLength
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

		// Token: 0x17002E62 RID: 11874
		// (get) Token: 0x0600BCE4 RID: 48356 RVA: 0x002E00C4 File Offset: 0x002DE2C4
		public int Difficulty
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002E63 RID: 11875
		// (get) Token: 0x0600BCE5 RID: 48357 RVA: 0x002E0104 File Offset: 0x002DE304
		public int StarLevel
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002E64 RID: 11876
		// (get) Token: 0x0600BCE6 RID: 48358 RVA: 0x002E0144 File Offset: 0x002DE344
		public int JsonId
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

		// Token: 0x0600BCE7 RID: 48359 RVA: 0x002E0184 File Offset: 0x002DE384
		public int RatingJudNew(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002E65 RID: 11877
		// (get) Token: 0x0600BCE8 RID: 48360 RVA: 0x002E01C4 File Offset: 0x002DE3C4
		public int RatingJudNewLength
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

		// Token: 0x0600BCE9 RID: 48361 RVA: 0x002E01F0 File Offset: 0x002DE3F0
		public Span<int> GetRatingJudNewBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600BCEA RID: 48362 RVA: 0x002E0200 File Offset: 0x002DE400
		public int[] GetRatingJudNewArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17002E66 RID: 11878
		// (get) Token: 0x0600BCEB RID: 48363 RVA: 0x002E0218 File Offset: 0x002DE418
		public string LockTips
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BCEC RID: 48364 RVA: 0x002E0250 File Offset: 0x002DE450
		public Span<byte> GetLockTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600BCED RID: 48365 RVA: 0x002E0260 File Offset: 0x002DE460
		public byte[] GetLockTipsArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BCEE RID: 48366 RVA: 0x002E0278 File Offset: 0x002DE478
		public int Guide(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002E67 RID: 11879
		// (get) Token: 0x0600BCEF RID: 48367 RVA: 0x002E02B8 File Offset: 0x002DE4B8
		public int GuideLength
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

		// Token: 0x0600BCF0 RID: 48368 RVA: 0x002E02E4 File Offset: 0x002DE4E4
		public Span<int> GetGuideBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600BCF1 RID: 48369 RVA: 0x002E02F4 File Offset: 0x002DE4F4
		public int[] GetGuideArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600BCF2 RID: 48370 RVA: 0x002E030C File Offset: 0x002DE50C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GuideIter()或GetGuideBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Guide()
		{
			RhythmSubLevel rhythmSubLevel = this;
			return rhythmSubLevel.GetGuideArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BCF3 RID: 48371 RVA: 0x002E0330 File Offset: 0x002DE530
		[NullableContext(1)]
		public readonly IEnumerable<int> GuideIter()
		{
			RhythmSubLevel.<GuideIter>d__38 <GuideIter>d__ = new RhythmSubLevel.<GuideIter>d__38(-2);
			<GuideIter>d__.<>3__<>4__this = this;
			return <GuideIter>d__;
		}

		// Token: 0x0600BCF4 RID: 48372 RVA: 0x002E0348 File Offset: 0x002DE548
		[NullableContext(1)]
		[Obsolete("已废弃，请使用PreLevelFrozenDict()缓存字典，遍历请使用PreLevelIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> PreLevel()
		{
			return this.PreLevelIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600BCF5 RID: 48373 RVA: 0x002E039E File Offset: 0x002DE59E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> PreLevelIter()
		{
			RhythmSubLevel.<PreLevelIter>d__40 <PreLevelIter>d__ = new RhythmSubLevel.<PreLevelIter>d__40(-2);
			<PreLevelIter>d__.<>3__<>4__this = this;
			return <PreLevelIter>d__;
		}

		// Token: 0x0600BCF6 RID: 48374 RVA: 0x002E03B4 File Offset: 0x002DE5B4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RatingJudNewIter()或GetRatingJudNewBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RatingJudNew()
		{
			RhythmSubLevel rhythmSubLevel = this;
			return rhythmSubLevel.GetRatingJudNewArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BCF7 RID: 48375 RVA: 0x002E03D8 File Offset: 0x002DE5D8
		[NullableContext(1)]
		public readonly IEnumerable<int> RatingJudNewIter()
		{
			RhythmSubLevel.<RatingJudNewIter>d__42 <RatingJudNewIter>d__ = new RhythmSubLevel.<RatingJudNewIter>d__42(-2);
			<RatingJudNewIter>d__.<>3__<>4__this = this;
			return <RatingJudNewIter>d__;
		}

		// Token: 0x0600BCF8 RID: 48376 RVA: 0x002E03F0 File Offset: 0x002DE5F0
		public int? GetPreLevel(int key)
		{
			this.EnsurePreLevelCacheIfNeeded();
			int value;
			if (!this.PreLevelCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600BCF9 RID: 48377 RVA: 0x002E0424 File Offset: 0x002DE624
		private void EnsurePreLevelCacheIfNeeded()
		{
			if (this.PreLevelCache != null)
			{
				return;
			}
			this.PreLevelCache = this.PreLevelIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600BCFA RID: 48378 RVA: 0x002E048A File Offset: 0x002DE68A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetPreLevelFrozenDict(int key)
		{
			this.EnsurePreLevelCacheIfNeeded();
			return this.PreLevelCache;
		}

		// Token: 0x040050A0 RID: 20640
		private Table __p;

		// Token: 0x040050A1 RID: 20641
		[Nullable(2)]
		private FrozenDictionary<int, int> PreLevelCache;
	}
}

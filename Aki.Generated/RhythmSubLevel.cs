using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010AE RID: 4270
	public struct RhythmSubLevel : IFlatbufferObject
	{
		// Token: 0x17002ED8 RID: 11992
		// (get) Token: 0x0600C323 RID: 49955 RVA: 0x002FC595 File Offset: 0x002FA795
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C324 RID: 49956 RVA: 0x002FC5A2 File Offset: 0x002FA7A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C325 RID: 49957 RVA: 0x002FC5AC File Offset: 0x002FA7AC
		public static RhythmSubLevel GetRootAsRhythmSubLevel(ByteBuffer _bb)
		{
			return RhythmSubLevel.GetRootAsRhythmSubLevel(_bb, default(RhythmSubLevel));
		}

		// Token: 0x0600C326 RID: 49958 RVA: 0x002FC5C8 File Offset: 0x002FA7C8
		public static RhythmSubLevel GetRootAsRhythmSubLevel(ByteBuffer _bb, RhythmSubLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C327 RID: 49959 RVA: 0x002FC5E5 File Offset: 0x002FA7E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C328 RID: 49960 RVA: 0x002FC5F4 File Offset: 0x002FA7F4
		public RhythmSubLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002ED9 RID: 11993
		// (get) Token: 0x0600C329 RID: 49961 RVA: 0x002FC604 File Offset: 0x002FA804
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

		// Token: 0x17002EDA RID: 11994
		// (get) Token: 0x0600C32A RID: 49962 RVA: 0x002FC640 File Offset: 0x002FA840
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

		// Token: 0x17002EDB RID: 11995
		// (get) Token: 0x0600C32B RID: 49963 RVA: 0x002FC67C File Offset: 0x002FA87C
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

		// Token: 0x0600C32C RID: 49964 RVA: 0x002FC6B8 File Offset: 0x002FA8B8
		public DicIntInt? PreLevel(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002EDC RID: 11996
		// (get) Token: 0x0600C32D RID: 49965 RVA: 0x002FC71C File Offset: 0x002FA91C
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

		// Token: 0x17002EDD RID: 11997
		// (get) Token: 0x0600C32E RID: 49966 RVA: 0x002FC748 File Offset: 0x002FA948
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

		// Token: 0x17002EDE RID: 11998
		// (get) Token: 0x0600C32F RID: 49967 RVA: 0x002FC788 File Offset: 0x002FA988
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

		// Token: 0x17002EDF RID: 11999
		// (get) Token: 0x0600C330 RID: 49968 RVA: 0x002FC7C8 File Offset: 0x002FA9C8
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

		// Token: 0x0600C331 RID: 49969 RVA: 0x002FC808 File Offset: 0x002FAA08
		public int RatingJudNew(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002EE0 RID: 12000
		// (get) Token: 0x0600C332 RID: 49970 RVA: 0x002FC848 File Offset: 0x002FAA48
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

		// Token: 0x0600C333 RID: 49971 RVA: 0x002FC874 File Offset: 0x002FAA74
		public Span<int> GetRatingJudNewBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600C334 RID: 49972 RVA: 0x002FC884 File Offset: 0x002FAA84
		public int[] GetRatingJudNewArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17002EE1 RID: 12001
		// (get) Token: 0x0600C335 RID: 49973 RVA: 0x002FC89C File Offset: 0x002FAA9C
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

		// Token: 0x0600C336 RID: 49974 RVA: 0x002FC8D4 File Offset: 0x002FAAD4
		public Span<byte> GetLockTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C337 RID: 49975 RVA: 0x002FC8E4 File Offset: 0x002FAAE4
		public byte[] GetLockTipsArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C338 RID: 49976 RVA: 0x002FC8FC File Offset: 0x002FAAFC
		public int Guide(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002EE2 RID: 12002
		// (get) Token: 0x0600C339 RID: 49977 RVA: 0x002FC93C File Offset: 0x002FAB3C
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

		// Token: 0x0600C33A RID: 49978 RVA: 0x002FC968 File Offset: 0x002FAB68
		public Span<int> GetGuideBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600C33B RID: 49979 RVA: 0x002FC978 File Offset: 0x002FAB78
		public int[] GetGuideArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600C33C RID: 49980 RVA: 0x002FC990 File Offset: 0x002FAB90
		[NullableContext(1)]
		public int[] Guide()
		{
			return this.GetGuideArray();
		}

		// Token: 0x0600C33D RID: 49981 RVA: 0x002FC998 File Offset: 0x002FAB98
		[NullableContext(1)]
		public IEnumerable<int> GuideIter()
		{
			RhythmSubLevel.<GuideIter>d__38 <GuideIter>d__ = new RhythmSubLevel.<GuideIter>d__38(-2);
			<GuideIter>d__.<>3__<>4__this = this;
			return <GuideIter>d__;
		}

		// Token: 0x0600C33E RID: 49982 RVA: 0x002FC9B0 File Offset: 0x002FABB0
		[NullableContext(1)]
		public Dictionary<int, int> PreLevel()
		{
			return this.PreLevelIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C33F RID: 49983 RVA: 0x002FCA06 File Offset: 0x002FAC06
		[NullableContext(1)]
		public IEnumerable<DicIntInt> PreLevelIter()
		{
			RhythmSubLevel.<PreLevelIter>d__40 <PreLevelIter>d__ = new RhythmSubLevel.<PreLevelIter>d__40(-2);
			<PreLevelIter>d__.<>3__<>4__this = this;
			return <PreLevelIter>d__;
		}

		// Token: 0x0600C340 RID: 49984 RVA: 0x002FCA1B File Offset: 0x002FAC1B
		[NullableContext(1)]
		public int[] RatingJudNew()
		{
			return this.GetRatingJudNewArray();
		}

		// Token: 0x0600C341 RID: 49985 RVA: 0x002FCA23 File Offset: 0x002FAC23
		[NullableContext(1)]
		public IEnumerable<int> RatingJudNewIter()
		{
			RhythmSubLevel.<RatingJudNewIter>d__42 <RatingJudNewIter>d__ = new RhythmSubLevel.<RatingJudNewIter>d__42(-2);
			<RatingJudNewIter>d__.<>3__<>4__this = this;
			return <RatingJudNewIter>d__;
		}

		// Token: 0x0600C342 RID: 49986 RVA: 0x002FCA38 File Offset: 0x002FAC38
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

		// Token: 0x0600C343 RID: 49987 RVA: 0x002FCA6C File Offset: 0x002FAC6C
		private void EnsurePreLevelCacheIfNeeded()
		{
			if (this.PreLevelCache != null)
			{
				return;
			}
			this.PreLevelCache = this.PreLevelIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C344 RID: 49988 RVA: 0x002FCAD2 File Offset: 0x002FACD2
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetPreLevelFrozenDict()
		{
			this.EnsurePreLevelCacheIfNeeded();
			return this.PreLevelCache;
		}

		// Token: 0x04005688 RID: 22152
		private Table __p;

		// Token: 0x04005689 RID: 22153
		[Nullable(2)]
		private FrozenDictionary<int, int> PreLevelCache;
	}
}

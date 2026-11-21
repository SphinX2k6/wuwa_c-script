using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D30 RID: 3376
	public struct ExploreProgress : IFlatbufferObject
	{
		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x0600713E RID: 28990 RVA: 0x00246DE1 File Offset: 0x00244FE1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600713F RID: 28991 RVA: 0x00246DEE File Offset: 0x00244FEE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007140 RID: 28992 RVA: 0x00246DF8 File Offset: 0x00244FF8
		public static ExploreProgress GetRootAsExploreProgress(ByteBuffer _bb)
		{
			return ExploreProgress.GetRootAsExploreProgress(_bb, default(ExploreProgress));
		}

		// Token: 0x06007141 RID: 28993 RVA: 0x00246E14 File Offset: 0x00245014
		public static ExploreProgress GetRootAsExploreProgress(ByteBuffer _bb, ExploreProgress obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007142 RID: 28994 RVA: 0x00246E31 File Offset: 0x00245031
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007143 RID: 28995 RVA: 0x00246E40 File Offset: 0x00245040
		public ExploreProgress __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x06007144 RID: 28996 RVA: 0x00246E50 File Offset: 0x00245050
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

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x06007145 RID: 28997 RVA: 0x00246E8C File Offset: 0x0024508C
		public int Area
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

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x06007146 RID: 28998 RVA: 0x00246EC8 File Offset: 0x002450C8
		public int ExploreType
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

		// Token: 0x06007147 RID: 28999 RVA: 0x00246F04 File Offset: 0x00245104
		public DicIntInt? SubTypeScore(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x06007148 RID: 29000 RVA: 0x00246F68 File Offset: 0x00245168
		public int SubTypeScoreLength
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

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x06007149 RID: 29001 RVA: 0x00246F94 File Offset: 0x00245194
		public int PhantomSkillId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x0600714A RID: 29002 RVA: 0x00246FD4 File Offset: 0x002451D4
		public string UnlockTextId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600714B RID: 29003 RVA: 0x0024700C File Offset: 0x0024520C
		public Span<byte> GetUnlockTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600714C RID: 29004 RVA: 0x0024701C File Offset: 0x0024521C
		public byte[] GetUnlockTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x0600714D RID: 29005 RVA: 0x00247034 File Offset: 0x00245234
		public string LockTextId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600714E RID: 29006 RVA: 0x0024706C File Offset: 0x0024526C
		public Span<byte> GetLockTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600714F RID: 29007 RVA: 0x0024707C File Offset: 0x0024527C
		public byte[] GetLockTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x06007150 RID: 29008 RVA: 0x00247094 File Offset: 0x00245294
		public int UnlockCondition
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007151 RID: 29009 RVA: 0x002470D4 File Offset: 0x002452D4
		public DicIntInt? SpecialPlayerMap(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x06007152 RID: 29010 RVA: 0x00247138 File Offset: 0x00245338
		public int SpecialPlayerMapLength
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

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x06007153 RID: 29011 RVA: 0x00247164 File Offset: 0x00245364
		public bool IsRecommend
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x06007154 RID: 29012 RVA: 0x002471A4 File Offset: 0x002453A4
		public bool IsShowProgress
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x06007155 RID: 29013 RVA: 0x002471E4 File Offset: 0x002453E4
		public bool IsShowTrack
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x06007156 RID: 29014 RVA: 0x00247224 File Offset: 0x00245424
		public string SpecialPlayerDesc
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007157 RID: 29015 RVA: 0x0024725C File Offset: 0x0024545C
		public Span<byte> GetSpecialPlayerDescBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06007158 RID: 29016 RVA: 0x0024726C File Offset: 0x0024546C
		public byte[] GetSpecialPlayerDescArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x06007159 RID: 29017 RVA: 0x00247284 File Offset: 0x00245484
		public int UnlockTrackType
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x0600715A RID: 29018 RVA: 0x002472C4 File Offset: 0x002454C4
		public int LockTrackType
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x0600715B RID: 29019 RVA: 0x00247304 File Offset: 0x00245504
		public int AccessPathId
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

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x0600715C RID: 29020 RVA: 0x00247344 File Offset: 0x00245544
		public int TagType
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600715D RID: 29021 RVA: 0x00247384 File Offset: 0x00245584
		[NullableContext(1)]
		public Dictionary<int, int> SpecialPlayerMap()
		{
			return this.SpecialPlayerMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600715E RID: 29022 RVA: 0x002473DA File Offset: 0x002455DA
		[NullableContext(1)]
		public IEnumerable<DicIntInt> SpecialPlayerMapIter()
		{
			ExploreProgress.<SpecialPlayerMapIter>d__51 <SpecialPlayerMapIter>d__ = new ExploreProgress.<SpecialPlayerMapIter>d__51(-2);
			<SpecialPlayerMapIter>d__.<>3__<>4__this = this;
			return <SpecialPlayerMapIter>d__;
		}

		// Token: 0x0600715F RID: 29023 RVA: 0x002473F0 File Offset: 0x002455F0
		[NullableContext(1)]
		public Dictionary<int, int> SubTypeScore()
		{
			return this.SubTypeScoreIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06007160 RID: 29024 RVA: 0x00247446 File Offset: 0x00245646
		[NullableContext(1)]
		public IEnumerable<DicIntInt> SubTypeScoreIter()
		{
			ExploreProgress.<SubTypeScoreIter>d__53 <SubTypeScoreIter>d__ = new ExploreProgress.<SubTypeScoreIter>d__53(-2);
			<SubTypeScoreIter>d__.<>3__<>4__this = this;
			return <SubTypeScoreIter>d__;
		}

		// Token: 0x06007161 RID: 29025 RVA: 0x0024745C File Offset: 0x0024565C
		public int? GetSpecialPlayerMap(int key)
		{
			this.EnsureSpecialPlayerMapCacheIfNeeded();
			int value;
			if (!this.SpecialPlayerMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06007162 RID: 29026 RVA: 0x00247490 File Offset: 0x00245690
		public int? GetSubTypeScore(int key)
		{
			this.EnsureSubTypeScoreCacheIfNeeded();
			int value;
			if (!this.SubTypeScoreCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06007163 RID: 29027 RVA: 0x002474C4 File Offset: 0x002456C4
		private void EnsureSpecialPlayerMapCacheIfNeeded()
		{
			if (this.SpecialPlayerMapCache != null)
			{
				return;
			}
			this.SpecialPlayerMapCache = this.SpecialPlayerMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007164 RID: 29028 RVA: 0x0024752C File Offset: 0x0024572C
		private void EnsureSubTypeScoreCacheIfNeeded()
		{
			if (this.SubTypeScoreCache != null)
			{
				return;
			}
			this.SubTypeScoreCache = this.SubTypeScoreIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007165 RID: 29029 RVA: 0x00247592 File Offset: 0x00245792
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetSpecialPlayerMapFrozenDict()
		{
			this.EnsureSpecialPlayerMapCacheIfNeeded();
			return this.SpecialPlayerMapCache;
		}

		// Token: 0x06007166 RID: 29030 RVA: 0x002475A0 File Offset: 0x002457A0
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetSubTypeScoreFrozenDict()
		{
			this.EnsureSubTypeScoreCacheIfNeeded();
			return this.SubTypeScoreCache;
		}

		// Token: 0x04005275 RID: 21109
		private Table __p;

		// Token: 0x04005276 RID: 21110
		[Nullable(2)]
		private FrozenDictionary<int, int> SpecialPlayerMapCache;

		// Token: 0x04005277 RID: 21111
		[Nullable(2)]
		private FrozenDictionary<int, int> SubTypeScoreCache;
	}
}

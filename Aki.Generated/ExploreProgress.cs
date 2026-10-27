using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C4D RID: 3149
	public struct ExploreProgress : IFlatbufferObject
	{
		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x06006B3C RID: 27452 RVA: 0x00227B35 File Offset: 0x00225D35
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006B3D RID: 27453 RVA: 0x00227B42 File Offset: 0x00225D42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006B3E RID: 27454 RVA: 0x00227B4C File Offset: 0x00225D4C
		public static ExploreProgress GetRootAsExploreProgress(ByteBuffer _bb)
		{
			return ExploreProgress.GetRootAsExploreProgress(_bb, default(ExploreProgress));
		}

		// Token: 0x06006B3F RID: 27455 RVA: 0x00227B68 File Offset: 0x00225D68
		public static ExploreProgress GetRootAsExploreProgress(ByteBuffer _bb, ExploreProgress obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006B40 RID: 27456 RVA: 0x00227B85 File Offset: 0x00225D85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006B41 RID: 27457 RVA: 0x00227B94 File Offset: 0x00225D94
		public ExploreProgress __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x06006B42 RID: 27458 RVA: 0x00227BA4 File Offset: 0x00225DA4
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

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x06006B43 RID: 27459 RVA: 0x00227BE0 File Offset: 0x00225DE0
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

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x06006B44 RID: 27460 RVA: 0x00227C1C File Offset: 0x00225E1C
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

		// Token: 0x06006B45 RID: 27461 RVA: 0x00227C58 File Offset: 0x00225E58
		public DicIntInt? SubTypeScore(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x06006B46 RID: 27462 RVA: 0x00227CBC File Offset: 0x00225EBC
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

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x06006B47 RID: 27463 RVA: 0x00227CE8 File Offset: 0x00225EE8
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

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x06006B48 RID: 27464 RVA: 0x00227D28 File Offset: 0x00225F28
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

		// Token: 0x06006B49 RID: 27465 RVA: 0x00227D60 File Offset: 0x00225F60
		public Span<byte> GetUnlockTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006B4A RID: 27466 RVA: 0x00227D70 File Offset: 0x00225F70
		public byte[] GetUnlockTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x06006B4B RID: 27467 RVA: 0x00227D88 File Offset: 0x00225F88
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

		// Token: 0x06006B4C RID: 27468 RVA: 0x00227DC0 File Offset: 0x00225FC0
		public Span<byte> GetLockTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006B4D RID: 27469 RVA: 0x00227DD0 File Offset: 0x00225FD0
		public byte[] GetLockTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x06006B4E RID: 27470 RVA: 0x00227DE8 File Offset: 0x00225FE8
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

		// Token: 0x06006B4F RID: 27471 RVA: 0x00227E28 File Offset: 0x00226028
		public DicIntInt? SpecialPlayerMap(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x06006B50 RID: 27472 RVA: 0x00227E8C File Offset: 0x0022608C
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

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x06006B51 RID: 27473 RVA: 0x00227EB8 File Offset: 0x002260B8
		public bool IsRecommend
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x06006B52 RID: 27474 RVA: 0x00227EF8 File Offset: 0x002260F8
		public bool IsShowProgress
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x06006B53 RID: 27475 RVA: 0x00227F38 File Offset: 0x00226138
		public bool IsShowTrack
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x06006B54 RID: 27476 RVA: 0x00227F78 File Offset: 0x00226178
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

		// Token: 0x06006B55 RID: 27477 RVA: 0x00227FB0 File Offset: 0x002261B0
		public Span<byte> GetSpecialPlayerDescBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06006B56 RID: 27478 RVA: 0x00227FC0 File Offset: 0x002261C0
		public byte[] GetSpecialPlayerDescArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x06006B57 RID: 27479 RVA: 0x00227FD8 File Offset: 0x002261D8
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

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x06006B58 RID: 27480 RVA: 0x00228018 File Offset: 0x00226218
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

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x06006B59 RID: 27481 RVA: 0x00228058 File Offset: 0x00226258
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

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x06006B5A RID: 27482 RVA: 0x00228098 File Offset: 0x00226298
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

		// Token: 0x06006B5B RID: 27483 RVA: 0x002280D8 File Offset: 0x002262D8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SpecialPlayerMapFrozenDict()缓存字典，遍历请使用SpecialPlayerMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> SpecialPlayerMap()
		{
			return this.SpecialPlayerMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006B5C RID: 27484 RVA: 0x0022812E File Offset: 0x0022632E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> SpecialPlayerMapIter()
		{
			ExploreProgress.<SpecialPlayerMapIter>d__51 <SpecialPlayerMapIter>d__ = new ExploreProgress.<SpecialPlayerMapIter>d__51(-2);
			<SpecialPlayerMapIter>d__.<>3__<>4__this = this;
			return <SpecialPlayerMapIter>d__;
		}

		// Token: 0x06006B5D RID: 27485 RVA: 0x00228144 File Offset: 0x00226344
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SubTypeScoreFrozenDict()缓存字典，遍历请使用SubTypeScoreIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> SubTypeScore()
		{
			return this.SubTypeScoreIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006B5E RID: 27486 RVA: 0x0022819A File Offset: 0x0022639A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> SubTypeScoreIter()
		{
			ExploreProgress.<SubTypeScoreIter>d__53 <SubTypeScoreIter>d__ = new ExploreProgress.<SubTypeScoreIter>d__53(-2);
			<SubTypeScoreIter>d__.<>3__<>4__this = this;
			return <SubTypeScoreIter>d__;
		}

		// Token: 0x06006B5F RID: 27487 RVA: 0x002281B0 File Offset: 0x002263B0
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

		// Token: 0x06006B60 RID: 27488 RVA: 0x002281E4 File Offset: 0x002263E4
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

		// Token: 0x06006B61 RID: 27489 RVA: 0x00228218 File Offset: 0x00226418
		private void EnsureSpecialPlayerMapCacheIfNeeded()
		{
			if (this.SpecialPlayerMapCache != null)
			{
				return;
			}
			this.SpecialPlayerMapCache = this.SpecialPlayerMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006B62 RID: 27490 RVA: 0x00228280 File Offset: 0x00226480
		private void EnsureSubTypeScoreCacheIfNeeded()
		{
			if (this.SubTypeScoreCache != null)
			{
				return;
			}
			this.SubTypeScoreCache = this.SubTypeScoreIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006B63 RID: 27491 RVA: 0x002282E6 File Offset: 0x002264E6
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetSpecialPlayerMapFrozenDict(int key)
		{
			this.EnsureSpecialPlayerMapCacheIfNeeded();
			return this.SpecialPlayerMapCache;
		}

		// Token: 0x06006B64 RID: 27492 RVA: 0x002282F4 File Offset: 0x002264F4
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetSubTypeScoreFrozenDict(int key)
		{
			this.EnsureSubTypeScoreCacheIfNeeded();
			return this.SubTypeScoreCache;
		}

		// Token: 0x04004C92 RID: 19602
		private Table __p;

		// Token: 0x04004C93 RID: 19603
		[Nullable(2)]
		private FrozenDictionary<int, int> SpecialPlayerMapCache;

		// Token: 0x04004C94 RID: 19604
		[Nullable(2)]
		private FrozenDictionary<int, int> SubTypeScoreCache;
	}
}

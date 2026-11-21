using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D8D RID: 3469
	public struct FloroRanchEventGroup : IFlatbufferObject
	{
		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x0600794B RID: 31051 RVA: 0x00259BBA File Offset: 0x00257DBA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600794C RID: 31052 RVA: 0x00259BC7 File Offset: 0x00257DC7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600794D RID: 31053 RVA: 0x00259BD0 File Offset: 0x00257DD0
		public static FloroRanchEventGroup GetRootAsFloroRanchEventGroup(ByteBuffer _bb)
		{
			return FloroRanchEventGroup.GetRootAsFloroRanchEventGroup(_bb, default(FloroRanchEventGroup));
		}

		// Token: 0x0600794E RID: 31054 RVA: 0x00259BEC File Offset: 0x00257DEC
		public static FloroRanchEventGroup GetRootAsFloroRanchEventGroup(ByteBuffer _bb, FloroRanchEventGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600794F RID: 31055 RVA: 0x00259C09 File Offset: 0x00257E09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007950 RID: 31056 RVA: 0x00259C18 File Offset: 0x00257E18
		public FloroRanchEventGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x06007951 RID: 31057 RVA: 0x00259C28 File Offset: 0x00257E28
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

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x06007952 RID: 31058 RVA: 0x00259C64 File Offset: 0x00257E64
		public int ActivityId
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

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x06007953 RID: 31059 RVA: 0x00259CA0 File Offset: 0x00257EA0
		public int Group
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

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x06007954 RID: 31060 RVA: 0x00259CDC File Offset: 0x00257EDC
		public int Period
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x06007955 RID: 31061 RVA: 0x00259D1C File Offset: 0x00257F1C
		public int Rate
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

		// Token: 0x06007956 RID: 31062 RVA: 0x00259D5C File Offset: 0x00257F5C
		public int Event(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x06007957 RID: 31063 RVA: 0x00259D9C File Offset: 0x00257F9C
		public int EventLength
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

		// Token: 0x06007958 RID: 31064 RVA: 0x00259DC8 File Offset: 0x00257FC8
		public Span<int> GetEventBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06007959 RID: 31065 RVA: 0x00259DD8 File Offset: 0x00257FD8
		public int[] GetEventArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600795A RID: 31066 RVA: 0x00259DF0 File Offset: 0x00257FF0
		public DicIntInt? Round(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x0600795B RID: 31067 RVA: 0x00259E54 File Offset: 0x00258054
		public int RoundLength
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

		// Token: 0x0600795C RID: 31068 RVA: 0x00259E80 File Offset: 0x00258080
		public DicIntInt? Protect(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x0600795D RID: 31069 RVA: 0x00259EE4 File Offset: 0x002580E4
		public int ProtectLength
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

		// Token: 0x0600795E RID: 31070 RVA: 0x00259F10 File Offset: 0x00258110
		[NullableContext(1)]
		public int[] Event()
		{
			return this.GetEventArray();
		}

		// Token: 0x0600795F RID: 31071 RVA: 0x00259F18 File Offset: 0x00258118
		[NullableContext(1)]
		public IEnumerable<int> EventIter()
		{
			FloroRanchEventGroup.<EventIter>d__30 <EventIter>d__ = new FloroRanchEventGroup.<EventIter>d__30(-2);
			<EventIter>d__.<>3__<>4__this = this;
			return <EventIter>d__;
		}

		// Token: 0x06007960 RID: 31072 RVA: 0x00259F30 File Offset: 0x00258130
		[NullableContext(1)]
		public Dictionary<int, int> Protect()
		{
			return this.ProtectIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06007961 RID: 31073 RVA: 0x00259F86 File Offset: 0x00258186
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ProtectIter()
		{
			FloroRanchEventGroup.<ProtectIter>d__32 <ProtectIter>d__ = new FloroRanchEventGroup.<ProtectIter>d__32(-2);
			<ProtectIter>d__.<>3__<>4__this = this;
			return <ProtectIter>d__;
		}

		// Token: 0x06007962 RID: 31074 RVA: 0x00259F9C File Offset: 0x0025819C
		[NullableContext(1)]
		public Dictionary<int, int> Round()
		{
			return this.RoundIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06007963 RID: 31075 RVA: 0x00259FF2 File Offset: 0x002581F2
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RoundIter()
		{
			FloroRanchEventGroup.<RoundIter>d__34 <RoundIter>d__ = new FloroRanchEventGroup.<RoundIter>d__34(-2);
			<RoundIter>d__.<>3__<>4__this = this;
			return <RoundIter>d__;
		}

		// Token: 0x06007964 RID: 31076 RVA: 0x0025A008 File Offset: 0x00258208
		public int? GetProtect(int key)
		{
			this.EnsureProtectCacheIfNeeded();
			int value;
			if (!this.ProtectCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06007965 RID: 31077 RVA: 0x0025A03C File Offset: 0x0025823C
		public int? GetRound(int key)
		{
			this.EnsureRoundCacheIfNeeded();
			int value;
			if (!this.RoundCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06007966 RID: 31078 RVA: 0x0025A070 File Offset: 0x00258270
		private void EnsureProtectCacheIfNeeded()
		{
			if (this.ProtectCache != null)
			{
				return;
			}
			this.ProtectCache = this.ProtectIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007967 RID: 31079 RVA: 0x0025A0D8 File Offset: 0x002582D8
		private void EnsureRoundCacheIfNeeded()
		{
			if (this.RoundCache != null)
			{
				return;
			}
			this.RoundCache = this.RoundIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007968 RID: 31080 RVA: 0x0025A13E File Offset: 0x0025833E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetProtectFrozenDict()
		{
			this.EnsureProtectCacheIfNeeded();
			return this.ProtectCache;
		}

		// Token: 0x06007969 RID: 31081 RVA: 0x0025A14C File Offset: 0x0025834C
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRoundFrozenDict()
		{
			this.EnsureRoundCacheIfNeeded();
			return this.RoundCache;
		}

		// Token: 0x040052EF RID: 21231
		private Table __p;

		// Token: 0x040052F0 RID: 21232
		[Nullable(2)]
		private FrozenDictionary<int, int> ProtectCache;

		// Token: 0x040052F1 RID: 21233
		[Nullable(2)]
		private FrozenDictionary<int, int> RoundCache;
	}
}

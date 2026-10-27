using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CA9 RID: 3241
	public struct FloroRanchEventGroup : IFlatbufferObject
	{
		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x06007340 RID: 29504 RVA: 0x0023AD05 File Offset: 0x00238F05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007341 RID: 29505 RVA: 0x0023AD12 File Offset: 0x00238F12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007342 RID: 29506 RVA: 0x0023AD1C File Offset: 0x00238F1C
		public static FloroRanchEventGroup GetRootAsFloroRanchEventGroup(ByteBuffer _bb)
		{
			return FloroRanchEventGroup.GetRootAsFloroRanchEventGroup(_bb, default(FloroRanchEventGroup));
		}

		// Token: 0x06007343 RID: 29507 RVA: 0x0023AD38 File Offset: 0x00238F38
		public static FloroRanchEventGroup GetRootAsFloroRanchEventGroup(ByteBuffer _bb, FloroRanchEventGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007344 RID: 29508 RVA: 0x0023AD55 File Offset: 0x00238F55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007345 RID: 29509 RVA: 0x0023AD64 File Offset: 0x00238F64
		public FloroRanchEventGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x06007346 RID: 29510 RVA: 0x0023AD74 File Offset: 0x00238F74
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

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x06007347 RID: 29511 RVA: 0x0023ADB0 File Offset: 0x00238FB0
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

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x06007348 RID: 29512 RVA: 0x0023ADEC File Offset: 0x00238FEC
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

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x06007349 RID: 29513 RVA: 0x0023AE28 File Offset: 0x00239028
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

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x0600734A RID: 29514 RVA: 0x0023AE68 File Offset: 0x00239068
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

		// Token: 0x0600734B RID: 29515 RVA: 0x0023AEA8 File Offset: 0x002390A8
		public int Event(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x0600734C RID: 29516 RVA: 0x0023AEE8 File Offset: 0x002390E8
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

		// Token: 0x0600734D RID: 29517 RVA: 0x0023AF14 File Offset: 0x00239114
		public Span<int> GetEventBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600734E RID: 29518 RVA: 0x0023AF24 File Offset: 0x00239124
		public int[] GetEventArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600734F RID: 29519 RVA: 0x0023AF3C File Offset: 0x0023913C
		public DicIntInt? Round(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x06007350 RID: 29520 RVA: 0x0023AFA0 File Offset: 0x002391A0
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

		// Token: 0x06007351 RID: 29521 RVA: 0x0023AFCC File Offset: 0x002391CC
		public DicIntInt? Protect(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x06007352 RID: 29522 RVA: 0x0023B030 File Offset: 0x00239230
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

		// Token: 0x06007353 RID: 29523 RVA: 0x0023B05C File Offset: 0x0023925C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EventIter()或GetEventBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Event()
		{
			FloroRanchEventGroup floroRanchEventGroup = this;
			return floroRanchEventGroup.GetEventArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007354 RID: 29524 RVA: 0x0023B080 File Offset: 0x00239280
		[NullableContext(1)]
		public readonly IEnumerable<int> EventIter()
		{
			FloroRanchEventGroup.<EventIter>d__30 <EventIter>d__ = new FloroRanchEventGroup.<EventIter>d__30(-2);
			<EventIter>d__.<>3__<>4__this = this;
			return <EventIter>d__;
		}

		// Token: 0x06007355 RID: 29525 RVA: 0x0023B098 File Offset: 0x00239298
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ProtectFrozenDict()缓存字典，遍历请使用ProtectIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Protect()
		{
			return this.ProtectIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06007356 RID: 29526 RVA: 0x0023B0EE File Offset: 0x002392EE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ProtectIter()
		{
			FloroRanchEventGroup.<ProtectIter>d__32 <ProtectIter>d__ = new FloroRanchEventGroup.<ProtectIter>d__32(-2);
			<ProtectIter>d__.<>3__<>4__this = this;
			return <ProtectIter>d__;
		}

		// Token: 0x06007357 RID: 29527 RVA: 0x0023B104 File Offset: 0x00239304
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RoundFrozenDict()缓存字典，遍历请使用RoundIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Round()
		{
			return this.RoundIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06007358 RID: 29528 RVA: 0x0023B15A File Offset: 0x0023935A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RoundIter()
		{
			FloroRanchEventGroup.<RoundIter>d__34 <RoundIter>d__ = new FloroRanchEventGroup.<RoundIter>d__34(-2);
			<RoundIter>d__.<>3__<>4__this = this;
			return <RoundIter>d__;
		}

		// Token: 0x06007359 RID: 29529 RVA: 0x0023B170 File Offset: 0x00239370
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

		// Token: 0x0600735A RID: 29530 RVA: 0x0023B1A4 File Offset: 0x002393A4
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

		// Token: 0x0600735B RID: 29531 RVA: 0x0023B1D8 File Offset: 0x002393D8
		private void EnsureProtectCacheIfNeeded()
		{
			if (this.ProtectCache != null)
			{
				return;
			}
			this.ProtectCache = this.ProtectIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600735C RID: 29532 RVA: 0x0023B240 File Offset: 0x00239440
		private void EnsureRoundCacheIfNeeded()
		{
			if (this.RoundCache != null)
			{
				return;
			}
			this.RoundCache = this.RoundIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600735D RID: 29533 RVA: 0x0023B2A6 File Offset: 0x002394A6
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetProtectFrozenDict(int key)
		{
			this.EnsureProtectCacheIfNeeded();
			return this.ProtectCache;
		}

		// Token: 0x0600735E RID: 29534 RVA: 0x0023B2B4 File Offset: 0x002394B4
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRoundFrozenDict(int key)
		{
			this.EnsureRoundCacheIfNeeded();
			return this.RoundCache;
		}

		// Token: 0x04004D0B RID: 19723
		private Table __p;

		// Token: 0x04004D0C RID: 19724
		[Nullable(2)]
		private FrozenDictionary<int, int> ProtectCache;

		// Token: 0x04004D0D RID: 19725
		[Nullable(2)]
		private FrozenDictionary<int, int> RoundCache;
	}
}

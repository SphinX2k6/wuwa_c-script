using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001148 RID: 4424
	public struct TrackMoonEntrust : IFlatbufferObject
	{
		// Token: 0x17003B22 RID: 15138
		// (get) Token: 0x0600E0B2 RID: 57522 RVA: 0x0033200D File Offset: 0x0033020D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E0B3 RID: 57523 RVA: 0x0033201A File Offset: 0x0033021A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E0B4 RID: 57524 RVA: 0x00332024 File Offset: 0x00330224
		public static TrackMoonEntrust GetRootAsTrackMoonEntrust(ByteBuffer _bb)
		{
			return TrackMoonEntrust.GetRootAsTrackMoonEntrust(_bb, default(TrackMoonEntrust));
		}

		// Token: 0x0600E0B5 RID: 57525 RVA: 0x00332040 File Offset: 0x00330240
		public static TrackMoonEntrust GetRootAsTrackMoonEntrust(ByteBuffer _bb, TrackMoonEntrust obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E0B6 RID: 57526 RVA: 0x0033205D File Offset: 0x0033025D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E0B7 RID: 57527 RVA: 0x0033206C File Offset: 0x0033026C
		public TrackMoonEntrust __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B23 RID: 15139
		// (get) Token: 0x0600E0B8 RID: 57528 RVA: 0x0033207C File Offset: 0x0033027C
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

		// Token: 0x17003B24 RID: 15140
		// (get) Token: 0x0600E0B9 RID: 57529 RVA: 0x003320B8 File Offset: 0x003302B8
		public string Title
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

		// Token: 0x0600E0BA RID: 57530 RVA: 0x003320EF File Offset: 0x003302EF
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E0BB RID: 57531 RVA: 0x003320FE File Offset: 0x003302FE
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B25 RID: 15141
		// (get) Token: 0x0600E0BC RID: 57532 RVA: 0x00332118 File Offset: 0x00330318
		public string Content
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E0BD RID: 57533 RVA: 0x0033214F File Offset: 0x0033034F
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E0BE RID: 57534 RVA: 0x0033215E File Offset: 0x0033035E
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B26 RID: 15142
		// (get) Token: 0x0600E0BF RID: 57535 RVA: 0x00332178 File Offset: 0x00330378
		public int UnlockCondition
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

		// Token: 0x17003B27 RID: 15143
		// (get) Token: 0x0600E0C0 RID: 57536 RVA: 0x003321B8 File Offset: 0x003303B8
		public bool Guaranteed
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003B28 RID: 15144
		// (get) Token: 0x0600E0C1 RID: 57537 RVA: 0x003321F8 File Offset: 0x003303F8
		public int JumpType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003B29 RID: 15145
		// (get) Token: 0x0600E0C2 RID: 57538 RVA: 0x00332238 File Offset: 0x00330438
		public int JumpParam
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

		// Token: 0x0600E0C3 RID: 57539 RVA: 0x00332278 File Offset: 0x00330478
		public DicIntInt? CapacityMap(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003B2A RID: 15146
		// (get) Token: 0x0600E0C4 RID: 57540 RVA: 0x003322DC File Offset: 0x003304DC
		public int CapacityMapLength
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

		// Token: 0x0600E0C5 RID: 57541 RVA: 0x00332308 File Offset: 0x00330508
		public DicIntInt? Consume(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003B2B RID: 15147
		// (get) Token: 0x0600E0C6 RID: 57542 RVA: 0x0033236C File Offset: 0x0033056C
		public int ConsumeLength
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

		// Token: 0x17003B2C RID: 15148
		// (get) Token: 0x0600E0C7 RID: 57543 RVA: 0x00332398 File Offset: 0x00330598
		public int Star
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003B2D RID: 15149
		// (get) Token: 0x0600E0C8 RID: 57544 RVA: 0x003323D8 File Offset: 0x003305D8
		public int EntrustType
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E0C9 RID: 57545 RVA: 0x00332418 File Offset: 0x00330618
		public DicIntInt? IdeaSuccRatio(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003B2E RID: 15150
		// (get) Token: 0x0600E0CA RID: 57546 RVA: 0x0033247C File Offset: 0x0033067C
		public int IdeaSuccRatioLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E0CB RID: 57547 RVA: 0x003324A8 File Offset: 0x003306A8
		public int IdeaSuccMul(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B2F RID: 15151
		// (get) Token: 0x0600E0CC RID: 57548 RVA: 0x003324E8 File Offset: 0x003306E8
		public int IdeaSuccMulLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E0CD RID: 57549 RVA: 0x00332514 File Offset: 0x00330714
		public Span<int> GetIdeaSuccMulBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600E0CE RID: 57550 RVA: 0x00332524 File Offset: 0x00330724
		public int[] GetIdeaSuccMulArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x0600E0CF RID: 57551 RVA: 0x0033253C File Offset: 0x0033073C
		public int AttributionSuccRatio(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003B30 RID: 15152
		// (get) Token: 0x0600E0D0 RID: 57552 RVA: 0x0033257C File Offset: 0x0033077C
		public int AttributionSuccRatioLength
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

		// Token: 0x0600E0D1 RID: 57553 RVA: 0x003325A8 File Offset: 0x003307A8
		public Span<int> GetAttributionSuccRatioBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x0600E0D2 RID: 57554 RVA: 0x003325B8 File Offset: 0x003307B8
		public int[] GetAttributionSuccRatioArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x17003B31 RID: 15153
		// (get) Token: 0x0600E0D3 RID: 57555 RVA: 0x003325D0 File Offset: 0x003307D0
		public int AttributeMaxValue
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003B32 RID: 15154
		// (get) Token: 0x0600E0D4 RID: 57556 RVA: 0x00332610 File Offset: 0x00330810
		public int InvestLimit
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

		// Token: 0x0600E0D5 RID: 57557 RVA: 0x00332650 File Offset: 0x00330850
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AttributionSuccRatioIter()或GetAttributionSuccRatioBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AttributionSuccRatio()
		{
			TrackMoonEntrust trackMoonEntrust = this;
			return trackMoonEntrust.GetAttributionSuccRatioArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E0D6 RID: 57558 RVA: 0x00332674 File Offset: 0x00330874
		[NullableContext(1)]
		public readonly IEnumerable<int> AttributionSuccRatioIter()
		{
			TrackMoonEntrust.<AttributionSuccRatioIter>d__54 <AttributionSuccRatioIter>d__ = new TrackMoonEntrust.<AttributionSuccRatioIter>d__54(-2);
			<AttributionSuccRatioIter>d__.<>3__<>4__this = this;
			return <AttributionSuccRatioIter>d__;
		}

		// Token: 0x0600E0D7 RID: 57559 RVA: 0x0033268C File Offset: 0x0033088C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用CapacityMapFrozenDict()缓存字典，遍历请使用CapacityMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> CapacityMap()
		{
			return this.CapacityMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600E0D8 RID: 57560 RVA: 0x003326E2 File Offset: 0x003308E2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> CapacityMapIter()
		{
			TrackMoonEntrust.<CapacityMapIter>d__56 <CapacityMapIter>d__ = new TrackMoonEntrust.<CapacityMapIter>d__56(-2);
			<CapacityMapIter>d__.<>3__<>4__this = this;
			return <CapacityMapIter>d__;
		}

		// Token: 0x0600E0D9 RID: 57561 RVA: 0x003326F8 File Offset: 0x003308F8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ConsumeFrozenDict()缓存字典，遍历请使用ConsumeIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Consume()
		{
			return this.ConsumeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600E0DA RID: 57562 RVA: 0x0033274E File Offset: 0x0033094E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ConsumeIter()
		{
			TrackMoonEntrust.<ConsumeIter>d__58 <ConsumeIter>d__ = new TrackMoonEntrust.<ConsumeIter>d__58(-2);
			<ConsumeIter>d__.<>3__<>4__this = this;
			return <ConsumeIter>d__;
		}

		// Token: 0x0600E0DB RID: 57563 RVA: 0x00332764 File Offset: 0x00330964
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用IdeaSuccMulIter()或GetIdeaSuccMulBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] IdeaSuccMul()
		{
			TrackMoonEntrust trackMoonEntrust = this;
			return trackMoonEntrust.GetIdeaSuccMulArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E0DC RID: 57564 RVA: 0x00332788 File Offset: 0x00330988
		[NullableContext(1)]
		public readonly IEnumerable<int> IdeaSuccMulIter()
		{
			TrackMoonEntrust.<IdeaSuccMulIter>d__60 <IdeaSuccMulIter>d__ = new TrackMoonEntrust.<IdeaSuccMulIter>d__60(-2);
			<IdeaSuccMulIter>d__.<>3__<>4__this = this;
			return <IdeaSuccMulIter>d__;
		}

		// Token: 0x0600E0DD RID: 57565 RVA: 0x003327A0 File Offset: 0x003309A0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用IdeaSuccRatioFrozenDict()缓存字典，遍历请使用IdeaSuccRatioIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> IdeaSuccRatio()
		{
			return this.IdeaSuccRatioIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600E0DE RID: 57566 RVA: 0x003327F6 File Offset: 0x003309F6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> IdeaSuccRatioIter()
		{
			TrackMoonEntrust.<IdeaSuccRatioIter>d__62 <IdeaSuccRatioIter>d__ = new TrackMoonEntrust.<IdeaSuccRatioIter>d__62(-2);
			<IdeaSuccRatioIter>d__.<>3__<>4__this = this;
			return <IdeaSuccRatioIter>d__;
		}

		// Token: 0x0600E0DF RID: 57567 RVA: 0x0033280C File Offset: 0x00330A0C
		public int? GetCapacityMap(int key)
		{
			this.EnsureCapacityMapCacheIfNeeded();
			int value;
			if (!this.CapacityMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600E0E0 RID: 57568 RVA: 0x00332840 File Offset: 0x00330A40
		public int? GetConsume(int key)
		{
			this.EnsureConsumeCacheIfNeeded();
			int value;
			if (!this.ConsumeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600E0E1 RID: 57569 RVA: 0x00332874 File Offset: 0x00330A74
		public int? GetIdeaSuccRatio(int key)
		{
			this.EnsureIdeaSuccRatioCacheIfNeeded();
			int value;
			if (!this.IdeaSuccRatioCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600E0E2 RID: 57570 RVA: 0x003328A8 File Offset: 0x00330AA8
		private void EnsureCapacityMapCacheIfNeeded()
		{
			if (this.CapacityMapCache != null)
			{
				return;
			}
			this.CapacityMapCache = this.CapacityMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600E0E3 RID: 57571 RVA: 0x00332910 File Offset: 0x00330B10
		private void EnsureConsumeCacheIfNeeded()
		{
			if (this.ConsumeCache != null)
			{
				return;
			}
			this.ConsumeCache = this.ConsumeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600E0E4 RID: 57572 RVA: 0x00332978 File Offset: 0x00330B78
		private void EnsureIdeaSuccRatioCacheIfNeeded()
		{
			if (this.IdeaSuccRatioCache != null)
			{
				return;
			}
			this.IdeaSuccRatioCache = this.IdeaSuccRatioIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600E0E5 RID: 57573 RVA: 0x003329DE File Offset: 0x00330BDE
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetCapacityMapFrozenDict(int key)
		{
			this.EnsureCapacityMapCacheIfNeeded();
			return this.CapacityMapCache;
		}

		// Token: 0x0600E0E6 RID: 57574 RVA: 0x003329EC File Offset: 0x00330BEC
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetConsumeFrozenDict(int key)
		{
			this.EnsureConsumeCacheIfNeeded();
			return this.ConsumeCache;
		}

		// Token: 0x0600E0E7 RID: 57575 RVA: 0x003329FA File Offset: 0x00330BFA
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetIdeaSuccRatioFrozenDict(int key)
		{
			this.EnsureIdeaSuccRatioCacheIfNeeded();
			return this.IdeaSuccRatioCache;
		}

		// Token: 0x0400528A RID: 21130
		private Table __p;

		// Token: 0x0400528B RID: 21131
		[Nullable(2)]
		private FrozenDictionary<int, int> CapacityMapCache;

		// Token: 0x0400528C RID: 21132
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeCache;

		// Token: 0x0400528D RID: 21133
		[Nullable(2)]
		private FrozenDictionary<int, int> IdeaSuccRatioCache;
	}
}

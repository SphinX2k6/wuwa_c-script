using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200127E RID: 4734
	public struct TrackMoonEntrust : IFlatbufferObject
	{
		// Token: 0x17003E86 RID: 16006
		// (get) Token: 0x0600EE20 RID: 60960 RVA: 0x0035D439 File Offset: 0x0035B639
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EE21 RID: 60961 RVA: 0x0035D446 File Offset: 0x0035B646
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EE22 RID: 60962 RVA: 0x0035D450 File Offset: 0x0035B650
		public static TrackMoonEntrust GetRootAsTrackMoonEntrust(ByteBuffer _bb)
		{
			return TrackMoonEntrust.GetRootAsTrackMoonEntrust(_bb, default(TrackMoonEntrust));
		}

		// Token: 0x0600EE23 RID: 60963 RVA: 0x0035D46C File Offset: 0x0035B66C
		public static TrackMoonEntrust GetRootAsTrackMoonEntrust(ByteBuffer _bb, TrackMoonEntrust obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EE24 RID: 60964 RVA: 0x0035D489 File Offset: 0x0035B689
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EE25 RID: 60965 RVA: 0x0035D498 File Offset: 0x0035B698
		public TrackMoonEntrust __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E87 RID: 16007
		// (get) Token: 0x0600EE26 RID: 60966 RVA: 0x0035D4A8 File Offset: 0x0035B6A8
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

		// Token: 0x17003E88 RID: 16008
		// (get) Token: 0x0600EE27 RID: 60967 RVA: 0x0035D4E4 File Offset: 0x0035B6E4
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

		// Token: 0x0600EE28 RID: 60968 RVA: 0x0035D51B File Offset: 0x0035B71B
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EE29 RID: 60969 RVA: 0x0035D52A File Offset: 0x0035B72A
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E89 RID: 16009
		// (get) Token: 0x0600EE2A RID: 60970 RVA: 0x0035D544 File Offset: 0x0035B744
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

		// Token: 0x0600EE2B RID: 60971 RVA: 0x0035D57B File Offset: 0x0035B77B
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600EE2C RID: 60972 RVA: 0x0035D58A File Offset: 0x0035B78A
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E8A RID: 16010
		// (get) Token: 0x0600EE2D RID: 60973 RVA: 0x0035D5A4 File Offset: 0x0035B7A4
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

		// Token: 0x17003E8B RID: 16011
		// (get) Token: 0x0600EE2E RID: 60974 RVA: 0x0035D5E4 File Offset: 0x0035B7E4
		public bool Guaranteed
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003E8C RID: 16012
		// (get) Token: 0x0600EE2F RID: 60975 RVA: 0x0035D624 File Offset: 0x0035B824
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

		// Token: 0x17003E8D RID: 16013
		// (get) Token: 0x0600EE30 RID: 60976 RVA: 0x0035D664 File Offset: 0x0035B864
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

		// Token: 0x0600EE31 RID: 60977 RVA: 0x0035D6A4 File Offset: 0x0035B8A4
		public DicIntInt? CapacityMap(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003E8E RID: 16014
		// (get) Token: 0x0600EE32 RID: 60978 RVA: 0x0035D708 File Offset: 0x0035B908
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

		// Token: 0x0600EE33 RID: 60979 RVA: 0x0035D734 File Offset: 0x0035B934
		public DicIntInt? Consume(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003E8F RID: 16015
		// (get) Token: 0x0600EE34 RID: 60980 RVA: 0x0035D798 File Offset: 0x0035B998
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

		// Token: 0x17003E90 RID: 16016
		// (get) Token: 0x0600EE35 RID: 60981 RVA: 0x0035D7C4 File Offset: 0x0035B9C4
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

		// Token: 0x17003E91 RID: 16017
		// (get) Token: 0x0600EE36 RID: 60982 RVA: 0x0035D804 File Offset: 0x0035BA04
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

		// Token: 0x0600EE37 RID: 60983 RVA: 0x0035D844 File Offset: 0x0035BA44
		public DicIntInt? IdeaSuccRatio(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003E92 RID: 16018
		// (get) Token: 0x0600EE38 RID: 60984 RVA: 0x0035D8A8 File Offset: 0x0035BAA8
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

		// Token: 0x0600EE39 RID: 60985 RVA: 0x0035D8D4 File Offset: 0x0035BAD4
		public int IdeaSuccMul(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E93 RID: 16019
		// (get) Token: 0x0600EE3A RID: 60986 RVA: 0x0035D914 File Offset: 0x0035BB14
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

		// Token: 0x0600EE3B RID: 60987 RVA: 0x0035D940 File Offset: 0x0035BB40
		public Span<int> GetIdeaSuccMulBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600EE3C RID: 60988 RVA: 0x0035D950 File Offset: 0x0035BB50
		public int[] GetIdeaSuccMulArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x0600EE3D RID: 60989 RVA: 0x0035D968 File Offset: 0x0035BB68
		public int AttributionSuccRatio(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E94 RID: 16020
		// (get) Token: 0x0600EE3E RID: 60990 RVA: 0x0035D9A8 File Offset: 0x0035BBA8
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

		// Token: 0x0600EE3F RID: 60991 RVA: 0x0035D9D4 File Offset: 0x0035BBD4
		public Span<int> GetAttributionSuccRatioBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x0600EE40 RID: 60992 RVA: 0x0035D9E4 File Offset: 0x0035BBE4
		public int[] GetAttributionSuccRatioArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x17003E95 RID: 16021
		// (get) Token: 0x0600EE41 RID: 60993 RVA: 0x0035D9FC File Offset: 0x0035BBFC
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

		// Token: 0x17003E96 RID: 16022
		// (get) Token: 0x0600EE42 RID: 60994 RVA: 0x0035DA3C File Offset: 0x0035BC3C
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

		// Token: 0x0600EE43 RID: 60995 RVA: 0x0035DA79 File Offset: 0x0035BC79
		[NullableContext(1)]
		public int[] AttributionSuccRatio()
		{
			return this.GetAttributionSuccRatioArray();
		}

		// Token: 0x0600EE44 RID: 60996 RVA: 0x0035DA81 File Offset: 0x0035BC81
		[NullableContext(1)]
		public IEnumerable<int> AttributionSuccRatioIter()
		{
			TrackMoonEntrust.<AttributionSuccRatioIter>d__54 <AttributionSuccRatioIter>d__ = new TrackMoonEntrust.<AttributionSuccRatioIter>d__54(-2);
			<AttributionSuccRatioIter>d__.<>3__<>4__this = this;
			return <AttributionSuccRatioIter>d__;
		}

		// Token: 0x0600EE45 RID: 60997 RVA: 0x0035DA98 File Offset: 0x0035BC98
		[NullableContext(1)]
		public Dictionary<int, int> CapacityMap()
		{
			return this.CapacityMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600EE46 RID: 60998 RVA: 0x0035DAEE File Offset: 0x0035BCEE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> CapacityMapIter()
		{
			TrackMoonEntrust.<CapacityMapIter>d__56 <CapacityMapIter>d__ = new TrackMoonEntrust.<CapacityMapIter>d__56(-2);
			<CapacityMapIter>d__.<>3__<>4__this = this;
			return <CapacityMapIter>d__;
		}

		// Token: 0x0600EE47 RID: 60999 RVA: 0x0035DB04 File Offset: 0x0035BD04
		[NullableContext(1)]
		public Dictionary<int, int> Consume()
		{
			return this.ConsumeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600EE48 RID: 61000 RVA: 0x0035DB5A File Offset: 0x0035BD5A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ConsumeIter()
		{
			TrackMoonEntrust.<ConsumeIter>d__58 <ConsumeIter>d__ = new TrackMoonEntrust.<ConsumeIter>d__58(-2);
			<ConsumeIter>d__.<>3__<>4__this = this;
			return <ConsumeIter>d__;
		}

		// Token: 0x0600EE49 RID: 61001 RVA: 0x0035DB6F File Offset: 0x0035BD6F
		[NullableContext(1)]
		public int[] IdeaSuccMul()
		{
			return this.GetIdeaSuccMulArray();
		}

		// Token: 0x0600EE4A RID: 61002 RVA: 0x0035DB77 File Offset: 0x0035BD77
		[NullableContext(1)]
		public IEnumerable<int> IdeaSuccMulIter()
		{
			TrackMoonEntrust.<IdeaSuccMulIter>d__60 <IdeaSuccMulIter>d__ = new TrackMoonEntrust.<IdeaSuccMulIter>d__60(-2);
			<IdeaSuccMulIter>d__.<>3__<>4__this = this;
			return <IdeaSuccMulIter>d__;
		}

		// Token: 0x0600EE4B RID: 61003 RVA: 0x0035DB8C File Offset: 0x0035BD8C
		[NullableContext(1)]
		public Dictionary<int, int> IdeaSuccRatio()
		{
			return this.IdeaSuccRatioIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600EE4C RID: 61004 RVA: 0x0035DBE2 File Offset: 0x0035BDE2
		[NullableContext(1)]
		public IEnumerable<DicIntInt> IdeaSuccRatioIter()
		{
			TrackMoonEntrust.<IdeaSuccRatioIter>d__62 <IdeaSuccRatioIter>d__ = new TrackMoonEntrust.<IdeaSuccRatioIter>d__62(-2);
			<IdeaSuccRatioIter>d__.<>3__<>4__this = this;
			return <IdeaSuccRatioIter>d__;
		}

		// Token: 0x0600EE4D RID: 61005 RVA: 0x0035DBF8 File Offset: 0x0035BDF8
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

		// Token: 0x0600EE4E RID: 61006 RVA: 0x0035DC2C File Offset: 0x0035BE2C
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

		// Token: 0x0600EE4F RID: 61007 RVA: 0x0035DC60 File Offset: 0x0035BE60
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

		// Token: 0x0600EE50 RID: 61008 RVA: 0x0035DC94 File Offset: 0x0035BE94
		private void EnsureCapacityMapCacheIfNeeded()
		{
			if (this.CapacityMapCache != null)
			{
				return;
			}
			this.CapacityMapCache = this.CapacityMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600EE51 RID: 61009 RVA: 0x0035DCFC File Offset: 0x0035BEFC
		private void EnsureConsumeCacheIfNeeded()
		{
			if (this.ConsumeCache != null)
			{
				return;
			}
			this.ConsumeCache = this.ConsumeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600EE52 RID: 61010 RVA: 0x0035DD64 File Offset: 0x0035BF64
		private void EnsureIdeaSuccRatioCacheIfNeeded()
		{
			if (this.IdeaSuccRatioCache != null)
			{
				return;
			}
			this.IdeaSuccRatioCache = this.IdeaSuccRatioIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600EE53 RID: 61011 RVA: 0x0035DDCA File Offset: 0x0035BFCA
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetCapacityMapFrozenDict()
		{
			this.EnsureCapacityMapCacheIfNeeded();
			return this.CapacityMapCache;
		}

		// Token: 0x0600EE54 RID: 61012 RVA: 0x0035DDD8 File Offset: 0x0035BFD8
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetConsumeFrozenDict()
		{
			this.EnsureConsumeCacheIfNeeded();
			return this.ConsumeCache;
		}

		// Token: 0x0600EE55 RID: 61013 RVA: 0x0035DDE6 File Offset: 0x0035BFE6
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetIdeaSuccRatioFrozenDict()
		{
			this.EnsureIdeaSuccRatioCacheIfNeeded();
			return this.IdeaSuccRatioCache;
		}

		// Token: 0x040058CD RID: 22733
		private Table __p;

		// Token: 0x040058CE RID: 22734
		[Nullable(2)]
		private FrozenDictionary<int, int> CapacityMapCache;

		// Token: 0x040058CF RID: 22735
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeCache;

		// Token: 0x040058D0 RID: 22736
		[Nullable(2)]
		private FrozenDictionary<int, int> IdeaSuccRatioCache;
	}
}

using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B5D RID: 2909
	public struct CalabashLevel : IFlatbufferObject
	{
		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060051DA RID: 20954 RVA: 0x001EE01D File Offset: 0x001EC21D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060051DB RID: 20955 RVA: 0x001EE02A File Offset: 0x001EC22A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060051DC RID: 20956 RVA: 0x001EE034 File Offset: 0x001EC234
		public static CalabashLevel GetRootAsCalabashLevel(ByteBuffer _bb)
		{
			return CalabashLevel.GetRootAsCalabashLevel(_bb, default(CalabashLevel));
		}

		// Token: 0x060051DD RID: 20957 RVA: 0x001EE050 File Offset: 0x001EC250
		public static CalabashLevel GetRootAsCalabashLevel(ByteBuffer _bb, CalabashLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060051DE RID: 20958 RVA: 0x001EE06D File Offset: 0x001EC26D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060051DF RID: 20959 RVA: 0x001EE07C File Offset: 0x001EC27C
		public CalabashLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060051E0 RID: 20960 RVA: 0x001EE08C File Offset: 0x001EC28C
		public int Level
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

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060051E1 RID: 20961 RVA: 0x001EE0C8 File Offset: 0x001EC2C8
		public int LevelUpExp
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

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060051E2 RID: 20962 RVA: 0x001EE104 File Offset: 0x001EC304
		public int LevelUpCondition
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

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060051E3 RID: 20963 RVA: 0x001EE140 File Offset: 0x001EC340
		public int TempCatchGain
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

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060051E4 RID: 20964 RVA: 0x001EE180 File Offset: 0x001EC380
		public int LowCostTempCatchGain
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

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060051E5 RID: 20965 RVA: 0x001EE1C0 File Offset: 0x001EC3C0
		public int IntensifyCaptureGuarantee
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

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060051E6 RID: 20966 RVA: 0x001EE200 File Offset: 0x001EC400
		public int LowCostIntensifyCaptureGuarantee
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

		// Token: 0x060051E7 RID: 20967 RVA: 0x001EE240 File Offset: 0x001EC440
		public int BuffIds(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060051E8 RID: 20968 RVA: 0x001EE280 File Offset: 0x001EC480
		public int BuffIdsLength
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

		// Token: 0x060051E9 RID: 20969 RVA: 0x001EE2AC File Offset: 0x001EC4AC
		public Span<int> GetBuffIdsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x060051EA RID: 20970 RVA: 0x001EE2BC File Offset: 0x001EC4BC
		public int[] GetBuffIdsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060051EB RID: 20971 RVA: 0x001EE2D4 File Offset: 0x001EC4D4
		public string BuffDescription
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

		// Token: 0x060051EC RID: 20972 RVA: 0x001EE30C File Offset: 0x001EC50C
		public Span<byte> GetBuffDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060051ED RID: 20973 RVA: 0x001EE31C File Offset: 0x001EC51C
		public byte[] GetBuffDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060051EE RID: 20974 RVA: 0x001EE334 File Offset: 0x001EC534
		public string LevelUpDescription
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060051EF RID: 20975 RVA: 0x001EE36C File Offset: 0x001EC56C
		public Span<byte> GetLevelUpDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060051F0 RID: 20976 RVA: 0x001EE37C File Offset: 0x001EC57C
		public byte[] GetLevelUpDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060051F1 RID: 20977 RVA: 0x001EE394 File Offset: 0x001EC594
		public string QualityDescription
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060051F2 RID: 20978 RVA: 0x001EE3CC File Offset: 0x001EC5CC
		public Span<byte> GetQualityDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060051F3 RID: 20979 RVA: 0x001EE3DC File Offset: 0x001EC5DC
		public byte[] GetQualityDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x060051F4 RID: 20980 RVA: 0x001EE3F4 File Offset: 0x001EC5F4
		public DicIntInt? BuffDescriptionMap(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060051F5 RID: 20981 RVA: 0x001EE458 File Offset: 0x001EC658
		public int BuffDescriptionMapLength
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

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060051F6 RID: 20982 RVA: 0x001EE484 File Offset: 0x001EC684
		public int Cost
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060051F7 RID: 20983 RVA: 0x001EE4C4 File Offset: 0x001EC6C4
		public int RewardId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 4301;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060051F8 RID: 20984 RVA: 0x001EE508 File Offset: 0x001EC708
		public DicIntInt? QualityDropWeight(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060051F9 RID: 20985 RVA: 0x001EE56C File Offset: 0x001EC76C
		public int QualityDropWeightLength
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

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060051FA RID: 20986 RVA: 0x001EE598 File Offset: 0x001EC798
		public string ReachTextChangeColor
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060051FB RID: 20987 RVA: 0x001EE5D0 File Offset: 0x001EC7D0
		public Span<byte> GetReachTextChangeColorBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x060051FC RID: 20988 RVA: 0x001EE5E0 File Offset: 0x001EC7E0
		public byte[] GetReachTextChangeColorArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060051FD RID: 20989 RVA: 0x001EE5F8 File Offset: 0x001EC7F8
		public string ReachTextOutlineColor
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060051FE RID: 20990 RVA: 0x001EE630 File Offset: 0x001EC830
		public Span<byte> GetReachTextOutlineColorBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x060051FF RID: 20991 RVA: 0x001EE640 File Offset: 0x001EC840
		public byte[] GetReachTextOutlineColorArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06005200 RID: 20992 RVA: 0x001EE658 File Offset: 0x001EC858
		public int ReachTextOutlineSize
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

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06005201 RID: 20993 RVA: 0x001EE698 File Offset: 0x001EC898
		public string TexPatternStatePath
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005202 RID: 20994 RVA: 0x001EE6D0 File Offset: 0x001EC8D0
		public Span<byte> GetTexPatternStatePathBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06005203 RID: 20995 RVA: 0x001EE6E0 File Offset: 0x001EC8E0
		public byte[] GetTexPatternStatePathArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06005204 RID: 20996 RVA: 0x001EE6F8 File Offset: 0x001EC8F8
		public string TexAddLight
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005205 RID: 20997 RVA: 0x001EE730 File Offset: 0x001EC930
		public Span<byte> GetTexAddLightBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06005206 RID: 20998 RVA: 0x001EE740 File Offset: 0x001EC940
		public byte[] GetTexAddLightArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x06005207 RID: 20999 RVA: 0x001EE758 File Offset: 0x001EC958
		[NullableContext(1)]
		[Obsolete("已废弃，请使用BuffDescriptionMapFrozenDict()缓存字典，遍历请使用BuffDescriptionMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> BuffDescriptionMap()
		{
			return this.BuffDescriptionMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005208 RID: 21000 RVA: 0x001EE7AE File Offset: 0x001EC9AE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> BuffDescriptionMapIter()
		{
			CalabashLevel.<BuffDescriptionMapIter>d__68 <BuffDescriptionMapIter>d__ = new CalabashLevel.<BuffDescriptionMapIter>d__68(-2);
			<BuffDescriptionMapIter>d__.<>3__<>4__this = this;
			return <BuffDescriptionMapIter>d__;
		}

		// Token: 0x06005209 RID: 21001 RVA: 0x001EE7C4 File Offset: 0x001EC9C4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffIdsIter()或GetBuffIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BuffIds()
		{
			CalabashLevel calabashLevel = this;
			return calabashLevel.GetBuffIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600520A RID: 21002 RVA: 0x001EE7E8 File Offset: 0x001EC9E8
		[NullableContext(1)]
		public readonly IEnumerable<int> BuffIdsIter()
		{
			CalabashLevel.<BuffIdsIter>d__70 <BuffIdsIter>d__ = new CalabashLevel.<BuffIdsIter>d__70(-2);
			<BuffIdsIter>d__.<>3__<>4__this = this;
			return <BuffIdsIter>d__;
		}

		// Token: 0x0600520B RID: 21003 RVA: 0x001EE800 File Offset: 0x001ECA00
		[NullableContext(1)]
		[Obsolete("已废弃，请使用QualityDropWeightFrozenDict()缓存字典，遍历请使用QualityDropWeightIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> QualityDropWeight()
		{
			return this.QualityDropWeightIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600520C RID: 21004 RVA: 0x001EE856 File Offset: 0x001ECA56
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> QualityDropWeightIter()
		{
			CalabashLevel.<QualityDropWeightIter>d__72 <QualityDropWeightIter>d__ = new CalabashLevel.<QualityDropWeightIter>d__72(-2);
			<QualityDropWeightIter>d__.<>3__<>4__this = this;
			return <QualityDropWeightIter>d__;
		}

		// Token: 0x0600520D RID: 21005 RVA: 0x001EE86C File Offset: 0x001ECA6C
		public int? GetBuffDescriptionMap(int key)
		{
			this.EnsureBuffDescriptionMapCacheIfNeeded();
			int value;
			if (!this.BuffDescriptionMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600520E RID: 21006 RVA: 0x001EE8A0 File Offset: 0x001ECAA0
		public int? GetQualityDropWeight(int key)
		{
			this.EnsureQualityDropWeightCacheIfNeeded();
			int value;
			if (!this.QualityDropWeightCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600520F RID: 21007 RVA: 0x001EE8D4 File Offset: 0x001ECAD4
		private void EnsureBuffDescriptionMapCacheIfNeeded()
		{
			if (this.BuffDescriptionMapCache != null)
			{
				return;
			}
			this.BuffDescriptionMapCache = this.BuffDescriptionMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005210 RID: 21008 RVA: 0x001EE93C File Offset: 0x001ECB3C
		private void EnsureQualityDropWeightCacheIfNeeded()
		{
			if (this.QualityDropWeightCache != null)
			{
				return;
			}
			this.QualityDropWeightCache = this.QualityDropWeightIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005211 RID: 21009 RVA: 0x001EE9A2 File Offset: 0x001ECBA2
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetBuffDescriptionMapFrozenDict(int key)
		{
			this.EnsureBuffDescriptionMapCacheIfNeeded();
			return this.BuffDescriptionMapCache;
		}

		// Token: 0x06005212 RID: 21010 RVA: 0x001EE9B0 File Offset: 0x001ECBB0
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetQualityDropWeightFrozenDict(int key)
		{
			this.EnsureQualityDropWeightCacheIfNeeded();
			return this.QualityDropWeightCache;
		}

		// Token: 0x04004B5B RID: 19291
		private Table __p;

		// Token: 0x04004B5C RID: 19292
		[Nullable(2)]
		private FrozenDictionary<int, int> BuffDescriptionMapCache;

		// Token: 0x04004B5D RID: 19293
		[Nullable(2)]
		private FrozenDictionary<int, int> QualityDropWeightCache;
	}
}

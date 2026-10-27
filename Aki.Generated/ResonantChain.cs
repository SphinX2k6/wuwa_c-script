using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FBB RID: 4027
	public struct ResonantChain : IFlatbufferObject
	{
		// Token: 0x17002DF8 RID: 11768
		// (get) Token: 0x0600BBBE RID: 48062 RVA: 0x002DD909 File Offset: 0x002DBB09
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BBBF RID: 48063 RVA: 0x002DD916 File Offset: 0x002DBB16
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BBC0 RID: 48064 RVA: 0x002DD920 File Offset: 0x002DBB20
		public static ResonantChain GetRootAsResonantChain(ByteBuffer _bb)
		{
			return ResonantChain.GetRootAsResonantChain(_bb, default(ResonantChain));
		}

		// Token: 0x0600BBC1 RID: 48065 RVA: 0x002DD93C File Offset: 0x002DBB3C
		public static ResonantChain GetRootAsResonantChain(ByteBuffer _bb, ResonantChain obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BBC2 RID: 48066 RVA: 0x002DD959 File Offset: 0x002DBB59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BBC3 RID: 48067 RVA: 0x002DD968 File Offset: 0x002DBB68
		public ResonantChain __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DF9 RID: 11769
		// (get) Token: 0x0600BBC4 RID: 48068 RVA: 0x002DD978 File Offset: 0x002DBB78
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

		// Token: 0x17002DFA RID: 11770
		// (get) Token: 0x0600BBC5 RID: 48069 RVA: 0x002DD9B4 File Offset: 0x002DBBB4
		public int GroupId
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

		// Token: 0x17002DFB RID: 11771
		// (get) Token: 0x0600BBC6 RID: 48070 RVA: 0x002DD9F0 File Offset: 0x002DBBF0
		public int GroupIndex
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

		// Token: 0x17002DFC RID: 11772
		// (get) Token: 0x0600BBC7 RID: 48071 RVA: 0x002DDA2C File Offset: 0x002DBC2C
		public int NodeType
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

		// Token: 0x17002DFD RID: 11773
		// (get) Token: 0x0600BBC8 RID: 48072 RVA: 0x002DDA6C File Offset: 0x002DBC6C
		public string NodeIndex
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BBC9 RID: 48073 RVA: 0x002DDAA4 File Offset: 0x002DBCA4
		public Span<byte> GetNodeIndexBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BBCA RID: 48074 RVA: 0x002DDAB4 File Offset: 0x002DBCB4
		public byte[] GetNodeIndexArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DFE RID: 11774
		// (get) Token: 0x0600BBCB RID: 48075 RVA: 0x002DDACC File Offset: 0x002DBCCC
		public string NodeName
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

		// Token: 0x0600BBCC RID: 48076 RVA: 0x002DDB04 File Offset: 0x002DBD04
		public Span<byte> GetNodeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BBCD RID: 48077 RVA: 0x002DDB14 File Offset: 0x002DBD14
		public byte[] GetNodeNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DFF RID: 11775
		// (get) Token: 0x0600BBCE RID: 48078 RVA: 0x002DDB2C File Offset: 0x002DBD2C
		public string AttributesDescription
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

		// Token: 0x0600BBCF RID: 48079 RVA: 0x002DDB64 File Offset: 0x002DBD64
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BBD0 RID: 48080 RVA: 0x002DDB74 File Offset: 0x002DBD74
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E00 RID: 11776
		// (get) Token: 0x0600BBD1 RID: 48081 RVA: 0x002DDB8C File Offset: 0x002DBD8C
		public string BgDescription
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BBD2 RID: 48082 RVA: 0x002DDBC4 File Offset: 0x002DBDC4
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600BBD3 RID: 48083 RVA: 0x002DDBD4 File Offset: 0x002DBDD4
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BBD4 RID: 48084 RVA: 0x002DDBEC File Offset: 0x002DBDEC
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(20);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002E01 RID: 11777
		// (get) Token: 0x0600BBD5 RID: 48085 RVA: 0x002DDC38 File Offset: 0x002DBE38
		public int BuffIdsLength
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

		// Token: 0x0600BBD6 RID: 48086 RVA: 0x002DDC64 File Offset: 0x002DBE64
		public Span<long> GetBuffIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(20, 8));
		}

		// Token: 0x0600BBD7 RID: 48087 RVA: 0x002DDC79 File Offset: 0x002DBE79
		public long[] GetBuffIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(20) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600BBD8 RID: 48088 RVA: 0x002DDCB8 File Offset: 0x002DBEB8
		public ConfigPropValue? AddProp(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new ConfigPropValue?(default(ConfigPropValue).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002E02 RID: 11778
		// (get) Token: 0x0600BBD9 RID: 48089 RVA: 0x002DDD1C File Offset: 0x002DBF1C
		public int AddPropLength
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

		// Token: 0x0600BBDA RID: 48090 RVA: 0x002DDD48 File Offset: 0x002DBF48
		public DicIntInt? ActivateConsume(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002E03 RID: 11779
		// (get) Token: 0x0600BBDB RID: 48091 RVA: 0x002DDDAC File Offset: 0x002DBFAC
		public int ActivateConsumeLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BBDC RID: 48092 RVA: 0x002DDDD8 File Offset: 0x002DBFD8
		public string AttributesDescriptionParams(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002E04 RID: 11780
		// (get) Token: 0x0600BBDD RID: 48093 RVA: 0x002DDE14 File Offset: 0x002DC014
		public int AttributesDescriptionParamsLength
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

		// Token: 0x17002E05 RID: 11781
		// (get) Token: 0x0600BBDE RID: 48094 RVA: 0x002DDE40 File Offset: 0x002DC040
		public string NodeIcon
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

		// Token: 0x0600BBDF RID: 48095 RVA: 0x002DDE78 File Offset: 0x002DC078
		public Span<byte> GetNodeIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600BBE0 RID: 48096 RVA: 0x002DDE88 File Offset: 0x002DC088
		public byte[] GetNodeIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BBE1 RID: 48097 RVA: 0x002DDEA0 File Offset: 0x002DC0A0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ActivateConsumeFrozenDict()缓存字典，遍历请使用ActivateConsumeIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ActivateConsume()
		{
			return this.ActivateConsumeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600BBE2 RID: 48098 RVA: 0x002DDEF6 File Offset: 0x002DC0F6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ActivateConsumeIter()
		{
			ResonantChain.<ActivateConsumeIter>d__51 <ActivateConsumeIter>d__ = new ResonantChain.<ActivateConsumeIter>d__51(-2);
			<ActivateConsumeIter>d__.<>3__<>4__this = this;
			return <ActivateConsumeIter>d__;
		}

		// Token: 0x0600BBE3 RID: 48099 RVA: 0x002DDF0B File Offset: 0x002DC10B
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AddPropIter()或GetAddPropBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly ConfigPropValue[] AddProp()
		{
			return this.AddPropIter().ToArray<ConfigPropValue>();
		}

		// Token: 0x0600BBE4 RID: 48100 RVA: 0x002DDF18 File Offset: 0x002DC118
		[NullableContext(1)]
		public readonly IEnumerable<ConfigPropValue> AddPropIter()
		{
			ResonantChain.<AddPropIter>d__53 <AddPropIter>d__ = new ResonantChain.<AddPropIter>d__53(-2);
			<AddPropIter>d__.<>3__<>4__this = this;
			return <AddPropIter>d__;
		}

		// Token: 0x0600BBE5 RID: 48101 RVA: 0x002DDF2D File Offset: 0x002DC12D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AttributesDescriptionParamsIter()或GetAttributesDescriptionParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AttributesDescriptionParams()
		{
			return this.AttributesDescriptionParamsIter().ToArray<string>();
		}

		// Token: 0x0600BBE6 RID: 48102 RVA: 0x002DDF3A File Offset: 0x002DC13A
		[NullableContext(1)]
		public readonly IEnumerable<string> AttributesDescriptionParamsIter()
		{
			ResonantChain.<AttributesDescriptionParamsIter>d__55 <AttributesDescriptionParamsIter>d__ = new ResonantChain.<AttributesDescriptionParamsIter>d__55(-2);
			<AttributesDescriptionParamsIter>d__.<>3__<>4__this = this;
			return <AttributesDescriptionParamsIter>d__;
		}

		// Token: 0x0600BBE7 RID: 48103 RVA: 0x002DDF50 File Offset: 0x002DC150
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffIdsIter()或GetBuffIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BuffIds()
		{
			ResonantChain resonantChain = this;
			return resonantChain.GetBuffIdsArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600BBE8 RID: 48104 RVA: 0x002DDF74 File Offset: 0x002DC174
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffIdsIter()
		{
			ResonantChain.<BuffIdsIter>d__57 <BuffIdsIter>d__ = new ResonantChain.<BuffIdsIter>d__57(-2);
			<BuffIdsIter>d__.<>3__<>4__this = this;
			return <BuffIdsIter>d__;
		}

		// Token: 0x0600BBE9 RID: 48105 RVA: 0x002DDF8C File Offset: 0x002DC18C
		public int? GetActivateConsume(int key)
		{
			this.EnsureActivateConsumeCacheIfNeeded();
			int value;
			if (!this.ActivateConsumeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600BBEA RID: 48106 RVA: 0x002DDFC0 File Offset: 0x002DC1C0
		private void EnsureActivateConsumeCacheIfNeeded()
		{
			if (this.ActivateConsumeCache != null)
			{
				return;
			}
			this.ActivateConsumeCache = this.ActivateConsumeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600BBEB RID: 48107 RVA: 0x002DE026 File Offset: 0x002DC226
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetActivateConsumeFrozenDict(int key)
		{
			this.EnsureActivateConsumeCacheIfNeeded();
			return this.ActivateConsumeCache;
		}

		// Token: 0x04005094 RID: 20628
		private Table __p;

		// Token: 0x04005095 RID: 20629
		[Nullable(2)]
		private FrozenDictionary<int, int> ActivateConsumeCache;
	}
}

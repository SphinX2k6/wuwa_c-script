using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CB4 RID: 3252
	public struct DangoBrawlShopEvt : IFlatbufferObject
	{
		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x060065BE RID: 26046 RVA: 0x0022DC65 File Offset: 0x0022BE65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060065BF RID: 26047 RVA: 0x0022DC72 File Offset: 0x0022BE72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060065C0 RID: 26048 RVA: 0x0022DC7C File Offset: 0x0022BE7C
		public static DangoBrawlShopEvt GetRootAsDangoBrawlShopEvt(ByteBuffer _bb)
		{
			return DangoBrawlShopEvt.GetRootAsDangoBrawlShopEvt(_bb, default(DangoBrawlShopEvt));
		}

		// Token: 0x060065C1 RID: 26049 RVA: 0x0022DC98 File Offset: 0x0022BE98
		public static DangoBrawlShopEvt GetRootAsDangoBrawlShopEvt(ByteBuffer _bb, DangoBrawlShopEvt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060065C2 RID: 26050 RVA: 0x0022DCB5 File Offset: 0x0022BEB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060065C3 RID: 26051 RVA: 0x0022DCC4 File Offset: 0x0022BEC4
		public DangoBrawlShopEvt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x060065C4 RID: 26052 RVA: 0x0022DCD4 File Offset: 0x0022BED4
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

		// Token: 0x060065C5 RID: 26053 RVA: 0x0022DD10 File Offset: 0x0022BF10
		public ProAddEntry? AddAttr(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ProAddEntry?(default(ProAddEntry).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x060065C6 RID: 26054 RVA: 0x0022DD70 File Offset: 0x0022BF70
		public int AddAttrLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x060065C7 RID: 26055 RVA: 0x0022DD9C File Offset: 0x0022BF9C
		public int Quality
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

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x060065C8 RID: 26056 RVA: 0x0022DDD8 File Offset: 0x0022BFD8
		public string QualityBg
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060065C9 RID: 26057 RVA: 0x0022DE10 File Offset: 0x0022C010
		public Span<byte> GetQualityBgBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060065CA RID: 26058 RVA: 0x0022DE20 File Offset: 0x0022C020
		public byte[] GetQualityBgArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x060065CB RID: 26059 RVA: 0x0022DE38 File Offset: 0x0022C038
		public string QualityCircle
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

		// Token: 0x060065CC RID: 26060 RVA: 0x0022DE70 File Offset: 0x0022C070
		public Span<byte> GetQualityCircleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060065CD RID: 26061 RVA: 0x0022DE80 File Offset: 0x0022C080
		public byte[] GetQualityCircleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x060065CE RID: 26062 RVA: 0x0022DE98 File Offset: 0x0022C098
		public string Name
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

		// Token: 0x060065CF RID: 26063 RVA: 0x0022DED0 File Offset: 0x0022C0D0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060065D0 RID: 26064 RVA: 0x0022DEE0 File Offset: 0x0022C0E0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x060065D1 RID: 26065 RVA: 0x0022DEF8 File Offset: 0x0022C0F8
		public string Icon
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

		// Token: 0x060065D2 RID: 26066 RVA: 0x0022DF30 File Offset: 0x0022C130
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060065D3 RID: 26067 RVA: 0x0022DF40 File Offset: 0x0022C140
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x060065D4 RID: 26068 RVA: 0x0022DF58 File Offset: 0x0022C158
		public string Desc
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

		// Token: 0x060065D5 RID: 26069 RVA: 0x0022DF90 File Offset: 0x0022C190
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060065D6 RID: 26070 RVA: 0x0022DFA0 File Offset: 0x0022C1A0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x060065D7 RID: 26071 RVA: 0x0022DFB8 File Offset: 0x0022C1B8
		public int RecommendOccupation(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x060065D8 RID: 26072 RVA: 0x0022DFF8 File Offset: 0x0022C1F8
		public int RecommendOccupationLength
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

		// Token: 0x060065D9 RID: 26073 RVA: 0x0022E024 File Offset: 0x0022C224
		public Span<int> GetRecommendOccupationBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x060065DA RID: 26074 RVA: 0x0022E034 File Offset: 0x0022C234
		public int[] GetRecommendOccupationArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x060065DB RID: 26075 RVA: 0x0022E04C File Offset: 0x0022C24C
		public bool IsShowTips
		{
			get
			{
				int num = this.__p.__offset(22);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x060065DC RID: 26076 RVA: 0x0022E08C File Offset: 0x0022C28C
		public int HyperLinkType
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

		// Token: 0x060065DD RID: 26077 RVA: 0x0022E0CC File Offset: 0x0022C2CC
		public DicIntInt? Term2ItemId(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x060065DE RID: 26078 RVA: 0x0022E130 File Offset: 0x0022C330
		public int Term2ItemIdLength
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

		// Token: 0x060065DF RID: 26079 RVA: 0x0022E15C File Offset: 0x0022C35C
		[NullableContext(1)]
		public ProAddEntry[] AddAttr()
		{
			return this.AddAttrIter().ToArray<ProAddEntry>();
		}

		// Token: 0x060065E0 RID: 26080 RVA: 0x0022E169 File Offset: 0x0022C369
		[NullableContext(1)]
		public IEnumerable<ProAddEntry> AddAttrIter()
		{
			DangoBrawlShopEvt.<AddAttrIter>d__48 <AddAttrIter>d__ = new DangoBrawlShopEvt.<AddAttrIter>d__48(-2);
			<AddAttrIter>d__.<>3__<>4__this = this;
			return <AddAttrIter>d__;
		}

		// Token: 0x060065E1 RID: 26081 RVA: 0x0022E17E File Offset: 0x0022C37E
		[NullableContext(1)]
		public int[] RecommendOccupation()
		{
			return this.GetRecommendOccupationArray();
		}

		// Token: 0x060065E2 RID: 26082 RVA: 0x0022E186 File Offset: 0x0022C386
		[NullableContext(1)]
		public IEnumerable<int> RecommendOccupationIter()
		{
			DangoBrawlShopEvt.<RecommendOccupationIter>d__50 <RecommendOccupationIter>d__ = new DangoBrawlShopEvt.<RecommendOccupationIter>d__50(-2);
			<RecommendOccupationIter>d__.<>3__<>4__this = this;
			return <RecommendOccupationIter>d__;
		}

		// Token: 0x060065E3 RID: 26083 RVA: 0x0022E19C File Offset: 0x0022C39C
		[NullableContext(1)]
		public Dictionary<int, int> Term2ItemId()
		{
			return this.Term2ItemIdIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060065E4 RID: 26084 RVA: 0x0022E1F2 File Offset: 0x0022C3F2
		[NullableContext(1)]
		public IEnumerable<DicIntInt> Term2ItemIdIter()
		{
			DangoBrawlShopEvt.<Term2ItemIdIter>d__52 <Term2ItemIdIter>d__ = new DangoBrawlShopEvt.<Term2ItemIdIter>d__52(-2);
			<Term2ItemIdIter>d__.<>3__<>4__this = this;
			return <Term2ItemIdIter>d__;
		}

		// Token: 0x060065E5 RID: 26085 RVA: 0x0022E208 File Offset: 0x0022C408
		public int? GetTerm2ItemId(int key)
		{
			this.EnsureTerm2ItemIdCacheIfNeeded();
			int value;
			if (!this.Term2ItemIdCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060065E6 RID: 26086 RVA: 0x0022E23C File Offset: 0x0022C43C
		private void EnsureTerm2ItemIdCacheIfNeeded()
		{
			if (this.Term2ItemIdCache != null)
			{
				return;
			}
			this.Term2ItemIdCache = this.Term2ItemIdIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060065E7 RID: 26087 RVA: 0x0022E2A2 File Offset: 0x0022C4A2
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetTerm2ItemIdFrozenDict()
		{
			this.EnsureTerm2ItemIdCacheIfNeeded();
			return this.Term2ItemIdCache;
		}

		// Token: 0x040051DF RID: 20959
		private Table __p;

		// Token: 0x040051E0 RID: 20960
		[Nullable(2)]
		private FrozenDictionary<int, int> Term2ItemIdCache;
	}
}

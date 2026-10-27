using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BD2 RID: 3026
	public struct DangoBrawlShopEvt : IFlatbufferObject
	{
		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06005FE5 RID: 24549 RVA: 0x0020E5C1 File Offset: 0x0020C7C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005FE6 RID: 24550 RVA: 0x0020E5CE File Offset: 0x0020C7CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005FE7 RID: 24551 RVA: 0x0020E5D8 File Offset: 0x0020C7D8
		public static DangoBrawlShopEvt GetRootAsDangoBrawlShopEvt(ByteBuffer _bb)
		{
			return DangoBrawlShopEvt.GetRootAsDangoBrawlShopEvt(_bb, default(DangoBrawlShopEvt));
		}

		// Token: 0x06005FE8 RID: 24552 RVA: 0x0020E5F4 File Offset: 0x0020C7F4
		public static DangoBrawlShopEvt GetRootAsDangoBrawlShopEvt(ByteBuffer _bb, DangoBrawlShopEvt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005FE9 RID: 24553 RVA: 0x0020E611 File Offset: 0x0020C811
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005FEA RID: 24554 RVA: 0x0020E620 File Offset: 0x0020C820
		public DangoBrawlShopEvt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06005FEB RID: 24555 RVA: 0x0020E630 File Offset: 0x0020C830
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

		// Token: 0x06005FEC RID: 24556 RVA: 0x0020E66C File Offset: 0x0020C86C
		public ProAddEntry? AddAttr(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ProAddEntry?(default(ProAddEntry).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06005FED RID: 24557 RVA: 0x0020E6CC File Offset: 0x0020C8CC
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

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06005FEE RID: 24558 RVA: 0x0020E6F8 File Offset: 0x0020C8F8
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

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06005FEF RID: 24559 RVA: 0x0020E734 File Offset: 0x0020C934
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

		// Token: 0x06005FF0 RID: 24560 RVA: 0x0020E76C File Offset: 0x0020C96C
		public Span<byte> GetQualityBgBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005FF1 RID: 24561 RVA: 0x0020E77C File Offset: 0x0020C97C
		public byte[] GetQualityBgArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06005FF2 RID: 24562 RVA: 0x0020E794 File Offset: 0x0020C994
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

		// Token: 0x06005FF3 RID: 24563 RVA: 0x0020E7CC File Offset: 0x0020C9CC
		public Span<byte> GetQualityCircleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005FF4 RID: 24564 RVA: 0x0020E7DC File Offset: 0x0020C9DC
		public byte[] GetQualityCircleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06005FF5 RID: 24565 RVA: 0x0020E7F4 File Offset: 0x0020C9F4
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

		// Token: 0x06005FF6 RID: 24566 RVA: 0x0020E82C File Offset: 0x0020CA2C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005FF7 RID: 24567 RVA: 0x0020E83C File Offset: 0x0020CA3C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06005FF8 RID: 24568 RVA: 0x0020E854 File Offset: 0x0020CA54
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

		// Token: 0x06005FF9 RID: 24569 RVA: 0x0020E88C File Offset: 0x0020CA8C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005FFA RID: 24570 RVA: 0x0020E89C File Offset: 0x0020CA9C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06005FFB RID: 24571 RVA: 0x0020E8B4 File Offset: 0x0020CAB4
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

		// Token: 0x06005FFC RID: 24572 RVA: 0x0020E8EC File Offset: 0x0020CAEC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06005FFD RID: 24573 RVA: 0x0020E8FC File Offset: 0x0020CAFC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06005FFE RID: 24574 RVA: 0x0020E914 File Offset: 0x0020CB14
		public int RecommendOccupation(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06005FFF RID: 24575 RVA: 0x0020E954 File Offset: 0x0020CB54
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

		// Token: 0x06006000 RID: 24576 RVA: 0x0020E980 File Offset: 0x0020CB80
		public Span<int> GetRecommendOccupationBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06006001 RID: 24577 RVA: 0x0020E990 File Offset: 0x0020CB90
		public int[] GetRecommendOccupationArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06006002 RID: 24578 RVA: 0x0020E9A8 File Offset: 0x0020CBA8
		public bool IsShowTips
		{
			get
			{
				int num = this.__p.__offset(22);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06006003 RID: 24579 RVA: 0x0020E9E8 File Offset: 0x0020CBE8
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

		// Token: 0x06006004 RID: 24580 RVA: 0x0020EA28 File Offset: 0x0020CC28
		public DicIntInt? Term2ItemId(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06006005 RID: 24581 RVA: 0x0020EA8C File Offset: 0x0020CC8C
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

		// Token: 0x06006006 RID: 24582 RVA: 0x0020EAB8 File Offset: 0x0020CCB8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AddAttrIter()或GetAddAttrBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly ProAddEntry[] AddAttr()
		{
			return this.AddAttrIter().ToArray<ProAddEntry>();
		}

		// Token: 0x06006007 RID: 24583 RVA: 0x0020EAC5 File Offset: 0x0020CCC5
		[NullableContext(1)]
		public readonly IEnumerable<ProAddEntry> AddAttrIter()
		{
			DangoBrawlShopEvt.<AddAttrIter>d__48 <AddAttrIter>d__ = new DangoBrawlShopEvt.<AddAttrIter>d__48(-2);
			<AddAttrIter>d__.<>3__<>4__this = this;
			return <AddAttrIter>d__;
		}

		// Token: 0x06006008 RID: 24584 RVA: 0x0020EADC File Offset: 0x0020CCDC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendOccupationIter()或GetRecommendOccupationBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendOccupation()
		{
			DangoBrawlShopEvt dangoBrawlShopEvt = this;
			return dangoBrawlShopEvt.GetRecommendOccupationArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006009 RID: 24585 RVA: 0x0020EB00 File Offset: 0x0020CD00
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendOccupationIter()
		{
			DangoBrawlShopEvt.<RecommendOccupationIter>d__50 <RecommendOccupationIter>d__ = new DangoBrawlShopEvt.<RecommendOccupationIter>d__50(-2);
			<RecommendOccupationIter>d__.<>3__<>4__this = this;
			return <RecommendOccupationIter>d__;
		}

		// Token: 0x0600600A RID: 24586 RVA: 0x0020EB18 File Offset: 0x0020CD18
		[NullableContext(1)]
		[Obsolete("已废弃，请使用Term2ItemIdFrozenDict()缓存字典，遍历请使用Term2ItemIdIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Term2ItemId()
		{
			return this.Term2ItemIdIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600600B RID: 24587 RVA: 0x0020EB6E File Offset: 0x0020CD6E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> Term2ItemIdIter()
		{
			DangoBrawlShopEvt.<Term2ItemIdIter>d__52 <Term2ItemIdIter>d__ = new DangoBrawlShopEvt.<Term2ItemIdIter>d__52(-2);
			<Term2ItemIdIter>d__.<>3__<>4__this = this;
			return <Term2ItemIdIter>d__;
		}

		// Token: 0x0600600C RID: 24588 RVA: 0x0020EB84 File Offset: 0x0020CD84
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

		// Token: 0x0600600D RID: 24589 RVA: 0x0020EBB8 File Offset: 0x0020CDB8
		private void EnsureTerm2ItemIdCacheIfNeeded()
		{
			if (this.Term2ItemIdCache != null)
			{
				return;
			}
			this.Term2ItemIdCache = this.Term2ItemIdIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600600E RID: 24590 RVA: 0x0020EC1E File Offset: 0x0020CE1E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetTerm2ItemIdFrozenDict(int key)
		{
			this.EnsureTerm2ItemIdCacheIfNeeded();
			return this.Term2ItemIdCache;
		}

		// Token: 0x04004BFD RID: 19453
		private Table __p;

		// Token: 0x04004BFE RID: 19454
		[Nullable(2)]
		private FrozenDictionary<int, int> Term2ItemIdCache;
	}
}

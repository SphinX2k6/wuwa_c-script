using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BD0 RID: 3024
	public struct DangoBrawlRound : IFlatbufferObject
	{
		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06005FB9 RID: 24505 RVA: 0x0020DEC5 File Offset: 0x0020C0C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005FBA RID: 24506 RVA: 0x0020DED2 File Offset: 0x0020C0D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005FBB RID: 24507 RVA: 0x0020DEDC File Offset: 0x0020C0DC
		public static DangoBrawlRound GetRootAsDangoBrawlRound(ByteBuffer _bb)
		{
			return DangoBrawlRound.GetRootAsDangoBrawlRound(_bb, default(DangoBrawlRound));
		}

		// Token: 0x06005FBC RID: 24508 RVA: 0x0020DEF8 File Offset: 0x0020C0F8
		public static DangoBrawlRound GetRootAsDangoBrawlRound(ByteBuffer _bb, DangoBrawlRound obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005FBD RID: 24509 RVA: 0x0020DF15 File Offset: 0x0020C115
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005FBE RID: 24510 RVA: 0x0020DF24 File Offset: 0x0020C124
		public DangoBrawlRound __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06005FBF RID: 24511 RVA: 0x0020DF34 File Offset: 0x0020C134
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

		// Token: 0x06005FC0 RID: 24512 RVA: 0x0020DF70 File Offset: 0x0020C170
		public IntArray? Opponents(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06005FC1 RID: 24513 RVA: 0x0020DFD0 File Offset: 0x0020C1D0
		public int OpponentsLength
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

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x06005FC2 RID: 24514 RVA: 0x0020DFFC File Offset: 0x0020C1FC
		public int RewardCoin
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

		// Token: 0x06005FC3 RID: 24515 RVA: 0x0020E038 File Offset: 0x0020C238
		public DicIntInt? ShopPoolWeight(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06005FC4 RID: 24516 RVA: 0x0020E09C File Offset: 0x0020C29C
		public int ShopPoolWeightLength
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

		// Token: 0x06005FC5 RID: 24517 RVA: 0x0020E0C8 File Offset: 0x0020C2C8
		public IntArray? PointShopItem(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06005FC6 RID: 24518 RVA: 0x0020E12C File Offset: 0x0020C32C
		public int PointShopItemLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06005FC7 RID: 24519 RVA: 0x0020E158 File Offset: 0x0020C358
		public int ShopGridCount
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06005FC8 RID: 24520 RVA: 0x0020E198 File Offset: 0x0020C398
		public int ShopEvtGridCount
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

		// Token: 0x06005FC9 RID: 24521 RVA: 0x0020E1D8 File Offset: 0x0020C3D8
		public float ShopRateList(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06005FCA RID: 24522 RVA: 0x0020E21C File Offset: 0x0020C41C
		public int ShopRateListLength
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

		// Token: 0x06005FCB RID: 24523 RVA: 0x0020E248 File Offset: 0x0020C448
		public Span<float> GetShopRateListBytes()
		{
			return this.__p.__vector_as_span<float>(18, 4);
		}

		// Token: 0x06005FCC RID: 24524 RVA: 0x0020E258 File Offset: 0x0020C458
		public float[] GetShopRateListArray()
		{
			return this.__p.__vector_as_array<float>(18) ?? Array.Empty<float>();
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06005FCD RID: 24525 RVA: 0x0020E270 File Offset: 0x0020C470
		public string ShopRateDesc
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

		// Token: 0x06005FCE RID: 24526 RVA: 0x0020E2A8 File Offset: 0x0020C4A8
		public Span<byte> GetShopRateDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005FCF RID: 24527 RVA: 0x0020E2B8 File Offset: 0x0020C4B8
		public byte[] GetShopRateDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x06005FD0 RID: 24528 RVA: 0x0020E2D0 File Offset: 0x0020C4D0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OpponentsIter()或GetOpponentsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] Opponents()
		{
			return this.OpponentsIter().ToArray<IntArray>();
		}

		// Token: 0x06005FD1 RID: 24529 RVA: 0x0020E2DD File Offset: 0x0020C4DD
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> OpponentsIter()
		{
			DangoBrawlRound.<OpponentsIter>d__35 <OpponentsIter>d__ = new DangoBrawlRound.<OpponentsIter>d__35(-2);
			<OpponentsIter>d__.<>3__<>4__this = this;
			return <OpponentsIter>d__;
		}

		// Token: 0x06005FD2 RID: 24530 RVA: 0x0020E2F2 File Offset: 0x0020C4F2
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PointShopItemIter()或GetPointShopItemBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] PointShopItem()
		{
			return this.PointShopItemIter().ToArray<IntArray>();
		}

		// Token: 0x06005FD3 RID: 24531 RVA: 0x0020E2FF File Offset: 0x0020C4FF
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> PointShopItemIter()
		{
			DangoBrawlRound.<PointShopItemIter>d__37 <PointShopItemIter>d__ = new DangoBrawlRound.<PointShopItemIter>d__37(-2);
			<PointShopItemIter>d__.<>3__<>4__this = this;
			return <PointShopItemIter>d__;
		}

		// Token: 0x06005FD4 RID: 24532 RVA: 0x0020E314 File Offset: 0x0020C514
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ShopPoolWeightFrozenDict()缓存字典，遍历请使用ShopPoolWeightIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ShopPoolWeight()
		{
			return this.ShopPoolWeightIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005FD5 RID: 24533 RVA: 0x0020E36A File Offset: 0x0020C56A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ShopPoolWeightIter()
		{
			DangoBrawlRound.<ShopPoolWeightIter>d__39 <ShopPoolWeightIter>d__ = new DangoBrawlRound.<ShopPoolWeightIter>d__39(-2);
			<ShopPoolWeightIter>d__.<>3__<>4__this = this;
			return <ShopPoolWeightIter>d__;
		}

		// Token: 0x06005FD6 RID: 24534 RVA: 0x0020E380 File Offset: 0x0020C580
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShopRateListIter()或GetShopRateListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] ShopRateList()
		{
			DangoBrawlRound dangoBrawlRound = this;
			return dangoBrawlRound.GetShopRateListArray() ?? Array.Empty<float>();
		}

		// Token: 0x06005FD7 RID: 24535 RVA: 0x0020E3A4 File Offset: 0x0020C5A4
		[NullableContext(1)]
		public readonly IEnumerable<float> ShopRateListIter()
		{
			DangoBrawlRound.<ShopRateListIter>d__41 <ShopRateListIter>d__ = new DangoBrawlRound.<ShopRateListIter>d__41(-2);
			<ShopRateListIter>d__.<>3__<>4__this = this;
			return <ShopRateListIter>d__;
		}

		// Token: 0x06005FD8 RID: 24536 RVA: 0x0020E3BC File Offset: 0x0020C5BC
		public int? GetShopPoolWeight(int key)
		{
			this.EnsureShopPoolWeightCacheIfNeeded();
			int value;
			if (!this.ShopPoolWeightCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06005FD9 RID: 24537 RVA: 0x0020E3F0 File Offset: 0x0020C5F0
		private void EnsureShopPoolWeightCacheIfNeeded()
		{
			if (this.ShopPoolWeightCache != null)
			{
				return;
			}
			this.ShopPoolWeightCache = this.ShopPoolWeightIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005FDA RID: 24538 RVA: 0x0020E456 File Offset: 0x0020C656
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetShopPoolWeightFrozenDict(int key)
		{
			this.EnsureShopPoolWeightCacheIfNeeded();
			return this.ShopPoolWeightCache;
		}

		// Token: 0x04004BFA RID: 19450
		private Table __p;

		// Token: 0x04004BFB RID: 19451
		[Nullable(2)]
		private FrozenDictionary<int, int> ShopPoolWeightCache;
	}
}

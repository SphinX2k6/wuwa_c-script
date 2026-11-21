using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CB2 RID: 3250
	public struct DangoBrawlRound : IFlatbufferObject
	{
		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06006592 RID: 26002 RVA: 0x0022D589 File Offset: 0x0022B789
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006593 RID: 26003 RVA: 0x0022D596 File Offset: 0x0022B796
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006594 RID: 26004 RVA: 0x0022D5A0 File Offset: 0x0022B7A0
		public static DangoBrawlRound GetRootAsDangoBrawlRound(ByteBuffer _bb)
		{
			return DangoBrawlRound.GetRootAsDangoBrawlRound(_bb, default(DangoBrawlRound));
		}

		// Token: 0x06006595 RID: 26005 RVA: 0x0022D5BC File Offset: 0x0022B7BC
		public static DangoBrawlRound GetRootAsDangoBrawlRound(ByteBuffer _bb, DangoBrawlRound obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006596 RID: 26006 RVA: 0x0022D5D9 File Offset: 0x0022B7D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006597 RID: 26007 RVA: 0x0022D5E8 File Offset: 0x0022B7E8
		public DangoBrawlRound __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06006598 RID: 26008 RVA: 0x0022D5F8 File Offset: 0x0022B7F8
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

		// Token: 0x06006599 RID: 26009 RVA: 0x0022D634 File Offset: 0x0022B834
		public IntArray? Opponents(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x0600659A RID: 26010 RVA: 0x0022D694 File Offset: 0x0022B894
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

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x0600659B RID: 26011 RVA: 0x0022D6C0 File Offset: 0x0022B8C0
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

		// Token: 0x0600659C RID: 26012 RVA: 0x0022D6FC File Offset: 0x0022B8FC
		public DicIntInt? ShopPoolWeight(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x0600659D RID: 26013 RVA: 0x0022D760 File Offset: 0x0022B960
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

		// Token: 0x0600659E RID: 26014 RVA: 0x0022D78C File Offset: 0x0022B98C
		public IntArray? PointShopItem(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x0600659F RID: 26015 RVA: 0x0022D7F0 File Offset: 0x0022B9F0
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

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x060065A0 RID: 26016 RVA: 0x0022D81C File Offset: 0x0022BA1C
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

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x060065A1 RID: 26017 RVA: 0x0022D85C File Offset: 0x0022BA5C
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

		// Token: 0x060065A2 RID: 26018 RVA: 0x0022D89C File Offset: 0x0022BA9C
		public float ShopRateList(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x060065A3 RID: 26019 RVA: 0x0022D8E0 File Offset: 0x0022BAE0
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

		// Token: 0x060065A4 RID: 26020 RVA: 0x0022D90C File Offset: 0x0022BB0C
		public Span<float> GetShopRateListBytes()
		{
			return this.__p.__vector_as_span<float>(18, 4);
		}

		// Token: 0x060065A5 RID: 26021 RVA: 0x0022D91C File Offset: 0x0022BB1C
		public float[] GetShopRateListArray()
		{
			return this.__p.__vector_as_array<float>(18) ?? Array.Empty<float>();
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x060065A6 RID: 26022 RVA: 0x0022D934 File Offset: 0x0022BB34
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

		// Token: 0x060065A7 RID: 26023 RVA: 0x0022D96C File Offset: 0x0022BB6C
		public Span<byte> GetShopRateDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060065A8 RID: 26024 RVA: 0x0022D97C File Offset: 0x0022BB7C
		public byte[] GetShopRateDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x060065A9 RID: 26025 RVA: 0x0022D994 File Offset: 0x0022BB94
		[NullableContext(1)]
		public IntArray[] Opponents()
		{
			return this.OpponentsIter().ToArray<IntArray>();
		}

		// Token: 0x060065AA RID: 26026 RVA: 0x0022D9A1 File Offset: 0x0022BBA1
		[NullableContext(1)]
		public IEnumerable<IntArray> OpponentsIter()
		{
			DangoBrawlRound.<OpponentsIter>d__35 <OpponentsIter>d__ = new DangoBrawlRound.<OpponentsIter>d__35(-2);
			<OpponentsIter>d__.<>3__<>4__this = this;
			return <OpponentsIter>d__;
		}

		// Token: 0x060065AB RID: 26027 RVA: 0x0022D9B6 File Offset: 0x0022BBB6
		[NullableContext(1)]
		public IntArray[] PointShopItem()
		{
			return this.PointShopItemIter().ToArray<IntArray>();
		}

		// Token: 0x060065AC RID: 26028 RVA: 0x0022D9C3 File Offset: 0x0022BBC3
		[NullableContext(1)]
		public IEnumerable<IntArray> PointShopItemIter()
		{
			DangoBrawlRound.<PointShopItemIter>d__37 <PointShopItemIter>d__ = new DangoBrawlRound.<PointShopItemIter>d__37(-2);
			<PointShopItemIter>d__.<>3__<>4__this = this;
			return <PointShopItemIter>d__;
		}

		// Token: 0x060065AD RID: 26029 RVA: 0x0022D9D8 File Offset: 0x0022BBD8
		[NullableContext(1)]
		public Dictionary<int, int> ShopPoolWeight()
		{
			return this.ShopPoolWeightIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060065AE RID: 26030 RVA: 0x0022DA2E File Offset: 0x0022BC2E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ShopPoolWeightIter()
		{
			DangoBrawlRound.<ShopPoolWeightIter>d__39 <ShopPoolWeightIter>d__ = new DangoBrawlRound.<ShopPoolWeightIter>d__39(-2);
			<ShopPoolWeightIter>d__.<>3__<>4__this = this;
			return <ShopPoolWeightIter>d__;
		}

		// Token: 0x060065AF RID: 26031 RVA: 0x0022DA43 File Offset: 0x0022BC43
		[NullableContext(1)]
		public float[] ShopRateList()
		{
			return this.GetShopRateListArray();
		}

		// Token: 0x060065B0 RID: 26032 RVA: 0x0022DA4B File Offset: 0x0022BC4B
		[NullableContext(1)]
		public IEnumerable<float> ShopRateListIter()
		{
			DangoBrawlRound.<ShopRateListIter>d__41 <ShopRateListIter>d__ = new DangoBrawlRound.<ShopRateListIter>d__41(-2);
			<ShopRateListIter>d__.<>3__<>4__this = this;
			return <ShopRateListIter>d__;
		}

		// Token: 0x060065B1 RID: 26033 RVA: 0x0022DA60 File Offset: 0x0022BC60
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

		// Token: 0x060065B2 RID: 26034 RVA: 0x0022DA94 File Offset: 0x0022BC94
		private void EnsureShopPoolWeightCacheIfNeeded()
		{
			if (this.ShopPoolWeightCache != null)
			{
				return;
			}
			this.ShopPoolWeightCache = this.ShopPoolWeightIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060065B3 RID: 26035 RVA: 0x0022DAFA File Offset: 0x0022BCFA
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetShopPoolWeightFrozenDict()
		{
			this.EnsureShopPoolWeightCacheIfNeeded();
			return this.ShopPoolWeightCache;
		}

		// Token: 0x040051DC RID: 20956
		private Table __p;

		// Token: 0x040051DD RID: 20957
		[Nullable(2)]
		private FrozenDictionary<int, int> ShopPoolWeightCache;
	}
}

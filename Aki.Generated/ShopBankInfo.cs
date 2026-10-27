using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010AA RID: 4266
	public struct ShopBankInfo : IFlatbufferObject
	{
		// Token: 0x170035BC RID: 13756
		// (get) Token: 0x0600D1B9 RID: 53689 RVA: 0x0030EA68 File Offset: 0x0030CC68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D1BA RID: 53690 RVA: 0x0030EA75 File Offset: 0x0030CC75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D1BB RID: 53691 RVA: 0x0030EA7C File Offset: 0x0030CC7C
		public static ShopBankInfo GetRootAsShopBankInfo(ByteBuffer _bb)
		{
			return ShopBankInfo.GetRootAsShopBankInfo(_bb, default(ShopBankInfo));
		}

		// Token: 0x0600D1BC RID: 53692 RVA: 0x0030EA98 File Offset: 0x0030CC98
		public static ShopBankInfo GetRootAsShopBankInfo(ByteBuffer _bb, ShopBankInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D1BD RID: 53693 RVA: 0x0030EAB5 File Offset: 0x0030CCB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D1BE RID: 53694 RVA: 0x0030EAC4 File Offset: 0x0030CCC4
		public ShopBankInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035BD RID: 13757
		// (get) Token: 0x0600D1BF RID: 53695 RVA: 0x0030EAD4 File Offset: 0x0030CCD4
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

		// Token: 0x170035BE RID: 13758
		// (get) Token: 0x0600D1C0 RID: 53696 RVA: 0x0030EB10 File Offset: 0x0030CD10
		public int BankId
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

		// Token: 0x170035BF RID: 13759
		// (get) Token: 0x0600D1C1 RID: 53697 RVA: 0x0030EB4C File Offset: 0x0030CD4C
		public int ItemId
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

		// Token: 0x170035C0 RID: 13760
		// (get) Token: 0x0600D1C2 RID: 53698 RVA: 0x0030EB88 File Offset: 0x0030CD88
		public int Weight
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

		// Token: 0x170035C1 RID: 13761
		// (get) Token: 0x0600D1C3 RID: 53699 RVA: 0x0030EBC8 File Offset: 0x0030CDC8
		public int ItemNum
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

		// Token: 0x170035C2 RID: 13762
		// (get) Token: 0x0600D1C4 RID: 53700 RVA: 0x0030EC08 File Offset: 0x0030CE08
		public int LimitNum
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

		// Token: 0x0600D1C5 RID: 53701 RVA: 0x0030EC48 File Offset: 0x0030CE48
		public DicIntInt? OriginalPrice(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170035C3 RID: 13763
		// (get) Token: 0x0600D1C6 RID: 53702 RVA: 0x0030ECAC File Offset: 0x0030CEAC
		public int OriginalPriceLength
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

		// Token: 0x0600D1C7 RID: 53703 RVA: 0x0030ECD8 File Offset: 0x0030CED8
		public DicIntInt? Price(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170035C4 RID: 13764
		// (get) Token: 0x0600D1C8 RID: 53704 RVA: 0x0030ED3C File Offset: 0x0030CF3C
		public int PriceLength
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

		// Token: 0x170035C5 RID: 13765
		// (get) Token: 0x0600D1C9 RID: 53705 RVA: 0x0030ED68 File Offset: 0x0030CF68
		public bool Show
		{
			get
			{
				int num = this.__p.__offset(20);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170035C6 RID: 13766
		// (get) Token: 0x0600D1CA RID: 53706 RVA: 0x0030EDA8 File Offset: 0x0030CFA8
		public string Label
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

		// Token: 0x0600D1CB RID: 53707 RVA: 0x0030EDE0 File Offset: 0x0030CFE0
		public Span<byte> GetLabelBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600D1CC RID: 53708 RVA: 0x0030EDF0 File Offset: 0x0030CFF0
		public byte[] GetLabelArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D1CD RID: 53709 RVA: 0x0030EE08 File Offset: 0x0030D008
		[NullableContext(1)]
		[Obsolete("已废弃，请使用OriginalPriceFrozenDict()缓存字典，遍历请使用OriginalPriceIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> OriginalPrice()
		{
			return this.OriginalPriceIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D1CE RID: 53710 RVA: 0x0030EE5E File Offset: 0x0030D05E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> OriginalPriceIter()
		{
			ShopBankInfo.<OriginalPriceIter>d__33 <OriginalPriceIter>d__ = new ShopBankInfo.<OriginalPriceIter>d__33(-2);
			<OriginalPriceIter>d__.<>3__<>4__this = this;
			return <OriginalPriceIter>d__;
		}

		// Token: 0x0600D1CF RID: 53711 RVA: 0x0030EE74 File Offset: 0x0030D074
		[NullableContext(1)]
		[Obsolete("已废弃，请使用PriceFrozenDict()缓存字典，遍历请使用PriceIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Price()
		{
			return this.PriceIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D1D0 RID: 53712 RVA: 0x0030EECA File Offset: 0x0030D0CA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> PriceIter()
		{
			ShopBankInfo.<PriceIter>d__35 <PriceIter>d__ = new ShopBankInfo.<PriceIter>d__35(-2);
			<PriceIter>d__.<>3__<>4__this = this;
			return <PriceIter>d__;
		}

		// Token: 0x0600D1D1 RID: 53713 RVA: 0x0030EEE0 File Offset: 0x0030D0E0
		public int? GetOriginalPrice(int key)
		{
			this.EnsureOriginalPriceCacheIfNeeded();
			int value;
			if (!this.OriginalPriceCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600D1D2 RID: 53714 RVA: 0x0030EF14 File Offset: 0x0030D114
		public int? GetPrice(int key)
		{
			this.EnsurePriceCacheIfNeeded();
			int value;
			if (!this.PriceCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600D1D3 RID: 53715 RVA: 0x0030EF48 File Offset: 0x0030D148
		private void EnsureOriginalPriceCacheIfNeeded()
		{
			if (this.OriginalPriceCache != null)
			{
				return;
			}
			this.OriginalPriceCache = this.OriginalPriceIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D1D4 RID: 53716 RVA: 0x0030EFB0 File Offset: 0x0030D1B0
		private void EnsurePriceCacheIfNeeded()
		{
			if (this.PriceCache != null)
			{
				return;
			}
			this.PriceCache = this.PriceIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D1D5 RID: 53717 RVA: 0x0030F016 File Offset: 0x0030D216
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetOriginalPriceFrozenDict(int key)
		{
			this.EnsureOriginalPriceCacheIfNeeded();
			return this.OriginalPriceCache;
		}

		// Token: 0x0600D1D6 RID: 53718 RVA: 0x0030F024 File Offset: 0x0030D224
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetPriceFrozenDict(int key)
		{
			this.EnsurePriceCacheIfNeeded();
			return this.PriceCache;
		}

		// Token: 0x040051B9 RID: 20921
		private Table __p;

		// Token: 0x040051BA RID: 20922
		[Nullable(2)]
		private FrozenDictionary<int, int> OriginalPriceCache;

		// Token: 0x040051BB RID: 20923
		[Nullable(2)]
		private FrozenDictionary<int, int> PriceCache;
	}
}

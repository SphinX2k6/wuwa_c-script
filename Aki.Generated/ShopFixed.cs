using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010AB RID: 4267
	public struct ShopFixed : IFlatbufferObject
	{
		// Token: 0x170035C7 RID: 13767
		// (get) Token: 0x0600D1D7 RID: 53719 RVA: 0x0030F032 File Offset: 0x0030D232
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D1D8 RID: 53720 RVA: 0x0030F03F File Offset: 0x0030D23F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D1D9 RID: 53721 RVA: 0x0030F048 File Offset: 0x0030D248
		public static ShopFixed GetRootAsShopFixed(ByteBuffer _bb)
		{
			return ShopFixed.GetRootAsShopFixed(_bb, default(ShopFixed));
		}

		// Token: 0x0600D1DA RID: 53722 RVA: 0x0030F064 File Offset: 0x0030D264
		public static ShopFixed GetRootAsShopFixed(ByteBuffer _bb, ShopFixed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D1DB RID: 53723 RVA: 0x0030F081 File Offset: 0x0030D281
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D1DC RID: 53724 RVA: 0x0030F090 File Offset: 0x0030D290
		public ShopFixed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035C8 RID: 13768
		// (get) Token: 0x0600D1DD RID: 53725 RVA: 0x0030F0A0 File Offset: 0x0030D2A0
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

		// Token: 0x170035C9 RID: 13769
		// (get) Token: 0x0600D1DE RID: 53726 RVA: 0x0030F0DC File Offset: 0x0030D2DC
		public int ShopId
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

		// Token: 0x170035CA RID: 13770
		// (get) Token: 0x0600D1DF RID: 53727 RVA: 0x0030F118 File Offset: 0x0030D318
		public int SortIndex
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

		// Token: 0x170035CB RID: 13771
		// (get) Token: 0x0600D1E0 RID: 53728 RVA: 0x0030F154 File Offset: 0x0030D354
		public int ItemId
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

		// Token: 0x170035CC RID: 13772
		// (get) Token: 0x0600D1E1 RID: 53729 RVA: 0x0030F194 File Offset: 0x0030D394
		public int ItemNum
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170035CD RID: 13773
		// (get) Token: 0x0600D1E2 RID: 53730 RVA: 0x0030F1D4 File Offset: 0x0030D3D4
		public int CondId
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

		// Token: 0x170035CE RID: 13774
		// (get) Token: 0x0600D1E3 RID: 53731 RVA: 0x0030F214 File Offset: 0x0030D414
		public int VisableCondition
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

		// Token: 0x170035CF RID: 13775
		// (get) Token: 0x0600D1E4 RID: 53732 RVA: 0x0030F254 File Offset: 0x0030D454
		public int DisableCondition
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170035D0 RID: 13776
		// (get) Token: 0x0600D1E5 RID: 53733 RVA: 0x0030F294 File Offset: 0x0030D494
		public int LimitNum
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D1E6 RID: 53734 RVA: 0x0030F2D4 File Offset: 0x0030D4D4
		public DicIntInt? OriginalPrice(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170035D1 RID: 13777
		// (get) Token: 0x0600D1E7 RID: 53735 RVA: 0x0030F338 File Offset: 0x0030D538
		public int OriginalPriceLength
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

		// Token: 0x0600D1E8 RID: 53736 RVA: 0x0030F364 File Offset: 0x0030D564
		public DicIntInt? Price(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170035D2 RID: 13778
		// (get) Token: 0x0600D1E9 RID: 53737 RVA: 0x0030F3C8 File Offset: 0x0030D5C8
		public int PriceLength
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

		// Token: 0x170035D3 RID: 13779
		// (get) Token: 0x0600D1EA RID: 53738 RVA: 0x0030F3F4 File Offset: 0x0030D5F4
		public bool Show
		{
			get
			{
				int num = this.__p.__offset(26);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170035D4 RID: 13780
		// (get) Token: 0x0600D1EB RID: 53739 RVA: 0x0030F434 File Offset: 0x0030D634
		public string Label
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

		// Token: 0x0600D1EC RID: 53740 RVA: 0x0030F46C File Offset: 0x0030D66C
		public Span<byte> GetLabelBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600D1ED RID: 53741 RVA: 0x0030F47C File Offset: 0x0030D67C
		public byte[] GetLabelArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170035D5 RID: 13781
		// (get) Token: 0x0600D1EE RID: 53742 RVA: 0x0030F494 File Offset: 0x0030D694
		public string SwitchText
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D1EF RID: 53743 RVA: 0x0030F4CC File Offset: 0x0030D6CC
		public Span<byte> GetSwitchTextBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600D1F0 RID: 53744 RVA: 0x0030F4DC File Offset: 0x0030D6DC
		public byte[] GetSwitchTextArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170035D6 RID: 13782
		// (get) Token: 0x0600D1F1 RID: 53745 RVA: 0x0030F4F4 File Offset: 0x0030D6F4
		public string PurchaseText
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D1F2 RID: 53746 RVA: 0x0030F52C File Offset: 0x0030D72C
		public Span<byte> GetPurchaseTextBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600D1F3 RID: 53747 RVA: 0x0030F53C File Offset: 0x0030D73C
		public byte[] GetPurchaseTextArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D1F4 RID: 53748 RVA: 0x0030F554 File Offset: 0x0030D754
		[NullableContext(1)]
		[Obsolete("已废弃，请使用OriginalPriceFrozenDict()缓存字典，遍历请使用OriginalPriceIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> OriginalPrice()
		{
			return this.OriginalPriceIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D1F5 RID: 53749 RVA: 0x0030F5AA File Offset: 0x0030D7AA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> OriginalPriceIter()
		{
			ShopFixed.<OriginalPriceIter>d__47 <OriginalPriceIter>d__ = new ShopFixed.<OriginalPriceIter>d__47(-2);
			<OriginalPriceIter>d__.<>3__<>4__this = this;
			return <OriginalPriceIter>d__;
		}

		// Token: 0x0600D1F6 RID: 53750 RVA: 0x0030F5C0 File Offset: 0x0030D7C0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用PriceFrozenDict()缓存字典，遍历请使用PriceIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Price()
		{
			return this.PriceIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D1F7 RID: 53751 RVA: 0x0030F616 File Offset: 0x0030D816
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> PriceIter()
		{
			ShopFixed.<PriceIter>d__49 <PriceIter>d__ = new ShopFixed.<PriceIter>d__49(-2);
			<PriceIter>d__.<>3__<>4__this = this;
			return <PriceIter>d__;
		}

		// Token: 0x0600D1F8 RID: 53752 RVA: 0x0030F62C File Offset: 0x0030D82C
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

		// Token: 0x0600D1F9 RID: 53753 RVA: 0x0030F660 File Offset: 0x0030D860
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

		// Token: 0x0600D1FA RID: 53754 RVA: 0x0030F694 File Offset: 0x0030D894
		private void EnsureOriginalPriceCacheIfNeeded()
		{
			if (this.OriginalPriceCache != null)
			{
				return;
			}
			this.OriginalPriceCache = this.OriginalPriceIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D1FB RID: 53755 RVA: 0x0030F6FC File Offset: 0x0030D8FC
		private void EnsurePriceCacheIfNeeded()
		{
			if (this.PriceCache != null)
			{
				return;
			}
			this.PriceCache = this.PriceIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D1FC RID: 53756 RVA: 0x0030F762 File Offset: 0x0030D962
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetOriginalPriceFrozenDict(int key)
		{
			this.EnsureOriginalPriceCacheIfNeeded();
			return this.OriginalPriceCache;
		}

		// Token: 0x0600D1FD RID: 53757 RVA: 0x0030F770 File Offset: 0x0030D970
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetPriceFrozenDict(int key)
		{
			this.EnsurePriceCacheIfNeeded();
			return this.PriceCache;
		}

		// Token: 0x040051BC RID: 20924
		private Table __p;

		// Token: 0x040051BD RID: 20925
		[Nullable(2)]
		private FrozenDictionary<int, int> OriginalPriceCache;

		// Token: 0x040051BE RID: 20926
		[Nullable(2)]
		private FrozenDictionary<int, int> PriceCache;
	}
}

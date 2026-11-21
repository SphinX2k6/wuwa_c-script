using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011A6 RID: 4518
	public struct ShopFixed : IFlatbufferObject
	{
		// Token: 0x170036D5 RID: 14037
		// (get) Token: 0x0600D9AD RID: 55725 RVA: 0x0032E506 File Offset: 0x0032C706
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D9AE RID: 55726 RVA: 0x0032E513 File Offset: 0x0032C713
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D9AF RID: 55727 RVA: 0x0032E51C File Offset: 0x0032C71C
		public static ShopFixed GetRootAsShopFixed(ByteBuffer _bb)
		{
			return ShopFixed.GetRootAsShopFixed(_bb, default(ShopFixed));
		}

		// Token: 0x0600D9B0 RID: 55728 RVA: 0x0032E538 File Offset: 0x0032C738
		public static ShopFixed GetRootAsShopFixed(ByteBuffer _bb, ShopFixed obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D9B1 RID: 55729 RVA: 0x0032E555 File Offset: 0x0032C755
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D9B2 RID: 55730 RVA: 0x0032E564 File Offset: 0x0032C764
		public ShopFixed __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170036D6 RID: 14038
		// (get) Token: 0x0600D9B3 RID: 55731 RVA: 0x0032E574 File Offset: 0x0032C774
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

		// Token: 0x170036D7 RID: 14039
		// (get) Token: 0x0600D9B4 RID: 55732 RVA: 0x0032E5B0 File Offset: 0x0032C7B0
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

		// Token: 0x170036D8 RID: 14040
		// (get) Token: 0x0600D9B5 RID: 55733 RVA: 0x0032E5EC File Offset: 0x0032C7EC
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

		// Token: 0x170036D9 RID: 14041
		// (get) Token: 0x0600D9B6 RID: 55734 RVA: 0x0032E628 File Offset: 0x0032C828
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

		// Token: 0x170036DA RID: 14042
		// (get) Token: 0x0600D9B7 RID: 55735 RVA: 0x0032E668 File Offset: 0x0032C868
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

		// Token: 0x170036DB RID: 14043
		// (get) Token: 0x0600D9B8 RID: 55736 RVA: 0x0032E6A8 File Offset: 0x0032C8A8
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

		// Token: 0x170036DC RID: 14044
		// (get) Token: 0x0600D9B9 RID: 55737 RVA: 0x0032E6E8 File Offset: 0x0032C8E8
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

		// Token: 0x170036DD RID: 14045
		// (get) Token: 0x0600D9BA RID: 55738 RVA: 0x0032E728 File Offset: 0x0032C928
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

		// Token: 0x170036DE RID: 14046
		// (get) Token: 0x0600D9BB RID: 55739 RVA: 0x0032E768 File Offset: 0x0032C968
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

		// Token: 0x0600D9BC RID: 55740 RVA: 0x0032E7A8 File Offset: 0x0032C9A8
		public DicIntInt? OriginalPrice(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170036DF RID: 14047
		// (get) Token: 0x0600D9BD RID: 55741 RVA: 0x0032E80C File Offset: 0x0032CA0C
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

		// Token: 0x0600D9BE RID: 55742 RVA: 0x0032E838 File Offset: 0x0032CA38
		public DicIntInt? Price(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170036E0 RID: 14048
		// (get) Token: 0x0600D9BF RID: 55743 RVA: 0x0032E89C File Offset: 0x0032CA9C
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

		// Token: 0x170036E1 RID: 14049
		// (get) Token: 0x0600D9C0 RID: 55744 RVA: 0x0032E8C8 File Offset: 0x0032CAC8
		public bool Show
		{
			get
			{
				int num = this.__p.__offset(26);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170036E2 RID: 14050
		// (get) Token: 0x0600D9C1 RID: 55745 RVA: 0x0032E908 File Offset: 0x0032CB08
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

		// Token: 0x0600D9C2 RID: 55746 RVA: 0x0032E940 File Offset: 0x0032CB40
		public Span<byte> GetLabelBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600D9C3 RID: 55747 RVA: 0x0032E950 File Offset: 0x0032CB50
		public byte[] GetLabelArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170036E3 RID: 14051
		// (get) Token: 0x0600D9C4 RID: 55748 RVA: 0x0032E968 File Offset: 0x0032CB68
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

		// Token: 0x0600D9C5 RID: 55749 RVA: 0x0032E9A0 File Offset: 0x0032CBA0
		public Span<byte> GetSwitchTextBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600D9C6 RID: 55750 RVA: 0x0032E9B0 File Offset: 0x0032CBB0
		public byte[] GetSwitchTextArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170036E4 RID: 14052
		// (get) Token: 0x0600D9C7 RID: 55751 RVA: 0x0032E9C8 File Offset: 0x0032CBC8
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

		// Token: 0x0600D9C8 RID: 55752 RVA: 0x0032EA00 File Offset: 0x0032CC00
		public Span<byte> GetPurchaseTextBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600D9C9 RID: 55753 RVA: 0x0032EA10 File Offset: 0x0032CC10
		public byte[] GetPurchaseTextArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D9CA RID: 55754 RVA: 0x0032EA28 File Offset: 0x0032CC28
		[NullableContext(1)]
		public Dictionary<int, int> OriginalPrice()
		{
			return this.OriginalPriceIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D9CB RID: 55755 RVA: 0x0032EA7E File Offset: 0x0032CC7E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> OriginalPriceIter()
		{
			ShopFixed.<OriginalPriceIter>d__47 <OriginalPriceIter>d__ = new ShopFixed.<OriginalPriceIter>d__47(-2);
			<OriginalPriceIter>d__.<>3__<>4__this = this;
			return <OriginalPriceIter>d__;
		}

		// Token: 0x0600D9CC RID: 55756 RVA: 0x0032EA94 File Offset: 0x0032CC94
		[NullableContext(1)]
		public Dictionary<int, int> Price()
		{
			return this.PriceIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D9CD RID: 55757 RVA: 0x0032EAEA File Offset: 0x0032CCEA
		[NullableContext(1)]
		public IEnumerable<DicIntInt> PriceIter()
		{
			ShopFixed.<PriceIter>d__49 <PriceIter>d__ = new ShopFixed.<PriceIter>d__49(-2);
			<PriceIter>d__.<>3__<>4__this = this;
			return <PriceIter>d__;
		}

		// Token: 0x0600D9CE RID: 55758 RVA: 0x0032EB00 File Offset: 0x0032CD00
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

		// Token: 0x0600D9CF RID: 55759 RVA: 0x0032EB34 File Offset: 0x0032CD34
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

		// Token: 0x0600D9D0 RID: 55760 RVA: 0x0032EB68 File Offset: 0x0032CD68
		private void EnsureOriginalPriceCacheIfNeeded()
		{
			if (this.OriginalPriceCache != null)
			{
				return;
			}
			this.OriginalPriceCache = this.OriginalPriceIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D9D1 RID: 55761 RVA: 0x0032EBD0 File Offset: 0x0032CDD0
		private void EnsurePriceCacheIfNeeded()
		{
			if (this.PriceCache != null)
			{
				return;
			}
			this.PriceCache = this.PriceIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D9D2 RID: 55762 RVA: 0x0032EC36 File Offset: 0x0032CE36
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetOriginalPriceFrozenDict()
		{
			this.EnsureOriginalPriceCacheIfNeeded();
			return this.OriginalPriceCache;
		}

		// Token: 0x0600D9D3 RID: 55763 RVA: 0x0032EC44 File Offset: 0x0032CE44
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetPriceFrozenDict()
		{
			this.EnsurePriceCacheIfNeeded();
			return this.PriceCache;
		}

		// Token: 0x040057BB RID: 22459
		private Table __p;

		// Token: 0x040057BC RID: 22460
		[Nullable(2)]
		private FrozenDictionary<int, int> OriginalPriceCache;

		// Token: 0x040057BD RID: 22461
		[Nullable(2)]
		private FrozenDictionary<int, int> PriceCache;
	}
}

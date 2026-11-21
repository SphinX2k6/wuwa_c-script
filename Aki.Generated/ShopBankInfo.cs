using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011A5 RID: 4517
	public struct ShopBankInfo : IFlatbufferObject
	{
		// Token: 0x170036CA RID: 14026
		// (get) Token: 0x0600D98F RID: 55695 RVA: 0x0032DF3C File Offset: 0x0032C13C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D990 RID: 55696 RVA: 0x0032DF49 File Offset: 0x0032C149
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D991 RID: 55697 RVA: 0x0032DF50 File Offset: 0x0032C150
		public static ShopBankInfo GetRootAsShopBankInfo(ByteBuffer _bb)
		{
			return ShopBankInfo.GetRootAsShopBankInfo(_bb, default(ShopBankInfo));
		}

		// Token: 0x0600D992 RID: 55698 RVA: 0x0032DF6C File Offset: 0x0032C16C
		public static ShopBankInfo GetRootAsShopBankInfo(ByteBuffer _bb, ShopBankInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D993 RID: 55699 RVA: 0x0032DF89 File Offset: 0x0032C189
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D994 RID: 55700 RVA: 0x0032DF98 File Offset: 0x0032C198
		public ShopBankInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170036CB RID: 14027
		// (get) Token: 0x0600D995 RID: 55701 RVA: 0x0032DFA8 File Offset: 0x0032C1A8
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

		// Token: 0x170036CC RID: 14028
		// (get) Token: 0x0600D996 RID: 55702 RVA: 0x0032DFE4 File Offset: 0x0032C1E4
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

		// Token: 0x170036CD RID: 14029
		// (get) Token: 0x0600D997 RID: 55703 RVA: 0x0032E020 File Offset: 0x0032C220
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

		// Token: 0x170036CE RID: 14030
		// (get) Token: 0x0600D998 RID: 55704 RVA: 0x0032E05C File Offset: 0x0032C25C
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

		// Token: 0x170036CF RID: 14031
		// (get) Token: 0x0600D999 RID: 55705 RVA: 0x0032E09C File Offset: 0x0032C29C
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

		// Token: 0x170036D0 RID: 14032
		// (get) Token: 0x0600D99A RID: 55706 RVA: 0x0032E0DC File Offset: 0x0032C2DC
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

		// Token: 0x0600D99B RID: 55707 RVA: 0x0032E11C File Offset: 0x0032C31C
		public DicIntInt? OriginalPrice(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170036D1 RID: 14033
		// (get) Token: 0x0600D99C RID: 55708 RVA: 0x0032E180 File Offset: 0x0032C380
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

		// Token: 0x0600D99D RID: 55709 RVA: 0x0032E1AC File Offset: 0x0032C3AC
		public DicIntInt? Price(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170036D2 RID: 14034
		// (get) Token: 0x0600D99E RID: 55710 RVA: 0x0032E210 File Offset: 0x0032C410
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

		// Token: 0x170036D3 RID: 14035
		// (get) Token: 0x0600D99F RID: 55711 RVA: 0x0032E23C File Offset: 0x0032C43C
		public bool Show
		{
			get
			{
				int num = this.__p.__offset(20);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170036D4 RID: 14036
		// (get) Token: 0x0600D9A0 RID: 55712 RVA: 0x0032E27C File Offset: 0x0032C47C
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

		// Token: 0x0600D9A1 RID: 55713 RVA: 0x0032E2B4 File Offset: 0x0032C4B4
		public Span<byte> GetLabelBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600D9A2 RID: 55714 RVA: 0x0032E2C4 File Offset: 0x0032C4C4
		public byte[] GetLabelArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D9A3 RID: 55715 RVA: 0x0032E2DC File Offset: 0x0032C4DC
		[NullableContext(1)]
		public Dictionary<int, int> OriginalPrice()
		{
			return this.OriginalPriceIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D9A4 RID: 55716 RVA: 0x0032E332 File Offset: 0x0032C532
		[NullableContext(1)]
		public IEnumerable<DicIntInt> OriginalPriceIter()
		{
			ShopBankInfo.<OriginalPriceIter>d__33 <OriginalPriceIter>d__ = new ShopBankInfo.<OriginalPriceIter>d__33(-2);
			<OriginalPriceIter>d__.<>3__<>4__this = this;
			return <OriginalPriceIter>d__;
		}

		// Token: 0x0600D9A5 RID: 55717 RVA: 0x0032E348 File Offset: 0x0032C548
		[NullableContext(1)]
		public Dictionary<int, int> Price()
		{
			return this.PriceIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D9A6 RID: 55718 RVA: 0x0032E39E File Offset: 0x0032C59E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> PriceIter()
		{
			ShopBankInfo.<PriceIter>d__35 <PriceIter>d__ = new ShopBankInfo.<PriceIter>d__35(-2);
			<PriceIter>d__.<>3__<>4__this = this;
			return <PriceIter>d__;
		}

		// Token: 0x0600D9A7 RID: 55719 RVA: 0x0032E3B4 File Offset: 0x0032C5B4
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

		// Token: 0x0600D9A8 RID: 55720 RVA: 0x0032E3E8 File Offset: 0x0032C5E8
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

		// Token: 0x0600D9A9 RID: 55721 RVA: 0x0032E41C File Offset: 0x0032C61C
		private void EnsureOriginalPriceCacheIfNeeded()
		{
			if (this.OriginalPriceCache != null)
			{
				return;
			}
			this.OriginalPriceCache = this.OriginalPriceIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D9AA RID: 55722 RVA: 0x0032E484 File Offset: 0x0032C684
		private void EnsurePriceCacheIfNeeded()
		{
			if (this.PriceCache != null)
			{
				return;
			}
			this.PriceCache = this.PriceIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D9AB RID: 55723 RVA: 0x0032E4EA File Offset: 0x0032C6EA
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetOriginalPriceFrozenDict()
		{
			this.EnsureOriginalPriceCacheIfNeeded();
			return this.OriginalPriceCache;
		}

		// Token: 0x0600D9AC RID: 55724 RVA: 0x0032E4F8 File Offset: 0x0032C6F8
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetPriceFrozenDict()
		{
			this.EnsurePriceCacheIfNeeded();
			return this.PriceCache;
		}

		// Token: 0x040057B8 RID: 22456
		private Table __p;

		// Token: 0x040057B9 RID: 22457
		[Nullable(2)]
		private FrozenDictionary<int, int> OriginalPriceCache;

		// Token: 0x040057BA RID: 22458
		[Nullable(2)]
		private FrozenDictionary<int, int> PriceCache;
	}
}

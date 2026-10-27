using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D00 RID: 3328
	public struct GiftPackage : IFlatbufferObject
	{
		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x06007AC0 RID: 31424 RVA: 0x0024BC54 File Offset: 0x00249E54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007AC1 RID: 31425 RVA: 0x0024BC61 File Offset: 0x00249E61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007AC2 RID: 31426 RVA: 0x0024BC68 File Offset: 0x00249E68
		public static GiftPackage GetRootAsGiftPackage(ByteBuffer _bb)
		{
			return GiftPackage.GetRootAsGiftPackage(_bb, default(GiftPackage));
		}

		// Token: 0x06007AC3 RID: 31427 RVA: 0x0024BC84 File Offset: 0x00249E84
		public static GiftPackage GetRootAsGiftPackage(ByteBuffer _bb, GiftPackage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007AC4 RID: 31428 RVA: 0x0024BCA1 File Offset: 0x00249EA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007AC5 RID: 31429 RVA: 0x0024BCB0 File Offset: 0x00249EB0
		public GiftPackage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x06007AC6 RID: 31430 RVA: 0x0024BCC0 File Offset: 0x00249EC0
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

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x06007AC7 RID: 31431 RVA: 0x0024BCFC File Offset: 0x00249EFC
		public GiftType Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return GiftType.Fixed;
				}
				return (GiftType)this.__p.bb.GetSbyte(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007AC8 RID: 31432 RVA: 0x0024BD38 File Offset: 0x00249F38
		public DicIntInt? Content(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x06007AC9 RID: 31433 RVA: 0x0024BD98 File Offset: 0x00249F98
		public int ContentLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007ACA RID: 31434 RVA: 0x0024BDC4 File Offset: 0x00249FC4
		public DicIntInt? Weight(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x06007ACB RID: 31435 RVA: 0x0024BE28 File Offset: 0x0024A028
		public int WeightLength
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

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x06007ACC RID: 31436 RVA: 0x0024BE54 File Offset: 0x0024A054
		public int AvailableNum
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

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x06007ACD RID: 31437 RVA: 0x0024BE94 File Offset: 0x0024A094
		public int ShowType
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

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x06007ACE RID: 31438 RVA: 0x0024BED4 File Offset: 0x0024A0D4
		public int CheckGoodsMethod
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

		// Token: 0x06007ACF RID: 31439 RVA: 0x0024BF14 File Offset: 0x0024A114
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ContentFrozenDict()缓存字典，遍历请使用ContentIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Content()
		{
			return this.ContentIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06007AD0 RID: 31440 RVA: 0x0024BF6A File Offset: 0x0024A16A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ContentIter()
		{
			GiftPackage.<ContentIter>d__25 <ContentIter>d__ = new GiftPackage.<ContentIter>d__25(-2);
			<ContentIter>d__.<>3__<>4__this = this;
			return <ContentIter>d__;
		}

		// Token: 0x06007AD1 RID: 31441 RVA: 0x0024BF80 File Offset: 0x0024A180
		[NullableContext(1)]
		[Obsolete("已废弃，请使用WeightFrozenDict()缓存字典，遍历请使用WeightIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Weight()
		{
			return this.WeightIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06007AD2 RID: 31442 RVA: 0x0024BFD6 File Offset: 0x0024A1D6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> WeightIter()
		{
			GiftPackage.<WeightIter>d__27 <WeightIter>d__ = new GiftPackage.<WeightIter>d__27(-2);
			<WeightIter>d__.<>3__<>4__this = this;
			return <WeightIter>d__;
		}

		// Token: 0x06007AD3 RID: 31443 RVA: 0x0024BFEC File Offset: 0x0024A1EC
		public int? GetContent(int key)
		{
			this.EnsureContentCacheIfNeeded();
			int value;
			if (!this.ContentCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06007AD4 RID: 31444 RVA: 0x0024C020 File Offset: 0x0024A220
		public int? GetWeight(int key)
		{
			this.EnsureWeightCacheIfNeeded();
			int value;
			if (!this.WeightCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06007AD5 RID: 31445 RVA: 0x0024C054 File Offset: 0x0024A254
		private void EnsureContentCacheIfNeeded()
		{
			if (this.ContentCache != null)
			{
				return;
			}
			this.ContentCache = this.ContentIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007AD6 RID: 31446 RVA: 0x0024C0BC File Offset: 0x0024A2BC
		private void EnsureWeightCacheIfNeeded()
		{
			if (this.WeightCache != null)
			{
				return;
			}
			this.WeightCache = this.WeightIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007AD7 RID: 31447 RVA: 0x0024C122 File Offset: 0x0024A322
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetContentFrozenDict(int key)
		{
			this.EnsureContentCacheIfNeeded();
			return this.ContentCache;
		}

		// Token: 0x06007AD8 RID: 31448 RVA: 0x0024C130 File Offset: 0x0024A330
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetWeightFrozenDict(int key)
		{
			this.EnsureWeightCacheIfNeeded();
			return this.WeightCache;
		}

		// Token: 0x04004D74 RID: 19828
		private Table __p;

		// Token: 0x04004D75 RID: 19829
		[Nullable(2)]
		private FrozenDictionary<int, int> ContentCache;

		// Token: 0x04004D76 RID: 19830
		[Nullable(2)]
		private FrozenDictionary<int, int> WeightCache;
	}
}

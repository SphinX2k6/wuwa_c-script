using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C81 RID: 3201
	public struct FishingItem : IFlatbufferObject
	{
		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x06006F64 RID: 28516 RVA: 0x002313CD File Offset: 0x0022F5CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006F65 RID: 28517 RVA: 0x002313DA File Offset: 0x0022F5DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006F66 RID: 28518 RVA: 0x002313E4 File Offset: 0x0022F5E4
		public static FishingItem GetRootAsFishingItem(ByteBuffer _bb)
		{
			return FishingItem.GetRootAsFishingItem(_bb, default(FishingItem));
		}

		// Token: 0x06006F67 RID: 28519 RVA: 0x00231400 File Offset: 0x0022F600
		public static FishingItem GetRootAsFishingItem(ByteBuffer _bb, FishingItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006F68 RID: 28520 RVA: 0x0023141D File Offset: 0x0022F61D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006F69 RID: 28521 RVA: 0x0023142C File Offset: 0x0022F62C
		public FishingItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x06006F6A RID: 28522 RVA: 0x0023143C File Offset: 0x0022F63C
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

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x06006F6B RID: 28523 RVA: 0x00231478 File Offset: 0x0022F678
		public int Type
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

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x06006F6C RID: 28524 RVA: 0x002314B4 File Offset: 0x0022F6B4
		public int Category
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

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x06006F6D RID: 28525 RVA: 0x002314F0 File Offset: 0x0022F6F0
		public string Name
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

		// Token: 0x06006F6E RID: 28526 RVA: 0x00231528 File Offset: 0x0022F728
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006F6F RID: 28527 RVA: 0x00231538 File Offset: 0x0022F738
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x06006F70 RID: 28528 RVA: 0x00231550 File Offset: 0x0022F750
		public string Desc
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

		// Token: 0x06006F71 RID: 28529 RVA: 0x00231588 File Offset: 0x0022F788
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006F72 RID: 28530 RVA: 0x00231598 File Offset: 0x0022F798
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x06006F73 RID: 28531 RVA: 0x002315B0 File Offset: 0x0022F7B0
		public string Pic
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

		// Token: 0x06006F74 RID: 28532 RVA: 0x002315E8 File Offset: 0x0022F7E8
		public Span<byte> GetPicBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006F75 RID: 28533 RVA: 0x002315F8 File Offset: 0x0022F7F8
		public byte[] GetPicArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x06006F76 RID: 28534 RVA: 0x00231610 File Offset: 0x0022F810
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

		// Token: 0x06006F77 RID: 28535 RVA: 0x00231648 File Offset: 0x0022F848
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006F78 RID: 28536 RVA: 0x00231658 File Offset: 0x0022F858
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x06006F79 RID: 28537 RVA: 0x00231670 File Offset: 0x0022F870
		public int Shap
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

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x06006F7A RID: 28538 RVA: 0x002316B0 File Offset: 0x0022F8B0
		public int Quality
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006F7B RID: 28539 RVA: 0x002316F0 File Offset: 0x0022F8F0
		public int Tech(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x06006F7C RID: 28540 RVA: 0x00231730 File Offset: 0x0022F930
		public int TechLength
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

		// Token: 0x06006F7D RID: 28541 RVA: 0x0023175C File Offset: 0x0022F95C
		public Span<int> GetTechBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06006F7E RID: 28542 RVA: 0x0023176C File Offset: 0x0022F96C
		public int[] GetTechArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x06006F7F RID: 28543 RVA: 0x00231784 File Offset: 0x0022F984
		public int Price(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x06006F80 RID: 28544 RVA: 0x002317C4 File Offset: 0x0022F9C4
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

		// Token: 0x06006F81 RID: 28545 RVA: 0x002317F0 File Offset: 0x0022F9F0
		public Span<int> GetPriceBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06006F82 RID: 28546 RVA: 0x00231800 File Offset: 0x0022FA00
		public int[] GetPriceArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x06006F83 RID: 28547 RVA: 0x00231818 File Offset: 0x0022FA18
		public IntArray? SizeWeight(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x06006F84 RID: 28548 RVA: 0x0023187C File Offset: 0x0022FA7C
		public int SizeWeightLength
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

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x06006F85 RID: 28549 RVA: 0x002318A8 File Offset: 0x0022FAA8
		public int Relation
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x06006F86 RID: 28550 RVA: 0x002318E8 File Offset: 0x0022FAE8
		public int ChildRelation
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006F87 RID: 28551 RVA: 0x00231928 File Offset: 0x0022FB28
		public DicIntInt? ConvertItem(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x06006F88 RID: 28552 RVA: 0x0023198C File Offset: 0x0022FB8C
		public int ConvertItemLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x06006F89 RID: 28553 RVA: 0x002319B8 File Offset: 0x0022FBB8
		public bool CanDelete
		{
			get
			{
				int num = this.__p.__offset(34);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x06006F8A RID: 28554 RVA: 0x002319F8 File Offset: 0x0022FBF8
		public int DetectionUnlockCondition
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006F8B RID: 28555 RVA: 0x00231A38 File Offset: 0x0022FC38
		public int Area(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x06006F8C RID: 28556 RVA: 0x00231A78 File Offset: 0x0022FC78
		public int AreaLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006F8D RID: 28557 RVA: 0x00231AA4 File Offset: 0x0022FCA4
		public Span<int> GetAreaBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x06006F8E RID: 28558 RVA: 0x00231AB4 File Offset: 0x0022FCB4
		public int[] GetAreaArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x06006F8F RID: 28559 RVA: 0x00231ACC File Offset: 0x0022FCCC
		public int Time
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x06006F90 RID: 28560 RVA: 0x00231B0C File Offset: 0x0022FD0C
		public string Color
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006F91 RID: 28561 RVA: 0x00231B44 File Offset: 0x0022FD44
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06006F92 RID: 28562 RVA: 0x00231B54 File Offset: 0x0022FD54
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x06006F93 RID: 28563 RVA: 0x00231B6C File Offset: 0x0022FD6C
		public string Sprite
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006F94 RID: 28564 RVA: 0x00231BA4 File Offset: 0x0022FDA4
		public Span<byte> GetSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06006F95 RID: 28565 RVA: 0x00231BB4 File Offset: 0x0022FDB4
		public byte[] GetSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x06006F96 RID: 28566 RVA: 0x00231BCC File Offset: 0x0022FDCC
		public int IllustratedNum
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x06006F97 RID: 28567 RVA: 0x00231C0C File Offset: 0x0022FE0C
		public int Reputation
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006F98 RID: 28568 RVA: 0x00231C4C File Offset: 0x0022FE4C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AreaIter()或GetAreaBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Area()
		{
			FishingItem fishingItem = this;
			return fishingItem.GetAreaArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006F99 RID: 28569 RVA: 0x00231C70 File Offset: 0x0022FE70
		[NullableContext(1)]
		public readonly IEnumerable<int> AreaIter()
		{
			FishingItem.<AreaIter>d__78 <AreaIter>d__ = new FishingItem.<AreaIter>d__78(-2);
			<AreaIter>d__.<>3__<>4__this = this;
			return <AreaIter>d__;
		}

		// Token: 0x06006F9A RID: 28570 RVA: 0x00231C88 File Offset: 0x0022FE88
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ConvertItemFrozenDict()缓存字典，遍历请使用ConvertItemIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ConvertItem()
		{
			return this.ConvertItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006F9B RID: 28571 RVA: 0x00231CDE File Offset: 0x0022FEDE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ConvertItemIter()
		{
			FishingItem.<ConvertItemIter>d__80 <ConvertItemIter>d__ = new FishingItem.<ConvertItemIter>d__80(-2);
			<ConvertItemIter>d__.<>3__<>4__this = this;
			return <ConvertItemIter>d__;
		}

		// Token: 0x06006F9C RID: 28572 RVA: 0x00231CF4 File Offset: 0x0022FEF4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PriceIter()或GetPriceBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Price()
		{
			FishingItem fishingItem = this;
			return fishingItem.GetPriceArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006F9D RID: 28573 RVA: 0x00231D18 File Offset: 0x0022FF18
		[NullableContext(1)]
		public readonly IEnumerable<int> PriceIter()
		{
			FishingItem.<PriceIter>d__82 <PriceIter>d__ = new FishingItem.<PriceIter>d__82(-2);
			<PriceIter>d__.<>3__<>4__this = this;
			return <PriceIter>d__;
		}

		// Token: 0x06006F9E RID: 28574 RVA: 0x00231D2D File Offset: 0x0022FF2D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SizeWeightIter()或GetSizeWeightBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] SizeWeight()
		{
			return this.SizeWeightIter().ToArray<IntArray>();
		}

		// Token: 0x06006F9F RID: 28575 RVA: 0x00231D3A File Offset: 0x0022FF3A
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> SizeWeightIter()
		{
			FishingItem.<SizeWeightIter>d__84 <SizeWeightIter>d__ = new FishingItem.<SizeWeightIter>d__84(-2);
			<SizeWeightIter>d__.<>3__<>4__this = this;
			return <SizeWeightIter>d__;
		}

		// Token: 0x06006FA0 RID: 28576 RVA: 0x00231D50 File Offset: 0x0022FF50
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TechIter()或GetTechBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Tech()
		{
			FishingItem fishingItem = this;
			return fishingItem.GetTechArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006FA1 RID: 28577 RVA: 0x00231D74 File Offset: 0x0022FF74
		[NullableContext(1)]
		public readonly IEnumerable<int> TechIter()
		{
			FishingItem.<TechIter>d__86 <TechIter>d__ = new FishingItem.<TechIter>d__86(-2);
			<TechIter>d__.<>3__<>4__this = this;
			return <TechIter>d__;
		}

		// Token: 0x06006FA2 RID: 28578 RVA: 0x00231D8C File Offset: 0x0022FF8C
		public int? GetConvertItem(int key)
		{
			this.EnsureConvertItemCacheIfNeeded();
			int value;
			if (!this.ConvertItemCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06006FA3 RID: 28579 RVA: 0x00231DC0 File Offset: 0x0022FFC0
		private void EnsureConvertItemCacheIfNeeded()
		{
			if (this.ConvertItemCache != null)
			{
				return;
			}
			this.ConvertItemCache = this.ConvertItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006FA4 RID: 28580 RVA: 0x00231E26 File Offset: 0x00230026
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetConvertItemFrozenDict(int key)
		{
			this.EnsureConvertItemCacheIfNeeded();
			return this.ConvertItemCache;
		}

		// Token: 0x04004CD0 RID: 19664
		private Table __p;

		// Token: 0x04004CD1 RID: 19665
		[Nullable(2)]
		private FrozenDictionary<int, int> ConvertItemCache;
	}
}

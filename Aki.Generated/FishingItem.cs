using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D65 RID: 3429
	public struct FishingItem : IFlatbufferObject
	{
		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x0600756F RID: 30063 RVA: 0x00250599 File Offset: 0x0024E799
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007570 RID: 30064 RVA: 0x002505A6 File Offset: 0x0024E7A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007571 RID: 30065 RVA: 0x002505B0 File Offset: 0x0024E7B0
		public static FishingItem GetRootAsFishingItem(ByteBuffer _bb)
		{
			return FishingItem.GetRootAsFishingItem(_bb, default(FishingItem));
		}

		// Token: 0x06007572 RID: 30066 RVA: 0x002505CC File Offset: 0x0024E7CC
		public static FishingItem GetRootAsFishingItem(ByteBuffer _bb, FishingItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007573 RID: 30067 RVA: 0x002505E9 File Offset: 0x0024E7E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007574 RID: 30068 RVA: 0x002505F8 File Offset: 0x0024E7F8
		public FishingItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x06007575 RID: 30069 RVA: 0x00250608 File Offset: 0x0024E808
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

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x06007576 RID: 30070 RVA: 0x00250644 File Offset: 0x0024E844
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

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x06007577 RID: 30071 RVA: 0x00250680 File Offset: 0x0024E880
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

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06007578 RID: 30072 RVA: 0x002506BC File Offset: 0x0024E8BC
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

		// Token: 0x06007579 RID: 30073 RVA: 0x002506F4 File Offset: 0x0024E8F4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600757A RID: 30074 RVA: 0x00250704 File Offset: 0x0024E904
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x0600757B RID: 30075 RVA: 0x0025071C File Offset: 0x0024E91C
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

		// Token: 0x0600757C RID: 30076 RVA: 0x00250754 File Offset: 0x0024E954
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600757D RID: 30077 RVA: 0x00250764 File Offset: 0x0024E964
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x0600757E RID: 30078 RVA: 0x0025077C File Offset: 0x0024E97C
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

		// Token: 0x0600757F RID: 30079 RVA: 0x002507B4 File Offset: 0x0024E9B4
		public Span<byte> GetPicBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007580 RID: 30080 RVA: 0x002507C4 File Offset: 0x0024E9C4
		public byte[] GetPicArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x06007581 RID: 30081 RVA: 0x002507DC File Offset: 0x0024E9DC
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

		// Token: 0x06007582 RID: 30082 RVA: 0x00250814 File Offset: 0x0024EA14
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007583 RID: 30083 RVA: 0x00250824 File Offset: 0x0024EA24
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x06007584 RID: 30084 RVA: 0x0025083C File Offset: 0x0024EA3C
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

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x06007585 RID: 30085 RVA: 0x0025087C File Offset: 0x0024EA7C
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

		// Token: 0x06007586 RID: 30086 RVA: 0x002508BC File Offset: 0x0024EABC
		public int Tech(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x06007587 RID: 30087 RVA: 0x002508FC File Offset: 0x0024EAFC
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

		// Token: 0x06007588 RID: 30088 RVA: 0x00250928 File Offset: 0x0024EB28
		public Span<int> GetTechBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06007589 RID: 30089 RVA: 0x00250938 File Offset: 0x0024EB38
		public int[] GetTechArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600758A RID: 30090 RVA: 0x00250950 File Offset: 0x0024EB50
		public int Price(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x0600758B RID: 30091 RVA: 0x00250990 File Offset: 0x0024EB90
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

		// Token: 0x0600758C RID: 30092 RVA: 0x002509BC File Offset: 0x0024EBBC
		public Span<int> GetPriceBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600758D RID: 30093 RVA: 0x002509CC File Offset: 0x0024EBCC
		public int[] GetPriceArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x0600758E RID: 30094 RVA: 0x002509E4 File Offset: 0x0024EBE4
		public IntArray? SizeWeight(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x0600758F RID: 30095 RVA: 0x00250A48 File Offset: 0x0024EC48
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

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x06007590 RID: 30096 RVA: 0x00250A74 File Offset: 0x0024EC74
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

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x06007591 RID: 30097 RVA: 0x00250AB4 File Offset: 0x0024ECB4
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

		// Token: 0x06007592 RID: 30098 RVA: 0x00250AF4 File Offset: 0x0024ECF4
		public DicIntInt? ConvertItem(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x06007593 RID: 30099 RVA: 0x00250B58 File Offset: 0x0024ED58
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

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x06007594 RID: 30100 RVA: 0x00250B84 File Offset: 0x0024ED84
		public bool CanDelete
		{
			get
			{
				int num = this.__p.__offset(34);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x06007595 RID: 30101 RVA: 0x00250BC4 File Offset: 0x0024EDC4
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

		// Token: 0x06007596 RID: 30102 RVA: 0x00250C04 File Offset: 0x0024EE04
		public int Area(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x06007597 RID: 30103 RVA: 0x00250C44 File Offset: 0x0024EE44
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

		// Token: 0x06007598 RID: 30104 RVA: 0x00250C70 File Offset: 0x0024EE70
		public Span<int> GetAreaBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x06007599 RID: 30105 RVA: 0x00250C80 File Offset: 0x0024EE80
		public int[] GetAreaArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x0600759A RID: 30106 RVA: 0x00250C98 File Offset: 0x0024EE98
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

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x0600759B RID: 30107 RVA: 0x00250CD8 File Offset: 0x0024EED8
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

		// Token: 0x0600759C RID: 30108 RVA: 0x00250D10 File Offset: 0x0024EF10
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600759D RID: 30109 RVA: 0x00250D20 File Offset: 0x0024EF20
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x0600759E RID: 30110 RVA: 0x00250D38 File Offset: 0x0024EF38
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

		// Token: 0x0600759F RID: 30111 RVA: 0x00250D70 File Offset: 0x0024EF70
		public Span<byte> GetSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x060075A0 RID: 30112 RVA: 0x00250D80 File Offset: 0x0024EF80
		public byte[] GetSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x060075A1 RID: 30113 RVA: 0x00250D98 File Offset: 0x0024EF98
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

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x060075A2 RID: 30114 RVA: 0x00250DD8 File Offset: 0x0024EFD8
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

		// Token: 0x060075A3 RID: 30115 RVA: 0x00250E15 File Offset: 0x0024F015
		[NullableContext(1)]
		public int[] Area()
		{
			return this.GetAreaArray();
		}

		// Token: 0x060075A4 RID: 30116 RVA: 0x00250E1D File Offset: 0x0024F01D
		[NullableContext(1)]
		public IEnumerable<int> AreaIter()
		{
			FishingItem.<AreaIter>d__78 <AreaIter>d__ = new FishingItem.<AreaIter>d__78(-2);
			<AreaIter>d__.<>3__<>4__this = this;
			return <AreaIter>d__;
		}

		// Token: 0x060075A5 RID: 30117 RVA: 0x00250E34 File Offset: 0x0024F034
		[NullableContext(1)]
		public Dictionary<int, int> ConvertItem()
		{
			return this.ConvertItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060075A6 RID: 30118 RVA: 0x00250E8A File Offset: 0x0024F08A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ConvertItemIter()
		{
			FishingItem.<ConvertItemIter>d__80 <ConvertItemIter>d__ = new FishingItem.<ConvertItemIter>d__80(-2);
			<ConvertItemIter>d__.<>3__<>4__this = this;
			return <ConvertItemIter>d__;
		}

		// Token: 0x060075A7 RID: 30119 RVA: 0x00250E9F File Offset: 0x0024F09F
		[NullableContext(1)]
		public int[] Price()
		{
			return this.GetPriceArray();
		}

		// Token: 0x060075A8 RID: 30120 RVA: 0x00250EA7 File Offset: 0x0024F0A7
		[NullableContext(1)]
		public IEnumerable<int> PriceIter()
		{
			FishingItem.<PriceIter>d__82 <PriceIter>d__ = new FishingItem.<PriceIter>d__82(-2);
			<PriceIter>d__.<>3__<>4__this = this;
			return <PriceIter>d__;
		}

		// Token: 0x060075A9 RID: 30121 RVA: 0x00250EBC File Offset: 0x0024F0BC
		[NullableContext(1)]
		public IntArray[] SizeWeight()
		{
			return this.SizeWeightIter().ToArray<IntArray>();
		}

		// Token: 0x060075AA RID: 30122 RVA: 0x00250EC9 File Offset: 0x0024F0C9
		[NullableContext(1)]
		public IEnumerable<IntArray> SizeWeightIter()
		{
			FishingItem.<SizeWeightIter>d__84 <SizeWeightIter>d__ = new FishingItem.<SizeWeightIter>d__84(-2);
			<SizeWeightIter>d__.<>3__<>4__this = this;
			return <SizeWeightIter>d__;
		}

		// Token: 0x060075AB RID: 30123 RVA: 0x00250EDE File Offset: 0x0024F0DE
		[NullableContext(1)]
		public int[] Tech()
		{
			return this.GetTechArray();
		}

		// Token: 0x060075AC RID: 30124 RVA: 0x00250EE6 File Offset: 0x0024F0E6
		[NullableContext(1)]
		public IEnumerable<int> TechIter()
		{
			FishingItem.<TechIter>d__86 <TechIter>d__ = new FishingItem.<TechIter>d__86(-2);
			<TechIter>d__.<>3__<>4__this = this;
			return <TechIter>d__;
		}

		// Token: 0x060075AD RID: 30125 RVA: 0x00250EFC File Offset: 0x0024F0FC
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

		// Token: 0x060075AE RID: 30126 RVA: 0x00250F30 File Offset: 0x0024F130
		private void EnsureConvertItemCacheIfNeeded()
		{
			if (this.ConvertItemCache != null)
			{
				return;
			}
			this.ConvertItemCache = this.ConvertItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060075AF RID: 30127 RVA: 0x00250F96 File Offset: 0x0024F196
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetConvertItemFrozenDict()
		{
			this.EnsureConvertItemCacheIfNeeded();
			return this.ConvertItemCache;
		}

		// Token: 0x040052B4 RID: 21172
		private Table __p;

		// Token: 0x040052B5 RID: 21173
		[Nullable(2)]
		private FrozenDictionary<int, int> ConvertItemCache;
	}
}

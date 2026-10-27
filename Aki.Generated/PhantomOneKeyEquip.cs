using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EF3 RID: 3827
	public struct PhantomOneKeyEquip : IFlatbufferObject
	{
		// Token: 0x17002730 RID: 10032
		// (get) Token: 0x0600A9C1 RID: 43457 RVA: 0x002B5C85 File Offset: 0x002B3E85
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A9C2 RID: 43458 RVA: 0x002B5C92 File Offset: 0x002B3E92
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A9C3 RID: 43459 RVA: 0x002B5C9C File Offset: 0x002B3E9C
		public static PhantomOneKeyEquip GetRootAsPhantomOneKeyEquip(ByteBuffer _bb)
		{
			return PhantomOneKeyEquip.GetRootAsPhantomOneKeyEquip(_bb, default(PhantomOneKeyEquip));
		}

		// Token: 0x0600A9C4 RID: 43460 RVA: 0x002B5CB8 File Offset: 0x002B3EB8
		public static PhantomOneKeyEquip GetRootAsPhantomOneKeyEquip(ByteBuffer _bb, PhantomOneKeyEquip obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A9C5 RID: 43461 RVA: 0x002B5CD5 File Offset: 0x002B3ED5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A9C6 RID: 43462 RVA: 0x002B5CE4 File Offset: 0x002B3EE4
		public PhantomOneKeyEquip __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002731 RID: 10033
		// (get) Token: 0x0600A9C7 RID: 43463 RVA: 0x002B5CF4 File Offset: 0x002B3EF4
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

		// Token: 0x0600A9C8 RID: 43464 RVA: 0x002B5D30 File Offset: 0x002B3F30
		public int LevelRange(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002732 RID: 10034
		// (get) Token: 0x0600A9C9 RID: 43465 RVA: 0x002B5D70 File Offset: 0x002B3F70
		public int LevelRangeLength
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

		// Token: 0x0600A9CA RID: 43466 RVA: 0x002B5D9B File Offset: 0x002B3F9B
		public Span<int> GetLevelRangeBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600A9CB RID: 43467 RVA: 0x002B5DAA File Offset: 0x002B3FAA
		public int[] GetLevelRangeArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17002733 RID: 10035
		// (get) Token: 0x0600A9CC RID: 43468 RVA: 0x002B5DC4 File Offset: 0x002B3FC4
		public int FirstVisionCost
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

		// Token: 0x17002734 RID: 10036
		// (get) Token: 0x0600A9CD RID: 43469 RVA: 0x002B5E00 File Offset: 0x002B4000
		public bool FirstVisionSpecial
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600A9CE RID: 43470 RVA: 0x002B5E40 File Offset: 0x002B4040
		public DicIntInt? SpecialPlan(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002735 RID: 10037
		// (get) Token: 0x0600A9CF RID: 43471 RVA: 0x002B5EA4 File Offset: 0x002B40A4
		public int SpecialPlanLength
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

		// Token: 0x0600A9D0 RID: 43472 RVA: 0x002B5ED0 File Offset: 0x002B40D0
		public DicIntInt? NormalPlan(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002736 RID: 10038
		// (get) Token: 0x0600A9D1 RID: 43473 RVA: 0x002B5F34 File Offset: 0x002B4134
		public int NormalPlanLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A9D2 RID: 43474 RVA: 0x002B5F60 File Offset: 0x002B4160
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LevelRangeIter()或GetLevelRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LevelRange()
		{
			PhantomOneKeyEquip phantomOneKeyEquip = this;
			return phantomOneKeyEquip.GetLevelRangeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A9D3 RID: 43475 RVA: 0x002B5F84 File Offset: 0x002B4184
		[NullableContext(1)]
		public readonly IEnumerable<int> LevelRangeIter()
		{
			PhantomOneKeyEquip.<LevelRangeIter>d__26 <LevelRangeIter>d__ = new PhantomOneKeyEquip.<LevelRangeIter>d__26(-2);
			<LevelRangeIter>d__.<>3__<>4__this = this;
			return <LevelRangeIter>d__;
		}

		// Token: 0x0600A9D4 RID: 43476 RVA: 0x002B5F9C File Offset: 0x002B419C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用NormalPlanFrozenDict()缓存字典，遍历请使用NormalPlanIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> NormalPlan()
		{
			return this.NormalPlanIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600A9D5 RID: 43477 RVA: 0x002B5FF2 File Offset: 0x002B41F2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> NormalPlanIter()
		{
			PhantomOneKeyEquip.<NormalPlanIter>d__28 <NormalPlanIter>d__ = new PhantomOneKeyEquip.<NormalPlanIter>d__28(-2);
			<NormalPlanIter>d__.<>3__<>4__this = this;
			return <NormalPlanIter>d__;
		}

		// Token: 0x0600A9D6 RID: 43478 RVA: 0x002B6008 File Offset: 0x002B4208
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SpecialPlanFrozenDict()缓存字典，遍历请使用SpecialPlanIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> SpecialPlan()
		{
			return this.SpecialPlanIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600A9D7 RID: 43479 RVA: 0x002B605E File Offset: 0x002B425E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> SpecialPlanIter()
		{
			PhantomOneKeyEquip.<SpecialPlanIter>d__30 <SpecialPlanIter>d__ = new PhantomOneKeyEquip.<SpecialPlanIter>d__30(-2);
			<SpecialPlanIter>d__.<>3__<>4__this = this;
			return <SpecialPlanIter>d__;
		}

		// Token: 0x0600A9D8 RID: 43480 RVA: 0x002B6074 File Offset: 0x002B4274
		public int? GetNormalPlan(int key)
		{
			this.EnsureNormalPlanCacheIfNeeded();
			int value;
			if (!this.NormalPlanCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600A9D9 RID: 43481 RVA: 0x002B60A8 File Offset: 0x002B42A8
		public int? GetSpecialPlan(int key)
		{
			this.EnsureSpecialPlanCacheIfNeeded();
			int value;
			if (!this.SpecialPlanCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600A9DA RID: 43482 RVA: 0x002B60DC File Offset: 0x002B42DC
		private void EnsureNormalPlanCacheIfNeeded()
		{
			if (this.NormalPlanCache != null)
			{
				return;
			}
			this.NormalPlanCache = this.NormalPlanIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600A9DB RID: 43483 RVA: 0x002B6144 File Offset: 0x002B4344
		private void EnsureSpecialPlanCacheIfNeeded()
		{
			if (this.SpecialPlanCache != null)
			{
				return;
			}
			this.SpecialPlanCache = this.SpecialPlanIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600A9DC RID: 43484 RVA: 0x002B61AA File Offset: 0x002B43AA
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetNormalPlanFrozenDict(int key)
		{
			this.EnsureNormalPlanCacheIfNeeded();
			return this.NormalPlanCache;
		}

		// Token: 0x0600A9DD RID: 43485 RVA: 0x002B61B8 File Offset: 0x002B43B8
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetSpecialPlanFrozenDict(int key)
		{
			this.EnsureSpecialPlanCacheIfNeeded();
			return this.SpecialPlanCache;
		}

		// Token: 0x04004FB6 RID: 20406
		private Table __p;

		// Token: 0x04004FB7 RID: 20407
		[Nullable(2)]
		private FrozenDictionary<int, int> NormalPlanCache;

		// Token: 0x04004FB8 RID: 20408
		[Nullable(2)]
		private FrozenDictionary<int, int> SpecialPlanCache;
	}
}

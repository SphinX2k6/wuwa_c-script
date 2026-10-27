using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BFF RID: 3071
	public struct DrinksBatching : IFlatbufferObject
	{
		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06006385 RID: 25477 RVA: 0x00216329 File Offset: 0x00214529
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006386 RID: 25478 RVA: 0x00216336 File Offset: 0x00214536
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006387 RID: 25479 RVA: 0x00216340 File Offset: 0x00214540
		public static DrinksBatching GetRootAsDrinksBatching(ByteBuffer _bb)
		{
			return DrinksBatching.GetRootAsDrinksBatching(_bb, default(DrinksBatching));
		}

		// Token: 0x06006388 RID: 25480 RVA: 0x0021635C File Offset: 0x0021455C
		public static DrinksBatching GetRootAsDrinksBatching(ByteBuffer _bb, DrinksBatching obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006389 RID: 25481 RVA: 0x00216379 File Offset: 0x00214579
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600638A RID: 25482 RVA: 0x00216388 File Offset: 0x00214588
		public DrinksBatching __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x0600638B RID: 25483 RVA: 0x00216398 File Offset: 0x00214598
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

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x0600638C RID: 25484 RVA: 0x002163D4 File Offset: 0x002145D4
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600638D RID: 25485 RVA: 0x0021640B File Offset: 0x0021460B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600638E RID: 25486 RVA: 0x0021641A File Offset: 0x0021461A
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x0600638F RID: 25487 RVA: 0x00216434 File Offset: 0x00214634
		public string Name
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006390 RID: 25488 RVA: 0x0021646B File Offset: 0x0021466B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006391 RID: 25489 RVA: 0x0021647A File Offset: 0x0021467A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06006392 RID: 25490 RVA: 0x00216494 File Offset: 0x00214694
		public DicIntInt? Flavor(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06006393 RID: 25491 RVA: 0x002164F8 File Offset: 0x002146F8
		public int FlavorLength
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

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06006394 RID: 25492 RVA: 0x00216524 File Offset: 0x00214724
		public int MeshTagId
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

		// Token: 0x06006395 RID: 25493 RVA: 0x00216564 File Offset: 0x00214764
		public DicIntInt? ScaleMap(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x06006396 RID: 25494 RVA: 0x002165C8 File Offset: 0x002147C8
		public int ScaleMapLength
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

		// Token: 0x06006397 RID: 25495 RVA: 0x002165F4 File Offset: 0x002147F4
		public DicIntInt? HeighScaleMap(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x06006398 RID: 25496 RVA: 0x00216658 File Offset: 0x00214858
		public int HeighScaleMapLength
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

		// Token: 0x06006399 RID: 25497 RVA: 0x00216684 File Offset: 0x00214884
		public DicIntInt? PosScaleMap(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x0600639A RID: 25498 RVA: 0x002166E8 File Offset: 0x002148E8
		public int PosScaleMapLength
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

		// Token: 0x0600639B RID: 25499 RVA: 0x00216714 File Offset: 0x00214914
		public DicIntIntArray? PosOnLiquid1(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x0600639C RID: 25500 RVA: 0x00216778 File Offset: 0x00214978
		public int PosOnLiquid1Length
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600639D RID: 25501 RVA: 0x002167A4 File Offset: 0x002149A4
		public DicIntIntArray? PosOnLiquid2(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x0600639E RID: 25502 RVA: 0x00216808 File Offset: 0x00214A08
		public int PosOnLiquid2Length
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

		// Token: 0x0600639F RID: 25503 RVA: 0x00216834 File Offset: 0x00214A34
		[NullableContext(1)]
		[Obsolete("已废弃，请使用FlavorFrozenDict()缓存字典，遍历请使用FlavorIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Flavor()
		{
			return this.FlavorIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060063A0 RID: 25504 RVA: 0x0021688A File Offset: 0x00214A8A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> FlavorIter()
		{
			DrinksBatching.<FlavorIter>d__39 <FlavorIter>d__ = new DrinksBatching.<FlavorIter>d__39(-2);
			<FlavorIter>d__.<>3__<>4__this = this;
			return <FlavorIter>d__;
		}

		// Token: 0x060063A1 RID: 25505 RVA: 0x002168A0 File Offset: 0x00214AA0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用HeighScaleMapFrozenDict()缓存字典，遍历请使用HeighScaleMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> HeighScaleMap()
		{
			return this.HeighScaleMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060063A2 RID: 25506 RVA: 0x002168F6 File Offset: 0x00214AF6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> HeighScaleMapIter()
		{
			DrinksBatching.<HeighScaleMapIter>d__41 <HeighScaleMapIter>d__ = new DrinksBatching.<HeighScaleMapIter>d__41(-2);
			<HeighScaleMapIter>d__.<>3__<>4__this = this;
			return <HeighScaleMapIter>d__;
		}

		// Token: 0x060063A3 RID: 25507 RVA: 0x0021690C File Offset: 0x00214B0C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用PosOnLiquid1FrozenDict()缓存字典，遍历请使用PosOnLiquid1Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> PosOnLiquid1()
		{
			return this.PosOnLiquid1Iter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x060063A4 RID: 25508 RVA: 0x00216962 File Offset: 0x00214B62
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> PosOnLiquid1Iter()
		{
			DrinksBatching.<PosOnLiquid1Iter>d__43 <PosOnLiquid1Iter>d__ = new DrinksBatching.<PosOnLiquid1Iter>d__43(-2);
			<PosOnLiquid1Iter>d__.<>3__<>4__this = this;
			return <PosOnLiquid1Iter>d__;
		}

		// Token: 0x060063A5 RID: 25509 RVA: 0x00216978 File Offset: 0x00214B78
		[NullableContext(1)]
		[Obsolete("已废弃，请使用PosOnLiquid2FrozenDict()缓存字典，遍历请使用PosOnLiquid2Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> PosOnLiquid2()
		{
			return this.PosOnLiquid2Iter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x060063A6 RID: 25510 RVA: 0x002169CE File Offset: 0x00214BCE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> PosOnLiquid2Iter()
		{
			DrinksBatching.<PosOnLiquid2Iter>d__45 <PosOnLiquid2Iter>d__ = new DrinksBatching.<PosOnLiquid2Iter>d__45(-2);
			<PosOnLiquid2Iter>d__.<>3__<>4__this = this;
			return <PosOnLiquid2Iter>d__;
		}

		// Token: 0x060063A7 RID: 25511 RVA: 0x002169E4 File Offset: 0x00214BE4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用PosScaleMapFrozenDict()缓存字典，遍历请使用PosScaleMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> PosScaleMap()
		{
			return this.PosScaleMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060063A8 RID: 25512 RVA: 0x00216A3A File Offset: 0x00214C3A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> PosScaleMapIter()
		{
			DrinksBatching.<PosScaleMapIter>d__47 <PosScaleMapIter>d__ = new DrinksBatching.<PosScaleMapIter>d__47(-2);
			<PosScaleMapIter>d__.<>3__<>4__this = this;
			return <PosScaleMapIter>d__;
		}

		// Token: 0x060063A9 RID: 25513 RVA: 0x00216A50 File Offset: 0x00214C50
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ScaleMapFrozenDict()缓存字典，遍历请使用ScaleMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ScaleMap()
		{
			return this.ScaleMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060063AA RID: 25514 RVA: 0x00216AA6 File Offset: 0x00214CA6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ScaleMapIter()
		{
			DrinksBatching.<ScaleMapIter>d__49 <ScaleMapIter>d__ = new DrinksBatching.<ScaleMapIter>d__49(-2);
			<ScaleMapIter>d__.<>3__<>4__this = this;
			return <ScaleMapIter>d__;
		}

		// Token: 0x060063AB RID: 25515 RVA: 0x00216ABC File Offset: 0x00214CBC
		public int? GetFlavor(int key)
		{
			this.EnsureFlavorCacheIfNeeded();
			int value;
			if (!this.FlavorCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060063AC RID: 25516 RVA: 0x00216AF0 File Offset: 0x00214CF0
		public int? GetHeighScaleMap(int key)
		{
			this.EnsureHeighScaleMapCacheIfNeeded();
			int value;
			if (!this.HeighScaleMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060063AD RID: 25517 RVA: 0x00216B24 File Offset: 0x00214D24
		public IntArray? GetPosOnLiquid1(int key)
		{
			this.EnsurePosOnLiquid1CacheIfNeeded();
			IntArray value;
			if (!this.PosOnLiquid1Cache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x060063AE RID: 25518 RVA: 0x00216B58 File Offset: 0x00214D58
		public IntArray? GetPosOnLiquid2(int key)
		{
			this.EnsurePosOnLiquid2CacheIfNeeded();
			IntArray value;
			if (!this.PosOnLiquid2Cache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x060063AF RID: 25519 RVA: 0x00216B8C File Offset: 0x00214D8C
		public int? GetPosScaleMap(int key)
		{
			this.EnsurePosScaleMapCacheIfNeeded();
			int value;
			if (!this.PosScaleMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060063B0 RID: 25520 RVA: 0x00216BC0 File Offset: 0x00214DC0
		public int? GetScaleMap(int key)
		{
			this.EnsureScaleMapCacheIfNeeded();
			int value;
			if (!this.ScaleMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060063B1 RID: 25521 RVA: 0x00216BF4 File Offset: 0x00214DF4
		private void EnsureFlavorCacheIfNeeded()
		{
			if (this.FlavorCache != null)
			{
				return;
			}
			this.FlavorCache = this.FlavorIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060063B2 RID: 25522 RVA: 0x00216C5C File Offset: 0x00214E5C
		private void EnsureHeighScaleMapCacheIfNeeded()
		{
			if (this.HeighScaleMapCache != null)
			{
				return;
			}
			this.HeighScaleMapCache = this.HeighScaleMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060063B3 RID: 25523 RVA: 0x00216CC4 File Offset: 0x00214EC4
		private void EnsurePosOnLiquid1CacheIfNeeded()
		{
			if (this.PosOnLiquid1Cache != null)
			{
				return;
			}
			this.PosOnLiquid1Cache = this.PosOnLiquid1Iter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x060063B4 RID: 25524 RVA: 0x00216D2C File Offset: 0x00214F2C
		private void EnsurePosOnLiquid2CacheIfNeeded()
		{
			if (this.PosOnLiquid2Cache != null)
			{
				return;
			}
			this.PosOnLiquid2Cache = this.PosOnLiquid2Iter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x060063B5 RID: 25525 RVA: 0x00216D94 File Offset: 0x00214F94
		private void EnsurePosScaleMapCacheIfNeeded()
		{
			if (this.PosScaleMapCache != null)
			{
				return;
			}
			this.PosScaleMapCache = this.PosScaleMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060063B6 RID: 25526 RVA: 0x00216DFC File Offset: 0x00214FFC
		private void EnsureScaleMapCacheIfNeeded()
		{
			if (this.ScaleMapCache != null)
			{
				return;
			}
			this.ScaleMapCache = this.ScaleMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060063B7 RID: 25527 RVA: 0x00216E62 File Offset: 0x00215062
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetFlavorFrozenDict(int key)
		{
			this.EnsureFlavorCacheIfNeeded();
			return this.FlavorCache;
		}

		// Token: 0x060063B8 RID: 25528 RVA: 0x00216E70 File Offset: 0x00215070
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetHeighScaleMapFrozenDict(int key)
		{
			this.EnsureHeighScaleMapCacheIfNeeded();
			return this.HeighScaleMapCache;
		}

		// Token: 0x060063B9 RID: 25529 RVA: 0x00216E7E File Offset: 0x0021507E
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetPosOnLiquid1FrozenDict(int key)
		{
			this.EnsurePosOnLiquid1CacheIfNeeded();
			return this.PosOnLiquid1Cache;
		}

		// Token: 0x060063BA RID: 25530 RVA: 0x00216E8C File Offset: 0x0021508C
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetPosOnLiquid2FrozenDict(int key)
		{
			this.EnsurePosOnLiquid2CacheIfNeeded();
			return this.PosOnLiquid2Cache;
		}

		// Token: 0x060063BB RID: 25531 RVA: 0x00216E9A File Offset: 0x0021509A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetPosScaleMapFrozenDict(int key)
		{
			this.EnsurePosScaleMapCacheIfNeeded();
			return this.PosScaleMapCache;
		}

		// Token: 0x060063BC RID: 25532 RVA: 0x00216EA8 File Offset: 0x002150A8
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetScaleMapFrozenDict(int key)
		{
			this.EnsureScaleMapCacheIfNeeded();
			return this.ScaleMapCache;
		}

		// Token: 0x04004C2E RID: 19502
		private Table __p;

		// Token: 0x04004C2F RID: 19503
		[Nullable(2)]
		private FrozenDictionary<int, int> FlavorCache;

		// Token: 0x04004C30 RID: 19504
		[Nullable(2)]
		private FrozenDictionary<int, int> HeighScaleMapCache;

		// Token: 0x04004C31 RID: 19505
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> PosOnLiquid1Cache;

		// Token: 0x04004C32 RID: 19506
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> PosOnLiquid2Cache;

		// Token: 0x04004C33 RID: 19507
		[Nullable(2)]
		private FrozenDictionary<int, int> PosScaleMapCache;

		// Token: 0x04004C34 RID: 19508
		[Nullable(2)]
		private FrozenDictionary<int, int> ScaleMapCache;
	}
}

using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CE1 RID: 3297
	[NullableContext(1)]
	[Nullable(0)]
	public struct DrinksBatching : IFlatbufferObject
	{
		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x06006964 RID: 26980 RVA: 0x00235989 File Offset: 0x00233B89
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006965 RID: 26981 RVA: 0x00235996 File Offset: 0x00233B96
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006966 RID: 26982 RVA: 0x002359A0 File Offset: 0x00233BA0
		[NullableContext(0)]
		public static DrinksBatching GetRootAsDrinksBatching(ByteBuffer _bb)
		{
			return DrinksBatching.GetRootAsDrinksBatching(_bb, default(DrinksBatching));
		}

		// Token: 0x06006967 RID: 26983 RVA: 0x002359BC File Offset: 0x00233BBC
		[NullableContext(0)]
		public static DrinksBatching GetRootAsDrinksBatching(ByteBuffer _bb, DrinksBatching obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006968 RID: 26984 RVA: 0x002359D9 File Offset: 0x00233BD9
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006969 RID: 26985 RVA: 0x002359E8 File Offset: 0x00233BE8
		[NullableContext(0)]
		public DrinksBatching __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x0600696A RID: 26986 RVA: 0x002359F8 File Offset: 0x00233BF8
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

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x0600696B RID: 26987 RVA: 0x00235A34 File Offset: 0x00233C34
		[Nullable(0)]
		public string Icon
		{
			[NullableContext(0)]
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

		// Token: 0x0600696C RID: 26988 RVA: 0x00235A6B File Offset: 0x00233C6B
		[NullableContext(0)]
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600696D RID: 26989 RVA: 0x00235A7A File Offset: 0x00233C7A
		[NullableContext(0)]
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x0600696E RID: 26990 RVA: 0x00235A94 File Offset: 0x00233C94
		[Nullable(0)]
		public string Name
		{
			[NullableContext(0)]
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

		// Token: 0x0600696F RID: 26991 RVA: 0x00235ACB File Offset: 0x00233CCB
		[NullableContext(0)]
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006970 RID: 26992 RVA: 0x00235ADA File Offset: 0x00233CDA
		[NullableContext(0)]
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06006971 RID: 26993 RVA: 0x00235AF4 File Offset: 0x00233CF4
		public DicIntInt? Flavor(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06006972 RID: 26994 RVA: 0x00235B58 File Offset: 0x00233D58
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

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06006973 RID: 26995 RVA: 0x00235B84 File Offset: 0x00233D84
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

		// Token: 0x06006974 RID: 26996 RVA: 0x00235BC4 File Offset: 0x00233DC4
		public DicIntInt? ScaleMap(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x06006975 RID: 26997 RVA: 0x00235C28 File Offset: 0x00233E28
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

		// Token: 0x06006976 RID: 26998 RVA: 0x00235C54 File Offset: 0x00233E54
		public DicIntInt? HeighScaleMap(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x06006977 RID: 26999 RVA: 0x00235CB8 File Offset: 0x00233EB8
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

		// Token: 0x06006978 RID: 27000 RVA: 0x00235CE4 File Offset: 0x00233EE4
		public DicIntInt? PosScaleMap(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x06006979 RID: 27001 RVA: 0x00235D48 File Offset: 0x00233F48
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

		// Token: 0x0600697A RID: 27002 RVA: 0x00235D74 File Offset: 0x00233F74
		public DicIntIntArray? PosOnLiquid1(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x0600697B RID: 27003 RVA: 0x00235DD8 File Offset: 0x00233FD8
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

		// Token: 0x0600697C RID: 27004 RVA: 0x00235E04 File Offset: 0x00234004
		public DicIntIntArray? PosOnLiquid2(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x0600697D RID: 27005 RVA: 0x00235E68 File Offset: 0x00234068
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

		// Token: 0x0600697E RID: 27006 RVA: 0x00235E94 File Offset: 0x00234094
		public Dictionary<int, int> Flavor()
		{
			return this.FlavorIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600697F RID: 27007 RVA: 0x00235EEA File Offset: 0x002340EA
		public IEnumerable<DicIntInt> FlavorIter()
		{
			DrinksBatching.<FlavorIter>d__39 <FlavorIter>d__ = new DrinksBatching.<FlavorIter>d__39(-2);
			<FlavorIter>d__.<>3__<>4__this = this;
			return <FlavorIter>d__;
		}

		// Token: 0x06006980 RID: 27008 RVA: 0x00235F00 File Offset: 0x00234100
		public Dictionary<int, int> HeighScaleMap()
		{
			return this.HeighScaleMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006981 RID: 27009 RVA: 0x00235F56 File Offset: 0x00234156
		public IEnumerable<DicIntInt> HeighScaleMapIter()
		{
			DrinksBatching.<HeighScaleMapIter>d__41 <HeighScaleMapIter>d__ = new DrinksBatching.<HeighScaleMapIter>d__41(-2);
			<HeighScaleMapIter>d__.<>3__<>4__this = this;
			return <HeighScaleMapIter>d__;
		}

		// Token: 0x06006982 RID: 27010 RVA: 0x00235F6C File Offset: 0x0023416C
		public Dictionary<int, IntArray> PosOnLiquid1()
		{
			return this.PosOnLiquid1Iter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x06006983 RID: 27011 RVA: 0x00235FC2 File Offset: 0x002341C2
		public IEnumerable<DicIntIntArray> PosOnLiquid1Iter()
		{
			DrinksBatching.<PosOnLiquid1Iter>d__43 <PosOnLiquid1Iter>d__ = new DrinksBatching.<PosOnLiquid1Iter>d__43(-2);
			<PosOnLiquid1Iter>d__.<>3__<>4__this = this;
			return <PosOnLiquid1Iter>d__;
		}

		// Token: 0x06006984 RID: 27012 RVA: 0x00235FD8 File Offset: 0x002341D8
		public Dictionary<int, IntArray> PosOnLiquid2()
		{
			return this.PosOnLiquid2Iter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x06006985 RID: 27013 RVA: 0x0023602E File Offset: 0x0023422E
		public IEnumerable<DicIntIntArray> PosOnLiquid2Iter()
		{
			DrinksBatching.<PosOnLiquid2Iter>d__45 <PosOnLiquid2Iter>d__ = new DrinksBatching.<PosOnLiquid2Iter>d__45(-2);
			<PosOnLiquid2Iter>d__.<>3__<>4__this = this;
			return <PosOnLiquid2Iter>d__;
		}

		// Token: 0x06006986 RID: 27014 RVA: 0x00236044 File Offset: 0x00234244
		public Dictionary<int, int> PosScaleMap()
		{
			return this.PosScaleMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006987 RID: 27015 RVA: 0x0023609A File Offset: 0x0023429A
		public IEnumerable<DicIntInt> PosScaleMapIter()
		{
			DrinksBatching.<PosScaleMapIter>d__47 <PosScaleMapIter>d__ = new DrinksBatching.<PosScaleMapIter>d__47(-2);
			<PosScaleMapIter>d__.<>3__<>4__this = this;
			return <PosScaleMapIter>d__;
		}

		// Token: 0x06006988 RID: 27016 RVA: 0x002360B0 File Offset: 0x002342B0
		public Dictionary<int, int> ScaleMap()
		{
			return this.ScaleMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006989 RID: 27017 RVA: 0x00236106 File Offset: 0x00234306
		public IEnumerable<DicIntInt> ScaleMapIter()
		{
			DrinksBatching.<ScaleMapIter>d__49 <ScaleMapIter>d__ = new DrinksBatching.<ScaleMapIter>d__49(-2);
			<ScaleMapIter>d__.<>3__<>4__this = this;
			return <ScaleMapIter>d__;
		}

		// Token: 0x0600698A RID: 27018 RVA: 0x0023611C File Offset: 0x0023431C
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

		// Token: 0x0600698B RID: 27019 RVA: 0x00236150 File Offset: 0x00234350
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

		// Token: 0x0600698C RID: 27020 RVA: 0x00236184 File Offset: 0x00234384
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

		// Token: 0x0600698D RID: 27021 RVA: 0x002361B8 File Offset: 0x002343B8
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

		// Token: 0x0600698E RID: 27022 RVA: 0x002361EC File Offset: 0x002343EC
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

		// Token: 0x0600698F RID: 27023 RVA: 0x00236220 File Offset: 0x00234420
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

		// Token: 0x06006990 RID: 27024 RVA: 0x00236254 File Offset: 0x00234454
		private void EnsureFlavorCacheIfNeeded()
		{
			if (this.FlavorCache != null)
			{
				return;
			}
			this.FlavorCache = this.FlavorIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006991 RID: 27025 RVA: 0x002362BC File Offset: 0x002344BC
		private void EnsureHeighScaleMapCacheIfNeeded()
		{
			if (this.HeighScaleMapCache != null)
			{
				return;
			}
			this.HeighScaleMapCache = this.HeighScaleMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006992 RID: 27026 RVA: 0x00236324 File Offset: 0x00234524
		private void EnsurePosOnLiquid1CacheIfNeeded()
		{
			if (this.PosOnLiquid1Cache != null)
			{
				return;
			}
			this.PosOnLiquid1Cache = this.PosOnLiquid1Iter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x06006993 RID: 27027 RVA: 0x0023638C File Offset: 0x0023458C
		private void EnsurePosOnLiquid2CacheIfNeeded()
		{
			if (this.PosOnLiquid2Cache != null)
			{
				return;
			}
			this.PosOnLiquid2Cache = this.PosOnLiquid2Iter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x06006994 RID: 27028 RVA: 0x002363F4 File Offset: 0x002345F4
		private void EnsurePosScaleMapCacheIfNeeded()
		{
			if (this.PosScaleMapCache != null)
			{
				return;
			}
			this.PosScaleMapCache = this.PosScaleMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006995 RID: 27029 RVA: 0x0023645C File Offset: 0x0023465C
		private void EnsureScaleMapCacheIfNeeded()
		{
			if (this.ScaleMapCache != null)
			{
				return;
			}
			this.ScaleMapCache = this.ScaleMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006996 RID: 27030 RVA: 0x002364C2 File Offset: 0x002346C2
		public FrozenDictionary<int, int> GetFlavorFrozenDict()
		{
			this.EnsureFlavorCacheIfNeeded();
			return this.FlavorCache;
		}

		// Token: 0x06006997 RID: 27031 RVA: 0x002364D0 File Offset: 0x002346D0
		public FrozenDictionary<int, int> GetHeighScaleMapFrozenDict()
		{
			this.EnsureHeighScaleMapCacheIfNeeded();
			return this.HeighScaleMapCache;
		}

		// Token: 0x06006998 RID: 27032 RVA: 0x002364DE File Offset: 0x002346DE
		public FrozenDictionary<int, IntArray> GetPosOnLiquid1FrozenDict()
		{
			this.EnsurePosOnLiquid1CacheIfNeeded();
			return this.PosOnLiquid1Cache;
		}

		// Token: 0x06006999 RID: 27033 RVA: 0x002364EC File Offset: 0x002346EC
		public FrozenDictionary<int, IntArray> GetPosOnLiquid2FrozenDict()
		{
			this.EnsurePosOnLiquid2CacheIfNeeded();
			return this.PosOnLiquid2Cache;
		}

		// Token: 0x0600699A RID: 27034 RVA: 0x002364FA File Offset: 0x002346FA
		public FrozenDictionary<int, int> GetPosScaleMapFrozenDict()
		{
			this.EnsurePosScaleMapCacheIfNeeded();
			return this.PosScaleMapCache;
		}

		// Token: 0x0600699B RID: 27035 RVA: 0x00236508 File Offset: 0x00234708
		public FrozenDictionary<int, int> GetScaleMapFrozenDict()
		{
			this.EnsureScaleMapCacheIfNeeded();
			return this.ScaleMapCache;
		}

		// Token: 0x04005210 RID: 21008
		private Table __p;

		// Token: 0x04005211 RID: 21009
		[Nullable(2)]
		private FrozenDictionary<int, int> FlavorCache;

		// Token: 0x04005212 RID: 21010
		[Nullable(2)]
		private FrozenDictionary<int, int> HeighScaleMapCache;

		// Token: 0x04005213 RID: 21011
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> PosOnLiquid1Cache;

		// Token: 0x04005214 RID: 21012
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> PosOnLiquid2Cache;

		// Token: 0x04005215 RID: 21013
		[Nullable(2)]
		private FrozenDictionary<int, int> PosScaleMapCache;

		// Token: 0x04005216 RID: 21014
		[Nullable(2)]
		private FrozenDictionary<int, int> ScaleMapCache;
	}
}

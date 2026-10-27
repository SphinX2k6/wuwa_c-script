using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CFC RID: 3324
	public struct GiantItemAccess : IFlatbufferObject
	{
		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x06007A71 RID: 31345 RVA: 0x0024B145 File Offset: 0x00249345
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007A72 RID: 31346 RVA: 0x0024B152 File Offset: 0x00249352
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007A73 RID: 31347 RVA: 0x0024B15C File Offset: 0x0024935C
		public static GiantItemAccess GetRootAsGiantItemAccess(ByteBuffer _bb)
		{
			return GiantItemAccess.GetRootAsGiantItemAccess(_bb, default(GiantItemAccess));
		}

		// Token: 0x06007A74 RID: 31348 RVA: 0x0024B178 File Offset: 0x00249378
		public static GiantItemAccess GetRootAsGiantItemAccess(ByteBuffer _bb, GiantItemAccess obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007A75 RID: 31349 RVA: 0x0024B195 File Offset: 0x00249395
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007A76 RID: 31350 RVA: 0x0024B1A4 File Offset: 0x002493A4
		public GiantItemAccess __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x06007A77 RID: 31351 RVA: 0x0024B1B4 File Offset: 0x002493B4
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

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x06007A78 RID: 31352 RVA: 0x0024B1F0 File Offset: 0x002493F0
		public int EcoType
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

		// Token: 0x06007A79 RID: 31353 RVA: 0x0024B22C File Offset: 0x0024942C
		public DicIntInt? ItemCounts(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x06007A7A RID: 31354 RVA: 0x0024B28C File Offset: 0x0024948C
		public int ItemCountsLength
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

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x06007A7B RID: 31355 RVA: 0x0024B2B8 File Offset: 0x002494B8
		public int AccessPathId
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

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x06007A7C RID: 31356 RVA: 0x0024B2F8 File Offset: 0x002494F8
		public int SortIndex
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

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x06007A7D RID: 31357 RVA: 0x0024B338 File Offset: 0x00249538
		public string Desc
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

		// Token: 0x06007A7E RID: 31358 RVA: 0x0024B370 File Offset: 0x00249570
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007A7F RID: 31359 RVA: 0x0024B380 File Offset: 0x00249580
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x06007A80 RID: 31360 RVA: 0x0024B398 File Offset: 0x00249598
		public int UnlockCondition
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

		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x06007A81 RID: 31361 RVA: 0x0024B3D8 File Offset: 0x002495D8
		public int DisplayGroup
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

		// Token: 0x06007A82 RID: 31362 RVA: 0x0024B418 File Offset: 0x00249618
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ItemCountsFrozenDict()缓存字典，遍历请使用ItemCountsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ItemCounts()
		{
			return this.ItemCountsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06007A83 RID: 31363 RVA: 0x0024B46E File Offset: 0x0024966E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ItemCountsIter()
		{
			GiantItemAccess.<ItemCountsIter>d__28 <ItemCountsIter>d__ = new GiantItemAccess.<ItemCountsIter>d__28(-2);
			<ItemCountsIter>d__.<>3__<>4__this = this;
			return <ItemCountsIter>d__;
		}

		// Token: 0x06007A84 RID: 31364 RVA: 0x0024B484 File Offset: 0x00249684
		public int? GetItemCounts(int key)
		{
			this.EnsureItemCountsCacheIfNeeded();
			int value;
			if (!this.ItemCountsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06007A85 RID: 31365 RVA: 0x0024B4B8 File Offset: 0x002496B8
		private void EnsureItemCountsCacheIfNeeded()
		{
			if (this.ItemCountsCache != null)
			{
				return;
			}
			this.ItemCountsCache = this.ItemCountsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007A86 RID: 31366 RVA: 0x0024B51E File Offset: 0x0024971E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetItemCountsFrozenDict(int key)
		{
			this.EnsureItemCountsCacheIfNeeded();
			return this.ItemCountsCache;
		}

		// Token: 0x04004D6F RID: 19823
		private Table __p;

		// Token: 0x04004D70 RID: 19824
		[Nullable(2)]
		private FrozenDictionary<int, int> ItemCountsCache;
	}
}

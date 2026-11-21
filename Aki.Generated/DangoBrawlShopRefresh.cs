using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CB5 RID: 3253
	public struct DangoBrawlShopRefresh : IFlatbufferObject
	{
		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x060065E8 RID: 26088 RVA: 0x0022E2B0 File Offset: 0x0022C4B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060065E9 RID: 26089 RVA: 0x0022E2BD File Offset: 0x0022C4BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060065EA RID: 26090 RVA: 0x0022E2C4 File Offset: 0x0022C4C4
		public static DangoBrawlShopRefresh GetRootAsDangoBrawlShopRefresh(ByteBuffer _bb)
		{
			return DangoBrawlShopRefresh.GetRootAsDangoBrawlShopRefresh(_bb, default(DangoBrawlShopRefresh));
		}

		// Token: 0x060065EB RID: 26091 RVA: 0x0022E2E0 File Offset: 0x0022C4E0
		public static DangoBrawlShopRefresh GetRootAsDangoBrawlShopRefresh(ByteBuffer _bb, DangoBrawlShopRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060065EC RID: 26092 RVA: 0x0022E2FD File Offset: 0x0022C4FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060065ED RID: 26093 RVA: 0x0022E30C File Offset: 0x0022C50C
		public DangoBrawlShopRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x060065EE RID: 26094 RVA: 0x0022E31C File Offset: 0x0022C51C
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

		// Token: 0x060065EF RID: 26095 RVA: 0x0022E358 File Offset: 0x0022C558
		public DicIntInt? RefreshCostMap(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x060065F0 RID: 26096 RVA: 0x0022E3B8 File Offset: 0x0022C5B8
		public int RefreshCostMapLength
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

		// Token: 0x060065F1 RID: 26097 RVA: 0x0022E3E4 File Offset: 0x0022C5E4
		[NullableContext(1)]
		public Dictionary<int, int> RefreshCostMap()
		{
			return this.RefreshCostMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060065F2 RID: 26098 RVA: 0x0022E43A File Offset: 0x0022C63A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RefreshCostMapIter()
		{
			DangoBrawlShopRefresh.<RefreshCostMapIter>d__14 <RefreshCostMapIter>d__ = new DangoBrawlShopRefresh.<RefreshCostMapIter>d__14(-2);
			<RefreshCostMapIter>d__.<>3__<>4__this = this;
			return <RefreshCostMapIter>d__;
		}

		// Token: 0x060065F3 RID: 26099 RVA: 0x0022E450 File Offset: 0x0022C650
		public int? GetRefreshCostMap(int key)
		{
			this.EnsureRefreshCostMapCacheIfNeeded();
			int value;
			if (!this.RefreshCostMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060065F4 RID: 26100 RVA: 0x0022E484 File Offset: 0x0022C684
		private void EnsureRefreshCostMapCacheIfNeeded()
		{
			if (this.RefreshCostMapCache != null)
			{
				return;
			}
			this.RefreshCostMapCache = this.RefreshCostMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060065F5 RID: 26101 RVA: 0x0022E4EA File Offset: 0x0022C6EA
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRefreshCostMapFrozenDict()
		{
			this.EnsureRefreshCostMapCacheIfNeeded();
			return this.RefreshCostMapCache;
		}

		// Token: 0x040051E1 RID: 20961
		private Table __p;

		// Token: 0x040051E2 RID: 20962
		[Nullable(2)]
		private FrozenDictionary<int, int> RefreshCostMapCache;
	}
}

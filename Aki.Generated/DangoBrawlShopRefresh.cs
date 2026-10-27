using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BD3 RID: 3027
	public struct DangoBrawlShopRefresh : IFlatbufferObject
	{
		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x0600600F RID: 24591 RVA: 0x0020EC2C File Offset: 0x0020CE2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006010 RID: 24592 RVA: 0x0020EC39 File Offset: 0x0020CE39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006011 RID: 24593 RVA: 0x0020EC40 File Offset: 0x0020CE40
		public static DangoBrawlShopRefresh GetRootAsDangoBrawlShopRefresh(ByteBuffer _bb)
		{
			return DangoBrawlShopRefresh.GetRootAsDangoBrawlShopRefresh(_bb, default(DangoBrawlShopRefresh));
		}

		// Token: 0x06006012 RID: 24594 RVA: 0x0020EC5C File Offset: 0x0020CE5C
		public static DangoBrawlShopRefresh GetRootAsDangoBrawlShopRefresh(ByteBuffer _bb, DangoBrawlShopRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006013 RID: 24595 RVA: 0x0020EC79 File Offset: 0x0020CE79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006014 RID: 24596 RVA: 0x0020EC88 File Offset: 0x0020CE88
		public DangoBrawlShopRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06006015 RID: 24597 RVA: 0x0020EC98 File Offset: 0x0020CE98
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

		// Token: 0x06006016 RID: 24598 RVA: 0x0020ECD4 File Offset: 0x0020CED4
		public DicIntInt? RefreshCostMap(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06006017 RID: 24599 RVA: 0x0020ED34 File Offset: 0x0020CF34
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

		// Token: 0x06006018 RID: 24600 RVA: 0x0020ED60 File Offset: 0x0020CF60
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RefreshCostMapFrozenDict()缓存字典，遍历请使用RefreshCostMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> RefreshCostMap()
		{
			return this.RefreshCostMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006019 RID: 24601 RVA: 0x0020EDB6 File Offset: 0x0020CFB6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RefreshCostMapIter()
		{
			DangoBrawlShopRefresh.<RefreshCostMapIter>d__14 <RefreshCostMapIter>d__ = new DangoBrawlShopRefresh.<RefreshCostMapIter>d__14(-2);
			<RefreshCostMapIter>d__.<>3__<>4__this = this;
			return <RefreshCostMapIter>d__;
		}

		// Token: 0x0600601A RID: 24602 RVA: 0x0020EDCC File Offset: 0x0020CFCC
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

		// Token: 0x0600601B RID: 24603 RVA: 0x0020EE00 File Offset: 0x0020D000
		private void EnsureRefreshCostMapCacheIfNeeded()
		{
			if (this.RefreshCostMapCache != null)
			{
				return;
			}
			this.RefreshCostMapCache = this.RefreshCostMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600601C RID: 24604 RVA: 0x0020EE66 File Offset: 0x0020D066
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRefreshCostMapFrozenDict(int key)
		{
			this.EnsureRefreshCostMapCacheIfNeeded();
			return this.RefreshCostMapCache;
		}

		// Token: 0x04004BFF RID: 19455
		private Table __p;

		// Token: 0x04004C00 RID: 19456
		[Nullable(2)]
		private FrozenDictionary<int, int> RefreshCostMapCache;
	}
}

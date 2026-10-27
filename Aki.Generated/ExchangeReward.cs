using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C43 RID: 3139
	public struct ExchangeReward : IFlatbufferObject
	{
		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06006A77 RID: 27255 RVA: 0x00225D46 File Offset: 0x00223F46
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006A78 RID: 27256 RVA: 0x00225D53 File Offset: 0x00223F53
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006A79 RID: 27257 RVA: 0x00225D5C File Offset: 0x00223F5C
		public static ExchangeReward GetRootAsExchangeReward(ByteBuffer _bb)
		{
			return ExchangeReward.GetRootAsExchangeReward(_bb, default(ExchangeReward));
		}

		// Token: 0x06006A7A RID: 27258 RVA: 0x00225D78 File Offset: 0x00223F78
		public static ExchangeReward GetRootAsExchangeReward(ByteBuffer _bb, ExchangeReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006A7B RID: 27259 RVA: 0x00225D95 File Offset: 0x00223F95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006A7C RID: 27260 RVA: 0x00225DA4 File Offset: 0x00223FA4
		public ExchangeReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06006A7D RID: 27261 RVA: 0x00225DB4 File Offset: 0x00223FB4
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

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06006A7E RID: 27262 RVA: 0x00225DF0 File Offset: 0x00223FF0
		public int SharedId
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

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06006A7F RID: 27263 RVA: 0x00225E2C File Offset: 0x0022402C
		public int MaxCount
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

		// Token: 0x06006A80 RID: 27264 RVA: 0x00225E68 File Offset: 0x00224068
		public DicIntInt? Cost(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06006A81 RID: 27265 RVA: 0x00225ECC File Offset: 0x002240CC
		public int CostLength
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

		// Token: 0x06006A82 RID: 27266 RVA: 0x00225EF8 File Offset: 0x002240F8
		public DicIntInt? RewardId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06006A83 RID: 27267 RVA: 0x00225F5C File Offset: 0x0022415C
		public int RewardIdLength
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

		// Token: 0x06006A84 RID: 27268 RVA: 0x00225F88 File Offset: 0x00224188
		public DicIntInt? RewardIdCalabash(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06006A85 RID: 27269 RVA: 0x00225FEC File Offset: 0x002241EC
		public int RewardIdCalabashLength
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

		// Token: 0x06006A86 RID: 27270 RVA: 0x00226018 File Offset: 0x00224218
		public DicIntIntIntMap? PreviewReward(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntIntMap?(default(DicIntIntIntMap).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06006A87 RID: 27271 RVA: 0x0022607C File Offset: 0x0022427C
		public int PreviewRewardLength
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

		// Token: 0x06006A88 RID: 27272 RVA: 0x002260A8 File Offset: 0x002242A8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用CostFrozenDict()缓存字典，遍历请使用CostIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Cost()
		{
			return this.CostIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006A89 RID: 27273 RVA: 0x002260FE File Offset: 0x002242FE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> CostIter()
		{
			ExchangeReward.<CostIter>d__27 <CostIter>d__ = new ExchangeReward.<CostIter>d__27(-2);
			<CostIter>d__.<>3__<>4__this = this;
			return <CostIter>d__;
		}

		// Token: 0x06006A8A RID: 27274 RVA: 0x00226114 File Offset: 0x00224314
		[NullableContext(1)]
		[Obsolete("已废弃，请使用PreviewRewardFrozenDict()缓存字典，遍历请使用PreviewRewardIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntIntMap> PreviewReward()
		{
			return this.PreviewRewardIter().ToDictionary((DicIntIntIntMap element) => element.Key, (DicIntIntIntMap element) => element.Value.Value);
		}

		// Token: 0x06006A8B RID: 27275 RVA: 0x0022616A File Offset: 0x0022436A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntIntMap> PreviewRewardIter()
		{
			ExchangeReward.<PreviewRewardIter>d__29 <PreviewRewardIter>d__ = new ExchangeReward.<PreviewRewardIter>d__29(-2);
			<PreviewRewardIter>d__.<>3__<>4__this = this;
			return <PreviewRewardIter>d__;
		}

		// Token: 0x06006A8C RID: 27276 RVA: 0x00226180 File Offset: 0x00224380
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RewardIdFrozenDict()缓存字典，遍历请使用RewardIdIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> RewardId()
		{
			return this.RewardIdIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006A8D RID: 27277 RVA: 0x002261D6 File Offset: 0x002243D6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RewardIdIter()
		{
			ExchangeReward.<RewardIdIter>d__31 <RewardIdIter>d__ = new ExchangeReward.<RewardIdIter>d__31(-2);
			<RewardIdIter>d__.<>3__<>4__this = this;
			return <RewardIdIter>d__;
		}

		// Token: 0x06006A8E RID: 27278 RVA: 0x002261EC File Offset: 0x002243EC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RewardIdCalabashFrozenDict()缓存字典，遍历请使用RewardIdCalabashIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> RewardIdCalabash()
		{
			return this.RewardIdCalabashIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006A8F RID: 27279 RVA: 0x00226242 File Offset: 0x00224442
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RewardIdCalabashIter()
		{
			ExchangeReward.<RewardIdCalabashIter>d__33 <RewardIdCalabashIter>d__ = new ExchangeReward.<RewardIdCalabashIter>d__33(-2);
			<RewardIdCalabashIter>d__.<>3__<>4__this = this;
			return <RewardIdCalabashIter>d__;
		}

		// Token: 0x06006A90 RID: 27280 RVA: 0x00226258 File Offset: 0x00224458
		public int? GetCost(int key)
		{
			this.EnsureCostCacheIfNeeded();
			int value;
			if (!this.CostCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06006A91 RID: 27281 RVA: 0x0022628C File Offset: 0x0022448C
		public IntIntMap? GetPreviewReward(int key)
		{
			this.EnsurePreviewRewardCacheIfNeeded();
			IntIntMap value;
			if (!this.PreviewRewardCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntIntMap?(value);
		}

		// Token: 0x06006A92 RID: 27282 RVA: 0x002262C0 File Offset: 0x002244C0
		public int? GetRewardId(int key)
		{
			this.EnsureRewardIdCacheIfNeeded();
			int value;
			if (!this.RewardIdCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06006A93 RID: 27283 RVA: 0x002262F4 File Offset: 0x002244F4
		public int? GetRewardIdCalabash(int key)
		{
			this.EnsureRewardIdCalabashCacheIfNeeded();
			int value;
			if (!this.RewardIdCalabashCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06006A94 RID: 27284 RVA: 0x00226328 File Offset: 0x00224528
		private void EnsureCostCacheIfNeeded()
		{
			if (this.CostCache != null)
			{
				return;
			}
			this.CostCache = this.CostIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006A95 RID: 27285 RVA: 0x00226390 File Offset: 0x00224590
		private void EnsurePreviewRewardCacheIfNeeded()
		{
			if (this.PreviewRewardCache != null)
			{
				return;
			}
			this.PreviewRewardCache = this.PreviewRewardIter().ToFrozenDictionary((DicIntIntIntMap kvp) => kvp.Key, (DicIntIntIntMap kvp) => kvp.Value.Value, null);
		}

		// Token: 0x06006A96 RID: 27286 RVA: 0x002263F8 File Offset: 0x002245F8
		private void EnsureRewardIdCacheIfNeeded()
		{
			if (this.RewardIdCache != null)
			{
				return;
			}
			this.RewardIdCache = this.RewardIdIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006A97 RID: 27287 RVA: 0x00226460 File Offset: 0x00224660
		private void EnsureRewardIdCalabashCacheIfNeeded()
		{
			if (this.RewardIdCalabashCache != null)
			{
				return;
			}
			this.RewardIdCalabashCache = this.RewardIdCalabashIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006A98 RID: 27288 RVA: 0x002264C6 File Offset: 0x002246C6
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetCostFrozenDict(int key)
		{
			this.EnsureCostCacheIfNeeded();
			return this.CostCache;
		}

		// Token: 0x06006A99 RID: 27289 RVA: 0x002264D4 File Offset: 0x002246D4
		[NullableContext(2)]
		public FrozenDictionary<int, IntIntMap> GetPreviewRewardFrozenDict(int key)
		{
			this.EnsurePreviewRewardCacheIfNeeded();
			return this.PreviewRewardCache;
		}

		// Token: 0x06006A9A RID: 27290 RVA: 0x002264E2 File Offset: 0x002246E2
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRewardIdFrozenDict(int key)
		{
			this.EnsureRewardIdCacheIfNeeded();
			return this.RewardIdCache;
		}

		// Token: 0x06006A9B RID: 27291 RVA: 0x002264F0 File Offset: 0x002246F0
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRewardIdCalabashFrozenDict(int key)
		{
			this.EnsureRewardIdCalabashCacheIfNeeded();
			return this.RewardIdCalabashCache;
		}

		// Token: 0x04004C83 RID: 19587
		private Table __p;

		// Token: 0x04004C84 RID: 19588
		[Nullable(2)]
		private FrozenDictionary<int, int> CostCache;

		// Token: 0x04004C85 RID: 19589
		[Nullable(2)]
		private FrozenDictionary<int, IntIntMap> PreviewRewardCache;

		// Token: 0x04004C86 RID: 19590
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardIdCache;

		// Token: 0x04004C87 RID: 19591
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardIdCalabashCache;
	}
}

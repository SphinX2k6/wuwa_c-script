using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C85 RID: 3205
	public struct FishingPoint : IFlatbufferObject
	{
		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x06006FD0 RID: 28624 RVA: 0x00232360 File Offset: 0x00230560
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006FD1 RID: 28625 RVA: 0x0023236D File Offset: 0x0023056D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006FD2 RID: 28626 RVA: 0x00232374 File Offset: 0x00230574
		public static FishingPoint GetRootAsFishingPoint(ByteBuffer _bb)
		{
			return FishingPoint.GetRootAsFishingPoint(_bb, default(FishingPoint));
		}

		// Token: 0x06006FD3 RID: 28627 RVA: 0x00232390 File Offset: 0x00230590
		public static FishingPoint GetRootAsFishingPoint(ByteBuffer _bb, FishingPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006FD4 RID: 28628 RVA: 0x002323AD File Offset: 0x002305AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006FD5 RID: 28629 RVA: 0x002323BC File Offset: 0x002305BC
		public FishingPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x06006FD6 RID: 28630 RVA: 0x002323CC File Offset: 0x002305CC
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

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x06006FD7 RID: 28631 RVA: 0x00232408 File Offset: 0x00230608
		public int EntityConfigId
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

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x06006FD8 RID: 28632 RVA: 0x00232444 File Offset: 0x00230644
		public int ShowItem
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

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x06006FD9 RID: 28633 RVA: 0x00232480 File Offset: 0x00230680
		public int GamePlayId
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

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x06006FDA RID: 28634 RVA: 0x002324C0 File Offset: 0x002306C0
		public int UnlockTech
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

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x06006FDB RID: 28635 RVA: 0x00232500 File Offset: 0x00230700
		public int GroupId
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

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x06006FDC RID: 28636 RVA: 0x00232540 File Offset: 0x00230740
		public int SceneConfigId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006FDD RID: 28637 RVA: 0x00232580 File Offset: 0x00230780
		public DicIntInt? RewardItem(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x06006FDE RID: 28638 RVA: 0x002325E4 File Offset: 0x002307E4
		public int RewardItemLength
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

		// Token: 0x06006FDF RID: 28639 RVA: 0x00232610 File Offset: 0x00230810
		public DicIntInt? OutGrowth(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x06006FE0 RID: 28640 RVA: 0x00232674 File Offset: 0x00230874
		public int OutGrowthLength
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

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x06006FE1 RID: 28641 RVA: 0x002326A0 File Offset: 0x002308A0
		public int DoubleRate
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x06006FE2 RID: 28642 RVA: 0x002326E0 File Offset: 0x002308E0
		public int Count
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x06006FE3 RID: 28643 RVA: 0x00232720 File Offset: 0x00230920
		public int RefreshTime
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006FE4 RID: 28644 RVA: 0x00232760 File Offset: 0x00230960
		[NullableContext(1)]
		[Obsolete("已废弃，请使用OutGrowthFrozenDict()缓存字典，遍历请使用OutGrowthIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> OutGrowth()
		{
			return this.OutGrowthIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006FE5 RID: 28645 RVA: 0x002327B6 File Offset: 0x002309B6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> OutGrowthIter()
		{
			FishingPoint.<OutGrowthIter>d__35 <OutGrowthIter>d__ = new FishingPoint.<OutGrowthIter>d__35(-2);
			<OutGrowthIter>d__.<>3__<>4__this = this;
			return <OutGrowthIter>d__;
		}

		// Token: 0x06006FE6 RID: 28646 RVA: 0x002327CC File Offset: 0x002309CC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RewardItemFrozenDict()缓存字典，遍历请使用RewardItemIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> RewardItem()
		{
			return this.RewardItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006FE7 RID: 28647 RVA: 0x00232822 File Offset: 0x00230A22
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RewardItemIter()
		{
			FishingPoint.<RewardItemIter>d__37 <RewardItemIter>d__ = new FishingPoint.<RewardItemIter>d__37(-2);
			<RewardItemIter>d__.<>3__<>4__this = this;
			return <RewardItemIter>d__;
		}

		// Token: 0x06006FE8 RID: 28648 RVA: 0x00232838 File Offset: 0x00230A38
		public int? GetOutGrowth(int key)
		{
			this.EnsureOutGrowthCacheIfNeeded();
			int value;
			if (!this.OutGrowthCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06006FE9 RID: 28649 RVA: 0x0023286C File Offset: 0x00230A6C
		public int? GetRewardItem(int key)
		{
			this.EnsureRewardItemCacheIfNeeded();
			int value;
			if (!this.RewardItemCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06006FEA RID: 28650 RVA: 0x002328A0 File Offset: 0x00230AA0
		private void EnsureOutGrowthCacheIfNeeded()
		{
			if (this.OutGrowthCache != null)
			{
				return;
			}
			this.OutGrowthCache = this.OutGrowthIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006FEB RID: 28651 RVA: 0x00232908 File Offset: 0x00230B08
		private void EnsureRewardItemCacheIfNeeded()
		{
			if (this.RewardItemCache != null)
			{
				return;
			}
			this.RewardItemCache = this.RewardItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006FEC RID: 28652 RVA: 0x0023296E File Offset: 0x00230B6E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetOutGrowthFrozenDict(int key)
		{
			this.EnsureOutGrowthCacheIfNeeded();
			return this.OutGrowthCache;
		}

		// Token: 0x06006FED RID: 28653 RVA: 0x0023297C File Offset: 0x00230B7C
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRewardItemFrozenDict(int key)
		{
			this.EnsureRewardItemCacheIfNeeded();
			return this.RewardItemCache;
		}

		// Token: 0x04004CD5 RID: 19669
		private Table __p;

		// Token: 0x04004CD6 RID: 19670
		[Nullable(2)]
		private FrozenDictionary<int, int> OutGrowthCache;

		// Token: 0x04004CD7 RID: 19671
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardItemCache;
	}
}

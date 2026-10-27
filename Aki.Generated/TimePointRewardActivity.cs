using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200112D RID: 4397
	public struct TimePointRewardActivity : IFlatbufferObject
	{
		// Token: 0x17003A6F RID: 14959
		// (get) Token: 0x0600DECF RID: 57039 RVA: 0x0032DD4E File Offset: 0x0032BF4E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DED0 RID: 57040 RVA: 0x0032DD5B File Offset: 0x0032BF5B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DED1 RID: 57041 RVA: 0x0032DD64 File Offset: 0x0032BF64
		public static TimePointRewardActivity GetRootAsTimePointRewardActivity(ByteBuffer _bb)
		{
			return TimePointRewardActivity.GetRootAsTimePointRewardActivity(_bb, default(TimePointRewardActivity));
		}

		// Token: 0x0600DED2 RID: 57042 RVA: 0x0032DD80 File Offset: 0x0032BF80
		public static TimePointRewardActivity GetRootAsTimePointRewardActivity(ByteBuffer _bb, TimePointRewardActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DED3 RID: 57043 RVA: 0x0032DD9D File Offset: 0x0032BF9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DED4 RID: 57044 RVA: 0x0032DDAC File Offset: 0x0032BFAC
		public TimePointRewardActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A70 RID: 14960
		// (get) Token: 0x0600DED5 RID: 57045 RVA: 0x0032DDBC File Offset: 0x0032BFBC
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

		// Token: 0x17003A71 RID: 14961
		// (get) Token: 0x0600DED6 RID: 57046 RVA: 0x0032DDF8 File Offset: 0x0032BFF8
		public int ActivityId
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

		// Token: 0x0600DED7 RID: 57047 RVA: 0x0032DE34 File Offset: 0x0032C034
		public DicIntInt? RewardItem(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003A72 RID: 14962
		// (get) Token: 0x0600DED8 RID: 57048 RVA: 0x0032DE94 File Offset: 0x0032C094
		public int RewardItemLength
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

		// Token: 0x0600DED9 RID: 57049 RVA: 0x0032DEC0 File Offset: 0x0032C0C0
		public IntPair? Rewards(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003A73 RID: 14963
		// (get) Token: 0x0600DEDA RID: 57050 RVA: 0x0032DF24 File Offset: 0x0032C124
		public int RewardsLength
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

		// Token: 0x0600DEDB RID: 57051 RVA: 0x0032DF50 File Offset: 0x0032C150
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RewardItemFrozenDict()缓存字典，遍历请使用RewardItemIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> RewardItem()
		{
			return this.RewardItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DEDC RID: 57052 RVA: 0x0032DFA6 File Offset: 0x0032C1A6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RewardItemIter()
		{
			TimePointRewardActivity.<RewardItemIter>d__19 <RewardItemIter>d__ = new TimePointRewardActivity.<RewardItemIter>d__19(-2);
			<RewardItemIter>d__.<>3__<>4__this = this;
			return <RewardItemIter>d__;
		}

		// Token: 0x0600DEDD RID: 57053 RVA: 0x0032DFBB File Offset: 0x0032C1BB
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RewardsIter()或GetRewardsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntPair[] Rewards()
		{
			return this.RewardsIter().ToArray<IntPair>();
		}

		// Token: 0x0600DEDE RID: 57054 RVA: 0x0032DFC8 File Offset: 0x0032C1C8
		[NullableContext(1)]
		public readonly IEnumerable<IntPair> RewardsIter()
		{
			TimePointRewardActivity.<RewardsIter>d__21 <RewardsIter>d__ = new TimePointRewardActivity.<RewardsIter>d__21(-2);
			<RewardsIter>d__.<>3__<>4__this = this;
			return <RewardsIter>d__;
		}

		// Token: 0x0600DEDF RID: 57055 RVA: 0x0032DFE0 File Offset: 0x0032C1E0
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

		// Token: 0x0600DEE0 RID: 57056 RVA: 0x0032E014 File Offset: 0x0032C214
		private void EnsureRewardItemCacheIfNeeded()
		{
			if (this.RewardItemCache != null)
			{
				return;
			}
			this.RewardItemCache = this.RewardItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DEE1 RID: 57057 RVA: 0x0032E07A File Offset: 0x0032C27A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRewardItemFrozenDict(int key)
		{
			this.EnsureRewardItemCacheIfNeeded();
			return this.RewardItemCache;
		}

		// Token: 0x0400526D RID: 21101
		private Table __p;

		// Token: 0x0400526E RID: 21102
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardItemCache;
	}
}

using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001263 RID: 4707
	public struct TimePointRewardActivity : IFlatbufferObject
	{
		// Token: 0x17003DD3 RID: 15827
		// (get) Token: 0x0600EC3D RID: 60477 RVA: 0x00359322 File Offset: 0x00357522
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EC3E RID: 60478 RVA: 0x0035932F File Offset: 0x0035752F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EC3F RID: 60479 RVA: 0x00359338 File Offset: 0x00357538
		public static TimePointRewardActivity GetRootAsTimePointRewardActivity(ByteBuffer _bb)
		{
			return TimePointRewardActivity.GetRootAsTimePointRewardActivity(_bb, default(TimePointRewardActivity));
		}

		// Token: 0x0600EC40 RID: 60480 RVA: 0x00359354 File Offset: 0x00357554
		public static TimePointRewardActivity GetRootAsTimePointRewardActivity(ByteBuffer _bb, TimePointRewardActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EC41 RID: 60481 RVA: 0x00359371 File Offset: 0x00357571
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EC42 RID: 60482 RVA: 0x00359380 File Offset: 0x00357580
		public TimePointRewardActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DD4 RID: 15828
		// (get) Token: 0x0600EC43 RID: 60483 RVA: 0x00359390 File Offset: 0x00357590
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

		// Token: 0x17003DD5 RID: 15829
		// (get) Token: 0x0600EC44 RID: 60484 RVA: 0x003593CC File Offset: 0x003575CC
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

		// Token: 0x0600EC45 RID: 60485 RVA: 0x00359408 File Offset: 0x00357608
		public DicIntInt? RewardItem(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003DD6 RID: 15830
		// (get) Token: 0x0600EC46 RID: 60486 RVA: 0x00359468 File Offset: 0x00357668
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

		// Token: 0x0600EC47 RID: 60487 RVA: 0x00359494 File Offset: 0x00357694
		public IntPair? Rewards(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003DD7 RID: 15831
		// (get) Token: 0x0600EC48 RID: 60488 RVA: 0x003594F8 File Offset: 0x003576F8
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

		// Token: 0x0600EC49 RID: 60489 RVA: 0x00359524 File Offset: 0x00357724
		[NullableContext(1)]
		public Dictionary<int, int> RewardItem()
		{
			return this.RewardItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600EC4A RID: 60490 RVA: 0x0035957A File Offset: 0x0035777A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RewardItemIter()
		{
			TimePointRewardActivity.<RewardItemIter>d__19 <RewardItemIter>d__ = new TimePointRewardActivity.<RewardItemIter>d__19(-2);
			<RewardItemIter>d__.<>3__<>4__this = this;
			return <RewardItemIter>d__;
		}

		// Token: 0x0600EC4B RID: 60491 RVA: 0x0035958F File Offset: 0x0035778F
		[NullableContext(1)]
		public IntPair[] Rewards()
		{
			return this.RewardsIter().ToArray<IntPair>();
		}

		// Token: 0x0600EC4C RID: 60492 RVA: 0x0035959C File Offset: 0x0035779C
		[NullableContext(1)]
		public IEnumerable<IntPair> RewardsIter()
		{
			TimePointRewardActivity.<RewardsIter>d__21 <RewardsIter>d__ = new TimePointRewardActivity.<RewardsIter>d__21(-2);
			<RewardsIter>d__.<>3__<>4__this = this;
			return <RewardsIter>d__;
		}

		// Token: 0x0600EC4D RID: 60493 RVA: 0x003595B4 File Offset: 0x003577B4
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

		// Token: 0x0600EC4E RID: 60494 RVA: 0x003595E8 File Offset: 0x003577E8
		private void EnsureRewardItemCacheIfNeeded()
		{
			if (this.RewardItemCache != null)
			{
				return;
			}
			this.RewardItemCache = this.RewardItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600EC4F RID: 60495 RVA: 0x0035964E File Offset: 0x0035784E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRewardItemFrozenDict()
		{
			this.EnsureRewardItemCacheIfNeeded();
			return this.RewardItemCache;
		}

		// Token: 0x040058B0 RID: 22704
		private Table __p;

		// Token: 0x040058B1 RID: 22705
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardItemCache;
	}
}

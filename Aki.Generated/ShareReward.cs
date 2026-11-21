using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001196 RID: 4502
	public struct ShareReward : IFlatbufferObject
	{
		// Token: 0x17003653 RID: 13907
		// (get) Token: 0x0600D85E RID: 55390 RVA: 0x0032B519 File Offset: 0x00329719
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D85F RID: 55391 RVA: 0x0032B526 File Offset: 0x00329726
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D860 RID: 55392 RVA: 0x0032B530 File Offset: 0x00329730
		public static ShareReward GetRootAsShareReward(ByteBuffer _bb)
		{
			return ShareReward.GetRootAsShareReward(_bb, default(ShareReward));
		}

		// Token: 0x0600D861 RID: 55393 RVA: 0x0032B54C File Offset: 0x0032974C
		public static ShareReward GetRootAsShareReward(ByteBuffer _bb, ShareReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D862 RID: 55394 RVA: 0x0032B569 File Offset: 0x00329769
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D863 RID: 55395 RVA: 0x0032B578 File Offset: 0x00329778
		public ShareReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003654 RID: 13908
		// (get) Token: 0x0600D864 RID: 55396 RVA: 0x0032B588 File Offset: 0x00329788
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

		// Token: 0x17003655 RID: 13909
		// (get) Token: 0x0600D865 RID: 55397 RVA: 0x0032B5C4 File Offset: 0x003297C4
		public int ShareType
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

		// Token: 0x0600D866 RID: 55398 RVA: 0x0032B600 File Offset: 0x00329800
		public DicIntInt? Reward(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003656 RID: 13910
		// (get) Token: 0x0600D867 RID: 55399 RVA: 0x0032B660 File Offset: 0x00329860
		public int RewardLength
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

		// Token: 0x17003657 RID: 13911
		// (get) Token: 0x0600D868 RID: 55400 RVA: 0x0032B68C File Offset: 0x0032988C
		public int UpdateType
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

		// Token: 0x0600D869 RID: 55401 RVA: 0x0032B6CC File Offset: 0x003298CC
		[NullableContext(1)]
		public Dictionary<int, int> Reward()
		{
			return this.RewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D86A RID: 55402 RVA: 0x0032B722 File Offset: 0x00329922
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RewardIter()
		{
			ShareReward.<RewardIter>d__18 <RewardIter>d__ = new ShareReward.<RewardIter>d__18(-2);
			<RewardIter>d__.<>3__<>4__this = this;
			return <RewardIter>d__;
		}

		// Token: 0x0600D86B RID: 55403 RVA: 0x0032B738 File Offset: 0x00329938
		public int? GetReward(int key)
		{
			this.EnsureRewardCacheIfNeeded();
			int value;
			if (!this.RewardCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600D86C RID: 55404 RVA: 0x0032B76C File Offset: 0x0032996C
		private void EnsureRewardCacheIfNeeded()
		{
			if (this.RewardCache != null)
			{
				return;
			}
			this.RewardCache = this.RewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D86D RID: 55405 RVA: 0x0032B7D2 File Offset: 0x003299D2
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRewardFrozenDict()
		{
			this.EnsureRewardCacheIfNeeded();
			return this.RewardCache;
		}

		// Token: 0x040057A7 RID: 22439
		private Table __p;

		// Token: 0x040057A8 RID: 22440
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardCache;
	}
}

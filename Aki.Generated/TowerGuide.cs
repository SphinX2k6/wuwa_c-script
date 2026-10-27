using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001141 RID: 4417
	public struct TowerGuide : IFlatbufferObject
	{
		// Token: 0x17003AFC RID: 15100
		// (get) Token: 0x0600E04B RID: 57419 RVA: 0x003311D1 File Offset: 0x0032F3D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E04C RID: 57420 RVA: 0x003311DE File Offset: 0x0032F3DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E04D RID: 57421 RVA: 0x003311E8 File Offset: 0x0032F3E8
		public static TowerGuide GetRootAsTowerGuide(ByteBuffer _bb)
		{
			return TowerGuide.GetRootAsTowerGuide(_bb, default(TowerGuide));
		}

		// Token: 0x0600E04E RID: 57422 RVA: 0x00331204 File Offset: 0x0032F404
		public static TowerGuide GetRootAsTowerGuide(ByteBuffer _bb, TowerGuide obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E04F RID: 57423 RVA: 0x00331221 File Offset: 0x0032F421
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E050 RID: 57424 RVA: 0x00331230 File Offset: 0x0032F430
		public TowerGuide __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003AFD RID: 15101
		// (get) Token: 0x0600E051 RID: 57425 RVA: 0x00331240 File Offset: 0x0032F440
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

		// Token: 0x17003AFE RID: 15102
		// (get) Token: 0x0600E052 RID: 57426 RVA: 0x0033127C File Offset: 0x0032F47C
		public int Difficulty
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

		// Token: 0x0600E053 RID: 57427 RVA: 0x003312B8 File Offset: 0x0032F4B8
		public DicIntInt? RewardItem(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003AFF RID: 15103
		// (get) Token: 0x0600E054 RID: 57428 RVA: 0x00331318 File Offset: 0x0032F518
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

		// Token: 0x17003B00 RID: 15104
		// (get) Token: 0x0600E055 RID: 57429 RVA: 0x00331344 File Offset: 0x0032F544
		public int TrialRoleId
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

		// Token: 0x17003B01 RID: 15105
		// (get) Token: 0x0600E056 RID: 57430 RVA: 0x00331384 File Offset: 0x0032F584
		public int MapMark
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

		// Token: 0x0600E057 RID: 57431 RVA: 0x003313C4 File Offset: 0x0032F5C4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RewardItemFrozenDict()缓存字典，遍历请使用RewardItemIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> RewardItem()
		{
			return this.RewardItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600E058 RID: 57432 RVA: 0x0033141A File Offset: 0x0032F61A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RewardItemIter()
		{
			TowerGuide.<RewardItemIter>d__20 <RewardItemIter>d__ = new TowerGuide.<RewardItemIter>d__20(-2);
			<RewardItemIter>d__.<>3__<>4__this = this;
			return <RewardItemIter>d__;
		}

		// Token: 0x0600E059 RID: 57433 RVA: 0x00331430 File Offset: 0x0032F630
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

		// Token: 0x0600E05A RID: 57434 RVA: 0x00331464 File Offset: 0x0032F664
		private void EnsureRewardItemCacheIfNeeded()
		{
			if (this.RewardItemCache != null)
			{
				return;
			}
			this.RewardItemCache = this.RewardItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600E05B RID: 57435 RVA: 0x003314CA File Offset: 0x0032F6CA
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRewardItemFrozenDict(int key)
		{
			this.EnsureRewardItemCacheIfNeeded();
			return this.RewardItemCache;
		}

		// Token: 0x04005282 RID: 21122
		private Table __p;

		// Token: 0x04005283 RID: 21123
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardItemCache;
	}
}

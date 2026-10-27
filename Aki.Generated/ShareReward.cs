using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200109B RID: 4251
	public struct ShareReward : IFlatbufferObject
	{
		// Token: 0x17003545 RID: 13637
		// (get) Token: 0x0600D088 RID: 53384 RVA: 0x0030BF59 File Offset: 0x0030A159
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D089 RID: 53385 RVA: 0x0030BF66 File Offset: 0x0030A166
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D08A RID: 53386 RVA: 0x0030BF70 File Offset: 0x0030A170
		public static ShareReward GetRootAsShareReward(ByteBuffer _bb)
		{
			return ShareReward.GetRootAsShareReward(_bb, default(ShareReward));
		}

		// Token: 0x0600D08B RID: 53387 RVA: 0x0030BF8C File Offset: 0x0030A18C
		public static ShareReward GetRootAsShareReward(ByteBuffer _bb, ShareReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D08C RID: 53388 RVA: 0x0030BFA9 File Offset: 0x0030A1A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D08D RID: 53389 RVA: 0x0030BFB8 File Offset: 0x0030A1B8
		public ShareReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003546 RID: 13638
		// (get) Token: 0x0600D08E RID: 53390 RVA: 0x0030BFC8 File Offset: 0x0030A1C8
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

		// Token: 0x17003547 RID: 13639
		// (get) Token: 0x0600D08F RID: 53391 RVA: 0x0030C004 File Offset: 0x0030A204
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

		// Token: 0x0600D090 RID: 53392 RVA: 0x0030C040 File Offset: 0x0030A240
		public DicIntInt? Reward(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003548 RID: 13640
		// (get) Token: 0x0600D091 RID: 53393 RVA: 0x0030C0A0 File Offset: 0x0030A2A0
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

		// Token: 0x17003549 RID: 13641
		// (get) Token: 0x0600D092 RID: 53394 RVA: 0x0030C0CC File Offset: 0x0030A2CC
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

		// Token: 0x0600D093 RID: 53395 RVA: 0x0030C10C File Offset: 0x0030A30C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RewardFrozenDict()缓存字典，遍历请使用RewardIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Reward()
		{
			return this.RewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D094 RID: 53396 RVA: 0x0030C162 File Offset: 0x0030A362
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RewardIter()
		{
			ShareReward.<RewardIter>d__18 <RewardIter>d__ = new ShareReward.<RewardIter>d__18(-2);
			<RewardIter>d__.<>3__<>4__this = this;
			return <RewardIter>d__;
		}

		// Token: 0x0600D095 RID: 53397 RVA: 0x0030C178 File Offset: 0x0030A378
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

		// Token: 0x0600D096 RID: 53398 RVA: 0x0030C1AC File Offset: 0x0030A3AC
		private void EnsureRewardCacheIfNeeded()
		{
			if (this.RewardCache != null)
			{
				return;
			}
			this.RewardCache = this.RewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D097 RID: 53399 RVA: 0x0030C212 File Offset: 0x0030A412
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRewardFrozenDict(int key)
		{
			this.EnsureRewardCacheIfNeeded();
			return this.RewardCache;
		}

		// Token: 0x040051A8 RID: 20904
		private Table __p;

		// Token: 0x040051A9 RID: 20905
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardCache;
	}
}

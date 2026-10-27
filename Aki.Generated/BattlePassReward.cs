using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B2A RID: 2858
	public struct BattlePassReward : IFlatbufferObject
	{
		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06004C89 RID: 19593 RVA: 0x001E1CBE File Offset: 0x001DFEBE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004C8A RID: 19594 RVA: 0x001E1CCB File Offset: 0x001DFECB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004C8B RID: 19595 RVA: 0x001E1CD4 File Offset: 0x001DFED4
		public static BattlePassReward GetRootAsBattlePassReward(ByteBuffer _bb)
		{
			return BattlePassReward.GetRootAsBattlePassReward(_bb, default(BattlePassReward));
		}

		// Token: 0x06004C8C RID: 19596 RVA: 0x001E1CF0 File Offset: 0x001DFEF0
		public static BattlePassReward GetRootAsBattlePassReward(ByteBuffer _bb, BattlePassReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004C8D RID: 19597 RVA: 0x001E1D0D File Offset: 0x001DFF0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004C8E RID: 19598 RVA: 0x001E1D1C File Offset: 0x001DFF1C
		public BattlePassReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06004C8F RID: 19599 RVA: 0x001E1D2C File Offset: 0x001DFF2C
		public int BattlePassId
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

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06004C90 RID: 19600 RVA: 0x001E1D68 File Offset: 0x001DFF68
		public int Level
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

		// Token: 0x06004C91 RID: 19601 RVA: 0x001E1DA4 File Offset: 0x001DFFA4
		public DicIntInt? FreeReward(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06004C92 RID: 19602 RVA: 0x001E1E04 File Offset: 0x001E0004
		public int FreeRewardLength
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

		// Token: 0x06004C93 RID: 19603 RVA: 0x001E1E30 File Offset: 0x001E0030
		public DicIntInt? PayReward(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06004C94 RID: 19604 RVA: 0x001E1E94 File Offset: 0x001E0094
		public int PayRewardLength
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

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06004C95 RID: 19605 RVA: 0x001E1EC0 File Offset: 0x001E00C0
		public bool IsMilestone
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06004C96 RID: 19606 RVA: 0x001E1F00 File Offset: 0x001E0100
		public bool IsRemind
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06004C97 RID: 19607 RVA: 0x001E1F40 File Offset: 0x001E0140
		[NullableContext(1)]
		[Obsolete("已废弃，请使用FreeRewardFrozenDict()缓存字典，遍历请使用FreeRewardIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> FreeReward()
		{
			return this.FreeRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004C98 RID: 19608 RVA: 0x001E1F96 File Offset: 0x001E0196
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> FreeRewardIter()
		{
			BattlePassReward.<FreeRewardIter>d__23 <FreeRewardIter>d__ = new BattlePassReward.<FreeRewardIter>d__23(-2);
			<FreeRewardIter>d__.<>3__<>4__this = this;
			return <FreeRewardIter>d__;
		}

		// Token: 0x06004C99 RID: 19609 RVA: 0x001E1FAC File Offset: 0x001E01AC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用PayRewardFrozenDict()缓存字典，遍历请使用PayRewardIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> PayReward()
		{
			return this.PayRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004C9A RID: 19610 RVA: 0x001E2002 File Offset: 0x001E0202
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> PayRewardIter()
		{
			BattlePassReward.<PayRewardIter>d__25 <PayRewardIter>d__ = new BattlePassReward.<PayRewardIter>d__25(-2);
			<PayRewardIter>d__.<>3__<>4__this = this;
			return <PayRewardIter>d__;
		}

		// Token: 0x06004C9B RID: 19611 RVA: 0x001E2018 File Offset: 0x001E0218
		public int? GetFreeReward(int key)
		{
			this.EnsureFreeRewardCacheIfNeeded();
			int value;
			if (!this.FreeRewardCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06004C9C RID: 19612 RVA: 0x001E204C File Offset: 0x001E024C
		public int? GetPayReward(int key)
		{
			this.EnsurePayRewardCacheIfNeeded();
			int value;
			if (!this.PayRewardCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06004C9D RID: 19613 RVA: 0x001E2080 File Offset: 0x001E0280
		private void EnsureFreeRewardCacheIfNeeded()
		{
			if (this.FreeRewardCache != null)
			{
				return;
			}
			this.FreeRewardCache = this.FreeRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004C9E RID: 19614 RVA: 0x001E20E8 File Offset: 0x001E02E8
		private void EnsurePayRewardCacheIfNeeded()
		{
			if (this.PayRewardCache != null)
			{
				return;
			}
			this.PayRewardCache = this.PayRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004C9F RID: 19615 RVA: 0x001E214E File Offset: 0x001E034E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetFreeRewardFrozenDict(int key)
		{
			this.EnsureFreeRewardCacheIfNeeded();
			return this.FreeRewardCache;
		}

		// Token: 0x06004CA0 RID: 19616 RVA: 0x001E215C File Offset: 0x001E035C
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetPayRewardFrozenDict(int key)
		{
			this.EnsurePayRewardCacheIfNeeded();
			return this.PayRewardCache;
		}

		// Token: 0x04004B1E RID: 19230
		private Table __p;

		// Token: 0x04004B1F RID: 19231
		[Nullable(2)]
		private FrozenDictionary<int, int> FreeRewardCache;

		// Token: 0x04004B20 RID: 19232
		[Nullable(2)]
		private FrozenDictionary<int, int> PayRewardCache;
	}
}

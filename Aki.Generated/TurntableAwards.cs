using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200117D RID: 4477
	public struct TurntableAwards : IFlatbufferObject
	{
		// Token: 0x17003D01 RID: 15617
		// (get) Token: 0x0600E5B4 RID: 58804 RVA: 0x0033D604 File Offset: 0x0033B804
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E5B5 RID: 58805 RVA: 0x0033D611 File Offset: 0x0033B811
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E5B6 RID: 58806 RVA: 0x0033D618 File Offset: 0x0033B818
		public static TurntableAwards GetRootAsTurntableAwards(ByteBuffer _bb)
		{
			return TurntableAwards.GetRootAsTurntableAwards(_bb, default(TurntableAwards));
		}

		// Token: 0x0600E5B7 RID: 58807 RVA: 0x0033D634 File Offset: 0x0033B834
		public static TurntableAwards GetRootAsTurntableAwards(ByteBuffer _bb, TurntableAwards obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E5B8 RID: 58808 RVA: 0x0033D651 File Offset: 0x0033B851
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E5B9 RID: 58809 RVA: 0x0033D660 File Offset: 0x0033B860
		public TurntableAwards __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D02 RID: 15618
		// (get) Token: 0x0600E5BA RID: 58810 RVA: 0x0033D670 File Offset: 0x0033B870
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

		// Token: 0x17003D03 RID: 15619
		// (get) Token: 0x0600E5BB RID: 58811 RVA: 0x0033D6AC File Offset: 0x0033B8AC
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

		// Token: 0x17003D04 RID: 15620
		// (get) Token: 0x0600E5BC RID: 58812 RVA: 0x0033D6E8 File Offset: 0x0033B8E8
		public int GroupId
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

		// Token: 0x0600E5BD RID: 58813 RVA: 0x0033D724 File Offset: 0x0033B924
		public DicIntInt? RewardItem(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003D05 RID: 15621
		// (get) Token: 0x0600E5BE RID: 58814 RVA: 0x0033D788 File Offset: 0x0033B988
		public int RewardItemLength
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

		// Token: 0x17003D06 RID: 15622
		// (get) Token: 0x0600E5BF RID: 58815 RVA: 0x0033D7B4 File Offset: 0x0033B9B4
		public bool IsSpecial
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600E5C0 RID: 58816 RVA: 0x0033D7F4 File Offset: 0x0033B9F4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RewardItemFrozenDict()缓存字典，遍历请使用RewardItemIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> RewardItem()
		{
			return this.RewardItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600E5C1 RID: 58817 RVA: 0x0033D84A File Offset: 0x0033BA4A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RewardItemIter()
		{
			TurntableAwards.<RewardItemIter>d__20 <RewardItemIter>d__ = new TurntableAwards.<RewardItemIter>d__20(-2);
			<RewardItemIter>d__.<>3__<>4__this = this;
			return <RewardItemIter>d__;
		}

		// Token: 0x0600E5C2 RID: 58818 RVA: 0x0033D860 File Offset: 0x0033BA60
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

		// Token: 0x0600E5C3 RID: 58819 RVA: 0x0033D894 File Offset: 0x0033BA94
		private void EnsureRewardItemCacheIfNeeded()
		{
			if (this.RewardItemCache != null)
			{
				return;
			}
			this.RewardItemCache = this.RewardItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600E5C4 RID: 58820 RVA: 0x0033D8FA File Offset: 0x0033BAFA
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRewardItemFrozenDict(int key)
		{
			this.EnsureRewardItemCacheIfNeeded();
			return this.RewardItemCache;
		}

		// Token: 0x040052C3 RID: 21187
		private Table __p;

		// Token: 0x040052C4 RID: 21188
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardItemCache;
	}
}

using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CF1 RID: 3313
	public struct GatherActivity : IFlatbufferObject
	{
		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x060079A5 RID: 31141 RVA: 0x002494E5 File Offset: 0x002476E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060079A6 RID: 31142 RVA: 0x002494F2 File Offset: 0x002476F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060079A7 RID: 31143 RVA: 0x002494FC File Offset: 0x002476FC
		public static GatherActivity GetRootAsGatherActivity(ByteBuffer _bb)
		{
			return GatherActivity.GetRootAsGatherActivity(_bb, default(GatherActivity));
		}

		// Token: 0x060079A8 RID: 31144 RVA: 0x00249518 File Offset: 0x00247718
		public static GatherActivity GetRootAsGatherActivity(ByteBuffer _bb, GatherActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060079A9 RID: 31145 RVA: 0x00249535 File Offset: 0x00247735
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060079AA RID: 31146 RVA: 0x00249544 File Offset: 0x00247744
		public GatherActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x060079AB RID: 31147 RVA: 0x00249554 File Offset: 0x00247754
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

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x060079AC RID: 31148 RVA: 0x00249590 File Offset: 0x00247790
		public int PlayTask
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

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x060079AD RID: 31149 RVA: 0x002495CC File Offset: 0x002477CC
		public string TaskClue
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060079AE RID: 31150 RVA: 0x00249603 File Offset: 0x00247803
		public Span<byte> GetTaskClueBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060079AF RID: 31151 RVA: 0x00249612 File Offset: 0x00247812
		public byte[] GetTaskClueArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x060079B0 RID: 31152 RVA: 0x0024962C File Offset: 0x0024782C
		public DicIntInt? SubmitItem(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x060079B1 RID: 31153 RVA: 0x00249690 File Offset: 0x00247890
		public int SubmitItemLength
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

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x060079B2 RID: 31154 RVA: 0x002496BC File Offset: 0x002478BC
		public int Reward
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

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x060079B3 RID: 31155 RVA: 0x002496FC File Offset: 0x002478FC
		public int LocationEntityConfigId
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

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x060079B4 RID: 31156 RVA: 0x0024973C File Offset: 0x0024793C
		public int MarkId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060079B5 RID: 31157 RVA: 0x0024977C File Offset: 0x0024797C
		public DicIntInt? RewardItem(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x060079B6 RID: 31158 RVA: 0x002497E0 File Offset: 0x002479E0
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

		// Token: 0x060079B7 RID: 31159 RVA: 0x0024980C File Offset: 0x00247A0C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RewardItemFrozenDict()缓存字典，遍历请使用RewardItemIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> RewardItem()
		{
			return this.RewardItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060079B8 RID: 31160 RVA: 0x00249862 File Offset: 0x00247A62
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RewardItemIter()
		{
			GatherActivity.<RewardItemIter>d__29 <RewardItemIter>d__ = new GatherActivity.<RewardItemIter>d__29(-2);
			<RewardItemIter>d__.<>3__<>4__this = this;
			return <RewardItemIter>d__;
		}

		// Token: 0x060079B9 RID: 31161 RVA: 0x00249878 File Offset: 0x00247A78
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SubmitItemFrozenDict()缓存字典，遍历请使用SubmitItemIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> SubmitItem()
		{
			return this.SubmitItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060079BA RID: 31162 RVA: 0x002498CE File Offset: 0x00247ACE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> SubmitItemIter()
		{
			GatherActivity.<SubmitItemIter>d__31 <SubmitItemIter>d__ = new GatherActivity.<SubmitItemIter>d__31(-2);
			<SubmitItemIter>d__.<>3__<>4__this = this;
			return <SubmitItemIter>d__;
		}

		// Token: 0x060079BB RID: 31163 RVA: 0x002498E4 File Offset: 0x00247AE4
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

		// Token: 0x060079BC RID: 31164 RVA: 0x00249918 File Offset: 0x00247B18
		public int? GetSubmitItem(int key)
		{
			this.EnsureSubmitItemCacheIfNeeded();
			int value;
			if (!this.SubmitItemCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060079BD RID: 31165 RVA: 0x0024994C File Offset: 0x00247B4C
		private void EnsureRewardItemCacheIfNeeded()
		{
			if (this.RewardItemCache != null)
			{
				return;
			}
			this.RewardItemCache = this.RewardItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060079BE RID: 31166 RVA: 0x002499B4 File Offset: 0x00247BB4
		private void EnsureSubmitItemCacheIfNeeded()
		{
			if (this.SubmitItemCache != null)
			{
				return;
			}
			this.SubmitItemCache = this.SubmitItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060079BF RID: 31167 RVA: 0x00249A1A File Offset: 0x00247C1A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRewardItemFrozenDict(int key)
		{
			this.EnsureRewardItemCacheIfNeeded();
			return this.RewardItemCache;
		}

		// Token: 0x060079C0 RID: 31168 RVA: 0x00249A28 File Offset: 0x00247C28
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetSubmitItemFrozenDict(int key)
		{
			this.EnsureSubmitItemCacheIfNeeded();
			return this.SubmitItemCache;
		}

		// Token: 0x04004D62 RID: 19810
		private Table __p;

		// Token: 0x04004D63 RID: 19811
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardItemCache;

		// Token: 0x04004D64 RID: 19812
		[Nullable(2)]
		private FrozenDictionary<int, int> SubmitItemCache;
	}
}

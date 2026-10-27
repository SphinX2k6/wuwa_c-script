using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AC4 RID: 2756
	public struct ActivityLinkage : IFlatbufferObject
	{
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600434F RID: 17231 RVA: 0x001CBFF4 File Offset: 0x001CA1F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004350 RID: 17232 RVA: 0x001CC001 File Offset: 0x001CA201
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004351 RID: 17233 RVA: 0x001CC008 File Offset: 0x001CA208
		public static ActivityLinkage GetRootAsActivityLinkage(ByteBuffer _bb)
		{
			return ActivityLinkage.GetRootAsActivityLinkage(_bb, default(ActivityLinkage));
		}

		// Token: 0x06004352 RID: 17234 RVA: 0x001CC024 File Offset: 0x001CA224
		public static ActivityLinkage GetRootAsActivityLinkage(ByteBuffer _bb, ActivityLinkage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004353 RID: 17235 RVA: 0x001CC041 File Offset: 0x001CA241
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x001CC050 File Offset: 0x001CA250
		public ActivityLinkage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06004355 RID: 17237 RVA: 0x001CC060 File Offset: 0x001CA260
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

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06004356 RID: 17238 RVA: 0x001CC09C File Offset: 0x001CA29C
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

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06004357 RID: 17239 RVA: 0x001CC0D8 File Offset: 0x001CA2D8
		public int Index
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

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06004358 RID: 17240 RVA: 0x001CC114 File Offset: 0x001CA314
		public string TabName
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x001CC14C File Offset: 0x001CA34C
		public Span<byte> GetTabNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x001CC15C File Offset: 0x001CA35C
		public byte[] GetTabNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600435B RID: 17243 RVA: 0x001CC174 File Offset: 0x001CA374
		public bool Show
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600435C RID: 17244 RVA: 0x001CC1B4 File Offset: 0x001CA3B4
		public DicIntInt? Reward(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600435D RID: 17245 RVA: 0x001CC218 File Offset: 0x001CA418
		public int RewardLength
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

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600435E RID: 17246 RVA: 0x001CC244 File Offset: 0x001CA444
		public int Rank
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

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600435F RID: 17247 RVA: 0x001CC284 File Offset: 0x001CA484
		public string BgImage
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x001CC2BC File Offset: 0x001CA4BC
		public Span<byte> GetBgImageBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004361 RID: 17249 RVA: 0x001CC2CC File Offset: 0x001CA4CC
		public byte[] GetBgImageArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06004362 RID: 17250 RVA: 0x001CC2E4 File Offset: 0x001CA4E4
		public string SmallImage
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004363 RID: 17251 RVA: 0x001CC31C File Offset: 0x001CA51C
		public Span<byte> GetSmallImageBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06004364 RID: 17252 RVA: 0x001CC32C File Offset: 0x001CA52C
		public byte[] GetSmallImageArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x06004365 RID: 17253 RVA: 0x001CC344 File Offset: 0x001CA544
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RewardFrozenDict()缓存字典，遍历请使用RewardIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Reward()
		{
			return this.RewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004366 RID: 17254 RVA: 0x001CC39A File Offset: 0x001CA59A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RewardIter()
		{
			ActivityLinkage.<RewardIter>d__34 <RewardIter>d__ = new ActivityLinkage.<RewardIter>d__34(-2);
			<RewardIter>d__.<>3__<>4__this = this;
			return <RewardIter>d__;
		}

		// Token: 0x06004367 RID: 17255 RVA: 0x001CC3B0 File Offset: 0x001CA5B0
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

		// Token: 0x06004368 RID: 17256 RVA: 0x001CC3E4 File Offset: 0x001CA5E4
		private void EnsureRewardCacheIfNeeded()
		{
			if (this.RewardCache != null)
			{
				return;
			}
			this.RewardCache = this.RewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004369 RID: 17257 RVA: 0x001CC44A File Offset: 0x001CA64A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRewardFrozenDict(int key)
		{
			this.EnsureRewardCacheIfNeeded();
			return this.RewardCache;
		}

		// Token: 0x04004AA0 RID: 19104
		private Table __p;

		// Token: 0x04004AA1 RID: 19105
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardCache;
	}
}

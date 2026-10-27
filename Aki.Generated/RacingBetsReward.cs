using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F90 RID: 3984
	public struct RacingBetsReward : IFlatbufferObject
	{
		// Token: 0x17002CCC RID: 11468
		// (get) Token: 0x0600B89E RID: 47262 RVA: 0x002D65B0 File Offset: 0x002D47B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B89F RID: 47263 RVA: 0x002D65BD File Offset: 0x002D47BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B8A0 RID: 47264 RVA: 0x002D65C4 File Offset: 0x002D47C4
		public static RacingBetsReward GetRootAsRacingBetsReward(ByteBuffer _bb)
		{
			return RacingBetsReward.GetRootAsRacingBetsReward(_bb, default(RacingBetsReward));
		}

		// Token: 0x0600B8A1 RID: 47265 RVA: 0x002D65E0 File Offset: 0x002D47E0
		public static RacingBetsReward GetRootAsRacingBetsReward(ByteBuffer _bb, RacingBetsReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B8A2 RID: 47266 RVA: 0x002D65FD File Offset: 0x002D47FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B8A3 RID: 47267 RVA: 0x002D660C File Offset: 0x002D480C
		public RacingBetsReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002CCD RID: 11469
		// (get) Token: 0x0600B8A4 RID: 47268 RVA: 0x002D661C File Offset: 0x002D481C
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

		// Token: 0x17002CCE RID: 11470
		// (get) Token: 0x0600B8A5 RID: 47269 RVA: 0x002D6658 File Offset: 0x002D4858
		public int SeasonId
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

		// Token: 0x17002CCF RID: 11471
		// (get) Token: 0x0600B8A6 RID: 47270 RVA: 0x002D6694 File Offset: 0x002D4894
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

		// Token: 0x17002CD0 RID: 11472
		// (get) Token: 0x0600B8A7 RID: 47271 RVA: 0x002D66D0 File Offset: 0x002D48D0
		public string RewardName
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

		// Token: 0x0600B8A8 RID: 47272 RVA: 0x002D6708 File Offset: 0x002D4908
		public Span<byte> GetRewardNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B8A9 RID: 47273 RVA: 0x002D6718 File Offset: 0x002D4918
		public byte[] GetRewardNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002CD1 RID: 11473
		// (get) Token: 0x0600B8AA RID: 47274 RVA: 0x002D6730 File Offset: 0x002D4930
		public int ResetType
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

		// Token: 0x17002CD2 RID: 11474
		// (get) Token: 0x0600B8AB RID: 47275 RVA: 0x002D6770 File Offset: 0x002D4970
		public int RewardType
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

		// Token: 0x0600B8AC RID: 47276 RVA: 0x002D67B0 File Offset: 0x002D49B0
		public DicIntInt? TargetReward(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002CD3 RID: 11475
		// (get) Token: 0x0600B8AD RID: 47277 RVA: 0x002D6814 File Offset: 0x002D4A14
		public int TargetRewardLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B8AE RID: 47278 RVA: 0x002D6840 File Offset: 0x002D4A40
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TargetRewardFrozenDict()缓存字典，遍历请使用TargetRewardIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> TargetReward()
		{
			return this.TargetRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600B8AF RID: 47279 RVA: 0x002D6896 File Offset: 0x002D4A96
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> TargetRewardIter()
		{
			RacingBetsReward.<TargetRewardIter>d__26 <TargetRewardIter>d__ = new RacingBetsReward.<TargetRewardIter>d__26(-2);
			<TargetRewardIter>d__.<>3__<>4__this = this;
			return <TargetRewardIter>d__;
		}

		// Token: 0x0600B8B0 RID: 47280 RVA: 0x002D68AC File Offset: 0x002D4AAC
		public int? GetTargetReward(int key)
		{
			this.EnsureTargetRewardCacheIfNeeded();
			int value;
			if (!this.TargetRewardCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600B8B1 RID: 47281 RVA: 0x002D68E0 File Offset: 0x002D4AE0
		private void EnsureTargetRewardCacheIfNeeded()
		{
			if (this.TargetRewardCache != null)
			{
				return;
			}
			this.TargetRewardCache = this.TargetRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600B8B2 RID: 47282 RVA: 0x002D6946 File Offset: 0x002D4B46
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetTargetRewardFrozenDict(int key)
		{
			this.EnsureTargetRewardCacheIfNeeded();
			return this.TargetRewardCache;
		}

		// Token: 0x0400505F RID: 20575
		private Table __p;

		// Token: 0x04005060 RID: 20576
		[Nullable(2)]
		private FrozenDictionary<int, int> TargetRewardCache;
	}
}

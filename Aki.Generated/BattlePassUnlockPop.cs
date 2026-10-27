using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B2C RID: 2860
	public struct BattlePassUnlockPop : IFlatbufferObject
	{
		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06004CB4 RID: 19636 RVA: 0x001E2494 File Offset: 0x001E0694
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004CB5 RID: 19637 RVA: 0x001E24A1 File Offset: 0x001E06A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004CB6 RID: 19638 RVA: 0x001E24A8 File Offset: 0x001E06A8
		public static BattlePassUnlockPop GetRootAsBattlePassUnlockPop(ByteBuffer _bb)
		{
			return BattlePassUnlockPop.GetRootAsBattlePassUnlockPop(_bb, default(BattlePassUnlockPop));
		}

		// Token: 0x06004CB7 RID: 19639 RVA: 0x001E24C4 File Offset: 0x001E06C4
		public static BattlePassUnlockPop GetRootAsBattlePassUnlockPop(ByteBuffer _bb, BattlePassUnlockPop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004CB8 RID: 19640 RVA: 0x001E24E1 File Offset: 0x001E06E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004CB9 RID: 19641 RVA: 0x001E24F0 File Offset: 0x001E06F0
		public BattlePassUnlockPop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06004CBA RID: 19642 RVA: 0x001E2500 File Offset: 0x001E0700
		public int TpyeID
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

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06004CBB RID: 19643 RVA: 0x001E253C File Offset: 0x001E073C
		public string UnlockTitle
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004CBC RID: 19644 RVA: 0x001E2573 File Offset: 0x001E0773
		public Span<byte> GetUnlockTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004CBD RID: 19645 RVA: 0x001E2582 File Offset: 0x001E0782
		public byte[] GetUnlockTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06004CBE RID: 19646 RVA: 0x001E259C File Offset: 0x001E079C
		public string UnlockText
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

		// Token: 0x06004CBF RID: 19647 RVA: 0x001E25D3 File Offset: 0x001E07D3
		public Span<byte> GetUnlockTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004CC0 RID: 19648 RVA: 0x001E25E2 File Offset: 0x001E07E2
		public byte[] GetUnlockTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06004CC1 RID: 19649 RVA: 0x001E25FC File Offset: 0x001E07FC
		public DicIntInt? UnlockReward(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06004CC2 RID: 19650 RVA: 0x001E2660 File Offset: 0x001E0860
		public int UnlockRewardLength
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

		// Token: 0x06004CC3 RID: 19651 RVA: 0x001E268C File Offset: 0x001E088C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用UnlockRewardFrozenDict()缓存字典，遍历请使用UnlockRewardIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> UnlockReward()
		{
			return this.UnlockRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004CC4 RID: 19652 RVA: 0x001E26E2 File Offset: 0x001E08E2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> UnlockRewardIter()
		{
			BattlePassUnlockPop.<UnlockRewardIter>d__22 <UnlockRewardIter>d__ = new BattlePassUnlockPop.<UnlockRewardIter>d__22(-2);
			<UnlockRewardIter>d__.<>3__<>4__this = this;
			return <UnlockRewardIter>d__;
		}

		// Token: 0x06004CC5 RID: 19653 RVA: 0x001E26F8 File Offset: 0x001E08F8
		public int? GetUnlockReward(int key)
		{
			this.EnsureUnlockRewardCacheIfNeeded();
			int value;
			if (!this.UnlockRewardCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06004CC6 RID: 19654 RVA: 0x001E272C File Offset: 0x001E092C
		private void EnsureUnlockRewardCacheIfNeeded()
		{
			if (this.UnlockRewardCache != null)
			{
				return;
			}
			this.UnlockRewardCache = this.UnlockRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004CC7 RID: 19655 RVA: 0x001E2792 File Offset: 0x001E0992
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetUnlockRewardFrozenDict(int key)
		{
			this.EnsureUnlockRewardCacheIfNeeded();
			return this.UnlockRewardCache;
		}

		// Token: 0x04004B23 RID: 19235
		private Table __p;

		// Token: 0x04004B24 RID: 19236
		[Nullable(2)]
		private FrozenDictionary<int, int> UnlockRewardCache;
	}
}

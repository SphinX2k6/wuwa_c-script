using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C7C RID: 3196
	public struct FishingEntrust : IFlatbufferObject
	{
		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x06006F04 RID: 28420 RVA: 0x002304A0 File Offset: 0x0022E6A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006F05 RID: 28421 RVA: 0x002304AD File Offset: 0x0022E6AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006F06 RID: 28422 RVA: 0x002304B4 File Offset: 0x0022E6B4
		public static FishingEntrust GetRootAsFishingEntrust(ByteBuffer _bb)
		{
			return FishingEntrust.GetRootAsFishingEntrust(_bb, default(FishingEntrust));
		}

		// Token: 0x06006F07 RID: 28423 RVA: 0x002304D0 File Offset: 0x0022E6D0
		public static FishingEntrust GetRootAsFishingEntrust(ByteBuffer _bb, FishingEntrust obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006F08 RID: 28424 RVA: 0x002304ED File Offset: 0x0022E6ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006F09 RID: 28425 RVA: 0x002304FC File Offset: 0x0022E6FC
		public FishingEntrust __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x06006F0A RID: 28426 RVA: 0x0023050C File Offset: 0x0022E70C
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

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x06006F0B RID: 28427 RVA: 0x00230548 File Offset: 0x0022E748
		public string Name
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

		// Token: 0x06006F0C RID: 28428 RVA: 0x0023057F File Offset: 0x0022E77F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006F0D RID: 28429 RVA: 0x0023058E File Offset: 0x0022E78E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x06006F0E RID: 28430 RVA: 0x002305A8 File Offset: 0x0022E7A8
		public bool IsNight
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x06006F0F RID: 28431 RVA: 0x002305E8 File Offset: 0x0022E7E8
		public string Desc
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

		// Token: 0x06006F10 RID: 28432 RVA: 0x00230620 File Offset: 0x0022E820
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006F11 RID: 28433 RVA: 0x00230630 File Offset: 0x0022E830
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x06006F12 RID: 28434 RVA: 0x00230648 File Offset: 0x0022E848
		public int PreviewItem
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

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x06006F13 RID: 28435 RVA: 0x00230688 File Offset: 0x0022E888
		public int Star
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

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x06006F14 RID: 28436 RVA: 0x002306C8 File Offset: 0x0022E8C8
		public int EntrustType
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

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x06006F15 RID: 28437 RVA: 0x00230708 File Offset: 0x0022E908
		public int EntrustPool
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x06006F16 RID: 28438 RVA: 0x00230748 File Offset: 0x0022E948
		public int UnlockCondition
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006F17 RID: 28439 RVA: 0x00230788 File Offset: 0x0022E988
		public DicIntInt? EntrustTarget(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x06006F18 RID: 28440 RVA: 0x002307EC File Offset: 0x0022E9EC
		public int EntrustTargetLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x06006F19 RID: 28441 RVA: 0x00230818 File Offset: 0x0022EA18
		public int EntrustDestination
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006F1A RID: 28442 RVA: 0x00230858 File Offset: 0x0022EA58
		public DicIntInt? EntrustReward(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x06006F1B RID: 28443 RVA: 0x002308BC File Offset: 0x0022EABC
		public int EntrustRewardLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x06006F1C RID: 28444 RVA: 0x002308E8 File Offset: 0x0022EAE8
		public int AccessPath
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006F1D RID: 28445 RVA: 0x00230928 File Offset: 0x0022EB28
		public DicIntString? TargetDesText(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x06006F1E RID: 28446 RVA: 0x0023098C File Offset: 0x0022EB8C
		public int TargetDesTextLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006F1F RID: 28447 RVA: 0x002309B8 File Offset: 0x0022EBB8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用EntrustRewardFrozenDict()缓存字典，遍历请使用EntrustRewardIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> EntrustReward()
		{
			return this.EntrustRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006F20 RID: 28448 RVA: 0x00230A0E File Offset: 0x0022EC0E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> EntrustRewardIter()
		{
			FishingEntrust.<EntrustRewardIter>d__44 <EntrustRewardIter>d__ = new FishingEntrust.<EntrustRewardIter>d__44(-2);
			<EntrustRewardIter>d__.<>3__<>4__this = this;
			return <EntrustRewardIter>d__;
		}

		// Token: 0x06006F21 RID: 28449 RVA: 0x00230A24 File Offset: 0x0022EC24
		[NullableContext(1)]
		[Obsolete("已废弃，请使用EntrustTargetFrozenDict()缓存字典，遍历请使用EntrustTargetIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> EntrustTarget()
		{
			return this.EntrustTargetIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006F22 RID: 28450 RVA: 0x00230A7A File Offset: 0x0022EC7A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> EntrustTargetIter()
		{
			FishingEntrust.<EntrustTargetIter>d__46 <EntrustTargetIter>d__ = new FishingEntrust.<EntrustTargetIter>d__46(-2);
			<EntrustTargetIter>d__.<>3__<>4__this = this;
			return <EntrustTargetIter>d__;
		}

		// Token: 0x06006F23 RID: 28451 RVA: 0x00230A90 File Offset: 0x0022EC90
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TargetDesTextFrozenDict()缓存字典，遍历请使用TargetDesTextIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> TargetDesText()
		{
			return this.TargetDesTextIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x06006F24 RID: 28452 RVA: 0x00230AE6 File Offset: 0x0022ECE6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> TargetDesTextIter()
		{
			FishingEntrust.<TargetDesTextIter>d__48 <TargetDesTextIter>d__ = new FishingEntrust.<TargetDesTextIter>d__48(-2);
			<TargetDesTextIter>d__.<>3__<>4__this = this;
			return <TargetDesTextIter>d__;
		}

		// Token: 0x06006F25 RID: 28453 RVA: 0x00230AFC File Offset: 0x0022ECFC
		public int? GetEntrustReward(int key)
		{
			this.EnsureEntrustRewardCacheIfNeeded();
			int value;
			if (!this.EntrustRewardCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06006F26 RID: 28454 RVA: 0x00230B30 File Offset: 0x0022ED30
		public int? GetEntrustTarget(int key)
		{
			this.EnsureEntrustTargetCacheIfNeeded();
			int value;
			if (!this.EntrustTargetCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06006F27 RID: 28455 RVA: 0x00230B64 File Offset: 0x0022ED64
		[NullableContext(2)]
		public string GetTargetDesText(int key)
		{
			this.EnsureTargetDesTextCacheIfNeeded();
			string result;
			if (!this.TargetDesTextCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06006F28 RID: 28456 RVA: 0x00230B8C File Offset: 0x0022ED8C
		private void EnsureEntrustRewardCacheIfNeeded()
		{
			if (this.EntrustRewardCache != null)
			{
				return;
			}
			this.EntrustRewardCache = this.EntrustRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006F29 RID: 28457 RVA: 0x00230BF4 File Offset: 0x0022EDF4
		private void EnsureEntrustTargetCacheIfNeeded()
		{
			if (this.EntrustTargetCache != null)
			{
				return;
			}
			this.EntrustTargetCache = this.EntrustTargetIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006F2A RID: 28458 RVA: 0x00230C5C File Offset: 0x0022EE5C
		private void EnsureTargetDesTextCacheIfNeeded()
		{
			if (this.TargetDesTextCache != null)
			{
				return;
			}
			this.TargetDesTextCache = this.TargetDesTextIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x06006F2B RID: 28459 RVA: 0x00230CC2 File Offset: 0x0022EEC2
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetEntrustRewardFrozenDict(int key)
		{
			this.EnsureEntrustRewardCacheIfNeeded();
			return this.EntrustRewardCache;
		}

		// Token: 0x06006F2C RID: 28460 RVA: 0x00230CD0 File Offset: 0x0022EED0
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetEntrustTargetFrozenDict(int key)
		{
			this.EnsureEntrustTargetCacheIfNeeded();
			return this.EntrustTargetCache;
		}

		// Token: 0x06006F2D RID: 28461 RVA: 0x00230CDE File Offset: 0x0022EEDE
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetTargetDesTextFrozenDict(int key)
		{
			this.EnsureTargetDesTextCacheIfNeeded();
			return this.TargetDesTextCache;
		}

		// Token: 0x04004CC8 RID: 19656
		private Table __p;

		// Token: 0x04004CC9 RID: 19657
		[Nullable(2)]
		private FrozenDictionary<int, int> EntrustRewardCache;

		// Token: 0x04004CCA RID: 19658
		[Nullable(2)]
		private FrozenDictionary<int, int> EntrustTargetCache;

		// Token: 0x04004CCB RID: 19659
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> TargetDesTextCache;
	}
}

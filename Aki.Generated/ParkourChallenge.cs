using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EAB RID: 3755
	public struct ParkourChallenge : IFlatbufferObject
	{
		// Token: 0x1700247C RID: 9340
		// (get) Token: 0x0600A27A RID: 41594 RVA: 0x002A530C File Offset: 0x002A350C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A27B RID: 41595 RVA: 0x002A5319 File Offset: 0x002A3519
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A27C RID: 41596 RVA: 0x002A5320 File Offset: 0x002A3520
		public static ParkourChallenge GetRootAsParkourChallenge(ByteBuffer _bb)
		{
			return ParkourChallenge.GetRootAsParkourChallenge(_bb, default(ParkourChallenge));
		}

		// Token: 0x0600A27D RID: 41597 RVA: 0x002A533C File Offset: 0x002A353C
		public static ParkourChallenge GetRootAsParkourChallenge(ByteBuffer _bb, ParkourChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A27E RID: 41598 RVA: 0x002A5359 File Offset: 0x002A3559
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A27F RID: 41599 RVA: 0x002A5368 File Offset: 0x002A3568
		public ParkourChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700247D RID: 9341
		// (get) Token: 0x0600A280 RID: 41600 RVA: 0x002A5378 File Offset: 0x002A3578
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

		// Token: 0x1700247E RID: 9342
		// (get) Token: 0x0600A281 RID: 41601 RVA: 0x002A53B4 File Offset: 0x002A35B4
		public int MarkId
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

		// Token: 0x1700247F RID: 9343
		// (get) Token: 0x0600A282 RID: 41602 RVA: 0x002A53F0 File Offset: 0x002A35F0
		public string BackGroundTexture
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

		// Token: 0x0600A283 RID: 41603 RVA: 0x002A5427 File Offset: 0x002A3627
		public Span<byte> GetBackGroundTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A284 RID: 41604 RVA: 0x002A5436 File Offset: 0x002A3636
		public byte[] GetBackGroundTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002480 RID: 9344
		// (get) Token: 0x0600A285 RID: 41605 RVA: 0x002A5450 File Offset: 0x002A3650
		public string Title
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

		// Token: 0x0600A286 RID: 41606 RVA: 0x002A5488 File Offset: 0x002A3688
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A287 RID: 41607 RVA: 0x002A5498 File Offset: 0x002A3698
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002481 RID: 9345
		// (get) Token: 0x0600A288 RID: 41608 RVA: 0x002A54B0 File Offset: 0x002A36B0
		public int LevelPlayId
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

		// Token: 0x0600A289 RID: 41609 RVA: 0x002A54F0 File Offset: 0x002A36F0
		public DicIntInt? Rewards(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002482 RID: 9346
		// (get) Token: 0x0600A28A RID: 41610 RVA: 0x002A5554 File Offset: 0x002A3754
		public int RewardsLength
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

		// Token: 0x0600A28B RID: 41611 RVA: 0x002A5580 File Offset: 0x002A3780
		public IntPair? RewardList(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002483 RID: 9347
		// (get) Token: 0x0600A28C RID: 41612 RVA: 0x002A55E4 File Offset: 0x002A37E4
		public int RewardListLength
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

		// Token: 0x17002484 RID: 9348
		// (get) Token: 0x0600A28D RID: 41613 RVA: 0x002A5610 File Offset: 0x002A3810
		public int LocationEntityConfigId
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

		// Token: 0x0600A28E RID: 41614 RVA: 0x002A564D File Offset: 0x002A384D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RewardListIter()或GetRewardListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntPair[] RewardList()
		{
			return this.RewardListIter().ToArray<IntPair>();
		}

		// Token: 0x0600A28F RID: 41615 RVA: 0x002A565A File Offset: 0x002A385A
		[NullableContext(1)]
		public readonly IEnumerable<IntPair> RewardListIter()
		{
			ParkourChallenge.<RewardListIter>d__31 <RewardListIter>d__ = new ParkourChallenge.<RewardListIter>d__31(-2);
			<RewardListIter>d__.<>3__<>4__this = this;
			return <RewardListIter>d__;
		}

		// Token: 0x0600A290 RID: 41616 RVA: 0x002A5670 File Offset: 0x002A3870
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RewardsFrozenDict()缓存字典，遍历请使用RewardsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Rewards()
		{
			return this.RewardsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600A291 RID: 41617 RVA: 0x002A56C6 File Offset: 0x002A38C6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RewardsIter()
		{
			ParkourChallenge.<RewardsIter>d__33 <RewardsIter>d__ = new ParkourChallenge.<RewardsIter>d__33(-2);
			<RewardsIter>d__.<>3__<>4__this = this;
			return <RewardsIter>d__;
		}

		// Token: 0x0600A292 RID: 41618 RVA: 0x002A56DC File Offset: 0x002A38DC
		public int? GetRewards(int key)
		{
			this.EnsureRewardsCacheIfNeeded();
			int value;
			if (!this.RewardsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600A293 RID: 41619 RVA: 0x002A5710 File Offset: 0x002A3910
		private void EnsureRewardsCacheIfNeeded()
		{
			if (this.RewardsCache != null)
			{
				return;
			}
			this.RewardsCache = this.RewardsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600A294 RID: 41620 RVA: 0x002A5776 File Offset: 0x002A3976
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRewardsFrozenDict(int key)
		{
			this.EnsureRewardsCacheIfNeeded();
			return this.RewardsCache;
		}

		// Token: 0x04004F60 RID: 20320
		private Table __p;

		// Token: 0x04004F61 RID: 20321
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardsCache;
	}
}

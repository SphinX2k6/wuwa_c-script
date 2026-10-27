using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E5A RID: 3674
	public struct MotorLinkageQuest : IFlatbufferObject
	{
		// Token: 0x1700219E RID: 8606
		// (get) Token: 0x06009A9C RID: 39580 RVA: 0x00293D6D File Offset: 0x00291F6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009A9D RID: 39581 RVA: 0x00293D7A File Offset: 0x00291F7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009A9E RID: 39582 RVA: 0x00293D84 File Offset: 0x00291F84
		public static MotorLinkageQuest GetRootAsMotorLinkageQuest(ByteBuffer _bb)
		{
			return MotorLinkageQuest.GetRootAsMotorLinkageQuest(_bb, default(MotorLinkageQuest));
		}

		// Token: 0x06009A9F RID: 39583 RVA: 0x00293DA0 File Offset: 0x00291FA0
		public static MotorLinkageQuest GetRootAsMotorLinkageQuest(ByteBuffer _bb, MotorLinkageQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009AA0 RID: 39584 RVA: 0x00293DBD File Offset: 0x00291FBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009AA1 RID: 39585 RVA: 0x00293DCC File Offset: 0x00291FCC
		public MotorLinkageQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700219F RID: 8607
		// (get) Token: 0x06009AA2 RID: 39586 RVA: 0x00293DDC File Offset: 0x00291FDC
		public int TaskId
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

		// Token: 0x170021A0 RID: 8608
		// (get) Token: 0x06009AA3 RID: 39587 RVA: 0x00293E18 File Offset: 0x00292018
		public int Ip
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

		// Token: 0x170021A1 RID: 8609
		// (get) Token: 0x06009AA4 RID: 39588 RVA: 0x00293E54 File Offset: 0x00292054
		public int Sort
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

		// Token: 0x170021A2 RID: 8610
		// (get) Token: 0x06009AA5 RID: 39589 RVA: 0x00293E90 File Offset: 0x00292090
		public string TaskName
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

		// Token: 0x06009AA6 RID: 39590 RVA: 0x00293EC8 File Offset: 0x002920C8
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009AA7 RID: 39591 RVA: 0x00293ED8 File Offset: 0x002920D8
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170021A3 RID: 8611
		// (get) Token: 0x06009AA8 RID: 39592 RVA: 0x00293EF0 File Offset: 0x002920F0
		public int AccessId
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

		// Token: 0x06009AA9 RID: 39593 RVA: 0x00293F30 File Offset: 0x00292130
		public DicIntInt? RewardInfo(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170021A4 RID: 8612
		// (get) Token: 0x06009AAA RID: 39594 RVA: 0x00293F94 File Offset: 0x00292194
		public int RewardInfoLength
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

		// Token: 0x170021A5 RID: 8613
		// (get) Token: 0x06009AAB RID: 39595 RVA: 0x00293FC0 File Offset: 0x002921C0
		public bool HasSticker
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170021A6 RID: 8614
		// (get) Token: 0x06009AAC RID: 39596 RVA: 0x00294000 File Offset: 0x00292200
		public string StickerIcon
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

		// Token: 0x06009AAD RID: 39597 RVA: 0x00294038 File Offset: 0x00292238
		public Span<byte> GetStickerIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009AAE RID: 39598 RVA: 0x00294048 File Offset: 0x00292248
		public byte[] GetStickerIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06009AAF RID: 39599 RVA: 0x00294060 File Offset: 0x00292260
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RewardInfoFrozenDict()缓存字典，遍历请使用RewardInfoIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> RewardInfo()
		{
			return this.RewardInfoIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06009AB0 RID: 39600 RVA: 0x002940B6 File Offset: 0x002922B6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RewardInfoIter()
		{
			MotorLinkageQuest.<RewardInfoIter>d__30 <RewardInfoIter>d__ = new MotorLinkageQuest.<RewardInfoIter>d__30(-2);
			<RewardInfoIter>d__.<>3__<>4__this = this;
			return <RewardInfoIter>d__;
		}

		// Token: 0x06009AB1 RID: 39601 RVA: 0x002940CC File Offset: 0x002922CC
		public int? GetRewardInfo(int key)
		{
			this.EnsureRewardInfoCacheIfNeeded();
			int value;
			if (!this.RewardInfoCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06009AB2 RID: 39602 RVA: 0x00294100 File Offset: 0x00292300
		private void EnsureRewardInfoCacheIfNeeded()
		{
			if (this.RewardInfoCache != null)
			{
				return;
			}
			this.RewardInfoCache = this.RewardInfoIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06009AB3 RID: 39603 RVA: 0x00294166 File Offset: 0x00292366
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRewardInfoFrozenDict(int key)
		{
			this.EnsureRewardInfoCacheIfNeeded();
			return this.RewardInfoCache;
		}

		// Token: 0x04004F03 RID: 20227
		private Table __p;

		// Token: 0x04004F04 RID: 20228
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardInfoCache;
	}
}

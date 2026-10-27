using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E33 RID: 3635
	public struct MotorDecalQuest : IFlatbufferObject
	{
		// Token: 0x17002030 RID: 8240
		// (get) Token: 0x06009705 RID: 38661 RVA: 0x0028BA7D File Offset: 0x00289C7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009706 RID: 38662 RVA: 0x0028BA8A File Offset: 0x00289C8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009707 RID: 38663 RVA: 0x0028BA94 File Offset: 0x00289C94
		public static MotorDecalQuest GetRootAsMotorDecalQuest(ByteBuffer _bb)
		{
			return MotorDecalQuest.GetRootAsMotorDecalQuest(_bb, default(MotorDecalQuest));
		}

		// Token: 0x06009708 RID: 38664 RVA: 0x0028BAB0 File Offset: 0x00289CB0
		public static MotorDecalQuest GetRootAsMotorDecalQuest(ByteBuffer _bb, MotorDecalQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009709 RID: 38665 RVA: 0x0028BACD File Offset: 0x00289CCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600970A RID: 38666 RVA: 0x0028BADC File Offset: 0x00289CDC
		public MotorDecalQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002031 RID: 8241
		// (get) Token: 0x0600970B RID: 38667 RVA: 0x0028BAEC File Offset: 0x00289CEC
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

		// Token: 0x17002032 RID: 8242
		// (get) Token: 0x0600970C RID: 38668 RVA: 0x0028BB28 File Offset: 0x00289D28
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

		// Token: 0x17002033 RID: 8243
		// (get) Token: 0x0600970D RID: 38669 RVA: 0x0028BB64 File Offset: 0x00289D64
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

		// Token: 0x17002034 RID: 8244
		// (get) Token: 0x0600970E RID: 38670 RVA: 0x0028BBA0 File Offset: 0x00289DA0
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

		// Token: 0x0600970F RID: 38671 RVA: 0x0028BBD8 File Offset: 0x00289DD8
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009710 RID: 38672 RVA: 0x0028BBE8 File Offset: 0x00289DE8
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002035 RID: 8245
		// (get) Token: 0x06009711 RID: 38673 RVA: 0x0028BC00 File Offset: 0x00289E00
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

		// Token: 0x06009712 RID: 38674 RVA: 0x0028BC40 File Offset: 0x00289E40
		public DicIntInt? RewardInfo(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002036 RID: 8246
		// (get) Token: 0x06009713 RID: 38675 RVA: 0x0028BCA4 File Offset: 0x00289EA4
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

		// Token: 0x06009714 RID: 38676 RVA: 0x0028BCD0 File Offset: 0x00289ED0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RewardInfoFrozenDict()缓存字典，遍历请使用RewardInfoIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> RewardInfo()
		{
			return this.RewardInfoIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06009715 RID: 38677 RVA: 0x0028BD26 File Offset: 0x00289F26
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RewardInfoIter()
		{
			MotorDecalQuest.<RewardInfoIter>d__24 <RewardInfoIter>d__ = new MotorDecalQuest.<RewardInfoIter>d__24(-2);
			<RewardInfoIter>d__.<>3__<>4__this = this;
			return <RewardInfoIter>d__;
		}

		// Token: 0x06009716 RID: 38678 RVA: 0x0028BD3C File Offset: 0x00289F3C
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

		// Token: 0x06009717 RID: 38679 RVA: 0x0028BD70 File Offset: 0x00289F70
		private void EnsureRewardInfoCacheIfNeeded()
		{
			if (this.RewardInfoCache != null)
			{
				return;
			}
			this.RewardInfoCache = this.RewardInfoIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06009718 RID: 38680 RVA: 0x0028BDD6 File Offset: 0x00289FD6
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRewardInfoFrozenDict(int key)
		{
			this.EnsureRewardInfoCacheIfNeeded();
			return this.RewardInfoCache;
		}

		// Token: 0x04004ED8 RID: 20184
		private Table __p;

		// Token: 0x04004ED9 RID: 20185
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardInfoCache;
	}
}

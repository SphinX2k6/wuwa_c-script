using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001064 RID: 4196
	public struct RoleTrialInfo : IFlatbufferObject
	{
		// Token: 0x17003383 RID: 13187
		// (get) Token: 0x0600CB86 RID: 52102 RVA: 0x00301059 File Offset: 0x002FF259
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CB87 RID: 52103 RVA: 0x00301066 File Offset: 0x002FF266
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CB88 RID: 52104 RVA: 0x00301070 File Offset: 0x002FF270
		public static RoleTrialInfo GetRootAsRoleTrialInfo(ByteBuffer _bb)
		{
			return RoleTrialInfo.GetRootAsRoleTrialInfo(_bb, default(RoleTrialInfo));
		}

		// Token: 0x0600CB89 RID: 52105 RVA: 0x0030108C File Offset: 0x002FF28C
		public static RoleTrialInfo GetRootAsRoleTrialInfo(ByteBuffer _bb, RoleTrialInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CB8A RID: 52106 RVA: 0x003010A9 File Offset: 0x002FF2A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CB8B RID: 52107 RVA: 0x003010B8 File Offset: 0x002FF2B8
		public RoleTrialInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003384 RID: 13188
		// (get) Token: 0x0600CB8C RID: 52108 RVA: 0x003010C8 File Offset: 0x002FF2C8
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

		// Token: 0x17003385 RID: 13189
		// (get) Token: 0x0600CB8D RID: 52109 RVA: 0x00301104 File Offset: 0x002FF304
		public int RoleId
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

		// Token: 0x17003386 RID: 13190
		// (get) Token: 0x0600CB8E RID: 52110 RVA: 0x00301140 File Offset: 0x002FF340
		public int TrialRoleId
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

		// Token: 0x17003387 RID: 13191
		// (get) Token: 0x0600CB8F RID: 52111 RVA: 0x0030117C File Offset: 0x002FF37C
		public string InstanceText
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

		// Token: 0x0600CB90 RID: 52112 RVA: 0x003011B4 File Offset: 0x002FF3B4
		public Span<byte> GetInstanceTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CB91 RID: 52113 RVA: 0x003011C4 File Offset: 0x002FF3C4
		public byte[] GetInstanceTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003388 RID: 13192
		// (get) Token: 0x0600CB92 RID: 52114 RVA: 0x003011DC File Offset: 0x002FF3DC
		public int InstanceId
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

		// Token: 0x0600CB93 RID: 52115 RVA: 0x0030121C File Offset: 0x002FF41C
		public DicIntInt? RewardItem(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003389 RID: 13193
		// (get) Token: 0x0600CB94 RID: 52116 RVA: 0x00301280 File Offset: 0x002FF480
		public int RewardItemLength
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

		// Token: 0x1700338A RID: 13194
		// (get) Token: 0x0600CB95 RID: 52117 RVA: 0x003012AC File Offset: 0x002FF4AC
		public int GachaId
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

		// Token: 0x0600CB96 RID: 52118 RVA: 0x003012EC File Offset: 0x002FF4EC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RewardItemFrozenDict()缓存字典，遍历请使用RewardItemIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> RewardItem()
		{
			return this.RewardItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600CB97 RID: 52119 RVA: 0x00301342 File Offset: 0x002FF542
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RewardItemIter()
		{
			RoleTrialInfo.<RewardItemIter>d__26 <RewardItemIter>d__ = new RoleTrialInfo.<RewardItemIter>d__26(-2);
			<RewardItemIter>d__.<>3__<>4__this = this;
			return <RewardItemIter>d__;
		}

		// Token: 0x0600CB98 RID: 52120 RVA: 0x00301358 File Offset: 0x002FF558
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

		// Token: 0x0600CB99 RID: 52121 RVA: 0x0030138C File Offset: 0x002FF58C
		private void EnsureRewardItemCacheIfNeeded()
		{
			if (this.RewardItemCache != null)
			{
				return;
			}
			this.RewardItemCache = this.RewardItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600CB9A RID: 52122 RVA: 0x003013F2 File Offset: 0x002FF5F2
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRewardItemFrozenDict(int key)
		{
			this.EnsureRewardItemCacheIfNeeded();
			return this.RewardItemCache;
		}

		// Token: 0x04005168 RID: 20840
		private Table __p;

		// Token: 0x04005169 RID: 20841
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardItemCache;
	}
}

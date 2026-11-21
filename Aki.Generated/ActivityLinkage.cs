using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B9E RID: 2974
	public struct ActivityLinkage : IFlatbufferObject
	{
		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06004896 RID: 18582 RVA: 0x001EBBD4 File Offset: 0x001E9DD4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004897 RID: 18583 RVA: 0x001EBBE1 File Offset: 0x001E9DE1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004898 RID: 18584 RVA: 0x001EBBE8 File Offset: 0x001E9DE8
		public static ActivityLinkage GetRootAsActivityLinkage(ByteBuffer _bb)
		{
			return ActivityLinkage.GetRootAsActivityLinkage(_bb, default(ActivityLinkage));
		}

		// Token: 0x06004899 RID: 18585 RVA: 0x001EBC04 File Offset: 0x001E9E04
		public static ActivityLinkage GetRootAsActivityLinkage(ByteBuffer _bb, ActivityLinkage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600489A RID: 18586 RVA: 0x001EBC21 File Offset: 0x001E9E21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600489B RID: 18587 RVA: 0x001EBC30 File Offset: 0x001E9E30
		public ActivityLinkage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600489C RID: 18588 RVA: 0x001EBC40 File Offset: 0x001E9E40
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

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600489D RID: 18589 RVA: 0x001EBC7C File Offset: 0x001E9E7C
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

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600489E RID: 18590 RVA: 0x001EBCB8 File Offset: 0x001E9EB8
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

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600489F RID: 18591 RVA: 0x001EBCF4 File Offset: 0x001E9EF4
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

		// Token: 0x060048A0 RID: 18592 RVA: 0x001EBD2C File Offset: 0x001E9F2C
		public Span<byte> GetTabNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060048A1 RID: 18593 RVA: 0x001EBD3C File Offset: 0x001E9F3C
		public byte[] GetTabNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060048A2 RID: 18594 RVA: 0x001EBD54 File Offset: 0x001E9F54
		public bool Show
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060048A3 RID: 18595 RVA: 0x001EBD94 File Offset: 0x001E9F94
		public DicIntInt? Reward(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060048A4 RID: 18596 RVA: 0x001EBDF8 File Offset: 0x001E9FF8
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

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060048A5 RID: 18597 RVA: 0x001EBE24 File Offset: 0x001EA024
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

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060048A6 RID: 18598 RVA: 0x001EBE64 File Offset: 0x001EA064
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

		// Token: 0x060048A7 RID: 18599 RVA: 0x001EBE9C File Offset: 0x001EA09C
		public Span<byte> GetBgImageBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060048A8 RID: 18600 RVA: 0x001EBEAC File Offset: 0x001EA0AC
		public byte[] GetBgImageArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060048A9 RID: 18601 RVA: 0x001EBEC4 File Offset: 0x001EA0C4
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

		// Token: 0x060048AA RID: 18602 RVA: 0x001EBEFC File Offset: 0x001EA0FC
		public Span<byte> GetSmallImageBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060048AB RID: 18603 RVA: 0x001EBF0C File Offset: 0x001EA10C
		public byte[] GetSmallImageArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x060048AC RID: 18604 RVA: 0x001EBF24 File Offset: 0x001EA124
		[NullableContext(1)]
		public Dictionary<int, int> Reward()
		{
			return this.RewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060048AD RID: 18605 RVA: 0x001EBF7A File Offset: 0x001EA17A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RewardIter()
		{
			ActivityLinkage.<RewardIter>d__34 <RewardIter>d__ = new ActivityLinkage.<RewardIter>d__34(-2);
			<RewardIter>d__.<>3__<>4__this = this;
			return <RewardIter>d__;
		}

		// Token: 0x060048AE RID: 18606 RVA: 0x001EBF90 File Offset: 0x001EA190
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

		// Token: 0x060048AF RID: 18607 RVA: 0x001EBFC4 File Offset: 0x001EA1C4
		private void EnsureRewardCacheIfNeeded()
		{
			if (this.RewardCache != null)
			{
				return;
			}
			this.RewardCache = this.RewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060048B0 RID: 18608 RVA: 0x001EC02A File Offset: 0x001EA22A
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRewardFrozenDict()
		{
			this.EnsureRewardCacheIfNeeded();
			return this.RewardCache;
		}

		// Token: 0x0400507A RID: 20602
		private Table __p;

		// Token: 0x0400507B RID: 20603
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardCache;
	}
}

using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012B3 RID: 4787
	public struct TurntableAwards : IFlatbufferObject
	{
		// Token: 0x17004065 RID: 16485
		// (get) Token: 0x0600F322 RID: 62242 RVA: 0x003683FC File Offset: 0x003665FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F323 RID: 62243 RVA: 0x00368409 File Offset: 0x00366609
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F324 RID: 62244 RVA: 0x00368410 File Offset: 0x00366610
		public static TurntableAwards GetRootAsTurntableAwards(ByteBuffer _bb)
		{
			return TurntableAwards.GetRootAsTurntableAwards(_bb, default(TurntableAwards));
		}

		// Token: 0x0600F325 RID: 62245 RVA: 0x0036842C File Offset: 0x0036662C
		public static TurntableAwards GetRootAsTurntableAwards(ByteBuffer _bb, TurntableAwards obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F326 RID: 62246 RVA: 0x00368449 File Offset: 0x00366649
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F327 RID: 62247 RVA: 0x00368458 File Offset: 0x00366658
		public TurntableAwards __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004066 RID: 16486
		// (get) Token: 0x0600F328 RID: 62248 RVA: 0x00368468 File Offset: 0x00366668
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

		// Token: 0x17004067 RID: 16487
		// (get) Token: 0x0600F329 RID: 62249 RVA: 0x003684A4 File Offset: 0x003666A4
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

		// Token: 0x17004068 RID: 16488
		// (get) Token: 0x0600F32A RID: 62250 RVA: 0x003684E0 File Offset: 0x003666E0
		public int GroupId
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

		// Token: 0x0600F32B RID: 62251 RVA: 0x0036851C File Offset: 0x0036671C
		public DicIntInt? RewardItem(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17004069 RID: 16489
		// (get) Token: 0x0600F32C RID: 62252 RVA: 0x00368580 File Offset: 0x00366780
		public int RewardItemLength
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

		// Token: 0x1700406A RID: 16490
		// (get) Token: 0x0600F32D RID: 62253 RVA: 0x003685AC File Offset: 0x003667AC
		public bool IsSpecial
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600F32E RID: 62254 RVA: 0x003685EC File Offset: 0x003667EC
		[NullableContext(1)]
		public Dictionary<int, int> RewardItem()
		{
			return this.RewardItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600F32F RID: 62255 RVA: 0x00368642 File Offset: 0x00366842
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RewardItemIter()
		{
			TurntableAwards.<RewardItemIter>d__20 <RewardItemIter>d__ = new TurntableAwards.<RewardItemIter>d__20(-2);
			<RewardItemIter>d__.<>3__<>4__this = this;
			return <RewardItemIter>d__;
		}

		// Token: 0x0600F330 RID: 62256 RVA: 0x00368658 File Offset: 0x00366858
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

		// Token: 0x0600F331 RID: 62257 RVA: 0x0036868C File Offset: 0x0036688C
		private void EnsureRewardItemCacheIfNeeded()
		{
			if (this.RewardItemCache != null)
			{
				return;
			}
			this.RewardItemCache = this.RewardItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600F332 RID: 62258 RVA: 0x003686F2 File Offset: 0x003668F2
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRewardItemFrozenDict()
		{
			this.EnsureRewardItemCacheIfNeeded();
			return this.RewardItemCache;
		}

		// Token: 0x04005906 RID: 22790
		private Table __p;

		// Token: 0x04005907 RID: 22791
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardItemCache;
	}
}

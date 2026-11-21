using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C0A RID: 3082
	public struct BattlePassReward : IFlatbufferObject
	{
		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x0600524B RID: 21067 RVA: 0x002020BA File Offset: 0x002002BA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600524C RID: 21068 RVA: 0x002020C7 File Offset: 0x002002C7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600524D RID: 21069 RVA: 0x002020D0 File Offset: 0x002002D0
		public static BattlePassReward GetRootAsBattlePassReward(ByteBuffer _bb)
		{
			return BattlePassReward.GetRootAsBattlePassReward(_bb, default(BattlePassReward));
		}

		// Token: 0x0600524E RID: 21070 RVA: 0x002020EC File Offset: 0x002002EC
		public static BattlePassReward GetRootAsBattlePassReward(ByteBuffer _bb, BattlePassReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600524F RID: 21071 RVA: 0x00202109 File Offset: 0x00200309
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005250 RID: 21072 RVA: 0x00202118 File Offset: 0x00200318
		public BattlePassReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06005251 RID: 21073 RVA: 0x00202128 File Offset: 0x00200328
		public int BattlePassId
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

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06005252 RID: 21074 RVA: 0x00202164 File Offset: 0x00200364
		public int Level
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

		// Token: 0x06005253 RID: 21075 RVA: 0x002021A0 File Offset: 0x002003A0
		public DicIntInt? FreeReward(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06005254 RID: 21076 RVA: 0x00202200 File Offset: 0x00200400
		public int FreeRewardLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005255 RID: 21077 RVA: 0x0020222C File Offset: 0x0020042C
		public DicIntInt? PayReward(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06005256 RID: 21078 RVA: 0x00202290 File Offset: 0x00200490
		public int PayRewardLength
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

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06005257 RID: 21079 RVA: 0x002022BC File Offset: 0x002004BC
		public bool IsMilestone
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06005258 RID: 21080 RVA: 0x002022FC File Offset: 0x002004FC
		public bool IsRemind
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06005259 RID: 21081 RVA: 0x0020233C File Offset: 0x0020053C
		[NullableContext(1)]
		public Dictionary<int, int> FreeReward()
		{
			return this.FreeRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600525A RID: 21082 RVA: 0x00202392 File Offset: 0x00200592
		[NullableContext(1)]
		public IEnumerable<DicIntInt> FreeRewardIter()
		{
			BattlePassReward.<FreeRewardIter>d__23 <FreeRewardIter>d__ = new BattlePassReward.<FreeRewardIter>d__23(-2);
			<FreeRewardIter>d__.<>3__<>4__this = this;
			return <FreeRewardIter>d__;
		}

		// Token: 0x0600525B RID: 21083 RVA: 0x002023A8 File Offset: 0x002005A8
		[NullableContext(1)]
		public Dictionary<int, int> PayReward()
		{
			return this.PayRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600525C RID: 21084 RVA: 0x002023FE File Offset: 0x002005FE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> PayRewardIter()
		{
			BattlePassReward.<PayRewardIter>d__25 <PayRewardIter>d__ = new BattlePassReward.<PayRewardIter>d__25(-2);
			<PayRewardIter>d__.<>3__<>4__this = this;
			return <PayRewardIter>d__;
		}

		// Token: 0x0600525D RID: 21085 RVA: 0x00202414 File Offset: 0x00200614
		public int? GetFreeReward(int key)
		{
			this.EnsureFreeRewardCacheIfNeeded();
			int value;
			if (!this.FreeRewardCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600525E RID: 21086 RVA: 0x00202448 File Offset: 0x00200648
		public int? GetPayReward(int key)
		{
			this.EnsurePayRewardCacheIfNeeded();
			int value;
			if (!this.PayRewardCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600525F RID: 21087 RVA: 0x0020247C File Offset: 0x0020067C
		private void EnsureFreeRewardCacheIfNeeded()
		{
			if (this.FreeRewardCache != null)
			{
				return;
			}
			this.FreeRewardCache = this.FreeRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005260 RID: 21088 RVA: 0x002024E4 File Offset: 0x002006E4
		private void EnsurePayRewardCacheIfNeeded()
		{
			if (this.PayRewardCache != null)
			{
				return;
			}
			this.PayRewardCache = this.PayRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005261 RID: 21089 RVA: 0x0020254A File Offset: 0x0020074A
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetFreeRewardFrozenDict()
		{
			this.EnsureFreeRewardCacheIfNeeded();
			return this.FreeRewardCache;
		}

		// Token: 0x06005262 RID: 21090 RVA: 0x00202558 File Offset: 0x00200758
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetPayRewardFrozenDict()
		{
			this.EnsurePayRewardCacheIfNeeded();
			return this.PayRewardCache;
		}

		// Token: 0x040050FE RID: 20734
		private Table __p;

		// Token: 0x040050FF RID: 20735
		[Nullable(2)]
		private FrozenDictionary<int, int> FreeRewardCache;

		// Token: 0x04005100 RID: 20736
		[Nullable(2)]
		private FrozenDictionary<int, int> PayRewardCache;
	}
}

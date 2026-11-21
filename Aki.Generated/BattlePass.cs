using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C09 RID: 3081
	public struct BattlePass : IFlatbufferObject
	{
		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600522A RID: 21034 RVA: 0x00201A2F File Offset: 0x001FFC2F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600522B RID: 21035 RVA: 0x00201A3C File Offset: 0x001FFC3C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600522C RID: 21036 RVA: 0x00201A44 File Offset: 0x001FFC44
		public static BattlePass GetRootAsBattlePass(ByteBuffer _bb)
		{
			return BattlePass.GetRootAsBattlePass(_bb, default(BattlePass));
		}

		// Token: 0x0600522D RID: 21037 RVA: 0x00201A60 File Offset: 0x001FFC60
		public static BattlePass GetRootAsBattlePass(ByteBuffer _bb, BattlePass obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600522E RID: 21038 RVA: 0x00201A7D File Offset: 0x001FFC7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600522F RID: 21039 RVA: 0x00201A8C File Offset: 0x001FFC8C
		public BattlePass __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06005230 RID: 21040 RVA: 0x00201A9C File Offset: 0x001FFC9C
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

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06005231 RID: 21041 RVA: 0x00201AD8 File Offset: 0x001FFCD8
		public int InitialLevel
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

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06005232 RID: 21042 RVA: 0x00201B14 File Offset: 0x001FFD14
		public int BattlePassRewardId
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

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06005233 RID: 21043 RVA: 0x00201B50 File Offset: 0x001FFD50
		public int LevelLimit
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06005234 RID: 21044 RVA: 0x00201B90 File Offset: 0x001FFD90
		public int LevelUpExp
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

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06005235 RID: 21045 RVA: 0x00201BD0 File Offset: 0x001FFDD0
		public int ConsumeId
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

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06005236 RID: 21046 RVA: 0x00201C10 File Offset: 0x001FFE10
		public int ConsumeCount
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

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06005237 RID: 21047 RVA: 0x00201C50 File Offset: 0x001FFE50
		public bool IsRecurringLevel
		{
			get
			{
				int num = this.__p.__offset(18);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06005238 RID: 21048 RVA: 0x00201C90 File Offset: 0x001FFE90
		public DicIntInt? FreeRecurringReward(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06005239 RID: 21049 RVA: 0x00201CF4 File Offset: 0x001FFEF4
		public int FreeRecurringRewardLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600523A RID: 21050 RVA: 0x00201D20 File Offset: 0x001FFF20
		public DicIntInt? PayRecurringReward(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x0600523B RID: 21051 RVA: 0x00201D84 File Offset: 0x001FFF84
		public int PayRecurringRewardLength
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

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600523C RID: 21052 RVA: 0x00201DB0 File Offset: 0x001FFFB0
		public int RecurringLevelExp
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

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600523D RID: 21053 RVA: 0x00201DF0 File Offset: 0x001FFFF0
		public int WeekExpLimit
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x0600523E RID: 21054 RVA: 0x00201E30 File Offset: 0x00200030
		public string ExclusiveRewardPath
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600523F RID: 21055 RVA: 0x00201E68 File Offset: 0x00200068
		public Span<byte> GetExclusiveRewardPathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06005240 RID: 21056 RVA: 0x00201E78 File Offset: 0x00200078
		public byte[] GetExclusiveRewardPathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x06005241 RID: 21057 RVA: 0x00201E90 File Offset: 0x00200090
		[NullableContext(1)]
		public Dictionary<int, int> FreeRecurringReward()
		{
			return this.FreeRecurringRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005242 RID: 21058 RVA: 0x00201EE6 File Offset: 0x002000E6
		[NullableContext(1)]
		public IEnumerable<DicIntInt> FreeRecurringRewardIter()
		{
			BattlePass.<FreeRecurringRewardIter>d__39 <FreeRecurringRewardIter>d__ = new BattlePass.<FreeRecurringRewardIter>d__39(-2);
			<FreeRecurringRewardIter>d__.<>3__<>4__this = this;
			return <FreeRecurringRewardIter>d__;
		}

		// Token: 0x06005243 RID: 21059 RVA: 0x00201EFC File Offset: 0x002000FC
		[NullableContext(1)]
		public Dictionary<int, int> PayRecurringReward()
		{
			return this.PayRecurringRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005244 RID: 21060 RVA: 0x00201F52 File Offset: 0x00200152
		[NullableContext(1)]
		public IEnumerable<DicIntInt> PayRecurringRewardIter()
		{
			BattlePass.<PayRecurringRewardIter>d__41 <PayRecurringRewardIter>d__ = new BattlePass.<PayRecurringRewardIter>d__41(-2);
			<PayRecurringRewardIter>d__.<>3__<>4__this = this;
			return <PayRecurringRewardIter>d__;
		}

		// Token: 0x06005245 RID: 21061 RVA: 0x00201F68 File Offset: 0x00200168
		public int? GetFreeRecurringReward(int key)
		{
			this.EnsureFreeRecurringRewardCacheIfNeeded();
			int value;
			if (!this.FreeRecurringRewardCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06005246 RID: 21062 RVA: 0x00201F9C File Offset: 0x0020019C
		public int? GetPayRecurringReward(int key)
		{
			this.EnsurePayRecurringRewardCacheIfNeeded();
			int value;
			if (!this.PayRecurringRewardCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06005247 RID: 21063 RVA: 0x00201FD0 File Offset: 0x002001D0
		private void EnsureFreeRecurringRewardCacheIfNeeded()
		{
			if (this.FreeRecurringRewardCache != null)
			{
				return;
			}
			this.FreeRecurringRewardCache = this.FreeRecurringRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005248 RID: 21064 RVA: 0x00202038 File Offset: 0x00200238
		private void EnsurePayRecurringRewardCacheIfNeeded()
		{
			if (this.PayRecurringRewardCache != null)
			{
				return;
			}
			this.PayRecurringRewardCache = this.PayRecurringRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005249 RID: 21065 RVA: 0x0020209E File Offset: 0x0020029E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetFreeRecurringRewardFrozenDict()
		{
			this.EnsureFreeRecurringRewardCacheIfNeeded();
			return this.FreeRecurringRewardCache;
		}

		// Token: 0x0600524A RID: 21066 RVA: 0x002020AC File Offset: 0x002002AC
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetPayRecurringRewardFrozenDict()
		{
			this.EnsurePayRecurringRewardCacheIfNeeded();
			return this.PayRecurringRewardCache;
		}

		// Token: 0x040050FB RID: 20731
		private Table __p;

		// Token: 0x040050FC RID: 20732
		[Nullable(2)]
		private FrozenDictionary<int, int> FreeRecurringRewardCache;

		// Token: 0x040050FD RID: 20733
		[Nullable(2)]
		private FrozenDictionary<int, int> PayRecurringRewardCache;
	}
}

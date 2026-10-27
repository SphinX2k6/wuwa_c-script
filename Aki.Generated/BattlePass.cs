using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B29 RID: 2857
	public struct BattlePass : IFlatbufferObject
	{
		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06004C68 RID: 19560 RVA: 0x001E1633 File Offset: 0x001DF833
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004C69 RID: 19561 RVA: 0x001E1640 File Offset: 0x001DF840
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x001E1648 File Offset: 0x001DF848
		public static BattlePass GetRootAsBattlePass(ByteBuffer _bb)
		{
			return BattlePass.GetRootAsBattlePass(_bb, default(BattlePass));
		}

		// Token: 0x06004C6B RID: 19563 RVA: 0x001E1664 File Offset: 0x001DF864
		public static BattlePass GetRootAsBattlePass(ByteBuffer _bb, BattlePass obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004C6C RID: 19564 RVA: 0x001E1681 File Offset: 0x001DF881
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004C6D RID: 19565 RVA: 0x001E1690 File Offset: 0x001DF890
		public BattlePass __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06004C6E RID: 19566 RVA: 0x001E16A0 File Offset: 0x001DF8A0
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

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06004C6F RID: 19567 RVA: 0x001E16DC File Offset: 0x001DF8DC
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

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06004C70 RID: 19568 RVA: 0x001E1718 File Offset: 0x001DF918
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

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06004C71 RID: 19569 RVA: 0x001E1754 File Offset: 0x001DF954
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

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06004C72 RID: 19570 RVA: 0x001E1794 File Offset: 0x001DF994
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

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06004C73 RID: 19571 RVA: 0x001E17D4 File Offset: 0x001DF9D4
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

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06004C74 RID: 19572 RVA: 0x001E1814 File Offset: 0x001DFA14
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

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06004C75 RID: 19573 RVA: 0x001E1854 File Offset: 0x001DFA54
		public bool IsRecurringLevel
		{
			get
			{
				int num = this.__p.__offset(18);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06004C76 RID: 19574 RVA: 0x001E1894 File Offset: 0x001DFA94
		public DicIntInt? FreeRecurringReward(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06004C77 RID: 19575 RVA: 0x001E18F8 File Offset: 0x001DFAF8
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

		// Token: 0x06004C78 RID: 19576 RVA: 0x001E1924 File Offset: 0x001DFB24
		public DicIntInt? PayRecurringReward(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06004C79 RID: 19577 RVA: 0x001E1988 File Offset: 0x001DFB88
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

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06004C7A RID: 19578 RVA: 0x001E19B4 File Offset: 0x001DFBB4
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

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06004C7B RID: 19579 RVA: 0x001E19F4 File Offset: 0x001DFBF4
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

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06004C7C RID: 19580 RVA: 0x001E1A34 File Offset: 0x001DFC34
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

		// Token: 0x06004C7D RID: 19581 RVA: 0x001E1A6C File Offset: 0x001DFC6C
		public Span<byte> GetExclusiveRewardPathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06004C7E RID: 19582 RVA: 0x001E1A7C File Offset: 0x001DFC7C
		public byte[] GetExclusiveRewardPathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x06004C7F RID: 19583 RVA: 0x001E1A94 File Offset: 0x001DFC94
		[NullableContext(1)]
		[Obsolete("已废弃，请使用FreeRecurringRewardFrozenDict()缓存字典，遍历请使用FreeRecurringRewardIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> FreeRecurringReward()
		{
			return this.FreeRecurringRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004C80 RID: 19584 RVA: 0x001E1AEA File Offset: 0x001DFCEA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> FreeRecurringRewardIter()
		{
			BattlePass.<FreeRecurringRewardIter>d__39 <FreeRecurringRewardIter>d__ = new BattlePass.<FreeRecurringRewardIter>d__39(-2);
			<FreeRecurringRewardIter>d__.<>3__<>4__this = this;
			return <FreeRecurringRewardIter>d__;
		}

		// Token: 0x06004C81 RID: 19585 RVA: 0x001E1B00 File Offset: 0x001DFD00
		[NullableContext(1)]
		[Obsolete("已废弃，请使用PayRecurringRewardFrozenDict()缓存字典，遍历请使用PayRecurringRewardIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> PayRecurringReward()
		{
			return this.PayRecurringRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004C82 RID: 19586 RVA: 0x001E1B56 File Offset: 0x001DFD56
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> PayRecurringRewardIter()
		{
			BattlePass.<PayRecurringRewardIter>d__41 <PayRecurringRewardIter>d__ = new BattlePass.<PayRecurringRewardIter>d__41(-2);
			<PayRecurringRewardIter>d__.<>3__<>4__this = this;
			return <PayRecurringRewardIter>d__;
		}

		// Token: 0x06004C83 RID: 19587 RVA: 0x001E1B6C File Offset: 0x001DFD6C
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

		// Token: 0x06004C84 RID: 19588 RVA: 0x001E1BA0 File Offset: 0x001DFDA0
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

		// Token: 0x06004C85 RID: 19589 RVA: 0x001E1BD4 File Offset: 0x001DFDD4
		private void EnsureFreeRecurringRewardCacheIfNeeded()
		{
			if (this.FreeRecurringRewardCache != null)
			{
				return;
			}
			this.FreeRecurringRewardCache = this.FreeRecurringRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004C86 RID: 19590 RVA: 0x001E1C3C File Offset: 0x001DFE3C
		private void EnsurePayRecurringRewardCacheIfNeeded()
		{
			if (this.PayRecurringRewardCache != null)
			{
				return;
			}
			this.PayRecurringRewardCache = this.PayRecurringRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004C87 RID: 19591 RVA: 0x001E1CA2 File Offset: 0x001DFEA2
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetFreeRecurringRewardFrozenDict(int key)
		{
			this.EnsureFreeRecurringRewardCacheIfNeeded();
			return this.FreeRecurringRewardCache;
		}

		// Token: 0x06004C88 RID: 19592 RVA: 0x001E1CB0 File Offset: 0x001DFEB0
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetPayRecurringRewardFrozenDict(int key)
		{
			this.EnsurePayRecurringRewardCacheIfNeeded();
			return this.PayRecurringRewardCache;
		}

		// Token: 0x04004B1B RID: 19227
		private Table __p;

		// Token: 0x04004B1C RID: 19228
		[Nullable(2)]
		private FrozenDictionary<int, int> FreeRecurringRewardCache;

		// Token: 0x04004B1D RID: 19229
		[Nullable(2)]
		private FrozenDictionary<int, int> PayRecurringRewardCache;
	}
}

using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D26 RID: 3366
	[NullableContext(1)]
	[Nullable(0)]
	public struct ExchangeReward : IFlatbufferObject
	{
		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x06007079 RID: 28793 RVA: 0x0024508E File Offset: 0x0024328E
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600707A RID: 28794 RVA: 0x0024509B File Offset: 0x0024329B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600707B RID: 28795 RVA: 0x002450A4 File Offset: 0x002432A4
		[NullableContext(0)]
		public static ExchangeReward GetRootAsExchangeReward(ByteBuffer _bb)
		{
			return ExchangeReward.GetRootAsExchangeReward(_bb, default(ExchangeReward));
		}

		// Token: 0x0600707C RID: 28796 RVA: 0x002450C0 File Offset: 0x002432C0
		[NullableContext(0)]
		public static ExchangeReward GetRootAsExchangeReward(ByteBuffer _bb, ExchangeReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600707D RID: 28797 RVA: 0x002450DD File Offset: 0x002432DD
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600707E RID: 28798 RVA: 0x002450EC File Offset: 0x002432EC
		[NullableContext(0)]
		public ExchangeReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x0600707F RID: 28799 RVA: 0x002450FC File Offset: 0x002432FC
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

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x06007080 RID: 28800 RVA: 0x00245138 File Offset: 0x00243338
		public int SharedId
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

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x06007081 RID: 28801 RVA: 0x00245174 File Offset: 0x00243374
		public int MaxCount
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

		// Token: 0x06007082 RID: 28802 RVA: 0x002451B0 File Offset: 0x002433B0
		public DicIntInt? Cost(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x06007083 RID: 28803 RVA: 0x00245214 File Offset: 0x00243414
		public int CostLength
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

		// Token: 0x06007084 RID: 28804 RVA: 0x00245240 File Offset: 0x00243440
		public DicIntInt? RewardId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x06007085 RID: 28805 RVA: 0x002452A4 File Offset: 0x002434A4
		public int RewardIdLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007086 RID: 28806 RVA: 0x002452D0 File Offset: 0x002434D0
		public DicIntInt? RewardIdCalabash(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x06007087 RID: 28807 RVA: 0x00245334 File Offset: 0x00243534
		public int RewardIdCalabashLength
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

		// Token: 0x06007088 RID: 28808 RVA: 0x00245360 File Offset: 0x00243560
		public DicIntIntIntMap? PreviewReward(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntIntMap?(default(DicIntIntIntMap).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x06007089 RID: 28809 RVA: 0x002453C4 File Offset: 0x002435C4
		public int PreviewRewardLength
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

		// Token: 0x0600708A RID: 28810 RVA: 0x002453F0 File Offset: 0x002435F0
		public Dictionary<int, int> Cost()
		{
			return this.CostIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600708B RID: 28811 RVA: 0x00245446 File Offset: 0x00243646
		public IEnumerable<DicIntInt> CostIter()
		{
			ExchangeReward.<CostIter>d__27 <CostIter>d__ = new ExchangeReward.<CostIter>d__27(-2);
			<CostIter>d__.<>3__<>4__this = this;
			return <CostIter>d__;
		}

		// Token: 0x0600708C RID: 28812 RVA: 0x0024545C File Offset: 0x0024365C
		public Dictionary<int, IntIntMap> PreviewReward()
		{
			return this.PreviewRewardIter().ToDictionary((DicIntIntIntMap element) => element.Key, (DicIntIntIntMap element) => element.Value.Value);
		}

		// Token: 0x0600708D RID: 28813 RVA: 0x002454B2 File Offset: 0x002436B2
		public IEnumerable<DicIntIntIntMap> PreviewRewardIter()
		{
			ExchangeReward.<PreviewRewardIter>d__29 <PreviewRewardIter>d__ = new ExchangeReward.<PreviewRewardIter>d__29(-2);
			<PreviewRewardIter>d__.<>3__<>4__this = this;
			return <PreviewRewardIter>d__;
		}

		// Token: 0x0600708E RID: 28814 RVA: 0x002454C8 File Offset: 0x002436C8
		public Dictionary<int, int> RewardId()
		{
			return this.RewardIdIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600708F RID: 28815 RVA: 0x0024551E File Offset: 0x0024371E
		public IEnumerable<DicIntInt> RewardIdIter()
		{
			ExchangeReward.<RewardIdIter>d__31 <RewardIdIter>d__ = new ExchangeReward.<RewardIdIter>d__31(-2);
			<RewardIdIter>d__.<>3__<>4__this = this;
			return <RewardIdIter>d__;
		}

		// Token: 0x06007090 RID: 28816 RVA: 0x00245534 File Offset: 0x00243734
		public Dictionary<int, int> RewardIdCalabash()
		{
			return this.RewardIdCalabashIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06007091 RID: 28817 RVA: 0x0024558A File Offset: 0x0024378A
		public IEnumerable<DicIntInt> RewardIdCalabashIter()
		{
			ExchangeReward.<RewardIdCalabashIter>d__33 <RewardIdCalabashIter>d__ = new ExchangeReward.<RewardIdCalabashIter>d__33(-2);
			<RewardIdCalabashIter>d__.<>3__<>4__this = this;
			return <RewardIdCalabashIter>d__;
		}

		// Token: 0x06007092 RID: 28818 RVA: 0x002455A0 File Offset: 0x002437A0
		public int? GetCost(int key)
		{
			this.EnsureCostCacheIfNeeded();
			int value;
			if (!this.CostCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06007093 RID: 28819 RVA: 0x002455D4 File Offset: 0x002437D4
		public IntIntMap? GetPreviewReward(int key)
		{
			this.EnsurePreviewRewardCacheIfNeeded();
			IntIntMap value;
			if (!this.PreviewRewardCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntIntMap?(value);
		}

		// Token: 0x06007094 RID: 28820 RVA: 0x00245608 File Offset: 0x00243808
		public int? GetRewardId(int key)
		{
			this.EnsureRewardIdCacheIfNeeded();
			int value;
			if (!this.RewardIdCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06007095 RID: 28821 RVA: 0x0024563C File Offset: 0x0024383C
		public int? GetRewardIdCalabash(int key)
		{
			this.EnsureRewardIdCalabashCacheIfNeeded();
			int value;
			if (!this.RewardIdCalabashCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06007096 RID: 28822 RVA: 0x00245670 File Offset: 0x00243870
		private void EnsureCostCacheIfNeeded()
		{
			if (this.CostCache != null)
			{
				return;
			}
			this.CostCache = this.CostIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007097 RID: 28823 RVA: 0x002456D8 File Offset: 0x002438D8
		private void EnsurePreviewRewardCacheIfNeeded()
		{
			if (this.PreviewRewardCache != null)
			{
				return;
			}
			this.PreviewRewardCache = this.PreviewRewardIter().ToFrozenDictionary((DicIntIntIntMap kvp) => kvp.Key, (DicIntIntIntMap kvp) => kvp.Value.Value, null);
		}

		// Token: 0x06007098 RID: 28824 RVA: 0x00245740 File Offset: 0x00243940
		private void EnsureRewardIdCacheIfNeeded()
		{
			if (this.RewardIdCache != null)
			{
				return;
			}
			this.RewardIdCache = this.RewardIdIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007099 RID: 28825 RVA: 0x002457A8 File Offset: 0x002439A8
		private void EnsureRewardIdCalabashCacheIfNeeded()
		{
			if (this.RewardIdCalabashCache != null)
			{
				return;
			}
			this.RewardIdCalabashCache = this.RewardIdCalabashIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600709A RID: 28826 RVA: 0x0024580E File Offset: 0x00243A0E
		public FrozenDictionary<int, int> GetCostFrozenDict()
		{
			this.EnsureCostCacheIfNeeded();
			return this.CostCache;
		}

		// Token: 0x0600709B RID: 28827 RVA: 0x0024581C File Offset: 0x00243A1C
		public FrozenDictionary<int, IntIntMap> GetPreviewRewardFrozenDict()
		{
			this.EnsurePreviewRewardCacheIfNeeded();
			return this.PreviewRewardCache;
		}

		// Token: 0x0600709C RID: 28828 RVA: 0x0024582A File Offset: 0x00243A2A
		public FrozenDictionary<int, int> GetRewardIdFrozenDict()
		{
			this.EnsureRewardIdCacheIfNeeded();
			return this.RewardIdCache;
		}

		// Token: 0x0600709D RID: 28829 RVA: 0x00245838 File Offset: 0x00243A38
		public FrozenDictionary<int, int> GetRewardIdCalabashFrozenDict()
		{
			this.EnsureRewardIdCalabashCacheIfNeeded();
			return this.RewardIdCalabashCache;
		}

		// Token: 0x04005266 RID: 21094
		private Table __p;

		// Token: 0x04005267 RID: 21095
		[Nullable(2)]
		private FrozenDictionary<int, int> CostCache;

		// Token: 0x04005268 RID: 21096
		[Nullable(2)]
		private FrozenDictionary<int, IntIntMap> PreviewRewardCache;

		// Token: 0x04005269 RID: 21097
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardIdCache;

		// Token: 0x0400526A RID: 21098
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardIdCalabashCache;
	}
}

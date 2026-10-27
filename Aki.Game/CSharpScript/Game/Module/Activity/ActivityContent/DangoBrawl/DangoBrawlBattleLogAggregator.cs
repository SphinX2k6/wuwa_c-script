using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006757 RID: 26455
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBattleLogAggregator
	{
		// Token: 0x060420FD RID: 270589 RVA: 0x01007245 File Offset: 0x01005445
		[return: Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public IReadOnlyDictionary<ValueTuple<EDangoBrawlDamageSource, int>, DangoBrawlBattleLogInfo> GetDamage(bool isSelfSide)
		{
			if (!isSelfSide)
			{
				return this.OppDmgMap;
			}
			return this.SelfDmgMap;
		}

		// Token: 0x060420FE RID: 270590 RVA: 0x01007257 File Offset: 0x01005457
		[return: Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public IReadOnlyDictionary<ValueTuple<EDangoBrawlDamageSource, int>, DangoBrawlBattleLogInfo> GetHeal(bool isSelfSide)
		{
			if (!isSelfSide)
			{
				return this.OppHealMap;
			}
			return this.SelfHealMap;
		}

		// Token: 0x060420FF RID: 270591 RVA: 0x01007269 File Offset: 0x01005469
		public void AddDamage(DangoBrawlDamageEvent evt, bool isSelfSide)
		{
			if (isSelfSide)
			{
				this.SelfDmgTotal = DangoBrawlBattleLogAggregator.AddTo(evt, this.SelfDmgMap, this.SelfDmgTotal);
				return;
			}
			this.OppDmgTotal = DangoBrawlBattleLogAggregator.AddTo(evt, this.OppDmgMap, this.OppDmgTotal);
		}

		// Token: 0x06042100 RID: 270592 RVA: 0x0100729F File Offset: 0x0100549F
		public void AddHeal(DangoBrawlDamageEvent evt, bool isSelfSide)
		{
			if (isSelfSide)
			{
				this.SelfHealTotal = DangoBrawlBattleLogAggregator.AddTo(evt, this.SelfHealMap, this.SelfHealTotal);
				return;
			}
			this.OppHealTotal = DangoBrawlBattleLogAggregator.AddTo(evt, this.OppHealMap, this.OppHealTotal);
		}

		// Token: 0x06042101 RID: 270593 RVA: 0x010072D8 File Offset: 0x010054D8
		public void Reset()
		{
			this.SelfDmgMap.Clear();
			this.OppDmgMap.Clear();
			this.SelfDmgTotal = 0;
			this.OppDmgTotal = 0;
			this.SelfHealMap.Clear();
			this.OppHealMap.Clear();
			this.SelfHealTotal = 0;
			this.OppHealTotal = 0;
		}

		// Token: 0x06042102 RID: 270594 RVA: 0x01007330 File Offset: 0x01005530
		private static int AddTo(DangoBrawlDamageEvent evt, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] Dictionary<ValueTuple<EDangoBrawlDamageSource, int>, DangoBrawlBattleLogInfo> map, int total)
		{
			if (!DangoBrawlBattleLogAggregator.CanLogEntry(evt))
			{
				return total;
			}
			total += evt.Value;
			int item = (evt.Source == EDangoBrawlDamageSource.Weapon && evt.SourceItemUid != 0) ? evt.SourceItemUid : evt.SourceConfigId;
			ValueTuple<EDangoBrawlDamageSource, int> key = new ValueTuple<EDangoBrawlDamageSource, int>(evt.Source, item);
			DangoBrawlBattleLogInfo dangoBrawlBattleLogInfo;
			if (!map.TryGetValue(key, out dangoBrawlBattleLogInfo))
			{
				dangoBrawlBattleLogInfo = new DangoBrawlBattleLogInfo
				{
					ItemUId = evt.SourceItemUid,
					ConfigId = evt.SourceConfigId,
					Source = evt.Source
				};
				map[key] = dangoBrawlBattleLogInfo;
			}
			dangoBrawlBattleLogInfo.Value += evt.Value;
			if (total <= 0)
			{
				return total;
			}
			foreach (DangoBrawlBattleLogInfo dangoBrawlBattleLogInfo2 in map.Values)
			{
				dangoBrawlBattleLogInfo2.DamagePercent = (float)dangoBrawlBattleLogInfo2.Value / (float)total;
			}
			return total;
		}

		// Token: 0x06042103 RID: 270595 RVA: 0x01007424 File Offset: 0x01005624
		private static bool CanLogEntry(DangoBrawlDamageEvent evt)
		{
			return evt.SourceConfigId > 0 || evt.SourceConfigId == -1001 || evt.SourceConfigId == -1002;
		}

		// Token: 0x0402265A RID: 140890
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private readonly Dictionary<ValueTuple<EDangoBrawlDamageSource, int>, DangoBrawlBattleLogInfo> SelfDmgMap = new Dictionary<ValueTuple<EDangoBrawlDamageSource, int>, DangoBrawlBattleLogInfo>();

		// Token: 0x0402265B RID: 140891
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private readonly Dictionary<ValueTuple<EDangoBrawlDamageSource, int>, DangoBrawlBattleLogInfo> OppDmgMap = new Dictionary<ValueTuple<EDangoBrawlDamageSource, int>, DangoBrawlBattleLogInfo>();

		// Token: 0x0402265C RID: 140892
		private int SelfDmgTotal;

		// Token: 0x0402265D RID: 140893
		private int OppDmgTotal;

		// Token: 0x0402265E RID: 140894
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private readonly Dictionary<ValueTuple<EDangoBrawlDamageSource, int>, DangoBrawlBattleLogInfo> SelfHealMap = new Dictionary<ValueTuple<EDangoBrawlDamageSource, int>, DangoBrawlBattleLogInfo>();

		// Token: 0x0402265F RID: 140895
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private readonly Dictionary<ValueTuple<EDangoBrawlDamageSource, int>, DangoBrawlBattleLogInfo> OppHealMap = new Dictionary<ValueTuple<EDangoBrawlDamageSource, int>, DangoBrawlBattleLogInfo>();

		// Token: 0x04022660 RID: 140896
		private int SelfHealTotal;

		// Token: 0x04022661 RID: 140897
		private int OppHealTotal;
	}
}

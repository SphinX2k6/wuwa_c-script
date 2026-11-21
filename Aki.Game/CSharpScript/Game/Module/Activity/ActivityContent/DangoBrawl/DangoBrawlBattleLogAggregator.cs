using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056A7 RID: 22183
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBattleLogAggregator
	{
		// Token: 0x06036C4F RID: 224335 RVA: 0x00F486C9 File Offset: 0x00F468C9
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

		// Token: 0x06036C50 RID: 224336 RVA: 0x00F486DB File Offset: 0x00F468DB
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

		// Token: 0x06036C51 RID: 224337 RVA: 0x00F486ED File Offset: 0x00F468ED
		public void AddDamage(DangoBrawlDamageEvent evt, bool isSelfSide)
		{
			if (isSelfSide)
			{
				this.SelfDmgTotal = DangoBrawlBattleLogAggregator.AddTo(evt, this.SelfDmgMap, this.SelfDmgTotal);
				return;
			}
			this.OppDmgTotal = DangoBrawlBattleLogAggregator.AddTo(evt, this.OppDmgMap, this.OppDmgTotal);
		}

		// Token: 0x06036C52 RID: 224338 RVA: 0x00F48723 File Offset: 0x00F46923
		public void AddHeal(DangoBrawlDamageEvent evt, bool isSelfSide)
		{
			if (isSelfSide)
			{
				this.SelfHealTotal = DangoBrawlBattleLogAggregator.AddTo(evt, this.SelfHealMap, this.SelfHealTotal);
				return;
			}
			this.OppHealTotal = DangoBrawlBattleLogAggregator.AddTo(evt, this.OppHealMap, this.OppHealTotal);
		}

		// Token: 0x06036C53 RID: 224339 RVA: 0x00F4875C File Offset: 0x00F4695C
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

		// Token: 0x06036C54 RID: 224340 RVA: 0x00F487B4 File Offset: 0x00F469B4
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

		// Token: 0x06036C55 RID: 224341 RVA: 0x00F488A8 File Offset: 0x00F46AA8
		private static bool CanLogEntry(DangoBrawlDamageEvent evt)
		{
			return evt.SourceConfigId > 0 || evt.SourceConfigId == -1001 || evt.SourceConfigId == -1002;
		}

		// Token: 0x0401CEB3 RID: 118451
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private readonly Dictionary<ValueTuple<EDangoBrawlDamageSource, int>, DangoBrawlBattleLogInfo> SelfDmgMap = new Dictionary<ValueTuple<EDangoBrawlDamageSource, int>, DangoBrawlBattleLogInfo>();

		// Token: 0x0401CEB4 RID: 118452
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private readonly Dictionary<ValueTuple<EDangoBrawlDamageSource, int>, DangoBrawlBattleLogInfo> OppDmgMap = new Dictionary<ValueTuple<EDangoBrawlDamageSource, int>, DangoBrawlBattleLogInfo>();

		// Token: 0x0401CEB5 RID: 118453
		private int SelfDmgTotal;

		// Token: 0x0401CEB6 RID: 118454
		private int OppDmgTotal;

		// Token: 0x0401CEB7 RID: 118455
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private readonly Dictionary<ValueTuple<EDangoBrawlDamageSource, int>, DangoBrawlBattleLogInfo> SelfHealMap = new Dictionary<ValueTuple<EDangoBrawlDamageSource, int>, DangoBrawlBattleLogInfo>();

		// Token: 0x0401CEB8 RID: 118456
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private readonly Dictionary<ValueTuple<EDangoBrawlDamageSource, int>, DangoBrawlBattleLogInfo> OppHealMap = new Dictionary<ValueTuple<EDangoBrawlDamageSource, int>, DangoBrawlBattleLogInfo>();

		// Token: 0x0401CEB9 RID: 118457
		private int SelfHealTotal;

		// Token: 0x0401CEBA RID: 118458
		private int OppHealTotal;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x02003140 RID: 12608
[NullableContext(2)]
[Nullable(0)]
public abstract class BaseFightDataTableRepository
{
	// Token: 0x0601B1E2 RID: 111074 RVA: 0x0076005D File Offset: 0x0075E25D
	[NullableContext(1)]
	public BaseFightDataTableRepository(FightDataTableCollection collection)
	{
		this.Collection = collection;
	}

	// Token: 0x0601B1E3 RID: 111075 RVA: 0x0076006C File Offset: 0x0075E26C
	[NullableContext(1)]
	protected virtual void OnExtraTablesRemoved(IReadOnlyList<UDataTable> removedTables)
	{
	}

	// Token: 0x0601B1E4 RID: 111076 RVA: 0x0076006E File Offset: 0x0075E26E
	[NullableContext(1)]
	protected virtual void OnExtraTableAdded(UDataTable addedTable)
	{
	}

	// Token: 0x0601B1E5 RID: 111077 RVA: 0x00760070 File Offset: 0x0075E270
	public virtual UDataTable GetTable(EFightDataTableSourceType tableSourceType, EEntityType? entityType = null)
	{
		if ((tableSourceType & EFightDataTableSourceType.Extra) != (EFightDataTableSourceType)0)
		{
			List<UDataTable> extraTables = this.ExtraTables;
			if (extraTables != null && extraTables.Count > 0)
			{
				return this.ExtraTables[0];
			}
		}
		if ((tableSourceType & EFightDataTableSourceType.Self) != (EFightDataTableSourceType)0 && this.SelfTable != null)
		{
			return this.SelfTable;
		}
		if ((tableSourceType & EFightDataTableSourceType.Common) != (EFightDataTableSourceType)0 && this.CommonOverrideTable != null)
		{
			return this.CommonOverrideTable;
		}
		return null;
	}

	// Token: 0x0601B1E6 RID: 111078 RVA: 0x007600CB File Offset: 0x0075E2CB
	public void SetCommonOverrideTable(UDataTable data)
	{
		if (this.CommonOverrideTable == data)
		{
			return;
		}
		this.CommonOverrideTable = data;
	}

	// Token: 0x0601B1E7 RID: 111079 RVA: 0x007600E0 File Offset: 0x0075E2E0
	public void ClearExtraTables()
	{
		if (this.ExtraTables == null && this.ExtraTableRefCounts == null)
		{
			return;
		}
		List<UDataTable> removedTables = (this.ExtraTables != null) ? new List<UDataTable>(this.ExtraTables) : new List<UDataTable>();
		this.ExtraTables = null;
		this.ExtraTableRefCounts = null;
		this.OnExtraTablesRemoved(removedTables);
	}

	// Token: 0x0601B1E8 RID: 111080 RVA: 0x00760130 File Offset: 0x0075E330
	public void AddExtraTable(UDataTable data)
	{
		if (data == null)
		{
			return;
		}
		if (this.ExtraTableRefCounts == null)
		{
			this.ExtraTableRefCounts = new Dictionary<UDataTable, int>();
		}
		int valueOrDefault = this.ExtraTableRefCounts.GetValueOrDefault(data, 0);
		if (valueOrDefault <= 0)
		{
			if (this.ExtraTables == null)
			{
				this.ExtraTables = new List<UDataTable>();
			}
			this.ExtraTables.Add(data);
			this.ExtraTableRefCounts[data] = valueOrDefault + 1;
			this.OnExtraTableAdded(data);
			return;
		}
		this.ExtraTableRefCounts[data] = valueOrDefault + 1;
	}

	// Token: 0x0601B1E9 RID: 111081 RVA: 0x007601AC File Offset: 0x0075E3AC
	public void RemoveExtraTable(UDataTable data)
	{
		if (data == null || this.ExtraTableRefCounts == null)
		{
			return;
		}
		int num;
		if (!this.ExtraTableRefCounts.TryGetValue(data, out num) || num <= 0)
		{
			return;
		}
		if (num == 1)
		{
			this.ExtraTableRefCounts.Remove(data);
			List<UDataTable> extraTables = this.ExtraTables;
			if (extraTables != null && extraTables.Count > 0)
			{
				this.ExtraTables.Remove(data);
				if (this.ExtraTables.Count <= 0)
				{
					this.ExtraTables = null;
				}
			}
			if (this.ExtraTableRefCounts.Count <= 0)
			{
				this.ExtraTableRefCounts = null;
			}
			this.OnExtraTablesRemoved(new UDataTable[]
			{
				data
			});
			return;
		}
		this.ExtraTableRefCounts[data] = num - 1;
	}

	// Token: 0x0601B1EA RID: 111082 RVA: 0x00760258 File Offset: 0x0075E458
	[NullableContext(1)]
	public virtual FightDataTableSnapshot CreateSnapshot(EEntityType entityType)
	{
		return new FightDataTableSnapshot
		{
			SelfTable = this.SelfTable,
			CommonTables = FightDataTableUtil.BuildCommonTables(new UDataTable[]
			{
				this.CommonOverrideTable
			}),
			ExtraTables = ((this.ExtraTables == null) ? null : new List<UDataTable>(this.ExtraTables))
		};
	}

	// Token: 0x0400D308 RID: 54024
	public UDataTable SelfTable;

	// Token: 0x0400D309 RID: 54025
	public UDataTable CommonOverrideTable;

	// Token: 0x0400D30A RID: 54026
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<UDataTable> ExtraTables;

	// Token: 0x0400D30B RID: 54027
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<UDataTable, int> ExtraTableRefCounts;

	// Token: 0x0400D30C RID: 54028
	[Nullable(1)]
	protected readonly FightDataTableCollection Collection;
}

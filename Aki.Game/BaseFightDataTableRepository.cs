using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

// Token: 0x020026A2 RID: 9890
[NullableContext(2)]
[Nullable(0)]
public abstract class BaseFightDataTableRepository
{
	// Token: 0x06018C73 RID: 101491 RVA: 0x00786706 File Offset: 0x00784906
	[NullableContext(1)]
	public BaseFightDataTableRepository(FightDataTableCollection collection)
	{
		this.Collection = collection;
	}

	// Token: 0x06018C74 RID: 101492 RVA: 0x00786715 File Offset: 0x00784915
	[NullableContext(1)]
	protected virtual void OnExtraTableAdded(UDataTable addedTable)
	{
	}

	// Token: 0x06018C75 RID: 101493 RVA: 0x00786717 File Offset: 0x00784917
	[NullableContext(1)]
	protected virtual void OnExtraTablesRemoved(IReadOnlyList<UDataTable> removedTables)
	{
	}

	// Token: 0x06018C76 RID: 101494 RVA: 0x00786719 File Offset: 0x00784919
	protected virtual void OnExtraTableReplaced(UDataTable removedTable, UDataTable addedTable)
	{
		if (removedTable != null)
		{
			this.OnExtraTablesRemoved(new UDataTable[]
			{
				removedTable
			});
		}
		if (addedTable != null)
		{
			this.OnExtraTableAdded(addedTable);
		}
	}

	// Token: 0x06018C77 RID: 101495 RVA: 0x00786738 File Offset: 0x00784938
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
		return null;
	}

	// Token: 0x06018C78 RID: 101496 RVA: 0x00786780 File Offset: 0x00784980
	public void ClearExtraTables()
	{
		if (this.ExtraTables == null)
		{
			return;
		}
		List<UDataTable> extraTables = this.ExtraTables;
		this.ExtraTables = null;
		this.OnExtraTablesRemoved(extraTables);
	}

	// Token: 0x06018C79 RID: 101497 RVA: 0x007867AC File Offset: 0x007849AC
	public void AddExtraTable(UDataTable data)
	{
		if (data == null)
		{
			return;
		}
		List<UDataTable> extraTables = this.ExtraTables;
		if (extraTables != null && extraTables.Contains(data))
		{
			return;
		}
		if (this.ExtraTables == null)
		{
			this.ExtraTables = new List<UDataTable>();
		}
		this.ExtraTables.Add(data);
		this.OnExtraTableAdded(data);
	}

	// Token: 0x06018C7A RID: 101498 RVA: 0x007867FC File Offset: 0x007849FC
	public void RemoveExtraTable(UDataTable data)
	{
		if (data == null || this.ExtraTables == null)
		{
			return;
		}
		int num = this.ExtraTables.IndexOf(data);
		if (num < 0)
		{
			return;
		}
		this.ExtraTables.RemoveAt(num);
		if (this.ExtraTables.Count <= 0)
		{
			this.ExtraTables = null;
		}
		this.OnExtraTablesRemoved(new UDataTable[]
		{
			data
		});
	}

	// Token: 0x06018C7B RID: 101499 RVA: 0x00786858 File Offset: 0x00784A58
	public void ReplaceExtraTable(UDataTable oldData, UDataTable newData)
	{
		if (oldData == newData)
		{
			return;
		}
		int num = (oldData != null && this.ExtraTables != null) ? this.ExtraTables.IndexOf(oldData) : -1;
		UDataTable udataTable = (num >= 0) ? oldData : null;
		if (num >= 0)
		{
			this.ExtraTables.RemoveAt(num);
			if (this.ExtraTables.Count <= 0)
			{
				this.ExtraTables = null;
			}
		}
		UDataTable udataTable2 = null;
		if (newData != null)
		{
			List<UDataTable> extraTables = this.ExtraTables;
			if (extraTables == null || !extraTables.Contains(newData))
			{
				if (this.ExtraTables == null)
				{
					this.ExtraTables = new List<UDataTable>();
				}
				if (num >= 0 && num <= this.ExtraTables.Count)
				{
					this.ExtraTables.Insert(num, newData);
				}
				else
				{
					this.ExtraTables.Add(newData);
				}
				udataTable2 = newData;
			}
		}
		if (udataTable != null || udataTable2 != null)
		{
			this.OnExtraTableReplaced(udataTable, udataTable2);
		}
	}

	// Token: 0x0400D747 RID: 55111
	public UDataTable SelfTable;

	// Token: 0x0400D748 RID: 55112
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<UDataTable> ExtraTables;

	// Token: 0x0400D749 RID: 55113
	[Nullable(1)]
	protected readonly FightDataTableCollection Collection;
}

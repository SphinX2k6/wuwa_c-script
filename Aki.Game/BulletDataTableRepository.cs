using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x020026A4 RID: 9892
[NullableContext(1)]
[Nullable(0)]
public class BulletDataTableRepository : BaseFightDataTableRepository
{
	// Token: 0x06018C8C RID: 101516 RVA: 0x00786D7F File Offset: 0x00784F7F
	public BulletDataTableRepository(FightDataTableCollection collection) : base(collection)
	{
	}

	// Token: 0x06018C8D RID: 101517 RVA: 0x00786D88 File Offset: 0x00784F88
	protected override void OnExtraTableAdded(UDataTable addedTable)
	{
		BulletConfig.Instance.EnqueueExtraPreload(this.Collection.EntityId, addedTable);
	}

	// Token: 0x06018C8E RID: 101518 RVA: 0x00786DA0 File Offset: 0x00784FA0
	protected override void OnExtraTablesRemoved(IReadOnlyList<UDataTable> removedTables)
	{
		foreach (UDataTable table in removedTables)
		{
			BulletConfig.Instance.RemoveEntityExtraBulletCacheByTable(this.Collection.EntityId, table);
			BulletConfig.Instance.CancelExtraPreload(this.Collection.EntityId, table);
		}
	}

	// Token: 0x06018C8F RID: 101519 RVA: 0x00786E10 File Offset: 0x00785010
	[NullableContext(2)]
	protected override void OnExtraTableReplaced(UDataTable removedTable, UDataTable addedTable)
	{
		if (removedTable != null)
		{
			BulletConfig.Instance.RemoveEntityExtraBulletCacheByTable(this.Collection.EntityId, removedTable);
			BulletConfig.Instance.CancelExtraPreload(this.Collection.EntityId, removedTable);
		}
		if (addedTable != null)
		{
			BulletConfig.Instance.EnqueueExtraPreload(this.Collection.EntityId, addedTable);
		}
	}

	// Token: 0x06018C90 RID: 101520 RVA: 0x00786E65 File Offset: 0x00785065
	public IEnumerable<long> EnumerateBulletIds(EFightDataTableSourceType tableSourceType)
	{
		BulletDataTableRepository.<EnumerateBulletIds>d__4 <EnumerateBulletIds>d__ = new BulletDataTableRepository.<EnumerateBulletIds>d__4(-2);
		<EnumerateBulletIds>d__.<>4__this = this;
		<EnumerateBulletIds>d__.<>3__tableSourceType = tableSourceType;
		return <EnumerateBulletIds>d__;
	}

	// Token: 0x06018C91 RID: 101521 RVA: 0x00786E7C File Offset: 0x0078507C
	[return: Nullable(2)]
	public ResolvedBulletDataMain FindBulletDataMain(string rowName)
	{
		if (this.ExtraTables != null)
		{
			foreach (UDataTable udataTable in this.ExtraTables)
			{
				SReBulletDataMain dataTableRow = DataTableUtil.GetDataTableRow<SReBulletDataMain>(udataTable, rowName);
				if (dataTableRow != null)
				{
					return new ResolvedBulletDataMain
					{
						Info = dataTableRow,
						SourceTable = udataTable,
						SourceType = EResolvedDataSourceType.Extra
					};
				}
			}
		}
		SReBulletDataMain dataTableRow2 = DataTableUtil.GetDataTableRow<SReBulletDataMain>(this.SelfTable, rowName);
		if (dataTableRow2 != null && this.SelfTable != null)
		{
			return new ResolvedBulletDataMain
			{
				Info = dataTableRow2,
				SourceTable = this.SelfTable,
				SourceType = EResolvedDataSourceType.Self
			};
		}
		return BulletDataTableRepository.FindCommonBulletDataMain(rowName);
	}

	// Token: 0x06018C92 RID: 101522 RVA: 0x00786F48 File Offset: 0x00785148
	[return: Nullable(2)]
	public static ResolvedBulletDataMain FindCommonBulletDataMain(string rowName)
	{
		UDataTable gameplayCommonBulletDataTable = GameplayCommonFightDataTables.GetGameplayCommonBulletDataTable();
		SReBulletDataMain dataTableRow = DataTableUtil.GetDataTableRow<SReBulletDataMain>(gameplayCommonBulletDataTable, rowName);
		if (dataTableRow != null && gameplayCommonBulletDataTable != null)
		{
			return new ResolvedBulletDataMain
			{
				Info = dataTableRow,
				SourceTable = gameplayCommonBulletDataTable,
				SourceType = EResolvedDataSourceType.GameplayCommon
			};
		}
		UDataTable commonBulletDataTable = BulletDataTableRepository.GetCommonBulletDataTable();
		SReBulletDataMain dataTableRow2 = DataTableUtil.GetDataTableRow<SReBulletDataMain>(commonBulletDataTable, rowName);
		if (dataTableRow2 != null && commonBulletDataTable != null)
		{
			return new ResolvedBulletDataMain
			{
				Info = dataTableRow2,
				SourceTable = commonBulletDataTable,
				SourceType = EResolvedDataSourceType.GlobalCommon
			};
		}
		return null;
	}

	// Token: 0x06018C93 RID: 101523 RVA: 0x00786FC0 File Offset: 0x007851C0
	[NullableContext(2)]
	public override UDataTable GetTable(EFightDataTableSourceType tableSourceType, EEntityType? entityType = null)
	{
		UDataTable result;
		if ((result = base.GetTable(tableSourceType, entityType)) == null)
		{
			if ((tableSourceType & EFightDataTableSourceType.Common) == (EFightDataTableSourceType)0)
			{
				return null;
			}
			result = (GameplayCommonFightDataTables.GetGameplayCommonBulletDataTable() ?? BulletDataTableRepository.GetCommonBulletDataTable());
		}
		return result;
	}

	// Token: 0x06018C94 RID: 101524 RVA: 0x00786FE3 File Offset: 0x007851E3
	[NullableContext(2)]
	public static UDataTable GetCommonBulletDataTable()
	{
		return WorldConfig.Instance.GetCommonBulletData();
	}

	// Token: 0x06018C95 RID: 101525 RVA: 0x00786FEF File Offset: 0x007851EF
	private static IEnumerable<long> EnumerateIdsFromTable([Nullable(2)] UDataTable table, HashSet<long> cacheIds)
	{
		BulletDataTableRepository.<EnumerateIdsFromTable>d__9 <EnumerateIdsFromTable>d__ = new BulletDataTableRepository.<EnumerateIdsFromTable>d__9(-2);
		<EnumerateIdsFromTable>d__.<>3__table = table;
		<EnumerateIdsFromTable>d__.<>3__cacheIds = cacheIds;
		return <EnumerateIdsFromTable>d__;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02003142 RID: 12610
[NullableContext(1)]
[Nullable(0)]
public class BulletDataTableRepository : BaseFightDataTableRepository
{
	// Token: 0x0601B1F6 RID: 111094 RVA: 0x0076053A File Offset: 0x0075E73A
	public BulletDataTableRepository(FightDataTableCollection collection) : base(collection)
	{
	}

	// Token: 0x0601B1F7 RID: 111095 RVA: 0x00760544 File Offset: 0x0075E744
	protected override void OnExtraTablesRemoved(IReadOnlyList<UDataTable> removedTables)
	{
		foreach (UDataTable table in removedTables)
		{
			BulletConfig.Instance.RemoveEntityExtraBulletCacheByTable(this.Collection.EntityId, table);
			BulletConfig.Instance.CancelExtraPreload(this.Collection.EntityId, table);
		}
	}

	// Token: 0x0601B1F8 RID: 111096 RVA: 0x007605B4 File Offset: 0x0075E7B4
	protected override void OnExtraTableAdded(UDataTable addedTable)
	{
		BulletConfig.Instance.EnqueueExtraPreload(this.Collection.EntityId, addedTable);
	}

	// Token: 0x0601B1F9 RID: 111097 RVA: 0x007605CC File Offset: 0x0075E7CC
	public IEnumerable<long> EnumerateBulletIds(EFightDataTableSourceType tableSourceType)
	{
		BulletDataTableRepository.<EnumerateBulletIds>d__3 <EnumerateBulletIds>d__ = new BulletDataTableRepository.<EnumerateBulletIds>d__3(-2);
		<EnumerateBulletIds>d__.<>4__this = this;
		<EnumerateBulletIds>d__.<>3__tableSourceType = tableSourceType;
		return <EnumerateBulletIds>d__;
	}

	// Token: 0x0601B1FA RID: 111098 RVA: 0x007605E4 File Offset: 0x0075E7E4
	[return: Nullable(2)]
	public SReBulletDataMain FindBulletDataMain(string rowName)
	{
		if (this.ExtraTables != null)
		{
			foreach (UDataTable table in this.ExtraTables)
			{
				SReBulletDataMain dataTableRow = DataTableUtil.GetDataTableRow<SReBulletDataMain>(table, rowName);
				if (dataTableRow != null)
				{
					return dataTableRow;
				}
			}
		}
		SReBulletDataMain dataTableRow2 = DataTableUtil.GetDataTableRow<SReBulletDataMain>(this.SelfTable, rowName);
		if (dataTableRow2 != null)
		{
			return dataTableRow2;
		}
		SReBulletDataMain dataTableRow3 = DataTableUtil.GetDataTableRow<SReBulletDataMain>(this.CommonOverrideTable, rowName);
		if (dataTableRow3 != null)
		{
			return dataTableRow3;
		}
		return DataTableUtil.GetDataTableRow<SReBulletDataMain>(BulletDataTableRepository.GetCommonBulletDataTable(), rowName);
	}

	// Token: 0x0601B1FB RID: 111099 RVA: 0x0076068C File Offset: 0x0075E88C
	public override FightDataTableSnapshot CreateSnapshot(EEntityType entityType)
	{
		return new FightDataTableSnapshot
		{
			SelfTable = this.SelfTable,
			CommonTables = FightDataTableUtil.BuildCommonTables(new UDataTable[]
			{
				this.CommonOverrideTable,
				BulletDataTableRepository.GetCommonBulletDataTable()
			}),
			ExtraTables = ((this.ExtraTables == null) ? null : new List<UDataTable>(this.ExtraTables))
		};
	}

	// Token: 0x0601B1FC RID: 111100 RVA: 0x007606EA File Offset: 0x0075E8EA
	[NullableContext(2)]
	public static UDataTable GetCommonBulletDataTable()
	{
		return WorldConfig.Instance.GetCommonBulletData();
	}

	// Token: 0x0601B1FD RID: 111101 RVA: 0x007606F6 File Offset: 0x0075E8F6
	private static IEnumerable<long> EnumerateIdsFromTable([Nullable(2)] UDataTable table, HashSet<long> cacheIds)
	{
		BulletDataTableRepository.<EnumerateIdsFromTable>d__7 <EnumerateIdsFromTable>d__ = new BulletDataTableRepository.<EnumerateIdsFromTable>d__7(-2);
		<EnumerateIdsFromTable>d__.<>3__table = table;
		<EnumerateIdsFromTable>d__.<>3__cacheIds = cacheIds;
		return <EnumerateIdsFromTable>d__;
	}
}

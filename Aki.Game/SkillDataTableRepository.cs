using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;

// Token: 0x020026A3 RID: 9891
[NullableContext(1)]
[Nullable(0)]
public class SkillDataTableRepository : BaseFightDataTableRepository
{
	// Token: 0x06018C7C RID: 101500 RVA: 0x00786920 File Offset: 0x00784B20
	public SkillDataTableRepository(FightDataTableCollection collection) : base(collection)
	{
	}

	// Token: 0x06018C7D RID: 101501 RVA: 0x00786934 File Offset: 0x00784B34
	protected override void OnExtraTableAdded(UDataTable addedTable)
	{
		this.NotifySkillIdsChangedByTables(new UDataTable[]
		{
			addedTable
		});
	}

	// Token: 0x06018C7E RID: 101502 RVA: 0x00786946 File Offset: 0x00784B46
	protected override void OnExtraTablesRemoved(IReadOnlyList<UDataTable> removedTables)
	{
		this.NotifySkillIdsChangedByTables(new List<UDataTable>(removedTables).ToArray());
	}

	// Token: 0x06018C7F RID: 101503 RVA: 0x00786959 File Offset: 0x00784B59
	[NullableContext(2)]
	protected override void OnExtraTableReplaced(UDataTable removedTable, UDataTable addedTable)
	{
		this.NotifySkillIdsChangedByTables(new UDataTable[]
		{
			removedTable,
			addedTable
		});
	}

	// Token: 0x06018C80 RID: 101504 RVA: 0x00786970 File Offset: 0x00784B70
	[NullableContext(2)]
	public void SetDebugTable(ECharacterLoadType loadType, UDataTable data)
	{
		UDataTable valueOrDefault = this.DebugTables.GetValueOrDefault(loadType);
		if (valueOrDefault == data)
		{
			return;
		}
		if (data == null)
		{
			this.DebugTables.Remove(loadType);
			this.NotifySkillIdsChangedByTables(new UDataTable[]
			{
				valueOrDefault
			});
			return;
		}
		this.DebugTables[loadType] = data;
		this.NotifySkillIdsChangedByTables(new UDataTable[]
		{
			valueOrDefault,
			data
		});
	}

	// Token: 0x06018C81 RID: 101505 RVA: 0x007869D1 File Offset: 0x00784BD1
	public void NotifyDebugSkillIdsChanged()
	{
		this.NotifySkillIdsChangedByTables(new List<UDataTable>(this.DebugTables.Values).ToArray());
	}

	// Token: 0x06018C82 RID: 101506 RVA: 0x007869F0 File Offset: 0x00784BF0
	private void NotifySkillIdsChangedByTables([Nullable(new byte[]
	{
		1,
		2
	})] params UDataTable[] tables)
	{
		HashSet<int> hashSet = new HashSet<int>();
		foreach (UDataTable table in tables)
		{
			HashSet<int> cacheIds = hashSet;
			Func<string, int> convert;
			if ((convert = SkillDataTableRepository.<>O.<0>__Parse) == null)
			{
				convert = (SkillDataTableRepository.<>O.<0>__Parse = new Func<string, int>(int.Parse));
			}
			foreach (int num in SkillDataTableRepository.EnumerateIdsFromTable<int>(table, cacheIds, convert))
			{
			}
		}
		this.Collection.NotifySkillIdsChanged(new List<int>(hashSet));
	}

	// Token: 0x06018C83 RID: 101507 RVA: 0x00786A7C File Offset: 0x00784C7C
	[NullableContext(2)]
	public ResolvedSkillInfo FindSkillInfo(long skillId, EEntityType entityType)
	{
		string rowName = skillId.ToString();
		UDataTable table;
		if (this.DebugTables.TryGetValue(FightDebugUtil.DtSkillTypeForDebug, out table))
		{
			SSkillInfo dataTableRow = DataTableUtil.GetDataTableRow<SSkillInfo>(table, rowName);
			if (dataTableRow != null)
			{
				return new ResolvedSkillInfo
				{
					Info = dataTableRow,
					SourceTable = SkillDataTableRepository.ResolveEffectiveSkillRowSource(table, rowName)
				};
			}
		}
		if (this.ExtraTables != null)
		{
			foreach (UDataTable table2 in this.ExtraTables)
			{
				SSkillInfo dataTableRow2 = DataTableUtil.GetDataTableRow<SSkillInfo>(table2, rowName);
				if (dataTableRow2 != null)
				{
					return new ResolvedSkillInfo
					{
						Info = dataTableRow2,
						SourceTable = SkillDataTableRepository.ResolveEffectiveSkillRowSource(table2, rowName)
					};
				}
			}
		}
		if (this.SelfTable != null)
		{
			SSkillInfo dataTableRow3 = DataTableUtil.GetDataTableRow<SSkillInfo>(this.SelfTable, rowName);
			if (dataTableRow3 != null)
			{
				return new ResolvedSkillInfo
				{
					Info = dataTableRow3,
					SourceTable = SkillDataTableRepository.ResolveEffectiveSkillRowSource(this.SelfTable, rowName)
				};
			}
		}
		UDataTable gameplayCommonSkillInfoTable = GameplayCommonFightDataTables.GetGameplayCommonSkillInfoTable(entityType);
		if (gameplayCommonSkillInfoTable != null)
		{
			SSkillInfo dataTableRow4 = DataTableUtil.GetDataTableRow<SSkillInfo>(gameplayCommonSkillInfoTable, rowName);
			if (dataTableRow4 != null)
			{
				return new ResolvedSkillInfo
				{
					Info = dataTableRow4,
					SourceTable = SkillDataTableRepository.ResolveEffectiveSkillRowSource(gameplayCommonSkillInfoTable, rowName)
				};
			}
		}
		UDataTable commonSkillInfoTable = SkillDataTableRepository.GetCommonSkillInfoTable(entityType);
		if (commonSkillInfoTable != null)
		{
			SSkillInfo dataTableRow5 = DataTableUtil.GetDataTableRow<SSkillInfo>(commonSkillInfoTable, rowName);
			if (dataTableRow5 != null)
			{
				return new ResolvedSkillInfo
				{
					Info = dataTableRow5,
					SourceTable = SkillDataTableRepository.ResolveEffectiveSkillRowSource(commonSkillInfoTable, rowName)
				};
			}
		}
		return null;
	}

	// Token: 0x06018C84 RID: 101508 RVA: 0x00786C08 File Offset: 0x00784E08
	[NullableContext(2)]
	public override UDataTable GetTable(EFightDataTableSourceType tableSourceType, EEntityType? entityType = null)
	{
		UDataTable table = base.GetTable(tableSourceType, entityType);
		if (table != null)
		{
			return table;
		}
		if ((tableSourceType & EFightDataTableSourceType.Common) != (EFightDataTableSourceType)0 && entityType != null)
		{
			return GameplayCommonFightDataTables.GetGameplayCommonSkillInfoTable(entityType.Value) ?? SkillDataTableRepository.GetCommonSkillInfoTable(entityType.Value);
		}
		return null;
	}

	// Token: 0x06018C85 RID: 101509 RVA: 0x00786C4F File Offset: 0x00784E4F
	public IEnumerable<int> EnumerateSkillIds(EFightDataTableSourceType tableSourceType, EEntityType entityType)
	{
		SkillDataTableRepository.<EnumerateSkillIds>d__10 <EnumerateSkillIds>d__ = new SkillDataTableRepository.<EnumerateSkillIds>d__10(-2);
		<EnumerateSkillIds>d__.<>4__this = this;
		<EnumerateSkillIds>d__.<>3__tableSourceType = tableSourceType;
		<EnumerateSkillIds>d__.<>3__entityType = entityType;
		return <EnumerateSkillIds>d__;
	}

	// Token: 0x06018C86 RID: 101510 RVA: 0x00786C6D File Offset: 0x00784E6D
	public IEnumerable<DataTableKeyRow<SSkillInfo>> EnumerateSkillInfoRows(EFightDataTableSourceType tableSourceType, EEntityType entityType)
	{
		SkillDataTableRepository.<EnumerateSkillInfoRows>d__11 <EnumerateSkillInfoRows>d__ = new SkillDataTableRepository.<EnumerateSkillInfoRows>d__11(-2);
		<EnumerateSkillInfoRows>d__.<>4__this = this;
		<EnumerateSkillInfoRows>d__.<>3__tableSourceType = tableSourceType;
		<EnumerateSkillInfoRows>d__.<>3__entityType = entityType;
		return <EnumerateSkillInfoRows>d__;
	}

	// Token: 0x06018C87 RID: 101511 RVA: 0x00786C8C File Offset: 0x00784E8C
	private static UDataTable ResolveEffectiveSkillRowSource(UDataTable table, string rowName)
	{
		FName value = FNameUtil.GetDynamicFName(rowName).Value;
		UDataTable udataTable = table;
		while (udataTable.IsA(UKuroDerivedDataTable.StaticClass()))
		{
			UKuroDerivedDataTable ukuroDerivedDataTable = (UKuroDerivedDataTable)udataTable;
			if (ukuroDerivedDataTable.IsChildOnlyRow(value) || ukuroDerivedDataTable.HasAnyOverrideInRow(value) || ukuroDerivedDataTable.ParentDataTable == null)
			{
				return udataTable;
			}
			udataTable = ukuroDerivedDataTable.ParentDataTable;
		}
		return udataTable;
	}

	// Token: 0x06018C88 RID: 101512 RVA: 0x00786CE4 File Offset: 0x00784EE4
	[NullableContext(2)]
	private static UDataTable GetCommonSkillInfoTable(EEntityType entityType)
	{
		if (entityType == EEntityType.Player)
		{
			return WorldConfig.Instance.GetRoleCommonSkillInfo();
		}
		if (entityType == EEntityType.Monster)
		{
			return WorldConfig.Instance.GetMonsterCommonSkillInfo();
		}
		if (entityType != EEntityType.Vision)
		{
			return null;
		}
		return WorldConfig.Instance.GetVisionCommonSkillInfo();
	}

	// Token: 0x06018C89 RID: 101513 RVA: 0x00786D15 File Offset: 0x00784F15
	private static List<string> GetCommonSkillRowNames(EEntityType entityType)
	{
		if (entityType == EEntityType.Player)
		{
			return WorldConfig.Instance.GetRoleCommonSkillRowNames();
		}
		if (entityType == EEntityType.Monster)
		{
			return WorldConfig.Instance.GetMonsterCommonSkillRowNames();
		}
		if (entityType != EEntityType.Vision)
		{
			return new List<string>();
		}
		return WorldConfig.Instance.GetVisionCommonSkillRowNames();
	}

	// Token: 0x06018C8A RID: 101514 RVA: 0x00786D4A File Offset: 0x00784F4A
	private static IEnumerable<T> EnumerateIdsFromTable<[Nullable(2)] T>([Nullable(2)] UDataTable table, HashSet<T> cacheIds, Func<string, T> convert)
	{
		SkillDataTableRepository.<EnumerateIdsFromTable>d__15<T> <EnumerateIdsFromTable>d__ = new SkillDataTableRepository.<EnumerateIdsFromTable>d__15<T>(-2);
		<EnumerateIdsFromTable>d__.<>3__table = table;
		<EnumerateIdsFromTable>d__.<>3__cacheIds = cacheIds;
		<EnumerateIdsFromTable>d__.<>3__convert = convert;
		return <EnumerateIdsFromTable>d__;
	}

	// Token: 0x06018C8B RID: 101515 RVA: 0x00786D68 File Offset: 0x00784F68
	private static IEnumerable<DataTableKeyRow<T>> EnumerateRowsFromTable<[Nullable(0)] T>([Nullable(2)] UDataTable table, HashSet<string> cacheRowNames) where T : UnrealScriptStructProxy, IUnrealScriptStructProxy
	{
		SkillDataTableRepository.<EnumerateRowsFromTable>d__16<T> <EnumerateRowsFromTable>d__ = new SkillDataTableRepository.<EnumerateRowsFromTable>d__16<T>(-2);
		<EnumerateRowsFromTable>d__.<>3__table = table;
		<EnumerateRowsFromTable>d__.<>3__cacheRowNames = cacheRowNames;
		return <EnumerateRowsFromTable>d__;
	}

	// Token: 0x0400D74A RID: 55114
	public readonly Dictionary<ECharacterLoadType, UDataTable> DebugTables = new Dictionary<ECharacterLoadType, UDataTable>();

	// Token: 0x020088CB RID: 35019
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402BB2E RID: 178990
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Func<string, int> <0>__Parse;
	}
}

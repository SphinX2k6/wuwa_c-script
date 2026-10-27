using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;

// Token: 0x02003141 RID: 12609
[NullableContext(1)]
[Nullable(0)]
public class SkillDataTableRepository : BaseFightDataTableRepository
{
	// Token: 0x0601B1EB RID: 111083 RVA: 0x007602AE File Offset: 0x0075E4AE
	public SkillDataTableRepository(FightDataTableCollection collection) : base(collection)
	{
	}

	// Token: 0x0601B1EC RID: 111084 RVA: 0x007602C2 File Offset: 0x0075E4C2
	[NullableContext(2)]
	public void SetDebugTable(ECharacterLoadType loadType, UDataTable data)
	{
		if (data == null)
		{
			this.DebugTables.Remove(loadType);
			return;
		}
		this.DebugTables[loadType] = data;
	}

	// Token: 0x0601B1ED RID: 111085 RVA: 0x007602E4 File Offset: 0x0075E4E4
	[NullableContext(2)]
	public SSkillInfo FindSkillInfo(long skillId, EEntityType entityType)
	{
		if (this.SelfTable == null)
		{
			return null;
		}
		string rowName = skillId.ToString();
		UDataTable table;
		if (this.DebugTables.TryGetValue(FightDebugUtil.DtSkillTypeForDebug, out table))
		{
			SSkillInfo dataTableRow = DataTableUtil.GetDataTableRow<SSkillInfo>(table, rowName);
			if (dataTableRow != null)
			{
				return dataTableRow;
			}
		}
		if (this.ExtraTables != null)
		{
			foreach (UDataTable table2 in this.ExtraTables)
			{
				SSkillInfo dataTableRow2 = DataTableUtil.GetDataTableRow<SSkillInfo>(table2, rowName);
				if (dataTableRow2 != null)
				{
					return dataTableRow2;
				}
			}
		}
		SSkillInfo dataTableRow3 = DataTableUtil.GetDataTableRow<SSkillInfo>(this.SelfTable, rowName);
		if (dataTableRow3 != null)
		{
			return dataTableRow3;
		}
		SSkillInfo dataTableRow4 = DataTableUtil.GetDataTableRow<SSkillInfo>(this.CommonOverrideTable, rowName);
		if (dataTableRow4 != null)
		{
			return dataTableRow4;
		}
		return DataTableUtil.GetDataTableRow<SSkillInfo>(SkillDataTableRepository.GetCommonSkillInfoTable(entityType), rowName);
	}

	// Token: 0x0601B1EE RID: 111086 RVA: 0x007603CC File Offset: 0x0075E5CC
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
			return SkillDataTableRepository.GetCommonSkillInfoTable(entityType.Value);
		}
		return null;
	}

	// Token: 0x0601B1EF RID: 111087 RVA: 0x00760403 File Offset: 0x0075E603
	public IEnumerable<int> EnumerateSkillIds(EFightDataTableSourceType tableSourceType, EEntityType entityType)
	{
		SkillDataTableRepository.<EnumerateSkillIds>d__5 <EnumerateSkillIds>d__ = new SkillDataTableRepository.<EnumerateSkillIds>d__5(-2);
		<EnumerateSkillIds>d__.<>4__this = this;
		<EnumerateSkillIds>d__.<>3__tableSourceType = tableSourceType;
		<EnumerateSkillIds>d__.<>3__entityType = entityType;
		return <EnumerateSkillIds>d__;
	}

	// Token: 0x0601B1F0 RID: 111088 RVA: 0x00760421 File Offset: 0x0075E621
	public IEnumerable<DataTableKeyRow<SSkillInfo>> EnumerateSkillInfoRows(EFightDataTableSourceType tableSourceType, EEntityType entityType)
	{
		SkillDataTableRepository.<EnumerateSkillInfoRows>d__6 <EnumerateSkillInfoRows>d__ = new SkillDataTableRepository.<EnumerateSkillInfoRows>d__6(-2);
		<EnumerateSkillInfoRows>d__.<>4__this = this;
		<EnumerateSkillInfoRows>d__.<>3__tableSourceType = tableSourceType;
		<EnumerateSkillInfoRows>d__.<>3__entityType = entityType;
		return <EnumerateSkillInfoRows>d__;
	}

	// Token: 0x0601B1F1 RID: 111089 RVA: 0x00760440 File Offset: 0x0075E640
	public override FightDataTableSnapshot CreateSnapshot(EEntityType entityType)
	{
		return new FightDataTableSnapshot
		{
			SelfTable = this.SelfTable,
			CommonTables = FightDataTableUtil.BuildCommonTables(new UDataTable[]
			{
				this.CommonOverrideTable,
				SkillDataTableRepository.GetCommonSkillInfoTable(entityType)
			}),
			ExtraTables = ((this.ExtraTables == null) ? null : new List<UDataTable>(this.ExtraTables))
		};
	}

	// Token: 0x0601B1F2 RID: 111090 RVA: 0x0076049F File Offset: 0x0075E69F
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

	// Token: 0x0601B1F3 RID: 111091 RVA: 0x007604D0 File Offset: 0x0075E6D0
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

	// Token: 0x0601B1F4 RID: 111092 RVA: 0x00760505 File Offset: 0x0075E705
	private static IEnumerable<T> EnumerateIdsFromTable<[Nullable(2)] T>([Nullable(2)] UDataTable table, HashSet<T> cacheIds, Func<string, T> convert)
	{
		SkillDataTableRepository.<EnumerateIdsFromTable>d__10<T> <EnumerateIdsFromTable>d__ = new SkillDataTableRepository.<EnumerateIdsFromTable>d__10<T>(-2);
		<EnumerateIdsFromTable>d__.<>3__table = table;
		<EnumerateIdsFromTable>d__.<>3__cacheIds = cacheIds;
		<EnumerateIdsFromTable>d__.<>3__convert = convert;
		return <EnumerateIdsFromTable>d__;
	}

	// Token: 0x0601B1F5 RID: 111093 RVA: 0x00760523 File Offset: 0x0075E723
	private static IEnumerable<DataTableKeyRow<T>> EnumerateRowsFromTable<[Nullable(0)] T>([Nullable(2)] UDataTable table, HashSet<string> cacheRowNames) where T : UnrealScriptStructProxy, IUnrealScriptStructProxy
	{
		SkillDataTableRepository.<EnumerateRowsFromTable>d__11<T> <EnumerateRowsFromTable>d__ = new SkillDataTableRepository.<EnumerateRowsFromTable>d__11<T>(-2);
		<EnumerateRowsFromTable>d__.<>3__table = table;
		<EnumerateRowsFromTable>d__.<>3__cacheRowNames = cacheRowNames;
		return <EnumerateRowsFromTable>d__;
	}

	// Token: 0x0400D30D RID: 54029
	public readonly Dictionary<ECharacterLoadType, UDataTable> DebugTables = new Dictionary<ECharacterLoadType, UDataTable>();

	// Token: 0x020096A7 RID: 38567
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0403049C RID: 197788
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Func<string, int> <0>__Parse;
	}
}

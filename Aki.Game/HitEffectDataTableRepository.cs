using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x020026A5 RID: 9893
[NullableContext(1)]
[Nullable(0)]
public class HitEffectDataTableRepository : BaseFightDataTableRepository
{
	// Token: 0x06018C96 RID: 101526 RVA: 0x00787006 File Offset: 0x00785206
	public HitEffectDataTableRepository(FightDataTableCollection collection) : base(collection)
	{
	}

	// Token: 0x06018C97 RID: 101527 RVA: 0x00787010 File Offset: 0x00785210
	[return: Nullable(2)]
	public SHitEffect FindHitEffect(string rowName)
	{
		if (this.ExtraTables != null)
		{
			foreach (UDataTable table in this.ExtraTables)
			{
				SHitEffect dataTableRow = DataTableUtil.GetDataTableRow<SHitEffect>(table, rowName);
				if (dataTableRow != null)
				{
					return dataTableRow;
				}
			}
		}
		SHitEffect dataTableRow2 = DataTableUtil.GetDataTableRow<SHitEffect>(this.SelfTable, rowName);
		if (dataTableRow2 != null)
		{
			return dataTableRow2;
		}
		SHitEffect dataTableRow3 = DataTableUtil.GetDataTableRow<SHitEffect>(GameplayCommonFightDataTables.GetGameplayCommonHitEffectDataTable(), rowName);
		if (dataTableRow3 != null)
		{
			return dataTableRow3;
		}
		return DataTableUtil.GetDataTableRow<SHitEffect>(HitEffectDataTableRepository.GetCommonHitEffectDataTable(), rowName);
	}

	// Token: 0x06018C98 RID: 101528 RVA: 0x007870B8 File Offset: 0x007852B8
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
			result = (GameplayCommonFightDataTables.GetGameplayCommonHitEffectDataTable() ?? HitEffectDataTableRepository.GetCommonHitEffectDataTable());
		}
		return result;
	}

	// Token: 0x06018C99 RID: 101529 RVA: 0x007870DB File Offset: 0x007852DB
	[NullableContext(2)]
	public static UDataTable GetCommonHitEffectDataTable()
	{
		return WorldConfig.Instance.GetCommonHitEffectData();
	}
}

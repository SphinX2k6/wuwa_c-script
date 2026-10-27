using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x02003143 RID: 12611
[NullableContext(1)]
[Nullable(0)]
public class HitEffectDataTableRepository : BaseFightDataTableRepository
{
	// Token: 0x0601B1FE RID: 111102 RVA: 0x0076070D File Offset: 0x0075E90D
	public HitEffectDataTableRepository(FightDataTableCollection collection) : base(collection)
	{
	}

	// Token: 0x0601B1FF RID: 111103 RVA: 0x00760718 File Offset: 0x0075E918
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
		SHitEffect dataTableRow3 = DataTableUtil.GetDataTableRow<SHitEffect>(this.CommonOverrideTable, rowName);
		if (dataTableRow3 != null)
		{
			return dataTableRow3;
		}
		return DataTableUtil.GetDataTableRow<SHitEffect>(HitEffectDataTableRepository.GetCommonHitEffectDataTable(), rowName);
	}

	// Token: 0x0601B200 RID: 111104 RVA: 0x007607C0 File Offset: 0x0075E9C0
	public override FightDataTableSnapshot CreateSnapshot(EEntityType entityType)
	{
		return new FightDataTableSnapshot
		{
			SelfTable = this.SelfTable,
			CommonTables = FightDataTableUtil.BuildCommonTables(new UDataTable[]
			{
				this.CommonOverrideTable,
				HitEffectDataTableRepository.GetCommonHitEffectDataTable()
			}),
			ExtraTables = ((this.ExtraTables == null) ? null : new List<UDataTable>(this.ExtraTables))
		};
	}

	// Token: 0x0601B201 RID: 111105 RVA: 0x0076081E File Offset: 0x0075EA1E
	[NullableContext(2)]
	public static UDataTable GetCommonHitEffectDataTable()
	{
		return WorldConfig.Instance.GetCommonHitEffectData();
	}
}

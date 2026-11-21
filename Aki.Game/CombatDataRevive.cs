using System;
using System.Runtime.CompilerServices;

// Token: 0x02002431 RID: 9265
public class CombatDataRevive : CombatDataBase
{
	// Token: 0x060172FA RID: 94970 RVA: 0x006CDDD0 File Offset: 0x006CBFD0
	public CombatDataRevive(int attackerId) : base(attackerId, 0)
	{
	}

	// Token: 0x060172FB RID: 94971 RVA: 0x006CDDDC File Offset: 0x006CBFDC
	[NullableContext(1)]
	public override string ParseToString()
	{
		string entityConfigName = CombatDataBase.GetEntityConfigName(this.AttackerId);
		return StringUtils.Format("<Date>{0}</><Atk>{1}</>复活", new string[]
		{
			this.DateCreate,
			entityConfigName ?? ""
		});
	}
}

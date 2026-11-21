using System;
using System.Runtime.CompilerServices;

// Token: 0x02002430 RID: 9264
public class CombatDataKilled : CombatDataBase
{
	// Token: 0x060172F8 RID: 94968 RVA: 0x006CDD6D File Offset: 0x006CBF6D
	public CombatDataKilled(int attackerId, int targetId) : base(attackerId, targetId)
	{
	}

	// Token: 0x060172F9 RID: 94969 RVA: 0x006CDD78 File Offset: 0x006CBF78
	[NullableContext(1)]
	public override string ParseToString()
	{
		string entityConfigName = CombatDataBase.GetEntityConfigName(this.AttackerId);
		string entityConfigName2 = CombatDataBase.GetEntityConfigName(this.TargetId);
		return StringUtils.Format("<Date>{0}</><Atk>{1}</>消灭了<Victim>{2}</>!", new string[]
		{
			this.DateCreate,
			entityConfigName ?? "",
			entityConfigName2 ?? ""
		});
	}
}

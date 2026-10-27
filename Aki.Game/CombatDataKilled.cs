using System;
using System.Runtime.CompilerServices;

// Token: 0x02002EDD RID: 11997
public class CombatDataKilled : CombatDataBase
{
	// Token: 0x060199F9 RID: 104953 RVA: 0x006A7BC9 File Offset: 0x006A5DC9
	public CombatDataKilled(int attackerId, int targetId) : base(attackerId, targetId)
	{
	}

	// Token: 0x060199FA RID: 104954 RVA: 0x006A7BD4 File Offset: 0x006A5DD4
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

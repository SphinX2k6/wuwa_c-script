using System;
using System.Runtime.CompilerServices;

// Token: 0x02002EDE RID: 11998
public class CombatDataRevive : CombatDataBase
{
	// Token: 0x060199FB RID: 104955 RVA: 0x006A7C2C File Offset: 0x006A5E2C
	public CombatDataRevive(int attackerId) : base(attackerId, 0)
	{
	}

	// Token: 0x060199FC RID: 104956 RVA: 0x006A7C38 File Offset: 0x006A5E38
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

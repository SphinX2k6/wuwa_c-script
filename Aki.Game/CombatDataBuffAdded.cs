using System;
using System.Runtime.CompilerServices;

// Token: 0x02002EDB RID: 11995
public class CombatDataBuffAdded : CombatDataBase
{
	// Token: 0x060199F5 RID: 104949 RVA: 0x006A7AF2 File Offset: 0x006A5CF2
	public CombatDataBuffAdded(int attackerId, long buffId, int targetId = 0) : base(attackerId, targetId)
	{
		this.BuffId = buffId;
	}

	// Token: 0x060199F6 RID: 104950 RVA: 0x006A7B04 File Offset: 0x006A5D04
	[NullableContext(1)]
	public override string ParseToString()
	{
		string entityConfigName = CombatDataBase.GetEntityConfigName(this.AttackerId);
		string entityConfigName2 = CombatDataBase.GetEntityConfigName(this.TargetId);
		return StringUtils.Format("<Date>{0}</><Victim>{1}</>获得了<Atk>{2}</>添加的Buff<NumDmg>{3}</>", new string[]
		{
			this.DateCreate,
			entityConfigName2 ?? "",
			entityConfigName ?? "",
			this.BuffId.ToString()
		});
	}

	// Token: 0x0400BFE6 RID: 49126
	public readonly long BuffId;
}

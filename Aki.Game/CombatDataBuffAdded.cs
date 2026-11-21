using System;
using System.Runtime.CompilerServices;

// Token: 0x0200242E RID: 9262
public class CombatDataBuffAdded : CombatDataBase
{
	// Token: 0x060172F4 RID: 94964 RVA: 0x006CDC96 File Offset: 0x006CBE96
	public CombatDataBuffAdded(int attackerId, long buffId, int targetId = 0) : base(attackerId, targetId)
	{
		this.BuffId = buffId;
	}

	// Token: 0x060172F5 RID: 94965 RVA: 0x006CDCA8 File Offset: 0x006CBEA8
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

	// Token: 0x0400C381 RID: 50049
	public readonly long BuffId;
}

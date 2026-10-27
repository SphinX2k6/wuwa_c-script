using System;
using System.Runtime.CompilerServices;

// Token: 0x02002EDC RID: 11996
public class CombatDataBuffRemoved : CombatDataBase
{
	// Token: 0x060199F7 RID: 104951 RVA: 0x006A7B6A File Offset: 0x006A5D6A
	public CombatDataBuffRemoved(int attackerId, long buffId, int targetId = 0) : base(attackerId, targetId)
	{
		this.BuffId = buffId;
	}

	// Token: 0x060199F8 RID: 104952 RVA: 0x006A7B7C File Offset: 0x006A5D7C
	[NullableContext(1)]
	public override string ParseToString()
	{
		string entityConfigName = CombatDataBase.GetEntityConfigName(this.TargetId);
		return StringUtils.Format("<Date>{0}</><Victim>{1}</>失去了Buff<NumDmg>{2}</>", new string[]
		{
			this.DateCreate,
			entityConfigName ?? "",
			this.BuffId.ToString()
		});
	}

	// Token: 0x0400BFE7 RID: 49127
	public readonly long BuffId;
}

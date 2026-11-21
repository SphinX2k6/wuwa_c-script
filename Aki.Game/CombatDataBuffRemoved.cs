using System;
using System.Runtime.CompilerServices;

// Token: 0x0200242F RID: 9263
public class CombatDataBuffRemoved : CombatDataBase
{
	// Token: 0x060172F6 RID: 94966 RVA: 0x006CDD0E File Offset: 0x006CBF0E
	public CombatDataBuffRemoved(int attackerId, long buffId, int targetId = 0) : base(attackerId, targetId)
	{
		this.BuffId = buffId;
	}

	// Token: 0x060172F7 RID: 94967 RVA: 0x006CDD20 File Offset: 0x006CBF20
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

	// Token: 0x0400C382 RID: 50050
	public readonly long BuffId;
}

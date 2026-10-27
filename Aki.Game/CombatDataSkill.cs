using System;
using System.Runtime.CompilerServices;

// Token: 0x02002EDA RID: 11994
public class CombatDataSkill : CombatDataBase
{
	// Token: 0x060199F3 RID: 104947 RVA: 0x006A7A80 File Offset: 0x006A5C80
	public CombatDataSkill(int attackerId, int skillId, int targetId = 0) : base(attackerId, targetId)
	{
		this.SkillId = skillId;
	}

	// Token: 0x060199F4 RID: 104948 RVA: 0x006A7A94 File Offset: 0x006A5C94
	[NullableContext(1)]
	public override string ParseToString()
	{
		string entityConfigName = CombatDataBase.GetEntityConfigName(this.AttackerId);
		string skillConfigName = CombatDataBase.GetSkillConfigName(this.AttackerId, this.SkillId);
		return StringUtils.Format("<Date>[{0}]</><Atk>{1}</>施放了技能<Skill>{2}</>。", new string[]
		{
			this.DateCreate,
			entityConfigName ?? "",
			skillConfigName ?? ""
		});
	}

	// Token: 0x0400BFE5 RID: 49125
	public readonly int SkillId;
}

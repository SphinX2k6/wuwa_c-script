using System;
using System.Runtime.CompilerServices;

// Token: 0x0200242D RID: 9261
public class CombatDataSkill : CombatDataBase
{
	// Token: 0x060172F2 RID: 94962 RVA: 0x006CDC24 File Offset: 0x006CBE24
	public CombatDataSkill(int attackerId, int skillId, int targetId = 0) : base(attackerId, targetId)
	{
		this.SkillId = skillId;
	}

	// Token: 0x060172F3 RID: 94963 RVA: 0x006CDC38 File Offset: 0x006CBE38
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

	// Token: 0x0400C380 RID: 50048
	public readonly int SkillId;
}

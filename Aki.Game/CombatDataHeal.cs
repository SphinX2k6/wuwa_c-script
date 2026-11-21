using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200242C RID: 9260
public class CombatDataHeal : CombatDataBase
{
	// Token: 0x060172F0 RID: 94960 RVA: 0x006CDB1A File Offset: 0x006CBD1A
	public CombatDataHeal(int attackerId, long healId, int healValue, int skillId, int targetId = 0) : base(attackerId, targetId)
	{
		this.HealId = healId;
		this.HealValue = healValue;
		this.SkillId = skillId;
	}

	// Token: 0x060172F1 RID: 94961 RVA: 0x006CDB3C File Offset: 0x006CBD3C
	[NullableContext(1)]
	public override string ParseToString()
	{
		string[] entityConfigNameAndSkillName = CombatDataBase.GetEntityConfigNameAndSkillName(this.AttackerId, this.HealId, this.SkillId);
		string entityConfigName = CombatDataBase.GetEntityConfigName(this.TargetId);
		BaseAttributeComponent component = EntitySystem.Instance.Get(this.TargetId).GetComponent<BaseAttributeComponent>();
		float currentValue = component.GetCurrentValue(EAttributeType.Life);
		float currentValue2 = component.GetCurrentValue(EAttributeType.LifeMax);
		return StringUtils.Format("<Date>[{0}]</><Atk>{1}</>施放了<Skill>{2}</>使<Victim>{3}</>恢复<NumDmg>{4}</>点生命<Change>{5}</>", new string[]
		{
			this.DateCreate,
			entityConfigNameAndSkillName[0] ?? "",
			entityConfigNameAndSkillName[1] ?? "",
			entityConfigName ?? "",
			this.HealValue.ToString(),
			(currentValue == currentValue2) ? "(满血)" : StringUtils.Format("({0}->{1})", new string[]
			{
				((int)currentValue).ToString(),
				((int)currentValue - this.HealValue).ToString()
			})
		});
	}

	// Token: 0x0400C37D RID: 50045
	public readonly long HealId;

	// Token: 0x0400C37E RID: 50046
	public readonly int HealValue;

	// Token: 0x0400C37F RID: 50047
	public readonly int SkillId;
}

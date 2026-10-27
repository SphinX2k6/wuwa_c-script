using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002ED9 RID: 11993
public class CombatDataHeal : CombatDataBase
{
	// Token: 0x060199F1 RID: 104945 RVA: 0x006A7976 File Offset: 0x006A5B76
	public CombatDataHeal(int attackerId, long healId, int healValue, int skillId, int targetId = 0) : base(attackerId, targetId)
	{
		this.HealId = healId;
		this.HealValue = healValue;
		this.SkillId = skillId;
	}

	// Token: 0x060199F2 RID: 104946 RVA: 0x006A7998 File Offset: 0x006A5B98
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

	// Token: 0x0400BFE2 RID: 49122
	public readonly long HealId;

	// Token: 0x0400BFE3 RID: 49123
	public readonly int HealValue;

	// Token: 0x0400BFE4 RID: 49124
	public readonly int SkillId;
}

using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002ED8 RID: 11992
public class CombatDataDamage : CombatDataBase
{
	// Token: 0x060199EF RID: 104943 RVA: 0x006A7870 File Offset: 0x006A5A70
	public CombatDataDamage(int attackerId, long damageId, int damageValue, int skillId, int targetId = 0) : base(attackerId, targetId)
	{
		this.DamageId = damageId;
		this.DamageValue = damageValue;
		this.SkillId = skillId;
	}

	// Token: 0x060199F0 RID: 104944 RVA: 0x006A7894 File Offset: 0x006A5A94
	[NullableContext(1)]
	public override string ParseToString()
	{
		string[] entityConfigNameAndSkillName = CombatDataBase.GetEntityConfigNameAndSkillName(this.AttackerId, this.DamageId, this.SkillId);
		string entityConfigName = CombatDataBase.GetEntityConfigName(this.TargetId);
		float currentValue = EntitySystem.Instance.Get(this.TargetId).GetComponent<BaseAttributeComponent>().GetCurrentValue(EAttributeType.Life);
		return StringUtils.Format("<Date>[{0}]</><Atk>{1}</>施放了<Skill>{2}</>对<Victim>{3}</>造成<NumDmg>{4}</>点伤害<Change>{5}</>", new string[]
		{
			this.DateCreate,
			entityConfigNameAndSkillName[0] ?? "",
			entityConfigNameAndSkillName[1] ?? "",
			entityConfigName ?? "",
			this.DamageValue.ToString(),
			(currentValue <= 0f) ? "(死亡)" : StringUtils.Format("({0}->{1})", new string[]
			{
				((int)currentValue + this.DamageValue).ToString(),
				((int)currentValue).ToString()
			})
		});
	}

	// Token: 0x0400BFDF RID: 49119
	public readonly long DamageId;

	// Token: 0x0400BFE0 RID: 49120
	public readonly int DamageValue;

	// Token: 0x0400BFE1 RID: 49121
	public readonly int SkillId;
}

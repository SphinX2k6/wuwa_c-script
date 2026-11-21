using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200242B RID: 9259
public class CombatDataDamage : CombatDataBase
{
	// Token: 0x060172EE RID: 94958 RVA: 0x006CDA14 File Offset: 0x006CBC14
	public CombatDataDamage(int attackerId, long damageId, int damageValue, int skillId, int targetId = 0) : base(attackerId, targetId)
	{
		this.DamageId = damageId;
		this.DamageValue = damageValue;
		this.SkillId = skillId;
	}

	// Token: 0x060172EF RID: 94959 RVA: 0x006CDA38 File Offset: 0x006CBC38
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

	// Token: 0x0400C37A RID: 50042
	public readonly long DamageId;

	// Token: 0x0400C37B RID: 50043
	public readonly int DamageValue;

	// Token: 0x0400C37C RID: 50044
	public readonly int SkillId;
}

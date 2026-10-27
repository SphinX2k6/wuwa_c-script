using System;
using System.Runtime.CompilerServices;

// Token: 0x02001B0F RID: 6927
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchUnlockSkillData : FloroRanchUnlockDataBase
{
	// Token: 0x0600CD95 RID: 52629 RVA: 0x002ED384 File Offset: 0x002EB584
	public FloroRanchUnlockSkillData(int id, bool isUnLock, int conditionId) : base(id, isUnLock, conditionId, EFloroRanchCardType.Skill)
	{
	}

	// Token: 0x0600CD96 RID: 52630 RVA: 0x002ED390 File Offset: 0x002EB590
	public void SetSkillData(FloroRanchSkillData skillData)
	{
		this.SkillData = skillData;
	}

	// Token: 0x0600CD97 RID: 52631 RVA: 0x002ED399 File Offset: 0x002EB599
	public FloroRanchSkillData GetSkillData()
	{
		return this.SkillData;
	}

	// Token: 0x0600CD98 RID: 52632 RVA: 0x002ED3A1 File Offset: 0x002EB5A1
	protected string GetConditionText()
	{
		return LevelGeneralCommons.GetConditionGroupHintText(this.ConditionId) ?? "";
	}

	// Token: 0x04005E4B RID: 24139
	private FloroRanchSkillData SkillData;
}

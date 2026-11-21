using System;
using System.Runtime.CompilerServices;

// Token: 0x02000FCE RID: 4046
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchUnlockSkillData : FloroRanchUnlockDataBase
{
	// Token: 0x0600A1A6 RID: 41382 RVA: 0x002F8470 File Offset: 0x002F6670
	public FloroRanchUnlockSkillData(int id, bool isUnLock, int conditionId) : base(id, isUnLock, conditionId, EFloroRanchCardType.Skill)
	{
	}

	// Token: 0x0600A1A7 RID: 41383 RVA: 0x002F847C File Offset: 0x002F667C
	public void SetSkillData(FloroRanchSkillData skillData)
	{
		this.SkillData = skillData;
	}

	// Token: 0x0600A1A8 RID: 41384 RVA: 0x002F8485 File Offset: 0x002F6685
	public FloroRanchSkillData GetSkillData()
	{
		return this.SkillData;
	}

	// Token: 0x0600A1A9 RID: 41385 RVA: 0x002F848D File Offset: 0x002F668D
	protected string GetConditionText()
	{
		return LevelGeneralCommons.GetConditionGroupHintText(this.ConditionId) ?? "";
	}

	// Token: 0x04005F1A RID: 24346
	private FloroRanchSkillData SkillData;
}

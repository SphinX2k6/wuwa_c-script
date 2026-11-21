using System;
using System.Runtime.CompilerServices;

// Token: 0x02001E3A RID: 7738
[NullableContext(2)]
[Nullable(0)]
public class RoleSkillResponseData
{
	// Token: 0x06013232 RID: 78386 RVA: 0x00597C1F File Offset: 0x00595E1F
	public void UpdateRoleSkillViewResponse(SkillEffect skillEffectList, SkillEffect nextSkillEffectList, int skillId)
	{
		this.SkillEffectList = skillEffectList;
		this.NextSkillEffectList = nextSkillEffectList;
		this.SkillId = skillId;
	}

	// Token: 0x06013233 RID: 78387 RVA: 0x00597C36 File Offset: 0x00595E36
	public int GetSkillId()
	{
		return this.SkillId;
	}

	// Token: 0x06013234 RID: 78388 RVA: 0x00597C3E File Offset: 0x00595E3E
	public SkillEffect GetSkillEffect()
	{
		return this.SkillEffectList;
	}

	// Token: 0x06013235 RID: 78389 RVA: 0x00597C46 File Offset: 0x00595E46
	public SkillEffect GetNextLevelSkillEffect()
	{
		return this.NextSkillEffectList;
	}

	// Token: 0x0400A432 RID: 42034
	private SkillEffect SkillEffectList;

	// Token: 0x0400A433 RID: 42035
	private SkillEffect NextSkillEffectList;

	// Token: 0x0400A434 RID: 42036
	private int SkillId;
}

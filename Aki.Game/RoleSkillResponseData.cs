using System;
using System.Runtime.CompilerServices;

// Token: 0x020028BF RID: 10431
[NullableContext(2)]
[Nullable(0)]
public class RoleSkillResponseData
{
	// Token: 0x06015832 RID: 88114 RVA: 0x0056CDD7 File Offset: 0x0056AFD7
	public void UpdateRoleSkillViewResponse(SkillEffect skillEffectList, SkillEffect nextSkillEffectList, int skillId)
	{
		this.SkillEffectList = skillEffectList;
		this.NextSkillEffectList = nextSkillEffectList;
		this.SkillId = skillId;
	}

	// Token: 0x06015833 RID: 88115 RVA: 0x0056CDEE File Offset: 0x0056AFEE
	public int GetSkillId()
	{
		return this.SkillId;
	}

	// Token: 0x06015834 RID: 88116 RVA: 0x0056CDF6 File Offset: 0x0056AFF6
	public SkillEffect GetSkillEffect()
	{
		return this.SkillEffectList;
	}

	// Token: 0x06015835 RID: 88117 RVA: 0x0056CDFE File Offset: 0x0056AFFE
	public SkillEffect GetNextLevelSkillEffect()
	{
		return this.NextSkillEffectList;
	}

	// Token: 0x0400A049 RID: 41033
	private SkillEffect SkillEffectList;

	// Token: 0x0400A04A RID: 41034
	private SkillEffect NextSkillEffectList;

	// Token: 0x0400A04B RID: 41035
	private int SkillId;
}

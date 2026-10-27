using System;
using System.Runtime.CompilerServices;

// Token: 0x02002796 RID: 10134
[NullableContext(1)]
[Nullable(0)]
public class TeamRoleSkillData
{
	// Token: 0x04009C95 RID: 40085
	public string SkillIcon = "";

	// Token: 0x04009C96 RID: 40086
	public int SkillType;

	// Token: 0x04009C97 RID: 40087
	public string SkillTypeText = "";

	// Token: 0x04009C98 RID: 40088
	public string SkillName = "";

	// Token: 0x04009C99 RID: 40089
	[Nullable(2)]
	public int[] SkillTagList;

	// Token: 0x04009C9A RID: 40090
	public bool ShowSkillToggle = true;

	// Token: 0x04009C9B RID: 40091
	public string SkillDesc = "";

	// Token: 0x04009C9C RID: 40092
	public string[] SkillDescNum = new string[0];

	// Token: 0x04009C9D RID: 40093
	public string MultiSkillDesc = "";

	// Token: 0x04009C9E RID: 40094
	public string[] MultiSkillDescNum = new string[0];

	// Token: 0x04009C9F RID: 40095
	public string SkillResume = "";

	// Token: 0x04009CA0 RID: 40096
	public string[] SkillResumeNum = new string[0];
}

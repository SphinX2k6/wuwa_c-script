using System;
using System.Runtime.CompilerServices;

// Token: 0x02001C81 RID: 7297
[NullableContext(1)]
[Nullable(0)]
public class TeamRoleSkillData
{
	// Token: 0x04009DF9 RID: 40441
	public string SkillIcon = "";

	// Token: 0x04009DFA RID: 40442
	public int SkillType;

	// Token: 0x04009DFB RID: 40443
	public string SkillTypeText = "";

	// Token: 0x04009DFC RID: 40444
	public string SkillName = "";

	// Token: 0x04009DFD RID: 40445
	[Nullable(2)]
	public int[] SkillTagList;

	// Token: 0x04009DFE RID: 40446
	public bool ShowSkillToggle = true;

	// Token: 0x04009DFF RID: 40447
	public string SkillDesc = "";

	// Token: 0x04009E00 RID: 40448
	public string[] SkillDescNum = new string[0];

	// Token: 0x04009E01 RID: 40449
	public string MultiSkillDesc = "";

	// Token: 0x04009E02 RID: 40450
	public string[] MultiSkillDescNum = new string[0];

	// Token: 0x04009E03 RID: 40451
	public string SkillResume = "";

	// Token: 0x04009E04 RID: 40452
	public string[] SkillResumeNum = new string[0];
}

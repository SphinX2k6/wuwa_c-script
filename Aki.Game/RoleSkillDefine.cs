using System;
using System.Runtime.CompilerServices;

// Token: 0x02001E2A RID: 7722
public class RoleSkillDefine : IStaticVariableResetter
{
	// Token: 0x060131AB RID: 78251 RVA: 0x00595A64 File Offset: 0x00593C64
	static RoleSkillDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleSkillDefine.CreateStaticDefaultValue), new Action(RoleSkillDefine.ResetStaticDefaultValue));
	}

	// Token: 0x060131AC RID: 78252 RVA: 0x00595A83 File Offset: 0x00593C83
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060131AD RID: 78253 RVA: 0x00595A85 File Offset: 0x00593C85
	public static void ResetStaticDefaultValue()
	{
	}

	// Token: 0x0400A414 RID: 42004
	[Nullable(1)]
	public const string RECOMMEND_SKILL_SHOW_TAG_RESOURCE_ID = "T_RoleDevelopRecommendA";

	// Token: 0x0400A415 RID: 42005
	[Nullable(1)]
	public const string CORE_SKILL_SHOW_TAG_RESOURCE_ID = "T_RoleDevelopRecommendB";
}

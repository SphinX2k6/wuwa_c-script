using System;
using System.Runtime.CompilerServices;

// Token: 0x020028AF RID: 10415
public class RoleSkillDefine : IStaticVariableResetter
{
	// Token: 0x060157AB RID: 87979 RVA: 0x0056AC1C File Offset: 0x00568E1C
	static RoleSkillDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleSkillDefine.CreateStaticDefaultValue), new Action(RoleSkillDefine.ResetStaticDefaultValue));
	}

	// Token: 0x060157AC RID: 87980 RVA: 0x0056AC3B File Offset: 0x00568E3B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060157AD RID: 87981 RVA: 0x0056AC3D File Offset: 0x00568E3D
	public static void ResetStaticDefaultValue()
	{
	}

	// Token: 0x0400A02B RID: 41003
	[Nullable(1)]
	public const string RECOMMEND_SKILL_SHOW_TAG_RESOURCE_ID = "T_RoleDevelopRecommendA";

	// Token: 0x0400A02C RID: 41004
	[Nullable(1)]
	public const string CORE_SKILL_SHOW_TAG_RESOURCE_ID = "T_RoleDevelopRecommend";
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001099 RID: 4249
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class FormationConfig : ConfigBase
{
	// Token: 0x0600A8A0 RID: 43168 RVA: 0x00319F24 File Offset: 0x00318124
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600A8A1 RID: 43169 RVA: 0x00319F27 File Offset: 0x00318127
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x0600A8A2 RID: 43170 RVA: 0x00319F2C File Offset: 0x0031812C
	public int GetMaxFormationId()
	{
		return ConfigCommonParamById.GetIntConfig("FormationNumLimit").Value;
	}

	// Token: 0x0600A8A3 RID: 43171 RVA: 0x00319F4C File Offset: 0x0031814C
	public FightFormation? GetFightFormationConfig(int fightFormationId)
	{
		if (fightFormationId == 0)
		{
			return null;
		}
		return ConfigFightFormationById.GetConfig(fightFormationId, true);
	}

	// Token: 0x0600A8A4 RID: 43172 RVA: 0x00319F70 File Offset: 0x00318170
	public FormationMotion? GetFormationMotionConfigByRoleIdAndPosition(int roleId, int position, int skinId = 0)
	{
		if (roleId == 0 || position == 0)
		{
			FormationMotion? result = null;
			return result;
		}
		IReadOnlyList<FormationMotion> configList = ConfigFormationMotionByRoleIdAndPosition.GetConfigList(roleId, position, true);
		if (configList == null || configList.Count == 0)
		{
			FormationMotion? result = null;
			return result;
		}
		foreach (FormationMotion value in configList)
		{
			if (value.SkinId == skinId)
			{
				return new FormationMotion?(value);
			}
		}
		foreach (FormationMotion value2 in configList)
		{
			if (value2.SkinId == 0)
			{
				return new FormationMotion?(value2);
			}
		}
		return new FormationMotion?(configList[0]);
	}

	// Token: 0x0600A8A5 RID: 43173 RVA: 0x0031A044 File Offset: 0x00318244
	public string GetSkillBranchIcon(int roleId, int index)
	{
		int p0Id = roleId;
		if (roleId > 100000)
		{
			TrialRoleInfo? config = ConfigTrialRoleInfoById.GetConfig(roleId, true);
			if (config != null)
			{
				p0Id = config.Value.ParentId;
			}
		}
		RoleInfo? config2 = ConfigRoleInfoById.GetConfig(p0Id, true);
		if (config2 == null || index < 0 || index >= config2.Value.SkillBranchIdsLength)
		{
			return "";
		}
		int num = config2.Value.SkillBranchIds(index);
		if (num == 0)
		{
			return "";
		}
		SkillBranch? config3 = ConfigSkillBranchById.GetConfig(num, true);
		return ((config3 != null) ? config3.GetValueOrDefault().Icon : null) ?? "";
	}

	// Token: 0x17001193 RID: 4499
	// (get) Token: 0x0600A8A6 RID: 43174 RVA: 0x0031A0F4 File Offset: 0x003182F4
	public static FormationConfig Instance
	{
		get
		{
			return FormationConfig._Instance;
		}
	}

	// Token: 0x0600A8A7 RID: 43175 RVA: 0x0031A0FB File Offset: 0x003182FB
	public static FormationConfig GetOrCreateInstance()
	{
		if (FormationConfig._Instance == null)
		{
			FormationConfig.CreateInstance();
		}
		return FormationConfig._Instance;
	}

	// Token: 0x0600A8A8 RID: 43176 RVA: 0x0031A10F File Offset: 0x0031830F
	public static bool CreateInstance()
	{
		if (FormationConfig._Instance != null)
		{
			return true;
		}
		FormationConfig._Instance = new FormationConfig();
		return true;
	}

	// Token: 0x0600A8A9 RID: 43177 RVA: 0x0031A125 File Offset: 0x00318325
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A8AA RID: 43178 RVA: 0x0031A127 File Offset: 0x00318327
	public static void ResetStaticDefaultValue()
	{
		FormationConfig._Instance = null;
	}

	// Token: 0x0600A8AB RID: 43179 RVA: 0x0031A12F File Offset: 0x0031832F
	static FormationConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FormationConfig.CreateStaticDefaultValue), new Action(FormationConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040061EF RID: 25071
	private const int TrialRoleConfigIdMin = 100000;

	// Token: 0x040061F0 RID: 25072
	[Nullable(2)]
	private static FormationConfig _Instance;
}

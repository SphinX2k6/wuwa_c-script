using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001BDA RID: 7130
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class FormationConfig : ConfigBase
{
	// Token: 0x0600D48E RID: 54414 RVA: 0x0030EDB0 File Offset: 0x0030CFB0
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600D48F RID: 54415 RVA: 0x0030EDB3 File Offset: 0x0030CFB3
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x0600D490 RID: 54416 RVA: 0x0030EDB8 File Offset: 0x0030CFB8
	public int GetMaxFormationId()
	{
		return ConfigCommonParamById.GetIntConfig("FormationNumLimit").Value;
	}

	// Token: 0x0600D491 RID: 54417 RVA: 0x0030EDD8 File Offset: 0x0030CFD8
	public FightFormation? GetFightFormationConfig(int fightFormationId)
	{
		if (fightFormationId == 0)
		{
			return null;
		}
		return ConfigFightFormationById.GetConfig(fightFormationId, true);
	}

	// Token: 0x0600D492 RID: 54418 RVA: 0x0030EDFC File Offset: 0x0030CFFC
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

	// Token: 0x0600D493 RID: 54419 RVA: 0x0030EED0 File Offset: 0x0030D0D0
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

	// Token: 0x1700116E RID: 4462
	// (get) Token: 0x0600D494 RID: 54420 RVA: 0x0030EF80 File Offset: 0x0030D180
	public static FormationConfig Instance
	{
		get
		{
			return FormationConfig._Instance;
		}
	}

	// Token: 0x0600D495 RID: 54421 RVA: 0x0030EF87 File Offset: 0x0030D187
	public static FormationConfig GetOrCreateInstance()
	{
		if (FormationConfig._Instance == null)
		{
			FormationConfig.CreateInstance();
		}
		return FormationConfig._Instance;
	}

	// Token: 0x0600D496 RID: 54422 RVA: 0x0030EF9B File Offset: 0x0030D19B
	public static bool CreateInstance()
	{
		if (FormationConfig._Instance != null)
		{
			return true;
		}
		FormationConfig._Instance = new FormationConfig();
		return true;
	}

	// Token: 0x0600D497 RID: 54423 RVA: 0x0030EFB1 File Offset: 0x0030D1B1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D498 RID: 54424 RVA: 0x0030EFB3 File Offset: 0x0030D1B3
	public static void ResetStaticDefaultValue()
	{
		FormationConfig._Instance = null;
	}

	// Token: 0x0600D499 RID: 54425 RVA: 0x0030EFBB File Offset: 0x0030D1BB
	static FormationConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FormationConfig.CreateStaticDefaultValue), new Action(FormationConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04006120 RID: 24864
	private const int TrialRoleConfigIdMin = 100000;

	// Token: 0x04006121 RID: 24865
	[Nullable(2)]
	private static FormationConfig _Instance;
}

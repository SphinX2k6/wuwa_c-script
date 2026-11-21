using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200065B RID: 1627
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityBlackCoastConfig : ConfigBase
{
	// Token: 0x06004B3A RID: 19258 RVA: 0x001993E2 File Offset: 0x001975E2
	public BlackCoastThemeConfig? GetActivityConfig(int activityId)
	{
		return ConfigBlackCoastThemeConfigByActivityId.GetConfig(activityId, true);
	}

	// Token: 0x06004B3B RID: 19259 RVA: 0x001993EB File Offset: 0x001975EB
	public BlackCoastThemeStageRe? GetStageConfig(int stageId)
	{
		return ConfigBlackCoastThemeStageReById.GetConfig(stageId, true);
	}

	// Token: 0x06004B3C RID: 19260 RVA: 0x001993F4 File Offset: 0x001975F4
	public IReadOnlyList<BlackCoastThemeStageRe> GetAllStageConfigByActivityId(int activityId)
	{
		return ConfigBlackCoastThemeStageReByActivityId.GetConfigList(activityId, true) ?? Array.Empty<BlackCoastThemeStageRe>();
	}

	// Token: 0x06004B3D RID: 19261 RVA: 0x00199406 File Offset: 0x00197606
	public BlackCoastThemeTaskRe? GetTaskConfig(int taskId)
	{
		return ConfigBlackCoastThemeTaskReByTaskId.GetConfig(taskId, true);
	}

	// Token: 0x06004B3E RID: 19262 RVA: 0x0019940F File Offset: 0x0019760F
	public IReadOnlyList<BlackCoastThemeTaskRe> GetAllTaskConfigByStageId(int stageId)
	{
		return ConfigBlackCoastThemeTaskReByStageId.GetConfigList(stageId, true) ?? Array.Empty<BlackCoastThemeTaskRe>();
	}

	// Token: 0x06004B3F RID: 19263 RVA: 0x00199421 File Offset: 0x00197621
	public BlackCoastThemeRewardRe? GetRewardConfig(int id)
	{
		return ConfigBlackCoastThemeRewardReById.GetConfig(id, true);
	}

	// Token: 0x06004B40 RID: 19264 RVA: 0x0019942A File Offset: 0x0019762A
	public IReadOnlyList<BlackCoastThemeRewardRe> GetAllRewardConfigByActivityId(int activityId)
	{
		return ConfigBlackCoastThemeRewardReByActivityId.GetConfigList(activityId, true) ?? Array.Empty<BlackCoastThemeRewardRe>();
	}

	// Token: 0x17000A61 RID: 2657
	// (get) Token: 0x06004B41 RID: 19265 RVA: 0x0019943C File Offset: 0x0019763C
	public static ActivityBlackCoastConfig Instance
	{
		get
		{
			return ActivityBlackCoastConfig._Instance;
		}
	}

	// Token: 0x06004B42 RID: 19266 RVA: 0x00199443 File Offset: 0x00197643
	public static ActivityBlackCoastConfig GetOrCreateInstance()
	{
		if (ActivityBlackCoastConfig._Instance == null)
		{
			ActivityBlackCoastConfig.CreateInstance();
		}
		return ActivityBlackCoastConfig._Instance;
	}

	// Token: 0x06004B43 RID: 19267 RVA: 0x00199457 File Offset: 0x00197657
	public static bool CreateInstance()
	{
		if (ActivityBlackCoastConfig._Instance != null)
		{
			return true;
		}
		ActivityBlackCoastConfig._Instance = new ActivityBlackCoastConfig();
		return true;
	}

	// Token: 0x06004B44 RID: 19268 RVA: 0x0019946D File Offset: 0x0019766D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004B45 RID: 19269 RVA: 0x0019946F File Offset: 0x0019766F
	public static void ResetStaticDefaultValue()
	{
		ActivityBlackCoastConfig._Instance = null;
	}

	// Token: 0x06004B46 RID: 19270 RVA: 0x00199477 File Offset: 0x00197677
	static ActivityBlackCoastConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityBlackCoastConfig.CreateStaticDefaultValue), new Action(ActivityBlackCoastConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040037B8 RID: 14264
	[Nullable(2)]
	private static ActivityBlackCoastConfig _Instance;
}

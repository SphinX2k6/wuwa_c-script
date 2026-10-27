using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020011A7 RID: 4519
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityBlackCoastConfig : ConfigBase
{
	// Token: 0x060077A3 RID: 30627 RVA: 0x001907FE File Offset: 0x0018E9FE
	public BlackCoastThemeConfig? GetActivityConfig(int activityId)
	{
		return ConfigBlackCoastThemeConfigByActivityId.GetConfig(activityId, true);
	}

	// Token: 0x060077A4 RID: 30628 RVA: 0x00190807 File Offset: 0x0018EA07
	public BlackCoastThemeStageRe? GetStageConfig(int stageId)
	{
		return ConfigBlackCoastThemeStageReById.GetConfig(stageId, true);
	}

	// Token: 0x060077A5 RID: 30629 RVA: 0x00190810 File Offset: 0x0018EA10
	public IReadOnlyList<BlackCoastThemeStageRe> GetAllStageConfigByActivityId(int activityId)
	{
		return ConfigBlackCoastThemeStageReByActivityId.GetConfigList(activityId, true) ?? Array.Empty<BlackCoastThemeStageRe>();
	}

	// Token: 0x060077A6 RID: 30630 RVA: 0x00190822 File Offset: 0x0018EA22
	public BlackCoastThemeTaskRe? GetTaskConfig(int taskId)
	{
		return ConfigBlackCoastThemeTaskReByTaskId.GetConfig(taskId, true);
	}

	// Token: 0x060077A7 RID: 30631 RVA: 0x0019082B File Offset: 0x0018EA2B
	public IReadOnlyList<BlackCoastThemeTaskRe> GetAllTaskConfigByStageId(int stageId)
	{
		return ConfigBlackCoastThemeTaskReByStageId.GetConfigList(stageId, true) ?? Array.Empty<BlackCoastThemeTaskRe>();
	}

	// Token: 0x060077A8 RID: 30632 RVA: 0x0019083D File Offset: 0x0018EA3D
	public BlackCoastThemeRewardRe? GetRewardConfig(int id)
	{
		return ConfigBlackCoastThemeRewardReById.GetConfig(id, true);
	}

	// Token: 0x060077A9 RID: 30633 RVA: 0x00190846 File Offset: 0x0018EA46
	public IReadOnlyList<BlackCoastThemeRewardRe> GetAllRewardConfigByActivityId(int activityId)
	{
		return ConfigBlackCoastThemeRewardReByActivityId.GetConfigList(activityId, true) ?? Array.Empty<BlackCoastThemeRewardRe>();
	}

	// Token: 0x17000A41 RID: 2625
	// (get) Token: 0x060077AA RID: 30634 RVA: 0x00190858 File Offset: 0x0018EA58
	public static ActivityBlackCoastConfig Instance
	{
		get
		{
			return ActivityBlackCoastConfig._Instance;
		}
	}

	// Token: 0x060077AB RID: 30635 RVA: 0x0019085F File Offset: 0x0018EA5F
	public static ActivityBlackCoastConfig GetOrCreateInstance()
	{
		if (ActivityBlackCoastConfig._Instance == null)
		{
			ActivityBlackCoastConfig.CreateInstance();
		}
		return ActivityBlackCoastConfig._Instance;
	}

	// Token: 0x060077AC RID: 30636 RVA: 0x00190873 File Offset: 0x0018EA73
	public static bool CreateInstance()
	{
		if (ActivityBlackCoastConfig._Instance != null)
		{
			return true;
		}
		ActivityBlackCoastConfig._Instance = new ActivityBlackCoastConfig();
		return true;
	}

	// Token: 0x060077AD RID: 30637 RVA: 0x00190889 File Offset: 0x0018EA89
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060077AE RID: 30638 RVA: 0x0019088B File Offset: 0x0018EA8B
	public static void ResetStaticDefaultValue()
	{
		ActivityBlackCoastConfig._Instance = null;
	}

	// Token: 0x060077AF RID: 30639 RVA: 0x00190893 File Offset: 0x0018EA93
	static ActivityBlackCoastConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityBlackCoastConfig.CreateStaticDefaultValue), new Action(ActivityBlackCoastConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400371F RID: 14111
	[Nullable(2)]
	private static ActivityBlackCoastConfig _Instance;
}

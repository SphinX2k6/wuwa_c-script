using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020013B3 RID: 5043
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityNewPlayerSupportConfig : ConfigBase
{
	// Token: 0x06008E0A RID: 36362 RVA: 0x001EA4B8 File Offset: 0x001E86B8
	public NewPlayerSupportTask GetTaskConfig(int id)
	{
		return ConfigNewPlayerSupportTaskById.GetConfig(id, true).Value;
	}

	// Token: 0x06008E0B RID: 36363 RVA: 0x001EA4D4 File Offset: 0x001E86D4
	[NullableContext(2)]
	public IReadOnlyList<NewPlayerSupportTask> GetAllTaskConfigs()
	{
		return ConfigNewPlayerSupportTaskAll.GetConfigList(true);
	}

	// Token: 0x06008E0C RID: 36364 RVA: 0x001EA4DC File Offset: 0x001E86DC
	public Dictionary<int, string> GetTrialRoleUnlockDesc()
	{
		Dictionary<int, string> dictionary = new Dictionary<int, string>();
		foreach (NewPlayerSupportTask newPlayerSupportTask in (this.GetAllTaskConfigs() ?? Array.Empty<NewPlayerSupportTask>()))
		{
			ConditionGroup? conditionGroup;
			string value = ((ConditionConfig.Instance.GetConditionGroupConfig(newPlayerSupportTask.ConditionGroup) != null) ? conditionGroup.GetValueOrDefault().HintText : null) ?? "";
			dictionary[newPlayerSupportTask.TrialRoleGroupId] = value;
		}
		return dictionary;
	}

	// Token: 0x06008E0D RID: 36365 RVA: 0x001EA57C File Offset: 0x001E877C
	public ConditionGroup? GetConditionGroup(int conditionId)
	{
		return ConfigConditionGroupById.GetConfig(conditionId, true);
	}

	// Token: 0x17000BEE RID: 3054
	// (get) Token: 0x06008E0E RID: 36366 RVA: 0x001EA585 File Offset: 0x001E8785
	public static ActivityNewPlayerSupportConfig Instance
	{
		get
		{
			return ActivityNewPlayerSupportConfig._Instance;
		}
	}

	// Token: 0x06008E0F RID: 36367 RVA: 0x001EA58C File Offset: 0x001E878C
	public static ActivityNewPlayerSupportConfig GetOrCreateInstance()
	{
		if (ActivityNewPlayerSupportConfig._Instance == null)
		{
			ActivityNewPlayerSupportConfig.CreateInstance();
		}
		return ActivityNewPlayerSupportConfig._Instance;
	}

	// Token: 0x06008E10 RID: 36368 RVA: 0x001EA5A0 File Offset: 0x001E87A0
	public static bool CreateInstance()
	{
		if (ActivityNewPlayerSupportConfig._Instance != null)
		{
			return true;
		}
		ActivityNewPlayerSupportConfig._Instance = new ActivityNewPlayerSupportConfig();
		return true;
	}

	// Token: 0x06008E11 RID: 36369 RVA: 0x001EA5B6 File Offset: 0x001E87B6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008E12 RID: 36370 RVA: 0x001EA5B8 File Offset: 0x001E87B8
	public static void ResetStaticDefaultValue()
	{
		ActivityNewPlayerSupportConfig._Instance = null;
	}

	// Token: 0x06008E13 RID: 36371 RVA: 0x001EA5C0 File Offset: 0x001E87C0
	static ActivityNewPlayerSupportConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityNewPlayerSupportConfig.CreateStaticDefaultValue), new Action(ActivityNewPlayerSupportConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003EF3 RID: 16115
	[Nullable(2)]
	private static ActivityNewPlayerSupportConfig _Instance;
}

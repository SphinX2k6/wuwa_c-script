using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000867 RID: 2151
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityNewPlayerSupportConfig : ConfigBase
{
	// Token: 0x0600619F RID: 24991 RVA: 0x001F3020 File Offset: 0x001F1220
	public NewPlayerSupportTask GetTaskConfig(int id)
	{
		return ConfigNewPlayerSupportTaskById.GetConfig(id, true).Value;
	}

	// Token: 0x060061A0 RID: 24992 RVA: 0x001F303C File Offset: 0x001F123C
	[NullableContext(2)]
	public IReadOnlyList<NewPlayerSupportTask> GetAllTaskConfigs()
	{
		return ConfigNewPlayerSupportTaskAll.GetConfigList(true);
	}

	// Token: 0x060061A1 RID: 24993 RVA: 0x001F3044 File Offset: 0x001F1244
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

	// Token: 0x060061A2 RID: 24994 RVA: 0x001F30E4 File Offset: 0x001F12E4
	public ConditionGroup? GetConditionGroup(int conditionId)
	{
		return ConfigConditionGroupById.GetConfig(conditionId, true);
	}

	// Token: 0x17000C0E RID: 3086
	// (get) Token: 0x060061A3 RID: 24995 RVA: 0x001F30ED File Offset: 0x001F12ED
	public static ActivityNewPlayerSupportConfig Instance
	{
		get
		{
			return ActivityNewPlayerSupportConfig._Instance;
		}
	}

	// Token: 0x060061A4 RID: 24996 RVA: 0x001F30F4 File Offset: 0x001F12F4
	public static ActivityNewPlayerSupportConfig GetOrCreateInstance()
	{
		if (ActivityNewPlayerSupportConfig._Instance == null)
		{
			ActivityNewPlayerSupportConfig.CreateInstance();
		}
		return ActivityNewPlayerSupportConfig._Instance;
	}

	// Token: 0x060061A5 RID: 24997 RVA: 0x001F3108 File Offset: 0x001F1308
	public static bool CreateInstance()
	{
		if (ActivityNewPlayerSupportConfig._Instance != null)
		{
			return true;
		}
		ActivityNewPlayerSupportConfig._Instance = new ActivityNewPlayerSupportConfig();
		return true;
	}

	// Token: 0x060061A6 RID: 24998 RVA: 0x001F311E File Offset: 0x001F131E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060061A7 RID: 24999 RVA: 0x001F3120 File Offset: 0x001F1320
	public static void ResetStaticDefaultValue()
	{
		ActivityNewPlayerSupportConfig._Instance = null;
	}

	// Token: 0x060061A8 RID: 25000 RVA: 0x001F3128 File Offset: 0x001F1328
	static ActivityNewPlayerSupportConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityNewPlayerSupportConfig.CreateStaticDefaultValue), new Action(ActivityNewPlayerSupportConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003F8B RID: 16267
	[Nullable(2)]
	private static ActivityNewPlayerSupportConfig _Instance;
}

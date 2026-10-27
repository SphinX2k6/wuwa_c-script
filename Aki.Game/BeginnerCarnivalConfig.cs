using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001196 RID: 4502
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class BeginnerCarnivalConfig : ConfigBase
{
	// Token: 0x06007724 RID: 30500 RVA: 0x0018DAC1 File Offset: 0x0018BCC1
	public NewbieCarnivalTask? GetNewbieCarnivalTask(int taskId)
	{
		return ConfigNewbieCarnivalTaskByTaskId.GetConfig(taskId, true);
	}

	// Token: 0x06007725 RID: 30501 RVA: 0x0018DACA File Offset: 0x0018BCCA
	public NewbieCarnivalTaskType? GetNewbieCarnivalTaskType(int typeId)
	{
		return ConfigNewbieCarnivalTaskTypeById.GetConfig(typeId, true);
	}

	// Token: 0x06007726 RID: 30502 RVA: 0x0018DAD3 File Offset: 0x0018BCD3
	public NewbieCarnivalParam? GetNewbieCarnivalParam(int activityId)
	{
		return ConfigNewbieCarnivalParamByActivityId.GetConfig(activityId, true);
	}

	// Token: 0x06007727 RID: 30503 RVA: 0x0018DADC File Offset: 0x0018BCDC
	public NewbieCarnivalRole? GetNewbieCarnivalRole(int roleId)
	{
		return ConfigNewbieCarnivalRoleByRoleId.GetConfig(roleId, true);
	}

	// Token: 0x06007728 RID: 30504 RVA: 0x0018DAE8 File Offset: 0x0018BCE8
	public NewbieCarnivalTask? GetNewbieCarnivalTaskByTaskType(int taskType)
	{
		IReadOnlyList<NewbieCarnivalTask> configList = ConfigNewbieCarnivalTaskByTaskType.GetConfigList(taskType, true);
		if (configList == null || configList.Count == 0)
		{
			return null;
		}
		return new NewbieCarnivalTask?(configList[0]);
	}

	// Token: 0x17000A3B RID: 2619
	// (get) Token: 0x06007729 RID: 30505 RVA: 0x0018DB1E File Offset: 0x0018BD1E
	public static BeginnerCarnivalConfig Instance
	{
		get
		{
			return BeginnerCarnivalConfig._Instance;
		}
	}

	// Token: 0x0600772A RID: 30506 RVA: 0x0018DB25 File Offset: 0x0018BD25
	public static BeginnerCarnivalConfig GetOrCreateInstance()
	{
		if (BeginnerCarnivalConfig._Instance == null)
		{
			BeginnerCarnivalConfig.CreateInstance();
		}
		return BeginnerCarnivalConfig._Instance;
	}

	// Token: 0x0600772B RID: 30507 RVA: 0x0018DB39 File Offset: 0x0018BD39
	public static bool CreateInstance()
	{
		if (BeginnerCarnivalConfig._Instance != null)
		{
			return true;
		}
		BeginnerCarnivalConfig._Instance = new BeginnerCarnivalConfig();
		return true;
	}

	// Token: 0x0600772C RID: 30508 RVA: 0x0018DB4F File Offset: 0x0018BD4F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600772D RID: 30509 RVA: 0x0018DB51 File Offset: 0x0018BD51
	public static void ResetStaticDefaultValue()
	{
		BeginnerCarnivalConfig._Instance = null;
	}

	// Token: 0x0600772E RID: 30510 RVA: 0x0018DB59 File Offset: 0x0018BD59
	static BeginnerCarnivalConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BeginnerCarnivalConfig.CreateStaticDefaultValue), new Action(BeginnerCarnivalConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040036B0 RID: 14000
	[Nullable(2)]
	private static BeginnerCarnivalConfig _Instance;
}

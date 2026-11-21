using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200064A RID: 1610
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class BeginnerCarnivalConfig : ConfigBase
{
	// Token: 0x06004ABB RID: 19131 RVA: 0x001966A9 File Offset: 0x001948A9
	public NewbieCarnivalTask? GetNewbieCarnivalTask(int taskId)
	{
		return ConfigNewbieCarnivalTaskByTaskId.GetConfig(taskId, true);
	}

	// Token: 0x06004ABC RID: 19132 RVA: 0x001966B2 File Offset: 0x001948B2
	public NewbieCarnivalTaskType? GetNewbieCarnivalTaskType(int typeId)
	{
		return ConfigNewbieCarnivalTaskTypeById.GetConfig(typeId, true);
	}

	// Token: 0x06004ABD RID: 19133 RVA: 0x001966BB File Offset: 0x001948BB
	public NewbieCarnivalParam? GetNewbieCarnivalParam(int activityId)
	{
		return ConfigNewbieCarnivalParamByActivityId.GetConfig(activityId, true);
	}

	// Token: 0x06004ABE RID: 19134 RVA: 0x001966C4 File Offset: 0x001948C4
	public NewbieCarnivalRole? GetNewbieCarnivalRole(int roleId)
	{
		return ConfigNewbieCarnivalRoleByRoleId.GetConfig(roleId, true);
	}

	// Token: 0x06004ABF RID: 19135 RVA: 0x001966D0 File Offset: 0x001948D0
	public NewbieCarnivalTask? GetNewbieCarnivalTaskByTaskType(int taskType)
	{
		IReadOnlyList<NewbieCarnivalTask> configList = ConfigNewbieCarnivalTaskByTaskType.GetConfigList(taskType, true);
		if (configList == null || configList.Count == 0)
		{
			return null;
		}
		return new NewbieCarnivalTask?(configList[0]);
	}

	// Token: 0x17000A5B RID: 2651
	// (get) Token: 0x06004AC0 RID: 19136 RVA: 0x00196706 File Offset: 0x00194906
	public static BeginnerCarnivalConfig Instance
	{
		get
		{
			return BeginnerCarnivalConfig._Instance;
		}
	}

	// Token: 0x06004AC1 RID: 19137 RVA: 0x0019670D File Offset: 0x0019490D
	public static BeginnerCarnivalConfig GetOrCreateInstance()
	{
		if (BeginnerCarnivalConfig._Instance == null)
		{
			BeginnerCarnivalConfig.CreateInstance();
		}
		return BeginnerCarnivalConfig._Instance;
	}

	// Token: 0x06004AC2 RID: 19138 RVA: 0x00196721 File Offset: 0x00194921
	public static bool CreateInstance()
	{
		if (BeginnerCarnivalConfig._Instance != null)
		{
			return true;
		}
		BeginnerCarnivalConfig._Instance = new BeginnerCarnivalConfig();
		return true;
	}

	// Token: 0x06004AC3 RID: 19139 RVA: 0x00196737 File Offset: 0x00194937
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004AC4 RID: 19140 RVA: 0x00196739 File Offset: 0x00194939
	public static void ResetStaticDefaultValue()
	{
		BeginnerCarnivalConfig._Instance = null;
	}

	// Token: 0x06004AC5 RID: 19141 RVA: 0x00196741 File Offset: 0x00194941
	static BeginnerCarnivalConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BeginnerCarnivalConfig.CreateStaticDefaultValue), new Action(BeginnerCarnivalConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003749 RID: 14153
	[Nullable(2)]
	private static BeginnerCarnivalConfig _Instance;
}

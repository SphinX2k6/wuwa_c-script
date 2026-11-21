using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200081D RID: 2077
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class TaskConfig : ConfigBase
{
	// Token: 0x06005E23 RID: 24099 RVA: 0x001E2918 File Offset: 0x001E0B18
	public IReadOnlyList<MainLine> GetAllMainLineTask()
	{
		return ConfigMainLineAll.GetConfigList(true);
	}

	// Token: 0x06005E24 RID: 24100 RVA: 0x001E2920 File Offset: 0x001E0B20
	public MainLine? GetMainLineTaskById(int taskId)
	{
		return ConfigMainLineById.GetConfig(taskId, true);
	}

	// Token: 0x06005E25 RID: 24101 RVA: 0x001E2929 File Offset: 0x001E0B29
	public IReadOnlyList<BranchLine> GetAllBranchLineTask()
	{
		return ConfigBranchLineAll.GetConfigList(true);
	}

	// Token: 0x06005E26 RID: 24102 RVA: 0x001E2931 File Offset: 0x001E0B31
	public BranchLine? GetBranchLineTaskById(int taskId)
	{
		return ConfigBranchLineById.GetConfig(taskId, true);
	}

	// Token: 0x06005E27 RID: 24103 RVA: 0x001E293C File Offset: 0x001E0B3C
	public BranchLine? GetBranchLineTaskByRealTaskId(int taskId)
	{
		IReadOnlyList<BranchLine> allBranchLineTask = this.GetAllBranchLineTask();
		for (int i = 0; i < allBranchLineTask.Count; i++)
		{
			BranchLine value = allBranchLineTask[i];
			if (value.TaskId == taskId)
			{
				return new BranchLine?(value);
			}
		}
		return null;
	}

	// Token: 0x17000BE1 RID: 3041
	// (get) Token: 0x06005E28 RID: 24104 RVA: 0x001E2983 File Offset: 0x001E0B83
	public static TaskConfig Instance
	{
		get
		{
			return TaskConfig._Instance;
		}
	}

	// Token: 0x06005E29 RID: 24105 RVA: 0x001E298A File Offset: 0x001E0B8A
	public static TaskConfig GetOrCreateInstance()
	{
		if (TaskConfig._Instance == null)
		{
			TaskConfig.CreateInstance();
		}
		return TaskConfig._Instance;
	}

	// Token: 0x06005E2A RID: 24106 RVA: 0x001E299E File Offset: 0x001E0B9E
	public static bool CreateInstance()
	{
		if (TaskConfig._Instance != null)
		{
			return true;
		}
		TaskConfig._Instance = new TaskConfig();
		return true;
	}

	// Token: 0x06005E2B RID: 24107 RVA: 0x001E29B4 File Offset: 0x001E0BB4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005E2C RID: 24108 RVA: 0x001E29B6 File Offset: 0x001E0BB6
	public static void ResetStaticDefaultValue()
	{
		TaskConfig._Instance = null;
	}

	// Token: 0x06005E2D RID: 24109 RVA: 0x001E29BE File Offset: 0x001E0BBE
	static TaskConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TaskConfig.CreateStaticDefaultValue), new Action(TaskConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003E50 RID: 15952
	[Nullable(2)]
	private static TaskConfig _Instance;
}

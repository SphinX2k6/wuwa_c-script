using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001369 RID: 4969
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class TaskConfig : ConfigBase
{
	// Token: 0x06008A88 RID: 35464 RVA: 0x001D9ABC File Offset: 0x001D7CBC
	public IReadOnlyList<MainLine> GetAllMainLineTask()
	{
		return ConfigMainLineAll.GetConfigList(true);
	}

	// Token: 0x06008A89 RID: 35465 RVA: 0x001D9AC4 File Offset: 0x001D7CC4
	public MainLine? GetMainLineTaskById(int taskId)
	{
		return ConfigMainLineById.GetConfig(taskId, true);
	}

	// Token: 0x06008A8A RID: 35466 RVA: 0x001D9ACD File Offset: 0x001D7CCD
	public IReadOnlyList<BranchLine> GetAllBranchLineTask()
	{
		return ConfigBranchLineAll.GetConfigList(true);
	}

	// Token: 0x06008A8B RID: 35467 RVA: 0x001D9AD5 File Offset: 0x001D7CD5
	public BranchLine? GetBranchLineTaskById(int taskId)
	{
		return ConfigBranchLineById.GetConfig(taskId, true);
	}

	// Token: 0x06008A8C RID: 35468 RVA: 0x001D9AE0 File Offset: 0x001D7CE0
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

	// Token: 0x17000BC1 RID: 3009
	// (get) Token: 0x06008A8D RID: 35469 RVA: 0x001D9B27 File Offset: 0x001D7D27
	public static TaskConfig Instance
	{
		get
		{
			return TaskConfig._Instance;
		}
	}

	// Token: 0x06008A8E RID: 35470 RVA: 0x001D9B2E File Offset: 0x001D7D2E
	public static TaskConfig GetOrCreateInstance()
	{
		if (TaskConfig._Instance == null)
		{
			TaskConfig.CreateInstance();
		}
		return TaskConfig._Instance;
	}

	// Token: 0x06008A8F RID: 35471 RVA: 0x001D9B42 File Offset: 0x001D7D42
	public static bool CreateInstance()
	{
		if (TaskConfig._Instance != null)
		{
			return true;
		}
		TaskConfig._Instance = new TaskConfig();
		return true;
	}

	// Token: 0x06008A90 RID: 35472 RVA: 0x001D9B58 File Offset: 0x001D7D58
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008A91 RID: 35473 RVA: 0x001D9B5A File Offset: 0x001D7D5A
	public static void ResetStaticDefaultValue()
	{
		TaskConfig._Instance = null;
	}

	// Token: 0x06008A92 RID: 35474 RVA: 0x001D9B62 File Offset: 0x001D7D62
	static TaskConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TaskConfig.CreateStaticDefaultValue), new Action(TaskConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003DB8 RID: 15800
	[Nullable(2)]
	private static TaskConfig _Instance;
}

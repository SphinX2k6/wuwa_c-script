using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020019E9 RID: 6633
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class DailyActivityConfig : ConfigBase
{
	// Token: 0x0600C207 RID: 49671 RVA: 0x002BCBC5 File Offset: 0x002BADC5
	[NullableContext(2)]
	public IReadOnlyList<Liveness> GetAllActivityGoalData()
	{
		return ConfigLivenessAll.GetConfigList(true);
	}

	// Token: 0x0600C208 RID: 49672 RVA: 0x002BCBD0 File Offset: 0x002BADD0
	public LivenessTask? GetActivityTaskConfigById(int taskId)
	{
		return new LivenessTask?(ConfigLivenessTaskByTaskId.GetConfig(taskId, true).Value);
	}

	// Token: 0x0600C209 RID: 49673 RVA: 0x002BCBF4 File Offset: 0x002BADF4
	public Dictionary<int, int> GetDropShowInfo(int id)
	{
		return ConfigDropPackageById.GetConfig(id, true).Value.DropPreview();
	}

	// Token: 0x17001034 RID: 4148
	// (get) Token: 0x0600C20A RID: 49674 RVA: 0x002BCC18 File Offset: 0x002BAE18
	public static DailyActivityConfig Instance
	{
		get
		{
			return DailyActivityConfig._Instance;
		}
	}

	// Token: 0x0600C20B RID: 49675 RVA: 0x002BCC1F File Offset: 0x002BAE1F
	public static DailyActivityConfig GetOrCreateInstance()
	{
		if (DailyActivityConfig._Instance == null)
		{
			DailyActivityConfig.CreateInstance();
		}
		return DailyActivityConfig._Instance;
	}

	// Token: 0x0600C20C RID: 49676 RVA: 0x002BCC33 File Offset: 0x002BAE33
	public static bool CreateInstance()
	{
		if (DailyActivityConfig._Instance != null)
		{
			return true;
		}
		DailyActivityConfig._Instance = new DailyActivityConfig();
		return true;
	}

	// Token: 0x0600C20D RID: 49677 RVA: 0x002BCC49 File Offset: 0x002BAE49
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C20E RID: 49678 RVA: 0x002BCC4B File Offset: 0x002BAE4B
	public static void ResetStaticDefaultValue()
	{
		DailyActivityConfig._Instance = null;
	}

	// Token: 0x0600C20F RID: 49679 RVA: 0x002BCC53 File Offset: 0x002BAE53
	static DailyActivityConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DailyActivityConfig.CreateStaticDefaultValue), new Action(DailyActivityConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005959 RID: 22873
	[Nullable(2)]
	private static DailyActivityConfig _Instance;
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000EA8 RID: 3752
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class DailyActivityConfig : ConfigBase
{
	// Token: 0x06009614 RID: 38420 RVA: 0x002C7B9D File Offset: 0x002C5D9D
	[NullableContext(2)]
	public IReadOnlyList<Liveness> GetAllActivityGoalData()
	{
		return ConfigLivenessAll.GetConfigList(true);
	}

	// Token: 0x06009615 RID: 38421 RVA: 0x002C7BA8 File Offset: 0x002C5DA8
	public LivenessTask? GetActivityTaskConfigById(int taskId)
	{
		return new LivenessTask?(ConfigLivenessTaskByTaskId.GetConfig(taskId, true).Value);
	}

	// Token: 0x06009616 RID: 38422 RVA: 0x002C7BCC File Offset: 0x002C5DCC
	public Dictionary<int, int> GetDropShowInfo(int id)
	{
		return ConfigDropPackageById.GetConfig(id, true).Value.DropPreview();
	}

	// Token: 0x17001059 RID: 4185
	// (get) Token: 0x06009617 RID: 38423 RVA: 0x002C7BF0 File Offset: 0x002C5DF0
	public static DailyActivityConfig Instance
	{
		get
		{
			return DailyActivityConfig._Instance;
		}
	}

	// Token: 0x06009618 RID: 38424 RVA: 0x002C7BF7 File Offset: 0x002C5DF7
	public static DailyActivityConfig GetOrCreateInstance()
	{
		if (DailyActivityConfig._Instance == null)
		{
			DailyActivityConfig.CreateInstance();
		}
		return DailyActivityConfig._Instance;
	}

	// Token: 0x06009619 RID: 38425 RVA: 0x002C7C0B File Offset: 0x002C5E0B
	public static bool CreateInstance()
	{
		if (DailyActivityConfig._Instance != null)
		{
			return true;
		}
		DailyActivityConfig._Instance = new DailyActivityConfig();
		return true;
	}

	// Token: 0x0600961A RID: 38426 RVA: 0x002C7C21 File Offset: 0x002C5E21
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600961B RID: 38427 RVA: 0x002C7C23 File Offset: 0x002C5E23
	public static void ResetStaticDefaultValue()
	{
		DailyActivityConfig._Instance = null;
	}

	// Token: 0x0600961C RID: 38428 RVA: 0x002C7C2B File Offset: 0x002C5E2B
	static DailyActivityConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DailyActivityConfig.CreateStaticDefaultValue), new Action(DailyActivityConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005A28 RID: 23080
	[Nullable(2)]
	private static DailyActivityConfig _Instance;
}

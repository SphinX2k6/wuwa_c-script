using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001108 RID: 4360
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class AvignonConfig : ConfigBase
{
	// Token: 0x060071D1 RID: 29137 RVA: 0x00174B6C File Offset: 0x00172D6C
	public IReadOnlyList<AvignonStage> GetStageConfigAll()
	{
		return ConfigAvignonStageAll.GetConfigList(true) ?? new AvignonStage[0];
	}

	// Token: 0x060071D2 RID: 29138 RVA: 0x00174B7E File Offset: 0x00172D7E
	public AvignonStage? GetStageConfigById(int stageId)
	{
		return ConfigAvignonStageById.GetConfig(stageId, true);
	}

	// Token: 0x060071D3 RID: 29139 RVA: 0x00174B87 File Offset: 0x00172D87
	public IReadOnlyList<AvignonTask> GetAvignonTaskConfigByStageId(int stageId)
	{
		return ConfigAvignonTaskByStageId.GetConfigList(stageId, true);
	}

	// Token: 0x060071D4 RID: 29140 RVA: 0x00174B90 File Offset: 0x00172D90
	public AvignonTask? GetAvignonTaskConfigByTaskId(int taskId)
	{
		return ConfigAvignonTaskByTaskId.GetConfig(taskId, true);
	}

	// Token: 0x1700099B RID: 2459
	// (get) Token: 0x060071D5 RID: 29141 RVA: 0x00174B99 File Offset: 0x00172D99
	public static AvignonConfig Instance
	{
		get
		{
			return AvignonConfig._Instance;
		}
	}

	// Token: 0x060071D6 RID: 29142 RVA: 0x00174BA0 File Offset: 0x00172DA0
	public static AvignonConfig GetOrCreateInstance()
	{
		if (AvignonConfig._Instance == null)
		{
			AvignonConfig.CreateInstance();
		}
		return AvignonConfig._Instance;
	}

	// Token: 0x060071D7 RID: 29143 RVA: 0x00174BB4 File Offset: 0x00172DB4
	public static bool CreateInstance()
	{
		if (AvignonConfig._Instance != null)
		{
			return true;
		}
		AvignonConfig._Instance = new AvignonConfig();
		return true;
	}

	// Token: 0x060071D8 RID: 29144 RVA: 0x00174BCA File Offset: 0x00172DCA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060071D9 RID: 29145 RVA: 0x00174BCC File Offset: 0x00172DCC
	public static void ResetStaticDefaultValue()
	{
		AvignonConfig._Instance = null;
	}

	// Token: 0x060071DA RID: 29146 RVA: 0x00174BD4 File Offset: 0x00172DD4
	static AvignonConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AvignonConfig.CreateStaticDefaultValue), new Action(AvignonConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040034D5 RID: 13525
	[Nullable(2)]
	private static AvignonConfig _Instance;
}

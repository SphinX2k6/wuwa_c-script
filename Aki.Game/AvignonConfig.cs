using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020005BC RID: 1468
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class AvignonConfig : ConfigBase
{
	// Token: 0x06004567 RID: 17767 RVA: 0x0017D528 File Offset: 0x0017B728
	public IReadOnlyList<AvignonStage> GetStageConfigAll()
	{
		return ConfigAvignonStageAll.GetConfigList(true) ?? new AvignonStage[0];
	}

	// Token: 0x06004568 RID: 17768 RVA: 0x0017D53A File Offset: 0x0017B73A
	public AvignonStage? GetStageConfigById(int stageId)
	{
		return ConfigAvignonStageById.GetConfig(stageId, true);
	}

	// Token: 0x06004569 RID: 17769 RVA: 0x0017D543 File Offset: 0x0017B743
	public IReadOnlyList<AvignonTask> GetAvignonTaskConfigByStageId(int stageId)
	{
		return ConfigAvignonTaskByStageId.GetConfigList(stageId, true);
	}

	// Token: 0x0600456A RID: 17770 RVA: 0x0017D54C File Offset: 0x0017B74C
	public AvignonTask? GetAvignonTaskConfigByTaskId(int taskId)
	{
		return ConfigAvignonTaskByTaskId.GetConfig(taskId, true);
	}

	// Token: 0x170009BB RID: 2491
	// (get) Token: 0x0600456B RID: 17771 RVA: 0x0017D555 File Offset: 0x0017B755
	public static AvignonConfig Instance
	{
		get
		{
			return AvignonConfig._Instance;
		}
	}

	// Token: 0x0600456C RID: 17772 RVA: 0x0017D55C File Offset: 0x0017B75C
	public static AvignonConfig GetOrCreateInstance()
	{
		if (AvignonConfig._Instance == null)
		{
			AvignonConfig.CreateInstance();
		}
		return AvignonConfig._Instance;
	}

	// Token: 0x0600456D RID: 17773 RVA: 0x0017D570 File Offset: 0x0017B770
	public static bool CreateInstance()
	{
		if (AvignonConfig._Instance != null)
		{
			return true;
		}
		AvignonConfig._Instance = new AvignonConfig();
		return true;
	}

	// Token: 0x0600456E RID: 17774 RVA: 0x0017D586 File Offset: 0x0017B786
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600456F RID: 17775 RVA: 0x0017D588 File Offset: 0x0017B788
	public static void ResetStaticDefaultValue()
	{
		AvignonConfig._Instance = null;
	}

	// Token: 0x06004570 RID: 17776 RVA: 0x0017D590 File Offset: 0x0017B790
	static AvignonConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AvignonConfig.CreateStaticDefaultValue), new Action(AvignonConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400356E RID: 13678
	[Nullable(2)]
	private static AvignonConfig _Instance;
}

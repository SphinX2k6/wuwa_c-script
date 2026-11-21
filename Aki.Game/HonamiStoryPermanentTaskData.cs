using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02001333 RID: 4915
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryPermanentTaskData
{
	// Token: 0x0600C190 RID: 49552 RVA: 0x0039485B File Offset: 0x00392A5B
	public HonamiStoryPermanentTaskData(int configId)
	{
		this.ConfigId = configId;
	}

	// Token: 0x0600C191 RID: 49553 RVA: 0x00394878 File Offset: 0x00392A78
	private HonamiStoryResidentTask? GetConfig()
	{
		return HonamiStoryConfig.Instance.GetHonamiStoryPermanentTaskConfig(this.ConfigId);
	}

	// Token: 0x0600C192 RID: 49554 RVA: 0x0039488A File Offset: 0x00392A8A
	public void UpdateData(ConditionTask data)
	{
		this.StatusInternal = TaskStateResolver.TaskState[(ActivityTaskState)data.Status];
		this.Current = data.Current;
		this.Target = data.Target;
	}

	// Token: 0x0600C193 RID: 49555 RVA: 0x003948BA File Offset: 0x00392ABA
	public void UpdateState(EActivityTaskState state)
	{
		this.StatusInternal = state;
	}

	// Token: 0x170012E2 RID: 4834
	// (get) Token: 0x0600C194 RID: 49556 RVA: 0x003948C4 File Offset: 0x00392AC4
	public int Id
	{
		get
		{
			return this.GetConfig().Value.Id;
		}
	}

	// Token: 0x170012E3 RID: 4835
	// (get) Token: 0x0600C195 RID: 49557 RVA: 0x003948E8 File Offset: 0x00392AE8
	public int DropId
	{
		get
		{
			return this.GetConfig().Value.DropId;
		}
	}

	// Token: 0x170012E4 RID: 4836
	// (get) Token: 0x0600C196 RID: 49558 RVA: 0x0039490C File Offset: 0x00392B0C
	public int JumpId
	{
		get
		{
			return this.GetConfig().Value.JumpId;
		}
	}

	// Token: 0x170012E5 RID: 4837
	// (get) Token: 0x0600C197 RID: 49559 RVA: 0x0039492F File Offset: 0x00392B2F
	public EActivityTaskState Status
	{
		get
		{
			return this.StatusInternal;
		}
	}

	// Token: 0x170012E6 RID: 4838
	// (get) Token: 0x0600C198 RID: 49560 RVA: 0x00394938 File Offset: 0x00392B38
	public string TaskName
	{
		get
		{
			return this.GetConfig().Value.RewardName;
		}
	}

	// Token: 0x04006F18 RID: 28440
	public int ConfigId;

	// Token: 0x04006F19 RID: 28441
	private EActivityTaskState StatusInternal = EActivityTaskState.Active;

	// Token: 0x04006F1A RID: 28442
	public int Current;

	// Token: 0x04006F1B RID: 28443
	public int Target = 1;
}

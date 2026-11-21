using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02001331 RID: 4913
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryLimitTaskData
{
	// Token: 0x0600C17D RID: 49533 RVA: 0x0039466A File Offset: 0x0039286A
	public HonamiStoryLimitTaskData(int configId)
	{
		this.ConfigId = configId;
	}

	// Token: 0x0600C17E RID: 49534 RVA: 0x00394687 File Offset: 0x00392887
	private HonamiStoryLimitTask? GetConfig()
	{
		return HonamiStoryConfig.Instance.GetHonamiStoryLimitTaskConfig(this.ConfigId);
	}

	// Token: 0x0600C17F RID: 49535 RVA: 0x00394699 File Offset: 0x00392899
	public void UpdateData(ConditionTask data)
	{
		this.StatusInternal = TaskStateResolver.TaskState[(ActivityTaskState)data.Status];
		this.Current = data.Current;
		this.Target = data.Target;
	}

	// Token: 0x0600C180 RID: 49536 RVA: 0x003946C9 File Offset: 0x003928C9
	public void UpdateState(EActivityTaskState state)
	{
		this.StatusInternal = state;
	}

	// Token: 0x170012D5 RID: 4821
	// (get) Token: 0x0600C181 RID: 49537 RVA: 0x003946D4 File Offset: 0x003928D4
	public int Id
	{
		get
		{
			return this.GetConfig().Value.Id;
		}
	}

	// Token: 0x170012D6 RID: 4822
	// (get) Token: 0x0600C182 RID: 49538 RVA: 0x003946F8 File Offset: 0x003928F8
	public int DropId
	{
		get
		{
			return this.GetConfig().Value.DropId;
		}
	}

	// Token: 0x170012D7 RID: 4823
	// (get) Token: 0x0600C183 RID: 49539 RVA: 0x0039471C File Offset: 0x0039291C
	public int JumpId
	{
		get
		{
			return this.GetConfig().Value.JumpId;
		}
	}

	// Token: 0x170012D8 RID: 4824
	// (get) Token: 0x0600C184 RID: 49540 RVA: 0x0039473F File Offset: 0x0039293F
	public EActivityTaskState Status
	{
		get
		{
			return this.StatusInternal;
		}
	}

	// Token: 0x170012D9 RID: 4825
	// (get) Token: 0x0600C185 RID: 49541 RVA: 0x00394748 File Offset: 0x00392948
	public string TaskName
	{
		get
		{
			return this.GetConfig().Value.RewardName;
		}
	}

	// Token: 0x04006F12 RID: 28434
	public int ConfigId;

	// Token: 0x04006F13 RID: 28435
	private EActivityTaskState StatusInternal = EActivityTaskState.Active;

	// Token: 0x04006F14 RID: 28436
	public int Current;

	// Token: 0x04006F15 RID: 28437
	public int Target = 1;
}

using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02001E71 RID: 7793
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryPermanentTaskData
{
	// Token: 0x0600ED71 RID: 60785 RVA: 0x00388C4F File Offset: 0x00386E4F
	public HonamiStoryPermanentTaskData(int configId)
	{
		this.ConfigId = configId;
	}

	// Token: 0x0600ED72 RID: 60786 RVA: 0x00388C6C File Offset: 0x00386E6C
	private HonamiStoryResidentTask? GetConfig()
	{
		return HonamiStoryConfig.Instance.GetHonamiStoryPermanentTaskConfig(this.ConfigId);
	}

	// Token: 0x0600ED73 RID: 60787 RVA: 0x00388C7E File Offset: 0x00386E7E
	public void UpdateData(ConditionTask data)
	{
		this.StatusInternal = TaskStateResolver.TaskState[(ActivityTaskState)data.Status];
		this.Current = data.Current;
		this.Target = data.Target;
	}

	// Token: 0x0600ED74 RID: 60788 RVA: 0x00388CAE File Offset: 0x00386EAE
	public void UpdateState(EActivityTaskState state)
	{
		this.StatusInternal = state;
	}

	// Token: 0x170012B8 RID: 4792
	// (get) Token: 0x0600ED75 RID: 60789 RVA: 0x00388CB8 File Offset: 0x00386EB8
	public int Id
	{
		get
		{
			return this.GetConfig().Value.Id;
		}
	}

	// Token: 0x170012B9 RID: 4793
	// (get) Token: 0x0600ED76 RID: 60790 RVA: 0x00388CDC File Offset: 0x00386EDC
	public int DropId
	{
		get
		{
			return this.GetConfig().Value.DropId;
		}
	}

	// Token: 0x170012BA RID: 4794
	// (get) Token: 0x0600ED77 RID: 60791 RVA: 0x00388D00 File Offset: 0x00386F00
	public int JumpId
	{
		get
		{
			return this.GetConfig().Value.JumpId;
		}
	}

	// Token: 0x170012BB RID: 4795
	// (get) Token: 0x0600ED78 RID: 60792 RVA: 0x00388D23 File Offset: 0x00386F23
	public EActivityTaskState Status
	{
		get
		{
			return this.StatusInternal;
		}
	}

	// Token: 0x170012BC RID: 4796
	// (get) Token: 0x0600ED79 RID: 60793 RVA: 0x00388D2C File Offset: 0x00386F2C
	public string TaskName
	{
		get
		{
			return this.GetConfig().Value.RewardName;
		}
	}

	// Token: 0x04006E37 RID: 28215
	public int ConfigId;

	// Token: 0x04006E38 RID: 28216
	private EActivityTaskState StatusInternal = EActivityTaskState.Active;

	// Token: 0x04006E39 RID: 28217
	public int Current;

	// Token: 0x04006E3A RID: 28218
	public int Target = 1;
}

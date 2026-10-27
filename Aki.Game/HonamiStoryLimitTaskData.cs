using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02001E6F RID: 7791
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryLimitTaskData
{
	// Token: 0x0600ED5E RID: 60766 RVA: 0x00388A5E File Offset: 0x00386C5E
	public HonamiStoryLimitTaskData(int configId)
	{
		this.ConfigId = configId;
	}

	// Token: 0x0600ED5F RID: 60767 RVA: 0x00388A7B File Offset: 0x00386C7B
	private HonamiStoryLimitTask? GetConfig()
	{
		return HonamiStoryConfig.Instance.GetHonamiStoryLimitTaskConfig(this.ConfigId);
	}

	// Token: 0x0600ED60 RID: 60768 RVA: 0x00388A8D File Offset: 0x00386C8D
	public void UpdateData(ConditionTask data)
	{
		this.StatusInternal = TaskStateResolver.TaskState[(ActivityTaskState)data.Status];
		this.Current = data.Current;
		this.Target = data.Target;
	}

	// Token: 0x0600ED61 RID: 60769 RVA: 0x00388ABD File Offset: 0x00386CBD
	public void UpdateState(EActivityTaskState state)
	{
		this.StatusInternal = state;
	}

	// Token: 0x170012AB RID: 4779
	// (get) Token: 0x0600ED62 RID: 60770 RVA: 0x00388AC8 File Offset: 0x00386CC8
	public int Id
	{
		get
		{
			return this.GetConfig().Value.Id;
		}
	}

	// Token: 0x170012AC RID: 4780
	// (get) Token: 0x0600ED63 RID: 60771 RVA: 0x00388AEC File Offset: 0x00386CEC
	public int DropId
	{
		get
		{
			return this.GetConfig().Value.DropId;
		}
	}

	// Token: 0x170012AD RID: 4781
	// (get) Token: 0x0600ED64 RID: 60772 RVA: 0x00388B10 File Offset: 0x00386D10
	public int JumpId
	{
		get
		{
			return this.GetConfig().Value.JumpId;
		}
	}

	// Token: 0x170012AE RID: 4782
	// (get) Token: 0x0600ED65 RID: 60773 RVA: 0x00388B33 File Offset: 0x00386D33
	public EActivityTaskState Status
	{
		get
		{
			return this.StatusInternal;
		}
	}

	// Token: 0x170012AF RID: 4783
	// (get) Token: 0x0600ED66 RID: 60774 RVA: 0x00388B3C File Offset: 0x00386D3C
	public string TaskName
	{
		get
		{
			return this.GetConfig().Value.RewardName;
		}
	}

	// Token: 0x04006E31 RID: 28209
	public int ConfigId;

	// Token: 0x04006E32 RID: 28210
	private EActivityTaskState StatusInternal = EActivityTaskState.Active;

	// Token: 0x04006E33 RID: 28211
	public int Current;

	// Token: 0x04006E34 RID: 28212
	public int Target = 1;
}

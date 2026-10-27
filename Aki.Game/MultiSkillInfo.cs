using System;
using System.Runtime.CompilerServices;

// Token: 0x0200314A RID: 12618
[NullableContext(2)]
[Nullable(0)]
public class MultiSkillInfo
{
	// Token: 0x17002594 RID: 9620
	// (get) Token: 0x0601B26A RID: 111210 RVA: 0x00762C96 File Offset: 0x00760E96
	public double RemainingStartTime
	{
		get
		{
			if (this.MultiSkillStartStamp != 0.0)
			{
				return (this.MultiSkillStartStamp - Time.Instance.FlowTime) * TimeUtil.Instance.Millisecond;
			}
			return 0.0;
		}
	}

	// Token: 0x17002595 RID: 9621
	// (get) Token: 0x0601B26B RID: 111211 RVA: 0x00762CCF File Offset: 0x00760ECF
	public double RemainingStopTime
	{
		get
		{
			if (this.MultiSkillStopStamp != 0.0)
			{
				return (this.MultiSkillStopStamp - Time.Instance.FlowTime) * TimeUtil.Instance.Millisecond;
			}
			return 0.0;
		}
	}

	// Token: 0x0400D331 RID: 54065
	public int FirstSkillId;

	// Token: 0x0400D332 RID: 54066
	public int CurSkillId;

	// Token: 0x0400D333 RID: 54067
	public int? NextSkillId;

	// Token: 0x0400D334 RID: 54068
	public float StartTime;

	// Token: 0x0400D335 RID: 54069
	public double MultiSkillStartStamp;

	// Token: 0x0400D336 RID: 54070
	public float StopTime;

	// Token: 0x0400D337 RID: 54071
	public double MultiSkillStopStamp;

	// Token: 0x0400D338 RID: 54072
	public bool IsReset;

	// Token: 0x0400D339 RID: 54073
	public bool IsResetOnChangeRole;

	// Token: 0x0400D33A RID: 54074
	public TimerHandle MultiSkillStartTimer;

	// Token: 0x0400D33B RID: 54075
	public TimerHandle MultiSkillStopTimer;
}

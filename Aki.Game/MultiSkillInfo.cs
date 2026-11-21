using System;
using System.Runtime.CompilerServices;

// Token: 0x020026B7 RID: 9911
[NullableContext(2)]
[Nullable(0)]
public class MultiSkillInfo
{
	// Token: 0x17002783 RID: 10115
	// (get) Token: 0x06018D6D RID: 101741 RVA: 0x0078A690 File Offset: 0x00788890
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

	// Token: 0x17002784 RID: 10116
	// (get) Token: 0x06018D6E RID: 101742 RVA: 0x0078A6C9 File Offset: 0x007888C9
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

	// Token: 0x0400D794 RID: 55188
	public int FirstSkillId;

	// Token: 0x0400D795 RID: 55189
	public int CurSkillId;

	// Token: 0x0400D796 RID: 55190
	public int? NextSkillId;

	// Token: 0x0400D797 RID: 55191
	public float StartTime;

	// Token: 0x0400D798 RID: 55192
	public double MultiSkillStartStamp;

	// Token: 0x0400D799 RID: 55193
	public float StopTime;

	// Token: 0x0400D79A RID: 55194
	public double MultiSkillStopStamp;

	// Token: 0x0400D79B RID: 55195
	public bool IsReset;

	// Token: 0x0400D79C RID: 55196
	public bool IsResetOnChangeRole;

	// Token: 0x0400D79D RID: 55197
	public TimerHandle MultiSkillStartTimer;

	// Token: 0x0400D79E RID: 55198
	public TimerHandle MultiSkillStopTimer;
}

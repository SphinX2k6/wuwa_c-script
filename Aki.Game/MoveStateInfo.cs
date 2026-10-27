using System;
using System.Runtime.CompilerServices;

// Token: 0x020032E0 RID: 13024
public class MoveStateInfo
{
	// Token: 0x0601C54E RID: 116046 RVA: 0x007EB534 File Offset: 0x007E9734
	[NullableContext(1)]
	public MoveStateInfo DeepCopy()
	{
		return new MoveStateInfo
		{
			TimeRatio = this.TimeRatio,
			PathRatio = this.PathRatio,
			PathDeltaSign = this.PathDeltaSign,
			IsFinish = this.IsFinish,
			ElapsedTime = this.ElapsedTime
		};
	}

	// Token: 0x0400E074 RID: 57460
	public double ElapsedTime;

	// Token: 0x0400E075 RID: 57461
	public double TimeRatio;

	// Token: 0x0400E076 RID: 57462
	public double PathRatio;

	// Token: 0x0400E077 RID: 57463
	public int PathDeltaSign = 1;

	// Token: 0x0400E078 RID: 57464
	public bool IsFinish;
}

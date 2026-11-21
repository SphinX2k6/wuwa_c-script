using System;
using System.Runtime.CompilerServices;

// Token: 0x02002852 RID: 10322
public class MoveStateInfo
{
	// Token: 0x0601A1F4 RID: 106996 RVA: 0x00811CBC File Offset: 0x0080FEBC
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

	// Token: 0x0400E51F RID: 58655
	public double ElapsedTime;

	// Token: 0x0400E520 RID: 58656
	public double TimeRatio;

	// Token: 0x0400E521 RID: 58657
	public double PathRatio;

	// Token: 0x0400E522 RID: 58658
	public int PathDeltaSign = 1;

	// Token: 0x0400E523 RID: 58659
	public bool IsFinish;
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200525C RID: 21084
	public enum TVisibleCondition : byte
	{
		// Token: 0x0400E2DD RID: 58077
		NONE,
		// Token: 0x0400E2DE RID: 58078
		IClock,
		// Token: 0x0400E2DF RID: 58079
		ICompareVar,
		// Token: 0x0400E2E0 RID: 58080
		IPreChildQuest,
		// Token: 0x0400E2E1 RID: 58081
		IPreQuest,
		// Token: 0x0400E2E2 RID: 58082
		ISeasonAndWeather,
		// Token: 0x0400E2E3 RID: 58083
		ITargetEntityInvisible,
		// Token: 0x0400E2E4 RID: 58084
		ITimePeriod,
		// Token: 0x0400E2E5 RID: 58085
		IWeather
	}
}

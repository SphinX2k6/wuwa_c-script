using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D60 RID: 19808
	public enum TVisibleCondition : byte
	{
		// Token: 0x0400D7AE RID: 55214
		NONE,
		// Token: 0x0400D7AF RID: 55215
		IClock,
		// Token: 0x0400D7B0 RID: 55216
		ICompareVar,
		// Token: 0x0400D7B1 RID: 55217
		IPreChildQuest,
		// Token: 0x0400D7B2 RID: 55218
		IPreQuest,
		// Token: 0x0400D7B3 RID: 55219
		ITargetEntityInvisible,
		// Token: 0x0400D7B4 RID: 55220
		ITimePeriod,
		// Token: 0x0400D7B5 RID: 55221
		IWeather
	}
}

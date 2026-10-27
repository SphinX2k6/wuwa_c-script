using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D15 RID: 19733
	public enum IVisibleCondition_Union : byte
	{
		// Token: 0x0400D6F7 RID: 55031
		NONE,
		// Token: 0x0400D6F8 RID: 55032
		IVisibleCondition,
		// Token: 0x0400D6F9 RID: 55033
		IWeather,
		// Token: 0x0400D6FA RID: 55034
		ITimePeriod,
		// Token: 0x0400D6FB RID: 55035
		IPreQuest,
		// Token: 0x0400D6FC RID: 55036
		IPreChildQuest,
		// Token: 0x0400D6FD RID: 55037
		IClock,
		// Token: 0x0400D6FE RID: 55038
		ICompareVar,
		// Token: 0x0400D6FF RID: 55039
		ITargetEntityInvisible
	}
}

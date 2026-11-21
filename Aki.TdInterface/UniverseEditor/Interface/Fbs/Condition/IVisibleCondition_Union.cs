using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005211 RID: 21009
	public enum IVisibleCondition_Union : byte
	{
		// Token: 0x0400E224 RID: 57892
		NONE,
		// Token: 0x0400E225 RID: 57893
		IVisibleCondition,
		// Token: 0x0400E226 RID: 57894
		IWeather,
		// Token: 0x0400E227 RID: 57895
		ITimePeriod,
		// Token: 0x0400E228 RID: 57896
		IPreQuest,
		// Token: 0x0400E229 RID: 57897
		IPreChildQuest,
		// Token: 0x0400E22A RID: 57898
		IClock,
		// Token: 0x0400E22B RID: 57899
		ICompareVar,
		// Token: 0x0400E22C RID: 57900
		ITargetEntityInvisible,
		// Token: 0x0400E22D RID: 57901
		ISeasonAndWeather
	}
}

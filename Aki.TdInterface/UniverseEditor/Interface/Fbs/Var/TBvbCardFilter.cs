using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B4D RID: 15181
	public enum TBvbCardFilter : byte
	{
		// Token: 0x0400B036 RID: 45110
		NONE,
		// Token: 0x0400B037 RID: 45111
		IBvbCardFilterCheckHasBattleFactor,
		// Token: 0x0400B038 RID: 45112
		IBvbCardFilterCheckHasOptimalFactor,
		// Token: 0x0400B039 RID: 45113
		IBvbCardFilterCheckIsCapableToEvolve,
		// Token: 0x0400B03A RID: 45114
		IBvbCardFilterCheckIsCore,
		// Token: 0x0400B03B RID: 45115
		IBvbCardFilterCompareActiveSkillTag,
		// Token: 0x0400B03C RID: 45116
		IBvbCardFilterCompareCardType,
		// Token: 0x0400B03D RID: 45117
		IBvbCardFilterCompareCost
	}
}

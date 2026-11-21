using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F4F RID: 16207
	public enum TBvbCardFilter : byte
	{
		// Token: 0x0400B9A3 RID: 47523
		NONE,
		// Token: 0x0400B9A4 RID: 47524
		IBvbCardFilterCheckHasBattleFactor,
		// Token: 0x0400B9A5 RID: 47525
		IBvbCardFilterCheckHasOptimalFactor,
		// Token: 0x0400B9A6 RID: 47526
		IBvbCardFilterCheckIsCapableToEvolve,
		// Token: 0x0400B9A7 RID: 47527
		IBvbCardFilterCheckIsCore,
		// Token: 0x0400B9A8 RID: 47528
		IBvbCardFilterCompareActiveSkillTag,
		// Token: 0x0400B9A9 RID: 47529
		IBvbCardFilterCompareCardType,
		// Token: 0x0400B9AA RID: 47530
		IBvbCardFilterCompareCost
	}
}

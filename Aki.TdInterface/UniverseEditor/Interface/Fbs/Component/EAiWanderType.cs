using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005266 RID: 21094
	public enum EAiWanderType : ushort
	{
		// Token: 0x0400E2FE RID: 58110
		None,
		// Token: 0x0400E2FF RID: 58111
		SmallRange = 300,
		// Token: 0x0400E300 RID: 58112
		SmallRangeLargeBody,
		// Token: 0x0400E301 RID: 58113
		MiddleRange = 600,
		// Token: 0x0400E302 RID: 58114
		MiddleRangeLargeBody,
		// Token: 0x0400E303 RID: 58115
		BigRange = 1000,
		// Token: 0x0400E304 RID: 58116
		BigRangeLargeBody
	}
}

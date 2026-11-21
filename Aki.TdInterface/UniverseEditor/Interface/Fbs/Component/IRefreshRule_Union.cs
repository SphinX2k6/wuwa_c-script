using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E3C RID: 24124
	public enum IRefreshRule_Union : byte
	{
		// Token: 0x0400FA31 RID: 64049
		NONE,
		// Token: 0x0400FA32 RID: 64050
		IRefreshRule,
		// Token: 0x0400FA33 RID: 64051
		ICdRefreshRule,
		// Token: 0x0400FA34 RID: 64052
		IFixedDateTimeRefreshRule,
		// Token: 0x0400FA35 RID: 64053
		IRandomNpcRule
	}
}

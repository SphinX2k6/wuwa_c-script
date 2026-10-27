using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005835 RID: 22581
	public enum IRefreshRule_Union : byte
	{
		// Token: 0x0400ED46 RID: 60742
		NONE,
		// Token: 0x0400ED47 RID: 60743
		IRefreshRule,
		// Token: 0x0400ED48 RID: 60744
		ICdRefreshRule,
		// Token: 0x0400ED49 RID: 60745
		IFixedDateTimeRefreshRule,
		// Token: 0x0400ED4A RID: 60746
		IRandomNpcRule
	}
}

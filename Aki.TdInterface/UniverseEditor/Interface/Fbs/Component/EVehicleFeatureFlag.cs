using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E35 RID: 20021
	public enum EVehicleFeatureFlag : byte
	{
		// Token: 0x0400DBA0 RID: 56224
		None,
		// Token: 0x0400DBA1 RID: 56225
		Movement,
		// Token: 0x0400DBA2 RID: 56226
		Battle,
		// Token: 0x0400DBA3 RID: 56227
		Audio = 4,
		// Token: 0x0400DBA4 RID: 56228
		MovablePlatform = 8,
		// Token: 0x0400DBA5 RID: 56229
		Sharing = 16,
		// Token: 0x0400DBA6 RID: 56230
		Performance = 32
	}
}

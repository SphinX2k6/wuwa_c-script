using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A73 RID: 19059
	public enum TLevelPlayRefresh : byte
	{
		// Token: 0x0400D141 RID: 53569
		NONE,
		// Token: 0x0400D142 RID: 53570
		IChildDestroyOrAwardedRefresh,
		// Token: 0x0400D143 RID: 53571
		IChildDestroyRefresh,
		// Token: 0x0400D144 RID: 53572
		ICompletedRefresh,
		// Token: 0x0400D145 RID: 53573
		ICustomOnlineRefresh,
		// Token: 0x0400D146 RID: 53574
		ICustomRefresh,
		// Token: 0x0400D147 RID: 53575
		IFixedDateTimeRefresh,
		// Token: 0x0400D148 RID: 53576
		INoneRefresh
	}
}

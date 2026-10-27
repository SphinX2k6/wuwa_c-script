using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200460B RID: 17931
	public enum TLevelPlayRefresh : byte
	{
		// Token: 0x0400C712 RID: 50962
		NONE,
		// Token: 0x0400C713 RID: 50963
		IChildDestroyOrAwardedRefresh,
		// Token: 0x0400C714 RID: 50964
		IChildDestroyRefresh,
		// Token: 0x0400C715 RID: 50965
		ICompletedRefresh,
		// Token: 0x0400C716 RID: 50966
		ICustomOnlineRefresh,
		// Token: 0x0400C717 RID: 50967
		ICustomRefresh,
		// Token: 0x0400C718 RID: 50968
		IFixedDateTimeRefresh,
		// Token: 0x0400C719 RID: 50969
		INoneRefresh
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004890 RID: 18576
	public enum ELevelPlayRefreshType : byte
	{
		// Token: 0x0400CDE9 RID: 52713
		None,
		// Token: 0x0400CDEA RID: 52714
		Completed,
		// Token: 0x0400CDEB RID: 52715
		ChildDestroy,
		// Token: 0x0400CDEC RID: 52716
		ChildDestroyOrAwarded,
		// Token: 0x0400CDED RID: 52717
		FixedDateTime,
		// Token: 0x0400CDEE RID: 52718
		CustomRefresh,
		// Token: 0x0400CDEF RID: 52719
		CustomOnlineRefresh
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004428 RID: 17448
	public enum ELevelPlayRefreshType : byte
	{
		// Token: 0x0400C3BC RID: 50108
		None,
		// Token: 0x0400C3BD RID: 50109
		Completed,
		// Token: 0x0400C3BE RID: 50110
		ChildDestroy,
		// Token: 0x0400C3BF RID: 50111
		ChildDestroyOrAwarded,
		// Token: 0x0400C3C0 RID: 50112
		FixedDateTime,
		// Token: 0x0400C3C1 RID: 50113
		CustomRefresh,
		// Token: 0x0400C3C2 RID: 50114
		CustomOnlineRefresh
	}
}

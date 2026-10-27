using System;

namespace NpcSitOnChair
{
	// Token: 0x020044B7 RID: 17591
	public enum ETaskPhase
	{
		// Token: 0x04018394 RID: 99220
		None,
		// Token: 0x04018395 RID: 99221
		Execute,
		// Token: 0x04018396 RID: 99222
		MoveNearby,
		// Token: 0x04018397 RID: 99223
		MoveClose,
		// Token: 0x04018398 RID: 99224
		TurnTo,
		// Token: 0x04018399 RID: 99225
		SitOnChair,
		// Token: 0x0401839A RID: 99226
		MoveAway,
		// Token: 0x0401839B RID: 99227
		Finish
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004512 RID: 17682
	public enum ILevelPlayRefresh_Union : byte
	{
		// Token: 0x0400C57D RID: 50557
		NONE,
		// Token: 0x0400C57E RID: 50558
		ILevelPlayRefresh,
		// Token: 0x0400C57F RID: 50559
		INoneRefresh,
		// Token: 0x0400C580 RID: 50560
		ICompletedRefresh,
		// Token: 0x0400C581 RID: 50561
		IChildDestroyRefresh,
		// Token: 0x0400C582 RID: 50562
		IChildDestroyOrAwardedRefresh,
		// Token: 0x0400C583 RID: 50563
		IFixedDateTimeRefresh,
		// Token: 0x0400C584 RID: 50564
		ICustomRefresh,
		// Token: 0x0400C585 RID: 50565
		ICustomOnlineRefresh
	}
}

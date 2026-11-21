using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200497A RID: 18810
	public enum ILevelPlayRefresh_Union : byte
	{
		// Token: 0x0400CFAC RID: 53164
		NONE,
		// Token: 0x0400CFAD RID: 53165
		ILevelPlayRefresh,
		// Token: 0x0400CFAE RID: 53166
		INoneRefresh,
		// Token: 0x0400CFAF RID: 53167
		ICompletedRefresh,
		// Token: 0x0400CFB0 RID: 53168
		IChildDestroyRefresh,
		// Token: 0x0400CFB1 RID: 53169
		IChildDestroyOrAwardedRefresh,
		// Token: 0x0400CFB2 RID: 53170
		IFixedDateTimeRefresh,
		// Token: 0x0400CFB3 RID: 53171
		ICustomRefresh,
		// Token: 0x0400CFB4 RID: 53172
		ICustomOnlineRefresh
	}
}

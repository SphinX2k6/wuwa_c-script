using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A74 RID: 27252
	public enum IClientSetSeasonStateConfig_Union : byte
	{
		// Token: 0x040117FF RID: 71679
		NONE,
		// Token: 0x04011800 RID: 71680
		IClientSetSeasonStateConfig,
		// Token: 0x04011801 RID: 71681
		ISwitchSeason,
		// Token: 0x04011802 RID: 71682
		ILoopSeasonChange
	}
}

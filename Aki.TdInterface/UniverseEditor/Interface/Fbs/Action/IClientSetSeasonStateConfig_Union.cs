using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063F4 RID: 25588
	public enum IClientSetSeasonStateConfig_Union : byte
	{
		// Token: 0x040109D9 RID: 68057
		NONE,
		// Token: 0x040109DA RID: 68058
		IClientSetSeasonStateConfig,
		// Token: 0x040109DB RID: 68059
		ISwitchSeason,
		// Token: 0x040109DC RID: 68060
		ILoopSeasonChange
	}
}

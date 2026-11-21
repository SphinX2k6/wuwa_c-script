using System;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x02004848 RID: 18504
	public enum EFocusPriorityType : byte
	{
		// Token: 0x0400CCBC RID: 52412
		None,
		// Token: 0x0400CCBD RID: 52413
		Npc,
		// Token: 0x0400CCBE RID: 52414
		Drop,
		// Token: 0x0400CCBF RID: 52415
		Treasure = 6,
		// Token: 0x0400CCC0 RID: 52416
		MonsterNormal,
		// Token: 0x0400CCC1 RID: 52417
		MonsterBoss = 11
	}
}

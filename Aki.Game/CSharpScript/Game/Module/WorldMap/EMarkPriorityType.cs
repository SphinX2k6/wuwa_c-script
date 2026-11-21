using System;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036C1 RID: 14017
	public enum EMarkPriorityType
	{
		// Token: 0x04014484 RID: 83076
		OthersLevel,
		// Token: 0x04014485 RID: 83077
		Custom = 1000,
		// Token: 0x04014486 RID: 83078
		Quest = 2000,
		// Token: 0x04014487 RID: 83079
		OtherPlayers = 3000,
		// Token: 0x04014488 RID: 83080
		Track = 100000,
		// Token: 0x04014489 RID: 83081
		Select = 200000
	}
}

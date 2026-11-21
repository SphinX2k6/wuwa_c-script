using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x020054B4 RID: 21684
	[Flags]
	public enum EPieceCaps
	{
		// Token: 0x0401C731 RID: 116529
		None = 0,
		// Token: 0x0401C732 RID: 116530
		Fallable = 2,
		// Token: 0x0401C733 RID: 116531
		Swappable = 4,
		// Token: 0x0401C734 RID: 116532
		AdjacentClear = 16,
		// Token: 0x0401C735 RID: 116533
		Land = 32,
		// Token: 0x0401C736 RID: 116534
		Matchable = 128,
		// Token: 0x0401C737 RID: 116535
		SwapEffect = 256,
		// Token: 0x0401C738 RID: 116536
		Block = 1024,
		// Token: 0x0401C739 RID: 116537
		Chain = 2048,
		// Token: 0x0401C73A RID: 116538
		Clearable = 4096,
		// Token: 0x0401C73B RID: 116539
		Health = 8192
	}
}

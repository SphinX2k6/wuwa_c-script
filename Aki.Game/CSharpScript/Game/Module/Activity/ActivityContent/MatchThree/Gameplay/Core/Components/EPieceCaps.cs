using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Core.Components
{
	// Token: 0x02006536 RID: 25910
	[Flags]
	public enum EPieceCaps
	{
		// Token: 0x04021E00 RID: 138752
		None = 0,
		// Token: 0x04021E01 RID: 138753
		Fallable = 2,
		// Token: 0x04021E02 RID: 138754
		Swappable = 4,
		// Token: 0x04021E03 RID: 138755
		AdjacentClear = 16,
		// Token: 0x04021E04 RID: 138756
		Land = 32,
		// Token: 0x04021E05 RID: 138757
		Matchable = 128,
		// Token: 0x04021E06 RID: 138758
		SwapEffect = 256,
		// Token: 0x04021E07 RID: 138759
		Block = 1024,
		// Token: 0x04021E08 RID: 138760
		Chain = 2048,
		// Token: 0x04021E09 RID: 138761
		Clearable = 4096,
		// Token: 0x04021E0A RID: 138762
		Health = 8192
	}
}

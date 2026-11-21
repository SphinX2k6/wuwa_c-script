using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039F4 RID: 14836
	[NullableContext(2)]
	public interface ITrapDefenseDevelopOpenParam
	{
		// Token: 0x17004E05 RID: 19973
		// (get) Token: 0x06026338 RID: 156472
		// (set) Token: 0x06026339 RID: 156473
		bool IsInDungeon { get; set; }

		// Token: 0x17004E06 RID: 19974
		// (get) Token: 0x0602633A RID: 156474
		// (set) Token: 0x0602633B RID: 156475
		int SelectedIndex { get; set; }

		// Token: 0x17004E07 RID: 19975
		// (get) Token: 0x0602633C RID: 156476
		// (set) Token: 0x0602633D RID: 156477
		TrapDefenseLevelData LevelData { get; set; }
	}
}

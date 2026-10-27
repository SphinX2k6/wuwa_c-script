using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A4C RID: 19020
	[NullableContext(2)]
	public interface ITrapDefenseDevelopOpenParam
	{
		// Token: 0x17007A58 RID: 31320
		// (get) Token: 0x060315A8 RID: 202152
		// (set) Token: 0x060315A9 RID: 202153
		bool IsInDungeon { get; set; }

		// Token: 0x17007A59 RID: 31321
		// (get) Token: 0x060315AA RID: 202154
		// (set) Token: 0x060315AB RID: 202155
		int SelectedIndex { get; set; }

		// Token: 0x17007A5A RID: 31322
		// (get) Token: 0x060315AC RID: 202156
		// (set) Token: 0x060315AD RID: 202157
		TrapDefenseLevelData LevelData { get; set; }
	}
}

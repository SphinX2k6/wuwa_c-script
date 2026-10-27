using System;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EDA RID: 20186
	public interface IRogueBattleMapSummeryOpenInfo
	{
		// Token: 0x17007F2D RID: 32557
		// (get) Token: 0x06033CF4 RID: 212212
		// (set) Token: 0x06033CF5 RID: 212213
		EUiTabViewName TabName { get; set; }

		// Token: 0x17007F2E RID: 32558
		// (get) Token: 0x06033CF6 RID: 212214
		// (set) Token: 0x06033CF7 RID: 212215
		int? FetterId { get; set; }
	}
}

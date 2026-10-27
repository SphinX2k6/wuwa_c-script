using System;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EDB RID: 20187
	public class RogueBattleMapSummeryOpenInfo : IRogueBattleMapSummeryOpenInfo
	{
		// Token: 0x17007F2F RID: 32559
		// (get) Token: 0x06033CF8 RID: 212216 RVA: 0x00C21176 File Offset: 0x00C1F376
		// (set) Token: 0x06033CF9 RID: 212217 RVA: 0x00C2117E File Offset: 0x00C1F37E
		public EUiTabViewName TabName { get; set; }

		// Token: 0x17007F30 RID: 32560
		// (get) Token: 0x06033CFA RID: 212218 RVA: 0x00C21187 File Offset: 0x00C1F387
		// (set) Token: 0x06033CFB RID: 212219 RVA: 0x00C2118F File Offset: 0x00C1F38F
		public int? FetterId { get; set; }
	}
}

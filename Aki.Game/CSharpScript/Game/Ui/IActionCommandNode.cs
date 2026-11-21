using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003541 RID: 13633
	internal interface IActionCommandNode
	{
		// Token: 0x17004879 RID: 18553
		// (get) Token: 0x06022AC5 RID: 142021
		// (set) Token: 0x06022AC6 RID: 142022
		EActionCommandType ActionCommand { get; set; }

		// Token: 0x1700487A RID: 18554
		// (get) Token: 0x06022AC7 RID: 142023
		// (set) Token: 0x06022AC8 RID: 142024
		bool Processed { get; set; }
	}
}

using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004618 RID: 17944
	internal interface IActionCommandNode
	{
		// Token: 0x170075C1 RID: 30145
		// (get) Token: 0x0602E3D0 RID: 189392
		// (set) Token: 0x0602E3D1 RID: 189393
		EActionCommandType ActionCommand { get; set; }

		// Token: 0x170075C2 RID: 30146
		// (get) Token: 0x0602E3D2 RID: 189394
		// (set) Token: 0x0602E3D3 RID: 189395
		bool Processed { get; set; }
	}
}

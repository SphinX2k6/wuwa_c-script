using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Plot
{
	// Token: 0x02006320 RID: 25376
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballPlotOptionItemData : IPinballPlotOptionItemData
	{
		// Token: 0x170092E9 RID: 37609
		// (get) Token: 0x0603FD63 RID: 261475 RVA: 0x00F71A91 File Offset: 0x00F6FC91
		// (set) Token: 0x0603FD64 RID: 261476 RVA: 0x00F71A99 File Offset: 0x00F6FC99
		public int OptionIndex { get; set; }

		// Token: 0x170092EA RID: 37610
		// (get) Token: 0x0603FD65 RID: 261477 RVA: 0x00F71AA2 File Offset: 0x00F6FCA2
		// (set) Token: 0x0603FD66 RID: 261478 RVA: 0x00F71AAA File Offset: 0x00F6FCAA
		public TableTextArgNew OptionText { get; set; }

		// Token: 0x170092EB RID: 37611
		// (get) Token: 0x0603FD67 RID: 261479 RVA: 0x00F71AB3 File Offset: 0x00F6FCB3
		// (set) Token: 0x0603FD68 RID: 261480 RVA: 0x00F71ABB File Offset: 0x00F6FCBB
		public Action<int> OptionDelegate { get; set; }
	}
}

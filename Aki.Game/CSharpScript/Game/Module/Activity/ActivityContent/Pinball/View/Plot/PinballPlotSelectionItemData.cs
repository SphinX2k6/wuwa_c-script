using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Plot
{
	// Token: 0x02006323 RID: 25379
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballPlotSelectionItemData : IPinballPlotSelectionItemData
	{
		// Token: 0x170092EE RID: 37614
		// (get) Token: 0x0603FD72 RID: 261490 RVA: 0x00F71C2D File Offset: 0x00F6FE2D
		// (set) Token: 0x0603FD73 RID: 261491 RVA: 0x00F71C35 File Offset: 0x00F6FE35
		public int OptionIndex { get; set; }

		// Token: 0x170092EF RID: 37615
		// (get) Token: 0x0603FD74 RID: 261492 RVA: 0x00F71C3E File Offset: 0x00F6FE3E
		// (set) Token: 0x0603FD75 RID: 261493 RVA: 0x00F71C46 File Offset: 0x00F6FE46
		public Action<int> OptionDelegate { get; set; }
	}
}

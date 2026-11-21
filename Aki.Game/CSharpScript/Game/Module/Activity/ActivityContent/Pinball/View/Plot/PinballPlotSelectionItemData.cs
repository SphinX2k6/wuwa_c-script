using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Plot
{
	// Token: 0x020052A1 RID: 21153
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballPlotSelectionItemData : IPinballPlotSelectionItemData
	{
		// Token: 0x17006650 RID: 26192
		// (get) Token: 0x06034A33 RID: 215603 RVA: 0x00EB8B89 File Offset: 0x00EB6D89
		// (set) Token: 0x06034A34 RID: 215604 RVA: 0x00EB8B91 File Offset: 0x00EB6D91
		public int OptionIndex { get; set; }

		// Token: 0x17006651 RID: 26193
		// (get) Token: 0x06034A35 RID: 215605 RVA: 0x00EB8B9A File Offset: 0x00EB6D9A
		// (set) Token: 0x06034A36 RID: 215606 RVA: 0x00EB8BA2 File Offset: 0x00EB6DA2
		public Action<int> OptionDelegate { get; set; }
	}
}

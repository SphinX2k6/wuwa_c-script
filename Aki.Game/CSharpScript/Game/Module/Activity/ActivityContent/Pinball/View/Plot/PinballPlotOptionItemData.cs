using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Plot
{
	// Token: 0x0200529E RID: 21150
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballPlotOptionItemData : IPinballPlotOptionItemData
	{
		// Token: 0x1700664B RID: 26187
		// (get) Token: 0x06034A24 RID: 215588 RVA: 0x00EB89ED File Offset: 0x00EB6BED
		// (set) Token: 0x06034A25 RID: 215589 RVA: 0x00EB89F5 File Offset: 0x00EB6BF5
		public int OptionIndex { get; set; }

		// Token: 0x1700664C RID: 26188
		// (get) Token: 0x06034A26 RID: 215590 RVA: 0x00EB89FE File Offset: 0x00EB6BFE
		// (set) Token: 0x06034A27 RID: 215591 RVA: 0x00EB8A06 File Offset: 0x00EB6C06
		public TableTextArgNew OptionText { get; set; }

		// Token: 0x1700664D RID: 26189
		// (get) Token: 0x06034A28 RID: 215592 RVA: 0x00EB8A0F File Offset: 0x00EB6C0F
		// (set) Token: 0x06034A29 RID: 215593 RVA: 0x00EB8A17 File Offset: 0x00EB6C17
		public Action<int> OptionDelegate { get; set; }
	}
}

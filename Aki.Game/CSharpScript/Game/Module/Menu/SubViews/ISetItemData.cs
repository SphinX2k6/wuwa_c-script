using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x0200543D RID: 21565
	[NullableContext(1)]
	public interface ISetItemData
	{
		// Token: 0x1700843D RID: 33853
		// (get) Token: 0x0603710B RID: 225547
		// (set) Token: 0x0603710C RID: 225548
		int Index { get; set; }

		// Token: 0x1700843E RID: 33854
		// (get) Token: 0x0603710D RID: 225549
		// (set) Token: 0x0603710E RID: 225550
		int Value { get; set; }

		// Token: 0x1700843F RID: 33855
		// (get) Token: 0x0603710F RID: 225551
		// (set) Token: 0x06037110 RID: 225552
		string Name { get; set; }
	}
}

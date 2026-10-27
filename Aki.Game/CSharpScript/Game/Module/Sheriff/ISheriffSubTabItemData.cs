using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C3F RID: 19519
	[NullableContext(1)]
	public interface ISheriffSubTabItemData
	{
		// Token: 0x17007CB2 RID: 31922
		// (get) Token: 0x060327D4 RID: 206804
		// (set) Token: 0x060327D5 RID: 206805
		ESheriffSubTabType TabType { get; set; }

		// Token: 0x17007CB3 RID: 31923
		// (get) Token: 0x060327D6 RID: 206806
		// (set) Token: 0x060327D7 RID: 206807
		string TabIcon { get; set; }

		// Token: 0x17007CB4 RID: 31924
		// (get) Token: 0x060327D8 RID: 206808
		// (set) Token: 0x060327D9 RID: 206809
		string TabTxt { get; set; }

		// Token: 0x17007CB5 RID: 31925
		// (get) Token: 0x060327DA RID: 206810
		// (set) Token: 0x060327DB RID: 206811
		bool IsFinished { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GameMainView.TrapDefense
{
	// Token: 0x02005A00 RID: 23040
	[NullableContext(2)]
	public interface ITrapDefenseRoundTipsData
	{
		// Token: 0x17008BAF RID: 35759
		// (get) Token: 0x0603A610 RID: 239120
		// (set) Token: 0x0603A611 RID: 239121
		int Round { get; set; }

		// Token: 0x17008BB0 RID: 35760
		// (get) Token: 0x0603A612 RID: 239122
		// (set) Token: 0x0603A613 RID: 239123
		Action Callback { get; set; }
	}
}

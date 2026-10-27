using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GameMainView.TrapDefense
{
	// Token: 0x02005A01 RID: 23041
	[NullableContext(2)]
	[Nullable(0)]
	public class TrapDefenseRoundTipsData : ITrapDefenseRoundTipsData
	{
		// Token: 0x17008BB1 RID: 35761
		// (get) Token: 0x0603A614 RID: 239124 RVA: 0x00DE3EF7 File Offset: 0x00DE20F7
		// (set) Token: 0x0603A615 RID: 239125 RVA: 0x00DE3EFF File Offset: 0x00DE20FF
		public int Round { get; set; }

		// Token: 0x17008BB2 RID: 35762
		// (get) Token: 0x0603A616 RID: 239126 RVA: 0x00DE3F08 File Offset: 0x00DE2108
		// (set) Token: 0x0603A617 RID: 239127 RVA: 0x00DE3F10 File Offset: 0x00DE2110
		public Action Callback { get; set; }
	}
}

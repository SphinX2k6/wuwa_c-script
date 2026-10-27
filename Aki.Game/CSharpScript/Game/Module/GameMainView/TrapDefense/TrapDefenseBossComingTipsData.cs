using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GameMainView.TrapDefense
{
	// Token: 0x020059FD RID: 23037
	[NullableContext(2)]
	[Nullable(0)]
	public class TrapDefenseBossComingTipsData : ITrapDefenseBossComingTipsData
	{
		// Token: 0x17008BAA RID: 35754
		// (get) Token: 0x0603A604 RID: 239108 RVA: 0x00DE3EB4 File Offset: 0x00DE20B4
		// (set) Token: 0x0603A605 RID: 239109 RVA: 0x00DE3EBC File Offset: 0x00DE20BC
		public Action Callback { get; set; }
	}
}

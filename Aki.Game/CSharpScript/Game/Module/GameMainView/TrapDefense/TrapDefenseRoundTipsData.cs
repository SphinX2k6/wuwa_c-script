using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GameMainView.TrapDefense
{
	// Token: 0x020049DD RID: 18909
	[NullableContext(2)]
	[Nullable(0)]
	public class TrapDefenseRoundTipsData : ITrapDefenseRoundTipsData
	{
		// Token: 0x17005F7F RID: 24447
		// (get) Token: 0x0602F55D RID: 193885 RVA: 0x00D34447 File Offset: 0x00D32647
		// (set) Token: 0x0602F55E RID: 193886 RVA: 0x00D3444F File Offset: 0x00D3264F
		public int Round { get; set; }

		// Token: 0x17005F80 RID: 24448
		// (get) Token: 0x0602F55F RID: 193887 RVA: 0x00D34458 File Offset: 0x00D32658
		// (set) Token: 0x0602F560 RID: 193888 RVA: 0x00D34460 File Offset: 0x00D32660
		public Action Callback { get; set; }
	}
}

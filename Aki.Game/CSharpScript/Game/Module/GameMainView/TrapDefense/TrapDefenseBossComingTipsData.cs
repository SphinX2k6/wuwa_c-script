using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GameMainView.TrapDefense
{
	// Token: 0x020049D9 RID: 18905
	[NullableContext(2)]
	[Nullable(0)]
	public class TrapDefenseBossComingTipsData : ITrapDefenseBossComingTipsData
	{
		// Token: 0x17005F78 RID: 24440
		// (get) Token: 0x0602F54D RID: 193869 RVA: 0x00D34404 File Offset: 0x00D32604
		// (set) Token: 0x0602F54E RID: 193870 RVA: 0x00D3440C File Offset: 0x00D3260C
		public Action Callback { get; set; }
	}
}

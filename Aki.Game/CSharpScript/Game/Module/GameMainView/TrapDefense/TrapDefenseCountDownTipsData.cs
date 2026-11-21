using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GameMainView.TrapDefense
{
	// Token: 0x020049DB RID: 18907
	[NullableContext(2)]
	[Nullable(0)]
	public class TrapDefenseCountDownTipsData : ITrapDefenseCountDownTipsData
	{
		// Token: 0x17005F7B RID: 24443
		// (get) Token: 0x0602F554 RID: 193876 RVA: 0x00D3441D File Offset: 0x00D3261D
		// (set) Token: 0x0602F555 RID: 193877 RVA: 0x00D34425 File Offset: 0x00D32625
		public float CountDownTime { get; set; }

		// Token: 0x17005F7C RID: 24444
		// (get) Token: 0x0602F556 RID: 193878 RVA: 0x00D3442E File Offset: 0x00D3262E
		// (set) Token: 0x0602F557 RID: 193879 RVA: 0x00D34436 File Offset: 0x00D32636
		public Action Callback { get; set; }
	}
}

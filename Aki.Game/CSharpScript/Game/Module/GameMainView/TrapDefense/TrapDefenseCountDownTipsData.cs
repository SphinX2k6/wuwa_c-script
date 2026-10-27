using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GameMainView.TrapDefense
{
	// Token: 0x020059FF RID: 23039
	[NullableContext(2)]
	[Nullable(0)]
	public class TrapDefenseCountDownTipsData : ITrapDefenseCountDownTipsData
	{
		// Token: 0x17008BAD RID: 35757
		// (get) Token: 0x0603A60B RID: 239115 RVA: 0x00DE3ECD File Offset: 0x00DE20CD
		// (set) Token: 0x0603A60C RID: 239116 RVA: 0x00DE3ED5 File Offset: 0x00DE20D5
		public float CountDownTime { get; set; }

		// Token: 0x17008BAE RID: 35758
		// (get) Token: 0x0603A60D RID: 239117 RVA: 0x00DE3EDE File Offset: 0x00DE20DE
		// (set) Token: 0x0603A60E RID: 239118 RVA: 0x00DE3EE6 File Offset: 0x00DE20E6
		public Action Callback { get; set; }
	}
}

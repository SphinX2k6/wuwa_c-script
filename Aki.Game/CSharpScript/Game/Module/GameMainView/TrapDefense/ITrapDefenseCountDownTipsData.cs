using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GameMainView.TrapDefense
{
	// Token: 0x020059FE RID: 23038
	[NullableContext(2)]
	public interface ITrapDefenseCountDownTipsData
	{
		// Token: 0x17008BAB RID: 35755
		// (get) Token: 0x0603A607 RID: 239111
		// (set) Token: 0x0603A608 RID: 239112
		float CountDownTime { get; set; }

		// Token: 0x17008BAC RID: 35756
		// (get) Token: 0x0603A609 RID: 239113
		// (set) Token: 0x0603A60A RID: 239114
		Action Callback { get; set; }
	}
}

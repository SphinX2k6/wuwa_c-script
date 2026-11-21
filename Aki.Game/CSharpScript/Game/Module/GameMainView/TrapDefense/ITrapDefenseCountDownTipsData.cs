using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GameMainView.TrapDefense
{
	// Token: 0x020049DA RID: 18906
	[NullableContext(2)]
	public interface ITrapDefenseCountDownTipsData
	{
		// Token: 0x17005F79 RID: 24441
		// (get) Token: 0x0602F550 RID: 193872
		// (set) Token: 0x0602F551 RID: 193873
		float CountDownTime { get; set; }

		// Token: 0x17005F7A RID: 24442
		// (get) Token: 0x0602F552 RID: 193874
		// (set) Token: 0x0602F553 RID: 193875
		Action Callback { get; set; }
	}
}

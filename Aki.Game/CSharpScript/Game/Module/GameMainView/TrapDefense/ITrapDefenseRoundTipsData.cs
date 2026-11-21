using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GameMainView.TrapDefense
{
	// Token: 0x020049DC RID: 18908
	[NullableContext(2)]
	public interface ITrapDefenseRoundTipsData
	{
		// Token: 0x17005F7D RID: 24445
		// (get) Token: 0x0602F559 RID: 193881
		// (set) Token: 0x0602F55A RID: 193882
		int Round { get; set; }

		// Token: 0x17005F7E RID: 24446
		// (get) Token: 0x0602F55B RID: 193883
		// (set) Token: 0x0602F55C RID: 193884
		Action Callback { get; set; }
	}
}

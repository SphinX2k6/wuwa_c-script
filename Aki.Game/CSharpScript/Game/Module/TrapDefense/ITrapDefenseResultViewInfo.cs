using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039FF RID: 14847
	[NullableContext(1)]
	public interface ITrapDefenseResultViewInfo
	{
		// Token: 0x17004E1D RID: 19997
		// (get) Token: 0x0602636D RID: 156525
		// (set) Token: 0x0602636E RID: 156526
		TrapDefenseChallengeResultNotify Notify { get; set; }

		// Token: 0x17004E1E RID: 19998
		// (get) Token: 0x0602636F RID: 156527
		// (set) Token: 0x06026370 RID: 156528
		bool NeedShowViewAnim { get; set; }
	}
}

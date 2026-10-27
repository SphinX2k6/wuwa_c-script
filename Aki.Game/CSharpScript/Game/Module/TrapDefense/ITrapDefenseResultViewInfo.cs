using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A57 RID: 19031
	[NullableContext(1)]
	public interface ITrapDefenseResultViewInfo
	{
		// Token: 0x17007A70 RID: 31344
		// (get) Token: 0x060315DD RID: 202205
		// (set) Token: 0x060315DE RID: 202206
		TrapDefenseChallengeResultNotify Notify { get; set; }

		// Token: 0x17007A71 RID: 31345
		// (get) Token: 0x060315DF RID: 202207
		// (set) Token: 0x060315E0 RID: 202208
		bool NeedShowViewAnim { get; set; }
	}
}

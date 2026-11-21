using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C81 RID: 15489
	[NullableContext(1)]
	public interface IPlanSwitchButtonState
	{
		// Token: 0x17005121 RID: 20769
		// (get) Token: 0x060279EE RID: 162286
		// (set) Token: 0x060279EF RID: 162287
		bool IsShow { get; set; }

		// Token: 0x17005122 RID: 20770
		// (get) Token: 0x060279F0 RID: 162288
		// (set) Token: 0x060279F1 RID: 162289
		string Text { get; set; }

		// Token: 0x17005123 RID: 20771
		// (get) Token: 0x060279F2 RID: 162290
		// (set) Token: 0x060279F3 RID: 162291
		bool IsHighlight { get; set; }
	}
}

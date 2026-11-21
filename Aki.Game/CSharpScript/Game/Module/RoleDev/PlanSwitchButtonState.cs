using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C82 RID: 15490
	[NullableContext(1)]
	[Nullable(0)]
	public class PlanSwitchButtonState : IPlanSwitchButtonState
	{
		// Token: 0x17005124 RID: 20772
		// (get) Token: 0x060279F4 RID: 162292 RVA: 0x00B1A1CE File Offset: 0x00B183CE
		// (set) Token: 0x060279F5 RID: 162293 RVA: 0x00B1A1D6 File Offset: 0x00B183D6
		public bool IsShow { get; set; }

		// Token: 0x17005125 RID: 20773
		// (get) Token: 0x060279F6 RID: 162294 RVA: 0x00B1A1DF File Offset: 0x00B183DF
		// (set) Token: 0x060279F7 RID: 162295 RVA: 0x00B1A1E7 File Offset: 0x00B183E7
		public string Text { get; set; }

		// Token: 0x17005126 RID: 20774
		// (get) Token: 0x060279F8 RID: 162296 RVA: 0x00B1A1F0 File Offset: 0x00B183F0
		// (set) Token: 0x060279F9 RID: 162297 RVA: 0x00B1A1F8 File Offset: 0x00B183F8
		public bool IsHighlight { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046D4 RID: 18132
	[NullableContext(1)]
	public interface IKurotatoComposeHighlight
	{
		// Token: 0x17005BEA RID: 23530
		// (get) Token: 0x0602D93D RID: 186685
		// (set) Token: 0x0602D93E RID: 186686
		HashSet<int> UpgradeSelectionIds { get; set; }

		// Token: 0x17005BEB RID: 23531
		// (get) Token: 0x0602D93F RID: 186687
		// (set) Token: 0x0602D940 RID: 186688
		HashSet<int> ArrowIncIds { get; set; }

		// Token: 0x17005BEC RID: 23532
		// (get) Token: 0x0602D941 RID: 186689
		// (set) Token: 0x0602D942 RID: 186690
		HashSet<int> BagPairArrowIncIds { get; set; }
	}
}

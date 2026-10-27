using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056FD RID: 22269
	[NullableContext(1)]
	public interface IKurotatoComposeHighlight
	{
		// Token: 0x17008822 RID: 34850
		// (get) Token: 0x06038A2D RID: 231981
		// (set) Token: 0x06038A2E RID: 231982
		HashSet<int> UpgradeSelectionIds { get; set; }

		// Token: 0x17008823 RID: 34851
		// (get) Token: 0x06038A2F RID: 231983
		// (set) Token: 0x06038A30 RID: 231984
		HashSet<int> ArrowIncIds { get; set; }

		// Token: 0x17008824 RID: 34852
		// (get) Token: 0x06038A31 RID: 231985
		// (set) Token: 0x06038A32 RID: 231986
		HashSet<int> BagPairArrowIncIds { get; set; }
	}
}

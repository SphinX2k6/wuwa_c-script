using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056FE RID: 22270
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoComposeHighlight : IKurotatoComposeHighlight
	{
		// Token: 0x17008825 RID: 34853
		// (get) Token: 0x06038A33 RID: 231987 RVA: 0x00D707BE File Offset: 0x00D6E9BE
		// (set) Token: 0x06038A34 RID: 231988 RVA: 0x00D707C6 File Offset: 0x00D6E9C6
		public HashSet<int> UpgradeSelectionIds { get; set; }

		// Token: 0x17008826 RID: 34854
		// (get) Token: 0x06038A35 RID: 231989 RVA: 0x00D707CF File Offset: 0x00D6E9CF
		// (set) Token: 0x06038A36 RID: 231990 RVA: 0x00D707D7 File Offset: 0x00D6E9D7
		public HashSet<int> ArrowIncIds { get; set; }

		// Token: 0x17008827 RID: 34855
		// (get) Token: 0x06038A37 RID: 231991 RVA: 0x00D707E0 File Offset: 0x00D6E9E0
		// (set) Token: 0x06038A38 RID: 231992 RVA: 0x00D707E8 File Offset: 0x00D6E9E8
		public HashSet<int> BagPairArrowIncIds { get; set; }
	}
}

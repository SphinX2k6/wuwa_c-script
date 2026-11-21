using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046D5 RID: 18133
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoComposeHighlight : IKurotatoComposeHighlight
	{
		// Token: 0x17005BED RID: 23533
		// (get) Token: 0x0602D943 RID: 186691 RVA: 0x00CBEDA6 File Offset: 0x00CBCFA6
		// (set) Token: 0x0602D944 RID: 186692 RVA: 0x00CBEDAE File Offset: 0x00CBCFAE
		public HashSet<int> UpgradeSelectionIds { get; set; }

		// Token: 0x17005BEE RID: 23534
		// (get) Token: 0x0602D945 RID: 186693 RVA: 0x00CBEDB7 File Offset: 0x00CBCFB7
		// (set) Token: 0x0602D946 RID: 186694 RVA: 0x00CBEDBF File Offset: 0x00CBCFBF
		public HashSet<int> ArrowIncIds { get; set; }

		// Token: 0x17005BEF RID: 23535
		// (get) Token: 0x0602D947 RID: 186695 RVA: 0x00CBEDC8 File Offset: 0x00CBCFC8
		// (set) Token: 0x0602D948 RID: 186696 RVA: 0x00CBEDD0 File Offset: 0x00CBCFD0
		public HashSet<int> BagPairArrowIncIds { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelEntityAbility
{
	// Token: 0x02006FB5 RID: 28597
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelAbilityConfig : ILevelAbilityConfig
	{
		// Token: 0x17009B77 RID: 39799
		// (get) Token: 0x060457FB RID: 284667 RVA: 0x0113DE98 File Offset: 0x0113C098
		// (set) Token: 0x060457FC RID: 284668 RVA: 0x0113DEA0 File Offset: 0x0113C0A0
		public EAbilityTickPhase? TickPhase { get; set; }

		// Token: 0x17009B78 RID: 39800
		// (get) Token: 0x060457FD RID: 284669 RVA: 0x0113DEA9 File Offset: 0x0113C0A9
		// (set) Token: 0x060457FE RID: 284670 RVA: 0x0113DEB1 File Offset: 0x0113C0B1
		public int? TickOrder { get; set; }

		// Token: 0x17009B79 RID: 39801
		// (get) Token: 0x060457FF RID: 284671 RVA: 0x0113DEBA File Offset: 0x0113C0BA
		// (set) Token: 0x06045800 RID: 284672 RVA: 0x0113DEC2 File Offset: 0x0113C0C2
		public bool? NeedTickActivate { get; set; }

		// Token: 0x17009B7A RID: 39802
		// (get) Token: 0x06045801 RID: 284673 RVA: 0x0113DECB File Offset: 0x0113C0CB
		// (set) Token: 0x06045802 RID: 284674 RVA: 0x0113DED3 File Offset: 0x0113C0D3
		public List<EEventName> Events { get; set; }

		// Token: 0x17009B7B RID: 39803
		// (get) Token: 0x06045803 RID: 284675 RVA: 0x0113DEDC File Offset: 0x0113C0DC
		// (set) Token: 0x06045804 RID: 284676 RVA: 0x0113DEE4 File Offset: 0x0113C0E4
		public List<int> BlockedTags { get; set; }
	}
}

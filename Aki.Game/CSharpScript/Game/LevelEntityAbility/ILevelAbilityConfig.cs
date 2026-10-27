using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelEntityAbility
{
	// Token: 0x02006FB4 RID: 28596
	[NullableContext(2)]
	public interface ILevelAbilityConfig
	{
		// Token: 0x17009B72 RID: 39794
		// (get) Token: 0x060457F1 RID: 284657
		// (set) Token: 0x060457F2 RID: 284658
		EAbilityTickPhase? TickPhase { get; set; }

		// Token: 0x17009B73 RID: 39795
		// (get) Token: 0x060457F3 RID: 284659
		// (set) Token: 0x060457F4 RID: 284660
		int? TickOrder { get; set; }

		// Token: 0x17009B74 RID: 39796
		// (get) Token: 0x060457F5 RID: 284661
		// (set) Token: 0x060457F6 RID: 284662
		bool? NeedTickActivate { get; set; }

		// Token: 0x17009B75 RID: 39797
		// (get) Token: 0x060457F7 RID: 284663
		// (set) Token: 0x060457F8 RID: 284664
		List<EEventName> Events { get; set; }

		// Token: 0x17009B76 RID: 39798
		// (get) Token: 0x060457F9 RID: 284665
		// (set) Token: 0x060457FA RID: 284666
		List<int> BlockedTags { get; set; }
	}
}

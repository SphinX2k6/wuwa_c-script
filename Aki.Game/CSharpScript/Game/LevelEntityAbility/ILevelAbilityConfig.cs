using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelEntityAbility
{
	// Token: 0x02006135 RID: 24885
	[NullableContext(2)]
	public interface ILevelAbilityConfig
	{
		// Token: 0x170070B2 RID: 28850
		// (get) Token: 0x0603B9A1 RID: 244129
		// (set) Token: 0x0603B9A2 RID: 244130
		EAbilityTickPhase? TickPhase { get; set; }

		// Token: 0x170070B3 RID: 28851
		// (get) Token: 0x0603B9A3 RID: 244131
		// (set) Token: 0x0603B9A4 RID: 244132
		int? TickOrder { get; set; }

		// Token: 0x170070B4 RID: 28852
		// (get) Token: 0x0603B9A5 RID: 244133
		// (set) Token: 0x0603B9A6 RID: 244134
		bool? NeedTickActivate { get; set; }

		// Token: 0x170070B5 RID: 28853
		// (get) Token: 0x0603B9A7 RID: 244135
		// (set) Token: 0x0603B9A8 RID: 244136
		List<EEventName> Events { get; set; }

		// Token: 0x170070B6 RID: 28854
		// (get) Token: 0x0603B9A9 RID: 244137
		// (set) Token: 0x0603B9AA RID: 244138
		List<int> BlockedTags { get; set; }
	}
}

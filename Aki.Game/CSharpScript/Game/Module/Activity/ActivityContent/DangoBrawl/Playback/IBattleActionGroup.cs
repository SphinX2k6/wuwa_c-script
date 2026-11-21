using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Playback
{
	// Token: 0x020057B1 RID: 22449
	[NullableContext(1)]
	public interface IBattleActionGroup
	{
		// Token: 0x17006AC4 RID: 27332
		// (get) Token: 0x060376E9 RID: 227049
		// (set) Token: 0x060376EA RID: 227050
		int GroupUid { get; set; }

		// Token: 0x17006AC5 RID: 27333
		// (get) Token: 0x060376EB RID: 227051
		// (set) Token: 0x060376EC RID: 227052
		int TriggerMs { get; set; }

		// Token: 0x17006AC6 RID: 27334
		// (get) Token: 0x060376ED RID: 227053
		// (set) Token: 0x060376EE RID: 227054
		List<IDangoBrawlBattleAction> Actions { get; set; }
	}
}

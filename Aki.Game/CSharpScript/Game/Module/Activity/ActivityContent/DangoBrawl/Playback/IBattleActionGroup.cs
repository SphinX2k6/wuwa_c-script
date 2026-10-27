using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Playback
{
	// Token: 0x02006861 RID: 26721
	[NullableContext(1)]
	public interface IBattleActionGroup
	{
		// Token: 0x17009783 RID: 38787
		// (get) Token: 0x06042B94 RID: 273300
		// (set) Token: 0x06042B95 RID: 273301
		int GroupUid { get; set; }

		// Token: 0x17009784 RID: 38788
		// (get) Token: 0x06042B96 RID: 273302
		// (set) Token: 0x06042B97 RID: 273303
		int TriggerMs { get; set; }

		// Token: 0x17009785 RID: 38789
		// (get) Token: 0x06042B98 RID: 273304
		// (set) Token: 0x06042B99 RID: 273305
		List<IDangoBrawlBattleAction> Actions { get; set; }
	}
}

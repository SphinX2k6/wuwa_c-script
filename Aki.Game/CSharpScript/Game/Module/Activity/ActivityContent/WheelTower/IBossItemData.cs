using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F0B RID: 20235
	[NullableContext(1)]
	public interface IBossItemData
	{
		// Token: 0x170062E0 RID: 25312
		// (get) Token: 0x06032DD4 RID: 208340
		// (set) Token: 0x06032DD5 RID: 208341
		IBossInfo BossInfo { get; set; }

		// Token: 0x170062E1 RID: 25313
		// (get) Token: 0x06032DD6 RID: 208342
		// (set) Token: 0x06032DD7 RID: 208343
		float? StartPercent { get; set; }

		// Token: 0x170062E2 RID: 25314
		// (get) Token: 0x06032DD8 RID: 208344
		// (set) Token: 0x06032DD9 RID: 208345
		bool? ShowBossRound { get; set; }
	}
}

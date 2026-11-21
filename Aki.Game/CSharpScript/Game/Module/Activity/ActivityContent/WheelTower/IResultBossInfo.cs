using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F0D RID: 20237
	[NullableContext(1)]
	public interface IResultBossInfo
	{
		// Token: 0x170062E6 RID: 25318
		// (get) Token: 0x06032DE1 RID: 208353
		// (set) Token: 0x06032DE2 RID: 208354
		IBossItemData BossInfo { get; set; }

		// Token: 0x170062E7 RID: 25319
		// (get) Token: 0x06032DE3 RID: 208355
		// (set) Token: 0x06032DE4 RID: 208356
		bool IsDead { get; set; }
	}
}

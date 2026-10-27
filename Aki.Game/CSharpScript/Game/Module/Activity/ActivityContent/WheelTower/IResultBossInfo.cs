using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F26 RID: 24358
	[NullableContext(1)]
	public interface IResultBossInfo
	{
		// Token: 0x17008F14 RID: 36628
		// (get) Token: 0x0603DE46 RID: 253510
		// (set) Token: 0x0603DE47 RID: 253511
		IBossItemData BossInfo { get; set; }

		// Token: 0x17008F15 RID: 36629
		// (get) Token: 0x0603DE48 RID: 253512
		// (set) Token: 0x0603DE49 RID: 253513
		bool IsDead { get; set; }
	}
}

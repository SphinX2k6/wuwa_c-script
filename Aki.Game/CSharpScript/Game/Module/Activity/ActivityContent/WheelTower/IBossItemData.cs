using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F24 RID: 24356
	[NullableContext(1)]
	public interface IBossItemData
	{
		// Token: 0x17008F0E RID: 36622
		// (get) Token: 0x0603DE39 RID: 253497
		// (set) Token: 0x0603DE3A RID: 253498
		IBossInfo BossInfo { get; set; }

		// Token: 0x17008F0F RID: 36623
		// (get) Token: 0x0603DE3B RID: 253499
		// (set) Token: 0x0603DE3C RID: 253500
		float? StartPercent { get; set; }

		// Token: 0x17008F10 RID: 36624
		// (get) Token: 0x0603DE3D RID: 253501
		// (set) Token: 0x0603DE3E RID: 253502
		bool? ShowBossRound { get; set; }
	}
}

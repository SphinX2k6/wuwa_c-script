using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F25 RID: 24357
	[NullableContext(1)]
	[Nullable(0)]
	public class BossItemData : IBossItemData
	{
		// Token: 0x17008F11 RID: 36625
		// (get) Token: 0x0603DE3F RID: 253503 RVA: 0x00EF5559 File Offset: 0x00EF3759
		// (set) Token: 0x0603DE40 RID: 253504 RVA: 0x00EF5561 File Offset: 0x00EF3761
		public IBossInfo BossInfo { get; set; } = new BossInfo();

		// Token: 0x17008F12 RID: 36626
		// (get) Token: 0x0603DE41 RID: 253505 RVA: 0x00EF556A File Offset: 0x00EF376A
		// (set) Token: 0x0603DE42 RID: 253506 RVA: 0x00EF5572 File Offset: 0x00EF3772
		public float? StartPercent { get; set; }

		// Token: 0x17008F13 RID: 36627
		// (get) Token: 0x0603DE43 RID: 253507 RVA: 0x00EF557B File Offset: 0x00EF377B
		// (set) Token: 0x0603DE44 RID: 253508 RVA: 0x00EF5583 File Offset: 0x00EF3783
		public bool? ShowBossRound { get; set; }
	}
}

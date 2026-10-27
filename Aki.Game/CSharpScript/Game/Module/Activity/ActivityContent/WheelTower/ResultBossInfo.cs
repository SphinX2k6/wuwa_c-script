using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F27 RID: 24359
	[NullableContext(1)]
	[Nullable(0)]
	public class ResultBossInfo : IResultBossInfo
	{
		// Token: 0x17008F16 RID: 36630
		// (get) Token: 0x0603DE4A RID: 253514 RVA: 0x00EF559F File Offset: 0x00EF379F
		// (set) Token: 0x0603DE4B RID: 253515 RVA: 0x00EF55A7 File Offset: 0x00EF37A7
		public IBossItemData BossInfo { get; set; } = new BossItemData();

		// Token: 0x17008F17 RID: 36631
		// (get) Token: 0x0603DE4C RID: 253516 RVA: 0x00EF55B0 File Offset: 0x00EF37B0
		// (set) Token: 0x0603DE4D RID: 253517 RVA: 0x00EF55B8 File Offset: 0x00EF37B8
		public bool IsDead { get; set; }
	}
}

using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F0E RID: 20238
	[NullableContext(1)]
	[Nullable(0)]
	public class ResultBossInfo : IResultBossInfo
	{
		// Token: 0x170062E8 RID: 25320
		// (get) Token: 0x06032DE5 RID: 208357 RVA: 0x00E472CB File Offset: 0x00E454CB
		// (set) Token: 0x06032DE6 RID: 208358 RVA: 0x00E472D3 File Offset: 0x00E454D3
		public IBossItemData BossInfo { get; set; } = new BossItemData();

		// Token: 0x170062E9 RID: 25321
		// (get) Token: 0x06032DE7 RID: 208359 RVA: 0x00E472DC File Offset: 0x00E454DC
		// (set) Token: 0x06032DE8 RID: 208360 RVA: 0x00E472E4 File Offset: 0x00E454E4
		public bool IsDead { get; set; }
	}
}

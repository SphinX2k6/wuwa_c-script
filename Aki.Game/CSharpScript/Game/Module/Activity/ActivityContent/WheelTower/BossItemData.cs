using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F0C RID: 20236
	[NullableContext(1)]
	[Nullable(0)]
	public class BossItemData : IBossItemData
	{
		// Token: 0x170062E3 RID: 25315
		// (get) Token: 0x06032DDA RID: 208346 RVA: 0x00E47285 File Offset: 0x00E45485
		// (set) Token: 0x06032DDB RID: 208347 RVA: 0x00E4728D File Offset: 0x00E4548D
		public IBossInfo BossInfo { get; set; } = new BossInfo();

		// Token: 0x170062E4 RID: 25316
		// (get) Token: 0x06032DDC RID: 208348 RVA: 0x00E47296 File Offset: 0x00E45496
		// (set) Token: 0x06032DDD RID: 208349 RVA: 0x00E4729E File Offset: 0x00E4549E
		public float? StartPercent { get; set; }

		// Token: 0x170062E5 RID: 25317
		// (get) Token: 0x06032DDE RID: 208350 RVA: 0x00E472A7 File Offset: 0x00E454A7
		// (set) Token: 0x06032DDF RID: 208351 RVA: 0x00E472AF File Offset: 0x00E454AF
		public bool? ShowBossRound { get; set; }
	}
}

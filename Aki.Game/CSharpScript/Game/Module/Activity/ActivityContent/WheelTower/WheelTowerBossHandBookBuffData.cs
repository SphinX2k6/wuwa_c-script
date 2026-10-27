using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02005F30 RID: 24368
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerBossHandBookBuffData : IWheelTowerBossHandBookBuffData
	{
		// Token: 0x17008F29 RID: 36649
		// (get) Token: 0x0603DE73 RID: 253555 RVA: 0x00EF5671 File Offset: 0x00EF3871
		// (set) Token: 0x0603DE74 RID: 253556 RVA: 0x00EF5679 File Offset: 0x00EF3879
		public int Round { get; set; }

		// Token: 0x17008F2A RID: 36650
		// (get) Token: 0x0603DE75 RID: 253557 RVA: 0x00EF5682 File Offset: 0x00EF3882
		// (set) Token: 0x0603DE76 RID: 253558 RVA: 0x00EF568A File Offset: 0x00EF388A
		public List<int> BuffIdList { get; set; } = new List<int>();

		// Token: 0x17008F2B RID: 36651
		// (get) Token: 0x0603DE77 RID: 253559 RVA: 0x00EF5693 File Offset: 0x00EF3893
		// (set) Token: 0x0603DE78 RID: 253560 RVA: 0x00EF569B File Offset: 0x00EF389B
		public bool IsActivate { get; set; }
	}
}

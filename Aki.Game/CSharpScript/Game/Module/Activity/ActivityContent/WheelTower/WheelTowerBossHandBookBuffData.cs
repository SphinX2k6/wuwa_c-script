using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.WheelTower
{
	// Token: 0x02004F17 RID: 20247
	[NullableContext(1)]
	[Nullable(0)]
	public class WheelTowerBossHandBookBuffData : IWheelTowerBossHandBookBuffData
	{
		// Token: 0x170062FB RID: 25339
		// (get) Token: 0x06032E0E RID: 208398 RVA: 0x00E4739D File Offset: 0x00E4559D
		// (set) Token: 0x06032E0F RID: 208399 RVA: 0x00E473A5 File Offset: 0x00E455A5
		public int Round { get; set; }

		// Token: 0x170062FC RID: 25340
		// (get) Token: 0x06032E10 RID: 208400 RVA: 0x00E473AE File Offset: 0x00E455AE
		// (set) Token: 0x06032E11 RID: 208401 RVA: 0x00E473B6 File Offset: 0x00E455B6
		public List<int> BuffIdList { get; set; } = new List<int>();

		// Token: 0x170062FD RID: 25341
		// (get) Token: 0x06032E12 RID: 208402 RVA: 0x00E473BF File Offset: 0x00E455BF
		// (set) Token: 0x06032E13 RID: 208403 RVA: 0x00E473C7 File Offset: 0x00E455C7
		public bool IsActivate { get; set; }
	}
}

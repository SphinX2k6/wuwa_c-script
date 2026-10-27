using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02005ECC RID: 24268
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelPlayNightMareConfigData : ILevelPlayNightMareConfigData
	{
		// Token: 0x17008EDD RID: 36573
		// (get) Token: 0x0603DB39 RID: 252729 RVA: 0x00EE5E01 File Offset: 0x00EE4001
		// (set) Token: 0x0603DB3A RID: 252730 RVA: 0x00EE5E09 File Offset: 0x00EE4009
		public int LevelPlayId { get; set; }

		// Token: 0x17008EDE RID: 36574
		// (get) Token: 0x0603DB3B RID: 252731 RVA: 0x00EE5E12 File Offset: 0x00EE4012
		// (set) Token: 0x0603DB3C RID: 252732 RVA: 0x00EE5E1A File Offset: 0x00EE401A
		public string[] Vars { get; set; }

		// Token: 0x17008EDF RID: 36575
		// (get) Token: 0x0603DB3D RID: 252733 RVA: 0x00EE5E23 File Offset: 0x00EE4023
		// (set) Token: 0x0603DB3E RID: 252734 RVA: 0x00EE5E2B File Offset: 0x00EE402B
		public int[] DefaultValues { get; set; }
	}
}

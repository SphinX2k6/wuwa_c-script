using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A11 RID: 14865
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseLevelTargetItemData : ITrapDefenseLevelTargetItemData
	{
		// Token: 0x17004E59 RID: 20057
		// (get) Token: 0x060263D9 RID: 156633 RVA: 0x00AB66AD File Offset: 0x00AB48AD
		// (set) Token: 0x060263DA RID: 156634 RVA: 0x00AB66B5 File Offset: 0x00AB48B5
		public ITrapDefenseLevelTargetInfo Info { get; set; }

		// Token: 0x17004E5A RID: 20058
		// (get) Token: 0x060263DB RID: 156635 RVA: 0x00AB66BE File Offset: 0x00AB48BE
		// (set) Token: 0x060263DC RID: 156636 RVA: 0x00AB66C6 File Offset: 0x00AB48C6
		public int TargetValue { get; set; }

		// Token: 0x17004E5B RID: 20059
		// (get) Token: 0x060263DD RID: 156637 RVA: 0x00AB66CF File Offset: 0x00AB48CF
		// (set) Token: 0x060263DE RID: 156638 RVA: 0x00AB66D7 File Offset: 0x00AB48D7
		public int TargetStar { get; set; }

		// Token: 0x17004E5C RID: 20060
		// (get) Token: 0x060263DF RID: 156639 RVA: 0x00AB66E0 File Offset: 0x00AB48E0
		// (set) Token: 0x060263E0 RID: 156640 RVA: 0x00AB66E8 File Offset: 0x00AB48E8
		public bool IsFinish { get; set; }
	}
}

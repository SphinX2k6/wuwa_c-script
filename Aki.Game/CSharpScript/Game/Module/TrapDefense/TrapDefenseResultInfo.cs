using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A02 RID: 14850
	public class TrapDefenseResultInfo : ITrapDefenseResultInfo
	{
		// Token: 0x17004E25 RID: 20005
		// (get) Token: 0x0602637E RID: 156542 RVA: 0x00AB6441 File Offset: 0x00AB4641
		// (set) Token: 0x0602637F RID: 156543 RVA: 0x00AB6449 File Offset: 0x00AB4649
		public int Value { get; set; }

		// Token: 0x17004E26 RID: 20006
		// (get) Token: 0x06026380 RID: 156544 RVA: 0x00AB6452 File Offset: 0x00AB4652
		// (set) Token: 0x06026381 RID: 156545 RVA: 0x00AB645A File Offset: 0x00AB465A
		public ETrapDefenseResultType Type { get; set; }

		// Token: 0x17004E27 RID: 20007
		// (get) Token: 0x06026382 RID: 156546 RVA: 0x00AB6463 File Offset: 0x00AB4663
		// (set) Token: 0x06026383 RID: 156547 RVA: 0x00AB646B File Offset: 0x00AB466B
		public int? Total { get; set; }

		// Token: 0x17004E28 RID: 20008
		// (get) Token: 0x06026384 RID: 156548 RVA: 0x00AB6474 File Offset: 0x00AB4674
		// (set) Token: 0x06026385 RID: 156549 RVA: 0x00AB647C File Offset: 0x00AB467C
		public int? History { get; set; }
	}
}

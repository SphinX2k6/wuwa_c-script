using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039F8 RID: 14840
	public class TrapDefenseDevelopPreviewLevelInfo : ITrapDefenseDevelopPreviewLevelInfo
	{
		// Token: 0x17004E0E RID: 19982
		// (get) Token: 0x0602634C RID: 156492 RVA: 0x00AB6366 File Offset: 0x00AB4566
		// (set) Token: 0x0602634D RID: 156493 RVA: 0x00AB636E File Offset: 0x00AB456E
		public int Id { get; set; }

		// Token: 0x17004E0F RID: 19983
		// (get) Token: 0x0602634E RID: 156494 RVA: 0x00AB6377 File Offset: 0x00AB4577
		// (set) Token: 0x0602634F RID: 156495 RVA: 0x00AB637F File Offset: 0x00AB457F
		public bool IsCurLevel { get; set; }

		// Token: 0x17004E10 RID: 19984
		// (get) Token: 0x06026350 RID: 156496 RVA: 0x00AB6388 File Offset: 0x00AB4588
		// (set) Token: 0x06026351 RID: 156497 RVA: 0x00AB6390 File Offset: 0x00AB4590
		public bool? NeedAlpha { get; set; }
	}
}

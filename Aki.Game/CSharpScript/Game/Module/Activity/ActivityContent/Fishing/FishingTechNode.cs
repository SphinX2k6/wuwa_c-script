using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200557A RID: 21882
	public class FishingTechNode : IFishingTechNode
	{
		// Token: 0x1700693C RID: 26940
		// (get) Token: 0x060363CE RID: 222158 RVA: 0x00F20B4B File Offset: 0x00F1ED4B
		// (set) Token: 0x060363CF RID: 222159 RVA: 0x00F20B53 File Offset: 0x00F1ED53
		public int ConfigId { get; set; }

		// Token: 0x1700693D RID: 26941
		// (get) Token: 0x060363D0 RID: 222160 RVA: 0x00F20B5C File Offset: 0x00F1ED5C
		// (set) Token: 0x060363D1 RID: 222161 RVA: 0x00F20B64 File Offset: 0x00F1ED64
		public EFishingTechNodeType NodeType { get; set; }

		// Token: 0x1700693E RID: 26942
		// (get) Token: 0x060363D2 RID: 222162 RVA: 0x00F20B6D File Offset: 0x00F1ED6D
		// (set) Token: 0x060363D3 RID: 222163 RVA: 0x00F20B75 File Offset: 0x00F1ED75
		public int Area { get; set; }

		// Token: 0x1700693F RID: 26943
		// (get) Token: 0x060363D4 RID: 222164 RVA: 0x00F20B7E File Offset: 0x00F1ED7E
		// (set) Token: 0x060363D5 RID: 222165 RVA: 0x00F20B86 File Offset: 0x00F1ED86
		public int PreNode { get; set; }
	}
}

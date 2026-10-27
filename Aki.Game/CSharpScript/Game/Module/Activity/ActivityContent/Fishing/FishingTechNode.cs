using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065FC RID: 26108
	public class FishingTechNode : IFishingTechNode
	{
		// Token: 0x170095DA RID: 38362
		// (get) Token: 0x06041709 RID: 268041 RVA: 0x00FD9ACB File Offset: 0x00FD7CCB
		// (set) Token: 0x0604170A RID: 268042 RVA: 0x00FD9AD3 File Offset: 0x00FD7CD3
		public int ConfigId { get; set; }

		// Token: 0x170095DB RID: 38363
		// (get) Token: 0x0604170B RID: 268043 RVA: 0x00FD9ADC File Offset: 0x00FD7CDC
		// (set) Token: 0x0604170C RID: 268044 RVA: 0x00FD9AE4 File Offset: 0x00FD7CE4
		public EFishingTechNodeType NodeType { get; set; }

		// Token: 0x170095DC RID: 38364
		// (get) Token: 0x0604170D RID: 268045 RVA: 0x00FD9AED File Offset: 0x00FD7CED
		// (set) Token: 0x0604170E RID: 268046 RVA: 0x00FD9AF5 File Offset: 0x00FD7CF5
		public int Area { get; set; }

		// Token: 0x170095DD RID: 38365
		// (get) Token: 0x0604170F RID: 268047 RVA: 0x00FD9AFE File Offset: 0x00FD7CFE
		// (set) Token: 0x06041710 RID: 268048 RVA: 0x00FD9B06 File Offset: 0x00FD7D06
		public int PreNode { get; set; }
	}
}

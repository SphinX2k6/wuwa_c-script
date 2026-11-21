using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200422A RID: 16938
	public class IEavesdropGamePlayConfigT
	{
		// Token: 0x17007376 RID: 29558
		// (get) Token: 0x060178CA RID: 96458 RVA: 0x0035C7AC File Offset: 0x0035A9AC
		// (set) Token: 0x060178CB RID: 96459 RVA: 0x0035C7B4 File Offset: 0x0035A9B4
		public ESpecialGamePlayConfigType Type { get; set; }

		// Token: 0x17007377 RID: 29559
		// (get) Token: 0x060178CC RID: 96460 RVA: 0x0035C7BD File Offset: 0x0035A9BD
		// (set) Token: 0x060178CD RID: 96461 RVA: 0x0035C7C5 File Offset: 0x0035A9C5
		public int EavesdropEntityId { get; set; }

		// Token: 0x17007378 RID: 29560
		// (get) Token: 0x060178CE RID: 96462 RVA: 0x0035C7CE File Offset: 0x0035A9CE
		// (set) Token: 0x060178CF RID: 96463 RVA: 0x0035C7D6 File Offset: 0x0035A9D6
		public int HintRangeEntityId { get; set; }

		// Token: 0x17007379 RID: 29561
		// (get) Token: 0x060178D0 RID: 96464 RVA: 0x0035C7DF File Offset: 0x0035A9DF
		// (set) Token: 0x060178D1 RID: 96465 RVA: 0x0035C7E7 File Offset: 0x0035A9E7
		public int ListenableRangeEntityId { get; set; }

		// Token: 0x1700737A RID: 29562
		// (get) Token: 0x060178D2 RID: 96466 RVA: 0x0035C7F0 File Offset: 0x0035A9F0
		// (set) Token: 0x060178D3 RID: 96467 RVA: 0x0035C7F8 File Offset: 0x0035A9F8
		public int TooCloseRangeEntityId { get; set; }

		// Token: 0x1700737B RID: 29563
		// (get) Token: 0x060178D4 RID: 96468 RVA: 0x0035C801 File Offset: 0x0035AA01
		// (set) Token: 0x060178D5 RID: 96469 RVA: 0x0035C809 File Offset: 0x0035AA09
		public int HintTag { get; set; }

		// Token: 0x1700737C RID: 29564
		// (get) Token: 0x060178D6 RID: 96470 RVA: 0x0035C812 File Offset: 0x0035AA12
		// (set) Token: 0x060178D7 RID: 96471 RVA: 0x0035C81A File Offset: 0x0035AA1A
		public int ListenableTag { get; set; }

		// Token: 0x1700737D RID: 29565
		// (get) Token: 0x060178D8 RID: 96472 RVA: 0x0035C823 File Offset: 0x0035AA23
		// (set) Token: 0x060178D9 RID: 96473 RVA: 0x0035C82B File Offset: 0x0035AA2B
		public int TooCloseTag { get; set; }

		// Token: 0x1700737E RID: 29566
		// (get) Token: 0x060178DA RID: 96474 RVA: 0x0035C834 File Offset: 0x0035AA34
		// (set) Token: 0x060178DB RID: 96475 RVA: 0x0035C83C File Offset: 0x0035AA3C
		public int ListenedTag { get; set; }

		// Token: 0x1700737F RID: 29567
		// (get) Token: 0x060178DC RID: 96476 RVA: 0x0035C845 File Offset: 0x0035AA45
		// (set) Token: 0x060178DD RID: 96477 RVA: 0x0035C84D File Offset: 0x0035AA4D
		public int EavesdroppingTag { get; set; }

		// Token: 0x17007380 RID: 29568
		// (get) Token: 0x060178DE RID: 96478 RVA: 0x0035C856 File Offset: 0x0035AA56
		// (set) Token: 0x060178DF RID: 96479 RVA: 0x0035C85E File Offset: 0x0035AA5E
		public bool BlockInteractOnListen { get; set; }

		// Token: 0x17007381 RID: 29569
		// (get) Token: 0x060178E0 RID: 96480 RVA: 0x0035C867 File Offset: 0x0035AA67
		// (set) Token: 0x060178E1 RID: 96481 RVA: 0x0035C86F File Offset: 0x0035AA6F
		public byte NullMask { get; set; }

		// Token: 0x060178E2 RID: 96482 RVA: 0x0035C878 File Offset: 0x0035AA78
		public IEavesdropGamePlayConfigT()
		{
			this.Type = ESpecialGamePlayConfigType.Stalking;
			this.EavesdropEntityId = 0;
			this.HintRangeEntityId = 0;
			this.ListenableRangeEntityId = 0;
			this.TooCloseRangeEntityId = 0;
			this.HintTag = 0;
			this.ListenableTag = 0;
			this.TooCloseTag = 0;
			this.ListenedTag = 0;
			this.EavesdroppingTag = 0;
			this.BlockInteractOnListen = false;
			this.NullMask = 0;
		}
	}
}

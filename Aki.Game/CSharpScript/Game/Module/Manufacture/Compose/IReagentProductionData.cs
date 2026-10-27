using System;

namespace CSharpScript.Game.Module.Manufacture.Compose
{
	// Token: 0x02005660 RID: 22112
	public class IReagentProductionData : IBaseItemData
	{
		// Token: 0x17008759 RID: 34649
		// (get) Token: 0x06038409 RID: 230409 RVA: 0x00D5563F File Offset: 0x00D5383F
		// (set) Token: 0x0603840A RID: 230410 RVA: 0x00D55647 File Offset: 0x00D53847
		public ESubComposeDataType SubType { get; set; }

		// Token: 0x1700875A RID: 34650
		// (get) Token: 0x0603840B RID: 230411 RVA: 0x00D55650 File Offset: 0x00D53850
		// (set) Token: 0x0603840C RID: 230412 RVA: 0x00D55658 File Offset: 0x00D53858
		public int UniqueId { get; set; }

		// Token: 0x1700875B RID: 34651
		// (get) Token: 0x0603840D RID: 230413 RVA: 0x00D55661 File Offset: 0x00D53861
		// (set) Token: 0x0603840E RID: 230414 RVA: 0x00D55669 File Offset: 0x00D53869
		public int ComposeCount { get; set; }

		// Token: 0x1700875C RID: 34652
		// (get) Token: 0x0603840F RID: 230415 RVA: 0x00D55672 File Offset: 0x00D53872
		// (set) Token: 0x06038410 RID: 230416 RVA: 0x00D5567A File Offset: 0x00D5387A
		public int LastRoleId { get; set; }

		// Token: 0x1700875D RID: 34653
		// (get) Token: 0x06038411 RID: 230417 RVA: 0x00D55683 File Offset: 0x00D53883
		// (set) Token: 0x06038412 RID: 230418 RVA: 0x00D5568B File Offset: 0x00D5388B
		public int EffectType { get; set; }
	}
}

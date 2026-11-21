using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200549D RID: 21661
	public class ICategoryMatchingSucceedT
	{
		// Token: 0x17009A58 RID: 39512
		// (get) Token: 0x06022187 RID: 139655 RVA: 0x004B35CF File Offset: 0x004B17CF
		// (set) Token: 0x06022188 RID: 139656 RVA: 0x004B35D7 File Offset: 0x004B17D7
		public bool IsSilent { get; set; }

		// Token: 0x17009A59 RID: 39513
		// (get) Token: 0x06022189 RID: 139657 RVA: 0x004B35E0 File Offset: 0x004B17E0
		// (set) Token: 0x0602218A RID: 139658 RVA: 0x004B35E8 File Offset: 0x004B17E8
		public bool IsDestroy { get; set; }

		// Token: 0x17009A5A RID: 39514
		// (get) Token: 0x0602218B RID: 139659 RVA: 0x004B35F1 File Offset: 0x004B17F1
		// (set) Token: 0x0602218C RID: 139660 RVA: 0x004B35F9 File Offset: 0x004B17F9
		public bool SyncAdsorbatePerformance { get; set; }

		// Token: 0x17009A5B RID: 39515
		// (get) Token: 0x0602218D RID: 139661 RVA: 0x004B3602 File Offset: 0x004B1802
		// (set) Token: 0x0602218E RID: 139662 RVA: 0x004B360A File Offset: 0x004B180A
		public string ChangeSelfState { get; set; }

		// Token: 0x17009A5C RID: 39516
		// (get) Token: 0x0602218F RID: 139663 RVA: 0x004B3613 File Offset: 0x004B1813
		// (set) Token: 0x06022190 RID: 139664 RVA: 0x004B361B File Offset: 0x004B181B
		public IEntityStateT ChangeItemState { get; set; }

		// Token: 0x17009A5D RID: 39517
		// (get) Token: 0x06022191 RID: 139665 RVA: 0x004B3624 File Offset: 0x004B1824
		// (set) Token: 0x06022192 RID: 139666 RVA: 0x004B362C File Offset: 0x004B182C
		public int DelayDischarge { get; set; }

		// Token: 0x17009A5E RID: 39518
		// (get) Token: 0x06022193 RID: 139667 RVA: 0x004B3635 File Offset: 0x004B1835
		// (set) Token: 0x06022194 RID: 139668 RVA: 0x004B363D File Offset: 0x004B183D
		public IEntityStateT ChangeItemStateAfterDischarged { get; set; }

		// Token: 0x17009A5F RID: 39519
		// (get) Token: 0x06022195 RID: 139669 RVA: 0x004B3646 File Offset: 0x004B1846
		// (set) Token: 0x06022196 RID: 139670 RVA: 0x004B364E File Offset: 0x004B184E
		public string ChangeSelfStateAfterDischarged { get; set; }

		// Token: 0x17009A60 RID: 39520
		// (get) Token: 0x06022197 RID: 139671 RVA: 0x004B3657 File Offset: 0x004B1857
		// (set) Token: 0x06022198 RID: 139672 RVA: 0x004B365F File Offset: 0x004B185F
		public IItemChangeAdsorbateStateT ChangeAdsorbateState { get; set; }

		// Token: 0x17009A61 RID: 39521
		// (get) Token: 0x06022199 RID: 139673 RVA: 0x004B3668 File Offset: 0x004B1868
		// (set) Token: 0x0602219A RID: 139674 RVA: 0x004B3670 File Offset: 0x004B1870
		public string DischargeSequence { get; set; }

		// Token: 0x17009A62 RID: 39522
		// (get) Token: 0x0602219B RID: 139675 RVA: 0x004B3679 File Offset: 0x004B1879
		// (set) Token: 0x0602219C RID: 139676 RVA: 0x004B3681 File Offset: 0x004B1881
		public byte NullMask { get; set; }

		// Token: 0x0602219D RID: 139677 RVA: 0x004B368C File Offset: 0x004B188C
		public ICategoryMatchingSucceedT()
		{
			this.IsSilent = false;
			this.IsDestroy = false;
			this.SyncAdsorbatePerformance = false;
			this.ChangeSelfState = null;
			this.ChangeItemState = null;
			this.DelayDischarge = 0;
			this.ChangeItemStateAfterDischarged = null;
			this.ChangeSelfStateAfterDischarged = null;
			this.ChangeAdsorbateState = null;
			this.DischargeSequence = null;
			this.NullMask = 0;
		}
	}
}

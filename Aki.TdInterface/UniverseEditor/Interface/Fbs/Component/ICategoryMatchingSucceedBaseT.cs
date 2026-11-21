using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054A0 RID: 21664
	public class ICategoryMatchingSucceedBaseT
	{
		// Token: 0x17009A6D RID: 39533
		// (get) Token: 0x060221C1 RID: 139713 RVA: 0x004B3DB3 File Offset: 0x004B1FB3
		// (set) Token: 0x060221C2 RID: 139714 RVA: 0x004B3DBB File Offset: 0x004B1FBB
		public bool IsSilent { get; set; }

		// Token: 0x17009A6E RID: 39534
		// (get) Token: 0x060221C3 RID: 139715 RVA: 0x004B3DC4 File Offset: 0x004B1FC4
		// (set) Token: 0x060221C4 RID: 139716 RVA: 0x004B3DCC File Offset: 0x004B1FCC
		public bool IsDestroy { get; set; }

		// Token: 0x17009A6F RID: 39535
		// (get) Token: 0x060221C5 RID: 139717 RVA: 0x004B3DD5 File Offset: 0x004B1FD5
		// (set) Token: 0x060221C6 RID: 139718 RVA: 0x004B3DDD File Offset: 0x004B1FDD
		public bool SyncAdsorbatePerformance { get; set; }

		// Token: 0x17009A70 RID: 39536
		// (get) Token: 0x060221C7 RID: 139719 RVA: 0x004B3DE6 File Offset: 0x004B1FE6
		// (set) Token: 0x060221C8 RID: 139720 RVA: 0x004B3DEE File Offset: 0x004B1FEE
		public string ChangeSelfState { get; set; }

		// Token: 0x17009A71 RID: 39537
		// (get) Token: 0x060221C9 RID: 139721 RVA: 0x004B3DF7 File Offset: 0x004B1FF7
		// (set) Token: 0x060221CA RID: 139722 RVA: 0x004B3DFF File Offset: 0x004B1FFF
		public IEntityStateT ChangeItemState { get; set; }

		// Token: 0x17009A72 RID: 39538
		// (get) Token: 0x060221CB RID: 139723 RVA: 0x004B3E08 File Offset: 0x004B2008
		// (set) Token: 0x060221CC RID: 139724 RVA: 0x004B3E10 File Offset: 0x004B2010
		public int DelayDischarge { get; set; }

		// Token: 0x17009A73 RID: 39539
		// (get) Token: 0x060221CD RID: 139725 RVA: 0x004B3E19 File Offset: 0x004B2019
		// (set) Token: 0x060221CE RID: 139726 RVA: 0x004B3E21 File Offset: 0x004B2021
		public IEntityStateT ChangeItemStateAfterDischarged { get; set; }

		// Token: 0x17009A74 RID: 39540
		// (get) Token: 0x060221CF RID: 139727 RVA: 0x004B3E2A File Offset: 0x004B202A
		// (set) Token: 0x060221D0 RID: 139728 RVA: 0x004B3E32 File Offset: 0x004B2032
		public string ChangeSelfStateAfterDischarged { get; set; }

		// Token: 0x17009A75 RID: 39541
		// (get) Token: 0x060221D1 RID: 139729 RVA: 0x004B3E3B File Offset: 0x004B203B
		// (set) Token: 0x060221D2 RID: 139730 RVA: 0x004B3E43 File Offset: 0x004B2043
		public byte NullMask { get; set; }

		// Token: 0x060221D3 RID: 139731 RVA: 0x004B3E4C File Offset: 0x004B204C
		public ICategoryMatchingSucceedBaseT()
		{
			this.IsSilent = false;
			this.IsDestroy = false;
			this.SyncAdsorbatePerformance = false;
			this.ChangeSelfState = null;
			this.ChangeItemState = null;
			this.DelayDischarge = 0;
			this.ChangeItemStateAfterDischarged = null;
			this.ChangeSelfStateAfterDischarged = null;
			this.NullMask = 0;
		}
	}
}

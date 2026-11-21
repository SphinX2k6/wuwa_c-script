using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005656 RID: 22102
	public class IDynamicPortalCreateModeT
	{
		// Token: 0x17009ED6 RID: 40662
		// (get) Token: 0x06023539 RID: 144697 RVA: 0x004DC480 File Offset: 0x004DA680
		// (set) Token: 0x0602353A RID: 144698 RVA: 0x004DC488 File Offset: 0x004DA688
		public EDynamicPortalCreateType Type { get; set; }

		// Token: 0x17009ED7 RID: 40663
		// (get) Token: 0x0602353B RID: 144699 RVA: 0x004DC491 File Offset: 0x004DA691
		// (set) Token: 0x0602353C RID: 144700 RVA: 0x004DC499 File Offset: 0x004DA699
		public IDynamicPortalConfigT PortalA { get; set; }

		// Token: 0x17009ED8 RID: 40664
		// (get) Token: 0x0602353D RID: 144701 RVA: 0x004DC4A2 File Offset: 0x004DA6A2
		// (set) Token: 0x0602353E RID: 144702 RVA: 0x004DC4AA File Offset: 0x004DA6AA
		public IDynamicPortalConfigT PortalB { get; set; }

		// Token: 0x17009ED9 RID: 40665
		// (get) Token: 0x0602353F RID: 144703 RVA: 0x004DC4B3 File Offset: 0x004DA6B3
		// (set) Token: 0x06023540 RID: 144704 RVA: 0x004DC4BB File Offset: 0x004DA6BB
		public EPortalModel InitOpenPortal { get; set; }

		// Token: 0x17009EDA RID: 40666
		// (get) Token: 0x06023541 RID: 144705 RVA: 0x004DC4C4 File Offset: 0x004DA6C4
		// (set) Token: 0x06023542 RID: 144706 RVA: 0x004DC4CC File Offset: 0x004DA6CC
		public IPortalRenderConfigT RenderConfig { get; set; }

		// Token: 0x17009EDB RID: 40667
		// (get) Token: 0x06023543 RID: 144707 RVA: 0x004DC4D5 File Offset: 0x004DA6D5
		// (set) Token: 0x06023544 RID: 144708 RVA: 0x004DC4DD File Offset: 0x004DA6DD
		public byte NullMask { get; set; }

		// Token: 0x06023545 RID: 144709 RVA: 0x004DC4E6 File Offset: 0x004DA6E6
		public IDynamicPortalCreateModeT()
		{
			this.Type = EDynamicPortalCreateType.Bullet;
			this.PortalA = null;
			this.PortalB = null;
			this.InitOpenPortal = EPortalModel.A;
			this.RenderConfig = null;
			this.NullMask = 0;
		}
	}
}

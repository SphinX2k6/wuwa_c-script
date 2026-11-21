using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D74 RID: 23924
	public class IPortalModeT
	{
		// Token: 0x1700B014 RID: 45076
		// (get) Token: 0x06027D4B RID: 163147 RVA: 0x00572D3D File Offset: 0x00570F3D
		// (set) Token: 0x06027D4C RID: 163148 RVA: 0x00572D45 File Offset: 0x00570F45
		public EPortalType Type { get; set; }

		// Token: 0x1700B015 RID: 45077
		// (get) Token: 0x06027D4D RID: 163149 RVA: 0x00572D4E File Offset: 0x00570F4E
		// (set) Token: 0x06027D4E RID: 163150 RVA: 0x00572D56 File Offset: 0x00570F56
		public EPortalModel PortalModel { get; set; }

		// Token: 0x1700B016 RID: 45078
		// (get) Token: 0x06027D4F RID: 163151 RVA: 0x00572D5F File Offset: 0x00570F5F
		// (set) Token: 0x06027D50 RID: 163152 RVA: 0x00572D67 File Offset: 0x00570F67
		public IPortalRenderConfigT RenderConfig { get; set; }

		// Token: 0x06027D51 RID: 163153 RVA: 0x00572D70 File Offset: 0x00570F70
		public IPortalModeT()
		{
			this.Type = EPortalType.Static;
			this.PortalModel = EPortalModel.A;
			this.RenderConfig = null;
		}
	}
}

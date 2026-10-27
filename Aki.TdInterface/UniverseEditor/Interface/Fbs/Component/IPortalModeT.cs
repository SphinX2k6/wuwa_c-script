using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200576D RID: 22381
	public class IPortalModeT
	{
		// Token: 0x1700A6F0 RID: 42736
		// (get) Token: 0x0602582B RID: 153643 RVA: 0x0052CBB1 File Offset: 0x0052ADB1
		// (set) Token: 0x0602582C RID: 153644 RVA: 0x0052CBB9 File Offset: 0x0052ADB9
		public EPortalType Type { get; set; }

		// Token: 0x1700A6F1 RID: 42737
		// (get) Token: 0x0602582D RID: 153645 RVA: 0x0052CBC2 File Offset: 0x0052ADC2
		// (set) Token: 0x0602582E RID: 153646 RVA: 0x0052CBCA File Offset: 0x0052ADCA
		public EPortalModel PortalModel { get; set; }

		// Token: 0x1700A6F2 RID: 42738
		// (get) Token: 0x0602582F RID: 153647 RVA: 0x0052CBD3 File Offset: 0x0052ADD3
		// (set) Token: 0x06025830 RID: 153648 RVA: 0x0052CBDB File Offset: 0x0052ADDB
		public IPortalRenderConfigT RenderConfig { get; set; }

		// Token: 0x06025831 RID: 153649 RVA: 0x0052CBE4 File Offset: 0x0052ADE4
		public IPortalModeT()
		{
			this.Type = EPortalType.Static;
			this.PortalModel = EPortalModel.A;
			this.RenderConfig = null;
		}
	}
}

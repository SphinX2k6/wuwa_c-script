using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050EE RID: 20718
	public class IDynamicPortalConfigT
	{
		// Token: 0x170096E0 RID: 38624
		// (get) Token: 0x060215C7 RID: 136647 RVA: 0x004A202F File Offset: 0x004A022F
		// (set) Token: 0x060215C8 RID: 136648 RVA: 0x004A2037 File Offset: 0x004A0237
		public EPortalModel PortalModel { get; set; }

		// Token: 0x170096E1 RID: 38625
		// (get) Token: 0x060215C9 RID: 136649 RVA: 0x004A2040 File Offset: 0x004A0240
		// (set) Token: 0x060215CA RID: 136650 RVA: 0x004A2048 File Offset: 0x004A0248
		public string TemplateId { get; set; }

		// Token: 0x060215CB RID: 136651 RVA: 0x004A2051 File Offset: 0x004A0251
		public IDynamicPortalConfigT()
		{
			this.PortalModel = EPortalModel.A;
			this.TemplateId = null;
		}
	}
}

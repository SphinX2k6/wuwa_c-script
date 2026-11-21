using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049E7 RID: 18919
	public class IRollBlockGridTemplateT
	{
		// Token: 0x170084AE RID: 33966
		// (get) Token: 0x0601C5D0 RID: 116176 RVA: 0x00402293 File Offset: 0x00400493
		// (set) Token: 0x0601C5D1 RID: 116177 RVA: 0x0040229B File Offset: 0x0040049B
		public ERollBlockGridType GridType { get; set; }

		// Token: 0x170084AF RID: 33967
		// (get) Token: 0x0601C5D2 RID: 116178 RVA: 0x004022A4 File Offset: 0x004004A4
		// (set) Token: 0x0601C5D3 RID: 116179 RVA: 0x004022AC File Offset: 0x004004AC
		public string TemplateId { get; set; }

		// Token: 0x0601C5D4 RID: 116180 RVA: 0x004022B5 File Offset: 0x004004B5
		public IRollBlockGridTemplateT()
		{
			this.GridType = ERollBlockGridType.Empty;
			this.TemplateId = null;
		}
	}
}

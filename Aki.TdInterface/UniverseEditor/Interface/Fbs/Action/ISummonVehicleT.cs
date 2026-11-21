using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A0E RID: 31246
	public class ISummonVehicleT
	{
		// Token: 0x1700E4F7 RID: 58615
		// (get) Token: 0x060370DA RID: 225498 RVA: 0x0075B9CD File Offset: 0x00759BCD
		// (set) Token: 0x060370DB RID: 225499 RVA: 0x0075B9D5 File Offset: 0x00759BD5
		public ESummonEntityType Type { get; set; }

		// Token: 0x1700E4F8 RID: 58616
		// (get) Token: 0x060370DC RID: 225500 RVA: 0x0075B9DE File Offset: 0x00759BDE
		// (set) Token: 0x060370DD RID: 225501 RVA: 0x0075B9E6 File Offset: 0x00759BE6
		public string TemplateId { get; set; }

		// Token: 0x1700E4F9 RID: 58617
		// (get) Token: 0x060370DE RID: 225502 RVA: 0x0075B9EF File Offset: 0x00759BEF
		// (set) Token: 0x060370DF RID: 225503 RVA: 0x0075B9F7 File Offset: 0x00759BF7
		public int PositionEntityId { get; set; }

		// Token: 0x060370E0 RID: 225504 RVA: 0x0075BA00 File Offset: 0x00759C00
		public ISummonVehicleT()
		{
			this.Type = ESummonEntityType.Vehicle;
			this.TemplateId = null;
			this.PositionEntityId = 0;
		}
	}
}

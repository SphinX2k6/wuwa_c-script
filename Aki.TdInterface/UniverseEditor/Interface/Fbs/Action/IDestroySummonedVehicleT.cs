using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C12 RID: 27666
	public class IDestroySummonedVehicleT
	{
		// Token: 0x1700CAD0 RID: 51920
		// (get) Token: 0x0602F9DF RID: 195039 RVA: 0x0067D16B File Offset: 0x0067B36B
		// (set) Token: 0x0602F9E0 RID: 195040 RVA: 0x0067D173 File Offset: 0x0067B373
		public ESummonEntityType Type { get; set; }

		// Token: 0x1700CAD1 RID: 51921
		// (get) Token: 0x0602F9E1 RID: 195041 RVA: 0x0067D17C File Offset: 0x0067B37C
		// (set) Token: 0x0602F9E2 RID: 195042 RVA: 0x0067D184 File Offset: 0x0067B384
		public string TemplateId { get; set; }

		// Token: 0x0602F9E3 RID: 195043 RVA: 0x0067D18D File Offset: 0x0067B38D
		public IDestroySummonedVehicleT()
		{
			this.Type = ESummonEntityType.Vehicle;
			this.TemplateId = null;
		}
	}
}

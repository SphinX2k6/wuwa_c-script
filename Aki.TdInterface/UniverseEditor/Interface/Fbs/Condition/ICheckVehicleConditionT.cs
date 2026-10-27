using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B69 RID: 19305
	public class ICheckVehicleConditionT
	{
		// Token: 0x17008C18 RID: 35864
		// (get) Token: 0x0601E6B1 RID: 124593 RVA: 0x00442BC7 File Offset: 0x00440DC7
		// (set) Token: 0x0601E6B2 RID: 124594 RVA: 0x00442BCF File Offset: 0x00440DCF
		public ECondition Type { get; set; }

		// Token: 0x17008C19 RID: 35865
		// (get) Token: 0x0601E6B3 RID: 124595 RVA: 0x00442BD8 File Offset: 0x00440DD8
		// (set) Token: 0x0601E6B4 RID: 124596 RVA: 0x00442BE0 File Offset: 0x00440DE0
		public TVehicleConditionUnion Condition { get; set; }

		// Token: 0x0601E6B5 RID: 124597 RVA: 0x00442BE9 File Offset: 0x00440DE9
		public ICheckVehicleConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Condition = null;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005209 RID: 21001
	public class IVehicleConditionT
	{
		// Token: 0x1700964C RID: 38476
		// (get) Token: 0x06021137 RID: 135479 RVA: 0x00491D72 File Offset: 0x0048FF72
		// (set) Token: 0x06021138 RID: 135480 RVA: 0x00491D7A File Offset: 0x0048FF7A
		public EVehicleConditionType Type { get; set; }

		// Token: 0x06021139 RID: 135481 RVA: 0x00491D83 File Offset: 0x0048FF83
		public IVehicleConditionT()
		{
			this.Type = EVehicleConditionType.UsingVehicle;
		}
	}
}

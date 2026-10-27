using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D0D RID: 19725
	public class IVehicleConditionT
	{
		// Token: 0x17008F13 RID: 36627
		// (get) Token: 0x0601F4F2 RID: 128242 RVA: 0x0045DE22 File Offset: 0x0045C022
		// (set) Token: 0x0601F4F3 RID: 128243 RVA: 0x0045DE2A File Offset: 0x0045C02A
		public EVehicleConditionType Type { get; set; }

		// Token: 0x0601F4F4 RID: 128244 RVA: 0x0045DE33 File Offset: 0x0045C033
		public IVehicleConditionT()
		{
			this.Type = EVehicleConditionType.UsingVehicle;
		}
	}
}

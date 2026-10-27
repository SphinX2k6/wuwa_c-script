using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F5B RID: 28507
	public class ISelfVehicleT
	{
		// Token: 0x1700D3CD RID: 54221
		// (get) Token: 0x060325CB RID: 206283 RVA: 0x006CCA9A File Offset: 0x006CAC9A
		// (set) Token: 0x060325CC RID: 206284 RVA: 0x006CCAA2 File Offset: 0x006CACA2
		public ETargetVehicle Type { get; set; }

		// Token: 0x060325CD RID: 206285 RVA: 0x006CCAAB File Offset: 0x006CACAB
		public ISelfVehicleT()
		{
			this.Type = ETargetVehicle.Current;
		}
	}
}

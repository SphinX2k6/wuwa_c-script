using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067C6 RID: 26566
	public class IFishingBoatVehicleT
	{
		// Token: 0x1700C534 RID: 50484
		// (get) Token: 0x0602E3ED RID: 189421 RVA: 0x00650C8E File Offset: 0x0064EE8E
		// (set) Token: 0x0602E3EE RID: 189422 RVA: 0x00650C96 File Offset: 0x0064EE96
		public ETargetVehicle Type { get; set; }

		// Token: 0x0602E3EF RID: 189423 RVA: 0x00650C9F File Offset: 0x0064EE9F
		public IFishingBoatVehicleT()
		{
			this.Type = ETargetVehicle.Current;
		}
	}
}

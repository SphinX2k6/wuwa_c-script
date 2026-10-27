using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064F0 RID: 25840
	public class ICurrentVehicleT
	{
		// Token: 0x1700C035 RID: 49205
		// (get) Token: 0x0602CD39 RID: 183609 RVA: 0x00628C06 File Offset: 0x00626E06
		// (set) Token: 0x0602CD3A RID: 183610 RVA: 0x00628C0E File Offset: 0x00626E0E
		public ETargetVehicle Type { get; set; }

		// Token: 0x0602CD3B RID: 183611 RVA: 0x00628C17 File Offset: 0x00626E17
		public ICurrentVehicleT()
		{
			this.Type = ETargetVehicle.Current;
		}
	}
}

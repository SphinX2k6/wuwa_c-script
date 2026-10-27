using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200747F RID: 29823
	public class ITriggeredVehicleT
	{
		// Token: 0x1700E269 RID: 57961
		// (get) Token: 0x06036326 RID: 221990 RVA: 0x0075E546 File Offset: 0x0075C746
		// (set) Token: 0x06036327 RID: 221991 RVA: 0x0075E54E File Offset: 0x0075C74E
		public ETargetVehicle Type { get; set; }

		// Token: 0x06036328 RID: 221992 RVA: 0x0075E557 File Offset: 0x0075C757
		public ITriggeredVehicleT()
		{
			this.Type = ETargetVehicle.Current;
		}
	}
}

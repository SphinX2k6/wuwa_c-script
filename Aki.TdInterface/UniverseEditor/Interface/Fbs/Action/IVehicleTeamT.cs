using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D2C RID: 32044
	public class IVehicleTeamT
	{
		// Token: 0x1700EFDD RID: 61405
		// (get) Token: 0x06039DA2 RID: 236962 RVA: 0x007CE2B0 File Offset: 0x007CC4B0
		// (set) Token: 0x06039DA3 RID: 236963 RVA: 0x007CE2B8 File Offset: 0x007CC4B8
		public ETargetVehicle Type { get; set; }

		// Token: 0x1700EFDE RID: 61406
		// (get) Token: 0x06039DA4 RID: 236964 RVA: 0x007CE2C1 File Offset: 0x007CC4C1
		// (set) Token: 0x06039DA5 RID: 236965 RVA: 0x007CE2C9 File Offset: 0x007CC4C9
		public int TeamId { get; set; }

		// Token: 0x06039DA6 RID: 236966 RVA: 0x007CE2D2 File Offset: 0x007CC4D2
		public IVehicleTeamT()
		{
			this.Type = ETargetVehicle.Current;
			this.TeamId = 0;
		}
	}
}

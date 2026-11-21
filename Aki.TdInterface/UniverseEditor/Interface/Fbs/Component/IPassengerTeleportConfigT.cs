using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C61 RID: 23649
	public class IPassengerTeleportConfigT
	{
		// Token: 0x1700ADD7 RID: 44503
		// (get) Token: 0x060273CF RID: 160719 RVA: 0x0056020D File Offset: 0x0055E40D
		// (set) Token: 0x060273D0 RID: 160720 RVA: 0x00560215 File Offset: 0x0055E415
		public IPosAT PosA { get; set; }

		// Token: 0x060273D1 RID: 160721 RVA: 0x0056021E File Offset: 0x0055E41E
		public IPassengerTeleportConfigT()
		{
			this.PosA = null;
		}
	}
}

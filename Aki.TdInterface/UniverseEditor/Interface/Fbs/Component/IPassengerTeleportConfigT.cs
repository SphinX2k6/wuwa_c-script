using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056BD RID: 22205
	public class IPassengerTeleportConfigT
	{
		// Token: 0x1700A543 RID: 42307
		// (get) Token: 0x0602517A RID: 151930 RVA: 0x0051F2C5 File Offset: 0x0051D4C5
		// (set) Token: 0x0602517B RID: 151931 RVA: 0x0051F2CD File Offset: 0x0051D4CD
		public IPosAT PosA { get; set; }

		// Token: 0x0602517C RID: 151932 RVA: 0x0051F2D6 File Offset: 0x0051D4D6
		public IPassengerTeleportConfigT()
		{
			this.PosA = null;
		}
	}
}

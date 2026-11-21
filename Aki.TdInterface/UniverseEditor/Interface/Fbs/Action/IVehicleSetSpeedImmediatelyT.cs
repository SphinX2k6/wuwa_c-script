using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D26 RID: 32038
	public class IVehicleSetSpeedImmediatelyT
	{
		// Token: 0x1700EFD6 RID: 61398
		// (get) Token: 0x06039D73 RID: 236915 RVA: 0x007CDBE9 File Offset: 0x007CBDE9
		// (set) Token: 0x06039D74 RID: 236916 RVA: 0x007CDBF1 File Offset: 0x007CBDF1
		public TVehicleSetSpeedImmediatelyUnion SetSpeedConfig { get; set; }

		// Token: 0x06039D75 RID: 236917 RVA: 0x007CDBFA File Offset: 0x007CBDFA
		public IVehicleSetSpeedImmediatelyT()
		{
			this.SetSpeedConfig = null;
		}
	}
}

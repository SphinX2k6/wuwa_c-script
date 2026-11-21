using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200786A RID: 30826
	public class ISetTotalVehicleSpeedImmediatelyT
	{
		// Token: 0x1700E215 RID: 57877
		// (get) Token: 0x06036371 RID: 222065 RVA: 0x007431AB File Offset: 0x007413AB
		// (set) Token: 0x06036372 RID: 222066 RVA: 0x007431B3 File Offset: 0x007413B3
		public ESetVehicleSpeedImmediatelyType Type { get; set; }

		// Token: 0x1700E216 RID: 57878
		// (get) Token: 0x06036373 RID: 222067 RVA: 0x007431BC File Offset: 0x007413BC
		// (set) Token: 0x06036374 RID: 222068 RVA: 0x007431C4 File Offset: 0x007413C4
		public TProcessedValueUnion Speed { get; set; }

		// Token: 0x06036375 RID: 222069 RVA: 0x007431CD File Offset: 0x007413CD
		public ISetTotalVehicleSpeedImmediatelyT()
		{
			this.Type = ESetVehicleSpeedImmediatelyType.TotalSpeed;
			this.Speed = null;
		}
	}
}

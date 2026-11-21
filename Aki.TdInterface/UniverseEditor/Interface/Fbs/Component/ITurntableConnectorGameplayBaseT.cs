using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006104 RID: 24836
	public class ITurntableConnectorGameplayBaseT
	{
		// Token: 0x1700B8EA RID: 47338
		// (get) Token: 0x0602A1A0 RID: 172448 RVA: 0x005BF29E File Offset: 0x005BD49E
		// (set) Token: 0x0602A1A1 RID: 172449 RVA: 0x005BF2A6 File Offset: 0x005BD4A6
		public ETurntableConnectorGameplayType Type { get; set; }

		// Token: 0x0602A1A2 RID: 172450 RVA: 0x005BF2AF File Offset: 0x005BD4AF
		public ITurntableConnectorGameplayBaseT()
		{
			this.Type = ETurntableConnectorGameplayType.CircuitConnect;
		}
	}
}

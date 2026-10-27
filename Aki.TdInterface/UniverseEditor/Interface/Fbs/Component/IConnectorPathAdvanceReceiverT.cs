using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005010 RID: 20496
	public class IConnectorPathAdvanceReceiverT
	{
		// Token: 0x17009493 RID: 38035
		// (get) Token: 0x06020CB1 RID: 134321 RVA: 0x0048F3BA File Offset: 0x0048D5BA
		// (set) Token: 0x06020CB2 RID: 134322 RVA: 0x0048F3C2 File Offset: 0x0048D5C2
		public string ConnectedState { get; set; }

		// Token: 0x17009494 RID: 38036
		// (get) Token: 0x06020CB3 RID: 134323 RVA: 0x0048F3CB File Offset: 0x0048D5CB
		// (set) Token: 0x06020CB4 RID: 134324 RVA: 0x0048F3D3 File Offset: 0x0048D5D3
		public string DisconnectedState { get; set; }

		// Token: 0x06020CB5 RID: 134325 RVA: 0x0048F3DC File Offset: 0x0048D5DC
		public IConnectorPathAdvanceReceiverT()
		{
			this.ConnectedState = null;
			this.DisconnectedState = null;
		}
	}
}

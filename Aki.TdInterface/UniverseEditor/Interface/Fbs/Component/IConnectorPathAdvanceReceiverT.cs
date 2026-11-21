using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200556F RID: 21871
	public class IConnectorPathAdvanceReceiverT
	{
		// Token: 0x17009C74 RID: 40052
		// (get) Token: 0x06022BD1 RID: 142289 RVA: 0x004C8E0A File Offset: 0x004C700A
		// (set) Token: 0x06022BD2 RID: 142290 RVA: 0x004C8E12 File Offset: 0x004C7012
		public string ConnectedState { get; set; }

		// Token: 0x17009C75 RID: 40053
		// (get) Token: 0x06022BD3 RID: 142291 RVA: 0x004C8E1B File Offset: 0x004C701B
		// (set) Token: 0x06022BD4 RID: 142292 RVA: 0x004C8E23 File Offset: 0x004C7023
		public string DisconnectedState { get; set; }

		// Token: 0x06022BD5 RID: 142293 RVA: 0x004C8E2C File Offset: 0x004C702C
		public IConnectorPathAdvanceReceiverT()
		{
			this.ConnectedState = null;
			this.DisconnectedState = null;
		}
	}
}

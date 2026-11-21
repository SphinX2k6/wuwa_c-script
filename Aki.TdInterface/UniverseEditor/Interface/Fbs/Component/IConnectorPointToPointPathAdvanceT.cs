using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200557B RID: 21883
	public class IConnectorPointToPointPathAdvanceT
	{
		// Token: 0x17009C8F RID: 40079
		// (get) Token: 0x06022C39 RID: 142393 RVA: 0x004C9ABC File Offset: 0x004C7CBC
		// (set) Token: 0x06022C3A RID: 142394 RVA: 0x004C9AC4 File Offset: 0x004C7CC4
		public EConnectorLogicType Type { get; set; }

		// Token: 0x17009C90 RID: 40080
		// (get) Token: 0x06022C3B RID: 142395 RVA: 0x004C9ACD File Offset: 0x004C7CCD
		// (set) Token: 0x06022C3C RID: 142396 RVA: 0x004C9AD5 File Offset: 0x004C7CD5
		public IConnectorEffectConfigT EffectConfig { get; set; }

		// Token: 0x17009C91 RID: 40081
		// (get) Token: 0x06022C3D RID: 142397 RVA: 0x004C9ADE File Offset: 0x004C7CDE
		// (set) Token: 0x06022C3E RID: 142398 RVA: 0x004C9AE6 File Offset: 0x004C7CE6
		public IConnectorPathAdvanceInitiatorT Initiator { get; set; }

		// Token: 0x17009C92 RID: 40082
		// (get) Token: 0x06022C3F RID: 142399 RVA: 0x004C9AEF File Offset: 0x004C7CEF
		// (set) Token: 0x06022C40 RID: 142400 RVA: 0x004C9AF7 File Offset: 0x004C7CF7
		public IConnectorPathAdvanceReceiverT Receiver { get; set; }

		// Token: 0x06022C41 RID: 142401 RVA: 0x004C9B00 File Offset: 0x004C7D00
		public IConnectorPointToPointPathAdvanceT()
		{
			this.Type = EConnectorLogicType.Range;
			this.EffectConfig = null;
			this.Initiator = null;
			this.Receiver = null;
		}
	}
}

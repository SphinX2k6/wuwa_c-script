using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200501C RID: 20508
	public class IConnectorPointToPointPathAdvanceT
	{
		// Token: 0x170094AE RID: 38062
		// (get) Token: 0x06020D19 RID: 134425 RVA: 0x0049006C File Offset: 0x0048E26C
		// (set) Token: 0x06020D1A RID: 134426 RVA: 0x00490074 File Offset: 0x0048E274
		public EConnectorLogicType Type { get; set; }

		// Token: 0x170094AF RID: 38063
		// (get) Token: 0x06020D1B RID: 134427 RVA: 0x0049007D File Offset: 0x0048E27D
		// (set) Token: 0x06020D1C RID: 134428 RVA: 0x00490085 File Offset: 0x0048E285
		public IConnectorEffectConfigT EffectConfig { get; set; }

		// Token: 0x170094B0 RID: 38064
		// (get) Token: 0x06020D1D RID: 134429 RVA: 0x0049008E File Offset: 0x0048E28E
		// (set) Token: 0x06020D1E RID: 134430 RVA: 0x00490096 File Offset: 0x0048E296
		public IConnectorPathAdvanceInitiatorT Initiator { get; set; }

		// Token: 0x170094B1 RID: 38065
		// (get) Token: 0x06020D1F RID: 134431 RVA: 0x0049009F File Offset: 0x0048E29F
		// (set) Token: 0x06020D20 RID: 134432 RVA: 0x004900A7 File Offset: 0x0048E2A7
		public IConnectorPathAdvanceReceiverT Receiver { get; set; }

		// Token: 0x06020D21 RID: 134433 RVA: 0x004900B0 File Offset: 0x0048E2B0
		public IConnectorPointToPointPathAdvanceT()
		{
			this.Type = EConnectorLogicType.Range;
			this.EffectConfig = null;
			this.Initiator = null;
			this.Receiver = null;
		}
	}
}

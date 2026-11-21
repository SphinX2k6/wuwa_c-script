using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200557E RID: 21886
	public class IConnectorRangeT
	{
		// Token: 0x17009C9E RID: 40094
		// (get) Token: 0x06022C75 RID: 142453 RVA: 0x004CA4CF File Offset: 0x004C86CF
		// (set) Token: 0x06022C76 RID: 142454 RVA: 0x004CA4D7 File Offset: 0x004C86D7
		public EConnectorLogicType Type { get; set; }

		// Token: 0x17009C9F RID: 40095
		// (get) Token: 0x06022C77 RID: 142455 RVA: 0x004CA4E0 File Offset: 0x004C86E0
		// (set) Token: 0x06022C78 RID: 142456 RVA: 0x004CA4E8 File Offset: 0x004C86E8
		public IConnectorEffectConfigT EffectConfig { get; set; }

		// Token: 0x17009CA0 RID: 40096
		// (get) Token: 0x06022C79 RID: 142457 RVA: 0x004CA4F1 File Offset: 0x004C86F1
		// (set) Token: 0x06022C7A RID: 142458 RVA: 0x004CA4F9 File Offset: 0x004C86F9
		public string ActiveState { get; set; }

		// Token: 0x17009CA1 RID: 40097
		// (get) Token: 0x06022C7B RID: 142459 RVA: 0x004CA502 File Offset: 0x004C8702
		// (set) Token: 0x06022C7C RID: 142460 RVA: 0x004CA50A File Offset: 0x004C870A
		public int EnterRange { get; set; }

		// Token: 0x17009CA2 RID: 40098
		// (get) Token: 0x06022C7D RID: 142461 RVA: 0x004CA513 File Offset: 0x004C8713
		// (set) Token: 0x06022C7E RID: 142462 RVA: 0x004CA51B File Offset: 0x004C871B
		public int LeaveRange { get; set; }

		// Token: 0x17009CA3 RID: 40099
		// (get) Token: 0x06022C7F RID: 142463 RVA: 0x004CA524 File Offset: 0x004C8724
		// (set) Token: 0x06022C80 RID: 142464 RVA: 0x004CA52C File Offset: 0x004C872C
		public List<IDynamicEntityMatchT> MatchConditions { get; set; }

		// Token: 0x17009CA4 RID: 40100
		// (get) Token: 0x06022C81 RID: 142465 RVA: 0x004CA535 File Offset: 0x004C8735
		// (set) Token: 0x06022C82 RID: 142466 RVA: 0x004CA53D File Offset: 0x004C873D
		public List<IDynamicEntityMatchT> KeepConditions { get; set; }

		// Token: 0x17009CA5 RID: 40101
		// (get) Token: 0x06022C83 RID: 142467 RVA: 0x004CA546 File Offset: 0x004C8746
		// (set) Token: 0x06022C84 RID: 142468 RVA: 0x004CA54E File Offset: 0x004C874E
		public string ConnectedState { get; set; }

		// Token: 0x17009CA6 RID: 40102
		// (get) Token: 0x06022C85 RID: 142469 RVA: 0x004CA557 File Offset: 0x004C8757
		// (set) Token: 0x06022C86 RID: 142470 RVA: 0x004CA55F File Offset: 0x004C875F
		public string DisconnectedState { get; set; }

		// Token: 0x17009CA7 RID: 40103
		// (get) Token: 0x06022C87 RID: 142471 RVA: 0x004CA568 File Offset: 0x004C8768
		// (set) Token: 0x06022C88 RID: 142472 RVA: 0x004CA570 File Offset: 0x004C8770
		public byte NullMask { get; set; }

		// Token: 0x06022C89 RID: 142473 RVA: 0x004CA57C File Offset: 0x004C877C
		public IConnectorRangeT()
		{
			this.Type = EConnectorLogicType.Range;
			this.EffectConfig = null;
			this.ActiveState = null;
			this.EnterRange = 0;
			this.LeaveRange = 0;
			this.MatchConditions = null;
			this.KeepConditions = null;
			this.ConnectedState = null;
			this.DisconnectedState = null;
			this.NullMask = 0;
		}
	}
}

using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200439B RID: 17307
	public class INightmareSettlementSystemConfigT
	{
		// Token: 0x170076BE RID: 30398
		// (get) Token: 0x0601878A RID: 100234 RVA: 0x0037CB9F File Offset: 0x0037AD9F
		// (set) Token: 0x0601878B RID: 100235 RVA: 0x0037CBA7 File Offset: 0x0037ADA7
		public EEnableSystemType Type { get; set; }

		// Token: 0x170076BF RID: 30399
		// (get) Token: 0x0601878C RID: 100236 RVA: 0x0037CBB0 File Offset: 0x0037ADB0
		// (set) Token: 0x0601878D RID: 100237 RVA: 0x0037CBB8 File Offset: 0x0037ADB8
		public List<INightmareSettlementSystemVarT> SystemVars { get; set; }

		// Token: 0x0601878E RID: 100238 RVA: 0x0037CBC1 File Offset: 0x0037ADC1
		public INightmareSettlementSystemConfigT()
		{
			this.Type = EEnableSystemType.GradingSystem;
			this.SystemVars = null;
		}
	}
}

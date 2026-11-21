using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077BF RID: 30655
	public class ISetGlobalTimeScaleT
	{
		// Token: 0x1700E0C1 RID: 57537
		// (get) Token: 0x06035D9E RID: 220574 RVA: 0x0073728F File Offset: 0x0073548F
		// (set) Token: 0x06035D9F RID: 220575 RVA: 0x00737297 File Offset: 0x00735497
		public ETimeScaleType Type { get; set; }

		// Token: 0x1700E0C2 RID: 57538
		// (get) Token: 0x06035DA0 RID: 220576 RVA: 0x007372A0 File Offset: 0x007354A0
		// (set) Token: 0x06035DA1 RID: 220577 RVA: 0x007372A8 File Offset: 0x007354A8
		public TSetGlobalTimeScaleUnion Config { get; set; }

		// Token: 0x06035DA2 RID: 220578 RVA: 0x007372B1 File Offset: 0x007354B1
		public ISetGlobalTimeScaleT()
		{
			this.Type = ETimeScaleType.Global;
			this.Config = null;
		}
	}
}

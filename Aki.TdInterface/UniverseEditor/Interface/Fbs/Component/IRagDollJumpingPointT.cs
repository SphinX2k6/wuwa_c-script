using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DE3 RID: 24035
	public class IRagDollJumpingPointT
	{
		// Token: 0x1700B11F RID: 45343
		// (get) Token: 0x060281B2 RID: 164274 RVA: 0x0057C504 File Offset: 0x0057A704
		// (set) Token: 0x060281B3 RID: 164275 RVA: 0x0057C50C File Offset: 0x0057A70C
		public EHookInteractType Type { get; set; }

		// Token: 0x1700B120 RID: 45344
		// (get) Token: 0x060281B4 RID: 164276 RVA: 0x0057C515 File Offset: 0x0057A715
		// (set) Token: 0x060281B5 RID: 164277 RVA: 0x0057C51D File Offset: 0x0057A71D
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700B121 RID: 45345
		// (get) Token: 0x060281B6 RID: 164278 RVA: 0x0057C526 File Offset: 0x0057A726
		// (set) Token: 0x060281B7 RID: 164279 RVA: 0x0057C52E File Offset: 0x0057A72E
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700B122 RID: 45346
		// (get) Token: 0x060281B8 RID: 164280 RVA: 0x0057C537 File Offset: 0x0057A737
		// (set) Token: 0x060281B9 RID: 164281 RVA: 0x0057C53F File Offset: 0x0057A73F
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700B123 RID: 45347
		// (get) Token: 0x060281BA RID: 164282 RVA: 0x0057C548 File Offset: 0x0057A748
		// (set) Token: 0x060281BB RID: 164283 RVA: 0x0057C550 File Offset: 0x0057A750
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700B124 RID: 45348
		// (get) Token: 0x060281BC RID: 164284 RVA: 0x0057C559 File Offset: 0x0057A759
		// (set) Token: 0x060281BD RID: 164285 RVA: 0x0057C561 File Offset: 0x0057A761
		public byte NullMask { get; set; }

		// Token: 0x060281BE RID: 164286 RVA: 0x0057C56A File Offset: 0x0057A76A
		public IRagDollJumpingPointT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.NullMask = 0;
		}
	}
}

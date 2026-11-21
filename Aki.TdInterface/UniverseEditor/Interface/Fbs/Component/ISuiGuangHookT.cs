using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FFD RID: 24573
	public class ISuiGuangHookT
	{
		// Token: 0x1700B630 RID: 46640
		// (get) Token: 0x06029698 RID: 169624 RVA: 0x005A71B0 File Offset: 0x005A53B0
		// (set) Token: 0x06029699 RID: 169625 RVA: 0x005A71B8 File Offset: 0x005A53B8
		public EHookInteractType Type { get; set; }

		// Token: 0x1700B631 RID: 46641
		// (get) Token: 0x0602969A RID: 169626 RVA: 0x005A71C1 File Offset: 0x005A53C1
		// (set) Token: 0x0602969B RID: 169627 RVA: 0x005A71C9 File Offset: 0x005A53C9
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700B632 RID: 46642
		// (get) Token: 0x0602969C RID: 169628 RVA: 0x005A71D2 File Offset: 0x005A53D2
		// (set) Token: 0x0602969D RID: 169629 RVA: 0x005A71DA File Offset: 0x005A53DA
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700B633 RID: 46643
		// (get) Token: 0x0602969E RID: 169630 RVA: 0x005A71E3 File Offset: 0x005A53E3
		// (set) Token: 0x0602969F RID: 169631 RVA: 0x005A71EB File Offset: 0x005A53EB
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700B634 RID: 46644
		// (get) Token: 0x060296A0 RID: 169632 RVA: 0x005A71F4 File Offset: 0x005A53F4
		// (set) Token: 0x060296A1 RID: 169633 RVA: 0x005A71FC File Offset: 0x005A53FC
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700B635 RID: 46645
		// (get) Token: 0x060296A2 RID: 169634 RVA: 0x005A7205 File Offset: 0x005A5405
		// (set) Token: 0x060296A3 RID: 169635 RVA: 0x005A720D File Offset: 0x005A540D
		public byte NullMask { get; set; }

		// Token: 0x060296A4 RID: 169636 RVA: 0x005A7216 File Offset: 0x005A5416
		public ISuiGuangHookT()
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

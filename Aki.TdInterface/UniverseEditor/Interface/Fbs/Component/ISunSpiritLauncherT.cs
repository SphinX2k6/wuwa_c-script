using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006015 RID: 24597
	public class ISunSpiritLauncherT
	{
		// Token: 0x1700B663 RID: 46691
		// (get) Token: 0x06029772 RID: 169842 RVA: 0x005A8DA4 File Offset: 0x005A6FA4
		// (set) Token: 0x06029773 RID: 169843 RVA: 0x005A8DAC File Offset: 0x005A6FAC
		public EHookInteractType Type { get; set; }

		// Token: 0x1700B664 RID: 46692
		// (get) Token: 0x06029774 RID: 169844 RVA: 0x005A8DB5 File Offset: 0x005A6FB5
		// (set) Token: 0x06029775 RID: 169845 RVA: 0x005A8DBD File Offset: 0x005A6FBD
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700B665 RID: 46693
		// (get) Token: 0x06029776 RID: 169846 RVA: 0x005A8DC6 File Offset: 0x005A6FC6
		// (set) Token: 0x06029777 RID: 169847 RVA: 0x005A8DCE File Offset: 0x005A6FCE
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700B666 RID: 46694
		// (get) Token: 0x06029778 RID: 169848 RVA: 0x005A8DD7 File Offset: 0x005A6FD7
		// (set) Token: 0x06029779 RID: 169849 RVA: 0x005A8DDF File Offset: 0x005A6FDF
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700B667 RID: 46695
		// (get) Token: 0x0602977A RID: 169850 RVA: 0x005A8DE8 File Offset: 0x005A6FE8
		// (set) Token: 0x0602977B RID: 169851 RVA: 0x005A8DF0 File Offset: 0x005A6FF0
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700B668 RID: 46696
		// (get) Token: 0x0602977C RID: 169852 RVA: 0x005A8DF9 File Offset: 0x005A6FF9
		// (set) Token: 0x0602977D RID: 169853 RVA: 0x005A8E01 File Offset: 0x005A7001
		public byte NullMask { get; set; }

		// Token: 0x0602977E RID: 169854 RVA: 0x005A8E0A File Offset: 0x005A700A
		public ISunSpiritLauncherT()
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

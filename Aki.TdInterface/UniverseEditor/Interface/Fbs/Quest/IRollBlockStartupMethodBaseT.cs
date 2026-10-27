using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040F2 RID: 16626
	public class IRollBlockStartupMethodBaseT
	{
		// Token: 0x1700752F RID: 29999
		// (get) Token: 0x060183B9 RID: 99257 RVA: 0x0037D156 File Offset: 0x0037B356
		// (set) Token: 0x060183BA RID: 99258 RVA: 0x0037D15E File Offset: 0x0037B35E
		public ERollBlockLaunchMethod Type { get; set; }

		// Token: 0x060183BB RID: 99259 RVA: 0x0037D167 File Offset: 0x0037B367
		public IRollBlockStartupMethodBaseT()
		{
			this.Type = ERollBlockLaunchMethod.Interact;
		}
	}
}

using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005274 RID: 21108
	public class IFixedPointHookT
	{
		// Token: 0x17009AAE RID: 39598
		// (get) Token: 0x060225BF RID: 140735 RVA: 0x004C369C File Offset: 0x004C189C
		// (set) Token: 0x060225C0 RID: 140736 RVA: 0x004C36A4 File Offset: 0x004C18A4
		public EHookInteractType Type { get; set; }

		// Token: 0x17009AAF RID: 39599
		// (get) Token: 0x060225C1 RID: 140737 RVA: 0x004C36AD File Offset: 0x004C18AD
		// (set) Token: 0x060225C2 RID: 140738 RVA: 0x004C36B5 File Offset: 0x004C18B5
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x17009AB0 RID: 39600
		// (get) Token: 0x060225C3 RID: 140739 RVA: 0x004C36BE File Offset: 0x004C18BE
		// (set) Token: 0x060225C4 RID: 140740 RVA: 0x004C36C6 File Offset: 0x004C18C6
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x17009AB1 RID: 39601
		// (get) Token: 0x060225C5 RID: 140741 RVA: 0x004C36CF File Offset: 0x004C18CF
		// (set) Token: 0x060225C6 RID: 140742 RVA: 0x004C36D7 File Offset: 0x004C18D7
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x17009AB2 RID: 39602
		// (get) Token: 0x060225C7 RID: 140743 RVA: 0x004C36E0 File Offset: 0x004C18E0
		// (set) Token: 0x060225C8 RID: 140744 RVA: 0x004C36E8 File Offset: 0x004C18E8
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x17009AB3 RID: 39603
		// (get) Token: 0x060225C9 RID: 140745 RVA: 0x004C36F1 File Offset: 0x004C18F1
		// (set) Token: 0x060225CA RID: 140746 RVA: 0x004C36F9 File Offset: 0x004C18F9
		public byte NullMask { get; set; }

		// Token: 0x060225CB RID: 140747 RVA: 0x004C3702 File Offset: 0x004C1902
		public IFixedPointHookT()
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

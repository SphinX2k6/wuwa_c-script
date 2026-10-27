using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057DC RID: 22492
	public class IRagDollJumpingPointT
	{
		// Token: 0x1700A7FB RID: 43003
		// (get) Token: 0x06025C92 RID: 154770 RVA: 0x00536378 File Offset: 0x00534578
		// (set) Token: 0x06025C93 RID: 154771 RVA: 0x00536380 File Offset: 0x00534580
		public EHookInteractType Type { get; set; }

		// Token: 0x1700A7FC RID: 43004
		// (get) Token: 0x06025C94 RID: 154772 RVA: 0x00536389 File Offset: 0x00534589
		// (set) Token: 0x06025C95 RID: 154773 RVA: 0x00536391 File Offset: 0x00534591
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700A7FD RID: 43005
		// (get) Token: 0x06025C96 RID: 154774 RVA: 0x0053639A File Offset: 0x0053459A
		// (set) Token: 0x06025C97 RID: 154775 RVA: 0x005363A2 File Offset: 0x005345A2
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700A7FE RID: 43006
		// (get) Token: 0x06025C98 RID: 154776 RVA: 0x005363AB File Offset: 0x005345AB
		// (set) Token: 0x06025C99 RID: 154777 RVA: 0x005363B3 File Offset: 0x005345B3
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700A7FF RID: 43007
		// (get) Token: 0x06025C9A RID: 154778 RVA: 0x005363BC File Offset: 0x005345BC
		// (set) Token: 0x06025C9B RID: 154779 RVA: 0x005363C4 File Offset: 0x005345C4
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700A800 RID: 43008
		// (get) Token: 0x06025C9C RID: 154780 RVA: 0x005363CD File Offset: 0x005345CD
		// (set) Token: 0x06025C9D RID: 154781 RVA: 0x005363D5 File Offset: 0x005345D5
		public byte NullMask { get; set; }

		// Token: 0x06025C9E RID: 154782 RVA: 0x005363DE File Offset: 0x005345DE
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

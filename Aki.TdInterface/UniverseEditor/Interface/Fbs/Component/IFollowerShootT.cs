using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005298 RID: 21144
	public class IFollowerShootT
	{
		// Token: 0x17009B09 RID: 39689
		// (get) Token: 0x06022768 RID: 141160 RVA: 0x004C73C4 File Offset: 0x004C55C4
		// (set) Token: 0x06022769 RID: 141161 RVA: 0x004C73CC File Offset: 0x004C55CC
		public EHookInteractType Type { get; set; }

		// Token: 0x17009B0A RID: 39690
		// (get) Token: 0x0602276A RID: 141162 RVA: 0x004C73D5 File Offset: 0x004C55D5
		// (set) Token: 0x0602276B RID: 141163 RVA: 0x004C73DD File Offset: 0x004C55DD
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x17009B0B RID: 39691
		// (get) Token: 0x0602276C RID: 141164 RVA: 0x004C73E6 File Offset: 0x004C55E6
		// (set) Token: 0x0602276D RID: 141165 RVA: 0x004C73EE File Offset: 0x004C55EE
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x17009B0C RID: 39692
		// (get) Token: 0x0602276E RID: 141166 RVA: 0x004C73F7 File Offset: 0x004C55F7
		// (set) Token: 0x0602276F RID: 141167 RVA: 0x004C73FF File Offset: 0x004C55FF
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x17009B0D RID: 39693
		// (get) Token: 0x06022770 RID: 141168 RVA: 0x004C7408 File Offset: 0x004C5608
		// (set) Token: 0x06022771 RID: 141169 RVA: 0x004C7410 File Offset: 0x004C5610
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x17009B0E RID: 39694
		// (get) Token: 0x06022772 RID: 141170 RVA: 0x004C7419 File Offset: 0x004C5619
		// (set) Token: 0x06022773 RID: 141171 RVA: 0x004C7421 File Offset: 0x004C5621
		public byte NullMask { get; set; }

		// Token: 0x06022774 RID: 141172 RVA: 0x004C742A File Offset: 0x004C562A
		public IFollowerShootT()
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

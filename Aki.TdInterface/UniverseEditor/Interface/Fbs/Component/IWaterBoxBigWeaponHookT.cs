using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006164 RID: 24932
	public class IWaterBoxBigWeaponHookT
	{
		// Token: 0x1700B9CA RID: 47562
		// (get) Token: 0x0602A561 RID: 173409 RVA: 0x005C6D40 File Offset: 0x005C4F40
		// (set) Token: 0x0602A562 RID: 173410 RVA: 0x005C6D48 File Offset: 0x005C4F48
		public EHookInteractType Type { get; set; }

		// Token: 0x1700B9CB RID: 47563
		// (get) Token: 0x0602A563 RID: 173411 RVA: 0x005C6D51 File Offset: 0x005C4F51
		// (set) Token: 0x0602A564 RID: 173412 RVA: 0x005C6D59 File Offset: 0x005C4F59
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700B9CC RID: 47564
		// (get) Token: 0x0602A565 RID: 173413 RVA: 0x005C6D62 File Offset: 0x005C4F62
		// (set) Token: 0x0602A566 RID: 173414 RVA: 0x005C6D6A File Offset: 0x005C4F6A
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700B9CD RID: 47565
		// (get) Token: 0x0602A567 RID: 173415 RVA: 0x005C6D73 File Offset: 0x005C4F73
		// (set) Token: 0x0602A568 RID: 173416 RVA: 0x005C6D7B File Offset: 0x005C4F7B
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700B9CE RID: 47566
		// (get) Token: 0x0602A569 RID: 173417 RVA: 0x005C6D84 File Offset: 0x005C4F84
		// (set) Token: 0x0602A56A RID: 173418 RVA: 0x005C6D8C File Offset: 0x005C4F8C
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700B9CF RID: 47567
		// (get) Token: 0x0602A56B RID: 173419 RVA: 0x005C6D95 File Offset: 0x005C4F95
		// (set) Token: 0x0602A56C RID: 173420 RVA: 0x005C6D9D File Offset: 0x005C4F9D
		public byte NullMask { get; set; }

		// Token: 0x0602A56D RID: 173421 RVA: 0x005C6DA6 File Offset: 0x005C4FA6
		public IWaterBoxBigWeaponHookT()
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

using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055DF RID: 21983
	public class IMovementPointHookT
	{
		// Token: 0x1700A2A7 RID: 41639
		// (get) Token: 0x06024777 RID: 149367 RVA: 0x00508C8C File Offset: 0x00506E8C
		// (set) Token: 0x06024778 RID: 149368 RVA: 0x00508C94 File Offset: 0x00506E94
		public EHookInteractType Type { get; set; }

		// Token: 0x1700A2A8 RID: 41640
		// (get) Token: 0x06024779 RID: 149369 RVA: 0x00508C9D File Offset: 0x00506E9D
		// (set) Token: 0x0602477A RID: 149370 RVA: 0x00508CA5 File Offset: 0x00506EA5
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700A2A9 RID: 41641
		// (get) Token: 0x0602477B RID: 149371 RVA: 0x00508CAE File Offset: 0x00506EAE
		// (set) Token: 0x0602477C RID: 149372 RVA: 0x00508CB6 File Offset: 0x00506EB6
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700A2AA RID: 41642
		// (get) Token: 0x0602477D RID: 149373 RVA: 0x00508CBF File Offset: 0x00506EBF
		// (set) Token: 0x0602477E RID: 149374 RVA: 0x00508CC7 File Offset: 0x00506EC7
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700A2AB RID: 41643
		// (get) Token: 0x0602477F RID: 149375 RVA: 0x00508CD0 File Offset: 0x00506ED0
		// (set) Token: 0x06024780 RID: 149376 RVA: 0x00508CD8 File Offset: 0x00506ED8
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700A2AC RID: 41644
		// (get) Token: 0x06024781 RID: 149377 RVA: 0x00508CE1 File Offset: 0x00506EE1
		// (set) Token: 0x06024782 RID: 149378 RVA: 0x00508CE9 File Offset: 0x00506EE9
		public byte NullMask { get; set; }

		// Token: 0x06024783 RID: 149379 RVA: 0x00508CF2 File Offset: 0x00506EF2
		public IMovementPointHookT()
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

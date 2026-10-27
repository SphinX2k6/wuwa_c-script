using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FAB RID: 16299
	public class IPlotHandBookNodeT
	{
		// Token: 0x170071CF RID: 29135
		// (get) Token: 0x060174C0 RID: 95424 RVA: 0x0035BE41 File Offset: 0x0035A041
		// (set) Token: 0x060174C1 RID: 95425 RVA: 0x0035BE49 File Offset: 0x0035A049
		public string TidTip { get; set; }

		// Token: 0x170071D0 RID: 29136
		// (get) Token: 0x060174C2 RID: 95426 RVA: 0x0035BE52 File Offset: 0x0035A052
		// (set) Token: 0x060174C3 RID: 95427 RVA: 0x0035BE5A File Offset: 0x0035A05A
		public IFlowStateIndexT Flow { get; set; }

		// Token: 0x170071D1 RID: 29137
		// (get) Token: 0x060174C4 RID: 95428 RVA: 0x0035BE63 File Offset: 0x0035A063
		// (set) Token: 0x060174C5 RID: 95429 RVA: 0x0035BE6B File Offset: 0x0035A06B
		public bool IsHideUi { get; set; }

		// Token: 0x060174C6 RID: 95430 RVA: 0x0035BE74 File Offset: 0x0035A074
		public IPlotHandBookNodeT()
		{
			this.TidTip = null;
			this.Flow = null;
			this.IsHideUi = false;
		}
	}
}

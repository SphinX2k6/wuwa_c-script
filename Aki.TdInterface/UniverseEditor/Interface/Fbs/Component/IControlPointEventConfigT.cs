using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005587 RID: 21895
	public class IControlPointEventConfigT
	{
		// Token: 0x17009CCF RID: 40143
		// (get) Token: 0x06022D1F RID: 142623 RVA: 0x004CC0F5 File Offset: 0x004CA2F5
		// (set) Token: 0x06022D20 RID: 142624 RVA: 0x004CC0FD File Offset: 0x004CA2FD
		public int Index { get; set; }

		// Token: 0x17009CD0 RID: 40144
		// (get) Token: 0x06022D21 RID: 142625 RVA: 0x004CC106 File Offset: 0x004CA306
		// (set) Token: 0x06022D22 RID: 142626 RVA: 0x004CC10E File Offset: 0x004CA30E
		public List<IActionInfoT> LeftInEventActions { get; set; }

		// Token: 0x17009CD1 RID: 40145
		// (get) Token: 0x06022D23 RID: 142627 RVA: 0x004CC117 File Offset: 0x004CA317
		// (set) Token: 0x06022D24 RID: 142628 RVA: 0x004CC11F File Offset: 0x004CA31F
		public List<IActionInfoT> LeftOutEventActions { get; set; }

		// Token: 0x17009CD2 RID: 40146
		// (get) Token: 0x06022D25 RID: 142629 RVA: 0x004CC128 File Offset: 0x004CA328
		// (set) Token: 0x06022D26 RID: 142630 RVA: 0x004CC130 File Offset: 0x004CA330
		public List<IActionInfoT> RightInEventActions { get; set; }

		// Token: 0x17009CD3 RID: 40147
		// (get) Token: 0x06022D27 RID: 142631 RVA: 0x004CC139 File Offset: 0x004CA339
		// (set) Token: 0x06022D28 RID: 142632 RVA: 0x004CC141 File Offset: 0x004CA341
		public List<IActionInfoT> RightOutEventActions { get; set; }

		// Token: 0x17009CD4 RID: 40148
		// (get) Token: 0x06022D29 RID: 142633 RVA: 0x004CC14A File Offset: 0x004CA34A
		// (set) Token: 0x06022D2A RID: 142634 RVA: 0x004CC152 File Offset: 0x004CA352
		public byte NullMask { get; set; }

		// Token: 0x06022D2B RID: 142635 RVA: 0x004CC15B File Offset: 0x004CA35B
		public IControlPointEventConfigT()
		{
			this.Index = 0;
			this.LeftInEventActions = null;
			this.LeftOutEventActions = null;
			this.RightInEventActions = null;
			this.RightOutEventActions = null;
			this.NullMask = 0;
		}
	}
}

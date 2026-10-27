using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200697F RID: 27007
	public class IInteractActionsT
	{
		// Token: 0x1700C84D RID: 51277
		// (get) Token: 0x0602F2AE RID: 193198 RVA: 0x0066CE93 File Offset: 0x0066B093
		// (set) Token: 0x0602F2AF RID: 193199 RVA: 0x0066CE9B File Offset: 0x0066B09B
		public EInteractOption Type { get; set; }

		// Token: 0x1700C84E RID: 51278
		// (get) Token: 0x0602F2B0 RID: 193200 RVA: 0x0066CEA4 File Offset: 0x0066B0A4
		// (set) Token: 0x0602F2B1 RID: 193201 RVA: 0x0066CEAC File Offset: 0x0066B0AC
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x0602F2B2 RID: 193202 RVA: 0x0066CEB5 File Offset: 0x0066B0B5
		public IInteractActionsT()
		{
			this.Type = EInteractOption.Flow;
			this.Actions = null;
		}
	}
}

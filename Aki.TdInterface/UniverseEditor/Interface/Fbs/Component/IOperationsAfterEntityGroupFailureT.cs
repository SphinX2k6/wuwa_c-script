using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056AB RID: 22187
	public class IOperationsAfterEntityGroupFailureT
	{
		// Token: 0x1700A501 RID: 42241
		// (get) Token: 0x0602508E RID: 151694 RVA: 0x0051D1FD File Offset: 0x0051B3FD
		// (set) Token: 0x0602508F RID: 151695 RVA: 0x0051D205 File Offset: 0x0051B405
		public bool IsResetState { get; set; }

		// Token: 0x1700A502 RID: 42242
		// (get) Token: 0x06025090 RID: 151696 RVA: 0x0051D20E File Offset: 0x0051B40E
		// (set) Token: 0x06025091 RID: 151697 RVA: 0x0051D216 File Offset: 0x0051B416
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700A503 RID: 42243
		// (get) Token: 0x06025092 RID: 151698 RVA: 0x0051D21F File Offset: 0x0051B41F
		// (set) Token: 0x06025093 RID: 151699 RVA: 0x0051D227 File Offset: 0x0051B427
		public byte NullMask { get; set; }

		// Token: 0x06025094 RID: 151700 RVA: 0x0051D230 File Offset: 0x0051B430
		public IOperationsAfterEntityGroupFailureT()
		{
			this.IsResetState = false;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}

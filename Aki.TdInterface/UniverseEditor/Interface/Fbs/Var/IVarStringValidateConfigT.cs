using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B1B RID: 15131
	public class IVarStringValidateConfigT
	{
		// Token: 0x170067CF RID: 26575
		// (get) Token: 0x06014A8B RID: 84619 RVA: 0x00301A89 File Offset: 0x002FFC89
		// (set) Token: 0x06014A8C RID: 84620 RVA: 0x00301A91 File Offset: 0x002FFC91
		public EVar Type { get; set; }

		// Token: 0x170067D0 RID: 26576
		// (get) Token: 0x06014A8D RID: 84621 RVA: 0x00301A9A File Offset: 0x002FFC9A
		// (set) Token: 0x06014A8E RID: 84622 RVA: 0x00301AA2 File Offset: 0x002FFCA2
		public List<string> ValidList { get; set; }

		// Token: 0x170067D1 RID: 26577
		// (get) Token: 0x06014A8F RID: 84623 RVA: 0x00301AAB File Offset: 0x002FFCAB
		// (set) Token: 0x06014A90 RID: 84624 RVA: 0x00301AB3 File Offset: 0x002FFCB3
		public byte NullMask { get; set; }

		// Token: 0x06014A91 RID: 84625 RVA: 0x00301ABC File Offset: 0x002FFCBC
		public IVarStringValidateConfigT()
		{
			this.Type = EVar.Boolean;
			this.ValidList = null;
			this.NullMask = 0;
		}
	}
}

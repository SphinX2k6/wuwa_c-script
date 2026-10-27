using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005663 RID: 22115
	public class INpcStandbyShowModeT
	{
		// Token: 0x1700A3DF RID: 41951
		// (get) Token: 0x06024C8D RID: 150669 RVA: 0x00513581 File Offset: 0x00511781
		// (set) Token: 0x06024C8E RID: 150670 RVA: 0x00513589 File Offset: 0x00511789
		public ENpcStandbyShowMode Type { get; set; }

		// Token: 0x1700A3E0 RID: 41952
		// (get) Token: 0x06024C8F RID: 150671 RVA: 0x00513592 File Offset: 0x00511792
		// (set) Token: 0x06024C90 RID: 150672 RVA: 0x0051359A File Offset: 0x0051179A
		public List<INpcLookAtConfigT> LookAtConfigs { get; set; }

		// Token: 0x1700A3E1 RID: 41953
		// (get) Token: 0x06024C91 RID: 150673 RVA: 0x005135A3 File Offset: 0x005117A3
		// (set) Token: 0x06024C92 RID: 150674 RVA: 0x005135AB File Offset: 0x005117AB
		public byte NullMask { get; set; }

		// Token: 0x06024C93 RID: 150675 RVA: 0x005135B4 File Offset: 0x005117B4
		public INpcStandbyShowModeT()
		{
			this.Type = ENpcStandbyShowMode.Finite;
			this.LookAtConfigs = null;
			this.NullMask = 0;
		}
	}
}

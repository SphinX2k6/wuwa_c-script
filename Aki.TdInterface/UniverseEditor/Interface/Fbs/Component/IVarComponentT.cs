using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B06 RID: 23302
	public class IVarComponentT
	{
		// Token: 0x1700AFCE RID: 45006
		// (get) Token: 0x06027CA4 RID: 162980 RVA: 0x00579019 File Offset: 0x00577219
		// (set) Token: 0x06027CA5 RID: 162981 RVA: 0x00579021 File Offset: 0x00577221
		public bool Disabled { get; set; }

		// Token: 0x1700AFCF RID: 45007
		// (get) Token: 0x06027CA6 RID: 162982 RVA: 0x0057902A File Offset: 0x0057722A
		// (set) Token: 0x06027CA7 RID: 162983 RVA: 0x00579032 File Offset: 0x00577232
		public List<IVarDefineT> Vars { get; set; }

		// Token: 0x1700AFD0 RID: 45008
		// (get) Token: 0x06027CA8 RID: 162984 RVA: 0x0057903B File Offset: 0x0057723B
		// (set) Token: 0x06027CA9 RID: 162985 RVA: 0x00579043 File Offset: 0x00577243
		public byte NullMask { get; set; }

		// Token: 0x06027CAA RID: 162986 RVA: 0x0057904C File Offset: 0x0057724C
		public IVarComponentT()
		{
			this.Disabled = false;
			this.Vars = null;
			this.NullMask = 0;
		}
	}
}

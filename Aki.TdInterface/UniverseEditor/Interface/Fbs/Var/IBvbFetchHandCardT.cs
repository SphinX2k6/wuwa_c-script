using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A55 RID: 14933
	public class IBvbFetchHandCardT
	{
		// Token: 0x1700665F RID: 26207
		// (get) Token: 0x060143BA RID: 82874 RVA: 0x002F4BFF File Offset: 0x002F2DFF
		// (set) Token: 0x060143BB RID: 82875 RVA: 0x002F4C07 File Offset: 0x002F2E07
		public ESystemVarName Type { get; set; }

		// Token: 0x17006660 RID: 26208
		// (get) Token: 0x060143BC RID: 82876 RVA: 0x002F4C10 File Offset: 0x002F2E10
		// (set) Token: 0x060143BD RID: 82877 RVA: 0x002F4C18 File Offset: 0x002F2E18
		public IBvbCardFilterGroupT Condition { get; set; }

		// Token: 0x060143BE RID: 82878 RVA: 0x002F4C21 File Offset: 0x002F2E21
		public IBvbFetchHandCardT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
			this.Condition = null;
		}
	}
}

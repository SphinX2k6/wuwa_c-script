using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E30 RID: 15920
	public class IBvbFetchHandCardT
	{
		// Token: 0x17006B8F RID: 27535
		// (get) Token: 0x060156D6 RID: 87766 RVA: 0x00317DEB File Offset: 0x00315FEB
		// (set) Token: 0x060156D7 RID: 87767 RVA: 0x00317DF3 File Offset: 0x00315FF3
		public ESystemVarName Type { get; set; }

		// Token: 0x17006B90 RID: 27536
		// (get) Token: 0x060156D8 RID: 87768 RVA: 0x00317DFC File Offset: 0x00315FFC
		// (set) Token: 0x060156D9 RID: 87769 RVA: 0x00317E04 File Offset: 0x00316004
		public IBvbCardFilterGroupT Condition { get; set; }

		// Token: 0x060156DA RID: 87770 RVA: 0x00317E0D File Offset: 0x0031600D
		public IBvbFetchHandCardT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
			this.Condition = null;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E2A RID: 15914
	public class IBvbCustomSystemVarIntT
	{
		// Token: 0x17006B86 RID: 27526
		// (get) Token: 0x060156AC RID: 87724 RVA: 0x003179E8 File Offset: 0x00315BE8
		// (set) Token: 0x060156AD RID: 87725 RVA: 0x003179F0 File Offset: 0x00315BF0
		public ESystemVarName Type { get; set; }

		// Token: 0x17006B87 RID: 27527
		// (get) Token: 0x060156AE RID: 87726 RVA: 0x003179F9 File Offset: 0x00315BF9
		// (set) Token: 0x060156AF RID: 87727 RVA: 0x00317A01 File Offset: 0x00315C01
		public string VarName { get; set; }

		// Token: 0x17006B88 RID: 27528
		// (get) Token: 0x060156B0 RID: 87728 RVA: 0x00317A0A File Offset: 0x00315C0A
		// (set) Token: 0x060156B1 RID: 87729 RVA: 0x00317A12 File Offset: 0x00315C12
		public string VarParams { get; set; }

		// Token: 0x060156B2 RID: 87730 RVA: 0x00317A1B File Offset: 0x00315C1B
		public IBvbCustomSystemVarIntT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
			this.VarName = null;
			this.VarParams = null;
		}
	}
}

using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ADF RID: 15071
	public class ISystemVarRefT
	{
		// Token: 0x17006765 RID: 26469
		// (get) Token: 0x06014884 RID: 84100 RVA: 0x002FDAE9 File Offset: 0x002FBCE9
		// (set) Token: 0x06014885 RID: 84101 RVA: 0x002FDAF1 File Offset: 0x002FBCF1
		public EVar Type { get; set; }

		// Token: 0x17006766 RID: 26470
		// (get) Token: 0x06014886 RID: 84102 RVA: 0x002FDAFA File Offset: 0x002FBCFA
		// (set) Token: 0x06014887 RID: 84103 RVA: 0x002FDB02 File Offset: 0x002FBD02
		public EVarRefSource Source { get; set; }

		// Token: 0x17006767 RID: 26471
		// (get) Token: 0x06014888 RID: 84104 RVA: 0x002FDB0B File Offset: 0x002FBD0B
		// (set) Token: 0x06014889 RID: 84105 RVA: 0x002FDB13 File Offset: 0x002FBD13
		public TSystemVarUnion Var { get; set; }

		// Token: 0x0601488A RID: 84106 RVA: 0x002FDB1C File Offset: 0x002FBD1C
		public ISystemVarRefT()
		{
			this.Type = EVar.Boolean;
			this.Source = EVarRefSource.Constant;
			this.Var = null;
		}
	}
}

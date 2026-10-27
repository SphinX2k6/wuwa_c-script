using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AD0 RID: 15056
	public class ISelfVarRefT
	{
		// Token: 0x17006749 RID: 26441
		// (get) Token: 0x060147BD RID: 83901 RVA: 0x002FBE55 File Offset: 0x002FA055
		// (set) Token: 0x060147BE RID: 83902 RVA: 0x002FBE5D File Offset: 0x002FA05D
		public EVar Type { get; set; }

		// Token: 0x1700674A RID: 26442
		// (get) Token: 0x060147BF RID: 83903 RVA: 0x002FBE66 File Offset: 0x002FA066
		// (set) Token: 0x060147C0 RID: 83904 RVA: 0x002FBE6E File Offset: 0x002FA06E
		public EVarRefSource Source { get; set; }

		// Token: 0x1700674B RID: 26443
		// (get) Token: 0x060147C1 RID: 83905 RVA: 0x002FBE77 File Offset: 0x002FA077
		// (set) Token: 0x060147C2 RID: 83906 RVA: 0x002FBE7F File Offset: 0x002FA07F
		public string Name { get; set; }

		// Token: 0x060147C3 RID: 83907 RVA: 0x002FBE88 File Offset: 0x002FA088
		public ISelfVarRefT()
		{
			this.Type = EVar.Boolean;
			this.Source = EVarRefSource.Constant;
			this.Name = null;
		}
	}
}

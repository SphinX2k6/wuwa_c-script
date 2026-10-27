using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007197 RID: 29079
	public class ISplinePointT
	{
		// Token: 0x1700D7FA RID: 55290
		// (get) Token: 0x060338F0 RID: 211184 RVA: 0x006F1B78 File Offset: 0x006EFD78
		// (set) Token: 0x060338F1 RID: 211185 RVA: 0x006F1B80 File Offset: 0x006EFD80
		public string Spline { get; set; }

		// Token: 0x1700D7FB RID: 55291
		// (get) Token: 0x060338F2 RID: 211186 RVA: 0x006F1B89 File Offset: 0x006EFD89
		// (set) Token: 0x060338F3 RID: 211187 RVA: 0x006F1B91 File Offset: 0x006EFD91
		public List<IVectorInfoT> Points { get; set; }

		// Token: 0x060338F4 RID: 211188 RVA: 0x006F1B9A File Offset: 0x006EFD9A
		public ISplinePointT()
		{
			this.Spline = null;
			this.Points = null;
		}
	}
}

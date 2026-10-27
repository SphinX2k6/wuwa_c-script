using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C3E RID: 15422
	public class IShapeTransformT
	{
		// Token: 0x17006A3F RID: 27199
		// (get) Token: 0x060154DF RID: 87263 RVA: 0x003155BA File Offset: 0x003137BA
		// (set) Token: 0x060154E0 RID: 87264 RVA: 0x003155C2 File Offset: 0x003137C2
		public IVectorInfoT Pos { get; set; }

		// Token: 0x17006A40 RID: 27200
		// (get) Token: 0x060154E1 RID: 87265 RVA: 0x003155CB File Offset: 0x003137CB
		// (set) Token: 0x060154E2 RID: 87266 RVA: 0x003155D3 File Offset: 0x003137D3
		public IVectorInfoT Rot { get; set; }

		// Token: 0x17006A41 RID: 27201
		// (get) Token: 0x060154E3 RID: 87267 RVA: 0x003155DC File Offset: 0x003137DC
		// (set) Token: 0x060154E4 RID: 87268 RVA: 0x003155E4 File Offset: 0x003137E4
		public IVectorInfoT Scale { get; set; }

		// Token: 0x060154E5 RID: 87269 RVA: 0x003155ED File Offset: 0x003137ED
		public IShapeTransformT()
		{
			this.Pos = null;
			this.Rot = null;
			this.Scale = null;
		}
	}
}

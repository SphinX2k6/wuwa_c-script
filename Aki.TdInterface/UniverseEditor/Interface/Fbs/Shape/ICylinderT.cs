using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004014 RID: 16404
	public class ICylinderT
	{
		// Token: 0x17006F3F RID: 28479
		// (get) Token: 0x060167A9 RID: 92073 RVA: 0x00337E43 File Offset: 0x00336043
		// (set) Token: 0x060167AA RID: 92074 RVA: 0x00337E4B File Offset: 0x0033604B
		public ERangeType Type { get; set; }

		// Token: 0x17006F40 RID: 28480
		// (get) Token: 0x060167AB RID: 92075 RVA: 0x00337E54 File Offset: 0x00336054
		// (set) Token: 0x060167AC RID: 92076 RVA: 0x00337E5C File Offset: 0x0033605C
		public IVectorInfoT Pos { get; set; }

		// Token: 0x17006F41 RID: 28481
		// (get) Token: 0x060167AD RID: 92077 RVA: 0x00337E65 File Offset: 0x00336065
		// (set) Token: 0x060167AE RID: 92078 RVA: 0x00337E6D File Offset: 0x0033606D
		public int Radius { get; set; }

		// Token: 0x17006F42 RID: 28482
		// (get) Token: 0x060167AF RID: 92079 RVA: 0x00337E76 File Offset: 0x00336076
		// (set) Token: 0x060167B0 RID: 92080 RVA: 0x00337E7E File Offset: 0x0033607E
		public int Height { get; set; }

		// Token: 0x060167B1 RID: 92081 RVA: 0x00337E87 File Offset: 0x00336087
		public ICylinderT()
		{
			this.Type = ERangeType.CircleRange;
			this.Pos = null;
			this.Radius = 0;
			this.Height = 0;
		}
	}
}

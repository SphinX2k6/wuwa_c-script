using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C08 RID: 15368
	public class ICylinderT
	{
		// Token: 0x17006997 RID: 27031
		// (get) Token: 0x060152B3 RID: 86707 RVA: 0x003112BB File Offset: 0x0030F4BB
		// (set) Token: 0x060152B4 RID: 86708 RVA: 0x003112C3 File Offset: 0x0030F4C3
		public ERangeType Type { get; set; }

		// Token: 0x17006998 RID: 27032
		// (get) Token: 0x060152B5 RID: 86709 RVA: 0x003112CC File Offset: 0x0030F4CC
		// (set) Token: 0x060152B6 RID: 86710 RVA: 0x003112D4 File Offset: 0x0030F4D4
		public IVectorInfoT Pos { get; set; }

		// Token: 0x17006999 RID: 27033
		// (get) Token: 0x060152B7 RID: 86711 RVA: 0x003112DD File Offset: 0x0030F4DD
		// (set) Token: 0x060152B8 RID: 86712 RVA: 0x003112E5 File Offset: 0x0030F4E5
		public int Radius { get; set; }

		// Token: 0x1700699A RID: 27034
		// (get) Token: 0x060152B9 RID: 86713 RVA: 0x003112EE File Offset: 0x0030F4EE
		// (set) Token: 0x060152BA RID: 86714 RVA: 0x003112F6 File Offset: 0x0030F4F6
		public int Height { get; set; }

		// Token: 0x060152BB RID: 86715 RVA: 0x003112FF File Offset: 0x0030F4FF
		public ICylinderT()
		{
			this.Type = ERangeType.CircleRange;
			this.Pos = null;
			this.Radius = 0;
			this.Height = 0;
		}
	}
}

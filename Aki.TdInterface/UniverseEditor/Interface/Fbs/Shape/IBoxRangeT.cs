using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BF0 RID: 15344
	public class IBoxRangeT
	{
		// Token: 0x1700694E RID: 26958
		// (get) Token: 0x060151B3 RID: 86451 RVA: 0x0030EED4 File Offset: 0x0030D0D4
		// (set) Token: 0x060151B4 RID: 86452 RVA: 0x0030EEDC File Offset: 0x0030D0DC
		public ERangeType Type { get; set; }

		// Token: 0x1700694F RID: 26959
		// (get) Token: 0x060151B5 RID: 86453 RVA: 0x0030EEE5 File Offset: 0x0030D0E5
		// (set) Token: 0x060151B6 RID: 86454 RVA: 0x0030EEED File Offset: 0x0030D0ED
		public IVectorInfoT Pos { get; set; }

		// Token: 0x17006950 RID: 26960
		// (get) Token: 0x060151B7 RID: 86455 RVA: 0x0030EEF6 File Offset: 0x0030D0F6
		// (set) Token: 0x060151B8 RID: 86456 RVA: 0x0030EEFE File Offset: 0x0030D0FE
		public IVectorInfoT Size { get; set; }

		// Token: 0x17006951 RID: 26961
		// (get) Token: 0x060151B9 RID: 86457 RVA: 0x0030EF07 File Offset: 0x0030D107
		// (set) Token: 0x060151BA RID: 86458 RVA: 0x0030EF0F File Offset: 0x0030D10F
		public IVectorInfoT Rotator { get; set; }

		// Token: 0x060151BB RID: 86459 RVA: 0x0030EF18 File Offset: 0x0030D118
		public IBoxRangeT()
		{
			this.Type = ERangeType.CircleRange;
			this.Pos = null;
			this.Size = null;
			this.Rotator = null;
		}
	}
}

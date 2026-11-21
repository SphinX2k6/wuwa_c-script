using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200404D RID: 16461
	public class IShapeTransformT
	{
		// Token: 0x17006FF0 RID: 28656
		// (get) Token: 0x060169F3 RID: 92659 RVA: 0x0033C45A File Offset: 0x0033A65A
		// (set) Token: 0x060169F4 RID: 92660 RVA: 0x0033C462 File Offset: 0x0033A662
		public IVectorInfoT Pos { get; set; }

		// Token: 0x17006FF1 RID: 28657
		// (get) Token: 0x060169F5 RID: 92661 RVA: 0x0033C46B File Offset: 0x0033A66B
		// (set) Token: 0x060169F6 RID: 92662 RVA: 0x0033C473 File Offset: 0x0033A673
		public IVectorInfoT Rot { get; set; }

		// Token: 0x17006FF2 RID: 28658
		// (get) Token: 0x060169F7 RID: 92663 RVA: 0x0033C47C File Offset: 0x0033A67C
		// (set) Token: 0x060169F8 RID: 92664 RVA: 0x0033C484 File Offset: 0x0033A684
		public IVectorInfoT Scale { get; set; }

		// Token: 0x060169F9 RID: 92665 RVA: 0x0033C48D File Offset: 0x0033A68D
		public IShapeTransformT()
		{
			this.Pos = null;
			this.Rot = null;
			this.Scale = null;
		}
	}
}

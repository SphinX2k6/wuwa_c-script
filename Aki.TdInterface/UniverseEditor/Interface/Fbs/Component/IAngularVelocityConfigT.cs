using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053CB RID: 21451
	public class IAngularVelocityConfigT
	{
		// Token: 0x170097BC RID: 38844
		// (get) Token: 0x060217ED RID: 137197 RVA: 0x0049EA86 File Offset: 0x0049CC86
		// (set) Token: 0x060217EE RID: 137198 RVA: 0x0049EA8E File Offset: 0x0049CC8E
		public IRangedRandomT X { get; set; }

		// Token: 0x170097BD RID: 38845
		// (get) Token: 0x060217EF RID: 137199 RVA: 0x0049EA97 File Offset: 0x0049CC97
		// (set) Token: 0x060217F0 RID: 137200 RVA: 0x0049EA9F File Offset: 0x0049CC9F
		public IRangedRandomT Y { get; set; }

		// Token: 0x170097BE RID: 38846
		// (get) Token: 0x060217F1 RID: 137201 RVA: 0x0049EAA8 File Offset: 0x0049CCA8
		// (set) Token: 0x060217F2 RID: 137202 RVA: 0x0049EAB0 File Offset: 0x0049CCB0
		public IRangedRandomT Z { get; set; }

		// Token: 0x060217F3 RID: 137203 RVA: 0x0049EAB9 File Offset: 0x0049CCB9
		public IAngularVelocityConfigT()
		{
			this.X = null;
			this.Y = null;
			this.Z = null;
		}
	}
}

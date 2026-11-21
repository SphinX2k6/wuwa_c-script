using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004005 RID: 16389
	public class IBoxTriggerTipShapeT
	{
		// Token: 0x17006F15 RID: 28437
		// (get) Token: 0x0601670B RID: 91915 RVA: 0x0033680C File Offset: 0x00334A0C
		// (set) Token: 0x0601670C RID: 91916 RVA: 0x00336814 File Offset: 0x00334A14
		public ETriggerTipShape Type { get; set; }

		// Token: 0x17006F16 RID: 28438
		// (get) Token: 0x0601670D RID: 91917 RVA: 0x0033681D File Offset: 0x00334A1D
		// (set) Token: 0x0601670E RID: 91918 RVA: 0x00336825 File Offset: 0x00334A25
		public IVectorInfoT Center { get; set; }

		// Token: 0x17006F17 RID: 28439
		// (get) Token: 0x0601670F RID: 91919 RVA: 0x0033682E File Offset: 0x00334A2E
		// (set) Token: 0x06016710 RID: 91920 RVA: 0x00336836 File Offset: 0x00334A36
		public IVectorInfoT Size { get; set; }

		// Token: 0x17006F18 RID: 28440
		// (get) Token: 0x06016711 RID: 91921 RVA: 0x0033683F File Offset: 0x00334A3F
		// (set) Token: 0x06016712 RID: 91922 RVA: 0x00336847 File Offset: 0x00334A47
		public IVectorInfoT Rotator { get; set; }

		// Token: 0x06016713 RID: 91923 RVA: 0x00336850 File Offset: 0x00334A50
		public IBoxTriggerTipShapeT()
		{
			this.Type = ETriggerTipShape.Box;
			this.Center = null;
			this.Size = null;
			this.Rotator = null;
		}
	}
}

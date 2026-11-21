using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004002 RID: 16386
	public class IBoxTriggerShapeT
	{
		// Token: 0x17006F0C RID: 28428
		// (get) Token: 0x060166ED RID: 91885 RVA: 0x0033636C File Offset: 0x0033456C
		// (set) Token: 0x060166EE RID: 91886 RVA: 0x00336374 File Offset: 0x00334574
		public ETriggerShape Type { get; set; }

		// Token: 0x17006F0D RID: 28429
		// (get) Token: 0x060166EF RID: 91887 RVA: 0x0033637D File Offset: 0x0033457D
		// (set) Token: 0x060166F0 RID: 91888 RVA: 0x00336385 File Offset: 0x00334585
		public IVectorInfoT Center { get; set; }

		// Token: 0x17006F0E RID: 28430
		// (get) Token: 0x060166F1 RID: 91889 RVA: 0x0033638E File Offset: 0x0033458E
		// (set) Token: 0x060166F2 RID: 91890 RVA: 0x00336396 File Offset: 0x00334596
		public IVectorInfoT Size { get; set; }

		// Token: 0x17006F0F RID: 28431
		// (get) Token: 0x060166F3 RID: 91891 RVA: 0x0033639F File Offset: 0x0033459F
		// (set) Token: 0x060166F4 RID: 91892 RVA: 0x003363A7 File Offset: 0x003345A7
		public IVectorInfoT Rotator { get; set; }

		// Token: 0x060166F5 RID: 91893 RVA: 0x003363B0 File Offset: 0x003345B0
		public IBoxTriggerShapeT()
		{
			this.Type = ETriggerShape.Box;
			this.Center = null;
			this.Size = null;
			this.Rotator = null;
		}
	}
}
